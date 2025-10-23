using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Computes the <see cref="T:System.Security.Cryptography.SHA512" /> hash for the input data.  </summary>
	// Token: 0x020002D5 RID: 725
	[ComVisible(true)]
	public abstract class SHA512 : HashAlgorithm
	{
		/// <summary>Initializes a new instance of <see cref="T:System.Security.Cryptography.SHA512" />.</summary>
		// Token: 0x06001822 RID: 6178 RVA: 0x00066FE6 File Offset: 0x000651E6
		protected SHA512()
		{
			this.HashSizeValue = 512;
		}

		/// <summary>Creates an instance of the default implementation of <see cref="T:System.Security.Cryptography.SHA512" />.</summary>
		/// <returns>A new instance of <see cref="T:System.Security.Cryptography.SHA512" />.</returns>
		/// <exception cref="T:System.Reflection.TargetInvocationException">The algorithm was used with Federal Information Processing Standards (FIPS) mode enabled, but is not FIPS compatible.</exception>
		// Token: 0x06001823 RID: 6179 RVA: 0x00066FF9 File Offset: 0x000651F9
		public static SHA512 Create()
		{
			return SHA512.Create("System.Security.Cryptography.SHA512");
		}

		/// <summary>Creates an instance of a specified implementation of <see cref="T:System.Security.Cryptography.SHA512" />.</summary>
		/// <param name="hashName">The name of the specific implementation of <see cref="T:System.Security.Cryptography.SHA512" /> to be used. </param>
		/// <returns>A new instance of <see cref="T:System.Security.Cryptography.SHA512" /> using the specified implementation.</returns>
		/// <exception cref="T:System.Reflection.TargetInvocationException">The algorithm described by the <paramref name="hashName" /> parameter was used with Federal Information Processing Standards (FIPS) mode enabled, but is not FIPS compatible.</exception>
		// Token: 0x06001824 RID: 6180 RVA: 0x00067005 File Offset: 0x00065205
		public new static SHA512 Create(string hashName)
		{
			return (SHA512)CryptoConfig.CreateFromName(hashName);
		}
	}
}
