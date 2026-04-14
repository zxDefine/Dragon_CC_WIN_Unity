using UnityEngine;

/// <summary>
/// M4.7 素材展示（原版 screens.rpy L1775 <c>screen sucai</c>）。
/// 展示游戏使用的原始素材列表（图像/音频/字体）。M4 首版只列 Addressables 分组统计，
/// 详细的逐资源预览归入 M5 / M6 打磨。
/// </summary>
public class SucaiScreen : UIScreenBase
{
    protected override void BuildContent()
    {
        CreateFullScreenBackground(Root, new Color(0.04f, 0.04f, 0.1f, 0.95f));
        CreateLabel(Root, "素材展示", new Vector2(0f, 430f), 42);
        CreateLabel(Root, "游戏素材来自原版 Renpy 工程 dragon_yuanban/game/", new Vector2(0f, 360f), 18);
        CreateLabel(Root, "Addressables 组：Audio / GUI / Images / MiddleData", new Vector2(0f, 320f), 18);
        CreateLabel(Root, "详细分项预览将在 M6 打磨阶段接入", new Vector2(0f, 280f), 16);

        CreateButton(Root, "返回", new Vector2(0f, -400f), new Vector2(160f, 50f), () => UIScreenManager.Instance.Pop());
    }
}
