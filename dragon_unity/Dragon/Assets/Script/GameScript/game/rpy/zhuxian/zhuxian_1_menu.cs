
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class zhuxian_1_menu : ILabelProvider
{
    private GameMethods _gameMethods;

    public zhuxian_1_menu(GameMethods gameMethods)
    {
        _gameMethods = gameMethods;
    }
    
    public IEnumerator label_zhuxian_1_menu_0_0uZ3wM7p()
    {
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:3f);
                yield return _gameMethods.ChangeLabelTo("label_choice2_1");

    }

    public IEnumerator label_zhuxian_1_menu_0_cfSQiBxk()
    {
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:3f);
                yield return _gameMethods.ChangeLabelTo("label_choice2_2");

    }

    public IEnumerator label_zhuxian_1_menu_0_L6K1ovAI()
    {
        Defaults.Daan_1 += 1;
                yield return _gameMethods.ChangeLabelTo("label_choice2_3");

    }

    public IEnumerator label_zhuxian_1_menu_0_KQbknFJ6()
    {
        yield return _gameMethods.ChangeLabelTo("label_choice3_1");
    }

    public IEnumerator label_zhuxian_1_menu_0_G91rkkCt()
    {
        yield return _gameMethods.ChangeLabelTo("label_choice3_2");
    }

    public IEnumerator label_zhuxian_1_menu_0_5w2QHhB3()
    {
        Defaults.Daan_1 += 1;
        yield return _gameMethods.ChangeLabelTo("label_choice3_3");
    }

    public IEnumerator label_zhuxian_1_menu_0_LuOjSnIg()
    {
        yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"nv_mei_fangsong", "-nv_emoji_han", "nv_zui_bi_xia", "nv_yan_dazheng"});
        yield return _gameMethods.OpenDialog(863); // "算了，如果对面是个粗神经还好，"
        yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"nv_yan_dazheng_hou"});
        yield return _gameMethods.OpenDialog(864); // "可偏偏是逻辑性强的类型..."
        yield return _gameMethods.OpenDialog(865); // "我对自己脑筋急转弯的水平没有自信..."
        yield return _gameMethods.ChangeLabelTo("label_choice4");
    }

    public IEnumerator label_zhuxian_1_menu_0_GINq6KpU()
    {
        yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"nv_yan_dazheng_hou", "nv_zui_zhangzui_xiao", "nv_mei_xie"});
        yield return _gameMethods.ExecuteCharacterImageData("nv2");
        yield return _gameMethods.OpenDialog(866); // "就是……嗯、第一次有幸碰到你头发的人竟然是我..."
        yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"nv_zui_zhangzui", "nv_mei_zhoumei"});
        Defaults.Haogandu_he = Defaults.Haogandu_he - 2;
        yield return _gameMethods.ExecuteCharacterImageData("nv2");
        yield return _gameMethods.OpenDialog(867); // "却又庆幸，因此有些过激。"
        yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"nv_zui_bi_xia", "he_zui_kai2"});
        yield return _gameMethods.ExecuteCharacterImageData("he");
        yield return _gameMethods.OpenDialog(868); // "这无法解释你刚刚的话语..."
        yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"he_zui_bi", "nv_yan_weizheng_hou"});
        yield return _gameMethods.ExecuteCharacterImageData("nv2");
        yield return _gameMethods.OpenDialog(478); // "……"
        yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"he_zui_kai3", "he_yan_xiao_hou", "he_mei_nu"});
        yield return _gameMethods.ExecuteCharacterImageData("he");
        yield return _gameMethods.OpenDialog(869); // "你在欺瞒我？"
        yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"he_zui_bi"});
        yield return _gameMethods.ExecuteCharacterImageData("nv2");
        yield return _gameMethods.OpenDialog(478); // "……"
        yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"-nv_yan_weizheng_hou"});
        yield return _gameMethods.OpenDialog(870); // "他怎么对人类既了解又不了解。"
        yield return _gameMethods.ChangeLabelTo("label_choice4");
    }

    public IEnumerator label_zhuxian_1_menu_0_0Ao0qzeo()
    {
        yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_nv2", "gaoguang_zheng"});
        yield return _gameMethods.ExecuteCharacterImageData("nv2");
        yield return _gameMethods.OpenDialog(1003); // "可是喜欢是不需要理由的。"
        yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_yan2", "biao_he_zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he");
        yield return _gameMethods.OpenDialog(1004); // "人的行为总会遵循特定的行事逻辑..."
        yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_nv4", "gaoguang_bi", "biao_he_zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv2");
        yield return _gameMethods.OpenDialog(1005); // "我对你一见钟情不行吗。"
        yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_zui2", "biao_he_yan1"});
        yield return _gameMethods.ExecuteCharacterImageData("he");
        yield return _gameMethods.OpenDialog(1006); // "那是什么？"
        yield return _gameMethods.ChangeLabelTo("label_choice5");
    }

    public IEnumerator label_zhuxian_1_menu_0_h0kOnOgu()
    {
        yield return _gameMethods.ChangeLabelTo("label_choice5");
    }

    public IEnumerator label_zhuxian_1_menu_0_fTyqxEBk()
    {
        yield return _gameMethods.ChangeLabelTo("label_choice7");
    }

    public IEnumerator label_zhuxian_1_menu_0_NC4LH3Fr()
    {
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(1812); // "惬意。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(1813); // "大概这就是人体的自我保护机制。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(1814); // "但我对它并不排斥。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan18", "zui15"});
        yield return _gameMethods.OpenDialog(1815); // "如果能让自己过得舒服一些，那何乐而不为呢？"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan21", "zui15"});
        yield return _gameMethods.OpenDialog(1816); // "而且，说实话，赫泽尔对我不算坏..."
        yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:3f);
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui7"});
        yield return _gameMethods.OpenDialog(1817); // "也许他并非无法沟通。{nw}{w=0.1}"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(1818); // "而预言也不是全无改变的可能。"
        yield return _gameMethods.EngineSetVolume(volume:0.7f, delay:0.5f, channelName:"music1");
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(461); // "…………"
        yield return _gameMethods.ChangeLabelTo("label_choice8");
    }

    public IEnumerator label_zhuxian_1_menu_0_0atx99ew()
    {
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan20", "zui15", "emoji13"});
        yield return _gameMethods.OpenDialog(1819); // "极其反感。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan21", "zui15", "-emoji13"});
        yield return _gameMethods.OpenDialog(1820); // "这种情感上不由自主的发展走向..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui9"});
        yield return _gameMethods.OpenDialog(1821); // "爱上带走我的人，是最屈辱的一件事了。"
        yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:3f);
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan20", "zui9"});
        yield return _gameMethods.OpenDialog(1822); // "无法掌控自身的感情与自由意志..."
        yield return _gameMethods.EngineSetVolume(volume:0.7f, delay:0.5f, channelName:"music1");
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(461); // "…………"
        yield return _gameMethods.ChangeLabelTo("label_choice8");
    }

    public IEnumerator label_zhuxian_1_menu_0_mUlXYAZU()
    {
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.5>audio/sound/jiaobusheng_xin_normal1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.40f}, {"zpos", -84.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui19", "-emoji2"});
        yield return _gameMethods.OpenDialog(1838); // "好呀，那你早点回来哦。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan3", "zui2"});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -84.0f}})});
        Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(1839); // "你还养着一只人类呢..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui7"});
        yield return _gameMethods.OpenDialog(1840); // "毕竟这里位于荒山野岭..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
        yield return _gameMethods.OpenDialog(1841); // "……好。"
        yield return _gameMethods.ChangeLabelTo("label_choice10");
    }

    public IEnumerator label_zhuxian_1_menu_0_SfrsndZZ()
    {
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.42f}, {"zpos", 20.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui19", "-emoji2"});
        yield return _gameMethods.OpenDialog(1842); // "「啊，那你慢慢飞就好，{nw}{w=0.1}"
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(1843); // "不用急着赶回来。」"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 20.0f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan11", "zui7"});
        yield return _gameMethods.OpenDialog(1844); // "最好就是别回来了..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(1845); // "我把这话咽进了肚子里。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.5>audio/sound/jiaobusheng_xin_normal1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 20.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.30f}, {"zpos", -84.0f}})});
        Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui2"});
        yield return _gameMethods.OpenDialog(1846); // "我会一直等你的！"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan3", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
        yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui9"});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -84.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
        yield return _gameMethods.OpenDialog(602); // "……嗯。"
        yield return _gameMethods.ChangeLabelTo("label_choice10");
    }

    public IEnumerator label_zhuxian_1_menu_0_nWmrA0MU()
    {
        Defaults.Qigai = 1;
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.5f, "<silence 0.4>audio/sound/moca1.ogg");
        yield return _gameMethods.Show("bread_1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 36f}, {"anchor", new Vector2(0f, 0f)}, {"pos", new Vector2(-180f, 320f)}, {"zoom", 0.8f}, {"yoffset", 100f}, {"alpha", 0f}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ease", 0.7f}, {"yoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ease", 0.2f}, {"alpha", 1f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan9", "zui10"});
        yield return _gameMethods.OpenDialog(1376); // "这是你花钱买的面包。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan7", "zui2"});
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1>audio/sound/jiaobusheng_xin_man1.ogg");
        yield return _gameMethods.Show("bread_1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}, {"alpha", 1f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -78.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.16f}, {"zpos", -114.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(1377); // "我能从中抽出几个送给她们么？"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan7", "zui2"});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -114.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(1378); // "「……{nw}{w=0.3}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
        yield return _gameMethods.OpenDialog(1379); // "……{nw}{w=0.5}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan8", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
        yield return _gameMethods.OpenDialog(1380); // "你随意。但这没用，改变不了她们的命运。」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan8", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui19"});
        yield return _gameMethods.OpenDialog(1381); // "谢谢你！"
        yield return _gameMethods.Hide("dajie2");
        yield return _gameMethods.Hide("he");
        yield return _gameMethods.Hide("bread_1");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(-480f, 138f)}, {"zpos", -270.0f}})});
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui7"});
        yield return _gameMethods.OpenDialog(1382); // "我走近小巷，朝那几个孩子挥了挥手。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui7"});
        yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui7"});
        yield return _gameMethods.OpenDialog(1383); // "她们望见我手里的食物..."
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/demo_audio/sound/moca5_duan.mp3");
        yield return _gameMethods.PlaySound("sounda1", 0.0f, 0.8f, "<silence 0.5>audio/sound/emeng_dajie/running_on_the_gravel_01.mp3");
        yield return _gameMethods.Show("dajie2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.38f, 1.27f)}, {"zoom", 1.31f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.3f}, {"alpha", 1f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(1384); // "直到第一个孩子耐不住了..."
        yield return _gameMethods.Show("dajie2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(1385); // "为防哄抢踩踏..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15"});
        yield return _gameMethods.OpenDialog(1386); // "接着，挨个分发面包。"
        yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:10f);
        yield return _gameMethods.Show("2-5_zoom");
        yield return _gameMethods.Hide("2-5_zoom");
        yield return _gameMethods.Scene("qigai_1");
        Defaults.Gui_duihuakuang_you = 0;
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -246f}, {"zpos", 390.0f}})});
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/emeng_dajie/Wolfing_01.ogg");
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(1387); // "那几个孩子刚得到面包..."
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -246f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 1f}, {"ypos", -438f}})});
        yield return _gameMethods.OpenDialog(1388); // "我盯着她们风卷残云地吞面包..."
        yield return _gameMethods.OpenDialog(1389); // "——尽管身上还藏着当初为了逃跑傍身..."
        yield return _gameMethods.OpenDialog(1390); // "金钱只会给这些无依无靠的孤儿招致祸患。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -438f}})});
        yield return _gameMethods.OpenDialog(1391); // "而且，我也绝不可以在赫泽尔面前..."
        yield return _gameMethods.OpenDialog(1392); // "因此……我能给她们的，只有几块面包。"
        yield return _gameMethods.OpenDialog(1393); // "这解决不了世界上普遍存在的贫穷..."
        yield return _gameMethods.OpenDialog(1394); // "现在我能给的也只有这个了。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/moca1.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("qigai_weizhi");
        yield return _gameMethods.OpenDialog(1395); // "——！！！"
        yield return _gameMethods.OpenDialog(1396); // "忽然，一道凄惨的尖叫响起。"
        yield return _gameMethods.OpenDialog(1397); // "我一惊，望去——"
        yield return _gameMethods.Show("2-6_zoom");
        yield return _gameMethods.Hide("2-6_zoom");
        yield return _gameMethods.Scene("qigai_2");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 1f}, {"ypos", -510f}, {"zpos", 396.0f}})});
        yield return _gameMethods.PlaySound("sounda1", 0.0f, 1.0f, "audio/sound/emeng_dajie/Body fall Scuffle Trip_01.ogg");
        yield return _gameMethods.Transition(time:0.2f);
        yield return _gameMethods.OpenDialog(1398); // "有两个流浪儿正激烈地在地上扭打着。"
        yield return _gameMethods.OpenDialog(1399); // "估计是其中一个孩子率先吃完了自己的面包..."
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/demo_audio/sound/moca5_duan.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -510f}, {"zpos", 396.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.5f}, {"ypos", -216f}})});
        // with Shake((0, 0, 0, 0), 0.5, dist=10) — 抖动转场
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(1400); // "被抢的女孩发出凄厉的哀嚎..."
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -216f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(478); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan20", "zui15"});
        yield return _gameMethods.OpenDialog(1401); // "明明同为受倾轧的弱者..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan17", "zui15"});
        yield return _gameMethods.OpenDialog(1402); // "我之所以扛着让赫泽尔等我的压力..."
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 396.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.4f}, {"zpos", 312.0f}})});
        yield return _gameMethods.OpenDialog(1403); // "我把面包篮往赫泽尔手里一塞..."
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.2f, "audio/sound/emeng_dajie/Slap In The Face_01.mp3");
        yield return _gameMethods.OpenDialog(1404); // "\n接着，给了那抢面包的小孩一巴掌。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 312.0f}})});
        yield return _gameMethods.OpenDialog(1405); // "那孩子起先还想挣脱..."
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/emeng_dajie/Down_01.mp3");
        yield return _gameMethods.OpenDialog(1406); // "然而我却松开了她..."
        yield return _gameMethods.OpenDialog(1407); // "由于从小需要收拾街道巷里..."
        yield return _gameMethods.OpenDialog(1408); // "其实，这种抢夺行为并未引起我的愤怒..."
        yield return _gameMethods.OpenDialog(1409); // "但秩序的维系需要暴力手段..."
        yield return _gameMethods.Scene("qigai_1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.49f, 1.25f)}, {"zoom", 1.38f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
        yield return _gameMethods.Transition(time:0.6f);
        yield return _gameMethods.OpenDialog(1410); // "那个闹事的孩子安分下来后..."
        yield return _gameMethods.OpenDialog(1411); // "这是最后一块。{nw}{w=0.01}"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/emeng_dajie/Wolfing_01.ogg");
        yield return _gameMethods.OpenDialog(1412); // "挨饿太久..."
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan9", "zui10"});
        yield return _gameMethods.OpenDialog(1413); // "「我会给你们买一张澡堂的票..."
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui10"});
        yield return _gameMethods.OpenDialog(1414); // "尤其头脸和手脚，衣服最好也洗一遍。」"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(1415); // "我忍不住多叮嘱了几句..."
        Defaults.Haogandu_he = Defaults.Haogandu_he + 2;
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan12", "zui10"});
        yield return _gameMethods.OpenDialog(1416); // "别偷懒..."
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(1417); // "洗澡是为了能让你们..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(1418); // "再之后——无论是..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(1419); // "还是工匠作坊的学徒..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(1420); // "又或者贵族的与家仆。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(1421); // "只要能找到一份工作..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan20", "zui15"});
        yield return _gameMethods.OpenDialog(1422); // "而只要活下来，就会有希望。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(1423); // "几个流浪儿只顾着狼吞虎咽..."
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:8f);
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(478); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(1424); // "（只能尽人事，听天命了。）"
        yield return _gameMethods.ShowWhite();
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/emeng_dajie/Magic Spell Book Pages Flipping_01.ogg");
        yield return _gameMethods.Transition(time:0.1f);
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(1425); // "忽然，我感觉到了某种视线。"
        yield return _gameMethods.OpenDialog(1426); // "下意识看去。"
        yield return _gameMethods.Scene("qigai_3_ditu", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -200f}})});
        yield return _gameMethods.Show("qigai_3_renwu", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -100f}})});
        yield return _gameMethods.Show("2-7_zoom");
        yield return _gameMethods.Hide("2-7_zoom");
        yield return _gameMethods.Show("qigai_3_xin", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(222f, 168f)}, {"zpos", -546f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 1.2f}, {"pos", new Vector2(462f, 180f)}, {"zpos", 174f}})});
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/demo_audio/sound/moca6_duan.mp3");
        yield return _gameMethods.PlaySound("soundb", 3f, 1.0f, "audio/sound/emeng_dajie/Nervous_01.ogg");
        yield return _gameMethods.Transition(time:0.2f);
        yield return _gameMethods.OpenDialog(1427); // "正对上一双眼睛。"
        yield return _gameMethods.OpenDialog(1428); // "刚刚那个抢人面包的女孩..."
        yield return _gameMethods.OpenDialog(1429); // "……我忽然意识到..."
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(462f, 180f)}, {"zpos", 174f}})});
        yield return _gameMethods.OpenDialog(1430); // "从她含污纳垢的头发下..."
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 462f}, {"zpos", 174f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 2f}, {"xpos", 234f}, {"zpos", -246f}})});
        yield return _gameMethods.OpenDialog(1431); // "女孩瞪视着我..."
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(461); // "…………"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan24", "zui7", "emoji2"});
        yield return _gameMethods.OpenDialog(1432); // "哈哈……该不会是记仇了..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui6", "emoji2"});
        yield return _gameMethods.OpenDialog(1433); // "真可惜，我估计等不到那时候了。"
        yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:3f);
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 234f}, {"zpos", -246f}})});
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 2>audio/sound/jiaobusheng_xin_normal1.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(1434); // "我看着那几个孩子，{nw}{w=0.1}"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15"});
        yield return _gameMethods.OpenDialog(1435); // "后退几步，{nw}{w=0.2}"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(1436); // "最终转身。{nw}{w=0.2}"
        yield return _gameMethods.Scene("dajie3");
        Defaults.Gui_duihuakuang_you = 1;
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 2.57f)}, {"zoom", 0.52f}})});
        yield return _gameMethods.Transition(time:0.6f);
        Engine._history = false;
        yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
        yield return _gameMethods.PlaySound("soundb", 1f, 0.7f, "audio/sound/emeng_dajie/Town Crow_01.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(1437); // "自觉地回到了赫泽尔身边。"
        yield return _gameMethods.PlaySound("music", 4f, 1.0f, "audio/demo_audio/music/richang1.mp3");
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(1438); // "对不起，耽误了你这么多时间。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(1439); // "谢谢你。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan5", "zui7"});
        // rpy 原版 he_nv 这句没有dialog id 在 dialogues.txt 中 — 使用占位符
        yield return _gameMethods.OpenDialog(1440); // "没关系。"
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(1441); // "我们继续逛街。"
        yield return _gameMethods.Scene("dajie1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-252f, -744f)}, {"zoom", 1.3f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.49f, 2.36f)}, {"zoom", 0.47f}})});
        yield return _gameMethods.Transition(time:0.7f);
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(1442); // "过了一段时间，赫泽尔突然开口。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(1443); // "她们之中，有四个会在一周内离世。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei1", "yan1", "zui15"});
        yield return _gameMethods.OpenDialog(491); // "………………"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei9", "yan1", "zui9"});
        yield return _gameMethods.OpenDialog(1444); // "……那只是五个孩子……"
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei9", "yan8", "zui3"});
        yield return _gameMethods.OpenDialog(1445); // "「……这样啊。{nw}{w=0.1}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei9", "yan12", "zui7"});
        yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei9", "yan21", "zui3"});
        yield return _gameMethods.OpenDialog(1446); // "\n这也是没办法的事。」"
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei9", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(1447); // "「不好意思啊，浪费你时间..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan11", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei9", "yan11", "zui7"});
        yield return _gameMethods.OpenDialog(611); // "{nw}{w=0.2}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(612); // "{nw}{w=0.12}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(1448); // "他轻轻摇了摇头。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei6", "yan12", "zui18"});
        yield return _gameMethods.OpenDialog(478); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei6", "yan12", "zui18"});
        yield return _gameMethods.OpenDialog(1449); // "我深呼吸了一下，平复心情。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(1450); // "……他方才的话里..."
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10"});
        yield return _gameMethods.OpenDialog(1451); // "……你还能预知未来吗？"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(1452); // "堆积在她们身上的灾祸太浓了..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(1453); // "「真厉害！"
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(1454); // "你能了解到什么程度呀？」"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.5>audio/sound/jiaobusheng_xin_normal1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.23f}, {"zpos", -42.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan3", "zui3"});
        yield return _gameMethods.OpenDialog(1455); // "「会知道她们会遇到什么，{nw}{w=0.1}"
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui9"});
        yield return _gameMethods.OpenDialog(1456); // "是如何离世的吗？」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -42.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(1457); // "……我只是能看见生物身上的黑雾浓度。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei22", "yan10", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(1458); // "而这个浓度，通常都会在五至七天内离世。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei22", "yan10", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan8", "zui19"});
        yield return _gameMethods.OpenDialog(1459); // "哦……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui7"});
        yield return _gameMethods.OpenDialog(1460); // "也就是说，不是预知。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -42.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"zpos", 0.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan21", "zui6"});
        yield return _gameMethods.OpenDialog(1461); // "我暗暗松了口气。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(1462); // "然而，{nw}{w=0.1}"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(1463); // "想到那几个流浪儿难以撼动的命运..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan20", "zui15"});
        yield return _gameMethods.OpenDialog(1464); // "心情仍旧沉重下来。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei3", "yan20", "zui15"});
        yield return _gameMethods.OpenDialog(478); // "……"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan12", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei3", "yan20", "zui15"});
        yield return _gameMethods.OpenDialog(1465); // "还有一个人不会死。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(1466); // "吃了面包后，她身上的浓雾被显著驱散了。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(478); // "……"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan8", "zui20"});
        yield return _gameMethods.OpenDialog(1467); // "这样啊。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui20"});
        yield return _gameMethods.OpenDialog(1468); // "谢谢你告诉我。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan8", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
        yield return _gameMethods.OpenDialog(780); // "没什么。"
        yield return _gameMethods.ChangeLabelTo("label_choice6");
    }

    public IEnumerator label_zhuxian_1_menu_0_HKPTHQ9W()
    {
        yield return _gameMethods.OpenDialog(1469); // "……算了吧，他说得对。"
        yield return _gameMethods.OpenDialog(1470); // "如果无法给这些孩子一个确定的未来..."
        yield return _gameMethods.OpenDialog(1471); // "还是算了吧。"
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 2>audio/sound/jiaobusheng_xin_normal1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
        yield return _gameMethods.Transition(time:0.6f);
        yield return _gameMethods.OpenDialog(461); // "…………"
        yield return _gameMethods.Scene("dajie1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-252f, -744f)}, {"zoom", 1.3f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.49f, 2.36f)}, {"zoom", 0.47f}})});
        yield return _gameMethods.Transition(time:0.7f);
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(1472); // "离开那个街道后，赫泽尔忽然开口。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(1473); // "她们会在一周内离世。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan2", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(491); // "………………"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1>audio/demo_audio/sound/zu3_nv_zou.ogg");
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.3f}, {"zpos", 28.0f}})});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
        yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei3", "yan12", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei3", "yan2", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(1474); // "这是他们的命运，不是因你而起，也不会因你改变。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 28.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei1", "yan8", "zui10", "-emoji2"});
        yield return _gameMethods.OpenDialog(1475); // "「……这样啊，{nw}{w=0.1}"
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei1", "yan12", "zui10"});
        yield return _gameMethods.OpenDialog(1476); // "这也是没办法的事。」"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei1", "yan2", "zui10"});
        yield return _gameMethods.OpenDialog(1477); // "…………你还能预知未来吗？"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei1", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(1478); // "堆积在她们身上的灾祸太浓了..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(1479); // "那，能了解到什么程度呀？"
        yield return _gameMethods.ExecuteCharacterImageData("nv1");
        yield return _gameMethods.OpenDialog(1480); // "会知道她们会遇到什么，是如何离世的吗？"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan8", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(1457); // "……我只是能看见生物身上的黑雾浓度。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(1458); // "而这个浓度，通常都会在五至七天内离世。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan8", "zui10"});
        yield return _gameMethods.OpenDialog(1459); // "哦……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(1460); // "也就是说，不是预知。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(1461); // "我暗暗松了口气。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan20", "zui15"});
        yield return _gameMethods.OpenDialog(1481); // "然而，想到那几个流浪儿难以撼动的命运..."
        yield return _gameMethods.ChangeLabelTo("label_choice6");
    }

}