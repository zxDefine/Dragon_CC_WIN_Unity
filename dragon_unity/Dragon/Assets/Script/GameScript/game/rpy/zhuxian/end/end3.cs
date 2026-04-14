    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class end3 : ILabelProvider
    {
        private GameMethods _gameMethods;

        public end3(GameMethods gameMethods)
        {
            _gameMethods = gameMethods;
        }

            public IEnumerator label_end3()
        {
            yield return _gameMethods.EngineSetVolume(volume:0.5f, delay:0.8f, channelName:"music2");
            yield return _gameMethods.Scene("tiankong_baitian1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.21f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.68f}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", -150f}})});
            yield return _gameMethods.ShowBlack();
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition(time:0.3f);
            yield return _gameMethods.OpenDialog(4757); // "……"
            yield return _gameMethods.Show("feather_ani");
            yield return _gameMethods.PlaySound("sounda2", 0.0f, 1.0f, "<from 0 to 1.5>audio/demo_audio/sound/flapping_wings_01.mp3");
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/manbu/strong_wind2_01.mp3");
            yield return _gameMethods.OpenDialog(4758); // "…………{nw}{w=1}"
            yield return _gameMethods.EngineSetVolume(volume:1f, delay:0.5f, channelName:"music2");
            yield return _gameMethods.ShowBlack(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.3f}, {"alpha", 0f}})});
            yield return _gameMethods.Show("feather_ani", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pause", 3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 0f}})});
            yield return _gameMethods.Show("tiankong_baitian1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.21f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.68f}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", -150f}}), new SameLineParamData(new Dictionary<string, object>{{"easein_cubic", 2f}, {"yoffset", 0f}})});
            
            yield return _gameMethods.OpenDialog(4759); // "此后，我周游大陆，踏过了千山万水。"
            yield return _gameMethods.OpenDialog(4760); // "参与了无数精彩的故事，也结识过各色天南海北的朋友。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/tiankong_yewan1.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 0.92f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.68f}, {"zpos", 138.0f}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(4761); // "偶尔，在夜深人静时，我仍会想起某个同和我在一座城堡里朝夕相处过三年之久的家伙。"
            yield return _gameMethods.OpenDialog(4762); // "那个黑色的身影总如幽灵一般，带着低温和阴雨天似的灰色情绪，飘过我的脑海。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/tiankong_yewan1.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(4763); // "……三年，放到一生的尺度当中，显得如此短暂。"
            yield return _gameMethods.OpenDialog(4764); // "但也许是最后的情绪足够强烈，他在我脑中残留的印象始终鲜艳。"
            yield return _gameMethods.OpenDialog(4765); // "……我想，这也和他给我留下的谜题有关。"
            yield return _gameMethods.OpenDialog(4766); // "如果爱我，为什么要这样对我？"
            yield return _gameMethods.OpenDialog(4767); // "如果不爱我，为什么可以沉睡得那样心平气和？"
            yield return _gameMethods.StopSound(channelName:"music2", fadeOut:5f);
            yield return _gameMethods.StopSound(channelName:"music1", fadeOut:5f);
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.TransitionBy("blink4_1");
            yield return _gameMethods.OpenDialog(4768); // "……我闭上眼。"
            yield return _gameMethods.PlaySound("soundb", 2f, 0.3f, "audio/demo_audio/sound/chanming.ogg");
            yield return _gameMethods.OpenDialog(4769); // "一片黑暗中，旧时熟悉的场景逐渐浮现。"
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_shufang_bangwan_shafa1.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(-0.01f, 1.94f)}, {"zoom", 1.46f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan13", "zui2", "d1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 3.06f)}, {"zoom", 0.63f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/shuben.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 170f}, {"ypos", 550f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -20f}, {"blur", 4f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 2f}, {"zpos", 0f}})});
            yield return _gameMethods.Transition(time:1f);
            yield return _gameMethods.OpenDialog(4770); // "他捧着书，坐在我的对面，一如记忆中那般，从容而沉静。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui9"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"blur", 0f}})});
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/demo_audio/sound/book2_he.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv_qian", parts: new List<string>{"mei7", "yan5", "zui15", "d3"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end3_6331c461.ogg");
            yield return _gameMethods.OpenDialog(4771); // "「……那么，{nw}{w=0.01}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end3_69f6e0f6.ogg");
            yield return _gameMethods.OpenDialog(4772); // "你的看法如何呢。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(4773); // "他合上书，抬眸看我。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}, {"zpos", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan17", "zui15"});
            yield return _gameMethods.OpenDialog(4757); // "……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(4774); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv");
            yield return _gameMethods.OpenDialog(4775); // "在故事的最后，我还会这样做吗？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(4757); // "……"
            yield return _gameMethods.OpenSelectMenu(screen:"choice3", talk: new List<string>{"-不会"}, jump: new List<string>{"label_end3_menu_0_ZVbbTUu9"}, condition: new List<string>{"NONE"});
        }

        public IEnumerator label_end3_chuan1()
        {
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end3_chuan1_3d9a7bef.ogg");
            yield return _gameMethods.OpenDialog(4776); // "在故事的最后，我爱着你么？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan21", "zui15"});
            yield return _gameMethods.OpenDialog(4757); // "……"
            yield return _gameMethods.OpenSelectMenu(screen:"choice4", talk: new List<string>{"-爱"}, jump: new List<string>{"label_end3_menu_0_tHYM9dti"}, condition: new List<string>{"NONE"});
        }

        public IEnumerator label_end3_chuan2()
        {
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end3_chuan2_7652c84b.ogg");
            yield return _gameMethods.OpenDialog(4777); // "我是否爱你，更胜过我的生命？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(4757); // "……"
            yield return _gameMethods.OpenSelectMenu(screen:"choice5", talk: new List<string>{"-胜过"}, jump: new List<string>{"label_end3_menu_0_QCwG9o4I"}, condition: new List<string>{"NONE"});
        }

        public IEnumerator label_end3_chuan3()
        {
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end3_chuan3_42473939.ogg");
            yield return _gameMethods.OpenDialog(4778); // "看来，你心中已经有了答案。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(4757); // "……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui12"});
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end3_chuan3_d789acd5.ogg");
            yield return _gameMethods.OpenDialog(4779); // "来对一下谜底吧。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end3_chuan3_d846953c.ogg");
            yield return _gameMethods.OpenDialog(4780); // "我的回答是——不。爱。是。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv");
            yield return _gameMethods.OpenDialog(4781); // "这和你心中所想一样么？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(4757); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan8", "zui10"});
            yield return _gameMethods.OpenDialog(4782); // "「可你只是我的幻觉，{nw}{w=0.3}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan12", "zui10"});
            yield return _gameMethods.OpenDialog(4783); // "我脑中的残影。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv", parts: new List<string>{"mei8", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(4784); // "是么。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end3_chuan3_9f9f5ad5.ogg");
            yield return _gameMethods.OpenDialog(4785); // "你这么认为？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan20", "zui15"});
            yield return _gameMethods.OpenDialog(4786); // "他的神色没有一丝惊恼，{nw}{w=0.01}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(4787); // "见我沉默，便只是不置可否，另起了话头。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end3_chuan3_edf34c3c.ogg");
            yield return _gameMethods.OpenDialog(4788); // "我很高兴，这么多年，你并未忘掉我。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi_nv", parts: new List<string>{"mei8", "yan5", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end3_chuan3_60a259c2.ogg");
            yield return _gameMethods.OpenDialog(4789); // "但是，你该睡了。"
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/daoju/shuben.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:3f);
            yield return _gameMethods.Transition(time:0.5f);
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi");
            yield return _gameMethods.OpenDialog(4790); // "——————睡吧，我会始终在这里等你。"
            yield return _gameMethods.ExecuteCharacterImageData("he_weizhi");
            yield return _gameMethods.OpenDialog(4791); // "明天，下一次，也许我们会有更好的选择。"
            Engine._history = false;
            yield return _gameMethods.OpenDialog(4792); // "{nw}{w=0.5}"
            Defaults.Persistent.Gallery_js_lock = 1;
            Defaults.Persistent.Jq_11_5 = 1;
            Defaults.Persistent.He_ending = 1;
            yield return _gameMethods.StopSound(channelName:"music1", fadeOut:5f);
            yield return _gameMethods.Show("tishi_chuan", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 0.5f)}, {"pos", new Vector2(0.5f, 0.5f)}, {"zpos", 0.0f}})});
            
                _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_0");
                _gameMethods.SyncAchievement();
            yield return _gameMethods.Transition(time:1f);
            yield return _gameMethods.OpenDialog(4793); // "{nw}{w=60}"
            Engine._history = true;
            if (Defaults.Persistent.Jq_11_1==1 && Defaults.Persistent.Jq_11_2==1 && Defaults.Persistent.Jq_11_3==1 && Defaults.Persistent.Jq_11_4==1 && Defaults.Persistent.Jq_11_5==1 && Defaults.Persistent.Jq_11_6==1 && Defaults.Persistent.Jq_11_7==1)
            {
                                
                        _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_7");
                        _gameMethods.SyncAchievement();

            }
        }
}