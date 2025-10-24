using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Represents the abstract class from which all implementations of the MD160 hash algorithm inherit.</summary>
	// Token: 0x020002CA RID: 714
	[ComVisible(true)]
	public abstract class RIPEMD160 : HashAlgorithm
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.RIPEMD160" /> class.</summary>
		// Token: 0x060017C7 RID: 6087 RVA: 0x00062DAE File Offset: 0x00060FAE
		protected RIPEMD160()
		{
			this.HashSizeValue = 160;
		}
	}
}
