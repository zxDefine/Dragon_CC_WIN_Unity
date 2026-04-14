using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Unity.VisualScripting;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using DG.Tweening;

public class ImageManager : MonoBehaviour
{
    public static ImageManager Instance;
    
    [Header("图层引用")]
    public Transform master0Layer;
    public Transform masterLayer; // show scene hide
    public Transform backgroundLayer; // 没被使用？
    public Transform middleLayer;
    public Transform forwardLayer;
    public Transform transientLayer; // 暂时图像（例如特效）
    public Transform screensLayer; // UI、对话框等
    public Transform overlayLayer;
    
    // 颜色覆盖层跟踪（用于 show black / show white 等）
    private Dictionary<string, GameObject> _colorOverlays = new Dictionary<string, GameObject>();

    // 单一贴图存储
    private Dictionary<string, AsyncOperationHandle<Texture2D>> _singleTextures = new Dictionary<string, AsyncOperationHandle<Texture2D>>();
    
    // 复合贴图存储
    private Dictionary<string, RenpyImage> _renpyImages = new Dictionary<string, RenpyImage>();
    
    // 通过角色名字绘制
    private Dictionary<string, GameObject> _charaImages = new Dictionary<string, GameObject>(); // 直接通过chara名字绘制（对话icon？）
    private RenpyImage _currentCharaImage;
    
    // 保存图层信息
    private Dictionary<string, List<GameObject>> _showImagesGameObject = new Dictionary<string, List<GameObject>>();
    private Dictionary<string, object> _showImagesOptions = new Dictionary<string, object>();

    void Awake()
    {
        if (Instance == null)
        {
            // 建立manager
            Instance = this;
            DontDestroyOnLoad(gameObject);
            
            // 读取json文件
            string jsonText = File.ReadAllText("Assets/RenpyResources/middle_data/image.json");
            // Dictionary<string, JObject> rootDict = JsonConvert.DeserializeObject<Dictionary<string, JObject>>(jsonText);
            JObject root = JObject.Parse(jsonText);

            // 遍历每个文件
            foreach (var kvp in root)
            {
                string name = kvp.Key;
                JToken data = kvp.Value;

                // Debug.Log($"\n解析模块: {name}");

                // 把数据传给专门的解析类处理
                RenpyImage image = new RenpyImage(name, data);
                _renpyImages[name] = image;
            }

            Debug.Log($"加载的image数量 -> {_renpyImages.Count}");
        }
        else
        {
            Destroy(gameObject);
        }
    }

    /// <summary>
    /// 显示图像并执行淡入 + 多路并行动画（决策 5.5 方案 C：支持 parallel_0~parallel_3 真正并行）。
    /// </summary>
    /// <param name="imageName">图像名或完整路径</param>
    /// <param name="layerName">目标图层（默认 master）</param>
    /// <param name="parts">Layered Image 部件列表</param>
    /// <param name="sameLine">即时应用的 ATL 属性</param>
    /// <param name="parallel">第 1 路 parallel 关键帧序列（历史上的 parallel 参数，等同 parallel_0）</param>
    /// <param name="parallel_1">第 2 路 parallel 关键帧序列</param>
    /// <param name="parallel_2">第 3 路 parallel 关键帧序列</param>
    /// <param name="parallel_3">第 4 路 parallel 关键帧序列</param>
    /// <remarks>
    /// 对应 Renpy: show X: ATL... parallel: ... parallel: ... parallel: ... parallel: ...
    /// 每个 parallel 块在后台独立运行，与剧情推进非阻塞。
    /// </remarks>
    public IEnumerator ShowWithFade(
        string imageName,
        string layerName,
        List<string> parts,
        List<SameLineParamData> sameLine,
        List<SameLineParamData> parallel,
        List<SameLineParamData> parallel_1 = null,
        List<SameLineParamData> parallel_2 = null,
        List<SameLineParamData> parallel_3 = null)
    {
        // 获得绘制信息
        Dictionary<string, object> options = GetDrawOptions(sameLine);
        
        // 如果是重复的图层
        if (_showImagesGameObject.ContainsKey(imageName))
        {
            // Debug.Log($"draw same image {imageName}");
            List<GameObject> oldGameObjects = _showImagesGameObject[imageName];
            object oldOptions = _showImagesOptions[imageName];

            // 新的option跟旧的option进行组合
            if (options != null && options.Count > 0)
            {
                // 替换成新的options
                if (oldOptions is Dictionary<string, object> oldOptionsDict)
                {
                    foreach (var pair in oldOptionsDict)
                    {
                        options[pair.Key] = pair.Value;
                    }
                }
            }
            else
            {
                // 用旧的options
                if (oldOptions is Dictionary<string, object> oldOptionsDict)
                {
                    options = oldOptionsDict;
                }
            }

            // 新的parts跟旧的parts进行组合
            if (parts != null && parts.Count > 0)
            {
                // 所有图层全部重新绘制
                DeleteShowImageInfo(imageName);
            }
            else
            {
                // 图层一样，但是用的新的options绘制
                foreach (GameObject g in oldGameObjects)
                {
                    CanvasGroup cg2 = g.GetComponent<CanvasGroup>();
                    RawImage image2 = g.GetComponent<RawImage>();
                    Texture2D te = (Texture2D)image2.texture;
            
                    // 设置绘制信息
                    DrawWithOptions(g, layerName, image2, te, options);
                    
                    // 处理动画
                    Debug.Log($"=== 重复图层开始处理动画 for {g.name} ===");
                    yield return ProcessAnimations(g, options, imageName);
                    Debug.Log($"=== 重复图层动画处理完成 for {g.name} ===");
                }
                yield break;
            }
        }

        // 如果是第一次绘制的贴图
        List<Texture2D> textures = new List<Texture2D>();
        // Debug.Log($"draw first image {imageName}");
        
        // 如果是单一贴图
        if (imageName.Contains("png") ||  imageName.Contains("jpg") || imageName.Contains("jpeg"))
        {
            textures.Add(GetSingleTexture(imageName));
        }
        else
        {
            // 从复合数据哪里获得
            if (!_renpyImages.ContainsKey(imageName))
            {
                Debug.LogError($"没有找到需要加载的image {imageName}");
            }
            else
            {
                RenpyImage characterImage = _renpyImages[imageName];
                textures = characterImage.GetCharaDrawTexture(parts);
            }
        }
        
        // 循环所有的texture
        List<GameObject> gos = new List<GameObject>();
        
        foreach (Texture2D t in textures)
        {
            // 检查贴图是否存在
            if (t == null)
            {
                Debug.LogError($"找不到贴图：{imageName}");
                continue;
            }

            // 根据image名字，设置新的RawImage
            GameObject go = new GameObject(t.name);
            gos.Add(go); // 保存用
            RawImage image = go.AddComponent<RawImage>();
            image.texture = t;
            image.rectTransform.sizeDelta = new Vector2(t.width, t.height);

            // 如果需要渐入的话，设置canvas为0
            CanvasGroup cg = go.AddComponent<CanvasGroup>();
            cg.alpha = 0f;

            // 设置新建的RawImage到对应的layer层
            Transform layer = GetLayerTransformByLayerName(layerName);
            go.transform.SetParent(layer, false);
            
            // 设置绘制信息
            DrawWithOptions(go, layerName, image, t, options);
            
            // 处理动画
            Debug.Log($"=== 开始处理动画 for {go.name} ===");
            yield return ProcessAnimations(go, options, imageName);
            Debug.Log($"=== 动画处理完成 for {go.name} ===");
            
            // 渐入
            float fadeDuration = 0.0f;
            if (options.ContainsKey("fade"))
            {
                fadeDuration = (float)options["fade"];
            }
            
            yield return FadeCanvasGroup(cg, 0f, 1f, fadeDuration);
        }
        
        // todo:临时

        // 保存图层信息
        AddShowImageInfo(imageName, gos, options, parts);

        // 决策 5.5 方案 C：为每路 parallel 启动独立的后台协程，真正实现多路并行动画
        // parallel（= parallel_0）、parallel_1、parallel_2、parallel_3 各自独立运行
        if (gos.Count > 0)
        {
            GameObject targetGo = gos[0]; // parallel 动画作用于第一个贴图（主贴图）
            if (parallel != null && parallel.Count > 0)
                StartCoroutine(RunParallelAnimationOnGameObject(targetGo, parallel, imageName, 0));
            if (parallel_1 != null && parallel_1.Count > 0)
                StartCoroutine(RunParallelAnimationOnGameObject(targetGo, parallel_1, imageName, 1));
            if (parallel_2 != null && parallel_2.Count > 0)
                StartCoroutine(RunParallelAnimationOnGameObject(targetGo, parallel_2, imageName, 2));
            if (parallel_3 != null && parallel_3.Count > 0)
                StartCoroutine(RunParallelAnimationOnGameObject(targetGo, parallel_3, imageName, 3));
        }

        yield return null;
    }

