using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

/// <summary>
/// M5.1 成就管理器。持久化到 <c>{persistentDataPath}/achievements.json</c>，
/// 对接 <see cref="GameMethods.GrantAchievement"/> 与回想模式。
/// </summary>
public static class AchievementManager
{
    private const string FileName = "achievements.json";

    [Serializable]
    private class Store
    {
        public List<UnlockedEntry> unlocked = new List<UnlockedEntry>();
    }

    [Serializable]
    public struct UnlockedEntry
    {
        public string id;
        public string unlockTime;
    }

    private static Dictionary<string, UnlockedEntry> _state;
    private static bool _dirty;

    /// <summary>
    /// 加载失败的"毒化"标志。一旦为 true，后续 Sync() 拒绝写回以防止旧存档被空状态覆盖。
    /// 修复 M5 审查 CRITICAL：EnsureLoaded 捕获异常后 _state 变空 → 下次 Sync 会静默擦除旧存档。
    /// </summary>
    private static bool _loadFailed;

    public static event Action<string> OnGranted; // 通知 UI 弹出 toast

    private static string FilePath => Path.Combine(Application.persistentDataPath, FileName);
    private static string BackupPath => Path.Combine(Application.persistentDataPath, FileName + ".corrupted");

    private static void EnsureLoaded()
    {
        if (_state != null) return;
        _state = new Dictionary<string, UnlockedEntry>();
        try
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                Store s = JsonUtility.FromJson<Store>(json);
                if (s != null && s.unlocked != null)
                {
                    foreach (var e in s.unlocked) _state[e.id] = e;
                }
            }
        }
        catch (Exception e)
        {
            // 关键：标记 _loadFailed 以阻止后续 Sync 用空 _state 覆盖磁盘
            _loadFailed = true;
            Debug.LogError($"[AchievementManager] load failed (will NOT overwrite to prevent data loss): {e}");
            // 尝试把损坏文件另存为 .corrupted 备份
            try
            {
                if (File.Exists(FilePath))
                {
                    File.Copy(FilePath, BackupPath, overwrite: true);
                    Debug.LogWarning($"[AchievementManager] corrupted file backed up to {BackupPath}");
                }
            }
            catch (Exception be)
            {
                Debug.LogError($"[AchievementManager] backup failed: {be.Message}");
            }
        }
    }

    /// <summary>授予成就。已解锁的成就不会重复触发事件，返回 true 表示首次解锁。</summary>
    public static bool Grant(string id)
    {
        if (string.IsNullOrEmpty(id)) return false;
        EnsureLoaded();
        if (_state.ContainsKey(id)) return false;

        var def = AchievementRegistry.Get(id);
        if (def == null)
        {
            Debug.LogWarning($"[AchievementManager] Grant unknown id '{id}'（未注册，已忽略）");
            return false;
        }

        _state[id] = new UnlockedEntry
        {
            id = id,
            unlockTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
        };
        _dirty = true;
        Debug.Log($"[AchievementManager] ★ Grant {id} ({def.DisplayName})");
        OnGranted?.Invoke(id);
        return true;
    }

    /// <summary>
    /// 同步到磁盘。仅在状态变更后实际写文件。
    /// 若上次 EnsureLoaded 失败（<see cref="_loadFailed"/> = true），拒绝写入以保护旧存档。
    /// </summary>
    public static void Sync()
    {
        EnsureLoaded();
        if (!_dirty) return;
        if (_loadFailed)
        {
            Debug.LogError("[AchievementManager] Sync aborted: previous load failed. "
                + "Corrupted save was backed up as achievements.json.corrupted; "
                + "clear it manually or call ForceSync() to proceed.");
            return;
        }
        try
        {
            var s = new Store();
            foreach (var kv in _state) s.unlocked.Add(kv.Value);
            string json = JsonUtility.ToJson(s, prettyPrint: true);
            File.WriteAllText(FilePath, json, System.Text.Encoding.UTF8);
            _dirty = false;
            Debug.Log($"[AchievementManager] Sync → {FilePath} ({s.unlocked.Count} unlocked)");
        }
        catch (Exception e)
        {
            Debug.LogException(e);
            Debug.LogError("[AchievementManager] Sync failed (see exception above)");
        }
    }

    /// <summary>
    /// 管理员覆盖：即使 <see cref="_loadFailed"/> 为 true 也强制写回。
    /// 仅应在用户明确选择"覆盖损坏存档"后调用。
    /// </summary>
    public static void ForceSync()
    {
        _loadFailed = false;
        _dirty = true;
        Sync();
    }

    public static bool IsUnlocked(string id)
    {
        EnsureLoaded();
        return _state.ContainsKey(id);
    }

    public static int UnlockedCount
    {
        get { EnsureLoaded(); return _state.Count; }
    }

    public static int TotalCount => AchievementRegistry.All.Length;

    public static IEnumerable<UnlockedEntry> EnumerateUnlocked()
    {
        EnsureLoaded();
        foreach (var kv in _state) yield return kv.Value;
    }

    /// <summary>Debug / 测试用：清空解锁状态。同时清除 <see cref="_loadFailed"/> 以允许后续 Sync。</summary>
    public static void ResetAll()
    {
        _state = new Dictionary<string, UnlockedEntry>();
        _dirty = true;
        _loadFailed = false;
        Sync();
    }
}
