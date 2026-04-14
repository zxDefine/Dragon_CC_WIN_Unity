# 资源规格与迁移清单

> 维护者：技术美术  
> 创建日期：2026-04-07  
> 最后更新：2026-04-07

---

## 1. 资源迁移总览

| 资源类型 | Renpy 数量 | Unity 数量 | 完成率 | 磁盘占用 |
|---|---|---|---|---|
| 图片（images/） | 1,830 | 1,830 | **100%** | 701 MB |
| 音频（audio/） | 3,066 | 3,011 | **98.2%** | 633 MB |
| GUI（gui/） | 512 | 502 | **98%** | 24 MB |
| 中间数据 | — | 5 | 新建 | < 1 MB |
| 字体 | 2 | 2 | **100%** | — |
| **总计** | **5,410** | **5,345** | **98.8%** | **约 1.4 GB** |

---

## 2. 路径映射规范

| Renpy 路径 | Unity Addressable 地址 |
|---|---|
| `images/{path}` | `Assets/RenpyResources/images/{path}` |
| `audio/{path}` | `Assets/RenpyResources/audio/{path}` |
| `gui/{path}` | `Assets/RenpyResources/gui/{path}` |

规则：Renpy 路径前加 `Assets/RenpyResources/` 前缀，路径分隔符统一使用正斜杠 `/`。

---

## 3. 图片资源详情

### 3.1 按子目录分布

| 子目录 | 文件数 | 大小 | 说明 |
|---|---|---|---|
| images/cg/ | 534 | 272 MB | CG 插图（全屏高分辨率） |
| images/lihui/ | 558 | 66 MB | 角色立绘（带透明通道） |
| images/bg/ | 115 | 169 MB | 背景图 |
| images/demo_images/ | 482 | 178 MB | 含背景/CG/立绘/道具/转场 |
| images/daoju/ | 114 | 14 MB | 道具图片 |
| images/texiao/ | 25 | 3.1 MB | 特效图片 |

### 3.2 迁移状态
- **100% 完整**，无缺失文件
- 目录结构完全镜像

### 3.3 导入设置建议

| 图片类型 | PC 压缩格式 | 移动端格式 | Max Size | Mipmap |
|---|---|---|---|---|
| CG 插图 | BC7 | ASTC 6×6 | 2048 | 关闭 |
| 背景 | BC7 (RGB) | ASTC 8×8 | 2048 | 关闭 |
| 角色立绘 | BC7 (RGBA) | ASTC 6×6 | 2048 | 关闭 |
| GUI 元素 | BC7 (RGBA) | ASTC 4×4 | 原始 | 关闭 |
| 特效/道具 | BC7 | ASTC 6×6 | 1024 | 关闭 |

### 3.4 图集策略

| 资源组 | 策略 |
|---|---|
| GUI 小图标（gui/bar/、gui/button/等） | 合并为 SpriteAtlas |
| 角色立绘部件 | **不建议图集**（运行时按需组合） |
| CG / 背景 | **不建议图集**（单张尺寸大） |
| 序列帧动画（feather 80帧） | 转换为 SpriteSheet 或视频 |

---

## 4. 音频资源详情

### 4.1 按子目录分布

| 子目录 | 文件数 | 大小 | 格式 |
|---|---|---|---|
| audio/music/ | 63 | 169 MB | MP3/OGG |
| audio/demo_audio/music/ | 16 | — | MP3 |
| audio/sound/ | 238 | 69 MB | OGG/MP3 |
| audio/demo_audio/sound/ | 60 | — | OGG/MP3 |
| audio/voice/ | 2,688 | 344 MB | OGG |
| audio/video/ | 1 | — | WEBM |

### 4.2 缺失文件（待补充）

| 文件 | 数量 | 说明 | 优先级 |
|---|---|---|---|
| `audio/voice/testa1_*.ogg` | 54 | 正式语音文件 | P1 |
| `audio/video/test1.webm` | 1 | 水下视频素材 | P1 |

### 4.3 导入设置建议

