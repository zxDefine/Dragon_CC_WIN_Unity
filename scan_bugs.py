import os, re

base = r'h:/Programming/ProjDragon/dragon_cc_win/dragon_unity/Dragon/Assets/Script/GameScript'

# ATL 关键字（不应作为图像名或角色部件名）
atl_keywords = {
    'linear', 'ease', 'easein', 'easeout', 'easein_cubic', 'easeout_cubic',
    'easein_quad', 'easeout_quad', 'easein_quart', 'easeout_quart',
    'easein_quint', 'easeout_quint', 'easein_circ', 'easeout_circ',
    'easein_back', 'easeout_back', 'easein_bounce', 'easeout_bounce',
    'easein_elastic', 'easeout_elastic',
    'pause', 'repeat', 'cycle', 'block', 'parallel', 'time', 'hold',
    'xpos', 'ypos', 'zpos', 'pos', 'xoffset', 'yoffset', 'offset',
    'xanchor', 'yanchor', 'anchor',
    'xalign', 'yalign', 'align',
    'xzoom', 'yzoom', 'zoom',
    'alpha', 'additive', 'rotate', 'rotate_pad',
    'crop', 'size', 'subpixel', 'blur', 'matrixcolor', 'matrixtransform',
    'perspective', 'gl_depth', 'drawScreen',
    'fadein', 'fadeout', 'volume', 'onLayer',
    'dissolveType', 'dissolveTime',
}

issues = {
    'scene_bad_name': [],
    'show_bad_name': [],
    'parts_has_atl': [],
    'empty_dict_in_list': [],
    'scene_numeric_name': [],
}

def is_numeric_name(s):
    s = s.strip()
    try:
        float(s)
        return True
    except ValueError:
        return False

def extract_string_arg(line, method_name):
    pattern = r'_gameMethods\.' + method_name + r'\("([^"]*)"'
    m = re.search(pattern, line)
    return m.group(1) if m else None

def extract_parts(line):
    m = re.search(r'parts:\s*new List<string>\{([^}]*)\}', line)
    if not m:
        return None
    parts_str = m.group(1)
    parts = re.findall(r'"([^"]*)"', parts_str)
    return parts

for root, dirs, files in os.walk(base):
    for fn in files:
        if not fn.endswith('.cs'):
            continue
        fp = os.path.join(root, fn)
        with open(fp, 'rb') as f:
            content = f.read().decode('utf-8')
        lines = content.split('\n')
        rel = os.path.relpath(fp, base).replace(os.sep, '/')

        for i, line in enumerate(lines, 1):
            scene_name = extract_string_arg(line, 'Scene')
            if scene_name is not None:
                if is_numeric_name(scene_name):
                    issues['scene_numeric_name'].append('{}:{} Scene("{}")'.format(rel, i, scene_name))
                elif scene_name.lower() in atl_keywords:
                    issues['scene_bad_name'].append('{}:{} Scene("{}")'.format(rel, i, scene_name))

            show_name = extract_string_arg(line, 'Show')
            if show_name is not None:
                if show_name.lower() in atl_keywords:
                    issues['show_bad_name'].append('{}:{} Show("{}")'.format(rel, i, show_name))
                elif is_numeric_name(show_name):
                    issues['scene_numeric_name'].append('{}:{} Show("{}") [numeric]'.format(rel, i, show_name))

            parts = extract_parts(line)
            if parts:
                suspicious = []
                for p in parts:
                    if is_numeric_name(p) or p.lower() in atl_keywords:
                        suspicious.append(p)
                if suspicious:
                    issues['parts_has_atl'].append('{}:{} parts={} suspicious={}'.format(rel, i, parts, suspicious))

            if 'new Dictionary<string, object>()' in line:
                if 'sameLine:' in line or 'parallel_' in line:
                    issues['empty_dict_in_list'].append('{}:{}'.format(rel, i))

print('=' * 80)
print('Global Audit Results')
print('=' * 80)
for category, items in issues.items():
    print('\n[{}] total {} occurrences:'.format(category, len(items)))
    for item in items[:100]:
        print('  ' + item)
    if len(items) > 100:
        print('  ... {} more not shown'.format(len(items) - 100))

total = sum(len(v) for v in issues.values())
print('\n===== TOTAL: {} suspicious =====' .format(total))
