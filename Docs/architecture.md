# Unity 框架架构说明

> 维护者：团结架构师  
> 创建日期：2026-04-07  
> 最后更新：2026-04-07

---

## 1. 技术栈

| 项目 | 值 |
|---|---|
| Unity 版本 | 6000.0.51f1 (Unity 6) |
| 渲染管线 | URP (Universal Render Pipeline), 2D Renderer |
| 色彩空间 | Linear |
| 输入系统 | 新输入系统 (activeInputHandler: 2) |
| 第三方插件 | DOTween、TextMesh Pro、Addressable Assets |
| 编程语言 | C# |
| 目标分辨率 | 1920×1080 |

---

## 2. 架构模式

**协程驱动 + 单例 Manager + Facade 模式**

```
GameScript (zhuxian0.cs 等)    middle_data/ (dialogues.txt, labels.txt, ...)
    │                                │
    ▼                                ▼
LabelRegistry (反射注册)  ──→  GameMethods (Facade API 层)
                                     │
                    ┌────────────────┼────────────────┐
                    ▼                ▼                ▼
              ImageManager    AudioManager     DialogManager
              CharacterMgr    CameraManager    DialogueUI
                    │                │                │
                    ▼                ▼                ▼
              Canvas/RawImage  AudioSource     TextMeshPro
```

---

## 3. 目录结构

```
Assets/Script/
├── GameMain.cs              # 游戏入口，启动 label 协程
├── GameMethods.cs           # Facade API 层（所有 GameScript 通过此调用）
├── GameState.cs             # 游戏状态（Defaults/Persistent 静态字段）
├── JsonHelp.cs              # JSON 辅助
├── DataClass/               # 数据类
│   ├── RenpyImage.cs        # 图片/分层立绘数据（含纹理加载）
│   ├── RenpyCharacter.cs    # 角色数据
│   ├── RenpyFade.cs         # Fade 转场参数（字段 private 无 getter — BUG）
│   ├── Matrixcolor.cs       # 色彩矩阵参数（字段 private 无 getter — BUG）
│   ├── SameLineParamData.cs # ATL 参数封装（Dictionary<string, object>）
│   └── SelectInfo.cs        # 选择菜单信息
├── Manager/
│   ├── ImageManager.cs      # 图像管理（1250+行，最复杂模块）
│   ├── CharacterManager.cs  # 角色管理
│   ├── CameraManager.cs     # 相机管理（空壳，33行）
│   ├── CursorManager.cs     # 自定义光标
│   ├── DialogManager.cs     # 对话数据管理
│   └── Audio/
│       ├── AudioManager.cs  # 音频管理（多通道/Addressables）
│       ├── AudioChannel.cs  # 单通道封装
│       └── AudioPathParser.cs # <silence>/<from-to> 解析
├── Label/
│   ├── ILabelProvider.cs    # 标记接口（空）
│   └── LabelRegistry.cs    # 反射 + labels.txt 动态注册
├── Loader/
│   └── DialogueLoader.cs   # 从 dialogues.txt 加载对话
├── UI/
│   ├── UIDialogue.cs        # 对话 UI（打字机效果/自动模式）
│   └── UISelectionMenu.cs   # 选择菜单 UI
├── ShotcutMenuButton/
│   └── AutoButton.cs        # 自动按钮
├── Utils/
│   └── UtilsMethods.cs      # 坐标转换（硬编码 1280×720）
└── GameScript/game/rpy/     # 已转换的剧情脚本（18个 cs 文件）
```

---

## 4. 核心系统详细说明

### 4.1 LabelRegistry — 标签注册与跳转

- **加载方式**：从 `labels.txt` 读取 `方法名,类名,文件路径` 三元组
- **注册机制**：通过反射创建 GameScript 类实例，注入 GameMethods，注册 `方法名 → IEnumerator 委托`
- **执行**：`GameMain.Start()` 调用 `RunCoroutineLabel("label_zhuxian0")` 启动协程
- **跳转**：`ChangeLabelTo()` 停止当前协程，启动新 label
- **缺失**：无 `call/return` 栈式调用机制

### 4.2 GameMethods — Facade API 层

