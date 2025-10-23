using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Computes a Hash-based Message Authentication Code (HMAC) using the <see cref="T:System.Security.Cryptography.SHA384" /> hash function.</summary>
	// Token: 0x020002BA RID: 698
	[ComVisible(true)]
	public class HMACSHA384 : HMAC
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.HMACSHA384" /> class by using a randomly generated key.</summary>
		// Token: 0x06001768 RID: 5992 RVA: 0x0006070D File Offset: 0x0005E90D
		public HMACSHA384() : this(Utils.GenerateRandom(128))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.HMACSHA384" /> class by using the specified key data.</summary>
		/// <param name="key">The secret key for <see cref="T:System.Security.Cryptography.HMACSHA384" /> encryption. The key can be any length. However, the recommended size is 128 bytes. If the key is more than 128 bytes long, it is hashed (using SHA-384) to derive a 128-byte key. If it is less than 128 bytes long, it is padded to 128 bytes. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="key" /> parameter is <see langword="null" />. </exception>
		// Token: 0x06001769 RID: 5993 RVA: 0x00060720 File Offset: 0x0005E920
		[SecuritySafeCritical]
		public HMACSHA384(byte[] key)
		{
			this.m_hashName = "SHA384";
			this.m_hash1 = HMAC.GetHashAlgorithmWithFipsFallback(() => new SHA384Managed(), () => HashAlgorithm.Create("System.Security.Cryptography.SHA384CryptoServiceProvider"));
			this.m_hash2 = HMAC.GetHashAlgorithmWithFipsFallback(() => new SHA384Managed(), () => HashAlgorithm.Create("System.Security.Cryptography.SHA384CryptoServiceProvider"));
			this.HashSizeValue = 384;
			base.BlockSizeValue = this.BlockSize;
			base.InitializeKey(key);
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x0600176A RID: 5994 RVA: 0x000607F9 File Offset: 0x0005E9F9
		private int BlockSize
		{
			get
			{
				if (!this.m_useLegacyBlockSize)
				{
					return 128;
				}
				return 64;
			}
		}

		// Token: 0x0400099E RID: 2462
		private bool m_useLegacyBlockSize = Utils._ProduceLegacyHmacValues();
	}
}
