namespace mouseod
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meterOrInchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startWithWindowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coordinatesGroupBox = new System.Windows.Forms.GroupBox();
            this.labelY = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.yAxisLabel = new System.Windows.Forms.Label();
            this.xAxisLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.distanceGroupBox = new System.Windows.Forms.GroupBox();
            this.baseButton = new System.Windows.Forms.Button();
            this.currentButton = new System.Windows.Forms.Button();
            this.baseLengthLabel = new System.Windows.Forms.Label();
            this.baseLabel = new System.Windows.Forms.Label();
            this.baseLabelLabel = new System.Windows.Forms.Label();
            this.totalLengthLabel = new System.Windows.Forms.Label();
            this.currentLengthLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.currentLabel = new System.Windows.Forms.Label();
            this.currentNameLabel = new System.Windows.Forms.Label();
            this.totalLabelLabel = new System.Windows.Forms.Label();
            this.calculationGroupBox = new System.Windows.Forms.GroupBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.baseBox = new System.Windows.Forms.MaskedTextBox();
            this.baseCoefficientLabel = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.globalEventProvider = new Gma.UserActivityMonitor.GlobalEventProvider();
            this.mainMenuStrip.SuspendLayout();
            this.coordinatesGroupBox.SuspendLayout();
            this.distanceGroupBox.SuspendLayout();
            this.calculationGroupBox.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.AccessibleDescription = null;
            this.mainMenuStrip.AccessibleName = null;
            resources.ApplyResources(this.mainMenuStrip, "mainMenuStrip");
            this.mainMenuStrip.BackgroundImage = null;
            this.mainMenuStrip.Font = null;
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Name = "mainMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.AccessibleDescription = null;
            this.fileToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.BackgroundImage = null;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem,
            this.toolStripSeparator2,
            this.hideToolStripMenuItem,
            this.onTopToolStripMenuItem,
            this.meterOrInchToolStripMenuItem,
            this.startWithWindowsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeyDisplayString = null;
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.AccessibleDescription = null;
            this.languageToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            this.languageToolStripMenuItem.BackgroundImage = null;
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.ShortcutKeyDisplayString = null;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.AccessibleDescription = null;
            this.toolStripSeparator2.AccessibleName = null;
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // hideToolStripMenuItem
            // 
            this.hideToolStripMenuItem.AccessibleDescription = null;
            this.hideToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.hideToolStripMenuItem, "hideToolStripMenuItem");
            this.hideToolStripMenuItem.BackgroundImage = null;
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            this.hideToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.hideToolStripMenuItem.Click += new System.EventHandler(this.hideToolStripMenuItem_Click);
            // 
            // onTopToolStripMenuItem
            // 
            this.onTopToolStripMenuItem.AccessibleDescription = null;
            this.onTopToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.onTopToolStripMenuItem, "onTopToolStripMenuItem");
            this.onTopToolStripMenuItem.BackgroundImage = null;
            this.onTopToolStripMenuItem.CheckOnClick = true;
            this.onTopToolStripMenuItem.Name = "onTopToolStripMenuItem";
            this.onTopToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.onTopToolStripMenuItem.Click += new System.EventHandler(this.onTopToolStripMenuItem_Click);
            // 
            // meterOrInchToolStripMenuItem
            // 
            this.meterOrInchToolStripMenuItem.AccessibleDescription = null;
            this.meterOrInchToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.meterOrInchToolStripMenuItem, "meterOrInchToolStripMenuItem");
            this.meterOrInchToolStripMenuItem.BackgroundImage = null;
            this.meterOrInchToolStripMenuItem.CheckOnClick = true;
            this.meterOrInchToolStripMenuItem.Name = "meterOrInchToolStripMenuItem";
            this.meterOrInchToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.meterOrInchToolStripMenuItem.Click += new System.EventHandler(this.meterOrInchToolStripMenuItem_Click);
            // 
            // startWithWindowsToolStripMenuItem
            // 
            this.startWithWindowsToolStripMenuItem.AccessibleDescription = null;
            this.startWithWindowsToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.startWithWindowsToolStripMenuItem, "startWithWindowsToolStripMenuItem");
            this.startWithWindowsToolStripMenuItem.BackgroundImage = null;
            this.startWithWindowsToolStripMenuItem.CheckOnClick = true;
            this.startWithWindowsToolStripMenuItem.Name = "startWithWindowsToolStripMenuItem";
            this.startWithWindowsToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.startWithWindowsToolStripMenuItem.Click += new System.EventHandler(this.startWithWindowsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AccessibleDescription = null;
            this.toolStripSeparator1.AccessibleName = null;
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.AccessibleDescription = null;
            this.exitToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.BackgroundImage = null;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.AccessibleDescription = null;
            this.helpToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            this.helpToolStripMenuItem.BackgroundImage = null;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextToolStripMenuItem,
            this.donateToolStripMenuItem,
            this.homeSiteToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeyDisplayString = null;
            // 
            // contextToolStripMenuItem
            // 
            this.contextToolStripMenuItem.AccessibleDescription = null;
            this.contextToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.contextToolStripMenuItem, "contextToolStripMenuItem");
            this.contextToolStripMenuItem.BackgroundImage = null;
            this.contextToolStripMenuItem.Name = "contextToolStripMenuItem";
            this.contextToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.contextToolStripMenuItem.Click += new System.EventHandler(this.contextToolStripMenuItem_Click);
            // 
            // donateToolStripMenuItem
            // 
            this.donateToolStripMenuItem.AccessibleDescription = null;
            this.donateToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.donateToolStripMenuItem, "donateToolStripMenuItem");
            this.donateToolStripMenuItem.BackgroundImage = null;
            this.donateToolStripMenuItem.Name = "donateToolStripMenuItem";
            this.donateToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.donateToolStripMenuItem.Click += new System.EventHandler(this.donateToolStripMenuItem_Click);
            // 
            // homeSiteToolStripMenuItem
            // 
            this.homeSiteToolStripMenuItem.AccessibleDescription = null;
            this.homeSiteToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.homeSiteToolStripMenuItem, "homeSiteToolStripMenuItem");
            this.homeSiteToolStripMenuItem.BackgroundImage = null;
            this.homeSiteToolStripMenuItem.Name = "homeSiteToolStripMenuItem";
            this.homeSiteToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.homeSiteToolStripMenuItem.Click += new System.EventHandler(this.homeSiteToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.AccessibleDescription = null;
            this.aboutToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.BackgroundImage = null;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // coordinatesGroupBox
            // 
            this.coordinatesGroupBox.AccessibleDescription = null;
            this.coordinatesGroupBox.AccessibleName = null;
            resources.ApplyResources(this.coordinatesGroupBox, "coordinatesGroupBox");
            this.coordinatesGroupBox.BackgroundImage = null;
            this.coordinatesGroupBox.Controls.Add(this.labelY);
            this.coordinatesGroupBox.Controls.Add(this.labelX);
            this.coordinatesGroupBox.Controls.Add(this.yAxisLabel);
            this.coordinatesGroupBox.Controls.Add(this.xAxisLabel);
            this.coordinatesGroupBox.Font = null;
            this.coordinatesGroupBox.Name = "coordinatesGroupBox";
            this.coordinatesGroupBox.TabStop = false;
            // 
            // labelY
            // 
            this.labelY.AccessibleDescription = null;
            this.labelY.AccessibleName = null;
            resources.ApplyResources(this.labelY, "labelY");
            this.labelY.Font = null;
            this.labelY.Name = "labelY";
            // 
            // labelX
            // 
            this.labelX.AccessibleDescription = null;
            this.labelX.AccessibleName = null;
            resources.ApplyResources(this.labelX, "labelX");
            this.labelX.Font = null;
            this.labelX.Name = "labelX";
            // 
            // yAxisLabel
            // 
            this.yAxisLabel.AccessibleDescription = null;
            this.yAxisLabel.AccessibleName = null;
            resources.ApplyResources(this.yAxisLabel, "yAxisLabel");
            this.yAxisLabel.Font = null;
            this.yAxisLabel.Name = "yAxisLabel";
            // 
            // xAxisLabel
            // 
            this.xAxisLabel.AccessibleDescription = null;
            this.xAxisLabel.AccessibleName = null;
            resources.ApplyResources(this.xAxisLabel, "xAxisLabel");
            this.xAxisLabel.Font = null;
            this.xAxisLabel.Name = "xAxisLabel";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // distanceGroupBox
            // 
            this.distanceGroupBox.AccessibleDescription = null;
            this.distanceGroupBox.AccessibleName = null;
            resources.ApplyResources(this.distanceGroupBox, "distanceGroupBox");
            this.distanceGroupBox.BackgroundImage = null;
            this.distanceGroupBox.Controls.Add(this.baseButton);
            this.distanceGroupBox.Controls.Add(this.currentButton);
            this.distanceGroupBox.Controls.Add(this.baseLengthLabel);
            this.distanceGroupBox.Controls.Add(this.baseLabel);
            this.distanceGroupBox.Controls.Add(this.baseLabelLabel);
            this.distanceGroupBox.Controls.Add(this.totalLengthLabel);
            this.distanceGroupBox.Controls.Add(this.currentLengthLabel);
            this.distanceGroupBox.Controls.Add(this.totalLabel);
            this.distanceGroupBox.Controls.Add(this.currentLabel);
            this.distanceGroupBox.Controls.Add(this.currentNameLabel);
            this.distanceGroupBox.Controls.Add(this.totalLabelLabel);
            this.distanceGroupBox.Font = null;
            this.distanceGroupBox.Name = "distanceGroupBox";
            this.distanceGroupBox.TabStop = false;
            // 
            // baseButton
            // 
            this.baseButton.AccessibleDescription = null;
            this.baseButton.AccessibleName = null;
            resources.ApplyResources(this.baseButton, "baseButton");
            this.baseButton.BackgroundImage = null;
            this.baseButton.Font = null;
            this.baseButton.Name = "baseButton";
            this.baseButton.UseVisualStyleBackColor = true;
            this.baseButton.Click += new System.EventHandler(this.baseButton_Click);
            // 
            // currentButton
            // 
            this.currentButton.AccessibleDescription = null;
            this.currentButton.AccessibleName = null;
            resources.ApplyResources(this.currentButton, "currentButton");
            this.currentButton.BackgroundImage = null;
            this.currentButton.Font = null;
            this.currentButton.Name = "currentButton";
            this.currentButton.UseVisualStyleBackColor = true;
            this.currentButton.Click += new System.EventHandler(this.currentButton_Click);
            // 
            // baseLengthLabel
            // 
            this.baseLengthLabel.AccessibleDescription = null;
            this.baseLengthLabel.AccessibleName = null;
            resources.ApplyResources(this.baseLengthLabel, "baseLengthLabel");
            this.baseLengthLabel.Font = null;
            this.baseLengthLabel.Name = "baseLengthLabel";
            // 
            // baseLabel
            // 
            this.baseLabel.AccessibleDescription = null;
            this.baseLabel.AccessibleName = null;
            resources.ApplyResources(this.baseLabel, "baseLabel");
            this.baseLabel.Font = null;
            this.baseLabel.Name = "baseLabel";
            // 
            // baseLabelLabel
            // 
            this.baseLabelLabel.AccessibleDescription = null;
            this.baseLabelLabel.AccessibleName = null;
            resources.ApplyResources(this.baseLabelLabel, "baseLabelLabel");
            this.baseLabelLabel.Font = null;
            this.baseLabelLabel.Name = "baseLabelLabel";
            // 
            // totalLengthLabel
            // 
            this.totalLengthLabel.AccessibleDescription = null;
            this.totalLengthLabel.AccessibleName = null;
            resources.ApplyResources(this.totalLengthLabel, "totalLengthLabel");
            this.totalLengthLabel.Font = null;
            this.totalLengthLabel.Name = "totalLengthLabel";
            // 
            // currentLengthLabel
            // 
            this.currentLengthLabel.AccessibleDescription = null;
            this.currentLengthLabel.AccessibleName = null;
            resources.ApplyResources(this.currentLengthLabel, "currentLengthLabel");
            this.currentLengthLabel.Font = null;
            this.currentLengthLabel.Name = "currentLengthLabel";
            // 
            // totalLabel
            // 
            this.totalLabel.AccessibleDescription = null;
            this.totalLabel.AccessibleName = null;
            resources.ApplyResources(this.totalLabel, "totalLabel");
            this.totalLabel.Font = null;
            this.totalLabel.Name = "totalLabel";
            // 
            // currentLabel
            // 
            this.currentLabel.AccessibleDescription = null;
            this.currentLabel.AccessibleName = null;
            resources.ApplyResources(this.currentLabel, "currentLabel");
            this.currentLabel.Font = null;
            this.currentLabel.Name = "currentLabel";
            // 
            // currentNameLabel
            // 
            this.currentNameLabel.AccessibleDescription = null;
            this.currentNameLabel.AccessibleName = null;
            resources.ApplyResources(this.currentNameLabel, "currentNameLabel");
            this.currentNameLabel.Font = null;
            this.currentNameLabel.Name = "currentNameLabel";
            // 
            // totalLabelLabel
            // 
            this.totalLabelLabel.AccessibleDescription = null;
            this.totalLabelLabel.AccessibleName = null;
            resources.ApplyResources(this.totalLabelLabel, "totalLabelLabel");
            this.totalLabelLabel.Font = null;
            this.totalLabelLabel.Name = "totalLabelLabel";
            // 
            // calculationGroupBox
            // 
            this.calculationGroupBox.AccessibleDescription = null;
            this.calculationGroupBox.AccessibleName = null;
            resources.ApplyResources(this.calculationGroupBox, "calculationGroupBox");
            this.calculationGroupBox.BackgroundImage = null;
            this.calculationGroupBox.Controls.Add(this.resultLabel);
            this.calculationGroupBox.Controls.Add(this.baseBox);
            this.calculationGroupBox.Controls.Add(this.baseCoefficientLabel);
            this.calculationGroupBox.Font = null;
            this.calculationGroupBox.Name = "calculationGroupBox";
            this.calculationGroupBox.TabStop = false;
            // 
            // resultLabel
            // 
            this.resultLabel.AccessibleDescription = null;
            this.resultLabel.AccessibleName = null;
            resources.ApplyResources(this.resultLabel, "resultLabel");
            this.resultLabel.Font = null;
            this.resultLabel.Name = "resultLabel";
            // 
            // baseBox
            // 
            this.baseBox.AccessibleDescription = null;
            this.baseBox.AccessibleName = null;
            resources.ApplyResources(this.baseBox, "baseBox");
            this.baseBox.BackgroundImage = null;
            this.baseBox.Font = null;
            this.baseBox.Name = "baseBox";
            this.baseBox.TextChanged += new System.EventHandler(this.baseBox_TextChanged);
            // 
            // baseCoefficientLabel
            // 
            this.baseCoefficientLabel.AccessibleDescription = null;
            this.baseCoefficientLabel.AccessibleName = null;
            resources.ApplyResources(this.baseCoefficientLabel, "baseCoefficientLabel");
            this.baseCoefficientLabel.Font = null;
            this.baseCoefficientLabel.Name = "baseCoefficientLabel";
            // 
            // notifyIcon
            // 
            resources.ApplyResources(this.notifyIcon, "notifyIcon");
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.AccessibleDescription = null;
            this.contextMenuStrip.AccessibleName = null;
            resources.ApplyResources(this.contextMenuStrip, "contextMenuStrip");
            this.contextMenuStrip.BackgroundImage = null;
            this.contextMenuStrip.Font = null;
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.contextMenuStrip.Name = "contextMenuStrip";
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.AccessibleDescription = null;
            this.showToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.showToolStripMenuItem, "showToolStripMenuItem");
            this.showToolStripMenuItem.BackgroundImage = null;
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.AccessibleDescription = null;
            this.exitToolStripMenuItem1.AccessibleName = null;
            resources.ApplyResources(this.exitToolStripMenuItem1, "exitToolStripMenuItem1");
            this.exitToolStripMenuItem1.BackgroundImage = null;
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.ShortcutKeyDisplayString = null;
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // globalEventProvider
            // 
            this.globalEventProvider.MouseMoveExt += new System.EventHandler<Gma.UserActivityMonitor.MouseEventExtArgs>(this.globalEventProvider_MouseMoveExt);
            this.globalEventProvider.KeyDown += new System.Windows.Forms.KeyEventHandler(this.globalEventProvider_KeyDown);
            this.globalEventProvider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.globalEventProvider_MouseDown);
            this.globalEventProvider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.globalEventProvider_MouseUp);
            this.globalEventProvider.KeyUp += new System.Windows.Forms.KeyEventHandler(this.globalEventProvider_KeyUp);
            // 
            // MainForm
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.calculationGroupBox);
            this.Controls.Add(this.distanceGroupBox);
            this.Controls.Add(this.coordinatesGroupBox);
            this.Controls.Add(this.mainMenuStrip);
            this.Font = null;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.coordinatesGroupBox.ResumeLayout(false);
            this.coordinatesGroupBox.PerformLayout();
            this.distanceGroupBox.ResumeLayout(false);
            this.distanceGroupBox.PerformLayout();
            this.calculationGroupBox.ResumeLayout(false);
            this.calculationGroupBox.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox coordinatesGroupBox;
        private System.Windows.Forms.Label yAxisLabel;
        private System.Windows.Forms.Label xAxisLabel;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.ToolStripMenuItem startWithWindowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private Gma.UserActivityMonitor.GlobalEventProvider globalEventProvider;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem meterOrInchToolStripMenuItem;
        private System.Windows.Forms.GroupBox distanceGroupBox;
        private System.Windows.Forms.Label currentNameLabel;
        private System.Windows.Forms.Label currentLabel;
        private System.Windows.Forms.Label currentLengthLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalLabelLabel;
        private System.Windows.Forms.Label totalLengthLabel;
        private System.Windows.Forms.Label baseLengthLabel;
        private System.Windows.Forms.Label baseLabel;
        private System.Windows.Forms.Label baseLabelLabel;
        private System.Windows.Forms.GroupBox calculationGroupBox;
        private System.Windows.Forms.Button baseButton;
        private System.Windows.Forms.Button currentButton;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolStripMenuItem homeSiteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem contextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
        private System.Windows.Forms.Label baseCoefficientLabel;
        private System.Windows.Forms.MaskedTextBox baseBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.ToolStripMenuItem donateToolStripMenuItem;
    }
}

