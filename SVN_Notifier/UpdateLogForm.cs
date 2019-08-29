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
using System.Collections;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CHD.SVN_Notifier
{
	public partial class UpdateLogForm : Form
	{

		[DllImport("winmm.dll", EntryPoint = "PlaySound", CharSet = CharSet.Auto)]
		private static extern int PlaySound(String pszSound, int hmod, int falgs);


		/// <summary>
		/// API Parameter Flags for PlaySound method
		/// </summary>
		[Flags]
		public enum SND
		{
			SND_SYNC = 0x0000,/* play synchronously (default) */
			SND_ASYNC = 0x0001, /* play asynchronously */
			SND_NODEFAULT = 0x0002, /* silence (!default) if sound not found */
			SND_MEMORY = 0x0004, /* pszSound points to a memory file */
			SND_LOOP = 0x0008, /* loop the sound until next sndPlaySound */
			SND_NOSTOP = 0x0010, /* don't stop any currently playing sound */
			SND_NOWAIT = 0x00002000, /* don't wait if the driver is busy */
			SND_ALIAS = 0x00010000,/* name is a registry alias */
			SND_ALIAS_ID = 0x00110000, /* alias is a pre d ID */
			SND_FILENAME = 0x00020000, /* name is file name */
			SND_RESOURCE = 0x00040004, /* name is resource name or atom */
			SND_PURGE = 0x0040,  /* purge non-static events for task */
			SND_APPLICATION = 0x0080  /* look for application specific association */
		}

		private readonly Hashtable ht = new Hashtable();
		private readonly SvnFolderProcess folderProcess;


		public UpdateLogForm(SvnFolderProcess sfp)
		{
			if (!sfp.isUpdateCommand) throw new ApplicationException();
			folderProcess = sfp;

			InitializeComponent();

			FillList();
			PlaySound();
		}


		private void FillList()
		{
			Text = folderProcess.folder.Path + " - Update... Finished!";
			bool conflict = false;

			foreach (string line in folderProcess.processOutput)
			{
				string action;
				string path;
				Color color = Color.Black;

				switch (line.Substring(0, Math.Min(line.Length, 2)))
				{
					case "A ":
						action = "Added";
						path = line.Substring(5);
						color = Color.Purple;
						AddAction(action);
						break;

					case "D ":
						action = "Deleted";
						path = line.Substring(5);
						color = Color.Brown;
						AddAction(action);
						break;

					case "U ":
						action = "Updated";
						path = line.Substring(5);
						AddAction(action);
						break;

					case "C ":
						action = "Conflicted";
						path = line.Substring(5);
						color = Color.Red;
						conflict = true;
						AddAction(action);
						break;

					case "G ":
						action = "Merged";
						path = line.Substring(5);
						color = Color.DarkGreen;
						AddAction(action);
						break;

					default:
						if (line.StartsWith("Updated to revision"))
						{
							action = "Completed";
							path = "At revision: " + line.Substring(20);
						}
						else
						{
							action = "Error";
							path = line;
							color = Color.Red;
						}
						break;
				}

				ListViewItem lvi = new ListViewItem(new[] { action, path }) { ForeColor = color };
				LogListView.Items.Add(lvi);
			}

			if (conflict)
			{
				ListViewItem lvi = new ListViewItem(new[] { "Warning!", "One or more files are in a conflicted state." });
				lvi.ForeColor = Color.Red;
				LogListView.Items.Add(lvi);
			}

			if (ht.Count > 0)
			{
				ResultsLabel.Text = "";
				foreach (DictionaryEntry de in ht)
				{
					ResultsLabel.Text += de.Key + ":" + de.Value + " ";
				}
				ShowLogButton.Enabled = true;
			}
			else
				ShowLogButton.Visible = false;
		}


		private void AddAction(string action)
		{
			try
			{
				ht[action] = (int)ht[action] + 1;
			}
			catch
			{
				ht[action] = 1;
			}
		}


		private static void PlaySound()
		{
			string wavFile = Path.Combine(Path.GetDirectoryName(Config.TortoiseSVNpath), "TortoiseSVN_error.wav");
			if (File.Exists(wavFile))
			{
				PlaySound(wavFile, 0, (int)(SND.SND_ASYNC | SND.SND_FILENAME | SND.SND_NOWAIT));
			}
		}


		private void ShowLogButton_Click(object sender, EventArgs e)
		{
			SvnTools.OpenChangeLogWindow(folderProcess.folder, false);
		}
	}
}
