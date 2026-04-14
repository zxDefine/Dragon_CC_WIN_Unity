#!/usr/bin/env python
# -*- coding: utf-8 -*-
"""
Smart converter bug fixer for Renpy -> C# conversion errors.

Strategy: Parallel walk between cs and rpy files using dialog text as anchors.
- For each cs call (Show/Scene/Hide/SetCamera/OpenDialog), match the corresponding
  rpy event by order, using dialog text equality as strong anchors.
- When a buggy cs call is encountered, use the currently matched rpy event as the source.
- Rewrite the cs call using the rpy data.
"""
import os, re, sys
from pathlib import Path

BASE = Path(r'h:/Programming/ProjDragon/dragon_cc_win')
CS_ROOT = BASE / 'dragon_unity/Dragon/Assets/Script/GameScript/game/rpy'
RPY_ROOT = BASE / 'dragon_yuanban/game/rpy'

ATL_KEYWORDS = {
    'linear', 'ease', 'easein', 'easeout',
    'easein_cubic', 'easeout_cubic', 'easein_quad', 'easeout_quad',
    'easein_quart', 'easeout_quart', 'easein_quint', 'easeout_quint',
    'easein_circ', 'easeout_circ', 'easein_back', 'easeout_back',
    'easein_bounce', 'easeout_bounce', 'easein_elastic', 'easeout_elastic',
    'ease_quad', 'ease_cubic', 'ease_quart', 'ease_quint',
    'ease_circ', 'ease_back', 'ease_bounce', 'ease_elastic',
    'pause', 'repeat', 'cycle', 'block', 'parallel', 'time', 'hold',
    'xpos', 'ypos', 'zpos', 'pos', 'xoffset', 'yoffset', 'offset',
    'xanchor', 'yanchor', 'anchor', 'xalign', 'yalign', 'align',
    'xzoom', 'yzoom', 'zoom', 'alpha', 'additive', 'rotate', 'rotate_pad',
    'xrotate', 'yrotate', 'zrotate',
    'crop', 'size', 'subpixel', 'blur',
    'matrixcolor', 'matrixtransform', 'matrixanchor',
}

FILE_PAIRS = {
    'zhuxian/zhuxian0.cs': 'zhuxian/zhuxian0.rpy',
    'zhuxian/zhuxian_1.cs': 'zhuxian/zhuxian_1.rpy',
    'zhuxian/zhuxian_2.cs': 'zhuxian/zhuxian_2.rpy',
    'zhuxian/zhuxian_3.cs': 'zhuxian/zhuxian_3.rpy',
    'zhuxian/zhuxian4.cs': 'zhuxian/zhuxian4.rpy',
    'zhuxian/wangzi.cs': 'zhuxian/wangzi.rpy',
    'zhuxian/end/end3.cs': 'zhuxian/end/end3.rpy',
    'zhuxian/end/end5.cs': 'zhuxian/end/end5.rpy',
    'zhuxian/end/end6.cs': 'zhuxian/end/end6.rpy',
    'zhuxian/zhuxian0_menu.cs': 'zhuxian/zhuxian0.rpy',
    'zhuxian/zhuxian_1_menu.cs': 'zhuxian/zhuxian_1.rpy',
    'zhuxian/zhuxian_2_menu.cs': 'zhuxian/zhuxian_2.rpy',
    'zhuxian/zhuxian_3_menu.cs': 'zhuxian/zhuxian_3.rpy',
    'zhuxian/zhuxian4_menu.cs': 'zhuxian/zhuxian4.rpy',
    'zhuxian/wangzi_menu.cs': 'zhuxian/wangzi.rpy',
    'zhuxian/end/end3_menu.cs': 'zhuxian/end/end3.rpy',
    'zhuxian/end/end5_menu.cs': 'zhuxian/end/end5.rpy',
    'zhuxian/end/end6_menu.cs': 'zhuxian/end/end6.rpy',
}


# ------------ RPY Parser ------------

