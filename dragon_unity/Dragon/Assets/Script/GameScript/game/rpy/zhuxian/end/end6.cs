    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class end6 : ILabelProvider
    {
        private GameMethods _gameMethods;

        public end6(GameMethods gameMethods)
        {
            _gameMethods = gameMethods;
        }

            public IEnumerator label_end7()
        {
            if (Defaults.He_xianzai == 1)
            {
                                yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:3f);
                yield return _gameMethods.StopSound(channelName:"soundc", fadeOut:3f);
                yield return _gameMethods.SceneBlack();
                yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
                yield return _gameMethods.Transition(time:0.4f);

            }
            yield return _gameMethods.OpenDialog(5034); // "……"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/demo_audio/sound/feng1.mp3");
            yield return _gameMethods.OpenDialog(5035); // "…………"
            yield return _gameMethods.OpenDialog(5036); // "到达王都时，天已经黑了。"
            yield return _gameMethods.PlaySound("soundb", 2f, 1.0f, "audio/demo_audio/sound/chong1.ogg");
            yield return _gameMethods.StopSound(channelName:"music", fadeOut:5f);
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg19_memory.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg19_memory.jpg");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/jieju/jieju4.jpg");
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition(time:0.6f);
            yield return _gameMethods.OpenDialog(5037); // "在夜色中，我们停在了城外。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan13", "zui8"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.05f, 1.93f)}, {"zoom", 0.41f}})});
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei2", "yan8", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.81f, 2.34f)}, {"zoom", 0.39f}})});
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei2", "yan2", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.46f, 2.34f)}, {"zoom", 0.39f}})});
            yield return _gameMethods.Transition(time:0.8f);
            yield return _gameMethods.OpenDialog(5038); // "我把自己的规划和三人简单说了一下。"
            yield return _gameMethods.PlaySound("music1", 0.0f, 1.0f, "audio/music/end/nvwang/PerituneMaterial_Labyrinth_loop.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(5039); // "那么，现在，先骑士团，还是法师塔？"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei8", "yan23", "zui1"});
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei2", "yan10", "zui1"});
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
            yield return _gameMethods.OpenDialog(5040); // "哪怕这两方势力注定不可能对我鼎力相助，但只要能确保他们保持中立、两不相帮，就足够了。"
            yield return _gameMethods.OpenDialog(5041); // "……只是想也知道，这会很艰难。"
            yield return _gameMethods.OpenDialog(5042); // "这些人在现有的秩序下过得好好的，凭什么支持我呢？"
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei2", "yan2", "zui6"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"ease", 1f}, {"zpos", 156.0f}})});
            yield return _gameMethods.Show("nuo1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"blur", 3f}})});
            yield return _gameMethods.Show("an2", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"blur", 3f}})});
            yield return _gameMethods.Show("jieju4", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"linear", 1f}, {"blur", 3f}})});
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1>audio/sound/jiaobusheng_an_normal1.ogg");
            yield return _gameMethods.ExecuteCharacterImageData("luo");
            yield return _gameMethods.OpenDialog(5043); // "先去法师塔吧。"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei8", "yan8", "zui1"});
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei2", "yan5", "zui14"});
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan1", "zui8"});
            Engine._history = false;
            yield return _gameMethods.ExecuteCharacterImageData("luo_qian");
            yield return _gameMethods.OpenDialog(5044); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui8"});
            yield return _gameMethods.ExecuteCharacterImageData("luo");
            yield return _gameMethods.OpenDialog(5045); // "在同安德鲁汇合之前，我曾在那里求学一年。"
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei2", "yan12", "zui15"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 156.0f}})});
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui1"}, sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 3f}})});
            yield return _gameMethods.Show("nuo1", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 3f}})});
            yield return _gameMethods.Show("jieju4", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"blur", 3f}})});
            yield return _gameMethods.ExecuteCharacterImageData("luo");
            yield return _gameMethods.OpenDialog(5046); // "以我对他们的了解，如果是你，可以说服他们。"
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei2", "yan5", "zui3"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(5047); // "……真的么。"
            yield return _gameMethods.OpenDialog(5048); // "我有点惊讶。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(5049); // "依据是什么？"
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan2", "zui1"});
            Engine._history = false;
            yield return _gameMethods.OpenDialog(5044); // "{nw}{w=0.15}"
            Engine._history = true;
            yield return _gameMethods.Show("an2", parts: new List<string>{"mei1", "yan8", "zui1"});
            yield return _gameMethods.OpenDialog(5050); // "虽然我的确打算给法师塔开出不错的利益条件，作为交换。"
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei2", "yan9", "zui3"});
            yield return _gameMethods.OpenDialog(5051); // "比如，在登基后，我将每年从拨给教会的财政税收中，拿出一部分预算转移给法师塔。"
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan11", "zui8"});
            yield return _gameMethods.OpenDialog(5052); // "——但这毕竟是空中大饼，说服力十分有限。"
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei2", "yan5", "zui4"});
            yield return _gameMethods.ExecuteCharacterImageData("luo");
            yield return _gameMethods.OpenDialog(5053); // "你可以问他们一个问题。"
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei2", "yan5", "zui1"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(5054); // "？"
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan10", "zui11"});
            yield return _gameMethods.ExecuteCharacterImageData("luo_qian");
            yield return _gameMethods.OpenDialog(5055); // "「我们初见时，{nw}{w=0.2}"
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan11", "zui11"});
            yield return _gameMethods.ExecuteCharacterImageData("luo_qian");
            yield return _gameMethods.OpenDialog(5056); // "你向我搭话那次聊的那个话题。」"
            yield return _gameMethods.Show("luo2", parts: new List<string>{"mei1", "yan5", "zui8"});
            yield return _gameMethods.Show("nuo1", parts: new List<string>{"mei7", "yan7", "zui9"});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(5034); // "……"
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:3f);
            yield return _gameMethods.EngineSetVolume(volume:0.3f, delay:1.6f, channelName:"music1");
            yield return _gameMethods.SceneBlack();
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition(time:0.6f);
            yield return _gameMethods.OpenDialog(5057); // "我若有所思，前往了与法师塔贤者的会面。"
            yield return _gameMethods.EngineSetVolume(volume:1f, delay:1f, channelName:"music1");
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg18_memory.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg18_memory.jpg");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/jieju/jieju5.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.03f)}, {"zoom", 0.74f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition(time:0.6f);
            yield return _gameMethods.OpenDialog(5058); // "“——你认为，衡量对错的标准应该位于意志之前，还是意志，决定了对错的标准？”"
            yield return _gameMethods.OpenDialog(5059); // "在我提出这个话题之后，仅仅讨论了片刻，我委婉地向他展示出自己所能提供的利益，又被问了几个关于施政倾向的问题，法师塔的最高贤者便应下了我的请求。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(5034); // "……"
            yield return _gameMethods.OpenDialog(5060); // "不用再犹豫几下的么。"
            yield return _gameMethods.OpenDialog(5061); // "难道是我开出的条件太优惠了？"
            yield return _gameMethods.OpenDialog(5062); // "……不应该啊。"
            yield return _gameMethods.OpenDialog(5063); // "虽然知道洛恩从不会无的放矢，但见他答应得如此爽快，我还是难免意外和怀疑。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(5064); // "……那么，我们就此说定了？"
            yield return _gameMethods.Show("Assets/RenpyResources/images/lihui/npc/npc_fashi.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.08f)}, {"zoom", 0.46f}})});
            yield return _gameMethods.Transition(time:0.4f);
            if (Defaults.Persistent.Povname=="辛西娅")
            {
                                yield return _gameMethods.ExecuteCharacterImageData("k");
                yield return _gameMethods.OpenDialog(5065); // "是的，辛西娅殿下。"

            }
            else
            {
                                yield return _gameMethods.ExecuteCharacterImageData("k");
                yield return _gameMethods.OpenDialog(5066); // "是的，[persistent.povname]殿下。"

            }
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(5034); // "……"
            yield return _gameMethods.ExecuteCharacterImageData("k");
            yield return _gameMethods.OpenDialog(5067); // "灾厄之龙和冰霜巨龙证明了你的实力。"
            yield return _gameMethods.ExecuteCharacterImageData("k");
            yield return _gameMethods.OpenDialog(5068); // "况且，你有勇者和洛恩作保，洛恩注定会成为我们这个时代最伟大的奥术师。"
            yield return _gameMethods.ExecuteCharacterImageData("k");
            yield return _gameMethods.OpenDialog(5069); // "现在，我明白了他选择你的原因。"
            yield return _gameMethods.ExecuteCharacterImageData("k");
            yield return _gameMethods.OpenDialog(5070); // "有时候，道路相近的人，只需要一个问题，就可以彼此确认。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(5034); // "……"
            yield return _gameMethods.OpenDialog(5071); // "这听上去有些过于理想化了。"
            yield return _gameMethods.OpenDialog(5072); // "仅凭这个，他们就能答应在我行动时袖手旁观？"
            yield return _gameMethods.ExecuteCharacterImageData("k");
            yield return _gameMethods.OpenDialog(5073); // "实际上，在我们眼中，人类的统治者是谁，无关紧要。"
            yield return _gameMethods.ExecuteCharacterImageData("k");
            yield return _gameMethods.OpenDialog(5074); // "我们只是需要一个可以研究魔法的平稳环境。"
            yield return _gameMethods.ExecuteCharacterImageData("k");
            yield return _gameMethods.OpenDialog(5075); // "当然，倘若新的国王能稍许关照一下我们，那会更好。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(5076); // "放心。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(5077); // "在这一点上，我们方向一致。"
            yield return _gameMethods.OpenDialog(5078); // "王权被压得太久，我自然会与你们合作。"
            yield return _gameMethods.OpenDialog(5079); // "我想尝试普及魔法，以消弭神圣术的影响力。法师塔与我之间还有很大的合作空间。"
            yield return _gameMethods.OpenDialog(5080); // "这当然称不上容易，但我总能做到。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1>audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.StopSound(channelName:"music1", fadeOut:4f);
            yield return _gameMethods.Show("npc_fashi", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0.0f}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.8f}, {"zpos", 24.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("k");
            yield return _gameMethods.OpenDialog(5081); // "……对了，如果你不介意，我还有个冒昧的问题。"
            yield return _gameMethods.PlaySound("soundb", 0.0f, 1.0f, "audio/demo_audio/sound/xintiao.ogg");
            yield return _gameMethods.OpenDialog(5082); // "我心中微紧。是要图穷匕见了么？"
            yield return _gameMethods.Show("Assets/RenpyResources/images/lihui/npc/npc_fashi.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 24.0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(5083); // "请问。"
            yield return _gameMethods.ExecuteCharacterImageData("k");
            yield return _gameMethods.OpenDialog(5084); // "您就是洛恩口中那位，和他从小相识，/n对他的人生和性格塑造都造成了深远影响的女士么？"
            yield return _gameMethods.StopSound(channelName:"soundb", fadeOut:1f);
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(5085); // "…………什么？"
            yield return _gameMethods.ExecuteCharacterImageData("k");
            yield return _gameMethods.OpenDialog(5086); // "若不冒犯的话，能否透露一下，在您眼中，洛恩是一个怎样的人？"
            yield return _gameMethods.PlaySound("music2", 0.0f, 1.0f, "audio/music/Whimsical_Waltz.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(5087); // "？？？"
            yield return _gameMethods.OpenDialog(5088); // "他似乎意识到了自己的失态，{nw}{w=0.01}"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "<from 0 to 1>audio/sound/jiaobusheng_xin_normal1.ogg");
            yield return _gameMethods.Show("npc_fashi", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}}), new SameLineParamData(new Dictionary<string, object>{{"easein", 0.8f}, {"zpos", 0f}})});
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(5089); // "于是雍容地后退一步，矜持地说道。"
            yield return _gameMethods.ExecuteCharacterImageData("k");
            yield return _gameMethods.OpenDialog(5090); // "请见谅。"
            yield return _gameMethods.ExecuteCharacterImageData("k");
            yield return _gameMethods.OpenDialog(5091); // "对于这一点，我们都很好奇。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(5034); // "……"
            yield return _gameMethods.PlaySound("sound", 0.0f, 0.4f, "audio/sound/moca1.ogg");
            yield return _gameMethods.Show("Assets/RenpyResources/images/lihui/npc/npc_fashi.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}})}, parallel_0: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"xoffset", -4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"xoffset", 4f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"xoffset", 0f}})}, parallel_1: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.06f}, {"yoffset", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.03f}, {"yoffset", -1f}}), new SameLineParamData(new Dictionary<string, object>{{"linear", 0.04f}, {"yoffset", 0f}})});
            yield return _gameMethods.OpenDialog(5092); // "“我们”都是谁啊……！"
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"xoffset", 0f}, {"yoffset", 0f}})});
            yield return _gameMethods.OpenDialog(5034); // "……"
            yield return _gameMethods.OpenDialog(5035); // "…………"
            yield return _gameMethods.Hide("Assets/RenpyResources/images/lihui/npc/npc_fashi.png");
            yield return _gameMethods.Transition(time:0.4f);
            yield return _gameMethods.StopSound(channelName:"music2", fadeOut:5f);
            yield return _gameMethods.OpenDialog(5093); // "总之，虽然中途出了一点不碍事的小意外——我得到了法师塔的保证。"
            yield return _gameMethods.OpenDialog(5094); // "在奥术的起源、伟大的法师先贤——梅林的名义下，我们订立下魔法契约。"
            yield return _gameMethods.OpenDialog(5095); // "他们将暂时关闭为王宫设下的守护法阵，保持中立，必要时刻，也有义务在暗中派出有限的战力来辅助我。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg17_memory.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg17_memory.jpg");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/jieju/jieju6.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.1f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.88f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.TransitionBy("trans_rip_fast");
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/end/footsteps-knight-team-walk-run-castle-hall_01.ogg");
            yield return _gameMethods.OpenDialog(5096); // "然而，在王都骑士团那里，我们碰壁了。"
            yield return _gameMethods.PlaySound("music", 0.0f, 1.0f, "audio/music/end/nvwang/Time_limit.mp3");
            yield return _gameMethods.OpenDialog(5097); // "我当然不会鲁莽到直接对着骑士团摊牌。"
            yield return _gameMethods.OpenDialog(5098); // "只是私下里递了口信给团长，谎称我已从灾厄之龙处生还，觐见过了国王，此刻有事要和他单独商议。"
            yield return _gameMethods.OpenDialog(5099); // "本打算在私密的环境下说降团长。"
            yield return _gameMethods.OpenDialog(5100); // "倘若无法利诱，就武力威逼。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/lihui/npc/npc_qishi.png", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"anchor", new Vector2(0.5f, 1.0f)}, {"pos", new Vector2(0.5f, 1.08f)}, {"zoom", 0.42f}})});
            yield return _gameMethods.Transition(time:0.4f);
            yield return _gameMethods.OpenDialog(5101); // "但这一届骑士团团长的政治素养不错，似乎异常敏感地品味出了其中的不对劲之处。"
            yield return _gameMethods.OpenDialog(5102); // "于是，当我见到他时，就发现他的身边还跟着二十名骑士团的小队长，以此向我暗示——“大家有话当面说”。"
            yield return _gameMethods.OpenDialog(5103); // "见到我这个被抓走的公主真的出场，在场的人员掀起了一波小小的骚乱。"
            yield return _gameMethods.PlaySound("sound", 0.0f, 1.0f, "audio/sound/end/kaijia_1.mp3");
            yield return _gameMethods.ExecuteCharacterImageData("l");
            yield return _gameMethods.OpenDialog(5104); // "居然真的是……！？！"
            yield return _gameMethods.ExecuteCharacterImageData("m");
            yield return _gameMethods.OpenDialog(5105); // "……真的回来了！"
            yield return _gameMethods.ExecuteCharacterImageData("n");
            yield return _gameMethods.OpenDialog(5106); // "难道灾龙…………？！"
            yield return _gameMethods.OpenDialog(5107); // "有人激动，有人敬慕，有人警惕，有人不屑。"
            yield return _gameMethods.ExecuteCharacterImageData("nv2");
            yield return _gameMethods.OpenDialog(5034); // "……"
            yield return _gameMethods.OpenDialog(5108); // "真麻烦。"
            yield return _gameMethods.OpenDialog(5109); // "现在在场的有二十一人。"
            yield return _gameMethods.OpenDialog(5110); // "应付他们不难，可如果不能在一瞬间控制住所有人，/n只要逃出一个去通风报信，我就可能陷入全盘被动。"
            yield return _gameMethods.OpenDialog(5111); // "况且，我是来结盟的，不是为了让我未来失去支持和帮助的。"
            yield return _gameMethods.OpenDialog(5112); // "既然说降这条路走不通，就得改变原定计划了。"
            yield return _gameMethods.OpenSelectMenu(talk: new List<string>{"—调虎离山"}, jump: new List<string>{"label_end6_menu_0_1nafPpk1"}, condition: new List<string>{"NONE"});
                    yield return _gameMethods.OpenSelectMenu(talk: new List<string>{"-好啊"}, jump: new List<string>{"label_end6_menu_1_oC2kVn80"}, condition: new List<string>{"NONE"});
        }

        public IEnumerator label_end7_1()
        {
            yield return _gameMethods.OpenDialog(5607); // "………………"
            yield return _gameMethods.OpenDialog(5608); // "没有任何一方对我的继任提出异议。"
            yield return _gameMethods.Show("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg15_memory.jpg");
            yield return _gameMethods.Hide("Assets/RenpyResources/images/demo_images/demo_images_bg/memory/anniu_bg15_memory.jpg");
            yield return _gameMethods.Scene("Assets/RenpyResources/images/bg/jieju/jieju8.jpg", sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"subpixel", true}, {"pos", new Vector2(0.5f, 1.29f)}, {"anchor", new Vector2(0.5f, 1.0f)}, {"zoom", 0.75f}})});
            yield return _gameMethods.SetCamera(sameLine: new List<SameLineParamData>{new SameLineParamData(new Dictionary<string, object>{{"perspective", true}}), new SameLineParamData(new Dictionary<string, object>{{"glDepth", true}}), new SameLineParamData(new Dictionary<string, object>{{"anchor", new Vector2(0f, 0f)}}), new SameLineParamData(new Dictionary<string, object>{{"xpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"ypos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zpos", 0f}}), new SameLineParamData(new Dictionary<string, object>{{"zoom", 1f}}), new SameLineParamData(new Dictionary<string, object>{{"blur", 0f}})});
            yield return _gameMethods.Transition(time:0.8f);
            yield return _gameMethods.PlaySound("soundd", 1f, 1.0f, "audio/sound/he/huanhu_chixu.ogg");
            yield return _gameMethods.OpenDialog(5609); // "三天之后，加冕仪式在王城广场举行。"
            yield return _gameMethods.OpenDialog(5610); // "群声鼎沸，万众瞩目之中。/n我与为官员相对而立。"
            yield return _gameMethods.OpenDialog(5611); // "安德鲁和洛恩站在我的身后。/n至于诺伯拉，他今早对我说有事要准备，一早便消失了。"
            yield return _gameMethods.OpenDialog(5034); // "……"
            yield return _gameMethods.OpenDialog(5612); // "按照加冕礼的正常流程，此时，我应该谦恭地单膝下跪低头，等待对方为我戴上皇冠。"
            yield return _gameMethods.OpenSelectMenu(talk: new List<string>{"-自己戴上冠冕"}, jump: new List<string>{"label_end6_menu_0_IdEQSfpx"}, condition: new List<string>{"NONE"});
        }
}