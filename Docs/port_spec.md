# 移植规格总纲（Port Specification）

> 维护者：高级项目经理  
> 创建日期：2026-04-07  
> 最后更新：2026-04-07  
> 状态：初稿，待用户审批

---

## 0. 项目概述

- **源项目**：`/dragon_yuanban/game/` — Renpy 视觉小说《灾厄黑龙与谎言公主》
- **目标项目**：`/dragon_unity/Dragon/Assets/` — Unity 6 (6000.0.51f1)，URP 2D Renderer
- **验收标准**：Unity 版游戏表现与 Renpy 原版完全一致
- **基准分辨率**：Renpy 原版 1280×720，Unity 端 1920×1080

---

## 1. 用户决策记录

| 决策项 | 决定 | 日期 |
|---|---|---|
| 被注释结局 end1/end2/end4 | 不移植 | 2026-04-07 |
| gui/xd/ SDK 资源 | 需要迁移 | 2026-04-07 |
| testa1_ 语音 + test1.webm 视频 | 正式内容，需迁移 | 2026-04-07 |
| 工作起点 | 从 M0（规格文档）开始 | 2026-04-07 |

---

## 2. 功能清单与实现状态

### 2.1 核心对话系统

| 编号 | 功能 | Renpy 实现 | Unity 状态 | 优先级 |
|---|---|---|---|---|
| F-DLG-01 | 基础对话显示（打字机效果） | 内建 say screen | DialogueUI.cs — 已实现 | — |
| F-DLG-02 | 角色名显示 + 前后缀符号（「」） | Character 定义 | CharacterManager.cs — 已实现 | — |
| F-DLG-03 | `{nw}` 不等待标签（全游戏 3454 处） | 内建文本标签 | **未实现** | P0 |
| F-DLG-04 | `{w=X}` 延时等待标签 | 内建文本标签 | **未实现** | P0 |
| F-DLG-05 | `extend` 追加文本 | 内建 | **未实现** | P0 |
| F-DLG-06 | NVL 全屏文本模式 | nvl screen | **未实现** | P1 |
| F-DLG-07 | 3种 say 屏幕变体（say/say1/say2） | screens.rpy | **未实现**（仅1种） | P1 |
| F-DLG-08 | SideImage 角色小头像 | screens.rpy | **未实现** | P2 |
| F-DLG-09 | 自定义对话框背景（window_background） | Character 属性 | **未实现** | P2 |
| F-DLG-10 | 对话历史回看 | 内建 history_length=50 | **未实现** | P2 |
| F-DLG-11 | `$_history = False/True` 控制 | 内建 | **未实现** | P1 |
| F-DLG-12 | `$_dismiss_pause` 控制暂停可跳过性 | 内建 | **未实现** | P1 |

### 2.2 分支选择系统

| 编号 | 功能 | Unity 状态 | 优先级 |
|---|---|---|---|
| F-SEL-01 | 基础 menu 选项 + label 跳转 | UISelectionMenu — 已实现 | — |
| F-SEL-02 | 6种 choice 变体样式 | **未实现**（仅1种） | P1 |
| F-SEL-03 | 条件选项（menu 中 if 控制可见性） | **未实现** | P1 |
| F-SEL-04 | 禁用选项（insensitive 状态） | **未实现** | P2 |
| F-SEL-05 | 选项悬停音效 + 点击音效 | **未实现** | P2 |

### 2.3 图像管理