def parse_rpy(rpy_path):
    """Parse rpy and return list of events with line numbers and types."""
    with open(rpy_path, 'r', encoding='utf-8') as f:
        raw_lines = f.readlines()

    events = []
    i = 0
    n = len(raw_lines)

    def get_indent(s):
        return len(s) - len(s.rstrip('\n').lstrip())

    def read_atl_block(start_idx, base_indent):
        body = []
        j = start_idx
        while j < n:
            line = raw_lines[j]
            # Strip newline but keep leading whitespace for indent calc
            stripped = line.strip()
            if not stripped or stripped.startswith('#'):
                j += 1
                continue
            ind = get_indent(line)
            if ind <= base_indent:
                break
            body.append((ind, stripped, j + 1))
            j += 1
        return body, j

    while i < n:
        line = raw_lines[i]
        stripped = line.strip()
        if not stripped or stripped.startswith('#'):
            i += 1
            continue

        indent = get_indent(line)
        line_num = i + 1

        # show X [parts...] [with Transition][:]
        # parts can be -prefixed (negative emoji modifier in Renpy)
        m = re.match(r'^show\s+([\w_]+)((?:\s+-?[\w_]+)*?)(?:\s+with\s+[^:]+)?\s*(:)?$', stripped)
        if m and not stripped.startswith('show screen'):
            image = m.group(1)
            parts_str = (m.group(2) or '').strip()
            parts = parts_str.split() if parts_str else []
            has_colon = bool(m.group(3))
            atl_body = []
            if has_colon:
                body_items, next_idx = read_atl_block(i + 1, indent)
                atl_body = body_items
                i = next_idx
            else:
                i += 1
            events.append({
                'type': 'show', 'image': image, 'parts': parts,
                'atl_body': atl_body, 'line': line_num, 'indent': indent,
            })
            continue

        # scene X [parts...] [with Transition][:]
        m = re.match(r'^scene\s+([\w_]+)((?:\s+-?[\w_]+)*?)(?:\s+with\s+[^:]+)?\s*(:)?$', stripped)
        if m:
            image = m.group(1)
            parts_str = (m.group(2) or '').strip()
            parts = parts_str.split() if parts_str else []
            has_colon = bool(m.group(3))
            atl_body = []
            if has_colon:
                body_items, next_idx = read_atl_block(i + 1, indent)
                atl_body = body_items
                i = next_idx
            else:
                i += 1
            events.append({
                'type': 'scene', 'image': image, 'parts': parts,
                'atl_body': atl_body, 'line': line_num, 'indent': indent,
            })
            continue

        # hide X
        m = re.match(r'^hide\s+([\w_]+)', stripped)
        if m and not stripped.startswith('hide screen'):
            events.append({
                'type': 'hide', 'image': m.group(1), 'line': line_num,
            })
            i += 1
            continue

        # camera:
        if re.match(r'^camera\s*:\s*$', stripped):
            body_items, next_idx = read_atl_block(i + 1, indent)
            events.append({
                'type': 'camera', 'atl_body': body_items, 'line': line_num, 'indent': indent,
            })
            i = next_idx
            continue

        # Dialog line (pure string or character + string)
        # Match: "text"  or  name "text"  or  name attr1 attr2 "text"
        m = re.match(r'^[^"\n]*"([^"]+)"\s*$', stripped)
        if m:
            text = m.group(1)
            # Filter out paths, Character definitions, variable assignments
            if ('audio/' in text or 'Character(' in stripped or
                stripped.startswith('$') or stripped.startswith('define ') or
                stripped.startswith('default ') or stripped.startswith('play ') or
                stripped.startswith('stop ') or stripped.startswith('queue ') or
                stripped.startswith('voice ') or 'images/' in text):
                i += 1
                continue
            events.append({'type': 'dialog', 'text': text, 'line': line_num})
            i += 1
            continue

        i += 1

    return events


# ------------ CS Parser ------------

