﻿using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Computes a Hash-based Message Authentication Code (HMAC) by using the <see cref="T:System.Security.Cryptography.RIPEMD160" /> hash function.</summary>
	// Token: 0x020002B6 RID: 694
	[ComVisible(true)]
	public class HMACRIPEMD160 : HMAC
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.HMACRIPEMD160" /> class with a randomly generated 64-byte key.</summary>
		// Token: 0x0600175B RID: 5979 RVA: 0x00060556 File Offset: 0x0005E756
		public HMACRIPEMD160() : this(Utils.GenerateRandom(64))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.HMACRIPEMD160" /> class with the specified key data.</summary>
		/// <param name="key">The secret key for <see cref="T:System.Security.Cryptography.HMACRIPEMD160" /> encryption. The key can be any length, but if it is more than 64 bytes long it is hashed (using SHA-1) to derive a 64-byte key. Therefore, the recommended size of the secret key is 64 bytes.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="key" /> parameter is <see langword="null" />. </exception>
		// Token: 0x0600175C RID: 5980 RVA: 0x00060565 File Offset: 0x0005E765
		public HMACRIPEMD160(byte[] key)
		{
			this.m_hashName = "RIPEMD160";
			this.m_hash1 = new RIPEMD160Managed();
			this.m_hash2 = new RIPEMD160Managed();
			this.HashSizeValue = 160;
			base.InitializeKey(key);
		}
	}
}
