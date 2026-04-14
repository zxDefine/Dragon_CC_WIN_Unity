using UnityEngine;

/// <summary>
/// 回想模式总入口。从主菜单直接点进，聚合剧情回忆 / CG / 音乐 / 角色档案。
/// </summary>
public class RecollectionScreen : UIScreenBase
{
    protected override void BuildContent()
    {
        CreateFullScreenBackground(Root, new Color(0.05f, 0.05f, 0.1f, 0.95f));
        CreateLabel(Root, "回想模式", new Vector2(0f, 440f), 42);

        CreateButton(Root, "剧情回忆", new Vector2(-250f, 150f), new Vector2(300f, 100f),
            () => UIScreenManager.Instance.Show<StoryGalleryScreen>());
        CreateButton(Root, "CG 鉴赏",  new Vector2(250f,  150f), new Vector2(300f, 100f),
            () => UIScreenManager.Instance.Show<CGGalleryScreen>());
        CreateButton(Root, "音乐回忆", new Vector2(-250f, 0f),   new Vector2(300f, 100f),
            () => UIScreenManager.Instance.Show<MusicGalleryScreen>());
        CreateButton(Root, "角色档案", new Vector2(250f,  0f),   new Vector2(300f, 100f),
            () => UIScreenManager.Instance.Show<CharacterArchiveScreen>());
        CreateButton(Root, "番外短篇", new Vector2(0f,   -150f), new Vector2(300f, 100f),
            () => UIScreenManager.Instance.Show<FanwaiScreen>());

        CreateButton(Root, "返回", new Vector2(0f, -440f), new Vector2(160f, 50f), () => UIScreenManager.Instance.Pop());
    }
}
