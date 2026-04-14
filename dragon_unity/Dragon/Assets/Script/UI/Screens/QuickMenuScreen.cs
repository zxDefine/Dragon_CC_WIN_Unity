using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// M4.3 游戏内快捷菜单覆盖层 — 对应 Renpy screens.rpy L486 <c>screen quick_menu</c>。
/// 贴在画面底部的小按钮条：回退 / 跳过 / 自动 / 保存 / Q存 / Q读 / 历史 / 隐藏 / 设置。
/// </summary>
/// <remarks>
/// 与普通栈式屏幕不同，QuickMenu 是半透明 HUD：对话时可见，主菜单时隐藏。
/// 由 <c>Defaults.Quick_menu_none</c> 切换显示。
/// </remarks>
public class QuickMenuScreen : UIScreenBase
{
    protected override void BuildContent()
    {
        // 底部横条背景（不遮整屏）
        GameObject bar = new GameObject("QuickMenuBar");
        bar.transform.SetParent(Root, false);
        Image img = bar.AddComponent<Image>();
        img.color = new Color(0f, 0f, 0f, 0.5f);
        RectTransform barRt = bar.GetComponent<RectTransform>();
        barRt.anchorMin = new Vector2(0f, 0f);
        barRt.anchorMax = new Vector2(1f, 0f);
        barRt.pivot = new Vector2(0.5f, 0f);
        barRt.anchoredPosition = Vector2.zero;
        barRt.sizeDelta = new Vector2(0f, 40f);

        // 一行横排按钮
        string[] labels = { "回退", "跳过", "自动", "保存", "Q存", "Q读", "历史", "隐藏", "设置", "菜单" };
        System.Action[] handlers =
        {
            OnBack, OnSkip, OnAuto, OnSave, OnQuickSave, OnQuickLoad, OnHistory, OnHide, OnSettings, OnGameMenu,
        };
        float total = labels.Length;
        float spacing = 1920f / (total + 1f);
        for (int i = 0; i < labels.Length; i++)
        {
            int capture = i;
            var btn = CreateButton(bar.transform, labels[i], new Vector2(spacing * (i + 1) - 960f, 0f), new Vector2(80f, 30f), () => handlers[capture]());
            // 覆盖尺寸与字号
            var bText = btn.GetComponentInChildren<Text>();
            if (bText != null) bText.fontSize = 14;
        }
    }

    public override void Show()
    {
        if (Defaults.Quick_menu_none) return;
        base.Show();
    }

    private void OnBack() { Debug.Log("[QuickMenu] 回退（M4 占位，需接对话历史回滚）"); }
    private void OnSkip() { Defaults.Preferences.Afm_time = Mathf.Max(1, Defaults.Preferences.Afm_time - 2); Debug.Log("[QuickMenu] 跳过"); }
    private void OnAuto() { Engine._dismiss_pause = !Engine._dismiss_pause; Debug.Log($"[QuickMenu] 自动：{Engine._dismiss_pause}"); }
    private void OnSave() { UIScreenManager.Instance.Show<SaveScreen>(); }
    private void OnQuickSave()
    {
        SaveSystem.Save(SaveSystem.QuickSlot, CurrentLabelHint(), "快存");
        Debug.Log("[QuickMenu] Q 存完成");
    }
    private void OnQuickLoad()
    {
        var snap = SaveSystem.Load(SaveSystem.QuickSlot);
        if (snap != null)
        {
            snap.Apply();
            Debug.Log($"[QuickMenu] Q 读：label={snap.currentLabel}");
            // 跳到存档时 label
            var gm = GameObject.Find("Game Methods")?.GetComponent<GameMethods>();
            if (gm != null && !string.IsNullOrEmpty(snap.currentLabel) && LabelRegistry.Instance != null)
            {
                gm.StartCoroutine(LabelRegistry.Instance.RunCoroutineByMethodOnly(snap.currentLabel));
            }
        }
    }
    private void OnHistory() { UIScreenManager.Instance.Show<HistoryScreen>(); }
    private void OnHide() { Hide(); }
    private void OnSettings() { UIScreenManager.Instance.Show<SettingsScreen>(); }
    private void OnGameMenu() { UIScreenManager.Instance.Show<GameMenuScreen>(); }

    private static string CurrentLabelHint()
    {
        // TODO(M4 后续)：由 LabelRegistry 公开"当前正在执行的 label"方便存档定位
        return "";
    }
}
