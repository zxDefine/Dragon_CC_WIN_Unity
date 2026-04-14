using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class AudioManager : MonoBehaviour
{
    public static AudioManager I { get; private set; }

    // 存储channel的字典，key是channel名称，value是AudioChannel实例
    private Dictionary<string, AudioChannel> channelMap = new Dictionary<string, AudioChannel>();
    
    // 存储每个channel的播放协程，用于管理并行播放
    private Dictionary<string, Coroutine> channelCoroutines = new Dictionary<string, Coroutine>();

    void Awake()
    {
        if (I != null) 
        { 
            Destroy(gameObject); 
            return; 
        }
        I = this;
        DontDestroyOnLoad(gameObject);
    }

    /// <summary>
    /// 播放音频
    /// </summary>
    /// <param name="channel">channel名称</param>
    /// <param name="fadein">淡入时间</param>
    /// <param name="volume">音量</param>
    /// <param name="soundPaths">音频资源路径数组</param>
    /// <returns></returns>
    public IEnumerator Play(string channel, float fadein, float volume, params string[] soundPaths)
    {
        // 检查channel是否存在，如果不存在则创建新的
        if (!channelMap.ContainsKey(channel))
        {
            CreateChannel(channel);
        }

        AudioChannel audioChannel = channelMap[channel];

        // BUG-07 修复：当通道正在播放时，先停止旧音频再播放新音频
        // Renpy 中对同一通道调用 play music 会替换当前播放的音乐
        if (audioChannel.IsPlaying())
        {
            // 停止该通道之前的播放协程（如果有的话）
            if (channelCoroutines.TryGetValue(channel, out Coroutine runningCoroutine))
            {
                StopCoroutine(runningCoroutine);
                channelCoroutines.Remove(channel);
            }

            // 停止当前音频（如有淡入参数则做淡出过渡，实现 crossfade 效果）
            if (fadein > 0f)
            {
                yield return audioChannel.Stop(fadein);
            }
            else
            {
                yield return audioChannel.Stop(0f);
            }
        }

        // 加载并播放新的音频
        if (soundPaths.Length > 0)
        {
            // 停止该channel之前的播放协程（如果有的话）
            if (channelCoroutines.TryGetValue(channel, out Coroutine existingCoroutine))
            {
                StopCoroutine(existingCoroutine);
            }
            
            // BUG-08 修复：使用 ShouldLoop() 判断通道是否需要循环播放
            // Renpy 原版中 music/music1~music4 和 soundb~soundf 都需要循环
            bool isMusicChannel = ShouldLoop(channel);
            
            // 启动新的播放协程并记录
            Coroutine newCoroutine = StartCoroutine(LoadAndPlayAudioSequence(audioChannel, soundPaths, fadein, volume, channel, isMusicChannel));
            channelCoroutines[channel] = newCoroutine;
        }
    }

    /// <summary>
    /// 创建新的音频channel
    /// </summary>
    /// <param name="channelName">channel名称</param>
    private void CreateChannel(string channelName)
    {
        if (channelMap.ContainsKey(channelName))
        {
            Debug.LogWarning($"Channel '{channelName}' 已存在");
            return;
        }

        AudioChannel newChannel = new AudioChannel(channelName, transform);
        channelMap.Add(channelName, newChannel);
        
        Debug.Log($"创建了新的音频Channel: {channelName}");
    }

    /// <summary>
    /// 获取指定的channel
    /// </summary>
    /// <param name="channelName">channel名称</param>
    /// <returns>AudioChannel实例，如果不存在则返回null</returns>
    public AudioChannel GetChannel(string channelName)
    {
        if (channelMap.TryGetValue(channelName, out AudioChannel channel))
        {
            return channel;
        }
        return null;
    }

    /// <summary>
    /// 删除指定的channel
    /// </summary>
    /// <param name="channelName">channel名称</param>
    public void RemoveChannel(string channelName)
    {
        // 停止并清理该channel的播放协程
        if (channelCoroutines.TryGetValue(channelName, out Coroutine coroutine))
        {
            StopCoroutine(coroutine);
            channelCoroutines.Remove(channelName);
        }
        
        if (channelMap.TryGetValue(channelName, out AudioChannel channel))
        {
            channel.Destroy();
            channelMap.Remove(channelName);
            Debug.Log($"删除了音频Channel: {channelName}");
        }
    }

    /// <summary>
    /// 获取所有channel名称
    /// </summary>
    /// <returns>channel名称列表</returns>
    public List<string> GetAllChannelNames()
    {
        return new List<string>(channelMap.Keys);
    }

    /// <summary>
    /// 停止指定channel的播放
    /// </summary>
    /// <param name="channel">channel名称</param>
    /// <param name="fadeout">淡出时间</param>
    /// <returns></returns>
    public IEnumerator Stop(string channel, float fadeout = 0f)
    {
        // 停止该channel的播放协程
        if (channelCoroutines.TryGetValue(channel, out Coroutine coroutine))
        {
            StopCoroutine(coroutine);
            channelCoroutines.Remove(channel);
        }
        
        if (channelMap.TryGetValue(channel, out AudioChannel audioChannel))
        {
            yield return audioChannel.Stop(fadeout);
        }
        // 如果 channel 不存在，静默跳过（Renpy 中 stop music 在没有 music 播放时不报错）
    }

    /// <summary>
    /// 设置指定channel的音量
    /// </summary>
    /// <param name="channel">channel名称</param>
    /// <param name="volume">音量值 (0-1)</param>
    public void SetVolume(string channel, float volume)
    {
        if (channelMap.TryGetValue(channel, out AudioChannel audioChannel))
        {
            audioChannel.SetVolume(volume);
        }
        else
        {
            Debug.LogWarning($"Channel '{channel}' 不存在");
        }
    }

    /// <summary>
    /// 使用Addressables加载并播放音频
    /// </summary>
    /// <param name="audioChannel">音频channel</param>
    /// <param name="audioPath">音频资源路径</param>
    /// <param name="fadein">淡入时间</param>
    /// <param name="volume">音量</param>
    /// <returns></returns>
    private IEnumerator LoadAndPlayAudio(AudioChannel audioChannel, string audioPath, float fadein, float volume)
    {
        // 解析音频路径，提取时间范围信息
        AudioPathInfo pathInfo = AudioPathParser.Parse(audioPath);
        
        // 构建完整的音频路径
        string fullPath = BuildFullAudioPath(pathInfo.Path);
        
        // 使用Addressables加载音频资源
        AsyncOperationHandle<AudioClip> loadOperation = Addressables.LoadAssetAsync<AudioClip>(fullPath);
        
        // 等待加载完成
        yield return loadOperation;
        
        if (loadOperation.Status == AsyncOperationStatus.Succeeded)
        {
            AudioClip clip = loadOperation.Result;
            if (clip != null)
            {
                if (pathInfo.HasTimeRange)
                {
                    // 播放指定时间段的音频
                    yield return audioChannel.Play(clip, fadein, volume, pathInfo.StartTime, pathInfo.EndTime);
                }
                else
                {
                    // 播放完整音频
                    yield return audioChannel.Play(clip, fadein, volume);
                }
            }
            else
            {
                Debug.LogWarning($"加载的音频资源为空: {fullPath}");
            }
        }
        else
        {
            Debug.LogError($"无法加载音频资源: {fullPath}, 错误: {loadOperation.OperationException}");
        }
        
        // 释放加载操作
        Addressables.Release(loadOperation);
    }

    /// <summary>
    /// 使用Addressables加载并顺序播放多个音频
    /// </summary>
    /// <param name="audioChannel">音频channel</param>
    /// <param name="audioPaths">音频资源路径数组</param>
    /// <param name="fadein">淡入时间</param>
    /// <param name="volume">音量</param>
    /// <param name="channelName">channel名称，用于清理协程记录</param>
    /// <param name="isMusicChannel">是否是music channel，用于循环播放</param>
    /// <returns></returns>
    private IEnumerator LoadAndPlayAudioSequence(AudioChannel audioChannel, string[] audioPaths, float fadein, float volume, string channelName = "", bool isMusicChannel = false)
    {
        // 如果是music channel，需要循环播放
        if (isMusicChannel)
        {
            yield return LoadAndPlayMusicLoop(audioChannel, audioPaths, fadein, volume, channelName);
        }
        else
        {
            // 普通channel的正常播放逻辑
            yield return LoadAndPlayNormalSequence(audioChannel, audioPaths, fadein, volume, channelName);
        }
    }

    /// <summary>
    /// 普通channel的顺序播放逻辑
    /// </summary>
    private IEnumerator LoadAndPlayNormalSequence(AudioChannel audioChannel, string[] audioPaths, float fadein, float volume, string channelName)
    {
        // 顺序播放每个音频文件
        for (int i = 0; i < audioPaths.Length; i++)
        {
            string audioPath = audioPaths[i];
            
            // 解析音频路径，提取时间范围信息
            AudioPathInfo pathInfo = AudioPathParser.Parse(audioPath);
            
            // 检查是否是静音
            if (pathInfo.IsSilence)
            {
                // 执行静音等待
                yield return WaitForSilence(pathInfo.SilenceDuration);
                continue;
            }
            
            // 构建完整的音频路径
            string fullPath = BuildFullAudioPath(pathInfo.Path);
            
            // 使用Addressables加载音频资源
            AsyncOperationHandle<AudioClip> loadOperation = Addressables.LoadAssetAsync<AudioClip>(fullPath);
            
            // 等待加载完成
            yield return loadOperation;
            
            if (loadOperation.Status == AsyncOperationStatus.Succeeded)
            {
                AudioClip clip = loadOperation.Result;
                if (clip != null)
                {
                    // 播放当前音频，等待播放完成
                    if (pathInfo.HasTimeRange)
                    {
                        // 播放指定时间段的音频
                        yield return audioChannel.Play(clip, fadein, volume, pathInfo.StartTime, pathInfo.EndTime);
                    }
                    else
                    {
                        // 播放完整音频
                        yield return audioChannel.Play(clip, fadein, volume);
                    }
                    
                    // 等待音频播放完毕
                    while (audioChannel.IsPlaying())
                    {
                        yield return null;
                    }
                }
                else
                {
                    Debug.LogWarning($"加载的音频资源为空: {fullPath}");
                }
            }
            else
            {
                Debug.LogError($"无法加载音频资源: {fullPath}, 错误: {loadOperation.OperationException}");
            }
            
            // 释放加载操作
            Addressables.Release(loadOperation);
        }
        
        Debug.Log($"Channel '{channelName}' 顺序播放完成，共播放了 {audioPaths.Length} 个音频文件");
        
        // 清理协程记录
        if (!string.IsNullOrEmpty(channelName) && channelCoroutines.ContainsKey(channelName))
        {
            channelCoroutines.Remove(channelName);
        }
    }

    /// <summary>
    /// Music channel的循环播放逻辑
    /// </summary>
    private IEnumerator LoadAndPlayMusicLoop(AudioChannel audioChannel, string[] audioPaths, float fadein, float volume, string channelName)
    {
        Debug.Log($"Music channel '{channelName}' 开始循环播放");
        
        // 对于music channel，我们只播放第一个音频文件并循环播放
        if (audioPaths.Length > 0)
        {
            string audioPath = audioPaths[0]; // 只取第一个音频文件
            
            // 解析音频路径，提取时间范围信息
            AudioPathInfo pathInfo = AudioPathParser.Parse(audioPath);
            
            // 检查是否是静音
            if (pathInfo.IsSilence)
            {
                Debug.LogWarning($"Music channel 不支持静音播放，跳过: {audioPath}");
                yield break;
            }
            
            // 构建完整的音频路径
            string fullPath = BuildFullAudioPath(pathInfo.Path);
            
            // 使用Addressables加载音频资源
            AsyncOperationHandle<AudioClip> loadOperation = Addressables.LoadAssetAsync<AudioClip>(fullPath);
            
            // 等待加载完成
            yield return loadOperation;
            
            if (loadOperation.Status == AsyncOperationStatus.Succeeded)
            {
                AudioClip clip = loadOperation.Result;
                if (clip != null)
                {
                    // 播放音频并启用循环
                    if (pathInfo.HasTimeRange)
                    {
                        // 播放指定时间段的音频（循环播放）
                        yield return audioChannel.Play(clip, fadein, volume, pathInfo.StartTime, pathInfo.EndTime, true);
                    }
                    else
                    {
                        // 播放完整音频（循环播放）
                        yield return audioChannel.Play(clip, fadein, volume, true);
                    }
                    
                    // 等待播放开始
                    while (!audioChannel.IsPlaying())
                    {
                        yield return null;
                    }
                    
                    // 持续监控播放状态，直到被停止
                    while (audioChannel.IsPlaying())
                    {
                        // 检查协程是否还存在（如果被停止则退出循环）
                        if (!channelCoroutines.ContainsKey(channelName))
                        {
                            Debug.Log($"Music channel '{channelName}' 播放被停止");
                            break;
                        }
                        yield return null;
                    }
                }
                else
                {
                    Debug.LogWarning($"加载的音频资源为空: {fullPath}");
                }
            }
            else
            {
                Debug.LogError($"无法加载音频资源: {fullPath}, 错误: {loadOperation.OperationException}");
            }
            
            // 释放加载操作
            Addressables.Release(loadOperation);
        }
        
        Debug.Log($"Music channel '{channelName}' 循环播放结束");
        
        // 清理协程记录
        if (channelCoroutines.ContainsKey(channelName))
        {
            channelCoroutines.Remove(channelName);
        }
    }

    /// <summary>
    /// 根据通道名称判断是否需要循环播放
    /// <remarks>
    /// 对应 Renpy 原版的通道循环配置：
    /// - music, music1~music4: 循环（mixer=music, loop=True）
    /// - music5: 不循环（loop=False）
    /// - soundb~soundf: 循环（mixer=sfx, loop=True）
    /// - sounda~sounda6: 不循环
    /// - 其他 sound 通道: 不循环
    /// </remarks>
    /// </summary>
    /// <param name="channel">通道名称</param>
    /// <returns>是否需要循环播放</returns>
    private static bool ShouldLoop(string channel)
    {
        string lower = channel.ToLower();

        // music 通道：music, music1~music4 循环；music5 不循环
        if (lower == "music")
            return true;
        if (lower.StartsWith("music") && lower.Length > 5)
        {
            // music5 明确不循环，其余 music1~music4 等循环
            if (lower == "music5")
                return false;
            return true;
        }

        // sound 通道：soundb~soundf 循环（单字母后缀 b~f）
        // sounda, sounda1~sounda6 等不循环
        if (lower.Length == 6 && lower.StartsWith("sound"))
        {
            char suffix = lower[5];
            if (suffix >= 'b' && suffix <= 'f')
                return true;
        }

        return false;
    }

    /// <summary>
    /// 等待指定时间的静音
    /// </summary>
    /// <param name="duration">静音持续时间（秒）</param>
    /// <returns></returns>
    private IEnumerator WaitForSilence(float duration)
    {
        Debug.Log($"开始静音等待 {duration} 秒");
        
        float elapsed = 0f;
        while (elapsed < duration)
        {
            elapsed += Time.unscaledDeltaTime;
            yield return null;
        }
        
        Debug.Log($"静音等待完成");
    }

    // ==================== 语音（Voice）系统 ====================
    // 对应 Renpy 的 voice "xxx.ogg" 和 voice sustain 语句
    // 语音使用名为 "voice" 的专用通道，不循环，播完自动停止

    /// <summary>
    /// 当前是否处于 voice sustain 状态
    /// <remarks>
    /// 对应 Renpy 的 voice sustain：当此标记为 true 时，
    /// 对话推进不会中断当前语音，语音会播放到自然结束。
    /// 每次对话推进检查后会自动重置为 false。
    /// </remarks>
    /// </summary>
    public bool IsVoiceSustaining { get; private set; } = false;

    /// <summary>
    /// 语音通道的固定名称
    /// </summary>
    private const string VoiceChannelName = "voice";

    /// <summary>
    /// 播放语音文件
    /// <remarks>
    /// 对应 Renpy 的 voice "audio/voice/xxx.ogg" 语句。
    /// 使用名为 "voice" 的专用通道播放，不循环，播完自动停止。
    /// 如果当前有语音正在播放，会先停止旧语音再播放新语音。
    /// 每次播放新语音时，sustain 标记会自动重置为 false。
    /// </remarks>
    /// </summary>
    /// <param name="voicePath">语音资源路径（相对路径，如 "audio/voice/xxx.ogg"）</param>
    /// <returns>协程迭代器</returns>
    public IEnumerator PlayVoice(string voicePath)
    {
        // 播放新语音时重置 sustain 标记
        // 因为 sustain 只对当前语音生效，新语音开始意味着新的状态
        IsVoiceSustaining = false;

        // 使用已有的 Play 方法，在 voice 通道上播放
        // fadein=0（语音通常无需淡入）、volume=1（默认满音量）、不循环（由 ShouldLoop 自动判断为 false）
        yield return Play(VoiceChannelName, 0f, 1f, soundPaths: voicePath);
    }

    /// <summary>
    /// 停止当前语音播放
    /// <remarks>
    /// 停止 voice 通道上的音频播放，并重置 sustain 标记。
    /// </remarks>
    /// </summary>
    /// <param name="fadeout">淡出时间（秒），默认为 0 立即停止</param>
    /// <returns>协程迭代器</returns>
    public IEnumerator StopVoice(float fadeout = 0f)
    {
        IsVoiceSustaining = false;
        yield return Stop(VoiceChannelName, fadeout);
    }

    /// <summary>
    /// 设置语音持续标记（voice sustain）
    /// <remarks>
    /// 对应 Renpy 的 voice sustain 语句。
    /// 设为 true 后，下一次对话推进时不会停止当前语音，
    /// 语音会继续播放到自然结束。
    /// </remarks>
    /// </summary>
    /// <param name="sustain">是否启用 sustain</param>
    public void SetVoiceSustain(bool sustain)
    {
        IsVoiceSustaining = sustain;
    }

    /// <summary>
    /// 在对话推进时调用，根据 sustain 状态决定是否停止语音
    /// <remarks>
    /// 工作流程：
    /// 1. 如果 sustain == false，停止当前语音（对应 Renpy 默认行为：新对话停止旧语音）
    /// 2. 如果 sustain == true，保持语音播放，然后重置 sustain 为 false
    ///    （sustain 只对紧接着的下一次对话推进生效一次）
    /// </remarks>
    /// </summary>
    public void HandleVoiceOnDialogAdvance()
    {
        if (IsVoiceSustaining)
        {
            // sustain 模式：保持语音播放，重置标记
            // 下一次对话推进将回到默认行为（停止语音）
            IsVoiceSustaining = false;
            Debug.Log("Voice sustain 生效：语音继续播放，sustain 标记已重置");
        }
        else
        {
            // 默认行为：停止当前语音
            AudioChannel voiceChannel = GetChannel(VoiceChannelName);
            if (voiceChannel != null && voiceChannel.IsPlaying())
            {
                // 直接停止，不用淡出（Renpy 原版行为是立即停止）
                StartCoroutine(Stop(VoiceChannelName, 0f));
                Debug.Log("对话推进：停止当前语音");
            }
        }
    }

    /// <summary>
    /// 检查语音通道是否正在播放
    /// </summary>
    /// <returns>语音是否正在播放</returns>
    public bool IsVoicePlaying()
    {
        AudioChannel voiceChannel = GetChannel(VoiceChannelName);
        return voiceChannel != null && voiceChannel.IsPlaying();
    }

    // ==================== 语音系统结束 ====================

    /// <summary>
    /// 构建完整的音频路径
    /// </summary>
    /// <param name="relativePath">相对路径</param>
    /// <returns>完整的音频路径</returns>
    /// <summary>
    /// 构建完整的音频资源 Addressable 地址。
    /// 统一归一化规则（决策 5.2 方案 C）：无论传入的是完整路径还是相对路径，都输出 Assets/RenpyResources/ 前缀的完整路径。
    /// </summary>
    /// <param name="relativePath">音频路径，可以是以下任一形式：
    ///   - 相对路径：audio/sound/xxx.mp3
    ///   - 完整路径：Assets/RenpyResources/audio/voice/xxx.ogg
    ///   - 带前导斜杠的路径：/audio/sound/xxx.mp3
    /// </param>
    /// <returns>规范化后的完整 Addressable 地址</returns>
    /// <remarks>
    /// 对应 Renpy 中音频路径的归一化处理。
    /// Renpy 原版中音频路径统一以 audio/ 开头（相对于 game/ 目录），
    /// Unity 端需加上 Assets/RenpyResources/ 前缀才能匹配 Addressable 地址。
    /// </remarks>
    private string BuildFullAudioPath(string relativePath)
    {
        if (string.IsNullOrEmpty(relativePath))
        {
            return relativePath;
        }

        // 归一化：统一反斜杠为正斜杠（防御 Windows 路径）
        string normalized = relativePath.Replace('\\', '/');

        // 去除前导斜杠
        normalized = normalized.TrimStart('/');

        // 如果已经是完整 Addressable 地址，直接返回
        if (normalized.StartsWith("Assets/RenpyResources/"))
        {
            return normalized;
        }

        // 如果以 Assets/ 开头但不是 RenpyResources，视为异常但仍返回
        if (normalized.StartsWith("Assets/"))
        {
            Debug.LogWarning($"[BuildFullAudioPath] 路径不以 Assets/RenpyResources/ 开头: {normalized}");
            return normalized;
        }

        // 否则添加 RenpyResources 前缀
        return $"Assets/RenpyResources/{normalized}";
    }
}
