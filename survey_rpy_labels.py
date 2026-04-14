"""盘点所有原版 rpy 文件的 label，并对比 labels.txt + cs 文件中已实现的 label。"""
import os
import sys
import io
import re
from collections import defaultdict

sys.stdout = io.TextIOWrapper(sys.stdout.buffer, encoding='utf-8')

RPY_ROOT = r'h:/Programming/ProjDragon/dragon_cc_win/dragon_yuanban/game/rpy/zhuxian'
CS_ROOT = r'h:/Programming/ProjDragon/dragon_cc_win/dragon_unity/Dragon/Assets/Script/GameScript/game/rpy/zhuxian'
LABELS_TXT = r'h:/Programming/ProjDragon/dragon_cc_win/dragon_unity/Dragon/Assets/RenpyResources/middle_data/labels.txt'

# 1. 收集 rpy 里所有 label
rpy_labels = defaultdict(list)  # rel_file -> [(line, label, commented)]
total_lines = 0
for root, dirs, files in os.walk(RPY_ROOT):
    for fn in files:
        if not fn.endswith('.rpy'):
            continue
        path = os.path.join(root, fn)
        with open(path, 'r', encoding='utf-8') as f:
            lines = f.readlines()
        total_lines += len(lines)
        rel = os.path.relpath(path, RPY_ROOT).replace(os.sep, '/')
        for i, ln in enumerate(lines, 1):
            stripped = ln.lstrip()
            # 顶层 label（不缩进）
            if ln[0] not in ' \t':
                m = re.match(r'^label\s+(\w+)\s*(?:\([^)]*\))?\s*:', stripped)
                if m:
                    rpy_labels[rel].append((i, m.group(1), False))
            # 注释掉的 label
            if stripped.startswith('#'):
                m = re.match(r'^#\s*label\s+(\w+)', stripped)
                if m:
                    rpy_labels[rel].append((i, m.group(1), True))

# 2. 从 labels.txt 读已注册的 label
registered = set()
registered_by_class = defaultdict(list)
with open(LABELS_TXT, 'r', encoding='utf-8') as f:
    for line in f:
        parts = [p.strip() for p in line.split(',')]
        if len(parts) == 3:
            method, cls, _ = parts
            # method 例如 label_choice22
            short = method[6:] if method.startswith('label_') else method
            registered.add(short)
            registered_by_class[cls].append(short)

# 3. 从 cs 文件扫描已实现的 IEnumerator label_xxx() 方法
cs_methods = defaultdict(set)  # cs_basename -> {method_name}
for root, dirs, files in os.walk(CS_ROOT):
    for fn in files:
        if not fn.endswith('.cs'):
            continue
        path = os.path.join(root, fn)
        with open(path, 'r', encoding='utf-8') as f:
            content = f.read()
        for m in re.finditer(r'IEnumerator\s+label_(\w+)\s*\(', content):
            cs_methods[fn[:-3]].add(m.group(1))

# 4. 报告
print("=" * 60)
print("原版 rpy label 盘点")
print("=" * 60)
all_rpy_labels = set()
for rel in sorted(rpy_labels):
    active = [l for l in rpy_labels[rel] if not l[2]]
    commented = [l for l in rpy_labels[rel] if l[2]]
    print(f"\n{rel}")
    print(f"  有效 label: {len(active)}, 注释掉: {len(commented)}")
    for line, name, _ in active:
        all_rpy_labels.add(name)
        impl = "✓" if name in registered else "✗"
        print(f"    {impl} L{line}: {name}")
    if commented:
        for line, name, _ in commented:
            print(f"    # L{line}: {name} (注释)")

print("\n" + "=" * 60)
print("cs 文件实现的 label 方法")
print("=" * 60)
all_cs_methods = set()
for cs in sorted(cs_methods):
    all_cs_methods |= cs_methods[cs]
    print(f"  {cs}.cs: {len(cs_methods[cs])} methods")

print("\n" + "=" * 60)
print("差异")
print("=" * 60)
missing_impl = all_rpy_labels - all_cs_methods
extra_impl = all_cs_methods - all_rpy_labels
print(f"rpy 有但 cs 缺失: {len(missing_impl)}")
for m in sorted(missing_impl)[:30]:
    print(f"  - {m}")
if len(missing_impl) > 30:
    print(f"  ...还有 {len(missing_impl) - 30} 个")

print(f"\ncs 有但 rpy 中没找到: {len(extra_impl)}")
for m in sorted(extra_impl)[:20]:
    print(f"  - {m}")

print(f"\n原版 rpy 总行数: {total_lines}")
print(f"原版 rpy 有效 label 总数: {len(all_rpy_labels)}")
print(f"cs 已实现 label 总数: {len(all_cs_methods)}")
