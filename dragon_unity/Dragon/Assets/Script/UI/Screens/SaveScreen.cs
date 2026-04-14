using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// M4.4 存档画面 — 对应 Renpy screens.rpy L1253 <c>screen save</c>。
/// 3 列 × 2 行 × 3 页 = 18 槽位网格。点击任一槽写入当前游戏状态。
/// </summary>
public class SaveScreen : UIScreenBase
{
    private int _currentPage = 0;
    private GameObject _gridRoot;

    protected override void BuildContent()
    {
        CreateFullScreenBackground(Root, new Color(0.06f, 0.06f, 0.08f, 0.95f));
        CreateLabel(Root, "保存", new Vector2(0f, 450f), 42);

        _gridRoot = new GameObject("SlotGrid");
        _gridRoot.transform.SetParent(Root, false);
        RectTransform gridRt = _gridRoot.AddComponent<RectTransform>();
        gridRt.anchorMin = new Vector2(0.5f, 0.5f);
        gridRt.anchorMax = new Vector2(0.5f, 0.5f);
        gridRt.pivot = new Vector2(0.5f, 0.5f);
        gridRt.anchoredPosition = new Vector2(0f, 50f);
        gridRt.sizeDelta = new Vector2(1600f, 700f);

        // 底部分页按钮 + 返回
        CreateButton(Root, "上一页", new Vector2(-260f, -400f), new Vector2(140f, 50f), () => SetPage(_currentPage - 1));
        CreateButton(Root, "下一页", new Vector2(260f, -400f), new Vector2(140f, 50f), () => SetPage(_currentPage + 1));
        CreateButton(Root, "返回",   new Vector2(0f,   -400f), new Vector2(140f, 50f), () => UIScreenManager.Instance.Pop());

        SetPage(0);
    }

    private void SetPage(int page)
    {
        if (page < 0) page = 0;
        if (page >= SaveSystem.MaxPages) page = SaveSystem.MaxPages - 1;
        _currentPage = page;
        RebuildGrid();
    }

    private void RebuildGrid()
    {
        // 清空旧按钮
        for (int i = _gridRoot.transform.childCount - 1; i >= 0; i--)
        {
            Destroy(_gridRoot.transform.GetChild(i).gameObject);
        }

        CreateLabel(_gridRoot.transform, $"— 第 {_currentPage + 1} 页 —", new Vector2(0f, 320f), 20);

        // 3×2 网格
        float slotW = 440f, slotH = 280f;
        float gapX = 60f, gapY = 60f;
        for (int row = 0; row < 2; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                int indexInPage = row * 3 + col;
                int slotId = _currentPage * SaveSystem.SlotsPerPage + indexInPage;
                float x = (col - 1) * (slotW + gapX);
                float y = (0.5f - row) * (slotH + gapY);
                CreateSlotButton(new Vector2(x, y), new Vector2(slotW, slotH), slotId);
            }
        }
    }

    private void CreateSlotButton(Vector2 pos, Vector2 size, int slotId)
    {
        SaveSystem.SaveSlotInfo info = SaveSystem.SlotExists(slotId)
            ? SaveSystem.PeekInfo(slotId)
            : new SaveSystem.SaveSlotInfo { slot = slotId, exists = false };

        string label;
        if (info.exists)
        {
            label = $"槽 {slotId + 1}\n{info.saveTime}\n{info.chapterDisplayName}";
        }
        else
        {
            label = $"槽 {slotId + 1}\n(空)";
        }

        CreateButton(_gridRoot.transform, label, pos, size, () => OnSlotClicked(slotId));
    }

    protected virtual void OnSlotClicked(int slotId)
    {
        // 保存动作
        SaveSystem.Save(slotId, "", "（存档）");
        Debug.Log($"[SaveScreen] 保存到槽 {slotId}");
        RebuildGrid();
    }
}
