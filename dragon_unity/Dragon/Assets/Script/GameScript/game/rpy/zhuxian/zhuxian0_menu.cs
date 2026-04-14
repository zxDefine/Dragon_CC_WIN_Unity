
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class zhuxian0_menu : ILabelProvider
{
    private GameMethods _gameMethods;

    public zhuxian0_menu(GameMethods gameMethods)
    {
        _gameMethods = gameMethods;
    }
    
    public IEnumerator label_zhuxian0_menu_0_lxExYY4b()
    {
        yield return _gameMethods.ChangeLabelTo("label_choice1_1");

    }

    public IEnumerator label_zhuxian0_menu_0_YSR9LSxg()
    {
        yield return _gameMethods.ChangeLabelTo("label_choice1_2");

    }

    public IEnumerator label_zhuxian0_menu_0_VC1zFfEH()
    {
        yield return _gameMethods.ChangeLabelTo("label_choice1_3");

    }

    
}