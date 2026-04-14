using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bai_menu : ILabelProvider
{
    private GameMethods _gameMethods;

    public bai_menu(GameMethods gameMethods)
    {
        _gameMethods = gameMethods;
    }

    // "-你怎么知道我不憎恨他？" 分支 (rpy L599)
    public IEnumerator label_bai_menu_0_u_NfL9wY()
    {
        yield return _gameMethods.PlaySound("music", 4.0f, 0.9f, "audio/music/Alphard.mp3");
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan8", "zui19"});
        yield return _gameMethods.OpenDialog(8832); // "你怎么知道我不憎恨他？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan8", "zui7"});
        yield return _gameMethods.OpenDialog(3620); // "是吗。"
        yield return _gameMethods.OpenDialog(8833); // "那你的憎恨，还真是温柔啊。"
        yield return _gameMethods.ChangeLabelTo("label_zhuxian5_choice3");
    }

    // "-没有人可以做我的主人" 分支 (rpy L606)
    public IEnumerator label_bai_menu_0_ED8d6tJV()
    {
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 2;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.PlaySound("music", 4.0f, 0.9f, "audio/music/Alphard.mp3");
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan2", "zui10"});
        yield return _gameMethods.OpenDialog(8835); // "没有人可以做我的主人。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan4", "zui5"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(8836); // "一颗不能被征服的心。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui1"});
        yield return _gameMethods.OpenDialog(8837); // "——嗯，这的确很有诱惑力。"
        yield return _gameMethods.ChangeLabelTo("label_zhuxian5_choice3");
    }

    // "-有点动容" 分支 (rpy L1662)
    public IEnumerator label_bai_menu_1_jxWk_Ed3()
    {
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan5", "zui14"});
        yield return _gameMethods.OpenDialog(9239); // "不管他说的是真是假，至少都表达了对我、以及我所拥..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui9"});
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 3;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan6", "zui14"});
        yield return _gameMethods.OpenDialog(9240); // "这种表态已经足够令我为他的好意而道谢了。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan12", "zui20"});
        yield return _gameMethods.OpenDialog(9241); // "谢谢你。我就当是真的好了。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui3"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian", parts: new List<string>{"mei7", "yan2", "zui7"});
        yield return _gameMethods.OpenDialog(9242); // "「“就当”？我就这么没信用呀~」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(3621); // "是啊。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(9243); // "所以，这已经是我在努力以最大程度的信赖，去相信你..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(9244); // "那真是多谢。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(3829); // "不客气。"
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Hide("nuo_heart_layered");
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.EngineSetVolume(volume:0.3f, delay:0.5f, channelName:"music2");
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.EngineSetVolume(volume:1.0f, delay:0.5f, channelName:"music2");
        yield return _gameMethods.ChangeLabelTo("label_he_yangtuzi");
    }

    // "-有点恶寒" 分支 (rpy L1699)
    public IEnumerator label_bai_menu_1_WF3pzbUX()
    {
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui8"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan12", "zui18", "emoji2", "emoji13", "emoji16"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
        yield return _gameMethods.OpenDialog(9246); // "好恶寒。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan24", "zui16"});
        yield return _gameMethods.OpenDialog(9247); // "就像看到犯错的人在诉说自己的心路历程一样。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui3"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian", parts: new List<string>{"mei7", "yan24", "zui16", "-emoji16"});
        yield return _gameMethods.OpenDialog(9248); // "「啊，不相信我呀？{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan5", "zui15", "-emoji13", "-emoji2"});
        yield return _gameMethods.OpenDialog(9249); // "真伤心。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan11", "zui19", "emoji2"});
        yield return _gameMethods.OpenDialog(6119); // "哈哈、哈哈……"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.OpenDialog(9250); // "我礼貌地笑了笑。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan8", "zui6", "-emoji2"});
        yield return _gameMethods.OpenDialog(9251); // "从我们见的第一面算起，满打满算也就一年多。\n谁..."
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Hide("nuo_heart_layered");
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.EngineSetVolume(volume:0.3f, delay:0.5f, channelName:"music2");
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.EngineSetVolume(volume:1.0f, delay:0.5f, channelName:"music2");
        yield return _gameMethods.ChangeLabelTo("label_he_yangtuzi");
    }

    // "-那就变深吧" 分支 (rpy L2778)
    public IEnumerator label_bai_menu_2_kz6j28WA()
    {
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 2;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_wu", parts: new List<string>{"mei3", "yan24", "zui16", "-emoji2"});
        yield return _gameMethods.OpenDialog(9577); // "（那就变深吧……和你的羁绊，总比和头痛的羁绊要强..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui2"});
        yield return _gameMethods.OpenDialog(9578); // "真高兴，我在你的心中这么有地位。"
        yield return _gameMethods.ChangeLabelTo("label_bai_1");
    }

    // "-那就算了吧" 分支 (rpy L2789)
    public IEnumerator label_bai_menu_2_h2t5SbbU()
    {
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_wu", parts: new List<string>{"mei3", "yan24", "zui15"});
        yield return _gameMethods.OpenDialog(9580); // "（那算了。）"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei3", "yan24", "zui15"});
        yield return _gameMethods.OpenDialog(9581); // "谨记，不能随意做交易。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei6", "yan7", "zui5"});
        yield return _gameMethods.OpenDialog(9582); // "真冷酷。"
        if (Defaults.Haogandu_nuo < 95)
        {
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei4", "yan13", "zui16"});
            yield return _gameMethods.StopSound(channelName:"music1", fadeOut:4.0f);
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(9583); // "不过，我毕竟也不忍心强迫一名虚弱的女士。"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui16"});
            yield return _gameMethods.OpenDialog(9584); // "等你回心转意，可以再叫我。"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
            yield return _gameMethods.OpenDialog(9585); // "他的语调变得意兴阑珊，又说了两句，便不再发出声响..."
            yield return _gameMethods.Hide("nuo_heart_layered");
            yield return _gameMethods.Transition(time:0.6f);
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(4); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(9586); // "我忍耐着疼痛的煎熬。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15"});
            yield return _gameMethods.OpenDialog(9587); // "这没什么。从第一次偏头痛开始，每一次我都是这么忍..."
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan20", "zui15"});
            yield return _gameMethods.OpenDialog(9588); // "只要挺过半小时，之后就会好受很多。"
            yield return _gameMethods.OpenDialog(9589); // "不知不觉间，我睡了过去。"
            yield return _gameMethods.OpenDialog(4); // "……"
            yield return _gameMethods.ChangeLabelTo("label_shenglitong_gong");
        }
        else
        {
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui4"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
            yield return _gameMethods.OpenDialog(9590); // "「可是，{nw}{w=0.01}"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui2"});
            yield return _gameMethods.OpenDialog(9591); // "我不想算了呢。」"
            yield return _gameMethods.ChangeLabelTo("label_bai_1");
        }
    }

    // "-信赖而松弛" 分支 (rpy L2854)
    public IEnumerator label_bai_menu_3_2w1Cqot7()
    {
        Defaults.Bai_xinlai = 1;
        yield return _gameMethods.OpenDialog(9601); // "我感觉有些安心。"
        yield return _gameMethods.OpenDialog(9602); // "不管怎么说，诺伯拉姑且算是我的盟友，也一直对我释..."
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.OpenDialog(9603); // "至少在现在这一刻，他是值得信任的。让我不必一个人..."
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.OpenDialog(9604); // "我似乎没能回答他的问题，但诺伯拉却并未继续追问。"
        yield return _gameMethods.PlaySound("music4", 0.0f, 1.0f, "audio/music/gentle1.mp3");
        yield return _gameMethods.Show("bai_shengliqi_ditu1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"xpos", 0.5f}, {"zoom", 0.52f}})});
        yield return _gameMethods.Transition(time:0.7f);
        yield return _gameMethods.OpenDialog(9605); // "逐渐的，我感觉浑身都沉浸在一种很熨帖的温暖之中，..."
        yield return _gameMethods.PlaySound("soundb", 1.0f, 1.0f, "audio/sound/bilu.ogg");
        yield return _gameMethods.Show("black");
        yield return _gameMethods.Transition(time:0.6f);
        yield return _gameMethods.OpenDialog(9606); // "全身暖融融的，宛如冬天窝在温暖的小木屋里烤火一样..."
        yield return _gameMethods.Hide("nuo_heart_layered");
        yield return _gameMethods.OpenDialog(9607); // "恍惚间，我仿佛回到了幼年贴在妈妈身边的被窝里。"
        yield return _gameMethods.Show("memory4_6", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"matrixcolor", "InvertMatrix(0.0)*ContrastMatrix(1.0)*SaturationMatrix(1.08)*BrightnessMatrix(-0.22)*HueMatrix(0.0)"}, {"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 0.9f}})});
        Defaults.Gui_duihuakuang_you = 0;
        yield return _gameMethods.OpenDialog(9608); // "好温暖。"
        yield return _gameMethods.Show("memory4_6", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.9f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv2_qian");
        yield return _gameMethods.OpenDialog(9609); // "（妈妈，我想你了。）"
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 2;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.OpenDialog(9610); // "困意惺忪、意识昏沉间，一丝酸涩闪过鼻腔。"
        yield return _gameMethods.OpenDialog(9611); // "……睡吧，努力过头的公主殿下。"
        yield return _gameMethods.OpenDialog(9612); // "有谁轻声说。"
        yield return _gameMethods.OpenDialog(9613); // "做个美梦。"
        yield return _gameMethods.SceneBlack();
        Defaults.Gui_duihuakuang_you = 1;
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(9614); // "……我陷入了梦乡。"
        yield return _gameMethods.StopSound(channelName:"music4", fadeOut:4.0f);
        yield return _gameMethods.ChangeLabelTo("label_shenglitong_gong");
    }

}
