﻿namespace KsDumper11
{
	// Token: 0x02000002 RID: 2
	public partial class Dumper : global::System.Windows.Forms.Form
	{
		// Token: 0x0600002C RID: 44 RVA: 0x00002ACC File Offset: 0x00000CCC
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002B04 File Offset: 0x00000D04
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dumper));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.logsTextBox = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dumpThisModuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dumpMainModuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openInExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suspendProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumeProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.killProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileDumpBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.hideSystemProcessBtn = new System.Windows.Forms.Button();
            this.closeDriverOnExitBox = new DarkControls.Controls.DarkCheckBox();
            this.autoRefreshCheckBox = new DarkControls.Controls.DarkCheckBox();
            this.closeBtn = new DarkControls.Controls.WindowsDefaultTitleBarButton();
            this.appIcon1 = new DarkControls.Controls.AppIcon();
            this.transparentLabel1 = new DarkControls.Controls.TransparentLabel();
            this.moduleList = new KsDumper11.Utility.ModuleListView();
            this.ModuleAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ModulePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ModuleEntry = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ModuleSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ModuleType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.trigger1 = new KsDumper11.Trigger();
            this.debuggerTrigger = new KsDumper11.Trigger();
            this.processList = new KsDumper11.Utility.ProcessListView();
            this.PIDHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PathHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BaseAddressHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EntryPointHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ImageSizeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ImageTypeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appIcon1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.logsTextBox);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(22, 1050);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Size = new System.Drawing.Size(1810, 359);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Logs";
            // 
            // logsTextBox
            // 
            this.logsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.logsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logsTextBox.ForeColor = System.Drawing.Color.Silver;
            this.logsTextBox.Location = new System.Drawing.Point(12, 31);
            this.logsTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.logsTextBox.Name = "logsTextBox";
            this.logsTextBox.ReadOnly = true;
            this.logsTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.logsTextBox.Size = new System.Drawing.Size(1773, 318);
            this.logsTextBox.TabIndex = 0;
            this.logsTextBox.Text = "";
            this.logsTextBox.TextChanged += new System.EventHandler(this.logsTextBox_TextChanged);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dumpThisModuleToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(273, 38);
            // 
            // dumpThisModuleToolStripMenuItem
            // 
            this.dumpThisModuleToolStripMenuItem.Name = "dumpThisModuleToolStripMenuItem";
            this.dumpThisModuleToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            this.dumpThisModuleToolStripMenuItem.Text = "Dump this module";
            this.dumpThisModuleToolStripMenuItem.Click += new System.EventHandler(this.dumpThisModuleToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dumpMainModuleToolStripMenuItem,
            this.toolStripSeparator1,
            this.openInExplorerToolStripMenuItem,
            this.suspendProcessToolStripMenuItem,
            this.resumeProcessToolStripMenuItem,
            this.killProcessToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(254, 180);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // dumpMainModuleToolStripMenuItem
            // 
            this.dumpMainModuleToolStripMenuItem.Name = "dumpMainModuleToolStripMenuItem";
            this.dumpMainModuleToolStripMenuItem.Size = new System.Drawing.Size(253, 34);
            this.dumpMainModuleToolStripMenuItem.Text = "Dump Process";
            this.dumpMainModuleToolStripMenuItem.Click += new System.EventHandler(this.dumpMainModuleToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(250, 6);
            // 
            // openInExplorerToolStripMenuItem
            // 
            this.openInExplorerToolStripMenuItem.Name = "openInExplorerToolStripMenuItem";
            this.openInExplorerToolStripMenuItem.Size = new System.Drawing.Size(253, 34);
            this.openInExplorerToolStripMenuItem.Text = "Open In Explorer";
            this.openInExplorerToolStripMenuItem.Click += new System.EventHandler(this.openInExplorerToolStripMenuItem_Click);
            // 
            // suspendProcessToolStripMenuItem
            // 
            this.suspendProcessToolStripMenuItem.Name = "suspendProcessToolStripMenuItem";
            this.suspendProcessToolStripMenuItem.Size = new System.Drawing.Size(253, 34);
            this.suspendProcessToolStripMenuItem.Text = "Suspend process";
            this.suspendProcessToolStripMenuItem.Click += new System.EventHandler(this.suspendProcessToolStripMenuItem_Click);
            // 
            // resumeProcessToolStripMenuItem
            // 
            this.resumeProcessToolStripMenuItem.Name = "resumeProcessToolStripMenuItem";
            this.resumeProcessToolStripMenuItem.Size = new System.Drawing.Size(253, 34);
            this.resumeProcessToolStripMenuItem.Text = "Resume process";
            this.resumeProcessToolStripMenuItem.Click += new System.EventHandler(this.resumeProcessToolStripMenuItem_Click);
            // 
            // killProcessToolStripMenuItem
            // 
            this.killProcessToolStripMenuItem.Name = "killProcessToolStripMenuItem";
            this.killProcessToolStripMenuItem.Size = new System.Drawing.Size(253, 34);
            this.killProcessToolStripMenuItem.Text = "Kill process";
            this.killProcessToolStripMenuItem.Click += new System.EventHandler(this.killProcessToolStripMenuItem_Click);
            // 
            // fileDumpBtn
            // 
            this.fileDumpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.fileDumpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileDumpBtn.ForeColor = System.Drawing.Color.Silver;
            this.fileDumpBtn.Location = new System.Drawing.Point(416, 79);
            this.fileDumpBtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.fileDumpBtn.Name = "fileDumpBtn";
            this.fileDumpBtn.Size = new System.Drawing.Size(138, 37);
            this.fileDumpBtn.TabIndex = 1;
            this.fileDumpBtn.Text = "Dump File";
            this.fileDumpBtn.UseVisualStyleBackColor = false;
            this.fileDumpBtn.Click += new System.EventHandler(this.fileDumpBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.ForeColor = System.Drawing.Color.Silver;
            this.refreshBtn.Location = new System.Drawing.Point(22, 79);
            this.refreshBtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(138, 37);
            this.refreshBtn.TabIndex = 10;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // hideSystemProcessBtn
            // 
            this.hideSystemProcessBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.hideSystemProcessBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hideSystemProcessBtn.ForeColor = System.Drawing.Color.Silver;
            this.hideSystemProcessBtn.Location = new System.Drawing.Point(1580, 79);
            this.hideSystemProcessBtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.hideSystemProcessBtn.Name = "hideSystemProcessBtn";
            this.hideSystemProcessBtn.Size = new System.Drawing.Size(251, 37);
            this.hideSystemProcessBtn.TabIndex = 12;
            this.hideSystemProcessBtn.Text = "Show System Processes";
            this.hideSystemProcessBtn.UseVisualStyleBackColor = false;
            this.hideSystemProcessBtn.Click += new System.EventHandler(this.hideSystemProcessBtn_Click);
            // 
            // closeDriverOnExitBox
            // 
            this.closeDriverOnExitBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.closeDriverOnExitBox.BoxBorderColor = System.Drawing.Color.DarkSlateBlue;
            this.closeDriverOnExitBox.BoxFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.closeDriverOnExitBox.CheckColor = System.Drawing.Color.CornflowerBlue;
            this.closeDriverOnExitBox.FlatAppearance.BorderSize = 0;
            this.closeDriverOnExitBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeDriverOnExitBox.Location = new System.Drawing.Point(1326, 79);
            this.closeDriverOnExitBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.closeDriverOnExitBox.Name = "closeDriverOnExitBox";
            this.closeDriverOnExitBox.Size = new System.Drawing.Size(244, 37);
            this.closeDriverOnExitBox.TabIndex = 13;
            this.closeDriverOnExitBox.Text = "Close Driver on Exit";
            this.closeDriverOnExitBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.closeDriverOnExitBox.UseVisualStyleBackColor = true;
            this.closeDriverOnExitBox.CheckedChanged += new System.EventHandler(this.closeDriverOnExitBox_CheckedChanged);
            // 
            // autoRefreshCheckBox
            // 
            this.autoRefreshCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.autoRefreshCheckBox.BoxBorderColor = System.Drawing.Color.DarkSlateBlue;
            this.autoRefreshCheckBox.BoxFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.autoRefreshCheckBox.CheckColor = System.Drawing.Color.CornflowerBlue;
            this.autoRefreshCheckBox.FlatAppearance.BorderSize = 0;
            this.autoRefreshCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autoRefreshCheckBox.Location = new System.Drawing.Point(170, 79);
            this.autoRefreshCheckBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.autoRefreshCheckBox.Name = "autoRefreshCheckBox";
            this.autoRefreshCheckBox.Size = new System.Drawing.Size(180, 37);
            this.autoRefreshCheckBox.TabIndex = 11;
            this.autoRefreshCheckBox.Text = "Auto Refresh";
            this.autoRefreshCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.autoRefreshCheckBox.UseVisualStyleBackColor = true;
            this.autoRefreshCheckBox.CheckedChanged += new System.EventHandler(this.autoRefreshCheckBox_CheckedChanged);
            // 
            // closeBtn
            // 
            this.closeBtn.ButtonType = DarkControls.Controls.WindowsDefaultTitleBarButton.Type.Close;
            this.closeBtn.ClickColor = System.Drawing.Color.Red;
            this.closeBtn.ClickIconColor = System.Drawing.Color.Black;
            this.closeBtn.HoverColor = System.Drawing.Color.OrangeRed;
            this.closeBtn.HoverIconColor = System.Drawing.Color.Black;
            this.closeBtn.IconColor = System.Drawing.Color.Black;
            this.closeBtn.IconLineThickness = 2;
            this.closeBtn.Location = new System.Drawing.Point(1776, 2);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(73, 65);
            this.closeBtn.TabIndex = 7;
            this.closeBtn.Text = "windowsDefaultTitleBarButton1";
            this.closeBtn.UseVisualStyleBackColor = true;
            // 
            // appIcon1
            // 
            this.appIcon1.AppIconImage = global::KsDumper11.Properties.Resources.icons8_crossed_axes_100;
            this.appIcon1.DragForm = this;
            this.appIcon1.Image = ((System.Drawing.Image)(resources.GetObject("appIcon1.Image")));
            this.appIcon1.Location = new System.Drawing.Point(9, 6);
            this.appIcon1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.appIcon1.Name = "appIcon1";
            this.appIcon1.Scale = 3.5F;
            this.appIcon1.Size = new System.Drawing.Size(28, 28);
            this.appIcon1.TabIndex = 9;
            this.appIcon1.TabStop = false;
            // 
            // transparentLabel1
            // 
            this.transparentLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transparentLabel1.Location = new System.Drawing.Point(59, 6);
            this.transparentLabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.transparentLabel1.Name = "transparentLabel1";
            this.transparentLabel1.Size = new System.Drawing.Size(198, 32);
            this.transparentLabel1.TabIndex = 8;
            this.transparentLabel1.Text = "KsDumper 11";
            // 
            // moduleList
            // 
            this.moduleList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.moduleList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.moduleList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ModuleAddress,
            this.ModulePath,
            this.ModuleEntry,
            this.ModuleSize,
            this.ModuleType});
            this.moduleList.ContextMenuStrip = this.contextMenuStrip2;
            this.moduleList.ForeColor = System.Drawing.Color.Silver;
            this.moduleList.FullRowSelect = true;
            this.moduleList.HideSelection = false;
            this.moduleList.Location = new System.Drawing.Point(19, 827);
            this.moduleList.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.moduleList.MultiSelect = false;
            this.moduleList.Name = "moduleList";
            this.moduleList.OwnerDraw = true;
            this.moduleList.Size = new System.Drawing.Size(1816, 217);
            this.moduleList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.moduleList.TabIndex = 2;
            this.moduleList.UseCompatibleStateImageBehavior = false;
            this.moduleList.View = System.Windows.Forms.View.Details;
            // 
            // ModuleAddress
            // 
            this.ModuleAddress.Text = "Base Address";
            this.ModuleAddress.Width = 221;
            // 
            // ModulePath
            // 
            this.ModulePath.Text = "Path";
            this.ModulePath.Width = 372;
            // 
            // ModuleEntry
            // 
            this.ModuleEntry.DisplayIndex = 3;
            this.ModuleEntry.Text = "Entry Point";
            this.ModuleEntry.Width = 150;
            // 
            // ModuleSize
            // 
            this.ModuleSize.DisplayIndex = 2;
            this.ModuleSize.Text = "Image Size";
            this.ModuleSize.Width = 150;
            // 
            // ModuleType
            // 
            this.ModuleType.Text = "Image Type";
            this.ModuleType.Width = 80;
            // 
            // trigger1
            // 
            this.trigger1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.trigger1.Location = new System.Drawing.Point(812, 45);
            this.trigger1.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.trigger1.Name = "trigger1";
            this.trigger1.Size = new System.Drawing.Size(64, 39);
            this.trigger1.TabIndex = 16;
            this.trigger1.Load += new System.EventHandler(this.trigger1_Load);
            // 
            // debuggerTrigger
            // 
            this.debuggerTrigger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.debuggerTrigger.Location = new System.Drawing.Point(887, 45);
            this.debuggerTrigger.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.debuggerTrigger.Name = "debuggerTrigger";
            this.debuggerTrigger.Size = new System.Drawing.Size(28, 21);
            this.debuggerTrigger.TabIndex = 15;
            // 
            // processList
            // 
            this.processList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.processList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.processList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PIDHeader,
            this.NameHeader,
            this.PathHeader,
            this.BaseAddressHeader,
            this.EntryPointHeader,
            this.ImageSizeHeader,
            this.ImageTypeHeader});
            this.processList.ContextMenuStrip = this.contextMenuStrip1;
            this.processList.ForeColor = System.Drawing.Color.Silver;
            this.processList.FullRowSelect = true;
            this.processList.HideSelection = false;
            this.processList.Location = new System.Drawing.Point(22, 126);
            this.processList.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.processList.MultiSelect = false;
            this.processList.Name = "processList";
            this.processList.OwnerDraw = true;
            this.processList.Size = new System.Drawing.Size(1810, 691);
            this.processList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.processList.SystemProcessesHidden = true;
            this.processList.TabIndex = 2;
            this.processList.UseCompatibleStateImageBehavior = false;
            this.processList.View = System.Windows.Forms.View.Details;
            this.processList.SelectedIndexChanged += new System.EventHandler(this.processList_SelectedIndexChanged);
            // 
            // PIDHeader
            // 
            this.PIDHeader.Text = "PID";
            this.PIDHeader.Width = 76;
            // 
            // NameHeader
            // 
            this.NameHeader.Text = "Name";
            this.NameHeader.Width = 143;
            // 
            // PathHeader
            // 
            this.PathHeader.Text = "Path";
            this.PathHeader.Width = 375;
            // 
            // BaseAddressHeader
            // 
            this.BaseAddressHeader.Text = "Base Address";
            this.BaseAddressHeader.Width = 106;
            // 
            // EntryPointHeader
            // 
            this.EntryPointHeader.Text = "Entry Point";
            this.EntryPointHeader.Width = 106;
            // 
            // ImageSizeHeader
            // 
            this.ImageSizeHeader.Text = "Image Size";
            this.ImageSizeHeader.Width = 88;
            // 
            // ImageTypeHeader
            // 
            this.ImageTypeHeader.Text = "Image Type";
            this.ImageTypeHeader.Width = 76;
            // 
            // Dumper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1850, 1433);
            this.Controls.Add(this.moduleList);
            this.Controls.Add(this.trigger1);
            this.Controls.Add(this.debuggerTrigger);
            this.Controls.Add(this.closeDriverOnExitBox);
            this.Controls.Add(this.hideSystemProcessBtn);
            this.Controls.Add(this.autoRefreshCheckBox);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.fileDumpBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.processList);
            this.Controls.Add(this.appIcon1);
            this.Controls.Add(this.transparentLabel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "Dumper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KsDumper 11";
            this.Load += new System.EventHandler(this.Dumper_Load);
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.appIcon1)).EndInit();
            this.ResumeLayout(false);

		}

		// Token: 0x04000012 RID: 18
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000013 RID: 19
		private global::KsDumper11.Utility.ProcessListView processList;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.ColumnHeader PIDHeader;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.ColumnHeader NameHeader;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.ColumnHeader PathHeader;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.ColumnHeader BaseAddressHeader;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.ColumnHeader EntryPointHeader;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Forms.ColumnHeader ImageSizeHeader;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.ColumnHeader ImageTypeHeader;

		// Token: 0x0400001B RID: 27
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.RichTextBox logsTextBox;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.ToolStripMenuItem dumpMainModuleToolStripMenuItem;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.ToolStripMenuItem openInExplorerToolStripMenuItem;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.ToolStripMenuItem suspendProcessToolStripMenuItem;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.ToolStripMenuItem resumeProcessToolStripMenuItem;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.ToolStripMenuItem killProcessToolStripMenuItem;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.Button fileDumpBtn;

		// Token: 0x04000025 RID: 37
		private global::DarkControls.Controls.WindowsDefaultTitleBarButton closeBtn;

		// Token: 0x04000026 RID: 38
		private global::DarkControls.Controls.TransparentLabel transparentLabel1;

		// Token: 0x04000027 RID: 39
		private global::DarkControls.Controls.AppIcon appIcon1;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.Button refreshBtn;

		// Token: 0x04000029 RID: 41
		private global::DarkControls.Controls.DarkCheckBox autoRefreshCheckBox;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.Button hideSystemProcessBtn;
        private DarkControls.Controls.DarkCheckBox closeDriverOnExitBox;
        private Trigger debuggerTrigger;
        private Trigger trigger1;
        private KsDumper11.Utility.ModuleListView moduleList;
        private System.Windows.Forms.ColumnHeader ModuleAddress;
        private System.Windows.Forms.ColumnHeader ModulePath;
        private System.Windows.Forms.ColumnHeader ModuleEntry;
        private System.Windows.Forms.ColumnHeader ModuleSize;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem dumpThisModuleToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader ModuleType;
    }
}
