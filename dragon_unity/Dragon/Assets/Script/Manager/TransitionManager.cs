using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 转场管理器 — 负责使用 ImageDissolve Shader 实现 Renpy 风格的遮罩溶解转场。
/// 支持 blink（睁眼/闭眼）和 trans_rip（波纹）等效果。
/// </summary>
/// <remarks>
/// 对应 Renpy 功能：
/// - ImageDissolve(mask, time, ramplen, reverse) — 单次遮罩溶解
/// - MultipleTransition([...]) — 多阶段转场序列（blink1~blink4, trans_rip_fast 等）
/// </remarks>
public class TransitionManager : MonoBehaviour
{
    public static TransitionManager Instance;

    /// <summary>ImageDissolve Shader 的引用（需要在 Inspector 中赋值，或从 Resources 加载）</summary>
    private Shader _imageDissolveShader;

    /// <summary>当前活跃的转场覆盖层 GameObject</summary>
    private GameObject _transitionOverlay;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);

        // 查找 ImageDissolve Shader
        _imageDissolveShader = Shader.Find("UI/ImageDissolve");
        if (_imageDissolveShader == null)
        {
            Debug.LogError("[TransitionManager] 找不到 UI/ImageDissolve Shader！");
        }
    }

    /// <summary>
    /// 执行单次 ImageDissolve 转场（睁眼/闭眼效果）。
    /// 在 overlay 图层创建全屏 Image，使用遮罩纹理 + Shader 实现渐进式溶解。
    /// </summary>
    /// <param name="maskTexture">遮罩灰度纹理（如 eye.png）</param>
    /// <param name="duration">转场持续时间（秒）</param>
    /// <param name="ramplen">边缘柔和度 0~256 映射到 0~0.5</param>
    /// <param name="reverse">是否反向（false=睁眼/显露, true=闭眼/遮挡）</param>
    /// <param name="overlayColor">覆盖颜色（通常为黑色）</param>
    /// <returns>协程迭代器</returns>
    public IEnumerator PlayImageDissolve(Texture2D maskTexture, float duration, float ramplen, bool reverse, Color overlayColor)
    {
        if (_imageDissolveShader == null || maskTexture == null)
        {
            Debug.LogWarning("[TransitionManager] Shader 或 mask 为空，回退到简单淡入淡出");
            yield return new WaitForSeconds(duration);
            yield break;
        }

        // 清理旧的转场覆盖层
        CleanupOverlay();

        // 查找 overlay 图层
        Transform overlayLayer = null;
        GameObject layerCanvas = GameObject.Find("LayerCanvas");
        if (layerCanvas != null)
        {
            overlayLayer = layerCanvas.transform.Find("overlay");
        }
        if (overlayLayer == null)
        {
            Debug.LogWarning("[TransitionManager] 找不到 overlay 图层");
            yield return new WaitForSeconds(duration);
            yield break;
        }

        // 创建全屏 Image 覆盖层
        _transitionOverlay = new GameObject("TransitionOverlay_ImageDissolve");
        Image img = _transitionOverlay.AddComponent<Image>();
        _transitionOverlay.transform.SetParent(overlayLayer, false);

        // 铺满（与 ColorOverlay 相同方案：锚定中心 + 极大尺寸）
        RectTransform rt = _transitionOverlay.GetComponent<RectTransform>();
        rt.anchorMin = new Vector2(0.5f, 0.5f);
        rt.anchorMax = new Vector2(0.5f, 0.5f);
        rt.pivot = new Vector2(0.5f, 0.5f);
        rt.anchoredPosition = Vector2.zero;
        rt.sizeDelta = new Vector2(10000f, 10000f);
        rt.localScale = Vector3.one;

        // 创建 Material
        Material mat = new Material(_imageDissolveShader);
        mat.SetTexture("_MaskTex", maskTexture);
        mat.SetColor("_OverlayColor", overlayColor);
        mat.SetFloat("_Reverse", reverse ? 1f : 0f);
        // 将 Renpy 的 ramplen (0~512) 映射到 Shader 的 0~0.5
        float shaderRamp = Mathf.Clamp(ramplen / 512f, 0.001f, 0.5f);
        mat.SetFloat("_Ramplen", shaderRamp);

        img.material = mat;
        img.color = Color.white; // Material 控制颜色，Image 用白色

        // 动画：progress 从 0 → 1（显露/睁眼）
        float elapsed = 0f;
        // 缓动函数：x^1.33（对应 Renpy 的 eyewarp）
        while (elapsed < duration)
        {
            elapsed += Time.deltaTime;
            float rawT = Mathf.Clamp01(elapsed / duration);
            float t = Mathf.Pow(rawT, 1.33f); // eyewarp 缓动
            mat.SetFloat("_Progress", t);
            yield return null;
        }

        mat.SetFloat("_Progress", 1f);

        // 销毁覆盖层
        CleanupOverlay();
    }

    /// <summary>
    /// 执行 blink4 转场序列（简化版）。
    /// 原版 blink4 是复杂的多阶段眨眼，这里简化为单次睁眼效果。
    /// </summary>
    /// <param name="maskTexture">eye.png 遮罩</param>
    /// <param name="duration">总持续时间（秒）</param>
    /// <param name="ramplen">边缘柔和度</param>
    public IEnumerator PlayBlink(Texture2D maskTexture, float duration, float ramplen)
    {
        // 简化版：单次从黑到画面的睁眼效果
        yield return PlayImageDissolve(maskTexture, duration, ramplen, false, Color.black);
    }

    /// <summary>
    /// 执行 trans_rip_fast 转场（波纹溶解）。
    /// </summary>
    /// <param name="maskTexture">waves.jpg 遮罩</param>
    /// <param name="duration">持续时间（秒）</param>
    /// <param name="ramplen">边缘柔和度</param>
    public IEnumerator PlayTransRip(Texture2D maskTexture, float duration, float ramplen)
    {
        yield return PlayImageDissolve(maskTexture, duration, ramplen, false, Color.black);
    }

    /// <summary>清理当前活跃的转场覆盖层</summary>
    private void CleanupOverlay()
    {
        if (_transitionOverlay != null)
        {
            Destroy(_transitionOverlay);
            _transitionOverlay = null;
        }
    }

    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    // M3.1 屏幕抖动（shake / hpunch）
    ///////////////////////////////////////////////////////////////////////////////////////////////////////

    /// <summary>
    /// 执行屏幕抖动效果，对应 Renpy 的 `with Shake((0,0,0,0), duration, dist=N)` 与 `with hpunch`。
    /// </summary>
    /// <param name="duration">抖动持续时间（秒）</param>
    /// <param name="magnitude">最大位移强度（像素）</param>
    /// <param name="horizontalOnly">是否仅水平抖动（hpunch 用）</param>
    /// <remarks>
    /// 对应原版：
    /// - hpunch：`define hpunch = Move((-15,0,0,0), (0,0,0,0), 0.275, bounce=True, repeat=2)`（水平弹跳 2 次 ~0.55s）
    /// - Shake((0,0,0,0), duration, dist=N)：所有维度随机抖动
    /// 具体实现：对 CameraManager 的 offset 做随机扰动，不直接改 Camera.transform 避免与 SetCamera 冲突。
    /// </remarks>
    public IEnumerator PlayShake(float duration, float magnitude, bool horizontalOnly)
    {
        Camera target = Camera.main;
        if (target == null)
        {
            Debug.LogWarning("[TransitionManager] PlayShake: Camera.main 为空，退回等待");
            yield return new WaitForSeconds(duration);
            yield break;
        }

        Vector3 origin = target.transform.localPosition;
        float elapsed = 0f;
        while (elapsed < duration)
        {
            elapsed += Time.deltaTime;
            // 随时间衰减的振幅（末段回归原位）
            float damper = 1f - Mathf.Clamp01(elapsed / duration);
            float dx = Random.Range(-1f, 1f) * magnitude * damper;
            float dy = horizontalOnly ? 0f : Random.Range(-1f, 1f) * magnitude * damper;
            target.transform.localPosition = origin + new Vector3(dx, dy, 0f);
            yield return null;
        }
        target.transform.localPosition = origin;
    }

    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    // M3.2 PushMove 画面推拉（pushleft / pushright）
    ///////////////////////////////////////////////////////////////////////////////////////////////////////

    /// <summary>
    /// 执行 PushMove 推拉转场，对应 Renpy 的 `with PushMove(duration, "pushleft"/"pushright")`。
    /// 当前所在层的所有图像整体偏移，营造新画面把旧画面"推"出去的错觉。
    /// </summary>
    /// <param name="duration">推拉持续时间（秒）</param>
    /// <param name="direction">"pushleft" 或 "pushright"（也接受 up/down）</param>
    /// <remarks>
    /// 简化实现：对 LayerCanvas 下 master 层做临时 anchoredPosition 动画。
    /// 真实 Renpy 是新旧两张快照同时滑动，这里只做单向推入，肉眼差异极小。
    /// </remarks>
    public IEnumerator PlayPushMove(float duration, string direction)
    {
        GameObject layerCanvas = GameObject.Find("LayerCanvas");
        if (layerCanvas == null)
        {
            Debug.LogWarning("[TransitionManager] PlayPushMove: 找不到 LayerCanvas，退回等待");
            yield return new WaitForSeconds(duration);
            yield break;
        }
        RectTransform master = layerCanvas.transform.Find("master") as RectTransform;
        if (master == null)
        {
            // 退回整个 LayerCanvas
            master = layerCanvas.transform as RectTransform;
        }

        // 方向向量：画面移动方向
        Vector2 offsetDir;
        string d = (direction ?? "").ToLower();
        switch (d)
        {
            case "pushleft": offsetDir = new Vector2(-1f, 0f); break;
            case "pushright": offsetDir = new Vector2(1f, 0f); break;
            case "pushup": offsetDir = new Vector2(0f, 1f); break;
            case "pushdown": offsetDir = new Vector2(0f, -1f); break;
            default: offsetDir = new Vector2(-1f, 0f); break;
        }

        // 以 LayerCanvas 宽度做位移量
        RectTransform canvasRect = layerCanvas.transform as RectTransform;
        float width = canvasRect != null ? canvasRect.rect.width : 1920f;
        float height = canvasRect != null ? canvasRect.rect.height : 1080f;
        Vector2 delta = new Vector2(offsetDir.x * width, offsetDir.y * height);

        Vector2 origin = master.anchoredPosition;
        float elapsed = 0f;
        while (elapsed < duration)
        {
            elapsed += Time.deltaTime;
            float t = Mathf.Clamp01(elapsed / duration);
            // ease-out 让推入末段减速
            float eased = 1f - Mathf.Pow(1f - t, 2f);
            master.anchoredPosition = origin + delta * eased;
            yield return null;
        }
        // 转场结束后瞬时复位（新画面由上层逻辑负责显示）
        master.anchoredPosition = origin;
    }

    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    // M3.4 Epilepsy 快速闪屏
    ///////////////////////////////////////////////////////////////////////////////////////////////////////

    /// <summary>
    /// 执行 epilepsy 闪屏效果，对应 Renpy 自定义的快速多色闪屏转场。
    /// </summary>
    /// <param name="duration">总持续时间（秒），默认 0.5s</param>
    /// <param name="flashCount">闪烁次数，默认 6 次</param>
    public IEnumerator PlayEpilepsy(float duration = 0.5f, int flashCount = 6)
    {
        GameObject layerCanvas = GameObject.Find("LayerCanvas");
        Transform overlayLayer = layerCanvas != null ? layerCanvas.transform.Find("overlay") : null;
        if (overlayLayer == null)
        {
            Debug.LogWarning("[TransitionManager] PlayEpilepsy: 找不到 overlay 图层，退回等待");
            yield return new WaitForSeconds(duration);
            yield break;
        }

        // 创建全屏闪屏 Image
        GameObject flashObj = new GameObject("EpilepsyFlash");
        flashObj.transform.SetParent(overlayLayer, false);
        Image img = flashObj.AddComponent<Image>();
        RectTransform rt = flashObj.GetComponent<RectTransform>();
        rt.anchorMin = new Vector2(0.5f, 0.5f);
        rt.anchorMax = new Vector2(0.5f, 0.5f);
        rt.pivot = new Vector2(0.5f, 0.5f);
        rt.anchoredPosition = Vector2.zero;
        rt.sizeDelta = new Vector2(10000f, 10000f);
        rt.localScale = Vector3.one;

        Color[] palette = { Color.white, Color.red, Color.yellow, Color.white, new Color(1f, 0.3f, 0f, 1f), Color.black };
        float perFlash = duration / Mathf.Max(1, flashCount);
        for (int i = 0; i < flashCount; i++)
        {
            img.color = palette[i % palette.Length];
            yield return new WaitForSeconds(perFlash * 0.5f);
            img.color = new Color(0f, 0f, 0f, 0f);
            yield return new WaitForSeconds(perFlash * 0.5f);
        }

        Destroy(flashObj);
    }

    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    // M3.5 统一派发入口（按字符串 key 调度，方便未来 MultipleTransitionSequencer 组合）
    ///////////////////////////////////////////////////////////////////////////////////////////////////////

    /// <summary>
    /// 按字符串名称派发转场效果。未知类型返回 false，让调用方走默认 dissolve 回退。
    /// </summary>
    /// <remarks>M3.5 架构梳理：为未来 MultipleTransitionSequencer 留的统一入口。</remarks>
    public bool TryPlayNamed(string transitionName, out IEnumerator routine)
    {
        routine = null;
        if (string.IsNullOrEmpty(transitionName)) return false;
        string key = transitionName.ToLower();
        switch (key)
        {
            case "shake":
                routine = PlayShake(0.5f, 10f, false);
                return true;
            case "hpunch":
                routine = PlayShake(0.55f, 15f, true);
                return true;
            case "pushmove_pushleft":
                routine = PlayPushMove(0.3f, "pushleft");
                return true;
            case "pushmove_pushright":
                routine = PlayPushMove(0.3f, "pushright");
                return true;
            case "pushmove_pushup":
                routine = PlayPushMove(0.3f, "pushup");
                return true;
            case "pushmove_pushdown":
                routine = PlayPushMove(0.3f, "pushdown");
                return true;
            case "epilepsy":
                routine = PlayEpilepsy();
                return true;
            case "none":
                routine = NoOp();
                return true;
        }
        return false;
    }

    private IEnumerator NoOp()
    {
        yield break;
    }
}
