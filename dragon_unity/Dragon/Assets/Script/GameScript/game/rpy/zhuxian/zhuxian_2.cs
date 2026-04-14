    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class zhuxian_2 : ILabelProvider
    {
        private GameMethods _gameMethods;

        public zhuxian_2(GameMethods gameMethods)
        {
            _gameMethods = gameMethods;
        }

            public IEnumerator label_zhuxian_2()
        {
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 2>audio/demo_audio/sound/zu3_nv_zou.ogg");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan11", "zui8", "emoji10"});
            yield return _gameMethods.OpenDialog(1859); // "嘿嘿，睡了。"
            yield return _gameMethods.StopSound(channelName:"music1", fadeOut:5f);
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.PlaySound("soundb", 0.0f, 1.0f, "audio/demo_audio/sound/niaoming.ogg");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/woshi_nv2_tian.jpg");
            yield return _gameMethods.TransitionBy("blink3");
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_shufang_baitian_quanjing.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.0f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.7f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(1861); // "…………"
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_mofa_yuan_liang.jpg");
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(1861); // "…………"
            Defaults.Persistent.Jq_2_5 = 1;
            yield return _gameMethods.OpenDialog(1862); // "一觉醒来，我就迫不及待地跑出房间，把城堡逛了一圈。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/ding1.mp3");
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:3f);
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui7", "-emoji10"});
            yield return _gameMethods.OpenDialog(1863); // "确定了。赫泽尔已经离开了。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan12", "zui8", "emoji9", "emoji10"});
            yield return _gameMethods.OpenDialog(1864); // "~~~"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui16", "-emoji9", "-emoji10"});
            yield return _gameMethods.OpenDialog(1865); // "我感觉好像压在头顶的一块石头被挪走了。"
            yield return _gameMethods.PlaySound("soundc", 0.0f, 1.0f, "audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_dating_baitian.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.0f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.7f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.PlaySound("music", 2f, 0.9f, "audio/music/chumen1.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan3", "zui7"});
            yield return _gameMethods.OpenDialog(1866); // "散步在城堡里，我感到前所未有的轻松。"
            yield return _gameMethods.StopSound(channelName:"soundc", fadeOut:1f);
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15"});
            yield return _gameMethods.OpenDialog(1867); // "接着，另一种念头便控制不住地升起。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan17", "zui15"});
            yield return _gameMethods.OpenDialog(1868); // "——要不要，趁机逃跑？"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1>audio/sound/jiaobusheng_xin_kuai1.ogg");
            yield return _gameMethods.SetDialogUIShowOrHide("hide");
            yield return _gameMethods.Scene("heilong_dating_men_baitian", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"xpos", 0.5f}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.91f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 1.11f}, {"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.3f}, {"ypos", 1.22f}, {"zpos", 366.0f}})});
            yield return _gameMethods.Transition(time:1.3f);
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_dating_men_baitian.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(0.5f, 1.22f)}, {"zpos", 366.0f}})});
            yield return _gameMethods.SetDialogUIShowOrHide("show");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(1869); // "我走到大门前，"
            yield return _gameMethods.PlaySound("sound", 0.0f, 2f, "audio/sound/door_tui.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1870); // "用力一推——"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan10", "zui17"});
            yield return _gameMethods.OpenDialog(1871); // "门板纹丝不动。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan17", "zui15"});
            yield return _gameMethods.OpenDialog(1872); // "……再努力一把。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.28f}, {"zpos", -90f}})});
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.5f, "audio/sound/door_zhuang1.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan11", "zui18"});
            yield return _gameMethods.OpenDialog(1873); // "我发动舍身撞击。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -90f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan2", "zui18", "emoji2"});
            yield return _gameMethods.OpenDialog(1874); // "大门无动于衷。"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<from 0 to 2>audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan5", "zui16", "emoji2"});
            yield return _gameMethods.OpenDialog(1875); // "只能借助科学的力量了！我后退三步，"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1>audio/sound/jiaobusheng_xin_kuai1.ogg");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan9", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(1876); // "助跑、"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan2", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(1877); // "起跳，"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -6f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 6f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/door_zhuang2.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan12", "zui5", "-emoji2", "emoji7"});
            yield return _gameMethods.OpenDialog(1878); // "利用惯性一个潇洒的回旋踢。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan2", "zui16", "emoji17", "-emoji7"});
            yield return _gameMethods.OpenDialog(1879); // "大门巍然如山，把我的脚撞得很痛。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui16", "emoji17"});
            yield return _gameMethods.OpenDialog(1880); // "…………最后，我不死心地向内拉门，又找了一截铁片试图疏通门缝，却只感觉仿佛撞到了空气墙，某种柔韧又坚实的压力阻止了铁皮的活动。"
            yield return _gameMethods.PlaySound("soundb", 0.0f, 1.0f, "audio/sound/jiaobusheng_xin_man1.ogg");
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(1881); // "每个房间、每扇窗户也同样的情况。"
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:1f);
            yield return _gameMethods.OpenDialog(1882); // "……唉，果然。"
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/heilong_dating_baitian_louti.jpg");
            yield return _gameMethods.Transition(time:1f);
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/emeng_dajie/Lying Bed_01.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui16", "emoji17"});
            yield return _gameMethods.OpenDialog(1883); // "我蔫蔫地坐回了大厅的阶梯上。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15", "emoji2", "emoji6", "-emoji17"});
            yield return _gameMethods.OpenDialog(1884); // "虽然一开始就想到没那么简单，但真的撞了墙，还是难免失落。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15", "-emoji2", "-emoji6"});
            yield return _gameMethods.OpenDialog(1885); // "算了，还是想想能做的事情吧。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui15"});
            yield return _gameMethods.OpenDialog(1886); // "难得的一天自由，要用来做些什么呢？"
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/tiankong_baitian.jpg");
            yield return _gameMethods.Transition(time:1f);
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.OpenDialog(1887); // "我再次把城堡跑了一圈。"
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/tiankong_yewan.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.45f)}, {"zoom", 1.37f}})});
            yield return _gameMethods.Transition(time:1f);
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/tangxia2_duan.mp3", "audio/demo_audio/sound/book1.mp3", "<silence 0.7>", "audio/demo_audio/sound/book1.mp3");
            yield return _gameMethods.OpenDialog(1888); // "最后，嚣张地躺在沙发上读了一天书。"
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:8f);
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.ChangeLabelTo("label_zhuxian_demo");
        }

        public IEnumerator label_zhuxian_demo()
        {
            yield return _gameMethods.PlaySound("soundb", 0.0f, 1.0f, "audio/demo_audio/sound/niaoming.ogg");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/woshi_nv2_tian.jpg");
            yield return _gameMethods.TransitionBy("blink3");
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.OpenDialog(1889); // "第二天，一大清早，我就醒了。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(1890); // "今天中午，赫泽尔就要回来了。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 2>audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/heilong_chufang_baitian_man.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.67f}})});
            yield return _gameMethods.Transition(time:1f);
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15"});
            yield return _gameMethods.OpenDialog(1891); // "我去一楼的厨房草草吃了一块面包填饱肚子，一边盘算起来，上午要做什么。"
            yield return _gameMethods.OpenDialog(1892); // "忽然。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/door_qiao_1.mp3");
            yield return _gameMethods.OpenDialog(1893); // "咚、咚。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(1894); // "……？幻听么。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.5f, "audio/sound/door_qiao_1.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1893); // "咚、咚。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan2", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(1895); // "……不，不会有错。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(1896); // "的确是敲门声。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(1897); // "不是说要等中午么，难道赫泽尔这么早就回来了？"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan5", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(1898); // "还是、难道说，果然有魔兽……"
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:3f);
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1>audio/sound/jiaobusheng_xin_kuai1.ogg");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/heilong_dating_duo_guan_baitian.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.55f, 1.14f)}, {"zoom", 0.78f}})});
            yield return _gameMethods.Transition(time:1f);
            yield return _gameMethods.OpenDialog(1899); // "我来到大厅，找了个角落躲好。"
            yield return _gameMethods.OpenDialog(1900); // "静观其变。"
            yield return _gameMethods.ExecuteCharacterImageData("nuo_weizhi");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_demo_2a0bf267.ogg");
            yield return _gameMethods.OpenDialog(1901); // "哎呀，没人在吗？"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan2", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(1902); // "！！"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan6", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(1903); // "年轻男人的声音……？"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1904); // "而且，说的是人类的通用语。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1905); // "灾厄之龙的城堡，怎么会出现其他人类（大概是人类）。"
            yield return _gameMethods.ExecuteCharacterImageData("nv", parts: new List<string>{"mei4", "yan6", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(1906); // "（难道预言中的勇者这么快就到了这里？）"
            yield return _gameMethods.OpenDialog(1907); // "我决定先按兵不动。"
            yield return _gameMethods.ExecuteCharacterImageData("nuo_weizhi");
            yield return _gameMethods.OpenDialog(1908); // "嗯——"
            yield return _gameMethods.OpenDialog(1909); // "那声音的主人似乎思考了片刻。"
            yield return _gameMethods.ExecuteCharacterImageData("nuo_weizhi");
            yield return _gameMethods.OpenDialog(1910); // "那，我就自己开门了。 "
            yield return _gameMethods.ExecuteCharacterImageData("nv", parts: new List<string>{"mei4", "yan5", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(1911); // "（……要来了。）"
            yield return _gameMethods.PlaySound("soundb", 0.0f, 0.7f, "audio/demo_audio/sound/heart1.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"xpos", 60f}})});
            yield return _gameMethods.OpenDialog(1912); // "我凝神屏气。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/door_open1.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 60f}})});
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/heilong_dating_duo_kai_baitian.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.55f, 1.14f)}, {"zoom", 0.78f}})});
            yield return _gameMethods.Transition(time:1f);
            yield return _gameMethods.OpenDialog(1913); // "那门从外部打开。"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<from 0 to 2>audio/sound/jiaobusheng_nuo_normal1.ogg");
            yield return _gameMethods.OpenDialog(1914); // "一个人影走了进来。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/zhenjing_shuaidaoganjue.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(60f, 0f)}, {"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.3f}, {"pos", new Vector2(318f, 80f)}, {"zpos", -414f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv");
            yield return _gameMethods.OpenDialog(1915); // "我连忙藏好。"
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:1f);
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(318f, 80f)}, {"zpos", -414f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_weizhi");
            yield return _gameMethods.OpenDialog(1916); // "居然对远道而来的客人这么冷淡。"
            yield return _gameMethods.ExecuteCharacterImageData("nuo_weizhi");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_demo_bf6627dc.ogg");
            yield return _gameMethods.OpenDialog(1917); // "真过分啊。"
            yield return _gameMethods.OpenDialog(1918); // "明明不会有人回应，但那人却十分自然地感慨着。"
            yield return _gameMethods.PlaySound("sounda", 3f, 2f, "<from 0 to 4>audio/sound/jiaobusheng_nuo_normal1.ogg");
            yield return _gameMethods.OpenDialog(1919); // "声音越来越近，似乎在朝我这个方向走来。"
            yield return _gameMethods.OpenDialog(1920); // "他不可能看得到我才对。偶然？"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 318f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.7f}, {"xpos", 468f}})});
            yield return _gameMethods.OpenDialog(1921); // "我缓缓移动脚步，打算随着他的移动，绕到柱子后与他相背的方向去。"
            yield return _gameMethods.PlaySound("sound", 0.4f, 1.0f, "audio/demo_audio/sound/moca2.mp3");
            yield return _gameMethods.Show("nuo1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.45f, 1.52f)}, {"zoom", 0.29f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 468f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan1", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(1922); // "男人却忽然探身到我面前。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 468f}, {"xoffset", 0f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.5f}, {"xpos", 84f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_weizhi");
            yield return _gameMethods.OpenDialog(1923); // "呀吼！"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui3"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 80f}, {"xpos", 84f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.5f}, {"ypos", -64f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_weizhi_qian");
            yield return _gameMethods.OpenDialog(1924); // "「你好呀，{nw}{w=0.001}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_weizhi_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_demo_1547b9a7.ogg");
            yield return _gameMethods.OpenDialog(1925); // "小妹妹~」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -64f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan1", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(1926); // "………"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan1", "zui2", "emoji2"});
            yield return _gameMethods.OpenDialog(1927); // "……你好。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1928); // "我僵硬片刻，才反应过来。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"zui7", "yan2"});
            yield return _gameMethods.OpenDialog(1929); // "调整表情，仿佛未曾刻意躲起来一般坦荡地回答。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19", "-emoji2"});
            yield return _gameMethods.OpenDialog(1930); // "真是令人印象深刻的登场方式呢，先生。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
            yield return _gameMethods.OpenDialog(1931); // "这个家伙，一开始就意识到了我的存在。"
            yield return _gameMethods.OpenDialog(1932); // "这是某种魔法的功能？"
            yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/demo_audio/music/time_syuanji.mp3");
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_weizhi");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_demo_3f612a79.ogg");
            yield return _gameMethods.OpenDialog(1933); // "谢谢称赞。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_weizhi_qian");
            yield return _gameMethods.OpenDialog(1934); // "「毕竟，{nw}{w=0.001}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_weizhi_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_demo_6352a605.ogg");
            yield return _gameMethods.OpenDialog(1935); // "我想给你留个好印象嘛。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(1936); // "{size=+10}留下了。绝佳的坏印象。{/size}"
            Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_weizhi_nv", parts: new List<string>{"mei3", "yan5", "zui8", "emoji2"});
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui14"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_weizhi_nv", parts: new List<string>{"mei7", "yan2", "zui7", "emoji2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_demo_2a2bf1c5.ogg");
            yield return _gameMethods.OpenDialog(1937); // "你就是尼德霍格抓来的那名人类公主？"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan2", "zui14", "-emoji2"});
            yield return _gameMethods.OpenDialog(1938); // "“人类”公主？"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan4", "zui15"});
            yield return _gameMethods.OpenDialog(1939); // "他是外族……？"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 2>audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_dating_men_baitian.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.55f, 0.81f)}, {"zoom", 0.46f}})});
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.47f, 1.33f)}, {"zoom", 0.24f}, {"anchor", new Vector2(0.5f, 1.0f)}})});
            yield return _gameMethods.TransitionBy("blink2");
            yield return _gameMethods.OpenDialog(1940); // "既然已经被发现，我若无其事地从柱子后钻了出来。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui20"});
            yield return _gameMethods.OpenDialog(1941); // "「是我。{nw}{w=0.3}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan17", "zui20"});
            yield return _gameMethods.OpenDialog(1942); // "真是受宠若惊，你好像了解我，但我还不认识你呢。」"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1.5>audio/sound/jiaobusheng_nuo_normal1.ogg");
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 1f}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 30.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_weizhi");
            yield return _gameMethods.OpenDialog(1943); // "诺伯拉·博尔吉亚。冰霜极地之龙。幸会。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan19", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 30.0f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/daoju/daoju_baimeigui.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"xpos", 0.55f}, {"zpos", 30f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.7f}, {"zoom", 0.38f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.7f}, {"ypos", 0.7f}, {"zoom", 0.5f}, {"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(1944); // "他顺手递来了一支白玫瑰。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/daoju/daoju_baimeigui.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(0.55f, 0.7f)}, {"zoom", 0.5f}, {"alpha", 1f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -64f}, {"zpos", -414f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.8f}, {"ypos", 2f}, {"zpos", -492f}})});
            yield return _gameMethods.OpenDialog(1945); // "翠绿的茎枝光洁，去掉了刺。……这条龙看起来对人类社会的文明礼仪了解不浅。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 2f}, {"zpos", -492f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/daoju/daoju_baimeigui.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.72f}, {"zoom", 0.5f}, {"alpha", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.8f}, {"ypos", 0.81f}, {"zoom", 0.57f}, {"alpha", 0.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui6"});
            yield return _gameMethods.OpenDialog(1946); // "我接过花，{nw}{w=0.4}"
            yield return _gameMethods.Hide("Assets/RenpyResources/images/daoju/daoju_baimeigui.png");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 2f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.31f}, {"ypos", -82f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan11", "zui6"});
            yield return _gameMethods.OpenDialog(1947); // "明快地微笑起来。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -82f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui20"});
            yield return _gameMethods.OpenDialog(1948); // "很高兴认识你。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1>audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -492f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.8f}, {"zpos", -516f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui19"});
            yield return _gameMethods.OpenDialog(1949); // "能介绍一下你的来意么，诺伯拉先生？"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -516f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui6"});
            yield return _gameMethods.OpenDialog(1950); // "按理来说，既然是龙，它……{nw}{w=0.4}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan4", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1951); // "算了、还是他吧，{nw}{w=0.2}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui7"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1953); // "应该是来拜访赫泽尔的。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1954); // "但如果是龙族，他也应该会清楚同族每年要回一趟龙之谷的习俗。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3"});
            yield return _gameMethods.OpenDialog(1955); // "怎么会恰恰碰巧就在这天过来？"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan20", "zui8"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nuo_qian");
            yield return _gameMethods.OpenDialog(1956); // "{nw}{w=0.4}"
            Engine._history = true;
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo");
            yield return _gameMethods.OpenDialog(1957); // "龙之谷在流传，说尼德霍格抓到了预言中那个人类公主。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo");
            yield return _gameMethods.OpenDialog(1958); // "我就跑来看热闹了。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui6", "emoji2"});
            yield return _gameMethods.OpenDialog(1959); // "……原来是看热闹的。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"yan24"});
            yield return _gameMethods.OpenDialog(1960); // "那你来得还挺快的，赫泽尔刚去龙之谷。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1961); // "听到消息后马不停蹄赶过来吃瓜是吗。"
            Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui8"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nuo_qian");
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo");
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan8", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(1926); // "………"
            yield return _gameMethods.EngineSetVolume(volume:0f, delay:4f, channelName:"music");
            yield return _gameMethods.PlaySound("soundb", 0.0f, 1.0f, "audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/zoulang_guodao1.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0f, 0f)}, {"pos", new Vector2(468f, 132f)}, {"zoom", 0.18f}})});
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            yield return _gameMethods.OpenDialog(1861); // "…………"
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:2f);
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/heilong_huiketing_quanjing_baitian.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0f, 0f)}, {"pos", new Vector2(468f, 126f)}, {"zoom", 0.28f}})});
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            yield return _gameMethods.OpenDialog(1962); // "既然是赫泽尔的相识，我将他带至了会客厅，{nw}{w=0.3}"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/daocha1.mp3");
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/heilong_huiketing_cahju_baitian.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0f, 0f)}, {"pos", new Vector2(438f, 108f)}, {"zoom", 0.44f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1");
            yield return _gameMethods.OpenDialog(1963); // "端上待客的红茶。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/heilong_huiketing_cahju_baitian.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(1861); // "…………"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg37_memory.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg37_memory.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/bg/heilong_huiketing_cahju_baitian.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/bg/heilong_huiketing_quanjing_baitian.jpg");
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/heilong_huiketing_shafa_baitian.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 0.97f)}, {"zoom", 0.95f}})});
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan20", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.21f)}, {"zoom", 0.21f}, {"anchor", new Vector2(0.5f, 1.0f)}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"xpos", 84f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -60f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.6f}, {"ypos", -82f}})});
            yield return _gameMethods.Transition(time:0.5f);
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui2"});
            yield return _gameMethods.OpenDialog(1964); // "「你来得很及时。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan11", "zui2"});
            yield return _gameMethods.OpenDialog(1965); // "希望我没有辜负你的期待。」"
            yield return _gameMethods.EngineSetVolume(volume:1f, delay:2f, channelName:"music");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(84f, -82f)}})});
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan19", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei7", "yan11", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice14_4536c36a.ogg");
            yield return _gameMethods.OpenDialog(1966); // "「…………{nw}{w=0.4}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(1967); // "嗯——  」"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(1968); // "他的目光轻飘飘地在我的周身扫过。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei6", "yan11", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(1969); // "「真可怜。{nw}{w=0.3}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei6", "yan11", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(1970); // "尼德霍格一定亏待你了。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei6", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan5", "zui6"});
            yield return _gameMethods.OpenDialog(1971); // "「……{nw}{w=0.3}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan11", "zui20"});
            yield return _gameMethods.OpenDialog(1972); // "为什么这么说呢？」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui6"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei7", "yan11", "zui7"});
            yield return _gameMethods.OpenDialog(1973); // "「你的头发缺乏光泽，{nw}{w=0.3}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan19", "zui4"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei7", "yan5", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_demo_3dbe2e1c.ogg");
            yield return _gameMethods.OpenDialog(1974); // "手部皮肤也变粗糙了，{nw}{w=0.3}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_demo_f1f62b3d.ogg");
            yield return _gameMethods.OpenDialog(1975); // "几乎像个平民。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.OpenDialog(1976); // "……这条龙是个名侦探。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui19"});
            yield return _gameMethods.OpenDialog(1977); // "你好像很了解人类。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(1978); // "我不动声色，面上露出欣赏和好奇。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei7", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(1979); // "「Bingo——。{nw}{w=0.3}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_demo_34f73153.ogg");
            yield return _gameMethods.OpenDialog(1980); // "在龙族里，我算是人类通。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui2"});
            yield return _gameMethods.OpenDialog(1981); // "你还玩过宾果游戏？"
            Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_demo_86b2de3d.ogg");
            yield return _gameMethods.OpenDialog(1982); // "算是吧，在贫民窟的酒馆里。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(1983); // "真令人敬佩。你一定去过很多地方。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "demo_audio/sound/tangxia3_duanduan.mp3");
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.7f}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 10.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.OpenDialog(1984); // "「我发现了。狡猾的小公主，{nw}{w=0.3}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_demo_ecb66d27.ogg");
            yield return _gameMethods.OpenDialog(1985); // "你该不会，在转移话题吧？」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui7"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 10.0f}})});
            yield return _gameMethods.OpenDialog(1986); // "……这么敏锐的么。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.OpenDialog(1987); // "这条龙有点难缠啊……"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan17", "zui19"});
            yield return _gameMethods.OpenDialog(1988); // "…也不是坏事啊，现在我更加了解到你的广博见识了。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei7", "yan17", "zui7"});
            yield return _gameMethods.OpenDialog(1989); // "「是呀，我见过的贵族女孩有不少，{nw}{w=0.3}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan19", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(1990); // "/n几乎头发都像丝绸，肌肤如同花瓣。{nw}{w=0.3}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_demo_f81848ea.ogg");
            yield return _gameMethods.OpenDialog(1991); // "你看起来很不同。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan5", "zui2"});
            yield return _gameMethods.OpenDialog(1992); // "「那你应该也会知道，高贵并不在于外表，{nw}{w=0.3}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui2"});
            yield return _gameMethods.OpenDialog(1993); // "/n而在于纯正的血脉、端正的行为，{nw}{w=0.3}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan17", "zui3"});
            yield return _gameMethods.OpenDialog(1994); // "与品格高尚的内心。」"
            Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(1995); // "其实高贵的是像我这样双手粗糙的劳动人民好吗。/n为了人民的未来而奋斗！"
            Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan4", "zui12"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1996); // "……但迫于这个世界的社会发展阶段，我说了违心的一番话。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei7", "yan5", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice14_a5641ef3.ogg");
            yield return _gameMethods.OpenDialog(1971); // "「……{nw}{w=0.3}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan20", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(1997); // "{nw}{w=0.7}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei8", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/demo_bai_over_29df3094.ogg");
            yield return _gameMethods.OpenDialog(1998); // "…………」"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(1999); // "再说了，无论多么高贵美丽的人，在你面前也会黯然失色的。"
            yield return _gameMethods.OpenDialog(2000); // "因为不想在此事上被深究下去，我转而开始夸他。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -516f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.4f}, {"zpos", -522f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui2"});
            yield return _gameMethods.OpenDialog(2001); // "你的眼睛比所有蓝宝石都更漂亮，远胜世上所有人。所以这不能怪我。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui3"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -522f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei7", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(2002); // "「呀——~最近的小妹妹可真会说话。{nw}{w=0.3}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(2003); // "你是要和我搞好关系吗？」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(2004); // "……？"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/moca1.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei4", "yan10", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(2005); // "冤枉！"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan11", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(2006); // "我是个正经公主，这只是诚实的赞美！"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan11", "zui8", "emoji2"});
            yield return _gameMethods.OpenDialog(2007); // "请你自重！"
            Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui5"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan11", "zui8", "emoji2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_demo_26d9e89c.ogg");
            yield return _gameMethods.OpenDialog(2008); // "王都中的贵妇和交际花从来都只是矜持端坐，等待骑士的追求和赞美呢。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui19", "-emoji2"});
            yield return _gameMethods.OpenDialog(2009); // "往常我也如此，但你让我感觉很特别，特别闪闪发光。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(2010); // "啊哈，你该不会经常出入社交场合吧？"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui19"});
            yield return _gameMethods.OpenDialog(2011); // "怎么会呢。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.OpenDialog(2012); // "这么了解贵妇和交际花，我看你是才差不多。"
            Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:4f);
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan3", "zui9"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(1956); // "{nw}{w=0.4}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei11", "yan2", "zui15"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei2", "yan2", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.OpenDialog(2013); // "哈哈哈——！"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei10", "yan2", "zui7"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(2014); // "有什么好笑的吗？"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_demo_17fe0e34.ogg");
            yield return _gameMethods.OpenDialog(2015); // "现在我相信你是一位公主了。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"ypos", -120f}, {"zpos", -594.0f}})});
            yield return _gameMethods.TransitionBy("blink2");
            yield return _gameMethods.PlaySound("music", 0.0f, 0.7f, "audio/demo_audio/music/disappearing painting.mp3");
            yield return _gameMethods.OpenDialog(2016); // "他微微眯起眼睛，审视着我，嘴角露出洞察一切般的笑意，纤长的白色睫毛犹如白粉蝶的翅膀一般，纷纷碰撞。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan14", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_demo_38a42a42.ogg");
            yield return _gameMethods.OpenDialog(2017); // "村姑与农夫处处畏缩怕事，生怕得罪了他们的领主，遭受灭顶之灾。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_demo_438901ca.ogg");
            yield return _gameMethods.OpenDialog(2018); // "而你，比我见过的其他贵族与公主都要更加骄傲，自由，富有尊严。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(2019); // "「你似乎完全不觉得自己低任何人一等，{nw}{w=0.3}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei10", "yan11", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_demo_abcee6ad.ogg");
            yield return _gameMethods.OpenDialog(2020); // "并且，还很狡猾呢。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei10", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.OpenDialog(2021); // "现在，我已经完全确定了。"
            yield return _gameMethods.OpenDialog(2022); // "这条龙对人类社会的了解和认知比我预想中还要深入很多。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei10", "yan20", "zui8"});
            yield return _gameMethods.OpenDialog(2023); // "并且，和居家读书派的赫泽尔不同，他恐怕积累了不少与人类直接相处的实践经验。"
            yield return _gameMethods.OpenDialog(2024); // "如果他是赫泽尔的朋友，我要小心再小心了。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei10", "yan19", "zui8"});
            yield return _gameMethods.OpenDialog(2025); // "不能在他面前泄露出任何一丝消极的真实想法，不能露出马脚……"
            yield return _gameMethods.OpenDialog(2026); // "假若他告诉了赫泽尔，对我就太不利了。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei10", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(2027); // "真正狡猾的人是不会让人察觉的。/n比起这个词，通常人们会评价我很好相处。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei10", "yan7", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan11", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_demo_8f2561a1.ogg");
            yield return _gameMethods.OpenDialog(2028); // "……嗯，我已经感受到了。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui14"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_demo_1bdebbe5.ogg");
            yield return _gameMethods.OpenDialog(2029); // "小公主，你的名字叫什么？"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui2"});
            yield return _gameMethods.OpenDialog(2030); // "[persistent.povname]。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
            if (Defaults.Persistent.Povname=="辛西娅")
            {
                                yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan5", "zui7"});
                yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_demo_a88d86a3.ogg");
                yield return _gameMethods.OpenDialog(2031); // "比我认识的其他“辛西娅”们更适合这个名字。"

            }
            else
            {
                                yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan5", "zui7"});
                yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_demo_96584e5a.ogg");
                yield return _gameMethods.OpenDialog(2032); // "比我认识的其他“[persistent.povname]”们更适合这个名字。"

            }
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan24", "zui2", "emoji2"});
            yield return _gameMethods.OpenDialog(2033); // "哈哈，我的荣幸……"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan24", "zui8", "emoji2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_demo_12e7ea20.ogg");
            yield return _gameMethods.OpenDialog(2034); // "真有趣。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan20", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan2", "zui14", "-emoji2"});
            yield return _gameMethods.OpenDialog(2035); // "有一段时间没碰到这么合胃口的人类了。/n我说不定会喜欢你很久的。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.OpenDialog(2036); // "可惜你是尼德霍格的收藏，不然就可以把你带回我的巢穴了。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2037); // "我礼貌地微笑回答。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(2038); // "可龙族不是只喜欢亮晶晶的东西吗？"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -80f}, {"zpos", -516.0f}})});
            yield return _gameMethods.TransitionBy("blink2");
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan12", "zui19", "-emoji2"});
            yield return _gameMethods.OpenDialog(2039); // "我的皮肤这么粗糙，头发也没有光泽。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui8"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan12", "zui8"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_demo_c8b5399f.ogg");
            yield return _gameMethods.OpenDialog(2040); // "你就是亮晶晶的呀。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(2041); // "毕竟光芒不在于外表，而来自于端正的行为与内心的品格嘛。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_demo_82aefc4e.ogg");
            yield return _gameMethods.OpenDialog(2042); // "而且，我可不会像尼德霍格这样冷落你。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(2043); // "「我会极尽珍品地滋养、浇灌你，{nw}{w=0.3}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(2044); // "把你养成一朵最娇艳的白玫瑰。」"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan24", "zui7"});
            yield return _gameMethods.OpenDialog(2045); // "看不出你还是位园艺爱好者啊。"
            Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2046); // "不过，这也只是在受人看管与温室花朵之间做一个选择而已。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2047); // "虽然后面这个要好上一些，但终究是仰人鼻息地活着，{nw}{w=0.3}"
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:8f);
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui7"});
            yield return _gameMethods.OpenDialog(2048); // "/n说不定什么时候他厌倦了，就不管我了。"
            Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan20", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(1861); // "…………"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei8", "yan11", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_demo_cff12cf6.ogg");
            yield return _gameMethods.OpenDialog(2049); // "你想不想知道尼德霍格的弱点？"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei8", "yan11", "zui8"});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/zhenjing_shuaidaoganjue.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan2", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(2050); // "！"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan2", "zui15", "emoji2", "emoji12"});
            yield return _gameMethods.OpenDialog(2051); // "他还有弱点？"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei8", "yan14", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(2052); // "「嗯——{nw}{w=0.3}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei8", "yan2", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
            yield return _gameMethods.OpenDialog(2053); // "求我一下，我就告诉你？」"
            yield return _gameMethods.OpenSelectMenu(talk: new List<string>{"-羞涩、紧张，这怎么行", "-也不是不行", "-只要求一下吗"}, jump: new List<string>{"label_zhuxian_2_menu_0_7NleJsc6", "label_zhuxian_2_menu_0_J4c1Ux9W", "label_zhuxian_2_menu_0_WsM59agt"}, condition: new List<string>{"NONE", "NONE", "NONE"});
        }

        public IEnumerator label_choice9_1()
        {
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui18", "emeoji2"});
            yield return _gameMethods.OpenDialog(2093); // "——……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui18", "-emeoji2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice12_554c5b0b.ogg");
            yield return _gameMethods.OpenDialog(2094); // "嗯。"
            yield return _gameMethods.OpenSelectMenu(screen:"choice1", talk: new List<string>{"-(如果他知道我已经给赫泽尔梳过头了/n会是什么反应)"}, jump: new List<string>{"label_zhuxian_2_menu_0_qbHAuybv"}, condition: new List<string>{"NONE"});
        }

        public IEnumerator label_choice9()
        {
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/heilong_huiketing_men_baitian.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"ypos", 0.63f}, {"zoom", 0.37f}, {"xpos", 0.5f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", -48f}, {"zpos", -642.0f}, {"ypos", -84f}})});
            yield return _gameMethods.Hide("nuo1");
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan3", "zui9"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.46f, 0.64f)}, {"zpos", 20.0f}, {"zoom", 0.07f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice9_54b7f146.ogg");
            yield return _gameMethods.OpenDialog(2115); // "博尔吉亚。"
            yield return _gameMethods.PlaySound("music", 0.0f, 0.7f, "audio/demo_audio/music/a dull dawn.mp3");
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(2116); // "赫泽尔回来了。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(2117); // "奇怪的是，见到诺伯拉，他的脸上并没有遇见朋友来拜访的愉快。"
            yield return _gameMethods.SetDialogUIShowOrHide("hide");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", -48f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.58f}, {"xpos", -12f}})});
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveType", "dissolve"}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 0.74f)}, {"zpos", 20.0f}, {"zoom", 0.1f}})});
            yield return _gameMethods.StopEngineTime(time:0.68f);
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", -12f}})});
            yield return _gameMethods.SetDialogUIShowOrHide("show");
            yield return _gameMethods.ExecuteCharacterImageData("nuo");
            yield return _gameMethods.OpenDialog(2118); // "哦，尼德霍格。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.5f, "<from 0 to 1.5>audio/demo_audio/sound/zu3_nv_zou_man.ogg");
            yield return _gameMethods.Hide("he");
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan27", "zui9"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"dissolveTime", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.46f, 0.66f)}, {"zpos", 30.0f}, {"zoom", 0.07f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice9_c5f39117.ogg");
            yield return _gameMethods.OpenDialog(2119); // "你怎么会在这里？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan27", "zui2"});
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo");
            yield return _gameMethods.OpenDialog(2120); // "我来看看你啊。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan9", "zui9"});
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice9_b5b6ead5.ogg");
            yield return _gameMethods.OpenDialog(2121); // "我不记得我们有任何交情。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan9", "zui2"});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.7>audio/sound/jiaobusheng_nuo_normal1.ogg");
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui13"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.5f}, {"zpos", 20.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"xpos", 0.505f}, {"zpos", 12.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_qian");
            yield return _gameMethods.OpenDialog(2122); // "「真不留情面呢。{nw}{w=0.3}"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_qian");
            yield return _gameMethods.OpenDialog(2123); // "好吧，我是为了被你藏起的小公主而来。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan9", "zui3", "emoji11"});
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.505f}, {"zpos", 12.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nuo");
            yield return _gameMethods.OpenDialog(2124); // "出人意料的聪明可爱，不是吗？"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan20", "zui8"});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan11", "zui3", "emoji11"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(-48f, -84f)}, {"zpos", -684.0f}})});
            yield return _gameMethods.TransitionBy("blink2");
            yield return _gameMethods.StopEngineTime(time:0.2f);
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan3", "zui2", "-emoji11"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan15", "zui15"});
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(2125); // "赫泽尔闻言向我看来。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan3", "zui2"});
            yield return _gameMethods.OpenDialog(2126); // "我们的目光在半空中触碰，"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan11", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2127); // "他像被什么烫了一下般，垂眸转开了目光。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan11", "zui2"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(-6f, -90f)}, {"zpos", -654.0f}})});
            yield return _gameMethods.TransitionBy("blink2");
            yield return _gameMethods.StopEngineTime(time:0.2f);
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan31", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(2128); // "既然看完，你该离开了。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan31", "zui2"});
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo");
            yield return _gameMethods.OpenDialog(2129); // "哎呀，看来主人不是很欢迎我呢。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"emoji2"});
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan31", "zui2", "emoji0"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(2130); // "我本能地察觉气氛不太对劲，还是谨慎为妙。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan24", "zui16", "emoji2"});
            yield return _gameMethods.OpenDialog(2131); // "悄悄噤声。"
            Engine._history = false;
            yield return _gameMethods.PlaySound("sound", 0.4f, 1.0f, "audio/demo_audio/sound/moca2.mp3");
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.505f}, {"zpos", 12.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"xpos", 0.5f}, {"zpos", 14.0f}})});
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
            yield return _gameMethods.OpenDialog(2132); // "诺伯拉却转头看向了我。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui13"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.5f}, {"zpos", 14.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei3", "yan2", "zui15", "emoji2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice9_e5c4313e.ogg");
            yield return _gameMethods.OpenDialog(2133); // "再见了，小公主。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
            yield return _gameMethods.OpenDialog(2134); // "期待与你下次相会。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan9", "zui3"});
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui7"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan5", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2135); // "正要对他尴尬而礼貌地微笑，赫泽尔却抢先一步开口。"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<from 0 to 1>audio/demo_audio/sound/zu3_nv_zou.ogg");
            yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan25", "zui12"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 30.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.27f}, {"zpos", 40.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_qian");
            yield return _gameMethods.OpenDialog(2136); // "「这种预期并不明智，{nw}{w=0.3}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan27", "zui9"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 40.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice9_fbcdad1f.ogg");
            yield return _gameMethods.OpenDialog(2137); // "你不如早点放弃，以免落空。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan27", "zui2"});
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo");
            yield return _gameMethods.OpenDialog(2138); // "哈哈~"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan20", "zui8"});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 3>audio/sound/jiaobusheng_nuo_normal1.ogg");
            yield return _gameMethods.Hide("nuo1");
            yield return _gameMethods.Transition(time:1f);
            yield return _gameMethods.OpenDialog(2139); // "诺伯拉笑了笑，似乎没太在意，便离开了。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan23", "zui2"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", -12f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.42f}, {"xpos", -48f}})});
            yield return _gameMethods.OpenDialog(2140); // "赫泽尔沉默无言。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan22", "zui2"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", -48f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/heilong_huiketing_cahju_baitian.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(468f, 204f)}, {"zoom", 0.21f}, {"zpos", 40f}})});
            yield return _gameMethods.TransitionBy("blink2");
            Defaults.Persistent.Jq_2_6 = 1;
            yield return _gameMethods.OpenDialog(2141); // "他的目光落在了我面前桌面的茶盏上。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan23", "zui2"});
            yield return _gameMethods.Hide("Assets/RenpyResources/images/bg/heilong_huiketing_cahju_baitian.jpg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -70f}})});
            yield return _gameMethods.Transition(time:0.6f);
            yield return _gameMethods.OpenDialog(2142); // "虽然面无波澜，我却感觉出他心情不太好。"
            yield return _gameMethods.ChangeLabelTo("label_demo_bai_over");
        }

        public IEnumerator label_demo_bai_over()
        {
            yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan9", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/demo_bai_over_3635de23.ogg");
            yield return _gameMethods.OpenDialog(2143); // "下次他再过来，你可以拒绝他。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan9", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(2144); // "啊。他很危险吗？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan22", "zui9", "emoji1"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(2145); // "…他没有伤害你的动机。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -70f}}), new SameLineParamData(new Dictionary<string, object>{{"bopInTimeWarp", 0.70f}, {"ypos", 2f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan22", "zui2", "emoji1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
            yield return _gameMethods.OpenDialog(2146); // "「那……"
            yield return _gameMethods.PlaySound("sound", 0.4f, 0.5f, "audio/demo_audio/sound/moca2.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"bopOutTimeWarp", 0.3f}, {"ypos", -76f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
            yield return _gameMethods.OpenDialog(2147); // "你讨厌他？」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan24", "zui9", "-emoji1", "emoji0"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -76f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/demo_bai_over_f673cb8b.ogg");
            yield return _gameMethods.OpenDialog(2148); // "你很在意他？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan24", "zui2", "emoji0"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -654.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.8f}, {"zpos", -660.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui10", "emoji2"});
            yield return _gameMethods.OpenDialog(2149); // "咦。不是，我只是有点奇怪。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -660.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(2150); // "你不是会无缘无故说出这种话的类型，是彼此之前有过节么？"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(2151); // "我谨慎地打探着他们两者之间的关系。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui7", "-emoji2"});
            yield return _gameMethods.OpenDialog(2152); // "只有掌握了诺伯拉的身份信息，才能更合理地调整我要采用的态度和策略。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan22", "zui9", "-emoji0"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/demo_bai_over_4a355f52.ogg");
            yield return _gameMethods.OpenDialog(2153); // "……不。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan22", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10", "emoji12"});
            yield return _gameMethods.OpenDialog(2154); // "那为什么不让他进来呢？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan15", "zui2", "emoji0"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui15", "-emoji12"});
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.OpenDialog(2155); // "他没有回答这个问题，却突然反问。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_qian");
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan16", "zui9", "-emoji0"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/demo_bai_over_4d50bdda.ogg");
            yield return _gameMethods.OpenDialog(2156); // "你为什么"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan16", "zui9", "emoji15", "emoji0"});
            yield return _gameMethods.Transition();
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/demo_bai_over_0a5a6f2b.ogg");
            yield return _gameMethods.OpenDialog(2157); // "要对他笑？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan16", "zui2", "emoji15", "emoji0"});
            yield return _gameMethods.OpenDialog(2158); // "这句话令我察觉到了些许异常。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"ypos", -88f}, {"zpos", -690.0f}})});
            yield return _gameMethods.TransitionBy("blink2");
            yield return _gameMethods.OpenDialog(2159); // "我抬头看向他的眼睛。"
            yield return _gameMethods.OpenDialog(2160); // "依然是那种平淡的样子。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan25", "zui2", "emoji16", "-emoji15"});
            Engine._history = false;
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan16", "zui2", "emoji15", "-emoji16", "emoji0"});
            yield return _gameMethods.OpenDialog(2161); // "他语无波澜，脸上也仍旧是那副淡漠的表情，平静的声音中却似乎隐含不满。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"ypos", -82f}, {"zpos", -660.0f}})});
            yield return _gameMethods.TransitionBy("blink2");
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan5", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2162); // "我一时间有点措手不及，弄不清他的态度与意图，进退不定。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.5>audio/demo_audio/sound/zu3_nv_zou.ogg");
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan25", "zui2", "emoji16", "-emoji15"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 40.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.30f}, {"zpos", 45.0f}})});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan16", "zui9", "emoji15", "emoji0", "-emoji16"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/demo_bai_over_5ec58478.ogg");
            yield return _gameMethods.OpenDialog(2163); // "你对他笑得很开心，就像和他认识了很久一样。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan16", "zui2", "emoji15", "emoji0"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 45.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(2164); // "赫泽尔向我走近。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.5>audio/demo_audio/sound/zu3_nv_zou.ogg");
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan17", "zui9", "emoji15", "-emoji0"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 45.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.30f}, {"zpos", 50.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei3", "yan2", "zui15", "-emoji2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/demo_bai_over_ff4cd679.ogg");
            yield return _gameMethods.OpenDialog(2165); // "「博尔吉亚善于同人类交往。{nw}{w=0.1}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan16", "zui9", "emoji15", "emoji0"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/demo_bai_over_feffa1ea.ogg");
            yield return _gameMethods.OpenDialog(2166); // "所以你也很喜欢他？」"
            yield return _gameMethods.PlaySound("sound", 0.0f, 2f, "<from 0 to 0.5>audio/demo_audio/sound/zu3_nv_zou.ogg");
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan25", "zui2", "emoji16", "-emoji15"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 50.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.30f}, {"zpos", 60.0f}})});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan19", "zui9", "-emoji16", "emoji15", "-emoji0"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/demo_bai_over_71155702.ogg");
            yield return _gameMethods.OpenDialog(2167); // "你对见到的每条龙、每个人都这样么。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan16", "zui9", "emoji15", "emoji0"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 60.0f}})});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei3", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei3", "yan2", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/demo_bai_over_76977d24.ogg");
            yield return _gameMethods.OpenDialog(2168); // "还是博尔吉亚格外讨你欢心？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan16", "zui2", "emoji15", "emoji0"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan9", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(2169); // "他看起来有些过于有压迫力了。/n莫可名状的恐惧令我浑身发冷。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(2170); // "我忍住后退的冲动。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19", "-emoji2"});
            yield return _gameMethods.OpenDialog(2171); // "……我以为他是你的朋友，所以应该友善地招待他，让他待得愉快。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan17", "zui21", "emoji15", "-emoji0"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan11", "zui7", "emoji2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/demo_bai_over_a1c71ac9.ogg");
            yield return _gameMethods.OpenDialog(2172); // "他不是。所以你没必要做这些。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan17", "zui21", "emoji2"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -82f}, {"blur", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"ypos", -58f}, {"blur", 3.83f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei1", "yan5", "zui19", "-emoji2"});
            yield return _gameMethods.OpenDialog(2173); // "「好吧。对不起，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei1", "yan9", "zui20"});
            yield return _gameMethods.OpenDialog(2174); // "我做了多余的事。」"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -58f}, {"blur", 3.83f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan17", "zui21", "-emoji2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_qian");
            yield return _gameMethods.OpenDialog(1971); // "「……{nw}{w=0.3}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan25", "zui2", "-emoji15", "emoji16"});
            yield return _gameMethods.ExecuteCharacterImageData("he_qian");
            yield return _gameMethods.OpenDialog(2175); // "……」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui9", "-emoji15", "-emoji16"});
            yield return _gameMethods.Transition();
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -58f}, {"blur", 3.83f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.38f}, {"ypos", -90f}, {"blur", 0.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(2176); // "你不需要道歉。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -90f}, {"blur", 0.0f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(2177); // "………？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan9", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(2178); // "「……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan23", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(2175); // "……」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2179); // "过了很久，他才再次开口。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei8", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei8", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(2180); // "…………这让我很不快。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan2", "zui10", "emoji12"});
            yield return _gameMethods.OpenDialog(2181); // "为什么？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan28", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei8", "yan2", "zui15", "-emoji12"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/demo_bai_over_5ea53ca6.ogg");
            yield return _gameMethods.OpenDialog(2182); // "「你是我带回来的。{nw}{w=0.1}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan22", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(2183); // "/n和你一起读书、睡觉的也是我，{nw}{w=0.1}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan15", "zui21", "emoji0"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/demo_bai_over_5a49ad36.ogg");
            yield return _gameMethods.OpenDialog(2184); // "并且，有我就够了。{nw}{w=0.1}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2", "-emoji0"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan27", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(2185); // "/n你不需要和其他龙接触。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan24", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(2186); // "……我大概明白了。龙都很有领地意识。"
            yield return _gameMethods.PlaySound("sound", 0.3f, 0.5f, "audio/demo_audio/sound/moca2.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -96f}, {"zpos", -672.0f}})});
            yield return _gameMethods.TransitionBy("blink2");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan2", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(2187); // "我微微低头，双目认真地注视着他的眼睛。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei4", "yan5", "zui10", "emoji2"});
            yield return _gameMethods.OpenDialog(2188); // "你吃醋了吗？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei4", "yan5", "zui15", "emoji2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/demo_bai_over_1d6f33ba.ogg");
            yield return _gameMethods.OpenDialog(2189); // "那是什么。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10", "-emoji2"});
            yield return _gameMethods.OpenDialog(2190); // "就是看到喜欢的人和别人关系好，嫉妒了。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei18", "yan10", "zui21"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/demo_bai_over_4b06097b.ogg");
            yield return _gameMethods.OpenDialog(2191); // "你是我的，我没必要嫉妒他。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.4f, "<from 0 to 0.5>audio/demo_audio/sound/zu3_nv_zou.ogg");
            yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan27", "zui9"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.66f}, {"zoom", 0.07000000000000006f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.33f}, {"ypos", 0.7f}, {"zoom", 0.08f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan10", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/demo_bai_over_285c30ae.ogg");
            yield return _gameMethods.OpenDialog(2192); // "你真的和他关系变好了？你们只认识了一个上午。"
            yield return _gameMethods.Show("menu", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.7f}, {"zoom", 0.08f}})});
            yield return _gameMethods.OpenDialog(2193); // "-没有，我下次可以不见他"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan27", "zui2"});
                yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan3", "zui11"});
                yield return _gameMethods.OpenDialog(2194); // "「如果你不喜欢，{nw}{w=0.1}"
                Defaults.Haogandu_he = Defaults.Haogandu_he + 2;
                yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui10"});
                yield return _gameMethods.OpenDialog(2195); // "那我下次就不见他了。」"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan3", "zui2"});
                yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
                yield return _gameMethods.OpenDialog(1860); // "……"
                yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19", "emoji10"});
                yield return _gameMethods.OpenDialog(2196); // "以你为准啦。"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan29", "zui2"});
                yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan2", "zui6", "-emoji10"});
                yield return _gameMethods.OpenDialog(2178); // "「……"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan15", "zui3"});
                yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
                yield return _gameMethods.OpenDialog(2175); // "……」"
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
                yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
                yield return _gameMethods.OpenDialog(2197); // "出乎我意料的是，赫泽尔并没有马上露出满意的神色。"
                yield return _gameMethods.OpenDialog(2198); // "这个孩子垂下眼眸，有些烦躁般地皱起细细的双眉。"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei18", "yan25", "zui2", "-emoji0"});
                yield return _gameMethods.ExecuteCharacterImageData("he_qian");
                yield return _gameMethods.OpenDialog(2178); // "「……"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan15", "zui9", "emoji0"});
                yield return _gameMethods.ExecuteCharacterImageData("he_qian");
                yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/demo_bai_over_7453a950.ogg");
                yield return _gameMethods.OpenDialog(2199); // "……为什么你要这么做。我并没有在强迫你。」"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan15", "zui2", "-emoji0"});
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan24", "zui16", "emoji2"});
                yield return _gameMethods.OpenDialog(2200); // "因为你是我的顶头上级。"
                yield return _gameMethods.StopSound(channelName:"music", fadeOut:5f);
                yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui20", "-emoji2"});
                yield return _gameMethods.OpenDialog(2201); // "「因为我更喜欢你，赫泽尔，{nw}{w=0.1}"
                yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui19"});
                yield return _gameMethods.OpenDialog(2202); // "你对我是最重要的。」"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan29", "zui2"});
                Defaults.Haogandu_he = Defaults.Haogandu_he + 3;
                yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan17", "zui4"});
                yield return _gameMethods.OpenDialog(2203); // "所以如果你不喜欢，我就不会做这件事。"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan2", "zui2"});
                yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan17", "zui7"});
                yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/demo_bai_over_edf0dd87.ogg");
                yield return _gameMethods.OpenDialog(2204); // "「…"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan25", "zui2"});
                yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
                yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei8", "yan2", "zui2"});
                yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
                yield return _gameMethods.OpenDialog(2096); // "…"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui3", "emoji5"});
                yield return _gameMethods.PlaySound("music1", 0.0f, 0.6f, "audio/music/wenxin/wind1.mp3");
                yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
                yield return _gameMethods.OpenDialog(1998); // "…………」"
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"ypos", -84f}, {"zpos", -648.0f}})});
                yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2", "emoji5"});
                yield return _gameMethods.TransitionBy("blink2");
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
                yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
                yield return _gameMethods.OpenDialog(2205); // "他不说话了。"
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
                yield return _gameMethods.OpenDialog(2206); // "过了良久，他闷闷地说。"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2", "-emoji5"});
                Engine._history = false;
                yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
                yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
                Engine._history = true;
                yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui9"});
                yield return _gameMethods.ExecuteCharacterImageData("he_nv");
                yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/demo_bai_over_d4f01f55.ogg");
                yield return _gameMethods.OpenDialog(2207); // "现在，你身上全都是博尔吉亚的味道。我不喜欢。"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2"});
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan10", "zui19", "emoji2"});
                yield return _gameMethods.OpenDialog(2208); // "你这是什么狗鼻子啊。"
                yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.5>audio/sound/jiaobusheng_xin_normal1.ogg");
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -648.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.22f}, {"zpos", -655.0f}})});
                yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui3", "-emoji2"});
                yield return _gameMethods.OpenDialog(2209); // "那，就把我重新沾满你的味道吧。"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan9", "zui2"});
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -655.0f}})});
                yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
                yield return _gameMethods.OpenDialog(2210); // "该怎么做呢，一个拥抱可以吗？"
                yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan23", "zui2"});
                Engine._history = false;
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui7"});
                yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
                Engine._history = true;
                yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui6"});
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
                yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
                Engine._history = true;
                yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
                yield return _gameMethods.OpenDialog(2211); // "他点点头，站在原地，稍稍抬起下巴，有点矜持似的等待着。"
                yield return _gameMethods.PlaySound("sound", 0.0f, 0.5f, "audio/demo_audio/sound/tangxia2_duan.mp3");
                yield return _gameMethods.Scene("cg_layered_tiantian", parts: new List<string>{"tiantian_dada"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.68f}, {"xalign", 0.5f}, {"yalign", 0.5f}})});
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(-360f, -90f)}, {"zpos", -522.0f}})});
                Defaults.Gui_duihuakuang_you = 0;
                yield return _gameMethods.Show("_zoom");
                yield return _gameMethods.Hide("_zoom");
                yield return _gameMethods.Transition(time:1.5f);
                yield return _gameMethods.OpenDialog(2212); // "我笑着抱住了他，紧紧地。"
                yield return _gameMethods.Show("cg_layered_tiantian", parts: new List<string>{"zhong_qian"});
                yield return _gameMethods.Transition(time:0.3f);
                yield return _gameMethods.OpenDialog(2213); // "他有些发硬的黑色卷发擦着我的脖颈，有些痒。"
                yield return _gameMethods.OpenDialog(2214); // "真难想象，在我这一生中，竟然会有机会和龙如此亲密地拥抱。"
                yield return _gameMethods.StopSound(channelName:"music1", fadeOut:8f);
                yield return _gameMethods.OpenDialog(2215); // "看起来，我似乎得到了他的信任。怎么说呢，有点令人受宠若惊。"
                yield return _gameMethods.OpenDialog(2216); // "皮肤的亲密接触给了我一种淡薄的安全感。"
                yield return _gameMethods.Show("cg_layered_tiantian", parts: new List<string>{"zhong_you"});
                yield return _gameMethods.StopEngineTime(time:0.8f);
                yield return _gameMethods.Show("cg_layered_tiantian", parts: new List<string>{"weimi_you"});
                yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice12_7defadbb.ogg");
                yield return _gameMethods.OpenDialog(1861); // "…………"
            yield return _gameMethods.ChangeLabelTo("label_choice12");
        }

        public IEnumerator label_choice12()
        {
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:8f);
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_shufang_baitian_quanjing.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.06f)}, {"zoom", 1.29f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            yield return _gameMethods.OpenDialog(1861); // "…………"
            yield return _gameMethods.PlaySound("soundb", 1f, 0.7f, "audio/demo_audio/sound/chanming.ogg");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_shufang_bangwan_quanjing.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.06f)}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}, {"zoom", 1.29f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(2217); // "之后，我们读了一下午的书。"
            yield return _gameMethods.PlaySound("soundc", 2f, 1.0f, "audio/demo_audio/sound/chong1.ogg");
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:4f);
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_shufang_bangwan_quanjing.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}, {"zoom", 1.29f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/heilong_shufang_yewankai_quanjing.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.06f)}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}, {"zoom", 1.29f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(2218); // "夜幕降临，我一如往常地和赫泽尔道了晚安，就打算回自己房间。"
            yield return _gameMethods.Show("heilong_shufang_yewankai_quanjing", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}, {"zoom", 1.29f}, {"blur", 1f}})});
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_shufang_baitian_quanjing.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_shufang_bangwan_quanjing.jpg");
            yield return _gameMethods.Show("he", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0f, 0f)}, {"pos", new Vector2(402f, 72f)}, {"zoom", 0.36f}})});
            yield return _gameMethods.Transition(time:0.6f);
            Defaults.Persistent.Jq_2_7 = 1;
            yield return _gameMethods.OpenDialog(2219); // "赫泽尔却一动不动，站在原地。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_qian");
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(2220); // "你说晚上会和我一起睡。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.OpenDialog(2221); // "他盯着我。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan24", "zui16", "emoji2"});
            yield return _gameMethods.OpenDialog(2222); // "……那其实只是一个比方。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(2223); // "没想到他真的记住了啊。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui15"});
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2224); // "不过，一起睡就一起睡吧。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(2225); // "虽然压力有点大，但和他多联络感情，对我的确也有好处。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.7>audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.6f}, {"zpos", -78.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(2226); // "「好呀，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui19"});
            yield return _gameMethods.OpenDialog(2227); // "等我回去拿一下枕头。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -78.0f}})});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan12", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice12_7c1062fb.ogg");
            yield return _gameMethods.OpenDialog(2094); // "嗯。"
            yield return _gameMethods.StopSound(channelName:"soundc", fadeOut:2f);
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(1861); // "…………"
            yield return _gameMethods.PlaySound("music", 3f, 0.8f, "audio/demo_audio/music/richang1.mp3");
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 2>audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/woshi_he1_sky.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.45f, 1.21f)}, {"zoom", 0.51f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/woshi_he1.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.45f, 1.21f)}, {"zoom", 0.51f}})});
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(2228); // "抱着枕头，我再次来到他的房间。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui7"});
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(0f, 0f)}, {"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.7f}, {"pos", new Vector2(-384f, 132f)}, {"zpos", -282.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2229); // "经过一番收拾，{nw}{w=0.1}"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/emeng_dajie/Lying Bed_01.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(2230); // "我们一起躺上了软软的床。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(2231); // "总感觉今天发生了好多事……"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-384f, 132f)}, {"zpos", -282.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(2232); // "我应该算是安全过关了……{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan21", "zui15", "emoji2", "emoji6"});
            yield return _gameMethods.OpenDialog(2233); // "但实在是太惊险了，心情好疲惫。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui7", "emoji2", "emoji6"});
            yield return _gameMethods.OpenDialog(2234); // "稍微聊几句就睡觉吧。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15", "-emoji2", "-emoji6"});
            yield return _gameMethods.OpenDialog(2235); // "找个什么话题好呢。"
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_portrait/he/he_zui4.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.28f, 1.73f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.9f}})});
            Defaults.Gui_duihuakuang_you = 0;
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition(time:0.6f);
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice14_2a8fb167.ogg");
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.OpenDialog(2236); // "今天的赫泽尔好像格外沉默。"
            yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"emoji1", "he_zui3"});
            yield return _gameMethods.Transition();
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(2237); // "…………？"
            yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"he_mei1"});
            yield return _gameMethods.OpenDialog(2238); // "是错觉吗。"
            yield return _gameMethods.OpenDialog(2239); // "怎么感觉，他的表情似乎有些不对劲。"
            yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"he_yan2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_pangbai");
            yield return _gameMethods.OpenDialog(2240); // "……这是、痛苦……的神色，吗？"
            yield return _gameMethods.OpenDialog(2241); // "我第一次在他脸上看到类似的表情。"
            yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"nv_zui2", "nv_mei2"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-240f, 66f)}, {"zpos", 276.0f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(2242); // "赫泽尔……你怎么了？"
            yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"nv_zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("he_pangbai");
            yield return _gameMethods.OpenDialog(2243); // "我目不转睛地盯着他的脸，仔细观察。"
            yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"he_yan7"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice12_bb7c1c06.ogg");
            yield return _gameMethods.OpenDialog(2244); // "……没什么。"
            yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"he_zui1", "nv_zui2", "nv_yan2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(2245); // "不可能。你和平时有些不一样。"
            yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"nv_zui1", "nv_mei1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(2246); // "这一年来，我们每天都在一起，我已经成为研究赫泽尔的专家了。"
            yield return _gameMethods.OpenDialog(2247); // "我恐吓他道。"
            yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"nv_yan4", "nv_zui2"});
            Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(2248); // "如果不告诉我的话，我就要一直缠着你了。"
            yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"nv_zui1", "he_yan4"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_qian");
            yield return _gameMethods.OpenDialog(2249); // "{nw}{w=0.5}"
            Engine._history = true;
            yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"he_yan8"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(1861); // "…………"
            yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"he_zui2", "nv_yan1"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(2250); // "龙之泉的泉水有活跃元素、促进魔力循环与骨骼生长的作用。"
            yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"he_yan7"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(2251); // "每年的这一晚，我体内残留的少许神圣血脉都会变得活跃，同本身的黑暗血脉产生冲突。"
            yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"he_zui4"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(2252); // "…………这样吗。"
            yield return _gameMethods.OpenDialog(2253); // "被神圣之龙所诞下的黑暗之龙吗。"
            yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"he_zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice12_c717f035.ogg");
            yield return _gameMethods.OpenDialog(2254); // "这没什么。"
            yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"he_yan5"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice12_cbd95688.ogg");
            yield return _gameMethods.OpenDialog(2255); // "等我进入成长期，最晚成年期，这种情况就会消失了。"
            yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"he_zui4", "nv_zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(2256); // "这样呀。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-264f, 222f)}, {"zpos", 606.0f}})});
            yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"ditu2", "nv_zui2"});
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/manbu/Body1_01.mp3");
            yield return _gameMethods.Transition(time:1f);
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(2257); // "……那、现在，如果很痛的话，你可以掐我，把痛转移到我身上。"
            yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"he_yan4", "nv_zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"nv_yan2", "nv_zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(2258); // "…当然，注意一点，别太用力就好了。"
            yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"nv_yan5", "gaoguang_bi"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(2259); // "我只有一个，你要有点轻重哦。"
            yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"he_yan5"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_qian");
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"he_yan7", "he_zui2", "nv_yan1", "nv_zui3", "gaoguang_zheng"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice12_03fd9e9c.ogg");
            yield return _gameMethods.OpenDialog(2260); // "这没有用，痛苦不可能转移。"
            yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"he_zui5"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"nv_mei3", "nv_yan3", "nv_zui3"});
            yield return _gameMethods.OpenDialog(2261); // "……果然是龙，非要如此坚定又自强不息吗。"
            yield return _gameMethods.OpenSelectMenu(talk: new List<string>{"-无法反驳", "-重在心意嘛", "-至少我可以陪你痛苦"}, jump: new List<string>{"label_zhuxian_2_menu_0_d83B0eum", "label_zhuxian_2_menu_0_1RxNDrMG", "label_zhuxian_2_menu_0_674EM6c8"}, condition: new List<string>{"NONE", "NONE", "NONE"});
        }

        public IEnumerator label_choice13()
        {
            yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"he_zui5"});
            yield return _gameMethods.OpenDialog(1861); // "…………"
            yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"he_zui5", "he_yan5", "he_mei1"});
            yield return _gameMethods.OpenDialog(2270); // "沉默了一会儿，他抬眸看我，表情寡淡。"
            yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"he_zui2", "nv_mei1", "nv_yan1", "nv_zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice13_070fc939.ogg");
            yield return _gameMethods.OpenDialog(2271); // "你的嘴巴味道是不是甜的？"
            yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"he_zui4", "nv_yan3"});
            yield return _gameMethods.OpenDialog(2272); // "好微妙的问题。"
            yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"nv_yan1", "nv_zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(2273); // "为什么这么问？"
            yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"he_zui2", "nv_zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(2274); // "因为你说的话都很甜蜜。"
            yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"he_zui4", "nv_zui5"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(2275); // "其实这些话是大脑想出来的，和嘴巴没有关系。"
            yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"he_zui2", "he_yan6", "-emoji1", "nv_zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice13_a062981c.ogg");
            yield return _gameMethods.OpenDialog(2276); // "那么，你的大脑也是甜的。"
            yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"he_yan4"});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(2277); // "你从头到脚，应该都是甜的。"
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:8f);
            yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"he_zui4", "nv_mei2", "nv_yan3", "nv_zui5"});
            yield return _gameMethods.OpenDialog(2278); // "{size=+10}这话从头到尾，听着都好夸张。{/size}"
            yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"nv_yan4", "nv_zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(2279); // "你说的话好夸张。"
            yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"he_yan5"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(18f, 0f)}, {"zpos", -30.0f}})});
            yield return _gameMethods.TransitionBy("blink2");
            yield return _gameMethods.OpenDialog(2280); // "他嗅着空气。"
            yield return _gameMethods.Show("cg_layered_sleep2", parts: new List<string>{"he_mei1", "he_yan6", "he_zui5", "nv_zui1"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -30.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"zpos", -90.0f}})});
            yield return _gameMethods.OpenDialog(2281); // "距离太近了，他的呼吸声隐隐约约，让我有些不自在。"
            yield return _gameMethods.PlaySound("soundb", 0.0f, 1.0f, "audio/demo_audio/sound/xintiao.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -90.0f}})});
            yield return _gameMethods.OpenDialog(2282); // "好奇怪。这个氛围总感觉有点不适应。"
            yield return _gameMethods.OpenDialog(2283); // "好怕我下一秒就会忍不住打个喷嚏。"
            yield return _gameMethods.OpenSelectMenu(talk: new List<string>{"-一动不动", "-退缩，拉开距离", "-拥抱他"}, jump: new List<string>{"label_zhuxian_2_menu_0_kgO1KOyt", "label_zhuxian_2_menu_0_Ra6CWrbb", "label_zhuxian_2_menu_0_SEwBwSFp"}, condition: new List<string>{"NONE", "NONE", "NONE"});
        }

        public IEnumerator label_choice14()
        {
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition(time:0.8f);
            yield return _gameMethods.OpenDialog(2309); // "之后，我们又聊了会天。"
            yield return _gameMethods.OpenDialog(2310); // "渐渐地，一起沉入了梦乡。"
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:5f);
            yield return _gameMethods.OpenDialog(2311); // "昏昏沉沉间，我做起了梦。"
            yield return _gameMethods.PlaySound("soundb", 0.0f, 1.0f, "audio/demo_audio/sound/niaoming.ogg");
            yield return _gameMethods.OpenDialog(1861); // "…………"
            yield return _gameMethods.OpenDialog(2312); // "意识复苏时，先听到的是鸟鸣。"
            yield return _gameMethods.Scene("sleep2_layered", parts: new List<string>{"zui4", "emoji1", "emoji2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.78f, 1.72f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.92f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 2f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.16f, saturationMatrix:1.02f, brightnessMatrix:-0.06f, hueMatrix:0.0f)}})});
            yield return _gameMethods.Show("_zoom");
            yield return _gameMethods.Hide("_zoom");
            yield return _gameMethods.TransitionBy("blink3");
            yield return _gameMethods.OpenDialog(2313); // "朦胧的图景涌入视野。"
            yield return _gameMethods.Show("sleep2_layered", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"blur", 0f}})});
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:2f);
            yield return _gameMethods.PlaySound("soundc", 3f, 1.0f, "audio/demo_audio/sound/xintiao.ogg");
            yield return _gameMethods.OpenDialog(2314); // "一双宛若属于爬行动物般的血色双瞳近在咫尺，正一眨不眨地紧紧盯住我。"
            yield return _gameMethods.OpenDialog(2315); // "专注。直勾勾。缺乏温度、情绪与人性。"
            yield return _gameMethods.OpenDialog(2316); // "仿佛它已经这样屏息在暗处伏击许久，只等我露出破绽，就控制住我。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/emeng_dajie/Magic Spell Book Pages Flipping_01.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei5", "yan1", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(2317); // "——！！"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
            yield return _gameMethods.OpenDialog(2318); // "那一瞬间，一种近乎于原始本能的惊悚、以及被掠食者盯住的恐慌，令我瞬时毛发直竖。"
            yield return _gameMethods.OpenDialog(2319); // "像任何不堪一击的弱者一样，陷入到僵硬状态。"
            yield return _gameMethods.StopSound(channelName:"soundc", fadeOut:1f);
            yield return _gameMethods.Show("sleep2_layered", parts: new List<string>{"-emoji1", "-emoji2"});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/emeng_dajie/Body_up_01.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"matrixcolor", new Matrixcolor(invertMatrix:0.0f, contrastMatrix:1.0f, saturationMatrix:1.0f, brightnessMatrix:0.0f, hueMatrix:0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(378f, 198f)}, {"zpos", 654f}})});
            yield return _gameMethods.Transition(time:0.5f);
            yield return _gameMethods.OpenDialog(2320); // "应激了两秒，我才意识到对方有着人的外形。"
            yield return _gameMethods.OpenDialog(2321); // "一个男孩……"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan12", "zui12", "-emoji2"});
            yield return _gameMethods.OpenDialog(2322); // "……………………赫泽尔。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(2323); // "「你这样大清早盯着别人，"
            yield return _gameMethods.PlaySound("music", 0.0f, 0.6f, "audio/demo_audio/music/qingkuai5.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei4", "yan10", "zui19", "emoji2", "emoji11"});
            yield return _gameMethods.OpenDialog(2324); // "{size=+10}好吓人啊。{/size}」"
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei4", "yan10", "zui7", "emoji2", "emoji11"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice14_9f98c18c.ogg");
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.Show("sleep2_layered", parts: new List<string>{"yan6", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice14_db3f343b.ogg");
            yield return _gameMethods.OpenDialog(2325); // "……我没想到你会突然醒来。"
            yield return _gameMethods.Show("sleep2_layered", parts: new List<string>{"zui4", "yan11"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan2", "zui15", "-emoji2", "-emoji11"});
            yield return _gameMethods.OpenDialog(2326); // "……什么意思。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(2327); // "「不是、大哥，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(2328); // "在别人睡着的时候盯着人家看，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan10", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(2329); // "也很吓人好么……」"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan6", "zui15", "-emoji2", "emoji12"});
            yield return _gameMethods.OpenDialog(2330); // "话说，他究竟是什么时候醒的？"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan11", "zui19", "emoji2", "-emoji12"});
            yield return _gameMethods.OpenDialog(2331); // "「哈哈……{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan1", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(2332); // "你醒的好早啊。」"
            yield return _gameMethods.Show("sleep2_layered", parts: new List<string>{"mei2", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui7", "-emoji2"});
            yield return _gameMethods.OpenDialog(2333); // "嗯，龙族不需要过于固定的睡眠。"
            yield return _gameMethods.Show("sleep2_layered", parts: new List<string>{"zui4"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10", "emoji12"});
            yield return _gameMethods.OpenDialog(2334); // "咦，什么意思？"
            yield return _gameMethods.ExecuteCharacterImageData("nv1");
            yield return _gameMethods.OpenDialog(2335); // "你晚上不用睡觉吗？"
            yield return _gameMethods.Show("sleep2_layered", parts: new List<string>{"yan6", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui15", "-emoji12"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice14_6d7d1fcc.ogg");
            yield return _gameMethods.OpenDialog(2336); // "在遇到你前，我刚结束一场长达四十年的睡眠。"
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice14_d41e261b.ogg");
            yield return _gameMethods.OpenDialog(2337); // "所以，至少二三十年内，如果我不想，就无需再入睡。"
            yield return _gameMethods.Show("sleep2_layered", parts: new List<string>{"zui4"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan6", "zui15", "emoji3"});
            yield return _gameMethods.OpenDialog(2338); // "……？？"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei4", "yan2", "zui19", "emoji2", "emoji3"});
            yield return _gameMethods.OpenDialog(2339); // "等等，那夜晚该睡觉的时候，你是在……？"
            yield return _gameMethods.Show("sleep2_layered", parts: new List<string>{"zui2", "mei1"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei4", "yan2", "zui8", "emoji2", "-emoji3"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice14_3933faa7.ogg");
            yield return _gameMethods.OpenDialog(2340); // "只是“如果不想”。"
            yield return _gameMethods.Show("sleep2_layered", parts: new List<string>{"zui4"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui10", "emoji2"});
            yield return _gameMethods.OpenDialog(2341); // "哦，就是说如果想睡还是会睡的。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(2342); // "有点像是银行，没事的时候储存睡眠，有需要时取出时间。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan24", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(2343); // "好羡慕。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10", "-emoji2"});
            yield return _gameMethods.OpenDialog(2344); // "那，你为什么要盯着我看呢？"
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(1861); // "…………"
            yield return _gameMethods.Show("sleep2_layered", parts: new List<string>{"yan9"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1861); // "…………"
            yield return _gameMethods.Show("sleep2_layered", parts: new List<string>{"zui2", "yan11"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(2345); // "看不到你的时候，我就无法确认你是不是还在这里。"
            yield return _gameMethods.Show("sleep2_layered", parts: new List<string>{"zui5"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan5", "zui15", "emoji2", "emoji16"});
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan18", "zui16", "emoji2", "emoji16"});
            yield return _gameMethods.OpenDialog(2346); // "不是吧，难道我想逃跑的念头被他察觉到了？"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui15", "emoji2", "-emoji16"});
            yield return _gameMethods.OpenDialog(2347); // "但他看起来好像挺平静的，没有要审问或惩罚我的意思。应该没有明确的证据。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(2348); // "我连忙表忠心。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei4", "yan2", "zui19", "-emoji2", "emoji7"});
            yield return _gameMethods.OpenDialog(2349); // "怎么会呢？我一直都在你身边啊。"
            yield return _gameMethods.Show("sleep2_layered", parts: new List<string>{"mei1", "yan1", "zui4"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 654.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.23f}, {"zpos", 582.0f}})});
            Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei4", "yan17", "zui2", "emoji9", "emoji7"});
            yield return _gameMethods.OpenDialog(2350); // "我对赫泽尔大人的心意天地可鉴！"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 582.0f}})});
            yield return _gameMethods.Show("sleep2_layered", parts: new List<string>{"yan2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei4", "yan17", "zui7", "emoji9", "emoji7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice14_c05f5029.ogg");
            yield return _gameMethods.OpenDialog(2351); // "……嗯。"
            yield return _gameMethods.Show("sleep2_layered", parts: new List<string>{"yan1", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice14_b77a65e0.ogg");
            yield return _gameMethods.OpenDialog(2352); // "看起来你做了个美梦。你一直在微笑，你梦到了什么？"
            yield return _gameMethods.Show("sleep2_layered", parts: new List<string>{"zui4"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui10", "-emoji9", "-emoji7"});
            yield return _gameMethods.OpenDialog(2353); // "「啊、"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan8", "zui9"});
            yield return _gameMethods.OpenDialog(2354); // "我……」"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(2355); // "我梦到了什么呢？"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan21", "zui15"});
            yield return _gameMethods.OpenDialog(2356); // "好像是过去，妈妈还在时的往事。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2357); // "安德鲁、洛恩也在内。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(2358); // "还好这是个美梦，没有泄漏出什么不该暴露的消极情绪，让他窥察我的内心。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei1", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(2359); // "「我梦到了……"
            yield return _gameMethods.PlaySound("sound", 0.6f, 0.5f, "audio/demo_audio/sound/moca6_duan_duan.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 198f}, {"zpos", 582.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.25f}, {"ypos", 168f}, {"zpos", 540.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
            yield return _gameMethods.OpenDialog(2360); // "很多好吃的。」"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 168f}, {"zpos", 540.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan6", "zui15"});
            yield return _gameMethods.OpenDialog(2361); // "「因为吃不完了，我正打算把它们带走，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei2", "yan12", "zui19"});
            yield return _gameMethods.OpenDialog(2362); // "突然就醒了。」"
            yield return _gameMethods.Show("sleep2_layered", parts: new List<string>{"mei1", "yan5", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei2", "yan12", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice14_d4c07bcd.ogg");
            yield return _gameMethods.OpenDialog(2363); // "……是么。"
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/woshi_he2.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(1.13f, 1.9f)}, {"anchor", new Vector2(0.5f, 1.0f)}})});
            Defaults.Gui_duihuakuang_you = 1;
            yield return _gameMethods.Transition(time:0.5f);
            yield return _gameMethods.OpenDialog(1861); // "…………"
            yield return _gameMethods.OpenDialog(2364); // "总算结束了这段对话，成功起床。"
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:6f);
            yield return _gameMethods.OpenDialog(2365); // "………………"
            yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_shufang_baitian_quanjing1.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.07f)}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/shuben.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 250f}, {"xpos", 150f}})});
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            yield return _gameMethods.PlaySound("music1", 0.0f, 1.0f, "audio/demo_audio/music/qingkuai4.mp3");
            yield return _gameMethods.OpenDialog(2366); // "我一边读书，一边走起神来。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"blur", 2f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(2367); // "诺伯拉的能力，让我升起了些许危机感。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 2f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2368); // "无论如何，被一个无法信任的陌生存在随意闯入大脑，绝不是一件令人安心的事。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan21", "zui15"});
            yield return _gameMethods.OpenDialog(2369); // "有没有什么应对措施呢？"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(2370); // "干脆大脑什么也不想……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2371); // "我尝试练习起如何大脑空白地组织语言。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan9", "zui15"});
            yield return _gameMethods.OpenDialog(2372); // "让语言直接由肌肉传出，而不经过脑中枢，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(2373); // "就像没长脑子一样，做到真正的边想边说。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan10", "zui7"});
            yield return _gameMethods.OpenDialog(2374); // "保证诺伯拉不会比我的舌头提前太久得知我最后到底要说什么。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui7", "emoji7"});
            yield return _gameMethods.OpenDialog(2375); // "我把这项技能称为练习大脑封闭术。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei3", "yan12", "zui7", "emoji7"});
            yield return _gameMethods.OpenDialog(2178); // "「……"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei3", "yan12", "zui7", "-emoji7", "emoji2"});
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei3", "yan12", "zui7", "emoji2", "emoji16"});
            yield return _gameMethods.OpenDialog(2376); // "………………」"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 2f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.22f}, {"blur", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei1", "yan21", "zui16", "-emoji2", "-emoji16", "emoji17"});
            yield return _gameMethods.OpenDialog(2377); // "…………好难啊。"
            yield return _gameMethods.PlaySound("sound", 0.8f, 0.5f, "audio/demo_audio/sound/moca6_duan_duan.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/shuben.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 250f}, {"xpos", 150f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.5f}, {"ypos", 300f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan8", "zui16", "emoji17"});
            yield return _gameMethods.OpenDialog(2378); // "只能慢慢来了。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/shuben.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 300f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui15", "-emoji17"});
            yield return _gameMethods.OpenDialog(2379); // "话说，在这段时间里，我已经将人类的通用语掌握的差不多了，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(2380); // "独自一人读书也不再有什么障碍。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(2381); // "我开始遥想更高级的知识，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan21", "zui15"});
            yield return _gameMethods.OpenDialog(2382); // "……或者说，更强大的力量。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan18", "zui15"});
            yield return _gameMethods.OpenDialog(2383); // "也许，我该找个机会，学习真言。"
            yield return _gameMethods.EngineSetVolume(volume:0.5f, delay:2f, channelName:"music1");
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.OpenDialog(2384); // "眨眼之间，两个月过去。"
            yield return _gameMethods.EngineSetVolume(volume:1f, delay:2f, channelName:"music1");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/woshi_nv2.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.07f)}, {"zoom", 0.51f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(2385); // "在此期间，城堡的生活恢复了平静。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui15"});
            yield return _gameMethods.OpenDialog(2386); // "我的意思是说，那位意外访客没有再次上门。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15"});
            yield return _gameMethods.OpenDialog(2387); // "这其实让我有些许失落。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(2388); // "因为我已经走进了一个死局，境遇如一潭死水。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan68", "zui15"});
            yield return _gameMethods.OpenDialog(2389); // "「如果这时出现了一枚新的活棋，那么，无论他能不能帮到我，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan18", "zui15"});
            yield return _gameMethods.OpenDialog(2390); // "至少都是一个机会。」"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan15", "zui15"});
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui10"});
            yield return _gameMethods.OpenDialog(2391); // "不过，我能做的，只有调整心态，过完每一天。"
            yield return _gameMethods.StopSound(channelName:"music1", fadeOut:5f);
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.Transition();
            Defaults.Haogandu_an = Defaults.Haogandu_an + 1;
            yield return _gameMethods.OpenDialog(2392); // "又是两个月过去。"
            yield return _gameMethods.Scene("heilong_chufang_zhuo1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.1f}, {"xalign", 0.5f}, {"yalign", 0.5f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/heilong_chufang_zhuo1_yingzi_nv1.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.1f}, {"xalign", 0.5f}, {"yalign", 0.5f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/heilong_chufang_zhuo1_tiandian.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.1f}, {"xalign", 0.5f}, {"yalign", 0.5f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(2393); // "…………终于。"
            yield return _gameMethods.PlaySound("music", 0.0f, 0.8f, "audio/demo_audio/music/qingkuai3.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan12", "zui8", "emoji2", "emoji9"});
            yield return _gameMethods.OpenDialog(2394); // "终于完成了！！"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
            Defaults.Persistent.Jq_3_1 = 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan2", "zui8", "-emoji2", "emoji7", "emoji9"});
            yield return _gameMethods.OpenDialog(2395); // "完美的鸡蛋布丁。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan9", "zui7", "-emoji2", "-emoji7", "emoji9"});
            yield return _gameMethods.OpenDialog(2396); // "我擦了一把头上的汗，{nw}{w=0.1}"
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/heilong_chufang_zhuo1_tiandian.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 0.5f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.5f}, {"zoom", 1.1f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.6f}, {"xpos", 0.58f}, {"zoom", 1.44f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/heilong_chufang_zhuo1_yingzi_nv1.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 0.5f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.5f}, {"zoom", 1.1f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.6f}, {"xpos", 0.58f}, {"zoom", 1.44f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/heilong_chufang_zhuo1.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 0.5f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.5f}, {"zoom", 1.1f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.6f}, {"xpos", 0.58f}, {"zoom", 1.44f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2397); // "看着这几天来的攻克目标。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/heilong_chufang_zhuo1_tiandian.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.58f}, {"zoom", 1.44f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/heilong_chufang_zhuo1_yingzi_nv1.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.58f}, {"zoom", 1.44f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/heilong_chufang_zhuo1.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.58f}, {"zoom", 1.44f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan18", "zui7", "-emoji9"});
            yield return _gameMethods.OpenDialog(2398); // "由于赫泽尔时常是一副清心寡欲的模样，我很想找到一个能让他喜欢的东西。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui8", "emoji7"});
            yield return _gameMethods.OpenDialog(2399); // "比如，几乎很少有人能拒绝的甜点。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui8", "-emoji7"});
            yield return _gameMethods.OpenDialog(2400); // "尤其是在这个工业并不发达的时代，糖无法被批量化生产，/n比起在现代、甜味显得更加稀少而珍贵，因而也更具诱惑力。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui7"});
            yield return _gameMethods.OpenDialog(2401); // "……对我更有利的是，由于缺乏探索，这个世界的甜品食谱也差不多停留在中世纪水平。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/daoju/zhongshiji_dangao.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"ypos", 0.92f}, {"zoom", 1.16f}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.6f}, {"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 1.2f}, {"xpos", 0.5f}, {"alpha", 1.0f}})});
            yield return _gameMethods.OpenDialog(2402); // "人们口中的所谓“蛋糕”，充其量只是加入了鸡蛋的面包。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/daoju/zhongshiji_dangao.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(0.5f, 0.92f)}, {"alpha", 1.0f}})});
            yield return _gameMethods.OpenDialog(2403); // "甜品师并不知道通过打发蛋清，可以让烘烤完的面团疏松多孔，以制作出后世那种蓬松的海绵蛋糕。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/daoju/zhongshiji_dangao.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"alpha", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan112", "zui7"});
            yield return _gameMethods.OpenDialog(2404); // "不过，我暂时也没有挑战制作奶油蛋糕的打算。"
            yield return _gameMethods.Hide("Assets/RenpyResources/images/daoju/zhongshiji_dangao.png");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2405); // "在缺少电动打蛋器的情况下，无论是手打蛋清还是手搅奶油，都太过挑战人类极限了。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan21", "zui8"});
            yield return _gameMethods.OpenDialog(2406); // "我决定先脚踏实地，从简单一些的甜品做起。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/ding1.mp3");
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/heilong_chufang_zhuo1_tiandian_star.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-0.14f, -174f)}, {"zoom", 1.44f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2407); // "比如布丁。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/heilong_chufang_zhuo1_tiandian_star.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/daoju/zhongshiji_buding.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"ypos", 0.88f}, {"zoom", 1.2f}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.6f}, {"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 1.2f}, {"xpos", 0.5f}, {"alpha", 1.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan8", "zui8"});
            yield return _gameMethods.OpenDialog(2408); // "这个世界中存在的“布丁”还处于最原始的版本，等同于填了肉馅的烤面团，是一种主食。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/daoju/zhongshiji_buding.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.5f}, {"alpha", 1.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan21", "zui8"});
            yield return _gameMethods.OpenDialog(2409); // "而在我记忆中、作为甜品的那种蛋糕式的蛋奶布丁，此刻还没发明。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/daoju/zhongshiji_buding.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"alpha", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui7"});
            yield return _gameMethods.OpenDialog(2410); // "这就是我的机会。"
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:12f);
            yield return _gameMethods.Hide("Assets/RenpyResources/images/daoju/zhongshiji_buding.png");
            Defaults.Persistent.Nvl_tran = 0;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai_nvl");
            yield return _gameMethods.OpenDialog(2411); // "——实际上，曾经我也尝试过借助所谓穿越者的优势，通过发明，发家致富。"
            Defaults.Persistent.Nvl_tran = 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai_nvl");
            yield return _gameMethods.OpenDialog(2412); // "鉴于火药、肥皂这些化工产品的合成知识，要么已经被我全部还给老师了，要么就从来没进入过我的大脑。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai_nvl");
            yield return _gameMethods.OpenDialog(2413); // "我把野心放在了新式甜点上。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai_nvl");
            yield return _gameMethods.OpenDialog(2414); // "我拜托洛恩以他家的磨坊和面包店提供材料，多次试验，做出了成品。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai_nvl");
            yield return _gameMethods.OpenDialog(2415); // "邻居们品尝后，全都惊为天人。"
            yield return _gameMethods.PlaySound("music1", 4f, 1.0f, "audio/demo_audio/music/youshang2.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai_nvl");
            yield return _gameMethods.OpenDialog(2416); // "可高昂的成本使得产品的价格不菲，完全超出了平民阶层的负担水平，只能面向贵族家庭及中上阶层售卖。"
            yield return _gameMethods.NvlClear();
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai_nvl");
            yield return _gameMethods.OpenDialog(2417); // "而当我们面对后者时，所拿出的新技术，只得到了一个结果："
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai_nvl");
            yield return _gameMethods.OpenDialog(2418); // "首先，由于出身平民家庭，我们面包店所发明的新甜点遭到了整个贵族群体的集体无视。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai_nvl");
            yield return _gameMethods.OpenDialog(2419); // "送给他们试吃的样品，不是被管家居高临下、矜持委婉地拒之门外；就是送到仆人的手中后，石沉大海。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai_nvl");
            yield return _gameMethods.OpenDialog(2420); // "接着，我们听说某个贵族家庭的主厨忽然“在自然的启迪和灵智的恩惠下”，“发明了一款佳醴”。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai_nvl");
            yield return _gameMethods.OpenDialog(2421); // "这时，那群贵族便仿佛突然睁开了眼睛，纷纷对这款甜品趋之若鹜，称赞它是“天才的发明”。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai_nvl");
            yield return _gameMethods.OpenDialog(2422); // "而中间群体，更不用说，向来把模仿上流社会作为时尚的风向标。"
            yield return _gameMethods.NvlClear();
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai_nvl");
            yield return _gameMethods.OpenDialog(2423); // "结果，我发明的甜品风靡了整个王国，前提是——它不能是我的发明。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai_nvl");
            yield return _gameMethods.OpenDialog(2424); // "甚至，连那名厨师都没有资格留下名字，这份甜品最终以该贵族的家族姓氏冠名。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(2425); // "……于是，我明白了。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15"});
            yield return _gameMethods.OpenDialog(2426); // "食物，同样是贵族之间进行身份认同的一环。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2427); // "平民不配发明出贵族所使用的东西。{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan20", "zui15"});
            yield return _gameMethods.OpenDialog(2428); // "除非我成为了大骑士或魔法师，改变了身份。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(2429); // "我转生了，这个世界存在剑与魔法，看似充满机会。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(2430); // "可我发现，事实依旧如此绝望。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan20", "zui15"});
            yield return _gameMethods.OpenDialog(2431); // "咸鱼翻身的机会寥寥无几。出身几乎决定了一切。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan18", "zui15"});
            yield return _gameMethods.OpenDialog(2432); // "要么投身于一个高级的血统，要么一开始就获得了优越的先天天赋。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan21", "zui15"});
            yield return _gameMethods.OpenDialog(2433); // "接着才有资格谈努力。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(2434); // "……最终，我熄了靠发明改变命运的念头。"
            yield return _gameMethods.StopSound(channelName:"music1", fadeOut:8f);
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan6", "zui15"});
            yield return _gameMethods.OpenDialog(2435); // "不过，这不妨碍现在的我把它拿出来，讨上司的开心。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan17", "zui15"});
            yield return _gameMethods.OpenDialog(2436); // "当然，在此之前，我已经进行了多次练习，确保万无一失。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 2>audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_shufang_baitian_shafa.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.02f, 3.27f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 2.95f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 2.47f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.5f}})});
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(2437); // "我来到书房，捕获住了正在读书的赫泽尔。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan", "zui15"});
            yield return _gameMethods.OpenDialog(2438); // "还没开口，他就已经抬起头，默默盯着我。"
            Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(2439); // "赫泽尔，今天可以陪我一下吗。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei8", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(2440); // "？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(2441); // "可以。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.PlaySound("music", 2f, 1.0f, "audio/demo_audio/music/qingkuai4.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei3", "yan12", "zui8"});
            yield return _gameMethods.OpenDialog(2442); // "「哼哼……{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei3", "yan5", "zui19", "emoji10"});
            yield return _gameMethods.OpenDialog(2443); // "跟我来一下厨房吧！」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan4", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei3", "yan5", "zui8", "-emoji10"});
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan12", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice14_018dd3f9.ogg");
            yield return _gameMethods.OpenDialog(2094); // "嗯。"
            yield return _gameMethods.Scene("heilong_chufang_zhuo1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.1f}, {"xalign", 0.5f}, {"yalign", 0.5f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/heilong_chufang_zhuo1_yingzi_nv1.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.1f}, {"xalign", 0.5f}, {"yalign", 0.5f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/heilong_chufang_zhuo1_yingzi_he1.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.1f}, {"xalign", 0.5f}, {"yalign", 0.5f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/heilong_chufang_zhuo1_tiandian.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.1f}, {"xalign", 0.5f}, {"yalign", 0.5f}})});
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<silence 0.2>", "audio/demo_audio/sound/ding1.mp3");
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/heilong_chufang_zhuo1_tiandian_star.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.1f}, {"xalign", 0.5f}, {"yalign", 0.5f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan12", "zui2", "emoji7", "emoji9"});
            yield return _gameMethods.OpenDialog(2444); // "锵锵！！"
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/heilong_chufang_zhuo1_tiandian_star.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei3", "yan12", "zui8", "-emoji7", "-emoji9"});
            yield return _gameMethods.OpenDialog(2004); // "……？"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan2", "zui8"});
            yield return _gameMethods.OpenDialog(2445); // "我像电视节目里推销钻石的导购小姐一般，展示桌面上的盘子。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"me4", "yan5", "zui19", "emoji7", "emoji9"});
            yield return _gameMethods.OpenDialog(2446); // "请看，这是我给你准备的礼物！"
            yield return _gameMethods.Show("he_ce", parts: new List<string>{"mei1", "yan2", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.71f, 0.72f)}, {"zoom", 0.4f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1f}})});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei4", "yan5", "zui7", "-emoji7", "-emoji9"});
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            yield return _gameMethods.Show("he_ce", parts: new List<string>{"mei2", "yan14", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he_ce", parts: new List<string>{"mei2", "yan8", "zui6"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(2447); // "礼物？"
            yield return _gameMethods.Show("he_ce", parts: new List<string>{"mei2", "yan8", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(2448); // "嗯。布丁！我亲手做的。"
            yield return _gameMethods.Show("he_ce", parts: new List<string>{"mei2", "yan7", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan", "zui19"});
            yield return _gameMethods.OpenDialog(2449); // "尝尝吧，这可是自信之作！"
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/heilong_chufang_zhuo1_tiandian_star.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"alpha", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui2"});
            yield return _gameMethods.OpenDialog(2450); // "连贵族的宴会上都吃不到哦。无论在哪个国家，哪个种族的地盘都吃不到的。"
            yield return _gameMethods.Hide("Assets/RenpyResources/images/bg/heilong_chufang_zhuo1_tiandian_star.png");
            yield return _gameMethods.Show("he_ce", parts: new List<string>{"mei2", "yan14", "zui1"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he_ce", parts: new List<string>{"mei2", "yan8", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan17", "zui2", "emoji7"});
            yield return _gameMethods.OpenDialog(2451); // "客人，需要的话，本店还可以提供喂食服务呢。"
            yield return _gameMethods.Show("he_ce", parts: new List<string>{"mei1", "yan12", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"me3", "yan17", "zui8", "-emoji7"});
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.Show("he_ce", parts: new List<string>{"mei2", "yan8", "zui6"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice14_2539f412.ogg");
            yield return _gameMethods.OpenDialog(2452); // "不用了。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/canpanpengzhuang2_duan.mp3");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/bg/heilong_chufang_zhuo1_yingzi_he1.png");
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/heilong_chufang_zhuo1_yingzi_he2.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.1f}, {"xalign", 0.5f}, {"yalign", 0.5f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.Show("he_ce", parts: new List<string>{"mei2", "yan8", "zui1"});
            Engine._history = false;
            yield return _gameMethods.OpenDialog(2453); // "{nw}{w=0.2}"
            Engine._history = true;
            yield return _gameMethods.Show("he_ce", parts: new List<string>{"mei2", "yan14", "zui1"});
            yield return _gameMethods.OpenDialog(2454); // "他拿起勺子，切了一块布丁，放入口中。"
            yield return _gameMethods.Show("he_ce", parts: new List<string>{"mei2", "yan8", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(2455); // "我观察着他的表情。"
            yield return _gameMethods.Show("he_ce", parts: new List<string>{"mei2", "yan8", "zui9"});
            yield return _gameMethods.OpenDialog(2456); // "他咀嚼两下，"
            yield return _gameMethods.Show("he_ce", parts: new List<string>{"mei2", "yan2", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2457); // "眼睛微微睁大了些许。"
            yield return _gameMethods.Show("he_ce", parts: new List<string>{"mei2", "yan10", "zui9", "emoji4"});
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.Show("he_ce", parts: new List<string>{"mei2", "yan11", "zui2", "emoji4"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.Show("he_ce", parts: new List<string>{"mei2", "yan14", "zui2", "-emoji4"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.Show("he_ce", parts: new List<string>{"mei2", "yan10", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2458); // "又很快收敛起神色，回归一本正经又冷淡的模样。"
            yield return _gameMethods.Show("he_ce", parts: new List<string>{"mei2", "yan10", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(2459); // "可能比较甜。怎么样，喜欢吗？"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<from 0 to 0.5>audio/demo_audio/sound/zu3_nv_zou.ogg");
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/heilong_chufang_zhuo1_yingzi_he2.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.5f}, {"alpha", 0f}})});
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/heilong_chufang_zhuo1_yingzi_he1.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.1f}, {"xalign", 0.5f}, {"yalign", 0.5f}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.5f}, {"alpha", 1f}})});
            yield return _gameMethods.Show("he_ce", parts: new List<string>{"mei2", "yan11", "zui6"});
            Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice14_aa3e4870.ogg");
            yield return _gameMethods.OpenDialog(2460); // "……还可以。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/heilong_chufang_zhuo1_yingzi_he1.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.Hide("Assets/RenpyResources/images/bg/heilong_chufang_zhuo1_yingzi_he2.png");
            yield return _gameMethods.Show("he_ce", parts: new List<string>{"mei2", "yan11", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan11", "zui7"});
            yield return _gameMethods.OpenDialog(2461); // "「……{nw}{w=0.4}"
            yield return _gameMethods.Show("he_ce", parts: new List<string>{"mei2", "yan7", "zui4"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(2462); // "为什么你对让我进食这么热衷。」"
            yield return _gameMethods.Show("he_ce", parts: new List<string>{"mei2", "yan7", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui19"});
            yield return _gameMethods.OpenDialog(2463); // "「因为，对于我们来说，食物是重要的生存物资，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan6", "zui19"});
            yield return _gameMethods.OpenDialog(2464); // "分享食物是一种表达喜爱的方式。」"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan42", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(2465); // "当然，这些东西都是他出钱买的，羊毛出在羊身上罢了。"
            yield return _gameMethods.Scene("heilong_chufang_baitian_jin", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.1f}, {"xalign", 0.5f}, {"yalign", 0.5f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 2.47f)}, {"zoom", 0.5f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(2466); // "「我小时候很渴望甜味。{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui11"});
            yield return _gameMethods.OpenDialog(2467); // "但糖对平民来说是奢侈品。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui19"});
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
            yield return _gameMethods.OpenDialog(2468); // "「所以，{nw}{w=0.1}"
            Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(2469); // "我想把我心里最好的东西送给你。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan7", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(2461); // "「……{nw}{w=0.4}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan32", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice14_e3984e98.ogg");
            yield return _gameMethods.OpenDialog(2470); // "以后你想吃，可以随时告诉我去买。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan32", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(2471); // "好啊。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.5f}, {"zpos", -42f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan17", "zui19"});
            yield return _gameMethods.OpenDialog(2472); // "但是现在，你不觉得该给我一点奖励嘛？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -42f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei3", "yan17", "zui16"});
            yield return _gameMethods.OpenDialog(2440); // "？"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei1", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(2473); // "为了做出最好吃的布丁，我可是努力提前练习了很久哦。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei1", "yan2", "zui10", "emoji7", "emoji9"});
            yield return _gameMethods.OpenDialog(2474); // "「失败作都吃吐了，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei1", "yan12", "zui9", "emoji7", "emoji9"});
            yield return _gameMethods.OpenDialog(2475); // "手也累得抽筋了很多次。」"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei3", "yan2", "zui10", "-emoji7", "-emoji9"});
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
            yield return _gameMethods.OpenDialog(2476); // "「而这一切！{nw}{w=0.1}"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/liangjinjin_01.ogg");
            Defaults.Haogandu_he = Defaults.Haogandu_he + 2;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei4", "yan5", "zui10", "emoji7"});
            yield return _gameMethods.OpenDialog(2477); // "都是希望能让我最喜欢的赫泽尔吃到最完美的布丁。」"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan29", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei4", "yan5", "zui15", "emoji7"});
            yield return _gameMethods.OpenDialog(2478); // "「{size=-7}……{/size}{nw}{w=0.4}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan11", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(2479); // "{size=-7}……{/size}」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(2480); // "{size=-7}……最喜欢……{/size}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan5", "zui15", "emoji7"});
            yield return _gameMethods.OpenDialog(2481); // "他的目光垂落，投到我的手上。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan14", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice14_f136cf29.ogg");
            yield return _gameMethods.OpenDialog(2482); // "……你想要什么。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan14", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui19", "-emoji7"});
            yield return _gameMethods.OpenDialog(2483); // "「我想要你，"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(2484); // "对我笑一下。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan11", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice14_8ad6682e.ogg");
            yield return _gameMethods.OpenDialog(2485); // "……笑？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice14_1ee3240f.ogg");
            yield return _gameMethods.OpenDialog(2094); // "嗯。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice14_0353d360.ogg");
            yield return _gameMethods.OpenDialog(2486); // "「为什么。{nw}{w=0.1}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan32", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(2487); // "我看不出其中对你有什么好处。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan32", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(2488); // "当然有了。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan3", "zui10"});
            yield return _gameMethods.OpenDialog(2489); // "「笑是开心的表现，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui19"});
            yield return _gameMethods.OpenDialog(2490); // "而看到你开心，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan11", "zui4"});
            yield return _gameMethods.OpenDialog(2491); // "我也会高兴。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(2492); // "毕竟领导的欢心，就决定了下面的人的生存环境嘛。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan12", "zui2"});
            yield return _gameMethods.OpenDialog(2493); // "我想让赫泽尔感到幸福。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan5", "zui19"});
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv1");
            yield return _gameMethods.OpenDialog(2494); // "如果这样，我也会幸福起来。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan2", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.6>audio/sound/jiaobusheng_xin_kuai1.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}, {"zpos", -42f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.50f}, {"ypos", -18f}, {"zpos", -108f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(2495); // "我把双手的食指放在嘴角两边，积极地怂恿。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -18f}, {"zpos", -108f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui2"});
            yield return _gameMethods.OpenDialog(2496); // "对我笑一笑吧，好吗？"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"ypos", -78f}, {"zpos", -252f}})});
            yield return _gameMethods.TransitionBy("blink2");
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan5", "zui19"});
            yield return _gameMethods.OpenDialog(2497); // "「因为你的开心与否，{nw}{w=0.1}"
            Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan17", "zui4", "emoji15"});
            yield return _gameMethods.OpenDialog(2498); // "对我很重要啊。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan2", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei8", "yan17", "zui7", "emoji15"});
            yield return _gameMethods.OpenDialog(2499); // "「…………{nw}{w=0.3}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan2", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui21", "emoji5"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(2500); // "……{nw}{w=0.4}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan9", "zui3", "emoji5"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui9", "emoji5"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(2175); // "……」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan24", "zui2", "emoji5", "emoji0"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan24", "zui2", "emoji5", "emoji0"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan12", "zui15", "-emoji15"});
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai11", parts: new List<string>{"mei8", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(2501); // "他抿着嘴唇，盯了我片刻。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui2", "emoji5", "emoji0"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai11");
            yield return _gameMethods.OpenDialog(2502); // "继而垂了垂眸，"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui3", "emoji5", "-emoji0"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai11");
            yield return _gameMethods.OpenDialog(2453); // "{nw}{w=0.2}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei4", "yan9", "zui19", "emoji5"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai11");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice14_13e9efab.ogg");
            yield return _gameMethods.OpenDialog(2503); // "有些生涩似的、慢慢地扬起了嘴角，弯出一个近乎于无的弧度。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan26", "zui20", "emoji5"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan12", "zui15", "-emoji15"});
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(2504); // "但，那也是一个微笑。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan26", "zui19", "emoji5"});
            yield return _gameMethods.OpenDialog(2505); // "一个星星一样的微笑。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"ypos", -6f}, {"zpos", -72.0f}})});
            yield return _gameMethods.TransitionBy("blink2");
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(2506); // "嘿嘿。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan17", "zui20", "emoji15"});
            yield return _gameMethods.OpenDialog(2507); // "好开心。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan28", "zui2", "emoji5"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(2453); // "{nw}{w=0.2}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan10", "zui3", "emoji5"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei8", "yan17", "zui7", "emoji15"});
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan3", "zui7", "-emoji15"});
            yield return _gameMethods.OpenDialog(2508); // "好吧，真的挺有成就感的。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui7"});
            yield return _gameMethods.OpenDialog(2509); // "我满意了，又贪心不足起来。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -72.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.7f}, {"zpos", -30.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui19"});
            yield return _gameMethods.OpenDialog(2510); // "「可惜我没有魔力，没法长时间搅拌，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan12", "zui19"});
            yield return _gameMethods.OpenDialog(2511); // "不然就可以给你做奶油蛋糕了。」"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -30.0f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui3", "-emoji5"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui17", "emoji2"});
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2512); // "当然，这不是因为我自己嘴巴馋了，主要还是为了哄领导高兴。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui7", "-emoji2"});
            yield return _gameMethods.OpenDialog(2513); // "正想和他强调一下“我做的奶油蛋糕和普通的奶油蛋糕可不一样！”，只听他先一步不假思索地回答道。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.9>audio/demo_audio/sound/zu3_nv_zou.ogg");
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.9f}, {"zpos", 54.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice14_3be07b26.ogg");
            yield return _gameMethods.OpenDialog(2514); // "我有魔力。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui9"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 54.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(2515); // "……你做这个想干什么？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(2516); // "「啊……{nw}{w=0.1}"
            Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(2517); // "为了给你呀。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui19"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui19"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan3", "zui10"});
            yield return _gameMethods.OpenDialog(2518); // "对了，赫泽尔的生日是什么时候？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan3", "zui15"});
            yield return _gameMethods.OpenDialog(2519); // "生日？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan28", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(1971); // "「……{nw}{w=0.3}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(2520); // "你是说我的出生日期？」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui19"});
            yield return _gameMethods.OpenDialog(2521); // "嗯！"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
            yield return _gameMethods.OpenDialog(2522); // "「奶油蛋糕是在过生日时吃的，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui19"});
            yield return _gameMethods.OpenDialog(2523); // "我想给你庆祝生日。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice14_2a9f81f6.ogg");
            yield return _gameMethods.OpenDialog(2524); // "为什么。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui12"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice14_cea4e769.ogg");
            yield return _gameMethods.OpenDialog(2525); // "「庆生只是人类的传统，{nw}{w=0.1}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice14_6e120999.ogg");
            yield return _gameMethods.OpenDialog(2526); // "我的灵魂不可能在出生日被弱小的恶魔入侵，没必要依靠那种臆想中的仪式来祈求好运。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan12", "zui19"});
            yield return _gameMethods.OpenDialog(2527); // "是啊，你最强大了。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan2", "zui19"});
            yield return _gameMethods.OpenDialog(2528); // "「不过，大家并不是真的为了实际用处而过生日的，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan5", "zui4"});
            yield return _gameMethods.OpenDialog(2529); // "只是想找一个理由来庆祝而已。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan5", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice14_efd3158f.ogg");
            yield return _gameMethods.OpenDialog(2530); // "庆祝什么？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(2531); // "「庆祝——{nw}{w=0.3}"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -6f}, {"zpos", -30.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.5f}, {"ypos", -60f}, {"zpos", -138.0f}})});
            yield return _gameMethods.PlaySound("sound", 0.0f, 2f, "audio/sound/manbu/Body1_02_duan.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(2532); // "……你的诞生啊。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan29", "zui2"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -60f}, {"zpos", -138.0f}})});
            yield return _gameMethods.EngineSetVolume(volume:0.1f, delay:2f, channelName:"music");
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui2"});
            yield return _gameMethods.OpenDialog(2533); // "「感谢你出生在了这个世界上，{nw}{w=0.1}"
            Defaults.Haogandu_he = Defaults.Haogandu_he + 5;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan17", "zui4", "emoji15"});
            yield return _gameMethods.OpenDialog(2534); // "与我相遇。」"
            yield return _gameMethods.PlaySound("soundb", 0.0f, 2f, "audio/music/end/star_looperman_01.mp3");
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan2", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei8", "yan17", "zui7", "emoji15"});
            yield return _gameMethods.OpenDialog(1861); // "…………"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2", "emoji5"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice14_4653b72e.ogg");
            yield return _gameMethods.OpenDialog(2535); // "「唔。{nw}{w=0.3}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2", "emoji5"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui2", "emoji5"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(2536); // "嗯。」"
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:4f);
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9", "-emoji5", "emoji1"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice14_80629821.ogg");
            yield return _gameMethods.OpenDialog(2537); // "你需要我做什么。"
            yield return _gameMethods.EngineSetVolume(volume:1f, delay:1f, channelName:"music");
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2", "emoji1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan2", "zui19", "-emoji15"});
            yield return _gameMethods.OpenDialog(2538); // "能做一个可以持续搅拌液体的装置吗。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.9>audio/demo_audio/sound/zu3_nv_zou.ogg");
            yield return _gameMethods.Hide("he");
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan28", "zui9", "-emoji1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.85f)}, {"zoom", 0.37f}, {"yoffset", 20f}})});
            yield return _gameMethods.Transition();
            yield return _gameMethods.ExecuteCharacterImageData("he");
            yield return _gameMethods.OpenDialog(2539); // "这样？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan28", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15"});
            yield return _gameMethods.OpenDialog(2540); // "他伸出手，掌心朝下。"
            yield return _gameMethods.PlaySound("soundb", 1f, 2f, "audio/sound/xuanfeng.ogg");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15"});
            yield return _gameMethods.OpenDialog(2541); // "半空中出现了一个缩小版的旋风。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.6>audio/sound/jiaobusheng_xin_kuai1.ogg");
            yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<silence 0.5>", "audio/demo_audio/sound/canpanpengzhuang2_duan.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -138.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.20f}, {"zpos", -168.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan21", "zui8", "emoji7"});
            yield return _gameMethods.OpenDialog(2542); // "我连忙捧着盛了蛋清的碗迎了上去。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -168.0f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan28", "zui2"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan2", "zui19", "-emoji7"});
            yield return _gameMethods.OpenDialog(2543); // "可以可以！！"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan11", "zui7", "emoji9"});
            yield return _gameMethods.OpenDialog(2544); // "我有魔能搅蛋器了！"
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:3f);
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui7", "-emoji9"});
            yield return _gameMethods.OpenDialog(2094); // "嗯。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan12", "zui11"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice14_469f9054.ogg");
            yield return _gameMethods.OpenDialog(2545); // "你需要的时候，可以找我。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice14_216f744a.ogg");
            yield return _gameMethods.OpenDialog(2546); // "我可以和你一起做。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(2547); // "好呀。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(1861); // "…………"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.5>audio/demo_audio/sound/zu3_nv_zou.ogg");
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui9"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.20f}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 36.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(2548); // "……你的生日。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 36.0f}})});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(2549); // "嗯？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(2550); // "你的生日，是什么时候。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.5>audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -168.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.15f}, {"zpos", -156.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan2", "zui19"});
            yield return _gameMethods.OpenDialog(2551); // "……啊，这个嘛。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -156.0f}})});
            yield return _gameMethods.OpenSelectMenu(talk: new List<string>{"我忘了"}, jump: new List<string>{"label_zhuxian_2_menu_0_u2XU8tcr"}, condition: new List<string>{"NONE"});
        }

        public IEnumerator label_zhuxian_2_1()
        {
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan2", "zui19"});
            yield return _gameMethods.OpenDialog(2551); // "……啊，这个嘛。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei1", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(2552); // "我忘了。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei1", "yan3", "zui20"});
            yield return _gameMethods.OpenDialog(2553); // "「你看，平民也不可能买得起蛋糕，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan5", "zui2"});
            yield return _gameMethods.OpenDialog(2554); // "所以大部分人都是不过生日的。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(2555); // "「………………{nw}{w=0.6}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(2556); // "哦。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:4f);
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui7"});
            yield return _gameMethods.OpenDialog(2557); // "其实我应该告诉他的。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2558); // "这有利于让他在我身上倾注更多感情，投入更多的时间与精力。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui7"});
            yield return _gameMethods.OpenDialog(2559); // "而这一切，都会在最后他对我真正下手时，成为阻拦在他面前的沉没成本。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2560); // "但是，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan21", "zui15"});
            yield return _gameMethods.OpenDialog(2561); // "我……犹豫了。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan20", "zui15"});
            yield return _gameMethods.OpenDialog(2562); // "我不想把曾经和妈妈一起度过的幸福时光，和如今扯上关系。"
            yield return _gameMethods.PlaySound("music1", 0.0f, 1.0f, "audio/music/One_spring_day.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(2563); // "那些记忆是我仅有的东西了。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan9", "zui15"});
            yield return _gameMethods.OpenDialog(2564); // "妈妈再也不会对我笑、给我过生日了。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan9", "zui15"});
            yield return _gameMethods.OpenDialog(2565); // "我每年最幸福的日子——妈妈会请假提早下班，给我准备惊喜，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan12", "zui7"});
            yield return _gameMethods.OpenDialog(2566); // "做一顿奢侈的大餐，陪我一整天。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan20", "zui15"});
            yield return _gameMethods.OpenDialog(2567); // "就连这种心情与回忆也要被覆盖吗？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(2568); // "不行，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(2569); // "不能这样低落。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1>audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -60f}, {"zpos", -156.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.3f}, {"ypos", -72f}, {"zpos", -198.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(2570); // "对不起，不能让赫泽尔陪我过生日，太遗憾了。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -72f}, {"zpos", -198.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei1", "yan5", "zui19"});
            yield return _gameMethods.OpenDialog(2571); // "有点难过呢。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei1", "yan5", "zui7"});
            yield return _gameMethods.OpenDialog(2572); // "没事。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/ding1.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(2573); // "「啊！{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan12", "zui10"});
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan2", "zui19"});
            yield return _gameMethods.OpenDialog(2574); // "我有办法了。」"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.5>audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -198.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.11f}, {"zpos", -222.0f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan11", "zui2"});
            yield return _gameMethods.OpenDialog(2575); // "不如，我就和赫泽尔在同一天过生日吧。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -222.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan5", "zui2"});
            yield return _gameMethods.OpenDialog(2576); // "赫泽尔的生日，就是我的生日，也是我们的相遇庆祝日。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui9", "emoji1"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei8", "yan5", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_2_1_23a38dee.ogg");
            yield return _gameMethods.OpenDialog(2577); // "……好。"
            yield return _gameMethods.StopSound(channelName:"music1", fadeOut:10f);
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2", "emoji1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan6", "zui7"});
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.PlaySound("music", 6f, 1.0f, "audio/demo_audio/music/richang1.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan2", "zui19"});
            yield return _gameMethods.OpenDialog(2578); // "说起来，我一直很好奇。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2", "-emoji1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan3", "zui10"});
            yield return _gameMethods.OpenDialog(2579); // "「记得你说过龙族在150岁到达成长期，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan5", "zui9"});
            yield return _gameMethods.OpenDialog(2580); // "那么，龙的寿命到底有多长呢？」"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(2581); // "关于此事，民间也不是没有相关传闻。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(2582); // "一般要么说是几百几千年，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui15"});
            yield return _gameMethods.OpenDialog(2583); // "要么就是夸张地言之凿凿表示龙能够不朽。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(2584); // "没想到现在会遇到正主，终于可以解惑了。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_demo_164e1fe0.ogg");
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(2585); // "根据血脉种类的差异，有所不同。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(2586); // "最普遍的寿命长度呢？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan5", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(2587); // "「一般从三万到五万年不等。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan18", "zui11"});
            yield return _gameMethods.OpenDialog(2588); // "「那……{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui19"});
            yield return _gameMethods.OpenDialog(2589); // "你的寿命呢？」"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(2590); // "印象里他属于更高等一些的龙。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_2_1_f61768b2.ogg");
            yield return _gameMethods.OpenDialog(2591); // "一百万年。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan13", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(2592); // "{size=+10}好长。{/size}"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan10", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(2593); // "你这家伙出生的时候太走运了吧。  "
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan10", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan24", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(2594); // "这就是站在食物链顶端的生物啊。 "
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan20", "zui15"});
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2595); // "绝对的单体强大，导致种族繁衍的困难，与数量上的稀有。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan12", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(2596); // "它们的生命，一定很有价值吧。"
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(2597); // "我的出生日……在冬天。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan12", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan8", "zui19"});
            yield return _gameMethods.OpenDialog(2598); // "「这样啊。……{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan5", "zui19"});
            yield return _gameMethods.OpenDialog(2599); // "那到时候、我就提前为你做蛋糕庆祝吧。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(2600); // "「不过，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan3", "zui9"});
            yield return _gameMethods.OpenDialog(2601); // "因为赫泽尔同时也要给我庆祝，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(2602); // "所以必须和我一起动手哦！」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan25", "zui19"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(2603); // "……嗯，可以。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.PlaySound("sound", 0.0f, 2f, "audio/sound/manbu/Body1_02_duan.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -72f}, {"zpos", -222.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.15f}, {"ypos", -78f}, {"zpos", -234.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan17", "zui4", "emoji15"});
            yield return _gameMethods.OpenDialog(2604); // "嘿嘿，约好了。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui9", "emoji1"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -78f}, {"zpos", -234.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan17", "zui7", "-emoji15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_2_1_12001c2d.ogg");
            yield return _gameMethods.OpenDialog(2605); // "……唔。"
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(2606); // "在轻松的氛围中，我们瓜分了布丁。"
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/heilong_chufang_baitian_man1.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.67f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition();
            Defaults.Persistent.Jq_3_2 = 1;
            Defaults.Haogandu_an = Defaults.Haogandu_an + 1;
            yield return _gameMethods.OpenDialog(2607); // "自从随我一起在厨房做过甜品后，赫泽尔似乎就突然解锁了一个新的场所，对这里产生了兴趣。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan25", "zui2", "-emoji1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 2.16f)}, {"zoom", 0.42f}})});
            yield return _gameMethods.Transition();
            Engine._history = false;
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.OpenDialog(2608); // "当我来到厨房料理自己的一日三餐，他也不声不响地从旁观看。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan9", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei5", "yan21", "zui8", "emoji2"});
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan28", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv", parts: new List<string>{"mei6", "yan8", "zui16", "emoji2"});
            yield return _gameMethods.OpenDialog(2609); // "（……压力好大。）"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan2", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan4", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(2610); // "理论上来讲，下属是不应该让领导干杂活的。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(2611); // "但是，总得让他有点参与感。"
            yield return _gameMethods.Scene("heilong_chufang_cai1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.1f}, {"xalign", 0.5f}, {"yalign", 0.5f}})});
            yield return _gameMethods.Transition();
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(2612); // "我站在切菜台前，试探性地提问。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(2613); // "赫泽尔，你有办法把这根萝卜切成片吗？"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan11", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(2614); // "他不会生气吧……？感觉受到了冒犯什么的。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan8", "zui8", "emoji2"});
            yield return _gameMethods.OpenDialog(2615); // "那样的话我就立刻道歉加拍马屁。"
            yield return _gameMethods.Show("he_ce", parts: new List<string>{"mei2", "yan10", "zui4"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.8f, 0.75f)}, {"zoom", 0.4f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(2616); // "可以，你要什么样的切片。"
            yield return _gameMethods.Show("he_ce", parts: new List<string>{"mei2", "yan10", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10", "-emoji2"});
            yield return _gameMethods.OpenDialog(2617); // "差不多这么厚。"
            yield return _gameMethods.Show("he_ce", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"alpha", 0f}, {"blur", 0.1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(2618); // "我用指尖比划了一下。"
            yield return _gameMethods.Hide("he_ce");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2619); // "他静静地审视了两秒，将手拂过案板上那根胡萝卜。"
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui15", "emoji12"});
            yield return _gameMethods.OpenDialog(2004); // "……？"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15", "-emoji12"});
            yield return _gameMethods.OpenDialog(2620); // "胡萝卜纹丝不动，形状完好无损。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui15"});
            yield return _gameMethods.OpenDialog(2621); // "还在蓄力吗？"
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:1f);
            yield return _gameMethods.Scene("heilong_chufang_cai2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.1f}, {"xalign", 0.5f}, {"yalign", 0.5f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(2622); // "——忽然，那根胡萝卜无声无息地裂开了。"
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(2623); // "它乖巧地分散成了完美的切片，瘫痪在案板上。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan1", "zui15", "emoji2"});
            yield return _gameMethods.OpenDialog(2624); // "震撼。厚薄控制得完全一致！"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
            yield return _gameMethods.PlaySound("music", 0.0f, 0.5f, "audio/music/PerituneMaterial_Laid_Back2_loop.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan2", "zui9", "emoji2"});
            yield return _gameMethods.OpenDialog(2625); // "这……这简直……！任何一个会下厨人士都会为之怦然心动的程度。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui19", "-emoji2"});
            yield return _gameMethods.OpenDialog(2626); // "太厉害了！"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
            yield return _gameMethods.OpenDialog(2627); // "难道你真的是天才？"
            yield return _gameMethods.Show("he_ce", parts: new List<string>{"mei2", "yan6", "zui3"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.8f, 0.75f)}, {"zoom", 0.4f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_2_1_92976d97.ogg");
            yield return _gameMethods.OpenDialog(2628); // "……这只是小事。"
            yield return _gameMethods.Show("he_ce", parts: new List<string>{"mei2", "yan11", "zui4", "emoji4"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(2629); // "你还需要什么。"
            yield return _gameMethods.Show("he_ce", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}, {"blur", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 0f}, {"blur", 0.1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan9", "zui19"});
            yield return _gameMethods.OpenDialog(2630); // "嗯，还有土豆！"
            yield return _gameMethods.Hide("he_ce");
            yield return _gameMethods.Scene("heilong_chufang_cai3", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.1f}, {"xalign", 0.5f}, {"yalign", 0.5f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui7"});
            yield return _gameMethods.OpenDialog(2631); // "土豆也裂开了。"
            yield return _gameMethods.Scene("heilong_chufang_cai4", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.1f}, {"xalign", 0.5f}, {"yalign", 0.5f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei4", "yan5", "zui19"});
            yield return _gameMethods.OpenDialog(2632); // "蘑菇也……！"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan9", "zui7"});
            yield return _gameMethods.OpenDialog(2633); // "蘑菇三度裂开。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan12", "zui7", "emoji7"});
            yield return _gameMethods.OpenDialog(2634); // "在黑龙大人的英明领导下，今天厨房的工作效率提升了300%%。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan12", "zui7", "-emoji7"});
            yield return _gameMethods.OpenDialog(2635); // "见我不出声了，赫泽尔开口询问。"
            yield return _gameMethods.Show("he_ce", parts: new List<string>{"mei2", "yan14", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.8f, 0.75f)}, {"zoom", 0.4f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1f}})});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he_ce", parts: new List<string>{"mei2", "yan7", "zui4"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_2_1_fd607ccb.ogg");
            yield return _gameMethods.OpenDialog(2636); // "还有么。"
            yield return _gameMethods.Show("he_ce", parts: new List<string>{"mei2", "yan7", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui19"});
            yield return _gameMethods.OpenDialog(2637); // "「暂时没有啦，谢谢你，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan11", "zui4"});
            yield return _gameMethods.OpenDialog(2638); // "今天的分量已经足够了。」"
            yield return _gameMethods.Show("he_ce", parts: new List<string>{"mei2", "yan10", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan5", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_2_1_f567f26f.ogg");
            yield return _gameMethods.OpenDialog(2639); // "……哦。"
            yield return _gameMethods.Show("he_ce", parts: new List<string>{"mei2", "yan10", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.OpenDialog(2640); // "他放下手，但话语里，好像没有几分高兴的意思……？"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan6", "zui10"});
            yield return _gameMethods.OpenDialog(2641); // "「那，"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zu2"});
            yield return _gameMethods.OpenDialog(2642); // "明天还可以再拜托你吗？」"
            yield return _gameMethods.Show("he_ce", parts: new List<string>{"mei2", "yan7", "zui4"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(2441); // "可以。"
            yield return _gameMethods.Show("he_ce", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 0f}, {"blur", 0.1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui16", "emoji2"});
            yield return _gameMethods.OpenDialog(2643); // "我曾经梦寐以求的全自动切菜机，居然实现了。"
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:5f);
            yield return _gameMethods.Hide("he_ce");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/heilong_chufang_zaocan/heilong_chufang_zaocan_ditu.jpg");
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/heilong_chufang_zaocan/heilong_chufang_zaocan_zhuozi.png");
            yield return _gameMethods.Transition();
            yield return _gameMethods.OpenDialog(2644); // "我火速了做了双人份的浓汤，把买来的面包切下几片，端到桌面上。"
            yield return _gameMethods.PlaySound("music1", 0.0f, 1.0f, "audio/demo_audio/music/richang2.mp3");
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/heilong_chufang_zaocan/heilong_chufang_zaocan_yingzi_nv.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui2"});
            yield return _gameMethods.OpenDialog(2645); // "「作为帮忙的感谢，赫泽尔，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan11", "zui2"});
            yield return _gameMethods.OpenDialog(2646); // "/n如果可以的话，和我一起吃早餐吧。」"
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/heilong_chufang_zaocan/heilong_chufang_zaocan_yingzi_nv.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            yield return _gameMethods.Show("he_ce", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.8f, 0.75f)}, {"zoom", 0.4f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1f}})});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.Show("he_ce", parts: new List<string>{"mei2", "yan14", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he_ce", parts: new List<string>{"mei2", "yan10", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2647); // "他盯着布置好早餐的木桌，似乎在观察一个非常陌生的事物。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1>audio/demo_audio/sound/zu3_nv_zou.ogg");
            yield return _gameMethods.PlaySound("sounda", 0.0f, 0.5f, "<silence 1>", "audio/demo_audio/sound/moca2.mp3");
            yield return _gameMethods.StopEngineTime(time:0.7f);
            yield return _gameMethods.Show("he", parts: new List<string>{"ying1", "mei1", "yan23", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"ypos", 1.5f}, {"zoom", 0.31f}, {"xpos", 0.5f}})});
            yield return _gameMethods.Hide("Assets/RenpyResources/images/bg/heilong_chufang_zaocan/heilong_chufang_zaocan_zhuozi.png");
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/heilong_chufang_zaocan/heilong_chufang_zaocan_zhuozi.png");
            yield return _gameMethods.Show("blend", parts: new List<string>{"multiply"});
            yield return _gameMethods.Hide("Assets/RenpyResources/images/bg/heilong_chufang_zaocan/heilong_chufang_zaocan_yingzi_nv.png");
            yield return _gameMethods.Show("Assets/RenpyResources/images/bg/heilong_chufang_zaocan/heilong_chufang_zaocan_yingzi_nv.png");
            yield return _gameMethods.Hide("he_ce");
            yield return _gameMethods.Transition(time:1f);
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2648); // "过了一会儿，才缓缓地在桌边坐下。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan9", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_2_1_a3a2f68a.ogg");
            yield return _gameMethods.OpenDialog(2524); // "为什么。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10"});
            yield return _gameMethods.OpenDialog(2649); // "嗯……？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan12", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_2_1_ff00f43c.ogg");
            yield return _gameMethods.OpenDialog(2650); // "——你知道的，我不需要进食。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_2_1_b3352abd.ogg");
            yield return _gameMethods.OpenDialog(2651); // "「还是说，这也是因为{nw}{w=0.1}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_2_1_69498f1e.ogg");
            yield return _gameMethods.OpenDialog(2652); // "你喜欢……{nw}{w=0.1}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_2_1_d067d2c1.ogg");
            yield return _gameMethods.OpenDialog(2653); // "所以想分享给我。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui19"});
            yield return _gameMethods.OpenDialog(2654); // "是呀。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.OpenDialog(2655); // "我不假思索地回答。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2", "emoji5"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.OpenDialog(2205); // "他不说话了。"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 0.5f, "audio/demo_audio/sound/moca2.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}, {"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.5f}, {"ypos", -40f}, {"zpos", -96f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan11", "zui9", "emoji9", "emoji10"});
            yield return _gameMethods.OpenDialog(2656); // "我将双肘放在桌面上，拖着两腮，笑意盈盈地望他。"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -40f}, {"zpos", -96f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2", "emoji1", "-emoji5"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui2", "emoji9", "emoji10", "emoji15"});
            yield return _gameMethods.OpenDialog(2657); // "况且，我想和赫泽尔一起共进早餐。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2", "emoji1"});
            Defaults.Haogandu_he = Defaults.Haogandu_he + 1;
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui4", "-emoji9", "-emoji10", "emoji15"});
            yield return _gameMethods.OpenDialog(2658); // "你不觉得这样就像家人一样吗？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui9", "emoji1"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan11", "zui7", "emoji15"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_2_1_db3888a5.ogg");
            yield return _gameMethods.OpenDialog(2659); // "家人……"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9", "-emoji1"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv");
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_2_1_c04d587d.ogg");
            yield return _gameMethods.OpenDialog(2660); // "可你是人类。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2661); // "他摆出了一副“我们种族不同”的冷静表情。"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan10", "zui7", "-emoji15"});
            yield return _gameMethods.OpenDialog(2662); // "怎么了，我们人类没资格当龙族的家人是吧。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan6", "zui19"});
            yield return _gameMethods.OpenDialog(2663); // "呃……确实，我们没有亲缘关系。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui19"});
            yield return _gameMethods.OpenDialog(2664); // "可是，家人也不是非得拥有血缘关系才能在一起啊。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_2_1_8d617035.ogg");
            yield return _gameMethods.OpenDialog(2665); // "你是说嫁娶？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei4", "yan22", "zui2", "emoji5", "emoji12", "emoji16"});
            yield return _gameMethods.OpenDialog(2666); // "{sc=2}{size=+10}不是！！！！！{/size}{/sc}"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan22", "zui8", "emoji3", "emoji5", "-emoji12", "emoji16"});
            yield return _gameMethods.OpenDialog(2667); // "什么东西？！"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19", "emoji2", "-emoji3", "-emoji5", "-emoji16"});
            yield return _gameMethods.OpenDialog(2668); // "只要有情感上的羁绊，互相支撑着生活下去，就可以称作家人。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan4", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(2669); // "「现在，我们生活在一个屋檐下，赫泽尔是我很重视的存在，{nw}{w=0.1}"
            yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui19", "emoji2"});
            yield return _gameMethods.OpenDialog(2670); // "所以你就是我的家人。」"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui9", "emoji1"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui7", "-emoji2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_2_1_15df5f66.ogg");
            yield return _gameMethods.OpenDialog(2639); // "……哦。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/canpanpengzhuang2_duan.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"ypos", -202f}, {"zpos", -480f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui2", "-emoji1"});
            yield return _gameMethods.Transition(time:0.8f);
            Engine._history = false;
            yield return _gameMethods.OpenDialog(2249); // "{nw}{w=0.5}"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui9"});
            yield return _gameMethods.OpenDialog(2249); // "{nw}{w=0.5}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan23", "zui2"});
            yield return _gameMethods.OpenDialog(2671); // "他垂眸喝了一口汤，又咬了一口面包，仔细地咀嚼后，才文雅地咽下。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan5", "zui10", "emoji2"});
            yield return _gameMethods.OpenDialog(2672); // "怎么样？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei3", "yan5", "zui15", "-emoji2"});
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian_2_1_85494f00.ogg");
            yield return _gameMethods.OpenDialog(2673); // "我没有品尝过同类的食物，所以无法进行对比。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan10", "zui7", "emoji2"});
            yield return _gameMethods.OpenDialog(2674); // "你真诚实啊。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui19", "-emoji2"});
            yield return _gameMethods.OpenDialog(2675); // "那，就只问问自己的心就好了。"
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan17", "zui4"});
            yield return _gameMethods.OpenDialog(2676); // "你喜欢吗？"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui9", "emoji1"});
            yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan17", "zui7"});
            yield return _gameMethods.OpenDialog(2677); // "……不算讨厌。"
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui2", "emoji1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan7", "zui6"});
            yield return _gameMethods.OpenDialog(1860); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan7", "zui6"});
            yield return _gameMethods.OpenDialog(2678); // "哈，口是心非。"
            yield return _gameMethods.PlaySound("sounda", 0.0f, 0.5f, "audio/demo_audio/sound/moca2.mp3");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -20f}, {"zpos", -48f}})});
            yield return _gameMethods.Transition(time:0.6f);
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui7"});
            yield return _gameMethods.OpenDialog(2679); // "我也开始专心享受早餐，把面包浸泡进汤碗中。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/door_qiao2.ogg", "<from 0 to 0.3>audio/demo_audio/sound/door_qiao2.ogg");
            yield return _gameMethods.StopSound(channelName:"music1", fadeOut:3f);
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -20f}, {"zpos", -48f}})});
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(1952); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui2", "-emoji1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
            yield return _gameMethods.OpenDialog(2680); // "——咚咚咚。"
            yield return _gameMethods.ChangeLabelTo("label_zhuxian_3");
        }
}