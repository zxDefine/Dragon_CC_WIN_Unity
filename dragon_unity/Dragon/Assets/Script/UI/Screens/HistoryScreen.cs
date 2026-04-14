using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 游戏内对话历史（Renpy 默认 history screen）。
/// M4 首版：保存最近 50 条已显示对话（Defines.Config.History_length）。
/// </summary>
public class HistoryScreen : UIScreenBase
{
    private static readonly Queue<HistoryEntry> _history = new Queue<HistoryEntry>();
    public const int MaxHistory = 50;

    public struct HistoryEntry
    {
        public string character;
        public string text;
    }

    /// <summary>由 DialogueUI 或 GameMethods.OpenDialog 调用以追加历史。</summary>
    public static void Append(string character, string text)
    {
        _history.Enqueue(new HistoryEntry { character = character, text = text });
        while (_history.Count > MaxHistory) _history.Dequeue();
    }

    public static void Clear() => _history.Clear();

    protected override void BuildContent()
    {
        CreateFullScreenBackground(Root, new Color(0.05f, 0.03f, 0.07f, 0.95f));
        CreateLabel(Root, "对话历史", new Vector2(0f, 460f), 42);

        // 内容容器（vertical layout）
        GameObject content = new GameObject("HistoryContent");
        content.transform.SetParent(Root, false);
        VerticalLayoutGroup vlg = content.AddComponent<VerticalLayoutGroup>();
        vlg.spacing = 14f;
        vlg.padding = new RectOffset(40, 40, 20, 20);
        vlg.childAlignment = TextAnchor.UpperCenter;
        vlg.childControlWidth = true;
        vlg.childForceExpandWidth = true;
        ContentSizeFitter csf = content.AddComponent<ContentSizeFitter>();
        csf.verticalFit = ContentSizeFitter.FitMode.PreferredSize;

        RectTransform rt = content.GetComponent<RectTransform>();
        rt.anchorMin = new Vector2(0.5f, 0.5f);
        rt.anchorMax = new Vector2(0.5f, 0.5f);
        rt.pivot = new Vector2(0.5f, 0.5f);
        rt.sizeDelta = new Vector2(1400f, 700f);

        int shown = 0;
        foreach (var entry in _history)
        {
            GameObject row = new GameObject($"Entry_{shown}");
            row.transform.SetParent(content.transform, false);
            Text t = row.AddComponent<Text>();
            t.text = $"{entry.character}: {entry.text}";
            t.fontSize = 20;
            t.color = Color.white;
            t.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
            t.alignment = TextAnchor.MiddleLeft;
            t.horizontalOverflow = HorizontalWrapMode.Wrap;
            shown++;
        }

        if (shown == 0)
        {
            CreateLabel(Root, "(暂无历史)", new Vector2(0f, 100f), 24);
        }

        CreateButton(Root, "返回", new Vector2(0f, -440f), new Vector2(160f, 50f), () => UIScreenManager.Instance.Pop());
    }
}
