"""根据 voice_insertion_plan.json 在 cs 文件中插入 PlayVoice 调用。

在每个目标 OpenDialog 行之前插入一行：
    <indent>yield return _gameMethods.PlayVoice(voicePath:"Assets/RenpyResources/audio/voice/<identifier>.ogg");

注意：
- 按文件分组，每个文件按 cs_line 降序插入（避免行号偏移）
- 同一行只插入一次（幂等）
- 跳过已经有 PlayVoice 的 OpenDialog 前导
"""
import os
import sys
import io
import json
import re
from collections import defaultdict

sys.stdout = io.TextIOWrapper(sys.stdout.buffer, encoding='utf-8')

PLAN = r'h:/Programming/ProjDragon/dragon_cc_win/voice_insertion_plan.json'

VOICE_PATH_TEMPLATE = 'Assets/RenpyResources/audio/voice/{id}.ogg'
INSERT_LINE_TEMPLATE = '{indent}yield return _gameMethods.PlayVoice(voicePath:"{path}");\n'


def get_indent(line: str) -> str:
    m = re.match(r'^(\s*)', line)
    return m.group(1) if m else ''


def main():
    with open(PLAN, 'r', encoding='utf-8') as f:
        plan_obj = json.load(f)
    plan = plan_obj['plan']

    by_file = defaultdict(list)
    for item in plan:
        by_file[item['cs_abs_path']].append(item)

    total_inserted = 0
    total_skipped = 0

    for cs_path, items in by_file.items():
        # 按 cs_line 降序，避免行号偏移
        items.sort(key=lambda x: -x['cs_line'])

        with open(cs_path, 'r', encoding='utf-8') as f:
            lines = f.readlines()

        inserted_here = 0
        skipped_here = 0

        for item in items:
            ln_idx = item['cs_line'] - 1  # 0-based
            if ln_idx < 0 or ln_idx >= len(lines):
                skipped_here += 1
                continue
            target = lines[ln_idx]
            if 'OpenDialog' not in target:
                skipped_here += 1
                continue
            # 如果上一行已经是该 voice 的 PlayVoice，跳过（幂等）
            voice_path = VOICE_PATH_TEMPLATE.format(id=item['voice_identifier'])
            if ln_idx > 0 and voice_path in lines[ln_idx - 1]:
                skipped_here += 1
                continue

            indent = get_indent(target)
            new_line = INSERT_LINE_TEMPLATE.format(indent=indent, path=voice_path)
            lines.insert(ln_idx, new_line)
            inserted_here += 1

        with open(cs_path, 'w', encoding='utf-8', newline='') as f:
            f.writelines(lines)

        total_inserted += inserted_here
        total_skipped += skipped_here
        print(f"{os.path.basename(cs_path)}: 插入 {inserted_here}, 跳过 {skipped_here}")

    print(f"\n=== 总计插入 {total_inserted} 条, 跳过 {total_skipped} 条 ===")


if __name__ == '__main__':
    main()
