# Release Notes v2.4.0

## 🐛 Bug 修复 / Bug Fixes

### 中文说明

**v2.4.0 (2026-07-09)**

本版本主要修复了几个重要的 Bug，并改进了代码质量：

- ✅ **修复注册表路径问题** - 修正了注册表路径大小写不一致的问题（`Run` vs `run`），确保开机自启功能正常工作
- ✅ **改进命名规范** - 将类名从 `selfinfo` 重命名为 `SelfInfo`，遵循 C# 命名规范
- ✅ **禁用过时警告** - 在项目文件中禁用了 BinaryFormatter 相关警告
- ✅ **添加安装脚本** - 新增 Inno Setup 安装脚本，方便生成安装包
- ✅ **更新文档** - 更新 README 添加版本历史记录

### 技术细节
- 框架：.NET 8.0 Windows Forms
- 数据存储：JSON 格式
- 兼容性：Windows 10 / 11

---

## English Description

**v2.4.0 (2026-07-09)**

This release focuses on fixing important bugs and improving code quality:

- ✅ **Fixed Registry Path Issue** - Corrected registry path case sensitivity issue (`Run` vs `run`) to ensure auto-start functionality works properly
- ✅ **Improved Naming Conventions** - Renamed class from `selfinfo` to `SelfInfo` following C# naming standards
- ✅ **Disabled Obsolete Warnings** - Disabled BinaryFormatter-related warnings in project file
- ✅ **Added Installer Script** - Added Inno Setup installer script for easier package generation
- ✅ **Updated Documentation** - Updated README with version history

### Technical Details
- Framework: .NET 8.0 Windows Forms
- Data Storage: JSON format
- Compatibility: Windows 10 / 11

---

## 下载 / Download

请从下方的 Assets 区域下载安装文件。

Please download the installer from the Assets section below.

## 安装说明 / Installation Instructions

### 中文
1. 下载 `PrinterSwitcher-2.4.0-setup.exe`
2. 运行安装程序
3. 按照提示完成安装
4. 启动程序并配置打印机映射

### English
1. Download `PrinterSwitcher-2.4.0-setup.exe`
2. Run the installer
3. Follow the prompts to complete installation
4. Launch the program and configure printer mappings

## 许可证 / License

Apache License 2.0