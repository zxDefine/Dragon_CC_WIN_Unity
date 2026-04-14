using System.Collections;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// M5.4 成就解锁 Toast 通知。右上角弹出 3 秒滑入/滑出。
/// 对应 Renpy screens.rpy 里 Tips/HideTips 两个屏幕的功能。
/// </summary>
public class AchievementToastScreen : UIScreenBase
{
    public static AchievementToastScreen Instance { get; private set; }

    private GameObject _card;
    private Text _titleText;
    private Text _subText;
    private Coroutine _activeRoutine;

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
    private static void AutoBootstrap()
    {
        if (Instance != null) return;
        // Show<T> 会自动创建并 push 到栈顶；但 Toast 需要常驻，直接 GetOrCreate 避免进栈
        if (UIScreenManager.Instance != null)
        {
            var toast = UIScreenManager.Instance.GetOrCreate<AchievementToastScreen>();
            toast.SortingOrder = 500; // 高优先级
            toast.Canvas.sortingOrder = 500;
        }
    }

    protected override void Awake()
    {
        base.Awake();
        if (Instance == null) Instance = this;
        // Toast 默认不显示 (base.Hide in Awake 已处理)
    }

    protected override void BuildContent()
    {
        // 右上角卡片
        _card = new GameObject("AchievementCard");
        _card.transform.SetParent(Root, false);
        Image bg = _card.AddComponent<Image>();
        bg.color = new Color(0.08f, 0.08f, 0.12f, 0.92f);
        RectTransform rt = _card.GetComponent<RectTransform>();
        rt.anchorMin = new Vector2(1f, 1f);
        rt.anchorMax = new Vector2(1f, 1f);
        rt.pivot = new Vector2(1f, 1f);
        rt.anchoredPosition = new Vector2(-30f, -30f);
        rt.sizeDelta = new Vector2(480f, 120f);

        // 使用中文标题代替 emoji 避免 LegacyRuntime.ttf 缺字形
        _titleText = CreateToastLabel(_card.transform, "★ 成就解锁", new Vector2(0f, 30f), 26, new Color(1f, 0.85f, 0.4f, 1f));
        _subText = CreateToastLabel(_card.transform, "", new Vector2(0f, -15f), 18, Color.white);

        _card.SetActive(false);
    }

    private static Text CreateToastLabel(Transform parent, string text, Vector2 pos, int size, Color color)
    {
        GameObject go = new GameObject("ToastLabel");
        go.transform.SetParent(parent, false);
        Text t = go.AddComponent<Text>();
        t.text = text;
        t.fontSize = size;
        t.color = color;
        t.alignment = TextAnchor.MiddleCenter;
        t.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
        t.horizontalOverflow = HorizontalWrapMode.Overflow;
        RectTransform rt = go.GetComponent<RectTransform>();
        rt.anchorMin = new Vector2(0.5f, 0.5f);
        rt.anchorMax = new Vector2(0.5f, 0.5f);
        rt.pivot = new Vector2(0.5f, 0.5f);
        rt.anchoredPosition = pos;
        rt.sizeDelta = new Vector2(460f, size * 1.6f);
        return t;
    }

    /// <summary>
    /// 展示一条成就解锁通知。已解锁状态已由 <see cref="AchievementManager"/> 判定，
    /// 本方法只负责视觉弹窗；若 <paramref name="achievementId"/> 未在注册表就静默跳过。
    /// </summary>
    public void ShowToast(string achievementId)
    {
        var def = AchievementRegistry.Get(achievementId);
        if (def == null) return;

        // 强制 Canvas 可见但不入栈（Toast 是 HUD 型 overlay）
        if (Canvas != null) Canvas.enabled = true;
        gameObject.SetActive(true);

        _subText.text = def.DisplayName;
        _card.SetActive(true);

        if (_activeRoutine != null) StopCoroutine(_activeRoutine);
        _activeRoutine = StartCoroutine(ToastRoutine());
    }

    private IEnumerator ToastRoutine()
    {
        RectTransform rt = _card.GetComponent<RectTransform>();
        Vector2 from = new Vector2(500f, -30f);  // 屏幕右侧外
        Vector2 to = new Vector2(-30f, -30f);

        // 滑入
        float dur = 0.4f;
        for (float t = 0f; t < dur; t += Time.unscaledDeltaTime)
        {
            float k = Mathf.SmoothStep(0f, 1f, t / dur);
            rt.anchoredPosition = Vector2.Lerp(from, to, k);
            yield return null;
        }
        rt.anchoredPosition = to;

        // 停留
        yield return new WaitForSecondsRealtime(2.8f);

        // 滑出
        for (float t = 0f; t < dur; t += Time.unscaledDeltaTime)
        {
            float k = Mathf.SmoothStep(0f, 1f, t / dur);
            rt.anchoredPosition = Vector2.Lerp(to, from, k);
            yield return null;
        }
        _card.SetActive(false);
        _activeRoutine = null;
    }
}
