using System;
using System.Runtime.InteropServices;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	/// <summary>Verifies an <see cref="T:System.Security.Cryptography.RSA" /> PKCS #1 version 1.5 signature.</summary>
	// Token: 0x020002E8 RID: 744
	[ComVisible(true)]
	public class RSAPKCS1SignatureDeformatter : AsymmetricSignatureDeformatter
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.RSAPKCS1SignatureDeformatter" /> class.</summary>
		// Token: 0x060018AE RID: 6318 RVA: 0x0006C091 File Offset: 0x0006A291
		public RSAPKCS1SignatureDeformatter()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.RSAPKCS1SignatureDeformatter" /> class with the specified key.</summary>
		/// <param name="key">The instance of <see cref="T:System.Security.Cryptography.RSA" /> that holds the public key. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key " />is <see langword="null" />.</exception>
		// Token: 0x060018AF RID: 6319 RVA: 0x0006C099 File Offset: 0x0006A299
		public RSAPKCS1SignatureDeformatter(AsymmetricAlgorithm key)
		{
			this.SetKey(key);
		}

		/// <summary>Sets the hash algorithm to use for verifying the signature.</summary>
		/// <param name="strName">The name of the hash algorithm to use for verifying the signature. </param>
		// Token: 0x060018B0 RID: 6320 RVA: 0x0006C0A8 File Offset: 0x0006A2A8
		public override void SetHashAlgorithm(string strName)
		{
			if (strName == null)
			{
				throw new ArgumentNullException("strName");
			}
			this.hashName = strName;
		}

		/// <summary>Sets the public key to use for verifying the signature.</summary>
		/// <param name="key">The instance of <see cref="T:System.Security.Cryptography.RSA" /> that holds the public key. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key " />is <see langword="null" />.</exception>
		// Token: 0x060018B1 RID: 6321 RVA: 0x0006C0BF File Offset: 0x0006A2BF
		public override void SetKey(AsymmetricAlgorithm key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			this.rsa = (RSA)key;
		}

		/// <summary>Verifies the <see cref="T:System.Security.Cryptography.RSA" /> PKCS#1 signature for the specified data.</summary>
		/// <param name="rgbHash">The data signed with <paramref name="rgbSignature" />. </param>
		/// <param name="rgbSignature">The signature to be verified for <paramref name="rgbHash" />. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="rgbSignature" /> matches the signature computed using the specified hash algorithm and key on <paramref name="rgbHash" />; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicUnexpectedOperationException">The key is <see langword="null" />.-or- The hash algorithm is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="rgbHash" /> parameter is <see langword="null" />.-or- The <paramref name="rgbSignature" /> parameter is <see langword="null" />. </exception>
		// Token: 0x060018B2 RID: 6322 RVA: 0x0006C0DC File Offset: 0x0006A2DC
		public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature)
		{
			if (this.rsa == null)
			{
				throw new CryptographicUnexpectedOperationException(Locale.GetText("No public key available."));
			}
			if (this.hashName == null)
			{
				throw new CryptographicUnexpectedOperationException(Locale.GetText("Missing hash algorithm."));
			}
			if (rgbHash == null)
			{
				throw new ArgumentNullException("rgbHash");
			}
			if (rgbSignature == null)
			{
				throw new ArgumentNullException("rgbSignature");
			}
			return PKCS1.Verify_v15(this.rsa, this.hashName, rgbHash, rgbSignature);
		}

		// Token: 0x04000A32 RID: 2610
		private RSA rsa;

		// Token: 0x04000A33 RID: 2611
		private string hashName;
	}
}