    /// <summary>
    /// 在指定 GameObject 上运行一路 parallel 关键帧动画（非阻塞后台协程）。
    /// 决策 5.5 方案 C：真正并行的多路动画支持。
    /// </summary>
    /// <param name="targetGo">目标 GameObject</param>
    /// <param name="keyframes">关键帧序列</param>
    /// <param name="imageName">图像名（用于调试日志）</param>
    /// <param name="slot">通道编号（0-3）</param>
    /// <remarks>
    /// 每个关键帧格式：
    ///   - 第 1 帧：仅属性值（初始值）
    ///   - 后续帧：{"linear"/"ease"/..., duration} + {属性名, 目标值}
    /// 支持属性：alpha、xoffset、yoffset、xpos、ypos、zoom、blur
    /// </remarks>
    private IEnumerator RunParallelAnimationOnGameObject(GameObject targetGo, List<SameLineParamData> keyframes, string imageName, int slot)
    {
        if (targetGo == null || keyframes == null || keyframes.Count == 0) yield break;

        CanvasGroup cg = targetGo.GetComponent<CanvasGroup>();
        RectTransform rt = targetGo.GetComponent<RectTransform>();
        if (rt == null) yield break;

        // 捕获当前状态作为起始值
        float currentAlpha = cg != null ? cg.alpha : 1f;
        Vector3 currentPos = rt.anchoredPosition3D;
        Vector3 currentScale = rt.localScale;

        for (int i = 0; i < keyframes.Count; i++)
        {
            if (targetGo == null) yield break; // 对象已被销毁
            SameLineParamData kf = keyframes[i];
            if (kf == null || kf.paramDict == null) continue;
            Dictionary<string, object> dict = kf.paramDict;

            // 提取 duration 和缓动类型
            float duration = 0f;
            string easing = "linear";
            if (dict.TryGetValue("linear", out object linVal)) { duration = ToFloat(linVal); easing = "linear"; }
            else if (dict.TryGetValue("easein", out object eiVal)) { duration = ToFloat(eiVal); easing = "easein"; }
            else if (dict.TryGetValue("easeout", out object eoVal)) { duration = ToFloat(eoVal); easing = "easeout"; }
            else if (dict.TryGetValue("ease", out object eVal)) { duration = ToFloat(eVal); easing = "ease"; }
            else if (dict.TryGetValue("pause", out object pVal))
            {
                // pause N - 纯等待
                float pt = ToFloat(pVal);
                if (pt > 0f) yield return new WaitForSeconds(pt);
                continue;
            }

            // 捕获目标值
            bool hasAlpha = dict.TryGetValue("alpha", out object aVal);
            bool hasXoff = dict.TryGetValue("xoffset", out object xoVal);
            bool hasYoff = dict.TryGetValue("yoffset", out object yoVal);
            bool hasXpos = dict.TryGetValue("xpos", out object xpVal);
            bool hasYpos = dict.TryGetValue("ypos", out object ypVal);
            bool hasZoom = dict.TryGetValue("zoom", out object zmVal);

            float targetAlpha = hasAlpha ? ToFloat(aVal) : currentAlpha;
            Vector3 targetPos = currentPos;
            Vector3 targetScale = currentScale;
            if (hasXoff) targetPos.x = currentPos.x + ToFloat(xoVal);
            if (hasYoff) targetPos.y = currentPos.y + ToFloat(yoVal);
            if (hasXpos) targetPos.x = ToFloat(xpVal);
            if (hasYpos) targetPos.y = ToFloat(ypVal);
            if (hasZoom) { float z = ToFloat(zmVal); targetScale = new Vector3(z, z, 1f); }

            if (duration <= 0f)
            {
                // 初始帧：直接设置
                if (hasAlpha && cg != null) cg.alpha = targetAlpha;
                if (hasXoff || hasYoff || hasXpos || hasYpos) rt.anchoredPosition3D = targetPos;
                if (hasZoom) rt.localScale = targetScale;
                currentAlpha = targetAlpha;
                currentPos = targetPos;
                currentScale = targetScale;
                continue;
            }

            // 插值动画
            float startAlpha = currentAlpha;
            Vector3 startPos = currentPos;
            Vector3 startScale = currentScale;
            float elapsed = 0f;
            while (elapsed < duration)
            {
                if (targetGo == null) yield break; // 目标已销毁，终止动画
                elapsed += Time.deltaTime;
                float t = Mathf.Clamp01(elapsed / duration);
                float k = ApplyParallelEasing(t, easing);
                if (cg != null && hasAlpha) cg.alpha = Mathf.Lerp(startAlpha, targetAlpha, k);
                if (hasXoff || hasYoff || hasXpos || hasYpos) rt.anchoredPosition3D = Vector3.Lerp(startPos, targetPos, k);
                if (hasZoom) rt.localScale = Vector3.Lerp(startScale, targetScale, k);
                yield return null;
            }

            // 精确到达终点
            if (cg != null && hasAlpha) cg.alpha = targetAlpha;
            rt.anchoredPosition3D = targetPos;
            rt.localScale = targetScale;
            currentAlpha = targetAlpha;
            currentPos = targetPos;
            currentScale = targetScale;
        }
    }

    /// <summary>将 object 转为 float，支持 int/float/double/long</summary>
    private float ToFloat(object val)
    {
        if (val is float f) return f;
        if (val is double d) return (float)d;
        if (val is int i) return i;
        if (val is long l) return l;
        return 0f;
    }

    /// <summary>应用缓动函数（linear/easein/easeout/ease）</summary>
    private float ApplyParallelEasing(float t, string easing)
    {
        switch (easing)
        {
            case "easein": return 1f - Mathf.Cos(t * Mathf.PI * 0.5f);
            case "easeout": return Mathf.Sin(t * Mathf.PI * 0.5f);
            case "ease": return (1f - Mathf.Cos(t * Mathf.PI)) * 0.5f;
            case "linear":
            default: return t;
        }
    }

    // Hide + 淡出
    public IEnumerator HideWithFade(string imageName, List<SameLineParamData> sameLine)
    {
        DeleteShowImageInfo(imageName);
        yield return null;
    }

    /// <summary>
    /// 切换场景（清除所有图层后绘制新图像），支持 parallel_0~parallel_3 多路并行动画。
    /// </summary>
    /// <param name="imageName">图像名或完整路径</param>
    /// <param name="sameLine">即时应用的 ATL 属性</param>
    /// <param name="parallel">第 1 路 parallel 关键帧序列</param>
    /// <param name="parts">Layered Image 部件列表（如场景图有表情/状态组合）</param>
    /// <param name="parallel_1">第 2 路 parallel 关键帧序列</param>
    /// <param name="parallel_2">第 3 路 parallel 关键帧序列</param>
    /// <param name="parallel_3">第 4 路 parallel 关键帧序列</param>
    public IEnumerator SceneWithFade(
        string imageName,
        List<SameLineParamData> sameLine,
        List<SameLineParamData> parallel,
        List<string> parts = null,
        List<SameLineParamData> parallel_1 = null,
        List<SameLineParamData> parallel_2 = null,
        List<SameLineParamData> parallel_3 = null)
    {
        // 清除所有图层的贴图
        HideAllLayers();

        // 绘制新的内容
        yield return ShowWithFade(imageName, "master", parts, sameLine, parallel, parallel_1, parallel_2, parallel_3);
    }
    
