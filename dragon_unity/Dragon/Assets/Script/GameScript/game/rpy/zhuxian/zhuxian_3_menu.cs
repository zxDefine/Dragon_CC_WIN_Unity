
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class zhuxian_3_menu : ILabelProvider
{
    private GameMethods _gameMethods;

    public zhuxian_3_menu(GameMethods gameMethods)
    {
        _gameMethods = gameMethods;
    }
    
    public IEnumerator label_zhuxian_3_menu_0_2geSYaMv()
    {
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
                Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 3;
                yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan3", "zui19", "emoji12", "-emoji6"});
                yield return _gameMethods.OpenDialog(2733); // "啊？好像确实也没错。"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan3", "zui2", "-emoji11", "-emoji12"});
                yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan4", "zui9"});
                Engine._history = false;
                yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan3", "zui7", "emoji2", "-emoji12"});
                yield return _gameMethods.OpenDialog(2734); // "{nw}{w=0.18}"
                Engine._history = true;
                yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei8", "yan2", "zui8"});
                yield return _gameMethods.ExecuteCharacterImageData("he_nv");
                yield return _gameMethods.OpenDialog(2688); // "……"
                yield return _gameMethods.PlaySound("sound", 0.0f, 1.5f, "<from 0 to 1.5>audio/demo_audio/sound/zu3_nv_zou_man.ogg");
                yield return _gameMethods.Show("he", parts: new List<string>{"mei9", "yan18", "zui9", "emoji12"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"ypos", 204f}, {"matrixanchor", new Vector2(0.5f, 0.5f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 192f}, {"zpos", 90.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"xpos", 222f}, {"zpos", 132.0f}})});
                yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan3", "zui7", "-emoji2"});
                yield return _gameMethods.OpenDialog(2735); // "这里恐怕不欢迎你。"
                yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei8", "yan11", "zui8"});
                yield return _gameMethods.Show("he", parts: new List<string>{"mei9", "yan18", "zui2", "emoji11"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(222f, 204f)}, {"zpos", 132.0f}})});
                yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
                yield return _gameMethods.OpenDialog(2700); // "…………"
                yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan14", "zui8"});
                yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
                yield return _gameMethods.OpenDialog(2736); // "「……{nw}{w=0.1}"
                yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
                yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
                yield return _gameMethods.OpenDialog(2737); // "嗯——不如我们做个交易吧，尼德霍格。」"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei9", "yan31", "zui2", "-emoji11"});
                yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui13"});
                yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/ding1.mp3");
                yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei7", "yan5", "zui15"});
                yield return _gameMethods.OpenDialog(2738); // "「我把王国的另一个公主抓过来，{nw}{w=0.1}"
                yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui3"});
                yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
                yield return _gameMethods.OpenDialog(2739); // "我们交换怎么样。」"
                yield return _gameMethods.ChangeLabelTo("label_choice15");

    }

    public IEnumerator label_zhuxian_3_menu_0_QNNRTPAa()
    {
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
                yield return _gameMethods.StopSound(channelName:"music", fadeOut:2f);
                yield return _gameMethods.PlaySound("music1", 0.0f, 0.7f, "audio/demo_audio/music/qingkuai2.mp3");
                yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei5", "yan12", "zui13", "emoji2"});
                yield return _gameMethods.OpenDialog(2740); // "「不，{nw}{w=0.1}"
                yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei5", "yan2", "zui13", "emoji2", "-emoji6"});
                yield return _gameMethods.OpenDialog(2741); // "我们家赫泽尔就是最厉害的！」"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan3", "zui2", "-emoji11", "-emoji12"});
                yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan4", "zui9"});
                yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei3", "yan9", "zui19", "-emoji2"});
                yield return _gameMethods.OpenDialog(2742); // "「别说盛开了，{nw}{w=0.1}"
                Defaults.Haogandu_he = Defaults.Haogandu_he + 4;
                yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei5", "yan5", "zui2", "emoji7", "emoji9"});
                yield return _gameMethods.OpenDialog(2743); // "只要他禁止，连花苗都别想长出来。」"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan25", "zui2"});
                Engine._history = false;
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
                yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
                Engine._history = true;
                yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan3", "zui2"});
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan5", "zui16", "emoji2", "emoji7", "-emoji9"});
                yield return _gameMethods.OpenDialog(2744); // "我要坚定地团结在直系领导的周围。"
                yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui9"});
                Engine._history = false;
                yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei5", "yan5", "zui16", "-emoji2", "-emoji7"});
                yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
                Engine._history = true;
                yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan4", "zui9"});
                yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
                yield return _gameMethods.OpenDialog(2688); // "……"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan27", "zui19"});
                yield return _gameMethods.ExecuteCharacterImageData("he_nv");
                yield return _gameMethods.OpenDialog(2688); // "……"
                yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan17", "zui9"});
                yield return _gameMethods.PlaySound("sound", 0.0f, 1.5f, "<from 0 to 1.5>audio/demo_audio/sound/zu3_nv_zou_man.ogg");
                yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan25", "zui20"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"ypos", 204f}, {"matrixanchor", new Vector2(0.5f, 0.5f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 192f}, {"zpos", 90.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"xpos", 222f}, {"zpos", 132.0f}})});
                yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
                yield return _gameMethods.OpenDialog(2745); // "「眼见为实，{nw}{w=0.1}"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan31", "zui18"});
                yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei3", "yan12", "zui10", "emoji2"});
                yield return _gameMethods.OpenDialog(2746); // "你已经知道答案了。」"
                yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui6"});
                yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan31", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(222f, 204f)}, {"zpos", 132.0f}})});
                yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei7", "yan5", "zui15", "-emoji2"});
                yield return _gameMethods.OpenDialog(2747); // "「唉，好吧。{nw}{w=0.1}"
                yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
                yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
                yield return _gameMethods.OpenDialog(2748); // "谁让你有主场优势呢。」"
                yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
                yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
                yield return _gameMethods.OpenDialog(2688); // "……"
                yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan14", "zui8"});
                yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
                yield return _gameMethods.OpenDialog(2749); // "「……嗯——{nw}{w=0.1}"
                yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
                yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
                yield return _gameMethods.OpenDialog(2750); // "不如我们做个交易吧，尼德霍格。」"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan25", "zui2"});
                Engine._history = false;
                yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
                yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
                Engine._history = true;
                yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan31", "zui2"});
                yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui13"});
                yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/ding1.mp3");
                yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
                yield return _gameMethods.OpenDialog(2738); // "「我把王国的另一个公主抓过来，{nw}{w=0.1}"
                yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui3"});
                yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
                yield return _gameMethods.OpenDialog(2739); // "我们交换怎么样。」"
                yield return _gameMethods.ChangeLabelTo("label_choice15");

    }

    public IEnumerator label_zhuxian_3_menu_0_3Te3Fbs0()
    {
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
                yield return _gameMethods.StopSound(channelName:"music", fadeOut:2f);
                yield return _gameMethods.PlaySound("music1", 0.0f, 0.8f, "audio/demo_audio/music/qingkuai5.mp3");
                yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan3", "zui19", "emoji12", "-emoji6"});
                yield return _gameMethods.OpenDialog(2751); // "啊、是在问我吗？"
                Defaults.Haogandu_he = Defaults.Haogandu_he + 2;
                yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei2", "yan5", "zui19", "emoji2", "-emoji12"});
                yield return _gameMethods.OpenDialog(2752); // "对不起，我今天耳朵聋了。"
                yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan4", "zui9"});
                yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan3", "zui2", "-emoji11", "-emoji12"});
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei2", "yan5", "zui7", "-emoji2"});
                yield return _gameMethods.OpenDialog(2753); // "我姿态谦逊，歉意地问。"
                yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei2", "yan11", "zui19"});
                yield return _gameMethods.OpenDialog(2754); // "你是在说这里飞虫有点多吗？"
                yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei2", "yan11", "zui19", "emoji2"});
                yield return _gameMethods.OpenDialog(2755); // "毕竟是在山里，没办法。"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan25", "zui2"});
                Engine._history = false;
                yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
                yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan3", "zui2"});
                yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei11", "yan2", "zui15"});
                yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
                yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
                Engine._history = true;
                yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei2", "yan2", "zui3"});
                Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 2;
                yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei2", "yan11", "zui7", "-emoji2"});
                yield return _gameMethods.OpenDialog(2756); // "哈哈哈哈哈~"
                yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei4", "yan11", "zui2"});
                yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
                yield return _gameMethods.OpenDialog(2757); // "「真狡猾呢。{nw}{w=0.1}"
                yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui1"});
                yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
                yield return _gameMethods.OpenDialog(2758); // "不过，很有趣所以放过你了。」"
                yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
                yield return _gameMethods.PlaySound("sound", 0.0f, 1.5f, "<from 0 to 1.5>audio/demo_audio/sound/zu3_nv_zou_man.ogg");
                yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan25", "zui13"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"ypos", 204f}, {"matrixanchor", new Vector2(0.5f, 0.5f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 192f}, {"zpos", 90.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"xpos", 222f}, {"zpos", 132.0f}})});
                yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei1", "yan24", "zui16", "emoji2"});
                yield return _gameMethods.OpenDialog(2759); // "「的确，{nw}{w=0.1}"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan31", "zui9"});
                yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
                yield return _gameMethods.OpenDialog(2760); // "这里的飞蚊太过扰人。」"
                yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan3", "zui8"});
                yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan31", "zui2"});
                Engine._history = false;
                yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
                yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
                Engine._history = true;
                yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
                yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei1", "yan24", "zui16", "-emoji2"});
                yield return _gameMethods.OpenDialog(2688); // "……"
                yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan14", "zui8"});
                yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
                yield return _gameMethods.OpenDialog(2749); // "「……嗯——{nw}{w=0.1}"
                yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
                yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
                yield return _gameMethods.OpenDialog(2750); // "不如我们做个交易吧，尼德霍格。」"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan25", "zui2"});
                Engine._history = false;
                yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
                yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
                Engine._history = true;
                yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan31", "zui2"});
                yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui13"});
                yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/ding1.mp3");
                yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei1", "yan5", "zui15"});
                yield return _gameMethods.OpenDialog(2738); // "「我把王国的另一个公主抓过来，{nw}{w=0.1}"
                yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui3"});
                yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
                yield return _gameMethods.OpenDialog(2739); // "我们交换怎么样。」"
                yield return _gameMethods.ChangeLabelTo("label_choice15");

    }

    public IEnumerator label_zhuxian_3_menu_0_VuG7naFr()
    {
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan20", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(2816); // "好怪啊。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan20", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(2817); // "虽然平时在睡觉时拉手也有过十指相扣，但那时是我主动握住他。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan21", "zui15"});
        yield return _gameMethods.OpenDialog(2818); // "现在被别人扣住了手掌，就产生了一种被他控制束缚般的不自在。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(2819); // "但是，这毕竟是领导。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(2820); // "短暂的沉默后，我乖乖地默认了他的行为。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(2821); // "似乎对此满意了，赫泽尔牵着我的手没有再动作。"
        yield return _gameMethods.ChangeLabelTo("label_choice16");
    }

    public IEnumerator label_zhuxian_3_menu_0_1ZhZMA1r()
    {
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(2822); // "轻微的错愕之下，{nw}{w=0.1}"
        yield return _gameMethods.PlaySound("sound", 0.5f, 1.0f, "audio/sound/emeng_dajie/Scuba Diver Wearing Wet Suit Tight Rubber Sleeve_01.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan21", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(2823); // "我下意识便想抽手。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan2", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(2824); // "只刚轻微挣动了一下，扣入我指缝中的手指就收束握得更紧。"
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/houhui/Tight Face_02_duan.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(0f, -60f)}, {"zpos", -198.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.4f}, {"pos", new Vector2(-60f, -36f)}, {"zpos", -312.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan2", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(2825); // "掌心紧压上来，填满每一丝可能出现的空隙。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-60f, -36f)}, {"zpos", -312.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan9", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(2826); // "他的手明明不大，力量上的悬殊却压倒性的令人无法升起一分一毫的抗衡。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan9", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(2827); // "严密合缝，毫无余地。"
        yield return _gameMethods.ChangeLabelTo("label_choice16");
    }

    public IEnumerator label_zhuxian_3_menu_0_rFFPcqla()
    {
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan21", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(2828); // "………"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(2829); // "………………好吧，虽然有点意外。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui16", "emoji2"});
        yield return _gameMethods.OpenDialog(2830); // "但不管他想干什么，我努力配合就是了。"
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/houhui/Grab Hand_01.mp3");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(2831); // "出于不能让老大冷场的自觉，我弯起手指，试着同样扣住他的手，作为回应。"
        yield return _gameMethods.PlaySound("sound", 0.5f, 1.0f, "audio/sound/emeng_dajie/Scuba Diver Wearing Wet Suit Tight Rubber Sleeve_01.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan9", "zui16", "emoji2"});
        yield return _gameMethods.OpenDialog(2832); // "……却发现自己连指根的关节都被他禁锢着，紧紧锁住了。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei4", "yan5", "zui16", "-emoji2"});
        yield return _gameMethods.OpenDialog(2700); // "…………"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan21", "zui8", "emoji2"});
        yield return _gameMethods.OpenDialog(2833); // "别说活动的空间了，根本就是一根手指也动不了。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui8", "emoji2"});
        yield return _gameMethods.OpenDialog(2834); // "整只手仿若被死死镇压住，动弹不得。"
        yield return _gameMethods.ChangeLabelTo("label_choice16");
    }

    public IEnumerator label_zhuxian_3_menu_0_0IL8gWTS()
    {
        yield return _gameMethods.ChangeLabelTo("label_choice17");
    }

    public IEnumerator label_zhuxian_3_menu_0_fjomO2Nf()
    {
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan18", "zui15"});
        yield return _gameMethods.OpenDialog(2913); // "我感觉……心里有些痒痒的。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(2914); // "是不是可以理解为，他对自己曾经的选择感到了后悔。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(2915); // "他对我怀有愧疚之情。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(2916); // "更重要的信息是——他在乎我。"
        yield return _gameMethods.ChangeLabelTo("label_choice19");
    }

    public IEnumerator label_zhuxian_3_menu_0_ianLAW4g()
    {
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan22", "zui15"});
        yield return _gameMethods.OpenDialog(2917); // "我心中毫无波动。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(2918); // "这行为能意味什么呢。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan20", "zui15"});
        yield return _gameMethods.OpenDialog(2919); // "内疚？同情？"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(2920); // "内疚到足以放掉我吗。同情到可以不再看管我么。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(2921); // "如果不能，那它就什么也不代表。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(2922); // "……不过。{nw}{w=0.1}"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan17", "zui15"});
        yield return _gameMethods.OpenDialog(2923); // "\n虽然不知龙会如何，但人倒是都会本能地逃避自己的过错。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(2924); // "若是不知节制地激发犯错者的愧疚，最终反而要引起对方的怨恨和厌烦。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(2925); // "我还是见好就收吧。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(2926); // "尽管原因不明，但看起来他对我心存一点愧疚，{nw}{w=0.1}"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(2927); // "\n还是借此为自己谋得一点实际利益吧。"
        yield return _gameMethods.ChangeLabelTo("label_choice19");
    }


}