def parse_cs_calls(cs_content):
    """Parse cs file and return list of calls with line numbers.
    Each call is a dict: {type, line, raw, ...}
    Types: Show, Scene, Hide, SetCamera, OpenDialog, other
    """
    calls = []
    lines = cs_content.split('\n')
    for i, line in enumerate(lines, 1):
        # Skip comments and empty lines
        s = line.strip()
        if not s or s.startswith('//'):
            continue

        # Match _gameMethods.METHOD(
        m = re.search(r'_gameMethods\.(\w+)\(', line)
        if not m:
            continue
        method = m.group(1)

        if method == 'OpenDialog':
            # Get the dialog text from the comment
            m2 = re.search(r'OpenDialog\(\d+\);?\s*//\s*"([^"]+)"', line)
            text = m2.group(1) if m2 else ''
            calls.append({'type': 'OpenDialog', 'line': i, 'raw': line, 'text': text})
        elif method in ('Show', 'ShowBlack', 'ShowWhite'):
            # Get image name
            m2 = re.search(r'_gameMethods\.(?:Show|ShowBlack|ShowWhite)\("([^"]*)"', line)
            image = m2.group(1) if m2 else ''
            calls.append({'type': 'Show', 'subtype': method, 'line': i, 'raw': line, 'image': image})
        elif method in ('Scene', 'SceneBlack', 'SceneWhite'):
            m2 = re.search(r'_gameMethods\.(?:Scene|SceneBlack|SceneWhite)\("([^"]*)"', line)
            image = m2.group(1) if m2 else ''
            calls.append({'type': 'Scene', 'subtype': method, 'line': i, 'raw': line, 'image': image})
        elif method in ('Hide', 'HideBlack', 'HideWhite'):
            m2 = re.search(r'_gameMethods\.(?:Hide|HideBlack|HideWhite)\("([^"]*)"', line)
            image = m2.group(1) if m2 else ''
            calls.append({'type': 'Hide', 'subtype': method, 'line': i, 'raw': line, 'image': image})
        elif method == 'SetCamera':
            calls.append({'type': 'SetCamera', 'line': i, 'raw': line})
        else:
            calls.append({'type': 'Other', 'method': method, 'line': i, 'raw': line})
    return calls


# ------------ ATL Body to C# Conversion ------------

def format_value(raw):
    """Convert a raw rpy value string to C# expression."""
    raw = raw.strip()
    if raw == 'True':
        return 'true'
    if raw == 'False':
        return 'false'
    # Tuple (x, y) - Vector2
    m = re.match(r'^\(([^,]+),\s*([^)]+)\)$', raw)
    if m:
        x, y = m.group(1).strip(), m.group(2).strip()
        return f'new Vector2({x}f, {y}f)'
    # Number
    try:
        float(raw)
        return f'{raw}f'
    except ValueError:
        pass
    # String (quoted or identifier)
    if raw.startswith('"') and raw.endswith('"'):
        return raw
    return f'"{raw}"'


def tokenize_atl_line(line):
    """Tokenize an ATL line, respecting (tuple) groups."""
    tokens = []
    i = 0
    s = line
    while i < len(s):
        ch = s[i]
        if ch.isspace():
            i += 1
            continue
        if ch == '(':
            depth = 1
            j = i + 1
            while j < len(s) and depth > 0:
                if s[j] == '(':
                    depth += 1
                elif s[j] == ')':
                    depth -= 1
                j += 1
            tokens.append(s[i:j])
            i = j
        elif ch == '"':
            j = i + 1
            while j < len(s) and s[j] != '"':
                j += 1
            tokens.append(s[i:j+1])
            i = j + 1
        else:
            j = i
            while j < len(s) and not s[j].isspace() and s[j] != '(':
                j += 1
            tokens.append(s[i:j])
            i = j
    return tokens


def parse_atl_line_to_pairs(line):
    """Parse a single ATL line into (attr_name, value) pairs.
    Examples:
      'blur 5' -> [('blur', '5')]
      'subpixel True pos (0.5, 1.0) zoom 0.5' -> [('subpixel','True'), ('pos','(0.5, 1.0)'), ('zoom','0.5')]
      'pause 3' -> [('pause', '3')]
    Special: 'subpixel' takes 'True'/'False' value.
    Zero-arg keywords: 'repeat' (no value).
    """
    tokens = tokenize_atl_line(line)
    pairs = []
    i = 0
    while i < len(tokens):
        tok = tokens[i]
        if tok in ('repeat',):
            pairs.append((tok, None))
            i += 1
            continue
        if tok == 'subpixel':
            if i + 1 < len(tokens) and tokens[i+1] in ('True', 'False'):
                pairs.append((tok, tokens[i+1]))
                i += 2
            else:
                pairs.append((tok, 'True'))
                i += 1
            continue
        # Normal attr: take next token as value
        if i + 1 < len(tokens):
            pairs.append((tok, tokens[i+1]))
            i += 2
        else:
            pairs.append((tok, None))
            i += 1
    return pairs


