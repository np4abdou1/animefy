using System;
using System.ComponentModel;

namespace System.Diagnostics
{
	/// <summary>Identifies the type of event that has caused the trace.</summary>
	// Token: 0x020000C2 RID: 194
	public enum TraceEventType
	{
		/// <summary>Fatal error or application crash.</summary>
		// Token: 0x040003AC RID: 940
		Critical = 1,
		/// <summary>Recoverable error.</summary>
		// Token: 0x040003AD RID: 941
		Error,
		/// <summary>Noncritical problem.</summary>
		// Token: 0x040003AE RID: 942
		Warning = 4,
		/// <summary>Informational message.</summary>
		// Token: 0x040003AF RID: 943
		Information = 8,
		/// <summary>Debugging trace.</summary>
		// Token: 0x040003B0 RID: 944
		Verbose = 16,
		/// <summary>Starting of a logical operation.</summary>
		// Token: 0x040003B1 RID: 945
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Start = 256,
		/// <summary>Stopping of a logical operation.</summary>
		// Token: 0x040003B2 RID: 946
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Stop = 512,
		/// <summary>Suspension of a logical operation.</summary>
		// Token: 0x040003B3 RID: 947
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Suspend = 1024,
		/// <summary>Resumption of a logical operation.</summary>
		// Token: 0x040003B4 RID: 948
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Resume = 2048,
		/// <summary>Changing of correlation identity.</summary>
		// Token: 0x040003B5 RID: 949
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Transfer = 4096
	}
}
