using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zhuxian5 : ILabelProvider
{
    private GameMethods _gameMethods;

    public zhuxian5(GameMethods gameMethods)
    {
        _gameMethods = gameMethods;
    }

    public IEnumerator label_zhuxian5_bai()
    {
        Defaults.Haogandu_an = Defaults.Haogandu_an + 1;
        Defaults.Persistent.Jq_6_5 = 1;
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.OpenDialog(33); // "………………"
        yield return _gameMethods.Hide("black");
        yield return _gameMethods.Show("heilong_shufang_baitian_shugui", parts: new List<string>{"onlayer", "master0"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.72f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(6933); // "转眼间，两周过去。"
        yield return _gameMethods.PlaySound("music", 2.0f, 1.0f, "audio/demo_audio/music/qingkuai4.mp3");
        yield return _gameMethods.OpenDialog(6934); // "今天是神奇的一天。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/ding1.mp3");
        yield return _gameMethods.Show("shuben_bi", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.5f)}, {"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1.0f}})});
        yield return _gameMethods.OpenDialog(6935); // "我从书架上居然翻出了一本爱情题材的罗曼戏剧。"
        yield return _gameMethods.Show("shuben_bi", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(6936); // "真是难得一见。"
        yield return _gameMethods.Show("shuben_bi", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 1.5f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.5f}, {"ypos", 1.4f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan11", "zui16", "emoji10", "emoji15"});
        yield return _gameMethods.OpenDialog(6937); // "好久没吃到这种精神食粮了……！"
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<from 0 to 1>audio/sound/jiaobusheng_xin_normal1.ogg");
        yield return _gameMethods.PlaySound("sounda1", 0.2f, 0.4f, "<silence 0.5>audio/demo_audio/sound/moca2.mp3");
        yield return _gameMethods.Scene("heilong_shufang_baitian_quanjing1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.09f)}})});
        yield return _gameMethods.TransitionBy("trans_rip_fast");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan9", "zui8", "emoji9", "-emoji10", "emoji15"});
        yield return _gameMethods.OpenDialog(6938); // "我将书拿到沙发边，坐下，{nw}{w=0.1}"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/book1.mp3");
        yield return _gameMethods.Hide("heilong_shufang_baitian_shugui");
        yield return _gameMethods.Show("shuben", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 400.0f}, {"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1.0f}})});
        yield return _gameMethods.OpenDialog(6939); // "迫不及待、津津有味地读了起来。"
        yield return _gameMethods.Show("shuben", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui7", "-emoji9", "-emoji15"});
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.OpenDialog(33); // "………………"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(6940); // "不知时间过了多久，忽然间，"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan6", "zui15"});
        yield return _gameMethods.OpenDialog(6941); // "我感觉到一股视线。"
        yield return _gameMethods.PlaySound("sound", 0.2f, 0.4f, "audio/demo_audio/sound/moca2.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.29f}, {"ypos", -60.0f}})});
        yield return _gameMethods.Show("heilong_shufang_baitian_shafa", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.2f, 2.75f)}, {"zoom", 2.41f}, {"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.3f}, {"alpha", 1.0f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 2.39f)}, {"zoom", 0.51f}, {"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.3f}, {"alpha", 1.0f}})});
        yield return _gameMethods.Show("shuben", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 400.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.5f}, {"yoffset", 450.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(6942); // "抬头望去——"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -60.0f}})});
        yield return _gameMethods.Show("heilong_shufang_baitian_shafa", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        yield return _gameMethods.Show("he", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        yield return _gameMethods.Show("shuben", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 450.0f}})});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.OpenDialog(6943); // "赫泽尔正看着我。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan7", "zui2"});
        yield return _gameMethods.OpenDialog(6944); // "他的目光落到我手中的书籍封皮上，停留的时间似乎有..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
        yield return _gameMethods.OpenDialog(6945); // "你对这本书有什么感想。"
        yield return _gameMethods.PlaySound("sound", 0.2f, 0.4f, "audio/demo_audio/sound/moca2.mp3");
        yield return _gameMethods.Show("shuben", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 450.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.3f}, {"yoffset", 430.0f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(924); // "……？"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan9", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan9", "zui15"});
        yield return _gameMethods.OpenDialog(1599); // "「……{nw}{w=0.1}"
        yield return _gameMethods.Show("shuben", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 430.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan2", "zui19"});
        yield return _gameMethods.OpenDialog(6946); // "还可以呀。」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan10", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui6"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui6", "emoji12"});
        yield return _gameMethods.OpenDialog(924); // "……？"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(1693); // "为什么？"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan11", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui6", "-emoji12"});
        yield return _gameMethods.OpenDialog(6947); // "这本书里不存在任何有价值的地方。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan11", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan2", "zui9"});
        yield return _gameMethods.OpenDialog(6948); // "……啊。{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei8", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei8", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(6949); // "我很快反应过来。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan6", "zui15"});
        yield return _gameMethods.OpenDialog(6950); // "赫泽尔大概有翻过这本书。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(6951); // "但他估计只能欣赏得来政治历史经济类书籍，所以看不..."
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui3"});
        yield return _gameMethods.OpenDialog(6952); // "你不是这本书的目标受众而已。它还是挺好看的。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan5", "zui6"});
        yield return _gameMethods.OpenDialog(6953); // "它讲了什么？"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui9"});
        yield return _gameMethods.OpenDialog(6954); // "你不是看过吗？"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan5", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(6955); // "我理解不了。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan5", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan6", "zui19"});
        yield return _gameMethods.OpenDialog(6956); // "「……呃，{nw}{w=0.01}"
        yield return _gameMethods.PlaySound("sound", 0.2f, 0.4f, "audio/demo_audio/sound/moca2.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.6f}, {"zpos", -18.0f}})});
        yield return _gameMethods.OpenDialog(6957); // "是人类之间的爱情纠葛。」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -18.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui6"});
        yield return _gameMethods.OpenDialog(6958); // "尽管听了我的解释，{nw}{w=0.01}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan28", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan5", "zui6"});
        yield return _gameMethods.OpenDialog(6959); // "但赫泽尔似乎仍旧对“人类之间的爱情纠葛”毫无想象..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(6960); // "于是他转而问我。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui6"});
        yield return _gameMethods.OpenDialog(6961); // "你认为这本书写得怎么样。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui3"});
        yield return _gameMethods.OpenDialog(6962); // "「还蛮精彩的，{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan3", "zui3"});
        yield return _gameMethods.OpenDialog(6963); // "情节一波三折，{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan3", "zui3"});
        yield return _gameMethods.OpenDialog(6964); // "但是依然存在一些{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei4", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan3", "zui10"});
        yield return _gameMethods.OpenDialog(6965); // "应该说是时代的局限性吧。」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan9", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei3", "yan3", "zui15"});
        yield return _gameMethods.OpenDialog(6966); // "局限性？"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan9", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan2", "zui10"});
        yield return _gameMethods.OpenDialog(6967); // "女主的形象太单薄了，就像刻板印象中纯洁柔弱的贵族..."
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan12", "zui10"});
        yield return _gameMethods.OpenDialog(6968); // "男女主之间的爱情只有莫名其妙的一见钟情，和毫无缘..."
        yield return _gameMethods.Hide("he");
        yield return _gameMethods.Hide("shuben");
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.67f}, {"alpha", 0.0f}, {"blur", 1.0f}, {"pos", new Vector2(12.0f, -54.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan9", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 2.39f)}, {"zoom", 0.51f}})});
        yield return _gameMethods.Show("shuben", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 430.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(6969); // "呀，真是卓有见地。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/zhenjing_shuaidaoganjue.mp3");
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:1.0f);
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei4", "yan25", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(47); // "……！"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(165); // "？"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei4", "yan2", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(4); // "……"
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(6970); // "我忽然睁大眼睛，让赫泽尔有些疑惑地看了我一眼，"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan11", "zui8", "emoji2"});
        yield return _gameMethods.OpenDialog(6971); // "我忙假装若无其事地对他笑笑。"
        yield return _gameMethods.PlaySound("music", 2.0f, 1.0f, "audio/music/Whimsical_Waltz.mp3");
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian", parts: new List<string>{"mei3", "yan11", "zui8", "-emoji2"});
        yield return _gameMethods.OpenDialog(6972); // "「呵呵……吓了一跳？{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan5", "zui8", "emoji2"});
        yield return _gameMethods.OpenDialog(6973); // "也对，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui4"});
        yield return _gameMethods.OpenDialog(6974); // "如果被赫泽尔发现，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui5"});
        yield return _gameMethods.OpenDialog(6975); // "不知道他会怎么惩罚你呢。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian", parts: new List<string>{"mei6", "yan10", "zui7"});
        yield return _gameMethods.OpenDialog(6976); // "「努力不要露出异常，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui3"});
        yield return _gameMethods.OpenDialog(6977); // "加油哦，小公主。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei5", "yan12", "zui8"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("nuo_heart_layered", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"alpha", 0.0f}, {"blur", 0.1f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan24", "zui15"});
        yield return _gameMethods.OpenDialog(6978); // "我尽力在脑海里屏蔽他的声音。"
        yield return _gameMethods.Hide("nuo_heart_layered");
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei4", "yan24", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(6979); // "这有什么问题么。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei3", "yan2", "zui19", "emoji2"});
        yield return _gameMethods.OpenDialog(6980); // "「我觉得爱情不会这样发生，{nw}{w=0.01..."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan11", "zui19", "emoji2"});
        yield return _gameMethods.OpenDialog(6981); // "至少这不符合我个人的爱情观。」"
        yield return _gameMethods.Hide("he");
        yield return _gameMethods.Hide("shuben");
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui5"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.67f}, {"alpha", 0.0f}, {"blur", 1.0f}, {"pos", new Vector2(12.0f, -54.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 2.39f)}, {"zoom", 0.51f}})});
        yield return _gameMethods.Show("shuben", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 430.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan11", "zui9", "emoji2"});
        yield return _gameMethods.OpenDialog(6982); // "嗯，这倒是让我很好奇。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_wu", parts: new List<string>{"mei4", "yan24", "zui8", "emoji2"});
        yield return _gameMethods.OpenDialog(6983); // "（你给我安静。）"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2"});
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei4", "yan24", "zui8", "-emoji2"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("nuo_heart_layered", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"alpha", 0.0f}, {"blur", 0.1f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(6984); // "你说得好像很了解爱情的样子。"
        yield return _gameMethods.Hide("nuo_heart_layered");
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei8", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(6985); // "你有过伴侣？"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan5", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(6986); // "「…………"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei8", "yan6", "zui15"});
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei8", "yan12", "zui2"});
        yield return _gameMethods.OpenDialog(6987); // "呃。」"
        yield return _gameMethods.Hide("he");
        yield return _gameMethods.Hide("shuben");
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.67f}, {"alpha", 0.0f}, {"blur", 1.0f}, {"pos", new Vector2(12.0f, -54.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 2.39f)}, {"zoom", 0.51f}})});
        yield return _gameMethods.Show("shuben", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 430.0f}})});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("nuo_heart_layered", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.8f}, {"alpha", 0.0f}, {"blur", 0.1f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui7"});
        yield return _gameMethods.OpenDialog(6988); // "总感觉给自己下了个套。可恶。"
        yield return _gameMethods.Hide("nuo_heart_layered");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(6989); // "……但是，按照赫泽尔的性格，假若不给出答案，他恐..."
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan8", "zui6"});
        yield return _gameMethods.OpenDialog(4054); // "嗯…………"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan8", "zui6", "-emoji2"});
        yield return _gameMethods.OpenDialog(6990); // "这辈子是没可能有闲情逸致去谈什么恋爱的。至于上辈..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan24", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(6991); // "……我有过吗？"
        yield return _gameMethods.OpenSelectMenu(
            talk: new List<string>{"-有过，是碳基活人", "-没有，寡王的一生", "-有很多，纸片的"},
            jump: new List<string>{"label_zhuxian5_menu_0_zOVaB79d", "label_zhuxian5_menu_0_dVxsu37I", "label_zhuxian5_menu_0_6EnhTLGh"},
            condition: new List<string>{"NONE", "NONE", "NONE"}
        );
    }

    public IEnumerator label_zhuxian5_choice1_bai()
    {
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan9", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7018); // "然而，我的沉默似乎给赫泽尔造成了误会。"
        yield return _gameMethods.EngineSetVolume(volume:1.0f, delay:2.0f, channelName:"music");
        yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan19", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei8", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(7019); // "谁。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan19", "zui21"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(7020); // "他现在还活着么。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan19", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei4", "yan2", "zui2", "emoji1", "emoji2", "emoji3", "emoji6"});
        yield return _gameMethods.OpenDialog(7021); // "{sc=2}{size=+10}首先为什么会问他..."
        yield return _gameMethods.PlaySound("music1", 0.0f, 1.0f, "audio/music/Alphard.mp3");
        yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan13", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei4", "yan2", "zui8", "-emoji3", "-emoji6"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan15", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(7022); // "你现在还爱他吗。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan15", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan2", "zui19"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan2", "zui6"});
        yield return _gameMethods.OpenDialog(6456); // "「……{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei8", "yan24", "zui19"});
        yield return _gameMethods.OpenDialog(7023); // "不好说。」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei8", "yan24", "zui8"});
        yield return _gameMethods.OpenDialog(7024); // "现在你更爱那个人，还是更爱我。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -18.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.5f}, {"zpos", -36.0f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(7025); // "那个，首先我们要区分一下。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan11", "zui1"});
        yield return _gameMethods.OpenDialog(7026); // "爱是一个门类，里面还有很多品种。比如亲情、友情和..."
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -36.0f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan4", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei8", "yan11", "zui6"});
        yield return _gameMethods.OpenDialog(7027); // "我还没有欠缺常识到不知道这些的地步。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan15", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(7028); // "你对我的是哪一种。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan2", "zui6"});
        yield return _gameMethods.OpenDialog(7029); // "「呃……{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei8", "yan5", "zui3"});
        yield return _gameMethods.OpenDialog(7030); // "友、友情？{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei8", "yan6", "zui3"});
        yield return _gameMethods.OpenDialog(7031); // "或者亲情，就像家人一样。」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan5", "zui3"});
        yield return _gameMethods.OpenDialog(7032); // "这和恋人之间的爱情是不同的。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei8", "yan5", "zui6"});
        yield return _gameMethods.OpenDialog(7033); // "不同？有什么区别。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan7", "zui6"});
        yield return _gameMethods.OpenDialog(7034); // "好哲学的问题。我迫切地想念搜索引擎。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7035); // "……必须认真回答，不然赫泽尔会不高兴。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan7", "zui6"});
        yield return _gameMethods.OpenDialog(7036); // "爱情和友情亲情，前者与后两者之间的区别是什么呢？"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui6"});
        yield return _gameMethods.OpenDialog(1926); // "………"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7037); // "苦思冥想片刻。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan12", "zui6", "emoji6"});
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(7038); // "——果然、最直观的差别就是亲密程度吧。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(7039); // "毫无疑问，和朋友与家人之间能接受的亲密程度是不同..."
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan10", "zui3", "-emoji13"});
        yield return _gameMethods.OpenDialog(7040); // "我想……和亲密程度有关？"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan12", "zui10", "-emoji1", "-emoji2", "-emoji6"});
        yield return _gameMethods.OpenDialog(7041); // "即便是一次无心之举，在亲人与朋友间都是绝对越界的..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan28", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(7042); // "他若有所思，似乎在消化这个概念。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:2.0f);
        yield return _gameMethods.StopSound(channelName:"music1", fadeOut:2.0f);
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(7043); // "「也就是说，如果我们变得更加亲密，{nw}{w=..."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(7044); // "你对我的感情就转变成了爱情？」"
        yield return _gameMethods.Hide("he");
        yield return _gameMethods.Hide("shuben");
        yield return _gameMethods.Show("nuo_heart_layered", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.67f}, {"alpha", 0.0f}, {"blur", 1.0f}, {"pos", new Vector2(12.0f, -54.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 0.0f}, {"pos", new Vector2(0.5f, 2.39f)}, {"zoom", 0.51f}})});
        yield return _gameMethods.Show("shuben", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 430.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan2", "zui13", "emoji2", "emoji5", "emoji6"});
        yield return _gameMethods.OpenDialog(7045); // "呀，真大胆。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/zhenjing_shuaidaoganjue.mp3");
        yield return _gameMethods.PlaySound("music2", 0.0f, 1.0f, "audio/music/Whimsical_Waltz.mp3");
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei6", "yan12", "zui2", "emoji2", "emoji16", "emoji5"});
        yield return _gameMethods.OpenDialog(7046); // "{size=+10}太恐怖了。{/size}我对..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui5"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei6", "yan24", "zui16", "emoji2", "emoji16", "emoji5"});
        yield return _gameMethods.OpenDialog(7047); // "嗯——这种程度就害怕了吗？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan9", "zui4"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
        yield return _gameMethods.OpenDialog(7048); // "「那假若我告诉你，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui6"});
        yield return _gameMethods.OpenDialog(7049); // "他看起来是认真的呢。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui12"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei6", "yan10", "zui10", "emoji2", "emoji6", "emoji16", "emoji5"});
        yield return _gameMethods.OpenDialog(130); // "……………………"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan14", "zui5"});
        yield return _gameMethods.OpenDialog(7050); // "如果你处理不善…………"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei6", "yan10", "zui15", "emoji2", "emoji6", "emoji16", "emoji5"});
        yield return _gameMethods.OpenDialog(7051); // "呵呵…真危险呀，小公主。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei6", "yan10", "zui15", "emoji2", "emoji6", "emoji16", "-emoji5"});
        yield return _gameMethods.OpenDialog(7052); // "你处于这么危险的境地，自己却如此脆弱。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei6", "yan10", "zui15", "emoji2", "emoji6", "emoji16"});
        yield return _gameMethods.OpenDialog(7053); // "不过，如果要在赫泽尔和我之间选择，我一定会是更好..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui16"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
        yield return _gameMethods.OpenDialog(7054); // "「至少，我的手段会比这样不谙世事的赫泽尔要温柔、..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui1"});
        yield return _gameMethods.OpenDialog(7055); // "不至于轻易把你弄坏。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui3"});
        yield return _gameMethods.OpenDialog(7056); // "对吗？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei6", "yan12", "zui23"});
        yield return _gameMethods.OpenDialog(7057); // "我恨不得把耳朵堵上。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei6", "yan12", "zui13"});
        yield return _gameMethods.OpenDialog(7058); // "求求你别说了！"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_wu", parts: new List<string>{"mei6", "yan22", "zui2"});
        yield return _gameMethods.OpenDialog(7059); // "（禁止花言巧语。）"
        yield return _gameMethods.Hide("nuo_heart_layered");
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(7060); // "为了避免赫泽尔的思维走向更可怕的方向，我连忙改口..."
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/moca1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0.0f}, {"parallel_1", true}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui1"});
        yield return _gameMethods.OpenDialog(7061); // "……不对，仔细想想！果然区别还是在于……在于……"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"yoffset", 0.0f}})});
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/demo_audio/sound/ding1.mp3");
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan24", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui1", "-emoji5", "emoji7"});
        yield return _gameMethods.OpenDialog(7062); // "啊，想到了！！"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui19"});
        yield return _gameMethods.OpenDialog(7063); // "应该是排他性！"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui6"});
        yield return _gameMethods.OpenDialog(165); // "？"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui2", "-emoji16"});
        yield return _gameMethods.OpenDialog(7064); // "也就是说，一段爱情关系会排斥第三者的存在。"
        yield return _gameMethods.OpenDialog(7065); // "你只能和一个人建立恋爱关系，而不能和第二或第三个..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan28", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui6", "-emoji7"});
        yield return _gameMethods.OpenDialog(7066); // "这可以理解为，“爱情的对象只能有一个，而友情或亲..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan28", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui1", "-emoji1", "-emoji2"});
        yield return _gameMethods.OpenDialog(7067); // "是的。至少在道德观念上，爱情必须忠贞，爱人是独一..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui6"});
        yield return _gameMethods.OpenDialog(7068); // "……但据我所知，在人类贵族中，也有先喜欢这个再喜..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui9", "-emoji6"});
        yield return _gameMethods.OpenDialog(7069); // "这是正常的，只要不同时喜欢两个就可以。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(1693); // "为什么？"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(7070); // "他无动于衷地看着我，一副“好奇怪但习惯了”的平淡..."
        yield return _gameMethods.Hide("he");
        yield return _gameMethods.Hide("shuben");
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei11", "yan2", "zui15"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.67f}, {"alpha", 0.0f}, {"blur", 1.0f}, {"pos", new Vector2(12.0f, -54.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 0.0f}, {"pos", new Vector2(0.5f, 2.39f)}, {"zoom", 0.51f}})});
        yield return _gameMethods.Show("shuben", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 430.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
        yield return _gameMethods.OpenDialog(6456); // "「……{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei11", "yan2", "zui3"});
        yield return _gameMethods.OpenDialog(7071); // "哈哈。」"
        yield return _gameMethods.Show("nuo_heart_layered", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"alpha", 0.0f}, {"blur", 0.1f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui9", "emoji1", "emoji2"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Hide("nuo_heart_layered");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui9", "emoji6"});
        yield return _gameMethods.OpenDialog(7072); // "好难过。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui9", "emoji5"});
        yield return _gameMethods.OpenDialog(7073); // "我感受到了一种宛若马里亚纳海沟似的代沟，和如同心..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan12", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui12"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(7074); // "我知道了。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(7075); // "你是在说，人类可以将感情从一个人转移到另一个人。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan8", "zui1"});
        yield return _gameMethods.OpenDialog(7076); // "哈哈……哈哈……是啊。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan8", "zui20"});
        yield return _gameMethods.OpenDialog(7077); // "{size=-10}……原来你知道啊……{/si..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan9", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan8", "zui5", "-emoji5", "-emoji6"});
        yield return _gameMethods.OpenDialog(7078); // "「…………{nw}{w=0.01}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan10", "zui9"});
        yield return _gameMethods.OpenDialog(7079); // "我只是一时之间没有想到。」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan10", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10"});
        yield return _gameMethods.OpenDialog(1640); // "哦。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(7080); // "我干巴巴地哦了一声。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei9", "yan24", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7081); // "赫泽尔皱眉看着我，我的这个反应似乎令他不太愉快。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui15"});
        yield return _gameMethods.OpenDialog(7082); // "……意识到这显得有些敷衍，{nw}{w=0.01..."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan5", "zui6"});
        yield return _gameMethods.OpenDialog(7083); // "我一击掌，大声夸赞道。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/moca1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0.0f}, {"parallel_1", true}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui2", "-emoji1", "-emoji2", "emoji7"});
        yield return _gameMethods.OpenDialog(7084); // "真是太厉害了！不愧是赫泽尔大人。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"yoffset", 0.0f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei9", "yan17", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui6"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui6", "emoji2"});
        yield return _gameMethods.OpenDialog(7085); // "不知为何，他好像更不高兴了。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan27", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan5", "zui6", "-emoji7"});
        yield return _gameMethods.OpenDialog(7086); // "追求稳定就是服务于生物的、为其提供的一种生存机制..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan25", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(7087); // "摒弃稳定的生活去配合感情的变化，本身是违背理性的..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan10", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(7088); // "所以，我一时间反应不过来，才是正常的思考方向。"
        yield return _gameMethods.StopSound(channelName:"music2", fadeOut:5.0f);
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -36.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.8f}, {"zpos", -18.0f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan10", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(7089); // "「这、{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan2", "zui19"});
        yield return _gameMethods.OpenDialog(7090); // "这样啊……」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan9", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan24", "zui6"});
        yield return _gameMethods.OpenDialog(7091); // "就这么讨厌被别人当成无知之辈吗你。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan13", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -18.0f}})});
        yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/demo_audio/music/richang2.mp3");
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(7092); // "……你对那个人，是爱情吗？"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui19"});
        yield return _gameMethods.OpenDialog(7093); // "是、是的吧，大概…。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan3", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui6"});
        yield return _gameMethods.OpenDialog(7094); // "为什么是那个人？他是什么样的。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui3"});
        yield return _gameMethods.OpenDialog(7095); // "咦，什么什么样的。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan22", "zui21"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan5", "zui6"});
        yield return _gameMethods.OpenDialog(7096); // "他有哪些外在或内在特征吸引到了你，足以让你将他放..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan22", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan3", "zui10"});
        yield return _gameMethods.OpenDialog(7097); // "……啊、他……"
        yield return _gameMethods.OpenSelectMenu(
            talk: new List<string>{"-和你差不多", "-和你完全不同"},
            jump: new List<string>{"label_zhuxian5_menu_1_sY7K8iTE", "label_zhuxian5_menu_1_k2JHdgwY"},
            condition: new List<string>{"NONE", "NONE"}
        );
    }

    public IEnumerator label_zhuxian5_he()
    {
        Defaults.Haogandu_an = Defaults.Haogandu_an + 1;
        Defaults.Persistent.Jq_6_4 = 1;
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.OpenDialog(33); // "………………"
        yield return _gameMethods.Hide("black");
        yield return _gameMethods.Show("heilong_shufang_baitian_shugui", parts: new List<string>{"onlayer", "master0"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.72f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(6933); // "转眼间，两周过去。"
        yield return _gameMethods.PlaySound("music", 2.0f, 1.0f, "audio/demo_audio/music/qingkuai4.mp3");
        yield return _gameMethods.OpenDialog(6934); // "今天是神奇的一天。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/ding1.mp3");
        yield return _gameMethods.Show("shuben_bi", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.5f)}, {"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1.0f}})});
        yield return _gameMethods.OpenDialog(6935); // "我从书架上居然翻出了一本爱情题材的罗曼戏剧。"
        yield return _gameMethods.Show("shuben_bi", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(6936); // "真是难得一见。"
        yield return _gameMethods.Show("shuben_bi", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 1.5f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.5f}, {"ypos", 1.4f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan11", "zui16", "emoji10", "emoji15"});
        yield return _gameMethods.OpenDialog(6937); // "好久没吃到这种精神食粮了……！"
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<from 0 to 1>audio/sound/jiaobusheng_xin_normal1.ogg");
        yield return _gameMethods.PlaySound("sounda1", 0.2f, 0.4f, "<silence 0.5>audio/demo_audio/sound/moca2.mp3");
        yield return _gameMethods.Scene("heilong_shufang_baitian_quanjing1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.09f)}})});
        yield return _gameMethods.TransitionBy("trans_rip_fast");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan9", "zui8", "emoji9", "-emoji10", "emoji15"});
        yield return _gameMethods.OpenDialog(7173); // "我将书拿到沙发边，坐下，{nw}{w=0.01}"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/book1.mp3");
        yield return _gameMethods.Hide("heilong_shufang_baitian_shugui");
        yield return _gameMethods.Show("shuben", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 400.0f}, {"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1.0f}})});
        yield return _gameMethods.OpenDialog(6939); // "迫不及待、津津有味地读了起来。"
        yield return _gameMethods.Show("shuben", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui7", "-emoji9", "-emoji15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7174); // "不知时间过了多久，忽然间，{nw}{w=0.01..."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan6", "zui15"});
        yield return _gameMethods.OpenDialog(6941); // "我感觉到一股视线。"
        yield return _gameMethods.PlaySound("sound", 0.2f, 0.4f, "audio/demo_audio/sound/moca2.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Hide("shuben");
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.ChangeLabelTo("label_dulishi_gongtong");
    }

    public IEnumerator label_dulishi_gongtong()
    {
        yield return _gameMethods.Scene("tiankong_baitian");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.Show("tiankong_bangwan", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 2.0f}, {"alpha", 1.0f}})});
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.Show("tiankong_yewan", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}, {"zoom", 1.3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 2.0f}, {"alpha", 1.0f}})});
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.Show("tiankong_baitian", parts: new List<string>{"at", "default", "as", "tiankong_baitian2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}, {"zoom", 1.3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 2.0f}, {"alpha", 1.0f}})});
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.Show("tiankong_bangwan", parts: new List<string>{"with", "dissolve"});
        yield return _gameMethods.PlaySound("music1", 3.0f, 1.0f, "audio/demo_audio/music/richang1.mp3");
        Defaults.Haogandu_an = Defaults.Haogandu_an + 1;
        yield return _gameMethods.OpenDialog(7175); // "时间仍在平缓地流逝。"
        yield return _gameMethods.Scene("heilong_shufang_bangwan1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}, {"pos", new Vector2(-444.0f, -450.0f)}, {"zoom", 1.1f}})});
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.OpenDialog(7176); // "我把大量的时间花费在书房里，学习真言、阅读书籍，..."
        yield return _gameMethods.PlaySound("sound", 0.0f, 2.0f, "audio/sound/manbu/Body1_02_duan.mp3");
        yield return _gameMethods.Show("heilong_shufang_bangwan1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        if (Defaults.He_about_boyfriend == 0)
        {
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.8f}, {"ypos", -432.0f}})});
            yield return _gameMethods.Show("heilong_shufang_bangwan3", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.0f, 0.0f)}, {"pos", new Vector2(-246.0f, -552.0f)}, {"zoom", 0.88f}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"alpha", 1.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15", "-emoji15"});
            yield return _gameMethods.OpenDialog(7177); // "迄今为止，他对我的态度，总让我感觉自己还有着那么..."
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -432.0f}})});
            yield return _gameMethods.Show("heilong_shufang_bangwan3", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        }
        if (Defaults.He_about_boyfriend == 1)
        {
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.8f}, {"ypos", -432.0f}})});
            yield return _gameMethods.Show("heilong_shufang_bangwan3", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.0f, 0.0f)}, {"pos", new Vector2(-246.0f, -552.0f)}, {"zoom", 0.88f}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"alpha", 1.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15", "-emoji15"});
            yield return _gameMethods.OpenDialog(7178); // "虽然上次气氛闹得有些僵硬，{nw}{w=0.01..."
            yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(7179); // "但考虑到迄今为止他对我逐渐软化的态度，我仍感觉自..."
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -432.0f}})});
            yield return _gameMethods.Show("heilong_shufang_bangwan3", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        }
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(7180); // "所以，我想再努力争取看看。"
        yield return _gameMethods.PlaySound("sounda1", 0.0f, 1.0f, "<from 0 to 2>audio/sound/jiaobusheng_xin_normal1.ogg");
        yield return _gameMethods.Scene("heilong_shufang_bangwan2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.48f, 1.03f)}, {"zoom", 0.71f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.TransitionBy("trans_rip_fast");
        yield return _gameMethods.OpenDialog(4); // "……"
        Defaults.Persistent.Jq_6_6 = 1;
        yield return _gameMethods.OpenDialog(7181); // "上次读罗曼小说，闹出了那么多麻烦。"
        yield return _gameMethods.OpenDialog(7182); // "这次我不敢再碰，打算选一本历史书来阅读。"
        yield return _gameMethods.Show("shuben_bi", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 150.0f}, {"xoffset", 350.0f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/book1.mp3");
        yield return _gameMethods.Hide("shuben_bi");
        yield return _gameMethods.Show("shuben", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 100.0f}, {"xoffset", 150.0f}})});
        yield return _gameMethods.Transition(time:0.5f);
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui9"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei", "yan9", "zui15"});
        yield return _gameMethods.OpenDialog(7183); // "北方兽人部落的统一与分散……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei", "yan", "zui15"});
        yield return _gameMethods.OpenDialog(7184); // "……啊。好巧。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei", "yan9", "zui15"});
        yield return _gameMethods.OpenDialog(7185); // "这是当初我刚到城堡时，赫泽尔曾给我阅读过的一本书..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(7186); // "那时，书上七八成的内容都是我所不认识的字眼。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan9", "zui8"});
        yield return _gameMethods.OpenDialog(7187); // "而现在，我已经能凭借自己的力量，不费吹灰之力地看..."
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<silence 0.2>audio/demo_audio/sound/book2_he.mp3");
        yield return _gameMethods.Hide("shuben");
        yield return _gameMethods.Show("shuben_bi", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 150.0f}, {"xoffset", 350.0f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(7188); // "寒来暑往，变化如此明显。"
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<from 0 to 1>audio/sound/jiaobusheng_xin_normal1.ogg");
        yield return _gameMethods.PlaySound("sounda1", 0.0f, 1.0f, "<silence 1>audio/demo_audio/sound/moca2.mp3");
        yield return _gameMethods.Scene("heilong_shufang_bangwan1");
        yield return _gameMethods.Hide("shuben_bi");
        yield return _gameMethods.Show("shuben_bi", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 350.0f}, {"xoffset", 350.0f}})});
        yield return _gameMethods.TransitionBy("trans_rip_fast");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui7"});
        yield return _gameMethods.OpenDialog(7189); // "我在平时常占的位置坐下。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/book1.mp3");
        yield return _gameMethods.Show("shuben_bi", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"alpha", 0.0f}})});
        yield return _gameMethods.Show("shuben", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 250.0f}, {"xoffset", 150.0f}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"alpha", 1.0f}})});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei", "yan8", "zui7"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei", "yan9", "zui7"});
        yield return _gameMethods.OpenDialog(7190); // "打开书，{nw}{w=0.01}"
        yield return _gameMethods.Show("shuben", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        yield return _gameMethods.Hide("shuben_bi");
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei", "yan8", "zui7"});
        yield return _gameMethods.OpenDialog(7191); // "逐渐沉浸其中。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei", "yan", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7192); // "史书篇章上、我再次读到了对那名曾统一北方草原的兽..."
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/book1.mp3");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7193); // "他看起来拥有着我当前最渴望的自由和力量。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7194); // "少年天才，锋芒毕露，无拘无束。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(7195); // "假若我能站上那样的位置，那么、现在困扰着我的一切..."
        if (Defaults.Bai_xue ==1)
        {
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.67f}, {"alpha", 0.0f}, {"blur", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1.0f}, {"blur", 0.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei8", "yan25", "zui15"});
            yield return _gameMethods.OpenDialog(7196); // "你对他很感兴趣？"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}, {"blur", 0.0f}})});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei8", "yan25", "zui15"});
            yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan7", "zui14", "emoji2"});
            yield return _gameMethods.OpenDialog(7197); // "诺伯拉的声音神出鬼没地冒了出来。"
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan8", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(7198); // "我对此已经屡见不怪了。"
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan8", "zui19"});
            yield return _gameMethods.OpenDialog(7199); // "毕竟也算是个传奇人物嘛。"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan14", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian", parts: new List<string>{"mei7", "yan8", "zui7"});
            yield return _gameMethods.OpenDialog(5003); // "「嗯——{nw}{w=0.01}"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13"});
            yield return _gameMethods.OpenDialog(7200); // "我见过他。」"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei3", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(1826); // "……！？"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui14"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/dulishi_gongtong_fced2013.ogg");
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
            yield return _gameMethods.OpenDialog(7201); // "「我当过他的一名卫兵。{nw}{w=0.01}"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13"});
            yield return _gameMethods.OpenDialog(7202); // "虽然，只是很短一段时间。」"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui3"});
            yield return _gameMethods.OpenDialog(7203); // "他赏赐手下时还挺大方的呢。"
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(21); // "…………"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.Show("shuben", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 250.0f}, {"xoffset", 150.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.5f}, {"yoffset", 320.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(7204); // "好像也不该奇怪。"
            yield return _gameMethods.Show("shuben", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 320.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan5", "zui9"});
            yield return _gameMethods.OpenDialog(7205); // "所以呢，他真的有记载中那么强大吗？"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui14"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(7206); // "「是啊，他很强，{nw}{w=0.01}"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui13"});
            yield return _gameMethods.OpenDialog(7207); // "击败了无数对手，站在了当时兽人部落的权力顶点。」"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13"});
            yield return _gameMethods.OpenDialog(7208); // "当然，也就结下了无数仇家。"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui8"});
            yield return _gameMethods.OpenDialog(4); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
            yield return _gameMethods.OpenDialog(7209); // "我专心地聆听着。"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan14", "zui16"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
            yield return _gameMethods.OpenDialog(7210); // "「他很担心这一点，达到了偏执的程度，{nw}{w..."
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13"});
            yield return _gameMethods.OpenDialog(7211); // "睡觉时不允许任何人近身。」"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui14"});
            yield return _gameMethods.OpenDialog(7212); // "疑心过重，让他很难休息好。"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui13"});
            yield return _gameMethods.OpenDialog(7213); // "在他的中晚年，脾气比较多变，甚至因此驱逐了不少随..."
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui6"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
            yield return _gameMethods.OpenDialog(7214); // "「但他从不为自己的决定而后悔，{nw}{w=0...."
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui14"});
            yield return _gameMethods.OpenDialog(7215); // "因为他觉得如果后悔，以后就无法再如此果决了。」"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(7216); // "这倒是书中未曾记载的。"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan5", "zui10"});
            yield return _gameMethods.OpenDialog(4671); // "……是吗。"
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan8", "zui10"});
            yield return _gameMethods.OpenDialog(7217); // "不把别人的前途当前途啊。"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui14"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(7218); // "当然。何况生命本就充满意外。"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui3"});
            yield return _gameMethods.OpenDialog(7219); // "每个生物都只把自己的生命看得贵重，不是吗。"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan9", "zui11"});
            yield return _gameMethods.OpenDialog(7220); // "你真会说大实话。"
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai1");
            yield return _gameMethods.OpenDialog(7221); // "唏嘘怅惘了一阵，我忽然意识到，身边这位热衷于人类..."
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai1");
            yield return _gameMethods.OpenDialog(7222); // "顿时，我燃起了新的兴趣。"
            yield return _gameMethods.Show("shuben", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 320.0f}, {"xoffset", 150.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.5f}, {"yoffset", 250.0f}})});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.5f, "audio/sound/manbu/Body1_02_duan.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan7", "zui19"});
            yield return _gameMethods.OpenDialog(7223); // "那你了解她吗？"
            yield return _gameMethods.Show("shuben", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 250.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan9", "zui8"});
            yield return _gameMethods.OpenDialog(7224); // "我指了指接下来的一篇人物传记。"
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan9", "zui3"});
            yield return _gameMethods.OpenDialog(7225); // "鲁亚的女王。 "
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui5"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan9", "zui7"});
            yield return _gameMethods.OpenDialog(7226); // "女王吗？"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui12"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan12", "zui7"});
            yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(7227); // "我点点头。"
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
            yield return _gameMethods.OpenDialog(7228); // "让我听点大女主爽文。"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui6"});
            yield return _gameMethods.OpenDialog(7229); // "女王啊……"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui4"});
            yield return _gameMethods.OpenDialog(7230); // "她的称王，源于对人生的疑问。"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan20", "zui4"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(7231); // "「她并不是一出生就想称王的，{nw}{w=0.0..."
            yield return _gameMethods.OpenDialog(7232); // "她也曾像一般的贵族，{nw}{w=0.01}"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui13"});
            yield return _gameMethods.OpenDialog(7233); // "渴望得到幸福的婚姻与圆满的人生。」"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui14"});
            yield return _gameMethods.OpenDialog(7234); // "但是最后，因为一些意外，她发现人生仿佛是一场水中..."
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan14", "zui17"});
            yield return _gameMethods.OpenDialog(7235); // "于是她的心里生出疑窦。"
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
            yield return _gameMethods.OpenDialog(7236); // "「也许成了女王，{nw}{w=0.01}"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui16"});
            yield return _gameMethods.OpenDialog(7237); // "便能有足够的力量与手段去解答人生的疑问。」"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei3", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(4); // "……"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei3", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(7238); // "不过，成为女王后，她同样找不到答案。"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui16"});
            yield return _gameMethods.OpenDialog(7239); // "偶尔也会犯下一些严重的错误。"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
            yield return _gameMethods.OpenDialog(7240); // "「最后，她回顾人生，发现自己做的好事标志着人生的..."
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13"});
            yield return _gameMethods.OpenDialog(7241); // "你应该也看到了，女王在统治期间实行平稳缓和的政策..."
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei9", "yan13", "zui17"});
            yield return _gameMethods.OpenDialog(7242); // "这比一心建立丰功伟绩、随意改革，却令人民怨声载道..."
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei9", "yan13", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(7243); // "…… "
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui14"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
            yield return _gameMethods.OpenDialog(7244); // "「怎么，{nw}{w=0.01}"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui3"});
            yield return _gameMethods.OpenDialog(7245); // "感觉自己猜错了？」"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_qian", parts: new List<string>{"mei7", "yan8", "zui10"});
            yield return _gameMethods.OpenDialog(7246); // "「不……{nw}{w=0.01}"
            Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
            if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
            {
                _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
                _gameMethods.SyncAchievement();
            }
            yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan12", "zui10"});
            yield return _gameMethods.OpenDialog(7247); // "只是，感觉他们更像真人了吧。」"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui12"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei8", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(7248); // "在那些被文字记载的丰功伟绩之下，实际上是一个个活..."
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui12"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei8", "yan9", "zui15"});
            yield return _gameMethods.OpenDialog(7249); // "有着明面上的金光闪闪，便存在背后的心酸坚忍。"
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei8", "yan7", "zui15"});
            yield return _gameMethods.OpenDialog(7250); // "……果然，不能用脑海中想象的人，取代真实存在的人..."
            yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei8", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(7251); // "\n用抽象概括的人，去代替具体复杂的人啊。"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui12"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan2", "zui2"});
            yield return _gameMethods.OpenDialog(7252); // "还挺荣幸的。你见过那么多才能出众、权势滔天的人物..."
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(7253); // "因为你确实是一位非常可爱的小公主呀。"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan24", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(7254); // "哈哈。"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan24", "zui7", "-emoji2"});
            yield return _gameMethods.OpenDialog(7255); // "我礼貌地一笑。"
            yield return _gameMethods.Show("nuo_heart_layered", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.7f}, {"alpha", 0.0f}, {"blur", 0.1f}})});
        }
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -2.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 2.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0.0f}, {"parallel_1", true}})});
        Defaults.Persistent.Jq_6_7 = 1;
        yield return _gameMethods.OpenDialog(779); // "你在想什么？"
        yield return _gameMethods.Hide("nuo_heart_layered");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"yoffset", 0.0f}})});
        yield return _gameMethods.OpenDialog(7256); // "赫泽尔冷不丁开口。"
        yield return _gameMethods.OpenDialog(165); // "？"
        yield return _gameMethods.StopSound(channelName:"music1", fadeOut:3.0f);
        yield return _gameMethods.PlaySound("sound", 0.2f, 0.4f, "audio/demo_audio/sound/moca2.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.32f}, {"ypos", -234.0f}})});
        yield return _gameMethods.Show("heilong_shufang_bangwan_shafa1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(450.0f, 810.0f)}, {"zoom", 0.88f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.2f}, {"alpha", 1.0f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}, {"blur", 0.01f}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(630.0f, 1830.0f)}, {"zoom", 0.59f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.2f}, {"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.Show("shuben", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 250.0f}, {"xoffset", 150.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.8f}, {"yoffset", 450.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan25", "zui14", "emoji2"});
        yield return _gameMethods.OpenDialog(7257); // "我心中一惊，抬起头，发现他那双赤红的眼眸正注视着..."
        yield return _gameMethods.Show("heilong_shufang_bangwan_shafa1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan23", "zui9"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -234.0f}})});
        yield return _gameMethods.Show("shuben", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 450.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(7258); // "你在这一页上停留了太久。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan23", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan25", "zui10"});
        yield return _gameMethods.OpenDialog(7259); // "「啊……{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan9", "zui2", "-emoji2"});
        yield return _gameMethods.OpenDialog(7260); // "……我在想，这是当初你最开始给我读过的那本书呢。..."
        yield return _gameMethods.PlaySound("music", 3.0f, 1.0f, "audio/demo_audio/music/youshang2.mp3");
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui2"});
        yield return _gameMethods.OpenDialog(7261); // "不知不觉间，居然已经两年多过去了。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan11", "zui6"});
        yield return _gameMethods.OpenDialog(7262); // "……两年……。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui6"});
        yield return _gameMethods.OpenDialog(7263); // "他低声咀嚼起这个词汇，仿佛自言自语一般。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui6"});
        yield return _gameMethods.OpenDialog(7264); // "才两年么……"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui6"});
        yield return _gameMethods.OpenDialog(7265); // "“才”两年啊。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui1"});
        yield return _gameMethods.OpenDialog(7266); // "对于人类而言，这已经是不短的一段时间啦。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan5", "zui6"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(7267); // "的确，这两年里发生了很多事。在感知上，也会更加漫..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(7268); // "对吧。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.5f, "audio/sound/manbu/Body1_02_duan.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.4f}, {"zpos", -18.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui2"});
        yield return _gameMethods.OpenDialog(7269); // "那时候，第一次见到赫泽尔，我吓了一跳。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -18.0f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan8", "zui2"});
        yield return _gameMethods.OpenDialog(7270); // "明明是那么精致的孩子，却看起来冷冰冰的，而且还说..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan8", "zui6"});
        yield return _gameMethods.OpenDialog(7271); // "你当时看起来并没有被吓到的迹象。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zu2"});
        Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui11"});
        yield return _gameMethods.OpenDialog(7272); // "那是因为我想和你搞好关系。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan29", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(6456); // "「……{nw}{w=0.01}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan15", "zui21"});
        yield return _gameMethods.OpenDialog(7273); // "唔。」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan15", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan3", "zui19"});
        yield return _gameMethods.OpenDialog(7274); // "那时可完全没想到，我们会成为今天这样亲近的关系呢..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan25", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan15", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan3", "zui7"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan3", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan14", "zui6"});
        yield return _gameMethods.OpenDialog(7275); // "「也就是说，{nw}{w=0.01}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan9", "zui9"});
        yield return _gameMethods.OpenDialog(7276); // "你已经爱上我了？」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan9", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan25", "zui15"});
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan8", "zui7"});
        yield return _gameMethods.OpenDialog(7277); // "「……嗯，{nw}{w=0.2}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan8", "zui20"});
        yield return _gameMethods.OpenDialog(7278); // "是啊。」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan29", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan8", "zui7"});
        yield return _gameMethods.OpenDialog(7279); // "沉默片刻，我微笑回答。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui20"});
        yield return _gameMethods.OpenDialog(7280); // "如果是现在，我说不定已经可以做到为你心甘情愿地献..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan13", "zui19"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui6", "-emoji2"});
        yield return _gameMethods.OpenDialog(7281); // "这是一次试探，也是一种诱导。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan9", "zui2", "emoji1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7282); // "我看着他，无比希望听到一句话。一句反驳，一句澄清..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui11", "emoji1"});
        yield return _gameMethods.ExecuteCharacterImageData("he_qian");
        yield return _gameMethods.OpenDialog(4400); // "「……{nw}{w=0.2}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei18", "yan15", "zui3", "-emoji1"});
        yield return _gameMethods.OpenDialog(1265); // "……」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei15", "yan9", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_qian");
        yield return _gameMethods.OpenDialog(4400); // "「……{nw}{w=0.2}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan25", "zui3"});
        yield return _gameMethods.OpenDialog(3123); // "……{nw}{w=0.3}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan15", "zui21"});
        yield return _gameMethods.OpenDialog(1497); // "嗯。」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan15", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_qian");
        yield return _gameMethods.OpenDialog(1378); // "「……{nw}{w=0.3}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan127", "zui9"});
        yield return _gameMethods.OpenDialog(7283); // "我知道了。」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan27", "zui2"});
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:6.0f);
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7284); // "我和他对望了一会儿，{nw}{w=0.01}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan15", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan9", "zui15"});
        yield return _gameMethods.OpenDialog(7285); // "丧失了说话的兴致。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(33); // "………………"
        yield return _gameMethods.PlaySound("sound", 0.2f, 0.4f, "audio/demo_audio/sound/moca2.mp3");
        yield return _gameMethods.Show("heilong_shufang_bangwan_shafa1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.8f}, {"alpha", 0.0f}})});
        yield return _gameMethods.Show("he", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 0.01f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.8f}, {"alpha", 0.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.Show("shuben", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 450.0f}, {"xoffset", 150.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.8f}, {"yoffset", 300.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15"});
        yield return _gameMethods.OpenDialog(7286); // "良久，我低头重新转向了手中的书页，却始终读不进去..."
        yield return _gameMethods.Hide("heilong_shufang_bangwan_shafa1");
        yield return _gameMethods.Hide("he");
        yield return _gameMethods.Show("shuben", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 300.0f}})});
        yield return _gameMethods.PlaySound("music1", 0.0f, 0.8f, "audio/music/Fall.mp3");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(6326); // "……{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(964); // "赫泽尔。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(7287); // "“嗯”、是什么意思呢？"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan20", "zui15"});
        yield return _gameMethods.OpenDialog(7288); // "——在这两年里，我能感受到这位灾厄之龙对我的态度..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan20", "zui15"});
        yield return _gameMethods.OpenDialog(7289); // "但那个我最关心的问题，我绝对不能直接问出口。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(7290); // "因为“深爱”着赫泽尔·尼德霍格、甘愿为他奉献自己..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(7291); // "只有心存不情愿的人，才会如此在意那件事。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(7292); // "我必须在不经意间轻轻试探，才能保证行为的自然。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan21", "zui15"});
        yield return _gameMethods.OpenDialog(7293); // "……再找找机会吧。"
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.StopSound(channelName:"music1", fadeOut:5.0f);
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Hide("shuben");
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.OpenDialog(21); // "…………"
        if (Defaults.Bai_xue == 1)
        {
            yield return _gameMethods.ChangeLabelTo("label_bai_jieji");
        }
        if (Defaults.Bai_xue == 0)
        {
            yield return _gameMethods.OpenDialog(7294); // "夏天匆匆过去，九月带走了最后一分暑气。"
            yield return _gameMethods.ChangeLabelTo("label_he_yangtuzi");
        }
    }

    public IEnumerator label_he_yangtuzi()
    {
        yield return _gameMethods.Scene("senlin2");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.PlaySound("soundb", 0.0f, 1.0f, "audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.Scene("senlin5");
        yield return _gameMethods.TransitionBy("trans_rip_fast");
        yield return _gameMethods.OpenDialog(21); // "…………"
        if (Defaults.Bai_xue == 0)
        {
            yield return _gameMethods.PlaySound("music2", 2.0f, 1.0f, "audio/demo_audio/music/richang1.mp3");
        }
        yield return _gameMethods.Scene("caodi1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(1.69f, 1.08f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 2.04f}})});
        yield return _gameMethods.Show("tuzi", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}, {"pos", new Vector2(240.0f, 96.0f)}, {"zoom", 0.74f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.7f}, {"alpha", 1.0f}})});
        yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:2.0f);
        yield return _gameMethods.Transition(time:0.4f);
        Defaults.Persistent.Jq_7_4 = 1;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan25", "zui15"});
        yield return _gameMethods.OpenDialog(7295); // "这天外出时，我在森林里捡到了一只受伤的兔子。"
        yield return _gameMethods.Show("tuzi", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(7296); // "……说起来，在我四五岁时，某次妈妈拾柴回来，也曾..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan3", "zui15"});
        yield return _gameMethods.OpenDialog(7297); // "那时，我们在农村过得十分清贫，虽没缺过黑面包填饱..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(7298); // "所以在最初的新奇和愉快过后，我有些不道德地咽了咽..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(7299); // "但妈妈非常喜欢它。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui7"});
        yield return _gameMethods.OpenDialog(7300); // "就像得到了礼物的女孩一样，她对它精心照料。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui7"});
        yield return _gameMethods.OpenDialog(7301); // "于是，每天晚上，我们两人便会一起围在兔子的小窝旁..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui6"});
        yield return _gameMethods.OpenDialog(7302); // "半个月后，它已经成了我们小家庭的一员。给我和妈妈..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(7303); // "但——不久后的某一天，它还是被不知哪个村民偷偷捉..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(7304); // "当我们找遍全村，最终寻到村外的田埂时，只看见一小..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan20", "zui15"});
        yield return _gameMethods.OpenDialog(7305); // "作为村里的孤女寡母，我和妈妈没有追根究底，只是流..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(7306); // "我打量着眼前的兔子。"
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(7307); // "它缩成一团，僵直地瑟瑟发抖，眼珠不安地转向一边，..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7308); // "仿佛无比恐惧于接下来的命运，却又只能煎熬地被动等..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(7309); // "……毫无疑问，在寄人篱下、自身难保的情况下，我没..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan21", "zui15"});
        yield return _gameMethods.OpenDialog(7310); // "但这只兔子，不同于那些自愈能力极强的魔兽，它只是..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan20", "zui15"});
        yield return _gameMethods.OpenDialog(7311); // "在这片森林里，受伤的弱者，等同于被宣判死刑。"
        yield return _gameMethods.StopSound(channelName:"music2", fadeOut:2.0f);
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Scene("heilong_huiketing_shafa_baitian", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.83f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 1.87f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 3.28f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.67f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.PlaySound("music", 0.0f, 0.8f, "audio/demo_audio/music/qingkuai3.mp3");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(7312); // "我和赫泽尔面对面坐着。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei6", "yan12", "zui12"});
        yield return _gameMethods.OpenDialog(7313); // "……所以，真的是这只兔子的实力太强大了。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan4", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei6", "yan12", "zui18"});
        yield return _gameMethods.OpenDialog(7314); // "我诚恳地对面前的赫泽尔解释。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei5", "yan2", "zui10"});
        yield return _gameMethods.OpenDialog(7315); // "「它的毛有魔力，{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan12", "zui10", "enoji15"});
        yield return _gameMethods.OpenDialog(7316); // "又软又柔，{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei1", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(7317); // "我的手被吸住就拿不下来了。」"
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei1", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(7318); // "就是说，你想收养这只兔子？"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei1", "yan2", "zui10", "emoji9", "emoji7"});
        yield return _gameMethods.OpenDialog(7319); // "……我可以吗？"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan2", "zui15", "-emoji9", "-emoji7"});
        yield return _gameMethods.OpenDialog(7320); // "我厚着脸皮问，小心地观察他的表情。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7321); // "以赫泽尔的强大和高傲，他通常并不在乎这种小事，因..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7322); // "不过，我当然也做好了一旦发现他面露不渝、就立刻放..."
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei2", "yan2", "zui10"});
        yield return _gameMethods.OpenDialog(7323); // "只是几天，等它痊愈了我就立刻放生。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan4", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei2", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei2", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(7324); // "求求你了，赫泽尔大人。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan10", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei2", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(7325); // "……随便你。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/moca1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.16f}, {"zpos", -35.0f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan10", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19", "emoji9", "-emoji15"});
        yield return _gameMethods.OpenDialog(7326); // "太好了！谢谢你。"
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:8.0f);
        yield return _gameMethods.Scene("woshi_nv2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 0.5f)}, {"pos", new Vector2(612.0f, 264.0f)}, {"zoom", 0.67f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.TransitionBy("trans_rip_fast");
        yield return _gameMethods.OpenDialog(7327); // "在我的恳求之下，赫泽尔最终允许了我短暂地收留这只..."
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.7f, "audio/demo_audio/sound/sibuliao.mp3");
        yield return _gameMethods.PlaySound("sounda", 0.0f, 0.7f, "<silence 1>audio/demo_audio/sound/sibuliao2.mp3");
        yield return _gameMethods.OpenDialog(7328); // "我找出治疗的草药，给它清理伤口，敷药，用夹板固定..."
        yield return _gameMethods.Scene("heilong_shufang_baitian_louti", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}, {"ypos", -180.0f}})});
        yield return _gameMethods.Show("shuben", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}, {"xpos", 200.0f}, {"ypos", 300.0f}})});
        yield return _gameMethods.TransitionBy("trans_rip_fast");
        yield return _gameMethods.PlaySound("music1", 2.0f, 0.7f, "audio/music/wenxin1.mp3");
        yield return _gameMethods.OpenDialog(7329); // "读书时，也把它抱到我的腿上。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui8", "-emoji9"});
        yield return _gameMethods.OpenDialog(7330); // "抚摸柔软的皮毛果然是最解压的办法之一。"
        yield return _gameMethods.PlaySound("sound", 0.2f, 0.4f, "audio/demo_audio/sound/moca2.mp3");
        yield return _gameMethods.Show("shuben", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 300.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.7f}, {"ypos", 400.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui7"});
        yield return _gameMethods.OpenDialog(7331); // "我看一会书，就忍不住轻轻摸一下小兔子。"
        yield return _gameMethods.Show("shuben", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 400.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7332); // "它已经不再怕我了，依偎在我的手边。"
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/demo_audio/sound/book2_he.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.5f}, {"ypos", -120.0f}})});
        yield return _gameMethods.Show("heilong_shufang_baitian_shafa", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.17f, 2.54f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 2.21f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan25", "zui3"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 2.52f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.55f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(7333); // "这时，旁边的赫泽尔忽然合上了手中的书本。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -120.0f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan27", "zui9"});
        yield return _gameMethods.OpenDialog(7334); // "……你在这只兔子上倾注了太多没必要的时间。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan27", "zui2"});
        yield return _gameMethods.OpenDialog(7335); // "他面色平静，声音中带着不满。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan10", "zui9"});
        yield return _gameMethods.OpenDialog(7336); // "它很弱，没有任何价值。即便再专注地去照料，也毫无..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan10", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(7337); // "「嗯…{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan2", "zui19"});
        yield return _gameMethods.OpenDialog(7338); // "可是它毛茸茸软绵绵的，{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan11", "zui20"});
        yield return _gameMethods.OpenDialog(7339); // "很可爱啊。」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan9", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan11", "zui6"});
        yield return _gameMethods.OpenDialog(7340); // "他扬起眉，对此嗤之以鼻。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan25", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
        yield return _gameMethods.OpenDialog(7341); // "「皮毛只是它本体孱弱、缺乏抗寒能力的证明，{nw..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan27", "zui9"});
        yield return _gameMethods.OpenDialog(7342); // "至于肌肉软弱无力，这也能算是优点么？」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan27", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui9"});
        yield return _gameMethods.OpenDialog(7029); // "「呃……{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan2", "zui10"});
        yield return _gameMethods.OpenDialog(7343); // "确实。」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan10", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui14"});
        yield return _gameMethods.OpenDialog(7344); // "相较于鳞片，毛发在战斗中能起到的作用小得可怜。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan25", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(7345); // "当危险来临，它根本不可能保护你，只会影响你的行动..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan10", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10"});
        yield return _gameMethods.OpenDialog(7346); // "你说的没错。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.5f}, {"zpos", -50.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan9", "zui19"});
        yield return _gameMethods.OpenDialog(7347); // "「但，它毛茸茸软绵绵的，{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan11", "zui2", "emoji15"});
        yield return _gameMethods.OpenDialog(7348); // "摸起来实在太解压了。」"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -50.0f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei3", "yan9", "zui8", "emoji15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan24", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
        yield return _gameMethods.OpenDialog(7349); // "「哦。所以你又觉得它的皮毛也很顺滑，{nw}{w..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei18", "yan17", "zui20"});
        yield return _gameMethods.OpenDialog(7350); // "摸起来也能治愈人心？」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei18", "yan17", "zui3"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui7", "emoji12", "-emoji15"});
        yield return _gameMethods.OpenDialog(165); // "？"
        yield return _gameMethods.OpenDialog(7351); // "错觉吗，感觉这话是不是略有耳熟。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui3", "-emoji12"});
        yield return _gameMethods.OpenDialog(7352); // "「我挺喜欢兔子的，{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(7353); // "所以照顾它也不会感觉太麻烦。」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei18", "yan3", "zui3"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui14"});
        yield return _gameMethods.OpenDialog(7354); // "这句话的哪里似乎令他感到了不快。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei10", "yan27", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(7355); // "它有什么值得你喜欢的地方，无能、还是弱小？"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei10", "yan27", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui14"});
        yield return _gameMethods.OpenDialog(7356); // "我发现，赫泽尔似乎总喜欢用价值代替情感，用必要性..."
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan8", "zui10"});
        yield return _gameMethods.OpenDialog(7357); // "「“值得”吗……"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan9", "zui10"});
        yield return _gameMethods.OpenDialog(7358); // "喜欢这种东西，或许一开始需要一些条件，{nw}{..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei10", "yan22", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan12", "zui10"});
        yield return _gameMethods.OpenDialog(7359); // "比如柔软的皮毛和可爱的外表。」"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui19"});
        yield return _gameMethods.OpenDialog(7360); // "但是感情一旦诞生，它就会自发地产生能量的。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan29", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan23", "zui19"});
        yield return _gameMethods.OpenDialog(7361); // "如果这只兔子对我已经成为了一个特别的存在。"
        Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan17", "zui20"});
        yield return _gameMethods.OpenDialog(7362); // "它就不需要通过持续提供某种利用价值，才能维持我对..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan25", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan17", "zui7"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan29", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui6"});
        yield return _gameMethods.OpenDialog(7363); // "赫泽尔陷入了长长的沉默。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7364); // "他沉默了一会儿，"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan27", "zui21"});
        yield return _gameMethods.OpenDialog(7365); // "又沉默了一会儿，"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan25", "zui2"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan17", "zui2"});
        yield return _gameMethods.OpenDialog(7366); // "最后似乎很不高兴地开口。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan17", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(7367); // "既然如此，为什么偏偏是这只兔子，而不是别的东西。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan17", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan25", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/moca1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -50.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.8f}, {"zpos", 0.0f}})});
        yield return _gameMethods.Show("shuben", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 400.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.7f}, {"ypos", 500.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui15"});
        yield return _gameMethods.OpenDialog(696); // "我明白了。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}})});
        yield return _gameMethods.Show("shuben", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 500.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan24", "zui7", "emoji2"});
        yield return _gameMethods.OpenDialog(7368); // "龙，还真是一种占有欲强烈的生物呢。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui19", "-emoji2"});
        yield return _gameMethods.OpenDialog(7369); // "我只是在说“如果”而已。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(7370); // "但实际上，我并没有爱上它呀。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan27", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan5", "zui6"});
        yield return _gameMethods.OpenDialog(7371); // "你刚刚说，你挺喜欢兔子的。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan27", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui10"});
        yield return _gameMethods.OpenDialog(7372); // "「只是稍微有一点喜欢，{nw}{w=0.01}"
        Defaults.Haogandu_he = Defaults.Haogandu_he + 2;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan12", "zui19", "emoji9"});
        yield return _gameMethods.OpenDialog(7373); // "大概有我对赫泽尔的喜欢程度的百分之一吧。」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan29", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei3", "yan12", "zui8"});
        yield return _gameMethods.OpenDialog(4400); // "「……{nw}{w=0.2}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan25", "zui2"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan15", "zui2"});
        yield return _gameMethods.OpenDialog(1265); // "……」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan15", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui10", "-emoji9"});
        yield return _gameMethods.OpenDialog(7374); // "「如果你讨厌这只兔子，{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan23", "zui19"});
        yield return _gameMethods.OpenDialog(7375); // "那我就把它放到你视线外的地方……？」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan15", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan23", "zui7"});
        yield return _gameMethods.OpenDialog(1313); // "不用。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan25", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(7376); // "我从不在乎弱者。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan15", "zui3"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan23", "zui2"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan27", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei4", "yan14", "zui11"});
        yield return _gameMethods.OpenDialog(7377); // "「不愧是赫泽尔大人，"
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/demo_audio/sound/zhenjing_shuaidaoganjue.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0.0f}, {"parallel_1", true}})});
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei4", "yan25", "zui12", "emoji2"});
        yield return _gameMethods.OpenDialog(7378); // "太成熟了，"
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/moca1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0.0f}, {"parallel_1", true}})});
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei4", "yan25", "zui2", "-emoji2", "emoji8", "emoji7"});
        yield return _gameMethods.OpenDialog(7379); // "这就是强者的风范吧！」"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"yoffset", 0.0f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui19"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei4", "yan25", "zui8", "-emoji8"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan28", "zui19"});
        yield return _gameMethods.OpenDialog(7380); // "他没有对我的赞美做出回应，满意地继续读书了。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/book1.mp3");
        yield return _gameMethods.Hide("he");
        yield return _gameMethods.Hide("heilong_shufang_baitian_shafa");
        yield return _gameMethods.Show("shuben", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 500.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.9f}, {"ypos", 400.0f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(7381); // "之后也没有再管我摸兔子。"
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.Hide("shuben");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.StopSound(channelName:"music1", fadeOut:10.0f);
        yield return _gameMethods.OpenDialog(7382); // "过了大概两周，这只兔子的腿伤总算痊愈了。"
        yield return _gameMethods.OpenDialog(7383); // "我把它放回了森林。\n希望它能活得久一点……说不..."
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.OpenDialog(21); // "…………"
        Defaults.Persistent.Jq_7_5 = 1;
        Defaults.Haogandu_an = Defaults.Haogandu_an + 1;
        yield return _gameMethods.OpenDialog(7384); // "天气渐渐转凉，很快正式入秋了。"
        yield return _gameMethods.Scene("dajie4");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.PlaySound("soundc", 1.0f, 1.0f, "audio/sound/emeng_dajie/Town Crow_01.ogg");
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.PlaySound("music", 0.0f, 0.7f, "audio/music/chumen1.mp3");
        yield return _gameMethods.OpenDialog(7385); // "我和赫泽尔又一次来到了山脚下那个小镇，进行秋季采..."
        yield return _gameMethods.OpenDialog(7386); // "这两年半里，我们每隔几个月都要来采购一次。\n由..."
        yield return _gameMethods.OpenDialog(7387); // "一来二去的，和店主们也算是混成了熟人。"
        yield return _gameMethods.Scene("dajie1_1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.27f)}, {"zoom", 0.91f}})});
        yield return _gameMethods.TransitionBy("trans_rip_fast");
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(0.0f, 0.0f)}, {"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.7f}, {"pos", new Vector2(342.0f, 0.0f)}, {"zpos", -348.0f}})});
        yield return _gameMethods.Show("dajie1_1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.5f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.3f}, {"blur", 3.0f}})});
        yield return _gameMethods.Show("npc_nanhai0", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.73f, 0.94f)}, {"zoom", 0.15f}, {"alpha", 0.0f}, {"zpos", 10.0f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.5f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.3f}, {"alpha", 1.0f}})});
        yield return _gameMethods.OpenDialog(7388); // "卖土豆的摊子由一个大约十七八岁、脸上带着雀斑的小..."
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(342.0f, 0.0f)}, {"zpos", -348.0f}})});
        yield return _gameMethods.Show("dajie1_1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 3.0f}})});
        yield return _gameMethods.Show("npc_nanhai0", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        yield return _gameMethods.OpenDialog(7389); // "这是个挺青涩的年轻人，性格内向害羞，向外展露出一..."
        yield return _gameMethods.OpenDialog(7390); // "……不知道为什么，总感觉他今天欲言又止，思虑重重..."
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(924); // "……？"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7391); // "是有心事吗？"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui15"});
        yield return _gameMethods.OpenDialog(7392); // "……嗯，上次来时，他好像提到过自己相依为命的爷爷..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7393); // "但他看起来倒也不似悲伤啊，更像紧张。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui1"});
        yield return _gameMethods.OpenDialog(7394); // "你爷爷身体好些了吗？"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/zhenjing_shuaidaoganjue.mp3");
        yield return _gameMethods.Show("npc_nanhai0", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"xoffset", -1.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 1.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0.0f}, {"parallel_1", true}})});
        yield return _gameMethods.ExecuteCharacterImageData("x_nv", parts: new List<string>{"mei7", "yan2", "zui6"});
        yield return _gameMethods.OpenDialog(7395); // "啊……是！"
        yield return _gameMethods.Show("npc_nanhai0", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"yoffset", 0.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7396); // "摊主顿时像是有些受宠若惊一般，涨红了脸，结结巴巴..."
        yield return _gameMethods.ExecuteCharacterImageData("x_nv");
        yield return _gameMethods.OpenDialog(7397); // "是的，已经健朗多了。多谢您的关心。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui1"});
        yield return _gameMethods.OpenDialog(7398); // "那就太好了。"
        yield return _gameMethods.OpenDialog(7399); // "请替我向他问好。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan11", "zui6"});
        yield return _gameMethods.OpenDialog(7400); // "他用力点点头，——忽然闭了闭眼睛，似乎下定了某种..."
        yield return _gameMethods.Hide("npc_nanhai0");
        yield return _gameMethods.Show("npc_nanhai", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.73f, 0.94f)}, {"zoom", 0.15f}, {"zpos", 10.0f}})});
        yield return _gameMethods.TransitionBy("blink2");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(7401); // "从摊子的铺面底下抽出了一枝玫瑰，眼也不敢睁。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 4.0f, "audio/sound/manbu/Body1_02_duan.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 294.0f}, {"zpos", -528.0f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(7402); // "就这么直戳戳地送到了我的面前。"
        yield return _gameMethods.ExecuteCharacterImageData("x_qian");
        yield return _gameMethods.OpenDialog(7403); // "「这、"
        yield return _gameMethods.Show("npc_nanhai", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"xoffset", -2.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 2.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0.0f}, {"parallel_1", true}})});
        yield return _gameMethods.OpenDialog(7404); // "这个送给您……！\n我想说——，呃，你很美。」"
        yield return _gameMethods.Show("npc_nanhai", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"yoffset", 0.0f}})});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(7405); // "买完了？"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 294.0f}, {"zpos", -528.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.8f}, {"xpos", 186.0f}, {"zpos", -342.0f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan27", "zui9"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 20.0f}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(732.0f, 1308.0f)}, {"zoom", 0.33f}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}, {"blur", 0.01f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.2f}, {"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan4", "zui15"});
        yield return _gameMethods.OpenDialog(7406); // "赫泽尔忽然问。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan27", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 186.0f}, {"zpos", -342.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan4", "zui19"});
        yield return _gameMethods.OpenDialog(7407); // "快了快了。"
        yield return _gameMethods.PlaySound("sound", 0.2f, 0.4f, "audio/demo_audio/sound/moca2.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 186.0f}, {"zpos", -342.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.6f}, {"xpos", 294.0f}, {"zpos", -360.0f}})});
        yield return _gameMethods.Show("he", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}, {"blur", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 0.0f}, {"blur", 0.01f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui6"});
        yield return _gameMethods.OpenDialog(7408); // "我回头对摊主微笑。"
        yield return _gameMethods.Show("he", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}, {"blur", 0.01f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 294.0f}, {"zpos", -360.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan11", "zui19", "-emoji2"});
        yield return _gameMethods.OpenDialog(7409); // "「谢谢你，{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei1", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(7410); // "可对不起，我不能收。」"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(7411); // "那个年轻人顿时像被浇了盆冷水，又生怕被误解一般，..."
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.5>audio/sound/jiaobusheng_xin_normal1.ogg");
        yield return _gameMethods.Show("npc_nanhai", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.94f}, {"zpos", 10.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.4f}, {"ypos", 0.96f}, {"zpos", 58.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("x_nv");
        yield return _gameMethods.OpenDialog(7412); // "为什么？那个，我没有别的意思——"
        yield return _gameMethods.Show("npc_nanhai", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.96f}, {"zpos", 58.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan2", "zui19"});
        yield return _gameMethods.OpenDialog(7413); // "「因为我已经收到了比这朵玫瑰更宝贵的东西，{nw..."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan11", "zui2"});
        yield return _gameMethods.OpenDialog(7414); // "那就是你的心意。谢谢你，我很高兴。」"
        yield return _gameMethods.ExecuteCharacterImageData("x_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
        yield return _gameMethods.OpenDialog(7415); // "哦，好吧……"
        yield return _gameMethods.PlaySound("sound", 0.2f, 0.4f, "audio/demo_audio/sound/moca2.mp3");
        yield return _gameMethods.Show("npc_nanhai", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 58.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.5f}, {"zpos", 28.0f}})});
        yield return _gameMethods.Show("npc_nanhai0", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 28.0f}, {"alpha", 0.0f}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.73f, 0.96f)}, {"zoom", 0.15f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.5f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"alpha", 1.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(7416); // "他的脸又有些红了，带着一些小尴尬地把那朵花收了回..."
        yield return _gameMethods.Hide("npc_nanhai");
        yield return _gameMethods.Hide("he");
        yield return _gameMethods.Show("npc_nanhai0", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7417); // "只是又给我多塞了很多土豆。"
        yield return _gameMethods.ExecuteCharacterImageData("x_nv");
        yield return _gameMethods.OpenDialog(7418); // "下次再来。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 2.0f, "<from 0 to 1>audio/demo_audio/sound/zu3_nv_zou.ogg");
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan25", "zui12"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 35.0f}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(732.0f, 1308.0f)}, {"zoom", 0.33f}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}, {"blur", 0.01f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.2f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 294.0f}, {"zpos", -360.0f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.5f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.6f}, {"xpos", 96.0f}, {"zpos", -348.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(7419); // "没有下次了。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 96.0f}, {"zpos", -348.0f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan27", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan7", "zui18", "emoji2"});
        yield return _gameMethods.OpenDialog(7420); // "赫泽尔突然开口。"
        yield return _gameMethods.ExecuteCharacterImageData("x_nv");
        yield return _gameMethods.OpenDialog(4920); // "啊？"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan3", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(7421); // "下次，我们会换一家店购买土豆。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 3.0f, "audio/sound/manbu/Body1_02_duan.mp3");
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan3", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 35.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.3f}, {"zpos", 59.0f}})});
        yield return _gameMethods.OpenDialog(7422); // "赫泽尔面无表情地说，{nw}{w=0.01}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan10", "zui2"});
        yield return _gameMethods.OpenDialog(7423); // "拉着我转身。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan25", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 59.0f}})});
        yield return _gameMethods.OpenDialog(7424); // "临走之前，{nw}{w=0.01}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan16", "zui2"});
        yield return _gameMethods.OpenDialog(7425); // "他居高临下地瞥了对方一眼。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan16", "zui9"});
        yield return _gameMethods.OpenDialog(7426); // "你太聒噪了。"
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<from 0 to 1.5>audio/sound/jiaobusheng_xin_normal1.ogg");
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(7427); // "说罢，他迈开步伐，扯着我离开了。"
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:5.0f);
        yield return _gameMethods.EngineSetVolume(volume:0.2f, delay:5.0f, channelName:"soundc");
        yield return _gameMethods.Scene("dajie1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.63f, 1.47f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 1.27f}})});
        yield return _gameMethods.TransitionBy("trans_rip_fast");
        yield return _gameMethods.OpenDialog(7428); // "远离那个摊铺后，我们一人一龙走在路上。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan7", "zui18", "emoji2"});
        yield return _gameMethods.OpenDialog(7429); // "气氛有些尴尬。我不知道该说点什么，于是保持沉默。"
        yield return _gameMethods.PlaySound("music1", 3.0f, 0.7f, "audio/music/PerituneMaterial_Guitar_Gentle_loop.mp3");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(7430); // "刚刚那个年轻的男孩……那朵玫瑰，应该是他好不容易..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7431); // "土豆是境况最贫苦的人们才会吃的食物。而卖土豆的人..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan20", "zui15"});
        yield return _gameMethods.OpenDialog(7432); // "那只年轻却带着粗茧、皲裂与冻疮的手，是卖掉了多少..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui18"});
        yield return _gameMethods.OpenDialog(7433); // "……但是我不能接。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(7434); // "原因有很多。不能回报心意，就不要给错误的信号。更..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(7435); // "如果他能把玫瑰卖掉，换回一点钱就好了。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan17", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.62f, 3.25f)}, {"zoom", 0.67f}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}, {"blur", 0.1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.0f}, {"xpos", 78.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan7", "zui18"});
        yield return _gameMethods.OpenDialog(7436); // "……最重要的是，赫泽尔已经明显很不快了。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan17", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan21", "zui18", "emoji2"});
        yield return _gameMethods.OpenDialog(7437); // "如果他不高兴，无论是我，还是那个卖土豆的男孩，都..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan20", "zui18", "-emoji2"});
        yield return _gameMethods.OpenDialog(7438); // "况且，相较于获得了他一定喜爱的我，更有可能遭到迁..."
        yield return _gameMethods.EngineSetVolume(volume:1.0f, delay:2.0f, channelName:"soundc");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 78.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 3.0f}, {"xpos", 492.0f}})});
        yield return _gameMethods.Show("he", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 1.0f}, {"alpha", 0.0f}, {"blur", 0.1f}})});
        yield return _gameMethods.OpenDialog(7439); // "……在我们默默走路的同时，道路两边、一些同我已经..."
        yield return _gameMethods.OpenDialog(7440); // "小姑娘又来买东西呀？"
        yield return _gameMethods.OpenDialog(7441); // "我勉力提起精神，微笑回应。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19", "emoji2"});
        yield return _gameMethods.OpenDialog(7442); // "是呀。大叔今天生意不错。"
        yield return _gameMethods.Hide("he");
        yield return _gameMethods.ExecuteCharacterImageData("i_nv", parts: new List<string>{"mei7", "yan5", "zui6"});
        yield return _gameMethods.OpenDialog(7443); // "借你吉言，哈哈！"
        yield return _gameMethods.ExecuteCharacterImageData("j_nv");
        yield return _gameMethods.OpenDialog(7444); // "哟，小姐您来啦？"
        yield return _gameMethods.ExecuteCharacterImageData("j_nv");
        yield return _gameMethods.OpenDialog(7445); // "谢谢你上次给的药方，我奶奶今年身体好多了。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui2", "-emoji2"});
        yield return _gameMethods.OpenDialog(7446); // "哈哈，我们那儿都是这么疗养的。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 492.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan11", "zui6"});
        yield return _gameMethods.OpenDialog(7447); // "我笑着和他们寒暄了几句，在这友好融洽的氛围中，心..."
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.5>audio/demo_audio/sound/zu3_nv_zou.ogg");
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan27", "zui9"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(1128.0f, 2124.0f)}, {"zoom", 0.61f}, {"zpos", 10.0f}, {"alpha", 0.0f}, {"blur", 0.01f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"blur", 0.0f}, {"alpha", 1.0f}})});
        yield return _gameMethods.OpenDialog(7448); // "你一定要跟他们说话吗？"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan27", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}, {"alpha", 1.0f}})});
        yield return _gameMethods.OpenDialog(7449); // "身边的赫泽尔忽然开口。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui14"});
        yield return _gameMethods.OpenDialog(975); // "嗯？"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan22", "zui21"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(7450); // "他们有什么价值，值得你对他们笑。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan22", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan6", "zui10"});
        yield return _gameMethods.OpenDialog(7029); // "「呃……{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan2", "zui19"});
        yield return _gameMethods.OpenDialog(7451); // "这只是很普通的人际交往呀。」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan3", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
        yield return _gameMethods.OpenDialog(7452); // "普通？你以前也是这么和别人相处的？"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan5", "zui3"});
        yield return _gameMethods.OpenDialog(7453); // "「差、{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan11", "zui1", "emoji2"});
        yield return _gameMethods.OpenDialog(7454); // "差不多……？」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan24", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan11", "zui6"});
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(7455); // "他不说话了，忽然盯着我，赤红的眼瞳直勾勾的，让人..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan2", "zui18"});
        yield return _gameMethods.OpenDialog(7456); // "……我瞬间福至心灵，在求生欲的作用下大力补救。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/moca1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0.0f}, {"parallel_1", true}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei4", "yan5", "zui11"});
        yield return _gameMethods.OpenDialog(7457); // "不过当然！这些都只是出于礼貌。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"yoffset", 0.0f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan25", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei4", "yan12", "zui2"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan24", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
        yield return _gameMethods.OpenDialog(7458); // "「那些人都仅仅是我生命中的过客，{nw}{w=0..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan27", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan2", "zui2"});
        yield return _gameMethods.OpenDialog(7459); // "而我最重要的存在，{nw}{w=0.01}"
        Defaults.Haogandu_he = Defaults.Haogandu_he + 2;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(7460); // "当然是赫泽尔啦！」"
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei3", "yan5", "zui8"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan25", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7461); // "他沉寂一会，{nw}{w=0.01}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan17", "zui2"});
        yield return _gameMethods.OpenDialog(7462); // "撇过了头，从鼻腔里轻嗤出声。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan25", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan12", "zui10"});
        yield return _gameMethods.OpenDialog(7463); // "这里的所有人类，全部都弱小得不值一提。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan17", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(7464); // "哪怕是护城的军队，也用不上我一成力气。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan17", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19", "emoji2"});
        yield return _gameMethods.OpenDialog(7465); // "哈哈……毕竟大家只是普通人类嘛。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui19", "-emoji2"});
        yield return _gameMethods.OpenDialog(7466); // "当然比不上龙族强大。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan27", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(7467); // "你似乎对那种羸弱的生物情有独钟。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan27", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui10"});
        yield return _gameMethods.OpenDialog(7468); // "「……呃。{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan2", "zui9"});
        yield return _gameMethods.OpenDialog(7469); // "也不是情有独钟……」"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui2"});
        yield return _gameMethods.OpenDialog(7470); // "赫泽尔，你说过伪装是弱者的生存技巧对吧。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan29", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei3", "yan5", "zui8", "-emoji2"});
        yield return _gameMethods.OpenDialog(165); // "？"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(602); // "……嗯。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui19", "emoji2"});
        yield return _gameMethods.OpenDialog(7471); // "合群，也是弱者为了生存而发展出的本领啊。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19", "-emoji2"});
        yield return _gameMethods.OpenDialog(7472); // "我从小就是依靠这种方式活下来的。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan5", "zui8"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.StopSound(channelName:"music1", fadeOut:8.0f);
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.5>audio/demo_audio/sound/zu3_nv_zou.ogg");
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 10.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.40f}, {"zpos", 46.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
        yield return _gameMethods.OpenDialog(7473); // "「那么，现在你没必要再和那些人合群了，{nw}{..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui9"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 46.0f}})});
        yield return _gameMethods.OpenDialog(7474); // "因为我会庇护你。」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui6"});
        yield return _gameMethods.OpenDialog(7475); // "真的吗。"
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.StopSound(channelName:"soundc", fadeOut:1.0f);
        yield return _gameMethods.PlaySound("sound", 0.0f, 3.0f, "audio/sound/manbu/Body1_02_duan.mp3");
        yield return _gameMethods.Show("guangjie_layered", parts: new List<string>{"nv_yan2", "nv_zui2", "he_zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(492.0f, 6.0f)}, {"anchor", new Vector2(0.0f, 0.0f)}, {"zoom", 0.51f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 130.0f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.4f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 2.5f}, {"zpos", 46.0f}})});
        Defaults.Gui_duihuakuang_you = 0;
        yield return _gameMethods.Show("2-22_zoom1");
        yield return _gameMethods.Hide("2-22_zoom1");
        yield return _gameMethods.TransitionWithFadeIn(outTime:0.2f, holdTime:0.2f, inTime:1.3f, colorCode:"#fff");
        yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/music/gentle1.mp3");
        yield return _gameMethods.OpenDialog(7476); // "我忽然伸出双手，大力地挽住了男孩一边的胳膊，身体..."
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/moca1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0.0f}, {"parallel_1", true}})});
        yield return _gameMethods.OpenDialog(468); // "……？！"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"yoffset", 0.0f}})});
        yield return _gameMethods.OpenDialog(7477); // "他睁大眼睛，在我的臂弯里，像一只忽然被人类紧急贴..."
        yield return _gameMethods.Show("guangjie_layered", parts: new List<string>{"nv_zui3"});
        yield return _gameMethods.OpenDialog(7478); // "好，那我就全靠伟大的赫泽尔大人了！"
        yield return _gameMethods.Show("guangjie_layered", parts: new List<string>{"nv_zui2"});
        yield return _gameMethods.OpenDialog(7479); // "我大声宣布，对这个有些错愕的孩子回以满面笑容。"
        yield return _gameMethods.Show("guangjie_layered", parts: new List<string>{"nv_zui3", "nv_yan3"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 46.0f}})});
        Defaults.Haogandu_he = Defaults.Haogandu_he + 2;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.OpenDialog(7480); // "你看，这样就能让所有人都看到，我们两个很亲密了！"
        yield return _gameMethods.Show("guangjie_layered", parts: new List<string>{"nv_zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_qian");
        yield return _gameMethods.OpenDialog(7481); // "「…………{nw}{w=0.2}"
        yield return _gameMethods.Show("guangjie_layered", parts: new List<string>{"he_zui1"});
        yield return _gameMethods.OpenDialog(7273); // "唔。」"
        yield return _gameMethods.OpenDialog(7482); // "他的身体僵硬片刻，迟疑地逐渐松弛。"
        yield return _gameMethods.Show("guangjie_layered", parts: new List<string>{"he_yan2"});
        yield return _gameMethods.OpenDialog(602); // "……嗯。"
        yield return _gameMethods.Show("guangjie_layered", parts: new List<string>{"he_zui2"});
        yield return _gameMethods.OpenDialog(7483); // "你和他们聊天时，看起来很开心。"
        yield return _gameMethods.Show("guangjie_layered", parts: new List<string>{"nv_yan2", "nv_zui1", "he_zui1"});
        yield return _gameMethods.OpenDialog(7484); // "有吗？"
        yield return _gameMethods.Show("guangjie_layered", parts: new List<string>{"nv_zui2", "he_zui2", "he_yan3"});
        yield return _gameMethods.OpenDialog(7485); // "你笑得很愉快。"
        yield return _gameMethods.Show("guangjie_layered", parts: new List<string>{"he_zui1"});
        yield return _gameMethods.OpenDialog(7486); // "笑起来并不代表开心啊。进入社会后的人，就是学会在..."
        yield return _gameMethods.OpenDialog(7487); // "……虽然的确是和那些店主聊天更轻松。毕竟他们都是..."
        yield return _gameMethods.Show("guangjie_layered", parts: new List<string>{"nv_zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv2_qian");
        yield return _gameMethods.OpenDialog(7488); // "「……虽然和他们聊天确实还算愉快，{nw}{w=..."
        yield return _gameMethods.Show("guangjie_layered", parts: new List<string>{"nv_zui2", "nv_yan3"});
        Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.OpenDialog(7489); // "但是，如果赫泽尔不高兴，那我也不高兴。」"
        yield return _gameMethods.Show("guangjie_layered", parts: new List<string>{"nv_zui2"});
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.OpenDialog(7490); // "赫泽尔没有回答我。"
        yield return _gameMethods.Show("guangjie_layered", parts: new List<string>{"nv_yan2", "he_yan2"});
        yield return _gameMethods.OpenDialog(7491); // "他少见地微微低垂下头，不知在想什么。"
        yield return _gameMethods.OpenDialog(7492); // "黑色额发的阴影遮住了那双低垂的眼睛，让人辨认不出..."
        yield return _gameMethods.PlaySound("sound", 0.0f, 2.0f, "audio/sound/manbu/Body1_02_duan.mp3");
        yield return _gameMethods.Show("guangjie_layered1", parts: new List<string>{"nv_yan1", "nv_zui2", "he_zui1", "he_yan2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}, {"zpos", 46.0f}, {"pos", new Vector2(492.0f, 6.0f)}, {"anchor", new Vector2(0.0f, 0.0f)}, {"zoom", 0.51f}, {"blur", 0.01f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.7f}, {"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.OpenDialog(7493); // "我忽然感觉到……自己挽着他手臂的那只手，被另一只..."
        yield return _gameMethods.Hide("guangjie_layered");
        yield return _gameMethods.Show("guangjie_layered1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.OpenDialog(7494); // "赫泽尔把我的手从他的胳膊上拿下，却是反掌抓紧了我..."
        yield return _gameMethods.OpenDialog(7495); // "指节收起，手指插入了我五指的指缝。\n十指交缠，..."
        yield return _gameMethods.OpenDialog(7496); // "这种密不透风的握法，就像要把对方牢牢地攥在自己的..."
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.OpenDialog(7497); // "他的情绪看起来不高，不开心吗？"
        yield return _gameMethods.Show("guangjie_layered1", parts: new List<string>{"nv_yan2"});
        yield return _gameMethods.OpenDialog(7498); // "是不是该再说几句哄他开心一些。"
        yield return _gameMethods.Show("guangjie_layered1", parts: new List<string>{"nv_zui1"});
        yield return _gameMethods.OpenDialog(7499); // "其实，你没必要在意那些人。"
        yield return _gameMethods.Show("guangjie_layered1", parts: new List<string>{"nv_zui2"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("guangjie_layered1", parts: new List<string>{"he_yan3"});
        yield return _gameMethods.OpenDialog(7500); // "赫泽尔抬眸看了过来。"
        yield return _gameMethods.Show("guangjie_layered1", parts: new List<string>{"nv_zui1"});
        yield return _gameMethods.OpenDialog(7501); // "他们根本无法与你相提并论。"
        yield return _gameMethods.Show("guangjie_layered1", parts: new List<string>{"nv_yan3"});
        yield return _gameMethods.OpenDialog(7502); // "因为我们两个，已经被紧紧地捆绑在一起了。"
        yield return _gameMethods.Show("guangjie_layered1", parts: new List<string>{"nv_zui2", "he_zui2"});
        yield return _gameMethods.OpenDialog(7503); // "捆绑在一起。"
        yield return _gameMethods.OpenDialog(7504); // "被什么？"
        yield return _gameMethods.Show("guangjie_layered1", parts: new List<string>{"he_zui1"});
        yield return _gameMethods.OpenDialog(7505); // "……您完全听不懂修辞是吗。"
        yield return _gameMethods.OpenSelectMenu(
            talk: new List<string>{"—命运"},
            jump: new List<string>{"label_zhuxian5_menu_2_mvgqASuL"},
            condition: new List<string>{"NONE"}
        );
    }

    public IEnumerator label_mingyun()
    {
        yield return _gameMethods.PlaySound("sound", 0.0f, 3.0f, "audio/sound/manbu/Body1_02_duan.mp3");
        yield return _gameMethods.Hide("guangjie_layered1");
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        Defaults.Gui_duihuakuang_you = 1;
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui9"});
        yield return _gameMethods.OpenDialog(7507); // "「被……"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan8", "zui9"});
        yield return _gameMethods.OpenDialog(7508); // "被……"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan5", "zui1"});
        yield return _gameMethods.OpenDialog(7509); // "命运？」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan29", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan2", "zui2"});
        yield return _gameMethods.OpenDialog(7510); // "我们可是预言中记载，注定要相遇、相识，一起相伴生..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan29", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei3", "yan5", "zui8"});
        yield return _gameMethods.OpenDialog(7511); // "……命运……"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan29", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei5", "yan12", "zui19"});
        yield return _gameMethods.OpenDialog(7512); // "是的，我们之间存在牢牢的羁绊。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei5", "yan12", "zui6"});
        yield return _gameMethods.OpenDialog(7513); // "牢不可破的羁绊。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan12", "zui6", "emoji2"});
        yield return _gameMethods.OpenDialog(7514); // "……怎么还自动升级了。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui8", "-emoji2"});
        yield return _gameMethods.OpenDialog(7515); // "不过，看起来，这话确实有效。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7516); // "我乘胜追击。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei53yan2", "zui2"});
        yield return _gameMethods.OpenDialog(7517); // "「你看，世界上有那么多龙，那么多公主，{nw}{..."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan8", "zui2"});
        yield return _gameMethods.OpenDialog(7518); // "偏偏是我会被你带走，成为你的…"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan12", "zui2"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan8", "zui2"});
        yield return _gameMethods.OpenDialog(7519); // "呃，{nw}{w=0.01}"
        Defaults.Haogandu_he = Defaults.Haogandu_he + 3;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan5", "zui2"});
        yield return _gameMethods.OpenDialog(7520); // "家人，"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(7521); // "这怎么不算是一种缘分呢？」"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui19"});
        yield return _gameMethods.OpenDialog(7522); // "所以不要在意他们了。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(4368); // "好。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan25", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan15", "zui3"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(7523); // "赫泽尔回答，{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(7524); // "依旧没有松开五指，紧紧抓握着我的手。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(7525); // "从他的声音和表情中，很难分辨他的心情到底有没有放..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui6"});
        yield return _gameMethods.OpenDialog(7526); // "嗯……随他开心吧。"
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:8.0f);
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.Scene("woshi_nv2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(564.0f, 792.0f)}, {"zoom", 0.61f}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/demo_audio/sound/door_close1.mp3");
        yield return _gameMethods.TransitionBy("trans_rip_fast");
        yield return _gameMethods.OpenDialog(7527); // "我们完成采购，回到了城堡。"
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.Show("woshi_nv4", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(564.0f, 792.0f)}, {"zoom", 0.61f}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.7f}, {"alpha", 1.0f}})});
        yield return _gameMethods.PlaySound("music1", 4.0f, 1.0f, "audio/demo_audio/music/richang1.mp3");
        Defaults.Haogandu_an = Defaults.Haogandu_an + 1;
        yield return _gameMethods.OpenDialog(7528); // "十一月的脚步临近。"
        yield return _gameMethods.Hide("woshi_nv2");
        yield return _gameMethods.Show("woshi_nv4", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        if (Defaults.Bai_xue == 1)
        {
            yield return _gameMethods.ChangeLabelTo("label_bai_about_nvwang");
        }
        if (Defaults.Bai_xue == 0)
        {
            yield return _gameMethods.ChangeLabelTo("label_he_StudyWords");
        }
        yield break;
    }

    public IEnumerator label_he_StudyWords()
    {
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/ding1.mp3");
        Defaults.Persistent.Jq_8_1 = 1;
        Defaults.Haogandu_an = Defaults.Haogandu_an + 1;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui6"});
        yield return _gameMethods.OpenDialog(7529); // "这段时间里，{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan5", "zui6"});
        yield return _gameMethods.OpenDialog(7530); // "我对于真言的学习已经初具成效。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui8"});
        yield return _gameMethods.OpenDialog(7531); // "现在，我至少掌握了接近两百个词汇。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7532); // "这个数字听起来似乎不多，但在真言的体系中，便已囊..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan6", "zui7"});
        yield return _gameMethods.OpenDialog(7533); // "之前，我背着赫泽尔，私下里尝试魔法，企图通过应用..."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan8", "zui15", "emoji1", "emoji2"});
        yield return _gameMethods.OpenDialog(7534); // "但却毫无悬念地失败了。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(7535); // "这其中固然有我被这个世界所排斥的可能性，{nw}..."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan5", "zui15", "-emoji1", "-emoji2"});
        yield return _gameMethods.OpenDialog(7536); // "但我想，还有一个重要的原因。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7537); // "那便是真言词汇在语义上的多重性。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan6", "zui15"});
        yield return _gameMethods.OpenDialog(7538); // "或许，我必须设计一个句子，即一句咒语。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7539); // "——用好几个词汇来相互交织、互为条件、彼此定义，..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan20", "zui15"});
        yield return _gameMethods.OpenDialog(7540); // "也就是，制造者最终希望呈现出的魔法。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7541); // "老实说，我觉得这个世界的普通魔法师，应该拥有更简..."
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7542); // "毕竟，根据我从赫泽尔那里听到的说法，{nw}{w..."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan20", "zui15"});
        yield return _gameMethods.OpenDialog(7543); // "真言对于大多数智慧生物，其实都具备一种精神上的破..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7544); // "它是一种接近世界或宇宙真理一般的存在。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7545); // "当人类接触到这种不可名状的知识时，{nw}{w=..."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan6", "zui15"});
        yield return _gameMethods.OpenDialog(7546); // "必须谨慎、小心，寸步为营，{nw}{w=0.01..."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan6", "zui15"});
        yield return _gameMethods.OpenDialog(7547); // "否则很容易便会产生幻觉，乃至陷入疯狂。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(7548); // "……但，大概也是我来自另一个世界的原因。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan6", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(7549); // "虽然我很容易忘记知识，{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei8", "yan6", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(7550); // "但也同时拥有某种玄奥的免疫力，{nw}{w=0...."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei8", "yan8", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(7551); // "能够保护我，较快从异常的精神状态中清醒回来，恢复..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan20", "zui15"});
        yield return _gameMethods.OpenDialog(7552); // "至于具体有多快……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui8"});
        yield return _gameMethods.OpenDialog(7553); // "一般睡上一觉，就再次活蹦乱跳、无忧无虑了。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan24", "zui7", "emoji2"});
        yield return _gameMethods.OpenDialog(7554); // "这算什么。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan24", "zui7", "emoji2"});
        yield return _gameMethods.OpenDialog(7555); // "外来的和尚会念经？"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan3", "zui8", "-emoji2"});
        yield return _gameMethods.OpenDialog(7556); // "总之，常人一般在背下第10个单词时，就大概率精神..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan24", "zui16", "emoji2"});
        yield return _gameMethods.OpenDialog(7557); // "而我除了学得痛苦一点、每天都活得像个苦学的学生之..."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan24", "zui16", "emoji2"});
        yield return _gameMethods.OpenDialog(7558); // "顺利地摄入了大量知识，从未因此感到精神不振。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan12", "zui16", "emoji2"});
        yield return _gameMethods.OpenDialog(7559); // "每天晨起做的第一件事，就是把自己学会的那一百多个..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan7", "zui8", "emoji3", "emoji5", "emoji6", "emoji17", "-emoji2"});
        yield return _gameMethods.OpenDialog(7560); // "……我好像来异世界备战高考来了。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan9", "zui8", "-emoji3", "-emoji5", "emoji6", "-emoji17"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan6", "zui15", "-emoji6"});
        yield return _gameMethods.OpenDialog(7561); // "我觉得，也许我很快就能使用出魔法了。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan18", "zui15"});
        yield return _gameMethods.OpenDialog(7562); // "我渴望抓住更多的力量。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan18", "zui15"});
        yield return _gameMethods.OpenDialog(7563); // "想着或许这样，就能更进一步地握紧命运。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(7564); // "哪怕最后只是徒劳无功，{nw}{w=0.01}"
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 2;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan20", "zui15"});
        yield return _gameMethods.OpenDialog(7565); // "至少我已极尽挣扎。"
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.StopSound(channelName:"music1", fadeOut:5.0f);
        yield return _gameMethods.PlaySound("soundb", 0.0f, 1.0f, "audio/demo_audio/sound/niaoming.ogg");
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.Scene("woshi_nv2_tian");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Transition(time:0.5f);
        Defaults.Persistent.Jq_8_2 = 1;
        yield return _gameMethods.OpenDialog(7566); // "……不妙。大事不妙。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/xintiao.ogg");
        yield return _gameMethods.OpenDialog(7567); // "十一月的某一天，我躺在床上，感受着头顶传来的刺痛..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15", "emoji2", "emoji5"});
        yield return _gameMethods.OpenDialog(7568); // "昨天碰了冷水，结果今天偏头痛就提前来了。"
        yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:10.0f);
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan12", "zui15", "emoji2", "emoji5"});
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7569); // "明明这段时间里，由于营养供应充足，每个月已经不会..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui15", "emoji2", "emoji5"});
        yield return _gameMethods.OpenDialog(7570); // "结果这一次来势汹汹。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan20", "zui15", "emoji2", "emoji5"});
        yield return _gameMethods.OpenDialog(7571); // "脑袋里像塞进了一个音响，在里面疯狂跳动。"
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/demo_audio/sound/tangxia1.mp3");
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.PlaySound("music", 3.0f, 0.7f, "audio/music/wenxin/wind1.mp3");
        yield return _gameMethods.OpenDialog(7572); // "我宛如一滩烂泥，费劲地翻过身，强撑着把枕头垫在脑..."
        yield return _gameMethods.OpenDialog(7573); // "接着便如木头似的，面向下趴倒在床上。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/door_qiao2.ogg");
        yield return _gameMethods.OpenDialog(7574); // "咚。咚。"
        yield return _gameMethods.OpenDialog(7575); // "敲门声。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei6", "yan12", "zui16", "emoji2"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7576); // "我一动不动地装木头，试图伪造出没人在屋内的假象。"
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/demo_audio/sound/door_qiao2.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei6", "yan12", "zui8", "emoji16"});
        yield return _gameMethods.OpenDialog(1563); // "咚、咚。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan11", "zui15", "-emoji16"});
        yield return _gameMethods.OpenDialog(6326); // "……{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei8", "yan24", "zui15"});
        yield return _gameMethods.OpenDialog(7577); // "唉。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7578); // "是赫泽尔来了吧。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(7579); // "但我连爬起床给他开门的力气都没有。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan8", "zui10"});
        yield return _gameMethods.OpenDialog(7580); // "请进……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(7581); // "我把脸埋在枕头里，虚弱地开口。"
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/door_open_3.mp3");
        yield return _gameMethods.OpenDialog(7582); // "好在他耳聪目明，肯定听得见。{nw}{w=0.0..."
        yield return _gameMethods.PlaySound("sounda2", 1.0f, 1.0f, "<from 0 to 3>audio/demo_audio/sound/zu3_nv_zou.ogg");
        yield return _gameMethods.OpenDialog(7583); // "\n脚步声由远及近，最终停在床边。"
        yield return _gameMethods.OpenDialog(7584); // "安静了一阵子。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/tangxia1.mp3");
        yield return _gameMethods.Scene("woshi_nv_chuang", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.32f, 1.81f)}, {"zoom", 0.67f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan9", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 2.57f)}, {"zoom", 0.53f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(7585); // "我侧过身体，睁开眼，看到赫泽尔正垂眸望着我。"
        yield return _gameMethods.OpenDialog(7586); // "他微微皱着眉，俯视着有气无力的我，仿佛一个太过富..."
        yield return _gameMethods.OpenDialog(7587); // "那双赤红的眼瞳一寸一寸扫过我脸部的表情，像是吞咽..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("he_qian");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan9", "zui2"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei1", "yan21", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7588); // "我与他对视了一眼，恹恹地低下了头。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(7589); // "疼痛吞噬了我所有的活力……"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui2"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui9"});
        yield return _gameMethods.OpenDialog(7590); // "还有别的办法能消除你的痛苦吗？"
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:1.0f);
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2"});
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/zhenjing_shuaidaoganjue.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0.0f}, {"parallel_1", true}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei5", "yan1", "zui18", "emoji1", "emoji2"});
        yield return _gameMethods.OpenDialog(47); // "……！"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan2", "zui2"});
        yield return _gameMethods.PlaySound("sounda", 0.0f, 0.4f, "audio/sound/moca1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"yoffset", 0.0f}})});
        yield return _gameMethods.PlaySound("music1", 0.0f, 0.6f, "audio/demo_audio/music/PerituneMaterial_NoWay3_loop.mp3");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan25", "zui18", "emoji1", "emoji2"});
        yield return _gameMethods.OpenDialog(7591); // "哪怕在头痛之中，我也努力抬手，勉强地抓住了他的手..."
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan12", "zui18"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan25", "zui18"});
        yield return _gameMethods.OpenDialog(7592); // "他愣了一下，"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan28", "zui2"});
        yield return _gameMethods.OpenDialog(7593); // "望了望我们交叠的手指，"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.OpenDialog(7594); // "才朝我看来。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei5", "yan25", "zui9"});
        yield return _gameMethods.OpenDialog(7595); // "「没有别的办法了……"
        yield return _gameMethods.PlaySound("sound", 0.2f, 0.4f, "audio/demo_audio/sound/moca2.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}, {"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.4f}, {"ypos", -30.0f}, {"zpos", -54.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei5", "yan5", "zui13"});
        yield return _gameMethods.OpenDialog(7596); // "{sc=2}{size=+10}我只能用你做的道..."
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -30.0f}, {"zpos", -54.0f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei5", "yan5", "zui14"});
        yield return _gameMethods.OpenDialog(7597); // "「……嗯，{nw}{w=0.01}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui9"});
        yield return _gameMethods.OpenDialog(7598); // "我也缺乏这方面的知识。」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan25", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
        yield return _gameMethods.OpenDialog(7599); // "「而你的体力太弱了，{nw}{w=0.01}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei4", "yan27", "zui9"});
        yield return _gameMethods.OpenDialog(7600); // "你痛苦的情绪实在太过强烈。」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei4", "yan27", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan1", "zui16"});
        yield return _gameMethods.OpenDialog(7601); // "什么知识。什么体力。我是不是听不清他说话了。"
        yield return _gameMethods.OpenDialog(7602); // "我感觉自己有些眩晕。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei4", "yan9", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_qian");
        yield return _gameMethods.OpenDialog(6456); // "「……{nw}{w=0.01}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan14", "zui9"});
        yield return _gameMethods.OpenDialog(7603); // "你需要医师么。」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan14", "zui2"});
        yield return _gameMethods.OpenDialog(7604); // "他问道。大有我一旦点头，他就当场去找一个过来的架..."
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/moca1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -54.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.4f}, {"zpos", -78.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan24", "zui19"});
        yield return _gameMethods.OpenDialog(7605); // "不不，看医师也没什么用的吧。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -78.0f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan12", "zui6"});
        yield return _gameMethods.OpenDialog(7606); // "我好想念现代药物。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui6", "-emoji1", "-emoji2"});
        yield return _gameMethods.OpenDialog(7607); // "但这个世界毕竟没这种东西，就还是别再祸害人家无辜..."
        yield return _gameMethods.StopSound(channelName:"music1", fadeOut:5.0f);
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui19"});
        yield return _gameMethods.OpenDialog(7608); // "放我一个人呆一天就好了。明天我就会没事了。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.OpenDialog(7609); // "一阵安静。"
        yield return _gameMethods.PlaySound("sounda", 0.0f, 0.5f, "audio/demo_audio/sound/tangxia1.mp3");
        yield return _gameMethods.PlaySound("sounda1", 0.0f, 1.5f, "<silence 1>audio/sound/houhui/Grab Hand_01.mp3");
        yield return _gameMethods.Show("woshi_nv_chuang", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.04f, 1.38f)}})});
        yield return _gameMethods.Show("he", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 2.8f)}, {"zoom", 0.58f}})});
        yield return _gameMethods.TransitionBy("blink2");
        yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/demo_audio/music/richang2.mp3");
        yield return _gameMethods.OpenDialog(7610); // "感到旁边的被褥下陷，他已经坐在了床边，握起我的手..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_qian");
        yield return _gameMethods.OpenDialog(7611); // "「这样，{nw}{w=0.01}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
        yield return _gameMethods.OpenDialog(7612); // "能感觉好些么。」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(7613); // "说实话，没用。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui15"});
        yield return _gameMethods.OpenDialog(7614); // "但有人在身边表达出关心，陪我一起不开心，{nw}..."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan8", "zui7"});
        yield return _gameMethods.OpenDialog(7615); // "确实在心理上会更平衡一些。"
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui6"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui6"});
        yield return _gameMethods.OpenDialog(765); // "嗯。"
        yield return _gameMethods.Show("black");
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui2"});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(7616); // "于是，他继续握着我的手，没有动作了。"
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:4.0f);
        yield return _gameMethods.OpenDialog(7617); // "过了好一会儿，我听不到赫泽尔的动静，不知道他此时..."
        yield return _gameMethods.Hide("black");
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan33", "zui2"});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"matrixcolor", "InvertMatrix(0.0)*ContrastMatrix(0.79)*SaturationMatrix(1.09)*BrightnessMatrix(-0.24)*HueMatrix(0.0)"}, {"subpixel", true}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/houhui/Tight Face_02_duan.mp3");
        yield return _gameMethods.PlaySound("music1", 1.0f, 1.0f, "audio/demo_audio/music/guiyi1.mp3");
        yield return _gameMethods.OpenDialog(7618); // "这一眼让我毛骨悚然。"
        yield return _gameMethods.OpenDialog(7619); // "赫泽尔正注视着我头顶产生剧痛的地方。"
        yield return _gameMethods.OpenDialog(7620); // "背光的阴影之中，他的瞳仁竖成了一道细细的黑色竖线..."
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/moca1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -30.0f}, {"zpos", -78.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.13f}, {"ypos", -35.0f}, {"zpos", -90.0f}})});
        yield return _gameMethods.StopSound(channelName:"music1", fadeOut:4.0f);
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan1", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(7621); // "心下一突，{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei5", "yan5", "zui16"});
        yield return _gameMethods.OpenDialog(7622); // "我晃了晃他的手。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -35.0f}, {"zpos", -90.0f}}), new SameLineParamData(new Dictionary<string, object>{{"matrixcolor", "InvertMatrix(0.0)*ContrastMatrix(1.0)*SaturationMatrix(1.0)*BrightnessMatrix(0.0)*HueMatrix(0.0)"}, {"linear", 1.0f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7623); // "他转头看我。"
        Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui1"});
        yield return _gameMethods.OpenDialog(7624); // "和我说说话吧。"
        yield return _gameMethods.PlaySound("music", 3.0f, 1.0f, "audio/demo_audio/music/youshang2.mp3");
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui1"});
        yield return _gameMethods.OpenDialog(7625); // "讲讲你以前的故事，比如你之前和什么人有接触，有过..."
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"matrixcolor", "InvertMatrix(0.0)*ContrastMatrix(1.0)*SaturationMatrix(1.0)*BrightnessMatrix(0.0)*HueMatrix(0.0)"}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan11", "zui6"});
        yield return _gameMethods.OpenDialog(7626); // "「没有，{nw}{w=0.01}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
        yield return _gameMethods.OpenDialog(7627); // "我对人类没有过多的兴趣。」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui3", "-emoji2"});
        yield return _gameMethods.OpenDialog(7628); // "可是，既然你能看到人类激烈痛苦下的记忆，应该也是..."
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui2"});
        yield return _gameMethods.OpenDialog(7629); // "或者，比如说，这座城堡是怎么来的呢？"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan28", "zui21"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui2"});
        yield return _gameMethods.OpenDialog(7630); // "这是我从一名人类领主那里征用的。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan28", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan22", "zui2", "emoji2"});
        yield return _gameMethods.OpenDialog(7631); // "征用，哈哈……"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui19", "-emoji2"});
        yield return _gameMethods.OpenDialog(7632); // "那，你为什么选中了这个人呢？你对他有什么印象。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui6"});
        yield return _gameMethods.OpenDialog(7633); // "只是偶然。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui6", "emoji12"});
        yield return _gameMethods.OpenDialog(924); // "……？"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan32", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui6", "-emoji12"});
        yield return _gameMethods.OpenDialog(7634); // "当时，我正从一个在绝望中离去的农民的记忆中见到他..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui13"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(7635); // "那名农民无意中冒犯了这个领主，被后者赶出了领地，..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
        yield return _gameMethods.OpenDialog(7636); // "「离开之时，残留在他脑中最后的情绪，便是对这名领..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui9"});
        yield return _gameMethods.OpenDialog(7637); // "以及对人生未来的迷茫。」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(7638); // "当时这块领地正好距离我不远，我顺路，就选了这个城..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(7639); // "……原来如此。看来人还是要多做好事，{nw}{w..."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan12", "zui8", "emoji2"});
        yield return _gameMethods.OpenDialog(7640); // "尽量少出现在这种强大生物的眼前，少刷存在感，以免..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei3", "yan8", "zui8"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.OpenDialog(7641); // "他似乎想起了什么。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan10", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_qian");
        yield return _gameMethods.OpenDialog(7642); // "「至于接触……{nw}{w=0.01}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
        yield return _gameMethods.OpenDialog(7643); // "在我以同样的理由和语气，将他驱逐出了城堡。」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(3194); // "我愣了一下。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan25", "zui10"});
        yield return _gameMethods.OpenDialog(7644); // "你这是在……打抱不平？"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan25", "zui15"});
        yield return _gameMethods.OpenDialog(165); // "？"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(7645); // "不，我只是好奇。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan10", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(7646); // "那位农民离开时的渴望强烈到了极点。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(7647); // "「我想知道，{nw}{w=0.01}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
        yield return _gameMethods.OpenDialog(7648); // "如果我做到了他所渴望的事，会是什么感受。」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10"});
        yield return _gameMethods.OpenDialog(7649); // "那你是什么感觉呢？"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(7650); // "「没感觉。{nw}{w=0.01}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan17", "zui9"});
        yield return _gameMethods.OpenDialog(7651); // "那人的表情很无聊。」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan17", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(1467); // "这样啊。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(7652); // "拥有无数生灵梦寐以求的强大的力量，却只能从中感到..."
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(7653); // "「但是，{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan11", "zui2"});
        yield return _gameMethods.OpenDialog(7654); // "如果那位农民能知道，他一定会感激你的。」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(7655); // "那你呢。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan5", "zui9"});
        yield return _gameMethods.OpenDialog(3151); // "什么？"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei8", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(7656); // "你觉得怎么样。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan5", "zui9"});
        yield return _gameMethods.OpenDialog(7657); // "「我……{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan6", "zui10"});
        yield return _gameMethods.OpenDialog(7658); // "我觉得你做了一件很有意义的事情。」"
        Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan8", "zui19"});
        yield return _gameMethods.OpenDialog(7659); // "这也可以防止那个领主名下所统治的更多无辜平民们，..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui20"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan8", "zui8"});
        yield return _gameMethods.OpenDialog(602); // "……嗯。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.8f}, {"blur", 2.0f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui19"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui8"});
        yield return _gameMethods.OpenDialog(7660); // "……不过，我猜，当这座城堡被占领后，周围领地上的..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(7661); // "离开赖以生存的故土，另谋生路，对于安土重迁的农民..."
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 2.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan20", "zui15"});
        yield return _gameMethods.OpenDialog(7662); // "也许甚至还不如继续生活在那个他们已经习惯了脾气的..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7663); // "因为再糟糕的秩序，也总是比失去秩序要好。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui19"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui19"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(7664); // "可赫泽尔又做错了什么呢。他什么没做错。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7665); // "他只是——{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan20", "zui15"});
        yield return _gameMethods.OpenDialog(7666); // "因为力量过于强大，以至于哪怕不特意去针对谁，仅其..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(7667); // "但这些话，我不可能对赫泽尔说。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7668); // "因为这是一个无解的话题。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(7669); // "就像我很难追问他，他到底喜不喜欢我、有多喜欢我一..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan21", "zui15"});
        yield return _gameMethods.OpenDialog(7670); // "有多喜欢我？能到达不忍心于是放过我的程度么。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(7671); // "……问题的尽头是死结。"
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:6.0f);
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.TransitionBy("blink4_1");
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.OpenDialog(33); // "………………"
        if (Defaults.Bai_xue == 1)
        {
            yield return _gameMethods.ChangeLabelTo("label_bai_shenglitong");
        }
        if (Defaults.Bai_xue == 0)
        {
            yield return _gameMethods.ChangeLabelTo("label_shenglitong_gong");
        }
    }

    public IEnumerator label_shenglitong_gong()
    {
        yield return _gameMethods.Scene("woshi_nv1_tian");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.PlaySound("soundb", 2.0f, 1.0f, "audio/demo_audio/sound/chong1.ogg");
        Defaults.Gui_duihuakuang_you = 1;
        yield return _gameMethods.TransitionBy("blink3");
        yield return _gameMethods.OpenDialog(7672); // "睁开眼，天色已经黑了。"
        yield return _gameMethods.Scene("woshi_nv_chuang1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.8f, 1.32f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.7f}})});
        yield return _gameMethods.PlaySound("sound", 0.0f, 2.0f, "audio/sound/manbu/Body1_02_duan.mp3");
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan1", "zui12", "emoji2"});
        yield return _gameMethods.OpenDialog(7673); // "……我睡着了！？"
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei3", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(765); // "嗯。"
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan1", "zui15"});
        yield return _gameMethods.OpenDialog(47); // "……！"
        yield return _gameMethods.PlaySound("sounda", 0.0f, 0.4f, "audio/sound/moca1.ogg");
        yield return _gameMethods.Show("woshi_nv_chuang1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(0.8f, 1.32f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.2f}, {"pos", new Vector2(0.05f, 1.56f)}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 2.95f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.6f}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}, {"blur", 0.01f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.5f, "<silence 0.4>audio/demo_audio/sound/book2_he.mp3");
        yield return _gameMethods.OpenDialog(7674); // "声音吓了我一跳，我转头看去，才发现坐在床边的赫泽..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.OpenDialog(7675); // "朝我看来。"
        yield return _gameMethods.Show("woshi_nv_chuang1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(0.05f, 1.56f)}})});
        yield return _gameMethods.Show("he", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10", "emoji2"});
        yield return _gameMethods.OpenDialog(7676); // "赫泽尔，原来你在。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(7677); // "他居然还在这里。"
        yield return _gameMethods.PlaySound("music", 2.0f, 1.0f, "audio/demo_audio/music/richang1.mp3");
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(765); // "嗯。"
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(7678); // "你睡了十个小时。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(7679); // "……你现在觉得怎么样。还好么。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(7680); // "「嗯……{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan3", "zui10"});
        yield return _gameMethods.OpenDialog(7681); // "好多了。」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui15"});
        yield return _gameMethods.OpenDialog(7682); // "我没有撒谎，这似乎是一段极其深沉的睡眠，可能因为..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(7683); // "昨晚发生了什么来着？"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan18", "zui15"});
        yield return _gameMethods.OpenDialog(7684); // "好像诺伯拉帮我消除了疼痛。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7685); // "然后我就迷迷糊糊地睡着了……"
        if (Defaults.Bai_xinlai == 1)
        {
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui15"});
            yield return _gameMethods.OpenDialog(7686); // "不过，我还记得，睡着之前的诺伯拉貌似难得的露出了..."
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15"});
            yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(7687); // "虽然这么讲可能不太合适，但那的确令我感受到了短暂..."
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui8", "emoji2"});
            yield return _gameMethods.OpenDialog(7688); // "人在忍受病痛的时候，心灵真是脆弱啊。"
        }
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan9", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(779); // "你在想什么？"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan9", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui9"});
        yield return _gameMethods.OpenDialog(7259); // "「啊……{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(7689); // "没什么。」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan6", "zui10"});
        yield return _gameMethods.OpenDialog(7690); // "我只是有点惊讶。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui10", "-emoji2"});
        yield return _gameMethods.OpenDialog(7691); // "你一直在这里等我到现在吗？"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(765); // "嗯。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(7692); // "……我不知道你什么时候会醒过来。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 2.0f, "audio/sound/manbu/Body1_02_duan.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.7f}, {"zpos", -42.0f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui19"});
        yield return _gameMethods.OpenDialog(7693); // "「一次偏头痛而已，{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(7694); // "还不至于醒不过来啦……」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan11", "zui7"});
        yield return _gameMethods.OpenDialog(7695); // "疼痛过重，会导致人类昏迷。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10"});
        yield return _gameMethods.OpenDialog(7696); // "……确实。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -42.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
        yield return _gameMethods.OpenDialog(7697); // "「也有人会因为偏头痛陷入昏迷，{nw}{w=0...."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan3", "zui10"});
        yield return _gameMethods.OpenDialog(7698); // "不过一般多休息就没问题了。」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan2", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan3", "zui15"});
        yield return _gameMethods.OpenDialog(6456); // "「……{nw}{w=0.01}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
        yield return _gameMethods.OpenDialog(7699); // "我记住了。」"
        yield return _gameMethods.EngineSetVolume(volume:0.4f, delay:0.5f, channelName:"music");
        yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:4.0f);
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Transition(time:0.6f);
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.EngineSetVolume(volume:1.0f, delay:0.5f, channelName:"music");
        yield return _gameMethods.Scene("heilong_dating_men_baitian", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.0f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.79f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.OpenDialog(7700); // "……于是，隔天，他带回了一朵灵芝，和三根虫草。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan10", "zui13", "emoji2"});
        yield return _gameMethods.OpenDialog(7701); // "我震撼极了。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan12", "zui18", "emoji2"});
        yield return _gameMethods.OpenDialog(7702); // "生平头一次吃到了这些。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui16", "emoji2"});
        yield return _gameMethods.OpenDialog(7703); // "不得不说，野外生长的灵芝与虫草，在经慢火熬煮，提..."
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui16", "-emoji2"});
        yield return _gameMethods.OpenDialog(7704); // "最后，那煲汤我喝了足足一个月。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei6", "yan12", "zui16", "emoji2"});
        yield return _gameMethods.OpenDialog(7705); // "都舍不得喝完。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei6", "yan21", "zui6", "emoji2", "emoji6"});
        yield return _gameMethods.OpenDialog(7706); // "……我发誓，这辈子，我对饮食的追求已经到头了。"
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:5.0f);
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.Show("anniu_bg28_memory");
        yield return _gameMethods.Hide("anniu_bg28_memory");
        yield return _gameMethods.Scene("winter_forest", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"xpos", 0.5f}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.69f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 1.04f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 2.0f}, {"ypos", 1.36f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Show("snow_white2");
        yield return _gameMethods.PlaySound("soundb", 3.0f, 1.0f, "audio/sound/huiyi_winter/Howling Wind_01.ogg");
        yield return _gameMethods.Transition(time:0.5f);
        Defaults.Haogandu_an = Defaults.Haogandu_an + 1;
        yield return _gameMethods.OpenDialog(7707); // "冬天到来。"
        yield return _gameMethods.PlaySound("music1", 0.0f, 0.6f, "audio/music/wenxin1.mp3");
        Defaults.Persistent.Jq_8_4 = 1;
        yield return _gameMethods.OpenDialog(7708); // "一同来临的还有赫泽尔的生日。"
        yield return _gameMethods.OpenDialog(7709); // "这一次，我提前一个月就着手准备了。"
        yield return _gameMethods.OpenDialog(7710); // "我要一雪前耻，默默准备一个惊喜，然后惊艳赫泽尔。"
        yield return _gameMethods.EngineSetVolume(volume:4.0f, delay:0.5f, channelName:"music1");
        yield return _gameMethods.Scene("heilong_chufang_baitian_jin", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.0f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 1.02f}, {"blur", 3.0f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 2.62f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.53f}})});
        yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:3.0f);
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei5", "yan18", "zui2", "emoji2"});
        yield return _gameMethods.OpenDialog(7711); // "…………我本来是这么打算的。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan18", "zui8"});
        yield return _gameMethods.OpenDialog(7712); // "我对站在一旁、正安静地盯着我的动作的赫泽尔解释道..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan28", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei5", "yan18", "zui8"});
        yield return _gameMethods.OpenDialog(7713); // "惊喜……"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(7714); // "你是说去年那个鸡蛋面包么。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.OpenDialog(7715); // "他冷静地发问。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei5", "yan10", "zui19"});
        yield return _gameMethods.OpenDialog(7716); // "「不是，{nw}{w=0.01}"
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/moca1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0.0f}, {"parallel_1", true}})});
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei5", "yan5", "zui2"});
        yield return _gameMethods.OpenDialog(7717); // "那是蛋糕！」"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"yoffset", 0.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei5", "yan12", "zui2"});
        yield return _gameMethods.OpenDialog(7718); // "「而且少小看人了，{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei4", "yan2", "zui2"});
        yield return _gameMethods.OpenDialog(7719); // "今年我要做的可是堂堂正正的鲜奶油戚风蛋糕。」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan3", "zui6"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan24", "zui8"});
        yield return _gameMethods.OpenDialog(7720); // "反正他没见过戚风蛋糕是什么样子，{nw}{w=0..."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei4", "yan12", "zui16"});
        yield return _gameMethods.OpenDialog(7721); // "解释权在我。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui2", "-emoji2"});
        yield return _gameMethods.OpenDialog(7722); // "「你可是第一个品尝到这种美味的人……"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan2", "zui2", "emoji2"});
        yield return _gameMethods.OpenDialog(7723); // "嗯，"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan5", "zui2", "emoji7"});
        yield return _gameMethods.OpenDialog(7724); // "生物，"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan11", "zui19", "-emoji2"});
        yield return _gameMethods.OpenDialog(7725); // "很荣幸的哦。」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui8", "-emoji7"});
        yield return _gameMethods.OpenDialog(7726); // "这是你第一次做？"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
        Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(2654); // "是呀。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui19"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(7727); // "不过放心，我不会失败的啦。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui20"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei3", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(602); // "……嗯。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1>audio/demo_audio/sound/zu3_nv_zou.ogg");
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.9f}, {"zpos", 48.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(2537); // "你需要我做什么。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(7728); // "……好吧，{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan6", "zui15"});
        yield return _gameMethods.OpenDialog(7729); // "送上来的助手。不用白不用。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan5", "zui2"});
        yield return _gameMethods.OpenDialog(7730); // "首先把面粉蒸熟吧。{nw}{w=0.01}"
        yield return _gameMethods.Show("he", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 48.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan8", "zui2"});
        yield return _gameMethods.OpenDialog(7731); // "\n然后还要拜托你，把它们粉碎一下。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan7", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan8", "zui7"});
        yield return _gameMethods.OpenDialog(249); // "可以。"
        yield return _gameMethods.Scene("heilong_chufang_baitian_man1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.2f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 1.07f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan7", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 2.63f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.54f}})});
        yield return _gameMethods.TransitionBy("trans_rip_fast");
        yield return _gameMethods.OpenDialog(7732); // "当我称量完面粉后，一个填满水的铜锅已经摆在了手边..."
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.6f, "<from 0 to 1>audio/demo_audio/sound/zu3_nv_zou.ogg");
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.7f}, {"zpos", 24.0f}})});
        yield return _gameMethods.OpenDialog(7733); // "赫泽尔再次走到我身边，看着我的动作。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 24.0f}})});
        yield return _gameMethods.OpenDialog(7734); // "为什么要粉碎面粉。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
        yield return _gameMethods.PlaySound("sounda1", 0.0f, 1.0f, "audio/demo_audio/sound/canpanpengzhuang2_duan.mp3");
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui10"});
        yield return _gameMethods.OpenDialog(7735); // "「啊，因为普通面粉里的蛋白质含量比较高，{nw}..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan29", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan5", "zui20"});
        yield return _gameMethods.OpenDialog(7736); // "容易起筋，只能用来做劲道的面食。」"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui6", "emoji2"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui6"});
        yield return _gameMethods.OpenDialog(7737); // "呃。好像一不小心说出了这个世界里没有的词汇。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(7738); // "我不动声色，偷偷看了一眼赫泽尔。"
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(7739); // "他面无表情，神态一如往常，毫无异色。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan6", "zui7", "-emoji2"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan9", "zui19"});
        yield return _gameMethods.OpenDialog(7740); // "所以，如果想做出口感松软的饼干和蛋糕，就需要低筋..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan12", "zui11"});
        yield return _gameMethods.OpenDialog(7741); // "但这在外面买不到。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(7742); // "这个世界的烹饪技术水准，尚未发展到能区分出面粉里..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan12", "zui8", "emoji2"});
        yield return _gameMethods.OpenDialog(7743); // "这也是为什么去年我会惨遭失败。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui", "emoji7", "-emoji2"});
        yield return _gameMethods.OpenDialog(7744); // "……不过，今年的我已经想出了解决方案。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(7745); // "我们只要人为地把面粉里的筋质分解掉就可以了。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui2"});
        yield return _gameMethods.OpenDialog(7746); // "所以要把面粉用水蒸熟，粉碎，精筛。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui6", "-emoji7"});
        yield return _gameMethods.OpenDialog(7747); // "多谢前世喜欢过的甜点烘培主题的手机游戏。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan10", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(7748); // "你在这方面似乎很有造诣。"
        yield return _gameMethods.PlaySound("sounda", 0.0f, 0.6f, "audio/demo_audio/sound/liangjinjin_01.ogg");
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei3", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(7749); // "「哼。{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan12", "zui19"});
        yield return _gameMethods.OpenDialog(7750); // "很有眼光哦赫泽尔大人。」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui19"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei3", "yan12", "zui8"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("black", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 24.0f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/liangjinjin_01.ogg");
        yield return _gameMethods.Hide("black");
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan11", "zui2"});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan25", "zui11", "emoji8", "emoji9", "emoji10"});
        yield return _gameMethods.OpenDialog(7751); // "大功告成！"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19", "-emoji8"});
        yield return _gameMethods.OpenDialog(7752); // "哎呀，有个帮手实在是太好了。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan24", "zui7", "emoji2", "-emoji9", "-emoji10"});
        yield return _gameMethods.OpenDialog(7753); // "如果自己手动从牛奶中搅出奶油，我大概要搅个两三小..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan10", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(2254); // "这没什么。"
        yield return _gameMethods.StopSound(channelName:"music1", fadeOut:5.0f);
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.PlaySound("soundb", 1.0f, 0.7f, "audio/demo_audio/sound/chong1.ogg");
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/music/One_spring_day.mp3");
        yield return _gameMethods.Scene("birthday_layered", parts: new List<string>{"h_mei1", "h_zui2", "h_yan2", "n_zui3", "n_yan2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.0f)}, {"zoom", 0.53f}})});
        Defaults.Gui_duihuakuang_you = 0;
        yield return _gameMethods.Show("2-24_zoom");
        yield return _gameMethods.Hide("2-24_zoom");
        yield return _gameMethods.Transition(time:0.8f);
        yield return _gameMethods.OpenDialog(3725); // "夜幕降临。"
        yield return _gameMethods.OpenDialog(7754); // "我把提前买好的蜡烛一一插在了蛋糕上，只插了十四根..."
        yield return _gameMethods.Show("birthday_layered", parts: new List<string>{"n_zui1", "n_yan1"});
        yield return _gameMethods.OpenDialog(7755); // "许一个愿望吧。"
        yield return _gameMethods.Show("birthday_layered", parts: new List<string>{"n_zui3", "h_zui1"});
        yield return _gameMethods.OpenDialog(924); // "……？"
        yield return _gameMethods.Show("birthday_layered", parts: new List<string>{"n_zui1", "h_zui2"});
        yield return _gameMethods.OpenDialog(7756); // "在人类的习俗里，我们会在吃蛋糕之前，在心里默默许..."
        yield return _gameMethods.Show("birthday_layered", parts: new List<string>{"n_yan2"});
        yield return _gameMethods.OpenDialog(7757); // "借助生日这天的幸运，希望未来能实现它。"
        yield return _gameMethods.Show("birthday_layered", parts: new List<string>{"h_zui1", "h_yan4", "n_zui3"});
        yield return _gameMethods.OpenDialog(7758); // "我不需要把愿望寄托在这种虚无缥缈的祈祷上。"
        yield return _gameMethods.Show("birthday_layered", parts: new List<string>{"h_zui2", "n_zui1", "n_yan1"});
        yield return _gameMethods.OpenDialog(7759); // "嗯……也就是说，你确实有愿望可以许？"
        yield return _gameMethods.Show("birthday_layered", parts: new List<string>{"h_yan2", "n_zui3"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("birthday_layered", parts: new List<string>{"n_zui1"});
        yield return _gameMethods.OpenDialog(7760); // "那，你也可以告诉我。"
        yield return _gameMethods.Show("birthday_layered", parts: new List<string>{"n_yan3"});
        Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.OpenDialog(7761); // "虽然赫泽尔很厉害，而我又弱小没什么能力，但我也会..."
        yield return _gameMethods.Show("birthday_layered", parts: new List<string>{"h_yan1", "n_zui3"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("birthday_layered", parts: new List<string>{"n_yan1"});
        yield return _gameMethods.OpenDialog(7762); // "他微微转开了头。"
        if (Defaults.Bai_xue == 0)
        {
            yield return _gameMethods.Show("birthday_layered", parts: new List<string>{"h_zui1", "h_mei2"});
            yield return _gameMethods.OpenDialog(4); // "……"
            yield return _gameMethods.Show("birthday_layered", parts: new List<string>{"h_zui2"});
            yield return _gameMethods.OpenDialog(7763); // "他小声嘟囔了一句什么，但我没能听清。"
            yield return _gameMethods.Show("birthday_layered", parts: new List<string>{"n_zui2"});
            yield return _gameMethods.OpenDialog(975); // "嗯？"
        }
        if (Defaults.Bai_xue == 1)
        {
            yield return _gameMethods.Show("birthday_layered", parts: new List<string>{"h_zui1", "h_mei2"});
            yield return _gameMethods.OpenDialog(7764); // "{size=-6}你不会实现它的。{/size}"
            yield return _gameMethods.Show("birthday_layered", parts: new List<string>{"h_zui2", "n_zui2"});
            yield return _gameMethods.OpenDialog(7765); // "……嗯？"
            yield return _gameMethods.Show("birthday_layered", parts: new List<string>{"n_zui3"});
            yield return _gameMethods.OpenDialog(7766); // "虽然和诺伯拉签订契约后，我的各项身体机能都有提升..."
            yield return _gameMethods.ExecuteCharacterImageData("nv2_qian");
            yield return _gameMethods.OpenDialog(7767); // "（只隐约听到什么“不会实现”的……）"
            yield return _gameMethods.ExecuteCharacterImageData("nv2_qian");
            yield return _gameMethods.OpenDialog(7768); // "（有什么愿望，是强大如黑龙也难以实现的吗？）"
        }
        yield return _gameMethods.Show("birthday_layered", parts: new List<string>{"h_zui1", "h_yan2", "h_mei1", "n_zui3", "n_yan1"});
        yield return _gameMethods.OpenDialog(7769); // "没什么。我的愿望不是你能实现的事。"
        yield return _gameMethods.Show("birthday_layered", parts: new List<string>{"h_zui2", "n_zui2"});
        yield return _gameMethods.OpenDialog(7770); // "………………啊、"
        yield return _gameMethods.Show("birthday_layered", parts: new List<string>{"n_zui1", "n_yan2"});
        yield return _gameMethods.OpenDialog(7771); // "这样啊。毕竟我太弱了嘛。不好意思哦。"
        yield return _gameMethods.Show("birthday_layered", parts: new List<string>{"h_yan1", "n_zui3"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("birthday_layered", parts: new List<string>{"h_zui1", "h_yan2"});
        yield return _gameMethods.OpenDialog(7772); // "你不许愿么。"
        yield return _gameMethods.Show("birthday_layered", parts: new List<string>{"h_zui2", "n_zui1", "n_yan1"});
        yield return _gameMethods.OpenDialog(7773); // "哦！对，说好一起过生日来着……"
        yield return _gameMethods.Show("birthday_layered", parts: new List<string>{"n_yan3"});
        yield return _gameMethods.OpenDialog(7774); // "那我就许个愿吧。"
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/manbu/Body1_01.mp3");
        yield return _gameMethods.Show("birthday_layered", parts: new List<string>{"s", "n_yan4", "n_zui3"});
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.OpenDialog(7775); // "我对着蛋糕，双手交握在胸前，"
        yield return _gameMethods.Show("black");
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.OpenDialog(7776); // "闭眼沉默了三秒，重新睁开。"
        yield return _gameMethods.Show("birthday_layered", parts: new List<string>{"h_yan2", "n_zui3", "n_yan2"});
        yield return _gameMethods.Hide("black");
        yield return _gameMethods.TransitionBy("blink3");
        yield return _gameMethods.Show("birthday_layered", parts: new List<string>{"h_zui1"});
        yield return _gameMethods.OpenDialog(7777); // "你的愿望是什么。"
        yield return _gameMethods.Show("birthday_layered", parts: new List<string>{"h_zui2", "n_yan2"});
        yield return _gameMethods.OpenDialog(7778); // "我想活下去。"
        yield return _gameMethods.Show("birthday_layered", parts: new List<string>{"n_zui3"});
        yield return _gameMethods.OpenDialog(7779); // "……我没有回答，只是笑起来。"
        yield return _gameMethods.Show("birthday_layered", parts: new List<string>{"n_zui1", "n_yan1", "-s"});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(7780); // "你要帮我实现它吗？"
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/shenglitong_gong_945379db1.ogg");
        yield return _gameMethods.Show("birthday_layered", parts: new List<string>{"h_zui1", "h_yan3", "n_zui3"});
        yield return _gameMethods.OpenDialog(7781); // "不过分的话。"
        yield return _gameMethods.Show("birthday_layered", parts: new List<string>{"h_zui2", "n_zui2", "n_yan3"});
        yield return _gameMethods.OpenDialog(7782); // "可能有点过分。"
        yield return _gameMethods.Show("birthday_layered", parts: new List<string>{"n_zui1", "n_yan1"});
        Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.OpenDialog(7783); // "我希望明年的这个时候，还可以和赫泽尔一起过生日。"
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:5.0f);
        yield return _gameMethods.Show("birthday_layered", parts: new List<string>{"h_yan2", "h_zui1", "n_zui3"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.OpenDialog(7784); // "他眼中的烛火摇曳了一下。"
        yield return _gameMethods.OpenDialog(7785); // "赫泽尔怔怔地注视着我，"
        yield return _gameMethods.Show("birthday_layered", parts: new List<string>{"h_yan1", "h_zui2"});
        yield return _gameMethods.OpenDialog(7786); // "过了一会儿，他转头看向了桌面。"
        yield return _gameMethods.Show("birthday_layered", parts: new List<string>{"h_zui1"});
        yield return _gameMethods.OpenDialog(7787); // "………哦。"
        yield return _gameMethods.Show("birthday_layered", parts: new List<string>{"h_zui2", "n_yan2"});
        yield return _gameMethods.OpenDialog(7788); // "所以，这就是你的答案。"
        yield return _gameMethods.Show("black");
        yield return _gameMethods.PlaySound("music2", 0.0f, 1.0f, "audio/music/the waltz of the bubble.mp3");
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(7789); // "一个不置可否的回答。"
        yield return _gameMethods.Hide("black");
        yield return _gameMethods.Show("birthday_layered", parts: new List<string>{"h_yan3", "n_zui4", "n_yan2"});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.OpenDialog(7790); // "我们一起望着蛋糕。"
        yield return _gameMethods.OpenDialog(7791); // "场景陷入沉寂。"
        yield return _gameMethods.OpenDialog(7792); // "很久很久，他没有进一步的解释。"
        yield return _gameMethods.Show("birthday_layered", parts: new List<string>{"n_zui1", "n_yan1"});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(7793); // "吃蛋糕吧！"
        yield return _gameMethods.Show("birthday_layered", parts: new List<string>{"n_zui3"});
        yield return _gameMethods.OpenDialog(7794); // "我打破沉默。"
        yield return _gameMethods.Show("birthday_layered", parts: new List<string>{"h_zui1"});
        yield return _gameMethods.OpenDialog(765); // "嗯。"
        yield return _gameMethods.Show("birthday_layered", parts: new List<string>{"h_zui2"});
        yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:5.0f);
        yield return _gameMethods.SceneBlack();
        Defaults.Gui_duihuakuang_you = 1;
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(7795); // "我们静静地分食了这块蛋糕。"
        yield return _gameMethods.OpenDialog(7796); // "奶油很淡，一点也不好吃。"
        yield return _gameMethods.StopSound(channelName:"music2", fadeOut:10.0f);
        yield return _gameMethods.ChangeLabelTo("label_zhuxian6");
        yield break;
    }

}
