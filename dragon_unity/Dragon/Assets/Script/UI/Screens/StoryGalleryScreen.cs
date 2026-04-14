using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// M4.9 剧情回忆 — 对应 Renpy screens.rpy L3807 <c>screen huixiang_juqing</c>。
/// 按章节列出可回顾的剧情片段，点击从对应 label 重新播放（不改变存档进度）。
/// 解锁状态来自 <see cref="Defaults.Persistent"/> 的 Jq_x_y 标志。
/// </summary>
public class StoryGalleryScreen : UIScreenBase
{
    /// <summary>回忆条目：label 名 + 显示名 + 所需的 persistent 字段名（检查 != 0 才算解锁）</summary>
    public struct StoryEntry
    {
        public string label;
        public string displayName;
        public string requiredFlag;
        public StoryEntry(string label, string displayName, string requiredFlag)
        {
            this.label = label;
            this.displayName = displayName;
            this.requiredFlag = requiredFlag;
        }
    }

    private static readonly List<StoryEntry> Entries = new List<StoryEntry>
    {
        new StoryEntry("label_zhuxian0",             "序章 · 觉醒",             "Jq_1_1"),
        new StoryEntry("label_zhuxian_1",            "第一章 · 初入此世",       "Jq_2_1"),
        new StoryEntry("label_zhuxian_2",            "第二章 · 同居",           "Jq_3_1"),
        new StoryEntry("label_zhuxian_3",            "第三章 · 相处",           "Jq_5_1"),
        new StoryEntry("label_zhuxian4",             "第四章 · 决意",           "Jq_7_1"),
        new StoryEntry("label_zhuxian5_bai",         "第五章 · 冰龙子线",       "Jq_8_1"),
        new StoryEntry("label_zhuxian6",             "第六章 · 决战前夜",       "Jq_9_1"),
        new StoryEntry("label_juezhan",              "决战",                    "Jq_9_6"),
        new StoryEntry("label_tuanzhan_you",         "团战 · 勇者线",           "Jq_10_5"),
        new StoryEntry("label_fanhuitu",             "返回途中",                "Jq_10_11"),
        new StoryEntry("label_end6",                 "Happy End · 驯养结局",    "He_ending"),
    };

    protected override void BuildContent()
    {
        CreateFullScreenBackground(Root, new Color(0.03f, 0.03f, 0.08f, 0.95f));
        CreateLabel(Root, "剧情回忆", new Vector2(0f, 460f), 42);

        for (int i = 0; i < Entries.Count; i++)
        {
            var entry = Entries[i];
            bool unlocked = IsUnlocked(entry.requiredFlag);
            int capture = i;
            string label = unlocked ? entry.displayName : $"? ? ? ?（未解锁：{entry.requiredFlag}）";
            var btn = CreateButton(Root, label,
                new Vector2(i % 2 == 0 ? -320f : 320f, 360f - (i / 2) * 80f),
                new Vector2(580f, 66f),
                () => { if (unlocked) OnReplay(capture); });
            // 未解锁禁用
            var image = btn.GetComponent<UnityEngine.UI.Image>();
            if (!unlocked && image != null) image.color = new Color(0.15f, 0.15f, 0.15f, 0.7f);
        }

        CreateButton(Root, "返回", new Vector2(0f, -440f), new Vector2(160f, 50f), () => UIScreenManager.Instance.Pop());
    }

    private static bool IsUnlocked(string flagName)
    {
        // 反射读取 Defaults.Persistent.<flagName>
        var persistentType = typeof(Defaults).GetNestedType("Persistent", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
        var field = persistentType?.GetField(flagName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
        if (field == null)
        {
            // 也许在 Defaults 顶层
            field = typeof(Defaults).GetField(flagName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
        }
        if (field == null) return false;
        object v = field.GetValue(null);
        if (v is int iv) return iv != 0;
        if (v is bool bv) return bv;
        return false;
    }

    private void OnReplay(int idx)
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
