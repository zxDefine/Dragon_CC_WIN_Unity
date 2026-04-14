
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class end5_menu : ILabelProvider
{
    private GameMethods _gameMethods;

    public end5_menu(GameMethods gameMethods)
    {
        _gameMethods = gameMethods;
    }
    
    public IEnumerator label_end5_menu_0_p3A6cVRF()
    {
        yield return _gameMethods.ChangeLabelTo("label_end3_1_tuan5_1");

    }

    public IEnumerator label_end5_menu_0_Pcj7Z1Sp()
    {
        yield return _gameMethods.ChangeLabelTo("label_end3_1_tuan5_2");

    }

    public IEnumerator label_end5_menu_0_x1vkdZEr()
    {
        yield return _gameMethods.ChangeLabelTo("label_end3_1_tuan5_3");

    }

    public IEnumerator label_end5_menu_0_0Q5klCm0()
    {
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
                if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
                {
                                        
                                _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
                                _gameMethods.SyncAchievement();

                }
                yield return _gameMethods.ChangeLabelTo("label_end3_1_tuan5_4");

    }

    public IEnumerator label_end5_menu_0_iZ0wGrLd()
    {
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 2;
                if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
                {
                                        
                                _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
                                _gameMethods.SyncAchievement();

                }
                yield return _gameMethods.ChangeLabelTo("label_end3_1_tuan5_5");

    }

    public IEnumerator label_end5_menu_0_1MiuAE6D()
    {
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 3;
                if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
                {
                                        
                                _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
                                _gameMethods.SyncAchievement();

                }
                yield return _gameMethods.ChangeLabelTo("label_end3_1_tuan5_6");

    }

    
}