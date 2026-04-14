    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class zhuxian_3 : ILabelProvider
    {
        private GameMethods _gameMethods;

        public zhuxian_3(GameMethods gameMethods)
        {
            _gameMethods = gameMethods;
        }

            public IEnumerator label_zhuxian_3()
        {
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan29", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2681); // "{nw}{w=0.2}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei9", "yan24", "zui2", "emoji12"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(2682); // "……？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan25", "zui21", "emoji12"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan21", "zui3", "emoji12"});
            Defaults.Persistent.Jq_3_3 = 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan3", "zui15", "emoji12"});
            yield return _gameMethods.OpenDialog(2684); // "好像听到了什么声音。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/door_qiao2.ogg", "<from 0 to 0.3>audio/demo_audio/sound/door_qiao2.ogg");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan3", "zui15", "-emoji12"});
            yield return _gameMethods.OpenDialog(2685); // "——咚咚咚。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan2", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(2686); // "不是幻觉。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui10", "-emoji2"});
            yield return _gameMethods.OpenDialog(2687); // "赫泽尔，是不是有人在敲门？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan25", "zui2", "emoji12"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan27", "zui2", "-emoji12"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_3_f392fbae.ogg");
            yield return _gameMethods.OpenDialog(2688); // "……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan25", "zui13"});
            yield return _gameMethods.PlaySound("sounda", 0.0f, 0.7f, "audio/demo_audio/sound/canpanpengzhuang1.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_3_e05c165d.ogg");
            yield return _gameMethods.OpenDialog(2689); // "你听错了。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan22", "zui2"});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.2f, "audio/demo_audio/sound/door_qiao2.ogg", "audio/demo_audio/sound/door_qiao2.ogg", "audio/demo_audio/sound/door_qiao2.ogg");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(2690); // "咚咚咚咚咚。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan22", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(2691); // "不，"
            yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/demo_audio/music/qingkuai2.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2692); // "这绝对是有人在敲门吧！！"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan25", "zui9"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan25", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei3", "yan22", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(2688); // "……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan28", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(2693); // "但赫泽尔依然恍若未闻般，不紧不慢地用着早餐。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui15"});
            yield return _gameMethods.OpenDialog(2694); // "太神奇了，他明明没怎么进食过，却无师自通地掌握了人类的用餐礼仪，动作优雅，充满风度。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15"});
            yield return _gameMethods.OpenDialog(2695); // "我也只能跟着慢慢吃早饭。"
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(2688); // "……"
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/heilong_chufang_baitian_man2.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, -0.27f)}, {"zoom", 0.96f}, {"anchor", new Vector2(0.5f, 1f)}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(2696); // "直到结束早餐，听见我说还得洗碗后，{nw}{w=0.1}"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1>audio/demo_audio/sound/zu3_nv_zou.ogg");
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/emeng_dajie/magic1.ogg");
            yield return _gameMethods.PlaySound("sounda1", 0.0f, 2f, "<silence 0.3>", "audio/demo_audio/sound/canpanpengzhuang2_duan.mp3", "audio/sound/dashuizhang/Small Splash_01.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2697); // "赫泽尔直接把残羹剩饭隔空碾成了齑粉，碗勺放到水下一冲就彻底干净了。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan5", "zui15", "emoji7", "emoji15"});
            yield return _gameMethods.OpenDialog(2698); // "……全自动厨余处理机！"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan12", "zui15", "-emoji7", "emoji15"});
            yield return _gameMethods.OpenDialog(2699); // "实在是太伟大了，毁灭之龙的权柄无所不能。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15", "-emoji15"});
            yield return _gameMethods.OpenDialog(2700); // "…………"
            yield return _gameMethods.OpenDialog(2701); // "………………"
            yield return _gameMethods.OpenDialog(2702); // "他又慢吞吞地等了十几分钟，{nw}{w=0.1}"
            yield return _gameMethods.PlaySound("soundb", 0.0f, 1.0f, "audio/demo_audio/sound/zu3_nv_zou.ogg");
            yield return _gameMethods.ShowBlack(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2703); // "最后才带头走出了厨房。"
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:2f);
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:2f);
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<from 0 to 1>audio/demo_audio/sound/door_open1.mp3");
            yield return _gameMethods.PlaySound("sounda1", 0.0f, 2f, "<silence 1>", "audio/sound/small_explosion2.mp3");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_dating_men_baitian.jpg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(0f, 0f)}, {"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.34f}, {"pos", new Vector2(0f, -102f)}, {"zpos", -210.0f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(2704); // "赫泽尔拉开门，看都没看门外一眼，就是一发黑色的能量球轰出了出去。"
            yield return _gameMethods.PlaySound("sounda2", 0.0f, 1.0f, "audio/sound/manbu/Body1_01.mp3");
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.ExecuteCharacterImageData("nuo");
            yield return _gameMethods.OpenDialog(2705); // "真是不友好的接待啊。"
            yield return _gameMethods.SaveLastVoiceToTheEnd();
            yield return _gameMethods.PlaySound("music", 0.0f, 0.7f, "audio/demo_audio/music/time_syuanji.mp3");
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1.5>audio/sound/jiaobusheng_nuo_normal1.ogg");
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei6", "yan1", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.37f, 1.95f)}, {"zoom", 0.39f}, {"zpos", 0.0f}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ease", 0.8f}, {"zpos", 90.0f}})});
            yield return _gameMethods.Transition(time:0.8f);
            yield return _gameMethods.OpenDialog(2706); // "从雾气与黑烟中，浮现出一个人影。"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 2f, "audio/sound/manbu/Body1_02_duan.mp3");
            yield return _gameMethods.Hide("nuo1");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_dating_men_baitian.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.86f)}, {"zoom", 1.9f}})});
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.37f, 1.95f)}, {"zoom", 0.39f}, {"zpos", 90.0f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(2707); // "冰霜之龙——诺伯拉笑眯眯地挥了挥手。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui3"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_3_14f3bf9c.ogg");
            yield return _gameMethods.OpenDialog(2708); // "哟，我来找你玩咯。"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<from 0 to 1>audio/demo_audio/sound/zu3_nv_zou.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.9f}, {"pos", new Vector2(-66f, 30f)}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan25", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0f, 0f)}, {"pos", new Vector2(192f, 204f)}, {"zoom", 0.33f}, {"zpos", 90.0f}, {"alpha", 0f}, {"xoffset", -100f}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.2f}, {"alpha", 1f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.7f}, {"xoffset", 0f}})});
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.37f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.7f}, {"xpos", 0.4f}})});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan24", "zui16", "emoji2"});
            yield return _gameMethods.OpenDialog(2709); // "黑暗之龙面若冰霜。 "
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-66f, 30f)}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan27", "zui9"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}, {"xoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_3_87da8a4a.ogg");
            yield return _gameMethods.OpenDialog(2710); // "你不知道未经邀请，冒然上门是失礼之举吗。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.5>audio/sound/jiaobusheng_nuo_normal1.ogg");
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei6", "yan4", "zui5"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.31f}, {"xpos", 0.43f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_3_919c0fab.ogg");
            yield return _gameMethods.OpenDialog(2711); // "哎呀，看来很不欢迎我嘛。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei6", "yan4", "zui9"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.43f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2712); // "诺伯拉故作受惊，{nw}{w=0.1}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei6", "yan2", "zui7"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2713); // "很快又笑眯眯了。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui13"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei7", "yan12", "zui16", "emoji2"});
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan24", "zui16", "emoji2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_3_4ddbfb64.ogg");
            yield return _gameMethods.OpenDialog(2714); // "不过，尼德霍格。"
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(2715); // "「我们毕竟是同族，{nw}{w=0.1}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei9", "yan19", "zui2", "emoji11"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(2716); // "所以，还是让我们好好相处吧。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/houhui/Tight Face_02_duan.mp3");
            yield return _gameMethods.Show("he", parts: new List<string>{"mei9", "yan17", "zui21", "emoji11"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(2717); // "……！"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei9", "yan17", "zui2", "emoji11"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui15", "-emoji2", "emoji12"});
            yield return _gameMethods.OpenDialog(2682); // "……？"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15", "-emoji12"});
            yield return _gameMethods.OpenDialog(2718); // "诺伯拉明明说的是充满和平与爱的话语，赫泽尔却不爽地眯起眼睛，仿佛被挑衅了一般。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei9", "yan25", "zui2", "emoji11"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei9", "yan17", "zui2", "emoji11"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui15", "emoji3"});
            yield return _gameMethods.OpenDialog(2719); // "那句话里隐藏了什么潜台词吗？"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui8"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui15", "-emoji3"});
            yield return _gameMethods.OpenDialog(2720); // "我没有出声，诺伯拉却已然知晓似的看向了我，进行解释。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(2721); // "「因为龙类之间同族互残，会激发血脉内蕴藏的古代诅咒，{nw}{w=0.1}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan14", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_3_c2a8da3f.ogg");
            yield return _gameMethods.OpenDialog(2722); // "以灾厄之龙的位格，{nw}{w=0.1}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_3_91370503.ogg");
            yield return _gameMethods.OpenDialog(2723); // "大概也要陷入沉睡至少一百年吧。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
            if (Defaults.Bai_xiu == 0)
            {
                                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan24", "zui16", "emoji2"});
                yield return _gameMethods.OpenDialog(2724); // "……虽然得到了解释，但是我讨厌读心术。"

            }
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan24", "zui9", "-emoji11"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(2725); // "这不代表我没有手段对付你，你应该明白。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei3", "yan5", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(2726); // "是呀，我也很担心风险。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan24", "zui2"});
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.OpenDialog(2727); // "但是，毕竟我就是想来找你玩呢。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei9", "yan24", "zui2", "emoji11"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(2700); // "…………"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1>audio/sound/jiaobusheng_nuo_normal1.ogg");
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.43f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.5f}, {"xpos", 0.42f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei9", "yan24", "zui2", "emoji11"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(2728); // "「况且，尼德霍格，{nw}{w=0.1}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan20", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_3_8aa12868.ogg");
            yield return _gameMethods.OpenDialog(2729); // "没人能阻止鲜花盛开，{nw}{w=0.1}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_3_f61f25e6.ogg");
            yield return _gameMethods.OpenDialog(2730); // "也没人能阻挡她吸引蜜蜂与蝴蝶。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui3"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.42f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei3", "yan22", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(2731); // "对吗，小公主？"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui8"});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei9", "yan16", "zui2", "emoji11", "emoji12"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1");
            yield return _gameMethods.OpenDialog(2688); // "……"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan20", "zui16", "emoji2", "emoji6"});
            yield return _gameMethods.OpenDialog(2732); // "好一道送命题。"
            yield return _gameMethods.OpenSelectMenu(talk: new List<string>{"-确实有道理", "-不，尼德霍格无所不能", "-秘技！！社畜之装傻充楞"}, jump: new List<string>{"label_zhuxian_3_menu_0_2geSYaMv", "label_zhuxian_3_menu_0_QNNRTPAa", "label_zhuxian_3_menu_0_3Te3Fbs0"}, condition: new List<string>{"NONE", "NONE", "NONE"});
        }

        public IEnumerator label_choice15()
        {
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan7", "zui2"});
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei3", "yan2", "zui15", "emoji2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice19_482a173f.ogg");
            yield return _gameMethods.OpenDialog(2688); // "……"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui8"});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei18", "yan25", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei3", "yan2", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(2761); // "「…………{nw}{w=0.3}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei18", "yan15", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice15_b64ff75a.ogg");
            yield return _gameMethods.OpenDialog(2762); // "这不可能。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei18", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei1", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(2763); // "按照自然同我的契约，人选需要在这座城堡下的魔法阵中待够三年，才能满足完成预言的条件。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan25", "zui13"});
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan20", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice15_463c6479.ogg");
            yield return _gameMethods.OpenDialog(2764); // "「现在三年之中，一年已过，{nw}{w=0.1}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan27", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice15_5783f035.ogg");
            yield return _gameMethods.OpenDialog(2765); // "剩下的时间已经不足以更换人选了。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan27", "zui2"});
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan20", "zui15"});
            yield return _gameMethods.OpenDialog(2688); // "……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan15", "zui2"});
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice15_0a190589.ogg");
            yield return _gameMethods.OpenDialog(2766); // "真可惜。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice15_d64b8ff2.ogg");
            yield return _gameMethods.OpenDialog(2767); // "下次和我一起出去约会吧，小公主~"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan3", "zui2"});
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei8", "yan17", "zui15"});
            yield return _gameMethods.OpenDialog(2768); // "我可以带你去附近的湖边散步。附近总还是可以的。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan24", "zui3", "emoji10"});
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(2769); // "……真的吗？"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(2770); // "我不禁有些心驰神往。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2771); // "我很想外出。{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui15"});
            yield return _gameMethods.OpenDialog(2772); // "虽然不清楚这只是他嘴巴说说，还是真有把握能做到把我带出去。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan25", "zui3", "-emoji10", "emoji12"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan24", "zui3", "emoji12"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(2773); // "不过既然赫泽尔在身边，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan11", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(2774); // "我只是对诺伯拉假笑了一下，没有接话。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei8", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei1", "yan11", "zui7", "-emoji2"});
            yield return _gameMethods.OpenDialog(2688); // "……"
            if (Defaults.Bai_xiu == 0)
            {
                                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan5", "zui7", "emoji2"});
                yield return _gameMethods.OpenDialog(2775); // "……啊，他有读心能力来着。"
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan8", "zui7", "-emoji2"});
                yield return _gameMethods.OpenDialog(2776); // "估计对我的想法一清二楚了吧。"

            }
            yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan25", "zui3", "emoji12"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan12", "zui6", "emoji2"});
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan15", "zui2", "-emoji12"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2777); // "我能怎么办呢，我只是一个弱小的人类而已。"
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:4f);
            yield return _gameMethods.StopSound(channelName:"music1", fadeOut:4f);
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei1", "yan2", "zui8"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei1", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan12", "zui6", "-emoji2"});
            yield return _gameMethods.OpenDialog(2688); // "……"
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(2778); // "在赫泽尔的虎视眈眈下，诺伯拉没过多久就离开了。"
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_dating_baitian.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.06f)}, {"zoom", 0.75f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan15", "zui2", "-emoji12"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 2.03f)}, {"zoom", 0.41f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(2701); // "………………"
            Defaults.Persistent.Jq_3_4 = 1;
            yield return _gameMethods.PlaySound("music", 2f, 0.6f, "audio/music/PerituneMaterial_Guitar_Gentle_loop.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2779); // "前者沉默了好一阵子。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(2780); // "感觉他心情不太好，在生闷气似的。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui15"});
            yield return _gameMethods.OpenDialog(2781); // "这可不是好事，上司心情不好，身旁的下属就很容易被殃及池鱼。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2782); // "我想了想。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.5>audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.22f}, {"zpos", -12.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(2783); // "那，赫泽尔，不如我们一起出去散步吧。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -12.0f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(2682); // "……？"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/manbu/Body1_02_duan.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2784); // "他转头向我看来。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan17", "zui7"});
            yield return _gameMethods.OpenDialog(2785); // "我把双手背在身后，笑眯眯地扬起嘴角。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}, {"zpos", -12.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"ypos", -60f}, {"zpos", -156.0f}})});
            yield return _gameMethods.PlaySound("sound", 0.0f, 3f, "audio/sound/manbu/Body1_02_duan.mp3");
            yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan11", "zui4"});
            yield return _gameMethods.OpenDialog(2786); // "「冰霜之龙不是说要带我去散步吗？{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui2"});
            yield return _gameMethods.OpenDialog(2787); // "下次再碰见，我就可以狠狠地拒绝他，说：」"
            Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv", parts: new List<string>{"mei7", "yan12", "zui11"});
            yield return _gameMethods.OpenDialog(2788); // "‘对不起，我已经和赫泽尔约会过了。不需要你了。’"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -60f}, {"zpos", -156.0f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan29", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(2688); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2789); // "他一言不发，静静地盯着我。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(2790); // "直到我开始内心怀疑自己是否说错话了，{nw}{w=0.1}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan22", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2791); // "才微微垂眸转开视线。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan22", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(2792); // "……嗯。可以。"
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice15_a6ecbebc.ogg");
            yield return _gameMethods.OpenDialog(2793); // "什么时候。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan22", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan6", "zui10"});
            yield return _gameMethods.OpenDialog(2794); // "你有空，并且也有兴趣的时候…？"
            yield return _gameMethods.Show("he", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.5f}, {"zpos", 6.0f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan27", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan6", "zui15"});
            yield return _gameMethods.OpenDialog(2795); // "现在？"
            yield return _gameMethods.Show("he", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 6.0f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan10", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(2796); // "你好积极，也好闲。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19", "-emoji2"});
            yield return _gameMethods.OpenDialog(2797); // "嗯，可以啊。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan15", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui2"});
            yield return _gameMethods.OpenDialog(2798); // "不过，约会的话，要走程序的。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1");
            yield return _gameMethods.OpenDialog(2799); // "你应该先邀请我。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice15_d5cba1de.ogg");
            yield return _gameMethods.OpenDialog(2800); // "怎么邀请。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui2"});
            yield return _gameMethods.OpenDialog(2801); // "朝我伸出手掌就好了。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(2688); // "……"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.5f, "audio/sound/manbu/Body1_01.mp3");
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.5f, "<from 0 to 1>audio/demo_audio/sound/zu3_nv_zou.ogg");
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan28", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"ypos", 2.03f}, {"zpos", 6.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.8f}, {"anchor", new Vector2(0.5f, 1.0f)}, {"ypos", 2.05f}, {"zpos", 78.0f}})});
            yield return _gameMethods.OpenDialog(2802); // "他依言伸出手，对我露出纹路浅淡、干干净净的掌心。"
            yield return _gameMethods.Show("he", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"ypos", 2.05f}, {"zpos", 78.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui8"});
            yield return _gameMethods.OpenDialog(2803); // "我轻快地抬手搭在其上。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan13", "zui2"});
            yield return _gameMethods.PlaySound("sounda2", 0.0f, 1.5f, "<silence 0.9>", "audio/sound/houhui/Grab Hand_01.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2804); // "似乎不太清楚该怎么做一般，赫泽尔有些迟疑的、生疏地收拢五指握住。"
            yield return _gameMethods.PlaySound("sounda1", 0.0f, 0.4f, "audio/demo_audio/sound/moca6_duan_duan.mp3");
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui8"});
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui7"});
            yield return _gameMethods.OpenDialog(2805); // "我也回握住他。"
            Defaults.Gui_duihuakuang_you = 0;
            yield return _gameMethods.PlaySound("sounda", 1f, 0.5f, "<silence 0.6>", "audio/demo_audio/sound/moca2.mp3");
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/tianshou/qianshou_zhengchang.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0f, 0f)}, {"pos", new Vector2(114f, 6f)}, {"zoom", 0.55f}, {"zpos", 78.0f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -250.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 1.2f}, {"zpos", -156.0f}})});
            
            yield return _gameMethods.OpenDialog(2806); // "将交握的双手下垂到两人的腿侧之间。"
            yield return _gameMethods.OpenDialog(2807); // "就这样手拉手，准备出门郊游。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui7"});
            yield return _gameMethods.OpenDialog(2701); // "………………"
            yield return _gameMethods.PlaySound("sound", 0.5f, 1.5f, "audio/sound/emeng_dajie/Scuba Diver Wearing Wet Suit Tight Rubber Sleeve_01.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"zpos", -156.0f}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -2f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 2f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(2808); // "这时，被我握住的那只手却挣动了一下。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui7", "-emoji2"});
            yield return _gameMethods.OpenDialog(2809); // "大概是不习惯，想摆脱束缚吧。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui7"});
            yield return _gameMethods.OpenDialog(2810); // "我善解人意地松开了力道，任由他抽离。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui7"});
            yield return _gameMethods.OpenDialog(2811); // "男孩的指头划过我的指尖，没有离开，"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/houhui/Tight Face_02_duan.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -156.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.8f}, {"zpos", -198.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2812); // "而是挤进了我张开些许的指缝中。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -198.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(2813); // "……！惊讶之中，我没来得及挣扎。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/moca3.mp3");
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/tianshou/qianshou_woshou.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0f, 0f)}, {"pos", new Vector2(114f, 6f)}, {"zoom", 0.55f}, {"zpos", 78.0f}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1f}})});
            yield return _gameMethods.Show("_zoom");
            yield return _gameMethods.Hide("_zoom");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(2814); // "接着，他的五指进一步插入得更深，穿过我手指的间隙。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan21", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(2815); // "牢牢地扣住了我的手背，迫使两个掌心紧密地贴合到了一起。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/tianshou/qianshou_woshou.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(2700); // "…………"
            yield return _gameMethods.OpenSelectMenu(talk: new List<string>{"-顺从", "-挣动", "-回应"}, jump: new List<string>{"label_zhuxian_3_menu_0_VuG7naFr", "label_zhuxian_3_menu_0_1ZhZMA1r", "label_zhuxian_3_menu_0_rFFPcqla"}, condition: new List<string>{"NONE", "NONE", "NONE"});
        }

        public IEnumerator label_choice16()
        {
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_dating_baitian.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.06f)}, {"zoom", 0.75f}})});
            Defaults.Gui_duihuakuang_you = 1;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 2.03f)}, {"zoom", 0.41f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -90f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -276f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(2688); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(2835); // "我忍不住转头看他。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2836); // "他若有所感，于是侧回过脸，同样盯着我。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(2837); // "你握得好紧啊。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan11", "zui7", "-emoji2"});
            yield return _gameMethods.OpenDialog(2838); // "嗯。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2839); // "他一点也没放松。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan10", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(2840); // "…这就是你们龙在外出时对于所拥有财产的看守的严密程度吗。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(2841); // "令人类甘拜下风。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan24", "zui7", "-emoji2"});
            yield return _gameMethods.OpenDialog(2842); // "我安慰自己。他大概还是控制了力道的，不然我估计要痛得不行了。"
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_dating_baitian.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.06f)}, {"zoom", 0.75f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -78f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -246f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_dating_men_baitian.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.04f)}, {"zoom", 0.89f}})});
            yield return _gameMethods.TransitionBy("blink2");
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.5>audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:8f);
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan2", "zui2", "emoji7"});
            yield return _gameMethods.OpenDialog(2843); // "出发！"
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei8", "yan2", "zui7", "-emoji7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice16_11ddb8fa.ogg");
            yield return _gameMethods.OpenDialog(2838); // "嗯。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan2", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 2.03f)}, {"zoom", 0.41f}})});
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_dating_men_baitian.jpg");
            yield return _gameMethods.TransitionBy("blink2");
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.5f, "audio/sound/manbu/Body1_02_duan.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(2688); // "……"
            Defaults.Persistent.Jq_3_5 = 1;
            yield return _gameMethods.OpenDialog(2844); // "不知为何，赫泽尔忽然僵住在原地。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan2", "zui2"});
            yield return _gameMethods.PlaySound("sounda2", 0.0f, 1.0f, "audio/sound/houhui/Grab Hand_01.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2845); // "他又紧了紧那只握着我的手，将掌心愈发贴合。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.5>audio/demo_audio/sound/zu3_nv_zou.ogg");
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/manbu/Body1_01.mp3");
            yield return _gameMethods.Show("he", parts: new List<string>{"mei9", "yan28", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.24f}, {"zpos", 18.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2846); // "他怔愣了一会儿，似乎发现什么，忽然抓起我的手，掰开五指。"
            yield return _gameMethods.Show("he", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 18.0f}})});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice19_6c5789c3.ogg");
            yield return _gameMethods.OpenDialog(2847); // "？"
            yield return _gameMethods.PlaySound("sound", 0.0f, 2f, "audio/sound/houhui/Hint_01.mp3");
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/fenjin/shou_ba.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(168f, 0f)}, {"anchor", new Vector2(0f, 0f)}, {"zoom", 0.49f}, {"zpos", 18.0f}})});
            Defaults.Gui_duihuakuang_you = 0;
            yield return _gameMethods.Show("_zoom");
            yield return _gameMethods.Hide("_zoom");
            yield return _gameMethods.Transition(time:0.7f);
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(2688); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan1", "zui15"});
            yield return _gameMethods.OpenDialog(2848); // "掌心被暴露在视野中。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1");
            yield return _gameMethods.OpenDialog(2688); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2849); // "几道极其显眼的伤疤。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan21", "zui15"});
            yield return _gameMethods.OpenDialog(2850); // "……哦。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2851); // "那是我来到这里第一天时，为了紧抓他的鳞片而割裂的伤口。"
            yield return _gameMethods.PlaySound("music", 3f, 0.5f, "audio/music/qiyi1.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2852); // "因为这里缺乏医疗物品，而他把我带来后也一副急于摆脱麻烦的样子，懒得看我便径自走开了。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan20", "zui15"});
            yield return _gameMethods.OpenDialog(2853); // "……现在想想，以龙的嗅觉，当时其实能轻易地嗅到腥气。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(2854); // "那就是单纯不想管了。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan21", "zui15"});
            yield return _gameMethods.OpenDialog(2855); // "总之，我只用路上收集的草药随便涂了涂。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2856); // "大概是消毒不及时或不彻底，伤口虽然愈合了，但留下了疤痕。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei9", "yan28", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(2857); // "不过不影响功能，无伤大雅。我已经很满足了。"
            yield return _gameMethods.Hide("Assets/RenpyResources/images/cg/fenjin/shou_ba.jpg");
            yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan7", "zui21"});
            Defaults.Gui_duihuakuang_you = 1;
            yield return _gameMethods.Transition(time:0.5f);
            yield return _gameMethods.ExecuteCharacterImageData("he_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice19_319a57d4.ogg");
            yield return _gameMethods.OpenDialog(2858); // "「……{nw}{w=0.3}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_qian");
            yield return _gameMethods.OpenDialog(2859); // "……」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(2688); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2860); // "……啊。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2861); // "赫泽尔。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan17", "zui15"});
            yield return _gameMethods.OpenDialog(2862); // "你这是什么表情？"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan20", "zui15"});
            yield return _gameMethods.OpenDialog(2863); // "事到如今了，难道还要突然在意起这个么。"
            yield return _gameMethods.OpenSelectMenu(talk: new List<string>{"-聊起伤疤", "-聊起伤疤", "-聊起伤疤"}, jump: new List<string>{"label_zhuxian_3_menu_0_0IL8gWTS", "label_zhuxian_3_menu_0_0IL8gWTS", "label_zhuxian_3_menu_0_0IL8gWTS"}, condition: new List<string>{"NONE", "NONE", "NONE"});
        }

        public IEnumerator label_choice17()
        {
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(2688); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(2864); // "没关系，早就不疼啦。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan17", "zui19"});
            yield return _gameMethods.OpenDialog(2865); // "再说了，都已经过去一年了，怎么突然想起来在意这个了嘛？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan13", "zui3", "emoji0", "emoji10"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei8", "yan17", "zui7"});
            yield return _gameMethods.OpenDialog(2700); // "…………"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(2866); // "……这个反应。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(2867); // "心中，稍微涌起了一股类似于满足的得意感。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(2868); // "但我嘴上状似轻松地说道。"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 0.5f, "audio/demo_audio/sound/moca2.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -258.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.50f}, {"zpos", -306.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(2869); // "其实无所谓的，我都习惯了。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan9", "zui3", "-emoji0", "-emoji10"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -306.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan5", "zui19"});
            yield return _gameMethods.OpenDialog(2870); // "你也知道，我本来不是公主。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan12", "zui2"});
            yield return _gameMethods.OpenDialog(2871); // "做公主前，其实就是个乡下的村姑。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan2", "zui19"});
            yield return _gameMethods.OpenDialog(2872); // "在田间被镰刀割伤是常有的事。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan13", "zui3", "emoji0", "emoji10"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan6", "zui11"});
            yield return _gameMethods.OpenDialog(2873); // "「冬天生冻疮也不是没烂过手，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan5", "zui4"});
            yield return _gameMethods.OpenDialog(2874); // "都正常。只不过痊愈了没留痕，现在看不到了而已。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan22", "zui3", "emoji0", "emoji10"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei8", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(2688); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan12", "zui19"});
            yield return _gameMethods.OpenDialog(2875); // "「况且，我一年前才刚被国王接回王宫，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan2", "zui2"});
            yield return _gameMethods.OpenDialog(2876); // "以前一直都是过这种日子。」"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan5", "zui2"});
            yield return _gameMethods.OpenDialog(2877); // "「所以没那么娇生惯养。{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(2878); // "又不是断胳膊断腿，都习惯啦。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan25", "zui3", "-emoji0", "-emoji10"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan11", "zui7"});
            yield return _gameMethods.OpenDialog(2700); // "…………"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei13", "yan15", "zui12", "emoji10"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice17_02721581.ogg");
            yield return _gameMethods.OpenDialog(2879); // "……别说了。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei13", "yan15", "zui3", "emoji10"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan20", "zui6"});
            yield return _gameMethods.OpenDialog(2880); // "是啊。不用说。{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2881); // "/n你都知道。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui6"});
            yield return _gameMethods.OpenDialog(2882); // "我在第一天就全告诉你了。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei13", "yan25", "zui3", "-emoji10"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei13", "yan15", "zui3", "emoji10"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan17", "zui15"});
            yield return _gameMethods.OpenDialog(2883); // "但你回答我。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2884); // "这双眼睛，证明了我身体里王室的血脉。所以，有资格充当人选。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei13", "yan9", "zui3", "emoji10"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(2885); // "现在，一年多过去了。{nw}{w=0.1}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei13", "yan15", "zui3", "emoji10"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2886); // "/n人选已无法更换。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei13", "yan25", "zui3", "-emoji10"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei13", "yan15", "zui3", "emoji10"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan20", "zui15"});
            yield return _gameMethods.OpenDialog(2887); // "尘埃已定，你注定夺走我的性命。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan22", "zui15"});
            yield return _gameMethods.OpenDialog(2888); // "那么、你现在，又摆出一副纠结的表情在做什么呢？"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2688); // "……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan13", "zui3", "emoji0", "emoji10"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"ypos", -114f}, {"zpos", -384.0f}})});
            yield return _gameMethods.TransitionBy("blink2");
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice19_96f01b9d.ogg");
            yield return _gameMethods.OpenDialog(2858); // "「……{nw}{w=0.3}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei15", "yan9", "zui3", "-emoji0", "emoji10"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(2859); // "……」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan13", "zui3", "emoji0", "emoji10"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan17", "zui15"});
            yield return _gameMethods.OpenDialog(2889); // "有点痛快。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(2890); // "——但同时也意识到，这种完全依附于对方的良心与情分的所谓“满足”，是一种多么可笑的自我感动。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(2891); // "他与我非亲非故。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan25", "zui3", "-emoji0", "-emoji10"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan13", "zui3", "emoji0", "emoji10"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2892); // "责怪他，就好像非要拉住街边一个不熟的过路人，揭开自己的衣摆，向他展示伤口哭诉一样，"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan21", "zui15"});
            yield return _gameMethods.OpenDialog(2893); // "甚至更糟，他就是我的敌人。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2894); // "尽管用笑闹装点了日常。{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan17", "zui15"});
            yield return _gameMethods.OpenDialog(2895); // "/n虽然在生活中他对我有诸多照顾之处。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan25", "zui3", "-emoji0", "-emoji10"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan13", "zui3", "emoji0", "emoji10"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2896); // "但在这一切的掩盖之下，我们之间实质性的关系，依然是看管者与被看管者。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan20", "zui15"});
            yield return _gameMethods.OpenDialog(2897); // "对自己的看管者卖惨，难道还要指望他心疼我吗？"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2898); // "这既起不到实际用处，又很可悲。{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan20", "zui15"});
            yield return _gameMethods.OpenDialog(2899); // "/n不过是弱者的顾影自怜。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2700); // "…………"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan25", "zui3", "-emoji0", "-emoji10"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(2900); // "算了。{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan9", "zui15"});
            yield return _gameMethods.OpenDialog(2901); // "还是换个话题方向——……"
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:6f);
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/zhenjing_shuaidaoganjue.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan1", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(2717); // "……！"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan25", "zui3"});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/houhui/Body3 _01.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
            yield return _gameMethods.OpenDialog(2902); // "赫泽尔忽然捏起我的手腕，同时低垂下头。"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/manbu/Body1_01.mp3");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/cg/tianshou/qianshou_cg.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.08f)}, {"zoom", 0.73f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-102f, 150f)}, {"zpos", -246.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            Defaults.Gui_duihuakuang_you = 0;
            yield return _gameMethods.Show("_zoom");
            yield return _gameMethods.Hide("_zoom");
            yield return _gameMethods.Transition(time:0.6f);
            yield return _gameMethods.PlaySound("music", 0.0f, 0.7f, "audio/music/Fall.mp3");
            yield return _gameMethods.OpenDialog(2903); // "他拉着我的手，贴近了自己。"
            yield return _gameMethods.PlaySound("soundb", 0.0f, 1.5f, "audio/sound/houhui/Lick Skin Saliva Amb_01.mp3");
            yield return _gameMethods.OpenDialog(2904); // "伸出手指，轻抚过掌心。"
            yield return _gameMethods.OpenDialog(2905); // "白皙的手指，顺着那些疤痕。/n晶莹的指甲映照着太阳，泛出亮晶晶的碎光。"
            yield return _gameMethods.OpenDialog(2906); // "指尖顺着掌心扫过指根的间缝，令敏感的肌肤微微发痒，让我感觉极其不适应。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}, {"ypos", 0f}, {"zpos", 0f}})});
            yield return _gameMethods.Transition(time:1f);
            yield return _gameMethods.OpenDialog(2907); // "他低垂着眼睑，安静无声地抚过每一寸皮肤。"
            yield return _gameMethods.OpenDialog(2908); // "这无济于事。"
            yield return _gameMethods.OpenDialog(2909); // "很显然，他掌握的是有关破坏的权柄，并不具备任何治愈的能力。"
            yield return _gameMethods.OpenDialog(2910); // "所以他只是轻抚着，而伤疤毫无改变。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(2700); // "…………"
            yield return _gameMethods.ExecuteCharacterImageData("nv", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(2911); // "（这种没用的行为，你做它是为了什么呢？）"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(2912); // "看着他的做法，我的内心……"
            yield return _gameMethods.OpenSelectMenu(talk: new List<string>{"-有些触动", "-毫无波动"}, jump: new List<string>{"label_zhuxian_3_menu_0_fjomO2Nf", "label_zhuxian_3_menu_0_ianLAW4g"}, condition: new List<string>{"NONE", "NONE"});
        }

        public IEnumerator label_choice19()
        {
            yield return _gameMethods.PlaySound("music1", 1f, 0.8f, "audio/music/chumen1.mp3");
            yield return _gameMethods.PlaySound("soundb", 2f, 6f, "audio/sound/dashuizhang/Bird Amb_01.ogg");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg33_memory.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg33_memory.jpg");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/senlin5.jpg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition(time:1f);
            Defaults.Persistent.Jq_3_6 = 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(2928); // "一年多了，除了几个月一次的采购物资外，我首次走出这座城堡。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2929); // "需要竭尽全力，才能不露出异常。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(2930); // "虽然想要仔细勘测周围的地形，但由于赫泽尔在我身边，我需要把注意力放在他身上。来陪伴他。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(2931); // "不能让他察觉我在搜集情报。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/senlin3.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(2688); // "……"
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/senlin3.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(2932); // "阳光明媚的户外。空气清新。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg32_memory.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg32_memory.jpg");
            yield return _gameMethods.PlaySound("soundc", 1f, 1.0f, "audio/sound/dashuizhang/Spilling Stream Into Creek Gurgling Water_01.ogg");
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/senlin6.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(2933); // "丰美的浆草上闪烁着露水。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/senlin6.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(2934); // "清澈的溪水，如同流动的玻璃。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg34_memory.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg34_memory.jpg");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/senlin4.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.02f)}, {"zoom", 0.69f}})});
            yield return _gameMethods.Transition(time:1f);
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:4f);
            yield return _gameMethods.StopSound(channelName:"soundc", fadeOut:8f);
            yield return _gameMethods.OpenDialog(2935); // "我们沿着溪流，到了一个湖泊边歇脚。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/dashuizhang/Water Splash Single Short_01.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(0f, 0f)}, {"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 1f}, {"pos", new Vector2(-96f, 90f)}, {"zpos", -330f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan11", "zui7", "emoji9"});
            yield return _gameMethods.OpenDialog(2936); // "我兴致勃勃地把双手浸入水面之下，拨动冰冷的湖水。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-96f, 90f)}, {"zpos", -330f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui7", "emoji10", "-emoji9"});
            yield return _gameMethods.OpenDialog(2937); // "而赫泽尔只是隔着一段距离，颇为矜持疏离般地在一边旁观。"
            yield return _gameMethods.PlaySound("sound", 0.4f, 1.0f, "audio/sound/dashuizhang/Water Splash Single Short_01.ogg");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2938); // "我玩了一会儿水，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan9", "zui7", "emoji7", "-emoji10"});
            yield return _gameMethods.OpenDialog(2939); // "就被水中的生物激发了嬉闹地兴致，开始逗弄湖里的小鱼小虾。"
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei3", "yan9", "zui7", "-emoji7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice19_cd44dcf4.ogg");
            yield return _gameMethods.OpenDialog(2940); // "你很高兴。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(2941); // "一旁的赫泽尔冷不丁地开口。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-96f, 90f)}, {"zpos", -330f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.46f}, {"pos", new Vector2(126f, -12f)}, {"zpos", -252f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.64f, 1.64f)}, {"zoom", 0.31f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.3f}, {"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(2942); // "我抬起头才发现，他似乎一直在观察我。"
            yield return _gameMethods.Show("he", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(126f, -12f)}, {"zpos", -252f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui19"});
            yield return _gameMethods.OpenDialog(2943); // "难道你不高兴吗？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice19_55586692.ogg");
            yield return _gameMethods.OpenDialog(2944); // "不，我只是不理解为什……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan9", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice19_dcce5443.ogg");
            yield return _gameMethods.OpenDialog(2945); // "「你好像每天都有值得开心的事。{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei3", "yan21", "zui8", "emoji7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice19_5da5d3a5.ogg");
            yield return _gameMethods.OpenDialog(2946); // "这很奇怪。」"
            yield return _gameMethods.PlaySound("sound", 0.0f, 3f, "audio/sound/dashuizhang/Water Splashing Gently Single Splash_01.ogg");
            yield return _gameMethods.Show("shuihua1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"blur", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.5f}, {"zoom", 1.03f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.98f}, {"xpos", 0.55f}, {"zoom", 0.8f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.39f}, {"ypos", 0.97f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.59f}, {"ypos", 1.11f}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.15f}, {"alpha", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.83f}, {"alpha", 0.0f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan11", "zui19", "emoji15", "-emoji7"});
            yield return _gameMethods.OpenDialog(2947); // "——哗啦！"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 2f, "audio/sound/dashuizhang/Water Splashing _01.mp3");
            yield return _gameMethods.Show("Assets/RenpyResources/images/texiao/shuihua1.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(0.55f, 1.11f)}, {"zoom", 0.8f}, {"alpha", 0.0f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan2", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei3", "yan2", "zui7", "emoji15"});
            yield return _gameMethods.OpenDialog(2717); // "……！"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan2", "zui2"});
            yield return _gameMethods.OpenDialog(2948); // "我猛地抬起水面下的双手，突然袭击式地向他泼了一捧水。"
            yield return _gameMethods.OpenDialog(2949); // "他猝不及防，脸上被劈头盖脸淋湿，/n那身宛如小少爷一般缎面马甲、丝绸衬衫的装束也被打湿，不复往日的整洁从容。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan2", "zui16", "-emoji15"});
            yield return _gameMethods.OpenDialog(2950); // "这个孩子骤然露出吃惊的表情，调高了眉毛，有些不可思议，甚至可以说是难以置信一般地朝我看来。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan2", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(2847); // "？"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei1", "yan17", "zui16"});
            yield return _gameMethods.OpenDialog(2951); // "「呵呵……{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei9", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(2952); // "哈哈哈哈！」"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei9", "yan11", "zui7"});
            yield return _gameMethods.OpenDialog(2953); // "这副神态简直太难得了。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan17", "zui21"});
            yield return _gameMethods.OpenDialog(2954); // "恶作剧成功的得意让我乐不可支，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(2955); // "呵呵大笑。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan4", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.17f}, {"zpos", 6.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei8", "yan17", "zui7"});
            yield return _gameMethods.OpenDialog(2688); // "……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan4", "zui9"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 6.0f}})});
            yield return _gameMethods.OpenDialog(2956); // "他好像想说点什么，"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan25", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(2957); // "又觉得那样会太过幼稚，{nw}{w=0.3}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan17", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(2958); // "抿嘴忍住了。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan17", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui19"});
            yield return _gameMethods.OpenDialog(2959); // "为什么不泼我呢？我们该打个水仗。"
            yield return _gameMethods.PlaySound("sound", 0.5f, 0.7f, "audio/sound/dashuizhang/Water Splash Single Short_01.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(126f, -12f)}, {"zpos", -252f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.35f}, {"pos", new Vector2(174f, -60f)}, {"zpos", -342f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan4", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(2960); // "我站了起来，舒展双臂，对他做出一个欢迎、又或者像拥抱的手势。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(174f, -60f)}, {"zpos", -342f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(2961); // "来吧，赫泽尔。"
            Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
            if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
            {
                                
                        _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
                        _gameMethods.SyncAchievement();

            }
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan17", "zui2"});
            yield return _gameMethods.OpenDialog(2962); // "生活充满美好和惊喜，要像对待礼物一样去对待它。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan17", "zui7"});
            yield return _gameMethods.OpenDialog(2688); // "……"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/dashuizhang/Small Splash_01.mp3");
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 6.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.30f}, {"zpos", 0f}})});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan17", "zui7"});
            yield return _gameMethods.OpenDialog(2963); // "似乎被这话说动，{nw}{w=0.1}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan23", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2964); // "他迟疑着微微弯腰，将手放进水中。"
            yield return _gameMethods.Show("he", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan17", "zui7"});
            yield return _gameMethods.OpenDialog(2965); // "接着，在我期待的目光下……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.PlaySound("sound", 0.0f, 2f, "audio/sound/dashuizhang/Huge Splash_01.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/texiao/shuihua3.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"ypos", 1.02f}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.6f}, {"zoom", 0.75f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.49f}, {"xpos", 0.7f}, {"zoom", 1.14f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.18f}, {"alpha", 1.0f}})});
            yield return _gameMethods.OpenDialog(2966); // "哗啦！！！！！"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/texiao/shuihua3.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(0.7f, 1.02f)}, {"zoom", 1.14f}, {"alpha", 1.0f}})});
            yield return _gameMethods.OpenDialog(2967); // "显然，力度没控制好，这简直像一场海啸。"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 2f, "audio/sound/dashuizhang/Water Splashing  2_01.mp3");
            yield return _gameMethods.Show("Assets/RenpyResources/images/texiao/shuihua3.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 1.14f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.61f}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.82f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.38f}, {"alpha", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.23f}, {"alpha", 0.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan10", "zui7", "emoji5", "emoji16"});
            yield return _gameMethods.OpenDialog(2968); // "当迸溅的巨浪过去，我浑身湿透地立在原地，麻木地任由水珠纷纷从睫毛发梢滴落。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.Show("Assets/RenpyResources/images/texiao/shuihua3.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.82f}, {"alpha", 0.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2969); // "而赫泽尔谨慎地观察着我，两人面面相觑。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan12", "zui3", "-emoji5", "emoji16"});
            yield return _gameMethods.OpenDialog(2970); // "……好吧，一场酣畅淋漓的淋浴。"
            yield return _gameMethods.PlaySound("sound", 0.4f, 0.6f, "audio/sound/dashuizhang/Water Splash Single Short_01.ogg");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui7", "emoji16"});
            yield return _gameMethods.OpenDialog(2971); // "我抹了一把脸。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan12", "zui19", "emoji16"});
            yield return _gameMethods.OpenDialog(2972); // "即使是我也感到心潮澎湃。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan24", "zui7", "-emoji16"});
            yield return _gameMethods.OpenDialog(2973); // "好在，在学习打水仗上，赫泽尔展现出了超人的天赋。{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(2974); // "/n只到了第二次，他的力道就把握得很精准了。"
            yield return _gameMethods.StopSound(channelName:"music1", fadeOut:8f);
            yield return _gameMethods.PlaySound("soundb", 2f, 0.8f, "audio/demo_audio/sound/chanming.ogg");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/tiankong_bangwan.jpg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2975); // "我们玩了整个下午。 "
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg25_memory.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg25_memory.jpg");
            yield return _gameMethods.PlaySound("soundc", 0.0f, 1.0f, "audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/xiaolu2.jpg");
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(2700); // "…………"
            yield return _gameMethods.StopSound(channelName:"soundc", fadeOut:4f);
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:4f);
            yield return _gameMethods.OpenDialog(2976); // "回城堡的路上，赫泽尔忽然放慢脚步，落在了我的后面。"
            yield return _gameMethods.PlaySound("music1", 2f, 1.0f, "audio/music/Alphard.mp3");
            if (Defaults.Persistent.Povname=="辛西娅")
            {
                                yield return _gameMethods.ExecuteCharacterImageData("he");
                yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice19_8da23660.ogg");
                yield return _gameMethods.OpenDialog(2977); // "辛西娅。"

            }
            else
            {
                                yield return _gameMethods.ExecuteCharacterImageData("he");
                yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice19_31af5a3b.ogg");
                yield return _gameMethods.OpenDialog(2978); // "[persistent.povname]。"

            }
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/xiaolu1.jpg");
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"ypos", 2.15f}, {"zoom", 0.43f}, {"xpos", 0.5f}})});
            yield return _gameMethods.TransitionBy("PushMove"); // TODO: 实现 PushMove(0.3, "pushright") 转场效果
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(2979); // "嗯？"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2980); // "我回过身，发现他的脸上竟罕见地有着某种犹豫。 "
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(2981); // "……你还……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui3", "emoji0"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(2688); // "……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui9", "emoji0"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice19_bcef873e.ogg");
            yield return _gameMethods.OpenDialog(2982); // "你现在爱上我了吗。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2", "emoji0"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan4", "zui15"});
            yield return _gameMethods.OpenDialog(2983); // "「……"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan5", "zui19"});
            yield return _gameMethods.OpenDialog(2984); // "快了。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan9", "zui2", "-emoji0"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(2688); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(2985); // "当然，如果你愿意经常让我外出散散步，我会更快一点喜欢上你。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan17", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice19_0288f814.ogg");
            yield return _gameMethods.OpenDialog(2986); // "……好。"
            yield return _gameMethods.StopSound(channelName:"music1", fadeOut:5f);
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice20_9e0d04eb.ogg");
            yield return _gameMethods.OpenDialog(2700); // "…………"
            yield return _gameMethods.OpenDialog(2987); // "……………………"
            yield return _gameMethods.PlaySound("music", 2f, 1.0f, "audio/demo_audio/music/richang1.mp3");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_shufang_baitian_quanjing.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.0f)}, {"zoom", 0.72f}})});
            yield return _gameMethods.Transition();
            Defaults.Persistent.Jq_3_7 = 1;
            Defaults.Haogandu_an = Defaults.Haogandu_an + 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(2988); // "上一次，他表现出了愧疚。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(2989); // "觉得时机成熟，我便趁机对赫泽尔提出了一个请求。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1.6>audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_shufang_baitian_shafa.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.09f, 3.02f)}, {"zoom", 2.62f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 2.46f)}, {"zoom", 0.5f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/shuben_bi.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 500f}, {"xpos", 380f}})});
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(2990); // "你可以教我真言吗？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<silence 0.5>", "audio/demo_audio/sound/book2_he.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan11", "zui7"});
            yield return _gameMethods.OpenDialog(2991); // "可以。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(2992); // "……我原本准备好的一堆说辞顿时堵在嘴边。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui15"});
            yield return _gameMethods.OpenDialog(2993); // "真是出乎意料，赫泽尔竟毫无反对，甚至还挺赞同。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(2994); // "知识是力量，也是美德。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(2995); // "掌握一门新的技艺对你有利无害。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan5", "zui19"});
            yield return _gameMethods.OpenDialog(2996); // "「呃……{nw}{w=0.1}"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.5f}, {"zpos", -30f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
            yield return _gameMethods.OpenDialog(2997); // "谢谢你，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(2998); // "你可真好。」"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -30f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(2999); // "令人费解。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui7", "-emoji2"});
            yield return _gameMethods.OpenDialog(3000); // "如果他最终无论如何都要令我失去未来，又何必在我身上投入这些精力和感情？"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui7"});
            yield return _gameMethods.OpenDialog(3001); // "这只会是无效投资。"
            yield return _gameMethods.OpenDialog(3002); // "还是说，这也是愧疚的影响？"
            yield return _gameMethods.ShowBlack();
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/daoju/shuben_bi.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(2700); // "…………"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui9"});
            yield return _gameMethods.HideBlack();
            yield return _gameMethods.Transition();
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(3003); // "……总之，在赫泽尔的讲解中，我逐渐了解了更多关于真言的知识。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(3004); // "这是一种最古老的语言。它甚至先于文字，便诞生于世。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3005); // "因此，严格来说，真正的真言无法被书写、无法被阅读。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3006); // "最接近真言的文字是古龙文，其次是精灵文。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3007); // "而真言的每一个发音，都具备着多重的复合含义。"
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(3008); // "如“蜡热”这个发音，意思是“太阳；生命；光；能源；火种；毁灭”。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3009); // "而“盖伊”，则有“大地；故乡；归宿；墓地；安眠之所”的意思。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui16", "emoji2"});
            yield return _gameMethods.OpenDialog(3010); // "是的，每个发音都包含着糅杂的释义，甚至有时会包括了两个截然相反对立的意思。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3011); // "……简直就像一种无法确定的量子态一样。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan24", "zui16", "emoji2"});
            yield return _gameMethods.OpenDialog(3012); // "难以想象这样一门语言该如何表达精准的语义。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3013); // "一句话中的每个发音都是息息相关、互为影响的有机体，话语的第一个字眼会影响着最后一个字眼取的是哪个涵义，而其他的字眼又共同确定了第一个发音的意思。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan20", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(3014); // "最恐怖的是，它没有任何语法。/n在真言编织的世界中，此处就是彼处，过去即为未来，而所有已逝的一切，现在都正在发生。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(3015); // "它让我深刻地感觉到了，人类的脑容量是有局限的。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.7f, "audio/demo_audio/sound/moca2.mp3");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_shufang_baitian_quanjing1.jpg");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/shuben.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 300f}, {"xpos", 180f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15"});
            yield return _gameMethods.OpenDialog(3016); // "为了硬啃，我用拼音标出它的读音，又记下它的每一个释义。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/shuben.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 300f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.7f}, {"ypos", 400f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15"});
            yield return _gameMethods.OpenDialog(3017); // "不过三分钟，记忆就像被橡皮擦掉一样，在我脑海中消失得干干净净了。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/shuben.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 400f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui16", "emoji5"});
            yield return _gameMethods.OpenDialog(2860); // "……啊。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3018); // "我很淡定，已经习惯了。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/shuben.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 400f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.7f}, {"ypos", 300f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui7", "emoji5"});
            yield return _gameMethods.OpenDialog(3019); // "忘掉就再背吧。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/shuben.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 300f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3020); // "根据以往经验，忘记并背诵重复20遍后差不多就能初步记住了。而背完80遍左右，就能牢固掌握了。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15", "-emoji5"});
            yield return _gameMethods.OpenDialog(3021); // "这个世界的人们还保持着中世纪那般一种田园牧歌式的生活节奏。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3022); // "相当缓慢而懒散，平均每周工作三十小时。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(3023); // "让他们见识一下来自工业化时代、加上了马达的运转速度。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui5"});
            yield return _gameMethods.OpenDialog(3024); // "更何况我还是来自那个时代中奋斗最努力的国家之一。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3025); // "现在的我无需工作谋生，最不缺的就是空闲时间。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/shuben.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 300f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.4f}, {"ypos", 200f}})});
            yield return _gameMethods.Show("fastwork");
            yield return _gameMethods.Transition();
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan5", "zui5", "emoji7"});
            yield return _gameMethods.OpenDialog(3026); // "真言，我们俩来比一比！"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/shuben.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 200f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan9", "zui5", "-emoji7"});
            yield return _gameMethods.OpenDialog(3027); // "抱着这样的决心，我投入到了学习中。 "
            yield return _gameMethods.EngineSetVolume(volume:0f, delay:2f, channelName:"music");
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(2700); // "…………"
            yield return _gameMethods.EngineSetVolume(volume:1f, delay:2f, channelName:"music");
            yield return _gameMethods.PlaySound("soundb", 0.0f, 1.0f, "audio/demo_audio/sound/niaoming.ogg");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/woshi_nv2.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.0f)}, {"zoom", 0.49f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition();
            Defaults.Persistent.Jq_4_1 = 1;
            Defaults.Haogandu_an = Defaults.Haogandu_an + 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(3028); // "当和赫泽尔共同出过几次门后，我意识到，必须想个办法，在支开他的情况下独自行动。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3029); // "我想对周边的环境做一个摸底调查。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(3030); // "虽然我想不到未来有什么可以成功逃离的机会，但还是不抱希望地想为此多做准备。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3031); // "熟悉周遭的环境，毫无疑问是其中的一环。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(3032); // "而且，有些准备也不好当着赫泽尔的面去做。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(3033); // "这是一个大胆的举措，不无风险，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(3034); // "但倘若成功，就能为我的行动赢得极大的斡旋空间。"
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:3f);
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(3035); // "抱着这样的想法，在早餐桌上，我若无其事地对赫泽尔开口。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/canpanpengzhuang1.mp3");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/heilong_chufang_zaocan/heilong_chufang_zaocan_ditu.jpg");
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui2", "ying1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"ypos", 1.5f}, {"zoom", 0.31f}, {"xpos", 0.5f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/heilong_chufang_zaocan/heilong_chufang_zaocan_zhuozi.png");
            yield return _gameMethods.Show("blend", parts: new List<string>{"multiply"});
            yield return _gameMethods.Show("he", parts: new List<string>{"heilong_chufang_zaocan_yingzi_nv"});
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui19"});
            yield return _gameMethods.OpenDialog(3036); // "今天，可以只由我一个人出门吗？"
            yield return _gameMethods.StopSound(channelName:"sound", fadeOut:1f);
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan20", "zui9"});
            yield return _gameMethods.Transition();
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice19_8b14a85b.ogg");
            yield return _gameMethods.OpenDialog(3037); // "……为什么。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan20", "zui2"});
            yield return _gameMethods.OpenDialog(3038); // "他一下子盯住我。"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/houhui/Peel Scales 1_01.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui7", "emoji2", "emoji5"});
            yield return _gameMethods.OpenDialog(3039); // "在失控的压迫力下，冷意慢慢爬上脖颈。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan20", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan17", "zui7", "emoji2", "emoji5"});
            yield return _gameMethods.OpenDialog(3040); // "要假装毫无异常，必须笑起来才行。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19", "-emoji2", "-emoji5"});
            yield return _gameMethods.OpenDialog(3041); // "那个，我偶尔也想单独一人外出走走…"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan20", "zui3", "emoji0"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui19"});
            yield return _gameMethods.OpenDialog(3042); // "「嗯，你看……{nw}{w=0.1}"
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.5f, "audio/demo_audio/sound/moca2.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}, {"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.28f}, {"ypos", -12f}, {"zpos", -50f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
            yield return _gameMethods.OpenDialog(3043); // "等到回来时，我会送给你一件在外面找到的礼物。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan25", "zui3", "-emoji0"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan27", "zui3"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -12f}, {"zpos", -50f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan3", "zui2"});
            yield return _gameMethods.OpenDialog(3044); // "「你呆在家里，像往常一样读书，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan5", "zui2"});
            yield return _gameMethods.OpenDialog(3045); // "到了快傍晚时，你知道我快要回来了，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui19"});
            yield return _gameMethods.OpenDialog(3046); // "心里就可以开始期待，猜测我会带些什么回来。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui2"});
            yield return _gameMethods.OpenDialog(3047); // "那么，这一天的傍晚，便会变得不同寻常、十分特别。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(3048); // "你不觉得这样很有趣吗？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan11", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice19_0a991e41.ogg");
            yield return _gameMethods.OpenDialog(3049); // "不。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei18", "yan15", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice19_84e3503e.ogg");
            yield return _gameMethods.OpenDialog(3050); // "当你脱离了我的视线范围内时，我只会感觉到很烦躁。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei18", "yan15", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei5", "yan10", "zui13", "emoji2", "emoji5"});
            yield return _gameMethods.OpenDialog(2688); // "……"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/wuyu.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan22", "zui16", "emoji2", "-emoji5"});
            yield return _gameMethods.OpenDialog(3051); // "你是在独自看守三岁幼童的单亲妈妈么。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei18", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei5", "yan22", "zui16", "-emoji2", "-emoji5"});
            yield return _gameMethods.OpenDialog(2688); // "……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan27", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(3052); // "「不过，{nw}{w=0.1}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan23", "zui21"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice19_4f09b7ee.ogg");
            yield return _gameMethods.OpenDialog(3053); // "如果你真的想单独出去、{nw}{w=0.1}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan15", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice19_aaecdce5.ogg");
            yield return _gameMethods.OpenDialog(3054); // "……而且，我也想得到你的礼物。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan25", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice19_0170a283.ogg");
            yield return _gameMethods.OpenDialog(3055); // "好吧，我会在城堡里等你。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(3056); // "你说的傍晚具体是直到哪一时刻？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan3", "zui2"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -12f}, {"zpos", -50.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.5f}, {"ypos", -34f}, {"zpos", -80.0f}})});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(3057); // "太阳落山前吧。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan27", "zui9"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -34f}, {"zpos", -80.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice19_f99e800f.ogg");
            yield return _gameMethods.OpenDialog(3058); // "那太晚了。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan10", "zui8", "emoji2", "emoji12"});
            yield return _gameMethods.OpenDialog(2847); // "？"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan10", "zui8", "emoji2", "-emoji12"});
            yield return _gameMethods.OpenDialog(3059); // "……不是吧，大哥，你可是能活上百万年的龙。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui7", "-emoji2"});
            yield return _gameMethods.OpenDialog(3060); // "哪怕几个月的时长对你都只是弹指一挥间，一个白天不也只是眨下眼皮的问题。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(3061); // "…可是我要好好准备给你的惊喜呀。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan2", "zui19"});
            yield return _gameMethods.OpenDialog(3062); // "时间太短就不够了。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei8", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(3063); // "「……{nw}{w=0.5}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan15", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(3064); // "好。」"
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:4f);
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(2701); // "………………"
            yield return _gameMethods.PlaySound("soundb", 2f, 3f, "audio/sound/dashuizhang/Bird Amb_01.ogg");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/senlin3.jpg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.PlaySound("music", 3f, 0.5f, "audio/music/PerituneMaterial_Laid_Back2_loop.mp3");
            Defaults.Persistent.Jq_4_2 = 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(3065); // "终于获得了独自外出的许可。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan11", "zui7", "emoji10"});
            yield return _gameMethods.OpenDialog(3066); // "这个宝贵的机会让我兴奋紧张不已。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui6", "-emoji10"});
            yield return _gameMethods.OpenDialog(3067); // "有一瞬间，我想要逃离这里。{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui6"});
            yield return _gameMethods.OpenDialog(3068); // "/n无论是往哪个方向，能走多远走多远。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(3069); // "——但理智制止了这个想法。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15"});
            yield return _gameMethods.OpenDialog(3070); // "我不可能跑得过黑龙的双翼。{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(3071); // "/n而被抓回来后，境况就很难收场了。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(2688); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(3072); // "（还是想点实际的东西吧。）"
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:12f);
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg31_memory.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg31_memory.jpg");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/senlin7.jpg");
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(3073); // "一边探索环境，我一边思考起今天的作业。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15"});
            yield return _gameMethods.OpenDialog(3074); // "给赫泽尔准备礼物。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui15"});
            yield return _gameMethods.OpenDialog(3075); // "……有点棘手啊。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3076); // "以黑龙这等高贵的地位，无论多么珍贵的宝物，在他眼里恐怕都稀松平常。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(3077); // "更何况，凭着我的微薄实力，想在这座深山里获取什么足以令他动容的珍品，实在不切实际。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan3", "zui15"});
            yield return _gameMethods.OpenDialog(3078); // "必须转换思路……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan18", "zui15"});
            yield return _gameMethods.OpenDialog(3079); // "能不能、在物品之外的地方做文章呢？"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3080); // "毕竟世界上最成功的营销手段，核心永远都在于兜售故事。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(3081); // "只要给商品附着上某种概念，它的价值就能得到极大的拔高，超过其本身。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan4", "zui15"});
            yield return _gameMethods.OpenDialog(3082); // "嗯……比如……"
            yield return _gameMethods.PlaySound("soundb", 1f, 1.0f, "audio/sound/dashuizhang/Spilling Stream Into Creek Gurgling Water_01.ogg");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/senlin6.jpg");
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan7", "zui15"});
            yield return _gameMethods.OpenDialog(3083); // "我沿着山路行走，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui15"});
            yield return _gameMethods.OpenDialog(3084); // "四处逡巡。"
            yield return _gameMethods.StopSound(channelName:"sound", fadeOut:1.5f);
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(0f, 0f)}, {"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.38f}, {"pos", new Vector2(-18f, 54f)}, {"zpos", -192.0f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/daoju/daoju_hongbaoshi.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.51f, 0.91f)}, {"zoom", 0.58f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.4f}, {"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(3085); // "这时，溪流底部，一块莹润的浆红色血石吸引了我的注意。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/daoju/daoju_hongbaoshi.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-18f, 54f)}, {"zpos", -192.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(3086); // "这不是什么值钱的宝石，只是常见的玛瑙，但依然很漂亮。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 4f, "audio/sound/dashuizhang/Small Splash_01.mp3");
            yield return _gameMethods.Show("Assets/RenpyResources/images/daoju/daoju_hongbaoshi.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui7"});
            yield return _gameMethods.OpenDialog(3087); // "我把血石从溪水中捡起，甩去水渍，擦拭干净。"
            yield return _gameMethods.Hide("Assets/RenpyResources/images/daoju/daoju_hongbaoshi.png");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan17", "zui7"});
            yield return _gameMethods.OpenDialog(3088); // "……剩下要做的，就是为它构造一个故事。"
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:4f);
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/senlin3.jpg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(2700); // "…………"
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:4f);
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/senlin3_1.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(2701); // "………………"
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/senlin3_1.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(3089); // "勘测了一番周遭的地理环境后，我在日落时回到了城堡。"
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/erlou_he/erlou_he1.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.67f}})});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/door_open1.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition(time:0.5f);
            yield return _gameMethods.OpenDialog(3090); // "赫泽尔站在二楼。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/erlou_he/erlou_he2.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}, {"zoom", 0.67f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(3091); // "垂着眼睛，居高临下的默默地盯着我。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/erlou_he/erlou_he2.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui7"});
            yield return _gameMethods.OpenDialog(2717); // "……！"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1.5>audio/sound/jiaobusheng_xin_kuai1.ogg");
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<silence 0.7>", "audio/demo_audio/sound/moca2.mp3");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/heilong_dating_bangwan_louti1.jpg");
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 2.97f)}, {"zoom", 0.6f}})});
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(3092); // "我加快脚步，来到他面前，一把拉住了他的手。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(2688); // "……"
            yield return _gameMethods.OpenDialog(3093); // "他顿了一下，没有挣脱。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan11", "zui19", "emoji9"});
            yield return _gameMethods.OpenDialog(3094); // "「走，{nw}{w=0.1}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan5", "zui19", "emoji9"});
            yield return _gameMethods.OpenDialog(3095); // "我们去会客厅说。」"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<from 0 to 1.6>audio/sound/jiaobusheng_xin_kuai1.ogg");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/heilong_huiketing_quanjing_baitian3_1.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.4f)}, {"zoom", 0.96f}})});
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            yield return _gameMethods.OpenDialog(3096); // "我兴冲冲地把他带到了会客厅。"
            yield return _gameMethods.Show("heilong_huiketing_quanjing_baitian3_1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.4f)}, {"zoom", 0.96f}, {"blur", 3f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 2.05f)}, {"zoom", 0.41f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui8", "-emoji9"});
            yield return _gameMethods.OpenDialog(3097); // "待两人站定，我颇有仪式感的把双手藏在身后。"
            yield return _gameMethods.PlaySound("music", 0.0f, 0.7f, "audio/demo_audio/music/qingkuai1.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan12", "zui19"});
            yield return _gameMethods.OpenDialog(3098); // "赫泽尔，把眼睛闭上。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei3", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(2688); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(3099); // "出乎我预料，他这次居然没有问为什么，"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan23", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3100); // "而是顺从地闭上了眼睛。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<silence 0.3>", "audio/demo_audio/sound/ding1.mp3");
            yield return _gameMethods.Show("Assets/RenpyResources/images/daoju/daoju_hongbaoshi.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}, {"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(378f, 252f)}, {"zoom", 0.33f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"alpha", 1f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/heilong_chufang_zhuo1_tiandian_star.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.58f, 1.1f)}, {"additive", 0.0f}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.58f, saturationMatrix:1.0f, brightnessMatrix:0.04f, hueMatrix:330.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan12", "zui7"});
            yield return _gameMethods.OpenDialog(3101); // "当当当当——"
            yield return _gameMethods.Show("Assets/RenpyResources/images/daoju/daoju_hongbaoshi.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/heilong_chufang_zhuo1_tiandian_star.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei3", "yan5", "zui19"});
            yield return _gameMethods.OpenDialog(3102); // "「今天的礼物，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei3", "yan17", "zui2", "emoji7", "emoji9"});
            yield return _gameMethods.OpenDialog(3103); // "是这个！」"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan17", "zui7", "-emoji7", "-emoji9"});
            yield return _gameMethods.OpenDialog(3104); // "我把藏在背后的手拿出来，露出掌心的血石。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan7", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(2688); // "……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan7", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3105); // "他眨了下眼睛。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui19"});
            yield return _gameMethods.OpenDialog(3106); // "这块石头，不是很像赫泽尔的眼睛吗？"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.24f}, {"zpos", -66.0f}})});
            Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
            if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
            {
                                
                        _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
                        _gameMethods.SyncAchievement();

            }
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(3107); // "所以一看到它，我就想把它送给你了。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan23", "zui9"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -66.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(3108); // "……唔。是么。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan23", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3109); // "他垂眼看向那块石头。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui4"});
            yield return _gameMethods.OpenDialog(3110); // "嘿嘿…这不是很神奇吗？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui19"});
            yield return _gameMethods.OpenDialog(3111); // "「如果不认识赫泽尔，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan9", "zui19"});
            yield return _gameMethods.OpenDialog(3112); // "那这块石头对我就只是路边随处可见的一块石子而已。」"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan6", "zui11"});
            yield return _gameMethods.OpenDialog(3113); // "即便我看到它，也不会产生任何感触。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(3114); // "「但是，因为遇到了你，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan5", "zui10"});
            yield return _gameMethods.OpenDialog(3115); // "看到它时，我就会忽然想起：」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv", parts: new List<string>{"mei7", "yan12", "zui19"});
            yield return _gameMethods.OpenDialog(3116); // "‘这个颜色，就像赫泽尔的眼睛一样，真美啊。’"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui2"});
            yield return _gameMethods.OpenDialog(3117); // "于是，它就突然化作了一种幸运。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan2", "zui2"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"ypos", -126f}, {"zpos", -396.0f}})});
            yield return _gameMethods.TransitionBy("blink2");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(3118); // "我雀跃地把掌心中的血石献到他的面前，低头凑近他，不躲不闪地注视着那对属于龙的血红的双瞳。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan17", "zui4"});
            yield return _gameMethods.OpenDialog(3119); // "赫泽尔，你让这块石头变得特别。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan12", "zui3"});
            yield return _gameMethods.OpenDialog(3120); // "因为你的存在，我的世界变得不一样了。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan2", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui2"});
            yield return _gameMethods.OpenDialog(3121); // "原本不值得开心的普通小事，也开始令人幸福。"
            Defaults.Haogandu_he = Defaults.Haogandu_he + 5;
            if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
            {
                                
                        _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
                        _gameMethods.SyncAchievement();

            }
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(3122); // "这就是赫泽尔施予我的，最大的魔法。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan2", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan11", "zui7"});
            yield return _gameMethods.OpenDialog(2983); // "「……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan9", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan17", "zui7"});
            yield return _gameMethods.OpenDialog(3123); // "……{nw}{w=0.3}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan15", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(2859); // "……」"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3124); // "他抿了抿唇，视线游移。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan15", "zui9"});
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:8f);
            yield return _gameMethods.PlaySound("music1", 2f, 1.0f, "audio/music/Fall.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice19_0a150350.ogg");
            yield return _gameMethods.OpenDialog(3125); // "我是……灾祸、之龙。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan15", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(3126); // "犹豫的目光。他的话语中逐渐染上了不确定的味道，似乎在向我告知，又仿佛在自言自语。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan25", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice19_3fca4c99.ogg");
            yield return _gameMethods.OpenDialog(3127); // "「掌握毁灭、{nw}{w=0.1}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan15", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(3128); // "散播痛苦……」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan15", "zui2"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"ypos", -48f}, {"zpos", -216.0f}})});
            yield return _gameMethods.TransitionBy("blink2");
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(3129); // "「但是，{nw}{w=0.1}"
            Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
            if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
            {
                                
                        _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
                        _gameMethods.SyncAchievement();

            }
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan5", "zui10"});
            yield return _gameMethods.OpenDialog(3130); // "你给我带来了幸福。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(2688); // "……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan13", "zui2"});
            yield return _gameMethods.OpenDialog(3131); // "他低着头，沉默了一会儿。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan15", "zui2"});
            yield return _gameMethods.OpenDialog(3132); // "才伸出手，{nw}{w=0.4}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan13", "zui2"});
            yield return _gameMethods.PlaySound("sound", 0.3f, 1.0f, "audio/sound/houhui/Grab Hand_01.mp3");
            yield return _gameMethods.Show("daoju_hongbaoshi", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"alpha", 0f}})});
            yield return _gameMethods.Show("heilong_chufang_zhuo1_tiandian_star", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"alpha", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(3133); // "指尖从我的手掌中捡起那块石头，攥在手里，垂首看了几秒，一言不发。"
            yield return _gameMethods.Hide("Assets/RenpyResources/images/bg/heilong_chufang_zhuo1_tiandian_star.png");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/daoju/daoju_hongbaoshi.png");
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(3134); // "忽然，他抬眸看向我。"
            Defaults.Gui_duihuakuang_you = 0;
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/moerhuan/moerhuan_1.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0f, 0f)}, {"pos", new Vector2(156f, 42f)}, {"zoom", 0.5f}, {"zpos", 24.0f}})});
            yield return _gameMethods.Show("_zoom");
            yield return _gameMethods.Hide("_zoom");
            yield return _gameMethods.Show("he", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.20f}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 24.0f}})});
            yield return _gameMethods.PlaySound("sounda", 0.6f, 1.0f, "audio/sound/houhui/Body3 _01.mp3");
            
            yield return _gameMethods.OpenDialog(3135); // "赫泽尔抬起了另一只手，向我伸来。"
            yield return _gameMethods.Show("menu", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 24.0f}})});
            yield return _gameMethods.OpenDialog(3136); // "-保持不动"
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan2", "zui15", "emoji2"});
                yield return _gameMethods.OpenDialog(3137); // "我克制住了躲闪的条件反射。"
                yield return _gameMethods.Hide("Assets/RenpyResources/images/cg/moerhuan/moerhuan_1.jpg");
                yield return _gameMethods.ShowBlack(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 24f}})});
                yield return _gameMethods.Transition(time:0.4f);
                yield return _gameMethods.OpenDialog(3138); // "男孩的手指掠过我脸侧的耳朵，顺着边缘，轻轻划过耳垂，停在耳坠下方。"
                yield return _gameMethods.PlaySound("sound", 0.2f, 1.0f, "audio/sound/houhui/Grab Hand_01.mp3");
                yield return _gameMethods.Show("Assets/RenpyResources/images/cg/moerhuan/moerhuan_2.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0f, 0f)}, {"pos", new Vector2(156f, 42f)}, {"zoom", 0.49f}, {"zpos", 24.0f}})});
                yield return _gameMethods.Show("_zoom");
                yield return _gameMethods.Hide("_zoom");
                yield return _gameMethods.Transition(time:0.4f);
                yield return _gameMethods.OpenDialog(3139); // "我感到耳垂一轻，他用指尖拈起了那块宝石。"
                yield return _gameMethods.ExecuteCharacterImageData("nv2");
                yield return _gameMethods.OpenDialog(2682); // "……？"
                yield return _gameMethods.ExecuteCharacterImageData("he");
                yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice19_353b3115.ogg");
                yield return _gameMethods.OpenDialog(3140); // "你的耳坠，是红色的。"
                yield return _gameMethods.Hide("Assets/RenpyResources/images/cg/moerhuan/moerhuan_2.jpg");
                yield return _gameMethods.HideBlack();
                Defaults.Gui_duihuakuang_you = 1;
                yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 30.0f}})});
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -48f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.6f}, {"ypos", -6f}})});
                yield return _gameMethods.Transition(time:0.4f);
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui7", "emoji2"});
                yield return _gameMethods.OpenDialog(3141); // "他说着，{nw}{w=0.1}"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui2"});
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
                yield return _gameMethods.OpenDialog(3142); // "垂下眼眸。血石在他手中发着光。"
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -6f}})});
                yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui9"});
                yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei3", "yan5", "zui7", "-emoji2"});
                yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice19_0e7fcd46.ogg");
                yield return _gameMethods.OpenDialog(3143); // "——如果我看到它，会这么想。"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui2"});
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
                yield return _gameMethods.OpenDialog(3144); // "……就是说、{nw}{w=0.1}"
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui15"});
                yield return _gameMethods.OpenDialog(3145); // "看到红色，会想起我……的意思吗？"
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -6f}, {"zpos", -216.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.47f}, {"ypos", -60f}, {"zpos", -246.0f}})});
                yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui2"});
                yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui19", "emoji2"});
                yield return _gameMethods.OpenDialog(3146); // "……这，这就叫做…心意相通吧！"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan9", "zui2"});
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -60f}, {"zpos", -246.0f}})});
                yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan2", "zui7", "-emoji2"});
                yield return _gameMethods.OpenDialog(2858); // "「……{nw}{w=0.3}"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui9"});
                yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
                yield return _gameMethods.OpenDialog(3147); // "嗯。」"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
                yield return _gameMethods.OpenDialog(3148); // "他幅度很小地轻轻点了下头。"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui9"});
                yield return _gameMethods.OpenDialog(3149); // "接着，声音很低地、喃喃说了句什么，令人几乎要听不见。"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui9"});
                yield return _gameMethods.ExecuteCharacterImageData("he");
                yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice19_df5c0d60.ogg");
                yield return _gameMethods.OpenDialog(3150); // "我好像有点控制不住。"
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -60f}, {"zpos", -246.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.36f}, {"ypos", -60f}, {"zpos", -264.0f}})});
                yield return _gameMethods.PlaySound("sound", 0.6f, 1.0f, "audio/demo_audio/sound/moca2.mp3");
                yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2"});
                Engine._history = false;
                yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui15"});
                yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
                Engine._history = true;
                yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10"});
                yield return _gameMethods.OpenDialog(3151); // "什么？"
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -60f}, {"zpos", -264.0f}})});
                yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
                yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
                yield return _gameMethods.OpenDialog(3152); // "我好像有点控制不住……想要……"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan1", "zui6", "emoji2", "emoji3"});
                yield return _gameMethods.OpenDialog(3153); // "{size=+10}？？？{/size}"
                yield return _gameMethods.PlaySound("sounda", 0.0f, 1.5f, "<from 0 to 0.5>audio/sound/jiaobusheng_xin_normal1.ogg");
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -60f}, {"zpos", -264.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.31f}, {"ypos", -60f}, {"zpos", -186.0f}})});
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei6", "yan13", "zui8", "emoji2", "emoji5", "emoji6", "-emoji3"});
                yield return _gameMethods.OpenDialog(3154); // "{size=+10}请你控制住。{/size}"
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -60f}, {"zpos", -186.0f}})});
                yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
                Engine._history = false;
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
                yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
                Engine._history = true;
                yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei6", "yan12", "zui8", "emoji2", "emoji6", "-emoji5"});
                yield return _gameMethods.OpenDialog(3155); // "预感到不是什么好事，我连忙制止。"
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei9", "yan5", "zui7", "emoji2", "-emoji6"});
                yield return _gameMethods.OpenDialog(3156); // "我强作镇定。"
                yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei1", "yan11", "zui19", "emoji2"});
                yield return _gameMethods.OpenDialog(3157); // "……为什么会控制不住呢？是我惹你不开心了吗。"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui9"});
                yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei1", "yan11", "zui7", "-emoji2"});
                yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice19_0156c4d1.ogg");
                yield return _gameMethods.OpenDialog(3158); // "「不。{nw}{w=0.1}"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui13"});
                yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
                yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice19_428a9581.ogg");
                yield return _gameMethods.OpenDialog(3159); // "……我会克制的。」"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2"});
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan24", "zui7", "emoji2"});
                yield return _gameMethods.OpenDialog(3160); // "好吧…………"
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
                yield return _gameMethods.OpenDialog(3161); // "龙的心，海底针。"
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan8", "zui7", "-emoji2"});
                yield return _gameMethods.OpenDialog(3162); // "至少我现在活得好好的，{nw}{w=0.1}"
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan12", "zui7"});
                yield return _gameMethods.OpenDialog(3163); // "他还要我协助他实现一年后的目标呢。我乐观地想。"
                yield return _gameMethods.ChangeLabelTo("label_choice20");
            yield return _gameMethods.OpenDialog(3164); // "-躲开"
                yield return _gameMethods.PlaySound("sound", 0.6f, 1.0f, "audio/demo_audio/sound/moca2.mp3");
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
                yield return _gameMethods.OpenDialog(3165); // "我没能控制住，下意识偏头地躲闪了一下。"
                yield return _gameMethods.Show("Assets/RenpyResources/images/cg/moerhuan/moerhuan_3.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0f, 0f)}, {"pos", new Vector2(156f, 42f)}, {"zoom", 0.5f}, {"zpos", 24.0f}})});
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
                yield return _gameMethods.Transition();
                yield return _gameMethods.ExecuteCharacterImageData("he");
                yield return _gameMethods.OpenDialog(2688); // "……"
                yield return _gameMethods.OpenDialog(3166); // "他的手顿在了半空中。"
                yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei1", "yan2", "zui15"});
                yield return _gameMethods.OpenDialog(2858); // "「……{nw}{w=0.3}"
                yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei4", "yan5", "zui10", "emoji2"});
                yield return _gameMethods.OpenDialog(2859); // "……」"
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan3", "zui15", "emoji16", "emoji2"});
                yield return _gameMethods.OpenDialog(3167); // "完蛋了，身体反应露馅了。"
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan6", "zui15", "emoji16", "emoji2"});
                yield return _gameMethods.OpenDialog(3168); // "我硬着头皮，不知该如何反应。"
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan12", "zui15", "-emoji16", "emoji2"});
                yield return _gameMethods.OpenDialog(3169); // "感觉会多做多错……{nw}{w=0.3}"
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui15", "emoji2"});
                yield return _gameMethods.OpenDialog(3170); // "最后，我面上装作若无其事地转回来头，神情自然如常地面向他。"
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui7", "emoji2"});
                yield return _gameMethods.OpenDialog(3171); // "谨慎地观察对方的反应，希望他能顺应我的弥补，假装什么都没发生。"
                yield return _gameMethods.ExecuteCharacterImageData("he");
                yield return _gameMethods.OpenDialog(2700); // "…………"
                yield return _gameMethods.OpenDialog(3172); // "他的手僵在空中片刻。"
                yield return _gameMethods.Hide("Assets/RenpyResources/images/cg/moerhuan/moerhuan_3.jpg");
                yield return _gameMethods.Transition();
                yield return _gameMethods.OpenDialog(3173); // "最后，赫泽尔恢复了原本平淡自然的表情，就像什么都没发生一样，继续刚才的动作。"
                yield return _gameMethods.PlaySound("sound", 0.6f, 1.0f, "audio/demo_audio/sound/tangxia3_duanduan.mp3");
                yield return _gameMethods.ShowBlack(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0f, 0f)}, {"pos", new Vector2(100f, 54f)}, {"zpos", 24f}, {"zoom", 2f}})});
                yield return _gameMethods.Transition(time:0.4f);
                yield return _gameMethods.OpenDialog(3174); // "他的手指掠过我脸侧的耳朵，顺着边缘，轻轻划过耳垂，停在耳坠下方。"
                yield return _gameMethods.HideBlack();
                yield return _gameMethods.PlaySound("sound", 0.2f, 1.0f, "audio/sound/houhui/Grab Hand_01.mp3");
                yield return _gameMethods.Show("Assets/RenpyResources/images/cg/moerhuan/moerhuan_2.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0f, 0f)}, {"pos", new Vector2(180f, 54f)}, {"zoom", 0.49f}, {"zpos", 24f}})});
                yield return _gameMethods.Show("_zoom");
                yield return _gameMethods.Hide("_zoom");
                yield return _gameMethods.Transition(time:0.4f);
                yield return _gameMethods.OpenDialog(3139); // "我感到耳垂一轻，他用指尖拈起了那块宝石。"
                yield return _gameMethods.ExecuteCharacterImageData("nv2");
                yield return _gameMethods.OpenDialog(2682); // "……？"
                yield return _gameMethods.ExecuteCharacterImageData("he");
                yield return _gameMethods.OpenDialog(3140); // "你的耳坠，是红色的。"
                yield return _gameMethods.Hide("Assets/RenpyResources/images/cg/moerhuan/moerhuan_2.jpg");
                yield return _gameMethods.Hide("Assets/RenpyResources/images/cg/moerhuan/moerhuan_1.jpg");
                Defaults.Gui_duihuakuang_you = 1;
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -90f}, {"zpos", -282.0f}, {"xpos", 0f}})});
                yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
                yield return _gameMethods.Transition(time:0.4f);
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui7", "emoji2"});
                yield return _gameMethods.OpenDialog(3141); // "他说着，{nw}{w=0.1}"
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -90f}, {"zpos", -282.0f}, {"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.5f}, {"ypos", -48f}})});
                yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui2"});
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
                yield return _gameMethods.OpenDialog(3142); // "垂下眼眸。血石在他手中发着光。"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui9"});
                yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei3", "yan5", "zui7", "-emoji2"});
                yield return _gameMethods.OpenDialog(3143); // "——如果我看到它，会这么想。"
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -48f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.25f}, {"ypos", -84f}})});
                yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui2"});
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
                yield return _gameMethods.OpenDialog(3144); // "……就是说、{nw}{w=0.1}"
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui15"});
                yield return _gameMethods.OpenDialog(3145); // "看到红色，会想起我……的意思吗？"
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -84f}})});
                yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui19", "emoji2"});
                yield return _gameMethods.OpenDialog(3175); // "「……这，{nw}{w=0.1}"
                yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/ding1.mp3");
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -2f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 2f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
                yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
                yield return _gameMethods.OpenDialog(3176); // "这就叫做…心意相通吧！」"
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
                yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan11", "zui7", "-emoji2"});
                yield return _gameMethods.OpenDialog(3177); // "有些急于弥补刚才的过失，我笑着说。"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui9"});
                yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
                yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice19_e4e41444.ogg");
                yield return _gameMethods.OpenDialog(3178); // "……嗯。"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan25", "zui3"});
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
                yield return _gameMethods.OpenDialog(3179); // "他抿了抿唇，{nw}{w=0.1}"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan27", "zui2"});
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
                yield return _gameMethods.OpenDialog(3180); // "抬眸望向了我，"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
                yield return _gameMethods.OpenDialog(3181); // "微微张嘴，{nw}{w=0.3}"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei16", "yan15", "zui2"});
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
                yield return _gameMethods.OpenDialog(3182); // "最终又紧紧闭合。"
                yield return _gameMethods.ChangeLabelTo("label_choice20");
        }

        public IEnumerator label_choice20()
        {
            yield return _gameMethods.StopSound(channelName:"music1", fadeOut:5f);
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(2700); // "…………"
            yield return _gameMethods.OpenDialog(2701); // "………………"
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/xiaolu1.jpg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.PlaySound("music1", 2f, 1.0f, "audio/demo_audio/music/richang1.mp3");
            Defaults.Persistent.Jq_4_3 = 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(3183); // "经过我竭力的说服，赫泽尔最终允许我每周六得到一次独自出门的机会。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3184); // "借此机会，我花了大概三个月的时间，把城堡方圆两公里的地方全都走了一遍，弄清了周遭的环境。"
            Defaults.Haogandu_an = Defaults.Haogandu_an + 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(3185); // "——之所以是两公里，是因为，一旦超过这个范围，我就会遭受某种限制，无法前进。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(3186); // "……总之，我还规划了几个逃跑路线来以防万一。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui7"});
            yield return _gameMethods.OpenDialog(3187); // "如果哪天找到了偷溜的机会呢，梦想还是要有的。"
            yield return _gameMethods.EngineSetVolume(volume:0.6f, delay:1f, channelName:"music1");
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(2688); // "……"
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/heilong_dating_bangwan.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.0f)}, {"zoom", 0.71f}})});
            yield return _gameMethods.Transition(time:0.6f);
            yield return _gameMethods.EngineSetVolume(volume:1f, delay:2f, channelName:"music1");
            yield return _gameMethods.OpenDialog(3188); // "又是一天礼拜六，我从外面回来。"
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/heilong_huiketing_quanjing_baitian2_1.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"zoom", 0.69f}})});
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan11", "zui7"});
            yield return _gameMethods.OpenDialog(3189); // "习以为常地到休息室找赫泽尔。/n这几个月里，他已经逐渐习惯在这里等待我。"
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/heilong_huiketing_shafa_baitian_1.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.38f, 1.89f)}, {"zoom", 2.16f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan23", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 2.71f)}, {"zoom", 0.56f}, {"anchor", new Vector2(0.5f, 1.0f)}})});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/door_open_3.mp3");
            yield return _gameMethods.TransitionBy("blink2");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(3190); // "刚进入房间，{nw}{w=0.1}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3191); // "赫泽尔就抬头望向我。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei9", "yan9", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3192); // "他的眉毛皱了皱。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei9", "yan24", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(3193); // "你身上有痛苦的味道。"
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei9", "yan24", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(3194); // "我愣了一下。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei9", "yan24", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(3195); // "今天没有偏头痛。"
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(3196); // "{nw}{w=0.12}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei9", "yan24", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(2858); // "「……{nw}{w=0.3}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(3196); // "{nw}{w=0.12}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(2859); // "……」"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(3197); // "怔了好一会，我才反应过来。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan3", "zui10"});
            yield return _gameMethods.OpenDialog(3198); // "……啊，今天我救了一只受伤的鸽子。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan3", "zui15", "emoji12"});
            yield return _gameMethods.OpenDialog(3199); // "但那至少是在一小时之前，而且鸽子明明飞走了。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan22", "zui13", "emoji2", "emoji3", "-emoji12"});
            yield return _gameMethods.OpenDialog(3200); // "……话说你连这种痛苦都能感觉到吗？！什么时候？？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan4", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei3", "yan22", "zui18", "emoji2", "-emoji3"});
            yield return _gameMethods.OpenDialog(2688); // "……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan10", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei3", "yan22", "zui18", "-emoji2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice20_9c9cc19f.ogg");
            yield return _gameMethods.OpenDialog(3201); // "……你总是会做这种事么。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan10", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan21", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(3202); // "什么事？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan27", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei3", "yan21", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(3203); // "这种无益的事。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan22", "zui21"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan2", "zui15", "-emoji2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice20_ff61c69f.ogg");
            yield return _gameMethods.OpenDialog(3204); // "「对于那等脆弱的生物，{nw}{w=0.1}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan27", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice20_72b13ec1.ogg");
            yield return _gameMethods.OpenDialog(3205); // "就算得到这一次短暂的帮助，也很快会被环境淘汰。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan25", "zui12"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice20_53cb73f2.ogg");
            yield return _gameMethods.OpenDialog(3206); // "你的努力也就此变得毫无用处。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan10", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan8", "zui19"});
            yield return _gameMethods.OpenDialog(3207); // "嗯……的确是这样。我也知道。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan4", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan8", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice20_61fd5d59.ogg");
            yield return _gameMethods.OpenDialog(3208); // "那为什么还要为此浪费时间？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan4", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan5", "zui19"});
            yield return _gameMethods.OpenDialog(3209); // "「为了……{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan6", "zui2"});
            yield return _gameMethods.OpenDialog(3210); // "内心的安宁？」"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui19"});
            yield return _gameMethods.OpenDialog(3211); // "「因为，我想，对于那只鸽子来说，是不一样的。{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui3"});
            yield return _gameMethods.OpenDialog(3212); // "至少它会在乎。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan29", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice15_f820312c.ogg");
            yield return _gameMethods.OpenDialog(2688); // "……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei9", "yan15", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice20_2169b4c7.ogg");
            yield return _gameMethods.OpenDialog(3213); // "又到底是为什么，你要在意它的感受。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei9", "yan15", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan9", "zui7"});
            yield return _gameMethods.OpenDialog(2688); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(3214); // "「因为……{nw}{w=0.1}"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.4f}, {"zpos", -24f}})});
            yield return _gameMethods.PlaySound("sound", 0.2f, 0.4f, "audio/demo_audio/sound/moca2.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
            yield return _gameMethods.OpenDialog(3215); // "我和它同样弱小。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan27", "zui2"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -24f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan5", "zui10"});
            yield return _gameMethods.OpenDialog(3216); // "「我帮助它，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui10"});
            yield return _gameMethods.OpenDialog(3217); // "其实是希望在我受伤时，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei1", "yan17", "zui4"});
            yield return _gameMethods.OpenDialog(3218); // "也能有谁来温柔地对待我。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei1", "yan8", "zui7"});
            yield return _gameMethods.OpenDialog(2688); // "……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan23", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(3219); // "「那你要做的，{nw}{w=0.1}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui21"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(3220); // "应该是去招揽更加强大的存在。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui9"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei8", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei8", "yan8", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice20_93d288c5.ogg");
            yield return _gameMethods.OpenDialog(3221); // "「因为它们的行动，{nw}{w=0.1}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan9", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice20_2d0e0b82.ogg");
            yield return _gameMethods.OpenDialog(3222); // "对你会更有益处。」"
            yield return _gameMethods.Show("menu");
            yield return _gameMethods.OpenDialog(3223); // "—确实呢，所以赫泽尔要好好保护我"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan9", "zui2"});
                yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan5", "zui19"});
                yield return _gameMethods.OpenDialog(3224); // "「确实呢，{nw}{w=0.1}"
                Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
                if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
                {
                                        
                                _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
                                _gameMethods.SyncAchievement();

                }
                yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan11", "zui19"});
                yield return _gameMethods.OpenDialog(3225); // "所以赫泽尔要好好保护我哦。」"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui9"});
                yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan18", "zui7"});
                yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice20_58f35fcb.ogg");
                yield return _gameMethods.OpenDialog(3226); // "……可以。"
                yield return _gameMethods.ExecuteCharacterImageData("he_nv");
                yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice20_e19544a3.ogg");
                yield return _gameMethods.OpenDialog(3227); // "只要在我身边，就没有生物能威胁到你。"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2"});
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui7"});
                yield return _gameMethods.OpenDialog(3228); // "是啊，除了你自己。"
                yield return _gameMethods.PlaySound("sound", 0.2f, 0.4f, "audio/demo_audio/sound/moca2.mp3");
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -2f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 2f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
                yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan2", "zui10"});
                yield return _gameMethods.OpenDialog(3229); // "「……啊！{nw}{w=0.1}"
                yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan9", "zui19"});
                yield return _gameMethods.OpenDialog(3230); // "对了对了，礼物！」"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
                yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan2", "zui2"});
                yield return _gameMethods.OpenDialog(3231); // "「差点忘了。{nw}{w=0.1}"
                yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan11", "zui19"});
                yield return _gameMethods.OpenDialog(3232); // "快过来快过来~」"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
                yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei8", "yan11", "zui7"});
                yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice15_9f98c18c.ogg");
                yield return _gameMethods.OpenDialog(2688); // "……"
                yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<silence 0.7>", "audio/demo_audio/sound/book2_he.mp3");
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui7", "emoji7"});
                yield return _gameMethods.OpenDialog(3233); // "在我热烈的注视下，赫泽尔认命地合上了手里的书。"
                yield return _gameMethods.PlaySound("sounda", 0.4f, 1.0f, "audio/demo_audio/sound/tangxia3_duanduan.mp3");
                yield return _gameMethods.PlaySound("sounda1", 0.0f, 1.5f, "<silence 0.5>", "<from 0 to 2>audio/demo_audio/sound/zu3_nv_zou.ogg");
                yield return _gameMethods.SceneBlack();
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
                yield return _gameMethods.Transition();
                yield return _gameMethods.OpenDialog(3234); // "起身。"
                yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/heilong_huiketing_quanjing_baitian3_1.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.84f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 1.29f}})});
                yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 2.63f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 10.0f}, {"zoom", 0.53f}})});
                yield return _gameMethods.Transition();
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui7", "-emoji7"});
                yield return _gameMethods.OpenDialog(3235); // "待他走至面前，我又期待地请求。"
                yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan17", "zui19"});
                yield return _gameMethods.OpenDialog(3236); // "把眼睛闭上，闭上。"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
                yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan17", "zui7"});
                yield return _gameMethods.OpenDialog(2688); // "……"
                yield return _gameMethods.StopSound(channelName:"music1", fadeOut:4f);
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan17", "zui7"});
                yield return _gameMethods.OpenDialog(3237); // "他合上了双眼，那配合的态度，堪称温驯了。"
                yield return _gameMethods.ChangeLabelTo("label_choice21_1");
            yield return _gameMethods.OpenDialog(3238); // "—可是，哪有强大的存在会愿意理睬我呢"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan9", "zui2"});
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan8", "zui15"});
                yield return _gameMethods.OpenDialog(3239); // "我的心中还在对他方才展现出的、敏锐到侵犯人类隐私权的嗅觉而耿耿于怀。"
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan12", "zui15"});
                yield return _gameMethods.OpenDialog(3240); // "听闻此话，{nw}{w=0.1}"
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan8", "zui15"});
                yield return _gameMethods.OpenDialog(3241); // "便心不在焉地顺口回答。"
                yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan8", "zui10"});
                yield return _gameMethods.OpenDialog(3242); // "可是强大的存在，又怎么会理睬我这种弱小的生物呢？"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan24", "zui2", "emoji9"});
                yield return _gameMethods.Transition();
                yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei8", "yan8", "zui15"});
                yield return _gameMethods.OpenDialog(2700); // "…………"
                yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice16_1ee9a704.ogg");
                yield return _gameMethods.OpenDialog(2688); // "……"
                yield return _gameMethods.OpenDialog(3243); // "他默然地盯着我。"
                Engine._history = false;
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
                yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
                Engine._history = true;
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15", "emoji12"});
                yield return _gameMethods.OpenDialog(3244); // "……我迷茫地望着他。"
                yield return _gameMethods.EngineSetVolume(volume:0f, delay:2f, channelName:"music1");
                yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/book2_he.mp3");
                yield return _gameMethods.Show("he", parts: new List<string>{"mei10", "yan25", "zui3"});
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15", "-emoji12"});
                yield return _gameMethods.OpenDialog(3245); // "忽然，他“啪”地一声，把手里的书用力合上了。"
                yield return _gameMethods.PlaySound("sounda", 0.6f, 1.0f, "audio/demo_audio/sound/tangxia3_duanduan.mp3");
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}, {"zpos", -24f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.43f}, {"ypos", -306f}, {"zpos", 18f}})});
                yield return _gameMethods.Show("he", parts: new List<string>{"mei10", "yan15", "zui3", "emoji11"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 2.71f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.43f}, {"ypos", 2.3f}})});
                yield return _gameMethods.OpenDialog(3246); // "一言不发地从沙发上站起，仿佛打算就此离开会客厅。"
                yield return _gameMethods.Hide("he");
                yield return _gameMethods.Transition();
                yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice17_39e15fc1.ogg");
                yield return _gameMethods.OpenDialog(2688); // "……"
                yield return _gameMethods.OpenDialog(2700); // "…………"
                yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/heilong_huiketing_quanjing_baitian3_1.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.84f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 1.29f}})});
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
                yield return _gameMethods.TransitionBy("trans_rip_fast");
                yield return _gameMethods.EngineSetVolume(volume:1f, delay:4f, channelName:"music1");
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15", "emoji2"});
                yield return _gameMethods.OpenDialog(3247); // "感觉赫泽尔的脸色有点臭，心情好像不太好。"
                yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan6", "zui15", "-emoji2"});
                yield return _gameMethods.OpenDialog(2688); // "……"
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
                yield return _gameMethods.OpenDialog(3248); // "但说实话，他灵敏到那个程度的嗅觉，让我有点不安。"
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan20", "zui15"});
                yield return _gameMethods.OpenDialog(3249); // "仅仅是水洗，不足以去除味道么。"
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
                yield return _gameMethods.OpenDialog(3250); // "总感觉会在自己不知情的情况下，泄露出许多未知的信息。"
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
                yield return _gameMethods.OpenDialog(3251); // "如果有办法能够测量出他的嗅觉能力就好了，而且，要在不引起他注意和警觉的情况下。"
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
                yield return _gameMethods.OpenDialog(3252); // "我内心思考着。"
                yield return _gameMethods.PlaySound("sounda1", 0.0f, 1.0f, "<from 0 to 2>audio/demo_audio/sound/zu3_nv_zou.ogg");
                yield return _gameMethods.Show("he", parts: new List<string>{"mei10", "yan15", "zui2", "-emoji11"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 2.63f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 10.0f}, {"zoom", 0.53f}, {"alpha", 0f}, {"xoffset", 100f}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.7f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.3f}, {"alpha", 1f}})});
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
                yield return _gameMethods.OpenDialog(3253); // "经过我面前的赫泽尔，却突然停住脚步。"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan24", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"alpha", 1f}})});
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
                yield return _gameMethods.OpenDialog(3254); // "他转过身来，微微抬起下巴，面无表情地看着我。"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan24", "zui9"});
                yield return _gameMethods.ExecuteCharacterImageData("he_nv");
                yield return _gameMethods.OpenDialog(3255); // "礼物。"
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
                yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan24", "zui2"});
                yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan2", "zui10"});
                yield return _gameMethods.OpenDialog(3229); // "「……啊！{nw}{w=0.1}"
                yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei3", "yan2", "zui11"});
                yield return _gameMethods.OpenDialog(3256); // "都忘了。」"
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
                yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan17", "zui19"});
                yield return _gameMethods.OpenDialog(3257); // "快，把眼睛闭上。"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan25", "zui2"});
                Engine._history = false;
                yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
                yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
                Engine._history = true;
                yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan24", "zui2"});
                yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan17", "zui7"});
                yield return _gameMethods.OpenDialog(2688); // "……"
                yield return _gameMethods.StopSound(channelName:"music1", fadeOut:4f);
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan17", "zui7"});
                yield return _gameMethods.OpenDialog(3258); // "他又审视了我一会，{nw}{w=0.1}"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
                yield return _gameMethods.OpenDialog(3259); // "才合上了双眼。"
                yield return _gameMethods.ChangeLabelTo("label_choice21_1");
        }

        public IEnumerator label_choice21_1()
        {
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/demo_audio/music/richang2.mp3");
            yield return _gameMethods.Show("Assets/RenpyResources/images/daoju/daoju_yuanwei.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(550f, 400f)}, {"anchor", new Vector2(0f, 0f)}, {"zoom", 0.3f}, {"zpos", 20f}, {"yoffset", 200f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.6f}, {"yoffset", 0f}, {"zoom", 0.2f}, {"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan11", "zui2"});
            yield return _gameMethods.OpenDialog(3260); // "「锵锵锵——{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei3", "yan5", "zui19", "emoji7"});
            yield return _gameMethods.OpenDialog(3261); // "请看！！」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.Show("Assets/RenpyResources/images/daoju/daoju_yuanwei.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}, {"zoom", 0.2f}, {"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui19", "emoji7"});
            yield return _gameMethods.OpenDialog(3262); // "我从身后拿出双手，重磅推出提前准备好的礼物。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan7", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19", "emoji9", "-emoji7"});
            yield return _gameMethods.OpenDialog(3263); // "今天的礼物——是这个！！"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}, {"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.6f}, {"ypos", 144f}, {"zpos", -150.0f}})});
            Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
            if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
            {
                                
                        _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
                        _gameMethods.SyncAchievement();

            }
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui7", "-emoji9"});
            yield return _gameMethods.OpenDialog(3264); // "一朵鸢蓝色的小花。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan7", "zui2"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"ypos", -54f}, {"zpos", -192.0f}})});
            yield return _gameMethods.TransitionBy("blink2");
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(2688); // "……"
            yield return _gameMethods.OpenDialog(3265); // "他盯着那朵花，{nw}{w=0.1}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan7", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(3266); // "眨了眨眼睛，似乎理解了其中的涵义，{nw}{w=0.3}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan11", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(3267); // "面色稍稍软化下来。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(3268); // "是的，这朵花的“故事”，就是它的花语。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui7"});
            yield return _gameMethods.OpenDialog(3269); // "在精灵族编辑出的《植物的真名》中，记载了精灵眼中每种植物所蕴含的独特的含义。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui7"});
            yield return _gameMethods.OpenDialog(3270); // "而这种花的花语，是“独一无二的邂逅，与“命中注定”。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan11", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3271); // "然而，由于这个世界里的语言，越是高深，其语意就越是多重而暧昧不清。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3272); // "精灵语不外如是。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui7"});
            yield return _gameMethods.OpenDialog(3273); // "所以，那句话也可以理解为“一生一次的相会”。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui7"});
            yield return _gameMethods.OpenDialog(3274); // "一生只有一次。一次，就足以改变一生。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan11", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(2688); // "……"
            yield return _gameMethods.PlaySound("sound", 0.3f, 1.0f, "audio/sound/houhui/Grab Hand_01.mp3");
            yield return _gameMethods.Show("Assets/RenpyResources/images/daoju/daoju_yuanwei.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.2f}, {"alpha", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.50f}, {"zoom", 0.15f}, {"alpha", 0f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan13", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(3275); // "赫泽尔微微垂了垂眼睑，接过了它。"
            yield return _gameMethods.Hide("Assets/RenpyResources/images/daoju/daoju_yuanwei.png");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3276); // "仔仔细细地注视着指间那朵花。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan12", "zui9"});
            yield return _gameMethods.OpenDialog(3277); // "……呼。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan13", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui7"});
            yield return _gameMethods.OpenDialog(3278); // "看来他对这个礼物还算满意。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui7"});
            yield return _gameMethods.OpenDialog(3279); // "我的心放回了肚子里。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan13", "zui2"});
            yield return _gameMethods.PlaySound("sound", 0.4f, 1.0f, "audio/demo_audio/sound/tangxia3_duanduan.mp3");
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:4f);
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(3280); // "——然后，{nw}{w=0.1}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan25", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(3281); // "就看到他把那朵花举到了嘴边。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3282); // "柔软的花瓣擦过他淡色的嘴唇。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3283); // "看起来像一个亲吻。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan13", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan25", "zui15"});
            yield return _gameMethods.OpenDialog(2688); // "……"
            yield return _gameMethods.OpenDialog(3284); // "还未及思考这个动作的含义。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan25", "zui13"});
            yield return _gameMethods.StopEngineTime(time:0.4f);
            yield return _gameMethods.PlaySound("music", 2f, 1.0f, "audio/demo_audio/music/a dull dawn.mp3");
            yield return _gameMethods.Hide("he");
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/chihua/chihuaa_1.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0f, 0f)}, {"pos", new Vector2(144f, 168f)}, {"zoom", 0.51f}, {"zpos", 10f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1f}})});
            yield return _gameMethods.Show("heilong_huiketing_quanjing_baitian3_1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"blur", 5f}})});
            yield return _gameMethods.Show("_zoom");
            yield return _gameMethods.Hide("_zoom");
            yield return _gameMethods.Transition(time:1f);
            yield return _gameMethods.OpenDialog(3285); // "赫泽尔张开了嘴。"
            yield return _gameMethods.Show("heilong_huiketing_quanjing_baitian3_1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 5f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/chihua/chihuaa_1.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(3286); // "猩红的口腔。鲜艳的舌头。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/chihua/chihuaa_2.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"at", "default"}, {"as", "chihuaa_11"}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0f, 0f)}, {"pos", new Vector2(144f, 168f)}, {"zoom", 0.51f}, {"zpos", 10f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(3287); // "他将花朵放入口中，咬了下去。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/chihua/chihuaa_2.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"as", "chihuaa_11"}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(3288); // "洁白的牙齿撕扯花瓣。/n它一点一点地把花朵咬去，咀嚼，吞咽。"
            yield return _gameMethods.OpenDialog(3289); // "少年的动作如此有条不紊，连吃花这种行为都显得优雅，理所当然。"
            yield return _gameMethods.OpenDialog(3290); // "精致的眼睫低垂，赤红的眼瞳中平静无波。"
            yield return _gameMethods.OpenDialog(3291); // "我就这样眼睁睁地看着他在自己面前吃完了那株花朵。"
            yield return _gameMethods.OpenDialog(3292); // "从花冠、花柄，每一片叶子，植物的茎。/n一直到茎最下方被我用手指亲手掐断的地方。"
            yield return _gameMethods.OpenDialog(3293); // "整株花被他全部吞没。"
            yield return _gameMethods.PlaySound("sound", 0.4f, 1.0f, "audio/demo_audio/sound/tangxia3_duanduan.mp3");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/cg/chihua/chihuaa_2.png");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/cg/chihua/chihuaa_1.png");
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/chihua/chihuaa_3.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0f, 0f)}, {"pos", new Vector2(144f, 168f)}, {"zoom", 0.51f}, {"zpos", 10f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(3294); // "赫泽尔神色如常地放下了手，{nw}{w=0.3}"
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/chihua/chihuaa_4.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0f, 0f)}, {"pos", new Vector2(144f, 168f)}, {"zoom", 0.51f}, {"zpos", 10f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1");
            yield return _gameMethods.OpenDialog(3295); // "目光也转移到我的身上。"
            yield return _gameMethods.OpenDialog(3296); // "仿佛他下一个吞食的目标就会是我。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/chihua/chihuaa_4.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(3297); // "我下意识想要后退，但脚却固定在了原地。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan1", "zui15", "emoji2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice17_aa7b3984.ogg");
            yield return _gameMethods.OpenDialog(2700); // "…………"
            yield return _gameMethods.Hide("chihuaa_11");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/cg/chihua/chihuaa_3.png");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/cg/chihua/chihuaa_4.png");
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 2.75f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.56f}})});
            yield return _gameMethods.Transition(time:0.8f);
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_qian");
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(2682); // "……？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan2", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(3298); // "直到他察觉到我的走神，疑惑地微微皱眉。我才意识到自己怔愣得太久。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei6", "yan8", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(3299); // "…………不安。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei9", "yan2", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(3300); // "「那个，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei9", "yan11", "zui19", "-emoji2"});
            yield return _gameMethods.OpenDialog(3301); // "你为什么要吃掉它呢……」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei9", "yan11", "zui7"});
            yield return _gameMethods.OpenDialog(3302); // "我勉强笑着问。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei9", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(3303); // "如果不吃掉，它很快就会枯萎。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3304); // "赫泽尔一脸的理所当然。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei9", "yan8", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(3305); // "可是，不是应该有合适的魔法，可以把它封存起来吗？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei9", "yan8", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(3306); // "即便封存，它也太脆弱了。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan10", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(3307); // "「需要随身携带，{nw}{w=0.1}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(3308); // "也会轻易地在发生变化的外部环境中破碎，毁灭。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(3309); // "不如让它一直伴随我。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei6", "yan2", "zui10", "-emoji2"});
            yield return _gameMethods.OpenDialog(3310); // "可是、这样……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei6", "yan2", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(3311); // "我觉得应该阻止他的这种想法，却实在想不到相应的理由，只得硬着头皮说。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei9", "yan24", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(3312); // "呃……这样、不太卫生啊……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei6", "yan12", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(3313); // "说完，自己也觉得这话有点太荒谬。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3314); // "龙恐怕这辈子都不知道什么叫拉肚子吧。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan4", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan10", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(3315); // "果然，他看着我，从视线中透出一股看傻瓜的无言。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan20", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(3160); // "好吧…………"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan7", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(3316); // "那，我之前送的那些礼物呢……？"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(3317); // "也都……？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan11", "zui7", "-emoji2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice16_bb688e6d.ogg");
            yield return _gameMethods.OpenDialog(2838); // "嗯。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan2", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(2700); // "…………"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(3318); // "我沉默了很久，实在不知道该说什么。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15", "emoji2", "emoji5"});
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3319); // "每一样被我仔细挑选，亲手摘取的事物，都已经被他吞吃入腹，于他的胃中消化。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan20", "zui15", "emoji2", "emoji5"});
            yield return _gameMethods.OpenDialog(3320); // "一股轻微的寒意升上后颈。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui7", "emoji2", "-emoji5"});
            yield return _gameMethods.OpenDialog(3321); // "我尽力开了个玩笑。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan11", "zui19", "-emoji2"});
            yield return _gameMethods.OpenDialog(3322); // "「好吧，看来，至少以后我送你东西应该避开活物，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan11", "zui19", "-emoji2"});
            yield return _gameMethods.OpenDialog(3323); // "还有石头这些不好吃的东西。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan11", "zui7"});
            yield return _gameMethods.OpenDialog(3324); // "都可以。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(3325); // "你可以送，只要你想。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan22", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(3326); // "啊、啊哈哈……"
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:5f);
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(2700); // "…………"
            yield return _gameMethods.OpenDialog(3327); // "无论如何，我决定尽可能地探索一下赫泽尔的嗅觉能力的边界。"
            yield return _gameMethods.ChangeLabelTo("label_choice21");
        }

        public IEnumerator label_choice21()
        {
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/senlin6.jpg");
            yield return _gameMethods.PlaySound("soundb", 0.0f, 1.0f, "audio/sound/dashuizhang/Spilling Stream Into Creek Gurgling Water_01.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.PlaySound("music", 2f, 1.0f, "audio/demo_audio/music/richang1.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(3328); // "第二周，我在外出时带上了香皂。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3329); // "这天，在林间寻觅到受伤的动物以后，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(3330); // "返回城堡之前，我在溪水中用香皂洗了个澡。"
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/heilong_huiketing_quanjing_baitian2_1.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.21f)}, {"anchor", new Vector2(0.5f, 1.0f)}})});
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:3f);
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(3331); // "回来后，赫泽尔没有显露出任何异常。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(3332); // "我等了许久，见他始终没有提到气味，便主动提及。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan23", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 2.63f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 10.0f}, {"zoom", 0.53f}, {"alpha", 0f}, {"blur", 0.001f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"alpha", 1f}, {"blur", 0f}})});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1>audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.60f}, {"zpos", -54f}})});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui19"});
            yield return _gameMethods.OpenDialog(3333); // "我今天又遇到了一只受伤的小鹿。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}, {"blur", 0f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -54f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan5", "zui19"});
            yield return _gameMethods.OpenDialog(3334); // "「怕熏到你，我就用香皂洗了洗，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan11", "zui2"});
            yield return _gameMethods.OpenDialog(3335); // "是不是感觉好多了？」"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1>audio/demo_audio/sound/zu3_nv_zou.ogg");
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 10.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"zpos", 28.0f}})});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(3336); // "他眨了眨眼睛，走近了我。"
            yield return _gameMethods.Show("he", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 28.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(3337); // "我保持着原本的位置，没有避开。"
            yield return _gameMethods.PlaySound("sounda", 0.6f, 1.0f, "audio/demo_audio/sound/moca2.mp3");
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 28.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.29f}, {"zpos", 45.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3338); // "他凑近我，鼻翼动了动。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui9"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 45.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice21_4ff5e72e.ogg");
            yield return _gameMethods.OpenDialog(3339); // "唔，没关系。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(3340); // "这种含糊的说法无法让我放心。{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan2", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(3341); // "我露出担心和惭愧。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei1", "yan5", "zui10"});
            yield return _gameMethods.OpenDialog(3342); // "还是很刺鼻吗？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei1", "yan5", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice21_5ec856e2.ogg");
            yield return _gameMethods.OpenDialog(3343); // "不仔细就嗅不到。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(3344); // "似乎是看我还很介意，他又加了一句。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice21_47c4b87d.ogg");
            yield return _gameMethods.OpenDialog(3345); // "不明显。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(2688); // "……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan20", "zui15"});
            yield return _gameMethods.OpenDialog(3346); // "也就是说，只差一点。"
            yield return _gameMethods.EngineSetVolume(volume:0.6f, delay:2f, channelName:"music");
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(2688); // "……"
            yield return _gameMethods.OpenDialog(3347); // "几日很快过去。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/door_qiao1.mp3");
            yield return _gameMethods.EngineSetVolume(volume:1f, delay:2f, channelName:"music");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/woshi_men3.jpg");
            yield return _gameMethods.Show("hand_biao_ani", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(480f, 852f)}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/hand_nv.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(564f, 942f)}})});
            yield return _gameMethods.Transition(time:0.6f);
            Defaults.Persistent.Jq_4_4 = 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(3348); // "一天，我忽然奇思妙想，在晚上敲响了赫泽尔卧室的门。"
            yield return _gameMethods.PlaySound("sounda3", 0.0f, 1.0f, "<from 0 to 1>audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/door_open_3.mp3");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/woshi_he1_sky.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(276f, 1.21f)}, {"zoom", 0.58f}, {"anchor", new Vector2(0.5f, 1.0f)}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/woshi_he1.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(276f, 1.21f)}, {"zoom", 0.58f}, {"anchor", new Vector2(0.5f, 1.0f)}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.39f, 2.34f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.48f}, {"zpos", 10f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/woshi_men2.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.56f, 2.05f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 1.42f}, {"zpos", 20f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", -90f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(3349); // "赫泽尔，可以送给我一个你的枕头吗？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice21_2a9f81f6.ogg");
            yield return _gameMethods.OpenDialog(3350); // "为什么。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3351); // "他冷静地问。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan6", "zui19"});
            yield return _gameMethods.OpenDialog(3352); // "「如果我天天枕着这个睡觉，就会一直沾染你的气味，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui19"});
            yield return _gameMethods.OpenDialog(3353); // "时间久了，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui2"});
            yield return _gameMethods.OpenDialog(3354); // "说不定就腌入味了呢。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan4", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(2700); // "…………"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan10", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(2991); // "可以。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice21_3e3e0278.ogg");
            yield return _gameMethods.OpenDialog(3355); // "人类都会像这样互相讨要床上用品么？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan12", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(3356); // "其实世间一般把这样的行为称为越界。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui19", "-emoji2"});
            yield return _gameMethods.OpenDialog(3357); // "「或许，{nw}{w=0.1}"
            yield return _gameMethods.PlaySound("sound", 0.5f, 1.0f, "audio/demo_audio/sound/moca2.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}, {"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.28f}, {"ypos", -24f}, {"zpos", -72.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan11", "zui19", "-emoji2"});
            yield return _gameMethods.OpenDialog(3358); // "只有在最亲密的人之间才会这样做？」"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -24f}, {"zpos", -72.0f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui7", "-emoji2"});
            yield return _gameMethods.OpenDialog(2688); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui7", "-emoji2"});
            yield return _gameMethods.OpenDialog(3359); // "他若有所思。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice21_6993a1a6.ogg");
            yield return _gameMethods.OpenDialog(3360); // "你以前向多少人要过枕头。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
            if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
            {
                                
                        _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
                        _gameMethods.SyncAchievement();

            }
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(3361); // "你还是第一个。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui19"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(3362); // "他好像有点满意。"
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(2700); // "…………"
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/woshi_he1_sky.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.89f, 1.45f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.88f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/woshi_he1.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.89f, 1.45f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.88f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui20"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.48f, 1.92f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.39f}, {"xoffset", 100f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.8f}, {"xoffset", 0f}})});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1.5>audio/demo_audio/sound/zu3_nv_zou.ogg");
            yield return _gameMethods.Transition();
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_qian");
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui20"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice21_74b73cd1.ogg");
            yield return _gameMethods.OpenDialog(3363); // "作为交换，我也应该得到你的枕头。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui19"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui19", "emoji12"});
            yield return _gameMethods.OpenDialog(3364); // "当然。只要你不介意。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(2683); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan5", "zui7", "-emoji12"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice21_503af6f0.ogg");
            yield return _gameMethods.OpenDialog(3365); // "为什么我会介意。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan6", "zui10"});
            yield return _gameMethods.OpenDialog(3366); // "「嗯…在人类中间会有一些人格外在意卫生，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui11"});
            yield return _gameMethods.OpenDialog(3367); // "不喜欢他人触碰自己的物品，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui9"});
            yield return _gameMethods.OpenDialog(3368); // "俗称洁癖。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice21_5f8a9aec.ogg");
            yield return _gameMethods.OpenDialog(3369); // "「你是我的，{nw}{w=0.1}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice21_d1d9b91c.ogg");
            yield return _gameMethods.OpenDialog(3370); // "你的一切也属于我。我没有任何理由介意。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan24", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(3371); // "……好的。多么理所当然的语气啊。"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<from 0 to 1.5>audio/demo_audio/sound/zu3_nv_zou.ogg");
            yield return _gameMethods.PlaySound("sound", 0.9f, 0.6f, "<silence 0.5>", "audio/demo_audio/sound/moca2.mp3");
            yield return _gameMethods.Hide("he");
            yield return _gameMethods.Show("zhentou", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.58f, 1.37f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.33f}, {"xrotate", 0.0f}, {"yrotate", 0.0f}, {"zrotate", 6.0f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan5", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(3372); // "我得到了赫泽尔的枕头，以我的枕头作为交换。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan18", "zui15"});
            yield return _gameMethods.OpenDialog(3373); // "在必要时刻，或许能用它来掩盖身上的气味。"
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition(time:0.4f);
            yield return _gameMethods.OpenDialog(2688); // "……"
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_shufang_baitian_quanjing.jpg");
            yield return _gameMethods.Transition(time:0.5f);
            Defaults.Haogandu_an = Defaults.Haogandu_an + 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(3374); // "学习的时间一晃而逝，第二个冬天很快到来。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/heilong_chufang_baitian_man1.jpg");
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(3375); // "我和赫泽尔一起制作了蛋糕，以庆祝生日。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan24", "zui16", "emoji2"});
            yield return _gameMethods.OpenDialog(3376); // "但在这段时间里，我的精力都放在了学习真言和外出探索等事情上，没有花费时间提前练习。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.8f, "<silence 0.4>", "audio/demo_audio/sound/wuyu.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui16", "emoji2"});
            yield return _gameMethods.OpenDialog(3377); // "毫不意外，烘烤的海绵蛋糕失败了。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui16", "-emoji2"});
            yield return _gameMethods.OpenDialog(3378); // "它变成了一块光荣的鸡蛋糕。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan12", "zui16", "emoji2"});
            yield return _gameMethods.OpenDialog(3379); // "……好吧，下次一定练习。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui19"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 2.33f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.48f}, {"alpha", 0f}, {"blur", 0.01f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1f}, {"blur", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui7", "-emoji2"});
            yield return _gameMethods.OpenDialog(3380); // "不过，幸好赫泽尔并没见过真正的海绵蛋糕，很好糊弄。"
            yield return _gameMethods.Show("he", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}, {"blur", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3381); // "除了嘴上矜傲，他似乎吃得挺愉悦的。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan11", "zui7"});
            yield return _gameMethods.OpenDialog(3382); // "我们热情高涨地分食了这块鸡蛋糕，互祝生日快乐。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg30_memory.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg30_memory.jpg");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/senlin8_1.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.01f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 1.0f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(3383); // "寒冷的冬天渐渐结束，{nw}{w=0.1}"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.8f}, {"ypos", -132f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/senlin8.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.01f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.7f}, {"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3384); // "春日到来。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -132f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/senlin8.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(3385); // "第三年开始了。"
            yield return _gameMethods.OpenDialog(3386); // "我的时间，只剩一年多了。"
            yield return _gameMethods.ChangeLabelTo("label_choice22");
        }
}