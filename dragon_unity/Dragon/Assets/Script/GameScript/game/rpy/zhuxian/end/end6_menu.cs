
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class end6_menu : ILabelProvider
{
    private GameMethods _gameMethods;

    public end6_menu(GameMethods gameMethods)
    {
        _gameMethods = gameMethods;
    }
    
    public IEnumerator label_end6_menu_0_1nafPpk1()
    {
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1>audio/sound/jiaobusheng_xin_normal1.ogg");
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.8f}, {"zpos", -18f}})});
                yield return _gameMethods.ExecuteCharacterImageData("nv2");
                yield return _gameMethods.OpenDialog(5113); // "深夜来见实在冒昧，只是兹事重大，还请团长见谅。"
                yield return _gameMethods.ExecuteCharacterImageData("o");
                yield return _gameMethods.OpenDialog(5114); // "公主言重了，这是属下职责所在。"
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -18f}})});
                yield return _gameMethods.ExecuteCharacterImageData("o");
                yield return _gameMethods.OpenDialog(5115); // "请问公主殿下带来了陛下的什么命令？"
                yield return _gameMethods.ExecuteCharacterImageData("nv2");
                yield return _gameMethods.OpenDialog(5116); // "勇者安德鲁、洛恩和我已经战胜了灾厄之龙尼德霍格。"
                yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/zhenjing_shuaidaoganjue.mp3");
                yield return _gameMethods.Show("Assets/RenpyResources/images/lihui/npc/npc_qishi.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"xoffset", -3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0f}})});
                yield return _gameMethods.ExecuteCharacterImageData("o");
                yield return _gameMethods.OpenDialog(5117); // "！"
                yield return _gameMethods.Show("Assets/RenpyResources/images/lihui/npc/npc_qishi.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
                yield return _gameMethods.ExecuteCharacterImageData("nv2");
                yield return _gameMethods.OpenDialog(5118); // "他城堡与财产的规模不可计数，此刻却还荒废在荒郊野岭。"
                yield return _gameMethods.ExecuteCharacterImageData("nv2");
                yield return _gameMethods.OpenDialog(5119); // "国王命我秘密通知您，即刻率骑士团，赶往指定地点，占领城堡，并将财产运回王都。"
                yield return _gameMethods.OpenDialog(5120); // "说完这番话，我便紧紧盯住骑团长的脸，以观察他接下来的神情，寻找蛛丝马迹。"
                yield return _gameMethods.OpenDialog(5121); // "如果他相信了，只要能调开他，也算是暂时剪掉了国王的这只羽翼。"
                yield return _gameMethods.ExecuteCharacterImageData("o");
                yield return _gameMethods.OpenDialog(5122); // "竟然能击败掌握毁灭权柄的灾厄之龙？！"
                yield return _gameMethods.Show("npc_qishi", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.5f}, {"zpos", 12.0f}})});
                yield return _gameMethods.ExecuteCharacterImageData("o");
                yield return _gameMethods.OpenDialog(5123); // "太好了！"
                yield return _gameMethods.OpenDialog(5124); // "团长面色潮红，显然这份喜悦让他情绪激动。"
                yield return _gameMethods.Show("Assets/RenpyResources/images/lihui/npc/npc_qishi.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 12.0f}})});
                yield return _gameMethods.ExecuteCharacterImageData("nv2");
                yield return _gameMethods.OpenDialog(5125); // "是啊，而您是父王唯一能委以这项重任的人选。"
                yield return _gameMethods.OpenDialog(5126); // "我笑着添了把柴，抬他一手。"
                yield return _gameMethods.ExecuteCharacterImageData("o");
                yield return _gameMethods.OpenDialog(5127); // "当然没问题，感谢陛下信任。"
                yield return _gameMethods.ExecuteCharacterImageData("o");
                yield return _gameMethods.OpenDialog(5128); // "请问公主可带来了国王的诏书？"
                yield return _gameMethods.ExecuteCharacterImageData("nv2");
                yield return _gameMethods.OpenDialog(5034); // "……"
                yield return _gameMethods.OpenDialog(5129); // "果然没那么好蒙骗。"
                yield return _gameMethods.OpenDialog(5130); // "他一语问到了我谎言的关键——按有国王印章的诏书。而我当然没有。"
                yield return _gameMethods.OpenDialog(5131); // "我仿佛不以为意，态度自然地轻描淡写。"
                yield return _gameMethods.ExecuteCharacterImageData("nv2");
                yield return _gameMethods.OpenDialog(5132); // "事态紧急，且财产宝贵，父王要求秘密行动，不可泄露消息。"
                yield return _gameMethods.ExecuteCharacterImageData("nv2");
                yield return _gameMethods.OpenDialog(5133); // "诏书会等明日白天之后补。"
                yield return _gameMethods.ExecuteCharacterImageData("o");
                yield return _gameMethods.OpenDialog(5034); // "……"
                yield return _gameMethods.OpenDialog(5134); // "他没说话，面色中逐渐显出一分迟疑。"
                yield return _gameMethods.OpenDialog(5135); // "看来是察觉到不对劲了。"
                yield return _gameMethods.OpenDialog(5136); // "……难办啊。"
                yield return _gameMethods.OpenDialog(5137); // "我深知，越是这种场合，越不能露怯，必须虚张声势，挺足底气，在心理博弈中占据上风。"
                yield return _gameMethods.ExecuteCharacterImageData("nv2");
                yield return _gameMethods.OpenDialog(5138); // "还犹豫什么？"
                yield return _gameMethods.OpenDialog(5139); // "眼见他迟迟没有动作，我冷下脸，似是有些不耐了。"
                yield return _gameMethods.ExecuteCharacterImageData("nv2");
                yield return _gameMethods.OpenDialog(5140); // "是不相信我带的旨意？"
                yield return _gameMethods.PlaySound("sound", 0.0f, 2f, "<from 0 to 0.5>audio/sound/jiaobusheng_xin_normal1.ogg");
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -18f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.6f}, {"zpos", -42f}})});
                yield return _gameMethods.ExecuteCharacterImageData("nv2");
                yield return _gameMethods.OpenDialog(5141); // "还是违抗王命？"
                yield return _gameMethods.ExecuteCharacterImageData("o");
                yield return _gameMethods.OpenDialog(5142); // "……请恕我冒犯，只是，没有诏书，我不敢贸然领命。"
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -42f}})});
                yield return _gameMethods.ExecuteCharacterImageData("nv2");
                yield return _gameMethods.OpenDialog(5034); // "……"
                yield return _gameMethods.OpenDialog(5143); // "我露出一副强压着不悦，却仍保持冷静与宽容的表情，用上位者的雍容强调说。"
                yield return _gameMethods.ExecuteCharacterImageData("nv2");
                yield return _gameMethods.OpenDialog(5144); // "不愧是莱茵团长，你的严谨令我敬重。"
                if (Defaults.Persistent.Povname=="辛西娅")
                {
                                        yield return _gameMethods.ExecuteCharacterImageData("nv2");
                    yield return _gameMethods.OpenDialog(5145); // "那么，我便以王国公主辛西娅之名，以及神选勇者安德鲁之名作证，这是国王亲口下达的旨意。"

                }
                else
                {
                                        yield return _gameMethods.ExecuteCharacterImageData("nv2");
                    yield return _gameMethods.OpenDialog(5146); // "那么，我便以王国公主[persistent.povname]之名，以及神选勇者安德鲁之名作证，这是国王亲口下达的旨意。"

                }
                yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan1", "zui1", "emoji21"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 12.0f}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(996f, 1398f)}, {"zoom", 0.32f}})});
                yield return _gameMethods.Transition(time:0.4f);
                yield return _gameMethods.ExecuteCharacterImageData("an");
                yield return _gameMethods.OpenDialog(5054); // "？"
                yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1>audio/sound/jiaobusheng_an_kuai1.ogg");
                yield return _gameMethods.Show("an2", parts: new List<string>{"mei8", "yan12", "zui8", "-emoji21"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(822f, 1650f)}, {"zoom", 0.38f}})});
                yield return _gameMethods.Transition(time:0.4f);
                yield return _gameMethods.ExecuteCharacterImageData("an");
                yield return _gameMethods.OpenDialog(5147); // "没错，我以王国所选的勇者之名作证。"
                yield return _gameMethods.Show("an2", parts: new List<string>{"mei8", "yan12", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 0f}, {"blur", 0.1f}})});
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -42f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.50f}, {"zpos", -65f}})});
                yield return _gameMethods.ExecuteCharacterImageData("o");
                yield return _gameMethods.OpenDialog(5034); // "……"
                yield return _gameMethods.OpenDialog(5148); // "在我打一棍子又给个枣的行为之下，肉眼可见的，骑士团团长已经有些动摇了。"
                yield return _gameMethods.Hide("an2");
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -65f}})});
                yield return _gameMethods.OpenDialog(5149); // "终于，他开口。"
                yield return _gameMethods.ExecuteCharacterImageData("o");
                yield return _gameMethods.OpenDialog(5150); // "……抱歉，公主，请恕我无法动身。"
                yield return _gameMethods.ExecuteCharacterImageData("o");
                yield return _gameMethods.OpenDialog(5151); // "虽然我们发誓敬重公主，也敬重王选的勇者安德鲁，/n但每位王家骑士都曾在国王面前许下誓言，只能听从波莱王室的调遣。"
                yield return _gameMethods.Show("npc_qishi2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 12.0f}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.35f}, {"pos", new Vector2(300f, 820f)}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.2f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"xoffset", -3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.2f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0f}})});
                yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/end/kaijia_1.mp3");
                yield return _gameMethods.Transition(time:0.3f);
                yield return _gameMethods.ExecuteCharacterImageData("p");
                yield return _gameMethods.OpenDialog(5152); // "团长，您对她太客气了！"
                yield return _gameMethods.Show("Assets/RenpyResources/images/lihui/npc/npc_qishi2.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
                yield return _gameMethods.OpenDialog(5153); // "此时，骑士团团长身后，一名面露不屑的小队长忽然打断了我们的对话。"
                yield return _gameMethods.ExecuteCharacterImageData("p");
                yield return _gameMethods.OpenDialog(5154); // "哈，什么公主。谁都知道，她曾经流落乡里，/n不过是当时事态紧急，才被赋予了公主的头衔。"
                if (Defaults.Qigai == 0)
                {
                                        yield return _gameMethods.StopSound(channelName:"music", fadeOut:2f);
                    yield return _gameMethods.ExecuteCharacterImageData("p_qian");
                    yield return _gameMethods.OpenDialog(5155); // "「但身世就是身世，和我们这些出生便流淌着高贵血液的——"
                    yield return _gameMethods.PlaySound("sound", 0.0f, 0.5f, "audio/sound/juezhan_dao/SWORD_02.ogg");
                    yield return _gameMethods.PlaySound("sounda", 0.0f, 1.5f, "<silence 0.3>", "audio/sound/emeng_dajie/magic1.ogg");
                    yield return _gameMethods.Show("Assets/RenpyResources/images/lihui/npc/npc_qishi2.png", parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"xoffset", -3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0f}})});
                    yield return _gameMethods.ExecuteCharacterImageData("p_qian");
                    yield return _gameMethods.OpenDialog(5156); // "……唔唔唔！」"
                    yield return _gameMethods.Show("Assets/RenpyResources/images/lihui/npc/npc_qishi2.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
                    if (Defaults.Bai_xue == 1)
                    {
                                                yield return _gameMethods.PlaySound("music1", 0.0f, 0.5f, "audio/music/end/nvwang/Umwelt.mp3");
                        yield return _gameMethods.OpenDialog(5157); // "安德鲁刚铿锵拔出一寸剑刃，而那人已被我用一块冰封冻住了下半张脸。"

                    }
                    yield return _gameMethods.PlaySound("sounda2", 0.0f, 1.0f, "<from 0 to 1>audio/sound/jiaobusheng_xin_normal1.ogg");
                    yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -65f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.6f}, {"zpos", -83f}})});
                    yield return _gameMethods.ExecuteCharacterImageData("nv2");
                    yield return _gameMethods.OpenDialog(5158); // "和你们这些“流淌着高贵血液”的什么？"
                    yield return _gameMethods.OpenDialog(5159); // "我好奇地询问。"
                    yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -83f}})});
                    yield return _gameMethods.Show("Assets/RenpyResources/images/lihui/npc/npc_qishi.png", parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"xoffset", -3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0f}})});
                    yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/zhenjing_shuaidaoganjue.mp3");
                    yield return _gameMethods.OpenDialog(5160); // "团长立即单膝下跪请罪。"
                    yield return _gameMethods.Show("Assets/RenpyResources/images/lihui/npc/npc_qishi.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
                    yield return _gameMethods.ExecuteCharacterImageData("o");
                    yield return _gameMethods.OpenDialog(5161); // "请公主恕罪！是我御下不严。"
                    yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1>audio/sound/jiaobusheng_an_normal1.ogg");
                    yield return _gameMethods.Hide("Assets/RenpyResources/images/lihui/npc/npc_qishi2.png");
                    yield return _gameMethods.Show("luo2", parts: new List<string>{"mei8", "yan5", "zui7"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 12.0f}, {"pos", new Vector2(996f, 1290f)}, {"zoom", 0.3f}})});
                    yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"xpos", 186f}})});
                    yield return _gameMethods.Transition(time:0.4f);
                    yield return _gameMethods.ExecuteCharacterImageData("luo_qian");
                    yield return _gameMethods.OpenDialog(5162); // "「那就好，{nw}{w=0.2}"
                    yield return _gameMethods.Show("luo2", parts: new List<string>{"mei4", "yan8", "zui15"});
                    yield return _gameMethods.ExecuteCharacterImageData("luo_qian");
                    yield return _gameMethods.OpenDialog(5163); // "不然我还以为，这是团长平日的耳濡目染。」"
                    yield return _gameMethods.Show("luo2", parts: new List<string>{"mei8", "yan12", "zui7"});
                    yield return _gameMethods.ExecuteCharacterImageData("luo_qian");
                    yield return _gameMethods.OpenDialog(5164); // "「毕竟，倘若有人侮辱王国的公主，{nw}{w=0.2}"
                    yield return _gameMethods.Show("luo2", parts: new List<string>{"mei4", "yan8", "zui14"});
                    yield return _gameMethods.ExecuteCharacterImageData("luo_qian");
                    yield return _gameMethods.OpenDialog(5165); // "我们法师塔也不会袖手旁观。」"
                    yield return _gameMethods.Show("luo2", parts: new List<string>{"mei4", "yan8", "zui8"});
                    yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 186f}})});
                    yield return _gameMethods.Show("Assets/RenpyResources/images/lihui/npc/npc_qishi.png", parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"xoffset", -3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0f}})});
                    yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/zhenjing_shuaidaoganjue.mp3");
                    yield return _gameMethods.ExecuteCharacterImageData("o");
                    yield return _gameMethods.OpenDialog(5117); // "！"
                    yield return _gameMethods.Show("Assets/RenpyResources/images/lihui/npc/npc_qishi.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
                    yield return _gameMethods.ExecuteCharacterImageData("o");
                    yield return _gameMethods.OpenDialog(5166); // "……您是说，法师塔么？"
                    yield return _gameMethods.Show("luo2", parts: new List<string>{"mei8", "yan5", "zui6"});
                    yield return _gameMethods.ExecuteCharacterImageData("luo");
                    yield return _gameMethods.OpenDialog(5167); // "不然我为何会出现于此？"
                    yield return _gameMethods.Show("luo2", parts: new List<string>{"mei8", "yan5", "zui1"});
                    yield return _gameMethods.ExecuteCharacterImageData("o");
                    yield return _gameMethods.OpenDialog(5034); // "……"

                }
                if (Defaults.Qigai == 1)
                {
                                        yield return _gameMethods.StopSound(channelName:"music", fadeOut:2f);
                    yield return _gameMethods.ExecuteCharacterImageData("p_qian");
                    yield return _gameMethods.OpenDialog(5155); // "「但身世就是身世，和我们这些出生便流淌着高贵血液的——"
                    yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/juezhan2/Blade Stab Cut Body Blood_01.ogg");
                    yield return _gameMethods.Show("Assets/RenpyResources/images/lihui/npc/npc_qishi2.png", parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"xoffset", -3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0f}})});
                    yield return _gameMethods.ExecuteCharacterImageData("p_qian");
                    yield return _gameMethods.OpenDialog(5168); // "……啊啊啊！」"
                    yield return _gameMethods.Show("Assets/RenpyResources/images/lihui/npc/npc_qishi2.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
                    yield return _gameMethods.OpenDialog(5169); // "他的话还未说完，已经变调成惨叫。"
                    yield return _gameMethods.PlaySound("music1", 0.0f, 0.5f, "audio/music/end/nvwang/Umwelt.mp3");
                    yield return _gameMethods.Show("Assets/RenpyResources/images/lihui/xiya/xiya_h1.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(288f, 1050f)}, {"zoom", 0.25f}, {"zpos", 12.0f}})});
                    yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}, {"zpos", -65f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.4f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.3f}, {"xpos", -186f}, {"zpos", -149f}})});
                    yield return _gameMethods.Hide("Assets/RenpyResources/images/lihui/npc/npc_qishi2.png");
                    yield return _gameMethods.PlaySound("sound", 0.0f, 2f, "audio/sound/juezhan_dao/SWORD_01.ogg");
                    
                    yield return _gameMethods.PlaySound("sounda1", 0.0f, 1.0f, "audio/sound/end/kantou.mp3");
                    yield return _gameMethods.OpenDialog(5170); // "在他身后，一个沉默的重甲女骑士在顷刻间举起剑鞘，干脆地一击敲晕了那人。"
                    yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", -186f}, {"zpos", -149f}})});
                    yield return _gameMethods.OpenDialog(5171); // "那人顷刻昏迷，摔倒在地，引发一阵骚动。"
                    yield return _gameMethods.OpenDialog(5172); // "连团长也惊愕皱眉。"
                    yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/zhenjing_shuaidaoganjue.mp3");
                    yield return _gameMethods.Show("Assets/RenpyResources/images/lihui/npc/npc_qishi.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"xoffset", -3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0f}})});
                    yield return _gameMethods.ExecuteCharacterImageData("o");
                    yield return _gameMethods.OpenDialog(5173); // "席亚，你做什么？！"
                    yield return _gameMethods.Show("Assets/RenpyResources/images/lihui/npc/npc_qishi.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
                    yield return _gameMethods.ExecuteCharacterImageData("q");
                    yield return _gameMethods.OpenDialog(5034); // "……"
                    yield return _gameMethods.OpenDialog(5174); // "但那女骑士却毫无言语，仿佛只是在做一件再寻常不过的小事。"
                    yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1.5>audio/sound/end/foots_xiya.ogg");
                    yield return _gameMethods.Hide("Assets/RenpyResources/images/lihui/xiya/xiya_h1.png");
                    yield return _gameMethods.Show("Assets/RenpyResources/images/lihui/xiya/xiya_h2.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 12.0f}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(288f, 1050f)}, {"zoom", 0.25f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"ypos", 1050f}, {"zpos", 60.0f}})});
                    yield return _gameMethods.Transition(time:0.8f);
                    yield return _gameMethods.OpenDialog(5175); // "她走了几步，弯腰，向我敬礼。"
                    yield return _gameMethods.OpenDialog(5176); // "这人约莫有兽人的血统，因此得天独厚，身形比起普通男子都更为高壮。"
                    yield return _gameMethods.PlaySound("soundb", 0.0f, 1.0f, "audio/sound/end/foots_xiya.ogg");
                    yield return _gameMethods.Show("Assets/RenpyResources/images/lihui/xiya/xiya_h2.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 1050f}, {"zpos", 60.0f}})});
                    yield return _gameMethods.OpenDialog(5177); // "烛光照射在她银亮的盔甲上，而她始终缄默。/n眼神坚定，立在原地，注视着我，向我致以敬意。"
                    yield return _gameMethods.OpenDialog(5178); // "我绷紧身体，安德鲁也做出备战姿态。"
                    yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:1f);
                    yield return _gameMethods.OpenDialog(5179); // "她却只是站着，宛如雕塑一样，笨拙地将重剑横起，平放在两手之间。"
                    yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(-354f, -96f)}, {"zpos", -323f}})});
                    yield return _gameMethods.Hide("Assets/RenpyResources/images/lihui/npc/npc_qishi.png");
                    yield return _gameMethods.TransitionBy("blink2");
                    yield return _gameMethods.OpenDialog(5180); // "然后，平静地俯身跪下，宛如一头庞大的熊伏身。/n双手平举那柄锃亮的重剑，抬过头顶。"
                    yield return _gameMethods.ExecuteCharacterImageData("q");
                    yield return _gameMethods.OpenDialog(5181); // "——骑士席亚。"
                    yield return _gameMethods.ExecuteCharacterImageData("q");
                    yield return _gameMethods.OpenDialog(5182); // "向您效忠。"
                    yield return _gameMethods.OpenDialog(5183); // "她嗓音沙哑，发音古怪，似乎很少开口讲话。"
                    yield return _gameMethods.ExecuteCharacterImageData("nv2");
                    yield return _gameMethods.OpenDialog(5034); // "……"
                    yield return _gameMethods.OpenDialog(5184); // "说实话，我有点懵。"
                    yield return _gameMethods.OpenDialog(5185); // "这是哪里来的帮手，难道是又和安德鲁有什么渊源？"
                    yield return _gameMethods.ExecuteCharacterImageData("q");
                    yield return _gameMethods.OpenDialog(5034); // "……"
                    yield return _gameMethods.OpenDialog(5186); // "似乎是见我迟迟没有反应，{nw}{w=0.01}"
                    yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/end/kaijia_1.mp3");
                    yield return _gameMethods.Hide("Assets/RenpyResources/images/lihui/xiya/xiya_h2.png");
                    yield return _gameMethods.Show("xiya", parts: new List<string>{"mei1", "yan6", "zui1", "emoji1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(288f, 1050f)}, {"zoom", 0.25f}, {"zpos", 60.0f}})});
                    yield return _gameMethods.Transition(time:0.5f);
                    yield return _gameMethods.OpenDialog(5187); // "那名女骑士卸下了面甲，露出一张横亘着一道显目伤痕的脸庞。"
                    yield return _gameMethods.Show("xiya");
                    yield return _gameMethods.OpenDialog(5188); // "宛如野生动物一样的眼神，沉寂而专注地盯着我，仿佛要把对方身上的每一寸毛发都看清一样。"
                    yield return _gameMethods.OpenDialog(5189); // "这种眼神唤醒了我的记忆。"
                    yield return _gameMethods.StopSound(channelName:"music1", fadeOut:3f);
                    yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.3>audio/sound/jiaobusheng_xin_kuai1.ogg");
                    yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -323.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.80f}, {"zpos", -335.0f}})});
                    yield return _gameMethods.ExecuteCharacterImageData("nv2");
                    yield return _gameMethods.OpenDialog(5190); // "……是你。"
                    yield return _gameMethods.OpenDialog(5191); // "当年，我曾出手帮了一把的孩子之一。"
                    yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -335.0f}})});
                    yield return _gameMethods.ExecuteCharacterImageData("q1");
                    yield return _gameMethods.OpenDialog(5034); // "……"
                    yield return _gameMethods.Show("xiya", parts: new List<string>{"mei1", "yan1", "zui1"});
                    yield return _gameMethods.PlaySound("music2", 5f, 0.7f, "audio/music/end/end_baiyin02.mp3");
                    Engine._history = false;
                    yield return _gameMethods.OpenDialog(5044); // "{nw}{w=0.15}"
                    Engine._history = true;
                    yield return _gameMethods.Show("xiya", parts: new List<string>{"mei1", "yan6", "zui1"});
                    yield return _gameMethods.OpenDialog(5192); // "她迟缓地眨了下眼，并未否认。"
                    yield return _gameMethods.ExecuteCharacterImageData("nv2");
                    yield return _gameMethods.OpenDialog(5034); // "……"
                    yield return _gameMethods.OpenDialog(5193); // "虽不知道她究竟是凭着怎样的能力、战功或机缘，走到了现在的位置。"
                    yield return _gameMethods.OpenDialog(5194); // "但——……"
                    yield return _gameMethods.OpenDialog(5195); // "原来，只需要两个面包、一张澡堂票，就有机会让一个走投无路的人起死回生，改变命运。"
                    yield return _gameMethods.Show("npc_qishi", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 60.0f}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(576f, 696f)}, {"zoom", 0.36f}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"xoffset", -3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0f}})});
                    yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"xpos", -216f}})});
                    yield return _gameMethods.Transition(time:0.4f);
                    yield return _gameMethods.PlaySound("sound", 0.0f, 0.5f, "audio/sound/end/kaijia_1.mp3");
                    yield return _gameMethods.ExecuteCharacterImageData("o");
                    yield return _gameMethods.OpenDialog(5196); // "席亚，你到底——/n——你可是我选定的继任者……！！！"
                    yield return _gameMethods.Show("Assets/RenpyResources/images/lihui/npc/npc_qishi.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
                    yield return _gameMethods.Show("xiya", parts: new List<string>{"mei1", "yan1", "zui1"});
                    Engine._history = false;
                    yield return _gameMethods.OpenDialog(5044); // "{nw}{w=0.15}"
                    Engine._history = true;
                    yield return _gameMethods.Show("xiya", parts: new List<string>{"mei1", "yan6", "zui1"});
                    yield return _gameMethods.OpenDialog(5197); // "团长不可置信地在女骑士的背后怒吼了两声，可席亚却跪得稳如泰山，头颅纹丝不动。"
                    yield return _gameMethods.ExecuteCharacterImageData("o");
                    yield return _gameMethods.OpenDialog(5034); // "……"
                    yield return _gameMethods.ExecuteCharacterImageData("nv2");
                    yield return _gameMethods.OpenDialog(5034); // "……"
                    yield return _gameMethods.OpenDialog(5198); // "在一片尴尬中，我率先伸出双手，{nw}{w=0.01}"
                    yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -335.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.62f}, {"zpos", -341.0f}})});
                    yield return _gameMethods.ExecuteCharacterImageData("nv2");
                    yield return _gameMethods.OpenDialog(5199); // "接过席亚手中的剑。"
                    yield return _gameMethods.PlaySound("sounda2", 0.0f, 0.4f, "audio/sound/end/kaijia_1.mp3");
                    yield return _gameMethods.PlaySound("sound", 0.0f, 3f, "<from 0 to 0.3>audio/sound/jiaobusheng_xin_kuai1.ogg");
                    yield return _gameMethods.PlaySound("sounda1", 0.0f, 2f, "audio/sound/manbu/Body1_02_duan.mp3");
                    yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -96f}, {"zpos", -341.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.22f}, {"ypos", -60f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.35f}, {"ypos", -96f}})});
                    yield return _gameMethods.OpenDialog(5200); // "——还好用的是双手，那剑极重，我差点一个踉跄，还好稳住了。"
                    yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -96f}})});
                    yield return _gameMethods.OpenDialog(5201); // "{size=+10}好沉啊。{/size}"
                    yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(-360f, -126f)}, {"zpos", -371.0f}})});
                    yield return _gameMethods.TransitionBy("blink2");
                    yield return _gameMethods.OpenDialog(5202); // "我内心呲牙咧嘴，表面云淡风凄，按照骑士的册封礼，用剑身轻轻拍打了两下她的肩膀。"
                    yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1>audio/sound/jiaobusheng_xin_normal1.ogg");
                    yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -371.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.77f}, {"zpos", -383.0f}})});
                    yield return _gameMethods.OpenDialog(5203); // "又上前两步，轻轻吻了一下她头盔下露出的左脸面颊，正落在了她面部的那道伤疤上。"
                    yield return _gameMethods.Show("xiya", parts: new List<string>{"mei1", "yan4", "zui1"});
                    yield return _gameMethods.ExecuteCharacterImageData("q1");
                    yield return _gameMethods.OpenDialog(5034); // "……"
                    yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -383.0f}})});
                    yield return _gameMethods.OpenDialog(5204); // "感觉她好像屏住了呼吸，会不会其实她的内心也有些许紧张呢。"
                    yield return _gameMethods.PlaySound("sound", 0.2f, 0.4f, "audio/demo_audio/sound/moca2.mp3");
                    yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -383.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.77f}, {"zpos", -371.0f}})});
                    yield return _gameMethods.OpenDialog(5205); // "——我后退抽身，把剑授予她。"
                    yield return _gameMethods.ExecuteCharacterImageData("nv2");
                    yield return _gameMethods.OpenDialog(5206); // "席亚骑士，我已收下你的忠诚。"
                    yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -371.0f}})});
                    yield return _gameMethods.ExecuteCharacterImageData("nv2");
                    yield return _gameMethods.OpenDialog(5207); // "此剑授予你，允你以它守护我终生。"
                    yield return _gameMethods.Show("xiya", parts: new List<string>{"mei1", "yan6", "zui1"});
                    yield return _gameMethods.ExecuteCharacterImageData("q1");
                    yield return _gameMethods.OpenDialog(5034); // "……"
                    yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1.5>audio/sound/end/foots_xiya.ogg");
                    yield return _gameMethods.Show("xiya", parts: new List<string>{"-emoji1"});
                    yield return _gameMethods.Hide("xiya");
                    yield return _gameMethods.Transition(time:0.5f);
                    yield return _gameMethods.OpenDialog(5208); // "她一言不发地、认真地接过那柄重剑，缓缓起身，浑身盔甲铿锵作响，走到了我的身后一侧。"
                    yield return _gameMethods.OpenDialog(5209); // "安德鲁看了她一眼，撇撇嘴，让出了一个位置。"
                    yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(-42f, -78f)}, {"zpos", -215.0f}})});
                    yield return _gameMethods.Transition(time:0.5f);
                    yield return _gameMethods.ExecuteCharacterImageData("o");
                    yield return _gameMethods.OpenDialog(5034); // "……"
                    yield return _gameMethods.OpenDialog(5210); // "团长蓦地无奈叹气，仿佛忽然间沧桑了十岁。"
                    yield return _gameMethods.ExecuteCharacterImageData("o");
                    yield return _gameMethods.OpenDialog(5211); // "随你吧。"
                    yield return _gameMethods.Show("npc_qishi", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 60.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.6f}, {"zpos", 74.0f}})});
                    yield return _gameMethods.OpenDialog(5212); // "他转而对我恭敬道。"
                    yield return _gameMethods.ExecuteCharacterImageData("o");
                    yield return _gameMethods.OpenDialog(5213); // "……怀特男爵对公主出言不逊，应当严惩。"
                    yield return _gameMethods.Show("Assets/RenpyResources/images/lihui/npc/npc_qishi.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 74.0f}})});
                    yield return _gameMethods.ExecuteCharacterImageData("o");
                    yield return _gameMethods.OpenDialog(5214); // "但很抱歉，公主，有骑士宣言在前，我们无能为力。"
                    yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1>audio/sound/jiaobusheng_an_normal1.ogg");
                    yield return _gameMethods.Show("luo2", parts: new List<string>{"mei8", "yan5", "zui7"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 12.0f}, {"pos", new Vector2(942f, 1206f)}, {"zoom", 0.28f}})});
                    yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.7f}, {"xpos", 186f}})});
                    yield return _gameMethods.Transition(time:0.4f);
                    yield return _gameMethods.ExecuteCharacterImageData("luo_qian");
                    yield return _gameMethods.OpenDialog(5215); // "「是么？若不是这位席亚骑士反应迅速，{nw}{w=0.2}"
                    yield return _gameMethods.Show("luo2", parts: new List<string>{"mei4", "yan8", "zui14"});
                    yield return _gameMethods.ExecuteCharacterImageData("luo_qian");
                    yield return _gameMethods.OpenDialog(5216); // "我都要以为那男爵所言，其实是团长平日里的耳濡目染了。」"
                    yield return _gameMethods.Show("luo2", parts: new List<string>{"mei4", "yan8", "zui8"});
                    yield return _gameMethods.ExecuteCharacterImageData("o");
                    yield return _gameMethods.OpenDialog(5217); // "以骑士的尊严起誓，绝无此事！"
                    yield return _gameMethods.Show("luo2", parts: new List<string>{"mei8", "yan5", "zui6"});
                    yield return _gameMethods.ExecuteCharacterImageData("luo");
                    yield return _gameMethods.OpenDialog(5218); // "那便好。"
                    yield return _gameMethods.Show("luo2", parts: new List<string>{"mei8", "yan12", "zui7"});
                    yield return _gameMethods.ExecuteCharacterImageData("luo_qian");
                    yield return _gameMethods.OpenDialog(5164); // "「毕竟，倘若有人侮辱王国的公主，{nw}{w=0.2}"
                    yield return _gameMethods.Show("luo2", parts: new List<string>{"mei4", "yan8", "zui15"});
                    yield return _gameMethods.ExecuteCharacterImageData("luo_qian");
                    yield return _gameMethods.OpenDialog(5165); // "我们法师塔也不会袖手旁观。」"
                    yield return _gameMethods.Show("luo2", parts: new List<string>{"mei4", "yan8", "zui8"});
                    yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/end/kaijia_1.mp3");
                    yield return _gameMethods.Show("Assets/RenpyResources/images/lihui/npc/npc_qishi.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"xoffset", -2f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 2f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0f}})});
                    yield return _gameMethods.ExecuteCharacterImageData("o");
                    yield return _gameMethods.OpenDialog(5117); // "！"
                    yield return _gameMethods.Show("Assets/RenpyResources/images/lihui/npc/npc_qishi.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
                    yield return _gameMethods.ExecuteCharacterImageData("o");
                    yield return _gameMethods.OpenDialog(5166); // "……您是说，法师塔么？"
                    yield return _gameMethods.Show("luo2", parts: new List<string>{"mei8", "yan5", "zui7"});
                    yield return _gameMethods.ExecuteCharacterImageData("luo");
                    yield return _gameMethods.OpenDialog(5219); // "不然我为何会出现在此？"
                    yield return _gameMethods.Show("luo2", parts: new List<string>{"mei8", "yan5", "zui1"});
                    yield return _gameMethods.ExecuteCharacterImageData("o");
                    yield return _gameMethods.OpenDialog(5034); // "……"

                }
                yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/jieju/jieju6.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.02f)}, {"zoom", 0.76f}})});
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", -6f}, {"zpos", -84.0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
                yield return _gameMethods.Show("Assets/RenpyResources/images/lihui/npc/npc_qishi.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.4f}, {"pos", new Vector2(618f, 762f)}})});
                yield return _gameMethods.Transition(time:0.4f);
                yield return _gameMethods.OpenDialog(5220); // "团长沉默了。"
                yield return _gameMethods.OpenDialog(5221); // "法师塔以精英著称，虽然其人数和在民间的能量，都远无法同骑士团等组织相比，但却掌握驻守着一个和最高神圣术有着同等威力的大型禁忌法阵。"
                yield return _gameMethods.OpenDialog(5222); // "倘若法阵被激活，足以将整个王都笼罩在内。/n届时，除了有神圣术守护的中央城区和王宫可以幸免，其他一切区域都将被摧毁。"
                yield return _gameMethods.OpenDialog(5223); // "这是很强力的威慑了。"
                yield return _gameMethods.OpenDialog(5224); // "衡量片刻，他一脸艰难地开口。"
                yield return _gameMethods.StopSound(channelName:"music1", fadeOut:7f);
                yield return _gameMethods.StopSound(channelName:"music2", fadeOut:7f);
                yield return _gameMethods.PlaySound("soundb", 2f, 1.0f, "audio/demo_audio/sound/chong1.ogg");
                yield return _gameMethods.ExecuteCharacterImageData("o");
                yield return _gameMethods.OpenDialog(5225); // "……抱歉，但有骑士宣言在前，/n我们、……"
                yield return _gameMethods.OpenDialog(5226); // "……我察觉到了。"
                yield return _gameMethods.OpenDialog(5227); // "他的信念其实已经摇摇欲坠了。"
                yield return _gameMethods.OpenDialog(5228); // "局势发展到现在，我的心思已近乎于明牌，而法师塔的加入，更是让他担心冲突一起，会波及城内无辜居民。"
                yield return _gameMethods.OpenDialog(5229); // "但他仍不肯松口，恐怕是因为那点身为骑士对于忠诚的执念。"
                yield return _gameMethods.OpenDialog(5230); // "也就是说，我要使用一个，在他心里，比对王的忠诚更加重要的东西作为借口，来压倒前者，缓解他的心理压力和罪恶感。"
                yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:2f);
                yield return _gameMethods.PlaySound("music1", 0.0f, 0.7f, "audio/music/end/nvwang/Dark_World.mp3");
                yield return _gameMethods.ExecuteCharacterImageData("nv2");
                yield return _gameMethods.OpenDialog(5231); // "……王家骑士团第十八任团长，莱因哈特听命。"
                yield return _gameMethods.ExecuteCharacterImageData("o");
                yield return _gameMethods.OpenDialog(5232); // "……？"
                yield return _gameMethods.ExecuteCharacterImageData("nv2");
                yield return _gameMethods.OpenDialog(5233); // "王都西北五百英里处出现异动，疑似魔物入侵。"
                yield return _gameMethods.PlaySound("sounda1", 0.0f, 1.0f, "audio/sound/end/kaijia_1.mp3");
                yield return _gameMethods.Show("Assets/RenpyResources/images/lihui/npc/npc_qishi.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"xoffset", -3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0f}})});
                yield return _gameMethods.ExecuteCharacterImageData("o");
                yield return _gameMethods.OpenDialog(5234); // "……！"
                yield return _gameMethods.PlaySound("sound", 0.0f, 2f, "<from 0 to 1>audio/sound/jiaobusheng_xin_normal1.ogg");
                yield return _gameMethods.Show("Assets/RenpyResources/images/lihui/npc/npc_qishi.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -84.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.8f}, {"zpos", -168.0f}})});
                if (Defaults.Persistent.Povname=="辛西娅")
                {
                                        yield return _gameMethods.ExecuteCharacterImageData("nv2");
                    yield return _gameMethods.OpenDialog(5235); // "我以波莱王室公主——辛西娅之名，命你率骑士团前往调查。"

                }
                else
                {
                                        yield return _gameMethods.ExecuteCharacterImageData("nv2");
                    yield return _gameMethods.OpenDialog(5236); // "我以波莱王室公主——[persistent.povname]之名，命你率骑士团前往调查。"

                }
                yield return _gameMethods.ExecuteCharacterImageData("nv2");
                yield return _gameMethods.OpenDialog(5237); // "你立即动身，若有延误，致使百姓伤亡，生灵涂炭，以叛国罪论处。"
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -168.0f}})});
                yield return _gameMethods.OpenDialog(5238); // "我咬重了“百姓伤亡，生灵涂炭”。"
                yield return _gameMethods.ExecuteCharacterImageData("o");
                yield return _gameMethods.OpenDialog(5034); // "……"
                yield return _gameMethods.PlaySound("sounda", 0.0f, 1.5f, "<from 0 to 0.5>audio/sound/jiaobusheng_an_normal1.ogg");
                yield return _gameMethods.Show("an2", parts: new List<string>{"mei8", "yan16", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(954f, 1656f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.37f}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}, {"blur", 0.1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1f}, {"blur", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 100f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.6f}, {"xoffset", 0f}})});
                yield return _gameMethods.ExecuteCharacterImageData("an");
                yield return _gameMethods.OpenDialog(5239); // "还等什么？"
                yield return _gameMethods.Show("an2", parts: new List<string>{"mei8", "yan16", "zui2"});
                yield return _gameMethods.OpenDialog(5240); // "安德鲁冷声问。"
                yield return _gameMethods.Show("an2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}, {"blur", 0f}, {"xoffset", 0f}})});
                yield return _gameMethods.OpenDialog(5241); // "骑士团团长默然片刻，恭敬低头。"
                yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/end/kaijia_1.mp3");
                yield return _gameMethods.Show("an2", parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 0f}, {"blur", 0.1f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.6f}, {"xoffset", 100f}})});
                yield return _gameMethods.Show("Assets/RenpyResources/images/lihui/npc/npc_qishi.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 762f}, {"zoom", 0.4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.31f}, {"ypos", 792f}, {"zoom", 0.42f}})});
                yield return _gameMethods.ExecuteCharacterImageData("o");
                yield return _gameMethods.OpenDialog(5242); // "遵照您的旨意，阁下。"
                yield return _gameMethods.Show("Assets/RenpyResources/images/lihui/npc/npc_qishi.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", 792f}, {"zoom", 0.42f}})});
                yield return _gameMethods.ExecuteCharacterImageData("o");
                yield return _gameMethods.OpenDialog(5243); // "军情紧急，我即刻动身。"
                yield return _gameMethods.PlaySound("sounda2", 0.0f, 1.0f, "audio/sound/end/footsteps-knight-team-walk-run-castle-hall_02.mp3");
                yield return _gameMethods.Hide("an2");
                yield return _gameMethods.Hide("Assets/RenpyResources/images/lihui/npc/npc_qishi.png");
                yield return _gameMethods.Transition(time:0.5f);
                yield return _gameMethods.OpenDialog(5244); // "我送了口气。总算成功对症下药了。"
                yield return _gameMethods.OpenDialog(5245); // "在这个距离下，骑士团即便到了地方就立刻掉头返回，也需花费至少三天时间。"
                yield return _gameMethods.OpenDialog(5246); // "在那之前，大局已定，我会摆平一切。"
                yield return _gameMethods.StopSound(channelName:"music1", fadeOut:5f);
                yield return _gameMethods.SceneBlack();
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
                yield return _gameMethods.Transition(time:0.5f);
                yield return _gameMethods.OpenDialog(5034); // "……"
                yield return _gameMethods.StopSound(channelName:"music", fadeOut:4f);
                yield return _gameMethods.OpenDialog(5035); // "…………"
                yield return _gameMethods.OpenDialog(5247); // "搞定了法师塔和骑士团，那么剩下的百千步兵也是群龙无首，不足为惧。"
                yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg16_memory.jpg");
                yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg16_memory.jpg");
                yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/jieju/jieju7.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.0f)}, {"zoom", 0.67f}})});
                yield return _gameMethods.Transition(time:0.5f);
                yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/music/end/nvwang/nvwang1.mp3");
                yield return _gameMethods.OpenDialog(5248); // "——终于，万事俱备，胜券在握。"
                yield return _gameMethods.OpenDialog(5249); // "我踏入了王宫。"
                yield return _gameMethods.OpenDialog(5250); // "驻守在宫殿外侧的轮班士兵们，此时还不知骑士团发生的变故，见到我后，都一脸惊愕。"
                yield return _gameMethods.OpenDialog(5251); // "但他们毕竟知道我的身份，也看到了我身后跟随的勇者一众人，很有几人还认出了席亚。"
                yield return _gameMethods.OpenDialog(5252); // "总之，无人敢阻拦。"
                yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 2>audio/sound/jiaobusheng_xin_kuai1.ogg");
                yield return _gameMethods.Scene("Assets/RenpyResources/images/demo_images/demo_images_bg/wanggong_zoulang.jpg");
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
                yield return _gameMethods.TransitionBy("trans_rip_fast");
                yield return _gameMethods.OpenDialog(5253); // "我就这样畅通无阻地进入了宫殿。"
                yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei1", "yan1", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.48f, 1.68f)}, {"zoom", 0.5f}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}, {"blur", 0.1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1f}, {"blur", 0f}})});
                yield return _gameMethods.OpenDialog(5254); // "一进门，迎面看到了正要外出的公主。"
                yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei1", "yan3", "zui5"});
                yield return _gameMethods.ExecuteCharacterImageData("c");
                yield return _gameMethods.OpenDialog(5255); // "……姐姐？"
                yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei1", "yan6", "zui5"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}, {"blur", 0f}})});
                yield return _gameMethods.ExecuteCharacterImageData("c");
                yield return _gameMethods.OpenDialog(5256); // "你回来了？"
                yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei1", "yan6", "zui2"});
                yield return _gameMethods.OpenDialog(5257); // "她一脸惊愕，打量了我两眼，随即笑出声。"
                yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei1", "yan1", "zui4"});
                yield return _gameMethods.ExecuteCharacterImageData("c_qian");
                yield return _gameMethods.OpenDialog(5258); // "「呵，{nw}{w=0.2}"
                yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei1", "yan2", "zui4"});
                yield return _gameMethods.ExecuteCharacterImageData("c_qian");
                yield return _gameMethods.OpenDialog(5259); // "我就知道，什么预言中的龙？」"
                yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei1", "yan6", "zui4"});
                yield return _gameMethods.ExecuteCharacterImageData("c");
                yield return _gameMethods.OpenDialog(5260); // "当然无法与我们卡佩王室的勇者相抗衡。"
                yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/jiaobusheng_nv_liangbuzou_gaogen_diban.mp3");
                yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei1", "yan4", "zui10"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 0.65f}, {"zpos", 24.0f}})});
                yield return _gameMethods.ExecuteCharacterImageData("c");
                yield return _gameMethods.OpenDialog(5261); // "对了，既然你回来，就跟我去见一下——"
                yield return _gameMethods.PlaySound("sounda1", 0.0f, 1.0f, "<from 0 to 2>audio/sound/jiaobusheng_xin_kuai1.ogg");
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"zpos", -186f}})});
                yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei1", "yan4", "zui11"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 0f}, {"blur", 0.1f}})});
                yield return _gameMethods.OpenDialog(5262); // "我没有回答，与她擦身而过，快步前进。"
                yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei2", "yan1", "zui11"});
                Engine._history = false;
                yield return _gameMethods.ExecuteCharacterImageData("c_qian");
                yield return _gameMethods.OpenDialog(5044); // "{nw}{w=0.15}"
                Engine._history = true;
                yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei3", "yan3", "zui5"});
                yield return _gameMethods.ExecuteCharacterImageData("c");
                yield return _gameMethods.OpenDialog(5263); // "喂！你怎么不理我？"
                yield return _gameMethods.Hide("gongzhu_layered");
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -186f}})});
                yield return _gameMethods.ExecuteCharacterImageData("c");
                yield return _gameMethods.OpenDialog(5264); // "……给我等等！"
                yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg21_memory.jpg");
                yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg21_memory.jpg");
                yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<from 0 to 1>audio/sound/jiaobusheng_xin_kuai1.ogg");
                yield return _gameMethods.PlaySound("sound", 0.0f, 2f, "audio/sound/end/door-open_01.mp3");
                yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/jieju/jieju2.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.0f)}, {"zoom", 0.67f}})});
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
                yield return _gameMethods.TransitionBy("trans_rip_fast");
                yield return _gameMethods.OpenDialog(5265); // "我一路闯进了宫殿正厅。"
                yield return _gameMethods.OpenDialog(5266); // "国王——那个穿金带银的年迈老头，正坐在最上正中的王座上，见到我，愕然一惊。"
                yield return _gameMethods.PlaySound("sound", 0.0f, 4f, "audio/sound/manbu/Body1_02_duan.mp3");
                yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "<from 0 to 1.5>audio/sound/jiaobusheng_xin_kuai1.ogg");
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 1.32f}, {"zpos", -420.0f}})});
                yield return _gameMethods.Show("npc_guowang", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.49f, 0.78f)}, {"zoom", 0.42f}, {"anchor", new Vector2(0.5f, 1.0f)}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1f}})});
                yield return _gameMethods.ExecuteCharacterImageData("nv2");
                yield return _gameMethods.OpenDialog(5267); // "国王陛下，我想问你一个问题。"
                yield return _gameMethods.OpenDialog(5268); // "我快步向前。"
                yield return _gameMethods.ExecuteCharacterImageData("a");
                yield return _gameMethods.OpenDialog(5269); // "你活着回来了？"
                yield return _gameMethods.OpenDialog(5270); // "他皱眉。"
                yield return _gameMethods.ExecuteCharacterImageData("a");
                yield return _gameMethods.OpenDialog(5271); // "怎么擅自闯入？真是没规矩！"
                yield return _gameMethods.PlaySound("sounda1", 0.0f, 1.0f, "<from 0 to 1>audio/sound/jiaobusheng_xin_normal1.ogg");
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -420.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 1.35f}, {"zpos", -500.0f}})});
                yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_portrait/npc/npc_guowang.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
                yield return _gameMethods.EngineSetVolume(volume:0.7f, delay:2f, channelName:"music");
                yield return _gameMethods.OpenDialog(5272); // "我没有回答，一步一步走上前去。"
                yield return _gameMethods.ExecuteCharacterImageData("nv2");
                yield return _gameMethods.OpenDialog(5273); // "……嗯，我还在犹豫究竟要怎么处置你。"
                yield return _gameMethods.ExecuteCharacterImageData("nv2");
                yield return _gameMethods.OpenDialog(5274); // "毕竟我的母亲已经去世了，我觉得该有人给她补偿，"
                yield return _gameMethods.ExecuteCharacterImageData("nv2");
                yield return _gameMethods.OpenDialog(5275); // "但又感觉，也许她并不想看我被这种人脏了手。"
                yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/jiaobusheng_nv_liangbuzou_gaogen_diban.mp3");
                yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei2", "yan6", "zui9"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(768f, 774f)}, {"zoom", 0.25f}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}, {"blur", 0.1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1f}, {"blur", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 50f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.8f}, {"xoffset", 0f}})});
                yield return _gameMethods.ExecuteCharacterImageData("c");
                yield return _gameMethods.OpenDialog(5276); // "？！"
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -500.0f}})});
                yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei2", "yan7", "zui8"});
                yield return _gameMethods.OpenDialog(5277); // "公主皱起眉，仿佛已敏锐地察觉到了话语中暗藏的危险。"
                yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei2", "yan5", "zui7"});
                yield return _gameMethods.ExecuteCharacterImageData("c");
                yield return _gameMethods.OpenDialog(5278); // "卫兵呢？"
                yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei2", "yan5", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}, {"xoffset", 0f}, {"blur", 0f}})});
                yield return _gameMethods.OpenDialog(5279); // "她高声呼喝。"
                yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei2", "yan7", "zui7"});
                yield return _gameMethods.PlaySound("sound", 0.0f, 4f, "audio/sound/manbu/Body1_02_duan.mp3");
                yield return _gameMethods.ExecuteCharacterImageData("c");
                yield return _gameMethods.OpenDialog(5280); // "来人，保护国王！"
                yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei2", "yan7", "zui8"});
                if (Defaults.Qigai == 0)
                {
                                        yield return _gameMethods.PlaySound("sounda", 0.0f, 3f, "<from 0 to 1.5>audio/sound/end/footsteps-knight-team-walk-run-castle-hall_01.ogg");
                    yield return _gameMethods.PlaySound("sounda1", 0.0f, 1f, "<silence 1>", "audio/sound/juezhan_dao/SWORD_02.ogg");
                    yield return _gameMethods.OpenDialog(5281); // "一小队卫兵瞬间向我冲来，却被安德鲁洛恩拦住。"

                }
                if (Defaults.Qigai == 1)
                {
                                        yield return _gameMethods.PlaySound("sounda1", 0.0f, 2f, "audio/sound/end/kaijia_1.mp3");
                    yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.4f}, {"xpos", -90f}})});
                    yield return _gameMethods.Show("xiya", parts: new List<string>{"mei2", "yan6", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(528f, 948f)}, {"zoom", 0.19f}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}, {"blur", 0.1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"alpha", 1f}, {"blur", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", -50f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.6f}, {"xoffset", 0f}})});
                    yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei2", "yan3", "zui9"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"blur", 2f}})});
                    yield return _gameMethods.Show("npc_guowang", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"blur", 2f}})});
                    yield return _gameMethods.ExecuteCharacterImageData("q1");
                    yield return _gameMethods.OpenDialog(5282); // "士兵，驻守原地。"
                    yield return _gameMethods.Show("xiya", parts: new List<string>{"mei2", "yan6", "zui1"});
                    yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei2", "yan5", "zui8"});
                    yield return _gameMethods.OpenDialog(5283); // "席亚沙哑的嗓音紧随。"
                    yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", -90f}})});
                    yield return _gameMethods.Show("xiya", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}, {"blur", 0f}, {"xoffset", 0f}})});
                    yield return _gameMethods.OpenDialog(5284); // "这道命令犹如定海神针，将本打算冲上来一小队卫兵定在了原地，犹豫不决。"
                    yield return _gameMethods.ExecuteCharacterImageData("r");
                    yield return _gameMethods.OpenDialog(5285); // "席亚队长，这是……？"
                    yield return _gameMethods.OpenDialog(5286); // "一个是高高在上的帝国公主，一个却是日常每天相见的直属队长。前者身份如此尊贵，但服从后者的命令也已仿佛成了身体本能。"

                }
                yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/jieju/jieju2.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.78f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 1.73f}})});
                yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_portrait/npc/npc_guowang.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(564f, 882f)}, {"zoom", 1.06f}, {"anchor", new Vector2(0.5f, 1.0f)}})});
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.6f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.5f}, {"zpos", -30f}})});
                yield return _gameMethods.PlaySound("sounda", 0.0f, 2f, "audio/sound/emeng_dajie/magic1.ogg");
                yield return _gameMethods.TransitionBy("blink2");
                yield return _gameMethods.OpenDialog(5287); // "趁着这拉扯犹豫的瞬间，我的魔法已经先一步缠上了国王的咽喉。"
                yield return _gameMethods.StopSound(channelName:"music", fadeOut:4f);
                yield return _gameMethods.OpenDialog(5288); // "看着他惊怒交加的表情，我忽然起了一些荒谬而幽默的好奇心。"
                yield return _gameMethods.ExecuteCharacterImageData("nv2");
                yield return _gameMethods.OpenDialog(5289); // "嗯，那么，就用一个问题来决定吧。"
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -30f}})});
                yield return _gameMethods.ExecuteCharacterImageData("nv2");
                yield return _gameMethods.OpenDialog(5290); // "我问你——"
                yield return _gameMethods.ExecuteCharacterImageData("nv2");
                yield return _gameMethods.OpenDialog(5291); // "我向您索要的二十四万金币，您实际上究竟给了我的朋友们多少呢。"
                yield return _gameMethods.PlaySound("music1", 0.0f, 1.0f, "audio/music/end/nvwang/Time_limit.mp3");
                yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/zhenjing_shuaidaoganjue.mp3");
                yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_portrait/npc/npc_guowang.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"xoffset", -3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0f}})});
                yield return _gameMethods.ExecuteCharacterImageData("a");
                yield return _gameMethods.OpenDialog(5292); // "什、什么？"
                yield return _gameMethods.PlaySound("sounda", 0.0f, 0.7f, "<from 0 to 0.5>audio/sound/jiaobusheng_xin_normal1.ogg");
                yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_portrait/npc/npc_guowang.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.3f}, {"zpos", -45f}})});
                yield return _gameMethods.ExecuteCharacterImageData("nv2");
                yield return _gameMethods.OpenDialog(5293); // "安德鲁·布莱克家，八万。"
                yield return _gameMethods.PlaySound("sounda", 0.0f, 1f, "<from 0 to 0.5>audio/sound/jiaobusheng_xin_normal1.ogg");
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.3f}, {"zpos", -60f}})});
                yield return _gameMethods.ExecuteCharacterImageData("nv2");
                yield return _gameMethods.OpenDialog(5294); // "洛恩·贝克家，八万。"
                yield return _gameMethods.PlaySound("sounda", 0.0f, 1.5f, "<from 0 to 0.5>audio/sound/jiaobusheng_xin_normal1.ogg");
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.3f}, {"zpos", -75f}})});
                yield return _gameMethods.ExecuteCharacterImageData("nv2");
                yield return _gameMethods.OpenDialog(5295); // "其他人家，八万。"
                yield return _gameMethods.ExecuteCharacterImageData("nv2");
                yield return _gameMethods.OpenDialog(5296); // "这是我的酬金。"
                yield return _gameMethods.ExecuteCharacterImageData("nv2");
                yield return _gameMethods.OpenDialog(5297); // "您付清了多少？"
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -75f}})});
                yield return _gameMethods.ExecuteCharacterImageData("a");
                yield return _gameMethods.OpenDialog(5034); // "……"
                yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.5>audio/sound/jiaobusheng_an_normal1.ogg");
                yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_portrait/npc/npc_guowang.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"zpos", 18.0f}})});
                yield return _gameMethods.ExecuteCharacterImageData("a");
                yield return _gameMethods.OpenDialog(5298); // "胡闹，你知道二十四万金币是多大一笔开支吗？"
                yield return _gameMethods.ExecuteCharacterImageData("nv2");
                yield return _gameMethods.OpenDialog(5299); // "当然。"
                yield return _gameMethods.ExecuteCharacterImageData("nv2");
                yield return _gameMethods.OpenDialog(5300); // "不过一座宫殿庭院的修建费。"
                yield return _gameMethods.PlaySound("sounda2", 0.0f, 0.4f, "audio/sound/moca1.ogg");
                yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_portrait/npc/npc_guowang.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 18.0f}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"xoffset", -3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0f}})});
                yield return _gameMethods.ExecuteCharacterImageData("a");
                yield return _gameMethods.OpenDialog(5301); // "{size=+10}一座宫殿庭院！！！{/size}"
                yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_portrait/npc/npc_guowang.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
                yield return _gameMethods.OpenDialog(5302); // "他瞪着我，似是震惊于我竟会产生如此大逆不道的念头。"
                yield return _gameMethods.ExecuteCharacterImageData("nv2");
                yield return _gameMethods.OpenDialog(5303); // "看来你是不会正面回答了。"
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(-270f, 450f)}, {"zpos", 15f}, {"anchor", new Vector2(0.5f, 1.0f)}, {"yoffset", 150f}})});
                yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan12", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(-18f, 1434f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.4f}, {"yoffset", 150f}})});
                yield return _gameMethods.Show("luo2", parts: new List<string>{"mei8", "yan5", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(-510f, 1362f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.39f}, {"yoffset", 150f}})});
                yield return _gameMethods.TransitionBy("blink2");
                yield return _gameMethods.OpenDialog(5304); // "我看向安德鲁和洛恩。"
                yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui1"});
                yield return _gameMethods.ExecuteCharacterImageData("nv2");
                yield return _gameMethods.OpenDialog(5305); // "那么，你们告诉我吧。"
                yield return _gameMethods.ExecuteCharacterImageData("nv2");
                yield return _gameMethods.OpenDialog(5306); // "这三年里，我真的很好奇这个问题。"
                yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan13", "zui6"});
                yield return _gameMethods.ExecuteCharacterImageData("an_qian");
                yield return _gameMethods.OpenDialog(5307); // "「金币么，{nw}{w=0.01}"
                yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui4"});
                yield return _gameMethods.ExecuteCharacterImageData("an_qian");
                yield return _gameMethods.OpenDialog(5308); // "我们家收到了八千。」"
                yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui1"});
                yield return _gameMethods.Show("luo2", parts: new List<string>{"mei8", "yan12", "zui1"});
                Engine._history = false;
                yield return _gameMethods.OpenDialog(5044); // "{nw}{w=0.15}"
                Engine._history = true;
                yield return _gameMethods.Show("luo2", parts: new List<string>{"mei8", "yan5", "zui7"});
                yield return _gameMethods.ExecuteCharacterImageData("luo");
                yield return _gameMethods.OpenDialog(5309); // "我也是八千。"
                yield return _gameMethods.Show("luo2", parts: new List<string>{"mei8", "yan5", "zui1"});
                yield return _gameMethods.ExecuteCharacterImageData("nv2");
                yield return _gameMethods.OpenDialog(5034); // "……"
                yield return _gameMethods.OpenDialog(5310); // "我差点没绷住表情。"
                yield return _gameMethods.OpenDialog(5311); // "虽然想过会缺斤少两，但居然能缩水到这个地步吗？！"
                yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan2", "zui1"});
                Engine._history = false;
                yield return _gameMethods.OpenDialog(5044); // "{nw}{w=0.15}"
                Engine._history = true;
                yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui1"});
                yield return _gameMethods.OpenDialog(5312); // "十分之一？！"
                yield return _gameMethods.EngineSetVolume(volume:0.5f, delay:2f, channelName:"music1");
                yield return _gameMethods.OpenDialog(5313); // "……等等，那我对安德鲁说“所以我给你钱，希望你能实现你的梦想”时，其实只给了他八千？"
                yield return _gameMethods.OpenDialog(5314); // "救命，这和那种每个月只给老婆八百块买菜钱还自信放言“以后我养你”的男人有什么区别？！"
                yield return _gameMethods.OpenDialog(5315); // "太尴尬了吧！？！？"
                yield return _gameMethods.EngineSetVolume(volume:1f, delay:1f, channelName:"music1");
                yield return _gameMethods.Hide("an2");
                yield return _gameMethods.Hide("luo2");
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(636f, 564f)}, {"zpos", -63.0f}})});
                yield return _gameMethods.Transition(time:0.4f);
                yield return _gameMethods.OpenDialog(5316); // "我维持着面上云淡风轻的神色，冷淡地蔑视着国王。"
                yield return _gameMethods.ExecuteCharacterImageData("nv2");
                yield return _gameMethods.OpenDialog(5034); // "……"
                yield return _gameMethods.ExecuteCharacterImageData("nv2");
                yield return _gameMethods.OpenDialog(5317); // "你看到了。天作孽，犹可恕，自作孽，不可活。"
                yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/moca1.ogg");
                yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_portrait/npc/npc_guowang.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"xoffset", -3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0f}})});
                yield return _gameMethods.ExecuteCharacterImageData("a");
                yield return _gameMethods.OpenDialog(5318); // "你要做什么？！你想做什么？！"
                yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_portrait/npc/npc_guowang.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
                yield return _gameMethods.PlaySound("sounda", 0.0f, 0.5f, "audio/sound/juezhan_dao/SWORD_02.ogg");
                yield return _gameMethods.OpenDialog(5319); // "维持着魔法对国王咽喉的束缚，我抽出安德鲁腰间的剑，对准了他。"
                yield return _gameMethods.ExecuteCharacterImageData("nv2");
                yield return _gameMethods.OpenDialog(5320); // "做你曾经对我和母亲做过的事，结束你的命运。"
                if (Defaults.Wangzixian == 0)
                {
                                        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/juezhan_dao/SWORD_01.ogg");
                    yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei2", "yan4", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(612f, 1182f)}, {"zoom", 0.5f}, {"zpos", 20.0f}})});
                    yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -63.0f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.4f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.5f}, {"zpos", 63.0f}})});
                    
                    yield return _gameMethods.OpenDialog(5321); // "然而，“锃”地一声，有个人飞快地拔出了剑，如一团风般，挡在国王身前。"
                    yield return _gameMethods.OpenDialog(5322); // "是一身红裙的公主琶菈丝。"
                    yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 63.0f}})});
                    yield return _gameMethods.OpenDialog(5323); // "她身材高挑，同样是一名觉醒了血脉力量的骑士，此刻持细剑而立，仿佛不敢置信。"
                    yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei3", "yan6", "zui7"});
                    yield return _gameMethods.ExecuteCharacterImageData("c");
                    yield return _gameMethods.OpenDialog(5324); // "为什么？！"
                    yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei3", "yan6", "zui8"});
                    yield return _gameMethods.OpenDialog(5325); // "公主盯着我。她气喘吁吁，发丝散乱，失去了所有贵族的风度与礼仪。"
                    yield return _gameMethods.OpenDialog(5326); // "带着被背弃了一般的怒火、冤屈和茫然，怒视着我。"
                    yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei3", "yan6", "zui7"});
                    yield return _gameMethods.ExecuteCharacterImageData("c");
                    yield return _gameMethods.OpenDialog(5327); // "为什么，你要这么做？"
                    yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei3", "yan6", "zui8"});
                    yield return _gameMethods.ExecuteCharacterImageData("nv2");
                    yield return _gameMethods.OpenDialog(5328); // "你说呢。"
                    yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei4", "yan4", "zui9"});
                    yield return _gameMethods.ExecuteCharacterImageData("nv2");
                    yield return _gameMethods.OpenDialog(5329); // "刚刚的对话，没听到么？"
                    yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei3", "yan1", "zui8"});
                    yield return _gameMethods.OpenDialog(5330); // "我心平气和的回答。"
                    yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei3", "yan4", "zui5"});
                    yield return _gameMethods.ExecuteCharacterImageData("c_qian");
                    yield return _gameMethods.OpenDialog(5331); // "「父亲他言而无信，的确有违皇室的风范……{nw}{w=0.2}"
                    yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei3", "yan2", "zui7"});
                    yield return _gameMethods.ExecuteCharacterImageData("c_qian");
                    yield return _gameMethods.OpenDialog(5332); // "可是成为公主，为王国做出贡献，难道不是无上的荣誉吗？」"
                    yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei3", "yan6", "zui8"});
                    yield return _gameMethods.OpenDialog(5333); // "这人逻辑太过自洽，让我反倒有些好奇了。"
                    yield return _gameMethods.StopSound(channelName:"music1", fadeOut:2f);
                    yield return _gameMethods.ExecuteCharacterImageData("nv2");
                    yield return _gameMethods.OpenDialog(5334); // "那么，为什么你不愿意被带走呢？"
                    yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.5>audio/demo_audio/sound/jiaobusheng_nv_liangbuzou_gaogen_diban.mp3");
                    yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei3", "yan7", "zui7"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.3f}, {"zpos", 40f}})});
                    yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/music/end/nvwang/desperation.mp3");
                    yield return _gameMethods.ExecuteCharacterImageData("c");
                    yield return _gameMethods.OpenDialog(5335); // "谁说我不愿意！"
                    yield return _gameMethods.Show("gongzhu_layered", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 40f}})});
                    yield return _gameMethods.ExecuteCharacterImageData("c");
                    yield return _gameMethods.OpenDialog(5336); // "认定的人选本就是我，只是父亲改变主意，才换成了你。"
                    yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei3", "yan7", "zui8"});
                    yield return _gameMethods.ExecuteCharacterImageData("nv2");
                    yield return _gameMethods.OpenDialog(5337); // "那可真是太遗憾了。"
                    yield return _gameMethods.ExecuteCharacterImageData("nv2");
                    yield return _gameMethods.OpenDialog(5338); // "你们彼此父慈女孝，与我无关。"
                    yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.5>audio/demo_audio/sound/jiaobusheng_nv_liangbuzou_gaogen_diban.mp3");
                    yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei3", "yan4", "zui5"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.3f}, {"zpos", 60f}})});
                    yield return _gameMethods.ExecuteCharacterImageData("c");
                    yield return _gameMethods.OpenDialog(5339); // "你——！"
                    yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei3", "yan4", "zui9"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 60f}})});
                    yield return _gameMethods.OpenDialog(5340); // "公主似乎被我冷漠的态度所刺激到，用剑尖对准了我。"
                    yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei3", "yan6", "zui7"});
                    yield return _gameMethods.ExecuteCharacterImageData("c");
                    yield return _gameMethods.OpenDialog(5341); // "我……我还以为我有了姐姐……！"
                    yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei3", "yan6", "zui8"});
                    if (Defaults.Bai_xue == 1)
                    {
                                                yield return _gameMethods.PlaySound("sounda", 0.0f, 4f, "audio/sound/manbu/Body1_02_duan.mp3");
                        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei8", "yan13", "zui13"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 60.0f}, {"pos", new Vector2(-18f, 1518f)}, {"zoom", 0.45f}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}, {"blur", 0.1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1f}, {"blur", 0f}})});
                        yield return _gameMethods.ExecuteCharacterImageData("nuo");
                        yield return _gameMethods.OpenDialog(5342); // "这戏码好拖沓，我有点厌烦了。"
                        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei8", "yan13", "zui8"});
                        yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei3", "yan5", "zui8"});
                        yield return _gameMethods.OpenDialog(5343); // "旁边的诺伯拉突然出声说。"
                        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}, {"blur", 0f}})});
                        yield return _gameMethods.OpenDialog(5344); // "他无聊地支着腮。"
                        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
                        yield return _gameMethods.ExecuteCharacterImageData("nuo");
                        yield return _gameMethods.OpenDialog(5345); // "小公主，需要我帮忙解决吗？"
                        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1>audio/sound/jiaobusheng_an_normal1.ogg");
                        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei8", "yan5", "zui7"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 60.0f}, {"pos", new Vector2(582f, 1506f)}, {"zoom", 0.35f}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}, {"blur", 0.1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1f}, {"blur", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 50f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.7f}, {"xoffset", 0f}})});
                        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
                        yield return _gameMethods.ExecuteCharacterImageData("luo");
                        yield return _gameMethods.OpenDialog(5346); // "我也随时可以出手。"
                        yield return _gameMethods.Show("luo2", parts: new List<string>{"mei8", "yan5", "zui1"});
                        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
                        if (Defaults.Qigai == 1)
                        {
                                                        yield return _gameMethods.Show("xiya", parts: new List<string>{"mei2", "yan6", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 60.0f}, {"pos", new Vector2(1020f, 1548f)}, {"zoom", 0.4f}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}, {"blur", 0.1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1f}, {"blur", 0f}})});
                            yield return _gameMethods.ExecuteCharacterImageData("q1");
                            yield return _gameMethods.OpenDialog(5034); // "……"
                            yield return _gameMethods.OpenDialog(5347); // "一旁的席亚则沉默地盯着我。"
                            yield return _gameMethods.Show("xiya", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}, {"alpha", 1f}})});
                            yield return _gameMethods.Show("xiya", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"blur", 4f}})});

                        }
                        yield return _gameMethods.PlaySound("sounda1", 0.0f, 1.0f, "audio/demo_audio/sound/zhenjing_shuaidaoganjue.mp3");
                        yield return _gameMethods.Show("npc_guowang", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"blur", 4f}})});
                        yield return _gameMethods.Show("jieju2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"blur", 4f}})});
                        yield return _gameMethods.Show("nuo1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"blur", 4f}})});
                        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 63.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.6f}, {"zpos", 180.0f}})});
                        yield return _gameMethods.Show("luo2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"alpha", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"blur", 4f}})});
                        yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan4", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 60.0f}, {"pos", new Vector2(606f, 1944f)}, {"zoom", 0.47f}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}, {"blur", 0.1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"alpha", 1f}, {"blur", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"xoffset", -3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0f}})});
                        yield return _gameMethods.ExecuteCharacterImageData("an");
                        yield return _gameMethods.OpenDialog(5348); // "……？！"
                        yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan9", "zui1"});
                        Engine._history = false;
                        yield return _gameMethods.OpenDialog(5044); // "{nw}{w=0.15}"
                        Engine._history = true;
                        yield return _gameMethods.Show("an2", parts: new List<string>{"mei8", "yan14", "zui1"});
                        yield return _gameMethods.OpenDialog(5349); // "安德鲁露出一副被抢了先的愕然，"
                        yield return _gameMethods.Show("an2", parts: new List<string>{"mei10", "yan8", "zui3"});
                        yield return _gameMethods.ExecuteCharacterImageData("an");
                        yield return _gameMethods.OpenDialog(5350); // "立刻也双眼睁大、炯炯有神地看向我，坚定地表达出自己的立场。"
                        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 180.0f}})});
                        yield return _gameMethods.Show("an2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}, {"blur", 0f}, {"xoffset", 0f}, {"yoffset", 0f}})});
                        yield return _gameMethods.OpenDialog(5351); // "我摇摇头，接着对公主说。"

                    }
                    yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/jieju/jieju2.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.78f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 1.73f}})});
                    yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", -42f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
                    yield return _gameMethods.Show("gongzhu_layered", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(576f, 1458f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 0.0f}, {"zoom", 0.58f}})});
                    yield return _gameMethods.Transition(time:0.6f);
                    yield return _gameMethods.ExecuteCharacterImageData("nv2");
                    yield return _gameMethods.OpenDialog(5352); // "你不如看看自己的身后。"
                    yield return _gameMethods.PlaySound("sounda1", 0.0f, 0.4f, "audio/sound/moca1.ogg");
                    yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei1", "yan4", "zui9"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"xoffset", -3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0f}})});
                    yield return _gameMethods.ExecuteCharacterImageData("c");
                    yield return _gameMethods.OpenDialog(5353); // "……！？"
                    yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei3", "yan5", "zui9"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
                    yield return _gameMethods.OpenDialog(5354); // "她似乎有一刻的动摇，"
                    yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei3", "yan2", "zui8"});
                    yield return _gameMethods.ExecuteCharacterImageData("c");
                    yield return _gameMethods.OpenDialog(5355); // "但很快反应过来，{nw}{w=0.2}"
                    yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei3", "yan6", "zui8"});
                    yield return _gameMethods.ExecuteCharacterImageData("c");
                    yield return _gameMethods.OpenDialog(5356); // "怀疑有诈，仍紧紧盯着我。"
                    yield return _gameMethods.OpenDialog(5357); // "有警惕心是好事，不过——"
                    yield return _gameMethods.ExecuteCharacterImageData("nv2");
                    yield return _gameMethods.OpenDialog(5358); // "你忘了么，我是名魔法师。"
                    yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei3", "yan3", "zui9"});
                    yield return _gameMethods.PlaySound("sounda", 0.0f, 0.5f, "audio/sound/houhui/Bones Break Cracking_01.ogg");
                    yield return _gameMethods.OpenDialog(5359); // "国王已经被吓到窒息，此刻面色发白，休克了过去。"
                    yield return _gameMethods.PlaySound("sound", 0.0f, 2f, "audio/sound/manbu/Body1_02_duan.mp3");
                    yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei3", "yan5", "zui8", "emoji1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"blur", 0.1f}, {"alpha", 0f}})});
                    yield return _gameMethods.OpenDialog(5360); // "公主悚然一惊，下意识地转回头看。"
                    yield return _gameMethods.PlaySound("sounda1", 0.0f, 1.0f, "audio/sound/manbu/Body1_01.mp3");
                    yield return _gameMethods.Show("an2", parts: new List<string>{"mei8", "yan12", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(576f, 2034f)}, {"zoom", 0.45f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0.1f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.2f}, {"alpha", 1f}, {"blur", 0f}})});
                    yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.40f}, {"zpos", 78.0f}})});
                    yield return _gameMethods.PlaySound("sounda5", 0.0f, 1.0f, "audio/sound/he/houjin.mp3");
                    yield return _gameMethods.OpenDialog(5361); // "就在她转身的一瞬间，安德鲁反手用剑柄一敲她的后颈。她身子一僵，软软倒地。"
                    yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei3", "yan5", "zui8", "-emoji1"});
                    yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.5>audio/sound/jiaobusheng_an_normal1.ogg");
                    yield return _gameMethods.Hide("gongzhu_layered");
                    yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan2", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}, {"blur", 0f}})});
                    yield return _gameMethods.Show("luo2", parts: new List<string>{"mei8", "yan5", "zui7"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(990f, 2004f)}, {"zoom", 0.45f}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 0.1f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"alpha", 1f}, {"blur", 0f}})});
                    yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", -42f}, {"zpos", 78.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"xpos", 186f}})});
                    Engine._history = false;
                    yield return _gameMethods.OpenDialog(5362); // "{nw}{w=0.2}"
                    Engine._history = true;
                    yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui1"});
                    yield return _gameMethods.ExecuteCharacterImageData("luo");
                    yield return _gameMethods.OpenDialog(5363); // "为什么对她手下留情？"
                    yield return _gameMethods.Show("luo2", parts: new List<string>{"mei8", "yan5", "zui1"});
                    yield return _gameMethods.OpenDialog(5364); // "洛恩问我。"
                    yield return _gameMethods.Show("luo2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}, {"blur", 0f}})});
                    yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 186f}})});
                    yield return _gameMethods.OpenDialog(5365); // "的确，在军力占有压倒性优势的情况下，我陪她浪费了如此多时间，算是相当优容了。"
                    yield return _gameMethods.Show("luo2", parts: new List<string>{"mei8", "yan9", "zui1"});
                    yield return _gameMethods.OpenDialog(5366); // "想必安德鲁也是看出了这一点，所以才只敲晕了公主。"
                    yield return _gameMethods.ExecuteCharacterImageData("nv2");
                    yield return _gameMethods.OpenDialog(5367); // "还可以，不是原则性问题。"
                    yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan2", "zui1"});
                    yield return _gameMethods.OpenDialog(5368); // "我平静地说。"
                    Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 2;
                    if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
                    {
                                                
                                        _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
                                        _gameMethods.SyncAchievement();

                    }
                    Defaults.Haogandu_an = Defaults.Haogandu_an + 3;
                    yield return _gameMethods.ExecuteCharacterImageData("nv2");
                    yield return _gameMethods.OpenDialog(5369); // "我觉得她是工作经验太少，之后给她安排个班上吧。"
                    yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan2", "zui1"});
                    yield return _gameMethods.Show("luo2", parts: new List<string>{"mei8", "yan12", "zui1"});
                    Engine._history = false;
                    yield return _gameMethods.OpenDialog(5044); // "{nw}{w=0.15}"
                    Engine._history = true;
                    yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan1", "zui1"});
                    yield return _gameMethods.Show("luo2", parts: new List<string>{"mei8", "yan2", "zui1"});
                    yield return _gameMethods.OpenDialog(5370); // "这就是多年上班带给我的情绪稳定。"
                    yield return _gameMethods.Show("luo2", parts: new List<string>{"mei4", "yan11", "zui12"});
                    yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei11", "yan2", "zui15"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.6f}, {"pos", new Vector2(-288f, 2076f)}})});
                    yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"xpos", -120f}, {"zpos", 396.0f}})});
                    yield return _gameMethods.Transition(time:0.5f);
                    yield return _gameMethods.Show("luo2", parts: new List<string>{"mei8", "yan5", "zui8"});
                    yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei11", "yan7", "zui8"});
                    yield return _gameMethods.ExecuteCharacterImageData("nuo");
                    yield return _gameMethods.OpenDialog(5371); // "噗……"
                    yield return _gameMethods.Show("an2", parts: new List<string>{"mei5", "yan16", "zui12", "emoji8"});
                    yield return _gameMethods.ExecuteCharacterImageData("an_luo");
                    yield return _gameMethods.OpenDialog(5034); // "……"
                    yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan13", "zui16", "-emoji8"});
                    yield return _gameMethods.ExecuteCharacterImageData("nv2");
                    yield return _gameMethods.OpenDialog(5372); // "她们父女两个先分别囚禁，稍后再处理。"
                    yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan15"});
                    yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
                    yield return _gameMethods.ExecuteCharacterImageData("nv2");
                    yield return _gameMethods.OpenDialog(5373); // "——走吧。"
                    yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui16"});
                    yield return _gameMethods.ExecuteCharacterImageData("nv2");
                    yield return _gameMethods.OpenDialog(5374); // "该该去和官员商议一下加冕仪式了。"
                    yield return _gameMethods.StopSound(channelName:"music", fadeOut:4f);
                    yield return _gameMethods.SceneBlack(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.3f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 1.14f}})});
                    yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
                    yield return _gameMethods.Transition(time:0.8f);
                    yield return _gameMethods.ChangeLabelTo("label_end7_1");

                }
                if (Defaults.Wangzixian == 1)
                {
                                        yield return _gameMethods.StopSound(channelName:"music1", fadeOut:4f);
                    yield return _gameMethods.ExecuteCharacterImageData("s_wen");
                    yield return _gameMethods.OpenDialog(5375); // "……请等一等。"
                    yield return _gameMethods.PlaySound("sound", 0.0f, 0.5f, "<from 0 to 2>audio/sound/jiaobusheng_nuo_kuai1.ogg");
                    yield return _gameMethods.OpenDialog(5376); // "一道温和急切的声音响起，{nw}{w=0.1}"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan9", "zui15", "emoji2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(282f, 1488f)}, {"zoom", 0.364f}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}, {"blur", 0.1f}, {"zpos", 18f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1f}, {"blur", 0f}})});
                    yield return _gameMethods.ExecuteCharacterImageData("s_wen");
                    yield return _gameMethods.OpenDialog(5377); // "王子出现在了视野里。"
                    yield return _gameMethods.Show("wangzi", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}, {"blur", 0f}})});
                    yield return _gameMethods.ExecuteCharacterImageData("nv2");
                    yield return _gameMethods.OpenDialog(5378); // "看来你平安回来了。"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan5", "zui1", "-emoji2"});
                    Engine._history = false;
                    yield return _gameMethods.ExecuteCharacterImageData("s_qian");
                    yield return _gameMethods.OpenDialog(5044); // "{nw}{w=0.15}"
                    Engine._history = true;
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan13", "zui9", "emoji1"});
                    yield return _gameMethods.ExecuteCharacterImageData("s");
                    yield return _gameMethods.OpenDialog(5379); // "托您的福。"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan13", "zui13", "emoji1"});
                    yield return _gameMethods.OpenDialog(5380); // "他走向我，"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan22", "zui2", "-emoji1"});
                    yield return _gameMethods.ExecuteCharacterImageData("s");
                    yield return _gameMethods.OpenDialog(5381); // "路过狼狈跌坐在地上的国王时，脚步顿了顿，垂眸瞥了他一眼。"
                    yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1.4>audio/sound/jiaobusheng_nuo_kuai1.ogg");
                    yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/jieju/jieju2.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.80f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 1.66f}})});
                    yield return _gameMethods.Show("npc_guowang", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 20f}, {"pos", new Vector2(390f, 1008f)}, {"alpha", 0f}, {"blur", 0.1f}})});
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(636f, 2076f)}, {"zoom", 0.47f}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 40f}})});
                    yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
                    yield return _gameMethods.TransitionBy("blink2");
                    yield return _gameMethods.OpenDialog(5382); // "便匆匆跨过剩下两步，来至我面前。"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei3", "yan9", "zui2"});
                    yield return _gameMethods.ExecuteCharacterImageData("s");
                    yield return _gameMethods.OpenDialog(5034); // "……"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei12", "yan19", "zui3"});
                    yield return _gameMethods.OpenDialog(5383); // "难以启齿般地沉默了一阵，他最终艰难地开口。"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei12", "yan19", "zui15"});
                    yield return _gameMethods.ExecuteCharacterImageData("s");
                    yield return _gameMethods.OpenDialog(5384); // "能不能，饶他一命呢？"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan9", "zui6"});
                    yield return _gameMethods.ExecuteCharacterImageData("s");
                    yield return _gameMethods.OpenDialog(5385); // "我是说，他至少是你血缘上的生父，如果留他一条命，至少可以别弄脏你的手。"
                    yield return _gameMethods.PlaySound("music", 0.0f, 0.8f, "audio/music/end/nvwang/Umwelt.mp3");
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan9", "zui4"});
                    yield return _gameMethods.OpenDialog(5386); // "……这还真是在预料之内，情理之中啊。"
                    yield return _gameMethods.ExecuteCharacterImageData("nv2");
                    yield return _gameMethods.OpenDialog(5387); // "我不想同你多争辩，但异地而处，你站在我这个位置，难道能装作什么都没发生过吗？"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan5", "zui1"});
                    yield return _gameMethods.ExecuteCharacterImageData("s_qian");
                    yield return _gameMethods.OpenDialog(5388); // "「……{nw}{w=0.2}"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan18", "zui3", "emoji0"});
                    yield return _gameMethods.ExecuteCharacterImageData("s_qian");
                    yield return _gameMethods.OpenDialog(5389); // "……」"
                    yield return _gameMethods.ExecuteCharacterImageData("nv2");
                    yield return _gameMethods.OpenDialog(5390); // "——况且。"
                    yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_portrait/npc/npc_guowang.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1f}})});
                    yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 1.26f}, {"xpos", -138f}})});
                    yield return _gameMethods.OpenDialog(5391); // "我将剑尖偏移，再次对准不老实地试图偷偷爬走的国王，{nw}{w=0.01}"
                    yield return _gameMethods.PlaySound("sound", 0.2f, 0.4f, "audio/demo_audio/sound/moca2.mp3");
                    yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_portrait/npc/npc_guowang.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.41f}, {"ypos", 1056f}, {"zpos", 0.0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"xoffset", -3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0f}})}, parallel_2: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0f}})});
                    yield return _gameMethods.ExecuteCharacterImageData("nv2");
                    yield return _gameMethods.OpenDialog(5392); // "吓得他一屁股坐在地上。"
                    yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", -138f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 1.26f}, {"xpos", 0f}})});
                    yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_portrait/npc/npc_guowang.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 1056f}, {"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 0f}})});
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei10", "yan9", "zui3", "-emoji0"});
                    yield return _gameMethods.ExecuteCharacterImageData("nv2_qian");
                    yield return _gameMethods.OpenDialog(5393); // "「看到了吧。对于一些人，你好声好气同他理论，他也许会忏悔，"
                    yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_portrait/npc/npc_guowang.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}})});
                    yield return _gameMethods.ExecuteCharacterImageData("nv2_qian");
                    yield return _gameMethods.OpenDialog(5394); // "可你把刀架在他的脖子上，他一定会忏悔。」"
                    yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_portrait/npc/npc_guowang.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.9f}, {"alpha", 1f}})});
                    yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 1.26f}, {"xpos", -138f}})});
                    yield return _gameMethods.OpenDialog(5395); // "我望向国王，他正发着抖。"
                    yield return _gameMethods.OpenDialog(5396); // "我微笑起来，感觉到一种扭曲的快意。"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei10", "yan2", "zui3"});
                    yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_portrait/npc/npc_guowang.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
                    yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", -138f}})});
                    Engine._history = false;
                    yield return _gameMethods.ExecuteCharacterImageData("nv2_qian");
                    yield return _gameMethods.OpenDialog(5044); // "{nw}{w=0.15}"
                    Engine._history = true;
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei10", "yan9", "zui3"});
                    yield return _gameMethods.ExecuteCharacterImageData("nv2");
                    yield return _gameMethods.OpenDialog(5397); // "可是需要他愧疚与道歉的人已经不在了。"
                    yield return _gameMethods.ExecuteCharacterImageData("nv2");
                    yield return _gameMethods.OpenDialog(5398); // "我能做的，就是送他去地下，面向她忏悔。"
                    if (Defaults.He_hen == 1)
                    {
                                                yield return _gameMethods.OpenDialog(5399); // "毕竟，那么多人都已经死了。他凭什么却能好好活着呢？"

                    }
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei10", "yan13", "zui6"});
                    yield return _gameMethods.ExecuteCharacterImageData("s_qian");
                    yield return _gameMethods.OpenDialog(5400); // "「……{nw}{w=0.4}"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei6", "yan19", "zui3"});
                    yield return _gameMethods.ExecuteCharacterImageData("s_qian");
                    yield return _gameMethods.OpenDialog(5401); // "……{nw}{w=0.6}"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan18", "zui3"});
                    yield return _gameMethods.ExecuteCharacterImageData("s_qian");
                    yield return _gameMethods.OpenDialog(5389); // "……」"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei6", "yan2", "zui2"});
                    Engine._history = false;
                    yield return _gameMethods.OpenDialog(5044); // "{nw}{w=0.15}"
                    Engine._history = true;
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei3", "yan9", "zui3"});
                    yield return _gameMethods.OpenDialog(5402); // "王子的嘴巴几度开合，再次出声时，声音已重新变得镇定冷静。"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei3", "yan9", "zui6"});
                    yield return _gameMethods.ExecuteCharacterImageData("s");
                    yield return _gameMethods.OpenDialog(5403); // "如果你要当女王，你就不能这样处置他。"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei3", "yan9", "zui2"});
                    yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", -138f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 1.26f}, {"xpos", 0f}})});
                    yield return _gameMethods.OpenDialog(5404); // "我看着他。"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan13", "zui6"});
                    yield return _gameMethods.ExecuteCharacterImageData("s");
                    yield return _gameMethods.OpenDialog(5405); // "因为世上没有不透风的墙，而每一个为人父母的国民，都无法拥戴一名这样对待自己父亲的女儿。"
                    yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}})});
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan13", "zui3"});
                    yield return _gameMethods.ExecuteCharacterImageData("nv2");
                    yield return _gameMethods.OpenDialog(5406); // "哦。所以，你现在要威胁我了？"
                    yield return _gameMethods.ExecuteCharacterImageData("nv2");
                    yield return _gameMethods.OpenDialog(5407); // "你难道真觉得我很在乎这个王座吗？"
                    yield return _gameMethods.OpenDialog(5408); // "看来王子选择了站在国王那边。"
                    yield return _gameMethods.OpenDialog(5409); // "我决定摒弃掉心头对他所残存的那些许情谊，以一种看待敌人的眼光来对待他。"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan9", "zui2"});
                    yield return _gameMethods.OpenDialog(5410); // "不知为何，接触到我冷嘲目光的瞬间，"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan4", "zui3"});
                    yield return _gameMethods.ExecuteCharacterImageData("nv2");
                    yield return _gameMethods.OpenDialog(5411); // "他仿佛被刺伤了，蓦地慌了神。"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei6", "yan3", "zui18", "emoji0"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"xoffset", -3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0f}})});
                    yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/moca1.ogg");
                    yield return _gameMethods.ExecuteCharacterImageData("s");
                    yield return _gameMethods.OpenDialog(5412); // "我没有这样想！"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei6", "yan3", "zui4", "emoji0"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
                    yield return _gameMethods.ExecuteCharacterImageData("nv2");
                    yield return _gameMethods.OpenDialog(5034); // "……"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei6", "yan4", "zui1", "emoji1", "-emoji0"});
                    yield return _gameMethods.OpenDialog(5413); // "喊出口后，他宛若意识到了自己的失态，{nw}{w=0.01}"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei6", "yan19", "zui4", "-emoji1", "emoji0"});
                    yield return _gameMethods.ExecuteCharacterImageData("nv2");
                    yield return _gameMethods.OpenDialog(5414); // "定了定神，抿了下唇。"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei10", "yan13", "zui4", "emoji0"});
                    yield return _gameMethods.OpenDialog(5415); // "王子迎着我冷漠的表情，表情万分苦涩。"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei12", "yan2", "zui6", "-emoji0"});
                    yield return _gameMethods.ExecuteCharacterImageData("s_qian");
                    yield return _gameMethods.OpenDialog(5416); // "「……他对不起你，我知道。{nw}{w=0.2}"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei12", "yan19", "zui6"});
                    yield return _gameMethods.ExecuteCharacterImageData("s_qian");
                    yield return _gameMethods.OpenDialog(5417); // "我只是想说……」"
                    yield return _gameMethods.ExecuteCharacterImageData("s_qian");
                    yield return _gameMethods.OpenDialog(5418); // "「如果非这样不可，那么……{nw}{w=0.2}"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei12", "yan13", "zui6"});
                    yield return _gameMethods.ExecuteCharacterImageData("s_qian");
                    yield return _gameMethods.OpenDialog(5419); // "让我来。」"
                    yield return _gameMethods.PlaySound("sound", 0.0f, 2f, "audio/sound/manbu/Body1_02_duan.mp3");
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei10", "yan9", "zui6"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 40.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.90f}, {"zpos", 58.0f}})});
                    yield return _gameMethods.ExecuteCharacterImageData("s");
                    yield return _gameMethods.OpenDialog(5420); // "我替你动手，好吗？"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei10", "yan9", "zui4"});
                    yield return _gameMethods.ExecuteCharacterImageData("nv2");
                    yield return _gameMethods.OpenDialog(5034); // "……"
                    yield return _gameMethods.Show("wangzi", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 58.0f}})});
                    yield return _gameMethods.OpenDialog(5421); // "这个回答出乎了我的预料，我愣住了。"
                    yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/demo_audio/sound/zhenjing_shuaidaoganjue.mp3");
                    yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_portrait/npc/npc_guowang.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"xoffset", -3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0f}})});
                    yield return _gameMethods.ExecuteCharacterImageData("a");
                    yield return _gameMethods.OpenDialog(5422); // "混账！你——……"
                    yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_portrait/npc/npc_guowang.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
                    yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 1.26f}, {"xpos", -138f}})});
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan18", "zui4"});
                    yield return _gameMethods.OpenDialog(5423); // "我眯起眼睛，再次向国王投去了严厉的一瞥，"
                    yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_portrait/npc/npc_guowang.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 390f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.69f}, {"xpos", 400f}})});
                    yield return _gameMethods.ExecuteCharacterImageData("a");
                    yield return _gameMethods.OpenDialog(5424); // "后者瞬间噤声。"
                    yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_portrait/npc/npc_guowang.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 400f}})});
                    yield return _gameMethods.OpenDialog(5425); // "难道他是要拖延时间，借此把国王捞到手里，然后偷偷放了他？"
                    yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", -138f}})});
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei10", "yan2", "zui4"});
                    yield return _gameMethods.OpenDialog(5426); // "我的心中还在思考，王子深吸了口气，{nw}{w=0.2}"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei10", "yan9", "zui4"});
                    yield return _gameMethods.ExecuteCharacterImageData("a");
                    yield return _gameMethods.OpenDialog(5427); // "继续对我说。"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei12", "yan13", "zui6"});
                    yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", -138f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 1.26f}, {"xpos", 0f}})});
                    yield return _gameMethods.ExecuteCharacterImageData("s_qian");
                    yield return _gameMethods.OpenDialog(5428); // "「父亲他做了错事，{nw}{w=0.2}"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei12", "yan18", "zui5"});
                    yield return _gameMethods.ExecuteCharacterImageData("s_qian");
                    yield return _gameMethods.OpenDialog(5429); // "我和妹妹同样对你有愧。{nw}{w=0.2}"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei10", "yan2", "zui7"});
                    yield return _gameMethods.ExecuteCharacterImageData("s_qian");
                    yield return _gameMethods.OpenDialog(5430); // "/n如今你想这样做，于情于理，我无话可说。」"
                    yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}})});
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei12", "yan9", "zui7"});
                    yield return _gameMethods.ExecuteCharacterImageData("s");
                    yield return _gameMethods.OpenDialog(5431); // "但若想当女王，你不宜亲自做。"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei4", "yan13", "zui7"});
                    yield return _gameMethods.ExecuteCharacterImageData("s");
                    yield return _gameMethods.OpenDialog(5432); // "至少……不该直接做。"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei4", "yan13", "zui3"});
                    yield return _gameMethods.ExecuteCharacterImageData("nv2");
                    yield return _gameMethods.OpenDialog(5034); // "……"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan19", "zui6"});
                    yield return _gameMethods.ExecuteCharacterImageData("s_qian");
                    yield return _gameMethods.OpenDialog(5433); // "「我……是一个无能的继承者，不称职的兄长和儿子。{nw}{w=0.2}"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei12", "yan2", "zui7"});
                    yield return _gameMethods.ExecuteCharacterImageData("s_qian");
                    yield return _gameMethods.OpenDialog(5434); // "/n本该保护你和琶菈丝，却没能做到。」"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei11", "yan13", "zui11", "emoji0", "emoji10"});
                    yield return _gameMethods.ExecuteCharacterImageData("s");
                    yield return _gameMethods.OpenDialog(5435); // "就让我履行兄长的职责，为自己的无能负责吧。"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei11", "yan13", "zui13", "emoji0", "emoji10"});
                    yield return _gameMethods.ExecuteCharacterImageData("nv2");
                    yield return _gameMethods.OpenDialog(5034); // "……"
                    yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/zhenjing_shuaidaoganjue.mp3");
                    yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_portrait/npc/npc_guowang.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"xoffset", -3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0f}})});
                    yield return _gameMethods.ExecuteCharacterImageData("a");
                    yield return _gameMethods.OpenDialog(5436); // "你——……你要对你的亲生父亲做什么？！你可是我的儿子！"
                    yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_portrait/npc/npc_guowang.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
                    yield return _gameMethods.OpenDialog(5437); // "国王的嗓音透露些许恐慌，毫无体面地嚷嚷起来。"
                    yield return _gameMethods.OpenDialog(5438); // "在这略显聒噪的背景音中，我和他都置若罔闻，只是安静地对视着。"
                    yield return _gameMethods.OpenDialog(5439); // "我面无表情。"
                    yield return _gameMethods.ExecuteCharacterImageData("nv2");
                    yield return _gameMethods.OpenDialog(5440); // "亲自动手，你会染上污点，自动失去继承权，遭人批评。"
                    yield return _gameMethods.ExecuteCharacterImageData("nv2");
                    yield return _gameMethods.OpenDialog(5441); // "就算如此，你也无法取信于我，得不到新王重用。"
                    yield return _gameMethods.ExecuteCharacterImageData("nv2");
                    yield return _gameMethods.OpenDialog(5442); // "而且，我从没承认你是兄长。"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei2", "yan5", "zui2", "emoji1", "emoji10", "-emoji0"});
                    yield return _gameMethods.ExecuteCharacterImageData("s_qian");
                    yield return _gameMethods.OpenDialog(5388); // "「……{nw}{w=0.2}"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan21", "zui4", "emoji1", "emoji10"});
                    yield return _gameMethods.ExecuteCharacterImageData("s_qian");
                    yield return _gameMethods.OpenDialog(5389); // "……」"
                    yield return _gameMethods.OpenDialog(5443); // "王子没有回答。/n他微微垂头，银发遮眼，看不清神色。"
                    yield return _gameMethods.StopSound(channelName:"music", fadeOut:4f);
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei12", "yan21", "zui4"});
                    yield return _gameMethods.OpenDialog(5444); // "良久，他低低地“嗯”了一声。"
                    yield return _gameMethods.PlaySound("sound", 0.0f, 4f, "audio/sound/manbu/Body1_02_duan.mp3");
                    yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/jieju/jieju2.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.65f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 1.66f}})});
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei12", "yan2", "zui3", "-emoji1", "-emoji10"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(636f, 1704f)}, {"zoom", 0.38f}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 40f}})});
                    yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
                    yield return _gameMethods.TransitionBy("blink2");
                    yield return _gameMethods.OpenDialog(5445); // "宛若做出了觉悟，青年撩开披风，单膝下跪。"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei12", "yan21", "zui3"});
                    yield return _gameMethods.ExecuteCharacterImageData("s_qian");
                    yield return _gameMethods.OpenDialog(5446); // "/n他压低了脖颈与头颅，卸掉腰间的佩剑，将其横举过头顶。"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei12", "yan21", "zui6"});
                    yield return _gameMethods.ExecuteCharacterImageData("s");
                    yield return _gameMethods.OpenDialog(5447); // "我主。"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei12", "yan21", "zui3"});
                    yield return _gameMethods.PlaySound("music1", 0.0f, 0.6f, "audio/music/wangzi/maou_bgm_piano_song_ahurera.mp3");
                    yield return _gameMethods.OpenDialog(5448); // "他尊敬地呼唤我道。"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei12", "yan21", "zui6"});
                    yield return _gameMethods.ExecuteCharacterImageData("s");
                    yield return _gameMethods.OpenDialog(5449); // "臣下……乃我主之骑士。/n领有采邑之家臣。"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei12", "yan2", "zui7"});
                    yield return _gameMethods.ExecuteCharacterImageData("s");
                    yield return _gameMethods.OpenDialog(5450); // "臣下愿竭忠尽智，不顾生死，/n终我一生，以侍奉我主。"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei12", "yan21", "zui3"});
                    yield return _gameMethods.OpenDialog(5451); // "这是典礼仪式中，骑士对自己所效忠的领主行臣服礼时的誓词。他一字一句，宣誓完毕，自下往上，恭谨地呈上长剑。"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei10", "yan13", "zui13"});
                    yield return _gameMethods.OpenDialog(5452); // "温和俊秀的面容上，那双象征王室血脉的黄金色的星状眼瞳，在剑身后微微抬起，以低微的姿态，顺从而谦卑、痛苦并决绝地朝我望来。"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei10", "yan9", "zui10"});
                    yield return _gameMethods.ExecuteCharacterImageData("s");
                    yield return _gameMethods.OpenDialog(5453); // "陛下，请对我下令吧。"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei10", "yan14", "zui10"});
                    yield return _gameMethods.ExecuteCharacterImageData("s_qian");
                    yield return _gameMethods.OpenDialog(5454); // "「就算这把剑脏了后，{nw}{w=0.01}"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei10", "yan2", "zui10"});
                    yield return _gameMethods.ExecuteCharacterImageData("s_qian");
                    yield return _gameMethods.OpenDialog(5044); // "{nw}{w=0.15}"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei10", "yan13", "zui12", "emoji1", "emoji0"});
                    yield return _gameMethods.ExecuteCharacterImageData("s_qian");
                    yield return _gameMethods.OpenDialog(5455); // "丢弃也无所谓。」"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei10", "yan13", "zui14"});
                    yield return _gameMethods.ExecuteCharacterImageData("nv2");
                    yield return _gameMethods.OpenDialog(5034); // "……"
                    yield return _gameMethods.OpenDialog(5456); // "我低头打量着王子，下意识地思考起他的行为背后的动机。"
                    yield return _gameMethods.OpenDialog(5457); // "我想……王子很聪明。"
                    yield return _gameMethods.OpenDialog(5458); // "大局已定，我的夺权已是他无法抗衡的结果，所以他迅速向我投诚。"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei10", "yan2", "zui14", "-emoji1", "-emoji0"});
                    Engine._history = false;
                    yield return _gameMethods.OpenDialog(5044); // "{nw}{w=0.15}"
                    Engine._history = true;
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei10", "yan13", "zui13", "emoji1", "emoji0"});
                    yield return _gameMethods.OpenDialog(5459); // "这样也许还能保全他、他的母亲，以及妹妹。"
                    yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei10", "yan19", "zui13", "-emoji1", "emoji0"});
                    yield return _gameMethods.ExecuteCharacterImageData("nv2");
                    yield return _gameMethods.OpenDialog(5460); // "/n不过，他的顺服、祈求，和诚恳的话语都把握的恰到好处，让我有些被打动了。"
                    yield return _gameMethods.OpenDialog(5461); // "最重要的是，他的提议对我没有坏处。"
                    yield return _gameMethods.OpenDialog(5462); // "更确切来说，是有利无弊。"

                }

    }

    public IEnumerator label_end6_menu_1_oC2kVn80()
    {
                yield return _gameMethods.ExecuteCharacterImageData("nv2");
                        yield return _gameMethods.OpenDialog(5463); // "好啊。"
                        yield return _gameMethods.PlaySound("sound", 0.2f, 0.4f, "audio/demo_audio/sound/moca2.mp3");
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan4", "zui3", "-emoji0"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"xoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0f}})});
                        yield return _gameMethods.ExecuteCharacterImageData("s");
                        yield return _gameMethods.OpenDialog(5234); // "……！"
                        yield return _gameMethods.Show("wangzi", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
                        yield return _gameMethods.OpenDialog(5465); // "王子瞬间抬头仰视着我。"
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan2", "zui3"});
                        Engine._history = false;
                        yield return _gameMethods.OpenDialog(5044); // "{nw}{w=0.15}"
                        Engine._history = true;
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan4", "zui3"});
                        yield return _gameMethods.OpenDialog(5466); // "他的金瞳中翻滚着剧烈的情绪。一时间，那副表情在我眼中有些难以言喻，仿若似喜非喜，悲喜交加。"
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei3", "yan21", "zui3", "emoji0"});
                        yield return _gameMethods.OpenDialog(5467); // "不过很快，他敛去了这些神色，恢复了沉寂，等待着我的旨意。"
                        yield return _gameMethods.ShowBlack(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 40f}, {"pos", new Vector2(708f, 924f)}, {"zoom", 1.18f}})});
                        yield return _gameMethods.Transition(time:0.6f);
                        yield return _gameMethods.OpenDialog(5468); // "我取走了他手里的剑，以剑敲一敲他的肩头。"
                        yield return _gameMethods.HideBlack();
                        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"ypos", -126f}, {"zpos", -270f}})});
                        yield return _gameMethods.Transition(time:0.6f);
                        yield return _gameMethods.OpenDialog(5469); // "……然后，停住了。"
                        yield return _gameMethods.ExecuteCharacterImageData("nv2");
                        yield return _gameMethods.OpenDialog(5034); // "……"
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei3", "yan2", "zui3", "-emoji0"});
                        Engine._history = false;
                        yield return _gameMethods.OpenDialog(5044); // "{nw}{w=0.15}"
                        Engine._history = true;
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei3", "yan21", "zui3", "-emoji0"});
                        yield return _gameMethods.OpenDialog(5470); // "按照王国正规的骑士册封仪式，我应该再吻一下他的左面颊，以示接受效忠。"
                        yield return _gameMethods.OpenDialog(5471); // "但一想到王子的体内流着一半和我相同的血液，算是我血缘上的兄亲，就令我感觉十分尴尬，下不去嘴。"
                        yield return _gameMethods.OpenDialog(5034); // "……"
                        yield return _gameMethods.OpenDialog(5472); // "……我看了看菲珀斯敛目垂眸的面孔。"
                        yield return _gameMethods.ExecuteCharacterImageData("nv2");
                        yield return _gameMethods.OpenDialog(5034); // "……"
                        yield return _gameMethods.OpenDialog(5473); // "不过，在这个敏感的关键时刻，如果我不做完正式流程，恐怕会被当作某种政治表态，曲解出额外的含义，让他多心和疑虑吧。"
                        yield return _gameMethods.PlaySound("sounda", 0.0f, 1.0f, "audio/sound/manbu/Body1_01.mp3");
                        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -270.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 1.08f}, {"zpos", -294.0f}})});
                        yield return _gameMethods.OpenDialog(5474); // "最后，我硬着头皮，轻轻伏身，将嘴唇在他的侧面颊上轻轻擦碰了一下。"
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan10", "zui3"});
                        yield return _gameMethods.ExecuteCharacterImageData("s_qian");
                        yield return _gameMethods.OpenDialog(5475); // "「……{nw}{w=0.6}"
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan22", "zui4", "emoji5"});
                        yield return _gameMethods.ExecuteCharacterImageData("s_qian");
                        yield return _gameMethods.OpenDialog(5389); // "……」"
                        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -294.0f}})});
                        yield return _gameMethods.ExecuteCharacterImageData("nv2");
                        yield return _gameMethods.OpenDialog(5476); // "那么，允许你向我效忠，菲珀斯。"
                        yield return _gameMethods.ExecuteCharacterImageData("nv2");
                        yield return _gameMethods.OpenDialog(5477); // "从此刻起，你便是我的骑士。"
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei10", "yan2", "zui6", "-emoji5"});
                        yield return _gameMethods.ExecuteCharacterImageData("s");
                        yield return _gameMethods.OpenDialog(5478); // "多谢您的恩赐，陛下。"
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui3"});
                        yield return _gameMethods.PlaySound("sound", 0.0f, 2f, "audio/sound/manbu/Body1_02_duan.mp3");
                        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"ypos", -6f}, {"zpos", -36.0f}})});
                        yield return _gameMethods.Transition(time:0.6f);
                        yield return _gameMethods.OpenDialog(5479); // "他轻轻说着，站了起身。"
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan19", "zui3"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 40.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.72f}, {"zpos", 52.0f}})});
                        yield return _gameMethods.OpenDialog(5480); // "青年慢了半拍，才接过了我手中的剑，{nw}{w=0.2}"
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan18", "zui3"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 52.0f}})});
                        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 1.37f}, {"xpos", -198f}})});
                        yield return _gameMethods.Show("npc_guowang", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 52f}, {"pos", new Vector2(102f, 1038f)}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}, {"blur", 0.1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 1f}, {"blur", 0f}})});
                        yield return _gameMethods.ExecuteCharacterImageData("s");
                        yield return _gameMethods.OpenDialog(5481); // "缓缓转过身去，面对瘫坐在地上的国王。"
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan22", "zui6"});
                        yield return _gameMethods.ExecuteCharacterImageData("s");
                        yield return _gameMethods.OpenDialog(5482); // "现在，请容我为您扫清路上的敌人。"
                        yield return _gameMethods.Show("npc_guowang", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}, {"blur", 0f}})});
                        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", -198f}})});
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan22", "zui3", "emoji0"});
                        yield return _gameMethods.OpenDialog(5483); // "他的声音尾部在微微颤抖。"
                        yield return _gameMethods.OpenDialog(5484); // "但他仍稳稳从刀鞘中抽出了银亮的长刃。"
                        yield return _gameMethods.StopSound(channelName:"music1", fadeOut:2f);
                        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/juezhan_dao/SWORD_01.ogg");
                        yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei3", "yan7", "zui9"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(-54f, 1632f)}, {"zoom", 0.66f}, {"zpos", 52f}})});
                        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", -198f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.3f}, {"xpos", -360f}})});
                        
                        yield return _gameMethods.OpenDialog(5485); // "然而，“锃”地一声，有个人比他更快地抽出剑，如一团风般，挡在国王身前。"
                        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", -360f}})});
                        yield return _gameMethods.OpenDialog(5322); // "是一身红裙的公主琶菈丝。"
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei3", "yan4", "zui3", "-emoji0"});
                        yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei2", "yan6", "zui8"});
                        yield return _gameMethods.OpenDialog(5486); // "她身材高挑，同样作为骑士持细剑而立，此刻不敢置信，仿佛怒发冲冠。"
                        yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei3", "yan7", "zui7"});
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei3", "yan9", "zui3"});
                        yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/music/end/nvwang/desperation.mp3");
                        yield return _gameMethods.ExecuteCharacterImageData("c");
                        yield return _gameMethods.OpenDialog(5487); // "哥哥，为什么？！"
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei3", "yan13", "zui6"});
                        yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei3", "yan7", "zui8"});
                        yield return _gameMethods.ExecuteCharacterImageData("s");
                        yield return _gameMethods.OpenDialog(5488); // "让开，琶菈丝。"
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei3", "yan13", "zui3"});
                        yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei3", "yan4", "zui7"});
                        yield return _gameMethods.ExecuteCharacterImageData("c");
                        yield return _gameMethods.OpenDialog(5489); // "你怎么能背叛父亲？！"
                        yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei3", "yan4", "zui8"});
                        yield return _gameMethods.OpenDialog(5490); // "公主厉声喝问。"
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei5", "yan9", "zui7"});
                        yield return _gameMethods.ExecuteCharacterImageData("s");
                        yield return _gameMethods.OpenDialog(5491); // "我……"
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei9", "yan2", "zui4"});
                        yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei2", "yan6", "zui8"});
                        yield return _gameMethods.OpenDialog(5492); // "他深吸了一口气。"
                        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.5>audio/sound/jiaobusheng_nuo_normal1.ogg");
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei3", "yan13", "zui6"});
                        yield return _gameMethods.ExecuteCharacterImageData("s");
                        yield return _gameMethods.OpenDialog(5493); // "我所效忠之人，在我身后，谈何背叛？"
                        yield return _gameMethods.PlaySound("sounda", 0.0f, 0.4f, "audio/sound/moca1.ogg");
                        yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei2", "yan2", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"xoffset", -3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0f}})});
                        Engine._history = false;
                        yield return _gameMethods.ExecuteCharacterImageData("c_qian");
                        yield return _gameMethods.OpenDialog(5044); // "{nw}{w=0.15}"
                        Engine._history = true;
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan13", "zui3", "emoji0"});
                        yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei2", "yan3", "zui7"});
                        yield return _gameMethods.ExecuteCharacterImageData("c");
                        yield return _gameMethods.OpenDialog(5494); // "你……！"
                        yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei2", "yan6", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
                        yield return _gameMethods.OpenDialog(5495); // "公主的视线越过王子，冲向了我。"
                        yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei3", "yan6", "zui5"});
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei5", "yan9", "zui4", "-emoji0"});
                        yield return _gameMethods.ExecuteCharacterImageData("c");
                        yield return _gameMethods.OpenDialog(5496); // "还有你。"
                        yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei3", "yan6", "zui7"});
                        yield return _gameMethods.ExecuteCharacterImageData("c");
                        yield return _gameMethods.OpenDialog(5497); // "你为什么要这么做？！"
                        yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei3", "yan2", "zui7"});
                        yield return _gameMethods.ExecuteCharacterImageData("c");
                        yield return _gameMethods.OpenDialog(5498); // "可是成为公主，为王国做出贡献，难道不是无上的荣誉吗？"
                        yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei3", "yan6", "zui8", "emoji3"});
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei5", "yan22", "zui4"});
                        yield return _gameMethods.OpenDialog(5499); // "她气喘吁吁，发丝散乱，失去了所有贵族的风度礼仪，带着被背弃了一般的怒火、冤屈和不甘，怒视着我。"
                        yield return _gameMethods.OpenDialog(5500); // "这人逻辑太过自洽，让我无话可说，反倒有些好奇了。"
                        yield return _gameMethods.ExecuteCharacterImageData("nv2");
                        yield return _gameMethods.OpenDialog(5334); // "那么，为什么你不愿意被带走呢？"
                        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 0.5>audio/demo_audio/sound/jiaobusheng_nv_liangbuzou_gaogen_diban.mp3");
                        yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei3", "yan6", "zui4"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", -54f}, {"zpos", 52.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.2f}, {"xpos", 6f}, {"zpos", 106.0f}})});
                        yield return _gameMethods.ExecuteCharacterImageData("c");
                        yield return _gameMethods.OpenDialog(5335); // "谁说我不愿意！"
                        yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei3", "yan1", "zui3"});
                        yield return _gameMethods.ExecuteCharacterImageData("c_qian");
                        yield return _gameMethods.OpenDialog(5501); // "「认定的人选本就是我，{nw}{w=0.2}"
                        yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei3", "yan6", "zui3"});
                        yield return _gameMethods.ExecuteCharacterImageData("c_qian");
                        yield return _gameMethods.OpenDialog(5502); // "只是父亲改变主意，才换成了你。」"
                        yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei3", "yan6", "zui2"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", 6f}, {"zpos", 106.0f}})});
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei12", "yan2", "zui7"});
                        yield return _gameMethods.ExecuteCharacterImageData("s");
                        yield return _gameMethods.OpenDialog(5503); // "别说了……琶菈丝。"
                        yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei2", "yan4", "zui8", "-emoji3"});
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan22", "zui3"});
                        yield return _gameMethods.OpenDialog(5504); // "王子打断她，声音疲倦。"
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan13", "zui6"});
                        yield return _gameMethods.ExecuteCharacterImageData("s");
                        yield return _gameMethods.OpenDialog(5505); // "任何人都没有资格要求他人。"
                        yield return _gameMethods.ExecuteCharacterImageData("s");
                        yield return _gameMethods.OpenDialog(5506); // "况且……你根本不理解那是什么处境，才自以为不怕。"
                        yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei2", "yan6", "zui7"});
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan13", "zui3"});
                        yield return _gameMethods.ExecuteCharacterImageData("c_qian");
                        yield return _gameMethods.OpenDialog(5507); // "「那你又懂什么？{nw}{w=0.2}"
                        yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei2", "yan7", "zui7"});
                        yield return _gameMethods.ExecuteCharacterImageData("c_qian");
                        yield return _gameMethods.OpenDialog(5508); // "/n你背叛父亲，还不是出于贪生怕死？！」"
                        yield return _gameMethods.ExecuteCharacterImageData("c");
                        yield return _gameMethods.OpenDialog(5509); // "父亲供养我们长大，你就如此对他！？"
                        yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei2", "yan7", "zui8"});
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei5", "yan9", "zui4"});
                        yield return _gameMethods.OpenDialog(5510); // "我有点好奇事情会如何发展，于是没有插手。"
                        yield return _gameMethods.OpenDialog(5511); // "既然已经接纳了菲珀斯作为手下，我便相信他会收拾局面。"
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei5", "yan22", "zui4"});
                        yield return _gameMethods.OpenDialog(5512); // "与怒气滔滔的公主琶菈丝截然相反，菲珀斯温和的脾性中虽然难得透出些许气急，却始终带着一股挥之不去的倦惫。"
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan2", "zui7"});
                        yield return _gameMethods.ExecuteCharacterImageData("s");
                        yield return _gameMethods.OpenDialog(5513); // "那你又怎么想呢？"
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan18", "zui11", "emoji0"});
                        yield return _gameMethods.ExecuteCharacterImageData("s");
                        yield return _gameMethods.OpenDialog(5514); // "你难道以为父亲是因为爱我们，才用她替代你吗？"
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan9", "zui10", "emoji0"});
                        yield return _gameMethods.ExecuteCharacterImageData("s_qian");
                        yield return _gameMethods.OpenDialog(5515); // "「他只是想省下一个公主，用于联姻。{nw}{w=0.2}"
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan13", "zui7", "emoji0"});
                        yield return _gameMethods.ExecuteCharacterImageData("s_qian");
                        yield return _gameMethods.OpenDialog(5516); // "/n我们和她没有不同，在父亲眼中，不过是更好用的工具。」"
                        yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei2", "yan6", "zui5"});
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan13", "zui3", "emoji0"});
                        yield return _gameMethods.ExecuteCharacterImageData("c");
                        yield return _gameMethods.OpenDialog(5517); // "那又怎样？！/n这就是我的使命，每个人的命运！"
                        yield return _gameMethods.ExecuteCharacterImageData("c");
                        yield return _gameMethods.OpenDialog(5518); // "农夫生来就该种地，马夫生来就该赶车，我们锦衣玉食，就该用婚姻维系国家。"
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei3", "yan2", "zui3", "-emoji0"});
                        Engine._history = false;
                        yield return _gameMethods.ExecuteCharacterImageData("c_qian");
                        yield return _gameMethods.OpenDialog(5044); // "{nw}{w=0.15}"
                        Engine._history = true;
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei3", "yan9", "zui3"});
                        yield return _gameMethods.ExecuteCharacterImageData("c");
                        yield return _gameMethods.OpenDialog(5519); // "世世代代，祖祖辈辈，向来如此！"
                        yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei2", "yan7", "zui6"});
                        yield return _gameMethods.ExecuteCharacterImageData("c");
                        yield return _gameMethods.OpenDialog(5520); // "哥哥，你就是因为总认不清自己的身份，才会一直如此痛苦！"
                        yield return _gameMethods.ExecuteCharacterImageData("c");
                        yield return _gameMethods.OpenDialog(5521); // "连父亲为你指派的未婚妻，都抗拒不受！"
                        if (Defaults.Bai_xue == 1)
                        {
                                                        yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/jieju/jieju2.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(1.05f, 1.65f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 1.66f}})});
                            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 63.0f}, {"pos", new Vector2(-54f, -168f)}, {"xoffset", 200f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 1f}, {"xoffset", 0f}})});
                            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei8", "yan13", "zui13"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 60.0f}, {"pos", new Vector2(-18f, 1518f)}, {"zoom", 0.45f}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}, {"blur", 0.1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1f}, {"blur", 0f}})});
                            yield return _gameMethods.Transition(time:0.4f);
                            yield return _gameMethods.ExecuteCharacterImageData("nuo");
                            yield return _gameMethods.OpenDialog(5342); // "这戏码好拖沓，我有点厌烦了。"
                            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei8", "yan13", "zui8"});
                            yield return _gameMethods.OpenDialog(5343); // "旁边的诺伯拉突然出声说。"
                            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}, {"blur", 0f}})});
                            yield return _gameMethods.OpenDialog(5344); // "他无聊地支着腮。"
                            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui13"});
                            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}})});
                            yield return _gameMethods.ExecuteCharacterImageData("nuo");
                            yield return _gameMethods.OpenDialog(5345); // "小公主，需要我帮忙解决吗？"
                            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1>audio/sound/jiaobusheng_an_normal1.ogg");
                            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei8", "yan5", "zui7"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 60.0f}, {"pos", new Vector2(582f, 1506f)}, {"zoom", 0.35f}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}, {"blur", 0.1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1f}, {"blur", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 50f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.7f}, {"xoffset", 0f}})});
                            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
                            yield return _gameMethods.ExecuteCharacterImageData("luo");
                            yield return _gameMethods.OpenDialog(5346); // "我也随时可以出手。"
                            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
                            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei8", "yan5", "zui1"});
                            if (Defaults.Qigai == 1)
                            {
                                                                yield return _gameMethods.Show("xiya", parts: new List<string>{"mei2", "yan6", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 60.0f}, {"pos", new Vector2(1020f, 1548f)}, {"zoom", 0.4f}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}, {"blur", 0.1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1f}, {"blur", 0f}})});
                                yield return _gameMethods.ExecuteCharacterImageData("q1");
                                yield return _gameMethods.OpenDialog(5034); // "……"
                                yield return _gameMethods.OpenDialog(5347); // "一旁的席亚则沉默地盯着我。"
                                yield return _gameMethods.Show("xiya", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}, {"alpha", 1f}})});
                                yield return _gameMethods.Show("xiya", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"blur", 4f}})});

                            }
                            yield return _gameMethods.PlaySound("sounda2", 0.0f, 1.0f, "audio/demo_audio/sound/zhenjing_shuaidaoganjue.mp3");
                            yield return _gameMethods.Show("npc_guowang", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"blur", 4f}})});
                            yield return _gameMethods.Show("jieju2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"blur", 4f}})});
                            yield return _gameMethods.Show("nuo1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"blur", 4f}})});
                            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 63.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 0.6f}, {"zpos", 180.0f}})});
                            yield return _gameMethods.Show("luo2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"alpha", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"blur", 4f}})});
                            yield return _gameMethods.Show("an2", parts: new List<string>{"mei11", "yan4", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 60.0f}, {"pos", new Vector2(606f, 1944f)}, {"zoom", 0.47f}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}, {"blur", 0.1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.4f}, {"alpha", 1f}, {"blur", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"xoffset", -3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0f}})});
                            yield return _gameMethods.ExecuteCharacterImageData("an");
                            yield return _gameMethods.OpenDialog(5348); // "……？！"
                            yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan9", "zui1"});
                            Engine._history = false;
                            yield return _gameMethods.OpenDialog(5044); // "{nw}{w=0.15}"
                            Engine._history = true;
                            yield return _gameMethods.Show("an2", parts: new List<string>{"mei8", "yan14", "zui1"});
                            yield return _gameMethods.OpenDialog(5349); // "安德鲁露出一副被抢了先的愕然，"
                            yield return _gameMethods.Show("an2", parts: new List<string>{"mei10", "yan8", "zui3"});
                            yield return _gameMethods.ExecuteCharacterImageData("an");
                            yield return _gameMethods.OpenDialog(5350); // "立刻也双眼睁大、炯炯有神地看向我，坚定地表达出自己的立场。"
                            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 180.0f}})});
                            yield return _gameMethods.Show("an2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}, {"blur", 0f}, {"xoffset", 0f}, {"yoffset", 0f}})});
                            yield return _gameMethods.OpenDialog(5522); // "我摇摇头。"
                            yield return _gameMethods.ExecuteCharacterImageData("nv2");
                            yield return _gameMethods.OpenDialog(5523); // "给他点时间。"
                            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/jieju/jieju2.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.65f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 1.66f}})});
                            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_portrait/npc/npc_guowang.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 52f}, {"pos", new Vector2(102f, 1038f)}})});
                            yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei3", "yan13", "zui6"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(636f, 1734f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 52.0f}, {"zoom", 0.39f}})});
                            yield return _gameMethods.Show("gongzhu_layered", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(6f, 1632f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 106.0f}, {"zoom", 0.66f}})});
                            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(-360f, -6f)}, {"zpos", -36.0f}})});
                            yield return _gameMethods.TransitionBy("blink2");

                        }
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei3", "yan13", "zui6"});
                        yield return _gameMethods.ExecuteCharacterImageData("s");
                        yield return _gameMethods.OpenDialog(5524); // "我……只是无法接受，没有爱存在的政治婚姻。"
                        yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei2", "yan6", "zui8"});
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei3", "yan2", "zui6"});
                        yield return _gameMethods.ExecuteCharacterImageData("s");
                        yield return _gameMethods.OpenDialog(5525); // "琶菈丝，我们是人，不是工具。"
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei3", "yan9", "zui7"});
                        yield return _gameMethods.ExecuteCharacterImageData("s");
                        yield return _gameMethods.OpenDialog(5526); // "即便你强迫自己接受了那样的人生，也会往后的每一天里感到窒息，就像溺水一样。"
                        yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei2", "yan7", "zui7"});
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei3", "yan9", "zui3"});
                        yield return _gameMethods.ExecuteCharacterImageData("c");
                        yield return _gameMethods.OpenDialog(5527); // "不，天真的是你！"
                        yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei2", "yan1", "zui7"});
                        yield return _gameMethods.ExecuteCharacterImageData("c");
                        yield return _gameMethods.OpenDialog(5528); // "权力和地位你有了，钱你有了，还想要爱，想要自由。"
                        yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei2", "yan4", "zui7"});
                        yield return _gameMethods.ExecuteCharacterImageData("c");
                        yield return _gameMethods.OpenDialog(5529); // "你为什么总想着什么都要？"
                        yield return _gameMethods.ExecuteCharacterImageData("c_qian");
                        yield return _gameMethods.OpenDialog(5530); // "「从小你就总那么古怪，和我，和爸爸都不一样。{nw}{w=0.01}"
                        yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei2", "yan6", "zui7"});
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei3", "yan2", "zui3"});
                        yield return _gameMethods.ExecuteCharacterImageData("c_qian");
                        yield return _gameMethods.OpenDialog(5044); // "{nw}{w=0.15}"
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei3", "yan9", "zui3"});
                        yield return _gameMethods.ExecuteCharacterImageData("c_qian");
                        yield return _gameMethods.OpenDialog(5531); // "/n你就像妈妈一样，老是执着于一些没必要的东西。」"
                        yield return _gameMethods.ExecuteCharacterImageData("c_qian");
                        yield return _gameMethods.OpenDialog(5532); // "「我就是不明白，{nw}{w=0.2}"
                        yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei2", "yan2", "zui7"});
                        yield return _gameMethods.ExecuteCharacterImageData("c_qian");
                        yield return _gameMethods.OpenDialog(5533); // "所谓爱、什么理想，还有那些庶民的想法，它们到底有什么重要？！」"
                        yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei2", "yan3", "zui4"});
                        yield return _gameMethods.ExecuteCharacterImageData("c");
                        yield return _gameMethods.OpenDialog(5534); // "老实规矩地承担自己的身份，享受你拥有的一切不行么？"
                        yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei2", "yan3", "zui2"});
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei5", "yan13", "zui14"});
                        yield return _gameMethods.ExecuteCharacterImageData("s");
                        yield return _gameMethods.OpenDialog(5535); // "这样是错的，而父亲也是错误的！"
                        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(12f, -108f)}, {"zpos", -180.0f}})});
                        yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei2", "yan6", "zui8"});
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei5", "yan13", "zui3"});
                        yield return _gameMethods.Transition(time:0.6f);
                        yield return _gameMethods.OpenDialog(5536); // "菲珀斯驳斥道，{nw}{w=0.01}"
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan2", "zui3"});
                        yield return _gameMethods.ExecuteCharacterImageData("s");
                        yield return _gameMethods.OpenDialog(5044); // "{nw}{w=0.15}"
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan9", "zui3"});
                        yield return _gameMethods.ExecuteCharacterImageData("s");
                        yield return _gameMethods.OpenDialog(5537); // "转头看了我一眼。"
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan13", "zui3"});
                        yield return _gameMethods.OpenDialog(5538); // "他的眼神中夹杂着一些说不清道不明的东西。"
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan18", "zui6"});
                        yield return _gameMethods.ExecuteCharacterImageData("s_qian");
                        yield return _gameMethods.OpenDialog(5539); // "「但是，错的就是错的。结果已经找上门来。{nw}{w=0.2}"
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan2", "zui7"});
                        yield return _gameMethods.ExecuteCharacterImageData("s_qian");
                        yield return _gameMethods.OpenDialog(5540); // "以前的一切，已经无法维系下去了。」 "
                        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/jiaobusheng_nv_liangbuzou_gaogen_diban.mp3");
                        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 12f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.3f}, {"xpos", -594f}})});
                        yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei3", "yan1", "zui8"});
                        Engine._history = false;
                        yield return _gameMethods.ExecuteCharacterImageData("c_qian");
                        yield return _gameMethods.OpenDialog(5044); // "{nw}{w=0.15}"
                        Engine._history = true;
                        yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei3", "yan6", "zui7"});
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan18", "zui3"});
                        yield return _gameMethods.ExecuteCharacterImageData("c");
                        yield return _gameMethods.OpenDialog(5541); // "——都是因为你。"
                        yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei3", "yan6", "zui8"});
                        yield return _gameMethods.OpenDialog(5542); // "公主也忽然把矛头指向了我。"
                        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", -594f}})});
                        yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei3", "yan7", "zui4", "emoji3"});
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan9", "zui3"});
                        yield return _gameMethods.ExecuteCharacterImageData("c");
                        yield return _gameMethods.OpenDialog(5543); // "都是你，出现后，把一切搅得一团糟……！"
                        yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei3", "yan6", "zui4"});
                        yield return _gameMethods.ExecuteCharacterImageData("c_qian");
                        yield return _gameMethods.OpenDialog(5544); // "「我还以为我有了姐姐……你为什么要这么做？{nw}{w=0.2}"
                        yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei3", "yan2", "zui7"});
                        yield return _gameMethods.ExecuteCharacterImageData("c_qian");
                        yield return _gameMethods.OpenDialog(5545); // "/n你为什么要出现，打破这一切？」"
                        yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei3", "yan4", "zui8"});
                        yield return _gameMethods.ExecuteCharacterImageData("nv2");
                        yield return _gameMethods.OpenDialog(5546); // "是吗？"
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan2", "zui3"});
                        Engine._history = false;
                        yield return _gameMethods.ExecuteCharacterImageData("nv2_qian");
                        yield return _gameMethods.OpenDialog(5044); // "{nw}{w=0.15}"
                        Engine._history = true;
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan9", "zui3"});
                        yield return _gameMethods.ExecuteCharacterImageData("nv2");
                        yield return _gameMethods.OpenDialog(5547); // "那么，我的诞生又是谁种下的恶果呢？"
                        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -180.0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.66f}, {"zpos", -200.0f}})});
                        yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei3", "yan3", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}, {"blur", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.5f}, {"alpha", 0f}, {"blur", 0.1f}})});
                        yield return _gameMethods.OpenDialog(5548); // "我看向国王。"
                        yield return _gameMethods.Hide("gongzhu_layered");
                        yield return _gameMethods.ExecuteCharacterImageData("nv2");
                        yield return _gameMethods.OpenDialog(5549); // "你说是不是？"
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei4", "yan13", "zui7", "emoji0"});
                        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", -200.0f}})});
                        yield return _gameMethods.ShowBlack(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"zpos", 100f}, {"pos", new Vector2(216f, 1008f)}, {"zoom", 1.22f}})});
                        yield return _gameMethods.Transition(time:0.3f);
                        yield return _gameMethods.ExecuteCharacterImageData("s");
                        yield return _gameMethods.OpenDialog(5550); // "够了，你该冷静一下。"
                        yield return _gameMethods.PlaySound("sounda5", 0.0f, 1.0f, "audio/sound/he/houjin.mp3");
                        yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei3", "yan1", "zui8"});
                        Engine._history = false;
                        yield return _gameMethods.OpenDialog(5044); // "{nw}{w=0.15}"
                        Engine._history = true;
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei4", "yan13", "zui3", "-emoji0"});
                        yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei3", "yan3", "zui8"});
                        yield return _gameMethods.OpenDialog(5551); // "菲珀斯忽然沉声说，出手击向公主的后颈，将她敲晕。"
                        yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei2", "yan2", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(18f, 1686f)}, {"zoom", 0.7f}, {"zpos", 100f}})});
                        yield return _gameMethods.HideBlack();
                        yield return _gameMethods.Transition(time:0.5f);
                        yield return _gameMethods.OpenDialog(5552); // "在昏迷之前，公主拼命试图反抗。"
                        yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei3", "yan6", "zui8"});
                        yield return _gameMethods.ExecuteCharacterImageData("s");
                        yield return _gameMethods.OpenDialog(5553); // "然而，令我意外的是，公主昏迷前瞪的不是王子，看的方向居然是我。"
                        yield return _gameMethods.Show("gongzhu_layered", parts: new List<string>{"mei3", "yan4", "zui8"});
                        yield return _gameMethods.OpenDialog(5554); // "她死死地盯着我，目不转睛，金瞳灼灼燃烧。"
                        yield return _gameMethods.OpenDialog(5555); // "仿佛那满腔的怒火将她的视野变得狭窄，从此只容得下我一人。"
                        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(12f, -66f)}, {"zpos", -104.0f}})});
                        yield return _gameMethods.Hide("gongzhu_layered");
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan13", "zui6"});
                        yield return _gameMethods.Transition(time:0.6f);
                        yield return _gameMethods.ExecuteCharacterImageData("s_qian");
                        yield return _gameMethods.OpenDialog(5556); // "「抱歉，陛下。{nw}{w=0.2}"
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan21", "zui6"});
                        yield return _gameMethods.ExecuteCharacterImageData("s_qian");
                        yield return _gameMethods.OpenDialog(5557); // "我的妹妹不太懂事。」"
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan21", "zui3"});
                        yield return _gameMethods.ExecuteCharacterImageData("nv2");
                        yield return _gameMethods.OpenDialog(5558); // "没事。"
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan2", "zui3"});
                        Engine._history = false;
                        yield return _gameMethods.ExecuteCharacterImageData("s_qian");
                        yield return _gameMethods.OpenDialog(5044); // "{nw}{w=0.15}"
                        Engine._history = true;
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan21", "zui3"});
                        yield return _gameMethods.ExecuteCharacterImageData("s");
                        yield return _gameMethods.OpenDialog(5034); // "……"
                        yield return _gameMethods.OpenDialog(5559); // "菲珀斯安静地等待了一会儿，"
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan19", "zui3"});
                        yield return _gameMethods.ExecuteCharacterImageData("s");
                        yield return _gameMethods.OpenDialog(5560); // "貌似是确定了我没有打算惩罚公主，绷紧的身体才微微放松了些许。"
                        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 2;
                        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
                        {
                                                        
                                                _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
                                                _gameMethods.SyncAchievement();

                        }
                        yield return _gameMethods.OpenDialog(5561); // "他多虑了，我从最开始就不打算严惩公主。我说过了，公主只是天真骄纵。"
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui3"});
                        yield return _gameMethods.OpenDialog(5562); // "菲珀斯再次开口。"
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui7"});
                        yield return _gameMethods.ExecuteCharacterImageData("s");
                        yield return _gameMethods.OpenDialog(5563); // "那么，我这就为您克服障碍。"
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui3"});
                        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 12f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.3f}, {"xpos", -222f}})});
                        yield return _gameMethods.Show("npc_guowang", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"xoffset", -3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0f}})});
                        yield return _gameMethods.ExecuteCharacterImageData("a");
                        yield return _gameMethods.OpenDialog(5564); // "你……你们！"
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan18", "zui3"});
                        yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_portrait/npc/npc_guowang.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"xoffset", -3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0f}})});
                        yield return _gameMethods.ExecuteCharacterImageData("a");
                        yield return _gameMethods.OpenDialog(5565); // "你们这样对待自己的亲生父亲，都不怕日夜良心难安，无法入睡吗？！"
                        yield return _gameMethods.OpenDialog(5566); // "菲珀斯的手顿了下。"
                        yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_portrait/npc/npc_guowang.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
                        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xpos", -222f}})});
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei4", "yan2", "zui3"});
                        yield return _gameMethods.ExecuteCharacterImageData("s");
                        yield return _gameMethods.OpenDialog(5034); // "……"
                        yield return _gameMethods.ExecuteCharacterImageData("nv2");
                        yield return _gameMethods.OpenDialog(5567); // "你都能安眠，我为什么不能？"
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei3", "yan18", "zui3"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"zpos", 0f}})});
                        yield return _gameMethods.Transition(time:0.8f);
                        yield return _gameMethods.OpenDialog(5568); // "听到我的表态，菲珀斯无声地扬起了剑。"
                        yield return _gameMethods.OpenDialog(5569); // "锋芒流过利刃。寂静的殿中响起了一阵水声。"
                        yield return _gameMethods.OpenDialog(5570); // "那个前任国王，被吓得不能自已了。"
                        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(1308f, 2196f)}, {"zoom", 0.62f}})});
                        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"xpos", 924f}, {"zpos", 10.0f}})});
                        yield return _gameMethods.Transition(time:0.6f);
                        yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
                        yield return _gameMethods.StopSound(channelName:"music", fadeOut:4f);
                        yield return _gameMethods.OpenDialog(5571); // "诺伯拉扑哧一声笑出来。"
                        yield return _gameMethods.OpenDialog(5572); // "卫兵们也窃窃私语。"
                        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(-186f, 6f)}, {"blur", 4f}})});
                        yield return _gameMethods.Hide("nuo1");
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei8", "yan12", "zui3"});
                        yield return _gameMethods.Transition(time:0.8f);
                        yield return _gameMethods.OpenDialog(5573); // "在这个节骨眼上，{nw}{w=0.01}"
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan18", "zui13", "emoji0", "emoji9"});
                        yield return _gameMethods.ExecuteCharacterImageData("nv2");
                        yield return _gameMethods.OpenDialog(5574); // "我却因为场面无聊，有些走神。"
                        yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/music/end/ran_theme_002.mp3");
                        yield return _gameMethods.OpenDialog(5575); // "……不知为何，像是抽离出了身体所在的这个场景，我莫名回忆起了多年以前的一个冬日。"
                        yield return _gameMethods.OpenDialog(5576); // "那天是新年。"
                        yield return _gameMethods.OpenDialog(5577); // "由于减了炉灶税，母亲用省下的钱买了一只鸡，从一早起便哼着歌，在锅灶边忙忙碌碌。"
                        yield return _gameMethods.OpenDialog(5578); // "夜幕很快降临。"
                        yield return _gameMethods.OpenDialog(5579); // "跨年之夜，我们在黑暗的木屋里点起了平日舍不得用的蜡烛。"
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei13", "yan2", "zui13", "-emoji0", "-emoji9"});
                        Engine._history = false;
                        yield return _gameMethods.OpenDialog(5044); // "{nw}{w=0.15}"
                        Engine._history = true;
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan22", "zui3"});
                        yield return _gameMethods.OpenDialog(5580); // "烛光下，我和母亲二人围着烤鸡，嗅着油滋滋的肉香，唱起赞歌，为好心的小王子祈福和道谢。"
                        yield return _gameMethods.OpenDialog(5581); // "……那天。真的好开心啊。"
                        yield return _gameMethods.OpenDialog(5582); // "而现在，我坐在王座上。"
                        yield return _gameMethods.OpenDialog(5583); // "国王无比狼狈地跌坐下方，生死仅在我一念之间；/n当年的王子对我恭恭敬敬，殿中的士兵噤若寒蝉。"
                        yield return _gameMethods.OpenDialog(5584); // "我的心头却毫无波澜。/n——如果妈妈还在，看到这一幕，她会怎么想呢？"
                        yield return _gameMethods.OpenDialog(5585); // "会高兴，夸奖我，为她报了仇么？"
                        if (Defaults.He_hen == 1)
                        {
                                                        yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_shufang_bangwan_shafa1.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(-0.01f, 1.94f)}, {"zoom", 1.46f}})});
                            yield return _gameMethods.Show("he", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 3.06f)}, {"zoom", 0.63f}})});
                            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/daoju/shuben.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 170f}, {"ypos", 550f}})});
                            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(30f, -138f)}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"easeIn", 2f}, {"zpos", 18.0f}})});
                            yield return _gameMethods.Transition(time:1f);
                            yield return _gameMethods.OpenDialog(5586); // "……如果，赫泽尔在这里，又会说些什么呢？"
                            yield return _gameMethods.OpenDialog(5587); // "大概会嫌弃国王，冷冷地说一句“太聒噪了”吧。"
                            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/heilong_shufang_bangwan_shafa1.jpg");
                            yield return _gameMethods.Hide("he");
                            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/daoju/shuben.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"onLayer", "forward"}})});
                            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"pos", new Vector2(-186f, 6f)}, {"zpos", 10f}, {"blur", 0f}})});
                            yield return _gameMethods.Transition(time:0.5f);

                        }
                        yield return _gameMethods.ExecuteCharacterImageData("nv2");
                        yield return _gameMethods.OpenDialog(5034); // "……"
                        yield return _gameMethods.OpenDialog(5588); // "突然间，一切索然无味。"
                        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"blur", 0f}})});
                        yield return _gameMethods.ExecuteCharacterImageData("nv2");
                        yield return _gameMethods.OpenDialog(5589); // "算了，我改主意了。"
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei3", "yan12", "zui1"});
                        yield return _gameMethods.OpenDialog(5590); // "我开口。"
                        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
                        yield return _gameMethods.OpenDialog(5591); // "本欲挥下剑刃的菲珀斯动作一顿。"
                        yield return _gameMethods.ExecuteCharacterImageData("nv2");
                        yield return _gameMethods.OpenDialog(5592); // "这样对他，太便宜他了，一辈子都没怎么吃过苦。"
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan4", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"xoffset", -3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 3f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.07f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.05f}, {"yoffset", 0f}})});
                        yield return _gameMethods.ExecuteCharacterImageData("s");
                        yield return _gameMethods.OpenDialog(5234); // "……！"
                        yield return _gameMethods.Show("wangzi", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
                        yield return _gameMethods.OpenDialog(5593); // "菲珀斯猛然望向我，眼神怔然，瞳孔颤抖，似乎不可置信。"
                        yield return _gameMethods.OpenDialog(5594); // "我对他微微一笑，意兴阑珊。"
                        yield return _gameMethods.ExecuteCharacterImageData("nv2");
                        yield return _gameMethods.OpenDialog(5595); // "想处置的人，我会亲手处置。"
                        Defaults.Haogandu_nuo = Defaults.Haogandu_nuo + 2;
                        Defaults.Haogandu_an = Defaults.Haogandu_an + 3;
                        if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)
                        {
                                                        
                                                _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_9");
                                                _gameMethods.SyncAchievement();

                        }
                        yield return _gameMethods.ExecuteCharacterImageData("nv2");
                        yield return _gameMethods.OpenDialog(5596); // "不至于躲在别人背后，让骑士替自己背负骂名。"
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui4", "emoji0"});
                        yield return _gameMethods.ExecuteCharacterImageData("s");
                        yield return _gameMethods.OpenDialog(5034); // "……"
                        yield return _gameMethods.ExecuteCharacterImageData("nv2");
                        yield return _gameMethods.OpenDialog(5597); // "记得北境有几个矿井。/n把他送去，严加看管，劳动改造吧。"
                        yield return _gameMethods.ExecuteCharacterImageData("nv2");
                        yield return _gameMethods.OpenDialog(5598); // "菲珀斯，你来负责。"
                        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(-6f, -84f)}, {"zpos", -278.0f}})});
                        yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_portrait/npc/npc_guowang.png");
                        yield return _gameMethods.Show("wangzi", parts: new List<string>{"mei7", "yan13", "zui15", "-emoji0"});
                        yield return _gameMethods.TransitionBy("blink2");
                        yield return _gameMethods.OpenDialog(5599); // "他似乎还未反应过来，只怔愣地望着我。"
                        yield return _gameMethods.PlaySound("sound", 0.0f, 4f, "audio/sound/manbu/Body1_02_duan.mp3");
                        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ease", 0.8f}, {"ypos", -120f}})});
                        yield return _gameMethods.OpenDialog(5600); // "我从座中起身。"
                        yield return _gameMethods.ExecuteCharacterImageData("nv2");
                        yield return _gameMethods.OpenDialog(5601); // "就这样。"
                        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"ypos", -120f}})});
                        yield return _gameMethods.ExecuteCharacterImageData("nv2");
                        yield return _gameMethods.OpenDialog(5602); // "我去和教会商议加冕仪式的事了。"
                        yield return _gameMethods.OpenDialog(5603); // "安德鲁一众人跟着我移步。"
                        yield return _gameMethods.SceneBlack(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.3f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 1.14f}})});
                        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
                        yield return _gameMethods.Transition(time:0.8f);
                        yield return _gameMethods.OpenDialog(5604); // "离开之前，我听到身后传来跪地领命的清晰声响。"
                        yield return _gameMethods.OpenDialog(5605); // "然后是……"
                        yield return _gameMethods.OpenDialog(5606); // "一声轻不可闻，几乎要消失在我们之间所隔这段距离里的——“谢谢”。"
                        yield return _gameMethods.StopSound(channelName:"music", fadeOut:5f);

    }

    public IEnumerator label_end6_menu_0_IdEQSfpx()
    {
        yield return _gameMethods.PlaySound("music3", 0.0f, 1.0f, "audio/music/end/nvwang/nvwang1.mp3");
        yield return _gameMethods.Scene("nvwang_ditu", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(642f, 888f)}, {"zoom", 0.66f}, {"blur", 40f}})});
        yield return _gameMethods.Show("nvwang_nv_1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(642f, 888f)}, {"zoom", 0.66f}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", -30f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.4f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.5f}, {"xoffset", 0f}, {"alpha", 1f}})});
        yield return _gameMethods.Show("nvwang_nv_2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(642f, 888f)}, {"zoom", 0.66f}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", -30f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.4f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.5f}, {"xoffset", 0f}, {"alpha", 1f}})});
        yield return _gameMethods.Show("nvwang_nv_3", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(642f, 888f)}, {"zoom", 0.66f}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", -30f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"pause", 0.4f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.5f}, {"xoffset", 0f}, {"alpha", 1f}})});
        Defaults.Gui_duihuakuang_you = 0;
        yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1>audio/sound/jiaobusheng_xin_normal1.ogg");
        yield return _gameMethods.Transition(time:0.5f);
        yield return _gameMethods.OpenDialog(5613); // "没等对方抬手，我已先一步走上前，主动用双手托起王冠，戴在了头顶。"
        yield return _gameMethods.Show("nvwang_j_2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(642f, 888f)}, {"zoom", 0.66f}}), new SameLineParamData(new Dictionary<string, object>{{"xoffset", 30f}, {"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.5f}, {"xoffset", 0f}, {"alpha", 1f}})});
        yield return _gameMethods.ExecuteCharacterImageData("t");
        yield return _gameMethods.OpenDialog(5034); // "……"
        yield return _gameMethods.Show("nvwang_nv_1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"alpha", 1f}})});
        yield return _gameMethods.Show("nvwang_nv_2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"alpha", 1f}})});
        yield return _gameMethods.Show("nvwang_nv_3", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"alpha", 1f}})});
        yield return _gameMethods.OpenDialog(5614); // "那张瘦削清矍的脸上，双目蓦地微微瞪大，流露出一丝几不可察的错愕。"
        yield return _gameMethods.Show("nvwang_j_1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(642f, 888f)}, {"zoom", 0.66f}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.5f}, {"alpha", 1f}})});
        yield return _gameMethods.OpenDialog(5615); // "但他很快压下了这份失态，在大庭广众之下，眼神重新冷静平和地看着我。"
        yield return _gameMethods.OpenDialog(5616); // "王自己为自己加冕——这不同寻常的一幕，在人群中掀起了些许哗然。"
        yield return _gameMethods.OpenDialog(5617); // "然而不久，这小小的骚乱，便在我们二人若无其事的淡然态度下，恢复了平静。"
        yield return _gameMethods.Show("nvwang_j_1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}})});
        yield return _gameMethods.Show("nvwang_j_2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"alpha", 1f}})});
        yield return _gameMethods.OpenDialog(5618); // "对方是个聪明人，知道什么场合该做什么事，才不会失去体面。"
        yield return _gameMethods.OpenDialog(5619); // "尽管从他刚刚那一眼中，已经泄露出了复杂的情绪。\n不满、疑虑、探究、忌惮……不安。"
        yield return _gameMethods.OpenDialog(5620); // "不过，这些不会影响我的决定。"
        if (Defaults.Bai_xue == 1 && Defaults.He_xianzai == 0)
        {
            yield return _gameMethods.PlaySound("sound", 0.0f, 4f, "audio/sound/manbu/Body1_02_duan.mp3");
            yield return _gameMethods.Show("nvwang_j_1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}, {"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.5f}, {"alpha", 0f}, {"xoffset", 30f}})});
            yield return _gameMethods.Show("nvwang_j_2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}, {"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.5f}, {"alpha", 0f}, {"xoffset", 30f}})});
            yield return _gameMethods.Show("nvwang_nv_2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.5f}, {"alpha", 0f}})});
            yield return _gameMethods.OpenDialog(5621); // "我捧着黑龙的血石，轻轻托举过头顶，和它一起接受着万人目光。"
            yield return _gameMethods.OpenDialog(5622); // "一阵倒抽冷气声。有父母捂住了孩子的眼。"
            yield return _gameMethods.OpenDialog(5623); // "很可怕吗？……是啊，在人类眼中，这块鲜艳的石头，大概是狰狞而恐怖的吧。"
            yield return _gameMethods.OpenDialog(5624); // "不知为何，许多往事涌上心头。胸腔中忽然一阵心绪翻涌。"
            yield return _gameMethods.OpenDialog(5625); // "我强行按了下去，振作开口。"
            yield return _gameMethods.Hide("nvwang_j_1");
            yield return _gameMethods.Hide("nvwang_j_2");
            yield return _gameMethods.Hide("nvwang_nv_2");
            yield return _gameMethods.Show("nvwang_nv_3", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.5f}, {"alpha", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(5626); // "灾厄之龙——……赫泽尔·尼德霍格，已被勇者击败。"
            yield return _gameMethods.Show("nvwang_nv_3", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(642f, 888f)}, {"zoom", 0.66f}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.5f}, {"alpha", 1f}})});
            yield return _gameMethods.OpenDialog(5627); // "民众彻底哗然。"
            yield return _gameMethods.Scene("jieju8", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.62f, 1.29f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 1.05f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui16"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.1f, 1.0f)}, {"pos", new Vector2(-84f, 2148f)}, {"zoom", 0.46f}})});
            Defaults.Gui_duihuakuang_you = 1;
            yield return _gameMethods.PlaySound("sound", 0.0f, 4f, "audio/sound/manbu/Body1_02_duan.mp3");
            yield return _gameMethods.Transition(time:0.8f);
            yield return _gameMethods.OpenDialog(5628); // "安德鲁躬身，{nw}{w=0.01}"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan2", "zui2"});
            yield return _gameMethods.OpenDialog(5629); // "单膝跪在我面前。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan12", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("an");
            yield return _gameMethods.OpenDialog(5630); // "多亏陛下！"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan13", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("an");
            yield return _gameMethods.OpenDialog(5631); // "在千钧一发之际，用冰系魔法和世界树枝干将灾龙尼德霍格制服，挽救了我的性命。"
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei4", "yan5", "zui14"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.1f, 1.0f)}, {"pos", new Vector2(408f, 2034f)}, {"zoom", 0.44f}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}, {"blur", 0.1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1f}, {"blur", 0f}})});
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan13", "zui16"});
            yield return _gameMethods.ExecuteCharacterImageData("luo");
            yield return _gameMethods.OpenDialog(5632); // "此事也为我亲眼目睹。"
            yield return _gameMethods.OpenDialog(5633); // "我感觉自己仿佛在演舞台剧。"
            yield return _gameMethods.Hide("an2");
            yield return _gameMethods.Hide("luo2");
            yield return _gameMethods.PlaySound("sounda5", 0.0f, 1.0f, "audio/sound/he/jintan.ogg");
            yield return _gameMethods.Transition(time:0.5f);
            yield return _gameMethods.OpenDialog(5634); // "人群却爆发出一阵不可思议的惊叹。"
            yield return _gameMethods.OpenDialog(5635); // "看得出来，他们对魔法了解不多，更不清楚灾龙和勇者各自都是什么水平，只能听个热闹，于是格外热衷于这种戏剧化的剧情。"
            yield return _gameMethods.OpenDialog(5636); // "我再次意识到。他们对于这三年里都发生了些什么，一无所知。"
            yield return _gameMethods.OpenDialog(5034); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(5637); // "赫泽尔，你我的名字将连在一起。"
            yield return _gameMethods.OpenDialog(5638); // "我抬高声音。"
            yield return _gameMethods.PlaySound("soundb", 0.0f, 1.0f, "audio/sound/end/bell_chime_9_01.ogg");
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(5639); // "正是命运的青睐，不然我为什么能够杀掉灾祸之龙？"
            yield return _gameMethods.StopSound(channelName:"music3", fadeOut:5f);
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(5640); // "我是受到命运帮助的王女，我们是得到命运之眷顾的国家。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(5641); // "所以，新王是我。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(5642); // "天命……"
            yield return _gameMethods.StopSound(channelName:"music3", fadeOut:1f);
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:2f);
            yield return _gameMethods.StopSound(channelName:"soundc", fadeOut:2f);
            yield return _gameMethods.PlaySound("music1", 0.0f, 1.0f, "audio/music/end/nvwang/PerituneMaterial_OverWorld_Orchestra_loop.mp3");
            yield return _gameMethods.Scene("nvwang_ditu", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(642f, 888f)}, {"zoom", 0.66f}})});
            Defaults.Gui_duihuakuang_you = 0;
            yield return _gameMethods.Show("2-31_zoom");
            yield return _gameMethods.Hide("2-31_zoom");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", -50f}, {"pause", 0.2f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 2f}, {"zpos", 0f}})});
            yield return _gameMethods.PlaySound("sounda2", 0.0f, 1.0f, "<from 0 to 1.5>audio/demo_audio/sound/flapping_wings_01.mp3");
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/manbu/strong_wind2_01.mp3");
            yield return _gameMethods.Transition(time:1f);
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(5643); // "在我！"
            yield return _gameMethods.OpenDialog(5644); // "我将象征王权的权杖高高举起。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(5645); // "愿拜我为王者，单膝跪下，献上你们的忠诚！"
            yield return _gameMethods.PlaySound("soundb", 1f, 4f, "audio/sound/he/huanhu_chixu2.ogg");
            yield return _gameMethods.OpenDialog(5646); // "万众喝彩。"
            yield return _gameMethods.OpenDialog(5647); // "民众已然爆发出亢奋的欢呼。"
            yield return _gameMethods.ExecuteCharacterImageData("w");
            yield return _gameMethods.OpenDialog(5648); // "女王！女王！陛下！陛下！"
            yield return _gameMethods.ExecuteCharacterImageData("w");
            yield return _gameMethods.OpenDialog(5648); // "女王！女王！陛下！陛下！"
        }
        if (Defaults.Bai_xue == 1)
        {
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:3f);
            yield return _gameMethods.Show("nvwang_1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(642f, 888f)}, {"zoom", 0.66f}})});
            yield return _gameMethods.PlaySound("soundc", 0.0f, 2f, "audio/demo_audio/sound/longpaidachibang.mp3");
            yield return _gameMethods.Transition(time:0.5f);
            yield return _gameMethods.OpenDialog(5649); // "——忽然，天边传来一阵龙啸。"
            yield return _gameMethods.OpenDialog(5650); // "一道巨大的阴影遮天蔽日，将人群笼罩在其下。"
            yield return _gameMethods.OpenDialog(5651); // "众人愕然抬头。"
            yield return _gameMethods.OpenDialog(5652); // "晴空光辉之中，银白色的龙鳞折射出梦幻的粼光，肉翅的内膜呈现着淡淡的蓝紫色，宛若银装素裹。"
            yield return _gameMethods.PlaySound("soundb", 1f, 4f, "audio/sound/he/huanhu_chixu2.ogg");
            yield return _gameMethods.ExecuteCharacterImageData("u");
            yield return _gameMethods.OpenDialog(5653); // "龙……！是龙！"
            yield return _gameMethods.ExecuteCharacterImageData("v");
            yield return _gameMethods.OpenDialog(5654); // "白色的龙！！"
            yield return _gameMethods.OpenDialog(5655); // "人群发出了恐慌又亢奋的呼喊。"
            yield return _gameMethods.Scene("jieju8", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.29f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.75f}})});
            Defaults.Gui_duihuakuang_you = 1;
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition(time:0.8f);
            yield return _gameMethods.OpenDialog(5656); // "然而，也许是这头纯白无垢的龙..."
            yield return _gameMethods.OpenDialog(5657); // "人们并未恐惧溃逃，而是呆站在了原地。"
            yield return _gameMethods.StopSound(channelName:"soundd", fadeOut:3f);
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:3f);
            yield return _gameMethods.OpenDialog(5658); // "仿若被迷惑了心智一般..."
            yield return _gameMethods.StopSound(channelName:"soundc", fadeOut:2f);
            yield return _gameMethods.PlaySound("sounda1", 0.0f, 1.0f, "audio/demo_audio/sound/feng2.mp3");
            yield return _gameMethods.OpenDialog(5659); // "它优雅地盘旋..."
            yield return _gameMethods.OpenDialog(5660); // "平稳降落后..."
            yield return _gameMethods.OpenDialog(5661); // "银蓝色的光芒..."
            yield return _gameMethods.OpenDialog(5662); // "宛若一场雪在为之加冕。"
            yield return _gameMethods.OpenDialog(5663); // "接着，龙盘在我背后的建筑上..."
            yield return _gameMethods.OpenDialog(5664); // "它的头颅慵懒地趴伏..."
            yield return _gameMethods.OpenDialog(5665); // "苍白浓密的睫毛低垂..."
            yield return _gameMethods.OpenDialog(5666); // "……四周静的出奇..."
            yield return _gameMethods.OpenDialog(5667); // "教皇脸色铁青..."
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei2", "yan3", "zui14"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.1f, 1.0f)}, {"pos", new Vector2(408f, 2034f)}, {"zoom", 0.44f}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}, {"blur", 0.1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1f}, {"blur", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("luo");
            yield return _gameMethods.OpenDialog(5668); // "是冰霜之龙，它已归顺于女王了！"
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei2", "yan3", "zui9"});
            yield return _gameMethods.OpenDialog(5669); // "洛恩果断高声道。"
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei2", "yan2", "zui9"});
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei8", "yan8", "zui12"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.1f, 1.0f)}, {"pos", new Vector2(-84f, 2148f)}, {"zoom", 0.46f}}), new SameLineParamData(new Dictionary<string, object>{{"alpha", 0f}, {"blur", 0.1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.6f}, {"alpha", 1f}, {"blur", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("an");
            yield return _gameMethods.OpenDialog(5670); // "灾龙已被铲除，冰霜之龙将会庇佑女王..."
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei8", "yan8", "zui16"});
            yield return _gameMethods.OpenDialog(5671); // "安德鲁随即补充。"
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei2", "yan11", "zui15"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}, {"blur", 0f}})});
            yield return _gameMethods.Show("an2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"alpha", 1f}, {"blur", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("luo");
            yield return _gameMethods.OpenDialog(5672); // "恭贺女王！"
            yield return _gameMethods.PlaySound("soundb", 1f, 4f, "audio/sound/he/huanhu_chixu2.ogg");
            yield return _gameMethods.Hide("luo2");
            yield return _gameMethods.Hide("an2");
            yield return _gameMethods.Transition(time:0.5f);
            yield return _gameMethods.OpenDialog(5673); // "全民爆发出剧烈的欢呼..."
            yield return _gameMethods.OpenDialog(5674); // "嘈杂而狂热的呼喊..."
            yield return _gameMethods.PlaySound("soundd", 1f, 3f, "audio/sound/he/huanhu_chixu2.ogg");
            yield return _gameMethods.ExecuteCharacterImageData("w");
            yield return _gameMethods.OpenDialog(5672); // "恭贺女王！"
            yield return _gameMethods.ExecuteCharacterImageData("w");
            yield return _gameMethods.OpenDialog(5675); // "恭贺女王！！"
            yield return _gameMethods.ExecuteCharacterImageData("w");
            yield return _gameMethods.OpenDialog(5676); // "恭贺女王！！！"
        }
        yield return _gameMethods.OpenDialog(5035); // "…………"
        yield return _gameMethods.OpenDialog(5677); // "……………………"
        yield return _gameMethods.Scene("black", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.24f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 1.1f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
        yield return _gameMethods.Transition(time:0.6f);
        yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:3f);
        yield return _gameMethods.StopSound(channelName:"soundd", fadeOut:3f);
        yield return _gameMethods.OpenDialog(5678); // "狂欢庆典持续了三天三夜。"
        Defaults.Persistent.Jq_11_4 = 1;
        yield return _gameMethods.StopSound(channelName:"music1", fadeOut:2f);
        Defaults.Persistent.Gallery_js_lock = 1;
        _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_5");
        _gameMethods.SyncAchievement();
        yield return _gameMethods.Scene("black", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.24f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 1.1f}})});
        yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
        yield return _gameMethods.Transition(time:0.6f);
        yield return _gameMethods.OpenDialog(5679); // "{nw}{w=0.5}"
        yield return _gameMethods.Show("tishi_nvwang", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0.5f, 0.5f)}, {"pos", new Vector2(0.5f, 0.7f)}, {"zpos", 0.0f}})});
        yield return _gameMethods.Transition(time:0.8f);
        yield return _gameMethods.OpenDialog(5680); // "{nw}{w=60}"
        if (Defaults.Persistent.Jq_11_1==1 && Defaults.Persistent.Jq_11_2==1 && Defaults.Persistent.Jq_11_3==1 && Defaults.Persistent.Jq_11_4==1 && Defaults.Persistent.Jq_11_5==1 && Defaults.Persistent.Jq_11_6==1 && Defaults.Persistent.Jq_11_7==1)
        {
            _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_7");
            _gameMethods.SyncAchievement();
        }
    }


}