using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace PrinterSwitcher
{
    /// <summary>
    /// Minimal i18n helper — supports Chinese (default) and English.
    /// Add more languages by extending the dictionaries.
    /// </summary>
    internal static class I18n
    {
        private static bool _isChinese = true; // 默认中文
        private static readonly string ConfigFile = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "APS", "language.json");
        
        public static bool IsChinese 
        { 
            get => _isChinese; 
            set 
            {
                _isChinese = value;
                SaveLanguageSetting();
            }
        }

        /// <summary>
        /// 加载语言设置
        /// </summary>
        public static void LoadLanguageSetting()
        {
            try
            {
                if (File.Exists(ConfigFile))
                {
                    string json = File.ReadAllText(ConfigFile);
                    var settings = System.Text.Json.JsonSerializer.Deserialize<LanguageSettings>(json);
                    _isChinese = settings?.IsChinese ?? true;
                }
            }
            catch
            {
                // 如果读取失败，使用默认中文
                _isChinese = true;
            }
        }

        /// <summary>
        /// 保存语言设置
        /// </summary>
        private static void SaveLanguageSetting()
        {
            try
            {
                string dir = Path.GetDirectoryName(ConfigFile);
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                var settings = new LanguageSettings { IsChinese = _isChinese };
                string json = System.Text.Json.JsonSerializer.Serialize(settings);
                File.WriteAllText(ConfigFile, json);
            }
            catch
            {
                // 保存失败时忽略
            }
        }

        private class LanguageSettings
        {
            public bool IsChinese { get; set; }
        }

        private static readonly Dictionary<string, string> Zh = new Dictionary<string, string>
        {
            // Main form
            ["APSTitle"] = "自动打印机切换器",
            ["RefreshProcesses"] = "刷新进程列表",
            ["ChangeDefaultPrinter"] = "更改默认打印机",
            ["Program"] = "程序",
            ["PrintsTo"] = "打印机",
            ["Type"] = "类型",
            ["StartWithWindows"] = "开机自启（自动切换）",
            ["DefaultPrinter"] = "默认打印机",
            ["ChangedDefaultTo"] = "已将默认打印机更改为",

            // Tray context menu
            ["About"] = "关于",
            ["RestoreAPS"] = "显示主窗口",
            ["StartupOptions"] = "启动选项",
            ["AutoStartOnLogon"] = "登录时自动启动",
            ["MinimizeToTrayOnStartup"] = "启动时最小化到托盘",
            ["Language"] = "语言",
            ["Chinese"] = "中文",
            ["English"] = "English",
            ["Quit"] = "退出",

            // Edit/Remove mapping
            ["EditMapping"] = "编辑映射",
            ["RemoveMapping"] = "删除映射",
            ["AreYouSureRemove"] = "确认删除进程 \"{0}\" 的打印机映射？",
            ["RemoveMappingTitle"] = "删除映射",

            // Printer selection
            ["MapPrinterFor"] = "为 [{0}] 选择打印机",
            ["AvailablePrinters"] = "可用打印机",
            ["PleaseChoosePrinter"] = "请先选择一台打印机",
            ["ChoosePrinter"] = "选择打印机",
            ["Okay"] = "确定",
            ["Cancel"] = "取消",

            // About
            ["AboutTitle"] = "关于 自动打印机切换器",
            ["AboutDesc"] = "根据当前前台程序自动切换默认打印机。\n\n版本: {0}\n\n开源地址: github.com/faisalthaheem/automatic-printer-switcher",

            // Errors
            ["ErrorLoadingMappings"] = "加载保存的映射时出错，文件可能已损坏。",
            ["LoadMappingTitle"] = "加载映射",
            ["ErrorSavingMappings"] = "保存映射时出错",
            ["SaveMappingTitle"] = "保存映射",
            ["AutoStartConfigError"] = "自动启动配置出错",

            // Status bar
            ["APSFeedback"] = "自动打印机切换器 v2.3",
            ["FeedbackTooltip"] = "有问题？去 GitHub 反馈",
            ["RefreshHint"] = "点击刷新以查看运行中的程序",
        };

        public static string T(string key)
        {
            if (IsChinese) 
            {
                return Zh.TryGetValue(key, out string val) ? val : key;
            }
            // 英文：返回 key（key 本身就是英文文本）
            return key;
        }

        public static string T(string key, params object[] args)
        {
            string s = T(key);
            return string.Format(s, args);
        }

        /// <summary>
        /// Apply Chinese text to a form and all its controls (recursive).
        /// Uses Tag or Name to map keys.
        /// </summary>
        public static void ApplyToForm(Form form)
        {
            if (!IsChinese) return;

            // Walk all controls
            ApplyToControl(form);
        }

        private static void ApplyToControl(Control ctrl)
        {
            // Apply based on known control names
            if (ctrl.Name == "chkAutoStart") ctrl.Text = T("StartWithWindows");
            if (ctrl.Text == "Program") ctrl.Text = T("Program");
            if (ctrl.Text == "Prints to") ctrl.Text = T("PrintsTo");
            if (ctrl.Text == "Type") ctrl.Text = T("Type");

            if (ctrl is ListView lv)
            {
                foreach (ColumnHeader col in lv.Columns)
                {
                    if (col.Text == "Program") col.Text = T("Program");
                    if (col.Text == "Prints to") col.Text = T("PrintsTo");
                    if (col.Text == "Type") col.Text = T("Type");
                }
            }

            foreach (Control child in ctrl.Controls)
                ApplyToControl(child);
        }

        private static void ApplyToToolStrip(frmV2 form)
        {
            if (form == null) return;

            // These controls are generated by the Designer with public access
            // If access errors occur here, change the field declarations in frmV2.Designer.cs
            // to remove the 'private' modifier or add [System.ComponentModel.AccessibleObject]
        }
    }
}