    /// <summary>
    /// 将 RectTransform 铺满父级容器（anchor 0,0 到 1,1，所有 offset 为 0）。
    /// 用于全屏纯色覆盖层（SceneBlack/SceneWhite）和颜色覆盖层。
    /// </summary>
    /// <param name="rt">目标 RectTransform</param>
    private void StretchRectTransformToFill(RectTransform rt)
    {
        if (rt == null) return;
        rt.anchorMin = Vector2.zero;
        rt.anchorMax = Vector2.one;
        rt.offsetMin = Vector2.zero;
        rt.offsetMax = Vector2.zero;
        rt.pivot = new Vector2(0.5f, 0.5f);
        rt.localScale = Vector3.one;
    }

    /// <summary>
    /// 切换到纯黑场景（对应 Renpy: scene black）。
    /// 清除所有图层后在 master 图层创建全屏黑色 Image。
    /// </summary>
    /// <remarks>修复：Image 必须铺满父容器，否则使用 UGUI 默认 100x100 尺寸显示为中间小方块。</remarks>
    public IEnumerator SceneBlack(List<SameLineParamData> sameLine)
    {
        HideAllLayers();

        GameObject go = new GameObject("scene_black");
        Image bg = go.AddComponent<Image>();
        bg.color = new Color(0f, 0f, 0f, 1f);
        bg.raycastTarget = false;

        Transform layer = GetLayerTransformByLayerName("master");
        go.transform.SetParent(layer, false);

        // 关键：铺满父容器，否则显示为中间 100x100 小方块
        StretchRectTransformToFill(go.GetComponent<RectTransform>());

        yield return null;
    }

    /// <summary>
    /// 切换到纯白场景（对应 Renpy: scene white）。
    /// 清除所有图层后在 master 图层创建全屏白色 Image。
    /// </summary>
    public IEnumerator SceneWhite(List<SameLineParamData> sameLine)
    {
        HideAllLayers();

        GameObject go = new GameObject("scene_white");
        Image bg = go.AddComponent<Image>();
        bg.color = new Color(1f, 1f, 1f, 1f);
        bg.raycastTarget = false;

        Transform layer = GetLayerTransformByLayerName("master");
        go.transform.SetParent(layer, false);

        // 关键：铺满父容器
        StretchRectTransformToFill(go.GetComponent<RectTransform>());

        yield return null;
    }
    
    /// <summary>
    /// 在 overlay 图层创建全屏纯色覆盖层，并用 DOTween 做 alpha 渐入动画
    /// </summary>
    /// <param name="name">覆盖层名称（如 "black"、"white"），用于字典跟踪</param>
    /// <param name="color">覆盖层颜色</param>
    /// <param name="fadeTime">渐入持续时间（秒），为 0 时立即显示</param>
    /// <returns>协程迭代器</returns>
    /// <remarks>对应 Renpy 的 show black / show white 命令，在画面最上层叠加纯色图层</remarks>
    public IEnumerator ShowColorOverlay(string name, Color color, float fadeTime)
    {
        // 如果已存在同名覆盖层，先销毁旧的
        if (_colorOverlays.TryGetValue(name, out GameObject existingGo))
        {
            // 停止旧的 DOTween 动画，避免冲突
            existingGo.GetComponent<CanvasGroup>()?.DOKill();
            UnityEngine.Object.Destroy(existingGo);
            _colorOverlays.Remove(name);
        }

        // 创建全屏 Image 作为覆盖层
        GameObject go = new GameObject($"ColorOverlay_{name}");
        Image img = go.AddComponent<Image>();
        img.color = color;
        img.raycastTarget = false; // 不拦截点击事件

        // 设置到 overlay 图层
        Transform layer = GetLayerTransformByLayerName("overlay");
        go.transform.SetParent(layer, false);

        // 覆盖整个屏幕（不依赖父级 RectTransform 的大小）
        // 方案：锚定中心点 + 极大 sizeDelta，保证任何父容器下都能完全覆盖屏幕
        RectTransform rt = go.GetComponent<RectTransform>();
        rt.anchorMin = new Vector2(0.5f, 0.5f);
        rt.anchorMax = new Vector2(0.5f, 0.5f);
        rt.pivot = new Vector2(0.5f, 0.5f);
        rt.anchoredPosition = Vector2.zero;
        rt.sizeDelta = new Vector2(10000f, 10000f); // 足够大以覆盖任何屏幕
        rt.localScale = Vector3.one;

        // 添加 CanvasGroup 用于 alpha 动画
        CanvasGroup cg = go.AddComponent<CanvasGroup>();
        cg.alpha = 0f;

        // 记录到字典
        _colorOverlays[name] = go;

        // DOTween 渐入动画
        if (fadeTime > 0f)
        {
            Tween tween = cg.DOFade(1f, fadeTime).SetEase(Ease.Linear);
            yield return tween.WaitForCompletion();
        }
        else
        {
            cg.alpha = 1f;
        }
    }

    /// <summary>
    /// 隐藏并销毁已存在的纯色覆盖层，用 DOTween 做 alpha 渐出动画
    /// </summary>
    /// <param name="name">覆盖层名称（如 "black"、"white"），对应 ShowColorOverlay 中使用的名称</param>
    /// <summary>
    /// 检查指定名称的颜色覆盖层是否存在。
    /// </summary>
    /// <param name="name">覆盖层名称（如 "black"、"white"）</param>
    /// <returns>是否存在该覆盖层</returns>
    public bool HasColorOverlay(string name)
    {
        return _colorOverlays.ContainsKey(name) && _colorOverlays[name] != null;
    }

    /// <param name="fadeTime">渐出持续时间（秒），为 0 时立即移除</param>
    /// <returns>协程迭代器</returns>
    /// <remarks>对应 Renpy 的 hide black / hide white 命令，移除画面最上层的纯色图层</remarks>
    public IEnumerator HideColorOverlay(string name, float fadeTime)
    {
        // 查找已存在的覆盖层
        if (!_colorOverlays.TryGetValue(name, out GameObject go))
        {
            Debug.LogWarning($"HideColorOverlay: 找不到名为 '{name}' 的颜色覆盖层");
            yield break;
        }

        CanvasGroup cg = go.GetComponent<CanvasGroup>();
        if (cg == null)
        {
            Debug.LogError($"HideColorOverlay: 覆盖层 '{name}' 缺少 CanvasGroup 组件");
            UnityEngine.Object.Destroy(go);
            _colorOverlays.Remove(name);
            yield break;
        }

        // DOTween 渐出动画
        if (fadeTime > 0f)
        {
            Tween tween = cg.DOFade(0f, fadeTime).SetEase(Ease.Linear);
            yield return tween.WaitForCompletion();
        }

        // 动画结束后销毁并移除字典记录
        UnityEngine.Object.Destroy(go);
        _colorOverlays.Remove(name);
    }

    public void DrawCharacter(string imageName, List<float>transform, float zoom, List<float>imageSidePos, List<string> imagePartsName)
     {
         // 获得image的绘制信息
         RenpyImage characterImage = _renpyImages[imageName];
         _currentCharaImage = characterImage;

         // 清除前面绘制的内容
         ClearCharacter();
         
         // 拿到需要绘制的textures
         List<Texture2D> textures = characterImage.GetCharaDrawTexture(imagePartsName);
         
         // 默认绘制的layer是master
         string layerName = "master";
         
         // 绘制图片
         foreach (Texture2D t in textures)
         {
             if (t == null)
             {
                 Debug.LogError("DrawCharacter 贴图为 null");
             }
             
             // 根据image名字，设置新的RawImage
             GameObject go = new GameObject(t.name);
             RawImage image = go.AddComponent<RawImage>();
             image.texture = t;
             image.rectTransform.sizeDelta = new Vector2(t.width, t.height);

             // 直接显示，所以alpha是1
             CanvasGroup cg = go.AddComponent<CanvasGroup>();
             cg.alpha = 1f;

             // 设置绘制信息
             DrawCharacterOptions(go, layerName, image, t, transform, zoom, imageSidePos);
         }
     }

