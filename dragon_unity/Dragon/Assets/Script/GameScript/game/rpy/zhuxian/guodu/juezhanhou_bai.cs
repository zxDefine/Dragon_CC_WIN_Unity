using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class juezhanhou_bai : ILabelProvider
{
    private GameMethods _gameMethods;

    public juezhanhou_bai(GameMethods gameMethods)
    {
        _gameMethods = gameMethods;
    }

    public IEnumerator label_juezhan_bai2()
    {
        Defaults.Persistent.Jq_10_10 = 1;
        yield return _gameMethods.Scene("caodi2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.06f, 1.3f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 1.04f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
        Defaults.Gui_duihuakuang_you = 1;
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.ExecuteCharacterImageData("nuo_weizhi");
        yield return _gameMethods.OpenDialog(6132); // "唉——居然用不上我出场了吗？"
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/emeng_dajie/magic1.ogg");
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.33f, 2.26f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.47f}})});
        yield return _gameMethods.Transition(time:0.3f);
        yield return _gameMethods.OpenDialog(6133); // "一道叹息般的声音..."
        yield return _gameMethods.OpenDialog(6134); // "是诺伯拉。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo");
        yield return _gameMethods.OpenDialog(6135); // "不过，你的确一直都是这么果敢呢。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan21", "zui15", "d3"});
        yield return _gameMethods.OpenDialog(1926); // "………"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan21", "zui10"});
        yield return _gameMethods.OpenDialog(6136); // "他真的自愿沉睡了？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui13"});
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/juezhan_bai1_2d9a9fdc.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"zui15"});
        yield return _gameMethods.OpenDialog(6137); // "「是呀，体内的魔力流已经减弱了。{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui6"});
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/juezhan_bai1_80c63c93.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6138); // "——他沉睡了。」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui14"});
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/juezhan_bai1_557711f2.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(6139); // "命运大概很快会筛选出下一只灾厄之龙..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui8"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan21", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/juezhan_bai1_2086e57d.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nuo");
        yield return _gameMethods.OpenDialog(6140); // "不过到新的灾厄之龙结束幼年期..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui2"});
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/juezhan_bai1_a424c1a4.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nuo");
        yield return _gameMethods.OpenDialog(6141); // "那就和你无关啦。"
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/juezhan_bai1_4faefac2.ogg");
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo");
        yield return _gameMethods.OpenDialog(6142); // "换句话来说，你自由了。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui14"});
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/juezhan_bai1_faefcc26.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nuo");
        yield return _gameMethods.OpenDialog(6143); // "——恭喜你，小公主！"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei3", "yan12", "zui18"});
        yield return _gameMethods.OpenDialog(1378); // "「……{nw}{w=0.3}"
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan20", "zui15"});
        yield return _gameMethods.OpenDialog(6144); // "………」"
        yield return _gameMethods.OpenDialog(6145); // "我麻木地立在原地。"
        yield return _gameMethods.OpenDialog(6146); // "地上的赫泽尔一动不动..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui8"});
        yield return _gameMethods.OpenDialog(6147); // "直到最后一秒..."
        yield return _gameMethods.OpenDialog(6148); // "像是猫在抓捕前戏弄老鼠的手段。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui8"});
        yield return _gameMethods.OpenDialog(6149); // "或许他会在下一刻站起来..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui12"});
        yield return _gameMethods.OpenDialog(6150); // "可他真的……就这么沉睡了。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui12"});
        yield return _gameMethods.OpenDialog(924); // "……？"
        yield return _gameMethods.OpenDialog(6151); // "…………我不明白。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan21", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0.5 to 1.5>audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui14"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.72f}, {"zpos", 12.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(6152); // "唉——~真是令人惊讶。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(6153); // "诺伯拉开口说道。"
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/juezhan_bai1_ebd1bd64.ogg");
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei6", "yan1", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(6154); // "明明无论在世界的轨道里..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui13"});
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/juezhan_bai1_fd48caa7.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(6155); // "作为柔弱悲惨的公主殿下..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui4"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 12.0f}})});
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/juezhan_bai1_30dd188f.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6156); // "「在以泪洗面中等待勇者的拯救……{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui13"});
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/juezhan_bai1_ec4f201c.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6157); // "明明只是这样可怜无助的小公主。」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan12", "zui10"});
        yield return _gameMethods.OpenDialog(6158); // "「真不巧，我不是公主，{nw}{w=0.01}"
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 2;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan21", "zui10"});
        yield return _gameMethods.OpenDialog(6159); // "而且，最难忍受的就是坐以待毙。」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"zui15"});
        yield return _gameMethods.OpenDialog(6160); // "……嗯，是呀。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(6161); // "我一直都知道。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui17"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6162); // "「像你这样大胆的女孩，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6163); // "一定能做出最出人意料的举动。」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan21", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan20", "zui10"});
        yield return _gameMethods.OpenDialog(6164); // "可是我现在感觉很不好。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan12", "zui10"});
        yield return _gameMethods.OpenDialog(6165); // "伤害别人也是需要付出代价的。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui9"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui5"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"zui15"});
        yield return _gameMethods.OpenDialog(1693); // "为什么？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan8", "zui10"});
        yield return _gameMethods.OpenDialog(6166); // "他好像……真的很在乎我。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui16"});
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/juezhan_bai1_a1639910.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei8", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(6167); // "是啊，自世界诞生以来..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan17", "zui10"});
        yield return _gameMethods.OpenDialog(6168); // "你觉得，他真的重视我吗？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei8", "yan17", "zui15"});
        yield return _gameMethods.OpenDialog(1378); // "「……{nw}{w=0.3}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/juezhan_bai1_dc403f53.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6169); // "你很想知道答案吗？」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan8", "zui10"});
        yield return _gameMethods.OpenDialog(6170); // "我不知道。"
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"zui15"});
        yield return _gameMethods.OpenDialog(6171); // "如果，他真的很在乎我..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan4", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan10", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan20", "zui15"});
        yield return _gameMethods.OpenDialog(6172); // "但，无论如何..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan21", "zui15"});
        yield return _gameMethods.OpenDialog(6173); // "\n回到当时，我也不会改变我做出的决定。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan12", "zui10"});
        yield return _gameMethods.OpenDialog(6174); // "算了。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(6175); // "既然已经动手，又何必惺惺作态。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan9", "zui15"});
        yield return _gameMethods.OpenDialog(6176); // "他要成长，我要活着。就这么简单。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui5"});
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/juezhan_bai1_c4510173.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(6177); // "……嗯。你在同情他？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6178); // "「呵呵……{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei6", "yan11", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6179); // "人类都这么富有道德感和责任心吗..."
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:5f);
        yield return _gameMethods.StopSound(channelName:"music1", fadeOut:5f);
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei6", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan21", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui13"});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"ypos", -60f}, {"zpos", -180f}})});
        yield return _gameMethods.PlaySound("music2", 3f, 0.5f, "audio/music/end/qicheng.mp3");
        yield return _gameMethods.TransitionBy("blink2");
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/juezhan_bai1_11ebb5f7.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nuo");
        yield return _gameMethods.OpenDialog(6180); // "哎呀，放宽心。"
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/juezhan_bai1_4a722aa4.ogg");
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo");
        yield return _gameMethods.OpenDialog(6181); // "相信么，你赋予他的好处..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui16"});
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/juezhan_bai1_37135fc7.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nuo");
        yield return _gameMethods.OpenDialog(6182); // "让我来告诉你一个道理吧。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui14"});
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/houhui/Win Bell 2_01.mp3");
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/juezhan_bai1_ed8db6fa.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nuo");
        yield return _gameMethods.OpenDialog(6183); // "——爱比被爱更快乐。"
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/juezhan_bai1_da9f631c.ogg");
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo");
        yield return _gameMethods.OpenDialog(6184); // "更何况，你特意花费时间心思欺骗他..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/juezhan_bai1_9bdd2e18.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nuo_qian");
        yield return _gameMethods.OpenDialog(6185); // "「他体验享受了被骗的过程..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui17"});
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/juezhan_bai1_580e4ebd.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nuo_qian");
        yield return _gameMethods.OpenDialog(6186); // "合情合理呀。」"
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/juezhan_bai1_3e82bf7c.ogg");
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo");
        yield return _gameMethods.OpenDialog(6187); // "你怎么不也来骗骗我呢？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.OpenDialog(6188); // "那么，他为这份服务付出的报酬，可真大啊。"
        yield return _gameMethods.OpenDialog(6189); // "我自嘲地笑了笑。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan8", "zui3"});
        yield return _gameMethods.OpenDialog(6190); // "说的容易，我骗得过你吗。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"zui15"});
        yield return _gameMethods.OpenDialog(6191); // "你不是已经骗到了嘛？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(6192); // "有吗。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei4", "yan7", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui5"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(6193); // "接下来，你打算怎么办？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan8", "zui10"});
        yield return _gameMethods.OpenDialog(6194); // "回家。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"zui15"});
        yield return _gameMethods.OpenDialog(3949); // "然后呢？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan8", "zui10"});
        yield return _gameMethods.OpenDialog(6195); // "「发展面包坊..."
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan12", "zui10"});
        yield return _gameMethods.OpenDialog(6196); // "或许吧，我不知道。」"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"zui15"});
        yield return _gameMethods.OpenDialog(6197); // "我还要解决安德鲁的问题。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui5"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_qian");
        yield return _gameMethods.OpenDialog(6198); // "「真过分啊，{nw}{w=0.01}"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0.5 to 1.5>audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
        yield return _gameMethods.Show("nuo1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 12.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.50f}, {"zpos", 30.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_qian");
        yield return _gameMethods.OpenDialog(6199); // "那我呢？」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo");
        yield return _gameMethods.OpenDialog(6200); // "不用对我负责么。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui12"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 30.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan5", "zui10", "emoji12"});
        yield return _gameMethods.OpenDialog(6201); // "……啊？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(6202); // "你不应该回到原本的泥潭中..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6203); // "「继续活跃在这个舞台上吧，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6204); // "让我注视你——{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6205); // "你应该是那种从一而终的人吧？」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan10", "zui3", "emoji2", "-emoji12"});
        yield return _gameMethods.OpenDialog(6206); // "……我们能不随意揣测吗。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan12", "zui10", "-emoji2"});
        yield return _gameMethods.OpenDialog(6207); // "你可以想办法说服我，谈判家。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui8"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"zui14"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/juezhan_bai1_b5fc4cfb.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6208); // "「这个世界上还有着很多有趣的东西哦..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui13"});
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/juezhan_bai1_d7e6fd09.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6209); // "比如说镜面湖心，精灵世界树..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui14"});
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/juezhan_bai1_85848762.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6210); // "再比如说——{nw}{w=0.01}"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1f, "audio/sound/manbu/Body1_02_duan.mp3");
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui16"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 30.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.42f}, {"zpos", 36.0f}})});
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/juezhan_bai1_5b31fdd4.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6211); // "妖精乐园。」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei3", "yan22", "zui3"});
        yield return _gameMethods.OpenDialog(6212); // "「你真是洞察人心，诺伯拉先生，"
        yield return _gameMethods.Show("nuo1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 36.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(6213); // "\n你知道该怎么拿回在那里失去的东西么。」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui14"});
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/juezhan_bai1_2fc7bb4f.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"zui15"});
        yield return _gameMethods.OpenDialog(6214); // "这可不容易。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/juezhan_bai1_58507e59.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(6215); // "得找到和他做交易的那个妖精..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan12", "zui10"});
        yield return _gameMethods.OpenDialog(6216); // "这样啊，真难办。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan5", "zui3"});
        yield return _gameMethods.OpenDialog(6217); // "不过你会给我一点小提示的，对吗？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui1"});
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/juezhan_bai1_6557f87e.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"zui6"});
        yield return _gameMethods.OpenDialog(6218); // "乐意为您效劳，公主殿下。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan10", "zui3"});
        yield return _gameMethods.OpenDialog(6219); // "怎么还叫我公主啊。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui14"});
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/juezhan_bai1_f4393340.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nuo");
        yield return _gameMethods.OpenDialog(6220); // "你是冰霜之龙的公主。"
    }
}
