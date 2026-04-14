# rpy → cs 转译差异与规范报告

> 生成日期：2026-04-14
> 目的：盘点原版 `dragon_yuanban/game/rpy/zhuxian/` 下所有 rpy 的转译状态，校验已有 cs 文件的遗漏/错误，并列出转译规范与未知语法以供用户确认后开始批量转译。

---

## 1. 盘点总览

| 项目 | 数值 |
|---|---|
| 原版 rpy 文件总数 | 21 |
| 原版 rpy 总行数 | 44,736 |
| 原版**有效** label 总数 | 120（不含 commented-out） |
| 现有 cs 实现的 label 数 | 100 |
| **完全未转译的 rpy** | **9 个文件 / ~17,440 行** |
| 用户决策跳过的 rpy | 3 个（end1/end2/end4，已废弃注释掉） |
| 已转译但**漏了 label** | 1 个（zhuxian_2.cs 缺 `choice12`） |
| 已转译但存在**逻辑错误** | 至少 1 处（end3.cs 的 7 条件 `and` 被简化为单条件） |

---

## 2. 用户决策：跳过的文件（不转译）

依据 `memory/project_decisions.md`：

| 文件 | 状态 | 原因 |
|---|---|---|
| end/end1.rpy | 全部 label 注释 | Bad End-Ash，已废弃 |
| end/end2.rpy | 全部 label 注释 | Bad End-Blade & Cage，已废弃 |
| end/end4.rpy | 全部 label 注释 | Good End-Long Confession，已废弃 |

**动作**：不创建对应的 cs 文件。

---

## 3. 已转译文件的问题清单

### 3.1 遗漏 label（1 处）

| 文件 | 缺失 label | rpy 位置 | 严重度 |
|---|---|---|---|
| zhuxian_2.cs | `label_choice12` | zhuxian_2.rpy:L1889 | 高（分支断链） |

**动作**：补齐 `public IEnumerator label_choice12()` 方法。

### 3.2 逻辑错误（至少 1 处，需进一步审计）

#### 错误 A — `and` 条件链被简化

**位置**：end3.cs:L180

```csharp
// cs 当前（错）
if (Defaults.Persistent.Jq_11_7==1)
{
    _gameMethods.GrantAchievement("NEW_ACHIEVEMENT_1_7");
    ...
}
```

```python
# rpy 原版（end3.rpy:L181）
if persistent.jq_11_1 == 1 and persistent.jq_11_2 == 1 and persistent.jq_11_3 == 1 and persistent.jq_11_4 == 1 and persistent.jq_11_5 == 1 and persistent.jq_11_6 == 1 and persistent.jq_11_7 == 1:
```

**影响**：只解锁 jq_11_7 即可拿成就，漏掉 jq_11_1..jq_11_6 的检查。

**可能存在的同类错误**：转译器对所有 `and` 链条都可能有此 bug。需要**全面扫描**所有现有 cs 的 `if` 语句，对照 rpy 原版。

### 3.3 需要后续审计项

- 68 条 `if` 语句（其中 `||` 25 条、`&&` 1 条、单条件 42 条）需要全部与 rpy 原版逐条对照
- 转译器 bug：之前已修过 322 条（详见 `Docs/converter_bugs_audit.txt`），但 `and` 链简化 bug 是新发现

---

## 4. 完全未转译的 9 个文件（~17,440 行）

