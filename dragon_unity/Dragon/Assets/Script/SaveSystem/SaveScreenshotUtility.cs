using UnityEngine;

/// <summary>
/// M6 polish G：存档槽位缩略图捕获工具。
/// 通过 <see cref="ScreenCapture.CaptureScreenshotAsTexture"/> 拿到当前 Game View 像素，
/// 再 Bilinear 缩放到目标尺寸（默认 256×144，对应 Renpy
/// <c>Defines.Config.Thumbnail_width / Thumbnail_height</c>），最后编码为 PNG。
/// </summary>
/// <remarks>
/// 必须在 <c>WaitForEndOfFrame</c> 之后调用，否则
/// CaptureScreenshotAsTexture 会返回 null（Unity 限制）。
/// 缩放采用 RenderTexture + Blit，避免 GetPixels 的高 CPU 开销。
/// </remarks>
public static class SaveScreenshotUtility
{
    /// <summary>
    /// 捕获当前帧 Game View，缩放到 (width × height) 并返回 PNG 字节。
    /// 失败时返回 null。调用方需在 <c>WaitForEndOfFrame</c> 之后调用。
    /// </summary>
    public static byte[] CaptureGameViewPng(int width = 256, int height = 144)
    {
        Texture2D full = ScreenCapture.CaptureScreenshotAsTexture();
        if (full == null)
        {
            Debug.LogWarning("[SaveScreenshotUtility] CaptureScreenshotAsTexture returned null (was this called outside WaitForEndOfFrame?)");
            return null;
        }
        try
        {
            Texture2D scaled = ResizeBilinear(full, width, height);
            byte[] png = scaled.EncodeToPNG();
            Object.Destroy(scaled);
            return png;
        }
        finally
        {
            Object.Destroy(full);
        }
    }

    /// <summary>
    /// 使用 RenderTexture + Blit 双线性缩放，比 Texture2D.GetPixels + 手算快得多。
    /// </summary>
    private static Texture2D ResizeBilinear(Texture2D src, int targetW, int targetH)
    {
        RenderTexture rt = RenderTexture.GetTemporary(targetW, targetH, 0,
            RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
        rt.filterMode = FilterMode.Bilinear;
        RenderTexture prev = RenderTexture.active;
        try
        {
            Graphics.Blit(src, rt);
            RenderTexture.active = rt;
            Texture2D result = new Texture2D(targetW, targetH, TextureFormat.RGBA32, false);
            result.ReadPixels(new Rect(0, 0, targetW, targetH), 0, 0);
            result.Apply();
            return result;
        }
        finally
        {
            RenderTexture.active = prev;
            RenderTexture.ReleaseTemporary(rt);
        }
    }
}
