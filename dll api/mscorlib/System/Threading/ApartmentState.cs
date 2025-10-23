using System;

namespace System.Threading
{
	/// <summary>Specifies the apartment state of a <see cref="T:System.Threading.Thread" />.</summary>
	// Token: 0x020001A1 RID: 417
	public enum ApartmentState
	{
		/// <summary>The <see cref="T:System.Threading.Thread" /> will create and enter a single-threaded apartment.</summary>
		// Token: 0x0400062B RID: 1579
		STA,
		/// <summary>The <see cref="T:System.Threading.Thread" /> will create and enter a multithreaded apartment.</summary>
		// Token: 0x0400062C RID: 1580
		MTA,
		/// <summary>The <see cref="P:System.Threading.Thread.ApartmentState" /> property has not been set.</summary>
		// Token: 0x0400062D RID: 1581
		Unknown
	}
}