| 编号 | 功能 | Unity 状态 | 优先级 |
|---|---|---|---|
| F-IMG-01 | show/hide 基础立绘显示隐藏 | ImageManager — 已实现 | — |
| F-IMG-02 | scene 切换背景（清除所有图层） | SceneWithFade — 已实现 | — |
| F-IMG-03 | show black / show white 纯色覆盖 | **空实现** | P0 |
| F-IMG-04 | hide 淡出动画（当前直接删除） | **缺失淡出** | P0 |
| F-IMG-05 | parallel 并行动画 | **完全未实现** | P0 |
| F-IMG-06 | ATL 缓动函数（linear/ease/easein_back 等） | 部分实现（5种） | P1 |
| F-IMG-07 | blur 模糊效果 | **未实现** | P1 |
| F-IMG-08 | matrixcolor 色彩矩阵 | **数据类在，Shader 缺失** | P1 |
| F-IMG-09 | additive 混合模式 | **未实现** | P1 |
| F-IMG-10 | zpos 伪3D纵深 | **未实现** | P1 |
| F-IMG-11 | blend "multiply" 混合（立绘腮红等） | **未实现** | P1 |
| F-IMG-12 | Layered Image 表情切换 | RenpyImage — 基本实现 | — |
| F-IMG-13 | 帧动画（feather_ani 80帧等） | **未实现** | P2 |
| F-IMG-14 | 粒子效果（SnowBlossom/DustParticles） | **未实现** | P2 |

### 2.4 转场特效

| 编号 | 功能 | Unity 状态 | 优先级 |
|---|---|---|---|
| F-TRN-01 | dissolve / Dissolve(t) 交叉溶解 | **仅 WaitForSeconds，无视觉** | P0 |
| F-TRN-02 | Fade(out, hold, in, color) 三段式 | **仅等待时间** | P0 |
| F-TRN-03 | ImageDissolve(mask, t, ramplen) 图案溶解 | **未实现，需 Shader** | P0 |
| F-TRN-04 | blink 系列 MultipleTransition | **未实现** | P1 |
| F-TRN-05 | Shake 画面抖动 | **未实现** | P1 |
| F-TRN-06 | hpunch 水平抖动 | **未实现** | P1 |
| F-TRN-07 | Glitch 故障效果 | **未实现** | P2 |
| F-TRN-08 | with Pause(N) | StopEngineTime — 已实现 | — |

### 2.5 音频系统

| 编号 | 功能 | Unity 状态 | 优先级 |
|---|---|---|---|
| F-AUD-01 | play music/sound 多通道播放 | AudioManager — 已实现 | — |
| F-AUD-02 | fadeIn/fadeOut 淡入淡出 | AudioChannel — 已实现 | — |
| F-AUD-03 | `<silence N>` / `<from X to Y>` 语法 | AudioPathParser — 已实现 | — |
| F-AUD-04 | voice 语音播放 | **空实现（仅 Debug.Log）** | P0 |
| F-AUD-05 | voice sustain 语音持续 | **空实现** | P0 |
| F-AUD-06 | auto_voice 自动语音（2688文件） | **未实现** | P1 |
| F-AUD-07 | 通道循环属性正确映射 | **逻辑错误（仅 "music" 匹配）** | P0 |
| F-AUD-08 | 同通道替换播放 | **逻辑错误（不替换，仅改音量）** | P0 |
| F-AUD-09 | AudioMixer 三路混音（music/sfx/voice） | **未实现** | P1 |
| F-AUD-10 | EngineSetVolume 运行时音量调节 | **空实现** | P1 |
| F-AUD-11 | queue music 排队播放 | **未实现** | P2 |

### 2.6 Camera 系统

| 编号 | 功能 | Unity 状态 | 优先级 |
|---|---|---|---|
| F-CAM-01 | SetCamera 基础参数（pos/zoom/blur） | **完全空实现** | P0 |
| F-CAM-02 | camera ATL 动画（linear/ease 插值） | **未实现** | P1 |
| F-CAM-03 | perspective 透视投影 | **未实现** | P1 |
| F-CAM-04 | camera 震动（Wiggle/xoffset+yoffset） | **未实现** | P1 |

### 2.7 UI 系统

