using System;

namespace System.Reflection
{
	/// <summary>Identifies the processor and bits-per-word of the platform targeted by an executable.</summary>
	// Token: 0x020004B3 RID: 1203
	public enum ProcessorArchitecture
	{
		/// <summary>An unknown or unspecified combination of processor and bits-per-word.</summary>
		// Token: 0x0400104D RID: 4173
		None,
		/// <summary>Neutral with respect to processor and bits-per-word.</summary>
		// Token: 0x0400104E RID: 4174
		MSIL,
		/// <summary>A 32-bit Intel processor, either native or in the Windows on Windows environment on a 64-bit platform (WOW64).</summary>
		// Token: 0x0400104F RID: 4175
		X86,
		/// <summary>A 64-bit Intel processor only.</summary>
		// Token: 0x04001050 RID: 4176
		IA64,
		/// <summary>A 64-bit AMD processor only.</summary>
		// Token: 0x04001051 RID: 4177
		Amd64,
		/// <summary>An ARM processor.</summary>
		// Token: 0x04001052 RID: 4178
		Arm
	}
}
