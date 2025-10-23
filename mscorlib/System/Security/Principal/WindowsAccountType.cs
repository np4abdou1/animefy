using System;
using System.Runtime.InteropServices;

namespace System.Security.Principal
{
	/// <summary>Specifies the type of Windows account used.</summary>
	// Token: 0x020002F6 RID: 758
	[ComVisible(true)]
	[Serializable]
	public enum WindowsAccountType
	{
		/// <summary>A standard user account.</summary>
		// Token: 0x04000A62 RID: 2658
		Normal,
		/// <summary>A Windows guest account.</summary>
		// Token: 0x04000A63 RID: 2659
		Guest,
		/// <summary>A Windows system account.</summary>
		// Token: 0x04000A64 RID: 2660
		System,
		/// <summary>An anonymous account.</summary>
		// Token: 0x04000A65 RID: 2661
		Anonymous
	}
}