    public void ClearCharacter()
    {
        foreach (var item in _charaImages)
        {
            Destroy(item.Value);
        }
        _charaImages.Clear();
    }
    
    public void ClearCurrentCharacterOldPartsNames()
    {
        if (_currentCharaImage != null)
        {
            _currentCharaImage.ClearOldPartsNames();
            _currentCharaImage = null;
        }
    }

    private void DrawCharacterOptions(GameObject go, string layerName, RawImage image, Texture2D texture, List<float>transform, float zoom, List<float>imageSidePos)
    {
        // 设置新建的RawImage到对应的layer层
        Transform layer = GetLayerTransformByLayerName(layerName);
        go.transform.SetParent(layer, false);
        _charaImages.Add(texture.name, go);
             
        // 调整位置，大小
        if (transform != null)
        {
            applyRenpyTransform(image, transform[0], transform[1], transform[2], transform[3], zoom);
        }
        else
        {
            // 只调整zoom
            image.rectTransform.localScale = new Vector3(zoom, zoom, 1f);
        }
             
        // 调整位置
        if (imageSidePos != null)
        {
            image.rectTransform.anchoredPosition = new Vector2(imageSidePos[0], imageSidePos[1]);
        }
    }
    
    private void applyRenpyTransform(RawImage rawImage, float cropX, float cropY, float cropWidth, float cropHeight, float zoom)
     {
         Texture tex = rawImage.texture;
         if (tex == null) return;
         
         // ✅ 设置 RawImage 的显示尺寸
         // 这样才不会把裁剪出来的小区域拉伸成整张图大小
         rawImage.rectTransform.sizeDelta = new Vector2(cropWidth, cropHeight);
         
         float texW = tex.width;
         float texH = tex.height;

         // 关键点：Unity 的 UV 原点是左下角，Renpy 是左上角
         float u = cropX / texW;
         float v = (texH - cropY - cropHeight) / texH;  // 正确翻转 crop Y 坐标
         float w = cropWidth / texW;
         float h = cropHeight / texH;
         rawImage.uvRect = new Rect(u, v, w, h);
         
         // 最后再设置缩放
         rawImage.rectTransform.localScale = new Vector3(zoom, zoom, 1f);
     }

    ////////////////////////////////////////////////////////////////////////////////////////////
    // 通用淡入/淡出协程
    private IEnumerator FadeCanvasGroup(CanvasGroup cg, float from, float to, float duration)
    {
        if (!cg) yield break;

        float t = 0f;
        cg.alpha = from;

        while (t < duration)
        {
            if (!cg) yield break;

            t += Time.deltaTime;
            cg.alpha = Mathf.Lerp(from, to, t / duration);
            yield return null;
        }

        if (cg) // 最后再检查一次，防止协程快结束时对象刚好被销毁
            cg.alpha = to;
    }
    
    /////////////////////////////////////////////////////////////////////////
    // 加载单文件的贴图
    private Texture2D GetSingleTexture(string imageName)
    {
        if (_singleTextures.TryGetValue(imageName, out AsyncOperationHandle<Texture2D> existHandle))
        {
            // 已经加载成功
            return existHandle.WaitForCompletion();
        }
        
        // 组合成完整地址
        string fullPath = $"{(string)imageName}";
        
        // 立刻加载返回
        AsyncOperationHandle<Texture2D> newHandle = Addressables.LoadAssetAsync<Texture2D>(fullPath);
        return newHandle.WaitForCompletion();
    }
    
    /////////////////////////////////////////////////////////////////////////
    // 获得绘制的layer的Transform
    private Transform GetLayerTransformByLayerName(string layerName)
    {
        Transform layerTransform = null;
        switch (layerName)
        {
            case "master0":
                layerTransform = master0Layer;
                break;
            case "master":
                layerTransform = masterLayer;
                break;
            case "background":
                layerTransform = backgroundLayer;
                break;
            case "middle":
                layerTransform = middleLayer;
                break;
            case "forward":
                layerTransform = forwardLayer;
                break;
            case "transient":
                layerTransform = transientLayer;
                break;
            case "screens":
                layerTransform = screensLayer;
                break;
            case "overlay":
                layerTransform = overlayLayer;
                break;
            default:
                Debug.LogError($"正在获取不存在的layer层 {layerName}");
                break;
        }
        return layerTransform;
    }
    
    // 清除出来background外的图层
    /// <summary>
    /// 隐藏并清理所有图层，包括 overlay 图层上的颜色覆盖层（black/white/fade_transition 等）。
    /// 同时清空 _colorOverlays 字典，防止 SceneBlack / Scene 切换后 HideBlack 找到脏引用。
    /// </summary>
    /// <remarks>对应 Renpy 的 scene 清场行为。</remarks>
    private void HideAllLayers()
    {
        // 清除所有记录的game object
        DeleteAllShowImageInfo();

        // 删除所有图层的RawImage
        destroyLayerRawImage(master0Layer);
        destroyLayerRawImage(masterLayer);
        destroyLayerRawImage(backgroundLayer);
        destroyLayerRawImage(middleLayer);
        destroyLayerRawImage(forwardLayer);
        destroyLayerRawImage(transientLayer);
        destroyLayerRawImage(screensLayer);
        destroyLayerRawImage(overlayLayer);

        // 清理颜色覆盖层字典（决策 5.1 方案 A：场景切换时完全重置所有覆盖层）
        // 先停止正在运行的 DOTween 动画，避免协程残留引用到已销毁的 GameObject
        foreach (var kv in _colorOverlays)
        {
            if (kv.Value != null)
            {
                CanvasGroup cg = kv.Value.GetComponent<CanvasGroup>();
                if (cg != null) cg.DOKill();
                // GameObject 本身已被 destroyLayerRawImage 销毁（它在 overlay 图层下），此处只清引用
            }
        }
        _colorOverlays.Clear();
    }
    
    private void destroyLayerRawImage(Transform t)
    {
        // 纯色
        Image[] images = t.GetComponentsInChildren<Image>(true);
        foreach (var image in images)
        {
            // rawImage.gameObject.SetActive(false);
            Destroy(image.gameObject);
        }
        
        // 贴图
        RawImage[] rawImages = t.GetComponentsInChildren<RawImage>(true);
        foreach (var rawImage in rawImages)
        {
            // rawImage.gameObject.SetActive(false);
            Destroy(rawImage.gameObject);
        }
    }
    
    /////////////////////////////////////////////////////////////////////////
    // 通过image名拿到image
    public RenpyImage GetImage(string imageName)
    {
        return _renpyImages[imageName];
    }

