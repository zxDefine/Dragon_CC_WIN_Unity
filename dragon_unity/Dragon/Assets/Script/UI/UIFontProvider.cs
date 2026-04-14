using System.Collections;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

/// <summary>
/// M6 CJK 字体共享提供者。M4 首版用 LegacyRuntime.ttf 时，中文生僻字与
/// Emoji 都会渲染为 □；本类把原版 GenSenRounded-M.ttc 异步加载一次后
/// 共享给所有 UGUI 屏幕使用，避免重复 IO 与每屏一份字体引用。
/// </summary>
/// <remarks>
/// 加载链：
///   1. <see cref="EnsureLoad"/> 同步触发协程（如果运行时缺 Font 会即时尝试同步加载）。
///   2. 加载完成后 <see cref="Current"/> 返回 GenSenRounded-M Font 实例。
///   3. 加载失败（资源缺失）时回退到 LegacyRuntime.ttf 以保证文本至少能显示。
///
/// 设计说明：故意使用静态字段 + Addressables 同步等待（WaitForCompletion）
/// 在 BuildContent 调用时取字体，因为 UIScreenBase 的工厂方法是同步的。
/// 对应 Renpy 原版 GameState.Gui.Text_font = "GenSenRounded-M.ttc"。
/// </remarks>
public static class UIFontProvider
{
    private const string PrimaryAddress = "Assets/RenpyResources/GenSenRounded-M.ttc";
    private const string FallbackAddress = "Assets/RenpyResources/SourceHanSansLite.ttf";

    private static Font _current;
    private static bool _attempted;

    /// <summary>
    /// 当前使用的字体。第一次访问会同步加载 GenSenRounded-M；
    /// 加载失败回退到 SourceHanSansLite，再失败回退到内置 LegacyRuntime.ttf。
    /// </summary>
    public static Font Current
    {
        get
        {
            if (_current != null) return _current;
            if (!_attempted) EnsureLoad();
            return _current ?? Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
        }
    }

    /// <summary>
    /// 同步加载主字体；失败则尝试备用字体。M6 阶段的字体资源已注册为 Addressables，
    /// WaitForCompletion 通常在毫秒级返回（小文件 + 本地）。
    /// </summary>
    private static void EnsureLoad()
    {
        _attempted = true;
        if (TryLoad(PrimaryAddress, out _current)) return;
        Debug.LogWarning($"[UIFontProvider] 主字体 {PrimaryAddress} 加载失败，尝试备用");
        if (TryLoad(FallbackAddress, out _current)) return;
        Debug.LogError("[UIFontProvider] CJK 字体全部加载失败，回退到 LegacyRuntime.ttf（中文可能缺字形）");
    }

    private static bool TryLoad(string address, out Font font)
    {
        font = null;
        try
        {
            AsyncOperationHandle<Font> h = Addressables.LoadAssetAsync<Font>(address);
            h.WaitForCompletion();
            if (h.Status == AsyncOperationStatus.Succeeded && h.Result != null)
            {
                font = h.Result;
                Debug.Log($"[UIFontProvider] loaded {address} → {font.name}");
                return true;
            }
        }
        catch (System.Exception e)
        {
            Debug.LogException(e);
        }
        return false;
    }
}
