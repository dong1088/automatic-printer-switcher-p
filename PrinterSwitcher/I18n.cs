using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PrinterSwitcher
{
    /// <summary>
    /// Minimal i18n helper — supports English (default) and Chinese.
    /// Add more languages by extending the dictionaries.
    /// </summary>
    internal static class I18n
    {
        public static bool IsChinese { get; set; } = false;

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
            ["APSFeedback"] = "自动打印机切换器 v2.2",
            ["FeedbackTooltip"] = "有问题？去 GitHub 反馈",
            ["RefreshHint"] = "点击刷新以查看运行中的程序",
        };

        public static string T(string key)
        {
            if (!IsChinese) return key; // For non-standard strings, key == English text
            return Zh.TryGetValue(key, out string val) ? val : key;
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
            ApplyToToolStrip(form as frmV2);
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

            form.tsbRefresh.Text = T("RefreshProcesses");
            form.tsbDefaultPrinter.Text = T("ChangeDefaultPrinter");

            form.aboutToolStripMenuItem.Text = T("About");
            form.restoreAPSToolStripMenuItem.Text = T("RestoreAPS");
            form.startupOptionsToolStripMenuItem.Text = T("StartupOptions");
            form.automaticallyStartWhenILogOnToolStripMenuItem.Text = T("AutoStartOnLogon");
            form.alwaysMinimizeToTrayOnStartupToolStripMenuItem.Text = T("MinimizeToTrayOnStartup");
            form.quitToolStripMenuItem.Text = T("Quit");
            form.langToolStripMenuItem.Text = T("Language");
            form.chineseToolStripMenuItem.Text = T("Chinese");
            form.englishToolStripMenuItem.Text = T("English");
            form.editMappingToolStripMenuItem.Text = T("EditMapping");
            form.removeMappingToolStripMenuItem.Text = T("RemoveMapping");
        }
    }
}
