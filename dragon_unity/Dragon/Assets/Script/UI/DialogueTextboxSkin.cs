using System.Collections;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

/// <summary>
/// M6 polish：把 DialogueUICanvas/TextBox 的 RawImage 从 placeholder
/// <c>textboxaaa.png</c> 换成原版 <c>gui/textbox.png</c>，并在
/// <c>DialogName</c> 文本下方动态插入一张 <c>gui/namebox.png</c> 背景。
/// </summary>
/// <remarks>
/// 通过 [RuntimeInitializeOnLoadMethod(AfterSceneLoad)] 自启动，
/// 不需要修改场景或 Prefab，更不需要扩 DialogueUI 的 Inspector 字段。
/// 内部维护一张 helper MonoBehaviour 协程负责 Addressables 异步加载，
/// 加载完成后把 RawImage.texture 直接替换 + 创建 namebox 子节点。
/// </remarks>
public static class DialogueTextboxSkin
{
    private const string TextboxAddress = "Assets/RenpyResources/gui/textbox.png";
    private const string NameboxAddress = "Assets/RenpyResources/gui/namebox.png";

    /// <summary>
    /// Renpy screen 名 → textbox 资源路径映射。M6 polish B：根据角色定义里的
    /// <c>screen="say1"/"say2"</c> 切换不同的对话框背景。
    /// say0 等占位 key 留待后续接入角色专属背景。
    /// </summary>
    private static readonly System.Collections.Generic.Dictionary<string, string> ScreenToAddress =
        new System.Collections.Generic.Dictionary<string, string>
    {
        { "say",  "Assets/RenpyResources/gui/textbox.png" },
        { "say1", "Assets/RenpyResources/gui/textbox_xin.png" },
        { "say2", "Assets/RenpyResources/gui/textbox_xin1.png" },
    };

    /// <summary>已加载的 textbox 变体缓存，避免每次切换重新 IO。</summary>
    private static readonly System.Collections.Generic.Dictionary<string, Texture2D> _variantCache =
        new System.Collections.Generic.Dictionary<string, Texture2D>();

    /// <summary>当前持有的 RawImage 引用，用于运行时切换变体。</summary>
    private static RawImage _textboxRaw;
    private static string _currentVariant = "say";

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
    private static void AutoBootstrap()
    {
        // 把启动协程挂到一个临时 host GameObject 上
        GameObject host = new GameObject("DialogueTextboxSkin (auto)");
        Object.DontDestroyOnLoad(host);
        host.AddComponent<Runner>().StartCoroutine(SkinRoutine(host));
    }

    private static IEnumerator SkinRoutine(GameObject host)
    {
        // 等到 DialogueUICanvas 出现（场景加载顺序未必先于本 hook）
        GameObject canvasGo = null;
        for (int i = 0; i < 240 && canvasGo == null; i++)
        {
            canvasGo = GameObject.Find("DialogueUICanvas");
            if (canvasGo == null) yield return null;
        }
        if (canvasGo == null)
        {
            Debug.LogWarning("[DialogueTextboxSkin] DialogueUICanvas 未找到（240 帧后），跳过");
            Object.Destroy(host);
            yield break;
        }

        Transform textBoxTr = canvasGo.transform.Find("TextBox");
        if (textBoxTr == null)
        {
            Debug.LogWarning("[DialogueTextboxSkin] DialogueUICanvas/TextBox 未找到，跳过");
            Object.Destroy(host);
            yield break;
        }
        RawImage raw = textBoxTr.GetComponent<RawImage>();
        if (raw == null)
        {
            Debug.LogWarning("[DialogueTextboxSkin] TextBox 上没有 RawImage，跳过");
            Object.Destroy(host);
            yield break;
        }

        // 缓存 RawImage 引用，便于运行时通过 SetVariant 切换 textbox 变体
        _textboxRaw = raw;

        AsyncOperationHandle<Texture2D> handle = Addressables.LoadAssetAsync<Texture2D>(TextboxAddress);
        yield return handle;
        if (handle.Status == AsyncOperationStatus.Succeeded && handle.Result != null)
        {
            raw.texture = handle.Result;
            _variantCache["say"] = handle.Result;
            Debug.Log($"[DialogueTextboxSkin] TextBox 纹理已替换为 textbox.png ({handle.Result.width}x{handle.Result.height})");
        }
        else
        {
            Debug.LogError("[DialogueTextboxSkin] textbox.png 加载失败，保留原 placeholder");
            Addressables.Release(handle);
        }
        // 注意：不 Release 成功的 handle，因为 RawImage / 缓存持有引用直到游戏退出

        // 同时插入 namebox 背景：在 DialogName 同级、order 排在它前面
        Transform dialogNameTr = canvasGo.transform.Find("DialogName");
        if (dialogNameTr != null && canvasGo.transform.Find("Namebox") == null)
        {
            yield return InsertNamebox(canvasGo.transform, dialogNameTr);
        }

        Object.Destroy(host);
    }

