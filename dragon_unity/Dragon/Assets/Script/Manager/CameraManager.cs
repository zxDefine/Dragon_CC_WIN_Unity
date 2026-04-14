using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 相机管理器 — 管理主相机的状态参数，对应 Renpy 的 camera: ATL 语句。
/// 支持即时参数应用（sameLine）和并行动画通道（parallel_0/1/2/3）。
/// </summary>
/// <remarks>
/// 对应 Renpy 功能：camera: ATL 语句中的 perspective/anchor/xpos/ypos/zpos/zoom/blur 参数，
/// 以及 parallel: 子块中的关键帧序列动画（xoffset/yoffset 震动、zpos 推拉等）。
/// Renpy camera 是非阻塞的——动画在后台运行，剧情继续推进。
/// </remarks>
public class CameraManager : MonoBehaviour
{
    public static CameraManager Instance;

    // ——— 相机状态参数（对应 Renpy camera ATL 的各项属性） ———

    /// <summary>是否启用透视模式（M1 暂存储不实现）</summary>
    private bool _perspective = true;

    /// <summary>相机锚点（M1 暂存储不实现）</summary>
    private Vector2 _anchor = Vector2.zero;

    /// <summary>相机 X 轴绝对位置</summary>
    private float _xpos = 0f;

    /// <summary>相机 Y 轴绝对位置</summary>
    private float _ypos = 0f;

    /// <summary>相机 Z 轴位置（M1 暂存储不实现 3D 透视效果）</summary>
    private float _zpos = 0f;

    /// <summary>X 轴偏移量（用于震动效果，与 xpos 叠加）</summary>
    private float _xoffset = 0f;

    /// <summary>Y 轴偏移量（用于震动效果，与 ypos 叠加）</summary>
    private float _yoffset = 0f;

    /// <summary>缩放倍率，1 为默认大小，大于 1 为放大（通过 orthographicSize 实现）</summary>
    private float _zoom = 1f;

    /// <summary>模糊程度（M1 暂存储不实现视觉效果）</summary>
    private float _blur = 0f;

    /// <summary>默认的 orthographicSize，在 Awake 时从主相机读取</summary>
    private float _defaultOrthoSize = 5f;

    /// <summary>相机初始位置，用于计算偏移</summary>
    private Vector3 _defaultPosition;

    /// <summary>跟踪当前运行中的 parallel 通道协程，key 为通道序号（0/1/2/3）</summary>
    private Dictionary<int, Coroutine> _parallelCoroutines = new Dictionary<int, Coroutine>();

    /// <summary>
    /// 已知但 M1 阶段未实现的相机字段（决策 5.6 方案 B+C）。
    /// 记录每个字段首次出现时输出一次 Warning，后续相同字段不再重复输出，避免日志刷屏。
    /// 同时通过 GetUnimplementedReport() 提供完整清单供 M3 阶段实现参考。
    /// </summary>
    private static HashSet<string> _warnedUnimplementedFields = new HashSet<string>();

    /// <summary>已知的未实现字段清单（M1 阶段不产生视觉效果）</summary>
    private static readonly HashSet<string> UnimplementedFieldNames = new HashSet<string>
    {
        "perspective", "glDepth", "gl_depth", "anchor", "zpos", "blur", "subpixel",
    };

