using System;

namespace System.IO
{
	/// <summary>Defines constants for read, write, or read/write access to a file.</summary>
	// Token: 0x02000524 RID: 1316
	[Flags]
	public enum FileAccess
	{
		/// <summary>Read access to the file. Data can be read from the file. Combine with <see langword="Write" /> for read/write access.</summary>
		// Token: 0x0400142B RID: 5163
		Read = 1,
		/// <summary>Write access to the file. Data can be written to the file. Combine with <see langword="Read" /> for read/write access.</summary>
		// Token: 0x0400142C RID: 5164
		Write = 2,
		/// <summary>Read and write access to the file. Data can be written to and read from the file.</summary>
		// Token: 0x0400142D RID: 5165
		ReadWrite = 3
	}
}
