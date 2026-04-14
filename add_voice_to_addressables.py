"""将 audio/voice/ 下所有 .ogg 批量加入 Addressables Audio group。

工作原理：直接修改 Audio.asset (YAML)，追加新条目到 m_SerializeEntries 列表末尾，
每条目格式与现有一致。GUID 从对应的 .ogg.meta 文件中读取。
"""
import os
import re
import sys
import io

sys.stdout = io.TextIOWrapper(sys.stdout.buffer, encoding='utf-8')

VOICE_DIR_ABS = r'h:/Programming/ProjDragon/dragon_cc_win/dragon_unity/Dragon/Assets/RenpyResources/audio/voice'
VOICE_ADDR_PREFIX = 'Assets/RenpyResources/audio/voice'
AUDIO_ASSET = r'h:/Programming/ProjDragon/dragon_cc_win/dragon_unity/Dragon/Assets/AddressableAssetsData/AssetGroups/Audio.asset'

GUID_RE = re.compile(r'^guid:\s*([a-f0-9]{32})\s*$', re.M)

ENTRY_TEMPLATE = (
    "  - m_GUID: {guid}\n"
    "    m_Address: {addr}\n"
    "    m_ReadOnly: 0\n"
    "    m_SerializedLabels: []\n"
    "    FlaggedDuringContentUpdateRestriction: 0\n"
)


def read_guid_from_meta(meta_path):
    with open(meta_path, 'r', encoding='utf-8') as f:
        m = GUID_RE.search(f.read())
    return m.group(1) if m else None


def main():
    # 1. 扫描 voice 目录，收集 .ogg + guid
    voice_entries = []  # [(guid, address), ...]
    missing_meta = 0
    for fn in sorted(os.listdir(VOICE_DIR_ABS)):
        if not fn.endswith('.ogg'):
            continue
        meta = os.path.join(VOICE_DIR_ABS, fn + '.meta')
        if not os.path.exists(meta):
            missing_meta += 1
            continue
        guid = read_guid_from_meta(meta)
        if not guid:
            missing_meta += 1
            continue
        address = f"{VOICE_ADDR_PREFIX}/{fn}"
        voice_entries.append((guid, address))

    print(f"voice 目录扫描: {len(voice_entries)} 个 ogg 有 meta")
    if missing_meta:
        print(f"  (跳过 {missing_meta} 个 meta 缺失的)")

    # 2. 读取 Audio.asset，提取已有 GUID 集合
    with open(AUDIO_ASSET, 'r', encoding='utf-8') as f:
        content = f.read()

    existing_guids = set(re.findall(r'- m_GUID:\s*([a-f0-9]{32})', content))
    print(f"Audio group 现有条目: {len(existing_guids)}")

    new_entries = [(g, a) for g, a in voice_entries if g not in existing_guids]
    already = len(voice_entries) - len(new_entries)
    print(f"  已在 group 中: {already}")
    print(f"  待新增: {len(new_entries)}")

    if not new_entries:
        print("无需操作。")
        return

    # 3. 生成新条目文本块（按 guid 字典序，保持与现有一致）
    new_entries.sort(key=lambda x: x[0])
    block = ''.join(ENTRY_TEMPLATE.format(guid=g, addr=a) for g, a in new_entries)

    # 4. 定位插入点：m_SerializeEntries 列表末尾
    # 模式：最后一个条目结尾的 "FlaggedDuringContentUpdateRestriction: 0\n"
    # 紧接着是外层的 "  m_ReadOnly: 0\n" (group 自己的 readonly)
    # 找到 m_SerializeEntries 后第一个 "\n  m_ReadOnly:" (顶格两空格的)
    m = re.search(
        r'(m_SerializeEntries:.*?)(\n  m_ReadOnly:)',
        content,
        re.DOTALL,
    )
    if not m:
        print("❌ 无法定位 m_SerializeEntries 块")
        return

    entries_block = m.group(1)
    # 在该块末尾追加新条目
    new_entries_block = entries_block + '\n' + block.rstrip('\n')
    new_content = content.replace(entries_block, new_entries_block, 1)

    # 5. 写回
    with open(AUDIO_ASSET, 'w', encoding='utf-8', newline='\n') as f:
        f.write(new_content)
    print(f"\n✅ 已写入 {len(new_entries)} 个 voice 条目到 Audio.asset")
    print("请在 Unity 中重新打开 Addressables Groups 窗口确认，然后 Build → New Build → Default Build Script")


if __name__ == '__main__':
    main()