| 编号 | 功能 | Unity 状态 | 优先级 |
|---|---|---|---|
| F-UI-01 | 对话框 UI | DialogueUI — 基本实现 | — |
| F-UI-02 | 选项菜单 UI | UISelectionMenu — 基本实现 | — |
| F-UI-03 | 快捷菜单（10个按钮） | **仅 AutoButton** | P0 |
| F-UI-04 | 主菜单（标题画面） | **未实现** | P1 |
| F-UI-05 | 游戏内菜单（ESC） | **未实现** | P1 |
| F-UI-06 | 存档界面 | **未实现** | P1 |
| F-UI-07 | 读档界面 | **未实现** | P1 |
| F-UI-08 | 设置界面 | **未实现** | P1 |
| F-UI-09 | 历史回看界面 | **未实现** | P2 |
| F-UI-10 | 好感度界面 | **未实现** | P2 |
| F-UI-11 | 确认弹窗 | **未实现** | P1 |
| F-UI-12 | 姓名输入界面 | **未实现** | P1 |
| F-UI-13 | Skip 快进指示器 | **未实现** | P2 |
| F-UI-14 | 通知消息 | **未实现** | P2 |
| F-UI-15 | show screen / hide screen 框架 | **空实现** | P1 |
| F-UI-16 | window show / hide 对话框控制 | **空实现** | P0 |

### 2.8 游戏逻辑

| 编号 | 功能 | Unity 状态 | 优先级 |
|---|---|---|---|
| F-LOG-01 | label / jump 跳转 | LabelRegistry — 已实现 | — |
| F-LOG-02 | call / return 调用栈 | **未实现** | P1 |
| F-LOG-03 | $ variable = value 变量赋值 | Defaults 静态字段 — 已实现 | — |
| F-LOG-04 | if/elif/else 条件分支 | C# if/else — 已实现 | — |
| F-LOG-05 | persistent 持久化存储 | **数据定义在，无序列化** | P1 |
| F-LOG-06 | 存档/读档系统 | **完全不存在** | P1 |
| F-LOG-07 | 成就系统 | **仅 Debug.Log** | P2 |
| F-LOG-08 | renpy.input 玩家输入名字 | **未实现** | P1 |

---

## 3. 资源迁移清单

### 3.1 迁移状态总览

| 资源类型 | Renpy 数量 | Unity 数量 | 完成率 | 备注 |
|---|---|---|---|---|
| 图片（images/） | 1,830 | 1,830 | **100%** | 完全一致 |
| 音频（audio/） | 3,066 | 3,011 | **98.2%** | 缺 54 个 testa1_ 语音 + 1 个 webm |
| GUI（gui/） | 512 | 502 | **98%** | 缺 gui/xd/ 目录 10 个 SDK 文件 |

### 3.2 待补充资源

| 文件 | 来源 | 优先级 |
|---|---|---|
| `audio/voice/testa1_*.ogg`（54个） | dragon_yuanban/game/audio/voice/ | P1 |
| `audio/video/test1.webm` | dragon_yuanban/game/audio/video/ | P1 |
| `gui/xd/`（10个文件） | dragon_yuanban/game/gui/xd/ | P2 |

### 3.3 需要新建的 Shader 文件

| Shader 名称 | 用途 | 优先级 |
|---|---|---|
| ImageDissolve.shader | 遮罩溶解转场（眨眼/波纹） | P0 |
| GaussianBlur.shader | 高斯模糊效果 | P0 |
| MatrixColor.shader | 色彩矩阵变换（Invert/Contrast/Saturation/Brightness/Hue） | P0 |
| AdditiveBlend.shader | 叠加混合模式 | P1 |
| MultiplyBlend.shader | 乘法混合模式（立绘腮红等） | P1 |
| Glitch.shader | 故障效果（后处理） | P2 |

---

## 4. 剧情脚本转换状态

### 4.1 已转换（18 个 rpy → 36 个 cs）

