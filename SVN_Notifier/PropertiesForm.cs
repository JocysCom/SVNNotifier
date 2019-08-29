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

using System.Windows.Forms;

namespace CHD.SVN_Notifier
{
	/// <summary>
	/// Summary description for SettingsProjectForm.
	/// </summary>
	public partial class PropertiesForm : Form
	{

		SvnItem _Folder;

		public PropertiesForm(SvnItem folder)
		{
			InitializeComponent();
			_Folder = folder;
			PathTextBox.Text = folder.Path;
			if (folder.ActiveStatusUpdateInterval < 0)
			{
				ActiveHoursUpDown.Value = Config.DefaultActiveStatusUpdateInterval / 3600;
				ActiveMinutesUpDown.Value = (Config.DefaultActiveStatusUpdateInterval % 3600) / 60;
				ActiveSecondsUpDown.Value = Config.DefaultActiveStatusUpdateInterval % 60;
				InactiveHoursUpDown.Value = Config.DefaultIdleStatusUpdateInterval / 3600;
				InactiveMinutesUpDown.Value = (Config.DefaultIdleStatusUpdateInterval % 3600) / 60;
				InactiveSecondsUpDown.Value = Config.DefaultIdleStatusUpdateInterval % 60;
				StatusUpdateCheckBox.Checked = false;
			}
			else
			{
				ActiveHoursUpDown.Value = folder.ActiveStatusUpdateInterval / 3600;
				ActiveMinutesUpDown.Value = (folder.ActiveStatusUpdateInterval % 3600) / 60;
				ActiveSecondsUpDown.Value = folder.ActiveStatusUpdateInterval % 60;
				InactiveHoursUpDown.Value = folder.IdleStatusUpdateInterval / 3600;
				InactiveMinutesUpDown.Value = (folder.IdleStatusUpdateInterval % 3600) / 60;
				InactiveSecondsUpDown.Value = folder.IdleStatusUpdateInterval % 60;
				StatusUpdateCheckBox.Checked = true;
			}
			EnableCheckBox.Checked = folder.Enabled;
			StatusUpdateCheckBox.Enabled = EnableCheckBox.Checked;
		}


		private void OkButton_Click(object sender, System.EventArgs e)
		{
			if (!StatusUpdateCheckBox.Checked)
			{
				_Folder.ActiveStatusUpdateInterval = -1;
				_Folder.IdleStatusUpdateInterval = -1;
			}
			else
			{
				_Folder.ActiveStatusUpdateInterval =
					(int)ActiveHoursUpDown.Value * 3600
					+ (int)ActiveMinutesUpDown.Value * 60
					+ (int)ActiveSecondsUpDown.Value;

				_Folder.IdleStatusUpdateInterval =
					(int)InactiveHoursUpDown.Value * 3600
					+ (int)InactiveMinutesUpDown.Value * 60
					+ (int)InactiveSecondsUpDown.Value;
			}
			_Folder.Enabled = EnableCheckBox.Checked;
			_Folder.Path = _Folder.origPath = PathTextBox.Text;
		}


		private void DisableCheckBox_CheckedChanged(object sender, System.EventArgs e)
		{
			StatusUpdateCheckBox.Enabled = !EnableCheckBox.Checked;
		}

		private void StatusUpdateCheckBox_CheckedChanged(object sender, System.EventArgs e)
		{
			StatusUpdatePanel.Enabled = StatusUpdateCheckBox.Checked;
		}
	}
}
