    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class zhuxian0 : ILabelProvider
    {
        private GameMethods _gameMethods;

        public zhuxian0(GameMethods gameMethods)
        {
            _gameMethods = gameMethods;
        }

            public IEnumerator label_zhuxian0()
        {
            Defaults.Persistent.Jq_1_1 = 1;
            Defaults.Persistent.Gallery_fanwai1_lock = 1;
            Engine._dismiss_pause = false;
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:1f);
            yield return _gameMethods.PlaySound("soundb", 0.0f, 1.0f, "audio/demo_audio/sound/fenwei_jinzhang_shuidi.ogg");
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/tielian1.ogg");
            yield return _gameMethods.ShowBlack();
            yield return _gameMethods.StopEngineTime(time:1f);
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.ShowBlack();
            yield return _gameMethods.StopEngineTime(time:0.5f);
            yield return _gameMethods.Show("nienie_ani_zoom");
            yield return _gameMethods.Hide("nienie_ani_zoom");
            yield return _gameMethods.Show("nienie_ani", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.99f}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-680f, -306f)}})});
            yield return _gameMethods.PlaySound("sounda", 6f, 1.0f, "<silence 3>", "<from 0 to 3>audio/sound/jiaobusheng_nuo_man1.ogg");
            yield return _gameMethods.TransitionBy("blink4");
            yield return _gameMethods.StopEngineTime(time:1f);
            yield return _gameMethods.PlaySound("sounda1", 0.0f, 0.7f, "audio/demo_audio/sound/moca4_duan.mp3");
            yield return _gameMethods.OpenDialog(0); // "紧闭的房间。锁链冰冷。"
            Engine._dismiss_pause = true;
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian0_d258503b.ogg");
            yield return _gameMethods.OpenDialog(1); // "为什么不笑？"
            if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
            {
                                
                        _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
                        _gameMethods.SyncAchievement();

            }
            yield return _gameMethods.PlaySound("sounda", 0.0f, 3f, "<from 0 to 1>audio/sound/jiaobusheng_nuo_man1.ogg");
            yield return _gameMethods.OpenDialog(2); // "那个长大后变得格外陌生的孩子，目光偏执地盯着我。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<silence 1>", "audio/demo_audio/sound/moca5_duan.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian0_0a0701a3.ogg");
            yield return _gameMethods.OpenDialog(3); // "你之前对那些无关紧要的人笑得很灿烂。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("he_pangbai");
            yield return _gameMethods.OpenDialog(5); // "我的沉默似乎令他感到焦躁。"
            yield return _gameMethods.PlaySound("sounda1", 0.0f, 1.0f, "audio/demo_audio/sound/moca6_duan.mp3");
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.8f, "<silence 0.5>", "audio/demo_audio/sound/banlian.mp3");
            yield return _gameMethods.Scene("nienie_ani", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"fade", new RenpyFade(0.2f, 0.2f, 1.3f, "#fff")}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.66f}})});
            yield return _gameMethods.OpenDialog(6); // "他扳起我的脸，不容违逆般地让我们对视。"
            yield return _gameMethods.OpenDialog(7); // "无言以对。"
            yield return _gameMethods.OpenDialog(8); // "我想起第一次遇见时，他冷淡而漠视的眼神。"
            yield return _gameMethods.OpenDialog(9); // "事情究竟是在哪里，从何时，开始出错的呢？"
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian0_0e5cce9e.ogg");
            yield return _gameMethods.OpenDialog(10); // "像对那些人一样，也对我笑一笑啊。"
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(11); // "还是说，现在的我对你，已经没有价值了？"
            yield return _gameMethods.SaveLastVoiceToTheEnd();
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.Transition(time:0.8f);
            yield return _gameMethods.OpenDialog(12); // "或许，早在相遇之前——"
            yield return _gameMethods.SaveLastVoiceToTheEnd();
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:2f);
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(13); // "-五年前-"
            yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/demo_audio/music/youshang1.mp3");
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/canpanpengzhuang1.mp3");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg1_memory.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg1_memory.jpg");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/wanggong_cantin1.jpg");
            yield return _gameMethods.Transition(time:1f);
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(14); // "王室晚宴的餐桌上。"
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai");
            yield return _gameMethods.OpenDialog(15); // "国王、王后、公主，和睦的一家三口就在面前。"
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai", parts: new List<string>{"mei1", "yan20", "zui9"});
            yield return _gameMethods.OpenDialog(16); // "虽然王子因为外出游学，暂时缺席，但这并未影响现场气氛的温馨。"
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(17); // "而作为国王刚被找回的私生女，我像局外人一样麻木地坐在这里。"
            yield return _gameMethods.OpenDialog(18); // "对面的国王咽下了最后一口食物，满面慈祥和悲悯地开口。"
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/wanggong_cantin2.jpg");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_portrait/npc/npc_guowang.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.47f, 1.21f)}, {"zoom", 1.06f}})});
            yield return _gameMethods.Transition(time:0.8f);
            yield return _gameMethods.ExecuteCharacterImageData("wu_a_nv", parts: new List<string>{"mei7", "yan2", "zui9"});
            yield return _gameMethods.OpenDialog(19); // "我苦命的女儿啊，你令我想起你的母亲。"
            yield return _gameMethods.ExecuteCharacterImageData("wu_a_nv", parts: new List<string>{"mei1", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(20); // "她也拥有一双美丽的蓝色双眼，在离开之前，她是整个王宫里我认识的最勤劳的女仆。"
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv1");
            yield return _gameMethods.OpenDialog(21); // "…………"
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai", parts: new List<string>{"mei8", "yan8", "zui5"});
            yield return _gameMethods.OpenDialog(22); // "……提她。你也配？"
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv1", parts: new List<string>{"mei7", "yan2", "zui2"});
            yield return _gameMethods.OpenDialog(23); // "…是的，父亲。我为她而骄傲。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_portrait/npc/npc_guowang.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.47f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 1f}, {"xpos", 0.32f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_portrait/npc/npc_wanghou.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.75f, 1.07f)}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.7f}, {"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("wu_b_nv", parts: new List<string>{"mei7"});
            yield return _gameMethods.OpenDialog(24); // "可怜的孩子，在民间漂泊了这么久，你一定吃了不少苦头。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_portrait/npc/npc_guowang.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.32f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_portrait/npc/npc_wanghou.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(25); // "没有的事，王后殿下。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_portrait/npc/npc_guowang.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.43f}, {"zpos", 30.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("wu_a_nv", parts: new List<string>{"mei7", "yan11", "zui7"});
            yield return _gameMethods.OpenDialog(26); // "……接下来几天，你就呆在卧房里吧。一步也不要外出，好好休息。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_portrait/npc/npc_guowang.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 30.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv1", parts: new List<string>{"mei7", "yan5", "zui2"});
            yield return _gameMethods.OpenDialog(27); // "我明白了，父亲。"
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv1", parts: new List<string>{"mei7", "yan2", "zui8"});
            yield return _gameMethods.OpenDialog(28); // "对了，父亲，之前请求您的事——……"
            yield return _gameMethods.ExecuteCharacterImageData("wu_a_nv", parts: new List<string>{"mei1", "yan2", "zui8"});
            yield return _gameMethods.OpenDialog(29); // "放心吧，孩子，我已如你所托，给了你那几位邻居一大笔钱，足够他们此生衣食无忧。"
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui8"});
            yield return _gameMethods.OpenDialog(30); // "我放心了。"
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv1", parts: new List<string>{"mei7", "yan11", "zui6"});
            yield return _gameMethods.OpenDialog(31); // "多谢您的慷慨，国王陛下。"
            yield return _gameMethods.PlaySound("soundc", 0.0f, 1.0f, "audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.Transition();
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(32); // "晚餐结束，我独自离开了宴厅。"
            yield return _gameMethods.OpenDialog(33); // "………………"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg2_memory.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg2_memory.jpg");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/wanggong_zoulang.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "dissolve"}})});
            yield return _gameMethods.PlaySound("sound", 0.5f, 1.0f, "audio/demo_audio/sound/jiaobusheng_nv_pao_gaogen_diban.mp3");
            yield return _gameMethods.StopSound(channelName:"soundc", fadeOut:3f);
            yield return _gameMethods.ExecuteCharacterImageData("c_weizhi");
            yield return _gameMethods.OpenDialog(34); // "等一下。"
            yield return _gameMethods.OpenDialog(35); // "高傲的声音从身后传来。"
            yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"zui1", "mei1", "yan6"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.29f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.41f}, {"alpha", 0f}, {"xoffset", 100f}, {"yoffset", 90f}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(36); // "我同父异母的妹妹——王国的公主追上了我。"
            yield return _gameMethods.Show("gongzhu_layered", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}, {"xoffset", 0f}})});
            yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"zui10", "mei2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.5f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.60f}, {"xpos", 0.47f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.41f}}), new SameLineParamData(new Dictionary<string, object>{{"easeInBack", 0.60f}, {"zoom", 0.42f}})});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/jiaobusheng_nv_liangbuzou_gaogen_diban.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("wu_c_nv", parts: new List<string>{"mei7", "yan2", "zui14"});
            yield return _gameMethods.OpenDialog(37); // "亲爱的姐姐，你可能会需要这个，来驱除自己身上的虱子。"
            yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"zui11"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.47f}, {"zoom", 0.42f}})});
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv1", parts: new List<string>{"mei7", "yan14", "zui2"});
            yield return _gameMethods.OpenDialog(38); // "谢谢，但我这个人很爱干净，不需要驱虫。"
            yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"zui4", "mei1", "yan6"});
            yield return _gameMethods.ExecuteCharacterImageData("wu_c_nv", parts: new List<string>{"mei7", "yan14", "zui6"});
            yield return _gameMethods.OpenDialog(39); // "哦。是吗？对不起，我还以为平民的身上都有虱子呢。"
            yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"zui11"});
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv1", parts: new List<string>{"mei7", "yan22", "zui6"});
            yield return _gameMethods.OpenDialog(4); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai");
            yield return _gameMethods.OpenDialog(40); // "这话是有心，还是无意？"
            yield return _gameMethods.OpenSelectMenu(talk: new List<string>{"-你知道平民饥荒时会吃什么吗", "-你还是多见见世面吧", "-谢谢，好意心领了"}, jump: new List<string>{"label_zhuxian0_menu_0_lxExYY4b", "label_zhuxian0_menu_0_YSR9LSxg", "label_zhuxian0_menu_0_VC1zFfEH"}, condition: new List<string>{"NONE", "NONE", "NONE"});
        }

        public IEnumerator label_choice1_1()
        {
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv1", parts: new List<string>{"mei7", "yan11", "zui1"});
            yield return _gameMethods.OpenDialog(41); // "公主，你知道平民没有面包吃而饿肚子的时候，都吃些什么吗？"
            yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"zui4", "mei1", "yan2"});
            yield return _gameMethods.ExecuteCharacterImageData("wu_c_nv", parts: new List<string>{"mei7", "yan5", "zui8"});
            yield return _gameMethods.OpenDialog(42); // "哦！真的吗，饿肚子？/n为了保持美丽，我也常忍饥挨饿，但我不知道平民也会如此高雅和体面。"
            yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"yan4", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("wu_c_nv", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(43); // "我的建议是多吃点沙拉。"
            yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"zui11"});
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv1", parts: new List<string>{"mei7", "yan11", "zui2"});
            yield return _gameMethods.OpenDialog(44); // "差不多，他们吃谷壳和木屑，有时候泥土。"
            yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"zui8", "mei3", "yan3"});
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.OpenDialog(45); // "她睁大眼睛，似乎听出了话中的讽刺。"
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.OpenDialog(4); // "……"
            yield return _gameMethods.ChangeLabelTo("label_choice1");
        }

        public IEnumerator label_choice1_2()
        {
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv1", parts: new List<string>{"mei7", "yan11", "zui2"});
            yield return _gameMethods.OpenDialog(46); // "公主，你有空还是多出几次王宫，见见世面吧。/n也免得以后因为无知，再闹笑话。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/zhenjing_shuaidaoganjue.mp3");
            yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"zui6", "mei2", "yan3"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.47f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"xpos", 0.46f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"xpos", 0.47f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xpos", 0.46f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 1.29f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"ypos", 1.29f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"ypos", 1.28f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"ypos", 1.27f}})}, parallel_2: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.42f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.2f}, {"zoom", 0.4f}})});
            yield return _gameMethods.ExecuteCharacterImageData("wu_c_nv", parts: new List<string>{"mei7", "yan5", "zui8"});
            yield return _gameMethods.OpenDialog(47); // "……！"
            yield return _gameMethods.Show("gongzhu_layered", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.46f}, {"ypos", 1.27f}, {"zoom", 0.4f}})});
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui8"});
            yield return _gameMethods.OpenDialog(48); // "她瞪大了眼睛，似乎不敢相信有人会对自己如此无礼。"
            yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"emoji1", "zui7", "mei2", "yan3"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.44f}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 84.0f}})});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.5>audio/demo_audio/sound/zu3_nv_zou_kuai.ogg");
            yield return _gameMethods.ExecuteCharacterImageData("wu_c_nv", parts: new List<string>{"mei7", "yan8", "zui7"});
            yield return _gameMethods.OpenDialog(49); // "你——……！"
            yield return _gameMethods.Show("gongzhu_layered", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 84.0f}})});
            yield return _gameMethods.ChangeLabelTo("label_choice1");
        }

        public IEnumerator label_choice1_3()
        {
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv1", parts: new List<string>{"mei7", "yan2", "zui3"});
            yield return _gameMethods.OpenDialog(50); // "在一些乡村的确如此，不过并非每个平民的身上都有虱子。"
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui15"});
            yield return _gameMethods.OpenDialog(51); // "至少贫民、农民、市民之间是有区别的。"
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(52); // "如果她的话不是有意挖苦，那么看来公主殿下脑中的民众形象，非常的模糊和抽象啊。"
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(53); // "但我也懒得和她争辩这些。"
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(54); // "不过还是谢谢你，好意心领了。"
            yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"zui6", "mei5", "yan1"});
            yield return _gameMethods.ExecuteCharacterImageData("wu_c_nv", parts: new List<string>{"mei7", "yan11", "zui7"});
            yield return _gameMethods.OpenDialog(55); // "当然。你在外面受了不少苦吧。"
            yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv1", parts: new List<string>{"mei1", "yan8", "zui3"});
            yield return _gameMethods.OpenDialog(56); // "是呀，你真贴心。"
            yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"yan4", "mei5", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("wu_c_nv", parts: new List<string>{"mei1", "yan8", "zui7"});
            yield return _gameMethods.OpenDialog(57); // "哼。"
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai");
            yield return _gameMethods.OpenDialog(58); // "她似乎满足了。"
            yield return _gameMethods.ChangeLabelTo("label_choice1");
        }

        public IEnumerator label_choice1()
        {
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}})});
            yield return _gameMethods.SceneBlack(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "dissolve"}})});
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:3f);
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1.7>audio/sound/jiaobusheng_xin_normal1.ogg", "audio/demo_audio/sound/door_close1.mp3");
            yield return _gameMethods.OpenDialog(21); // "…………"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg3_memory.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg3_memory.jpg");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/wanggongwoshi_huanghun.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.28f, 1.19f)}, {"anchor", new Vector2(0.5f, 1.0f)}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(59); // "我抛下她，回到了卧室。"
            yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/demo_audio/music/youshang2.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(60); // "是的。/n三天之前，我还是一名平民。"
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai", parts: new List<string>{"mei1", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(61); // "与他人不同，我残存着上一世的记忆。"
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(434); // "作为地球二十一世纪的一名普通上班族，连续通宵，穿越，成为了这个世界的婴儿。"
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(63); // "穿越、转生…无论如何称呼，这就是我遇到的情况。"
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai", parts: new List<string>{"mei7", "yan20", "zui15"});
            yield return _gameMethods.OpenDialog(64); // "只可惜，毫无超常才能，我同前世一样，是个普通居民。"
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai", parts: new List<string>{"mei7", "yan20", "zui9"});
            yield return _gameMethods.OpenDialog(65); // "由于这一世的母亲早早过世，我从十二岁起就在邻居家开的面包店打工，自食其力。"
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui9"});
            yield return _gameMethods.OpenDialog(435); // "——然而，三天前，找来的骑士告诉我，我居然是国王流落在世间的女儿。"
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai", parts: new List<string>{"mei1", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(67); // "还没来得及同青梅竹马的伙伴们告别，国王的骑兵队就火速加急，把我带回了王宫。"
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai", parts: new List<string>{"mei1", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(68); // "后来，我弄清了国王如此着急的原因。"
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai", parts: new List<string>{"mei1", "zui15", "yan20"});
            yield return _gameMethods.OpenDialog(436); // "曾有人收获一块石板，上面记载了古老的预言。"
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai", parts: new List<string>{"mei1", "zui15", "yan20"});
            yield return _gameMethods.OpenDialog(70); // "这一年，帝国的一位公主将被恶龙夺走，囚禁于高塔之中。"
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai", parts: new List<string>{"mei7", "zui15", "yan12"});
            yield return _gameMethods.OpenDialog(437); // "并在三年之后，成为恶龙力量的源泉。/n这是人类帝国接下来三百年灾难纪元的开端。"
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15"});
            yield return _gameMethods.OpenDialog(72); // "唯一的变数，就是此后从民间遴选出的某位勇者。/n这名勇者将在三百名候选之中脱颖而出，在世界各地历经磨难。"
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(438); // "如果命运垂青，他会变得足够强大，直至无可阻挡。/n最终，于大陆的边缘胜过黑暗之龙尼德霍格，为人族带来接近三百年的和平。"
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai", parts: new List<string>{"mei7", "yan20", "zui15"});
            yield return _gameMethods.OpenDialog(74); // "——而在此之前，我将成为公主的替罪羊。"
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(75); // "十六年来，国王第一次过问我的下落，{nw}{w=0.15}"
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(439); // "/n目的是让我保住他更爱的女儿。"
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai", parts: new List<string>{"mei6", "yan20", "zui3"});
            yield return _gameMethods.OpenDialog(77); // "为了防止我逃走，他还专门派了八队卫兵在外轮流防守。"
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv1", parts: new List<string>{"mei5", "yan12", "zui5"});
            yield return _gameMethods.OpenDialog(4); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv1", parts: new List<string>{"mei5", "yan11", "zui13", "emoji6"});
            yield return _gameMethods.OpenDialog(78); // "国民的税金就是用在这种地方的吗！！"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"ypos", -5f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"ypos", 5f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"ypos", -5f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"ypos", 5f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"ypos", -5f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"ypos", 5f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"ypos", 0f}})});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/moca1.ogg");
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv1", parts: new List<string>{"mei6", "yan1", "zui2"});
            yield return _gameMethods.OpenDialog(79); // "/n可恶，向以前辛勤工作交税的我道歉！"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai", parts: new List<string>{"mei5", "yan2", "zui15", "-emoji6"});
            yield return _gameMethods.OpenDialog(80); // "但考虑到我处于这个封建时期社会阶段的世界，{nw}{w=0.15}"
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai", parts: new List<string>{"mei7", "yan10", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(81); // "又并非数量稀有、地位高贵的奥术师或骑士，那便没有天赋人权可言，{nw}{w=0.15}"
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui10", "emoji2"});
            yield return _gameMethods.OpenDialog(82); // "必须听命于整个王国最大的封建领主——国王。"
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(440); // "如果说，过去的社会经历曾教给过我什么，那大概就是一件事——"
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai", parts: new List<string>{"mei6", "yan20", "zui15"});
            yield return _gameMethods.OpenDialog(441); // "无论是多么无稽的不幸，发生在某人身上，都是合乎情理的。"
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai", parts: new List<string>{"mei5", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(85); // "这是时代的局限性，{nw}{w=0.15}"
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai", parts: new List<string>{"mei6", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(86); // "/n一个底层平民，只能{cps=4}自认倒霉。{/cps}"
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:2f);
            yield return _gameMethods.OpenDialog(21); // "…………"
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai", parts: new List<string>{"mei6", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(87); // "既然被恶龙抓走的命运已经避无可避，{nw}{w=0.15}"
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai", parts: new List<string>{"mei7", "yan7", "zui15"});
            yield return _gameMethods.OpenDialog(88); // "我决定乐观一点。"
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai", parts: new List<string>{"mei7", "yan7", "zui15"});
            yield return _gameMethods.OpenDialog(89); // "首先，{nw}{w=0.4}"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/demo_audio/sound/ding1.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai", parts: new List<string>{"mei7", "yan17", "zui2", "emoji10"});
            yield return _gameMethods.OpenDialog(90); // "不如收他一点钱。"
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai", parts: new List<string>{"mei7", "yan4", "zui5", "emoji9"});
            yield return _gameMethods.OpenDialog(91); // "我委托国王在有复数大臣见证的场合下做出了承诺，向我曾经的伙伴们赠送大笔财富。"
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai", parts: new List<string>{"mei1", "yan12", "zui7"});
            yield return _gameMethods.OpenDialog(92); // "如果他们足够勤奋，这辈子或许能花完八分之一。"
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui10", "-emoji9", "-emoji10"});
            yield return _gameMethods.OpenDialog(93); // "其次，死都要死了，死前就尽量别再遭受虐待了。/n至少想过得舒服一些。"
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui6"});
            yield return _gameMethods.OpenDialog(94); // "为此，我要和恶龙搞好关系。"
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai", parts: new List<string>{"mei7", "yan17", "zui6"});
            yield return _gameMethods.OpenDialog(95); // "第一步，是给领导留下个好印象。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1.7>audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.PlaySound("sounda", 0.0f, 0.5f, "<silence 2>", "audio/sound/moca1.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(0f, 0f)}, {"anchor", new Vector2(0f, 0f)}, {"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.5f}, {"pos", new Vector2(-576f, 180f)}, {"anchor", new Vector2(0f, 0f)}, {"zoom", 2.05f}, {"zpos", -390.0f}})});
            yield return _gameMethods.StopEngineTime(time:1.5f);
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-576f, 180f)}, {"anchor", new Vector2(0f, 0f)}, {"zoom", 2.05f}, {"zpos", -390.0f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/jingzi1.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.14f, 0.7f)}, {"zoom", 0.57f}})});
            yield return _gameMethods.Show("someone2", parts: new List<string>{"zui15"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.142f, 1.065f)}, {"zoom", 0.182f}}), new SameLineParamData(new Dictionary<string, object>{{"matrixcolor", new Matrixcolor(invertMatrix:0.16f, contrastMatrix:0.83f, saturationMatrix:1.0f, brightnessMatrix:-0.05f, hueMatrix:0.0f)}})});
            yield return _gameMethods.Transition(time:0.56f);
            yield return _gameMethods.OpenDialog(96); // "我坐到镜子前。"
            yield return _gameMethods.Show("someone2", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(97); // "话说，昨晚好像听到了一些骚乱。"
            yield return _gameMethods.Show("someone2", parts: new List<string>{"mei7", "yan10", "zui6"});
            yield return _gameMethods.OpenDialog(98); // "估计是又召开了什么宫廷宴会吧。总之和我不可能有关。"
            yield return _gameMethods.Show("someone2", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(21); // "…………"
            yield return _gameMethods.Show("someone2", parts: new List<string>{"mei7", "yan5", "zui9"});
            yield return _gameMethods.OpenDialog(99); // "「从今天起。」"
            yield return _gameMethods.Show("someone2", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(100); // "我对着镜子里的自己，无声说。"
            yield return _gameMethods.Show("someone2", parts: new List<string>{"mei7", "yan5", "zui9"});
            yield return _gameMethods.OpenDialog(442); // "要时刻记得，你要寄人篱下了。"
            yield return _gameMethods.Show("someone2", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(102); // "默念着这个事实，"
            yield return _gameMethods.Show("someone2", parts: new List<string>{"mei7", "yan5", "zui15", "er1", "er2"});
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai");
            yield return _gameMethods.OpenDialog(103); // "我把红宝石耳坠戴在双耳上。"
            yield return _gameMethods.Show("someone2", parts: new List<string>{"mei7", "yan8", "zui15", "er1", "er2"});
            yield return _gameMethods.OpenDialog(104); // "耳垂沉甸甸的，有些疼。"
            yield return _gameMethods.Show("someone2", parts: new List<string>{"mei7", "yan20", "zui15", "er1", "er2"});
            yield return _gameMethods.OpenDialog(105); // "挺好的。这能时刻提醒我自己的人身处境与社会地位。"
            yield return _gameMethods.Show("someone2", parts: new List<string>{"mei7", "yan5", "zui15", "er1", "er2", "emoji1", "emoji2"});
            yield return _gameMethods.OpenDialog(106); // "嘴角控制不住地下垂，我揉了揉脸。"
            yield return _gameMethods.Show("someone2", parts: new List<string>{"mei2", "yan5", "zui7", "er1", "er2", "-emoji1", "-emoji2"});
            yield return _gameMethods.OpenDialog(107); // "开心一点，[persistent.povname]。"
            yield return _gameMethods.OpenDialog(108); // "想要骗过别人，必须先骗过自己。"
            yield return _gameMethods.Show("someone2", parts: new List<string>{"mei5", "yan2", "zui1", "er1", "er2", "emoji7"});
            yield return _gameMethods.OpenDialog(109); // "对着镜中的人，我露出一个大大的灿烂笑脸。"
            yield return _gameMethods.Show("someone2", parts: new List<string>{"mei5", "yan2", "zui3", "er1", "er2", "emoji1", "emoji2", "emoji7"});
            yield return _gameMethods.OpenDialog(110); // "…好像有点谄媚。像搞推销的。"
            yield return _gameMethods.Show("someone2", parts: new List<string>{"mei1", "yan6", "zui16", "emoji1", "emoji2", "emoji6", "er1", "er2", "-emoji7"});
            yield return _gameMethods.OpenDialog(111); // "龙都比较高傲，万一它嫌我太卑微了怎么办？"
            yield return _gameMethods.Show("someone2", parts: new List<string>{"er1", "er2", "mei3", "yan12", "zui16", "-emoji6", "emoji1", "emoji2"});
            yield return _gameMethods.OpenDialog(112); // "不行，我得再欲擒故纵一下。"
            yield return _gameMethods.Show("someone2", parts: new List<string>{"er1", "er2", "mei6", "yan11", "zui6", "emoji1", "emoji2"});
            yield return _gameMethods.StopEngineTime(time:1f);
            yield return _gameMethods.Show("someone2", parts: new List<string>{"er1", "er2", "mei2", "yan1", "zui2", "emoji1", "emoji2"});
            yield return _gameMethods.StopEngineTime(time:1f);
            yield return _gameMethods.Show("someone2", parts: new List<string>{"er1", "er2", "mei6", "yan1", "zui1", "emoji1", "emoji2"});
            yield return _gameMethods.StopEngineTime(time:1f);
            yield return _gameMethods.Show("someone2", parts: new List<string>{"er1", "er2", "mei7", "yan11", "zui1", "-emoji1", "-emoji2", "emoji10"});
            yield return _gameMethods.OpenDialog(113); // "调整几下，"
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai");
            yield return _gameMethods.OpenDialog(114); // "终于找到了满意的笑容方式。"
            yield return _gameMethods.PlaySound("music", 0.0f, 0.9f, "Assets/RenpyResources/audio/demo_audio/music/qingkuai1.mp3");
            yield return _gameMethods.Show("someone2", parts: new List<string>{"er1", "er2", "mei3", "yan3", "zui8", "emoji7", "-emoji10"});
            yield return _gameMethods.OpenDialog(115); // "我的职业规划非常清晰。"
            yield return _gameMethods.OpenDialog(116); // "接下来，要把恶龙当作我未来几年的顶头上司。"
            yield return _gameMethods.Show("someone2", parts: new List<string>{"er1", "er2", "mei5", "yan3", "zui8", "emoji7"});
            yield return _gameMethods.OpenDialog(117); // "做到急领导之所急；"
            yield return _gameMethods.Show("someone2", parts: new List<string>{"er1", "er2", "mei5", "yan12", "zui7", "emoji7"});
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai");
            yield return _gameMethods.OpenDialog(118); // "/n想领导之所想；"
            yield return _gameMethods.Show("someone2", parts: new List<string>{"er1", "er2", "mei5", "yan5", "zui11", "emoji7"});
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai");
            yield return _gameMethods.OpenDialog(119); // "/n紧密地团结在领导周围，成为他称心满意的跟班。"
            yield return _gameMethods.Show("someone2", parts: new List<string>{"er1", "er2", "mei4", "yan12", "zui16", "emoji7"});
            yield return _gameMethods.OpenDialog(120); // "为自己争取最大程度的人身自由与生活福利。"
            yield return _gameMethods.OpenDialog(121); // "因此。"
            yield return _gameMethods.Show("someone2", parts: new List<string>{"er1", "er2", "mei7", "yan14", "zui6", "-emoji7"});
            yield return _gameMethods.OpenDialog(122); // "见面礼，是要有的。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/moca1.ogg");
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<silence 0.3>", "audio/demo_audio/sound/ding1.mp3");
            yield return _gameMethods.Show("someone2", parts: new List<string>{"er1", "er2", "mei7", "yan12", "zui6"});
            yield return _gameMethods.TransitionBy("None");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/huashu.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.14f, 0.64f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.18f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"matrixcolor", new Matrixcolor(invertMatrix:0.16f, contrastMatrix:0.83f, saturationMatrix:1.0f, brightnessMatrix:-0.05f, hueMatrix:0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/huashu.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"as", "huashu2"}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.11f, 1.01f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.55f}, {"alpha", 0f}, {"yoffset", -20f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("wu_nv_pangbai");
            yield return _gameMethods.OpenDialog(123); // "/n捧花，也不可或缺。"
            yield return _gameMethods.Show("someone2", parts: new List<string>{"er1", "er2", "mei7", "yan2", "zui6"});
            yield return _gameMethods.OpenDialog(124); // "听说龙都喜欢亮晶晶的东西，这个简单。/n我提前攒了满满一盒首饰，作为傍身之财。"
            yield return _gameMethods.Show("someone2", parts: new List<string>{"er1", "er2", "mei7", "yan9", "zui6"});
            yield return _gameMethods.OpenDialog(125); // "这并不难，国王给了我大量的宝石，似乎生怕我在第三者的眼中看起来不像一位公主。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 2>audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", -576f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.80f}, {"xpos", -768f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 180f}, {"zpos", -390.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.38f}, {"ypos", -18f}, {"zpos", -36.0f}})});
            yield return _gameMethods.Hide("someone2");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/jingzi1.png");
            yield return _gameMethods.Hide("huashu2");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/daoju/huashu.png");
            yield return _gameMethods.Transition(time:0.4f);
            yield return _gameMethods.OpenDialog(126); // "窗外霞光万里。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1>audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"xpos", -768f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -18f}, {"zpos", -36.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.82f}, {"ypos", 318f}, {"zpos", 0.0f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/huashu.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"xpos", -0.07f}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 1.04f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 1.61f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.82f}, {"ypos", 1.36f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan2", "zui14", "emoji2"});
            yield return _gameMethods.OpenDialog(127); // "我准备好一切，抱着花束，目光热烈地紧盯阳台，{nw}{w=0.15}"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/huashu.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-0.07f, 1.36f)}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-768f, 318f)}, {"zpos", 0.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(128); // "/n这辈子，就算是求婚时也不会再有这么认真了。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/moca1.ogg", "<silence 0.37>", "audio/sound/moca1.ogg");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/huashu.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 1.36f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.29f}, {"ypos", 1.32f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.19f}, {"ypos", 1.37f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.26f}, {"ypos", 1.32f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.20f}, {"ypos", 1.36f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan5", "zui13", "emoji7", "-emoji2"});
            yield return _gameMethods.OpenDialog(129); // "在恶龙到来的第一时间，我就要把花戳到它的鼻子底下，让它深深感受到我的热切欢迎与衷心爱戴。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/huashu.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 1.36f}})});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/door_qiao1.mp3", "<silence 0.2>", "audio/sound/door_open_3.mp3");
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:0.5f);
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice1_1ee9a704.ogg");
            yield return _gameMethods.OpenDialog(4); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(130); // "……………………"
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv", parts: new List<string>{"mei5", "yan5", "zui15", "emoji12"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice1_bdc65777.ogg");
            yield return _gameMethods.OpenDialog(131); // "晚上好。"
            yield return _gameMethods.SetDialogUIShowOrHide("hide");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/wanggongwoshi_huanghun_2.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(2.0f, 1.23f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.93f}})});
            yield return _gameMethods.Show("he", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(1.89f, 0.8f)}, {"zpos", 100.0f}, {"zoom", 0.11f}, {"anchor", new Vector2(0.5f, 1.0f)}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-768f, 318f)}, {"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeInBack", 0.5f}, {"ypos", 218f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.63f}, {"pos", new Vector2(4332f, 312f)}, {"zpos", 54.0f}})});
            yield return _gameMethods.StopEngineTime(time:1.13f);
            yield return _gameMethods.SetDialogUIShowOrHide("show");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui14", "-emoji7", "-emoji12"});
            yield return _gameMethods.OpenDialog(132); // "一个声音忽然响起，将我的目光拉至卧房门口。"
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/daoju/huashu.png");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(4332f, 312f)}, {"zpos", 54.0f}})});
            Defaults.Persistent.Jq_1_2 = 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan2", "zui14"});
            yield return _gameMethods.OpenDialog(133); // "不知何时，门已被打开，一名穿着衬衫礼服的男孩正安安静静地站在门外。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(135); // "他看起来很有教养，神态冷静，宛若某个贵族家的小少爷。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1>audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"easeOutBack", 0.91f}, {"pos", new Vector2(4014f, 36f)}, {"zpos", -288.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui2"});
            yield return _gameMethods.OpenDialog(136); // "咦，小弟弟，你是谁呀。迷路了吗？"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(4014f, 35f)}, {"zpos", -288.0f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan9", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui8"});
            yield return _gameMethods.OpenDialog(137); // "但外面有八队卫兵在轮番防守，怎么也不该迷路到这里。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui14"});
            yield return _gameMethods.OpenDialog(443); // "是我那便宜老爹又找到一个儿子？老头子基因这么好的吗。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 35f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.87f}, {"ypos", 317f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui14"});
            yield return _gameMethods.OpenDialog(139); // "——就在这时，我注意到一件事。"
            yield return _gameMethods.PlaySound("soundb", 0.0f, 1.0f, "audio/demo_audio/music/guiyi1.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 317f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui14"});
            yield return _gameMethods.OpenDialog(140); // "在他的脚边，仿佛躺着什么物体。"
            yield return _gameMethods.ExecuteShowScreenFunction("stop_screen", functionParams: new List<object>{1.5f});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.0f, saturationMatrix:1.0f, brightnessMatrix:0.0f, hueMatrix:0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.5f}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.96f, saturationMatrix:1.59f, brightnessMatrix:-0.07f, hueMatrix:0.0f)}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(4014f, 317f)}, {"zpos", -288.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.57f}, {"pos", new Vector2(4020f, 353f)}, {"zpos", -324.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui14"});
            yield return _gameMethods.OpenDialog(141); // "那是一只横着的人脚，"
            yield return _gameMethods.ExecuteShowScreenFunction("stop_screen", functionParams: new List<object>{1.5f});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -324.0f}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.96f, saturationMatrix:1.59f, brightnessMatrix:-0.07f, hueMatrix:0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.5f}, {"zpos", -400.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(142); // "小腿包裹着腿甲，"
            yield return _gameMethods.ExecuteShowScreenFunction("stop_screen", functionParams: new List<object>{1.42f});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(4020f, 353f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"pos", new Vector2(3936f, 353f)}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.96f, saturationMatrix:1.59f, brightnessMatrix:-0.07f, hueMatrix:0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.96f, saturationMatrix:1.59f, brightnessMatrix:-0.07f, hueMatrix:0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.01f}, {"matrixcolor", new Matrixcolor(invertMatrix:0.8f, contrastMatrix:1.96f, saturationMatrix:1.59f, brightnessMatrix:-0.07f, hueMatrix:0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"matrixcolor", new Matrixcolor(invertMatrix:0.8f, contrastMatrix:1.96f, saturationMatrix:1.59f, brightnessMatrix:-0.07f, hueMatrix:0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.01f}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.96f, saturationMatrix:1.59f, brightnessMatrix:-0.07f, hueMatrix:0.0f)}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(143); // "更上面的肢体看不见，被门框遮挡住了。"
            yield return _gameMethods.Show("he", parts: new List<string>{"zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(144); // "你好，我是来劫走你的。"
            yield return _gameMethods.SaveLastVoiceToTheEnd();
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteShowScreenFunction("stop_screen", functionParams: new List<object>{0.6f});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(3936f, 353f)}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.96f, saturationMatrix:1.59f, brightnessMatrix:-0.07f, hueMatrix:0.0f)}})});
            yield return _gameMethods.StopSound(channelName:"soundb");
            yield return _gameMethods.PlaySound("sound", 0.0f, 1f, "audio/demo_audio/sound/Simple Whoosh A.mp3");
            yield return _gameMethods.SetDialogUIShowOrHide("hide");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(3936f, 353f)}, {"zpos", -400.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"pos", new Vector2(3954f, -19f)}, {"zpos", -364.0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.96f, saturationMatrix:1.59f, brightnessMatrix:-0.07f, hueMatrix:0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.0f, saturationMatrix:1.0f, brightnessMatrix:0.0f, hueMatrix:0.0f)}})});
            yield return _gameMethods.StopEngineTime(time:0.6f);
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(3954f, -19f)}, {"zpos", -364.0f}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.0f, saturationMatrix:1.0f, brightnessMatrix:0.0f, hueMatrix:0.0f)}})});
            yield return _gameMethods.SetDialogUIShowOrHide("show");
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui15", "emoji2", "emoji5"});
            yield return _gameMethods.OpenDialog(21); // "…………"
            yield return _gameMethods.Hide("stop_screen");
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15", "emoji2", "emoji5"});
            yield return _gameMethods.OpenDialog(145); // "男孩见我还是一脸呆滞，又礼貌地解释了一句。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1>audio/demo_audio/sound/zu3_nv_zou.ogg");
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv_qian", parts: new List<string>{"mei7", "yan2", "zui15", "emoji2", "emoji5"});
            yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(1.89f, 0.8f)}, {"zpos", 100.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"pos", new Vector2(1.9f, 0.82f)}, {"zpos", 136.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv", parts: new List<string>{"mei7", "yan2", "zui15", "emoji2", "emoji5"});
            yield return _gameMethods.OpenDialog(146); // "我是这一代的黑暗之龙。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui2", "emoji2", "emoji13", "-emoji5"});
            yield return _gameMethods.OpenDialog(4); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui2", "emoji2", "emoji13", "-emoji5"});
            yield return _gameMethods.OpenDialog(21); // "…………"
            yield return _gameMethods.Show("he", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(1.9f, 0.82f)}, {"zpos", 136.0f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 3954f}, {"zpos", -364.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.8f}, {"xpos", 6300f}, {"zpos", 284.0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -19f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.8f}, {"ypos", 215f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1");
            yield return _gameMethods.OpenDialog(147); // "可是"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(6300f, 215f)}, {"zpos", 284.0f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(6300f, 215f)}, {"zpos", 284.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"pos", new Vector2(3972f, 5f)}, {"zpos", -334.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1");
            yield return _gameMethods.OpenDialog(148); // "/n你不是该从阳台飞进来吗？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan4", "zui9"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(3972f, 5f)}, {"zpos", -334.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv", parts: new List<string>{"mei7", "yan11", "zui8", "emoji2", "-emoji13"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice1_c9db7a9c.ogg");
            yield return _gameMethods.OpenDialog(149); // "？那样很不礼貌。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan4", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan11", "zui8", "emoji2"});
            yield return _gameMethods.OpenDialog(150); // "他不解地瞥了我一眼。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei1", "yan5", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(151); // "……抱歉，误会你了。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv", parts: new List<string>{"mei1", "yan5", "zui8", "emoji2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice1_cc4933e6.ogg");
            yield return _gameMethods.OpenDialog(152); // "没关系，我原谅你。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui11", "-emoji2"});
            yield return _gameMethods.OpenDialog(153); // "啊，对了。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.PlaySound("music", 0.0f, 0.8f, "audio/demo_audio/music/qingkuai1.mp3");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/huashu.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1f)}, {"xpos", 1.89f}, {"ypos", 294f}, {"zoom", 0.45f}, {"zpos", 136f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(154); // "我忙把之前准备好的花束献到他脸前。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan7", "zui2"});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/huashu.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.2f, "audio/sound/moca1.ogg");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/huashu.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(1.89f, 294f)}, {"anchor", new Vector2(0.5f, 1f)}, {"zoom", 0.45f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.41f}, {"pos", new Vector2(1.89f, 276f)}, {"anchor", new Vector2(0.5f, 1f)}, {"zoom", 0.25f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19", "emoji10"});
            yield return _gameMethods.OpenDialog(155); // "这个给你！"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv_qian", parts: new List<string>{"mei7", "yan11", "zui8", "emoji10"});
            yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan7", "zui9"});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/huashu.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(1.89f, 276f)}, {"anchor", new Vector2(0.5f, 1f)}, {"zoom", 0.25f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv", parts: new List<string>{"mei7", "yan11", "zui8", "emoji10"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice1_04a5ddf5.ogg");
            yield return _gameMethods.OpenDialog(156); // "这是什么。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan7", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19", "emoji10", "emoji9"});
            yield return _gameMethods.OpenDialog(157); // "花呀。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv", parts: new List<string>{"mei7", "yan2", "zui8", "emoji10", "emoji9"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice1_5d827522.ogg");
            yield return _gameMethods.OpenDialog(158); // "为什么要给我花。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui2", "-emoji10", "-emoji9", "emoji7"});
            yield return _gameMethods.OpenDialog(159); // "表达对你的欢迎呀！！嘿嘿。认识你很高兴。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv", parts: new List<string>{"mei7", "yan5", "zui8", "-emoji7"});
            yield return _gameMethods.OpenDialog(4); // "……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui8"});
            yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui8"});
            yield return _gameMethods.OpenDialog(160); // "他看上去困惑地反应了一会，语气平铺直叙。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(161); // "你应该害怕我。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/huashu.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1f)}, {"ypos", 276f}, {"zoom", 0.25f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.52f}, {"anchor", new Vector2(0.5f, 1f)}, {"ypos", 288f}, {"zoom", 0.29f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui1", "emoji2"});
            yield return _gameMethods.OpenDialog(162); // "…………对不起，该怕你的吗。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/huashu.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1f)}, {"ypos", 288f}, {"zoom", 0.29f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan12", "zui8", "emoji2"});
            yield return _gameMethods.OpenDialog(163); // "我内心挣扎了片刻，诚恳地解释。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(3972f, 5f)}, {"zpos", -334.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.30f}, {"pos", new Vector2(3948f, -19f)}, {"zpos", -364.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei4", "yan5", "zui9", "-emoji2"});
            yield return _gameMethods.OpenDialog(164); // "…是这样的，虽然表面上看不出来，但其实我在压抑内心的恐惧。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan27", "zui2"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(3948f, -19f)}, {"zpos", -364.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv", parts: new List<string>{"mei4", "yan5", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(165); // "？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv", parts: new List<string>{"mei4", "yan5", "zui15", "emoji2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice1_8485cfa5.ogg");
            yield return _gameMethods.OpenDialog(166); // "你编谎应该再编圆一点，至少该在表面上装出害怕的样子。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei5", "yan5", "zui9", "-emoji2"});
            yield return _gameMethods.OpenDialog(167); // "那我现在装还来得及吗。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv", parts: new List<string>{"mei4", "yan5", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(168); // "你可以不用装。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei5", "yan5", "zui10", "emoji2"});
            yield return _gameMethods.OpenDialog(169); // "谢谢。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv", parts: new List<string>{"mei5", "yan5", "zui15", "emoji2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice1_b39a3984.ogg");
            yield return _gameMethods.OpenDialog(170); // "不用谢。"
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}})});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/door_close1.mp3");
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(4); // "……"
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:2f);
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei5", "yan5", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(21); // "…………"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 25f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -221f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -528f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/wanggongwoshi_huanghun.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.61f, 0.53f)}, {"zpos", -20.0f}, {"zoom", 0.56f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui2", "emoji1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.51f, 0.88f)}, {"zoom", 0.18f}, {"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.3f}, {"alpha", 1.0f}})});
            yield return _gameMethods.HideBlack();
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui9", "-emoji2"});
            yield return _gameMethods.OpenDialog(171); // "啊，"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2", "-emoji1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui11"});
            yield return _gameMethods.OpenDialog(172); // "对了，"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan17", "zui19"});
            yield return _gameMethods.OpenDialog(173); // "我还有一个见面礼给你。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/baoshi.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.53f, 0.51f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.33f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv", parts: new List<string>{"mei7", "yan8", "zui8"});
            yield return _gameMethods.OpenDialog(4); // "……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan7", "zui2"});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/ding1.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui2", "emoji10"});
            yield return _gameMethods.OpenDialog(174); // "你看——！"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan7", "zui2"});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/baoshi.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(0.53f, 0.51f)}, {"zoom", 0.33000000000000007f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"pos", new Vector2(0.51f, 0.39f)}, {"zoom", 0.19f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19", "emoji9", "emoji10"});
            yield return _gameMethods.OpenDialog(175); // "都是宝石哦。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/baoshi.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(0.51f, 0.39f)}, {"zoom", 0.19f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"xpos", 25f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -221f}, {"zpos", -528.0f}, {"xpos", 25f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.8f}, {"ypos", -179f}, {"zpos", -630.0f}, {"xpos", 13f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan12", "zui8", "emoji2", "emoji9", "emoji10"});
            yield return _gameMethods.OpenDialog(176); // "绿松石、鸡血石、玛瑙、钻石……我心如刀割。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(13f, -179f)}, {"zpos", -630.0f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -179f}, {"zpos", -630.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.39f}, {"ypos", -251f}, {"zpos", -594.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan5", "zui8", "emoji2", "-emoji9", "-emoji10"});
            yield return _gameMethods.OpenDialog(177); // "为了缓解内心的疼痛，我把目光强制从首饰上移开，集中在恶龙的脸上。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui7", "-emoji2"});
            yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei4", "yan7", "zui2"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -251f}, {"zpos", -594.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui7", "-emoji2"});
            yield return _gameMethods.OpenDialog(178); // "对于我豪华的首饰盒，这个孩子却只是歪了歪头，没什么表情。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv", parts: new List<string>{"mei7", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(179); // "你的礼物很多。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei1", "yan17", "zui19"});
            yield return _gameMethods.OpenDialog(180); // "你不喜欢吗？我听说龙都喜欢亮晶晶的东西，所以特地给你准备的。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan18", "zui14"});
            yield return _gameMethods.OpenDialog(181); // "怎么回事，难道揣测上意失败，影响了我和未来老大的感情？"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan6", "zui15"});
            yield return _gameMethods.OpenDialog(182); // "这可不好。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv", parts: new List<string>{"mei7", "yan5", "zui14"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice1_54f8adbb.ogg");
            yield return _gameMethods.OpenDialog(183); // "你听到的没错，但我不明白你为什么要准备这些。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(13f, -251f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"pos", new Vector2(5f, -251f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"pos", new Vector2(21f, -252f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"pos", new Vector2(13f, -251f)}})});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/zhenjing_shuaidaoganjue.mp3");
            yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/demo_audio/music/qingkuai2.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei5", "yan5", "zui9"});
            yield return _gameMethods.OpenDialog(184); // "因为我喜欢你。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv", parts: new List<string>{"mei5", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(185); // "为什么喜欢我。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(186); // "本来我以为会是个非常可怕残忍的恶龙，都做好被打骂的准备了，打算用来贿赂它的。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(187); // "结果没想到你这么礼貌，所以，我想送给你当礼物。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan29", "zui2"});
            Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui2"});
            yield return _gameMethods.OpenDialog(188); // "而且，你这么可爱，有谁会不喜欢你吗。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv_qian", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan29", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.OpenDialog(21); // "…………"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan8", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv", parts: new List<string>{"mei7", "yan5", "zui8"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice1_74dd4a28.ogg");
            yield return _gameMethods.OpenDialog(189); // "……我只做必要的事，没有向人类施虐的兴趣。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan8", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(190); // "太好了！"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice1_28bcbc6c.ogg");
            yield return _gameMethods.OpenDialog(191); // "但你看起来需要提醒。"
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(444); // "你会被我带走，并在我的居所待三年。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan8", "zui7"});
            yield return _gameMethods.OpenDialog(4); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(193); // "是啊，太倒霉了。"
            Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/baoshi.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"xpos", 0.51f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.39f}, {"zoom", 0.19f}, {"alpha", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.54f}, {"ypos", 0.46f}, {"zoom", 0.24f}, {"alpha", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan17", "zui7"});
            yield return _gameMethods.OpenDialog(194); // "不过，现在看到你本身，我就开心多了。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan9", "zui2"});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/baoshi.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(0.51f, 0.46f)}, {"zoom", 0.24f}, {"alpha", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan11", "zui7"});
            yield return _gameMethods.OpenDialog(4); // "……"
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/daoju/baoshi.png");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan11", "zui7"});
            yield return _gameMethods.OpenDialog(195); // "他面无波澜地抬起那双石榴红的眼瞳，默默看了我半响。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv", parts: new List<string>{"mei7", "yan11", "zui7", "emoji2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice1_7a642ac9.ogg");
            yield return _gameMethods.OpenDialog(196); // "你很奇怪。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan17", "zui19", "-emoji2"});
            yield return _gameMethods.OpenDialog(197); // "哪里？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan8", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv", parts: new List<string>{"mei7", "yan17", "zui8"});
            yield return _gameMethods.OpenDialog(445); // "不怕么。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv_qian", parts: new List<string>{"mei7", "yan2", "zui14"});
            yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv", parts: new List<string>{"mei7", "yan2", "zui14"});
            yield return _gameMethods.OpenDialog(446); // "就我所知，人类生命短暂，格外惧怕这类事情。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan6", "zui15"});
            yield return _gameMethods.OpenDialog(200); // "它在问我的信息。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan6", "zui15"});
            yield return _gameMethods.OpenDialog(201); // "询问的背面就是好奇和在意。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(202); // "原本我担心龙对渺小的人类完全没有兴趣，现在看来事实并非如此。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(203); // "这是个好消息。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(204); // "怕，但也没用呀。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei1", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(205); // "我已经很倒霉了，如果怨天尤人，就更悲惨了。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei4", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(447); // "还不如乐观主动一点，这样，……还能保留一些尊严。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei4", "yan4", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv", parts: new List<string>{"mei3", "yan11", "zui8"});
            yield return _gameMethods.OpenDialog(207); // "……你的想法，真奇怪。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei4", "yan4", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui19"});
            yield return _gameMethods.OpenDialog(448); // "最后三年里能和你这么体谅人类的龙一起度过，我已经非常幸运了。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui2"});
            yield return _gameMethods.OpenDialog(449); // "阳光一点来想，我之所以被你带走，这一切都是为了让我们两个相遇。"
            Defaults.Haogandu_he = Defaults.Haogandu_he + 2;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei4", "yan5", "zui19"});
            yield return _gameMethods.OpenDialog(210); // "这么想是不是就浪漫多了？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan29", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv", parts: new List<string>{"mei4", "yan5", "zui8"});
            yield return _gameMethods.OpenDialog(21); // "…………"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei4", "yan8", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv", parts: new List<string>{"mei7", "yan5", "zui8"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice1_ae5aeb00.ogg");
            yield return _gameMethods.OpenDialog(211); // "很奇怪。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei4", "yan8", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei1", "yan11", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(212); // "……也不用重复三遍吧！我的心要受伤了。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv", parts: new List<string>{"mei1", "yan11", "zui8", "emoji2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice1_008ddcb0.ogg");
            yield return _gameMethods.OpenDialog(213); // "但是，你没有撒谎。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -251f}, {"zpos", -594.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeInBack", 0.45f}, {"ypos", -263f}, {"zpos", -624.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui2", "-emoji2"});
            yield return _gameMethods.OpenDialog(214); // "……哇，你愿意相信我的心吗？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -263f}, {"zpos", -624.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice1_0dd7ccc3.ogg");
            yield return _gameMethods.OpenDialog(215); // "我相信我的权柄。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan7", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv_qian", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(216); // "「从你身上，{nw}{w=0.001}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv_qian");
            yield return _gameMethods.OpenDialog(217); // "我没有看到任何负面情绪。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei9", "yan5", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(218); // "……你还能看到别人身上的负面情绪？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei4", "yan25", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv", parts: new List<string>{"mei9", "yan5", "zui7", "emoji2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice1_378cbc4f.ogg");
            yield return _gameMethods.OpenDialog(219); // "……你不知道么。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv", parts: new List<string>{"mei9", "yan5", "zui7", "emoji2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice1_85a5f93d.ogg");
            yield return _gameMethods.OpenDialog(220); // "我头衔的全称是黑暗与灾厄之龙，掌管世间一切智慧生灵的悲痛、愤怒、仇恨与恐惧。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(4); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei6", "yan8", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(221); // "遭了，这么重要的情报怎么没人告诉我。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei6", "yan12", "zui8", "emoji2"});
            yield return _gameMethods.OpenDialog(450); // "这样的话，我的情绪在他的视线下岂不是一目了然了！"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan20", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan20", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(223); // "……幸运的是，听口风，刚刚我还没有泄露出任何纰漏。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan20", "zui15"});
            yield return _gameMethods.OpenDialog(224); // "接下来必须小心了。"
            yield return _gameMethods.EngineSetVolume(volume:0f, delay:2f, channelName:"music");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui18"});
            yield return _gameMethods.OpenDialog(21); // "…………"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan20", "zui15"});
            yield return _gameMethods.OpenDialog(107); // "开心一点，[persistent.povname]。"
            yield return _gameMethods.ShowBlack(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.3f}, {"alpha", 1.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan20", "zui15"});
            yield return _gameMethods.OpenDialog(225); // "你必须开心才行。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan8", "zui9"});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/door_open_3.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(-30f, 6f)}, {"zpos", -198.0f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg4_memory.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg4_memory.jpg");
            yield return _gameMethods.Scene("tiankong_bangwan_yundong");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/yangtai_yuanchujianzhu.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(294f, -24f)}, {"zpos", 30.0f}, {"zoom", 0.54f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/yangtai_jinchulangan.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(180f, -12f)}, {"zpos", 260.0f}, {"zoom", 0.5f}})});
            yield return _gameMethods.Transition(time:1f);
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(492f, 220f)}, {"zpos", 270.0f}, {"zoom", 0.17f}})});
            yield return _gameMethods.Transition(time:0.5f);
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv_qian", parts: new List<string>{"mei3", "yan20", "zui15"});
            yield return _gameMethods.OpenDialog(226); // "{nw}{w=0.2}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv", parts: new List<string>{"mei3", "yan20", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice1_486a5b36.ogg");
            yield return _gameMethods.OpenDialog(227); // "已经耽误够久了，出发吧。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan8", "zui2"});
            yield return _gameMethods.EngineSetVolume(volume:1f, delay:0.5f, channelName:"music");
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.OpenDialog(228); // "现在该怎么走？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice1_e867df83.ogg");
            yield return _gameMethods.OpenDialog(229); // "你可以坐在我身上。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -198.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.25f}, {"zpos", -222.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui9"});
            yield return _gameMethods.OpenDialog(230); // "…………真的可以吗？"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-30f, 6f)}, {"zpos", -222.0f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui14"});
            yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui14"});
            yield return _gameMethods.OpenDialog(231); // "我委婉地提问。见他石榴红的眼睛把目光投过来，便又解释。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(232); // "我是说，虽然我是一名体态轻盈的淑女，但你的体格看起来还没发育完全，可能……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan4", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv_qian", parts: new List<string>{"mei7", "yan5", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(233); // "「？{nw}{w=0.001}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan4", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv_qian");
            yield return _gameMethods.OpenDialog(234); // "我不小。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei4", "yan25", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv", parts: new List<string>{"mei7", "yan5", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(235); // "我在幼年期就已经达到了17英尺高，800磅重。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.5f, "audio/sound/moca1.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-30f, 6f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"pos", new Vector2(-35f, 6f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"pos", new Vector2(-25f, 6f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"pos", new Vector2(-30f, -3f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"pos", new Vector2(-31f, 8f)}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei6", "yan1", "zui20", "emoji2", "emoji6", "emoji13"});
            yield return _gameMethods.OpenDialog(236); // "……五米高，400公斤的巨龙。这是幼年期？？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei6", "yan10", "zui8", "emoji2", "emoji6", "emoji13"});
            yield return _gameMethods.OpenDialog(237); // "外表也太有欺骗性了吧，说是构成诈骗也不为过了。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui8", "emoji2", "-emoji6", "-emoji13"});
            yield return _gameMethods.OpenDialog(238); // "那你现在是什么期呢？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan28", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv", parts: new List<string>{"mei7", "yan11", "zui8", "emoji2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice1_997a9a5a.ogg");
            yield return _gameMethods.OpenDialog(4); // "……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan11", "zui8", "emoji2"});
            yield return _gameMethods.OpenDialog(239); // "他沉默了一会儿，才仿若有些不太情愿地开口。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan10", "zui9", "-emojji16"});
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv", parts: new List<string>{"mei7", "yan11", "zui8", "emoji2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice1_4b3b8ec2.ogg");
            yield return _gameMethods.OpenDialog(240); // "我很快就会到达成长期了，只剩三年。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan10", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui8", "-emoji2"});
            yield return _gameMethods.OpenDialog(241); // "所以目前还在幼年期是吗。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui19"});
            yield return _gameMethods.OpenDialog(242); // "龙的幼年期有多长时间呢？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice1_ead0385c.ogg");
            yield return _gameMethods.OpenDialog(243); // "一百五十年。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -222.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.37f}, {"zpos", -168.0f}})});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/wuyu.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan10", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(244); // "你好，巨龙爷爷。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui2", "-emoji2"});
            yield return _gameMethods.OpenDialog(245); // "啊对了，还没问你的名字呢！我叫[persistent.povname]，你呢？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice1_80e5e99b.ogg");
            yield return _gameMethods.OpenDialog(246); // "赫泽尔·尼德霍格。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei4", "yan5", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(247); // "太有档次了吧！"
            
            if (Defaults.Persistent.Povname != "")
            {
                Defaults.Persistent.Povnamelenth=Defaults.Persistent.Povname.Length;

            }
            else
            {
                Defaults.Persistent.Povnamelenth=1;

            }
            if (Defaults.Persistent.Povnamelenth <= 3)
            {
                yield return _gameMethods.ChangeLabelTo("label_mingzi1");

            }
            else
            {
                yield return _gameMethods.ChangeLabelTo("label_mingzi2");

            }
            Defaults.Haogandu_he = Defaults.Haogandu_he + 2;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui19"});
            yield return _gameMethods.OpenDialog(248); // "那我叫你赫泽尔可以吗？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:4f);
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui8"});
            yield return _gameMethods.OpenDialog(249); // "可以。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 8f}, {"zpos", -168.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.54f}, {"ypos", -34f}, {"zpos", -270.0f}})});
            yield return _gameMethods.Show("he", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 270.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.50f}, {"zpos", 260.0f}})});
            yield return _gameMethods.Hide("he", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveTime", 0.2f}})});
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/yangtai_jinchulangan.png");
            yield return _gameMethods.TransitionBy("None");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/yangtai_jinchulangan.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"at", "default"}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(180f, -12f)}, {"zpos", 260.0f}, {"anchor", new Vector2(0f, 0f)}, {"zoom", 0.5f}})});
            yield return _gameMethods.StopEngineTime(time:0.4f);
            yield return _gameMethods.OpenDialog(250); // "赫泽尔从阳台跳下。"
            yield return _gameMethods.SceneBlack(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "fade"}})});
            yield return _gameMethods.OpenDialog(4); // "……"
            yield return _gameMethods.PlaySound("soundb", 2f, 1.0f, "audio/demo_audio/sound/longpaidachibang.mp3");
            yield return _gameMethods.ShowWhite();
            yield return _gameMethods.HideWhite(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "dissolve"}})});
            yield return _gameMethods.OpenDialog(4); // "……"
            Engine._dismiss_pause = false;
            yield return _gameMethods.ShowWhite();
            yield return _gameMethods.HideWhite(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveTime", 0.1f}})});
            yield return _gameMethods.SetDialogUIShowOrHide("hide");
            yield return _gameMethods.Show("tiankong_bangwan_yundong", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"ypos", 0.98f}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 1.34f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/yangtai_yuanchujianzhu.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"at", "default"}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(294f, -24f)}, {"zpos", 30.0f}, {"anchor", new Vector2(0f, 0f)}, {"zoom", 0.54f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.24f}, {"pos", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 1.88f}, {"pos", new Vector2(24f, -318f)}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -150.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 1.24f}, {"zpos", -174.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 1.88f}, {"zpos", -200.0f}})}, parallel_2: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"matrixTransform", new MatrixTransform(ScaleMatrix: new Vector3(1.0f, 1.0f, 1.0f), RotateMatrix: new Vector3(0.0f, 0.0f, 0.0f), OffsetMatrix: new Vector3(0.0f, 0.0f, 0.0f))}, {"alpha", 1.0f}, {"additive", 0.0f}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.0f, saturationMatrix:1.0f, brightnessMatrix:0.0f, hueMatrix:0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.24f}, {"matrixTransform", new MatrixTransform(ScaleMatrix: new Vector3(1.0f, 1.0f, 1.0f), RotateMatrix: new Vector3(0.0f, 0.0f, 0.0f), OffsetMatrix: new Vector3(0.0f, 0.0f, 0.0f))}, {"alpha", 1.0f}, {"additive", 0.0f}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.0f, saturationMatrix:1.0f, brightnessMatrix:0.0f, hueMatrix:0.0f)}})}, parallel_3: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.60f}, {"blur", 4.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.20f}, {"blur", 10.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.10f}, {"blur", 4.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.34f}, {"blur", 4.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.13f}, {"blur", 13.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.13f}, {"blur", 6.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.30f}, {"blur", 10.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.32f}, {"blur", 15.0f}})});
            yield return _gameMethods.Show("heilong_huanghun_yundong", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0f, 0f)}, {"zoom", 1.0f}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 96f}, {"zpos", 150.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 3.12f}, {"xpos", 96f}, {"zpos", 84.0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 558f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 3.12f}, {"ypos", -354f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/yangtai_jinchulangan.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"at", "default"}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0f, 0f)}, {"pos", new Vector2(222f, 72f)}, {"zoom", 0.47f}, {"zpos", 260.0f}})});
            yield return _gameMethods.Transition(time:0.5f);
            yield return _gameMethods.StopEngineTime(time:3.12f);
            yield return _gameMethods.SetDialogUIShowOrHide("show");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/yangtai_jinchulangan.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0f, 0f)}, {"pos", new Vector2(222f, 72f)}, {"zoom", 0.47f}})});
            yield return _gameMethods.OpenDialog(251); // "不一会儿，我看到两双巨大而漂亮的黑色肉翼有力地拍打着，逐渐从阳台边缘浮了上来。"
            yield return _gameMethods.SetDialogUIShowOrHide("hide");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -318f}, {"zpos", -200.0f}, {"blur", 15.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.87f}, {"ypos", -138f}, {"zpos", 0.0f}, {"blur", 0.0f}})});
            yield return _gameMethods.StopEngineTime(time:1.97f);
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -138f}, {"zpos", 0.0f}, {"blur", 0.0f}})});
            yield return _gameMethods.StopEngineTime(time:1f);
            yield return _gameMethods.ShowWhite(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveTime", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(18f, -138f)}, {"zpos", 270.0f}, {"anchor", new Vector2(0f, 0f)}, {"zoom", 1.19f}})});
            yield return _gameMethods.Hide("heilong_huanghun_yundong");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/yangtai_jinchulangan.png");
            yield return _gameMethods.StopEngineTime(time:0.4f);
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_portrait/he/heilong_huanghun.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0f, 0f)}, {"zoom", 1.0f}, {"xpos", 96f}, {"zpos", 84.0f}, {"ypos", -354f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/yangtai_jinchulangan.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"at", "default"}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0f, 0f)}, {"pos", new Vector2(222f, 72f)}, {"zoom", 0.47f}, {"zpos", 260.0f}})});
            yield return _gameMethods.HideWhite(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveTime", 1f}})});
            yield return _gameMethods.StopEngineTime(time:0.4f);
            yield return _gameMethods.SetDialogUIShowOrHide("show");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan2", "zui9"});
            yield return _gameMethods.OpenDialog(252); // "巨龙的轮廓渐渐清晰，完整地呈现在我的眼前。"
            yield return _gameMethods.SetDialogUIShowOrHide("hide");
            yield return _gameMethods.PlaySound("sounda", 0.0f, 0.9f, "'<silence 0.2>'", "audio/demo_audio/sound/Tension Riser B.mp3");
            yield return _gameMethods.PlaySound("music", 0.0f, 1f, "'<silence 1.4>'", "audio/demo_audio/music/flying force combat.mp3");
            yield return _gameMethods.Show("tiankong_bangwan_yundong", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.0f, saturationMatrix:1.0f, brightnessMatrix:0.0f, hueMatrix:0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.66f}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.0f, saturationMatrix:1.0f, brightnessMatrix:0.0f, hueMatrix:0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.20f}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.0f, saturationMatrix:1.0f, brightnessMatrix:0.0f, hueMatrix:0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.13f}, {"matrixcolor", new Matrixcolor(invertMatrix:2.93f, contrastMatrix:1.0f, saturationMatrix:1.0f, brightnessMatrix:0.0f, hueMatrix:0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.13f}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.0f, saturationMatrix:1.0f, brightnessMatrix:0.0f, hueMatrix:0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.29f}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.0f, saturationMatrix:1.0f, brightnessMatrix:0.0f, hueMatrix:0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.13f}, {"matrixcolor", new Matrixcolor(invertMatrix:2.93f, contrastMatrix:1.0f, saturationMatrix:1.0f, brightnessMatrix:0.0f, hueMatrix:0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.20f}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.0f, saturationMatrix:1.0f, brightnessMatrix:0.0f, hueMatrix:0.0f)}})});
            yield return _gameMethods.ShowBlack(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"at", "default"}, {"as", "black2"}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"additive", 0.0f}, {"zpos", 260f}, {"pos", new Vector2(-36f, -396f)}, {"anchor", new Vector2(0f, 0f)}, {"zoom", 2.39f}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.0f, saturationMatrix:1.0f, brightnessMatrix:0.0f, hueMatrix:0.0f)}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"drawScreen", "black"}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.22f}, {"alpha", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.43f}, {"alpha", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.01f}, {"alpha", 0.0f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"alpha", 1.0f}, {"additive", 0.0f}, {"blur", 0.0f}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -138f}, {"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.32f}, {"pos", new Vector2(0f, -138f)}, {"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"pos", new Vector2(-264f, -294f)}, {"zpos", -378.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 2.84f}, {"pos", new Vector2(-264f, -294f)}, {"zpos", -378.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 1.42f}, {"pos", new Vector2(-360f, -306f)}, {"zpos", -498.0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.0f, saturationMatrix:1.0f, brightnessMatrix:0.0f, hueMatrix:0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.86f}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.0f, saturationMatrix:1.0f, brightnessMatrix:0.0f, hueMatrix:0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.13f}, {"matrixcolor", new Matrixcolor(invertMatrix:1.11f, contrastMatrix:1.0f, saturationMatrix:1.0f, brightnessMatrix:0.0f, hueMatrix:0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.13f}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.0f, saturationMatrix:1.0f, brightnessMatrix:0.0f, hueMatrix:0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.29f}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.0f, saturationMatrix:1.0f, brightnessMatrix:0.0f, hueMatrix:0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.13f}, {"matrixcolor", new Matrixcolor(invertMatrix:1.11f, contrastMatrix:1.0f, saturationMatrix:1.0f, brightnessMatrix:0.0f, hueMatrix:0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.20f}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.0f, saturationMatrix:1.0f, brightnessMatrix:0.0f, hueMatrix:0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.49f}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.0f, saturationMatrix:1.0f, brightnessMatrix:0.0f, hueMatrix:0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.42f}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.4f, saturationMatrix:3.06f, brightnessMatrix:0.02f, hueMatrix:0.0f)}})});
            yield return _gameMethods.StopEngineTime(time:4.75f);
            yield return _gameMethods.SetDialogUIShowOrHide("show");
            Engine._dismiss_pause = true;
            yield return _gameMethods.OpenDialog(253); // "那双血红的灯笼一般的兽瞳，居高临下地盯着我。"
            yield return _gameMethods.ShowBlack(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"as", "black2"}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-36f, -396f)}, {"anchor", new Vector2(0f, 0f)}, {"zoom", 2.39f}, {"alpha", 0.0f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-360f, -306f)}, {"zpos", -498.0f}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.4f, saturationMatrix:3.06f, brightnessMatrix:0.02f, hueMatrix:0.0f)}})});
            yield return _gameMethods.OpenDialog(254); // "有种脊背发寒的战栗感。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.4f, saturationMatrix:3.06f, brightnessMatrix:0.02f, hueMatrix:0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"easeOutCubic", 0.5f}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.5f, saturationMatrix:4.08f, brightnessMatrix:0.02f, hueMatrix:0.0f)}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan17", "zui18", "emoji2"});
            yield return _gameMethods.OpenDialog(255); // "……好可怕。同刚才孩童外形完全不可同日而语的压迫力。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan17", "zui18", "emoji2"});
            yield return _gameMethods.OpenDialog(453); // "我意识到，面前的这只巨兽只需漫不经心地落下一爪，就可以轻易让我动弹不得。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan5", "zui18", "-emoji2"});
            yield return _gameMethods.OpenDialog(257); // "……但，"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -306f}, {"zpos", -498.0f}}), new SameLineParamData(new Dictionary<string, object>{{"bopOutTimeWarp", 0.50f}, {"ypos", -320f}, {"zpos", -530.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(258); // "不能退缩。"
            yield return _gameMethods.SceneBlack(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"at", "default"}, {"dissolveType", "dissolve"}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(0f, -390f)}, {"zoom", 4f}})});
            yield return _gameMethods.StopSound(channelName:"soundb");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(259); // "裹紧身上的斗篷，我跳上了他的背部，抱住巨龙的脊梁。"
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:3f);
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/feng2.mp3");
            yield return _gameMethods.OpenDialog(260); // "他在确认我坐稳了之后，平稳地开始升空。"
            yield return _gameMethods.PlaySound("soundb", 0.0f, 0.7f, "audio/demo_audio/sound/longpaidachibang.mp3", "<silence 2>", "audio/demo_audio/sound/longpaidachibang.mp3", "<silence 1>", "audio/demo_audio/sound/longpaidachibang.mp3", "<silence 3>");
            yield return _gameMethods.OpenDialog(261); // "变高了。"
            yield return _gameMethods.PlaySound("soundc", 2f, 0.6f, "audio/demo_audio/sound/tiankong_huanjin.ogg");
            yield return _gameMethods.OpenDialog(262); // "更高了。"
            yield return _gameMethods.EngineSetVolume(volume:0.5f, delay:1f, channelName:"soundb");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.0f, saturationMatrix:1.0f, brightnessMatrix:0.0f, hueMatrix:0.0f)}})});
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/demo_audio/sound/zhongsheng_niao.mp3");
            yield return _gameMethods.HideBlack();
            yield return _gameMethods.Show("fly_cg_ani");
            yield return _gameMethods.Transition(time:2f);
            yield return _gameMethods.OpenDialog(263); // "他开始飞驶。"
            yield return _gameMethods.EngineSetVolume(volume:1f, delay:3f, channelName:"soundb");
            yield return _gameMethods.OpenDialog(264); // "我迎着风流，探出头来，看到环绕城堡的围墙中，国王与他周身的护卫队都仰着头，欢欣鼓舞、弹冠相庆地目送我们离开。"
            yield return _gameMethods.OpenDialog(265); // "我对他们举起了手，做出一个国际间用于表达友好的手势。"
            yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/demo_audio/music/youshang2.mp3");
            yield return _gameMethods.Show("fly_cg_ani", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "blink2"}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.56f, 1.25f)}, {"zoom", 1.37f}})});
            yield return _gameMethods.OpenDialog(266); // "飞出城堡后，我看到王都的人纷纷从房屋中涌出，聚集在大街小巷里，抬头看着我们。"
            yield return _gameMethods.OpenDialog(267); // "我朝他们挥手。"
            yield return _gameMethods.OpenDialog(268); // "有几个贫民窟的孩子伸手想回应我，随即被旁边的母亲拉下了胳膊，好像生怕被传说中的恶龙注意到。"
            yield return _gameMethods.OpenDialog(269); // "底层的平民总是生活得如此步履薄冰、小心翼翼。"
            yield return _gameMethods.OpenDialog(270); // "我试图从王城中找到我曾工作过的那个面包坊，还有面包坊对面的那家肉铺。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/feng1.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}, {"blur", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.27f}, {"xpos", 90f}, {"blur", 30f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.46f}, {"xpos", 36f}, {"blur", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.55f}, {"xpos", 90f}, {"blur", 30f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.29f}, {"xpos", 66f}, {"blur", 0.0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.27f}, {"ypos", 66f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.46f}, {"ypos", 36f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.55f}, {"ypos", 18f}})});
            yield return _gameMethods.OpenDialog(271); // "但还未找到，便被风吹得迷了眼睛。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(66f, 18f)}, {"blur", 0.0f}})});
            yield return _gameMethods.ShowBlack(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 2f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(272); // "只一阵功夫，人们的身影便越来越小，逐渐变成了一只只瓢虫与蚂蚁。"
            yield return _gameMethods.Show("tiankong_bangwan_yundong_1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "dissolve"}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.3f}})});
            yield return _gameMethods.OpenDialog(273); // "城市消失在我的视野之中。"
            yield return _gameMethods.HideBlack();
            yield return _gameMethods.OpenDialog(21); // "…………"
            yield return _gameMethods.OpenDialog(274); // "赫泽尔飞得很低很慢，因此高空的寒流与气流虽然有点折磨人，但至少还到不了要我小命的地步。"
            yield return _gameMethods.OpenDialog(275); // "我抓住了他的几片龙鳞，小心留意不被锋利的边缘割破手。"
            yield return _gameMethods.OpenDialog(276); // "这些黑曜石一般的鳞片十分漂亮，遇到光照时会晕出一道道神秘的炫彩。如果一定要形容的话，那就是五彩斑斓的黑。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan12", "zui8"});
            yield return _gameMethods.OpenDialog(277); // "我深深地吸了一口气。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan12", "zui8"});
            yield return _gameMethods.OpenDialog(4); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan8", "zui18", "emoji2"});
            yield return _gameMethods.OpenDialog(278); // "半小时后，我意识到胳膊的酸痛。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan20", "zui18", "emoji2"});
            yield return _gameMethods.OpenDialog(279); // "现在可不是滑落下去的时机。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan12", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(280); // "我狠了狠心，手指摸到龙鳞的边缘，"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan8", "zui9", "emoji2"});
            yield return _gameMethods.OpenDialog(281); // "接着，弯曲指节，"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan20", "zui18", "emoji2"});
            yield return _gameMethods.OpenDialog(282); // "抠住缝隙。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(66f, 6f)}, {"blur", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"pos", new Vector2(61f, 18f)}, {"blur", 30f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"pos", new Vector2(71f, 18f)}, {"blur", 20f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"pos", new Vector2(66f, 9f)}, {"blur", 20f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"pos", new Vector2(65f, 20f)}, {"blur", 0f}})});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/zhenjing_shuaidaoganjue.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei6", "yan11", "zui18", "emoji2", "emoji13"});
            yield return _gameMethods.OpenDialog(47); // "……！"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(65f, 20f)}, {"blur", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan12", "zui15", "emoji2", "-emoji13"});
            yield return _gameMethods.OpenDialog(283); // "锋利的鳞片扎进了皮肉。钻心的疼痛在一瞬间刺激着我的鼻子。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan8", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(454); // "乐观点看，我很高兴它没有让我失去意识。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan8", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(285); // "然而，这并非长久之策。"
            yield return _gameMethods.ShowBlack(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 2f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan8", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(286); // "靠着疼痛的刺激又挺了一个小时，我终于到极限了。"
            yield return _gameMethods.ShowBlack(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 2f}, {"alpha", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(287); // "赫泽尔，赫泽尔？能听见我说话吗？"
            yield return _gameMethods.HideBlack();
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei9", "yan11", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(288); // "我的声音一出口，就被风吹成了破碎的片段。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei9", "yan11", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(21); // "…………"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei2", "yan2", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(289); // "没有回答。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui18", "-emoji2"});
            yield return _gameMethods.OpenDialog(290); // "我咬了咬牙，继续坚持。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui18"});
            yield return _gameMethods.OpenDialog(291); // "忍耐吧，[persistent.povname]，你已经靠着忍耐，成功地渡过了很多困难。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui18"});
            yield return _gameMethods.OpenDialog(292); // "所以，接下来的，也一定可以。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}, {"blur", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.27f}, {"xpos", 90f}, {"blur", 30f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.46f}, {"xpos", 36f}, {"blur", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.55f}, {"xpos", 90f}, {"blur", 30f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.29f}, {"xpos", 66f}, {"blur", 0.0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.27f}, {"ypos", 66f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.46f}, {"ypos", 36f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.55f}, {"ypos", 18f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan12", "zui18"});
            yield return _gameMethods.OpenDialog(293); // "……眩晕。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan12", "zui18"});
            yield return _gameMethods.OpenDialog(294); // "火烧一般的辣度从十指传达到心脉。"
            yield return _gameMethods.ShowBlack(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 2f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1f}})});
            yield return _gameMethods.StopSound(channelName:"soundc", fadeOut:4f);
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan21", "zui14"});
            yield return _gameMethods.OpenDialog(295); // "直到几分钟后，我意识到周围的景物正在上升"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui9"});
            yield return _gameMethods.OpenDialog(296); // "——或者说，我正在下降。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/feng2.mp3");
            yield return _gameMethods.PlaySound("sounda", 0.0f, 0.8f, "<silence 1>", "audio/demo_audio/sound/flapping_wings_01.mp3");
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:2f);
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(297); // "赫泽尔的翅膀越来越慢，最终停在地面上。"
            yield return _gameMethods.PlaySound("sounda1", 0.0f, 4f, "audio/sound/emeng_dajie/Body_up_01.mp3");
            yield return _gameMethods.OpenDialog(298); // "我终于支撑不住，滑落下来。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg5_memory.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg5_memory.jpg");
            yield return _gameMethods.ShowBlack(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 2f}, {"alpha", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 0f}})});
            yield return _gameMethods.Show("senlin1_bangwan", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 8f}})});
            yield return _gameMethods.Show("heilong_huanghun_ban_layered", parts: new List<string>{"yan_zhengyanxia"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.85f, 1.25f)}, {"zoom", 1.31f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice1_4e168dbc.ogg");
            yield return _gameMethods.OpenDialog(299); // "你想说什么？"
            yield return _gameMethods.OpenDialog(300); // "他作为龙时的嗓音一点也不像人类，显得更加冷酷无情。"
            yield return _gameMethods.Hide("tiankong_bangwan_yundong");
            yield return _gameMethods.Hide("tiankong_bangwan_yundong_1");
            yield return _gameMethods.HideBlack();
            yield return _gameMethods.Show("heilong_huanghun_ban_layered", parts: new List<string>{"yan_xia"});
            yield return _gameMethods.OpenDialog(301); // "这时，他耸动了下鼻翼，似乎闻到了什么气味，视线落到我伤痕累累的手上。"
            yield return _gameMethods.OpenDialog(302); // "黑龙面无波澜，仿佛对这些事物的出现有点迷惑。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan11", "zui1", "emoji2"});
            yield return _gameMethods.OpenDialog(303); // "我讪笑着遮住伤痕。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui1", "emoji2"});
            yield return _gameMethods.OpenDialog(304); // "我胳膊酸了……抱不住你的脖子了。"
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan11", "zui8", "emoji2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice1_405d58b4.ogg");
            yield return _gameMethods.OpenDialog(4); // "……"
            yield return _gameMethods.Show("heilong_huanghun_ban_layered", parts: new List<string>{"yan_miyanxia"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan11", "zui8", "emoji2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice1_8a3c04ee.ogg");
            yield return _gameMethods.OpenDialog(305); // "你好弱。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(455); // "他语气平淡，口吻中透露出“你好麻烦”的味道。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei9", "yan12", "zui8", "emoji2"});
            yield return _gameMethods.OpenDialog(307); // "我能怎样呢，我沉重地低下了头。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei9", "yan12", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(308); // "生而为人，我很抱歉。"
            yield return _gameMethods.ShowBlack(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 2f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1f}})});
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:4f);
            yield return _gameMethods.PlaySound("soundb", 1f, 1.0f, "audio/demo_audio/sound/chong1.ogg");
            yield return _gameMethods.OpenDialog(21); // "…………"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/senlin1_wan.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveTime", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(309); // "赫泽尔在森林里找了一只森林巨猿，威胁后者带领他摸回族群领地。"
            yield return _gameMethods.HideBlack();
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui8", "emoji2"});
            yield return _gameMethods.OpenDialog(310); // "……具体的威胁方式，就是用那双猩红的巨瞳默默盯着对方。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui8", "emoji2"});
            yield return _gameMethods.OpenDialog(311); // "森林巨猿在他的盯视下，没两秒便瑟瑟发抖地抱住头颅，趴伏在地。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(312); // "赫泽尔又转头看了看我。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan12", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(313); // "本外交大使走上前，对森林巨猿比划起来。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan10", "zui8", "emoji2"});
            yield return _gameMethods.OpenDialog(314); // "享受到了一种狐假虎威的快感。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan2", "zui7", "-emoji2"});
            yield return _gameMethods.OpenDialog(315); // "发动整个巨猿群落的力量，我获得了一个编织藤筐。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(316); // "可以盛放一名公主。"
            yield return _gameMethods.ShowBlack(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 2f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(21); // "…………"
            yield return _gameMethods.OpenDialog(33); // "………………"
            yield return _gameMethods.PlaySound("soundc", 0.0f, 1.0f, "audio/demo_audio/sound/longpaidachibang.mp3");
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:2f);
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg6_memory.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg6_memory.jpg");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_waichengqiang.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.56f, 0f)}, {"anchor", new Vector2(0.5f, 1f)}})});
            yield return _gameMethods.Transition(time:1f);
            yield return _gameMethods.OpenDialog(317); // "经历了一番波折，总算到达了——……"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_waichengqiang.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.65f}, {"ypos", -84f}})});
            yield return _gameMethods.StopSound(channelName:"soundc", fadeOut:1f);
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/feng2.mp3");
            yield return _gameMethods.OpenDialog(318); // "…………龙的巢穴。"
            yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/demo_audio/music/youshang2.mp3");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_waichengqiang.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -84f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.74f}, {"ypos", 450f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 2.07f)}, {"zoom", 0.27f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"alpha", 1f}})});
            Defaults.Persistent.Jq_1_3 = 1;
            yield return _gameMethods.OpenDialog(319); // "赫泽尔把装盛我的藤篮放在地上，就化成了人形。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 450f}})});
            yield return _gameMethods.Show("he", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(320); // "我僵硬地蜷缩着双手，艰难地从藤篮的边缘爬下来，{nw}{w=0.3}"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/zhenjing_shuaidaoganjue.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -14f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 14f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -7f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})}, parallel_2: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 450f}, {"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.21f}, {"ypos", 690f}, {"zpos", -288f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan8", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(321); // "甚至差点摔了一跤。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei12", "yan16", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(4); // "……"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 690f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.47f}, {"ypos", 408f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui14", "emoji2"});
            yield return _gameMethods.OpenDialog(322); // "抬起头时，看见他在用一种难以言喻的眼神俯视我。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 408f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui14", "emoji2"});
            yield return _gameMethods.OpenDialog(323); // "仿佛从未想过世界上竟还有如此没用的生物似的。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei12", "yan16", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei2", "yan11", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(324); // "欸嘿嘿……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei4", "yan4", "zui2"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"xpos", 80f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan22", "zui2"});
            yield return _gameMethods.OpenDialog(325); // "我装傻般欲盖弥彰地笑了笑，看向城堡。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 80f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(80f, 408f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"pos", new Vector2(218f, 360f)}})});
            yield return _gameMethods.OpenDialog(326); // "——首先看到的就是外侧环绕的一道城墙的大门。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(218f, 360f)}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 360f}, {"zpos", -288.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.65f}, {"ypos", -132f}, {"zpos", -180.0f}})});
            yield return _gameMethods.OpenDialog(21); // "…………"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -132f}, {"zpos", -180.0f}})});
            yield return _gameMethods.OpenDialog(4); // "……"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -132f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.66f}, {"ypos", 444f}})});
            yield return _gameMethods.OpenDialog(33); // "………………"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 444f}})});
            yield return _gameMethods.OpenDialog(327); // "一般情况下，这里是用来供骑兵和哨卫轮值驻守，监督人员进出的。"
            yield return _gameMethods.OpenDialog(328); // "显然，这座城堡规模宏大，占地甚广。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 218f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.8f}, {"xpos", 8f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan6", "zui19", "-emoji2"});
            yield return _gameMethods.OpenDialog(329); // "你的家——"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 8f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan6", "zui8", "emoji2"});
            yield return _gameMethods.OpenDialog(330); // "……呃，"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui2", "emoji2"});
            yield return _gameMethods.OpenDialog(331); // "好值钱呀。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan11", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(332); // "领主级别的城堡了吧这是。/n明明是头龙，居然拥有人类不动产！"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei4", "yan6", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei4", "yan11", "zui7", "emoji2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice1_ee9d2d1d.ogg");
            yield return _gameMethods.OpenDialog(333); // "嗯。这边。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 2>audio/demo_audio/sound/zu3_nv_zou.ogg");
            yield return _gameMethods.Hide("he");
            yield return _gameMethods.Transition(time:1f);
            yield return _gameMethods.OpenDialog(334); // "他只不温不火地点了下头，就自顾自地向前走。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 8f}, {"zpos", -180.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.44f}, {"xpos", 92f}, {"zpos", -282.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui9", "-emoji2"});
            yield return _gameMethods.OpenDialog(335); // "我连忙跟上。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/door_open1.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 92f}, {"zpos", -282.0f}})});
            yield return _gameMethods.SceneBlack(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 2f}, {"xpos", -10f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui14"});
            yield return _gameMethods.OpenDialog(336); // "这座城堡大概是有什么魔法装置，大门自动打开。"
            yield return _gameMethods.PlaySound("soundb", 0.0f, 1.0f, "audio/demo_audio/sound/zu3_nv_zou_man.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}})});
            yield return _gameMethods.OpenDialog(21); // "…………"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg7_memory.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg7_memory.jpg");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_dating_wan_kaideng.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.0f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.69f}})});
            
            yield return _gameMethods.OpenDialog(21); // "…………"
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:1f);
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(337); // "进入大厅后，我深吸一口气，{nw}{w=0.15}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui9"});
            yield return _gameMethods.OpenDialog(338); // "开口。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(339); // "…那个，有件事情，必须向你坦白。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1.2>audio/demo_audio/sound/zu3_nv_zou.ogg");
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "dissolve"}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"ypos", 1.96f}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.39f}, {"xpos", 0.5f}})});
            Engine._history = false;
            yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.OpenDialog(340); // "黑龙停下脚步，没有表情地看着我。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei2", "yan5", "zui19"});
            yield return _gameMethods.OpenDialog(341); // "其实我只是国王的私生女，从小作为平民流落在民间，并不算真正的公主。"
            Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei2", "yan11", "zui1"});
            yield return _gameMethods.OpenDialog(342); // "很抱歉，但我觉得不能瞒着你。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.OpenDialog(343); // "之所以刚刚没有在王宫里说出口，"
            yield return _gameMethods.ExecuteCharacterImageData("nv1");
            yield return _gameMethods.OpenDialog(344); // "/n是因为，"
            yield return _gameMethods.OpenDialog(345); // "如果黑龙真的带走了真正的公主，留下的我恐怕会被国王拿去泄愤。"
            yield return _gameMethods.OpenDialog(346); // "但和黑龙的第一面，我判断出他比国王更不容易迁怒别人。"
            yield return _gameMethods.PlaySound("soundb", 0.0f, 1.2f, "audio/demo_audio/sound/xintiao.ogg");
            yield return _gameMethods.OpenDialog(347); // "心脏跳动"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(348); // "如果在这里，能够被放走，{nw}{w=0.015}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(349); // "我会偷偷跑到边境地区，隐名埋姓地生活。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei4", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(350); // "「没关系，{nw}{w=0.001}"
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:1f);
            yield return _gameMethods.Show("he", parts: new List<string>{"mei4", "yan25", "zui11"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(351); // "你有罗兰王室标志性的奥术之星蓝眼，{nw}{w=0.001}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(352); // "这是血统的证明。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(353); // "……可恶。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(354); // "这样啊，那我就放心了。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.3f}, {"zpos", -84f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan17", "zui2", "-emoji2"});
            yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan17", "zui2", "-emoji2"});
            yield return _gameMethods.OpenDialog(355); // "那个，我可以在什么范围内活动呢？你规定一下，我坚决服从。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -84f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan17", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice1_8a65b4ec.ogg");
            yield return _gameMethods.OpenDialog(356); // "这座城堡。大门为界。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui2", "emoji10"});
            yield return _gameMethods.OpenDialog(357); // "哇，太慷慨了吧。谢谢！"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan17", "zui1", "emoji10"});
            yield return _gameMethods.OpenDialog(358); // "我还担心是不是只能被囚禁在房间里呢。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan17", "zui7", "-emoji10"});
            yield return _gameMethods.OpenDialog(359); // "「嗯。{nw}{w=0.001}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei4", "yan25", "zui11"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(360); // "这里的房间，你随便找一个住。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan17", "zui7"});
            yield return _gameMethods.OpenDialog(361); // "出问题再找我。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 3>audio/demo_audio/sound/zu3_nv_zou.ogg");
            yield return _gameMethods.Show("he", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.8f}, {"alpha", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan17", "zui7"});
            yield return _gameMethods.OpenDialog(362); // "说完这番话，他就离开了。"
            yield return _gameMethods.Show("he", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui6"});
            yield return _gameMethods.OpenDialog(4); // "……"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_dating_wan_kaideng.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "blink2"}})});
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.5f, "audio/demo_audio/sound/moca2.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(363); // "我把攥在身后的手伸开。"
            yield return _gameMethods.Hide("he");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan20", "zui15"});
            yield return _gameMethods.OpenDialog(364); // "手指内侧关节处皮开肉绽，血已经凝固了。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(365); // "剧烈的疼痛在手上燃烧，有些麻木。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan20", "zui15"});
            yield return _gameMethods.OpenDialog(366); // "我克制着活动了一下。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(367); // "……嗯，真幸运。/n没有伤及筋骨，想必不影响日后的手部功能。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan18", "zui14"});
            yield return _gameMethods.OpenDialog(368); // "希望今天我没有泄露出太多负面情绪。"
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:3f);
            yield return _gameMethods.PlaySound("soundb", 0.0f, 1.0f, "audio/sound/jiaobusheng_xin_man1.ogg");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_dating_wan_kaideng_louti.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "trans_rip_fast"}})});
            yield return _gameMethods.OpenDialog(21); // "…………"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg8_memory.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg8_memory.jpg");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/zoulang_zhuanjiao2.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "trans_rip_fast"}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"ypos", 1.21f}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.63f}, {"xpos", 0.5f}})});
            yield return _gameMethods.OpenDialog(21); // "…………"
            yield return _gameMethods.PlaySound("soundb", 0.0f, 1.0f, "audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/zoulang_guodao1.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "trans_rip_fast"}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.07f)}, {"zoom", 0.67f}})});
            yield return _gameMethods.OpenDialog(33); // "………………"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}, {"zpos", -84f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.5f}, {"ypos", -60f}, {"zpos", -200f}})});
            yield return _gameMethods.OpenDialog(369); // "在这个简直宛若宫殿一般的城堡中逡巡。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -60f}, {"zpos", -200f}})});
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:1f);
            yield return _gameMethods.SceneBlack(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "dissolve"}})});
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.5f, "audio/demo_audio/sound/zu2.ogg");
            yield return _gameMethods.OpenDialog(370); // "花了很短的时间，"
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.8f, "audio/demo_audio/sound/door_close1.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(371); // "/n我就给自己找了个空卧室入住。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg9_memory.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg9_memory.jpg");
            yield return _gameMethods.Scene("woshi_nv_yeyan_layered", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "dissolve"}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.25f, 0.39f)}, {"zoom", 0.36f}})});
            yield return _gameMethods.OpenDialog(21); // "…………"
            yield return _gameMethods.OpenDialog(372); // "伤口仍时刻发出疼痛的提醒。"
            yield return _gameMethods.SetDialogUIShowOrHide("hide");
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1>audio/sound/jiaobusheng_xin_normal1.ogg", "audio/demo_audio/sound/moca2.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(0f, -60f)}, {"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 2f}, {"pos", new Vector2(-108f, 276f)}, {"zoom", 1.8f}})});
            yield return _gameMethods.StopEngineTime(time:2.1f);
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-108f, 276f)}, {"zoom", 1.8f}})});
            yield return _gameMethods.SetDialogUIShowOrHide("show");
            yield return _gameMethods.OpenDialog(373); // "好在，我擅长忍耐，也擅长处理糟糕的后续。"
            yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/demo_audio/music/youshang2.mp3");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/caoyao.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"alpha", 0f}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.29f, 0.68f)}, {"zoom", 0.45f}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.0f, saturationMatrix:0.89f, brightnessMatrix:-0.13f, hueMatrix:0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan18", "zui14"});
            yield return _gameMethods.OpenDialog(374); // "刚刚在森林里等待藤筐编织时，我借黑龙的余威让巨猿们帮忙采集了一些止血的草药。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/caoyao.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(375); // "这些草药和我认识的那几种不同，总之只能试试看了。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(376); // "我花费大量时间， 一点点清理掉了草药根部粘连的土壤。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(377); // "又挨个检查叶子背面，确认干净没有虫卵。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/caoyao.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(378); // "最后把它们塞进嘴里，忍着舌尖传来的苦涩与麻痹，连根带茎地耐心嚼碎。吐到了手上。"
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/daoju/caoyao.png");
            yield return _gameMethods.Show("woshi_nv_yeyan_layered", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"fade", new RenpyFade(0.01f, 0.3f, 0.01f, "#ff0000")}})});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/zhenjing_shuaidaoganjue.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei6", "yan20", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(379); // "——…！"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei6", "yan12", "zui18", "emoji2"});
            yield return _gameMethods.OpenDialog(380); // "药渣与创面接触，一股刺激性的凉意和令人煎熬的疼痛瞬间袭来。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.7f, "audio/demo_audio/sound/sibuliao.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei6", "yan21", "zui9", "emoji2"});
            yield return _gameMethods.OpenDialog(381); // "我咬着牙，费劲地用手肘辅助扯了一些布料，裹住伤口，兜住敷料。"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 0.7f, "audio/demo_audio/sound/sibuliao2.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei6", "yan20", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(456); // "好在，之前我就经常给别人处理伤口，早已轻车熟路。"
            yield return _gameMethods.SceneBlack(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "dissolve"}})});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice1_b24d1f09.ogg");
            yield return _gameMethods.OpenDialog(21); // "…………"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei6", "yan12", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(383); // "……做完这些。已经得有一个小时过去了。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/woshi_nv1_chuang.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "dissolve"}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.28f, 0.79f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.46f}})});
            yield return _gameMethods.PlaySound("sound", 0.0f, 2f, "audio/sound/emeng_dajie/Lying Bed_01.mp3");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice1_369060c8.ogg");
            yield return _gameMethods.OpenDialog(21); // "…………"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei2", "yan12", "zui9", "emoji2"});
            yield return _gameMethods.OpenDialog(384); // "我脱力地倒在床上。"
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/woshi_nv1_tian.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "blink2"}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.24f, 0.78f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.51f}})});
            yield return _gameMethods.OpenDialog(385); // "开始放松身体，忍耐痛楚。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei6", "yan12", "zui18", "emoji2"});
            yield return _gameMethods.OpenDialog(386); // "快睡吧，睡过去就不痛了。"
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:4f);
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan20", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(387); // "可是，不知道是不是今天发生了太多事。/n神经还处于高度紧张的状态，难以松懈。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(388); // "脑中异常清醒。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(389); // "…不能产生痛苦和埋怨，得快点高兴起来。"
            yield return _gameMethods.SceneBlack(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "blink2"}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"zoom", 3f}})});
            yield return _gameMethods.OpenDialog(21); // "…………"
            yield return _gameMethods.OpenDialog(390); // "我开始回忆往事。"
            Defaults.Gui_duihuakuang_you = 0;
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}})});
            yield return _gameMethods.OpenDialog(391); // "从记事起，我在某个乡村生活。"
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_cg/memory_1/huiyi_nvzhutongnian_1.jpg");
            yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "Assets/RenpyResources/audio/demo_audio/music/huiyi1.mp3");
            yield return _gameMethods.Show("snow_white");
            yield return _gameMethods.Show("jiaopian", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.5f}})});
            yield return _gameMethods.Show("jiaopian", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"as", "jiaopiantiao2"}, {"onLayer", "forward"}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 638f}, {"alpha", 0.5f}})});
            yield return _gameMethods.Transition(time:1f);
            yield return _gameMethods.OpenDialog(392); // "六岁那年，母亲带我来到了王城。"
            yield return _gameMethods.OpenDialog(393); // "人流如织的城市，让我们感到些许不安。"
            yield return _gameMethods.OpenDialog(394); // "但很快，"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_cg/memory_1/huiyi_nvzhutongnian_2.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.9f}, {"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(395); // "母亲成功在小贵族家里找到了一份女佣的工作，来养活我。"
            yield return _gameMethods.OpenDialog(396); // "我们租下了一个比窝棚大不了多少的破旧木屋，作为小小的家。"
            yield return _gameMethods.Show("huiyi_nvzhutongnian_2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}, {"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein_cubic", 3.15f}, {"xpos", -132f}, {"zpos", 192.0f}})});
            yield return _gameMethods.OpenDialog(397); // "日子虽然缺钱，但过得很开心。"
            yield return _gameMethods.Scene("huiyi_nvzhutongnian_3", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(0.56f, 0.88f)}, {"zpos", 270.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein_cubic", 3.52f}, {"pos", new Vector2(0.5f, 1.0f)}, {"zpos", 0.0f}})});
            yield return _gameMethods.OpenDialog(398); // "我和附近街道上的两名同龄孩子成为了朋友。"
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_cg/memory_1/huiyi_nvzhutongnian_5.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "dissolve"}})});
            yield return _gameMethods.OpenDialog(399); // "一个是兼开面包作坊的磨坊主的独子，洛恩，这条街上最富裕体面的人家。"
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_cg/memory_1/huiyi_nvzhutongnian_4.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "dissolve"}})});
            yield return _gameMethods.OpenDialog(400); // "另一个则是肉铺家的长子安德鲁，家境殷实。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_cg/memory_1/huiyi_nvzhutongnian_6.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.70f}, {"alpha", 1.0f}})});
            yield return _gameMethods.OpenDialog(401); // "毫无疑问，我之所以选择和他们打好关系，最初是抱着某种不纯粹的目的。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_cg/memory_1/huiyi_nvzhutongnian_6.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
            yield return _gameMethods.OpenDialog(402); // "不过久而久之，我们的确建立了深厚的友谊。"
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.OpenDialog(403); // "然而，在我十二岁生日过后的冬天。"
            yield return _gameMethods.EngineSetVolume(volume:0.8f, delay:0.5f, channelName:"music");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_cg/memory_1/huiyi_nvzhutongnian_7.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.30f}, {"alpha", 1.0f}})});
            yield return _gameMethods.OpenDialog(404); // "母亲病倒了。"
            yield return _gameMethods.OpenDialog(405); // "她的咳嗽声日渐沉重，声音却日趋虚弱。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_cg/memory_1/huiyi_nvzhutongnian_8.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.8f}, {"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(406); // "我们约定好，春天来临后一起去野餐。"
            yield return _gameMethods.OpenDialog(407); // "可某一天，她再也没睁开眼。"
            yield return _gameMethods.SetDialogUIShowOrHide("hide");
            yield return _gameMethods.Hide("jiaopian", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}})});
            yield return _gameMethods.Hide("jiaopiantiao2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}})});
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.Show("lightning_1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.1f}})});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.2f, "audio/demo_audio/sound/leisheng1.mp3");
            yield return _gameMethods.PlaySound("soundb", 0.0f, 1.3f, "audio/demo_audio/sound/yu1.ogg");
            yield return _gameMethods.StopEngineTime(time:2.5f);
            yield return _gameMethods.EngineSetVolume(volume:1f, delay:0.5f, channelName:"music");
            yield return _gameMethods.Show("jiaopian", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.5f}})});
            yield return _gameMethods.Show("jiaopian", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"as", "jiaopiantiao2"}, {"onLayer", "forward"}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 638f}, {"alpha", 0.5f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_cg/memory_1/huiyi_nvzhutongnian_9.jpg");
            yield return _gameMethods.Show("rain_1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "middle"}})});
            yield return _gameMethods.StopEngineTime(time:1.5f);
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_cg/memory_1/huiyi_nvzhutongnian_10.jpg");
            yield return _gameMethods.StopEngineTime(time:1.5f);
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_cg/memory_1/huiyi_nvzhutongnian_11.jpg");
            yield return _gameMethods.StopEngineTime(time:1.5f);
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_cg/memory_1/huiyi_nvzhutongnian_12.jpg");
            yield return _gameMethods.StopEngineTime(time:1.5f);
            yield return _gameMethods.SetDialogUIShowOrHide("show");
            yield return _gameMethods.OpenDialog(21); // "…………"
            yield return _gameMethods.Hide("jiaopian", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}})});
            yield return _gameMethods.Hide("jiaopiantiao2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(33); // "………………"
            yield return _gameMethods.OpenDialog(408); // "依靠邻里的善意，我在洛恩家开的面包坊里得到了一份工作。"
            yield return _gameMethods.OpenDialog(409); // "也是差不多从那时，洛恩就开始参与面包店的生意管理，他将商业头脑发挥得淋漓尽致。"
            yield return _gameMethods.OpenDialog(33); // "………………"
            yield return _gameMethods.ExecuteShowScreenFunction("stop_screen", functionParams: new List<object>{2.6f});
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:3f);
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:2f);
            yield return _gameMethods.Hide("rain_1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "middle"}}), new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "dissolve"}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.SceneWhite();
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/bread/bread_changtiao.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"pauseTime", 0.5f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.9f}, {"alpha", 1f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/bread/bread_hei.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.8f}, {"xalign", 0.5f}, {"yalign", 0.5f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.9f}, {"alpha", 1f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/bread/bread_fangchui.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.8f}, {"xalign", 0.5f}, {"yalign", 0.5f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"pauseTime", 0.5f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.9f}, {"alpha", 1f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/bread/bread_niujiao.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.8f}, {"xalign", 0.5f}, {"yalign", 0.5f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"pauseTime", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/bread/bread_yuan.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.8f}, {"xalign", 0.5f}, {"yalign", 0.5f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"pauseTime", 1.5f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.1f}, {"alpha", 1f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/bread/bread_jianguo.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}, {"zoom", 0.8f}, {"xalign", 0.5f}, {"yalign", 0.5f}}), new SameLineParamData(new Dictionary<string, object>{{"pauseTime", 1.5f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.1f}, {"alpha", 1f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.PlaySound("music1", 2f, 1.0f, "audio/demo_audio/music/richang1.mp3");
            yield return _gameMethods.OpenDialog(410); // "比如，店里会根据小麦面粉的精炼程度，/n做出近十种不同档次的面包，"
            yield return _gameMethods.Hide("stop_screen");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/bread/bread_jianguo.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}, {"zoom", 0.8f}, {"xalign", 0.5f}, {"yalign", 0.5f}})});
            yield return _gameMethods.OpenDialog(411); // "颜色从白色、米黄、浅褐，再到深褐、黑色。/n精准对应每个阶层的细分，堪称切片大师。"
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/daoju/bread/bread_changtiao.png");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/daoju/bread/bread_hei.png");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/daoju/bread/bread_fangchui.png");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/daoju/bread/bread_niujiao.png");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/daoju/bread/bread_jianguo.png");
            yield return _gameMethods.Transition();
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/bread/bread_yuan.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.5f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 1f}, {"ypos", 0.37f}})});
            yield return _gameMethods.OpenDialog(412); // "最贵的那种小圆面包属于最好的白面包，用连麦芽坯都去掉了的精筛精磨小麦粉做成，发酵得软绵绵的，只有富庶人家舍得购买。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/bread/bread_yuan.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.37f}})});
            yield return _gameMethods.OpenDialog(413); // "我向他提议，在市坊中放出了“路易安娜面包”的名头。/n（这是已逝的作风奢侈的前前任王后的名字，那时候我还没想到自己日后有一天要为这个王室挡枪。）"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/bread/bread_xing.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(414); // "使这种面包成为了富裕平民的第一款轻奢点心。"
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/daoju/bread/bread_xing.png");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/daoju/bread/bread_yuan.png");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/bread/bread_hei.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.8f}, {"pos", new Vector2(54f, 96f)}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(415); // "最差的黑面包，主要用黑麦、燕麦等粗粝的谷物烤制，能从粗粮里检测到一点小麦成分。"
            yield return _gameMethods.OpenDialog(416); // "而且为了压分量，里面会掺入麦糠、谷壳和土豆皮，/n热时黏糊糊的，吃起来容易拉嗓子。"
            yield return _gameMethods.OpenDialog(417); // "不过洛恩家比较良心，从不混进木屑、沙砾和碎石子等免费食材。"
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/daoju/bread/bread_hei.png");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/bread/bread_tang.png");
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(418); // "更差一点的人家就连最便宜的面包也吃不起了，只能用少许燕麦做的稀水粥或豆子糊糊维持生存，整日饥肠辘辘，食不果腹。"
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/daoju/bread/bread_tang.png");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/bread/bread_tudou.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.7f}, {"xalign", 0.5f}, {"yalign", 0.4f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(457); // "一些最凄惨的贫民会吃土豆。/n这种作物从南边不宜居住的地带传进来，被体面的贵族们鄙夷为廉价的食物。"
            yield return _gameMethods.OpenDialog(420); // "后者声称，任何文明的人类都只应该食用小麦面包，喝清水或葡萄酒。"
            yield return _gameMethods.OpenDialog(458); // "因为这是真正洁净的佳肴。"
            yield return _gameMethods.OpenDialog(459); // "要我说，倘若他们真的如此健康，就该去啃没发酵的粗糙的大麦饼子，那才是几乎未经处理的洁净食物。"
            yield return _gameMethods.OpenDialog(423); // "况且，如果这里作物的元素成分和我前世一样，那吃土豆可比吃面包要营养多了。"
            yield return _gameMethods.OpenDialog(424); // "总而言之，与更多不幸的人相比，我已经过得非常小康了。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/bread/bread_hei.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"alpha", 1f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/bread/bread_changtiao.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"alpha", 1f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/bread/bread_tudou.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"alpha", 0f}})});
            yield return _gameMethods.OpenDialog(425); // "因为在面包坊工作的最大的好处就是能免费拿走一些剩面包。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/bread/bread_hei.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/bread/bread_changtiao.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/daoju/bread/bread_tudou.png");
            yield return _gameMethods.OpenDialog(426); // "当然，奶白的小圆面包肯定不要奢想了（面包店主自己都舍不得吃），但能吃到掺了一半麸皮、褐色的中等面包就很好。"
            yield return _gameMethods.OpenDialog(21); // "…………"
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/woshi_nv1_tian.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "dissolve"}})});
            Defaults.Gui_duihuakuang_you = 1;
            yield return _gameMethods.OpenDialog(4); // "……"
            yield return _gameMethods.StopSound(channelName:"music1", fadeOut:4f);
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei9", "yan20", "zui15"});
            yield return _gameMethods.OpenDialog(427); // "我忽然感觉心里空落落的，宛如植株被活生生地从土地里连根拔起一般。"
            yield return _gameMethods.SceneBlack(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "dissolve"}})});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/moca2.mp3");
            yield return _gameMethods.OpenDialog(460); // "我转过身，抱住枕头，把它狠狠压在胸前，/n仿佛稍微填充了一点胸腔里的空洞。"
            yield return _gameMethods.OpenDialog(21); // "…………"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.OpenDialog(33); // "………………"
            yield return _gameMethods.PlaySound("soundb", 0.0f, 1.0f, "audio/demo_audio/sound/niaoming.ogg");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/woshi_nv2_tian.jpg");
            yield return _gameMethods.Transition(time:1f);
            Defaults.Haogandu_an = Defaults.Haogandu_an + 1;
            yield return _gameMethods.OpenDialog(429); // "第二天醒来，伤口的疼痛减缓了许多。"
            yield return _gameMethods.OpenDialog(430); // "我感觉饥肠辘辘。"
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:2f);
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(431); // "今天要探索一下城堡。"
            yield return _gameMethods.ChangeLabelTo("label_zhuxian1");
        }

        public IEnumerator label_mingzi1()
        {
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan12", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(432); // "我该谎称自己叫维罗妮卡或伊丽莎白的。"
        }

        public IEnumerator label_mingzi2()
        {
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui7", "-emoji2"});
            yield return _gameMethods.OpenDialog(433); // "竟然能和我相媲美了。"
        }
}