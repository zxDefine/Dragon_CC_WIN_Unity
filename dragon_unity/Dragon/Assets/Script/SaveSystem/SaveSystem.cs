using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

/// <summary>
/// M4.1 存档/读档后端。JSON + <see cref="Application.persistentDataPath"/>，跨平台、人类可读、
/// Editor/Player 都能工作。
/// </summary>
/// <remarks>
/// 槽位设计（与原版 Renpy 24 槽默认一致）：
/// - 3 列 × 2 行 × 最多 10 页 = 最多 60 槽；M4 首版先开 18 槽（3 页 × 6 槽/页）
/// - 特殊槽：quicksave（q）、autosave（a）
/// 存档路径：<c>{persistentDataPath}/saves/slot_{n}.json</c>
/// 文件命名用数字槽号而非名字，避免 Unicode 文件系统兼容问题。
/// </remarks>
public static class SaveSystem
{
    private const string SaveSubdir = "saves";
    public const int SlotsPerPage = 6;
    public const int MaxPages = 10;
    public const int QuickSlot = -1; // 特殊编号
    public const int AutoSlot = -2;

    public static string SaveDirectory
    {
        get
        {
            string dir = Path.Combine(Application.persistentDataPath, SaveSubdir);
            if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
            return dir;
        }
    }

    public static string SlotPath(int slot)
    {
        string name;
        if (slot == QuickSlot) name = "quicksave.json";
        else if (slot == AutoSlot) name = "autosave.json";
        else name = $"slot_{slot:D3}.json";
        return Path.Combine(SaveDirectory, name);
    }

    public static bool SlotExists(int slot) => File.Exists(SlotPath(slot));

    /// <summary>
    /// 保存当前游戏状态到指定槽。
    /// </summary>
    /// <param name="slot">槽号（正数 = 编号槽；QuickSlot / AutoSlot 为特殊槽）</param>
    /// <param name="currentLabel">当前运行的 label 名（读档恢复入口）</param>
    /// <param name="chapterDisplayName">显示在槽位预览上的章节名</param>
    /// <param name="thumbnailPng">可选 PNG 字节（256×144），存档预览图</param>
    public static bool Save(int slot, string currentLabel, string chapterDisplayName = "", byte[] thumbnailPng = null)
    {
        try
        {
            string thumb = thumbnailPng != null && thumbnailPng.Length > 0
                ? Convert.ToBase64String(thumbnailPng)
                : "";
            GameStateSnapshot snap = GameStateSnapshot.Capture(currentLabel, chapterDisplayName, thumb);
            string json = JsonUtility.ToJson(snap, prettyPrint: true);
            File.WriteAllText(SlotPath(slot), json, System.Text.Encoding.UTF8);
            Debug.Log($"[SaveSystem] Saved slot={slot} label={currentLabel} path={SlotPath(slot)}");
            return true;
        }
        catch (Exception e)
        {
            Debug.LogError($"[SaveSystem] Save slot={slot} failed: {e.Message}");
            return false;
        }
    }

    /// <summary>
    /// 读取指定槽的快照。读取后需调用 <see cref="GameStateSnapshot.Apply"/> 才会写回静态字段。
    /// </summary>
    public static GameStateSnapshot Load(int slot)
    {
        string path = SlotPath(slot);
        if (!File.Exists(path))
        {
            Debug.LogWarning($"[SaveSystem] Load: slot {slot} 不存在 ({path})");
            return null;
        }
        try
        {
            string json = File.ReadAllText(path, System.Text.Encoding.UTF8);
            GameStateSnapshot snap = JsonUtility.FromJson<GameStateSnapshot>(json);
            return snap;
        }
        catch (Exception e)
        {
            Debug.LogError($"[SaveSystem] Load slot={slot} failed: {e.Message}");
            return null;
        }
    }

    /// <summary>删除指定槽。</summary>
    public static bool Delete(int slot)
    {
        string path = SlotPath(slot);
        if (!File.Exists(path)) return false;
        try { File.Delete(path); return true; }
        catch (Exception e) { Debug.LogError($"[SaveSystem] Delete slot={slot} failed: {e.Message}"); return false; }
    }

    /// <summary>列举全部已存在的槽（含 quick/auto）。</summary>
    public static List<SaveSlotInfo> ListSlots()
    {
        var list = new List<SaveSlotInfo>();
        foreach (int special in new[] { AutoSlot, QuickSlot })
        {
            if (SlotExists(special)) list.Add(PeekInfo(special));
        }
        for (int p = 0; p < MaxPages; p++)
        {
            for (int s = 0; s < SlotsPerPage; s++)
            {
                int slot = p * SlotsPerPage + s;
                if (SlotExists(slot)) list.Add(PeekInfo(slot));
            }
        }
        return list;
    }

    /// <summary>轻量预览：只读 saveTime / currentLabel / chapterDisplayName / thumbnail。</summary>
    public static SaveSlotInfo PeekInfo(int slot)
    {
        GameStateSnapshot snap = Load(slot);
        if (snap == null) return new SaveSlotInfo { slot = slot, exists = false };
        return new SaveSlotInfo
        {
            slot = slot,
            exists = true,
            saveTime = snap.saveTime,
            currentLabel = snap.currentLabel,
            chapterDisplayName = snap.chapterDisplayName,
            thumbnailPngBase64 = snap.thumbnailPngBase64,
        };
    }

    public struct SaveSlotInfo
    {
        public int slot;
        public bool exists;
        public string saveTime;
        public string currentLabel;
        public string chapterDisplayName;
        public string thumbnailPngBase64;

        public Texture2D DecodeThumbnail()
        {
            if (string.IsNullOrEmpty(thumbnailPngBase64)) return null;
            try
            {
                byte[] bytes = Convert.FromBase64String(thumbnailPngBase64);
                Texture2D tex = new Texture2D(2, 2);
                tex.LoadImage(bytes);
                return tex;
            }
            catch { return null; }
        }
    }
}
