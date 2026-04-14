using UnityEngine;

/// <summary>
/// M4.7 附加内容入口 — 对应 Renpy screens.rpy L1550 <c>screen extra</c>。
/// 入口页：音乐 / CG / 剧情回忆 / 角色档案 / 番外 / 素材。
/// </summary>
public class ExtrasScreen : UIScreenBase
{
    protected override void BuildContent()
    {
        CreateFullScreenBackground(Root, new Color(0.05f, 0.04f, 0.08f, 0.95f));
        CreateLabel(Root, "附加内容", new Vector2(0f, 430f), 42);

        string[] labels = { "音乐回忆", "CG 鉴赏", "剧情回忆", "角色档案", "番外短篇", "成就", "素材展示" };
        System.Action[] handlers =
        {
            () => UIScreenManager.Instance.Show<MusicGalleryScreen>(),
            () => UIScreenManager.Instance.Show<CGGalleryScreen>(),
            () => UIScreenManager.Instance.Show<StoryGalleryScreen>(),
            () => UIScreenManager.Instance.Show<CharacterArchiveScreen>(),
            () => UIScreenManager.Instance.Show<FanwaiScreen>(),
            () => UIScreenManager.Instance.Show<AchievementListScreen>(),
            () => UIScreenManager.Instance.Show<SucaiScreen>(),
        };
        for (int i = 0; i < labels.Length; i++)
        {
            int capture = i;
            int row = i / 3;
            int col = i % 3;
            float x = (col - 1) * 360f;
            float y = 200f - row * 160f;
            CreateButton(Root, labels[i], new Vector2(x, y), new Vector2(320f, 120f), () => handlers[capture]());
        }

        CreateButton(Root, "返回", new Vector2(0f, -400f), new Vector2(160f, 50f), () => UIScreenManager.Instance.Pop());
    }
}
