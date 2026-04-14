using Unity.VisualScripting;
// using UnityEditor;
using UnityEngine;
using UnityEngine.AddressableAssets;
// using UnityEngine.Events;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

public class AutoButton : MonoBehaviour
{
    // public RawImage iconImage;
    private Button _button;

    void Start()
    {
        _button = gameObject.GetComponent<Button>();
        _button.onClick.AddListener(OnButtonClick);
    }
    
    // 点击测试
    void OnButtonClick()
    {
        Debug.Log("按钮被点击了！");
    }

    // 设置图标
    public void SetIcon(bool isAuto)
    {
        Debug.Log("=====> Set auto button icon");
        
        // 根据状态读取贴图
        string path = isAuto ? "Assets/RenpyResources/gui/kuaijie/kuaijie_7_0.png" : "Assets/RenpyResources/gui/kuaijie/kuaijie_7.png";
        AsyncOperationHandle<Image> handle = Addressables.LoadAssetAsync<Image>(path);
        Image image = handle.WaitForCompletion();
        if (image == null)
        {
            Debug.LogWarning("auto button texture is null");
        }
        
        // 设置贴图
        _button.image = image;
    }
    
}