    // 泛用绘制函数 - 主要绘制函数
    private void DrawWithOptions(GameObject go, string layerName, RawImage image, Texture2D texture, Dictionary<string, object> options)
    {
        // 设置新建的RawImage到对应的layer层
        Transform layer = GetLayerTransformByLayerName(layerName);
        go.transform.SetParent(layer, false);

        Debug.Log("DrawWithOptions options内容:");
        foreach (var kvp in options)
        {
            if (kvp.Value is ImageAnimDataInfo animData)
            {
                Debug.Log($"  {kvp.Key}: ImageAnimDataInfo(时间={animData.times}, 目标属性={animData.targetName}, 目标值={animData.targetData})");
            }
            else
            {
                Debug.Log($"  {kvp.Key}: {kvp.Value} (类型: {kvp.Value?.GetType()})");
            }
        }
        Debug.Log($"=== DrawWithOptions options内容 结束 ===");

        // 缩放
        float zoom = 1.0f;
        if (options.ContainsKey("zoom"))
        {
            zoom = (float)options["zoom"];
            Debug.Log($"=========== zoom {zoom} =========");
        }
        if(options.ContainsKey("zposzoom")){
            zoom = image.rectTransform.localScale.x; // * (1 + (float)options["zposzoom"]);
            // Debug.Log($"=========== zposzoom1 {options["zposzoom"]} =========");
            // Debug.Log($"=========== zposzoom2 {image.rectTransform.localScale.x} =========");
            // Debug.Log($"=========== zposzoom3 {zoom} =========");
        }
        
        // 调整rect
        List<float> rect = new List<float>();
        if (options.ContainsKey("rect"))
        {
            rect = (List<float>)options["rect"];
            applyRenpyTransform(image, rect[0], rect[1], rect[2], rect[3], zoom);
        }
        
        // 只调整zoom - 检查是否需要更新
        Vector3 newScale = new Vector3(zoom, zoom, 1f);
        if (image.rectTransform.localScale != newScale)
        {
            image.rectTransform.localScale = newScale;
        }
        
        // 设置anchor - 检查是否需要更新
        if (options.ContainsKey("anchor"))
        {
            Vector2 ret = (Vector2)options["anchor"];
            Vector2 newAnchorMax = new Vector2(ret.x, 1.0f - ret.y);
            Vector2 newAnchorMin = new Vector2(ret.x, 1.0f - ret.y);
            Vector2 newPivot = new Vector2(ret.x, 1.0f - ret.y);
            
            if (image.rectTransform.anchorMax != newAnchorMax)
            {
                image.rectTransform.anchorMax = newAnchorMax;
            }
            if (image.rectTransform.anchorMin != newAnchorMin)
            {
                image.rectTransform.anchorMin = newAnchorMin;
            }
            if (image.rectTransform.pivot != newPivot)
            {
                image.rectTransform.pivot = newPivot;
            }
        }
        else
        {
            Vector2 defaultAnchor = new Vector2(0.5f, 0.5f);
            if (image.rectTransform.anchorMax != defaultAnchor)
            {
                image.rectTransform.anchorMax = defaultAnchor;
            }
            if (image.rectTransform.anchorMin != defaultAnchor)
            {
                image.rectTransform.anchorMin = defaultAnchor;
            }
            if (image.rectTransform.pivot != defaultAnchor)
            {
                image.rectTransform.pivot = defaultAnchor;
            }
        }
        
        // 调整pos
        Vector2 pos = Vector2.zero;
        if (options.ContainsKey("pos"))
        {
            Vector2 p = (Vector2)options["pos"];
            if (p.x > 0.0f && p.x < 1.0f)
            {
                // 拿到的是比例值，需要转换
                pos = new Vector2(UtilsMethods.GetXFromRatio(p.x), UtilsMethods.GetYFromRatio(p.y));
            }
            else
            {
                pos = new Vector2(p.x / 2.0f, -p.y / 2.0f);   
            }
        }
        // 调整pos偏移量
        Vector2 offset = Vector2.zero;
        if (options.ContainsKey("xoffset"))
        {
            offset.x = (float)options["xoffset"];
        }
        if (options.ContainsKey("yoffset"))
        {
            offset.y = (float)options["yoffset"];
        }
        // 最终pos计算 - 检查是否需要更新
        float finalX = pos.x - offset.x;
        float finalY = pos.y - offset.y;
        Vector2 newPosition = new Vector2(finalX, finalY);
        if (image.rectTransform.anchoredPosition != newPosition)
        {
            image.rectTransform.anchoredPosition = newPosition;
        }

        // 单独的x/y坐标（比例），仅覆盖对应轴
        if (options.ContainsKey("xpos"))
        {
            
            float rx = (float)options["xpos"];
            float tmpXpos = UtilsMethods.GetXFromRatio(rx);
            Debug.Log($"DrawWithOptions xpos:{tmpXpos},{rx}");
            Vector2 newPositionXPos = image.rectTransform.anchoredPosition;
            newPositionXPos.x = tmpXpos;
            if(image.rectTransform.anchoredPosition != newPositionXPos){
                image.rectTransform.anchoredPosition = newPositionXPos;
            }
        }
        if (options.ContainsKey("ypos"))
        {
            float ry = (float)options["ypos"];
            float tmpYpos = UtilsMethods.GetYFromRatio(ry);
            Debug.Log($"DrawWithOptions ypos:{tmpYpos},{ry}");
            Vector2 newPositionYPos = image.rectTransform.anchoredPosition;
            newPositionYPos.y = tmpYpos;
            if(image.rectTransform.anchoredPosition != newPositionYPos){
                image.rectTransform.anchoredPosition = newPositionYPos;
            }
        }
    }
    
