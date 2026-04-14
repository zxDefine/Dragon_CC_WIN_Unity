    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class wangzi : ILabelProvider
    {
        private GameMethods _gameMethods;

        public wangzi(GameMethods gameMethods)
        {
            _gameMethods = gameMethods;
        }

            public IEnumerator label_wangzi_1()
        {
            yield return _gameMethods.OpenSelectMenu(talk: new List<string>{"-查看", "-远离"}, jump: new List<string>{"label_wangzi_menu_0_SKSsp87i", "label_wangzi_menu_0_nEMsGra4"}, condition: new List<string>{"NONE", "NONE"});
        }

        public IEnumerator label_zhuxian4_5()
        {
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<from 0.5 to 1.5>audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -114.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 2f}, {"zpos", -270.0f}})});
            Engine._history = false;
            yield return _gameMethods.OpenDialog(4152); // "{nw}{w=1}"
            Engine._history = true;
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0.5 to 1.5>audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg49_memory.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg49_memory.jpg");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/cave2.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.0f)}, {"zoom", 0.73f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition(time:0.5f);
            yield return _gameMethods.PlaySound("sounda5", 0.0f, 6f, "audio/sound/he/rocks3.ogg");
            yield return _gameMethods.OpenDialog(4153); // "我谨慎进入山洞，用石壁遮挡住自己的身影，小心翼翼地朝着内部窥探而去。"
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:3f);
            yield return _gameMethods.OpenDialog(4154); // "一个人影正靠坐在洞内的墙角，虚弱地喘息着。"
            yield return _gameMethods.OpenDialog(4155); // "那是一名人类男性，通体服饰华贵。"
            yield return _gameMethods.PlaySound("sounda1", 0.0f, 0.5f, "audio/sound/emeng_dajie/Magic Spell Book Pages Flipping_01.ogg");
            yield return _gameMethods.OpenDialog(4156); // "……更令我震惊的是，我认识他。"
            yield return _gameMethods.OpenDialog(4157); // "那双星状瞳孔的黄金瞳，昭示了他的身份——这个国家的王子。"
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.PlaySound("music1", 0.0f, 1.0f, "audio/demo_audio/music/youshang2.mp3");
            yield return _gameMethods.Transition(time:0.5f);
            yield return _gameMethods.OpenDialog(4158); // "他名为菲珀斯。"
            yield return _gameMethods.OpenDialog(4159); // "这是人类古老传说中的太阳的名讳。"
            yield return _gameMethods.OpenDialog(4160); // "他身上所承载的期望与宠爱之重，可见一斑。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/texiao/huiyi_biankuang.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"zpos", 0.0f}, {"anchor", new Vector2(0f, 0f)}, {"zoom", 1f}})});
            yield return _gameMethods.PlaySound("soundb", 3f, 1.0f, "audio/sound/huiyi_winter/Howling Wind_01.ogg");
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4161); // "这不是我和王子的第一次见面。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg46_memory.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg46_memory.jpg");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/dajie7_1.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.0f)}, {"zoom", 0.69f}})});
            yield return _gameMethods.Show("snow_white2");
            yield return _gameMethods.Transition(time:0.7f);
            yield return _gameMethods.OpenDialog(4162); // "实际上，第一次知道王子，是在我和妈妈来到王都后迎来的第一个冬天。"
            yield return _gameMethods.OpenDialog(4163); // "那一年，恰好严冬凛冽，极其难熬。"
            yield return _gameMethods.OpenDialog(4164); // "我们立足未稳，经济拮据，生活十分窘迫。"
            yield return _gameMethods.OpenDialog(4165); // "就在困难之际，一个喜讯突然传遍了大街小巷——"
            yield return _gameMethods.OpenDialog(4166); // "那个冬天，我听说，整个王都所有居民的炉灶税都被免除了。"
            yield return _gameMethods.OpenDialog(4167); // "这是杂货店里那个唾沫横飞的老板说的，他妻子的表妹在王宫里当杂役女仆。"
            yield return _gameMethods.NvlClear();
            Defaults.Persistent.Nvl_tran = 0;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai_nvl");
            yield return _gameMethods.OpenDialog(4168); // "“免炉灶税”是八岁的小王子，在那一年，以自己三年不添置新衣、不庆贺生日为交换，向国王请求的生日礼物。"
            Defaults.Persistent.Nvl_tran = 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai_nvl");
            yield return _gameMethods.OpenDialog(4169); // "据说，那一晚，在王宫的晚宴舞会上，王子待人接物礼仪周到，行为举止滴水不漏，得到了全场的称赞。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai_nvl");
            yield return _gameMethods.OpenDialog(4170); // "哪怕被父王提问功课，也对答如流。/n国王心情大好。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai_nvl");
            yield return _gameMethods.OpenDialog(4171); // "于是当着群臣宾客们的面，上演起父慈子孝，询问王子，想要什么生日礼物。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai_nvl");
            yield return _gameMethods.OpenDialog(4172); // "王子谦卑地推拒了几次。/n国王却始终慷慨豪爽地坚持。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai_nvl");
            yield return _gameMethods.OpenDialog(4173); // "最终，王子拗不过他，只好开口。"
            yield return _gameMethods.NvlClear();
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai_nvl");
            yield return _gameMethods.OpenDialog(4174); // "请求减免王室直属领地下，所有农民一年的税收。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai_nvl");
            yield return _gameMethods.OpenDialog(4175); // "场面瞬间安静。/n国王脸色铁青。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai_nvl");
            yield return _gameMethods.OpenDialog(4176); // "毫无疑问，这样天真的要求被拒绝了。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai_nvl");
            yield return _gameMethods.OpenDialog(4177); // "但作为国王，既已夸下海口，倒也拉不下面子毫无表示。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai_nvl");
            yield return _gameMethods.OpenDialog(4178); // "最终，他免除了王都一城之内的炉灶税。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai_nvl");
            yield return _gameMethods.OpenDialog(4179); // "而大头税收——无论是人头税还是宗教税，都没有少一个子。"
            yield return _gameMethods.NvlClear();
            yield return _gameMethods.OpenDialog(4180); // "但这还是惠及了许多家庭。"
            yield return _gameMethods.OpenDialog(4181); // "得益于此，妈妈和我省下一笔钱，过了个还算温饱的冬季。"
            yield return _gameMethods.OpenDialog(4182); // "这是王子首次在我心中留下的印象。"
            yield return _gameMethods.OpenDialog(4183); // "在那之后。"
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:4f);
            yield return _gameMethods.Hide("Assets/RenpyResources/images/texiao/huiyi_biankuang.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}})});
            yield return _gameMethods.StopSound(channelName:"music1", fadeOut:3f);
            yield return _gameMethods.Transition(time:0.5f);
            yield return _gameMethods.OpenDialog(4184); // "有一次，我们真正地偶然相遇了。"
            yield return _gameMethods.PlaySound("music", 2f, 1.0f, "audio/music/wangzi/PeriTune_Village_Fete_loop.mp3");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg45_memory.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg45_memory.jpg");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/dajie8_1.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.18f)}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition(time:0.7f);
            yield return _gameMethods.OpenDialog(4185); // "大概在八年以后，我十四岁时。"
            yield return _gameMethods.OpenDialog(4186); // "那天正好是国家的建国庆典日。"
            yield return _gameMethods.OpenDialog(4187); // "每年的这一天，国家都会举行阅兵仪式。"
            yield return _gameMethods.OpenDialog(4188); // "王室骑着高头大马，带领士兵列队，在王城中游行一圈。"
            yield return _gameMethods.OpenDialog(4189); // "这样的日子，自然也得到了我的重视。"
            yield return _gameMethods.OpenDialog(4190); // "我会提前一两天占据游行路线中的有利位置，在人群中兜售面包、糕点和三明治，趁机赚一笔。"
            yield return _gameMethods.PlaySound("soundc", 1f, 1.0f, "audio/sound/manbu/Gentle Breeze Blowing Foliage Rustling_01.ogg");
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:5f);
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/dajie8_2.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.18f)}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.7f}, {"alpha", 1f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 1.5f}, {"ypos", -162f}})});
            yield return _gameMethods.OpenDialog(4191); // "那一天，日暮时分。"
            yield return _gameMethods.OpenDialog(4192); // "游行早已结束，人们已经稀稀落落散去。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.8f, "<from 0 to 2>audio/sound/he/crow1.mp3");
            yield return _gameMethods.OpenDialog(4193); // "倦鸟归巢，天空被夕阳染成一片昏黄。"
            yield return _gameMethods.StopSound(channelName:"soundc", fadeOut:4f);
            yield return _gameMethods.PlaySound("music1", 0.0f, 1.0f, "audio/demo_audio/music/richang1.mp3");
            yield return _gameMethods.PlaySound("soundb", 0.0f, 1.0f, "audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg44_memory.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg44_memory.jpg");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/dajie9.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.37f, 1.17f)}, {"zoom", 1.07f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            yield return _gameMethods.OpenDialog(4194); // "回家途中，我在河边那排民居前的小道上，看见了两个人影。"
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:1f);
            yield return _gameMethods.Show("Assets/RenpyResources/images/lihui/npc/npc_nanhai_1.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(420f, 798f)}, {"zoom", 0.56f}, {"anchor", new Vector2(0.5f, 1.0f)}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.ExecuteCharacterImageData("y");
            yield return _gameMethods.OpenDialog(4195); // "呜呜呜哇哇……！！！"
            yield return _gameMethods.ExecuteCharacterImageData("y");
            yield return _gameMethods.OpenDialog(4196); // "你还我的草青蛙，还我的草青蛙！"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan9", "zui7", "emoji1", "emoji2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.6f, 1.81f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.30f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.ExecuteCharacterImageData("z");
            yield return _gameMethods.OpenDialog(4197); // "抱歉，我并不擅编织。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan9", "zui3", "emoji1", "emoji2"});
            yield return _gameMethods.ExecuteCharacterImageData("y");
            yield return _gameMethods.OpenDialog(4198); // "呜呜呜呜……！"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan12", "zui3", "emoji1", "emoji2"});
            yield return _gameMethods.ExecuteCharacterImageData("z_qian");
            yield return _gameMethods.OpenDialog(4199); // "「……"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui35", "emoji1", "emoji2"});
            yield return _gameMethods.ExecuteCharacterImageData("z_qian");
            yield return _gameMethods.OpenDialog(4200); // "如果你不介意，{nw}{w=0.2}"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan19", "zui9", "-emoji1", "-emoji2"});
            yield return _gameMethods.ExecuteCharacterImageData("z_qian");
            yield return _gameMethods.OpenDialog(4201); // "请容我以此作为赔偿。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan13", "zui10"});
            yield return _gameMethods.ExecuteCharacterImageData("z_qian");
            yield return _gameMethods.OpenDialog(4202); // "你可以用它购买一只新的草编…{nw}{w=0.3}"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan15", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("z_qian");
            yield return _gameMethods.OpenDialog(4203); // "嗯、{nw}{w=0.3}"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan2", "zui12"});
            yield return _gameMethods.ExecuteCharacterImageData("z_qian");
            yield return _gameMethods.OpenDialog(4204); // "青蛙。」"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan13", "zui13"});
            yield return _gameMethods.OpenDialog(4205); // "说话的男生似乎对那个词语不甚熟悉，言及此时，话语卡壳了一下。"
            yield return _gameMethods.ExecuteCharacterImageData("y");
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.PlaySound("sounda1", 0.0f, 0.4f, "audio/sound/moca1.ogg");
            yield return _gameMethods.Show("Assets/RenpyResources/images/lihui/npc/npc_nanhai_1.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"xoffset", -3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("y");
            yield return _gameMethods.OpenDialog(4206); // "这什么破玩意儿！"
            yield return _gameMethods.Show("Assets/RenpyResources/images/lihui/npc/npc_nanhai_1.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei1", "yan5", "zui3", "emoji2"});
            yield return _gameMethods.ExecuteCharacterImageData("y");
            yield return _gameMethods.OpenDialog(4207); // "呜呜呜呜！！我要，嗝，我的…青蛙！"
            yield return _gameMethods.ExecuteCharacterImageData("y");
            yield return _gameMethods.OpenDialog(4208); // "呜呜呜哇哇哇！"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<from 0.3 to 0.5>audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 1f}, {"zpos", -30f}})});
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei3", "yan21", "zui3", "-emoji2"});
            yield return _gameMethods.OpenDialog(4209); // "我好奇地探头，想瞧瞧那个被孩子嫌弃为“破玩意儿”的东西是什么。"
            yield return _gameMethods.OpenDialog(4210); // "定睛一看——"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -30f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/daoju/qianbi.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(642f, 570f)}, {"zoom", 0.42f}, {"anchor", new Vector2(0.5f, 1.0f)}})});
            yield return _gameMethods.Show("wangzi", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 5f}})});
            yield return _gameMethods.Show("npc_nanhai_1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 5f}})});
            yield return _gameMethods.Show("dajie9", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 5f}})});
            yield return _gameMethods.Transition(time:0.5f);
            yield return _gameMethods.OpenDialog(4211); // "那是一枚标准制金币。"
            yield return _gameMethods.OpenDialog(4212); // "币面上还印着开国君主波洛卡一世那经过美化的头像。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei3", "yan2", "zui3"});
            Engine._history = false;
            yield return _gameMethods.OpenDialog(4213); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei3", "yan21", "zui3"});
            yield return _gameMethods.OpenDialog(4214); // "依照市面价格，它能换到五百磅面包，或四十只鸡，或十头羊，或一匹劣马。"
            yield return _gameMethods.OpenDialog(4215); // "……我陷入迷茫。"
            yield return _gameMethods.OpenDialog(4216); // "我努力思考。"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/demo_audio/sound/ding1.mp3");
            yield return _gameMethods.OpenDialog(4217); // "我恍然大悟。"
            yield return _gameMethods.OpenDialog(4218); // "确实，在这个时代，平民家里基本都没有余钱。"
            yield return _gameMethods.OpenDialog(4219); // "粮食和牲口是最常见的硬通货。乡镇的平民之间，普遍存在以物易物的现象，不少工资也会以实物的形式发放。"
            yield return _gameMethods.OpenDialog(4220); // "孩子没有零花钱，根本接触不到货币，自然也就对钱不太熟悉。"
            yield return _gameMethods.Hide("Assets/RenpyResources/images/daoju/qianbi.png");
            yield return _gameMethods.Show("wangzi", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Show("npc_nanhai_1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Show("dajie9", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition(time:0.5f);
            yield return _gameMethods.OpenDialog(4221); // "……不过就算不认识金币，孩子一般也会本能性地喜欢这种亮晶晶、金光闪闪的精致物件吧。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}, {"zpos", -30f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.7f}, {"xpos", -60f}, {"zpos", -66f}})});
            yield return _gameMethods.StopSound(channelName:"music1", fadeOut:5f);
            yield return _gameMethods.OpenDialog(4222); // "这孩子、小小年纪，竟展现出如此贫贱不能移的气魄……日后必成大器。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei3", "yan2", "zui3"});
            Engine._history = false;
            yield return _gameMethods.OpenDialog(4213); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei3", "yan21", "zui3"});
            yield return _gameMethods.OpenDialog(4223); // "对着满脸鼻涕眼泪的男孩，那名温和贵气的少年似乎颇为为难。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", -60f}, {"zpos", -66f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.7f}, {"xpos", -12f}})});
            yield return _gameMethods.OpenDialog(4224); // "真难得，作为一名贵族，这个少年的道德素质显然有些太多了。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.Show("wangzi", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 2f}, {"blur", 4f}})});
            yield return _gameMethods.Show("npc_nanhai_1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 2f}, {"blur", 4f}})});
            yield return _gameMethods.Show("dajie9", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 2f}, {"blur", 4f}})});
            yield return _gameMethods.OpenDialog(4225); // "我想了想，默默从河边的芦苇丛中揪了根油亮漂亮的芦苇叶。"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 0.6f, "audio/demo_audio/sound/sibuliao2.mp3");
            yield return _gameMethods.OpenDialog(4226); // "将叶片折叠、穿插，没一会儿，{nw}{w=0.01}"
            yield return _gameMethods.PlaySound("music2", 0.0f, 1.0f, "audio/music/wangzi/PerituneMaterial_Scéal_Réalta_inst_loop.mp3");
            yield return _gameMethods.Show("Assets/RenpyResources/images/daoju/xiaowa.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}, {"pos", new Vector2(468f, 192f)}, {"anchor", new Vector2(0f, 0f)}, {"zoom", 0.3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4227); // "一只翠绿的草青蛙出现在我手中。"
            yield return _gameMethods.Show("wangzi", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 4f}})});
            yield return _gameMethods.Show("npc_nanhai_1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 4f}})});
            yield return _gameMethods.Show("dajie9", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 4f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/daoju/xiaowa.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.OpenDialog(4228); // "小时候，妈妈也用这种小玩意哄过我呢。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0.5 to 1.5>audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/daoju/xiaowa.png");
            yield return _gameMethods.Show("wangzi", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 2f}, {"blur", 0f}})});
            yield return _gameMethods.Show("npc_nanhai_1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 2f}, {"blur", 0f}})});
            yield return _gameMethods.Show("dajie9", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 2f}, {"blur", 0f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-12f, 0f)}, {"zpos", -66f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.71f}, {"pos", new Vector2(-192f, 78f)}, {"zpos", -252f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(4229); // "……我走上前去，来到两人旁边，向那名孩子递出了手里的草编小动物。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 2f, "audio/sound/manbu/Body1_02_duan.mp3");
            yield return _gameMethods.Show("Assets/RenpyResources/images/daoju/xiaowa.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.36f, 0.92f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.11f}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 40f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"yoffset", 0f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4230); // "给你。"
            yield return _gameMethods.Hide("Assets/RenpyResources/images/lihui/npc/npc_nanhai_1.png");
            yield return _gameMethods.Show("Assets/RenpyResources/images/lihui/npc/npc_nanhai_2.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(420f, 798f)}, {"zoom", 0.56f}, {"anchor", new Vector2(0.5f, 1.0f)}})});
            yield return _gameMethods.Hide("Assets/RenpyResources/images/daoju/xiaowa.png");
            yield return _gameMethods.Show("Assets/RenpyResources/images/daoju/xiaowa.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.36f, 0.92f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.11f}})});
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan5", "zui3"});
            yield return _gameMethods.Transition();
            yield return _gameMethods.ExecuteCharacterImageData("y");
            yield return _gameMethods.OpenDialog(4231); // "……？"
            yield return _gameMethods.Hide("Assets/RenpyResources/images/lihui/npc/npc_nanhai_2.png");
            yield return _gameMethods.Show("Assets/RenpyResources/images/lihui/npc/npc_nanhai_3.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(420f, 798f)}, {"zoom", 0.56f}, {"anchor", new Vector2(0.5f, 1.0f)}})});
            yield return _gameMethods.Hide("Assets/RenpyResources/images/daoju/xiaowa.png");
            yield return _gameMethods.Show("Assets/RenpyResources/images/daoju/xiaowa.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.36f, 0.92f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.11f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.ExecuteCharacterImageData("y");
            yield return _gameMethods.OpenDialog(4232); // "啊！！"
            yield return _gameMethods.Show("Assets/RenpyResources/images/daoju/xiaowa.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-192f, 78f)}, {"zpos", -252f}})});
            yield return _gameMethods.Show("wangzi", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Show("dajie9", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.OpenDialog(4233); // "孩子破涕为笑，{nw}{w=0.01}"
            yield return _gameMethods.Show("Assets/RenpyResources/images/daoju/xiaowa.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("y");
            yield return _gameMethods.OpenDialog(4234); // "一把抓过去，边左右端详着草编青蛙，边从鼻孔里冒出一个美滋滋的鼻涕泡。"
            yield return _gameMethods.OpenDialog(4235); // "我放心了。"
            yield return _gameMethods.Hide("Assets/RenpyResources/images/daoju/xiaowa.png");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-192f, 78f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.62f}, {"pos", new Vector2(-126f, 30f)}})});
            yield return _gameMethods.OpenDialog(4236); // "抬起头，我发现对面的银发少年此时将目光投到了我的身上。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan2", "zui3"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("bb_qian");
            yield return _gameMethods.OpenDialog(4213); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan5", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("bb");
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-126f, 30f)}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", -126f}, {"zpos", -252f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.49f}, {"xpos", -72f}, {"zpos", -270f}})});
            yield return _gameMethods.PlaySound("sounda1", 0.0f, 1.0f, "audio/sound/houhui/Grab Hand_01.mp3");
            yield return _gameMethods.OpenDialog(4237); // "我对他礼貌地笑了一笑，飞快地从他掌心拿走金币，{nw}{w=0.01}"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 0.5f, "audio/sound/houhui/Body3 _01.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(-222f, 132f)}, {"zpos", -360.0f}})});
            yield return _gameMethods.Transition(time:0.5f);
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4238); // "塞到男孩的手里。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4239); // "把这个也拿着吧。"
            yield return _gameMethods.OpenDialog(4240); // "我对男孩嘱咐。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4241); // "带回去给你的爸爸妈妈，他们会用这个给你买肉吃的。"
            yield return _gameMethods.OpenDialog(4242); // "孩子还在长身体，能吃就得多吃肉。"
            yield return _gameMethods.OpenDialog(4243); // "这位小男孩的父母、亲朋、兄弟姐妹们……大家不用感谢我。"
            yield return _gameMethods.OpenDialog(4244); // "我的名字就叫做——互帮互助的普通人。"
            yield return _gameMethods.ExecuteCharacterImageData("y_qian");
            yield return _gameMethods.OpenDialog(4245); // "「肉，{nw}{w=0.2}"
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/moca1.ogg");
            yield return _gameMethods.Show("Assets/RenpyResources/images/lihui/npc/npc_nanhai_3.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"xoffset", -3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("y_qian");
            yield return _gameMethods.OpenDialog(4246); // "真的吗？！」"
            yield return _gameMethods.Show("Assets/RenpyResources/images/lihui/npc/npc_nanhai_3.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4247); // "嗯，所以千万别弄丢了。"
            yield return _gameMethods.OpenDialog(4248); // "男孩抹了把鼻涕，把它均匀地涂了一脸，用力点点头，带着欢乐的傻笑，{nw}{w=0.01}"
            yield return _gameMethods.Show("Assets/RenpyResources/images/lihui/npc/npc_nanhai_3.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"alpha", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4249); // "扭头就跑了。"
            yield return _gameMethods.OpenDialog(4250); // "我望着他的背影。"
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/dajie9.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.02f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.71f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition(time:0.5f);
            yield return _gameMethods.OpenDialog(4251); // "他小小的身影越跑越远，隐没在夕阳橘黄的余晖下。"
            yield return _gameMethods.OpenDialog(4252); // "他会带给家人一个喜讯，一个惊喜交加、欢乐幸福的夜晚吗？"
            yield return _gameMethods.EngineSetVolume(volume:0.2f, delay:0.7f, channelName:"music2");
            yield return _gameMethods.ExecuteCharacterImageData("bb_1");
            yield return _gameMethods.OpenDialog(4253); // "……真厉害呢，你。"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 2f, "audio/sound/emeng_dajie/Swing Whoosh_01.mp3");
            yield return _gameMethods.OpenDialog(4254); // "一道声音把我的意识唤了回来。"
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/dajie9.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.3f, 1.05f)}, {"anchor", new Vector2(0.5f, 1.0f)}})});
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui13"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.49f, 2.38f)}, {"zoom", 0.42f}})});
            yield return _gameMethods.Transition(time:0.5f);
            yield return _gameMethods.EngineSetVolume(volume:1f, delay:0.5f, channelName:"music2");
            yield return _gameMethods.OpenDialog(4255); // "我转回头。"
            yield return _gameMethods.OpenDialog(4256); // "那名银发少年不知何时已走到了我的身侧，{nw}{w=0.2}"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan15", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_1");
            yield return _gameMethods.OpenDialog(4257); // "也在望着街道尽头，那个男孩奔跑消失的背影。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4258); // "？"
            yield return _gameMethods.OpenDialog(4259); // "难道他对我有意见？我有些心虚。 "
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan9", "zui10"});
            yield return _gameMethods.ExecuteCharacterImageData("bb");
            yield return _gameMethods.OpenDialog(4260); // "三两下就让那孩子破涕为笑了。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan9", "zui13"});
            yield return _gameMethods.OpenDialog(4261); // "残阳的余晖下，{nw}{w=0.2}"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan19", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("bb");
            yield return _gameMethods.OpenDialog(4262); // "少年那张年轻俊秀的脸上，浮现着些许阴郁与落寞。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan19", "zui13"});
            yield return _gameMethods.PlaySound("soundb", 1f, 2f, "audio/sound/manbu/Gentle Breeze Blowing Foliage Rustling_01.ogg");
            yield return _gameMethods.OpenDialog(4263); // "阵风掠过，拂过他银色的发丝和嘴角的苦笑。"
            yield return _gameMethods.OpenDialog(4264); // "仔细辨别了一番他的神态和语气，我确定这不是讽刺，而是真心实意的称赞。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4265); // "啊……这不算什么啦。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan13", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4266); // "比我厉害的女孩大有人在。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan9", "zui3"});
            yield return _gameMethods.OpenDialog(4267); // "位于我这个阶层的女孩，大多从能落地走路起，便开始照顾家中弟妹。我只能算是将军里面挑瘸子。"
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:2f);
            yield return _gameMethods.StopSound(channelName:"music2", fadeOut:3f);
            yield return _gameMethods.PlaySound("sounda1", 0.0f, 0.5f, "audio/sound/emeng_dajie/Magic Spell Book Pages Flipping_01.ogg");
            yield return _gameMethods.OpenDialog(4268); // "嗯？"
            yield return _gameMethods.OpenDialog(4269); // "话说，这张脸……是不是有些眼熟？"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan2", "zui3"});
            Engine._history = false;
            yield return _gameMethods.OpenDialog(4213); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan9", "zui3"});
            yield return _gameMethods.OpenDialog(4270); // "似曾相识……仿佛就在最近，我见过这张脸。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.OpenDialog(4271); // "等等。{nw}{w=0.01}"
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/moca1.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -8f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 8f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4272); // "我想起来了……！"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
            yield return _gameMethods.OpenDialog(4273); // "虽然只是在今天上午远远望见过一眼，但我非常确信。这、这不就是——"
            yield return _gameMethods.OpenDialog(4274); // "今早还游行过的王子吗？！"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4275); // "……！"
            yield return _gameMethods.PlaySound("soundb", 3f, 3f, "audio/sound/manbu/Gentle Breeze Blowing Foliage Rustling_01.ogg");
            yield return _gameMethods.OpenDialog(4276); // "他好像换了一套衣服。王子在微服私访？"
            yield return _gameMethods.OpenDialog(4277); // "我一时惊讶，哑口无言。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan18", "zui13"});
            yield return _gameMethods.OpenDialog(4278); // "他还在苦笑着。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan22", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_2");
            yield return _gameMethods.OpenDialog(4279); // "……不。"
            yield return _gameMethods.ExecuteCharacterImageData("bb_2");
            yield return _gameMethods.OpenDialog(4280); // "很了不起啊。"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<from 0.3 to 0.5>audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.6f}, {"zpos", -24.0f}})});
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan22", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4281); // "什么？"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan2", "zui7"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_2_qian");
            yield return _gameMethods.OpenDialog(4282); // "「你刚刚说那“不算什么”，{nw}{w=0.01}"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan9", "zui6"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_2_qian");
            yield return _gameMethods.OpenDialog(4283); // "我不认同。」"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -24.0f}})});
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui10"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_2");
            yield return _gameMethods.OpenDialog(4284); // "因为你替我解了围。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan15", "zui10"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_2");
            yield return _gameMethods.OpenDialog(4285); // "刚才，我虽然拿着金币，却无计可施。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan15", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4286); // "可那枚金币从一开始就是你的啊。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan18", "zui9"});
            yield return _gameMethods.PlaySound("music2", 4f, 0.7f, "audio/music/wangzi/PerituneMaterial_Memories6_Piano_loop.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("bb_3_qian");
            yield return _gameMethods.OpenDialog(4287); // "「是吗、{nw}{w=0.3}"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan21", "zui10"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3_qian");
            yield return _gameMethods.OpenDialog(4288); // "是啊……{nw}{w=0.3}"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan2", "zui31"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3_qian");
            yield return _gameMethods.OpenDialog(4289); // "没错。」"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan9", "zui7"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4290); // "不过，拥有钱财，并不代表便有着与之相匹配的才能。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan13", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4291); // "很多时候，也并非单纯靠钱就能解决问题。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan22", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4292); // "更何况，这钱实际上也不算是我的。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan22", "zui13"});
            yield return _gameMethods.OpenDialog(4293); // "这人好矛盾。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3_qian");
            yield return _gameMethods.OpenDialog(4294); // "「……那个孩子说得对。{nw}{w=0.2}"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan16", "zui6"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3_qian");
            yield return _gameMethods.OpenDialog(4295); // "当金币比不上一个草编的青蛙更能带给他快乐时，」"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan2", "zui10"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4296); // "金钱就什么也不代表。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan16", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.PlaySound("sound", 0.2f, 0.4f, "audio/demo_audio/sound/moca2.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -24f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.39f}, {"zpos", 0f}})});
            yield return _gameMethods.OpenDialog(4297); // "太小众了，这个人居然痛恨金钱。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan18", "zui13"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}})});
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.OpenDialog(4298); // "难道是因为觉得彼此间的身份与生活没有交集吗。"
            yield return _gameMethods.OpenDialog(4299); // "对于我这个萍水相逢的路人，王子殿下意外地敞开了心扉啊。"
            yield return _gameMethods.OpenDialog(4300); // "说实话，他所倾吐这些话，在这十几年贫穷生活的映衬下，落在我的耳中，便显得有些曲高和寡。"
            yield return _gameMethods.OpenDialog(4301); // "但我想，这并非是出于“何不食肉糜”式的无知。"
            yield return _gameMethods.OpenDialog(4302); // "他大概有着私人的烦恼。"
            yield return _gameMethods.OpenDialog(4303); // "——是自我认同度太低？衣食富足，却不幸福？"
            yield return _gameMethods.OpenDialog(4304); // "我要对症下药。"
            yield return _gameMethods.OpenDialog(4305); // "因为我希望他的心情能好起来。"
            yield return _gameMethods.OpenDialog(4306); // "王子对我有些许恩惠。"
            yield return _gameMethods.OpenDialog(4307); // "那年冬天，在睡前的被窝里，我曾在心里默默地向这位素未谋面的小王子道了一句谢，祝他生日快乐。"
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:5f);
            yield return _gameMethods.StopSound(channelName:"music2", fadeOut:3f);
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.OpenDialog(4308); // "八年过去，原来当初那位善良的小王子也长大了。"
            yield return _gameMethods.PlaySound("music1", 0.0f, 1.0f, "audio/music/wangzi/maou_bgm_piano_song_ahurera.mp3");
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<from 0.3 to 0.5>audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.39f}, {"zpos", -24.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4309); // "……不是的。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan16", "zui3"});
            yield return _gameMethods.OpenDialog(4310); // "我斩钉截铁地开口说道。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -24.0f}})});
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan9", "zui3"});
            yield return _gameMethods.OpenDialog(4311); // "少年望向我，微感意外一般。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4312); // "这世上可能确实存在钱也买不来的幸福，"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4313); // "但却有着很多用钱就可以避免的不幸。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan2", "zui3"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv2_qian");
            yield return _gameMethods.OpenDialog(4213); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan9", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4314); // "你给孩子的那枚金币，"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4315); // "足够他们一家人整个冬天的日常花费和炭火钱了。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4316); // "虽然他还小，不懂其中的价值，但你确实给了一个家庭莫大的帮助。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4317); // "这对他们意义重大。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan4", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.OpenDialog(4318); // "王子注视着我，有些愕然。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4319); // "况且，你的话也有所偏颇。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4320); // "珍贵的东西不只有财力或才能，更重要的是……心意。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan4", "zui3"});
            Engine._history = false;
            yield return _gameMethods.OpenDialog(4213); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan4", "zui3"});
            yield return _gameMethods.OpenDialog(4321); // "我把手放在胸口。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4322); // "具有才能的人不少，富有的贵族也很多，"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4323); // "但会选择把这枚金币交给平民，情愿为自己的行为道歉并赔偿的人，却寥寥无几。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4324); // "良心是很宝贵的东西。你恰恰是一位有同情心、有良心的人。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4325); // "这是你身上最宝贵、耀眼，也独一无二的地方。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4326); // "我觉得，如果你坚持下去，会有人感谢你的。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan4", "zui3"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("bb_3_qian");
            yield return _gameMethods.OpenDialog(4213); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan4", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.OpenDialog(4327); // "他怔然地凝视着我。落日的余晖照亮了那双金瞳的眼底，其中浮动着细碎的光芒。"
            yield return _gameMethods.OpenDialog(4328); // "我不躲不闪地对视。"
            yield return _gameMethods.OpenDialog(4329); // "八年之后，我终于亲口向这个人道了谢。"
            yield return _gameMethods.OpenDialog(4330); // "……许久，"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan2", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4213); // "{nw}{w=0.15}"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan4", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4331); // "少年仓促地眨了眨眼睛，"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan4", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4213); // "{nw}{w=0.15}"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan14", "zui3", "emoji3"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4332); // "忽然移开视线，回避了我的目光。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan18", "zui3", "emoji3"});
            Engine._history = false;
            yield return _gameMethods.OpenDialog(4333); // "{nw}{w=0.3}"
            Engine._history = true;
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei3", "yan22", "zui4", "emoji3"});
            yield return _gameMethods.OpenDialog(4334); // "他不自然地垂眸，"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan22", "zui4", "emoji3"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4335); // "抿了抿唇，"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan22", "zui13", "emoji3"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4336); // "弯起一个温润中微带局促的笑容。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan22", "zui12", "-emoji3"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4337); // "我好像，被你鼓舞了呢。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan13", "zui12"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4338); // "……谢谢。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan13", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4339); // "不客气。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan14", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan9", "zui7"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3_qian");
            yield return _gameMethods.OpenDialog(4340); // "「虽然这对淑女可能有些冒犯，{nw}{w=0.2}"
            yield return _gameMethods.Show("wangzi", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"zpos", 18.0f}})});
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<from 0.3 to 0.5>audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
            yield return _gameMethods.ExecuteCharacterImageData("bb_3_qian");
            yield return _gameMethods.OpenDialog(4341); // "——可以问一下你的年龄吗？」"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan9", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4342); // "没关系，我不是淑女。我今年14岁。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan13", "zui12", "emoji1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 18.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4343); // "……那你比我小四岁，比我妹妹要大一些呢。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan13", "zui34", "emoji1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4344); // "哈哈、这样啊……"
            yield return _gameMethods.OpenDialog(4345); // "公主吗。"
            yield return _gameMethods.OpenDialog(4346); // "即便年龄相仿，人生轨迹也没什么可比性吧。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan16", "zui2", "emoji1"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan18", "zui5", "emoji1"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4347); // "那么，你也需要吗？"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan18", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4268); // "嗯？"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan9", "zui6", "-emoji1"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4348); // "金钱。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan13", "zui10", "emoji1"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4349); // "那些用钱就可以留住的幸福，我想送给你。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan13", "zui13", "emoji1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4350); // "……？？"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan21", "zui9", "-emoji1"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4351); // "你刚才对我说的话……对我而言，也意义重大。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan9", "zui10"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4352); // "我想回报给你，比起我给那个孩子所更多的东西。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan13", "zui31", "emoji1"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4353); // "如果这能让你也获得幸福的话。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan13", "zui13", "emoji1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.EngineSetVolume(volume:0.3f, delay:1f, channelName:"music1");
            yield return _gameMethods.OpenDialog(4354); // "可是太晚了。"
            yield return _gameMethods.OpenDialog(4355); // "我所拥有的可以用钱留住的最大的幸福，已经离我而去了。"
            yield return _gameMethods.OpenDialog(4356); // "……不过，有钱谁不要呢。"
            yield return _gameMethods.EngineSetVolume(volume:1f, delay:1f, channelName:"music1");
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0.5 to 1.5>audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"ypos", -78f}, {"zpos", -180.0f}})});
            yield return _gameMethods.TransitionBy("blink2");
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4357); // "好呀。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4358); // "你觉得我的幸福值多少钱呢？"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan5", "zui7", "-emoji1"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4359); // "我只随身带了十几枚金币，宝石可以吗？"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan5", "zui3"});
            yield return _gameMethods.PlaySound("sounda", 0.0f, 0.4f, "audio/sound/moca1.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -8f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 8f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
            yield return _gameMethods.OpenDialog(4360); // "……？！"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4361); // "……宝石还是算了！"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4362); // "那么，你也给我一个金币吧。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan2", "zui3"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4213); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan9", "zui5"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4363); // "……这就够了吗？"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan9", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4364); // "是啊。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4365); // "足够我一年的花销了。"
            yield return _gameMethods.OpenDialog(4366); // "因为我们家只有我一个人。"
            yield return _gameMethods.OpenDialog(4367); // "而且收得多了，就欠了人情债，总有一天要为之付出代价，算了算了。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan18", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan2", "zui10"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4368); // "好。"
            yield return _gameMethods.PlaySound("sounda1", 0.0f, 0.6f, "audio/sound/houhui/Body3 _01.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -180.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.50f}, {"zpos", -204.0f}})});
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui13"});
            yield return _gameMethods.OpenDialog(4369); // "我冲他伸出手，双掌摊开，歪头嘿嘿一笑。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -204.0f}})});
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei3", "yan3", "zui13"});
            yield return _gameMethods.OpenDialog(4370); // "他不禁笑了一下，{nw}{w=0.2}"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan13", "zui14", "emoji0"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4371); // "以授勋般的认真和慎重，取出一枚金闪闪的硬币放进我的手心。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4372); // "谢谢你，好心的先生。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan2", "zui12", "-emoji0"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3_qian");
            yield return _gameMethods.OpenDialog(4373); // "「我才是。{nw}{w=0.2}"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan13", "zui10", "emoji0"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3_qian");
            yield return _gameMethods.OpenDialog(4374); // "多谢你，突然出现的小仙子。」"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan13", "zui14", "emoji0"});
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.OpenDialog(4375); // "……小仙子？"
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.StopSound(channelName:"music1", fadeOut:4f);
            yield return _gameMethods.Transition(time:0.4f);
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/dajie9.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.3f, 1.05f)}, {"anchor", new Vector2(0.5f, 1.0f)}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -50f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition(time:0.5f);
            yield return _gameMethods.PlaySound("music2", 4f, 1.0f, "audio/music/wangzi/luminous.mp3");
            yield return _gameMethods.OpenDialog(4376); // "对话告一段落。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -50f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.8f}, {"ypos", -180f}})});
            yield return _gameMethods.OpenDialog(4377); // "不知还能说些什么，我看了一眼夕阳沦陷的天色。"
            yield return _gameMethods.OpenDialog(4378); // "他敏锐地察觉了。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.69f}, {"ypos", 0f}})});
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui6", "-emoji0"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 2.63f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.46f}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}, {"blur", 0.01f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1f}, {"blur", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4379); // "你要回去了吗？"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4380); // "是啊，你不回去吗？"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan18", "zui15"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4381); // "……我不知道。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan21", "zui15"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}, {"blur", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4382); // "我好像，应该是要回去的。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan21", "zui3"});
            yield return _gameMethods.OpenDialog(4383); // "嘴上如此说，他的脸上却带着迷途的旅人一般的表情，并未挪动脚步。"
            yield return _gameMethods.OpenDialog(4384); // "宛如植株固执地把孱弱的根系插进地面，试图以此停留得更久一点。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4385); // "再不回去，你就只能在外面吃晚饭了。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui6"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4386); // "是吗。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4387); // "我还从没在外面吃过饭呢。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.OpenDialog(4388); // "他是认真的吗？不想回王宫？"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan16", "zui3"});
            yield return _gameMethods.OpenDialog(4389); // "看着他那张不知为何让我感到些许熟悉、有点亲切的面孔。"
            yield return _gameMethods.OpenDialog(4390); // "鬼使神差下，我做出了一个冒险的决定。"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<from 0.3 to 0.5>audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.45f}, {"zpos", -24.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4391); // "好吧。那么，为了答谢你送给我的金币。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -24.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4392); // "你想知道这一枚金币能买到些什么吗？"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan9", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4231); // "……？"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4393); // "呃……我是在邀请你。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4394); // "如果你的胃能接受平民的食物，或许我可以请你吃一顿晚饭。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4395); // "不过不用勉强，毕竟你看起来就是一名贵族嘛。"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 0.7f, "<from 0.3 to 0.5>audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui7"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.41f}, {"zpos", 42.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4396); // "我可以的。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui3"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 42.0f}})});
            yield return _gameMethods.OpenDialog(4397); // "我的话音尚未落下，他便果断地回答。仿佛担心答应得太慢，就会被我收回邀请似的。"
            yield return _gameMethods.OpenDialog(4398); // "……好吧，我的确想说如果他犹豫，我就撤回呢。"
            yield return _gameMethods.OpenDialog(4399); // "毕竟万一他吃出问题，我也要被殃及池鱼。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan18", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3_qian");
            yield return _gameMethods.OpenDialog(4400); // "「……{nw}{w=0.2}"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui10"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3_qian");
            yield return _gameMethods.OpenDialog(4401); // "冒昧请问，你的名字是什么呢？」"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4402); // "那你呢，又叫什么名字？"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan9", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan19", "zui3"});
            yield return _gameMethods.OpenDialog(4403); // "他沉默了。"
            yield return _gameMethods.OpenDialog(4404); // "不方便说是吧。"
            yield return _gameMethods.OpenDialog(4405); // "我知道，因为我也不方便说。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4406); // "那，你可以叫我玛丽。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan9", "zui3"});
            yield return _gameMethods.OpenDialog(4407); // "这是个平庸到烂大街的名字，整个国家至少有三分之一的女孩叫玛丽。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}, {"zpos", -24.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"ypos", -24f}, {"zpos", -48.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4408); // "而我喊你……"
            yield return _gameMethods.OpenDialog(4409); // "我放缓声音，双眼看向他，给对方留出插话的空间。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan2", "zui3"});
            Engine._history = false;
            yield return _gameMethods.OpenDialog(4213); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan9", "zui3"});
            yield return _gameMethods.OpenDialog(4410); // "可他却没有开口的意思，期许而专注地望着我，似乎等待着我的命名。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -24f}, {"zpos", -48.0f}})});
            yield return _gameMethods.OpenDialog(4411); // "于是我只好试探性地问。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4412); // "杰克？"
            yield return _gameMethods.OpenDialog(4413); // "全国也有三分之一的男孩叫杰克。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan11", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4414); // "好的，我是杰克。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan18", "zui14", "emoji0"});
            yield return _gameMethods.OpenDialog(4415); // "他似乎忍不住抿嘴笑了下。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui10", "-emoji0"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4416); // "那么，我们现在该去做什么，玛丽？"
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4417); // "我对我们的晚餐很感兴趣。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4418); // "但是你不回家吃晚饭可以吗？"
            yield return _gameMethods.OpenDialog(4419); // "不知道王室成员平时是不是在一张桌子上用餐。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan2", "zui3"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("bb_3_qian");
            yield return _gameMethods.OpenDialog(4213); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui6"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4420); // "短时间内，我不打算回去。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui3"});
            yield return _gameMethods.OpenDialog(4421); // "他笃定地说。"
            yield return _gameMethods.OpenDialog(4422); // "……这家伙看起来脾性温和，却好像很有主见，下定决心就不罢休。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 2f, "audio/sound/manbu/Body1_02_duan.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -48.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 1f}, {"zpos", 42.0f}})});
            yield return _gameMethods.OpenDialog(4423); // "算了，掰不过他。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4424); // "那就跟我来吧。"
            yield return _gameMethods.StopSound(channelName:"music2", fadeOut:4f);
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1.5>audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg43_memory.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg43_memory.jpg");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/dianpu1.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.0f)}, {"zoom", 0.7f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/music/wangzi/Goodmorning sky.mp3");
            yield return _gameMethods.OpenDialog(4425); // "我把他带进了一家平价配饰店。"
            yield return _gameMethods.OpenDialog(4426); // "少年不动声色地观察着周围。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan2", "zui3"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 2.51f)}, {"zoom", 0.44f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan15", "zui5"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4427); // "这里看上去并不供应食物。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan15", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4428); // "你给的一枚金币面额太大，路边小吃摊肯定不收。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4429); // "我们先买点东西，换点零钱。"
            yield return _gameMethods.Hide("wangzi");
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(4430); // "这家店里卖得都是一些用较为便宜的矿石，——比如水晶、石英、玛瑙、琥珀等——，所打磨而成的工艺品与饰物。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/dianpu1.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.3f, 1.22f)}, {"zoom", 1.05f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(4431); // "不像钻石、红蓝宝石那类昂贵的珠宝般高不可攀，但也同样美丽动人。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4432); // "所以，你选一个吧。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4433); // "虽然不是什么贵重的宝石，就当作买作纪念品啦。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan5", "zui3"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 2.55f)}, {"zoom", 0.45f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4434); // "放心选，这里全场的商品没有我付不了的价钱。"
            yield return _gameMethods.OpenDialog(4435); // "我豪横地说。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan2", "zui3"});
            Engine._history = false;
            yield return _gameMethods.OpenDialog(4213); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan5", "zui3"});
            yield return _gameMethods.OpenDialog(4436); // "他呆立在原地。好像从来没有经历过这样的场景，被女士带着去挑选首饰。"
            yield return _gameMethods.Hide("wangzi");
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(4437); // "被我催促后，王子踟蹰地伸手。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan18", "zui10"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 2.55f)}, {"zoom", 0.45f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 5f}})});
            yield return _gameMethods.Show("dianpu1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 5f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/daoju/baoshi1.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 0.57f)}, {"zoom", 0.18f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4438); // "那么……这个吧。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan18", "zui13"});
            yield return _gameMethods.OpenDialog(4439); // "他选定了一枚湛蓝的玛瑙，拈在指尖。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4440); // "这颗蓝色的浓度很不错。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4441); // "欸，这个吗？"
            yield return _gameMethods.OpenDialog(4442); // "我有点苦恼。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4443); // "这个有点太便宜了，要为此给一枚金币找钱的话，老板也会翻白眼的吧。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei2", "yan1", "zui13"});
            yield return _gameMethods.OpenDialog(4444); // "他好像有点被逗笑了，{nw}{w=0.2}"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui13", "emoji1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4445); // "忍俊不禁。"
            yield return _gameMethods.Hide("Assets/RenpyResources/images/daoju/baoshi1.png");
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui11", "emoji1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Show("dianpu1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4446); // "或许，你可以为自己也选一枚。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui14", "-emoji1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4447); // "有道理。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui14", "-emoji1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 2.55f)}, {"zoom", 0.45f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 5f}})});
            yield return _gameMethods.Show("dianpu1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 5f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/daoju/baoshi2.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 0.67f)}, {"zoom", 0.12f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4448); // "——嗯，就这个好了。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan2", "zui13"});
            Engine._history = false;
            yield return _gameMethods.OpenDialog(4213); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui13"});
            yield return _gameMethods.OpenDialog(4449); // "我举起一枚金色的圆形琥珀。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"ypos", -78f}, {"zpos", -228.0f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"ypos", -78f}, {"zpos", -228.0f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/daoju/baoshi2.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"ypos", 0.89f}, {"zoom", 0.51f}, {"alpha", 0.9f}})});
            yield return _gameMethods.TransitionBy("blink2");
            yield return _gameMethods.OpenDialog(4450); // "用拇指与食指捏着，我透过琥珀看向他。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/daoju/baoshi2.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.7f}, {"alpha", 0.65f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -228.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.49f}, {"zpos", -246.0f}})});
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui13"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"blur", 1f}})});
            yield return _gameMethods.OpenDialog(4451); // "这琥珀的透光度不错，穿过金灿灿的石质，足以看到少年朦胧的人影。我笑起来。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -246.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4452); // "真漂亮，就像闪闪发光的太阳一样呢！"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan4", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4275); // "……！"
            yield return _gameMethods.OpenDialog(4453); // "不知为何，少年忽然错愕地睁大眼睛，讶然地看着我。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan2", "zui3"});
            Engine._history = false;
            yield return _gameMethods.OpenDialog(4213); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan5", "zui3", "emoji3", "emoji4"});
            yield return _gameMethods.OpenDialog(4454); // "两秒后，他原本白皙的耳根逐渐攀爬上了红晕。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan18", "zui5"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4455); // "……咳、"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan18", "zui3"});
            yield return _gameMethods.OpenDialog(4456); // "他稍稍敛眸，握拳遮住鼻尖，不自在地轻咳了一声，错开我的视线，看向一旁。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan22", "zui5"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4457); // "唔……嗯、是啊。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan22", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4231); // "……？"
            yield return _gameMethods.OpenDialog(4458); // "我一头雾水。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1>audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/dianpu1.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.0f)}, {"zoom", 0.7f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            yield return _gameMethods.OpenDialog(4459); // "……去结账时，我才后知后觉地反应过来。"
            yield return _gameMethods.OpenDialog(4460); // "…啊。忽然想起，免税的那年，我似乎听人说起过，王子的名字叫菲珀斯。"
            yield return _gameMethods.OpenDialog(4461); // "这个名字源自古传说中的太阳的名讳，恰好就是指太阳。"
            yield return _gameMethods.OpenDialog(4462); // "……但是，我也不是故意的啊。"
            yield return _gameMethods.OpenDialog(4463); // "我假装一无所知，——反正本来也不是我应该知道的信息——，若无其事地等老板找了零钱。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1>audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/dianpu1.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.3f, 1.22f)}, {"zoom", 1.05f}})});
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan18", "zui3", "-emoji3", "-emoji4"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 2.55f)}, {"zoom", 0.45f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(4464); // "再回来时，他的面色已经恢复了正常。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan9", "zui3"});
            yield return _gameMethods.OpenDialog(4465); // "我将那一大捧银币混合着铜币装进钱袋，宣布。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4466); // "我们接下来去一个市场，那里有很多面向平民的熟食摊子。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4467); // "嗯。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg38_memory.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg38_memory.jpg");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/haibian1.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.05f)}, {"zoom", 0.76f}, {"anchor", new Vector2(0.5f, 1.0f)}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.PlaySound("soundb", 2f, 1.0f, "audio/sound/emeng_dajie/Town Crow_01.ogg");
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            yield return _gameMethods.OpenDialog(4468); // "我们来到了西区的市场。"
            yield return _gameMethods.OpenDialog(4469); // "这里靠近码头，因而受到了很多卸货工人的光顾。"
            yield return _gameMethods.OpenDialog(4470); // "此时，正是人流较多的时段。"
            yield return _gameMethods.OpenDialog(4471); // "下了工的人们一身麻布短衣，满身的汗水混着灰尘形成了泥泞，疲惫地在街道上穿行。"
            yield return _gameMethods.OpenDialog(4472); // "王子体面的衣着在这里吸引了不少视线。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan5", "zui3"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 2.63f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.46f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(4473); // "我买了一个圆圆的小馅饼，分成两半，{nw}{w=0.2}"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan9", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4474); // "递给他半块。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan19", "zui3"});
            yield return _gameMethods.OpenDialog(4475); // "他迟疑地接过，咬了一口，{nw}{w=0.2}"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei3", "yan21", "zui4"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4476); // "刚嚼了一下，便面色一僵，微微皱眉。"
            yield return _gameMethods.OpenDialog(4477); // "这神情一闪而逝，{nw}{w=0.01}"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei3", "yan2", "zui4"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4213); // "{nw}{w=0.15}"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan9", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4478); // "他很快恢复正常神色，富有修养地匀速地咀嚼起来。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4479); // "好吃吗？"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui10"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4480); // "很美味。多谢你。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan9", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4481); // "……骗人的吧。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan9", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.OpenDialog(4482); // "这也能昧着良心夸出来啊。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4483); // "谢谢你照顾我的心情，不过没必要说客套话。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4484); // "你看起来不像喜欢。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan2", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("bb_3_qian");
            yield return _gameMethods.OpenDialog(4213); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan9", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4485); // "实际的感觉呢？"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan18", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4486); // "有些过咸。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 3f, "audio/sound/manbu/Body1_02_duan.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.7f}, {"zpos", 42f}})});
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan18", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4487); // "我猜也是啦。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4488); // "这里的食物都是针对重体力劳动者的。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 42f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4489); // "他们一天要流很多汗，得靠吃盐补充体力，所以口味会比较重。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan14", "zui3"});
            yield return _gameMethods.OpenDialog(4490); // "他若有所思，又咬了一口小馅饼。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan19", "zui3"});
            yield return _gameMethods.OpenDialog(4491); // "我感觉自己仿佛在带着王子吃忆苦思甜饭。"
            yield return _gameMethods.Hide("wangzi");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -222f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(4492); // "吃掉手中的半边小饼，我看到前方不远的一个摊子，顿时眼前一亮。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -8f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 8f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4493); // "是牛肚包！"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4494); // "牛肚包？"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4495); // "这个好吃！"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<from 0 to 1>audio/sound/jiaobusheng_xin_kuai1.ogg");
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/haibian1.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.76f, 1.13f)}, {"zoom", 0.97f}})});
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan9", "zui3"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 2.31f)}, {"zoom", 0.39f}})});
            yield return _gameMethods.Show("bao1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 0.72f)}, {"zoom", 0.41f}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 60f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.8f}, {"yoffset", 0f}})});
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            yield return _gameMethods.OpenDialog(4496); // "我开开心心地买了两个最贵（同时肉的含量也最多）的牛肚包，分给他一个。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/daoju/bao1.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}})});
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan2", "zui3"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv2_qian");
            yield return _gameMethods.OpenDialog(4213); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan14", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4497); // "这是把两块面包的中间掏空，塞进卤牛杂和牛肉，再将面包夹起来做成的。"
            yield return _gameMethods.OpenDialog(4498); // "算是西式肉夹馍吧。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4499); // "这个还蛮贵的，我平时都不舍得买呢。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4500); // "你能吃内脏吗？"
            yield return _gameMethods.Hide("Assets/RenpyResources/images/daoju/bao1.png");
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan9", "zui9"});
            yield return _gameMethods.Transition();
            yield return _gameMethods.ExecuteCharacterImageData("bb_3_qian");
            yield return _gameMethods.OpenDialog(4501); // "「嗯。我的母后——{nw}{w=0.2}"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan18", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3_qian");
            yield return _gameMethods.OpenDialog(4502); // "……{nw}{w=0.2}"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan2", "zui10"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3_qian");
            yield return _gameMethods.OpenDialog(4503); // "母亲和妹妹，不能接受除鹅肝和鱼籽之外的动物内脏。」"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui10"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4504); // "不过我并不太介意这些区别。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4505); // "这样啊。哈哈……"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan19", "zui15"});
            yield return _gameMethods.OpenDialog(4506); // "他咬了一口。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.5>audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -222.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.4f}, {"zpos", -250.0f}})});
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan19", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4507); // "怎么样？虽然味道肯定没有鹅肝和鱼子酱要好啦。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan2", "zui3"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -250.0f}})});
            Engine._history = false;
            yield return _gameMethods.OpenDialog(4213); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan9", "zui13"});
            yield return _gameMethods.OpenDialog(4508); // "他摇摇头，对我露出一个微笑，充分地咀嚼并吞咽下口中的食物，才开口道。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui10"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4509); // "这个比馅饼要更鲜美。"
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:4f);
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition(time:0.4f);
            yield return _gameMethods.OpenDialog(4510); // "…………"
            yield return _gameMethods.OpenDialog(4511); // "此后，我们路过了面包店，观摩了挂在烤炉旁边的巨大硬皮馅饼。"
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/dajie7.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.04f)}, {"zoom", 1.15f}})});
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            yield return _gameMethods.OpenDialog(4512); // "路过煮豌豆小摊时，还买了一份奶酪配煮豌豆。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan15", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 2.63f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.463f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(4513); // "王子忽然指着路边一家破败的面包店柜台上几团黑漆漆的东西，问道。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan15", "zui5"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3_qian");
            yield return _gameMethods.OpenDialog(4514); // "「那是什么？{nw}{w=0.2}"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3_qian");
            yield return _gameMethods.OpenDialog(4515); // "木炭吗。为什么放在柜台上面。」"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui13"});
            yield return _gameMethods.Show("Assets/RenpyResources/images/cg/fenjin/mianbao1.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 0.75f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 1.0f}})});
            yield return _gameMethods.Hide("wangzi");
            yield return _gameMethods.Show("dajie7", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 3f}})});
            yield return _gameMethods.Show("_zoom");
            yield return _gameMethods.Hide("_zoom");
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4516); // "哦，那个啊，是面包。"
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4517); // "……面包？？"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4518); // "是啊。黑面包。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4519); // "穷人吃的，里面都是麸皮，所以看着黑。"
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4520); // "别小看它，这面包很厉害的，出炉后能吃一周。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4521); // "一周后硬得啃不动了，还能切成片，当盘子用。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4522); // "如果家里的盘子正好碎了，那就是件耐用的餐具。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4523); // "我们街上有户人家就用它招待过我们呢。"
            yield return _gameMethods.Hide("Assets/RenpyResources/images/cg/fenjin/mianbao1.jpg");
            yield return _gameMethods.Show("dajie7", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei12", "yan4", "zui3"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 2.63f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.463f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4524); // "……盘子？"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei12", "yan4", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4525); // "是啊。价格实惠，手边就有。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan15", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4526); // "你要试试看吗？就当磨牙口了。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan13", "zui6"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4527); // "……嗯。"
            yield return _gameMethods.ShowBlack();
            yield return _gameMethods.Transition(time:0.4f);
            yield return _gameMethods.OpenDialog(4528); // "我和店主交谈了两句，买了一小片黑面包递给王子。"
            yield return _gameMethods.HideBlack();
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0f, -36f)}, {"zpos", -180.0f}})});
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei9", "yan21", "zui4", "emoji2", "emoji0", "emoji10"});
            yield return _gameMethods.Transition(time:0.5f);
            yield return _gameMethods.OpenDialog(4529); // "他只吃了一口，就难以克制地深深皱起眉，差点呕出来。"
            yield return _gameMethods.OpenDialog(4530); // "我知道那口味，明明是新出炉的面包，却还原出了正宗的馊味。"
            yield return _gameMethods.OpenDialog(4531); // "吃起来又酸又馊又糙又硬，还咯牙，拉嗓子，因为里面有沙子。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4532); // "吃口煮豌豆缓缓吧。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei11", "yan2", "zui4", "emoji2", "-emoji0", "-emoji10"});
            yield return _gameMethods.OpenDialog(4533); // "我同情地把手里用干硬的大麦面包做的碟子递给他。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei3", "yan9", "zui6", "-emoji2"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3_qian");
            yield return _gameMethods.OpenDialog(4534); // "「为什么穷人不吃这个？{nw}{w=0.2}"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei3", "yan21", "zui6"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3_qian");
            yield return _gameMethods.OpenDialog(4535); // "我是说，煮豌豆。」"
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4536); // "你刚刚说，豌豆也很便宜，仅次于土豆。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui6"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4537); // "如果购买生豌豆自己煮熟，花费仍比直接买面包更低。"
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:6f);
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4538); // "这应该可以省下一笔开支，同时不用担心罹患疾病。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui3"});
            yield return _gameMethods.OpenDialog(4539); // "疾病？"
            yield return _gameMethods.OpenDialog(4540); // "……哦。"
            yield return _gameMethods.PlaySound("music1", 3f, 1.0f, "audio/demo_audio/music/youshang1.mp3");
            yield return _gameMethods.OpenDialog(4541); // "教会和贵族认为土豆肿胀且布满麻点，看起来像是麻风病人的手，所以食用土豆会得麻风病。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4542); // "……其实，最穷的那些劳工，有的根本租不起一间屋子。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan9", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4543); // "不少人都是五六个挤在一个房间打地铺，压根没地方做饭。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan5", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4544); // "就算有房间，煮豆子也需要炉灶和锅具，这些器具并不便宜。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4545); // "还有炉灶税呢，这个是要提前交的，而且要一口气交完一年的税款，才能修建炉灶。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4546); // "另外，每次煮熟豌豆也要花时间。那些劳工有些天没亮就要上工，没这个时间慢慢做饭。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan2", "zui3"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("bb_3_qian");
            yield return _gameMethods.OpenDialog(4213); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan4", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4510); // "…………"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4547); // "所以……虽然平摊下来算，自己做饭更划算，而且豆子更有营养。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei3", "yan18", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4548); // "但好多人今天的口粮就是前一天刚挣来的工钱买的，根本无力购置厨具。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4549); // "黑面包就不一样了，不用厨具，买了就能吃，而且可以每次只买一顿的量。"
            yield return _gameMethods.OpenDialog(4550); // "当然，代价就是要让面包师和商人赚差价。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei3", "yan18", "zui6"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4551); // "……也就是说。因为贫穷，他们没有能力购置锅具费用和燃料，做饭省钱。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei3", "yan2", "zui7"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3_qian");
            yield return _gameMethods.OpenDialog(4552); // "「于是反而要浪费更多的钱，{nw}{w=0.2}"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui6"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3_qian");
            yield return _gameMethods.OpenDialog(4553); // "去购买昂贵的面包。」"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4554); // "没错。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4555); // "越是穷人就越难省钱啦。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan22", "zui3"});
            yield return _gameMethods.OpenDialog(4556); // "就这一点而言，母亲和我其实一起过的还不错。"
            yield return _gameMethods.OpenDialog(4557); // "她在贵族家里做女仆的薪水还算优厚，我们每天都能喝上温暖的浓汤。"
            yield return _gameMethods.OpenDialog(4558); // "只是由于家里只有一名劳动力，而每周的租房等固定开支又实在无法节省，所以日子才过得紧巴巴的。"
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.StopSound(channelName:"music1", fadeOut:6f);
            yield return _gameMethods.PlaySound("soundb", 2f, 1.0f, "audio/demo_audio/sound/chong1.ogg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/bg/dajie7.jpg");
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/dajie7_1.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.04f)}, {"zoom", 1.15f}})});
            yield return _gameMethods.Hide("wangzi");
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan22", "zui3"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 2.63f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.46f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -500f}})});
            yield return _gameMethods.Transition(time:0.6f);
            yield return _gameMethods.OpenDialog(4510); // "…………"
            yield return _gameMethods.OpenDialog(4559); // "天色已经黑透了。"
            yield return _gameMethods.OpenDialog(4560); // "我觉得如果自己再不回去，安德鲁可能就要开始想七想八地担心，并在整条街里搜寻我的下落。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"ypos", -36f}})});
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan15", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4561); // "就到这里吧。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan9", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4562); // "好像跟你讲了很多不怎么愉快的事，不过还是希望这顿晚餐你吃得开心。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan13", "zui10", "emoji1"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3_qian");
            yield return _gameMethods.OpenDialog(4563); // "「非常。{nw}{w=0.2}"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan19", "zui10"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3_qian");
            yield return _gameMethods.OpenDialog(4564); // "这是我所受到过的最好的一次招待。」"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan19", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4565); // "嘿嘿，那就好。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1>audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -36f}, {"zpos", -180.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.7f}, {"ypos", 6f}, {"zpos", -96.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4566); // "那么——再见啦，杰克。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan5", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4567); // "回去路上小心。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 6f}, {"zpos", -96.0f}})});
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan4", "zui6"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3_qian");
            yield return _gameMethods.OpenDialog(4400); // "「……{nw}{w=0.2}"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan18", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3_qian");
            yield return _gameMethods.OpenDialog(4502); // "……{nw}{w=0.2}"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan21", "zui5"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3_qian");
            yield return _gameMethods.OpenDialog(4568); // "嗯。」"
            yield return _gameMethods.ShowBlack();
            yield return _gameMethods.Transition(time:0.5f);
            yield return _gameMethods.OpenDialog(4569); // "我转过身，朝着所住街区的方向迈开脚步。"
            yield return _gameMethods.OpenDialog(4570); // "刚匆匆走出几步，听到身后的一声呼唤。"
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4571); // "……玛丽。"
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:2f);
            yield return _gameMethods.HideBlack();
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"ypos", 138f}, {"zpos", 282.0f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/dajie7_1.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.69f, 1.5f)}, {"zoom", 1.56f}, {"anchor", new Vector2(0.5f, 1.0f)}})});
            yield return _gameMethods.Hide("wangzi");
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 2.63f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.45f}})});
            yield return _gameMethods.Transition(time:0.5f);
            yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/music/wangzi/PerituneMaterial_Scéal_Réalta_inst_loop.mp3");
            yield return _gameMethods.OpenDialog(4572); // "我停了下来，迷惑地转头看他。"
            yield return _gameMethods.OpenDialog(4573); // "月光下，他背对着月亮，朝向我，面部陷入一片阴影之中。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan21", "zui6"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3_qian");
            yield return _gameMethods.OpenDialog(4574); // "「我们以后，{nw}{w=0.2}"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan5", "zui6"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3_qian");
            yield return _gameMethods.OpenDialog(4575); // "还会再见面吗？」"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan5", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4576); // "有机会吧。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan18", "zui7"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4577); // "……好。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui7"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4578); // "那个、你——……"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4258); // "？"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan19", "zui3"});
            yield return _gameMethods.OpenDialog(4579); // "他最终垂了垂眼睛，{nw}{w=0.2}"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan22", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4580); // "淡淡微笑。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan22", "zui10"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4581); // "没什么。希望以后还能再见吧。"
            yield return _gameMethods.ShowBlack(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0f, 0f)}, {"pos", new Vector2(-288f, 0f)}, {"zoom", 2.0f}})});
            yield return _gameMethods.Hide("wangzi");
            yield return _gameMethods.Transition(time:0.6f);
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.HideBlack();
            yield return _gameMethods.Show("Assets/RenpyResources/images/texiao/huiyi_biankuang.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"zpos", 0.0f}, {"anchor", new Vector2(0f, 0f)}, {"zoom", 1f}})});
            yield return _gameMethods.Transition(time:0.6f);
            yield return _gameMethods.OpenDialog(4510); // "…………"
            yield return _gameMethods.OpenDialog(4582); // "在那之后，我没有再去过和王子相遇过的那个街区。"
            yield return _gameMethods.OpenDialog(4583); // "就像两条直线，在短暂而偶然的相交后，再次回归各自的轨道。"
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/cave2.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.06f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.69f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.PlaySound("sounda", 0.0f, 2f, "audio/sound/emeng_dajie/Swing Whoosh_01.mp3");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/texiao/huiyi_biankuang.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}})});
            yield return _gameMethods.Transition(time:0.5f);
            Defaults.Persistent.Jq_5_3 = 1;
            yield return _gameMethods.OpenDialog(4584); // "——————————没想到，多年以后，我们会以这种方式重逢。"
            yield return _gameMethods.OpenDialog(4585); // "他看起来无比狼狈，命悬一线。"
            yield return _gameMethods.OpenDialog(4586); // "而我，看起来还活着，其实也好不了多少。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.OpenDialog(4587); // "好吧，我就知道，金币不是白拿的。"
            yield return _gameMethods.OpenDialog(4588); // "拿人钱财，替人消灾。"
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:4f);
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 2f}, {"zpos", -30.0f}})});
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan21", "zui3", "emoji1", "emoji2", "emoji6", "emoji7", "emoji8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.58f, 2.2f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.38f}})});
            yield return _gameMethods.Transition(time:0.5f);
            yield return _gameMethods.OpenDialog(4589); // "我轻轻走近。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei3", "yan14", "zui1", "emoji0"});
            yield return _gameMethods.OpenDialog(4590); // "他虽然受伤，但却似乎保持着警觉，{nw}{w=0.2}"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei4", "yan20", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4591); // "闻声抬头看来。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan9", "zui15"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4592); // "…………是你。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan9", "zui2"});
            yield return _gameMethods.OpenDialog(4593); // "令我惊讶的是，他认出了我。{nw}{w=0.01}"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan18", "zui13", "emoji4"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4594); // "微微苦笑。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan22", "zui10"});
            yield return _gameMethods.PlaySound("music1", 3f, 1.0f, "audio/music/wangzi/luminous.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4595); // "……已经出现幻觉了么……"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan22", "zui14"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(108f, -108f)}, {"zpos", -342.0f}})});
            yield return _gameMethods.TransitionBy("blink2");
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/houhui/Grab Hand_01.mp3");
            yield return _gameMethods.OpenDialog(4596); // "我蹲下来，捏了一下他的脸。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei3", "yan4", "zui2", "-emoji0", "-emoji1"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4597); // "？！"
            yield return _gameMethods.OpenDialog(4598); // "他睁大眼睛望向我，惊讶的眼睛像无辜的动物。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 2f, "audio/sound/manbu/Body1_02_duan.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -342.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.8f}, {"zpos", -324.0f}})});
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei3", "yan4", "zui2"});
            yield return _gameMethods.OpenDialog(4599); // "我收回手，感到指尖微热，他皮肤温度仿佛还残留在上面。"
            yield return _gameMethods.OpenDialog(4600); // "错觉么，他脸似乎有点发烫。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4601); // "现在知道我不是幻觉了吧？"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -324.0f}})});
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei3", "yan2", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("bb_3_qian");
            yield return _gameMethods.OpenDialog(4213); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei3", "yan4", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan18", "zui10"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4467); // "嗯。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan18", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4602); // "怎么把自己弄得这么狼狈，杰克？"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei12", "yan2", "zui13", "emoji5"});
            yield return _gameMethods.OpenDialog(4603); // "他苦笑。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei12", "yan22", "zui11"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4604); // "是我实力不足。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei12", "yan22", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4605); // "你不是在邻国游历求学么。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4606); // "就算回国，现在也应该在王宫才是。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei10", "yan13", "zui6"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4607); // "……对不起。"
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4608); // "那时我回来晚了。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei10", "yan9", "zui6"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4609); // "我没能阻止父亲……"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei10", "yan22", "zui6"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3_qian");
            yield return _gameMethods.OpenDialog(4610); // "「我想闯进去，带你离开，{nw}{w=0.2}"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei9", "yan2", "zui15"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3_qian");
            yield return _gameMethods.OpenDialog(4611); // "却被骑兵拦住了。」"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei9", "yan22", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.OpenDialog(4612); // "闯进去？闯进哪里？"
            yield return _gameMethods.OpenDialog(4613); // "带我离开？什么时候？"
            yield return _gameMethods.OpenDialog(4614); // "被骑兵拦住？"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei9", "yan2", "zui3"});
            Engine._history = false;
            yield return _gameMethods.OpenDialog(4213); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei9", "yan22", "zui3"});
            yield return _gameMethods.OpenDialog(4615); // "……我懵了半天，忽然想起什么。"
            yield return _gameMethods.OpenDialog(4616); // "——两年前，我被黑龙带走前的那一天……"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 2f, "audio/sound/emeng_dajie/Swing Whoosh_01.mp3");
            yield return _gameMethods.StopSound(channelName:"music1", fadeOut:3f);
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/wanggongwoshi_huanghun.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.13f)}, {"zoom", 0.88f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/texiao/huiyi_biankuang.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"zpos", 0.0f}, {"anchor", new Vector2(0f, 0f)}, {"zoom", 1f}})});
            yield return _gameMethods.Transition(time:0.5f);
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(4617); // "话说，昨晚好像听到了房间外有一些骚乱。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(4618); // "估计是又召开了什么宫廷宴会吧。总之和我不可能有关。"
            yield return _gameMethods.PlaySound("sounda1", 0.0f, 2f, "audio/sound/emeng_dajie/Swing Whoosh_01.mp3");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/wanggongwoshi_huanghun.jpg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(108f, -108f)}, {"zpos", -324.0f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/cave2.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.06f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.69f}})});
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei9", "yan2", "zui3", "emoji2", "emoji6", "emoji7", "emoji8", "emoji4"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.58f, 2.2f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.38f}})});
            yield return _gameMethods.Hide("Assets/RenpyResources/images/texiao/huiyi_biankuang.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}})});
            yield return _gameMethods.Transition(time:0.4f);
            yield return _gameMethods.OpenDialog(4510); // "…………"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -8f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 8f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/moca1.ogg");
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4619); // "是你？？？"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4620); // "在黑龙来的前一夜，你打算闯进我的房间，带我离开？！"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei9", "yan2", "zui6"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4621); // "嗯……"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei9", "yan21", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4622); // "…………为什么？"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei9", "yan21", "zui6"});
            yield return _gameMethods.PlaySound("music", 0.0f, 0.8f, "audio/music/wangzi/maou_bgm_piano_song_ahurera.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4623); // "你是，国家的子民，是…活生生的性命。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei9", "yan13", "zui6"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4624); // "没人有资格剥夺你的生命，"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei9", "yan13", "zui7"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4625); // "卡佩家族绝不靠出卖自己的子民苟活。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei9", "yan13", "zui4"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.OpenDialog(4626); // "震惊，国王是怎么生出这样的儿子来的。"
            yield return _gameMethods.OpenDialog(4627); // "怪不得预言里写，假若黑龙沉睡，人类王国能迎来三百年繁荣。"
            yield return _gameMethods.OpenDialog(4628); // "大概他就是下一代明君吧。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei9", "yan2", "zui4"});
            Engine._history = false;
            yield return _gameMethods.OpenDialog(4213); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei9", "yan13", "zui4"});
            yield return _gameMethods.OpenDialog(4629); // "那么此刻，他出现在这里，还遍体鳞伤，难道也是为了来找我？"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4630); // "话说……你居然不赞成的吗？"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4631); // "我还以为你可能多少有些犹豫，但最终还是会做出割舍。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4632); // "毕竟这是为了保住正牌的公主，你的妹妹。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei10", "yan18", "zui6"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4633); // "你，你也是，我的妹妹……"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei10", "yan18", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/houhui/Body3 _01.mp3");
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei12", "yan22", "zui6"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.51f}, {"zpos", 10.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4634); // "我是兄长，应该保护你们。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei9", "yan2", "zui7"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4635); // "——不，不是的。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei10", "yan13", "zui6"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4636); // "我想要、……我必须，向你赎罪。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei10", "yan22", "zui6"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 10.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4637); // "我一直想，再见你一面。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei10", "yan2", "zui7"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4638); // "睡不着的时候，我很对不起你。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei10", "yan22", "zui3"});
            yield return _gameMethods.OpenDialog(4639); // "他有些颠三倒四地说。"
            yield return _gameMethods.PlaySound("sounda1", 0.0f, 0.7f, "audio/sound/emeng_dajie/Magic Spell Book Pages Flipping_01.ogg");
            yield return _gameMethods.OpenDialog(4640); // "我忽然察觉，他的状态似乎不太对劲。"
            yield return _gameMethods.OpenDialog(4641); // "虽然不知道平时的王子殿下是什么模样，但现在的他显然有点逻辑混乱。"
            yield return _gameMethods.OpenDialog(4642); // "对我所表现出来的态度，也未免过于缺乏距离感和边界感了。"
            yield return _gameMethods.OpenDialog(4643); // "作为只不过见过一次面的人而言，他显得太亲近、太无话不谈。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4644); // "不好意思，冒犯一下。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 3f, "audio/sound/manbu/Body1_02_duan.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -324.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.7f}, {"zpos", -342.0f}})});
            yield return _gameMethods.OpenDialog(4645); // "我伸出手，探向他的额头。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan9", "zui3"});
            yield return _gameMethods.OpenDialog(4646); // "他短暂地愣了一下，没有避开，{nw}{w=0.2}"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/houhui/Grab Hand_01.mp3");
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan18", "zui3"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 10.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"zpos", 25.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4647); // "反而稍微侧脸，隐蔽地、却也的确是更进一步地把额头贴进了我微凉的掌心。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -342.0f}})});
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan2", "zui3"});
            yield return _gameMethods.OpenDialog(4648); // "青年一直蹙起的眉心微微松开，露出有些舒适的神色。"
            yield return _gameMethods.OpenDialog(4649); // "额头好烫。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan13", "zui3"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 25.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4650); // "你发烧了。"
            yield return _gameMethods.OpenDialog(4651); // "恐怕是伤口发炎引发的并发症。"
            yield return _gameMethods.OpenDialog(4652); // "必须给他降温消炎，不然凶多吉少。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4653); // "你出门有没有带药剂？"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan21", "zui6"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4654); // "嗯，带了……"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan21", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4655); // "放在哪里？"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan2", "zui7"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4656); // "用完了……"
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:6f);
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan21", "zui3"});
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.OpenDialog(4657); // "说话能不能不要大喘气。"
            yield return _gameMethods.OpenDialog(4658); // "也是，如果身上有药，也不至于落到这副境地了。"
            yield return _gameMethods.OpenDialog(4659); // "我不禁开始恨铁不成钢。"
            yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/demo_audio/music/qingkuai2.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -8f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 8f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4660); // "话说单人上路，你胆子也太大了吧！"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4661); // "连勇者都是带着一名奥术兼药剂师的呢。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui6"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4662); // "我是私自出来的，我不能暴露行迹。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4663); // "不是，你都没有个私人心腹什么的吗……"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan19", "zui7"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4664); // "有，但他劝阻我不要来。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei3", "yan21", "zui10"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4665); // "既如此，我也不愿意为此耽误了别人的前程。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei3", "yan21", "zui3"});
            yield return _gameMethods.OpenDialog(4666); // "……所以你就把自己心腹给丢下了？就因为他不认同你的行动？"
            yield return _gameMethods.OpenDialog(4667); // "人家说不定只是好心劝两句，也没说不听你命令吧！"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan22", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.OpenDialog(4668); // "到底是该说这家伙是善解人意，还是倔脾气啊。"
            yield return _gameMethods.OpenDialog(4669); // "这人真能当国王吗？"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4670); // "你看起来好像脾气随和，其实还挺固执的吧。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan18", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4671); // "……是吗。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3_qian");
            yield return _gameMethods.OpenDialog(4672); // "「你这么说……{nw}{w=0.2}"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan2", "zui10"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3_qian");
            yield return _gameMethods.OpenDialog(4673); // "那大概就是吧。」"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan2", "zui13"});
            yield return _gameMethods.OpenDialog(4674); // "不过这么说，他是一个人单枪匹马闯到了这里？也算是厉害了。"
            yield return _gameMethods.OpenDialog(4675); // "菲珀斯并非预言中的勇者，不用肩负为三年后决战做准备的使命，所以可以不管不顾地直奔这里来，竟然比安德鲁更早一步来到了此处。"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<from 0.3 to 0.5>audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -342.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.8f}, {"zpos", -276.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4676); // "总之，我先帮你降降温吧。"
            yield return _gameMethods.OpenDialog(4677); // "我决定去洞外找点派得上用场的草药。"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/houhui/Tight Face_02_duan.mp3");
            yield return _gameMethods.Show("wangzi", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 25.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.24f}, {"zpos", 37.0f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -276.0f}})});
            yield return _gameMethods.OpenDialog(4678); // "站起正要转身时，他拉住了我的裙摆。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei3", "yan13", "zui7"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4679); // "你要去哪里？"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei3", "yan13", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4680); // "我去找点药。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei12", "yan9", "zui7"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 37.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4681); // "不用…别走，我会好的。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei3", "yan9", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.OpenDialog(4682); // "我信你有鬼。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4683); // "只是一会，我马上回来。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei3", "yan13", "zui7"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4684); // "多久？"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei3", "yan9", "zui3"});
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.OpenDialog(4685); // "虽然彼此还不熟，但我已经感觉到他性格中的麻烦之处了。"
            yield return _gameMethods.OpenDialog(4686); // "这家伙生病时好缠人啊。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4687); // "你在心中默数到八千只羊，我就回来了。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei3", "yan13", "zui7"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4688); // "如果你没回来怎么办。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei3", "yan9", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4689); // "……那你就继续数到两万只羊。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -8f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 8f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/moca1.ogg");
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4690); // "千万别乱走啊！我回来时会给你带礼物的。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan18", "zui6"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4691); // "……。我会数的，你早一点回来。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan18", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4692); // "收到。好的。我尽量。"
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:3f);
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/woshi_nv2.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.0f)}, {"zoom", 0.7f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            yield return _gameMethods.OpenDialog(4510); // "…………"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/caoyao.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 0.8f)}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.PlaySound("music2", 0.0f, 1.0f, "audio/demo_audio/music/richang1.mp3");
            yield return _gameMethods.OpenDialog(4693); // "我折回了城堡，取了一些消毒和降温的草药。"
            yield return _gameMethods.OpenDialog(4694); // "这是自从我上次生病受伤后，在集市上采购回来备用的。都只是些不含魔力的普通草药。"
            yield return _gameMethods.OpenDialog(4695); // "如果有专门的魔法炼金药剂就更好了，使用后几分钟内就能令伤口愈合。"
            yield return _gameMethods.OpenDialog(4696); // "但因为我并非体质强健的骑士，也不是体内拥有魔力回路的魔法师；作为普通人，我很难承受比较烈性的魔药。"
            yield return _gameMethods.OpenDialog(4697); // "赫泽尔又是天生具有强大的体魄，无需外物治疗。"
            yield return _gameMethods.OpenDialog(4698); // "因此，城堡中没有魔药储备。"
            yield return _gameMethods.OpenDialog(4699); // "……只能相信纯天然的草本功效，以及王子作为骑士的强大体质和自愈能力了。"
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/senlin6.jpg");
            yield return _gameMethods.PlaySound("soundb", 1f, 1.0f, "audio/sound/dashuizhang/Spilling Stream Into Creek Gurgling Water_01.ogg");
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            yield return _gameMethods.OpenDialog(4700); // "在回去山洞的途中，我绕了趟水潭，用冷水浸透了绸缎。"
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:2f);
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/cave1.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.21f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.69f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            yield return _gameMethods.OpenDialog(4701); // "回到山洞时，我发现王子挪动了自己的位置。"
            yield return _gameMethods.OpenDialog(4702); // "他没离开山洞，就坐在最靠近洞口的地方。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui3", "emoji4", "emoji2", "emoji6", "emoji7", "emoji8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.73f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.27f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(12f, -24f)}, {"zpos", -420f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(4703); // "因此，在我出现的刹那间，那双黄金瞳就望向了了我。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.OpenDialog(4704); // "你是留守在家的看门动物吗。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0.5 to 1.5>audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"ypos", -54f}, {"zpos", -528.0f}})});
            yield return _gameMethods.TransitionBy("blink2");
            yield return _gameMethods.OpenDialog(4705); // "我走近他，将冰冷的湿巾贴在他的额头上。"
            yield return _gameMethods.OpenDialog(4706); // "然后在处理草药时，发现自己忘带研磨工具了。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4510); // "…………"
            yield return _gameMethods.PlaySound("sounda2", 0.0f, 0.6f, "audio/demo_audio/sound/sibuliao2.mp3");
            yield return _gameMethods.OpenDialog(4707); // "我默默地将那些草药撕了撕，丢进嘴里嚼碎了，糊在他的伤口上。"
            yield return _gameMethods.OpenDialog(4708); // "……没关系。最天然的草本精华，往往只需要最朴素的处理方式。"
            yield return _gameMethods.PlaySound("sounda1", 0.0f, 0.5f, "audio/demo_audio/sound/sibuliao.mp3");
            yield return _gameMethods.OpenDialog(4709); // "想当初我刚到城堡时，也是这么敷治伤口的。这就是我们荒野求生者之间的羁绊。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"ypos", -24f}, {"zpos", -408.0f}})});
            yield return _gameMethods.TransitionBy("blink2");
            yield return _gameMethods.OpenDialog(4710); // "在做这一切时，王子一直目不转睛地盯着我。"
            yield return _gameMethods.OpenDialog(4711); // "我的心头涌上了一股心虚。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4712); // "……我是有意这样做的。"
            yield return _gameMethods.OpenDialog(4713); // "我欲盖弥彰地解释。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4714); // "这样可以最大程度地保留药效，不让草药中的药性流失。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.OpenDialog(4715); // "他却好像一句都没听进去，只是有点晃神似的看着我的脸。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan18", "zui13"});
            yield return _gameMethods.OpenDialog(4716); // "随后，他低低地笑了一声。"
            yield return _gameMethods.StopSound(channelName:"music2", fadeOut:3f);
            yield return _gameMethods.PlaySound("sound", 0.0f, 2f, "audio/sound/manbu/Body1_02_duan.mp3");
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan2", "zui13"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(4717); // "身体突然一歪，整个人栽在了我的肩头。"
            yield return _gameMethods.OpenDialog(4718); // "接着，有些开心似的将脸颊埋进我的颈窝里，轻微地贴在皮肤上，像是感慨、又仿佛梦呓一般喃喃。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan2", "zui10"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"ypos", -60f}, {"zpos", -540.0f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.PlaySound("music", 3f, 1.0f, "audio/music/wangzi/PerituneMaterial_Memories6_Piano_loop.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4719); // "终于、又见到你了……"
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4720); // "玛丽。"
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4721); // "我好想你。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan2", "zui14"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4722); // "……是，是吗。"
            yield return _gameMethods.OpenDialog(4723); // "明明只见过一面……？"
            yield return _gameMethods.OpenDialog(4724); // "怎么回事，这个距离感。"
            yield return _gameMethods.OpenDialog(4725); // "我浑身僵硬，对于这位并不太熟的王子此刻所展现出来的兄妹情深，感到颇为不自在。"
            yield return _gameMethods.OpenDialog(4726); // "但顾及到他是病人，还是为了我千里迢迢赶来的，便也狠不下心把对方推开。"
            yield return _gameMethods.OpenDialog(4727); // "发烧真可怕。可以预见，等他醒来后，这将会成为王子终生难忘的黑历史。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan18", "zui10"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4728); // "这四年里，"
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4729); // "我有很多事想问你……"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan18", "zui14"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4730); // "那，你现在可以问了。来问吧。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui6"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4731); // "我不想听答案。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4258); // "？"
            yield return _gameMethods.OpenDialog(4732); // "好麻烦啊，这个人。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan19", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan19", "zui6"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4733); // "……求你原谅我。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan19", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.OpenDialog(4734); // "……哦，原来是这件事。"
            yield return _gameMethods.OpenDialog(4735); // "我没有回答。"
            yield return _gameMethods.OpenDialog(4736); // "他好像不安了，抬起头看我。"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/manbu/Body1_01.mp3");
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui6"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"zpos", 3.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4737); // "对不起……求你原谅我。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei3", "yan9", "zui4"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan22", "zui6"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 3.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4738); // "抱歉。我也知道，自己没有资格对你这么说。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan22", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4739); // "想让我原谅你吗？"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui6"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4740); // "……我该怎么做？"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4741); // "好好睡一觉。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4742); // "等烧退了，伤好了，就回去王都。"
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4743); // "我不能在这里呆太久。"
            yield return _gameMethods.OpenDialog(4744); // "如果夜里不回到城堡，城堡下的魔法阵里会留下记录。到时候我很难同回来的赫泽尔交代。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan18", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4745); // "回去吧，王子殿下。"
            yield return _gameMethods.OpenDialog(4746); // "我半开玩笑地说，试图缓和气氛。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4747); // "你可是国民们的太阳啊，担任着普照万物的职责。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.OpenDialog(4748); // "他却丝毫没有笑意，仍是盯着我沉默。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.OpenDialog(4749); // "我叹了口气，认真起来，盯着他的双眼。"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 0.5f, "audio/demo_audio/sound/moca2.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -540.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.5f}, {"zpos", -552.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(4750); // "答应我，你会回去。"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan2", "zui3"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("bb_3_qian");
            yield return _gameMethods.OpenDialog(4213); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4150); // "……"
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan9", "zui3"});
            yield return _gameMethods.OpenDialog(4751); // "我们对视片刻。"
            yield return _gameMethods.OpenDialog(4752); // "最终，他垂下眼眸。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -552.0f}})});
            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan22", "zui6"});
            yield return _gameMethods.ExecuteCharacterImageData("bb_3");
            yield return _gameMethods.OpenDialog(4753); // "我会回去的。"
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.Transition(time:0.5f);
            yield return _gameMethods.OpenDialog(4510); // "…………"
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:7f);
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/senlin4.jpg");
            yield return _gameMethods.PlaySound("soundb", 1f, 1.0f, "audio/sound/dashuizhang/Spilling Stream Into Creek Gurgling Water_01.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            yield return _gameMethods.OpenDialog(4754); // "离开了山洞后，我在湖泊里泡了一下，先冲淡味道。"
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/woshi_nv2.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.0f)}, {"zoom", 0.56f}})});
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:2f);
            yield return _gameMethods.OpenDialog(4755); // "回到城堡，我快速用香皂洗了个澡，然后抱住从赫泽尔那里骗到的枕头，浑身在枕头上蹭了蹭。"
            yield return _gameMethods.OpenDialog(4756); // "嗯，应该不会露出端倪了。"
        }
}