using System.Collections;
using UnityEngine;

public class AudioChannel
{
    private AudioSource audioSource;
    private float targetVolume = 1f;
    private bool isMuted = false;

    public AudioChannel(string channelName, Transform parent)
    {
        // 创建GameObject来承载AudioSource
        GameObject channelObject = new GameObject($"AudioChannel_{channelName}");
        channelObject.transform.SetParent(parent, false);
        
        // 添加AudioSource组件
        audioSource = channelObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;
        audioSource.loop = false;
    }

    /// <summary>
    /// 播放音频
    /// </summary>
    /// <param name="clip">音频片段</param>
    /// <param name="fadein">淡入时间</param>
    /// <param name="volume">音量</param>
    /// <param name="loop">是否循环</param>
    public IEnumerator Play(AudioClip clip, float fadein, float volume, bool loop = false)
    {
        yield return Play(clip, fadein, volume, 0f, -1f, loop);
    }

    /// <summary>
    /// 播放音频片段（指定时间段）
    /// </summary>
    /// <param name="clip">音频片段</param>
    /// <param name="fadein">淡入时间</param>
    /// <param name="volume">音量</param>
    /// <param name="startTime">开始时间（秒）</param>
    /// <param name="endTime">结束时间（秒），-1表示播放到结尾</param>
    /// <param name="loop">是否循环</param>
    public IEnumerator Play(AudioClip clip, float fadein, float volume, float startTime, float endTime, bool loop = false)
    {
        if (clip == null) yield break;

        // 如果正在播放，只修改音量和淡入效果
        if (audioSource.isPlaying)
        {
            // 设置新的目标音量
            float newTargetVolume = Mathf.Clamp01(volume);

            // 如果音量有变化，执行淡入效果
            if (Mathf.Abs(newTargetVolume - targetVolume) > 0.01f || fadein > 0f)
            {
                yield return FadeIn(newTargetVolume, fadein);
            }
            else
            {
                // 直接设置音量
                SetVolume(newTargetVolume);
            }
            yield break;
        }

        // 如果不在播放，设置新的音频片段
        audioSource.clip = clip;
        audioSource.loop = loop;

        // 设置目标音量
        targetVolume = Mathf.Clamp01(volume);

        // 设置开始时间
        if (startTime > 0f)
        {
            audioSource.time = startTime;
        }

        // 开始播放
        audioSource.Play();

        // 淡入效果
        if (fadein > 0f)
        {
            audioSource.volume = 0f;
            float elapsed = 0f;

            while (elapsed < fadein)
            {
                elapsed += Time.unscaledDeltaTime;
                float t = elapsed / fadein;
                audioSource.volume = Mathf.Lerp(0f, targetVolume, t);
                yield return null;
            }
        }

        audioSource.volume = targetVolume;
        
        // 如果有结束时间，等待播放到结束时间
        if (endTime > 0f)
        {
            while (audioSource.isPlaying && audioSource.time < endTime)
            {
                yield return null;
            }
            
            // 如果到达结束时间，根据是否循环决定是否停止播放
            if (audioSource.isPlaying && audioSource.time >= endTime)
            {
                if (!loop)
                {
                    audioSource.Stop();
                }
                // 如果是循环播放，AudioSource会自动重新开始播放
            }
        }
    }

    /// <summary>
    /// 设置音量
    /// </summary>
    /// <param name="volume">音量值 (0-1)</param>
    public void SetVolume(float volume)
    {
        targetVolume = Mathf.Clamp01(volume);
        if (!isMuted)
        {
            audioSource.volume = targetVolume;
        }
    }

    /// <summary>
    /// 获取当前音量
    /// </summary>
    /// <returns>当前音量值</returns>
    public float GetVolume()
    {
        return targetVolume;
    }

    /// <summary>
    /// 淡入音量
    /// </summary>
    /// <param name="targetVolume">目标音量</param>
    /// <param name="duration">淡入时间</param>
    public IEnumerator FadeIn(float targetVolume, float duration)
    {
        float startVolume = audioSource.volume;
        float endVolume = Mathf.Clamp01(targetVolume);
        
        float elapsed = 0f;
        while (elapsed < duration)
        {
            elapsed += Time.unscaledDeltaTime;
            float t = elapsed / duration;
            audioSource.volume = Mathf.Lerp(startVolume, endVolume, t);
            yield return null;
        }
        
        audioSource.volume = endVolume;
        this.targetVolume = endVolume;
    }

    /// <summary>
    /// 淡出音量
    /// </summary>
    /// <param name="duration">淡出时间</param>
    public IEnumerator FadeOut(float duration)
    {
        float startVolume = audioSource.volume;
        
        float elapsed = 0f;
        while (elapsed < duration)
        {
            elapsed += Time.unscaledDeltaTime;
            float t = elapsed / duration;
            audioSource.volume = Mathf.Lerp(startVolume, 0f, t);
            yield return null;
        }
        
        audioSource.volume = 0f;
    }

    /// <summary>
    /// 暂停播放
    /// </summary>
    public void Pause()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Pause();
        }
    }

    /// <summary>
    /// 恢复播放
    /// </summary>
    public void Resume()
    {
        if (!audioSource.isPlaying && audioSource.clip != null)
        {
            audioSource.UnPause();
        }
    }

    /// <summary>
    /// 停止播放
    /// </summary>
    /// <param name="fadeout">淡出时间</param>
    public IEnumerator Stop(float fadeout = 0f)
    {
        if (!audioSource.isPlaying) yield break;

        if (fadeout > 0f)
        {
            yield return FadeOut(fadeout);
        }
        
        audioSource.Stop();
    }

    /// <summary>
    /// 检查是否正在播放
    /// </summary>
    /// <returns>是否正在播放</returns>
    public bool IsPlaying()
    {
        return audioSource.isPlaying;
    }

    /// <summary>
    /// 静音
    /// </summary>
    public void Mute()
    {
        isMuted = true;
        audioSource.volume = 0f;
    }

    /// <summary>
    /// 取消静音
    /// </summary>
    public void Unmute()
    {
        isMuted = false;
        audioSource.volume = targetVolume;
    }

    /// <summary>
    /// 检查是否静音
    /// </summary>
    /// <returns>是否静音</returns>
    public bool IsMuted()
    {
        return isMuted;
    }

    /// <summary>
    /// 销毁资源
    /// </summary>
    public void Destroy()
    {
        if (audioSource != null && audioSource.gameObject != null)
        {
            Object.DestroyImmediate(audioSource.gameObject);
        }
    }
}
