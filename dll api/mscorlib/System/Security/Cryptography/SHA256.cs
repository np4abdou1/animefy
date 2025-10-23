using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Computes the <see cref="T:System.Security.Cryptography.SHA256" /> hash for the input data. </summary>
	// Token: 0x020002D1 RID: 721
	[ComVisible(true)]
	public abstract class SHA256 : HashAlgorithm
	{
		/// <summary>Initializes a new instance of <see cref="T:System.Security.Cryptography.SHA256" />.</summary>
		// Token: 0x060017FA RID: 6138 RVA: 0x000660EC File Offset: 0x000642EC
		protected SHA256()
		{
			this.HashSizeValue = 256;
		}

		/// <summary>Creates an instance of the default implementation of <see cref="T:System.Security.Cryptography.SHA256" />.</summary>
		/// <returns>A new instance of <see cref="T:System.Security.Cryptography.SHA256" />.</returns>
		/// <exception cref="T:System.Reflection.TargetInvocationException">The algorithm was used with Federal Information Processing Standards (FIPS) mode enabled, but is not FIPS compatible.</exception>
		// Token: 0x060017FB RID: 6139 RVA: 0x000660FF File Offset: 0x000642FF
		public static SHA256 Create()
		{
			return SHA256.Create("System.Security.Cryptography.SHA256");
		}

		/// <summary>Creates an instance of a specified implementation of <see cref="T:System.Security.Cryptography.SHA256" />.</summary>
		/// <param name="hashName">The name of the specific implementation of <see cref="T:System.Security.Cryptography.SHA256" /> to be used. </param>
		/// <returns>A new instance of <see cref="T:System.Security.Cryptography.SHA256" /> using the specified implementation.</returns>
		/// <exception cref="T:System.Reflection.TargetInvocationException">The algorithm described by the <paramref name="hashName" /> parameter was used with Federal Information Processing Standards (FIPS) mode enabled, but is not FIPS compatible.</exception>
		// Token: 0x060017FC RID: 6140 RVA: 0x0006610B File Offset: 0x0006430B
		public new static SHA256 Create(string hashName)
		{
			return (SHA256)CryptoConfig.CreateFromName(hashName);
		}
	}
}
