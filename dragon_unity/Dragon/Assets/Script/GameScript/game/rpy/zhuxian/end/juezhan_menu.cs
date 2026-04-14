using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class juezhan_menu : ILabelProvider
{
    private GameMethods _gameMethods;

    public juezhan_menu(GameMethods gameMethods)
    {
        _gameMethods = gameMethods;
    }

    // "-说服黑龙" 分支 (juezhan menu L99)
    public IEnumerator label_juezhan_menu_0_shuofu()
    {
        Defaults.Persistent.Jq_10_3 = 1;
        yield return _gameMethods.ChangeLabelTo("label_end6");
    }

    // "-就是现在" 分支 (juezhan menu L102 / L110)
    public IEnumerator label_juezhan_menu_0_jiushixianzai()
    {
        Defaults.Persistent.Jq_10_2 = 1;
        yield return _gameMethods.ChangeLabelTo("label_juezhan_1");
    }

    // "-再等等" 分支 (juezhan menu L105 / L113)
    public IEnumerator label_juezhan_menu_0_zaidengdeng()
    {
        Defaults.Persistent.Jq_10_1 = 1;
        yield return _gameMethods.ChangeLabelTo("label_juezhan_2");
    }

    // "—我爱你" 分支 (juezhan_1 menu L338)
    // 注：原 rpy 中 "-我恨你" 分支整段被注释，按项目"skip commented endings"决定不予实现
    public IEnumerator label_juezhan_menu_1_woaini()
    {
        Defaults.Persistent.Jq_10_6 = 1;
        yield return _gameMethods.ExecuteCharacterImageData("nv2");
        yield return _gameMethods.OpenDialog(6609); // "我爱你，赫泽尔。"
        yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:2f);
        if (Defaults.Bai_xin == 1)
        {
            yield return _gameMethods.Show("tongdaozi_cg_layered", parts: new List<string>{"d_zui3"});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/houhui/Bones Break Cracking_01.ogg");
            yield return _gameMethods.OpenDialog(6610); // "微微抖动枝干，调整角度再次放出魔力。"
            yield return _gameMethods.Show("tongdaozi_cg_layered", parts: new List<string>{"d_zui2", "d_mei1", "d_yan3"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(6611); // "所以，为了我而放过我，好吗？"
            yield return _gameMethods.Show("tongdaozi_cg_layered", parts: new List<string>{"d_zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(1926); // "………"
            yield return _gameMethods.OpenDialog(6612); // "他的瞳孔缩小成针尖状，身形僵住不动。"
            yield return _gameMethods.OpenDialog(33); // "………………"
            yield return _gameMethods.OpenDialog(6613); // "过了良久，才重新有了动静。"
            yield return _gameMethods.PlaySound("sounda1", 1f, 1.0f, "audio/sound/end/roce-de-ropa_01.mp3");
            yield return _gameMethods.Show("tongdaozi_cg_layered", parts: new List<string>{"ditu2", "mei1", "yan1", "zui3", "d_mei0", "d_yan0", "d_zui0"});
            yield return _gameMethods.Transition(time:0.8f);
            yield return _gameMethods.OpenDialog(6614); // "他伸出胳膊，因动作的牵扯..."
            yield return _gameMethods.OpenDialog(6615); // "那双沾上了泥土的手，艰难地抬起，{nw}{w=0.01}"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.5f, "audio/sound/houhui/Grab Hand_01.mp3");
            yield return _gameMethods.OpenDialog(6616); // "竭尽全力一般，搭在了我抓着枝干的手上。"
            yield return _gameMethods.OpenDialog(6617); // "滑腻的触感。略低于人类的体温。"
            yield return _gameMethods.Show("tongdaozi_cg_layered", parts: new List<string>{"ditu3", "he_zui"});
            yield return _gameMethods.Transition(time:0.8f);
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/houhui/Peel Scales 1_01.mp3");
            Defaults.Haogandu_he = Defaults.Haogandu_he + 2;
            if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
            {
                _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
                _gameMethods.SyncAchievement();
            }
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(6618); // "………好。"
            yield return _gameMethods.Show("tongdaozi_cg_layered", parts: new List<string>{"-he_zui"});
            yield return _gameMethods.Transition(time:0.5f);
            yield return _gameMethods.OpenDialog(6619); // "没有挣扎，没有反抗，就这样，他自愿沉睡。"
        }
        yield return _gameMethods.OpenDialog(6620); // "他是如此平静，轻握着我的手，令人想起那些夜晚。"
        yield return _gameMethods.OpenDialog(6621); // "疼痛渐渐消散，安稳地沉入同一个梦乡。"
        yield return _gameMethods.PlaySound("sounda2", 0.0f, 1.0f, "audio/sound/he/ci2.ogg");
        yield return _gameMethods.OpenDialog(6622); // "一年。{nw}{w=1}"
        yield return _gameMethods.OpenDialog(6623); // "两年。{nw}{w=1}"
        yield return _gameMethods.PlaySound("sounda5", 0.5f, 1.0f, "audio/sound/he/ci3.ogg");
        yield return _gameMethods.OpenDialog(6624); // "三年。{nw}{w=1}"
        yield return _gameMethods.OpenDialog(6625); // "……移不开视线。"
        yield return _gameMethods.OpenDialog(6626); // "我的手像被紧紧黏住了一样，和他贴在一起。"
        yield return _gameMethods.OpenDialog(6627); // "眼泪滑过面颊，发出无声的哀戚。"
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<silence 1.7>audio/sound/he/shuai.mp3");
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/juezhan_1_57fe36c1.ogg");
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.ExecuteCharacterImageData("he_pangbai");
        yield return _gameMethods.OpenDialog(6628); // "终于，他再也无法支撑站立..."
        yield return _gameMethods.StopSound(channelName:"music1", fadeOut:5f);
        yield return _gameMethods.OpenDialog(6629); // "我随着他的下坠也缓缓屈膝..."
        yield return _gameMethods.OpenDialog(6630); // "他的身体犹如被抽走了支柱..."
        if (Defaults.Bai_xin == 0)
        {
            yield return _gameMethods.PlaySound("sounda1", 0.0f, 0.6f, "audio/sound/emeng_dajie/Magic Spell Book Pages Flipping_01.ogg");
            // rpy 原版: with Fade(0.2, 0.1, 0.2, color="#fff") — 近似为白屏闪
            yield return _gameMethods.ShowWhite(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveTime", 0.2f}})});
            yield return _gameMethods.HideWhite(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveTime", 0.2f}})});
            yield return _gameMethods.OpenDialog(6631); // "这一刻，通过这根令他自己沉睡的树枝..."
        }
        if (Defaults.Bai_xin == 1)
        {
            yield return _gameMethods.OpenDialog(6632); // "这一刻，我的耳边再次回响起..."
        }
        yield return _gameMethods.Scene("sihuai_ditu_layered", parts: new List<string>{"nv_zui2", "mei2", "zui5", "yan2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.33f, 1.11f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.87f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -100f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 4f}, {"zpos", 0f}})});
        yield return _gameMethods.Show("2-29_zoom");
        yield return _gameMethods.Hide("2-29_zoom");
        yield return _gameMethods.Transition(time:0.7f);
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/houhui/Win Bell 2_01.mp3");
        yield return _gameMethods.PlaySound("soundb", 0.0f, 2f, "audio/sound/manbu/Gentle Breeze Blowing Foliage Rustling_01.ogg");
        yield return _gameMethods.OpenDialog(6633); // "{cps=15}‘不过，你已经掌握住他一个弱点了..."
        yield return _gameMethods.Hide("sihuai_ditu_layered");
        yield return _gameMethods.Show("sihuai_ditu_layered", parts: new List<string>{"nv_zui2", "mei2", "zui5", "yan2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(-18f, -18f)}, {"anchor", new Vector2(0f, 0f)}, {"zoom", 0.53f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -40f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 3f}, {"zpos", 0f}})});
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/manbu/strong_wind2_01.mp3");
        yield return _gameMethods.Transition(time:0.7f);
        yield return _gameMethods.OpenDialog(6634); // "但，现在在他身上的这个弱点..."
        yield return _gameMethods.OpenDialog(6635); // "它已经作为弱点实现了自己的价值。"
        yield return _gameMethods.OpenDialog(6636); // "永远地作为弱点，而非幸福。"
        yield return _gameMethods.Show("sihuai_ditu_layered", parts: new List<string>{"nv_lei"});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.PlaySound("music", 0.0f, 0.4f, "audio/music/end/Peritune_Tender_Gaze.mp3");
        yield return _gameMethods.OpenDialog(6637); // "我感觉眼眶酸涩..."
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}})});
        yield return _gameMethods.Show("sihuai_ditu_layered", parts: new List<string>{"zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("he_qian");
        yield return _gameMethods.OpenDialog(6638); // "「……你在{nw}{w=0.01}"
        yield return _gameMethods.Show("sihuai_ditu_layered", parts: new List<string>{"yan1"});
        yield return _gameMethods.OpenDialog(6639); // "……悲伤？」"
        yield return _gameMethods.Show("sihuai_ditu_layered", parts: new List<string>{"zui5"});
        yield return _gameMethods.OpenDialog(5546); // "是吗？"
        yield return _gameMethods.OpenDialog(6640); // "脸颊痒痒的。是眼泪。"
        yield return _gameMethods.Show("sihuai_ditu_layered", parts: new List<string>{"nv_yan1"});
        yield return _gameMethods.OpenDialog(6641); // "……我后知后觉地意识到..."
        yield return _gameMethods.OpenDialog(6642); // "而我应该不必再在他面前掩藏情绪了。"
        yield return _gameMethods.OpenDialog(6643); // "可以尽情地不甘、埋怨、愤慨。"
        yield return _gameMethods.OpenDialog(6644); // "还有悲伤。"
        yield return _gameMethods.Show("sihuai_ditu_layered", parts: new List<string>{"nv_zui3"});
        yield return _gameMethods.ExecuteCharacterImageData("nv2");
        yield return _gameMethods.OpenDialog(6645); // "……是的。"
        yield return _gameMethods.Show("sihuai_ditu_layered", parts: new List<string>{"nv_zui2", "yan3", "zui4"});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.ExecuteCharacterImageData("he");
        yield return _gameMethods.OpenDialog(6646); // "为什、么……？"
        yield return _gameMethods.OpenDialog(6647); // "得偿所愿，不高兴么…。"
        yield return _gameMethods.Show("sihuai_ditu_layered", parts: new List<string>{"nv_zui0", "zui5"});
        yield return _gameMethods.ExecuteCharacterImageData("nv2");
        yield return _gameMethods.OpenDialog(6648); // "因为我爱你。但我必须活着。"
        yield return _gameMethods.Show("sihuai_ditu_layered", parts: new List<string>{"zui2", "yan1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv2");
        yield return _gameMethods.OpenDialog(6649); // "我爱你，感觉不到吗？"
        yield return _gameMethods.Show("sihuai_ditu_layered", parts: new List<string>{"nv_zui2", "zui1"});
        Defaults.Haogandu_he = Defaults.Haogandu_he + 2;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("he");
        yield return _gameMethods.OpenDialog(6650); // "我不……知道。"
        yield return _gameMethods.Show("sihuai_ditu_layered", parts: new List<string>{"mei1", "yan5"});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.ExecuteCharacterImageData("he");
        yield return _gameMethods.OpenDialog(6651); // "我的权柄里……不包括爱。"
        yield return _gameMethods.Show("sihuai_ditu_layered", parts: new List<string>{"-nv_lei", "nv_zui3", "zui5"});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.ExecuteCharacterImageData("nv2");
        yield return _gameMethods.OpenDialog(6652); // "那么，现在，我告诉你，你得到它了。"
        Defaults.Haogandu_he = Defaults.Haogandu_he + 2;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nv2");
        yield return _gameMethods.OpenDialog(6653); // "虽然，只是一个微不足道的，人类的爱。"
        yield return _gameMethods.Show("sihuai_ditu_layered", parts: new List<string>{"nv_zui2", "zui1", "yan1", "mei2"});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.ExecuteCharacterImageData("he");
        yield return _gameMethods.OpenDialog(6654); // "这是…对我听话的…奖励吗？"
        yield return _gameMethods.Show("sihuai_ditu_layered", parts: new List<string>{"nv_zui3", "zui5"});
        Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nv2");
        yield return _gameMethods.OpenDialog(602); // "……嗯。"
        yield return _gameMethods.Show("sihuai_ditu_layered", parts: new List<string>{"nv_zui2", "mei3", "zui3", "yan2"});
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/juezhan_1_74aadfa9.ogg");
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.ExecuteCharacterImageData("he_pangbai");
        yield return _gameMethods.OpenDialog(6655); // "他淡淡地微笑了一下。"
        yield return _gameMethods.Show("sihuai_ditu_layered", parts: new List<string>{"zui4"});
        if (Defaults.Persistent.Povname == "辛西娅")
        {
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(6656); // "再见……辛西娅。"
        }
        else
        {
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(6657); // "再见……[persistent.povname]。"
        }
        yield return _gameMethods.Show("sihuai_ditu_layered", parts: new List<string>{"nv_zui3", "zui5"});
        yield return _gameMethods.ExecuteCharacterImageData("nv2");
        yield return _gameMethods.OpenDialog(6658); // "再见，赫泽尔。"
        yield return _gameMethods.OpenDialog(6659); // "一直以来谢谢你。睡吧。"
        yield return _gameMethods.Show("sihuai_ditu_layered", parts: new List<string>{"nv_zui2", "nv_yan0", "mei2", "yan6", "zui3"});
        yield return _gameMethods.Transition(time:0.7f);
        yield return _gameMethods.OpenDialog(6660); // "温柔地摸着他的头。眷恋地抱着他。"
        yield return _gameMethods.Show("black", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1f}})});
        yield return _gameMethods.PlaySound("sounda5", 0.0f, 1.0f, "audio/sound/he/ci3.ogg");
        yield return _gameMethods.OpenDialog(6661); // "手中地枝干早已坠到了地上。"
        yield return _gameMethods.OpenDialog(6662); // "龙睡在了我的怀里。"
        _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_8");
        _gameMethods.SyncAchievement();
        yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:3f);
        // 注：原 rpy 使用 `call juezhan_baiX; jump end3` 语义（先跳入 juezhan_baiX 执行其内容，
        // 其 return 后再跳到 end3）。当前 ChangeLabelTo 连续调用是否等价取决于运行时实现，
        // 待 label_juezhan_bai1 实现并联机测试后确认。
        if (Defaults.Bai_xin == 1 && Defaults.Bai_kiss == 1)
        {
            yield return _gameMethods.ChangeLabelTo("label_juezhan_bai1");
            yield return _gameMethods.ChangeLabelTo("label_end3");
        }
        if (Defaults.Bai_xin == 1 && Defaults.Bai_kiss == 0)
        {
            yield return _gameMethods.ChangeLabelTo("label_juezhan_bai2");
            yield return _gameMethods.ChangeLabelTo("label_end3");
        }
        if (Defaults.Bai_xin == 0)
        {
            Defaults.Gui_duihuakuang_you = 1;
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:5f);
            yield return _gameMethods.PlaySound("music2", 3f, 1.0f, "audio/music/end/qicheng.mp3");
            yield return _gameMethods.ChangeLabelTo("label_end3");
        }
    }
}
