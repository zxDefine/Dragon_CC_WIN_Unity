"""为单个 rpy 文件生成对应 cs 草稿（Phase 3.5 tuanzhan_you 手工转译辅助工具）。

用法：python rpy_to_cs_transcriber.py <rpy_rel_path> <class_name>

产物：
- <class_name>.cs 主 label 文件（stdout 写到 --cs-out 指定路径）
- <class_name>_menu.cs 菜单分支文件（--menu-out 指定路径）

注意：
- dialog_id 权威来源 = rpy_dialogs_<basename>.json（`entries[*].line -> dialog_id`）
- 对话文本截断注释为前 ~24 字符 + "..."
- 复杂 camera/show/scene 块采用简化 sameLine 结构，可能需要人工复核
- Fade / Shake / Dissolve 等 with 过渡：已尽量覆盖主流形式，无法识别的会产生 TransitionBy 占位
"""
import os
import sys
import io
import re
import json
from pathlib import Path

sys.stdout = io.TextIOWrapper(sys.stdout.buffer, encoding='utf-8')

BASE = Path(r'h:/Programming/ProjDragon/dragon_cc_win')
RPY_ROOT = BASE / 'dragon_yuanban'

# ---------------------------------------------------------------------------
# helpers
# ---------------------------------------------------------------------------

def comment_preview(text, limit=24):
    """把原对话文本截断为 cs 行尾注释（// "..."）用。
    注释体内的原文按字面保留（不转义 \\ 与 "），与 fanhuitu.cs / juezhan.cs 约定一致。
    """
    t = text
    if len(t) > limit:
        t = t[:limit] + '...'
    return t


def cs_string(s):
    """Escape for C# double-quoted literal."""
    return s.replace('\\', '\\\\').replace('"', '\\"')


FADE_RE = re.compile(r'Fade\(\s*([0-9.]+)\s*,\s*([0-9.]+)\s*,\s*([0-9.]+)\s*(?:,\s*color\s*=\s*"([^"]+)")?\s*\)')
SHAKE_RE = re.compile(r'Shake\(\s*\(([^)]*)\)\s*,\s*([0-9.]+)\s*(?:,\s*dist\s*=\s*([0-9.]+))?\s*\)')
DISSOLVE_RE = re.compile(r'Dissolve\(\s*([0-9.]+)\s*\)')
PUSHMOVE_RE = re.compile(r'PushMove\(\s*([0-9.]+)\s*,\s*"([^"]+)"\s*\)')
PAUSE_RE = re.compile(r'Pause\(\s*([0-9.]+)\s*\)')


def translate_with(expr):
    """把 rpy `with xxx` 的 xxx 翻译成 cs 调用。"""
    expr = expr.strip()
    # with None —— 无过渡
    if expr == 'None':
        return '// with None (no-op)'
    m = DISSOLVE_RE.fullmatch(expr)
    if m:
        return f'yield return _gameMethods.Transition(time:{m.group(1)}f);'
    if expr == 'dissolve':
        return 'yield return _gameMethods.Transition(time:0.5f);'
    # with Pause(N) —— Renpy 语义是单纯等待 N 秒，映射到 StopEngineTime
    m = PAUSE_RE.fullmatch(expr)
    if m:
        return f'yield return _gameMethods.StopEngineTime(time:{to_float(m.group(1))});'
    m = FADE_RE.fullmatch(expr)
    if m:
        # rpy: Fade(out, hold, in, color) → cs: TransitionWithFadeIn(out, hold, in, color)
        out_, hold, in_ = m.group(1), m.group(2), m.group(3)
        color = m.group(4) or '#000'
        return (
            f'yield return _gameMethods.TransitionWithFadeIn(outTime:{to_float(out_)}, '
            f'holdTime:{to_float(hold)}, inTime:{to_float(in_)}, colorCode:"{color}");'
        )
    m = SHAKE_RE.fullmatch(expr)
    if m:
        # Shake → TransitionBy("shake")（M3.1 已由 TransitionManager.PlayShake 真实实现）
        dur = m.group(2)
        dist = m.group(3) or '5'
        return f'yield return _gameMethods.TransitionBy("shake"); // Shake({m.group(1)}, {dur}, dist={dist})'
    m = PUSHMOVE_RE.fullmatch(expr)
    if m:
        dur = m.group(1)
        dirn = m.group(2)
        return f'yield return _gameMethods.TransitionBy("pushmove_{dirn}");'
    # 裸 transition 名（hpunch / epilepsy / fade / blink* / trans_rip_* / 等）
    safe = re.sub(r'[^a-zA-Z0-9_]', '_', expr)
    return f'yield return _gameMethods.TransitionBy("{safe}");'


# ---------------------------------------------------------------------------
# rpy block-property parser (for show/scene/camera ATL blocks)
# ---------------------------------------------------------------------------

TOKEN_NUMBER = re.compile(r'-?\d+(?:\.\d+)?')