    //////////////////////////////////////////////////////////////////
    // 获得绘制optinon信息
    private Dictionary<string, object> GetDrawOptions(List<SameLineParamData> sameLine)
    {
        Dictionary<string, object> options = new Dictionary<string, object>();

        // 如果没有sameline信息，就返回空
        if (sameLine == null)
        {
            Debug.Log("GetDrawOptions: sameLine为null，返回空options");
            return options;
        }

        Debug.Log($"=== GetDrawOptions 开始解析 ===");
        Debug.Log($"sameLine参数数量: {sameLine.Count}");
        
        // 先打印所有sameLine的内容
        for (int debugIndex = 0; debugIndex < sameLine.Count; debugIndex++)
        {
            Debug.Log($"SameLine[{debugIndex}] 包含的参数:");
            foreach (var kvp in sameLine[debugIndex].paramDict)
            {
                Debug.Log($"  {kvp.Key}: {kvp.Value} (类型: {kvp.Value?.GetType()})");
            }
        }

        int linearAnimIndex = 0;
        int easeAnimIndex = 0;
        int easeInBackAnimIndex = 0;
        int easeOutBackAnimIndex = 0;
        int easeOutCubicAnimIndex = 0;
                
        // 解析绘制信息
        for(int i = 0; i < sameLine.Count; i++)
        {
            var option = sameLine[i];
            Dictionary<string, object> optionDict = option.paramDict;
            
            Debug.Log($"处理SameLine[{i}]，包含参数: {string.Join(", ", optionDict.Keys)}");
            
            //需要先判断是否含有动画的关键字
            if (optionDict.TryGetValue("linear", out object linearObj) && linearObj is float aniTotaleTime_linearObj)
            {
                Debug.Log($"找到linear动画关键字，时间: {aniTotaleTime_linearObj}");
                // Check if optionDict has exactly 2 keys
                if (optionDict.Keys.Count == 2)
                {
                    // Find the non-linear key
                    string nonLinearKey = null;
                    object nonLinearValue = null;
                    foreach (var pair in optionDict)
                    {
                        if (pair.Key != "linear")
                        {
                            nonLinearKey = pair.Key;
                            nonLinearValue = pair.Value;
                            break;
                        }
                    }

                    if (nonLinearKey != null && nonLinearValue != null)
                    {
                        var animData = new ImageAnimDataInfo(aniTotaleTime_linearObj, nonLinearKey, (float)nonLinearValue);
                        options["linear_" + linearAnimIndex] = animData;
                        Debug.Log($"添加linear动画: linear_{linearAnimIndex} -> 属性:{nonLinearKey}, 目标值:{nonLinearValue}, 时间:{aniTotaleTime_linearObj}");
                        linearAnimIndex++;
                    }
                }
                else
                {
                    Debug.LogWarning($"linear动画参数数量不正确，期望2个参数，实际有{optionDict.Keys.Count}个参数");
                }
                continue;
            }
            if (optionDict.TryGetValue("ease", out object easeObj) && easeObj is float aniTotaleTime_ease)
            {
                Debug.Log($"找到ease动画关键字，时间: {aniTotaleTime_ease}");
                // Check if optionDict has exactly 2 keys
                if (optionDict.Keys.Count == 2)
                {
                    // Find the non-ease key
                    string nonEaseKey = null;
                    object nonEaseValue = null;
                    foreach (var pair in optionDict)
                    {
                        if (pair.Key != "ease")
                        {
                            nonEaseKey = pair.Key;
                            nonEaseValue = pair.Value;
                            break;
                        }
                    }

                    if (nonEaseKey != null && nonEaseValue != null)
                    {
                        var animData = new ImageAnimDataInfo(aniTotaleTime_ease, nonEaseKey, (float)nonEaseValue);
                        options["ease_" + easeAnimIndex] = animData;
                        Debug.Log($"添加ease动画: ease_{easeAnimIndex} -> 属性:{nonEaseKey}, 目标值:{nonEaseValue}, 时间:{aniTotaleTime_ease}");
                        easeAnimIndex++;
                    }
                }
                else
                {
                    Debug.LogWarning($"ease动画参数数量不正确，期望2个参数，实际有{optionDict.Keys.Count}个参数");
                }
                continue;
            }
            if (optionDict.TryGetValue("easeInBack", out object easeInBackObj) && easeInBackObj is float aniTotaleTime_easeInBack)
            {
                Debug.Log($"找到easeInBack动画关键字，时间: {aniTotaleTime_easeInBack}");
                // Check if optionDict has exactly 2 keys
                if (optionDict.Keys.Count == 2)
                {
                    // Find the non-easeInBack key
                    string nonEaseInBackKey = null;
                    object nonEaseInBackValue = null;
                    foreach (var pair in optionDict)
                    {
                        if (pair.Key != "easeInBack")
                        {
                            nonEaseInBackKey = pair.Key;
                            nonEaseInBackValue = pair.Value;
                            break;
                        }
                    }

                    if (nonEaseInBackKey != null && nonEaseInBackValue != null)
                    {
                        var animData = new ImageAnimDataInfo(aniTotaleTime_easeInBack, nonEaseInBackKey, (float)nonEaseInBackValue);
                        options["easeInBack_" + easeInBackAnimIndex] = animData;
                        Debug.Log($"添加easeInBack动画: easeInBack_{easeInBackAnimIndex} -> 属性:{nonEaseInBackKey}, 目标值:{nonEaseInBackValue}, 时间:{aniTotaleTime_easeInBack}");
                        easeInBackAnimIndex++;
                    }
                }
                else
                {
                    Debug.LogWarning($"easeInBack动画参数数量不正确，期望2个参数，实际有{optionDict.Keys.Count}个参数");
                }
                continue;
            }
            if (optionDict.TryGetValue("easeOutBack", out object easeOutBackObj) && easeOutBackObj is float aniTotaleTime_easeOutBack)
            {
                Debug.Log($"找到easeOutBack动画关键字，时间: {aniTotaleTime_easeOutBack}");
                // Check if optionDict has exactly 2 keys
                if (optionDict.Keys.Count == 2)
                {
                    // Find the non-easeOutBack key
                    string nonEaseOutBackKey = null;
                    object nonEaseOutBackValue = null;
                    foreach (var pair in optionDict)
                    {
                        if (pair.Key != "easeOutBack")
                        {
                            nonEaseOutBackKey = pair.Key;
                            nonEaseOutBackValue = pair.Value;
                            break;
                        }
                    }

                    if (nonEaseOutBackKey != null && nonEaseOutBackValue != null)
                    {
                        var animData = new ImageAnimDataInfo(aniTotaleTime_easeOutBack, nonEaseOutBackKey, (float)nonEaseOutBackValue);
                        options["easeOutBack_" + easeOutBackAnimIndex] = animData;
                        Debug.Log($"添加easeOutBack动画: easeOutBack_{easeOutBackAnimIndex} -> 属性:{nonEaseOutBackKey}, 目标值:{nonEaseOutBackValue}, 时间:{aniTotaleTime_easeOutBack}");
                        easeOutBackAnimIndex++;
                    }
                }
                else
                {
                    Debug.LogWarning($"easeOutBack动画参数数量不正确，期望2个参数，实际有{optionDict.Keys.Count}个参数");
                }
                continue;
            }
            if (optionDict.TryGetValue("easeOutCubic", out object easeOutCubicObj) && easeOutCubicObj is float aniTotaleTime_easeOutCubic)
            {
                Debug.Log($"找到easeOutCubic动画关键字，时间: {aniTotaleTime_easeOutCubic}");
                // Check if optionDict has exactly 2 keys
                if (optionDict.Keys.Count == 2)
                {
                    // Find the non-easeOutCubic key
                    string nonEaseOutCubicKey = null;
                    object nonEaseOutCubicValue = null;
                    foreach (var pair in optionDict)
                    {
                        if (pair.Key != "easeOutCubic")
                        {
                            nonEaseOutCubicKey = pair.Key;
                            nonEaseOutCubicValue = pair.Value;
                            break;
                        }
                    }

                    if (nonEaseOutCubicKey != null && nonEaseOutCubicValue != null)
                    {
                        var animData = new ImageAnimDataInfo(aniTotaleTime_easeOutCubic, nonEaseOutCubicKey, (float)nonEaseOutCubicValue);
                        options["easeOutCubic_" + easeOutCubicAnimIndex] = animData;
                        Debug.Log($"添加easeOutCubic动画: easeOutCubic_{easeOutCubicAnimIndex} -> 属性:{nonEaseOutCubicKey}, 目标值:{nonEaseOutCubicValue}, 时间:{aniTotaleTime_easeOutCubic}");
                        easeOutCubicAnimIndex++;
                    }
                }
                else
                {
                    Debug.LogWarning($"easeOutCubic动画参数数量不正确，期望2个参数，实际有{optionDict.Keys.Count}个参数");
                }
                continue;
            }
            //非动画相关关键字
            if (optionDict.TryGetValue("zoom", out object obj) && obj is float zoom)
            {
                // Debug.Log($"add zoom {zoom}");
                options["zoom"] = zoom;
            }
            if (optionDict.TryGetValue("pos", out object posObj) && posObj is Vector2 pos)
            {
                // Debug.Log($"add pos {pos}");
                options["pos"] = new Vector2(pos.x, pos.y);
            }
            if (optionDict.TryGetValue("anchor", out object anchorObj) && anchorObj is Vector2 anchor)
            {
                // Debug.Log($"add anchor {anchor.x} {anchor.y}");
                options["anchor"] = new Vector2(anchor.x, anchor.y);
            }
            if (optionDict.TryGetValue("alpha", out object alphaObj) && alphaObj is float alpha)
            {
                // Debug.Log($"add alpha {alpha}");
                options["alpha"] = alpha;
            }
            if (optionDict.TryGetValue("xoffset", out object xoffsetObj) && xoffsetObj is float xoffset)
            {
                // Debug.Log($"add xoffset {xoffset}");
                options["xoffset"] = xoffset;
            }
            if (optionDict.TryGetValue("yoffset", out object yoffsetObj) && yoffsetObj is float yoffset)
            {
                // Debug.Log($"add yoffset {yoffset}");
                options["yoffset"] = yoffset;
            }
            if (optionDict.TryGetValue("xpan", out object xpanObj) && xpanObj is float xpan)
            {
                // Debug.Log($"add xpan {xpan}");
                options["xpan"] = xpan;
            }
            if (optionDict.TryGetValue("repeat", out object repeatObj) && repeatObj is float repeat)
            {
                // Debug.Log($"add repeat {repeat}");
                options["repeat"] = repeat;
            }
            if (optionDict.TryGetValue("pause", out object pauseObj) && pauseObj is float pause)
            {
                // Debug.Log($"add pause {pause}");
                options["pause"] = pause;
            }
            if (optionDict.TryGetValue("xpos", out object xposObj) && xposObj is float xpos)
            {
                Debug.Log($"add xpos {xpos}");
                options["xpos"] = xpos;
            }
            if (optionDict.TryGetValue("ypos", out object yposObj) && yposObj is float ypos)
            {
                Debug.Log($"add ypos {ypos}");
                options["ypos"] = ypos;
            }
            if (optionDict.TryGetValue("zpos", out object zposObj) && zposObj is float zpos)
            {
                Debug.Log($"add zpos to sacel {zpos}");
                options["zposzoom"] = UtilsMethods.ChangeZposToScale(zpos);
            }
            // linear，会重复
            // ease_circ, 会重复
        }
        
        Debug.Log($"=== GetDrawOptions 解析完成 ===");
        Debug.Log($"最终options字典数量: {options.Count}");
        Debug.Log("最终options内容:");
        foreach (var kvp in options)
        {
            if (kvp.Value is ImageAnimDataInfo animData)
            {
                Debug.Log($"  {kvp.Key}: ImageAnimDataInfo(时间={animData.times}, 目标属性={animData.targetName}, 目标值={animData.targetData})");
            }
            else
            {
                Debug.Log($"  {kvp.Key}: {kvp.Value} (类型: {kvp.Value?.GetType()})");
            }
        }
        Debug.Log($"=== GetDrawOptions 结束 ===");
        
        return options;
    }

