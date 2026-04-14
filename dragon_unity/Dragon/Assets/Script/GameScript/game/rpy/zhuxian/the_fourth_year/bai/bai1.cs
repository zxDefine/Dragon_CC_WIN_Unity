using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bai1 : ILabelProvider
{
    private GameMethods _gameMethods;

    public bai1(GameMethods gameMethods)
    {
        _gameMethods = gameMethods;
    }

    public IEnumerator label_bai_mosuomofa()
    {
        yield return _gameMethods.PlaySound("sounda2", 0.0f, 1.0f, "<from 0 to 2>audio/sound/dashuizhang/clapping_alone3.mp3");
        Defaults.Persistent.Jq_8_6 = 1;
        yield return _gameMethods.OpenDialog(6221); // "啪，啪，啪。一段掌声突兀地响起。"
        yield return _gameMethods.StopSound(channelName:"music1", fadeOut:3f);
        yield return _gameMethods.PlaySound("sound", 0.2f, 0.4f, "audio/demo_audio/sound/moca2.mp3");
        yield return _gameMethods.Scene("senlin4");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -348f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.3f}, {"ypos", 0f}})});
        yield return _gameMethods.Transition(time:0.3f);
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan1", "zui15"});
        yield return _gameMethods.OpenDialog(6222); // "…… "
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(6223); // "我僵住了。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(6224); // "一种莫名的羞耻感涌上心头..."
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}})});
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.29f, 2.91f)}, {"zoom", 0.62f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/demo_audio/music/time_syuanji.mp3");
        yield return _gameMethods.OpenDialog(6225); // "我闻声望去，一名白发的青年..."
        yield return _gameMethods.OpenDialog(6226); // "诺伯拉。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan19", "zui16"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_qian");
        yield return _gameMethods.OpenDialog(4980); // "「看来，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei4", "yan11", "zui16"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_qian");
        yield return _gameMethods.OpenDialog(6227); // "你不需要我出手相救呢。」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei4", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10"});
        yield return _gameMethods.OpenDialog(6228); // "啊……你不是只是我的幻觉吗？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui12"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan4", "zui10"});
        yield return _gameMethods.OpenDialog(6229); // "应该也没法干涉其他的客观物体吧。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei4", "yan13", "zui16"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan4", "zui15"});
        yield return _gameMethods.OpenDialog(6230); // "……是啊。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei4", "yan1", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(6231); // "真聪明呀，小公主。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei4", "yan11", "zui16"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(6232); // "你似乎从一开始，就没产生向我求助的念头。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei4", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui15"});
        yield return _gameMethods.OpenDialog(6233); // "……呃，这么说来，貌似还真是。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan8", "zui10"});
        yield return _gameMethods.OpenDialog(4989); // "嗯——……"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui11"});
        yield return _gameMethods.OpenDialog(6234); // "笃定你一定会来救我，那样才比较不识趣吧。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei4", "yan7", "zui12"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan12", "zui11"});
        yield return _gameMethods.OpenDialog(6235); // "就好像指望着你帮忙收拾所有烂摊子一样。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui10"});
        yield return _gameMethods.OpenDialog(6236); // "「你应该也厌烦了这样被束缚，{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(6237); // "不是吗。」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei4", "yan1", "zui12"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei4", "yan7", "zui12"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan24", "zui8"});
        yield return _gameMethods.OpenDialog(6238); // "最重要的是，客观世界也不会以我的主观意愿为转移啊..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei4", "yan13", "zui12"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui16"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(6239); // "呵呵……没错。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei11", "yan11", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(6240); // "你真会察言观色。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei11", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan12", "zui19", "emoji7"});
        yield return _gameMethods.OpenDialog(6241); // "我一向还蛮有眼色的。"
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:3f);
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei3", "yan1", "zui12"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei4", "yan13", "zui12"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui7", "-emoji7"});
        yield return _gameMethods.OpenDialog(6242); // "我望着他，忽然灵机一动。"
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/emeng_dajie/magic1.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui8"});
        yield return _gameMethods.OpenDialog(6243); // "手心朝上，掌中冒出一朵喷泉。"
        yield return _gameMethods.PlaySound("music1", 0.0f, 1.0f, "audio/demo_audio/music/richang2.mp3");
        yield return _gameMethods.PlaySound("sounda1", 0.0f, 1.0f, "audio/sound/dashuizhang/Small Splash_01.mp3");
        yield return _gameMethods.Show("shuihua", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(468f, 354f)}, {"zoom", 0.66f}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}, {"zpos", 10f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(6244); // "水流从中央向四周散开..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei4", "yan1", "zui12"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei4", "yan13", "zui12"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui8"});
        yield return _gameMethods.OpenDialog(6245); // "我抬起胳膊，把花双手捧给他。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/manbu/Body1_02_duan.mp3");
        yield return _gameMethods.Show("shuihua", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.60f}, {"zpos", -18f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(6246); // "给你。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei4", "yan7", "zui12"});
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui19"});
        yield return _gameMethods.OpenDialog(6247); // "你送我花，我也送给你花。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -18f}})});
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei4", "yan19", "zui12"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(6248); // "他垂着眼眸，"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei4", "yan1", "zui12"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei4", "yan19", "zui12"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(6249); // "神色淡淡地望了我片刻..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan19", "zui12"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(6250); // "终于，自高处伸出手来。"
        yield return _gameMethods.Show("nuo1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"easein", 0.8f}, {"zpos", 10f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan9", "zui15"});
        yield return _gameMethods.OpenDialog(6251); // "指尖触碰到那朵水流时..."
        yield return _gameMethods.Show("nuo1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 10f}})});
        yield return _gameMethods.OpenDialog(6252); // "不过很快，在我的视野中..."
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/he/ICE1.ogg");
        yield return _gameMethods.Show("shuihua", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 0f}})});
        yield return _gameMethods.Show("binghua", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(468f, 354f)}, {"zoom", 0.66f}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}, {"zpos", 10f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1f}})});
        yield return _gameMethods.OpenDialog(6253); // "他的五指覆盖在我的手背上..."
        yield return _gameMethods.Hide("binghua");
        yield return _gameMethods.Hide("shuihua");
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(6254); // "他摘下那朵冰花，拿在手里，低头看着它。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan19", "zui12"});
        Engine._history = false;
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan19", "zui12"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo");
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo");
        yield return _gameMethods.OpenDialog(6255); // "你不想学习冰系魔法么。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui16"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo");
        yield return _gameMethods.OpenDialog(6256); // "它会让水拥有更强的杀伤力和可塑性。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui8"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan2", "zui10"});
        yield return _gameMethods.OpenDialog(6257); // "啊……但是，我没什么学习渠道啊。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui15", "emoji12"});
        yield return _gameMethods.OpenDialog(6258); // "难道要在寒冬腊月跳进冰湖..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan6", "zui15", "-emoji12"});
        yield return _gameMethods.OpenDialog(6259); // "你忘记我的名讳和权柄了么？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(6260); // "诺伯拉.博尔吉亚。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10"});
        yield return _gameMethods.OpenDialog(6261); // "冰霜与心灵之龙？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(6262); // "是啊，冰霜可是我掌管的领域。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(6263); // "只要念诵我的名讳..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(6264); // "那么，它需要我交付什么代价来换取呢？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui12"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6265); // "「……{nw}{w=0.3}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui12"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6266); // "……」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(6267); // "不知道。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui16"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(6268); // "你愿意为此而付出什么呢？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan9", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(6269); // "这个答案让我有些不安。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui12"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan20", "zui15"});
        yield return _gameMethods.OpenDialog(6270); // "在我的过往经历中..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei9", "yan13", "zui12"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan12", "zui18"});
        yield return _gameMethods.OpenDialog(6271); // "可我手里哪还有几张牌可出呢？"
        yield return _gameMethods.PlaySound("sound", 0.0f, 2f, "audio/sound/manbu/Body1_02_duan.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}, {"zpos", -18.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.50f}, {"ypos", -12f}, {"zpos", -30.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(6272); // "「嗯——"
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan11", "zui4"});
        yield return _gameMethods.OpenDialog(6273); // "也许是感情？」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei8", "yan7", "zui12"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui19"});
        yield return _gameMethods.OpenDialog(6274); // "「你会得到我诚挚的感激，"
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan24", "zui19", "emoji2"});
        yield return _gameMethods.OpenDialog(6275); // "由衷的祝福，"
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei3", "yan12", "zui2", "-emoji2"});
        yield return _gameMethods.OpenDialog(6276); // "以及人格……"
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/demo_audio/sound/ding1.mp3");
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei3", "yan5", "zui2", "emoji2"});
        yield return _gameMethods.OpenDialog(6277); // "龙格上的升华。」"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -12f}, {"zpos", -30.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui8", "emoji2"});
        yield return _gameMethods.OpenDialog(6278); // "我厚着脸皮，开始尝试强行吃霸王餐。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei3", "yan5", "zui8", "-emoji2"});
        yield return _gameMethods.OpenDialog(6279); // "「嗯————{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei6", "yan1", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6280); // "可以啊~」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei4", "yan2", "zui8", "emoji2", "emoji12"});
        yield return _gameMethods.OpenDialog(6281); // "……嗯嗯嗯？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei4", "yan2", "zui8", "emoji2", "-emoji12"});
        yield return _gameMethods.OpenDialog(6282); // "反正你也已经让我看到了好东西。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(6283); // "作为让我看到花朵绽开的回报..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan5", "zui10", "-emoji2"});
        yield return _gameMethods.OpenDialog(6284); // "……真的吗？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei3", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(6285); // "嗯。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0.5 to 1.5>audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.8f}, {"ypos", 2.94f}, {"zpos", 66.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(6286); // "不过，我还有一个条件。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 2.94f}, {"zpos", 66.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan12", "zui8", "emoji2"});
        yield return _gameMethods.OpenDialog(6282); // "果然有附带要求..."
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui11", "-emoji2"});
        yield return _gameMethods.OpenDialog(6283); // "是什么？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui16"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(6284); // "「等你学会制冰术后..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6285); // "将你用冰结出的第一枝花朵送给我。」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui8"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(6286); // "我等了一会儿，没听到下文..."
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(2539); // "这样？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(5601); // "就这样。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(6287); // "没问题。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui17"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.OpenDialog(6288); // "那么，下次吧。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui19"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6289); // "「——嘘，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan12", "zui16"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6290); // "他来了。」"
        yield return _gameMethods.Hide("nuo1");
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/emeng_dajie/magic1.ogg");
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.StopSound(channelName:"music1", fadeOut:4f);
        yield return _gameMethods.OpenDialog(6291); // "诺伯拉的身影蓦地隐匿。"
        yield return _gameMethods.ChangeLabelTo("label_zhuxian6_1");
    }

    public IEnumerator label_bai_manbu()
    {
        Defaults.Persistent.Jq_9_2 = 1;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan18", "zui15"});
        yield return _gameMethods.OpenDialog(6292); // "我需要找一个帮手..."
        yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:3f);
        yield return _gameMethods.Scene("senlin3");
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0.5 to 2>audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
        yield return _gameMethods.TransitionBy("blink2");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(6293); // "他们如此年轻..."
        yield return _gameMethods.Scene("senlin3_1");
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.OpenDialog(6294); // "我独自在林中练习了很久的拔刀和魔法..."
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(6295); // "直到夜幕低垂，我回到了城堡。"
        yield return _gameMethods.Show("anniu_bg24_memory");
        yield return _gameMethods.Hide("anniu_bg24_memory");
        yield return _gameMethods.PlaySound("soundb", 2f, 1.0f, "audio/demo_audio/sound/chong1.ogg");
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/door_open_3.mp3");
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<silence 0.3><from 0 to 1>audio/sound/jiaobusheng_xin_normal1.ogg");
        yield return _gameMethods.Scene("woshi_nv1_yewan_yangtai_ani", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.33f, 0.71f)}, {"zoom", 0.72f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.OpenDialog(6296); // "睡前，我走出卧室..."
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/feng2.mp3");
        yield return _gameMethods.OpenDialog(6297); // "不久，那个熟悉的声音划破寂静..."
        yield return _gameMethods.PlaySound("sounda1", 0.0f, 1.0f, "audio/sound/manbu/Sole_01.mp3");
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"lv1", "mei7", "yan7", "zui6"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.29f, 2.71f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.57f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.ExecuteCharacterImageData("nuo");
        yield return _gameMethods.OpenDialog(6298); // "你知道我会来。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui4"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo");
        yield return _gameMethods.OpenDialog(6299); // "小公主，看样子你找到了秘密道具。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui12"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(6300); // "白发青年出现在我眼前。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(6301); // "我知道，这不再是幻觉，而是真身。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(6226); // "诺伯拉。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui5"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan11", "zui7"});
        yield return _gameMethods.OpenDialog(6302); // "我对他笑眯眯。 "
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui3"});
        yield return _gameMethods.OpenDialog(6303); // "我正想找你。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(6304); // "真意外，公主殿下还会主动找我。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui19"});
        yield return _gameMethods.OpenDialog(6305); // "毕竟你对我很重要。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
        yield return _gameMethods.OpenDialog(6306); // "是吗？那我当真咯。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6067); // "「那么，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6307); // "你想说什么？」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan17", "zui3"});
        yield return _gameMethods.OpenDialog(6308); // "我要向你换取帮助。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan17", "zui7"});
        yield return _gameMethods.OpenDialog(6309); // "我不是已经在帮你了吗？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan10", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(6310); // "不，我要另一个帮助。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei8", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(6283); // "是什么？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan6", "zui15"});
        yield return _gameMethods.OpenDialog(6311); // "看来他并没有听到。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(6312); // "之后告诉你。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan12", "zui10"});
        yield return _gameMethods.OpenDialog(6313); // "「而报酬，{nw}{w=0.1}"
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan9", "zui10"});
        yield return _gameMethods.OpenDialog(6314); // "……或者说，谢礼。」"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1>audio/sound/jiaobusheng_xin_normal1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.87f}, {"zpos", -66f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan2", "zui10"});
        yield return _gameMethods.OpenDialog(6315); // "「我想给你一个礼物，{nw}{w=0.2}"
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(6316); // "如果你愿意要的话。」"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -66f}})});
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan4", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(6317); // "——假设诺伯拉会因此失去兴趣..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(6318); // "一不小心，他就会在履行约定后与我断绝往来。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(6319); // "但是，我不要继续保持他对我的兴趣了。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui9"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan4", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan21", "zui15"});
        yield return _gameMethods.OpenDialog(6320); // "就把保留的所有手段..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(6321); // "\n——只要能达成那个心愿。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(6322); // "问完这句后，我便有些忐忑的等待着。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui9"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan4", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan20", "zui15"});
        yield return _gameMethods.OpenDialog(6323); // "不知时至今日，这张存放太久的底牌..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6324); // "「啊，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui3"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6325); // "那确实很有诱惑力。」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(6326); // "……{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan12", "zui7"});
        yield return _gameMethods.OpenDialog(6327); // "我松了口气。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(6328); // "诺伯拉看着我，带着笑容。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui16"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(6329); // "你不会最后给我一个顶针吧？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(6330); // "这是我曾经给他讲过的一个故事..."
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(2011); // "怎么会呢。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui2"});
        yield return _gameMethods.OpenDialog(6331); // "我们可以先验货，如果你满意了，再做决定。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei7", "yan5", "zui8"});
        yield return _gameMethods.OpenDialog(1378); // "「……{nw}{w=0.3}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6332); // "你曾说过，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6333); // "礼物与爱不可分割。」"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1.5>audio/sound/jiaobusheng_nuo_normal1.ogg");
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"lv1", "mei7", "yan11", "zui13"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.66f}, {"zpos", 24.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(6334); // "所以，这代表你爱上我了？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"lv1", "mei7", "yan11", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 24.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan8", "zui3"});
        yield return _gameMethods.OpenDialog(6335); // "不，我没有爱上你。"
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui7"});
        yield return _gameMethods.OpenDialog(6336); // "我不能撒谎。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(6337); // "「礼物是给所爱之人的。{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui10"});
        yield return _gameMethods.OpenDialog(6338); // "不含爱的礼物就没有意义了。」"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui11"});
        yield return _gameMethods.OpenDialog(6339); // "我要给你礼物，可我也确实并不爱你。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui4"});
        yield return _gameMethods.OpenDialog(6340); // "所以，我要给你一个特殊的礼物。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui8"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan11", "zui3"});
        yield return _gameMethods.OpenDialog(6341); // "把手伸过来。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/houhui/Grab Hand_01.mp3");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(6342); // "我双手握住了他的手..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan19", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(6343); // "诺伯拉没有阻止..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan9", "zui7"});
        yield return _gameMethods.OpenDialog(6344); // "我心无杂念..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan17", "zui7"});
        yield return _gameMethods.OpenDialog(6345); // "缓缓地温柔地移动手臂..."
        yield return _gameMethods.Show("black", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 24.0f}})});
        yield return _gameMethods.PlaySound("sound", 0.0f, 3f, "audio/sound/manbu/Body1_02_duan.mp3");
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:2f);
        yield return _gameMethods.OpenDialog(6346); // "——然后，攥住他肩膀的衣料借力..."
        yield return _gameMethods.Show("cg_bai_kiss_secret_layered", parts: new List<string>{"yan1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 24.0f}, {"anchor", new Vector2(0f, 0f)}, {"zoom", 0.61f}, {"pos", new Vector2(-168f, -162f)}})});
        Defaults.Gui_duihuakuang_you = 0;
        yield return _gameMethods.Show("2-26_zoom");
        yield return _gameMethods.Hide("2-26_zoom");
        yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/music/PerituneMaterial_Grief_inst_loop.mp3");
        yield return _gameMethods.Transition(time:1.7f);
        yield return _gameMethods.OpenDialog(6347); // "一股凛冽清凉的气息扑面而来..."
        yield return _gameMethods.OpenDialog(6348); // "那是一种很难形容的气味..."
        yield return _gameMethods.Show("cg_bai_kiss_secret_layered", parts: new List<string>{"yan1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(-492f, -252f)}, {"zoom", 0.87f}})});
        yield return _gameMethods.Transition(time:0.7f);
        yield return _gameMethods.OpenDialog(6349); // "双唇轻轻吻在他的指节上。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(216f, -162f)}})});
        yield return _gameMethods.Transition(time:0.9f);
        yield return _gameMethods.Show("cg_bai_kiss_secret_layered", parts: new List<string>{"yan2"});
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.OpenDialog(6350); // "他的眼睛在一瞬间微微睁大。"
        yield return _gameMethods.OpenDialog(6351); // "雪白眼睫下的蓝色双瞳..."
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(216f, -162f)}})});
        yield return _gameMethods.OpenDialog(6352); // "我眨了眨眼睛，同他对视。"
        yield return _gameMethods.OpenDialog(6353); // "在这双蓝瞳最底部的深处..."
        yield return _gameMethods.OpenDialog(6354); // "那里漂浮着一片庞大而透明的虚无之海..."
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.5f, "audio/sound/manbu/Body1_02_duan.mp3");
        yield return _gameMethods.OpenDialog(6355); // "像是被引诱了，我忍不住将头向前凑了些许..."
        yield return _gameMethods.PlaySound("sounda", 0.0f, 0.7f, "audio/sound/houhui/Tight Face_02_duan.mp3");
        yield return _gameMethods.Show("cg_bai_kiss_secret_layered", parts: new List<string>{"yan3"});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(6356); // "他的瞳孔收紧微缩。"
        yield return _gameMethods.OpenDialog(6357); // "隔着一根手指..."
        yield return _gameMethods.OpenDialog(6358); // "嘴上的触感如此清晰。"
        yield return _gameMethods.OpenDialog(6359); // "双唇却连一丁点的接触都没有。"
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 5;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.PlaySound("sound", 0.0f, 2f, "<from 0 to 0.7>audio/sound/manbu/Heartbeat Slow Motion_01.ogg");
        yield return _gameMethods.OpenDialog(6360); // "——砰。"
        yield return _gameMethods.Show("cg_bai_kiss_secret_layered", parts: new List<string>{"yan0"});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(6361); // "我听到胸腔中的心脏重重地跳动了一下。"
        yield return _gameMethods.OpenDialog(6362); // "如冰雪融化，新芽萌发。"
        yield return _gameMethods.Show("cg_bai_kiss_secret_layered", parts: new List<string>{"yan1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(276f, -126f)}, {"zoom", 0.47f}})});
        yield return _gameMethods.Transition(time:0.9f);
        yield return _gameMethods.OpenDialog(6363); // "——不，不是我的心在跳动。"
        yield return _gameMethods.OpenDialog(6364); // "……是、他的心在跳动？"
        yield return _gameMethods.Show("black", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 50f}, {"zoom", 2f}, {"yoffset", -200f}})});
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/houhui/Body3 _01.mp3");
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.OpenDialog(6365); // "在心中默数三秒，我松开他的衣服..."
        yield return _gameMethods.Hide("cg_bai_kiss_secret_layered");
        yield return _gameMethods.Hide("black");
        Defaults.Gui_duihuakuang_you = 1;
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan16", "zui9"});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"zpos", -66.0f}, {"xpos", 0f}, {"ypos", 0f}})});
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei1", "yan9", "zui19"});
        yield return _gameMethods.OpenDialog(6366); // "这就是我给你的礼物了，诺伯拉。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui9"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan4", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei1", "yan9", "zui7"});
        yield return _gameMethods.OpenDialog(1378); // "「……{nw}{w=0.3}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(1265); // "……」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui5"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(6367); // "真是新奇的体验。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(6368); // "他沉思片刻。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6369); // "「有点奇妙，明明你已经把礼物给了我..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6370); // "为什么我反而开始不满足了呢。」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan9", "zui5"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei8", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(6371); // "现在，我开始想得到你真正的吻了。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui4"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(6372); // "我想得到你…真正的爱。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui12"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(5003); // "「嗯——{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui16"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6373); // "这算是欲擒故纵？」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan8", "zui19"});
        yield return _gameMethods.OpenDialog(6374); // "「或许吧。{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan11", "zui4"});
        yield return _gameMethods.OpenDialog(6375); // "我成功了吗？」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(6376); // "非常。\n你还真是明白我会吃哪一套呢。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan12", "zui19"});
        yield return _gameMethods.OpenDialog(6377); // "运气好猜中了而已。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan8", "zui7"});
        yield return _gameMethods.OpenDialog(6378); // "呀，是吗？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui19"});
        yield return _gameMethods.OpenDialog(6067); // "「那么，{nw}{w=0.01}"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1>audio/sound/jiaobusheng_xin_normal1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}, {"zpos", -66.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.57f}, {"ypos", -24f}, {"zpos", -120.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
        yield return _gameMethods.OpenDialog(6379); // "做个约定吧。」"
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan6", "zui19"});
        yield return _gameMethods.OpenDialog(6380); // "「如果我活到了决战之日以后，{nw}{w=0.1}"
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui3"});
        yield return _gameMethods.OpenDialog(6381); // "到时候，我会尝试去爱上你，{nw}{w=0.1}"
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan5", "zui3"});
        yield return _gameMethods.OpenDialog(6382); // "给你一个真正的礼物。」"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -24f}, {"zpos", -120.0f}})});
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(6383); // "好啊，我会为此而努力的。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(6384); // "毕竟，如果你失败了，我也会感到可惜。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan2", "zui10"});
        yield return _gameMethods.OpenDialog(6385); // "「居然有可能让你产生惋惜，{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan10", "zui19"});
        yield return _gameMethods.OpenDialog(6386); // "还真是受宠若惊。」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei8", "yan10", "zui8"});
        yield return _gameMethods.OpenDialog(3621); // "是啊。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(6387); // "谁知道呢。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6388); // "「也许，{nw}{w=0.01}"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.7>audio/sound/jiaobusheng_nuo_normal1.ogg");
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"lv1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 24.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.56f}, {"zpos", 42.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6389); // "我还会感觉……」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"lv1", "mei7", "yan9", "zui9"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 42.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei8", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(1543); // "「……{nw}{w=0.4}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(1265); // "……」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(1378); // "「……{nw}{w=0.3}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei4", "yan1", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6390); // "哈啊——……{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6391); // "真是的，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei11", "yan11", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6392); // "该不会我才是那个猎物吧？」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei11", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan2", "zui14", "emoji12"});
        yield return _gameMethods.OpenDialog(6393); // "我用清澈无知的眼神，坦坦荡荡地回看他。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.7>audio/sound/jiaobusheng_nuo_normal1.ogg");
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"lv1", "mei6", "yan1", "zui14"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 42.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.56f}, {"zpos", 24.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei8", "yan2", "zui14", "-emoji12"});
        yield return _gameMethods.OpenDialog(6394); // "……呵呵，好吧。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"lv1", "mei7", "yan11", "zui13"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 24.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(6395); // "你赢了，了不起的公主殿下。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan14", "zui16"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei8", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(6396); // "我缴械投降。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(6397); // "那么，你可以发表一下胜利感言了..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan11", "zui2"});
        yield return _gameMethods.OpenDialog(6398); // "你愿意帮我到什么程度呢？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei8", "yan2", "zui7"});
        yield return _gameMethods.OpenDialog(5003); // "「嗯——{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6399); // "现在的话，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui3"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6400); // "说不定无论你提出什么要求，我都会答应哦。」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(6401); // "在决战那天，请你出战。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei8", "yan5", "zui8"});
        yield return _gameMethods.OpenDialog(6402); // "「好吧，预料之中。{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6403); // "\n我会尽力的，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6404); // "毕竟现在我也不想看到你失败呢。」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan10", "zui10"});
        yield return _gameMethods.OpenDialog(1597); // "「不，"
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan8", "zui10"});
        yield return _gameMethods.OpenDialog(6405); // "……我是想拜托你、去保护人类那边的勇者……」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan8", "zui5"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:7f);
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan12", "zui10"});
        yield return _gameMethods.OpenDialog(6406); // "他们，是我很重要的……朋友，家人。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan20", "zui9"});
        yield return _gameMethods.OpenDialog(6407); // "比我的，……生命、更加重要。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 2f, "audio/sound/manbu/Body1_02_duan.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -24f}, {"zpos", -120.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.30f}, {"ypos", -54f}, {"zpos", -162.0f}})});
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan17", "zui10"});
        yield return _gameMethods.OpenDialog(6408); // "所以，拜托你了……"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui9"});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -54f}, {"zpos", -162.0f}})});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei8", "yan17", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui16"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6409); // "「……嗯，所以，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui3"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6410); // "你是在当着我的面想着别的朋友？」"
        yield return _gameMethods.PlaySound("music1", 0.0f, 1.0f, "audio/music/bing_richang1.mp3");
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan2", "zui15", "emoji12"});
        yield return _gameMethods.OpenDialog(165); // "？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan10", "zui19", "emoji2", "emoji3", "-emoji12"});
        yield return _gameMethods.OpenDialog(6411); // "{size=+10}不是，我们两个的关系有这么亲近吗。{/size}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei3", "yan10", "zui7", "emoji2", "-emoji3"});
        yield return _gameMethods.OpenDialog(6412); // "「毕竟你已经做出了要爱上我的誓言..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan14", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6413); // "按照人类社会的准则..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan14", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui8", "emoji2", "emoji6"});
        yield return _gameMethods.OpenDialog(6414); // "你对伴侣关系有什么误解。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei11", "yan2", "zui15"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(226); // "{nw}{w=0.2}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei11", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15", "-emoji2", "-emoji6"});
        yield return _gameMethods.OpenDialog(6415); // "我并未把腹诽说出口..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan10", "zui15"});
        yield return _gameMethods.OpenDialog(6416); // "因为从他的表情上看，这家伙是故意的。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan24", "zui15"});
        yield return _gameMethods.OpenDialog(6417); // "真是恶劣又坏心眼的玩笑..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui16"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(6418); // "不过——"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(6419); // "还是令人不悦啊。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(6420); // "「明明刚刚做出了并不爱我的发言..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6421); // "却当着我的面，展露你对别人的真情。」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui16"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(6422); // "真的不怕我发火吗？"
        yield return _gameMethods.OpenSelectMenu(talk: new List<string>{"-不怕", "-你不会发火的"}, jump: new List<string>{"label_bai1_menu_0_bufa", "label_bai1_menu_0_buhuifa"}, condition: new List<string>{"NONE", "NONE"});
    }

    public IEnumerator label_zhuxian6_5()
    {
        yield return _gameMethods.OpenSelectMenu(talk: new List<string>{"-你还没有得到我", "-你是我最最亲爱的诺伯拉呀"}, jump: new List<string>{"label_bai1_menu_0_meidedao", "label_bai1_menu_0_qinaide"}, condition: new List<string>{"NONE", "NONE"});
    }

    public IEnumerator label_zhuxian6_9()
    {
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei8", "yan17", "zui7"});
        yield return _gameMethods.OpenDialog(6456); // "「……{nw}{w=0.01}"
        yield return _gameMethods.StopSound(channelName:"music1", fadeOut:4f);
        Defaults.Persistent.Jq_9_3 = 1;
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6457); // "小公主，你喜欢散步吗？」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(6458); // "他忽然问。"
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10"});
        yield return _gameMethods.OpenDialog(6459); // "挺喜欢的。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.PlaySound("music2", 0.0f, 1.0f, "audio/music/One_spring_day.mp3");
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(6460); // "「我之前说过要带你去湖边散步..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6461); // "不如就现在吧。」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(6462); // "现在吗？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(6463); // "为什么不呢。"
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(6464); // "他牵住了我的一只手。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo");
        yield return _gameMethods.OpenDialog(6465); // "走这里。"
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<silence 1><from 0 to 2>audio/sound/jiaobusheng_nuo_normal1.ogg");
        yield return _gameMethods.Scene("woshi_nv1_yewan_yangtai_ani", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.03f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.71f}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", -200f}, {"yoffset", -230f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}, {"pause", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 2f}, {"zpos", -300f}})});
        yield return _gameMethods.Transition(time:1.7f);
        yield return _gameMethods.OpenDialog(6466); // "引着我步近了露台栏杆。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui15", "emoji12"});
        yield return _gameMethods.OpenDialog(924); // "……？"
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nv", parts: new List<string>{"mei7", "yan6", "zui15"});
        yield return _gameMethods.OpenDialog(6467); // "（从这里走？是比较快吗。）"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -300f}})});
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"lv1", "mei11", "yan2", "zui16"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.32f, 2.25f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.44f}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}, {"blur", 0.01f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1f}, {"blur", 0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan6", "zui15", "-emoji12"});
        yield return _gameMethods.OpenDialog(6468); // "噗。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(6469); // "……嗯，是啊。"
        yield return _gameMethods.PlaySound("sounda", 0.0f, 0.5f, "<from 0 to 0.5>audio/sound/jiaobusheng_nuo_normal1.ogg");
        yield return _gameMethods.PlaySound("sound", 0.0f, 2f, "<silence 0.4>audio/sound/manbu/Body1_01.mp3");
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"lv1", "mei7", "yan11", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.32f}, {"alpha", 1f}, {"blur", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 1.4f}, {"xpos", 0.2f}})});
        yield return _gameMethods.OpenDialog(6470); // "夜空墨蓝，月光皎洁..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"lv1", "mei7", "yan2", "zui14"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.2f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nuo");
        yield return _gameMethods.OpenDialog(6471); // "跳上去试试。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(6472); // "……有一瞬间，我怀疑他在拿我寻开心。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(6473); // "不过，既然他如此说了..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(6474); // "毕竟，他没有在这时和我开玩笑的理由。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei4", "yan13", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo");
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<silence 0.5><from 0 to 1>audio/sound/jiaobusheng_xin_man1.ogg");
        yield return _gameMethods.Hide("nuo1");
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -300f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.4f}, {"zpos", -318f}})});
        yield return _gameMethods.OpenDialog(6475); // "我原地掂了踮脚，"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -318f}})});
        yield return _gameMethods.OpenDialog(6476); // "犹豫片刻，"
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.8f, "audio/sound/manbu/Silence+Other Sounds _01.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"bop_in_time_warp", 0.5f}, {"ypos", -66f}})});
        yield return _gameMethods.OpenDialog(6477); // "双脚踩着地面轻轻蹦了一下。"
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/emeng_dajie/magic1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -66f}})});
        yield return _gameMethods.OpenDialog(6478); // "悬空的瞬间，我意识到..."
        yield return _gameMethods.OpenDialog(6479); // "就像被空气托住一般..."
        yield return _gameMethods.PlaySound("sounda1", 0.0f, 1.0f, "audio/sound/manbu/Body1_01.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -66f}, {"zpos", -318f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.8f}, {"ypos", -18f}, {"zpos", -462f}})});
        yield return _gameMethods.OpenDialog(6480); // "与此同时，牵着我的手的诺伯拉也跨了一步..."
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/manbu/Sole_01.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -18f}, {"zpos", -462f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.20f}, {"ypos", -5f}})});
        yield return _gameMethods.OpenDialog(6481); // "停驻在栏杆上。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -5f}})});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.OpenDialog(6482); // "好好玩。"
        yield return _gameMethods.PlaySound("soundb", 1f, 2f, "audio/sound/manbu/Blowing at a Suburban Street  Windy Weather Draught _01.ogg");
        yield return _gameMethods.Show("cg_manbu_gaokong_ani", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.53f, 0.78f)}, {"zoom", 0.52f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(6483); // "相距十几米的地面就悬在脚下..."
        yield return _gameMethods.Show("cg_manbu_gaokong", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.53f, 0.78f)}, {"zoom", 0.52f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.5f}, {"alpha", 1f}})});
        yield return _gameMethods.OpenDialog(6484); // "但或许是由于身边青年的存在..."
        yield return _gameMethods.Show("cg_manbu_gaokong", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
        yield return _gameMethods.OpenDialog(6485); // "反而涌上了一股期待打破常规..."
        yield return _gameMethods.ExecuteCharacterImageData("nuo");
        yield return _gameMethods.OpenDialog(6486); // "来，向前走一步看看。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/manbu/Silence+Other Sounds _01.ogg");
        yield return _gameMethods.PlaySound("sounda", 0.0f, 0.4f, "audio/sound/emeng_dajie/magic1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -462f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.38f}, {"zpos", -490f}})});
        yield return _gameMethods.StopSound(channelName:"music2", fadeOut:4f);
        yield return _gameMethods.OpenDialog(6487); // "我试探性地迈出一步..."
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -490f}})});
        yield return _gameMethods.OpenDialog(6488); // "触感……宛若踩在气垫上..."
        yield return _gameMethods.Scene("black", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 2f}, {"yoffset", -300f}})});
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.5f, "audio/sound/manbu/Silence+Other Sounds _01.ogg");
        yield return _gameMethods.PlaySound("sounda", 0.0f, 0.5f, "audio/sound/emeng_dajie/magic1.ogg");
        yield return _gameMethods.OpenDialog(6489); // "第二步。"
        Defaults.Gui_duihuakuang_you = 0;
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
        yield return _gameMethods.PlaySound("sounda", 0.0f, 2f, "audio/sound/emeng_dajie/magic1.ogg");
        yield return _gameMethods.OpenDialog(6490); // "第三步。"
        yield return _gameMethods.PlaySound("sound", 0.6f, 1.0f, "audio/sound/manbu/Air Magic Gust of Wind_01.ogg");
        yield return _gameMethods.Show("cg_manbu_ani1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"xpos", 0.0f}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.7f}, {"ypos", 0.3f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"alpha", 1f}})});
        yield return _gameMethods.Show("2-27_zoom");
        yield return _gameMethods.Hide("2-27_zoom");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 330f}}), new SameLineParamData(new Dictionary<string, object>{{"ease_cubic", 2f}, {"ypos", 100f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.PlaySound("music", 0.2f, 1.0f, "audio/music/under_star.mp3");
        yield return _gameMethods.OpenDialog(6491); // "慢悠悠地、富有节奏，在空中漫步..."
        yield return _gameMethods.Transition(time:2f);
        yield return _gameMethods.OpenDialog(6492); // "月光流泻，云层拨开。"
        yield return _gameMethods.OpenDialog(6493); // "露出树在夜色中参差不齐..."
        yield return _gameMethods.Scene("cg_manbu_ani1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.18f, 0.36f)}, {"zoom", 0.37f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
        yield return _gameMethods.Transition(time:1f);
        yield return _gameMethods.OpenDialog(6494); // "远方模糊蛰伏的群山连绵..."
        yield return _gameMethods.ExecuteCharacterImageData("nv2");
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("manbu_snow_white_small_fast");
        yield return _gameMethods.Show("dust_particles");
        yield return _gameMethods.Transition(time:1f);
        yield return _gameMethods.OpenDialog(6495); // "一些星星点点的冷绿荧光缓缓冒出..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai1");
        yield return _gameMethods.OpenDialog(6496); // "（……这是，萤火虫？）"
        yield return _gameMethods.OpenDialog(6497); // "它们轻飘飘的、幽浮着在上空汇聚..."
        yield return _gameMethods.OpenDialog(6498); // "星星和月亮都远去了..."
        yield return _gameMethods.OpenDialog(6499); // "黑黢黢的天地间只剩下那些亮起的绿光..."
        yield return _gameMethods.PlaySound("sounda", 0.0f, 0.4f, "<from 0 to 0.3>audio/sound/manbu/Sole_01.mp3");
        yield return _gameMethods.PlaySound("sound", 0.0f, 2f, "audio/sound/emeng_dajie/magic1.ogg");
        yield return _gameMethods.OpenDialog(6500); // "我忍住了没有伸手去触摸..."
        yield return _gameMethods.PlaySound("sounda1", 0.0f, 1.4f, "audio/sound/manbu/Body1_01.mp3");
        yield return _gameMethods.OpenDialog(6501); // "诺伯拉心领神会，驻足耐心等待。"
        yield return _gameMethods.Hide("dust_particles");
        yield return _gameMethods.Hide("manbu_snow_white_small_fast");
        yield return _gameMethods.Show("manbu_snow_white_small_fast1");
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(6502); // "萤火萦绕着我们，转了两圈..."
        yield return _gameMethods.PlaySound("sound", 0.6f, 2f, "audio/sound/emeng_dajie/magic1.ogg");
        yield return _gameMethods.OpenDialog(6503); // "我忍不住跟着它们。"
        yield return _gameMethods.OpenDialog(6504); // "诺伯拉顺从着我的脚步。"
        yield return _gameMethods.PlaySound("sounda1", 0.0f, 2f, "audio/sound/emeng_dajie/magic1.ogg");
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.2f, "audio/sound/manbu/Light Wind Passing By_01.ogg");
        yield return _gameMethods.Show("dust_particles");
        yield return _gameMethods.Transition(time:1f);
        yield return _gameMethods.OpenDialog(6505); // "我们跟随着那断断续续、晃晃悠悠的窄队..."
        yield return _gameMethods.PlaySound("soundc", 2f, 3f, "audio/sound/manbu/Gentle Breeze Blowing Foliage Rustling_01.ogg");
        yield return _gameMethods.OpenDialog(6506); // "那里是一片波光粼粼的湖泊..."
        yield return _gameMethods.OpenDialog(6507); // "萤火虫明灭的光亮..."
        yield return _gameMethods.PlaySound("soundd", 0.0f, 1.0f, "audio/sound/manbu/Heartbeat Slow Motion_01.ogg");
        yield return _gameMethods.OpenDialog(6508); // "我不自觉屏住呼吸..."
        yield return _gameMethods.OpenDialog(6509); // "那兴奋降落..."
        yield return _gameMethods.StopSound(channelName:"soundd", fadeOut:3f);
        yield return _gameMethods.Hide("manbu_snow_white_small_fast1");
        yield return _gameMethods.Hide("dust_particles");
        yield return _gameMethods.Transition(time:0.6f);
        yield return _gameMethods.OpenDialog(6510); // "渐渐的，萤火虫隐没。"
        yield return _gameMethods.OpenDialog(6511); // "周围的一切都不复存在了..."
        yield return _gameMethods.OpenDialog(6512); // "感动却依然撑满了我的整个胸腔..."
        yield return _gameMethods.OpenDialog(6513); // "一种生命闪烁、宇宙永恒..."
        yield return _gameMethods.OpenDialog(1926); // "………"
        yield return _gameMethods.OpenDialog(6514); // "我久久说不出话来。"
        yield return _gameMethods.OpenDialog(6515); // "寂静良久，诺伯拉开口。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo");
        yield return _gameMethods.OpenDialog(6516); // "开心吗？"
        yield return _gameMethods.ExecuteCharacterImageData("nv2");
        yield return _gameMethods.OpenDialog(765); // "嗯。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo");
        yield return _gameMethods.OpenDialog(6517); // "这是给你的谢礼。"
        yield return _gameMethods.ExecuteCharacterImageData("nv2");
        yield return _gameMethods.OpenDialog(6518); // "谢礼？"
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nuo");
        yield return _gameMethods.OpenDialog(6519); // "谢谢你，小公主..."
        yield return _gameMethods.ExecuteCharacterImageData("nv2");
        yield return _gameMethods.OpenDialog(4); // "……"
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nuo");
        yield return _gameMethods.OpenDialog(6520); // "况且，你一直努力了那么久..."
        yield return _gameMethods.ExecuteCharacterImageData("nv2");
        yield return _gameMethods.OpenDialog(6521); // "这个奖励很有效。谢谢。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo");
        yield return _gameMethods.OpenDialog(6522); // "呵呵。"
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nuo");
        yield return _gameMethods.OpenDialog(6523); // "我很好奇故事的结尾..."
        yield return _gameMethods.ExecuteCharacterImageData("nv2");
        yield return _gameMethods.OpenDialog(6524); // "留下了，他爱上了她。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo");
        yield return _gameMethods.OpenDialog(6525); // "真不错，一个美满的结局。"
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(6526); // "我们静静的看着夜幕中的景色。"
        yield return _gameMethods.Scene("cg_manbu_ani2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.18f, 0.36f)}, {"zoom", 0.37f}})});
        yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:3f);
        yield return _gameMethods.StopSound(channelName:"soundc", fadeOut:3f);
        Defaults.Gui_duihuakuang_you = 1;
        yield return _gameMethods.Transition(time:0.9f);
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:6f);
        yield return _gameMethods.ChangeLabelTo("label_zhuxian6_3");
    }
}
