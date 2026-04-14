using System;
using System.Text.RegularExpressions;

/// <summary>
/// 音频路径解析器，用于解析包含时间标记的音频路径
/// </summary>
public class AudioPathInfo
{
    public string Path { get; set; }
    public float StartTime { get; set; }
    public float EndTime { get; set; }
    public bool HasTimeRange { get; set; }
    public bool IsSilence { get; set; }
    public float SilenceDuration { get; set; }

    public AudioPathInfo(string path, float startTime = 0f, float endTime = -1f)
    {
        Path = path;
        StartTime = startTime;
        EndTime = endTime;
        HasTimeRange = endTime > 0f;
        IsSilence = false;
        SilenceDuration = 0f;
    }

    public AudioPathInfo(float silenceDuration)
    {
        Path = "";
        StartTime = 0f;
        EndTime = -1f;
        HasTimeRange = false;
        IsSilence = true;
        SilenceDuration = silenceDuration;
    }
}

public static class AudioPathParser
{
    private static readonly Regex timeRangeRegex = new Regex(@"<from\s+(\d+(?:\.\d+)?)\s+to\s+(\d+(?:\.\d+)?)>\s*(.+)", RegexOptions.IgnoreCase);
    private static readonly Regex silenceRegex = new Regex(@"<silence\s+(\d+(?:\.\d+)?)>", RegexOptions.IgnoreCase);

    /// <summary>
    /// 解析音频路径，提取时间范围和实际路径
    /// </summary>
    /// <param name="inputPath">输入的音频路径</param>
    /// <returns>解析后的音频路径信息</returns>
    public static AudioPathInfo Parse(string inputPath)
    {
        if (string.IsNullOrEmpty(inputPath))
        {
            return new AudioPathInfo(inputPath);
        }

        // 检查是否是静音标记
        var silenceMatch = silenceRegex.Match(inputPath);
        if (silenceMatch.Success)
        {
            float silenceDuration = float.Parse(silenceMatch.Groups[1].Value);
            return new AudioPathInfo(silenceDuration);
        }

        // 检查是否是时间范围标记
        var match = timeRangeRegex.Match(inputPath);
        if (match.Success)
        {
            float startTime = float.Parse(match.Groups[1].Value);
            float endTime = float.Parse(match.Groups[2].Value);
            string actualPath = match.Groups[3].Value.Trim();

            return new AudioPathInfo(actualPath, startTime, endTime);
        }

        // 没有特殊标记，返回原始路径
        return new AudioPathInfo(inputPath);
    }

    /// <summary>
    /// 检查路径是否包含时间标记
    /// </summary>
    /// <param name="inputPath">输入的音频路径</param>
    /// <returns>是否包含时间标记</returns>
    public static bool HasTimeRange(string inputPath)
    {
        return timeRangeRegex.IsMatch(inputPath);
    }
}
