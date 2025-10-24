using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Computes the <see cref="T:System.Security.Cryptography.SHA1" /> hash for the input data.</summary>
	// Token: 0x020002CF RID: 719
	[ComVisible(true)]
	public abstract class SHA1 : HashAlgorithm
	{
		/// <summary>Initializes a new instance of <see cref="T:System.Security.Cryptography.SHA1" />.</summary>
		/// <exception cref="T:System.InvalidOperationException">The policy on this object is not compliant with the FIPS algorithm.</exception>
		// Token: 0x060017EE RID: 6126 RVA: 0x00062DAE File Offset: 0x00060FAE
		protected SHA1()
		{
			this.HashSizeValue = 160;
		}

		/// <summary>Creates an instance of the default implementation of <see cref="T:System.Security.Cryptography.SHA1" />.</summary>
		/// <returns>A new instance of <see cref="T:System.Security.Cryptography.SHA1" />.</returns>
		// Token: 0x060017EF RID: 6127 RVA: 0x0006592A File Offset: 0x00063B2A
		public static SHA1 Create()
		{
			return SHA1.Create("System.Security.Cryptography.SHA1");
		}

		/// <summary>Creates an instance of the specified implementation of <see cref="T:System.Security.Cryptography.SHA1" />.</summary>
		/// <param name="hashName">The name of the specific implementation of <see cref="T:System.Security.Cryptography.SHA1" /> to be used. </param>
		/// <returns>A new instance of <see cref="T:System.Security.Cryptography.SHA1" /> using the specified implementation.</returns>
		// Token: 0x060017F0 RID: 6128 RVA: 0x00065936 File Offset: 0x00063B36
		public new static SHA1 Create(string hashName)
		{
			return (SHA1)CryptoConfig.CreateFromName(hashName);
		}
	}
}
