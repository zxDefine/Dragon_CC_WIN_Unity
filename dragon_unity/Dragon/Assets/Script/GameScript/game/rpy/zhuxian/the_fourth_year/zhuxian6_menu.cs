using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zhuxian6_menu : ILabelProvider
{
    private GameMethods _gameMethods;

    public zhuxian6_menu(GameMethods gameMethods)
    {
        _gameMethods = gameMethods;
    }

    // "-冲向他们" 分支 (rpy L1065)
    public IEnumerator label_zhuxian6_menu_0_gMz2hZ5b()
    {
        yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/music/One_spring_day.mp3");
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<from 0 to 1>audio/sound/juezhan_dao/Running Footsteps Mud and Grass Surface (1)_01.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -30.0f}})});
        yield return _gameMethods.Show("caodi1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.83f, 1.24f)}, {"zoom", 1.06f}})});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan8", "zui10", "emoji11"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.32f, 2.22f)}, {"zoom", 0.36f}})});
        yield return _gameMethods.Show("luo2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.64f, 2.04f)}, {"zoom", 0.34f}})});
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.OpenDialog(8123); // "越跑越快，最后我冲到两人面前，不得不来了个急刹车..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui18", "emoji2"});
        yield return _gameMethods.OpenDialog(8124); // "撑着膝盖，平了平气息。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(8125); // "看着面前的面孔，我心中感慨万千，五味陈杂，终于开..."
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:4.0f);
        yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:6.0f);
        yield return _gameMethods.PlaySound("sounda1", 0.0f, 0.4f, "audio/sound/moca1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0.0f}, {"parallel_1", true}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei5", "yan2", "zui2", "emoji2"});
        yield return _gameMethods.OpenDialog(8126); // "……等一下，你这家伙还真的是勇者啊！"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"yoffset", 0.0f}})});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui1", "-emoji11", "emoji12"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei5", "yan11", "zui2", "emoji2"});
        yield return _gameMethods.OpenDialog(8127); // "明明就是个屠夫肉铺家的小子，逞什么英雄啦！"
        yield return _gameMethods.ChangeLabelTo("label_zhuxian6_7");
    }

    // "-抱向他们" 分支 (rpy L1101)
    public IEnumerator label_zhuxian6_menu_0_Lmpai0DK()
    {
        yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/music/One_spring_day.mp3");
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<from 0 to 1>audio/sound/juezhan_dao/Running Footsteps Mud and Grass Surface (1)_01.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"zpos", -138.0f}, {"ypos", -30.0f}})});
        yield return _gameMethods.Show("caodi1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.83f, 1.24f)}, {"zoom", 1.06f}})});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan8", "zui10", "emoji11"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.32f, 2.22f)}, {"zoom", 0.36f}})});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan5", "zui10"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.64f, 2.04f)}, {"zoom", 0.34f}})});
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.OpenDialog(8129); // "越跑越快，最后我不由得伸开双臂，携着长风与气流，..."
        yield return _gameMethods.Show("black");
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.PlaySound("sound", 0.0f, 3.0f, "audio/sound/manbu/Body1_02_duan.mp3");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan23", "zui7"});
        yield return _gameMethods.OpenDialog(8130); // "被他们伸手拦住。"
        Defaults.Haogandu_an = Defaults.Haogandu_an + 2;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8131); // "紧紧相拥。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan12", "zui7"});
        yield return _gameMethods.OpenDialog(8132); // "谁也没有说话。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8133); // "他们身上有一股汗水和尘土交织的味道，多年再见就这..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan20", "zui7"});
        yield return _gameMethods.OpenDialog(8134); // "但我胸中漂浮的心，却忽然安稳。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8135); // "他们还是他们。"
        yield return _gameMethods.PlaySound("sounda", 0.8f, 0.4f, "audio/demo_audio/sound/tangxia1.mp3");
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan23", "zui10", "emoji11", "emoji12"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan10", "zui9"});
        yield return _gameMethods.Hide("black");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui7"});
        yield return _gameMethods.OpenDialog(8136); // "……过了一会儿，我微微松开手。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei5", "yan12", "zui1", "emoji11", "emoji12"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan2", "zui1"});
        yield return _gameMethods.OpenDialog(8137); // "察觉到我有要挣脱的意图，抱住我的手臂也适时松开了..."
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0.5 to 1.5>audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"easein", 1.2f}, {"zpos", 0.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(8138); // "我后退两步，平了平气息。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}})});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei5", "yan2", "zui1", "emoji11", "emoji12"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui1", "-emoji11", "emoji12"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv");
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan5", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("luo_nv");
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei2", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(8139); // "看着面前的面孔，心中感慨万千，五味陈杂。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei2", "yan12", "zui7"});
        yield return _gameMethods.OpenDialog(8140); // "口头的话沉甸甸的，仿佛有千斤重，我终于开口。"
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:4.0f);
        yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:6.0f);
        yield return _gameMethods.PlaySound("sounda1", 0.0f, 0.4f, "audio/sound/moca1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0.0f}, {"parallel_1", true}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei5", "yan2", "zui2", "emoji2"});
        yield return _gameMethods.OpenDialog(8126); // "……等一下，你这家伙还真的是勇者啊！"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"yoffset", 0.0f}})});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan2", "zui3"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei5", "yan11", "zui2", "emoji2"});
        yield return _gameMethods.OpenDialog(8127); // "明明就是个屠夫肉铺家的小子，逞什么英雄啦！"
        yield return _gameMethods.ChangeLabelTo("label_zhuxian6_7");
    }

    // "-但我不会跑的" 分支 (rpy L1262)
    public IEnumerator label_zhuxian6_menu_1_c782TjsQ()
    {
        yield return _gameMethods.ChangeLabelTo("label_zhuxian6_4");
    }

    // "-钱吗？" 分支 (rpy L1431)
    public IEnumerator label_zhuxian6_menu_2_PZLqtDo4()
    {
        Defaults.Choice_1_newb = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei2", "yan5", "zui15", "-emoji3"});
        yield return _gameMethods.OpenDialog(8205); // "我一下子同情起来。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei1", "yan17", "zui10"});
        yield return _gameMethods.OpenDialog(8206); // "这个道具应该很贵吧？"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui1", "-emoji4"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan17", "zui15"});
        yield return _gameMethods.OpenDialog(8207); // "你的身体还好吗？"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan16", "zui4"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(8208); // "你钻钱眼里了吧。怎么跟洛恩一样。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan16", "zui1"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan12", "zui16"});
        yield return _gameMethods.ExecuteCharacterImageData("luo_nv_qian", parts: new List<string>{"mei8", "yan11", "zui8"});
        yield return _gameMethods.OpenDialog(8209); // "「异议，{nw}{w=0.2}"
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan2", "zui4"});
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei8", "yan2", "zui8"});
        yield return _gameMethods.OpenDialog(8210); // "我从不缺乏智慧。」"
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan5", "zui3"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan6", "zui10"});
        yield return _gameMethods.OpenDialog(8211); // "所以你是用、身上最珍贵的……"
        yield return _gameMethods.ChangeLabelTo("label_multiple_choice3");
    }

    // "-肌肉？" 分支 (rpy L1447)
    public IEnumerator label_zhuxian6_menu_2_sh5LcHcW()
    {
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui1", "-emoji4"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei5", "yan5", "zui10", "emoji2", "-emoji3"});
        yield return _gameMethods.OpenDialog(8213); // "用你的肌肉吗。"
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/demo_audio/sound/wuyu.mp3");
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei8", "yan20", "zui12", "emoji8", "emoji10", "emoji21"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei5", "yan5", "zui18", "emoji2"});
        yield return _gameMethods.OpenDialog(5087); // "？？？"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei8", "yan20", "zui10", "emoji8", "emoji10", "emoji21"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan12", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("luo_nv", parts: new List<string>{"mei5", "yan5", "zui18", "-emoji2"});
        yield return _gameMethods.OpenDialog(8214); // "的确，他身上除了肌肉之外也没什么长处了。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/moca1.ogg");
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei10", "yan2", "zui12", "-emoji8", "emoji10", "emoji19", "-emoji21"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"xoffset", -3.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 3.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0.0f}, {"parallel_1", true}})});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan2", "zui3"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.OpenDialog(8215); // "希望，我是用希望换的！！"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei10", "yan2", "zui12", "-emoji10", "emoji19"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"yoffset", 0.0f}})});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei2", "yan1", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(8216); // "希望？"
        yield return _gameMethods.ChangeLabelTo("label_zhuxian6_2");
    }

    // "-不会是……" 分支 (rpy L1476)
    public IEnumerator label_zhuxian6_menu_2_Yg_OqHBF()
    {
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15", "emoji3"});
        yield return _gameMethods.OpenDialog(8218); // "不会是……"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(18.0f, -30.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 2.0f}, {"pos", new Vector2(-96.0f, 90.0f)}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan21", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(8219); // "我默默降低视线，谨慎而凝重地看向了他。"
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan1", "zui1"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(226); // "{nw}{w=0.2}"
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei4", "yan11", "zui10"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei2", "yan5", "zui8"});
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/moca1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.8f}, {"xpos", 18.0f}, {"zpos", -162.0f}, {"ypos", -30.0f}})});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei8", "yan4", "zui8", "emoji2", "emoji3", "emoji4", "emoji5"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"xoffset", -3.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 3.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0.0f}, {"parallel_1", true}})});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv");
        yield return _gameMethods.OpenDialog(8220); // "……干什么这么凝重？！"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan8", "zui3", "emoji2", "emoji3", "emoji4", "emoji5"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"yoffset", 0.0f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 18.0f}, {"zpos", -162.0f}, {"ypos", -30.0f}})});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei3", "yan5", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15", "-emoji2", "-emoji3"});
        yield return _gameMethods.OpenDialog(8221); // "勇者的脸一下子红到脖子根，{nw}{w=0.3}"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan17", "zui2", "emoji2", "emoji3", "emoji4", "emoji5"});
        yield return _gameMethods.PlaySound("sounda", 0.0f, 2.0f, "audio/sound/manbu/Body1_02_duan.mp3");
        yield return _gameMethods.OpenDialog(8222); // "不愿直视我，{nw}{w=0.3}"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei8", "yan12", "zui1", "emoji2", "emoji3", "emoji4", "emoji5"});
        yield return _gameMethods.OpenDialog(8223); // "悄声地嘀咕了一句。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan16", "zui4", "emoji2", "emoji3", "emoji4", "emoji5"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan10", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
        yield return _gameMethods.OpenDialog(8224); // "「没有用上什么特别珍贵的东西……{nw}{w=0..."
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan2", "zui12", "emoji2", "emoji3", "emoji4", "emoji5"});
        yield return _gameMethods.OpenDialog(8225); // "希望，是希望！！」"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan2", "zui10", "emoji2", "emoji3", "emoji4", "emoji5"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei2", "yan1", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(8216); // "希望？"
        yield return _gameMethods.ChangeLabelTo("label_zhuxian6_2");
    }

    // "-跟赫泽尔回城堡" 分支 (rpy L2389)
    public IEnumerator label_zhuxian6_menu_3_psZbjBcn()
    {
        yield return _gameMethods.SceneBlack(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 2.0f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(8470); // "……不，赫泽尔已经明显很不快了。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(8471); // "还是不要轻举妄动，继续惹怒他为好。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan21", "zui15"});
        yield return _gameMethods.OpenDialog(8472); // "我按捺住了回头再看一眼的欲望，跟着赫泽尔返回了城..."
        yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:5.0f);
        yield return _gameMethods.StopSound(channelName:"soundc", fadeOut:5.0f);
        yield return _gameMethods.StopSound(channelName:"sounde", fadeOut:5.0f);
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:5.0f);
        yield return _gameMethods.ChangeLabelTo("label_zhuxian6_8");
    }

    // "-不择手段留下来" 分支 (rpy L2412)
    public IEnumerator label_zhuxian6_menu_3_hzBt87YW()
    {
        yield return _gameMethods.OpenDialog(8474); // "必须想办法留下来。"
        yield return _gameMethods.OpenDialog(8475); // "必须阻拦他的脚步。"
        yield return _gameMethods.OpenDialog(8476); // "有什么办法……"
        yield return _gameMethods.OpenDialog(8477); // "说服？诱惑？要挟？恳求？哭闹？"
        yield return _gameMethods.EngineSetVolume(volume:0.3f, delay:1.0f, channelName:"soundb");
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:5.0f);
        yield return _gameMethods.Hide("an2");
        yield return _gameMethods.Show("wuqipu", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 0.5f)}, {"zoom", 0.46f}})});
        yield return _gameMethods.TransitionBy("trans_rip_fast1");
        yield return _gameMethods.PlaySound("sound", 0.0f, 2.0f, "audio/sound/houhui/Hint_01.mp3");
        yield return _gameMethods.OpenDialog(8478); // "忽然，一股冲劲忽然进入我的大脑。那是一个莽撞但果..."
        yield return _gameMethods.OpenDialog(8479); // "许久未见的朋友就在我的身边。"
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.OpenDialog(8480); // "只能如此。"
        yield return _gameMethods.StopSound(channelName:"soundc", fadeOut:2.0f);
        yield return _gameMethods.StopSound(channelName:"sounde", fadeOut:2.0f);
        yield return _gameMethods.PlaySound("sounda", 0.0f, 2.0f, "<from 0 to 0.5>audio/sound/jiaobusheng_xin_normal1.ogg");
        yield return _gameMethods.OpenDialog(8481); // "电光火石间，我下定了决心，在踏出下一步时，左脚却..."
        yield return _gameMethods.PlaySound("sound", 0.0f, 2.0f, "audio/sound/houhui/Body3 _01.mp3");
        yield return _gameMethods.PlaySound("sounda1", 0.0f, 2.0f, "<silence 0.8>audio/demo_audio/sound/zhenjing_shuaidaoganjue.mp3");
        yield return _gameMethods.OpenDialog(8482); // "双脚被绊在了原地，但前面赫泽尔拉扯着我前进的速度..."
        yield return _gameMethods.OpenDialog(8483); // "啊！"
        yield return _gameMethods.OpenDialog(8484); // "我惊叫了一声。"
        yield return _gameMethods.Show("4-9_zoom");
        yield return _gameMethods.Hide("4-9_zoom");
        yield return _gameMethods.PlaySound("sound", 0.0f, 6.0f, "audio/sound/manbu/Body1_02_duan.mp3");
        yield return _gameMethods.PlaySound("sounda2", 0.5f, 2.0f, "audio/demo_audio/sound/canpanpengzhuang2_duan.mp3");
        yield return _gameMethods.Show("wuqipu1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 0.5f)}, {"zoom", 0.46f}, {"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"alpha", 1.0f}})});
        yield return _gameMethods.OpenDialog(8485); // "身体止不住地向着地面摔去，同时，双手想要撑住某个..."
        yield return _gameMethods.Show("wuqipu1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        yield return _gameMethods.PlaySound("sounda4", 0.0f, 1.0f, "audio/sound/dashuizhang/glass-break_01.ogg");
        yield return _gameMethods.OpenDialog(8486); // "——！"
        yield return _gameMethods.OpenDialog(8487); // "不出所料，手心传来皮肤擦破的刺痒疼痛，但预想中与..."
        yield return _gameMethods.PlaySound("sounda1", 0.0f, 2.0f, "audio/sound/emeng_dajie/magic1.ogg");
        yield return _gameMethods.Hide("wuqipu");
        yield return _gameMethods.Hide("wuqipu1");
        yield return _gameMethods.Show("dajie1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(1.09f, 1.31f)}, {"zoom", 1.25f}, {"yoffset", 100.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 1.0f}, {"yoffset", 0.0f}})});
        yield return _gameMethods.PlaySound("sounda5", 0.0f, 0.4f, "audio/demo_audio/sound/strange_wave.mp3");
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(8488); // "我以半是要摔倒的姿势浮在了空气中，被赫泽尔扶正。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.5>audio/demo_audio/sound/zu3_nv_zou.ogg");
        yield return _gameMethods.EngineSetVolume(volume:0.3f, delay:2.0f, channelName:"soundb");
        yield return _gameMethods.Show("he", parts: new List<string>{"mei18", "yan27", "zui2", "emoji2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 2.03f)}, {"zpos", 5.0f}, {"zoom", 0.42f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/houhui/Tight Face_02_duan.mp3");
        yield return _gameMethods.OpenDialog(8489); // "他蹙着眉，有些焦躁似的抬眸望着差点跌倒的我，"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei18", "yan2", "zui2"});
        yield return _gameMethods.OpenDialog(8490); // "鼻间嗅到什么，脸色一变，"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei18", "yan23", "zui3"});
        yield return _gameMethods.OpenDialog(8491); // "看向我的右手。"
        yield return _gameMethods.OpenDialog(8492); // "醒目的痕迹在白皙的手心绽开，顺着手掌的纹路向四周..."
        yield return _gameMethods.Show("dajie1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}})});
        yield return _gameMethods.OpenDialog(8493); // "这些痕迹布满手掌……正好叠加在了此前存在的那些旧..."
        yield return _gameMethods.PlaySound("music1", 0.0f, 1.3f, "audio/music/the waltz of the bubble.mp3");
        yield return _gameMethods.PlaySound("sounda2", 0.0f, 2.0f, "audio/sound/manbu/Body1_02_duan.mp3");
        yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan7", "zui2"});
        yield return _gameMethods.OpenDialog(8494); // "赫泽尔面色一白，{nw}{w=0.01}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan29", "zui21", "emoji2"});
        yield return _gameMethods.OpenDialog(8495); // "下意识抬手似乎想施用些什么魔法，"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei21", "yan25", "zui2", "emoji2"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei21", "yan1", "zui2", "emoji2"});
        yield return _gameMethods.OpenDialog(8496); // "却乍然停滞。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei13", "yan2", "zui21", "emoji2"});
        yield return _gameMethods.OpenDialog(8497); // "那只手僵在半空中，狼狈地虚握了握。\n什么治愈魔..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei18", "yan23", "zui3", "emoji0", "emoji10"});
        yield return _gameMethods.ExecuteCharacterImageData("he_qian");
        yield return _gameMethods.OpenDialog(1543); // "「……{nw}{w=0.4}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan15", "zui3", "-emoji0", "emoji10", "emoji2"});
        yield return _gameMethods.OpenDialog(1265); // "……」"
        yield return _gameMethods.PlaySound("sound", 0.2f, 0.4f, "audio/demo_audio/sound/moca2.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -276.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.36f}, {"zpos", -294.0f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei19", "yan25", "zui3", "-emoji10"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan27", "zui2"});
        yield return _gameMethods.OpenDialog(8498); // "他再次抬手，{nw}{w=0.01}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan13", "zui2", "emoji10"});
        yield return _gameMethods.OpenDialog(8499); // "双手抓住我的右手手掌，"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan25", "zui9", "-emoji10"});
        yield return _gameMethods.OpenDialog(8500); // "迫不及待地，要清理伤口——"
        yield return _gameMethods.PlaySound("sounda", 0.6f, 1.0f, "<from 0 to 1.5>audio/sound/jiaobusheng_an_kuai1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -294.0f}})});
        yield return _gameMethods.OpenDialog(8501); // "被冲上来的安德鲁打断。"
        yield return _gameMethods.PlaySound("sounda1", 0.0f, 1.0f, "audio/sound/houhui/Body3 _01.mp3");
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan4", "zui8", "emoji8", "-emoji6", "-emoji13", "-emoji20", "-emoji12"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 5.0f}, {"alpha", 0.0f}, {"blur", 0.01f}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(1050.0f, 1680.0f)}, {"zoom", 0.42f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.2f}, {"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(0.0f, -126.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"pos", new Vector2(348.0f, -234.0f)}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei18", "yan7", "zui2", "emoji2"});
        yield return _gameMethods.OpenDialog(8502); // "怎么又把自己弄伤了？！"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan8", "zui3", "emoji8", "emoji20"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(348.0f, -234.0f)}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan1", "zui2"});
        yield return _gameMethods.OpenDialog(8503); // "他慌里慌张地一把抓过我的手，又气又急。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan23", "zui3", "emoji8", "emoji20"});
        yield return _gameMethods.PlaySound("sound", 0.0f, 2.0f, "audio/sound/houhui/Grab Hand_01.mp3");
        yield return _gameMethods.PlaySound("sounda", 0.0f, 0.4f, "<silence 0.8>audio/demo_audio/sound/sibuliao.mp3");
        yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan25", "zui2"});
        Engine._history = false;
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan1", "zui2"});
        yield return _gameMethods.OpenDialog(8504); // "安德鲁从随身的腰包里取出某种预先配好的草药膏，用..."
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan12", "zui6", "-emoji8", "-emoji20"});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei19", "yan9", "zui3"});
        yield return _gameMethods.OpenDialog(8505); // "快速愈合的魔药药性对你来说太烈，我只用了杀毒止血..."
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan8", "zui9"});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei19", "yan15", "zui3", "emoji0", "emoji10"});
        yield return _gameMethods.OpenDialog(8506); // "我带你去医馆。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan13", "zui3", "emoji0", "emoji10"});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan8", "zui1"});
        yield return _gameMethods.OpenDialog(8507); // "我并未挪动脚步，而是看向赫泽尔。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(6.0f, -150.0f)}, {"zpos", -354.0f}})});
        yield return _gameMethods.TransitionBy("blink2");
        yield return _gameMethods.OpenDialog(8508); // "他正抿唇望着我被安德鲁抓住的那只伤手，一言不发。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(8509); // "赫泽尔？"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan1", "zui2", "emoji2"});
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/moca1.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei8", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(47); // "……！"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8510); // "他猛地抬头盯着我，瞳孔不知何时缩成了竖瞳，脸色难..."
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(8511); // "我可以去吗。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan2", "zui2", "emoji2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan5", "zui8"});
        yield return _gameMethods.OpenDialog(8512); // "我向他请示。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei18", "yan13", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8513); // "他没有回答。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(8514); // "见他似乎不像是要答应的意思，我再次开口。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan9", "zui19"});
        yield return _gameMethods.OpenDialog(8515); // "不去也没关系的。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan9", "zui7"});
        yield return _gameMethods.OpenDialog(8516); // "同时，摊开双手。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(8517); // "掌心鳞片状狰狞的陈年伤疤坦露出来。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei4", "yan7", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8518); // "时隔三年，新的伤痕重叠在上面。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8519); // "更加新鲜，更为醒目。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei19", "yan25", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei19", "yan1", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan21", "zui19"});
        yield return _gameMethods.OpenDialog(8520); // "反正……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan21", "zui6"});
        yield return _gameMethods.OpenDialog(8521); // "挂着淡淡的微笑，我宛如不抱期待一般。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei1", "yan17", "zui3"});
        yield return _gameMethods.OpenDialog(8522); // "我都已经习惯了。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei19", "yan15", "zui3", "emoji0", "emoji10"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei1", "yan17", "zui7"});
        yield return _gameMethods.OpenDialog(47); // "……！"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8523); // "他猛地眯起双瞳。露出一副被刺痛的模样。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(8524); // "啊。真的在痛苦吗？"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan8", "zui7"});
        yield return _gameMethods.OpenDialog(8525); // "这算什么？临终关怀？"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei19", "yan25", "zui3", "emoji2", "-emoji0", "-emoji10"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8526); // "他不发一言。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei19", "yan15", "zui21", "emoji0", "emoji10"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(8527); // "……去。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei15", "yan13", "zui9", "emoji10", "-emoji0"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei8", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(8528); // "我和你去医馆。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"xpos", 228.0f}, {"zpos", -90.0f}})});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan12", "zui3"});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei15", "yan13", "zui3", "emoji10"});
        yield return _gameMethods.TransitionBy("blink2");
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.StopSound(channelName:"music1", fadeOut:2.0f);
        yield return _gameMethods.ExecuteCharacterImageData("luo_weizhi");
        yield return _gameMethods.OpenDialog(8529); // "那就出发吧。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei15", "yan27", "zui2", "emoji10"});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan4", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(8530); // "温润的嗓音响起。"
        yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/music/yongzhe_wenxin1.mp3");
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<from 0 to 1>audio/sound/jiaobusheng_xin_normal1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 228.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.0f}, {"xpos", 420.0f}})});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan5", "zui3"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}, {"blur", 0.01f}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(1446.0f, 1650.0f)}, {"zpos", 5.0f}, {"zoom", 0.42f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.2f}, {"alpha", 1.0f}, {"blur", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.5f}, {"xpos", 1416.0f}, {"parallel_1", true}})});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan12", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8531); // "伴随着这个声音，洛恩的身影一同出现。"
        yield return _gameMethods.Show("luo2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}, {"blur", 0.0f}, {"xpos", 1416.0f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 420.0f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei15", "yan15", "zui2", "emoji10"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(8532); // "他刚才大概是去做什么事了，此刻神色自如地加入我们..."
        yield return _gameMethods.PlaySound("sound", 0.0f, 3.0f, "audio/sound/manbu/Body1_02_duan.mp3");
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan10", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 1416.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.5f}, {"xpos", 1400.0f}})});
        yield return _gameMethods.OpenDialog(8533); // "\n路过安德鲁时，顺手单掌轻按住了他的肩膀。"
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan9", "zui16"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 1400.0f}})});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan23", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("luo_nv");
        yield return _gameMethods.OpenDialog(8534); // "冷静。"
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan9", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:5.0f);
        yield return _gameMethods.SceneBlack(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 2.0f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.7f, "audio/demo_audio/sound/sibuliao.mp3");
        yield return _gameMethods.Scene("yiguan_baitian");
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan9", "zui15"});
        yield return _gameMethods.OpenDialog(8535); // "医馆里。医师处理好了我的伤口。"
        yield return _gameMethods.Show("npc_yishi", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 5.0f}, {"pos", new Vector2(882.0f, 822.0f)}, {"zoom", 0.52f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"alpha", 1.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("e_nv");
        yield return _gameMethods.OpenDialog(8536); // "之后一段时间不要碰水，还有其他注意事项你记一下。"
        yield return _gameMethods.Show("npc_yishi", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("e_nv", parts: new List<string>{"mei8", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(8537); // "……你们几个里，谁是伤者的家属？"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan3", "zui9", "-emoji10"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}, {"blur", 0.01f}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 5.0f}, {"pos", new Vector2(640.0f, 1614.0f)}, {"zoom", 0.42f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(8538); // "我。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan3", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan8", "zui4"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}, {"blur", 0.01f}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 5.0f}, {"pos", new Vector2(234.0f, 1938.0f)}, {"zoom", 0.45f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv");
        yield return _gameMethods.OpenDialog(8539); // "我是。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan8", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan12", "zui6"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}, {"blur", 0.01f}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 5.0f}, {"pos", new Vector2(1038.0f, 1800.0f)}, {"zoom", 0.43f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei18", "yan19", "zui3", "emoji12"});
        yield return _gameMethods.ExecuteCharacterImageData("luo_nv", parts: new List<string>{"mei7", "yan3", "zui15"});
        yield return _gameMethods.OpenDialog(8540); // "我们。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei19", "yan19", "zui3", "emoji0", "emoji11", "emoji12"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan2", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}, {"blur", 0.0f}})});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei18", "yan22", "zui3", "emoji11", "emoji12"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan4", "zui15"});
        yield return _gameMethods.OpenDialog(8541); // "医师看着我们，表情一言难尽，那眼神虽然什么都没说..."
        yield return _gameMethods.ExecuteCharacterImageData("e_nv", parts: new List<string>{"mei7", "yan24", "zui16", "emoji2"});
        yield return _gameMethods.OpenDialog(8542); // "你们……三个，都是她的……嗯，兄弟？"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei18", "yan25", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei18", "yan22", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan12", "zui16", "emoji2"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan11", "zui11"});
        yield return _gameMethods.ExecuteCharacterImageData("luo_nv", parts: new List<string>{"mei7", "yan24", "zui16", "-emoji2"});
        yield return _gameMethods.OpenDialog(8543); // "我们是情同手足、异父异母的亲兄妹。"
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei8", "yan5", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8544); // "医师看了看比我矮半个头的赫泽尔。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan5", "zui19", "emoji2"});
        yield return _gameMethods.OpenDialog(8545); // "还有姐弟。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei19", "yan25", "zui3"});
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:5.0f);
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei8", "yan5", "zui8", "-emoji2"});
        yield return _gameMethods.OpenDialog(1543); // "「……{nw}{w=0.4}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei18", "yan27", "zui2", "-emoji11", "-emoji12"});
        yield return _gameMethods.OpenDialog(1265); // "……」"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8546); // "赫泽尔平淡地开口。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei18", "yan27", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(8547); // "她是我的。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/moca1.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0.0f}, {"parallel_1", true}})});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei8", "yan1", "zui1"});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei18", "yan27", "zui2"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei8", "yan1", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan2", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(47); // "……！"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"yoffset", 0.0f}})});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei5", "yan8", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("luo_nv", parts: new List<string>{"mei8", "yan8", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.PlaySound("music2", 3.0f, 1.0f, "audio/music/Fall.mp3");
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei10", "yan12", "zui3", "emoji6", "emoji17"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv");
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan12", "zui9", "emoji6", "emoji17"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv");
        yield return _gameMethods.OpenDialog(8548); // "……我说你——"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan12", "zui2", "emoji6", "emoji17"});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei18", "yan27", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei18", "yan2", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(8549); // "安德鲁似乎终于忍无可忍。"
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei5", "yan12", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei5", "yan8", "zui2"});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan16", "zui12", "emoji6", "emoji16", "emoji17"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv");
        yield return _gameMethods.OpenDialog(8550); // "你根本，没有过珍惜的事物吧。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan16", "zui10", "emoji6", "emoji16", "emoji17"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(8551); // "他目光中带着一分少见的尖锐。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan16", "zui12", "emoji6", "emoji16", "emoji17"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei5", "yan10", "zui2"});
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/zhuxian6_3_b8753305.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("an_nv");
        yield return _gameMethods.OpenDialog(8552); // "你根本就不知道自己得到的东西有多宝贵，对别人又有..."
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan16", "zui10", "emoji6", "emoji16", "emoji17"});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei18", "yan27", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei15", "yan2", "zui2", "emoji2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
        yield return _gameMethods.OpenDialog(1222); // "「……"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei19", "yan2", "zui2", "emoji2"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei19", "yan20", "zui3", "emoji11"});
        yield return _gameMethods.OpenDialog(1265); // "……」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei19", "yan1", "zui21", "-emoji11"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(8547); // "她是我的。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei19", "yan1", "zui3", "emoji11"});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan8", "zui3", "emoji16", "emoji17", "-emoji6"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei4", "yan1", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(8553); // "赫泽尔重复，瞳孔竖起，近乎有一分偏执的倔强。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei20", "yan20", "zui12", "emoji0", "emoji11"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(8554); // "我们之间存在着牢不可破的羁绊，所以，她会一直待在..."
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan12", "zui8", "emoji15", "emoji16", "-emoji17"});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei20", "yan20", "zui3", "emoji0", "emoji11"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei5", "yan8", "zui3"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei8", "yan20", "zui15"});
        yield return _gameMethods.OpenDialog(8555); // "你……！！"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan20", "zui12", "emoji6", "emoji15", "emoji16"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv");
        yield return _gameMethods.OpenDialog(8556); // "你，可真是条不折不扣的黑龙啊。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan20", "zui10", "emoji6", "emoji15", "emoji16"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan12", "zui10"});
        yield return _gameMethods.OpenDialog(8557); // "……不要说了。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 1.0f}, {"zpos", -30.0f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei20", "yan25", "zui3", "emoji11", "-emoji0"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei4", "yan5", "zui1"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei20", "yan20", "zui3", "emoji11"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(8558); // "我看向赫泽尔，"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan11", "zui7"});
        yield return _gameMethods.OpenDialog(8559); // "带着微笑。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(8560); // "「是啊，"
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        Defaults.Haogandu_he = Defaults.Haogandu_he + 2;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(8561); // "我是你的。」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan2", "zui2", "-emoji11"});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -30.0f}})});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan1", "zui1", "-emoji6", "-emoji15", "-emoji16"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei4", "yan1", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(47); // "……！"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan3", "zui19"});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei10", "yan15", "zui2", "emoji6"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei4", "yan10", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan8", "zui7"});
        yield return _gameMethods.OpenDialog(1222); // "「……"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei7", "yan12", "zui3", "emoji0", "emoji10"});
        yield return _gameMethods.OpenDialog(6326); // "……{nw}{w=0.01}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei19", "yan25", "zui3", "-emoji0", "-emoji10"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan3", "zui2"});
        yield return _gameMethods.OpenDialog(2054); // "{nw}{w=0.3}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan27", "zui9"});
        yield return _gameMethods.OpenDialog(4082); // "……嗯。」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan27", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(8562); // "我面向安德鲁和洛恩。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei1", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(8563); // "不好意思，今天闹出这些风波。"
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei4", "yan5", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(8564); // "我就先和赫泽尔回去了。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei10", "yan19", "zui2", "emoji6"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan8", "zui7"});
        yield return _gameMethods.OpenDialog(8565); // "虽然还想再多相处些时间，但事态冲突明显激化到快要..."
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei7", "yan12", "zui2", "emoji6", "emoji13"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv");
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei2", "yan12", "zui5"});
        yield return _gameMethods.ExecuteCharacterImageData("luo_nv_qian");
        yield return _gameMethods.OpenDialog(8566); // "「那么，{nw}{w=0.3}"
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan5", "zui5"});
        yield return _gameMethods.OpenDialog(8567); // "你也保重。」"
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan5", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(8568); // "安德鲁沉默地望着我，还是洛恩接过了话头。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei1", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(8569); // "我对他点点头，{nw}{w=0.01}"
        yield return _gameMethods.Show("black", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}, {"zpos", 10.0f}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1.0f}})});
        yield return _gameMethods.PlaySound("sound", 0.0f, 2.0f, "audio/sound/manbu/Body1_02_duan.mp3");
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei8", "yan20", "zui7"});
        yield return _gameMethods.OpenDialog(8570); // "拉过了赫泽尔的胳膊。"
        yield return _gameMethods.Hide("black");
        yield return _gameMethods.Hide("an2");
        yield return _gameMethods.Hide("luo2");
        yield return _gameMethods.Hide("npc_yishi");
        yield return _gameMethods.Show("yiguan_baitian", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.21f, 1.36f)}, {"zoom", 1.6f}})});
        yield return _gameMethods.Show("he", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"ypos", 2232.0f}, {"zoom", 0.63f}})});
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan12", "zui19"});
        yield return _gameMethods.OpenDialog(8571); // "「走吧，{nw}{w=0.01}"
        Defaults.Haogandu_he = Defaults.Haogandu_he + 3;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei8", "yan9", "zui19"});
        yield return _gameMethods.OpenDialog(8572); // "我们回家。」"
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei8", "yan9", "zui15"});
        yield return _gameMethods.OpenDialog(5800); // "…………嗯。"
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei2", "yan9", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 10.0f}, {"pos", new Vector2(336.0f, -30.0f)}, {"anchor", new Vector2(0.0f, 0.0f)}, {"zoom", 0.42f}})});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei7", "yan23", "zui2", "emoji6", "emoji13"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 10.0f}, {"pos", new Vector2(-192.0f, 24.0f)}, {"anchor", new Vector2(0.0f, 0.0f)}, {"zoom", 0.46f}})});
        yield return _gameMethods.Show("he", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}})});
        yield return _gameMethods.Show("yiguan_baitian", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.85f, 1.38f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 1.73f}})});
        yield return _gameMethods.TransitionBy("blink2");
        yield return _gameMethods.OpenDialog(8573); // "离开前，赫泽尔又回头看了那两人一眼。"
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei2", "yan5", "zui1"});
        yield return _gameMethods.OpenDialog(8574); // "他背对着我，所以我看不见他面上的神情。"
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei5", "yan8", "zui2", "emoji3"});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei9", "yan12", "zui3", "emoji6", "emoji13"});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(8575); // "只是从对面安德鲁和洛恩难看和充满敌意的脸色来判断..."
        yield return _gameMethods.Show("black", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}, {"zpos", 10.0f}})});
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.OpenDialog(8576); // "我扯了扯赫泽尔。"
        yield return _gameMethods.Hide("luo2");
        yield return _gameMethods.Hide("black");
        yield return _gameMethods.Hide("an2");
        yield return _gameMethods.Show("yiguan_baitian", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.21f, 1.36f)}, {"zoom", 1.6f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan27", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"ypos", 2232.0f}, {"zoom", 0.63f}, {"alpha", 1.0f}})});
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.3f, "audio/sound/houhui/Grab Hand_01.mp3");
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<silence 0.5>audio/sound/houhui/Tight Face_02_duan.mp3");
        yield return _gameMethods.OpenDialog(8577); // "他转回身，紧紧扣住了我的手。他的五指同我的手指紧..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan22", "zui9"});
        yield return _gameMethods.OpenDialog(8578); // "我们回家。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan22", "zui2"});
        Engine._history = false;
        yield return _gameMethods.OpenDialog(226); // "{nw}{w=0.2}"
        Engine._history = true;
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(8579); // "我们回到了城堡。"
        yield return _gameMethods.StopSound(channelName:"music2", fadeOut:5.0f);
        yield return _gameMethods.ChangeLabelTo("label_zhuxian6_8");
    }

}
