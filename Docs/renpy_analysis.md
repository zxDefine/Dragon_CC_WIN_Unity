# Renpy 原版逆向分析文档

> 主导：叙事设计师  
> 协作：着色器艺术家、音频工程师、技术美术、界面设计师  
> 创建日期：2026-04-07  
> 最后更新：2026-04-07

---

## 1. 项目概况

- **游戏名称**：灾厄黑龙与谎言公主
- **引擎**：Ren'Py
- **基准分辨率**：1280×720
- **原版路径**：`/dragon_yuanban/game/`
- **总脚本行数**：约 44,735 行（21 个故事脚本）
- **类型**：西方奇幻恋爱视觉小说，含多结局分支

---

## 2. 文件结构

```
/dragon_yuanban/game/
├── rpy/
│   ├── zhuxian/               # 主线剧情脚本（21个）
│   │   ├── zhuxian0.rpy       # 序章（1,970行）
│   │   ├── zhuxian_1.rpy      # 第1章（5,481行）
│   │   ├── zhuxian_2.rpy      # 第2章（3,604行）
│   │   ├── zhuxian_3.rpy      # 第3章（3,101行）
│   │   ├── zhuxian4.rpy       # 第4章（4,142行）
│   │   ├── wangzi.rpy         # 王子线（1,956行）
│   │   ├── end/               # 结局目录
│   │   │   ├── end1.rpy       # Bad End-灰烬（被注释，不移植）
│   │   │   ├── end2.rpy       # Bad End-刀锋（被注释，不移植）
│   │   │   ├── end3.rpy       # True End（187行）
│   │   │   ├── end4.rpy       # Good End-告白（被注释，不移植）
│   │   │   ├── end5.rpy       # Good End-五彩纷呈（1,000行）
│   │   │   ├── end6.rpy       # 含 label end7 女王在上（2,931行）
│   │   │   ├── end7.rpy       # 含 label end6 驯养（2,625行）
│   │   │   └── juezhan.rpy    # 决战（1,135行）
│   │   ├── guodu/             # 过渡剧情
│   │   │   ├── fanhuitu.rpy   # 返回途中（365行）
│   │   │   ├── tuanzhan_you.rpy # 团战优（1,558行）
│   │   │   └── juezhanhou_bai.rpy # 决战后冰龙（519行）
│   │   ├── the third year_d/  # 第三年
│   │   │   ├── zhuxian5.rpy   # 主线第5章（3,749行）
│   │   │   └── bai/bai.rpy    # 冰龙子线（3,033行）
│   │   └── the fourth year/   # 第四年
│   │       ├── zhuxian6.rpy   # 主线第6章（3,200行）
│   │       └── bai/bai1.rpy   # 冰龙子线（1,094行）
│   ├── effects.rpy            # 特效/转场定义（112行）
│   ├── cartoon.rpy            # 帧动画定义（139行）
│   ├── layered_image/         # 分层立绘定义
│   │   ├── image_define.rpy             # 图片/动画定义（749行）
│   │   ├── image_define_gui.rpy         # GUI 图片定义（82行）
│   │   ├── layered_images_define_lihui.rpy  # 角色立绘（2,843行）
│   │   ├── layered_image_define_cg_he.rpy   # 赫泽尔CG（851行）
│   │   ├── layered_image_define_cg_nuo.rpy  # 诺伯拉CG（292行）
│   │   └── layered_image_define_cg_an.rpy   # 安CG（59行）
│   └── demo_rpy/              # 系统定义
│       ├── script.rpy         # 主入口/全局变量（730行）
│       ├── screens.rpy        # UI 界面定义（7,456行）
│       ├── gui.rpy            # GUI 配置（415行）
│       ├── options.rpy        # 全局选项（263行）
│       ├── demo_transition.rpy # 转场效果（204行）
│       ├── kinetic_text_tags.rpy # 动态文字标签（841行）
│       ├── end_zimu.rpy       # 结尾字幕（533行）
│       ├── huixiang.rpy       # 回想系统（247行）
│       ├── souji.rpy          # 收集系统（177行）
│       └── test_achievements.rpy # 成就测试（55行）
├── camera/                    # 相机系统
│   ├── 00warper.rpy           # 自定义缓动函数（28+种曲线）
│   ├── ATL_functions.rpy      # ATL 动画函数（sin/cos/wiggle）
│   ├── ActionEditor.rpy       # 动作编辑器
│   └── ...
├── images/                    # 图片资源（1,830文件）
├── audio/                     # 音频资源（3,066文件）
├── gui/                       # GUI 资源（512文件）
└── tl/                        # 翻译文件
```

---

## 3. 故事结构

### 3.1 主线流程图

