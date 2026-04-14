using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class GameMethods : MonoBehaviour
{
    public DialogManager _dialogManager;
    public CharacterManager _characterManager;
    public UISelectionMenu uiSelectionMenu;
    
    // 统合manager
    public ImageManager ImageManager;
    
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    
    /// <summary>
    /// u3d处理函数
    /// </summary>
    // void Start()
    // {
    //     _dialogManager = GameObject.Find("Game Resources Manger").GetComponent<DialogManager>();
    //     // _layeredManager = GameObject.Find("Game Resources Manger").GetComponent<LayeredManager>();
    //     _characterManager = GameObject.Find("Game Resources Manger").GetComponent<CharacterManager>();
    //     
    //     // 统合manager
    //     _newImageManager = GameObject.Find("Game Resources Manger").GetComponent<NewImageManager>();
    // }
    
    
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// show
    /// <summary>
    /// 在画面上显示图像（立绘/背景/CG），对应 Renpy 的 show 语句。
    /// 支持即时参数（sameLine）和最多 4 个 parallel 并行动画通道。
    /// </summary>
    /// <param name="imageName">图像名称或路径</param>
    /// <param name="parts">Layered Image 部件列表（角色表情等）</param>
    /// <param name="sameLine">show: 块内直接出现的 ATL 属性</param>
    /// <param name="parallel_0">第 1 个 parallel: 子块的关键帧序列</param>
    /// <param name="parallel_1">第 2 个 parallel: 子块的关键帧序列</param>
    /// <param name="parallel_2">第 3 个 parallel: 子块的关键帧序列</param>
    /// <param name="parallel_3">第 4 个 parallel: 子块的关键帧序列</param>
    /// <remarks>
    /// 当前 ImageManager 仅处理单一的 parallel 参数，M1 阶段将 parallel_0 传给 ImageManager，
    /// parallel_1/2/3 已接收但暂不处理（归入 M3 阶段完整实现）。
    /// </remarks>
    public IEnumerator Show(
        string imageName,
        List<string> parts = null,
        List<SameLineParamData> sameLine = null,
        List<SameLineParamData> parallel_0 = null,
        List<SameLineParamData> parallel_1 = null,
        List<SameLineParamData> parallel_2 = null,
        List<SameLineParamData> parallel_3 = null)
    {
        Debug.Log($"Show imageName:{imageName}");
        // 决策 5.5 方案 C：传递全部 4 路 parallel 到 ImageManager 实现真正并行动画
        yield return ImageManager.ShowWithFade(imageName, "master", parts, sameLine, parallel_0, parallel_1, parallel_2, parallel_3);
    }
     
    /// <summary>
    /// 在画面最上层显示纯黑覆盖层，带渐入动画
    /// </summary>
    /// <param name="time">渐入持续时间（秒），默认 0.5 秒</param>
    /// <param name="sameLine">同行参数数据（保留接口兼容）</param>
    /// <param name="parallel_0">第 1 个 parallel: 子块的关键帧序列（M1 暂不处理）</param>
    /// <param name="parallel_1">第 2 个 parallel: 子块的关键帧序列（M1 暂不处理）</param>
    /// <param name="parallel_2">第 3 个 parallel: 子块的关键帧序列（M1 暂不处理）</param>
    /// <param name="parallel_3">第 4 个 parallel: 子块的关键帧序列（M1 暂不处理）</param>
    /// <returns>协程迭代器</returns>
    /// <remarks>对应 Renpy 的 show black 命令</remarks>
    public IEnumerator ShowBlack(
        float time=0.5f,
        List<SameLineParamData> sameLine = null,
        List<SameLineParamData> parallel_0 = null,
        List<SameLineParamData> parallel_1 = null,
        List<SameLineParamData> parallel_2 = null,
        List<SameLineParamData> parallel_3 = null)
    {
        Debug.Log($"ShowBlack time:{time}");
        yield return ImageManager.ShowColorOverlay("black", Color.black, time);
    }

    /// <summary>
    /// 在画面最上层显示纯白覆盖层，带渐入动画
    /// </summary>
    /// <param name="time">渐入持续时间（秒），默认 0.5 秒</param>
    /// <param name="sameLine">同行参数数据（保留接口兼容）</param>
    /// <returns>协程迭代器</returns>
    /// <remarks>对应 Renpy 的 show white 命令</remarks>
    public IEnumerator ShowWhite(float time=0.5f, List<SameLineParamData> sameLine = null)
    {
        Debug.Log($"ShowWhite time:{time}");
        yield return ImageManager.ShowColorOverlay("white", Color.white, time);
    }
    
    /// 打开对应变量名的贴图
    // public IEnumerator ExecuteShowImageDataFunction(string functionName, List<string> parts = null, List<SameLineParamData> sameLine = null, List<SameLineParamData> parallel = null)
    // {
    //     Debug.Log($"ExecuteShowImageDataFunction functionName:{functionName}");
    //     // for (int i = 0; i < sameLine.Count; i++)
    //     // {
    //     //     sameLine[i].DebugLog();
    //     // }
    //
    //     // 执行对应的函数
    //     yield return _layeredImageManager.ExecuteShowFunction(functionName, parts, sameLine, parallel);
    // }

    /// 打开对应的scene内容
    public IEnumerator ExecuteShowScreenFunction(string sceneName, List<object> functionParams)
    {
        Debug.Log($"ExecuteShowScreenFunction functionName:{sceneName}");
        
        // 
        
        yield return null;
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    
    
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// hide
    public IEnumerator Hide(string imageName, List<SameLineParamData> sameLine = null)
    {
        Debug.Log($"Hide imageName:{imageName}");
        
        // 执行对应的函数
        yield return ImageManager.HideWithFade(imageName, sameLine);
    }
    
    /// <summary>
    /// 隐藏纯黑覆盖层，带渐出动画
    /// </summary>
    /// <param name="time">渐出持续时间（秒），默认 0.5 秒</param>
    /// <param name="sameLine">同行参数数据（保留接口兼容，如 dissolveType）</param>
    /// <returns>协程迭代器</returns>
    /// <remarks>对应 Renpy 的 hide black 命令</remarks>
    public IEnumerator HideBlack(float time=0.5f, List<SameLineParamData> sameLine = null)
    {
        Debug.Log($"HideBlack time:{time}");
        yield return ImageManager.HideColorOverlay("black", time);
    }

    /// <summary>
    /// 隐藏纯白覆盖层，带渐出动画
    /// </summary>
    /// <param name="time">渐出持续时间（秒），默认 0.5 秒</param>
    /// <param name="sameLine">同行参数数据（保留接口兼容）</param>
    /// <returns>协程迭代器</returns>
    /// <remarks>对应 Renpy 的 hide white 命令</remarks>
    public IEnumerator HideWhite(float time=0.5f, List<SameLineParamData> sameLine = null)
    {
        Debug.Log($"HideWhite time:{time}");
        yield return ImageManager.HideColorOverlay("white", time);
    }
    
    /// 关闭对应的scene内容
    public IEnumerator ExecuteHideScreenFunction(string sceneName)
    {
        Debug.Log($"ExecuteHideScreenFunction functionName:{sceneName}");
        
        // 
        
        yield return null;
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    
    
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// play
    /// 播放音乐
    public IEnumerator PlaySound(string channelName = "", float fadeIn = 0.0f, float volume = 0.0f, params string[] soundPath)
    {
        if (AudioManager.I == null)
        {
            Debug.LogError("[GameMethods] AudioManager.I 为 null，无法播放音频！请检查场景中是否有 AudioManager 组件。");
            yield break;
        }
        yield return AudioManager.I.Play(channelName, fadeIn, volume, soundPaths: soundPath);
    }
    
    /// 暂停音乐
    public IEnumerator StopSound(string channelName = "", float fadeOut = 0.0f) => AudioManager.I.Stop(channelName, fadeOut);

    /// 设置音量
    public void SetVolume(string channelName = "", float volume = 0.0f, float delay = 0.001f) => AudioManager.I.SetVolume(channelName, volume);

    /// 静音
    //public IEnumerator SilenceSound(string soundChannel = "", float time = 0.0f)
    //{
    //    Debug.Log($"SilenceSound {soundChannel} {time}");
        
    //    yield return new WaitForSeconds(time);
    //}
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    
    
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// voice
    /// <summary>
    /// 播放语音文件
    /// </summary>
    /// <param name="voicePath">语音资源路径（如 "audio/voice/xxx.ogg"）</param>
    /// <returns>协程迭代器</returns>
    /// <remarks>
    /// 对应 Renpy 的 voice "audio/voice/xxx.ogg" 语句。
    /// 通过 AudioManager 的语音通道播放，不循环，播完自动停止。
    /// </remarks>
    public IEnumerator PlayVoice(string voicePath)
    {
        Debug.Log($"PlayVoice voicePath:{voicePath}");
        yield return AudioManager.I.PlayVoice(voicePath);
    }

    /// <summary>
    /// 保存最后一条语音到对话结束（sustain 效果）
    /// </summary>
    /// <returns>协程迭代器</returns>
    /// <remarks>
    /// 对应 Renpy 的 voice sustain 语句。
    /// 设置 sustain 标记后，下一次对话推进时不会中断当前语音，
    /// 语音会继续播放到自然结束。sustain 只生效一次。
    /// </remarks>
    public IEnumerator SaveLastVoiceToTheEnd()
    {
        Debug.Log("SaveLastVoiceToTheEnd（voice sustain）");
        AudioManager.I.SetVoiceSustain(true);
        yield return null;
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    
    
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// camera
    /// <summary>
    /// 设置相机参数，对应 Renpy 的 camera: ATL 语句。
    /// 解析 sameLine 参数列表，逐个应用到 CameraManager。
    /// </summary>
    /// <param name="sameLine">同行参数列表，包含 xpos/ypos/zpos/zoom/blur 等相机属性</param>
    /// <param name="parallel">并行参数列表（M1 暂不处理，预留给 M3 动画系统）</param>
    /// <returns>协程迭代器</returns>
    /// <remarks>对应 Renpy：camera: 后跟 ATL 属性，如 camera: xpos 200 ypos 100 zoom 1.5</remarks>
    /// <summary>
    /// 设置相机参数，对应 Renpy 的 camera: ATL 语句。
    /// 支持即时参数（sameLine）和最多 4 个 parallel 并行动画通道。
    /// </summary>
    /// <param name="sameLine">camera: 块内直接出现的属性（即时应用）</param>
    /// <param name="parallel_0">第 1 个 parallel: 子块的关键帧序列</param>
    /// <param name="parallel_1">第 2 个 parallel: 子块的关键帧序列</param>
    /// <param name="parallel_2">第 3 个 parallel: 子块的关键帧序列</param>
    /// <param name="parallel_3">第 4 个 parallel: 子块的关键帧序列</param>
    /// <remarks>
    /// Renpy 原版 camera 是非阻塞的，动画在后台运行时剧情继续推进。
    /// 本实现同样非阻塞：立即应用 sameLine 并启动 parallel 协程后返回。
    /// </remarks>
    public IEnumerator SetCamera(
        List<SameLineParamData> sameLine = null,
        List<SameLineParamData> parallel_0 = null,
        List<SameLineParamData> parallel_1 = null,
        List<SameLineParamData> parallel_2 = null,
        List<SameLineParamData> parallel_3 = null)
    {
        Debug.Log("SetCamera");

        if (CameraManager.Instance == null)
        {
            Debug.LogWarning("[SetCamera] CameraManager.Instance 为空，无法应用相机参数。");
            yield break;
        }

        // 1. 即时应用 sameLine 中的参数
        if (sameLine != null)
        {
            for (int i = 0; i < sameLine.Count; i++)
            {
                CameraManager.Instance.ApplyCameraState(sameLine[i]);
            }
        }

        // 2. 启动 parallel 通道的动画协程（非阻塞，后台运行）
        if (parallel_0 != null) CameraManager.Instance.StartParallelAnimation(0, parallel_0);
        if (parallel_1 != null) CameraManager.Instance.StartParallelAnimation(1, parallel_1);
        if (parallel_2 != null) CameraManager.Instance.StartParallelAnimation(2, parallel_2);
        if (parallel_3 != null) CameraManager.Instance.StartParallelAnimation(3, parallel_3);

        yield return null;
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    
    
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// scecne
    /// <summary>
    /// 切换场景（清除所有图层后显示新背景/图像）。
    /// 对应 Renpy 的 scene 语句。
    /// </summary>
    /// <param name="imageName">图像名称或路径</param>
    /// <param name="parts">Layered Image 部件列表（如表情参数）</param>
    /// <param name="sameLine">ATL 属性参数</param>
    /// <param name="parallel">并行动画参数</param>
    public IEnumerator Scene(
        string imageName,
        List<string> parts = null,
        List<SameLineParamData> sameLine = null,
        List<SameLineParamData> parallel = null,
        List<SameLineParamData> parallel_0 = null,
        List<SameLineParamData> parallel_1 = null,
        List<SameLineParamData> parallel_2 = null,
        List<SameLineParamData> parallel_3 = null)
    {
        Debug.Log($"Scene imageName:{imageName}");

        // 兼容两种调用形式：parallel 或 parallel_0 都作为第 1 路
        List<SameLineParamData> p0 = parallel_0 ?? parallel;

        yield return ImageManager.SceneWithFade(imageName, sameLine, p0, parts, parallel_1, parallel_2, parallel_3);
    }
    
    public IEnumerator SceneBlack(List<SameLineParamData> sameLine = null)
    {
        Debug.Log("SceneBlack");
        yield return ImageManager.SceneBlack(sameLine);
    }
    
    public IEnumerator SceneWhite(List<SameLineParamData> sameLine = null)
    {
        Debug.Log("SceneWhite");
        
        // 关闭所有当面显示的贴图
        
        // 将背景改为white
        // if (BackgroundController.Instance != null)
        // {
        //     float time = 0.5f; // 默认的time值
        //     yield return BackgroundController.Instance.OpenBackgroundColorSmooth("#FFF", time:time);
        // }
        yield return ImageManager.SceneWhite(sameLine);
        yield return null;
    }
    
    // public IEnumerator ExecuteSceneImageDataFunction(string functionName, List<SameLineParamData> sameLine = null)
    // {
    //     Debug.Log($"ExecuteSceneImageDataFunction functionName:{functionName}");
    //     // for (int i = 0; i < sameLine.Count; i++)
    //     // {
    //     //     sameLine[i].DebugLog();
    //     // }
    //
    //     // 执行对应的函数
    //     yield return _layeredImageManager.ExecuteSceneFunction(functionName);
    // }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////


    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// nvl
    /// <summary>
    /// 清空 NVL 模式的当前对话页面，对应 Renpy 的 nvl clear 命令。
    /// </summary>
    /// <remarks>
    /// 对应 Renpy: nvl clear。在 NVL 全屏文本模式下，将当前累积的对话清空，开始新的一页。
    /// M1 阶段未实现 NVL 模式（归入 M4 UI 系统），此处仅作占位防止编译错误。
    /// </remarks>
    public IEnumerator NvlClear()
    {
        Debug.Log("NvlClear (M1 阶段占位)");
        yield return null;
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////


    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// select menu
    /// <summary>
    /// 打开选择菜单，显示选项列表并等待用户选择后跳转到对应 label。
    /// 对应 Renpy 的 menu: 语句。
    /// </summary>
    /// <param name="talk">选项文本列表（对应 Renpy menu 中的文本）</param>
    /// <param name="jump">跳转目标 label 列表（与 talk 一一对应）</param>
    /// <param name="condition">条件列表（"NONE" 表示无条件，否则为条件表达式字符串）</param>
    /// <param name="screen">选择界面样式名（如 "choice3"/"choice4" 等，M1 阶段暂不处理）</param>
    /// <remarks>对应 Renpy: menu(screen="choiceX"): "选项文本" jump label_name if condition</remarks>
    public IEnumerator OpenSelectMenu(List<string> talk = null, List<string> jump = null, List<string> condition = null, string screen = null)
    {
        // 根据 condition 过滤选项。Renpy 语义：`"选项" if expr` 只在 expr 为真时显示。
        // M1 阶段支持 "NONE"（总是显示）与 "Defaults.<FieldName>" 形式布尔字段（反射读取）。
        // 其它复杂表达式归入 M4 完整解析。
        List<string> filteredTalk = new List<string>();
        List<string> filteredJump = new List<string>();
        int count = talk?.Count ?? 0;
        for (int i = 0; i < count; i++)
        {
            string cond = (condition != null && i < condition.Count) ? condition[i] : "NONE";
            if (!EvaluateMenuCondition(cond))
            {
                Debug.Log($"[OpenSelectMenu] 过滤掉选项[{i}] '{talk[i]}'，条件 '{cond}' 为 false");
                continue;
            }
            filteredTalk.Add(talk[i]);
            filteredJump.Add(jump != null && i < jump.Count ? jump[i] : null);
        }

        SelectInfo selectInfo = new SelectInfo
        {
            textList = filteredTalk,
            labelList = filteredJump
        };
        Debug.Log($"OpenSelectMenu talk:{talk?.Count}→{filteredTalk.Count} jump:{jump?.Count} screen:{screen}");

        // TODO(M4): screen 参数控制不同的选择界面样式

        yield return uiSelectionMenu.OpenMenu(selectInfo);
    }

    /// <summary>
    /// 评估 menu 选项的条件字符串。返回 true 表示选项应该显示。
    /// 支持：
    ///   "NONE"                            → 始终显示
    ///   "Defaults.<Field>"                → 读取 GameState.cs 上的静态 bool/int 字段
    ///   "Defaults.Persistent.<Field>"     → 读取 Persistent 子对象字段
    ///   前缀 "!"                          → 结果取反
    /// 其它形式（含比较、组合逻辑等）归入 M4 完整表达式解析；此处回退为 false 并记录警告。
    /// </summary>
    private static bool EvaluateMenuCondition(string cond)
    {
        if (string.IsNullOrEmpty(cond) || cond == "NONE") return true;
        string expr = cond.Trim();
        bool negate = false;
        if (expr.StartsWith("!"))
        {
            negate = true;
            expr = expr.Substring(1).TrimStart();
        }
        bool? value = ResolveDottedBool(expr);
        if (!value.HasValue)
        {
            Debug.LogWarning($"[EvaluateMenuCondition] 无法解析条件 '{cond}'，回退为 false");
            return false;
        }
        return negate ? !value.Value : value.Value;
    }

    /// <summary>
    /// 通过反射解析 "Defaults.X" / "Defaults.Persistent.Y" 形式的字段路径，
    /// 返回布尔化后的结果（bool 直接返回；数值类型 0 为 false，非 0 为 true；string 空为 false）。
    /// 解析失败返回 null。
    /// </summary>
    private static bool? ResolveDottedBool(string path)
    {
        string[] parts = path.Split('.');
        if (parts.Length < 2) return null;
        System.Type t = System.Type.GetType(parts[0]);
        if (t == null)
        {
            // 在当前已加载程序集里按短名查找（匹配 Defaults / Engine 等单根类型）
            foreach (var asm in System.AppDomain.CurrentDomain.GetAssemblies())
            {
                t = asm.GetType(parts[0], false, false);
                if (t != null) break;
                foreach (var candidate in asm.GetTypes())
                {
                    if (candidate.Name == parts[0]) { t = candidate; break; }
                }
                if (t != null) break;
            }
        }
        if (t == null) return null;

        object current = null; // 静态根
        for (int i = 1; i < parts.Length; i++)
        {
            string name = parts[i];
            var field = t.GetField(name, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Instance);
            if (field != null)
            {
                current = field.GetValue(current);
                t = field.FieldType;
                continue;
            }
            var prop = t.GetProperty(name, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Instance);
            if (prop != null)
            {
                current = prop.GetValue(current);
                t = prop.PropertyType;
                continue;
            }
            return null;
        }
        if (current == null) return false;
        if (current is bool b) return b;
        if (current is int iv) return iv != 0;
        if (current is long lv) return lv != 0;
        if (current is float fv) return fv != 0f;
        if (current is string sv) return !string.IsNullOrEmpty(sv);
        return true; // 非空引用即 true
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// dialog
    public IEnumerator OpenDialog(int subtitleID)
    {
        // 测试用
        string text = _dialogManager.GetDialogue(subtitleID);
        bool auto = false;
        AudioClip voiceClip = null;
        
        // 检查是不是有设置chara
        if (!_characterManager.GetShowTalkCharaIcon())
        {
            // 没有角色设置的话，清除之前的角色icon
            ImageManager.Instance.ClearCharacter();
            ImageManager.Instance.ClearCurrentCharacterOldPartsNames();
        }
        
        // 打开对话框
        DialogueUI.Instance.Show(text, auto, voiceClip);
        yield return new WaitUntil(() => DialogueUI.Instance.WaitForNext());
    }

    // 测试用，完整功能的对话框
    // public IEnumerator ShowDialogue(string text, bool auto = false, AudioClip voiceClip = null)
    // {
    //     // 打开对话框
    //     DialogueUI.Instance.Show(text, auto, voiceClip);
    //     yield return new WaitUntil(() => DialogueUI.Instance.WaitForNext());
    //         
    //     /////////////////////////////////// 使用案例
    //     // // 自动播放
    //     // yield return ShowDialogue("这是自动模式……", auto: true);
    //     //
    //     // // 播放语音 + 等待语音结束
    //     // AudioClip clip = Resources.Load<AudioClip>("voice/hello");
    //     // yield return ShowDialogue("你好，我是语音内容", voiceClip: clip);
    //     //
    //     // // 同时自动和语音都开启（语音优先）
    //     // yield return ShowDialogue("自动 + 语音", auto: true, voiceClip: clip);
    // }

    /// <summary>
    /// 控制对话框 UI 的显示或隐藏，对应 Renpy 的 window show / window hide 语句。
    /// </summary>
    /// <param name="windowType">窗口操作类型："show" 显示对话框，"hide" 隐藏对话框</param>
    /// <returns>协程迭代器</returns>
    /// <remarks>对应 Renpy：window show / window hide</remarks>
    public IEnumerator SetDialogUIShowOrHide(string windowType)
    {
        Debug.Log($"SetDialogUIShowOrHide windowType:{windowType}");

        if (DialogueUI.Instance == null)
        {
            Debug.LogWarning("[SetDialogUIShowOrHide] DialogueUI.Instance 为 null，无法操作对话框。");
            yield break;
        }

        switch (windowType.ToLower())
        {
            case "show":
                yield return DialogueUI.Instance.ShowWindow();
                break;
            case "hide":
                yield return DialogueUI.Instance.HideWindow();
                break;
            default:
                Debug.LogWarning($"[SetDialogUIShowOrHide] 未知的 windowType: {windowType}，仅支持 show/hide。");
                yield return null;
                break;
        }
    }
    
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    
    
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// label
    public IEnumerator ChangeLabelTo(string labelName)
    {
        Debug.Log("ChangeLabelTo " + labelName);
     
        // 跳转到其他的label
        yield return LabelRegistry.Instance.RunCoroutineByMethodOnly(labelName);
    }
    
    
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    
    
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// character image
    [CanBeNull]
    public IEnumerator ExecuteCharacterImageData(string charaNameFunction, List<string> parts = null)
    {
        // 如果parts是null的话，那就是只显示名字
        yield return _characterManager.ChangeCharacter(charaNameFunction, parts);
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// engine
    public IEnumerator StopEngineTime(float time)
    {
        // 暂停引擎时间，直到出现鼠标单击事件
        Debug.Log($"StopEngineTime {time}");
        
        // 如果给定一个数字，就只会暂停数字对应的秒数。
        yield return new WaitForSeconds(time);
    }

    public IEnumerator EngineSetVolume(float volume, float delay, string channelName)
    {
        // 调整音量
        Debug.Log($"EngineSetVolume  volume:{volume} delay:{delay} channelName:{channelName}");
        
        yield return null;
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    
    
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// achievement
    /// <summary>
    /// 授予成就（M5.1 接入 AchievementManager 真实持久化 + 触发 Toast 通知）。
    /// 对应 Renpy 的 <c>achievement.grant("NEW_ACHIEVEMENT_1_X")</c>。
    /// </summary>
    public void GrantAchievement(string achievementName)
    {
        bool unlocked = AchievementManager.Grant(achievementName);
        if (unlocked)
        {
            // 弹出 toast 通知
            if (AchievementToastScreen.Instance != null)
            {
                AchievementToastScreen.Instance.ShowToast(achievementName);
            }
        }
    }

    /// <summary>
    /// 把成就变更写回磁盘。对应 Renpy 的 <c>achievement.sync()</c>。
    /// </summary>
    public void SyncAchievement()
    {
        AchievementManager.Sync();
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    
    
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// transition（转场效果）

    /// <summary>
    /// 基础 Dissolve 转场效果 -- 等待画面渐变完成。
    /// 由于 ImageManager.ShowWithFade 已内置 FadeCanvasGroup 动画，
    /// 此方法负责提供足够的等待时间让渐变完成，实现视觉上的交叉溶解效果。
    /// </summary>
    /// <param name="time">转场持续时间（秒），默认 0.5 秒</param>
    /// <returns>协程迭代器</returns>
    /// <remarks>对应 Renpy 的 with dissolve / with Dissolve(t) 命令</remarks>
    public IEnumerator Transition(float time=0.5f)
    {
        // Renpy 的 with dissolve / with Dissolve(t) 语义：
        // 从旧画面平滑过渡到新画面。如果旧画面上有 ColorOverlay（show black/white），
        // 转场过程中应该淡出覆盖层，让新画面逐渐显露。
        bool fadedOverlay = false;
        if (ImageManager != null)
        {
            if (ImageManager.HasColorOverlay("black"))
            {
                fadedOverlay = true;
                yield return ImageManager.HideColorOverlay("black", time);
            }
            if (ImageManager.HasColorOverlay("white"))
            {
                fadedOverlay = true;
                yield return ImageManager.HideColorOverlay("white", time);
            }
        }

        if (!fadedOverlay)
        {
            // 没有覆盖层时，正常等待（ShowWithFade 已在画面切换时执行了 FadeCanvasGroup 动画）
            yield return new WaitForSeconds(time);
        }
    }

    /// <summary>
    /// 三段式 Fade 转场效果：淡出到纯色 -> 保持 -> 从纯色淡入。
    /// 阶段1：在 overlay 层创建颜色覆盖层，alpha 从 0 渐变到 1（outTime 秒）
    /// 阶段2：等待 holdTime 秒（此时底层画面已被切换）
    /// 阶段3：覆盖层 alpha 从 1 渐变到 0（inTime 秒），然后销毁覆盖层
    /// </summary>
    /// <param name="outTime">淡出时间（秒）-- 覆盖层从透明到不透明</param>
    /// <param name="holdTime">保持时间（秒）-- 纯色画面停留</param>
    /// <param name="inTime">淡入时间（秒）-- 覆盖层从不透明到透明</param>
    /// <param name="colorCode">颜色代码（如 "#000"、"#fff"、"#ff0000"），使用 ColorUtility 解析</param>
    /// <returns>协程迭代器</returns>
    /// <remarks>对应 Renpy 的 with Fade(out, hold, in, color) 命令</remarks>
    public IEnumerator TransitionWithFadeIn(float outTime, float holdTime, float inTime, string colorCode)
    {
        Debug.Log($"TransitionWithFadeIn outTime:{outTime} holdTime:{holdTime} inTime:{inTime} colorCode:{colorCode}");

        // 解析颜色代码，ColorUtility 要求以 '#' 开头
        Color fadeColor = Color.black;
        string normalizedCode = colorCode;
        if (!normalizedCode.StartsWith("#"))
        {
            normalizedCode = "#" + normalizedCode;
        }
        if (!ColorUtility.TryParseHtmlString(normalizedCode, out fadeColor))
        {
            Debug.LogWarning($"TransitionWithFadeIn: 无法解析颜色代码 '{colorCode}'，使用默认黑色");
            fadeColor = Color.black;
        }

        // 使用固定名称 "_fade_transition" 以避免与 show black/white 的覆盖层冲突
        string overlayName = "_fade_transition";

        // 阶段1：淡出 -- 覆盖层从透明渐变到不透明
        yield return ImageManager.ShowColorOverlay(overlayName, fadeColor, outTime);

        // 阶段2：保持 -- 纯色画面停留，此时底层画面已切换完成
        if (holdTime > 0f)
        {
            yield return new WaitForSeconds(holdTime);
        }

        // 阶段3：淡入 -- 覆盖层从不透明渐变到透明，然后销毁
        yield return ImageManager.HideColorOverlay(overlayName, inTime);
    }

    /// <summary>
    /// 根据转场类型名称执行对应的转场效果。
    /// M1 阶段简单处理：已知类型使用基础 dissolve 效果，未知类型用等待占位。
    /// </summary>
    /// <param name="dissolveType">转场类型名称（如 dissolve、blink2、blink3、fade 等）</param>
    /// <returns>协程迭代器</returns>
    /// <remarks>对应 Renpy 的 with [转场名] 语句</remarks>
    /// <summary>
    /// 按名称执行指定类型的转场效果，对应 Renpy 的 with XXX 语句。
    /// M1 阶段（决策 5.4 方案 B）：所有已知类型统一降级为 0.5 秒 dissolve，避免画面突变；
    /// 真正的 ImageDissolve/MultipleTransition 视觉效果留给 M3 阶段的 Shader 系统实现。
    /// </summary>
    /// <param name="dissolveType">转场类型名称，对应 Renpy demo_transition.rpy 中的定义</param>
    /// <returns>协程迭代器</returns>
    /// <remarks>
    /// 对应 Renpy 原版转场（全游戏共使用 218 次）：
    /// - blink1/blink1_1：复杂记忆闪回眨眼（中间画面 + 多次睁闭眼）
    /// - blink2/blink2_1：快速/慢速眨眼一下
    /// - blink3/blink3_1：慢速/快速单次睁眼
    /// - blink4/blink4_1：捏捏 CG 专用复杂眨眼 / 仅闭眼
    /// - trans_rip_fast/trans_rip_fast1：波纹状图像溶解（使用 waves.jpg 遮罩）
    /// - dissolve/fade/pixellate：标准转场
    /// </remarks>
    public IEnumerator TransitionBy(string dissolveType)
    {
        Debug.Log($"TransitionBy dissolveType:{dissolveType}");

        string lowerType = (dissolveType ?? "").ToLower();

        // M3.5 优先走 TransitionManager.TryPlayNamed 的统一派发（shake/hpunch/push*/epilepsy/none）
        // 这些类型不依赖 ColorOverlay，不需要走后面的 ImageDissolve 分支
        if (TransitionManager.Instance != null && TransitionManager.Instance.TryPlayNamed(lowerType, out IEnumerator namedRoutine))
        {
            yield return namedRoutine;
            yield break;
        }

        // 先清除 ColorOverlay（如 ShowBlack 创建的黑幕）
        // Renpy 的 with XXX 会从旧画面过渡到新画面，覆盖层是旧画面的一部分
        bool hasBlackOverlay = ImageManager != null && ImageManager.HasColorOverlay("black");
        bool hasWhiteOverlay = ImageManager != null && ImageManager.HasColorOverlay("white");

        // 如果有覆盖层且有 TransitionManager，使用 ImageDissolve 效果
        if ((hasBlackOverlay || hasWhiteOverlay) && TransitionManager.Instance != null)
        {
            Color overlayColor = hasBlackOverlay ? Color.black : Color.white;
            string overlayName = hasBlackOverlay ? "black" : "white";

            // 先立即移除 ColorOverlay（因为 TransitionManager 会创建自己的遮罩覆盖层）
            if (ImageManager.HasColorOverlay(overlayName))
            {
                yield return ImageManager.HideColorOverlay(overlayName, 0f); // 立即移除，不淡出
            }

            // 根据转场类型选择不同的 ImageDissolve 参数
            // 对应 Renpy demo_transition.rpy 中的定义
            switch (lowerType)
            {
                case "blink4":
                    // 捏捏CG专用：睁眼 0.7s + 多阶段（简化为单次 1.5s 睁眼）
                    yield return LoadAndPlayImageDissolve("Assets/RenpyResources/images/demo_images/demo_images_transition/eye.png", 1.5f, 128, false, overlayColor);
                    break;
                case "blink2":
                    // 快速眨眼：闭眼 0.4s → 黑 → 睁眼 0.8s（简化为 0.8s 睁眼）
                    yield return LoadAndPlayImageDissolve("Assets/RenpyResources/images/demo_images/demo_images_transition/eye.png", 0.8f, 128, false, overlayColor);
                    break;
                case "blink2_1":
                    // 慢速眨眼：1.3s
                    yield return LoadAndPlayImageDissolve("Assets/RenpyResources/images/demo_images/demo_images_transition/eye.png", 1.3f, 64, false, overlayColor);
                    break;
                case "blink3":
                    // 慢速睁眼 1.5s
                    yield return LoadAndPlayImageDissolve("Assets/RenpyResources/images/demo_images/demo_images_transition/eye.png", 1.5f, 128, false, overlayColor);
                    break;
                case "blink3_1":
                    // 快速睁眼 0.8s
                    yield return LoadAndPlayImageDissolve("Assets/RenpyResources/images/demo_images/demo_images_transition/eye.png", 0.8f, 128, false, overlayColor);
                    break;
                case "blink4_1":
                    // 仅闭眼 0.8s
                    yield return LoadAndPlayImageDissolve("Assets/RenpyResources/images/demo_images/demo_images_transition/eye.png", 0.8f, 64, true, overlayColor);
                    break;
                case "blink1":
                case "blink1_1":
                    // 复杂记忆闪回（简化为 2s 睁眼）
                    yield return LoadAndPlayImageDissolve("Assets/RenpyResources/images/demo_images/demo_images_transition/eye.png", 2f, 128, false, overlayColor);
                    break;
                case "trans_rip_fast":
                    // 波纹溶解 0.8s
                    yield return LoadAndPlayImageDissolve("Assets/RenpyResources/images/demo_images/demo_images_transition/waves.jpg", 0.8f, 32, false, overlayColor);
                    break;
                case "trans_rip_fast1":
                    // 快速波纹 0.6s
                    yield return LoadAndPlayImageDissolve("Assets/RenpyResources/images/demo_images/demo_images_transition/waves.jpg", 0.6f, 32, false, overlayColor);
                    break;
                case "fade":
                    // 裸 `with fade` — 原版默认是短暂黑屏的 fade
                    yield return TransitionWithFadeIn(0.5f, 0f, 0.5f, "#000");
                    break;
                default:
                    // 默认使用 dissolve 淡出
                    yield return Transition(0.5f);
                    break;
            }
        }
        else
        {
            // 没有覆盖层时，根据类型分派
            if (lowerType == "fade")
            {
                yield return TransitionWithFadeIn(0.5f, 0f, 0.5f, "#000");
            }
            else
            {
                // 默认 dissolve
                yield return Transition(0.5f);
            }
        }
    }

    /// <summary>
    /// 加载遮罩纹理并通过 TransitionManager 播放 ImageDissolve 效果。
    /// </summary>
    private IEnumerator LoadAndPlayImageDissolve(string maskPath, float duration, float ramplen, bool reverse, Color color)
    {
        // 通过 Addressables 加载遮罩纹理
        var handle = Addressables.LoadAssetAsync<Texture2D>(maskPath);
        yield return handle;

        if (handle.Status == AsyncOperationStatus.Succeeded && handle.Result != null)
        {
            yield return TransitionManager.Instance.PlayImageDissolve(handle.Result, duration, ramplen, reverse, color);
            Addressables.Release(handle);
        }
        else
        {
            Debug.LogWarning($"[TransitionBy] 无法加载遮罩纹理: {maskPath}，回退到普通 dissolve");
            yield return new WaitForSeconds(duration);
        }
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    
    
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// 辅助函数
    // public IEnumerator OpenTexture(UnitImageInfo imageInfo)
    // {
    //     Vector2 actualPos = imageInfo.pos;  // 使用默认值
    //     Vector2 actualAnchor = Vector2.zero;  // 使用默认值
    //    
    //     // 读取贴图
    //     TextureManager.Instance.LoadImageTexture(imageInfo.texPath);
    //     
    //     // 拿到贴图的handle
    //     AsyncOperationHandle<Texture2D> handle = TextureManager.Instance.GetImageTexture(imageInfo.texPath);
    //     
    //     // 绘制贴图
    //     if (BackgroundController.Instance != null)
    //     {
    //         yield return BackgroundController.Instance.OpenBackgroundTextureSmooth(handle, actualPos, actualAnchor, imageInfo.zoom);
    //         // Debug.Log("OpenTexture " + $"texPath:{imageInfo.texPath} actualPos:{actualPos} actualAnchor:{actualAnchor} zoom:{imageInfo.zoom}");
    //     }
    //     
    //     yield return null;
    // }
    
    // public IEnumerator CloseTexture(UnitImageInfo imageInfo)
    // {
    //     // 拿到贴图的handle
    //     AsyncOperationHandle<Texture2D> handle = TextureManager.Instance.GetImageTexture(imageInfo.texPath);
    //     Texture2D texture = handle.WaitForCompletion();
    //     if (texture == null)
    //     {
    //         Debug.LogWarning($"传入的贴图为{imageInfo.texPath} null");
    //         yield return null;
    //     }
    //     // 绘制贴图
    //     if (BackgroundController.Instance != null)
    //     {
    //         yield return BackgroundController.Instance.CloseBackgroundTextureSmooth(handle);
    //         Debug.Log("CloseTexture " + $"texPath:{imageInfo.texPath} zoom:{imageInfo.zoom}");
    //     }
    //     
    //     yield return null;
    // }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    

    /// 关闭贴图
    // public IEnumerator CloseTexture(string textureName)
    // {
    //     Debug.Log("CloseTexture " + textureName);
    //     yield return null;
    // }
    
    /// 关闭贴图(黑色)
    // public IEnumerator CloseTextureBlack(float time=0.5f)
    // {
    //     if (BackgroundController.Instance != null)
    //     {
    //         yield return BackgroundController.Instance.CloseBackgroundColorSmooth(time:time);
    //         Debug.Log("CloseTextureBlack ");
    //     }
    // }


    
    // /// <summary>
    // /// 特效函数
    // /// </summary>
    // public IEnumerable SnowBlossom(UnitImageInfo imageInfo, float count, float border, float start, bool fast, bool horizontal, Vector2? xspeed= null, Vector2? yspeed= null)
    // {
    //     Vector2 actualXspeed = xspeed ?? Vector2.zero;  // 使用默认值
    //     Vector2 actualYspeed = yspeed ?? Vector2.zero;  // 使用默认值
    //     
    //     Debug.logger.Log($"SnowBlossom -> image:({imageInfo.texPath}, {imageInfo.zoom})count:{count} border:{border} xspeed:{actualXspeed} yspeed:{actualYspeed} start:{start} fast:{fast} horizontal:{horizontal}");
    //     yield return null;
    // }
    
    // /// <summary>
    // /// 执行组合特效
    // /// </summary>
    // public IEnumerator ExecuteUnitTransitionFunction(string unitTransitionName)
    // {
    //     Debug.Log($"ExecuteUnitTransitionFunction unitTransitionName:{unitTransitionName}");
    //     
    //     // 执行对应特效
    //     // _unitImageManager.executeTransitionFunction(unitTransitionName);
    //     
    //     yield return null;
    // }
    
    // todo：最优先对应
    // 拆分这些函数
    /// <summary>
    /// 设置chara角色
    /// </summary>


    /// <summary>
    /// 跳转label处理
    /// </summary>


    /// <summary>
    /// 设置对话窗口模式，对应 Renpy 的 window auto / window show / window hide。
    /// </summary>
    /// <param name="setTypeName">窗口设置类型："auto" 自动模式，"show" 显示，"hide" 隐藏</param>
    /// <returns>协程迭代器</returns>
    /// <remarks>对应 Renpy：window auto / window show / window hide</remarks>
    public IEnumerator WindowSet(string setTypeName)
    {
        Debug.Log("WindowSet " + setTypeName);

        switch (setTypeName.ToLower())
        {
            case "show":
                yield return DialogueUI.Instance?.ShowWindow();
                break;
            case "hide":
                yield return DialogueUI.Instance?.HideWindow();
                break;
            case "auto":
                // window auto 模式：对话框将在有对话时自动显示，无对话时自动隐藏
                // M1 阶段仅记录日志，实际 auto 逻辑由对话系统在显示/结束对话时自行控制
                Debug.Log("[WindowSet] window auto 模式已设置（M1 阶段由对话系统自动管理）。");
                break;
            default:
                Debug.LogWarning($"[WindowSet] 未知的窗口设置类型: {setTypeName}");
                break;
        }

        yield return null;
    }
    
    /// 更新dialog

    
}