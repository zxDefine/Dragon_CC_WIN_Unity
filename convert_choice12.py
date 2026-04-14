"""协助工具：提取 zhuxian_2.rpy label choice12 的对白并查找在 dialogues.txt 中的 ID。

生成 choice12 的对白 ID 映射表，便于手动转换。
"""
import os
import sys
import io
import re

sys.stdout = io.TextIOWrapper(sys.stdout.buffer, encoding='utf-8')

RPY = r'h:/Programming/ProjDragon/dragon_cc_win/dragon_yuanban/game/rpy/zhuxian/zhuxian_2.rpy'
DLG = r'h:/Programming/ProjDragon/dragon_cc_win/dragon_unity/Dragon/Assets/RenpyResources/middle_data/dialogues.txt'

# 读取 rpy, 提取 label choice12 body
with open(RPY, 'r', encoding='utf-8') as f:
    lines = f.readlines()

start_l = None
end_l = None
for i, ln in enumerate(lines, 1):
    if ln.strip() == 'label choice12:':
        start_l = i
    elif start_l and ln and not ln[0].isspace() and ln.strip() and not ln.startswith('#'):
        end_l = i - 1
        break
if start_l and not end_l:
    end_l = len(lines)

body = lines[start_l:end_l]
print(f"label choice12 body: rpy L{start_l+1}-L{end_l} ({len(body)} lines)")

# 提取对白
# 对白行识别: 开头不是关键字（show/scene/play/hide/with/camera/if/$/menu/label/jump/call/python/voice/stop/define）
# 且包含 "..."
EXCLUDE_PREFIX = ('show', 'scene', 'play', 'hide', 'with', 'camera:', 'if', '$', 'menu', 'label',
                  'jump', 'call', 'python', 'voice', 'stop', 'define', '#', 'return', 'pause',
                  'window', 'parallel', 'linear', 'easein', 'alpha', 'pos', 'anchor', 'zoom',
                  'xpos', 'ypos', 'zpos', 'xoffset', 'yoffset', 'blur', 'rotate', 'perspective',
                  'gl_depth', 'ease', 'time', 'subpixel')

dialogs = []  # (rpy_line, character, text, full_line)
for i, ln in enumerate(body, start_l + 1):
    s = ln.strip()
    if not s or s.startswith('#'):
        continue
    first = s.split()[0]
    if first.rstrip(':') in EXCLUDE_PREFIX:
        continue
    if '"' not in s:
        continue
    # 形式: [character] [attrs...] "text"
    m = re.match(r'^([\w_]+\s)?(.*?)"(.+)"\s*$', s)
    if m:
        char_pre = m.group(1) or ''
        middle = m.group(2)
        text = m.group(3)
        character = char_pre.strip() if char_pre else ''
        # 排除那些里面的 "" 不是对白的
        if text:
            dialogs.append((i, character, middle.strip(), text, s))

print(f"\n提取的对白数: {len(dialogs)}")

# 读取 dialogues.txt 并按文本映射到 ID
with open(DLG, 'r', encoding='utf-8') as f:
    dlg_lines = [ln.rstrip() for ln in f]

# 建立 text -> [line indices] 查找桶 (只限 zhuxian_2.rpy 条目)
from collections import defaultdict
text_to_ids = defaultdict(list)
for i, dl in enumerate(dlg_lines):
    # 格式: text, ../.../zhuxian_2.rpy
    if 'zhuxian_2.rpy' not in dl:
        continue
    # 切分：text, path
    idx = dl.rfind(', ..')
    if idx < 0:
        continue
    text_part = dl[:idx]
    text_to_ids[text_part].append(i)  # 0-based id

# 按顺序匹配对白到 dialogues.txt 的 ID (允许重复使用同一 id，与现有 cs 风格一致)
mappings = []  # (rpy_line, text, id_0based)
for rpy_line, character, attrs, text, full in dialogs:
    candidates = text_to_ids.get(text, [])
    picked = candidates[0] if candidates else None
    mappings.append((rpy_line, character, attrs, text, picked))

matched = sum(1 for m in mappings if m[4] is not None)
print(f"dialogues.txt 命中: {matched}/{len(mappings)}")

# 输出到 JSON + 人可读格式
import json
out = {
    'label': 'choice12',
    'rpy_file': 'game/rpy/zhuxian/zhuxian_2.rpy',
    'rpy_start': start_l + 1,
    'rpy_end': end_l,
    'body_lines': len(body),
    'dialogs': [
        {
            'rpy_line': rl,
            'character': c,
            'attrs': a,
            'text': t,
            'dialog_id': did,
        }
        for rl, c, a, t, did in mappings
    ],
}
with open(r'h:/Programming/ProjDragon/dragon_cc_win/choice12_mapping.json', 'w', encoding='utf-8') as f:
    json.dump(out, f, ensure_ascii=False, indent=1)

print(f"\n前 10 条映射:")
for rl, c, a, t, did in mappings[:10]:
    print(f"  rpy L{rl} [{c}] {a} id={did}: {t[:50]}")

print(f"\n未命中条目 ({len(mappings) - matched}):")
for rl, c, a, t, did in mappings:
    if did is None:
        print(f"  rpy L{rl}: {t[:60]}")
