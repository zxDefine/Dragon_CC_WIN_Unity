using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// M4.5 设置画面 — 对应 Renpy screens.rpy L6370 <c>screen sz</c> / 以及 preferences。
/// 音量（music/sound/voice）、文字速度、自动播放时间、全屏切换。
/// </summary>
/// <remarks>
/// 存档位：设置存在 Defaults.Preferences.*（内存）+ PlayerPrefs（持久化）两处。
/// </remarks>
public class SettingsScreen : UIScreenBase
{
    private const string PP_Music = "pref.volume.music";
    private const string PP_Sound = "pref.volume.sound";
    private const string PP_Voice = "pref.volume.voice";
    private const string PP_TextCps = "pref.text_cps";
    private const string PP_Afm = "pref.afm_time";
    private const string PP_Fullscreen = "pref.fullscreen";

    protected override void BuildContent()
    {
        CreateFullScreenBackground(Root, new Color(0.06f, 0.06f, 0.08f, 0.95f));
        CreateLabel(Root, "设置", new Vector2(0f, 450f), 42);

        float y = 300f;
        CreateSlider(Root, "音乐音量", new Vector2(0f, y), 0f, 1f,
            PlayerPrefs.GetFloat(PP_Music, Defines.Config.Default_music_volume),
            v => { PlayerPrefs.SetFloat(PP_Music, v); ApplyMusicVolume(v); });

        y -= 70f;
        CreateSlider(Root, "音效音量", new Vector2(0f, y), 0f, 1f,
            PlayerPrefs.GetFloat(PP_Sound, Defines.Config.Default_sfx_volume),
            v => { PlayerPrefs.SetFloat(PP_Sound, v); ApplySoundVolume(v); });

        y -= 70f;
        CreateSlider(Root, "语音音量", new Vector2(0f, y), 0f, 1f,
            PlayerPrefs.GetFloat(PP_Voice, Defines.Config.Default_voice_volume),
            v => { PlayerPrefs.SetFloat(PP_Voice, v); ApplyVoiceVolume(v); });

        y -= 70f;
        CreateSlider(Root, "文字速度", new Vector2(0f, y), 5f, 120f,
            PlayerPrefs.GetInt(PP_TextCps, Defaults.Preferences.Text_cps),
            v =>
            {
                int cps = Mathf.RoundToInt(v);
                PlayerPrefs.SetInt(PP_TextCps, cps);
                Defaults.Preferences.Text_cps = cps;
            });

        y -= 70f;
        CreateSlider(Root, "自动播放间隔", new Vector2(0f, y), 1f, 20f,
            PlayerPrefs.GetInt(PP_Afm, Defaults.Preferences.Afm_time),
            v =>
            {
                int t = Mathf.RoundToInt(v);
                PlayerPrefs.SetInt(PP_Afm, t);
                Defaults.Preferences.Afm_time = t;
            });

        y -= 90f;
        CreateButton(Root, Screen.fullScreen ? "切换：当前全屏" : "切换：当前窗口",
            new Vector2(0f, y), new Vector2(280f, 50f), OnToggleFullscreen);

        CreateButton(Root, "返回", new Vector2(0f, -420f), new Vector2(160f, 50f), () => UIScreenManager.Instance.Pop());
    }

    private void OnToggleFullscreen()
    {
        Screen.fullScreen = !Screen.fullScreen;
        PlayerPrefs.SetInt(PP_Fullscreen, Screen.fullScreen ? 1 : 0);
    }

    private static void ApplyMusicVolume(float v) { if (AudioManager.I != null) AudioManager.I.SetVolume("music", v); }
    private static void ApplySoundVolume(float v) { if (AudioManager.I != null) AudioManager.I.SetVolume("sound", v); }
    private static void ApplyVoiceVolume(float v) { if (AudioManager.I != null) AudioManager.I.SetVolume("voice", v); }
}
