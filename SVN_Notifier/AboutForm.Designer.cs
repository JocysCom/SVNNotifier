namespace CHD.SVN_Notifier
{
	public partial class AboutForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
			this.OkButton = new System.Windows.Forms.Button();
			this.CompanyLinkLabel = new System.Windows.Forms.LinkLabel();
			this.TitleLabel = new System.Windows.Forms.Label();
			this.CopyrightLabel = new System.Windows.Forms.Label();
			this.DescriptionLabel = new System.Windows.Forms.Label();
			this.DevelopersLabel = new System.Windows.Forms.Label();
			this.ProjectLabel = new System.Windows.Forms.Label();
			this.ProjectLinkLabel = new System.Windows.Forms.LinkLabel();
			this.HeaderPictureBox = new System.Windows.Forms.PictureBox();
			this.BodyPanel = new System.Windows.Forms.Panel();
			this.GitHubLabel = new System.Windows.Forms.Label();
			this.GitHubLinkLinkLabel = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.HeaderPictureBox)).BeginInit();
			this.BodyPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// OkButton
			// 
			this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.OkButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.OkButton.Location = new System.Drawing.Point(232, 268);
			this.OkButton.Name = "OkButton";
			this.OkButton.Size = new System.Drawing.Size(80, 23);
			this.OkButton.TabIndex = 1;
			this.OkButton.Text = "OK";
			// 
			// CompanyLinkLabel
			// 
			this.CompanyLinkLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.CompanyLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CompanyLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
			this.CompanyLinkLabel.Location = new System.Drawing.Point(0, 64);
			this.CompanyLinkLabel.Name = "CompanyLinkLabel";
			this.CompanyLinkLabel.Size = new System.Drawing.Size(324, 16);
			this.CompanyLinkLabel.TabIndex = 2;
			this.CompanyLinkLabel.TabStop = true;
			this.CompanyLinkLabel.Text = "www.chd.lv";
			this.CompanyLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.CompanyLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_LinkClicked);
			// 
			// TitleLabel
			// 
			this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TitleLabel.Location = new System.Drawing.Point(0, 0);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new System.Drawing.Size(324, 32);
			this.TitleLabel.TabIndex = 3;
			this.TitleLabel.Text = "SVN Notifier {0}";
			this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// CopyrightLabel
			// 
			this.CopyrightLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.CopyrightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CopyrightLabel.Location = new System.Drawing.Point(0, 32);
			this.CopyrightLabel.Name = "CopyrightLabel";
			this.CopyrightLabel.Size = new System.Drawing.Size(324, 32);
			this.CopyrightLabel.TabIndex = 4;
			this.CopyrightLabel.Text = "Copyright (C) 2007-2011 Computer Hardware Design Ltd";
			this.CopyrightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// DescriptionLabel
			// 
			this.DescriptionLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DescriptionLabel.Location = new System.Drawing.Point(0, 160);
			this.DescriptionLabel.Name = "DescriptionLabel";
			this.DescriptionLabel.Size = new System.Drawing.Size(324, 32);
			this.DescriptionLabel.TabIndex = 5;
			this.DescriptionLabel.Text = "SVN Notifier is Open Source Software released under the GNU General Public Licens" +
    "e v3.";
			this.DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// DevelopersLabel
			// 
			this.DevelopersLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.DevelopersLabel.Location = new System.Drawing.Point(0, 192);
			this.DevelopersLabel.Name = "DevelopersLabel";
			this.DevelopersLabel.Size = new System.Drawing.Size(324, 32);
			this.DevelopersLabel.TabIndex = 6;
			this.DevelopersLabel.Text = "Developers: Vlad Rudenko, Aleksej Vaschenko, Nikolaj Nahimov";
			this.DevelopersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ProjectLabel
			// 
			this.ProjectLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.ProjectLabel.Location = new System.Drawing.Point(0, 128);
			this.ProjectLabel.Name = "ProjectLabel";
			this.ProjectLabel.Size = new System.Drawing.Size(324, 16);
			this.ProjectLabel.TabIndex = 7;
			this.ProjectLabel.Text = "Project Home - Version 1.x:";
			this.ProjectLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// ProjectLinkLabel
			// 
			this.ProjectLinkLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.ProjectLinkLabel.Location = new System.Drawing.Point(0, 144);
			this.ProjectLinkLabel.Name = "ProjectLinkLabel";
			this.ProjectLinkLabel.Size = new System.Drawing.Size(324, 16);
			this.ProjectLinkLabel.TabIndex = 9;
			this.ProjectLinkLabel.TabStop = true;
			this.ProjectLinkLabel.Text = "svnnotifier.tigris.org";
			this.ProjectLinkLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.ProjectLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_LinkClicked);
			// 
			// HeaderPictureBox
			// 
			this.HeaderPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.HeaderPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("HeaderPictureBox.Image")));
			this.HeaderPictureBox.Location = new System.Drawing.Point(0, 0);
			this.HeaderPictureBox.Name = "HeaderPictureBox";
			this.HeaderPictureBox.Size = new System.Drawing.Size(324, 41);
			this.HeaderPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.HeaderPictureBox.TabIndex = 10;
			this.HeaderPictureBox.TabStop = false;
			// 
			// BodyPanel
			// 
			this.BodyPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.BodyPanel.BackColor = System.Drawing.Color.White;
			this.BodyPanel.Controls.Add(this.GitHubLabel);
			this.BodyPanel.Controls.Add(this.GitHubLinkLinkLabel);
			this.BodyPanel.Controls.Add(this.ProjectLabel);
			this.BodyPanel.Controls.Add(this.ProjectLinkLabel);
			this.BodyPanel.Controls.Add(this.CompanyLinkLabel);
			this.BodyPanel.Controls.Add(this.DescriptionLabel);
			this.BodyPanel.Controls.Add(this.CopyrightLabel);
			this.BodyPanel.Controls.Add(this.TitleLabel);
			this.BodyPanel.Controls.Add(this.DevelopersLabel);
			this.BodyPanel.Location = new System.Drawing.Point(0, 38);
			this.BodyPanel.Name = "BodyPanel";
			this.BodyPanel.Size = new System.Drawing.Size(324, 224);
			this.BodyPanel.TabIndex = 11;
			// 
			// GitHubLabel
			// 
			this.GitHubLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.GitHubLabel.Location = new System.Drawing.Point(0, 96);
			this.GitHubLabel.Name = "GitHubLabel";
			this.GitHubLabel.Size = new System.Drawing.Size(324, 16);
			this.GitHubLabel.TabIndex = 10;
			this.GitHubLabel.Text = "Project Home - Version 2.x:";
			this.GitHubLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// GitHubLinkLinkLabel
			// 
			this.GitHubLinkLinkLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.GitHubLinkLinkLabel.Location = new System.Drawing.Point(0, 112);
			this.GitHubLinkLinkLabel.Name = "GitHubLinkLinkLabel";
			this.GitHubLinkLinkLabel.Size = new System.Drawing.Size(324, 16);
			this.GitHubLinkLinkLabel.TabIndex = 11;
			this.GitHubLinkLinkLabel.TabStop = true;
			this.GitHubLinkLinkLabel.Text = "github.com/JocysCom/SVNNotifier";
			this.GitHubLinkLinkLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.GitHubLinkLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_LinkClicked);
			// 
			// AboutForm
			// 
			this.AcceptButton = this.OkButton;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.OkButton;
			this.ClientSize = new System.Drawing.Size(324, 303);
			this.Controls.Add(this.BodyPanel);
			this.Controls.Add(this.HeaderPictureBox);
			this.Controls.Add(this.OkButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "About";
			this.Load += new System.EventHandler(this.AboutForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.HeaderPictureBox)).EndInit();
			this.BodyPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private System.Windows.Forms.Button OkButton;
		private System.Windows.Forms.LinkLabel CompanyLinkLabel;
		private System.Windows.Forms.Label TitleLabel;
		private System.Windows.Forms.Label CopyrightLabel;
		private System.Windows.Forms.Label DescriptionLabel;
		private System.Windows.Forms.Label DevelopersLabel;
		private System.Windows.Forms.Label ProjectLabel;
		private System.Windows.Forms.LinkLabel ProjectLinkLabel;
		private System.Windows.Forms.PictureBox HeaderPictureBox;
		private System.Windows.Forms.Panel BodyPanel;
		private System.Windows.Forms.Label GitHubLabel;
		private System.Windows.Forms.LinkLabel GitHubLinkLinkLabel;
	}
}
