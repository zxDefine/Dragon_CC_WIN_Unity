using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tuanzhan_you_menu : ILabelProvider
{
    private GameMethods _gameMethods;

    public tuanzhan_you_menu(GameMethods gameMethods)
    {
        _gameMethods = gameMethods;
    }

    // "-出手" 分支 (rpy L913)
    public IEnumerator label_tuanzhan_you_menu_0_chushou()
    {
        yield return _gameMethods.PlaySound("sounda5", 0.0f, 2.0f, "audio/sound/emeng_dajie/magic1.ogg");
        yield return _gameMethods.PlaySound("sounda4", 0.0f, 1.0f, "audio/sound/juezhan2/Solidifying Ice_01.ogg");
        yield return _gameMethods.OpenDialog(6784); // "我瞬间拿出世界树枝干，念动咒语。"
        yield return _gameMethods.StopSound(channelName:"music1", fadeOut:2.0f);
        yield return _gameMethods.PlaySound("sound", 0.0f, 4.0f, "audio/sound/juezhan2/Blade Stab Cut Body Blood_01.ogg");
        yield return _gameMethods.Show("white", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}, {"zoom", 3.0f}, {"anchor", new Vector2(0.0f, 0.0f)}, {"pos", new Vector2(-582.0f, -360.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"alpha", 1.0f}})});
        yield return _gameMethods.OpenDialog(6785); // "赫泽尔立刻失去了力气，无力的右臂的方向偏移，垂在..."
        yield return _gameMethods.OpenDialog(6786); // "安德鲁抓住机会，放出更多的魔力，在体力即将耗尽的..."
        yield return _gameMethods.PlaySound("sounda", 0.0f, 0.3f, "<silence 0.3>audio/sound/juezhan_dao/tinnitus1.mp3");
        yield return _gameMethods.PlaySound("sounda6", 0.0f, 2.0f, "<silence 0.5>audio/sound/houhui/Bones Break Cracking_02.ogg");
        yield return _gameMethods.Scene("juezhan2_cg9", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 0.5f)}, {"pos", new Vector2(0.5f, 0.5f)}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 500.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.5f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 3.0f}, {"zpos", 708.0f}})});
        yield return _gameMethods.Show("2-37_zoom");
        yield return _gameMethods.Hide("2-37_zoom");
        yield return _gameMethods.TransitionWithFadeIn(outTime:0.2f, holdTime:0.2f, inTime:1.3f, colorCode:"#fff");
        yield return _gameMethods.OpenDialog(6787); // "——他将黑龙牢牢地控制在了身前。"
        yield return _gameMethods.ChangeLabelTo("label_end3_1_tuan3");
    }

    // "-什么约定？" 分支 (rpy L1362)
    public IEnumerator label_tuanzhan_you_menu_1_shenmeyueding()
    {
        yield return _gameMethods.ChangeLabelTo("label_end3_1_tuan1");
    }

}
