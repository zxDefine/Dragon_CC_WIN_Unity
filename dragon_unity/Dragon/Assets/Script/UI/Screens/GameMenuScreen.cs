using UnityEngine;

/// <summary>
/// M4.4 游戏内菜单 — 对应 Renpy screens.rpy L1015 <c>screen game_menu</c>。
/// 暂停、保存、读档、设置、回主菜单、关于。
/// </summary>
public class GameMenuScreen : UIScreenBase
{
    protected override void BuildContent()
    {
        CreateFullScreenBackground(Root, new Color(0f, 0f, 0f, 0.75f));
        CreateLabel(Root, "游戏菜单", new Vector2(0f, 380f), 40);

        string[] labels = { "继续游戏", "保存", "读取", "设置", "历史", "返回主菜单" };
        System.Action[] handlers =
        {
            OnResume, OnSave, OnLoad, OnSettings, OnHistory, OnMainMenu,
        };
        for (int i = 0; i < labels.Length; i++)
        {
            int capture = i;
            CreateButton(Root, labels[i], new Vector2(0f, 200f - i * 80f), new Vector2(280f, 60f), () => handlers[capture]());
        }
    }

    private void OnResume() => UIScreenManager.Instance.Pop();
    private void OnSave() => UIScreenManager.Instance.Show<SaveScreen>();
    private void OnLoad() => UIScreenManager.Instance.Show<LoadScreen>();
    private void OnSettings() => UIScreenManager.Instance.Show<SettingsScreen>();
    private void OnHistory() => UIScreenManager.Instance.Show<HistoryScreen>();

    private void OnMainMenu()
    {
        UIScreenManager.Instance.PopAll();
        UIScreenManager.Instance.Show<MainMenuScreen>();
    }
}