| rpy 文件 | 行数 | cs 文件 | Phase |
|---|---|---|---|
| zhuxian0.rpy | 1,970 | zhuxian0.cs + zhuxian0_menu.cs | 先期 |
| zhuxian_1.rpy | 5,481 | zhuxian_1.cs + zhuxian_1_menu.cs | 先期 |
| zhuxian_2.rpy | 3,604 | zhuxian_2.cs + zhuxian_2_menu.cs | 先期 |
| zhuxian_3.rpy | 3,101 | zhuxian_3.cs + zhuxian_3_menu.cs | 先期 |
| zhuxian4.rpy | 4,142 | zhuxian4.cs + zhuxian4_menu.cs | 先期 |
| wangzi.rpy | 1,956 | wangzi.cs + wangzi_menu.cs | 先期 |
| end3.rpy | 187 | end3.cs + end3_menu.cs | 先期 |
| end5.rpy | 1,000 | end5.cs + end5_menu.cs | 先期 |
| end6.rpy (label:end7) | 2,931 | end6.cs + end6_menu.cs | 先期 |
| bai1.rpy | 1,094 | bai1.cs（手工，无 menu） | 3.3 |
| juezhan.rpy | 1,135 | juezhan.cs + juezhan_menu.cs | 3.4 |
| juezhanhou_bai.rpy | 519 | juezhanhou_bai.cs（无 menu） | 3.4 |
| fanhuitu.rpy | 365 | fanhuitu.cs（无 menu） | 3.4 |
| tuanzhan_you.rpy | 1,558 | tuanzhan_you.cs + tuanzhan_you_menu.cs | 3.5 |
| zhuxian5.rpy | 3,749 | zhuxian5.cs + zhuxian5_menu.cs | 3.6 |
| zhuxian6.rpy | 3,200 | zhuxian6.cs + zhuxian6_menu.cs | 3.7 |
| bai.rpy | 3,033 | bai.cs + bai_menu.cs | 3.8 |
| end7.rpy (label:end6) | 2,625 | end7.cs + end7_menu.cs | 3.9 |

> Phase 3.5+ 通过 `rpy_to_cs_transcriber.py` 机械转译，dialog ID 均来自 `rpy_dialogs_<name>.json` 权威源，对齐率 100%。脚本当前支持 rpy 对话/show/scene/hide/camera/ATL 块/play/stop/with（Dissolve/Fade/Shake/PushMove/具名过渡）/pause/voice/$/python/if-elif-else/menu（含 `if cond:` 后缀）/label/jump/return/空台词节拍/image 声明。

### 4.2 待转换

（全部完成）

### 4.2.1 Phase 3.5+ 累计增量

- `dialogues.txt`：+3222 条新 dialog（6663–9884），复用 1152 条既有 ID
- `labels.txt`：+68 条 label 注册（含 4 条孤儿清理）
- `rpy_to_cs_transcriber.py` 新增 ~1000 行确定性转译逻辑

### 4.3 不移植

| rpy 文件 | 行数 | 原因 |
|---|---|---|
| end1.rpy | 1,165 | 99%+ 被注释，用户确认不移植 |
| end2.rpy | 983 | 99%+ 被注释，用户确认不移植 |
| end4.rpy | 937 | 99%+ 被注释，用户确认不移植 |

---

## 5. P0 阻塞性 Bug 清单

本次（M1 收尾）核查后，11 条 P0 bug 中 10 条已在早期修复，1 条本次修复。

