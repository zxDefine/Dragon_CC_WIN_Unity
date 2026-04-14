
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class end3_menu : ILabelProvider
{
    private GameMethods _gameMethods;

    public end3_menu(GameMethods gameMethods)
    {
        _gameMethods = gameMethods;
    }
    
    public IEnumerator label_end3_menu_0_ZVbbTUu9()
    {
        yield return _gameMethods.ChangeLabelTo("label_end3_chuan1");

    }

    public IEnumerator label_end3_menu_0_tHYM9dti()
    {
        yield return _gameMethods.ChangeLabelTo("label_end3_chuan2");
    }

    public IEnumerator label_end3_menu_0_QCwG9o4I()
    {
        yield return _gameMethods.ChangeLabelTo("label_end3_chuan3");
    }

}