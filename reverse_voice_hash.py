import hashlib, os, re

voice_dir = r'h:/Programming/ProjDragon/dragon_cc_win/dragon_unity/Dragon/Assets/RenpyResources/audio/voice'
rpy_path = r'h:/Programming/ProjDragon/dragon_cc_win/dragon_yuanban/game/rpy/zhuxian/zhuxian0.rpy'

# Get all voice file hashes for zhuxian0
voice_hashes = set()
for f in os.listdir(voice_dir):
    if f.startswith('zhuxian0_') and f.endswith('.ogg'):
        h = f.replace('zhuxian0_', '').replace('.ogg', '')
        voice_hashes.add(h)
print(f"Voice hashes to match: {sorted(voice_hashes)}")

# Parse rpy to get say statements with context
with open(rpy_path, 'r', encoding='utf-8') as f:
    lines = f.readlines()

# Extract say statements: line_num, who, what
says = []
for i, line in enumerate(lines, 1):
    stripped = line.strip()
    # Pattern: "text" or character "text" or character attr1 attr2 "text"
    m = re.match(r'^(?:(\w+)\s+(?:[\w\s-]*\s+)?)?\"(.+)\"$', stripped)
    if m:
        who = m.group(1) or ''
        what = m.group(2)
        # Skip non-dialog lines
        if any(stripped.startswith(x) for x in ['$', 'play ', 'stop ', 'voice ', 'show ', 'scene ', 'hide ', 'with ', 'camera', 'define ', 'default ', '#']):
            continue
        if 'audio/' in what or 'images/' in what:
            continue
        says.append((i, who, what))

print(f"\nTotal say statements in zhuxian0: {len(says)}")

# Try various hash methods
def try_hash(label, serial, who, what, says_idx):
    results = []

    # Method 1: md5(what)[:8]
    h = hashlib.md5(what.encode('utf-8')).hexdigest()[:8]
    results.append(('md5(what)', h))

    # Method 2: md5(who + what)[:8]
    h = hashlib.md5((who + what).encode('utf-8')).hexdigest()[:8]
    results.append(('md5(who+what)', h))

    # Method 3: md5(who + " " + what)[:8]
    h = hashlib.md5((who + " " + what).encode('utf-8')).hexdigest()[:8]
    results.append(('md5(who+" "+what)', h))

    # Method 4: Renpy style - md5 of say tuple representation
    for sep in ['', '\0', '\n', ' ']:
        h = hashlib.md5(f"{label}{sep}{serial}".encode('utf-8')).hexdigest()[:8]
        results.append((f'md5(label+"{repr(sep)}"+serial={serial})', h))

    # Method 5: md5 of "label line_number"
    h = hashlib.md5(f"{label} {says_idx}".encode('utf-8')).hexdigest()[:8]
    results.append((f'md5("{label} {says_idx}")', h))

    # Method 6: md5 of who\0what
    h = hashlib.md5(f"{who}\x00{what}".encode('utf-8')).hexdigest()[:8]
    results.append(('md5(who+\\0+what)', h))

    # Method 7: Renpy typical - md5(f"{who} {what}" or just what with line number)
    for prefix in [f"{label}_{serial}_", f"{serial}_", f""]:
        h = hashlib.md5(f"{prefix}{what}".encode('utf-8')).hexdigest()[:8]
        results.append((f'md5("{prefix}"+what)', h))

    return results

label = 'zhuxian0'
serial = 0
matches = []
for idx, (line_num, who, what) in enumerate(says):
    for method, h in try_hash(label, serial, who, what, idx):
        if h in voice_hashes:
            matches.append((line_num, who, what[:30], method, h))
    serial += 1

if matches:
    print(f"\n=== MATCHES FOUND: {len(matches)} ===")
    for line_num, who, what, method, h in matches:
        print(f"  rpy:{line_num} [{who}] \"{what}\" -> {method} = {h}")
else:
    print("\nNo matches found with any method.")
    # Print first 10 say hashes for debugging
    print("\nFirst 10 say statement hashes (md5(what)[:8]):")
    for i, (ln, who, what) in enumerate(says[:10]):
        h = hashlib.md5(what.encode('utf-8')).hexdigest()[:8]
        print(f"  rpy:{ln} [{who}] \"{what[:30]}\" -> {h}")
