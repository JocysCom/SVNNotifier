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

using System.Collections;
using System.Windows.Forms;

namespace CHD.SVN_Notifier
{
	/// <summary>
	/// Summary description for SettingsProjectForm.
	/// </summary>
	public partial class ErrorLogForm : Form
	{

		public ErrorLogForm(Hashtable errorLog)
		{
			InitializeComponent();
			foreach (DictionaryEntry de in errorLog)
			{
				LogTextBox.Text += de.Value;
			}
		}


		private void ClearButton_Click(object sender, System.EventArgs e)
		{
			LogTextBox.Clear();
		}


		private void ButtonsTimer_Tick(object sender, System.EventArgs e)
		{
			ClearButton.Enabled = true;
			CloseButton.Enabled = true;
			ButtonsTimer.Enabled = false;
		}
	}
}
