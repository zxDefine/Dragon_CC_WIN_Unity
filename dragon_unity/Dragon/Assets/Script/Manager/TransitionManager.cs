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
}
