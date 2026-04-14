using System.Collections;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

/// <summary>
/// M4.2 主菜单 — 对应 Renpy screens.rpy L808 <c>screen main_menu</c>。
/// 按钮：开始 / 读档 / 设置 / 附加 / 回想 / 退出。
/// </summary>
/// <remarks>
/// M6 视觉打磨：使用原版 <c>gui/zhu/zhu_ditu.jpg</c> 全屏背景与 <c>zhu_logo1.png</c> 标题图。
/// 按钮仍是文本按钮，原版 <c>zhu_button1~8.png</c> 是分层 sprite，留待后续完整对位。
/// </remarks>
public class MainMenuScreen : UIScreenBase
{
    private const string BackgroundAddress = "Assets/RenpyResources/gui/zhu/zhu_ditu.jpg";
    private const string LogoAddress = "Assets/RenpyResources/gui/zhu/zhu_logo1.png";

    private RawImage _bgImage;
    private RawImage _logoImage;
    private AsyncOperationHandle<Texture2D> _bgHandle;
    private AsyncOperationHandle<Texture2D> _logoHandle;

    protected override void BuildContent()
    {
        // 黑色兜底，等纹理加载
        CreateFullScreenBackground(Root, Color.black);

        // 全屏背景图占位（先创建，纹理后异步加载）
        GameObject bgGo = new GameObject("Background");
        bgGo.transform.SetParent(Root, false);
        _bgImage = bgGo.AddComponent<RawImage>();
        _bgImage.color = Color.white;
        RectTransform bgRt = bgGo.GetComponent<RectTransform>();
        bgRt.anchorMin = Vector2.zero;
        bgRt.anchorMax = Vector2.one;
        bgRt.offsetMin = Vector2.zero;
        bgRt.offsetMax = Vector2.zero;

        // Logo 占位（中上方）
        GameObject logoGo = new GameObject("Logo");
        logoGo.transform.SetParent(Root, false);
        _logoImage = logoGo.AddComponent<RawImage>();
        _logoImage.color = Color.white;
        RectTransform logoRt = logoGo.GetComponent<RectTransform>();
        logoRt.anchorMin = new Vector2(0.5f, 0.5f);
        logoRt.anchorMax = new Vector2(0.5f, 0.5f);
        logoRt.pivot = new Vector2(0.5f, 0.5f);
        logoRt.anchoredPosition = new Vector2(0f, 280f);
        logoRt.sizeDelta = new Vector2(688f, 432f); // 2x of 344x216

        CreateLabel(Root, "v1.0 — Unity 移植版", new Vector2(0f, 60f), 18);

        // 6 个主按钮（对应 Renpy navigation.rpy L722）
        // 视觉位置改到画面下方居中，与原版 zhu_button 排布更接近
        float x = -480f;
        float y0 = -40f;
        float step = -78f;
        CreateButton(Root, "开始游戏", new Vector2(x, y0 + step * 0), new Vector2(280f, 64f), OnStartGame);
        CreateButton(Root, "读取存档", new Vector2(x, y0 + step * 1), new Vector2(280f, 64f), OnLoadGame);
        CreateButton(Root, "设置",     new Vector2(x, y0 + step * 2), new Vector2(280f, 64f), OnSettings);
        CreateButton(Root, "附加内容", new Vector2(x, y0 + step * 3), new Vector2(280f, 64f), OnExtras);
        CreateButton(Root, "回想模式", new Vector2(x, y0 + step * 4), new Vector2(280f, 64f), OnRecollection);
        CreateButton(Root, "退出游戏", new Vector2(x, y0 + step * 5), new Vector2(280f, 64f), OnQuit);
    }

    public override void Show()
    {
        base.Show();
        // 每次 Show 都尝试加载纹理（已加载的话 Addressables 会快速返回）
        StartCoroutine(LoadTextures());
    }

    private IEnumerator LoadTextures()
    {
        if (!_bgHandle.IsValid())
        {
            _bgHandle = Addressables.LoadAssetAsync<Texture2D>(BackgroundAddress);
            yield return _bgHandle;
            if (_bgHandle.Status == AsyncOperationStatus.Succeeded && _bgHandle.Result != null)
            {
                _bgImage.texture = _bgHandle.Result;
            }
            else
            {
                Debug.LogWarning("[MainMenu] 背景图 zhu_ditu.jpg 加载失败");
            }
        }

        if (!_logoHandle.IsValid())
        {
            _logoHandle = Addressables.LoadAssetAsync<Texture2D>(LogoAddress);
            yield return _logoHandle;
            if (_logoHandle.Status == AsyncOperationStatus.Succeeded && _logoHandle.Result != null)
            {
                _logoImage.texture = _logoHandle.Result;
            }
            else
            {
                Debug.LogWarning("[MainMenu] Logo zhu_logo1.png 加载失败");
            }
        }
    }

    public override void Hide()
    {
        // 主菜单常驻：通常不释放纹理，避免反复 IO
        base.Hide();
    }

    private void OnDestroy()
    {
        if (_bgHandle.IsValid()) Addressables.Release(_bgHandle);
        if (_logoHandle.IsValid()) Addressables.Release(_logoHandle);
    }

    private void OnStartGame()
    {
        // 隐藏自身并通过 GameMain 进入第一章
        UIScreenManager.Instance.PopAll();
        GameMethods gm = GameObject.Find("Game Methods")?.GetComponent<GameMethods>();
        if (gm != null && LabelRegistry.Instance != null)
        {
            gm.StartCoroutine(LabelRegistry.Instance.RunCoroutineByMethodOnly("label_zhuxian0"));
        }
        else
        {
            Debug.LogError("[MainMenu] 无法启动：缺少 GameMethods / LabelRegistry");
        }
    }

    private void OnLoadGame() => UIScreenManager.Instance.Show<LoadScreen>();
    private void OnSettings() => UIScreenManager.Instance.Show<SettingsScreen>();
    private void OnExtras() => UIScreenManager.Instance.Show<ExtrasScreen>();
    private void OnRecollection() => UIScreenManager.Instance.Show<RecollectionScreen>();

    private void OnQuit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
