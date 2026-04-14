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

    public static event Action<string> OnGranted; // 通知 UI 弹出 toast

    private static string FilePath => Path.Combine(Application.persistentDataPath, FileName);

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
            Debug.LogError($"[AchievementManager] load failed: {e.Message}");
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
        Debug.Log($"[AchievementManager] 🏆 Grant {id} ({def.displayName})");
        OnGranted?.Invoke(id);
        return true;
    }

    /// <summary>同步到磁盘。仅在状态变更后实际写文件。</summary>
    public static void Sync()
    {
        EnsureLoaded();
        if (!_dirty) return;
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
            Debug.LogError($"[AchievementManager] Sync failed: {e.Message}");
        }
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

    /// <summary>Debug / 测试用：清空解锁状态。</summary>
    public static void ResetAll()
    {
        _state = new Dictionary<string, UnlockedEntry>();
        _dirty = true;
        Sync();
    }
}