def atl_body_to_same_line(atl_body, base_indent=None):
    """Convert rpy ATL body (list of (indent, content, line)) to C# sameLine list.

    Handles nested block: and parallel: by flattening.
    """
    if not atl_body:
        return None

    # Flatten: skip 'block:' / 'parallel:' container lines but include their children
    flat = []
    for indent, content, line_num in atl_body:
        stripped = content.rstrip(':').strip()
        # Skip pure container lines
        if stripped in ('block', 'parallel', 'choice', 'contains'):
            continue
        flat.append((indent, content, line_num))

    entries = []
    for indent, content, _ in flat:
        pairs = parse_atl_line_to_pairs(content)
        if not pairs:
            continue
        kv = []
        for attr, val in pairs:
            if val is None:
                # zero-arg keywords (repeat) - skip in sameLine
                continue
            cv = format_value(val)
            kv.append(f'{{"{attr}", {cv}}}')
        if not kv:
            continue
        dict_str = '{' + ', '.join(kv) + '}'
        entries.append(f'new SameLineParamData(new Dictionary<string, object>{dict_str})')

    if not entries:
        return None
    return 'new List<SameLineParamData>{' + ', '.join(entries) + '}'


def build_show_call(ev):
    image = ev['image']
    parts = ev.get('parts', [])
    atl_body = ev.get('atl_body', [])

    args = [f'"{image}"']
    if parts:
        parts_list = ', '.join(f'"{p}"' for p in parts)
        args.append(f'parts: new List<string>{{{parts_list}}}')

    sl = atl_body_to_same_line(atl_body)
    if sl:
        args.append(f'sameLine: {sl}')

    return f'_gameMethods.Show({", ".join(args)})'


def build_scene_call(ev):
    image = ev['image']
    atl_body = ev.get('atl_body', [])
    parts = ev.get('parts', [])

    args = [f'"{image}"']
    if parts:
        parts_list = ', '.join(f'"{p}"' for p in parts)
        args.append(f'parts: new List<string>{{{parts_list}}}')

    sl = atl_body_to_same_line(atl_body)
    if sl:
        args.append(f'sameLine: {sl}')

    return f'_gameMethods.Scene({", ".join(args)})'


# ------------ Matching Algorithm ------------

def is_buggy(call):
    """Check if a parsed cs call is buggy."""
    if call['type'] == 'Show':
        name = call.get('image', '')
        if name.lower() in ATL_KEYWORDS:
            return 'show_bad_name'
        try:
            float(name)
            return 'show_numeric_name'
        except ValueError:
            pass
        # Check for empty dict in raw
        if 'new Dictionary<string, object>()' in call['raw']:
            return 'empty_dict'
    elif call['type'] == 'Scene':
        name = call.get('image', '')
        try:
            float(name)
            return 'scene_numeric_name'
        except ValueError:
            pass
        if name.lower() in ATL_KEYWORDS:
            return 'scene_bad_name'
        if 'new Dictionary<string, object>()' in call['raw']:
            return 'empty_dict'
    return None


def build_cs_rpy_anchor_map(cs_calls, rpy_events):
    """
    Build a robust cs_idx -> rpy_idx mapping using long dialog texts as anchors.

    Strategy:
    1. Collect all cs dialog calls with sufficiently long texts
    2. Collect all rpy dialog events
    3. Match each cs dialog to its UNIQUE rpy counterpart using order-preserving LCS-like matching
    4. Interpolate for non-dialog calls
    """
    MIN_LEN = 6
    # Collect cs dialogs (idx_in_cs_calls, text)
    cs_dialogs = []
    for ci, call in enumerate(cs_calls):
        if call['type'] == 'OpenDialog':
            t = call.get('text', '')
            if len(t) >= MIN_LEN:
                cs_dialogs.append((ci, t))

    # Collect rpy dialogs (idx_in_rpy_events, text)
    rpy_dialogs = []
    for ri, ev in enumerate(rpy_events):
        if ev['type'] == 'dialog' and len(ev['text']) >= MIN_LEN:
            rpy_dialogs.append((ri, ev['text']))

    # Match cs dialogs to rpy dialogs in order using greedy LCS
    # For each cs dialog, find the next occurrence in rpy that is monotonically increasing
    anchor_map = {}  # cs_idx -> rpy_idx
    rpy_cursor = 0
    for cs_idx, cs_text in cs_dialogs:
        # Look ahead in rpy for matching text
        # Allow some lookahead but prefer near matches
        best_rpy = -1
        for ri in range(rpy_cursor, len(rpy_dialogs)):
            rpy_idx, rpy_text = rpy_dialogs[ri]
            if rpy_text == cs_text:
                best_rpy = ri
                break
        if best_rpy >= 0:
            anchor_map[cs_idx] = rpy_dialogs[best_rpy][0]
            rpy_cursor = best_rpy + 1

    return anchor_map


