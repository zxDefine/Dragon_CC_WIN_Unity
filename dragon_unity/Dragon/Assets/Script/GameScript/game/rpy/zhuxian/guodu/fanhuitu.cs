using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fanhuitu : ILabelProvider
{
    private GameMethods _gameMethods;

    public fanhuitu(GameMethods gameMethods)
    {
        _gameMethods = gameMethods;
    }

    public IEnumerator label_fanhuitu()
    {
        if (Defaults.He_xianzai == 1)
        {
            yield return _gameMethods.ShowBlack();
            yield return _gameMethods.Transition(time:0.5f);
        }
        yield return _gameMethods.OpenDialog(6010); // "经过与妖精商人的协商，我们谈好了交换条件。"
        yield return _gameMethods.OpenDialog(6011); // "他提出的要求颇为刁钻，都是些无法轻易获得的奇异珍品。"
        yield return _gameMethods.OpenDialog(6012); // "我们恐怕需要以好几年时间，去慢慢收集。"
        if (Defaults.He_xianzai == 1)
        {
            yield return _gameMethods.Show("caodi2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 0.91f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.5f}})});
            yield return _gameMethods.HideBlack();
            yield return _gameMethods.Transition(time:0.5f);
        }
        yield return _gameMethods.OpenDialog(6013); // "不过，这并无大碍..."
        yield return _gameMethods.OpenDialog(6014); // "我有绝对的觉悟..."
        yield return _gameMethods.OpenDialog(6015); // "不过在那之前，我们要先回一趟王都..."
        yield return _gameMethods.Scene("senlin1_baitian");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/feng2.mp3");
        yield return _gameMethods.PlaySound("sounda", 0.0f, 0.8f, "<silence 1><from 0 to 1.5>audio/demo_audio/sound/flapping_wings_01.mp3");
        yield return _gameMethods.TransitionBy("trans_rip_fast");
        yield return _gameMethods.OpenDialog(6016); // "……然而，在返回时，我们发生了一点小小的争执。"
        yield return _gameMethods.OpenDialog(6017); // "诺伯拉愿意载我..."
        yield return _gameMethods.OpenDialog(6018); // "而在这个没有空间或传送魔法的世界..."
        yield return _gameMethods.StopSound(channelName:"music2", fadeOut:5f);
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.OpenDialog(6019); // "……最后，在我的劝说下，诺伯拉勉为其难同意用爪子抓着两人飞行。"
        yield return _gameMethods.PlaySound("soundb", 0.0f, 0.7f, "audio/demo_audio/sound/longpaidachibang.mp3");
        yield return _gameMethods.EngineSetVolume(volume:0.5f, delay:0.001f, channelName:"soundb");
        yield return _gameMethods.OpenDialog(33); // "………………"
        yield return _gameMethods.PlaySound("soundc", 1f, 0.6f, "audio/demo_audio/sound/tiankong_huanjin.ogg");
        yield return _gameMethods.EngineSetVolume(volume:0.5f, delay:0.001f, channelName:"soundc");
        yield return _gameMethods.Show("tiankong_baitian");
        yield return _gameMethods.Transition(time:0.5f);
        if (Defaults.He_xianzai == 1)
        {
            yield return _gameMethods.PlaySound("music", 0.0f, 0.8f, "audio/music/yongzhe_wenxin1.mp3");
        }
        Defaults.Persistent.Jq_10_11 = 1;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15", "d3"});
        yield return _gameMethods.OpenDialog(6020); // "距离抵达还有一点时间..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(6021); // "……有一件事，必须提前决断。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15"});
        yield return _gameMethods.OpenDialog(6022); // "回到王都后..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan21", "zui15"});
        yield return _gameMethods.OpenDialog(6023); // "到那时，我们恐怕会被卷入利益的风暴眼。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(6024); // "毕竟，在被黑龙抓走前..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(6025); // "现在的我完全具备成为王储的资格。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(6026); // "到时候，树欲静而风不止..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(6027); // "……所以，我必须想清楚..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15"});
        yield return _gameMethods.OpenDialog(6028); // "无论选择哪个..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(6029); // "作为王储，则失去自由..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(6030); // "离开王都，则能全身心投入冒险..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan18", "zui15"});
        yield return _gameMethods.OpenDialog(6031); // "仅仅发自内心——对于这即将到来的风暴..."
        yield return _gameMethods.OpenSelectMenu(talk: new List<string>{"-登顶为王", "-远离纷争，去冒险"}, jump: new List<string>{"label_end3_1_1_tuan2", "label_end3_1_2_tuan2"}, condition: new List<string>{"NONE", "NONE"});
    }

    public IEnumerator label_end3_1_1_tuan2()
    {
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(6034); // "我喜欢自己做主。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(6035); // "与其失去决定的机会..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(6036); // "既然要做，就做得彻底吧..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.67f}, {"alpha", 0f}, {"blur", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1f}, {"blur", 0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo");
        yield return _gameMethods.OpenDialog(6037); // "所以，你要当女王了？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei8", "yan12", "zui10"});
        yield return _gameMethods.OpenDialog(6038); // "是啊，试试看吧。"

        if (Defaults.Bai_kiss == 1)
        {
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui16"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}, {"blur", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian", parts: new List<string>{"mei8", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(6039); // "「哦——……{nw}{w=0.01}"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
            yield return _gameMethods.OpenDialog(6040); // "我很期待。」"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(6041); // "他没有说要帮我。"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan14", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
            yield return _gameMethods.OpenDialog(6042); // "我知道，他在等我开口请求..."
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(6043); // "但我不想让他如愿占据上风。"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui12"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(6044); // "为了让他帮忙..."
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui12"});
            yield return _gameMethods.OpenDialog(6045); // "而我清楚，他是个很难被取悦的家伙..."
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui12"});
            Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
            if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
            {
                _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
                _gameMethods.SyncAchievement();
            }
            yield return _gameMethods.OpenDialog(6046); // "会要求拿走的，一定会是真正有分量的东西。"
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
            yield return _gameMethods.OpenDialog(6047); // "所以……"
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan12", "zui10"});
            yield return _gameMethods.OpenDialog(6048); // "那你就好好看着吧。"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui12"});
            Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
            if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
            {
                _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
                _gameMethods.SyncAchievement();
            }
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(6049); // "不用他的帮助，我能搞定。"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui14"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo");
            yield return _gameMethods.OpenDialog(6050); // "……好啊。"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo");
            yield return _gameMethods.OpenDialog(6051); // "我拭目以待。"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui8"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
            yield return _gameMethods.OpenDialog(226); // "{nw}{w=0.2}"
            Engine._history = true;
            yield return _gameMethods.Hide("nuo_heart_layered");
            yield return _gameMethods.Transition(time:0.5f);
        }

        if (Defaults.Bai_xue == 1)
        {
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui13"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}, {"blur", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei8", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(6052); // "我拭目以待，女王陛下。"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui16"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo");
            yield return _gameMethods.OpenDialog(6053); // "听凭你的差遣。"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan10", "zui10", "emoji2"});
            yield return _gameMethods.OpenDialog(6054); // "……你忽然变得真好说话。"
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan10", "zui15", "-emoji2"});
            yield return _gameMethods.OpenDialog(6055); // "我有些警惕。"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei6", "yan7", "zui6"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
            yield return _gameMethods.OpenDialog(4992); // "「唉，{nw}{w=0.01}"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei5", "yan11", "zui6"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
            yield return _gameMethods.OpenDialog(6056); // "真冤枉呀。」"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei5", "yan13", "zui5"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo");
            yield return _gameMethods.OpenDialog(6057); // "我只是在尝试以人类的方法讨你欢心而已。"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei5", "yan1", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(6058); // "「当然，{nw}{w=0.01}"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
            yield return _gameMethods.OpenDialog(6059); // "如果你要奖励我些什么，{nw}{w=0.01}"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui14"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
            yield return _gameMethods.OpenDialog(6060); // "我也不会拒绝。」"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_qian", parts: new List<string>{"mei7", "yan12", "zui15"});
            yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(4); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan8", "zui3"});
            yield return _gameMethods.OpenDialog(1439); // "谢谢你。"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan8", "zui6"});
            yield return _gameMethods.OpenDialog(6061); // "那不如……多喜欢我一点。"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
            yield return _gameMethods.OpenDialog(6062); // "「又或者，{nw}{w=0.01}"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui17"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
            yield return _gameMethods.OpenDialog(6063); // "骗我久一点？」"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
            Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
            if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
            {
                _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
                _gameMethods.SyncAchievement();
            }
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan5", "zui10"});
            yield return _gameMethods.OpenDialog(6064); // "不管你信不信，我可都是真心的。"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan14", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(6065); // "嗯——是啊。"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui13"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo");
            yield return _gameMethods.OpenDialog(6066); // "只有真心才换得到真心嘛。"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui17"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
            yield return _gameMethods.OpenDialog(6067); // "「那么，{nw}{w=0.01}"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui14"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
            yield return _gameMethods.OpenDialog(6068); // "我期待得到你的真心。」"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan24", "zui16", "emoji2"});
            yield return _gameMethods.OpenDialog(4); // "……"
            yield return _gameMethods.Hide("nuo_heart_layered");
            yield return _gameMethods.Transition(time:0.5f);
            Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
            if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
            {
                _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
                _gameMethods.SyncAchievement();
            }
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan24", "zui16", "emoji2"});
            yield return _gameMethods.OpenDialog(6069); // "诺伯拉给我的感觉就像那种会为了尝鲜而河豚中毒的类型。"
        }

        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(6070); // "想当上女王，其实很简单。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(6071); // "把国王、王子、公主造成的障碍依次克服掉..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(6072); // "但我不喜欢做得太过火。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(6073); // "和我有过节的只有国王..."
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 2;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15"});
        yield return _gameMethods.OpenDialog(6074); // "所以，如果我不想舍弃自己的良心和原则..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan20", "zui15"});
        yield return _gameMethods.OpenDialog(6075); // "然而，经常办事的朋友们都知道..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui5"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.67f}, {"alpha", 0f}, {"blur", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1f}, {"blur", 0f}})});
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/juezhan_1_7458474b.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo");
        yield return _gameMethods.OpenDialog(6076); // "你是不是太心软了？"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei3", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("nuo_heart_layered", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}, {"blur", 0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei3", "yan10", "zui18", "emoji2"});
        yield return _gameMethods.OpenDialog(6077); // "怎么突然插嘴啊！"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui13"});
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/juezhan_1_fe4be022.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo");
        yield return _gameMethods.OpenDialog(6078); // "不过，这一点也令我很中意。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui16"});
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/juezhan_1_5c48d0e3.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian", parts: new List<string>{"mei3", "yan5", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(6079); // "「你愿意为了哪些人，哪些事..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui13"});
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/juezhan_1_230b6d6e.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
        yield return _gameMethods.OpenDialog(6080); // "又在哪些方面宁可吃苦..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/juezhan_1_2b768cf3.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
        yield return _gameMethods.OpenDialog(6081); // "「——在这些微妙的关键点上..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui16"});
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/juezhan_1_ae77e972.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
        yield return _gameMethods.OpenDialog(6082); // "总是特别有趣。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei3", "yan22", "zui3", "emoji2"});
        yield return _gameMethods.OpenDialog(6083); // "……这种说法，简直像是以小说为食粮的阅读爱好者一样啊……"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui14"});
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/juezhan_1_abcb7955.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei3", "yan22", "zui7", "emoji2"});
        yield return _gameMethods.OpenDialog(6084); // "你就是我最重要的精神食粮呀。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui17"});
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/juezhan_1_c1772363.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei3", "yan5", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(6085); // "观察你的一举一动，都充满了乐趣。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei3", "yan10", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei3", "yan13", "zui15", "emoji5", "-emoji2"});
        yield return _gameMethods.OpenDialog(6086); // "{size=+10}……做出过火发言了。{/size}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui17"});
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/juezhan_1_3ff1498f.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian", parts: new List<string>{"mei3", "yan5", "zui15", "-emoji5"});
        yield return _gameMethods.OpenDialog(6087); // "「呵呵，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/juezhan_1_93be6c5e.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
        yield return _gameMethods.OpenDialog(6088); // "让我听听你的宏伟计划吧..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui1"});
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/juezhan_1_eef651ef.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
        yield return _gameMethods.OpenDialog(6089); // "小女王。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan1", "zui14"});
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/juezhan_1_bcb6a149.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian", parts: new List<string>{"mei3", "yan5", "zui15", "-emoji5"});
        yield return _gameMethods.OpenDialog(6090); // "「我很好奇，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui13"});
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/juezhan_1_afabbfce.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
        yield return _gameMethods.OpenDialog(6091); // "你打算设计怎样的策略。」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/juezhan_1_a4ee3348.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
        yield return _gameMethods.OpenDialog(6092); // "「又愿意付出多大的代价..."
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui16"});
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/juezhan_1_a7137fc8.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
        yield return _gameMethods.OpenDialog(6093); // "来让你的这份良心，得以保留？」"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_qian", parts: new List<string>{"mei3", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei3", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("nuo_heart_layered", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"alpha", 0f}, {"blur", 0.01f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(6094); // "虽然有些不爽，但我还是继续思考起来。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(6095); // "众所周知，兵贵神速。"
        yield return _gameMethods.Hide("nuo_heart_layered");
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan20", "zui15"});
        yield return _gameMethods.OpenDialog(6096); // "\n想拿下王都，首先要迅速处理王都的部署。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(6097); // "由于我被接到王宫后并不是立刻被带走..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan9", "zui15"});
        yield return _gameMethods.OpenDialog(6098); // "\n那几天里我穷极无聊..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(6099); // "再加上在黑龙城堡中，也阅读了许多政史书籍。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(6100); // "——因此，我得以了解到..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(6101); // "国王打仗时的军队..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan18", "zui15"});
        yield return _gameMethods.OpenDialog(6102); // "而排除掉长期驻扎在边疆的兵力..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(6103); // "——尽管如此。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(6104); // "一千兵力..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan9", "zui15"});
        yield return _gameMethods.OpenDialog(6105); // "在这种情况下，我之所以敢于尝试..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan21", "zui15"});
        yield return _gameMethods.OpenDialog(6106); // "——在这个剑与魔法的世界..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(6107); // "换句话说，千人军队不是主要矛盾点。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(6108); // "只要拿下其中真正作为战术核心..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(6109); // "就大局已定了。"
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.ChangeLabelTo("label_end7");
    }

    public IEnumerator label_end3_1_2_tuan2()
    {
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(6110); // "我不想追名逐利。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15"});
        yield return _gameMethods.OpenDialog(6111); // "我喜欢爱、真心，一切鲜活而真诚的东西..."
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan9", "zui10"});
        yield return _gameMethods.OpenDialog(6112); // "我想去冒险。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(6113); // "我要去认识这个世界。"

        if (Defaults.Bai_kiss == 1)
        {
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui13"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.67f}, {"alpha", 0f}, {"blur", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1f}, {"blur", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(6114); // "听起来很有趣呢。"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan8", "zui19"});
            yield return _gameMethods.OpenDialog(6115); // "是啊……"
            yield return _gameMethods.Show("nuo_heart_layered", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}, {"blur", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan12", "zui3"});
            yield return _gameMethods.OpenDialog(6116); // "你的确很擅长说服，或者诱惑。"
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan8", "zui7"});
            yield return _gameMethods.OpenDialog(6117); // "只要了解到这块大陆的广袤，就很难不动心。"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui16"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo");
            yield return _gameMethods.OpenDialog(6118); // "只有你值得我这么花心思啊，公主殿下。"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan10", "zui19"});
            yield return _gameMethods.OpenDialog(6119); // "哈哈、哈哈……"
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan24", "zui7"});
            yield return _gameMethods.OpenDialog(3555); // "真的吗，我不信。"
        }

        if (Defaults.Bai_xue == 1)
        {
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui14"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.67f}, {"alpha", 0f}, {"blur", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1f}, {"blur", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(6120); // "好呀，会很精彩吧。"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan7", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan12", "zui10"});
            yield return _gameMethods.OpenDialog(6121); // "是啊，还是被你口中的故事给诱惑到了……"
            yield return _gameMethods.Show("nuo_heart_layered", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}, {"blur", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(6117); // "只要了解到这块大陆的广袤，就很难不动心。"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
            yield return _gameMethods.OpenDialog(5003); // "「嗯——{nw}{w=0.01}"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui14"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo_qian");
            yield return _gameMethods.OpenDialog(6122); // "那我是不是应该负责到底？」"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan10", "zui6", "emoji2"});
            yield return _gameMethods.OpenDialog(6123); // "……怎么还是问句啊。"
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai");
            yield return _gameMethods.OpenDialog(6124); // "要我表态是吧。"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan12", "zui10", "-emoji2"});
            yield return _gameMethods.OpenDialog(6125); // "我怎么知道？"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
            yield return _gameMethods.OpenDialog(6126); // "我把皮球抛回去。"
            Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
            if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
            {
                _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
                _gameMethods.SyncAchievement();
            }
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin", parts: new List<string>{"mei7", "yan5", "zui10"});
            yield return _gameMethods.OpenDialog(6127); // "尊重你的决定哦。"
            yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui14"});
            yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_nuo", parts: new List<string>{"mei7", "yan5", "zui15"});
            yield return _gameMethods.OpenDialog(5009); // "呵呵……"
        }

        yield return _gameMethods.Hide("nuo_heart_layered");
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.PlaySound("soundb", 0.0f, 6f, "audio/sound/end/wind_at_night1_01.ogg");
        yield return _gameMethods.OpenDialog(6128); // "我们不再开口。"
        yield return _gameMethods.Scene("tiankong_baitian1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.21f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.68f}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", -150f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.6f}}), new SameLineParamData(new Dictionary<string, object>{{"easein_circ", 2f}, {"yoffset", 0f}})});
        yield return _gameMethods.Transition(time:1.1f);
        yield return _gameMethods.OpenDialog(6129); // "迎着风流，我抬起头，望向前方。"
        yield return _gameMethods.OpenDialog(6130); // "晨光闪耀，地平线广袤无垠。"
        yield return _gameMethods.OpenDialog(6131); // "这个世界如此宽阔。"
        yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:4f);
        yield return _gameMethods.StopSound(channelName:"soundc", fadeOut:4f);
        // rpy: if bai_kiss == 1 and he_xianzai == 1: jump end4  else: jump end5
        // end4 被用户决策跳过，两条分支都跳到 end5
        yield return _gameMethods.ChangeLabelTo("label_end5");
    }
}