| 音频类型 | Load Type | 压缩格式 | 说明 |
|---|---|---|---|
| BGM（music/） | **Streaming** | Vorbis | 避免全量加载到内存 |
| 音效（sound/） | Decompress On Load（短）/ Compressed In Memory（长） | Vorbis | 按时长区分 |
| 语音（voice/） | **Streaming** | Vorbis | 344 MB 不可能常驻 |

---

## 5. GUI 资源详情

### 5.1 迁移状态

- **98% 完整**
- 缺失：`gui/xd/` 目录（10 个文件）

### 5.2 缺失文件（待补充）

| 文件 | 说明 | 优先级 |
|---|---|---|
| `gui/xd/age_btn.png` | 年龄验证按钮 | P2 |
| `gui/xd/age_msg.png` | 年龄提示 | P2 |
| `gui/xd/agreementText.png` | 协议文字 | P2 |
| `gui/xd/agreementTextOK.png` | 协议确认 | P2 |
| `gui/xd/health_tip.png` | 健康提示 | P2 |
| `gui/xd/login_bg.png` | 登录背景 | P2 |
| `gui/xd/login_btn.png` | 登录按钮 | P2 |
| `gui/xd/privacyAgreement.png` | 隐私协议 | P2 |
| `gui/xd/userAgreement.png` | 用户协议 | P2 |
| `gui/xd/user_center_btn.png` | 用户中心按钮 | P2 |

---

## 6. 中间数据文件

| 文件 | 位置 | 说明 |
|---|---|---|
| `labels.txt` | RenpyResources/middle_data/ | label 注册表 |
| `dialogues.txt` | RenpyResources/middle_data/ | 对话文本库 |
| `character.json` | RenpyResources/middle_data/ | 角色定义 |
| `image.json` | RenpyResources/middle_data/ | 图片/layered image 定义 |
| `ButtonTemplate.prefab` | RenpyResources/middle_data/ | 按钮模板 |

---

## 7. 需要新建的资源

### 7.1 Shader 文件

| Shader | 用途 | 优先级 |
|---|---|---|
| ImageDissolve.shader | 遮罩溶解转场 | P0 |
| GaussianBlur.shader | 高斯模糊 | P0 |
| MatrixColor.shader | 色彩矩阵变换 | P0 |
| AdditiveBlend.shader | 叠加混合 | P1 |
| MultiplyBlend.shader | 乘法混合（腮红等） | P1 |
| Glitch.shader | 故障效果 | P2 |

### 7.2 转场遮罩图

需确认以下遮罩图已在 Unity 项目中可用：
- `waves.jpg` — 波纹溶解用
- `eye.png` — 眨眼效果用

---

## 8. Addressable Assets 分组建议

### 8.1 当前分组

| Group | 内容 |
|---|---|
| Audio | 全部音频 |
| Images | 全部图片 |
| GUI | 全部 GUI |
| MiddleData | 数据文件 |

### 8.2 建议优化

| 新 Group | 内容 | 理由 |
|---|---|---|
| Audio_Music | music/ | BGM 独立管理 |
| Audio_Voice | voice/ | 大量文件独立分组 |
| Audio_SFX | sound/ | 音效独立 |
| Images_CG | images/cg/ | 大图按需加载 |
| Images_BG | images/bg/ | 背景按需 |
| Images_Portrait | images/lihui/ | 立绘按需 |
| Images_Other | 其余图片 | — |

---

## 9. 已知资源相关问题

| 问题 | 影响 | 修复方案 |
|---|---|---|
| GameScript 中路径含反斜杠 `\` | 资源加载失败 | 批量替换为 `/` |
| blend "multiply" 未在 image.json 中记录 | 腮红等效果显示错误 | 扩展 image.json 格式 |
| RenpyImage 构造时加载全部纹理 | 启动慢/内存高 | 改为延迟加载 |
| WaitForCompletion 同步阻塞 | 加载卡顿 | 改为异步 |
| Addressables Release 过早 | 循环音频可能被卸载 | 在 Stop 时释放 |
| 序列帧动画（feather 80帧）未优化 | 内存浪费 | 转 SpriteSheet 或视频 |
