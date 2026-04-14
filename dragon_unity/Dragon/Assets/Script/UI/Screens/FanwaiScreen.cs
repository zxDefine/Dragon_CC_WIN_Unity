using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// M4.12 番外短篇 — 对应 Renpy screens.rpy L1880 <c>screen fanwai</c> 系列。
/// 列出所有已解锁的番外剧情。
/// </summary>
public class FanwaiScreen : UIScreenBase
{
    public struct FanwaiEntry
    {
        public string displayName;
        public string label;        // 入口 label
        public string requiredFlag; // Gallery_fanwai*_lock != 0
        public FanwaiEntry(string name, string label, string flag) { displayName = name; this.label = label; requiredFlag = flag; }
    }

    private static readonly List<FanwaiEntry> Entries = new List<FanwaiEntry>
    {
        new FanwaiEntry("番外 · 日常小景",   "label_fanwai_1_sub1", "Gallery_fanwai1_lock"),
        new FanwaiEntry("番外 · 雪夜谈话",   "label_fanwai_1_sub2", "Gallery_fanwai2_lock"),
        new FanwaiEntry("番外 · 桃花盛开",   "label_fanwai_1_sub3", "Gallery_fanwai3_lock"),
        new FanwaiEntry("番外 · 妖精交易",   "label_fanwai_js",     "Gallery_js_lock"),
    };

    protected override void BuildContent()
    {
        CreateFullScreenBackground(Root, new Color(0.05f, 0.04f, 0.08f, 0.95f));
        CreateLabel(Root, "番外短篇", new Vector2(0f, 440f), 42);

        for (int i = 0; i < Entries.Count; i++)
        {
            var e = Entries[i];
            bool unlocked = IsUnlocked(e.requiredFlag);
            int capture = i;
            string label = unlocked ? e.displayName : $"? ? ? ?（未解锁：{e.requiredFlag}）";
            var btn = CreateButton(Root, label, new Vector2(0f, 300f - i * 90f), new Vector2(640f, 70f),
                () => { if (unlocked) OnPlayFanwai(capture); });
            var img = btn.GetComponent<UnityEngine.UI.Image>();
            if (!unlocked && img != null) img.color = new Color(0.12f, 0.12f, 0.12f, 0.85f);
        }

        CreateButton(Root, "返回", new Vector2(0f, -440f), new Vector2(160f, 50f), () => UIScreenManager.Instance.Pop());
    }

    private static bool IsUnlocked(string flag)
    {
        var persistentType = typeof(Defaults).GetNestedType("Persistent", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
        var f = persistentType?.GetField(flag, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
        if (f == null) return false;
        object v = f.GetValue(null);
        return v is int iv ? iv != 0 : false;
    }

    private void OnPlayFanwai(int idx)
    {
        if (idx < 0 || idx >= Entries.Count) return;
        UIScreenManager.Instance.PopAll();
        var gm = GameObject.Find("Game Methods")?.GetComponent<GameMethods>();
        if (gm != null && LabelRegistry.Instance != null)
        {
            gm.StartCoroutine(LabelRegistry.Instance.RunCoroutineByMethodOnly(Entries[idx].label));
        }
    }
}