def match_and_fix(cs_calls, rpy_events):
    """
    Walk cs_calls and rpy_events in parallel, building a mapping.
    Return list of fixes: {cs_line, bug_type, old_raw, new_raw, rpy_line}
    """
    fixes = []

    # Build strong anchor map from dialogs
    anchor_map = build_cs_rpy_anchor_map(cs_calls, rpy_events)

    def get_rpy_idx_hint(cs_idx):
        """Estimate rpy_idx for a given cs_idx using surrounding anchors."""
        # Find the nearest preceding anchor and following anchor
        prev_cs, prev_rpy = -1, 0
        next_cs, next_rpy = None, None
        for ac in sorted(anchor_map.keys()):
            if ac <= cs_idx:
                prev_cs, prev_rpy = ac, anchor_map[ac]
            else:
                next_cs, next_rpy = ac, anchor_map[ac]
                break
        # Return the preceding anchor's rpy_idx + 1 (start searching from there)
        return prev_rpy + 1 if prev_cs >= 0 else 0

    # Strategy: For each buggy cs call, find its position within the anchor segment,
    # count how many same-type (Show/Scene) calls in cs come before it in the segment,
    # then match to the same-index same-type rpy event in the corresponding rpy segment.

    # Build list of anchor points as sorted (cs_idx, rpy_idx) pairs
    anchor_list = sorted(anchor_map.items())  # [(cs_idx, rpy_idx), ...]

    def find_segment(cs_idx):
        """Find the (prev_anchor, next_anchor) pair surrounding cs_idx.
        Returns (prev_cs_idx, prev_rpy_idx, next_cs_idx, next_rpy_idx).
        Either prev or next may be None if out of range.
        """
        prev_cs = prev_rpy = None
        next_cs = next_rpy = None
        for ac_cs, ac_rpy in anchor_list:
            if ac_cs < cs_idx:
                prev_cs, prev_rpy = ac_cs, ac_rpy
            elif ac_cs > cs_idx:
                next_cs, next_rpy = ac_cs, ac_rpy
                break
        return prev_cs, prev_rpy, next_cs, next_rpy

    def count_prior_same_type(cs_idx, call_type, lower_bound_cs):
        """Count how many cs calls of same type exist in [lower_bound_cs+1, cs_idx-1]."""
        count = 0
        start = (lower_bound_cs + 1) if lower_bound_cs is not None else 0
        for i in range(start, cs_idx):
            if cs_calls[i]['type'] == call_type:
                count += 1
        return count

    def get_rpy_events_in_range(lower_rpy, upper_rpy, event_type):
        """Get indices of rpy events of given type in [lower_rpy+1, upper_rpy)."""
        start = (lower_rpy + 1) if lower_rpy is not None else 0
        end = upper_rpy if upper_rpy is not None else len(rpy_events)
        return [i for i in range(start, end) if rpy_events[i]['type'] == event_type]

    for ci, call in enumerate(cs_calls):
        if call['type'] not in ('Show', 'Scene'):
            continue
        bug_type = is_buggy(call)
        if not bug_type:
            continue

        # Find surrounding anchors
        prev_cs, prev_rpy, next_cs, next_rpy = find_segment(ci)

        # Count how many Show/Scene calls appear before this in the cs segment
        nth = count_prior_same_type(ci, call['type'], prev_cs)

        # Find the corresponding rpy event (nth show/scene in the rpy segment)
        ev_type = 'show' if call['type'] == 'Show' else 'scene'
        rpy_candidates = get_rpy_events_in_range(prev_rpy, next_rpy, ev_type)

        if nth < len(rpy_candidates):
            matched_idx = rpy_candidates[nth]
            ev = rpy_events[matched_idx]
            if call['type'] == 'Show':
                new_call_str = build_show_call(ev)
                old_call_match = re.search(r'_gameMethods\.Show\([^;]*\)', call['raw'])
            else:
                new_call_str = build_scene_call(ev)
                old_call_match = re.search(r'_gameMethods\.Scene\([^;]*\)', call['raw'])
            if old_call_match:
                new_raw = call['raw'].replace(old_call_match.group(0), new_call_str)
                fixes.append({
                    'cs_line': call['line'],
                    'bug_type': bug_type,
                    'old': call['raw'].rstrip('\r'),
                    'new': new_raw.rstrip('\r'),
                    'rpy_line': ev['line'],
                })
                continue

        fixes.append({
            'cs_line': call['line'],
            'bug_type': bug_type,
            'old': call['raw'].rstrip('\r'),
            'new': None,
            'error': f'No matching rpy {ev_type} event found (nth={nth}, candidates={len(rpy_candidates)})',
        })

    return fixes


