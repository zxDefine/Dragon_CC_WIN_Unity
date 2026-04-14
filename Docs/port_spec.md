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

### 4.1 已转换（9个 rpy → 18个 cs）

| rpy 文件 | 行数 | cs 文件 | 状态 |
|---|---|---|---|
| zhuxian0.rpy | 1,970 | zhuxian0.cs + zhuxian0_menu.cs | 已转换 |
| zhuxian_1.rpy | 5,481 | zhuxian_1.cs + zhuxian_1_menu.cs | 已转换 |
| zhuxian_2.rpy | 3,604 | zhuxian_2.cs + zhuxian_2_menu.cs | 已转换 |
| zhuxian_3.rpy | 3,101 | zhuxian_3.cs + zhuxian_3_menu.cs | 已转换 |
| zhuxian4.rpy | 4,142 | zhuxian4.cs + zhuxian4_menu.cs | 已转换 |
| wangzi.rpy | 1,956 | wangzi.cs + wangzi_menu.cs | 已转换 |
| end3.rpy | 187 | end3.cs + end3_menu.cs | 已转换 |
| end5.rpy | 1,000 | end5.cs + end5_menu.cs | 已转换 |
| end6.rpy (label:end7) | 2,931 | end6.cs + end6_menu.cs | 已转换 |

### 4.2 待转换（9个，排除被注释结局）

| rpy 文件 | 行数 | 优先级 | 说明 |
|---|---|---|---|
| zhuxian5.rpy | 3,749 | P0 | 第三年主线（冰龙/黑龙分流） |
| zhuxian6.rpy | 3,200 | P0 | 第四年主线（决战准备） |
| juezhan.rpy | 1,135 | P0 | 决战核心（所有结局分流枢纽） |
| tuanzhan_you.rpy | 1,558 | P0 | 团战路线过渡 |
| fanhuitu.rpy | 365 | P0 | 返回途中（女王/冒险分流） |
| bai.rpy | 3,033 | P1 | 第三年冰龙子线 |
| bai1.rpy | 1,094 | P1 | 第四年冰龙子线 |
| end7.rpy (label:end6) | 2,625 | P1 | 驯养结局（二周目解锁） |
| juezhanhou_bai.rpy | 519 | P1 | 决战后冰龙出现 |

### 4.3 不移植

| rpy 文件 | 行数 | 原因 |
|---|---|---|
| end1.rpy | 1,165 | 99%+ 被注释，用户确认不移植 |
| end2.rpy | 983 | 99%+ 被注释，用户确认不移植 |
| end4.rpy | 937 | 99%+ 被注释，用户确认不移植 |

---

## 5. P0 阻塞性 Bug 清单

| 编号 | 问题 | 文件 | 行号 | 修复方案 |
|---|---|---|---|---|
| BUG-01 | `GameMethods.Show` 缺少 parallel_0/1 参数 | GameMethods.cs | ~34 | 扩展签名或使用 Dictionary 传递 |
| BUG-02 | `File.ReadAllText` 硬编码路径 | DialogManager/CharacterManager/ImageManager | 20/37/53 | 改用 Addressables 加载 |
| BUG-03 | `SceneBlack` alpha=0（应=1） | ImageManager.cs | 239 | 修改为 `new Color(0,0,0,1f)` |
| BUG-04 | `PlayVoice`/`SaveLastVoiceToTheEnd` 返回 IEnumerable | GameMethods.cs | 151/157 | 改为 IEnumerator |
| BUG-05 | `RenpyFade`/`Matrixcolor` 字段全 private 无 getter | RenpyFade.cs/Matrixcolor.cs | 全文件 | 添加 public getter |
| BUG-06 | 对话跳过时缺少前后缀符号 | UIDialogue.cs | 99-101 | fullText 中包含 prefix/suffix |
| BUG-07 | `AudioManager.Play` 同通道不替换旧音频 | AudioManager.cs | 47-57 | 先停止旧音频再播放新的 |
| BUG-08 | 循环判定仅匹配 `"music"` | AudioManager.cs | 70 | 建立 Channel 配置表 |
| BUG-09 | GameScript 中路径含反斜杠 | GameScript/*.cs | 多处 | 批量替换 `\` → `/` |
| BUG-10 | `GameState.cs` An_2 字符串截断 | GameState.cs | 222 | 修复截断的字符串 |
| BUG-11 | `UISelectionMenu.OnSelect` null 检查后未 yield break | UISelectionMenu.cs | 122-135 | 添加 yield break |

---

## 6. 里程碑计划

### M0 — 规格文档补全（当前）
- [x] port_spec.md（本文件）
- [ ] renpy_analysis.md
- [ ] architecture.md
- [ ] asset_spec.md

### M1 — P0 Bug 修复 + GameMethods 空实现补全
- 目标：让 zhuxian0 一章可完整运行
- 详细 todo 见 M1 实施时拆分

### M2 — 剩余 9 个剧情脚本转换
- 转换 P0 关键路径：zhuxian5/6, juezhan, tuanzhan_you, fanhuitu
- 转换 P1 分支：bai, bai1, end7, juezhanhou_bai

### M3 — 转场与视觉特效系统
- 5 个自定义 Shader
- TransitionManager + WarperLibrary
- ShakeEffect + MultipleTransitionSequencer

### M4 — UI 系统移植
- 25+ 个屏幕的 UGUI 实现
- 存档/读档功能

### M5 — 成就与画廊系统
- 成就系统、CG 画廊、回想模式、结局字幕

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