所有 GameScript 通过此类调用游戏操作。约 500+ 行，包含：
- `Show/Hide/Scene` → ImageManager
- `PlaySound/StopSound` → AudioManager
- `OpenDialog` → DialogManager → DialogueUI
- `OpenSelectMenu` → UISelectionMenu
- `SetCamera` → CameraManager
- `Transition/TransitionBy/TransitionWithFadeIn` → 转场
- `ChangeLabelTo` → LabelRegistry
- **大量空实现方法**（ShowBlack/ShowWhite/PlayVoice/SetCamera/WindowSet 等）

### 4.3 ImageManager — 图像管理（最复杂模块）

**图层系统**（8层，对应 Renpy layer）：
```
master0 → master → background → middle → forward → transient → screens → overlay
```

**已实现**：
- Show/Hide/Scene 基本流程
- 复合贴图（RenpyImage layered image）
- 淡入动画（CanvasGroup alpha）
- 5种缓动（linear/ease/easeInBack/easeOutBack/easeOutCubic，用 DOTween）
- 属性动画：alpha/zoom/zpos/xpos/ypos/xoffset

**未实现**：
- parallel 并行动画
- blur/matrixcolor/additive/multiply
- HideWithFade 无淡出（直接 Destroy）
- dissolveType 转场视觉效果

### 4.4 AudioManager — 音频管理

**已实现**：
- 动态通道创建/销毁
- Addressables 异步加载
- 淡入/淡出（线性插值）
- `<silence N>` / `<from X to Y>` 语法解析
- 音效序列播放

**关键 Bug**：
- 循环判定仅匹配 `"music"`（应按 channel 配置表）
- 同通道 Play 不替换旧音频

### 4.5 GameState — 游戏状态

全部使用 `public static` 字段，分为：
- `Defines` — 常量配置（Build/Config/Gui/角色定义字符串）
- `Defaults` — 运行时变量（好感度/剧情标记）
- `Defaults.Persistent` — 跨存档变量（jq_*/结局标记）
- `Engine` — 引擎状态（_dismiss_pause/_history）

**问题**：无序列化/反序列化支持，无法实现存档/读档。

---

## 5. 数据流

### 5.1 中间数据文件

| 文件 | 格式 | 内容 | 加载方式 |
|---|---|---|---|
| `labels.txt` | CSV | 方法名,类名,文件路径 | Addressables（TextAsset） |
| `dialogues.txt` | 自定义 | 对话文本,源文件路径 | File.ReadAllText（**BUG**） |
| `character.json` | JSON | 角色定义 | File.ReadAllText（**BUG**） |
| `image.json` | JSON | 图片/layered image 定义 | File.ReadAllText（**BUG**） |

> **BUG**：dialogues.txt/character.json/image.json 使用 `File.ReadAllText("Assets/...")` 加载，打包后路径不存在，必须改为 Addressables。

### 5.2 资源加载方式

| 资源类型 | 加载方式 | 问题 |
|---|---|---|
| 纹理（Texture2D） | Addressables 异步 + `WaitForCompletion()` 同步阻塞 | 主线程卡顿 |
| 音频（AudioClip） | Addressables 异步 | Release 时机过早 |
| 数据文件 | File.ReadAllText 同步 | 打包后失败 |

---

## 6. Addressable Assets 配置

| Group | 内容 |
|---|---|
| Audio | 音频资源 |
| Images | 图片资源 |
| GUI | GUI 资源 |
| MiddleData | labels.txt, dialogues.txt 等 |
| Default | 默认组 |

**已知问题**：
- Images/Audio 组过大，应按子目录拆分
- 无 Label 策略，不支持按类别预加载
- 资源地址使用完整路径，增加目录体积

---

## 7. 已知架构问题与改进方向

| 问题 | 影响 | 建议 |
|---|---|---|
| GameMethods 职责过重（500+行） | 可维护性差 | 按领域拆分 |
| GameState 全静态字段 | 无法序列化/测试/重置 | 改为可序列化单例 |
| ImageManager 过于庞大（1250+行） | 单一职责违反 | 拆分动画/图层/加载 |
| SameLineParamData 用 Dictionary<string,object> | 类型不安全 | 考虑强类型封装 |
| 过度使用 GameObject.Find | 性能差/脆弱 | 改为 Inspector 引用 |
| 大量 Debug.Log 残留 | 性能和日志噪音 | 条件编译或移除 |
| 动画解析代码重复（5种缓动×相似逻辑） | 维护困难 | 提取通用方法 |
