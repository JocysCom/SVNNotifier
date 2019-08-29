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
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace CHD.SVN_Notifier
{
	public class SvnItem : ICloneable, INotifyPropertyChanged
	{
		public SvnItem()
		{
			Enabled = true;
		}

		public string origPath;
		public int ActiveStatusUpdateInterval;
		public int IdleStatusUpdateInterval;
		public PathType pathType;
		public string RepositoryUrl;

		public SvnStatus Status
		{
			get { return _Status; }
			set
			{
				_Status = value;
				_StatusTime = DateTime.Now;
				NotifyPropertyChanged("Status");
				NotifyPropertyChanged("StatusTime");
			}
		}
		SvnStatus _Status;

		public string VisiblePath
		{
			get { return _VisiblePath; }
			set { _VisiblePath = value; NotifyPropertyChanged("VisiblePath"); }
		}
		string _VisiblePath;

		public DateTime StatusTime { get { return _StatusTime; } }
		DateTime _StatusTime;

		public bool Enabled
		{
			get { return _Enabled; }
			set { _Enabled = value; NotifyPropertyChanged("Enabled"); }
		}
		bool _Enabled;


		public string Path
		{
			get { return _Path; }
			set { _Path = value; NotifyPropertyChanged("Status"); }
		}
		string _Path;


		public SvnItem(string path, PathType type)
		{
			Path = DeserializePath(path);
			origPath = path;
			pathType = type;
			Status = SvnStatus.Unknown;
			_StatusTime = DateTime.MinValue;
			ActiveStatusUpdateInterval = -1;
			IdleStatusUpdateInterval = -1;
			Enabled = true;
		}


		public string Serialize()
		{
			return origPath + "|" + ActiveStatusUpdateInterval + "|" + IdleStatusUpdateInterval + "|" + !Enabled + "|" + (int)pathType;
		}


		public static SvnItem Deserialize(string s)
		{
			string[] p = s.Split('|');
			SvnItem f = new SvnItem(p[0], (PathType)int.Parse(p[4]))
			{
				ActiveStatusUpdateInterval = int.Parse(p[1]),
				IdleStatusUpdateInterval = int.Parse(p[2]),
				Enabled = !Boolean.Parse(p[3])
			};
			return f;
		}


		private static string DeserializePath(string s)
		{
			Regex r = new Regex("%(.*)%", RegexOptions.None);
			Match m = r.Match(s);
			string v = m.Groups[1].ToString().Trim();
			if (v != "")
			{
				try
				{
					string path = Environment.GetEnvironmentVariable(v);
					if (path != null)
						s = s.Replace("%" + v + "%", path);
				}
				catch
				{
					// TODO: ...
					// ...variable is a null reference
					// ...The caller does not have EnvironmentPermission with Read access.
				}
			}
			return s;
		}


		public object Clone()
		{
			return MemberwiseClone();
		}


		public int GetInterval(bool formIsActive)
		{
			return ActiveStatusUpdateInterval < 0
					   ? (formIsActive ? Config.DefaultActiveStatusUpdateInterval : Config.DefaultIdleStatusUpdateInterval)
					   : (formIsActive ? ActiveStatusUpdateInterval : IdleStatusUpdateInterval);
		}

		public static int FindNextStatusUpdateTimeMs(BindingList<SvnItem> list, bool formIsActive)
		{
			if (list.Count == 0) return 3000;                           // Return just some good value

			DateTime minNextTime = DateTime.MaxValue;
			DateTime now = DateTime.Now;

			foreach (SvnItem folder in list)
			{
				TimeSpan ts = new TimeSpan(0, 0, folder.GetInterval(formIsActive));
				DateTime nextTime = folder.StatusTime + ts;

				if (nextTime <= now)
					return 0;

				if (nextTime < minNextTime)
					minNextTime = nextTime;
			}

			return (int)(minNextTime - now).TotalMilliseconds;
		}

		internal int updateRevision;
		internal int reviewedRevision;

		#region INotifyPropertyChanged

		public event PropertyChangedEventHandler PropertyChanged;

		private void NotifyPropertyChanged(string propertyName = "")
		{
			var ev = PropertyChanged;
			if (ev == null) return;
			ev(this, new PropertyChangedEventArgs(propertyName));
		}

		#endregion


	}

}