    // ——— 单例初始化 ———

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject); // 防止重复
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject); // 保持场景中唯一存在

        // 记录主相机的默认参数，用于后续偏移计算
        Camera cam = Camera.main;
        if (cam != null)
        {
            _defaultOrthoSize = cam.orthographicSize;
            _defaultPosition = cam.transform.position;
        }
    }

    /// <summary>
    /// 解析单个 SameLineParamData 中的相机参数并应用到当前状态（即时切换，无动画）。
    /// </summary>
    /// <param name="paramData">包含相机参数键值对的数据对象</param>
    /// <remarks>
    /// 对应 Renpy：camera: 块内直接出现的属性（非 parallel 子块内）。
    /// 参数名与 Renpy ATL 属性名一致：perspective/anchor/xpos/ypos/zpos/xoffset/yoffset/zoom/blur。
    /// </remarks>
    public void ApplyCameraState(SameLineParamData paramData)
    {
        if (paramData == null || paramData.paramDict == null) return;

        Dictionary<string, object> dict = paramData.paramDict;

        // 逐个解析参数并更新内部状态
        if (dict.TryGetValue("perspective", out object perspVal))
        {
            _perspective = ConvertToBool(perspVal);
            WarnUnimplementedOnce("perspective");
        }

        // 兼容两种键名：anchor / gl_depth / glDepth
        if (dict.TryGetValue("gl_depth", out object glDepthVal) || dict.TryGetValue("glDepth", out glDepthVal))
        {
            WarnUnimplementedOnce("gl_depth");
        }

        if (dict.TryGetValue("anchor", out object anchorVal))
        {
            if (anchorVal is Vector2 vec2) _anchor = vec2;
            WarnUnimplementedOnce("anchor");
        }

        if (dict.TryGetValue("xpos", out object xVal))
            _xpos = ConvertToFloat(xVal);

        if (dict.TryGetValue("ypos", out object yVal))
            _ypos = ConvertToFloat(yVal);

        if (dict.TryGetValue("zpos", out object zVal))
        {
            _zpos = ConvertToFloat(zVal);
            WarnUnimplementedOnce("zpos");
        }

        if (dict.TryGetValue("xoffset", out object xoffVal))
            _xoffset = ConvertToFloat(xoffVal);

        if (dict.TryGetValue("yoffset", out object yoffVal))
            _yoffset = ConvertToFloat(yoffVal);

        if (dict.TryGetValue("zoom", out object zoomVal))
            _zoom = ConvertToFloat(zoomVal);

        if (dict.TryGetValue("blur", out object blurVal))
        {
            _blur = ConvertToFloat(blurVal);
            WarnUnimplementedOnce("blur");
        }

        // subpixel 仅为渲染标记，不影响相机状态
        if (dict.ContainsKey("subpixel"))
            WarnUnimplementedOnce("subpixel");

        // 将状态应用到主相机
        ApplyToCamera();
    }

    /// <summary>
    /// 对已知未实现的相机字段输出一次 Warning 日志，后续相同字段不再重复输出。
    /// 决策 5.6 方案 B+C：首次出现时 Warning 提醒开发者，同时记录到未实现清单供 M3 阶段参考。
    /// </summary>
    /// <param name="fieldName">字段名</param>
    private void WarnUnimplementedOnce(string fieldName)
    {
        if (!UnimplementedFieldNames.Contains(fieldName)) return;
        if (_warnedUnimplementedFields.Contains(fieldName)) return;

        _warnedUnimplementedFields.Add(fieldName);
        Debug.LogWarning($"[CameraManager] 字段 '{fieldName}' 在 M1 阶段未实现视觉效果（仅存储），归入 M3 阶段实现。此警告仅输出一次。");
    }

    /// <summary>
    /// 获取所有未实现的相机字段清单（M3 阶段实现时参考用）。
    /// </summary>
    /// <returns>已在运行时遇到过的未实现字段名列表</returns>
    public static IEnumerable<string> GetUnimplementedReport()
    {
        return _warnedUnimplementedFields;
    }

    /// <summary>
    /// 启动一个 parallel 通道的关键帧动画序列（非阻塞）。
    /// 如果指定通道上已有动画在运行，会先停止旧的再启动新的。
    /// </summary>
    /// <param name="slot">通道序号（0/1/2/3，对应 parallel_0/1/2/3）</param>
    /// <param name="keyframes">关键帧列表，每个关键帧是一个 SameLineParamData</param>
    /// <remarks>
    /// 对应 Renpy：camera: 块内的 parallel: 子块。
    /// 关键帧格式：
    ///   - 第 1 帧：仅属性值（初始值），如 {"xoffset", 0f}
    ///   - 后续帧：{"linear"/"easein"/"easeout"/"ease", duration} + {"属性名", 目标值}
    /// </remarks>
    public void StartParallelAnimation(int slot, List<SameLineParamData> keyframes)
    {
        if (keyframes == null || keyframes.Count == 0) return;

        // 停止该通道上已有的动画
        if (_parallelCoroutines.TryGetValue(slot, out Coroutine old) && old != null)
        {
            StopCoroutine(old);
        }

        // 启动新的协程
        _parallelCoroutines[slot] = StartCoroutine(PlayKeyframeSequence(slot, keyframes));
    }

    /// <summary>
    /// 停止所有正在运行的 parallel 动画。
    /// </summary>
    public void StopAllParallelAnimations()
    {
        foreach (var kv in _parallelCoroutines)
        {
            if (kv.Value != null) StopCoroutine(kv.Value);
        }
        _parallelCoroutines.Clear();
    }

    /// <summary>
    /// 按顺序执行关键帧序列，每个带 duration 的关键帧会在当前值与目标值之间插值动画。
    /// </summary>
    /// <param name="slot">通道序号（用于调试日志）</param>
    /// <param name="keyframes">关键帧列表</param>
    private IEnumerator PlayKeyframeSequence(int slot, List<SameLineParamData> keyframes)
    {
        for (int i = 0; i < keyframes.Count; i++)
        {
            SameLineParamData kf = keyframes[i];
            if (kf == null || kf.paramDict == null) continue;

            Dictionary<string, object> dict = kf.paramDict;

            // 尝试从关键帧中提取 duration 和缓动类型
            float duration = 0f;
            string easing = "linear";
            if (dict.TryGetValue("linear", out object linVal))
            {
                duration = ConvertToFloat(linVal);
                easing = "linear";
            }
            else if (dict.TryGetValue("easein", out object eiVal))
            {
                duration = ConvertToFloat(eiVal);
                easing = "easein";
            }
            else if (dict.TryGetValue("easeout", out object eoVal))
            {
                duration = ConvertToFloat(eoVal);
                easing = "easeout";
            }
            else if (dict.TryGetValue("ease", out object eVal))
            {
                duration = ConvertToFloat(eVal);
                easing = "ease";
            }

            if (duration <= 0f)
            {
                // 无 duration：即时设置（通常是第一个关键帧，即初始值）
                ApplyCameraState(kf);
                continue;
            }

            // 有 duration：在当前值与目标值之间插值
            yield return AnimateToKeyframe(dict, duration, easing);
        }

        // 动画完成，从跟踪字典移除
        _parallelCoroutines.Remove(slot);
    }

    /// <summary>
    /// 在指定时间内将当前相机状态插值到关键帧的目标值。
    /// 仅对关键帧中实际存在的属性进行插值，其他属性保持不变。
    /// </summary>
    /// <param name="targetDict">目标关键帧的参数字典</param>
    /// <param name="duration">动画持续时间（秒）</param>
    /// <param name="easing">缓动类型：linear/easein/easeout/ease</param>
    private IEnumerator AnimateToKeyframe(Dictionary<string, object> targetDict, float duration, string easing)
    {
        // 捕获起始值（仅对目标字典中存在的属性）
        float startXpos = _xpos, targetXpos = _xpos;
        float startYpos = _ypos, targetYpos = _ypos;
        float startZpos = _zpos, targetZpos = _zpos;
        float startXoff = _xoffset, targetXoff = _xoffset;
        float startYoff = _yoffset, targetYoff = _yoffset;
        float startZoom = _zoom, targetZoom = _zoom;
        float startBlur = _blur, targetBlur = _blur;

        bool animXpos = targetDict.TryGetValue("xpos", out object v1);
        if (animXpos) targetXpos = ConvertToFloat(v1);

        bool animYpos = targetDict.TryGetValue("ypos", out object v2);
        if (animYpos) targetYpos = ConvertToFloat(v2);

        bool animZpos = targetDict.TryGetValue("zpos", out object v3);
        if (animZpos) targetZpos = ConvertToFloat(v3);

        bool animXoff = targetDict.TryGetValue("xoffset", out object v4);
        if (animXoff) targetXoff = ConvertToFloat(v4);

        bool animYoff = targetDict.TryGetValue("yoffset", out object v5);
        if (animYoff) targetYoff = ConvertToFloat(v5);

        bool animZoom = targetDict.TryGetValue("zoom", out object v6);
        if (animZoom) targetZoom = ConvertToFloat(v6);

        bool animBlur = targetDict.TryGetValue("blur", out object v7);
        if (animBlur) targetBlur = ConvertToFloat(v7);

        // 插值动画主循环
        float elapsed = 0f;
        while (elapsed < duration)
        {
            elapsed += Time.deltaTime;
            float rawT = Mathf.Clamp01(elapsed / duration);
            float t = ApplyEasing(rawT, easing);

            if (animXpos) _xpos = Mathf.Lerp(startXpos, targetXpos, t);
            if (animYpos) _ypos = Mathf.Lerp(startYpos, targetYpos, t);
            if (animZpos) _zpos = Mathf.Lerp(startZpos, targetZpos, t);
            if (animXoff) _xoffset = Mathf.Lerp(startXoff, targetXoff, t);
            if (animYoff) _yoffset = Mathf.Lerp(startYoff, targetYoff, t);
            if (animZoom) _zoom = Mathf.Lerp(startZoom, targetZoom, t);
            if (animBlur) _blur = Mathf.Lerp(startBlur, targetBlur, t);

            ApplyToCamera();
            yield return null;
        }

        // 确保精确到达终点值
        if (animXpos) _xpos = targetXpos;
        if (animYpos) _ypos = targetYpos;
        if (animZpos) _zpos = targetZpos;
        if (animXoff) _xoffset = targetXoff;
        if (animYoff) _yoffset = targetYoff;
        if (animZoom) _zoom = targetZoom;
        if (animBlur) _blur = targetBlur;
        ApplyToCamera();
    }

    /// <summary>
    /// 应用缓动函数，将线性进度 t 映射为缓动后的进度。
    /// </summary>
    /// <param name="t">线性进度 [0,1]</param>
    /// <param name="easing">缓动类型：linear/easein/easeout/ease</param>
    /// <returns>缓动后的进度 [0,1]</returns>
    private float ApplyEasing(float t, string easing)
    {
        switch (easing)
        {
            case "linear":
                return t;
            case "easein":
                // Renpy easein: 慢起快止（1 - cos(t*π/2)）
                return 1f - Mathf.Cos(t * Mathf.PI * 0.5f);
            case "easeout":
                // Renpy easeout: 快起慢止（sin(t*π/2)）
                return Mathf.Sin(t * Mathf.PI * 0.5f);
            case "ease":
                // Renpy ease: 慢起慢止（(1 - cos(t*π)) / 2）
                return (1f - Mathf.Cos(t * Mathf.PI)) * 0.5f;
            default:
                return t;
        }
    }

    /// <summary>
    /// 将当前存储的相机状态即时应用到主相机。
    /// xpos+xoffset 影响 transform.position.x，ypos+yoffset 影响 transform.position.y，
    /// zoom 影响 orthographicSize。
    /// </summary>
    private void ApplyToCamera()
    {
        Camera cam = Camera.main;
        if (cam == null) return;

        // 位置偏移 = 默认位置 + xpos/ypos（绝对位置）+ xoffset/yoffset（震动偏移）
        Vector3 newPos = _defaultPosition;
        newPos.x += _xpos + _xoffset;
        newPos.y += _ypos + _yoffset;
        cam.transform.position = newPos;

        // zoom 缩放：orthographicSize 反比于 zoom（zoom 越大画面越大，orthoSize 越小）
        if (_zoom > 0f)
        {
            cam.orthographicSize = _defaultOrthoSize / _zoom;
        }
    }

    /// <summary>
    /// 重置相机状态到默认值，并停止所有正在运行的 parallel 动画。
    /// </summary>
    public void ResetCamera()
    {
        StopAllParallelAnimations();

        _perspective = true;
        _anchor = Vector2.zero;
        _xpos = 0f;
        _ypos = 0f;
        _zpos = 0f;
        _xoffset = 0f;
        _yoffset = 0f;
        _zoom = 1f;
        _blur = 0f;

        ApplyToCamera();
        Debug.Log("[CameraManager] 相机状态已重置为默认值。");
    }

    // ——— 工具方法 ———

    /// <summary>
    /// 将 object 安全转换为 float，支持 int/float/double/string 类型。
    /// </summary>
    private float ConvertToFloat(object val)
    {
        if (val is float f) return f;
        if (val is double d) return (float)d;
        if (val is int i) return i;
        if (val is long l) return l;
        if (val is string s && float.TryParse(s, out float parsed)) return parsed;

        Debug.LogWarning($"[CameraManager] 无法将值 '{val}' (类型: {val?.GetType()}) 转换为 float，使用默认值 0。");
        return 0f;
    }

    /// <summary>
    /// 将 object 安全转换为 bool。
    /// </summary>
    private bool ConvertToBool(object val)
    {
        if (val is bool b) return b;
        if (val is string s) return s.ToLower() == "true";

        Debug.LogWarning($"[CameraManager] 无法将值 '{val}' 转换为 bool，使用默认值 true。");
        return true;
    }
}
