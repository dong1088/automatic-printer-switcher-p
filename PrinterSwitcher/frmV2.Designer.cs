namespace PrinterSwitcher
{
    partial class frmV2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmV2));
            this.menuStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDefaultPrinter = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lvProcesses = new System.Windows.Forms.ListView();
            this.lvProcessesName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvProcessesPrinter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cntxtMnuProcesses = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editMappingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeMappingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cntxtMnuWindows = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editMappingWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.removeMappingWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.cntxtMnuNotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.checkingForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactComputedSynergyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportBugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.restoreAPSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.startupOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automaticallyStartWhenILogOnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrWindowCheck = new System.Windows.Forms.Timer(this.components);
            toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.cntxtMnuProcesses.SuspendLayout();
            this.cntxtMnuWindows.SuspendLayout();
            this.cntxtMnuNotifyIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            toolStripStatusLabel1.ForeColor = System.Drawing.Color.Gray;
            toolStripStatusLabel1.IsLink = true;
            toolStripStatusLabel1.LinkColor = System.Drawing.Color.Gray;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new System.Drawing.Size(462, 17);
            toolStripStatusLabel1.Spring = true;
            toolStripStatusLabel1.Text = "v2.3 · 双击进程即可设置打印机映射";
            toolStripStatusLabel1.ToolTipText = "打开 GitHub 项目主页";
            toolStripStatusLabel1.VisitedLinkColor = System.Drawing.Color.Gray;
            toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbRefresh,
            this.toolStripSeparator4,
            this.tsbDefaultPrinter});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(680, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(88, 22);
            this.tsbRefresh.Text = "刷新进程";
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbDefaultPrinter
            // 
            this.tsbDefaultPrinter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbDefaultPrinter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsbDefaultPrinter.Name = "tsbDefaultPrinter";
            this.tsbDefaultPrinter.Size = new System.Drawing.Size(110, 22);
            this.tsbDefaultPrinter.Text = "默认打印机";
            this.tsbDefaultPrinter.Click += new System.EventHandler(this.tsbDefaultPrinter_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 225);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(680, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // lvProcesses
            // 
            this.lvProcesses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvProcessesName,
            this.lvProcessesPrinter});
            this.lvProcesses.ContextMenuStrip = this.cntxtMnuProcesses;
            this.lvProcesses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvProcesses.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvProcesses.FullRowSelect = true;
            this.lvProcesses.Location = new System.Drawing.Point(0, 25);
            this.lvProcesses.Name = "lvProcesses";
            this.lvProcesses.Size = new System.Drawing.Size(680, 200);
            this.lvProcesses.TabIndex = 0;
            this.lvProcesses.UseCompatibleStateImageBehavior = false;
            this.lvProcesses.View = System.Windows.Forms.View.Details;
            this.lvProcesses.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvProcesses_ColumnClick);
            this.lvProcesses.SelectedIndexChanged += new System.EventHandler(this.lvProcesses_SelectedIndexChanged);
            // 
            // lvProcessesName
            // 
            this.lvProcessesName.Text = "程序";
            this.lvProcessesName.Width = 300;
            // 
            // lvProcessesPrinter
            // 
            this.lvProcessesPrinter.Text = "打印机";
            this.lvProcessesPrinter.Width = 350;
            // 
            // cntxtMnuProcesses
            // 
            this.cntxtMnuProcesses.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editMappingToolStripMenuItem,
            this.removeMappingToolStripMenuItem});
            this.cntxtMnuProcesses.Name = "cntxtMnuProcesses";
            this.cntxtMnuProcesses.Size = new System.Drawing.Size(169, 48);
            this.cntxtMnuProcesses.Opening += new System.ComponentModel.CancelEventHandler(this.cntxtMnuProcesses_Opening);
            // 
            // editMappingToolStripMenuItem
            // 
            this.editMappingToolStripMenuItem.Name = "editMappingToolStripMenuItem";
            this.editMappingToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.editMappingToolStripMenuItem.Text = "编辑映射";
            this.editMappingToolStripMenuItem.Click += new System.EventHandler(this.editMappingToolStripMenuItem_Click);
            // 
            // removeMappingToolStripMenuItem
            // 
            this.removeMappingToolStripMenuItem.Name = "removeMappingToolStripMenuItem";
            this.removeMappingToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.removeMappingToolStripMenuItem.Text = "删除映射";
            this.removeMappingToolStripMenuItem.Click += new System.EventHandler(this.removeMappingToolStripMenuItem_Click);
            // 
            // cntxtMnuWindows
            // 
            this.cntxtMnuWindows.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editMappingWindow,
            this.removeMappingWindow});
            this.cntxtMnuWindows.Name = "cntxtMnuWindows";
            this.cntxtMnuWindows.Size = new System.Drawing.Size(169, 48);
            this.cntxtMnuWindows.Opening += new System.ComponentModel.CancelEventHandler(this.cntxtMnuWindows_Opening);
            // 
            // editMappingWindow
            // 
            this.editMappingWindow.Name = "editMappingWindow";
            this.editMappingWindow.Size = new System.Drawing.Size(168, 22);
            this.editMappingWindow.Text = "编辑映射";
            this.editMappingWindow.Click += new System.EventHandler(this.editMappingWindow_Click);
            // 
            // removeMappingWindow
            // 
            this.removeMappingWindow.Name = "removeMappingWindow";
            this.removeMappingWindow.Size = new System.Drawing.Size(168, 22);
            this.removeMappingWindow.Text = "删除映射";
            this.removeMappingWindow.Click += new System.EventHandler(this.removeMappingWindow_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.cntxtMnuNotifyIcon;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "自动打印机切换器";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // cntxtMnuNotifyIcon
            // 
            this.cntxtMnuNotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkingForUpdatesToolStripMenuItem,
            this.toolStripSeparator2,
            this.aboutToolStripMenuItem,
            this.contactComputedSynergyToolStripMenuItem,
            this.reportBugToolStripMenuItem,
            this.toolStripSeparator3,
            this.restoreAPSToolStripMenuItem,
            this.toolStripSeparator1,
            this.startupOptionsToolStripMenuItem,
            this.toolStripSeparator5,
            this.quitToolStripMenuItem});
            this.cntxtMnuNotifyIcon.Name = "cntxtMnuNotifyIcon";
            this.cntxtMnuNotifyIcon.Size = new System.Drawing.Size(222, 182);
            this.cntxtMnuNotifyIcon.Opening += new System.ComponentModel.CancelEventHandler(this.cntxtMnuNotifyIcon_Opening);
            // 
            // checkingForUpdatesToolStripMenuItem
            // 
            this.checkingForUpdatesToolStripMenuItem.Enabled = false;
            this.checkingForUpdatesToolStripMenuItem.Name = "checkingForUpdatesToolStripMenuItem";
            this.checkingForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.checkingForUpdatesToolStripMenuItem.Text = "检查更新 / Check for Updates";
            this.checkingForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkingForUpdatesToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(218, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.aboutToolStripMenuItem.Text = "关于";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // contactComputedSynergyToolStripMenuItem
            // 
            this.contactComputedSynergyToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.contactComputedSynergyToolStripMenuItem.Text = "项目主页";
            this.contactComputedSynergyToolStripMenuItem.Click += new System.EventHandler(this.contactComputedSynergyToolStripMenuItem_Click);
            // 
            // reportBugToolStripMenuItem
            // 
            this.reportBugToolStripMenuItem.Name = "reportBugToolStripMenuItem";
            this.reportBugToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.reportBugToolStripMenuItem.Text = "反馈问题";
            this.reportBugToolStripMenuItem.Click += new System.EventHandler(this.reportBugToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(218, 6);
            // 
            // restoreAPSToolStripMenuItem
            // 
            this.restoreAPSToolStripMenuItem.Name = "restoreAPSToolStripMenuItem";
            this.restoreAPSToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.restoreAPSToolStripMenuItem.Text = "显示主窗口";
            this.restoreAPSToolStripMenuItem.Click += new System.EventHandler(this.restoreAPSToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(218, 6);
            // 
            // startupOptionsToolStripMenuItem
            // 
            this.startupOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.automaticallyStartWhenILogOnToolStripMenuItem});
            this.startupOptionsToolStripMenuItem.Name = "startupOptionsToolStripMenuItem";
            this.startupOptionsToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.startupOptionsToolStripMenuItem.Text = "启动选项";
            // 
            // automaticallyStartWhenILogOnToolStripMenuItem
            // 
            this.automaticallyStartWhenILogOnToolStripMenuItem.Name = "automaticallyStartWhenILogOnToolStripMenuItem";
            this.automaticallyStartWhenILogOnToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.automaticallyStartWhenILogOnToolStripMenuItem.Text = "登录时自动启动";
            this.automaticallyStartWhenILogOnToolStripMenuItem.Click += new System.EventHandler(this.automaticallyStartWhenILogOnToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(218, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.quitToolStripMenuItem.Text = "退出";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // tmrWindowCheck
            // 
            this.tmrWindowCheck.Interval = 2000;
            this.tmrWindowCheck.Tick += new System.EventHandler(this.tmrWindowCheck_Tick);
            // 
            // frmV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 247);
            this.Controls.Add(this.lvProcesses);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmV2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "自动打印机切换器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmV2_FormClosing);
            this.Load += new System.EventHandler(this.frmV2_Load);
            this.Resize += new System.EventHandler(this.frmV2_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.cntxtMnuProcesses.ResumeLayout(false);
            this.cntxtMnuWindows.ResumeLayout(false);
            this.cntxtMnuNotifyIcon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolStrip menuStrip1;
        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ListView lvProcesses;
        public System.Windows.Forms.ColumnHeader lvProcessesName;
        public System.Windows.Forms.ColumnHeader lvProcessesPrinter;
        public System.Windows.Forms.NotifyIcon notifyIcon1;
        public System.Windows.Forms.ContextMenuStrip cntxtMnuNotifyIcon;
        public System.Windows.Forms.ToolStripMenuItem checkingForUpdatesToolStripMenuItem;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem contactComputedSynergyToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem reportBugToolStripMenuItem;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ToolStripMenuItem restoreAPSToolStripMenuItem;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripMenuItem startupOptionsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem automaticallyStartWhenILogOnToolStripMenuItem;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        public System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        public System.Windows.Forms.ContextMenuStrip cntxtMnuProcesses;
        public System.Windows.Forms.ContextMenuStrip cntxtMnuWindows;
        public System.Windows.Forms.ToolStripMenuItem editMappingToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem removeMappingToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem editMappingWindow;
        public System.Windows.Forms.ToolStripMenuItem removeMappingWindow;
        public System.Windows.Forms.Timer tmrWindowCheck;
        public System.Windows.Forms.ToolStripButton tsbRefresh;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        public System.Windows.Forms.ToolStripButton tsbDefaultPrinter;
        public System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}