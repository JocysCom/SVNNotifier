using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Linq;

namespace CHD.SVN_Notifier
{
	partial class MainForm
	{
		private readonly Icon trayIcon_NeedUpdate = Properties.Resources.TrayIcon_NeedUpdate;
		private readonly Icon trayIcon_UpToDate = Properties.Resources.TrayIcon_UpToDate;
		private readonly Icon trayIcon_Unknown = Properties.Resources.TrayIcon_Unknown;
		private readonly Icon trayIcon_Error = Properties.Resources.TrayIcon_Error;

		BindingList<SvnItem> folders = new BindingList<SvnItem>();


		private int GetFoldersCommonPartLength()
		{
			if (folders.Count < 2) return 0;

			string path0 = folders[0].Path;

			int len = 0;
			for (int i = 0; i < path0.Length; i++)
				for (int f = 1; f < folders.Count; f++)
				{
					string path = folders[f].Path;
					if (i == path.Length - 1) return len;
					if (path0[i] != path[i]) return len;
					if (path0[i] == '\\') len = i + 1;
				}
			return len;
		}


		private void UpdateListViewFolderNames()
		{
			int i = GetFoldersCommonPartLength();
			for (int f = 0; f < folders.Count; f++)
			{
				folders[f].VisiblePath = (i > 0 ? "\u2026" : "") + folders[f].Path.Substring(i);
			}
		}

		//////////////////////////////////////////////////////////////////////////////

		private void UpdateFolder()
		{
			if (ItemListView.SelectedRows.Count == 0)
				return;

			int selectedIndex = ItemListView.Rows.IndexOf(ItemListView.SelectedRows[0]);
			SvnItem folder = folders[selectedIndex];

			if (Config.ChangeLogBeforeUpdate && (folder.reviewedRevision < SvnTools.GetRepositoryHeadRevision(folder)))
			{
				MessageBox.Show("You need to see ChangeLog first!", "SVN Notifier", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return;
			}

			UpdateButton.Enabled = UpdateMenuItem.Enabled = CheckNowMenuItem.Enabled = false;
			folder.Status = SvnStatus.Unknown;
			newNonUpdatedFolders.Clear();
			StatusLabel.Text = "Updating '" + folder.Path + "'...";
			UpdateTray(true);
			Refresh();              // Show "Unknown" folder status during updating

			updateNotInProgress.Reset();
			BeginUpdateFolderStatuses();

			SvnTools.Update(folder, false);

			forcedFolders.Enqueue(folder);

			updateNotInProgress.Set();
		}


		private void CommitFolder()
		{
			if (ItemListView.SelectedRows.Count == 0)
				return;

			int selectedIndex = ItemListView.Rows.IndexOf(ItemListView.SelectedRows[0]);
			SvnTools.Commit(folders[selectedIndex]);
		}


		private void UpdateAll()
		{
			newNonUpdatedFolders.Clear();
			StatusLabel.Text = "Updating all...";
			UpdateTray(true);

			BeginUpdateFolderStatuses();

			UpdateButton.Enabled = UpdateMenuItem.Enabled = CheckNowMenuItem.Enabled = TrayUpdateAllMenuItem.Enabled = false;

			foreach (SvnItem folder in folders)
				if ((folder.Status == SvnStatus.NeedUpdate) || (folder.Status == SvnStatus.NeedUpdate_Modified))
				{
					folder.Status = SvnStatus.Unknown;
					if (Config.UpdateAllSilently)
						SvnTools.BeginUpdateSilently(folder);
					else
					{
						updateNotInProgress.Reset();
						SvnTools.Update(folder, true);
						forcedFolders.Enqueue(folder);
						updateNotInProgress.Set();
					}
				}
			UpdateTray(true);
		}


		private void OpenFolder()
		{
			var selectedIndex = ItemListView.Rows.IndexOf(ItemListView.SelectedRows[0]);
			var folder = folders[selectedIndex].Path;
			if (File.Exists(folders[selectedIndex].Path))
				folder = Path.GetDirectoryName(folder);
			// Open folder or folder of the file
			Process.Start(folder + @"\");                   
		}


		private void ShowChangeLog()
		{
			int selectedIndex = ItemListView.Rows.IndexOf(ItemListView.SelectedRows[0]);
			SvnTools.OpenChangeLogWindow(folders[selectedIndex], true);
		}


		private void ShowFullLog()
		{
			int selectedIndex = ItemListView.Rows.IndexOf(ItemListView.SelectedRows[0]);
			SvnTools.OpenLogWindow(folders[selectedIndex].Path);
		}

		SvnItem GetSelectedItem()
		{
			var viewRow = ItemListView.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
			var item = (SvnItem)viewRow.DataBoundItem;
			return item;
		}

		private void SelectFolder(string path)
		{
			for (int i = 0; i < ItemListView.Rows.Count; i++)
			{
				var viewRow = ItemListView.Rows[i];
				var item = (ListViewItem)viewRow.DataBoundItem;
				if (item.Text == path)
				{
					item.Selected = true;
					break;
				}
			}
		}
	}
}