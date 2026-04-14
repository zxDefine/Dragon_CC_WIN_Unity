"""审计现有 cs 文件的 if 条件是否正确转译自对应 rpy 的 if。

策略：
1. 对每个 rpy 文件，提取所有 `if ... :` 语句及其原文。
2. 统计 `and` / `or` 操作符数量，和完整操作数列表。
3. 对应的 cs 文件，提取所有 `if (...)` 语句。
4. 按操作数名称（变量名）做启发式匹配：把 rpy 变量名规范化到 cs 命名（persistent.xx → Defaults.Persistent.Xx）。
5. 对比：如果 cs 的 if 条件缺少某个 rpy 操作数 → 报告 bug。
"""
import os
import sys
import io
import re

sys.stdout = io.TextIOWrapper(sys.stdout.buffer, encoding='utf-8')

RPY_ROOT = r'h:/Programming/ProjDragon/dragon_cc_win/dragon_yuanban/game/rpy/zhuxian'
CS_ROOT = r'h:/Programming/ProjDragon/dragon_cc_win/dragon_unity/Dragon/Assets/Script/GameScript/game/rpy/zhuxian'

# rpy → [cs 文件列表]（主文件 + _menu.cs，因为 menu 分支的代码在 _menu.cs 中）
RPY_TO_CS = {
    'end/end3.rpy': ['end/end3.cs', 'end/end3_menu.cs'],
    'end/end5.rpy': ['end/end5.cs', 'end/end5_menu.cs'],
    'end/end6.rpy': ['end/end6.cs', 'end/end6_menu.cs'],
    'zhuxian0.rpy': ['zhuxian0.cs', 'zhuxian0_menu.cs'],
    'zhuxian4.rpy': ['zhuxian4.cs', 'zhuxian4_menu.cs'],
    'zhuxian_1.rpy': ['zhuxian_1.cs', 'zhuxian_1_menu.cs'],
    'zhuxian_2.rpy': ['zhuxian_2.cs', 'zhuxian_2_menu.cs'],
    'zhuxian_3.rpy': ['zhuxian_3.cs', 'zhuxian_3_menu.cs'],
    'wangzi.rpy': ['wangzi.cs', 'wangzi_menu.cs'],
}


def extract_rpy_ifs(rpy_path):
    """返回 [(line_num, full_condition_text, [operands])]。"""
    with open(rpy_path, 'r', encoding='utf-8') as f:
        lines = f.readlines()
    result = []
    for i, ln in enumerate(lines, 1):
        s = ln.strip()
        if s.startswith('#'):
            continue
        m = re.match(r'^(?:el)?if\s+(.*?):\s*(?:#.*)?$', s)
        if m:
            cond = m.group(1).strip()
            # 拆分为 operands（只关心 and/or 连接的字面操作数）
            # 先把 and/or 当分隔符
            parts = re.split(r'\s+(?:and|or)\s+', cond)
            operands = [p.strip() for p in parts]
            result.append((i, cond, operands))
    return result


def extract_cs_ifs(cs_path):
    with open(cs_path, 'r', encoding='utf-8') as f:
        lines = f.readlines()
    result = []
    for i, ln in enumerate(lines, 1):
        s = ln.strip()
        m = re.match(r'^(?:else\s+)?if\s*\((.+)\)\s*\{?\s*$', s)
        if m:
            cond = m.group(1).strip()
            result.append((i, cond))
    return result


def normalize_rpy_var(rpy_var):
    """将 rpy 变量名映射到 cs 形式。

    rpy: persistent.jq_11_7 → cs: Defaults.Persistent.Jq_11_7
    rpy: haogandu_he → cs: Defaults.Haogandu_he
    """
    rpy_var = rpy_var.strip()
    if rpy_var.startswith('persistent.'):
        suffix = rpy_var[len('persistent.'):]
        # PascalCase: only first letter uppercase (Unity convention in existing cs)
        parts = suffix.split('.')
        cs_parts = [p[0].upper() + p[1:] for p in parts if p]
        return 'Defaults.Persistent.' + '.'.join(cs_parts)
    # Plain variable
    return 'Defaults.' + rpy_var[0].upper() + rpy_var[1:] if rpy_var else rpy_var


def extract_var_names(operand):
    """从一个操作数如 `persistent.jq_11_7 == 1` 提取变量名。"""
    # 处理 != == >= <= > <  -> split
    m = re.match(r'^\s*(!?\s*)?([a-zA-Z_][\w.]*)\s*(?:[=!<>]+\s*.*)?$', operand.strip())
    if m:
        return m.group(2)
    return None


def main():
    bugs = []  # (rpy_file, rpy_line, rpy_cond, cs_file, cs_line, cs_cond, missing)
    for rpy_rel, cs_rels in RPY_TO_CS.items():
        rpy_path = os.path.join(RPY_ROOT, rpy_rel.replace('/', os.sep))
        if not os.path.exists(rpy_path):
            continue

        # 汇总所有 cs 候选文件的 if 列表
        cs_if_pool = []  # [(cs_rel, line, cond)]
        for cs_rel in cs_rels:
            cs_path = os.path.join(CS_ROOT, cs_rel.replace('/', os.sep))
            if not os.path.exists(cs_path):
                continue
            for cl, cc in extract_cs_ifs(cs_path):
                cs_if_pool.append((cs_rel, cl, cc))

        rpy_ifs = extract_rpy_ifs(rpy_path)
        multi_ifs = [r for r in rpy_ifs if len(r[2]) >= 2]

        for r_line, r_cond, r_ops in multi_ifs:
            r_vars = set()
            for op in r_ops:
                v = extract_var_names(op)
                if v:
                    r_vars.add(v)

            cs_forms = {v: normalize_rpy_var(v) for v in r_vars}
            last_var = extract_var_names(r_ops[-1])
            if not last_var:
                continue
            last_cs = cs_forms[last_var]
            last_simple = last_cs.split('.')[-1]

            candidates = [(cr, cl, cc) for cr, cl, cc in cs_if_pool
                          if last_simple in cc]
            if not candidates:
                continue

            found_full = False
            best = None
            for cr, cl, cc in candidates:
                missing = []
                for v, cs_form in cs_forms.items():
                    simple_name = cs_form.split('.')[-1]
                    if simple_name not in cc:
                        missing.append(v)
                if not missing:
                    found_full = True
                    break
                if best is None or len(missing) < len(best[3]):
                    best = (cr, cl, cc, missing)

            if not found_full and best:
                bugs.append((
                    rpy_rel, r_line, r_cond,
                    best[0], best[1], best[2], best[3],
                ))

    print(f"发现 {len(bugs)} 处疑似 if 条件简化 bug")
    print("=" * 70)
    for rpy_f, rpy_l, rpy_c, cs_f, cs_l, cs_c, missing in bugs:
        print(f"\n📍 {rpy_f}:L{rpy_l}")
        print(f"   rpy:  if {rpy_c}:")
        print(f"   cs:   {cs_f}:L{cs_l}")
        print(f"         if ({cs_c[:150]})")
        print(f"   缺失变量: {missing}")


if __name__ == '__main__':
    main()
