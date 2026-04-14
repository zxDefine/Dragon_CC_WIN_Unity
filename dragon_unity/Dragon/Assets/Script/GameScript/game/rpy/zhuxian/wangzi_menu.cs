
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class wangzi_menu : ILabelProvider
{
    private GameMethods _gameMethods;

    public wangzi_menu(GameMethods gameMethods)
    {
        _gameMethods = gameMethods;
    }
    
    public IEnumerator label_wangzi_menu_0_SKSsp87i()
    {
        Defaults.Persistent.Jq_5_2 = 1;
                Defaults.Wangzixian = 1;
                yield return _gameMethods.ChangeLabelTo("label_zhuxian4_5");

    }

    public IEnumerator label_wangzi_menu_0_nEMsGra4()
    {
        yield return _gameMethods.OpenDialog(4147); // "弱者应该学会明哲保身，少沾惹麻烦事。"
                yield return _gameMethods.PlaySound("soundb", 0.0f, 1.0f, "audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
                yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/senlin7.jpg");
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
                yield return _gameMethods.TransitionBy("trans_rip_fast");
                yield return _gameMethods.StopSound(channelName:"music", fadeOut:6f);
                yield return _gameMethods.OpenDialog(4148); // "我远离了那个山洞，默默地在心中那个可供藏匿的地点备选名单上，将这个山洞划去。"
                yield return _gameMethods.OpenDialog(4149); // "继续去下一个地方吧。"
                yield return _gameMethods.OpenDialog(4150); // "……"
                yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:2f);
                yield return _gameMethods.SceneBlack();
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
                yield return _gameMethods.Transition(time:0.5f);
                yield return _gameMethods.OpenDialog(4151); // "在确认完所有藏匿点后，我回到了城堡。"

    }

    
}