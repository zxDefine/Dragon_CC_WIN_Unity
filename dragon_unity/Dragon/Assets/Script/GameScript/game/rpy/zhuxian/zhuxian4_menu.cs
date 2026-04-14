
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class zhuxian4_menu : ILabelProvider
{
    private GameMethods _gameMethods;

    public zhuxian4_menu(GameMethods gameMethods)
    {
        _gameMethods = gameMethods;
    }
    
    public IEnumerator label_zhuxian4_menu_0_0Th11hcK()
    {
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/manbu/Silence+Other Sounds _01.ogg");
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -36f}, {"zpos", -96.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.3f}, {"ypos", -114f}, {"zpos", -258.0f}})});
                yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan1", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.2f}, {"alpha", 0f}})});
                yield return _gameMethods.OpenDialog(3525); // "手指果然穿过了他的脸颊。"
                yield return _gameMethods.PlaySound("sounda", 0.0f, 0.5f, "audio/demo_audio/sound/moca2.mp3");
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -114f}, {"zpos", -258.0f}})});
                yield return _gameMethods.Show("an2", parts: new List<string>{"mei8", "yan2", "zui8", "emoji2", "emoji4"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.2f}, {"alpha", 1f}, {"blur", 0f}})});
                Defaults.Haogandu_an = Defaults.Haogandu_an + 1;
                yield return _gameMethods.ExecuteCharacterImageData("an_qian");
                yield return _gameMethods.OpenDialog(3526); // "「去去去、{nw}{w=0.1}"
                yield return _gameMethods.Show("an2", parts: new List<string>{"mei8", "yan15", "zui8", "emoji2", "emoji4"});
                yield return _gameMethods.ExecuteCharacterImageData("an_qian");
                yield return _gameMethods.OpenDialog(3527); // "摸哪儿呢？」"
                yield return _gameMethods.Show("an2", parts: new List<string>{"mei8", "yan15", "zui1", "emoji2", "emoji4"});
                yield return _gameMethods.OpenDialog(3528); // "他挥挥手，像驱赶飞虫一样。"
                yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan16", "zui6", "-emoji2", "emoji4", "emoji20"});
                yield return _gameMethods.ExecuteCharacterImageData("an");
                yield return _gameMethods.OpenDialog(3529); // "少没大没小的，占我便宜是不是？"
                yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan16", "zui1", "emoji4", "emoji20"});
                yield return _gameMethods.OpenDialog(3530); // "也就比我大半年，摆什么架子呀。"
                yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui10"});
                yield return _gameMethods.OpenDialog(3531); // "「这不是看你好久没见，{nw}{w=0.1}"
                Defaults.Haogandu_an = Defaults.Haogandu_an + 1;
                yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan11", "zui19"});
                yield return _gameMethods.OpenDialog(3532); // "又变帅气了么。」"
                yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan4", "zui1", "emoji4", "-emoji20", "emoji2"});
                yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian", parts: new List<string>{"mei7", "yan11", "zui7"});
                yield return _gameMethods.OpenDialog(3533); // "「…{nw}{w=0.4}"
                yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan19", "zui1", "emoji2", "emoji1", "emoji4"});
                yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
                yield return _gameMethods.OpenDialog(3534); // "…」"
                yield return _gameMethods.Show("an2", parts: new List<string>{"mei8", "yan16", "zui13", "emoji2", "-emoji1", "emoji4", "emoji8"});
                yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
                yield return _gameMethods.OpenDialog(3535); // "你还真是一样的花言巧语啊……"
                yield return _gameMethods.Show("an2", parts: new List<string>{"mei8", "yan16", "zui16", "emoji2", "-emoji1", "emoji4", "emoji8"});
                yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan11", "zui19"});
                yield return _gameMethods.OpenDialog(3536); // "「嘿嘿。开个玩笑。{nw}{w=0.1}"
                yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei3", "yan2", "zui10"});
                yield return _gameMethods.OpenDialog(3537); // "其实、我真正要说的是……」"
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 12f}, {"zpos", 30.0f}})});
                yield return _gameMethods.TransitionBy("blink2");
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan2", "zui15"});
                yield return _gameMethods.OpenDialog(3538); // "我收起笑容，一脸凝重。"
                yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei4", "yan5", "zui10"});
                yield return _gameMethods.OpenDialog(3539); // "安德鲁，你怎么老了这么多。一脸沧桑的。"
                yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan8", "zui1", "emoji2", "-emoji1", "emoji4", "-emoji8"});
                yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei4", "yan5", "zui15"});
                yield return _gameMethods.OpenDialog(3540); // "？"
                yield return _gameMethods.Show("an2", parts: new List<string>{"mei5", "yan2", "zui8", "emoji2", "-emoji4"});
                yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
                yield return _gameMethods.OpenDialog(3541); // "「你胡说八道，{nw}{w=0.1}"
                yield return _gameMethods.Show("an2", parts: new List<string>{"mei5", "yan16", "zui8", "emoji2", "-emoji4"});
                yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
                yield return _gameMethods.OpenDialog(3542); // "明明一路上的人都崇拜地叫我“尊敬的勇者大人”好不好？」"
                yield return _gameMethods.Show("an2", parts: new List<string>{"mei5", "yan16", "zui1"});
                yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei3", "yan12", "zui19"});
                yield return _gameMethods.OpenDialog(3543); // "「他们可真是{nw}{w=0.1}"
                yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei5", "yan2", "zui2", "emoji7"});
                yield return _gameMethods.OpenDialog(3544); // "尊老爱幼啊。」"
                yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan20", "zui12", "emoji6"});
                yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei5", "yan2", "zui7", "emoji7"});
                yield return _gameMethods.OpenDialog(3545); // "你找茬是吧。"
                yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan20", "zui10", "emoji6"});
                yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan6", "zui17", "-emoji7"});
                yield return _gameMethods.OpenDialog(3546); // "我若无其事地侧头看风景。"
                yield return _gameMethods.ChangeLabelTo("label_choice25");

    }

    public IEnumerator label_zhuxian4_menu_0_A0AvA9S7()
    {
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/manbu/Silence+Other Sounds _01.ogg");
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -36f}, {"zpos", -96.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.37f}, {"ypos", 156f}, {"zpos", -294.0f}})});
                yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan1", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.2f}, {"alpha", 0f}})});
                yield return _gameMethods.OpenDialog(3547); // "手指果然穿过了他的身躯。"
                yield return _gameMethods.PlaySound("sound", 0.0f, 0.6f, "<from 0 to 0.5>audio/sound/emeng_dajie/walking_on_the_earth_01.mp3");
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 156f}, {"zpos", -294.0f}})});
                yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan4", "zui8", "emoji1", "emoji2", "emoji4", "emoji10"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 10f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.2f}, {"alpha", 1f}, {"blur", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.16f}}), new SameLineParamData(new Dictionary<string, object>{{"bop_to_time_warp", 0.2f}, {"yoffset", 0f}})});
                Defaults.Haogandu_an = Defaults.Haogandu_an + 1;
                yield return _gameMethods.ExecuteCharacterImageData("an");
                yield return _gameMethods.OpenDialog(3548); // "……喂、摸哪儿呢！"
                yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan8", "zui1", "emoji1", "emoji2", "emoji4", "-emoji10"});
                yield return _gameMethods.OpenDialog(3549); // "他立刻跳起，活像吃了大亏、被非礼了一般护住胸膛，{nw}{w=0.1}"
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 156f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.2f}, {"ypos", -108f}})});
                yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan17", "zui1", "emoji1", "emoji2", "emoji4"});
                yield return _gameMethods.ExecuteCharacterImageData("an");
                yield return _gameMethods.OpenDialog(3550); // "虚张声势，宛如一只张牙舞爪的螃蟹。"
                yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan17", "zui5", "emoji1", "emoji2", "emoji4"});
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -108f}})});
                yield return _gameMethods.ExecuteCharacterImageData("an");
                yield return _gameMethods.OpenDialog(3551); // "占我便宜是不是？"
                yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan17", "zui1", "emoji1", "emoji2", "emoji4"});
                yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui15"});
                yield return _gameMethods.OpenDialog(3396); // "……"
                yield return _gameMethods.ChangeLabelTo("label_choice23");

    }

    public IEnumerator label_zhuxian4_menu_0_yjTubabw()
    {
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan17", "zui1", "emoji1", "emoji2", "emoji4"});
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0.5 to 1.5>audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.45f}, {"ypos", 12f}, {"zpos", 30.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei4", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(3552); // "还好没碰到，不然我的手就脏了。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan16", "zui13", "emoji1", "emoji2", "emoji4", "emoji8"});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 12f}, {"zpos", 30.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei4", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(3553); // "喂！！！"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan2", "zui12", "emoji1", "emoji2", "emoji4", "emoji8"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv");
        yield return _gameMethods.OpenDialog(3554); // "那是你不走运好吧..."
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan2", "zui10", "emoji1", "emoji2", "emoji4", "-emoji8"});
        yield return _gameMethods.PlaySound("sound", 0.4f, 0.5f, "audio/demo_audio/sound/moca2.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 30.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.4f}, {"zpos", 6.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(3555); // "真的吗，我不信。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 6.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui19"});
        yield return _gameMethods.OpenDialog(3556); // "除非下次陪我出去采购..."
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei8", "yan16", "zui6", "emoji1", "emoji2", "-emoji3", "emoji4", "-emoji5", "emoji8"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
        yield return _gameMethods.OpenDialog(3557); // "你被洛恩传染了？"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei8", "yan16", "zui1", "emoji1", "emoji2", "-emoji3", "emoji4", "-emoji5", "-emoji8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei1", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(3558); // "不行吗？"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan17", "zui5", "emoji1", "emoji2", "-emoji3", "emoji4", "-emoji5", "emoji8"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei1", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(3559); // "……啊—，好—、行—。可以了吧？"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan2", "zui6", "emoji1", "emoji2", "-emoji3", "emoji4", "-emoji5", "emoji8"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv");
        yield return _gameMethods.OpenDialog(3560); // "我怎么摊上这么一个青梅竹马。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan17", "zui1", "emoji1", "emoji2", "-emoji3", "emoji4", "-emoji5", "emoji8"});
        yield return _gameMethods.PlaySound("sound", 0.4f, 0.5f, "audio/demo_audio/sound/moca2.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 6.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.4f}, {"zpos", 30.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(3561); // "太棒了，说定了。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan2", "zui1", "emoji1", "-emoji2", "emoji4", "-emoji8"});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 30.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian", parts: new List<string>{"mei7", "yan11", "zui7"});
        yield return _gameMethods.OpenDialog(3481); // "「……{nw}{w=0.1}"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan12", "zui14", "emoji1", "emoji4"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
        yield return _gameMethods.OpenDialog(3562); // "嗯，说定了。」"
        yield return _gameMethods.ChangeLabelTo("label_choice25");
    }

    public IEnumerator label_zhuxian4_menu_0_4zVrOITy()
    {
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan17", "zui1", "emoji1", "emoji2", "emoji4"});
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0.5 to 1.5>audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.45f}, {"ypos", 12f}, {"zpos", 30.0f}})});
        Defaults.Haogandu_an = Defaults.Haogandu_an + 1;
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10"});
        yield return _gameMethods.OpenDialog(3563); // "对。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan16", "zui13", "emoji1", "emoji2", "emoji4", "emoji8"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(3564); // "「……真理直气壮啊，{nw}{w=0.1}"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan23", "zui12", "emoji1", "emoji2", "emoji4", "emoji8"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
        yield return _gameMethods.OpenDialog(3565); // "强烈怀疑你对我图谋不轨。」"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan23", "zui10", "emoji1", "emoji2", "emoji4", "emoji8"});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 12f}, {"zpos", 30.0f}})});
        Defaults.Haogandu_an = Defaults.Haogandu_an + 1;
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui3"});
        yield return _gameMethods.OpenDialog(3563); // "对。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/moca1.ogg");
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan1", "zui1", "emoji1", "emoji2", "emoji4", "emoji8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"xoffset", -3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian", parts: new List<string>{"mei7", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(3533); // "「…{nw}{w=0.4}"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan17", "zui2", "emoji1", "emoji2", "emoji3", "emoji4", "emoji5", "emoji8"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
        yield return _gameMethods.OpenDialog(3566); // "…"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan2", "zui1", "emoji1", "emoji2", "emoji3", "emoji4", "emoji5", "emoji8"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
        yield return _gameMethods.OpenDialog(3567); // "……{nw}{w=0.3}"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan2", "zui12", "emoji1", "emoji2", "emoji3", "emoji4", "emoji5", "emoji8"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
        yield return _gameMethods.OpenDialog(3568); // "哈哈，可惜啊，你碰不到！」"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan13", "zui12", "emoji1", "emoji2", "emoji3", "emoji4", "emoji5", "emoji8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/choice23_1eaa5657.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("an_nv");
        yield return _gameMethods.OpenDialog(3569); // "我这一年肌肉壮了足足有一圈呢。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan13", "zui10", "emoji1", "emoji2", "emoji3", "emoji4", "emoji5", "emoji8"});
        yield return _gameMethods.PlaySound("sound", 0.4f, 0.5f, "audio/demo_audio/sound/moca2.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 30.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.4f}, {"zpos", 6.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui19"});
        yield return _gameMethods.OpenDialog(3555); // "真的吗，我不信。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 6.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan12", "zui19"});
        yield return _gameMethods.OpenDialog(3556); // "除非下次陪我出去采购..."
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei8", "yan16", "zui6", "emoji1", "emoji2", "-emoji3", "emoji4", "emoji5", "emoji8"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei3", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(3557); // "你被洛恩传染了？"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei8", "yan16", "zui1", "emoji1", "emoji2", "-emoji3", "emoji4", "emoji5", "emoji8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei1", "yan2", "zui9"});
        yield return _gameMethods.OpenDialog(3558); // "不行吗？"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan17", "zui5", "emoji1", "emoji2", "-emoji3", "emoji4", "emoji5", "emoji8"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei1", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(3559); // "……啊—，好—、行—。可以了吧？"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan2", "zui6", "emoji1", "emoji2", "-emoji3", "emoji4", "emoji5", "emoji8"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv");
        yield return _gameMethods.OpenDialog(3560); // "我怎么摊上这么一个青梅竹马。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan17", "zui1", "emoji1", "emoji2", "-emoji3", "emoji4", "emoji5", "emoji8"});
        yield return _gameMethods.PlaySound("sound", 0.4f, 0.5f, "audio/demo_audio/sound/moca2.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 6.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.4f}, {"zpos", 30.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(3561); // "太棒了，说定了。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui1", "emoji1", "-emoji2", "-emoji3", "emoji4", "-emoji5", "-emoji8"});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 30.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian", parts: new List<string>{"mei7", "yan2", "zui7"});
        yield return _gameMethods.OpenDialog(3533); // "「…{nw}{w=0.4}"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan3", "zui12", "emoji1", "emoji4"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
        yield return _gameMethods.OpenDialog(3562); // "嗯，说定了。」"
        yield return _gameMethods.ChangeLabelTo("label_choice25");
    }

    public IEnumerator label_zhuxian4_menu_0_GK2oHy5M()
    {
        yield return _gameMethods.ExecuteCharacterImageData("nv2");
        yield return _gameMethods.OpenDialog(3601); // "生气啦？"
        yield return _gameMethods.Show("yongzhe1_layered", parts: new List<string>{"-emoji3", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("an");
        yield return _gameMethods.OpenDialog(3602); // "……生气了。"
        yield return _gameMethods.Show("yongzhe1_layered", parts: new List<string>{"zui5"});
        yield return _gameMethods.ExecuteCharacterImageData("nv2");
        yield return _gameMethods.OpenDialog(3603); // "对不起啦。"
        Defaults.Haogandu_an = Defaults.Haogandu_an + 1;
        yield return _gameMethods.ExecuteCharacterImageData("nv2");
        yield return _gameMethods.OpenDialog(3604); // "我只想说，你能来，我真的很高兴。"
        yield return _gameMethods.ExecuteCharacterImageData("an");
        yield return _gameMethods.OpenDialog(3396); // "……"
        yield return _gameMethods.OpenDialog(3605); // "他没理我。"
        yield return _gameMethods.OpenDialog(3606); // "和以前相比，这次好像变难哄了一点。"
        yield return _gameMethods.OpenDialog(3607); // "再想几句话吧。"
        yield return _gameMethods.ShowWhite();
        yield return _gameMethods.PlaySound("sounda", 0.0f, 0.5f, "audio/demo_audio/sound/moca2.mp3");
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.5f, "<silence 0.5>audio/sound/emeng_dajie/finger_snap_01.mp3");
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(3608); // "他忽然毫无征兆地伸出手，弹了我一个脑瓜崩。"
        yield return _gameMethods.HideWhite();
        yield return _gameMethods.Hide("yongzhe1_layered");
        yield return _gameMethods.Show("yongzhe1_layered", parts: new List<string>{"emoji2", "mei2", "yan6", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.02f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.45f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(3609); // "阳光把他那张别扭的脸映得十分温暖。"
        yield return _gameMethods.ExecuteCharacterImageData("an");
        yield return _gameMethods.OpenDialog(3610); // "……算了，谁让我摊上这么一个不令人省心的青梅竹马呢。"
        yield return _gameMethods.Show("yongzhe1_layered", parts: new List<string>{"zui3"});
        yield return _gameMethods.ExecuteCharacterImageData("nv2");
        yield return _gameMethods.OpenDialog(3396); // "……"
        yield return _gameMethods.OpenDialog(3611); // "我捂住脑门，迟迟不动了。"
        yield return _gameMethods.ExecuteCharacterImageData("nv2");
        yield return _gameMethods.OpenDialog(3612); // "……完了，我被你敲得头疼。"
        yield return _gameMethods.ExecuteCharacterImageData("nv2");
        yield return _gameMethods.OpenDialog(3613); // "现在头疼不止，好不了了。"
        yield return _gameMethods.ExecuteCharacterImageData("nv2");
        yield return _gameMethods.OpenDialog(3614); // "你怎么赔我？"
        yield return _gameMethods.Show("yongzhe1_layered", parts: new List<string>{"mei4", "yan7", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("an");
        yield return _gameMethods.OpenDialog(3615); // "你少胡说啊。"
        yield return _gameMethods.ChangeLabelTo("label_choice27");
    }

    public IEnumerator label_zhuxian4_menu_0_VVbVxfcP()
    {
        yield return _gameMethods.OpenDialog(3616); // "根据我丰富的经验..."
        yield return _gameMethods.OpenDialog(3617); // "所以我只是默默观看他的背影。"
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/manbu/Body1_01.mp3");
        yield return _gameMethods.Scene("yongzhe1_layered", parts: new List<string>{"emoji1", "emoji2", "mei4", "yan6", "zui5"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.02f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.45f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(3618); // "果然，没过一会儿..."
        yield return _gameMethods.Show("yongzhe1_layered", parts: new List<string>{"zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("an");
        yield return _gameMethods.OpenDialog(3619); // "我说你啊……真的挺过分的吧？"
        yield return _gameMethods.Show("yongzhe1_layered", parts: new List<string>{"zui5"});
        yield return _gameMethods.ExecuteCharacterImageData("nv2");
        yield return _gameMethods.OpenDialog(3620); // "是吗。"
        yield return _gameMethods.Show("yongzhe1_layered", parts: new List<string>{"zui6", "mei3"});
        yield return _gameMethods.ExecuteCharacterImageData("an");
        yield return _gameMethods.OpenDialog(3621); // "是啊。"
        yield return _gameMethods.Show("yongzhe1_layered", parts: new List<string>{"zui5"});
        yield return _gameMethods.ExecuteCharacterImageData("nv2");
        yield return _gameMethods.OpenDialog(3622); // "比如？"
        yield return _gameMethods.Show("yongzhe1_layered", parts: new List<string>{"zui6", "-emoji2", "yan4"});
        yield return _gameMethods.ExecuteCharacterImageData("an");
        yield return _gameMethods.OpenDialog(3623); // "明明都被带走了..."
        yield return _gameMethods.Show("yongzhe1_layered", parts: new List<string>{"zui5"});
        yield return _gameMethods.ExecuteCharacterImageData("nv2");
        yield return _gameMethods.OpenDialog(3396); // "……"
        yield return _gameMethods.OpenDialog(3624); // "难以辩驳。"
        yield return _gameMethods.Show("yongzhe1_layered", parts: new List<string>{"zui2", "-emoji1"});
        yield return _gameMethods.ExecuteCharacterImageData("an");
        yield return _gameMethods.OpenDialog(3625); // "自己都自身难保了..."
        yield return _gameMethods.ExecuteCharacterImageData("nv2");
        yield return _gameMethods.OpenDialog(3396); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("an");
        yield return _gameMethods.OpenDialog(3626); // "明明一个人被恶龙抓走两年..."
        yield return _gameMethods.Show("yongzhe1_layered", parts: new List<string>{"yan7"});
        yield return _gameMethods.ExecuteCharacterImageData("an");
        yield return _gameMethods.OpenDialog(3627); // "你不觉得这种做法有问题吗？"
        yield return _gameMethods.Show("yongzhe1_layered", parts: new List<string>{"zui5"});
        yield return _gameMethods.ChangeLabelTo("label_choice26_1");
    }

    public IEnumerator label_zhuxian4_menu_0_L8UBVumN()
    {
        yield return _gameMethods.ExecuteCharacterImageData("nv2");
        yield return _gameMethods.OpenDialog(3628); // "确实有问题。但我也是有苦衷的。"
        yield return _gameMethods.ChangeLabelTo("label_choice26_1");
    }

    public IEnumerator label_zhuxian4_menu_0_AMVsmkZH()
    {
        yield return _gameMethods.ExecuteCharacterImageData("nv2");
        yield return _gameMethods.OpenDialog(3629); // "不觉得。"
        yield return _gameMethods.ChangeLabelTo("label_choice26_1");
    }

    public IEnumerator label_zhuxian4_menu_0_mxaXEbi9()
    {
        yield return _gameMethods.ChangeLabelTo("label_choice26");
    }

    public IEnumerator label_zhuxian4_menu_0_QTmFjhCo()
    {
        yield return _gameMethods.ChangeLabelTo("label_choice26");
    }

    public IEnumerator label_zhuxian4_menu_0_YLz3BRGa()
    {
        yield return _gameMethods.EngineSetVolume(volume:0.4f, delay:1f, channelName:"music");
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/door_open_3.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(3748); // "我打开了阳台的门。"
        yield return _gameMethods.Show("anniu_bg24_memory");
        yield return _gameMethods.Hide("anniu_bg24_memory");
        if (Defaults.Wangzixian == 1)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_10");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.Scene("woshi_nv1_yewan_yangtai_ani", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.33f, 0.72f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.77f}})});
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"lv1", "mei7", "yan7", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.32f, 2.46f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.51f}})});
        yield return _gameMethods.EngineSetVolume(volume:1f, delay:1f, channelName:"music");
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.ExecuteCharacterImageData("nuo");
        yield return _gameMethods.OpenDialog(3749); // "晚上好，公主殿下。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<from 0 to 1>audio/sound/jiaobusheng_xin_normal1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"zpos", -60.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(3750); // "晚上好，诺伯拉先生。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1");
        yield return _gameMethods.OpenDialog(3751); // "你出场的方式很特别。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(3752); // "我还以为你会形容为浪漫。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -60.0f}})});
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui3"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(3753); // "不觉得这样很像在幽会吗？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan24", "zui19"});
        yield return _gameMethods.OpenDialog(3754); // "「谢谢你如此肯定我的魅力。{nw}{w=0.1}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui2"});
        yield return _gameMethods.OpenDialog(3755); // "不过我还不够等级做你的约会对象。」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan5", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei7", "yan2", "zui7"});
        yield return _gameMethods.OpenDialog(3756); // "「嗯——{nw}{w=0.1}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan5", "zui5"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(3757); // "那我们孤男寡女，{nw}{w=0.1}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan20", "zui4"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei6", "yan10", "zui10"});
        yield return _gameMethods.OpenDialog(3758); // "夜间偷偷见面，{nw}{w=0.1}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei6", "yan24", "zui15", "emoji3", "emoji6"});
        yield return _gameMethods.OpenDialog(3759); // "是在做什么呢？」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui8"});
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui2", "-emoji3", "-emoji6"});
        yield return _gameMethods.OpenDialog(3760); // "进行健康、适度且纯洁的社交往来。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan11", "zui7"});
        yield return _gameMethods.OpenDialog(3761); // "听起来不错~"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan24", "zui19"});
        yield return _gameMethods.OpenDialog(3762); // "我也觉得。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10"});
        yield return _gameMethods.OpenDialog(3763); // "你是特地来找我的吗？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(3764); // "你是在明知故问吗？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(3765); // "不算，因为我真的不确定。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui8"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei8", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(3391); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(3766); // "那么，现在你知道了。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan10", "zui14"});
        yield return _gameMethods.OpenDialog(3396); // "……"
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:4f);
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan6", "zui14"});
        yield return _gameMethods.OpenDialog(3767); // "寒暄结束，短暂地安静。"
        yield return _gameMethods.PlaySound("soundb", 2f, 2f, "audio/sound/manbu/Gentle Breeze Blowing Foliage Rustling_01.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(3768); // "微风轻轻拂起..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui8"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(3391); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(3769); // "这是难得的机会。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(3770); // "平时，我只能接触到赫泽尔一个对象。"
        yield return _gameMethods.PlaySound("music", 2f, 0.8f, "audio/music/Whimsical_Waltz.mp3");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(3771); // "而今天终于有了额外的情报来源。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(3772); // "多问他一些问题吧。"
        yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:3f);
        yield return _gameMethods.ChangeLabelTo("label_multiple_choice1");
    }

    public IEnumerator label_zhuxian4_menu_0_0iznrAW0()
    {
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei10", "yan11", "zui8"});
        Defaults.Persistent.Jq_5_5 = 1;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(3902); // "不管行不行，都只能硬着头皮上了。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(3903); // "我给你讲一个故事吧。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei8", "yan2", "zui7"});
        yield return _gameMethods.OpenDialog(3904); // "哦？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui3"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(3905); // "「几百年来，所有话剧我都看过..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan10", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(3906); // "各个王国我皆已走遍..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei8", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(3907); // "你有自信这个故事是我没听过的吗？」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan3", "zui10"});
        yield return _gameMethods.OpenDialog(3908); // "这个故事，叫做《一千零一夜》。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan9", "zui5"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei8", "yan3", "zui15"});
        yield return _gameMethods.OpenDialog(3909); // "这个名字我倒是还没听说过。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(3910); // "你自己编的？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui12"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(3911); // "「差不多吧。{nw}{w=0.1}"
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(3912); // "你要听吗？」"
        yield return _gameMethods.PlaySound("sound", 0.4f, 1.0f, "audio/demo_audio/sound/moca2.mp3");
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"lv1", "mei7", "yan2", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 80.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.24f}, {"zpos", 90.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(3913); // "荣幸之至。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"lv1", "mei7", "yan11", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 90.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan6", "zui19"});
        yield return _gameMethods.OpenDialog(3914); // "很久之前，有一位国王..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui19"});
        yield return _gameMethods.OpenDialog(3915); // "从此，他便对女人充满了疑问。」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui10"});
        yield return _gameMethods.OpenDialog(3916); // "「每夜，他都要邀请一位女士与之交谈..."
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(3917); // "翌日清晨便送走她..."
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan12", "zui10"});
        yield return _gameMethods.OpenDialog(3918); // "而受邀的人选则具备各种身份。"
        yield return _gameMethods.StopSound(channelName:"music1", fadeOut:10f);
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.ExecuteCharacterImageData("nv2");
        yield return _gameMethods.OpenDialog(3919); // "这个国家的宰相有一位女儿..."
        yield return _gameMethods.Scene("wenxue_ditu", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 0.5f)}, {"pos", new Vector2(0.5f, 0.5f)}, {"zoom", 0.86f}})});
        Defaults.Gui_duihuakuang_you = 0;
        yield return _gameMethods.Show("wenxue_nv", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 0.5f)}, {"pos", new Vector2(0.5f, 0.5f)}, {"zoom", 0.86f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(3920); // "其实开口之前我还有点担心。"
        yield return _gameMethods.Show("wenxue_nv1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 0.5f)}, {"pos", new Vector2(0.5f, 0.5f)}, {"zoom", 0.86f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1f}})});
        yield return _gameMethods.OpenDialog(3921); // "毕竟他有读心能力..."
        yield return _gameMethods.OpenDialog(3922); // "但事情出乎意料的顺利..."
        yield return _gameMethods.Hide("wenxue_nv1");
        yield return _gameMethods.OpenDialog(3387); // "…………"
        yield return _gameMethods.PlaySound("music", 0.0f, 0.4f, "audio/demo_audio/music/qingkuai1.mp3");
        yield return _gameMethods.Show("wenxue_wenxue", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 0.5f)}, {"pos", new Vector2(0.5f, 0.5f)}, {"zoom", 0.86f}, {"yoffset", -200f}}), new SameLineParamData(new Dictionary<string, object>{{"easein_bounce", 1f}, {"yoffset", 0f}})});
        yield return _gameMethods.OpenDialog(3923); // "讲述完一千零一夜的开头..."
        yield return _gameMethods.OpenDialog(3924); // "说实话，我并不是什么文豪..."
        yield return _gameMethods.OpenDialog(3925); // "但我仍拥有相当程度的自信。"
        yield return _gameMethods.OpenDialog(3926); // "因为，在这个世界生活十六年以来..."
        yield return _gameMethods.OpenDialog(3927); // "大概只相当于我上一个世界里..."
        yield return _gameMethods.Hide("wenxue_wenxue");
        yield return _gameMethods.Show("wenxue_jiaohui", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 0.14f)}, {"anchor", new Vector2(0.5f, 0.5f)}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.51f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.8f}, {"zoom", 0.86f}, {"alpha", 1f}})});
        yield return _gameMethods.OpenDialog(3928); // "可能是因为寓言故事还占据着权威地位吧。"
        yield return _gameMethods.Show("wenxue_qishi");
        yield return _gameMethods.Show("wenxue_ditu_r");
        yield return _gameMethods.Show("wenxue_jiaohuang");
        yield return _gameMethods.Show("3-64_zoom");
        yield return _gameMethods.Hide("3-64_zoom");
        yield return _gameMethods.OpenDialog(3929); // "它对人们的思想施加了诸多限制..."
        yield return _gameMethods.Hide("wenxue_qishi");
        yield return _gameMethods.Hide("wenxue_jiaohuang");
        yield return _gameMethods.Show("wenxue_shenhua");
        yield return _gameMethods.OpenDialog(3930); // "无论绘画还是雕塑，"
        yield return _gameMethods.Show("wenxue_shenmu");
        yield return _gameMethods.OpenDialog(3931); // "主流内容也都是神话传说和民间传奇。"
        yield return _gameMethods.OpenDialog(3932); // "因此，通俗文学尚未得到太多的发展空间。"
        yield return _gameMethods.Hide("wenxue_shenmu");
        yield return _gameMethods.Hide("wenxue_shenhua");
        yield return _gameMethods.Hide("wenxue_ditu_l");
        yield return _gameMethods.Hide("wenxue_ditu_r");
        yield return _gameMethods.Hide("wenxue_jiaohui");
        yield return _gameMethods.Show("wenxue_xiju");
        yield return _gameMethods.Show("3-65_zoom");
        yield return _gameMethods.Hide("3-65_zoom");
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.OpenDialog(3933); // "故事也大多相当的原生态。"
        yield return _gameMethods.OpenDialog(3934); // "社会上最通俗的文体是寓言叙事诗..."
        yield return _gameMethods.Hide("wenxue_xiju");
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.OpenDialog(3935); // "而就算是眼下最新型的小说..."
        yield return _gameMethods.Show("wenxue_ditu_l");
        yield return _gameMethods.Show("wenxue_guizu");
        yield return _gameMethods.OpenDialog(3936); // "上流社会推崇高雅的戏剧，"
        yield return _gameMethods.Show("wenxue_ditu_r");
        yield return _gameMethods.Show("wenxue_pingmin");
        yield return _gameMethods.OpenDialog(3937); // "而市民阶层间虽流传着通俗的故事..."
        yield return _gameMethods.OpenDialog(3938); // "文学之间存在着过大的断层。"
        yield return _gameMethods.OpenDialog(3939); // "所以，这就是我的机会。"
        yield return _gameMethods.OpenDialog(3940); // "作为现代人，别的我不敢说..."
        yield return _gameMethods.Hide("wenxue_guizu");
        yield return _gameMethods.Hide("wenxue_pingmin");
        yield return _gameMethods.Hide("wenxue_ditu_l");
        yield return _gameMethods.Hide("wenxue_ditu_r");
        yield return _gameMethods.OpenDialog(3941); // "——这并不是说现代文学就比古典文学要好。"
        yield return _gameMethods.Show("wenxue_ditu_l");
        yield return _gameMethods.Show("wenxue_dunzhu");
        yield return _gameMethods.OpenDialog(3942); // "\n只是古典文学宛若原汁原味的炖煮..."
        yield return _gameMethods.Show("wenxue_ditu_r");
        yield return _gameMethods.Show("wenxue_kuaican");
        yield return _gameMethods.OpenDialog(3943); // "而现代文学则像调味丰富、刺激的油炸快餐..."
        yield return _gameMethods.OpenDialog(3944); // "我改编了几个看过的短篇小说..."
        yield return _gameMethods.Scene("woshi_nv1_yewan_yangtai_ani", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.29f, 0.97f)}, {"zoom", 1.25f}})});
        Defaults.Gui_duihuakuang_you = 1;
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8", "lv1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.25f, 2.92f)}, {"zoom", 0.6f}, {"xoffset", 50f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan18", "zui10"});
        yield return _gameMethods.OpenDialog(3945); // "但一个短篇故事刚说了开头，{nw}{w=0.1}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan4", "zui8"});
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 5;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(3946); // "青年蓝色的双眼就固定在了我的身上..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(3947); // "讲到一半，"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan17", "zui7"});
        yield return _gameMethods.OpenDialog(3948); // "我停住了嘴。"
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:5f);
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui8"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(3391); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan4", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(3949); // "然后呢？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan4", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(3950); // "然后就没时间讲啦。等明天吧。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
        yield return _gameMethods.OpenDialog(3951); // "哎呀，你也要像故事中的公主一样..."
        yield return _gameMethods.PlaySound("music1", 0.0f, 0.7f, "audio/music/Whimsical_Waltz.mp3");
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui2"});
        yield return _gameMethods.OpenDialog(3952); // "为什么不呢。适度的等待会让美食更加可口。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan9", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan12", "zui19"});
        yield return _gameMethods.OpenDialog(3953); // "想听到结局，就等下次见面吧。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.5>audio/sound/jiaobusheng_nuo_normal1.ogg");
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui3"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 2.92f}, {"zoom", 0.6f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.4f}, {"ypos", 2.89f}, {"zoom", 0.59f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei7", "yan6", "zui7"});
        yield return _gameMethods.OpenDialog(3954); // "「好吧，你说动我了。小公主。{nw}{w=0.1}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(3955); // "你要我如何下注呢？」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui3"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(3956); // "事先说明，论武力我可是打不过尼德霍格的哦。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 2.89f}, {"zoom", 0.59f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei1", "yan2", "zui10", "emoji7"});
        yield return _gameMethods.OpenDialog(3957); // "怎么能劳烦尊贵的赞助商大人动手呢。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan2", "zui19", "-emoji7"});
        yield return _gameMethods.OpenDialog(3958); // "不过，这会不会太夸张了..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui16"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
        yield return _gameMethods.OpenDialog(3959); // "物种之间，与个体间先天的差距比你想象的还要大。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan18", "zui15"});
        yield return _gameMethods.OpenDialog(3960); // "而且，实际上，距离我诞生只过了两千年。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(3961); // "我刚刚结束成长期..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(3962); // "在你们人类中大概也只相当于青年而已。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan10", "zui7"});
        yield return _gameMethods.OpenDialog(3963); // "看出来了，还是挺爱玩的那种年轻龙。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(3964); // "不过，两千岁的青年吗。听起来像天山童姥。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan4", "zui4"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(3876); // "那是什么？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui13"});
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(3965); // "的脑袋里总是装着很多奇妙的想法..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan2", "zui8", "emoji2"});
        yield return _gameMethods.OpenDialog(3396); // "……"
        yield return _gameMethods.PlaySound("sound", 0.4f, 0.5f, "audio/demo_audio/sound/moca2.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.26f}, {"zpos", 12f}})});
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan5", "zui19", "emoji2"});
        yield return _gameMethods.OpenDialog(3966); // "你们龙说话都那么冒犯么。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 12f}})});
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei3", "yan5", "zui7", "-emoji2"});
        yield return _gameMethods.OpenDialog(3967); // "「都？{nw}{w=0.1}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(3968); // "看来尼德霍格也不是那么受你的宠爱啊。」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan24", "zui17", "emoji2"});
        yield return _gameMethods.OpenDialog(3396); // "……"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(3969); // "原谅我们吧。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan19", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(3970); // "「你对我们而言，{nw}{w=0.1}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(3971); // "太过纤小和脆弱了。」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan10", "zui14", "-emoji2"});
        yield return _gameMethods.OpenDialog(3396); // "……"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui8"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(3391); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(3972); // "那么，你要我提供什么帮助呢。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1>audio/sound/jiaobusheng_xin_normal1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 12.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.8f}, {"zpos", -18.0f}})});
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan2", "zui10"});
        yield return _gameMethods.OpenDialog(3973); // "我要借用一下你的身体。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -18.0f}})});
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan3", "zui9"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(3974); // "{nw}{w=0.18}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei11", "yan4", "zui5"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei8", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(3975); // "「好大胆呀，小姐~！{nw}{w=0.1}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei8", "yan2", "zui3"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(3976); // "你要对我做什么？」"
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/moca1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei8", "yan2", "zui7"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei5", "yan2", "zui19", "emoji2"});
        yield return _gameMethods.OpenDialog(3977); // "……干嘛一副期待的样子啊！！"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei8", "yan11", "zui7"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui12", "-emoji2"});
        yield return _gameMethods.OpenDialog(3978); // "我想研究一下龙的躯体。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(3979); // "我好奇很久了..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(3980); // "究竟只是呈现出了一种外观上的幻觉..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei8", "yan1", "zui8"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(3391); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei8", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(3981); // "骨骼、肌肉、血液与皮肤的密度也同人类一样么？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei6", "yan1", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(3982); // "「好吧，请一定要手下留情..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(3983); // "对我温柔一点。」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(3984); // "当然了。我怎么会舍得伤害你呢。"
        yield return _gameMethods.StopSound(channelName:"music1", fadeOut:3f);
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"ypos", 294f}, {"zpos", -132.0f}})});
        yield return _gameMethods.TransitionBy("blink2");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui7"});
        yield return _gameMethods.OpenDialog(3985); // "虽然性情飘浮..."
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 294f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.7f}, {"ypos", 432f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(3986); // "浑身被服装覆盖..."
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui9"});
        yield return _gameMethods.OpenDialog(3987); // "能脱下手套吗？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui16"});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 432f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.36f}, {"ypos", 6f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(3988); // "当然，悉听尊便。"
        yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/demo_audio/music/a dull dawn.mp3");
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/emeng_dajie/Body_up_01.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 6f}})});
        yield return _gameMethods.Show("shou_bai3", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}, {"anchor", new Vector2(0f, 0f)}, {"zoom", 0.62f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1f}})});
        Defaults.Gui_duihuakuang_you = 0;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(3989); // "他抬起手，放在我面前。"
        yield return _gameMethods.Show("shou_bai3", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(3990); // "……这是要我来动手的意思了。"
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/demo_audio/sound/moca3.mp3");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15"});
        yield return _gameMethods.OpenDialog(3991); // "我将他的手套脱下，{nw}{w=0.1}"
        yield return _gameMethods.Show("shou_bai1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}, {"anchor", new Vector2(0f, 0f)}, {"zoom", 0.62f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(3992); // "露出了那只属于成年人类男性的骨节宽大分明..."
        yield return _gameMethods.Show("shou_bai1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(3993); // "摸起来和人类的手别无二致..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan9", "zui15"});
        yield return _gameMethods.OpenDialog(3994); // "我用力捏了一下他的手背。"
        yield return _gameMethods.PlaySound("sounda1", 0.0f, 0.8f, "audio/sound/houhui/Bones Break Cracking_02.ogg");
        yield return _gameMethods.Show("shou_bai2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}, {"anchor", new Vector2(0f, 0f)}, {"zoom", 0.62f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1f}})});
        yield return _gameMethods.Show("4-7_zoom");
        yield return _gameMethods.Hide("4-7_zoom");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(3995); // "手指接触到柔韧的肌肤，却无法扭动。"
        yield return _gameMethods.Show("shou_bai2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(3996); // "果然在表层浮现出了一层透明的鳞片纹路。"
        yield return _gameMethods.Show("shou_bai2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(72f, 156f)}, {"zpos", 270.0f}})});
        yield return _gameMethods.Transition(time:0.9f);
        yield return _gameMethods.OpenDialog(3997); // "……龙鳞。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan19", "zui16"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan21", "zui15"});
        yield return _gameMethods.OpenDialog(3998); // "即便变成了人形，也还是存在啊。"
        yield return _gameMethods.Hide("shou_bai1");
        yield return _gameMethods.Hide("shou_bai2");
        yield return _gameMethods.Hide("shou_bai3");
        yield return _gameMethods.Transition(time:0.5f);
        Defaults.Gui_duihuakuang_you = 1;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_qian");
        yield return _gameMethods.OpenDialog(3999); // "「——它会处于一种无形并逸散的元素状态..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_qian");
        yield return _gameMethods.OpenDialog(4000); // "当我们拟化成不具备鳞片结构的生物时。」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(4001); // "龙鳞的防御..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(3396); // "……"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui8"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(3391); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(4002); // "既然无法从外部打破，"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(4003); // "\n那么、{nw}{w=0.1}"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan17", "zui15"});
        yield return _gameMethods.OpenDialog(4004); // "从内部呢？"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(4005); // "…………既然是器官..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui8"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(3391); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(4006); // "哦呀，不错的想法。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(4007); // "「…嗯，可以哦，{nw}{w=0.1}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan20", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(4008); // "不但能自由控制收放..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei7", "yan2", "zui7"});
        yield return _gameMethods.OpenDialog(4009); // "「不过，在尼德霍格之前..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(4010); // "你要怎么说服我为你解除防御呢？」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan10", "zui8", "emoji2"});
        yield return _gameMethods.OpenDialog(3396); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan24", "zui16", "emoji2"});
        yield return _gameMethods.OpenDialog(4011); // "……明明都结成同盟了..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui8"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei3", "yan12", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(3391); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1");
        yield return _gameMethods.OpenDialog(3396); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(4012); // "该怎么做呢？"
        yield return _gameMethods.ChangeLabelTo("label_multiple_choice2");
    }

    public IEnumerator label_zhuxian4_menu_0_6ljhrtMf()
    {
        Defaults.Choice_1_new = false;
        yield return _gameMethods.ChangeLabelTo("label_choice28_1");
    }

    public IEnumerator label_zhuxian4_menu_0_8bb1wFnS()
    {
        Defaults.Choice_2_new = false;
        yield return _gameMethods.ChangeLabelTo("label_choice28_2");
    }

    public IEnumerator label_zhuxian4_menu_0_bRSfgS1g()
    {
        Defaults.Choice_3_new = false;
        yield return _gameMethods.ChangeLabelTo("label_choice28_3");
    }

    public IEnumerator label_zhuxian4_menu_0_b5alUqkq()
    {
        yield return _gameMethods.PlaySound("sound", 0.2f, 0.4f, "audio/demo_audio/sound/moca2.mp3");
        Defaults.Choice_1_newa = false;
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -132.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.29f}, {"zpos", -148.0f}})});
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei9", "yan2", "zui10", "emoji7"});
        yield return _gameMethods.OpenDialog(4013); // "求求您了..."
        yield return _gameMethods.PlaySound("sound", 0.4f, 0.3f, "audio/demo_audio/sound/moca2.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -148.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.29f}, {"zpos", -168.0f}})});
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan4", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei9", "yan11", "zui11", "emoji7"});
        yield return _gameMethods.OpenDialog(4014); // "如果我不依靠您..."
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -168.0f}})});
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui9"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(3391); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan4", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei1", "yan5", "zui15", "emoji7"});
        yield return _gameMethods.OpenDialog(3396); // "……"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei9", "yan11", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(4015); // "真是难以不对你心软啊..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei9", "yan11", "zui7"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan2", "zui16", "-emoji7"});
        yield return _gameMethods.OpenDialog(4016); // "我天真无辜地注视着他。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei9", "yan20", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(4017); // "「好吧——{nw}{w=0.1}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(4018); // "真拿你没办法。{nw}{w=0.1}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei8", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(3391); // "{nw}{w=0.15}"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei8", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(4019); // "钻空子可行不通..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan6", "zui17"});
        yield return _gameMethods.OpenDialog(4020); // "他似笑非笑地盯着我..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(4021); // "但我已经从那双充满兴趣的冰瞳中读出了他的意思。{nw}{w=0.1}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(3391); // "{nw}{w=0.15}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui14"});
        yield return _gameMethods.OpenDialog(4022); // "\n——我很期待..."
        yield return _gameMethods.ChangeLabelTo("label_choice_or_ending1");
    }


}