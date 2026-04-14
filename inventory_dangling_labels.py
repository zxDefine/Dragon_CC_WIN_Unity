"""构建悬空 label 的完整清单：
- 每个悬空 label 的 cs 引用位置（所在方法 + 行号）
- OpenSelectMenu 的 talk 列表（菜单选项文本）
- 该 cs 方法对应的 rpy label
- 在 rpy 中查找对应 menu 的行号 + 对应选项的 body 行数

输出: dangling_inventory.json + 可读表格
"""
import os
import sys
import io
import re
import json
from collections import defaultdict

sys.stdout = io.TextIOWrapper(sys.stdout.buffer, encoding='utf-8')

GS_ROOT = r'h:/Programming/ProjDragon/dragon_cc_win/dragon_unity/Dragon/Assets/Script/GameScript'
RPY_ROOT = r'h:/Programming/ProjDragon/dragon_cc_win/dragon_yuanban'
OUT_JSON = r'h:/Programming/ProjDragon/dragon_cc_win/dangling_inventory.json'

# 1. 收集所有 cs 中实现的 label 方法
impl_labels = set()
cs_label_methods = {}  # label_name -> (cs_rel, line)
for root, dirs, files in os.walk(GS_ROOT):
    for fn in files:
        if not fn.endswith('.cs'):
            continue
        p = os.path.join(root, fn)
        rel = os.path.relpath(p, GS_ROOT).replace('\\', '/')
        with open(p, 'r', encoding='utf-8') as f:
            for i, ln in enumerate(f, 1):
                m = re.search(r'IEnumerator\s+(label_\w+)\s*\(', ln)
                if m:
                    impl_labels.add(m.group(1))
                    cs_label_methods[m.group(1)] = (rel, i)


# 2. 解析所有 OpenSelectMenu 调用的上下文
# 对每个调用，记录：所在 cs 文件、所在方法（label_X）、行号、talk 列表、jump 列表
def parse_cs_menus(cs_path, cs_rel):
    with open(cs_path, 'r', encoding='utf-8') as f:
        lines = f.readlines()
    results = []  # [{cs_rel, line, method, talk, jump, condition}]
    current_method = None
    for i, ln in enumerate(lines, 1):
        m = re.search(r'IEnumerator\s+(label_\w+)\s*\(', ln)
        if m:
            current_method = m.group(1)
        if 'OpenSelectMenu' in ln:
            # 从该行 + 可能的后几行拼接（可能跨行但这里一般单行）
            full = ln.rstrip()
            # talk list
            tmatch = re.search(r'talk:\s*new\s*List<string>\{([^}]*)\}', full)
            jmatch = re.search(r'jump:\s*new\s*List<string>\{([^}]*)\}', full)
            cmatch = re.search(r'condition:\s*new\s*List<string>\{([^}]*)\}', full)
            smatch = re.search(r'screen:\s*"([^"]*)"', full)
            talks = re.findall(r'"([^"]*)"', tmatch.group(1)) if tmatch else []
            jumps = re.findall(r'"([^"]*)"', jmatch.group(1)) if jmatch else []
            conds = re.findall(r'"([^"]*)"', cmatch.group(1)) if cmatch else []
            screen = smatch.group(1) if smatch else None
            results.append({
                'cs_rel': cs_rel,
                'cs_line': i,
                'method': current_method,
                'talk': talks,
                'jump': jumps,
                'condition': conds,
                'screen': screen,
            })
    return results


all_menus = []
for root, dirs, files in os.walk(GS_ROOT):
    for fn in files:
        if not fn.endswith('.cs'):
            continue
        p = os.path.join(root, fn)
        rel = os.path.relpath(p, GS_ROOT).replace('\\', '/')
        all_menus.extend(parse_cs_menus(p, rel))

print(f"全部 OpenSelectMenu 调用: {len(all_menus)}")


# 3. 构建悬空清单（按 cs 文件分组）
dangling_entries = []
for menu in all_menus:
    for idx, target in enumerate(menu['jump']):
        if target == 'NONE':
            continue
        if target not in impl_labels:
            dangling_entries.append({
                'cs_rel': menu['cs_rel'],
                'cs_line': menu['cs_line'],
                'container_method': menu['method'],
                'option_index': idx,
                'option_text': menu['talk'][idx] if idx < len(menu['talk']) else '',
                'screen': menu['screen'],
                'target_label': target,
            })

print(f"悬空 jump 目标: {len(dangling_entries)}")


# 4. 读取 rpy，为每个 cs 文件找对应 rpy 源
# cs 路径 → rpy 路径
def cs_to_rpy_path(cs_rel):
    # game/rpy/zhuxian/end/end6.cs → game/rpy/zhuxian/end/end6.rpy
    # game/rpy/zhuxian/end/end6_menu.cs → game/rpy/zhuxian/end/end6.rpy
    if cs_rel.endswith('_menu.cs'):
        rpy = cs_rel[:-len('_menu.cs')] + '.rpy'
    else:
        rpy = cs_rel[:-3] + '.rpy'
    return os.path.join(RPY_ROOT, rpy.replace('/', os.sep))