| 编号 | 问题 | 状态 | 备注 |
|---|---|---|---|
| BUG-01 | `GameMethods.Show` 缺少 parallel_0/1 参数 | ✅ 已修复 | Show 签名现含 parallel_0..parallel_3（决策 5.5 方案 C） |
| BUG-02 | `File.ReadAllText` Editor-only 硬编码路径 | ✅ 本次修复 | DialogManager/CharacterManager/ImageManager 均改为 Addressables 异步加载；新增 `IsReady` 标记；GameMain poll 三者 ready 后才进入主流程 |
| BUG-03 | `SceneBlack` alpha=0（应=1） | ✅ 已修复 | ImageManager L443 `new Color(0f, 0f, 0f, 1f)` |
| BUG-04 | `PlayVoice`/`SaveLastVoiceToTheEnd` 返回 IEnumerable | ✅ 已修复 | 两个方法现返回 IEnumerator（GameMethods.cs L213/L228） |
| BUG-05 | `RenpyFade`/`Matrixcolor` 字段无 getter | ✅ 已修复 | 两个类均使用表达式体属性公开只读 getter |
| BUG-06 | 对话跳过时缺少前后缀符号 | ✅ 已修复 | UIDialogue.TypeText L133 跳过时使用 `_whatPrefix + fullText + _whatSuffix` |
| BUG-07 | `AudioManager.Play` 同通道不替换旧音频 | ✅ 已修复 | AudioManager.Play 先停止旧协程与音频（含 crossfade 分支） |
| BUG-08 | 循环判定仅匹配 `"music"` | ✅ 已修复 | Channel 分类现覆盖 music / music1~4 循环、music5 不循环、soundb~soundf 循环 |
| BUG-09 | GameScript 中路径含反斜杠 | ✅ 已修复 | grep 全库未见实际路径反斜杠，仅剩 `\n` 注释转义（Renpy 对白内合法） |
| BUG-10 | `GameState.cs` An_2 字符串截断 | ✅ 已修复 | An_2 现为完整 `Character("洝&%魯#", voice_tag=...)` |
| BUG-11 | `UISelectionMenu.OnSelect` null 检查后未 yield break | ✅ 已修复 | UISelectionMenu.cs L124/L134 均显式 `yield break` |

### 5.1 BUG-02 本次修复细节

**问题**：三大 Manager 在 Editor 下用 `File.ReadAllText("Assets/RenpyResources/middle_data/*.txt|json")` 同步读取，打成 Player 后 `Assets/` 不存在，加载失败。

**修复**（参考既有 LabelRegistry.cs L44 的 Addressables 模式）：

1. `DialogueLoader` 新增 `LoadDialoguesFromText(string)` 入口，原 `LoadDialogues(filePath)` 改为 `File.ReadLines` 的 BC 包装。
2. `DialogManager.Awake` 只保留 Instance 设置，移除 `DialogueLoader.LoadDialogues(filePath)` 同步调用；新增 `IEnumerator Start()` → `LoadDialoguesAsync()` 使用 `Addressables.LoadAssetAsync<TextAsset>("Assets/RenpyResources/middle_data/dialogues.txt")`，加载完毕后 `IsReady = true`。
3. `CharacterManager` 同样处理：Start 改为 IEnumerator，`LoadCharacterJsonAsync` 异步加载 character.json。
4. `ImageManager` 同样处理：Awake 里的 JSON 解析整段迁移到 `LoadImageJsonAsync`；每个 RenpyImage 的解析逻辑保留不动。
5. `GameMain.Start`：`yield return null` 之后加入 `while (!ManagersReady()) yield return null;` 轮询，确保三大 Manager 的 Addressables 加载完成才进入 `RegisterAllLabelsFromTxt` 与 `startLabel` 协程。

**Addressables 地址**：使用既有 `MiddleData` Asset Group（已注册 `Assets/RenpyResources/middle_data` 整个文件夹，子文件通过完整 asset path 自动索引，与 LabelRegistry 用法一致）。

**兼容性**：`DialogueLoader.LoadDialogues(filePath)` 保留给未来可能的离线工具/Editor 脚本使用；运行时不再走此入口。

---

## 6. 里程碑计划

### M0 — 规格文档补全 ✅
- [x] port_spec.md（本文件）
- [x] renpy_analysis.md（390 行，原版逆向分析）
- [x] architecture.md（203 行，目标工程架构说明）
- [x] asset_spec.md（193 行，资源迁移规格）

