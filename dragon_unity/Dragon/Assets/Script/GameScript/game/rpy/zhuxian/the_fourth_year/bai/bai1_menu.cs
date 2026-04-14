using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bai1_menu : ILabelProvider
{
    private GameMethods _gameMethods;

    public bai1_menu(GameMethods gameMethods)
    {
        _gameMethods = gameMethods;
    }

    // "-不怕" 分支 (bai_manbu menu L642)
    public IEnumerator label_bai1_menu_0_bufa()
    {
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10"});
        yield return _gameMethods.OpenDialog(6424); // "不怕。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui8"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui16"});
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(3904); // "哦？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(6425); // "「因为你是一个遵守承诺的人……"
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei3", "yan6", "zui2", "emoji2"});
        yield return _gameMethods.OpenDialog(659); // "呃，"
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei3", "yan24", "zui2", "emoji2"});
        yield return _gameMethods.OpenDialog(6426); // "龙。」"
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan2", "zui11", "-emoji2"});
        yield return _gameMethods.OpenDialog(6427); // "「如果游戏规则能被随意地更改、反悔..."
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan12", "zui10"});
        yield return _gameMethods.OpenDialog(6428); // "那么整盘游戏也就失去乐趣了。」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan5", "zui4"});
        yield return _gameMethods.OpenDialog(6429); // "所以哪怕你发火，也不会毁约的。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei8", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(6430); // "还真是被你吃住了。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui16"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(6431); // "这就是过河拆桥，兔死狗烹吗？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan11", "zui2"});
        yield return _gameMethods.OpenDialog(6432); // "不，这叫做彼此信赖。"
        yield return _gameMethods.ChangeLabelTo("label_zhuxian6_9");
    }

    // "-你不会发火的" 分支 (bai_manbu menu L642)
    public IEnumerator label_bai1_menu_0_buhuifa()
    {
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan2", "zui7"});
        yield return _gameMethods.OpenDialog(6434); // "你不会发火的。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui8"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui16"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei8", "yan2", "zui17"});
        yield return _gameMethods.OpenDialog(3904); // "哦？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(994); // "因为……"
        yield return _gameMethods.ChangeLabelTo("label_zhuxian6_5");
    }

    // "-你还没有得到我" 分支 (zhuxian6_5 menu L685)
    public IEnumerator label_bai1_menu_0_meidedao()
    {
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan12", "zui3"});
        yield return _gameMethods.OpenDialog(6436); // "因为，你还没有得到我。"
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan5", "zui8"});
        yield return _gameMethods.OpenDialog(6437); // "而越是还没得到的东西，对你就越有吸引力。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(6438); // "你果然很了解我。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan5", "zui8"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ChangeLabelTo("label_zhuxian6_9");
    }

    // "-你是我最最亲爱的诺伯拉呀" 分支 (zhuxian6_5 menu L685)
    public IEnumerator label_bai1_menu_0_qinaide()
    {
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
        yield return _gameMethods.OpenDialog(6440); // "「因为，"
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 3;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan11", "zui2", "emoji9", "emoji10", "emoji15"});
        yield return _gameMethods.OpenDialog(6441); // "你是我最最亲爱的诺伯拉呀。」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan4", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei8", "yan2", "zui8", "emoji9", "-emoji10", "emoji15"});
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei8", "yan2", "zui8", "-emoji9", "-emoji15"});
        yield return _gameMethods.OpenDialog(6442); // "「…{nw}{w=0.3}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei4", "yan13", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6443); // "真是不得了。」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei11", "yan11", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(6444); // "你该不会是真的有意在哄我吧？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei11", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(6445); // "如果是的话，会怎么样？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui18"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei8", "yan5", "zui8"});
        yield return _gameMethods.OpenDialog(6446); // "如果你是有意的，那很可怕。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui6"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6447); // "「如果是无意的，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei8", "yan11", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6448); // "就更可怕了。」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei8", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan10", "zui19", "emoji2"});
        yield return _gameMethods.OpenDialog(6449); // "……在你心里，我到底是一副什么样的形象啊……"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui16"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei8", "yan10", "zui8", "-emoji2"});
        yield return _gameMethods.OpenDialog(6450); // "你呢——"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6451); // "「你可是我见过的，最最可爱、{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui16"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei8", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(6452); // "最有魅力的，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui3"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6453); // "公主殿下啊。」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan11", "zui2"});
        yield return _gameMethods.OpenDialog(6454); // "「呵呵…！{nw}{w=0.01}"
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan17", "zui19"});
        yield return _gameMethods.OpenDialog(6455); // "那可真是太荣幸了。」"
        yield return _gameMethods.ChangeLabelTo("label_zhuxian6_9");
    }
}
