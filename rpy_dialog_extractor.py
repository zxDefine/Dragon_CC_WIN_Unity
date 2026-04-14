"""为新 rpy 文件提取所有对话行并分配/查找 ID，用于手动 cs 转译。

用法：python rpy_dialog_extractor.py <rpy_rel_path> [--append]
  --append: 实际向 dialogues.txt 追加新 ID（否则只预览）

输出：
- 控制台：所有 dialog 行的 [ID] | character | attrs | text 表
- JSON：保存到 rpy_dialogs_<basename>.json 供 cs 转译参考
"""
import os
import sys
import io
import re
import json

sys.stdout = io.TextIOWrapper(sys.stdout.buffer, encoding='utf-8')

RPY_ROOT = r'h:/Programming/ProjDragon/dragon_cc_win/dragon_yuanban'
DLG = r'h:/Programming/ProjDragon/dragon_cc_win/dragon_unity/Dragon/Assets/RenpyResources/middle_data/dialogues.txt'

EXCLUDE_FIRST = {
    'show', 'scene', 'play', 'stop', 'hide', 'with', 'camera:', 'if',
    'elif', 'else:', 'jump', 'menu:', 'menu', 'call', 'label', 'python:',
    'voice', '$', 'return', 'define', 'image', 'pause', 'window',
    'parallel:', 'linear', 'easein', 'alpha', 'pos', 'anchor', 'zoom',
    'xpos', 'ypos', 'zpos', 'xoffset', 'yoffset', 'blur', 'rotate',
    'perspective', 'gl_depth', 'ease', 'time', 'subpixel', 'easein_bounce',
    'easein_cubic', 'easein_circ', 'easeout', '#', 'init',
}

# 这些 patterns（子串）出现在行首时也应跳过（python 块内函数调用）
EXCLUDE_SUBSTR = ('achievement.', 'renpy.', 'persistent.', '_history', 'extend renpy')


def parse_rpy_dialog(rpy_path):
    """解析 rpy，输出每一行的 (line_num, kind, character, attrs, text).

    kind: 'dialog' / 'extend' / 'narrator' / 'comment' / 'other'
    """
    with open(rpy_path, 'r', encoding='utf-8') as f:
        lines = f.readlines()
    result = []
    for i, ln in enumerate(lines, 1):
        stripped = ln.strip()
        raw_orig = ln.rstrip('\r\n')
        if not stripped:
            continue
        if stripped.startswith('#'):
            continue
        # Skip block-attribute continuations (indented non-root statements)
        first = stripped.split()[0]
        first_clean = first.rstrip(':')
        if first_clean in EXCLUDE_FIRST:
            continue
        if first in EXCLUDE_FIRST:
            continue
        if any(stripped.startswith(p) for p in EXCLUDE_SUBSTR):
            continue
        # Does it have a quoted string?
        m = re.search(r'"([^"]*)"', stripped)
        if not m:
            continue
        text = m.group(1)
        # Empty dialogs we skip
        if not text:
            continue
        # Split "character [attrs...] "text""
        before_quote = stripped[:m.start()].strip()
        character = ''
        attrs = ''
        kind = 'narrator'
        if before_quote:
            parts = before_quote.split()
            if parts:
                first_tok = parts[0]
                if first_tok == 'extend':
                    kind = 'extend'
                    character = ''
                    attrs = ' '.join(parts[1:]) if len(parts) > 1 else ''
                else:
                    character = first_tok
                    attrs = ' '.join(parts[1:]) if len(parts) > 1 else ''
                    kind = 'dialog'
        result.append({
            'line': i,
            'kind': kind,
            'character': character,
            'attrs': attrs,
            'text': text,
            'raw': raw_orig,
        })
    return result


def load_existing_dialogs():
    """返回 (text → [ID]) 字典，以及当前最大 ID。"""
    index = {}
    max_id = -1
    with open(DLG, 'r', encoding='utf-8') as f:
        for i, line in enumerate(f):
            line = line.rstrip('\r\n')
            idx = line.rfind(', ..')
            if idx < 0:
                continue
            text = line[:idx]
            index.setdefault(text, []).append(i)
            max_id = i
    return index, max_id


def main():
    if len(sys.argv) < 2:
        print("用法: python rpy_dialog_extractor.py <rpy_rel_path> [--append]")
        sys.exit(1)
    rpy_rel = sys.argv[1]
    do_append = '--append' in sys.argv
    rpy_path = os.path.join(RPY_ROOT, rpy_rel.replace('/', os.sep))
    if not os.path.exists(rpy_path):
        print(f"文件不存在: {rpy_path}")
        sys.exit(1)

    dlg_index, max_id = load_existing_dialogs()
    print(f"当前 dialogues.txt 最大 ID: {max_id}")

    entries = parse_rpy_dialog(rpy_path)
    print(f"解析 rpy 对话行数: {len(entries)}")

    # 分配 ID（优先复用相同文本）
    # 但对于同一文本的多个出现，复用第一个 ID（和现有 cs 风格一致）
    new_entries = []  # (text, rpy_file) to append
    assigned_this_run = {}  # text → id (for newly assigned in this run)
    for e in entries:
        text = e['text']
        if text in dlg_index:
            e['dialog_id'] = dlg_index[text][0]
            e['new'] = False
        elif text in assigned_this_run:
            e['dialog_id'] = assigned_this_run[text]
            e['new'] = False  # 已在本轮分配
        else:
            max_id += 1
            e['dialog_id'] = max_id
            e['new'] = True
            assigned_this_run[text] = max_id
            new_entries.append((text, rpy_rel))

    print(f"需要新增 {len(new_entries)} 条对白")
    print(f"复用现有 ID: {sum(1 for e in entries if not e['new'])}")

    # 按 kind 统计
    from collections import Counter
    kind_counts = Counter(e['kind'] for e in entries)
    print(f"按 kind 分类: {dict(kind_counts)}")

    # 输出到 JSON
    basename = os.path.basename(rpy_rel).replace('.rpy', '')
    out_path = rf'h:/Programming/ProjDragon/dragon_cc_win/rpy_dialogs_{basename}.json'
    with open(out_path, 'w', encoding='utf-8') as f:
        json.dump({
            'rpy_file': rpy_rel,
            'entries': entries,
            'new_count': len(new_entries),
            'max_id_after': max_id,
        }, f, ensure_ascii=False, indent=1)
    print(f"已保存到 {out_path}")

    if do_append and new_entries:
        # 追加新条目到 dialogues.txt，路径使用 ../middle_code/ + 原 rpy_rel（不重复）
        dlg_rel = f"../middle_code/{rpy_rel}"
        with open(DLG, 'a', encoding='utf-8', newline='\n') as f:
            for text, _ in new_entries:
                f.write(f"{text}, {dlg_rel}\n")
        print(f"✅ 已追加 {len(new_entries)} 条到 dialogues.txt")


if __name__ == '__main__':
    main()
