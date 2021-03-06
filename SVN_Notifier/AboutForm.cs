//
// SVN Notifier
// Copyright 2007 SIA Computer Hardware Design (www.chd.lv)
//
// This file is part of SVN Notifier.
//
// SVN Notifier is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation; either version 3 of the License, or
// (at your option) any later version.
//
// SVN Notifier is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>
//

using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CHD.SVN_Notifier
{

	public partial class AboutForm : Form
	{

		public AboutForm()
		{
			InitializeComponent();
			if (Parent == null)
				StartPosition = FormStartPosition.CenterScreen;
		}

		private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			var ll = (LinkLabel)sender;
			OpenLink("http://"+ ll.Text);
		}

		private void AboutForm_Load(object sender, EventArgs e)
		{
			TitleLabel.Text = string.Format(TitleLabel.Text, Application.ProductVersion);
		}

		private void OpenLink(string link)
		{
			// Ignore browser missing or delayed situations
			try
			{
				Process.Start(link);
			}
			catch { }
		}
	}
}
