using System.Collections;
using UnityEngine;

public class GameMain : MonoBehaviour
{
    [Header("启动配置")]
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

        // 启动游戏流程（运行指定 label 协程）
        // StartCoroutine(LabelRegistry.Instance.RunCoroutineLabel("fanhuitu.label_intro"));
        yield return LabelRegistry.Instance.RunCoroutineByMethodOnly(startLabel);
    }

    private static bool ManagersReady()
    {
        return DialogManager.Instance != null && DialogManager.Instance.IsReady
            && CharacterManager.Instance != null && CharacterManager.Instance.IsReady
            && ImageManager.Instance != null && ImageManager.Instance.IsReady;
    }
}