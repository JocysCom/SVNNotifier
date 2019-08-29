using System;
using System.ComponentModel;

namespace CHD.SVN_Notifier
{
	public enum SvnStatus
	{
		[Description("Unknown")]
		Unknown,
		[Description("Error")]
		Error,
		[Description("Changed")]
		NeedUpdate,
		[Description("Changed, Modified")]
		NeedUpdate_Modified,
		[Description("Synchronized")]
		UpToDate,
		[Description("Modified")]
		UpToDate_Modified,
	}
}
