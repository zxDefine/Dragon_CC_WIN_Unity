using System.Collections;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

/// <summary>
/// 启动画面。展示 <c>gui/zhu/zhu_yujing.jpg</c> 全屏背景，
/// 经历 fade-in / hold / fade-out 三阶段后过渡到 <see cref="MainMenuScreen"/>。
/// 用户点击或按任意键可立即跳过。
/// </summary>
/// <remarks>
/// 对应 Renpy 原版的 splash + 警告画面（zhu_yujing 即"预警"页）。
/// 由 <see cref="GameMain"/> 在 startLabel 为空时作为第一个屏幕显示。
/// </remarks>
public class SplashScreen : UIScreenBase
{
    private const string YujingAddress = "Assets/RenpyResources/gui/zhu/zhu_yujing.jpg";

    private const float FadeInDuration = 0.6f;
    private const float HoldDuration = 1.6f;
    private const float FadeOutDuration = 0.6f;

    private RawImage _bgImage;
    private Image _coverImage;
    private bool _skipRequested;
    private AsyncOperationHandle<Texture2D> _texHandle;

    protected override void BuildContent()
    {
        // 黑色底层（背景图加载完成前的兜底色）
        CreateFullScreenBackground(Root, Color.black);

        // 全屏 RawImage 显示 splash 纹理
        GameObject imgGo = new GameObject("SplashImage");
        imgGo.transform.SetParent(Root, false);
        _bgImage = imgGo.AddComponent<RawImage>();
        _bgImage.color = Color.white;
        RectTransform rt = imgGo.GetComponent<RectTransform>();
        rt.anchorMin = Vector2.zero;
        rt.anchorMax = Vector2.one;
        rt.offsetMin = Vector2.zero;
        rt.offsetMax = Vector2.zero;

        // 黑色覆盖层，控制 fade-in/out 透明度
        GameObject coverGo = new GameObject("FadeCover");
        coverGo.transform.SetParent(Root, false);
        _coverImage = coverGo.AddComponent<Image>();
        _coverImage.color = new Color(0f, 0f, 0f, 1f); // 起始全黑
        RectTransform crt = coverGo.GetComponent<RectTransform>();
        crt.anchorMin = Vector2.zero;
        crt.anchorMax = Vector2.one;
        crt.offsetMin = Vector2.zero;
        crt.offsetMax = Vector2.zero;
        // 让 cover 接收点击以触发 skip
        Button skipBtn = coverGo.AddComponent<Button>();
        skipBtn.transition = Selectable.Transition.None;
        skipBtn.onClick.AddListener(() => _skipRequested = true);
    }

    public override void Show()
    {
        base.Show();
        _skipRequested = false;
        StartCoroutine(SplashRoutine());
    }

    private IEnumerator SplashRoutine()
    {
        // 1) 异步加载纹理
        _texHandle = Addressables.LoadAssetAsync<Texture2D>(YujingAddress);
        yield return _texHandle;
        if (_texHandle.Status == AsyncOperationStatus.Succeeded && _texHandle.Result != null)
        {
            _bgImage.texture = _texHandle.Result;
        }
        else
        {
            Debug.LogWarning("[SplashScreen] 无法加载 zhu_yujing.jpg，使用纯黑兜底");
        }

        // 2) Fade in（cover 从不透明到透明）
        yield return Fade(_coverImage, 1f, 0f, FadeInDuration);
        if (_skipRequested) { ToMainMenu(); yield break; }

        // 3) Hold
        float t = 0f;
        while (t < HoldDuration && !_skipRequested)
        {
            t += Time.unscaledDeltaTime;
            yield return null;
        }

        // 4) Fade out（cover 从透明到不透明）
        yield return Fade(_coverImage, 0f, 1f, FadeOutDuration);

        ToMainMenu();
    }

    private static IEnumerator Fade(Image img, float fromA, float toA, float duration)
    {
        float t = 0f;
        Color c = img.color;
        while (t < duration)
        {
            t += Time.unscaledDeltaTime;
            float k = Mathf.Clamp01(t / duration);
            c.a = Mathf.Lerp(fromA, toA, k);
            img.color = c;
            yield return null;
        }
        c.a = toA;
        img.color = c;
    }

    private void ToMainMenu()
    {
        // 释放纹理 + 进入主菜单
        if (_texHandle.IsValid())
        {
            Addressables.Release(_texHandle);
            _texHandle = default;
        }
        UIScreenManager.Instance.PopAll();
        UIScreenManager.Instance.Show<MainMenuScreen>();
    }

    public override void Hide()
    {
        if (_texHandle.IsValid())
        {
            Addressables.Release(_texHandle);
            _texHandle = default;
        }
        base.Hide();
    }
}