def parse_block_props(lines, start_idx, base_indent, _parallel_counter=None):
    """从 start_idx 开始读取缩进 > base_indent 的行，返回字典列表（每行一组属性）。"""
    if _parallel_counter is None:
        _parallel_counter = {'n': 0}
    i = start_idx
    result = []  # list of dicts
    n = len(lines)
    while i < n:
        ln = lines[i]
        if ln.strip() == '':
            i += 1
            continue
        indent = len(ln) - len(ln.lstrip())
        if indent <= base_indent:
            break
        stripped = ln.strip()
        if stripped.startswith('#'):
            i += 1
            continue
        # parallel: / block: sub-blocks
        if stripped in ('parallel:', 'block:'):
            i += 1
            # inner counter resets for nested, but top-level parallel_N uses shared counter
            sub_rows = parse_block_props(lines, i, indent, {'n': 0})
            # advance i
            while i < n:
                sub_ln = lines[i]
                if sub_ln.strip() == '':
                    i += 1
                    continue
                sub_indent = len(sub_ln) - len(sub_ln.lstrip())
                if sub_indent <= indent:
                    break
                i += 1
            tag = stripped[:-1]  # 'parallel' / 'block'
            idx = _parallel_counter['n']
            _parallel_counter['n'] += 1
            for row in sub_rows:
                row[f'__{tag}_{idx}'] = True
                result.append(row)
            continue
        result.append(parse_prop_line(stripped))
        i += 1
    return result


PROP_KEYWORDS = {
    'subpixel', 'perspective', 'gl_depth', 'repeat',
    'pos', 'anchor', 'xpos', 'ypos', 'zpos', 'xoffset', 'yoffset',
    'zoom', 'xzoom', 'yzoom', 'alpha', 'blur', 'rotate', 'xrotate',
    'yrotate', 'zrotate', 'additive', 'matrixcolor',
    'linear', 'ease', 'easein', 'easeout',
    'easein_cubic', 'easeout_cubic', 'easein_quad', 'easeout_quad',
    'easein_quart', 'easeout_quart', 'easein_quint', 'easeout_quint',
    'easein_circ', 'easeout_circ', 'easein_back', 'easeout_back',
    'easein_bounce', 'easeout_bounce', 'easein_elastic', 'easeout_elastic',
    'pause', 'time', 'hold',
}


def parse_prop_line(s):
    """把一行 ATL 属性解析成 {key: value}。支持：
    - 布尔: subpixel True
    - 数值: xpos 0.5 / linear 0.3 xpos 0.42
    - 元组: pos (0.5, 1.0)
    - matrixcolor InvertMatrix(...)*ContrastMatrix(...)*... (保留为原字符串)
    """
    d = {}
    # matrixcolor special
    mc = re.search(r'matrixcolor\s+(.+)$', s)
    if mc:
        d['matrixcolor'] = mc.group(1).strip()
        s = s[:mc.start()].rstrip()
    # tokenize
    tokens = []
    i = 0
    while i < len(s):
        ch = s[i]
        if ch == ' ' or ch == '\t':
            i += 1
            continue
        if ch == '(':
            j = s.find(')', i)
            if j == -1:
                break
            tokens.append(s[i:j+1])
            i = j + 1
            continue
        if ch == '"':
            j = s.find('"', i+1)
            if j == -1:
                break
            tokens.append(s[i:j+1])
            i = j + 1
            continue
        j = i
        while j < len(s) and s[j] not in (' ', '\t', '('):
            j += 1
        tokens.append(s[i:j])
        i = j
    k = 0
    while k < len(tokens):
        tok = tokens[k]
        if tok in PROP_KEYWORDS:
            # boolean flags
            if tok in ('subpixel', 'perspective', 'gl_depth', 'repeat'):
                # may be followed by True/False
                if k + 1 < len(tokens) and tokens[k+1] in ('True', 'False'):
                    d[tok] = tokens[k+1] == 'True'
                    k += 2
                    continue
                d[tok] = True
                k += 1
                continue
            # has value
            if k + 1 < len(tokens):
                val_tok = tokens[k+1]
                d[tok] = val_tok
                k += 2
                continue
        k += 1
    return d


def render_samelines(rows):
    """把字典列表渲染成 `sameLine: new List<SameLineParamData>{...}` 源代码。"""
    if not rows:
        return ''
    parts = []
    for row in rows:
        parts.append(render_samerow(row))
    return 'sameLine: new List<SameLineParamData>{' + ', '.join(parts) + '}'


KEY_RENAME = {
    'gl_depth': 'glDepth',
}


def render_samerow(row):
    """单行 → SameLineParamData(new Dictionary<string, object>{...})."""
    items = []
    for k, v in row.items():
        if k.startswith('__'):
            # parallel / block marker
            marker = k.lstrip('_')
            items.append(f'{{"{marker}", true}}')
            continue
        cs_key = KEY_RENAME.get(k, k)
        items.append(f'{{"{cs_key}", {render_prop_value(k, v)}}}')
    return 'new SameLineParamData(new Dictionary<string, object>{' + ', '.join(items) + '})'


