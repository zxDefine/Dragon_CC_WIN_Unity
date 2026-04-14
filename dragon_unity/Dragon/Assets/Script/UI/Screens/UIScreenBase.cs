using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

/// <summary>
/// M4 所有 UGUI 屏幕的公共基类。负责建立 full-screen Canvas、overlay 背景、
/// 以及一组通用的 UI 工厂方法（按钮 / 标签 / 滚动网格）用于纯代码构建画面。
/// </summary>
/// <remarks>
/// 所有 M4 screen 都通过 <see cref="UIScreenManager"/> 压栈管理显示隐藏。
/// 屏幕实例是 MonoBehaviour，被挂在一个 DontDestroyOnLoad 的 GameObject 上。
/// 默认 1920x1080 参考分辨率，与 GameState.Gui 配合。
/// </remarks>
public abstract class UIScreenBase : MonoBehaviour
{
    public Canvas Canvas { get; private set; }
    public RectTransform Root { get; private set; }
    public bool IsVisible => Canvas != null && Canvas.enabled;

    /// <summary>每个屏幕 sortingOrder，后入栈的屏幕显示在更高层。</summary>
    public int SortingOrder { get; set; } = 100;

    protected virtual void Awake()
    {
        BuildCanvas();
        BuildContent();
        Hide();
    }

    private void BuildCanvas()
    {
        Canvas = gameObject.AddComponent<Canvas>();
        Canvas.renderMode = RenderMode.ScreenSpaceOverlay;
        Canvas.sortingOrder = SortingOrder;
        gameObject.AddComponent<CanvasScaler>().uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        var scaler = GetComponent<CanvasScaler>();
        scaler.referenceResolution = new Vector2(1920f, 1080f);
        scaler.matchWidthOrHeight = 0.5f;
        gameObject.AddComponent<GraphicRaycaster>();
        Root = GetComponent<RectTransform>();
    }

    /// <summary>
    /// 子类在 <see cref="Awake"/> 调用时构建自己的 UGUI 结构。
    /// </summary>
    protected abstract void BuildContent();

    public virtual void Show()
    {
        if (Canvas != null) Canvas.enabled = true;
        gameObject.SetActive(true);
    }

    public virtual void Hide()
    {
        if (Canvas != null) Canvas.enabled = false;
    }

    // --- 通用 UI 工厂 --- //

    protected static GameObject CreateFullScreenBackground(RectTransform parent, Color color)
    {
        GameObject bg = new GameObject("Background");
        bg.transform.SetParent(parent, false);
        Image img = bg.AddComponent<Image>();
        img.color = color;
        RectTransform rt = bg.GetComponent<RectTransform>();
        rt.anchorMin = Vector2.zero;
        rt.anchorMax = Vector2.one;
        rt.offsetMin = Vector2.zero;
        rt.offsetMax = Vector2.zero;
        return bg;
    }

    protected static GameObject CreateLabel(Transform parent, string text, Vector2 pos, int fontSize = 24, TextAnchor align = TextAnchor.MiddleCenter)
    {
        GameObject go = new GameObject("Label");
        go.transform.SetParent(parent, false);
        Text t = go.AddComponent<Text>();
        t.text = text;
        t.fontSize = fontSize;
        t.alignment = align;
        t.color = Color.white;
        t.font = UIFontProvider.Current;
        t.horizontalOverflow = HorizontalWrapMode.Overflow;
        t.verticalOverflow = VerticalWrapMode.Overflow;
        RectTransform rt = go.GetComponent<RectTransform>();
        rt.anchorMin = new Vector2(0.5f, 0.5f);
        rt.anchorMax = new Vector2(0.5f, 0.5f);
        rt.pivot = new Vector2(0.5f, 0.5f);
        rt.anchoredPosition = pos;
        rt.sizeDelta = new Vector2(800f, fontSize * 1.6f);
        return go;
    }

    protected static GameObject CreateButton(Transform parent, string label, Vector2 pos, Vector2 size, UnityAction onClick)
    {
        GameObject go = new GameObject("Button_" + label);
        go.transform.SetParent(parent, false);
        Image img = go.AddComponent<Image>();
        img.color = new Color(0.15f, 0.15f, 0.2f, 0.9f);
        Button btn = go.AddComponent<Button>();
        ColorBlock cb = btn.colors;
        cb.normalColor = new Color(1f, 1f, 1f, 1f);
        cb.highlightedColor = new Color(0.9f, 0.6f, 0.6f, 1f);
        cb.pressedColor = new Color(0.7f, 0.3f, 0.3f, 1f);
        btn.colors = cb;
        if (onClick != null) btn.onClick.AddListener(onClick);

        RectTransform rt = go.GetComponent<RectTransform>();
        rt.anchorMin = new Vector2(0.5f, 0.5f);
        rt.anchorMax = new Vector2(0.5f, 0.5f);
        rt.pivot = new Vector2(0.5f, 0.5f);
        rt.anchoredPosition = pos;
        rt.sizeDelta = size;

        // 按钮内部文字
        GameObject txt = new GameObject("Text");
        txt.transform.SetParent(go.transform, false);
        Text text = txt.AddComponent<Text>();
        text.text = label;
        text.alignment = TextAnchor.MiddleCenter;
        text.color = Color.white;
        text.fontSize = 22;
        text.font = UIFontProvider.Current;
        RectTransform trt = txt.GetComponent<RectTransform>();
        trt.anchorMin = Vector2.zero;
        trt.anchorMax = Vector2.one;
        trt.offsetMin = Vector2.zero;
        trt.offsetMax = Vector2.zero;
        return go;
    }

    protected static GameObject CreateSlider(Transform parent, string labelText, Vector2 pos, float min, float max, float current, UnityAction<float> onChange)
    {
        GameObject go = new GameObject("Slider_" + labelText);
        go.transform.SetParent(parent, false);

        // 标签
        GameObject lab = CreateLabel(go.transform, labelText, new Vector2(-260f, 0f), 22, TextAnchor.MiddleRight);
        RectTransform labRt = lab.GetComponent<RectTransform>();
        labRt.sizeDelta = new Vector2(200f, 40f);

        // 滑动条
        GameObject sliderGo = new GameObject("Slider");
        sliderGo.transform.SetParent(go.transform, false);
        Image bg = sliderGo.AddComponent<Image>();
        bg.color = new Color(0.2f, 0.2f, 0.2f, 0.8f);
        Slider slider = sliderGo.AddComponent<Slider>();
        slider.minValue = min;
        slider.maxValue = max;
        slider.value = current;
        if (onChange != null) slider.onValueChanged.AddListener(onChange);
        RectTransform sRt = sliderGo.GetComponent<RectTransform>();
        sRt.anchorMin = new Vector2(0.5f, 0.5f);
        sRt.anchorMax = new Vector2(0.5f, 0.5f);
        sRt.pivot = new Vector2(0f, 0.5f);
        sRt.anchoredPosition = new Vector2(-140f, 0f);
        sRt.sizeDelta = new Vector2(400f, 20f);

        RectTransform rt = go.GetComponent<RectTransform>();
        rt.anchorMin = new Vector2(0.5f, 0.5f);
        rt.anchorMax = new Vector2(0.5f, 0.5f);
        rt.pivot = new Vector2(0.5f, 0.5f);
        rt.anchoredPosition = pos;
        rt.sizeDelta = new Vector2(700f, 40f);
        return go;
    }
}
