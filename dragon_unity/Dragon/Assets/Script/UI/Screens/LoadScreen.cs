using UnityEngine;

/// <summary>
/// M4.4 读档画面 — 对应 Renpy screens.rpy L1378 <c>screen load</c>。
/// 复用 <see cref="SaveScreen"/> 的槽位网格布局，但点击行为变成"读档"。
/// </summary>
public class LoadScreen : SaveScreen
{
    protected override void OnSlotClicked(int slotId)
    {
        GameStateSnapshot snap = SaveSystem.Load(slotId);
        if (snap == null)
        {
            Debug.LogWarning($"[LoadScreen] 槽 {slotId} 为空或损坏");
            return;
        }
        snap.Apply();
        UIScreenManager.Instance.PopAll();

        // 跳转到快照里的 label
        if (!string.IsNullOrEmpty(snap.currentLabel) && LabelRegistry.Instance != null)
        {
            GameMethods gm = GameObject.Find("Game Methods")?.GetComponent<GameMethods>();
            if (gm != null)
            {
                gm.StartCoroutine(LabelRegistry.Instance.RunCoroutineByMethodOnly(snap.currentLabel));
                Debug.Log($"[LoadScreen] 读档成功：跳到 {snap.currentLabel}");
            }
        }
    }
}