| # | rpy 文件 | 行数 | 顶层有效 label |
|---|---|---|---|
| 1 | end/end7.rpy | 2625 | end6, end6_2, end6_1（注意：文件名 end7 但 label 叫 end6） |
| 2 | end/juezhan.rpy | 1135 | juezhan, juezhan_1, juezhan_2 |
| 3 | guodu/fanhuitu.rpy | 365 | fanhuitu, end3_1_1_tuan2, end3_1_2_tuan2 |
| 4 | guodu/juezhanhou_bai.rpy | 519 | juezhan_bai2（juezhan_bai1 注释） |
| 5 | guodu/tuanzhan_you.rpy | 1558 | tuanzhan_you, end3_1_tuan3, end3_1_tuan1 |
| 6 | the fourth year/bai/bai1.rpy | 1094 | bai_mosuomofa, bai_manbu, zhuxian6_5, zhuxian6_9 |
| 7 | the fourth year/zhuxian6.rpy | 3200 | zhuxian6, zhuxian6_1..8（除 5/9）, multiple_choice3 |
| 8 | the third year_d/bai/bai.rpy | 3033 | bai_xinlingtongxun 等 8 个 |
| 9 | the third year_d/zhuxian5.rpy | 3749 | zhuxian5_bai, zhuxian5_he 等 8 个 |

---

## 5. 转译格式规范（仿现有 cs）

### 5.1 文件头骨架

```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class <filename> : ILabelProvider
{
    private GameMethods _gameMethods;

    public <filename>(GameMethods gameMethods)
    {
        _gameMethods = gameMethods;
    }

    public IEnumerator label_<name>()
    {
        ...
        yield break; // 或省略
    }
}
```

### 5.2 核心映射表

| rpy 语法 | cs 调用 |
|---|---|
| `"text"` | `OpenDialog(N); // "text"` — N 从 dialogues.txt 分配 |
| `character "text"` | `ExecuteCharacterImageData("character"); OpenDialog(N);` |
| `character attr1 attr2 "text"` | `ExecuteCharacterImageData("character", parts: [...]); OpenDialog(N);` |
| `extend "text"` | `OpenDialog(N); // "text"` |
| `scene <img>:` + 属性 | `Scene("<img>", sameLine: new List<SameLineParamData>{...})` |
| `scene black` | `SceneBlack()` |
| `show black` | `ShowBlack()` |
| `show white` | `ShowWhite()` |
| `hide black` | `HideBlack()` |
| `show <name> parts:` + 属性 | `Show("<name>", parts: [...], sameLine: [...])` |
| `show <name> onlayer forward:` | `Show("<name>", sameLine: [{onLayer=forward, ...}])` |
| `hide <name>` | `Hide("<name>")` |
| `camera: ...` | `SetCamera(sameLine: [...], parallel_0: [...], parallel_1: [...])` |
| `parallel:` 子块 | `parallel_0/1/2/3` 命名参数 |
| `with Dissolve(t)` | `Transition(time:t)` |
| `with Fade(...)` | `Transition(time:<求和>)` （Fade 参数被简化） |
| `with blink4` / `with trans_rip_fast` | `TransitionBy("blink4")` |
| `play <channel> "<path>" [fadein F] [volume V]` | `PlaySound("<channel>", F, V, "<path>")` |
| `stop <channel> [fadeout F]` | `StopSound(channelName:"<channel>", fadeOut:Ff)` |
| `voice "<path>"` | `PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/<basename>.ogg")` |
| `$ renpy.music.set_volume(v, delay=d, channel='c')` | `EngineSetVolume(volume:vf, delay:df, channelName:"c")` |
| `$ _history = False/True` | `Engine._history = false/true;` |
| `$ persistent.xxx = N` | `Defaults.Persistent.Xxx = N;`（PascalCase） |
| `$ <var> = N` | `Defaults.Xxx = N;` |
| `$ <var> += N` | `Defaults.Xxx += N;` |
| `if cond1 and cond2:` | `if (cond1 && cond2)` ⚠️ 需要确保**所有**条件都保留 |
| `if cond1 or cond2:` | `if (cond1 \|\| cond2)` |
| `jump <label>` | `yield return _gameMethods.JumpToLabel("<label>");` 或直接 `yield return <MethodRef>()` |
| `call <label> from ...` | `yield return <label>();` 后继续 |
| `return` | 方法自然结束 |
| `menu(screen="X"):` | `OpenSelectMenu(screen:"X", talk: [...], jump: [...], condition: [...])` |
| `menu:`（无 screen） | **未知**——现有 cs 未见此用法，需规范 |
| `# 注释 menu 选项` | 跳过，不生成 |
| `python: <calls>` | 按调用映射，如 `achievement.grant(X)` → `_gameMethods.GrantAchievement("X");` |

