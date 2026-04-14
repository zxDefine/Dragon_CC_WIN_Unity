"""Phase 3 开工前的三项检查：
1. 悬空菜单 jump 目标扫描
2. Show("label", ...) 形式 bug 重扫
3. voice mapping 重新匹配（统计新增了 choice12 和 IdEQSfpx 后可补上的数量）
"""
import os
import sys
import io
import re
import json

sys.stdout = io.TextIOWrapper(sys.stdout.buffer, encoding='utf-8')

GS_ROOT = r'h:/Programming/ProjDragon/dragon_cc_win/dragon_unity/Dragon/Assets/Script/GameScript'
LABELS_TXT = r'h:/Programming/ProjDragon/dragon_cc_win/dragon_unity/Dragon/Assets/RenpyResources/middle_data/labels.txt'

# === 1. 悬空菜单 jump 目标扫描 ===
print("=" * 60)
print("检查 1: 悬空菜单 jump 目标")
print("=" * 60)

# 收集所有 cs 文件中的 OpenSelectMenu jump 目标
all_jumps = []  # (cs_file, line_num, [targets])
for root, dirs, files in os.walk(GS_ROOT):
    for fn in files:
        if not fn.endswith('.cs'):
            continue
        p = os.path.join(root, fn)
        rel = os.path.relpath(p, GS_ROOT).replace('\\', '/')
        with open(p, 'r', encoding='utf-8') as f:
            for i, ln in enumerate(f, 1):
                if 'OpenSelectMenu' in ln:
                    # 提取 jump 列表
                    m = re.search(r'jump:\s*new\s*List<string>\{([^}]*)\}', ln)
                    if m:
                        body = m.group(1)
                        targets = re.findall(r'"([^"]+)"', body)
                        all_jumps.append((rel, i, targets))

# 收集所有实现过的 label 方法
impl_labels = set()
for root, dirs, files in os.walk(GS_ROOT):
    for fn in files:
        if not fn.endswith('.cs'):
            continue
        p = os.path.join(root, fn)
        with open(p, 'r', encoding='utf-8') as f:
            content = f.read()
        for m in re.finditer(r'IEnumerator\s+(label_\w+)\s*\(', content):
            impl_labels.add(m.group(1))

# 收集 labels.txt 注册项
registered = set()
with open(LABELS_TXT, 'r', encoding='utf-8') as f:
    for line in f:
        parts = [p.strip() for p in line.split(',')]
        if len(parts) == 3:
            registered.add(parts[0])

dangling = []
for rel, ln, targets in all_jumps:
    for t in targets:
        if t == 'NONE':
            continue
        if t not in impl_labels:
            dangling.append((rel, ln, t))

print(f"总 OpenSelectMenu 调用: {len(all_jumps)}")
print(f"总 jump 目标（去除 NONE）: {sum(1 for _, _, ts in all_jumps for t in ts if t != 'NONE')}")
print(f"已实现 label 方法总数: {len(impl_labels)}")
print(f"labels.txt 注册项数: {len(registered)}")
print(f"\n悬空 jump 目标（未实现）: {len(dangling)}")
for rel, ln, target in dangling[:20]:
    status = ' (labels.txt 已注册)' if target in registered else ' (labels.txt 未注册)'
    print(f"  {rel}:L{ln} → {target}{status}")
if len(dangling) > 20:
    print(f"  ... 还有 {len(dangling) - 20} 个")

# === 2. Show("label", ...) 形式 bug 扫描 ===
print("\n" + "=" * 60)
print("检查 2: Show(\"label\", ...) 形式 bug")
print("=" * 60)

bugs = []
for root, dirs, files in os.walk(GS_ROOT):
    for fn in files:
        if not fn.endswith('.cs'):
            continue
        p = os.path.join(root, fn)
        rel = os.path.relpath(p, GS_ROOT).replace('\\', '/')
        with open(p, 'r', encoding='utf-8') as f:
            for i, ln in enumerate(f, 1):
                if re.search(r'Show\("label",\s*parts:', ln):
                    m = re.search(r'Show\("label",\s*parts:\s*new\s*List<string>\{([^}]*)\}', ln)
                    if m:
                        parts = re.findall(r'"([^"]+)"', m.group(1))
                        bugs.append((rel, i, parts))

print(f"发现: {len(bugs)}")
for rel, ln, parts in bugs:
    print(f"  {rel}:L{ln} → Show(\"label\", {parts})")

# === 3. 重跑 voice mapping 统计（增量部分） ===
print("\n" + "=" * 60)
print("检查 3: voice mapping 重跑（需要手动运行 match_voice_to_cs.py + apply）")
print("=" * 60)
print("新增的 OpenDialog 可能让之前未匹配的 voice entry 现在能匹配上。")
print("建议在 Phase 3 完成后一次性重跑。")