```
序章(zhuxian0) → 第1章(zhuxian_1) → 第2章(zhuxian_2) → 第3章(zhuxian_3)
    → 第4章(zhuxian4)
        ├─ bai_xue=1 → 冰龙线(zhuxian5_bai) ─┐
        └─ bai_xue=0 → 黑龙线(zhuxian5_he) ──┤
                                               ├→ 共通段(dulishi_gongtong)
                                               └→ 第四年(zhuxian6) → 决战(juezhan)
                                                    ├─ "就是现在" → juezhan_1
                                                    │    ├→ end3 (True End)
                                                    │    └→ tuanzhan_you → fanhuitu
                                                    │         ├→ end7 (女王在上)
                                                    │         ├→ end5 (四人冒险)
                                                    │         └→ end4 (不移植)
                                                    ├─ "再等等" → juezhan_2
                                                    │    ├→ tuanzhan_you (bai_xin=1)
                                                    │    └→ end1 (不移植)
                                                    └─ "说服黑龙"(二周目) → end6 (驯养)
```

### 3.2 七大结局

| 结局 | 名称 | persistent 标志 | 移植状态 | 触发条件 |
|---|---|---|---|---|
| end1 | Bad End - 灰烬 | jq_11_1 | **不移植**（被注释） | — |
| end2 | Bad End - 刀锋与牢笼 | jq_11_6 | **不移植**（被注释） | — |
| end3 | True End - 传说中你为爱甘愿被搁浅 | jq_11_5 | 移植 | juezhan_1 特定条件 |
| end4 | Good End - 漫长告白 | jq_11_3 | **不移植**（被注释） | — |
| end5 | Good End - 世界因你五彩纷呈 | jq_11_2 | 移植 | fanhuitu 选冒险→四人版 |
| end6(label) | Happy End - 驯养 | jq_11_7 | 移植 | 二周目"说服黑龙" |
| end7(label) | Good End - 女王在上 | jq_11_4 | 移植 | fanhuitu 选登顶为王 |

> **注意**：文件名与 label 名交叉 — `end6.rpy` 含 `label end7`，`end7.rpy` 含 `label end6`

### 3.3 关键变量系统

| 变量名 | 默认值 | 说明 | 关键判断点 |
|---|---|---|---|
| `haogandu_he` | 0 | 赫泽尔好感度 | 成就触发（>100） |
| `haogandu_nuo` | 0 | 诺伯拉好感度 | 成就触发（>100） |
| `haogandu_an` | 100 | 安德鲁好感度 | 较少判断 |
| `bai_xue` | 0 | 冰龙线标记 | zhuxian4 末→分流 |
| `bai_xin` | 1 | 给冰龙开门 | 决战菜单解锁 |
| `bai_kiss` | 0 | 既成事实事件 | juezhan 内部分支 |
| `wangzixian` | 0 | 王子线 | end5 中王位交接 |
| `he_xianzai` | 0 | "动手"路线 | 多处判断 |
| `persistent.he_ending` | 0 | True End 通关 | **二周目解锁第三选项** |
| `persistent.povname` | "辛西娅" | 玩家名字 | 大量对话插值 |

81 个 `persistent.jq_*` 标志位用于剧情追踪/收集系统。

---

## 4. 音频系统分析

### 4.1 Channel 注册表

原版在 `script.rpy` 中注册了 20+ 个音频通道：

| Channel 类型 | 名称 | Mixer | 默认循环 |
|---|---|---|---|
| 主音效 | `sound` | sfx | 否 |
| 附加音效 | `sounda` ~ `sounda6` (7个) | sfx | 否 |
| 循环音效 | `soundb` ~ `soundf` (5个) | sfx | **是** |
| 主音乐 | `music` | music | 是 |
| 附加音乐 | `music1` ~ `music4` (4个) | music | 是 |
| 特殊音乐 | `music5` | music | 否 |
| 语音 | `voice` | voice | 否 |

### 4.2 音频命令统计

全部 rpy 文件共约 **1,692 条** play/stop/fadeout 命令。常见模式：

- **多层音效叠加**：同时使用 5-8 个通道构建音景
- **音频序列**：`["<silence N>", "<from X to Y>file"]` 精确定时
- **音频片段截取**：`<from X to Y>` 播放指定时间段
- **淡入淡出**：`fadein N` / `fadeout N`

### 4.3 音频资源统计

| 类别 | 数量 | 大小 |
|---|---|---|
| 音乐（music/） | 79 | 223 MB |
| 音效（sound/） | 298 | 123 MB |
| 语音（voice/） | 2,688 | 344 MB |
| 视频音频（video/） | 1 | — |
| **总计** | **3,066** | **约 652 MB** |

---

## 5. 转场特效系统

### 5.1 基础转场