def process_file(cs_rel, rpy_rel):
    cs_path = CS_ROOT / cs_rel
    rpy_path = RPY_ROOT / rpy_rel
    if not cs_path.exists() or not rpy_path.exists():
        return [], f'Missing file: {cs_path} or {rpy_path}'

    with open(cs_path, 'r', encoding='utf-8') as f:
        cs_content = f.read()

    rpy_events = parse_rpy(rpy_path)
    cs_calls = parse_cs_calls(cs_content)
    fixes = match_and_fix(cs_calls, rpy_events)
    return fixes, None


def main():
    mode = sys.argv[1] if len(sys.argv) > 1 else 'preview'
    assert mode in ('preview', 'apply'), 'Mode must be preview or apply'

    all_fixes = {}
    errors = []
    stats = {'total': 0, 'fixed': 0, 'failed': 0}

    for cs_rel, rpy_rel in FILE_PAIRS.items():
        fixes, err = process_file(cs_rel, rpy_rel)
        if err:
            errors.append(f'{cs_rel}: {err}')
            continue
        if fixes:
            all_fixes[cs_rel] = fixes
            for f in fixes:
                stats['total'] += 1
                if f.get('new') is not None:
                    stats['fixed'] += 1
                else:
                    stats['failed'] += 1

    print('=' * 80)
    print(f'Mode: {mode}')
    print(f'Total bugs: {stats["total"]}')
    print(f'Auto-fixable: {stats["fixed"]}')
    print(f'Failed to match: {stats["failed"]}')
    print('=' * 80)

    preview_path = BASE / 'Docs/converter_fixes_preview.txt'
    with open(preview_path, 'w', encoding='utf-8') as f:
        f.write(f'Converter Bug Fix Preview\n')
        f.write(f'Total: {stats["total"]}, Fixable: {stats["fixed"]}, Failed: {stats["failed"]}\n')
        f.write('=' * 80 + '\n\n')
        for cs_rel, fixes in all_fixes.items():
            f.write(f'### {cs_rel}\n')
            for fix in fixes:
                f.write(f'\n  Line {fix["cs_line"]} [{fix["bug_type"]}]\n')
                f.write(f'  OLD: {fix["old"].strip()[:400]}\n')
                if fix.get('new'):
                    f.write(f'  NEW: {fix["new"].strip()[:400]}\n')
                    f.write(f'  (matched rpy line {fix.get("rpy_line", "?")})\n')
                else:
                    f.write(f'  ERROR: {fix.get("error", "")}\n')
            f.write('\n')

    print(f'Preview saved to: {preview_path}')
    if errors:
        print('Errors:')
        for e in errors:
            print(f'  {e}')

    if mode == 'apply':
        applied = 0
        for cs_rel, fixes in all_fixes.items():
            cs_path = CS_ROOT / cs_rel
            with open(cs_path, 'rb') as f:
                content_bytes = f.read()
            # Detect line ending
            use_crlf = b'\r\n' in content_bytes
            content = content_bytes.decode('utf-8')
            lines = content.split('\n')
            for fix in sorted(fixes, key=lambda x: -x['cs_line']):
                if fix.get('new') is not None:
                    idx = fix['cs_line'] - 1
                    if 0 <= idx < len(lines):
                        original = lines[idx]
                        has_cr = original.endswith('\r')
                        new = fix['new']
                        if has_cr and not new.endswith('\r'):
                            new += '\r'
                        lines[idx] = new
                        applied += 1
            new_content = '\n'.join(lines)
            with open(cs_path, 'w', encoding='utf-8', newline='') as f:
                f.write(new_content)
        print(f'\nApplied {applied} fixes.')


if __name__ == '__main__':
    main()
