"""移除所有 cs 文件中已插入的 PlayVoice 行（以 voicePath: 为标识）。"""
import os, sys, io, re
sys.stdout = io.TextIOWrapper(sys.stdout.buffer, encoding='utf-8')

GS_ROOT = r'h:/Programming/ProjDragon/dragon_cc_win/dragon_unity/Dragon/Assets/Script/GameScript'

pattern = re.compile(r'^\s*yield return _gameMethods\.PlayVoice\(voicePath:"Assets/RenpyResources/audio/voice/[^"]+\.ogg"\);\s*$')

total = 0
for root, dirs, files in os.walk(GS_ROOT):
    for fn in files:
        if not fn.endswith('.cs'):
            continue
        p = os.path.join(root, fn)
        with open(p, 'r', encoding='utf-8') as f:
            lines = f.readlines()
        new_lines = [ln for ln in lines if not pattern.match(ln.rstrip('\r\n'))]
        removed = len(lines) - len(new_lines)
        if removed:
            with open(p, 'w', encoding='utf-8', newline='') as f:
                f.writelines(new_lines)
            print(f"{fn}: 移除 {removed} 条 PlayVoice")
            total += removed
print(f"\n总计移除 {total} 条")
