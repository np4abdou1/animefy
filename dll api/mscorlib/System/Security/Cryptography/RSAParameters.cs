using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Represents the standard parameters for the <see cref="T:System.Security.Cryptography.RSA" /> algorithm.</summary>
	// Token: 0x020002CC RID: 716
	[ComVisible(true)]
	[Serializable]
	public struct RSAParameters
	{
		/// <summary>Represents the <see langword="Exponent" /> parameter for the <see cref="T:System.Security.Cryptography.RSA" /> algorithm.</summary>
		// Token: 0x040009DA RID: 2522
		public byte[] Exponent;

		/// <summary>Represents the <see langword="Modulus" /> parameter for the <see cref="T:System.Security.Cryptography.RSA" /> algorithm.</summary>
		// Token: 0x040009DB RID: 2523
		public byte[] Modulus;

		/// <summary>Represents the <see langword="P" /> parameter for the <see cref="T:System.Security.Cryptography.RSA" /> algorithm.</summary>
		// Token: 0x040009DC RID: 2524
		[NonSerialized]
		public byte[] P;

		/// <summary>Represents the <see langword="Q" /> parameter for the <see cref="T:System.Security.Cryptography.RSA" /> algorithm.</summary>
		// Token: 0x040009DD RID: 2525
		[NonSerialized]
		public byte[] Q;

		/// <summary>Represents the <see langword="DP" /> parameter for the <see cref="T:System.Security.Cryptography.RSA" /> algorithm.</summary>
		// Token: 0x040009DE RID: 2526
		[NonSerialized]
		public byte[] DP;

		/// <summary>Represents the <see langword="DQ" /> parameter for the <see cref="T:System.Security.Cryptography.RSA" /> algorithm.</summary>
		// Token: 0x040009DF RID: 2527
		[NonSerialized]
		public byte[] DQ;

		/// <summary>Represents the <see langword="InverseQ" /> parameter for the <see cref="T:System.Security.Cryptography.RSA" /> algorithm.</summary>
		// Token: 0x040009E0 RID: 2528
		[NonSerialized]
		public byte[] InverseQ;

		/// <summary>Represents the <see langword="D" /> parameter for the <see cref="T:System.Security.Cryptography.RSA" /> algorithm.</summary>
		// Token: 0x040009E1 RID: 2529
		[NonSerialized]
		public byte[] D;
	}
}
