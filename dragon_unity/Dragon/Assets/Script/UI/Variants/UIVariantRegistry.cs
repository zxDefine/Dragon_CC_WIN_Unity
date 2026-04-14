using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// M4.6 对话框 / 选项菜单 变体注册表。
/// 对应 Renpy screens.rpy 的 say/say1/say2 与 choice/choice1-5 多种样式。
/// </summary>
/// <remarks>
/// 原版 Renpy 里，每个 Character 定义可通过 <c>screen="say1"</c> 指定使用哪个对话框 screen
/// （见 GameState.cs 里的 Nuo_1_xin_* 系列，均带 <c>screen = "say1"</c>）。
/// Unity 这边的 <see cref="DialogueUI"/> 只有一种样式，M4.6 通过本注册表集中声明变体参数，
/// 让 DialogueUI / UISelectionMenu 在 Show 时读取并覆盖自己的视觉属性。
///
/// 变体参数目前只记录纯字段，真正的外观切换留待 M6 阶段根据美术资源对齐。
/// </remarks>
public static class UIVariantRegistry
{
    public class DialogVariant
    {
        /// <summary>对话框文字颜色（Renpy gui 里叫 idle_color）</summary>
        public Color textColor = Color.white;
        /// <summary>角色名文字颜色</summary>
        public Color nameColor = new Color(1f, 0.6f, 0.6f, 1f);
        /// <summary>对话框 Image 背景资源路径（Addressables）</summary>
        public string backgroundAddress = "";
        /// <summary>对话框 y 偏移（正值向上）</summary>
        public float yOffset = 0f;
        /// <summary>文字相对 textbox 的 x 偏移</summary>
        public float textXOffset = 0f;
    }

    public class ChoiceVariant
    {
        /// <summary>选项按钮高度</summary>
        public float buttonHeight = 60f;
        /// <summary>选项按钮宽度</summary>
        public float buttonWidth = 790f;
        /// <summary>选项之间的垂直间距</summary>
        public float spacing = 10f;
        /// <summary>按钮空闲颜色</summary>
        public Color idleColor = new Color(0.53f, 0.53f, 0.53f, 1f);
        /// <summary>按钮 hover 颜色</summary>
        public Color hoverColor = Color.white;
    }

    // --- 默认变体 --- //
    private static readonly DialogVariant Default = new DialogVariant();
    private static readonly ChoiceVariant DefaultChoice = new ChoiceVariant();

    private static readonly Dictionary<string, DialogVariant> DialogVariants = new Dictionary<string, DialogVariant>
    {
        { "say", Default },
        { "say1", new DialogVariant
            {
                // Nuo_1_xin 系列用 textbox_xin_yoffset 背景
                backgroundAddress = "Assets/RenpyResources/gui/textbox_xin_yoffset.png",
                yOffset = 20f,
                textColor = new Color(1f, 0.92f, 0.92f, 1f),
            }
        },
        { "say2", new DialogVariant
            {
                backgroundAddress = "Assets/RenpyResources/gui/textbox_xin1_yoffset.png",
                yOffset = 40f,
                textColor = new Color(0.92f, 1f, 0.92f, 1f),
            }
        },
    };

    private static readonly Dictionary<string, ChoiceVariant> ChoiceVariants = new Dictionary<string, ChoiceVariant>
    {
        { "choice", DefaultChoice },
        { "choice1", new ChoiceVariant { buttonHeight = 80f, spacing = 20f } },
        { "choice2", new ChoiceVariant { buttonHeight = 70f, buttonWidth = 900f, spacing = 15f } },
        { "choice3", new ChoiceVariant { buttonHeight = 90f, buttonWidth = 1000f, spacing = 30f,
                                         idleColor = new Color(0.8f, 0.4f, 0.4f, 1f) } },
        { "choice4", new ChoiceVariant { buttonHeight = 60f, buttonWidth = 700f, spacing = 5f } },
        { "choice5", new ChoiceVariant { buttonHeight = 100f, buttonWidth = 1100f, spacing = 40f,
                                         hoverColor = new Color(1f, 0.8f, 0.4f, 1f) } },
    };

    public static DialogVariant GetDialog(string name)
    {
        if (string.IsNullOrEmpty(name)) return Default;
        return DialogVariants.TryGetValue(name, out var v) ? v : Default;
    }

    public static ChoiceVariant GetChoice(string name)
    {
        if (string.IsNullOrEmpty(name)) return DefaultChoice;
        return ChoiceVariants.TryGetValue(name, out var v) ? v : DefaultChoice;
    }
}
