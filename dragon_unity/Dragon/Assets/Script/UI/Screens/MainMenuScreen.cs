using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// M4.2 主菜单 — 对应 Renpy screens.rpy L808 <c>screen main_menu</c>。
/// 按钮：开始 / 读档 / 附加（extras）/ 设置 / 退出。
/// </summary>
/// <remarks>
/// 视觉上与原版有差距（原版用 gui/main_menu.png 背景 + 自定义字体 + 特殊按钮样式），
/// M4 首版用纯色背景 + 内置字体确保能跑；M6 打磨阶段再接美术资源。
/// </remarks>
public class MainMenuScreen : UIScreenBase
{
    protected override void BuildContent()
    {
        CreateFullScreenBackground(Root, new Color(0.08f, 0.05f, 0.1f, 1f));
        CreateLabel(Root, "灾厄黑龙与谎言公主", new Vector2(0f, 280f), 60);
        CreateLabel(Root, "v1.0 — Unity 移植版", new Vector2(0f, 210f), 18);

        // 7 个主按钮（对应 Renpy navigation.rpy L722）
        float x = -500f;
        float y0 = 60f;
        float step = -80f;
        CreateButton(Root, "开始游戏", new Vector2(x, y0 + step * 0), new Vector2(260f, 60f), OnStartGame);
        CreateButton(Root, "读取存档", new Vector2(x, y0 + step * 1), new Vector2(260f, 60f), OnLoadGame);
        CreateButton(Root, "设置",     new Vector2(x, y0 + step * 2), new Vector2(260f, 60f), OnSettings);
        CreateButton(Root, "附加内容", new Vector2(x, y0 + step * 3), new Vector2(260f, 60f), OnExtras);
        CreateButton(Root, "回想模式", new Vector2(x, y0 + step * 4), new Vector2(260f, 60f), OnRecollection);
        CreateButton(Root, "退出游戏", new Vector2(x, y0 + step * 5), new Vector2(260f, 60f), OnQuit);
    }

    private void OnStartGame()
    {
        // 隐藏自身并通过 GameMain 进入第一章
        UIScreenManager.Instance.PopAll();
        GameMethods gm = GameObject.Find("Game Methods")?.GetComponent<GameMethods>();
        if (gm != null && LabelRegistry.Instance != null)
        {
            gm.StartCoroutine(LabelRegistry.Instance.RunCoroutineByMethodOnly("label_zhuxian0"));
        }
        else
        {
            Debug.LogError("[MainMenu] 无法启动：缺少 GameMethods / LabelRegistry");
        }
    }

    private void OnLoadGame()
    {
        UIScreenManager.Instance.Show<LoadScreen>();
    }

    private void OnSettings()
    {
        UIScreenManager.Instance.Show<SettingsScreen>();
    }

    private void OnExtras()
    {
        UIScreenManager.Instance.Show<ExtrasScreen>();
    }

    private void OnRecollection()
    {
        UIScreenManager.Instance.Show<RecollectionScreen>();
    }

    private void OnQuit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