def render_prop_value(key, v):
    if isinstance(v, bool):
        return 'true' if v else 'false'
    if isinstance(v, str):
        v = v.strip()
        if v.startswith('(') and v.endswith(')'):
            nums = [x.strip() for x in v[1:-1].split(',') if x.strip()]
            if len(nums) == 2:
                return f'new Vector2({to_float(nums[0])}, {to_float(nums[1])})'
            if len(nums) == 3:
                return f'new Vector3({to_float(nums[0])}, {to_float(nums[1])}, {to_float(nums[2])})'
            return '"' + cs_string(v) + '"'
        if v in ('True', 'False'):
            return 'true' if v == 'True' else 'false'
        if v.startswith('"') and v.endswith('"'):
            return v  # already quoted
        # number?
        if TOKEN_NUMBER.fullmatch(v):
            return to_float(v)
        # color or expression → quoted string
        return '"' + cs_string(v) + '"'
    return str(v)


def to_float(n):
    if '.' not in n:
        n = n + '.0'
    return n + 'f'


# ---------------------------------------------------------------------------
# main rpy-to-cs walker
# ---------------------------------------------------------------------------

class Emitter:
    def __init__(self, indent=8):
        self.lines = []
        self.base_indent = indent

    def emit(self, code, extra_indent=0):
        pad = ' ' * (self.base_indent + extra_indent)
        self.lines.append(pad + code)

    def text(self):
        return '\n'.join(self.lines)


def build_id_map(json_path):
    with open(json_path, 'r', encoding='utf-8') as f:
        data = json.load(f)
    return {int(e['line']): e for e in data['entries']}


def split_play_path(raw):
    """解析 play 后面的 path 部分（可能是 "xxx" 或 [ "a", "b" ]）。返回字符串。"""
    raw = raw.strip()
    if raw.startswith('['):
        # list of strings concatenated
        parts = re.findall(r'"([^"]*)"', raw)
        return ''.join(parts)
    m = re.match(r'"([^"]*)"', raw)
    if m:
        return m.group(1)
    return raw


PLAY_RE = re.compile(r'play\s+(\w+)\s+(.+?)\s*(?:volume\s+([0-9.]+))?\s*(?:fadein\s+([0-9.]+))?$')


def convert_play(stripped):
    """`play music "path" volume 0.8 fadein 1` → PlaySound(channel, fadein, volume, path)"""
    m = re.match(r'play\s+(\w+)\s+(.+)$', stripped)
    if not m:
        return None
    channel = m.group(1)
    rest = m.group(2).strip()
    # extract volume / fadein options (may appear in any order after the path)
    volume = '1.0'
    fadein = '0.0'
    # tail options
    tail_re = re.compile(r'\s+(volume|fadein)\s+([0-9.]+)')
    while True:
        tm = tail_re.search(rest)
        if not tm:
            break
        if tm.group(1) == 'volume':
            volume = tm.group(2)
        else:
            fadein = tm.group(2)
        rest = rest[:tm.start()] + rest[tm.end():]
    path_expr = split_play_path(rest)
    return f'yield return _gameMethods.PlaySound("{channel}", {to_float(fadein)}, {to_float(volume)}, "{cs_string(path_expr)}");'


def convert_stop(stripped):
    m = re.match(r'stop\s+(\w+)(?:\s+fadeout\s+([0-9.]+))?', stripped)
    if not m:
        return None
    ch = m.group(1)
    fo = m.group(2) or '0'
    return f'yield return _gameMethods.StopSound(channelName:"{ch}", fadeOut:{to_float(fo)});'


def cap_first(name):
    """只大写首字母，其余保持不变（匹配 Haogandu_he / He_xianzai / Jq_10_5 / Povname 风格）。"""
    return name[:1].upper() + name[1:] if name else name


