namespace CHD.SVN_Notifier
{
	public partial class PropertiesForm
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

		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PropertiesForm));
			this.OkButton = new System.Windows.Forms.Button();
			this.StatusUpdateCheckBox = new System.Windows.Forms.CheckBox();
			this.InactiveMinutesLabel = new System.Windows.Forms.Label();
			this.ActiveMinutesLabel = new System.Windows.Forms.Label();
			this.StatusHoursLabel = new System.Windows.Forms.Label();
			this.InactiveHoursUpDown = new System.Windows.Forms.NumericUpDown();
			this.ActiveHoursUpDown = new System.Windows.Forms.NumericUpDown();
			this.StatusSecondsLabel = new System.Windows.Forms.Label();
			this.StatusMinutesLabel = new System.Windows.Forms.Label();
			this.InactiveSecondsLabel = new System.Windows.Forms.Label();
			this.InactiveMinutesUpDown = new System.Windows.Forms.NumericUpDown();
			this.ActiveMinutesUpDown = new System.Windows.Forms.NumericUpDown();
			this.ActiveSecondsLabel = new System.Windows.Forms.Label();
			this.FormIsActiveLabel = new System.Windows.Forms.Label();
			this.InactiveSecondsUpDown = new System.Windows.Forms.NumericUpDown();
			this.FormIsInactiveLabel = new System.Windows.Forms.Label();
			this.ActiveSecondsUpDown = new System.Windows.Forms.NumericUpDown();
			this.CloseButton = new System.Windows.Forms.Button();
			this.EnableCheckBox = new System.Windows.Forms.CheckBox();
			this.PathTextBox = new System.Windows.Forms.TextBox();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.PathLabel = new System.Windows.Forms.Label();
			this.StatusUpdatePanel = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.InactiveHoursUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ActiveHoursUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.InactiveMinutesUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ActiveMinutesUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.InactiveSecondsUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ActiveSecondsUpDown)).BeginInit();
			this.StatusUpdatePanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// OkButton
			// 
			this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.OkButton.Location = new System.Drawing.Point(200, 166);
			this.OkButton.Name = "OkButton";
			this.OkButton.Size = new System.Drawing.Size(72, 23);
			this.OkButton.TabIndex = 1;
			this.OkButton.Text = "OK";
			this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
			// 
			// StatusUpdateCheckBox
			// 
			this.StatusUpdateCheckBox.AutoSize = true;
			this.StatusUpdateCheckBox.Location = new System.Drawing.Point(12, 38);
			this.StatusUpdateCheckBox.Name = "StatusUpdateCheckBox";
			this.StatusUpdateCheckBox.Size = new System.Drawing.Size(167, 17);
			this.StatusUpdateCheckBox.TabIndex = 6;
			this.StatusUpdateCheckBox.TabStop = false;
			this.StatusUpdateCheckBox.Text = "Status update interval when...";
			this.StatusUpdateCheckBox.CheckedChanged += new System.EventHandler(this.StatusUpdateCheckBox_CheckedChanged);
			// 
			// InactiveMinutesLabel
			// 
			this.InactiveMinutesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.InactiveMinutesLabel.Location = new System.Drawing.Point(236, 43);
			this.InactiveMinutesLabel.Name = "InactiveMinutesLabel";
			this.InactiveMinutesLabel.Size = new System.Drawing.Size(8, 16);
			this.InactiveMinutesLabel.TabIndex = 25;
			this.InactiveMinutesLabel.Text = ":";
			this.InactiveMinutesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ActiveMinutesLabel
			// 
			this.ActiveMinutesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ActiveMinutesLabel.Location = new System.Drawing.Point(236, 19);
			this.ActiveMinutesLabel.Name = "ActiveMinutesLabel";
			this.ActiveMinutesLabel.Size = new System.Drawing.Size(8, 16);
			this.ActiveMinutesLabel.TabIndex = 24;
			this.ActiveMinutesLabel.Text = ":";
			this.ActiveMinutesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// StatusHoursLabel
			// 
			this.StatusHoursLabel.AutoSize = true;
			this.StatusHoursLabel.Location = new System.Drawing.Point(193, 3);
			this.StatusHoursLabel.Name = "StatusHoursLabel";
			this.StatusHoursLabel.Size = new System.Drawing.Size(35, 13);
			this.StatusHoursLabel.TabIndex = 23;
			this.StatusHoursLabel.Text = "Hours";
			// 
			// InactiveHoursUpDown
			// 
			this.InactiveHoursUpDown.Location = new System.Drawing.Point(196, 43);
			this.InactiveHoursUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
			this.InactiveHoursUpDown.Name = "InactiveHoursUpDown";
			this.InactiveHoursUpDown.Size = new System.Drawing.Size(40, 20);
			this.InactiveHoursUpDown.TabIndex = 22;
			this.InactiveHoursUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.InactiveHoursUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
			// 
			// ActiveHoursUpDown
			// 
			this.ActiveHoursUpDown.Location = new System.Drawing.Point(196, 19);
			this.ActiveHoursUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
			this.ActiveHoursUpDown.Name = "ActiveHoursUpDown";
			this.ActiveHoursUpDown.Size = new System.Drawing.Size(40, 20);
			this.ActiveHoursUpDown.TabIndex = 21;
			this.ActiveHoursUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ActiveHoursUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
			// 
			// StatusSecondsLabel
			// 
			this.StatusSecondsLabel.AutoSize = true;
			this.StatusSecondsLabel.Location = new System.Drawing.Point(289, 3);
			this.StatusSecondsLabel.Name = "StatusSecondsLabel";
			this.StatusSecondsLabel.Size = new System.Drawing.Size(49, 13);
			this.StatusSecondsLabel.TabIndex = 20;
			this.StatusSecondsLabel.Text = "Seconds";
			// 
			// StatusMinutesLabel
			// 
			this.StatusMinutesLabel.AutoSize = true;
			this.StatusMinutesLabel.Location = new System.Drawing.Point(241, 3);
			this.StatusMinutesLabel.Name = "StatusMinutesLabel";
			this.StatusMinutesLabel.Size = new System.Drawing.Size(44, 13);
			this.StatusMinutesLabel.TabIndex = 19;
			this.StatusMinutesLabel.Text = "Minutes";
			// 
			// InactiveSecondsLabel
			// 
			this.InactiveSecondsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.InactiveSecondsLabel.Location = new System.Drawing.Point(284, 43);
			this.InactiveSecondsLabel.Name = "InactiveSecondsLabel";
			this.InactiveSecondsLabel.Size = new System.Drawing.Size(8, 16);
			this.InactiveSecondsLabel.TabIndex = 18;
			this.InactiveSecondsLabel.Text = ":";
			this.InactiveSecondsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// InactiveMinutesUpDown
			// 
			this.InactiveMinutesUpDown.Location = new System.Drawing.Point(244, 43);
			this.InactiveMinutesUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
			this.InactiveMinutesUpDown.Name = "InactiveMinutesUpDown";
			this.InactiveMinutesUpDown.Size = new System.Drawing.Size(40, 20);
			this.InactiveMinutesUpDown.TabIndex = 17;
			this.InactiveMinutesUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.InactiveMinutesUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
			// 
			// ActiveMinutesUpDown
			// 
			this.ActiveMinutesUpDown.Location = new System.Drawing.Point(244, 19);
			this.ActiveMinutesUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
			this.ActiveMinutesUpDown.Name = "ActiveMinutesUpDown";
			this.ActiveMinutesUpDown.Size = new System.Drawing.Size(40, 20);
			this.ActiveMinutesUpDown.TabIndex = 16;
			this.ActiveMinutesUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ActiveMinutesUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
			// 
			// ActiveSecondsLabel
			// 
			this.ActiveSecondsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ActiveSecondsLabel.Location = new System.Drawing.Point(284, 19);
			this.ActiveSecondsLabel.Name = "ActiveSecondsLabel";
			this.ActiveSecondsLabel.Size = new System.Drawing.Size(8, 16);
			this.ActiveSecondsLabel.TabIndex = 15;
			this.ActiveSecondsLabel.Text = ":";
			this.ActiveSecondsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FormIsActiveLabel
			// 
			this.FormIsActiveLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.FormIsActiveLabel.AutoSize = true;
			this.FormIsActiveLabel.Location = new System.Drawing.Point(106, 21);
			this.FormIsActiveLabel.Name = "FormIsActiveLabel";
			this.FormIsActiveLabel.Size = new System.Drawing.Size(84, 13);
			this.FormIsActiveLabel.TabIndex = 4;
			this.FormIsActiveLabel.Text = "... form is active:";
			this.FormIsActiveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// InactiveSecondsUpDown
			// 
			this.InactiveSecondsUpDown.Location = new System.Drawing.Point(292, 43);
			this.InactiveSecondsUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
			this.InactiveSecondsUpDown.Name = "InactiveSecondsUpDown";
			this.InactiveSecondsUpDown.Size = new System.Drawing.Size(40, 20);
			this.InactiveSecondsUpDown.TabIndex = 1;
			this.InactiveSecondsUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.InactiveSecondsUpDown.Value = new decimal(new int[] {
            34,
            0,
            0,
            0});
			// 
			// FormIsInactiveLabel
			// 
			this.FormIsInactiveLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.FormIsInactiveLabel.AutoSize = true;
			this.FormIsInactiveLabel.Location = new System.Drawing.Point(88, 45);
			this.FormIsInactiveLabel.Name = "FormIsInactiveLabel";
			this.FormIsInactiveLabel.Size = new System.Drawing.Size(102, 13);
			this.FormIsInactiveLabel.TabIndex = 5;
			this.FormIsInactiveLabel.Text = "... form is not active:";
			this.FormIsInactiveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ActiveSecondsUpDown
			// 
			this.ActiveSecondsUpDown.Location = new System.Drawing.Point(292, 19);
			this.ActiveSecondsUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
			this.ActiveSecondsUpDown.Name = "ActiveSecondsUpDown";
			this.ActiveSecondsUpDown.Size = new System.Drawing.Size(40, 20);
			this.ActiveSecondsUpDown.TabIndex = 0;
			this.ActiveSecondsUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ActiveSecondsUpDown.Value = new decimal(new int[] {
            34,
            0,
            0,
            0});
			// 
			// CloseButton
			// 
			this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CloseButton.Location = new System.Drawing.Point(278, 166);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size(72, 23);
			this.CloseButton.TabIndex = 7;
			this.CloseButton.Text = "Cancel";
			// 
			// EnableCheckBox
			// 
			this.EnableCheckBox.AutoSize = true;
			this.EnableCheckBox.Location = new System.Drawing.Point(12, 144);
			this.EnableCheckBox.Name = "EnableCheckBox";
			this.EnableCheckBox.Size = new System.Drawing.Size(106, 17);
			this.EnableCheckBox.TabIndex = 8;
			this.EnableCheckBox.Text = "Enable checking";
			this.EnableCheckBox.CheckedChanged += new System.EventHandler(this.DisableCheckBox_CheckedChanged);
			// 
			// PathTextBox
			// 
			this.PathTextBox.Location = new System.Drawing.Point(50, 12);
			this.PathTextBox.Name = "PathTextBox";
			this.PathTextBox.Size = new System.Drawing.Size(300, 20);
			this.PathTextBox.TabIndex = 9;
			// 
			// folderBrowserDialog
			// 
			this.folderBrowserDialog.Description = "Select folder controlled by Subversion";
			this.folderBrowserDialog.ShowNewFolderButton = false;
			// 
			// PathLabel
			// 
			this.PathLabel.AutoSize = true;
			this.PathLabel.Location = new System.Drawing.Point(12, 14);
			this.PathLabel.Name = "PathLabel";
			this.PathLabel.Size = new System.Drawing.Size(32, 13);
			this.PathLabel.TabIndex = 10;
			this.PathLabel.Text = "Path:";
			// 
			// StatusUpdatePanel
			// 
			this.StatusUpdatePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.StatusUpdatePanel.Controls.Add(this.ActiveSecondsUpDown);
			this.StatusUpdatePanel.Controls.Add(this.InactiveSecondsUpDown);
			this.StatusUpdatePanel.Controls.Add(this.InactiveHoursUpDown);
			this.StatusUpdatePanel.Controls.Add(this.ActiveHoursUpDown);
			this.StatusUpdatePanel.Controls.Add(this.ActiveMinutesUpDown);
			this.StatusUpdatePanel.Controls.Add(this.InactiveMinutesUpDown);
			this.StatusUpdatePanel.Controls.Add(this.StatusHoursLabel);
			this.StatusUpdatePanel.Controls.Add(this.InactiveMinutesLabel);
			this.StatusUpdatePanel.Controls.Add(this.FormIsInactiveLabel);
			this.StatusUpdatePanel.Controls.Add(this.ActiveMinutesLabel);
			this.StatusUpdatePanel.Controls.Add(this.FormIsActiveLabel);
			this.StatusUpdatePanel.Controls.Add(this.ActiveSecondsLabel);
			this.StatusUpdatePanel.Controls.Add(this.StatusSecondsLabel);
			this.StatusUpdatePanel.Controls.Add(this.StatusMinutesLabel);
			this.StatusUpdatePanel.Controls.Add(this.InactiveSecondsLabel);
			this.StatusUpdatePanel.Enabled = false;
			this.StatusUpdatePanel.Location = new System.Drawing.Point(12, 61);
			this.StatusUpdatePanel.Name = "StatusUpdatePanel";
			this.StatusUpdatePanel.Padding = new System.Windows.Forms.Padding(3);
			this.StatusUpdatePanel.Size = new System.Drawing.Size(338, 77);
			this.StatusUpdatePanel.TabIndex = 11;
			// 
			// PropertiesForm
			// 
			this.AcceptButton = this.OkButton;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.CloseButton;
			this.ClientSize = new System.Drawing.Size(362, 201);
			this.Controls.Add(this.StatusUpdatePanel);
			this.Controls.Add(this.PathLabel);
			this.Controls.Add(this.EnableCheckBox);
			this.Controls.Add(this.CloseButton);
			this.Controls.Add(this.StatusUpdateCheckBox);
			this.Controls.Add(this.OkButton);
			this.Controls.Add(this.PathTextBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PropertiesForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Properties";
			((System.ComponentModel.ISupportInitialize)(this.InactiveHoursUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ActiveHoursUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.InactiveMinutesUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ActiveMinutesUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.InactiveSecondsUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ActiveSecondsUpDown)).EndInit();
			this.StatusUpdatePanel.ResumeLayout(false);
			this.StatusUpdatePanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

		private System.Windows.Forms.Button OkButton;
		private System.Windows.Forms.CheckBox StatusUpdateCheckBox;
		private System.Windows.Forms.Label FormIsActiveLabel;
		private System.Windows.Forms.Label FormIsInactiveLabel;
		private System.Windows.Forms.Button CloseButton;
		private System.Windows.Forms.Label InactiveSecondsLabel;
		private System.Windows.Forms.Label ActiveSecondsLabel;
		private System.Windows.Forms.NumericUpDown InactiveSecondsUpDown;
		private System.Windows.Forms.NumericUpDown ActiveSecondsUpDown;
		private System.Windows.Forms.NumericUpDown InactiveMinutesUpDown;
		private System.Windows.Forms.NumericUpDown ActiveMinutesUpDown;
		private System.Windows.Forms.Label StatusSecondsLabel;
		private System.Windows.Forms.Label StatusMinutesLabel;
		private System.Windows.Forms.Label StatusHoursLabel;
		private System.Windows.Forms.NumericUpDown InactiveHoursUpDown;
		private System.Windows.Forms.NumericUpDown ActiveHoursUpDown;
		private System.Windows.Forms.Label InactiveMinutesLabel;
		private System.Windows.Forms.Label ActiveMinutesLabel;
		private System.Windows.Forms.CheckBox EnableCheckBox;
		private System.Windows.Forms.TextBox PathTextBox;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.Windows.Forms.Label PathLabel;
		private System.Windows.Forms.Panel StatusUpdatePanel;

	}
}
