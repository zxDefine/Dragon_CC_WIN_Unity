using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end7_menu : ILabelProvider
{
    private GameMethods _gameMethods;

    public end7_menu(GameMethods gameMethods)
    {
        _gameMethods = gameMethods;
    }

    // "—你这样挺好的" 分支 (rpy L1054)
    public IEnumerator label_end7_menu_0_y1ZJZYKK()
    {
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan5", "zui19", "emoji2"});
        yield return _gameMethods.OpenDialog(5960); // "「你这样……{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan12", "zui19", "emoji2"});
        yield return _gameMethods.OpenDialog(5961); // "挺好的。挺好的。」"
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei3", "yan5", "zui2", "-emoji2"});
        yield return _gameMethods.OpenDialog(5962); // "「这样也很帅气。{nw}{w=0.01}"
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.3f, "audio/sound/moca1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -8.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 8.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0.0f}, {"parallel_1", true}})});
        Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(5963); // "一表人才！」"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei1", "yan4", "zui1"});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"yoffset", 0.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei3", "yan5", "zui8"});
        yield return _gameMethods.OpenDialog(4400); // "「……{nw}{w=0.2}"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei1", "yan14", "zui6", "emoji10"});
        yield return _gameMethods.OpenDialog(1497); // "嗯。」"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei1", "yan14", "zui15", "emoji10"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui15"});
        yield return _gameMethods.OpenDialog(5965); // "等等，他是不是脸红了？"
        yield return _gameMethods.PlaySound("sound", 0.0f, 4.0f, "audio/sound/manbu/Body1_02_duan.mp3");
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui14"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(-834.0f, 2136.0f)}, {"zoom", 0.65f}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}, {"blur", 0.1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.2f}, {"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", -408.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.33f}, {"xpos", -786.0f}})});
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan14", "zui15", "emoji10"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(5966); // "那我呢？"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", -786.0f}})});
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei8", "yan11", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.ChangeLabelTo("label_end6_2");
    }

    // "—你还能变回去吗" 分支 (rpy L1101)
    public IEnumerator label_end7_menu_0__WPL6L3_()
    {
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan5", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19", "emoji2"});
        yield return _gameMethods.OpenDialog(5967); // "你还能变回去吗？"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan4", "zui1"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
        yield return _gameMethods.OpenDialog(226); // "{nw}{w=0.2}"
        Engine._history = true;
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan13", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan11", "zui8", "emoji2"});
        yield return _gameMethods.OpenDialog(165); // "？"
        yield return _gameMethods.PlaySound("sound", 0.0f, 4.0f, "audio/sound/manbu/Body1_02_duan.mp3");
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei8", "yan7", "zui13"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(-834.0f, 2136.0f)}, {"zoom", 0.65f}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}, {"blur", 0.1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.2f}, {"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", -408.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.33f}, {"xpos", -786.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei7", "yan11", "zui8", "-emoji2"});
        yield return _gameMethods.OpenDialog(5968); // "「这副样子看起来很危险对吧？{nw}{w=0.0..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui16"});
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei8", "yan16", "zui1", "emoji14"});
        yield return _gameMethods.OpenDialog(5969); // "我懂哦，让人想要远离。」"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", -786.0f}})});
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei8", "yan16", "zui1", "emoji14"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan10", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(5970); // "你也没安全到哪里去。"
        yield return _gameMethods.PlaySound("sounda", 0.0f, 0.3f, "<from 0 to 1>audio/sound/emeng_dajie/walking_on_the_earth_01.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 144.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.95f}, {"zpos", 180.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan24", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(5971); // "我离他也拉远了两步。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(226); // "{nw}{w=0.2}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei11", "yan2", "zui15"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei11", "yan11", "zui8"});
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan14", "zui1", "-emoji14"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan24", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 180.0f}})});
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan1", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan5", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(5972); // "你喜欢年龄更小的么？"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan5", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan12", "zui2", "emoji2"});
        yield return _gameMethods.OpenDialog(5973); // "也、不是这个意思……"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui8"});
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan17", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei3", "yan6", "zui8", "emoji2"});
        yield return _gameMethods.OpenDialog(5974); // "所以，你要反悔了？"
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.3f, "audio/sound/moca1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -8.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 8.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0.0f}, {"parallel_1", true}})});
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan17", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan5", "zui11", "emoji2"});
        yield return _gameMethods.OpenDialog(5975); // "我没这么说！"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan14", "zui2"});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"yoffset", 0.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei3", "yan5", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan1", "zui7"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(5976); // "就结论而言，回不去。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan10", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei3", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(5977); // "进入成长期后，龙族躯体的绝对质量增加了。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan5", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(5978); // "因此，所拟态的对象，在体积上也无法低于某个临界点..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui14"});
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan5", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan18", "zui15"});
        yield return _gameMethods.OpenDialog(5979); // "是啊，不然我早就拟化成幼年期的外表了。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(5980); // "「毕竟，小公主看起来似乎青睐于这种类型，{nw}..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui14"});
        yield return _gameMethods.OpenDialog(5981); // "不是么？」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.Hide("nuo1");
        yield return _gameMethods.Hide("heo");
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei4", "yan2", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(-414.0f, 1752.0f)}, {"zoom", 0.41f}})});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei8", "yan1", "zui1", "emoji21"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(36.0f, 1866.0f)}, {"zoom", 0.43f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 200.0f}, {"zpos", 66.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.3f}, {"xoffset", 0.0f}})});
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.5f, "audio/sound/emeng_dajie/Swing Whoosh_01.mp3");
        yield return _gameMethods.Transition(time:0.2f);
        yield return _gameMethods.ExecuteCharacterImageData("an_luo");
        yield return _gameMethods.OpenDialog(924); // "……？"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei8", "yan1", "zui1", "-emoji21"});
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/moca1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -8.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 8.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0.0f}, {"parallel_1", true}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei4", "yan11", "zui2", "emoji2"});
        yield return _gameMethods.OpenDialog(5982); // "我不是，我没有！"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"yoffset", 0.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan22", "zui8", "emoji2"});
        yield return _gameMethods.OpenDialog(5983); // "不要胡乱揣测我的偏好！"
        yield return _gameMethods.ChangeLabelTo("label_end6_1");
    }

    // "—你也很像个人" 分支 (rpy L1221)
    public IEnumerator label_end7_menu_1_ERN73FYC()
    {
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(5984); // "你也很像个人。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei3", "yan11", "zui8"});
        yield return _gameMethods.OpenDialog(5985); // "「真是差别对待。{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan5", "zui8"});
        yield return _gameMethods.OpenDialog(4883); // "」"
        yield return _gameMethods.ChangeLabelTo("label_end6_1");
    }

    // "—你也一表人才" 分支 (rpy L1228)
    public IEnumerator label_end7_menu_1_4MWVlgt_()
    {
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(5986); // "你也一表人才。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.6f, "<from 0 to 0.5>audio/sound/emeng_dajie/walking_on_the_earth_01.mp3");
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei8", "yan7", "zui9"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", -834.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.65f}, {"xpos", -804.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei7", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(4400); // "「……{nw}{w=0.2}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui13"});
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei1", "yan10", "zui11", "-emoji10"});
        yield return _gameMethods.OpenDialog(5987); // "我还可以为你，变得更加温柔可信一点点。」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui13"});
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei6", "yan15", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(5988); // "你想看看吗？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.5f, "audio/sound/emeng_dajie/Swing Whoosh_01.mp3");
        yield return _gameMethods.Hide("nuo1");
        yield return _gameMethods.Hide("heo");
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei8", "yan8", "zui14"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(-216.0f, 1878.0f)}, {"zoom", 0.45f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 200.0f}, {"zpos", 66.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.3f}, {"xoffset", 0.0f}})});
        yield return _gameMethods.Transition(time:0.2f);
        yield return _gameMethods.OpenDialog(5989); // "她不想。"
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei8", "yan8", "zui3"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan24", "zui16"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ChangeLabelTo("label_end6_1");
    }

}