def convert_dollar(stripped):
    """`$ xxx` → best-effort C# statement."""
    expr = stripped[1:].strip()
    # set_volume
    sv = re.match(r"renpy\.music\.set_volume\(\s*([0-9.]+)\s*,\s*delay\s*=\s*([0-9.]+)\s*,\s*channel\s*=\s*'([^']+)'\s*\)", expr)
    if sv:
        return f'yield return _gameMethods.EngineSetVolume(volume:{to_float(sv.group(1))}, delay:{to_float(sv.group(2))}, channelName:"{sv.group(3)}");'
    # _dismiss_pause
    dp = re.match(r'_dismiss_pause\s*=\s*(True|False)', expr)
    if dp:
        return f'Engine._dismiss_pause = {"true" if dp.group(1) == "True" else "false"};'
    hist = re.match(r'_history\s*=\s*(True|False)', expr)
    if hist:
        return f'Engine._history = {"true" if hist.group(1) == "True" else "false"};'
    # gui_duihuakuang_you
    gd = re.match(r'gui_duihuakuang_you\s*=\s*(\d+)', expr)
    if gd:
        return f'Defaults.Gui_duihuakuang_you = {gd.group(1)};'
    # persistent.xxx = val
    ps = re.match(r'persistent\.([a-zA-Z0-9_]+)\s*=\s*(.+)', expr)
    if ps:
        field = cap_first(ps.group(1))
        val = ps.group(2).split('#')[0].strip()
        return f'Defaults.Persistent.{field} = {val};'
    # haogandu_xx = haogandu_xx + N  (also jq_xx, bai_xx etc.)
    hg = re.match(r'([a-z][a-zA-Z0-9_]*)\s*=\s*\1\s*\+\s*(\d+)', expr)
    if hg:
        name = hg.group(1)
        cs_name = cap_first(name)
        return f'Defaults.{cs_name} = Defaults.{cs_name} + {hg.group(2)};'
    # plain assignment: name = literal (number / string / true/false)
    pa = re.match(r'([a-z][a-zA-Z0-9_]*)\s*=\s*(.+)', expr)
    if pa:
        name = pa.group(1)
        val = pa.group(2).split('#')[0].strip()
        # normalise val
        if val in ('True', 'False'):
            val = 'true' if val == 'True' else 'false'
        cs_name = cap_first(name)
        return f'Defaults.{cs_name} = {val};'
    # fallthrough
    return f'// TODO($): {cs_string(expr)}'


# character-name heuristics
SPEAK_CHAR_PREFIXES = ('nv', 'an', 'he', 'nuo', 'luo', 'yao', 'bai')


def is_speak_char(name):
    return any(name.startswith(p) for p in SPEAK_CHAR_PREFIXES)


VIRTUAL_CHAR_SUFFIXES = ('_qian', '_nv', '_pangbai', '_luo', '_he', '_nv_qian', '_nv_weizhi', '_weizhi')


def is_virtual_speaker(name):
    return any(s in name for s in VIRTUAL_CHAR_SUFFIXES) or name.endswith(('_pangbai',))


def convert_char_line(name, rest, id_entry):
    """`nv1 mei1 yan5 zui19 "..."` → 如果是派生/虚拟 speaker 用 ExecuteCharacterImageData + OpenDialog."""
    parts_match = re.match(r'((?:[a-zA-Z0-9_\-]+\s+)*)"(.*)"\s*$', rest)
    parts = []
    if parts_match:
        parts_str = parts_match.group(1).strip()
        if parts_str:
            parts = parts_str.split()
    out = []
    if parts:
        parts_cs = ', '.join(f'"{p}"' for p in parts)
        out.append(f'yield return _gameMethods.ExecuteCharacterImageData("{name}", parts: new List<string>{{{parts_cs}}});')
    else:
        out.append(f'yield return _gameMethods.ExecuteCharacterImageData("{name}");')
    if id_entry:
        tid = id_entry['dialog_id']
        preview = comment_preview(id_entry['text'])
        out.append(f'yield return _gameMethods.OpenDialog({tid}); // "{preview}"')
    return out


def convert_show(stripped, block_rows):
    """`show <name> <parts>` + optional block props."""
    m = re.match(r'show\s+([\w\-]+)(.*?)(?::\s*)?$', stripped)
    if not m:
        return None
    name = m.group(1)
    rest = m.group(2).strip()
    parts = []
    if rest:
        tokens = rest.split()
        parts = [t for t in tokens if t not in ('-emoji2', '-emoji3', '-emoji5') and not t.startswith(':')]
    parts_cs = ''
    if parts:
        parts_cs = 'parts: new List<string>{' + ', '.join(f'"{cs_string(p)}"' for p in parts) + '}'
    same = render_samelines(block_rows)
    args = ', '.join(x for x in [parts_cs, same] if x)
    if args:
        return f'yield return _gameMethods.Show("{name}", {args});'
    return f'yield return _gameMethods.Show("{name}");'


def convert_scene(stripped, block_rows):
    m = re.match(r'scene\s+([\w\-]+)(.*?)(?::\s*)?$', stripped)
    if not m:
        return None
    name = m.group(1)
    rest = m.group(2).strip()
    parts = rest.split() if rest else []
    parts_cs = ''
    if parts:
        parts_cs = 'parts: new List<string>{' + ', '.join(f'"{p}"' for p in parts) + '}'
    same = render_samelines(block_rows)
    args = ', '.join(x for x in [parts_cs, same] if x)
    if name == 'black':
        return 'yield return _gameMethods.SceneBlack();' if not args else f'yield return _gameMethods.SceneBlack({args});'
    if name == 'white':
        return 'yield return _gameMethods.SceneWhite();' if not args else f'yield return _gameMethods.SceneWhite({args});'
    if args:
        return f'yield return _gameMethods.Scene("{name}", {args});'
    return f'yield return _gameMethods.Scene("{name}");'


def convert_hide(stripped):
    m = re.match(r'hide\s+([\w\-]+)', stripped)
    if not m:
        return None
    return f'yield return _gameMethods.Hide("{m.group(1)}");'


