namespace CHD.SVN_Notifier
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
		private void InitializeComponent( )
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.MainFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.StatusUpdateTimer = new System.Timers.Timer();
			this.MainOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.TrayNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.TrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.TrayShowProgramMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.TrayUpdateAllSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.TrayUpdateAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.TrayExitSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.TrayExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MainMenu = new System.Windows.Forms.MenuStrip();
			this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AddFolderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AddFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RemoveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ImportConfigurationMenuSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.ImportConfigurationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ExportConfigurationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ExitMenuSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.UpdateAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SettingsMenuSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.SettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CheckForUpdatesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AboutMenuSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ItemMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.CheckNowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ChangeLogSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.ChangeLogMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.UpdateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CommitSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.CommitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.OpenSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.OpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.LogMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.PropertiesSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.PropertiesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
			this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.WarningStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.MenuToolStrip = new System.Windows.Forms.ToolStrip();
			this.PropertiesButton = new System.Windows.Forms.ToolStripButton();
			this.PropertiesButtonSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.LogButton = new System.Windows.Forms.ToolStripButton();
			this.OpenButton = new System.Windows.Forms.ToolStripButton();
			this.OpenButtonSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.CommitButton = new System.Windows.Forms.ToolStripButton();
			this.CommitButtonSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.UpdateButton = new System.Windows.Forms.ToolStripButton();
			this.ChangeLogButton = new System.Windows.Forms.ToolStripButton();
			this.AddFolderButton = new System.Windows.Forms.ToolStripButton();
			this.AddFileButtonSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.AddFileButton = new System.Windows.Forms.ToolStripButton();
			this.RemoveButtonSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.RemoteButton = new System.Windows.Forms.ToolStripButton();
			this.PauseTimer = new System.Windows.Forms.Timer(this.components);
			this.ItemListView = new System.Windows.Forms.DataGridView();
			this.ColumnEnabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.ImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
			this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnVisiblePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PathColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.StatusUpdateTimer)).BeginInit();
			this.TrayMenu.SuspendLayout();
			this.MainMenu.SuspendLayout();
			this.ItemMenu.SuspendLayout();
			this.MainStatusStrip.SuspendLayout();
			this.MenuToolStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ItemListView)).BeginInit();
			this.SuspendLayout();
			// 
			// MainFolderBrowserDialog
			// 
			this.MainFolderBrowserDialog.Description = "Select folder controlled by Subversion";
			this.MainFolderBrowserDialog.ShowNewFolderButton = false;
			// 
			// StatusUpdateTimer
			// 
			this.StatusUpdateTimer.AutoReset = false;
			this.StatusUpdateTimer.SynchronizingObject = this;
			this.StatusUpdateTimer.Elapsed += new System.Timers.ElapsedEventHandler(this.statusUpdateTimer_Elapsed);
			// 
			// MainOpenFileDialog
			// 
			this.MainOpenFileDialog.Title = "Select file controlled by Subversion";
			// 
			// TrayNotifyIcon
			// 
			this.TrayNotifyIcon.ContextMenuStrip = this.TrayMenu;
			this.TrayNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayNotifyIcon.Icon")));
			this.TrayNotifyIcon.Text = "SVN Notifier";
			this.TrayNotifyIcon.Visible = true;
			this.TrayNotifyIcon.BalloonTipClicked += new System.EventHandler(this.TrayNotifyIcon_BalloonTipClicked);
			this.TrayNotifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TrayNotifyIcon_MouseClick);
			// 
			// TrayMenu
			// 
			this.TrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TrayShowProgramMenuItem,
            this.TrayUpdateAllSeparator,
            this.TrayUpdateAllMenuItem,
            this.TrayExitSeparator,
            this.TrayExitMenuItem});
			this.TrayMenu.Name = "contextMenuStrip";
			this.TrayMenu.Size = new System.Drawing.Size(157, 82);
			// 
			// TrayShowProgramMenuItem
			// 
			this.TrayShowProgramMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TrayShowProgramMenuItem.Image = global::CHD.SVN_Notifier.Properties.Resources.Program_Window;
			this.TrayShowProgramMenuItem.Name = "TrayShowProgramMenuItem";
			this.TrayShowProgramMenuItem.Size = new System.Drawing.Size(156, 22);
			this.TrayShowProgramMenuItem.Text = "Show Program";
			this.TrayShowProgramMenuItem.Click += new System.EventHandler(this.TrayShowProgramMenuItem_Click);
			// 
			// TrayUpdateAllSeparator
			// 
			this.TrayUpdateAllSeparator.Name = "TrayUpdateAllSeparator";
			this.TrayUpdateAllSeparator.Size = new System.Drawing.Size(153, 6);
			// 
			// TrayUpdateAllMenuItem
			// 
			this.TrayUpdateAllMenuItem.Image = global::CHD.SVN_Notifier.Properties.Resources.Toolbar_Update_All;
			this.TrayUpdateAllMenuItem.Name = "TrayUpdateAllMenuItem";
			this.TrayUpdateAllMenuItem.Size = new System.Drawing.Size(156, 22);
			this.TrayUpdateAllMenuItem.Text = "Update All";
			this.TrayUpdateAllMenuItem.Click += new System.EventHandler(this.TrayUpdateAllMenuItem_Click);
			// 
			// TrayExitSeparator
			// 
			this.TrayExitSeparator.Name = "TrayExitSeparator";
			this.TrayExitSeparator.Size = new System.Drawing.Size(153, 6);
			// 
			// TrayExitMenuItem
			// 
			this.TrayExitMenuItem.Image = global::CHD.SVN_Notifier.Properties.Resources.Exit;
			this.TrayExitMenuItem.Name = "TrayExitMenuItem";
			this.TrayExitMenuItem.Size = new System.Drawing.Size(156, 22);
			this.TrayExitMenuItem.Text = "Exit";
			this.TrayExitMenuItem.Click += new System.EventHandler(this.TrayExitMenuItem_Click);
			// 
			// MainMenu
			// 
			this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.ToolsMenuItem,
            this.HelpMenuItem});
			this.MainMenu.Location = new System.Drawing.Point(0, 0);
			this.MainMenu.Name = "MainMenu";
			this.MainMenu.Size = new System.Drawing.Size(544, 24);
			this.MainMenu.TabIndex = 9;
			this.MainMenu.Text = "menuStrip";
			// 
			// FileMenuItem
			// 
			this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddFolderMenuItem,
            this.AddFileMenuItem,
            this.RemoveMenuItem,
            this.ImportConfigurationMenuSeparator,
            this.ImportConfigurationMenuItem,
            this.ExportConfigurationMenuItem,
            this.ExitMenuSeparator,
            this.ExitMenuItem});
			this.FileMenuItem.Name = "FileMenuItem";
			this.FileMenuItem.Size = new System.Drawing.Size(37, 20);
			this.FileMenuItem.Text = "&File";
			// 
			// AddFolderMenuItem
			// 
			this.AddFolderMenuItem.Image = global::CHD.SVN_Notifier.Properties.Resources.Toolbar_AddFolder;
			this.AddFolderMenuItem.Name = "AddFolderMenuItem";
			this.AddFolderMenuItem.Size = new System.Drawing.Size(196, 22);
			this.AddFolderMenuItem.Text = "&Add Folder...";
			this.AddFolderMenuItem.Click += new System.EventHandler(this.AddFolderButton_Click);
			// 
			// AddFileMenuItem
			// 
			this.AddFileMenuItem.Image = global::CHD.SVN_Notifier.Properties.Resources.Toolbar_AddFile;
			this.AddFileMenuItem.Name = "AddFileMenuItem";
			this.AddFileMenuItem.Size = new System.Drawing.Size(196, 22);
			this.AddFileMenuItem.Text = "Add F&ile...";
			this.AddFileMenuItem.Click += new System.EventHandler(this.AddFileButton_Click);
			// 
			// RemoveMenuItem
			// 
			this.RemoveMenuItem.Enabled = false;
			this.RemoveMenuItem.Image = global::CHD.SVN_Notifier.Properties.Resources.Toolbar_Remove;
			this.RemoveMenuItem.Name = "RemoveMenuItem";
			this.RemoveMenuItem.Size = new System.Drawing.Size(196, 22);
			this.RemoveMenuItem.Text = "&Remove...";
			this.RemoveMenuItem.Click += new System.EventHandler(this.RemoteButton_Click);
			// 
			// ImportConfigurationMenuSeparator
			// 
			this.ImportConfigurationMenuSeparator.Name = "ImportConfigurationMenuSeparator";
			this.ImportConfigurationMenuSeparator.Size = new System.Drawing.Size(193, 6);
			// 
			// ImportConfigurationMenuItem
			// 
			this.ImportConfigurationMenuItem.Image = global::CHD.SVN_Notifier.Properties.Resources.Import_Settings;
			this.ImportConfigurationMenuItem.Name = "ImportConfigurationMenuItem";
			this.ImportConfigurationMenuItem.Size = new System.Drawing.Size(196, 22);
			this.ImportConfigurationMenuItem.Text = "&Import Configuration...";
			this.ImportConfigurationMenuItem.Click += new System.EventHandler(this.ImportConfigurationMenuItem_Click);
			// 
			// ExportConfigurationMenuItem
			// 
			this.ExportConfigurationMenuItem.Image = global::CHD.SVN_Notifier.Properties.Resources.Export_Settings;
			this.ExportConfigurationMenuItem.Name = "ExportConfigurationMenuItem";
			this.ExportConfigurationMenuItem.Size = new System.Drawing.Size(196, 22);
			this.ExportConfigurationMenuItem.Text = "&Export Configuration...";
			this.ExportConfigurationMenuItem.Click += new System.EventHandler(this.ExportConfigurationMenuItem_Click);
			// 
			// ExitMenuSeparator
			// 
			this.ExitMenuSeparator.Name = "ExitMenuSeparator";
			this.ExitMenuSeparator.Size = new System.Drawing.Size(193, 6);
			// 
			// ExitMenuItem
			// 
			this.ExitMenuItem.Image = global::CHD.SVN_Notifier.Properties.Resources.Exit;
			this.ExitMenuItem.Name = "ExitMenuItem";
			this.ExitMenuItem.Size = new System.Drawing.Size(196, 22);
			this.ExitMenuItem.Text = "E&xit";
			this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
			// 
			// ToolsMenuItem
			// 
			this.ToolsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UpdateAllMenuItem,
            this.SettingsMenuSeparator,
            this.SettingsMenuItem});
			this.ToolsMenuItem.Name = "ToolsMenuItem";
			this.ToolsMenuItem.Size = new System.Drawing.Size(46, 20);
			this.ToolsMenuItem.Text = "&Tools";
			// 
			// UpdateAllMenuItem
			// 
			this.UpdateAllMenuItem.Enabled = false;
			this.UpdateAllMenuItem.Image = global::CHD.SVN_Notifier.Properties.Resources.Toolbar_Update_All;
			this.UpdateAllMenuItem.Name = "UpdateAllMenuItem";
			this.UpdateAllMenuItem.Size = new System.Drawing.Size(129, 22);
			this.UpdateAllMenuItem.Text = "&Update All";
			this.UpdateAllMenuItem.Click += new System.EventHandler(this.UpdateAllMenuItem_Click);
			// 
			// SettingsMenuSeparator
			// 
			this.SettingsMenuSeparator.Name = "SettingsMenuSeparator";
			this.SettingsMenuSeparator.Size = new System.Drawing.Size(126, 6);
			// 
			// SettingsMenuItem
			// 
			this.SettingsMenuItem.Image = global::CHD.SVN_Notifier.Properties.Resources.Settings;
			this.SettingsMenuItem.Name = "SettingsMenuItem";
			this.SettingsMenuItem.Size = new System.Drawing.Size(129, 22);
			this.SettingsMenuItem.Text = "&Settings...";
			this.SettingsMenuItem.Click += new System.EventHandler(this.SettingsMenuItem_Click);
			// 
			// HelpMenuItem
			// 
			this.HelpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CheckForUpdatesMenuItem,
            this.AboutMenuSeparator,
            this.AboutMenuItem});
			this.HelpMenuItem.Name = "HelpMenuItem";
			this.HelpMenuItem.Size = new System.Drawing.Size(44, 20);
			this.HelpMenuItem.Text = "&Help";
			// 
			// CheckForUpdatesMenuItem
			// 
			this.CheckForUpdatesMenuItem.Image = global::CHD.SVN_Notifier.Properties.Resources.Check_Updates;
			this.CheckForUpdatesMenuItem.Name = "CheckForUpdatesMenuItem";
			this.CheckForUpdatesMenuItem.Size = new System.Drawing.Size(175, 22);
			this.CheckForUpdatesMenuItem.Text = "&Check for Updates";
			this.CheckForUpdatesMenuItem.Click += new System.EventHandler(this.CheckForUpdatesMenuItem_Click);
			// 
			// AboutMenuSeparator
			// 
			this.AboutMenuSeparator.Name = "AboutMenuSeparator";
			this.AboutMenuSeparator.Size = new System.Drawing.Size(172, 6);
			// 
			// AboutMenuItem
			// 
			this.AboutMenuItem.Image = global::CHD.SVN_Notifier.Properties.Resources.About;
			this.AboutMenuItem.Name = "AboutMenuItem";
			this.AboutMenuItem.Size = new System.Drawing.Size(175, 22);
			this.AboutMenuItem.Text = "&About SVN Notifier";
			this.AboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
			// 
			// ItemMenu
			// 
			this.ItemMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CheckNowMenuItem,
            this.ChangeLogSeparator,
            this.ChangeLogMenuItem,
            this.UpdateMenuItem,
            this.CommitSeparator,
            this.CommitMenuItem,
            this.OpenSeparator,
            this.OpenMenuItem,
            this.LogMenuItem,
            this.PropertiesSeparator,
            this.PropertiesMenuItem});
			this.ItemMenu.Name = "contextMenuStrip";
			this.ItemMenu.Size = new System.Drawing.Size(148, 182);
			this.ItemMenu.Opening += new System.ComponentModel.CancelEventHandler(this.ItemMenu_Opening);
			// 
			// CheckNowMenuItem
			// 
			this.CheckNowMenuItem.Image = global::CHD.SVN_Notifier.Properties.Resources.Check_Now;
			this.CheckNowMenuItem.Name = "CheckNowMenuItem";
			this.CheckNowMenuItem.Size = new System.Drawing.Size(147, 22);
			this.CheckNowMenuItem.Text = "Check Now...";
			this.CheckNowMenuItem.Click += new System.EventHandler(this.CheckNowMenuItem_Click);
			// 
			// ChangeLogSeparator
			// 
			this.ChangeLogSeparator.Name = "ChangeLogSeparator";
			this.ChangeLogSeparator.Size = new System.Drawing.Size(144, 6);
			// 
			// ChangeLogMenuItem
			// 
			this.ChangeLogMenuItem.Image = global::CHD.SVN_Notifier.Properties.Resources.Toolbar_ShowChangeLogs;
			this.ChangeLogMenuItem.Name = "ChangeLogMenuItem";
			this.ChangeLogMenuItem.Size = new System.Drawing.Size(147, 22);
			this.ChangeLogMenuItem.Text = "Change Log...";
			this.ChangeLogMenuItem.Click += new System.EventHandler(this.ChangeLogMenuItem_Click);
			// 
			// UpdateMenuItem
			// 
			this.UpdateMenuItem.Image = global::CHD.SVN_Notifier.Properties.Resources.Toolbar_Update;
			this.UpdateMenuItem.Name = "UpdateMenuItem";
			this.UpdateMenuItem.Size = new System.Drawing.Size(147, 22);
			this.UpdateMenuItem.Text = "Update";
			this.UpdateMenuItem.Click += new System.EventHandler(this.UpdateMenuItem_Click);
			// 
			// CommitSeparator
			// 
			this.CommitSeparator.Name = "CommitSeparator";
			this.CommitSeparator.Size = new System.Drawing.Size(144, 6);
			// 
			// CommitMenuItem
			// 
			this.CommitMenuItem.Image = global::CHD.SVN_Notifier.Properties.Resources.Toolbar_Commit;
			this.CommitMenuItem.Name = "CommitMenuItem";
			this.CommitMenuItem.Size = new System.Drawing.Size(147, 22);
			this.CommitMenuItem.Text = "Commit...";
			this.CommitMenuItem.Click += new System.EventHandler(this.CommitMenuItem_Click);
			// 
			// OpenSeparator
			// 
			this.OpenSeparator.Name = "OpenSeparator";
			this.OpenSeparator.Size = new System.Drawing.Size(144, 6);
			// 
			// OpenMenuItem
			// 
			this.OpenMenuItem.Image = global::CHD.SVN_Notifier.Properties.Resources.Toolbar_OpenFolder;
			this.OpenMenuItem.Name = "OpenMenuItem";
			this.OpenMenuItem.Size = new System.Drawing.Size(147, 22);
			this.OpenMenuItem.Text = "Open...";
			this.OpenMenuItem.Click += new System.EventHandler(this.OpenMenuItem_Click);
			// 
			// LogMenuItem
			// 
			this.LogMenuItem.Image = global::CHD.SVN_Notifier.Properties.Resources.Toolbar_ShowLogs;
			this.LogMenuItem.Name = "LogMenuItem";
			this.LogMenuItem.Size = new System.Drawing.Size(147, 22);
			this.LogMenuItem.Text = "Log...";
			this.LogMenuItem.Click += new System.EventHandler(this.LogMenuItem_Click);
			// 
			// PropertiesSeparator
			// 
			this.PropertiesSeparator.Name = "PropertiesSeparator";
			this.PropertiesSeparator.Size = new System.Drawing.Size(144, 6);
			// 
			// PropertiesMenuItem
			// 
			this.PropertiesMenuItem.Image = global::CHD.SVN_Notifier.Properties.Resources.Properties;
			this.PropertiesMenuItem.Name = "PropertiesMenuItem";
			this.PropertiesMenuItem.Size = new System.Drawing.Size(147, 22);
			this.PropertiesMenuItem.Text = "Properties";
			this.PropertiesMenuItem.Click += new System.EventHandler(this.PropertiesButton_Click);
			// 
			// MainStatusStrip
			// 
			this.MainStatusStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
			this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel,
            this.WarningStatusLabel});
			this.MainStatusStrip.Location = new System.Drawing.Point(0, 119);
			this.MainStatusStrip.Name = "MainStatusStrip";
			this.MainStatusStrip.Size = new System.Drawing.Size(544, 22);
			this.MainStatusStrip.TabIndex = 10;
			this.MainStatusStrip.Text = "statusStrip1";
			// 
			// StatusLabel
			// 
			this.StatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
			this.StatusLabel.Name = "StatusLabel";
			this.StatusLabel.Size = new System.Drawing.Size(509, 17);
			this.StatusLabel.Spring = true;
			this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// WarningStatusLabel
			// 
			this.WarningStatusLabel.AutoSize = false;
			this.WarningStatusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
			this.WarningStatusLabel.Image = ((System.Drawing.Image)(resources.GetObject("WarningStatusLabel.Image")));
			this.WarningStatusLabel.Name = "WarningStatusLabel";
			this.WarningStatusLabel.Size = new System.Drawing.Size(20, 17);
			this.WarningStatusLabel.Click += new System.EventHandler(this.WarningStatusLabel_Click);
			// 
			// MenuToolStrip
			// 
			this.MenuToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.MenuToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PropertiesButton,
            this.PropertiesButtonSeparator,
            this.LogButton,
            this.OpenButton,
            this.OpenButtonSeparator,
            this.CommitButton,
            this.CommitButtonSeparator,
            this.UpdateButton,
            this.ChangeLogButton,
            this.AddFolderButton,
            this.AddFileButtonSeparator,
            this.AddFileButton,
            this.RemoveButtonSeparator,
            this.RemoteButton});
			this.MenuToolStrip.Location = new System.Drawing.Point(0, 24);
			this.MenuToolStrip.Name = "MenuToolStrip";
			this.MenuToolStrip.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.MenuToolStrip.Size = new System.Drawing.Size(544, 25);
			this.MenuToolStrip.TabIndex = 11;
			this.MenuToolStrip.Text = "toolStrip1";
			// 
			// PropertiesButton
			// 
			this.PropertiesButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.PropertiesButton.Enabled = false;
			this.PropertiesButton.Image = global::CHD.SVN_Notifier.Properties.Resources.Properties;
			this.PropertiesButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.PropertiesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.PropertiesButton.Name = "PropertiesButton";
			this.PropertiesButton.Size = new System.Drawing.Size(80, 22);
			this.PropertiesButton.Text = "Properties";
			this.PropertiesButton.Click += new System.EventHandler(this.PropertiesButton_Click);
			// 
			// PropertiesButtonSeparator
			// 
			this.PropertiesButtonSeparator.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.PropertiesButtonSeparator.Name = "PropertiesButtonSeparator";
			this.PropertiesButtonSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// LogButton
			// 
			this.LogButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.LogButton.Enabled = false;
			this.LogButton.Image = global::CHD.SVN_Notifier.Properties.Resources.Toolbar_ShowLogs;
			this.LogButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.LogButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.LogButton.Name = "LogButton";
			this.LogButton.Size = new System.Drawing.Size(47, 22);
			this.LogButton.Text = "Log";
			this.LogButton.Click += new System.EventHandler(this.LogButton_Click);
			// 
			// OpenButton
			// 
			this.OpenButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.OpenButton.Enabled = false;
			this.OpenButton.Image = global::CHD.SVN_Notifier.Properties.Resources.Toolbar_OpenFolder;
			this.OpenButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.OpenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.OpenButton.Name = "OpenButton";
			this.OpenButton.Size = new System.Drawing.Size(56, 22);
			this.OpenButton.Text = "Open";
			this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
			// 
			// OpenButtonSeparator
			// 
			this.OpenButtonSeparator.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.OpenButtonSeparator.Name = "OpenButtonSeparator";
			this.OpenButtonSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// CommitButton
			// 
			this.CommitButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.CommitButton.Enabled = false;
			this.CommitButton.Image = global::CHD.SVN_Notifier.Properties.Resources.Toolbar_Commit;
			this.CommitButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.CommitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.CommitButton.Name = "CommitButton";
			this.CommitButton.Size = new System.Drawing.Size(71, 22);
			this.CommitButton.Text = "Commit";
			this.CommitButton.Click += new System.EventHandler(this.CommitButton_Click);
			// 
			// CommitButtonSeparator
			// 
			this.CommitButtonSeparator.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.CommitButtonSeparator.Name = "CommitButtonSeparator";
			this.CommitButtonSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// UpdateButton
			// 
			this.UpdateButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.UpdateButton.Enabled = false;
			this.UpdateButton.Image = global::CHD.SVN_Notifier.Properties.Resources.Toolbar_Update;
			this.UpdateButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.UpdateButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.UpdateButton.Name = "UpdateButton";
			this.UpdateButton.Size = new System.Drawing.Size(65, 22);
			this.UpdateButton.Text = "Update";
			this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
			// 
			// ChangeLogButton
			// 
			this.ChangeLogButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.ChangeLogButton.Enabled = false;
			this.ChangeLogButton.Image = global::CHD.SVN_Notifier.Properties.Resources.Toolbar_ShowChangeLogs;
			this.ChangeLogButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.ChangeLogButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ChangeLogButton.Name = "ChangeLogButton";
			this.ChangeLogButton.Size = new System.Drawing.Size(91, 22);
			this.ChangeLogButton.Text = "Change Log";
			this.ChangeLogButton.Click += new System.EventHandler(this.ChangeLogButton_Click);
			// 
			// AddFolderButton
			// 
			this.AddFolderButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.AddFolderButton.Image = global::CHD.SVN_Notifier.Properties.Resources.Toolbar_AddFolder;
			this.AddFolderButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.AddFolderButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.AddFolderButton.Name = "AddFolderButton";
			this.AddFolderButton.Size = new System.Drawing.Size(23, 22);
			this.AddFolderButton.Text = "Add Folder";
			this.AddFolderButton.Click += new System.EventHandler(this.AddFolderButton_Click);
			// 
			// AddFileButtonSeparator
			// 
			this.AddFileButtonSeparator.Name = "AddFileButtonSeparator";
			this.AddFileButtonSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// AddFileButton
			// 
			this.AddFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.AddFileButton.Image = global::CHD.SVN_Notifier.Properties.Resources.Toolbar_AddFile;
			this.AddFileButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.AddFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.AddFileButton.Name = "AddFileButton";
			this.AddFileButton.Size = new System.Drawing.Size(23, 22);
			this.AddFileButton.Text = "Add File";
			this.AddFileButton.Click += new System.EventHandler(this.AddFileButton_Click);
			// 
			// RemoveButtonSeparator
			// 
			this.RemoveButtonSeparator.Name = "RemoveButtonSeparator";
			this.RemoveButtonSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// RemoteButton
			// 
			this.RemoteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.RemoteButton.Enabled = false;
			this.RemoteButton.Image = global::CHD.SVN_Notifier.Properties.Resources.Toolbar_Remove;
			this.RemoteButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.RemoteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.RemoteButton.Name = "RemoteButton";
			this.RemoteButton.Size = new System.Drawing.Size(23, 22);
			this.RemoteButton.Text = "Remove";
			this.RemoteButton.Click += new System.EventHandler(this.RemoteButton_Click);
			// 
			// PauseTimer
			// 
			this.PauseTimer.Tick += new System.EventHandler(this.PauseTimer_Tick);
			// 
			// ItemListView
			// 
			this.ItemListView.AllowDrop = true;
			this.ItemListView.AllowUserToAddRows = false;
			this.ItemListView.AllowUserToDeleteRows = false;
			this.ItemListView.AllowUserToResizeRows = false;
			this.ItemListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ItemListView.ColumnHeadersVisible = false;
			this.ItemListView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnEnabled,
            this.ImageColumn,
            this.StatusColumn,
            this.ColumnVisiblePath,
            this.PathColumn});
			this.ItemListView.ContextMenuStrip = this.ItemMenu;
			this.ItemListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ItemListView.Location = new System.Drawing.Point(0, 49);
			this.ItemListView.MultiSelect = false;
			this.ItemListView.Name = "ItemListView";
			this.ItemListView.RowHeadersVisible = false;
			this.ItemListView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.ItemListView.Size = new System.Drawing.Size(544, 70);
			this.ItemListView.TabIndex = 0;
			this.ItemListView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ItemListView_CellFormatting);
			this.ItemListView.SelectionChanged += new System.EventHandler(this.ItemListView_SelectedIndexChanged);
			this.ItemListView.DragDrop += new System.Windows.Forms.DragEventHandler(this.ItemListView_DragDrop);
			this.ItemListView.DragEnter += new System.Windows.Forms.DragEventHandler(this.ItemListView_DragEnter);
			this.ItemListView.DragOver += new System.Windows.Forms.DragEventHandler(this.ItemListView_DragOver);
			this.ItemListView.DoubleClick += new System.EventHandler(this.ItemListView_DoubleClick);
			this.ItemListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ItemListView_KeyDown);
			// 
			// ColumnEnabled
			// 
			this.ColumnEnabled.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.ColumnEnabled.DataPropertyName = "Enabled";
			this.ColumnEnabled.HeaderText = "";
			this.ColumnEnabled.Name = "ColumnEnabled";
			this.ColumnEnabled.ReadOnly = true;
			this.ColumnEnabled.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.ColumnEnabled.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.ColumnEnabled.Width = 5;
			// 
			// ImageColumn
			// 
			this.ImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.ImageColumn.DataPropertyName = "Status";
			this.ImageColumn.HeaderText = "";
			this.ImageColumn.Name = "ImageColumn";
			this.ImageColumn.ReadOnly = true;
			this.ImageColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.ImageColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.ImageColumn.Width = 5;
			// 
			// StatusColumn
			// 
			this.StatusColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.StatusColumn.DataPropertyName = "Status";
			this.StatusColumn.HeaderText = "Status";
			this.StatusColumn.Name = "StatusColumn";
			this.StatusColumn.ReadOnly = true;
			this.StatusColumn.Width = 5;
			// 
			// ColumnVisiblePath
			// 
			this.ColumnVisiblePath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.ColumnVisiblePath.DataPropertyName = "VisiblePath";
			this.ColumnVisiblePath.HeaderText = "Visible Path";
			this.ColumnVisiblePath.Name = "ColumnVisiblePath";
			this.ColumnVisiblePath.Visible = false;
			this.ColumnVisiblePath.Width = 5;
			// 
			// PathColumn
			// 
			this.PathColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.PathColumn.DataPropertyName = "Path";
			this.PathColumn.HeaderText = "Path";
			this.PathColumn.Name = "PathColumn";
			this.PathColumn.ReadOnly = true;
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(544, 141);
			this.Controls.Add(this.ItemListView);
			this.Controls.Add(this.MenuToolStrip);
			this.Controls.Add(this.MainMenu);
			this.Controls.Add(this.MainStatusStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MainMenuStrip = this.MainMenu;
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(560, 180);
			this.Name = "MainForm";
			this.Text = "SVN Notifier";
			this.Activated += new System.EventHandler(this.MainForm_Activated);
			this.Closing += new System.ComponentModel.CancelEventHandler(this.MainForm_Closing);
			this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.StatusUpdateTimer)).EndInit();
			this.TrayMenu.ResumeLayout(false);
			this.MainMenu.ResumeLayout(false);
			this.MainMenu.PerformLayout();
			this.ItemMenu.ResumeLayout(false);
			this.MainStatusStrip.ResumeLayout(false);
			this.MainStatusStrip.PerformLayout();
			this.MenuToolStrip.ResumeLayout(false);
			this.MenuToolStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ItemListView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.FolderBrowserDialog MainFolderBrowserDialog;
		private System.Timers.Timer StatusUpdateTimer;
		private System.Windows.Forms.Timer PauseTimer;
		private System.Windows.Forms.DataGridView ItemListView;
		private System.Windows.Forms.OpenFileDialog MainOpenFileDialog;
		private System.Windows.Forms.NotifyIcon TrayNotifyIcon;
		private System.Windows.Forms.ContextMenuStrip TrayMenu;
		private System.Windows.Forms.ToolStripMenuItem TrayShowProgramMenuItem;
		private System.Windows.Forms.ToolStripSeparator TrayUpdateAllSeparator;
		private System.Windows.Forms.ToolStripMenuItem TrayUpdateAllMenuItem;
		private System.Windows.Forms.ToolStripSeparator TrayExitSeparator;
		private System.Windows.Forms.ToolStripMenuItem TrayExitMenuItem;
		private System.Windows.Forms.MenuStrip MainMenu;
		private System.Windows.Forms.ToolStripMenuItem ToolsMenuItem;
		private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
		private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ImportConfigurationMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ExportConfigurationMenuItem;
		private System.Windows.Forms.ToolStripSeparator ExitMenuSeparator;
		private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
		private System.Windows.Forms.ToolStripMenuItem AddFolderMenuItem;
		private System.Windows.Forms.ToolStripMenuItem AddFileMenuItem;
		private System.Windows.Forms.ToolStripMenuItem RemoveMenuItem;
		private System.Windows.Forms.ToolStripMenuItem UpdateAllMenuItem;
		private System.Windows.Forms.ToolStripSeparator SettingsMenuSeparator;
		private System.Windows.Forms.ToolStripMenuItem SettingsMenuItem;
		private System.Windows.Forms.ToolStripMenuItem CheckForUpdatesMenuItem;
		private System.Windows.Forms.ToolStripSeparator AboutMenuSeparator;
		private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
		private System.Windows.Forms.ContextMenuStrip ItemMenu;
		private System.Windows.Forms.ToolStripMenuItem CheckNowMenuItem;
		private System.Windows.Forms.ToolStripSeparator ChangeLogSeparator;
		private System.Windows.Forms.ToolStripMenuItem ChangeLogMenuItem;
		private System.Windows.Forms.ToolStripMenuItem UpdateMenuItem;
		private System.Windows.Forms.ToolStripSeparator CommitSeparator;
		private System.Windows.Forms.ToolStripMenuItem CommitMenuItem;
		private System.Windows.Forms.ToolStripSeparator OpenSeparator;
		private System.Windows.Forms.ToolStripMenuItem OpenMenuItem;
		private System.Windows.Forms.ToolStripMenuItem LogMenuItem;
		private System.Windows.Forms.ToolStripSeparator PropertiesSeparator;
		private System.Windows.Forms.ToolStripMenuItem PropertiesMenuItem;
		private System.Windows.Forms.StatusStrip MainStatusStrip;
		private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
		private System.Windows.Forms.ToolStripStatusLabel WarningStatusLabel;
		private System.Windows.Forms.ToolStrip MenuToolStrip;
		private System.Windows.Forms.ToolStripButton ChangeLogButton;
		private System.Windows.Forms.ToolStripButton UpdateButton;
		private System.Windows.Forms.ToolStripButton CommitButton;
		private System.Windows.Forms.ToolStripButton OpenButton;
		private System.Windows.Forms.ToolStripButton LogButton;
		private System.Windows.Forms.ToolStripButton RemoteButton;
		private System.Windows.Forms.ToolStripButton AddFileButton;
		private System.Windows.Forms.ToolStripButton AddFolderButton;
		private System.Windows.Forms.ToolStripSeparator AddFileButtonSeparator;
		private System.Windows.Forms.ToolStripSeparator RemoveButtonSeparator;
		private System.Windows.Forms.ToolStripSeparator PropertiesButtonSeparator;
		private System.Windows.Forms.ToolStripSeparator OpenButtonSeparator;
		private System.Windows.Forms.ToolStripSeparator ImportConfigurationMenuSeparator;
		private System.Windows.Forms.ToolStripButton PropertiesButton;
		private System.Windows.Forms.ToolStripSeparator CommitButtonSeparator;
		private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnEnabled;
		private System.Windows.Forms.DataGridViewImageColumn ImageColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVisiblePath;
		private System.Windows.Forms.DataGridViewTextBoxColumn PathColumn;
	}
}