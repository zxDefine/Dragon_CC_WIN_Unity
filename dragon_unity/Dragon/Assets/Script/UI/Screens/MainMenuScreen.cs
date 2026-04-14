using System.Collections;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

/// <summary>
/// M4.2 主菜单 — 对应 Renpy screens.rpy L808 <c>screen main_menu</c>。
/// M6 phase 2：使用原版 zhu_ditu.jpg 背景 + zhu_logo1.png 标题 +
/// zhu_button1~8.png 分层 sprite 按钮（透明 hit-test）。
/// </summary>
/// <remarks>
/// 实现思路：
/// 1. 全屏 zhu_ditu.jpg 背景；
/// 2. 标题位置叠加 zhu_logo1.png；
/// 3. 8 张 zhu_buttonN.png（每张本身就是 1280×720 全画布的"按钮层"，按钮像素已就位）
///    叠到背景之上做视觉；
/// 4. 在每个按钮像素的中心位置插入一个透明 Image + Button 作为点击 hit-test 区域。
///
/// 按钮像素 bounds（已通过 GetPixels32 alpha 阈值采样得到）：
///   button1: (18,445)-(296,481)  → 开始游戏（top, 大）
///   button2: (17,398)-(304,434)  → 读取存档
///   button3: (17,329)-(302,366)  → 设置
///   button4: (18,281)-(305,317)  → 附加内容
///   button5: (18,215)-(305,251)  → 退出游戏
///   button6: (18,116)-(232,152)  → 回想模式（小，底部）
///   button7: (17,66) -(230,102)  → 系统位（M6 暂留装饰）
///   button8: (18,18) -(232,54)   → 系统位（M6 暂留装饰）
///
/// Source 1280×720 → Canvas 1920×1080 缩放系数 1.5x（同 16:9 比例）。
/// </remarks>
public class MainMenuScreen : UIScreenBase
{
    private const string BackgroundAddress = "Assets/RenpyResources/gui/zhu/zhu_ditu.jpg";
    private const string LogoAddress = "Assets/RenpyResources/gui/zhu/zhu_logo1.png";

    /// <summary>每个按钮的像素 bounds（在 1280×720 源图里）。</summary>
    private static readonly RectInt[] ButtonBoundsSrc =
    {
        new RectInt(18, 445, 279, 37),  // 1
        new RectInt(17, 398, 288, 37),  // 2
        new RectInt(17, 329, 286, 38),  // 3
        new RectInt(18, 281, 288, 37),  // 4
        new RectInt(18, 215, 288, 37),  // 5
        new RectInt(18, 116, 215, 37),  // 6
        new RectInt(17, 66,  214, 37),  // 7
        new RectInt(18, 18,  215, 37),  // 8
    };

    private RawImage _bgImage;
    private RawImage _logoImage;
    private readonly RawImage[] _buttonLayers = new RawImage[8];

    private AsyncOperationHandle<Texture2D> _bgHandle;
    private AsyncOperationHandle<Texture2D> _logoHandle;
    private readonly AsyncOperationHandle<Texture2D>[] _buttonHandles = new AsyncOperationHandle<Texture2D>[8];

    protected override void BuildContent()
    {
        // 0) 黑色兜底
        CreateFullScreenBackground(Root, Color.black);

        // 1) 全屏背景
        _bgImage = CreateFullScreenRawImage(Root, "Background");

        // 2) 8 张 button sprite 层（也是全屏 RawImage，sprite 的透明区天然不挡视觉）
        for (int i = 0; i < 8; i++)
        {
            _buttonLayers[i] = CreateFullScreenRawImage(Root, "ButtonLayer" + (i + 1));
        }

        // 3) Logo 在中上方
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

        // 4) 8 个透明 hit-test rect（前 6 个有 action，后 2 个保持装饰）
        UnityAction[] actions =
        {
            OnStartGame,    // button1 → 开始游戏
            OnLoadGame,     // button2 → 读取存档
            OnSettings,     // button3 → 设置
            OnExtras,       // button4 → 附加内容
            OnQuit,         // button5 → 退出游戏
            OnRecollection, // button6 → 回想模式
            null,           // button7 → 装饰
            null,           // button8 → 装饰
        };
        for (int i = 0; i < ButtonBoundsSrc.Length; i++)
        {
            if (actions[i] == null) continue;
            CreateHitRect(Root, "Hit" + (i + 1), ButtonBoundsSrc[i], actions[i]);
        }

        CreateLabel(Root, "v1.0 — Unity 移植版", new Vector2(0f, -500f), 16);
    }