    private void AddShowImageInfo(string imageName, List<GameObject> gos, Dictionary<string, object> options, List<string> parts)
    {
        _showImagesGameObject.Add(imageName, gos);
        _showImagesOptions.Add(imageName, options);
    }

    private void DeleteShowImageInfo(string imageName)
    {
        DeleteShowImageInfoGameObject(imageName);
        DeleteShowImageInfoOptions(imageName);
        // DeleteShowImageInfoParts(imageName);
    }

    private void DeleteShowImageInfoGameObject(string imageName)
    {
        if (!_showImagesGameObject.ContainsKey(imageName))
        {
            Debug.LogError($"gameobject 需要删除的image:{imageName}并没有被绘制");
            return;
        }
        
        // 删除贴图
        List<GameObject> gos = _showImagesGameObject[imageName];
        foreach (var go in gos)
        {
            Destroy(go);
        }
        _showImagesGameObject.Remove(imageName);
    }
    
    private void DeleteShowImageInfoOptions(string imageName)
    {
        if (!_showImagesOptions.ContainsKey(imageName))
        {
            Debug.LogError($"options 需要删除的image:{imageName}并没有被绘制");
            return;
        }
        
        // 删除绘制信息
        _showImagesOptions.Remove(imageName);
    }
    
    private void DeleteAllShowImageInfo()
    {
        // 删除所有绘制的贴图
        foreach (var item in _showImagesGameObject)
        {
            foreach (var go in item.Value)
            {
                Destroy(go);
            }
        }
        _showImagesGameObject.Clear();
        
        // 删除所有绘制信息
        _showImagesOptions.Clear();
    }

    ////////////////////////////////////////////////////////////////////////////////////////////
    // 处理动画的协程
    private IEnumerator ProcessAnimations(GameObject go, Dictionary<string, object> options, string imageName)
    {
        Debug.Log($"ProcessAnimations被调用 for {go.name}");
        if (options == null || options.Count == 0) 
        {
            Debug.Log($"ProcessAnimations: options为空，直接返回");
            yield break;
        }

        // 调试日志：显示options和go的信息
        Debug.Log("=== ProcessAnimations 调试信息 ===");
        Debug.Log($"GameObject名称: {go.name}");
        Debug.Log($"GameObject位置: {go.transform.position}");
        Debug.Log($"GameObject缩放: {go.transform.localScale}");
        
        RawImage image = go.GetComponent<RawImage>();
        CanvasGroup canvasGroup = go.GetComponent<CanvasGroup>();
        if (image != null)
        {
            Debug.Log($"RawImage锚点位置: {image.rectTransform.anchoredPosition}");
            Debug.Log($"RawImage尺寸: {image.rectTransform.sizeDelta}");
        }
        if (canvasGroup != null)
        {
            Debug.Log($"CanvasGroup透明度: {canvasGroup.alpha}");
        }
        
        Debug.Log($"Options字典数量: {options.Count}");
        Debug.Log("Options内容:");
        foreach (var kvp in options)
        {
            if (kvp.Value is ImageAnimDataInfo animData)
            {
                Debug.Log($"  {kvp.Key}: ImageAnimDataInfo(时间={animData.times}, 目标属性={animData.targetName}, 目标值={animData.targetData})");
            }
            else
            {
                Debug.Log($"  {kvp.Key}: {kvp.Value} (类型: {kvp.Value?.GetType()})");
            }
        }
        Debug.Log("=== ProcessAnimations 调试信息结束 ===");

        List<Tween> activeTweens = new List<Tween>();

        // 处理linear动画
        for (int i = 0; i < 100; i++) // 限制循环次数防止无限循环
        {
            string key = $"linear_{i}";
            if (options.TryGetValue(key, out object animObj) && animObj is ImageAnimDataInfo animData)
            {
                Tween tween = CreateTween(go, animData, Ease.Linear, imageName);
                if (tween != null) activeTweens.Add(tween);
            }
            else
            {
                break; // 没有更多linear动画了
            }
        }

        // 处理ease动画
        for (int i = 0; i < 100; i++)
        {
            string key = $"ease_{i}";
            if (options.TryGetValue(key, out object animObj) && animObj is ImageAnimDataInfo animData)
            {
                Tween tween = CreateTween(go, animData, Ease.InOutQuad, imageName);
                if (tween != null) activeTweens.Add(tween);
            }
            else
            {
                break;
            }
        }

        // 处理easeInBack动画
        for (int i = 0; i < 100; i++)
        {
            string key = $"easeInBack_{i}";
            if (options.TryGetValue(key, out object animObj) && animObj is ImageAnimDataInfo animData)
            {
                Tween tween = CreateTween(go, animData, Ease.InBack, imageName);
                if (tween != null) activeTweens.Add(tween);
            }
            else
            {
                break;
            }
        }

        // 处理easeOutBack动画
        for (int i = 0; i < 100; i++)
        {
            string key = $"easeOutBack_{i}";
            if (options.TryGetValue(key, out object animObj) && animObj is ImageAnimDataInfo animData)
            {
                Tween tween = CreateTween(go, animData, Ease.OutBack, imageName);
                if (tween != null) activeTweens.Add(tween);
            }
            else
            {
                break;
            }
        }

        // 处理easeOutCubic动画
        for (int i = 0; i < 100; i++)
        {
            string key = $"easeOutCubic_{i}";
            if (options.TryGetValue(key, out object animObj) && animObj is ImageAnimDataInfo animData)
            {
                Tween tween = CreateTween(go, animData, Ease.OutCubic, imageName);
                if (tween != null) activeTweens.Add(tween);
            }
            else
            {
                break;
            }
        }

        // 等待所有动画完成
        if (activeTweens.Count > 0)
        {
            yield return new WaitUntil(() => activeTweens.All(t => t == null || !t.IsActive()));
        }
    }

