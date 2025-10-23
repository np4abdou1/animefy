using System;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	/// <summary>Specifies the type of the portable executable (PE) file.</summary>
	// Token: 0x02000513 RID: 1299
	[ComVisible(true)]
	[Serializable]
	public enum PEFileKinds
	{
		/// <summary>The portable executable (PE) file is a DLL.</summary>
		// Token: 0x0400138F RID: 5007
		Dll = 1,
		/// <summary>The application is a console (not a Windows-based) application.</summary>
		// Token: 0x04001390 RID: 5008
		ConsoleApplication,
		/// <summary>The application is a Windows-based application.</summary>
		// Token: 0x04001391 RID: 5009
		WindowApplication
	}
}
