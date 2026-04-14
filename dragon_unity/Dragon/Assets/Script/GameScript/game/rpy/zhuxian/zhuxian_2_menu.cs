
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class zhuxian_2_menu : ILabelProvider
{
    private GameMethods _gameMethods;

    public zhuxian_2_menu(GameMethods gameMethods)
    {
        _gameMethods = gameMethods;
    }

    public IEnumerator label_zhuxian_2_menu_0_7NleJsc6()
    {
        Defaults.Bai_xiu = 1;
        Defaults.Bai_xin = 0;
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:3f);
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui8"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15", "-emoji2", "-emoji12"});
        yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan2", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(2054); // "{nw}{w=0.3}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei4", "yan2", "zui18", "emoji2", "emoji14"});
        yield return _gameMethods.OpenDialog(2055); // "……？！"
        yield return _gameMethods.PlaySound("music1", 0.0f, 1.0f, "audio/demo_audio/music/time_syuanji.mp3");
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei4", "yan5", "zui13", "emoji2", "emoji14"});
        yield return _gameMethods.OpenDialog(2056); // "……你、你说什么啊！这怎么行！？"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}})});
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.5>audio/sound/jiaobusheng_xin_normal1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -80f}, {"zpos", -516.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.21f}, {"ypos", -75f}, {"zpos", -490.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1");
        yield return _gameMethods.OpenDialog(2057); // "我们才第一次见吧！"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -75f}, {"zpos", -490.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan2", "zui18", "emoji2", "emoji14"});
        yield return _gameMethods.OpenDialog(2058); // "我大为震撼，后退半步、不假思索地反驳。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui3"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(2059); // "哈哈，脸红了呢，真可爱~"
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo - 2;
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(2060); // "算了，开个玩笑。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(2061); // "他举起双手。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei3", "yan2", "zui18", "emoji2", "-emoji14"});
        yield return _gameMethods.OpenDialog(2062); // "我可不好向尼德霍格的东西出手。"
        yield return _gameMethods.StopSound(channelName:"music1", fadeOut:3f);
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/door_open_3.mp3");
        yield return _gameMethods.PlaySound("sound", 0.0f, 2f, "<silence 0.7><from 0 to 2>audio/demo_audio/sound/zu3_nv_zou.ogg");
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(2063); // "这时，会客厅的门忽然被打开。"
        yield return _gameMethods.ChangeLabelTo("label_choice9");
    }

    public IEnumerator label_zhuxian_2_menu_0_J4c1Ux9W()
    {
        yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/demo_audio/music/time_syuanji.mp3");
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan6", "zui15"});
        yield return _gameMethods.OpenDialog(2064); // "也不是不行。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -516.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.32f}, {"zpos", -528.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan2", "zui10", "-emoji12"});
        yield return _gameMethods.OpenDialog(2065); // "就是你不觉得是我比较占便宜吗。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -528.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(2066); // "又能得到情报，又能看到帅哥。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei9", "yan13", "zui12"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(2067); // "嗯——想想也是。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei9", "yan2", "zui8"});
        Engine._history = false;
        yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui3"});
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_demo_4e95bccf.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nuo");
        yield return _gameMethods.OpenDialog(2068); // "那还是先算了。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan10", "zui7"});
        yield return _gameMethods.OpenDialog(2069); // "好随便的男人。"
        yield return _gameMethods.ChangeLabelTo("label_choice9_1");
    }

    public IEnumerator label_zhuxian_2_menu_0_WsM59agt()
    {
        yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/demo_audio/music/time_syuanji.mp3");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan2", "zui15", "emoji2", "-emoji12"});
        yield return _gameMethods.OpenDialog(2070); // "只要求一下吗。"
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan4", "zui12"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(2071); // "要不你多提几个条件，不然这情报我拿得不踏实。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei11", "yan2", "zui15"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei11", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(2072); // "倒不是因为我是个社交经验多么丰富..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(2073); // "主要是事关未来..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"me3", "yan8", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(2074); // "虽然不算有多乐意..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(2075); // "只是……我更在乎它的后果..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan17", "zui15"});
        yield return _gameMethods.OpenDialog(2076); // "事情一旦做了..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(2077); // "假设诺伯拉是个社交达人..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(2078); // "一个对我丧失兴趣..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan14", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(2079); // "……所以，这次还是按兵不动吧。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(2080); // "我的筹码很少..."
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -516.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.5f}, {"zpos", -540.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(2081); // "这是可以轻易换来的情报吗..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -540.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(2082); // "不过，还是算了。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui2"});
        yield return _gameMethods.OpenDialog(2083); // "「我觉得占你便宜不好，"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan4", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan9", "zui19"});
        yield return _gameMethods.OpenDialog(2084); // "你和赫泽尔…{nw}{w=0.3}"
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei3", "yan12", "zui7"});
        yield return _gameMethods.OpenDialog(2085); // "嗯，兄弟情深，{nw}{w=0.3}"
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(2086); // "要学会爱惜、保护自己和同胞。」"
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.OpenDialog(2087); // "话说这龙应该至少几百上千岁了吧..."
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui9"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan4", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(1860); // "……"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei9", "yan2", "zui3"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(2088); // "「哈哈哈哈哈……！{nw}{w=0.15}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(2089); // "好呀。」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(2090); // "哎呀，真是越来越喜欢你了。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(2091); // "你一定要让我感兴趣得久一点，小公主。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan10", "zui7", "emoji2"});
        yield return _gameMethods.OpenDialog(2092); // "好随意的说话方式..."
        yield return _gameMethods.ChangeLabelTo("label_choice9_1");
    }

    public IEnumerator label_zhuxian_2_menu_0_qbHAuybv()
    {
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(2095); // "不知道如果他知晓我已经给赫泽尔梳过头了..."
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:1f);
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan3", "zui9"});
        yield return _gameMethods.PlaySound("sound", 0.0f, 3f, "audio/sound/pencha1.mp3");
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(2096); // "…"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei2", "yan2", "zui12"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"xoffset", -3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0f}})});
        yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
        yield return _gameMethods.PlaySound("music1", 0.0f, 0.8f, "audio/demo_audio/music/PerituneMaterial_NoWay3_loop.mp3");
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei2", "yan2", "zui6"});
        yield return _gameMethods.OpenDialog(2097); // "噗！咳咳——、"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -540.0f}, {"ypos", -70f}})});
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei2", "yan4", "zui10", "emoji1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.15f)}, {"zoom", 0.19f}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 50f}, {"xoffset", 0f}, {"yoffset", 0f}})});
        yield return _gameMethods.TransitionBy("blink2");
        yield return _gameMethods.OpenDialog(2098); // "他毫无征兆地被猛烈呛了一下..."
        yield return _gameMethods.OpenDialog(2099); // "难得地瞪大了眼睛..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei2", "yan4", "zui13", "emoji1"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo");
        yield return _gameMethods.OpenDialog(2100); // "你们——………"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei2", "yan4", "zui7", "emoji1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan12", "zui10"});
        yield return _gameMethods.OpenDialog(2101); // "……我们什么都没有做。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/moca1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan10", "zui2", "emoji2"});
        yield return _gameMethods.OpenDialog(2102); // "也只是梳个头而已吧！"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei6", "yan1", "zui5", "emoji1"});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan10", "zui7", "emoji2"});
        yield return _gameMethods.OpenDialog(2103); // "哈……"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei6", "yan1", "zui12", "emoji1"});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -70f}, {"zpos", -540.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.4f}, {"ypos", -77f}, {"zpos", -554.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui10", "-emoji2"});
        yield return _gameMethods.OpenDialog(2104); // "果然，你应该有能感知别人心理活动的能力呢。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui12", "-emoji1"});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -77f}, {"zpos", -554.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan10", "zui10"});
        yield return _gameMethods.OpenDialog(2105); // "之前就觉得反应有点不对劲..."
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan22", "zui10"});
        yield return _gameMethods.OpenDialog(2106); // "你真的是冰霜与极地之龙吗？"
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 2;
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan22", "zui15"});
        yield return _gameMethods.OpenDialog(2107); // "啊，被拆穿了。你果然很聪明~"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(2108); // "更正一下，我是冰霜与心灵之龙。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(2109); // "心灵之龙、难道……"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(2110); // "没错，我能听到智慧生物的心声。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan22", "zui8", "emoji2"});
        yield return _gameMethods.OpenDialog(2111); // "{size=+10}有点不妙。{/size}这和叫别人放弃隐私有什么区别。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(2112); // "所以我是为了你的心情考虑..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan11", "zui2", "emoji2"});
        yield return _gameMethods.OpenDialog(2113); // "那真是多谢您的贴心，先生。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei3", "yan11", "zui7", "emoji2"});
        yield return _gameMethods.OpenDialog(2114); // "举手之劳，小姐。"
        yield return _gameMethods.StopSound(channelName:"music1", fadeOut:2f);
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/door_open_3.mp3");
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(2063); // "这时，会客厅的门忽然被打开。"
        yield return _gameMethods.ChangeLabelTo("label_choice9");
    }

    public IEnumerator label_zhuxian_2_menu_0_d83B0eum()
    {
        yield return _gameMethods.ChangeLabelTo("label_choice13");
    }

    public IEnumerator label_zhuxian_2_menu_0_1RxNDrMG()
    {
        yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"nv_yan2", "nv_zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv2");
        yield return _gameMethods.OpenDialog(2262); // "至少这可以让你感受到我深厚的情谊。"
        yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"he_yan9", "nv_zui3", "nv_mei1"});
        yield return _gameMethods.ExecuteCharacterImageData("he");
        yield return _gameMethods.OpenDialog(1860); // "……"
        yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"nv_zui4", "nv_yan1"});
        Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
        yield return _gameMethods.ExecuteCharacterImageData("nv2");
        yield return _gameMethods.OpenDialog(2263); // "据说爱能止痛。有没有感觉好点了？"
        yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"nv_zui3"});
        yield return _gameMethods.OpenDialog(2264); // "我关切地问。"
        if (Defaults.Haogandu_he < 50)
        {
            yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"he_zui6"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice12_60b3596d.ogg");
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(2265); // "没有。"
        }
        else
        {
            yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"he_zui6"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice12_0bf9813a.ogg");
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(2266); // "……或许吧。"
        }
        yield return _gameMethods.ChangeLabelTo("label_choice13");
    }

    public IEnumerator label_zhuxian_2_menu_0_674EM6c8()
    {
        yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"nv_mei1", "nv_yan1", "nv_zui4"});
        Defaults.Haogandu_he = Defaults.Haogandu_he + 2;
        yield return _gameMethods.ExecuteCharacterImageData("nv2");
        yield return _gameMethods.OpenDialog(2267); // "但这样，你就不是自己一个人痛苦了呀，有我陪着你。"
        yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"he_yan5"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("he_qian");
        yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"he_yan4", "nv_zui3"});
        yield return _gameMethods.ExecuteCharacterImageData("he");
        yield return _gameMethods.OpenDialog(1860); // "……"
        yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"he_yan5"});
        yield return _gameMethods.ExecuteCharacterImageData("he");
        yield return _gameMethods.OpenDialog(2094); // "嗯。"
        yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"he_yan7"});
        yield return _gameMethods.OpenDialog(2268); // "他低垂着眼睑，轻轻点了点头。"
        yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"-emoji1"});
        yield return _gameMethods.OpenDialog(2269); // "并没露出有真的打算伸手掐我的意思..."
        yield return _gameMethods.ChangeLabelTo("label_choice13");
    }

    public IEnumerator label_zhuxian_2_menu_0_kgO1KOyt()
    {
        yield return _gameMethods.OpenDialog(2284); // "受到那双血瞳的威慑..."
        yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"he_zui3"});
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/manbu/Body1_01.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -90.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"zpos", -120.0f}})});
        yield return _gameMethods.OpenDialog(2285); // "他盯着我..."
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -120.0f}})});
        yield return _gameMethods.OpenDialog(2286); // "过近的距离导致双瞳无法对焦..."
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -120.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"zpos", -150.0f}})});
        yield return _gameMethods.OpenDialog(2287); // "\n喷嚏，就要忍……"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/moca6_duan_duan.mp3");
        yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:2f);
        yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"he_yan5", "nv_mei3", "nv_yan6", "nv_zui1", "gaoguang_bi"});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.20f}, {"ypos", 66f}, {"zpos", 168.0f}})});
        yield return _gameMethods.OpenDialog(2288); // "受不了了！我猛地后仰。"
        yield return _gameMethods.PlaySound("music", 2f, 1.0f, "audio/demo_audio/music/richang1.mp3");
        yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"he_zui5", "nv_zui2"});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 18f}, {"ypos", 66f}, {"zpos", 168.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.20f}, {"xpos", -306f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv2");
        yield return _gameMethods.OpenDialog(2289); // "赶紧睡吧！！！"
        yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"nv_zui3"});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", -306f}})});
        yield return _gameMethods.OpenDialog(2290); // "太可怕了..."
        yield return _gameMethods.OpenDialog(2291); // "这条龙真的毫无常识..."
        yield return _gameMethods.ChangeLabelTo("label_choice14");
    }

    public IEnumerator label_zhuxian_2_menu_0_Ra6CWrbb()
    {
        yield return _gameMethods.PlaySound("music", 2f, 1.0f, "audio/demo_audio/music/richang1.mp3");
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.5f, "audio/demo_audio/sound/moca3.mp3");
        yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:2f);
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -90.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.5f}, {"zpos", 78.0f}})});
        yield return _gameMethods.OpenDialog(2292); // "我不动声色地缓缓向后拉开距离。"
        yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"he_yan5"});
        yield return _gameMethods.OpenDialog(2293); // "好不容易转移了话题。"
        yield return _gameMethods.OpenDialog(2294); // "感觉心累的减寿了十年…………"
        yield return _gameMethods.ChangeLabelTo("label_choice14");
    }

    public IEnumerator label_zhuxian_2_menu_0_SEwBwSFp()
    {
        yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:2f);
        yield return _gameMethods.Scene("sleep_yongbao", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.07f, 1.83f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 1.05f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}, {"zpos", -258.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 2f}, {"ypos", 0f}, {"zpos", 0.0f}})});
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/manbu/Body1_01.mp3");
        yield return _gameMethods.Transition(time:0.2f);
        yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/music/Alphard.mp3");
        Defaults.Haogandu_he = Defaults.Haogandu_he + 3;
        yield return _gameMethods.OpenDialog(2295); // "我决定反客为主..."
        yield return _gameMethods.OpenDialog(2296); // "他瞬间停住了行动。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}, {"zpos", 0.0f}})});
        yield return _gameMethods.OpenDialog(2297); // "似乎有些僵硬住了般..."
        yield return _gameMethods.OpenDialog(2298); // "……一点怪异感浮上我的心头。"
        yield return _gameMethods.OpenDialog(2299); // "这条龙在我心中一直是力量的代言词..."
        yield return _gameMethods.OpenDialog(2300); // "从见到他的那天起..."
        yield return _gameMethods.OpenDialog(2301); // "但此时..."
        yield return _gameMethods.OpenDialog(2302); // "可以被我揽在怀中。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/tangxia3_duanduan.mp3");
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<silence 0.5>audio/sound/houhui/Grab Hand_01.mp3");
        Defaults.Haogandu_he = Defaults.Haogandu_he + 2;
        yield return _gameMethods.OpenDialog(2303); // "我一只手环着赫泽尔的后背..."
        yield return _gameMethods.OpenDialog(2304); // "手感不错。"
        yield return _gameMethods.OpenDialog(2305); // "他没有拒绝..."
        yield return _gameMethods.ExecuteCharacterImageData("he");
        yield return _gameMethods.OpenDialog(2306); // "……我好像……没有那么疼了。"
        yield return _gameMethods.OpenDialog(2307); // "有些闷闷的声音从怀里传来。"
        yield return _gameMethods.ExecuteCharacterImageData("nv2");
        yield return _gameMethods.OpenDialog(2094); // "嗯。"
        yield return _gameMethods.OpenDialog(2308); // "我温柔地轻声回答。"
        yield return _gameMethods.ChangeLabelTo("label_choice14");
    }

    public IEnumerator label_zhuxian_2_menu_0_u2XU8tcr()
    {
        yield return _gameMethods.ChangeLabelTo("label_zhuxian_2_1");
    }

}