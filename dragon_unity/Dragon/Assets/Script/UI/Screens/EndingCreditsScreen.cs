using System.Collections;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// M5.3 结局字幕滚动屏幕。从底部向上匀速滚动制作人员、角色、原版致谢等信息。
/// 对应 Renpy 原版 demo_rpy/end_zimu.rpy。M5 首版内置一份占位 credits，
/// M6 打磨期间改为从 Addressables 加载真实文本。
/// </summary>
public class EndingCreditsScreen : UIScreenBase
{
    private const float ScrollDuration = 40f; // 完整滚完的时间
    private Text _creditsText;
    private RectTransform _creditsRt;
    private Coroutine _scrollRoutine;

    // 占位 credits 内容（可通过 SetCredits 覆写）
    private static readonly string DefaultCredits = string.Join("\n",
        "— 灾厄黑龙与谎言公主 —",
        "",
        "— Unity 移植版 1.0 —",
        "",
        "",
        "原作",
        "宿命千早",
        "",
        "",
        "原版引擎",
        "Ren'Py",
        "",
        "",
        "移植工程",
        "dragon_cc_win",
        "",
        "",
        "主要角色",
        "公主 · 辛西娅",
        "赫泽尔 · 黑龙",
        "安德鲁 · 勇者",
        "诺伯拉 · 冰龙",
        "洛恩 · 奥术师",
        "妖精商人",
        "",
        "",
        "感谢游玩",
        "— 完 —"
    );

    public static string CustomCredits { get; set; }

    protected override void BuildContent()
    {
        CreateFullScreenBackground(Root, Color.black);

        // 滚动文本容器
        GameObject textGo = new GameObject("CreditsText");
        textGo.transform.SetParent(Root, false);
        _creditsText = textGo.AddComponent<Text>();
        _creditsText.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
        _creditsText.fontSize = 32;
        _creditsText.alignment = TextAnchor.UpperCenter;
        _creditsText.color = Color.white;
        _creditsText.horizontalOverflow = HorizontalWrapMode.Overflow;
        _creditsText.verticalOverflow = VerticalWrapMode.Overflow;
        _creditsText.lineSpacing = 1.4f;

        _creditsRt = textGo.GetComponent<RectTransform>();
        _creditsRt.anchorMin = new Vector2(0.5f, 0f);
        _creditsRt.anchorMax = new Vector2(0.5f, 0f);
        _creditsRt.pivot = new Vector2(0.5f, 0f);
        _creditsRt.sizeDelta = new Vector2(900f, 3000f);
        _creditsRt.anchoredPosition = new Vector2(0f, -1080f);

        // 跳过按钮
        CreateButton(Root, "跳过", new Vector2(800f, -460f), new Vector2(140f, 50f), OnSkip);
    }

    public override void Show()
    {
        _creditsText.text = string.IsNullOrEmpty(CustomCredits) ? DefaultCredits : CustomCredits;
        _creditsRt.anchoredPosition = new Vector2(0f, -1080f);
        base.Show();
        if (_scrollRoutine != null) StopCoroutine(_scrollRoutine);
        _scrollRoutine = StartCoroutine(ScrollRoutine());
    }

    private IEnumerator ScrollRoutine()
    {
        // 从底部滚到顶部
        float startY = -1080f;
        float endY = 2200f;
        float t = 0f;
        while (t < ScrollDuration)
        {
            t += Time.deltaTime;
            float k = Mathf.Clamp01(t / ScrollDuration);
            _creditsRt.anchoredPosition = new Vector2(0f, Mathf.Lerp(startY, endY, k));
            yield return null;
        }
        // 滚完后等 1s 自动返回
        yield return new WaitForSeconds(1f);
        OnSkip();
    }

    private void OnSkip()
    {
        if (_scrollRoutine != null) { StopCoroutine(_scrollRoutine); _scrollRoutine = null; }
        UIScreenManager.Instance.PopAll();
        UIScreenManager.Instance.Show<MainMenuScreen>();
    }
}
