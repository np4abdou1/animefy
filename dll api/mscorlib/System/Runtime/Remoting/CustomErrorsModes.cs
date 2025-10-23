using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting
{
	/// <summary>Specifies how custom errors are handled.</summary>
	// Token: 0x02000301 RID: 769
	[ComVisible(true)]
	public enum CustomErrorsModes
	{
		/// <summary>All callers receive filtered exception information.</summary>
		// Token: 0x04000A90 RID: 2704
		On,
		/// <summary>All callers receive complete exception information.</summary>
		// Token: 0x04000A91 RID: 2705
		Off,
		/// <summary>Local callers receive complete exception information; remote callers receive filtered exception information.</summary>
		// Token: 0x04000A92 RID: 2706
		RemoteOnly
	}
}
