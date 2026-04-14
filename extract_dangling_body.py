"""通用工具：给定 rpy 文件 + 起止行号，提取每行并查找 dialog ID。

用法：python extract_dangling_body.py <rpy_rel_path> <start> <end>
"""
import os
import sys
import io
import re
from collections import defaultdict

sys.stdout = io.TextIOWrapper(sys.stdout.buffer, encoding='utf-8')

RPY_ROOT = r'h:/Programming/ProjDragon/dragon_cc_win/dragon_yuanban'
DLG = r'h:/Programming/ProjDragon/dragon_cc_win/dragon_unity/Dragon/Assets/RenpyResources/middle_data/dialogues.txt'

EXCLUDE = {'show', 'scene', 'play', 'stop', 'hide', 'with', 'camera', 'if',
           'elif', 'else', 'jump', 'menu', 'call', 'label', 'python',
           'voice', '$', 'return', 'define', 'image', 'pause', 'window',
           'parallel', 'linear', 'easein', 'alpha', 'pos', 'anchor', 'zoom',
           'xpos', 'ypos', 'zpos', 'xoffset', 'yoffset', 'blur', 'rotate',
           'perspective', 'gl_depth', 'ease', 'time', 'subpixel'}


def load_dlg_index():
    """构建 (text, rpy_basename) → first ID（0-based）查找表。"""
    index = {}  # (text, rpy_name) → id
    with open(DLG, 'r', encoding='utf-8') as f:
        for i, line in enumerate(f):
            line = line.rstrip('\r\n')
            idx = line.rfind(', ..')
            if idx < 0:
                continue
            text = line[:idx]
            path = line[idx + 2:]
            rpy_name = path.rsplit('/', 1)[-1] if '/' in path else path
            key = (text, rpy_name)
            if key not in index:
                index[key] = i
    return index


def extract(rpy_rel, start, end):
    rpy_path = os.path.join(RPY_ROOT, rpy_rel.replace('/', os.sep))
    with open(rpy_path, 'r', encoding='utf-8') as f:
        lines = f.readlines()

    dlg_index = load_dlg_index()
    rpy_name = os.path.basename(rpy_rel)

    for i in range(start, end + 1):
        if i > len(lines):
            break
        ln = lines[i - 1].rstrip('\r\n')
        stripped = ln.lstrip()
        if not stripped:
            print(f"L{i:4} BLANK")
            continue
        if stripped.startswith('#'):
            print(f"L{i:4} COMMENT        | {ln}")
            continue

        first = stripped.split()[0].rstrip(':')
        dlg_id = None
        if first not in EXCLUDE and '"' in stripped:
            m = re.match(r'^.*?"([^"]*)"\s*$', stripped)
            if m:
                text = m.group(1)
                key = (text, rpy_name)
                if key in dlg_index:
                    dlg_id = dlg_index[key]

        marker = f"[dlg={dlg_id}]" if dlg_id is not None else ""
        print(f"L{i:4} {first:12} {marker:12} | {ln}")


if __name__ == '__main__':
    rpy_rel = sys.argv[1]
    start = int(sys.argv[2])
    end = int(sys.argv[3])
    extract(rpy_rel, start, end)
