using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end7 : ILabelProvider
{
    private GameMethods _gameMethods;

    public end7(GameMethods gameMethods)
    {
        _gameMethods = gameMethods;
    }

    public IEnumerator label_end6()
    {
        yield return _gameMethods.OpenDialog(5681); // "我想……同他好好谈谈。"
        yield return _gameMethods.OpenDialog(5682); // "但是，如果就这么直接和他摊牌，我不放心。"
        yield return _gameMethods.OpenDialog(5683); // "假若和谈失败，那我就无计可施了。"
        yield return _gameMethods.OpenDialog(5684); // "我需要一个保险。"
        yield return _gameMethods.OpenDialog(5685); // "比如，让他先丧失行动能力。"
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15", "d3"});
        yield return _gameMethods.OpenDialog(5687); // "我深吸了一口气。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(5688); // "露出若无其事的笑脸。"
        yield return _gameMethods.Show("caodi2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.31f)}, {"zoom", 1.05f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui2", "d1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.49f, 2.51f)}, {"zoom", 0.5f}})});
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/manbu/Body1_01.mp3");
        yield return _gameMethods.TransitionBy("blink2");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(5689); // "然后，扯了扯赫泽尔的衣袖。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(964); // "赫泽尔。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei8", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan2", "zui10"});
        yield return _gameMethods.OpenDialog(5691); // "我们可能再也见不到了。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei1", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(5692); // "「在那之前，{nw}{w=0.01}"
        Defaults.Haogandu_he = Defaults.Haogandu_he + 2;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei1", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(5693); // "再抱一抱吧。」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan29", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei1", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.OpenDialog(33); // "………………"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0.5 to 3>audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
        yield return _gameMethods.Show("he", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 2.5f}, {"zpos", 96.0f}})});
        yield return _gameMethods.OpenDialog(5696); // "他看了我几秒，向我走近。"
        yield return _gameMethods.Show("he", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 96.0f}})});
        yield return _gameMethods.Show("black", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 100.0f}})});
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/houhui/Body3 _01.mp3");
        yield return _gameMethods.Transition(time:0.3f);
        yield return _gameMethods.OpenDialog(5697); // "抬起手，将双臂揽在了我的背后。"
        yield return _gameMethods.OpenDialog(5698); // "他抱住了我。"
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/manbu/Body1_01.mp3");
        yield return _gameMethods.OpenDialog(5699); // "于是，我也抬起双手，轻轻搂住他。"
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/houhui/Body3 _01.mp3");
        yield return _gameMethods.StopSound(channelName:"soundc", fadeOut:1.0f);
        yield return _gameMethods.Hide("black");
        yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan13", "zui19"});
        yield return _gameMethods.Transition(time:0.3f);
        yield return _gameMethods.OpenDialog(5700); // "……拥抱了几秒钟，我主动放开了他。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan27", "zui2"});
        Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.OpenDialog(5701); // "其实，我还给你准备了一份礼物。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.OpenDialog(5702); // "本来是想作为你今年的生日礼物的，但感觉……可能没..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan29", "zui2"});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_qian");
        yield return _gameMethods.OpenDialog(1543); // "「……{nw}{w=0.4}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
        yield return _gameMethods.OpenDialog(1265); // "……」"
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.OpenDialog(5705); // "我们对视了几秒。"
        yield return _gameMethods.OpenDialog(5706); // "赫泽尔，闭上眼睛。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.65f}, {"zpos", -24.0f}})});
        yield return _gameMethods.OpenDialog(5707); // "在决战开始之前，让我最后给你一份礼物。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
        Engine._history = false;
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
        yield return _gameMethods.OpenDialog(5709); // "他面无表情地盯了我片刻。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -24.0f}})});
        yield return _gameMethods.OpenDialog(5710); // "我的心情意外地平静。"
        yield return _gameMethods.OpenDialog(5711); // "我们安静地对视，"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui2"});
        yield return _gameMethods.OpenDialog(5712); // "他垂了垂眼睛，"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
        yield return _gameMethods.OpenDialog(5713); // "那双血红的眼瞳缓缓闭合。"
        yield return _gameMethods.OpenDialog(5714); // "就像一个与此情此景毫无关联的旁观者一样，我以新奇..."
        yield return _gameMethods.OpenDialog(5715); // "精致而年轻，骄傲而稚嫩。"
        yield return _gameMethods.OpenDialog(5716); // "这是同我一起朝夕相处了三年的龙。"
        yield return _gameMethods.OpenDialog(5717); // "即便在当下的战场上，他也毫无戒备地向我闭上双眼。"
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:7.0f);
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/houhui/Grab Hand_01.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -24.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.65f}, {"zpos", -40.0f}})});
        yield return _gameMethods.OpenDialog(5718); // "心中百感交集，我伸出手，轻轻地抚摸了他的脸庞。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei4", "yan25", "zui2"});
        yield return _gameMethods.OpenDialog(5719); // "赫泽尔的睫毛微微颤动了一下，但他放任了我的行为。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -40.0f}})});
        yield return _gameMethods.PlaySound("sounda", 0.2f, 0.4f, "audio/demo_audio/sound/moca2.mp3");
        yield return _gameMethods.OpenDialog(5720); // "我收回了手。"
        yield return _gameMethods.OpenDialog(5721); // "赫泽尔耐心地等待着。"
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.PlaySound("sounda", 0.0f, 0.3f, "<silence 0.5>audio/sound/juezhan_dao/tinnitus1.mp3");
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<silence 0.2>audio/sound/juezhan2/Blade Stab Cut Body Blood_01.ogg");
        yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:1.0f);
        yield return _gameMethods.Scene("tongdaozi_cg_layered", parts: new List<string>{"d_mei2", "d_yan3", "d_zui3"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.01f)}, {"zoom", 0.52f}})});
        yield return _gameMethods.Show("black");
        yield return _gameMethods.Show("bishou2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"rotate", 31.0f}, {"zoom", 0.28f}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(0.54f, 0.96f)}, {"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.3f}, {"pos", new Vector2(0.39f, 1.06f)}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.15f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.15f}, {"alpha", 1.0f}, {"parallel_1", true}})});
        yield return _gameMethods.Show("erhuan_guang1_ani", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.62f, 1.2f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"rotate", -48.0f}, {"zoom", 0.71f}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.5f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.0f}, {"alpha", 1.0f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-126.0f, 114.0f)}, {"zpos", -300.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        Defaults.Gui_duihuakuang_you = 0;
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.Show("black", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"alpha", 0.0f}})});
        yield return _gameMethods.Show("bishou2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"alpha", 0.0f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-126.0f, 114.0f)}, {"zpos", -300.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 2.0f}, {"zpos", -270.0f}})});
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.Hide("erhuan_guang1_ani");
        yield return _gameMethods.Transition(time:0.8f);
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.Hide("black");
        yield return _gameMethods.Hide("bishou2");
        yield return _gameMethods.OpenDialog(47); // "……！"
        yield return _gameMethods.OpenDialog(5724); // "突然他意识到自己已无法控制四肢，身体瘫软得要向地..."
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 114.0f}, {"zpos", -270.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 2.0f}, {"ypos", -42.0f}})});
        yield return _gameMethods.OpenDialog(5725); // "他双眼撑大，对眼前景象感到茫然一般、空盲地抬头。"
        yield return _gameMethods.PlaySound("soundb", 3.0f, 1.5f, "audio/sound/manbu/Gentle Breeze Blowing Foliage Rustling_01.ogg");
        yield return _gameMethods.EngineSetVolume(volume:0.5f, delay:0.01f, channelName:"soundb");
        yield return _gameMethods.OpenDialog(5726); // "那张向来平静淡漠的孩子般的脸庞上，闪过了一丝极浅..."
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -42.0f}})});
        yield return _gameMethods.Show("tongdaozi_cg_layered", parts: new List<string>{"d_mei2", "d_yan1", "d_zui3"});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(5727); // "可我的神色毫无异常，依然温柔地看着他，仿佛这只是..."
        yield return _gameMethods.OpenDialog(5728); // "于是，他似乎也被这副表情所安抚了，脸上的愕然逐渐..."
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.7f, "<silence 0.5>audio/sound/he/shuai.mp3");
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.OpenDialog(5729); // "赫泽尔再也无法支撑站立，双膝扑通跪倒在地。"
        yield return _gameMethods.Scene("cg_wenroudao_ani");
        yield return _gameMethods.PlaySound("sounda2", 0.0f, 1.0f, "<from 0 to 1.5>audio/demo_audio/sound/flapping_wings_01.mp3");
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/manbu/strong_wind2_01.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -100.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.7f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 2.5f}, {"zpos", 0.0f}})});
        yield return _gameMethods.Show("2-39_zoom");
        yield return _gameMethods.Hide("2-39_zoom");
        yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/music/end/ran_theme_001.mp3");
        yield return _gameMethods.TransitionWithFadeIn(outTime:0.2f, holdTime:0.5f, inTime:1.2f, colorCode:"#fff");
        yield return _gameMethods.EngineSetVolume(volume:1.0f, delay:1.0f, channelName:"soundb");
        yield return _gameMethods.OpenDialog(5730); // "我随之缓缓屈膝、稳稳地接住他。"
        yield return _gameMethods.OpenDialog(5731); // "将手按在他胸前的伤口上，我俯视着他。"
        yield return _gameMethods.OpenDialog(5732); // "赫泽尔抬头仰望我。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}})});
        yield return _gameMethods.OpenDialog(5733); // "我柔和地看着他，开口。"
        yield return _gameMethods.Scene("wenroudao2_layered", parts: new List<string>{"h_mei1", "h_yan4", "h_zui2", "n_mei1", "n_zui4", "n_yan4"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.50f, 1.0f)}, {"zoom", 0.73f}})});
        yield return _gameMethods.Show("huacao", parts: new List<string>{"idle"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.61f, 1.7f)}, {"xzoom", -1.0f}, {"yzoom", 1.0f}, {"zoom", 1.25f}, {"xrotate", 0.0f}, {"zrotate", 12.0f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Show("2-40_zoom");
        yield return _gameMethods.Hide("2-40_zoom");
        yield return _gameMethods.PlaySound("sound", 0.2f, 0.4f, "audio/demo_audio/sound/moca2.mp3");
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(5734); // "我只是让你暂时失去了力气。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_yan3", "n_zui3"});
        yield return _gameMethods.OpenDialog(47); // "……！"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"n_zui4", "n_yan2"});
        yield return _gameMethods.OpenDialog(5735); // "现在，听我说。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"n_mei3", "n_yan5"});
        yield return _gameMethods.OpenDialog(5736); // "如果打败了勇者，你打算怎么对我？"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_zui3", "n_zui3"});
        yield return _gameMethods.OpenDialog(2153); // "……不。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_zui2", "n_zui4"});
        yield return _gameMethods.OpenDialog(5738); // "你早就已经不打算夺走我的未来了，对么？"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"n_zui3"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"n_zui4"});
        yield return _gameMethods.OpenDialog(5739); // "是什么时候改变想法的。"
        yield return _gameMethods.OpenDialog(5740); // "为什么不告诉我？"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_mei4", "h_yan9", "h_zui3", "n_zui3"});
        yield return _gameMethods.OpenDialog(5741); // "………………现在，你是不是要去他那边了。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_zui2", "n_zui4", "n_yan4"});
        yield return _gameMethods.OpenDialog(5742); // "…嗯？为什么突然说这个。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_zui3", "h_yan5", "n_zui3"});
        yield return _gameMethods.OpenDialog(5743); // "我和你之间，原本的联系已经没有了。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_mei3", "h_yan5"});
        yield return _gameMethods.OpenDialog(5744); // "你已经没有再爱上我的必要了。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_zui2", "n_zui5", "n_yan2"});
        yield return _gameMethods.OpenDialog(5745); // "和这些有什么关系？我在问你的是——"
        yield return _gameMethods.OpenDialog(1926); // "………"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"n_zui3", "n_mei2", "n_yan3"});
        yield return _gameMethods.PlaySound("sound", 0.0f, 2.0f, "audio/sound/houhui/Win Bell 2_01.mp3");
        yield return _gameMethods.OpenDialog(5747); // "忽然间，他刚刚说的那句话掠过我的大脑。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_yan1", "h_mei4"});
        yield return _gameMethods.OpenDialog(5748); // "……………他一直以来不告诉我的原因，\n明明早已..."
        yield return _gameMethods.OpenDialog(5749); // "就是因为这个？"
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"n_zui4", "n_mei1", "n_yan4"});
        Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.OpenDialog(5750); // "我不会。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_mei4", "h_yan4", "h_zui3", "n_zui3"});
        yield return _gameMethods.OpenDialog(5751); // "你很快就会遇到其他龙，"
        yield return _gameMethods.OpenDialog(5752); // "我的兄弟们，还有博尔吉亚。"
        yield return _gameMethods.OpenDialog(5753); // "他们比我更懂得讨取人类欢心。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_yan5"});
        yield return _gameMethods.OpenDialog(5754); // "你很快就会去爱他们的。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_zui2", "n_zui4", "n_yan5"});
        Defaults.Haogandu_he = Defaults.Haogandu_he + 2;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.OpenDialog(5755); // "不，我只爱你。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_mei5", "h_yan9", "h_zui3", "n_zui3"});
        yield return _gameMethods.OpenDialog(5756); // "……你只是现在这么说而已。"
        yield return _gameMethods.OpenDialog(5757); // "如果你一开始遇到的是他们，你从一开始不会接近我。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_zui2", "n_zui4", "n_mei3"});
        Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.OpenDialog(5758); // "我会的。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_zui3", "n_zui3"});
        yield return _gameMethods.OpenDialog(5759); // "怎么接近？"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_yan6"});
        yield return _gameMethods.OpenDialog(5760); // "假使没有原先的纽带，你根本就不会遇见我。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_zui2", "n_zui1", "n_mei2", "n_yan2"});
        yield return _gameMethods.OpenDialog(5761); // "嗯……这样可以吗。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"n_yan4"});
        yield return _gameMethods.OpenDialog(5762); // "我生活在王都，三年前，你过来带走真正的公主，"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"n_zui1"});
        Defaults.Haogandu_he = Defaults.Haogandu_he + 3;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.OpenDialog(5763); // "离开时，我看到了天空中的你，觉得你好酷好帅，一见..."
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"n_yan1"});
        yield return _gameMethods.OpenDialog(5764); // "然后，因为我是在面包坊工作，为了打响店铺的名气，..."
        Defaults.Haogandu_he = Defaults.Haogandu_he + 2;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.OpenDialog(5765); // "一路来到了城堡，见到了你。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_yan3", "n_zui4", "n_yan4"});
        yield return _gameMethods.OpenDialog(5766); // "你会夺走我的未来吗？"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_zui3", "n_zui3"});
        yield return _gameMethods.OpenDialog(5767); // "……不会。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_yan4", "n_zui2"});
        yield return _gameMethods.OpenDialog(5768); // "只要你没表现出明显的威胁。我不喜欢进行没有必要的..."
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_zui2", "n_zui1", "n_yan3"});
        yield return _gameMethods.OpenDialog(5769); // "那就好啦。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"n_zui4"});
        yield return _gameMethods.OpenDialog(5770); // "不过，如果你在我面前打败勇者，夺走公主的未来，我..."
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_zui3", "h_mei2", "h_yan4", "n_zui3"});
        yield return _gameMethods.OpenDialog(5771); // "我可以不对他们出手。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_zui2", "n_zui1"});
        yield return _gameMethods.OpenDialog(5772); // "那我们就化敌为友，渐渐熟悉了。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"n_yan4"});
        yield return _gameMethods.OpenDialog(5773); // "在相处中，我逐渐发现你是一个聪慧、理智，有礼貌的..."
        Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.OpenDialog(5774); // "并且，非常可爱。"
        Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.OpenDialog(5775); // "所以，渐渐喜欢上了你。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_zui3", "n_zui2"});
        yield return _gameMethods.OpenDialog(3949); // "然后呢？"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_zui2", "n_zui1", "n_mei2", "n_yan6"});
        yield return _gameMethods.OpenDialog(5777); // "然后，就要看你的表现了。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"n_yan4"});
        yield return _gameMethods.OpenDialog(5778); // "你会和我一起做什么呢。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"n_zui2"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_mei2", "h_zui3"});
        yield return _gameMethods.OpenDialog(5779); // "我会和你一起读书。我可以教你真言，还可以听你讲解..."
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_zui2", "n_zui3", "n_mei1", "n_yan6"});
        yield return _gameMethods.OpenDialog(5780); // "能不能听点好的。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"n_zui1", "n_yan5"});
        yield return _gameMethods.OpenDialog(5781); // "这很好呀。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_mei2", "h_yan3", "h_zui3", "n_zui2"});
        yield return _gameMethods.OpenDialog(5782); // "你会爱上我吗。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_zui2", "n_zui1", "n_yan1"});
        Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.OpenDialog(5783); // "会的。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_yan5", "h_zui3", "n_zui2"});
        yield return _gameMethods.OpenDialog(5784); // "这只是你的假设。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_zui2", "n_zui4", "n_yan4"});
        Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.OpenDialog(5785); // "是事实和经验，因为，现在的我就爱上你了。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_mei2", "h_zui3", "n_zui2"});
        yield return _gameMethods.OpenDialog(5786); // "……。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_zui2", "n_zui1"});
        yield return _gameMethods.OpenDialog(5787); // "不管怎么相遇，我都会爱上你的，因为，你就是我喜欢..."
        Defaults.Haogandu_he = Defaults.Haogandu_he + 3;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.OpenDialog(5788); // "从第一次见面我就说了，像你这么又可爱又温柔的龙，..."
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_zui3", "n_zui2", "h_yan8"});
        yield return _gameMethods.OpenDialog(5789); // "我的母亲不喜欢我。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_zui2", "n_zui4", "n_mei3"});
        Defaults.Haogandu_he = Defaults.Haogandu_he + 2;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.OpenDialog(5790); // "恕我冒犯，她没什么品位。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"n_zui3"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"shou", "h_mei1", "h_yan3", "h_zui2"});
        yield return _gameMethods.PlaySound("sound", 0.2f, 0.4f, "audio/demo_audio/sound/moca2.mp3");
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.5f, "<silence 0.5>audio/sound/houhui/Grab Hand_01.mp3");
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(5791); // "我捧住了他的脸颊。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"n_zui4"});
        yield return _gameMethods.OpenDialog(5792); // "赫泽尔，听我说。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_yan4", "n_zui3"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"n_zui4"});
        yield return _gameMethods.OpenDialog(5793); // "如果我不制止你，你最后一定会控制不住地击败勇者对..."
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_yan9", "n_zui3"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.OpenDialog(5794); // "他看向别处，回避了我的视线。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"n_zui4"});
        yield return _gameMethods.OpenDialog(5795); // "如果我在此没有彻底制服你，你一定会对人类出手，重..."
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_zui3", "n_zui3"});
        yield return _gameMethods.OpenDialog(2605); // "……唔。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_zui2", "n_zui4", "n_mei1", "n_yan5"});
        yield return _gameMethods.OpenDialog(5797); // "面对那么多糟糕的可能，我却不愿彻底制服你。"
        yield return _gameMethods.OpenDialog(5798); // "……你看。"
        Defaults.Haogandu_he = Defaults.Haogandu_he + 2;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.OpenDialog(5799); // "这还不足以证明我对你的爱吗？"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_mei2", "h_yan5", "h_zui3", "n_zui2"});
        yield return _gameMethods.OpenDialog(5800); // "…………嗯。"
        yield return _gameMethods.OpenDialog(5801); // "你爱我。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_zui2", "n_zui1"});
        yield return _gameMethods.OpenDialog(5802); // "现在相信了吗？"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_zui3", "h_yan4", "n_zui2"});
        yield return _gameMethods.OpenDialog(5803); // "这从逻辑上是成立的。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_zui2"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"n_yan2"});
        yield return _gameMethods.OpenDialog(5804); // "但从情感上无法相信，是吗。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"n_zui4"});
        yield return _gameMethods.OpenDialog(5805); // "唉……你真是不明白啊。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_zui3", "n_zui3"});
        yield return _gameMethods.OpenDialog(5806); // "…………不行么。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_zui2", "n_zui1"});
        Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.OpenDialog(5807); // "当然，可以。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"n_zui2"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"n_zui1", "n_mei2"});
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:7.0f);
        yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:5.0f);
        yield return _gameMethods.OpenDialog(5808); // "那就交给我吧，赫泽尔。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_mei2", "h_yan3", "h_zui2", "n_zui2", "n_mei2", "n_yan3"});
        yield return _gameMethods.OpenDialog(5809); // "我望进他的眼底，同他紧紧对视。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"n_zui1"});
        Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.OpenDialog(5810); // "你不会的事情，我来教你，\n你不懂的爱，我告诉你..."
        yield return _gameMethods.Show("feather_ani", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xzoom", -1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 4.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.3f}, {"alpha", 0.0f}})});
        yield return _gameMethods.PlaySound("sounda2", 0.0f, 1.0f, "<from 0 to 1.5>audio/demo_audio/sound/flapping_wings_01.mp3");
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/manbu/strong_wind2_01.mp3");
        yield return _gameMethods.PlaySound("music2", 4.0f, 1.0f, "audio/music/end/PerituneMaterial_Endless_Woods.mp3");
        yield return _gameMethods.OpenDialog(5811); // "所以，把一切都托付给我吧。"
        Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.OpenDialog(5812); // "我来了解你。\n我来理解你。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_mei1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv2_qian");
        yield return _gameMethods.OpenDialog(5813); // "「无条件地接纳你。"
        yield return _gameMethods.OpenDialog(5814); // "\n没理由地相信你。"
        Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.OpenDialog(5815); // "\n无止境地陪伴你。」"
        yield return _gameMethods.Hide("feather_ani");
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"n_zui4", "n_yan5"});
        yield return _gameMethods.ExecuteCharacterImageData("nv2_qian");
        yield return _gameMethods.OpenDialog(5816); // "「……嗯，在我的寿命范围内。"
        Defaults.Haogandu_he = Defaults.Haogandu_he + 3;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"n_zui1", "n_yan3"});
        yield return _gameMethods.OpenDialog(5817); // "\n——我将永远爱你。」"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"n_zui2"});
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.OpenDialog(5818); // "他沉默了许久。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_yan4"});
        yield return _gameMethods.OpenDialog(5819); // "最后，垂着眼睛，"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_zui1"});
        yield return _gameMethods.OpenDialog(5820); // "轻轻地点了下头。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_zui4", "h_yan4"});
        yield return _gameMethods.OpenDialog(1841); // "……好。"
        yield return _gameMethods.Show("wenroudao2_layered");
        yield return _gameMethods.OpenDialog(5822); // "你会一直在我身边？"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_zui1"});
        yield return _gameMethods.OpenDialog(765); // "嗯。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_zui3", "h_mei1"});
        yield return _gameMethods.OpenDialog(5824); // "不会去别人那里？"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_zui2"});
        yield return _gameMethods.OpenDialog(765); // "嗯。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_zui3"});
        yield return _gameMethods.OpenDialog(5825); // "不会离开我。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_zui2"});
        yield return _gameMethods.OpenDialog(765); // "嗯。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"n_zui4"});
        yield return _gameMethods.OpenDialog(5826); // "——啊，不过，如果要一辈子在没人的地方隐居，那的..."
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"n_yan4"});
        yield return _gameMethods.OpenDialog(5827); // "我偶尔也想出去逛街，玩一玩的。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_zui3", "h_mei2", "h_yan3", "n_zui3"});
        yield return _gameMethods.OpenDialog(5828); // "我可以在人类的城镇生存。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_zui2", "n_zui4"});
        yield return _gameMethods.OpenDialog(5829); // "……那在逛街时，我能和店主聊聊天，讲几句家常么？"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_zui3", "h_mei3", "h_yan8", "n_zui3"});
        yield return _gameMethods.OpenDialog(5830); // "……只要在我身边，可以。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_zui2", "n_yan5"});
        yield return _gameMethods.OpenDialog(5831); // "我不禁倒吸一口冷气。"
        yield return _gameMethods.OpenDialog(5832); // "他突然变得善解人意了好多。让我都有点不习惯了。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_yan4", "n_zui1", "n_yan3", "n_mei1"});
        yield return _gameMethods.OpenDialog(5833); // "那不已经完美了么？"
        Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.OpenDialog(5834); // "我们简直是天造地设的一对啊。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_zui3", "h_yan3", "n_zui2"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_zui2", "n_zui1"});
        yield return _gameMethods.OpenDialog(5835); // "我们可以一起做很多事……"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"n_zui4"});
        yield return _gameMethods.OpenDialog(5836); // "嗯，对了。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"n_yan2"});
        yield return _gameMethods.OpenDialog(5837); // "既然有你在，我就可以不用看国王的脸色了。"
        yield return _gameMethods.OpenDialog(5838); // "还有以前欺负过我的人，我都能找他们讨回公道。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_zui3", "h_yan4", "n_zui2"});
        yield return _gameMethods.OpenDialog(5839); // "可以。你想怎么处理他们？"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_zui2", "n_zui3", "n_yan4"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"emoji", "n_mei3", "n_zui2", "n_yan2"});
        yield return _gameMethods.OpenDialog(5840); // "这么毫不犹豫就让我仗势欺人真的好吗。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"n_zui4", "-emoji", "n_zui4", "n_yan4"});
        yield return _gameMethods.OpenDialog(5841); // "不过……不彻底制服我真的没问题么。"
        yield return _gameMethods.OpenDialog(5842); // "倘若违背了预言，放弃向人类散布灾祸，你也要承受代..."
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_zui3", "n_zui3"});
        yield return _gameMethods.OpenDialog(765); // "嗯。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_zui2", "n_zui4"});
        yield return _gameMethods.OpenDialog(5843); // "代价是什么？"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_zui3", "h_yan4", "n_zui3"});
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end6_71f653a6.ogg");
        yield return _gameMethods.OpenDialog(5844); // "如果始终拒不履行义务，我会被判定丧失了拥有这一位..."
        yield return _gameMethods.OpenDialog(5845); // "接着，命运会重新寻找下一任灾厄之龙。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_zui2", "n_zui5", "n_yan3"});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -2.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 2.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0.0f}, {"parallel_1", true}})});
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/zhenjing_shuaidaoganjue.mp3");
        yield return _gameMethods.OpenDialog(5846); // "{size=+10}……这不是问题很大么？！？！..."
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"yoffset", 0.0f}})});
        yield return _gameMethods.OpenDialog(5847); // "怎么办，你还能活多久？！"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_zui3", "n_zui3"});
        yield return _gameMethods.OpenDialog(5848); // "一千年。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"h_zui2", "n_zui2", "emoji"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.OpenDialog(5849); // "我冷静了。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"n_yan2"});
        yield return _gameMethods.OpenDialog(5850); // "好吧。论寿命，我比他还短点。"
        yield return _gameMethods.OpenDialog(5851); // "他能赶上给我送终呢。"
        yield return _gameMethods.Show("wenroudao2_layered", parts: new List<string>{"n_mei3", "n_zui3", "n_yan4"});
        yield return _gameMethods.OpenDialog(5852); // "深刻地理解了什么叫“瘦死的骆驼比马大”。"
        yield return _gameMethods.OpenDialog(5853); // "以这些长生种的寿命，就算只从指缝里漏出一粒沙，也..."
        yield return _gameMethods.Scene("caodi2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(-0.13f, 1.38f)}, {"zoom", 1.31f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei18", "yan13", "zui12", "emoji2", "d1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 3.41f)}, {"zoom", 0.7f}})});
        Defaults.Gui_duihuakuang_you = 1;
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Transition(time:0.6f);
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"d3", "mei7", "yan24", "zui8", "emoji2"});
        yield return _gameMethods.OpenDialog(5854); // "……咳。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei18", "yan13", "zui3", "emoji2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(5855); // "赫泽尔忽然咳了几下。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei9", "yan23", "zui2", "emoji0", "emoji2", "d1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan2", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(5856); // "少年原本苍白的面色泛上不自然的红晕，{nw}{w..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei19", "yan25", "zui3", "-emoji0"});
        yield return _gameMethods.OpenDialog(5857); // "他皱了皱眉。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei18", "yan25", "zui9", "emoji2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(5858); // "你先离开。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei18", "yan25", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei3", "yan12", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan2", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(165); // "？"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei18", "yan13", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(5860); // "第二颗心脏开始跳动了。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan27", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(5861); // "我要……蜕皮进入成长期了。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan27", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan2", "zui10"});
        yield return _gameMethods.OpenDialog(5862); // "……啊，现在吗？"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan6", "zui15"});
        yield return _gameMethods.OpenDialog(5863); // "这么突然？"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(5864); // "我不能看么？"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(5865); // "说实话，有点好奇。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan25", "zui2"});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan3", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(249); // "可以。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(5867); // "不过，蜕完皮首次拟态成人类时，我没有余力。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(924); // "……？"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(5869); // "我需要一定时间恢复体力，才能拟现出人体外部的物品..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan10", "zui13", "emoji2"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.EngineSetVolume(volume:0.5f, delay:1.0f, channelName:"music2");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan10", "zui18", "emoji2"});
        yield return _gameMethods.OpenDialog(5870); // "就是说，你们龙在第一次变人时没有衣服么。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.6f, "<from 0 to 0.5>audio/sound/emeng_dajie/walking_on_the_earth_01.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.51f}, {"zpos", 24.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan24", "zui19", "emoji2"});
        yield return _gameMethods.OpenDialog(5871); // "好，那我先走开了……"
        yield return _gameMethods.PlaySound("sounda", 0.0f, 0.4f, "audio/sound/moca1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -8.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 8.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0.0f}, {"parallel_1", true}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei4", "yan5", "zui2", "emoji2"});
        yield return _gameMethods.OpenDialog(5872); // "……记得把衣服穿上再过来啊！！要注意礼节！"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan4", "zui2"});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"yoffset", 0.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei4", "yan5", "zui8", "emoji2", "d3"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan6", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan24", "zui7", "emoji2"});
        yield return _gameMethods.OpenDialog(5873); // "他是不是给了我一个白眼？"
        yield return _gameMethods.StopSound(channelName:"music2", fadeOut:8.0f);
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Transition(time:0.6f);
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.PlaySound("soundb", 0.0f, 1.0f, "audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
        yield return _gameMethods.Scene("caodi2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.2f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 1.0f}})});
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.OpenDialog(5874); // "我走向一旁，和安德鲁与洛恩汇合。"
        yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:1.0f);
        yield return _gameMethods.OpenDialog(5875); // "他们大概发现了我这边有情况，担心打扰了我的计划，..."
        yield return _gameMethods.OpenDialog(5876); // "我很感谢这一点，因为如果缺乏两人之间坦诚交流的私..."
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei4", "yan1", "zui1", "emoji2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(384.0f, 1704.0f)}, {"zoom", 0.4f}, {"anchor", new Vector2(0.5f, 1.0f)}})});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei8", "yan4", "zui3", "emoji8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(924.0f, 1818.0f)}, {"zoom", 0.42f}, {"anchor", new Vector2(0.5f, 1.0f)}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(5877); // "此刻，见我走向他们，那两人便匆匆赶来。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.6f, "<from 0 to 1>audio/sound/emeng_dajie/walking_on_the_earth_01.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.60f}, {"xpos", 126.0f}})});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan2", "zui3", "emoji8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 924.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.60f}, {"xpos", 834.0f}})});
        Engine._history = false;
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei3", "yan2", "zui1"});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan8", "zui3", "emoji8"});
        yield return _gameMethods.OpenDialog(5878); // "安德鲁快步来到我面前，先抓着我的肩膀，皱着眉把我..."
        yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/music/end/bai_jieju1.mp3");
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan2", "zui8", "emoji8"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan12", "zui3"});
        yield return _gameMethods.OpenDialog(5879); // "发现我身上没有伤口后，才松了口气，{nw}{w=..."
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei3", "yan8", "zui1", "-emoji8"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan5", "zui3"});
        yield return _gameMethods.OpenDialog(5880); // "放开我。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei3", "yan8", "zui8"});
        yield return _gameMethods.OpenDialog(5881); // "你和他说了什么？"
        yield return _gameMethods.OpenDialog(5882); // "他不再打算夺走你的未来了吧？"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei3", "yan8", "zui3"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10", "d3"});
        yield return _gameMethods.OpenDialog(5883); // "嗯，我搞定他了。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 126.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.80f}, {"xpos", 0.0f}})});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan5", "zui4"});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei4", "yan3", "zui10"});
        yield return _gameMethods.ExecuteCharacterImageData("luo_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(5884); // "看来，你现在似乎已经不需要我们了。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei4", "yan12", "zui16"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan5", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(5885); // "怎么这么说？如果没有你们我可做不到这些。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei4", "yan8", "zui16"});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}})});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan8", "zui8"});
        Defaults.Haogandu_an = Defaults.Haogandu_an + 1;
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(5886); // "见到你们真好。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei3", "yan17", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
        yield return _gameMethods.OpenDialog(5887); // "哼，肉麻。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei3", "yan17", "zui16"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_weizhi");
        yield return _gameMethods.OpenDialog(5888); // "哦——所以……"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"xpos", -222.0f}})});
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui13"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-264.0f, 1841.0f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.55f}, {"alpha", 0.0f}, {"blur", 0.1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.3f}, {"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan4", "zui1"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan2", "zui1"});
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/emeng_dajie/magic1.ogg");
        yield return _gameMethods.OpenDialog(5889); // "你也不再需要我了么？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan5", "zui1"});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan9", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", -222.0f}})});
        yield return _gameMethods.Show("nuo1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan10", "zui19", "emoji2"});
        yield return _gameMethods.OpenDialog(5890); // "你来得可真及时。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan9", "zui8"});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan10", "zui7", "-emoji2"});
        yield return _gameMethods.OpenDialog(5891); // "他面不改色，假装没听懂我的反话。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui13"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan12", "zui1"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan5", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(5892); // "可惜还是晚了一步。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan13", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(5893); // "不过，这也让我看到了小公主如此耀眼的一面呢。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui14"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan8", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(5894); // "真是令人心动。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei2", "yan8", "zui3"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan24", "zui19"});
        yield return _gameMethods.OpenDialog(5895); // "哈哈。哈哈。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.7f, "audio/sound/moca1.ogg");
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan21", "zui6"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"xoffset", -3.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 3.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0.0f}, {"parallel_1", true}})});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei7", "yan24", "zui7"});
        yield return _gameMethods.OpenDialog(5896); // "……这人谁啊？"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan21", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"yoffset", 0.0f}})});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan12", "zui4"});
        yield return _gameMethods.OpenDialog(5897); // "不清楚。"
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan5", "zui1"});
        yield return _gameMethods.OpenDialog(5898); // "洛恩看我。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui8"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("luo_qian");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan11", "zui12"});
        yield return _gameMethods.OpenDialog(5899); // "不介绍一下么？"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui1"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei8", "yan5", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10"});
        yield return _gameMethods.OpenDialog(5900); // "这位是冰霜与心灵之龙，诺伯拉·博尔吉亚。"
        if (Defaults.Bai_xue == 1)
        {
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei8", "yan6", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui19"});
            yield return _gameMethods.OpenDialog(5901); // "「我请他来帮点忙，{nw}{w=0.01}"
            yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan24", "zui19"});
            yield return _gameMethods.OpenDialog(5902); // "虽然也没用上。{nw}{w=0.01}"
            yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan24", "zui8"});
            yield return _gameMethods.OpenDialog(4883); // "」"
        }
        if (Defaults.Bai_kiss == 1)
        {
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei8", "yan6", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui19"});
            yield return _gameMethods.OpenDialog(5904); // "「我们算是有过合作。{nw}{w=0.01}"
            yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(4883); // "」"
        }
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui8"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei6", "yan7", "zui5"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(5905); // "「好冷淡的介绍词，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui16"});
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(5906); // "我们难道不已经是接过——……」"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan13", "zui1"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei8", "yan3", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei6", "yan11", "zui2", "emoji2"});
        yield return _gameMethods.OpenDialog(5907); // "{size=+10}接过了彼此传递友谊的善意之手..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui12"});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan12", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei7", "yan11", "zui2", "emoji2"});
        yield return _gameMethods.OpenDialog(4400); // "「……{nw}{w=0.2}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei11", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei6", "yan11", "zui8"});
        yield return _gameMethods.OpenDialog(5909); // "扑哧。」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui3"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei5", "yan22", "zui8", "emoji2"});
        yield return _gameMethods.OpenDialog(5910); // "嗯~你说了算。"
        yield return _gameMethods.EngineSetVolume(volume:0.2f, delay:1.0f, channelName:"music");
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan21", "zui1"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei8", "yan9", "zui1"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan5", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan24", "zui16", "emoji2"});
        yield return _gameMethods.OpenDialog(5911); // "不知为何，感觉空气有点令人窒息……"
        yield return _gameMethods.EngineSetVolume(volume:1.0f, delay:1.0f, channelName:"music");
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui8"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan24", "zui16", "-emoji2"});
        yield return _gameMethods.OpenDialog(5912); // "最终，诺伯拉打破了沉默。"
        yield return _gameMethods.Hide("an2");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(-408.0f, 30.0f)}, {"zpos", 144.0f}})});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei8", "yan9", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"xpos", 510.0f}})});
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan12", "zui13"});
        yield return _gameMethods.TransitionBy("blink2");
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(5913); // "闻名不如见面。原来这两人，就是你说过的旧相识。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan12", "zui8"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei8", "yan2", "zui7"});
        yield return _gameMethods.ExecuteCharacterImageData("luo_nv", parts: new List<string>{"mei8", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(5914); // "“闻名不如见面？”"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui14"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei8", "yan2", "zui1"});
        Defaults.Haogandu_an = Defaults.Haogandu_an + 1;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(5915); // "是啊。我听她提起过你们。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei8", "yan6", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei8", "yan6", "zui15"});
        yield return _gameMethods.OpenDialog(5916); // "这两年里，我们二人几乎日日彼此相伴。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei6", "yan22", "zui10", "emoji2"});
        yield return _gameMethods.OpenDialog(5917); // "诺伯拉笑意盎然，白色的眼睫毛弯成了月牙。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(5918); // "「所以，公主殿下已经把她所有的事都告诉我了，{n..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui16"});
        yield return _gameMethods.OpenDialog(5919); // "当然也包括你们。」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui8"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei4", "yan9", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan20", "zui15", "emoji2", "emoji12"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(5920); // "我不禁开始沉思。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan18", "zui15", "emoji2", "emoji12"});
        yield return _gameMethods.OpenDialog(5921); // "哪里来的两年？"
        if (Defaults.Bai_xue == 1)
        {
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(5922); // "如果从第一次见面就开始算起，倒是有两年，可我们真..."
        }
        yield return _gameMethods.PlaySound("sound", 0.0f, 2.0f, "audio/sound/manbu/Body1_02_duan.mp3");
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui14"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.39f}, {"zpos", 30.0f}})});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei4", "yan12", "zui1"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei4", "yan9", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei3", "yan18", "zui15", "-emoji2", "-emoji12"});
        yield return _gameMethods.OpenDialog(5923); // "对么，小公主？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 30.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(5924); // "诺伯拉忽然转头，笑眯眯地看着我。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei1", "yan11", "zui8"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(5925); // "我礼貌地微笑，{nw}{w=0.2}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei8", "yan24", "zui16"});
        yield return _gameMethods.OpenDialog(5926); // "随即转头看起了风景。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui16", "emoji2"});
        yield return _gameMethods.OpenDialog(5927); // "很识相，怕他报复，还是别拆台了。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei11", "yan2", "zui8"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("luo_nv_qian");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei6", "yan11", "zui8"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei8", "yan11", "zui12"});
        yield return _gameMethods.ExecuteCharacterImageData("luo_nv");
        yield return _gameMethods.OpenDialog(5928); // "哦——……两年啊。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan8", "zui8"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei8", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan8", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(5929); // "洛恩微微一笑，并未多说什么，但脸上那礼貌而矜持的..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui8"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei8", "yan6", "zui15"});
        yield return _gameMethods.ExecuteCharacterImageData("luo_nv");
        yield return _gameMethods.OpenDialog(5930); // "只有两年的话……"
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei3", "yan9", "zui15"});
        yield return _gameMethods.ExecuteCharacterImageData("luo_nv");
        yield return _gameMethods.OpenDialog(5931); // "讲得完我们之间八年的故事么？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei4", "yan12", "zui12"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei3", "yan9", "zui8"});
        yield return _gameMethods.EngineSetVolume(volume:0.2f, delay:1.0f, channelName:"music");
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei8", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan7", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(5932); // "不知为何，洛恩和诺伯拉都不再说话，"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei4", "yan2", "zui8"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei8", "yan11", "zui10"});
        yield return _gameMethods.OpenDialog(5933); // "\n双方微笑对视，场面陷入沉静。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan10", "zui18", "emoji2"});
        yield return _gameMethods.OpenDialog(5934); // "……总感觉空气有点令人窒息……"
        yield return _gameMethods.EngineSetVolume(volume:1.0f, delay:1.0f, channelName:"music");
        yield return _gameMethods.Show("caodi2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(-0.71f, 1.35f)}, {"zoom", 1.32f}})});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei5", "yan16", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(198.0f, 2142.0f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.5f}})});
        yield return _gameMethods.Hide("luo2");
        yield return _gameMethods.Hide("nuo1");
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/manbu/Body1_01.mp3");
        yield return _gameMethods.TransitionBy("blink2");
        yield return _gameMethods.OpenDialog(5935); // "安德鲁扯了扯我。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei8", "yan16", "zui12", "emoji8"});
        yield return _gameMethods.OpenDialog(5936); // "你怎么老能招惹来莫名其妙的东西啊……？！"
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(1378); // "「……{nw}{w=0.3}"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei8", "yan16", "zui16", "emoji8"});
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan12", "zui18", "emoji2"});
        yield return _gameMethods.OpenDialog(1265); // "……」"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan12", "zui19", "emoji2"});
        yield return _gameMethods.OpenDialog(5938); // "可能因为我是个好人吧，好人有好报。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan8", "zui1", "-emoji8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan5", "zui2", "emoji2"});
        yield return _gameMethods.OpenDialog(5939); // "你看，朋友就变多了。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui19", "-emoji2"});
        yield return _gameMethods.OpenDialog(5940); // "谢谢你，来救我。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan21", "zui4", "emoji20"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
        yield return _gameMethods.OpenDialog(5941); // "顺路而已。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan21", "zui1", "emoji20"});
        Defaults.Haogandu_an = Defaults.Haogandu_an + 1;
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan10", "zui2"});
        yield return _gameMethods.OpenDialog(5942); // "真的吗？顺路报名了勇者，还千里迢迢地跑到这里来？"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan8", "zui8", "emoji20"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian", parts: new List<string>{"mei8", "yan10", "zui8"});
        yield return _gameMethods.OpenDialog(5943); // "「那……是我有责任心！{nw}{w=0.01}"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan2", "zui12", "emoji8", "emoji20"});
        yield return _gameMethods.OpenDialog(5944); // "拯救公主，人人有责懂吗。」"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan2", "zui10", "emoji8", "emoji20"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(5945); // "「好，我信了。"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei8", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(5946); // "骗朋友可以，朋友被骗骗没什么，{nw}{w=0...."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei8", "yan22", "zui19"});
        yield return _gameMethods.OpenDialog(5947); // "别把自己也骗进去了就行。」"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan1", "zui1", "emoji2", "-emoji8", "emoji20"});
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.6f, "audio/sound/moca1.ogg");
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan3", "zui12", "emoji2", "emoji20"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"xoffset", -3.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 3.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0.0f}, {"parallel_1", true}})});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei8", "yan22", "zui8"});
        yield return _gameMethods.OpenDialog(5948); // "……滚！！"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan3", "zui10", "emoji2", "emoji20"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"yoffset", 0.0f}})});
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:2.0f);
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0.5 to 1.5>audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
        if (Defaults.Persistent.Povname == "辛西娅")
        {
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv_qian");
            yield return _gameMethods.OpenDialog(5949); // "「辛西娅。」"
        }
        else
        {
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv_qian");
            yield return _gameMethods.OpenDialog(5950); // "「[persistent.povname]。」"
        }
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.PlaySound("sounda1", 0.0f, 1.5f, "audio/sound/emeng_dajie/Swing Whoosh_01.mp3");
        yield return _gameMethods.Scene("caodi2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(-0.65f, 1.35f)}, {"zoom", 1.32f}})});
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan5", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(300.0f, 2124.0f)}, {"zoom", 0.48f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 200.0f}, {"zpos", 66.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.3f}, {"xoffset", 0.0f}})});
        yield return _gameMethods.Transition(time:0.2f);
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"d3"});
        yield return _gameMethods.OpenDialog(226); // "{nw}{w=0.2}"
        Engine._history = true;
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -8.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 8.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0.0f}, {"parallel_1", true}})});
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/demo_audio/sound/zhenjing_shuaidaoganjue.mp3");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan22", "zui13", "emoji2", "emoji5", "emoji6", "d3"});
        yield return _gameMethods.OpenDialog(5952); // "{size=+10}你谁啊。{/size}"
        yield return _gameMethods.PlaySound("music1", 0.0f, 1.0f, "audio/music/bing_richang1.mp3");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan1", "zui8", "emoji2", "emoji3", "emoji5", "emoji6"});
        yield return _gameMethods.OpenDialog(5953); // "一瞬间变那么大只。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.3f, "<from 0 to 1>audio/sound/emeng_dajie/walking_on_the_earth_01.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"yoffset", 0.0f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 1.0f}, {"zpos", 144.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan24", "zui16", "emoji2", "emoji6", "-emoji3", "-emoji5"});
        yield return _gameMethods.OpenDialog(5954); // "我默默往后移了两步。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan17", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(5955); // "为什么你离我那么远。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 144.0f}})});
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan17", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan24", "zui2", "emoji2", "emoji6"});
        yield return _gameMethods.OpenDialog(5956); // "不太适应。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui8", "emoji2", "emoji6"});
        yield return _gameMethods.OpenDialog(5957); // "有种受到威胁的感觉。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan9", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei3", "yan8", "zui8", "emoji2", "-emoji6"});
        yield return _gameMethods.OpenDialog(4400); // "「……{nw}{w=0.2}"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan14", "zui3"});
        yield return _gameMethods.OpenDialog(1265); // "……」"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan1", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(5958); // "我是赫泽尔。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan5", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan12", "zui2", "emoji2"});
        yield return _gameMethods.OpenDialog(4869); // "我知道。"
        yield return _gameMethods.OpenSelectMenu(
            talk: new List<string>{"—你这样挺好的", "—你还能变回去吗"},
            jump: new List<string>{"label_end7_menu_0_y1ZJZYKK", "label_end7_menu_0__WPL6L3_"},
            condition: new List<string>{"NONE", "NONE"}
        );
    }

    public IEnumerator label_end6_2()
    {
        yield return _gameMethods.OpenSelectMenu(
            talk: new List<string>{"—你也很像个人", "—你也一表人才"},
            jump: new List<string>{"label_end7_menu_1_ERN73FYC", "label_end7_menu_1_4MWVlgt_"},
            condition: new List<string>{"NONE", "NONE"}
        );
    }

    public IEnumerator label_end6_1()
    {
        yield return _gameMethods.Scene("caodi2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.05f)}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.TransitionBy("blink2");
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan12", "zui19", "emoji2", "d3"});
        yield return _gameMethods.OpenDialog(5990); // "好了，好了。"
        yield return _gameMethods.StopSound(channelName:"music1", fadeOut:5.0f);
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19", "emoji2"});
        yield return _gameMethods.OpenDialog(5991); // "那个，现在我们来讨论一下正经事……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(5992); // "要先帮安德鲁解除诅咒。"
        yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/music/yongzhe_wenxin1.mp3");
        yield return _gameMethods.OpenDialog(33); // "………………"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(5993); // "我把安德鲁身上的情况简单说了一下，试图群策群力。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan5", "zui6"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.5f}, {"pos", new Vector2(744.0f, 2232.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}, {"blur", 0.1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.3f}, {"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.OpenDialog(5994); // "妖精商人么。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei1", "yan10", "zui6"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("he_qian");
        yield return _gameMethods.OpenDialog(5995); // "「我了解这个种族，{nw}{w=0.01}"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei1", "yan1", "zui6"});
        yield return _gameMethods.OpenDialog(5996); // "他们性情狡诈，从不会吃亏。」"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei1", "yan10", "zui1"});
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<from 0.5 to 1>audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.5f, "audio/sound/manbu/Body1_02_duan.mp3");
        yield return _gameMethods.Hide("heo");
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui16"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(384.0f, 1536.0f)}, {"zoom", 0.45f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 200.0f}, {"zpos", 30.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.3f}, {"xoffset", 0.0f}, {"zpos", 0.0f}})});
        yield return _gameMethods.Transition(time:0.2f);
        yield return _gameMethods.OpenDialog(9619); // "总之，先把那个妖精叫出来吧。 "
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan21", "zui1", "emoji2", "emoji20"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(1056.0f, 1548.0f)}, {"zoom", 0.35f}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}, {"blur", 0.1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.2f}, {"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"xoffset", 0.0f}, {"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"xpos", 156.0f}})});
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan8", "zui8"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(5998); // "诺伯拉看向安德鲁。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan8", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(5999); // "你们契约的内容是什么？"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei5", "yan4", "zui1", "-emoji20"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 156.0f}})});
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan8", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv");
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan23", "zui4"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
        yield return _gameMethods.OpenDialog(6000); // "「好像是……每当我感受到幸福，{nw}{w=0...."
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui4"});
        yield return _gameMethods.OpenDialog(6001); // "他就会出现一次，取走令我幸福的事物。」"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui1"});
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei3", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(6002); // "那你先做件能让自己快速感到幸福的事吧。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui8"});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan4", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
        yield return _gameMethods.OpenDialog(4400); // "「……{nw}{w=0.2}"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan17", "zui1"});
        yield return _gameMethods.OpenDialog(4502); // "……{nw}{w=0.2}"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei5", "yan16", "zui1", "emoji20"});
        yield return _gameMethods.OpenDialog(1265); // "……」"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan23", "zui2", "emoji20"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(6004); // "安德鲁的视线游移，"
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.6f, "<from 0 to 1>audio/sound/emeng_dajie/walking_on_the_earth_01.mp3");
        yield return _gameMethods.Show("an2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(1056.0f, 1548.0f)}, {"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.88f}, {"pos", new Vector2(918.0f, 1548.0f)}, {"zpos", 144.0f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 156.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.9f}, {"xpos", 198.0f}})});
        yield return _gameMethods.OpenDialog(6005); // "上前凑近了我。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan12", "zui3", "emoji20"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(6006); // "似乎鼓起了莫大的勇气一般，他的视线落在我的脸上。"
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:0.5f);
        yield return _gameMethods.PlaySound("sound", 0.0f, 2.0f, "audio/sound/he/liekai.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 198.0f}})});
        yield return _gameMethods.Show("an2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(918.0f, 1548.0f)}, {"zpos", 144.0f}})});
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei2", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(6007); // "不知为何，诺伯拉唇边常年挂着的云淡风轻的微笑忽然..."
        yield return _gameMethods.Scene("qq1_1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.0f)}, {"zoom", 0.67f}})});
        Defaults.Gui_duihuakuang_you = 0;
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -36.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Show("qq1_2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 0.5f)}, {"zoom", 0.67f}, {"pos", new Vector2(444.0f, 96.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.8f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.2f}, {"alpha", 1.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.22f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.23f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.26f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.26f}, {"parallel_1", true}})});
        yield return _gameMethods.TransitionWithFadeIn(outTime:0.2f, holdTime:0.1f, inTime:0.2f, colorCode:"#fff");
        yield return _gameMethods.Show("2-41_zoom");
        yield return _gameMethods.Hide("2-41_zoom");
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.6f, "audio/sound/he/kiss.mp3");
        yield return _gameMethods.OpenDialog(6008); // "接着，勇者微微俯身，用嘴唇在我的左脸颊上轻轻啄了..."
        yield return _gameMethods.Show("qq1_2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{})});
        yield return _gameMethods.OpenDialog(6009); // "轻如羽毛。宛若错觉。"
        yield return _gameMethods.PlaySound("music3", 0.0f, 1.0f, "audio/music/PerituneMaterial_Laid_Back2_loop.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"easein", 1.0f}, {"zpos", 0.0f}})});
        yield return _gameMethods.Show("qq1_3", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.67f}, {"anchor", new Vector2(0.0f, 1.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.2f}, {"alpha", 1.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-126.0f, 414.0f)}, {"zrotate", 36.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.60f}, {"pos", new Vector2(0.0f, 360.0f)}, {"zrotate", 0.0f}, {"parallel_1", true}})});
        yield return _gameMethods.Show("qq1_4", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.67f}, {"anchor", new Vector2(1.0f, 1.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.2f}, {"alpha", 1.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(1038.0f, -24.0f)}, {"zrotate", 12.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.80f}, {"pos", new Vector2(924.0f, 0.0f)}, {"zrotate", 0.0f}, {"parallel_1", true}})});
        yield return _gameMethods.Show("qq1_5", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.67f}, {"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.2f}, {"alpha", 1.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(1038.0f, 402.0f)}, {"zrotate", -18.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.60f}, {"pos", new Vector2(984.0f, 402.0f)}, {"zrotate", 0.0f}, {"parallel_1", true}})});
        yield return _gameMethods.OpenDialog(33); // "………………"
        yield return _gameMethods.Show("2-42_zoom");
        yield return _gameMethods.Hide("2-42_zoom");
        yield return _gameMethods.Scene("qq2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.67f}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(642.0f, 720.0f)}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.OpenDialog(9620); // "接着他立刻仰身，拉开距离。"
        yield return _gameMethods.Show("qq2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.82f}, {"xpos", 702.0f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.ExecuteCharacterImageData("an_qian");
        yield return _gameMethods.OpenDialog(9621); // "「友情之吻啊！！别自作多——……{nw}{w=0..."
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/juezhan_dao/Black Magic_01.ogg");
        yield return _gameMethods.Show("qq3", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.78f}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(542.0f, 720.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.3f}, {"alpha", 1.0f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.2f}, {"zpos", -18.0f}})});
        yield return _gameMethods.Show("2-43_zoom");
        yield return _gameMethods.Hide("2-43_zoom");
        yield return _gameMethods.OpenDialog(9622); // "哇啊！」"
        yield return _gameMethods.Show("qq3", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        yield return _gameMethods.OpenDialog(9623); // "话未说完，他便狼狈后撤，险险避开了一个黑色能量球..."
        yield return _gameMethods.Scene("qq4_1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.67f}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(642.0f, 720.0f)}})});
        yield return _gameMethods.Show("qq4_2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.67f}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 1.0f)}, {"pos", new Vector2(498.0f, 54.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.2f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.2f}, {"alpha", 1.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(498.0f, 54.0f)}, {"zrotate", 18.0f}, {"zoom", 0.5f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.2f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.2f}, {"pos", new Vector2(498.0f, 54.0f)}, {"zrotate", 0.0f}, {"zoom", 0.67f}, {"parallel_1", true}})});
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.2f, "<silence 0.2>audio/sound/he/hammer-hitting-a-head_01.mp3");
        yield return _gameMethods.PlaySound("sounda1", 0.0f, 4.0f, "audio/sound/manbu/Body1_02_duan.mp3");
        yield return _gameMethods.Show("2-44_zoom");
        yield return _gameMethods.Hide("2-44_zoom");
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.OpenDialog(9624); // "随即被诺伯拉痛殴头部，“嗷呜”一声抱住了脑袋，"
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/juezhan_dao/AXE DRAW draw _02.ogg");
        yield return _gameMethods.Show("qq4_2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}, {"pos", new Vector2(498.0f, 54.0f)}, {"zrotate", 0.0f}, {"zoom", 0.67f}})});
        yield return _gameMethods.OpenDialog(9625); // "就在他低头时，几道淡紫的叶刃正巧割过他的头顶，带..."
        yield return _gameMethods.Scene("caodi2");
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei10", "yan4", "zui12", "emoji8", "emoji21"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.46f}, {"pos", new Vector2(594.0f, 1986.0f)}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        Defaults.Gui_duihuakuang_you = 1;
        yield return _gameMethods.Transition(time:0.3f);
        yield return _gameMethods.OpenDialog(5087); // "？？？"
        yield return _gameMethods.Hide("an2");
        yield return _gameMethods.Show("caodi2");
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei2", "yan2", "zui14"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.5f}, {"pos", new Vector2(426.0f, 1674.0f)}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 200.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.2f}, {"xoffset", 0.0f}})});
        yield return _gameMethods.OpenDialog(9626); // "对不起，手痒~"
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei8", "yan11", "zui12"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(1134.0f, 1626.0f)}, {"zoom", 0.38f}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}, {"blur", 0.1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.2f}, {"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"xpos", 246.0f}})});
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei2", "yan11", "zui8"});
        yield return _gameMethods.OpenDialog(9627); // "抱歉，手滑。"
        yield return _gameMethods.Show("qq5", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(522.0f, 1110.0f)}, {"zoom", 1.07f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"alpha", 1.0f}})});
        Defaults.Gui_duihuakuang_you = 0;
        yield return _gameMethods.Show("2-45_zoom");
        yield return _gameMethods.Hide("2-45_zoom");
        yield return _gameMethods.PlaySound("sounda", 0.0f, 0.5f, "audio/sound/juezhan2/Magical Blast_01.ogg");
        yield return _gameMethods.OpenDialog(9628); // "但能请你不要骚扰我的员工吗。"
        yield return _gameMethods.OpenDialog(33); // "………………"
        yield return _gameMethods.PlaySound("soundb", 1.0f, 0.1f, "audio/sound/end/flashtrauma__electricity_01.ogg");
        yield return _gameMethods.Show("qq5", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        yield return _gameMethods.Show("qq5", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"xpos", 1266.0f}})});
        yield return _gameMethods.Transition(time:0.6f);
        yield return _gameMethods.OpenDialog(9629); // "赫泽尔面色冰冷。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.5f}, {"zpos", -42.0f}})});
        yield return _gameMethods.OpenDialog(9630); // "你该分清自己能做和不能做的事。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -42.0f}})});
        yield return _gameMethods.Show("qq5", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(888.0f, 714.0f)}, {"zoom", 0.66f}})});
        yield return _gameMethods.Transition(time:0.6f);
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -8.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 8.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0.0f}, {"parallel_1", true}})});
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/moca1.ogg");
        yield return _gameMethods.OpenDialog(9631); // "不是，再这样下去，没等妖精商人到来，我们就已经先..."
        yield return _gameMethods.Scene("caodi2");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"yoffset", 0.0f}})});
        Defaults.Gui_duihuakuang_you = 1;
        yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:2.0f);
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan22", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(9632); // "我麻木地擦汗，{nw}{w=0.01}"
        yield return _gameMethods.Show("npc_yaojingshangren", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(642.0f, 930.0f)}, {"zoom", 1.21f}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei8", "yan24", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(9633); // "突然发现不知何时，有一名青年已经蹲在我身侧，看热..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(9634); // "见被发现，他从容开口。"
        yield return _gameMethods.StopSound(channelName:"music3", fadeOut:6.0f);
        yield return _gameMethods.ExecuteCharacterImageData("yao_nv_weizhi");
        yield return _gameMethods.OpenDialog(9635); // "你好，公主大人。"
        yield return _gameMethods.ExecuteCharacterImageData("yao_nv_weizhi");
        yield return _gameMethods.OpenDialog(9636); // "我来的似乎不是时候？"
        yield return _gameMethods.Show("npc_yaojingshangren", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "<from 0 to 0.5>audio/sound/emeng_dajie/walking_on_the_earth_01.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.50f}, {"zpos", -24.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(9637); // "您就是和安德鲁签订协议的那名妖精商人？"
        yield return _gameMethods.ExecuteCharacterImageData("yao_nv", parts: new List<string>{"mei7", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(9638); // "这有点冒犯呢。"
        yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/music/yongzhe_kaixin.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -24.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("yao_nv");
        yield return _gameMethods.OpenDialog(9639); // "毕竟我是有名字的，如果我喊你“人类”， 公主大人..."
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui2"});
        yield return _gameMethods.OpenDialog(9640); // "那你希望我叫你什么呢。"
        yield return _gameMethods.ExecuteCharacterImageData("yao_nv", parts: new List<string>{"mei7", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(9641); // "昂戈。叫我昂戈。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.6f, "<from 0 to 0.5>audio/sound/emeng_dajie/walking_on_the_earth_01.mp3");
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan15", "zui6"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(1122.0f, 1770.0f)}, {"zpos", 24.0f}, {"zoom", 0.39f}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}, {"blur", 0.1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.2f}, {"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"xpos", 210.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(9642); // "你该搭话的对象是我们。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan15", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 210.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("yao_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(9643); // "啊，无意冒犯。"
        yield return _gameMethods.ExecuteCharacterImageData("yao_nv");
        yield return _gameMethods.OpenDialog(9644); // "只是按照协约，公主大人方才已经成了我的战利品。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei7", "yan7", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
        yield return _gameMethods.OpenDialog(4400); // "「……{nw}{w=0.2}"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan1", "zui6"});
        yield return _gameMethods.OpenDialog(9645); // "你带不走她。」"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan11", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(9646); // "而用“战利品”这个字眼来形容不属于你的人，也未免..."
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan11", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("yao_nv", parts: new List<string>{"mei7", "yan10", "zui7"});
        yield return _gameMethods.OpenDialog(9647); // "真是迫人的气场。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan16", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan24", "zui7"});
        yield return _gameMethods.OpenDialog(9648); // "谈条件吧。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan16", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("yao_nv");
        yield return _gameMethods.OpenDialog(9649); // "嗯——的确，我也不愿和灾厄之龙阁下为敌。"
        yield return _gameMethods.ExecuteCharacterImageData("yao_nv");
        yield return _gameMethods.OpenDialog(9650); // "只是，公主大人的价值，我们有目共睹。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan15", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("yao_nv", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(9651); // "又碰巧，我感觉和公主很合得来，交换条件可不会低。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan1", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(9652); // "这些不需要再赘述。等价交换，理所当然。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan7", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
        yield return _gameMethods.OpenDialog(9653); // "「只是，如果你想贪心，{nw}{w=0.01}"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei1", "yan19", "zui6"});
        yield return _gameMethods.OpenDialog(9654); // "也要确保自己负担得起相应的代价。」"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei1", "yan19", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("yao_nv");
        yield return _gameMethods.OpenDialog(4); // "……"
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(9655); // "妖精商人沉默片刻，表情一言难尽。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei1", "yan7", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("yao_nv");
        yield return _gameMethods.OpenDialog(9656); // "如果我记得没错，这位勇者大人所换的匕首，本就是用..."
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan15", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(9657); // "你想表达什么？"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan15", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("yao_nv");
        yield return _gameMethods.OpenDialog(9658); // "…………没什么。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan14", "zui1"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(390.0f, -126.0f)}, {"zpos", -330.0f}})});
        yield return _gameMethods.TransitionBy("blink2");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(9659); // "赫泽尔也停顿稍许，{nw}{w=0.01}"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan9", "zui1"});
        yield return _gameMethods.OpenDialog(9660); // "侧头看了我一眼。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(9661); // "我不明所以地同他对视。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan5", "zui1"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(4081); // "{nw}{w=0.25}"
        Engine._history = true;
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan18", "zui1", "emoji10"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(9662); // "他垂了垂眼眸，触电似的收回视线，{nw}{w=0..."
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan1", "zui1", "emoji10"});
        yield return _gameMethods.OpenDialog(9663); // "重新看向妖精商人，{nw}{w=0.2}"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan7", "zui1", "-emoji10"});
        Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.OpenDialog(9664); // "面色已恢复了冷淡高傲，平静漠然。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(240.0f, -42.0f)}, {"zpos", -78.0f}})});
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan7", "zui6"});
        yield return _gameMethods.TransitionBy("blink2");
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(9665); // "结果如你所见。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan12", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(9666); // "「她花费心思，使用那把匕首，{nw}{w=0.0..."
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan1", "zui7"});
        yield return _gameMethods.OpenDialog(9667); // "不过是为了创造一个合适的场合，{nw}{w=0...."
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan7", "zui6"});
        yield return _gameMethods.OpenDialog(9668); // "同我展示真心，坦诚交流。」"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan7", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("yao_nv_qian", parts: new List<string>{"mei6", "yan24", "zui16", "emoji2"});
        yield return _gameMethods.OpenDialog(9669); // "「啊………………{nw}{w=0.8}"
        yield return _gameMethods.OpenDialog(9670); // "这………………{nw}{w=0.8}"
        yield return _gameMethods.OpenDialog(9671); // "您所言极是。」"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -78.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.45f}, {"zpos", -108.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan12", "zui1", "emoji2"});
        yield return _gameMethods.OpenDialog(9672); // "想要作废你和勇者之间的协议，需要什么条件？"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -108.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(9673); // "实在听不下去这些闲谈，我上前打断，将话题重新引入..."
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:4.0f);
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Transition(time:0.3f);
        yield return _gameMethods.OpenDialog(33); // "………………"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/feng2.mp3");
        yield return _gameMethods.OpenDialog(130); // "……………………"
        yield return _gameMethods.PlaySound("soundc", 0.0f, 0.7f, "audio/demo_audio/sound/longpaidachibang.mp3<silence 2>audio/demo_audio/sound/longpaidachibang.mp3<silence 1>audio/demo_audio/sound/longpaidachibang.mp3<silence 3>");
        yield return _gameMethods.PlaySound("soundb", 1.0f, 1.0f, "audio/demo_audio/sound/tiankong_huanjin.ogg");
        yield return _gameMethods.PlaySound("music1", 0.0f, 1.0f, "audio/music/end/qicheng.mp3");
        yield return _gameMethods.Scene("tiankong_bangwan_yundong", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.2f, 1.27f)}, {"zoom", 1.26f}, {"anchor", new Vector2(0.5f, 1.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", -150.0f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Transition(time:0.7f);
        yield return _gameMethods.OpenDialog(6010); // "经过与妖精商人的协商，我们谈好了交换条件。"
        yield return _gameMethods.OpenDialog(6011); // "他提出的要求颇为刁钻，都是些无法轻易获得的奇异珍..."
        yield return _gameMethods.OpenDialog(9674); // "我们恐怕需要以几年时间，去慢慢收集。"
        yield return _gameMethods.OpenDialog(6013); // "不过，这并无大碍，对我而言，凡是能靠着努力去克服..."
        yield return _gameMethods.OpenDialog(6014); // "我有绝对的觉悟，会做到这一切。……更何况，我并不..."
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.OpenDialog(33); // "………………"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"matrixcolor", "InvertMatrix(0.0)*ContrastMatrix(1.0)*SaturationMatrix(1.0)*BrightnessMatrix(0.0)*HueMatrix(0.0)"}})});
        yield return _gameMethods.Show("fly_cg_ani", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.0f)}, {"zoom", 1.14f}})});
        yield return _gameMethods.Transition(time:2f);
        yield return _gameMethods.OpenDialog(9675); // "看着不远处，宛如微缩模型一般的王城。"
        yield return _gameMethods.OpenDialog(9676); // "我悄悄地把嘴巴贴近了巨大的龙身。"
        yield return _gameMethods.OpenDialog(9677); // "无论我想做什么，你都会帮我吗？"
        yield return _gameMethods.OpenDialog(765); // "嗯。"
        yield return _gameMethods.Hide("tiankong_bangwan_yundong");
        yield return _gameMethods.OpenDialog(9678); // "无论什么？"
        yield return _gameMethods.OpenDialog(9679); // "无论什么。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 1.0f}, {"ypos", -108.0f}})});
        yield return _gameMethods.Show("tiankong_bangwan_yundong", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.0f, 756.0f)}, {"zoom", 1.24f}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1.0f}})});
        yield return _gameMethods.OpenDialog(9680); // "嗯，我抬头看向天空。"
        yield return _gameMethods.OpenDialog(9681); // "再次确信。"
        yield return _gameMethods.Hide("fly_cg_ani");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -108.0f}})});
        yield return _gameMethods.OpenDialog(9682); // "已经没什么可担心的了。无论是什么，我都做得到。"
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.Show("screen", parts: new List<string>{"stop_screen(120)"});
        Engine._dismiss_pause = false;
        yield return _gameMethods.StopSound(channelName:"music1", fadeOut:3.0f);
        yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:3.0f);
        yield return _gameMethods.StopSound(channelName:"soundc", fadeOut:3.0f);
        yield return _gameMethods.SceneBlack();
        Engine._dismiss_pause = false;
        Defaults.Gui_duihuakuang_you = 0;
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Transition(time:0.6f);
        yield return _gameMethods.PlaySound("music5", 0.0f, 0.5f, "audio/music/end/maou_08_burning_heart.mp3");
        yield return _gameMethods.Show("geci", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(0.58f, 1.68f)}})});
        yield return _gameMethods.Show("end", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.5f}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.5f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.TransitionBy("Pause_2_0_");
        yield return _gameMethods.Hide("end");
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.Show("cast_image", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.34f}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 0.5f)}}), new SameLineParamData(new Dictionary<string, object>{}), new SameLineParamData(new Dictionary<string, object>{})});
        yield return _gameMethods.Show("cast", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 700.0f}, {"anchor", new Vector2(0.0f, 0.0f)}, {"xpos", 690.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 112.0f}, {"yoffset", -1870.0f}})});
        yield return _gameMethods.Show("cg_wenroudao_ani", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 115.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.0f}, {"alpha", 1.0f}})});
        yield return _gameMethods.Show("pianwei_m", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}, {"zoom", 0.67f}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 0.5f)}}), new SameLineParamData(new Dictionary<string, object>{}), new SameLineParamData(new Dictionary<string, object>{}), new SameLineParamData(new Dictionary<string, object>{{"pause", 118.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.0f}, {"alpha", 1.0f}})});
        yield return _gameMethods.Show("black", parts: new List<string>{"at", "default", "as", "black2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 0.5f)}}), new SameLineParamData(new Dictionary<string, object>{}), new SameLineParamData(new Dictionary<string, object>{}), new SameLineParamData(new Dictionary<string, object>{{"pause", 120.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.0f}, {"alpha", 1.0f}})});
        yield return _gameMethods.Show("pianwei", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}, {"zoom", 0.67f}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 0.5f)}}), new SameLineParamData(new Dictionary<string, object>{}), new SameLineParamData(new Dictionary<string, object>{}), new SameLineParamData(new Dictionary<string, object>{{"pause", 118.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.0f}, {"alpha", 1.0f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.StopEngineTime(time:122.0f);
        Engine._dismiss_pause = true;
        yield return _gameMethods.Hide("screen");
        yield return _gameMethods.StopEngineTime(time:0.5f);
        yield return _gameMethods.PlaySound("soundc", 0.0f, 0.7f, "audio/demo_audio/sound/longpaidachibang.mp3<silence 2>audio/demo_audio/sound/longpaidachibang.mp3<silence 1>audio/demo_audio/sound/longpaidachibang.mp3<silence 3>");
        yield return _gameMethods.PlaySound("soundb", 1.0f, 1.0f, "audio/demo_audio/sound/tiankong_huanjin.ogg");
        yield return _gameMethods.PlaySound("music1", 0.0f, 1.0f, "audio/music/end/bai_jieju1.mp3");
        yield return _gameMethods.Scene("fly_cg_ani");
        Defaults.Gui_duihuakuang_you = 1;
        yield return _gameMethods.StopSound(channelName:"music5", fadeOut:2.0f);
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"matrixcolor", "InvertMatrix(0.0)*ContrastMatrix(1.0)*SaturationMatrix(1.0)*BrightnessMatrix(0.0)*HueMatrix(0.0)"}})});
        yield return _gameMethods.Transition(time:2f);
        yield return _gameMethods.OpenDialog(9683); // "最终——"
        yield return _gameMethods.OpenDialog(9684); // "公主活着，灾厄之龙也活着。"
        yield return _gameMethods.OpenDialog(9685); // "这打破了预言的所有结局。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/feng2.mp3");
        yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:2.0f);
        yield return _gameMethods.StopSound(channelName:"soundc", fadeOut:2.0f);
        yield return _gameMethods.Show("anniu_bg22_memory");
        yield return _gameMethods.Hide("anniu_bg22_memory");
        yield return _gameMethods.Scene("jieju10");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Transition(time:0.8f);
        yield return _gameMethods.OpenDialog(9686); // "我们回了一趟王都，处理关于预言的善后事宜。"
        yield return _gameMethods.OpenDialog(9687); // "国王屁滚尿流地宣告了退位。王子私下联系我，希望由..."
        yield return _gameMethods.OpenDialog(9688); // "但我还在考虑。"
        yield return _gameMethods.OpenDialog(9689); // "最后，我决定先尝试接手一部分国家政务的处理，体验..."
        yield return _gameMethods.Show("anniu_bg23_memory");
        yield return _gameMethods.Hide("anniu_bg23_memory");
        yield return _gameMethods.Scene("jieju9");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.TransitionBy("trans_rip_fast");
        yield return _gameMethods.OpenDialog(9690); // "这几天，我一直在忙于公务。"
        yield return _gameMethods.OpenDialog(9691); // "和预想中令人疲惫的情况不同。实际上，这份工作可以..."
        yield return _gameMethods.OpenDialog(9692); // "这让我感觉还不错，仿佛接触到了一个全新的、更加宽..."
        yield return _gameMethods.OpenDialog(9693); // "介于我的时间和精力被工作分去了大半，这似乎让赫泽..."
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.StopSound(channelName:"music1", fadeOut:4.0f);
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.Scene("jieju9", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.34f, 1.31f)}, {"zoom", 1.26f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/demo_audio/music/qingkuai4.mp3");
        yield return _gameMethods.OpenDialog(9694); // "这一天。"
        yield return _gameMethods.OpenDialog(9695); // "我阅读完了财政大臣刚刚提交的预算报表。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei5", "yan12", "zui15", "emoji2", "d4"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(9696); // "忍不住揉了揉太阳穴。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan22", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(9697); // "看到的数据，让我对自己产生了怀疑。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei3", "yan18", "zui15", "emoji2", "emoji12"});
        yield return _gameMethods.OpenDialog(9698); // "（难道我平时表现得真的不谙世事？）"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15", "emoji2", "-emoji12"});
        yield return _gameMethods.OpenDialog(9699); // "不然他们为什么会觉得，给一只鸡配上1金币的标价，..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(9700); // "……财政部内部人员的问题不小。得找出刺头，杀鸡儆..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan21", "zui15"});
        yield return _gameMethods.OpenDialog(9701); // "名单的初筛……待会就交给洛恩吧。"
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:1.0f);
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei1", "yan5", "zui6"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.46f}, {"pos", new Vector2(708.0f, 2070.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}, {"blur", 0.1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.2f}, {"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1.5>audio/sound/jiaobusheng_nuo_normal1.ogg");
        if (Defaults.Persistent.Povname == "辛西娅")
        {
            yield return _gameMethods.OpenDialog(2977); // "辛西娅。"
        }
        else
        {
            yield return _gameMethods.OpenDialog(2030); // "[persistent.povname]。"
        }
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei1", "yan5", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(47); // "……！"
        yield return _gameMethods.PlaySound("music1", 0.0f, 1.0f, "audio/demo_audio/music/richang1.mp3");
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10"});
        yield return _gameMethods.OpenDialog(8509); // "赫泽尔？"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui15"});
        yield return _gameMethods.OpenDialog(9702); // "他什么时候来的。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei1", "yan1", "zui1"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei1", "yan5", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(9703); // "「见到你真好。"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(9704); // "找我有事么？」"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei1", "yan5", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
        yield return _gameMethods.OpenDialog(765); // "嗯。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei1", "yan10", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(9705); // "……我有一个问题要问你。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"ypos", -48.0f}, {"zpos", -120.0f}})});
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei1", "yan14", "zui1"});
        yield return _gameMethods.TransitionBy("blink2");
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(9706); // "嗯？你说？"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui7"});
        yield return _gameMethods.OpenDialog(9707); // "我放下笔，顺手拿起瓷杯抿了口茶。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan11", "zui7"});
        yield return _gameMethods.OpenDialog(9708); // "有点新奇，赫泽尔居然会有事来咨询我。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei1", "yan5", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(9709); // "我们现在是什么关系。"
        yield return _gameMethods.StopSound(channelName:"music1", fadeOut:1.0f);
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei1", "yan5", "zui1"});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -8.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 8.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0.0f}, {"parallel_1", true}})});
        yield return _gameMethods.PlaySound("sound", 0.0f, 2.0f, "audio/sound/pencha1.mp3");
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei6", "yan11", "zui13", "emoji2", "emoji6"});
        yield return _gameMethods.OpenDialog(9710); // "……噗————！！！"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"yoffset", 0.0f}})});
        yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/demo_audio/music/qingkuai5.mp3");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei6", "yan11", "zui18", "emoji2", "emoji6"});
        yield return _gameMethods.OpenDialog(9711); // "我喷了。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -120.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.5f}, {"zpos", -114.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan22", "zui19", "emoji2", "emoji6"});
        yield return _gameMethods.OpenDialog(9712); // "怎、怎么突然想起问这个？"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei1", "yan10", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan22", "zui8", "emoji2", "emoji6"});
        yield return _gameMethods.OpenDialog(9713); // "你曾承诺，等我进入成长期，就将我视为爱情对象。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -114.0f}})});
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei1", "yan10", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui10", "-emoji2", "-emoji6"});
        yield return _gameMethods.OpenDialog(9714); // "「对，对……"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan18", "zui10"});
        yield return _gameMethods.OpenDialog(9715); // "是有这么回事来着。」"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan5", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei5", "yan12", "zui20", "emoji2"});
        yield return _gameMethods.OpenDialog(9716); // "我当时说，会考虑一下。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan9", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei5", "yan12", "zui8", "emoji2"});
        yield return _gameMethods.OpenDialog(9717); // "……你在含糊其辞？"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan17", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei3", "yan2", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(9718); // "你在试图回避这个问题。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan17", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(9719); // "这也太敏锐了。"
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:3.0f);
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -114.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.5f}, {"zpos", -120.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(9720); // "我端正态度，直视着他的双眼，认真回答。"
        yield return _gameMethods.PlaySound("music1", 0.0f, 1.0f, "audio/demo_audio/music/richang1.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -120.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(9721); // "不是回避，只是在阐述客观事实。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan5", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(9722); // "毕竟我当时的确是那么说的，而他那时也并未提出质疑..."
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan1", "zui1"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan5", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(21); // "…………"
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(9723); // "他沉默半响。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan16", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(9724); // "然后缓慢地环起双臂，撇开了脸，"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei6", "yan18", "zui1"});
        yield return _gameMethods.OpenDialog(9725); // "盯着地面，冷冷地从鼻腔里发出一声嗤音。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei9", "yan1", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(9726); // "…………哼。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei8", "yan16", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan2", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(9727); // "……他“哼”了吗。是他在“哼”吗？"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan6", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(9728); // "赫泽尔…？那位从出生起就强大全知、无所不能的黑暗..."
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -8.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 8.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0.0f}, {"parallel_1", true}})});
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/moca1.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei5", "yan5", "zui19", "-emoji2"});
        yield return _gameMethods.OpenDialog(9729); // "——所以！！我从现在就认真考虑！"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"yoffset", 0.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan11", "zui19", "emoji2"});
        yield return _gameMethods.OpenDialog(9730); // "你先别急着不高兴……！"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei6", "yan13", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei3", "yan5", "zui8", "emoji2"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.OpenDialog(9731); // "他重新看向我，目光有些冷淡，直勾勾地盯着我，仿佛..."
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan8", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei6", "yan1", "zui1"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei6", "yan13", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui18"});
        yield return _gameMethods.OpenDialog(9732); // "我沉思片刻。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan20", "zui15"});
        yield return _gameMethods.OpenDialog(9733); // "又沉思片刻。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan12", "zui8", "emoji2"});
        yield return _gameMethods.OpenDialog(9734); // "最后决定坦白。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui19", "emoji2"});
        yield return _gameMethods.OpenDialog(9735); // "…………你要听实话么？"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei6", "yan9", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan5", "zui7", "emoji2"});
        yield return _gameMethods.OpenDialog(765); // "嗯。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei6", "yan9", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan18", "zui10", "-emoji2"});
        yield return _gameMethods.OpenDialog(9736); // "「其实，虽然我的确对你有怀有爱意，"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei8", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(9737); // "但一时半会……我还很难立刻把你当作恋情对象。」"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan5", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(9738); // "实话说。我觉得他很可爱。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(9739); // "想回报他。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(9740); // "想温柔地对待他。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(9741); // "但是我依然很难保证这足以建立一段紧密的关系。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan17", "zui15"});
        yield return _gameMethods.OpenDialog(9742); // "……于是，这么说完，我紧张地睁眼看他。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan1", "zui1"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan5", "zui1"});
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(9743); // "却见他仍面色如常，保持着冷静。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(9744); // "……你不对我发火么？"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan9", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(9745); // "如果这是事实，我为什么要生气。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan9", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan24", "zui19", "emoji2"});
        yield return _gameMethods.OpenDialog(9746); // "「呃……因为我曾承诺过会爱你？{nw}{w=0...."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan12", "zui2", "emoji2"});
        yield return _gameMethods.OpenDialog(9747); // "但情感它，它好像没跟上嘴巴的速度。」"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan1", "zui1"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan9", "zui1"});
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei3", "yan8", "zui8", "emoji2"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan1", "zui7"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(9748); // "就算如此，发火并不能解决问题。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan10", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan2", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(9749); // "「这段时间，我研读了一些探究人类心理的书籍，{n..."
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan18", "zui6"});
        yield return _gameMethods.OpenDialog(9750); // "也观阅了一些处于恋爱关系中的人类的相处方式。」"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan1", "zui7"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
        yield return _gameMethods.OpenDialog(9751); // "「无谓的宣泄情感，{nw}{w=0.01}"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan5", "zui6"});
        yield return _gameMethods.OpenDialog(9752); // "只会把你推得更远。」"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan5", "zui1"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan10", "zui10", "emoji2"});
        yield return _gameMethods.OpenDialog(9753); // "怎么回事，感觉他进步得也太神速了。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan10", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(9754); // "好稳定的情绪。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.5f, "<from 0 to 1>audio/sound/jiaobusheng_nuo_normal1.ogg");
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan1", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(708.0f, 2070.0f)}, {"zpos", 30.0f}, {"zoom", 0.45999999999999996f}})});
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan5", "zui6"});
        yield return _gameMethods.OpenDialog(9755); // "更何况，我不会给你抽身离开我的机会。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan14", "zui6"});
        yield return _gameMethods.OpenDialog(9756); // "你没可能去爱上别人。"
        yield return _gameMethods.PlaySound("sounda", 0.0f, 0.7f, "<from 0 to 1>audio/sound/jiaobusheng_xin_normal1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -120.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 1.0f}, {"zpos", -90.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan24", "zui2", "emoji2"});
        yield return _gameMethods.OpenDialog(9757); // "……这、这样啊。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan24", "zui8", "emoji2"});
        yield return _gameMethods.OpenDialog(9758); // "这话它，应该当着我的面说么。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -90.0f}})});
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei1", "yan1", "zui7"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(9759); // "所以，你没必要感到焦虑。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei1", "yan9", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan5", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(9760); // "我已经做好了准备。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan16", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
        yield return _gameMethods.OpenDialog(9761); // "「即便你中途不慎被其他碍事的东西吸引目光，{nw..."
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan20", "zui6"});
        yield return _gameMethods.OpenDialog(9762); // "我也会帮你纠正错误。」"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan1", "zui7"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
        yield return _gameMethods.OpenDialog(1956); // "{nw}{w=0.4}"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan9", "zui6"});
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(9763); // "直到你做出正确的选择。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/moca1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -3.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 3.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0.0f}, {"parallel_1", true}})});
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan9", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei6", "yan10", "zui19", "emoji2"});
        yield return _gameMethods.OpenDialog(9764); // "…………不是，你到底做好了什么准备？"
        yield return _gameMethods.PlaySound("sounda", 0.0f, 0.4f, "audio/sound/moca1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -8.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 8.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0.0f}, {"parallel_1", true}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei6", "yan11", "zui2", "emoji2", "emoji5"});
        yield return _gameMethods.OpenDialog(9765); // "这段时间你从书里都学会了些什么东西啊！"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"yoffset", 0.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan8", "zui8", "emoji2", "emoji5"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan12", "zui8", "emoji2", "-emoji5"});
        yield return _gameMethods.OpenDialog(9766); // "失策了，基于身份与权柄，这家伙所能看到的人类的行..."
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan1", "zui1"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan9", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan24", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(9767); // "我应该及时加以干涉，以免他被误导。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei3", "yan2", "zui19", "emoji2"});
        yield return _gameMethods.OpenDialog(9768); // "「……那个！那个！"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan5", "zui19", "emoji2"});
        yield return _gameMethods.OpenDialog(9769); // "我已经为我们之间的关系发展，做出了一个颇具实操性..."
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan5", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei3", "yan5", "zui7", "-emoji2"});
        yield return _gameMethods.OpenDialog(975); // "嗯？"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan5", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(9770); // "你知道恋爱的步骤吗？"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(9771); // "人们都是先交往，谈一段时间的恋爱，确定无误了，再..."
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan10", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.StopSound(channelName:"music1", fadeOut:3.0f);
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(9772); // "他思考了一下。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei1", "yan1", "zui7"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(9773); // "没必要那么麻烦。"
        yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/demo_audio/music/qingkuai3.mp3");
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan5", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(9774); // "如果婚姻是终点，我们可以现在进行。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan5", "zui1"});
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.5>audio/sound/jiaobusheng_xin_normal1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -90.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.46f}, {"zpos", -36.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei5", "yan22", "zui19", "emoji2"});
        yield return _gameMethods.OpenDialog(9775); // "{size=+10}慢着。你等下。{/size}"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan13", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei5", "yan22", "zui8", "emoji2"});
        yield return _gameMethods.OpenDialog(165); // "？"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -36.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan5", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan10", "zui8", "emoji2"});
        yield return _gameMethods.OpenDialog(9776); // "该疑问的是我吧？不是我吗……？"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui8", "emoji2"});
        yield return _gameMethods.OpenDialog(9777); // "为什么他这么理直气壮啊。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan1", "zui1"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan5", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19", "emoji2"});
        yield return _gameMethods.OpenDialog(9778); // "……不、那个……你先别那么果断……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan11", "zui7", "emoji2"});
        yield return _gameMethods.OpenDialog(9779); // "别再冲刺了，我有点害怕。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei1", "yan6", "zui19", "-emoji2"});
        yield return _gameMethods.OpenDialog(9780); // "我觉得还是应该先从约会做起……"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan1", "zui1"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan14", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei1", "yan6", "zui7"});
        yield return _gameMethods.OpenDialog(9781); // "约会。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan14", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10"});
        yield return _gameMethods.OpenDialog(9782); // "就是两人约定一个时间地点来会面，一起度过一段时光..."
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan5", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(4869); // "我知道。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan10", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(9783); // "我只是不理解，为什么要约定时间地点来会面。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan1", "zui7"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(9784); // "既然我们住在一起，便没理由分开。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan10", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei6", "yan22", "zui13", "emoji5", "emoji6"});
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei6", "yan22", "zui16", "emoji2", "emoji5", "emoji6"});
        yield return _gameMethods.OpenDialog(9785); // "好沉重。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.5>audio/sound/jiaobusheng_xin_normal1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -36.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.40f}, {"zpos", -56.0f}})});
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan5", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19", "emoji2", "-emoji5", "emoji6"});
        yield return _gameMethods.OpenDialog(9786); // "因、因为仪式感……"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui19", "emoji2", "-emoji6"});
        yield return _gameMethods.OpenDialog(9787); // "这是一种与日常生活截然不同的行程。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -56.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan6", "zui2", "emoji2"});
        yield return _gameMethods.OpenDialog(9788); // "约会，就代表着接下来要全心全意地享受与对方一起的..."
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan9", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan6", "zui8", "emoji2"});
        yield return _gameMethods.OpenDialog(9789); // "……就像我们平时一起读书那样？"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan9", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan10", "zui8", "emoji2"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan10", "zui8", "-emoji2"});
        yield return _gameMethods.OpenDialog(9790); // "我觉得这有点不对，但一时说不出问题出在哪。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan1", "zui7"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
        yield return _gameMethods.OpenDialog(9791); // "「那么，我们已经拥有了很多约会经验，{nw}{w..."
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan5", "zui6"});
        yield return _gameMethods.OpenDialog(9792); // "足以进行到下一步。」"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan5", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(9793); // "他顿了一下。似乎并不确定下一步是什么，{nw}{..."
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan14", "zui1"});
        yield return _gameMethods.OpenDialog(9794); // "于是冷静地提出了一个猜测。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan5", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(9795); // "………………结婚？"
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/moca1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -8.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 8.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0.0f}, {"parallel_1", true}})});
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan5", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei5", "yan11", "zui2", "emoji2"});
        yield return _gameMethods.OpenDialog(9796); // "不是！！！！是交往！！"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"yoffset", 0.0f}})});
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei1", "yan13", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei5", "yan22", "zui8", "emoji2"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei1", "yan5", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(9797); // "那就交往。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei1", "yan5", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan5", "zui10", "-emoji2"});
        yield return _gameMethods.OpenDialog(9798); // "等等。"
        yield return _gameMethods.OpenDialog(9799); // "首先我要反驳，之前我们一起读书、逛街，那些都不算..."
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan21", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei3", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(9800); // "你的理由？"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan17", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(9801); // "那些是生活。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan5", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan12", "zui19"});
        yield return _gameMethods.OpenDialog(9802); // "约会，应该是以一种更特别的心态来进行的。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui2"});
        yield return _gameMethods.OpenDialog(9803); // "在这个过程中，我会用全新的、看待恋爱对象的眼光来..."
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan18", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(9804); // "他缄口不言，似是有点意动了。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan9", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui7"});
        yield return _gameMethods.OpenDialog(9805); // "沉吟思忖片刻，赫泽尔再次问道。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan9", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(9806); // "这个步骤的作用是什么？"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan9", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan6", "zui10"});
        yield return _gameMethods.OpenDialog(9807); // "「通过约会，我们可以感受彼此在各方面是否合适，{..."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(9808); // "如果不合适，还能及时——……」"
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.5f, "<from 0 to 1>audio/sound/jiaobusheng_nuo_normal1.ogg");
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei7", "yan21", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(708.0f, 2070.0f)}, {"zpos", 72.0f}, {"zoom", 0.45999999999999996f}})});
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.OpenDialog(9809); // "不会不合适。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei7", "yan21", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(9810); // "他打断我。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei5", "yan1", "zui7"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(9811); // "我会完成你的所有要求。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei7", "yan16", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei5", "yan10", "zui2", "emoji2"});
        yield return _gameMethods.OpenDialog(9812); // "……非常感动但我没说完，我还没说完呢！"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui19", "-emoji2"});
        yield return _gameMethods.OpenDialog(9813); // "如果合适，也许就会走到下一步。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan5", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(9814); // "相伴一生？"
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/moca1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -8.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 8.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0.0f}, {"parallel_1", true}})});
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan5", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei5", "yan11", "zui2", "emoji2"});
        yield return _gameMethods.OpenDialog(9815); // "是交往啊！！"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"yoffset", 0.0f}})});
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei8", "yan14", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan11", "zui8", "-emoji2"});
        yield return _gameMethods.OpenDialog(9816); // "他微微皱眉。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei8", "yan1", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(9817); // "我不明白中间这些多余的步骤有何价值。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei8", "yan14", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan2", "zui10"});
        yield return _gameMethods.OpenDialog(9818); // "有必要的。爱是一种极其微妙的感情，是需要细心呵护..."
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei8", "yan9", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(9819); // "爱是一种奢侈品。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan12", "zui12"});
        yield return _gameMethods.OpenDialog(9820); // "说实话，之前我其实从没指望这辈子追求什么爱情，能..."
        Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(9821); // "但是现在，因为你，我改变了想法。"
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:3.0f);
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(-48.0f, -108.0f)}, {"zpos", -200.0f}})});
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan4", "zui1"});
        yield return _gameMethods.TransitionBy("blink2");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(9822); // "我认真地凝视着他，与他目光交汇。"
        yield return _gameMethods.PlaySound("music1", 0.0f, 1.0f, "audio/music/end/bai_jieju1.mp3");
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(9823); // "「赫泽尔，我想和你一起认真地去探索我们之间的关系..."
        Defaults.Haogandu_he = Defaults.Haogandu_he + 2;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(9824); // "不行吗？」"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan1", "zui1"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan5", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(9825); // "他凝望我片刻，"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan14", "zui1", "emoji10"});
        yield return _gameMethods.OpenDialog(9826); // "垂下眼眸。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan18", "zui6", "emoji10"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(9160); // "……好吧。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan1", "zui7"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(9827); // "如果你坚持的话。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"ypos", -54.0f}, {"zpos", -38.0f}})});
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan18", "zui1"});
        yield return _gameMethods.TransitionBy("blink2");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan12", "zui7"});
        yield return _gameMethods.OpenDialog(6327); // "我松了口气。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan18", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(9828); // "……那么，我们去约会。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan9", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
        yield return _gameMethods.OpenDialog(9829); // "要怎么做？"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan9", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui19"});
        yield return _gameMethods.OpenDialog(9830); // "……你对什么地方比较感兴趣？"
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan18", "zui11"});
        yield return _gameMethods.OpenDialog(9831); // "「图书馆？逛街？{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan5", "zui2"});
        yield return _gameMethods.OpenDialog(9832); // "还是去野外散步野餐？」"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan1", "zui1"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan5", "zui6"});
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan5", "zui8"});
        yield return _gameMethods.OpenDialog(9833); // "不是该去你喜欢的地方么。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan5", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(9834); // "他平静地问。"
        yield return _gameMethods.OpenDialog(3194); // "我愣了一下。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan10", "zui6"});
        yield return _gameMethods.OpenDialog(9835); // "你说爱情不是一个人的事。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei1", "yan1", "zui7"});
        yield return _gameMethods.OpenDialog(9836); // "伴侣要承担责任与义务，做到关心、陪伴和温柔。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei1", "yan9", "zui6"});
        yield return _gameMethods.OpenDialog(9837); // "不是么。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei1", "yan9", "zui1"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(9838); // "这些话语似曾相识。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(9839); // "我从记忆里扒出了自己曾说过的内容。那已经是一年多..."
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan5", "zui10", "emoji2"});
        yield return _gameMethods.OpenDialog(9840); // "…………你还挺会的。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei1", "yan5", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei3", "yan5", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(165); // "？"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan7", "zui10"});
        yield return _gameMethods.OpenDialog(9841); // "可是我想不到有什么想去的地方呢。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(9842); // "你有好点子么？"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan14", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan5", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(9843); // "你好像很喜欢罗曼小说，我们可以一起去书店，寻找这..."
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan6", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(9844); // "你曾说过你从小渴望甜味，我们可以去品尝你想吃的甜..."
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
        yield return _gameMethods.OpenDialog(9845); // "「你……{nw}{w=0.01}"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan18", "zui6"});
        yield return _gameMethods.OpenDialog(9846); // "之前，似乎喜欢那种孱弱的皮毛动物，我可以带你找一..."
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei6", "yan1", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
        yield return _gameMethods.OpenDialog(9847); // "「——但是，过多地被这种事物分散注意力，仍是一件..."
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei6", "yan9", "zui6"});
        yield return _gameMethods.OpenDialog(9848); // "你最好学会节制。」"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei6", "yan9", "zui1"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(9849); // "他生硬地转折，向我强调。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei1", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(9850); // "看得出来，他的确在绞尽脑汁地思考，有哪些事可以让..."
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei1", "yan14", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan11", "zui7"});
        yield return _gameMethods.OpenDialog(9851); // "如果这些都无法让你产生兴趣。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei1", "yan14", "zui3"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(9852); // "他抿了抿唇。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei7", "yan1", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(9853); // "那么我会再思考一下。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei1", "yan9", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_weizhi");
        yield return _gameMethods.OpenDialog(9854); // "听起来不错。"
        yield return _gameMethods.StopSound(channelName:"music1", fadeOut:2.0f);
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan4", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(9855); // "一道声音忽然出现。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.5f, "<from 0 to 0.5>audio/sound/jiaobusheng_nuo_normal1.ogg");
        yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/music/yongzhe_kaixin.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", -48.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"xpos", 252.0f}})});
        yield return _gameMethods.Hide("heo");
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui14"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(888.0f, 2068.0f)}, {"zoom", 0.63f}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}, {"blur", 0.1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.2f}, {"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei6", "yan1", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(708.0f, 2070.0f)}, {"zpos", 72.0f}, {"zoom", 0.45999999999999996f}})});
        Engine._history = false;
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei6", "yan19", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_qian");
        yield return _gameMethods.OpenDialog(9856); // "「但是很可惜，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei4", "yan11", "zui16"});
        yield return _gameMethods.OpenDialog(9857); // "我会来妨碍你们的。」"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei6", "yan19", "zui2"});
        yield return _gameMethods.PlaySound("sounda1", 0.0f, 4.0f, "audio/sound/manbu/Body1_02_duan.mp3");
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei4", "yan11", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-462.0f, 12.0f)}, {"zpos", 172.0f}})});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei8", "yan11", "zui12", "emoji3"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.0f, 1944.0f)}, {"zoom", 0.45f}, {"zpos", 72.0f}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", -70.0f}, {"alpha", 0.0f}, {"blur", 0.1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"xoffset", 0.0f}, {"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.ExecuteCharacterImageData("luo_nv", parts: new List<string>{"mei7", "yan7", "zui15"});
        yield return _gameMethods.OpenDialog(9858); // "我也是。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei6", "yan20", "zui2"});
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<from 0 to 1>audio/sound/jiaobusheng_an_kuai1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"easein", 0.4f}, {"xpos", -594.0f}})});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan16", "zui4", "-emoji8", "-emoji21"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 72.0f}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}, {"blur", 0.1f}, {"pos", new Vector2(-486.0f, 2052.0f)}, {"zoom", 0.47f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.2f}, {"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei4", "yan8", "zui8", "emoji3", "emoji5"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei7", "yan6", "zui15"});
        yield return _gameMethods.OpenDialog(9859); // "……我会监督你，以免你伤害她。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"xpos", -594.0f}})});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan16", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.Show("luo2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei6", "yan18", "zui2", "emoji14"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan24", "zui16", "emoji2"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(-36.0f, -114.0f)}, {"zpos", -134.0f}})});
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei6", "yan1", "zui8", "-emoji14"});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(9860); // "你们没有自己的事要做吗。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", -36.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.51f}, {"xpos", 228.0f}})});
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei4", "yan9", "zui6"});
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei6", "yan11", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(9861); // "「嗯——我的任务，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui14"});
        yield return _gameMethods.OpenDialog(9862); // "就是把公主从恶龙手中拯救出来？」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui8"});
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan15", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei3", "yan12", "zui8", "emoji2"});
        yield return _gameMethods.OpenDialog(9863); // "……你也好意思说这话么。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 228.0f}})});
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan15", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(9864); // "当然，我可是好龙呀。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei0", "yan19", "zui2", "emoji14"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan21", "zui8", "emoji2"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("black", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 72.0f}, {"anchor", new Vector2(0.0f, 0.0f)}, {"pos", new Vector2(6.0f, -156.0f)}, {"zoom", 1.21f}})});
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(9865); // "我抬头看天，低头看地。"
        yield return _gameMethods.Hide("black");
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui16"});
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei6", "yan18", "zui2", "emoji14"});
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(9866); // "很头疼，是吗？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(9867); // "诺伯拉笑眯眯地看向我。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan10", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(9868); // "但是，没办法。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui14"});
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei6", "yan1", "zui2", "emoji14"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei6", "yan18", "zui2", "emoji14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(9869); // "你总要对自己所关照的事物负责嘛。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan12", "zui2", "emoji2"});
        yield return _gameMethods.OpenDialog(9870); // "……是啊，我知道。"
        Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan5", "zui2", "-emoji2"});
        yield return _gameMethods.OpenDialog(9871); // "那么首先，先让我和赫泽尔约会。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(9872); // "这是我答应过的。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei6", "yan15", "zui2", "-emoji14"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(9873); // "赫泽尔不快地盯着诺伯拉。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan10", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(9874); // "后者一脸好心地开口安慰。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei6", "yan14", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(9875); // "没关系的，尼德霍格。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei6", "yan1", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(9876); // "「你要知道，在王都，一段完善的人生中，{nw}{..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan14", "zui16"});
        yield return _gameMethods.OpenDialog(9877); // "总少不了几名挚友、知音，又或是伙伴的身影。」"
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/moca1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -8.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 8.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0.0f}, {"parallel_1", true}})});
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan14", "zui8"});
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei6", "yan3", "zui2", "emoji2", "emoji12", "emoji14", "emoji16"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei5", "yan22", "zui2", "emoji2"});
        yield return _gameMethods.OpenDialog(9878); // "这种东西就不要胡说了吧！！"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"yoffset", 0.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan22", "zui8", "emoji2"});
        yield return _gameMethods.OpenDialog(9879); // "忍不住吐槽出声。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui7", "-emoji2"});
        yield return _gameMethods.OpenDialog(9880); // "接着，{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei2", "yan11", "zui8"});
        yield return _gameMethods.OpenDialog(9881); // "我自己也绷不住笑了。"
        yield return _gameMethods.Show("heo", parts: new List<string>{"mei6", "yan16", "zui2", "emoji14", "-emoji12", "-emoji16"});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan14", "zui2"});
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei4", "yan9", "zui1"});
        yield return _gameMethods.Show("jieju9", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.33f, 1.86f)}, {"zoom", 1.77f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(-264.0f, 204.0f)}, {"zpos", 688.0f}})});
        yield return _gameMethods.Transition(time:0.6f);
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(9882); // "……好吧，好吧。"
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:6.0f);
        yield return _gameMethods.OpenDialog(9883); // "——你要对自己所关照的事物负责。"
        yield return _gameMethods.OpenDialog(9884); // "接下来的日子，恐怕绝对不会无聊或寂寞了。"
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Transition(time:0.6f);
        Engine._history = false;
        yield return _gameMethods.OpenDialog(2249); // "{nw}{w=0.5}"
        Defaults.Persistent.Gallery_js_lock = 1;
        _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_6");
        _gameMethods.SyncAchievement();
        Defaults.Persistent.Jq_11_7 = 1;
        yield return _gameMethods.Show("tishi_xun", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 0.5f)}, {"pos", new Vector2(0.5f, 0.5f)}, {"zpos", 0.0f}})});
        yield return _gameMethods.Transition(time:0.8f);
        yield return _gameMethods.OpenDialog(4793); // "{nw}{w=60}"
        Engine._history = true;
        if (Defaults.Persistent.Jq_11_1 == 1 && Defaults.Persistent.Jq_11_2 == 1 && Defaults.Persistent.Jq_11_3 == 1 && Defaults.Persistent.Jq_11_4 == 1 && Defaults.Persistent.Jq_11_5 == 1 && Defaults.Persistent.Jq_11_6 == 1 && Defaults.Persistent.Jq_11_7 == 1)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_7");
            _gameMethods.SyncAchievement();
        }
        yield break;
    }

}