### 5.3 label_xxx_menu_0_<random> 辅助 label

每个 menu 跳转会生成一个桥接 label（名字随机），承接"用户选某项后要执行的代码块"。现有 cs 用 `label_<file>_menu_0_<RANDOM>` 命名，对应在 `<file>_menu.cs` 文件中实现。**此命名不可避免，保留现状。**

### 5.4 缩进

- class 外层 4 空格
- 方法体 8 空格
- 与现有文件一致

---

## 6. 未知 / 需要您决策的语法（共 5 项）

### 6.1 ❓ `menu:`（无 screen 参数）— 5 处

**位置**：zhuxian_1/2/3 等现有文件中出现了 5 处 `menu:`（无 screen）。现有 cs 如何处理的？还没验证。未转译文件中可能也有。

**建议方案**：
- **方案 A（保守）**：生成自动 screen 名如 `"auto_<line>"`
- **方案 B（现状）**：查看现有 cs 如何对应（可能是直接内联条件分支）

**请您决定**：A 还是 B？或者把这种情况列个单独清单先挂起？

### 6.2 ❓ `if <var> > 100 or <var2> > 100:`

**位置**：end7.rpy 171 处。`haogandu_he > 100 or haogandu_nuo > 100`

**现有 cs 已有样本**：`if (Defaults.Haogandu_he > 100 || Defaults.Haogandu_nuo > 100)` ✓ 直接用。

**建议**：无需决策，按现有样式转。

### 6.3 ❓ `call <label> from _call_<label>`

**位置**：juezhan.rpy:L548,L552。rpy 原生语法：call + 自动命名的返回标签。

**建议方案**：
- Renpy 的 `call` 是"调用后返回"；`from X` 只是给返回点命名，无实际语义差别
- **方案 A**：直接翻译为 `yield return <LabelMethod>();`
- **方案 B**：如框架没有对等机制，改用 `JumpToLabel`（无返回语义）

**请您决定**：框架的 `GameMethods` 是否已经支持"调用并返回"？如果没有，我可以按 `yield return LabelRegistry.Instance.RunCoroutineByMethodOnly("<name>")` 调用同步等待。

### 6.4 ❓ `python:` 多行块

**位置**：未转译文件中 124 处。通常内容是 `achievement.grant(...)` 两行。

**建议**：沿用现有 cs 的做法——`python:` 块内每一行逐行识别并映射。已知可识别：
- `achievement.grant("X")` → `_gameMethods.GrantAchievement("X");`
- `achievement.sync()` → `_gameMethods.SyncAchievement();`

**如果出现无法识别的 python 语句**，我会在转译时**逐条标记**并在报告中列出，等您确认后再手填。

### 6.5 ❓ ATL 动画关键字（parallel 内部）

**已支持**（现有 cs 都有样本）：linear, easein, easein_cubic, alpha, xoffset, yoffset, xpos, ypos, zpos, pause, blur, zoom, anchor, pos, subpixel, rotate

**未确认**：如果新文件中出现上述以外的 ATL 关键字，我会列出来让您确认如何对应。

---

## 7. 后续不可避免的**副产物**

### 7.1 dialogues.txt 需要扩展

现有 `dialogues.txt` 包含 6010 行，对应已转译文件的对白 ID。新转译的 9 个文件会新增约 **5000~6000 条**对白，需要追加到 dialogues.txt 并分配连续 ID。

**建议**：从当前最大 ID 开始递增。**会在转译时自动生成。**

### 7.2 labels.txt 需要扩展

新转译的每个 label 需要加一行：`label_<name>, <class>, file_path`。

**建议**：自动追加。

### 7.3 新 cs 文件清单

