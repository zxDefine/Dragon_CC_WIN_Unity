using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zhuxian5_menu : ILabelProvider
{
    private GameMethods _gameMethods;

    public zhuxian5_menu(GameMethods gameMethods)
    {
        _gameMethods = gameMethods;
    }

    // "-有过，是碳基活人" 分支 (rpy L270)
    public IEnumerator label_zhuxian5_menu_0_zOVaB79d()
    {
        Defaults.He_about_boyfriend_type = 1;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui7", "-emoji2"});
        yield return _gameMethods.OpenDialog(6993); // "虽然也许令人惊讶，但……{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan9", "zui6"});
        yield return _gameMethods.OpenDialog(6994); // "是的，我真的有过那么一名——好吧，也许是几名——..."
        yield return _gameMethods.EngineSetVolume(volume:0.2f, delay:2.0f, channelName:"music");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(6995); // "然而，时间已经过去了太久太久。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(6996); // "阻隔在我们之间的岁月与空间如此巨大，使得站在对面..."
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(6997); // "………… "
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:6.0f);
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui9"});
        yield return _gameMethods.OpenDialog(6998); // "「一时之间，不知该从何说起。{nw}{w=0.0..."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(6999); // "我哑然无声。」"
        yield return _gameMethods.ChangeLabelTo("label_zhuxian5_choice1_bai");
    }

    // "-没有，寡王的一生" 分支 (rpy L287)
    public IEnumerator label_zhuxian5_menu_0_dVxsu37I()
    {
        Defaults.He_about_boyfriend_type = 2;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(7001); // "我努力地回忆了一下。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei6", "yan12", "zui18"});
        yield return _gameMethods.OpenDialog(7002); // "又努力地回忆了一下。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei6", "yan12", "zui2", "emoji2"});
        yield return _gameMethods.OpenDialog(7003); // "…显然，这份努力并不能为我凭空创造出一位不曾存在..."
        yield return _gameMethods.EngineSetVolume(volume:0.6f, delay:2.0f, channelName:"music");
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei6", "yan8", "zui8", "-emoji2"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7004); // "实际上，光是谋生都已经让我精疲力竭了，{nw}{..."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei6", "yan8", "zui22"});
        yield return _gameMethods.OpenDialog(7005); // "如果下班后少的可怜的时间还要用来陪伴别人，{nw..."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei6", "yan12", "zui16", "emoji2"});
        yield return _gameMethods.OpenDialog(7006); // "那人生就真的暗无天日了。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(7007); // "……但是，是否应该承认自己的单身历史呢？"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan5", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(7008); // "这会不会显得我建立社会关系的经验不够丰富，历练不..."
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:6.0f);
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei6", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(7009); // "一时之间，我陷入了犹豫。"
        yield return _gameMethods.ChangeLabelTo("label_zhuxian5_choice1_bai");
    }

    // "-有很多，纸片的" 分支 (rpy L311)
    public IEnumerator label_zhuxian5_menu_0_6EnhTLGh()
    {
        Defaults.He_about_boyfriend_type = 3;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"-emoji2"});
        yield return _gameMethods.OpenDialog(7011); // "我无意夸耀什么，{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan12", "zui18"});
        yield return _gameMethods.OpenDialog(7012); // "但的的确确拥有着超过千万字的丰富的恋爱阅历。"
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/demo_audio/sound/liangjinjin_01.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan10", "zui18", "emoji7"});
        yield return _gameMethods.OpenDialog(7013); // "不仅如此，{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan12", "zui5"});
        yield return _gameMethods.OpenDialog(7014); // "我还全面均衡地接触过风靡市场的各种类型。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui5"});
        yield return _gameMethods.OpenDialog(7015); // "对于传统和新潮的爱情关系，{nw}{w=0.01..."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei8", "yan11", "zui4"});
        yield return _gameMethods.OpenDialog(7016); // "都有着非同一般的深刻了解。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan11", "zui6", "-emoji7"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:6.0f);
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan24", "zui16", "emoji2"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7017); // "得思考一下，该怎么形容这种过于先进的恋爱观。"
        yield return _gameMethods.ChangeLabelTo("label_zhuxian5_choice1_bai");
    }

    // "-和你差不多" 分支 (rpy L574)
    public IEnumerator label_zhuxian5_menu_1_sY7K8iTE()
    {
        Defaults.He_about_boyfriend = 0;
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan6", "zui10"});
        yield return _gameMethods.OpenDialog(7099); // "「他……"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan3", "zui2"});
        Defaults.Haogandu_he = Defaults.Haogandu_he + 5;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan6", "zui3"});
        yield return _gameMethods.OpenDialog(7100); // "和你差不多吧。」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan2", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(7101); // "也不是没有喜欢过高冷的角色。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan24", "zui16", "-emoji2"});
        yield return _gameMethods.OpenDialog(7102); // "……我默默咽下了“其中有一部分”这几个字。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan15", "zui19"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan25", "zui19"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan15", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(7103); // "那么，你也可以放弃他。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei2", "yan15", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(975); // "嗯？"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(7104); // "你可以放弃他，把爱情的对象换成我。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui12"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
        yield return _gameMethods.OpenDialog(7105); // "「他能做到的一切，{nw}{w=0.01}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
        yield return _gameMethods.OpenDialog(7106); // "我只会比他做得更好。」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui16", "emoji1", "emoji2", "emoji5", "emoji6"});
        yield return _gameMethods.OpenDialog(7107); // "{size=+8}不行。至少他不会把我带到城堡严..."
        yield return _gameMethods.Hide("he");
        yield return _gameMethods.Hide("shuben");
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei11", "yan2", "zui15"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.67f}, {"alpha", 0.0f}, {"blur", 1.0f}, {"pos", new Vector2(12.0f, -54.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 0.0f}, {"pos", new Vector2(0.5f, 2.39f)}, {"zoom", 0.51f}})});
        yield return _gameMethods.Show("shuben", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 430.0f}})});
        yield return _gameMethods.OpenDialog(7108); // "噗嗤……！"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui3"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.OpenDialog(7109); // "我就不会这样呢。"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_1_xin_wu", parts: new List<string>{"mei7", "yan10", "zui6"});
        yield return _gameMethods.OpenDialog(7110); // "（是啊，该被看管的那个是你……）"
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan2", "zui3"});
        yield return _gameMethods.OpenDialog(7111); // "真伤心。"
        yield return _gameMethods.Show("nuo_heart_layered", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.7f}, {"alpha", 0.0f}, {"blur", 0.1f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui19", "-emoji1", "-emoji2", "-emoji5", "-emoji6"});
        yield return _gameMethods.OpenDialog(7112); // "「嗯——那个，其他的先不谈，{nw}{w=0.0..."
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.5f, "audio/sound/manbu/Body1_02_duan.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -18.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.5f}, {"zpos", -36.0f}})});
        yield return _gameMethods.OpenDialog(7113); // "爱情可不是一个人的事情哦。」"
        yield return _gameMethods.Hide("nuo_heart_layered");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -36.0f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(7114); // "你也会受到影响，会很麻烦的。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan4", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan5", "zui6"});
        yield return _gameMethods.OpenDialog(7115); // "比如说？"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan4", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7116); // "我决定提高一点难度门槛，稍稍制约一下事态的发展程..."
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan6", "zui2"});
        yield return _gameMethods.OpenDialog(7117); // "「比如，你必须关心对方，花时间精力陪伴对方，{n..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.OpenDialog(7118); // "哪怕在你很忙碌、心情烦躁的时候，也要履行义务。」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan28", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan12", "zui2"});
        yield return _gameMethods.OpenDialog(7119); // "因为伴侣就宛如命运共同体一般的存在，即便自己不开..."
        yield return _gameMethods.OpenDialog(7120); // "在自己很生气时，也必须冷静下来，温柔地对待她。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan27", "zui2"});
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(7121); // "爱，不仅仅是享受权利，更要承担责任与约束。"
        yield return _gameMethods.Hide("he");
        yield return _gameMethods.Hide("shuben");
        yield return _gameMethods.Show("nuo_heart_layered", parts: new List<string>{"mei7", "yan13", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.67f}, {"alpha", 0.0f}, {"blur", 1.0f}, {"pos", new Vector2(12.0f, -54.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan27", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 0.0f}, {"pos", new Vector2(0.5f, 2.39f)}, {"zoom", 0.51f}})});
        yield return _gameMethods.Show("shuben", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 430.0f}})});
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.Show("nuo_heart_layered", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.7f}, {"alpha", 0.0f}, {"blur", 0.1f}})});
        yield return _gameMethods.OpenDialog(7122); // "而且，你的自由也会受限。如果你要我爱你，那么你也..."
        yield return _gameMethods.OpenDialog(7123); // "至少，在和我结束关系之前一直如此。"
        yield return _gameMethods.Hide("nuo_heart_layered");
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan5", "zui6"});
        yield return _gameMethods.OpenDialog(249); // "可以。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui21"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(7124); // "「我没有其他需要去爱的生物。{nw}{w=0.0..."
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
        yield return _gameMethods.OpenDialog(7125); // "也不会和你结束关系。」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui16", "emoji2"});
        yield return _gameMethods.OpenDialog(7126); // "你真果决啊。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(7127); // "「呃，那等你长大了，{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan11", "zui19", "-emoji2"});
        yield return _gameMethods.OpenDialog(7128); // "我就再考虑考虑吧。」"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.5f, "audio/sound/manbu/Body1_02_duan.mp3");
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.5f}, {"zpos", 10.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan11", "zui6"});
        yield return _gameMethods.OpenDialog(7129); // "具体期限是多久。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 10.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan11", "zui6", "emoji2"});
        yield return _gameMethods.OpenDialog(7130); // "太严谨了吧。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan6", "zui19"});
        yield return _gameMethods.OpenDialog(7131); // "至少等你幼年期结束吧。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui15", "-emoji1", "-emoji2"});
        yield return _gameMethods.OpenDialog(7132); // "要是那时候我还能活着，什么都好商量。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan22", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan15", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(4368); // "好。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(7133); // "……无论如何，你已经再也不会见到那个人了。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/manbu/Body1_02_duan.mp3");
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan25", "zui13"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 10.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.6f}, {"zpos", 0.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(7134); // "所以没有爱下去的必要，这只会是浪费时间而已。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan8", "zui19"});
        yield return _gameMethods.OpenDialog(7135); // "「是呢。我已经回不去了，{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(7136); // "所以你不需要担心。」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan10", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan8", "zui15"});
        yield return _gameMethods.OpenDialog(7137); // "……我没有表达担心，只是在陈述事实。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(7138); // "你应该省下时间，去做些更实际的事。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan27", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui20"});
        yield return _gameMethods.OpenDialog(3622); // "比如？"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan5", "zui6"});
        yield return _gameMethods.OpenDialog(7139); // "「……比如读书，{nw}{w=0.01}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui9"});
        yield return _gameMethods.OpenDialog(7140); // "和我一起。」"
        yield return _gameMethods.PlaySound("sound", 0.2f, 0.4f, "audio/demo_audio/sound/moca2.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -36.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.5f}, {"zpos", -18.0f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan13", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.OpenDialog(7141); // "呵呵，心口不一。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(7142); // "是呀，当然。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -18.0f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan3", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui19"});
        yield return _gameMethods.OpenDialog(7143); // "「现在我只有你了，{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan17", "zui4"});
        yield return _gameMethods.OpenDialog(7144); // "所以我们不是正在一起读书吗？」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan9", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan17", "zui7"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.OpenDialog(7145); // "结束聊天，我继续复习起了真言。"
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:8.0f);
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.ChangeLabelTo("label_bai_about_BlackDragon");
    }

    // "-和你完全不同" 分支 (rpy L756)
    public IEnumerator label_zhuxian5_menu_1_k2JHdgwY()
    {
        Defaults.He_about_boyfriend = 1;
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan7", "zui11", "-emoji2"});
        yield return _gameMethods.OpenDialog(7147); // "「他是个……"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan2", "zui10"});
        yield return _gameMethods.OpenDialog(7148); // "和你完全不同的人。」"
        if (Defaults.He_about_boyfriend_type == 3)
        {
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan2", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan3", "zui8", "emoji2"});
            yield return _gameMethods.OpenDialog(7149); // "首先，制作材料就有天差地别。"
        }
        if (Defaults.He_about_boyfriend_type == 1)
        {
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan2", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan3", "zui8", "emoji2"});
            yield return _gameMethods.OpenDialog(7150); // "首先，物种就有着天差地别。"
        }
        if (Defaults.He_about_boyfriend_type == 2)
        {
            yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan2", "zui2"});
            yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan3", "zui8", "emoji2"});
            yield return _gameMethods.OpenDialog(7151); // "首先，有没有这号人就是个问题。"
        }
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:8.0f);
        yield return _gameMethods.Show("he", parts: new List<string>{"mei1", "yan2", "zui2"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("he_nv_qian", parts: new List<string>{"mei7", "yan12", "zui6", "-emoji2"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei7", "yan2", "zui6"});
        yield return _gameMethods.OpenDialog(1926); // "………"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan24", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(7152); // "哦。是吗。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan24", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(7153); // "他的神色蓦地冷了下去。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan25", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(7154); // "遗憾的是，无论如何，你已经再也不会见到那个人了。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan27", "zui18"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(7155); // "所以没必要继续追忆他，那只会是浪费时间而已。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei3", "yan27", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei18", "yan24", "zui20"});
        yield return _gameMethods.PlaySound("music2", 2.0f, 0.6f, "audio/music/kepa/PerituneMaterial_Ominous.mp3");
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(7156); // "怎么？\n难道你还指望能和那家伙重聚吗。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei18", "yan24", "zui19"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7157); // "见我没有回答，他有些嘲讽地问道。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(7158); // "我第一次见赫泽尔露出那种透着几分讥诮的笑容，{n..."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(7159); // "仿佛是在看着自不量力的蝼蚁，显得如此陌生，近乎带..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan11", "zui8", "-emoji2"});
        yield return _gameMethods.OpenDialog(7160); // "……我露出笑容。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(7161); // "哈哈、是啊。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei3", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(7162); // "「毕竟，我马上就要离世了嘛。"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan8", "zui20"});
        yield return _gameMethods.OpenDialog(7163); // "离世前唯一能见到，"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei3", "yan20", "zui20"});
        yield return _gameMethods.OpenDialog(7164); // "也就只有你了吧。」"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei9", "yan27", "zui3"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv", parts: new List<string>{"mei3", "yan20", "zui15"});
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei18", "yan22", "zui12"});
        yield return _gameMethods.ExecuteCharacterImageData("he_nv");
        yield return _gameMethods.OpenDialog(7165); // "你知道就好。"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei18", "yan22", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei3", "yan21", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.PlaySound("sound", 0.2f, 0.4f, "audio/demo_audio/sound/moca2.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -60.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.5f}, {"ypos", 18.0f}})});
        yield return _gameMethods.Show("he", parts: new List<string>{"mei17", "yan15", "zui3"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7166); // "不知为何，我忽然失去了读书的胃口。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 18.0f}})});
        yield return _gameMethods.Hide("heilong_shufang_baitian_shafa");
        yield return _gameMethods.Hide("he");
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan21", "zui15"});
        yield return _gameMethods.OpenDialog(7167); // "低下头，呆愣愣地望着书页许久，却一个字都没看进去..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(7168); // "…………好吧。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7169); // "我安慰自己说。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7170); // "赫泽尔的这个生理阶段，在人类里充其量也就是个高年..."
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(7171); // "孩子还小，说着玩的，算了算了。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/manbu/Body1_02_duan.mp3");
        yield return _gameMethods.PlaySound("sounda1", 0.0f, 1.0f, "audio/demo_audio/sound/book1.mp3");
        yield return _gameMethods.Show("shuben", parts: new List<string>{"onlayer", "forward"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 430.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.5f}, {"yoffset", 350.0f}})});
        yield return _gameMethods.OpenDialog(7172); // "我压下情绪，继续复习真言。"
        yield return _gameMethods.StopSound(channelName:"music2", fadeOut:8.0f);
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.ChangeLabelTo("label_bai_about_BlackDragon");
    }

    // "—命运" 分支 (rpy L2758)
    public IEnumerator label_zhuxian5_menu_2_mvgqASuL()
    {
        yield return _gameMethods.ChangeLabelTo("label_mingyun");
    }

}