    // 创建Tween的辅助方法
    private Tween CreateTween(GameObject go, ImageAnimDataInfo animData, Ease easeType, string imageName)
    {
        RawImage image = go.GetComponent<RawImage>();
        CanvasGroup canvasGroup = go.GetComponent<CanvasGroup>();

        //需要更新options的数据
        object options = null;
        if (_showImagesOptions.ContainsKey(imageName))
        {
            options = _showImagesOptions[imageName];
        }
        else
        {
            Debug.LogWarning($"CreateTween: 找不到imageName '{imageName}' 在 _showImagesOptions 字典中");
        } 
        
        if (image == null) return null;
        
        // 如果options为null，仍然可以创建动画，只是不会更新options字典
        if (options == null)
        {
            Debug.LogWarning($"CreateTween: options为null，将创建动画但不会更新options字典 for {imageName}");
        }

        float startValue = GetCurrentValue(go, animData.targetName);
        
        // 调试日志：显示动画创建信息
        Debug.Log($"=== 创建动画 ===");
        Debug.Log($"目标属性: {animData.targetName}");
        Debug.Log($"动画时间: {animData.times}");
        Debug.Log($"目标值: {animData.targetData}");
        Debug.Log($"起始值: {startValue}");
        Debug.Log($"缓动类型: {easeType}");
        
        Tween resultTween = null;
        
        switch (animData.targetName.ToLower())
        {
            case "alpha":
                if (canvasGroup != null)
                {
                    resultTween = canvasGroup.DOFade(animData.targetData, animData.times)
                        .SetEase(easeType);
                    Debug.Log($"创建透明度动画: {canvasGroup.alpha} -> {animData.targetData}");
                    if (options is Dictionary<string, object> optionsDict_alpha)
                    {
                        if (optionsDict_alpha.ContainsKey("alpha"))
                        {
                            optionsDict_alpha["alpha"] = animData.targetData;
                        }
                    }
                }
                break;
                
            case "zoom":
                resultTween = image.rectTransform.DOScale(new Vector3(animData.targetData, animData.targetData, 1f), animData.times)
                    .SetEase(easeType);
                Debug.Log($"创建缩放动画: {image.rectTransform.localScale.x} -> {animData.targetData}");
                if (options is Dictionary<string, object> optionsDict_zoom)
                {
                    if (optionsDict_zoom.ContainsKey("zoom"))
                    {
                        optionsDict_zoom["zoom"] = animData.targetData;
                    }
                }
                break;

            case "zpos":
                float tmpNewScale = image.rectTransform.localScale.x * (1 + UtilsMethods.ChangeZposToScale(animData.targetData));
                resultTween = image.rectTransform.DOScale(new Vector3(tmpNewScale, tmpNewScale, 1f), animData.times).SetEase(easeType);
                Debug.Log($"创建缩放动画zpos: {image.rectTransform.localScale.x} -> {tmpNewScale}");
                if (options is Dictionary<string, object> optionsDict_zpos)
                {
                    if (optionsDict_zpos.ContainsKey("zposzoom"))
                    {
                        optionsDict_zpos["zposzoom"] = animData.targetData;
                    }
                }
                break;
                    
            case "xpos":
                Vector3 currentPos = image.rectTransform.anchoredPosition;
                float tatgetPosX = UtilsMethods.GetXFromRatio(animData.targetData);
                resultTween = image.rectTransform.DOAnchorPosX(tatgetPosX, animData.times)
                    .SetEase(easeType);
                Debug.Log($"创建X位置动画: {currentPos.x} -> {tatgetPosX}");
                if (options is Dictionary<string, object> optionsDict_xpos)
                {
                    if (optionsDict_xpos.ContainsKey("xpos"))
                    {
                        optionsDict_xpos["xpos"] = animData.targetData;
                    }
                    if (optionsDict_xpos.ContainsKey("pos"))
                    {
                        // 获取pos的值
                        Vector2 pos = (Vector2)optionsDict_xpos["pos"];
                        pos.x = animData.targetData;
                        optionsDict_xpos["pos"] = pos;
                    }
                }
                break;
                    
            case "ypos":
                float targetPosY = UtilsMethods.GetYFromRatio(animData.targetData);
                resultTween = image.rectTransform.DOAnchorPosY(targetPosY, animData.times)
                    .SetEase(easeType);
                Debug.Log($"创建Y位置动画: {image.rectTransform.anchoredPosition.y} -> {targetPosY}");
                if (options is Dictionary<string, object> optionsDict_ypos)
                {
                    if (optionsDict_ypos.ContainsKey("ypos"))
                    {
                        optionsDict_ypos["ypos"] = animData.targetData;
                    }
                    if (optionsDict_ypos.ContainsKey("pos"))
                    {
                        // 获取pos的值
                        Vector2 pos = (Vector2)optionsDict_ypos["pos"];
                        pos.y = animData.targetData;
                        optionsDict_ypos["pos"] = pos;
                    }
                }
                break;
                    
            case "xoffset":
                Vector3 currentPos2 = image.rectTransform.anchoredPosition;
                resultTween = image.rectTransform.DOAnchorPosX(currentPos2.x - animData.targetData, animData.times)
                    .SetEase(easeType);
                Debug.Log($"创建X偏移动画: {currentPos2.x} -> {currentPos2.x - animData.targetData}");
                if (options is Dictionary<string, object> optionsDict_xoffset)
                {
                    if (optionsDict_xoffset.ContainsKey("xoffset"))
                    {
                        optionsDict_xoffset["xoffset"] = animData.targetData;
                    }
                }
                break;
                    
            case "yoffset":
                Vector3 currentPos3 = image.rectTransform.anchoredPosition;
                resultTween = image.rectTransform.DOAnchorPosY(currentPos3.y - animData.targetData, animData.times)
                    .SetEase(easeType);
                Debug.Log($"创建Y偏移动画: {currentPos3.y} -> {currentPos3.y - animData.targetData}");
                if (options is Dictionary<string, object> optionsDict_yoffset)
                {
                    if (optionsDict_yoffset.ContainsKey("yoffset"))
                    {
                        optionsDict_yoffset["yoffset"] = animData.targetData;
                    }
                }
                break;
                    
            case "xalign":
                // 根据屏幕宽度计算绝对位置
                float screenX = Screen.width * animData.targetData;
                float worldX = screenX - Screen.width / 2f;
                resultTween = image.rectTransform.DOAnchorPosX(worldX, animData.times)
                    .SetEase(easeType);
                Debug.Log($"创建X对齐动画: {image.rectTransform.anchoredPosition.x} -> {worldX} (屏幕比例: {animData.targetData})");
                if (options is Dictionary<string, object> optionsDict_xalign)
                {
                    if (optionsDict_xalign.ContainsKey("xalign"))
                    {
                        optionsDict_xalign["xalign"] = animData.targetData;
                    }
                }
                break;
                    
            case "yalign":
                // 根据屏幕高度计算绝对位置
                float screenY = Screen.height * animData.targetData;
                float worldY = screenY - Screen.height / 2f;
                resultTween = image.rectTransform.DOAnchorPosY(worldY, animData.times)
                    .SetEase(easeType);
                Debug.Log($"创建Y对齐动画: {image.rectTransform.anchoredPosition.y} -> {worldY} (屏幕比例: {animData.targetData})");
                if (options is Dictionary<string, object> optionsDict_yalign)
                {
                    if (optionsDict_yalign.ContainsKey("yalign"))
                    {
                        optionsDict_yalign["yalign"] = animData.targetData;
                    }
                }
                break;
                
            default:
                Debug.LogWarning($"未知的动画属性: {animData.targetName}");
                break;
        }
        
        if (resultTween != null)
        {
            Debug.Log($"动画创建成功: {animData.targetName}");
        }
        else
        {
            Debug.LogWarning($"动画创建失败: {animData.targetName}");
        }
        Debug.Log($"=== 动画创建结束 ===");
        
        return resultTween;
    }

    // 获取当前值的辅助方法
    private float GetCurrentValue(GameObject go, string propertyName)
    {
        RawImage image = go.GetComponent<RawImage>();
        CanvasGroup canvasGroup = go.GetComponent<CanvasGroup>();
        
        switch (propertyName.ToLower())
        {
            case "alpha":
                return canvasGroup != null ? canvasGroup.alpha : 1f;
                
            case "zoom":
                return image.rectTransform.localScale.x;
                
            case "xpos":
                return image.rectTransform.anchoredPosition.x;
                
            case "ypos":
                return image.rectTransform.anchoredPosition.y;
                
            case "xalign":
                return (image.rectTransform.anchoredPosition.x + Screen.width / 2f) / Screen.width;
                
            case "yalign":
                return (image.rectTransform.anchoredPosition.y + Screen.height / 2f) / Screen.height;
                
            default:
                return 0f;
        }
    }
}

//需要一个保存image动画的简单类
public struct ImageAnimDataInfo{
    public float times;
    public string targetName;
    public float targetData;

    public ImageAnimDataInfo(float aniTimes, string tarName, float tarData){
        times = aniTimes;
        targetName = tarName;
        targetData = tarData;
    }
}