using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;
using UnityEngine.ResourceManagement.AsyncOperations;

public class CharacterManager : MonoBehaviour
{
    public static CharacterManager Instance;

    /// <summary>
    /// 异步加载完成后才为 true（BUG-02 修复）。
    /// </summary>
    public bool IsReady { get; private set; }

    private const string CharacterJsonAddress = "Assets/RenpyResources/middle_data/character.json";

    // 通过middle_data的character.json读取
    private Dictionary<string, object> _characterImageJson = new Dictionary<string, object>();
    private Dictionary<string, RenpyCharacter> _characterImageDict = new Dictionary<string, RenpyCharacter>();
    
    // 是否设置的角色立绘
    // private bool _showTalkCharacter = false;
    private bool _showTalkCharaIcon = false;
    
    private void Awake()
    {
        if (Instance == null)
        {
            // 建立manager
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
        yield return LoadCharacterJsonAsync();
    }

    private IEnumerator LoadCharacterJsonAsync()
    {
        AsyncOperationHandle<TextAsset> handle = Addressables.LoadAssetAsync<TextAsset>(CharacterJsonAddress);
        yield return handle;

        if (handle.Status == AsyncOperationStatus.Succeeded && handle.Result != null)
        {
            _characterImageJson = JsonHelper.ParseJsonToNestedDict(handle.Result.text);
            Debug.Log($"CharacterManager loaded {_characterImageJson.Count} character entries via Addressables");
        }
        else
        {
            Debug.LogError($"CharacterManager: failed to load {CharacterJsonAddress} via Addressables");
            _characterImageJson = new Dictionary<string, object>();
        }

        IsReady = true;
    }
    
    public void LoadCharacterImage(string characterName)
    {
        if (null != characterName && !_characterImageDict.ContainsKey(characterName))
        {
            // 找到与这个character相关的dict
            Dictionary<string, object> dict = _characterImageJson[characterName] as Dictionary<string, object>;
            
            // 加载对应的图片
            _characterImageDict[characterName] = new RenpyCharacter(dict);
        }
    }
    
    public void Draw(string characterName, List<string> imagePartsName)
    {
        // 获得需要绘制的chara信息
        RenpyCharacter character = _characterImageDict[characterName];
        
        // 获得image的绘制信息
        // image名称
        string imageName = character.GetImageName();
        
        // image的位置信息
        List<float> imageRect = character.GetRectList();
        
        // image的zoom信息
        float imageZoom = character.GetImageZoom();
        
        // image的对话框头像的pos
        List<float> imageSidePos = character.GetImageSidePos();

        // 绘制chara中的image
        ImageManager.Instance.DrawCharacter(imageName, imageRect, imageZoom, imageSidePos, imagePartsName);
    }

    public IEnumerator ChangeCharacter(string characterName, List<string> parts = null)
    {
        // 读取贴图
        LoadCharacterImage(characterName);
        
        // 设置名字
        ChangeTalkCharacterName(characterName);
        // 设置对话前后的符号
        SetTalkCharacterSymbol(characterName);

        // 设置显示角色头像
        SetShowTalkCharaIcon(true);
        
        // 如果有部位信息的话，需要重置角色头像
        if (parts != null && parts.Count > 0)
        {
            // 绘制立绘
            Draw(characterName, parts);
        }

        yield break;
    }
    
    public void ChangeTalkCharacterName(string characterName)
    {
        string talkName = _characterImageDict[characterName].GetCharacterName();
        if (talkName == "persistent.povname")
        {
            talkName = Defaults.Persistent.Povname;
        }
        DialogueUI.Instance.SetTalkCharacterName(talkName);
    }

    public void SetTalkCharacterSymbol(string characterName)
    {
        List<string> talkSymbol = _characterImageDict[characterName].GetCharacterTalkSymbol();
        DialogueUI.Instance.SetTalkCharacterSymbol(talkSymbol[0], talkSymbol[1]);
    }

    public void SetShowTalkCharaIcon(bool show)
    {
        _showTalkCharaIcon = show;
    }
    
    public bool GetShowTalkCharaIcon()
    {
        return _showTalkCharaIcon;
    }
}