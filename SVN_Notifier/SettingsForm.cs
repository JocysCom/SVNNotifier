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

using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CHD.SVN_Notifier
{
	public partial class SettingsForm : Form
	{
		public SettingsForm()
		{
			InitializeComponent();
		}

		private void SettingsForm_Load(object sender, System.EventArgs e)
		{
			SvnPathTextBox.Text = Config.SVNpath;
			TortoisePathTextBox.Text = Config.TortoiseSVNpath;
			
			ActiveHoursUpDown.Value = Config.DefaultActiveStatusUpdateInterval / 3600;
			ActiveMinutesUpDown.Value = (Config.DefaultActiveStatusUpdateInterval % 3600) / 60;
			ActiveSecondsUpDown.Value = Config.DefaultActiveStatusUpdateInterval % 60;

			InactiveHoursUpDown.Value = Config.DefaultIdleStatusUpdateInterval / 3600;
			InactiveMinutesUpDown.Value = (Config.DefaultIdleStatusUpdateInterval % 3600) / 60;
			InactiveSecondsUpDown.Value = Config.DefaultIdleStatusUpdateInterval % 60;

			StartupHoursUpDown.Value = Config.PauseAfterApplicationStartupInterval / 3600;
			StartupMinutesUpDown.Value = (Config.PauseAfterApplicationStartupInterval % 3600) / 60;
			StartupSecondsUpDown.Value = Config.PauseAfterApplicationStartupInterval % 60;
			StartupLabel.Checked = Config.DoPauseAfterApplicationStartup;

			ResumeHoursUpDown.Value = Config.PauseAfterWindowsResumeInterval / 3600;
			ResumeMinutesUpDown.Value = (Config.PauseAfterWindowsResumeInterval % 3600) / 60;
			ResumeSecondsUpDown.Value = Config.PauseAfterWindowsResumeInterval % 60;
			ResumeLabel.Checked = Config.DoPauseAfterWindowsResume;

			if (Config.IsTortoiseVersion_1_5_orHigher())
			{
				ChangeLogBeforeUpdateCheckBox.Checked = Config.ChangeLogBeforeUpdate;
				ChangeLogBeforeUpdateCheckBox.Enabled = true;
			}
			else
			{
				ChangeLogBeforeUpdateCheckBox.Checked = false;
				ChangeLogBeforeUpdateCheckBox.Enabled = false;
			}

			DoubleClickComboBox.SelectedIndex = (int) Config.ItemDoubleClickAction;
			HideSystemTrayUpDown.Value = Config.ShowBalloonInterval / 1000;
			HideOnStartupCheckBox.Checked = Config.HideOnStartup;
			ShowInTaskbarCheckBox.Checked = Config.ShowInTaskbar;
			CheckForNewVersionCheckBox.Checked = Config.CheckForNewVersion;
			SilentlUpdateCheckBox.Checked = Config.UpdateAllSilently;
			DialogActiionDropDown.SelectedIndex = Config.UpdateWindowAction;
		}


		private void button_OK_Click(object sender, System.EventArgs e)
		{
			Config.SVNpath = SvnPathTextBox.Text;
			Config.TortoiseSVNpath = TortoisePathTextBox.Text;

			Config.DefaultActiveStatusUpdateInterval = 
				(int)ActiveHoursUpDown.Value * 3600
				+ (int)ActiveMinutesUpDown.Value * 60 
				+ (int)ActiveSecondsUpDown.Value;

			Config.DefaultIdleStatusUpdateInterval = 
				(int)InactiveHoursUpDown.Value * 3600
				+ (int)InactiveMinutesUpDown.Value * 60
				+ (int)InactiveSecondsUpDown.Value;

			Config.PauseAfterApplicationStartupInterval =
				(int)StartupHoursUpDown.Value * 3600
				+ (int)StartupMinutesUpDown.Value * 60
				+ (int)StartupSecondsUpDown.Value;
			Config.DoPauseAfterApplicationStartup = StartupLabel.Checked;

			Config.PauseAfterWindowsResumeInterval =
				(int)ResumeHoursUpDown.Value * 3600
				+ (int)ResumeMinutesUpDown.Value * 60
				+ (int)ResumeSecondsUpDown.Value;
			Config.DoPauseAfterWindowsResume = ResumeLabel.Checked;

			Config.ChangeLogBeforeUpdate = ChangeLogBeforeUpdateCheckBox.Checked;
			Config.ItemDoubleClickAction = (Config.Action) DoubleClickComboBox.SelectedIndex;
			Config.ShowBalloonInterval = (int)HideSystemTrayUpDown.Value * 1000;
			Config.HideOnStartup = HideOnStartupCheckBox.Checked;
			Config.ShowInTaskbar = ShowInTaskbarCheckBox.Checked;
			Config.CheckForNewVersion = CheckForNewVersionCheckBox.Checked;
			Config.UpdateAllSilently = SilentlUpdateCheckBox.Checked;
			Config.UpdateWindowAction = DialogActiionDropDown.SelectedIndex;

			Config.SaveSettings();
			Close();
		}


		private void button_BrowseSvn_Click(object sender, System.EventArgs e)
		{
			if (SvnFileDialog.ShowDialog (this) == DialogResult.OK)
			{
				SvnPathTextBox.Text = SvnFileDialog.FileName;
				CheckPathes (sender, e);
			}
		}

		
		private void button_BrowseTortoise_Click(object sender, System.EventArgs e)
		{
			if (TortoiseFileDialog.ShowDialog (this) == DialogResult.OK)
			{
				TortoisePathTextBox.Text = TortoiseFileDialog.FileName;
				CheckPathes (sender, e);
			}
		}


		private void CheckPathes (object sender, System.EventArgs e)
		{
			OkButton.Enabled = true;
			SvnPathTextBox.BackColor = TortoisePathTextBox.BackColor = Color.White;

			if (!File.Exists (SvnPathTextBox.Text))
			{
				SvnPathTextBox.BackColor = Color.Yellow;
				OkButton.Enabled = false;

			}
				
			if (!File.Exists (TortoisePathTextBox.Text))
			{
				TortoisePathTextBox.BackColor = Color.Yellow;
				OkButton.Enabled = false;
			}
		}

		private void checkBox_ChangeLogBeforeUpdate_CheckedChanged(object sender, System.EventArgs e)
		{
			SilentlUpdateCheckBox.Enabled = !ChangeLogBeforeUpdateCheckBox.Checked;

			if (! SilentlUpdateCheckBox.Enabled)
				SilentlUpdateCheckBox.Checked = false;
		}
	}
}
