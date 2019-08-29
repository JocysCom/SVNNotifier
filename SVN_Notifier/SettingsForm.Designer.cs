namespace CHD.SVN_Notifier
{
	public partial class SettingsForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
			this.SvnPathLabel = new System.Windows.Forms.Label();
			this.TortoisePathLabel = new System.Windows.Forms.Label();
			this.SvnPathTextBox = new System.Windows.Forms.TextBox();
			this.TortoisePathTextBox = new System.Windows.Forms.TextBox();
			this.OkButton = new System.Windows.Forms.Button();
			this.CloseButton = new System.Windows.Forms.Button();
			this.SvnBrowseButton = new System.Windows.Forms.Button();
			this.TortoiseBrowseButton = new System.Windows.Forms.Button();
			this.SvnFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.TortoiseFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.DoubleClickComboBox = new System.Windows.Forms.ComboBox();
			this.DoubleClickLabel = new System.Windows.Forms.Label();
			this.HideOnStartupCheckBox = new System.Windows.Forms.CheckBox();
			this.CheckForNewVersionCheckBox = new System.Windows.Forms.CheckBox();
			this.HideSystemTrayUpDown = new System.Windows.Forms.NumericUpDown();
			this.HideSystemTrayLabel = new System.Windows.Forms.Label();
			this.ChangeLogBeforeUpdateCheckBox = new System.Windows.Forms.CheckBox();
			this.SilentlUpdateCheckBox = new System.Windows.Forms.CheckBox();
			this.DialogActionLabel = new System.Windows.Forms.Label();
			this.DialogActiionDropDown = new System.Windows.Forms.ComboBox();
			this.MainTabControl = new System.Windows.Forms.TabControl();
			this.GeneralTabPage = new System.Windows.Forms.TabPage();
			this.OtherOptionsGroupBox = new System.Windows.Forms.GroupBox();
			this.ShowInTaskbarCheckBox = new System.Windows.Forms.CheckBox();
			this.LocationsGroupBox = new System.Windows.Forms.GroupBox();
			this.StatusTabPage = new System.Windows.Forms.TabPage();
			this.PauseGroupBox = new System.Windows.Forms.GroupBox();
			this.ResumeHoursUpDown = new System.Windows.Forms.NumericUpDown();
			this.StartupHoursUpDown = new System.Windows.Forms.NumericUpDown();
			this.ResumeMinutesUpDown = new System.Windows.Forms.NumericUpDown();
			this.StartupMinutesUpDown = new System.Windows.Forms.NumericUpDown();
			this.ResumeSecondsUpDown = new System.Windows.Forms.NumericUpDown();
			this.StartupSecondsUpDown = new System.Windows.Forms.NumericUpDown();
			this.ResumeLabel = new System.Windows.Forms.CheckBox();
			this.StartupLabel = new System.Windows.Forms.CheckBox();
			this.StartupMinutesLabel = new System.Windows.Forms.Label();
			this.ResumeMinutesLabel = new System.Windows.Forms.Label();
			this.PauseHoursLabel = new System.Windows.Forms.Label();
			this.ResumeSecondsLabel = new System.Windows.Forms.Label();
			this.PauseSecondsLabel = new System.Windows.Forms.Label();
			this.PauseMinutesLabel = new System.Windows.Forms.Label();
			this.StartupSecondsLanbel = new System.Windows.Forms.Label();
			this.StatusGroupBox = new System.Windows.Forms.GroupBox();
			this.InactiveHoursUpDown = new System.Windows.Forms.NumericUpDown();
			this.ActiveHoursUpDown = new System.Windows.Forms.NumericUpDown();
			this.InactiveMinutesUpDown = new System.Windows.Forms.NumericUpDown();
			this.ActiveMinutesUpDown = new System.Windows.Forms.NumericUpDown();
			this.InactiveSecondsUpDown = new System.Windows.Forms.NumericUpDown();
			this.ActiveSecondsUpDown = new System.Windows.Forms.NumericUpDown();
			this.ActiveMinutesLabel = new System.Windows.Forms.Label();
			this.InactiveMinutesLabel = new System.Windows.Forms.Label();
			this.StatusHoursLabel = new System.Windows.Forms.Label();
			this.InactiveSecondsLabel = new System.Windows.Forms.Label();
			this.StatusSecondsLabel = new System.Windows.Forms.Label();
			this.StatusMinutesLabel = new System.Windows.Forms.Label();
			this.ActiveSecondsLabel = new System.Windows.Forms.Label();
			this.ActiveLabel = new System.Windows.Forms.Label();
			this.InactiveLabel = new System.Windows.Forms.Label();
			this.UpdateTabPage = new System.Windows.Forms.TabPage();
			this.RequiresTortoiseLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.HideSystemTrayUpDown)).BeginInit();
			this.MainTabControl.SuspendLayout();
			this.GeneralTabPage.SuspendLayout();
			this.OtherOptionsGroupBox.SuspendLayout();
			this.LocationsGroupBox.SuspendLayout();
			this.StatusTabPage.SuspendLayout();
			this.PauseGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ResumeHoursUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.StartupHoursUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ResumeMinutesUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.StartupMinutesUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ResumeSecondsUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.StartupSecondsUpDown)).BeginInit();
			this.StatusGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.InactiveHoursUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ActiveHoursUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.InactiveMinutesUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ActiveMinutesUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.InactiveSecondsUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ActiveSecondsUpDown)).BeginInit();
			this.UpdateTabPage.SuspendLayout();
			this.SuspendLayout();
			// 
			// SvnPathLabel
			// 
			this.SvnPathLabel.AutoSize = true;
			this.SvnPathLabel.Location = new System.Drawing.Point(10, 16);
			this.SvnPathLabel.Name = "SvnPathLabel";
			this.SvnPathLabel.Size = new System.Drawing.Size(84, 13);
			this.SvnPathLabel.TabIndex = 0;
			this.SvnPathLabel.Text = "Path to svn.exe:";
			this.SvnPathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// TortoisePathLabel
			// 
			this.TortoisePathLabel.AutoSize = true;
			this.TortoisePathLabel.Location = new System.Drawing.Point(10, 55);
			this.TortoisePathLabel.Name = "TortoisePathLabel";
			this.TortoisePathLabel.Size = new System.Drawing.Size(127, 13);
			this.TortoisePathLabel.TabIndex = 1;
			this.TortoisePathLabel.Text = "Path to TortoiseProc.exe:";
			this.TortoisePathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// SvnPathTextBox
			// 
			this.SvnPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SvnPathTextBox.Location = new System.Drawing.Point(10, 32);
			this.SvnPathTextBox.Name = "SvnPathTextBox";
			this.SvnPathTextBox.Size = new System.Drawing.Size(263, 20);
			this.SvnPathTextBox.TabIndex = 1;
			this.SvnPathTextBox.TextChanged += new System.EventHandler(this.CheckPathes);
			// 
			// TortoisePathTextBox
			// 
			this.TortoisePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TortoisePathTextBox.Location = new System.Drawing.Point(10, 71);
			this.TortoisePathTextBox.Name = "TortoisePathTextBox";
			this.TortoisePathTextBox.Size = new System.Drawing.Size(263, 20);
			this.TortoisePathTextBox.TabIndex = 3;
			this.TortoisePathTextBox.TextChanged += new System.EventHandler(this.CheckPathes);
			// 
			// OkButton
			// 
			this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.OkButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.OkButton.Location = new System.Drawing.Point(242, 297);
			this.OkButton.Name = "OkButton";
			this.OkButton.Size = new System.Drawing.Size(72, 23);
			this.OkButton.TabIndex = 7;
			this.OkButton.Text = "&OK";
			this.OkButton.Click += new System.EventHandler(this.button_OK_Click);
			// 
			// CloseButton
			// 
			this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.CloseButton.Location = new System.Drawing.Point(320, 297);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size(72, 23);
			this.CloseButton.TabIndex = 8;
			this.CloseButton.Text = "Cancel";
			// 
			// SvnBrowseButton
			// 
			this.SvnBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SvnBrowseButton.Location = new System.Drawing.Point(279, 30);
			this.SvnBrowseButton.Name = "SvnBrowseButton";
			this.SvnBrowseButton.Size = new System.Drawing.Size(75, 23);
			this.SvnBrowseButton.TabIndex = 2;
			this.SvnBrowseButton.Text = "Browse...";
			this.SvnBrowseButton.Click += new System.EventHandler(this.button_BrowseSvn_Click);
			// 
			// TortoiseBrowseButton
			// 
			this.TortoiseBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.TortoiseBrowseButton.Location = new System.Drawing.Point(279, 69);
			this.TortoiseBrowseButton.Name = "TortoiseBrowseButton";
			this.TortoiseBrowseButton.Size = new System.Drawing.Size(75, 23);
			this.TortoiseBrowseButton.TabIndex = 4;
			this.TortoiseBrowseButton.Text = "Browse...";
			this.TortoiseBrowseButton.Click += new System.EventHandler(this.button_BrowseTortoise_Click);
			// 
			// SvnFileDialog
			// 
			this.SvnFileDialog.DefaultExt = "exe";
			this.SvnFileDialog.Filter = "svn.exe|svn.exe";
			// 
			// TortoiseFileDialog
			// 
			this.TortoiseFileDialog.DefaultExt = "exe";
			this.TortoiseFileDialog.Filter = "TortoiseProc.exe|TortoiseProc.exe";
			// 
			// DoubleClickComboBox
			// 
			this.DoubleClickComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.DoubleClickComboBox.Items.AddRange(new object[] {
            "Open folder",
            "Show change/full log",
            "Update",
            "Commit",
            "CheckNow"});
			this.DoubleClickComboBox.Location = new System.Drawing.Point(100, 19);
			this.DoubleClickComboBox.Name = "DoubleClickComboBox";
			this.DoubleClickComboBox.Size = new System.Drawing.Size(136, 21);
			this.DoubleClickComboBox.TabIndex = 6;
			// 
			// DoubleClickLabel
			// 
			this.DoubleClickLabel.Location = new System.Drawing.Point(6, 22);
			this.DoubleClickLabel.Name = "DoubleClickLabel";
			this.DoubleClickLabel.Size = new System.Drawing.Size(88, 16);
			this.DoubleClickLabel.TabIndex = 14;
			this.DoubleClickLabel.Text = "On double click:";
			// 
			// HideOnStartupCheckBox
			// 
			this.HideOnStartupCheckBox.AutoSize = true;
			this.HideOnStartupCheckBox.Location = new System.Drawing.Point(6, 67);
			this.HideOnStartupCheckBox.Name = "HideOnStartupCheckBox";
			this.HideOnStartupCheckBox.Size = new System.Drawing.Size(206, 17);
			this.HideOnStartupCheckBox.TabIndex = 15;
			this.HideOnStartupCheckBox.Text = "Hide program to system tray on startup";
			// 
			// CheckForNewVersionCheckBox
			// 
			this.CheckForNewVersionCheckBox.AutoSize = true;
			this.CheckForNewVersionCheckBox.Location = new System.Drawing.Point(6, 113);
			this.CheckForNewVersionCheckBox.Name = "CheckForNewVersionCheckBox";
			this.CheckForNewVersionCheckBox.Size = new System.Drawing.Size(132, 17);
			this.CheckForNewVersionCheckBox.TabIndex = 16;
			this.CheckForNewVersionCheckBox.Text = "Check for new version";
			// 
			// HideSystemTrayUpDown
			// 
			this.HideSystemTrayUpDown.Location = new System.Drawing.Point(152, 46);
			this.HideSystemTrayUpDown.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
			this.HideSystemTrayUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.HideSystemTrayUpDown.Name = "HideSystemTrayUpDown";
			this.HideSystemTrayUpDown.Size = new System.Drawing.Size(40, 20);
			this.HideSystemTrayUpDown.TabIndex = 17;
			this.HideSystemTrayUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.HideSystemTrayUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// HideSystemTrayLabel
			// 
			this.HideSystemTrayLabel.Location = new System.Drawing.Point(6, 48);
			this.HideSystemTrayLabel.Name = "HideSystemTrayLabel";
			this.HideSystemTrayLabel.Size = new System.Drawing.Size(256, 16);
			this.HideSystemTrayLabel.TabIndex = 18;
			this.HideSystemTrayLabel.Text = "Hide system tray balloon after                 seconds";
			// 
			// ChangeLogBeforeUpdateCheckBox
			// 
			this.ChangeLogBeforeUpdateCheckBox.AutoSize = true;
			this.ChangeLogBeforeUpdateCheckBox.Location = new System.Drawing.Point(6, 46);
			this.ChangeLogBeforeUpdateCheckBox.Name = "ChangeLogBeforeUpdateCheckBox";
			this.ChangeLogBeforeUpdateCheckBox.Size = new System.Drawing.Size(227, 17);
			this.ChangeLogBeforeUpdateCheckBox.TabIndex = 19;
			this.ChangeLogBeforeUpdateCheckBox.Text = "Force to see \"Change Log\" before Update";
			this.ChangeLogBeforeUpdateCheckBox.CheckedChanged += new System.EventHandler(this.checkBox_ChangeLogBeforeUpdate_CheckedChanged);
			// 
			// SilentlUpdateCheckBox
			// 
			this.SilentlUpdateCheckBox.AutoSize = true;
			this.SilentlUpdateCheckBox.Location = new System.Drawing.Point(6, 82);
			this.SilentlUpdateCheckBox.Name = "SilentlUpdateCheckBox";
			this.SilentlUpdateCheckBox.Size = new System.Drawing.Size(114, 17);
			this.SilentlUpdateCheckBox.TabIndex = 22;
			this.SilentlUpdateCheckBox.Text = "\"Silent\" Update All";
			// 
			// DialogActionLabel
			// 
			this.DialogActionLabel.AutoSize = true;
			this.DialogActionLabel.Location = new System.Drawing.Point(6, 3);
			this.DialogActionLabel.Name = "DialogActionLabel";
			this.DialogActionLabel.Size = new System.Drawing.Size(191, 13);
			this.DialogActionLabel.TabIndex = 25;
			this.DialogActionLabel.Text = "TortoiseSVN dialog acton after update:";
			// 
			// DialogActiionDropDown
			// 
			this.DialogActiionDropDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DialogActiionDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.DialogActiionDropDown.Items.AddRange(new object[] {
            "don\'t close the dialog automatically",
            "auto close if no errors",
            "auto close if no errors and conflicts",
            "auto close if no errors, conflicts and merges",
            "auto close if no errors, conflicts and merges for local operations"});
			this.DialogActiionDropDown.Location = new System.Drawing.Point(6, 19);
			this.DialogActiionDropDown.Name = "DialogActiionDropDown";
			this.DialogActiionDropDown.Size = new System.Drawing.Size(360, 21);
			this.DialogActiionDropDown.TabIndex = 27;
			// 
			// MainTabControl
			// 
			this.MainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MainTabControl.Controls.Add(this.GeneralTabPage);
			this.MainTabControl.Controls.Add(this.StatusTabPage);
			this.MainTabControl.Controls.Add(this.UpdateTabPage);
			this.MainTabControl.Location = new System.Drawing.Point(12, 12);
			this.MainTabControl.Multiline = true;
			this.MainTabControl.Name = "MainTabControl";
			this.MainTabControl.SelectedIndex = 0;
			this.MainTabControl.Size = new System.Drawing.Size(380, 281);
			this.MainTabControl.TabIndex = 28;
			// 
			// GeneralTabPage
			// 
			this.GeneralTabPage.BackColor = System.Drawing.SystemColors.Control;
			this.GeneralTabPage.Controls.Add(this.OtherOptionsGroupBox);
			this.GeneralTabPage.Controls.Add(this.LocationsGroupBox);
			this.GeneralTabPage.Location = new System.Drawing.Point(4, 22);
			this.GeneralTabPage.Name = "GeneralTabPage";
			this.GeneralTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.GeneralTabPage.Size = new System.Drawing.Size(372, 255);
			this.GeneralTabPage.TabIndex = 0;
			this.GeneralTabPage.Text = "General";
			// 
			// OtherOptionsGroupBox
			// 
			this.OtherOptionsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.OtherOptionsGroupBox.Controls.Add(this.HideSystemTrayUpDown);
			this.OtherOptionsGroupBox.Controls.Add(this.DoubleClickLabel);
			this.OtherOptionsGroupBox.Controls.Add(this.CheckForNewVersionCheckBox);
			this.OtherOptionsGroupBox.Controls.Add(this.ShowInTaskbarCheckBox);
			this.OtherOptionsGroupBox.Controls.Add(this.HideOnStartupCheckBox);
			this.OtherOptionsGroupBox.Controls.Add(this.DoubleClickComboBox);
			this.OtherOptionsGroupBox.Controls.Add(this.HideSystemTrayLabel);
			this.OtherOptionsGroupBox.Location = new System.Drawing.Point(6, 112);
			this.OtherOptionsGroupBox.Name = "OtherOptionsGroupBox";
			this.OtherOptionsGroupBox.Size = new System.Drawing.Size(360, 137);
			this.OtherOptionsGroupBox.TabIndex = 22;
			this.OtherOptionsGroupBox.TabStop = false;
			this.OtherOptionsGroupBox.Text = "Other Options";
			// 
			// ShowInTaskbarCheckBox
			// 
			this.ShowInTaskbarCheckBox.AutoSize = true;
			this.ShowInTaskbarCheckBox.Location = new System.Drawing.Point(6, 90);
			this.ShowInTaskbarCheckBox.Name = "ShowInTaskbarCheckBox";
			this.ShowInTaskbarCheckBox.Size = new System.Drawing.Size(102, 17);
			this.ShowInTaskbarCheckBox.TabIndex = 20;
			this.ShowInTaskbarCheckBox.Text = "Show in taskbar";
			// 
			// LocationsGroupBox
			// 
			this.LocationsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LocationsGroupBox.Controls.Add(this.SvnPathLabel);
			this.LocationsGroupBox.Controls.Add(this.TortoiseBrowseButton);
			this.LocationsGroupBox.Controls.Add(this.TortoisePathTextBox);
			this.LocationsGroupBox.Controls.Add(this.SvnBrowseButton);
			this.LocationsGroupBox.Controls.Add(this.SvnPathTextBox);
			this.LocationsGroupBox.Controls.Add(this.TortoisePathLabel);
			this.LocationsGroupBox.Location = new System.Drawing.Point(6, 6);
			this.LocationsGroupBox.Name = "LocationsGroupBox";
			this.LocationsGroupBox.Size = new System.Drawing.Size(360, 100);
			this.LocationsGroupBox.TabIndex = 21;
			this.LocationsGroupBox.TabStop = false;
			this.LocationsGroupBox.Text = "Locations";
			// 
			// StatusTabPage
			// 
			this.StatusTabPage.Controls.Add(this.PauseGroupBox);
			this.StatusTabPage.Controls.Add(this.StatusGroupBox);
			this.StatusTabPage.Location = new System.Drawing.Point(4, 22);
			this.StatusTabPage.Name = "StatusTabPage";
			this.StatusTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.StatusTabPage.Size = new System.Drawing.Size(372, 255);
			this.StatusTabPage.TabIndex = 2;
			this.StatusTabPage.Text = "Status";
			// 
			// PauseGroupBox
			// 
			this.PauseGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PauseGroupBox.Controls.Add(this.ResumeHoursUpDown);
			this.PauseGroupBox.Controls.Add(this.StartupHoursUpDown);
			this.PauseGroupBox.Controls.Add(this.ResumeMinutesUpDown);
			this.PauseGroupBox.Controls.Add(this.StartupMinutesUpDown);
			this.PauseGroupBox.Controls.Add(this.ResumeSecondsUpDown);
			this.PauseGroupBox.Controls.Add(this.StartupSecondsUpDown);
			this.PauseGroupBox.Controls.Add(this.ResumeLabel);
			this.PauseGroupBox.Controls.Add(this.StartupLabel);
			this.PauseGroupBox.Controls.Add(this.StartupMinutesLabel);
			this.PauseGroupBox.Controls.Add(this.ResumeMinutesLabel);
			this.PauseGroupBox.Controls.Add(this.PauseHoursLabel);
			this.PauseGroupBox.Controls.Add(this.ResumeSecondsLabel);
			this.PauseGroupBox.Controls.Add(this.PauseSecondsLabel);
			this.PauseGroupBox.Controls.Add(this.PauseMinutesLabel);
			this.PauseGroupBox.Controls.Add(this.StartupSecondsLanbel);
			this.PauseGroupBox.Location = new System.Drawing.Point(6, 100);
			this.PauseGroupBox.Name = "PauseGroupBox";
			this.PauseGroupBox.Size = new System.Drawing.Size(360, 88);
			this.PauseGroupBox.TabIndex = 1;
			this.PauseGroupBox.TabStop = false;
			this.PauseGroupBox.Text = "Pause update after...";
			// 
			// ResumeHoursUpDown
			// 
			this.ResumeHoursUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ResumeHoursUpDown.Location = new System.Drawing.Point(212, 56);
			this.ResumeHoursUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
			this.ResumeHoursUpDown.Name = "ResumeHoursUpDown";
			this.ResumeHoursUpDown.Size = new System.Drawing.Size(40, 20);
			this.ResumeHoursUpDown.TabIndex = 7;
			this.ResumeHoursUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ResumeHoursUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
			// 
			// StartupHoursUpDown
			// 
			this.StartupHoursUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.StartupHoursUpDown.Location = new System.Drawing.Point(212, 32);
			this.StartupHoursUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
			this.StartupHoursUpDown.Name = "StartupHoursUpDown";
			this.StartupHoursUpDown.Size = new System.Drawing.Size(40, 20);
			this.StartupHoursUpDown.TabIndex = 1;
			this.StartupHoursUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.StartupHoursUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
			// 
			// ResumeMinutesUpDown
			// 
			this.ResumeMinutesUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ResumeMinutesUpDown.Location = new System.Drawing.Point(260, 56);
			this.ResumeMinutesUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
			this.ResumeMinutesUpDown.Name = "ResumeMinutesUpDown";
			this.ResumeMinutesUpDown.Size = new System.Drawing.Size(40, 20);
			this.ResumeMinutesUpDown.TabIndex = 10;
			this.ResumeMinutesUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ResumeMinutesUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
			// 
			// StartupMinutesUpDown
			// 
			this.StartupMinutesUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.StartupMinutesUpDown.Location = new System.Drawing.Point(260, 32);
			this.StartupMinutesUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
			this.StartupMinutesUpDown.Name = "StartupMinutesUpDown";
			this.StartupMinutesUpDown.Size = new System.Drawing.Size(40, 20);
			this.StartupMinutesUpDown.TabIndex = 3;
			this.StartupMinutesUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.StartupMinutesUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
			// 
			// ResumeSecondsUpDown
			// 
			this.ResumeSecondsUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ResumeSecondsUpDown.Location = new System.Drawing.Point(308, 56);
			this.ResumeSecondsUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
			this.ResumeSecondsUpDown.Name = "ResumeSecondsUpDown";
			this.ResumeSecondsUpDown.Size = new System.Drawing.Size(40, 20);
			this.ResumeSecondsUpDown.TabIndex = 13;
			this.ResumeSecondsUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ResumeSecondsUpDown.Value = new decimal(new int[] {
            34,
            0,
            0,
            0});
			// 
			// StartupSecondsUpDown
			// 
			this.StartupSecondsUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.StartupSecondsUpDown.Location = new System.Drawing.Point(308, 32);
			this.StartupSecondsUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
			this.StartupSecondsUpDown.Name = "StartupSecondsUpDown";
			this.StartupSecondsUpDown.Size = new System.Drawing.Size(40, 20);
			this.StartupSecondsUpDown.TabIndex = 5;
			this.StartupSecondsUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.StartupSecondsUpDown.Value = new decimal(new int[] {
            34,
            0,
            0,
            0});
			// 
			// ResumeLabel
			// 
			this.ResumeLabel.AutoSize = true;
			this.ResumeLabel.Checked = true;
			this.ResumeLabel.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ResumeLabel.Location = new System.Drawing.Point(6, 57);
			this.ResumeLabel.Name = "ResumeLabel";
			this.ResumeLabel.Size = new System.Drawing.Size(119, 17);
			this.ResumeLabel.TabIndex = 6;
			this.ResumeLabel.Text = "... Windows resume";
			this.ResumeLabel.UseVisualStyleBackColor = true;
			// 
			// StartupLabel
			// 
			this.StartupLabel.AutoSize = true;
			this.StartupLabel.Checked = true;
			this.StartupLabel.CheckState = System.Windows.Forms.CheckState.Checked;
			this.StartupLabel.Location = new System.Drawing.Point(6, 33);
			this.StartupLabel.Name = "StartupLabel";
			this.StartupLabel.Size = new System.Drawing.Size(131, 17);
			this.StartupLabel.TabIndex = 0;
			this.StartupLabel.Text = "... SVN Notifier startup";
			this.StartupLabel.UseVisualStyleBackColor = true;
			// 
			// StartupMinutesLabel
			// 
			this.StartupMinutesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.StartupMinutesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StartupMinutesLabel.Location = new System.Drawing.Point(251, 32);
			this.StartupMinutesLabel.Name = "StartupMinutesLabel";
			this.StartupMinutesLabel.Size = new System.Drawing.Size(8, 16);
			this.StartupMinutesLabel.TabIndex = 2;
			this.StartupMinutesLabel.Text = ":";
			this.StartupMinutesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ResumeMinutesLabel
			// 
			this.ResumeMinutesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ResumeMinutesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ResumeMinutesLabel.Location = new System.Drawing.Point(251, 56);
			this.ResumeMinutesLabel.Name = "ResumeMinutesLabel";
			this.ResumeMinutesLabel.Size = new System.Drawing.Size(8, 16);
			this.ResumeMinutesLabel.TabIndex = 8;
			this.ResumeMinutesLabel.Text = ":";
			this.ResumeMinutesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// PauseHoursLabel
			// 
			this.PauseHoursLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.PauseHoursLabel.AutoSize = true;
			this.PauseHoursLabel.Location = new System.Drawing.Point(209, 16);
			this.PauseHoursLabel.Name = "PauseHoursLabel";
			this.PauseHoursLabel.Size = new System.Drawing.Size(35, 13);
			this.PauseHoursLabel.TabIndex = 17;
			this.PauseHoursLabel.Text = "Hours";
			// 
			// ResumeSecondsLabel
			// 
			this.ResumeSecondsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ResumeSecondsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ResumeSecondsLabel.Location = new System.Drawing.Point(300, 56);
			this.ResumeSecondsLabel.Name = "ResumeSecondsLabel";
			this.ResumeSecondsLabel.Size = new System.Drawing.Size(8, 16);
			this.ResumeSecondsLabel.TabIndex = 9;
			this.ResumeSecondsLabel.Text = ":";
			this.ResumeSecondsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// PauseSecondsLabel
			// 
			this.PauseSecondsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.PauseSecondsLabel.AutoSize = true;
			this.PauseSecondsLabel.Location = new System.Drawing.Point(305, 16);
			this.PauseSecondsLabel.Name = "PauseSecondsLabel";
			this.PauseSecondsLabel.Size = new System.Drawing.Size(49, 13);
			this.PauseSecondsLabel.TabIndex = 12;
			this.PauseSecondsLabel.Text = "Seconds";
			// 
			// PauseMinutesLabel
			// 
			this.PauseMinutesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.PauseMinutesLabel.AutoSize = true;
			this.PauseMinutesLabel.Location = new System.Drawing.Point(257, 16);
			this.PauseMinutesLabel.Name = "PauseMinutesLabel";
			this.PauseMinutesLabel.Size = new System.Drawing.Size(44, 13);
			this.PauseMinutesLabel.TabIndex = 11;
			this.PauseMinutesLabel.Text = "Minutes";
			// 
			// StartupSecondsLanbel
			// 
			this.StartupSecondsLanbel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.StartupSecondsLanbel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StartupSecondsLanbel.Location = new System.Drawing.Point(300, 32);
			this.StartupSecondsLanbel.Name = "StartupSecondsLanbel";
			this.StartupSecondsLanbel.Size = new System.Drawing.Size(8, 16);
			this.StartupSecondsLanbel.TabIndex = 4;
			this.StartupSecondsLanbel.Text = ":";
			this.StartupSecondsLanbel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// StatusGroupBox
			// 
			this.StatusGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.StatusGroupBox.Controls.Add(this.InactiveHoursUpDown);
			this.StatusGroupBox.Controls.Add(this.ActiveHoursUpDown);
			this.StatusGroupBox.Controls.Add(this.InactiveMinutesUpDown);
			this.StatusGroupBox.Controls.Add(this.ActiveMinutesUpDown);
			this.StatusGroupBox.Controls.Add(this.InactiveSecondsUpDown);
			this.StatusGroupBox.Controls.Add(this.ActiveSecondsUpDown);
			this.StatusGroupBox.Controls.Add(this.ActiveMinutesLabel);
			this.StatusGroupBox.Controls.Add(this.InactiveMinutesLabel);
			this.StatusGroupBox.Controls.Add(this.StatusHoursLabel);
			this.StatusGroupBox.Controls.Add(this.InactiveSecondsLabel);
			this.StatusGroupBox.Controls.Add(this.StatusSecondsLabel);
			this.StatusGroupBox.Controls.Add(this.StatusMinutesLabel);
			this.StatusGroupBox.Controls.Add(this.ActiveSecondsLabel);
			this.StatusGroupBox.Controls.Add(this.ActiveLabel);
			this.StatusGroupBox.Controls.Add(this.InactiveLabel);
			this.StatusGroupBox.Location = new System.Drawing.Point(6, 6);
			this.StatusGroupBox.Name = "StatusGroupBox";
			this.StatusGroupBox.Size = new System.Drawing.Size(360, 88);
			this.StatusGroupBox.TabIndex = 0;
			this.StatusGroupBox.TabStop = false;
			this.StatusGroupBox.Text = "Default status checking interval when...";
			// 
			// InactiveHoursUpDown
			// 
			this.InactiveHoursUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.InactiveHoursUpDown.Location = new System.Drawing.Point(212, 56);
			this.InactiveHoursUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
			this.InactiveHoursUpDown.Name = "InactiveHoursUpDown";
			this.InactiveHoursUpDown.Size = new System.Drawing.Size(40, 20);
			this.InactiveHoursUpDown.TabIndex = 7;
			this.InactiveHoursUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.InactiveHoursUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
			// 
			// ActiveHoursUpDown
			// 
			this.ActiveHoursUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ActiveHoursUpDown.Location = new System.Drawing.Point(212, 32);
			this.ActiveHoursUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
			this.ActiveHoursUpDown.Name = "ActiveHoursUpDown";
			this.ActiveHoursUpDown.Size = new System.Drawing.Size(40, 20);
			this.ActiveHoursUpDown.TabIndex = 1;
			this.ActiveHoursUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ActiveHoursUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
			// 
			// InactiveMinutesUpDown
			// 
			this.InactiveMinutesUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.InactiveMinutesUpDown.Location = new System.Drawing.Point(260, 56);
			this.InactiveMinutesUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
			this.InactiveMinutesUpDown.Name = "InactiveMinutesUpDown";
			this.InactiveMinutesUpDown.Size = new System.Drawing.Size(40, 20);
			this.InactiveMinutesUpDown.TabIndex = 10;
			this.InactiveMinutesUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.InactiveMinutesUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
			// 
			// ActiveMinutesUpDown
			// 
			this.ActiveMinutesUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ActiveMinutesUpDown.Location = new System.Drawing.Point(260, 32);
			this.ActiveMinutesUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
			this.ActiveMinutesUpDown.Name = "ActiveMinutesUpDown";
			this.ActiveMinutesUpDown.Size = new System.Drawing.Size(40, 20);
			this.ActiveMinutesUpDown.TabIndex = 3;
			this.ActiveMinutesUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ActiveMinutesUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
			// 
			// InactiveSecondsUpDown
			// 
			this.InactiveSecondsUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.InactiveSecondsUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.InactiveSecondsUpDown.Location = new System.Drawing.Point(308, 56);
			this.InactiveSecondsUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
			this.InactiveSecondsUpDown.Name = "InactiveSecondsUpDown";
			this.InactiveSecondsUpDown.Size = new System.Drawing.Size(40, 20);
			this.InactiveSecondsUpDown.TabIndex = 13;
			this.InactiveSecondsUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.InactiveSecondsUpDown.Value = new decimal(new int[] {
            34,
            0,
            0,
            0});
			// 
			// ActiveSecondsUpDown
			// 
			this.ActiveSecondsUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ActiveSecondsUpDown.Location = new System.Drawing.Point(308, 32);
			this.ActiveSecondsUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
			this.ActiveSecondsUpDown.Name = "ActiveSecondsUpDown";
			this.ActiveSecondsUpDown.Size = new System.Drawing.Size(40, 20);
			this.ActiveSecondsUpDown.TabIndex = 5;
			this.ActiveSecondsUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ActiveSecondsUpDown.Value = new decimal(new int[] {
            34,
            0,
            0,
            0});
			// 
			// ActiveMinutesLabel
			// 
			this.ActiveMinutesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ActiveMinutesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ActiveMinutesLabel.Location = new System.Drawing.Point(251, 32);
			this.ActiveMinutesLabel.Name = "ActiveMinutesLabel";
			this.ActiveMinutesLabel.Size = new System.Drawing.Size(8, 16);
			this.ActiveMinutesLabel.TabIndex = 2;
			this.ActiveMinutesLabel.Text = ":";
			this.ActiveMinutesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// InactiveMinutesLabel
			// 
			this.InactiveMinutesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.InactiveMinutesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.InactiveMinutesLabel.Location = new System.Drawing.Point(251, 56);
			this.InactiveMinutesLabel.Name = "InactiveMinutesLabel";
			this.InactiveMinutesLabel.Size = new System.Drawing.Size(8, 16);
			this.InactiveMinutesLabel.TabIndex = 8;
			this.InactiveMinutesLabel.Text = ":";
			this.InactiveMinutesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// StatusHoursLabel
			// 
			this.StatusHoursLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.StatusHoursLabel.AutoSize = true;
			this.StatusHoursLabel.Location = new System.Drawing.Point(209, 16);
			this.StatusHoursLabel.Name = "StatusHoursLabel";
			this.StatusHoursLabel.Size = new System.Drawing.Size(35, 13);
			this.StatusHoursLabel.TabIndex = 17;
			this.StatusHoursLabel.Text = "Hours";
			// 
			// InactiveSecondsLabel
			// 
			this.InactiveSecondsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.InactiveSecondsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.InactiveSecondsLabel.Location = new System.Drawing.Point(300, 56);
			this.InactiveSecondsLabel.Name = "InactiveSecondsLabel";
			this.InactiveSecondsLabel.Size = new System.Drawing.Size(8, 16);
			this.InactiveSecondsLabel.TabIndex = 9;
			this.InactiveSecondsLabel.Text = ":";
			this.InactiveSecondsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// StatusSecondsLabel
			// 
			this.StatusSecondsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.StatusSecondsLabel.AutoSize = true;
			this.StatusSecondsLabel.Location = new System.Drawing.Point(305, 16);
			this.StatusSecondsLabel.Name = "StatusSecondsLabel";
			this.StatusSecondsLabel.Size = new System.Drawing.Size(49, 13);
			this.StatusSecondsLabel.TabIndex = 12;
			this.StatusSecondsLabel.Text = "Seconds";
			// 
			// StatusMinutesLabel
			// 
			this.StatusMinutesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.StatusMinutesLabel.AutoSize = true;
			this.StatusMinutesLabel.Location = new System.Drawing.Point(257, 16);
			this.StatusMinutesLabel.Name = "StatusMinutesLabel";
			this.StatusMinutesLabel.Size = new System.Drawing.Size(44, 13);
			this.StatusMinutesLabel.TabIndex = 11;
			this.StatusMinutesLabel.Text = "Minutes";
			// 
			// ActiveSecondsLabel
			// 
			this.ActiveSecondsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ActiveSecondsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ActiveSecondsLabel.Location = new System.Drawing.Point(300, 32);
			this.ActiveSecondsLabel.Name = "ActiveSecondsLabel";
			this.ActiveSecondsLabel.Size = new System.Drawing.Size(8, 16);
			this.ActiveSecondsLabel.TabIndex = 4;
			this.ActiveSecondsLabel.Text = ":";
			this.ActiveSecondsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ActiveLabel
			// 
			this.ActiveLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ActiveLabel.AutoSize = true;
			this.ActiveLabel.Location = new System.Drawing.Point(122, 34);
			this.ActiveLabel.Name = "ActiveLabel";
			this.ActiveLabel.Size = new System.Drawing.Size(84, 13);
			this.ActiveLabel.TabIndex = 0;
			this.ActiveLabel.Text = "... form is active:";
			this.ActiveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// InactiveLabel
			// 
			this.InactiveLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.InactiveLabel.AutoSize = true;
			this.InactiveLabel.Location = new System.Drawing.Point(104, 58);
			this.InactiveLabel.Name = "InactiveLabel";
			this.InactiveLabel.Size = new System.Drawing.Size(102, 13);
			this.InactiveLabel.TabIndex = 6;
			this.InactiveLabel.Text = "... form is not active:";
			this.InactiveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// UpdateTabPage
			// 
			this.UpdateTabPage.Controls.Add(this.RequiresTortoiseLabel);
			this.UpdateTabPage.Controls.Add(this.ChangeLogBeforeUpdateCheckBox);
			this.UpdateTabPage.Controls.Add(this.SilentlUpdateCheckBox);
			this.UpdateTabPage.Controls.Add(this.DialogActionLabel);
			this.UpdateTabPage.Controls.Add(this.DialogActiionDropDown);
			this.UpdateTabPage.Location = new System.Drawing.Point(4, 22);
			this.UpdateTabPage.Name = "UpdateTabPage";
			this.UpdateTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.UpdateTabPage.Size = new System.Drawing.Size(372, 255);
			this.UpdateTabPage.TabIndex = 1;
			this.UpdateTabPage.Text = "Update";
			// 
			// RequiresTortoiseLabel
			// 
			this.RequiresTortoiseLabel.AutoSize = true;
			this.RequiresTortoiseLabel.ForeColor = System.Drawing.SystemColors.GrayText;
			this.RequiresTortoiseLabel.Location = new System.Drawing.Point(44, 66);
			this.RequiresTortoiseLabel.Name = "RequiresTortoiseLabel";
			this.RequiresTortoiseLabel.Size = new System.Drawing.Size(186, 13);
			this.RequiresTortoiseLabel.TabIndex = 28;
			this.RequiresTortoiseLabel.Text = "(Requires TortoiseSVN v1.5 or higher)";
			// 
			// SettingsForm
			// 
			this.AcceptButton = this.OkButton;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.CloseButton;
			this.ClientSize = new System.Drawing.Size(404, 332);
			this.Controls.Add(this.MainTabControl);
			this.Controls.Add(this.CloseButton);
			this.Controls.Add(this.OkButton);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(420, 360);
			this.Name = "SettingsForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Settings";
			this.Load += new System.EventHandler(this.SettingsForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.HideSystemTrayUpDown)).EndInit();
			this.MainTabControl.ResumeLayout(false);
			this.GeneralTabPage.ResumeLayout(false);
			this.OtherOptionsGroupBox.ResumeLayout(false);
			this.OtherOptionsGroupBox.PerformLayout();
			this.LocationsGroupBox.ResumeLayout(false);
			this.LocationsGroupBox.PerformLayout();
			this.StatusTabPage.ResumeLayout(false);
			this.PauseGroupBox.ResumeLayout(false);
			this.PauseGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ResumeHoursUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.StartupHoursUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ResumeMinutesUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.StartupMinutesUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ResumeSecondsUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.StartupSecondsUpDown)).EndInit();
			this.StatusGroupBox.ResumeLayout(false);
			this.StatusGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.InactiveHoursUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ActiveHoursUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.InactiveMinutesUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ActiveMinutesUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.InactiveSecondsUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ActiveSecondsUpDown)).EndInit();
			this.UpdateTabPage.ResumeLayout(false);
			this.UpdateTabPage.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox OtherOptionsGroupBox;
		private System.Windows.Forms.GroupBox LocationsGroupBox;
		private System.Windows.Forms.Label SvnPathLabel;
		private System.Windows.Forms.Label TortoisePathLabel;
		private System.Windows.Forms.TextBox SvnPathTextBox;
		private System.Windows.Forms.TextBox TortoisePathTextBox;
		private System.Windows.Forms.Button OkButton;
		private System.Windows.Forms.Button CloseButton;
		private System.Windows.Forms.Button SvnBrowseButton;
		private System.Windows.Forms.Button TortoiseBrowseButton;
		private System.Windows.Forms.OpenFileDialog SvnFileDialog;
		private System.Windows.Forms.OpenFileDialog TortoiseFileDialog;
		private System.Windows.Forms.ComboBox DoubleClickComboBox;
		private System.Windows.Forms.Label DoubleClickLabel;
		private System.Windows.Forms.CheckBox HideOnStartupCheckBox;
		private System.Windows.Forms.CheckBox CheckForNewVersionCheckBox;
		private System.Windows.Forms.NumericUpDown HideSystemTrayUpDown;
		private System.Windows.Forms.Label HideSystemTrayLabel;
		private System.Windows.Forms.CheckBox ChangeLogBeforeUpdateCheckBox;
		private System.Windows.Forms.CheckBox SilentlUpdateCheckBox;
		private System.Windows.Forms.Label DialogActionLabel;
		private System.Windows.Forms.ComboBox DialogActiionDropDown;
		private System.Windows.Forms.TabControl MainTabControl;
		private System.Windows.Forms.TabPage GeneralTabPage;
		private System.Windows.Forms.TabPage UpdateTabPage;
		private System.Windows.Forms.TabPage StatusTabPage;
		private System.Windows.Forms.GroupBox StatusGroupBox;
		private System.Windows.Forms.Label ActiveMinutesLabel;
		private System.Windows.Forms.Label InactiveMinutesLabel;
		private System.Windows.Forms.Label StatusHoursLabel;
		private System.Windows.Forms.NumericUpDown InactiveHoursUpDown;
		private System.Windows.Forms.NumericUpDown ActiveHoursUpDown;
		private System.Windows.Forms.Label InactiveSecondsLabel;
		private System.Windows.Forms.NumericUpDown InactiveMinutesUpDown;
		private System.Windows.Forms.Label StatusSecondsLabel;
		private System.Windows.Forms.Label StatusMinutesLabel;
		private System.Windows.Forms.NumericUpDown ActiveMinutesUpDown;
		private System.Windows.Forms.Label ActiveSecondsLabel;
		private System.Windows.Forms.Label ActiveLabel;
		private System.Windows.Forms.NumericUpDown InactiveSecondsUpDown;
		private System.Windows.Forms.Label InactiveLabel;
		private System.Windows.Forms.NumericUpDown ActiveSecondsUpDown;
		private System.Windows.Forms.Label RequiresTortoiseLabel;
		private System.Windows.Forms.CheckBox ShowInTaskbarCheckBox;
		private System.Windows.Forms.GroupBox PauseGroupBox;
		private System.Windows.Forms.Label StartupMinutesLabel;
		private System.Windows.Forms.Label ResumeMinutesLabel;
		private System.Windows.Forms.Label PauseHoursLabel;
		private System.Windows.Forms.NumericUpDown ResumeHoursUpDown;
		private System.Windows.Forms.NumericUpDown StartupHoursUpDown;
		private System.Windows.Forms.Label ResumeSecondsLabel;
		private System.Windows.Forms.NumericUpDown ResumeMinutesUpDown;
		private System.Windows.Forms.Label PauseSecondsLabel;
		private System.Windows.Forms.Label PauseMinutesLabel;
		private System.Windows.Forms.NumericUpDown StartupMinutesUpDown;
		private System.Windows.Forms.Label StartupSecondsLanbel;
		private System.Windows.Forms.NumericUpDown ResumeSecondsUpDown;
		private System.Windows.Forms.NumericUpDown StartupSecondsUpDown;
		private System.Windows.Forms.CheckBox ResumeLabel;
		private System.Windows.Forms.CheckBox StartupLabel;

	}
}
