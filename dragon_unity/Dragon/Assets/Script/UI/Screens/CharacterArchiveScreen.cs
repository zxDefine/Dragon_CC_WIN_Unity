using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// M4.11 角色档案 — 对应 Renpy screens.rpy L6274 <c>screen juesedangan</c>。
/// 展示游戏里出场角色的基本信息 + 解锁度。
/// </summary>
public class CharacterArchiveScreen : UIScreenBase
{
    public struct CharacterProfile
    {
        public string displayName;
        public string key;         // 在 Defaults 里的 Haogandu_* 字段
        public string description;
        public CharacterProfile(string name, string key, string desc)
        {
            displayName = name;
            this.key = key;
            description = desc;
        }
    }

    private static readonly List<CharacterProfile> Profiles = new List<CharacterProfile>
    {
        new CharacterProfile("诺伯拉 · 冰龙",       "Haogandu_nuo", "冷静洒脱的冰龙，公主的契约伙伴。"),
        new CharacterProfile("安德鲁 · 勇者",       "Haogandu_an",  "金发少年，为救公主踏上旅途。"),
        new CharacterProfile("赫泽尔 · 灾厄黑龙",   "Haogandu_he",  "被预言视为终结者的黑龙，面无表情的少年体型。"),
        new CharacterProfile("洛恩 · 奥术师",       "",             "蓝发博学者，与勇者同行。"),
        new CharacterProfile("妖精商人",             "",             "与公主订立契约的神秘商人。"),
    };

    protected override void BuildContent()
    {
        CreateFullScreenBackground(Root, new Color(0.04f, 0.03f, 0.08f, 0.95f));
        CreateLabel(Root, "角色档案", new Vector2(0f, 460f), 42);

        for (int i = 0; i < Profiles.Count; i++)
        {
            var p = Profiles[i];
            int favor = ReadFavor(p.key);
            string line = string.IsNullOrEmpty(p.key)
                ? $"{p.displayName}"
                : $"{p.displayName}    好感度:{favor}";
            CreateLabel(Root, line, new Vector2(0f, 340f - i * 110f), 24);
            CreateLabel(Root, p.description, new Vector2(0f, 340f - i * 110f - 36f), 18);
        }

        CreateButton(Root, "返回", new Vector2(0f, -440f), new Vector2(160f, 50f), () => UIScreenManager.Instance.Pop());
    }

    private static int ReadFavor(string key)
    {
        if (string.IsNullOrEmpty(key)) return 0;
        var f = typeof(Defaults).GetField(key, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
        if (f == null) return 0;
        object v = f.GetValue(null);
        return v is int iv ? iv : 0;
    }
}
