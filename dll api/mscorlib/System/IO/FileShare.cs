using System;

namespace System.IO
{
	/// <summary>Contains constants for controlling the kind of access other <see cref="T:System.IO.FileStream" /> objects can have to the same file.</summary>
	// Token: 0x02000529 RID: 1321
	[Flags]
	public enum FileShare
	{
		/// <summary>Declines sharing of the current file. Any request to open the file (by this process or another process) will fail until the file is closed.</summary>
		// Token: 0x04001442 RID: 5186
		None = 0,
		/// <summary>Allows subsequent opening of the file for reading. If this flag is not specified, any request to open the file for reading (by this process or another process) will fail until the file is closed. However, even if this flag is specified, additional permissions might still be needed to access the file.</summary>
		// Token: 0x04001443 RID: 5187
		Read = 1,
		/// <summary>Allows subsequent opening of the file for writing. If this flag is not specified, any request to open the file for writing (by this process or another process) will fail until the file is closed. However, even if this flag is specified, additional permissions might still be needed to access the file.</summary>
		// Token: 0x04001444 RID: 5188
		Write = 2,
		/// <summary>Allows subsequent opening of the file for reading or writing. If this flag is not specified, any request to open the file for reading or writing (by this process or another process) will fail until the file is closed. However, even if this flag is specified, additional permissions might still be needed to access the file.</summary>
		// Token: 0x04001445 RID: 5189
		ReadWrite = 3,
		/// <summary>Allows subsequent deleting of a file.</summary>
		// Token: 0x04001446 RID: 5190
		Delete = 4,
		/// <summary>Makes the file handle inheritable by child processes. This is not directly supported by Win32.</summary>
		// Token: 0x04001447 RID: 5191
		Inheritable = 16
	}
}
