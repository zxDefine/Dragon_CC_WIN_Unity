using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class juezhan : ILabelProvider
{
    private GameMethods _gameMethods;

    public juezhan(GameMethods gameMethods)
    {
        _gameMethods = gameMethods;
    }

    public IEnumerator label_juezhan()
    {
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(1926); // "………"
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.PlaySound("soundb", 0.0f, 1.0f, "audio/demo_audio/sound/yu1.ogg");
        yield return _gameMethods.PlaySound("soundc", 0.0f, 1.0f, "audio/demo_audio/sound/leisheng_gun1.ogg");
        yield return _gameMethods.Scene("senlin2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})});
        yield return _gameMethods.Show("rain_1");
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(6527); // "几个月的时光如流水掠过。"
        yield return _gameMethods.OpenDialog(6528); // "这几个月里，我趁着赫泽尔放宽了限制，尽量独自外出。"
        yield return _gameMethods.OpenDialog(6529); // "很快到了决定命运的那一天。"
        yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:4f);
        yield return _gameMethods.StopSound(channelName:"soundc", fadeOut:4f);
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(1926); // "………"
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.PlaySound("soundd", 0.0f, 1.0f, "audio/demo_audio/sound/niaoming.ogg");
        yield return _gameMethods.Scene("caodi2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.0f)}, {"zoom", 0.47f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.PlaySound("soundc", 1f, 1.0f, "audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
        yield return _gameMethods.OpenDialog(6530); // "决战之时在黎明时分。"
        Defaults.Persistent.Jq_9_6 = 1;
        yield return _gameMethods.OpenDialog(6531); // "我们到达了预言中所记载的战场。"
        yield return _gameMethods.StopSound(channelName:"soundc", fadeOut:2f);
        yield return _gameMethods.PlaySound("soundb", 2f, 2.0f, "audio/sound/manbu/Gentle Breeze Blowing Foliage Rustling_01.ogg");
        yield return _gameMethods.OpenDialog(6532); // "这里是一座悬崖，青草茫茫..."
        yield return _gameMethods.OpenDialog(6533); // "凌晨时分，日出之前，黯淡的天地间。"
        yield return _gameMethods.StopSound(channelName:"soundd", fadeOut:5f);
        yield return _gameMethods.OpenDialog(6534); // "勇者和奥术师两人的身影出现在了视野里。"
        yield return _gameMethods.OpenDialog(6535); // "我们隔着一段距离，陷入安静的对峙。"
        yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/music/juezhan/sadness_room.mp3");
        yield return _gameMethods.OpenDialog(6536); // "空气无比沉重。"
        yield return _gameMethods.OpenDialog(6537); // "似乎谁都不想开口..."
        yield return _gameMethods.OpenDialog(6538); // "寂静。"
        yield return _gameMethods.OpenDialog(6539); // "有一刻，我感到灵魂仿佛脱出了这具身体..."
        yield return _gameMethods.OpenDialog(6540); // "这么短的时间里，就会决定我的命运吗？"
        yield return _gameMethods.OpenDialog(6541); // "一种想笑的荒唐感。"
        yield return _gameMethods.OpenDialog(6542); // "赫泽尔的面色带着几分阴郁。 "
        yield return _gameMethods.OpenDialog(6543); // "真奇怪，我还以为他会恢复原型..."
        yield return _gameMethods.OpenDialog(6544); // "毕竟不管怎么看，都是龙的庞大体型..."
        yield return _gameMethods.OpenDialog(6545); // "但他始终保持着人类体型..."
        yield return _gameMethods.OpenDialog(6546); // "是觉得、仅仅这样..."
        yield return _gameMethods.OpenDialog(6547); // "……不明白他的想法啊。"
        yield return _gameMethods.OpenDialog(6548); // "我攥了攥手指..."
        yield return _gameMethods.OpenDialog(6549); // "当太阳跳出地平线的那一瞬间..."
        yield return _gameMethods.OpenDialog(6550); // "而一旦开战，就没有机会了。"
        yield return _gameMethods.OpenDialog(6551); // "战场瞬息万变..."
        yield return _gameMethods.OpenDialog(6552); // "如果要下手，就必须当机立断。"
        yield return _gameMethods.OpenDialog(6553); // "……现在吗？"
        if (Defaults.Persistent.He_ending == 1 && Defaults.Bai_xin == 1)
        {
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.6>audio/sound/heartbeats_01.ogg");
            yield return _gameMethods.OpenDialog(6554); // "忽然，不知为何，我的心剧烈地跳动了一下。"
            yield return _gameMethods.OpenDialog(6555); // "眼前的情景陡然给了我一种熟悉之感。"
            yield return _gameMethods.OpenDialog(6556); // "好像我曾来过这个地方..."
            yield return _gameMethods.OpenDialog(6557); // "这怎么可能呢。"
            yield return _gameMethods.OpenDialog(6558); // "……但，此时此刻..."
            yield return _gameMethods.OpenDialog(6559); // "——“赫泽尔似乎并不打算动手。”"
            yield return _gameMethods.OpenDialog(6560); // "……太矛盾了。"
            yield return _gameMethods.OpenDialog(6561); // "理性来看..."
            yield return _gameMethods.OpenDialog(6562); // "现在，这突如其来的强烈感性..."
            yield return _gameMethods.OpenDialog(6563); // "如果在这里判断失误，后果将是致命的。"
            yield return _gameMethods.OpenDialog(6564); // "我该怎么做？"
        }
        if (Defaults.Persistent.He_ending == 1 && Defaults.Bai_xin == 1)
        {
            yield return _gameMethods.OpenSelectMenu(talk: new List<string>{"-说服黑龙", "-就是现在", "-再等等"}, jump: new List<string>{"label_juezhan_menu_0_shuofu", "label_juezhan_menu_0_jiushixianzai", "label_juezhan_menu_0_zaidengdeng"}, condition: new List<string>{"NONE", "NONE", "NONE"});
        }
        else
        {
            yield return _gameMethods.OpenSelectMenu(talk: new List<string>{"-就是现在", "-再等等"}, jump: new List<string>{"label_juezhan_menu_0_jiushixianzai", "label_juezhan_menu_0_zaidengdeng"}, condition: new List<string>{"NONE", "NONE"});
        }
    }

    public IEnumerator label_juezhan_1()
    {
        Defaults.He_xianzai = 1;
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
        yield return _gameMethods.OpenDialog(6568); // "他看向了我，脸上一如往常缺乏情绪。"
        yield return _gameMethods.OpenDialog(6569); // "他在想什么？..."
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
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei1", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(5693); // "再抱一抱吧。」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan29", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei1", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.OpenDialog(33); // "………………"
        yield return _gameMethods.OpenDialog(6570); // "他看了我几秒，有几秒呢？..."
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0.5 to 3>audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 2.5f}, {"zpos", 96.0f}})});
        Engine._history = false;
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
        yield return _gameMethods.OpenDialog(6571); // "然后，他动了。"
        yield return _gameMethods.OpenDialog(6572); // "他向我走近。"
        yield return _gameMethods.OpenDialog(6573); // "是不是下一秒就会动手呢。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan3", "zui2"});
        yield return _gameMethods.OpenDialog(6574); // "他抬起手。"
        yield return _gameMethods.OpenDialog(6575); // "是不是立刻会露出利爪..."
        yield return _gameMethods.Show("he", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 96.0f}})});
        yield return _gameMethods.Show("black", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 100f}})});
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/houhui/Body3 _01.mp3");
        yield return _gameMethods.Transition(time:0.3f);
        yield return _gameMethods.OpenDialog(6576); // "他将双臂揽在了我的背后。"
        yield return _gameMethods.OpenDialog(6577); // "啊………是拥抱。"
        yield return _gameMethods.OpenDialog(5698); // "他抱住了我。"
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/manbu/Body1_01.mp3");
        yield return _gameMethods.OpenDialog(5699); // "于是，我也抬起双手，轻轻搂住他。"
        yield return _gameMethods.OpenDialog(6578); // "填满了胸怀的瘦削身体..."
        yield return _gameMethods.OpenDialog(6579); // "除了低于人类的体温..."
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/houhui/Grab Hand_01.mp3");
        yield return _gameMethods.OpenDialog(6580); // "我拍了拍他的脊背。"
        yield return _gameMethods.OpenDialog(6581); // "指腹传导来马甲面料光滑柔软的触感。"
        yield return _gameMethods.PlaySound("soundc", 0.0f, 0.5f, "audio/demo_audio/sound/xintiao.ogg");
        yield return _gameMethods.OpenDialog(6582); // "心脏……在胸腔的第五根到第七根肋骨之间。"
        yield return _gameMethods.OpenDialog(6583); // "但从背后，这个姿势对我而言太陌生了..."
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/houhui/Body3 _01.mp3");
        yield return _gameMethods.StopSound(channelName:"soundc", fadeOut:1f);
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
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei1", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(5701); // "其实，我还给你准备了一份礼物。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei1", "yan8", "zui3"});
        yield return _gameMethods.OpenDialog(5702); // "本来是想作为你今年的生日礼物的..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan29", "zui2"});
        yield return _gameMethods.OpenDialog(6584); // "为什么我还在说这些。"
        yield return _gameMethods.OpenDialog(6585); // "我还在指望着他反驳..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2"});
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/juezhan_1_1b9cd915.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("he_qian");
        yield return _gameMethods.OpenDialog(6456); // "「……{nw}{w=0.01}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
        yield return _gameMethods.OpenDialog(1265); // "……」"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(5705); // "我们对视了几秒。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(5706); // "赫泽尔，闭上眼睛。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.65f}, {"zpos", -24f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(5707); // "在决战开始之前，让我最后给你一份礼物。"
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:15f);
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
        Engine._history = false;
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
        yield return _gameMethods.OpenDialog(5709); // "他面无表情地盯了我片刻。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -24f}})});
        yield return _gameMethods.OpenDialog(5710); // "我的心情意外地平静。"
        yield return _gameMethods.OpenDialog(5711); // "我们安静地对视，"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui2"});
        yield return _gameMethods.OpenDialog(5712); // "他垂了垂眼睛，"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
        yield return _gameMethods.OpenDialog(5713); // "那双血红的眼瞳缓缓闭合。"
        yield return _gameMethods.OpenDialog(5714); // "就像一个与此情此景毫无关联的旁观者一样..."
        yield return _gameMethods.OpenDialog(5715); // "精致而年轻，骄傲而稚嫩。"
        yield return _gameMethods.OpenDialog(5716); // "这是同我一起朝夕相处了三年的龙。"
        yield return _gameMethods.OpenDialog(6586); // "我们一起吃饭，一起睡觉。"
        yield return _gameMethods.OpenDialog(6587); // "他为我采购食物，教我知识。"
        yield return _gameMethods.OpenDialog(5717); // "即便在当下的战场上，他也毫无戒备地向我闭上双眼。"
        yield return _gameMethods.OpenDialog(6588); // "是对我的信任，还是料定我不会产生任何威胁？"
        yield return _gameMethods.OpenDialog(6589); // "我的心中百感交集..."
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/houhui/Grab Hand_01.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -24f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.65f}, {"zpos", -40f}})});
        yield return _gameMethods.OpenDialog(6590); // "我伸出手，轻轻地抚摸了他的脸庞。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei4", "yan25", "zui2"});
        yield return _gameMethods.OpenDialog(5719); // "赫泽尔的睫毛微微颤动了一下..."
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -40f}})});
        yield return _gameMethods.PlaySound("sounda", 0.2f, 0.4f, "audio/demo_audio/sound/moca2.mp3");
        yield return _gameMethods.OpenDialog(5720); // "我收回了手。"
        yield return _gameMethods.OpenDialog(5721); // "赫泽尔耐心地等待着。"
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.PlaySound("sounda", 0.0f, 0.3f, "<silence 0.5>audio/sound/juezhan_dao/tinnitus1.mp3");
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<silence 0.2>audio/sound/juezhan2/Blade Stab Cut Body Blood_01.ogg");
        yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:1f);
        yield return _gameMethods.Scene("tongdaozi_cg_layered", parts: new List<string>{"d_mei2", "d_yan3", "d_zui3"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.01f)}, {"zoom", 0.52f}})});
        yield return _gameMethods.Show("black");
        yield return _gameMethods.Show("bishou2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"rotate", 31.0f}, {"zoom", 0.28f}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(0.54f, 0.96f)}, {"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"parallel_0", true}, {"easein", 0.3f}, {"pos", new Vector2(0.39f, 1.06f)}}), new SameLineParamData(new Dictionary<string, object>{{"parallel_1", true}, {"pause", 0.15f}, {"easein", 0.15f}, {"alpha", 1.0f}})});
        yield return _gameMethods.Show("erhuan_guang1_ani", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.62f, 1.2f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"rotate", -48.0f}, {"zoom", 0.71f}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.5f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"alpha", 1f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-126f, 114f)}, {"zpos", -300.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
        Defaults.Gui_duihuakuang_you = 0;
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.Show("black", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"alpha", 0f}})});
        yield return _gameMethods.Show("bishou2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"alpha", 0f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-126f, 114f)}, {"zpos", -300.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 2f}, {"zpos", -270f}})});
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.Hide("erhuan_guang1_ani");
        yield return _gameMethods.Transition(time:0.8f);
        yield return _gameMethods.OpenDialog(6591); // "——然后，他的呼吸一滞，浑身僵住了。"
        yield return _gameMethods.Show("2-28_zoom");
        yield return _gameMethods.Hide("2-28_zoom");
        yield return _gameMethods.Hide("black");
        yield return _gameMethods.Hide("bishou2");
        yield return _gameMethods.ExecuteCharacterImageData("he");
        yield return _gameMethods.OpenDialog(47); // "……！"
        yield return _gameMethods.PlaySound("music1", 0.0f, 0.6f, "audio/music/juezhan/ran_theme_004.mp3");
        yield return _gameMethods.OpenDialog(5724); // "突然他意识到自己已无法控制四肢..."
        yield return _gameMethods.OpenDialog(6592); // "枝干的魔力令他失去了力气。"
        yield return _gameMethods.OpenDialog(6593); // "枝干，抵在了他的背上。"
        yield return _gameMethods.ExecuteCharacterImageData("he");
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 114f}, {"zpos", -270f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 2f}, {"ypos", -42f}})});
        yield return _gameMethods.OpenDialog(5725); // "他双眼撑大，对眼前景象感到茫然一般..."
        yield return _gameMethods.OpenDialog(5726); // "那张向来平静淡漠的孩子般的脸庞上..."
        yield return _gameMethods.Show("tongdaozi_cg_layered", parts: new List<string>{"d_yan1"});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(6594); // "我紧紧盯着他。"
        yield return _gameMethods.OpenDialog(6595); // "——如果带着多余的情绪..."
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -42f}})});
        yield return _gameMethods.OpenDialog(6596); // "所以，必须不带感情地使出这一招。"
        yield return _gameMethods.OpenDialog(6597); // "满怀爱意地使出这一招。"
        yield return _gameMethods.OpenDialog(6598); // "这一招我已经练习了无数遍。"
        yield return _gameMethods.OpenDialog(6599); // "所以，绝对不会失误。"
        yield return _gameMethods.OpenDialog(6600); // "孱弱的呼吸声停在耳边。"
        yield return _gameMethods.OpenDialog(6601); // "坚硬的枝干在我手心中发凉。"
        yield return _gameMethods.OpenDialog(3621); // "是啊。"
        yield return _gameMethods.OpenDialog(6602); // "没有波澜壮阔的战斗。没有热血激昂的拼搏。"
        yield return _gameMethods.OpenDialog(6603); // "这个童话以威胁开场。"
        yield return _gameMethods.Show("tongdaozi_cg_layered", parts: new List<string>{"d_mei1", "d_yan2"});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(6604); // "中间充满了欺诈与诡计，其结局则潦草而荒唐。"
        yield return _gameMethods.PlaySound("soundb", 0.0f, 5f, "audio/sound/manbu/Heartbeat Slow Motion_01.ogg");
        yield return _gameMethods.OpenDialog(6605); // "心脏狂跳。血液沸腾。"
        yield return _gameMethods.OpenDialog(6606); // "我感到内心波涛汹涌..."
        yield return _gameMethods.ExecuteCharacterImageData("nv2");
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("tongdaozi_cg_layered", parts: new List<string>{"d_zui2", "d_yan3"});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(0f, 0f)}, {"zpos", 0f}})});
        yield return _gameMethods.Transition(time:0.8f);
        yield return _gameMethods.OpenDialog(6607); // "我张开嘴。"
        yield return _gameMethods.OpenSelectMenu(talk: new List<string>{"—我爱你"}, jump: new List<string>{"label_juezhan_menu_1_woaini"}, condition: new List<string>{"NONE"});
    }

    public IEnumerator label_juezhan_2()
    {
        if (Defaults.Bai_xin == 1 && Defaults.Bai_kiss == 0)
        {
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:6f);
            yield return _gameMethods.ChangeLabelTo("label_tuanzhan_you");
        }
        else
        {
            yield return _gameMethods.ChangeLabelTo("label_end1");
        }
    }
}
