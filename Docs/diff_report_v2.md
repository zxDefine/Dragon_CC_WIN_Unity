# rpy → cs 转译 v2 差异报告

> 生成日期：2026-04-14
> 更新范围：Phase 1 (选项 C) 修复结果 + 推迟到 Phase 3 之后的审计清单

---

## 1. Phase 1 已完成的修复

### 1.1 if 条件链简化 bug（已修）

| # | 位置 | 原 cs（错） | 修复 |
|---|---|---|---|
| 1 | [end3.cs:L180](../dragon_unity/Dragon/Assets/Script/GameScript/game/rpy/zhuxian/end/end3.cs#L180) | `if (Jq_11_7==1)` | 展开为 7 条件 `&&` |
| 2 | [end5.cs:L1133](../dragon_unity/Dragon/Assets/Script/GameScript/game/rpy/zhuxian/end/end5.cs#L1133) | `if (Jq_11_7==1)` | 展开为 7 条件 `&&` |

**影响**：成就 `NEW_ACHIEVEMENT_1_7` 现在只在 jq_11_1..7 全部为 1 时才会授予，与原版一致。

### 1.2 缺失 label（已修）

| 文件 | 缺失 label | 修复方式 |
|---|---|---|
| [zhuxian_2.cs](../dragon_unity/Dragon/Assets/Script/GameScript/game/rpy/zhuxian/zhuxian_2.cs) | `label_choice12` | 从 `label_demo_bai_over` 尾部切分出 207 行（59 OpenDialog / 6 PlayVoice）独立为 `label_choice12()` 方法；在 demo_bai_over 尾部插入 `ChangeLabelTo("label_choice12")` 保留 fall-through 语义；labels.txt 注册 |

### 1.3 内容缺失修复（end6 菜单分支）

| 文件 | 问题 | 修复方式 |
|---|---|---|
| [end6_menu.cs](../dragon_unity/Dragon/Assets/Script/GameScript/game/rpy/zhuxian/end/end6_menu.cs) | `label_end6_menu_0_IdEQSfpx` 在 labels.txt 注册但方法未实现（悬空引用）；原版 rpy L2517-2898 "-自己戴上冠冕" 菜单选项（~380 行）完全丢失 | 新增方法 `label_end6_menu_0_IdEQSfpx()`，包含 73 条 OpenDialog + 两个 `if bai_xue` 分支 + 所有 show/scene/camera/play/stop/python 块 + 结尾的成就授予；严格对照 rpy L2518-2898 手工转译 |

#### 1.3.1 转译映射

| rpy 段 | 行数 | cs 对应 |
|---|---|---|
| L2518-2565 前奏（女王冠冕前戏） | 48 行 | 方法开头 28 行 |
| L2675-2780 `if bai_xue==1 && he_xianzai==0` 分支（安德鲁+洛恩作证+宣王） | 106 行 | 第一个 if 块 70 行 |
| L2781-2853 `if bai_xue==1` 分支（白龙降临加冕） | 73 行 | 第二个 if 块 55 行 |
| L2854-2898 结尾（黑屏+成就+末尾判定） | 45 行 | 结尾 25 行 |
| **合计** | **272 行 rpy** | **~180 行 cs** |

---

## 2. Phase 1 未动的发现（⏸ 推迟到 Phase 3 之后）

以下是 Phase 1 扫描出、**但尚未处理**的问题清单。按优先级排序。

### 2.1 其他文件的对白数量差异（待复核）

按"rpy 对白行数 vs cs OpenDialog 数"粗略比对（Phase 1 使用朴素统计，数字是**上限估计**）：

| rpy 文件 | rpy 对白 | cs OpenDialog | 差额 | 优先级 | 备注 |
|---|---:|---:|---:|---:|---|
| zhuxian4.rpy | 914 | 665 | **249** | 高 ⚠️ | 27% 差额。rpy 有 6 个被注释掉的 label (`choice_or_ending2/choice29/choice31/zhuxian4_4/he_xian1/zhuxian4_wangzi1`)，可能是误计入统计；但 27% 明显偏高，仍需逐 label 核查 |
| zhuxian_1.rpy | 1741 | 1553 | 188 | 中 | 11% 差额 |
| zhuxian_2.rpy | 1018 | 902 | 116 | 中 | choice12 补齐后应降至约 57（因为 choice12 给出 59 个新 OpenDialog） |
| end6.rpy | 756 | 675 | 81 | ✅ 已降低 | IdEQSfpx 补齐后应降至约 8 |
| zhuxian_3.rpy | 914 | 859 | 55 | 中低 | 6% |
| end5.rpy | 305 | 285 | 20 | 低 | 7% |
| end3.rpy | 48 | 43 | 5 | 低 | 10% |
| zhuxian0.rpy | 503 | 499 | 4 | 最低 ✓ | |
| wangzi.rpy | 706 | 704 | 2 | 最低 ✓ | |

**推迟处理方式**：Phase 3 完成后，对每个文件逐 label 做**句对句**比对（而非整体数量比对），生成 `diff_report_v3.md`，列出所有缺失的 dialog / show / scene / play 调用。

### 2.2 待全面审计的 if 条件

Phase 1 审计工具只捕获了 `and` 链被简化为 1 条的情况。未覆盖的潜在问题：
- `and` 被简化为 2~6 条（只保留部分）
- `or` 被误转为 `&&` 或反之
- 比较运算符颠倒（如 `== 0` → `== 1`）
- 变量名大小写错误（如 `Persistent.PovName` vs `Persistent.Povname`）

**推迟处理方式**：Phase 3 完成后，对每个 cs 文件的每个 `if` 语句，逐条对照 rpy 原版。

### 2.3 其他潜在的"转换器 bug"模式

| 类别 | 症状 | 实例 |
|---|---|---|
| label 被误解析 | `label choice12:` → `Show("label", ["choice12"])` | 已修（zhuxian_2.cs），但其他文件可能也有 |
| 菜单分支 body 丢失 | 菜单桥接 label 注册但方法未实现 | 已修（IdEQSfpx），需确认其他 cs 中所有 menu jump 的目标 label 都有实现 |
| 嵌套 if 分支丢失 | rpy 的深嵌 if body 被压平或丢弃 | 未系统扫描，只在 end6 发现 |
| `extend` 对白丢失 | rpy 的 `extend "text"` 可能被跳过 | 未扫描 |
| 缩进混乱 | 部分方法体使用 16 空格缩进（正常应为 8）| 不影响运行，但可读性差 |

**推迟处理方式**：
- 悬空 label 扫描：写脚本检查所有 `OpenSelectMenu` 的 jump 目标是否都在 labels.txt + 实现存在 → Phase 3 开始前做
- 其他深入检查：Phase 3 完成后做

---

## 3. Phase 3 开工前的必做检查项

这几项建议在 Phase 3 开始**之前**快速完成（约 30 分钟工作量）：

### 3.1 悬空菜单 jump 目标扫描

```bash
# 找所有 OpenSelectMenu 的 jump 目标 → 与 labels.txt 交叉验证 → 输出未实现清单
```

### 3.2 简单 label 解析 bug 重扫

```bash
# 搜索所有 `Show("label", ...)` 形式 → 都是转换器 bug
```

### 3.3 重跑 voice 映射匹配器

zhuxian_2.cs 已新增 choice12（59 个 OpenDialog），end6_menu.cs 已新增 IdEQSfpx（73 个 OpenDialog）。之前 Phase M1.9 的 465 条 PlayVoice 插入会出现新的可匹配项，可能补 30-50 条。

---

## 4. Phase 3 工作量估算

未转译 9 个 rpy 文件 ≈ 19,364 行。按人工手动转译速度 50-80 行/小时，**预计 250-400 小时**工作量。

| 文件 | 行数 | 顶层 label | 难度 |
|---|---:|---|---|
| guodu/fanhuitu.rpy | 365 | 3 | 小（练手） |
| guodu/juezhanhou_bai.rpy | 519 | 1 | 小 |
| the fourth year/bai/bai1.rpy | 1094 | 4 | 中 |
| end/juezhan.rpy | 1135 | 3 | 中 |
| guodu/tuanzhan_you.rpy | 1558 | 3 | 中 |
| end/end7.rpy | 2625 | 3 | 大 |
| the third year_d/bai/bai.rpy | 3033 | 8 | 大 |
| the fourth year/zhuxian6.rpy | 3200 | 8 | 大 |
| the third year_d/zhuxian5.rpy | 3749 | 8 | 大 |

**建议顺序**：从小到大（对应上表由上到下）。每完成一个文件暂停验收。

---

## 5. 下一步

进入 Phase 2：
- 创建下划线目录结构 `the_fourth_year/` / `the_third_year_d/`（存放新生成的 cs 文件）
- 验证路径是否会影响 LabelRegistry

然后进入 Phase 3：逐文件手动转译，从最小的 `fanhuitu.rpy` 开始。