将新增 9 个主 cs + 对应的若干 _menu.cs（取决于每个文件有多少 menu 分支）：
- end7.cs, end7_menu.cs（注意：cs 类名应为 `end7` 但内含 label `end6/end6_1/end6_2`）
- juezhan.cs, juezhan_menu.cs
- fanhuitu.cs, fanhuitu_menu.cs
- juezhanhou_bai.cs (无 menu)
- tuanzhan_you.cs, tuanzhan_you_menu.cs
- bai1.cs, bai1_menu.cs
- zhuxian6.cs, zhuxian6_menu.cs
- bai.cs, bai_menu.cs
- zhuxian5.cs, zhuxian5_menu.cs

注意：**文件路径对 class 名的影响**——现有 cs 用的是**文件名**（不含目录）作为 class 名（如 `end/end3.cs` 的类名是 `end3`）。跨目录重名应该不会有，因为原版 rpy 也没有重名文件。

---

## 8. 工具方案建议

考虑到工作量（17k+ 行），**唯一可行的做法是用 Python 写一个 rpy→cs 转译器**，而不是手工逐行。
我会：

1. 基于现有 end3/zhuxian0 的 rpy↔cs 对照写**规则引擎**（行级解析 + ATL 块解析）
2. 先对**已转译**的一个文件（如 zhuxian0.rpy）作**回归测试**：输入 rpy，对比输出是否与现有 cs 基本一致
3. 通过后再批量转译 9 个新文件
4. 对无法自动转换的语句，在 cs 中生成 `// TODO:` 注释并列出清单

---

## 9. 我需要您确认的事项

请逐条回复"同意/不同意/其他方案"：

### Q1 — 跳过决策
✅ 确认跳过 end1/end2/end4？（依据 `project_decisions.md`）

### Q2 — 校验并修复已转译 cs 的 bug
是否授权我在批量转译之前，**先审计并修复**现有 cs 的 `if` 条件 bug（如 end3.cs 的 `and` 链简化）？预计影响 2~5 处。

### Q3 — 已转译 cs 补齐遗漏 label
是否授权我补齐 `zhuxian_2.cs` 的 `label_choice12`？

### Q4 — `menu:`（无 screen）处理方案
请选：**A** 自动 screen 名（`"menu_<label>_<lineno>"`）/ **B** 查看现有样本仿造 / **C** 跳过并列出清单

### Q5 — `call <label> from ...` 处理方案
请选：**A** `yield return <labelMethod>()`（同步等待）/ **B** `JumpToLabel`（无返回）/ **C** 其他

### Q6 — `python:` 块未知调用
如果出现除 `achievement.*` 之外的无法识别调用，**A** 生成 TODO 注释 / **B** 停止等您确认

### Q7 — 工具方案
是否同意我写 Python 转译器 + 回归测试后再批量转译？还是您希望我逐文件手动转？

### Q8 — dialogues.txt / labels.txt 自动追加
是否授权我直接追加这两个配置文件？

### Q9 — 执行顺序
1. 先修 Q2/Q3 的 bug 和遗漏
2. 写转译器 + 回归测试
3. 批量转 9 个文件
4. 把 139 条未匹配的 voice entry 重新跑一遍补全
5. 报告结果

此顺序是否 OK？或者您希望先做别的？

---

## 10. 风险与已知限制

1. **转译器必然有 bug**：即使回归测试通过，新文件仍可能有语法角落。我会生成 `converter_bugs_audit_v2.txt` 列出所有 `// TODO:` 和异常行。
2. **label 跨文件跳转**：当一个文件 `jump` 到另一个文件的 label 时（如 end7.rpy → end6），需要确保 LabelRegistry 能正确解析。现有 `RunCoroutineByMethodOnly` 可按方法名查找，已足够。
3. **Haogandu/Choice_new 等全局变量**：新文件使用的变量如果 `Defaults` 类里没有，需要在 `Defaults.cs` 里补定义。我会在转译时列一个清单。
4. **文件名含空格**："the fourth year" 和 "the third year_d" 目录名有空格。cs 目录可以用同名或改为下划线。**请决定**：保留空格 / 改为 `the_fourth_year`？