    /// <summary>把源图里的按钮 bounds 转换成 canvas 中心坐标 + 大小的 Image+Button hit-rect。</summary>
    private static void CreateHitRect(Transform parent, string name, RectInt bounds, UnityAction onClick)
    {
        // 源 1280×720 → 画布 1920×1080，缩放 1.5x；Y 轴在 Unity 是从底到上递增
        const float scale = 1.5f;
        float canvasX = ((bounds.x + bounds.width * 0.5f) - 640f) * scale;
        float canvasY = ((bounds.y + bounds.height * 0.5f) - 360f) * scale;
        Vector2 size = new Vector2(bounds.width * scale, bounds.height * scale);

        GameObject hit = new GameObject(name);
        hit.transform.SetParent(parent, false);
        Image img = hit.AddComponent<Image>();
        img.color = new Color(1f, 1f, 1f, 0f); // 完全透明但接收点击
        Button btn = hit.AddComponent<Button>();
        btn.transition = Selectable.Transition.None;
        btn.onClick.AddListener(onClick);

        RectTransform rt = hit.GetComponent<RectTransform>();
        rt.anchorMin = new Vector2(0.5f, 0.5f);
        rt.anchorMax = new Vector2(0.5f, 0.5f);
        rt.pivot = new Vector2(0.5f, 0.5f);
        rt.anchoredPosition = new Vector2(canvasX, canvasY);
        rt.sizeDelta = size;
    }

    private static RawImage CreateFullScreenRawImage(Transform parent, string name)
    {
        GameObject go = new GameObject(name);
        go.transform.SetParent(parent, false);
        RawImage img = go.AddComponent<RawImage>();
        img.color = Color.white;
        // 关键：raycastTarget=false 让点击穿透到下面的 hit rect
        img.raycastTarget = false;
        RectTransform rt = go.GetComponent<RectTransform>();
        rt.anchorMin = Vector2.zero;
        rt.anchorMax = Vector2.one;
        rt.offsetMin = Vector2.zero;
        rt.offsetMax = Vector2.zero;
        return img;
    }

    public override void Show()
    {
        base.Show();
        StartCoroutine(LoadTextures());
    }

    private IEnumerator LoadTextures()
    {
        if (!_bgHandle.IsValid())
        {
            _bgHandle = Addressables.LoadAssetAsync<Texture2D>(BackgroundAddress);
            yield return _bgHandle;
            if (_bgHandle.Status == AsyncOperationStatus.Succeeded && _bgHandle.Result != null)
                _bgImage.texture = _bgHandle.Result;
            else
                Debug.LogWarning("[MainMenu] 背景图加载失败");
        }

        if (!_logoHandle.IsValid())
        {
            _logoHandle = Addressables.LoadAssetAsync<Texture2D>(LogoAddress);
            yield return _logoHandle;
            if (_logoHandle.Status == AsyncOperationStatus.Succeeded && _logoHandle.Result != null)
                _logoImage.texture = _logoHandle.Result;
            else
                Debug.LogWarning("[MainMenu] Logo 加载失败");
        }

        for (int i = 0; i < 8; i++)
        {
            if (_buttonHandles[i].IsValid()) continue;
            string addr = $"Assets/RenpyResources/gui/zhu/zhu_button{i + 1}.png";
            _buttonHandles[i] = Addressables.LoadAssetAsync<Texture2D>(addr);
            yield return _buttonHandles[i];
            if (_buttonHandles[i].Status == AsyncOperationStatus.Succeeded && _buttonHandles[i].Result != null)
                _buttonLayers[i].texture = _buttonHandles[i].Result;
        }
    }

    public override void Hide()
    {
        base.Hide();
    }

    private void OnDestroy()
    {
        if (_bgHandle.IsValid()) Addressables.Release(_bgHandle);
        if (_logoHandle.IsValid()) Addressables.Release(_logoHandle);
        for (int i = 0; i < 8; i++)
            if (_buttonHandles[i].IsValid()) Addressables.Release(_buttonHandles[i]);
    }

    private void OnStartGame()
    {
        UIScreenManager.Instance.PopAll();
        GameMethods gm = GameObject.Find("Game Methods")?.GetComponent<GameMethods>();
        if (gm != null && LabelRegistry.Instance != null)
            gm.StartCoroutine(LabelRegistry.Instance.RunCoroutineByMethodOnly("label_zhuxian0"));
        else
            Debug.LogError("[MainMenu] 无法启动：缺少 GameMethods / LabelRegistry");
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
