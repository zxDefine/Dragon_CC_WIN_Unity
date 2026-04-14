using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

/// <summary>
/// M4.10 CG 鉴赏 — 对应 Renpy screens.rpy L5458 <c>screen huixiang_cg</c>。
/// 网格展示已解锁的 CG，点击放大全屏预览。
/// 解锁逻辑暂以 Gallery_fanwai*_lock 等 Persistent 标志简化。
/// </summary>
public class CGGalleryScreen : UIScreenBase
{
    public struct CGEntry
    {
        public string displayName;
        public string address;      // Addressables 路径
        public string requiredFlag; // Defaults.Persistent.<flag> != 0 才解锁
        public CGEntry(string name, string addr, string flag) { displayName = name; address = addr; requiredFlag = flag; }
    }

    /// <summary>CG 列表：首批 9 张代表性 CG，全量扫描推迟到 M7 资源整理阶段。</summary>
    private static readonly List<CGEntry> Entries = new List<CGEntry>
    {
        new CGEntry("决战 · 九剑",   "Assets/RenpyResources/images/juezhan2_cg2_ren1.png", "Jq_9_6"),
        new CGEntry("决战 · 压制",   "Assets/RenpyResources/images/juezhan2_cg5_ren1.png", "Jq_9_6"),
        new CGEntry("决战 · 拥抱",   "Assets/RenpyResources/images/juezhan_cg1.png",       "Jq_9_6"),
        new CGEntry("团战 · 破冰",   "Assets/RenpyResources/images/juezhan2_cg9.png",      "Jq_10_5"),
        new CGEntry("返回 · 起飞",   "Assets/RenpyResources/images/tiankong_baitian.png",  "Jq_10_11"),
        new CGEntry("番外 · 日常",   "Assets/RenpyResources/images/caodi2.png",            "Gallery_fanwai1_lock"),
        new CGEntry("番外 · 雪夜",   "Assets/RenpyResources/images/senlin2.png",           "Gallery_fanwai2_lock"),
        new CGEntry("番外 · 桃花",   "Assets/RenpyResources/images/senlin1_baitian.png",   "Gallery_fanwai3_lock"),
        new CGEntry("结局 · 驯养",   "Assets/RenpyResources/images/tongdaozi_cg_layered.png", "He_ending"),
    };

    protected override void BuildContent()
    {
        CreateFullScreenBackground(Root, new Color(0.02f, 0.02f, 0.08f, 0.95f));
        CreateLabel(Root, "CG 鉴赏", new Vector2(0f, 460f), 42);

        GameObject grid = new GameObject("CGGrid");
        grid.transform.SetParent(Root, false);
        GridLayoutGroup glg = grid.AddComponent<GridLayoutGroup>();
        glg.cellSize = new Vector2(360f, 220f);
        glg.spacing = new Vector2(20f, 20f);
        glg.padding = new RectOffset(20, 20, 20, 20);
        glg.childAlignment = TextAnchor.UpperCenter;
        RectTransform gridRt = grid.GetComponent<RectTransform>();
        gridRt.anchorMin = new Vector2(0.5f, 0.5f);
        gridRt.anchorMax = new Vector2(0.5f, 0.5f);
        gridRt.pivot = new Vector2(0.5f, 0.5f);
        gridRt.anchoredPosition = new Vector2(0f, 50f);
        gridRt.sizeDelta = new Vector2(1400f, 800f);

        for (int i = 0; i < Entries.Count; i++)
        {
            CGEntry e = Entries[i];
            bool unlocked = IsUnlocked(e.requiredFlag);
            int capture = i;
            var btn = CreateButton(grid.transform, unlocked ? e.displayName : "? ? ?", Vector2.zero, Vector2.zero,
                () => { if (unlocked) OnPreview(capture); });
            var layoutEl = btn.AddComponent<LayoutElement>();
            layoutEl.preferredWidth = 360f;
            layoutEl.preferredHeight = 220f;
            if (!unlocked)
            {
                var img = btn.GetComponent<Image>();
                if (img != null) img.color = new Color(0.1f, 0.1f, 0.1f, 0.9f);
            }
        }

        CreateButton(Root, "返回", new Vector2(0f, -440f), new Vector2(160f, 50f), () => UIScreenManager.Instance.Pop());
    }