def convert_camera(block_rows):
    same = render_samelines(block_rows)
    if same:
        return f'yield return _gameMethods.SetCamera({same});'
    return 'yield return _gameMethods.SetCamera();'


def convert_voice(stripped):
    m = re.match(r'voice\s+"([^"]+)"', stripped)
    if not m:
        return None
    p = m.group(1)
    if not p.startswith('Assets/'):
        p = 'Assets/RenpyResources/' + p
    return f'yield return _gameMethods.PlayVoice(voicePath:"{p}");'


def convert_pause(stripped):
    m = re.match(r'pause\s+([0-9.]+)', stripped)
    if not m:
        return None
    # 顶层 pause N → StopEngineTime(Nf)（参考 zhuxian0.cs 等现有实现）
    return f'yield return _gameMethods.StopEngineTime(time:{to_float(m.group(1))});'


# ---------------------------------------------------------------------------
# main walker
# ---------------------------------------------------------------------------

def skip_block(lines, i, base_indent):
    n = len(lines)
    while i < n:
        ln = lines[i]
        if ln.strip() == '':
            i += 1
            continue
        indent = len(ln) - len(ln.lstrip())
        if indent <= base_indent:
            break
        i += 1
    return i


def process_lines(lines, id_map, start_line, end_line, indent=8):
    """处理 [start_line, end_line]（1-based，含端点）区间，返回 cs 代码字符串。"""
    em = Emitter(indent=indent)
    i = start_line - 1  # 0-based
    n = min(end_line, len(lines))

    while i < n:
        raw = lines[i]
        stripped = raw.strip()
        if not stripped or stripped.startswith('#'):
            i += 1
            continue
        line_no = i + 1
        base_indent = len(raw) - len(raw.lstrip())

        # label / jump / menu / label def
        if re.match(r'label\s+', stripped):
            # outer-level label (handled by caller)
            i += 1
            continue
        if stripped.startswith('jump '):
            target = stripped[5:].strip().rstrip(':')
            em.emit(f'yield return _gameMethods.ChangeLabelTo("label_{target}");')
            i += 1
            continue
        if stripped == 'return':
            em.emit('yield break;')
            i += 1
            continue
        # 空台词行 `""` —— Renpy 里是"等待点击"节拍，参考 juezhan.cs 处理：静默跳过
        if stripped == '""':
            i += 1
            continue
        # 模块级 image 声明（如 `image tishi_xun = Text("...")`），运行时不重放，跳过
        if re.match(r'image\s+\w+\s*=', stripped):
            i += 1
            continue
        if stripped == 'menu:' or stripped.startswith('menu:'):
            # handled by caller
            i += 1
            continue

        # voice
        v = convert_voice(stripped)
        if v:
            em.emit(v)
            i += 1
            continue

        # voice attribute quoting aside, dialog lines first
        id_entry = id_map.get(line_no)
        if id_entry:
            kind = id_entry['kind']
            text = id_entry['text']
            tid = id_entry['dialog_id']
            preview = comment_preview(text)
            if kind == 'narrator':
                em.emit(f'yield return _gameMethods.OpenDialog({tid}); // "{preview}"')
                i += 1
                continue
            elif kind == 'dialog':
                char = id_entry['character']
                # if this character looks like a "virtual" composed speaker, emit ExecuteCharacterImageData
                attrs = (id_entry.get('attrs') or '').strip()
                if attrs and is_virtual_speaker(char):
                    parts = attrs.split()
                    parts_cs = ', '.join(f'"{p}"' for p in parts)
                    em.emit(f'yield return _gameMethods.ExecuteCharacterImageData("{char}", parts: new List<string>{{{parts_cs}}});')
                elif is_virtual_speaker(char):
                    em.emit(f'yield return _gameMethods.ExecuteCharacterImageData("{char}");')
                elif attrs:
                    parts = attrs.split()
                    parts_cs = ', '.join(f'"{p}"' for p in parts)
                    em.emit(f'yield return _gameMethods.ExecuteCharacterImageData("{char}", parts: new List<string>{{{parts_cs}}});')
                # 对于非虚拟角色（nv2, an, he, luo, nuo, yao），原版用 show 控制立绘，这里只做台词
                em.emit(f'yield return _gameMethods.OpenDialog({tid}); // "{preview}"')
                i += 1
                continue
            elif kind == 'extend':
                char = id_entry['character']
                attrs = (id_entry.get('attrs') or '').strip()
                if attrs:
                    parts = attrs.split()
                    parts_cs = ', '.join(f'"{p}"' for p in parts)
                    em.emit(f'yield return _gameMethods.ExecuteCharacterImageData("{char}", parts: new List<string>{{{parts_cs}}});')
                em.emit(f'yield return _gameMethods.OpenDialog({tid}); // "{preview}"')
                i += 1
                continue

        # scene / show / camera / hide with possible block
        if stripped.startswith('scene') or re.match(r'scene\s', stripped + ' '):
            if stripped.endswith(':'):
                block_rows = parse_block_props(lines, i+1, base_indent)
                code = convert_scene(stripped[:-1], block_rows)
                em.emit(code)
                i = skip_block(lines, i+1, base_indent)
            else:
                code = convert_scene(stripped, [])
                em.emit(code)
                i += 1
            continue
        if re.match(r'show\s', stripped):
            if stripped.endswith(':'):
                block_rows = parse_block_props(lines, i+1, base_indent)
                code = convert_show(stripped[:-1], block_rows)
                em.emit(code)
                i = skip_block(lines, i+1, base_indent)
            else:
                code = convert_show(stripped, [])
                em.emit(code)
                i += 1
            continue
        if re.match(r'hide\s', stripped):
            code = convert_hide(stripped)
            em.emit(code)
            i += 1
            continue
        if stripped == 'camera:' or stripped.startswith('camera:'):
            block_rows = parse_block_props(lines, i+1, base_indent)
            code = convert_camera(block_rows)
            em.emit(code)
            i = skip_block(lines, i+1, base_indent)
            continue

        # play / stop
        if stripped.startswith('play '):
            code = convert_play(stripped)
            if code:
                em.emit(code)
            else:
                em.emit(f'// TODO(play L{line_no}): {cs_string(stripped)}')
            i += 1
            continue
        if stripped.startswith('stop '):
            code = convert_stop(stripped)
            if code:
                em.emit(code)
            else:
                em.emit(f'// TODO(stop L{line_no}): {cs_string(stripped)}')
            i += 1
            continue

        # with
        if stripped.startswith('with '):
            expr = stripped[5:].strip()
            em.emit(translate_with(expr))
            i += 1
            continue

        # pause
        if stripped.startswith('pause '):
            code = convert_pause(stripped)
            if code:
                em.emit(code)
            i += 1
            continue

        # $
        if stripped.startswith('$'):
            code = convert_dollar(stripped)
            em.emit(code)
            i += 1
            continue

        # python:
        if stripped == 'python:':
            # collect block
            i += 1
            block = []
            while i < len(lines):
                ln = lines[i]
                if ln.strip() == '':
                    i += 1
                    continue
                ind = len(ln) - len(ln.lstrip())
                if ind <= base_indent:
                    break
                block.append(ln.strip())
                i += 1
            # try to render well-known achievement.grant block
            grant_names = [re.match(r'achievement\.grant\("([^"]+)"\)', b) for b in block]
            if any(grant_names) and any('achievement.sync()' in b for b in block):
                for g in grant_names:
                    if g:
                        em.emit(f'_gameMethods.GrantAchievement("{g.group(1)}");')
                em.emit('_gameMethods.SyncAchievement();')
            else:
                for b in block:
                    em.emit(f'// TODO(python): {cs_string(b)}')
            continue

        # if / elif / else
        m = re.match(r'if\s+(.+?):\s*$', stripped)
        if m:
            cond = translate_cond(m.group(1))
            em.emit(f'if ({cond})')
            em.emit('{')
            # recurse into block
            body = find_block_range(lines, i+1, base_indent)
            body_code = process_lines(lines, id_map, body[0]+1, body[1]+1, indent=em.base_indent+4)
            em.lines.append(body_code)
            em.emit('}')
            i = body[1] + 1
            # handle following elif/else at same base_indent
            while i < len(lines):
                nxt = lines[i]
                if nxt.strip() == '':
                    i += 1
                    continue
                ind = len(nxt) - len(nxt.lstrip())
                if ind != base_indent:
                    break
                st = nxt.strip()
                em2 = re.match(r'elif\s+(.+?):\s*$', st)
                if em2:
                    cond = translate_cond(em2.group(1))
                    em.emit(f'else if ({cond})')
                    em.emit('{')
                    body = find_block_range(lines, i+1, base_indent)
                    body_code = process_lines(lines, id_map, body[0]+1, body[1]+1, indent=em.base_indent+4)
                    em.lines.append(body_code)
                    em.emit('}')
                    i = body[1] + 1
                    continue
                if st == 'else:':
                    em.emit('else')
                    em.emit('{')
                    body = find_block_range(lines, i+1, base_indent)
                    body_code = process_lines(lines, id_map, body[0]+1, body[1]+1, indent=em.base_indent+4)
                    em.lines.append(body_code)
                    em.emit('}')
                    i = body[1] + 1
                    break
                break
            continue

        # character-line fallback: `xxx "text"` where xxx is a char name but NO line entry (rare)
        m = re.match(r'([a-zA-Z0-9_\-]+)\s+(.+)', stripped)
        if m and '"' in m.group(2):
            em.emit(f'// TODO(char-line L{line_no}): {cs_string(stripped)}')
            i += 1
            continue

        # unknown — emit as comment
        em.emit(f'// TODO L{line_no}: {cs_string(stripped)}')
        i += 1

    return em.text()


