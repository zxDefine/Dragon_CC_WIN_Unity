using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DialogueUI : MonoBehaviour
{
    public static DialogueUI Instance;
    public TextMeshProUGUI dialogueText;
    public TextMeshProUGUI dialogueNameText;
    
    // 对话设置
    private string _whatPrefix = "";
    private string _whatSuffix = "";
    private string _characterName = "";
    
    public float charDisplaySpeed = 0.05f;
    public float autoDelay = 2.0f; // 自动播放时延迟秒数

    private Coroutine currentCoroutine; // 打字效果等待
    private string fullText = "";
    private bool isTyping = false;
    private bool nextClicked = false;
    private bool waitForVoice = false;
    private AudioSource voiceAudio;
    
    [Header("自动播放控制")]
    public bool autoMode = false; // ← 公开模式开关
    public Button autoToggleButton; // ← 指向场景中按钮
    // public TextMeshProUGUI autoButtonText; // ← 按钮上的文字

    /// <summary>用于控制对话框显示/隐藏的 CanvasGroup 组件</summary>
    private CanvasGroup _canvasGroup;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            voiceAudio = gameObject.AddComponent<AudioSource>();

            // 确保 CanvasGroup 组件存在，用于 window show/hide 功能
            _canvasGroup = GetComponent<CanvasGroup>();
            if (_canvasGroup == null)
            {
                _canvasGroup = gameObject.AddComponent<CanvasGroup>();
            }
        }
    }
    
    public void ToggleAutoMode()
    {
        // Debug.Log("=====> Toggle auto mode");
        
        autoMode = !autoMode;
        // if (autoButtonText != null)
        //     autoButtonText.text = autoMode ? "自动" : "手动";
        autoToggleButton.GetComponent<AutoButton>().SetIcon(autoMode);
        
        
        if (autoMode && !isTyping && !nextClicked)
        {
            // 手动触发自动播放流程
            StartCoroutine(AutoAdvance());
        }
    }
    
    /// <summary>
    /// 展示文字内容
    /// <remarks>
    /// 对应 Renpy 对话显示逻辑。在每次新对话显示时：
    /// 1. 通过 AudioManager.HandleVoiceOnDialogAdvance() 检查 voice sustain 状态
    /// 2. 如果 sustain == false（默认），停止当前语音
    /// 3. 如果 sustain == true，保持语音播放并重置标记
    /// 4. 检查 AudioManager 的语音通道是否正在播放，决定是否等待语音结束
    /// </remarks>
    /// </summary>
    /// <param name="text">要显示的文本</param>
    /// <param name="forceAuto">是否强制自动继续</param>
    /// <param name="voiceClip">可选语音 AudioClip（保留向后兼容，优先使用 AudioManager 语音通道）</param>
    public void Show(string text, bool forceAuto = false, AudioClip voiceClip = null)
    {
        // 对话推进时，处理语音 sustain 逻辑
        // 如果 sustain 为 false，会停止旧语音；为 true 则保持播放
        if (AudioManager.I != null)
        {
            AudioManager.I.HandleVoiceOnDialogAdvance();
        }

        fullText = text;
        nextClicked = false;

        // 判断是否需要等待语音播放完成
        // 优先检查 AudioManager 的语音通道（由 GameMethods.PlayVoice 触发）
        // 同时保留旧的 voiceClip 参数兼容
        bool hasVoiceFromManager = AudioManager.I != null && AudioManager.I.IsVoicePlaying();
        waitForVoice = voiceClip != null || hasVoiceFromManager;

        // 保留旧的 voiceClip 播放逻辑（向后兼容）
        if (voiceClip != null)
        {
            voiceAudio.clip = voiceClip;
            voiceAudio.Play();
        }

        if (currentCoroutine != null)
            StopCoroutine(currentCoroutine);

        currentCoroutine = StartCoroutine(TypeText(text));
    }

    private IEnumerator TypeText(string text)
    {
        // 设置角色名
        dialogueNameText.text = _characterName;
        
        // 添加对话的前后符号
        text =  _whatPrefix + text + _whatSuffix;
        
        // 开始打印内容
        dialogueText.text = "";
        isTyping = true;

        foreach (char c in text)
        {
            if (nextClicked)
            {
                // BUG-06修复：跳过打字效果时也需要添加前后缀符号
                dialogueText.text = _whatPrefix + fullText + _whatSuffix;
                break;
            }

            dialogueText.text += c;
            yield return new WaitForSeconds(charDisplaySpeed);
        }

        isTyping = false;

        // 自动播放
        if (autoMode)
        {
            // 等待语音播放完成（同时检查 AudioManager 语音通道和旧的 voiceAudio）
            if (waitForVoice)
                yield return new WaitUntil(() => !IsAnyVoicePlaying());

            yield return new WaitForSeconds(autoDelay);
            nextClicked = true;
        }
        else if (waitForVoice)
        {
            // 非自动模式下也等待语音播放完成
            yield return new WaitUntil(() => !IsAnyVoicePlaying());
        }
        
        // 清除设定
        resetSetting();
        
        // 取消chara绘制flag
        CharacterManager.Instance.SetShowTalkCharaIcon(false);
        
        currentCoroutine = null;
    }

    public void SetTalkCharacterName(string characterName)
    {
        _characterName = characterName;
    }

    public bool CheckDialogueCharacter()
    {
        return _characterName != "";
    }

    // 暂时没有地方使用
    public void SetTalkCharacterSymbol(string whatPrefix, string whatSuffix)
    {
        _whatPrefix = whatPrefix;
        _whatSuffix = whatSuffix;
    }

    void Update()
    {
        // 当前在菜单状态时，不允许跳句
        if (SelectionMenuIsActive())
        {
            return;
        }
        
        // 鼠标左键点击 & 不在 UI 上
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            // 只有打字和语音都结束，才允许跳到下一句
            // 同时检查 AudioManager 语音通道和旧的 voiceAudio
            if (!isTyping && (!waitForVoice || !IsAnyVoicePlaying()))
            {
                nextClicked = true;
            }
        }
    }

    public bool WaitForNext()
    {
        return !isTyping && nextClicked;
    }
    
    private IEnumerator AutoAdvance()
    {
        // 等语音播放完成（如果有），同时检查两个语音源
        if (waitForVoice)
            yield return new WaitUntil(() => !IsAnyVoicePlaying());

        yield return new WaitForSeconds(autoDelay);

        nextClicked = true;
    }

    /// <summary>
    /// 检查是否有任何语音正在播放
    /// <remarks>
    /// 同时检查 AudioManager 的语音通道（新系统）和旧的 voiceAudio（向后兼容）。
    /// 任何一个正在播放都返回 true。
    /// </remarks>
    /// </summary>
    /// <returns>是否有语音正在播放</returns>
    private bool IsAnyVoicePlaying()
    {
        // 检查 AudioManager 的语音通道
        bool managerVoicePlaying = AudioManager.I != null && AudioManager.I.IsVoicePlaying();
        // 检查旧的 voiceAudio（向后兼容）
        bool localVoicePlaying = voiceAudio != null && voiceAudio.isPlaying;
        return managerVoicePlaying || localVoicePlaying;
    }

    private bool SelectionMenuIsActive()
    {
        GameObject panelGO = GameObject.Find("SelectionMenuCanvas/SelectionMenuPanel");
        if (panelGO == null)
        {
            // 找不到，直接返回
            return false;
        }

        UISelectionMenu selectionMenu = panelGO.GetComponent<UISelectionMenu>();
        if (selectionMenu == null)
        {
            // 组件没挂，返回false
            return false;
        }
        
        return selectionMenu.IsShow();
    }

    private void resetSetting()
    {
        // 重置对话的前后符号
        _whatPrefix = "";
        _whatSuffix = "";

        // 重置chara名
        _characterName = "";
    }

    // ——— 对话框显示/隐藏控制（对应 Renpy window show / window hide） ———

    /// <summary>
    /// 显示对话框窗口，使用 DOTween 渐变 CanvasGroup alpha 从 0 到 1。
    /// </summary>
    /// <param name="duration">渐变持续时间（秒），默认 0.2 秒</param>
    /// <returns>可用于 yield return 的 Coroutine 等待对象</returns>
    /// <remarks>对应 Renpy 的 window show 语句</remarks>
    public Coroutine ShowWindow(float duration = 0.2f)
    {
        return StartCoroutine(ShowWindowCoroutine(duration));
    }

    /// <summary>
    /// 隐藏对话框窗口，使用 DOTween 渐变 CanvasGroup alpha 从 1 到 0。
    /// </summary>
    /// <param name="duration">渐变持续时间（秒），默认 0.2 秒</param>
    /// <returns>可用于 yield return 的 Coroutine 等待对象</returns>
    /// <remarks>对应 Renpy 的 window hide 语句</remarks>
    public Coroutine HideWindow(float duration = 0.2f)
    {
        return StartCoroutine(HideWindowCoroutine(duration));
    }

    /// <summary>
    /// ShowWindow 的协程实现：渐显对话框并启用交互
    /// </summary>
    private IEnumerator ShowWindowCoroutine(float duration)
    {
        if (_canvasGroup == null) yield break;

        // 使用 DOTween 渐变 alpha
        _canvasGroup.DOKill(); // 中断之前的动画，避免冲突
        _canvasGroup.interactable = true;
        _canvasGroup.blocksRaycasts = true;

        yield return _canvasGroup.DOFade(1f, duration)
            .SetEase(Ease.Linear)
            .WaitForCompletion();

        Debug.Log("[DialogueUI] 对话框已显示（window show）");
    }

    /// <summary>
    /// HideWindow 的协程实现：渐隐对话框并禁用交互
    /// </summary>
    private IEnumerator HideWindowCoroutine(float duration)
    {
        if (_canvasGroup == null) yield break;

        // 使用 DOTween 渐变 alpha
        _canvasGroup.DOKill(); // 中断之前的动画，避免冲突

        yield return _canvasGroup.DOFade(0f, duration)
            .SetEase(Ease.Linear)
            .WaitForCompletion();

        _canvasGroup.interactable = false;
        _canvasGroup.blocksRaycasts = false;

        Debug.Log("[DialogueUI] 对话框已隐藏（window hide）");
    }
}

