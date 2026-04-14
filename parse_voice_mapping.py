"""解析 voice_mapping/*.txt，生成 identifier→(rpy_file, text) 的结构化数据。

每行格式（多空格分隔）：
    Identifier  [Character]  Dialogue  Filename(rpy_path)  LineNum  RpyScript
Character 可能省略。
"""
import os
import sys
import io
import json
import re
from collections import Counter

sys.stdout = io.TextIOWrapper(sys.stdout.buffer, encoding='utf-8')

VOICE_DIR = r'h:/Programming/ProjDragon/dragon_cc_win/dragon_unity/Dragon/Assets/RenpyResources/audio/voice'
MAPPING_DIR = r'h:/Programming/ProjDragon/dragon_cc_win/voice_mapping'
OUT_JSON = r'h:/Programming/ProjDragon/dragon_cc_win/voice_mapping_parsed.json'

voice_files = set()
for f in os.listdir(VOICE_DIR):
    if f.endswith('.ogg'):
        voice_files.add(f[:-4])
print(f"voice 目录下存在 {len(voice_files)} 个 ogg 文件")

entries = []
skipped = 0

for fname in sorted(os.listdir(MAPPING_DIR)):
    if not fname.endswith('.txt'):
        continue
    path = os.path.join(MAPPING_DIR, fname)
    with open(path, 'r', encoding='utf-8') as fh:
        lines = fh.readlines()

    file_count = 0
    for line in lines:
        line = line.rstrip('\r\n')
        if not line.strip():
            continue
        if line.startswith('Identifier'):
            continue

        parts = re.split(r' {2,}', line)
        # 找到含 'game/rpy' 的列索引
        rpy_idx = None
        for i, p in enumerate(parts):
            if '.rpy' in p and ('game/rpy' in p or 'rpy/' in p):
                rpy_idx = i
                break
        if rpy_idx is None:
            skipped += 1
            continue

        identifier = parts[0].strip()
        raw_rpy_field = parts[rpy_idx].strip()
        # 该字段可能混入 "rpy_file <line_num> [extra]"，拆出
        m = re.match(r'^(\S+?\.rpy)(?:\s+(\d+))?(?:\s+.*)?$', raw_rpy_field)
        if m:
            rpy_file = m.group(1)
            rpy_line = int(m.group(2)) if m.group(2) else None
        else:
            rpy_file = raw_rpy_field
            rpy_line = None
        if rpy_line is None and rpy_idx + 1 < len(parts):
            try:
                rpy_line = int(parts[rpy_idx + 1].strip())
            except ValueError:
                pass

        # dialogue / character
        if rpy_idx == 2:
            # no character
            character = ''
            dialogue = parts[1].strip()
        elif rpy_idx == 3:
            character = parts[1].strip()
            dialogue = parts[2].strip()
        elif rpy_idx > 3:
            # 不寻常，取 parts[1..rpy_idx] 的第一个有意义部分
            character = parts[1].strip() if rpy_idx > 2 else ''
            dialogue = parts[rpy_idx - 1].strip()
        else:
            skipped += 1
            continue

        if not identifier:
            continue

        has_voice = identifier in voice_files

        entries.append({
            'identifier': identifier,
            'character': character,
            'text': dialogue,
            'rpy_file': rpy_file,
            'rpy_line': rpy_line,
            'has_voice': has_voice,
            'src_txt': fname,
        })
        file_count += 1

    print(f"{fname}: {file_count} 条")

print(f"\n总计 {len(entries)} 条，跳过 {skipped} 条")
with_voice = [e for e in entries if e['has_voice']]
print(f"其中存在 voice 文件的: {len(with_voice)}")

by_rpy = Counter(e['rpy_file'] for e in with_voice)
print("\n按 rpy 文件分组 (有 voice):")
for rpy, cnt in sorted(by_rpy.items()):
    print(f"  {rpy}: {cnt}")

with open(OUT_JSON, 'w', encoding='utf-8') as fh:
    json.dump(entries, fh, ensure_ascii=False, indent=1)
print(f"\n已保存到 {OUT_JSON}")