### M1 — P0 Bug 修复 + GameMethods 空实现补全 ✅
- [x] 11 条 P0 bug 全部修复（BUG-01~11，详见 §5）
- [x] `OpenSelectMenu` condition 反射求值（支持 `"NONE"` / `"Defaults.X"` / `"Defaults.Persistent.X"` / 前缀 `!` 取反）
- [x] `TransitionBy` 已实现 10+ 种 ImageDissolve 转场（eye/waves 遮罩，M3 继续打磨）
- NvlClear 暂按原计划归入 M4（NVL 模式需要 UI 子系统配套）

### M2 — 剩余剧情脚本转换 ✅
- [x] P0 关键路径：zhuxian5/6（Phase 3.6/3.7）, juezhan（Phase 3.4）, tuanzhan_you（Phase 3.5）, fanhuitu（Phase 3.4）
- [x] P1 分支：bai（Phase 3.8）, bai1（Phase 3.3）, end7（Phase 3.9）, juezhanhou_bai（Phase 3.4）
- [x] `rpy_to_cs_transcriber.py` 确定性转译工具链建立
- 共 18 个 rpy 全部转换完成（9 条新增 + 9 条先期），见 §4.1

### M3 — 转场与视觉特效系统 🟡 进行中
- [x] M3.1 ScreenShake / hpunch：`TransitionManager.PlayShake` 对 Camera.main 做逐帧阻尼扰动；`TransitionBy("shake"/"hpunch")` 走 M3.5 统一派发入口
- [x] M3.2 PushMove：`TransitionManager.PlayPushMove` 支持 `pushleft/pushright/pushup/pushdown`，ease-out 动画 0.3s
- [x] M3.3 Pause/None/fade：transcriber `with Pause(N)` 直接发射 `StopEngineTime(N)`；`with None` 转为注释 no-op；`with fade` 在 TransitionBy 走 `TransitionWithFadeIn` 而非 dissolve
- [x] M3.4 Epilepsy：`TransitionManager.PlayEpilepsy` 用 overlay Image 快速切换 white/red/yellow/orange/black 调色板（默认 6 次闪烁 / 0.5s）
- [x] M3.5 TransitionManager 统一派发：新增 `TryPlayNamed(name, out routine)` 字符串派发入口，为未来 MultipleTransitionSequencer 组合预留；`GameMethods.TransitionBy` 优先走该入口
- [x] M3.6 5 个自定义 Shader：
  - `Shaders/GaussianBlur.shader`（9-tap 近似 σ≈1.5）
  - `Shaders/MatrixColor.shader`（Invert + Hue 旋转 + Saturation + Contrast + Brightness）
  - `Shaders/AdditiveBlend.shader`（SrcAlpha One，发光/粒子）
  - `Shaders/MultiplyBlend.shader`（DstColor OneMinusSrcAlpha，立绘腮红）
  - `Shaders/Glitch.shader`（条带抖动 + 色彩像差 + 扫描线）
- WarperLibrary（Renpy 缓动函数库如 eyewarp/bounce/repeat）与 MultipleTransitionSequencer（多阶段转场组合）留待 M3 二轮打磨期间视需求补

