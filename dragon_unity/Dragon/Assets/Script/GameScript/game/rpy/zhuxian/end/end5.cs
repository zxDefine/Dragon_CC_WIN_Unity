    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class end5 : ILabelProvider
    {
        private GameMethods _gameMethods;

        public end5(GameMethods gameMethods)
        {
            _gameMethods = gameMethods;
        }

            public IEnumerator label_end5()
        {
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition(time:0.6f);
            if (Defaults.Wangzixian == 1)
            {
                                yield return _gameMethods.OpenDialog(4794); // "解决了王都的事端后，我把王位甩给了王子。/n开始了冒险。"

            }
            if (Defaults.Wangzixian == 0)
            {
                                yield return _gameMethods.OpenDialog(4795); // "解决了王都的事端后，我把王位甩给了公主。/n开始了冒险。"

            }
            yield return _gameMethods.OpenDialog(4796); // "为了收集妖精商人要求的物品，我、安德鲁、洛恩……还有一位尊贵的冰龙，一同踏上了旅途。"
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:5f);
            yield return _gameMethods.OpenDialog(4797); // "……"
            yield return _gameMethods.OpenDialog(4798); // "…………"
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/dajie4.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.44f, 1.11f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 1.23f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(330f, -84f)}, {"zpos", -342f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan2", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.75f, 2.0f)}, {"zoom", 0.32f}})});
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            yield return _gameMethods.PlaySound("music1", 0.0f, 0.6f, "audio/music/yongzhe_kaixin.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("an_qian");
            yield return _gameMethods.OpenDialog(4799); // "「…………所以说，{nw}{w=0.01}"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan21", "zui4"});
            yield return _gameMethods.ExecuteCharacterImageData("an_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end5_d1ceb092.ogg");
            yield return _gameMethods.OpenDialog(4800); // "为什么我们非得带上这个家伙不可啊。」"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan21", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui10", "d3"});
            yield return _gameMethods.OpenDialog(4801); // "因为我们还需要用到他的知识储备。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.5>audio/sound/jiaobusheng_nuo_normal1.ogg");
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui14"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.33f, 1.94f)}, {"zoom", 0.4f}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}, {"blur", 0.1f}, {"xoffset", -100f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.2f}, {"alpha", 1f}, {"blur", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.6f}, {"xoffset", 0f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ease", 0.6f}, {"xpos", 156f}})});
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end5_d07af76d.ogg");
            yield return _gameMethods.OpenDialog(4802); // "不是哦。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei5", "yan5", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(4803); // "「是因为，{nw}{w=0.01}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui16"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(4804); // "我和小公主有亲密的私人关系。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei8", "yan13", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(4797); // "……"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei10", "yan21", "zui16", "emoji6", "emoji18"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan10", "zui8", "emoji2"});
            yield return _gameMethods.OpenDialog(4805); // "就你长嘴了？"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui8", "emoji2"});
            yield return _gameMethods.OpenDialog(4806); // "能少说两句么。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan23", "zui1", "emoji6", "emoji18"});
            yield return _gameMethods.PlaySound("sounda", 0.0f, 4f, "audio/sound/manbu/Body1_02_duan.mp3");
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1>audio/sound/jiaobusheng_an_normal1.ogg");
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan8", "zui15"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.47f, 2.03f)}, {"zoom", 0.33f}})});
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.09f, 1.92f)}, {"zoom", 0.4f}})});
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui8"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(-18f, -60f)}, {"zpos", -318.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 1.5f}, {"zpos", -252.0f}})});
            yield return _gameMethods.Transition(time:0.5f);
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("luo_nv_qian");
            yield return _gameMethods.OpenDialog(4807); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("luo_nv");
            yield return _gameMethods.OpenDialog(4808); // "哦？能有多亲密？"
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan8", "zui8"});
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan13", "zui1", "-emoji6", "-emoji18"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei8", "yan5", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(4809); // "「公主殿下和我曾是盟友，{nw}{w=0.01}"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -252.0f}})});
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui14"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei8", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(4810); // "还诚恳地请求过我。」"
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/moca1.ogg");
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei8", "yan5", "zui1", "emoji8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"xoffset", -3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0f}})});
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei4", "yan1", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei3", "yan24", "zui16", "emoji2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end5_88e97c9c.ogg");
            yield return _gameMethods.OpenDialog(4811); // "……？！？！"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<from 0 to 0.5>audio/sound/jiaobusheng_an_normal1.ogg");
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei10", "yan17", "zui8", "emoji8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"xoffset", 0f}, {"yoffset", 0f}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"xoffset", -3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0f}})});
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei4", "yan8", "zui9", "emoji3", "emoji5"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end5_4eaf9038.ogg");
            yield return _gameMethods.OpenDialog(4812); // "你——……！"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei10", "yan17", "zui3", "emoji6", "emoji8", "-emoji8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.OpenDialog(4797); // "……"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(-180f, -84f)}, {"zpos", -252f}})});
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei2", "yan11", "zui12", "-emoji3", "-emoji5"});
            yield return _gameMethods.Transition(time:0.4f);
            yield return _gameMethods.ExecuteCharacterImageData("luo_nv");
            yield return _gameMethods.OpenDialog(4813); // "那她做这些，是为了从你身上得到什么？"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui12"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("luo_nv_qian");
            yield return _gameMethods.OpenDialog(4807); // "{nw}{w=0.15}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui12"});
            Engine._history = true;
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan5", "zui7"});
            yield return _gameMethods.ExecuteCharacterImageData("luo_nv_qian", parts: new List<string>{"mei3", "yan5", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(4814); // "「不管是什么，{nw}{w=0.3}"
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei8", "yan8", "zui12"});
            yield return _gameMethods.ExecuteCharacterImageData("luo_nv_qian");
            yield return _gameMethods.OpenDialog(4815); // "肯定不是爱。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei4", "yan11", "zui12"});
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei8", "yan8", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei8", "yan2", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(4797); // "……"
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei8", "yan11", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("luo_nv");
            yield return _gameMethods.OpenDialog(4797); // "……"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei4", "yan2", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.OpenDialog(4797); // "……"
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(4807); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(4797); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan24", "zui16", "emoji2"});
            yield return _gameMethods.OpenDialog(4816); // "总感觉气氛好诡异。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei4", "yan11", "zui8"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -252.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.76f}, {"zpos", -246.0f}})});
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei8", "yan8", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(4817); // "我开始保持安静，宛如一只缩起脖子的鹌鹑，尽力降低自己的存在感。"
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei8", "yan12", "zui1"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(4807); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei8", "yan2", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan24", "zui16", "emoji2"});
            yield return _gameMethods.OpenDialog(4818); // "洛恩却抬眸朝我看来。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan23", "zui2", "-emoji6", "-emoji8"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-180f, -84f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"pos", new Vector2(0f, -84f)}})});
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei3", "yan8", "zui4"});
            yield return _gameMethods.Transition(time:0.3f);
            yield return _gameMethods.ExecuteCharacterImageData("luo");
            yield return _gameMethods.OpenDialog(4819); // "有点厚此薄彼了呢，公主大人。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei4", "yan7", "zui9"});
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei3", "yan8", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(4797); // "……"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(0f, -84f)}})});
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan6", "zui16"});
            yield return _gameMethods.ExecuteCharacterImageData("luo_nv");
            yield return _gameMethods.OpenDialog(4820); // "我和安德鲁为了你打败许多竞争者，从王都出发。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui1"});
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan12", "zui7"});
            yield return _gameMethods.ExecuteCharacterImageData("luo_nv_qian");
            yield return _gameMethods.OpenDialog(4821); // "「一路奔波，训练了三年，{nw}{w=0.01}"
            yield return _gameMethods.ExecuteCharacterImageData("luo_nv_qian", parts: new List<string>{"mei1", "yan2", "zui16"});
            yield return _gameMethods.OpenDialog(4822); // "才来到你身边。」"
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei3", "yan8", "zui4"});
            yield return _gameMethods.ExecuteCharacterImageData("luo_nv");
            yield return _gameMethods.OpenDialog(4823); // "原来，连这个不知从哪里冒出的家伙还不如么？"
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.7f, "audio/demo_audio/sound/zhenjing_shuaidaoganjue.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan12", "zui1"});
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan8", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan10", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(4824); // "……不是，这个，那个。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei3", "yan10", "zui4"});
            yield return _gameMethods.ExecuteCharacterImageData("luo_nv", parts: new List<string>{"mei3", "yan10", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(4825); // "我知道你一定是受情势所迫，很辛苦了……"
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei3", "yan12", "zui4"});
            yield return _gameMethods.ExecuteCharacterImageData("luo_nv_qian");
            yield return _gameMethods.OpenDialog(4826); // "「不过，{nw}{w=0.3}"
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei3", "yan5", "zui6"});
            yield return _gameMethods.ExecuteCharacterImageData("luo_nv_qian");
            yield return _gameMethods.OpenDialog(4827); // "是不是也该给我们一点奖励呢。」"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(4798); // "…………"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan21", "zui1", "emoji8"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -246.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.43f}, {"zpos", -276.0f}})});
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei3", "yan5", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan12", "zui10", "emoji2"});
            yield return _gameMethods.OpenDialog(4828); // "那，那你想要什么……？"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan21", "zui1", "-emoji8"});
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei7", "yan8", "zui7"});
            yield return _gameMethods.ExecuteCharacterImageData("luo_nv", parts: new List<string>{"mei7", "yan12", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(4829); // "至少应该一视同仁不是么。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei10", "yan21", "zui16", "emoji6", "emoji8"});
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei7", "yan8", "zui1"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -276.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(4797); // "……"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei10", "yan2", "zui16", "-emoji6", "emoji8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan10", "zui7", "emoji2", "emoji6"});
            yield return _gameMethods.OpenDialog(4830); // "我不理解。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei5", "yan16", "zui1", "-emoji8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei1", "yan5", "zui10", "-emoji2", "-emoji6"});
            yield return _gameMethods.OpenDialog(4831); // "被咬脖子有什么好的？"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei1", "yan24", "zui10"});
            yield return _gameMethods.OpenDialog(4832); // "这有什么好的？"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei5", "yan8", "zui1"});
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei7", "yan2", "zui16"});
            yield return _gameMethods.ExecuteCharacterImageData("luo_nv", parts: new List<string>{"mei1", "yan24", "zui15"});
            yield return _gameMethods.OpenDialog(4833); // "那要看怎么求我了。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.5f, "<from 0 to 1>audio/sound/jiaobusheng_an_normal1.ogg");
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan11", "zui12"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 1f}, {"zpos", 12.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("luo_nv", parts: new List<string>{"mei8", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(4834); // "你会对我诚恳一点的对吧？"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui13"});
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan5", "zui9"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.42f}, {"xpos", -186f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei8", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(4835); // "「难说，{nw}{w=0.01}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(4836); // "她可是让我都害羞了，{nw}{w=0.01}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui16"});
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei2", "yan1", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(4837); // "让我心都酸了。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei5", "yan8", "zui8", "emoji3"});
            yield return _gameMethods.ExecuteCharacterImageData("luo_nv", parts: new List<string>{"mei5", "yan22", "zui13", "emoji2", "emoji6"});
            yield return _gameMethods.OpenDialog(4797); // "……"
            yield return _gameMethods.Show("luo2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 12.0f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", -186f}})});
            yield return _gameMethods.PlaySound("sounda", 0.0f, 0.7f, "audio/sound/juezhan2/Magical Blast_01.ogg");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan22", "zui13", "emoji2", "emoji6"});
            yield return _gameMethods.OpenDialog(4838); // "洛恩的背后在一瞬间冒出黑气。"
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei5", "yan11", "zui12", "emoji3", "emoji4", "emoji5"});
            yield return _gameMethods.ExecuteCharacterImageData("luo_nv");
            yield return _gameMethods.OpenDialog(4839); // "求我啊，还要四遍。"
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei5", "yan11", "zui9", "emoji3", "emoji4", "emoji5"});
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/moca1.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei5", "yan12", "zui19", "emoji2", "emoji5", "emoji6"});
            yield return _gameMethods.OpenDialog(4840); // "……求求你求求你！"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei5", "yan8", "zui3", "emoji3", "emoji4", "emoji5"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei4", "yan10", "zui2", "emoji2", "-emoji5", "-emoji6"});
            yield return _gameMethods.OpenDialog(4841); // "所以这到底有什么好争的啊……？！"
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei2", "yan5", "zui4", "-emoji3", "-emoji4", "-emoji5"});
            yield return _gameMethods.ExecuteCharacterImageData("luo_nv", parts: new List<string>{"mei4", "yan10", "zui8", "-emoji2"});
            yield return _gameMethods.OpenDialog(4842); // "我只是要拿走自己本该得到的利益罢了。"
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei2", "yan8", "zui7"});
            yield return _gameMethods.ExecuteCharacterImageData("luo_nv");
            yield return _gameMethods.OpenDialog(4843); // "还有一遍。"
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei2", "yan8", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui10", "emoji2"});
            yield return _gameMethods.OpenDialog(4844); // "「这算哪门子的利益啦……{nw}{w=0.2}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan10", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(4845); // "还有光天化日之下我们真的要讨论这个话题吗？」"
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "<from 0 to 1.5>audio/sound/jiaobusheng_nuo_normal1.ogg");
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui13"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 1f}, {"zpos", 12.0f}})});
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei2", "yan2", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan10", "zui7", "emoji2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end5_a53ce5c8.ogg");
            yield return _gameMethods.OpenDialog(4846); // "没关系的，小公主。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui16"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end5_f8332986.ogg");
            yield return _gameMethods.OpenDialog(4847); // "接下来的旅途中，我帮你都不需要额外的报偿。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui4"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 12.0f}})});
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei4", "yan8", "zui8", "emoji5"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei7", "yan5", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(4848); // "「毕竟，和别人不同，{nw}{w=0.01}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end5_cdcb1fff.ogg");
            yield return _gameMethods.OpenDialog(4849); // "我只是单纯地希望讨你欢心而已。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan11", "zui12", "-emoji5"});
            yield return _gameMethods.ExecuteCharacterImageData("luo_nv_qian");
            yield return _gameMethods.OpenDialog(4850); // "「不好意思，我不够大度，{nw}{w=0.3}"
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei4", "yan8", "zui15"});
            yield return _gameMethods.ExecuteCharacterImageData("luo_nv_qian");
            yield return _gameMethods.OpenDialog(4851); // "只会狭恩图报。」"
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei4", "yan8", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan24", "zui16", "emoji2"});
            yield return _gameMethods.OpenDialog(4797); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui16", "emoji2"});
            yield return _gameMethods.OpenDialog(4852); // "脑壳好痛……"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(4853); // "这个我们之后再讲好么？"
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei4", "yan9", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan22", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(4854); // "拜托了，路人都已经看过来了啊！！"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan7", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(4855); // "无奈之下，我求助于身边唯一看起来还算情绪稳定的人。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan23", "zui1"});
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.Hide("luo2");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(324f, -108f)}, {"zpos", -396.0f}})});
            yield return _gameMethods.TransitionBy("blink2");
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei1", "yan5", "zui11", "-emoji2"});
            yield return _gameMethods.OpenDialog(4856); // "「安德鲁……"
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.2f, "audio/sound/moca1.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei1", "yan11", "zui13", "emoji2"});
            yield return _gameMethods.OpenDialog(4857); // "安德鲁你说句话啊！」"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui12", "emoji2"});
            yield return _gameMethods.OpenDialog(4858); // "快劝劝他们。"
            yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei7", "yan2", "zui18", "emoji2"});
            yield return _gameMethods.OpenDialog(4797); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui18", "-emoji2"});
            yield return _gameMethods.OpenDialog(4859); // "安德鲁正微微垂头，视线落在一旁的地面，似乎在思忖着什么。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan12", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(4860); // "闻言，他望向我。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei5", "yan16", "zui5"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end5_35260fbe.ogg");
            yield return _gameMethods.OpenDialog(4861); // "头疼了？"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei5", "yan16", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(4862); // "他微微挑眉，{nw}{w=0.4}"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan20", "zui16"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(4863); // "冷笑一声。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan17", "zui12"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv");
            yield return _gameMethods.OpenDialog(4864); // "活该。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei10", "yan2", "zui12"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv");
            yield return _gameMethods.OpenDialog(4865); // "谁让你在外面惹来麻烦。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan19", "zui16", "emoji6"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan24", "zui17", "emoji2"});
            yield return _gameMethods.OpenDialog(4866); // "……我也是为了夹缝求生嘛。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei5", "yan8", "zui1", "-emoji6"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
            yield return _gameMethods.OpenDialog(4867); // "「……{nw}{w=0.3}"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei5", "yan12", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
            yield return _gameMethods.OpenDialog(4868); // "……」"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan23", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei7", "yan24", "zui15", "-emoji2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end5_bb1998ea.ogg");
            yield return _gameMethods.OpenDialog(4869); // "我知道。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan23", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(4870); // "他放缓了声音。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui1"});
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.2f, "audio/demo_audio/sound/moca6_duan.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"ypos", -126f}, {"zpos", -456.0f}})});
            yield return _gameMethods.TransitionBy("blink2");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(4871); // "安德鲁揉了揉我的头顶，不经意般的、大大咧咧地开口。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei8", "yan2", "zui12"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv");
            yield return _gameMethods.OpenDialog(4872); // "好了，不需要什么奖励。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan12", "zui12"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end5_4a3c983f.ogg");
            yield return _gameMethods.OpenDialog(4873); // "现在还能一起站在这里聊天，就足够了。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan13", "zui6"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end5_e2734892.ogg");
            yield return _gameMethods.OpenDialog(4874); // "至于洛恩，之后我和他聊聊。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan13", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan5", "zui15", "emoji8"});
            yield return _gameMethods.OpenDialog(4875); // "我感动不已。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.5>audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -456.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.25f}, {"zpos", -462.0f}})});
            Defaults.Haogandu_an = Defaults.Haogandu_an + 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei2", "yan5", "zui10", "emoji7", "-emoji8"});
            yield return _gameMethods.OpenDialog(4876); // "你真好。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan16", "zui13", "emoji4", "emoji20"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei2", "yan5", "zui15", "emoji7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end5_ed487ab3.ogg");
            yield return _gameMethods.OpenDialog(4877); // "你少来。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei5", "yan16", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei2", "yan5", "zui15", "-emoji7"});
            yield return _gameMethods.OpenDialog(4797); // "……"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei5", "yan17", "zui5", "-emoji4", "-emoji20"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -462.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end5_6ca01ec4.ogg");
            yield return _gameMethods.OpenDialog(4878); // "不过——……"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan2", "zui6"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian", parts: new List<string>{"mei8", "yan2", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end5_6b9eb7ff.ogg");
            yield return _gameMethods.OpenDialog(4879); // "「你和那个白色的家伙之间发生了什么，{nw}{w=0.01}"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan12", "zui12"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
            yield return _gameMethods.OpenDialog(4880); // "{nw}{w=0.7}"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei10", "yan3", "zui12", "emoji18"});
            yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end5_d14ed7e2.ogg");
            yield return _gameMethods.OpenDialog(4881); // "之后最好和我好·好·解释一下。」"
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.5f, "<from 0 to 0.4>audio/sound/jiaobusheng_xin_man1.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -462.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"zpos", -456.0f}})});
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei10", "yan3", "zui10", "emoji18"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan24", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(4882); // "「……好的……{nw}{w=0.01}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan24", "zui7", "-emoji2"});
            yield return _gameMethods.OpenDialog(4883); // "」"
            yield return _gameMethods.StopSound(channelName:"music1", fadeOut:4f);
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition(time:0.4f);
            yield return _gameMethods.OpenDialog(4798); // "…………"
            yield return _gameMethods.PlaySound("soundb", 1f, 1.0f, "audio/demo_audio/sound/chong1.ogg");
            yield return _gameMethods.OpenDialog(4884); // "在镇上补充好物资之后，我们找了家旅馆入住，决定好好休息一夜，第二天一早再出发。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg42_memory.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg42_memory.jpg");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/end_lvguan1.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 0.5f)}, {"pos", new Vector2(0.5f, 0.5f)}, {"zoom", 0.78f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 125.0f}})});
            yield return _gameMethods.Transition(time:0.4f);
            yield return _gameMethods.OpenDialog(4885); // "夜幕降临，我们围成一桌，讨论之后的行程规划。"
            yield return _gameMethods.PlaySound("music", 1f, 0.5f, "audio/music/end/end_siren.mp3");
            yield return _gameMethods.OpenDialog(4886); // "差不多感到倦了，我打了个哈欠。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.8f, "<from 0 to 0.5>audio/sound/jiaobusheng_an_normal1.ogg");
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui4", "-emoji18"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.50f, 2.54f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.42f}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}, {"blur", 0.01f}, {"xoffset", 50f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.8f}, {"alpha", 1f}, {"blur", 0f}, {"xoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("an");
            yield return _gameMethods.OpenDialog(4887); // "困了？"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan2", "zui5"});
            yield return _gameMethods.ExecuteCharacterImageData("an");
            yield return _gameMethods.OpenDialog(4888); // "困了就去睡吧。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui4"});
            yield return _gameMethods.ExecuteCharacterImageData("an");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end5_3bd251e3.ogg");
            yield return _gameMethods.OpenDialog(4889); // "明早我去敲门叫你。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}, {"blur", 0f}, {"xoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan21", "zui10", "d3"});
            yield return _gameMethods.OpenDialog(4890); // "唔……好……"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 0.5f, "<from 0 to 1.5>audio/sound/jiaobusheng_nuo_normal1.ogg");
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(-762f, -66f)}, {"anchor", new Vector2(0f, 0f)}, {"zoom", 0.55f}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}, {"blur", 0.01f}, {"xoffset", -50f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 1f}, {"alpha", 1f}, {"blur", 0f}, {"xoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei2", "yan12", "zui12"});
            yield return _gameMethods.OpenDialog(4891); // "晚安，小公主。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui14"});
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan13", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei8", "yan21", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end5_5bde56a7.ogg");
            yield return _gameMethods.OpenDialog(4892); // "需要陪伴可以呼唤我。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}, {"blur", 0f}, {"xoffset", 0f}})});
            yield return _gameMethods.PlaySound("sounda1", 0.0f, 0.4f, "<from 0 to 1>audio/sound/jiaobusheng_an_normal1.ogg");
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan2", "zui6"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0f, 0f)}, {"zoom", 0.42f}, {"pos", new Vector2(528f, -48f)}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}, {"blur", 0.01f}, {"xoffset", 50f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 1f}, {"alpha", 1f}, {"blur", 0f}, {"xoffset", 0f}})});
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan21", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("luo_nv", parts: new List<string>{"mei8", "yan10", "zui15"});
            yield return _gameMethods.OpenDialog(4893); // "好好休息。"
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei2", "yan9", "zui7"});
            yield return _gameMethods.ExecuteCharacterImageData("luo_nv_qian");
            yield return _gameMethods.OpenDialog(4894); // "「如果某个肆意妄为的家伙去打扰你，{nw}{w=0.3}"
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei2", "yan12", "zui7"});
            yield return _gameMethods.ExecuteCharacterImageData("luo_nv_qian");
            yield return _gameMethods.OpenDialog(4895); // "别搭理他。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan8", "zui5"});
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei2", "yan9", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end5_49fa9502.ogg");
            yield return _gameMethods.OpenDialog(4896); // "嗯，这是在说谁呢？"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan8", "zui9"});
            yield return _gameMethods.Show("luo2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}, {"blur", 0f}, {"xoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan24", "zui10"});
            yield return _gameMethods.OpenDialog(4897); // "……晚安。"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<from 0 to 1>audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg41_memory.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg41_memory.jpg");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/end_lvguan2.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.32f)}, {"anchor", new Vector2(0.5f, 1.0f)}})});
            yield return _gameMethods.TransitionBy("blink2");
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.5f, "audio/sound/door_open_1.mp3");
            yield return _gameMethods.OpenDialog(4898); // "………………"
            yield return _gameMethods.PlaySound("sounda1", 0.0f, 1.0f, "audio/sound/emeng_dajie/Lying Bed_01.mp3");
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:6f);
            yield return _gameMethods.EngineSetVolume(volume:1f, delay:0.5f, channelName:"soundb");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/tiankong_yewan.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.38f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 1.3f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.TransitionBy("blink2");
            yield return _gameMethods.OpenDialog(4899); // "我躺在床上，望着床边窗外浩渺的夜空，睡意爬上眼皮，意识渐渐朦胧。"
            yield return _gameMethods.OpenDialog(4798); // "…………"
            yield return _gameMethods.OpenDialog(4898); // "………………"
            yield return _gameMethods.PlaySound("music1", 0.0f, 1.0f, "audio/music/end/star_looperman_01.mp3");
            yield return _gameMethods.OpenDialog(4900); // "忽然间，心神一动。"
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/end_lvguan2.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.32f)}, {"anchor", new Vector2(0.5f, 1.0f)}})});
            yield return _gameMethods.TransitionBy("blink2");
            yield return _gameMethods.OpenDialog(4901); // "……有种奇怪的感觉。仿佛此刻，我并非孤身一人。"
            yield return _gameMethods.SetDialogUIShowOrHide("hide");
            yield return _gameMethods.Show("Assets/RenpyResources/images/texiao/huiyi_biankuang.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.90f}, {"xpos", -282f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.19f}, {"xpos", -282f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 1.35f}, {"xpos", 300f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.36f}, {"xpos", 300f}}), new SameLineParamData(new Dictionary<string, object>{{"easeOut", 0.84f}, {"xpos", 0f}})});
            yield return _gameMethods.StopEngineTime(time:3.74f);
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}})});
            yield return _gameMethods.Hide("Assets/RenpyResources/images/texiao/huiyi_biankuang.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.SetDialogUIShowOrHide("show");
            yield return _gameMethods.OpenDialog(4902); // "环视周围，无人存在。"
            Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
            if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
            {
                                
                        _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
                        _gameMethods.SyncAchievement();

            }
            if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
            {
                                
                        _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
                        _gameMethods.SyncAchievement();

            }
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan6", "zui10", "d3"});
            yield return _gameMethods.OpenDialog(4903); // "……诺伯拉？"
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_weizhi", parts: new List<string>{"mei8", "yan6", "zui15"});
            yield return _gameMethods.OpenDialog(4797); // "……"
            yield return _gameMethods.StopSound(channelName:"music1", fadeOut:2f);
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_weizhi");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end5_06f05db1.ogg");
            yield return _gameMethods.OpenDialog(4904); // "哎呀，察觉到我了么。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan5", "zui10"});
            yield return _gameMethods.OpenDialog(4905); // "……嗯。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(4906); // "这点感知还是有的。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan7", "zui10"});
            yield return _gameMethods.OpenDialog(4907); // "大概……"
            Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
            if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
            {
                                
                        _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
                        _gameMethods.SyncAchievement();

            }
            if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
            {
                                
                        _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
                        _gameMethods.SyncAchievement();

            }
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan12", "zui10"});
            yield return _gameMethods.OpenDialog(4908); // "就像你说的，也已经朝夕相处一年了嘛。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/emeng_dajie/magic1.ogg");
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"lv1", "mei7", "yan11", "zui13"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.34f, 2.09f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.43f}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}, {"blur", 0.01f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1f}, {"blur", 0f}})});
            yield return _gameMethods.PlaySound("sounda", 0.0f, 0.5f, "<from 0 to 0.5>audio/sound/jiaobusheng_nuo_normal1.ogg");
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei8", "yan9", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end5_db4530ff.ogg");
            yield return _gameMethods.OpenDialog(4909); // "呵呵……这样啊。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui16"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}, {"blur", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei8", "yan5", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end5_561f9504.ogg");
            yield return _gameMethods.OpenDialog(4910); // "你看起来并不惊讶我的出现。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
            if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
            {
                                
                        _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
                        _gameMethods.SyncAchievement();

            }
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan10", "zui19"});
            yield return _gameMethods.OpenDialog(4911); // "毕竟如果不闹出点什么惊吓，也就不是你了。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui14"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei8", "yan10", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end5_ccc444bb.ogg");
            yield return _gameMethods.OpenDialog(4912); // "真了解我啊。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(4797); // "……"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.OpenDialog(4797); // "……"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.63f}, {"zpos", -30.0f}})});
            Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
            if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
            {
                                
                        _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
                        _gameMethods.SyncAchievement();

            }
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan5", "zui19"});
            yield return _gameMethods.OpenDialog(4913); // "……你有话要对我说吗？"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui6"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei8", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(4914); // "为什么这么问。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -30.0f}})});
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(4915); // "只是感觉。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan6", "zui15"});
            yield return _gameMethods.OpenDialog(4916); // "他虽然随心所欲，但也会掌握分寸，很少无缘无故半夜骚扰。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui16"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(4917); // "「好吧。也许……{nw}{w=0.01}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui14"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(4918); // "是有点嫉妒。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui8"});
            yield return _gameMethods.PlaySound("music", 0.0f, 0.5f, "audio/music/bing_jiesi.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan2", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(4919); // "？"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui15", "emoji2", "emoji12"});
            yield return _gameMethods.OpenDialog(4920); // "啊？"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(4921); // "「他们两个都和你拥有深厚的羁绊，{nw}{w=0.01}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei6", "yan19", "zui14"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end5_cfdef9dc.ogg");
            yield return _gameMethods.OpenDialog(4922); // "只有我举目无亲，{nw}{w=0.01}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei5", "yan11", "zui5"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end5_186d1cf4.ogg");
            yield return _gameMethods.OpenDialog(4923); // "被你们排挤在外。好寂寞啊。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan24", "zui19", "emoji2", "-emoji12"});
            yield return _gameMethods.OpenDialog(4924); // "……是吗。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan24", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(4925); // "真是令人震撼的言论……"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui6"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(4926); // "「如果不好好安抚我的话，{nw}{w=0.01}"
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.7f, "<from 0 to 1.5>audio/sound/jiaobusheng_nuo_normal1.ogg");
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"lv1", "mei7", "yan7", "zui5"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 1f}, {"zpos", 42.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end5_05552258.ogg");
            yield return _gameMethods.OpenDialog(4927); // "我说不定会因为过于嫉妒，而走入极端，{nw}{w=0.01}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui14"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(4928); // "做些什么哦？」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan12", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(4929); // "嗯嗯好，你会做些什么呢。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"lv1", "mei7", "yan13", "zui16"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 42.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei3", "yan12", "zui8", "-emoji2"});
            yield return _gameMethods.OpenDialog(4930); // "「嗯……比如说，{nw}{w=0.01}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(4931); // "哪怕是下定决心。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(4932); // "「彻底离开你们，让你们没法找到秘宝，{nw}{w=0.01}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui14"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(4933); // "让你的朋友永远无法幸福？」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan22", "zui10", "emoji2", "emoji5"});
            yield return _gameMethods.OpenDialog(4797); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan22", "zui19", "emoji2", "emoji5", "emoji6"});
            yield return _gameMethods.OpenDialog(4934); // "威胁。{size=+10}这是在威胁我！{/size}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan12", "zui13", "emoji2", "emoji5", "emoji6"});
            yield return _gameMethods.OpenDialog(4935); // "太糟糕了啊这条龙。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan24", "zui19", "emoji2", "emoji6", "-emoji5"});
            yield return _gameMethods.OpenDialog(4936); // "这句话里的槽点太多了，竟然让我一时不知该从何吐起……"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui8"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
            yield return _gameMethods.OpenDialog(4807); // "{nw}{w=0.15}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan5", "zui10", "-emoji2", "-emoji6"});
            yield return _gameMethods.OpenDialog(4937); // "不过，你不像是会做出这种决绝行为的类型呢。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan6", "zui10"});
            yield return _gameMethods.OpenDialog(4938); // "我的意思是，感觉你该会用更巧妙、有艺术性的方法达成目的才对。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei4", "yan1", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei8", "yan6", "zui15"});
            yield return _gameMethods.OpenDialog(4939); // "「这可说不定，{nw}{w=0.01}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei4", "yan11", "zui16"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei8", "yan5", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end5_5dfc77d4.ogg");
            yield return _gameMethods.OpenDialog(4940); // "毕竟你都让我变得那么喜欢你了。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei4", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan12", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(4941); // "好好好，我的错。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan24", "zui8", "emoji2"});
            yield return _gameMethods.OpenDialog(4942); // "好怀疑啊。真的有那么喜欢吗。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.OpenDialog(4797); // "……"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui16"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end5_4d4a9157.ogg");
            yield return _gameMethods.OpenDialog(4943); // "嗯——不过，如你所言那样的办法，也有呢。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei8", "yan2", "zui15", "-emoji2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end5_85c3465e.ogg");
            yield return _gameMethods.OpenDialog(4944); // "而且，可钻的空隙相当明显。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan5", "zui10"});
            yield return _gameMethods.OpenDialog(4945); // "……比如？"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei8", "yan5", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end5_8e0c2c7d.ogg");
            yield return _gameMethods.OpenDialog(4946); // "你们三个之间，也并不是铁板一块吧。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(4807); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(4947); // "……？"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui16"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end5_07ab631c.ogg");
            yield return _gameMethods.OpenDialog(4948); // "没发现么。你和其中一人的关系太好了。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui16"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei8", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(4949); // "「三人之间的情谊，{nw}{w=0.01}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui14"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end5_ff302f90.ogg");
            yield return _gameMethods.OpenDialog(4950); // "总会存在一个家伙，{nw}{w=0.01}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end5_abe1b33a.ogg");
            yield return _gameMethods.OpenDialog(4951); // "怀有无法插入另外两人的不安感。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei9", "yan14", "zui16"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(4952); // "「只要简单地施以影响，就很容易让他误入歧途，{nw}{w=0.01}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui16"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end5_065702c7.ogg");
            yield return _gameMethods.OpenDialog(4953); // "不顾一切地毁掉所有东西吧。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(4954); // "「到那时，你旧有的关系被摧毁，{nw}{w=0.01}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui14"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(4955); // "我就可以趁虚而入了。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(4807); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(4797); // "……"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan10", "zui16", "emoji2"});
            yield return _gameMethods.OpenDialog(4956); // "好恶毒的男人。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "<from 0 to 0.5>audio/sound/jiaobusheng_nuo_normal1.ogg");
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"lv1", "mei7", "yan11", "zui13"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 42.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.8f}, {"zpos", 60.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end5_e6b82beb.ogg");
            yield return _gameMethods.OpenDialog(4957); // "害怕我了？"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan12", "zui10", "-emoji2"});
            yield return _gameMethods.OpenDialog(4958); // "不。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"lv1", "mei7", "yan7", "zui9"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 60.0f}})});
            Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 2;
            if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
            {
                                
                        _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
                        _gameMethods.SyncAchievement();

            }
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui10"});
            yield return _gameMethods.OpenDialog(4959); // "既然都已经说出来了，就表明你不会实施吧。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui9"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(4807); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(4797); // "……"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui16"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.OpenDialog(4960); // "因为我在刚刚的斗争中，赢了呢。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end5_3573e828.ogg");
            yield return _gameMethods.OpenDialog(4961); // "不想看到你痛苦的念头居然占据了上风。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui10"});
            yield return _gameMethods.OpenDialog(4962); // "竟然。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(4963); // "那看来，你比想象中更喜欢我呢。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan5", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end5_d9b02b44.ogg");
            yield return _gameMethods.OpenDialog(4964); // "也许哦。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan12", "zui19"});
            yield return _gameMethods.OpenDialog(4965); // "好——加分。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan5", "zui19", "emoji7"});
            yield return _gameMethods.OpenDialog(4966); // "对诺伯拉·博尔吉亚的好感度提升了。"
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:6f);
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui5"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei3", "yan5", "zui8", "emoji7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end5_0d45445a.ogg");
            yield return _gameMethods.OpenDialog(4967); // "好感度？"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei4", "yan9", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei8", "yan2", "zui7", "-emoji7"});
            yield return _gameMethods.OpenDialog(4797); // "……"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui5"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end5_0bb66597.ogg");
            yield return _gameMethods.OpenDialog(4968); // "——那么，现在对我共计有多少呢？"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan6", "zui11"});
            yield return _gameMethods.OpenDialog(4969); // "现在嘛……"
            yield return _gameMethods.OpenSelectMenu(screen:"choice2", talk: new List<string>{"-零", "-大概一到三十点？", "-三十到五十之间吧", "-也许是五十到八十那么多", "-可能在八十到九十九点呢", "-一百点"}, jump: new List<string>{"label_end5_menu_0_p3A6cVRF", "label_end5_menu_0_Pcj7Z1Sp", "label_end5_menu_0_x1vkdZEr", "label_end5_menu_0_0Q5klCm0", "label_end5_menu_0_iZ0wGrLd", "label_end5_menu_0_1MiuAE6D"}, condition: new List<string>{"NONE", "NONE", "NONE", "NONE", "NONE", "NONE"});
        }

        public IEnumerator label_end3_1_tuan5_1()
        {
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei4", "yan11", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(4797); // "……"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei4", "yan11", "zui16"});
            yield return _gameMethods.PlaySound("music1", 0.0f, 0.5f, "audio/music/bing_xia.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.OpenDialog(4970); // "真的么？这个数字？"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei4", "yan1", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.OpenDialog(4971); // "即便是我也会伤心的哦。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei4", "yan11", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.OpenDialog(4972); // "该不会最开始是负的吧？"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei4", "yan11", "zui8"});
            yield return _gameMethods.ChangeLabelTo("label_end3_1_tuan6");
        }

        public IEnumerator label_end3_1_tuan5_2()
        {
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei6", "yan11", "zui5"});
            yield return _gameMethods.PlaySound("music1", 0.0f, 0.9f, "audio/music/bing_richang1.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(4973); // "唉？只有这么一点？"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui6"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(4974); // "「真不公平。{nw}{w=0.01}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui6"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(4975); // "明明我对你的一定远远超过了这个数字呢。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui9"});
            yield return _gameMethods.ChangeLabelTo("label_end3_1_tuan6");
        }

        public IEnumerator label_end3_1_tuan5_3()
        {
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei4", "yan13", "zui5"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(4976); // "嗯——有点少啊。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui6"});
            yield return _gameMethods.PlaySound("music1", 0.0f, 0.5f, "audio/music/bing_xia.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.OpenDialog(4977); // "嘛不过，也是意料之中呢。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.OpenDialog(4978); // "你看起来就是一幅不太信任我的样子。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
            yield return _gameMethods.ChangeLabelTo("label_end3_1_tuan6");
        }

        public IEnumerator label_end3_1_tuan5_4()
        {
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui9"});
            yield return _gameMethods.PlaySound("music1", 0.0f, 1.0f, "audio/music/host_clean.mp3");
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(4807); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui5"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(4979); // "哦呀，有这么多？"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(4980); // "「看来，{nw}{w=0.01}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui14"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(4981); // "你也比表现出来的更喜欢我呢。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.ChangeLabelTo("label_end3_1_tuan6");
        }

        public IEnumerator label_end3_1_tuan5_5()
        {
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei4", "yan4", "zui4"});
            yield return _gameMethods.PlaySound("music1", 0.0f, 1.0f, "audio/music/host_clean.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(4982); // "……呜哇~这么多么？"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei4", "yan2", "zui14"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.OpenDialog(4983); // "即便是我也有点开心了。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei4", "yan11", "zui16"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.OpenDialog(4984); // "呵呵，这场剧目中，我该不会是你最偏爱的那个角色吧？"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei4", "yan11", "zui8"});
            yield return _gameMethods.ChangeLabelTo("label_end3_1_tuan6");
        }

        public IEnumerator label_end3_1_tuan5_6()
        {
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui9"});
            yield return _gameMethods.PlaySound("music1", 0.0f, 1.0f, "audio/music/gentle1.mp3");
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei7", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(4807); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan4", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.OpenDialog(4797); // "……"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan4", "zui5"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.OpenDialog(4985); // "这还真是吓到我了。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui6"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.OpenDialog(4986); // "生平第一次体会到“受宠若惊”是什么感觉呢。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui14"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.OpenDialog(4987); // "……我说，这该不会是变相的表白吧？"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.OpenDialog(4988); // "说出这个回答，你已经做好相应的准备了么？"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.ChangeLabelTo("label_end3_1_tuan6");
        }

        public IEnumerator label_end3_1_tuan6()
        {
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan6", "zui19"});
            yield return _gameMethods.OpenDialog(4989); // "嗯——……"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}, {"zpos", -30.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.36f}, {"ypos", -30f}, {"zpos", -54.0f}})});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.5>audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
            yield return _gameMethods.OpenDialog(4990); // "「这到底是不是真的呢，{nw}{w=0.01}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(4991); // "你猜？」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei8", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(4797); // "……"
            yield return _gameMethods.StopSound(channelName:"music1", fadeOut:5f);
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui6"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -30f}, {"zpos", -54.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(4992); // "「唉，{nw}{w=0.01}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(4993); // "真是被你彻底抓住了把柄。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan12", "zui19"});
            yield return _gameMethods.OpenDialog(4994); // "既然那么喜欢我，就温柔一点地呵护我吧。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui14"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(4995); // "好吧~"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui13"});
            yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/music/end/end_baiyin01.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.OpenDialog(4996); // "当然，我会的。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui12"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(4807); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end3_1_tuan6_dd1ffd3d.ogg");
            yield return _gameMethods.OpenDialog(4997); // "——不过，公主殿下。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui16"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(4998); // "「可不可以，给我一点鼓励，{nw}{w=0.01}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end3_1_tuan6_b0332336.ogg");
            yield return _gameMethods.OpenDialog(4999); // "好让我能继续坚持下去？」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui16"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(5000); // "「毕竟，{nw}{w=0.01}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei6", "yan11", "zui4"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(5001); // "我忍得真的很辛苦哦。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei6", "yan11", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan5", "zui10"});
            yield return _gameMethods.OpenDialog(5002); // "……你想要什么呢？"
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.5f, "<from 0 to 1.5>audio/sound/jiaobusheng_nuo_normal1.ogg");
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"lv1", "mei7", "yan13", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 60.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 1.2f}, {"zpos", 90.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei8", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(5003); // "「嗯——{nw}{w=0.01}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui14"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end3_1_tuan6_a30eb6d7.ogg");
            yield return _gameMethods.OpenDialog(4991); // "你猜？」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan10", "zui8", "emoji2"});
            yield return _gameMethods.OpenDialog(4797); // "……"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui14"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end3_1_tuan6_b04175ea.ogg");
            yield return _gameMethods.OpenDialog(5004); // "你来想吧。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end3_1_tuan6_8fe18952.ogg");
            yield return _gameMethods.OpenDialog(5005); // "一直挂念着我吧。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"lv1", "mei7", "yan11", "zui14"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 90.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei8", "yan5", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(5006); // "我期待着，你给的惊喜。"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 2f, "audio/sound/manbu/Body1_02_duan.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -54.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.7f}, {"zpos", -30.0f}})});
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(5007); // "……好啦，我会仔细想一想的。"
            Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
            if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
            {
                                
                        _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
                        _gameMethods.SyncAchievement();

            }
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan5", "zui2"});
            yield return _gameMethods.OpenDialog(5008); // "毕竟要负起责任来，哄好你呢。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui16"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -30.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei8", "yan5", "zui8"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end3_1_tuan6_e65765c2.ogg");
            yield return _gameMethods.OpenDialog(5009); // "呵呵……"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end3_1_tuan6_a09a8fec.ogg");
            yield return _gameMethods.OpenDialog(5010); // "真奇怪。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui16"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.OpenDialog(5011); // "仅仅听到你如此回答，心情似乎就已经愉快了几分。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui8"});
            Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 2;
            if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
            {
                                
                        _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
                        _gameMethods.SyncAchievement();

            }
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei4", "yan5", "zui10"});
            yield return _gameMethods.OpenDialog(5012); // "事先声明，这可还不算在开始哄你的范畴内哦。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei4", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(5013); // "「知道了，{nw}{w=0.01}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(5014); // "你还真是了解人情世故呢。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(5015); // "不行么？"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei7", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(5016); // "「当然……{nw}{w=0.01}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end3_1_tuan6_699cb3ab.ogg");
            yield return _gameMethods.OpenDialog(5017); // "可以。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui16"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end3_1_tuan6_70f4f98c.ogg");
            yield return _gameMethods.OpenDialog(5018); // "——那么，我好像也不该再过多地纠缠你了。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"lv1", "mei7", "yan7", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.OpenDialog(4891); // "晚安，小公主。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui7"});
            yield return _gameMethods.OpenDialog(4807); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui19"});
            yield return _gameMethods.OpenDialog(5019); // "晚安。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"lv1", "mei7", "yan11", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(5020); // "记得梦到我哦？"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan10", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(4797); // "……"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"lv1", "mei7", "yan2", "zui8"});
            yield return _gameMethods.OpenDialog(5021); // "别太缠人。"
            yield return _gameMethods.OpenDialog(4797); // "……"
            yield return _gameMethods.PlaySound("sounda1", 0.0f, 1.0f, "audio/sound/emeng_dajie/magic1.ogg");
            yield return _gameMethods.Hide("nuo1");
            yield return _gameMethods.Transition(time:0.5f);
            yield return _gameMethods.OpenDialog(4798); // "…………"
            yield return _gameMethods.OpenDialog(5022); // "诺伯拉离开了。"
            yield return _gameMethods.OpenDialog(5023); // "屋内重回寂静。"
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/tiankong_yewan.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.29f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 1.28f}})});
            yield return _gameMethods.TransitionBy("blink2");
            yield return _gameMethods.OpenDialog(5024); // "我望着夜空，头脑空白，默默发呆。"
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:4f);
            yield return _gameMethods.OpenDialog(5025); // "……是错觉么。"
            yield return _gameMethods.OpenDialog(5026); // "总感觉今天不是在哄人，就是在哄龙。"
            yield return _gameMethods.PlaySound("music1", 0.0f, 1.0f, "audio/music/end/qicheng.mp3");
            yield return _gameMethods.OpenDialog(5027); // "该不会以后的日子都要这样吧。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan24", "zui18", "emoji2", "d3"});
            yield return _gameMethods.OpenDialog(4797); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan12", "zui16", "emoji2"});
            yield return _gameMethods.OpenDialog(5028); // "不知为何，一股宛若中年已婚人的淡淡沧桑与疲惫感，浮上心头。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(5029); // "真不容易啊……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan8", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(5030); // "——不过，有一点倒是可以肯定。"
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:2f);
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition(time:0.5f);
            yield return _gameMethods.OpenDialog(5031); // "未来，绝对、绝对，不会无聊……就是了。"
            Defaults.Persistent.Gallery_js_lock = 1;
            yield return _gameMethods.StopSound(channelName:"music1", fadeOut:5f);
            Defaults.Persistent.Jq_11_2 = 1;
            
                _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_4");
                _gameMethods.SyncAchievement();
            Engine._history = false;
            yield return _gameMethods.OpenDialog(5032); // "{nw}{w=0.5}"
            yield return _gameMethods.Show("tishi_shi", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 0.5f)}, {"pos", new Vector2(0.5f, 0.5f)}, {"zpos", 0.0f}})});
            yield return _gameMethods.Transition(time:0.8f);
            yield return _gameMethods.OpenDialog(5033); // "{nw}{w=60}"
            Engine._history = true;
            if (Defaults.Persistent.Jq_11_1==1 && Defaults.Persistent.Jq_11_2==1 && Defaults.Persistent.Jq_11_3==1 && Defaults.Persistent.Jq_11_4==1 && Defaults.Persistent.Jq_11_5==1 && Defaults.Persistent.Jq_11_6==1 && Defaults.Persistent.Jq_11_7==1)
            {
                                
                        _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_7");
                        _gameMethods.SyncAchievement();

            }
        }
}