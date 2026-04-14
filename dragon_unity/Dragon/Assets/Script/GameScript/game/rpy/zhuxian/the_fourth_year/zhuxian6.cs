using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zhuxian6 : ILabelProvider
{
    private GameMethods _gameMethods;

    public zhuxian6(GameMethods gameMethods)
    {
        _gameMethods = gameMethods;
    }

    public IEnumerator label_zhuxian6()
    {
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.PlaySound("soundb", 0.0f, 1.0f, "audio/sound/bilu.ogg");
        yield return _gameMethods.Scene("woshi_nv2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"ypos", 1.02f}, {"zoom", 0.52f}, {"xpos", 0.5f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Transition(time:0.5f);
        Defaults.Persistent.Jq_8_5 = 1;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(7797); // "我来到城堡后的第三个冬天，在安静中度过。"
        yield return _gameMethods.PlaySound("music1", 2.0f, 1.0f, "audio/demo_audio/music/youshang2.mp3");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(7798); // "整个冬天，我缩在壁炉边，铆足了一股劲头，想编写出..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(7799); // "但能供我实践的时间却十分有限。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7800); // "出于尽量隐藏底牌的目的，在赫泽尔面前时，我基本只..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan20", "zui7"});
        yield return _gameMethods.OpenDialog(7801); // "这听起来似乎有些可笑，人类有几斤几两，值得在强大..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan21", "zui15"});
        yield return _gameMethods.OpenDialog(7802); // "但我的确不由自主地这样做了。"
        yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:4.0f);
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 2>audio/sound/jiaobusheng_xin_normal1.ogg");
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<silence 0.4>audio/sound/door_open_3.mp3");
        yield return _gameMethods.Scene("heilong_shufang_baitian_quanjing");
        yield return _gameMethods.TransitionBy("trans_rip_fast");
        yield return _gameMethods.OpenDialog(7803); // "………说实话，随着彼此了解日渐加深，我能察觉到赫..."
        yield return _gameMethods.PlaySound("sounda1", 0.0f, 1.0f, "<from 0 to 1.5>audio/sound/jiaobusheng_xin_normal1.ogg");
        yield return _gameMethods.PlaySound("sounda2", 0.2f, 0.4f, "<silence 1.2>audio/demo_audio/sound/moca2.mp3");
        yield return _gameMethods.Scene("heilong_shufang_baitian_quanjing1");
        yield return _gameMethods.Show("shuben", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 300.0f}, {"xoffset", 170.0f}})});
        yield return _gameMethods.Transition(time:0.6f);
        yield return _gameMethods.OpenDialog(7804); // "所以，不可否认地，我也真的产生过一丝期盼，希望能..."
        yield return _gameMethods.OpenDialog(7805); // "指望着，可以凭借这个孩子对我的感情，保全性命。"
        yield return _gameMethods.Show("heilong_shufang_baitian_shafa", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.24f, 2.68f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 2.35f}, {"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.8f}, {"alpha", 1.0f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 2.72f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.59f}, {"alpha", 0.0f}, {"blur", 0.01f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.8f}, {"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"easein", 1.0f}, {"yoffset", -100.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(7806); // "然而，在之前几次对话中，对于我的委婉试探，赫泽尔..."
        yield return _gameMethods.PlaySound("sound", 0.2f, 0.4f, "audio/demo_audio/sound/moca2.mp3");
        yield return _gameMethods.Show("he", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.Show("heilong_shufang_baitian_shafa", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", -100.0f}})});
        yield return _gameMethods.Show("shuben", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 300.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.8f}, {"yoffset", 400.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7807); // "这让我的心渐渐沉了下去。"
        yield return _gameMethods.Show("shuben", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 400.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15"});
        yield return _gameMethods.OpenDialog(7808); // "我想……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(7809); // "“他对我的态度与众不同”，"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei8", "yan20", "zui15"});
        yield return _gameMethods.OpenDialog(7810); // "——这大概只是人类一厢情愿、自我陶醉的错觉。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan12", "zui5"});
        yield return _gameMethods.OpenDialog(7811); // "又或者，即便对我有点兴趣，这点兴致足以令他给我提..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(7812); // "却没有大到足以让他放过我所能带来的利益的程度。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan21", "zui15"});
        yield return _gameMethods.OpenDialog(7813); // "毕竟，对于一些人——"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(7814); // "乃至很多人来说，爱都并非生命里最重要的东西。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan18", "zui15"});
        yield return _gameMethods.OpenDialog(7815); // "此外，还有一种可能。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(7816); // "我猜，即使身为比我更强大的存在，在预言、身份与职..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan20", "zui15"});
        yield return _gameMethods.OpenDialog(7817); // "放过我，他约莫也是要付出代价的。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(7818); // "比如，无法顺利过渡到成长期，无法消除神圣血脉带给..."
        yield return _gameMethods.PlaySound("sound", 0.2f, 0.2f, "audio/demo_audio/sound/moca2.mp3");
        yield return _gameMethods.Show("heilong_shufang_baitian_shafa", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.8f}, {"alpha", 0.0f}})});
        yield return _gameMethods.Show("he", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 0.01f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.8f}, {"alpha", 0.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.Show("shuben", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 400.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.8f}, {"yoffset", 300.0f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(7819); // "……总之，倘若赫泽尔果真打算放了我，那他没理由不..."
        yield return _gameMethods.Hide("heilong_shufang_baitian_shafa");
        yield return _gameMethods.Hide("he");
        yield return _gameMethods.Show("shuben", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 300.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan17", "zui15"});
        yield return _gameMethods.OpenDialog(7820); // "而如今，他却不置可否，没有半点表示。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(7821); // "这本身就是一种态度。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.PlaySound("sounda", 0.0f, 0.3f, "<silence 0.3>audio/demo_audio/sound/moca2.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", -100.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.8f}, {"yoffset", -200.0f}})});
        yield return _gameMethods.Show("shuben", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 300.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.8f}, {"yoffset", 600.0f}})});
        yield return _gameMethods.Show("heilong_shufang_baitian_ding1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"ypos", 0.8f}, {"zoom", 0.78f}, {"xpos", 0.5f}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"alpha", 1.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan21", "zui15"});
        yield return _gameMethods.OpenDialog(7822); // "……有时，我真的好想干脆问他，能否放了我。"
        yield return _gameMethods.Show("shuben", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 600.0f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", -200.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7823); // "但从理智上又明白，我不能、也不会如此做。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(7824); // "因为事情一旦问出口，就泄露了我对它在意的态度。"
        yield return _gameMethods.Show("heilong_shufang_baitian_ding1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7825); // "背后隐藏的信息，是我“想活着”。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(7826); // "这如同博弈，一旦失败，就有打草惊蛇的风险。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7827); // "若他加强了对我的警惕，会对我之后可能逃跑的行动产..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(7828); // "所以。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7829); // "在他面前，我不能暴露出对力量的过度追求和掌握。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan17", "zui15"});
        yield return _gameMethods.OpenDialog(7830); // "我应该是无害的，纯良的，没有威胁的，百依百顺的。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7831); // "甘愿接受他的一切决定，对他永远忠贞，永无反抗之心..."
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.Show("heilong_shufang_bangwan3", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"ypos", 0.8f}, {"zoom", 0.78f}, {"xpos", 0.5f}})});
        yield return _gameMethods.TransitionWithFadeIn(outTime:0.6f, holdTime:0.1f, inTime:0.9f, colorCode:"#000");
        yield return _gameMethods.OpenDialog(33); // "………………"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan18", "zui15"});
        yield return _gameMethods.OpenDialog(7832); // "——因此，我打算只有等独自外出时，才开始测试魔法..."
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1>audio/sound/jiaobusheng_xin_normal1.ogg");
        yield return _gameMethods.Scene("woshi_nv4", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"ypos", 1.02f}, {"zoom", 0.52f}, {"xpos", 0.5f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}})});
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/demo_audio/sound/door_close1.mp3");
        yield return _gameMethods.PlaySound("soundb", 0.0f, 1.0f, "audio/sound/bilu.ogg");
        yield return _gameMethods.Hide("shuben");
        yield return _gameMethods.TransitionBy("trans_rip_fast");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(7833); // "然而，整个天寒地冻的冬天，我的外出活动被禁止了。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(7834); // "只能躲在室内，听着壁炉中木柴劈里啪啦的燃烧声，挖..."
        yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:4.0f);
        yield return _gameMethods.Scene("heilong_dating_baitian", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.23f)}, {"anchor", new Vector2(0.5f, 1.0f)}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(7835); // "……间或，我也会起身锻炼身体。"
        yield return _gameMethods.OpenDialog(7836); // "在安静的城堡中反复上下楼梯、跑跑跳跳，闹出不小的..."
        yield return _gameMethods.OpenDialog(7837); // "赫泽尔放任了我的行为，他认为健康的体魄能减少疾病..."
        yield return _gameMethods.EngineSetVolume(volume:0.2f, delay:2.0f, channelName:"music1");
        yield return _gameMethods.PlaySound("soundc", 0.0f, 1.5f, "audio/sound/dashuizhang/Bird Amb_01.ogg");
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(7838); // "随着嫩芽萌发，春季如约而至。"
        yield return _gameMethods.Scene("xiaolu3");
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.EngineSetVolume(volume:1.0f, delay:2.0f, channelName:"music1");
        yield return _gameMethods.OpenDialog(7839); // "我带着一整个冬日里思考出的大堆咒语，来到野外，逐..."
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/emeng_dajie/magic1.ogg");
        yield return _gameMethods.PlaySound("sounda5", 0.0f, 0.7f, "audio/sound/juezhan2/Ice Cracking Pile of Snow Falling_01.ogg");
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.OpenDialog(7840); // "失败了。"
        yield return _gameMethods.PlaySound("sounda1", 0.0f, 0.8f, "audio/sound/juezhan2/Magical Blast_01.ogg");
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.OpenDialog(7841); // "这一个也失败了。"
        yield return _gameMethods.OpenDialog(7842); // "能量在即将凝聚成形的那一瞬间，忽然扭曲瓦解，崩溃..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei6", "yan3", "zui14", "emoji2"});
        yield return _gameMethods.OpenDialog(7843); // "好难啊。这真的是人类做得到的事情吗。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.7f, "audio/sound/emeng_dajie/Lying Bed_01.mp3");
        yield return _gameMethods.StopSound(channelName:"soundc", fadeOut:3.0f);
        yield return _gameMethods.Scene("senlin3", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"xpos", 0.5f}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 1.14f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 1.0f}, {"ypos", 1.13f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(7844); // "我前所未有的地怀疑起人生。"
        yield return _gameMethods.OpenDialog(7845); // "热的；明亮的；危险的；运动的；能量的……这样还是..."
        yield return _gameMethods.OpenDialog(7846); // "或许我对于火这种事物还是了解太少。"
        yield return _gameMethods.Show("senlin3", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 1.13f}})});
        yield return _gameMethods.OpenDialog(7847); // "那么，换成日常中接触得更多的水呢？"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0.5 to 3>audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
        yield return _gameMethods.Scene("senlin4", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.03f)}, {"zoom", 0.7f}})});
        yield return _gameMethods.TransitionBy("trans_rip_fast");
        yield return _gameMethods.OpenDialog(7848); // "透明的；流动的；母亲的；生命的……不行，不够。"
        yield return _gameMethods.OpenDialog(7849); // "光是了解它还不够，我能觉察到，还必须有一种息息相..."
        yield return _gameMethods.OpenDialog(7850); // "一种“领悟”。"
        yield return _gameMethods.StopSound(channelName:"music1", fadeOut:2.0f);
        yield return _gameMethods.PlaySound("sounda", 0.0f, 0.7f, "audio/sound/he/chui_sha.mp3");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan9", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(7851); // "我烦躁地锤了地面一拳，盯着潭水的表面。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}, {"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 2.5f}, {"ypos", 114.0f}, {"zpos", -282.0f}})});
        yield return _gameMethods.PlaySound("soundb", 0.0f, 1.0f, "audio/sound/dashuizhang/Spilling Stream Into Creek Gurgling Water_01.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7852); // "清幽的水，犹如一块剔透的宝石。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan21", "zui15"});
        yield return _gameMethods.OpenDialog(7853); // "像要被它吸入进去一般。"
        yield return _gameMethods.PlaySound("music", 0.0f, 0.7f, "audio/music/kepa/PerituneMaterial_Ominous.mp3");
        yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:10.0f);
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei6", "yan21", "zui15"});
        yield return _gameMethods.OpenDialog(7854); // "……渐渐的，我的心头升起一股因自己的弱小，而产生..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7855); // "两年。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7856); // "我在黑龙城堡里已呆了两年。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7857); // "寄人篱下，命运不由自主。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7858); // "即便努力地挣扎，拼命地学习，可一切仿佛都未曾改变..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei6", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(7859); // "自幼检测不出魔法天赋，觉醒不了血脉力量，学会的文..."
        yield return _gameMethods.OpenDialog(7860); // "如今依旧如此。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 114.0f}, {"zpos", -282.0f}})});
        yield return _gameMethods.OpenDialog(7861); // "宛若冥冥之中有哪个意志在告诫我，即使学了真言，魔..."
        yield return _gameMethods.OpenDialog(7862); // "……为什么。凭什么。"
        yield return _gameMethods.OpenDialog(7863); // "给我一次机会啊……！"
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 2;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.OpenDialog(7864); // "弱者就只能一辈子，做不出一次像样的挣扎，发不出一..."
        yield return _gameMethods.OpenDialog(7865); // "问题到底出在哪里……"
        yield return _gameMethods.OpenDialog(7866); // "到底要我怎么做。"
        yield return _gameMethods.PlaySound("sounda4", 0.0f, 0.6f, "audio/sound/houhui/Bones Break Cracking_02.ogg");
        yield return _gameMethods.OpenDialog(7867); // "我抓紧了地面的碎石，掌心刺痛，指甲嵌入泥土。"
        yield return _gameMethods.OpenDialog(7868); // "和水接触的还不够……是吗？"
        yield return _gameMethods.OpenDialog(7869); // "那就干脆贴近到底。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -282.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 2.0f}, {"zpos", -354.0f}})});
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0.5 to 2>audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<silence 1.6>audio/sound/dashuizhang/Small Splash_01.mp3");
        yield return _gameMethods.OpenDialog(7870); // "怀着某种决心，我深吸一口气，走进水中。"
        yield return _gameMethods.OpenDialog(7871); // "初春，水温很低。"
        yield return _gameMethods.OpenDialog(7872); // "我一步一步，扛着阻力往更深处走去。"
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:4.0f);
        yield return _gameMethods.PlaySound("sounda1", 0.0f, 1.0f, "audio/sound/dashuizhang/Water Splashing Gently Single Splash_01.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -354.0f}})});
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(7873); // "直到迈过某个界限，踩出最后一脚，进入了深水区。"
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.Show("water_video", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.67f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.PlaySound("music", 0.0f, 0.8f, "audio/music/Deep_Search.mp3");
        yield return _gameMethods.TransitionWithFadeIn(outTime:0.8f, holdTime:0.2f, inTime:1.3f, colorCode:"#000");
        yield return _gameMethods.OpenDialog(7874); // "冰冷的温度。刺骨的寒意。"
        yield return _gameMethods.OpenDialog(7875); // "这种冷水其实会刺激肌肉收缩，即便我懂水性，也极易..."
        yield return _gameMethods.OpenDialog(7876); // "但神奇的是，此刻我很冷静。"
        yield return _gameMethods.OpenDialog(7877); // "我憋着气，潜入水中。"
        yield return _gameMethods.OpenDialog(7878); // "然后，也顾不上这种荒山野岭的水里是不是存在细菌了..."
        yield return _gameMethods.Show("anniu_bg29_memory");
        yield return _gameMethods.Hide("anniu_bg29_memory");
        yield return _gameMethods.PlaySound("sounda5", 0.0f, 3.0f, "audio/sound/he/qipao.mp3");
        yield return _gameMethods.Show("water_shuixia1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"xpos", 0.5f}, {"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 1.0f}, {"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 3.0f}, {"ypos", 1.35f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.0f}, {"alpha", 1.0f}, {"parallel_1", true}})});
        yield return _gameMethods.TransitionBy("blink2");
        yield return _gameMethods.OpenDialog(7879); // "一连串气泡从嘴中呼出。"
        yield return _gameMethods.OpenDialog(7880); // "水下的世界，静谧美丽。"
        yield return _gameMethods.OpenDialog(7881); // "仔细观察周围许久。"
        yield return _gameMethods.OpenDialog(7882); // "我感受着水的美丽，透明，变幻莫测，不可捉摸。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.8f, "audio/sound/houhui/Tight Face_02_duan.mp3");
        yield return _gameMethods.PlaySound("soundb", 0.5f, 2.0f, "audio/sound/heartbeats_01.ogg");
        yield return _gameMethods.OpenDialog(7883); // "渐渐地，氧气有些不足。"
        yield return _gameMethods.Show("water_shuixia1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}, {"ypos", 1.35f}})});
        yield return _gameMethods.OpenDialog(7884); // "像是漏气的气球，我体内的氧气正逐渐减少。"
        yield return _gameMethods.OpenDialog(7885); // "但我并不害怕，相反我冷静地调整姿势和呼吸系统，尝..."
        yield return _gameMethods.OpenDialog(7886); // "十秒钟，再坚持十秒钟，我就上浮。"
        yield return _gameMethods.OpenDialog(7887); // "此刻我的样子或许很狼狈。头发凌乱地在水中漂浮，面..."
        yield return _gameMethods.OpenDialog(7888); // "但很奇怪，这种设想竟没有影响我的意志一分一毫。"
        yield return _gameMethods.OpenDialog(7889); // "只要学会这魔法。所谓的预言再也管不着我了。"
        yield return _gameMethods.OpenDialog(7890); // "心跳如擂，我像水草一样摇摆，望着上方的水面。"
        yield return _gameMethods.OpenDialog(7891); // "透明的水波中，湖面跳动的光斑，仿佛就在我眼前，只..."
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 2.0f}, {"blur", 5.0f}})});
        yield return _gameMethods.OpenDialog(7892); // "意识愈发清醒。"
        yield return _gameMethods.EngineSetVolume(volume:2.0f, delay:2.0f, channelName:"soundb");
        yield return _gameMethods.OpenDialog(7893); // "憋气几乎要超越极限，肺部仍旧感到充盈。"
        yield return _gameMethods.PlaySound("soundd", 1.0f, 1.0f, "audio/sound/dashuizhang/coming_of_terror.ogg");
        yield return _gameMethods.OpenDialog(7894); // "四周没有空气，包围我的只有水，尽管仍旧寒凉，却如..."
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 5.0f}})});
        yield return _gameMethods.OpenDialog(7895); // "好自如。我双眼微闭，感知四周。"
        yield return _gameMethods.PlaySound("soundc", 0.0f, 1.0f, "audio/sound/bai_yao/SeaWaves_01.ogg");
        yield return _gameMethods.OpenDialog(7896); // "眼前是水，耳边是水，周遭是水。"
        yield return _gameMethods.OpenDialog(7897); // "在那一线之间，我感觉自己的存在正和自然同一。"
        yield return _gameMethods.OpenDialog(7898); // "水包裹着我，轻抚着我，关怀着我，托举着我。"
        yield return _gameMethods.Hide("black");
        yield return _gameMethods.Show("black");
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:1.0f);
        yield return _gameMethods.StopSound(channelName:"soundc", fadeOut:1.0f);
        yield return _gameMethods.StopSound(channelName:"soundd", fadeOut:1.0f);
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/emeng_dajie/magic1.ogg");
        yield return _gameMethods.OpenDialog(7899); // "————"
        yield return _gameMethods.OpenDialog(7900); // "似乎是在某种本能的驱使下，我的嘴唇轻轻开合，无声..."
        yield return _gameMethods.Show("water_shuixia2");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.TransitionBy("blink3");
        yield return _gameMethods.PlaySound("soundc", 0.0f, 2.0f, "audio/sound/bai_yao/SeaWaves_01.ogg");
        yield return _gameMethods.OpenDialog(7901); // "然后。"
        yield return _gameMethods.OpenDialog(7902); // "水回应了我的呼唤。"
        yield return _gameMethods.OpenDialog(7903); // "一股水流在我的身下汇聚，托着我的身体，推向水面。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/dashuizhang/Water Splash Single Short_01.ogg");
        yield return _gameMethods.Scene("senlin4", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.03f)}, {"zoom", 0.7f}})});
        yield return _gameMethods.Transition(time:0.3f);
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:2.0f);
        yield return _gameMethods.StopSound(channelName:"soundc", fadeOut:2.0f);
        yield return _gameMethods.OpenDialog(7904); // "咳咳、咳咳咳！！"
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/dashuizhang/Water Splashing  2_01.mp3");
        yield return _gameMethods.OpenDialog(7905); // "我憋着气扒着岸边站了起来。"
        yield return _gameMethods.OpenDialog(7906); // "急促地喘气，咳嗽。"
        yield return _gameMethods.OpenDialog(7907); // "顾不上平复气息，我激动地呛咳，伸出手，像得到了珍..."
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/emeng_dajie/magic1.ogg");
        yield return _gameMethods.OpenDialog(7908); // "我念出一串形容。"
        yield return _gameMethods.PlaySound("sounda1", 0.0f, 1.0f, "audio/sound/dashuizhang/Small Splash_01.mp3");
        yield return _gameMethods.OpenDialog(7909); // "一串水花从我的手中窜出，如烟花喷泉一般，在半空中..."
        yield return _gameMethods.PlaySound("music1", 0.0f, 1.0f, "audio/demo_audio/music/richang2.mp3");
        yield return _gameMethods.OpenDialog(7910); // "剧烈的狂喜。"
        yield return _gameMethods.OpenDialog(7911); // "一种不真实感。"
        yield return _gameMethods.OpenDialog(7912); // "被水包裹，被水轻抚的柔软触感还残留着，我此刻感到..."
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan12", "zui3"});
        yield return _gameMethods.OpenDialog(5009); // "呵呵……"
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/moca1.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui1"});
        yield return _gameMethods.OpenDialog(7913); // "哈哈哈哈！"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui7"});
        yield return _gameMethods.OpenDialog(7914); // "一种淋漓尽致的畅快，让我情不自禁地笑了出来。"
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/dashuizhang/Water Splashing Gently Single Splash_01.ogg");
        yield return _gameMethods.OpenDialog(7915); // "我爬上了岸，摇摇晃晃地站了起来。"
        yield return _gameMethods.PlaySound("sounda1", 0.0f, 0.6f, "<from 0 to 2>audio/sound/emeng_dajie/walking_on_the_earth_01.mp3");
        yield return _gameMethods.Scene("tiankong_baitian1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"xpos", 0.5f}, {"zoom", 0.69f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 1.03f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.7f}, {"ypos", 1.2f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Transition(time:0.5f);
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 2;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.OpenDialog(7916); // "兴奋地原地蹦了两下，还嫌不够，又转了几圈，停下脚..."
        yield return _gameMethods.OpenDialog(7917); // "眼前的一切景色都如此美丽，熠熠生辉。"
        yield return _gameMethods.OpenDialog(7918); // "青空白云下，露珠亮晶晶地闪着光，花蕾鲜艳地怒放，..."
        yield return _gameMethods.OpenDialog(7919); // "如梦似幻。"
        yield return _gameMethods.Show("tiankong_baitian1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 1.2f}})});
        if (Defaults.Bai_xue ==1)
        {
            yield return _gameMethods.ChangeLabelTo("label_bai_mosuomofa");
        }
        else
        {
            yield return _gameMethods.OpenDialog(7920); // "我颇感新奇地玩了一会儿，没多久就魔力耗竭了。"
            yield return _gameMethods.OpenDialog(7921); // "这时。"
            yield return _gameMethods.ChangeLabelTo("label_zhuxian6_1");
        }
        yield break;
    }

    public IEnumerator label_zhuxian6_1()
    {
        yield return _gameMethods.StopSound(channelName:"music1", fadeOut:5.0f);
        Defaults.Persistent.Jq_8_7 = 1;
        yield return _gameMethods.PlaySound("soundb", 1.0f, 1.0f, "audio/demo_audio/sound/longpaidachibang.mp3");
        yield return _gameMethods.OpenDialog(7922); // "我的身后传来巨大的拍打的翅膀的声音。"
        yield return _gameMethods.Scene("xiaolu3", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 0.5f)}, {"zoom", 1.1f}, {"pos", new Vector2(0.5f, 0.5f)}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.TransitionBy("blink2");
        yield return _gameMethods.OpenDialog(7923); // "下意识转身，看向后方。"
        yield return _gameMethods.OpenDialog(7924); // "翅膀扇动的气流使我睁不开眼。"
        yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:2.0f);
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/demo_audio/sound/feng2.mp3");
        yield return _gameMethods.OpenDialog(7925); // "一道巨大的龙形阴影，遮天蔽日一般，将我所处的这一..."
        yield return _gameMethods.OpenDialog(7926); // "几乎是下一刻。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.2f, "<silence 1>audio/sound/houhui/Tight Face_02_duan.mp3");
        yield return _gameMethods.PlaySound("sounda1", 0.0f, 2.0f, "audio/sound/manbu/Body1_02_duan.mp3");
        yield return _gameMethods.Show("he", parts: new List<string>{"mei20", "yan27", "zui21", "emoji2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 3.0f)}, {"zoom", 0.62f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(7927); // "龙影落地，气流平息，我的肩膀被一双手紧紧握住，力..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei20", "yan25", "zui2", "emoji2"});
        yield return _gameMethods.OpenDialog(7928); // "还带着气喘的急促嗓音同时响起。"
        yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/music/the waltz of the bubble.mp3");
        yield return _gameMethods.Show("he", parts: new List<string>{"mei20", "yan3", "zui9", "emoji2"});
        yield return _gameMethods.OpenDialog(7929); // "你怎么了？"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei20", "yan3", "zui2", "emoji2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(7930); // "赫泽尔来了。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(7931); // "尽管我始终保持冷静和拼搏的意志，但想要不产生一丝..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei20", "yan7", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan20", "zui15"});
        yield return _gameMethods.OpenDialog(7932); // "此刻，距离我浮上水面，爬到岸边，大概只过了没几分..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(7933); // "在这个没有空间传送魔法的世界（至少我从未见到与听..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei20", "yan25", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei20", "yan2", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan11", "zui19", "emoji2"});
        yield return _gameMethods.OpenDialog(7934); // "我不小心掉到水里啦~哈哈……"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei19", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan8", "zui8"});
        yield return _gameMethods.OpenDialog(7935); // "我揪了揪自己水淋淋的头发。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan12", "zui11"});
        yield return _gameMethods.OpenDialog(7936); // "好险啊，差点以为要出意外了。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan2", "zui10", "-emoji2"});
        yield return _gameMethods.OpenDialog(7937); // "「不过站起来后，才发现水还没有我个头高，{nw}..."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei1", "yan24", "zui19", "emoji2"});
        yield return _gameMethods.OpenDialog(7938); // "虚惊一场，太丢人了。」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei19", "yan25", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei19", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei1", "yan24", "zui8", "emoji2"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0.5 to 1.5>audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.79f}, {"zpos", -20.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei1", "yan2", "zui19", "-emoji2"});
        yield return _gameMethods.OpenDialog(7939); // "「赫泽尔是来救我的么？"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei8", "yan11", "zui19", "emoji9", "emoji10", "emoji15"});
        yield return _gameMethods.OpenDialog(7940); // "好感动，谢谢你。」"
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:4.0f);
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -20.0f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei18", "yan27", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei8", "yan11", "zui7", "-emoji8", "emoji9", "emoji10", "emoji15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan24", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(7941); // "你在骗我？"
        yield return _gameMethods.PlaySound("music1", 0.0f, 0.7f, "audio/music/kepa/Ritual of snowfall.mp3");
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan24", "zui2"});
        yield return _gameMethods.PlaySound("sound", 0.0f, 2.0f, "<from 0 to 0.4>audio/demo_audio/sound/xintiao.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan1", "zui15", "emoji2", "-emoji9", "-emoji10", "-emoji15"});
        yield return _gameMethods.OpenDialog(7942); // "噗通。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7943); // "心脏骤然收缩。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan5", "zui7", "-emoji2"});
        yield return _gameMethods.OpenDialog(7944); // "我保持笑脸，{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei1", "yan11", "zui8"});
        yield return _gameMethods.OpenDialog(7945); // "假装迷惑。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei1", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(3151); // "什么？"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0.5 to 1.5>audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan25", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 3.0f}, {"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 1.0f}, {"ypos", 3.01f}, {"zpos", 24.0f}})});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan24", "zui2"});
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7946); // "赫泽尔向我走近两步。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/manbu/Body1_02_duan.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -20.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 1.0f}, {"zpos", 16.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan17", "zui15", "emoij2"});
        yield return _gameMethods.OpenDialog(7947); // "我不觉后退。"
        yield return _gameMethods.Show("black", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 24.0f}})});
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<from 0.5 to 4>audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(7948); // "随着越发靠近身后的水潭，碎石在我脚下发出咯嚓的声..."
        yield return _gameMethods.Scene("senlin4", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 0.5f)}, {"pos", new Vector2(0.17f, 0.46f)}, {"zoom", 1.25f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.0f, 0.0f)}, {"pos", new Vector2(0.0f, 0.0f)}, {"zpos", 16.0f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan24", "zui9"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 3.01f)}, {"zpos", 24.0f}, {"zoom", 0.62f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.StopSound(channelName:"sounda", fadeOut:1.0f);
        yield return _gameMethods.OpenDialog(7949); // "差点要出事了。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan24", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan22", "zui21"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 3.01f}, {"zpos", 24.0f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 16.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
        yield return _gameMethods.OpenDialog(7950); // "「这个水潭距离边缘逐步加深，不可能让人突然跌进一..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan9", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei8", "yan20", "zui15"});
        yield return _gameMethods.OpenDialog(7951); // "无风无浪，也不存在被卷入的可能。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan25", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(7952); // "其他岸边，根本没有适合人类的落脚点，正常情况下你..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan24", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(7953); // "——你是从这个浅滩，自己一步步走进深水的。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan24", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan24", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(7954); // "给我一个理由。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan24", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan2", "zui10"});
        yield return _gameMethods.OpenDialog(1495); // "「呃……"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei1", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(7955); // "对不起？」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan25", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan24", "zui2"});
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei1", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(7956); // "刚刚隐瞒只是不想让你担心。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan5", "zui8", "emoji2"});
        yield return _gameMethods.OpenDialog(7957); // "我沉默片刻，露出了“果然瞒不过你”的懊恼，以及心..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan6", "zui8", "emoji2"});
        yield return _gameMethods.OpenDialog(7958); // "挠着脸颊傻笑。"
        yield return _gameMethods.PlaySound("sound", 0.2f, 0.4f, "audio/demo_audio/sound/moca2.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 16.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.3f}, {"zpos", 0.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei1", "yan12", "zui19"});
        yield return _gameMethods.OpenDialog(7959); // "其实……我是看到一只水鸭子，感觉它叽叽喳喳和我挺..."
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei1", "yan5", "zui2", "-emoji2"});
        yield return _gameMethods.OpenDialog(7960); // "想抓住送给你，当作今天的礼物。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan3", "zui2"});
        yield return _gameMethods.StopSound(channelName:"music1", fadeOut:5.0f);
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei5", "yan12", "zui19", "emoji2"});
        yield return _gameMethods.OpenDialog(7961); // "结果跟着它走得太专注，不知不觉就一脚踏进深水区了..."
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan24", "zui10", "emoji2"});
        yield return _gameMethods.OpenDialog(7962); // "唉，很丢人吧……所以我才不想说的。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan9", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei8", "yan24", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7963); // "他定定注视了我片刻。"
        yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/music/Alphard.mp3");
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(7964); // "你不该做出这么冒失的行为。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui12"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei8", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(7965); // "以此为代价的礼物，我不需要。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei8", "yan20", "zui7"});
        yield return _gameMethods.OpenDialog(7966); // "那种聒噪的生物……不可能和你等同。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.3f}, {"zpos", -10.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(7967); // "对不起，我已经深刻意识到自己的错误了。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -10.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(7968); // "我积极认错，主动忏悔。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7969); // "根据经验，只要你积极反省，对方就找不到批评的台词..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei8", "yan8", "zui7"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(7970); // "……为什么想送给我那个。"
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei8", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(7971); // "那只，和你相似的鸭子。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan2", "zui10"});
        yield return _gameMethods.OpenDialog(7972); // "因为……以后我会不在。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan2", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan17", "zui19"});
        yield return _gameMethods.OpenDialog(7973); // "「我怕到那时候，"
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei8", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(7974); // "就没有人陪你了啊。」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei18", "yan1", "zui2", "emoji2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan17", "zui7"});
        yield return _gameMethods.OpenDialog(7975); // "我真诚地看着他，展露着发自内心的关怀。"
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
        yield return _gameMethods.OpenDialog(3063); // "「……{nw}{w=0.5}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei20", "yan15", "zui2", "emoji2"});
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian6_1_985b3ff9.ogg");
        yield return _gameMethods.OpenDialog(1998); // "…………」"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7976); // "不出所料，他僵硬且沉默了。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan15", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan12", "zui7"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan17", "zui7"});
        yield return _gameMethods.OpenDialog(7977); // "现在，即便我的说法存在漏洞，他也不太可能再继续追..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan8", "zui7"});
        yield return _gameMethods.OpenDialog(7978); // "我顺势转移话题。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan8", "zui19"});
        yield return _gameMethods.OpenDialog(7979); // "谢谢你来找我，那我们回去吧。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan19", "zui2", "emoji1"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei8", "yan8", "zui7"});
        yield return _gameMethods.OpenDialog(1543); // "「……{nw}{w=0.4}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan15", "zui9", "-emoji1"});
        yield return _gameMethods.OpenDialog(1497); // "嗯。」"
        yield return _gameMethods.PlaySound("soundb", 0.0f, 1.0f, "audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
        yield return _gameMethods.Hide("he");
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(7980); // "走的时候，他不容置疑地牵住了我的手，攥得紧紧的。"
        yield return _gameMethods.OpenDialog(7981); // "仿佛只要撒手，我就会像鸭子般飞到水潭里一样。"
        yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:2.0f);
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:4.0f);
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.Scene("heilong_dating_baitian", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.0f)}, {"zoom", 0.69f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.PlaySound("music2", 0.0f, 1.0f, "audio/demo_audio/music/richang1.mp3");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui18", "emoji2", "emoji5", "emoji6"});
        yield return _gameMethods.OpenDialog(7982); // "我被禁足了。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan9", "zui15"});
        yield return _gameMethods.OpenDialog(7983); // "只有在赫泽尔的陪同下才能出门。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan8", "zui15", "emoji2", "-emoji5", "-emoji6"});
        yield return _gameMethods.OpenDialog(7984); // "这也是没办法。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan8", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(7985); // "赫泽尔很重视我的性命。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(7986); // "而且，现在我的人身自由并不属于自己，只要赫泽尔想..."
        yield return _gameMethods.Show("black");
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7987); // "我心里很急。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan20", "zui15"});
        yield return _gameMethods.OpenDialog(7988); // "但我不能急。"
        yield return _gameMethods.Hide("black");
        yield return _gameMethods.Transition(time:0.5f);
        Defaults.Haogandu_an = Defaults.Haogandu_an + 1;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan6", "zui15"});
        yield return _gameMethods.OpenDialog(7989); // "我花了大概两个月，耐心等待“潜水意外事件”的后续..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan9", "zui15"});
        yield return _gameMethods.OpenDialog(7990); // "又对着赫泽尔说了很多好话，{nw}{w=0.01..."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei4", "yan12", "zui8", "emoji2"});
        yield return _gameMethods.OpenDialog(7991); // "指天发誓，只要有危险一定能立刻让他感应到。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan8", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(7992); // "最后他勉强同意，允许我半个月出门一次。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan24", "zui16", "emoji2"});
        yield return _gameMethods.OpenDialog(7993); // "每次半天。"
        yield return _gameMethods.StopSound(channelName:"music2", fadeOut:4.0f);
        if (Defaults.Bai_xue == 1)
        {
            yield return _gameMethods.Scene("caodi1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(-0.09f, 1.5f)}, {"zoom", 1.22f}})});
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.34f, 2.72f)}, {"zoom", 0.57f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/music/bing_richang1.mp3");
            Defaults.Persistent.Jq_8_8 = 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui7"});
            yield return _gameMethods.OpenDialog(7994); // "于是，我终于得以再次和诺伯拉面对面学习冰系魔法。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(7995); // "见到你真开心，诺伯拉先生。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan2", "zui8"});
            yield return _gameMethods.OpenDialog(7996); // "我也是，小公主。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui14"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(7997); // "「毕竟你已经很久没对我这么热情过了。{nw}{w..."
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei8", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(7998); // "只有尼德霍格才值得你如此花费心思去哄，不是吗？」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan11", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(7999); // "怎么可能呢。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei1", "yan5", "zui19", "-emoji2"});
            yield return _gameMethods.OpenDialog(8000); // "我们不是每天都在彼此陪伴，分享故事吗？"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(8001); // "现在，我已经听他讲到第五百八十二岁时的故事了。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan6", "zui15"});
            yield return _gameMethods.OpenDialog(8002); // "挺精彩的，我还蛮期待后续，不知道这辈子还有没有机..."
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.OpenDialog(8003); // "呵呵，有没有机会呢？"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0.5 to 1>audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.61f}, {"zpos", -30.0f}})});
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan2", "zui19"});
            yield return _gameMethods.OpenDialog(8004); // "那么，冰系魔法。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -30.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan5", "zui19"});
            yield return _gameMethods.OpenDialog(8005); // "我该怎么做呢，诺伯拉老师？"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui12"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan5", "zui8"});
            yield return _gameMethods.OpenDialog(8006); // "我礼貌地把对话拉回正题。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(8007); // "急切的就像正在进行按小时收费的培训班。{nw}{..."
            yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei8", "yan24", "zui8", "emoji2"});
            yield return _gameMethods.OpenDialog(8008); // "毕竟我真的赶时间。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui12"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan12", "zui8", "emoji2"});
            yield return _gameMethods.OpenDialog(8009); // "我敢肯定，但凡我晚于约定的时间三分钟还没踏进城堡..."
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui16"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei8", "yan12", "zui8", "-emoji2"});
            yield return _gameMethods.OpenDialog(8010); // "试着把我的名字加入你所编写的咒语吧。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(8011); // "毕竟我是掌握冰霜权柄的龙。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui15"});
            yield return _gameMethods.OpenDialog(1502); // "有道理。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(8012); // "在这个世界，语言即魔法，名字是符咒。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15"});
            yield return _gameMethods.OpenDialog(8013); // "虽然我在魔法上造诣不深，但我很听话，{nw}{w..."
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui8"});
            yield return _gameMethods.OpenDialog(8014); // "立刻把诺伯拉的名讳放进了关于冰的那条咒语的末尾。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.PlaySound("sounda1", 0.0f, 0.8f, "audio/sound/juezhan2/Magical Blast_01.ogg");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan21", "zui15"});
            yield return _gameMethods.OpenDialog(8015); // "……没有成功。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui9"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"ypos", -42.0f}, {"zpos", -168.0f}})});
            yield return _gameMethods.TransitionBy("blink2");
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/ga_wuyajiao.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan10", "zui15"});
            yield return _gameMethods.OpenDialog(8016); // "我幽幽地回望诺伯拉。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan9", "zui12"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(8017); // "他托腮思考。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui12"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(8018); // "「嗯——……{nw}{w=0.01}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei6", "yan1", "zui6"});
            yield return _gameMethods.OpenDialog(8019); // "你念我的名字时太冷漠了，{nw}{w=0.01}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei6", "yan11", "zui5"});
            yield return _gameMethods.OpenDialog(8020); // "没有感情。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei6", "yan11", "zui12"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei1", "yan2", "zui15", "emoji12"});
            yield return _gameMethods.OpenDialog(165); // "？"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan5", "zui10", "-emoji12"});
            yield return _gameMethods.OpenDialog(8021); // "我需要多有感情呢？"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(8022); // "我诚恳请教，求知若渴。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan14", "zui6"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(8023); // "「把我当作你的偶像、理想，{nw}{w=0.01..."
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui6"});
            yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei8", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(8024); // "甘愿奉献上全部努力的唯一至高的对象。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui18"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(8025); // "「祈祷我降临于此，给予回报，{nw}{w=0.0..."
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui4"});
            yield return _gameMethods.OpenDialog(8026); // "赐予力量与成果。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui16"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.OpenDialog(8027); // "就像人类王国里，大部分的神圣术那么做。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(4); // "……"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/ga_wuyajiao.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan24", "zui8", "emoji2"});
            yield return _gameMethods.OpenDialog(8028); // "我要是做得到，还能沦落到现在这个地步吗……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan12", "zui8", "emoji2"});
            yield return _gameMethods.OpenDialog(8029); // "我灰溜溜地摸了下鼻子。果然靠人不如靠自己。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei6", "yan1", "zui13"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 2.72f}, {"zoom", 0.57f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.46f}, {"ypos", 2.68f}, {"zoom", 0.56f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei8", "yan12", "zui8", "-emoji2"});
            yield return _gameMethods.OpenDialog(8030); // "「唉……我可是都已经免了你的仪式材料和精油，不收..."
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui17"});
            yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei8", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(8031); // "\n只要魔力连结上，就帮你打白工了。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui16"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 2.68f}, {"zoom", 0.56f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.OpenDialog(8032); // "考虑到你已和我结盟，以及这些日子里我们的羁绊。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(8033); // "「按理来说，但凡你的信赖程度能达到人际关系里普通..."
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui16"});
            yield return _gameMethods.OpenDialog(8034); // "就该已经与我建立上了连结才对。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(4); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan24", "zui16", "emoji2"});
            yield return _gameMethods.OpenDialog(8035); // "我心虚地想，谁让我从小听着“人要靠自己，才能过得..."
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan24", "zui16", "-emoji2"});
            yield return _gameMethods.OpenDialog(8036); // "童年对人的影响是终生的。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui6"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(8037); // "「没办法了。{nw}{w=0.01}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei6", "yan9", "zui5"});
            yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(8038); // "既然你一个人到达不了我这里，{nw}{w=0.0..."
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui13"});
            yield return _gameMethods.OpenDialog(8039); // "也就只能我这边努努力了。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui14"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.OpenDialog(8040); // "再试一次吧。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan9", "zui15"});
            yield return _gameMethods.OpenDialog(8041); // "我又念诵了一遍，{nw}{w=0.01}"
            yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan12", "zui18", "emoji2"});
            yield return _gameMethods.OpenDialog(8042); // "这次，努力地加上了感情。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan22", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(8043); // "就像小学语文课上朗诵课文那样，想象着我对他的热爱..."
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:4.0f);
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(8044); // "不知道这份饱满的感情有没有起到效果，总之，这次，..."
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/bai_yao/Bell Stop_01.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0.0f}, {"parallel_1", true}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(8045); // "宛如装上了一个特效信号加强器，视野感知陡然清晰，..."
            yield return _gameMethods.PlaySound("soundb", 0.0f, 1.0f, "audio/sound/bai_yao/SeaWaves_01.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"yoffset", 0.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(8046); // "接着，在某种无形的明悟与指引下，我无师自通地捕捉..."
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -42.0f}, {"zpos", -168.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.82f}, {"ypos", 48.0f}, {"zpos", -126.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15"});
            yield return _gameMethods.OpenDialog(8047); // "从我掌心处的空气开始，它们寸寸冻结。"
            yield return _gameMethods.OpenDialog(8048); // "我控制着冰晶的形状，塑造着它的弧度。 "
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 48.0f}, {"zpos", -126.0f}})});
            yield return _gameMethods.OpenDialog(8049); // "枝茎、叶子，向外翻卷的花瓣。"
            yield return _gameMethods.PlaySound("sounda1", 0.0f, 1.0f, "audio/sound/emeng_dajie/magic1.ogg");
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:2.0f);
            yield return _gameMethods.Show("daoju_bingmeigui", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}, {"anchor", new Vector2(0.5f, 0.5f)}, {"pos", new Vector2(666.0f, 588.0f)}, {"zoom", 0.34f}, {"zrotate", 6.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1.0f}})});
            yield return _gameMethods.OpenDialog(8050); // "一枝晶莹洁白的冰雪玫瑰出现在我的掌中。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/manbu/Body1_02_duan.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 48.0f}, {"zpos", -126.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"ypos", -36.0f}, {"zpos", -180.0f}})});
            yield return _gameMethods.Show("daoju_bingmeigui", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 588.0f}, {"zoom", 0.3400000000000001f}, {"alpha", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.67f}, {"ypos", 540.0f}, {"zoom", 0.33f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(8051); // "我捏住他，递给了诺伯拉。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan19", "zui8"});
            yield return _gameMethods.PlaySound("music1", 0.0f, 1.0f, "audio/demo_audio/music/richang2.mp3");
            Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
            if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
            {
                _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
                _gameMethods.SyncAchievement();
            }
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(8052); // "给你，我开出的第一朵玫瑰。"
            yield return _gameMethods.PlaySound("sound", 0.2f, 0.4f, "audio/demo_audio/sound/moca2.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -36.0f}, {"zpos", -180.0f}})});
            yield return _gameMethods.Show("daoju_bingmeigui", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 0.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui8"});
            yield return _gameMethods.OpenDialog(8053); // "他收下了。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan19", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.OpenDialog(8054); // "和我想的一样美。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(4); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(33); // "………………"
            yield return _gameMethods.Hide("daoju_bingmeigui");
            yield return _gameMethods.Hide("nuo1");
            yield return _gameMethods.Transition(time:0.5f);
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui7"});
            yield return _gameMethods.OpenDialog(8055); // "接下来的日子里，我有了一个新的目标，练习魔法。"
        }
        else
        {
            yield return _gameMethods.PlaySound("music1", 3.0f, 0.7f, "audio/music/chumen1.mp3");
            yield return _gameMethods.Scene("caodi1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(-0.09f, 1.5f)}, {"zoom", 1.22f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -36.0f}, {"zpos", -180.0f}})});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<silence 1>audio/sound/dashuizhang/Small Splash_01.mp3");
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(8056); // "于是，我终于得以再次练习刚刚领悟的水系魔法。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(21); // "…………"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui7"});
            yield return _gameMethods.OpenDialog(8057); // "接下来的日子里，我拥有了一个全新的追求目标。"
        }
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui8"});
        yield return _gameMethods.OpenDialog(8058); // "经过一次次的重复、训练，不断总结方法，将这份新的..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8059); // "万事开头难。一旦入了门，后面的路便走得越来越顺畅..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan9", "zui8"});
        yield return _gameMethods.OpenDialog(8060); // "我不清楚这个世界里魔法师的普遍成长速度如何，但自..."
        yield return _gameMethods.PlaySound("soundb", 0.0f, 1.5f, "audio/sound/dashuizhang/Bird Amb_01.ogg");
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0.5 to 2.5>audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
        yield return _gameMethods.Scene("senlin3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Transition(time:0.7f);
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan6", "zui7"});
        yield return _gameMethods.OpenDialog(8061); // "经过实践，我确信自己已经掌握了与一些中等体型的魔..."
        if (Defaults.Bai_xue ==1)
        {
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(8062); // "其中，使用的最为炉火纯青的，当然就是水与冰系法术..."
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan8", "zui7"});
            yield return _gameMethods.OpenDialog(8063); // "据诺伯拉的说法，我已到了正式魔法师的水平，大概占..."
        }
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(8064); // "……虽然和龙族的实力比，仍是云泥之别，"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei8", "yan21", "zui15"});
        yield return _gameMethods.OpenDialog(8065); // "但至少，我已经做到了什么，超越了曾经的自己。"
        yield return _gameMethods.StopSound(channelName:"music1", fadeOut:4.0f);
        yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:3.0f);
        yield return _gameMethods.PlaySound("soundc", 3.0f, 1.0f, "audio/demo_audio/sound/chanming.ogg");
        yield return _gameMethods.Scene("tiankong_baitian", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.01f)}, {"zoom", 0.68f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Transition(time:0.6f);
        yield return _gameMethods.OpenDialog(4); // "……"
        Defaults.Haogandu_an = Defaults.Haogandu_an + 1;
        yield return _gameMethods.OpenDialog(8066); // "春天过去，初夏来临。"
        Defaults.Persistent.Jq_9_1 = 1;
        yield return _gameMethods.OpenDialog(8067); // "赫泽尔返回龙之谷的日期也到了。"
        yield return _gameMethods.StopSound(channelName:"soundc", fadeOut:2.0f);
        yield return _gameMethods.Scene("heilong_chufang_baitian_man", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.0f)}, {"zoom", 0.7f}})});
        yield return _gameMethods.Transition(time:0.6f);
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/canpanpengzhuang2_duan.mp3");
        yield return _gameMethods.PlaySound("music", 3.0f, 1.0f, "audio/demo_audio/music/richang1.mp3");
        yield return _gameMethods.OpenDialog(8068); // "这次，他是在我起床之后才出发的。"
        yield return _gameMethods.PlaySound("soundb", 0.0f, 1.0f, "audio/demo_audio/sound/zu3_nv_zou.ogg");
        yield return _gameMethods.Scene("heilong_dating_men_baitian", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.46f)}, {"zoom", 1.29f}})});
        yield return _gameMethods.TransitionBy("trans_rip_fast");
        yield return _gameMethods.OpenDialog(8069); // "我们一起吃了早饭，来到大厅为他送行。"
        yield return _gameMethods.OpenDialog(8070); // "赫泽尔即将走出门外，却顿了一下脚步。"
        yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:1.0f);
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/manbu/Body1_02_duan.mp3");
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 2.65f)}, {"zoom", 0.54f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(8071); // "他转身看我，{nw}{w=0.01}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.OpenDialog(8072); // "貌似有些迟疑。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
        yield return _gameMethods.OpenDialog(8073); // "……你——……"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei9", "yan13", "zui2"});
        yield return _gameMethods.OpenDialog(8074); // "话说到一半，他突兀地住了口。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui14", "emoji12"});
        yield return _gameMethods.OpenDialog(165); // "？"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan15", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui14", "-emoji12"});
        yield return _gameMethods.OpenDialog(8075); // "……没什么，你就呆在这里。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan15", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui2"});
        yield return _gameMethods.OpenDialog(4368); // "好。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 2>audio/demo_audio/sound/zu3_nv_zou.ogg");
        yield return _gameMethods.Show("he", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 0.0f}, {"blur", 0.01f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.Hide("he");
        yield return _gameMethods.PlaySound("sounda1", 0.0f, 0.8f, "audio/sound/houhui/Bones Break Cracking_01.ogg");
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.5f, "audio/demo_audio/sound/feng2.mp3");
        yield return _gameMethods.OpenDialog(8076); // "我望着他从背部裂出一对漆黑的肉翼，浑身遍布鳞片，..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(8077); // "直到确定他的身影在天空中变成一个微点，又消失不见..."
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:3.0f);
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan12", "zui8"});
        yield return _gameMethods.OpenDialog(8078); // "我如释重负，"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/ding1.mp3");
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei8", "yan6", "zui8", "emoji7"});
        yield return _gameMethods.OpenDialog(8079); // "出门透风。"
        yield return _gameMethods.PlaySound("soundb", 0.0f, 1.5f, "audio/sound/dashuizhang/Bird Amb_01.ogg");
        yield return _gameMethods.Scene("senlin3");
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.PlaySound("soundc", 0.0f, 0.6f, "audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Scene("senlin5");
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.Scene("senlin2");
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.OpenDialog(33); // "………………"
        yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:8.0f);
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui7"});
        yield return _gameMethods.OpenDialog(8080); // "走在树荫小道上。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui7"});
        yield return _gameMethods.OpenDialog(8081); // "我听着被踩踏的树叶发出清脆的声音，原本还高昂了些..."
        yield return _gameMethods.PlaySound("music2", 4.0f, 1.0f, "audio/music/Fall.mp3");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(8082); // "这会是决战前，赫泽尔最后一次离开城堡。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(8083); // "大概还有不到半年，就是决战之日了。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(8084); // "可是直到现在，我都没能摸索出一条能逃离黑龙的、具..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan20", "zui15"});
        yield return _gameMethods.OpenDialog(8085); // "……难道说，我只能什么都不做，等着勇者（真的是安..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8086); // "让我坐以待毙，实在煎熬。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(8087); // "我在心中再一次回忆起，这两年里我计划了无数遍的路..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8088); // "——从这里到达山脚的小镇，以我的脚程，大概需要一..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(8089); // "接着，用藏匿的钱财在那个小镇买一匹健马，乔装打扮..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan6", "zui15"});
        yield return _gameMethods.OpenDialog(8090); // "之后，顺利混入人流量更庞大的城市中。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan21", "zui15"});
        yield return _gameMethods.OpenDialog(8091); // "……虽然，以我的预测，大概我在骑马赶往城市的半途..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan4", "zui15"});
        yield return _gameMethods.OpenDialog(8092); // "…………还是说，秉持着“最危险就是最安全的地方”..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8093); // "等赫泽尔回来发现我失踪、去远方找人后，我再往相反..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan9", "zui15"});
        yield return _gameMethods.OpenDialog(8094); // "不管哪种方案，在他作弊一般的移动速度，和过于强大..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(8095); // "百分百会被抓回来的。"
        yield return _gameMethods.Scene("xiaolu3");
        yield return _gameMethods.TransitionBy("trans_rip_fast");
        yield return _gameMethods.StopSound(channelName:"music2", fadeOut:4.0f);
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(8096); // "边思考边走着，不知不觉间，我发现自己已走在了前往..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/houhui/Hint_01.mp3");
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan2", "zui10", "emoji2"});
        yield return _gameMethods.OpenDialog(8097); // "……咦？"
        yield return _gameMethods.StopSound(channelName:"soundc", fadeOut:1.0f);
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan2", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(8098); // "不远处，仿佛看到了什么奇怪的东西。"
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<from 0.5 to 1>audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
        yield return _gameMethods.PlaySound("sounda2", 0.0f, 1.0f, "<silence 0.6><from 0.5 to 1>audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
        yield return _gameMethods.PlaySound("sounda1", 0.0f, 1.0f, "<silence 1.0><from 0 to 0.3>audio/sound/juezhan_dao/Running Footsteps Mud and Grass Surface (1)_01.ogg");
        yield return _gameMethods.OpenDialog(8099); // "我快步走近。"
        yield return _gameMethods.Show("mayi", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 0.77f)}, {"zoom", 0.67f}})});
        yield return _gameMethods.Show("4-8_zoom");
        yield return _gameMethods.Hide("4-8_zoom");
        yield return _gameMethods.TransitionBy("trans_rip_fast");
        yield return _gameMethods.OpenDialog(8100); // "在一块巨大的岩石上，蚂蚁汇聚。"
        yield return _gameMethods.OpenDialog(8101); // "黑蚁们沿着某种特定的路线爬行着，形成了一行字。"
        yield return _gameMethods.OpenDialog(8102); // "——“正午，草地会面。”"
        yield return _gameMethods.PlaySound("sound", 0.0f, 3.0f, "<from 0 to 0.5>audio/demo_audio/sound/xintiao.ogg");
        yield return _gameMethods.PlaySound("music1", 2.0f, 1.0f, "audio/music/yongzhe_wenxin1.mp3");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan1", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(8103); // "心脏猛然跳动了一下。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(8104); // "熟悉的笔迹。我立刻认出了写字者的身份。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(8105); // "他在写到某个字母时，总会翘起一个小尾巴。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan12", "zui8"});
        yield return _gameMethods.OpenDialog(8106); // "是勇者……安德鲁的字。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan9", "zui7"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8107); // "蜜糖的痕迹还很新鲜，像是刚写下来不超过一个小时。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan6", "zui15"});
        yield return _gameMethods.OpenDialog(8108); // "……我和安德鲁说过，赫泽尔每年前往龙之谷的日期。..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8109); // "所以，才在前往小镇最近的一条路上留下了讯息。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15"});
        yield return _gameMethods.OpenDialog(8110); // "定定地注视了一会儿那行蠕动的字，我把石面上涂抹的..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8111); // "蚁群恋恋不舍地散开。"
        yield return _gameMethods.PlaySound("soundb", 0.0f, 1.0f, "audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
        yield return _gameMethods.Hide("mayi");
        yield return _gameMethods.TransitionBy("trans_rip_fast");
        yield return _gameMethods.OpenDialog(8112); // "我向着草地的方向走去。"
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:1.0f);
        yield return _gameMethods.Scene("senlin7");
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan21", "zui15"});
        yield return _gameMethods.OpenDialog(8113); // "该怎么说呢。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(8114); // "这就是近乡情怯的感觉吗。"
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0.5 to 2.5>audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
        yield return _gameMethods.OpenDialog(8115); // "我深吸一口气，走出树林。"
        yield return _gameMethods.PlaySound("soundb", 2.0f, 1.0f, "audio/sound/manbu/Gentle Breeze Blowing Foliage Rustling_01.ogg");
        yield return _gameMethods.Scene("caodi1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.0f)}, {"zoom", 0.49f}})});
        yield return _gameMethods.Transition(time:0.6f);
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(8116); // "视野变得平坦开阔。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(8117); // "隔着一段距离，我远远地看到了两道身影。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei6", "yan17", "zui7"});
        yield return _gameMethods.OpenDialog(8118); // "虽然已经许久没见，但我立刻认出了他们的身份。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei6", "yan12", "zui7"});
        yield return _gameMethods.OpenDialog(8119); // "是他们。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei9", "yan17", "zui7"});
        yield return _gameMethods.OpenDialog(8120); // "许久未见的故人。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0.5 to 2>audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<silence 1>audio/sound/juezhan_dao/Running Footsteps Mud and Grass Surface (1)_01.ogg");
        yield return _gameMethods.OpenDialog(8121); // "我走向那两人，脚步逐渐加快，继而放开步伐，大步奔..."
        yield return _gameMethods.StopSound(channelName:"music1", fadeOut:3.0f);
        yield return _gameMethods.OpenSelectMenu(
            talk: new List<string>{"-冲向他们", "-抱向他们"},
            jump: new List<string>{"label_zhuxian6_menu_0_gMz2hZ5b", "label_zhuxian6_menu_0_Lmpai0DK"},
            condition: new List<string>{"NONE", "NONE"}
        );
    }

    public IEnumerator label_zhuxian6_7()
    {
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan12", "zui1", "emoji12"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan10", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei5", "yan5", "zui8", "emoji2"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.PlaySound("music1", 0.0f, 0.7f, "audio/music/yongzhe_kaixin.mp3");
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan2", "zui8", "-emoji12"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
        yield return _gameMethods.OpenDialog(8141); // "「你这种村姑都能成为公主，{nw}{w=0.01..."
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan16", "zui15", "emoji6"});
        yield return _gameMethods.OpenDialog(8142); // "凭什么我不可能是勇者啊！」"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan16", "zui12", "-emoji6"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei3", "yan2", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(8143); // "话说你这是对待救命恩人的态度吗！"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0.5 to 1>audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan2", "zui12"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"easein", 0.6f}, {"zpos", 10.0f}})});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan16", "zui10"});
        if (Defaults.Persistent.Povname == "辛西娅")
        {
            yield return _gameMethods.ExecuteCharacterImageData("luo_nv");
            yield return _gameMethods.OpenDialog(8144); // "好久不见，你看起来很精神，辛西娅。"
        }
        else
        {
            yield return _gameMethods.ExecuteCharacterImageData("luo_nv");
            yield return _gameMethods.OpenDialog(8145); // "好久不见，你看起来很精神，[persistent..."
        }
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan2", "zui9"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 10.0f}})});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei1", "yan5", "zui10", "emoji2"});
        yield return _gameMethods.OpenDialog(8146); // "「洛恩居然也真的……"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}, {"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.80f}, {"xpos", 180.0f}, {"zpos", -162.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei1", "yan10", "zui19", "emoji2"});
        yield return _gameMethods.OpenDialog(8147); // "你不是有洁癖最顽固了吗？ 」"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei5", "yan23", "zui10"});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 180.0f}, {"zpos", -162.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan24", "zui8", "-emoji2"});
        yield return _gameMethods.OpenDialog(8148); // "不干净的桌椅，他向来连沾都不愿意沾一下。"
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan10", "zui15"});
        yield return _gameMethods.ExecuteCharacterImageData("luo_nv");
        yield return _gameMethods.OpenDialog(8149); // "…是啊，我有精神洁癖。"
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan12", "zui15"});
        yield return _gameMethods.ExecuteCharacterImageData("luo_nv_qian");
        yield return _gameMethods.OpenDialog(8150); // "「所以无法容忍出卖朋友，{nw}{w=0.01}"
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan5", "zui14"});
        yield return _gameMethods.OpenDialog(8151); // "苟且偷生的行为。」 "
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan11", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("luo_nv", parts: new List<string>{"mei8", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(8152); // "还有自己的员工被别人霸占。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0.5 to 1>audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan8", "zui9"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"easein", 0.8f}, {"zpos", 10.0f}, {"xpos", 0.35f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 180.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.80f}, {"xpos", 18.0f}})});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan5", "zui10"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv");
        yield return _gameMethods.OpenDialog(8153); // "等下，怎么说话呢你。"
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan2", "zui1"});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 18.0f}})});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan2", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.35f}, {"zpos", 10.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv");
        yield return _gameMethods.OpenDialog(8154); // "应该尊称人家为帝国未来的奥术之星洛恩阁下。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan2", "zui1"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan3", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei3", "yan10", "zui19"});
        yield return _gameMethods.OpenDialog(8155); // "「几年没见，你讲话怎么还是这么惹人厌烦，{nw}..."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei4", "yan12", "zui19"});
        yield return _gameMethods.OpenDialog(8156); // "晚上睡觉记得锁好门窗。」"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0.5 to 1>audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan16", "zui13"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.35f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.8f}, {"xpos", 0.36f}})});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan10", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian", parts: new List<string>{"mei4", "yan12", "zui8"});
        yield return _gameMethods.OpenDialog(8157); // "「怎么，要来偷袭我啊？{nw}{w=0.01}"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei6", "yan17", "zui13"});
        yield return _gameMethods.OpenDialog(8158); // "可怕，我可是无辜居民。」"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei6", "yan17", "zui10"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.36f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei4", "yan21", "zui19", "emoji6"});
        yield return _gameMethods.OpenDialog(6522); // "呵呵。"
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei8", "yan12", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan5", "zui10", "-emoji6"});
        yield return _gameMethods.OpenDialog(8159); // "你打得过巨龙？"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui4"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan5", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei8", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(8160); // "那当然打不过。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan10", "zui8", "emoji12"});
        yield return _gameMethods.OpenDialog(165); // "？"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan12", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian", parts: new List<string>{"mei3", "yan10", "zui8", "-emoji12"});
        yield return _gameMethods.OpenDialog(8161); // "「想什么呢，{nw}{w=0.01}"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan2", "zui8"});
        yield return _gameMethods.OpenDialog(8162); // "我才练了三年，就算成为了人类王国的第一骑士，也打..."
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei3", "yan2", "zui10"});
        yield return _gameMethods.OpenDialog(8163); // "「说的好对，"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(8164); // "但我想不通你在骄傲什么。」"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan3", "zui15"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan10", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei3", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(8165); // "就算打不过，至少我可以帮你拦一会儿，让你赶紧跑嘛..."
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan3", "zui10"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan25", "zui15"});
        yield return _gameMethods.OpenDialog(3063); // "「……{nw}{w=0.5}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan20", "zui15"});
        yield return _gameMethods.OpenDialog(1265); // "……」"
        yield return _gameMethods.OpenSelectMenu(
            talk: new List<string>{"-但我不会跑的"},
            jump: new List<string>{"label_zhuxian6_menu_1_c782TjsQ"},
            condition: new List<string>{"NONE"}
        );
    }

    public IEnumerator label_zhuxian6_4()
    {
        Defaults.Haogandu_an = Defaults.Haogandu_an + 1;
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan12", "zui10"});
        yield return _gameMethods.OpenDialog(8167); // "谢谢你，但我不会跑的。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(8168); // "我不能跑。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15"});
        yield return _gameMethods.OpenDialog(8169); // "如果他有战胜的能力，我会毫不犹豫转头就跑，给他减..."
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan23", "zui10"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(8170); // "但我了解安德鲁，假若在我逃跑后他能脱身，他就会坦..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan20", "zui15"});
        yield return _gameMethods.OpenDialog(8171); // "可他没说。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan2", "zui13"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan12", "zui8"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan10", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv");
        yield return _gameMethods.OpenDialog(8172); // "果然，就知道你会说这种话。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei8", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(8173); // "所以我……"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/ding1.mp3");
        yield return _gameMethods.Hide("an2");
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan12", "zui4"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 10.0f}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.36f, 2.22f)}, {"zoom", 0.36f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.7f}, {"zpos", 52.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv");
        yield return _gameMethods.OpenDialog(8174); // "我打算使点计谋。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan12", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 52.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan2", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei1", "yan5", "zui19", "-emoji2"});
        yield return _gameMethods.OpenDialog(8175); // "发挥传统特长是吧。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan13", "zui10"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan12", "zui8"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan10", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei1", "yan11", "zui2"});
        yield return _gameMethods.OpenDialog(8176); // "我们怎么小时候要靠小机灵，长大了还要挖空心思？"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan2", "zui12"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei1", "yan5", "zui8"});
        yield return _gameMethods.OpenDialog(8177); // "你懂什么，这叫战略。"
        yield return _gameMethods.ExecuteCharacterImageData("an_nv");
        yield return _gameMethods.OpenDialog(8178); // "懂不懂什么叫智力型战斗啊。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan12", "zui10"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(8179); // "懂了。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan12", "zui20"});
        yield return _gameMethods.OpenDialog(8180); // "这就让龙族见识一下，我们人类的机智之道。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei5", "yan17", "zui6"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan12", "zui8"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan10", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei3", "yan12", "zui7"});
        yield return _gameMethods.OpenDialog(8181); // "哼，也不想想这都是为了谁啊？"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei5", "yan17", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui7"});
        yield return _gameMethods.OpenDialog(8182); // "他没好气地说。"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan8", "zui7"});
        yield return _gameMethods.OpenDialog(8183); // "我沉默了。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan8", "zui3"});
        yield return _gameMethods.OpenDialog(8184); // "「…………。谢谢。"
        Defaults.Haogandu_an = Defaults.Haogandu_an + 1;
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei1", "yan5", "zui4"});
        yield return _gameMethods.OpenDialog(8185); // "我很想你。」"
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/moca1.ogg");
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan4", "zui1", "emoji2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"xoffset", -3.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 3.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0.0f}, {"parallel_1", true}})});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian", parts: new List<string>{"mei1", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(1543); // "「……{nw}{w=0.4}"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan2", "zui12", "emoji2", "emoji8"});
        yield return _gameMethods.OpenDialog(8186); // "哈哈！{nw}{w=0.01}"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan9", "zui12", "emoji2", "emoji8"});
        yield return _gameMethods.OpenDialog(8187); // "我可一点都不想你。」"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan9", "zui10", "emoji2", "emoji8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"yoffset", 0.0f}})});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan5", "zui4"});
        yield return _gameMethods.ExecuteCharacterImageData("luo_nv", parts: new List<string>{"mei8", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(8188); // "他说谎的。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan8", "zui3", "emoji2", "emoji8"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan5", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8189); // "洛恩无情地说。"
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan12", "zui16"});
        yield return _gameMethods.ExecuteCharacterImageData("luo_nv");
        yield return _gameMethods.OpenDialog(8190); // "我经常听见他夜里躺在床上辗转反侧。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan8", "zui8", "emoji2", "emoji3", "emoji4", "emoji8"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan2", "zui6"});
        if (Defaults.Persistent.Povname == "辛西娅")
        {
            yield return _gameMethods.ExecuteCharacterImageData("luo_nv");
            yield return _gameMethods.OpenDialog(8191); // "这家伙每天睡前都要拿出你以前送的那个吊坠不停摩挲..."
        }
        else
        {
            yield return _gameMethods.ExecuteCharacterImageData("luo_nv");
            yield return _gameMethods.OpenDialog(8192); // "这家伙每天睡前都要拿出你以前送的那个吊坠不停摩挲..."
        }
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan2", "zui1"});
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/moca1.ogg");
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei10", "yan3", "zui12", "emoji3", "emoji4", "emoji5", "emoji8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"xoffset", -3.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 3.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0.0f}, {"parallel_1", true}})});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian", parts: new List<string>{"mei8", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei8", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(8193); // "你放屁！！！！"
        yield return _gameMethods.PlaySound("sounda", 0.0f, 2.5f, "audio/sound/houhui/Grab Hand_01.mp3");
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei10", "yan16", "zui12", "emoji3", "emoji4", "emoji5", "emoji6", "emoji8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"yoffset", 0.0f}})});
        yield return _gameMethods.Show("black", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 52.0f}})});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan9", "zui1"});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(8194); // "安德鲁骤然暴起，狼狈地伸手去捂住洛恩的嘴，后者不..."
        yield return _gameMethods.Hide("black");
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei4", "yan11", "zui10", "emoji5", "emoji3"});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8195); // "勉强制服好洛恩后，安德鲁瞄了我一眼，正好与我的目..."
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan8", "zui1", "emoji3", "emoji4", "-emoji6", "emoji8"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian", parts: new List<string>{"mei8", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei8", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("bishou1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 0.5f)}, {"zpos", 100.0f}, {"pos", new Vector2(654.0f, 486.0f)}, {"zoom", 0.25f}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.3f}, {"alpha", 1.0f}})});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan17", "zui6", "emoji3", "emoji4", "emoji5", "emoji6", "-emoji8"});
        yield return _gameMethods.OpenDialog(8196); // "总之，这个给你，拿好。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan17", "zui1", "emoji3", "emoji4", "emoji5", "emoji6"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan2", "zui1"});
        yield return _gameMethods.OpenDialog(8197); // "安德鲁从腰包里掏出一根树枝，将粗壮的一头递给我。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan17", "zui1", "emoji3", "emoji4", "emoji6"});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -30.0f}, {"zpos", -162.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"ypos", 6.0f}, {"zpos", -198.0f}})});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan9", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan9", "zui10"});
        yield return _gameMethods.OpenDialog(8198); // "这是……？"
        yield return _gameMethods.Show("bishou1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan12", "zui4", "emoji2", "emoji4", "-emoji6"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei7", "yan9", "zui10"});
        yield return _gameMethods.OpenDialog(8199); // "用世界树枝干做的道具，能让龙族暂时失去力气。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei5", "yan13", "zui5", "emoji2", "emoji4"});
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian6_4_4069da28.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(8200); // "但只能由和龙有一定关系的人使用，我在妖精乐园换来..."
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 6.0f}, {"zpos", -198.0f}})});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan2", "zui8", "emoji2", "emoji4"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv");
        yield return _gameMethods.OpenDialog(8201); // "收好啊，这可是我用身上最宝贵的东西换的！"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei5", "yan17", "zui2", "emoji2", "emoji4"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan12", "zui1"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan9", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8202); // "他重音强调。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"ypos", -30.0f}, {"zpos", -162.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan21", "zui15", "emoji3"});
        yield return _gameMethods.OpenDialog(8203); // "……最宝贵的东西？"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -30.0f}, {"zpos", -162.0f}})});
        yield return _gameMethods.ChangeLabelTo("label_multiple_choice3");
    }

    public IEnumerator label_multiple_choice3()
    {
        yield return _gameMethods.OpenSelectMenu(
            talk: new List<string>{"-钱吗？", "-肌肉？", "-不会是……"},
            jump: new List<string>{"label_zhuxian6_menu_2_PZLqtDo4", "label_zhuxian6_menu_2_sh5LcHcW", "label_zhuxian6_menu_2_Yg_OqHBF"},
            condition: new List<string>{"Defaults.Choice_1_newb", "NONE", "NONE"}
        );
    }

    public IEnumerator label_zhuxian6_2()
    {
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei8", "yan10", "zui1"});
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0.5 to 1>audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan1", "zui2", "emoji8", "-emoji19", "-emoji4"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 52.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.61f}, {"zpos", 28.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.Show("an2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 28.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8226); // "他戛然住嘴。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan17", "zui3", "emoji8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(8227); // "一副“不好，说错话了”的神情。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(18.0f, -30.0f)}, {"zpos", -162.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.77f}, {"pos", new Vector2(-84.0f, -30.0f)}, {"zpos", -186.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan22", "zui10"});
        yield return _gameMethods.OpenDialog(8228); // "那是什么意思？"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-84.0f, -30.0f)}, {"zpos", -186.0f}})});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan23", "zui3", "emoji8"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian", parts: new List<string>{"mei3", "yan22", "zui15"});
        yield return _gameMethods.OpenDialog(8229); // "「………{nw}{w=0.6}"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan12", "zui2", "emoji8"});
        yield return _gameMethods.OpenDialog(6144); // "………」"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan2", "zui8", "emoji8"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv");
        yield return _gameMethods.OpenDialog(8230); // "……就是你之前猜的那个东西。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan2", "zui2", "emoji8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(8231); // "安德鲁忍辱负重地说道。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan21", "zui8", "emoji8"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv");
        yield return _gameMethods.OpenDialog(8232); // "我只不过强调一下它对我比较重要，相当于一辈子的幸..."
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan21", "zui2", "emoji8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan12", "zui5", "emoji2"});
        yield return _gameMethods.OpenDialog(8233); // "我被这副嘴硬的样子气笑了。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", -84.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.80f}, {"xpos", 60.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan10", "zui10", "-emoji2"});
        yield return _gameMethods.OpenDialog(8234); // "洛恩？"
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan12", "zui5"});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 60.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("luo_nv", parts: new List<string>{"mei3", "yan10", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan10", "zui1"});
        yield return _gameMethods.StopSound(channelName:"music1", fadeOut:3.0f);
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8235); // "洛恩叹了口气。"
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan5", "zui5"});
        yield return _gameMethods.PlaySound("music", 2.0f, 1.0f, "audio/music/yongzhe_wenxin1.mp3");
        yield return _gameMethods.ExecuteCharacterImageData("luo_nv");
        yield return _gameMethods.OpenDialog(8236); // "妖精一族十分滑头，他们只会偶然出现在拥有足够强烈..."
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan9", "zui16"});
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(8237); // "用肉眼看不见的珍贵之物做交换，立下契约。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan16", "zui1", "emoji8"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan12", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(8238); // "执着的生灵。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(8239); // "所以，这种珍贵之物是什么呢？"
        yield return _gameMethods.PlaySound("sound", 0.0f, 2.5f, "audio/sound/manbu/Body1_02_duan.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 60.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.71f}, {"xpos", 18.0f}})});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan17", "zui7", "emoji8"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan2", "zui4"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian", parts: new List<string>{"mei7", "yan5", "zui18"});
        yield return _gameMethods.OpenDialog(8240); // "「……啊，真是的。{nw}{w=0.01}"
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan1", "zui1"});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan2", "zui8", "emoji8"});
        yield return _gameMethods.OpenDialog(8241); // "算了。」"
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan5", "zui1"});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 18.0f}})});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan2", "zui2", "emoji8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui18"});
        yield return _gameMethods.OpenDialog(8242); // "安德鲁抓了抓脑袋，将头发抓乱成一团糟。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan12", "zui6", "-emoji8"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan9", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
        yield return _gameMethods.OpenDialog(8243); // "「总之就是记忆，生命，情感，羁绊，未来的可能性什..."
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan2", "zui6"});
        yield return _gameMethods.OpenDialog(8244); // "反正莫名其妙的。」"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan15", "zui5"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(8245); // "那家伙说，人类除了情感丰富，先天所拥有的其它筹码..."
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan2", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
        yield return _gameMethods.OpenDialog(8246); // "「但我总不能拿记忆和情感来换吧，{nw}{w=0..."
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan12", "zui1"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan9", "zui1"});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan13", "zui4"});
        yield return _gameMethods.OpenDialog(8247); // "所以我是用此后能获得幸福的所有未来，用这份‘希望..."
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan13", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan20", "zui15"});
        yield return _gameMethods.OpenDialog(8248); // "无法获得、幸福吗？"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8249); // "我知道，安德鲁不是贪心之辈，他的幸福很简单。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8250); // "用炭笔画画很幸福；和家人团聚很幸福；碰到艳阳天，..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8251); // "对于他来说，照顾好家人、和朋友共处，遇到心宜的人..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui18"});
        yield return _gameMethods.OpenDialog(8252); // "但是，他已经再没有获得这种未来的可能了。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan12", "zui12", "emoji6"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan8", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei9", "yan5", "zui18"});
        yield return _gameMethods.OpenDialog(8253); // "……所以，我可是下了血本的。给我用好啊！！"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan2", "zui12", "-emoji6"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan5", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv");
        yield return _gameMethods.OpenDialog(8254); // "敢让你安德大人的苦心白费，就等着我变成恶灵每晚缠..."
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan2", "zui10"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei6", "yan20", "zui18"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan16", "zui13", "emoji6"});
        yield return _gameMethods.OpenDialog(8255); // "怎么了，是不是感动地说不出话了？"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan16", "zui10", "emoji6"});
        yield return _gameMethods.OpenDialog(8256); // "见我沉默，他翘鼻子了，一脸得瑟。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei6", "yan12", "zui18"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.50f}, {"blur", 3.02f}})});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan1", "zui1", "-emoji6"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan1", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei9", "yan5", "zui18", "emoji20"});
        yield return _gameMethods.OpenDialog(8257); // "我的眼泪掉下来了。"
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei4", "yan1", "zui1", "emoji2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei9", "yan17", "zui18", "emoji21", "emoji23", "-emoji20"});
        yield return _gameMethods.OpenDialog(8258); // "三年来，我第一次哭了。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "<silence 1>audio/sound/moca1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-102.0f, -90.0f)}, {"zpos", -282.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei10", "yan4", "zui8", "emoji8", "emoji9", "emoji10"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei4", "yan5", "zui2", "emoji2"});
        yield return _gameMethods.TransitionBy("blink2");
        Defaults.Haogandu_an = Defaults.Haogandu_an + 2;
        yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei9", "yan11", "zui18", "emoji19", "emoji22", "emoji23", "-emoji21"});
        yield return _gameMethods.OpenDialog(8259); // "……喂喂喂，别哭啊！！"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-102.0f, -90.0f)}, {"zpos", -282.0f}})});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei10", "yan4", "zui3", "emoji8", "emoji9", "emoji10"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei5", "yan12", "zui1"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei4", "yan9", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei6", "yan12", "zui18", "emoji18", "emoji22", "emoji23", "-emoji19"});
        yield return _gameMethods.OpenDialog(8260); // "见我落泪，安德鲁肉眼可见地慌了。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan23", "zui6", "emoji6", "emoji8", "emoji9", "emoji10"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv");
        yield return _gameMethods.OpenDialog(8261); // "丢……丢不丢人啊……"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan16", "zui12", "emoji6", "emoji8", "emoji9", "emoji10"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei4", "yan5", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv");
        yield return _gameMethods.OpenDialog(8262); // "我都还没哭呢。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan16", "zui10", "emoji6", "emoji8", "emoji9", "emoji10"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei2", "yan20", "zui15", "emoji18", "emoji21", "emoji23", "-emoji22"});
        yield return _gameMethods.OpenDialog(8263); // "一开始，他试图挤兑我，"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei7", "yan8", "zui3", "-emoji6", "emoji8", "emoji9", "emoji10"});
        yield return _gameMethods.OpenDialog(8264); // "发现毫无作用后，便手足无措了。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan15", "zui3", "emoji6", "emoji8", "emoji9", "emoji10"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei2", "yan12", "zui15", "emoji18", "emoji21", "emoji23"});
        yield return _gameMethods.OpenDialog(8265); // "只好搜肠刮肚地试图安慰、{nw}{w=0.01}"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei7", "yan16", "zui3", "-emoji6", "emoji8", "emoji9", "emoji10"});
        yield return _gameMethods.OpenDialog(8266); // "最后苦口婆心地劝道。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei7", "yan16", "zui7", "-emoji6", "emoji8", "emoji9", "emoji10"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
        yield return _gameMethods.OpenDialog(8267); // "「别哭了，{nw}{w=0.01}"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei7", "yan2", "zui12", "emoji8", "emoji9", "emoji10"});
        yield return _gameMethods.OpenDialog(8268); // "不就一个破希望嘛，{nw}{w=0.01}"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei7", "yan17", "zui12", "emoji8", "emoji9", "emoji10"});
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei9", "yan21", "zui15", "emoji18", "emoji21", "-emoji23"});
        yield return _gameMethods.OpenDialog(8269); // "人也不是非得有幸福才能活着啊。」"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei8", "yan2", "zui12", "emoji8", "emoji9", "emoji10"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei3", "yan9", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv");
        yield return _gameMethods.OpenDialog(8270); // "区区一份幸福，没了也能好好活着好吧。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei8", "yan2", "zui10", "emoji8", "emoji9", "emoji10"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei6", "yan12", "zui10", "emoji18", "emoji21", "emoji23"});
        yield return _gameMethods.OpenDialog(8271); // "「……可是，如果感受不到幸福，{nw}{w=0...."
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei3", "yan8", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei9", "yan5", "zui10", "emoji18", "emoji20", "-emoji23", "-emoji21"});
        yield return _gameMethods.OpenDialog(8272); // "你活着又是为了期待什么呢？」"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui4", "-emoji8", "-emoji9", "-emoji10"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei9", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(5491); // "我……"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8273); // "他放软了声音。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei4", "yan12", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
        yield return _gameMethods.OpenDialog(8274); // "「我还可以为你而活着啊。{nw}{w=0.01}"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan3", "zui15"});
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei1", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(8275); // "以后，我的使命就是保护你。」"
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan10", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan20", "zui15", "emoji21", "-emoji20"});
        yield return _gameMethods.OpenDialog(1048); // "那么。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8276); // "我就是你的苦难，"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei6", "yan12", "zui15", "emoji18", "emoji21", "-emoji23"});
        yield return _gameMethods.OpenDialog(8277); // "你的痛苦之源。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei4", "yan8", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv");
        yield return _gameMethods.OpenDialog(8278); // "别哭了。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei4", "yan23", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
        yield return _gameMethods.OpenDialog(8279); // "「你想想，你都给了我们家那么一大笔钱，{nw}{..."
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei4", "yan12", "zui12"});
        yield return _gameMethods.OpenDialog(8280); // "足够把我买下来了。」"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan3", "zui12"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan12", "zui1"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan10", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei8", "yan5", "zui15", "emoji18", "emoji20", "-emoji23", "-emoji21"});
        yield return _gameMethods.OpenDialog(8281); // "就当我被你买了当侍卫，行不行？"
        yield return _gameMethods.Show("black", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 400.0f}, {"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1.0f}})});
        yield return _gameMethods.Show("bishou1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 0.0f}})});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan3", "zui10"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei6", "yan20", "zui15", "emoji18", "emoji21", "emoji23"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(0.0f, -30.0f)}, {"zpos", -186.0f}})});
        yield return _gameMethods.Show("black", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 0.0f}})});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan4", "zui4", "emoji8"});
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian6_2_0d92d099_1.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
        yield return _gameMethods.OpenDialog(8282); // "「……不是，{nw}{w=0.01}"
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian6_2_51208b53.ogg");
        yield return _gameMethods.OpenDialog(8283); // "怎么还哭啊。」"
        yield return _gameMethods.PlaySound("sound", 0.0f, 2.0f, "audio/sound/manbu/Body1_02_duan.mp3");
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan18", "zui2", "emoji8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.36f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.4f}, {"xpos", 0.37f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8284); // "他用力捅了洛恩一胳膊肘。"
        yield return _gameMethods.Hide("bishou1");
        yield return _gameMethods.Hide("black");
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan18", "zui4", "emoji8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.37f}})});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv");
        yield return _gameMethods.OpenDialog(8285); // "赶紧想个办法，哄哄她。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan18", "zui4", "-emoji8"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan12", "zui4"});
        yield return _gameMethods.ExecuteCharacterImageData("luo_nv_qian", parts: new List<string>{"mei6", "yan20", "zui15", "emoji18", "emoji21", "emoji23"});
        yield return _gameMethods.OpenDialog(8286); // "「为什么要制止？{nw}{w=0.3}"
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan2", "zui4"});
        yield return _gameMethods.OpenDialog(8287); // "她哭起来挺可爱的。」"
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan2", "zui1"});
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/moca1.ogg");
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei10", "yan6", "zui12", "emoji8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"xoffset", -3.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 3.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0.0f}, {"parallel_1", true}})});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv");
        yield return _gameMethods.OpenDialog(8288); // "你正经点！"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei10", "yan6", "zui10", "emoji8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"yoffset", 0.0f}})});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan8", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("luo_nv");
        yield return _gameMethods.OpenDialog(8289); // "她能在我们面前落泪，表示她认为我们值得信任。"
        yield return _gameMethods.Show("black", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 28.0f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(8290); // "一根屈起的食指出现在我面前。"
        yield return _gameMethods.PlaySound("sounda1", 0.5f, 0.6f, "audio/sound/houhui/Grab Hand_01.mp3");
        yield return _gameMethods.OpenDialog(8291); // "温热的指节轻轻触及我的脸颊，接走了一滴眼泪。"
        yield return _gameMethods.Hide("black");
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui1", "-emoji8"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei3", "yan10", "zui1"});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15", "emoji18", "emoji21", "-emoji23"});
        yield return _gameMethods.OpenDialog(8292); // "洛恩垂眸看了一眼手指上的那滴泪珠，{nw}{w=..."
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei3", "yan5", "zui3"});
        yield return _gameMethods.OpenDialog(8293); // "抬起紫色的双瞳望着我，说。"
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei3", "yan8", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("luo_nv_qian");
        yield return _gameMethods.OpenDialog(8294); // "「你还不明白吗？{nw}{w=0.3}"
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei3", "yan12", "zui16"});
        yield return _gameMethods.OpenDialog(8295); // "她能放心哭泣的地方，{nw}{w=0.3}"
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei3", "yan5", "zui14"});
        yield return _gameMethods.OpenDialog(8296); // "只有在我们面前。」"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan2", "zui1"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei3", "yan4", "zui1"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei3", "yan5", "zui3"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan19", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8297); // "安德鲁沉默一下，"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0.5 to 1.5>audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan12", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 2.22f}, {"zpos", 28.0f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.2f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 1.3f}, {"ypos", 2.27f}, {"zpos", 112.0f}})});
        yield return _gameMethods.OpenDialog(8298); // "走到了我身前，{nw}{w=0.01}"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan8", "zui1", "emoji20"});
        yield return _gameMethods.OpenDialog(8299); // "站直，"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei10", "yan2", "zui2", "emoji2", "-emoji20"});
        yield return _gameMethods.OpenDialog(8300); // "一脸不自然地仰起了头。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei10", "yan2", "zui8", "emoji2"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv");
        yield return _gameMethods.OpenDialog(8301); // "好吧，你哭，我替你挡着行了吧。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei10", "yan2", "zui2", "emoji2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 2.27f}, {"zpos", 112.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei2", "yan5", "zui18"});
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 1.2f}, {"blur", 6.0f}})});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei10", "yan2", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei9", "yan11", "zui18", "emoji19", "emoji22", "emoji24", "-emoji18", "-emoji21", "-emoji23"});
        yield return _gameMethods.OpenDialog(8302); // "眼眶酸涩难忍。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei6", "yan12", "zui18", "emoji18", "emoji21", "emoji23", "-emoji19", "-emoji22", "-emoji24"});
        yield return _gameMethods.OpenDialog(8303); // "我吸着鼻子，{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei6", "yan11", "zui18", "emoji19", "emoji22", "emoji24", "-emoji18", "-emoji21", "-emoji23"});
        yield return _gameMethods.OpenDialog(8304); // "眼泪哗啦啦的放纵地往下掉落，很快模糊了视线。"
        yield return _gameMethods.Scene("yongzhe3_layered", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.67f, 0.86f)}, {"zoom", 0.73f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Show("2-25_zoom");
        yield return _gameMethods.Hide("2-25_zoom");
        Defaults.Gui_duihuakuang_you = 0;
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(8305); // "一片泪水朦胧的黑暗中，我感觉到有一只手小心翼翼、..."
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:6.0f);
        yield return _gameMethods.Show("black", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 112.0f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(8306); // "……我…、"
        yield return _gameMethods.OpenDialog(8307); // "少年迟疑的嗓音，在耳边响起。"
        yield return _gameMethods.OpenDialog(8308); // "——然后、变得坚定。"
        yield return _gameMethods.Scene("yongzhe3_layered", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.0f)}, {"zoom", 0.52f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.TransitionWithFadeIn(outTime:0.2f, holdTime:0.2f, inTime:1.3f, colorCode:"#fff");
        yield return _gameMethods.PlaySound("music1", 0.0f, 1.0f, "audio/music/yongzhe_gandong.mp3");
        yield return _gameMethods.OpenDialog(8309); // "我、安德鲁·布莱克。"
        yield return _gameMethods.OpenDialog(8310); // "在此起誓。"
        if (Defaults.Persistent.Povname == "辛西娅")
        {
            yield return _gameMethods.OpenDialog(8311); // "从今往后，我的使命即守护辛西娅·波莱。"
        }
        else
        {
            yield return _gameMethods.OpenDialog(8312); // "从今往后，我的使命即守护[persistent...."
        }
        yield return _gameMethods.OpenDialog(8313); // "仅此一人。"
        yield return _gameMethods.OpenDialog(8314); // "我将不懈怠、不松弛、不享乐。"
        yield return _gameMethods.OpenDialog(8315); // "咽尽苦痛，至死不渝。"
        yield return _gameMethods.OpenDialog(8316); // "今日如此，日日皆然。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei6", "yan12", "zui18", "emoji18", "emoji21", "emoji23", "-emoji19", "-emoji22", "-emoji24"});
        yield return _gameMethods.OpenDialog(8317); // "……呜——"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei9", "yan11", "zui13", "emoji15", "emoji18", "emoji22", "emoji24", "-emoji19", "-emoji21", "-emoji23"});
        yield return _gameMethods.OpenDialog(8318); // "哇啊啊啊啊……！！！"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8319); // "嚎啕大哭。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8320); // "我一直翘首以盼的机会。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8321); // "如今以如此残酷的方式出现在了面前。"
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        Defaults.Gui_duihuakuang_you = 1;
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(8322); // "那么，无论付出多大代价，\n我都一定要抓住它才行..."
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.StopSound(channelName:"music1", fadeOut:10.0f);
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/door_open1.mp3");
        yield return _gameMethods.Scene("heilong_dating_baitian", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.0f)}, {"zoom", 0.7f}})});
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.OpenDialog(8323); // "和安德鲁与洛恩分手后，我回到城堡，洗干净了自己身..."
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/demo_audio/sound/door_close1.mp3");
        yield return _gameMethods.Scene("woshi_nv2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(1.02f, 1.26f)}})});
        yield return _gameMethods.TransitionBy("trans_rip_fast");
        yield return _gameMethods.PlaySound("music", 5.0f, 1.0f, "audio/demo_audio/music/youshang2.mp3");
        yield return _gameMethods.Show("bishou1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 0.5f)}, {"pos", new Vector2(630.0f, 360.0f)}, {"zoom", 0.49f}, {"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.5f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan21", "zui15", "-emoji18", "-emoji22", "-emoji24"});
        yield return _gameMethods.OpenDialog(8324); // "回到卧室，端详着这把金灿灿的树枝，我发现上面刻着..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan20", "zui15"});
        yield return _gameMethods.OpenDialog(8325); // "那些文字弯弯曲曲，十分眼熟。"
        yield return _gameMethods.Show("bishou1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan18", "zui15"});
        yield return _gameMethods.OpenDialog(8326); // "……似乎是古龙文。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan18", "zui14"});
        yield return _gameMethods.OpenDialog(8327); // "…………吗？"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan9", "zui15"});
        yield return _gameMethods.OpenDialog(8328); // "嗯……是吗？"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(8329); // "我并不认识古龙文，但没关系。{nw}{w=0.0..."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(8330); // "\n学会真言，就掌握了一切其他语言。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan20", "zui15"});
        yield return _gameMethods.OpenDialog(8331); // "尽管学艺不精，但我还是磕磕绊绊勉强地翻译出了上面..."
        yield return _gameMethods.OpenDialog(8332); // "{cps=8}命运之枝，\n存汝之气，\n畅通其..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan9", "zui15"});
        yield return _gameMethods.OpenDialog(8333); // "文字精简而神秘，但我读到它的瞬间，就明白了其中蕴..."
        yield return _gameMethods.Show("black", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan18", "zui15"});
        yield return _gameMethods.OpenDialog(8334); // "使用它的条件有两则。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8335); // "一、必须是和要控制的目标有深厚的关系，要么是血脉..."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(8336); // "要么是有强烈的情感纽带。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan21", "zui15"});
        yield return _gameMethods.OpenDialog(8337); // "二、我必须先用自己的呼吸激活整根树枝，它才能生效..."
        yield return _gameMethods.Show("black", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 0.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan20", "zui5"});
        yield return _gameMethods.OpenDialog(8338); // "……有点庆幸提前学会了真言。不然大概拿到了都不知..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8339); // "果然知识就是力量，读书改变命运啊。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan21", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(8340); // "……强烈的情感纽带。"
        yield return _gameMethods.Hide("black");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(8341); // "我和赫泽尔之间，能有几分真正的感情存在呢？"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15"});
        yield return _gameMethods.OpenDialog(8342); // "一开始就建立在威胁与欺骗之上的关系，又能有几分厚..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan21", "zui18"});
        yield return _gameMethods.OpenDialog(8343); // "……心里没底啊。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui18"});
        yield return _gameMethods.OpenDialog(8344); // "无论哪方面，无论什么事，都没有把握。"
        yield return _gameMethods.Show("black");
        yield return _gameMethods.TransitionBy("blink4_1");
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/houhui/Tight Face_02_duan.mp3");
        yield return _gameMethods.OpenDialog(8345); // "我紧紧握着树枝，双臂抱住膝盖，把脸埋在手臂中。"
        yield return _gameMethods.OpenDialog(8346); // "我讨厌这种命运不能自主的感觉。"
        yield return _gameMethods.OpenDialog(8347); // "但是三年来，我也已经习惯了。"
        yield return _gameMethods.OpenDialog(8348); // "……默数五秒吧。"
        yield return _gameMethods.OpenDialog(8349); // "五秒钟之后，就必须坚强起来了。"
        yield return _gameMethods.EngineSetVolume(volume:0.6f, delay:1.5f, channelName:"music");
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.5>audio/demo_audio/sound/xintiao.ogg");
        yield return _gameMethods.OpenDialog(8350); // "一。"
        yield return _gameMethods.OpenDialog(8351); // "你要好好长大，好好吃饭，和喜欢的人结婚。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.5>audio/demo_audio/sound/xintiao.ogg");
        yield return _gameMethods.OpenDialog(8352); // "二。"
        yield return _gameMethods.OpenDialog(8353); // "再说了，从小家里那么多弟弟妹妹给我惹事，都照顾习..."
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.5>audio/demo_audio/sound/xintiao.ogg");
        yield return _gameMethods.OpenDialog(8354); // "三。"
        yield return _gameMethods.OpenDialog(8355); // "所以，现在，为了我长远的收益、你未来的劳动力，作..."
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.5>audio/demo_audio/sound/xintiao.ogg");
        yield return _gameMethods.OpenDialog(8356); // "四。"
        yield return _gameMethods.OpenDialog(8357); // "别哭了，不就一个破希望嘛，区区一份幸福，没了也能..."
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.5>audio/demo_audio/sound/xintiao.ogg");
        yield return _gameMethods.OpenDialog(8358); // "五。"
        yield return _gameMethods.OpenDialog(8359); // "明明想看着你长大的，为什么……"
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei6", "yan8", "zui15", "-emoji6", "-emoji2", "emoji20"});
        yield return _gameMethods.OpenDialog(8360); // "眼眶又开始发热，鼻子酸涩，但被我忍住了。"
        yield return _gameMethods.EngineSetVolume(volume:1.0f, delay:2.0f, channelName:"music");
        yield return _gameMethods.Hide("black");
        yield return _gameMethods.TransitionBy("blink3");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15", "-emoji20"});
        yield return _gameMethods.OpenDialog(8361); // "我长长地吸一口气，把对那些人的眷恋留在了黑暗中，..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(8362); // "好了，去激活吧。"
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.PlaySound("soundb", 2.0f, 1.0f, "audio/sound/dashuizhang/Spilling Stream Into Creek Gurgling Water_01.ogg");
        yield return _gameMethods.Scene("senlin6");
        yield return _gameMethods.Show("bishou1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 0.5f)}, {"pos", new Vector2(636.0f, 360.0f)}, {"zoom", 0.49f}})});
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.OpenDialog(8363); // "以防激活时产生的魔力残留在城堡里，让回来的赫泽察..."
        yield return _gameMethods.Show("bishou2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 0.5f)}, {"pos", new Vector2(636.0f, 360.0f)}, {"zoom", 0.49f}, {"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1.0f}})});
        yield return _gameMethods.OpenDialog(8364); // "……嘶……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan21", "zui15"});
        yield return _gameMethods.OpenDialog(8365); // "不过还真累啊。"
        yield return _gameMethods.Hide("bishou1");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan9", "zui15"});
        yield return _gameMethods.OpenDialog(8366); // "气息……"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(8367); // "不愧是神奇之物，这根树枝需要的气息也太多了。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(8368); // "吸足了气息后，这根树枝肉眼可见的变得更有光泽了。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(8369); // "我一边走神，把玩着它。另一个隐忧浮现上心头。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8370); // "安德鲁和洛恩……他们打不过赫泽尔。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan20", "zui15"});
        yield return _gameMethods.OpenDialog(8371); // "如果我——倘若真的动手之后——失败了怎么办？"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(8372); // "战败屈尊，天经地义。{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei5", "yan12", "zui14"});
        yield return _gameMethods.OpenDialog(8373); // "我没什么好说的。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan21", "zui18"});
        yield return _gameMethods.OpenDialog(8374); // "但他们不行。"
        if (Defaults.Bai_xue == 0)
        {
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(21); // "…………"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(8375); // "……可我又能怎么办呢。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan20", "zui15"});
            yield return _gameMethods.OpenDialog(8376); // "难道我还有其他路可以考虑吗？"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan12", "zui18"});
            yield return _gameMethods.OpenDialog(8377); // "算了，多想无益，徒增焦虑而已。"
            yield return _gameMethods.Show("bishou2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 0.5f)}, {"pos", new Vector2(636.0f, 360.0f)}, {"zoom", 0.49f}, {"alpha", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 0.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(8378); // "这一天的剩余时光，我都在城堡外练习抽枝和魔法。"
            yield return _gameMethods.Hide("bishou2");
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:2.0f);
            yield return _gameMethods.ChangeLabelTo("label_zhuxian6_3");
        }
        else
        {
            yield return _gameMethods.ChangeLabelTo("label_bai_manbu");
        }
    }

    public IEnumerator label_zhuxian6_3()
    {
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.Scene("heilong_shufang_baitian_shafa", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.2f, 2.77f)}, {"zpos", 0.0f}, {"zoom", 2.25f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 2.87f)}, {"zoom", 0.59f}})});
        yield return _gameMethods.Show("shuben", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 150.0f}, {"ypos", 450.0f}})});
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.OpenDialog(8379); // "第二天，赫泽尔回来了。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(8380); // "说起来，我曾经试图询问赫泽尔在龙之谷的经历，想要..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan20", "zui15"});
        yield return _gameMethods.OpenDialog(8381); // "但他从不肯跟我讲关于龙之谷，以及其它龙的事。"
        yield return _gameMethods.Show("shuben", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 450.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 1.0f}, {"ypos", 300.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(8382); // "总之，见到他没有发觉异常，{nw}{w=0.01..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan12", "zui10"});
        yield return _gameMethods.OpenDialog(6327); // "我松了口气。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan9", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15"});
        yield return _gameMethods.OpenDialog(8383); // "我们宁静的生活如此继续。"
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.Hide("shuben");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:4.0f);
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.PlaySound("soundb", 2.0f, 1.0f, "audio/sound/emeng_dajie/Town Crow_01.ogg");
        yield return _gameMethods.Scene("dajie1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.45f, 1.09f)}, {"zoom", 0.89f}})});
        yield return _gameMethods.Transition(time:0.5f);
        Defaults.Persistent.Jq_9_4 = 1;
        yield return _gameMethods.PlaySound("music1", 0.0f, 0.4f, "audio/music/PerituneMaterial_Harvest_loop___chujie.mp3");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(8384); // "新的季度来临，赫泽尔和我再次来到山下的小镇补充物..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui15"});
        yield return _gameMethods.OpenDialog(8385); // "……是错觉吗？总感觉这里好像比印象中繁荣了很多。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.0f, 0.0f)}, {"pos", new Vector2(1446.0f, 192.0f)}, {"zoom", 2.04f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(8386); // "我来到每次采购都会来的那家水果摊。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui7"});
        yield return _gameMethods.OpenDialog(8387); // "这家店的老板已经算得上是熟人了，偶尔也会在买卖之..."
        yield return _gameMethods.ExecuteCharacterImageData("h_nv");
        yield return _gameMethods.OpenDialog(8388); // "小姐，你们是姐弟吗？关系真好啊。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan10", "zui13", "emoji2", "emoji6"});
        yield return _gameMethods.OpenDialog(8389); // "……哪敢如此冒犯了上级！"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan20", "zui8", "emoji2", "emoji6"});
        yield return _gameMethods.OpenDialog(8390); // "我大脑飞速运转，思考回答。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan27", "zui9"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}, {"blur", 0.01f}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(1050.0f, 1002.0f)}, {"zoom", 0.25f}, {"zpos", 5.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.3f}, {"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian6_3_5eca7915.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(8391); // "我们不是。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan27", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15", "-emoji2", "-emoji6"});
        yield return _gameMethods.OpenDialog(8392); // "身旁的赫泽尔忽地出声打断。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan22", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(8393); // "他面无表情地说完这一句，就闭了嘴，丝毫没有要继续..."
        yield return _gameMethods.OpenDialog(8394); // "……啊，这样吗。"
        yield return _gameMethods.OpenDialog(8395); // "这副不近人情的样子，让气氛瞬间冷场。那个店主看起..."
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19", "emoji2"});
        yield return _gameMethods.OpenDialog(3326); // "啊、啊哈哈……"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan25", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan22", "zui2"});
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan24", "zui16", "emoji2"});
        yield return _gameMethods.OpenDialog(8396); // "还是打个圆场吧。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(8397); // "怎么解释呢？"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui8", "emoji2"});
        yield return _gameMethods.OpenDialog(8398); // "“其实，这是我们家的小少爷”，这样说应该可以吧…..."
        yield return _gameMethods.StopSound(channelName:"music1", fadeOut:2.0f);
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui19", "-emoji2"});
        yield return _gameMethods.OpenDialog(8399); // "其实——"
        yield return _gameMethods.EngineSetVolume(volume:0.6f, delay:2.0f, channelName:"soundb");
        yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/music/yongzhe_Side.mp3");
        yield return _gameMethods.ExecuteCharacterImageData("an_weizhi");
        yield return _gameMethods.OpenDialog(5546); // "是吗？"
        yield return _gameMethods.ExecuteCharacterImageData("an_weizhi");
        yield return _gameMethods.OpenDialog(8400); // "可我看起来倒挺像的。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/moca1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0.0f}, {"parallel_1", true}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        Engine._history = false;
        yield return _gameMethods.OpenDialog(4081); // "{nw}{w=0.25}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan27", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan25", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"yoffset", 0.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8401); // "一道熟悉的声音在身后响起。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(8402); // "震惊、不可思议同时涌上心头。"
        yield return _gameMethods.OpenDialog(8403); // "我不敢回身。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan25", "zui2"});
        Engine._history = false;
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan27", "zui2"});
        yield return _gameMethods.OpenDialog(8404); // "他怎么会在这里。"
        yield return _gameMethods.OpenDialog(8405); // "他怎么能在这里。"
        yield return _gameMethods.OpenDialog(8406); // "——可是、他似乎的确应该出现在这里。"
        yield return _gameMethods.OpenDialog(8407); // "这座小镇，是距离黑龙城堡最近的一个人类聚居地。"
        yield return _gameMethods.PlaySound("sound", 0.5f, 1.0f, "<from 0 to 2>audio/sound/jiaobusheng_an_normal1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 1446.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 1.5f}, {"xpos", 1272.0f}})});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui16"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.61f, 1.44f)}, {"zoom", 0.22f}, {"alpha", 0.0f}, {"blur", 0.01f}, {"zpos", 5.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 1.0f}, {"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan10", "zui2"});
        yield return _gameMethods.OpenDialog(8408); // "随着那人走近，他的面容出现在我们面前。"
        yield return _gameMethods.OpenDialog(8409); // "勇者大人！"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan3", "zui2"});
        yield return _gameMethods.OpenDialog(8410); // "店主的脸上霎时间容光焕发，露出一种混合着仰望、崇..."
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui13"});
        yield return _gameMethods.OpenDialog(8411); // "你好。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui16"});
        yield return _gameMethods.OpenDialog(8412); // "安德鲁露出了一个稳重、可靠而亲切，又保持着适度的..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan25", "zui2"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan3", "zui2"});
        yield return _gameMethods.OpenDialog(8413); // "对摊主点了点头，作为致意。"
        yield return _gameMethods.Show("an2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 1272.0f}})});
        yield return _gameMethods.OpenDialog(8414); // "他好像已经对别人的这种态度习以为常了。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan2", "zui16"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui16"});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan27", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(8415); // "我似乎从没在他脸上见过这种陌生的神情。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(8416); // "但毫无疑问，那是一个完美的微笑。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan17", "zui15"});
        yield return _gameMethods.OpenDialog(8417); // "正是那种承载着众人的仰慕与期望，又平易近人的勇者..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan10", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan22", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(8418); // "赫泽尔瞥了他一眼，似乎被后者身上的什么东西引起了..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan25", "zui2"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan22", "zui2"});
        yield return _gameMethods.OpenDialog(8419); // "他垂眸望了下安德鲁胸前的徽章，稍稍眯起眼。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan10", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(8420); // "人类的勇者。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan10", "zui2"});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan14", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8421); // "随着赫泽尔的这句陈述，安德鲁眼中原本的怀疑也落定..."
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan14", "zui4"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv");
        yield return _gameMethods.OpenDialog(8422); // "尼德霍格。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan14", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(8423); // "他用陈述的语气说道，{nw}{w=0.01}"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan3", "zui16"});
        yield return _gameMethods.OpenDialog(8424); // "微微笑了起来。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan3", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
        yield return _gameMethods.OpenDialog(8425); // "「果然，{nw}{w=0.01}"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan14", "zui13"});
        yield return _gameMethods.OpenDialog(8426); // "人类和非人的生物就是截然不同啊。」"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan14", "zui16"});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan21", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui18", "emoji2"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan2", "zui16"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan14", "zui16"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv");
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(8427); // "买好了吗？"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan14", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui18"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui18", "-emoji2"});
        yield return _gameMethods.OpenDialog(8428); // "无视了对方，赫泽尔直接对我询问。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(8429); // "这副目下无尘、目空一切的高傲模样，一如既往。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui1"});
        yield return _gameMethods.OpenDialog(8430); // "安德鲁没有生气，那双绿松石一样的眼瞳转向了我。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.5>audio/sound/jiaobusheng_an_normal1.ogg");
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui4"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 1.44f}, {"zoom", 0.21999999999999997f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.5f}, {"ypos", 1.49f}, {"zoom", 0.23f}})});
        yield return _gameMethods.OpenDialog(8431); // "你——"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei9", "yan21", "zui2"});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui18", "emoji2"});
        yield return _gameMethods.OpenDialog(8432); // "我的心提到了嗓子眼。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan12", "zui12"});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan25", "zui21"});
        if (Defaults.Persistent.Povname == "辛西娅")
        {
            yield return _gameMethods.ExecuteCharacterImageData("an_nv");
            yield return _gameMethods.OpenDialog(8433); // "你就是被抓走的辛西娅公主吧？"
        }
        else
        {
            yield return _gameMethods.ExecuteCharacterImageData("an_nv");
            yield return _gameMethods.OpenDialog(8434); // "你就是被抓走的[persistent.povna..."
        }
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan12", "zui10"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 1.49f}, {"zoom", 0.23f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan21", "zui21"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan2", "zui10", "-emoji2"});
        yield return _gameMethods.OpenDialog(1495); // "「呃……"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei8", "yan11", "zui2", "emoji2"});
        yield return _gameMethods.OpenDialog(8435); // "你好？……」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan5", "zui2", "emoji2"});
        yield return _gameMethods.OpenDialog(8436); // "很高兴见到你，你就是王国的勇者么。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan23", "zui13"});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan27", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei8", "yan5", "zui8", "-emoji2"});
        yield return _gameMethods.OpenDialog(6115); // "是啊……"
        yield return _gameMethods.ExecuteCharacterImageData("an_nv");
        yield return _gameMethods.OpenDialog(8437); // "我也想见你很久了……"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei18", "yan22", "zui3"});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan23", "zui16"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan10", "zui1", "emoji2", "emoji15"});
        yield return _gameMethods.OpenDialog(8438); // "怎么突然说这么肉麻的话！！"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan25", "zui2"});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 1272.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.4f}, {"xpos", 1500.0f}})});
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/dashuizhang/money_box2.mp3");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan10", "zui7", "emoji2", "emoji15"});
        yield return _gameMethods.OpenDialog(8439); // "“当啷”一声。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan22", "zui2"});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan4", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan2", "zui15", "emoji2", "-emoji15"});
        yield return _gameMethods.OpenDialog(8440); // "赫泽尔把一颗魔石丢到了摊子上，发出清脆的响声。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 1500.0f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan27", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei8", "yan5", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(8441); // "「买完了，{nw}{w=0.01}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan25", "zui12"});
        yield return _gameMethods.OpenDialog(8442); // "走吧。」"
        yield return _gameMethods.PlaySound("sound", 0.0f, 3.0f, "audio/sound/manbu/Body1_02_duan.mp3");
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan22", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}, {"blur", 0.01f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"alpha", 0.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan12", "zui2"});
        yield return _gameMethods.OpenDialog(8443); // "他握住我的手腕，便要扯着我离开。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan19", "zui2"});
        yield return _gameMethods.OpenDialog(8444); // "我一时犹豫，没有跟着移动脚步。"
        yield return _gameMethods.OpenDialog(8445); // "赫泽尔的脚步被我牵绊住了一下。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei18", "yan22", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}, {"blur", 0.01f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"blur", 0.0f}, {"alpha", 1.0f}})});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei10", "yan8", "zui1", "emoji8"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.OpenDialog(8446); // "糟了。在他面前表现出了对勇者的偏向。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan12", "zui2", "emoji8"});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei18", "yan25", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}, {"alpha", 1.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("he_qian");
        yield return _gameMethods.OpenDialog(4400); // "「……{nw}{w=0.2}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan15", "zui2"});
        yield return _gameMethods.OpenDialog(1265); // "……」"
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(8447); // "赫泽尔沉默片刻，出人意料地什么也没说，只是拉着我..."
        yield return _gameMethods.OpenDialog(8448); // "这次，我只能跟着挪动了脚步。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 2.0f, "<from 0 to 2>audio/sound/jiaobusheng_xin_kuai1.ogg");
        yield return _gameMethods.Scene("dajie1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.43f, 1.53f)}, {"zoom", 1.43f}})});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan1", "zui9", "-emoji8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.91f)}, {"zoom", 0.32f}})});
        yield return _gameMethods.PlaySound("soundc", 0.0f, 0.2f, "audio/sound/end/footsteps_003_01.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -120.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 4.0f}, {"zpos", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.36f}, {"ypos", -5.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"ypos", -5.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.30f}, {"ypos", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"ypos", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.28f}, {"ypos", 10.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"ypos", 7.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.28f}, {"ypos", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"ypos", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.23f}, {"ypos", -10.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.08f}, {"ypos", -7.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.30f}, {"ypos", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.09f}, {"ypos", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"repeat", true}, {"parallel_1", true}})});
        yield return _gameMethods.TransitionBy("blink3_1");
        yield return _gameMethods.OpenDialog(8449); // "走了几步，我忍不住回头。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan1", "zui1", "-emoji8"});
        yield return _gameMethods.PlaySound("sounde", 0.0f, 5.0f, "audio/sound/end/jiaobu_kuai_sha_01.ogg");
        yield return _gameMethods.OpenDialog(8450); // "安德鲁站在原地，望着这边。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan12", "zui1", "emoji7", "-emoji8"});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(8451); // "金色的额发微微遮住了双眼，那张总是展现出各种鲜活..."
        yield return _gameMethods.OpenDialog(8452); // "清澈的绿瞳眼底，漫上了一层薄暗色的阴翳。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"ypos", -126.0f}, {"zpos", -276.0f}})});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan1", "zui1", "-emoji7"});
        yield return _gameMethods.Show("yongzhe_shuye", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"ypos", 0.89f}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.92f}, {"xpos", 0.5f}})});
        yield return _gameMethods.PlaySound("soundd", 1.0f, 2.0f, "audio/sound/manbu/Gentle Breeze Blowing Foliage Rustling_01.ogg");
        yield return _gameMethods.EngineSetVolume(volume:0.6f, delay:1.0f, channelName:"soundb");
        yield return _gameMethods.StopSound(channelName:"soundc", fadeOut:2.0f);
        yield return _gameMethods.StopSound(channelName:"sounde", fadeOut:2.0f);
        yield return _gameMethods.TransitionBy("blink2");
        yield return _gameMethods.OpenDialog(8453); // "直到我们目光交汇。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan4", "zui1"});
        yield return _gameMethods.OpenDialog(8454); // "他微微愣神，{nw}{w=0.2}"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei4", "yan12", "zui10", "emoji6", "emoji12", "emoji20"});
        yield return _gameMethods.OpenDialog(8455); // "展开一个笑容。"
        yield return _gameMethods.OpenDialog(8456); // "愤怒、内疚、{nw}{w=0.3}"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan23", "zui16", "emoji6", "emoji13", "emoji20", "-emoji12"});
        yield return _gameMethods.OpenDialog(8457); // "深深地痛苦、挣扎、哀伤……的笑容。"
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.OpenDialog(8458); // "原来如此。他明白我的处境。"
        yield return _gameMethods.OpenDialog(8459); // "他是故意装不认识我的，也是忍住了才没有追上来。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan2", "zui16", "-emoji6", "emoji13", "emoji20", "-emoji12"});
        yield return _gameMethods.OpenDialog(8460); // "因为他明白，假若表现得和我关系密切，只会让我在黑..."
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan23", "zui16", "emoji6", "emoji13", "emoji20", "-emoji12"});
        yield return _gameMethods.OpenDialog(8461); // "……如果几个月之后我就会死在决战。"
        yield return _gameMethods.OpenDialog(8462); // "那么，这也许便是我们倒数第二次的见面。"
        yield return _gameMethods.OpenDialog(8463); // "见一次少一次。"
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.36f}, {"yoffset", -5.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", -5.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.30f}, {"yoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.28f}, {"yoffset", 10.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 7.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.28f}, {"yoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"yoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.23f}, {"yoffset", -10.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.08f}, {"yoffset", -7.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.30f}, {"yoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.09f}, {"yoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"repeat", true}, {"parallel_0", true}})});
        yield return _gameMethods.PlaySound("soundc", 0.0f, 0.2f, "audio/sound/end/footsteps_003_01.ogg");
        yield return _gameMethods.PlaySound("sounde", 0.0f, 5.0f, "audio/sound/end/jiaobu_kuai_sha_01.ogg");
        yield return _gameMethods.PlaySound("sound", 0.0f, 2.0f, "audio/sound/houhui/Tight Face_02_duan.mp3");
        yield return _gameMethods.OpenDialog(8464); // "赫泽尔握的很紧，脚步有些快，几乎是有什么急迫的事..."
        yield return _gameMethods.OpenDialog(8465); // "我不得不有些勉强地跟在他后面。"
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Hide("an2");
        yield return _gameMethods.Hide("yongzhe_shuye");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -126.0f}})});
        yield return _gameMethods.Show("dajie1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"ypos", 1.48f}, {"zoom", 0.75f}, {"yoffset", -100.0f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.2f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 1.0f}, {"yoffset", 0.0f}})});
        yield return _gameMethods.StopSound(channelName:"soundd", fadeOut:2.0f);
        yield return _gameMethods.PlaySound("sounda1", 0.0f, 1.0f, "audio/sound/emeng_dajie/Magic Spell Book Pages Flipping_01.ogg");
        yield return _gameMethods.TransitionWithFadeIn(outTime:0.1f, holdTime:0.2f, inTime:0.1f, colorCode:"#fff");
        yield return _gameMethods.OpenDialog(8466); // "忽然间，我强烈地意识到。"
        yield return _gameMethods.OpenDialog(8467); // "如果我还想和他多说一句话，此时此刻，是最后一个来..."
        yield return _gameMethods.OpenDialog(8468); // "机会稍纵即逝。"
        yield return _gameMethods.Show("dajie1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}})});
        yield return _gameMethods.OpenSelectMenu(
            talk: new List<string>{"-跟赫泽尔回城堡", "-不择手段留下来"},
            jump: new List<string>{"label_zhuxian6_menu_3_psZbjBcn", "label_zhuxian6_menu_3_hzBt87YW"},
            condition: new List<string>{"NONE", "NONE"}
        );
    }

    public IEnumerator label_zhuxian6_8()
    {
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Scene("heilong_shufang_bangwan3", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(0.5f, 1.09f)}, {"zoom", 0.94f}, {"anchor", new Vector2(0.5f, 1.0f)}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.PlaySound("music3", 3.0f, 1.0f, "audio/demo_audio/music/youshang1.mp3");
        Defaults.Persistent.Jq_9_5 = 1;
        Defaults.Haogandu_an = Defaults.Haogandu_an + 1;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(8580); // "距离预言中所记载的最终决战之日，只剩三个月了。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15"});
        yield return _gameMethods.OpenDialog(8581); // "我和赫泽尔之间，保持着一种诡异的平静。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(8582); // "很多次，我想打破这种安静。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan20", "zui15"});
        yield return _gameMethods.OpenDialog(8583); // "想问他，是否打算放过我。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(8584); // "但我忍住了。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8585); // "内心其实很明白。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan20", "zui15"});
        yield return _gameMethods.OpenDialog(8586); // "这个至关重要的问题，一直卡在我们二人心里。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8587); // "我在意它。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8588); // "他知道我在意它。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(8589); // "而如今，决战在即，他却从未提及这个问题，没有半点..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(7821); // "这本身就是一种态度。"
        yield return _gameMethods.PlaySound("sound", 0.2f, 0.4f, "audio/demo_audio/sound/moca2.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.7f}, {"ypos", 156.0f}})});
        yield return _gameMethods.Show("heilong_shufang_bangwan1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(678.0f, 906.0f)}, {"zoom", 1.07f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1.0f}})});
        yield return _gameMethods.Show("shuben", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}, {"xoffset", 170.0f}, {"yoffset", 400.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.3f}, {"alpha", 1.0f}})});
        yield return _gameMethods.OpenDialog(8590); // "………………尽管我如此清楚地明白这个道理。"
        yield return _gameMethods.Show("heilong_shufang_bangwan1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        yield return _gameMethods.Show("shuben", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 156.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui18"});
        yield return _gameMethods.OpenDialog(8591); // "但还是无法死心。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8592); // "大言不惭地说，我能感受赫泽尔对我的在乎。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan21", "zui18"});
        yield return _gameMethods.OpenDialog(8593); // "如果还有那么一丝可能，能够用感情打动他，对我手下..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(8594); // "于是，我打算做出最后一步试探。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8595); // "——告诉他，我想活着。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan9", "zui15"});
        yield return _gameMethods.OpenDialog(8596); // "当然，理由不能只是因为我想活着。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/book2_he.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 156.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.55f}, {"ypos", 102.0f}})});
        yield return _gameMethods.Show("heilong_shufang_bangwan_shafa1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.17f, 1.94f)}, {"zoom", 1.28f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 2.99f)}, {"zoom", 0.59f}})});
        yield return _gameMethods.Hide("shuben");
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 102.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(8597); // "我放下书本，看向赫泽尔。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(8598); // "心中开始回放，三年来朝夕相处的点点滴滴——"
        yield return _gameMethods.OpenDialog(8599); // "一开始，这条强大巨龙对我的不屑。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
        Engine._history = false;
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui2"});
        yield return _gameMethods.OpenDialog(8600); // "从读书讨论开始，冰层破解。"
        yield return _gameMethods.OpenDialog(8601); // "第一次同床共枕，对“爱”的争论。"
        yield return _gameMethods.OpenDialog(8602); // "生病。偏头痛。每天的早餐桌。"
        yield return _gameMethods.OpenDialog(8603); // "生日蛋糕。无数个外出归来时的礼物。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
        Engine._history = false;
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui2"});
        yield return _gameMethods.OpenDialog(8604); // "每一幕都清晰得宛如昨日。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan9", "zui15"});
        yield return _gameMethods.OpenDialog(8605); // "顺理成章地，我的心头流淌出了饱满而新鲜的情感。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8606); // "温馨。感慨。留恋。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(8607); // "这三年来，我每时每刻都在做一件事——确保自己是乐..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan21", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8608); // "但此时此刻，我明确地意识到，自己是如此悲伤于即将..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan7", "zui2"});
        Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8609); // "悲伤、不舍与不甘充斥心间。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(8610); // "我凝视着那头男孩外表的龙。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(964); // "赫泽尔。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan17", "zui15"});
        yield return _gameMethods.OpenDialog(8611); // "我们真的要就此分离吗。"
        yield return _gameMethods.PlaySound("sound", 0.3f, 0.2f, "audio/demo_audio/sound/moca2.mp3");
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8612); // "他抬起头来，看向了我。"
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan17", "zui15"});
        yield return _gameMethods.OpenDialog(8613); // "他感应到了。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan15", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8614); // "赫泽尔的眼神似乎挣扎了一下。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei18", "yan25", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8615); // "但很快恢复了镇定。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8616); // "面色一如既往，冷静而平淡。"
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan17", "zui15"});
        yield return _gameMethods.OpenDialog(8617); // "我默默等待。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8618); // "他没有说一句话。"
        yield return _gameMethods.Show("black", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.28f)}, {"zoom", 1.36f}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1.0f}})});
        yield return _gameMethods.StopSound(channelName:"music3", fadeOut:5.0f);
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan20", "zui7"});
        yield return _gameMethods.OpenDialog(8619); // "……好吧，我明白了。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8620); // "我收拾好那些情绪，将悲伤与不舍一一收回，妥善地处..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
        yield return _gameMethods.Show("black", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 0.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15"});
        yield return _gameMethods.OpenDialog(8621); // "这是我进入社会后学会的一项工作技能，因为很多事情..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(8622); // "然后，"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei1", "yan11", "zui7"});
        yield return _gameMethods.OpenDialog(8623); // "我露出伤感的微笑。"
        yield return _gameMethods.PlaySound("music1", 0.0f, 1.0f, "audio/music/end/end_baiyin01.mp3");
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei1", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(8624); // "我想送你一个礼物。"
        yield return _gameMethods.Hide("black");
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan8", "zui7"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan29", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"d3"});
        yield return _gameMethods.OpenDialog(8625); // "我把右耳垂上的耳坠解了下来。"
        yield return _gameMethods.PlaySound("sound", 0.3f, 0.2f, "audio/demo_audio/sound/moca6_duan_duan.mp3");
        yield return _gameMethods.Show("erzhui1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}, {"anchor", new Vector2(0.0f, 0.0f)}, {"pos", new Vector2(528.0f, 546.0f)}, {"zoom", 0.16f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(8626); // "这个给你。"
        yield return _gameMethods.Show("erzhui1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan11", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei8", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(165); // "？"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan2", "zui10"});
        yield return _gameMethods.OpenDialog(8627); // "这是我的耳坠。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei8", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(4869); // "我知道。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
        Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(8628); // "我们戴一样的耳坠，就体现我们两个关系不一般。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei8", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(8629); // "……这个应该怎么戴。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(8630); // "「就是穿在耳洞……{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei8", "yan2", "zui10"});
        yield return _gameMethods.OpenDialog(8631); // "哦，你好像没有耳洞。」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei8", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(8632); // "可以打一个。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(8633); // "「那，{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei8", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(8634); // "我来给你打耳洞可以吗。」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei8", "yan2", "zui7"});
        yield return _gameMethods.OpenDialog(249); // "可以。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
        yield return _gameMethods.Show("black", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.32f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 1.25f}})});
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.OpenDialog(8635); // "我试着直接使用其自带的针头。"
        yield return _gameMethods.Hide("black");
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2"});
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan21", "zui10"});
        yield return _gameMethods.OpenDialog(8636); // "……嗯——不行啊。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan21", "zui15"});
        yield return _gameMethods.OpenDialog(8637); // "不出所料，他的皮肤摸着触感柔软，但我加大气力，再..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan9", "zui15"});
        yield return _gameMethods.OpenDialog(8638); // "当纹路的波动褪去，那只耳朵连表皮都没有擦破。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan28", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan12", "zui10"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei1", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(8639); // "「抱歉，我太弱小了，{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei1", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(8640); // "你的耳垂太坚韧。」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui2"});
        yield return _gameMethods.PlaySound("sounda1", 0.0f, 0.3f, "audio/sound/houhui/Bones Break Cracking_02.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei1", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(8641); // "现在你可以再试一次。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(8642); // "虽然看不见变化，但我知道，他已经撤下了对我的鳞片..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan9", "zui15"});
        yield return _gameMethods.OpenDialog(8643); // "我再次勤勤恳恳地给赫泽尔戳耳洞。"
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/demo_audio/sound/sibuliao2.mp3");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8644); // "由于紧贴在耳针旁边的花朵装饰实在碍事，{nw}{..."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan21", "zui15"});
        yield return _gameMethods.OpenDialog(8645); // "我试了几次，没能成功，"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/moca3.mp3");
        yield return _gameMethods.Show("erzhui1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 0.0f}})});
        yield return _gameMethods.Show("erzhui2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}, {"anchor", new Vector2(0.0f, 0.0f)}, {"pos", new Vector2(528.0f, 546.0f)}, {"zoom", 0.16f}, {"yoffset", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 1.0f}, {"yoffset", -50.0f}, {"parallel_1", true}})});
        yield return _gameMethods.OpenDialog(8646); // "干脆把装饰拽了下来。"
        yield return _gameMethods.Show("erzhui2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}, {"yoffset", -50.0f}})});
        yield return _gameMethods.Hide("erzhui1");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8647); // "用了番力气后……"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei8", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei8", "yan9", "zui8"});
        yield return _gameMethods.OpenDialog(8648); // "果然，没有龙鳞的阻拦，{nw}{w=0.01}"
        yield return _gameMethods.Show("erzhui2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 0.0f}})});
        yield return _gameMethods.OpenDialog(8649); // "我的尝试最终成功了。"
        yield return _gameMethods.Hide("erzhui2");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8650); // "很快，我观察到，从耳洞侧面出现了即将愈合的预兆。"
        yield return _gameMethods.Show("black", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.29f)}, {"zoom", 1.37f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
        yield return _gameMethods.Transition(time:0.5f);
        Engine._history = false;
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2"});
        yield return _gameMethods.OpenDialog(8651); // "我眼疾手快，在耳洞愈合、排出异物之前，给他戴上了..."
        yield return _gameMethods.Hide("black");
        yield return _gameMethods.Show("he", parts: new List<string>{"d1"});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(8652); // "红宝石耳坠，挂在他的右耳下，像一轮红月。"
        yield return _gameMethods.PlaySound("sound", 0.2f, 0.4f, "audio/demo_audio/sound/moca2.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.5f}, {"zpos", 30.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan5", "zui8"});
        yield return _gameMethods.OpenDialog(8653); // "我松开手，微笑望他。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(8654); // "这样，就算我不在了以后，它也能陪伴在你身边。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan2", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei8", "yan9", "zui8"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 30.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei1", "yan17", "zui3"});
        yield return _gameMethods.OpenDialog(8655); // "你会记住我吗。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan2", "zui21"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei1", "yan17", "zui7"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.OpenDialog(8656); // "他动了动嘴，似乎想说些什么。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan22", "zui3"});
        Engine._history = false;
        yield return _gameMethods.OpenDialog(226); // "{nw}{w=0.2}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan15", "zui2"});
        yield return _gameMethods.OpenDialog(8657); // "但最后只是……"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan25", "zui9"});
        Engine._history = false;
        yield return _gameMethods.OpenDialog(2054); // "{nw}{w=0.3}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan27", "zui9"});
        yield return _gameMethods.OpenDialog(765); // "嗯。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan27", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan17", "zui7"});
        yield return _gameMethods.OpenDialog(8658); // "好，不用说了。"
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan12", "zui7"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan21", "zui15"});
        yield return _gameMethods.OpenDialog(8659); // "我已经全部知道了。"
        yield return _gameMethods.StopSound(channelName:"music1", fadeOut:10.0f);
        yield return _gameMethods.ChangeLabelTo("label_juezhan");
        yield break;
    }

}
