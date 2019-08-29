namespace CHD.SVN_Notifier
{
	public partial class UpdateLogForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateLogForm));
			this.ShowLogButton = new System.Windows.Forms.Button();
			this.OkButton = new System.Windows.Forms.Button();
			this.CloseButton = new System.Windows.Forms.Button();
			this.ResultsLabel = new System.Windows.Forms.Label();
			this.LogListView = new System.Windows.Forms.ListView();
			this.ActionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.PathColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// ShowLogButton
			// 
			this.ShowLogButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ShowLogButton.Enabled = false;
			this.ShowLogButton.Location = new System.Drawing.Point(306, 326);
			this.ShowLogButton.Name = "ShowLogButton";
			this.ShowLogButton.Size = new System.Drawing.Size(104, 23);
			this.ShowLogButton.TabIndex = 0;
			this.ShowLogButton.Text = "Show log...";
			this.ShowLogButton.Click += new System.EventHandler(this.ShowLogButton_Click);
			// 
			// OkButton
			// 
			this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.OkButton.Location = new System.Drawing.Point(416, 326);
			this.OkButton.Name = "OkButton";
			this.OkButton.Size = new System.Drawing.Size(75, 23);
			this.OkButton.TabIndex = 1;
			this.OkButton.Text = "Ok";
			// 
			// CloseButton
			// 
			this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CloseButton.Enabled = false;
			this.CloseButton.Location = new System.Drawing.Point(497, 326);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size(75, 23);
			this.CloseButton.TabIndex = 2;
			this.CloseButton.Text = "Cancel";
			// 
			// ResultsLabel
			// 
			this.ResultsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ResultsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.ResultsLabel.Location = new System.Drawing.Point(12, 326);
			this.ResultsLabel.Name = "ResultsLabel";
			this.ResultsLabel.Size = new System.Drawing.Size(288, 23);
			this.ResultsLabel.TabIndex = 3;
			this.ResultsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LogListView
			// 
			this.LogListView.AllowColumnReorder = true;
			this.LogListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LogListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ActionColumn,
            this.PathColumn});
			this.LogListView.FullRowSelect = true;
			this.LogListView.HideSelection = false;
			this.LogListView.LabelWrap = false;
			this.LogListView.Location = new System.Drawing.Point(12, 12);
			this.LogListView.Name = "LogListView";
			this.LogListView.Size = new System.Drawing.Size(560, 308);
			this.LogListView.TabIndex = 5;
			this.LogListView.UseCompatibleStateImageBehavior = false;
			this.LogListView.View = System.Windows.Forms.View.Details;
			// 
			// ActionColumn
			// 
			this.ActionColumn.Text = "Action";
			this.ActionColumn.Width = 42;
			// 
			// PathColumn
			// 
			this.PathColumn.Text = "Path";
			this.PathColumn.Width = 498;
			// 
			// UpdateLogsForm
			// 
			this.AcceptButton = this.OkButton;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.CloseButton;
			this.ClientSize = new System.Drawing.Size(584, 361);
			this.Controls.Add(this.CloseButton);
			this.Controls.Add(this.OkButton);
			this.Controls.Add(this.ShowLogButton);
			this.Controls.Add(this.ResultsLabel);
			this.Controls.Add(this.LogListView);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(480, 300);
			this.Name = "UpdateLogsForm";
			this.Text = "Update Log";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button ShowLogButton;
		private System.Windows.Forms.Button OkButton;
		private System.Windows.Forms.Button CloseButton;
		private System.Windows.Forms.Label ResultsLabel;
		private System.Windows.Forms.ListView LogListView;
		private System.Windows.Forms.ColumnHeader ActionColumn;
		private System.Windows.Forms.ColumnHeader PathColumn;
	}
}