# 5. 在 rpy 中找 menu 的位置：用 container_method (label_name) 定位 rpy label，再找 menu:
def find_rpy_menu_for_entry(entry):
    cs_rel = entry['cs_rel']
    container = entry['container_method']  # e.g., label_choice23
    if not container:
        return None
    label_name = container[len('label_'):] if container.startswith('label_') else container
    rpy_path = cs_to_rpy_path(cs_rel)
    if not os.path.exists(rpy_path):
        return None
    with open(rpy_path, 'r', encoding='utf-8') as f:
        rpy_lines = f.readlines()
    # Find label <label_name>: top-level
    label_start = None
    label_end = None
    for i, ln in enumerate(rpy_lines, 1):
        if re.match(rf'^label\s+{re.escape(label_name)}\s*(?:\([^)]*\))?\s*:', ln):
            label_start = i
    if label_start is None:
        return None
    # Find end of this label (next top-level label or file end)
    for i in range(label_start, len(rpy_lines)):
        ln = rpy_lines[i]
        if i + 1 > label_start and ln and not ln[0].isspace() and ln.strip() and not ln.startswith('#'):
            if re.match(r'^label\s+\w+', ln):
                label_end = i + 1
                break
    if label_end is None:
        label_end = len(rpy_lines)

    # In label body, find all menu: blocks (recursively)
    # Each menu: with multiple "-option": children
    # Match by option_text
    target_text = entry['option_text']
    for i in range(label_start, label_end):
        ln = rpy_lines[i]
        if re.match(r'^\s*menu\s*(?:\([^)]*\))?\s*:', ln) and not ln.lstrip().startswith('#'):
            menu_line = i + 1
            menu_indent = len(ln) - len(ln.lstrip())
            # Look at children: options at menu_indent+4
            opt_indent = menu_indent + 4
            options = []  # (start_line, end_line, option_text)
            j = i + 1
            while j < label_end:
                sl = rpy_lines[j]
                if not sl.strip() or sl.lstrip().startswith('#'):
                    j += 1
                    continue
                lead = len(sl) - len(sl.lstrip())
                if lead <= menu_indent:
                    break
                if lead == opt_indent and sl.lstrip().startswith('"') and sl.rstrip().endswith(':'):
                    # This is an option
                    opt_text = sl.strip()[1:]  # remove leading "
                    opt_text = opt_text.rsplit('"', 1)[0]
                    # Find end of option body
                    opt_start = j + 1
                    opt_end = None
                    k = opt_start
                    while k < label_end:
                        sl2 = rpy_lines[k]
                        if not sl2.strip():
                            k += 1
                            continue
                        lead2 = len(sl2) - len(sl2.lstrip())
                        if lead2 <= opt_indent and sl2.strip():
                            opt_end = k
                            break
                        k += 1
                    if opt_end is None:
                        opt_end = label_end
                    options.append((j + 1, opt_end, opt_text))
                    j = opt_end
                else:
                    j += 1
            # Try to match target_text to an option
            for ostart, oend, otext in options:
                if otext == target_text:
                    return {
                        'menu_line': menu_line,
                        'option_start': ostart + 1,  # body first line
                        'option_end': oend,
                        'body_lines': oend - ostart,
                        'option_text': otext,
                    }
            # If no exact text match but only 1 option, return it
            if len(options) == 1 and target_text:
                ostart, oend, otext = options[0]
                return {
                    'menu_line': menu_line,
                    'option_start': ostart + 1,
                    'option_end': oend,
                    'body_lines': oend - ostart,
                    'option_text': otext,
                    'note': 'single_option_no_text_match',
                }
    return None


# 6. 为每个悬空 entry 查找 rpy 源
for entry in dangling_entries:
    rpy_info = find_rpy_menu_for_entry(entry)
    entry['rpy_info'] = rpy_info


# 7. 输出
with open(OUT_JSON, 'w', encoding='utf-8') as f:
    json.dump(dangling_entries, f, ensure_ascii=False, indent=1)

# 按 cs 文件分组汇总
from collections import Counter, defaultdict
by_file = defaultdict(list)
for e in dangling_entries:
    by_file[e['cs_rel']].append(e)

print(f"\n按 cs 文件分组:")
print(f"{'cs 文件':60} {'悬空数':>6} {'总行数':>7}")
print('=' * 80)
total_rpy_lines = 0
for cs_rel in sorted(by_file.keys()):
    entries = by_file[cs_rel]
    cnt = len(entries)
    total = sum(e['rpy_info']['body_lines'] for e in entries if e.get('rpy_info'))
    total_rpy_lines += total
    print(f"{cs_rel:60} {cnt:>6} {total:>7}")

print(f"\n总计: {len(dangling_entries)} 处悬空 label, 约 {total_rpy_lines} 行 rpy 需要转译")

# 找不到 rpy 源的
unmatched = [e for e in dangling_entries if not e.get('rpy_info')]
if unmatched:
    print(f"\n无法定位 rpy 源: {len(unmatched)}")
    for e in unmatched[:10]:
        print(f"  {e['cs_rel']}:L{e['cs_line']} method={e['container_method']} target={e['target_label']} opt='{e['option_text'][:30]}'")
