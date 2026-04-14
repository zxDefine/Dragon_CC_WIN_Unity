    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class zhuxian4 : ILabelProvider
    {
        private GameMethods _gameMethods;

        public zhuxian4(GameMethods gameMethods)
        {
            _gameMethods = gameMethods;
        }

            public IEnumerator label_choice22()
        {
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(3387); // "…………"
            Defaults.Persistent.Jq_5_1 = 1;
            yield return _gameMethods.OpenDialog(3388); // "转眼间，又到了赫泽尔该返回龙之谷的日子。"
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:8f);
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_dating_men_baitian.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.3f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 1.16f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan14", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 2.04f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.41f}})});
            yield return _gameMethods.Transition();
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui15"});
            yield return _gameMethods.OpenDialog(3389); // "{nw}{w=0.2}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui15"});
            yield return _gameMethods.OpenDialog(3390); // "临走之前，赫泽尔对我叮嘱。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1>audio/demo_audio/sound/zu3_nv_zou.ogg");
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(0.5f, 2.04f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.9f}, {"pos", new Vector2(0.5f, 2.04f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 54.0f}})});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(3391); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice22_d89fc9a6.ogg");
            yield return _gameMethods.OpenDialog(3392); // "如果博尔吉亚再来，不用给他开门。"
            yield return _gameMethods.PlaySound("music1", 0.0f, 0.7f, "audio/music/chumen1.mp3");
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan5", "zui10"});
            yield return _gameMethods.OpenDialog(3393); // "好的，我记住了。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan8", "zui19"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(0.5f, 2.04f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 54.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(3394); // "我乖巧应答。"
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(3395); // "赫泽尔又嘱咐了一次他回来的时间，最后离开了。"
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_dating_men_baitian.jpg");
            yield return _gameMethods.Transition();
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(3396); // "……"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.21f}, {"zpos", -66f}})});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.5>audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui8"});
            yield return _gameMethods.OpenDialog(3397); // "难得可以自由支配的时间，"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui8"});
            yield return _gameMethods.OpenDialog(3398); // "我决定出门，去城堡周围转转。"
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/senlin5.jpg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            yield return _gameMethods.OpenDialog(3396); // "……"
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/senlin7.jpg");
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            yield return _gameMethods.OpenDialog(3396); // "……"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 1.5f}, {"zpos", -186.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(3399); // "我在树林中绕了一圈，最终决定走过树林的边缘，前往位于城堡东边的草地。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan3", "zui7"});
            yield return _gameMethods.OpenDialog(3400); // "那里视野开阔，最适合吹着清风，放空思绪。"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<from 0 to 2>audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg51_memory.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg51_memory.jpg");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/caodi1.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.87f, 1.02f)}, {"zoom", 0.86f}, {"anchor", new Vector2(0.5f, 1.0f)}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(3401); // "出了森林，来到空旷的草场。"
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui7"});
            yield return _gameMethods.OpenDialog(3391); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(3387); // "…………"
            yield return _gameMethods.StopSound(channelName:"music1", fadeOut:3f);
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"blur", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.2f}, {"xoffset", 45f}, {"blur", 30f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"xoffset", 18f}, {"blur", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"xoffset", 45f}, {"blur", 30f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.2f}, {"xoffset", 0f}, {"blur", 0.0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.2f}, {"yoffset", 33f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"yoffset", 18f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"yoffset", 0f}})});
            yield return _gameMethods.PlaySound("soundb", 1f, 2f, "audio/sound/manbu/Gentle Breeze Blowing Foliage Rustling_01.ogg");
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan2", "zui14"});
            yield return _gameMethods.OpenDialog(3402); // "…………咦？"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}, {"blur", 0.0f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/yongzhe2/yongzhe2_0.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0f, 0f)}, {"pos", new Vector2(0f, 0f)}, {"zoom", 0.52f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan2", "zui14"});
            yield return _gameMethods.OpenDialog(3403); // "在草地上，我看见了一个绝对不会在此时此地见到的画面。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/yongzhe2/yongzhe2_0.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(3404); // "（……错觉？）"
            yield return _gameMethods.OpenDialog(3405); // "这里是深山。"
            yield return _gameMethods.OpenDialog(3406); // "按常理讲，是无人区。"
            yield return _gameMethods.OpenDialog(3407); // "事实上，这一年来，我在城堡周围也没有见过任何一名人类。"
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:2f);
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/manbu/strong_wind2_01.mp3");
            yield return _gameMethods.Show("yongzhe2_1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0f, 0f)}, {"pos", new Vector2(0f, 0f)}, {"zoom", 0.52f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"blur", 0f}})});
            Defaults.Gui_duihuakuang_you = 0;
            yield return _gameMethods.Show("_zoom");
            yield return _gameMethods.Hide("_zoom");
            
            yield return _gameMethods.PlaySound("music", 0.0f, 0.9f, "audio/music/PerituneMaterial_Dawning_Tale.mp3");
            yield return _gameMethods.OpenDialog(3408); // "但……此刻、在我眼前的不远处，出现了一道人影。"
            yield return _gameMethods.Show("yongzhe2_1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.OpenDialog(3409); // "一个身形干练的冒险者装束的少年，正抬头望着不远处城堡的轮廓。"
            yield return _gameMethods.OpenDialog(3410); // "神情怅然而迷惘。"
            yield return _gameMethods.OpenDialog(3411); // "更重要的是，那张脸如此熟悉，曾经无数次出现在我的回忆和梦中。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(3412); // "……！"
            yield return _gameMethods.OpenDialog(3413); // "好像看到了一个不可能出现在这里的人。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(3414); // "安德鲁？"
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/yongzhe2/yongzhe2_2.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0f, 0f)}, {"pos", new Vector2(0f, 0f)}, {"zoom", 0.52f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(3415); // "他闻声转回头来。"
            yield return _gameMethods.OpenDialog(3416); // "目光触及我的瞬间，眼睫剧烈地颤动了一下。"
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/caodi1.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.97f, 1.9f)}, {"zoom", 1.5f}})});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/emeng_dajie/dashing_01.mp3");
            Defaults.Gui_duihuakuang_you = 1;
            yield return _gameMethods.TransitionBy("blink2");
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan8", "zui8", "emoji20"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.49f, 3.28f)}, {"zoom", 0.55f}, {"alpha", 0f}, {"blur", 0.01f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.5f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.3f}, {"alpha", 1f}, {"blur", 0f}})});
            if (Defaults.Persistent.Povname=="辛西娅")
            {
                                yield return _gameMethods.ExecuteCharacterImageData("an");
                yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice22_b4bc72fa.ogg");
                yield return _gameMethods.OpenDialog(3417); // "辛西娅。"

            }
            else
            {
                                yield return _gameMethods.ExecuteCharacterImageData("an");
                yield return _gameMethods.OpenDialog(3418); // "[persistent.povname]。"

            }
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan2", "zui5", "emoji20"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}, {"blur", 0f}})});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("an_qian");
            yield return _gameMethods.OpenDialog(3391); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan8", "zui8", "emoji20"});
            Defaults.Haogandu_an = Defaults.Haogandu_an + 2;
            yield return _gameMethods.ExecuteCharacterImageData("an");
            yield return _gameMethods.OpenDialog(3419); // "……你还活着？"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan8", "zui3", "emoji20"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui14"});
            yield return _gameMethods.OpenDialog(3420); // "「……"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui14"});
            yield return _gameMethods.OpenDialog(3421); // "{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei6", "yan12", "zui14"});
            yield return _gameMethods.OpenDialog(3391); // "{nw}{w=0.15}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei9", "yan17", "zui19"});
            yield return _gameMethods.OpenDialog(3391); // "{nw}{w=0.15}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
            yield return _gameMethods.OpenDialog(3422); // "刚见面第一句能不能说点好听的。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan8", "zui10", "emoji20", "emoji11"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei9", "yan17", "zui7"});
            yield return _gameMethods.OpenDialog(3423); // "居然真的见面了。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan2", "zui10", "emoji20", "-emoji11", "emoji12"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3391); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan8", "zui10", "emoji20", "emoji11", "-emoji12"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei9", "yan17", "zui8"});
            yield return _gameMethods.OpenDialog(3424); // "自从六岁那年我来到王都，和他认识了十年，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei2", "yan20", "zui6"});
            yield return _gameMethods.OpenDialog(3425); // "这是我们第一次分离那么久。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei9", "yan12", "zui6"});
            yield return _gameMethods.OpenDialog(3426); // "两年不见了。{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei9", "yan5", "zui6"});
            yield return _gameMethods.OpenDialog(3427); // "/n久别重逢，我试图活跃气氛。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan19", "zui10", "emoji12", "emoji11", "emoji20"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3428); // "本以为他会如往常无数次所做的那样抽动嘴角，然后吐槽回来。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan2", "zui3", "emoji12", "-emoji11", "-emoji20"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(3429); // "但他却只是垂下眼眸。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei3", "yan23", "zui13", "emoji11", "emoji12"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice22_0037af84.ogg");
            yield return _gameMethods.OpenDialog(3430); // "我……只是，没想到。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei3", "yan16", "zui4", "emoji11", "emoji12"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice22_0f5b07ec.ogg");
            yield return _gameMethods.OpenDialog(3431); // "我只是想来远远地看一眼……"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei3", "yan16", "zui2", "emoji11", "emoji12"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(3391); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(3432); // "那种软弱的语气还未延续太久，"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan4", "zui2", "emoji11", "emoji12"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3433); // "很快，他回过神来，"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan2", "zui1", "emoji11", "emoji12"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3391); // "{nw}{w=0.15}"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan15", "zui1", "emoji11", "emoji12"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3434); // "原本的那股惘然、脆弱与迷茫，便犹如清晨后日下蒸发的露珠一般消失了。"
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:5f);
            yield return _gameMethods.PlaySound("music1", 1f, 1.0f, "audio/music/yongzhe_wenxin1.mp3");
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan2", "zui16", "-emoji11", "-emoji12"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(3391); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan12", "zui16"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(3435); // "…………他恢复了平时那副漫不经心又笑嘻嘻的神色，露出了一如既往欠扁的笑容。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.5f, "<from 0 to 0.5>audio/sound/emeng_dajie/walking_on_the_earth_01.mp3");
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan3", "zui15"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"zpos", 18.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
            yield return _gameMethods.OpenDialog(3436); // "我就是过来看看，万一没见到你就帮忙哀悼一下，{nw}{w=0.1}"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan12", "zui12"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
            yield return _gameMethods.OpenDialog(3437); // "没想到，果然是祸害遗千年啊。」"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan12", "zui10"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 18.0f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.3f}, {"blur", 4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"blur", 0.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei9", "yan5", "zui6"});
            yield return _gameMethods.OpenDialog(3438); // "鼻子有些酸涩。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei9", "yan12", "zui6"});
            yield return _gameMethods.OpenDialog(3391); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan17", "zui19"});
            yield return _gameMethods.OpenDialog(3439); // "那好人不长命，你可千万要当心。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan16", "zui12", "emoji8"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei7", "yan17", "zui7"});
            yield return _gameMethods.OpenDialog(3440); // "喂喂。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan2", "zui13", "-emoji8"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei7", "yan17", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice22_75588d32.ogg");
            yield return _gameMethods.OpenDialog(3441); // "看到你还是这么有精神，我就放心了。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan9", "zui10"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan11", "zui7"});
            yield return _gameMethods.OpenDialog(3442); // "我忍不住微笑。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui19"});
            yield return _gameMethods.OpenDialog(3443); // "你也是。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1");
            yield return _gameMethods.OpenDialog(3444); // "怎么跑到这里来了？"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan4", "zui5"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice22_50c3c1c8.ogg");
            yield return _gameMethods.OpenDialog(3445); // "「啊，{nw}{w=0.1}"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan2", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice22_d10f8baf.ogg");
            yield return _gameMethods.OpenDialog(3446); // "做任务的时候拿到了一个神秘卷轴，说是能把人送到心中最渴——……」"
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.7f, "audio/demo_audio/sound/moca2.mp3");
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei8", "yan19", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv");
            yield return _gameMethods.OpenDialog(3412); // "……！"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan12", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(3391); // "{nw}{w=0.15}"
            yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian", parts: new List<string>{"mei8", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(3447); // "「……」"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei5", "yan17", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3448); // "他胡乱地揉了揉一头乱发。"
            yield return _gameMethods.PlaySound("sounda", 0.4f, 0.5f, "audio/demo_audio/sound/moca2.mp3");
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei5", "yan2", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"xoffset", -3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice27_fc0294d5.ogg");
            yield return _gameMethods.OpenDialog(3449); // "呃啊啊，反正就是跟传送道具差不多。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei5", "yan23", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(3391); // "{nw}{w=0.15}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(3450); // "我注意到他的额角多了一道我没见过的疤痕。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3451); // "脖子上也缠着绷带。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(3452); // "这些变化，毫无疑问都是在我们分离的这两年里添上的。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei5", "yan2", "zui6"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice22_c0e1d7b8.ogg");
            yield return _gameMethods.OpenDialog(3453); // "「没想到碰巧传送到这里来了。{nw}{w=0.1}"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan12", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice22_d0d7bf31.ogg");
            yield return _gameMethods.OpenDialog(3454); // "你运气真不错。」"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.60f}, {"ypos", 132f}})});
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan12", "zui10"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan24", "zui7"});
            yield return _gameMethods.OpenDialog(3455); // "槽点太多了不想吐。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(3456); // "「做任务？"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 132f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 1f}, {"ypos", 624f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan9", "zui9"});
            yield return _gameMethods.OpenDialog(3457); // "你这身打扮……」"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei7", "yan9", "zui15"});
            yield return _gameMethods.OpenDialog(3458); // "嗯。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan9", "zui8"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.2f}, {"ypos", -6f}})});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice22_3e0454b3.ogg");
            yield return _gameMethods.OpenDialog(3459); // "「我报名了勇者。并且，胜出了。{nw}{w=0.1}"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan12", "zui5"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice22_e829f389.ogg");
            yield return _gameMethods.OpenDialog(3460); // "眼下正在冒险历练。」"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -6f}})});
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan16", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(3391); // "{nw}{w=0.15}"
            yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(3461); // "「所以，{nw}{w=0.1}"
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.5f, "<from 0 to 1>audio/sound/emeng_dajie/walking_on_the_earth_01.mp3");
            yield return _gameMethods.Show("an2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 18.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.8f}, {"zpos", 36.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice22_5a4c6ba1.ogg");
            yield return _gameMethods.OpenDialog(3462); // "现在本大爷就是你脱离苦海的唯一希望。{nw}{w=0.1}"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan2", "zui12"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice22_444ffc1d.ogg");
            yield return _gameMethods.OpenDialog(3463); // "赶快向我祈祷吧。」"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan2", "zui10"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 36.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui10"});
            yield return _gameMethods.OpenDialog(3464); // "…………为什么要当勇者呢。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan20", "zui9"});
            yield return _gameMethods.OpenDialog(3465); // "你不是一直想学绘画吗？"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan20", "zui15"});
            yield return _gameMethods.OpenDialog(3466); // "我知道，安德鲁身为屠户家的长子，从小就跟随父亲学习技艺。"
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(3391); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan20", "zui15"});
            yield return _gameMethods.OpenDialog(3467); // "他的父亲力气日渐衰弱，家里又还有两个年幼的弟妹，急需安德鲁顶起担子，撑起家业。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan19", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan20", "zui15"});
            yield return _gameMethods.OpenDialog(3468); // "所以，虽然他喜欢绘画，在我看来也很有天赋。{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(3469); // "/n但却并不可能在这项只有有钱有闲的贵族才能学习的领域上有所发展。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(3470); // "甚至，他也曾测出过足以获得骑士资质的觉醒血脉。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan2", "zui1"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3391); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan19", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3471); // "但考虑到安德鲁的资质不算出众，穷极一生大约也只能成为中级骑士。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3472); // "而在那之前，却要付出三四年的训练时间和大量的经济成本，才能成为初等骑士，开始获得受雇佣和赚钱的能力。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(3473); // "综合考量之下，他放弃了这条路。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan2", "zui1"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3391); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan19", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3474); // "闲聊时，我曾经问过他，怎么样才会考虑去学习绘画。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(3475); // "他很干脆地说，等到有钱。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei6", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(3476); // "所以，我便送给他钱。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3477); // "虽然我的心愿已无法实现，但我希望其他有心愿的人能够实现它们。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0.3 to 0.5>audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.3f}, {"zpos", -10.0f}})});
            Defaults.Haogandu_an = Defaults.Haogandu_an + 2;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei9", "yan20", "zui9"});
            yield return _gameMethods.OpenDialog(3478); // "明明已经有钱了，现在你不用再因为是长子就必须继承家业了。"
            yield return _gameMethods.PlaySound("sound", 0.1f, 0.4f, "<from 0.3 to 0.5>audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -10.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.3f}, {"zpos", -20.0f}})});
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan2", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei9", "yan5", "zui10"});
            yield return _gameMethods.OpenDialog(3479); // "那些颜料很贵，但你也全都买得起了。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0.5 to 1>audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -20.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.3f}, {"zpos", -30.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei2", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(3480); // "我不是叫国王送给你们钱了吗？"
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.6f, "<from 0 to 1>audio/sound/emeng_dajie/walking_on_the_earth_01.mp3");
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan23", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 36.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.7f}, {"zpos", 12.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian", parts: new List<string>{"mei2", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(3481); // "「……{nw}{w=0.1}"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan2", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice22_de60e678.ogg");
            yield return _gameMethods.OpenDialog(3482); // "谁要那个啊。{nw}{w=0.1}"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan8", "zui12"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice22_3af07859.ogg");
            yield return _gameMethods.OpenDialog(3483); // "你家安德大人我就算用树枝在地上扒拉也能画出惊天大作好吧。」"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan8", "zui10"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 12.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei3", "yan10", "zui19"});
            yield return _gameMethods.OpenDialog(3484); // "「凭什么看不起钱，那可是我卖命换来的金币啊，{nw}{w=0.1}"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan4", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei4", "yan12", "zui19"});
            yield return _gameMethods.OpenDialog(3485); // "给我向钱道歉好么。」"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan23", "zui12"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei4", "yan12", "zui8"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice22_5e2ba504.ogg");
            yield return _gameMethods.OpenDialog(3486); // "所以，我才不能用啊。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan23", "zui16"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(3396); // "……"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan2", "zui16"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
            yield return _gameMethods.OpenDialog(3391); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan23", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv");
            yield return _gameMethods.OpenDialog(3396); // "……"
            yield return _gameMethods.PlaySound("soundb", 0.2f, 3f, "audio/sound/manbu/Gentle Breeze Blowing Foliage Rustling_01.ogg");
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/yongzhe2/yongzhe_shuye.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}, {"zpos", 12.0f}, {"pos", new Vector2(-96f, -12f)}, {"zoom", 1.11f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.8f}, {"alpha", 1f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"offset", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.2f}, {"offset", new Vector2(-20f, 5f)}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.2f}, {"offset", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.2f}, {"offset", new Vector2(18f, -5f)}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.2f}, {"offset", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.3f}, {"offset", new Vector2(-12f, 5f)}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.2f}, {"offset", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.2f}, {"offset", new Vector2(10f, -5f)}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.2f}, {"offset", new Vector2(0f, 0f)}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(3487); // "风声唏嘘，草叶扑簌簌地摇晃着。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/yongzhe2/yongzhe_shuye.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3488); // "我们陷入了短暂的沉默之中。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.5f, "<from 0 to 0.5>audio/sound/emeng_dajie/walking_on_the_earth_01.mp3");
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui4"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 3.28f}, {"zoom", 0.55f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.15f}, {"ypos", 3.34f}, {"zoom", 0.56f}})});
            if (Defaults.Persistent.Povname=="辛西娅")
            {
                                yield return _gameMethods.ExecuteCharacterImageData("an_nv");
                yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice22_0472b689.ogg");
                yield return _gameMethods.OpenDialog(3417); // "辛西娅。"

            }
            else
            {
                                yield return _gameMethods.ExecuteCharacterImageData("an_nv");
                yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice22_10334f6c.ogg");
                yield return _gameMethods.OpenDialog(3418); // "[persistent.povname]。"

            }
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"offset", new Vector2(0f, 0f)}})});
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 3.34f}, {"zoom", 0.56f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(3489); // "安德鲁突然开口。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui6"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
            yield return _gameMethods.OpenDialog(3490); // "「……{nw}{w=0.4}"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan23", "zui4"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
            yield return _gameMethods.OpenDialog(3491); // "……」"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan2", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3492); // "他的嘴巴轻轻张合，最后只简短地吐出。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan12", "zui4"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice22_8e25776b.ogg");
            yield return _gameMethods.OpenDialog(3493); // "……等我。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan12", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan5", "zui10"});
            yield return _gameMethods.OpenDialog(3494); // "好。我等你。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei3", "yan12", "zui16"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan8", "zui10"});
            yield return _gameMethods.OpenDialog(3495); // "但是，吃力的话就逃吧。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei3", "yan4", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan2", "zui9"});
            yield return _gameMethods.OpenDialog(3496); // "你不必背负我的命运，就这样带着叔叔阿姨他们跑掉也可以。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan19", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan6", "zui10"});
            yield return _gameMethods.OpenDialog(3497); // "人类帝国经受三百年的灾厄也没什么大不了的。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan2", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan12", "zui12"});
            yield return _gameMethods.OpenDialog(3498); // "合久必分分久必合嘛。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan12", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan5", "zui10"});
            yield return _gameMethods.OpenDialog(3499); // "不要做一个好人也可以。带着我的份幸福地活下去。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui3"});
            yield return _gameMethods.OpenDialog(3500); // "「祸害遗千年。{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan5", "zui19"});
            yield return _gameMethods.OpenDialog(3501); // "活得久一点啊。」"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan2", "zui7"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian", parts: new List<string>{"mei7", "yan5", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice22_947aec65.ogg");
            yield return _gameMethods.OpenDialog(3502); // "「……真是的，又被你给装到了。{nw}{w=0.1}"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan12", "zui7"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice22_8d6c8843.ogg");
            yield return _gameMethods.OpenDialog(3503); // "偶尔也把耍帅的机会让给别人吧。」"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan19", "zui12"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice22_65b6a899.ogg");
            yield return _gameMethods.OpenDialog(3504); // "一个人被国王的骑兵接走，一个人让骑士送来了吓死人的金子。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan8", "zui12"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei7", "yan5", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice22_5ea2abc6.ogg");
            yield return _gameMethods.OpenDialog(3505); // "我和洛恩都很担心你。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan8", "zui16"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan8", "zui10"});
            yield return _gameMethods.OpenDialog(3506); // "洛恩还好吗？"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan2", "zui1"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
            yield return _gameMethods.OpenDialog(3391); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei8", "yan4", "zui5"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice22_cdd74263.ogg");
            yield return _gameMethods.OpenDialog(3507); // "「他说要记你无故旷工，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice22_a86443e9.ogg");
            yield return _gameMethods.OpenDialog(3508); // "等回来后把工时全部补回来。」"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei8", "yan4", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei6", "yan12", "zui19", "emoji2", "emoji6"});
            yield return _gameMethods.OpenDialog(3509); // "……好可怕啊，能不能多关心一下我，瞬间不想回去了。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan16", "zui12"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei6", "yan12", "zui8", "emoji2", "emoji6"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice22_1264df96.ogg");
            yield return _gameMethods.OpenDialog(3510); // "我会帮忙向你的老板如实转告。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan16", "zui10"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei4", "yan5", "zui10", "-emoji2", "-emoji6"});
            yield return _gameMethods.OpenDialog(3511); // "我刚刚什么都没说。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan12", "zui16"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei4", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(3387); // "…………"
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:5f);
            yield return _gameMethods.Hide("Assets/RenpyResources/images/cg/yongzhe2/yongzhe_shuye.png");
            yield return _gameMethods.Transition(time:0.5f);
            yield return _gameMethods.OpenDialog(3387); // "…………"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei3", "yan19", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("an");
            yield return _gameMethods.OpenDialog(3512); // "恶龙对你还好么。有没有虐待你？"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei3", "yan19", "zui16"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(3513); // "「没有，他可喜欢我了。{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei3", "yan12", "zui19", "emoji7"});
            yield return _gameMethods.OpenDialog(3514); // "我可是王城充满魅力的面包店知名美少女啊。」"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei8", "yan8", "zui4"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei3", "yan12", "zui8", "emoji7"});
            yield return _gameMethods.OpenDialog(3515); // "……还好没吃早饭，差点就吐了。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei8", "yan8", "zui1"});
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/moca1.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei4", "yan10", "zui2", "-emoji7"});
            yield return _gameMethods.OpenDialog(3516); // "滚！！！"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan2", "zui10"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian", parts: new List<string>{"mei4", "yan10", "zui8"});
            yield return _gameMethods.OpenDialog(3517); // "「噗——{nw}{w=0.1}"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan3", "zui12"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice22_ae490812.ogg");
            yield return _gameMethods.OpenDialog(3518); // "哈哈，{nw}{w=0.1}"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan12", "zui12"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice22_7065ccfc.ogg");
            yield return _gameMethods.OpenDialog(3519); // "就不~」"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan12", "zui10"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan24", "zui6", "emoji2"});
            yield return _gameMethods.OpenDialog(3520); // "……小学生吗。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10", "-emoji2"});
            yield return _gameMethods.OpenDialog(3521); // "你要怎么回去？"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui5"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice22_fc2d6337.ogg");
            yield return _gameMethods.OpenDialog(3522); // "这里的我只是投影。等卷轴能量耗尽就会回去了。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui1"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(3391); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(3523); // "投影？"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -6f}, {"zpos", -30.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.4f}, {"ypos", -36f}, {"zpos", -96.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3524); // "我伸出手。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -36f}, {"zpos", -96.0f}})});
            yield return _gameMethods.OpenSelectMenu(talk: new List<string>{"-戳他脸", "-戳他胸"}, jump: new List<string>{"label_zhuxian4_menu_0_0Th11hcK", "label_zhuxian4_menu_0_A0AvA9S7"}, condition: new List<string>{"NONE", "NONE"});
        }

        public IEnumerator label_choice23()
        {
            yield return _gameMethods.OpenSelectMenu(talk: new List<string>{"-还好没碰到，不然我脏了", "-对"}, jump: new List<string>{"label_zhuxian4_menu_0_yjTubabw", "label_zhuxian4_menu_0_4zVrOITy"}, condition: new List<string>{"NONE", "NONE"});
        }

        public IEnumerator label_choice25()
        {
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui5", "-emoji2", "-emoji6", "-emoji1"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice25_cdf90615.ogg");
            yield return _gameMethods.OpenDialog(3570); // "话说，你怎么能出城堡了？"
            yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei8", "yan2", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice25_de096990.ogg");
            yield return _gameMethods.OpenDialog(3571); // "预言里不是说要被囚禁在高塔上么。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei3", "yan5", "zui19"});
            yield return _gameMethods.OpenDialog(3572); // "「那是因为黑龙特别喜欢我，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei3", "yan12", "zui19"});
            yield return _gameMethods.OpenDialog(3573); // "所以允许我在城堡周围活动。」"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan12", "zui4", "emoji8"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei3", "yan12", "zui8"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice25_9880b7bf.ogg");
            yield return _gameMethods.OpenDialog(3574); // "它就这么没品位？"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan12", "zui1", "emoji8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei5", "yan10", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(3575); // "你会不会说人话？"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan3", "zui15", "-emoji8", "emoji20"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian", parts: new List<string>{"mei5", "yan10", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(3576); // "「…{nw}{w=0.5}"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui10", "emoji20"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
            yield return _gameMethods.OpenDialog(3534); // "…」"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan24", "zui8", "-emoji2"});
            yield return _gameMethods.OpenDialog(3396); // "……"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui10", "emoji20"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(3577); // "我忽然有一个发现。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(3578); // "安德鲁。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan2", "zui16", "-emoji20"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
            yield return _gameMethods.OpenDialog(3391); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan4", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(3579); // "嗯？"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/manbu/Silence+Other Sounds _01.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 12f}, {"zpos", 30.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.3f}, {"ypos", 114f}, {"zpos", -72.0f}})});
            yield return _gameMethods.Show("an2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.2f}, {"alpha", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(3580); // "我伸出手，五指插进那道虚影的心脏。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 114f}, {"zpos", -72.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan17", "zui19"});
            yield return _gameMethods.OpenDialog(3581); // "你看，黑虎掏心。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei5", "yan16", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.2f}, {"alpha", 1f}, {"blur", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei3", "yan17", "zui8"});
            yield return _gameMethods.OpenDialog(3396); // "……"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei5", "yan17", "zui6"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice25_543c5616.ogg");
            yield return _gameMethods.OpenDialog(3582); // "幼不幼稚。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei5", "yan17", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}, {"blur", 0f}})});
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.6f, "<from 0.2 to 0.5>audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -72.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.3f}, {"zpos", -6.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan6", "zui17"});
            yield return _gameMethods.OpenDialog(3583); // "真没童心。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -6.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(3584); // "我又有了一个发现。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 114f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.3f}, {"ypos", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(3585); // "「安德鲁，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei3", "yan5", "zui9"});
            yield return _gameMethods.OpenDialog(3586); // "我发现你掏我，也能黑虎掏心。」"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}})});
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan4", "zui1", "emoji8"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei3", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(3387); // "…………"
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/moca1.ogg");
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan17", "zui8", "emoji1", "emoji8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"xoffset", -3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv");
            yield return _gameMethods.OpenDialog(3587); // "你、你能不能有点常识？"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan2", "zui8", "emoji1", "-emoji8"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(3391); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice25_b0693fee.ogg");
            yield return _gameMethods.OpenDialog(3588); // "胸是能随便让别人碰的吗？！"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan17", "zui3", "emoji1", "emoji8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(3589); // "……我就说说而已，这么激动干什么。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan12", "zui19"});
            yield return _gameMethods.OpenDialog(3590); // "再说你也碰不到啊。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.6f, "<from 0 to 0.5>audio/sound/emeng_dajie/walking_on_the_earth_01.mp3");
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan8", "zui8", "emoji1", "-emoji8", "emoji18"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 12.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.13f}, {"zpos", 60.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice25_7bbee4d0.ogg");
            yield return _gameMethods.OpenDialog(3591); // "「这是碰不碰得到的问题吗？{nw}{w=0.1}"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan13", "zui6", "emoji1", "emoji8", "-emoji18", "-emoji10"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice25_15ff292f.ogg");
            yield return _gameMethods.OpenDialog(3592); // "而且我哪里激动了。」"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan13", "zui1", "emoji1", "-emoji8", "-emoji10"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 60.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan24", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(3593); // "不知该怎么讲，因为他无论怎么看都挺激动的。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui7", "-emoji2"});
            yield return _gameMethods.OpenDialog(3594); // "这家伙照顾弟弟妹妹习惯了，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(3595); // "大概是一起长大的缘故，他的过度保护也常常会蔓延到我的头上。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei3", "yan10", "zui19", "-emoji2"});
            yield return _gameMethods.OpenDialog(3596); // "你不要总是这么操心，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan6", "zui11"});
            yield return _gameMethods.OpenDialog(3597); // "我已经长大了，安德鲁哥哥。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/moca1.ogg");
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan8", "zui8", "emoji1", "emoji4", "emoji5", "emoji8", "-emoji10"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"xoffset", -3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei7", "yan6", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice25_b00bdfc5.ogg");
            yield return _gameMethods.OpenDialog(3598); // "我……！"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan8", "zui3", "emoji1", "emoji4", "emoji5", "emoji8", "-emoji10"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
            yield return _gameMethods.OpenDialog(3599); // "他愕然地瞪大眼睛，似乎是非常生气吧，脸整个都涨红了。"
            yield return _gameMethods.Scene("zui5", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.86f, 1.81f)}, {"zoom", 0.8f}})});
            Defaults.Gui_duihuakuang_you = 0;
            yield return _gameMethods.Show("_zoom");
            yield return _gameMethods.Hide("_zoom");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/emeng_dajie/Lying Bed_01.mp3");
            yield return _gameMethods.Transition(time:0.4f);
            yield return _gameMethods.OpenDialog(3600); // "卡壳半天，大概是没想到好的反驳说辞，他气势汹汹地坐在了草地上，抱臂面向另一侧。"
            yield return _gameMethods.OpenSelectMenu(talk: new List<string>{"-哄哄他", "-不理他", "-确实有问题", "-不觉得"}, jump: new List<string>{"label_zhuxian4_menu_0_GK2oHy5M", "label_zhuxian4_menu_0_VVbVxfcP", "label_zhuxian4_menu_0_L8UBVumN", "label_zhuxian4_menu_0_AMVsmkZH"}, condition: new List<string>{"NONE", "NONE", "NONE", "NONE"});
        }

        public IEnumerator label_choice26_1()
        {
            yield return _gameMethods.Show("yongzhe1_layered", parts: new List<string>{"mei2"});
            yield return _gameMethods.ExecuteCharacterImageData("an");
            yield return _gameMethods.OpenDialog(3540); // "？"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(3630); // "因为……"
            yield return _gameMethods.OpenSelectMenu(talk: new List<string>{"-你们不是别人", "-你的幸福就是我的幸福"}, jump: new List<string>{"label_zhuxian4_menu_0_mxaXEbi9", "label_zhuxian4_menu_0_QTmFjhCo"}, condition: new List<string>{"NONE", "NONE"});
        }

        public IEnumerator label_choice26()
        {
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(3631); // "你和洛恩不是别人，是我重要的人。"
            yield return _gameMethods.Show("yongzhe1_layered", parts: new List<string>{"yan6"});
            Defaults.Haogandu_an = Defaults.Haogandu_an + 2;
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(3632); // "所以，知道你们幸福，我也会幸福。"
            yield return _gameMethods.OpenDialog(3633); // "好像连同此刻我所不得不承受的事情，都有了更崇高的意义。"
            yield return _gameMethods.Show("yongzhe1_layered", parts: new List<string>{"emoji1"});
            yield return _gameMethods.ExecuteCharacterImageData("an");
            yield return _gameMethods.OpenDialog(3387); // "…………"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 0.7f, "audio/demo_audio/sound/moca2.mp3");
            yield return _gameMethods.Show("yongzhe1_layered", parts: new List<string>{"emoji2", "emoji3", "yan2"});
            yield return _gameMethods.OpenDialog(3634); // "他沉默一刻，忽然猛地把头低了下去，双手捂住了自己的上半张脸。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(3635); // "你还好吗，突然失心疯了？"
            yield return _gameMethods.OpenDialog(3636); // "我关切地凑近问。"
            yield return _gameMethods.ExecuteCharacterImageData("an");
            yield return _gameMethods.OpenDialog(3396); // "……"
            yield return _gameMethods.OpenDialog(3637); // "他一言不发，一动不动地捂着脸好久。"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 0.5f, "audio/demo_audio/sound/moca2.mp3");
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.5f, "<silence 0.5>", "audio/sound/emeng_dajie/finger_snap_01.mp3");
            yield return _gameMethods.ShowWhite();
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(3638); // "忽然毫无征兆地伸出右手，轻轻地弹了我一个脑瓜崩，用如临大敌一般的语气，沉重地说。"
            yield return _gameMethods.HideWhite();
            yield return _gameMethods.Show("yongzhe1_layered", parts: new List<string>{"yan3", "mei4", "zui2"});
            yield return _gameMethods.Transition();
            yield return _gameMethods.ExecuteCharacterImageData("an");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice26_bcb943a0.ogg");
            yield return _gameMethods.OpenDialog(3639); // "……你、真是个难搞的家伙啊。"
            yield return _gameMethods.Show("yongzhe1_layered", parts: new List<string>{"zui5"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(3640); // "我，真是个难搞的家伙啊。"
            yield return _gameMethods.OpenDialog(3641); // "我附和。"
            yield return _gameMethods.Show("yongzhe1_layered", parts: new List<string>{"yan2", "zui6"});
            yield return _gameMethods.ExecuteCharacterImageData("an");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice26_8d47c1ce.ogg");
            yield return _gameMethods.OpenDialog(3642); // "又没夸你。"
            yield return _gameMethods.Show("yongzhe1_layered", parts: new List<string>{"zui5"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(3643); // "……难搞的是你吧。"
            yield return _gameMethods.ChangeLabelTo("label_choice27");
        }

        public IEnumerator label_choice27()
        {
            yield return _gameMethods.ShowBlack();
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(3396); // "……"
            yield return _gameMethods.OpenDialog(3644); // "………"
            yield return _gameMethods.HideBlack();
            yield return _gameMethods.Show("yongzhe1_layered", parts: new List<string>{"mei4", "yan3", "zui1", "-emoji1", "-emoji2", "-emoji3"});
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(3645); // "我们坐在草坡上，眺望着地平线处的森林，交换着彼此的信息。"
            yield return _gameMethods.OpenDialog(3646); // "意识到机会难得，我争分夺秒地向安德鲁告知了这段时间里我所摸索出的有关赫泽尔的情报。"
            yield return _gameMethods.OpenDialog(3647); // "包括它强大的实力、能感知人类负面情绪的特殊能力、以及它疑似每年在这两天都会出门前往龙之谷的习性……等等。"
            yield return _gameMethods.OpenDialog(3648); // "反正有的没的我都和他说了一通，紧张程度堪比高考前老师给学生灌输考点。哪怕是最不起眼的小情报，说不定什么时候真的用到了呢？"
            yield return _gameMethods.OpenDialog(3649); // "到那时，也许这些信息就能保护他，甚至救他一命。"
            yield return _gameMethods.Show("yongzhe1_layered", parts: new List<string>{"zui3"});
            yield return _gameMethods.OpenDialog(3650); // "……不过，当这些沉重的正事说完后，我们便逐渐放松，开始聊起一些回忆中无关痛痒的小事。"
            yield return _gameMethods.OpenDialog(3651); // "原来不只是觉醒了骑士血脉的安德鲁，洛恩也跟着一起出发了。"
            yield return _gameMethods.OpenDialog(3652); // "作为新生代天才奥术师，和肩负着重任的勇者。"
            yield return _gameMethods.OpenDialog(3653); // "这一年来，他们经历了很多事。"
            yield return _gameMethods.OpenDialog(3654); // "……话说，安德鲁就算了，反正皮糙肉厚。"
            yield return _gameMethods.OpenDialog(3655); // "可洛恩那家伙明明是个彻头彻尾的室内派，从小就不喜欢日晒，反感流汗，任何时刻都要保持衣着整洁，甚至还有轻微的洁癖……这家伙出来冒险真的没问题吗。"
            yield return _gameMethods.Show("yongzhe1_layered", parts: new List<string>{"emoji1", "emoji2", "mei4", "yan4", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("an");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice27_052ee5be.ogg");
            yield return _gameMethods.OpenDialog(3656); // "对了，我一直想问——……"
            yield return _gameMethods.OpenDialog(3657); // "他忽然开口。"
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/caodi1.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(1.9f, 1.96f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 2.16f}})});
            Defaults.Gui_duihuakuang_you = 1;
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 2.69f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.45f}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.2f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.2f}, {"xoffset", -3f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.3f}, {"xoffset", 3f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.2f}, {"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}, {"blur", 0f}, {"alpha", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.2f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.2f}, {"yoffset", 0f}, {"blur", 4f}, {"alpha", 0.5f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.3f}, {"yoffset", -2f}, {"blur", 0f}, {"alpha", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.2f}, {"yoffset", 0f}, {"blur", 0.5f}, {"alpha", 0.7f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/emeng_dajie/magic1.ogg");
            yield return _gameMethods.Transition();
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(3658); // "就在这时，安德鲁的身影闪动了两下，几经模糊，逐渐变得飘渺起来。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan1", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(3659); // "他有些愕然地睁大双瞳，"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei4", "yan23", "zui10"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3660); // "随即，无奈地笑了。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei4", "yan12", "zui13"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}, {"blur", 0.5f}, {"alpha", 0.7f}})});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian", parts: new List<string>{"mei3", "yan5", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice27_5bf4ad50.ogg");
            yield return _gameMethods.OpenDialog(3661); // "「我要滚了，不能继续烦你了。{nw}{w=0.1}"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei4", "yan3", "zui12"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian", parts: new List<string>{"mei3", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(3662); // "高兴坏了吧？」"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei4", "yan12", "zui10"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(3387); // "…………"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan6", "zui10"});
            yield return _gameMethods.OpenDialog(3663); // "你想问什么？"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei4", "yan23", "zui10"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian", parts: new List<string>{"mei7", "yan6", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice27_9e9959ed.ogg");
            yield return _gameMethods.OpenDialog(3664); // "「嗯……"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui5"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice27_72d69440.ogg");
            yield return _gameMethods.OpenDialog(3665); // "不，{nw}{w=0.1}"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan2", "zui5"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice27_4a205202.ogg");
            yield return _gameMethods.OpenDialog(3666); // "还是下次再说吧。」"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan10", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(3667); // "……不知道话说半截很讨打么。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan3", "zui10"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan10", "zui7", "-emoji2"});
            yield return _gameMethods.OpenDialog(3668); // "他微微一笑。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan3", "zui12"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ease", 0.4f}, {"xoffset", -2f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.3f}, {"xoffset", 2f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.3f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"yoffset", 0f}, {"blur", 4f}, {"alpha", 0.5f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.3f}, {"yoffset", -1f}, {"blur", 0f}, {"alpha", 0.6f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.3f}, {"yoffset", 0f}, {"blur", 1f}, {"alpha", 0.4f}})});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice27_e93ca6f6.ogg");
            yield return _gameMethods.OpenDialog(3669); // "我知道，所以故意的。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan12", "zui10"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(3396); // "……"
            yield return _gameMethods.Show("an2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}, {"blur", 1f}, {"alpha", 0.4f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(3670); // "他的身影已经近乎透明了。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei7", "yan19", "zui13"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"zpos", 6.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei1", "yan8", "zui15", "-emoji2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice27_e0622a9a.ogg");
            yield return _gameMethods.OpenDialog(3671); // "所以，想知道的话，一定要再见面啊。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan8", "zui12"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 6.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei1", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(3672); // "不到一年，我就能把你救出苦海。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan3", "zui15"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice27_dd4b5ac4.ogg");
            yield return _gameMethods.OpenDialog(3673); // "到时候，记得给我当牛做马报答我噢。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan8", "zui10"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan24", "zui19"});
            yield return _gameMethods.OpenDialog(3674); // "嗯嗯，下次一定。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan16", "zui12"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei7", "yan24", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice27_7a39a76a.ogg");
            yield return _gameMethods.OpenDialog(3675); // "你啊……。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan16", "zui10"});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0.5 to 1.5>audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.8f}, {"zpos", -30f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(3676); // "不过……"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 2f, "audio/sound/emeng_dajie/Swing Whoosh_01.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -30f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/caodi1.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"at", "default"}, {"as", "caodi12"}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"zpos", 6.0f}, {"pos", new Vector2(1.0f, 1.98f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 1.58f}})});
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan2", "zui5"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"at", "default"}, {"as", "an22"}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"zpos", 6.0f}, {"pos", new Vector2(0.5f, 3.23f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.54f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/texiao/huiyi_biankuang.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"zpos", 6.0f}, {"anchor", new Vector2(0f, 0f)}, {"zoom", 0.98f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.ExecuteCharacterImageData("an_qian");
            yield return _gameMethods.OpenDialog(3677); // "「做任务的时候拿到了一个神秘卷轴，说是能把人送到心中最渴——{nw}{w=0.3}"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan4", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"as", "an22"}})});
            yield return _gameMethods.ExecuteCharacterImageData("an_qian");
            yield return _gameMethods.OpenDialog(3491); // "……」"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan17", "zui8", "emoji2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"as", "an22"}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"xoffset", -3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("an");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice22_f1013490.ogg");
            yield return _gameMethods.OpenDialog(3449); // "呃啊啊，反正就是跟传送道具差不多。"
            yield return _gameMethods.Hide("caodi12");
            yield return _gameMethods.Hide("an22");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/texiao/huiyi_biankuang.png");
            yield return _gameMethods.PlaySound("sounda1", 0.0f, 1f, "audio/sound/emeng_dajie/Swing Whoosh_01.mp3");
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan16", "zui10", "-emoji2"});
            yield return _gameMethods.Transition();
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei3", "yan10", "zui19"});
            yield return _gameMethods.OpenDialog(3678); // "「心目中最渴望的地方居然是我这边，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(3679); // "你到底是有多想我啊，小安德。」"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei3", "yan1", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei7", "yan17", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice27_2358f81c.ogg");
            yield return _gameMethods.OpenDialog(3680); // "……………"
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/moca1.ogg");
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan4", "zui8", "emoji1", "emoji2", "emoji4", "emoji8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"xoffset", -3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice27_fe88ff06.ogg");
            yield return _gameMethods.OpenDialog(3681); // "你——！"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan4", "zui3", "emoji1", "emoji2", "emoji4", "emoji8"});
            yield return _gameMethods.OpenDialog(3682); // "他的脸瞬间涨的通红，一副被戳穿的心虚慌张和羞恼成怒，{nw}{w=0.3}"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/emeng_dajie/magic1.ogg");
            yield return _gameMethods.Show("an2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 0f}, {"blur", 0.1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv");
            yield return _gameMethods.OpenDialog(3683); // "/n但还没来得及说些什么，少年的身形便消失在树林中。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(3684); // "什么都不见了。"
            yield return _gameMethods.Hide("an2");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(3685); // "就像什么未曾出现过。"
            yield return _gameMethods.Scene("caodi1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(1.01f, 1.0f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 120.0f}})});
            yield return _gameMethods.Transition(time:0.8f);
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(3686); // "我出神地站在原地，看了这片空无一人的草地很久很久。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3644); // "………"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(3687); // "就像再次敲响了某种警钟。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3688); // "和安德鲁的相逢，让我的头脑陡然间清醒了些许。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(3689); // "原本在这些日子里变得软弱钝化的心，也重新冷静下来。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(3690); // "……这不是该享乐的时候。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(3691); // "如果他们在努力，那我也不应该坐以待毙。"
            yield return _gameMethods.StopSound(channelName:"music1", fadeOut:5f);
            yield return _gameMethods.PlaySound("soundb", 0.0f, 1.0f, "audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/senlin7.jpg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            yield return _gameMethods.OpenDialog(3692); // "我再次检查了一遍自己之前踩点定下的逃跑路线，逐一确认找到的藏匿地点。"
            yield return _gameMethods.OpenDialog(3693); // "下一个藏匿点是某个山洞。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg50_memory.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg50_memory.jpg");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/cave1.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.0f)}, {"zoom", 0.7f}})});
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:1f);
            yield return _gameMethods.OpenDialog(3694); // "即将到达山洞入口时，我停住了脚步。"
            yield return _gameMethods.PlaySound("sounda1", 0.0f, 1.0f, "audio/sound/emeng_dajie/Magic Spell Book Pages Flipping_01.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}, {"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.80f}, {"xpos", 96f}, {"zpos", -114.0f}})});
            yield return _gameMethods.OpenDialog(3695); // "在地面上，出现了极其隐蔽的痕迹。"
            yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/demo_audio/music/a dull dawn.mp3");
            yield return _gameMethods.OpenDialog(3696); // "痕迹还很新鲜。"
            yield return _gameMethods.OpenDialog(3697); // "是受伤的野兽……？"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}, {"xpos", 96f}, {"zpos", -114.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"ypos", -42f}})});
            yield return _gameMethods.OpenDialog(3698); // "不，虽然那家伙警惕地磨掉了地面表层的脚印，却在周围的草木上留下了劈砍的痕迹，那是刀剑类武器才会留下的断口。"
            yield return _gameMethods.OpenDialog(3699); // "毫无疑问，这是人类的行迹。"
            yield return _gameMethods.OpenDialog(3700); // "要进去查看吗……？"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -42f}})});
            yield return _gameMethods.ChangeLabelTo("label_wangzi_1");
            yield return _gameMethods.PlaySound("music4", 3f, 1.0f, "audio/demo_audio/music/youshang2.mp3");
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/book1.mp3", "<silence 0.5>", "audio/demo_audio/sound/book1.mp3");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_shufang_baitian_quanjing.jpg");
            yield return _gameMethods.Transition();
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(3701); // "在剩下的时间里，我见缝插针地温习了真言。"
            if (Defaults.Wangzixian == 1)
            {
                                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
                yield return _gameMethods.OpenDialog(3702); // "总还是忍不住分神。"
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
                yield return _gameMethods.OpenDialog(3703); // "一会儿想到安德鲁，一会儿想到受伤的王子。"
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan21", "zui15"});
                yield return _gameMethods.OpenDialog(3704); // "安德鲁应该已经回到原本的地点，和洛恩会合了吧。"
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan18", "zui15"});
                yield return _gameMethods.OpenDialog(3705); // "王子菲珀斯，不知道他能不能在赫泽尔回来之前，离开这座山呢。"
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
                yield return _gameMethods.OpenDialog(3706); // "……原来还有人为了救我而在努力着，甚至已经找到了这个地方。"
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
                yield return _gameMethods.OpenDialog(3707); // "我有些感动。"
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
                yield return _gameMethods.OpenDialog(3708); // "然而，想起安德鲁脸上的绷带，以及王子身上的印记，心脏隐隐沉重。"
                yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan20", "zui15"});
                yield return _gameMethods.OpenDialog(3396); // "……"
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15"});
                yield return _gameMethods.OpenDialog(3709); // "…………不、别再想了。"
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
                yield return _gameMethods.OpenDialog(3710); // "我所处的环境容不下我沉浸在伤春悲秋之中。"
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan21", "zui15"});
                yield return _gameMethods.OpenDialog(3711); // "必须抛弃脑海中所有的杂念和眷念，来应对当下的问题。"
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan9", "zui15"});
                yield return _gameMethods.OpenDialog(3712); // "在面临灾厄之龙时，我越少提及到他们，对他们来说，才越安全。"
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
                yield return _gameMethods.OpenDialog(3713); // "不能让赫泽尔过多地注意他们。"
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
                yield return _gameMethods.OpenDialog(3714); // "为此，我必须把他们忘掉。"
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
                yield return _gameMethods.OpenDialog(3396); // "……"
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan17", "zui15"});
                yield return _gameMethods.OpenDialog(3715); // "默默地坐了一会儿，我努力地将那些思绪按压下去，封藏进心底。"
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui8"});
                yield return _gameMethods.OpenDialog(3716); // "学习、学习……"
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
                yield return _gameMethods.OpenDialog(3717); // "保持乐观和活泼。"
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan20", "zui8"});
                yield return _gameMethods.OpenDialog(3718); // "不要回忆，不能眷恋。"
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan12", "zui8"});
                yield return _gameMethods.OpenDialog(3719); // "/n眷恋……就会软弱。"
                yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan12", "zui15"});
                yield return _gameMethods.OpenDialog(3720); // "………………"

            }
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(3721); // "说起来，由于赫泽尔说过，真言是魔力运行的规则。/n所以，我曾指望过通过学习这种语言来掌握魔法。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(3722); // "但每次那拗口的话语到了嘴边，明明也能感觉到有某种能量充盈在身体内，呼之欲发。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(3723); // "但最终还是缺了点什么。仿佛有一层隔膜阻挡。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan20", "zui15"});
            yield return _gameMethods.OpenDialog(3724); // "我不明原因，只能寄希望于继续学习。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_shufang_bangwan_quanjing.jpg");
            yield return _gameMethods.Transition();
            yield return _gameMethods.StopEngineTime(time:0.4f);
            yield return _gameMethods.PlaySound("soundb", 2f, 1.0f, "audio/demo_audio/sound/chong1.ogg");
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/heilong_shufang_yewankai_quanjing.jpg");
            yield return _gameMethods.Transition(time:0.8f);
            yield return _gameMethods.OpenDialog(3725); // "夜幕降临。"
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/door_close1.mp3");
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(3726); // "我回到卧室，上床休息。"
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:10f);
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/woshi_nv3_tian.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.2f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition(time:0.4f);
            yield return _gameMethods.OpenDialog(3727); // "躺了很久，睡意始终没有造访我的眼皮，我只得盯着天花板发呆。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(3396); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3728); // "安德鲁和洛恩，他们现在在做什么呢……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(3729); // "一股烦闷涌上心头。"
            if (Defaults.Bai_xiu == 1)
            {
                                yield return _gameMethods.SceneBlack();
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
                yield return _gameMethods.Transition(time:0.5f);
                yield return _gameMethods.OpenDialog(3730); // "我翻来覆去许久，最终才在不知何时沉沉睡去。 "
                yield return _gameMethods.ChangeLabelTo("label_zhuxian4_3");

            }
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/woshi_nv3_tian.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.2f}})});
            yield return _gameMethods.TransitionBy("blink2");
            yield return _gameMethods.PlaySound("sound", 0.0f, 2f, "audio/demo_audio/sound/door_qiao2.ogg");
            yield return _gameMethods.StopSound(channelName:"music4", fadeOut:3f);
            yield return _gameMethods.OpenDialog(3731); // "咚咚。"
            Defaults.Persistent.Jq_5_4 = 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(3732); // "突兀出现的声响吸引了注意。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/nv_chuangshang_yewan/nv_chuangshang_yewan_sky.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.4f, 2.28f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.42f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/nv_chuangshang_yewan/nv_chuangshang_yewan_nuo.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.4f, 2.28f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.42f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/nv_chuangshang_yewan/nv_chuangshang_yewan.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.4f, 2.28f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.42f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui15"});
            yield return _gameMethods.OpenDialog(3733); // "这声音的方位不是从房门，而是——……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan4", "zui15"});
            yield return _gameMethods.OpenDialog(3734); // "有人在敲阳台的门？"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/emeng_dajie/Body_up_01.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.34f}, {"ypos", 816f}})});
            yield return _gameMethods.OpenDialog(3735); // "我猛然坐起。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 816f}})});
            yield return _gameMethods.OpenDialog(3736); // "赫泽尔不可能此时回来，更不可能选择从这里拜访。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(270f, 774f)}, {"zpos", -354.0f}})});
            yield return _gameMethods.TransitionBy("blink2");
            yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/demo_audio/music/time_syuanji.mp3");
            yield return _gameMethods.OpenDialog(3737); // "那就只有——"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 270f}, {"zpos", -354.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"xpos", 306f}, {"zpos", -408.0f}})});
            yield return _gameMethods.OpenDialog(3738); // "诺伯拉站在阳台上，隔着透明的琉璃门与我相望。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 306f}, {"zpos", -408.0f}})});
            if (Defaults.Wangzixian == 1)
            {
                                yield return _gameMethods.OpenDialog(3739); // "…………今天，还真是忙碌的一天啊。"

            }
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan24", "zui7"});
            yield return _gameMethods.OpenDialog(3740); // "……好吧，现在我的确不用打开城堡的大门了。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(3741); // "不过赫泽尔显然不希望我与他有过多的接触。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(3742); // "如果我接待诺伯拉，赫泽尔知道了肯定会不高兴的。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(3743); // "——除非，我能瞒过他。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(3744); // "到底开不开门呢？"
            if (Defaults.Persistent.He_ending==1)
            {
                                yield return _gameMethods.OpenDialog(3745); // "我盯着门外那人冰蓝色的眼睛，不知为何，心头忽然冒出一种怪异的、似曾相识之感。"
                yield return _gameMethods.OpenDialog(3746); // "……有种预感，如果此时，在这里，我不打开这扇门。"
                yield return _gameMethods.OpenDialog(3747); // "将会错过非常重要的信息。"

            }
            yield return _gameMethods.OpenSelectMenu(talk: new List<string>{"-开门"}, jump: new List<string>{"label_zhuxian4_menu_0_YLz3BRGa"}, condition: new List<string>{"NONE"});
        }

        public IEnumerator label_multiple_choice1()
        {
            yield return _gameMethods.OpenSelectMenu(talk: new List<string>{"-你今天怎么来得这么晚", "-你可以远距离听到心声吗", "-能听到龙的心声吗"}, jump: new List<string>{"label_zhuxian4_menu_0_6ljhrtMf", "label_zhuxian4_menu_0_8bb1wFnS", "label_zhuxian4_menu_0_bRSfgS1g"}, condition: new List<string>{"Defaults.Choice_1_new", "Defaults.Choice_2_new", "Defaults.Choice_3_new"});
        }

        public IEnumerator label_choice28_1()
        {
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(3774); // "你今天怎么到的这么晚。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(3775); // "哎呀，这就要问你家的幼龙了。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan20", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.OpenDialog(3776); // "他在路上布置了不少小麻烦，我差点来不了呢。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan20", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan10", "zui7", "emoji2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice22_798b36d7.ogg");
            yield return _gameMethods.OpenDialog(3396); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan24", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(3777); // "那你还真是锲而不舍、身残志坚啊。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.OpenDialog(3778); // "我这么锲而不舍，翻山越岭地来看你，有没有很感动？"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan24", "zui19", "-emoji2"});
            yield return _gameMethods.OpenDialog(3779); // "「嗯嗯真感动，{nw}{w=0.1}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan12", "zui19"});
            yield return _gameMethods.OpenDialog(3780); // "我都要哭了。」"
            yield return _gameMethods.ChangeLabelTo("label_choice_or_ending1");
        }

        public IEnumerator label_choice28_2()
        {
            yield return _gameMethods.PlaySound("sound", 0.0f, 2f, "audio/sound/manbu/Body1_02_duan.mp3");
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -60.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.7f}, {"zpos", -102.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(3781); // "话说、你是能够随时听到世间所有生灵的心声么？"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan6", "zui10"});
            yield return _gameMethods.OpenDialog(3782); // "即便彼此相隔万里？"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan9", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei8", "yan6", "zui15"});
            yield return _gameMethods.OpenDialog(3756); // "「嗯——{nw}{w=0.1}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan9", "zui5"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(3783); // "理论上是可行的。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui4"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -102.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.OpenDialog(3784); // "只要在集体的潜意识里，撷取到目标的那段思维就好了。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui6"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei8", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(3785); // "不过，实际情况比这复杂多了。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui6"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei8", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(3391); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(3786); // "「你可以把世间生物的心声想象为一个海洋，{nw}{w=0.1}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan19", "zui5"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei7", "yan6", "zui14"});
            yield return _gameMethods.OpenDialog(3787); // "它散乱、深邃又无序，蕴含漩涡与暗流。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan20", "zui4"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan2", "zui14"});
            yield return _gameMethods.OpenDialog(3788); // "在这片潜意识的海洋里，漂浮着数以百万计，来自不同地方、不同种族、不同语言的只言片语。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui5"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(3789); // "「我能够在其中遨游、观测，{nw}{w=0.1}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui6"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(3790); // "但不可能影响或控制它。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui5"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.OpenDialog(3791); // "所以，想在其中定向地找到某一个人的声音也是很困难的。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(3792); // "啊，也就是说……"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui10"});
            yield return _gameMethods.OpenDialog(3793); // "在那里，你可以听到世间万物的思绪吗？"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui8"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(3391); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.OpenDialog(3794); // "是啊。很有趣的哦。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan20", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.OpenDialog(3795); // "随手抓住一尾小鱼，就能听到不知在何时、何处，由何人发出的心声。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(3391); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(3796); // "不过，就算有时听到了很有趣的想法，也见不到当事人。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.OpenDialog(3797); // "这点偶尔有些遗憾吧。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.PlaySound("sound", 0.4f, 0.7f, "audio/demo_audio/sound/moca2.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -102.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"zpos", -60.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan3", "zui14"});
            yield return _gameMethods.OpenDialog(3798); // "听起来像捞漂流瓶一样，还蛮浪漫的。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -60.0f}})});
            yield return _gameMethods.ChangeLabelTo("label_choice_or_ending1");
        }

        public IEnumerator label_choice28_3()
        {
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(3799); // "我一直很好奇，你能也听到同族的想法么？"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui19"});
            yield return _gameMethods.OpenDialog(3800); // "赫泽尔的呢。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui5"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(3801); // "其他的龙可以，但尼德霍格不行。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui10"});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.6>audio/sound/jiaobusheng_xin_kuai1.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -60.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.4f}, {"zpos", -102.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui9"});
            yield return _gameMethods.OpenDialog(3802); // "咦。为什么？"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui1"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -102.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(3803); // "他的权柄高于我。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.OpenDialog(3804); // "我没有权力查看。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/moca1.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -2f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 2f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan6", "zui10"});
            yield return _gameMethods.OpenDialog(3805); // "「居然。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(3806); // "赫泽尔有这么厉害吗，明明还只是幼年期？」"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui6"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei8", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(3807); // "「他是六柱龙之一。{nw}{w=0.1}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan9", "zui5"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei3", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(3808); // "位格甚至高过了掌管生命的神圣母龙。{nw}{w=0.1}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui6"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei3", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(3809); // "能制衡他的大约也只有自然了。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui10"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui19"});
            yield return _gameMethods.OpenDialog(3810); // "「可是你穿的衣服花里胡哨的，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(3811); // "一副看起来比他强的样子。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan20", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan11", "zui7"});
            yield return _gameMethods.OpenDialog(3812); // "当然我很强，只是还没有那么强罢了。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan9", "zui4"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(3813); // "「至于服装选择，{nw}{w=0.1}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(3814); // "这和性格有关。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan6", "zui10", "emoji12"});
            yield return _gameMethods.OpenDialog(3815); // "为什么黑暗之龙会比神圣之龙更强？"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei7", "yan6", "zui14", "emoji12"});
            yield return _gameMethods.OpenDialog(3816); // "「很奇怪吗？{nw}{w=0.1}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(3817); // "混乱、无序与黑暗是世界永恒的主题，{nw}{w=0.1}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei7", "yan2", "zui15", "-emoji12"});
            yield return _gameMethods.OpenDialog(3818); // "而生命只不过是其中一个偶然并短暂的插曲而已。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui8"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(3391); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(3387); // "…………"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui14"});
            yield return _gameMethods.OpenDialog(3819); // "我努力地用自己的认知储备去理解这句话。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan12", "zui8", "emoji2"});
            yield return _gameMethods.OpenDialog(3820); // "呃、大概是这个意思吧，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(3821); // "宇宙的规律是熵增。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei9", "yan20", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan6", "zui14"});
            yield return _gameMethods.OpenDialog(3822); // "真空也的确是黑暗的，{nw}{w=0.1}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei9", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3823); // "太阳——恒星，终有一天会能量枯竭，直至死亡，然后寂灭。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(3824); // "而终结永恒。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan24", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(3825); // "……大概。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui3"});
            Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei3", "yan24", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(3826); // "看你的样子，好像是理解了？很有悟性嘛。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei9", "yan11", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan2", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(3827); // "如果能活下来，说不定有成为大奥术师的潜力呢。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei9", "yan11", "zui8"});
            yield return _gameMethods.PlaySound("sound", 0.4f, 1.0f, "audio/demo_audio/sound/moca2.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -102.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.25f}, {"zpos", -60.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan24", "zui19"});
            yield return _gameMethods.OpenDialog(3828); // "谢谢称赞，如果我能活下来，就努力看看。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -60.0f}})});
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan24", "zui7"});
            yield return _gameMethods.OpenDialog(3829); // "不客气。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan2", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice22_18acb653.ogg");
            yield return _gameMethods.OpenDialog(3387); // "…………"
            yield return _gameMethods.ChangeLabelTo("label_choice_or_ending1");
        }

        public IEnumerator label_choice_or_ending1()
        {
            if (!Defaults.Choice_1_new && !Defaults.Choice_2_new && !Defaults.Choice_3_new)
            {
                                yield return _gameMethods.ChangeLabelTo("label_choice28");

            }
            yield return _gameMethods.ChangeLabelTo("label_multiple_choice1");
        }

        public IEnumerator label_choice28()
        {
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:2f);
            yield return _gameMethods.PlaySound("sounda", 0.0f, 3f, "audio/sound/houhui/Hint_01.mp3");
            yield return _gameMethods.OpenDialog(3830); // "——忽然间、我意识到了一点。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(3831); // "赫泽尔的位阶高于诺伯拉。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei8", "yan7", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3832); // "他不假辞色地拒绝诺伯拉来这里。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(3833); // "可后者还是来了。{nw}{w=0.1}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei8", "yan14", "zui8"});
            yield return _gameMethods.PlaySound("music", 0.0f, 0.8f, "audio/demo_audio/music/disappearing painting.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3834); // "/n而且，对我的问题有问必答，简直到了称得上纵容的地步。"
            Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan6", "zui15"});
            yield return _gameMethods.OpenDialog(3835); // "我没有给过他任何利益，他却敞开了情报信息任凭我询问。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei9", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan17", "zui15"});
            yield return _gameMethods.OpenDialog(3396); // "……"
            yield return _gameMethods.PlaySound("sound", 0.4f, 0.5f, "audio/demo_audio/sound/moca2.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}, {"zpos", -60.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.26f}, {"ypos", -24f}, {"zpos", -126.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(3836); // "所以，你真的是特地来找我的。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -24f}, {"zpos", -126.0f}})});
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei9", "yan9", "zui12"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(3756); // "「嗯——{nw}{w=0.1}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice28_cac3c803.ogg");
            yield return _gameMethods.OpenDialog(3837); // "这次总算明知故问了吧？」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui19"});
            yield return _gameMethods.OpenDialog(3838); // "怎么算呢，你刚刚又没有正面回答。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(3839); // "好吧，我是，小公主。"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<from 0 to 1.5>audio/sound/jiaobusheng_nuo_normal1.ogg");
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"lv1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.9f}, {"zpos", 24.0f}})});
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei10", "yan11", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.OpenDialog(3840); // "当然——我只为你而来。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"lv1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 24.0f}})});
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei10", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui19"});
            yield return _gameMethods.OpenDialog(3841); // "真意外，我以为你们龙不会把人类放在眼里。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan3", "zui2"});
            yield return _gameMethods.OpenDialog(3842); // "毕竟我们短暂的生命与有限的认知，在你们眼里应该会愚蠢又可怜才对。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan3", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice28_7007f82a.ogg");
            yield return _gameMethods.OpenDialog(3843); // "怎么会。人类可是很有意思的。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan20", "zui1"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(3391); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(3844); // "「虽然特点各异，{nw}{w=0.1}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(3845); // "但兜兜转转，都会在关键节点被相似的弱点绊倒。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(3846); // "「偶尔又会出其不意~~地、发出一生一次的闪光。{nw}{w=0.1}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(3847); // "/n多有趣呀。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui8"});
            Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan17", "zui19"});
            yield return _gameMethods.OpenDialog(3848); // "就像在看悲喜剧一样吗？"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan4", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei3", "yan17", "zui7"});
            yield return _gameMethods.OpenDialog(3849); // "「对对、{nw}{w=0.1}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(3850); // "/n——所以，我来找你了。」"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<from 0 to 1.5>audio/sound/jiaobusheng_nuo_normal1.ogg");
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"lv1", "mei7", "yan2", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 2.46f}, {"zpos", 24.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.9f}, {"ypos", 2.47f}, {"zpos", 72.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice28_e3f629ee.ogg");
            yield return _gameMethods.OpenDialog(3851); // "我也很期待，眼前这幕戏剧的结局。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"lv1", "mei7", "yan2", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 2.47f}, {"zpos", 72.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan8", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice25_2ed82d68.ogg");
            yield return _gameMethods.OpenDialog(3396); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui19"});
            yield return _gameMethods.OpenDialog(3852); // "「有什么可期待的呢，{nw}{w=0.1}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei8", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui19"});
            yield return _gameMethods.OpenDialog(3853); // "你不觉得人龙力量太过悬殊，情节没什么悬念吗。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei8", "yan13", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(3854); // "「嗯……{nw}{w=0.1}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(3855); // "因为女主角做出了出人意料的举动，{nw}{w=0.1}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(3856); // "所以剧情发展变得意外的有看头了起来。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(3481); // "「……{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui10"});
            yield return _gameMethods.OpenDialog(3857); // "话说，既然能够看破人心。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui9"});
            yield return _gameMethods.OpenDialog(3858); // "人类鉴赏什么的，你不是应该已经看到腻烦了嘛。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice28_d07af76d.ogg");
            yield return _gameMethods.OpenDialog(3859); // "不是哦。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice28_d7f826f6.ogg");
            yield return _gameMethods.OpenDialog(3860); // "因为看过大量相似的情节，所以我是很挑食的。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan14", "zui6"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(3861); // "「因为很挑食，所以也常常处于饥饿中。{nw}{w=0.1}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(3862); // "/n找到一个有意思的剧目，就难以放手了。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan8", "zui10"});
            yield return _gameMethods.OpenDialog(3863); // "……这样啊。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(3864); // "上次见面，我以为他毫无疑问和赫泽尔是一伙的。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui8"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3391); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(3865); // "但现在看来，他似乎站在一个中立的位置。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan20", "zui15"});
            yield return _gameMethods.OpenDialog(3866); // "这或许是一个可以拉拢的力量。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei8", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice25_b99402bb.ogg");
            yield return _gameMethods.OpenDialog(3396); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(3867); // "这番心声，想必也已经被他听到了吧。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"ypos", -66f}, {"zpos", -192.0f}})});
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei8", "yan1", "zui8"});
            yield return _gameMethods.TransitionBy("blink2");
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(3391); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:5f);
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei8", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3868); // "我抬头看向对面，白发青年正看着我，眼底透露出一种隔岸观火般轻忽的漫不经心，却又好整以暇、拭目以待的微笑。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15"});
            yield return _gameMethods.OpenDialog(3869); // "没有离开。这代表一种默许。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei8", "yan1", "zui8"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3391); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei8", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(3870); // "他在等待…又或是，在期待我的拉拢。"
            Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan17", "zui15"});
            yield return _gameMethods.OpenDialog(3871); // "——也就是说，接下来的表现至关重要，我将有机会从中受益。"
            yield return _gameMethods.OpenDialog(3387); // "…………"
            yield return _gameMethods.PlaySound("sound", 0.0f, 2f, "<from 0 to 1>audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.PlaySound("music1", 2f, 0.3f, "audio/music/white boat.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -192.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.90f}, {"zpos", -228.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(3872); // "但是先生，只在台下坐着观看，不会觉得太无聊了吗？"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei8", "yan1", "zui8"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
            yield return _gameMethods.OpenDialog(3391); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei8", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui19"});
            yield return _gameMethods.OpenDialog(3873); // "时代已经不同以往了，我们完全可以提高观众的参与感，带来沉浸式体验。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei8", "yan2", "zui14"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(3874); // "你有什么好的提议么，演员小姐？"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -228.0f}})});
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei8", "yan2", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv", parts: new List<string>{"mei7", "yan24", "zui7"});
            yield return _gameMethods.OpenDialog(3875); // "（你知道什么叫主播互动、还有榜一大哥吗。）"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei8", "yan4", "zui5"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice28_8d69eca8.ogg");
            yield return _gameMethods.OpenDialog(3876); // "那是什么？"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei8", "yan4", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui19"});
            yield return _gameMethods.OpenDialog(3877); // "「呃……{nw}{w=0.3}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan24", "zui19"});
            yield return _gameMethods.OpenDialog(3878); // "赞助商的意思。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei8", "yan7", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan12", "zui19"});
            yield return _gameMethods.OpenDialog(3879); // "如果你为我提供一些帮助，我会给你特别的回报。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei8", "yan13", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan2", "zui2"});
            yield return _gameMethods.OpenDialog(3880); // "下注在我身上吧，我不会让你失望的。"
            Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan5", "zui2"});
            yield return _gameMethods.OpenDialog(3881); // "现在的话，还可以算你赌资半价打折噢。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei8", "yan11", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei3", "yan5", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice28_d9cec5e6.ogg");
            yield return _gameMethods.OpenDialog(3882); // "嗯，回报呢？"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei8", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui19"});
            yield return _gameMethods.OpenDialog(3883); // "「我能活下来，打破预言，{nw}{w=0.1}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui19"});
            yield return _gameMethods.OpenDialog(3884); // "站在创世之初预设的舞台中央，{nw}{w=0.1}"
            Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan17", "zui4"});
            yield return _gameMethods.OpenDialog(3885); // "为冰霜与心灵之龙阁下献上精彩的一幕。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan17", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice28_913bd6bf.ogg");
            yield return _gameMethods.OpenDialog(3886); // "真诱人呢，在谢幕后，我还能得到其他好处。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice28_180552a4.ogg");
            yield return _gameMethods.OpenDialog(3887); // "一个潜力股女主角，这可不多得呀。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(3888); // "「是啊，以后会源源不断地生产出其他新颖的剧目。这还不够赚吗？{nw}{w=0.3}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui20", "emoji7", "emoji9"});
            yield return _gameMethods.OpenDialog(3889); // "哎呀，简直太合算了。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei7", "yan17", "zui7", "emoji7", "emoji9"});
            yield return _gameMethods.OpenDialog(3890); // "「呵呵——……{nw}{w=0.1}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(3891); // "知道你现在像什么吗？」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10", "-emoji7", "-emoji9"});
            yield return _gameMethods.OpenDialog(3892); // "什么。"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<from 0 to 0.8>audio/sound/jiaobusheng_nuo_normal1.ogg");
            yield return _gameMethods.PlaySound("sound", 0.4f, 1f, "audio/demo_audio/sound/moca2.mp3");
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"lv1", "mei7", "yan11", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 2.47f}, {"zpos", 72.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.31f}, {"ypos", 2.49f}, {"zpos", 80.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(3893); // "一个油嘴滑舌、欺骗贵族小姐的风流浪子。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"lv1", "mei7", "yan11", "zui7"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 2.49f}, {"zpos", 80.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan10", "zui15", "emoji2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice26_b99402bb.ogg");
            yield return _gameMethods.OpenDialog(3396); // "……"
            Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan10", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(3894); // "风流浪子自己在说什么呢。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 2f, "<from 0 to 1>audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -228.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"zpos", -264.0f}})});
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui7"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
            yield return _gameMethods.OpenDialog(3391); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui7"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19", "-emoji2"});
            yield return _gameMethods.OpenDialog(3895); // "那你愿意吗，诺伯拉先生。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan5", "zui19"});
            yield return _gameMethods.OpenDialog(3896); // "我会用实际证明，我是个值得依靠的女人。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan20", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei3", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(3756); // "「嗯——{nw}{w=0.1}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan20", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice28_a21a75fc.ogg");
            yield return _gameMethods.OpenDialog(3897); // "这可真是令人心动。」"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -264.0f}})});
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei10", "yan7", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(3898); // "「但想让我走出观众席，与尼德霍格为敌，{nw}{w=0.1}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei10", "yan1", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice28_60ca1942.ogg");
            yield return _gameMethods.OpenDialog(3899); // "一个空头许诺可还不够。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei10", "yan11", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice28_49cd2263.ogg");
            yield return _gameMethods.OpenDialog(3900); // "我需要一点更实际的、能立刻拿到手的东西。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei10", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan24", "zui15"});
            yield return _gameMethods.OpenDialog(3901); // "有什么，是他会感兴趣的。"
            yield return _gameMethods.OpenSelectMenu(talk: new List<string>{"-给他讲一个故事"}, jump: new List<string>{"label_zhuxian4_menu_0_0iznrAW0"}, condition: new List<string>{"NONE"});
        }

        public IEnumerator label_multiple_choice2()
        {
            yield return _gameMethods.OpenSelectMenu(talk: new List<string>{"-通过真诚的恳求"}, jump: new List<string>{"label_zhuxian4_menu_0_b5alUqkq"}, condition: new List<string>{"Defaults.Choice_1_newa"});
        }

        public IEnumerator label_choice29_1()
        {
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.29f}, {"zpos", -175.0f}})});
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui14"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(4023); // "合作愉快，演员小姐。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui2"});
            yield return _gameMethods.OpenDialog(4024); // "我的荣幸，资助商先生。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -30.0f}})});
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan11", "zui7"});
            yield return _gameMethods.OpenDialog(4025); // "……接着，我便和他相对无言了。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui19"});
            yield return _gameMethods.OpenDialog(4026); // "像你这么尊贵的龙，一定很受欢迎也很忙吧？"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.5f, "audio/sound/manbu/Body2_01.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.8f}, {"ypos", -600f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/woshi_nv_shafa.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"at", "default"}, {"as", "woshi_nv_shafa2"}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"alpha", 0f}, {"pos", new Vector2(0.32f, 1.93f)}, {"zoom", 1.04f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(3396); // "……"
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/woshi_nv_shafa.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"as", "woshi_nv_shafa2"}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"alpha", 1f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -600f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(4027); // "我抬头委婉地看了看月亮，诚恳地表达出“已经很晚了”的意思。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -600f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.8f}, {"ypos", 0f}})});
            yield return _gameMethods.Show("woshi_nv_shafa", parts: new List<string>{"at", "default", "as", "woshi_nv_shafa2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"alpha", 1f}, {"pos", new Vector2(0.32f, 1.93f)}, {"zoom", 1.04f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"alpha", 0f}})});
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan4", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(4028); // "「嗯？{nw}{w=0.1}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan4", "zui5"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(4029); // "今晚我可是专门来陪你的哦。」"
            yield return _gameMethods.Hide("woshi_nv_shafa2");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}})});
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(4030); // "而夜晚还很长，远没有结束。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(4031); // "多谢你的陪伴，让我度过了一个美好的夜晚。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan17", "zui2"});
            yield return _gameMethods.OpenDialog(4032); // "而作为回报，我也不该再多占用你宝贵的时间了。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan17", "zui7"});
            yield return _gameMethods.OpenDialog(4033); // "能够将光阴消磨在可爱的公主身上，是我的荣幸。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/manbu/Body1_02_duan.mp3");
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui3"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.50f}, {"zpos", 6.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.OpenDialog(4034); // "比如，我们可以再分享一个故事。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"lv1", "mei7", "yan7", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 6.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui19"});
            yield return _gameMethods.OpenDialog(4035); // "「我相信你是一位有耐心的绅士，"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan11", "zui4"});
            yield return _gameMethods.OpenDialog(4036); // "等到下一次，好吗？」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei7", "yan11", "zui7"});
            yield return _gameMethods.OpenDialog(4037); // "「好啊。{nw}{w=0.1}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan14", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(4038); // "那你也可以讲讲，你从哪里来。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui14"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei4", "yan10", "zui10", "emoji2"});
            yield return _gameMethods.OpenDialog(4039); // "「而你身上的这些秘密，{nw}{w=0.1}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(4040); // "又源自何处？」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan11", "zui1", "emoji2"});
            yield return _gameMethods.OpenDialog(4041); // "哈哈，我怎么会舍得拒绝你的心愿呢。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan5", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(4042); // "你等一下，我这就给你讲个故事。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui8"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
            yield return _gameMethods.OpenDialog(3391); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan24", "zui16", "emoji2"});
            yield return _gameMethods.OpenDialog(3396); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(4043); // "怎么说呢，明明已经上千岁了，却喜欢对刚结盟的盟友这样亲密。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui16", "emoji2"});
            yield return _gameMethods.OpenDialog(4044); // "他该不会真的是自来……"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan10", "zui7", "-emoji2"});
            yield return _gameMethods.OpenDialog(3396); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui15", "emoji2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice25_0894ca4b.ogg");
            yield return _gameMethods.OpenDialog(3387); // "…………"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/ding1.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -30.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"zpos", -60.0f}})});
            Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan5", "zui8", "emoji7", "emoji9", "-emoji2"});
            yield return _gameMethods.OpenDialog(4045); // "……自然而然令所有人为之折服的风度翩翩的绅士。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -60.0f}})});
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan24", "zui7", "emoji2", "-emoji7", "-emoji9"});
            yield return _gameMethods.OpenDialog(4046); // "好吧，{nw}{w=0.1}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei1", "yan1", "zui15"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3391); // "{nw}{w=0.15}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei11", "yan2", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(4047); // "既然是我的榜一大哥。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei1", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui8", "-emoji2"});
            yield return _gameMethods.OpenDialog(4048); // "那我也要发挥一些职业素养，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan2", "zui8"});
            yield return _gameMethods.OpenDialog(4049); // "今晚把他哄开心了。"
            yield return _gameMethods.ShowBlack(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 6f}})});
            yield return _gameMethods.Transition(time:0.4f);
            Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 2;
            yield return _gameMethods.OpenDialog(4050); // "然后，我听到了青年的轻笑。我绞尽脑汁，又编了两个故事，讲时难免心惊胆战，生怕哪一段续写太过无聊，让他对我失去了兴趣。"
            yield return _gameMethods.OpenDialog(4051); // "好在，这些担心的事情没有发生……讲到最后，我困得打起了哈欠。"
            yield return _gameMethods.HideBlack();
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei10", "yan1", "zui3"});
            yield return _gameMethods.Transition(time:0.4f);
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei7", "yan9", "zui15"});
            yield return _gameMethods.OpenDialog(4052); // "「好吧，也不能一直纠缠不休，{nw}{w=0.1}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei10", "yan7", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei7", "yan11", "zui12", "emoji19"});
            yield return _gameMethods.OpenDialog(4053); // "今夜就这样结束吧。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei10", "yan7", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan21", "zui15", "emoji18", "-emoji19"});
            yield return _gameMethods.OpenDialog(4054); // "嗯…………"
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/demo_audio/sound/door_close1.mp3");
            yield return _gameMethods.Transition(time:0.4f);
            yield return _gameMethods.OpenDialog(3396); // "……"
            yield return _gameMethods.Scene("woshi_nv1_yewan_yangtai_ani", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.25f, 0.7f)}, {"zoom", 0.96f}})});
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"lv1", "mei10", "yan20", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.29f, 2.44f)}, {"zoom", 0.52f}})});
            yield return _gameMethods.Transition(time:0.4f);
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nuo_qian");
            yield return _gameMethods.OpenDialog(3391); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei10", "yan7", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice23_f5b95db1.ogg");
            yield return _gameMethods.OpenDialog(3420); // "「……"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_qian");
            yield return _gameMethods.OpenDialog(4055); // "晚安，公主殿下。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui13"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nuo_qian");
            yield return _gameMethods.OpenDialog(3391); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei6", "yan11", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo");
            yield return _gameMethods.OpenDialog(4056); // "愿你有个好梦。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.StopEngineTime(time:0.2f);
            yield return _gameMethods.PlaySound("sounda1", 0.0f, 1.0f, "audio/sound/manbu/Body2_01.mp3");
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<silence 0.4>", "audio/demo_audio/sound/feng1.mp3");
            yield return _gameMethods.StopSound(channelName:"music1", fadeOut:4f);
            yield return _gameMethods.Hide("nuo1");
            yield return _gameMethods.Transition();
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan10", "zui15", "emoji18"});
            yield return _gameMethods.OpenDialog(4057); // "我对他挥了挥手作为告别，他离开了。"
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/woshi_nv3.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.0f)}, {"zoom", 0.57f}})});
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<from 0 to 2>audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan11", "zui11", "emoji19", "-emoji18"});
            yield return _gameMethods.OpenDialog(4058); // "强撑着睡意，我在睡着之前打开了全部的窗户，通风散气。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/emeng_dajie/Lying Bed_01.mp3");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/woshi_nv3_tian.jpg");
            yield return _gameMethods.Transition();
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan12", "zui15", "-emoji19"});
            yield return _gameMethods.OpenDialog(4059); // "然后一头栽在了床上。"
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.TransitionBy("blink4_1");
            yield return _gameMethods.OpenDialog(3396); // "……"
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice26_f6afd5cd.ogg");
            yield return _gameMethods.OpenDialog(3387); // "…………"
            yield return _gameMethods.ChangeLabelTo("label_bai_xinlingtongxun");
        }

        public IEnumerator label_zhuxian4_2()
        {
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.PlaySound("sounda3", 0.0f, 0.8f, "audio/demo_audio/sound/tangxia1.mp3");
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(4060); // "目送诺伯拉离开后，我躺回床上，望着天花板，不知不觉间睡着了。"
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(3720); // "………………"
            yield return _gameMethods.ChangeLabelTo("label_zhuxian4_3");
        }

        public IEnumerator label_zhuxian4_3()
        {
            yield return _gameMethods.PlaySound("soundc", 0.0f, 1.0f, "audio/demo_audio/sound/niaoming.ogg");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/senlin7.jpg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(4061); // "第二天上午，我继续出城堡锻炼体能，顺带熟悉周边地形。"
            yield return _gameMethods.StopSound(channelName:"music4", fadeOut:3f);
            yield return _gameMethods.StopSound(channelName:"soundc", fadeOut:5f);
            yield return _gameMethods.ChangeLabelTo("label_zhuxian4");
        }

        public IEnumerator label_zhuxian4()
        {
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/heilong_chufang_baitian_man.jpg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            if (Defaults.Bai_xue == 0)
            {
                                yield return _gameMethods.PlaySound("music", 2f, 1.0f, "audio/demo_audio/music/richang1.mp3");

            }
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/canpanpengzhuang2_duan.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(3387); // "…………"
            yield return _gameMethods.PlaySound("soundb", 0.0f, 2f, "audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15"});
            yield return _gameMethods.OpenDialog(4062); // "吃完午饭，我回到卧室休息。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg36_memory.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg36_memory.jpg");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/jingzi_he.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.24f)}, {"zoom", 0.71f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:1f);
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(4063); // "路过穿衣镜时，停下脚步，看着镜中的自己。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(3396); // "……"
            if (Defaults.Bai_xin == 0)
            {
                                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
                yield return _gameMethods.OpenDialog(4064); // "安德鲁的出现，唤醒了我的危机意识。"
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
                yield return _gameMethods.OpenDialog(4065); // "倘若想战胜一头龙，应该怎么做呢？"
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
                yield return _gameMethods.OpenDialog(4066); // "可能和其他物种一样，要想办法找到并攻击它的弱点吧。"
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
                yield return _gameMethods.OpenDialog(4067); // "一般来说，寻常生物的致命点，无非也就是大脑、心脏和大动脉等部位。"

            }
            yield return _gameMethods.PlaySound("sound", 0.0f, 2.5f, "audio/sound/manbu/Body1_02_duan.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(4068); // "我把手放在了胸脯上。追随着心跳声，我的手在左胸前轻轻摸索。"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 2f, "<from 0 to 4>audio/demo_audio/sound/heart1.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15"});
            yield return _gameMethods.OpenDialog(4069); // "心脏，……在肋骨的第五根到第七根之间。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(4070); // "赫泽尔，你的心在哪里呢？"
            yield return _gameMethods.OpenDialog(3387); // "…………"
            yield return _gameMethods.Scene("tiankong_bangwan", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.36f}, {"ypos", 1.0f}, {"anchor", new Vector2(0.5f, 1.0f)}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(3720); // "………………"
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/heilong_dating_bangwan_louti2.jpg");
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.7f, "audio/demo_audio/sound/door_open1.mp3");
            yield return _gameMethods.Transition();
            Defaults.Persistent.Jq_6_1 = 1;
            yield return _gameMethods.OpenDialog(4071); // "午后，赫泽尔回来了。"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<from 0 to 2>audio/demo_audio/sound/zu3_nv_zou.ogg");
            if (Defaults.Bai_xiu == 1)
            {
                                yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/heilong_dating_bangwan_louti1.jpg");
                yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui9"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 2.71f)}, {"zoom", 0.55f}})});
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
                yield return _gameMethods.Transition();

            }
        }

        public IEnumerator label_zhuxian4_1()
        {
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 2>audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.EngineSetVolume(volume:1f, delay:2f, channelName:"music");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/woshi_men3.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}, {"pos", new Vector2(-72f, -6f)}, {"zoom", 1.1f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            yield return _gameMethods.StopEngineTime(time:0.4f);
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/hand_nv.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.45f, 1.25f)}})});
            yield return _gameMethods.Show("hand_biao_ani", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.43f, 1.1f)}})});
            yield return _gameMethods.Transition(time:0.5f);
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/demo_audio/sound/door_qiao1.mp3");
            yield return _gameMethods.OpenDialog(4072); // "我再次抱着枕头，来到赫泽尔的卧室门前。"
            Defaults.Persistent.Jq_6_3 = 1;
            yield return _gameMethods.OpenDialog(4073); // "如果记得没错，今天是赫泽尔会因为神圣血脉而感觉痛苦的时间。"
            yield return _gameMethods.PlaySound("sounda1", 0.0f, 1.0f, "audio/sound/door_open_3.mp3");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/woshi_he1_sky.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.29f, 1.29f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.61f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/woshi_he1.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.29f, 1.29f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.61f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei18", "yan22", "zui3", "emoji0", "emoji2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 2.81f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.58f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/woshi_men2.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.67f, 2.59f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 1.71f}})});
            yield return _gameMethods.Transition(time:0.8f);
            yield return _gameMethods.ExecuteCharacterImageData("he_qian");
            yield return _gameMethods.OpenDialog(4074); // "「……{nw}{w=0.3}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan3", "zui9", "-emoji0", "emoji2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_qian");
            yield return _gameMethods.OpenDialog(4075); // "是你。{nw}{w=0.1}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan15", "zui9", "emoji2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_qian");
            yield return _gameMethods.OpenDialog(4076); // "什么事？」"
            yield return _gameMethods.PlaySound("sound", 0.0f, 2f, "audio/sound/manbu/Body1_02_duan.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}, {"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.4f}, {"ypos", -24f}, {"zpos", -60f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan15", "zui2", "emoji2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui19", "emoji10"});
            yield return _gameMethods.OpenDialog(4077); // "当然是找你呀。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -24f}, {"zpos", -60f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan2", "zui2", "-emoji2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei1", "yan5", "zui12", "-emoji10"});
            yield return _gameMethods.OpenDialog(4078); // "今天是你会感到痛苦的日子吧。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
            yield return _gameMethods.OpenDialog(3391); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan2", "zui2"});
            Defaults.Haogandu_he = Defaults.Haogandu_he + 2;
            if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
            {
                                
                        _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
                        _gameMethods.SyncAchievement();

            }
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei1", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(4079); // "我们还是一起睡，好吗？我可以陪着你。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei1", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(4080); // "「……{nw}{w=0.6}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui19"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(4081); // "{nw}{w=0.25}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui20"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(4082); // "……嗯。」"
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/emeng_dajie/Lying Bed_01.mp3");
            yield return _gameMethods.Transition(time:0.5f);
            yield return _gameMethods.OpenDialog(4083); // "进了门后，我们没有多做交谈，钻进了柔软的被窝。"
            yield return _gameMethods.Scene("sleep2_layered", parts: new List<string>{"lv1", "lv2", "yan9", "zui5", "mei2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(0.5f, 1.04f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.53f}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.11f, saturationMatrix:1.29f, brightnessMatrix:-0.01f, hueMatrix:0.0f)}})});
            Defaults.Gui_duihuakuang_you = 0;
            yield return _gameMethods.Transition(time:0.4f);
            yield return _gameMethods.Show("sleep2_layered", parts: new List<string>{"s"});
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/houhui/Grab Hand_01.mp3");
            yield return _gameMethods.Transition(time:0.4f);
            yield return _gameMethods.OpenDialog(4084); // "刚刚躺稳，我就感到身侧的手被人抓住。"
            yield return _gameMethods.OpenDialog(4085); // "赫泽尔自然地将五指插进了我的指缝，动作顺理成章，宛若对此已经轻车熟路了。"
            yield return _gameMethods.OpenDialog(4086); // "我忍不住说。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan10", "zui19"});
            yield return _gameMethods.OpenDialog(4087); // "你好熟练啊。"
            yield return _gameMethods.Show("sleep2_layered", parts: new List<string>{"yan8"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan10", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice22_394b4940.ogg");
            yield return _gameMethods.OpenDialog(3540); // "？"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan6", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(4088); // "哈哈、没什么……"
            yield return _gameMethods.ShowBlack();
            yield return _gameMethods.Transition(time:0.4f);
            yield return _gameMethods.OpenDialog(3387); // "…………"
            yield return _gameMethods.HideBlack();
            yield return _gameMethods.Show("sleep2_layered", parts: new List<string>{"mei3", "yan11", "zui1", "emoji1", "emoji2"});
            yield return _gameMethods.Transition(time:0.4f);
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"yan6", "zui8", "emoji2"});
            yield return _gameMethods.OpenDialog(4089); // "聊了几句之后，{nw}{w=0.1}"
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:4f);
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.9f}, {"zpos", -36.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(4090); // "我注意到，赫泽尔的脸上再次浮现出隐忍的痛苦，仿佛血管里那些本不属于黑暗的部分,正在烧灼着他的神经。"
            yield return _gameMethods.EngineSetVolume(volume:0.5f, delay:3f, channelName:"soundf");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -36.0f}})});
            yield return _gameMethods.PlaySound("music1", 2f, 1.0f, "audio/music/One_spring_day.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(4091); // "真奇妙啊，如此强大的生物，也会遭受约束，忍耐苦楚吗。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(4092); // "……赫泽尔。"
            yield return _gameMethods.Show("sleep2_layered", parts: new List<string>{"yan8", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice25_07039449.ogg");
            yield return _gameMethods.OpenDialog(3579); // "嗯？"
            yield return _gameMethods.Show("sleep2_layered", parts: new List<string>{"zui4"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui10"});
            yield return _gameMethods.OpenDialog(4093); // "你上次说，只要再过两年，进入成长期，这种痛苦就会消失了，是吗？"
            yield return _gameMethods.Show("sleep2_layered", parts: new List<string>{"zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(4094); // "唔。"
            yield return _gameMethods.Show("sleep2_layered", parts: new List<string>{"zui4"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(4095); // "他点头。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(4096); // "也就是说，在此之前，他曾独自忍过了147个这样的夜晚。"
            yield return _gameMethods.Show("sleep2_layered", parts: new List<string>{"yan9", "zui5"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(4097); // "大概是因为他的外表实在太像个普通的人类男孩，我的心头五味陈杂。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(4098); // "……我忽然想到。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(4099); // "赫泽尔结束幼年期、进入成长期的阶段性节点，恰好位于预言里决战的时间点上。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(4100); // "那正是决定我未来之日。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(4101); // "从这个角度一想——我的人生，宛如他成长强大的仪式。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(3396); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(4102); // "忽然感觉自己真是太闲了，就像对着牛弹琴一样。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(4103); // "……我想听听看，这头牛是不是也有着同我一样的心脏与心跳。"
            yield return _gameMethods.PlaySound("sound", 0.2f, 0.4f, "audio/demo_audio/sound/moca2.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}, {"zpos", -36.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.5f}, {"ypos", -36f}, {"zpos", -90.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(4104); // "赫泽尔，我可以抱抱你吗？"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -36f}, {"zpos", -90.0f}})});
            yield return _gameMethods.Show("sleep2_layered", parts: new List<string>{"yan7"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(4105); // "他看向我，没有问为什么。"
            yield return _gameMethods.Show("sleep2_layered", parts: new List<string>{"zui2"});
            Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
            if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
            {
                                
                        _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
                        _gameMethods.SyncAchievement();

            }
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(4106); // "可以。"
            yield return _gameMethods.Show("sleep2_layered", parts: new List<string>{"zui4"});
            yield return _gameMethods.Scene("Assets/RenpyResources/images/cg/sleep3/sleep_yongbao.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.0f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.52f}})});
            yield return _gameMethods.Show("_zoom");
            yield return _gameMethods.Hide("_zoom");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/manbu/Body1_01.mp3");
            yield return _gameMethods.Transition(time:0.5f);
            yield return _gameMethods.OpenDialog(4107); // "我凑近他，双手搂住他。"
            yield return _gameMethods.OpenDialog(4108); // "他静静地任由我抱着，像一只疏远矜持的猫，永远不会主动贴近或讨好你些什么，只会偶尔纡尊降贵地收起利爪，允许你摸摸他的皮毛。"
            yield return _gameMethods.PlaySound("sounda1", 0.0f, 0.8f, "audio/sound/heartbeats_01.ogg");
            yield return _gameMethods.OpenDialog(4109); // "在这种近距离下，我很轻易地听到了他的心跳声。"
            yield return _gameMethods.OpenDialog(4110); // "他心脏的跳动比人类的更明亮有力，仅从声音判断，就知道那是一颗多么强大、充满能量的心脏。"
            yield return _gameMethods.OpenDialog(4111); // "如同一颗燃烧着的小小的太阳。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4112); // "你心跳的声音好响。"
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian4_1_7c1062fb_1.ogg");
            yield return _gameMethods.OpenDialog(3458); // "嗯。"
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(3396); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(4113); // "你的心跳很弱。像随时会熄灭一样。"
            yield return _gameMethods.OpenDialog(4114); // "……干什么突然这么说我啊。"
            yield return _gameMethods.OpenDialog(4115); // "我想了想。"
            yield return _gameMethods.OpenDialog(4116); // "也许这是一个机会，能让我更为贴近、更加准确地听寻一下，龙的心脏在哪个位置。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4117); // "那你要听听看吗？"
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(3892); // "什么。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4118); // "如果很弱的话，凑近一点听就能听清了吧。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4119); // "然后你要收回前言。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4120); // "而且，作为交换，你也要让我凑近听听你的心跳。"
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(4121); // "……好。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}, {"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 1f}, {"ypos", -66f}, {"zpos", -126.0f}})});
            yield return _gameMethods.OpenDialog(4122); // "我稍微换了个姿势，向上面移了移，方便他能听到我的心跳。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4123); // "听到了吗。"
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice22_23aaee87.ogg");
            yield return _gameMethods.OpenDialog(3458); // "嗯。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -66f}, {"zpos", -126.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(4124); // "……还是很弱。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(3396); // "……"
            yield return _gameMethods.OpenDialog(4125); // "你知道什么是善意的谎言吗。"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/manbu/Body1_01.mp3");
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition(time:0.5f);
            yield return _gameMethods.OpenDialog(4126); // "我一把推开他，往床上按去。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4127); // "轮到我了。让我听听。"
            yield return _gameMethods.Scene("Assets/RenpyResources/images/cg/sleep3/sleep_xintiao.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.0f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.52f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Show("_zoom");
            yield return _gameMethods.Hide("_zoom");
            yield return _gameMethods.Transition(time:0.5f);
            yield return _gameMethods.OpenDialog(4128); // "赫泽尔没有阻挠，仰躺在床上。"
            yield return _gameMethods.OpenDialog(4129); // "我支起身子，靠在他身边，把耳朵贴到他看起来仿佛很单薄的胸膛前。"
            yield return _gameMethods.PlaySound("soundd", 0.0f, 1.3f, "audio/sound/heartbeats_01.ogg");
            yield return _gameMethods.OpenDialog(4130); // "熔炉一样的心脏跳动着，把声音清楚地送进了我的耳内。"
            yield return _gameMethods.OpenDialog(4131); // "胸腔的第五根、到第七根肋骨之间。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(3396); // "……"
            yield return _gameMethods.PlaySound("soundc", 0.0f, 0.4f, "audio/demo_audio/sound/heart1.mp3");
            yield return _gameMethods.OpenDialog(4132); // "……？"
            yield return _gameMethods.OpenDialog(4133); // "有些不对。"
            yield return _gameMethods.OpenDialog(4134); // "我仔细分辨着，隐约感觉，那强烈的声音中，隐隐存在着一丝不和谐的因素。"
            if (Defaults.Bai_kiss == 0)
            {
                                yield return _gameMethods.ChangeLabelTo("label_heart_none");

            }
            if (Defaults.Bai_kiss == 1)
            {
                                yield return _gameMethods.ChangeLabelTo("label_heart_have");

            }
        }

        public IEnumerator label_heart_have()
        {
            yield return _gameMethods.OpenDialog(4135); // "仿佛在较响的那个声音之下，还夹杂着另一个微弱的声响，在轻轻地搏动着。"
            yield return _gameMethods.OpenDialog(4136); // "……难道有第二颗心脏？"
            yield return _gameMethods.OpenDialog(4137); // "我放缓呼吸，好奇地仔细捕捉那一声音的方位。"
            yield return _gameMethods.OpenDialog(4138); // "在……在、右侧？"
            yield return _gameMethods.OpenDialog(4139); // "是右侧吗？"
            yield return _gameMethods.OpenDialog(4140); // "……好迷茫，我开始怀疑起自己的耳朵，这种感觉就像回到了当年在考场上面对英语听力选择题时的纠结。"
            yield return _gameMethods.ChangeLabelTo("label_heart_over");
        }

        public IEnumerator label_heart_none()
        {
            yield return _gameMethods.OpenDialog(4141); // "是什么呢。"
            yield return _gameMethods.OpenDialog(4135); // "仿佛在较响的那个声音之下，还夹杂着另一个微弱的声响，在轻轻地搏动着。"
            yield return _gameMethods.OpenDialog(4142); // "……听不分明，更像是幻觉。"
            yield return _gameMethods.OpenDialog(3387); // "…………"
            yield return _gameMethods.OpenDialog(4143); // "是错觉吗？"
            yield return _gameMethods.ChangeLabelTo("label_heart_over");
        }

        public IEnumerator label_heart_over()
        {
            yield return _gameMethods.OpenDialog(4144); // "不过，已经听得够久了。再磨蹭下去，恐怕赫泽尔也会起疑。"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/manbu/Body1_01.mp3");
            yield return _gameMethods.StopSound(channelName:"soundd", fadeOut:2f);
            yield return _gameMethods.StopSound(channelName:"soundc", fadeOut:2f);
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:2f);
            yield return _gameMethods.SceneBlack();
            Defaults.Gui_duihuakuang_you = 1;
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(4145); // "我退开了身体。"
            yield return _gameMethods.OpenDialog(4146); // "这天，一直到最终沉入睡眠时，我都满腹思虑。"
            yield return _gameMethods.StopSound(channelName:"soundf", fadeOut:6f);
            yield return _gameMethods.StopSound(channelName:"music1", fadeOut:6f);
            if (Defaults.Bai_xue == 1)
            {
                                yield return _gameMethods.ChangeLabelTo("label_zhuxian5_bai");

            }
            if (Defaults.Bai_xue == 0)
            {
                                yield return _gameMethods.ChangeLabelTo("label_zhuxian5_he");

            }
        }
}