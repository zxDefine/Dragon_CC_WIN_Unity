using UnityEngine;

public class CustomCursor : MonoBehaviour
{
    public Texture2D cursorTexture; // 拖鼠标图案到这里
    public Vector2 hotSpot = Vector2.zero; // 鼠标热点
    public CursorMode cursorMode = CursorMode.Auto;

    void Start()
    {
        // 如果没设置图片，不设置鼠标
        if (cursorTexture != null)
        {
            Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
        }
    }
}
