"""将 voice_mapping_parsed.json 中的条目匹配到 GameScript cs 文件的 OpenDialog 行。

策略：
1. 对每个 rpy 文件，获取 txt 中 **所有** dialog 条目（包括无 voice 的），按顺序排列（rpy_line 升序）。
2. 读取对应的 cs 文件，逐行提取 `OpenDialog(id); // "text"` 模式，得到有序列表。
3. 按"贪心前向匹配"将 txt 条目对应到 cs 行：按顺序走，通过文本规范化比较。
4. 对于 has_voice=True 的 txt 条目，记录其对应的 cs 行号 → 输出 insertion plan。

输出: voice_insertion_plan.json
"""
import os
import sys
import io
import json
import re
from collections import defaultdict

sys.stdout = io.TextIOWrapper(sys.stdout.buffer, encoding='utf-8')

PARSED = r'h:/Programming/ProjDragon/dragon_cc_win/voice_mapping_parsed.json'
GS_ROOT = r'h:/Programming/ProjDragon/dragon_cc_win/dragon_unity/Dragon/Assets/Script/GameScript'
OUT = r'h:/Programming/ProjDragon/dragon_cc_win/voice_insertion_plan.json'

RPY_TO_CS = {
    'game/rpy/zhuxian/end/end3.rpy':   'game/rpy/zhuxian/end/end3.cs',
    'game/rpy/zhuxian/end/end5.rpy':   'game/rpy/zhuxian/end/end5.cs',
    'game/rpy/zhuxian/end/end6.rpy':   'game/rpy/zhuxian/end/end6.cs',
    'game/rpy/zhuxian/zhuxian0.rpy':   'game/rpy/zhuxian/zhuxian0.cs',
    'game/rpy/zhuxian/zhuxian4.rpy':   'game/rpy/zhuxian/zhuxian4.cs',
    'game/rpy/zhuxian/zhuxian_1.rpy':  'game/rpy/zhuxian/zhuxian_1.cs',
    'game/rpy/zhuxian/zhuxian_2.rpy':  'game/rpy/zhuxian/zhuxian_2.cs',
    'game/rpy/zhuxian/zhuxian_3.rpy':  'game/rpy/zhuxian/zhuxian_3.cs',
    'game/rpy/zhuxian/wangzi.rpy':     'game/rpy/zhuxian/wangzi.cs',
}

# 匹配 cs 里 OpenDialog(id); // "..." 的正则
OPEN_DIALOG_RE = re.compile(
    r'_gameMethods\.OpenDialog\s*\(\s*(\d+)\s*\)\s*;\s*//\s*"(.*)"\s*$'
)


def normalize_text(s: str) -> str:
    """规范化对比文本：去掉常见的 rpy 标签和空白差异。"""
    if s is None:
        return ''
    s = s.strip()
    # 去掉 {nw} {w=...} {size=...}{/size} 等标签
    s = re.sub(r'\{[^}]*\}', '', s)
    # 去掉 \n 换行转义
    s = s.replace('\\n', '').replace('\n', '').replace('\r', '')
    s = s.strip()
    return s


def load_cs_dialogs(cs_path):
    """返回 [{line_num, dialog_id, raw_text, norm_text}, ...]"""
    with open(cs_path, 'r', encoding='utf-8') as f:
        lines = f.readlines()
    result = []
    for i, ln in enumerate(lines, 1):
        m = OPEN_DIALOG_RE.search(ln)
        if m:
            dialog_id = int(m.group(1))
            raw = m.group(2)
            # 转义还原
            raw = raw.replace('\\"', '"')
            result.append({
                'line_num': i,
                'dialog_id': dialog_id,
                'raw_text': raw,
                'norm_text': normalize_text(raw),
            })
    return result, lines


def match_sequence(txt_entries, cs_dialogs):
    """基于文本的匹配 + 出现次序消歧。

    对每个 cs_dialog 的 norm_text，收集其在 cs 里所有位置；
    然后对 txt 条目按顺序遍历，每个文本到 cs 对应 bucket 的下一个未用位置。
    """
    # 建立 cs norm_text → [indices...] 的 bucket
    bucket = defaultdict(list)
    for i, d in enumerate(cs_dialogs):
        bucket[d['norm_text']].append(i)
    used = set()
    result = []
    for e in txt_entries:
        tnorm = normalize_text(e['text'])
        candidates = bucket.get(tnorm, [])
        pick = None
        for idx in candidates:
            if idx not in used:
                pick = idx
                break
        if pick is not None:
            used.add(pick)
            result.append((e, cs_dialogs[pick]))
        else:
            result.append((e, None))
    return result


def main():
    with open(PARSED, 'r', encoding='utf-8') as f:
        data = json.load(f)

    # 按 rpy_file 分组，仅处理我们有 cs 的
    by_rpy = defaultdict(list)
    for e in data:
        if e['rpy_file'] in RPY_TO_CS:
            by_rpy[e['rpy_file']].append(e)

    # 每组按 rpy_line 排序（None 放末尾）
    for k in by_rpy:
        by_rpy[k].sort(key=lambda x: x.get('rpy_line') or 1_000_000)

    insertion_plan = []  # 每条: {cs_file, cs_line, voice_identifier, indent, dialog_text}
    stats_per_file = {}

    for rpy, entries in sorted(by_rpy.items()):
        cs_rel = RPY_TO_CS[rpy]
        cs_abs = os.path.join(GS_ROOT, cs_rel.replace('/', os.sep))
        if not os.path.exists(cs_abs):
            print(f"[跳过] cs 不存在: {cs_rel}")
            continue

        cs_dialogs, _ = load_cs_dialogs(cs_abs)
        matches = match_sequence(entries, cs_dialogs)

        matched = sum(1 for _, cs in matches if cs is not None)
        voiced = sum(1 for e, _ in matches if e['has_voice'])
        voiced_matched = sum(1 for e, cs in matches if e['has_voice'] and cs is not None)

        stats_per_file[rpy] = {
            'total_txt': len(entries),
            'total_cs_dialogs': len(cs_dialogs),
            'matched': matched,
            'voiced': voiced,
            'voiced_matched': voiced_matched,
        }

        print(f"\n{rpy}")
        print(f"  txt 总数: {len(entries)}, cs OpenDialog 总数: {len(cs_dialogs)}")
        print(f"  成功匹配: {matched}/{len(entries)}")
        print(f"  有 voice: {voiced}, 有 voice 且匹配: {voiced_matched}")

        for e, cs in matches:
            if e['has_voice'] and cs is not None:
                insertion_plan.append({
                    'cs_file': cs_rel,
                    'cs_abs_path': cs_abs,
                    'cs_line': cs['line_num'],
                    'dialog_id': cs['dialog_id'],
                    'voice_identifier': e['identifier'],
                    'dialog_text': cs['raw_text'][:50],
                })

    print(f"\n=== 总计可插入: {len(insertion_plan)} 条 PlayVoice ===")
    with open(OUT, 'w', encoding='utf-8') as f:
        json.dump({'plan': insertion_plan, 'stats': stats_per_file}, f, ensure_ascii=False, indent=1)
    print(f"已保存到 {OUT}")


if __name__ == '__main__':
    main()