def translate_cond(cond):
    """翻译简单 if 条件为 C# 等价。"""
    c = cond.strip()
    # operators first, BEFORE variable substitution, so `or`/`and`/`not` 不会被当成变量
    c = re.sub(r'\band\b', '&&', c)
    c = re.sub(r'\bor\b', '||', c)
    c = re.sub(r'\bnot\b', '!', c)
    # persistent.xxx
    c = re.sub(r'persistent\.([a-zA-Z0-9_]+)', lambda m: 'Defaults.Persistent.' + cap_first(m.group(1)), c)
    # haogandu_xx / he_xianzai 等（跳过已经前缀 Defaults. 的）
    def var_repl(m):
        name = m.group(0)
        if name in ('True', 'False'):
            return 'true' if name == 'True' else 'false'
        return 'Defaults.' + cap_first(name)
    # 只替换那些前面没有 `.` 的 identifier（避免重复前缀）
    c = re.sub(r'(?<![\w.])[a-z][a-zA-Z0-9_]*', var_repl, c)
    return c


def find_block_range(lines, start_idx, base_indent):
    """返回 [first_idx, last_idx]（0-based），代表严格缩进 > base_indent 的连续块。"""
    i = start_idx
    n = len(lines)
    first = i
    last = i - 1
    while i < n:
        ln = lines[i]
        if ln.strip() == '':
            i += 1
            continue
        ind = len(ln) - len(ln.lstrip())
        if ind <= base_indent:
            break
        last = i
        i += 1
    return (first, last)


