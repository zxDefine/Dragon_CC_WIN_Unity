using System.Collections.Generic;
using UnityEngine;

public class DialogManager : MonoBehaviour
{
    public static DialogManager Instance;
    
    // 加载对话信息
    private Dictionary<int, DialogueInfo> _dialogues = new();

    private void Awake()
    {
        if (Instance == null)
        {
            // 建立manager
            Instance = this;
            DontDestroyOnLoad(gameObject);
            
            // 读取所有的对话信息
            _dialogues = DialogueLoader.LoadDialogues("Assets/RenpyResources/middle_data/dialogues.txt");
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    // 获得对应编号的对话
    public string GetDialogue(int dialogueID)
    {
        DialogueInfo info = _dialogues[dialogueID];
        // Debug.Log("GetDialogue " + info.Dialogue + " from " + info.FilePath);
        return info.Dialogue;
    }
    
    void OnDestroy()
    {
        Instance = null;
        _dialogues.Clear();
    }
}