### M4 — UI 系统移植 ✅（首版完成，M6 打磨对齐美术）
- [x] M4.1 SaveSystem 后端：`GameStateSnapshot`（反射序列化 Defaults/Persistent/Preferences/Engine 全量静态字段）+ `SaveSystem`（JSON + `Application.persistentDataPath/saves/` + 18 槽位 + quick/auto 特殊槽）
- [x] M4.2 Main Menu + Navigation（开始/读档/设置/附加/回想/退出）
- [x] M4.3 Quick Menu overlay（回退/跳过/自动/保存/Q存/Q读/历史/隐藏/设置/菜单）
- [x] M4.4 Game Menu + Save / Load 画面（3×2 网格 × 10 页分页）
- [x] M4.5 Settings（music/sound/voice 音量 + 文字速度 + 自动播放间隔 + 全屏切换，PlayerPrefs 持久化）
- [x] M4.6 Dialog/Choice 变体注册表（`UIVariantRegistry`：say/say1/say2 与 choice/choice1~5 的样式参数集中声明）
- [x] M4.7 Extras 入口 + Sucai 素材页 + History 历史面板 + Recollection 回想总入口
- [x] M4.8 Music Gallery（9 首代表曲目 + 停止按钮 + AudioManager 真播放）
- [x] M4.9 Story Gallery（11 个章节条目 + 基于 `Defaults.Persistent.Jq_*` 的解锁门禁）
- [x] M4.10 CG Gallery（9 张代表 CG，网格布局，点击异步 Addressables 加载 Texture2D 预览日志）
- [x] M4.11 Character Archive（5 角色档案 + 反射读取 Haogandu_* 好感度）
- [x] M4.12 Fanwai 番外列表（基于 Gallery_fanwai*_lock 解锁）
- [x] `UIScreenBase` / `UIScreenManager`：纯代码构建 Canvas，栈式导航，GetOrCreate 延迟实例化
- 首版均为纯代码 UGUI，字体暂用 `LegacyRuntime.ttf`；美术资源接入（textbox 背景、主菜单立绘、gui/ 按钮样式）归入 M6 打磨

### M5 — 成就与画廊系统 ✅（首版完成）
- [x] M5.1 AchievementManager 后端：JSON + `{persistentDataPath}/achievements.json` 持久化；11 条成就注册表（NEW_ACHIEVEMENT_1_0 ~ 1_10）+ displayName / description / hidden 标记
- [x] M5.1 Grant / Sync / IsUnlocked / ResetAll API；OnGranted event 供 UI 订阅
- [x] M5.2 CG Gallery 真实预览 overlay：异步 Addressables 加载 Texture2D，按宽高比自适应到 1600×900 可视区域，点击任意处返回；Hide 时自动释放 AsyncOperationHandle
- [x] M5.3 EndingCreditsScreen：匀速从底部滚动的结局字幕（默认 40s 总时长），滚完自动回主菜单；右下角"跳过"按钮；支持 `CustomCredits` 覆写
- [x] M5.4 `GameMethods.GrantAchievement` 现对接 `AchievementManager.Grant` 并触发 `AchievementToastScreen.ShowToast` 滑入/滑出卡片
- [x] M5 附加：AchievementToastScreen（右上角 Toast）+ AchievementListScreen（Extras 新增第 6 格"成就"入口，卡片网格展示全部 11 条，hidden 成就锁定前显示 ???）

### M6 — 全流程通测与保真度比对
- 原版 vs 移植版逐场景对比
- Bug 修复与调优

---

## 7. 性能基准

| 指标 | PC 目标 | 底线 |
|---|---|---|
| 普通对话帧率 | 60 FPS | 30 FPS |
| 总内存 | < 1.5 GB | < 2 GB |
| 纹理内存 | < 512 MB | < 768 MB |
| 游戏启动时间 | < 3 秒 | < 6 秒 |
| 场景切换时间 | < 0.5 秒 | < 1 秒 |

### 已知性能风险
1. `WaitForCompletion()` 同步阻塞纹理加载 — 需改为异步
2. 启动时预加载全部纹理 — 需改为按需加载 + LRU 缓存
3. 大量 Debug.Log — 需条件编译或移除

---

## 8. 叙事关键注意事项

1. **文件名与 label 交叉**：`end6.rpy` 内含 `label end7`，`end7.rpy` 内含 `label end6`
2. **二周目解锁**：`persistent.he_ending = 1`（end3 通关设定）解锁决战第三选项
3. **81 个 persistent.jq_* 标志位**：用于剧情追踪和收集系统
4. **8+ 个音频通道同时使用**：sound/sounda/sounda1-6/soundb-f/music/music1-5
5. **关键分流变量**：`bai_xue`（冰龙/黑龙线）、`bai_xin`（决战选项解锁）、`bai_kiss`（心跳检测）
