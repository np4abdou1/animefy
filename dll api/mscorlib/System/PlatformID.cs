using System;
using System.Runtime.InteropServices;

namespace System
{
	/// <summary>Identifies the operating system, or platform, supported by an assembly.</summary>
	// Token: 0x0200017A RID: 378
	[ComVisible(true)]
	[Serializable]
	public enum PlatformID
	{
		/// <summary>The operating system is Win32s. Win32s is a layer that runs on 16-bit versions of Windows to provide access to 32-bit applications.</summary>
		// Token: 0x040005A8 RID: 1448
		Win32S,
		/// <summary>The operating system is Windows 95 or Windows 98.</summary>
		// Token: 0x040005A9 RID: 1449
		Win32Windows,
		/// <summary>The operating system is Windows NT or later.</summary>
		// Token: 0x040005AA RID: 1450
		Win32NT,
		/// <summary>The operating system is Windows CE.</summary>
		// Token: 0x040005AB RID: 1451
		WinCE,
		/// <summary>The operating system is Unix.</summary>
		// Token: 0x040005AC RID: 1452
		Unix,
		/// <summary>The development platform is Xbox 360.</summary>
		// Token: 0x040005AD RID: 1453
		Xbox,
		/// <summary>The operating system is Macintosh.</summary>
		// Token: 0x040005AE RID: 1454
		MacOSX
	}
}
