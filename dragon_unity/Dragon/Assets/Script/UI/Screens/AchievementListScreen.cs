using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// M5 成就浏览页。按网格列出全部 11 条成就，未解锁的显示为问号。
/// </summary>
public class AchievementListScreen : UIScreenBase
{
    protected override void BuildContent()
    {
        CreateFullScreenBackground(Root, new Color(0.05f, 0.05f, 0.08f, 0.96f));
        CreateLabel(Root, "成就", new Vector2(0f, 450f), 42);
        CreateLabel(Root,
            $"已解锁 {AchievementManager.UnlockedCount}/{AchievementManager.TotalCount}",
            new Vector2(0f, 400f), 22);

        // 网格容器
        GameObject gridGo = new GameObject("AchGrid");
        gridGo.transform.SetParent(Root, false);
        var glg = gridGo.AddComponent<GridLayoutGroup>();
        glg.cellSize = new Vector2(420f, 120f);
        glg.spacing = new Vector2(20f, 20f);
        glg.padding = new RectOffset(20, 20, 20, 20);
        glg.childAlignment = TextAnchor.UpperCenter;
        RectTransform gridRt = gridGo.GetComponent<RectTransform>();
        gridRt.anchorMin = new Vector2(0.5f, 0.5f);
        gridRt.anchorMax = new Vector2(0.5f, 0.5f);
        gridRt.pivot = new Vector2(0.5f, 0.5f);
        gridRt.anchoredPosition = new Vector2(0f, 20f);
        gridRt.sizeDelta = new Vector2(1400f, 720f);

        foreach (var def in AchievementRegistry.All)
        {
            CreateAchievementCard(gridGo.transform, def);
        }

        CreateButton(Root, "返回", new Vector2(0f, -460f), new Vector2(160f, 50f),
            () => UIScreenManager.Instance.Pop());
    }

    private static void CreateAchievementCard(Transform parent, AchievementRegistry.AchievementDef def)
    {
        bool unlocked = AchievementManager.IsUnlocked(def.Id);
        GameObject card = new GameObject("Card_" + def.Id);
        card.transform.SetParent(parent, false);
        Image bg = card.AddComponent<Image>();
        bg.color = unlocked
            ? new Color(0.18f, 0.12f, 0.05f, 0.9f)
            : new Color(0.08f, 0.08f, 0.1f, 0.85f);

        // 标题。使用中文方括号前缀代替 emoji 避免 LegacyRuntime.ttf 缺字形
        GameObject titleGo = new GameObject("Title");
        titleGo.transform.SetParent(card.transform, false);
        Text title = titleGo.AddComponent<Text>();
        title.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
        title.alignment = TextAnchor.MiddleLeft;
        title.fontSize = 22;
        string prefix = unlocked ? "[已解锁] " : "[未解锁] ";
        title.text = prefix + (unlocked ? def.DisplayName : (def.Hidden ? "???" : def.DisplayName));
        title.color = unlocked ? new Color(1f, 0.85f, 0.4f, 1f) : new Color(0.6f, 0.6f, 0.6f, 1f);
        RectTransform trt = titleGo.GetComponent<RectTransform>();
        trt.anchorMin = new Vector2(0f, 1f);
        trt.anchorMax = new Vector2(1f, 1f);
        trt.pivot = new Vector2(0.5f, 1f);
        trt.offsetMin = new Vector2(20f, -50f);
        trt.offsetMax = new Vector2(-20f, -10f);

        // 描述
        GameObject descGo = new GameObject("Desc");
        descGo.transform.SetParent(card.transform, false);
        Text desc = descGo.AddComponent<Text>();
        desc.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
        desc.alignment = TextAnchor.UpperLeft;
        desc.fontSize = 16;
        desc.text = unlocked ? def.Description : (def.Hidden ? "（未解锁）" : def.Description);
        desc.color = unlocked ? new Color(0.95f, 0.95f, 0.95f, 1f) : new Color(0.5f, 0.5f, 0.5f, 1f);
        desc.horizontalOverflow = HorizontalWrapMode.Wrap;
        desc.verticalOverflow = VerticalWrapMode.Truncate;
        RectTransform drt = descGo.GetComponent<RectTransform>();
        drt.anchorMin = new Vector2(0f, 0f);
        drt.anchorMax = new Vector2(1f, 1f);
        drt.pivot = new Vector2(0.5f, 0.5f);
        drt.offsetMin = new Vector2(20f, 10f);
        drt.offsetMax = new Vector2(-20f, -55f);
    }
}