    private static bool IsUnlocked(string flag)
    {
        var persistentType = typeof(Defaults).GetNestedType("Persistent", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
        var f = persistentType?.GetField(flag, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static)
            ?? typeof(Defaults).GetField(flag, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
        if (f == null) return false;
        object v = f.GetValue(null);
        if (v is int iv) return iv != 0;
        if (v is bool bv) return bv;
        return false;
    }

    private void OnPreview(int idx)
    {
        if (idx < 0 || idx >= Entries.Count) return;
        // M5.2：弹出全屏 overlay 显示真实图像；点击任意处关闭
        StartCoroutine(LoadAndShow(Entries[idx]));
    }

    private AsyncOperationHandle<Texture2D> _activeHandle;
    private GameObject _activePreview;

    private System.Collections.IEnumerator LoadAndShow(CGEntry entry)
    {
        // 释放上一张
        ClosePreview();

        // 用局部 handle 避免快速重复点击时 _activeHandle 被后一次调用覆盖，
        // 导致本协程 yield 恢复后读到的是别人家的 handle。
        var handle = Addressables.LoadAssetAsync<Texture2D>(entry.address);
        _activeHandle = handle;
        yield return handle;
        if (handle.Status != AsyncOperationStatus.Succeeded || handle.Result == null)
        {
            Debug.LogWarning($"[CGGallery] 加载失败：{entry.address}");
            yield break;
        }

        Texture2D tex = handle.Result;
        Debug.Log($"[CGGallery] 预览 {entry.displayName} ({tex.width}x{tex.height})");

        // 全屏半透明背景 + Image 组件
        _activePreview = new GameObject("CGPreview");
        _activePreview.transform.SetParent(Root, false);

        // 背景遮罩（点击关闭）
        Image bg = _activePreview.AddComponent<Image>();
        bg.color = new Color(0f, 0f, 0f, 0f); // 起始透明，将动画到 0.94
        Button closeBtn = _activePreview.AddComponent<Button>();
        closeBtn.onClick.AddListener(ClosePreview);

        RectTransform bgRt = _activePreview.GetComponent<RectTransform>();
        bgRt.anchorMin = Vector2.zero;
        bgRt.anchorMax = Vector2.one;
        bgRt.offsetMin = Vector2.zero;
        bgRt.offsetMax = Vector2.zero;

        // 图片本体
        GameObject imgGo = new GameObject("Image");
        imgGo.transform.SetParent(_activePreview.transform, false);
        RawImage img = imgGo.AddComponent<RawImage>();
        img.texture = tex;
        img.color = new Color(1f, 1f, 1f, 0f); // 起始透明

        // 按宽高比适配到 ~1600x900 内部区域
        float maxW = 1600f, maxH = 900f;
        float aspect = (float)tex.width / Mathf.Max(1, tex.height);
        float w = maxW, h = maxW / aspect;
        if (h > maxH) { h = maxH; w = maxH * aspect; }
        RectTransform imgRt = imgGo.GetComponent<RectTransform>();
        imgRt.anchorMin = new Vector2(0.5f, 0.5f);
        imgRt.anchorMax = new Vector2(0.5f, 0.5f);
        imgRt.pivot = new Vector2(0.5f, 0.5f);
        imgRt.anchoredPosition = Vector2.zero;
        imgRt.sizeDelta = new Vector2(w, h);
        imgRt.localScale = Vector3.one * 0.92f; // 起始略微缩小，将动画到 1.0

        // 提示
        var hintGo = CreateLabel(_activePreview.transform, entry.displayName + "（点击任意位置返回）",
            new Vector2(0f, -h * 0.5f - 40f), 22);
        var hintText = hintGo.GetComponent<UnityEngine.UI.Text>();
        if (hintText != null) hintText.color = new Color(1f, 1f, 1f, 0f);

        // 入场动画：背景渐黑 + 图片同步淡入 + 轻微 ease-out 缩放
        StartCoroutine(PreviewIntroAnim(bg, img, imgRt, hintText));
    }

    private System.Collections.IEnumerator PreviewIntroAnim(Image bg, RawImage img, RectTransform imgRt, UnityEngine.UI.Text hint)
    {
        const float duration = 0.32f;
        float t = 0f;
        Vector3 startScale = Vector3.one * 0.92f;
        while (t < duration)
        {
            t += Time.unscaledDeltaTime;
            float k = Mathf.Clamp01(t / duration);
            float ease = 1f - Mathf.Pow(1f - k, 3f); // ease-out cubic
            if (bg != null) bg.color = new Color(0f, 0f, 0f, 0.94f * k);
            if (img != null) img.color = new Color(1f, 1f, 1f, k);
            if (imgRt != null) imgRt.localScale = Vector3.Lerp(startScale, Vector3.one, ease);
            if (hint != null) hint.color = new Color(1f, 1f, 1f, k);
            yield return null;
        }
        if (bg != null) bg.color = new Color(0f, 0f, 0f, 0.94f);
        if (img != null) img.color = Color.white;
        if (imgRt != null) imgRt.localScale = Vector3.one;
        if (hint != null) hint.color = Color.white;
    }

    public void ClosePreview()
    {
        if (_activePreview != null)
        {
            Destroy(_activePreview);
            _activePreview = null;
        }
        if (_activeHandle.IsValid())
        {
            Addressables.Release(_activeHandle);
            _activeHandle = default;
        }
    }

    public override void Hide()
    {
        ClosePreview();
        base.Hide();
    }
}
