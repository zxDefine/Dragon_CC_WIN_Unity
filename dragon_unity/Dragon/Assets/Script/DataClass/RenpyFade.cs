/// <summary>
/// Renpy Fade 转场数据类，存储淡出、保持、淡入时间及颜色信息
/// </summary>
/// <remarks>
/// 对应 Renpy 的 Fade(out, hold, in, color) 转场定义。
/// x = 淡出时间, y = 保持时间, z = 淡入时间, colorName = 中间颜色名称
/// </remarks>
public class RenpyFade
{
    private float _x;
    private float _y;
    private float _z;
    private string _colorName;

    /// <summary>淡出时间（秒），对应 Renpy Fade 的第一个参数</summary>
    public float FadeOut => _x;

    /// <summary>保持时间（秒），对应 Renpy Fade 的第二个参数</summary>
    public float Hold => _y;

    /// <summary>淡入时间（秒），对应 Renpy Fade 的第三个参数</summary>
    public float FadeIn => _z;

    /// <summary>转场中间颜色名称，对应 Renpy Fade 的 color 参数</summary>
    public string ColorName => _colorName;

    /// <summary>
    /// 构造 RenpyFade 实例
    /// </summary>
    /// <param name="x">淡出时间（秒）</param>
    /// <param name="y">保持时间（秒）</param>
    /// <param name="z">淡入时间（秒）</param>
    /// <param name="colorName">中间颜色名称（如 "#000"）</param>
    public RenpyFade(float x, float y, float z, string colorName)
    {
        _x = x;
        _y = y;
        _z = z;
        _colorName = colorName;
    }
}