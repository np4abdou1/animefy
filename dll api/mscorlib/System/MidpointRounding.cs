using System;

namespace System
{
	/// <summary>Specifies how mathematical rounding methods should process a number that is midway between two numbers.</summary>
	// Token: 0x020000D6 RID: 214
	public enum MidpointRounding
	{
		/// <summary>When a number is halfway between two others, it is rounded toward the nearest even number.</summary>
		// Token: 0x04000331 RID: 817
		ToEven,
		/// <summary>When a number is halfway between two others, it is rounded toward the nearest number that is away from zero.</summary>
		// Token: 0x04000332 RID: 818
		AwayFromZero
	}
}
