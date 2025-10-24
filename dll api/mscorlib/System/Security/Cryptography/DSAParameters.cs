using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Contains the typical parameters for the <see cref="T:System.Security.Cryptography.DSA" /> algorithm.</summary>
	// Token: 0x020002B0 RID: 688
	[ComVisible(true)]
	[Serializable]
	public struct DSAParameters
	{
		/// <summary>Specifies the <see langword="P" /> parameter for the <see cref="T:System.Security.Cryptography.DSA" /> algorithm.</summary>
		// Token: 0x04000987 RID: 2439
		public byte[] P;

		/// <summary>Specifies the <see langword="Q" /> parameter for the <see cref="T:System.Security.Cryptography.DSA" /> algorithm.</summary>
		// Token: 0x04000988 RID: 2440
		public byte[] Q;

		/// <summary>Specifies the <see langword="G" /> parameter for the <see cref="T:System.Security.Cryptography.DSA" /> algorithm.</summary>
		// Token: 0x04000989 RID: 2441
		public byte[] G;

		/// <summary>Specifies the <see langword="Y" /> parameter for the <see cref="T:System.Security.Cryptography.DSA" /> algorithm.</summary>
		// Token: 0x0400098A RID: 2442
		public byte[] Y;

		/// <summary>Specifies the <see langword="J" /> parameter for the <see cref="T:System.Security.Cryptography.DSA" /> algorithm.</summary>
		// Token: 0x0400098B RID: 2443
		public byte[] J;

		/// <summary>Specifies the <see langword="X" /> parameter for the <see cref="T:System.Security.Cryptography.DSA" /> algorithm.</summary>
		// Token: 0x0400098C RID: 2444
		[NonSerialized]
		public byte[] X;

		/// <summary>Specifies the seed for the <see cref="T:System.Security.Cryptography.DSA" /> algorithm.</summary>
		// Token: 0x0400098D RID: 2445
		public byte[] Seed;

		/// <summary>Specifies the counter for the <see cref="T:System.Security.Cryptography.DSA" /> algorithm.</summary>
		// Token: 0x0400098E RID: 2446
		public int Counter;
	}
}
