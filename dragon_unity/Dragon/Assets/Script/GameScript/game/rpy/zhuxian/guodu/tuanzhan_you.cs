using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tuanzhan_you : ILabelProvider
{
    private GameMethods _gameMethods;

    public tuanzhan_you(GameMethods gameMethods)
    {
        _gameMethods = gameMethods;
    }

    public IEnumerator label_tuanzhan_you()
    {
        yield return _gameMethods.OpenDialog(6663); // "是胆怯吗，还是心软了？"
        yield return _gameMethods.OpenDialog(6664); // "我犹豫了。"
        yield return _gameMethods.OpenDialog(6665); // "感觉无法下手。"
        yield return _gameMethods.OpenDialog(6666); // "之后再找机会吧，一定还有机会的。"
        Engine._dismiss_pause = false;
        yield return _gameMethods.Scene("juezhan_cg1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"ypos", 1.14f}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.78f}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.70f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.4f}}), new SameLineParamData(new Dictionary<string, object>{{"easein_circ", 0.2f}, {"xpos", 0.42f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        Defaults.Gui_duihuakuang_you = 0;
        yield return _gameMethods.PlaySound("sound", 0.0f, 5.0f, "audio/sound/juezhan_dao/Run Sword_01.mp3");
        yield return _gameMethods.TransitionWithFadeIn(outTime:0.2f, holdTime:0.2f, inTime:0.5f, colorCode:"#fff");
        yield return _gameMethods.PlaySound("music", 0.0f, 0.8f, "audio/music/juezhan/PerituneMaterial_Epic.mp3");
        Engine._dismiss_pause = true;
        yield return _gameMethods.OpenDialog(6667); // "太阳跳出地平线的一瞬间，安德鲁动了。"
        yield return _gameMethods.Scene("caodi2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(-0.31f, 1.44f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 1.57f}})});
        yield return _gameMethods.Show("he", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.54f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.3f}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}, {"blur", 0.01f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.3f}, {"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/juezhan_dao/SWORD_01.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.25f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", -2.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.02f}, {"xoffset", 2.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.25f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.02f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", 0.0f}, {"parallel_1", true}})});
        yield return _gameMethods.Show("lan_shan_l_r_car_lr");
        yield return _gameMethods.TransitionBy("pushmove_pushleft");
        yield return _gameMethods.OpenDialog(6668); // "他蓄势待发的身体宛若离弦之箭，在那一瞬间冲刺而来..."
        yield return _gameMethods.PlaySound("sounda2", 0.0f, 3.0f, "<silence 0.2>audio/sound/juezhan_dao/05 Attention Hit_01.mp3");
        yield return _gameMethods.PlaySound("sounda1", 0.0f, 2.0f, "audio/sound/juezhan_dao/Sword Swish and Clash Shing_01.ogg");
        yield return _gameMethods.StopEngineTime(time:0.2f);
        yield return _gameMethods.Hide("lan_shan_l_r_car_lr");
        yield return _gameMethods.Hide("he");
        yield return _gameMethods.Show("caodi2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"matrixcolor", "InvertMatrix(0.0)*ContrastMatrix(1.0)*SaturationMatrix(1.0)*BrightnessMatrix(0.0)*HueMatrix(0.0)"}, {"blur", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"matrixcolor", "InvertMatrix(0.0)*ContrastMatrix(1.0)*SaturationMatrix(1.0)*BrightnessMatrix(-0.26)*HueMatrix(0.0)"}, {"linear", 0.1f}, {"blur", 1.52f}})});
        yield return _gameMethods.Show("he", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.54f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.3f}})});
        yield return _gameMethods.Show("juezhan_cg3", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-360.0f, -186.0f)}, {"zoom", 1.0f}, {"anchor", new Vector2(0.0f, 0.0f)}, {"alpha", 0.7f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}, {"xoffset", 0.0f}, {"yoffset", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.1f}, {"zpos", 200.0f}})});
        yield return _gameMethods.OpenDialog(6669); // "我甚至没看清赫泽尔是如何抵挡的，只见到刀光剑影撞..."
        yield return _gameMethods.Show("juezhan_cg3", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-360.0f, -186.0f)}, {"zoom", 1.0f}})});
        yield return _gameMethods.Scene("juezhan_cg4", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 0.5f)}, {"anchor", new Vector2(0.5f, 0.5f)}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.25f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 1.5f}, {"zoom", 0.7f}})});
        yield return _gameMethods.PlaySound("sound", 0.0f, 2.0f, "audio/sound/juezhan_dao/Grass 3_01.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(6670); // "他熟练地在空中调整体态落地，双脚在地面上摩擦划了..."
        yield return _gameMethods.PlaySound("sounda1", 0.0f, 0.7f, "<silence 0.8>audio/sound/juezhan_dao/AXE DRAW draw _01.ogg");
        yield return _gameMethods.Scene("juezhan_cg5_ditu", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 0.5f)}, {"anchor", new Vector2(0.5f, 0.5f)}, {"zoom", 0.69f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -50.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 2.0f}, {"zpos", 0.0f}})});
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.OpenDialog(6671); // "他抿着唇，再次紧握住剑柄，摆好格挡与进攻的架势。"
        yield return _gameMethods.ExecuteCharacterImageData("nv2_qian");
        yield return _gameMethods.OpenDialog(6672); // "（不好，诺伯拉呢？）"
        yield return _gameMethods.ExecuteCharacterImageData("nv2_qian");
        yield return _gameMethods.OpenDialog(6673); // "（明明约好了的。）"
        yield return _gameMethods.OpenDialog(6674); // "我想做些什么，可战斗节奏急促紧凑，已远非我能插得..."
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.8f, "audio/sound/houhui/Bones Break Cracking_01.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein_cubic", 0.35f}, {"xpos", 270.0f}, {"zpos", -366.0f}})});
        yield return _gameMethods.Show("juezhan_cg6", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.71f, 0.55f)}, {"anchor", new Vector2(0.5f, 0.5f)}, {"zoom", 0.61f}, {"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.2f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.3f}, {"alpha", 1.0f}})});
        yield return _gameMethods.StopEngineTime(time:0.5f);
        yield return _gameMethods.PlaySound("sounda", 0.0f, 3.5f, "audio/sound/juezhan_dao/Black Magic_01.ogg");
        yield return _gameMethods.PlaySound("soundb", 1.0f, 0.4f, "audio/sound/juezhan_dao/Lightsaber Humming Constantly _01.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 270.0f}, {"zpos", -366.0f}})});
        yield return _gameMethods.Scene("juezhan_cg5_ditu1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.64f, 1.36f)}})});
        yield return _gameMethods.Show("juezhan_cg5_ball1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.64f, 1.36f)}})});
        yield return _gameMethods.Show("juezhan_cg5_an", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.64f, 1.36f)}})});
        yield return _gameMethods.TransitionBy("pushmove_pushright");
        yield return _gameMethods.OpenDialog(6675); // "赫泽尔一挥手，几道暗紫色的光球凝聚成形，骤然砸去..."
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -366.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 2.0f}, {"zpos", -222.0f}})});
        yield return _gameMethods.Show("juezhan_cg5_ball2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.64f, 1.36f)}, {"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1.0f}})});
        yield return _gameMethods.Show("juezhan_cg5_ball1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.8f}, {"alpha", 0.0f}})});
        yield return _gameMethods.Hide("juezhan_cg5_an");
        yield return _gameMethods.Show("juezhan_cg5_an", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.64f, 1.36f)}})});
        yield return _gameMethods.OpenDialog(6676); // "那球体的能量如此高密，导致周围空气都发生了一定程..."
        yield return _gameMethods.Hide("juezhan_cg5_ball1");
        yield return _gameMethods.Show("juezhan_cg5_ball2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        yield return _gameMethods.Show("juezhan_cg5_water1", parts: new List<string>{"with", "Dissolve(0.4)"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.64f, 1.36f)}, {"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.8f}, {"alpha", 1.0f}})});
        yield return _gameMethods.PlaySound("sounda1", 0.0f, 3.0f, "audio/sound/juezhan_dao/Water Spell Whoosh_01.ogg");
        yield return _gameMethods.OpenDialog(6677); // "洛恩挥动法杖，一道水幕罩住了两人。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 4.0f, "audio/sound/juezhan_dao/Electric Explosion Thunder Spell_01.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.1f}, {"zpos", 102.0f}, {"parallel_0", true}})});
        yield return _gameMethods.Show("juezhan_cg5_ball3", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.64f, 1.36f)}, {"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1.0f}})});
        yield return _gameMethods.Show("juezhan_cg5_ball2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.8f}, {"alpha", 0.0f}})});
        yield return _gameMethods.Hide("juezhan_cg5_an");
        yield return _gameMethods.Show("juezhan_cg5_an", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.64f, 1.36f)}})});
        yield return _gameMethods.Hide("juezhan_cg5_water1");
        yield return _gameMethods.Show("juezhan_cg5_water1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.64f, 1.36f)}, {"alpha", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 0.0f}})});
        yield return _gameMethods.Show("juezhan_cg5_water2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.64f, 1.36f)}, {"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1.0f}})});
        yield return _gameMethods.TransitionBy("hpunch");
        yield return _gameMethods.OpenDialog(6678); // "球体撞上水幕，立即剧烈爆炸。"
        yield return _gameMethods.Show("juezhan_cg5_ball3", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        yield return _gameMethods.Show("juezhan_cg5_water2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 102.0f}})});
        yield return _gameMethods.PlaySound("sounda2", 0.0f, 2.0f, "audio/sound/juezhan_dao/Acid Spell_01.ogg");
        yield return _gameMethods.OpenDialog(6679); // "嘶啦——。液体沸腾蒸发的声响。"
        yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:2.0f);
        yield return _gameMethods.PlaySound("sound", 0.0f, 3.0f, "audio/sound/juezhan_dao/Fireball Fly By Close Impact _01.ogg");
        yield return _gameMethods.Hide("juezhan_cg5_ball2");
        yield return _gameMethods.Hide("juezhan_cg5_water1");
        yield return _gameMethods.Show("juezhan_cg5_water2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.64f, 1.36f)}, {"alpha", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 0.0f}})});
        yield return _gameMethods.Show("juezhan_cg5_water3", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.64f, 1.36f)}, {"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1.0f}})});
        yield return _gameMethods.StopEngineTime(time:0.5f);
        yield return _gameMethods.SceneWhite();
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Transition(time:0.1f);
        yield return _gameMethods.OpenDialog(6680); // "水汽炸开，由远及近地弥漫，看不清爆炸中心处发生的..."
        yield return _gameMethods.Show("juezhan_cg7_ditu", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"xpos", 0.5f}, {"anchor", new Vector2(0.5f, 0.5f)}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 1.15f}, {"zoom", 0.92f}, {"alpha", 0.9f}})});
        yield return _gameMethods.Transition(time:0.8f);
        yield return _gameMethods.OpenDialog(6681); // "我正眯着眼睛试图分辨情况。"
        yield return _gameMethods.Show("juezhan_cg7_ditu", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"xpos", 0.5f}, {"anchor", new Vector2(0.5f, 0.5f)}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 1.15f}, {"zoom", 0.92f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.2f}, {"ypos", 1.09f}, {"zoom", 0.69f}, {"alpha", 1.0f}})});
        yield return _gameMethods.Show("juezhan_cg7_qi", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"xpos", 0.5f}, {"anchor", new Vector2(0.5f, 0.5f)}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 1.15f}, {"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zrotate", -48.0f}, {"zoom", 0.62f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.2f}, {"ypos", 1.09f}, {"zoom", 0.69f}, {"zrotate", 0.0f}, {"alpha", 1.0f}})});
        yield return _gameMethods.PlaySound("sound", 0.0f, 2.0f, "audio/sound/juezhan_dao/Whoosh Magical Winter_01.ogg");
        yield return _gameMethods.StopEngineTime(time:0.3f);
        yield return _gameMethods.PlaySound("sounda1", 0.0f, 2.0f, "audio/sound/juezhan_dao/AXE DRAW draw _02.ogg");
        yield return _gameMethods.Show("juezhan_cg7_an", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"xpos", 0.5f}, {"anchor", new Vector2(0.5f, 0.5f)}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.69f}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.1f}, {"alpha", 1.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 1.34f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 1.09f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"zrotate", 12.0f}, {"parallel_2", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.20f}, {"zrotate", 0.0f}, {"parallel_2", true}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}, {"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.24f}, {"ypos", -180.0f}, {"zpos", -168.0f}})});
        yield return _gameMethods.OpenDialog(6682); // "忽地，空气流动急转，一柄剑刃从中破出。"
        yield return _gameMethods.Show("2-32_zoom");
        yield return _gameMethods.Hide("2-32_zoom");
        yield return _gameMethods.PlaySound("sound", 0.0f, 5.0f, "audio/sound/juezhan_dao/Run Sword_01.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -180.0f}, {"zpos", -168.0f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.15f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.23f}, {"ypos", 756.0f}, {"zpos", 18.0f}})});
        yield return _gameMethods.TransitionWithFadeIn(outTime:0.1f, holdTime:0.1f, inTime:0.1f, colorCode:"#000");
        yield return _gameMethods.OpenDialog(6683); // "一眨眼，安德鲁已借着烟雾的掩护冲至近前。 "
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 756.0f}, {"zpos", 18.0f}})});
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end1_5a9a12fa.ogg");
        yield return _gameMethods.OpenDialog(6684); // "…把…她……"
        yield return _gameMethods.OpenDialog(6685); // "他的声音像是从牙缝中挤出来一样。"
        yield return _gameMethods.OpenDialog(6686); // "我仔细聆听，才勉强听到他在说什么。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 18.0f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein_cubic", 0.1f}, {"zpos", -100.0f}})});
        if (Defaults.Persistent.Povname == "辛西娅")
        {
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end1_9eaed253.ogg");
            yield return _gameMethods.ExecuteCharacterImageData("an_qian");
            yield return _gameMethods.OpenDialog(6687); // "「把辛西娅………………还给我！！！」{nw}{w..."
        }
        else
        {
            yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end1_653c56e6.ogg");
            yield return _gameMethods.ExecuteCharacterImageData("an_qian");
            yield return _gameMethods.OpenDialog(6688); // "「把[persistent.povname]……..."
        }
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/juezhan_dao/Run Sword_01.mp3");
        yield return _gameMethods.PlaySound("sounda", 0.0f, 3.0f, "audio/sound/juezhan_dao/Magic Block_01.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Show("lan_shan_l_r_car_tb");
        yield return _gameMethods.StopEngineTime(time:0.6f);
        yield return _gameMethods.Show("lan_shan_l_r_car_bt");
        yield return _gameMethods.StopEngineTime(time:0.7f);
        yield return _gameMethods.Show("lan_shan_l_r_car_lr");
        yield return _gameMethods.OpenDialog(6689); // "他挥下利刃，速度与力度仿佛逼近人类肉体的极限。"
        yield return _gameMethods.PlaySound("sounda1", 0.0f, 1.0f, "<from 0 to 1>audio/sound/juezhan_dao/Multi Slash Fast_01.mp3");
        yield return _gameMethods.Hide("lan_shan_l_r_car_tb");
        yield return _gameMethods.Hide("lan_shan_l_r_car_bt");
        yield return _gameMethods.Hide("lan_shan_l_r_car_lr");
        yield return _gameMethods.Show("black", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 2.0f}, {"anchor", new Vector2(0.5f, 0.5f)}})});
        yield return _gameMethods.Show("he", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 2.56f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.51f}, {"alpha", 0.0f}, {"blur", 0.01f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.Show("juezhan_cg3", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(-618.0f, -234.0f)}, {"anchor", new Vector2(0.0f, 0.0f)}, {"zoom", 1.3f}, {"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 0.5f}})});
        yield return _gameMethods.StopEngineTime(time:0.3f);
        yield return _gameMethods.Show("lan_shan_l_r_car_lr");
        yield return _gameMethods.Show("lan_shan_l_r_car_tb");
        yield return _gameMethods.Show("lan_shan_l_r_car_bt");
        yield return _gameMethods.TransitionBy("shake"); // Shake(0, 0, 0, 0, 1.0, dist=5)
        yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/end1_655cfa9c.ogg");
        yield return _gameMethods.OpenDialog(6690); // "把她还给我啊！！！！"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei11", "yan1", "zui2", "emoji2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}, {"blur", 0.0f}})});
        yield return _gameMethods.Show("juezhan_cg3", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.5f}})});
        yield return _gameMethods.ExecuteCharacterImageData("he_qian");
        yield return _gameMethods.OpenDialog(1543); // "「……{nw}{w=0.4}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei13", "yan7", "zui3", "emoji12"});
        yield return _gameMethods.OpenDialog(2500); // "……{nw}{w=0.4}"
        yield return _gameMethods.Show("he", parts: new List<string>{"mei20", "yan19", "zui3", "emoji12"});
        yield return _gameMethods.OpenDialog(1265); // "……」"
        yield return _gameMethods.Show("he", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.7f}, {"blur", 3.0f}})});
        yield return _gameMethods.Show("juezhan_cg3", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.7f}, {"blur", 10.0f}})});
        yield return _gameMethods.Show("juezhan_fenjing1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}, {"pos", new Vector2(-114.0f, 48.0f)}, {"anchor", new Vector2(0.0f, 0.0f)}, {"zoom", 0.79f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1.0f}})});
        yield return _gameMethods.OpenDialog(6691); // "赫泽尔的眼神沉下来。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/houhui/Bones Break Cracking_01.ogg");
        yield return _gameMethods.Show("juezhan_fenjing1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        yield return _gameMethods.Show("he", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 3.0f}})});
        yield return _gameMethods.Show("juezhan_cg3", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 10.0f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"matrixcolor", "InvertMatrix(0.0)*ContrastMatrix(1.0)*SaturationMatrix(1.0)*BrightnessMatrix(0.0)*HueMatrix(0.0)"}}), new SameLineParamData(new Dictionary<string, object>{{"matrixcolor", "InvertMatrix(0.0)*ContrastMatrix(1.18)*SaturationMatrix(2.09)*BrightnessMatrix(-0.25)*HueMatrix(0.0)"}, {"linear", 1.0f}})});
        yield return _gameMethods.OpenDialog(6692); // "战意？"
        yield return _gameMethods.OpenDialog(6693); // "我意识到，有什么微妙地发生了变化。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"matrixcolor", "InvertMatrix(0.0)*ContrastMatrix(1.18)*SaturationMatrix(2.09)*BrightnessMatrix(-0.25)*HueMatrix(0.0)"}})});
        yield return _gameMethods.OpenDialog(6694); // "向着糟糕的方向。"
        yield return _gameMethods.PlaySound("sounda", 0.0f, 2.0f, "audio/demo_audio/sound/Tension Riser B.mp3");
        yield return _gameMethods.SceneWhite();
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"matrixcolor", "InvertMatrix(0.0)*ContrastMatrix(1.0)*SaturationMatrix(1.0)*BrightnessMatrix(0.0)*HueMatrix(0.0)"}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.OpenDialog(6695); // "——接下来，一切都急转直下。"
        yield return _gameMethods.PlaySound("sounda3", 0.0f, 3.5f, "audio/sound/juezhan_dao/Black Magic 2_01.mp3");
        yield return _gameMethods.Scene("juezhan_cg8", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 0.5f)}, {"anchor", new Vector2(0.5f, 0.5f)}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.71f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.15f}, {"zoom", 0.68f}})});
        yield return _gameMethods.OpenDialog(6696); // "像是周身的气压忽然下降，那副威压强到令人产生生理..."
        yield return _gameMethods.Show("juezhan_cg8", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.68f}})});
        yield return _gameMethods.OpenDialog(6697); // "疾风骤雨，令人喘不过气一般的远程近战攻击。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 5.0f, "audio/sound/juezhan_dao/Sword Fast_01.ogg");
        yield return _gameMethods.OpenDialog(6698); // "仅仅几个回合，他已经打得安德鲁连连格挡，应接不暇..."
        yield return _gameMethods.EngineSetVolume(volume:0.0f, delay:1.0f, channelName:"sounda3");
        yield return _gameMethods.PlaySound("sounda", 0.0f, 5.0f, "audio/sound/juezhan_dao/Punch_01.mp3");
        yield return _gameMethods.PlaySound("sounda2", 0.0f, 4.0f, "audio/sound/juezhan_dao/Hit Hard Dust_01.mp3");
        yield return _gameMethods.Show("juezhan_cg9_ditu", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(648.0f, 732.0f)}, {"zoom", 0.71f}, {"blur", 12.0f}}), new SameLineParamData(new Dictionary<string, object>{{"matrixcolor", "InvertMatrix(0.0)*ContrastMatrix(1.0)*SaturationMatrix(1.0)*BrightnessMatrix(-0.2)*HueMatrix(0.0)"}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1.0f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.OpenDialog(6699); // "最终，被一击重重击飞。"
        yield return _gameMethods.Show("juezhan_cg9_ditu", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        yield return _gameMethods.OpenDialog(6700); // "……！！！"
        yield return _gameMethods.OpenDialog(6701); // "我的心瞬间提起。"
        yield return _gameMethods.Show("juezhan_cg9_an", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(648.0f, 732.0f)}, {"zoom", 0.71f}})});
        yield return _gameMethods.Show("2-33_zoom");
        yield return _gameMethods.Hide("2-33_zoom");
        yield return _gameMethods.Transition(time:0.8f);
        yield return _gameMethods.OpenDialog(6702); // "烟尘散去，金发少年踉跄爬起，咳了几声。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}, {"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.2f}, {"ypos", 66.0f}, {"zpos", -378.0f}})});
        yield return _gameMethods.PlaySound("sounda1", 0.0f, 1.0f, "audio/sound/juezhan_dao/Sharp As a Sword.ogg");
        yield return _gameMethods.TransitionBy("shake"); // Shake(0, 0, 0, 0, 0.7, dist=15)
        yield return _gameMethods.OpenDialog(6703); // "黑龙的下一击已接踵而至。"
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.PlaySound("sound", 0.0f, 3.0f, "audio/sound/juezhan_dao/Lightning Spell Cast_01.ogg");
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(6704); // "异常的声音。"
        yield return _gameMethods.Scene("juezhan_cg10_1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 0.5f)}, {"zpos", 0.0f}, {"pos", new Vector2(642.0f, 170.0f)}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Show("juezhan2_cg1_qiu", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 0.5f)}, {"zpos", 50.0f}, {"pos", new Vector2(642.0f, 170.0f)}})});
        yield return _gameMethods.Show("juezhan2_cg1_quan1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 0.5f)}, {"zpos", 50.0f}, {"pos", new Vector2(642.0f, 170.0f)}})});
        yield return _gameMethods.Show("juezhan2_cg1_quan2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 0.5f)}, {"zpos", 50.0f}, {"pos", new Vector2(642.0f, 170.0f)}, {"alpha", 0.0f}})});
        yield return _gameMethods.Show("juezhan_cg10_3", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 0.5f)}, {"zpos", 250.0f}, {"pos", new Vector2(642.0f, 90.0f)}})});
        yield return _gameMethods.Show("juezhan_cg10_4", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 0.5f)}, {"zpos", 400.0f}, {"pos", new Vector2(642.0f, 60.0f)}})});
        yield return _gameMethods.PlaySound("soundb", 0.0f, 4.0f, "sound/juezhan_dao/Ground Opening Spell Debris Falling and Wind_01.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}, {"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 2.5f}, {"ypos", -180.0f}, {"zpos", 378.0f}})});
        yield return _gameMethods.Show("2-34_zoom");
        yield return _gameMethods.Hide("2-34_zoom");
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.OpenDialog(6705); // "一个庞大的、黑色的能量影子在上空逐渐凝聚成形。"
        yield return _gameMethods.OpenDialog(6706); // "在它的周遭，空气被不断地撕裂，空间在肉眼可见的视..."
        yield return _gameMethods.OpenDialog(6707); // "球体本身漆黑如黑洞，在视域的边界却扭动着五光十色..."
        yield return _gameMethods.OpenDialog(6708); // "它的直径已经达到了至少十米，却仍在不断扩大。"
        yield return _gameMethods.OpenDialog(6709); // "强烈的危机感在心头闪烁。"
        yield return _gameMethods.OpenDialog(6710); // "仅仅肉眼就能得知拥有毁灭性的力量。"
        yield return _gameMethods.OpenDialog(6711); // "不行，不能让它成形。"
        yield return _gameMethods.OpenDialog(6712); // "一旦凝聚完整，就结束了。"
        yield return _gameMethods.OpenDialog(6713); // "趁这个喘息间隙，我终于找到机会，感受周身空间中存..."
        Defaults.Persistent.Jq_10_5 = 1;
        yield return _gameMethods.OpenDialog(6714); // "巨大球体的核心汇集着高密的暗性能量，极度危险，根..."
        yield return _gameMethods.OpenDialog(6715); // "我硬着头皮去感受它。"
        yield return _gameMethods.EngineSetVolume(volume:0.1f, delay:0.5f, channelName:"soundb");
        yield return _gameMethods.PlaySound("sounda", 0.0f, 3.0f, "audio/sound/houhui/Win Bell 2_01.mp3");
        yield return _gameMethods.OpenDialog(2317); // "——！！"
        yield return _gameMethods.OpenDialog(6716); // "就在意识接触到它的瞬间，我居然产生了一种熟悉感和..."
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/juezhan2/Magic Inspration_01.mp3");
        yield return _gameMethods.EngineSetVolume(volume:1.0f, delay:1.0f, channelName:"soundb");
        yield return _gameMethods.OpenDialog(6717); // "它的诸多“含义”经过某种解码，涌入脑海。"
        yield return _gameMethods.OpenDialog(6718); // "黑暗、乖离、膨胀、紊乱、无序……"
        yield return _gameMethods.OpenDialog(6719); // "——它在真言中的描述程式。"
        yield return _gameMethods.OpenDialog(6720); // "理论上讲，如果拥有足够魔力，充分吸收这些知识，反..."
        yield return _gameMethods.OpenDialog(6721); // "但来不及了。"
        yield return _gameMethods.OpenDialog(6722); // "只能调动最熟练的冰系魔法了。"
        yield return _gameMethods.OpenDialog(6723); // "在能量球的外围构筑一层冰层吧……哪怕只能延缓一点..."
        yield return _gameMethods.OpenDialog(6724); // "战场中心的赫泽尔似乎朝我转过了脸。"
        yield return _gameMethods.EngineSetVolume(volume:0.6f, delay:0.5f, channelName:"soundb");
        yield return _gameMethods.PlaySound("sounda", 0.0f, 2.0f, "audio/sound/juezhan2/ICE 2_01.mp3");
        yield return _gameMethods.OpenDialog(6725); // "我无暇辨认他的表情，全神贯注，施展法术。"
        yield return _gameMethods.Show("juezhan2_cg1_0", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 0.5f)}, {"zpos", 50.0f}, {"pos", new Vector2(642.0f, 170.0f)}, {"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1.0f}})});
        yield return _gameMethods.OpenDialog(6726); // "目标为直径十五米的空心球体。"
        yield return _gameMethods.Show("juezhan2_cg1_0", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 0.0f}})});
        yield return _gameMethods.Show("juezhan2_cg1_1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 0.5f)}, {"zpos", 50.0f}, {"pos", new Vector2(642.0f, 170.0f)}, {"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1.0f}})});
        yield return _gameMethods.OpenDialog(6727); // "基底建立完成。"
        yield return _gameMethods.OpenDialog(6728); // "厚度增长为……"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/juezhan2/Solidifying Ice_01.ogg");
        yield return _gameMethods.Hide("juezhan2_cg1_0");
        yield return _gameMethods.Show("juezhan2_cg1_1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 0.0f}})});
        yield return _gameMethods.Show("juezhan2_cg1_2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 0.5f)}, {"zpos", 50.0f}, {"pos", new Vector2(642.0f, 170.0f)}, {"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1.0f}})});
        yield return _gameMethods.OpenDialog(6729); // "半米。 {nw}{w=1.2}"
        yield return _gameMethods.Hide("juezhan2_cg1_1");
        yield return _gameMethods.Show("juezhan2_cg1_2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 0.0f}})});
        yield return _gameMethods.Show("juezhan2_cg1_3", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 0.5f)}, {"zpos", 50.0f}, {"pos", new Vector2(642.0f, 170.0f)}, {"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1.0f}})});
        yield return _gameMethods.PlaySound("sounda", 0.4f, 0.6f, "audio/sound/juezhan2/Solidifying Ice_01.ogg");
        yield return _gameMethods.OpenDialog(6730); // "一米。 {nw}{w=1.2}"
        yield return _gameMethods.Hide("juezhan2_cg1_2");
        yield return _gameMethods.Show("juezhan2_cg1_3", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 0.0f}})});
        yield return _gameMethods.Show("juezhan2_cg1_4", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 0.5f)}, {"zpos", 50.0f}, {"pos", new Vector2(642.0f, 170.0f)}, {"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1.0f}})});
        yield return _gameMethods.PlaySound("sounda2", 0.0f, 1.2f, "audio/sound/juezhan2/Solidifying Ice_01.ogg");
        yield return _gameMethods.OpenDialog(6731); // "三米。 {nw}{w=1.2}"
        yield return _gameMethods.OpenDialog(6732); // "魔力很快告罄。"
        yield return _gameMethods.OpenDialog(6733); // "膨胀中的黑色球体接触到了外侧的透明冰层。"
        yield return _gameMethods.PlaySound("sounda1", 0.0f, 4.0f, "audio/sound/juezhan2/Ice Cracking Pile of Snow Falling_01.ogg");
        yield return _gameMethods.Hide("juezhan2_cg1_3");
        yield return _gameMethods.Show("juezhan2_cg1_4", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.7f}, {"alpha", 0.0f}})});
        yield return _gameMethods.Show("juezhan2_cg1_5", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 0.5f)}, {"zpos", 50.0f}, {"pos", new Vector2(642.0f, 170.0f)}, {"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.7f}, {"alpha", 1.0f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -2.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 2.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 2.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", -2.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"repeat", true}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"repeat", true}, {"parallel_1", true}})});
        yield return _gameMethods.OpenDialog(6734); // "从交界处开始，冰层被寸寸挤碎。"
        yield return _gameMethods.OpenDialog(6735); // "能量球的增速被延缓少许，却仍在稳步扩大。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"yoffset", 0.0f}})});
        yield return _gameMethods.OpenDialog(6736); // "不行——"
        yield return _gameMethods.OpenDialog(6737); // "我咬牙坚持。"
        yield return _gameMethods.Hide("juezhan2_cg1_4");
        yield return _gameMethods.Show("juezhan2_cg1_5", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        yield return _gameMethods.OpenDialog(6738); // "竭力往外侧进一步延展冻结的厚度。"
        yield return _gameMethods.EngineSetVolume(volume:0.3f, delay:1.0f, channelName:"soundb");
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.6f, "audio/sound/juezhan2/Hollow Light Aura Spell_01.ogg");
        yield return _gameMethods.OpenDialog(6739); // "继续，再多一点！"
        yield return _gameMethods.PlaySound("sounda", 0.0f, 0.4f, "audio/sound/juezhan2/Screech and Fear Impact_01.ogg");
        yield return _gameMethods.OpenDialog(6740); // "枯竭的感觉。"
        yield return _gameMethods.OpenDialog(6741); // "我拼命凝聚精神，试图榨取出最后一丝力量。"
        yield return _gameMethods.PlaySound("sounda1", 0.3f, 1.4f, "audio/sound/juezhan2/Head_01.mp3");
        yield return _gameMethods.OpenDialog(6742); // "极限了。头痛欲裂。 "
        yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:1.0f);
        yield return _gameMethods.StopSound(channelName:"sounda1", fadeOut:1.0f);
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:1.0f);
        yield return _gameMethods.PlaySound("sounda2", 0.0f, 2.0f, "audio/sound/juezhan2/Whoosh Wind Chimes_01.ogg");
        yield return _gameMethods.OpenDialog(6743); // "——忽然，一股清凉的魔力涌入我的身体。"
        yield return _gameMethods.OpenDialog(6744); // "宛如一场宁静的大雪降临，冰冷的雪花从空中飘落，覆..."
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.5f, "audio/sound/juezhan2/Cloak_01.mp3");
        yield return _gameMethods.OpenDialog(6745); // "我的肩膀被人从身后笼罩住了，然后，那个人轻轻拉过..."
        yield return _gameMethods.OpenDialog(6746); // "真倔强啊。"
        yield return _gameMethods.OpenDialog(6747); // "明明都说过，只要念诵我的名讳，我就会将力量分享给..."
        yield return _gameMethods.PlaySound("music", 1.0f, 1.0f, "audio/music/wenxin/bing_PerituneMaterial_Foreboding_loop.mp3");
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/juezhan2/Magic Power_01.mp3");
        yield return _gameMethods.OpenDialog(6748); // "滞涩的冰元素蓦地如臂使指。"
        yield return _gameMethods.OpenDialog(6749); // "原本掏空的魔法回路再次充盈，仿佛连接上了一个取之..."
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/juezhan2/Freeze Magic Ice Cracking_01.ogg");
        yield return _gameMethods.Show("juezhan2_cg1_5", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 1.5f}, {"alpha", 0.0f}})});
        yield return _gameMethods.Show("juezhan2_cg1_6", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 0.5f)}, {"zpos", 50.0f}, {"pos", new Vector2(642.0f, 170.0f)}, {"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.5f}, {"alpha", 1.0f}})});
        yield return _gameMethods.Show("juezhan2_cg1_quan1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 1.5f}, {"alpha", 0.0f}})});
        yield return _gameMethods.Show("juezhan2_cg1_quan2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 0.5f)}, {"zpos", 50.0f}, {"pos", new Vector2(642.0f, 170.0f)}, {"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1.5f}, {"alpha", 1.0f}})});
        yield return _gameMethods.OpenDialog(6750); // "我单手握紧，魔力喷发，冰层暴涨，封冻几十米。"
        yield return _gameMethods.OpenDialog(6751); // "巨大的黑色球体瞬间被冻结。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -2.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 2.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 2.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", -2.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"repeat", true}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"repeat", true}, {"parallel_1", true}})});
        yield return _gameMethods.PlaySound("sounda1", 0.0f, 1.0f, "audio/sound/juezhan2/ICE Crash_01.mp3");
        yield return _gameMethods.OpenDialog(6752); // "接着，极度膨胀的物质能量与外界的约束力互相挤压。"
        yield return _gameMethods.PlaySound("sounda2", 0.0f, 1.5f, "audio/sound/juezhan2/ICE EX_01.mp3");
        yield return _gameMethods.SceneWhite();
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"yoffset", 0.0f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(6753); // "嘭——"
        yield return _gameMethods.OpenDialog(6754); // "冰球爆炸。"
        yield return _gameMethods.OpenDialog(6755); // "在空中化作一束盛大、晶莹的烟花雨。"
        yield return _gameMethods.OpenDialog(6756); // "冰晶在四周纷落而下。"
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:4.0f);
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.5f, "audio/sound/juezhan_dao/AXE DRAW draw _01.ogg");
        yield return _gameMethods.OpenDialog(6757); // "一道绿色的身影陡然突击出现，现身于赫泽尔身前不到..."
        yield return _gameMethods.PlaySound("music1", 0.0f, 0.6f, "audio/music/juezhan/PerituneMaterial_Firmament2_Active_loop.mp3");
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.5f, "audio/sound/juezhan2/Sharp As a Sword - Blade Fast Cut_01.ogg");
        yield return _gameMethods.OpenDialog(6758); // "锵！"
        yield return _gameMethods.OpenDialog(6759); // "龙鳞被撞击的声音。"
        yield return _gameMethods.PlaySound("sounda1", 0.0f, 2.0f, "audio/sound/juezhan2/Multi Slash Fast_2.mp3");
        yield return _gameMethods.OpenDialog(2444); // "锵锵！！"
        yield return _gameMethods.PlaySound("sounda2", 0.0f, 2.0f, "audio/sound/juezhan2/Multi Slash Fast_5.mp3");
        yield return _gameMethods.OpenDialog(6760); // "锵锵锵锵锵！！！"
        yield return _gameMethods.OpenDialog(6761); // "瞬息之间，八剑结束，龙鳞破碎，金属声消失。"
        yield return _gameMethods.Scene("juezhan2_cg2_ditu", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"zoom", 1.12f}, {"anchor", new Vector2(0.5f, 0.5f)}, {"zpos", 0.0f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-348.0f, -234.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 162.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.55f}, {"zpos", 20.0f}})});
        yield return _gameMethods.Show("juezhan2_cg2_shou", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"xpos", -378.0f}, {"anchor", new Vector2(0.5f, 0.5f)}, {"zpos", 100.0f}})});
        yield return _gameMethods.Show("juezhan2_cg2_xue", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 0.5f)}, {"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-20.0f, 0.0f)}, {"yrotate", -6.0f}, {"rotate", 186.0f}, {"zoom", 1.18f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.55f}, {"pos", new Vector2(0.0f, 0.0f)}, {"yrotate", 0.0f}, {"rotate", 0.0f}, {"zoom", 1.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.14f}, {"alpha", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.14f}, {"alpha", 1.0f}, {"parallel_1", true}})});
        yield return _gameMethods.Show("juezhan2_cg2_xue1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 0.5f)}, {"zpos", 200.0f}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(0.0f, 0.0f)}, {"yrotate", -6.0f}, {"rotate", 186.0f}, {"zoom", 1.18f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.55f}, {"pos", new Vector2(0.0f, 0.0f)}, {"yrotate", 0.0f}, {"rotate", 0.0f}, {"zoom", 1.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.14f}, {"alpha", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.14f}, {"alpha", 1.0f}, {"parallel_1", true}})});
        yield return _gameMethods.PlaySound("sounda2", 0.0f, 2.5f, "audio/sound/juezhan2/Spraying Blood_01.mp3");
        yield return _gameMethods.StopEngineTime(time:0.3f);
        yield return _gameMethods.Show("juezhan2_cg2_xue", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(0.0f, 0.0f)}, {"yrotate", 0.0f}, {"rotate", 0.0f}, {"zoom", 1.0f}, {"alpha", 1.0f}})});
        yield return _gameMethods.Show("juezhan2_cg2_xue1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(0.0f, 0.0f)}, {"yrotate", 0.0f}, {"rotate", 0.0f}, {"zoom", 1.0f}, {"alpha", 1.0f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", -348.0f}, {"zpos", 20.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.55f}, {"xpos", -726.0f}})});
        yield return _gameMethods.Show("juezhan2_cg2_shou", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"ypos", 162.0f}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", -378.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.22f}, {"xpos", -378.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.33f}, {"xpos", -48.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"rotate", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.55f}, {"rotate", 120.0f}, {"parallel_1", true}})});
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/juezhan2/Hand Cut_01.mp3");
        yield return _gameMethods.TransitionWithFadeIn(outTime:0.1f, holdTime:0.1f, inTime:0.1f, colorCode:"#E3170D");
        yield return _gameMethods.OpenDialog(6762); // "然后，第九剑，光影四起。"
        yield return _gameMethods.OpenDialog(6763); // "瞬间看不清发生了什么。"
        yield return _gameMethods.PlaySound("sounda", 0.0f, 5.0f, "audio/sound/juezhan2/One Step Leave_01.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", -726.0f}})});
        yield return _gameMethods.Show("juezhan2_cg2_shou", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-48.0f, 162.0f)}, {"rotate", 120.0f}})});
        yield return _gameMethods.PlaySound("sounda2", 0.0f, 1.0f, "audio/sound/houhui/Bones Break Cracking_01.ogg");
        yield return _gameMethods.PlaySound("sounda6", 0.0f, 6.0f, "audio/sound/juezhan_dao/HeartBeat One Shot_01.mp3");
        yield return _gameMethods.OpenDialog(6764); // "稍显吃力的赫泽尔瞬间判断不清状况，愣住了片刻，调..."
        yield return _gameMethods.PlaySound("sounda4", 0.0f, 5.0f, "audio/sound/emeng_dajie/Swing Whoosh_01.mp3");
        yield return _gameMethods.Scene("juezhan2_cg3", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 0.67f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.3f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.33f}, {"zpos", -130.0f}})});
        yield return _gameMethods.TransitionBy("pushmove_pushleft");
        yield return _gameMethods.PlaySound("sounda", 0.0f, 2.5f, "audio/sound/juezhan2/Drawing Sword Dagger Scrape _01.ogg");
        yield return _gameMethods.PlaySound("sounda1", 0.0f, 2.0f, "audio/sound/juezhan2/Blade Stab Cut Body Blood_01.ogg");
        yield return _gameMethods.OpenDialog(6765); // "——然而，比那更快，他被安德鲁抵住胸口。{nw}..."
        yield return _gameMethods.Scene("juezhan2_cg4", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}, {"anchor", new Vector2(0.5f, 0.5f)}, {"pos", new Vector2(0.5f, 0.5f)}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.7f}, {"zoom", 0.67f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}})});
        yield return _gameMethods.PlaySound("sounda5", 0.0f, 0.7f, "audio/sound/he/jitui.ogg");
        yield return _gameMethods.TransitionWithFadeIn(outTime:0.2f, holdTime:0.1f, inTime:0.2f, colorCode:"#fff");
        yield return _gameMethods.OpenDialog(6766); // "接着，便在勇者使出全力的迅猛冲刺下，被右手手肘顶..."
        yield return _gameMethods.Scene("juezhan2_cg5_ditu", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 0.5f)}, {"pos", new Vector2(0.5f, 0.5f)}, {"zpos", 0.0f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(0.0f, -318.0f)}, {"zpos", -270.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Show("juezhan2_cg5_ren1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 0.5f)}, {"pos", new Vector2(0.5f, 0.5f)}, {"zpos", 0.0f}})});
        yield return _gameMethods.Show("2-35_zoom");
        yield return _gameMethods.Hide("2-35_zoom");
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.6f, "audio/sound/juezhan2/Body Slam_01.ogg");
        yield return _gameMethods.TransitionBy("shake"); // Shake(0, 0, 0, 0, 0.7, dist=15)
        yield return _gameMethods.OpenDialog(6767); // "最终被压制在身后一面岩石壁上，{nw}{w=0...."
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -318.0f}, {"zpos", -270.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 1.0f}, {"ypos", -270.0f}, {"zpos", 144.0f}})});
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/juezhan2/Wall Crash_01.ogg");
        yield return _gameMethods.OpenDialog(6768); // "以他为中心，巨大的冲击力在石壁上裂开了一面蜘蛛网..."
        yield return _gameMethods.PlaySound("sounda", 0.0f, 2.5f, "audio/sound/juezhan2/Drawing Sword Dagger Scrape _01.ogg");
        yield return _gameMethods.OpenDialog(6769); // "安德鲁保持压制姿态。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 2.0f, "audio/sound/emeng_dajie/magic1.ogg");
        yield return _gameMethods.PlaySound("sounda2", 0.0f, 0.4f, "audio/sound/end/reflection.mp3");
        yield return _gameMethods.PlaySound("sounda4", 0.0f, 0.4f, "<silence 0.5>audio/sound/end/reflection.mp3");
        yield return _gameMethods.PlaySound("sounda5", 0.0f, 0.2f, "<silence 1>audio/sound/end/reflection.mp3");
        yield return _gameMethods.PlaySound("sounda6", 0.0f, 0.2f, "<silence 1.1>audio/sound/end/reflection.mp3");
        yield return _gameMethods.PlaySound("sounda1", 0.0f, 2.0f, "<silence 1>audio/sound/juezhan2/Magical Blast_01.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}, {"ypos", -270.0f}, {"zpos", 144.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.3f}, {"xpos", 486.0f}})});
        yield return _gameMethods.Show("juezhan2_cg5_ding", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 0.5f)}, {"pos", new Vector2(0.5f, 0.5f)}, {"zpos", 0.0f}, {"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.2f}, {"alpha", 1.0f}})});
        yield return _gameMethods.Show("juezhan2_cg5_quan_r", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 0.5f)}, {"pos", new Vector2(0.5f, 0.5f)}, {"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.2f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.1f}, {"alpha", 1.0f}})});
        yield return _gameMethods.StopEngineTime(time:0.4f);
        yield return _gameMethods.Show("juezhan2_cg5_ding", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        yield return _gameMethods.Show("juezhan2_cg5_quan_r", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(486.0f, -270.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.4f}, {"pos", new Vector2(-390.0f, -66.0f)}})});
        yield return _gameMethods.Show("juezhan2_cg5_quan_l", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 0.5f)}, {"pos", new Vector2(0.5f, 0.5f)}, {"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.1f}, {"alpha", 1.0f}})});
        yield return _gameMethods.StopEngineTime(time:0.3f);
        yield return _gameMethods.Show("juezhan2_cg5_quan_l", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(6.0f, 18.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 378.0f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.3f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.63f}, {"zpos", 756.0f}})});
        yield return _gameMethods.TransitionWithFadeIn(outTime:0.2f, holdTime:0.2f, inTime:0.8f, colorCode:"#fff");
        yield return _gameMethods.OpenDialog(6770); // "洛恩的魔法阵紧接其上，四个淡紫色的法阵封锁住了黑..."
        yield return _gameMethods.PlaySound("sounda6", 0.0f, 1.0f, "audio/sound/he/fumo.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 756.0f}})});
        yield return _gameMethods.OpenDialog(6771); // "从安德鲁的体内涌出金色的魔力，顺着左手手臂蜿蜒而..."
        yield return _gameMethods.PlaySound("sounda2", 0.0f, 1.5f, "audio/sound/juezhan2/Magic Broken 2_01.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 6.0f}, {"zpos", 756.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.58f}, {"xpos", -612.0f}, {"zpos", -12.0f}})});
        yield return _gameMethods.Hide("juezhan2_cg5_quan_l");
        yield return _gameMethods.Show("juezhan2_cg5_quan_l_1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 0.5f)}, {"pos", new Vector2(0.5f, 0.5f)}}), new SameLineParamData(new Dictionary<string, object>{{"matrixcolor", "InvertMatrix(0.0)*ContrastMatrix(1.0)*SaturationMatrix(1.0)*BrightnessMatrix(0.11)*HueMatrix(0.0)"}, {"alpha", 0.84f}, {"additive", 1.3f}})});
        yield return _gameMethods.TransitionBy("shake"); // Shake(0, 0, 0, 0, 1.0, dist=15)
        yield return _gameMethods.OpenDialog(6772); // "赫泽尔费力挣扎，从法阵中挣脱出一只手。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -12.0f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.3f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.31f}, {"zpos", -214.0f}, {"xpos", -768.0f}})});
        yield return _gameMethods.PlaySound("sounda5", 0.0f, 2.0f, "audio/sound/emeng_dajie/magic1.ogg");
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/juezhan2/ICE EX_01.mp3");
        yield return _gameMethods.Show("juezhan2_cg5_quan_l_1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pause", 0.3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.3f}, {"alpha", 0.0f}})});
        yield return _gameMethods.Show("juezhan2_cg5_ren2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 0.5f)}, {"pos", new Vector2(0.5f, 0.5f)}, {"zpos", 0.0f}})});
        yield return _gameMethods.TransitionWithFadeIn(outTime:0.1f, holdTime:0.1f, inTime:0.1f, colorCode:"#fff");
        yield return _gameMethods.TransitionBy("shake"); // Shake(0, 0, 0, 0, 0.4, dist=5)
        yield return _gameMethods.OpenDialog(6773); // "下一秒被诺伯拉又一次冻在石壁上。"
        yield return _gameMethods.PlaySound("sounda4", 0.0f, 1.0f, "<silence 0.3>audio/sound/houhui/Bones Break Cracking_01.ogg");
        yield return _gameMethods.PlaySound("sounda", 0.0f, 2.0f, "audio/sound/juezhan2/Drawing Sword Dagger Scrape _01.ogg");
        yield return _gameMethods.SceneWhite();
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(6774); // "安德鲁以左手食指对准赫泽尔的胸腔，用魔力阻止他行..."
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.7f, "audio/sound/juezhan2/Magic Broken_01.ogg");
        yield return _gameMethods.OpenDialog(6775); // "啪！啪！咔！"
        yield return _gameMethods.OpenDialog(6776); // "两道法阵、一块坚冰被接连破开。"
        yield return _gameMethods.OpenDialog(6777); // "洛恩和诺伯拉再度施法，封住他的四肢，{nw}{w..."
        yield return _gameMethods.Show("juezhan2_cg7", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 0.5f)}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(0.26f, 0.05f)}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.61f}, {"pos", new Vector2(0.04f, 0.05f)}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.1f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}, {"parallel_1", true}})});
        yield return _gameMethods.Show("red", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"alpha", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.1f}, {"alpha", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"alpha", 0.0f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.PlaySound("sounda6", 0.0f, 6.0f, "audio/sound/juezhan_dao/HeartBeat One Shot_01.mp3");
        yield return _gameMethods.OpenDialog(6778); // "却遗漏下一只手臂来不及封锁。"
        yield return _gameMethods.Hide("red");
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/juezhan2/Riser Into Suck Back _01.ogg");
        yield return _gameMethods.Scene("juezhan2_cg7", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 0.5f)}, {"pos", new Vector2(0.5f, 0.5f)}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 174.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 3.4f}, {"zpos", 708.0f}})});
        yield return _gameMethods.Show("2-36_zoom");
        yield return _gameMethods.Hide("2-36_zoom");
        yield return _gameMethods.Transition(time:1.7f);
        yield return _gameMethods.OpenDialog(6779); // "赫泽尔的右臂变形为利爪，试图反击。"
        yield return _gameMethods.OpenDialog(6780); // "…………！！！"
        yield return _gameMethods.OpenDialog(6781); // "事到如今，一切的准备，所有的努力，全部的贡献，都..."
        yield return _gameMethods.OpenDialog(6782); // "难道要让它付之东流吗？"
        yield return _gameMethods.OpenSelectMenu(
            talk: new List<string>{"-出手"},
            jump: new List<string>{"label_tuanzhan_you_menu_0_chushou"},
            condition: new List<string>{"NONE"}
        );
    }

    public IEnumerator label_end3_1_tuan3()
    {
        yield return _gameMethods.OpenDialog(6788); // "顷刻间。"
        yield return _gameMethods.SceneWhite();
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Transition(time:0.3f);
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/juezhan2/Huge Explosion_01.ogg");
        yield return _gameMethods.OpenDialog(6789); // "轰隆————！！！！！"
        yield return _gameMethods.OpenDialog(6790); // "仿佛水面长久以来平衡稳定的状态被打破，气流与风浪..."
        yield return _gameMethods.OpenDialog(6791); // "气流与风浪席卷整片草原。"
        yield return _gameMethods.OpenDialog(6792); // "我蹲下，紧紧抓着地面，睁不开眼。"
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.StopSound(channelName:"sounda", fadeOut:2.0f);
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.OpenDialog(6793); // "…………………"
        yield return _gameMethods.OpenDialog(6794); // "等到风波停息，我重新站立。"
        yield return _gameMethods.Scene("caodi2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 0.5f)}, {"xpos", 0.5f}, {"ypos", 0.5f}, {"zoom", 0.5f}})});
        Defaults.Gui_duihuakuang_you = 1;
        yield return _gameMethods.Transition(time:0.6f);
        yield return _gameMethods.OpenDialog(6795); // "空旷的草原上，无力的赫泽尔躺在一边，他选择主动沉..."
        yield return _gameMethods.OpenDialog(6796); // "离得较远的洛恩看起来未受波及。"
        yield return _gameMethods.OpenDialog(6797); // "安德鲁……则倒在另一侧。"
        yield return _gameMethods.PlaySound("soundb", 0.0f, 2.0f, "audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}})});
        yield return _gameMethods.Transition(time:0.3f);
        yield return _gameMethods.OpenDialog(6798); // "我走向安德鲁。"
        yield return _gameMethods.Scene("caodi2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(1.55f, 1.16f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 2.01f}})});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan2", "zui3", "emoji8", "emoji9", "emoji14", "xue"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.46f, 4.07f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.69f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 156.0f}}), new SameLineParamData(new Dictionary<string, object>{{"matrixcolor", "InvertMatrix(0.0)*ContrastMatrix(1.0)*SaturationMatrix(1.0)*BrightnessMatrix(-0.03)*HueMatrix(0.0)"}})});
        yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:1.0f);
        yield return _gameMethods.PlaySound("music", 0.0f, 0.6f, "audio/music/yongzhe_gandong.mp3");
        yield return _gameMethods.Transition(time:0.6f);
        yield return _gameMethods.OpenDialog(6799); // "他虚弱地躺在草地上，动弹不得，{nw}{w=0...."
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan23", "zui3", "emoji8", "emoji9", "emoji14"});
        yield return _gameMethods.OpenDialog(6800); // "\n额头流下的汗糊住了半边眼睛。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei4", "yan12", "zui2", "emoji8", "emoji9", "emoji14"});
        yield return _gameMethods.OpenDialog(6801); // "见到我，{nw}{w=0.01}"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan23", "zui2", "emoji8", "emoji9", "emoji14", "emoji20"});
        yield return _gameMethods.OpenDialog(6802); // "少年艰难地用手背擦掉了眼睛四周的汗水，"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei4", "yan3", "zui16", "emoji8", "emoji9", "emoji14", "emoji20"});
        yield return _gameMethods.OpenDialog(6803); // "对我露出一个无力的微笑。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei4", "yan12", "zui13", "emoji8", "emoji9", "emoji14", "emoji20"});
        yield return _gameMethods.OpenDialog(6804); // "……结束了？"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei4", "yan12", "zui16", "emoji8", "emoji9", "emoji14", "emoji20"});
        yield return _gameMethods.OpenDialog(6805); // "结束了。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei4", "yan23", "zui16"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan2", "zui1"});
        yield return _gameMethods.OpenDialog(6806); // "他从胸腔里呼出了深深的一口气，{nw}{w=0...."
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan2", "zui3"});
        yield return _gameMethods.OpenDialog(6807); // "又移动了一下脸上的手臂，遮住全部双眼。"
        yield return _gameMethods.OpenDialog(6808); // "手腕之下，露出的那张嘴巴开合。嗓音沙哑。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei6", "yan23", "zui12"});
        yield return _gameMethods.OpenDialog(6809); // "我真的很努力了……公主大人。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei6", "yan23", "zui16"});
        yield return _gameMethods.OpenDialog(765); // "嗯。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei7", "yan2", "zui13"});
        yield return _gameMethods.OpenDialog(6810); // "可以给我一句夸奖，一点鼓励吗？"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei7", "yan2", "zui16"});
        yield return _gameMethods.OpenDialog(1841); // "……好。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"easein", 2.0f}, {"zpos", 0.0f}})});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei7", "yan23", "zui16"});
        yield return _gameMethods.OpenDialog(6811); // "我屈膝，跪坐到他身侧，\n拿开了他遮挡脸庞的那只..."
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei4", "yan12", "zui1"});
        yield return _gameMethods.OpenDialog(6812); // "他猝不及防，有些意外而无措地望着我，"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei4", "yan13", "zui2"});
        yield return _gameMethods.OpenDialog(6813); // "随即不自在地飘闪开视线。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}})});
        yield return _gameMethods.Show("black");
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan23", "zui16"});
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/houhui/Grab Hand_01.mp3");
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(6814); // "不待他掩饰性地挂起狼狈的笑容，我俯下身体，轻轻地..."
        yield return _gameMethods.Hide("black");
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei4", "yan11", "zui1", "-emoji14"});
        Defaults.Haogandu_an = Defaults.Haogandu_an + 1;
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.OpenDialog(6815); // "少年的神情定格，{nw}{w=0.1}"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei4", "yan1", "zui1"});
        yield return _gameMethods.OpenDialog(6816); // "翠绿双瞳在惊讶中逐渐睁大。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"matrixcolor", "InvertMatrix(0.0)*ContrastMatrix(1.0)*SaturationMatrix(1.0)*BrightnessMatrix(-0.03)*HueMatrix(0.0)"}}), new SameLineParamData(new Dictionary<string, object>{{"matrixcolor", "InvertMatrix(0.0)*ContrastMatrix(1.0)*SaturationMatrix(1.0)*BrightnessMatrix(0.02)*HueMatrix(0.0)"}, {"linear", 0.66f}})});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei4", "yan8", "zui1"});
        yield return _gameMethods.OpenDialog(6817); // "我跪坐低着头，在很近的距离里同他双目对视。"
        yield return _gameMethods.OpenDialog(6818); // "耳边垂下的发梢扫到他的脸颊边，晨曦的微光中，一切..."
        yield return _gameMethods.OpenDialog(6819); // "我轻声说。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei1", "yan5", "zui19", "d3"});
        yield return _gameMethods.OpenDialog(6820); // "谢谢你，勇者。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei4", "yan1", "zui1"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei4", "yan8", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei1", "yan12", "zui19"});
        yield return _gameMethods.OpenDialog(6821); // "你将世界从可能的危机中拯救了出来。"
        Defaults.Haogandu_an = Defaults.Haogandu_an + 2;
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"matrixcolor", "InvertMatrix(0.0)*ContrastMatrix(1.0)*SaturationMatrix(1.0)*BrightnessMatrix(0.02)*HueMatrix(0.0)"}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei1", "yan17", "zui20"});
        yield return _gameMethods.OpenDialog(6822); // "我代表一切生灵，向你表达感激与敬意。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei5", "yan1", "zui1", "emoji12", "emoji20"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei1", "yan17", "zui7"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei4", "yan8", "zui1", "emoji11"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(6823); // "霎时间，他的瞳孔微微颤抖起来。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei4", "yan15", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(6824); // "眼睛似有似无地潮湿了，{nw}{w=0.01}"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan15", "zui3"});
        yield return _gameMethods.OpenDialog(6825); // "他抿了下嘴唇，"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei10", "yan2", "zui3"});
        yield return _gameMethods.OpenDialog(6826); // "竭力克制压下了些什么一般，{nw}{w=0.3}"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan19", "zui10"});
        yield return _gameMethods.OpenDialog(6827); // "露出一个勉强而拙劣的笑容。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan23", "zui13"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian", parts: new List<string>{"mei1", "yan12", "zui7"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian", parts: new List<string>{"mei1", "yan17", "zui7"});
        yield return _gameMethods.OpenDialog(6828); // "「…………只要公主大人还在我身边，{nw}{w=..."
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei3", "yan2", "zui13"});
        yield return _gameMethods.OpenDialog(6829); // "我就能够永远战斗下去，{nw}{w=0.01}"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei4", "yan23", "zui13"});
        yield return _gameMethods.OpenDialog(6830); // "无论多少遍。」"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei4", "yan23", "zui16"});
        yield return _gameMethods.ExecuteCharacterImageData("luo_nv_weizhi", parts: new List<string>{"mei1", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(6831); // "——我也能够永远战斗下去，公主大人。"
        yield return _gameMethods.StopSound(channelName:"music", fadeOut:4.0f);
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/manbu/Air Magic Gust of Wind_02.ogg");
        yield return _gameMethods.OpenDialog(6832); // "一个治愈法术从我背后冒出，撞在安德鲁酸痛的左肩。"
        yield return _gameMethods.SceneBlack();
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/houhui/Tight Face_02_duan.mp3");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"matrixcolor", "InvertMatrix(0.0)*ContrastMatrix(1.0)*SaturationMatrix(1.0)*BrightnessMatrix(0.0)*HueMatrix(0.0)"}})});
        yield return _gameMethods.Transition(time:0.3f);
        yield return _gameMethods.OpenDialog(6833); // "接着，一双手落到我的肩膀上，温和中带着强硬地把我..."
        yield return _gameMethods.PlaySound("music1", 0.0f, 0.6f, "audio/music/yongzhe_kaixin.mp3");
        yield return _gameMethods.Scene("caodi2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.75f, 1.28f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 1.18f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.0f, 0.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1.0f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 30.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.7f}, {"yoffset", 0.0f}})});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei4", "yan8", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 10.0f}, {"pos", new Vector2(600.0f, 1610.0f)}, {"zoom", 0.37f}})});
        yield return _gameMethods.Transition(time:0.3f);
        yield return _gameMethods.OpenDialog(6834); // "洛恩阴阳怪气地说。"
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei4", "yan5", "zui12"});
        yield return _gameMethods.OpenDialog(6835); // "你可不能厚此薄彼啊。"
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei4", "yan5", "zui8"});
        yield return _gameMethods.OpenDialog(6836); // "……你！？"
        yield return _gameMethods.PlaySound("sound", 0.0f, 4.0f, "<silence 0.2>audio/sound/manbu/Body1_02_duan.mp3");
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<from 0 to 0.5>audio/sound/emeng_dajie/walking_on_the_earth_01.mp3");
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei8", "yan9", "zui1"});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei8", "yan1", "zui5", "-emoji12", "-emoji20", "-emoji11"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 10.0f}, {"pos", new Vector2(1014.0f, 1632.0f)}, {"zoom", 0.37f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0.0f}, {"yoffset", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.3f}, {"xpos", 174.0f}})});
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.OpenDialog(6837); // "安德鲁愕然片刻，一个鲤鱼打挺、猛然坐起。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei8", "yan8", "zui1"});
        yield return _gameMethods.OpenDialog(6838); // "他目瞪口呆，张口结舌地盯着洛恩。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 174.0f}})});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei5", "yan11", "zui15", "emoji3", "emoji5"});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei8", "yan12", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("luo_qian");
        yield return _gameMethods.OpenDialog(6839); // "「嘘。忘了你身上的诅咒了吗，{nw}{w=0.3..."
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei5", "yan8", "zui15", "emoji3", "emoji5"});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan4", "zui1"});
        yield return _gameMethods.OpenDialog(6840); // "如果你感到幸福，就麻烦了。」"
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei5", "yan8", "zui9", "emoji3", "emoji5"});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan1", "zui1"});
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei10", "yan4", "zui8", "emoji8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"xoffset", -3.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 3.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0.0f}, {"parallel_1", true}})});
        yield return _gameMethods.PlaySound("sounda2", 0.0f, 0.4f, "audio/sound/moca1.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("an_qian");
        yield return _gameMethods.OpenDialog(6841); // "「不好，{nw}{w=0.01}"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei10", "yan3", "zui8"});
        yield return _gameMethods.OpenDialog(6842); // "我已经——……！」"
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/emeng_dajie/magic1.ogg");
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei10", "yan3", "zui3", "emoji8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"yoffset", 0.0f}})});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei5", "yan1", "zui1", "emoji2"});
        yield return _gameMethods.ExecuteCharacterImageData("yao_weizhi");
        yield return _gameMethods.OpenDialog(6843); // "我来收取我的报酬了。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 2.0f, "audio/sound/emeng_dajie/Swing Whoosh_01.mp3");
        yield return _gameMethods.Show("npc_yaojingshangren", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(1578.0f, 950.0f)}, {"zoom", 1.23f}, {"zpos", 10.0f}, {"alpha", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.3f}, {"alpha", 1.0f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 174.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.39f}, {"xpos", 786.0f}})});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei10", "yan8", "zui3"});
        yield return _gameMethods.OpenDialog(6844); // "哎呀，要被带走的就是这位公主殿下吗？"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan10", "zui3"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan24", "zui10", "emoji12", "d3"});
        yield return _gameMethods.OpenDialog(6845); // "我的脑门上难道刻着公主两个字？"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 786.0f}})});
        yield return _gameMethods.Show("npc_yaojingshangren", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1.0f}})});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan14", "zui4"});
        yield return _gameMethods.ExecuteCharacterImageData("yao_nv", parts: new List<string>{"mei8", "yan24", "zui15", "-emoji12"});
        yield return _gameMethods.OpenDialog(6846); // "当然不是。我们……很多存在，都在关注着这场战斗的..."
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan8", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(6847); // "您真是消息灵通，不愧是商人。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan10", "zui1", "-emoji8"});
        yield return _gameMethods.ExecuteCharacterImageData("yao_nv", parts: new List<string>{"mei8", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(6848); // "多谢赞美。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei8", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(6849); // "「不知道您对交易对象有没有筛选，{nw}{w=0..."
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei8", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(6850); // "我也想和你做个交易。」"
        yield return _gameMethods.ExecuteCharacterImageData("yao_nv", parts: new List<string>{"mei8", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(6851); // "那可不行。你已经成为我的战利品了。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei5", "yan6", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei10", "yan23", "zui2"});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"xpos", 426.0f}})});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei4", "yan10", "zui3", "emoji3", "emoji5"});
        yield return _gameMethods.TransitionBy("blink2");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan10", "zui14"});
        yield return _gameMethods.OpenDialog(6852); // "我默默地望向了安德鲁。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan2", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(6853); // "他把脸埋进了手掌里。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan17", "zui8", "emoji2", "emoji4"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
        yield return _gameMethods.OpenDialog(6854); // "「……谁能想到会有那种、{nw}{w=0.01}"
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/moca1.ogg");
        yield return _gameMethods.Show("an2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"xoffset", -3.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 3.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0.0f}, {"parallel_1", true}})});
        yield return _gameMethods.OpenDialog(6855); // "那种突然袭击啊……！」"
        yield return _gameMethods.Show("an2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"yoffset", 0.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei8", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei2", "yan5", "zui1"});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan2", "zui8", "-emoji4"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv_qian");
        yield return _gameMethods.OpenDialog(6856); // "「可恶、再做场交换，{nw}{w=0.01}"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei10", "yan8", "zui4"});
        yield return _gameMethods.OpenDialog(6857); // "让这家伙直接带走我吧。」"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei10", "yan8", "zui1"});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.35f}, {"zpos", -24.0f}})});
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<from 0.3 to 0.5>audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei4", "yan12", "zui12", "emoji2"});
        yield return _gameMethods.OpenDialog(6858); // "「你等等。{nw}{w=0.01}"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -24.0f}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0.0f}, {"parallel_1", true}})});
        Defaults.Haogandu_an = Defaults.Haogandu_an + 1;
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei4", "yan22", "zui12", "emoji2"});
        yield return _gameMethods.OpenDialog(6859); // "不行！」"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"yoffset", 0.0f}})});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei10", "yan12", "zui1"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei4", "yan6", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan8", "zui15", "emoji2"});
        yield return _gameMethods.OpenDialog(6860); // "……还有办法、一定还有办法的。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei10", "yan23", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan12", "zui15", "-emoji2"});
        yield return _gameMethods.OpenDialog(6861); // "冷静一点。必须思考出来。"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei10", "yan2", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(6862); // "我还有什么东西能拿出去交换……"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei7", "yan23", "zui2"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei3", "yan21", "zui15"});
        yield return _gameMethods.OpenDialog(6863); // "在连自己都不属于自己的情况下。"
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei4", "yan12", "zui1"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.PlaySound("sounda1", 0.0f, 0.6f, "audio/sound/emeng_dajie/Magic Spell Book Pages Flipping_01.ogg");
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei4", "yan6", "zui1"});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan9", "zui15"});
        yield return _gameMethods.OpenDialog(6864); // "………………有了。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(6865); // "我的身份。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(6866); // "有些利益，现在的我身上绝对没有，但在未来却会有。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(936.0f, -24.0f)}, {"zpos", -168.0f}})});
        yield return _gameMethods.TransitionBy("blink2");
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(6867); // "您既然是商人，就一定很明白放长线钓大鱼的道理吧。"
        yield return _gameMethods.ExecuteCharacterImageData("yao_nv", parts: new List<string>{"mei7", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(6868); // "不愧是战胜了灾厄之龙的公主殿下，实在通透。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui19"});
        yield return _gameMethods.OpenDialog(6869); // "那么，不妨再晚点来接我如何。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0.5 to 1.5>audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -168.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.8f}, {"zpos", -186.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui3"});
        yield return _gameMethods.OpenDialog(6870); // "你应该知道，我拥有国王的血脉，换句话说，是合理合..."
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan6", "zui2"});
        yield return _gameMethods.OpenDialog(6871); // "勇者刚刚战胜了巨龙，而我也阻拦了灾厄纪元的到来。"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan12", "zui19"});
        yield return _gameMethods.OpenDialog(6872); // "只要经营得当，我的声望会达到顶峰，将有很大机会继..."
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -186.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui3"});
        yield return _gameMethods.OpenDialog(6873); // "到那时，你会有更大的利益可图，不是吗？"
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui2"});
        yield return _gameMethods.OpenDialog(6874); // "现在就还请高抬贵手吧。"
        yield return _gameMethods.ExecuteCharacterImageData("yao_nv", parts: new List<string>{"mei7", "yan2", "zui8"});
        yield return _gameMethods.OpenDialog(6875); // "不，您不明白，公主大人。"
        yield return _gameMethods.PlaySound("sounda", 0.0f, 0.7f, "<from 0.5 to 1.5>audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
        yield return _gameMethods.Show("npc_yaojingshangren", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 10.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.8f}, {"zpos", 26.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("yao_nv");
        yield return _gameMethods.OpenDialog(6876); // "整个人类国度的价值，根本不算什么。"
        yield return _gameMethods.ExecuteCharacterImageData("yao_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(6877); // "钱粮？声誉？地位？"
        yield return _gameMethods.Show("npc_yaojingshangren", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 26.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("yao_nv");
        yield return _gameMethods.OpenDialog(6878); // "这些一文不值，完全无法与您相提并论。"
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan12", "zui15"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan18", "zui15"});
        yield return _gameMethods.OpenDialog(6879); // "这个我真的想不到。"
        yield return _gameMethods.ExecuteCharacterImageData("yao_nv");
        yield return _gameMethods.OpenDialog(6880); // "除非有同等价值的东西，否则我不会接受。"
        yield return _gameMethods.PlaySound("sounda1", 0.0f, 1.0f, "audio/sound/emeng_dajie/magic1.ogg");
        yield return _gameMethods.PlaySound("sounda2", 0.0f, 1.0f, "<silence 0.6><from 0.3 to 0.5>audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(6881); // "嗯？都在这里做什么呢~"
        yield return _gameMethods.Hide("npc_yaojingshangren");
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 16.0f}, {"pos", new Vector2(1866.0f, 1716.0f)}, {"zoom", 0.51f}})});
        yield return _gameMethods.Show("npc_yaojingshangren", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 16.0f}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(1578.0f, 950.0f)}, {"zoom", 1.23f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(1200.0f, 12.0f)}, {"zpos", 200.0f}})});
        yield return _gameMethods.TransitionBy("blink2");
        yield return _gameMethods.ExecuteCharacterImageData("yao_nv", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(6882); // "啊呀，居然是冰龙阁下。"
        yield return _gameMethods.ExecuteCharacterImageData("yao_nv");
        yield return _gameMethods.OpenDialog(6883); // "是什么竟能令您大驾光临？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6884); // "「当然是为了我可爱的朋友。{nw}{w=0.01..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui14"});
        yield return _gameMethods.OpenDialog(6885); // "人类的公主殿下。」"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 1200.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.8f}, {"xpos", 966.0f}})});
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei8", "yan1", "zui9", "emoji21"});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv");
        yield return _gameMethods.OpenDialog(6886); // "…？？？"
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei8", "yan1", "zui1", "-emoji21"});
        yield return _gameMethods.ExecuteCharacterImageData("yao_nv", parts: new List<string>{"mei8", "yan24", "zui16", "emoji2"});
        yield return _gameMethods.OpenDialog(6887); // "很可惜，这位在刚刚已经成为了我要收取的报酬。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui6"});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei10", "yan23", "zui3", "emoji20"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei8", "yan24", "zui16", "-emoji2"});
        yield return _gameMethods.OpenDialog(6888); // "「啊——{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan14", "zui13"});
        yield return _gameMethods.OpenDialog(6889); // "这就伤脑筋了。」"
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6890); // "「不好意思，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui16"});
        yield return _gameMethods.OpenDialog(6891); // "我可不能让你把她带走。{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui17"});
        yield return _gameMethods.OpenDialog(6892); // "因为我们之间还有约定呢。」"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 966.0f}})});
        yield return _gameMethods.OpenSelectMenu(
            talk: new List<string>{"-什么约定？"},
            jump: new List<string>{"label_tuanzhan_you_menu_1_shenmeyueding"},
            condition: new List<string>{"NONE"}
        );
    }

    public IEnumerator label_end3_1_tuan1()
    {
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei5", "yan8", "zui1", "-emoji20"});
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei8", "yan5", "zui10", "emoji12"});
        yield return _gameMethods.OpenDialog(6894); // "什么约定？ "
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei8", "yan5", "zui15", "-emoji12"});
        yield return _gameMethods.OpenDialog(6895); // "忘了吗？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui16"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6896); // "「你说要报答我，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui3"});
        yield return _gameMethods.OpenDialog(6897); // "还要给我一个热情阳光、真挚诚恳的感谢呢。」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei2", "yan1", "zui1"});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan1", "zui2"});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 966.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein_circ", 0.3f}, {"xpos", 594.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("an_nv", parts: new List<string>{"mei8", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(6898); // "？！？！"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 594.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein_cubic", 1.0f}, {"xpos", 384.0f}})});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei2", "yan8", "zui1", "emoji3"});
        yield return _gameMethods.ExecuteCharacterImageData("luo_nv");
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan10", "zui8", "emoji2"});
        yield return _gameMethods.OpenDialog(6899); // "我很确定他添了很多油加醋。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei6", "yan7", "zui5"});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(1428.0f, -30.0f)}, {"zpos", -46.0f}})});
        yield return _gameMethods.TransitionBy("blink2");
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6900); // "「为什么不承认，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei5", "yan11", "zui5"});
        yield return _gameMethods.OpenDialog(6901); // "难道你是忘了？」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei5", "yan11", "zui9"});
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.OpenDialog(6902); // "你对我的感谢有什么执念。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei11", "yan2", "zui15"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -30.0f}, {"zpos", -46.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.8f}, {"ypos", 96.0f}, {"zpos", -88.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei8", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(6903); // "我没有回答，而是看向他的身后。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 0.5f, "audio/sound/end/Ice_01.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(6904); // "他一直将右手背在腰后，但手上那一大块冻结的冰晶实..."
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 96.0f}, {"zpos", -88.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.31f}, {"ypos", -84.0f}})});
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan2", "zui10"});
        yield return _gameMethods.OpenDialog(6905); // "你的手怎么了？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui9"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(1378); // "「……{nw}{w=0.3}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui8"});
        yield return _gameMethods.OpenDialog(3123); // "……{nw}{w=0.3}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui8"});
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
        yield return _gameMethods.OpenDialog(1265); // "……」"
        yield return _gameMethods.PlaySound("sounda", 0.0f, 0.5f, "audio/sound/end/Ice_02.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai");
        yield return _gameMethods.OpenDialog(6906); // "他神色如常，抖掉了那块冰。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -84.0f}})});
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(6907); // "嗯？不用在意。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui16"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(6908); // "这个世上不存在没有代价的奇迹。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6909); // "「违逆了命运的旨意，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui14"});
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.OpenDialog(6910); // "总要付出点小小的代价。」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan22", "zui19"});
        yield return _gameMethods.OpenDialog(6911); // "“小小的”？"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan22", "zui7"});
        yield return _gameMethods.OpenDialog(765); // "嗯。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui14"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(6912); // "——难道我看起来像是那种无私奉献却不宣扬的类型吗..."
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.68f}, {"ypos", 96.0f}, {"zpos", -88.0f}})});
        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 1;
        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
            _gameMethods.SyncAchievement();
        }
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui10"});
        yield return _gameMethods.OpenDialog(6913); // "你刚刚把手背到了身后。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan2", "zui14"});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 96.0f}, {"zpos", -88.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.31f}, {"ypos", -84.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv", parts: new List<string>{"mei7", "yan5", "zui15"});
        yield return _gameMethods.OpenDialog(6914); // "哎呀，只是因为那看起来一点也不帅气嘛。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv");
        yield return _gameMethods.OpenDialog(6915); // "安心。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui16"});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -84.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("nuo_nv_qian");
        yield return _gameMethods.OpenDialog(6916); // "「如果我做了什么，{nw}{w=0.01}"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui13"});
        yield return _gameMethods.OpenDialog(6917); // "那只说明，你身上有值得这份付出的价值。」"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian", parts: new List<string>{"mei7", "yan2", "zui15"});
        yield return _gameMethods.OpenDialog(1222); // "「……"
        yield return _gameMethods.ExecuteCharacterImageData("", parts: new List<string>{"mei7", "yan12", "zui3", "emoji2"});
        yield return _gameMethods.OpenDialog(6918); // "好吧。」"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.6f}, {"xpos", 1254.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("yao_nv", parts: new List<string>{"mei7", "yan5", "zui7", "-emoji2"});
        yield return _gameMethods.OpenDialog(6919); // "——所以。您们两位是……挚友关系？"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"xpos", 240.0f}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0.0f}, {"parallel_0", true}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1.0f}, {"parallel_1", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0.0f}, {"parallel_1", true}})});
        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei5", "yan11", "zui12", "emoji3"});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei10", "yan4", "zui8", "emoji20", "emoji8"});
        yield return _gameMethods.ExecuteCharacterImageData("an_luo_nv", parts: new List<string>{"mei7", "yan2", "zui7"});
        yield return _gameMethods.OpenDialog(6920); // "不是！！！"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(948.0f, -18.0f)}, {"xoffset", -200.0f}, {"yoffset", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.4f}, {"xoffset", 0.0f}})});
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei11", "yan2", "zui15"});
        yield return _gameMethods.Show("an2", parts: new List<string>{"mei10", "yan4", "zui3", "-emoji20", "-emoji8"});
        yield return _gameMethods.Transition(time:0.5f);
        Engine._history = false;
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei11", "yan11", "zui8"});
        yield return _gameMethods.OpenDialog(6921); // "……好吧。真是扑朔迷离的关系。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei11", "yan10", "zui8"});
        yield return _gameMethods.OpenDialog(6922); // "的确，我也不想同冰霜之龙阁下为敌。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0.0f}})});
        yield return _gameMethods.OpenDialog(6923); // "如果有阁下作保，我可以考虑换成其他条件。"
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -88.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.35f}, {"zpos", -106.0f}})});
        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<from 0.3 to 0.5>audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan5", "zui19"});
        yield return _gameMethods.OpenDialog(6924); // "那开价吧。"
        yield return _gameMethods.OpenDialog(6925); // "换回我自己，和安德鲁卖给你的所有东西，都需要付出..."
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -106.0f}})});
        yield return _gameMethods.ExecuteCharacterImageData("yao_nv", parts: new List<string>{"mei7", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(6926); // "那样的话——价码可不低啊。"
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei11", "yan1", "zui8"});
        Engine._history = false;
        yield return _gameMethods.ExecuteCharacterImageData("nv1_qian");
        yield return _gameMethods.OpenDialog(134); // "{nw}{w=0.15}"
        Engine._history = true;
        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei11", "yan10", "zui8"});
        yield return _gameMethods.ExecuteCharacterImageData("nv1", parts: new List<string>{"mei7", "yan11", "zui19"});
        yield return _gameMethods.OpenDialog(6927); // "但我们总会付得起的，不是吗。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(6928); // "这是双赢。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan8", "zui7"});
        yield return _gameMethods.OpenDialog(6929); // "他会将利益最大化，但仅限于我们的能力范围之内。"
        yield return _gameMethods.ExecuteCharacterImageData("nv_pangbai", parts: new List<string>{"mei7", "yan12", "zui7"});
        yield return _gameMethods.OpenDialog(6930); // "不然生意做不成，他同样捞不到好处。"
        yield return _gameMethods.ExecuteCharacterImageData("yao_nv", parts: new List<string>{"mei7", "yan5", "zui7"});
        yield return _gameMethods.OpenDialog(6931); // "呵呵……当然。"
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0.5 to 1.5>audio/sound/juezhan_dao/Footsteps Sneakers on Grass_01.ogg");
        yield return _gameMethods.Show("npc_yaojingshangren", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 16.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.8f}, {"zpos", 40.0f}})});
        yield return _gameMethods.OpenDialog(6932); // "那么，就让我来向您说明吧——……"
        yield return _gameMethods.StopSound(channelName:"music1", fadeOut:5.0f);
        yield return _gameMethods.Show("npc_yaojingshangren", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 40.0f}})});
        yield return _gameMethods.Show("black", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zoom", 2.0f}, {"anchor", new Vector2(0.5f, 0.5f)}, {"zpos", 40.0f}, {"xpos", 1014.0f}})});
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.OpenDialog(4); // "……"
        yield return _gameMethods.OpenDialog(21); // "…………"
        yield return _gameMethods.PlaySound("music", 0.0f, 0.8f, "audio/music/yongzhe_wenxin1.mp3");
        yield return _gameMethods.Hide("black");
        yield return _gameMethods.Hide("nuo1");
        yield return _gameMethods.Hide("an2");
        yield return _gameMethods.Transition(time:0.4f);
        yield return _gameMethods.ChangeLabelTo("label_fanhuitu");
    }

}
