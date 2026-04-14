using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

/// <summary>
/// 运行时游戏状态快照 DTO。M4.1 存档系统用来把内存里 <see cref="Defaults"/> 家族的静态字段
/// 序列化为 JSON。存档和读档都走反射，新增字段不需要改本文件。
/// </summary>
/// <remarks>
/// 字段采用通用字典的形式而非逐字段硬编码：
/// - <see cref="defaults"/>：顶层 Defaults.XXX（Haogandu / Bai_xin / He_xianzai 等）
/// - <see cref="persistent"/>：Defaults.Persistent.XXX（Povname / Jq_10_5 / Gallery_* / He_ending 等）
/// - <see cref="preferences"/>：Defaults.Preferences.XXX（Text_cps 等）
/// - <see cref="engine"/>：Engine.XXX（_dismiss_pause / _history）
/// - <see cref="currentLabel"/>：当前运行到的 label（存档时由 LabelRegistry / GameMain 主动设置）
/// - <see cref="saveTime"/>：存档时间戳
/// - <see cref="thumbnailPngBase64"/>：可选，256x144 缩略图的 base64 编码
/// </remarks>
[Serializable]
public class GameStateSnapshot
{
    public int version = 1;
    public string saveTime = "";
    public string currentLabel = "";
    public string chapterDisplayName = "";
    public string thumbnailPngBase64 = "";

    // 使用 Serializable 字典兼容 JsonUtility（JsonUtility 不原生支持 Dictionary）
    public List<StringPair> defaults = new List<StringPair>();
    public List<StringPair> persistent = new List<StringPair>();
    public List<StringPair> preferences = new List<StringPair>();
    public List<StringPair> engine = new List<StringPair>();

    [Serializable]
    public struct StringPair
    {
        public string k;
        public string v;
        public StringPair(string key, string value) { k = key; v = value; }
    }

    /// <summary>
    /// 从内存 Defaults/Engine 家族拷贝到当前快照。
    /// </summary>
    public static GameStateSnapshot Capture(string currentLabel = null, string chapterDisplayName = null, string thumbnailBase64 = null)
    {
        GameStateSnapshot snap = new GameStateSnapshot
        {
            saveTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
            currentLabel = currentLabel ?? "",
            chapterDisplayName = chapterDisplayName ?? "",
            thumbnailPngBase64 = thumbnailBase64 ?? "",
        };
        snap.defaults = SerializeStaticFields(typeof(Defaults), true);
        var persistentType = typeof(Defaults).GetNestedType("Persistent", BindingFlags.Public | BindingFlags.Static);
        if (persistentType != null) snap.persistent = SerializeStaticFields(persistentType, true);
        var prefType = typeof(Defaults).GetNestedType("Preferences", BindingFlags.Public | BindingFlags.Static);
        if (prefType != null) snap.preferences = SerializeStaticFields(prefType, true);
        snap.engine = SerializeStaticFields(typeof(Engine), false); // Engine 的 _dismiss_pause 等带下划线
        return snap;
    }

    /// <summary>把当前快照写回静态字段。</summary>
    public void Apply()
    {
        DeserializeStaticFields(typeof(Defaults), defaults);
        var persistentType = typeof(Defaults).GetNestedType("Persistent", BindingFlags.Public | BindingFlags.Static);
        if (persistentType != null) DeserializeStaticFields(persistentType, persistent);
        var prefType = typeof(Defaults).GetNestedType("Preferences", BindingFlags.Public | BindingFlags.Static);
        if (prefType != null) DeserializeStaticFields(prefType, preferences);
        DeserializeStaticFields(typeof(Engine), engine);
    }

    private static List<StringPair> SerializeStaticFields(Type type, bool skipNestedTypes)
    {
        var list = new List<StringPair>();
        if (type == null) return list;
        foreach (FieldInfo f in type.GetFields(BindingFlags.Public | BindingFlags.Static))
        {
            if (skipNestedTypes && f.FieldType.IsClass && f.FieldType != typeof(string) && !f.FieldType.IsPrimitive) continue;
            object val = f.GetValue(null);
            string s = val == null ? "" : Convert.ToString(val, System.Globalization.CultureInfo.InvariantCulture);
            list.Add(new StringPair(f.Name, s));
        }
        return list;
    }

    private static void DeserializeStaticFields(Type type, List<StringPair> pairs)
    {
        if (type == null || pairs == null) return;
        foreach (var pair in pairs)
        {
            FieldInfo f = type.GetField(pair.k, BindingFlags.Public | BindingFlags.Static);
            if (f == null) continue;
            try
            {
                object converted;
                if (f.FieldType == typeof(string)) converted = pair.v;
                else if (f.FieldType == typeof(bool)) converted = bool.Parse(pair.v);
                else if (f.FieldType == typeof(int)) converted = int.Parse(pair.v, System.Globalization.CultureInfo.InvariantCulture);
                else if (f.FieldType == typeof(long)) converted = long.Parse(pair.v, System.Globalization.CultureInfo.InvariantCulture);
                else if (f.FieldType == typeof(float)) converted = float.Parse(pair.v, System.Globalization.CultureInfo.InvariantCulture);
                else if (f.FieldType == typeof(double)) converted = double.Parse(pair.v, System.Globalization.CultureInfo.InvariantCulture);
                else continue;
                f.SetValue(null, converted);
            }
            catch (Exception e)
            {
                Debug.LogWarning($"[GameStateSnapshot] 字段 {type.Name}.{pair.k} 反序列化失败: {e.Message}");
            }
        }
    }
}
