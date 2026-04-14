using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class DialogManager : MonoBehaviour
{
    public static DialogManager Instance;

    // 加载对话信息
    private Dictionary<int, DialogueInfo> _dialogues = new();

    /// <summary>
    /// 异步加载完成后才为 true。GameMain 会在进入主流程前 poll 此标记。
    /// 对应 BUG-02 修复：避免 Editor-only 的 File.ReadAllText 硬编码路径。
    /// </summary>
    public bool IsReady { get; private set; }

    private const string DialoguesAddress = "Assets/RenpyResources/middle_data/dialogues.txt";

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private IEnumerator Start()
    {
        if (Instance != this) yield break;
        yield return LoadDialoguesAsync();
    }

    private IEnumerator LoadDialoguesAsync()
    {
        AsyncOperationHandle<TextAsset> handle = Addressables.LoadAssetAsync<TextAsset>(DialoguesAddress);
        yield return handle;

        if (handle.Status == AsyncOperationStatus.Succeeded && handle.Result != null)
        {
            _dialogues = DialogueLoader.LoadDialoguesFromText(handle.Result.text);
            Debug.Log($"DialogManager loaded {_dialogues.Count} dialogues via Addressables");
        }
        else
        {
            Debug.LogError($"DialogManager: failed to load {DialoguesAddress} via Addressables");
            _dialogues = new Dictionary<int, DialogueInfo>();
        }

        IsReady = true;
    }

    // 获得对应编号的对话
    public string GetDialogue(int dialogueID)
    {
        DialogueInfo info = _dialogues[dialogueID];
        return info.Dialogue;
    }

    void OnDestroy()
    {
        if (Instance == this) Instance = null;
        _dialogues.Clear();
    }
}