| 转场 | 参数 | 使用频率 |
|---|---|---|
| `dissolve` / `Dissolve(t)` | t = 0.4~1.5秒 | 极高（数百次） |
| `Fade(out, hold, in, color)` | 秒数+颜色 | 中等 |
| `hpunch` | 无参数 | 低 |

### 5.2 ImageDissolve（图案溶解）

| 名称 | 遮罩图 | 参数 |
|---|---|---|
| `trans_rip_fast` | waves.jpg | 0.8秒, ramplen=32 |
| `trans_rip_fast1` | waves.jpg | 0.6秒, ramplen=32 |
| `eye_open_with_time(t, ram)` | eye.png | 自定义缓动 x^1.33 |
| `eye_shut_with_time(t, ram)` | eye.png | reverse=True |

### 5.3 MultipleTransition（blink 系列）

| 名称 | 效果 |
|---|---|
| `blink1` / `blink1_1` | 复杂记忆闪回眨眼序列（含中间 blur+ease 动画） |
| `blink2` | 快速眨眼：闭眼0.4s→黑→睁眼0.8s |
| `blink2_1` | 慢速眨眼：闭眼1.3s→黑→睁眼0.8s |
| `blink3` / `blink3_1` | 慢/快速睁眼 |
| `blink4` | 捏捏CG专用眨眼 |
| `blink4_1` | 仅闭眼0.8s |

### 5.4 其他特效

| 特效 | 实现方式 |
|---|---|
| `Shake((0,0,0,0), time, dist)` | 屏幕震动 |
| `glitch` / `animated_glitch` | 故障效果（水平条带偏移+色差） |
| `squares_glitch` | 方块故障（方格UV置换） |

---

## 6. Camera/ATL 系统

### 6.1 自定义缓动函数（00warper.rpy）

28+ 种曲线函数：

| 函数组 | 说明 |
|---|---|
| `power_in2`~`power_in6` / `power_out2`~`power_out6` | n次幂 ease-in/out |
| `spring1/2/3` | 弹簧阻尼曲线 |
| `bop_time_warp` / `bop_in/out/to` | 弹跳效果 |
| `easeout2/easein2/ease2` | cos 缓动变体 |
| `loop_cos` | 循环余弦波 |

### 6.2 ATL 动画函数（ATL_functions.rpy）

| 函数 | 功能 |
|---|---|
| `mfn(*funcs)` | 多函数并行组合器 |
| `atl_sin(property, peak, hz, ...)` | 正弦波属性动画 |
| `atl_cos(property, peak, hz, ...)` | 余弦波属性动画 |
| `atl_wiggle(property, max, deviation, ...)` | 随机振动（高斯分布+样条） |

### 6.3 ATL 属性使用频率

| 属性 | 频率 | 值域 |
|---|---|---|
| `pos` / `xpos` / `ypos` | 极高 | 绝对值和比例值 |
| `zoom` | 高 | 0.33~2.39 |
| `blur` | 高 | 0~40 |
| `alpha` | 高 | 0~1 |
| `xoffset` / `yoffset` | 高 | 震动效果 |
| `zpos` | 中等 | -432~260 |
| `matrixcolor` | 中等 | 5参数矩阵 |
| `additive` | 中等 | 叠加混合 |
| `subpixel` | 中等 | 亚像素渲染开关 |
| `rotate` | 低 | 旋转角度 |

---

## 7. Matrixcolor 系统

Renpy 使用 5×5 色彩矩阵组合：`InvertMatrix(I) * ContrastMatrix(C) * SaturationMatrix(S) * BrightnessMatrix(B) * HueMatrix(H)`

| 矩阵 | 参数含义 | 项目内使用范围 |
|---|---|---|
| InvertMatrix | 颜色反转 | 始终 0.0（未使用） |
| ContrastMatrix | 对比度 | 0.86 ~ 1.58 |
| SaturationMatrix | 饱和度 | 0.55 ~ 1.39 |
| BrightnessMatrix | 亮度偏移 | -0.45 ~ 0.11 |
| HueMatrix | 色相旋转 | 0.0 ~ 330.0° |

常见模式：暗化回忆（低对比+低饱和+负亮度）、高对比强调、闪烁动画。

---

## 8. UI 屏幕系统（screens.rpy — 7,456行）

### 8.1 完整屏幕清单

