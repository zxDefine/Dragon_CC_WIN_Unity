using System.Collections;
using UnityEngine;

public class GameMain : MonoBehaviour
{
    [Header("启动配置")]
    [Tooltip("留空表示走主菜单；填 label_zhuxian0 之类会跳过主菜单直接进入对应章节（调试用）。")]
    public string startLabel = "";

    IEnumerator Start()
    {
        // 等待一帧，确保场景中所有 GameObject 初始化完成
        yield return null;

        // BUG-02 修复：等待三大 Manager 通过 Addressables 异步加载完成
        // DialogManager / CharacterManager / ImageManager 在 Start() 协程里才真正完成数据装载
        while (!ManagersReady())
        {
            yield return null;
        }

        // 然后获取 GameMethods
        GameMethods gm = GameObject.Find("Game Methods")?.GetComponent<GameMethods>();
        if (gm == null)
        {
            Debug.LogError("找不到 Game Methods 或缺少 GameMethods 组件");
            yield break;
        }

        // 注册所有 label（LabelRegistry 必须在同一个场景中）
        LabelRegistry.Instance.InjectDependency("GameMethods", gm);
        yield return LabelRegistry.Instance.RegisterAllLabelsFromTxt();

        // M4：根据 startLabel 决定走主菜单还是直接启动指定章节
        if (string.IsNullOrWhiteSpace(startLabel))
        {
            // 无指定 label → 弹主菜单，等待玩家点击"开始游戏"或"读取存档"
            if (UIScreenManager.Instance != null)
            {
                UIScreenManager.Instance.Show<MainMenuScreen>();
                Debug.Log("[GameMain] 进入主菜单（startLabel 为空）");
            }
            else
            {
                Debug.LogError("[GameMain] UIScreenManager 不存在，回退到默认 label");
                yield return LabelRegistry.Instance.RunCoroutineByMethodOnly("label_zhuxian0");
            }
        }
        else
        {
            // 指定了 startLabel → 跳过主菜单，直接进入（调试用）
            Debug.Log($"[GameMain] 跳过主菜单，直接进入 {startLabel}");
            yield return LabelRegistry.Instance.RunCoroutineByMethodOnly(startLabel);
        }
    }

    private static bool ManagersReady()
    {
        return DialogManager.Instance != null && DialogManager.Instance.IsReady
            && CharacterManager.Instance != null && CharacterManager.Instance.IsReady
            && ImageManager.Instance != null && ImageManager.Instance.IsReady;
    }

    /// <summary>
    /// 应用退出时的安全网：即使某个 cs 遗漏了 <c>SyncAchievement()</c>，
    /// 这里仍会把未持久化的成就解锁刷回磁盘，避免玩家流失成就。
    /// 同时由 <see cref="AchievementManager._loadFailed"/> 守护，不会覆盖损坏的旧存档。
    /// </summary>
    private void OnApplicationQuit()
    {
        try { AchievementManager.Sync(); }
        catch (System.Exception e) { Debug.LogException(e); }
    }
}