# ---------------------------------------------------------------------------
# driver
# ---------------------------------------------------------------------------

def main():
    rpy_rel = sys.argv[1]
    class_name = sys.argv[2]
    cs_out = sys.argv[3]
    menu_out = sys.argv[4]

    rpy_path = RPY_ROOT / rpy_rel
    basename = Path(rpy_rel).stem
    json_path = BASE / f'rpy_dialogs_{basename}.json'

    with open(rpy_path, 'r', encoding='utf-8') as f:
        lines = f.read().split('\n')
    id_map = build_id_map(json_path)

    # locate labels
    labels = []  # list of (line_idx 0-based, name, base_indent)
    for i, ln in enumerate(lines):
        m = re.match(r'(\s*)label\s+(\w+)\s*:', ln)
        if m:
            labels.append((i, m.group(2), len(m.group(1))))
    # locate menus
    menus = []  # list of (line_idx 0-based, base_indent)
    for i, ln in enumerate(lines):
        m = re.match(r'(\s*)menu\s*:\s*$', ln)
        if m:
            menus.append((i, len(m.group(1))))

    # Build segments: each label is a segment from its line to the next label OR menu-before-next-label.
    # We treat each menu as a segment boundary: emit its body + OpenSelectMenu in the enclosing label.
    # Assumptions for tuanzhan_you: every menu has a single option that bodies -> jump target, we emit
    # OpenSelectMenu at end of label and put the option body in menu file.

    # Generate cs header
    cs = [
        'using System.Collections;',
        'using System.Collections.Generic;',
        'using UnityEngine;',
        '',
        f'public class {class_name} : ILabelProvider',
        '{',
        '    private GameMethods _gameMethods;',
        '',
        f'    public {class_name}(GameMethods gameMethods)',
        '    {',
        '        _gameMethods = gameMethods;',
        '    }',
        '',
    ]
    menu_cs = [
        'using System.Collections;',
        'using System.Collections.Generic;',
        'using UnityEngine;',
        '',
        f'public class {class_name}_menu : ILabelProvider',
        '{',
        '    private GameMethods _gameMethods;',
        '',
        f'    public {class_name}_menu(GameMethods gameMethods)',
        '    {',
        '        _gameMethods = gameMethods;',
        '    }',
        '',
    ]

    menu_counter = 0
    menu_entries = []  # (menu_idx, option_idx, pinyin, body_start, body_end, jump_target)

    # walk labels in order
    for li, (lidx, lname, lindent) in enumerate(labels):
        next_start = labels[li+1][0] if li+1 < len(labels) else len(lines)
        cs.append(f'    public IEnumerator label_{lname}()')
        cs.append('    {')
        # check if a menu is inside [lidx+1, next_start)
        inner_menus = [m for m in menus if lidx < m[0] < next_start]
        cursor = lidx + 1  # first content line
        for mi, mindent in inner_menus:
            # emit lines cursor..mi-1
            body_code = process_lines(lines, id_map, cursor+1, mi, indent=8)
            if body_code.strip():
                cs.append(body_code)
            # parse menu options (choices indented > mindent)
            options = []  # (line_no, choice_text, body_first, body_last, jump_target)
            j = mi + 1
            while j < next_start:
                ln = lines[j]
                if ln.strip() == '':
                    j += 1
                    continue
                ind = len(ln) - len(ln.lstrip())
                st = ln.strip()
                if ind <= mindent:
                    break
                if st.startswith('#'):
                    j += 1
                    continue
                # 支持 "-text": 与 "-text" if cond:
                m_opt = re.match(r'"([^"]+)"\s*(?:if\s+([^:]+?))?\s*:', st)
                if m_opt and ind == mindent + 4:
                    choice = m_opt.group(1)
                    opt_cond_raw = m_opt.group(2)  # 原始 if 条件，None 表示无条件
                    body_first = j + 1
                    k = body_first
                    body_last = j
                    while k < next_start:
                        lnk = lines[k]
                        if lnk.strip() == '':
                            k += 1
                            continue
                        indk = len(lnk) - len(lnk.lstrip())
                        if indk <= ind:
                            break
                        body_last = k
                        k += 1
                    # find last jump in body
                    jump_target = None
                    for kk in range(body_first, body_last+1):
                        stk = lines[kk].strip()
                        jm = re.match(r'jump\s+(\w+)', stk)
                        if jm:
                            jump_target = jm.group(1)
                    options.append((j+1, choice, body_first, body_last, jump_target, opt_cond_raw))
                    j = k
                    continue
                j += 1
            # emit OpenSelectMenu
            talks = ', '.join(f'"{cs_string(o[1])}"' for o in options)
            jumps_list = []
            for oi, (_, choice, _, _, _, _) in enumerate(options):
                pinyin_safe = pinyin_ascii(choice)
                jumps_list.append(f'"label_{class_name}_menu_{menu_counter}_{pinyin_safe}"')
            jumps = ', '.join(jumps_list)
            # 条件：无 if 用 "NONE"，有 if 用 cs 形式条件字符串（C# 解析层会再求值）
            cond_strs = []
            for (_, _, _, _, _, opt_cond_raw) in options:
                if opt_cond_raw is None:
                    cond_strs.append('"NONE"')
                else:
                    cond_strs.append(f'"{cs_string(translate_cond(opt_cond_raw))}"')
            conds = ', '.join(cond_strs)
            cs.append('        yield return _gameMethods.OpenSelectMenu(')
            cs.append(f'            talk: new List<string>{{{talks}}},')
            cs.append(f'            jump: new List<string>{{{jumps}}},')
            cs.append(f'            condition: new List<string>{{{conds}}}')
            cs.append('        );')
            # record menu entries
            for oi, (opt_line, choice, bf, bl, jt, _opt_cond) in enumerate(options):
                menu_entries.append((menu_counter, oi, pinyin_ascii(choice), bf, bl, jt, choice, opt_line))
            menu_counter += 1
            cursor = next_start  # skip rest of this label (it's the menu body + the next label below)
            break  # assume only one menu per label for this file
        # remaining body after menu or if no menu
        if not inner_menus:
            body_code = process_lines(lines, id_map, cursor+1, next_start, indent=8)
            if body_code.strip():
                cs.append(body_code)
        # tail: last statement might be `jump fanhuitu`
        # already handled by process_lines's jump handling
        cs.append('    }')
        cs.append('')

    cs.append('}')

    # menu file
    for (mc, oi, pinyin, bf, bl, jt, choice, opt_line) in menu_entries:
        menu_cs.append(f'    // "{cs_string(choice)}" 分支 (rpy L{opt_line})')
        menu_cs.append(f'    public IEnumerator label_{class_name}_menu_{mc}_{pinyin}()')
        menu_cs.append('    {')
        body_code = process_lines(lines, id_map, bf+1, bl+1, indent=8)
        body_has_jump = 'ChangeLabelTo' in body_code
        if body_code.strip():
            menu_cs.append(body_code)
        if jt and not body_has_jump:
            menu_cs.append(f'        yield return _gameMethods.ChangeLabelTo("label_{jt}");')
        menu_cs.append('    }')
        menu_cs.append('')
    menu_cs.append('}')

    with open(cs_out, 'w', encoding='utf-8') as f:
        f.write('\n'.join(cs) + '\n')
    with open(menu_out, 'w', encoding='utf-8') as f:
        f.write('\n'.join(menu_cs) + '\n')

    print(f'Wrote {cs_out} ({len(cs)} lines)')
    print(f'Wrote {menu_out} ({len(menu_cs)} lines)')


PINYIN_MAP = {
    '出手': 'chushou', '什么约定': 'shenmeyueding', '约定': 'yueding',
    '说服': 'shuofu', '现在': 'xianzai', '等等': 'dengdeng', '爱你': 'aini',
}


def pinyin_ascii(s):
    import hashlib, base64
    s = s.lstrip('-—').strip()
    s = s.rstrip('？?!！。')
    if s in PINYIN_MAP:
        return PINYIN_MAP[s]
    # 纯 ASCII 时直接 lower
    out = ''.join(ch for ch in s if ch.isascii() and (ch.isalnum() or ch == '_'))
    if out:
        return out.lower()
    # 稳定 8 字符 base64 兜底（对齐既有 zhuxian_1/2/3_menu 8 字符风格）
    digest = hashlib.md5(s.encode('utf-8')).digest()
    b64 = base64.urlsafe_b64encode(digest).decode('ascii').rstrip('=').replace('-', '_')
    return b64[:8]


if __name__ == '__main__':
    main()