| 屏幕 | 功能 | 复杂度 |
|---|---|---|
| `say` / `say1` / `say2` | 对话框（3种变体） | 高 |
| `choice` ~ `choice5` | 选项菜单（6种变体） | 高 |
| `quick_menu` | 快捷菜单（10个图标按钮） | 高 |
| `main_menu` | 标题菜单（含动画/粒子/登录） | 高 |
| `save` / `load` | 存档/读档（2×3网格/缩略图） | 高 |
| `sz` | 设置界面 | 高 |
| `lishi` | 对话历史回看 | 中 |
| `heart` | 好感度显示 | 中 |
| `confirm` / `confirm_bai` | 确认弹窗 | 中 |
| `extra` | EXTRA 菜单（番外/回想/杂谈） | 高 |
| `music_huixiang` | 音乐回想 | 高 |
| `huixiang_juqing` | 剧情回想 | 中 |
| `huixiang_cg` | CG 回想 | 中 |
| `juesedangan` | 角色档案 | 中 |
| `zatan` | 制作杂谈 | 中 |
| `fanwai` | 番外界面 | 中 |
| `sucai` | 素材来源 | 低 |
| `name_input` | 姓名输入 | 中 |
| `skip_indicator` | 快进指示器 | 低 |
| `notify` | 通知消息 | 低 |
| `navigation` | 导航菜单 | 中 |
| `game_menu` | 游戏菜单框架 | 中 |

### 8.2 UI 视觉规格

| 项目 | 值 |
|---|---|
| 字体 | GenSenRounded-M.ttc（源泉圆体） |
| 对话文字大小 | 25px |
| 角色名大小 | 30px |
| 文字描边 | 2.5px 黑色 |
| 强调色 | #cc0000 |
| 文本颜色 | #ffffff |
| 悬停色 | #e06666 |
| 对话框高度 | 230px，底部对齐 |
| 选项按钮宽 | 790px |
| 选项文字色 | idle: #888888 → hover: #fcc9c7 |

---

## 9. Layered Image 系统（角色立绘）

### 9.1 定义清单（20 个 layeredimage）

| 名称 | 角色 | 图层组 |
|---|---|---|
| `he` | 赫泽尔（日常） | ditu + yan(24种) + mei(13种) + zui(15种) + emoji(17种) + ying |
| `heo` | 赫泽尔（龙形） | 底图 + yan + mei + zui + emoji + 顶层 |
| `nuo1` | 诺伯拉 | 分层立绘 |
| `an1` / `an2` | 安德鲁 | 两种形态 |
| `luo1` / `luo2` | 洛恩 | 两种形态 |
| `he_ce` | 赫泽尔（侧面） | 分层立绘 |
| `gongzhu_layered` | 公主 | 分层立绘 |
| `wangzi` | 王子 | 分层立绘 |
| `xiya` | 希亚 | 分层立绘 |
| `someone1`~`4` | 神秘人 | 4种形态 |
| `npc_qishi1_layered` | NPC 骑士 | 静态单图 |
| `an_k` / `luo_k` | 暗/洛（框架版） | 分层立绘 |
| `nuo_heart_layered` | 诺（心跳状态） | 分层立绘 |

### 9.2 组合机制

- **互斥组（group）**：yan/mei/zui 同组内同时仅显示一个
- **独立叠加**：emoji 各自独立 group，可多个叠加
- **blend "multiply"**：部分 emoji 使用乘法混合模式（腮红效果）
- **绘制顺序**：底图 → 眼 → 眉 → 嘴 → emoji → 顶层

---

## 10. 动态图像定义（image_define.rpy）

| 效果类型 | 示例 | 移植方案 |
|---|---|---|
| 帧动画 | `feather_ani`（80帧序列帧） | SpriteAnimation |
| 透明度循环 | `erhuan_guang1_ani`（刀光） | DOTween alpha 动画 |
| 位移抖动 | `memory4_1_ani` | DOTween xoffset/yoffset |
| 粒子效果 | `snow_white`（雪花） | Unity ParticleSystem |
| 复合场景 | `fly_cg_ani`（飞天云层） | 多层 Canvas + 独立动画 |
| 滚动平移 | `tiankong_bangwan_yundong`（天空云动） | UV 滚动 Shader |
| 闪电 | `lightning_1`~`4` | alpha 闪烁序列 |
| 视频 | `water_video` | Unity VideoPlayer |

---

## 11. 特殊文本标签（kinetic_text_tags.rpy — 841行）

原版定义了动态文字效果标签，用于对话文本的视觉增强：
- 文字抖动
- 文字渐变
- 其他动态效果

需在 Unity TextMeshPro 中实现等效效果。

---

## 12. 其他系统

### 12.1 收集系统（souji.rpy）
81 个 `persistent.jq_*` 标志位，11 个章节组，记录玩家经历的剧情节点。

### 12.2 回想系统（huixiang.rpy）
已解锁剧情可重新观看。

### 12.3 成就系统
通过 `achievement.grant()` / `achievement.sync()` 对接（原版为 Steam 成就）。

### 12.4 自动语音（auto_voice）
`config.auto_voice = "audio/voice/{id}.ogg"` — 基于对话节点 ID 自动匹配语音文件。

### 12.5 结尾字幕（end_zimu.rpy — 533行）
制作人员名单滚动。