    private static IEnumerator InsertNamebox(Transform canvasTr, Transform dialogNameTr)
    {
        AsyncOperationHandle<Texture2D> nh = Addressables.LoadAssetAsync<Texture2D>(NameboxAddress);
        yield return nh;
        if (nh.Status != AsyncOperationStatus.Succeeded || nh.Result == null)
        {
            Debug.LogWarning("[DialogueTextboxSkin] namebox.png 加载失败，跳过");
            Addressables.Release(nh);
            yield break;
        }

        GameObject nb = new GameObject("Namebox");
        nb.transform.SetParent(canvasTr, false);
        // 排到 DialogName 前面，保证 namebox 在 name 文字下方
        nb.transform.SetSiblingIndex(dialogNameTr.GetSiblingIndex());

        var rawNb = nb.AddComponent<RawImage>();
        rawNb.texture = nh.Result;
        rawNb.color = Color.white;
        // 不释放 nh：RawImage 持有引用

        // 复制 DialogName 的中心点，用 namebox 自身像素尺寸 (300x36)
        var nameRt = dialogNameTr.GetComponent<RectTransform>();
        var nbRt = nb.GetComponent<RectTransform>();
        nbRt.anchorMin = nameRt.anchorMin;
        nbRt.anchorMax = nameRt.anchorMax;
        nbRt.pivot = new Vector2(0.5f, 0.5f);
        // 以 DialogName 中心为锚点，整体上移一点点对齐文字基线
        nbRt.anchoredPosition = nameRt.anchoredPosition + new Vector2(0f, 2f);
        nbRt.sizeDelta = new Vector2(nh.Result.width, nh.Result.height);

        Debug.Log($"[DialogueTextboxSkin] Namebox 已插入 ({nh.Result.width}x{nh.Result.height}) at {nbRt.anchoredPosition}");
    }

    /// <summary>
    /// M6 polish B：根据角色 screen 名（say / say1 / say2）切换对话框背景。
    /// 由 <see cref="CharacterManager.ChangeCharacter"/> 在每次切换说话人时调用。
    /// 缓存命中即同步切换；未缓存触发同步 Addressables 加载。
    /// </summary>
    public static void SetVariant(string screenName)
    {
        if (_textboxRaw == null) return; // 还没初始化，骨架未就绪
        string key = string.IsNullOrEmpty(screenName) ? "say" : screenName;
        if (key == _currentVariant) return;
        if (!ScreenToAddress.TryGetValue(key, out string address))
        {
            // 未知 screen 名 → 回退到默认 textbox
            key = "say";
            address = TextboxAddress;
        }
        if (_variantCache.TryGetValue(key, out Texture2D cached) && cached != null)
        {
            _textboxRaw.texture = cached;
            _currentVariant = key;
            return;
        }
        // 同步加载（小本地资源，毫秒级）
        try
        {
            var h = Addressables.LoadAssetAsync<Texture2D>(address);
            h.WaitForCompletion();
            if (h.Status == AsyncOperationStatus.Succeeded && h.Result != null)
            {
                _variantCache[key] = h.Result;
                _textboxRaw.texture = h.Result;
                _currentVariant = key;
                // handle 不 release，缓存持有引用
            }
            else
            {
                Debug.LogWarning("[DialogueTextboxSkin] SetVariant: 无法加载 " + address);
                Addressables.Release(h);
            }
        }
        catch (System.Exception e)
        {
            Debug.LogException(e);
        }
    }

    /// <summary>仅作为协程宿主的空 MonoBehaviour。</summary>
    private class Runner : MonoBehaviour { }
}
