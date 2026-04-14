"""提取 end6.rpy L2517-2931 （label end7_1 menu "-自己戴上冠冕" 分支）的活动代码+对白 ID 映射。

目的：辅助手动转译为 label_end6_menu_0_IdEQSfpx 方法。
"""
import os
import sys
import io
import re
import json
from collections import defaultdict

sys.stdout = io.TextIOWrapper(sys.stdout.buffer, encoding='utf-8')

RPY = r'h:/Programming/ProjDragon/dragon_cc_win/dragon_yuanban/game/rpy/zhuxian/end/end6.rpy'
DLG = r'h:/Programming/ProjDragon/dragon_cc_win/dragon_unity/Dragon/Assets/RenpyResources/middle_data/dialogues.txt'
OUT = r'h:/Programming/ProjDragon/dragon_cc_win/end6_IdEQSfpx_extracted.txt'

START_LINE = 2517  # "-自己戴上冠冕": (the option's body starts at the line after)
END_LINE = 2931  # end of file

with open(RPY, 'r', encoding='utf-8') as f:
    rpy_lines = f.readlines()

with open(DLG, 'r', encoding='utf-8') as f:
    dlg_lines = [ln.rstrip() for ln in f]

# Build text → [ids] for end6.rpy lines
text_to_ids = defaultdict(list)
for i, dl in enumerate(dlg_lines):
    if 'end6.rpy' not in dl:
        continue
    idx = dl.rfind(', ..')
    if idx < 0:
        continue
    text_part = dl[:idx]
    text_to_ids[text_part].append(i)  # 0-based id

# Walk rpy L2518-L2931 (body of the -自己戴上冠冕 option starts AFTER L2517 where the option label is)
# Skip comments (# ...)
out = []
for i in range(START_LINE, END_LINE + 1):  # inclusive
    if i > len(rpy_lines):
        break
    ln = rpy_lines[i - 1].rstrip('\r\n')
    # Skip blank / pure-comment lines
    stripped = ln.lstrip()
    if not stripped:
        out.append((i, '', ln, None))
        continue
    if stripped.startswith('#'):
        out.append((i, 'COMMENT', ln, None))
        continue
    # Detect dialog line
    # Exclude lines that start with ATL / control keywords
    EXCLUDE = ('show', 'scene', 'play', 'stop', 'hide', 'with', 'camera', 'if',
               'elif', 'else', 'jump', 'menu', 'call', 'label', 'python',
               'voice', '$', '#', 'return', 'define', 'image', 'pause', 'window',
               'parallel', 'linear', 'easein', 'alpha', 'pos', 'anchor', 'zoom',
               'xpos', 'ypos', 'zpos', 'xoffset', 'yoffset', 'blur', 'rotate',
               'perspective', 'gl_depth', 'ease', 'time', 'subpixel')
    dialog_text = None
    first = stripped.split()[0] if stripped.split() else ''
    if first.rstrip(':') not in EXCLUDE and '"' in stripped:
        # Extract LAST quoted string which is the dialog
        # Form: [character [attrs...]] "text"
        m = re.match(r'^.*?"([^"]*)"\s*$', stripped)
        if m:
            dialog_text = m.group(1)
    dialog_id = None
    if dialog_text is not None:
        cands = text_to_ids.get(dialog_text, [])
        if cands:
            dialog_id = cands[0]  # allow reuse
    out.append((i, 'LINE', ln, dialog_id))

# Output a readable trace
with open(OUT, 'w', encoding='utf-8', newline='\n') as f:
    for i, kind, ln, did in out:
        marker = f"[dlg={did}]" if did is not None else ""
        f.write(f"L{i:4} {kind:8} {marker:12} | {ln}\n")

print(f"已输出到 {OUT}")
print(f"总行数: {len(out)}")
print(f"对白行（含 id）: {sum(1 for _, _, _, d in out if d is not None)}")
print(f"注释行: {sum(1 for _, k, _, _ in out if k == 'COMMENT')}")
