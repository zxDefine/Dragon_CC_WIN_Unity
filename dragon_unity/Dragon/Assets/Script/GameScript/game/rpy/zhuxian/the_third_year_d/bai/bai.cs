using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bai : ILabelProvider
{
    private GameMethods _gameMethods;

    public bai(GameMethods gameMethods)
    {
        _gameMethods = gameMethods;
    }

    public IEnumerator label_bai_xinlingtongxun2()
    {
        yield return _gameMethods.OpenDialog(8660); // "我心中忐忑，考虑着要不要在他察觉出异样之前，先一..."
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<from 0 to 2>audio/demo_audio/sound/zu3_nv_zou.ogg");
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.Scene("heilong_dating_bangwan_louti1");
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 2.71f)}, {"zoom", 0.55f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Transition(time:0.5f);
        Engine._history = false;
        yield return _gameMethods.OpenDialog(2249); // "{nw}{w=0.5}"
        Engine._history = true;
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian4_13a02456_1.ogg");
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
        yield return _gameMethods.OpenDialog(8661); // "博尔吉亚来过了？"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(8662); // "对啊。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei9", "yan17", "zui21"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(8663); // "不过，我叫他离开了。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan11", "zui7"});
        yield return _gameMethods.OpenDialog(8664); // "只不过是在和他的交谈结束之后。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui16", "emoji2"});
        yield return _gameMethods.OpenDialog(8665); // "……这也不算在撒谎对吧。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui19"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
        yield return _gameMethods.OpenDialog(226); // "{nw}{w=0.2}"
        Engine._history = true;
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian4_5f304563.ogg");
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(765); // "嗯。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan5", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8666); // "我一直观察着赫泽尔，他表情没有任何异样，似乎始终..."
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan6", "zui15"});
        yield return _gameMethods.OpenDialog(924); // "……？"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
        yield return _gameMethods.OpenDialog(8667); // "（没有察觉到我结盟的事情么？）"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(8668); // "难道是发现了后、隐而不发……？"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(8669); // "……不，赫泽尔不是这样的性格。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(8670); // "他的实力不需要他委曲求全，所以他也从不会这样做。"
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<from 0 to 2>audio/demo_audio/sound/zu3_nv_zou.ogg");
        yield return _gameMethods.Hide("he");
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(8671); // "既然如此，那事实就是…他的确没发现。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui3", "onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.67f}, {"alpha", 0.0f}, {"blur", 0.1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.OpenDialog(8672); // "哎呀，这是怎么回事呢？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui8", "onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_wu", parts: new List<string>{"mei7", "yan22", "zui15"});
        yield return _gameMethods.OpenDialog(8673); // "（你骗我？）"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei6", "yan4", "zui5", "onlayer", "forward"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
        yield return _gameMethods.OpenDialog(8674); // "「怎么能叫骗。{nw}{w=0.1}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan20", "zui4", "onlayer", "forward"});
        yield return _gameMethods.OpenDialog(8675); // "如果你和其他龙结盟，尼德霍格当然能发现。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui5", "onlayer", "forward"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(8676); // "只是我的权柄比较特殊，介于虚实之间，他感受不到也..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui8", "onlayer", "forward"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan10", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui6", "onlayer", "forward"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
        yield return _gameMethods.OpenDialog(8677); // "「况且，我之前又没有经验，{nw}{w=0.1}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13", "onlayer", "forward"});
        yield return _gameMethods.OpenDialog(8678); // "你还是第一个和我结盟的人类……不，生物呢。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui3", "onlayer", "forward"});
        yield return _gameMethods.OpenDialog(8679); // "我也是第一次面对这种情况呀。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui8", "onlayer", "forward"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei3", "yan24", "zui8", "emoji2"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8", "onlayer", "forward"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
        yield return _gameMethods.OpenDialog(8680); // "我确信了。他至少有一半是故意的。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui8", "onlayer", "forward"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei8", "yan11", "zui7", "onlayer", "forward"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei3", "yan12", "zui8", "emoji2"});
        yield return _gameMethods.OpenDialog(8681); // "这家伙就是那种喜欢捉弄人的恶趣味类型。 "
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}, {"blur", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 0.0f}, {"blur", 1.0f}})});
        yield return _gameMethods.OpenDialog(130); // "……………………"
        yield return _gameMethods.PlaySound("sounda1", 0.0f, 1.0f, "<from 0 to 2>audio/sound/jiaobusheng_xin_normal1.ogg");
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<silence 0.4>audio/demo_audio/sound/door_close1.mp3");
        yield return _gameMethods.Hide("nuo_heart_layered");
        yield return _gameMethods.Scene("woshi_nv4", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.47f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.TransitionBy("trans_rip_fast");
        yield return _gameMethods.EngineSetVolume(volume:0.3f, delay:2.0f, channelName:"music");
        yield return _gameMethods.OpenDialog(8682); // "在我的强烈抗议下，诺伯拉总算答应，除非得到许可，..."
        yield return _gameMethods.OpenDialog(8683); // "……不过，是否能够遵守，当然只能全靠他的自觉了。"
        yield return _gameMethods.PlaySound("soundb", 1.0f, 1.0f, "audio/demo_audio/sound/chong1.ogg");
        yield return _gameMethods.Scene("woshi_nv1_sky", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.47f}})});
        yield return _gameMethods.Show("woshi_nv1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.47f}})});
        yield return _gameMethods.Transition(time:0.8f);
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:5.0f);
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(8684); // "诺伯拉离开后，我开始思考下一步的打算。"
        yield return _gameMethods.Scene("woshi_nv_chuang1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.0f, 0.0f)}, {"pos", new Vector2(-24.0f, -66.0f)}, {"zoom", 0.42f}})});
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/demo_audio/sound/moca2.mp3");
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.PlaySound("music1", 3.0f, 0.7f, "audio/music/wenxin/wind1.mp3");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8685); // "冰霜与心灵之龙——这个巨大的变数加入到了我未来的..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan20", "zui15"});
        yield return _gameMethods.OpenDialog(8686); // "我该如何合理地运用这一机会呢？"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(8687); // "我非常了解这种三分钟热度的类型。{nw}{w=0..."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(8688); // "\n他们会在最初向感兴趣的对象燃烧出全部的热情。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(8689); // "在这段时间里，他将全心全意地把心神倾注在目标身上..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(8690); // "但这些很快会消散，因为他的兴趣会轻易地转移到其他..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15"});
        yield return _gameMethods.OpenDialog(8691); // "所以，我有两个可选择方案。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan7", "zui15"});
        yield return _gameMethods.OpenDialog(8692); // "一个是趁着他最初的热情期，抓住时机，套出能从他身..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8693); // "另一个，则是想办法延长他对我的兴趣与投入。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan10", "zui15"});
        yield return _gameMethods.OpenDialog(8694); // "毫无疑问，前者的可实施性会更高，{nw}{w=0..."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(8695); // "\n毕竟对于后者，一介人类想要挑战如此目标，未免..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15"});
        yield return _gameMethods.OpenDialog(8696); // "我已经过了会自命不凡的人生阶段了。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8697); // "说来幽默，被选为替代的人选，这件事竟然是我两辈子..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan20", "zui15"});
        yield return _gameMethods.OpenDialog(8698); // "…………不过，在那之前，还有一个更令我在意的疑点..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan18", "zui15"});
        yield return _gameMethods.OpenDialog(8699); // "为什么，在我讲故事时，诺伯拉并没有因为提前看到我..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8700); // "要知道，除非是百年经典，对于普通的故事来说，剧透..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(8701); // "……我开始回忆，当时发生的一切。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8702); // "这和往常我与他的交流有何不同？"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/moca1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -2.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 2.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0.0f}, {"parallel_1", true}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan25", "zui15"});
        yield return _gameMethods.OpenDialog(8703); // "………………啊。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"yoffset", 0.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8704); // "编故事时，由于所调取的都是前一世的回忆与故事资源..."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan6", "zui15"});
        yield return _gameMethods.OpenDialog(8705); // "所以，好像、大概……我潜意识中用的是上一世的语言..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan21", "zui15"});
        yield return _gameMethods.OpenDialog(8706); // "……难道关键点，就在这里？"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(8707); // "说起来，赫泽尔似乎说过，这个世界上一切语言和文字..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8708); // "而真言是魔法流通的原理、运行的规律。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8709); // "我的上一世是一个没有魔法的世界，很自然的，它的语..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8710); // "它同真言，大概是截然不同的两种东西，宛如正负空间..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui7"});
        yield return _gameMethods.OpenDialog(8711); // "……原来如此。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8712); // "如果事实果真如想象中那般乐观，{nw}{w=0...."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(8713); // "现在，我就掌握了不被诺伯拉窥探内心的奥秘。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan6", "zui7"});
        yield return _gameMethods.OpenDialog(8714); // "但，我也不能从此都用这种语言方式来思考，以此完全..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui7"});
        yield return _gameMethods.OpenDialog(8715); // "一方面，双语模式还是很难切换的。如果日常生活中频..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan20", "zui7"});
        yield return _gameMethods.OpenDialog(8716); // "另一方面，一个武器作为秘密武器时，才最有价值。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8717); // "此前，诺伯拉并未对我指出我脑中存在着一种他听不懂..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan12", "zui7"});
        yield return _gameMethods.OpenDialog(8718); // "……大概是想先不动声色，借此观察我无意间所泄露出..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8719); // "如果他倾向于不让我意识到这一点。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan8", "zui7"});
        yield return _gameMethods.OpenDialog(8720); // "——那么，我也可以利用这一点，假装没有察觉到。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan17", "zui7"});
        yield return _gameMethods.OpenDialog(8721); // "这样，在少数的关键时刻，我就可以在脑子里仔细地思..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan12", "zui7"});
        yield return _gameMethods.OpenDialog(8722); // "这时即便好奇，他也没有借口追问我在想什么。{nw..."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei8", "yan21", "zui7"});
        yield return _gameMethods.OpenDialog(8723); // "他要伪装出能一直正常地听到我心声的假象，绝不会提..."
        yield return _gameMethods.StopSound(channelName:"music1", fadeOut:6.0f);
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui19"});
        yield return _gameMethods.OpenDialog(8724); // "诺伯拉，你离开了吗？"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui7"});
        yield return _gameMethods.OpenDialog(8725); // "……没有回答。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan12", "zui11"});
        yield return _gameMethods.OpenDialog(8726); // "诺伯拉·博尔吉亚是否守信还是值得怀疑，简单试探一..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(8725); // "……没有回答。"
        yield return _gameMethods.PlaySound("music", 2.0f, 1.0f, "audio/demo_audio/music/richang1.mp3");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui7"});
        yield return _gameMethods.OpenDialog(8727); // "我稍微放下了心。"
        yield return _gameMethods.ChangeLabelTo("label_zhuxian4_1");
        yield break;
    }

    public IEnumerator label_bai_xinlingtongxun()
    {
        yield return _gameMethods.PlaySound("soundb", 0.0f, 1.0f, "audio/demo_audio/sound/niaoming.ogg");
        yield return _gameMethods.Scene("woshi_nv2_tian");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.TransitionBy("blink3");
        Defaults.Persistent.Jq_5_7 = 1;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(8728); // "第二天一醒，睁开眼睛，我愣了愣半天才适应过来。"
        yield return _gameMethods.Scene("woshi_nv_chuang", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"zoom", 0.41f}})});
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/manbu/Body1_02_duan.mp3");
        yield return _gameMethods.Transition(time:0.6f);
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(8729); // "感觉视野……好像更清晰了，听感也敏锐了许多。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan3", "zui15"});
        yield return _gameMethods.OpenDialog(8730); // "全部感官好像都变灵敏了。"
        yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:2.0f);
        yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/demo_audio/music/qingkuai4.mp3");
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/emeng_dajie/Body_up_01.mp3");
        yield return _gameMethods.Transition(time:0.6f);
        yield return _gameMethods.OpenDialog(8731); // "我飞速下床。"
        yield return _gameMethods.Scene("woshi_nv2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(1.05f, 1.05f)}})});
        yield return _gameMethods.Transition(time:0.6f);
        yield return _gameMethods.PlaySound("sounda", 0.0f, 2.0f, "audio/sound/houhui/Tight Face_02_duan.mp3");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15"});
        yield return _gameMethods.OpenDialog(8732); // "找到了房间里最大的重物——沙发，把它搬离了地面。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan9", "zui8", "emoji2"});
        yield return _gameMethods.OpenDialog(8733); // "……嗯，确定了。力量也变大了。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan18", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(8734); // "这就是结盟的效果？"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan11", "zui18"});
        yield return _gameMethods.OpenDialog(8735); // "……有点后悔怎么没有早点结盟。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui8"});
        yield return _gameMethods.OpenDialog(8736); // "上次诺伯拉自顾自到访的时候，如果我抓住机会早点看..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan12", "zui8"});
        yield return _gameMethods.OpenDialog(8737); // "悔不当初。"
        yield return _gameMethods.OpenDialog(8738); // "放心，现在结盟也不算太晚。"
        yield return _gameMethods.OpenDialog(8739); // "所以没什么好遗憾的。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_qian", parts: new List<string>{"mei7", "yan2", "zui2"});
        yield return _gameMethods.OpenDialog(8740); // "「好吧，"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan11", "zui2"});
        yield return _gameMethods.OpenDialog(8741); // "那就…………"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei4", "yan2", "zui8", "emoji2", "emoji12"});
        yield return _gameMethods.OpenDialog(8742); // "？！？！」"
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:2.0f);
        yield return _gameMethods.OpenDialog(8743); // "第二天了，能告诉我故事的后续了吗？"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0.0f}, {"parallel_1", true}})});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei5", "yan1", "zui8", "emoji2", "emoji3", "-emoji12"});
        yield return _gameMethods.OpenDialog(8744); // "……？？？"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.5f, "audio/sound/manbu/Body1_02_duan.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(0.0f, 0.0f)}, {"xoffset", 0.0f}, {"yoffset", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.35f}, {"pos", new Vector2(1182.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.4f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.76f}, {"pos", new Vector2(822.0f, -324.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.2f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.2f}, {"pos", new Vector2(156.0f, -66.0f)}})});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei5", "yan3", "zui15", "emoji2", "-emoji3"});
        yield return _gameMethods.OpenDialog(8745); // "被吓了一跳，{nw}{w=0.1}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei5", "yan7", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(8746); // "我环视四周，却没看到半个人影。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei3", "yan18", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(8747); // "……刚刚的声音貌似有点耳熟。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan7", "zui10", "emoji2"});
        yield return _gameMethods.OpenDialog(8748); // "诺伯拉？"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(156.0f, -66.0f)}})});
        yield return _gameMethods.PlaySound("music1", 2.0f, 1.0f, "audio/demo_audio/music/time_syuanji.mp3");
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui8", "onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.67f}, {"alpha", 0.0f}, {"blur", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui3", "onlayer", "forward"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian", parts: new List<string>{"mei7", "yan7", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(8749); // "「呀——居然立刻认出我了，{nw}{w=0.1}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui2", "onlayer", "forward"});
        yield return _gameMethods.OpenDialog(8750); // "真开心。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8", "onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan24", "zui10", "-emoji2"});
        yield return _gameMethods.OpenDialog(8751); // "你在哪里？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui8", "onlayer", "forward"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13", "onlayer", "forward"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
        yield return _gameMethods.OpenDialog(8752); // "「潜意识之海。{nw}{w=0.1}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan20", "zui13", "onlayer", "forward"});
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan24", "zui15"});
        yield return _gameMethods.OpenDialog(8753); // "这里位于大陆极北，存在于虚实的交界之际。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan20", "zui8", "onlayer", "forward"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan2", "zui10"});
        yield return _gameMethods.OpenDialog(8754); // "听起来离这里很远。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13", "onlayer", "forward"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(2654); // "是呀。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui14", "onlayer", "forward"});
        yield return _gameMethods.OpenDialog(8755); // "你和我结盟，就在潜意识之海里定下了锚点。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13", "onlayer", "forward"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(8756); // "我找到你的位置，就可以直接通过心声来交流啦。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui8", "onlayer", "forward"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei3", "yan2", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei3", "yan10", "zui15", "emoji2", "emoji12"});
        yield return _gameMethods.OpenDialog(165); // "？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui8", "onlayer", "forward"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei4", "yan22", "zui7", "emoji2", "emoji3", "-emoji12"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui8", "onlayer", "forward"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
        yield return _gameMethods.OpenDialog(5087); // "？？？"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei4", "yan22", "zui7", "-emoji2", "emoji3"});
        yield return _gameMethods.OpenDialog(8757); // "总感觉好像被什么令人烦恼的事情缠上了。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui8", "onlayer", "forward"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei5", "yan12", "zui13", "emoji2", "emoji5", "emoji6", "-emoji3"});
        yield return _gameMethods.OpenDialog(8758); // "不要啊，这世上还有没有一片能让人类安静休憩的心灵..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui13", "onlayer", "forward"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian", parts: new List<string>{"mei5", "yan12", "zui18", "emoji2", "emoji5", "emoji6"});
        yield return _gameMethods.OpenDialog(8759); // "「放心，你的灵魂十分特殊。{nw}{w=0.1}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan10", "zui5", "onlayer", "forward"});
        yield return _gameMethods.OpenDialog(8760); // "我的能力在你身上似乎折半，时灵时不灵的。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui4", "onlayer", "forward"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian", parts: new List<string>{"mei8", "yan5", "zui15", "emoji2", "-emoji5", "emoji6"});
        yield return _gameMethods.OpenDialog(8761); // "「况且，我也有其他的事要做，{nw}{w=0.1..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui13", "onlayer", "forward"});
        yield return _gameMethods.OpenDialog(8762); // "可不会一天二十四小时看着你哦。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui8", "onlayer", "forward"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei8", "yan5", "zui15", "-emoji2", "-emoji6"});
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui8", "onlayer", "forward"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei3", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(8763); // "……好吧，有获得，就要支付代价。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
        yield return _gameMethods.OpenDialog(8764); // "等价交换，这很公平。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan20", "zui8", "onlayer", "forward"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei8", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(8765); // "虽然这个代价是否合理，还有待商榷。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui8", "onlayer", "forward"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(8766); // "既然现实已成，就只能暂且接受、再慢慢想办法了。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui8", "onlayer", "forward"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_qian", parts: new List<string>{"mei8", "yan3", "zui10"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui8", "onlayer", "forward"});
        yield return _gameMethods.OpenDialog(8767); // "我和别的龙结盟，不会被赫泽尔发现吧？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan14", "zui8", "onlayer", "forward"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei8", "yan3", "zui15"});
        yield return _gameMethods.OpenDialog(8768); // "我有点担心。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(8769); // "他鼻子那么灵敏。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui3", "onlayer", "forward"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(8770); // "「当然——{nw}{w=0.1}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui13", "onlayer", "forward"});
        yield return _gameMethods.OpenDialog(8771); // " 会。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan20", "zui16", "onlayer", "forward"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(8772); // "而且，多半会反应激烈吧。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei8", "yan2", "zui3", "onlayer", "forward"});
        yield return _gameMethods.OpenDialog(8773); // "你要怎么向他解释呢？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei8", "yan2", "zui8", "onlayer", "forward"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei3", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei8", "yan11", "zui8", "onlayer", "forward"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei3", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(8774); // "虽然我得到了一定的力量、但却丧失了极大的自由。"
        Defaults.Persistent.Jq_6_2 = 1;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei3", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(8775); // "本来被人随意翻阅大脑就已经够令我烦闷了，{nw}..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei8", "yan1", "zui8", "onlayer", "forward"});
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan21", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei8", "yan11", "zui8", "onlayer", "forward"});
        yield return _gameMethods.OpenDialog(8776); // "他口吻中一副“真令人期待啊”的等着看热闹的模样，..."
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei3", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(8777); // "那就要让你失望了。因为我根本不需要解释。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan4", "zui9", "onlayer", "forward"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei4", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(8778); // "我这样的弱者，在你们眼里本来就是任由摆布的蚂蚁。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan4", "zui9", "onlayer", "forward"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_qian", parts: new List<string>{"mei4", "yan17", "zui19"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan4", "zui9", "onlayer", "forward"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_qian");
        yield return _gameMethods.OpenDialog(8779); // "「如果被强加了什么，也一定不是出于自己的意志，{..."
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei4", "yan11", "zui2"});
        yield return _gameMethods.OpenDialog(8780); // "难道弱者还有选择的权利嘛。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei6", "yan20", "zui4", "onlayer", "forward"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian", parts: new List<string>{"mei4", "yan11", "zui7"});
        yield return _gameMethods.OpenDialog(8781); // "「真是冤枉呀，公主殿下，{nw}{w=0.1}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei5", "yan7", "zui5", "onlayer", "forward"});
        yield return _gameMethods.OpenDialog(8782); // "我怎么会忍心强迫你呢。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei5", "yan7", "zui9", "onlayer", "forward"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei3", "yan21", "zui2"});
        yield return _gameMethods.OpenDialog(8783); // "真的吗？"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_qian", parts: new List<string>{"mei3", "yan12", "zui2"});
        yield return _gameMethods.OpenDialog(8784); // "「你听我的心声，总不是我主动邀请的吧。{nw}{..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei5", "yan1", "zui9", "onlayer", "forward"});
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan2", "zui19"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei5", "yan7", "zui9", "onlayer", "forward"});
        yield return _gameMethods.OpenDialog(8785); // "如果我现在要求你退出去，你会离开吗。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan20", "zui10", "onlayer", "forward"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian", parts: new List<string>{"mei3", "yan2", "zui7"});
        yield return _gameMethods.OpenDialog(3756); // "「嗯——{nw}{w=0.1}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui6", "onlayer", "forward"});
        yield return _gameMethods.OpenDialog(2568); // "不行，{nw}{w=0.1}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui13", "onlayer", "forward"});
        yield return _gameMethods.OpenDialog(8786); // "因为实在是太有趣了。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8", "onlayer", "forward"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei3", "yan8", "zui6"});
        yield return _gameMethods.OpenDialog(8787); // "这不就是了。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_qian", parts: new List<string>{"mei8", "yan12", "zui10"});
        yield return _gameMethods.OpenDialog(8788); // "「况且，你怎么做不重要，"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei8", "yan17", "zui11"});
        yield return _gameMethods.OpenDialog(8789); // "重要的是赫泽尔会怎么想就够了。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui8", "onlayer", "forward"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_qian");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui8", "onlayer", "forward"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei3", "yan22", "zui2"});
        yield return _gameMethods.OpenDialog(8790); // "你没听说过“疏不间亲”吗？"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei3", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(8791); // "所以很抱歉，你是看不到想看的场景的。"
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei3", "yan11", "zui7"});
        yield return _gameMethods.OpenDialog(8792); // "他倒是一点没生气。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui3", "onlayer", "forward"});
        yield return _gameMethods.OpenDialog(8793); // "呵呵，真精彩。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui8", "onlayer", "forward"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei3", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13", "onlayer", "forward"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
        yield return _gameMethods.OpenDialog(8794); // "「好啦，为了讨你高兴，{nw}{w=0.1}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan10", "zui5", "onlayer", "forward"});
        yield return _gameMethods.OpenDialog(8795); // "那么，{nw}{w=0.1}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13", "onlayer", "forward"});
        yield return _gameMethods.OpenDialog(8796); // "你看这份礼物可以吗？」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui14", "onlayer", "forward"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei3", "yan20", "zui15"});
        yield return _gameMethods.OpenDialog(8797); // "——龙并非强大到无敌。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13", "onlayer", "forward"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei8", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(8798); // "通过少数手段可以使其无力。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui8", "onlayer", "forward"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei4", "yan2", "zui10"});
        yield return _gameMethods.OpenDialog(8799); // "…………我承认我刚刚说话大声了一点。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei2", "yan2", "zui15", "onlayer", "forward"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei4", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(226); // "{nw}{w=0.2}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei11", "yan11", "zui8", "onlayer", "forward"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
        yield return _gameMethods.OpenDialog(8800); // "我恳切地说。"
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei4", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(8801); // "要不你再惹我多生两次气吧，我还想听听龙族其他的弱..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui3", "onlayer", "forward"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei4", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(8802); // "哎呀，我可不舍得惹小公主再发火。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui7", "onlayer", "forward"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei3", "yan6", "zui17"});
        yield return _gameMethods.OpenDialog(8803); // "……嘁。"
        yield return _gameMethods.Show("black", parts: new List<string>{"onlayer", "forward"});
        yield return _gameMethods.Transition(time:0.6f);
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.EngineSetVolume(volume:0.3f, delay:2.0f, channelName:"music1");
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}, {"blur", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 0.0f}, {"blur", 1.0f}})});
        yield return _gameMethods.OpenDialog(8804); // "不管发生什么，一日三餐总还是雷打不动要吃的。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 2>audio/sound/jiaobusheng_xin_normal1.ogg");
        yield return _gameMethods.Hide("nuo_heart_layered");
        yield return _gameMethods.Scene("heilong_chufang_baitian_man", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.71f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Hide("black");
        yield return _gameMethods.TransitionBy("trans_rip_fast");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui7"});
        yield return _gameMethods.OpenDialog(8805); // "平复好心情后，我去厨房做饭。"
        yield return _gameMethods.PlaySound("sounda", 1.0f, 0.6f, "audio/sound/grilling2_01.mp3");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui7"});
        yield return _gameMethods.OpenDialog(8806); // "在我煎鸡蛋培根的过程中，诺伯拉一直在脑海中点评。"
        yield return _gameMethods.EngineSetVolume(volume:1.0f, delay:1.0f, channelName:"music1");
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan4", "zui5", "onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.67f}, {"alpha", 0.0f}, {"blur", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
        yield return _gameMethods.OpenDialog(8807); // "「居然是自己动手做早餐吗？{nw}{w=0.1}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui4", "onlayer", "forward"});
        yield return _gameMethods.OpenDialog(8808); // "太可怜了。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui9", "onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei3", "yan21", "zui7"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.PlaySound("sounda1", 0.0f, 3.0f, "audio/demo_audio/sound/canpanpengzhuang2_duan.mp3");
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_wu", parts: new List<string>{"mei4", "yan12", "zui7"});
        yield return _gameMethods.OpenDialog(8809); // "（你懂什么，劳动最光荣！）"
        yield return _gameMethods.Show("black", parts: new List<string>{"onlayer", "forward"});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.Hide("black");
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui3", "onlayer", "forward"});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian", parts: new List<string>{"mei3", "yan9", "zui15"});
        yield return _gameMethods.OpenDialog(8810); // "「看起来很可口嘛，{nw}{w=0.1}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui2", "onlayer", "forward"});
        yield return _gameMethods.OpenDialog(8811); // "公主殿下还有这样的手艺。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8", "onlayer", "forward"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan7", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_wu", parts: new List<string>{"mei7", "yan9", "zui7"});
        yield return _gameMethods.OpenDialog(8812); // "（嗯，这话倒是事实。）"
        yield return _gameMethods.Show("black", parts: new List<string>{"onlayer", "forward"});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.Hide("black");
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei6", "yan7", "zui13", "onlayer", "forward"});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(8813); // "明明刚刚还心情不佳，只是吃了份早餐，就转阴为晴了..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei6", "yan1", "zui14", "onlayer", "forward"});
        yield return _gameMethods.OpenDialog(8814); // "小公主真是容易满足呀。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei6", "yan11", "zui8", "onlayer", "forward"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei3", "yan11", "zui8", "emoji11"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.PlaySound("sound", 0.2f, 0.4f, "audio/demo_audio/sound/moca2.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0.0f}, {"parallel_1", true}})});
        yield return _gameMethods.OpenDialog(8815); // "（知足常乐，你懂什么！）"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"yoffset", 0.0f}})});
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}, {"blur", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 0.0f}, {"blur", 1.0f}})});
        yield return _gameMethods.Show("black");
        yield return _gameMethods.Transition(time:0.5f);
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.OpenDialog(8816); // "……一顿饭下来，我感觉自己像是一个身不由己，被迫..."
        yield return _gameMethods.Hide("nuo_heart_layered");
        yield return _gameMethods.OpenDialog(8817); // "为此，我决定充分利用一下他的劳动价值。"
        yield return _gameMethods.Scene("heilong_shufang_baitian_shugui", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.0f)}, {"zoom", 0.71f}})});
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<from 0 to 1.5>audio/sound/jiaobusheng_xin_normal1.ogg");
        yield return _gameMethods.TransitionBy("trans_rip_fast");
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei3", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(8818); // "你会真言么？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui5", "onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.67f}, {"alpha", 0.0f}, {"blur", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei3", "yan11", "zui7"});
        yield return _gameMethods.OpenDialog(8819); // "嗯？当然。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui9", "onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei1", "yan2", "zui11"});
        yield return _gameMethods.OpenDialog(8820); // "不愧是博学多识的诺伯拉大人，请教教我吧。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui13", "onlayer", "forward"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei1", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(8821); // "好呀，我很乐意。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui8", "onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}, {"blur", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 0.0f}, {"blur", 1.0f}})});
        yield return _gameMethods.StopSound(channelName:"music1", fadeOut:4.0f);
        yield return _gameMethods.OpenDialog(33); // "………………"
        yield return _gameMethods.PlaySound("music", 4.0f, 1.0f, "audio/demo_audio/music/richang1.mp3");
        yield return _gameMethods.Hide("nuo_heart_layered");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan6", "zui15"});
        yield return _gameMethods.OpenDialog(8822); // "令人意外的是，诺伯拉竟然是一个不错的老师。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(8823); // "比起得天独厚、无法理解别人愚钝之处的赫泽尔，诺伯..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan12", "zui7"});
        yield return _gameMethods.OpenDialog(8824); // "一个上午结束，我获益匪浅。"
        yield return _gameMethods.ChangeLabelTo("label_zhuxian4");
        yield break;
    }

    public IEnumerator label_bai_about_BlackDragon()
    {
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.Hide("shuben");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Transition(time:0.3f);
        yield return _gameMethods.OpenDialog(33); // "………………"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1.5>audio/sound/jiaobusheng_xin_normal1.ogg");
        yield return _gameMethods.Scene("zoulang_guodao1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.1f)}, {"zoom", 0.61f}})});
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(8825); // "离开书房后，之前一直消停安静的诺伯拉突然出声 。"
        yield return _gameMethods.PlaySound("music2", 3.0f, 0.9f, "audio/demo_audio/music/richang1.mp3");
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.67f}, {"alpha", 0.0f}, {"blur", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.OpenDialog(8826); // "你对尼德霍格的态度真有趣。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(197); // "哪里？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui4"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(8827); // "现在，他左右着你的生命，并且，注定带走你的未来。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan12", "zui10"});
        yield return _gameMethods.OpenDialog(8828); // "是啊，能不能说点我不知道的新鲜事……"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan12", "zui14"});
        yield return _gameMethods.OpenDialog(8829); // "所以，你应该要么憎恨并恐惧他。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui4"});
        yield return _gameMethods.OpenDialog(8830); // "要么彻底支持他，全心全意地去崇拜，爱他，乞求他的..."
        yield return _gameMethods.StopSound(channelName:"music2", fadeOut:5.0f);
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan5", "zui14"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.OpenSelectMenu(
            talk: new List<string>{"-你怎么知道我不憎恨他？", "-没有人可以做我的主人"},
            jump: new List<string>{"label_bai_menu_0_u_NfL9wY", "label_bai_menu_0_ED8d6tJV"},
            condition: new List<string>{"NONE", "NONE"}
        );
    }

    public IEnumerator label_zhuxian5_choice3()
    {
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.OpenDialog(8838); // "无论如何，你的反应都称得上奇怪了。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui14"});
        yield return _gameMethods.OpenDialog(8839); // "你怎么能是在心中调侃他？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan9", "zui3"});
        yield return _gameMethods.OpenDialog(8840); // "奇怪吗、哈哈。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_wu", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(8841); // "（毕竟，除此之外，还能怎么办呢。）"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei1", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(8842); // "被生活搓圆捏扁时，即便哭也换不来谁的同情或拯救。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan21", "zui15"});
        yield return _gameMethods.OpenDialog(8843); // "我们这些普通人，也唯有擦干眼泪，爬起来，冲它吐下..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui12"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei1", "yan8", "zui7"});
        yield return _gameMethods.OpenDialog(8844); // "像个小丑一样，对自己开开玩笑。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei1", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(8845); // "我所面临的困难，连同自己的渺小，好像一切都没什么..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(8846); // "不过，就算是渺小的蚂蚁，如果还有一丝的机会，我依..."
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 3;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei3", "yan20", "zui15"});
        yield return _gameMethods.OpenDialog(8847); // "无论是要忍受艰辛，抑或是以一种在上位者看来会狼狈..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan20", "zui8"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
        yield return _gameMethods.OpenDialog(8848); // "「真是令人动容的闪光，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui14"});
        yield return _gameMethods.OpenDialog(8849); // "人类最让我喜欢的地方就在于此。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui13"});
        yield return _gameMethods.OpenDialog(8850); // "明明没有胜算，却还要侥幸挣扎。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui17"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei3", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(8851); // "你能走到什么地步呢？我很期待。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei4", "yan4", "zui20"});
        yield return _gameMethods.OpenDialog(8852); // "……真是隔岸观火的语气啊。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei6", "yan7", "zui5"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei5", "yan4", "zui15"});
        yield return _gameMethods.OpenDialog(8853); // "怎么会？我可是站在你这边的。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei6", "yan7", "zui12"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_qian", parts: new List<string>{"mei5", "yan12", "zui2"});
        yield return _gameMethods.OpenDialog(8854); // "「是啊……{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei5", "yan5", "zui2"});
        yield return _gameMethods.OpenDialog(8855); // "但是，一切都要靠我自己努力。对吧。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian", parts: new List<string>{"mei5", "yan5", "zui6"});
        yield return _gameMethods.OpenDialog(6178); // "「呵呵……{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui14"});
        yield return _gameMethods.OpenDialog(8856); // "我相信，像你这样无论在任何境地下都懂得为自己争取..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.OpenDialog(8857); // "永远不会把决定命运的权力让给别人。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui3"});
        yield return _gameMethods.OpenDialog(7056); // "对吗？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei6", "yan5", "zui5"});
        yield return _gameMethods.OpenDialog(8858); // "他那副玩世不恭、对接下来的发展翘首以待的语气，令..."
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei4", "yan8", "zui20"});
        yield return _gameMethods.OpenDialog(8859); // "是啊，我知道规矩。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei4", "yan8", "zui7"});
        yield return _gameMethods.OpenDialog(8860); // "自己的命，永远不要指望靠别人帮忙做主。"
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.PlaySound("soundb", 0.0f, 1.0f, "audio/sound/jiaobusheng_xin_normal1.ogg");
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.OpenDialog(8861); // "谈话告一段落，我走向了通往厨房的路。"
        yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:1.0f);
        yield return _gameMethods.Show("heilong_chufang_baitian_man", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}, {"pos", new Vector2(0.0f, 0.0f)}, {"zoom", 0.71f}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1.0f}})});
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui5"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.67f}, {"alpha", 0.0f}, {"blur", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(8862); // "不回卧室么。你打算做什么？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui12"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.Show("heilong_chufang_baitian_man", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan2", "zui10"});
        yield return _gameMethods.OpenDialog(8863); // "做点好吃的。"
        yield return _gameMethods.Show("nuo_heart_layered", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"alpha", 0.0f}, {"blur", 0.1f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(8864); // "我要把自己哄开心。"
        yield return _gameMethods.Hide("nuo_heart_layered");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("heilong_chufang_baitian_man1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}, {"pos", new Vector2(0.0f, 0.0f)}, {"zoom", 0.71f}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15"});
        yield return _gameMethods.OpenDialog(8865); // "我烤了一份黄油饼干，做成喜欢的形状，洗了些色彩缤..."
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/canpanpengzhuang2_duan.mp3");
        yield return _gameMethods.Show("heilong_chufang_baitian_man1", parts: new List<string>{"at", "default", "as", "heilong_chufang_baitian_man12"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.0f, 0.0f)}, {"pos", new Vector2(-678.0f, -492.0f)}, {"zoom", 1.37f}, {"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui8"});
        yield return _gameMethods.OpenDialog(8866); // "把它们摆在漂亮的杯碟里，端正地放置到桌子上。"
        yield return _gameMethods.Show("heilong_chufang_baitian_man1", parts: new List<string>{"as", "heilong_chufang_baitian_man12"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"yan5", "zui8"});
        yield return _gameMethods.OpenDialog(8867); // "欣赏了一会儿自己的杰作，{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan12", "zui8", "emoji7"});
        yield return _gameMethods.OpenDialog(8868); // "在心里说“我要开动了”。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan2", "zui7", "emoji7"});
        yield return _gameMethods.OpenDialog(8869); // "然后全神贯注地投入进对这份美食的感受里。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan12", "zui21", "emoji14", "emoji15", "-emoji7"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui21"});
        yield return _gameMethods.OpenDialog(8870); // "甜味漫到舌尖的味蕾。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui21", "emoji9"});
        yield return _gameMethods.OpenDialog(8871); // "伴随食物进入肚子，空落的心好像也随着胃袋一起被填..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8872); // "我品味着这美味而微薄的幸福。"
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui8", "emoji9", "emoji15"});
        yield return _gameMethods.OpenDialog(8873); // "……嗯，原谅世界一秒钟。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui14"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.67f}, {"alpha", 0.0f}, {"blur", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
        yield return _gameMethods.OpenDialog(8874); // "「呵呵……所以，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.OpenDialog(8875); // "这就让你变开心了么，小公主？」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan12", "zui21", "-emoji9", "emoji15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui14"});
        yield return _gameMethods.OpenDialog(8876); // "唉——"
        yield return _gameMethods.OpenDialog(8877); // "该说你是脆弱好，还是坚强好呢？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan20", "zui21", "-emoji14", "emoji15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai1");
        yield return _gameMethods.OpenDialog(8878); // "我充耳不闻，专心享受。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan20", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai1");
        yield return _gameMethods.OpenDialog(8879); // "不知是明白了我不会回答，还是感到无趣索性离开了，..."
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:10.0f);
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.ChangeLabelTo("label_dulishi_gongtong");
    }

    public IEnumerator label_bai_jieji()
    {
        yield return _gameMethods.PlaySound("soundb", 1.0f, 1.0f, "audio/demo_audio/sound/chanming.ogg");
        yield return _gameMethods.Scene("tiankong_baitian");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.StopEngineTime(time:0.7f);
        yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:2.0f);
        yield return _gameMethods.PlaySound("soundc", 1.0f, 1.0f, "audio/demo_audio/sound/yu1.ogg");
        yield return _gameMethods.Scene("senlin2");
        yield return _gameMethods.Show("rain_1");
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(8880); // "夏天匆匆过去，十月带走了最后一分暑气。"
        Defaults.Persistent.Jq_7_1 = 1;
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 3;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.OpenDialog(8881); // "这几个月来，我差不多已经熟悉了与诺伯拉共存的生活..."
        yield return _gameMethods.OpenDialog(8882); // "不管实际上如何，至少他将表面功夫做得很足，从未在..."
        yield return _gameMethods.Show("rain_1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.8f}, {"alpha", 0.0f}})});
        yield return _gameMethods.StopSound(channelName:"soundc", fadeOut:4.0f);
        yield return _gameMethods.OpenDialog(8883); // "……于是，适应了现状后，我的心思再次活泛起来，思..."
        yield return _gameMethods.StopSound(channelName:"music1", fadeOut:2.0f);
        yield return _gameMethods.Scene("woshi_nv2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"ypos", 1.06f}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.56f}, {"xpos", 0.5f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Transition(time:0.8f);
        yield return _gameMethods.OpenDialog(8884); // "某天，我给诺伯拉讲完了最新的故事连载。"
        yield return _gameMethods.PlaySound("music", 2.0f, 0.8f, "audio/music/bing_richang1.mp3");
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui16"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.67f}, {"alpha", 0.0f}, {"blur", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(8885); // "你是说，矮人所发明的蒸汽机得到推广后，实现了与魔..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.OpenDialog(8886); // "而且，不需要任何魔力门槛。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(3621); // "是啊。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan24", "zui19"});
        yield return _gameMethods.OpenDialog(8887); // "故事嘛，我幻想的。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan24", "zui6"});
        yield return _gameMethods.OpenDialog(8888); // "谁知道能不能实现，毕竟都不清楚这个世界的物理法则..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui1"});
        yield return _gameMethods.OpenDialog(8889); // "那么你幻想的这个世界，细节很丰富呢。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei3", "yan5", "zui19", "emoji7"});
        yield return _gameMethods.OpenDialog(8890); // "其实我的想象力还挺丰富的哦。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui3"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei3", "yan2", "zui8", "emoji7"});
        yield return _gameMethods.OpenDialog(8891); // "呵呵，感受到了。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei3", "yan2", "zui8", "-emoji7"});
        yield return _gameMethods.OpenDialog(8892); // "这个想法很有趣，或许以后可以试试。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei3", "yan8", "zui19"});
        yield return _gameMethods.OpenDialog(8893); // "嗯，好呀。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan2", "zui11"});
        yield return _gameMethods.OpenDialog(8894); // "话说——"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(8895); // "总是我在给你讲故事，你也该讲点什么给我听听吧？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui12"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_qian");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui12"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(8896); // "你应该创造过很多故事才对。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian", parts: new List<string>{"mei7", "yan2", "zui7"});
        yield return _gameMethods.OpenDialog(8897); // "「哦——所以，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui6"});
        yield return _gameMethods.OpenDialog(8898); // "你是打算用这种方法了解我，{nw}{w=0.01..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui14"});
        yield return _gameMethods.OpenDialog(8899); // "然后找机会攻下我？」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_qian", parts: new List<string>{"mei8", "yan10", "zui19", "emoji2"});
        yield return _gameMethods.OpenDialog(8900); // "「……不是、"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei8", "yan24", "zui19", "emoji2"});
        yield return _gameMethods.OpenDialog(8901); // "没有，"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan12", "zui8", "emoji2"});
        yield return _gameMethods.OpenDialog(8902); // "别乱说。」"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei4", "yan17", "zui19", "emoji2"});
        yield return _gameMethods.OpenDialog(8903); // "你高看我了！"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei3", "yan11", "zui19", "emoji2"});
        yield return _gameMethods.OpenDialog(8904); // "就算攻下，也该是你攻下我吧。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_qian", parts: new List<string>{"mei7", "yan21", "zui11", "-emoji2"});
        yield return _gameMethods.OpenDialog(8905); // "「我的力量如此弱小，{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan21", "zui11"});
        yield return _gameMethods.OpenDialog(8906); // "怎么可能对你造成威胁。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui3"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan21", "zui15"});
        yield return _gameMethods.OpenDialog(8907); // "呵呵，谁知道呢。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
        yield return _gameMethods.OpenDialog(8908); // "「毕竟我们的公主看起来如此可爱，{nw}{w=0..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui1"});
        yield return _gameMethods.OpenDialog(8909); // "其实却十分狡猾呢。 」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/moca1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0.0f}, {"parallel_1", true}})});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan2", "zui11"});
        yield return _gameMethods.OpenDialog(8910); // "真是冤枉。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"yoffset", 0.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan11", "zui2"});
        yield return _gameMethods.OpenDialog(8911); // "只是，我觉得你应该了解一下，另一种能让你享受到更..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan2", "zui7"});
        yield return _gameMethods.OpenDialog(8912); // "嗯——比如？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan2", "zui10"});
        yield return _gameMethods.OpenDialog(8913); // "你以前经常会化身为人类，进入到我们的社会中，去游..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(8914); // "没错～"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui8"});
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(8915); // "而且，每开始一段新的游戏历程之前，你是不是还喜欢..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei8", "yan4", "zui12"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(6456); // "「……{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei8", "yan2", "zui3"});
        yield return _gameMethods.OpenDialog(8916); // "你真了解我。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei8", "yan11", "zui14"});
        yield return _gameMethods.OpenDialog(8917); // "我们的脾性果然很相投呢。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei8", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei8", "yan24", "zui16"});
        yield return _gameMethods.OpenDialog(8918); // "……呵呵，你这种追求新鲜感的角色，{nw}{w=..."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan12", "zui8"});
        yield return _gameMethods.OpenDialog(8919); // "我见得多了。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan2", "zui2"});
        yield return _gameMethods.OpenDialog(8920); // "那么，一般情况下，你在人类社会的一个“剧本”中，..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan2", "zui7"});
        yield return _gameMethods.OpenDialog(8921); // "少至几月或半年，多至两三年吧。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan5", "zui11"});
        yield return _gameMethods.OpenDialog(8922); // "这么短吗？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(8923); // "跨度长达十多年的情况也有过，但中途我会离开，定期..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(8924); // "因为，那些人很快会变得如出一辙，千遍一律。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui14"});
        yield return _gameMethods.OpenDialog(8925); // "我比较缺乏耐心嘛。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan18", "zui6", "emoji2"});
        yield return _gameMethods.OpenDialog(8926); // "还挺有自知之明的。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei1", "yan2", "zui15"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
        yield return _gameMethods.OpenDialog(6456); // "「……{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei1", "yan11", "zui8"});
        yield return _gameMethods.OpenDialog(1265); // "……」"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan3", "zui10", "-emoji2"});
        yield return _gameMethods.OpenDialog(8927); // "你看，问题就出在这里。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan17", "zui10"});
        yield return _gameMethods.OpenDialog(8928); // "你总是在快速地消耗完新鲜感后就离开。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei8", "yan12", "zui10"});
        yield return _gameMethods.OpenDialog(8929); // "但，实际上，是你在某一事物上花费的时间，才使它对..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei8", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(3904); // "哦？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_qian", parts: new List<string>{"mei7", "yan2", "zui10"});
        yield return _gameMethods.OpenDialog(8930); // "「如果不付出时间和精力去深入地了解、照顾某件事物..."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan6", "zui10"});
        yield return _gameMethods.OpenDialog(8931); // "它对你就和世界上的其他事物没有不同。」"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei1", "yan2", "zui10"});
        yield return _gameMethods.OpenDialog(8932); // "这个世界于你而言，也就是单调空虚的。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan9", "zui5"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(8933); // "「可事实上，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui14"});
        yield return _gameMethods.OpenDialog(8934); // "他们就是没有不同呀。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan6", "zui6", "emoji2"});
        yield return _gameMethods.OpenDialog(8935); // "……你是真的油盐不进啊。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei4", "yan2", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan2", "zui11", "-emoji2"});
        yield return _gameMethods.OpenDialog(8936); // "能不能具体展开说说？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei4", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(8937); // "我诚恳地问，为了说服他而绞尽脑汁、虚心请教。"
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:3.0f);
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan14", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
        yield return _gameMethods.OpenDialog(8938); // "「从哪里说起呢？{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui14"});
        yield return _gameMethods.OpenDialog(8939); // "比如王城吧。」"
        yield return _gameMethods.PlaySound("music1", 1.0f, 1.0f, "audio/music/wenxin/wind1.mp3");
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.OpenDialog(8940); // "你会发现，以不同身份进入社交场合，会被分门别类，..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui13"});
        yield return _gameMethods.OpenDialog(8941); // "贵族们面对不同地位和身份的人时，都经过了特定的训..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei3", "yan8", "zui10"});
        yield return _gameMethods.OpenDialog(8942); // "……有这么绝对吗？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui3"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei3", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(8943); // "毕竟没有训练完成的人，通常是不会出现在社交场上的..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui18"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(8944); // "在童年时代，许多人或许还能残留一些天性。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
        yield return _gameMethods.OpenDialog(8945); // "「但随着年龄增长，他们便会被环境改造，越来越接近..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui4"});
        yield return _gameMethods.OpenDialog(8946); // "思想趋于同质化，每个人的行为和选择都变得可以预测..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui6"});
        yield return _gameMethods.OpenDialog(8947); // "最终，无趣透顶，令人失望。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui12"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei3", "yan12", "zui12", "emoji2"});
        yield return _gameMethods.OpenDialog(8948); // "也不至于就同质化到这种程度吧……"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei3", "yan8", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(8949); // "我不甘心地挣扎。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei3", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(8950); // "嗯——小公主。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan19", "zui4"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian", parts: new List<string>{"mei3", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(8951); // "「这世上支配着人类的事物不计其数，{nw}{w=..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui6"});
        yield return _gameMethods.OpenDialog(8952); // "但归根结底都只源于两种动力。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui3"});
        yield return _gameMethods.OpenDialog(8953); // "你觉得那是什么？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui8"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_qian", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_qian", parts: new List<string>{"mei7", "yan2", "zui9"});
        yield return _gameMethods.OpenDialog(8954); // "「恐惧，"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan3", "zui10"});
        yield return _gameMethods.OpenDialog(8955); // "以及欲望？」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan3", "zui15"});
        yield return _gameMethods.OpenDialog(8956); // "没错——真聪明~"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(8957); // "那么，小公主。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
        yield return _gameMethods.OpenDialog(8958); // "「假设现在，你第一次现身于社交场合。{nw}{w..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui1"});
        yield return _gameMethods.OpenDialog(8959); // "所有人都热情地簇围上来，试图打探你的信息，暗中评..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(8960); // "他们发现我是平民。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(8961); // "「他们发觉你是平民，而且没有财富、权力，或强大的..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan20", "zui13"});
        yield return _gameMethods.OpenDialog(8962); // "很快就对你视而不见，如同对待空气，或微不足道的蝼..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan20", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan6", "zui10"});
        yield return _gameMethods.OpenDialog(8963); // "如果我有利用价值？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian", parts: new List<string>{"mei7", "yan6", "zui15"});
        yield return _gameMethods.OpenDialog(8964); // "「那他们就会维持着表面上的彬彬有礼，同时用尽手段..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei3", "yan10", "zui8", "emoji2"});
        yield return _gameMethods.OpenDialog(8965); // "“社会经验很丰富啊。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei3", "yan12", "zui8", "emoji2"});
        yield return _gameMethods.OpenDialog(8966); // "这一套总结得挺全面。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan5", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
        yield return _gameMethods.OpenDialog(8967); // "虽然我们在谈的是“我”，但我知道，这都是谁的经验..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
        yield return _gameMethods.OpenDialog(8968); // "看来他的确对这一套熟悉到厌烦了。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan2", "zui10", "-emoji2"});
        yield return _gameMethods.OpenDialog(8969); // "假若我本身也是贵族呢？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(8970); // "那就复杂了。"
        yield return _gameMethods.OpenDialog(8971); // "还要分成下级、平级和上级等不同的情况，来调整对待..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan5", "zui20"});
        yield return _gameMethods.OpenDialog(8972); // "真是细致入微啊。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan5", "zui8"});
        yield return _gameMethods.OpenDialog(5009); // "呵呵……"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui14"});
        yield return _gameMethods.OpenDialog(8973); // "对下级，贵族会表现得既矜持又高贵，等待对方来取悦..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan12", "zui13"});
        yield return _gameMethods.OpenDialog(8974); // "面对平级，则要保持友善和礼貌，暗中警惕，刺探彼此..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui13"});
        yield return _gameMethods.OpenDialog(8975); // "而遇到等级高于自己的人，便要表达出尊敬、热情，乃..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
        yield return _gameMethods.OpenDialog(8976); // "「你看，就是这样——{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui1"});
        yield return _gameMethods.OpenDialog(8977); // "欲望与恐惧，千遍一律。」"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei8", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(21); // "…………"
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei6", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei8", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(8978); // "他这些话，让我想起一个比喻。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan20", "zui15"});
        yield return _gameMethods.OpenDialog(8979); // "社会就像一群猴子在攀爬一颗大树。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui12"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
        yield return _gameMethods.OpenDialog(8980); // "往下看，看到的都是笑脸，\n往上看，瞧到的全是尾..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan20", "zui12"});
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(8981); // "\n左右看，望见的全是耳目。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(8982); // "所以每个人都在拼命往上爬。爬得越高，能看到的笑脸..."
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
        yield return _gameMethods.OpenDialog(8983); // "就在这个过程中，为了爬得更高，我们克制自己的良心..."
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
        yield return _gameMethods.OpenDialog(8984); // "不断地磨平自己的棱角，最终成功地改变了自己，变成..."
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
        yield return _gameMethods.OpenDialog(8985); // "但是，这难道该指责‘个人’吗？"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui12"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan5", "zui11"});
        yield return _gameMethods.OpenDialog(8986); // "贵族千遍一律，那平民呢？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan14", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(8987); // "「……平民阶层啊……{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui17"});
        yield return _gameMethods.OpenDialog(8988); // "那就有意思多了。」"
        yield return _gameMethods.OpenDialog(8989); // "他们经常会打破常规，冒出出人意料的新鲜表现。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan5", "zui1"});
        yield return _gameMethods.OpenDialog(8990); // "看来你在民间玩得很开心啊。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui3"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan5", "zui6"});
        yield return _gameMethods.OpenDialog(8991); // "是啊。有不少好玩的人呢。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui17"});
        yield return _gameMethods.OpenDialog(8992); // "不过，见的人多了，你会发现一个有趣的现象。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui17"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(8993); // "——无论是性情怎样各异的家伙，都摆脱不了对身份的..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan2", "zui9"});
        yield return _gameMethods.OpenDialog(8994); // "你是说，平民也会趋炎附势？"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan8", "zui10"});
        yield return _gameMethods.OpenDialog(8995); // "……不，应该肯定也会存在对出身嗤之以鼻、不屑一顾..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui16"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(8996); // "确实有。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui17"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
        yield return _gameMethods.OpenDialog(8997); // "「但——{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.OpenDialog(8998); // "这不就是一种在乎吗？」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei3", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.OpenDialog(8999); // "你知道吗，小公主。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui13"});
        yield return _gameMethods.OpenDialog(9000); // "大多数平民，对贵族首先怀有的是仰慕、向往和渴望。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan9", "zui6"});
        yield return _gameMethods.OpenDialog(9001); // "渴望，又得不到，于是有些人便转而敌视。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui4"});
        yield return _gameMethods.OpenDialog(9002); // "但这种自我保护般不屑的敌视背后，也隐藏了一种自卑..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.OpenDialog(9003); // "一旦他们得到了后者的赏识、款待和拉拢，态度往往会..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui14"});
        yield return _gameMethods.OpenDialog(9004); // "即使是原本对贵族不感兴趣的人，一旦受到贵族的亲近..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui16"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
        yield return _gameMethods.OpenDialog(9005); // "「他们根深蒂固地认为，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui16"});
        yield return _gameMethods.OpenDialog(9006); // "贵族生来比自己更高贵。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(9007); // "毕竟，我们生活在一个等级分明的社会里。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
        yield return _gameMethods.OpenDialog(9008); // "虽然平民有机会通过成为骑士或魔法师来提升自己的社..."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(9009); // "实际上，大多数骑士和魔法师的位置还是被贵族家庭所..."
        yield return _gameMethods.StopSound(channelName:"music1", fadeOut:10.0f);
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan10", "zui5"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei3", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(9010); // "不过，我确实遇到了一个例外。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan10", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei8", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(9011); // "这让我提起了一点兴趣。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"zui12"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei3", "yan6", "zui15"});
        yield return _gameMethods.OpenDialog(9012); // "能让诺伯拉感到意外的人，必定算是一个特别的存在。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui10"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei3", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(9013); // "是什么人？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui3"});
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.PlaySound("music", 0.0f, 0.7f, "audio/demo_audio/music/disappearing painting.mp3");
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei3", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(9014); // "你呀。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui13"});
        yield return _gameMethods.OpenDialog(9015); // "你似乎打心眼里，不觉得自己低于或高于任何人呢。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(9016); // "我没有说话。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
        yield return _gameMethods.OpenDialog(9017); // "诺伯拉继续开口。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui13"});
        yield return _gameMethods.OpenDialog(9018); // "对所谓的贵族，你抱有一种看玩笑的态度。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui14"});
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.OpenDialog(9019); // "你自嘲，却从没有一丁点的自卑。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui10"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
        yield return _gameMethods.OpenDialog(1378); // "「……{nw}{w=0.3}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui13"});
        yield return _gameMethods.OpenDialog(7278); // "是啊。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui6"});
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.OpenDialog(9020); // "你的心里，不存在尊卑。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui4"});
        yield return _gameMethods.OpenDialog(9021); // "好像外部世界的等级观念，不曾打破你内心的规则，留..."
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
        yield return _gameMethods.OpenDialog(9022); // "他剖析得似乎有些太深入了。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
        yield return _gameMethods.OpenDialog(9023); // "我一时沉默。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei10", "yan1", "zui8"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei10", "yan11", "zui1"});
        yield return _gameMethods.OpenDialog(9024); // "我很好奇，是怎样的经历塑造出了你现在的模样。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei10", "yan11", "zui8"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(9025); // "“怎样的经历”。那是……"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
        yield return _gameMethods.OpenDialog(9026); // "是…………{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan5", "zui15", "emoji12"});
        yield return _gameMethods.OpenDialog(9027); // "九年义务制教育？{nw}{w=0.2}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan4", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan6", "zui15", "emoji12"});
        yield return _gameMethods.OpenDialog(9028); // "信息时代的互联网冲浪？"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei3", "yan12", "zui15", "-emoji12"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui9"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan9", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan9", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
        yield return _gameMethods.OpenDialog(9029); // "可能是因为所有的封建贵族已经变成了历史吧。\n贵..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan14", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(9030); // "在现代社会中，尽管各种各样的状况依然普遍存在。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
        yield return _gameMethods.OpenDialog(9031); // "可说到底，刚刚提到的各种问题，究竟是被根除了。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan21", "zui15"});
        yield return _gameMethods.OpenDialog(9032); // "无论在实际生活中，人之间的交际模式是如何运转，发..."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(9033); // "但——"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei3", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(9034); // "人与人之间应该是平等的。个人意志应该是自由的。{..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei8", "yan1", "zui8"});
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan18", "zui15"});
        yield return _gameMethods.OpenDialog(9035); // "\n无论是何种程度的权威，都不值得去盲目地迷信。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
        yield return _gameMethods.OpenDialog(9036); // "——这是前世每个人从儿时起就会被灌输和培养的科学..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei8", "yan13", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan9", "zui7", "emoji2"});
        yield return _gameMethods.OpenDialog(9037); // "……虽然这都魔法世界了。谈科学好像的确不合时宜了..."
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan8", "zui7", "-emoji2"});
        yield return _gameMethods.OpenDialog(9038); // "我转而寻找起另外的突破口，试图将谈话引导向更利于..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei8", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_qian", parts: new List<string>{"mei7", "yan5", "zui9"});
        yield return _gameMethods.OpenDialog(9039); // "「……你知道吗？那些人其实并不像你说得那样无趣，..."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan6", "zui10"});
        yield return _gameMethods.OpenDialog(9040); // "他们每个人也有自己独特的一面。」"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan12", "zui11"});
        yield return _gameMethods.OpenDialog(9041); // "你之所以觉得他们千遍一律，是因为……"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(9042); // "你是‘外人’。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei8", "yan11", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan19", "zui15"});
        yield return _gameMethods.OpenDialog(7765); // "……嗯？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei8", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan5", "zui2"});
        yield return _gameMethods.OpenDialog(9043); // "在这个世界上，真情是奢侈品。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan8", "zui2"});
        yield return _gameMethods.OpenDialog(9044); // "人们用坚硬的外壳保护自己，只将柔软的内里留给最重..."
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(9045); // "而面对外人时，我们只会投入恰当的情感，把更多的精..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian", parts: new List<string>{"mei7", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(9046); // "「因此，你的意思是，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.OpenDialog(9047); // "如果我之前感到无聊，是因为我没有得到‘真情’？」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui14"});
        yield return _gameMethods.OpenDialog(9048); // "因为，我付出的代价不够多？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan12", "zui6"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan5", "zui6"});
        yield return _gameMethods.OpenDialog(9049); // "虽然知道对方多半看不见，我还是坚定不移地点了点头..."
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(9050); // "你从旁观的角度看，从高处看，自然会认为他们落入俗..."
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan8", "zui3"});
        yield return _gameMethods.OpenDialog(9051); // "但只有真正身处其中的人，才会感受到那份与众不同。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan8", "zui6"});
        yield return _gameMethods.OpenDialog(9052); // "哦——……"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
        yield return _gameMethods.OpenDialog(6067); // "「那么，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui1"});
        yield return _gameMethods.OpenDialog(9053); // "你也有柔软的内里吗？」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(9054); // "沉默片刻。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan8", "zui7"});
        yield return _gameMethods.OpenDialog(9055); // "我听到自己的声音缓缓说。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan8", "zui20"});
        yield return _gameMethods.OpenDialog(9056); // "有啊。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei9", "yan17", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan8", "zui7"});
        yield return _gameMethods.OpenDialog(9057); // "同时，{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan12", "zui7"});
        yield return _gameMethods.OpenDialog(9058); // "犹如在这两年里所形成某种的公式化的本能一样，"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(9059); // "脸上也慢慢露出一个微笑。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_qian", parts: new List<string>{"mei7", "yan17", "zui2"});
        yield return _gameMethods.OpenDialog(9060); // "「所以，{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan12", "zui4"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan17", "zui4"});
        yield return _gameMethods.OpenDialog(9061); // "要不要和我一起落入俗套试试看。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei9", "yan18", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan17", "zui7"});
        yield return _gameMethods.OpenDialog(9062); // "——让我们选择彼此，以此来成为对方的特殊吧。"
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:10.0f);
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei8", "yan20", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei8", "yan20", "zui8"});
        yield return _gameMethods.OpenDialog(9063); // "…………{nw}{w=0.2}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan18", "zui8"});
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
        yield return _gameMethods.OpenDialog(9064); // "场面一时安静。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
        yield return _gameMethods.OpenDialog(9065); // "对面没有回答。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan6", "zui15"});
        yield return _gameMethods.OpenDialog(9066); // "…既然拉赞助的邀请都已经说出来了，我想了想，又真..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui8"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_qian");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan18", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei3", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(9067); // "试一试吧，你有那么多时间，不会损失什么。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei3", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei3", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
        yield return _gameMethods.OpenDialog(9068); // "许久，我都没得到回应。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui8"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan18", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan19", "zui15"});
        yield return _gameMethods.OpenDialog(9069); // "被拒绝了？"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
        yield return _gameMethods.OpenDialog(9070); // "我及时调整心情，倒也没有过于沮丧。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei3", "yan12", "zui8"});
        yield return _gameMethods.OpenDialog(9071); // "有枣没枣打一杆子嘛，不成功也是常事。"
        yield return _gameMethods.PlaySound("music1", 2.0f, 0.7f, "audio/music/wenxin/bing_PerituneMaterial_Foreboding_loop.mp3");
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui3"});
        yield return _gameMethods.OpenDialog(2471); // "好啊。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(9072); // "耳边传来青年如往常一样轻描淡写的声音。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan18", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
        yield return _gameMethods.OpenDialog(9073); // "他的声线还是那样稀松平常，跳脱、轻盈又冷静。\n..."
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/moca1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0.0f}, {"parallel_1", true}})});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan25", "zui15"});
        yield return _gameMethods.OpenDialog(47); // "……！"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"yoffset", 0.0f}})});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan25", "zui15"});
        yield return _gameMethods.OpenDialog(9074); // "真的成功了？"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
        yield return _gameMethods.OpenDialog(9075); // "连我自己也不敢置信。"
        yield return _gameMethods.StopSound(channelName:"music1", fadeOut:10.0f);
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui13"});
        yield return _gameMethods.OpenDialog(9076); // "为什么要这么惊讶呢。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui14"});
        yield return _gameMethods.OpenDialog(9077); // "你不是已经成功说服过我一次了吗？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(9078); // "——所以，我们现在要做什么？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.PlaySound("music2", 4.0f, 1.0f, "audio/demo_audio/music/richang1.mp3");
        Defaults.Persistent.Jq_7_2 = 1;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan2", "zui19"});
        yield return _gameMethods.OpenDialog(9079); // "你要告诉我你的经历，你的想法，让我了解你。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_qian", parts: new List<string>{"mei7", "yan8", "zui2"});
        yield return _gameMethods.OpenDialog(9080); // "「让我以这种方式参与你的过去，你的人…{nw}{..."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan3", "zui19"});
        yield return _gameMethods.OpenDialog(7519); // "呃，{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(9081); // "龙生。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan8", "zui5"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(9082); // "我想不到有什么可讲的事情呢。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan8", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_qian", parts: new List<string>{"mei7", "yan6", "zui19"});
        yield return _gameMethods.OpenDialog(9083); // "「那就讲讲——{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan2", "zui19"});
        yield return _gameMethods.OpenDialog(9084); // "……你第一次去人类社会吧，是在什么时候呢？」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan2", "zui7"});
        yield return _gameMethods.OpenDialog(9085); // "嗯……130岁左右吧。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui12"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_qian", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(9086); // "那不是还在幼年期吗。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan6", "zui15"});
        yield return _gameMethods.OpenDialog(9087); // "赫泽尔说过一般龙会在成长期后才离开龙之谷……"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei4", "yan10", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(9088); // "难道你也有一个悲惨身世。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian", parts: new List<string>{"mei4", "yan10", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(9089); // "「不，我的诞生很普通。{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui1"});
        yield return _gameMethods.OpenDialog(9090); // "可我不是那么听话的孩子。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(9091); // "从很小时起，我就一直能听到生物的心声，其中最复杂..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
        yield return _gameMethods.OpenDialog(9092); // "「我很好奇这个种族究竟是什么模样，{nw}{w=..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui13"});
        yield return _gameMethods.OpenDialog(9093); // "于是某天就偷偷跑了出去。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan2", "zui10"});
        yield return _gameMethods.OpenDialog(9094); // "那么，你应该是以孩子的样貌来到了人类王国吧。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan6", "zui10"});
        yield return _gameMethods.OpenDialog(9095); // "而且，装束应该也是绸缎华服。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan6", "zui15"});
        yield return _gameMethods.OpenDialog(9096); // "是啊，刚来到人类的城镇中，我发现这里的人很友善。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui7"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(9097); // "……真的吗。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan12", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(9098); // "「有两个男人看到我后，大概以为我是哪家迷路的少爷..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui2"});
        yield return _gameMethods.OpenDialog(9099); // "非常热情地邀请我去他们家做客，还承诺说帮我寻找家..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(6326); // "……{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei5", "yan24", "zui8", "emoji2"});
        yield return _gameMethods.OpenDialog(9100); // "嗯嗯？{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei6", "yan22", "zui13", "emoji5", "emoji6"});
        yield return _gameMethods.OpenDialog(9101); // "不对劲吧！!"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei6", "yan22", "zui13", "-emoji5", "-emoji6"});
        yield return _gameMethods.OpenDialog(9102); // "那你——"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui3"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei6", "yan22", "zui15"});
        yield return _gameMethods.OpenDialog(9103); // "我当然是欣然答应。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan9", "zui5"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian", parts: new List<string>{"mei7", "yan2", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(9104); // "「然后，我就睡着了，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui18"});
        yield return _gameMethods.OpenDialog(9105); // "那时，我还无法完全掌握我的权能，否则哪怕在睡梦中..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui11"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei5", "yan24", "zui16", "emoji2"});
        yield return _gameMethods.OpenDialog(5371); // "噗……"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei5", "yan12", "zui16", "emoji2"});
        yield return _gameMethods.OpenDialog(9106); // "毫不意外。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui11"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei6", "yan12", "zui16", "emoji2"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui11"});
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
        yield return _gameMethods.OpenDialog(9107); // "虽然不太厚道。但是居然第一次来到人类社会就发生了..."
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei3", "yan5", "zui19", "-emoji2"});
        yield return _gameMethods.OpenDialog(9108); // "好吧，现在你看到人类是什么模样了。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(9109); // "你感觉如何呢？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan8", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian", parts: new List<string>{"mei7", "yan5", "zui8"});
        yield return _gameMethods.OpenDialog(9110); // "「我当时睡得很香，不知过了多久，{nw}{w=0..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui3"});
        yield return _gameMethods.OpenDialog(9111); // "我才知道最后被送到了哪里，{nw}{w=0.01..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui17"});
        yield return _gameMethods.OpenDialog(9112); // "会发展成什么样。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_qian", parts: new List<string>{"mei7", "yan5", "zui3"});
        yield return _gameMethods.OpenDialog(9113); // "「……那，{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan10", "zui3"});
        yield return _gameMethods.OpenDialog(9114); // "然后。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei9", "yan13", "zui5"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian", parts: new List<string>{"mei7", "yan10", "zui6"});
        yield return _gameMethods.OpenDialog(9115); // "「最后，我坐在窗台上，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei9", "yan1", "zui18"});
        yield return _gameMethods.OpenDialog(9116); // "观看着那两个和我搭话的人，穿着草裙，在屋内对跳草..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan21", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan24", "zui8", "emoji2"});
        yield return _gameMethods.OpenDialog(9117); // "好摧残人心的场景。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui9"});
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei6", "yan12", "zui8", "emoji6"});
        yield return _gameMethods.OpenDialog(9118); // "能不能看点好的。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui15"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_qian", parts: new List<string>{"mei7", "yan5", "zui10", "-emoji6", "-emoji2"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.OpenDialog(9119); // "不过，为什么会跳舞？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(9120); // "毕竟心理幻觉也属于我的权柄范畴呢。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui1"});
        yield return _gameMethods.OpenDialog(9121); // "他大概是看到了什么合心意的幻境吧。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan10", "zui15", "emoji6"});
        yield return _gameMethods.OpenDialog(21); // "…………"
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan10", "zui8"});
        yield return _gameMethods.OpenDialog(9122); // "那你还蛮慈善的噢，让人家如愿以偿。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui17"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan10", "zui8", "-emoji6"});
        yield return _gameMethods.OpenDialog(9123); // "后来我感觉无聊，就离开了。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan10", "zui18"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(9124); // "「如果他们对跳舞的热爱太过不知节制，{nw}{w..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui3"});
        yield return _gameMethods.OpenDialog(9125); // "也许会累倒在地板上睡整整三天吧。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(9126); // "能控制别人对外界的感官。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei3", "yan12", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(9127); // "总感觉，某种程度上，这家伙比赫泽尔要更危险吧……"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei6", "yan7", "zui5"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei3", "yan8", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(9128); // "所以，你听完这些后就开始害怕我了。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei6", "yan7", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei8", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(9129); // "他露出可怜受伤的语气。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei1", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(9130); // "我诚恳老实地安慰。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_qian", parts: new List<string>{"mei2", "yan2", "zui10", "emoji7", "emoji9"});
        yield return _gameMethods.OpenDialog(9131); // "「怎么会呢，"
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei8", "yan24", "zui19", "-emoji7", "-emoji9"});
        yield return _gameMethods.OpenDialog(9132); // "我害怕你也不是这一两天的事了。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei3", "yan24", "zui16", "emoji2"});
        yield return _gameMethods.OpenDialog(5009); // "呵呵……"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei3", "yan24", "zui16", "-emoji2"});
        yield return _gameMethods.OpenDialog(9133); // "那么，作为交换，接下来该轮到你了。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei3", "yan10", "zui8", "emoji2"});
        yield return _gameMethods.OpenDialog(9134); // "……我们是什么交换礼物以学习做朋友的小学生吗。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei3", "yan12", "zui19", "emoji2"});
        yield return _gameMethods.OpenDialog(9135); // "好、好，我想想……"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei3", "yan8", "zui7", "-emoji2"});
        yield return _gameMethods.OpenDialog(9136); // "这次要编一个什么新故事呢——"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui14"});
        yield return _gameMethods.OpenDialog(9137); // "根据等价交换的原则，你应该讲一个有关于你的故事。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(9138); // "「发生在你的身上、{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui14"});
        yield return _gameMethods.OpenDialog(9139); // "与你相关的事情，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui1"});
        yield return _gameMethods.OpenDialog(9140); // "——说给我听。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
        yield return _gameMethods.OpenDialog(7611); // "「这样，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui3"});
        yield return _gameMethods.OpenDialog(9141); // "才能让我参与你的人生呀。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei3", "yan5", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei3", "yan24", "zui24", "emoji6"});
        yield return _gameMethods.OpenDialog(9142); // "真是难对付。"
        Defaults.Persistent.Jq_7_3 = 1;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei3", "yan5", "zui15", "emoji5"});
        yield return _gameMethods.OpenDialog(9143); // "我，"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei5", "yan10", "zui15"});
        yield return _gameMethods.OpenDialog(9144); // "非常、"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei5", "yan22", "zui8"});
        yield return _gameMethods.OpenDialog(9145); // "极其、"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei5", "yan12", "zui8"});
        yield return _gameMethods.OpenDialog(9146); // "完全不想，和现在认识的这两条龙，谈及自身的过往。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
        yield return _gameMethods.OpenDialog(9147); // "他恐怕也是意识到了这一点，才把它当作挑战目标。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui8"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei3", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(9148); // "他笑眯眯地看着我。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
        yield return _gameMethods.OpenDialog(9149); // "那副表情，就好像在说，想要他付出真心，就必须也拿..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei3", "yan10", "zui15", "emoji5", "emoji6"});
        yield return _gameMethods.OpenDialog(9150); // "…………{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei5", "yan12", "zui8", "-emoji5"});
        yield return _gameMethods.OpenDialog(9151); // "………………好吧。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei3", "yan6", "zui15", "-emoji6", "-emoji1"});
        yield return _gameMethods.OpenDialog(9152); // "讲点什么呢。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui7"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"-emoji2", "-emoji6"});
        yield return _gameMethods.OpenDialog(9153); // "讲一讲，关于你最重视的人的事情吧。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui1"});
        yield return _gameMethods.OpenDialog(9154); // "你不是要教我学会真情吗？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei3", "yan5", "zui20"});
        yield return _gameMethods.OpenDialog(9155); // "你真是善于找出别人的心理弱点，对吗？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(9156); // "我只是想了解你呀。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui8"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(9157); // "……我生命中最重要的人，毫无疑问就是她了。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei2", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(9158); // "妈妈。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei1", "yan20", "zui15"});
        yield return _gameMethods.OpenDialog(9159); // "但我并不想在这里和别人直接谈及她。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui8"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(9160); // "……好吧。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(9161); // "我酝酿了一下，有些艰难地开口。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(9162); // "六岁时，我家搬到了王都。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui5"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(9163); // "哦，在那之前，你住在哪里？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan2", "zui10"});
        yield return _gameMethods.OpenDialog(9164); // "乡下。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan8", "zui10"});
        yield return _gameMethods.OpenDialog(9165); // "我的母亲，带着我一个人居住，在那种保守的环境中行..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(9166); // "毕竟风气如此嘛。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan12", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan12", "zui10"});
        yield return _gameMethods.OpenDialog(9167); // "来到王城后，虽然风气开放了一些，但还是难免惹来一..."
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan6", "zui10"});
        yield return _gameMethods.OpenDialog(9168); // "有一次，一个男孩在我面前说了我妈妈的坏话。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui4"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan6", "zui15"});
        yield return _gameMethods.OpenDialog(9169); // "那，你怎么回应的？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui9"});
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan2", "zui10"});
        yield return _gameMethods.OpenDialog(9170); // "我一拳揍了上去。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan4", "zui12"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(1599); // "「……{nw}{w=0.1}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei2", "yan2", "zui8"});
        yield return _gameMethods.OpenDialog(9171); // "……{nw}{w=0.1}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei5", "yan12", "zui3"});
        yield return _gameMethods.OpenDialog(9172); // "当然，我毫不怀疑你的勇敢。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui2"});
        yield return _gameMethods.OpenDialog(9173); // "之后呢，结果是？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan12", "zui11"});
        yield return _gameMethods.OpenDialog(9174); // "我被打得更惨。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(9175); // "真是现实的结局。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan5", "zui4"});
        yield return _gameMethods.OpenDialog(9176); // "但是我赢了。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui5"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan5", "zui6"});
        yield return _gameMethods.OpenDialog(9177); // "哦？他求饶了？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan6", "zui3"});
        yield return _gameMethods.OpenDialog(9178); // "口头上当然没有，他还又和我打过两次呢。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui16"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan6", "zui6"});
        yield return _gameMethods.OpenDialog(9179); // "所以，你认为你赢了？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan2", "zui19"});
        yield return _gameMethods.OpenDialog(9180); // "当然了。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei3", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(9181); // "从此以后他就知道，想要说我妈妈的坏话，就得付出代..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui12"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei3", "yan5", "zui8", "emoji10"});
        yield return _gameMethods.OpenDialog(9182); // "我忍不住有点小得意。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei10", "yan2", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei3", "yan12", "zui19", "-emoji10"});
        yield return _gameMethods.OpenDialog(9183); // "所以在同我打过两次之后，他就再也不愿意惹是生非了..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei10", "yan11", "zui8"});
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan8", "zui19"});
        yield return _gameMethods.OpenDialog(9184); // "因为他明白，我不会投降，如果他还想过安生日子，就..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan2", "zui6"});
        yield return _gameMethods.OpenDialog(9185); // "所以，你赢了？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_qian", parts: new List<string>{"mei7", "yan5", "zui2"});
        yield return _gameMethods.OpenDialog(9186); // "「所以，我赢了。{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(9187); // "而且，赢到最后的人一定会是我。」"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_qian", parts: new List<string>{"mei3", "yan12", "zui19"});
        yield return _gameMethods.OpenDialog(9188); // "「我的胜利就在于，{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan17", "zui3"});
        yield return _gameMethods.OpenDialog(9189); // "我反抗了。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei6", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei3", "yan17", "zui7"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
        yield return _gameMethods.OpenDialog(9190); // "「不过——你还是被打得很凄惨，{nw}{w=0...."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(9191); // "为了口角之争、意气用事。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui13"});
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.OpenDialog(9192); // "你看起来像是一个比起会做出这种事的人，更加精明的..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei3", "yan12", "zui8"});
        yield return _gameMethods.OpenDialog(9193); // "呵呵，天真。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan5", "zui3"});
        yield return _gameMethods.OpenDialog(9194); // "这才是我聪明的地方呢。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan5", "zui6"});
        yield return _gameMethods.OpenDialog(3904); // "哦？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan10", "zui2"});
        yield return _gameMethods.OpenDialog(9195); // "他没有办法向家长告状。\n因为我和他打架了，这就..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui8"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_qian", parts: new List<string>{"mei7", "yan11", "zui2"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.OpenDialog(9196); // "如果他向大人告状，就会受到这条街上所有打架的孩子..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui7"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan11", "zui6"});
        yield return _gameMethods.OpenDialog(9197); // "哈哈……真聪明。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan5", "zui6"});
        yield return _gameMethods.OpenDialog(9198); // "他似乎笑了笑。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui13"});
        yield return _gameMethods.OpenDialog(9199); // "可是，小公主，你不喜欢打架，不喜欢受伤。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan20", "zui16"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(9200); // "「和天生享受此事的人不同，{nw}{w=0.01..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui14"});
        yield return _gameMethods.OpenDialog(9201); // "你无法从给他人施加痛苦的行为中获得快乐。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
        yield return _gameMethods.OpenDialog(9202); // "「你在做一件自己不喜欢的事。{nw}{w=0.0..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei6", "yan11", "zui1"});
        yield return _gameMethods.OpenDialog(9203); // "就是为了你口中所说的真情？」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei6", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan5", "zui3"});
        yield return _gameMethods.OpenDialog(2654); // "是呀。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei10", "yan7", "zui12"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan5", "zui6"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
        yield return _gameMethods.OpenDialog(9204); // "似乎没料到我会一口答应得那么干脆，对方倒猝不及防..."
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan8", "zui6"});
        yield return _gameMethods.OpenDialog(9205); // "这有什么好奇怪的呢？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei10", "yan13", "zui12"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
        yield return _gameMethods.OpenDialog(9206); // "妈妈是我的全部，我也是妈妈的全部。{nw}{w=..."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(9207); // "\n她把她所有的爱都给了我，我们是彼此在世上最重..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei10", "yan11", "zui12"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
        yield return _gameMethods.OpenDialog(9208); // "虽然她不会再对我说一句话，露出一个微笑。"
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 3;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan20", "zui7"});
        yield return _gameMethods.OpenDialog(9209); // "但是，她给过我的东西，将贯穿余生。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui13"});
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
        yield return _gameMethods.OpenDialog(9210); // "忽然间，诺伯拉感慨般地叹了口气。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui16"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(9211); // "「忠贞不渝的爱情。{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui13"});
        yield return _gameMethods.OpenDialog(9212); // "\n肝胆相照的友情。{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan19", "zui13"});
        yield return _gameMethods.OpenDialog(9213); // "\n血浓于水的亲情。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
        yield return _gameMethods.OpenDialog(9214); // "「无论看过多少遍，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui16"});
        yield return _gameMethods.OpenDialog(9215); // "人类身上的这些东西，永远令我感到奇妙。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan4", "zui15"});
        yield return _gameMethods.OpenDialog(9216); // "“奇妙”……{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan7", "zui7"});
        yield return _gameMethods.OpenDialog(9217); // "啊。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_qian", parts: new List<string>{"mei7", "yan12", "zui12"});
        yield return _gameMethods.OpenDialog(9218); // "「是啊。{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan2", "zui10"});
        yield return _gameMethods.OpenDialog(9219); // "阴阳相隔、爱恨情仇，喜怒悲欢，{nw}{w=0...."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(9220); // "这些、在你眼里……{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan8", "zui3"});
        yield return _gameMethods.OpenDialog(9221); // "应该都已经是千遍一律的俗套故事了吧？」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan8", "zui6"});
        yield return _gameMethods.OpenDialog(9222); // "嗯——确实见过很多了。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan8", "zui3"});
        yield return _gameMethods.OpenDialog(765); // "嗯。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_qian", parts: new List<string>{"mei7", "yan12", "zui3"});
        yield return _gameMethods.OpenDialog(9223); // "「所以说，{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(9224); // "我的故事其实也没什么特别的。」"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(9225); // "世界上如出一辙的事情随时都在发生，这样的故事、这..."
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan8", "zui18"});
        yield return _gameMethods.OpenDialog(9226); // "像草一样，数量太多，因而似乎已经无足轻重。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui16"});
        yield return _gameMethods.OpenDialog(9227); // "但是，我开始理解你说过的话了。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(924); // "……？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
        yield return _gameMethods.OpenDialog(9228); // "「这件事情不光在于它本身有没有趣，{nw}{w=..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.OpenDialog(9229); // "更重要的是——它是关于你的事情。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui16"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
        yield return _gameMethods.OpenDialog(9230); // "「所以，它才让我感到新奇。{nw}{w=0.01..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui4"});
        yield return _gameMethods.OpenDialog(9231); // "以及……特别。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui9"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_qian", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan25", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
        yield return _gameMethods.OpenDialog(9232); // "特别。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(9233); // "这真是最不可能从他口中说出的一个词汇。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui13"});
        yield return _gameMethods.OpenDialog(9234); // "很奇怪吗？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.OpenDialog(9235); // "‘原来你也会做这种事，你曾经做出过这种事。’——..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui8"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_qian", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(9236); // "居然能听到这种家伙的嘴里说出这种话。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei3", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(9237); // "总感觉………………"
        yield return _gameMethods.OpenSelectMenu(
            talk: new List<string>{"-有点动容", "-有点恶寒"},
            jump: new List<string>{"label_bai_menu_1_jxWk_Ed3", "label_bai_menu_1_WF3pzbUX"},
            condition: new List<string>{"NONE", "NONE"}
        );
    }

    public IEnumerator label_bai_about_nvwang()
    {
        yield return _gameMethods.Show("black");
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.Hide("black");
        yield return _gameMethods.Show("woshi_nv2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(564.0f, 792.0f)}, {"zoom", 0.61f}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}})});
        yield return _gameMethods.Transition(time:0.5f);
        Defaults.Persistent.Jq_7_6 = 1;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(9252); // "我和诺伯拉之间的交谈每日都在进行。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(9253); // "除了原本惯例的故事会之外，诺伯拉也开始和我讲述他..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(9254); // "这让我对这条热爱观察又喜欢玩弄人心的冰霜之龙，有..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(9255); // "我发现，不少令我耳熟能闻的重大历史事件背后，影影..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(9256); // "诺伯拉似乎热衷于在一些重要事件中，扮演一名貌不惊..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"yan8", "zui15"});
        yield return _gameMethods.OpenDialog(9257); // "有时是侍者、有时是路人，有时则是阴谋计划中的一枚..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(9258); // "他站在风云变幻的权力漩涡边缘，悠闲地旁观着各方势..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"yan6", "zui15"});
        yield return _gameMethods.OpenDialog(9259); // "另一些时候，他则喜欢化身普通的平民，扎身到于市井..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"yan5", "zui15"});
        yield return _gameMethods.OpenDialog(9260); // "……说实话。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"yan12", "zui15"});
        yield return _gameMethods.OpenDialog(9261); // "在很多叙述中，诺伯拉展现出了一种缺乏人性的纯粹的..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(9262); // "但部分时候，又会令我感觉他仿佛只是爱玩、兼之好奇..."
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.OpenDialog(9263); // "而自从上次谈及到我的过去，诺伯拉似乎对于我本身的..."
        yield return _gameMethods.OpenDialog(9264); // "时不时会把话题引到我身上。"
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.Hide("woshi_nv2");
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(33); // "………………"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui5"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.67f}, {"alpha", 0.0f}, {"blur", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.OpenDialog(9265); // "所以——在前往王城前，你和你的母亲住在乡村？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui9"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan2", "zui10"});
        yield return _gameMethods.OpenDialog(9266); // "是的，在北方的一个领地。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(9267); // "听到我说出那个领地的名字，他开口。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui13"});
        yield return _gameMethods.OpenDialog(9268); // "我在那里呆过一阵子。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei1", "yan14", "zui13"});
        yield return _gameMethods.OpenDialog(9269); // "记得那里的领主是以昏庸而出名的吧。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei1", "yan14", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan6", "zui15"});
        yield return _gameMethods.OpenDialog(9270); // "……虽然的确是昏庸，但是居然已经出名到传进外族耳..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei9", "yan11", "zui12"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(9271); // "……是啊，所以母亲才带着我搬家到王城了。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(9272); // "当时我只是担心母亲会遇到刁难，所以提了一嘴。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei6", "yan1", "zui8"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
        yield return _gameMethods.OpenDialog(9273); // "但没想到她真的动身了。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
        yield return _gameMethods.OpenDialog(9274); // "长途的搬迁，对这个时代的人们来说，需要巨大的决心..."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(9275); // "\n我知道，妈妈是考虑了我的将来。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(9276); // "「你拥有一位非常重视你的母亲。{nw}{w=0...."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.OpenDialog(9277); // "同时，还具备勇气。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui8"});
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei3", "yan11", "zui19", "emoji15", "emoji10"});
        yield return _gameMethods.OpenDialog(9278); // "你真有眼光。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei2", "yan2", "zui15"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei3", "yan2", "zui7", "emoji15", "-emoji10"});
        yield return _gameMethods.OpenDialog(226); // "{nw}{w=0.2}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei6", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
        yield return _gameMethods.OpenDialog(9279); // "他一夸我的妈妈，声音就令我感到悦耳不少。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui14"});
        yield return _gameMethods.OpenDialog(9280); // "呵呵。怪不得你不像贵族。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei8", "yan12", "zui19"});
        yield return _gameMethods.OpenDialog(9281); // "是啊是啊，因为，我就是个平民。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei8", "yan8", "zui7"});
        yield return _gameMethods.OpenDialog(9282); // "我一直在底层的平民间长大，也见过形形色色的农民和..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei8", "yan8", "zui15", "-emoji15"});
        yield return _gameMethods.OpenDialog(9283); // "他们通常也会有爱占小便宜的习惯，但大部分时间里都..."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei8", "yan20", "zui15"});
        yield return _gameMethods.OpenDialog(9284); // "这一生没做错过任何事，却得到一个潦草的结局。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei3", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(9285); // "最恐怖的是，如果没有超凡力量的存在，那么无论出身..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui9"});
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei3", "yan18", "zui15"});
        yield return _gameMethods.OpenDialog(9286); // "但在这样一个拥有魔法和骑士的世界里，底层的人民无..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui9"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian", parts: new List<string>{"mei3", "yan18", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui9"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui5"});
        yield return _gameMethods.OpenDialog(9287); // "你真是喜欢发表惊世骇俗的言论呢，小公主。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui16"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei3", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(9288); // "这让我有点好奇了……"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
        yield return _gameMethods.OpenDialog(9289); // "「由你当上女王的国家，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui2"});
        yield return _gameMethods.OpenDialog(9290); // "会是一副怎样的面貌？」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_qian", parts: new List<string>{"mei7", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(9291); // "「跟现在没什么两样吧，{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan6", "zui10"});
        yield return _gameMethods.OpenDialog(9292); // "毕竟世界和财富是劳动人民创造的，我一个人的影响力..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_qian", parts: new List<string>{"mei7", "yan12", "zui11"});
        yield return _gameMethods.OpenDialog(9293); // "「顶多少盖两座宫殿和教堂，给人民群众省点钱。{n..."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei8", "yan8", "zui10"});
        yield return _gameMethods.OpenDialog(9294); // "\n该当吉祥物的时候当吉祥物，该赈灾赈灾，不要拖..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei8", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(9295); // "真是朴实的目标啊。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 2;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei8", "yan10", "zui7", "emoji2"});
        yield return _gameMethods.OpenDialog(9296); // "不然呢，仅凭我自己可以做到什么超越时代的事情吗。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan4", "zui9"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei3", "yan12", "zui8"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei11", "yan2", "zui15"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei11", "yan7", "zui8"});
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
        yield return _gameMethods.OpenDialog(9297); // "我也不可能硬是在传统经济基础上探索新的道路啊。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei3", "yan12", "zui8", "-emoji2"});
        yield return _gameMethods.OpenDialog(9298); // "听起来你对当女王不那么感兴趣。为什么？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan1", "zui8", "emoji6"});
        yield return _gameMethods.OpenDialog(9299); // "不为什么。能不能考虑一下我一年后的未来都没确定的..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan5", "zui10", "-emoji2", "-emoji6"});
        yield return _gameMethods.OpenDialog(9300); // "还好吧，当不了没什么，当上了也不亏。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui3"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(9301); // "那么我就更期待你当上女王的样子了。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan10", "zui15"});
        yield return _gameMethods.OpenDialog(9302); // "这就是追求新鲜感的人爱干的事情吧，搅风搅雨，再看..."
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan8", "zui3"});
        yield return _gameMethods.OpenDialog(9303); // "你总是喜欢像这样，把普通人放在不属于他们的高位上..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei6", "yan7", "zui5"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(9304); // "你对我的印象也太恶劣了。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei6", "yan13", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(9305); // "「为什么就不能是因为我单纯喜欢你，{nw}{w=..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei6", "yan1", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(9306); // "所以想用人人都为之追逐的、最昂贵的东西当做礼物，..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui13"});
        yield return _gameMethods.OpenDialog(9307); // "好讨公主殿下的欢心呢。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan5", "zui3"});
        yield return _gameMethods.OpenDialog(9308); // "因为我还算是比较有自知之明。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan24", "zui5"});
        yield return _gameMethods.OpenDialog(5546); // "是吗？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.OpenDialog(9309); // "真遗憾，我还期待看到你站在这个位置上大展手脚，创..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan11", "zui2"});
        yield return _gameMethods.OpenDialog(9310); // "那你不如多透露给我一些龙族的弱点吧。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian", parts: new List<string>{"mei7", "yan11", "zui6"});
        yield return _gameMethods.OpenDialog(9311); // "「很可惜。龙族的弱点，根据其血脉的不同，不一而足..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(9312); // "但它们都不适用于尼德霍格。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.OpenDialog(9313); // "不过，你已经掌握住他一个弱点了。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui16"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian", parts: new List<string>{"mei7", "yan12", "zui6"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(9314); // "「不如说，你硬生生地在他的身上创造出了一个弱点。..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei6", "yan1", "zui3"});
        yield return _gameMethods.OpenDialog(9315); // "我都要为你的丰功伟绩而惊叹了。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(9316); // "什么意思？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(9317); // "「是啊，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui14"});
        yield return _gameMethods.OpenDialog(9318); // "什么意思呢。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei3", "yan10", "zui8"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei5", "yan12", "zui8"});
        yield return _gameMethods.OpenDialog(9319); // "我的拳头握硬了。这辈子最讨厌谜语人。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei3", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(9320); // "我试图蒙中答案。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan8", "zui10"});
        yield return _gameMethods.OpenDialog(9321); // "你是说，勇者最终有可能战胜黑龙吗？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei6", "yan7", "zui16"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(9322); // "「勇者？{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui14"});
        yield return _gameMethods.OpenDialog(9323); // "哈哈哈哈，当然不。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian", parts: new List<string>{"mei3", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(9324); // "「你或许知道尼德霍格强大，{nw}{w=0.01..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui14"});
        yield return _gameMethods.OpenDialog(9325); // "却不明白他究竟有多强大，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui17"});
        yield return _gameMethods.OpenDialog(9326); // "才以为人类也许有可以通过努力而战胜他的那一天。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui13"});
        yield return _gameMethods.OpenDialog(9327); // "然而，越是往上爬的人，越是会明白力量的差距。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui14"});
        yield return _gameMethods.OpenDialog(9328); // "也会清楚地意识到——这是不可能的任务。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui18"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
        yield return _gameMethods.OpenDialog(9329); // "「现在，他还没到成长期，尚未履行他在命运中的职责..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan14", "zui6"});
        yield return _gameMethods.OpenDialog(9330); // "没有获得完整的权柄，处于有史以来最弱的时间。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui4"});
        yield return _gameMethods.OpenDialog(9331); // "尽管如此，我依然无法与他抗衡，顶多只有他力量的六..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan9", "zui6"});
        yield return _gameMethods.OpenDialog(9332); // "或许当我到达成熟期时会有力量与幼年期的他一战吧。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan9", "zui12"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(9333); // "你怎么能肯定勇者就不行？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan10", "zui11"});
        yield return _gameMethods.OpenDialog(9334); // "那可是预言中的勇者，说不定就能创造奇迹呢。更别提..."
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei3", "yan10", "zui15"});
        yield return _gameMethods.OpenDialog(9335); // "涉及到我的两个童年玩伴，我还是情不自禁嘴硬了一下..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui9"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui9"});
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
        yield return _gameMethods.OpenDialog(1599); // "「……{nw}{w=0.1}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui1"});
        yield return _gameMethods.OpenDialog(9336); // "啊，原来勇者一行人是你的旧相识。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui3"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei3", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(9337); // "真不愧是魅力无限的公主殿下。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei3", "yan5", "zui18"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui2"});
        yield return _gameMethods.OpenDialog(9338); // "而且，你们的交情，似乎还不浅呢。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei3", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui14"});
        yield return _gameMethods.OpenDialog(9339); // "他们是你很在乎的人？"
        yield return _gameMethods.StopSound(channelName:"music1", fadeOut:5.0f);
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
        yield return _gameMethods.OpenDialog(9340); // "我始终沉默。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei8", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
        yield return _gameMethods.OpenDialog(9341); // "他的语气又开始变得兴致盎然了。"
        yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/music/bing_richang1.mp3");
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei8", "yan1", "zui8"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei8", "yan7", "zui14"});
        yield return _gameMethods.OpenDialog(9342); // "和我讲讲你们之间的故事吧。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei8", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_qian", parts: new List<string>{"mei3", "yan12", "zui11"});
        yield return _gameMethods.OpenDialog(9343); // "「……按照等价交换，如果想听，你也要给我讲一个你..."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan5", "zui11"});
        yield return _gameMethods.OpenDialog(9344); // "你有吗？」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei8", "yan14", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei3", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(9345); // "嗯——我有过不少在特定时期内联系密切的人物。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei8", "yan7", "zui13"});
        yield return _gameMethods.OpenDialog(9346); // "按照人类社会的普遍标准，我们当时的确被大众视为挚..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei8", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan5", "zui11"});
        yield return _gameMethods.OpenDialog(9347); // "那不行。只有在你心中同样重要的存在才叫挚友。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan10", "zui6"});
        yield return _gameMethods.OpenDialog(9348); // "别想钻空子。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui6"});
        yield return _gameMethods.OpenDialog(1747); // "好吧。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui1"});
        yield return _gameMethods.OpenDialog(9349); // "——那你想知道控制住龙的方法吗？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(9350); // "……还有这种秘籍？"
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/moca1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -8.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 8.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0.0f}, {"parallel_1", true}})});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei5", "yan25", "zui12", "emoji7"});
        yield return _gameMethods.OpenDialog(9351); // "想。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"yoffset", 0.0f}})});
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui8"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei5", "yan25", "zui16"});
        yield return _gameMethods.OpenDialog(9352); // "我以一种求知若渴的眼神看着他，就像饥饿的人扑在面..."
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
        yield return _gameMethods.OpenDialog(9353); // "又或是像失学儿童在恳切地凝望着支教老师。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui13"});
        yield return _gameMethods.OpenDialog(9354); // "想要控制住龙，可以通过……"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan4", "zui5"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
        yield return _gameMethods.OpenDialog(9355); // "「——哎呀，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui3"});
        yield return _gameMethods.OpenDialog(9356); // "我怎么给忘了？」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei3", "yan5", "zui15", "-emoji7", "emoji2"});
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei3", "yan10", "zui19", "-emoji2"});
        yield return _gameMethods.OpenDialog(9357); // "那么，听一个关于人类友情的故事，对你恢复记忆有没..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei8", "yan11", "zui17"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei3", "yan10", "zui8"});
        yield return _gameMethods.OpenDialog(9358); // "我想，一定会有的。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei8", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei8", "yan24", "zui7"});
        yield return _gameMethods.OpenDialog(9359); // "（你可真是不吃一点亏啊。）"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei8", "yan2", "zui7"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei8", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(9360); // "我在心中叹了口气。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei8", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei8", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(9361); // "友情吗。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei4", "yan12", "zui18", "emoji2"});
        yield return _gameMethods.OpenDialog(9362); // "……洛恩，对不起。回去后一定向你跪地谢罪，"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei8", "yan13", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei4", "yan22", "zui18", "emoji2"});
        yield return _gameMethods.OpenDialog(9363); // "但是扣工资和免费义务劳动还是绝对免谈。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei3", "yan8", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(9364); // "组织了一下语言，我开口。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(9365); // "勇者队伍里，有一个人叫洛恩。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(9366); // "你口中的那名奥术师？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(1660); // "是的。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(9367); // "你和勇者，以及他的关系都很不错。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan6", "zui11"});
        yield return _gameMethods.OpenDialog(9368); // "我们三个从小就认识了。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan14", "zui16"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan6", "zui15"});
        yield return _gameMethods.OpenDialog(9052); // "哦——……"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan14", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei3", "yan5", "zui11"});
        yield return _gameMethods.OpenDialog(9369); // "你问题怎么那么多？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei3", "yan12", "zui11"});
        yield return _gameMethods.OpenDialog(9370); // "还听不听了。"
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:5.0f);
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui3"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei3", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(9371); // "当然，洗耳恭听。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui7"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei3", "yan6", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.PlaySound("sounda", 0.0f, 2.0f, "<silence 0.6>audio/sound/jiaotang/Church Bell Three Shots_01.mp3");
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei3", "yan6", "zui10"});
        yield return _gameMethods.OpenDialog(9372); // "我和洛恩的相识。是在王城平民区济贫院的公共讲堂里..."
        yield return _gameMethods.Scene("memory3_1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.29f, 1.04f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 1.42f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        Defaults.Gui_duihuakuang_you = 0;
        yield return _gameMethods.Hide("nuo_heart_layered");
        yield return _gameMethods.PlaySound("soundb", 0.0f, 6.0f, "audio/sound/jiaotang/Crow Town Step_01.ogg");
        yield return _gameMethods.Transition(time:0.6f);
        yield return _gameMethods.PlaySound("music2", 0.0f, 1.0f, "audio/music/One_spring_day.mp3");
        Defaults.Persistent.Jq_7_7 = 1;
        yield return _gameMethods.OpenDialog(9373); // "那时，我是去领取餐食的。"
        yield return _gameMethods.OpenDialog(9374); // "毕竟我们每年都要通过捐出一点钱或日常用品等种种方..."
        yield return _gameMethods.OpenDialog(9375); // "我决心吃回本来。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 5.0f, "audio/sound/jiaotang/FootStep Elegant 1_01.mp3");
        yield return _gameMethods.Show("memory3_1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 5.0f}, {"xpos", 0.67f}, {"zoom", 1.36f}})});
        yield return _gameMethods.Show("memory3_1", parts: new List<string>{"at", "default", "as", "memory3_12"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(-36.0f, -132.0f)}, {"anchor", new Vector2(0.0f, 0.0f)}, {"zoom", 1.47f}, {"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.8f}, {"alpha", 1.0f}})});
        yield return _gameMethods.OpenDialog(9376); // "就在这时，我注意到了洛恩。"
        yield return _gameMethods.OpenDialog(9377); // "他穿着一身体面文雅的正装，跟从家人一起来这聆听宣..."
        yield return _gameMethods.OpenDialog(9378); // "在此之前，我就知道他，他家是这片区域里最富裕的一..."
        yield return _gameMethods.OpenDialog(9379); // "但洛恩显然和我们这些穿着短袖短裤、会在大街小巷上..."
        yield return _gameMethods.OpenDialog(9380); // "所以很自然的，我们此前也素未相识。"
        yield return _gameMethods.Show("memory3_1", parts: new List<string>{"as", "memory3_12"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        yield return _gameMethods.Show("memory3_1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.67f}, {"zoom", 1.36f}})});
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.Show("memory3_2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.8f}, {"alpha", 1.0f}})});
        yield return _gameMethods.OpenDialog(9381); // "公共讲堂的座位被这一区域的居民们填满后。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 2.0f, "audio/sound/jiaotang/Flip Books Mid_01.mp3");
        yield return _gameMethods.Hide("memory3_1");
        yield return _gameMethods.Hide("memory3_1");
        yield return _gameMethods.Hide("memory3_1");
        yield return _gameMethods.Show("memory3_2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        yield return _gameMethods.OpenDialog(9382); // "讲师开始宣讲。"
        yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:5.0f);
        yield return _gameMethods.OpenDialog(9383); // "——自然包容万物，深爱众人，宽恕众人。"
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.OpenDialog(9384); // "当讲师宣讲完后，洛恩做出了一个令所有人都意想不到..."
        yield return _gameMethods.Scene("memory3_3");
        yield return _gameMethods.Transition(time:0.7f);
        yield return _gameMethods.OpenDialog(9385); // "他举起了手。"
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/houhui/Body3 _01.mp3");
        yield return _gameMethods.Show("memory3_4", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.7f}, {"alpha", 1.0f}})});
        yield return _gameMethods.OpenDialog(9386); // "经过讲师的许可，他站起提问。"
        yield return _gameMethods.Show("memory3_4", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        yield return _gameMethods.Show("memory3_5", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1.0f}})});
        yield return _gameMethods.OpenDialog(9387); // "如如果自然深爱众人，为什么还会有那么多食不果腹、..."
        yield return _gameMethods.Show("memory3_5", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        yield return _gameMethods.Show("memory3_6", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1.0f}})});
        yield return _gameMethods.OpenDialog(9388); // "一切都在自然的运行和意志之中。"
        yield return _gameMethods.Show("memory3_6", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        yield return _gameMethods.Hide("memory3_5");
        yield return _gameMethods.Show("memory3_5", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1.0f}})});
        yield return _gameMethods.OpenDialog(9389); // "那这些战乱、饥饿、贫穷，也都是自然的运行吗？"
        yield return _gameMethods.Show("memory3_5", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        yield return _gameMethods.Hide("memory3_6");
        yield return _gameMethods.Show("memory3_6", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1.0f}})});
        yield return _gameMethods.OpenDialog(9390); // "是。因为人类曾犯下罪孽，令自然的运作紊乱，所以要..."
        yield return _gameMethods.Show("memory3_6", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        yield return _gameMethods.Hide("memory3_5");
        yield return _gameMethods.Show("memory3_5", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1.0f}})});
        yield return _gameMethods.Show("memory3_7", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.8f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.3f}, {"alpha", 1.0f}})});
        yield return _gameMethods.Transition(time:0.9f);
        yield return _gameMethods.OpenDialog(9391); // "洛恩看起来充满了疑问。"
        yield return _gameMethods.Show("memory3_5", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        yield return _gameMethods.Show("memory3_7", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        yield return _gameMethods.OpenDialog(9392); // "不是说自然如慈父，会爱并宽恕他的孩子吗？"
        yield return _gameMethods.Hide("memory3_6");
        yield return _gameMethods.Show("memory3_6", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1.0f}})});
        yield return _gameMethods.OpenDialog(9393); // "自然如慈父，也是严父，会在适当的时机，宽恕已经偿..."
        yield return _gameMethods.Hide("memory3_7");
        yield return _gameMethods.Show("memory3_7", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.3f}, {"alpha", 1.0f}})});
        yield return _gameMethods.OpenDialog(9394); // "那什么时候算是适当的时机？偿清罪孽的标准又是什么..."
        yield return _gameMethods.OpenDialog(9395); // "我们该怎么知道，自己还要偿还多少罪孽？"
        yield return _gameMethods.Hide("memory3_6");
        yield return _gameMethods.Show("memory3_6", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1.0f}})});
        yield return _gameMethods.StopEngineTime(time:0.8f);
        yield return _gameMethods.Show("memory3_8", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1.0f}})});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.PlaySound("sounda1", 0.0f, 1.0f, "audio/sound/jiaotang/Crow Whisper_01.ogg");
        yield return _gameMethods.Show("memory3_6", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        yield return _gameMethods.Show("memory3_8", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        yield return _gameMethods.OpenDialog(9396); // "讲师不说话了，慢慢皱起眉，大概是觉得他在捣乱。"
        yield return _gameMethods.OpenDialog(9397); // "而周围的信徒投来怪异的目光。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<silence 0.7>audio/sound/jiaotang/Sit_01.mp3");
        yield return _gameMethods.Scene("memory3_10");
        yield return _gameMethods.Transition(time:0.7f);
        yield return _gameMethods.OpenDialog(9398); // "洛恩的家人觉得十分尴尬，忙拽他坐回到位置上。"
        yield return _gameMethods.Scene("memory3_9");
        yield return _gameMethods.Transition(time:0.7f);
        yield return _gameMethods.OpenDialog(9399); // "宣讲继续，再无任何波澜，直到结束。"
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.PlaySound("soundb", 0.0f, 1.0f, "audio/sound/jiaotang/Crowd Talking Chatter Pre Show_01.ogg");
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.Show("memory3_11");
        yield return _gameMethods.Transition(time:0.8f);
        yield return _gameMethods.StopEngineTime(time:1.0f);
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.3f, "audio/sound/huiyi_winter/Crystal Treasure Pick Up_01.ogg");
        yield return _gameMethods.Show("memory3_12");
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.StopEngineTime(time:2.0f);
        yield return _gameMethods.Show("memory3_13");
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.OpenDialog(9400); // "人群散去，我看到那个男孩依然站在原地。"
        yield return _gameMethods.EngineSetVolume(volume:3.0f, delay:1.0f, channelName:"soundb");
        yield return _gameMethods.StopSound(channelName:"music2", fadeOut:10.0f);
        yield return _gameMethods.Show("memory3_14");
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.StopEngineTime(time:2.0f);
        yield return _gameMethods.Show("memory3_15");
        yield return _gameMethods.Transition(time:0.8f);
        yield return _gameMethods.StopEngineTime(time:1.0f);
        yield return _gameMethods.Show("memory3_16");
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(9401); // "他望着雕像走神，又仿佛若有所思。"
        yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:2.0f);
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/jiaotang/Inspiration_01.ogg");
        yield return _gameMethods.Hide("memory3_11");
        yield return _gameMethods.Hide("memory3_12");
        yield return _gameMethods.Hide("memory3_13");
        yield return _gameMethods.Hide("memory3_14");
        yield return _gameMethods.Hide("memory3_15");
        yield return _gameMethods.Show("memory3_17", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.7f}, {"alpha", 1.0f}})});
        yield return _gameMethods.OpenDialog(9402); // "一种临时的冲动涌上胸口，又仿佛实际上是某种我已等..."
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/jiaotang/Step Forward_01.ogg");
        yield return _gameMethods.Show("memory3_17", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        yield return _gameMethods.OpenDialog(9403); // "我走上前去。"
        yield return _gameMethods.Show("memory3_18", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.7f}, {"alpha", 1.0f}})});
        yield return _gameMethods.OpenDialog(9404); // "你问这些是不会有结果的。"
        yield return _gameMethods.Show("memory3_18", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        yield return _gameMethods.Show("memory3_19", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.7f}, {"alpha", 1.0f}})});
        yield return _gameMethods.OpenDialog(9405); // "我开口说道。"
        yield return _gameMethods.PlaySound("sounda1", 0.0f, 1.0f, "audio/sound/jiaotang/Church With Birds_01.mp3");
        yield return _gameMethods.Show("memory3_19", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        yield return _gameMethods.Show("memory3_20", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.7f}, {"alpha", 1.0f}})});
        yield return _gameMethods.OpenDialog(9406); // "他朝我看来。"
        yield return _gameMethods.Show("memory3_21", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.7f}, {"alpha", 1.0f}})});
        yield return _gameMethods.OpenDialog(9407); // "这是我第一次进入洛恩的视野。"
        yield return _gameMethods.Show("memory3_21", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        yield return _gameMethods.OpenDialog(9408); // "我的心头浮上了某种正式步入舞台、亲手揭开了帷幕的..."
        yield return _gameMethods.OpenDialog(9409); // "以及，轻微的兴奋感。"
        yield return _gameMethods.OpenDialog(9410); // "我说——"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_qian");
        yield return _gameMethods.OpenDialog(9411); // "“因为这些‘事实’都是自然的意志所认定的。”"
        yield return _gameMethods.Scene("woshi_nv1_chuang1");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan20", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.67f}, {"alpha", 0.0f}, {"blur", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1.0f}, {"blur", 0.0f}})});
        Defaults.Gui_duihuakuang_you = 1;
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.PlaySound("sounda1", 0.0f, 2.0f, "audio/sound/emeng_dajie/Swing Whoosh_01.mp3");
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai1");
        yield return _gameMethods.OpenDialog(9412); // "诺伯拉的声音将我拉回了现实。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui13"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.OpenDialog(9413); // "他们认为，判断事物正确或错误与否的标准在于自然的..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui6"});
        yield return _gameMethods.OpenDialog(9414); // "一件事情，因为自然地存在，就算正确，而不是因为它..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan18", "zui4"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo1_qian");
        yield return _gameMethods.OpenDialog(9415); // "「衡量正确的尺度是，——且仅是——，{nw}{w..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan18", "zui16"});
        yield return _gameMethods.OpenDialog(9416); // "自然的运行和意志。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan18", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai1");
        yield return _gameMethods.OpenDialog(9417); // "他不紧不慢地道出了我当初所讲的话语。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/houhui/Tight Face_02_duan.mp3");
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/demo_audio/sound/xintiao.ogg");
        yield return _gameMethods.PlaySound("music", 4.0f, 0.8f, "audio/music/kepa/Ritual of snowfall.mp3");
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei3", "yan1", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(9418); // "有一瞬间，惊悚升起，寒意爬上我的后背。"
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 10;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei5", "yan5", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(9419); // "他怎么会了解我的过去？"
        yield return _gameMethods.OpenDialog(9420); // "这种仿佛被了如指掌的惊疑不定和警惕感，在霎那间冲..."
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei5", "yan20", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui8"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan18", "zui8"});
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei4", "yan12", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(9421); // "……很快，我意识到，我恐怕是被读心了。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei4", "yan17", "zui12"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei4", "yan5", "zui10", "-emoji2"});
        yield return _gameMethods.OpenDialog(9422); // "你读到了我的想法？"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei4", "yan5", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui12"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
        yield return _gameMethods.OpenDialog(9423); // "他却没有立刻回答。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui12"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
        yield return _gameMethods.OpenDialog(9424); // "诺伯拉垂了垂眼睫，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui12"});
        yield return _gameMethods.OpenDialog(9425); // "沉默片刻，"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui12"});
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei4", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(9426); // "直到我看向他，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui8"});
        yield return _gameMethods.OpenDialog(9427); // "才云淡风轻地微微一笑。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui14"});
        yield return _gameMethods.OpenDialog(6230); // "……是啊。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui16"});
        yield return _gameMethods.OpenDialog(9428); // "你总是会被我听到心声呢。"
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:5.0f);
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei3", "yan5", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.PlaySound("music1", 3.0f, 1.0f, "audio/demo_audio/music/richang1.mp3");
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.OpenDialog(9429); // "所以，你对这些看法如何？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan10", "zui18"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
        yield return _gameMethods.OpenDialog(9430); // "「类似于——“有用的思想才是好思想”、{nw}{..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui14"});
        yield return _gameMethods.OpenDialog(9431); // "“靠山山倒，最终还是要靠自己”之类的么。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 3;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei3", "yan8", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(9432); // "……怎么回事，连这些都被他读到了吗。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei3", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(9433); // "小时候，我的确曾在参加礼拜时多次这么叛逆地腹诽过..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei4", "yan17", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei3", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(9434); // "但这些话过于大逆不道，我从来也只敢在心里想想，最..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei4", "yan13", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei3", "yan9", "zui15"});
        yield return _gameMethods.OpenDialog(9435); // "居然会在今天听到这句话。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
        yield return _gameMethods.OpenDialog(9436); // "是我刚才脑中掠过的潜意识？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei4", "yan18", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei5", "yan12", "zui18", "emoji13"});
        yield return _gameMethods.OpenDialog(9437); // "感觉被他摸清到令人恶寒的程度了。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei3", "yan10", "zui3"});
        yield return _gameMethods.OpenDialog(9438); // "……总觉得自从和你遇见后，我的压力陡然剧增。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui3"});
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 2;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei3", "yan10", "zui6"});
        yield return _gameMethods.OpenDialog(9439); // "正相反，与你相遇，我倒是很高兴呢。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei3", "yan24", "zui19"});
        yield return _gameMethods.OpenDialog(7254); // "哈哈。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_qian", parts: new List<string>{"mei2", "yan12", "zui19"});
        yield return _gameMethods.OpenDialog(9440); // "「那么现在，{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan5", "zui3", "-emoji2", "-emoji13"});
        yield return _gameMethods.OpenDialog(9441); // "你能回想起控制住龙的方法了吗？」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan9", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei3", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(9442); // "嗯，好像记起来了。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
        yield return _gameMethods.OpenDialog(9443); // "「以尼德霍格的位格。{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui13"});
        yield return _gameMethods.OpenDialog(9444); // "足够控制住他的，在这世上其实只有两样事物。」"
        yield return _gameMethods.Hide("nuo_heart_layered");
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(9445); // "一个是预言中所记述的，拥有压制住他的可能性的‘勇..."
        yield return _gameMethods.OpenDialog(9446); // "而另一个，则是效力路径特殊、能够无视位格差距的‘..."
        yield return _gameMethods.StopSound(channelName:"music1", fadeOut:4.0f);
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(9447); // "我正专心致志地仔细聆听着，却逐渐感觉到了某种奇怪..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui18", "emoji2"});
        yield return _gameMethods.OpenDialog(9448); // "违和感……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan7", "zui18"});
        yield return _gameMethods.OpenDialog(9449); // "那个声音，好像是从身后传过来。"
        yield return _gameMethods.OpenDialog(9450); // "就仿佛……有一个人正活生生在我的身后说话一般。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 3.0f, "audio/sound/manbu/Body1_02_duan.mp3");
        yield return _gameMethods.Show("woshi_nv4", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.8f, 1.79f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 1.25f}, {"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1.0f}})});
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.25f, 3.06f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.65f}, {"alpha", 0.0f}, {"blur", 0.01f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.OpenDialog(9451); // "我转过身去。"
        yield return _gameMethods.Show("woshi_nv4", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}, {"blur", 0.0f}})});
        Engine._history = false;
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.OpenDialog(9452); // "看到的景象令我瞪大了眼睛。"
        yield return _gameMethods.OpenDialog(9453); // "他的身形出现在了现实之中。\n那个高大的身影，活..."
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan25", "zui10", "emoji2"});
        yield return _gameMethods.OpenDialog(9454); // "「你、"
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/moca1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0.0f}, {"parallel_1", true}})});
        yield return _gameMethods.OpenDialog(9455); // "你怎么……！」"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"yoffset", 0.0f}})});
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui16"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan25", "zui15"});
        yield return _gameMethods.OpenDialog(9456); // "是心理幻觉。"
        yield return _gameMethods.PlaySound("sounda1", 0.0f, 1.0f, "<from 0 to 0.8>audio/sound/jiaobusheng_nuo_normal1.ogg");
        yield return _gameMethods.PlaySound("music", 2.0f, 0.5f, "audio/music/bing_xia.mp3");
        yield return _gameMethods.PlaySound("sounda2", 0.2f, 0.2f, "audio/demo_audio/sound/moca2.mp3");
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.5f}, {"zpos", 36.0f}})});
        yield return _gameMethods.OpenDialog(9457); // "白发青年微笑着俯身，伸手勾起了我的一缕头发。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui13"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 36.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_qian");
        yield return _gameMethods.OpenDialog(9458); // "「即便遥隔千里——{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui14"});
        yield return _gameMethods.OpenDialog(9459); // "\n我都只在你的视野、你的感知中存在。」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan17", "zui1"});
        yield return _gameMethods.OpenDialog(9460); // "这是我们彼此之间，联结和羁绊加深的表现。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui3"});
        yield return _gameMethods.OpenDialog(6516); // "开心吗？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan18", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei6", "yan10", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(9461); // "{size=+10}开心坏了。{/size}"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(9462); // "我的心情降到了谷底。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui8"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei6", "yan24", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan18", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(9463); // "所以，我们之间的羁绊加深，结果就是他能对我施加更..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei6", "yan11", "zui18"});
        yield return _gameMethods.OpenDialog(9464); // "虽然我知道大自然一向弱肉强食，力量决定一切，但这..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui3"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(9465); // "呵呵……当然不仅如此，小公主。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(9466); // "你对我所能施加的影响，远比你想象中的要更深哦。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui17"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(9467); // "「比如说，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui14"});
        yield return _gameMethods.OpenDialog(9468); // "如果你现在拿着世界树枝干，{nw}{w=0.01..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui13"});
        yield return _gameMethods.OpenDialog(9469); // "就已经可以凭借它轻易控制住我了。」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei5", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei5", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(9470); // "等一下，如果必须羁绊够深的对象，才能让你施加心理..."
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei5", "yan8", "zui10"});
        yield return _gameMethods.OpenDialog(9471); // "「那你初次来到人类社会时，遇到的那两个奇怪的人，..."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei5", "yan10", "zui10"});
        yield return _gameMethods.OpenDialog(9472); // "你们之间……？」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei4", "yan7", "zui12"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei5", "yan8", "zui14", "emoji2"});
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei4", "yan21", "zui16"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(9473); // "我可以随时对面前的生物施加幻觉。"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(9474); // "「只是远距离的影响需要密切的联系而已。{nw}{..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei3", "yan2", "zui13"});
        yield return _gameMethods.OpenDialog(9475); // "你在想什么？」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei3", "yan21", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan12", "zui10"});
        yield return _gameMethods.OpenDialog(9476); // "原来如此。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(6327); // "我松了口气。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan9", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui4"});
        Defaults.Persistent.Jq_7_8 = 1;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(9477); // "「如果当时遇到的是你，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui13"});
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(9478); // "说不定会更有意思吧。」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan7", "zui3", "emoji2"});
        yield return _gameMethods.OpenDialog(9479); // "「哈哈。如果当时遇到的是我，{nw}{w=0.0..."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan12", "zui19", "-emoji2"});
        yield return _gameMethods.OpenDialog(9480); // "你早就对我失去兴趣了……」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei7", "yan8", "zui6"});
        yield return _gameMethods.OpenDialog(9481); // "「哎呀，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui3"});
        yield return _gameMethods.OpenDialog(9482); // "对自己这么没有信心吗？」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui10", "-emoji2"});
        yield return _gameMethods.OpenDialog(9483); // "我只是对自己的实力具备合理的认知。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui16"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(9484); // "不是哦。——你只是不相信我。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui16"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(9485); // "「不想付出信任，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui17"});
        yield return _gameMethods.OpenDialog(9486); // "所以，不会怀抱期待。」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(9487); // "这样，你就不用忍受希望落空的痛苦和耻辱了。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(9488); // "不愧是人类专家。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan24", "zui8"});
        yield return _gameMethods.OpenDialog(9489); // "他应该拿个心理学学位。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.5>audio/sound/jiaobusheng_xin_normal1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.7f}, {"zpos", 66.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei1", "yan12", "zui19"});
        yield return _gameMethods.OpenDialog(9490); // "「没办法啦，人类的精神就是这么脆弱，{nw}{w..."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(9491); // "所以会寻找外壳，保护自己。」"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 66.0f}})});
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 2;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan6", "zui20"});
        yield return _gameMethods.OpenDialog(9492); // "哪怕错过一些美好也没关系，只要能躲避一次伤害，就..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan10", "zui6"});
        yield return _gameMethods.OpenDialog(9493); // "况且，自己值不值得信任难道你自己心里没点数吗。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui12"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(1599); // "「……{nw}{w=0.1}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei2", "yan2", "zui8"});
        yield return _gameMethods.OpenDialog(226); // "{nw}{w=0.2}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei11", "yan11", "zui8"});
        yield return _gameMethods.OpenDialog(1265); // "……」"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan10", "zui19"});
        yield return _gameMethods.OpenDialog(9494); // "所以呢，这份胆怯和懦弱让你对我失望了？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei3", "yan10", "zui7"});
        yield return _gameMethods.OpenDialog(9495); // "「不，正相反的是，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.OpenDialog(9496); // "这样的你，反而让我产生了一种……」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(9497); // "想要仔细对待的，心痒？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei5", "yan8", "zui3"});
        yield return _gameMethods.OpenDialog(9498); // "就像看到一只好像很可怜的野生狗，于是心血来潮想捡..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui3"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei5", "yan8", "zui5"});
        yield return _gameMethods.OpenDialog(9499); // "「就像看到了一朵独自开放的玫瑰，想干扰它的自由，..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui17"});
        yield return _gameMethods.OpenDialog(9500); // "摘下它，把它变成属于自己的花那样。」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(9501); // "你刚才说了很越界的发言吧。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan10", "zui15"});
        yield return _gameMethods.OpenDialog(9502); // "注意点啊。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.7f, "<from 0 to 1.5>audio/sound/jiaobusheng_nuo_normal1.ogg");
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan9", "zui13"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 36.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.6f}, {"zpos", 50.0f}})});
        yield return _gameMethods.OpenDialog(9503); // "小公主，你呢，就像一只在风中忽闪着飞过的蝴蝶。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui14"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 50.0f}})});
        yield return _gameMethods.OpenDialog(9504); // "大大的翅膀，那么美丽而单薄，在寒风里微微颤抖，又..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui16"});
        yield return _gameMethods.OpenDialog(9505); // "即使被拢进掌心，断去后路，你也会机灵地兜着圈子，..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui17"});
        yield return _gameMethods.OpenDialog(9506); // "——所以，就会让人好奇。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui1"});
        yield return _gameMethods.OpenDialog(9507); // "如果伸出手指，捕获住你，\n属于我的你，会在手心..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_qian");
        yield return _gameMethods.OpenDialog(9508); // "「再然后，如果更进一步，捏紧了你的翅膀，{nw}..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui13"});
        yield return _gameMethods.OpenDialog(9509); // "逼迫得你动弹不得，再也无法保留，{nw}{w=0..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui14"});
        yield return _gameMethods.OpenDialog(9510); // "你又会露出怎样的表情呢？」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei5", "yan10", "zui13", "emoji2", "emoji5"});
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15", "emoji16", "emoji6"});
        yield return _gameMethods.OpenDialog(9511); // "{size=+5}别说微微颤抖，{/size}{..."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei5", "yan12", "zui18", "emoji6"});
        yield return _gameMethods.OpenDialog(9512); // "{size=+10}我的心已经在剧烈地震了。{/..."
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/moca1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0.0f}, {"parallel_1", true}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei6", "yan22", "zui2"});
        yield return _gameMethods.OpenDialog(9513); // "怎么回事啊你这龙。"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei6", "yan12", "zui8"});
        yield return _gameMethods.OpenDialog(9514); // "好恐怖。"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei6", "yan13", "zui1"});
        yield return _gameMethods.OpenDialog(9515); // "你才是黑暗与灾祸之龙吧。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"yoffset", 0.0f}})});
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui8"});
        Engine._history = false;
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.OpenDialog(5404); // "我看着他。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.OpenDialog(9516); // "他懒洋洋地，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui8"});
        yield return _gameMethods.OpenDialog(9517); // "露出一个随意又轻飘飘的笑容。"
        yield return _gameMethods.OpenDialog(9518); // "看不出是在说实话，抑或是开玩笑的恐吓。"
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:5.0f);
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui8"});
        yield return _gameMethods.OpenDialog(9519); // "危险感。"
        yield return _gameMethods.OpenDialog(9520); // "仿佛在冰地上行进，一脚踏空，陷入了冰层下深不见底..."
        yield return _gameMethods.PlaySound("sounda1", 0.0f, 1.0f, "audio/sound/emeng_dajie/Magic Spell Book Pages Flipping_01.ogg");
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei4", "yan1", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(9521); // "我突然意识到了一个危险的事实。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan6", "zui15", "-emoji5"});
        yield return _gameMethods.OpenDialog(9522); // "引起他的兴趣，对我是有利的。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(9523); // "但是一旦涉足更深，引来更庞大的注视，反而便要弥足..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui8"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan20", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(9524); // "就像为了摆脱一个陷阱，而不慎触发了另一个陷阱。"
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.PlaySound("music1", 4.0f, 0.8f, "audio/music/kepa/The witch's small house.mp3");
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1.5>audio/sound/jiaobusheng_nuo_normal1.ogg");
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 50.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 1.0f}, {"zpos", 128.0f}})});
        Engine._history = false;
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.OpenDialog(9525); // "我僵在原地，诺伯拉却向我走近两步。"
        yield return _gameMethods.PlaySound("sounda", 0.0f, 3.0f, "audio/sound/manbu/Body1_02_duan.mp3");
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan19", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 128.0f}})});
        yield return _gameMethods.OpenDialog(9526); // "他俯下身，伸出一只手指，点在了我脖颈上的蝴蝶结上..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.OpenDialog(9527); // "抬了抬指尖，勾起蓬松柔软的缎带。"
        yield return _gameMethods.OpenDialog(9528); // "那轻微到几不可查的拉扯力，仿佛钩子，扯住人类细弱..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui17"});
        yield return _gameMethods.OpenDialog(9529); // "所以，这不是很糟糕吗？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan17", "zui13"});
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/bai_about_nvwang_8debd273.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nuo_qian");
        yield return _gameMethods.OpenDialog(9530); // "「越是拼命挣扎，不甘心坠落，{nw}{w=0.0..."
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/bai_about_nvwang_f206176b.ogg");
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan18", "zui16"});
        yield return _gameMethods.OpenDialog(9531); // "就越是散发出强烈的吸引力，招来那些藏身暗处的庞然..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan18", "zui8"});
        yield return _gameMethods.OpenDialog(9532); // "他在我脸侧微微俯首，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui8"});
        yield return _gameMethods.OpenDialog(9533); // "附耳轻声说。"
        yield return _gameMethods.Show("black", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 128.0f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(9534); // "你这么脆弱，却总是表现得这么冷静呢。"
        yield return _gameMethods.OpenDialog(9535); // "微凉的吐息，宛如真实存在一般拂过耳廓。"
        yield return _gameMethods.OpenDialog(9536); // "些微的痒意让我一个激灵，头皮发麻。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei5", "yan5", "zui15", "emoji2", "emoji5"});
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.Hide("black");
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan18", "zui8"});
        yield return _gameMethods.Transition(time:0.5f);
        Engine._history = false;
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui8"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan18", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan9", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(9537); // "我沉默了几秒，{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei5", "yan12", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(9538); // "保持了面上的镇定，抬起手，{nw}{w=0.01..."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan5", "zui15", "-emoji5", "-emoji16"});
        yield return _gameMethods.OpenDialog(9539); // "揉了揉自己的耳朵。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(9540); // "「…………你的台词功底真好，{nw}{w=0.0..."
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei8", "yan2", "zui19"});
        yield return _gameMethods.OpenDialog(9541); // "不愧是戏剧爱好者，文采斐然。」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei8", "yan2", "zui7"});
        yield return _gameMethods.OpenDialog(9542); // "呵呵，很不错吧。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1.5>audio/sound/jiaobusheng_nuo_normal1.ogg");
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 1.0f}, {"zpos", 50.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(9543); // "他松开手，恢复了原本的距离，仿若无事地微笑。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui13"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 50.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(9544); // "我也有扮演过剧院的演员呢，虽然是配角。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan10", "zui3"});
        yield return _gameMethods.OpenDialog(9545); // "厉害，太厉害了。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(9546); // "能给我也讲讲吗？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui3"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei8", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(2471); // "好啊。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(9547); // "我岔开话题，他任由我岔开了话题。"
        yield return _gameMethods.StopSound(channelName:"music1", fadeOut:5.0f);
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(9548); // "我和诺伯拉谈笑风生，度过了一段融洽的时光。"
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Scene("woshi_nv4_tian");
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/emeng_dajie/Lying Bed_01.mp3");
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.PlaySound("music1", 4.0f, 1.0f, "audio/demo_audio/music/richang1.mp3");
        yield return _gameMethods.OpenDialog(9549); // "等诺伯拉离开后，我倒在床上，看着床帐的顶部。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(9550); // "那股传过脊背的寒意，尚且盘旋不去。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(9551); // "…………………想了一会儿。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 2.0f, "audio/sound/manbu/Body1_02_duan.mp3");
        yield return _gameMethods.Show("woshi_nv_chuang2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}, {"pos", new Vector2(-114.0f, 0.0f)}, {"anchor", new Vector2(0.0f, 0.0f)}, {"zoom", 0.37f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan12", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(9552); // "算了。我释然了。"
        yield return _gameMethods.Show("woshi_nv_chuang2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(9553); // "他能图我什么呢？\n就算想要带走我，也得排队。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan24", "zui7", "emoji2"});
        yield return _gameMethods.OpenDialog(9554); // "还有一头龙排在他前面呢。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui8", "emoji2"});
        yield return _gameMethods.OpenDialog(9555); // "诺伯拉和赫泽尔，要不他们两个先辩一辩吧。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui8"});
        yield return _gameMethods.OpenDialog(9556); // "这样的话，对我反而变成了好事。"
        yield return _gameMethods.Scene("woshi_nv4", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(1.12f, 1.39f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 1.04f}})});
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1.5>audio/sound/jiaobusheng_xin_normal1.ogg");
        yield return _gameMethods.TransitionBy("trans_rip_fast");
        yield return _gameMethods.OpenDialog(9557); // "想清这些后，我稍微放下心来，继续钻研真言。"
        yield return _gameMethods.ChangeLabelTo("label_he_StudyWords");
        yield break;
    }

    public IEnumerator label_bai_shenglitong()
    {
        yield return _gameMethods.OpenDialog(9558); // "我把脸埋进枕头里，默默忍耐着那剧烈的痛苦。"
        Defaults.Persistent.Jq_8_3 = 1;
        yield return _gameMethods.PlaySound("music1", 4.0f, 1.0f, "audio/demo_audio/music/time_syuanji.mp3");
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.67f}, {"alpha", 0.0f}, {"blur", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.OpenDialog(9559); // "哎呀，这是什么情况？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai1");
        yield return _gameMethods.OpenDialog(9560); // "诺伯拉的声音，忽然在脑海中冒出。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_wu", parts: new List<string>{"mei5", "yan12", "zui8", "emoji5"});
        yield return _gameMethods.OpenDialog(9561); // "（我今天心情很差，警告你别惹我。）"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan4", "zui5"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
        yield return _gameMethods.OpenDialog(9562); // "「哇，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui14"});
        yield return _gameMethods.OpenDialog(9563); // "怎么了？」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei6", "yan11", "zui15", "emoji2", "-emoji5"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.PlaySound("sound", 0.2f, 0.4f, "audio/demo_audio/sound/moca2.mp3");
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei9", "yan20", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(9564); // "我懒得动弹，没有回答。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui17"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
        yield return _gameMethods.OpenDialog(9565); // "「……哦——这样啊。{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan17", "zui16"});
        yield return _gameMethods.OpenDialog(9566); // "你偏头痛了。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui14"});
        yield return _gameMethods.OpenDialog(9567); // "那么，要帮忙吗？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_wu", parts: new List<string>{"mei8", "yan21", "zui15"});
        yield return _gameMethods.OpenDialog(9568); // "（什么……）"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui14"});
        yield return _gameMethods.OpenDialog(9569); // "忘了么？我掌握的可是心理幻觉哦。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.OpenDialog(9570); // "不光是视觉，对于其它部分感官，也可以短暂地施加影..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui2"});
        yield return _gameMethods.OpenDialog(9571); // "所以只要想的话，就能让你舒服起来。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_wu", parts: new List<string>{"mei3", "yan12", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(9572); // "（代价是什么？）"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui16"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
        yield return _gameMethods.OpenDialog(9573); // "「代价吗……{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui14"});
        yield return _gameMethods.OpenDialog(9574); // "代价就是，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui1"});
        yield return _gameMethods.OpenDialog(9575); // "和我的羁绊会变得更深刻吧。」"
        yield return _gameMethods.OpenSelectMenu(
            talk: new List<string>{"-那就变深吧", "-那就算了吧"},
            jump: new List<string>{"label_bai_menu_2_kz6j28WA", "label_bai_menu_2_h2t5SbbU"},
            condition: new List<string>{"NONE", "NONE"}
        );
    }

    public IEnumerator label_bai_1()
    {
        yield return _gameMethods.StopSound(channelName:"music1", fadeOut:5.0f);
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
        yield return _gameMethods.OpenDialog(9592); // "「——来吧，小公主。{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui3"});
        yield return _gameMethods.OpenDialog(9593); // "来做一件我愿意为你去做的事。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.Scene("bai_shengliqi_ditu1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.0f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.89f}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.79f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 2.5f}, {"xpos", 0.40f}})});
        yield return _gameMethods.Hide("nuo_heart_layered");
        yield return _gameMethods.Show("2-23_zoom");
        yield return _gameMethods.Hide("2-23_zoom");
        yield return _gameMethods.PlaySound("sounda5", 0.0f, 0.7f, "audio/demo_audio/sound/tangxia1.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        Defaults.Gui_duihuakuang_you = 0;
        yield return _gameMethods.TransitionWithFadeIn(outTime:0.2f, holdTime:0.2f, inTime:1.0f, colorCode:"#fff");
        yield return _gameMethods.OpenDialog(9594); // "身后似乎多了一具身体，仿佛有一只半透明的手放在了..."
        yield return _gameMethods.OpenDialog(9595); // "逐渐的，一股宛若错觉的热意从那里扩散开来。"
        yield return _gameMethods.OpenDialog(9596); // "他对我施加的幻觉逐渐生效，侵占了原本的感官。"
        yield return _gameMethods.OpenDialog(9597); // "好了，你要用什么感觉来替换呢？"
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("bai_shengliqi_ditu1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(0.40f, 1.0f)}})});
        yield return _gameMethods.OpenDialog(9598); // "此时，身体的感官被掌握在他的手中，原本的痛苦也变..."
        yield return _gameMethods.OpenDialog(9599); // "听到这句话、我感觉……"
        yield return _gameMethods.OpenSelectMenu(
            talk: new List<string>{"-信赖而松弛"},
            jump: new List<string>{"label_bai_menu_3_2w1Cqot7"},
            condition: new List<string>{"NONE"}
        );
    }

}
