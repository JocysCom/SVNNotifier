namespace CHD.SVN_Notifier
{
	public partial class ErrorLogForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorLogForm));
			this.CloseButton = new System.Windows.Forms.Button();
			this.LogTextBox = new System.Windows.Forms.TextBox();
			this.ClearButton = new System.Windows.Forms.Button();
			this.ButtonsTimer = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// CloseButton
			// 
			this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CloseButton.Enabled = false;
			this.CloseButton.Location = new System.Drawing.Point(500, 326);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size(72, 23);
			this.CloseButton.TabIndex = 7;
			this.CloseButton.Text = "Close";
			// 
			// LogTextBox
			// 
			this.LogTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LogTextBox.Location = new System.Drawing.Point(12, 12);
			this.LogTextBox.Multiline = true;
			this.LogTextBox.Name = "LogTextBox";
			this.LogTextBox.ReadOnly = true;
			this.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.LogTextBox.Size = new System.Drawing.Size(560, 308);
			this.LogTextBox.TabIndex = 8;
			// 
			// ClearButton
			// 
			this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ClearButton.DialogResult = System.Windows.Forms.DialogResult.Abort;
			this.ClearButton.Enabled = false;
			this.ClearButton.Location = new System.Drawing.Point(422, 326);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(72, 23);
			this.ClearButton.TabIndex = 9;
			this.ClearButton.Text = "Clear";
			this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
			// 
			// ButtonsTimer
			// 
			this.ButtonsTimer.Enabled = true;
			this.ButtonsTimer.Interval = 1000;
			this.ButtonsTimer.Tick += new System.EventHandler(this.ButtonsTimer_Tick);
			// 
			// ErrorLogForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(584, 361);
			this.Controls.Add(this.ClearButton);
			this.Controls.Add(this.LogTextBox);
			this.Controls.Add(this.CloseButton);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(480, 300);
			this.Name = "ErrorLogForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Error Log";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

		private System.Windows.Forms.Button CloseButton;
		private System.Windows.Forms.TextBox LogTextBox;
		private System.Windows.Forms.Timer ButtonsTimer;
		private System.Windows.Forms.Button ClearButton;

	}
}
