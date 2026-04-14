using System.Collections;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

/// <summary>
/// M6 polish：把 DialogueUICanvas/TextBox 的 RawImage 从 placeholder
/// <c>textboxaaa.png</c> 换成原版 <c>gui/textbox.png</c>。
/// </summary>
/// <remarks>
/// 通过 [RuntimeInitializeOnLoadMethod(AfterSceneLoad)] 自启动，
/// 不需要修改场景或 Prefab，更不需要扩 DialogueUI 的 Inspector 字段。
/// 内部维护一张 helper MonoBehaviour 协程负责 Addressables 异步加载，
/// 加载完成后把 RawImage.texture 直接替换。
/// </remarks>
public static class DialogueTextboxSkin
{
    private const string TextboxAddress = "Assets/RenpyResources/gui/textbox.png";
    // 备用：M6 polish 后续也可在此挂 textbox_xin / textbox_xin0 / textbox_xin1
    // 做角色 say1 / say2 变体切换；目前先统一换默认 textbox.png

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

        AsyncOperationHandle<Texture2D> handle = Addressables.LoadAssetAsync<Texture2D>(TextboxAddress);
        yield return handle;
        if (handle.Status == AsyncOperationStatus.Succeeded && handle.Result != null)
        {
            raw.texture = handle.Result;
            Debug.Log($"[DialogueTextboxSkin] TextBox 纹理已替换为 textbox.png ({handle.Result.width}x{handle.Result.height})");
        }
        else
        {
            Debug.LogError("[DialogueTextboxSkin] textbox.png 加载失败，保留原 placeholder");
            Addressables.Release(handle);
        }
        // 注意：不 Release 成功的 handle，因为 RawImage 持有引用直到游戏退出

        Object.Destroy(host);
    }

    /// <summary>仅作为协程宿主的空 MonoBehaviour。</summary>
    private class Runner : MonoBehaviour { }
}
