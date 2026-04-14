    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class zhuxian_1 : ILabelProvider
    {
        private GameMethods _gameMethods;

        public zhuxian_1(GameMethods gameMethods)
        {
            _gameMethods = gameMethods;
        }

            public IEnumerator label_zhuxian1()
        {
            yield return _gameMethods.PlaySound("music", 2f, 1.0f, "audio/demo_audio/music/richang1.mp3");
            yield return _gameMethods.PlaySound("soundb", 0.0f, 1.0f, "audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/zoulang_zhuanjiao2.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.14f)}, {"zoom", 0.57f}})});
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:1f);
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.85f)}, {"zoom", 0.37f}})});
            yield return _gameMethods.Transition();
            Defaults.Persistent.Jq_1_4 = 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(462); // "在过道上，我偶遇了赫泽尔。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/jiaobusheng_nv_liangbuzou_gaogen_diban.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}, {"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.20f}, {"ypos", 42f}, {"zpos", 84f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan24", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(463); // "因为他明显目空一切，所以我自觉地安静让路。"
            yield return _gameMethods.PlaySound("soundb", 0.0f, 1.0f, "audio/demo_audio/sound/zu3_nv_zou_man.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 42f}, {"zpos", 84f}})});
            yield return _gameMethods.Show("he", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"xoffset", 100f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(464); // "正以为就此别过，"
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:1f);
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan3", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 100f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(465); // "他却忽然好像想起什么。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 100f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"xoffset", 0f}})});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian1_04baa3fd.ogg");
            yield return _gameMethods.OpenDialog(467); // "昨天晚上你哭了？"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/zhenjing_shuaidaoganjue.mp3");
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -5f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 5f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -2f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan2", "zui9", "emoji2"});
            yield return _gameMethods.OpenDialog(468); // "……？！"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian1_d4b3acc1.ogg");
            yield return _gameMethods.OpenDialog(469); // "我能感知生物的灰暗情绪。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan3", "zui2", "emoji2"});
            yield return _gameMethods.OpenDialog(470); // "……啊，"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui19", "-emoji2"});
            yield return _gameMethods.OpenDialog(471); // "夜里容易想家。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 84f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.4f}, {"zpos", 24f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1");
            yield return _gameMethods.OpenDialog(472); // "居然被你感觉到了，真让人不好意思。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei12", "yan9", "zui2"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 24f}})});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui9"});
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(473); // "「没事，{nw}{w=0.15}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(474); // "这很正常。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui7"});
            yield return _gameMethods.OpenDialog(475); // "……是啊，这是正常的，但不是讨人喜欢的。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(476); // "今后要更加注意才行。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.5>audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 42f}, {"zpos", 24f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.6f}, {"ypos", -30f}, {"zpos", -102f}})});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(477); // "因为一个人容易寂寞，为了防止我打扰到你的睡眠，你可以陪我一起睡。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei4", "yan4", "zui2"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -30f}, {"zpos", -102f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(479); // "其实我是在开玩笑。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan16", "zui2", "emoji1"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan5", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.PlaySound("soundb", 0.0f, 1.0f, "audio/demo_audio/sound/zu3_nv_zou.ogg");
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan17", "zui2", "emoji1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ease", 1.4f}, {"xoffset", 200f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.7f}, {"alpha", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.7f}, {"alpha", 0f}})});
            yield return _gameMethods.OpenDialog(480); // "他一脸无语，没有给予我多余的反应和理会，越过我，下了楼梯。"
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:4f);
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.OpenDialog(481); // "……………………"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg10_memory.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg10_memory.jpg");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_mofa_yuan_an.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.0f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.67f}})});
            
            yield return _gameMethods.OpenDialog(482); // "这座城堡的前主人貌似积淀颇丰。/n遗留下来了一整套家居魔法装置。"
            yield return _gameMethods.OpenDialog(483); // "里面零件复杂，组装了似乎有平衡湿气、防尘、维持自来水管道之类的功能。"
            yield return _gameMethods.PlaySound("soundb", 0.0f, 1.0f, "audio/sound/jiaobusheng_xin_man1.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -102.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.7f}, {"zpos", -432.0f}})});
            yield return _gameMethods.Show("heilong_mofa_jin_an", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}, {"pos", new Vector2(300f, 156f)}, {"anchor", new Vector2(0f, 0f)}, {"zoom", 0.54f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.5f}, {"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(484); // "它由魔力结晶供能，而请魔法师充一次能便花销不菲。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -432.0f}})});
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:1f);
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(485); // "王城里，有不少落魄贵族死要面子购置了一套装点门面，实际上平时根本不舍得用。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_mofa_jin_an.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(486); // "……就像明明装了空调地暖，却心疼巨额电费而舍不得开一样。"
            yield return _gameMethods.OpenDialog(487); // "不过赫泽尔毫无顾忌，只伸了下手，"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/strange_wave.mp3");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_mofa_jin_liang.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(300f, 156f)}, {"anchor", new Vector2(0f, 0f)}, {"zoom", 0.54f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"alpha", 1f}})});
            yield return _gameMethods.Show("heilong_mofa_jin_guang", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}, {"anchor", new Vector2(0f, 0f)}, {"zoom", 0.54f}, {"pos", new Vector2(300f, 156f)}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"alpha", 0.7f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.3f}, {"alpha", 0.2f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.7f}, {"alpha", 0.7f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.5f}, {"alpha", 0.2f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(488); // "便直接把这颗巨大的能量石充满了。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_mofa_jin_liang.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_mofa_yuan_an.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_mofa_jin_an.jpg");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(489); // "……亮起的是暗紫色。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(490); // "这是他魔力的颜色么？"
            yield return _gameMethods.Scene("heilong_mofa_yuan_liang", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"ypos", 0.94f}, {"zpos", -402.0f}, {"xpos", 0.5f}})});
            yield return _gameMethods.Transition(time:1f);
            yield return _gameMethods.OpenDialog(491); // "………………"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(492); // "总之，得益于这套历史遗产，我过上了有厕所（不用人工掏茅坑）、有浴室、有自来水（从地下抽取并经过滤）、有自燃厨具的小资生活。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 2>audio/sound/jiaobusheng_xin_man1.ogg");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg11_memory.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg11_memory.jpg");
            yield return _gameMethods.Scene("heilong_chufang_jiazi_baitian", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"ypos", 0.7f}, {"zoom", 0.5f}, {"xpos", 0.5f}})});
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15"});
            yield return _gameMethods.OpenDialog(493); // "唯一可惜的是，没有食物。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(494); // "虽然储藏间有保鲜功能，但装置的魔法效力有限，顶多延缓变质。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15"});
            yield return _gameMethods.OpenDialog(495); // "经过几十年，厨房的食材早已腐败降解。/n牛羊肉看不出全貌，麦稻只剩下发霉的壳子。"
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_chufang_baitian.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 0.74f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.41f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(496); // "我找到了一盒昂贵的香料，这东西主要从精灵的领地出产，价比黄金，基本只有贵族才能享用。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(497); // "可惜发霉了。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei6", "yan12", "zui18"});
            yield return _gameMethods.OpenDialog(498); // "心痛得难以呼吸。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15"});
            yield return _gameMethods.OpenDialog(499); // "唯一幸存的只有盐。"
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.Transition();
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.OpenDialog(491); // "………………"
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_dating_baitian.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.67f}})});
            yield return _gameMethods.Transition(time:1f);
            yield return _gameMethods.OpenDialog(500); // "我在城堡中游荡了一会儿。"
            yield return _gameMethods.PlaySound("soundb", 0.0f, 1.0f, "audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.Show("he", parts: new List<string>{"mei7", "yan10", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"ypos", 1.43f}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.27f}, {"xpos", 0.5f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(501); // "在大厅时，趁着偶遇了赫泽尔，我忙抓住机会拖住他询问。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei7", "yan3", "zui2"});
            yield return _gameMethods.StopSound(channelName:"soundb");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}, {"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.35f}, {"zpos", -198f}, {"ypos", -40f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui19"});
            yield return _gameMethods.OpenDialog(502); // "你平时怎么吃饭呀？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -198f}, {"ypos", -40f}})});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(503); // "我不需要进食，我以生物的黑暗情绪为食。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(504); // "好酷的设定。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(505); // "那个，也许会让你感到麻烦，但我需要定期进食才能活下来。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.6>audio/sound/jiaobusheng_xin_kuai1.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -198f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.11f}, {"zpos", -228f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan17", "zui2"});
            yield return _gameMethods.OpenDialog(506); // "一日三餐……"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -228f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan20", "zui2"});
            yield return _gameMethods.OpenDialog(507); // "实在不行，一日两餐，"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(508); // "一餐也可以。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(509); // "在这个世界，只有贵族才会享用一日三餐。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(510); // "平民只吃午餐和晚餐，小孩和生病的人倒是能享受到早餐的特殊待遇。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(511); // "我很担心让他觉得我太过麻烦，便会使用魔法，让我在昏迷中度过三年。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_dating_baitian.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"xpos", -114f}, {"zoom", 0.8f}})});
            yield return _gameMethods.Show("he", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"ypos", 1.87f}, {"zoom", 0.36f}, {"anchor", new Vector2(0.5f, 1.0f)}, {"xpos", 0.5f}})});
            yield return _gameMethods.TransitionBy("blink2");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui7", "-emoji2"});
            yield return _gameMethods.OpenDialog(512); // "然而，他脸上表情如常。大概之前就明白人类需要食物吧。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan7", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(513); // "知道了。等下。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 2>audio/demo_audio/sound/zu3_nv_zou.ogg");
            yield return _gameMethods.Hide("he");
            yield return _gameMethods.Transition(time:1f);
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(514); // "他说完，就出了城堡大门。"
            yield return _gameMethods.Scene("heilong_dating_men_baitian", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.8f}, {"xalign", 0.5f}, {"yalign", 0.5f}})});
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(515); // "我留在大厅中，眼巴巴地盯着大门，宛若嗷嗷待哺的雏鸟等待鸟妈妈回巢。"
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.OpenDialog(491); // "………………"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/silu.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.27f, 1.1f)}, {"zoom", 0.58f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan10", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"ypos", 1.41f}, {"zoom", 0.26f}, {"xpos", 0.5f}})});
            yield return _gameMethods.TransitionBy("blink2");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(516); // "只过了十分钟，他就回来了。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1>audio/demo_audio/sound/zu3_nv_zou.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.29f}, {"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.69f}, {"xpos", 96f}})});
            yield return _gameMethods.Show("he", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.5f}}), new SameLineParamData(new Dictionary<string, object>{{"ease_quad", 0.98f}, {"xpos", 0.62f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan1", "zui18", "emoji2", "emoji5"});
            yield return _gameMethods.OpenDialog(517); // "——拖着一麻袋"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 96f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.62f}})});
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.6f, "audio/demo_audio/sound/hu.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(96f, -40f)}, {"zpos", -228f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.67f}, {"pos", new Vector2(-138f, 194f)}, {"zpos", -312f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(518); // "新鲜的食物。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-138f, 194f)}, {"zpos", -312f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-138f, 194f)}, {"zpos", -312f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.2f}, {"pos", new Vector2(-48f, 248f)}, {"zpos", -500f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan9", "zui18", "emoji2", "emoji5"});
            yield return _gameMethods.OpenDialog(519); // "这一袋子里装满了野外的浆果、菌菇、野菜。虽然都沾有泥头，但四溢的香气透露出这些都是现采的。赫泽尔当然不会亲自动手，多半和之前一样是让巨猿搜集来的吧。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-48f, 248f)}, {"zpos", -500f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan24", "zui8", "emoji2", "emoji5"});
            yield return _gameMethods.OpenDialog(520); // "我觉得悲喜交集。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui8", "emoji2", "-emoji5", "emoji6"});
            yield return _gameMethods.OpenDialog(521); // "/n……对那些巨猿，不由得产生了些许同情。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/Simple Whoosh A.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-48f, 248f)}, {"zpos", -500f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.5f}, {"pos", new Vector2(156f, -40f)}, {"zpos", -302f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(522); // "这够你吃多久。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(156f, -40f)}, {"zpos", -302f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -40f}, {"zpos", -302f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"ypos", 110f}, {"zpos", -278f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan9", "zui15", "emoji2", "-emoji6"});
            yield return _gameMethods.OpenDialog(523); // "我目测了一下，这袋子食物大约有五十公斤重，"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 110f}, {"zpos", -278f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(156f, 110f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.9f}, {"pos", new Vector2(-6f, 164f)}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(524); // "去掉泥土、水分和不能吃的部分，大概只剩下70%%左右。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-6f, 164f)}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-6f, 164f)}, {"zpos", -278.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.54f}, {"pos", new Vector2(156f, -40f)}, {"zpos", -344.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(525); // "一个半月……"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan12", "zui8", "emoji2"});
            yield return _gameMethods.OpenDialog(526); // "不，"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei4", "yan5", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(527); // "两个月。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan4", "zui2"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(156f, -40f)}, {"zpos", -344.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei4", "yan5", "zui8", "emoji2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/dui1_33f3d53f.ogg");
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(528); // "他的眼神中再次透露出“好麻烦”的嫌弃。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan22", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(529); // "对于寿命漫长的龙来说，这大概就相当于每天都要出去采集一样麻烦吧。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -344.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"zpos", -320.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(530); // "我心虚极了。生怕他下一秒就施展魔法，把我强制冬眠。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(461); // "…………"
            Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.6>audio/sound/jiaobusheng_xin_kuai1.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -320.0f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -40f}, {"zpos", -320.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.37f}, {"ypos", -70f}, {"zpos", -392.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1");
            yield return _gameMethods.OpenDialog(531); // "如果不介意的话，可以去人类的市集，买那种船员吃的饼干。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -70f}, {"zpos", -392.0f}})});
            yield return _gameMethods.OpenDialog(532); // "为了远洋航行，这种压缩干粮经过多次烤晒，含水量极低，能存放一年。"
            yield return _gameMethods.OpenDialog(533); // "缺点是坚硬得像石块，水手每次吃前都要先用刀鞘把饼干砸开，然后用液体泡软。"
            yield return _gameMethods.OpenDialog(491); // "………………"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan17", "zui2"});
            Engine._history = false;
            yield return _gameMethods.OpenDialog(534); // "{nw}{w=1}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1");
            yield return _gameMethods.OpenDialog(535); // "好在，赫泽尔只是无言地看了我那么一会，"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 2>audio/demo_audio/sound/zu3_nv_zou.ogg");
            yield return _gameMethods.Show("he", parts: new List<string>{"yan17", "zui2", "emoji1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"alpha", 1f}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"xoffset", 100f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.8f}, {"alpha", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.2f}, {"alpha", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1");
            yield return _gameMethods.OpenDialog(536); // "没有别的反应，就径自走掉了。"
            yield return _gameMethods.Hide("he");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(537); // "他没回应人类市集的话题，我也不敢多问。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(156f, -70f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.91f}, {"pos", new Vector2(-240f, 230f)}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(538); // "我打量着被留下的麻袋。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 2>audio/sound/jiaobusheng_xin_man1.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-240f, 230f)}})});
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_chufang_baitian.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.33f, 1.12f)}, {"zoom", 0.4f}})});
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan5", "zui7", "emoji1", "emoji2"});
            yield return _gameMethods.OpenDialog(539); // "费了九牛二虎之力，把它拖到厨房。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/sibuliao2.mp3");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_chufang_shuicao_baitian.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.29f, 1.14f)}, {"zoom", 0.6f}})});
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan9", "zui6", "-emoji1", "-emoji2"});
            yield return _gameMethods.OpenDialog(540); // "我运用日日夜夜熟练掌握的洗菜知识，简单地处理了这袋食物。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan12", "zui6", "emoji2"});
            yield return _gameMethods.OpenDialog(541); // "至于分辨菌菇的毒性……我只能说，努力过了。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 2>audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_chufang_jiazi_baitian.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.32f, 1.09f)}, {"zoom", 0.57f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.7f}, {"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui6", "-emoji2"});
            yield return _gameMethods.OpenDialog(542); // "根据前世的见闻，简单筛选掉了可能有毒的。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_chufang_jiazi_baitian.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(543); // "就算吃错了，赫泽尔应该不会防着我不管吧……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui6"});
            yield return _gameMethods.OpenDialog(544); // "不清楚赫泽尔是否是有意要求巨猿挑些无毒的，从结果上看大部分看起来都健康无害。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui6"});
            yield return _gameMethods.OpenDialog(545); // "由于食材采集得十分及时，尽管缺乏香料烹调，野菜的芬芳本身就已足够美味鲜甜。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui6"});
            yield return _gameMethods.OpenDialog(546); // "虽然缺乏肉类的摄入，但在这里也没有多余的选择，有的吃就不错了。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui6"});
            yield return _gameMethods.OpenDialog(547); // "我安慰自己，这是轻负担饮食。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan2", "zui19", "emoji7"});
            yield return _gameMethods.OpenDialog(548); // "/n追上了隔壁二十一世纪的前卫潮流呢。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan12", "zui19", "emoji1", "emoji2", "-emoji7"});
            yield return _gameMethods.OpenDialog(549); // "只是……如果一直这个吃法，好担心自己会缺少蛋白质。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan2", "zui18", "emoji1", "emoji2"});
            yield return _gameMethods.OpenDialog(550); // "只能再努力和黑龙拉近关系，看看他愿不愿意带点荤菜回来让我补充营养了。"
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:4f);
            yield return _gameMethods.PlaySound("soundb", 1f, 0.2f, "audio/demo_audio/sound/chanming.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.0f, saturationMatrix:1.0f, brightnessMatrix:0.0f, hueMatrix:0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.0f, saturationMatrix:1.0f, brightnessMatrix:-0.19f, hueMatrix:0.0f)}})});
            yield return _gameMethods.OpenDialog(551); // "用味道清甜的蔬菜汤填饱肚子，又做完冷藏工作，已经到下午了。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.0f, saturationMatrix:1.0f, brightnessMatrix:-0.19f, hueMatrix:0.0f)}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"-emoji1", "-emoji2"});
            yield return _gameMethods.OpenDialog(552); // "我清理了一下身上，在城堡中寻找赫泽尔的行迹。"
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:2f);
            yield return _gameMethods.PlaySound("soundc", 0.0f, 1.0f, "audio/sound/jiaobusheng_xin_man1.ogg");
            yield return _gameMethods.SceneBlack(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.4f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(491); // "………………"
            yield return _gameMethods.StopSound(channelName:"soundc", fadeOut:2f);
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.0f, saturationMatrix:1.0f, brightnessMatrix:0.0f, hueMatrix:0.0f)}})});
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.OpenDialog(553); // "最终在书房中找到了他。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.7f, "audio/sound/door_open_3.mp3");
            yield return _gameMethods.ShowWhite(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "dissolve"}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg12_memory.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg12_memory.jpg");
            yield return _gameMethods.StopEngineTime(time:0.2f);
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_shufang_baitian_quanjing.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveTime", 1.5f}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.0f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.68f}})});
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 2.5>audio/sound/jiaobusheng_xin_man1.ogg");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_shufang_baitian_shugui.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.0f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.68f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.5f}, {"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(481); // "……………………"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_shufang_baitian_shugui.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            Defaults.Persistent.Jq_1_5 = 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(554); // "这是我这一世第一次见到如此丰富浩瀚的藏书。"
            yield return _gameMethods.HideBlack();
            yield return _gameMethods.HideWhite();
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_shufang_baitian_quanjing.jpg");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(555); // "在这个世界，书籍与文化大多为贵族所垄断，平民甚至很少有机会识字。"
            yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/demo_audio/music/youshang2.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(556); // "教育是昂贵的，一般是通过家族内聘请家庭教师的方式进行。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(557); // "而学校……除了王国内的几所学习剑术与魔法的贵族学院外，/n在各地的城镇中，只有少量私人创办的小学校，{nw}{w=0.15}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(558); // "但也要不菲的学费。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(559); // "从我来到王都以来，一直试图在空暇时间偷听教会学校的课。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(560); // "毕竟根据我上辈子从小受到的教育，知识就是力量。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan18", "zui15"});
            yield return _gameMethods.OpenDialog(561); // "如果学会文字，我就能摆脱与众多劳动力竞争女佣、杂工岗位的命运，而在政府办事处找到一份更加轻松、拥有更多报酬的文书工作。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(562); // "尤其在整个国家的识字率也并不高的情况下。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(563); // "但不知道是不是转生的原因，这个世界的文字对我似乎有一种排斥反应。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(564); // "尽管我仔细用拼音注音，做了详密的笔记，并很努力地背诵了。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(565); // "可它们还是不停地从我的记忆中流失，好像对我整个人都怀有意见一样。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan20", "zui18"});
            yield return _gameMethods.OpenDialog(491); // "………………"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(566); // "又能怎么办呢……{nw}{w=0.15}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan21", "zui15"});
            yield return _gameMethods.OpenDialog(567); // "早在上辈子就明白了这个道理。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan20", "zui15"});
            yield return _gameMethods.OpenDialog(568); // "这世上，有些事，没有就是没有，不行就是不行。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(569); // "如果还是不想放弃，{nw}{w=0.15}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(570); // "也只能继续“偏要勉强”了。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan6", "zui7"});
            yield return _gameMethods.OpenDialog(571); // "好在，使出了全副力气，通过不断重复，我依旧成功掌握了一部分。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui7"});
            yield return _gameMethods.OpenDialog(572); // "新的本领。——这就是令生活有所转机的可能。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan17", "zui15"});
            yield return _gameMethods.OpenDialog(573); // "如果有一天机会降临了，我一定要凭此来抓住它。"
            yield return _gameMethods.ShowBlack(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.7f}, {"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(574); // "……我忽然后知后觉地意识到，我已经不可能回去了。"
            yield return _gameMethods.ShowBlack(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(575); // "三年后，我会迎接注定的命运。/n根本没有未来可言。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/moca3.mp3", "audio/demo_audio/sound/book2_he.mp3");
            yield return _gameMethods.HideBlack();
            yield return _gameMethods.Transition();
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/shuben_bi.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 200f}, {"xalign", 0.5f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan17", "zui15"});
            yield return _gameMethods.OpenDialog(576); // "不过，读书本身是一件令人愉快的事。"
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:4f);
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_shufang_baitian_shafa.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "trans_rip_fast"}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.04f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.54f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/shuben_bi.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}, {"dissolveType", "dissolve"}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 470f}, {"xalign", 0.5f}})});
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 2>audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}, {"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.35f}, {"xpos", 102f}, {"zpos", -624f}})});
            yield return _gameMethods.StopEngineTime(time:1.45f);
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(102f, 0f)}, {"zpos", -624f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan13", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "dissolve"}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.57f, 1.05f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.14f}})});
            yield return _gameMethods.OpenDialog(577); // "从书柜里抽出了一本厚度适中的书籍，我走到沙发区。"
            yield return _gameMethods.OpenDialog(578); // "赫泽尔正安静地坐在那里，翻阅着一本厚厚的大部头，头也不抬。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/tangxia2_duan.mp3");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_shufang_baitian_shafa.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"at", "default"}, {"as", "heilong_shufang_baitian_shafa2"}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(564f, 18f)}, {"anchor", new Vector2(0f, 0f)}, {"zoom", 0.33f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"alpha", 1f}})});
            yield return _gameMethods.StopEngineTime(time:1.02f);
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_shufang_baitian_shafa.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(579); // "我轻手轻脚地自己找了个位置落座。"
            yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/demo_audio/music/richang1.mp3");
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/book1.mp3");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/daoju/shuben_bi.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/shuben.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 300f}, {"xpos", 140f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15"});
            yield return _gameMethods.OpenDialog(580); // "悄悄打开手中的书本。"
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(581); // "…………只看了一会儿，就深深地沉默了。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan12", "zui16", "emoji2", "emoji6"});
            yield return _gameMethods.OpenDialog(582); // "太深奥了，有七八成的字，我都不认识。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/shuben.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 300f}, {"xpos", 140f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"ypos", 380f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan24", "zui7", "emoji2", "emoji6"});
            yield return _gameMethods.OpenDialog(583); // "好想回去换一本书。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/shuben.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 380f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan10", "zui14", "emoji2", "-emoji6"});
            yield return _gameMethods.OpenDialog(584); // "…… 不过在短时间内频繁地闹出动静，会惹恼了身边的那头龙吧。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/book1.mp3", "audio/demo_audio/sound/book1.mp3", "<silence 0.5>", "audio/demo_audio/sound/book1.mp3");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/shuben.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 380f}, {"xpos", 140f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"ypos", 300f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui14", "-emoji2"});
            yield return _gameMethods.OpenDialog(585); // "我硬着头皮，"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui14"});
            yield return _gameMethods.OpenDialog(586); // ""
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui14"});
            yield return _gameMethods.OpenDialog(587); // "又翻了几页。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/shuben.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 300f}})});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui14"});
            yield return _gameMethods.OpenDialog(586); // ""
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui14"});
            yield return _gameMethods.OpenDialog(588); // "企图从中找到一面能够参悟的内容。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.5f, "audio/demo_audio/sound/book1.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui16", "emoji2"});
            yield return _gameMethods.OpenDialog(589); // "找了半天后，虽然我的知识水平没能获得显著的提高，但精神状态确实有了显著的下滑。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan5", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/shuben.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 300f}, {"xpos", 140f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"ypos", 380f}})});
            yield return _gameMethods.Hide("heilong_shufang_baitian_shafa2");
            yield return _gameMethods.Transition(time:1f);
            yield return _gameMethods.OpenDialog(590); // "我抬起头，望向了赫泽尔的脸。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/shuben.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 380f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan5", "zui8", "emoji2"});
            yield return _gameMethods.OpenDialog(591); // "今天的学习课题，就暂定为龙族观察吧。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(592); // "观察持续了一分钟后，"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(593); // "赫泽尔冷不丁地抬起头，一双血红的眼瞳平静地看向我。"
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:3f);
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice4_71b15ab0.ogg");
            yield return _gameMethods.OpenDialog(594); // "？"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/zhenjing_shuaidaoganjue.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -624.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.18f}, {"zpos", -605.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui8", "emoji2"});
            yield return _gameMethods.OpenDialog(595); // "糟了。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -605.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(596); // "……我正在向你学习。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan11", "zui8", "emoji2"});
            yield return _gameMethods.OpenDialog(597); // "总之先拍个马屁再说。我憋出一个借口，恭敬地解释。"
            yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/demo_audio/music/qingkuai4.mp3");
            Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei4", "yan5", "zui10", "emoji2"});
            yield return _gameMethods.OpenDialog(598); // "学习你对阅读的专注。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei4", "yan4", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei4", "yan5", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(599); // "他似乎有些无语，但没露出不快的意思。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan2", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(600); // "我顺杆而上。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/shuben.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 380f}, {"xpos", 140f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"ypos", 420f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19", "-emoji2", "emoji10"});
            yield return _gameMethods.OpenDialog(601); // "你平时都喜欢来这里读书吗？"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/shuben.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 420f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui8", "emoji10"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice8_e4e41444.ogg");
            yield return _gameMethods.OpenDialog(602); // "……嗯。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan5", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan2", "zui8", "-emoji10"});
            yield return _gameMethods.OpenDialog(603); // "「这座城堡的主人{nw}{w=0.001}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(604); // "留下了很多书籍。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan3", "zui14"});
            yield return _gameMethods.OpenDialog(605); // "……啊。这么说来，书本上的确都是人类王国的通用语。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui14"});
            yield return _gameMethods.OpenDialog(606); // "也就是说，这座城堡原本属于一名人类领主吧。"
            yield return _gameMethods.EngineSetVolume(volume:0.5f, delay:0.5f, channelName:"music");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(607); // "为什么它会落入赫泽尔手里……{nw}{w=0.15}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui8", "emoji2"});
            yield return _gameMethods.OpenDialog(608); // "嗯，还是别再深思了。"
            yield return _gameMethods.EngineSetVolume(volume:1f, delay:0.5f, channelName:"music");
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui2", "-emoji2"});
            yield return _gameMethods.OpenDialog(609); // "也就是说……你还学会了人类的文字吗？"
            Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1");
            yield return _gameMethods.OpenDialog(610); // "真博学，你是不是掌握了所有种族的文字。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan11", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(611); // "{nw}{w=0.2}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(612); // "{nw}{w=0.12}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(613); // "他幅度很小地点了下头，理所当然一般。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_qian");
            yield return _gameMethods.OpenDialog(614); // "「事实上，所有种族的语言和文字都来源于上古时期的一种文字——真言。{nw}{w=0.001}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan10", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_qian");
            yield return _gameMethods.OpenDialog(615); // "/n那是万物运行的法则、魔力流通的原理。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan9", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui14"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian1_ab579776.ogg");
            yield return _gameMethods.OpenDialog(616); // "学会真言，就掌握了魔法，能听懂世上任何一种语言。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan5", "zui14"});
            yield return _gameMethods.OpenDialog(617); // "「古时的矮人、{nw}{w=0.001}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(618); // "兽人、人类和精灵们魔力强大，试图铸造通天塔，{nw}{w=0.001}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui14"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(619); // "可自然的力量却突然降临，混乱了他们的语言。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan17", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian1_0c1937dc.ogg");
            yield return _gameMethods.OpenDialog(620); // "这分化成了现在各族的语言。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan10", "zui15"});
            yield return _gameMethods.OpenDialog(621); // "好强力。好想学。"
            yield return _gameMethods.EngineSetVolume(volume:0.5f, delay:1f, channelName:"music");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(622); // "但我想终于明白自己为什么学不会文字和魔法了。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(623); // "我有一半的部分不算这个世界的人。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(624); // "所以，必须付出双倍的努力。"
            yield return _gameMethods.EngineSetVolume(volume:1f, delay:0.5f, channelName:"music");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -605.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.18f}, {"zpos", -617.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(625); // "真是太厉害了。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui19"});
            yield return _gameMethods.OpenDialog(626); // "你在读的这本是什么呢？"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -617.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan7", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(627); // "/n鲁亚王国的历史。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan7", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(628); // "那好像是在我们国家北部的王国呀，这本书里讲了什么？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui14"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian1_617c0bd6.ogg");
            yield return _gameMethods.OpenDialog(629); // "鲁亚王室的权力嬗变。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui16", "emoji7"});
            yield return _gameMethods.OpenDialog(630); // "我继续期待地看着他。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan2", "zui16", "emoji7"});
            yield return _gameMethods.OpenDialog(631); // "「……{nw}{w=0.15}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan4", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(632); // "……{nw}{w=0.001}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan7", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(633); // "我正读到王后试图通过意外继承王位。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan7", "zui2"});
            yield return _gameMethods.EngineSetVolume(volume:0f, delay:0.2f, channelName:"music");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan5", "zui8", "emoji2", "-emoji7"});
            yield return _gameMethods.OpenDialog(634); // "不愧是灾祸之龙。原来你在熟习业务，好尽职尽责。"
            yield return _gameMethods.EngineSetVolume(volume:1f, delay:0.5f, channelName:"music");
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan2", "zui19", "-emoji2"});
            yield return _gameMethods.OpenDialog(635); // "这王后真是个狠角色啊，我辈榜样。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei3", "yan2", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian1_04fb1af7.ogg");
            yield return _gameMethods.OpenDialog(636); // "你想掌权？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui19"});
            yield return _gameMethods.OpenDialog(637); // "「很值得奇怪么，{nw}{w=0.15}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(638); // "/n人类不全都是贪婪的生物嘛。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(639); // "我见过很多有野心的人，但你和他们不太一样，并不具备类似的特征。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/ga_wuyajiao.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan24", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(640); // "是啊，最大的区别就是短命。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19", "-emoji2"});
            yield return _gameMethods.OpenDialog(641); // "我比较没出息，能活下来就很满足了。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan7", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian1_28de8aea.ogg");
            yield return _gameMethods.OpenDialog(642); // "对于你，想生存确实不算容易。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan7", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(643); // "你说话是一直这么诚实吗。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan5", "zui8", "emoji2"});
            yield return _gameMethods.OpenDialog(644); // "「？{nw}{w=0.001}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(645); // "/n伪装是弱者的生存技巧，我不需要。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/jian.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan10", "zui8", "emoji2"});
            yield return _gameMethods.OpenDialog(646); // "我感觉自己的身上中了一箭。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19", "-emoji2"});
            yield return _gameMethods.OpenDialog(647); // "那么，那位王后最后成功谋取王位了么？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan7", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan11", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian1_94aea0d2.ogg");
            yield return _gameMethods.OpenDialog(648); // "她成为了鲁亚王国历史上的第一任女王，在她六十岁诞辰当天。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan23", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(649); // "不过，在她逝世的第二天，原王室的男性子嗣用同样的方法再次夺回了王座。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan23", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(650); // "好像有点似曾相识。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(651); // "好有意思。能再多讲点么？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan11", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice4_1ee9a704.ogg");
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.OpenDialog(652); // "他看着我，面无表情，没有说话。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei1", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(653); // "……对不起，我是不是吵到你了？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei1", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(654); // "没有。"
            Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan8", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei1", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(655); // "你靠我太近了。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan8", "zui2"});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/moca2.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -617.0f}, {"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.22f}, {"zpos", -575.0f}, {"ypos", 10f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei2", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(656); // "抱歉，让你不舒服了。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -575.0f}, {"ypos", 10f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei1", "yan5", "zui19"});
            yield return _gameMethods.OpenDialog(657); // "——你不高兴了么？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei1", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(658); // "……我不会被这种琐事惹恼。/n只是我想有必要重申，你会在三年后被我夺走未来。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(659); // "呃，"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(660); // "我知道啊。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian1_984c0229.ogg");
            yield return _gameMethods.OpenDialog(661); // "你对我的态度很奇怪。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui19"});
            yield return _gameMethods.OpenDialog(662); // "我想了解你。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/dui1_015b7ff5.ogg");
            yield return _gameMethods.OpenDialog(663); // "为什么。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1");
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei1", "yan6", "zui20"});
            yield return _gameMethods.OpenDialog(664); // "说出来，"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui19"});
            yield return _gameMethods.OpenDialog(665); // "理由可能会让你觉得很可笑。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(594); // "？"
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:5f);
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan5", "zui9"});
            yield return _gameMethods.OpenDialog(666); // "事实上，"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui9"});
            yield return _gameMethods.OpenDialog(667); // "我一脸诚恳地说。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -575.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.17f}, {"zpos", -593.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei5", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(668); // "你让我回忆起我邻居家的弟弟。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -593.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(669); // "（虽然我和他平生素未谋面，也不知道这位弟弟存在于哪个平行世界里。）"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan4", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei5", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(670); // "「……{nw}{w=0.001}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan4", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(671); // "我是龙。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan4", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei5", "yan", "zui7"});
            yield return _gameMethods.OpenDialog(672); // "对。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui9"});
            yield return _gameMethods.OpenDialog(673); // "呃、"
            yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/demo_audio/music/qingkuai3.mp3");
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/zhenjing_shuaidaoganjue.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", -8f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 8f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan2", "zui11"});
            yield return _gameMethods.OpenDialog(674); // "…啊，"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei4", "yan5", "zui12"});
            yield return _gameMethods.OpenDialog(675); // "仔细一看！"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(676); // "/n你比他要可爱，"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan7", "zui19"});
            yield return _gameMethods.OpenDialog(677); // "不是、"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/ding1.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(678); // "帅气多了！"
            Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan17", "zui8", "-emoji2"});
            yield return _gameMethods.OpenDialog(679); // "/n还成熟，博学多识，并且强大。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan17", "zui8"});
            yield return _gameMethods.OpenDialog(680); // "……你在对我甜言蜜语？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/shuben.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 420f}, {"xpos", 140f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"ypos", 470f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui2"});
            yield return _gameMethods.OpenDialog(681); // "阐述事实的事情，怎么能叫甜言蜜语呢。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/shuben.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 470f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui2"});
            yield return _gameMethods.OpenDialog(682); // "那你觉得这些话悦耳吗。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(683); // "…谁知道呢。/n龙的强大是显而易见，并且理所当然的。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui2"});
            Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(684); // "更棒了，现在你还有具备自知之明这个优点。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei8", "yan11", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice4_1ee9a704_1.ogg");
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan2", "zui7", "emoji2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice4_1ee9a704_2.ogg");
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan9", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei8", "yan2", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(685); // "你想继续听我读这本书？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan9", "zui2"});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/book2_he.mp3");
            yield return _gameMethods.Scene("shuben_bi", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 540f}, {"xalign", 0.45f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui20", "-emoji2"});
            yield return _gameMethods.OpenDialog(686); // "我可以吗？"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(687); // "我厚着脸皮问。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan9", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan23", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(688); // "下一任君主继承王位，登上王座之后，其英明才智得到了所有人的认可……"
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.EngineSetVolume(volume:0.2f, delay:2f, channelName:"music");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/daoju/shuben_bi.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}})});
            yield return _gameMethods.ShowBlack();
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(491); // "………………"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan23", "zui2"});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/shuben_bi.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}}), new SameLineParamData(new Dictionary<string, object>{{"xalign", 0.45f}, {"ypos", 540f}})});
            yield return _gameMethods.HideBlack();
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(689); // "我们度过了一段平静的时光。"
            yield return _gameMethods.EngineSetVolume(volume:1f, delay:1f, channelName:"music");
            yield return _gameMethods.OpenDialog(690); // "为了表现出自己倾听的专注投入，我试图给出一些有效反馈。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan23", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(691); // "真可惜。这名将军一生都是个军事天才，却因为一时失策，发动了这场注定失败的战争。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian1_132a252c.ogg");
            yield return _gameMethods.OpenDialog(692); // "不，他是有意的。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan2", "zui9"});
            yield return _gameMethods.OpenDialog(693); // "啊，为什么？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan7", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei8", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(694); // "如果国家遭受重创，对他更有利。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan7", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan18", "zui15"});
            yield return _gameMethods.OpenDialog(695); // "…………噢——"
            Defaults.Haogandu_he = Defaults.Haogandu_he - 2;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei1", "yan20", "zui5"});
            yield return _gameMethods.OpenDialog(696); // "我明白了。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei1", "yan20", "zui5"});
            yield return _gameMethods.OpenDialog(697); // "你明白什么了。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui5"});
            yield return _gameMethods.OpenDialog(698); // "国家只是一个抽象的政治体，它本身没有利益，不会受利益驱使而做出什么行动。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(699); // "但人有。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui5"});
            yield return _gameMethods.OpenDialog(700); // "这位将军出身显赫名门，他的野心与冷酷不相上下。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui5"});
            yield return _gameMethods.OpenDialog(701); // "之所以明知必败却发动战争，"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan18", "zui5"});
            yield return _gameMethods.OpenDialog(702); // "是因为他……"
            yield return _gameMethods.OpenSelectMenu(talk: new List<string>{"-想追求刺激", "-要释放情绪", "-想从国家灾难中攫取个人利益"}, jump: new List<string>{"label_zhuxian_1_menu_0_0uZ3wM7p", "label_zhuxian_1_menu_0_cfSQiBxk", "label_zhuxian_1_menu_0_L6K1ovAI"}, condition: new List<string>{"NONE", "NONE", "NONE"});
        }

        public IEnumerator label_choice2_1()
        {
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/demo_audio/music/qingkuai5.mp3");
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/ding1.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"yan5", "zui1", "emoji2"});
            yield return _gameMethods.OpenDialog(703); // "因为他想追求刺激？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei7", "yan4", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"yan5", "zui1", "emoji2"});
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei7", "yan7", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"yan5", "zui1", "emoji2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice2_1_6fde7548.ogg");
            yield return _gameMethods.OpenDialog(704); // "虽然我不是人类，但我相信，你的思维在人类之中也属于异类。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei7", "yan7", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"yan6", "zui17", "emoji2"});
            yield return _gameMethods.OpenDialog(705); // "…好吧。看来错了。"
            yield return _gameMethods.ChangeLabelTo("label_choice2");
        }

        public IEnumerator label_choice2_2()
        {
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/demo_audio/music/qingkuai5.mp3");
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/ding1.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"yan5", "zui10", "emoji2"});
            yield return _gameMethods.OpenDialog(706); // "因为他想释放情绪？"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"yan3", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(707); // "我越想越有道理。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"yan5", "zui16", "emoji2"});
            yield return _gameMethods.OpenDialog(708); // "你看，这位将军出身名门，年纪轻轻就入职军队。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"yan12", "zui10", "emoji2"});
            yield return _gameMethods.OpenDialog(709); // "在退休制度尚未落实的这个世界，保守估计，这位大人是要上班终生的。"
            yield return _gameMethods.ExecuteCharacterImageData("nv", parts: new List<string>{"yan4", "zu10", "emoji2"});
            yield return _gameMethods.OpenDialog(710); // "「他可能对工作感到厌倦了。{nw}{w=0.15}"
            yield return _gameMethods.ExecuteCharacterImageData("nv", parts: new List<string>{"mei4", "yan4", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(711); // "既然如此，想释放情绪也算是合情合理、情有可原。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"yan4", "zui15", "emoji2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice4_18fd1668.ogg");
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei4", "yan16", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice2_2_ff8181e6.ogg");
            yield return _gameMethods.OpenDialog(712); // "你思考问题的方式很有趣，只是仿佛欠缺了一些理智。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei4", "yan16", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"yan6", "zui17", "emoji2"});
            yield return _gameMethods.OpenDialog(713); // "…好吧。错了。"
            yield return _gameMethods.ChangeLabelTo("label_choice2");
        }

        public IEnumerator label_choice2_3()
        {
            yield return _gameMethods.ExecuteCharacterImageData("nv", parts: new List<string>{"mei7", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(714); // "「这个国家已经位于危难边缘。{nw}{w=0.15}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv", parts: new List<string>{"mei8", "yan8", "zui9"});
            yield return _gameMethods.OpenDialog(715); // "/n即便因为这位将领的过错，而使国家在败仗中损兵折将，{nw}{w=0.15}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei5", "yan9", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv", parts: new List<string>{"mei8", "yan5", "zui4"});
            yield return _gameMethods.OpenDialog(716); // "/n但战争过后摇摇欲坠的国家，却反而更加依赖他手中的军队。」"
            Defaults.Haogandu_he = Defaults.Haogandu_he + 6;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan17", "zui7"});
            yield return _gameMethods.OpenDialog(717); // "这会令军事将领在国家中的政治地位不降反升。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan17", "zui7"});
            yield return _gameMethods.OpenDialog(718); // "当军事首领发动一场战争，这未必是最优的国家战略，"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan5", "zui6"});
            yield return _gameMethods.OpenDialog(719); // "而是有利于领导者本人。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei7", "yan19", "zui2", "emoji0", "emoji1"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei8", "yan5", "zui6"});
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(491); // "………………"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan5", "zui6"});
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan5", "zui6"});
            yield return _gameMethods.OpenDialog(720); // "他看了我一会儿，"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan5", "zui14"});
            yield return _gameMethods.OpenDialog(721); // "停留的视线久到让我稍感异样了，"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan7", "zui2", "-emoji0", "-emoji1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(722); // "才重新把视线落回手中的书上。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei5", "yan7", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei8", "yan5", "zui14"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice2_3_e178956e.ogg");
            yield return _gameMethods.OpenDialog(723); // "嗯。你的理解没错。"
            yield return _gameMethods.ChangeLabelTo("label_choice2");
        }

        public IEnumerator label_choice2()
        {
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:7f);
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/daoju/shuben_bi.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}})});
            yield return _gameMethods.ShowBlack();
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(724); // "赫泽尔继续叙读这段历史。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan11", "zui2"});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/book1.mp3");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/shuben_bi.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}}), new SameLineParamData(new Dictionary<string, object>{{"xalign", 0.5f}, {"ypos", 540f}})});
            yield return _gameMethods.HideBlack();
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(725); // "讲完上个世纪曾经极盛的兽人部落联盟经过对人类王国的几次胜仗，逐渐衰弱并消亡。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.OpenDialog(726); // "他停了下来，看着我。/n仿佛在等我说些什么。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui7", "emoji2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice4_3120de59.ogg");
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"yan24", "zui8", "emoji2"});
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan12", "zui7", "-emoji2"});
            yield return _gameMethods.OpenDialog(727); // "……老大有期望，下属必须迎难而上。/n没有条件，创造条件也要上。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan8", "zui14", "emoji2"});
            yield return _gameMethods.OpenDialog(728); // "我开始头脑风暴，拼命调动起上辈子和网友们谈天说地残留的一点点社科思维。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan20", "zui14", "emoji2"});
            yield return _gameMethods.OpenDialog(729); // "明明打了胜仗，为什么兽人部落却渐渐消亡并解散了呢？"
            yield return _gameMethods.OpenSelectMenu(talk: new List<string>{"-他们变成了和平爱好者", "-他们感到无敌是多么寂寞", "-他们没有从军事胜利中赢取实际利益"}, jump: new List<string>{"label_zhuxian_1_menu_0_KQbknFJ6", "label_zhuxian_1_menu_0_G91rkkCt", "label_zhuxian_1_menu_0_5w2QHhB3"}, condition: new List<string>{"NONE", "NONE", "NONE"});
        }

        public IEnumerator label_choice3_1()
        {
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/demo_audio/music/qingkuai5.mp3");
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/ding1.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei4", "yan5", "zui10", "emoji2"});
            yield return _gameMethods.OpenDialog(730); // "因为他们洗心革面，变成了和平爱好者？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui12"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei4", "yan5", "zui15", "emoji2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice3_1_4a342977.ogg");
            yield return _gameMethods.OpenDialog(731); // "不错的答案，除了它错得离谱。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan16", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei1", "yan6", "zui17", "emoji2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice5_1ee9a704.ogg");
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.ChangeLabelTo("label_choice3");
        }

        public IEnumerator label_choice3_2()
        {
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/demo_audio/music/qingkuai5.mp3");
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/ding1.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei4", "yan5", "zui10", "emoji2"});
            yield return _gameMethods.OpenDialog(732); // "虽然很令人费解，但我想他们是感受到了强者的寂寞。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan2", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv", parts: new List<string>{"mei6", "yan12", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(733); // "「他们始终找不到足以互相欣赏的对手，无比孤独，{nw}{w=0.15}"
            yield return _gameMethods.ExecuteCharacterImageData("nv", parts: new List<string>{"mei5", "yan5", "zui9", "emoji2"});
            yield return _gameMethods.OpenDialog(734); // "于是自行解散了。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan2", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei4", "yan5", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei4", "yan5", "zui15", "emoji2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice3_2_ecdfc54d.ogg");
            yield return _gameMethods.OpenDialog(735); // "我觉得，更令人费解的是你的大脑。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan3", "zui17", "emoji2"});
            yield return _gameMethods.OpenDialog(736); // "我一脸无辜。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan16", "zui12"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei1", "yan3", "zui17", "emoji2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice3_2_2c894834.ogg");
            yield return _gameMethods.OpenDialog(737); // "……虽然这种猜想很荒谬，你不会是在有意戏弄我吧。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan16", "zui2"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -8f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 8f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/zhenjing_shuaidaoganjue.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei4", "yan5", "zui19", "-emoji2"});
            yield return _gameMethods.OpenDialog(738); // "绝对没有，"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui20"});
            yield return _gameMethods.OpenDialog(739); // "我怎么敢。"
            yield return _gameMethods.ChangeLabelTo("label_choice3");
        }

        public IEnumerator label_choice3_3()
        {
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/demo_audio/music/qingkuai1.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui19", "-emoji2"});
            yield return _gameMethods.OpenDialog(740); // "呃……我想，战争是政治的延续，是为了达到预定的政治目的而进行的？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(741); // "兽人部落联盟虽然攻下了城池，但损失惨重，"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(742); // "更重要的是，这与他们最初的战略目标南辕北辙。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan6", "zui10"});
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan6", "zui10"});
            yield return _gameMethods.OpenDialog(743); // "兽人真正需要的，是在冬季来临之前，从人类王国那里尽可能掠夺物资，"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui20"});
            yield return _gameMethods.OpenDialog(744); // "但他们花费巨大代价，攻下的却是几座根本不可能留下驻兵防守的城池。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan12", "zui7"});
            yield return _gameMethods.OpenDialog(745); // "所以，兽人之后就撤退了。"
            Defaults.Haogandu_he = Defaults.Haogandu_he + 5;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan17", "zui3"});
            yield return _gameMethods.OpenDialog(746); // "尽管他们打了胜仗，但没有得到实际利益，反而元气大损。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan2", "zui2"});
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.OpenDialog(747); // "他那双平静的眼睛里似乎闪过了一丝意外，和…那大概是愉悦吗？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui19"});
            yield return _gameMethods.StopEngineTime(time:0.6f);
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui19"});
            yield return _gameMethods.StopEngineTime(time:0.2f);
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice3_3_8371f051.ogg");
            yield return _gameMethods.OpenDialog(748); // "你确实是一位公主。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:5f);
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/wuyu.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan12", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(749); // "不，我只是每天在网上看时事新闻。"
            yield return _gameMethods.ChangeLabelTo("label_choice3");
        }

        public IEnumerator label_choice3()
        {
            if (Defaults.Daan_1 == 0)
            {
                                yield return _gameMethods.ChangeLabelTo("label_cuo1");

            }
            else
            {
                                yield return _gameMethods.ChangeLabelTo("label_dui1");

            }
        }

        public IEnumerator label_cuo1()
        {
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:6f);
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(750); // "赫泽尔合上了手中的书本。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(751); // "你似乎不太适合阅读这些书。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan12", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(752); // "不行了，接下来一定要打起精神！"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -8f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 8f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan2", "zui2", "emoji2"});
            yield return _gameMethods.OpenDialog(753); // "再给我一次机会！！下次肯定不会错了！"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan2", "zui8", "emoji2"});
            yield return _gameMethods.OpenDialog(754); // "我表现得宛如一条连输的赌狗。"
            yield return _gameMethods.ChangeLabelTo("label_dui1");
        }

        public IEnumerator label_dui1()
        {
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan11", "zui2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice5_1ee9a704_2.ogg");
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui2"});
            yield return _gameMethods.OpenDialog(755); // "赫泽尔再次低头看书。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/dui1_651fb458.ogg");
            yield return _gameMethods.OpenDialog(756); // "人类用三比一的损耗比，惨烈地结束了战争……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui9"});
            yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/demo_audio/music/qingkuai2.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(757); // "这次，我已经非常上道，学会了抢答。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui11"});
            yield return _gameMethods.OpenDialog(758); // "很值。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan3", "zui15"});
            yield return _gameMethods.OpenDialog(759); // "「兽人减少了十五万，人类减少了四十万，{nw}{w=0.15}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(760); // "局势对人类王国有利。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei7", "yan22", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan8", "zui9"});
            yield return _gameMethods.OpenDialog(761); // "「因为，人类王国总人口有八百万，{nw}{w=0.15}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(762); // "农耕经济很快能繁衍出损失的人口，伤筋不动骨。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan5", "zui10"});
            yield return _gameMethods.OpenDialog(763); // "「而兽人部落总人口只有不足一百万。{nw}{w=0.15}"
            Defaults.Haogandu_he = Defaults.Haogandu_he + 2;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan12", "zui9"});
            yield return _gameMethods.OpenDialog(764); // "/n减少的全都是青壮年，这将彻底拖垮他们的半渔猎经济。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui19"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei8", "yan12", "zui9"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/dui1_deece1dd.ogg");
            yield return _gameMethods.OpenDialog(765); // "嗯。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(766); // "他看着我，开始露出微笑。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui20"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/dui1_fd607ccb.ogg");
            yield return _gameMethods.OpenDialog(767); // "还有么。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui19"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan5", "zui11"});
            yield return _gameMethods.OpenDialog(768); // "更重要的是，兽人制度落后，各个部落向来是一盘散沙。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan6", "zui15"});
            yield return _gameMethods.OpenDialog(769); // "这次只是由于鹰族出了个军事天才，用声望和手段才把他们凝聚到了一起。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui2", "emoji0"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan18", "zui9"});
            yield return _gameMethods.OpenDialog(770); // "这场仗，兽人明明打赢了，但各个部落却都没有从中获得好处。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(771); // "所以他们对领袖颇为不满，后者在前二十年里所积累的名望一落千丈。/n联盟也随后分崩离析。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2", "-emoji0"});
            Defaults.Haogandu_he = Defaults.Haogandu_he + 3;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan12", "zui10"});
            yield return _gameMethods.OpenDialog(772); // "有过这次失败的前例，兽人部落至少两百年之内都不可能再被谁团结起来了。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui19"});
            yield return _gameMethods.ExecuteCharacterImageData("he_pangbai");
            yield return _gameMethods.OpenDialog(773); // "他似乎有点满意，好像完美地验证了自己想听到的结果一样。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan9", "zui20"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_qian");
            yield return _gameMethods.OpenDialog(774); // "{nw}{w=0.001}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/dui1_299d75bc.ogg");
            yield return _gameMethods.OpenDialog(775); // "你的想法和我一致。他们赢了军事，输了政治。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan9", "zui19"});
            yield return _gameMethods.EngineSetVolume(volume:0.2f, delay:0.5f, channelName:"music");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0f}})});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/zhenjing_shuaidaoganjue.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui8"});
            yield return _gameMethods.OpenDialog(776); // "{sc=2}{size=+10}为什么被带走还要考试啊。{/size}{/sc}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui7"});
            yield return _gameMethods.OpenDialog(777); // "考试。这个在脑中闪过的词汇随即在我的心里引起一连串遥远的回忆。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui7"});
            yield return _gameMethods.OpenDialog(778); // "那些属于另一个世界的记忆，似乎已经是很久很久以前的事情了，变得朦胧而不真实。"
            yield return _gameMethods.EngineSetVolume(volume:1f, delay:1f, channelName:"music");
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan19", "zui9", "emoji1"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan9", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/dui1_33d86492.ogg");
            yield return _gameMethods.OpenDialog(779); // "你在想什么？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan19", "zui2", "emoji1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui7"});
            yield return _gameMethods.OpenDialog(780); // "没什么。"
            yield return _gameMethods.OpenDialog(781); // "不过，我察觉到，这位高贵强大的龙，也许并不讨厌被忤逆。"
            yield return _gameMethods.OpenDialog(782); // "正相反，轻微适当的反驳，反而能够博得他的好印象。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan6", "zui7"});
            yield return _gameMethods.OpenDialog(783); // "我只是觉得，他们在军事上也输的一塌糊涂。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan9", "zui2", "-emoji1"});
            Defaults.Haogandu_he = Defaults.Haogandu_he + 2;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui8"});
            yield return _gameMethods.OpenDialog(784); // "毕竟军事的本质，就是为了获取国家在谈判桌上拿不到的东西。只要没达到目的，就是失败。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui8"});
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan9", "zui20"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan2", "zui8"});
            yield return _gameMethods.OpenDialog(785); // "「不错的观点。{nw}{w=0.001}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui20"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(786); // "/n世上拥有智慧的人不多，很高兴你是其中一个。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan9", "zui19"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan10", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(787); // "这么自恋。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan23", "zui19"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.EngineSetVolume(volume:0.2f, delay:1f, channelName:"music");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/daoju/shuben_bi.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}})});
            yield return _gameMethods.ShowBlack(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 2f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -200f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(788); // "接下来，由于对这个世界的具体历史缺乏了解，我问了他不少问题。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(789); // "令我惊讶的是，这位黑龙真的一一解答清楚了。"
            yield return _gameMethods.OpenDialog(790); // "并且，虽然他只会在偶尔吐露出一两句对书中内容的看法，但精准独到，的确对人类社会的运转规律有自己的理解。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan23", "zui2"});
            yield return _gameMethods.EngineSetVolume(volume:1f, delay:1f, channelName:"music");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/shuben_bi.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}}), new SameLineParamData(new Dictionary<string, object>{{"xalign", 0.45f}, {"ypos", 540f}})});
            yield return _gameMethods.HideBlack();
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(791); // "当赫泽尔读了差不多半小时，虽然他的表情没有任何波动，但我明智地意识到应该适可而止。"
            yield return _gameMethods.OpenDialog(792); // "以防我的顶头上司感到厌烦。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui1"});
            yield return _gameMethods.OpenDialog(793); // "「很精彩。{nw}{w=0.15}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan11", "zui1"});
            yield return _gameMethods.OpenDialog(794); // "/n没想到你对人类社会有这么深刻透彻的理解。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui6"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/dui1_9e61dd93.ogg");
            yield return _gameMethods.OpenDialog(795); // "……我读过这里的所有书。"
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(796); // "并且，我所吸纳的仇恨、恐惧与愤怒中也有人类贡献的成分。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 10f}, {"zpos", -593.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.11f}, {"ypos", -2f}, {"zpos", -605.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(797); // "真的呀？"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan17", "zui19"});
            yield return _gameMethods.OpenDialog(798); // "我还以为人类对龙微不足道，你不会太感兴趣呢。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -2f}, {"zpos", -605.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan17", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/dui1_b74fc97c.ogg");
            yield return _gameMethods.OpenDialog(799); // "实际上，在所有智慧种族中，人类为我贡献了最多的力量。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -8f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 8f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(800); // "！真的吗？"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan24", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(801); // "……怎么回事，好像也自豪不起来啊。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan8", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/dui1_db1a1870.ogg");
            yield return _gameMethods.OpenDialog(802); // "在所有种族里，比人类生命更短的只有矮人，但他们社会组织简单，情绪也不复杂。"
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan5", "zui14", "-emoji2"});
            yield return _gameMethods.OpenDialog(803); // "精灵与龙的寿命都太长，不足以为遇到的一切产生太多波动。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(804); // "只有人类，日复一日地分分合合，重演历史。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(805); // "听起来你对人类的印象并不算太好。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/dui1_599c600e.ogg");
            yield return _gameMethods.OpenDialog(806); // "你的错觉，我对种族没有偏见。它们只是各有特点罢了。"
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:2f);
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/daoju/shuben_bi.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}})});
            yield return _gameMethods.Scene("black", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 2f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -200f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.PlaySound("soundb", 0.0f, 1.0f, "audio/demo_audio/sound/niaoming.ogg");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/tiankong_baitian.jpg");
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(807); // "这几天里，赫泽尔基本除了睡觉，就是读书打发时间，活动安静极了。"
            yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/demo_audio/music/richang1.mp3");
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:3f);
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_shufang_baitian_quanjing.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveTime", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.0f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.68f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(808); // "当他前往图书室，我就会跟着。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(809); // "然后视情况决定是否顺竿爬梯，拜托他将手中正读的书念一段给我听。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan12", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(810); // "所幸，他看起来对这种请求不算讨厌，只是会时不时地提出几个问题，查验我对书中内容的看法。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(811); // "每当我说出一些算是有趣的见解，虽然他的表情没什么太大幅度的变化，但能感觉到心情变得不错。"
            yield return _gameMethods.OpenDialog(812); // "我留意到，他给我念书的时间越来越久。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(813); // "第一天是半小时。"
            Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(814); // "第二天，差不多一小时。"
            Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(815); // "第三天有两个多小时。"
            Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_shufang_bangwan_quanjing.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}, {"subpixel", true}, {"pos", new Vector2(0.5f, 1.0f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.68f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(816); // "到了第四天，我们在这种他读我听、间或交流几句观点的模式中自然地度过了整个下午。"
            yield return _gameMethods.ExecuteShowScreenFunction("stop_screen", functionParams: new List<object>{1f});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_shufang_bangwan_quanjing.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/tiankong_bangwan.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"alpha", 1f}})});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice5_7defadbb.ogg");
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1.5>audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.ExecuteShowScreenFunction("stop_screen", functionParams: new List<object>{1.5f});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/tiankong_yewan.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}, {"zoom", 1.4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.5f}, {"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(491); // "………………"
            yield return _gameMethods.Hide("stop_screen");
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/door_close1.mp3");
            yield return _gameMethods.Scene("woshi_nv_yeyan_layered", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "dissolve"}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.25f, 0.39f)}, {"zoom", 0.5f}})});
            yield return _gameMethods.OpenDialog(481); // "……………………"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(817); // "得益于可以逐字逐句地对照发音和书面文字。我的识字能力有了十足的长进。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(818); // "在此之前，我基本没可能找到一个愿意长时间为我念诵书本的人。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(819); // "识字的人大多是贵族或家境不错的体面平民，身价都很高，我雇佣不起。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(820); // "没想到，反而是在这种情况下，我得到了老师——一条货真价实的龙。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan24", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(821); // "虽然，代价是要面对他令人提心吊胆的提问。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(822); // "好在直到目前为止，我做得都还算过关。"
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:2f);
            yield return _gameMethods.SceneBlack(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "dissolve"}})});
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.OpenDialog(491); // "………………"
            Defaults.Haogandu_an = Defaults.Haogandu_an + 1;
            yield return _gameMethods.OpenDialog(823); // "几天转瞬即逝。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 2>audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_shufang_bangwan_quanjing.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "dissolve"}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"zoom", 0.71f}})});
            Defaults.Persistent.Jq_1_6 = 1;
            yield return _gameMethods.OpenDialog(824); // "这一天，我洗完了头，来到书房。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui15"});
            yield return _gameMethods.OpenDialog(825); // "我没有留太长的头发，因为洗头后不方便晾干，影响干活。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(826); // "但也不敢剪太短，以防遭受周围人的异样眼光。"
            yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/demo_audio/music/youshang2.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(827); // "除了有条件精心打理长得离谱的长发的贵族之外，平民的头发稍短一点是合理现象，但依然很少有女性的头发短过肩膀。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(828); // "而在市井之间生活，必须融入群体，不能遭受排斥。"
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_shufang_bangwan_shafa1.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(-348f, -522f)}, {"zoom", 0.96f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan23", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 2.22f)}, {"zoom", 0.44f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(829); // "赫泽尔一如前几日，正在这里阅读。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan23", "zui2"});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/book1.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(830); // "当我到来时，他刚巧翻过手中的一张书页，"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan9", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(831); // "于是有余暇抬起头分给了我一道目光。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(832); // "我盯着他卷曲的黑发，心中突然萌生出一个大胆的想法。"
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:4f);
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1>audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}, {"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"bopOutTimeWarp", 0.6f}, {"ypos", -30f}, {"zpos", -100.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(833); // "我可以给你梳理头发么？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -30f}, {"zpos", -100.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(834); // "他似乎对我偶尔突如其来的发言有些习惯了，面不改色。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice5_6bbbadbe.ogg");
            yield return _gameMethods.OpenDialog(663); // "为什么。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui1"});
            yield return _gameMethods.OpenDialog(835); // "就是想？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan4", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(836); // "我找了新的阶段目标，立刻卖力地劝说起来，/n宛如一名充满了激情的按摩技师兼推销员。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(837); // "「我的手艺很好的，试一下吧，客人，{nw}{w=0.15}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan5", "zui19"});
            yield return _gameMethods.OpenDialog(838); // "/n如果是你这么招人喜欢的龙，特别算你免费噢。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei4", "yan25", "zui18"});
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.5f, "audio/demo_audio/sound/book2_he.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan5", "zui8"});
            yield return _gameMethods.OpenDialog(670); // "「……{nw}{w=0.001}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(839); // "………随便你。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(840); // "得到许可，我来了精神。"
            Defaults.Gui_duihuakuang_you = 0;
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1>audio/sound/jiaobusheng_xin_kuai1.ogg");
            yield return _gameMethods.Hide("he");
            yield return _gameMethods.Show("shutou_zoom");
            yield return _gameMethods.Hide("shutou_zoom");
            yield return _gameMethods.Show("heilong_shufang_bangwan_shafa1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"blur", 14.43f}})});
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"ditu1", "he_yan_xiao_qian", "he_mei_putong", "he_zui_bi", "nv_mei_putong", "nv_yan_dazheng", "nv_zui_weixiao"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 0.9f)}, {"zoom", 0.55f}})});
            
            yield return _gameMethods.OpenDialog(841); // "三两步跑到他的身后，我拿出这几日勇于探索为我自己赢得的战利品——"
            yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/demo_audio/music/richang2.mp3");
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"ditu2", "-nv_yan_dazheng"});
            yield return _gameMethods.OpenDialog(842); // "一把从城堡女主人房间里找到的象牙梳，细致地梳理起他乌黑的卷发。"
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"he_yan_zhong_qian"});
            yield return _gameMethods.OpenDialog(843); // "和龙鳞一样，他的黑发上渲染着色彩华丽的光泽。"
            yield return _gameMethods.OpenDialog(844); // "这个孩子的发质比较硬，但发丝丰密、柔顺且滑亮得像打了蜡似的，触感既不干涩，也不油腻，仿佛某种名贵的大型猫科动物的皮毛。"
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"nv_yan_weizheng_hou", "nv_emoji_han"});
            yield return _gameMethods.OpenDialog(845); // "……有点上瘾。"
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice5_7defadbb_1.ogg");
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"-nv_yan_weizheng_hou"});
            Defaults.Haogandu_he = Defaults.Haogandu_he + 2;
            yield return _gameMethods.OpenDialog(846); // "我用手指梳理蓬松泛卷的黑发，指尖偶尔会轻轻触碰到他的头皮或耳畔。"
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"nv_yan_dazheng"});
            yield return _gameMethods.OpenDialog(847); // "偷眼瞧了瞧他的表情。"
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"he_yan_weizheng"});
            yield return _gameMethods.OpenDialog(848); // "他微微眯起了眼睛，一副被撸得合心的猫感到舒适的模样。"
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"-nv_emoji_han"});
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/moca2.mp3");
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"ditu1", "nv_yan_dazheng"});
            yield return _gameMethods.OpenDialog(849); // "担心惹他厌烦，过了差不多五六分钟，我便适可而止地停下了动作。"
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"nv_zui_zhangzui_xiao", "nv_mei_zhoumei"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(850); // "感觉怎么样？"
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"nv_zui_weixiao"});
            yield return _gameMethods.ExecuteCharacterImageData("he_qian");
            yield return _gameMethods.OpenDialog(670); // "「……{nw}{w=0.001}"
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"he_zui_kai2", "he_yan_zhong_qian"});
            yield return _gameMethods.ExecuteCharacterImageData("he_qian");
            yield return _gameMethods.OpenDialog(851); // "不算讨厌。」"
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"he_zui_bi"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"he_zui_kai", "he_yan_zhong_hou"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(852); // "从来没有别的生物摸过我的头顶。"
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"nv_zui_zhangzui_xiao", "nv_yan_dadazheng", "nv_mei_fangsong", "he_zui_bi"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(853); // "哇，我居然能享受此种殊荣！"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.StopSound(channelName:"music");
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"nv_emoji_han"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.ShowBlack(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "dissolve"}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei2", "yan24", "zui7", "emoiji2"});
            yield return _gameMethods.OpenDialog(854); // "沉默半响，我不禁捂住了半边脸。"
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"nv_emoji_han", "nv_mei_zhoumei", "nv_yan_dazheng", "nv_zui_zhangzui", "he_yan_zhong_qian"});
            yield return _gameMethods.HideBlack(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "dissolve"}})});
            yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/demo_audio/music/qingkuai2.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(855); // "…………对不起，忘了吧。/n我忏悔，不该对你开这种玩笑的。"
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"nv_yan_dazheng_hou"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(856); // "就算我们共处一段时间了这也依旧很冒犯。"
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"-nv_yan_dazheng_hou", "nv_zui_bi_xia"});
            yield return _gameMethods.OpenDialog(857); // "身处此种境地，我却得意忘形，不知轻重。"
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"he_mei_putong", "he_yan_zhong_hou", "he_zui_kai2"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(858); // "？为什么冒犯。"
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"he_zui_bi"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"he_zui_kai"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(859); // "解释。"
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"nv_zui_zhangzui_xiao", "he_zui_bi"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(860); // "呃……"
            yield return _gameMethods.OpenDialog(861); // "深刻地体会到了进退两难的滋味。"
            yield return _gameMethods.OpenDialog(862); // "怎么办呢……"
            yield return _gameMethods.OpenSelectMenu(talk: new List<string>{"-诚实如实解释", "-瞎编"}, jump: new List<string>{"label_zhuxian_1_menu_0_LuOjSnIg", "label_zhuxian_1_menu_0_GINq6KpU"}, condition: new List<string>{"NONE", "NONE"});
        }

        public IEnumerator label_choice4()
        {
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"nv_yan_dazheng", "nv_zui_bi_xia", "nv_mei_putong", "he_zui_bi"});
            yield return _gameMethods.OpenDialog(871); // "我斟酌了一下措辞。"
            Defaults.Haogandu_he = Defaults.Haogandu_he + 2;
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"nv_zui_zhangzui", "nv_yan_dadazheng", "-nv_emoji_han", "ditu2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(872); // "你知道在人类王国，两人即便相互熟悉，也要保持礼仪上的克制吗？"
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"he_yan_zhong_qian", "he_zui_kai", "nv_zui_bi_xia"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice4_6f8c172b.ogg");
            yield return _gameMethods.OpenDialog(873); // "那是什么。"
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"he_zui_bi", "nv_yan_dazheng", "nv_zui_zhangzui"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(874); // "……就是，尽管我们已经相互有所了解，但鉴于我们的关系，我不应该这样忘乎所以。"
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"nv_zui_bi_xia", "nv_yan_weizheng"});
            yield return _gameMethods.EngineSetVolume(volume:0.4f, delay:1f, channelName:"music");
            yield return _gameMethods.OpenDialog(875); // "这也是我母亲带我离开了原本的那个庄园主，来到王都的原因之一。"
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"he_yan_zhong_hou", "he_zui_kai2", "he_mei_putong"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(876); // "你们人类的日常来往都必须如此拘谨？"
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"nv_zui_zhangzui", "he_zui_bi"});
            yield return _gameMethods.EngineSetVolume(volume:1f, delay:1f, channelName:"music");
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(877); // "这倒是没那么严重，只是部分情况会如此。"
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"nv_zui_bi_xia", "he_zui_kai2"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(878); // "如果不是所有情况，这个规范又有什么意义？"
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"he_zui_bi", "nv_emoji_han"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.OpenDialog(879); // "这个问题成功地让我沉默了。"
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"-nv_yan_weizheng", "nv_mei_xie", "nv_zui_weixiao", "ditu1"});
            yield return _gameMethods.OpenDialog(880); // "……救命，现在就想消失。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -6f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 6f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", -2f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0f}})});
            yield return _gameMethods.OpenDialog(881); // "为什么我必须给带走了我的恶龙上礼节课啊。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"nv_zui_zhangzui_xiao"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(882); // "我也不清楚呢。总之，从社交场合中，延伸出了这个说法。"
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"nv_zui_weixiao"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"he_yan_xiao_hou", "he_mei_nu"});
            yield return _gameMethods.OpenDialog(883); // "他用一种“你好怪”的眼神看我。"
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"he_zui_kai"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(884); // "我是龙，不适用这条规范。"
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"he_zui_bi", "nv_yan_dadazheng", "nv_zui_zhangzui_xiao"});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/zhenjing_shuaidaoganjue.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -6f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 6f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", -2f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0f}})});
            yield return _gameMethods.OpenDialog(885); // "{outlinecolor=#000}{sc=2}{size=+10}我也没想让你遵守！！！{/size}{/sc}{/outlinecolor}"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"nv_yan_dadazheng", "nv_zui_bi_xia"});
            yield return _gameMethods.OpenDialog(886); // "……好吧，看怪人的眼神总比看冒失之人的眼神要好上一些。"
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"nv_zui_zhangzui", "-nv_emoji_han", "nv_mei_zhoumei", "he_mei_chennu"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(887); // "总之，如果你喜欢，我很乐意以后继续为你梳理头发。"
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"he_yan_xiao_qian", "he_zui_kai", "nv_zui_bi_xia"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice4_7a6652e6.ogg");
            yield return _gameMethods.OpenDialog(888); // "我没有说过喜欢。"
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"he_zui_bi", "nv_zui_weixiao"});
            yield return _gameMethods.OpenDialog(889); // "我从善如流地改口。"
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"ditu2", "nv_zui_zhangzui_xiao", "he_mei_chennu"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(890); // "那如果你不讨厌，我们以后可以再这样做。"
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"nv_zui_weixiao"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"he_zui_kai"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice4_32233700.ogg");
            yield return _gameMethods.OpenDialog(891); // "………有机会吧。"
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"nv_mei_xie", "-nv_yan_dadazheng", "nv_zui_zhangzui_xiao", "he_zui_bi"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(892); // "太好了。"
            yield return _gameMethods.ExecuteCharacterImageData("he_qian");
            yield return _gameMethods.OpenDialog(670); // "「……{nw}{w=0.001}"
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"nv_zui_weixiao", "he_zui_kai2", "he_yan_da_qian"});
            yield return _gameMethods.ExecuteCharacterImageData("he_qian");
            yield return _gameMethods.OpenDialog(893); // "为什么这么说。」"
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"he_zui_bi", "nv_zui_zhangzui_xiao"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(894); // "啊，因为我很开心。"
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"nv_yan_dazheng"});
            Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(895); // "/n给赫泽尔梳头，就好像我们很亲近一样。"
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"he_yan_zhong_qian", "nv_zui_weixiao"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"nv_zui_zhangzui", "nv_yan_dazheng_hou", "nv_mei_zhoumei"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(896); // "而且——"
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"he_yan_zhong_hou"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(594); // "？"
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"nv_zui_zhangzui_xiao", "nv_yan_dadazheng", "nv_mei_putong"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(897); // "而且你的头发很顺滑，手感超级好，简直能治愈人心。"
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"-nv_yan_dadazheng", "nv_zui_weixiao"});
            yield return _gameMethods.OpenDialog(898); // "就像撸猫一样。"
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"nv_zui_weixiao", "he_yan_xiao_hou", "he_zui_kai2"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice4_51206114.ogg");
            yield return _gameMethods.OpenDialog(899); // "……我是灾厄之龙。"
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"he_zui_bi"});
            yield return _gameMethods.OpenDialog(900); // "他看着我，就像在说“我没有这个功能”。"
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"nv_yan_dadazheng", "nv_mei_zhoumei", "nv_zui_zhangzui_xiao"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(901); // "太伟大了，灾厄之龙大人。"
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"nv_zui_weixiao", "he_yan_xiao_qian"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.Show("cg_layered_shutou", parts: new List<string>{"he_mei_putong"});
            yield return _gameMethods.OpenDialog(902); // "赫泽尔低头看书，不再说话了。"
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:3f);
            yield return _gameMethods.ShowBlack();
            yield return _gameMethods.Transition();
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/tiankong_baitian.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "dissolve"}})});
            yield return _gameMethods.PlaySound("soundc", 0.0f, 1.0f, "audio/demo_audio/sound/chanming.ogg");
            Defaults.Gui_duihuakuang_you = 1;
            Defaults.Haogandu_an = Defaults.Haogandu_an + 1;
            yield return _gameMethods.OpenDialog(903); // "一周的时光一瞬即逝，我差不多习惯了在城堡的生活。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/tiankong_bangwan.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 2f}, {"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/tiankong_yewan.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}, {"zoom", 1.3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 2f}, {"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.StopSound(channelName:"soundc", fadeOut:1f);
            yield return _gameMethods.SceneBlack(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "dissolve"}})});
            yield return _gameMethods.OpenDialog(904); // "夏日的天气总是多变。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/lachuanglian.mp3", "audio/demo_audio/sound/zu2.ogg");
            yield return _gameMethods.PlaySound("soundb", 5f, 1f, "audio/demo_audio/sound/yu1.ogg");
            yield return _gameMethods.PlaySound("soundc", 5f, 2f, "audio/demo_audio/sound/leisheng_gun1.ogg");
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.5f, saturationMatrix:1.0f, brightnessMatrix:-0.18f, hueMatrix:0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.2f}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.0f, saturationMatrix:1.0f, brightnessMatrix:0.0f, hueMatrix:0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.8f}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.5f, saturationMatrix:1.0f, brightnessMatrix:-0.18f, hueMatrix:0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.8f}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.0f, saturationMatrix:1.0f, brightnessMatrix:0.0f, hueMatrix:0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.5f, saturationMatrix:1.0f, brightnessMatrix:-0.18f, hueMatrix:0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.0f, saturationMatrix:1.0f, brightnessMatrix:0.0f, hueMatrix:0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.5f, saturationMatrix:1.0f, brightnessMatrix:-0.18f, hueMatrix:0.0f)}})});
            yield return _gameMethods.Scene("woshi_nv1_b_ani", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "dissolve"}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.4f, 0.17f)}, {"zoom", 1.67f}})});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.5f, "audio/demo_audio/sound/leisheng1.mp3");
            Defaults.Persistent.Jq_2_1 = 1;
            yield return _gameMethods.OpenDialog(905); // "我拉开窗帘，看向窗外。"
            yield return _gameMethods.OpenDialog(906); // "暴风骤雨。"
            yield return _gameMethods.OpenDialog(907); // "每次这种天气我都很害怕。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.5f, "audio/demo_audio/sound/leisheng1.mp3");
            yield return _gameMethods.Show("woshi_nv1_b_ani", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "dissolve"}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.4f, 0.17f)}, {"zoom", 1.67f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.5f, saturationMatrix:1.0f, brightnessMatrix:-0.18f, hueMatrix:0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.0f}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.0f, saturationMatrix:1.0f, brightnessMatrix:0.0f, hueMatrix:0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.8f}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.5f, saturationMatrix:1.0f, brightnessMatrix:-0.18f, hueMatrix:0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.8f}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.0f, saturationMatrix:1.0f, brightnessMatrix:0.0f, hueMatrix:0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.5f, saturationMatrix:1.0f, brightnessMatrix:-0.18f, hueMatrix:0.0f)}})});
            yield return _gameMethods.OpenDialog(908); // "并不是本身怕打雷，/n只是会担心屋顶可能被雷劈中，可能漏雨潮湿，/n到了雨后，家里也会冒出各种各样的虫子。"
            yield return _gameMethods.OpenDialog(909); // "尤其在夏天，身处于这个没有纱窗纱帘的世界里，除非勤奋地时时用苦艾熏遍整个屋子，否则基本不可能阻止蚊虫的登门入室。"
            yield return _gameMethods.OpenDialog(910); // "至于卫生条件更落后的乡村，人们身上普遍存在跳蚤也并不奇怪……"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.88f}, {"xpos", 288f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.88f}, {"ypos", 372f}})}, parallel_2: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.5f, saturationMatrix:1.0f, brightnessMatrix:-0.18f, hueMatrix:0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.88f}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.3f, saturationMatrix:1.0f, brightnessMatrix:-0.05f, hueMatrix:0.0f)}})});
            yield return _gameMethods.OpenDialog(911); // "而此时，此刻。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(288f, 372f)}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(288f, 372f)}, {"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 2f}, {"pos", new Vector2(480f, 456f)}, {"zoom", 1.07f}})});
            yield return _gameMethods.OpenDialog(912); // "我位于城堡内部，魔力装置正在平稳运行，室内温暖而干燥。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(480f, 456f)}, {"zoom", 1.07f}})});
            yield return _gameMethods.OpenDialog(913); // "不知是不是什么驱逐阵法的作用，城堡里也从没出现过蚊虫。/n……在王宫里时同样如此。"
            yield return _gameMethods.OpenDialog(914); // "……再一次，感受到了这个世界上存在的差别。"
            yield return _gameMethods.OpenDialog(915); // "关于力量，关于差异。"
            yield return _gameMethods.OpenDialog(916); // "听着外面的雷声，我意识到，这也许是一次机会。"
            yield return _gameMethods.OpenDialog(917); // "或许我能以此为借口，试着进一步拉近与赫泽尔之间的距离。"
            yield return _gameMethods.OpenDialog(918); // "毕竟，他愿意让我为他梳头——这头龙似乎不是那么难以接近。"
            yield return _gameMethods.OpenDialog(919); // "而通过对话，能发现他没什么礼节意识，这意味着，一些更亲密的举动不会为我带来额外的风险。"
            yield return _gameMethods.OpenDialog(920); // "那么，我是不是有可能成为他的朋友、家人，邻家姐姐……——成为一名，让他难以割舍的人呢？"
            yield return _gameMethods.OpenDialog(921); // "我呼了口气，抱上枕头。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1f, saturationMatrix:1.0f, brightnessMatrix:0f, hueMatrix:0.0f)}})});
            yield return _gameMethods.PlaySound("soundd", 0.0f, 1.0f, "audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/zoulang_guodao1.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "trans_rip_fast"}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.8f, 1.69f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.67f}})});
            yield return _gameMethods.EngineSetVolume(volume:0.4f, delay:1f, channelName:"soundb");
            yield return _gameMethods.StopSound(channelName:"soundc", fadeOut:2f);
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/zoulang_zhuanjiao2.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "trans_rip_fast"}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.87f, 1.87f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.75f}})});
            yield return _gameMethods.OpenDialog(491); // "………………"
            yield return _gameMethods.StopSound(channelName:"soundd", fadeOut:1f);
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/woshi_men1.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "trans_rip_fast"}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.83f, 1.73f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 1.27f}})});
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.5f, "audio/demo_audio/sound/zu2.ogg");
            yield return _gameMethods.OpenDialog(922); // "来到了赫泽尔卧室的门口。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/woshi_men3.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}, {"pos", new Vector2(408f, 402f)}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/hand_nv.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveTime", 0.8f}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.8f, 1.66f)}})});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/door_qiao1.mp3");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/woshi_men1.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.91f, 2.71f)}, {"zoom", 2.94f}})});
            yield return _gameMethods.Show("hand_biao_ani", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.79f, 1.59f)}})});
            yield return _gameMethods.OpenDialog(923); // "敲响房门。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 414f}})});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1>audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/zoulang_guodao1.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/zoulang_zhuanjiao2.jpg");
            yield return _gameMethods.Hide("woshi_nv1_b_ani");
            yield return _gameMethods.Hide("hand_biao_ani");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/daoju/hand_nv.png");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/woshi_men3.jpg");
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.OpenDialog(491); // "………………"
            yield return _gameMethods.EngineSetVolume(volume:0.2f, delay:1f, channelName:"soundb");
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/door_open_3.mp3");
            yield return _gameMethods.Show("woshi_he1_ani", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(-0.05f, 0.83f)}, {"zpos", -198.0f}, {"zoom", 0.61f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.75f, 2.52f)}, {"zoom", 0.38f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/woshi_men2.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1f)}, {"pos", new Vector2(1146f, 176f)}, {"zoom", 1.15f}})});
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/woshi_men1.jpg");
            yield return _gameMethods.Transition(time:1f);
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(924); // "……？"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1>audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"zpos", -126.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui19"});
            yield return _gameMethods.OpenDialog(925); // "晚上好。我有个提议。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei4", "yan5", "zui19"});
            yield return _gameMethods.OpenDialog(926); // "我们来开枕头派对吧！"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -126.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei4", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(927); // "那是什么东西。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.PlaySound("music", 0.0f, 0.5f, "audio/demo_audio/music/qingkuai3.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui2"});
            yield return _gameMethods.OpenDialog(928); // "就是睡前大家一起聊天的活动。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui8"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice4_59fb6c17.ogg");
            yield return _gameMethods.OpenDialog(929); // "这个活动有什么意义。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan18", "zui3", "emoji2"});
            yield return _gameMethods.OpenDialog(930); // "拉近感情？"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(931); // "其实这是个借口，我只是想和你一起睡。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei7", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan5", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(924); // "……？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei7", "yan3", "zui2"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei2", "yan5", "zui10", "-emoji2"});
            yield return _gameMethods.OpenDialog(932); // "我害怕打雷，所以现在如果没有你陪着，我会睡不着的。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 456f}, {"zpos", -126.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.40f}, {"ypos", 450f}, {"zpos", -162.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei2", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(933); // "虽然是撒谎的。/n我一脸诚恳，双手深情地交握在胸前。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 450f}, {"zpos", -162.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei2", "yan17", "zui11"});
            yield return _gameMethods.OpenDialog(934); // "拜托了，"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei2", "yan11", "zui12"});
            yield return _gameMethods.OpenDialog(935); // "赫泽尔，这是我一生只有一次的请求！"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan4", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei2", "yan17", "zui14"});
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan4", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei9", "yan5", "zui14", "emoji7", "emoji17"});
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1>audio/demo_audio/sound/zu3_nv_zou.ogg");
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan8", "zui9"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.9f}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", -54.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice4_058269ba.ogg");
            yield return _gameMethods.OpenDialog(936); // "进来吧。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan8", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", -54.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19", "emoji10", "-emoji7", "-emoji17"});
            yield return _gameMethods.OpenDialog(937); // "太棒了！"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui19", "emoji10"});
            yield return _gameMethods.OpenDialog(938); // "谢谢你，你今天真帅。"
            yield return _gameMethods.SceneBlack(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "dissolve"}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 3f}})});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/door_close1.mp3");
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg13_memory.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg13_memory.jpg");
            yield return _gameMethods.Scene("woshi_he1_ani", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "dissolve"}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.13f, 0.94f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.49f}})});
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.OpenDialog(939); // "这只是一个普通的人类贵族房间。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(414f, 450f)}, {"zoom", 1.07f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.94f}, {"pos", new Vector2(-186f, 882f)}, {"zoom", 1.46f}})});
            yield return _gameMethods.StopEngineTime(time:2.04f);
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-186f, 882f)}, {"zoom", 1.46f}})});
            yield return _gameMethods.SetDialogUIShowOrHide("show");
            yield return _gameMethods.OpenDialog(940); // "里面有张巨大豪华的软床。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-186f, 882f)}, {"zoom", 1.46f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -162.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.54f}, {"zpos", -204.0f}})});
            yield return _gameMethods.OpenDialog(941); // "这床没什么奇怪之处。但对于主人的身份，它便似乎有些过于普通了。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -204.0f}})});
            yield return _gameMethods.OpenDialog(942); // "我好奇地打量。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui15", "-emoji10"});
            yield return _gameMethods.OpenDialog(943); // "原来你也睡床啊。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "dissolve"}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.29f, 2.03f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.22f}, {"xoffset", 100f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 1f}, {"xoffset", 0f}})});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 2>audio/demo_audio/sound/zu3_nv_zou.ogg");
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(944); // "不睡床睡哪里。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei1", "yan5", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(945); // "……不是，我以为你们龙会睡在洞窟里，或者随便空地就能睡。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan4", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei1", "yan5", "zui7", "emoji2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice4_0ae9746e.ogg");
            yield return _gameMethods.OpenDialog(946); // "？地面上有沙石，那样会很不舒服。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan4", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan12", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(947); // "……抱歉，是我考虑不周。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei3", "yan12", "zui7", "emoji2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice4_0047c3ae.ogg");
            yield return _gameMethods.OpenDialog(948); // "没事，我原谅你。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 882f}, {"zpos", -204.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.38f}, {"ypos", 840f}, {"zpos", -276.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui19", "-emoji2"});
            yield return _gameMethods.OpenDialog(949); // "我能和你睡一张床吗。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 840f}, {"zpos", -276.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(950); // "「没有别的意思，{nw}{w=0.15}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei3", "yan7", "zui19"});
            yield return _gameMethods.OpenDialog(951); // "主要就是想替我最喜欢的赫泽尔守夜。」"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei4", "yan5", "zui10"});
            yield return _gameMethods.OpenDialog(952); // "「如果有敌人想来伤害你，{nw}{w=0.15}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei4", "yan5", "zui10", "emoji7"});
            yield return _gameMethods.OpenDialog(953); // "就要先越过我。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei4", "yan5", "zui15", "emoji7"});
            yield return _gameMethods.OpenDialog(954); // "你力气不够。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei9", "yan11", "zui19", "-emoji7", "emoji2"});
            yield return _gameMethods.OpenDialog(955); // "……太不留情面了吧！"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei6", "yan5", "zui10", "-emoji2"});
            yield return _gameMethods.OpenDialog(956); // "/n那我能睡床吗。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei6", "yan5", "zui14"});
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan23", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.29f, 2.03f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.22f}, {"xoffset", 0f}, {"alpha", 1f}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ease", 1f}, {"xoffset", 100f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.9f}, {"alpha", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.1f}, {"alpha", 0f}})});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 2>audio/demo_audio/sound/zu3_nv_zou.ogg");
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(631); // "「……{nw}{w=0.15}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice4_845fb695.ogg");
            yield return _gameMethods.OpenDialog(957); // "上来吧。」"
            yield return _gameMethods.Hide("he", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "dissolve"}})});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/moca1.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-186f, 840f)}, {"zoom", 1.46f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.5f}, {"pos", new Vector2(-192f, 1386f)}, {"zoom", 2.16f}})});
            yield return _gameMethods.OpenDialog(958); // "我快乐地跳上了床，挪到一旁，给我的顶头上司留出位置。"
            yield return _gameMethods.EngineSetVolume(volume:0f, delay:1f, channelName:"music");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-192f, 1386f)}, {"zoom", 2.16f}})});
            yield return _gameMethods.ShowBlack(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "dissolve"}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 4f}})});
            yield return _gameMethods.OpenDialog(959); // "他站在床边，以一种仿佛在看自己无法理解的新奇生物"
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(960); // "——或者新奇的事物一"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/tangxia1.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(961); // "般的眼神，无言地盯了我两秒，才躺到我身侧。"
            Defaults.Gui_duihuakuang_you = 0;
            yield return _gameMethods.EngineSetVolume(volume:0.5f, delay:1f, channelName:"music");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Show("sleep_zoom");
            yield return _gameMethods.Hide("sleep_zoom");
            yield return _gameMethods.Scene("biao_he_yan2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"fade", new RenpyFade(0.2f, 0.2f, 1f, "#fff")}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.5f}})});
            yield return _gameMethods.OpenDialog(962); // "我翻身面向他，脸上笑容盈盈。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(0f, 0f)}, {"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"pos", new Vector2(138f, 24f)}, {"zoom", 1.2f}})});
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_yan1"});
            yield return _gameMethods.OpenDialog(963); // "他察觉到了，微微侧过脸来，没有表情地回以视线，似乎在问我“做什么”。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(138f, 24f)}, {"zoom", 1.2f}})});
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_nv1", "gaoguang_zheng"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "dissolve"}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(964); // "赫泽尔。"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(594); // "？"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_nv2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(965); // "我有点怕，能握住你的手吗。"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice4_15d3b0cf.ogg");
            yield return _gameMethods.OpenDialog(966); // "你笑得很灿烂，看不出在害怕的意思。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.7f, "audio/demo_audio/sound/moca2.mp3");
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_nv5", "gaoguang_bi"});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_cg/sleep/sleep_zhentou.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "dissolve"}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.5f}})});
            yield return _gameMethods.OpenDialog(967); // "我立刻露出一副痛不欲生的苦瓜脸，绝望凄惨地抱紧了枕头。"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_yan2", "biao_he_zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_yan3", "biao_he_zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice4_e18888fe.ogg");
            yield return _gameMethods.OpenDialog(968); // "……随你吧。"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_nv2", "gaoguang_zheng", "biao_he_zui1"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(138f, 24f)}, {"zoom", 1.2f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"pos", new Vector2(0f, 0f)}, {"zoom", 1.0f}})});
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.5f, "audio/demo_audio/sound/moca2.mp3");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_cg/sleep/sleep_zhentou.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "dissolve"}})});
            yield return _gameMethods.OpenDialog(969); // "得到首肯，我便大大方方探出了手臂，去拉他放在被子上的手。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(0f, 0f)}, {"zoom", 1.0f}})});
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"ditu2", "biao_nv1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "dissolve"}})});
            yield return _gameMethods.OpenDialog(970); // "……抓住了。"
            yield return _gameMethods.OpenDialog(971); // "好凉。"
            yield return _gameMethods.OpenDialog(972); // "他没有反应。"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_nv3", "gaoguang_bi"});
            yield return _gameMethods.OpenDialog(973); // "也就是没有拒绝。"
            yield return _gameMethods.OpenDialog(974); // "他的手同人类幼童的手别无二致，皮肤柔软，/n手掌比我小了一号，指甲整整齐齐。"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_nv1", "gaoguang_zheng"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(964); // "赫泽尔。"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_yan1", "biao_he_zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice4_eaa8fe19.ogg");
            yield return _gameMethods.OpenDialog(975); // "嗯？"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(976); // "你的手好冰。"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice4_21fe6c93.ogg");
            yield return _gameMethods.OpenDialog(977); // "龙族的血液温度低于人类，除了火龙等少数族类。"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_zui1", "biao_nv3", "gaoguang_bi"});
            yield return _gameMethods.OpenDialog(978); // "……确实，蜥蜴好像是冷血动物。"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_nv1", "gaoguang_zheng"});
            yield return _gameMethods.OpenDialog(979); // "大型蜥蜴应该也没有例外。"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_zui2", "biao_he_yan3"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(980); // "你的手，很热。"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_nv2", "biao_he_zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(981); // "因为我是热血动物。"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_nv4", "gaoguang_bi"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(982); // "那和我贴在一起，会不会让你感到不舒服？"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_zui2", "biao_nv3", "biao_he_yan2"});
            Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice4_e89aa975.ogg");
            yield return _gameMethods.OpenDialog(983); // "不会。只是有点奇怪。"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_nv2", "gaoguang_zheng", "biao_he_zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(984); // "你以前有和别人在同一个巢里睡过么？"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_yan1", "biao_he_zui2", "biao_nv1"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice4_b69a0bc2.ogg");
            yield return _gameMethods.OpenDialog(985); // "当我还在卵里的时候，曾经短暂地和我的母亲以及兄弟们睡在一起。"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_zui1", "biao_he_yan2"});
            yield return _gameMethods.OpenDialog(986); // "出生后就没了是吗。"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_nv4", "gaoguang_bi"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(987); // "那你应该没有和别人共眠的习惯。"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_nv2", "gaoguang_zheng"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(988); // "明早一醒来，你不会因为警戒就下意识把我控制住了吧？"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_yan1", "biao_he_zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice4_e2255e58.ogg");
            yield return _gameMethods.OpenDialog(989); // "你很弱，没到引起警戒的水平。"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_zui1"});
            yield return _gameMethods.EngineSetVolume(volume:0f, delay:0.1f, channelName:"music");
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(990); // "/n…………"
            yield return _gameMethods.EngineSetVolume(volume:0.5f, delay:0.1f, channelName:"music");
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_nv4", "gaoguang_bi"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(991); // "……谢谢你，现在我感觉安心多了。"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_nv1", "gaoguang_zheng"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(992); // "说说你童年时期的事可以么？"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_yan2", "biao_he_zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(993); // "你为什么有这么多问题。"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(994); // "因为……"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_nv4", "gaoguang_bi"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(995); // "/n我想要了解你？"
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:4f);
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_yan4", "biao_he_zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_qian");
            yield return _gameMethods.OpenDialog(996); // "「因为你说过的那个“弟弟”？{nw}{w=0.001}"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_yan3"});
            yield return _gameMethods.ExecuteCharacterImageData("he_qian");
            yield return _gameMethods.OpenDialog(997); // "/n还是你“喜欢”我。」"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_nv3", "biao_he_zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(998); // "…很全面，我没什么要补充的了。"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_yan2", "biao_he_zui2"});
            yield return _gameMethods.PlaySound("music", 2f, 1.2f, "audio/demo_audio/music/youshang2.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice4_4ebc301c.ogg");
            yield return _gameMethods.OpenDialog(999); // "这两个条件，一则都不成立。"
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(1000); // "一来，我是龙，他是人，我强大，他孱弱。"
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice4_8629aeb4.ogg");
            yield return _gameMethods.OpenDialog(1001); // "我和你口中的弟弟没有任何共同之处。"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_yan1"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice4_c5b079b5.ogg");
            yield return _gameMethods.OpenDialog(1002); // "二来。我将结束你的生命，从常理看，你没有可能会喜欢上我。"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.OpenSelectMenu(talk: new List<string>{"-告诉他喜欢是不需要理由的", "-给他提供一个合理解释"}, jump: new List<string>{"label_zhuxian_1_menu_0_0Ao0qzeo", "label_zhuxian_1_menu_0_h0kOnOgu"}, condition: new List<string>{"NONE", "NONE"});
        }

        public IEnumerator label_choice5()
        {
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_nv1", "biao_he_zui1", "gaoguang_zheng", "biao_he_yan1"});
            yield return _gameMethods.OpenDialog(1007); // "好吧，既然你如此地追求合理性。"
            yield return _gameMethods.OpenDialog(1008); // "那我就给你一个解释。"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_nv3", "gaoguang_bi"});
            yield return _gameMethods.OpenDialog(1009); // "——我有可能去发自内心地爱上你的动机，/n同时，也是我对你的‘爱’的纯洁性的证明。"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_nv4"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(1010); // "从常理看，确实如此。"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_nv1", "gaoguang_zheng"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(1011); // "但……"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(1012); // "我只是，想和你建立联系。"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_yan3", "biao_he_zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice7_82c674a8.ogg");
            yield return _gameMethods.OpenDialog(663); // "为什么。"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(1013); // "如果我能更了解你……了解我所为之付出生命的对象是一个怎样的存在，"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(1014); // "你对我而言，就变成了一条特殊的、独一无二的龙。/n这让我的死亡有了价值和意义。"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_yan1"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(924); // "……？"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(1015); // "假如你和我没有任何联系，那我就只是不幸、悲惨地被带走而已。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(1016); // "但若我了解你、爱你，那我就可以心甘情愿地为心爱之人奉献自己。"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_nv3", "gaoguang_bi"});
            Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(1017); // "/n我会是幸福的。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(1018); // "你能理解吗？"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_yan3", "biao_he_zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(1019); // "…不。但我好像知道了你的逻辑。"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_zui1", "biao_nv1", "gaoguang_zheng"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(1020); // "“好像”？"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_yan1", "biao_he_zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice5_3171fc71.ogg");
            yield return _gameMethods.OpenDialog(1021); // "你的脑筋很奇怪，我遇到的人类中还没出现过一个人像你这么想。"
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(1022); // "这对我是一种陌生的观点，需要时间消化。"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_nv4", "gaoguang_bi", "biao_he_zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(1023); // "那在你消化完全之前，我可以了解你吗？"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice5_3a287120.ogg");
            yield return _gameMethods.OpenDialog(1024); // "……你想知道什么？"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_nv2", "gaoguang_zheng", "biao_he_zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(1025); // "说说你的童年吧。你从一出生就住在这里吗？"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_nv1", "biao_he_zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(1026); // "在我出生后的前十年里，我和我的兄弟们一起居住在龙之谷。"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_yan2"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice5_05007856.ogg");
            yield return _gameMethods.OpenDialog(1027); // "十岁时，我的母亲说我可以离开，独自生活了。"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_nv2", "biao_he_zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(1028); // "哇，换算成人类，当时你还是个婴儿吧。你们龙这么早就可以独立的吗。"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_zui2", "biao_nv1"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(1029); // "大部分龙至少要等到幼年期结束。"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_nv2", "biao_he_zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(1030); // "……那你为什么那么早就离开啊。"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_zui2", "biao_he_yan3"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice5_270c5401.ogg");
            yield return _gameMethods.OpenDialog(1031); // "因为我比较强大。"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_zui1", "biao_nv4", "gaoguang_bi"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(1032); // "噢。"
            yield return _gameMethods.OpenDialog(1033); // "我露出一副意料之中的表情，又一脸美滋滋地说。"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_nv2", "gaoguang_zheng"});
            Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(1034); // "那当然，我们赫泽尔必然是最厉害的。"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_yan1", "biao_nv1"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_yan2", "biao_he_zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_qian");
            yield return _gameMethods.OpenDialog(1035); // "「另外，我的母亲是神圣母龙，{nw}{w=0.001}"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_yan3"});
            yield return _gameMethods.ExecuteCharacterImageData("he_qian");
            yield return _gameMethods.OpenDialog(1036); // "她崇尚秩序与光明，厌恶一切不详与黑暗，和我靠得过近，对她的元素有害。」"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(1037); // "……啊，黑暗巨龙竟然可以由神圣巨龙生出来吗？"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_zui2", "biao_he_yan1"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(1038); // "我会是历史记载中的第一个案例。"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_zui2", "biao_he_yan2"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice5_e484e87c.ogg");
            yield return _gameMethods.OpenDialog(1039); // "所以，她在孕育我时很痛苦。"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_zui1"});
            yield return _gameMethods.OpenDialog(1040); // "不用多言，趋利避害是一切生物的天性。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_nv3", "gaoguang_bi"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(1041); // "我可以抱你一下吗？"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_zui2", "biao_he_yan1"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice5_62494e09.ogg");
            yield return _gameMethods.OpenDialog(1042); // "……理由是什么。"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_nv1", "gaoguang_zheng", "biao_he_zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(1043); // "单纯想抱。"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_yan3"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice5_2f04f717.ogg");
            yield return _gameMethods.OpenDialog(1044); // "随便你。"
            yield return _gameMethods.ShowBlack(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "dissolve"}})});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/tangxia2_duan.mp3");
            yield return _gameMethods.OpenDialog(1045); // "我伸出手臂环住了他。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"zui7"});
            yield return _gameMethods.OpenDialog(1046); // "好厉害啊，赫泽尔殿下，这么早就独自出来，而且变得如此智慧又强大。"
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(1047); // "……这是理所当然的。/n我是灾厄与黑暗之龙，从觉醒血脉的那一天起，力量与智慧便与生俱来。"
            yield return _gameMethods.HideBlack(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "dissolve"}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(1048); // "那么。"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_nv3", "gaoguang_bi"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(1049); // "谢谢你，拥有如此强大的力量，还愿意温柔地对待我。"
            Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(1050); // "为我读书，陪我入睡。"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_yan2"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_nv1", "gaoguang_zheng"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(1051); // "我想，历届的黑暗之龙，以及你的兄弟们。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(1052); // "我从没见过他们，他们对我而言也就没有任何不同。"
            Defaults.Haogandu_he = Defaults.Haogandu_he - 2;
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(1053); // "但是，你来到了我面前，我所认识的、会喜欢上的就是你。"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_yan1", "biao_he_zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(1054); // "即使我带走了你？"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(1055); // "……呃。这个嘛。"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_nv4", "gaoguang_bi"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(1056); // "目前、距离要让我走得无怨无悔，那确实还有一点点路程。"
            Defaults.Haogandu_he = Defaults.Haogandu_he + 2;
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_nv2", "gaoguang_zheng"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(1057); // "不过我们努努力，很快了！"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_zui2", "biao_he_yan2"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice5_3b1694c6.ogg");
            yield return _gameMethods.OpenDialog(1058); // "你觉得这有可能么。"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_nv3", "gaoguang_bi", "biao_he_zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(1059); // "有可能的。"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_nv1", "gaoguang_zheng"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(1060); // "到那时，我会甘愿实现你的目的。"
            Defaults.Haogandu_he = Defaults.Haogandu_he + 3;
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(1061); // "因为你是我最重要的人…龙。你的幸福，就是我的幸福。"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_yan3"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_zui3"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(0f, 0f)}, {"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 1f}, {"pos", new Vector2(700f, 24f)}, {"zoom", 1.8f}})});
            yield return _gameMethods.OpenDialog(1062); // "他眨了眨眼睛，罕见地露出了些许怔愣和懵懂的茫然，仿佛面对着一项自己从未涉及、难以理解的陌生事物，找不到话说了一样。"
            yield return _gameMethods.EngineSetVolume(volume:0f, delay:2f, channelName:"music");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(700f, 24f)}, {"zoom", 1.8f}})});
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_yan2", "biao_he_zui1"});
            Defaults.Haogandu_he = Defaults.Haogandu_he - 10;
            yield return _gameMethods.OpenDialog(1063); // "但只片刻，这个孩子的神态便恢复了漠然与平淡。"
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.OpenDialog(481); // "……………………"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_yan1"});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_cg/cg_tiao/cg_tiao_he_yan1.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.58f, 0.42f)}, {"zoom", 0.58f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"alpha", 1f}})});
            yield return _gameMethods.EngineSetVolume(volume:0.8f, delay:1f, channelName:"soundb");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1f, saturationMatrix:1.0f, brightnessMatrix:0f, hueMatrix:0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.1f, saturationMatrix:1.39f, brightnessMatrix:-0.02f, hueMatrix:0.0f)}})});
            yield return _gameMethods.OpenDialog(1064); // "继而，他眯起眸，判断与审视什么一般盯着我看。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_cg/cg_tiao/cg_tiao_he_yan1.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.1f, saturationMatrix:1.39f, brightnessMatrix:-0.02f, hueMatrix:0.0f)}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.1f, saturationMatrix:1.39f, brightnessMatrix:-0.02f, hueMatrix:0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.1f, saturationMatrix:1.39f, brightnessMatrix:-0.14f, hueMatrix:0.0f)}})});
            yield return _gameMethods.OpenDialog(1065); // "那双镶嵌在暗红色虹膜中的黑色竖瞳，有种爬行类掠食者的无机质感，透露着一股原始而古老的高傲。"
            yield return _gameMethods.PlaySound("soundc", 0.0f, 3f, "audio/demo_audio/sound/leisheng_gun1.ogg");
            yield return _gameMethods.EngineSetVolume(volume:1f, delay:1f, channelName:"soundb");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.1f, saturationMatrix:1.39f, brightnessMatrix:-0.14f, hueMatrix:0.0f)}})});
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.8f, "audio/demo_audio/sound/Tension Riser B.mp3");
            yield return _gameMethods.OpenDialog(1066); // "被这种威慑所压迫，便会情不自禁想要跪地匍匐。"
            yield return _gameMethods.SetDialogUIShowOrHide("hide");
            yield return _gameMethods.Show("lightning_1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"rotate", 180f}, {"ypos", -350f}, {"zoom", 0.9f}, {"xpos", 100f}, {"alpha", 0.5f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.1f, saturationMatrix:1.39f, brightnessMatrix:-0.14f, hueMatrix:0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.1f}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.1f, saturationMatrix:1.39f, brightnessMatrix:0.02f, hueMatrix:0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.1f}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.1f, saturationMatrix:1.39f, brightnessMatrix:-0.14f, hueMatrix:0.0f)}})});
            yield return _gameMethods.StopEngineTime(time:0.60f);
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.1f, saturationMatrix:1.39f, brightnessMatrix:-0.14f, hueMatrix:0.0f)}})});
            yield return _gameMethods.SetDialogUIShowOrHide("show");
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.8f, "audio/demo_audio/sound/leisheng1.mp3");
            yield return _gameMethods.OpenDialog(1067); // "宛若弱者的本能，我的背脊生出一股寒意与软弱，想向他求饶，为自己的冒犯恳求原谅。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai1");
            yield return _gameMethods.OpenDialog(1068); // "（……可是解决问题的办法不在后面，永远只会在前方。）"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai1");
            yield return _gameMethods.OpenDialog(1069); // "（我很清楚，懦弱乞讨不来生路。）"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_cg/cg_tiao/cg_tiao_he_yan1.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.58f, 0.42f)}, {"zoom", 0.58f}, {"alpha", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"alpha", 0f}})});
            yield return _gameMethods.StopEngineTime(time:1.1f);
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_cg/cg_tiao/cg_tiao_he_yan1.png");
            yield return _gameMethods.SetDialogUIShowOrHide("hide");
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:1f);
            yield return _gameMethods.StopSound(channelName:"soundc", fadeOut:1f);
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 700f}, {"zoom", 1.8f}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.1f, saturationMatrix:1.39f, brightnessMatrix:-0.14f, hueMatrix:0.0f)}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ease", 0.9f}, {"xpos", 376f}, {"zoom", 1.71f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.9f}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.0f, saturationMatrix:1.39f, brightnessMatrix:0.0f, hueMatrix:0.0f)}})});
            yield return _gameMethods.StopEngineTime(time:1f);
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.0f, saturationMatrix:1.39f, brightnessMatrix:0.0f, hueMatrix:0.0f)}})});
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_nv4", "gaoguang_bi"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 376f}, {"zoom", 1.71f}})});
            yield return _gameMethods.SetDialogUIShowOrHide("show");
            yield return _gameMethods.EngineSetVolume(volume:1.2f, delay:0.5f, channelName:"music");
            yield return _gameMethods.OpenDialog(1070); // "我压制着心中的恐惧，抬起脸庞，弯起嘴角，对他露出一个大大的笑脸。"
            Defaults.Haogandu_he = Defaults.Haogandu_he + 12;
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_yan2"});
            yield return _gameMethods.StopEngineTime(time:0.7f);
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_yan3"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.0f, saturationMatrix:1.39f, brightnessMatrix:0.0f, hueMatrix:0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.60f}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.0f, saturationMatrix:1.0f, brightnessMatrix:0.0f, hueMatrix:0.0f)}})});
            yield return _gameMethods.OpenDialog(1071); // "毫无征兆地，他反而移开了视线。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.0f, saturationMatrix:1.0f, brightnessMatrix:0.0f, hueMatrix:0.0f)}})});
            yield return _gameMethods.Show("cg_layered_sleep", parts: new List<string>{"biao_he_zui2", "ditu1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "dissolve"}})});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice5_8786dbe6.ogg");
            yield return _gameMethods.OpenDialog(1072); // "我要睡了。"
            yield return _gameMethods.ShowBlack(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "dissolve"}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 2f}, {"xpos", -100f}})});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/tangxia1.mp3");
            yield return _gameMethods.OpenDialog(1073); // "语毕，他背过身去。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan9", "zui7", "emoji1", "emoji2"});
            yield return _gameMethods.OpenDialog(1074); // "我松了口气。感觉挺过了一关。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan2", "zui7", "emoji1", "emoji2"});
            yield return _gameMethods.OpenDialog(1075); // "赫泽尔背对着我，没有声音了。"
            Defaults.Gui_duihuakuang_you = 1;
            yield return _gameMethods.PlaySound("soundb", 2f, 1.0f, "audio/demo_audio/sound/yu1.ogg");
            yield return _gameMethods.Scene("woshi_he2_ani", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "dissolve"}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(-0.25f, 0.52f)}, {"zoom", 1.03f}})});
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.0f, saturationMatrix:1.0f, brightnessMatrix:0.0f, hueMatrix:0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.8f}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.3f, saturationMatrix:0.96f, brightnessMatrix:-0.14f, hueMatrix:0.0f)}})});
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.SceneBlack(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "dissolve"}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.3f}, {"xpos", -100f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.0f, saturationMatrix:1.0f, brightnessMatrix:0.0f, hueMatrix:0.0f)}})});
            yield return _gameMethods.OpenDialog(1076); // "在漆黑中逐渐下沉，我沉入了粘稠的睡意。"
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:3f);
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:3f);
            yield return _gameMethods.OpenDialog(491); // "………………"
            yield return _gameMethods.OpenDialog(481); // "……………………"
            yield return _gameMethods.ChangeLabelTo("label_testa1");
        }

        public IEnumerator label_testa1()
        {
            yield return _gameMethods.PlaySound("soundb", 0.5f, 1.0f, "audio/demo_audio/sound/niaoming.ogg");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/woshi_he2.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveTime", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.75f, 1.46f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.75f}})});
            Defaults.Haogandu_an = Defaults.Haogandu_an + 1;
            yield return _gameMethods.OpenDialog(1077); // "第二天醒来时，床上只有我一个人。"
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:2f);
            yield return _gameMethods.PlaySound("soundc", 0.0f, 1.0f, "audio/sound/jiaobusheng_xin_man1.ogg");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/zoulang_zhuanjiao2.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.0f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.51f}})});
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice7_c6c6c07e.ogg");
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_dating_baitian.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.0f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.75f}})});
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_chufang_baitian.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.0f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.69f}})});
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            yield return _gameMethods.OpenDialog(491); // "………………"
            yield return _gameMethods.StopSound(channelName:"soundc", fadeOut:1f);
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_shufang_baitian_quanjing.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.0f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.72f}})});
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            yield return _gameMethods.OpenDialog(481); // "……………………"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<silence 0.7>", "audio/demo_audio/sound/book1.mp3");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/woshi_he2.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/zoulang_zhuanjiao2.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_dating_baitian.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_chufang_baitian.jpg");
            yield return _gameMethods.TransitionBy("None");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_shufang_baitian_shafa.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.23f, 2.65f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 2.16f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan11", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 2.32f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.46f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -100f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(1078); // "在城堡里寻觅，果然又是在书房找到了那个身影。"
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_shufang_baitian_quanjing.jpg");
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.PlaySound("music", 2f, 1.0f, "audio/demo_audio/music/richang1.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(964); // "赫泽尔。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(1079); // "这段时间以来，我当然也仔细观察了这个对我未来的生活和命运至关重要的客体对象。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1080); // "他的生活似乎极其贫瘠而单调，在我的印象里，不是在睡觉，就是在阅读。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(1081); // "明明拥有自由，却只呆在这座城堡中，哪里也不去。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(1082); // "……其中固然有出于要看守我的需要（我猜），但他本身看起来也对外界没有任何兴趣。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1083); // "阅读时也看不出什么情绪波动，仿佛做这件事也只是为了打发时间。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan6", "zui15"});
            yield return _gameMethods.OpenDialog(1084); // "明明外表是个孩子，身上却有着一种看破红尘、四大皆空、遁入空门一般无欲无求、生无可恋的淡然。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.6f, "audio/demo_audio/sound/book1.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(1085); // "真是矛盾。热爱阅读，这本应该是对世界和未知领域充满好奇心的人才会有的特质。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeOutQuad", 0.40f}, {"ypos", 36f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(1086); // "也许这就是宅吧。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1>audio/sound/jiaobusheng_xin_normal1.ogg", "audio/demo_audio/sound/moca2.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 36f}, {"zpos", 0f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_shufang_baitian_quanjing1.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.1f)}, {"zoom", 0.88f}})});
            yield return _gameMethods.Show("shuben_bi", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 570f}, {"xalign", 0.5f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.5f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 1f}, {"ypos", 470f}, {"alpha", 1f}})});
            yield return _gameMethods.Transition(time:1.5f);
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15"});
            yield return _gameMethods.OpenDialog(1087); // "我放弃思考，熟门熟路地到他身边坐下，{nw}{w=0.1}"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/book1.mp3");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/shuben_bi.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}, {"ypos", 470f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/shuben.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 370f}, {"xalign", 0.5f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1088); // "继续读之前找到的一本图画较多、词汇简单的书。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/shuben.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/daoju/shuben_bi.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}})});
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_shufang_baitian_quanjing1.jpg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 36f}, {"zpos", -100f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.7f}, {"ypos", -15f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan2", "zui8", "emoji7"});
            yield return _gameMethods.OpenDialog(1089); // "赫泽尔抬头看了我一眼，"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan7", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan12", "zui8", "emoji7"});
            yield return _gameMethods.OpenDialog(1090); // "{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan2", "zui8", "emoji7"});
            yield return _gameMethods.OpenDialog(1091); // "没说什么，低头继续了。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.7f, "audio/demo_audio/sound/moca2.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -15f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.7f}, {"ypos", 36f}, {"zpos", 0f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_shufang_baitian_quanjing1.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.1f)}, {"zoom", 0.88f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.6f}, {"alpha", 1f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/shuben.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 470f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.7f}, {"ypos", 350f}, {"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15", "-emoji7"});
            yield return _gameMethods.OpenDialog(1092); // "我艰难而顽强地和手中这本书搏斗起来。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/demo_audio/sound/book1.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan21", "zui15"});
            yield return _gameMethods.OpenDialog(1093); // "遇到好几处不认识的字眼，{nw}{w=0.1}"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 36f}, {"zpos", 0f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_shufang_baitian_quanjing1.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/shuben.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 350f}, {"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan8", "zui18", "emoji2"});
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan9", "zui18", "emoji2"});
            yield return _gameMethods.OpenDialog(1094); // "我又是联系上下文，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan8", "zui18", "emoji2"});
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan9", "zui18", "emoji2"});
            yield return _gameMethods.OpenDialog(1095); // "又是结合词根词缀，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui5", "emoji2"});
            yield return _gameMethods.OpenDialog(1096); // "总算连蒙带猜地推理出了它们的涵义，"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/book1.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1097); // "成功地翻到了下一页。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui5", "-emoji2"});
            yield return _gameMethods.OpenDialog(1098); // "我再次看到了好几处不认识的词汇。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei6", "yan21", "zui13", "emoji2", "emoji5"});
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.7f, "audio/demo_audio/sound/moca2.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 36f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.25f}, {"ypos", -42f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/shuben.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 350f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.3f}, {"ypos", 400f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan12", "zui18", "emoji2", "emoji5"});
            yield return _gameMethods.OpenDialog(1099); // "忍不了了。/n去找词典吧。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -42f}})});
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_shufang_baitian_quanjing1.jpg");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_shufang_baitian_shafa.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.23f, 2.56f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 2.16f}})});
            yield return _gameMethods.Show("he", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 2.24f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.46f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(1100); // "刚从沙发上站起身，{nw}{w=0.1}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1101); // "一旁的赫泽尔却若有所觉一般，从书本中抬头，平静地将目光投到了我身上。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan5", "zui15", "emoji2", "-emoji5"});
            yield return _gameMethods.OpenDialog(1102); // "……莫名地，从他的目光中，感受到了一种压力。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1103); // "他似乎在等我解释自己的行为。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(1104); // "（………奇怪，之前对我看得有这么严吗。）"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui2", "emoji2"});
            yield return _gameMethods.OpenDialog(1105); // "我去拿下词典。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(1106); // "你想查什么？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.5f, "audio/demo_audio/sound/moca2.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"ypos", -42f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.50f}, {"zpos", -78f}})});
            yield return _gameMethods.Show("shuben", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"ypos", 400f}}), new SameLineParamData(new Dictionary<string, object>{{"matrixtransform", "ScaleMatrix"}, {"(1.0, 1.0, 1.0)", "*RotateMatrix"}, {"(0.0, 0.0, 0.0)", "*OffsetMatrix"}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.73f}, {"matrixtransform", "ScaleMatrix"}, {"(1.0, 0.3, 1.0)", "*RotateMatrix"}, {"(0.0, 0.0, 0.0)", "*OffsetMatrix"}, {"(0.0, 0.0, 0.0)", "ypos"}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui7", "-emoji2"});
            yield return _gameMethods.OpenDialog(1107); // "我指给他看。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -78f}})});
            yield return _gameMethods.Show("shuben", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"matrixtransform", "ScaleMatrix"}, {"(1.0, 0.3, 1.0)", "*RotateMatrix"}, {"(0.0, 0.0, 0.0)", "*OffsetMatrix"}, {"(0.0, 0.0, 0.0)", "ypos"}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan7", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(1108); // "他瞥了一眼，告诉我解释。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15"});
            yield return _gameMethods.OpenDialog(1109); // "我继续挨个指出了剩下的难点。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan7", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1110); // "他挨个告诉了我解释，{nw}{w=0.1}"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/book1.mp3");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/shuben.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"alpha", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1111); // "最后干脆就拿着这本书给我读了起来。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan7", "zui2"});
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/daoju/shuben.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui8", "emoji2"});
            yield return _gameMethods.OpenDialog(1112); // "我觉得，他应该是付出了极大的容忍，才能愿意为我读这本接近童话的寓言故事的……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"blur", 7.71f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(1113); // "自从一起入睡那天以后，感觉他对我的态度似乎产生了微妙的变化。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 7.71f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1114); // "尽管仍是一脸冷淡、难以接近的模样，但赫泽尔给我的回应显然变多了。"
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(1115); // "他的视线比以前更多地投映到我身上。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1116); // "在书房外，仍能看见他的频率也变多了。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui15"});
            yield return _gameMethods.OpenDialog(1117); // "有种亲密度上升了的感觉。"
            yield return _gameMethods.EngineSetVolume(volume:0.2f, delay:8f, channelName:"music");
            yield return _gameMethods.Scene("black", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 2f}, {"yoffset", -300f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.PlaySound("soundb", 1f, 1.0f, "audio/demo_audio/sound/yu1.ogg");
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg35_memory.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg35_memory.jpg");
            yield return _gameMethods.Scene("senlin2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.05f, saturationMatrix:0.82f, brightnessMatrix:-0.08f, hueMatrix:0.0f)}})});
            yield return _gameMethods.Show("rain_1");
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(491); // "………………"
            Defaults.Persistent.Jq_2_2 = 1;
            Defaults.Haogandu_an = Defaults.Haogandu_an + 1;
            yield return _gameMethods.OpenDialog(1118); // "九月末，山里下了几场雨，有了秋意，天气也微寒起来。"
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:5f);
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/senlin2.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.05f, saturationMatrix:0.82f, brightnessMatrix:-0.08f, hueMatrix:0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1f, saturationMatrix:1f, brightnessMatrix:0f, hueMatrix:0.0f)}})});
            yield return _gameMethods.Show("rain_1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"alpha", 0f}})});
            yield return _gameMethods.OpenDialog(491); // "………………"
            yield return _gameMethods.Hide("rain_1");
            yield return _gameMethods.OpenDialog(1119); // "大概也是山间树木茂郁的缘故，气温一向比较低。"
            yield return _gameMethods.PlaySound("soundb", 0.0f, 1.0f, "audio/sound/jiaobusheng_xin_man1.ogg");
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.EngineSetVolume(volume:1f, delay:1f, channelName:"music");
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:1f);
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/door_close1.mp3");
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/woshi_nv2.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.0f)}, {"zoom", 0.49f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(1120); // "我找遍了整座城堡，最后可悲地发现，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(1121); // "由于衣帽间长久封闭，加之干湿装置失灵，无论什么材质的衣物，大都已经在近一百五十年的时光下变为了尘埃。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/woshi_nv2.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(1122); // "不过也不用太过悲观，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan2", "zui7", "-emoji2"});
            yield return _gameMethods.OpenDialog(1123); // "至少我还剩下三个选择。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}, {"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 1f}, {"xpos", -216f}, {"zpos", -204f}})});
            yield return _gameMethods.OpenDialog(1124); // "窗帘、"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.6f}, {"pos", new Vector2(300f, -96f)}, {"zpos", -312.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1125); // "被子，"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 1f}, {"pos", new Vector2(-360f, 120f)}, {"zpos", -384.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1126); // "和拆沙发套。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui7"});
            yield return _gameMethods.OpenDialog(1127); // "这些物品，大概是因为位于干燥通风的地方，又材质特殊，被保存了下来。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/sibuliao.mp3", "audio/demo_audio/sound/sibuliao2.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-360f, 120f)}, {"zpos", -384.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.5f}, {"pos", new Vector2(-360f, -12f)}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yn2", "zui15"});
            yield return _gameMethods.OpenDialog(1128); // "我试图扯窗帘给自己做了个斗篷。/n保暖效果……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(1129); // "不能说是完全没有，只能说是形同虚设。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-360f, -12f)}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(1130); // "而之前装野菜的麻袋，虽然挺厚，但因为我当时过于急切，也已经破破烂烂，根本无法做成外套，穿在身上。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan2", "zui8", "-emoji2"});
            yield return _gameMethods.OpenDialog(1131); // "……决定了，白天尽量躲在被窝里。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan6", "zui8", "emoji2"});
            yield return _gameMethods.OpenDialog(1132); // "如果最后实在不行，就找个赫泽尔看起来心情比较好的时候提出需求吧。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/emeng_dajie/Lying Bed_01.mp3");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/woshi_nv2_tian.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.21f, 0.79f)}, {"zoom", 0.64f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan20", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(1133); // "不知为什么，有种提不起精神的体虚感。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei9", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(1134); // "今天天气好凉。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei9", "yan20", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(1135); // "后背的寒意——物理意义上的寒冷——令我有些不安。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/tangxia2_duan.mp3");
            yield return _gameMethods.ShowBlack(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 2f}, {"xpos", -300f}})});
            yield return _gameMethods.TransitionBy("blink4_1");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei9", "yan12", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(1136); // "有种不好的预感，我早早地睡下。"
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:4f);
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1137); // "寄希望于睡眠能提高免疫力。"
            yield return _gameMethods.PlaySound("soundc", 2f, 1.0f, "audio/sound/emeng_dajie/nightmare_01.ogg");
            yield return _gameMethods.Show("xuanyun_ani", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.2f}, {"xalign", 0.5f}, {"yalign", 0.5f}})});
            yield return _gameMethods.TransitionBy("blink3");
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1138); // "难受。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1139); // "宛若浑身被炙烤。头颅昏沉胀痛。恶心想吐。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1140); // "过了很久很久。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"blur", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.35f}, {"xoffset", 90f}, {"blur", 30f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.56f}, {"xoffset", 36f}, {"blur", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.65f}, {"xoffset", 90f}, {"blur", 30f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.29f}, {"xoffset", 66f}, {"blur", 0.0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.35f}, {"yoffset", 66f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.56f}, {"yoffset", 36f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.65f}, {"yoffset", 18f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1141); // "我在昏沉的泥潭中反复沉浮，痛苦挣扎。"
            yield return _gameMethods.OpenDialog(491); // "………………"
            yield return _gameMethods.SceneBlack(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.3f}})});
            yield return _gameMethods.Transition(time:0.8f);
            yield return _gameMethods.OpenDialog(1142); // "又过了不知道多久。"
            yield return _gameMethods.OpenDialog(1143); // "朦朦胧胧间，仿佛听到谁的声音。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.6f, "audio/sound/emeng_dajie/Scuba Diver Wearing Wet Suit Tight Rubber Sleeve_01.ogg");
            yield return _gameMethods.OpenDialog(1144); // "冰凉的触感贴在了脸颊上。"
            yield return _gameMethods.OpenDialog(1145); // "谁的手？"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}, {"xoffset", 0f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(1146); // "你怎么了。"
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(1147); // "能听清我说话么。"
            yield return _gameMethods.Show("xuanyun_ani1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.2f}, {"xalign", 0.5f}, {"yalign", 0.5f}})});
            yield return _gameMethods.TransitionBy("blink3");
            yield return _gameMethods.OpenDialog(1148); // "好难受。"
            yield return _gameMethods.OpenDialog(1149); // "眼泪要出来了。"
            yield return _gameMethods.OpenDialog(1150); // "这可不行，我没有那么软弱。"
            yield return _gameMethods.Hide("xuanyun_ani1");
            yield return _gameMethods.TransitionBy("blink4_1");
            yield return _gameMethods.OpenDialog(1151); // "我不能软弱。"
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(491); // "………………"
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(1152); // "不要死。"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/emeng_dajie/Body_up_01.mp3");
            yield return _gameMethods.OpenDialog(1153); // "恍惚中，我仿佛被抬了起来，脑袋的颠动又让我一阵恶心。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 2f, "audio/sound/emeng_dajie/magic1.ogg");
            yield return _gameMethods.OpenDialog(1154); // "之后，感觉一直在漂浮。"
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.OpenDialog(491); // "………………"
            yield return _gameMethods.StopSound(channelName:"soundc", fadeOut:4f);
            yield return _gameMethods.PlaySound("soundb", 0.0f, 1.0f, "audio/sound/emeng_dajie/Town Moring_01.ogg");
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/emeng_dajie/Knocking on Heavy Door _01.ogg");
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/emeng_dajie/Closing Shut Heavy Door_01.ogg");
            yield return _gameMethods.ExecuteCharacterImageData("e_weizhi");
            yield return _gameMethods.OpenDialog(1155); // "谁啊？大清早的——……！！你是——"
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:6f);
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(1156); // "救活她。"
            yield return _gameMethods.ExecuteCharacterImageData("e_weizhi");
            yield return _gameMethods.OpenDialog(1157); // "好、好的，魔法师阁下！！"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/emeng_dajie/Glass Cup_01.ogg");
            yield return _gameMethods.PlaySound("soundc", 0.0f, 1.0f, "<silence 0.8>", "audio/sound/emeng_dajie/Grinding_01.ogg");
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.StopSound(channelName:"soundc", fadeOut:2f);
            yield return _gameMethods.PlaySound("soundb", 0.0f, 0.2f, "audio/sound/emeng_dajie/Boiling_01.ogg");
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/emeng_dajie/Swallowing Pills_01.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}})});
            yield return _gameMethods.OpenDialog(1158); // "略带苦涩的液体被喂入口中。"
            yield return _gameMethods.PlaySound("soundc", 1f, 0.4f, "audio/sound/emeng_dajie/Clock Clip_01.ogg");
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:3f);
            yield return _gameMethods.OpenDialog(1159); // "时间一点点过去。"
            yield return _gameMethods.StopSound(channelName:"soundc", fadeOut:3f);
            yield return _gameMethods.OpenDialog(1160); // "那烧灼的不适略微有所缓解。"
            yield return _gameMethods.OpenDialog(478); // "……"
            Engine._dismiss_pause = false;
            Defaults.Gui_duihuakuang_you = 0;
            yield return _gameMethods.EngineSetVolume(volume:0.6f, delay:0f, channelName:"soundb");
            yield return _gameMethods.PlaySound("soundb", 1f, 2f, "audio/sound/zhutang1.ogg");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_cg/memory_2/memory_2_1.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "blink1"}})});
            yield return _gameMethods.OpenDialog(1161); // "熟悉的天花板。"
            yield return _gameMethods.OpenDialog(1162); // "这是王城中，我生活了近十年的那个简陋的家。"
            yield return _gameMethods.EngineSetVolume(volume:1f, delay:0f, channelName:"soundb");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_cg/memory_2/memory_2_2.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveTime", 0.8f}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(0.75f, 2.39f)}, {"zoom", 2.41f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 2.8f}, {"pos", new Vector2(0.78f, 1.63f)}, {"zoom", 1.73f}})});
            yield return _gameMethods.OpenDialog(1163); // "锅炉里的浓汤正在咕嘟咕嘟冒泡。"
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_cg/memory_2/memory_2_1.jpg");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_cg/memory_2/memory_2_2.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(0.78f, 1.63f)}, {"zoom", 1.73f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 1.62f}, {"pos", new Vector2(0.64f, 1.24f)}})});
            yield return _gameMethods.ExecuteCharacterImageData("e_weizhi");
            yield return _gameMethods.OpenDialog(1164); // "面包也已从橱柜里拿了出来。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_cg/memory_2/memory_2_2.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"at", "default"}, {"as", "memory_2_22"}, {"dissolveTime", 1.5f}})});
            Engine._dismiss_pause = true;
            yield return _gameMethods.OpenDialog(1165); // "我在小桌子边坐好，双手托腮，等妈妈工作回来。"
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_cg/memory_2/memory_2_2.jpg");
            yield return _gameMethods.Hide("memory_2_22");
            yield return _gameMethods.PlaySound("sound", 0.0f, 2.2f, "audio/sound/door_open_1.mp3");
            yield return _gameMethods.Show("memory_2_3", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"ypos", 1.0f}, {"anchor", new Vector2(0.5f, 0.99f)}, {"zoom", 3.16f}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", -0.56f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.62f}, {"xpos", -0.22f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 2.3f}, {"xpos", -0.12f}})});
            yield return _gameMethods.EngineSetVolume(volume:0.8f, delay:0f, channelName:"soundb");
            yield return _gameMethods.OpenDialog(1166); // "{cps=3}吱 呀{/cps}"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.5f, "audio/sound/door_open_2.mp3");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_cg/memory_2/memory_2_3.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "Shake"}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-0.12f, 0.99f)}})});
            yield return _gameMethods.OpenDialog(1167); // "木门被猛地打开。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_cg/memory_2/memory_2_3.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"at", "default"}, {"as", "memory_2_32"}, {"dissolveTime", 0.5f}})});
            yield return _gameMethods.OpenDialog(1168); // "是妈妈。"
            yield return _gameMethods.OpenDialog(1169); // "她形容落魄，心事重重，仿佛有很重的东西压在那对纤瘦的肩膀上，眼眶微红。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 2.5f, "audio/sound/stool_drag1.mp3");
            yield return _gameMethods.PlaySound("sounda", 0.0f, 2.5f, "<silence 1>", "<from 0 to 1.2>audio/sound/run1.ogg");
            yield return _gameMethods.OpenDialog(1170); // "我从凳子上站起来，跑向她。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_cg/memory_2/memory_2_4.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveTime", 0.6f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.67f}, {"xpos", -0.3f}, {"ypos", -0.6f}})});
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_cg/memory_2/memory_2_3.jpg");
            yield return _gameMethods.PlaySound("sound", 0.0f, 2.5f, "audio/sound/moca1.ogg");
            yield return _gameMethods.OpenDialog(1171); // "她没有力气一般，蹲了下来，"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_cg/memory_2/memory_2_4.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -0.6f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 6f}, {"ypos", 0.0f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_cg/memory_2/memory_2_4.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"at", "default"}, {"as", "memory_2_42"}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.55f}, {"ypos", 1.65f}, {"zoom", 1.67f}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("e_weizhi");
            yield return _gameMethods.OpenDialog(1172); // "/n妈妈握住我的肩膀，看着我的眼睛，忍着眼泪。"
            yield return _gameMethods.ExecuteCharacterImageData("d");
            yield return _gameMethods.OpenDialog(1173); // "[persistent.povname]。/n朋友之间有没有欺负你？"
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_cg/memory_2/memory_2_4.jpg");
            yield return _gameMethods.ExecuteCharacterImageData("d");
            yield return _gameMethods.OpenDialog(1174); // "他们有没有骂你没有爸爸。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(1175); // "没有啊。我会打回去。"
            yield return _gameMethods.ExecuteCharacterImageData("d");
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_cg/memory_2/memory_2_5.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveTime", 0.7f}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"xpos", 0.55f}, {"ypos", 1.65f}, {"zoom", 1.67f}})});
            yield return _gameMethods.OpenDialog(1176); // "她低下了头，内疚羞惭自厌茫然，视线看着地面。"
            yield return _gameMethods.Hide("memory_2_42");
            yield return _gameMethods.Hide("memory_2_32");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_cg/memory_2/memory_2_5.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.0f, saturationMatrix:1.0f, brightnessMatrix:0.0f, hueMatrix:0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.8f}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1f, saturationMatrix:0.6f, brightnessMatrix:-0.27f, hueMatrix:0.0f)}})});
            yield return _gameMethods.ExecuteCharacterImageData("d");
            yield return _gameMethods.OpenDialog(1177); // "你会不会觉得，妈妈给你丢脸了。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian1_f500abff.ogg");
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1>audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:2f);
            yield return _gameMethods.EngineSetVolume(volume:1f, delay:0f, channelName:"soundb");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_cg/memory_2/memory_2_6.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveTime", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.62f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 1.66f}}), new SameLineParamData(new Dictionary<string, object>{{"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1f, saturationMatrix:0.5f, brightnessMatrix:-0.37f, hueMatrix:0.0f)}})});
            yield return _gameMethods.OpenDialog(1178); // "我向前走了一步，双手抱住她的身躯。"
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_cg/memory_2/memory_2_5.jpg");
            yield return _gameMethods.OpenDialog(1179); // "小孩子的手臂太短了，要踮起脚尽全力才能圈住她。"
            yield return _gameMethods.PlaySound("music", 0.0f, 1.5f, "audio/music/gentle1.mp3");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_cg/memory_2/memory_2_6.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1f, saturationMatrix:0.5f, brightnessMatrix:-0.37f, hueMatrix:0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.49f}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.0f, saturationMatrix:1.0f, brightnessMatrix:0.0f, hueMatrix:0.0f)}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(1180); // "怎么会呢，妈妈，/n是那个不负责任的男人的错。"
            yield return _gameMethods.OpenDialog(1181); // "生下我时，她还年轻。/n连自己如何生活下去都还尚未搞懂，就要对另一个脆弱的生命负责。"
            yield return _gameMethods.OpenDialog(1182); // "可她坚持下来了。明明自己还只是个孩子。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(1183); // "我爱你，谢谢你这么辛苦地抚养我。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_cg/memory_2/memory_2_6.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"at", "default"}, {"as", "memory_2_62"}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.2f}, {"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(1184); // "我为你而骄傲，妈妈。"
            yield return _gameMethods.ExecuteCharacterImageData("d");
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.OpenDialog(1185); // "她沉默了很久，从喉咙深处泄露出一声长长的、因压抑而变调的哭泣。"
            yield return _gameMethods.OpenDialog(1186); // "狠狠拥抱住我，好像抱着浮木一般。"
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.SceneBlack(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveTime", 0.5f}})});
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_cg/memory_2/memory_2_6.jpg");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian1_f680ad55.ogg");
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.OpenDialog(1187); // "后来怎么回事呢？"
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:8f);
            yield return _gameMethods.OpenDialog(1188); // "后来她就生病了。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_cg/memory_2/memory_2_7.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.2f}, {"alpha", 1f}})});
            yield return _gameMethods.PlaySound("soundb", 0.0f, 0.5f, "audio/sound/zhutang1.ogg");
            yield return _gameMethods.OpenDialog(1189); // "我明明按时喂水喂饭，可她还是一天天消瘦下去。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_cg/memory_2/memory_2_7.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(1190); // "冬天来了，燃料好贵。屋子冷得要命。"
            yield return _gameMethods.OpenDialog(1191); // "洛恩和安德鲁家送来了一些柴火，但只能省着用。"
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:4f);
            yield return _gameMethods.PlaySound("soundc", 3f, 1.0f, "audio/sound/rain_thunder1_01.ogg");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_cg/memory_2/memory_2_8.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"alpha", 1f}})});
            yield return _gameMethods.Show("snow_white1");
            yield return _gameMethods.OpenDialog(1192); // "那一天，回光反照时，她说了什么？"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_cg/memory_2/memory_2_8.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("d");
            yield return _gameMethods.OpenDialog(1193); // "对不起，明明想看着你长大的。"
            yield return _gameMethods.ExecuteCharacterImageData("d");
            yield return _gameMethods.OpenDialog(1194); // "对不起。对不起。/n你要好好长大，好好吃饭，和喜欢的人结婚。"
            yield return _gameMethods.ExecuteCharacterImageData("d");
            yield return _gameMethods.OpenDialog(1195); // "对不起我不是个合格的妈妈，谢谢你，愿意当我的孩子。/n这个世上我比谁都爱你。"
            yield return _gameMethods.ExecuteCharacterImageData("d");
            yield return _gameMethods.OpenDialog(1196); // "[persistent.povname]，我爱你。/n……明明想看着你长大的，怎么会，呜呜——……"
            yield return _gameMethods.OpenDialog(1197); // "那个冬天，我失去了妈妈。"
            yield return _gameMethods.StopSound(channelName:"soundc", fadeOut:5f);
            yield return _gameMethods.PlaySound("soundb", 3f, 1.0f, "audio/sound/emeng_dajie/nightmare_01.ogg");
            yield return _gameMethods.SceneBlack();
            Defaults.Gui_duihuakuang_you = 1;
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.OpenDialog(1198); // "什么时候了？"
            yield return _gameMethods.OpenDialog(1199); // "好难受。但我不能躺在这里……"
            yield return _gameMethods.OpenDialog(1200); // "我记得……我还在工作。"
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:4f);
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "<silence 1.2>", "audio/demo_audio/sound/zhenjing_shuaidaoganjue.mp3");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg27_memory.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg27_memory.jpg");
            yield return _gameMethods.Scene("wuzi_po_wanshang", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.1f}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.0f, saturationMatrix:0.4f, brightnessMatrix:0.0f, hueMatrix:0.0f)}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.Show("npc_anmei", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(450f, 216f)}, {"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"matrixcolor", "InvertMatrix"}, {"(0.0)", "*ContrastMatrix"}, {"(1.0)", "*SaturationMatrix"}, {"(0.2)", "*BrightnessMatrix"}, {"(0.0)", "*HueMatrix"}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.5f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.12f}, {"xoffset", -3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.08f}, {"xoffset", 3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.5f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.12f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.08f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("f");
            yield return _gameMethods.OpenDialog(1201); // "姐姐！"
            yield return _gameMethods.Show("Assets/RenpyResources/images/lihui/npc/npc_anmei.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}, {"xoffset", 0f}, {"yoffset", 0f}})});
            yield return _gameMethods.OpenDialog(1202); // "……啊，是安德鲁家的妹妹。"
            yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/music/One_spring_day.mp3");
            yield return _gameMethods.Show("an1", parts: new List<string>{"mei1", "yan8", "zui4", "onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.6f, 2.13f)}, {"zoom", 0.35f}, {"yoffset", -10f}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 150f}, {"alpha", 0f}, {"blur", 0.001f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.8f}, {"alpha", 1f}, {"blur", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("an_weizhi");
            yield return _gameMethods.OpenDialog(1203); // "噢。你醒了啊。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.5f, "<from 0 to 1.5>audio/sound/jiaobusheng_an_normal1.ogg");
            yield return _gameMethods.Show("npc_anmei", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 450f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.4f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.30f}, {"xpos", 410f}})});
            yield return _gameMethods.Show("an1", parts: new List<string>{"mei1", "yan8", "zui1", "onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.6f, 2.13f)}, {"zoom", 0.35f}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 150f}, {"alpha", 1f}, {"blur", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 1f}, {"xoffset", 0f}})});
            yield return _gameMethods.OpenDialog(1204); // "安德鲁端着一杯水走过来。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/lihui/npc/npc_anmei.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 410f}})});
            yield return _gameMethods.Show("an1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(1205); // "安德鲁？"
            yield return _gameMethods.PlaySound("sound", 0.5f, 1.0f, "audio/sound/emeng_dajie/Body_up_01.mp3");
            yield return _gameMethods.Show("an1", parts: new List<string>{"mei1", "yan12", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 2.13f}, {"zoom", 0.35f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.38f}, {"ypos", 2.3f}, {"zoom", 0.37f}})});
            yield return _gameMethods.OpenDialog(1206); // "他把水杯塞了到了我手里，{nw}{w=0.1}"
            yield return _gameMethods.Show("an1", parts: new List<string>{"mei2", "yan19", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(1207); // "俯身摸了摸我额头的温度。"
            yield return _gameMethods.Show("an1", parts: new List<string>{"mei1", "yan2", "zui7"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 2.3f}, {"zoom", 0.37f}})});
            yield return _gameMethods.ExecuteCharacterImageData("an");
            yield return _gameMethods.OpenDialog(1208); // "真走运啊，还没有烧傻。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.5f, "<silence 0.8>", "audio/sound/houhui/Grab Hand_01.mp3");
            yield return _gameMethods.Show("an1", parts: new List<string>{"mei2", "yan12", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 2.3f}, {"zoom", 0.37f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.3f}, {"ypos", 2.34f}, {"zoom", 0.38f}})});
            yield return _gameMethods.OpenDialog(1209); // "然后恨铁不成钢地作势要敲我脑门一下。"
            yield return _gameMethods.Show("an1", parts: new List<string>{"mei2", "yan16", "zui8", "emoji6"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 2.34f}, {"zoom", 0.38f}})});
            yield return _gameMethods.ExecuteCharacterImageData("an");
            yield return _gameMethods.OpenDialog(1210); // "你至于吗，都生病了还闷不吭声上了一天的班。"
            yield return _gameMethods.Show("an1", parts: new List<string>{"mei2", "yan16", "zui2", "-emoji6"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}})});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1.1>audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.Show("luo1", parts: new List<string>{"mei1", "yan5", "zui5"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.26f, 1.62f)}, {"zoom", 0.28f}, {"yoffset", 70f}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}, {"xoffset", -50f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"alpha", 1f}, {"xoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("luo");
            yield return _gameMethods.OpenDialog(1211); // "而且是在最忙的农忙期。"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 0.6f, "<from 0 to 0.6>audio/sound/jiaobusheng_an_normal1.ogg");
            yield return _gameMethods.Show("an1", parts: new List<string>{"mei1", "yan2", "zui6"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 2.34f}, {"zoom", 0.38f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"ypos", 1.97f}, {"zoom", 0.32f}})});
            yield return _gameMethods.Show("luo1", parts: new List<string>{"mei1", "yan5", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("an_qian");
            yield return _gameMethods.OpenDialog(1212); // "「这家伙也太过分了，{nw}{w=0.1}"
            yield return _gameMethods.Show("an1", parts: new List<string>{"mei1", "yan13", "zui5"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}})});
            yield return _gameMethods.ExecuteCharacterImageData("an_qian");
            yield return _gameMethods.OpenDialog(1213); // "你不要太惯着他，该请假就请假好不好。」"
            yield return _gameMethods.Show("an1", parts: new List<string>{"mei1", "yan13", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 1.97f}, {"zoom", 0.32f}})});
            yield return _gameMethods.OpenDialog(1214); // "这家伙平时不会说话，这种时候倒是难能可见地温柔了一些。"
            yield return _gameMethods.Show("luo1", parts: new List<string>{"mei1", "yan12", "zui7"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}, {"xoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("luo");
            yield return _gameMethods.OpenDialog(1215); // "真过分啊，我还没有对员工严苛到这个份上。"
            yield return _gameMethods.Show("luo1", parts: new List<string>{"mei8", "yan8", "zui14"});
            yield return _gameMethods.ExecuteCharacterImageData("luo_qian");
            yield return _gameMethods.OpenDialog(1216); // "「所以，现在，为了我长远的收益、你未来的劳动力，{nw}{w=0.2}"
            yield return _gameMethods.Show("luo1", parts: new List<string>{"mei8", "yan5", "zui11"});
            yield return _gameMethods.ExecuteCharacterImageData("luo_qian");
            yield return _gameMethods.OpenDialog(1217); // "/n作为老板，我要求你好好休息。康复起来。」"
            yield return _gameMethods.Show("an1", parts: new List<string>{"mei1", "yan8", "zui4"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}})});
            yield return _gameMethods.Show("luo1", parts: new List<string>{"mei8", "yan5", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("an");
            yield return _gameMethods.OpenDialog(1218); // "听见没有。"
            yield return _gameMethods.Show("an1", parts: new List<string>{"mei1", "yan8", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(1219); // "突然这么温柔，我都不习惯了。"
            yield return _gameMethods.Show("an1", parts: new List<string>{"mei8", "yan16", "zui12"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}})});
            yield return _gameMethods.ExecuteCharacterImageData("an");
            yield return _gameMethods.OpenDialog(1220); // "那要不要我掐你一把，让你习惯习惯啊？"
            yield return _gameMethods.Show("an1", parts: new List<string>{"mei8", "yan16", "zui10"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(1221); // "有什么可习惯的呢？你们不是一直都这么温柔吗？"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 0.5f, "<from 0 to 0.6>audio/sound/jiaobusheng_an_normal1.ogg");
            yield return _gameMethods.Show("an1", parts: new List<string>{"mei2", "yan2", "zui3"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 1.97f}, {"zoom", 0.32f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.48f}, {"ypos", 2.03f}, {"zoom", 0.33f}})});
            yield return _gameMethods.Show("luo1", parts: new List<string>{"mei8", "yan2", "zui1"});
            Engine._history = false;
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("luo1", parts: new List<string>{"mei2", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("an_qian");
            yield return _gameMethods.OpenDialog(1222); // "「……"
            if (Defaults.Persistent.Povname=="辛西娅")
            {
                                yield return _gameMethods.Show("an1", parts: new List<string>{"mei2", "yan12", "zui4"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}})});
                yield return _gameMethods.ExecuteCharacterImageData("an_qian");
                yield return _gameMethods.OpenDialog(1223); // "辛西娅。」"

            }
            else
            {
                                yield return _gameMethods.Show("an1", parts: new List<string>{"mei2", "yan12", "zui4"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}})});
                yield return _gameMethods.ExecuteCharacterImageData("an_qian");
                yield return _gameMethods.OpenDialog(1224); // "[persistent.povname]。」"

            }
            yield return _gameMethods.Show("an1", parts: new List<string>{"mei2", "yan12", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 2.03f}, {"zoom", 0.33f}})});
            yield return _gameMethods.Show("luo1", parts: new List<string>{"mei2", "yan5", "zui8"});
            yield return _gameMethods.OpenDialog(1225); // "安德鲁忽然叫了我一声，沉下眉眼注视着我。"
            yield return _gameMethods.OpenDialog(1226); // "他的语气认真。"
            yield return _gameMethods.Show("an1", parts: new List<string>{"mei1", "yan8", "zui5"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}})});
            yield return _gameMethods.ExecuteCharacterImageData("an_qian");
            yield return _gameMethods.OpenDialog(1227); // "「我们是你的同伴，不会是你的负担，{nw}{w=0.1}"
            yield return _gameMethods.Show("an1", parts: new List<string>{"mei1", "yan23", "zui4"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}})});
            yield return _gameMethods.ExecuteCharacterImageData("an_qian");
            yield return _gameMethods.OpenDialog(1228); // "/n如果遇到麻烦，{nw}{w=0.1}"
            yield return _gameMethods.Show("an1", parts: new List<string>{"mei1", "yan12", "zui4"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}})});
            yield return _gameMethods.ExecuteCharacterImageData("an_qian");
            yield return _gameMethods.OpenDialog(1229); // "告诉我们，我们自然会帮你解决。」"
            yield return _gameMethods.Show("an1", parts: new List<string>{"mei1", "yan2", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}})});
            yield return _gameMethods.ExecuteCharacterImageData("an_qian");
            yield return _gameMethods.OpenDialog(1230); // "「再说了，从小家里那么多弟弟妹妹给我惹事，都照顾习惯了，{nw}{w=0.1}"
            yield return _gameMethods.Show("an1", parts: new List<string>{"mei1", "yan12", "zui13"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}})});
            yield return _gameMethods.ExecuteCharacterImageData("an_qian");
            yield return _gameMethods.OpenDialog(1231); // "/n多你一个也没什么区别。」"
            yield return _gameMethods.Show("an1", parts: new List<string>{"mei1", "yan12", "zui10"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(1232); // "谢谢。"
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.Hide("an1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}})});
            yield return _gameMethods.TransitionBy("blink2_1");
            yield return _gameMethods.OpenDialog(1233); // "内心涌过暖流。"
            yield return _gameMethods.OpenDialog(1234); // "有了这么多人的帮助。/n我一定要活下去，好好地长大。"
            yield return _gameMethods.OpenDialog(1235); // "我要在春天去郊外野餐。/n在夏天去河边嬉水抓鱼，弄湿衣服。"
            yield return _gameMethods.OpenDialog(1236); // "秋天去田间捡麦穗，升起火堆烤得焦黑后，搓掉外皮吃掉。"
            yield return _gameMethods.OpenDialog(1237); // "冬天就在屋子里烤着炉火，/n吃热热的炖菜………………"
            yield return _gameMethods.OpenDialog(1238); // "和很要好很要好的朋友，/n一起度过很长时间。"
            yield return _gameMethods.OpenDialog(1239); // "幸运的话，找到相伴一生的人…………"
            yield return _gameMethods.OpenDialog(1240); // "我想要…………"
            yield return _gameMethods.OpenDialog(1241); // "获得幸福啊……"
            yield return _gameMethods.OpenDialog(1242); // "……不知何时。"
            yield return _gameMethods.OpenDialog(1243); // "……萦绕全身的痛苦……消失了。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg26_memory.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg26_memory.jpg");
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:9f);
            yield return _gameMethods.PlaySound("soundb", 2f, 0.7f, "audio/sound/emeng_dajie/Town Moring_01.ogg");
            yield return _gameMethods.Scene("yiguan_baitian", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.1f}, {"xalign", 0.5f}, {"yalign", 0.5f}, {"blur", 10f}})});
            yield return _gameMethods.TransitionBy("blink3");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian1_76380fd8.ogg");
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.Show("yiguan_baitian", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 10f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"blur", 0f}})});
            yield return _gameMethods.OpenDialog(1244); // "病房……？"
            yield return _gameMethods.OpenDialog(1245); // "我似乎躺在一张床上。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/emeng_dajie/Body_up_01.mp3");
            yield return _gameMethods.Show("yiguan_baitian", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.32f}, {"zpos", -234f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan2", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(1246); // "我坐起身。"
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:9f);
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -234f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan27", "zui3"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 2.88f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.58f}, {"alpha", 0f}, {"blur", 0.01f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.3f}, {"alpha", 1f}, {"blur", 0f}})});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan3", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan2", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(1247); // "看到赫泽尔正在病床一旁盯着我。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan22", "zui9"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}, {"blur", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(1248); // "你昏迷了。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan22", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan4", "zui10", "-emoji2"});
            yield return _gameMethods.OpenDialog(1249); // "这里是……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan4", "zui15"});
            yield return _gameMethods.OpenDialog(1250); // "医馆，在人类的市镇。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(1251); // "龙之谷太远了。我担心你撑不到草药之龙的面前。"
            yield return _gameMethods.Show("he", parts: new List<string>{"zui2", "mei1", "yan15"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(1252); // "他悒郁地说，低垂眼眸，{nw}{w=0.1}"
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/fenjin/shengbing_moshou1.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}, {"pos", new Vector2(150f, 66f)}, {"anchor", new Vector2(0f, 0f)}, {"zoom", 0.52f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.7f}, {"alpha", 1f}})});
            Defaults.Gui_duihuakuang_you = 0;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1253); // "玩弄着我的手指。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/demo_audio/sound/tangxia2_duan.mp3");
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/fenjin/shengbing_moshou1.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}, {"ypos", 0f}, {"zpos", -234f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.8f}, {"anchor", new Vector2(0f, 0f)}, {"ypos", -66f}, {"zpos", -354f}})});
            yield return _gameMethods.OpenDialog(1254); // "他握住我的手腕，拇指轻轻地点在了我的手腕上。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}, {"ypos", -66f}, {"zpos", -354f}})});
            yield return _gameMethods.OpenDialog(1255); // "腕部内侧，薄薄的皮肤表皮浮现出青紫色纤细的血管脉络，/n他的指腹沿着血管下划，在我眼前，{nw}{w=0.1}"
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.6f, "audio/demo_audio/sound/moca3.mp3");
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/fenjin/shengbing_moshou2.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}, {"pos", new Vector2(150f, 66f)}, {"anchor", new Vector2(0f, 0f)}, {"zoom", 0.52f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1f}})});
            yield return _gameMethods.Show("_zoom");
            yield return _gameMethods.Hide("_zoom");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1256); // "手指划过柔嫩的皮肤。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/fenjin/shengbing_moshou2.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(1257); // "凉凉的触感，好痒。"
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(491); // "………………"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui9"});
            yield return _gameMethods.PlaySound("music", 2f, 1.0f, "audio/demo_audio/music/youshang2.mp3");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/cg/fenjin/shengbing_moshou2.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/cg/fenjin/shengbing_moshou1.jpg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}, {"ypos", 0f}, {"zpos", -234f}})});
            yield return _gameMethods.Transition(time:0.8f);
            Defaults.Gui_duihuakuang_you = 1;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(1258); // "你好脆弱。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui21"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(1259); // "「轻易就会死掉。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan24", "zui8", "emoji2"});
            yield return _gameMethods.OpenDialog(1260); // "……不，我觉得是参照物的问题吧。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan12", "zui8", "emoji2"});
            yield return _gameMethods.OpenDialog(1261); // "对龙来说至少要到超人类的境界才能不算脆弱吧。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui19", "-emoji2"});
            yield return _gameMethods.OpenDialog(1262); // "「是呀，人是很脆弱的，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui19"});
            yield return _gameMethods.OpenDialog(1263); // "而且，非常容易死。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan9", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui2"});
            yield return _gameMethods.OpenDialog(1264); // "所以，要好好爱惜我，保护我。"
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(1222); // "「……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan23", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(1265); // "……」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2"});
            Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(765); // "嗯。"
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(481); // "……………………"
            yield return _gameMethods.Scene("yiguan_baitian", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.1f}, {"xalign", 0.5f}, {"yalign", 0.5f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(1266); // "恢复行动能力后，我们办理手续离开。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.28f}, {"zpos", -138.0f}})});
            yield return _gameMethods.Show("npc_yishi", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}, {"pos", new Vector2(486f, 120f)}, {"anchor", new Vector2(0f, 0f)}, {"zoom", 0.4f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.2f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(1267); // "临走之前，医师抓住我们，再次复述诊断结果和医嘱。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -138.0f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/lihui/npc/npc_yishi.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("e");
            yield return _gameMethods.OpenDialog(1268); // "长期的营养不良。还有，你工作很忙碌吧，心情压力——……"
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/moca1.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei4", "yan1", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(1269); // "「我知道了！！"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei4", "yan2", "zui2", "emoji2"});
            yield return _gameMethods.OpenDialog(1270); // "要保持一个良好的心情才有利于健康对吧。」"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan2", "zui8", "emoji2"});
            yield return _gameMethods.OpenDialog(1271); // "我连忙打断他。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}, {"zpos", -138.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.5f}, {"xpos", 108f}, {"zpos", -78.0f}})});
            yield return _gameMethods.Show("he", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.62f, 2.13f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 156.0f}, {"zoom", 0.39f}, {"alpha", 0f}, {"blur", 0.01f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1f}, {"blur", 0f}})});
            Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan11", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(1272); // "要赫泽尔，那你可要多多陪伴我，不然我会很寂寞的。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 108f}, {"zpos", -78.0f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}, {"blur", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei3", "yan11", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(1273); // "「…………{nw}{w=0.3}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(1274); // "嗯。可以。」"
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:4f);
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 108f}, {"zpos", -78.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.69f}, {"xpos", 0f}, {"zpos", -132.0f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("e_nv", parts: new List<string>{"mei7", "yan5", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(1275); // "啊、啊，哦……那就好。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 3>audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}, {"zpos", -132.0f}})});
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(491); // "………………"
            yield return _gameMethods.OpenDialog(1276); // "离开医馆后，我们走在大街上。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg48_memory.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg48_memory.jpg");
            yield return _gameMethods.PlaySound("soundb", 1f, 1.0f, "audio/sound/emeng_dajie/Town Crow_01.ogg");
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/dajie1.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0f, -84f)}, {"anchor", new Vector2(0f, 0f)}, {"zoom", 0.63f}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(1277); // "人类的市集，真是久违了。"
            yield return _gameMethods.PlaySound("music", 0.0f, 0.6f, "audio/music/PerituneMaterial_Harvest_loop___chujie.mp3");
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/dajie1.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui14", "-emoji2"});
            yield return _gameMethods.OpenDialog(1278); // "这显然只是个边陲的小镇，市集称不上多么繁荣，商品也不像王都那般琳琅满目、应有尽有。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(0f, 0f)}, {"zpos", -132.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 1f}, {"pos", new Vector2(235f, 0f)}, {"zpos", -400.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "ya2", "zui10", "emoji7", "emoji15"});
            yield return _gameMethods.OpenDialog(1279); // "我看了看路边摊贩上的水果，不禁垂涎三尺。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(235f, 0f)}, {"zpos", -400.0f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 235f}, {"zpos", -400.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.70f}, {"xpos", 19f}, {"zpos", -334.0f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.85f)}, {"zoom", 0.33f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19", "emoji7", "-emoji15"});
            yield return _gameMethods.OpenDialog(1280); // "难得进城，要买点东西带回去么？"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 19f}, {"zpos", -334.0f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui19", "-emoji7"});
            yield return _gameMethods.OpenDialog(1281); // "比如买些干粮，这样就可以很长时间不用麻烦你帮我采集啦。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(1282); // "「那个营养么。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(1283); // "呃……能填饱肚子就是了。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei8", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(1284); // "怎么做能保证你的饮食营养。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui2"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -334.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.35f}, {"zpos", -346.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(1285); // "哇，这可是很奢侈的。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -346.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan11", "zui7"});
            yield return _gameMethods.OpenDialog(1286); // "要请仆人？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui11"});
            yield return _gameMethods.OpenDialog(1287); // "「啊——"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/moca1.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
            yield return _gameMethods.OpenDialog(1288); // "不用不用，"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan5", "zui19"});
            yield return _gameMethods.OpenDialog(1289); // "我们可以买点蔬菜种子。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan3", "zui2"});
            yield return _gameMethods.OpenDialog(1290); // "当然，能有些调味料就更好啦。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan28", "zui9"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan3", "zui7"});
            yield return _gameMethods.OpenDialog(1291); // "你可以买下任何你需要的东西。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan28", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan4", "zui10"});
            yield return _gameMethods.OpenDialog(1292); // "好霸气的发言。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan28", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui2"});
            yield return _gameMethods.OpenDialog(1293); // "哇！！真的吗？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.5>audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -346.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.31f}, {"zpos", -358.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui19"});
            yield return _gameMethods.OpenDialog(1294); // "「我不会客气的哦？"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<from 0 to 0.5>audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -358.0f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -358.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.31f}, {"zpos", -370.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei3", "yan5", "zui19"});
            yield return _gameMethods.OpenDialog(1295); // "真的真的不会客气的！」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -370.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei3", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(1296); // "为什么要客气。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(1297); // "他反而一副理所当然的态度反问。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan6", "zui9"});
            yield return _gameMethods.OpenDialog(1298); // "明白了。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(1299); // "敞开欲望购物吧，相信黑暗巨龙不会有因为付不起费用而被扣留的一天。"
            yield return _gameMethods.Hide("he");
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/dajie1.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"at", "default"}, {"as", "dajie12"}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(-144f, -396f)}, {"anchor", new Vector2(0f, 0f)}, {"zoom", 0.92f}})});
            yield return _gameMethods.Transition(time:0.8f);
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15"});
            yield return _gameMethods.OpenDialog(1300); // "就像所有曾经遭受饥饿之苦，从此便将饥饿刻在了骨子里的人一样，我无论看到什么，都感觉自己需要、都想买下屯着。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(1301); // "面粉、面包、鸡蛋、黄油、莴苣、卷心菜、火腿、蜂蜜……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan17", "zui15"});
            yield return _gameMethods.OpenDialog(1302); // "甚至，在路过一家香料店时，我大着胆子购入了这种昂贵物品。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 3f, "<silence 0.8>", "audio/sound/emeng_dajie/coins.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(1303); // "赫泽尔对物价似乎毫无概念，也并不在乎，用魔晶石搞定了所有开销。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui15"});
            yield return _gameMethods.OpenDialog(1304); // "由于经济水平的限制，我以前所接触到的钱币最高也只到达银币，根本不清楚这些比金币要更珍贵的魔晶石的价值。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(1305); // "在我的心里，它就像钻石，距离自己的生活太遥远，根本没必要了解确切的价格。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan4", "zui15"});
            yield return _gameMethods.OpenDialog(1306); // "不过，从店主们那心神荡漾、红光满面的表情来看，我们大概做了一桩桩极其败家的赔本买卖。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.47f}, {"ypos", 24f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"yan12", "zui15"});
            yield return _gameMethods.OpenDialog(1307); // "……难受，感觉被坑了。唉，我真是穷惯了。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 24f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 24f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.2f}, {"ypos", 12f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(1308); // "不过，这毕竟不是我的钱，作为受益者，也不应该干涉钱主人的消费习惯。"
            yield return _gameMethods.PlaySound("soundc", 0.0f, 1.0f, "audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.Hide("dajie12");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/bg/dajie1.jpg");
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/dajie3.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.38f, 1.27f)}, {"zoom", 1.31f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 12f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition(time:0.8f);
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan20", "zui15"});
            yield return _gameMethods.OpenDialog(1309); // "因为实在是被饿怕了，生怕没有下一次，我缺乏节制地采购了太多物资。"
            yield return _gameMethods.StopSound(channelName:"soundc", fadeOut:1f);
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"ypos", 2.29f}, {"zoom", 0.45f}, {"xpos", 0.5f}, {"anchor", new Vector2(0.5f, 1.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}, {"blur", 0.01f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1f}, {"blur", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(1310); // "最后我终于不好意思了，装模做样地问。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.7f, "audio/sound/moca1.ogg");
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(1311); // "「这么多东西，不好拿吧，{nw}{w=0.1}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}, {"blur", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan5", "zui19"});
            yield return _gameMethods.OpenDialog(1312); // "要不今天就先不买别的了？」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(1313); // "不用。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan10", "zui2"});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/emeng_dajie/magic1.ogg");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(1314); // "他只说了这么一句，所有物品就都被气流托起一般，凭空浮起，{nw}{w=0.1}"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/demo_audio/sound/strange_wave.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1315); // "飘在半空中，像宠物一样跟随着我们。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 2f, "<from 0 to 1>audio/demo_audio/sound/zu3_nv_zou.ogg");
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 2.29f)}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.7f}, {"zpos", 24.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(1316); // "「还有要买的么。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 24.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan3", "zui15"});
            yield return _gameMethods.OpenDialog(1222); // "「……"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan4", "zui15"});
            yield return _gameMethods.OpenDialog(1265); // "……」"
            yield return _gameMethods.EngineSetVolume(volume:4f, delay:0.5f, channelName:"soundb");
            yield return _gameMethods.Show("he", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}, {"blur", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"alpha", 0f}, {"blur", 0.01f}})});
            yield return _gameMethods.PlaySound("sounda", 0.0f, 3f, "audio/sound/jiaotang/Crow Whisper_01.ogg");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan4", "zui15"});
            yield return _gameMethods.OpenDialog(1317); // "路上的行人们投来惊叹又敬畏的眼神，让开道路，空出距离。"
            yield return _gameMethods.Hide("he");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan7", "zui15"});
            yield return _gameMethods.OpenDialog(1318); // "他们一定把赫泽尔当作了强大的魔法师。"
            yield return _gameMethods.EngineSetVolume(volume:1f, delay:3f, channelName:"soundb");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(1319); // "尽管能用魔法做到便利生活，几乎没有魔法师舍得如此浪费魔力。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(1320); // "很多世人口中尊称的“魔法师”，充其量只是在呕心沥血备齐材料之后、才能以仪式制造出一两次神奇效果的魔法学徒罢了。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(1321); // "因此，赫泽尔的这种做法，在人类看来是一种挥霍与奢侈。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(1322); // "换句话说，是实力雄厚的高等贵族才能支撑的作风。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "ya20", "zui15"});
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:10f);
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 2f}, {"blur", 9.62f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei6", "yan12", "zui9"});
            yield return _gameMethods.OpenDialog(1323); // "如果我有魔法天赋就好了。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei6", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(1324); // "或者哪怕觉醒骑士血脉，也能借此赚些收入，买到魔法治疗服务。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg47_memory.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg47_memory.jpg");
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/dajie2.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.38f, 1.27f)}, {"zoom", 1.31f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.3f}, {"alpha", 1f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 9.62f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei6", "yan20", "zui9"});
            yield return _gameMethods.OpenDialog(1325); // "那么、也许她就不会……"
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/dajie2.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
            yield return _gameMethods.TransitionBy("blink2");
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/emeng_dajie/Magic Spell Book Pages Flipping_01.ogg");
            yield return _gameMethods.OpenDialog(1326); // "忽然、我感到一阵强烈的被注视感。"
            yield return _gameMethods.EngineSetVolume(volume:0.3f, delay:3f, channelName:"soundb");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}, {"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.72f}, {"xpos", -324f}, {"zpos", -132f}})});
            yield return _gameMethods.OpenDialog(1327); // "随之望去——"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/emeng_dajie/Heavy Gong Logo_01.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", -324f}, {"zpos", -132.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.65f}, {"pos", new Vector2(-438f, 138f)}})});
            yield return _gameMethods.OpenDialog(1328); // "在街角的阴影里，蹲着一些衣不蔽体的孩子。"
            yield return _gameMethods.PlaySound("soundc", 1f, 1.0f, "audio/sound/emeng_dajie/Children_01.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-438f, 138f)}, {"zpos", -132.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(1329); // "其中男孩有，但更多的是女孩。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(1330); // "在农业时代，男性被视作家中重要的劳动力，重男轻女现象比工业时期更加严重。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(1331); // "她们渴望地盯着我怀里的面包。"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/manbu/Body1_01.mp3");
            yield return _gameMethods.StopSound(channelName:"soundc", fadeOut:3f);
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/dajie2.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(1332); // "但见我望去，那些孩子们便唯恐得罪了大人物一样，惊恐地纷纷低头缩紧。"
            yield return _gameMethods.PlaySound("music", 2f, 0.9f, "audio/music/Fall.mp3");
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/dajie2.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(1333); // "（如果当初不够幸运，我很有可能成为其中一员。）"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(1334); // "然后，不幸的话，冻死在哪个冬天。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15"});
            yield return _gameMethods.OpenDialog(1335); // "而若有幸能活下来，长到十二三岁，就会被当地的黑商盯上挑选。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(1336); // "漂亮的，就做餐厅旅馆的服务员招揽生意。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan20", "zui15"});
            yield return _gameMethods.OpenDialog(1337); // "不漂亮的，则进到后厨仓库干些杂货。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(1338); // "他们不会更早做这件事，因为没人愿意承担把一个孩子喂大的口粮。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui15"});
            yield return _gameMethods.OpenDialog(1339); // "说来，这两年，居无定所的人似乎多了不少。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1340); // "这也是经济不景气的表现之一。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15"});
            yield return _gameMethods.OpenDialog(1341); // "其实前两年，人们过得没这么凄惨。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(1342); // "曾经有过一段物资丰饶的时期，那时气候温暖，麦子丰收，牲畜繁衍。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan4", "zui15"});
            yield return _gameMethods.OpenDialog(1343); // "几乎没人吃稀粥，即便最穷苦的人家也能吃得起褐色面包，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(1344); // "而富裕一些的农民或劳工，更是以小麦白面包为日常主食，每天喝牛奶。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(1345); // "可从十年前开始，天气一年比一年冷，旱涝灾害与植株病灾频发，粮食产量也下滑了。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan20", "zui15"});
            yield return _gameMethods.OpenDialog(1346); // "经济上的窘境，促使一些兽人部落、或人类国家向外征讨，企图用暴力从邻居那里获取食物。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(1347); // "而爆发的局部战争，则又让人们的生活水平变得更加一塌糊涂。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan20", "zui15"});
            yield return _gameMethods.OpenDialog(1348); // "很多人说，这是由于预言中的灾厄纪年即将到来的原因。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan20", "zui15"});
            yield return _gameMethods.OpenDialog(1349); // "灾厄纪年……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(1350); // "灾厄之龙？"
            yield return _gameMethods.EngineSetVolume(volume:0.8f, delay:1f, channelName:"soundb");
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1>audio/demo_audio/sound/zu3_nv_zou.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", -438f}, {"zpos", -132.0f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.2f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.46f}, {"xpos", -264f}, {"zpos", -78.0f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.3f, 2.84f)}, {"zoom", 0.53f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(1351); // "你在看什么？"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", -264f}, {"zpos", -78.0f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(1352); // "我的停驻引起了赫泽尔的注意。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(1353); // "我望着面前的灾厄之龙。他看起来和人类国度中普通的贵族家小少爷别无二致。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan6", "zui10"});
            yield return _gameMethods.OpenDialog(780); // "没什么。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", -264f}, {"zpos", -78.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.50f}, {"xpos", -486f}, {"zpos", -228.0f}})});
            yield return _gameMethods.Show("he", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui15"});
            yield return _gameMethods.OpenDialog(1354); // "我又看向了之前那处街角。"
            yield return _gameMethods.Show("he", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", -486f}, {"zpos", -228.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui15"});
            yield return _gameMethods.OpenDialog(1355); // "赫泽尔顺着我的目光望去，却对那几个孩子视若无睹，仿佛眼里根本没有这几号人似的，不解地回望我。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", -486f}, {"zpos", -228.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.50f}, {"xpos", -264f}, {"zpos", -78.0f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan10", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.Transition();
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_qian");
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(594); // "？"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan8", "zui10"});
            yield return _gameMethods.OpenDialog(1356); // "我在看那些孩子。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", -264f}, {"zpos", -78.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(1357); // "她们很可怜。但我没有把这句话说出口。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(1358); // "以我寄人篱下的身份，这样的……{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15"});
            yield return _gameMethods.OpenDialog(1359); // "呃，情感软弱、极大概率会引来他的不快与反感。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(1360); // "毕竟，弱者的同情心在强者眼中总归会显得缺乏自知之明。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan10", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}, {"blur", 0.001f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 0f}, {"blur", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(1361); // "他又看了看孩子，"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}, {"blur", 0.001f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1f}, {"blur", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1362); // "转回头来，白皙精致的脸上没有任何表情。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(1363); // "所以？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(1364); // "……你在同情他们？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(1365); // "我心中挣扎片刻，{nw}{w=0.1}"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 138f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.2f}, {"ypos", 174f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.24f}, {"ypos", 144f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.26f}, {"ypos", 180f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.2f}, {"ypos", 138f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei6", "yan12", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(1366); // "最终还是沉痛地点了点头。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan4", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei6", "yan12", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1>audio/demo_audio/sound/zu3_nv_zou.ogg");
            yield return _gameMethods.Show("he", parts: new List<string>{"mei4", "yan25", "zui13"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.49f}, {"zpos", 36.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei4", "yan5", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(1367); // "生物的生死是自然常态，阻止它没有任何意义。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 138f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan28", "zui9"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 36.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei3", "yan2", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(1368); // "「优胜劣汰，{nw}{w=0.1}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(1369); // "这是世界的法则，自然的规律。{nw}{w=0.1}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei3", "yan120", "zui15"});
            yield return _gameMethods.OpenDialog(1370); // "机体的自我清理是必要的。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei4", "yan5", "zui10", "emoji2"});
            yield return _gameMethods.OpenDialog(1371); // "你说得太对了。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan5", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(1372); // "我诚恳应和。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(1373); // "很在理，这种人、这种事在这片大陆上多如牛毛。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(1374); // "即便救了一个、十个、一百个，对整个世界的局势也不会有什么改变。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(1375); // "所以……我要怎么做呢？"
            yield return _gameMethods.OpenSelectMenu(talk: new List<string>{"-对孩子施以援手", "-还是别干涉了"}, jump: new List<string>{"label_zhuxian_1_menu_0_nWmrA0MU", "label_zhuxian_1_menu_0_HKPTHQ9W"}, condition: new List<string>{"NONE", "NONE"});
        }

        public IEnumerator label_choice6()
        {
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan8", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan8", "zui7"});
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui2", "emoji1"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.45f}, {"zpos", -30.0f}})});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(1482); // "既然能看到，那你也能影响别人身上的灾祸吗？"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -30.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan6", "zui10"});
            yield return _gameMethods.OpenDialog(1483); // "增加或减少什么的。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2", "-emoji1"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan6", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice6_0e2b12f3.ogg");
            yield return _gameMethods.OpenDialog(1484); // "只能施加，不能拿走。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(1485); // "他抬眸看向我，似乎是打算一次性和我说明白。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(1486); // "我是灾祸之龙。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui9"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(1487); // "「我掌握毁灭的权柄，降下天灾、战争、瘟疫与饥荒，{nw}{w=0.1}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan10", "zui12"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice6_ea429194.ogg");
            yield return _gameMethods.OpenDialog(1488); // "散播悲伤、仇恨、痛苦和绝望，{nw}{w=0.1}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan27", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(1489); // "却永远不会去修复或拯救什么。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui12"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice6_5ccb54cc.ogg");
            yield return _gameMethods.OpenDialog(1490); // "修补——或者说，创造，是神圣母龙的职责。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice6_340bd4ef.ogg");
            yield return _gameMethods.OpenDialog(1491); // "她热衷于生命、新事物与喜悦。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(1492); // "他那副超然而淡漠的态度，令我陷入了默然。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan8", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan17", "zui15"});
            yield return _gameMethods.OpenDialog(1493); // "……为什么能这么平静呢。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan20", "zui15"});
            yield return _gameMethods.OpenDialog(1494); // "因为你是龙，所以才能够这样高高在上地俯瞰人间吗。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan5", "zui19"});
            yield return _gameMethods.OpenDialog(1495); // "「呃……"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan6", "zui19"});
            yield return _gameMethods.OpenDialog(1496); // "那、"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(1497); // "嗯。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui19"});
            yield return _gameMethods.OpenDialog(1498); // "「……那你的情绪可真稳定啊，"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui19"});
            yield return _gameMethods.OpenDialog(1499); // "以一位掌管悲伤、仇恨和绝望的龙来说。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei4", "yan4", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice6_8ec000d6.ogg");
            yield return _gameMethods.OpenDialog(1500); // "那些东西不会影响我本身。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei4", "yan25", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice6_90bf1f66.ogg");
            yield return _gameMethods.OpenDialog(1501); // "我管理它们，确保一切事物在正确的轨道上运行，而不是受其管理。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei4", "yan25", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan3", "zui15"});
            yield return _gameMethods.OpenDialog(1502); // "有道理。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice6_71f8e481.ogg");
            yield return _gameMethods.OpenDialog(1503); // "况且，我不可能既愤怒仇恨，同时又悲伤绝望。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan9", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice6_2434e5e8.ogg");
            yield return _gameMethods.OpenDialog(1504); // "愤怒的人是不会绝望的，绝望的前提是接纳现实。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui18"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice6_4195e28b.ogg");
            yield return _gameMethods.OpenDialog(1505); // "绝望的人也不会悲伤，悲伤是因为还心存侥幸。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(1506); // "……这样啊。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(1507); // "绝望，就是已经麻木了。{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(1508); // "心灵像干瘪枯涸的果实，再也无法被命运或苦难挤出一丝汁液。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(1509); // "这样看来，我还不能算作绝望。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan17", "zui15"});
            yield return _gameMethods.OpenDialog(1510); // "因为我既没有完全接受现实，也还心存侥幸。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(1511); // "你见过很多绝望的人吗？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(612); // "{nw}{w=0.12}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(1512); // "他摇了摇头。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan24", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(1513); // "确实，想符合这个条件也很难吧……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei8", "yan24", "zui7", "emoji2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice6_d834922e.ogg");
            yield return _gameMethods.OpenDialog(765); // "嗯。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei8", "yan2", "zui15", "-emoji2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice6_c3b71353.ogg");
            yield return _gameMethods.OpenDialog(1514); // "大多人只是自认为走投无路，不知道身上实则还有很多可以失去的东西。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice6_f61bd729.ogg");
            yield return _gameMethods.OpenDialog(1515); // "当这些东西全部失去时，这个人通常也不会存在太久了。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan12", "zui15", "emoji2", "emoji6"});
            yield return _gameMethods.OpenDialog(1516); // "好不道德的结论啊。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan10", "zui7", "emoji2", "emoji6"});
            yield return _gameMethods.OpenDialog(1517); // "绝望的人一般会寻死，所以活人中很少存在绝望的人是吗。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan8", "zui10", "emoji2", "-emoji6"});
            yield return _gameMethods.OpenDialog(1518); // "……所以，人们多数时候只是在悲伤和痛苦。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei3", "yan8", "zui15", "-emoji2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice6_1981d8e8.ogg");
            yield return _gameMethods.OpenDialog(765); // "嗯。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(1519); // "好吧，这真是一年来最振奋人心的一个消息了。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(1520); // "痛苦，是因为我还活着……"
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:8f);
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition(time:0.5f);
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.OpenDialog(1521); // "这一天，我们横扫了整条商业街，为这座边陲小镇的经济发展做出了不可磨灭的伟大贡献。"
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:4f);
            yield return _gameMethods.OpenDialog(481); // "……………………"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/door_open1.mp3");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_dating_baitian.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.0f)}, {"zoom", 0.89f}})});
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            yield return _gameMethods.OpenDialog(1522); // "回到城堡后"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<from 0 to 2>audio/sound/jiaobusheng_xin_kuai1.ogg");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_chufang_baitian.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.0f)}, {"zoom", 0.89f}})});
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            yield return _gameMethods.OpenDialog(1523); // "我迫不及待地进入了厨房。"
            yield return _gameMethods.OpenDialog(1524); // "虽然因为之前的事，心情难免沉重，但我想尽可能地让自己保持住轻松愉快的心理状态。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan9", "zui15"});
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.PlaySound("music", 3f, 0.7f, "audio/music/host_clean.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(1525); // "开心。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan9", "zui6"});
            yield return _gameMethods.OpenDialog(1526); // "开心起来。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan21", "zui8"});
            yield return _gameMethods.OpenDialog(1527); // "给我开心！"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan9", "zui7"});
            yield return _gameMethods.OpenDialog(1528); // "……我试图用更令人愉快的事物转移注意力。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui7"});
            yield return _gameMethods.OpenDialog(1529); // "嗯。好多美味的食材，要怎么处理才好呢。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui7"});
            yield return _gameMethods.OpenDialog(1530); // "是的，我应该期待……这是一件值得期待的事情。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui7"});
            yield return _gameMethods.OpenDialog(1531); // "因为期待，所以也值得快乐。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(1532); // "所以、我……"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(1533); // "好期待啊～"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1>audio/demo_audio/sound/zu3_nv_zou.ogg");
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 2.34f)}, {"zoom", 0.47f}, {"alpha", 0f}, {"xoffset", 30f}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan11", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice6_c3049f67.ogg");
            yield return _gameMethods.OpenDialog(1534); // "你很高兴。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui2"});
            yield return _gameMethods.OpenDialog(1535); // "当然啦。这个我一直都想吃呢！"
            Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(1536); // "多亏了赫泽尔，你真好。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan8", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan11", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice6_4c5a02ae.ogg");
            yield return _gameMethods.OpenDialog(1537); // "……没什么。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan8", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan3", "zui10"});
            yield return _gameMethods.OpenDialog(1538); // "可惜你不吃人类的食物，不然真想和你一起吃饭。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan3", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice6_fe8f9bf3.ogg");
            yield return _gameMethods.OpenDialog(1539); // "我可以进食，只是不以此为生。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(1540); // "啊……真的吗？！"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.5>audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.38f}, {"zpos", -24.0f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan5", "zui19"});
            yield return _gameMethods.OpenDialog(1541); // "「那，下次等我做了我的拿手作，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui19"});
            yield return _gameMethods.OpenDialog(1542); // "就给你尝尝吧！」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan28", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(1543); // "「……{nw}{w=0.4}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -24.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(1497); // "嗯。」"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 2>audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_chufang_jiazi_baitian.jpg");
            yield return _gameMethods.Transition();
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui7"});
            yield return _gameMethods.OpenDialog(1544); // "我对食材进行了初步的处理，{nw}{w=0.1}"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/ding1.mp3");
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/heilong_chufang_jiazi_man_baitian.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1545); // "然后分门别类收纳在了储存室中。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/heilong_chufang_jiazi_man_baitian.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui7"});
            yield return _gameMethods.OpenDialog(1546); // "拜托赫泽尔给装置补充完魔力后，这里已经恢复了低温干燥的贮藏功能。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui7"});
            yield return _gameMethods.OpenDialog(1547); // "给食品保鲜两三个月，约莫不是问题。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui7"});
            yield return _gameMethods.OpenDialog(1548); // "饮食问题，总算是解决了。"
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.Transition(time:1f);
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:5f);
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.OpenDialog(481); // "……………………"
            yield return _gameMethods.PlaySound("soundb", 0.0f, 1.0f, "audio/demo_audio/sound/niaoming.ogg");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/woshi_nv2_tian.jpg");
            yield return _gameMethods.Transition(time:0.6f);
            Defaults.Persistent.Jq_2_3 = 1;
            Defaults.Haogandu_an = Defaults.Haogandu_an + 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15"});
            yield return _gameMethods.OpenDialog(1549); // "这天，一觉醒来，我就察觉到了身体的异样。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.5f, "<from 0 to 4>audio/demo_audio/sound/xintiao.ogg");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(1550); // "虚弱发冷，头的一侧还传来了熟悉的阵痛。"
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:9f);
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan20", "zui15"});
            yield return _gameMethods.OpenDialog(1551); // "……啊，该来的还是来了。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(1552); // "偏头痛。"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/demo_audio/sound/tangxia2_duan.mp3");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/woshi_nv_chuang.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.38f, 1.09f)}, {"zoom", 0.42f}})});
            yield return _gameMethods.Transition(time:0.5f);
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan9", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(1553); // "第一反应是尝试止痛。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(1554); // "……不好，没有提前准备。"
            yield return _gameMethods.PlaySound("music", 3f, 1.0f, "audio/demo_audio/music/youshang2.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(1555); // "不清楚是因为水土还是什么，总之，自从我到达黑龙城堡后，一连两个月都没有发生偏头痛。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(1556); // "我得赶紧打开窗透透气。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan10", "zui15"});
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<silence 0.6>", "audio/sound/emeng_dajie/Lying Bed_01.mp3");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/woshi_nv2_tian.jpg");
            yield return _gameMethods.Transition(time:0.6f);
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan12", "zui10"});
            yield return _gameMethods.OpenDialog(1557); // "不想起床。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(1558); // "我有点恹恹地躺在床上。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(1559); // "但理智告诉我，如果再不起身，很可能会疼得晕过去，白白增加负担。"
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/emeng_dajie/Body_up_01.mp3");
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(1560); // "……最后，我痛苦地起了床。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 2>audio/sound/jiaobusheng_xin_normal1.ogg", "audio/demo_audio/sound/tangxia2_duan.mp3");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/woshi_nv2.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.94f, 1.23f)}, {"zoom", 0.89f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(1561); // "做好准备工作后，打开窗户，窝在沙发上。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan24", "zui16", "emoji2"});
            yield return _gameMethods.OpenDialog(1562); // "沙发太短，没法躺下。"
            yield return _gameMethods.EngineSetVolume(volume:0.2f, delay:2f, channelName:"music");
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.6f, "audio/demo_audio/sound/door_qiao2.ogg");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1563); // "咚、咚。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(1564); // "……敲门声？"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan3", "zui15"});
            yield return _gameMethods.OpenDialog(1565); // "是听错了吧。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/door_qiao2.ogg");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1563); // "咚、咚。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan2", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.OpenDialog(491); // "………………"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/demo_audio/sound/tangxia2_duan.mp3", "<from 0 to 3>audio/sound/jiaobusheng_xin_man1.ogg");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/woshi_nv_men_guan.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.0f)}, {"zoom", 0.68f}})});
            yield return _gameMethods.Transition(time:1f);
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(1566); // "我挣扎片刻，认命地起身开门。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(0f, 0f)}, {"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.5f}, {"pos", new Vector2(-30f, 84f)}, {"zpos", -528.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(481); // "……………………"
            yield return _gameMethods.EngineSetVolume(volume:1f, delay:2f, channelName:"music");
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.7f, "audio/sound/door_open_3.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-30f, 84f)}, {"zpos", -528.0f}})});
            yield return _gameMethods.Hide("Assets/RenpyResources/images/bg/woshi_nv_men_guan.jpg");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/zoulang_zhuanjiao2.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.48f, 0.96f)}, {"zoom", 0.31f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.46f, 1.27f)}, {"zoom", 0.17f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/woshi_nv_men_kao.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.03f)}, {"zoom", 0.68f}})});
            yield return _gameMethods.TransitionBy("blink2");
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.OpenDialog(1567); // "赫泽尔站在门外，神情平淡地看着我。"
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(1568); // "大概是见我没有下楼，就过来看看情况吧。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(1569); // "你生病了？ "
            yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(1570); // "「啊，没有没有，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(1571); // "我就是有点起晚了。」"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui19"});
            yield return _gameMethods.OpenDialog(1572); // "不好意思哦，让你担心了。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan11", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(611); // "{nw}{w=0.2}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(612); // "{nw}{w=0.12}"
            Engine._history = true;
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan57ui19"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice6_826aa89d.ogg");
            yield return _gameMethods.OpenDialog(765); // "嗯。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:4f);
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1573); // "他点了点头，{nw}{w=0.25}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan2", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1574); // "平静的脸色忽然发生了变化，{nw}{w=0.25}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1575); // "稍微皱眉。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(924); // "……？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan24", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1576); // "赫泽尔鼻尖耸动片刻，双瞳微微眯起，锁定在我身上，眼珠不动了。"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<silence 0.5>", "<from 0 to 1>audio/demo_audio/sound/zu3_nv_zou.ogg");
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.5f, "audio/demo_audio/sound/door_close1.mp3");
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/woshi_nv_men_guan.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.03f)}, {"zoom", 0.68f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"alpha", 1f}})});
            yield return _gameMethods.Hide("he");
            yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan24", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.17000000000000004f}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.46f, 1.27f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.2f}, {"ypos", 1.32f}, {"zoom", 0.18f}})});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(1577); // "接着，他迈步走向了我。"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<from 0 to 2>audio/demo_audio/sound/zu3_nv_zou_man.ogg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/bg/woshi_nv_men_kao.png");
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/woshi_nv_men_guan.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan24", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}, {"ypos", 1.32f}, {"zoom", 0.18f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.9f}, {"zpos", 66.0f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -528.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.9f}, {"zpos", -500.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan2", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(1578); // "他明明身形纤小，但蹙眉沉默走近时，却有种令人想要退却的气质。"
            yield return _gameMethods.PlaySound("sounda1", 0.0f, 1.0f, "<from 0 to 0.6>audio/sound/jiaobusheng_xin_kuai1.ogg");
            yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan28", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 66.0f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -500.0f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -500.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.40f}, {"zpos", -470.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(1579); // "我克制不住地后退几步，"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.5>audio/demo_audio/sound/zu3_nv_zou_man.ogg");
            yield return _gameMethods.PlaySound("sounda1", 0.0f, 0.4f, "<silence 0.5>", "audio/demo_audio/sound/moca2.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -470.0f}})});
            yield return _gameMethods.Show("he", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 66.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 102.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan2", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(1580); // "又因他的目光感到害怕，"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/emeng_dajie/Lying Bed_01.mp3");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/cg/fenjin/shengliqi_chuangshang.jpg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-270f, -96f)}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            Defaults.Gui_duihuakuang_you = 0;
            yield return _gameMethods.Show("_zoom");
            yield return _gameMethods.Hide("_zoom");
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(1581); // "不敢动弹。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(1582); // "怎么了？"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 0.6f, "audio/demo_audio/sound/moca7_chang.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-270f, -96f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.3f}, {"pos", new Vector2(-228f, -318f)}})});
            yield return _gameMethods.OpenDialog(1583); // "他没有回答，皱着眉对着我看来看去，有目标地搜寻什么一般。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(-228f, -318f)}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(1584); // "等等……等一下！"
            yield return _gameMethods.PlaySound("sounda1", 0.0f, 1.5f, "<silence 0.5>", "audio/demo_audio/sound/moca3.mp3");
            yield return _gameMethods.OpenDialog(1585); // "他的眼神在我的头上停留，手指轻轻划过我的头发，{nw}{w=0.01}"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/fenjin/shengliqi_chuangshang.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"at", "default"}, {"as", "shengliqi_chuangshang2"}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(-306f, -342f)}, {"zpos", 0.0f}, {"anchor", new Vector2(0f, 0f)}, {"zoom", 0.75f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.7f}, {"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(1586); // "停在了我的头顶。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/moca6_duan.mp3");
            yield return _gameMethods.PlaySound("sounda", 0.0f, 2f, "<silence 0.6>", "audio/demo_audio/sound/zhenjing_shuaidaoganjue.mp3");
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/fenjin/shengliqi_chuangshang.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"as", "shengliqi_chuangshang2"}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(1587); // "他抬头要拨开我的头发，我忙按住他的手。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei6", "yan17", "zui12", "emoji2"});
            yield return _gameMethods.OpenDialog(1588); // "等等这里真的不行！！"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei6", "yan12", "zui12", "emoji2", "emoji11"});
            yield return _gameMethods.OpenDialog(1589); // "{size=+10}「……到底怎么了！"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei6", "yan14", "zui13", "emoji2", "emoji11"});
            yield return _gameMethods.OpenDialog(1590); // "我真的发火了！」{/size}"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/tangxia2_duan.mp3");
            yield return _gameMethods.Scene("woshi_nv_chuang", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.79f, 1.62f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.64f}, {"blur", 5f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan28", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 3.48f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.72f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition(time:0.6f);
            Defaults.Gui_duihuakuang_you = 1;
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_qian");
            yield return _gameMethods.OpenDialog(611); // "{nw}{w=0.2}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice6_145e9217.ogg");
            yield return _gameMethods.OpenDialog(1591); // "你受伤了。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei6", "yan14", "zui18", "emoji2", "-emoji11"});
            yield return _gameMethods.OpenDialog(1592); // "他停下了动作，血红的竖瞳盯着我，解释。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan28", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(1593); // "痛苦的气息太过浓烈。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan28", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei6", "yan12", "zui18", "emoji2"});
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei4", "yan2", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(924); // "……？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan28", "zui2"});
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.6f, "audio/sound/moca1.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei3", "yan6", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(1222); // "「……"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei4", "yan2", "zui10", "emoji2"});
            yield return _gameMethods.OpenDialog(1594); // "啊，"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei5", "yan2", "zui12", "emoji2"});
            yield return _gameMethods.OpenDialog(1595); // "啊啊啊啊、那个！」"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan17", "zui13", "emoji2"});
            yield return _gameMethods.OpenDialog(1596); // "啊啊啊啊啊啊啊。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.30f}, {"zpos", 42.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei6", "yan20", "zui23", "emoji2", "emoji16"});
            yield return _gameMethods.OpenDialog(1597); // "「不，"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 42.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei6", "yan11", "zui13", "emoji2", "emoji16"});
            yield return _gameMethods.OpenDialog(659); // "呃，"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei6", "yan5", "zui12", "emoji2", "-emoji16"});
            yield return _gameMethods.OpenDialog(1598); // "我没有受伤！」"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan19", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(1599); // "「……{nw}{w=0.1}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "zui21"});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_portrait/he/he_yan20.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}, {"pos", new Vector2(0.5f, 3.48f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.72f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei6", "yan5", "zui18", "emoji2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice6_0b85342d.ogg");
            yield return _gameMethods.OpenDialog(1600); // "为什么要隐瞒。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan20", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(1601); // "似乎因为我的隐瞒而焦躁不悦一般，他态度笃定，{nw}{w=0.1}"
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.6f, "audio/demo_audio/sound/moca4_duan.mp3");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_portrait/he/he_yan20.png");
            yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan33", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 1f}, {"zpos", 126.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1602); // "不容违逆地就要拨开我的头发寻找伤口。"
            yield return _gameMethods.Show("he", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 126.0f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan1", "zui15"});
            yield return _gameMethods.OpenDialog(1603); // "！！！"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
            yield return _gameMethods.OpenSelectMenu(talk: new List<string>{"-发火", "-发火", "-发火"}, jump: new List<string>{"label_zhuxian_1_menu_0_fTyqxEBk", "label_zhuxian_1_menu_0_fTyqxEBk", "label_zhuxian_1_menu_0_fTyqxEBk"}, condition: new List<string>{"NONE", "NONE", "NONE"});
        }

        public IEnumerator label_choice7()
        {
            yield return _gameMethods.OpenDialog(1604); // "毫无疑问，我的力气在他面前不值一提。"
            yield return _gameMethods.OpenDialog(1605); // "本来就因为偏头痛而身体不适，我感觉大脑一片空白，理智断了线一样。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/moca6_duan.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.44f}, {"xpos", -24f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.11f}, {"xpos", -42f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.44f}, {"ypos", 318f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.11f}, {"ypos", 310f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.22f}, {"ypos", 318f}})}, parallel_2: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 42.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.77f}, {"zpos", 138.0f}})});
            yield return _gameMethods.Show("he", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 126.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.23f}, {"zpos", 126.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.21f}, {"zpos", 80.0f}, {"ypos", 3.52f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei6", "yan11", "zui13", "emoji22"});
            yield return _gameMethods.OpenDialog(1606); // "放手！！！"
            yield return _gameMethods.PlaySound("music", 2f, 0.6f, "audio/music/PerituneMaterial_Guitar_Gentle_loop.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-42f, 318f)}, {"zpos", 138.0f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan2", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 80.0f}, {"ypos", 3.52f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei6", "yan11", "zui18", "emoji22"});
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 318f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.8f}, {"ypos", 90f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei6", "yan13", "zui18", "emoji21", "-emoji22"});
            yield return _gameMethods.OpenDialog(1607); // "鼻子眼眶酸涩。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}, {"ypos", 90f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.38f}, {"blur", 2.56f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei6", "yan21", "zui18", "emoji18", "emoji21"});
            yield return _gameMethods.OpenDialog(1608); // "泪珠都似乎要不受控制地夺眶而出。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei4", "yan22", "zui2"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 2.56f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei6", "yan20", "zui18", "emoji18", "emoji21"});
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.6f, "audio/demo_audio/sound/tangxia2_duan.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 2.56f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.49f}, {"blur", 0.0f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei4", "yan27", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 80.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.8f}, {"zpos", 32.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1609); // "他松开了手，默默观察着我的脸色。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
            yield return _gameMethods.Show("he", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 32.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1610); // "……还是说，在感受我的情绪？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice7_83f70765.ogg");
            yield return _gameMethods.OpenDialog(1611); // "你生气了。"
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei6", "yan12", "zui15", "emoji18", "emoji21"});
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei4", "yan8", "zui15", "emoji18", "-emoji21"});
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice7_86089e14.ogg");
            yield return _gameMethods.OpenDialog(1612); // "我并没有想惹恼你。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei4", "yan12", "zui15", "emoji18"});
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei4", "yan8", "zui15", "-emoji18"});
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(1613); // "……如果我现在就走，能让你觉得高兴一点么。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei4", "yan17", "zui12"});
            yield return _gameMethods.OpenDialog(1614); // "「没有真的不是……"
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.6f, "audio/sound/moca1.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
            yield return _gameMethods.OpenDialog(1615); // "这是正常的生理现象！」"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei5", "yan2", "zui12"});
            yield return _gameMethods.OpenDialog(1616); // "「有些人不定期就会有一次的！{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei5", "yan5", "zui11"});
            yield return _gameMethods.OpenDialog(1617); // "不止是我其他人也会有的。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei5", "yan5", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian1_2a9f81f6.ogg");
            yield return _gameMethods.OpenDialog(663); // "为什么。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(1618); // "在他冷静的提问中，我的情绪逐渐平复。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan12", "zui10"});
            yield return _gameMethods.OpenDialog(1619); // "这是压力过大的一种表现。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei4", "yan4", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei3", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(1620); // "压力过大就会产生剧痛？这不利于野外生存。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei4", "yan4", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan10", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(1621); // "……多么令人痛哭的求真精神。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan12", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(1622); // "我强行冷静下来，试图和他沟通。"
            yield return _gameMethods.EngineSetVolume(volume:0.6f, delay:2f, channelName:"music");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"blur", 5f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(1623); // "的确，这个世界的医学主要建立在草药、一些简单的外科手术（主要指截肢），{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan20", "zui15"});
            yield return _gameMethods.OpenDialog(1624); // "以及最重要的——疗愈术的基础上。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 5f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(1625); // "而在解剖学方面，则进展有限。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan19", "zui15"});
            yield return _gameMethods.OpenDialog(1626); // "……至少在人类的国家，大部分认为人类是自然的造物。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan7", "zui15"});
            yield return _gameMethods.OpenDialog(1627); // "既然如此，剖开人体去研究它的内在，显然，是对自然的不敬。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan9", "zui15"});
            yield return _gameMethods.OpenDialog(1628); // "学校在宣讲时，倒也提及过人体拥有心、肝、肺等几种主要的内脏，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan4", "zui15"});
            yield return _gameMethods.OpenDialog(1629); // "这些器官以奇妙的方式相互协作，以此展示人体构造的鬼斧神工，与自然的伟大。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan10", "zui15"});
            yield return _gameMethods.OpenDialog(1630); // "（我猜他们私下里肯定还是有人在解剖的。）"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(1631); // "然而，并没有人试图了解疼痛的原理，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(1632); // "/n这被简单地视作一种意外，被视为不详和霉运的象征。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(1633); // "这种抽象的说法，肯定不足以打发掉重视逻辑、对问题追根究底的赫泽尔。"
            yield return _gameMethods.EngineSetVolume(volume:0.7f, delay:2f, channelName:"music");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 5f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.49f}, {"blur", 0.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(1634); // "我决定一口气堵死他提问的可能。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei4", "yan4", "zui2"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 138.0f}, {"blur", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.26f}, {"zpos", 102.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(1635); // "嗯…就是，当压力过大的时候，人的神经会遭受刺激得到激活，释放某种物质。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 102.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan6", "zui11"});
            yield return _gameMethods.OpenDialog(1636); // "这些物质又会导致脑部的血管扩张以及炎症，刺激神经，引起疼痛。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan12", "zui12"});
            yield return _gameMethods.OpenDialog(1637); // "下次依然如此，次次相同。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei3", "yan5", "zui12"});
            yield return _gameMethods.OpenDialog(1638); // "「所以，只要到了压力过大的时候，就有可能头痛，除非摄入一些药物。{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei3", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(1639); // "明白了吗。」"
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:8f);
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei3", "yan5", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice7_5faede16.ogg");
            yield return _gameMethods.OpenDialog(1640); // "哦。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan28", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice7_b469f018.ogg");
            yield return _gameMethods.OpenDialog(1641); // "「你的身体太脆弱了，{nw}{w=0.1}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan27", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(1642); // "区区压力，就会让你如此痛苦。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan10", "zui13", "emoji2"});
            yield return _gameMethods.OpenDialog(1643); // "{size=+10}别小瞧我啊！！！{/size}"
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.6f, "audio/demo_audio/sound/tangxia2_duan.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 102.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.8f}, {"zpos", 162.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan12", "zui12", "emoji2"});
            yield return _gameMethods.OpenDialog(1644); // "总之头疼的时候不要乱动，会更疼。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan12", "zui9"});
            yield return _gameMethods.PlaySound("music", 3f, 1.0f, "audio/demo_audio/music/youshang2.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 162.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei3", "yan5", "zui15", "-emoji2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice7_fb0f00d8.ogg");
            yield return _gameMethods.OpenDialog(1645); // "……好吧，我会记下。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei3", "yan6", "zui15"});
            yield return _gameMethods.OpenDialog(1646); // "你多久会这么头疼一次？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(1647); // "是，会打扰到你吗？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan15", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei3", "yan2", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice7_12aa938e.ogg");
            yield return _gameMethods.OpenDialog(1648); // "「不会。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan15", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 32.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.4f}, {"zpos", 45.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(1649); // "…"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan27", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(1650); // "你会离世吗？」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan27", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 45.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan12", "zui10"});
            yield return _gameMethods.OpenDialog(1651); // "不会啦。就是偶尔会发生几次而已。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan13", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei3", "yan8", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice7_41ab190f.ogg");
            yield return _gameMethods.OpenDialog(1640); // "哦。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan9", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice7_a92b107e.ogg");
            yield return _gameMethods.OpenDialog(1652); // "你的心情不太好。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan9", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(1653); // "……你看到我的负面情绪了吗？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei3", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(1654); // "只有一点，朦朦胧胧的。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan5", "zui10"});
            yield return _gameMethods.OpenDialog(1655); // "「……因为偏头痛时，身体会不舒服，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan7", "zui11"});
            yield return _gameMethods.OpenDialog(1656); // "头痛，浑身无力，心情低落。{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui10"});
            yield return _gameMethods.OpenDialog(1657); // "都是正常现象。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan4", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice7_12540ab7.ogg");
            yield return _gameMethods.OpenDialog(1658); // "……听起来这像是被诅咒了。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan28", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(1659); // "你们人类总有人要经历一段这种状态？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan28", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan5", "zui10"});
            yield return _gameMethods.OpenDialog(1660); // "是的。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan13", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei3", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.6f, "audio/demo_audio/sound/tangxia3_duanduan.mp3");
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 45.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.8f}, {"zpos", 57.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice7_73bbbe4c.ogg");
            yield return _gameMethods.OpenDialog(1661); // "有什么办法能减轻你的痛苦。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 57.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan24", "zui3", "emoji2"});
            yield return _gameMethods.OpenDialog(1662); // "……多喝热水吧，大概。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 162.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.33f}, {"zpos", 198.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(1663); // "没关系，我都习惯啦。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 198.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(1664); // "不过，的确有需要你帮忙的事。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian1_4f491637.ogg");
            yield return _gameMethods.OpenDialog(594); // "？"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(1665); // "我在思考做止痛药的问题。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1666); // "就我所知，殷实人家会用野生草药来制作。{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan18", "zui15"});
            yield return _gameMethods.OpenDialog(1667); // "/n但因为草药比较贵，所以在此之前，我都是通过呼吸新鲜空气来缓解疼痛，这也是平民中的普遍做法。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(1668); // "乡下的空气很清新，很干净。{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan24", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(1669); // "/n主要还是免费，不要花一分钱。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 198.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.25f}, {"zpos", 174.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10", "-emoji2"});
            yield return _gameMethods.OpenDialog(1670); // "我想去买点药草。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 174.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(1671); // "可以，你要这个做什么。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan3", "zui10"});
            yield return _gameMethods.OpenDialog(1672); // "「你看，如果一直头疼，会不方便行动对吧，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei3", "yan5", "zui10"});
            yield return _gameMethods.OpenDialog(1673); // "会影响生活。」"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan9", "zui19"});
            yield return _gameMethods.OpenDialog(1674); // "「所以要用药草来缓解头疼，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan5", "zui19"});
            yield return _gameMethods.OpenDialog(1675); // "就和刚刚说的一样。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan4", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(1676); // "他似乎无法理解。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan4", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(1677); // "药草只能用于一时。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan4", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui19"});
            yield return _gameMethods.OpenDialog(1678); // "所以要多备一点，随时更换。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan28", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(1679); // "他若有所思。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(1680); // "你是需要一种可以及时抑制疼痛的东西。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui10", "emoji12"});
            yield return _gameMethods.OpenDialog(1660); // "是的。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui15", "-emoji12"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice7_73416823.ogg");
            yield return _gameMethods.OpenDialog(1681); // "不用那么麻烦，这可以通过附魔解决。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice7_7aa1eff4.ogg");
            yield return _gameMethods.OpenDialog(1682); // "一个炼金术或奥术纹路就可以达到效果，很简单。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan2", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(1683); // "重新定义简单。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan2", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(1684); // "他的语气如此理所当然，以至于，一个不可思议的猜测呼之欲出。"
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:8f);
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.8f, "audio/demo_audio/sound/tangxia3_duanduan.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 90f}, {"zpos", 174.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.38f}, {"ypos", 48f}, {"zpos", 48.0f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(1685); // "「……难道，"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan17", "zui11"});
            yield return _gameMethods.OpenDialog(1686); // "你要帮我做吗？」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan4", "zui2"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 48f}, {"zpos", 48.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei8", "yan17", "zui15"});
            yield return _gameMethods.OpenDialog(594); // "？"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1687); // "他露出一个“难道你自己会做么”的眼神。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui15"});
            yield return _gameMethods.OpenDialog(1688); // "让灾厄之龙用魔法帮自己做止痛道具什么的。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan11", "zui7"});
            yield return _gameMethods.OpenDialog(1689); // "好奢侈的行为。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan11", "zui7"});
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "<silence 0.8>", "audio/demo_audio/music/richang2.mp3");
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/manbu/Body1_01.mp3");
            Defaults.Gui_duihuakuang_you = 0;
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/fenjin/shengliqi_xunzhao.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.47f, 1.08f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 57.0f}, {"zoom", 0.68f}})});
            yield return _gameMethods.Show("_zoom");
            yield return _gameMethods.Hide("_zoom");
            
            yield return _gameMethods.OpenDialog(1690); // "他把手放在了我的头上，轻轻抚摸着。"
            yield return _gameMethods.OpenDialog(1691); // "感觉有些奇怪，但我忍住了没有躲避。"
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice7_f506b80a.ogg");
            yield return _gameMethods.OpenDialog(1692); // "我感觉有点烦躁。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(1693); // "为什么？"
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(1694); // "因为痛苦的气息。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan23", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.Hide("Assets/RenpyResources/images/cg/fenjin/shengliqi_xunzhao.jpg");
            Defaults.Gui_duihuakuang_you = 1;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan13", "zui9"});
            yield return _gameMethods.Transition(time:0.6f);
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(1695); // "让我觉得你仿佛一直处于危险之中，在我不知道的地方就会离世。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(1222); // "「……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan13", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(1696); // "没那么容易离世的啦。」"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui19"});
            yield return _gameMethods.OpenDialog(1697); // "人类虽然脆弱，却也很坚韧的。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan10", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(1698); // "但是，我经常看见人类的离世。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan10", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui2"});
            yield return _gameMethods.OpenDialog(1699); // "……你和人类社会、有很多直接的接触么？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(1700); // "他摇头。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(1701); // "我掌管黑暗情绪，也能沿着较为激烈的那些，看到相关记忆。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei3", "yan1", "zui15"});
            yield return _gameMethods.OpenDialog(1702); // "即便是碎片，也足够了。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(1703); // "这倒是我此前不知道的。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan12", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(1704); // "……这提醒了我，一定要做好情绪管理。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(1705); // "我需要更加去了解他，尽量知己知彼，摸清他的能力范围。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.6f, "audio/demo_audio/sound/tangxia3_duanduan.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-42f, 48f)}, {"zpos", 48.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.6f}, {"pos", new Vector2(-42f, 84f)}, {"zpos", 174.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui19"});
            yield return _gameMethods.OpenDialog(1706); // "「原来如此，与黑暗情绪有关的记忆吗。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan3", "zui11"});
            yield return _gameMethods.OpenDialog(1707); // "嗯……应该有不少离世和冲突吧。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-42f, 84f)}, {"zpos", 174.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui14"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice7_c6948bf6.ogg");
            yield return _gameMethods.OpenDialog(765); // "嗯。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan10", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(1708); // "所以才这么年纪轻轻就老气横秋了吗。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(1709); // "……话虽如此，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui15"});
            yield return _gameMethods.OpenDialog(1710); // "总感觉他在历史、政治乃至生命哲学等宏观的论题上，都有着超然物外般的成熟。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(1711); // "但涉及到具体地与人交往接触时，却在许多方面都显得比较纯粹呢。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(612); // "{nw}{w=0.12}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(1712); // "不过，我在你身边不是吗。"
            Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan17", "zui19"});
            yield return _gameMethods.OpenDialog(1713); // "这里是世界上最安全的地方了。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan2", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan17", "zui7"});
            yield return _gameMethods.OpenDialog(1714); // "只要，你会保护我。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan21", "zui7"});
            yield return _gameMethods.OpenDialog(1715); // "只要你愿意保护我。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan11", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(1222); // "「……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan9", "zui9", "emoji1"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(1497); // "嗯。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan9", "zui2", "emoji1"});
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:5f);
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(1716); // "……因为实在是太过心有余悸了，我忍不住再次强调。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan9", "zui9", "-emoji1"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 174.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.18f}, {"zpos", 162.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan5", "zui2", "emoji2"});
            yield return _gameMethods.OpenDialog(1717); // "不过随意摸病人的头这种事下次可千万别再做了。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.PlaySound("music", 0.0f, 0.8f, "audio/demo_audio/music/qingkuai2.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 162.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei4", "yan10", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(1718); // "「…话说为什么你这家伙进门都知道敲门，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
            yield return _gameMethods.OpenDialog(1719); // "{sc=2}{size=+10}别的事却能做得毫不犹豫啊！{/size}{/sc}」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan9", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei4", "yan10", "zui8", "emoji2"});
            yield return _gameMethods.OpenDialog(1720); // "…从那里传出了痛苦。而你却在阻止我的检查。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan9", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan2", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(1721); // "他似乎反而有些不满。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan16", "zui9", "emoji0"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice7_487d6114.ogg");
            yield return _gameMethods.OpenDialog(1722); // "「你不该对我有所隐瞒，{nw}{w=0.1}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan16", "zui18", "emoji0"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(1723); // "无论是什么。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan16", "zui2", "emoji0"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan22", "zui23", "emoji2", "emoji6"});
            yield return _gameMethods.OpenDialog(1724); // "啊。头痛。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei6", "yan12", "zui13", "emoji2", "emoji6"});
            yield return _gameMethods.OpenDialog(1725); // "我的头好痛。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan17", "zui2", "-emoji0"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei6", "yan20", "zui8", "emoji2", "emoji6"});
            yield return _gameMethods.OpenDialog(1726); // "他对人类社会的常识真是令人迷惑。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei3", "yan12", "zui19", "emoji2", "emoji6"});
            yield return _gameMethods.OpenDialog(1727); // "「不是隐瞒不隐瞒的问题……{nw}{w=0.1}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan9", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei4", "yan5", "zui10", "emoji2", "-emoji6"});
            yield return _gameMethods.OpenDialog(1728); // "只是以防万一，你知道为什么病人的头不能随意摸吗？」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei7", "yan2", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan20", "zui15", "emoji2", "emoji6"});
            yield return _gameMethods.OpenDialog(1729); // "他会直接回答我刚才说的“会更疼”吗？好不安。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei7", "yan4", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(1730); // "……因为随意的触碰会刺激到病人的头部，导致疼痛加剧。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan6", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei3", "yan2", "zui15", "-emoji6"});
            yield return _gameMethods.OpenDialog(1731); // "而且，过分亲密对人类也算是冒犯行为。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan4", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1732); // "他用有点鄙视的眼神看我。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan16", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(1733); // "你当我没记住你说过的话吗。"
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei3", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan16", "zui2"});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/zhenjing_shuaidaoganjue.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan10", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(1734); // "{size=+10}你知道的啊。{/size}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan16", "zui2"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan24", "zui8", "emoji2", "emoji6"});
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui8", "emoji2", "emoji6"});
            yield return _gameMethods.OpenDialog(1735); // "我不明白。难道这是因为物种的不同……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui7", "emoji2", "emoji6"});
            yield return _gameMethods.OpenDialog(1736); // "就像人类看到游动的鱼会觉得它开心，而不怀疑鱼只是在顺从天性。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan21", "zui7", "emoji2", "emoji6"});
            yield return _gameMethods.OpenDialog(1737); // "龙与人之间也同理对吧……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice7_16ccd528.ogg");
            yield return _gameMethods.OpenDialog(1738); // "……但是，现在你身处这里，无需再考虑位于人类社会中的声誉和名节。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan5", "zui15", "emoji2", "emoji6"});
            yield return _gameMethods.OpenDialog(1739); // "「更何况，我的魔力，尽管不能治疗，但阻断你的疼痛绰绰有余，{nw}{w=0.1}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(1740); // "毕竟你所说的物质也是可以消灭的对象。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan17", "zui21", "emoji0"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui15", "-emoji2", "-emoji6"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice7_85db7475.ogg");
            yield return _gameMethods.OpenDialog(1741); // "所以，我不明白这到底还有什么隐藏的必要。"
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan17", "zui3", "emoji0"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan22", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(1742); // "{size=+10}你是有多介意自己受到隐瞒这点啊。{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan1", "zui2", "emoji2", "emoji5", "emoji6"});
            yield return _gameMethods.OpenDialog(1743); // "/n至于吗？{/size}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan17", "zui3", "emoji0"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan11", "zui7", "emoji2", "-emoji5", "emoji6"});
            yield return _gameMethods.OpenDialog(1222); // "「……"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan11", "zui19", "emoji2", "emoji6"});
            yield return _gameMethods.OpenDialog(1744); // "那个，不光是出于实际影响的考虑，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan5", "zui19", "emoji2", "emoji6"});
            yield return _gameMethods.OpenDialog(1745); // "人类还有一种东西，叫个人隐私。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan19", "zui2", "-emoji0"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan5", "zui7", "emoji2", "-emoji6"});
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1746); // "他无动于衷地看着我，似乎在等我解释。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", -42f}, {"zpos", 162.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.60f}, {"xpos", -42f}, {"zpos", 204.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan20", "zui8", "emoji2"});
            yield return _gameMethods.OpenDialog(1747); // "好吧。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", -42f}, {"zpos", 204.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10", "-emoji2"});
            yield return _gameMethods.OpenDialog(1748); // "你知道《旧日寓言》中的故事吧？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan3", "zui10"});
            yield return _gameMethods.OpenDialog(1749); // "曾经有只夜莺向猫头鹰倾诉了自己的心事，以为它会为自己保密。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan8", "zui10"});
            yield return _gameMethods.OpenDialog(1750); // "「但猫头鹰承受不住压力，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui9"});
            yield return _gameMethods.OpenDialog(1751); // "将秘密说了出去，结果害夜莺被猎人捉住，后悔不已。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan9", "zui10"});
            yield return _gameMethods.OpenDialog(1752); // "人总有些不愿他人知道或干预的事情。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui9"});
            yield return _gameMethods.OpenDialog(1753); // "即便有些事情并不重要，但让他人知道本身就有可能造成负面的影响。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan9", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(1754); // "……也就是说，如果我贸然干预你的头痛，这同样会使你承受刺激。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan28", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1755); // "他思考着把手指放到唇边。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(1756); // "我点头。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan9", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(1757); // "除了疼痛，这对于你而言同样是一种具备越界含义的行为。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan9", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan6", "zui15", "emoji12"});
            yield return _gameMethods.OpenDialog(1758); // "越界？"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10", "-emoji12"});
            yield return _gameMethods.OpenDialog(1759); // "……呃，或许。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan6", "zui10"});
            yield return _gameMethods.OpenDialog(1760); // "或许当事态发展到最糟糕的境地时，我会为了更重要的东西而割舍它。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui9"});
            yield return _gameMethods.OpenDialog(1761); // "「但在那之前，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan5", "zui10"});
            yield return _gameMethods.OpenDialog(1762); // "个人隐私仍然是对人意义重大的事物。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan15", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1679); // "他若有所思。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice7_e6461f1a.ogg");
            yield return _gameMethods.OpenDialog(1763); // "我记住了。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei3", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(1764); // "「……你记住了？"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei4", "yan5", "zui10", "emoji2"});
            yield return _gameMethods.OpenDialog(1765); // "以后不会再随便摸病人的头了对吗。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan16", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei4", "yan5", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan18", "zui14", "-emoji2"});
            yield return _gameMethods.OpenDialog(1766); // "他刚才是不是给了我一个白眼。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan10", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice7_f25647ac.ogg");
            yield return _gameMethods.OpenDialog(1767); // "我本来就不会随便这么做。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan10", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(1768); // "「好吧，现在你也知道了，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui10"});
            yield return _gameMethods.OpenDialog(1769); // "在不确定的偶尔几天里，从我头上传来痛苦的气息也是正常现象……」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice7_c6b5db53.ogg");
            yield return _gameMethods.OpenDialog(765); // "嗯。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/tangxia3_duanduan.mp3");
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui9"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 57.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.6f}, {"zpos", 3.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice7_433ae48a.ogg");
            yield return _gameMethods.OpenDialog(1770); // "「现在，给我布匹，{nw}{w=0.1}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice7_dd03fa7e.ogg");
            yield return _gameMethods.OpenDialog(1771); // "我会帮你附魔。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 3.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan5", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(1772); // "「……好的。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan24", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(1773); // "拜托你了，赫泽尔大人…… 」"
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:10f);
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition(time:1f);
            Defaults.Persistent.Jq_2_4 = 1;
            Defaults.Haogandu_an = Defaults.Haogandu_an + 1;
            yield return _gameMethods.OpenDialog(1774); // "就在这样的日子里，冬天的脚步逐渐到来。"
            yield return _gameMethods.PlaySound("soundb", 1f, 0.6f, "audio/sound/zhutang1.ogg");
            Engine._dismiss_pause = false;
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/woshi_nv2_tian.jpg");
            yield return _gameMethods.TransitionBy("blink1_1");
            Engine._dismiss_pause = true;
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:10f);
            yield return _gameMethods.OpenDialog(1775); // "……在城堡里，每天醒来，我都有些恍惚。"
            yield return _gameMethods.OpenDialog(491); // "………………"
            yield return _gameMethods.OpenDialog(481); // "……………………"
            yield return _gameMethods.PlaySound("sound", 0.7f, 0.2f, "audio/demo_audio/sound/moca6_duan_duan.mp3");
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.TransitionBy("blink4_1");
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.PlaySound("soundb", 3f, 1.0f, "audio/sound/huiyi_winter/Howling Wind_01.ogg");
            yield return _gameMethods.OpenDialog(1776); // "尤记得以前的每个冬日，起床都仿佛一种折磨。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/memory_4/memory4_1.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/cg/memory_4/memory4_1.jpg");
            yield return _gameMethods.Scene("memory4_1_ani", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.1f}, {"xalign", 0.5f}, {"yalign", 0.5f}})});
            Defaults.Gui_duihuakuang_you = 0;
            yield return _gameMethods.Show("snow_white2");
            yield return _gameMethods.Transition(time:0.7f);
            yield return _gameMethods.PlaySound("soundc", 2f, 1.0f, "audio/sound/huiyi_winter/Footsteps Walking on Soft Snow_01.ogg");
            yield return _gameMethods.PlaySound("soundd", 2f, 3f, "audio/sound/huiyi_winter/Shaking water_01.ogg");
            yield return _gameMethods.OpenDialog(1777); // "在我的印象中，冬天，表现为脸颊刮伤般寒冷的刺痛，手脚上的冻疮，钻进骨头里的阴冷，和永远僵硬着耸肩缩颈、瑟缩成团的身体。"
            yield return _gameMethods.OpenDialog(1778); // "柴火似乎总是不够用。"
            yield return _gameMethods.OpenDialog(1779); // "白天，为了蹭壁炉，我会去济贫院，跟着济贫院所组织的妇女人群，做一些类似于削土豆、缝补丁之类的活计。"
            yield return _gameMethods.StopSound(channelName:"soundc", fadeOut:2f);
            yield return _gameMethods.StopSound(channelName:"soundd", fadeOut:2f);
            yield return _gameMethods.EngineSetVolume(volume:0.2f, delay:2f, channelName:"soundb");
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/memory_4/memory4_2.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1f}})});
            yield return _gameMethods.PlaySound("sound", 0.0f, 3f, "audio/sound/huiyi_winter/Wooden Door Closing_01.ogg");
            yield return _gameMethods.PlaySound("sounda", 0.0f, 0.7f, "<silence 0.8>", "audio/sound/huiyi_winter/Sneezing_01.ogg");
            yield return _gameMethods.OpenDialog(1780); // "但回到家后，我不舍得独自点壁炉取暖，只能硬撑。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/memory_4/memory4_2.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/memory_4/memory4_3.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1f}})});
            yield return _gameMethods.PlaySound("sounda1", 0.0f, 1.0f, "audio/sound/huiyi_winter/Rubbing Hands_01.mp3");
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.EngineSetVolume(volume:0.4f, delay:1f, channelName:"soundb");
            yield return _gameMethods.PlaySound("sounda3", 0.0f, 0.6f, "audio/sound/door_open_1.mp3");
            yield return _gameMethods.PlaySound("sounda2", 0.0f, 2f, "<silence 0.8>", "audio/sound/huiyi_winter/FireWood_01.ogg");
            yield return _gameMethods.Hide("memory4_1_ani");
            yield return _gameMethods.Hide("snow_white2");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/cg/memory_4/memory4_2.jpg");
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/memory_4/memory4_3.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/memory_4/memory4_4.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.5f, "audio/sound/stool_drag1.mp3");
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.5f, "<silence 1>", "<from 0 to 1.2>audio/sound/run1.ogg");
            yield return _gameMethods.OpenDialog(1781); // "每晚，妈妈带着用按周结算的工钱购买的新木柴回来。"
            yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/music/One_spring_day.mp3");
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:2f);
            yield return _gameMethods.PlaySound("sounda", 0.0f, 2f, "audio/sound/houhui/Body3 _01.mp3");
            yield return _gameMethods.PlaySound("sounda1", 0.0f, 0.6f, "audio/sound/huiyi_winter/Crystal Treasure Pick Up_01.ogg");
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/memory_4/memory4_4.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/memory_4/memory4_5.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.OpenDialog(491); // "………………"
            yield return _gameMethods.OpenDialog(1782); // "我们会快速吃完晚饭，早早地上床。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.5f, "audio/sound/manbu/Body1_01.mp3");
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/memory_4/memory4_6.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(1783); // "进被窝后，我才敢小心翼翼地舒展开身体，像鼯鼠一样贴在母亲柔软的身体上。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/memory_4/memory4_6.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(1784); // "我们用体温互相取暖。"
            yield return _gameMethods.PlaySound("soundb", 1f, 1.0f, "audio/demo_audio/sound/chong1.ogg");
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/memory_4/memory4_7.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.8f}, {"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(1785); // "每个夜晚，我依偎在母亲身边，汲取着她周身的一点暖意，陷入安眠。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/memory_4/memory4_7.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:4f);
            yield return _gameMethods.Scene("Assets/RenpyResources/images/cg/memory_4/memory4_8.jpg");
            yield return _gameMethods.TransitionBy("blink2_1");
            yield return _gameMethods.PlaySound("sound", 0.0f, 2.5f, "<silence 0.5>", "audio/sound/manbu/Body2_01.mp3");
            yield return _gameMethods.OpenDialog(1786); // "而在天不亮时，我就会感受到母亲起床的动静。"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 0.8f, "audio/sound/huiyi_winter/Wooden Floorboard Squeaks Cracking_01.ogg");
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/memory_4/memory4_9.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(1787); // "她尽量做到了轻手轻脚，但我还是会在粘稠的睡意、木头床板的吱呀抖动，和钻进被子的冷气中感受到她的离去。"
            yield return _gameMethods.PlaySound("sounda1", 0.0f, 2f, "audio/sound/huiyi_winter/FootSteps Far_01.mp3");
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/memory_4/memory4_9.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/memory_4/memory4_10.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(586); // ""
            yield return _gameMethods.PlaySound("sounda2", 0.0f, 1.0f, "audio/sound/huiyi_winter/Wooden Door Closing_01.ogg");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/cg/memory_4/memory4_11.jpg");
            yield return _gameMethods.Show("rain_1");
            
            yield return _gameMethods.PlaySound("soundb", 0.3f, 3.5f, "audio/demo_audio/sound/yu1.ogg");
            yield return _gameMethods.PlaySound("sounda2", 0.0f, 0.4f, "<silence 0.8>", "audio/sound/huiyi_winter/Female Voice Reaction Child Crying Sobbing _01.ogg");
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.OpenDialog(1788); // "……母亲去世后，"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/houhui/Body3 _01.mp3");
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/memory_4/memory4_11.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/memory_4/memory4_12.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.8f}, {"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(1789); // "那张床上夜晚就只剩下了我一人。"
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:5f);
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/memory_4/memory4_12.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(1790); // "冬夜很冷。我经常手脚冰冷，直到睡去的前一刻都没能捂热指尖。"
            yield return _gameMethods.OpenDialog(1791); // "即便捂热，手脚上生了冻疮的地方也会钻心的痒。"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/huiyi_winter/Scratching Skin_01.mp3");
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/memory_4/memory4_14_1.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/cg/memory_4/memory4_14_1.jpg");
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/memory_4/memory4_14.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}, {"pos", new Vector2(198f, 126f)}, {"zoom", 0.7f}}), new SameLineParamData(new Dictionary<string, object>{{"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.0f, saturationMatrix:1.0f, brightnessMatrix:-0.8f, hueMatrix:0.0f)}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.0f, saturationMatrix:1.0f, brightnessMatrix:-0.15f, hueMatrix:0.0f)}})});
            yield return _gameMethods.OpenDialog(1792); // "曾有几次，我忍不住把冻疮挠破了，被妈妈看到。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/houhui/Grab Hand_01.mp3");
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/memory_4/memory4_14.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.0f, saturationMatrix:1.0f, brightnessMatrix:-0.15f, hueMatrix:0.0f)}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/memory_4/memory4_15.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}, {"pos", new Vector2(198f, 126f)}, {"zoom", 0.7f}}), new SameLineParamData(new Dictionary<string, object>{{"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.0f, saturationMatrix:1.0f, brightnessMatrix:-0.15f, hueMatrix:0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/memory_4/memory4_15_1.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/cg/memory_4/memory4_15_1.jpg");
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/memory_4/memory4_16_1.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/cg/memory_4/memory4_16_1.jpg");
            yield return _gameMethods.PlaySound("sounda1", 0.0f, 0.4f, "audio/sound/houhui/Body3 _01.mp3");
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/memory_4/memory4_15.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/memory_4/memory4_16.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}, {"pos", new Vector2(198f, 126f)}, {"zoom", 0.7f}}), new SameLineParamData(new Dictionary<string, object>{{"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.0f, saturationMatrix:1.0f, brightnessMatrix:-0.15f, hueMatrix:0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(1793); // "她没有骂我，只是抱住我一声不吭地掉眼泪。"
            yield return _gameMethods.OpenDialog(1794); // "从此我再也不敢碰自己的疮肿了。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/memory_4/memory4_16.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(1795); // "……可现在，妈妈已经再也不会出现、不会再抱住我流泪了。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/memory_4/memory4_12.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/memory_4/memory4_13.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.Transition(time:0.5f);
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.PlaySound("soundb", 0.0f, 0.7f, "audio/demo_audio/sound/niaoming.ogg");
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/memory_4/memory4_18.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(1796); // "每次醒来，我都感觉仿佛一整个冬天的冰雪都压在了被子外面。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/memory_4/memory4_18.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(1797); // "真想闭上眼睛，永远沉睡过去。"
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:3f);
            yield return _gameMethods.OpenDialog(1798); // "这个世界太过寒冷，令人疲惫，也让人不想面对。"
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/memory_4/memory4_17.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(1799); // "……我再次合上双眼"
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.Transition(time:0.5f);
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.PlaySound("soundb", 0.0f, 2f, "audio/demo_audio/sound/niaoming.ogg");
            yield return _gameMethods.PlaySound("sound", 0.0f, 2f, "audio/sound/huiyi_winter/Knocking on A Wooden Door Glass Rattling _01.ogg");
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/memory_4/memory4_19.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(1800); // "接着，就被巨大的声响吵醒了。"
            yield return _gameMethods.OpenDialog(1801); // "那是以送早饭的名义，来喊我起床的安德鲁。"
            yield return _gameMethods.PlaySound("sounda1", 0.0f, 3f, "audio/sound/manbu/Body1_02_duan.mp3");
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/memory_4/memory4_19.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/memory_4/memory4_20.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(1802); // "他总会使劲敲着我的门，用响亮的嗓音大喊我的名字。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/memory_4/memory4_20.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(1803); // "如果我不想因赖床而在街坊中出名，就必须下床给他开门。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1>audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.PlaySound("sounda3", 0.0f, 0.6f, "<silence 0.5>", "audio/sound/door_open_1.mp3");
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.Transition(time:0.6f);
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:3f);
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:3f);
            yield return _gameMethods.PlaySound("sounda", 0.4f, 0.6f, "audio/sound/emeng_dajie/Town Moring_01.ogg");
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/memory_4/memory4_21.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(491); // "………………"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/emeng_dajie/Body_up_01.mp3");
            yield return _gameMethods.PlaySound("sounda3", 0.0f, 1.0f, "<silence 1>", "<from 0 to 1>audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.StopSound(channelName:"sounda", fadeOut:2f);
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/woshi_nv2.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.19f, 1.38f)}, {"anchor", new Vector2(0.5f, 1.0f)}})});
            Defaults.Gui_duihuakuang_you = 1;
            yield return _gameMethods.TransitionBy("blink2");
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(1804); // "而在赫泽尔的城堡里，一整个冬天，我都得以蹲守在暖炉前，不知寒冷的滋味。"
            yield return _gameMethods.PlaySound("music1", 2f, 1.0f, "audio/demo_audio/music/richang1.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(1805); // "如果不考虑三年后的命运，这真是我度过的条件最好的一个冬季了。"
            yield return _gameMethods.PlaySound("soundb", 0.0f, 2f, "audio/demo_audio/sound/niaoming.ogg");
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/senlin3.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(1806); // "……渐渐的、我从窗户看到外面的森林重现绿意。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/senlin3.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(1807); // "冰河融化，春暖花开。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(1808); // "鸟鸣声再次出现。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15"});
            yield return _gameMethods.OpenDialog(1809); // "而同样的，伴随着时间流逝，我感觉到自己对赫泽尔的警惕心正在消解，{nw}{w=0.01}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan20", "zui15"});
            yield return _gameMethods.OpenDialog(1810); // "怀疑自己产生了类似斯德哥尔摩的症状。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(1811); // "这种变化让我感到……"
            yield return _gameMethods.OpenSelectMenu(talk: new List<string>{"-惬意", "-反感"}, jump: new List<string>{"label_zhuxian_1_menu_0_NC4LH3Fr", "label_zhuxian_1_menu_0_0atx99ew"}, condition: new List<string>{"NONE", "NONE"});
        }

        public IEnumerator label_choice8()
        {
            yield return _gameMethods.EngineSetVolume(volume:1f, delay:2f, channelName:"music1");
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1>audio/demo_audio/sound/zu3_nv_zou.ogg");
            yield return _gameMethods.Scene("black");
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan10", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 2.38f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.48f}, {"xoffset", 70f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.7f}, {"xoffset", 0f}, {"alpha", 1f}})});
            yield return _gameMethods.Transition(time:0.6f);
            Engine._history = false;
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(1823); // "这一天，在晚安分手前，赫泽尔停留了脚步。 "
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(1824); // "见他似是要说些什么，我也知趣地停下。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(1825); // "明天我会出门。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -2f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 2f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan25", "zui15"});
            yield return _gameMethods.OpenDialog(1826); // "……！？"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(1827); // "「咦，"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(1828); // "去做什么呀？」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice8_a3071615.ogg");
            yield return _gameMethods.OpenDialog(1829); // "回龙之谷。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan6", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice8_d996a10d.ogg");
            yield return _gameMethods.OpenDialog(1830); // "成年期之前，所有的龙都要定期每年回一次龙之谷，沐浴龙之泉。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(1506); // "……这样啊。"
            Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(1831); // "知道了，我会在家里乖乖等你的。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(461); // "…………"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(1832); // "「…嗯。{nw}{w=0.1}"
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.6f, "<from 0 to 0.5>audio/demo_audio/sound/zu3_nv_zou.ogg");
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.70f}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 12.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(1833); // "我会在后天中午回来。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 12.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(1834); // "啊，只要一天？这么快么。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(1835); // "所有成长期以前的龙都需要在龙之谷呆上至少一夜。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan24", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(1836); // "成长期以前……啊哈哈。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(1837); // "‘幼年期’这三个字其实不烫嘴的。"
            yield return _gameMethods.OpenSelectMenu(talk: new List<string>{"-那你早点回来哦", "-不用急着赶回来"}, jump: new List<string>{"label_zhuxian_1_menu_0_mUlXYAZU", "label_zhuxian_1_menu_0_SfrsndZZ"}, condition: new List<string>{"NONE", "NONE"});
        }

        public IEnumerator label_choice10()
        {
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -84.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice10_d7bd24c7.ogg");
            yield return _gameMethods.OpenDialog(1847); // "这里我的领地，不会有魔兽闯入。你可以放心。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui2"});
            yield return _gameMethods.OpenDialog(1848); // "哇，太好了！"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan28", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(1849); // "我条件反射一般地捧场夸奖道，同时，也的确放下了悬着的心。"
            yield return _gameMethods.PlaySound("soundb", 0.0f, 1.0f, "audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.Scene("heilong_dating_wan_kaideng_men", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.2f}, {"xalign", 0.5f}, {"yalign", 0.5f}})});
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan8", "zui8", "emoji9", "emoji10"});
            yield return _gameMethods.OpenDialog(1850); // "~~~"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan11", "zui8", "emoji9", "emoji10"});
            yield return _gameMethods.OpenDialog(1851); // "一想到明天就会迎来一天短暂的自由，我的心情就不可抑制地晴朗了起来。"
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:1f);
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1>audio/demo_audio/sound/zu3_nv_zou.ogg");
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan3", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.63f, 1.87f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.36f}, {"xoffset", 30f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.7f}, {"xoffset", 0f}, {"alpha", 1f}})});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan11", "zui8", "-emoji9", "-emoji10"});
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.PlaySound("sound", 0.4f, 0.5f, "audio/demo_audio/sound/moca2.mp3");
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan28", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"alpha", 1f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}, {"zpos", -84.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.39f}, {"xpos", 84f}, {"zpos", -162.0f}})});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
            yield return _gameMethods.OpenDialog(466); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(924); // "……？"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 84f}, {"zpos", -162.0f}})});
            yield return _gameMethods.OpenDialog(1852); // "见他在盯着我，我有点疑惑地回望过去。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan6", "zui16", "emoji2"});
            yield return _gameMethods.OpenDialog(1853); // "……难道是高兴的太明显了？{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(1854); // "我有点心虚地挂起笑容。"
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(478); // "……"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1>audio/demo_audio/sound/zu3_nv_zou.ogg");
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}, {"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 0f}, {"xoffset", 30f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1855); // "他却先一步收回视线，与我错开了目光，转过了身去。"
            yield return _gameMethods.Hide("he");
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui7", "-emoji2", "emoji12"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice10_58400ded.ogg");
            yield return _gameMethods.OpenDialog(1856); // "我回房间了。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19", "-emoji12", "emoji10"});
            yield return _gameMethods.OpenDialog(1857); // "好，晚安~"
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan5", "zui7", "-emoji10"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice10_b73af603.ogg");
            yield return _gameMethods.OpenDialog(1858); // "……晚安。"
            yield return _gameMethods.ChangeLabelTo("label_zhuxian_2");
        }
}