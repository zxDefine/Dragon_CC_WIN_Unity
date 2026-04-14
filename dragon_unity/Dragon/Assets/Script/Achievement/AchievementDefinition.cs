using System;
using System.Collections.Generic;

/// <summary>
/// M5.1 成就定义 + 注册表。11 条成就对应 Renpy 原版 test_achievements.rpy
/// 中注册的 NEW_ACHIEVEMENT_1_0 ~ NEW_ACHIEVEMENT_1_10。
/// </summary>
public static class AchievementRegistry
{
    /// <summary>
    /// 单条成就的不可变描述。字段只读，避免外部运行时修改注册表（审查建议）。
    /// </summary>
    public class AchievementDef
    {
        public string Id { get; }
        public string DisplayName { get; }
        public string Description { get; }
        /// <summary>未解锁时是否隐藏描述（"???"占位）。</summary>
        public bool Hidden { get; }

        public AchievementDef(string id, string name, string desc, bool hidden = false)
        {
            Id = id;
            DisplayName = name;
            Description = desc;
            Hidden = hidden;
        }
    }

    /// <summary>
    /// 11 条成就定义。显示名 / 描述根据原版剧情语境给出，均为推测性文案，
    /// M6 打磨期间会与原版 gui/achievements 图标资源对齐。
    /// </summary>
    public static readonly AchievementDef[] All = new AchievementDef[]
    {
        new AchievementDef("NEW_ACHIEVEMENT_1_0",  "初见",         "第一次与黑龙相遇。"),
        new AchievementDef("NEW_ACHIEVEMENT_1_1",  "同居生活",     "开始与赫泽尔的朝夕相处。"),
        new AchievementDef("NEW_ACHIEVEMENT_1_2",  "成长",         "完成第一年的日常。"),
        new AchievementDef("NEW_ACHIEVEMENT_1_3",  "真言启蒙",     "学会第一句真言。"),
        new AchievementDef("NEW_ACHIEVEMENT_1_4",  "契约冰龙",     "与诺伯拉缔结契约。"),
        new AchievementDef("NEW_ACHIEVEMENT_1_5",  "妖精交易",     "与妖精商人达成第一笔交易。"),
        new AchievementDef("NEW_ACHIEVEMENT_1_6",  "勇者之心",     "赢得安德鲁的好感。"),
        new AchievementDef("NEW_ACHIEVEMENT_1_7",  "决战前夜",     "站上决战的悬崖。"),
        new AchievementDef("NEW_ACHIEVEMENT_1_8",  "灾厄终结",     "以威胁终结了灾厄之龙。"),
        new AchievementDef("NEW_ACHIEVEMENT_1_9",  "超越百点",     "任意角色好感度突破 100。", hidden: true),
        new AchievementDef("NEW_ACHIEVEMENT_1_10", "Happy End",    "解锁驯养结局。", hidden: true),
    };

    private static Dictionary<string, AchievementDef> _byId;
    public static AchievementDef Get(string id)
    {
        if (_byId == null)
        {
            _byId = new Dictionary<string, AchievementDef>();
            foreach (var a in All) _byId[a.id] = a;
        }
        return _byId.TryGetValue(id, out var def) ? def : null;
    }
}
