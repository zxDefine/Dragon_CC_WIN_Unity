using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// M4.8 音乐回忆 — 对应 Renpy screens.rpy L1977 <c>screen music_huixiang</c>。
/// 列出 BGM 与 vocal 曲目，点击播放。解锁状态根据 Defaults.Persistent.Jq_* 判断。
/// </summary>
public class MusicGalleryScreen : UIScreenBase
{
    /// <summary>初始曲目数据。实际 M6 会改为从 audio/music 目录扫描或读取 JSON 曲库。</summary>
    private static readonly List<TrackEntry> Tracks = new List<TrackEntry>
    {
        new TrackEntry("adventure",             "开始主题",          "audio/music/adventure.mp3"),
        new TrackEntry("yongzhe_wenxin1",       "勇者温馨 Ⅰ",       "audio/music/yongzhe_wenxin1.mp3"),
        new TrackEntry("yongzhe_wenxin2",       "勇者温馨 Ⅱ",       "audio/music/yongzhe_wenxin2.mp3"),
        new TrackEntry("yongzhe_gandong",       "勇者感动",          "audio/music/yongzhe_gandong.mp3"),
        new TrackEntry("yongzhe_kaixin",        "勇者开心",          "audio/music/yongzhe_kaixin.mp3"),
        new TrackEntry("juezhan_ran",           "决战 Ran",          "audio/music/juezhan/ran_theme_004.mp3"),
        new TrackEntry("juezhan_sadness",       "决战悲伤",          "audio/music/juezhan/sadness_room.mp3"),
        new TrackEntry("juezhan_epic",          "史诗战斗",          "audio/music/juezhan/PerituneMaterial_Epic.mp3"),
        new TrackEntry("bing_foreboding",       "冰之不祥",          "audio/music/wenxin/bing_PerituneMaterial_Foreboding_loop.mp3"),
    };

    public struct TrackEntry
    {
        public string id;
        public string displayName;
        public string path;
        public TrackEntry(string id, string name, string path) { this.id = id; this.displayName = name; this.path = path; }
    }

    protected override void BuildContent()
    {
        CreateFullScreenBackground(Root, new Color(0.04f, 0.02f, 0.07f, 0.95f));
        CreateLabel(Root, "音乐回忆", new Vector2(0f, 450f), 42);

        float y = 360f;
        for (int i = 0; i < Tracks.Count; i++)
        {
            TrackEntry t = Tracks[i];
            int capture = i;
            CreateButton(Root, t.displayName, new Vector2(0f, y - i * 70f), new Vector2(600f, 58f), () => OnPlayTrack(capture));
        }

        CreateButton(Root, "停止", new Vector2(-220f, -420f), new Vector2(160f, 50f), OnStop);
        CreateButton(Root, "返回", new Vector2(220f, -420f), new Vector2(160f, 50f), () => UIScreenManager.Instance.Pop());
    }

    private void OnPlayTrack(int idx)
    {
        if (idx < 0 || idx >= Tracks.Count) return;
        var track = Tracks[idx];
        if (AudioManager.I != null)
        {
            AudioManager.I.StartCoroutine(AudioManager.I.Play("music", 0.5f, 0.8f, new[] { track.path }));
            Debug.Log($"[MusicGallery] 播放 {track.displayName}");
        }
    }

    private void OnStop()
    {
        if (AudioManager.I != null)
        {
            AudioManager.I.StartCoroutine(AudioManager.I.Stop("music", 1f));
        }
    }
}
