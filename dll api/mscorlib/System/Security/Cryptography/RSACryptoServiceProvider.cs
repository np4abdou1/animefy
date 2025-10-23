using System;
using System.Runtime.InteropServices;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	/// <summary>Performs asymmetric encryption and decryption using the implementation of the <see cref="T:System.Security.Cryptography.RSA" /> algorithm provided by the cryptographic service provider (CSP). This class cannot be inherited.</summary>
	// Token: 0x020002CE RID: 718
	[ComVisible(true)]
	public sealed class RSACryptoServiceProvider : RSA
	{
		/// <summary>Gets or sets a value indicating whether the key should be persisted in the computer's key store instead of the user profile store.</summary>
		/// <returns>
		///     <see langword="true" /> if the key should be persisted in the computer key store; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000280 RID: 640
		// (get) Token: 0x060017DD RID: 6109 RVA: 0x00065563 File Offset: 0x00063763
		public static bool UseMachineKeyStore
		{
			get
			{
				return RSACryptoServiceProvider.s_UseMachineKeyStore == CspProviderFlags.UseMachineKeyStore;
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.RSACryptoServiceProvider" /> class using the default key.</summary>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The cryptographic service provider (CSP) cannot be acquired. </exception>
		// Token: 0x060017DE RID: 6110 RVA: 0x0006556F File Offset: 0x0006376F
		public RSACryptoServiceProvider() : this(1024)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.RSACryptoServiceProvider" /> class with the specified parameters.</summary>
		/// <param name="parameters">The parameters to be passed to the cryptographic service provider (CSP). </param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The CSP cannot be acquired. </exception>
		// Token: 0x060017DF RID: 6111 RVA: 0x0006557C File Offset: 0x0006377C
		public RSACryptoServiceProvider(CspParameters parameters) : this(1024, parameters)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.RSACryptoServiceProvider" /> class with the specified key size.</summary>
		/// <param name="dwKeySize">The size of the key to use in bits. </param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The cryptographic service provider (CSP) cannot be acquired. </exception>
		// Token: 0x060017E0 RID: 6112 RVA: 0x0006558A File Offset: 0x0006378A
		public RSACryptoServiceProvider(int dwKeySize)
		{
			this.privateKeyExportable = true;
			base..ctor();
			this.Common(dwKeySize, false);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.RSACryptoServiceProvider" /> class with the specified key size and parameters.</summary>
		/// <param name="dwKeySize">The size of the key to use in bits. </param>
		/// <param name="parameters">The parameters to be passed to the cryptographic service provider (CSP). </param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The CSP cannot be acquired.-or- The key cannot be created. </exception>
		// Token: 0x060017E1 RID: 6113 RVA: 0x000655A4 File Offset: 0x000637A4
		public RSACryptoServiceProvider(int dwKeySize, CspParameters parameters)
		{
			this.privateKeyExportable = true;
			base..ctor();
			bool flag = parameters != null;
			this.Common(dwKeySize, flag);
			if (flag)
			{
				this.Common(parameters);
			}
		}

		// Token: 0x060017E2 RID: 6114 RVA: 0x000655D8 File Offset: 0x000637D8
		private void Common(int dwKeySize, bool parameters)
		{
			this.LegalKeySizesValue = new KeySizes[1];
			this.LegalKeySizesValue[0] = new KeySizes(384, 16384, 8);
			base.KeySize = dwKeySize;
			this.rsa = new RSAManaged(this.KeySize);
			this.rsa.KeyGenerated += this.OnKeyGenerated;
			this.persistKey = parameters;
			if (parameters)
			{
				return;
			}
			CspParameters cspParameters = new CspParameters(1);
			if (RSACryptoServiceProvider.UseMachineKeyStore)
			{
				cspParameters.Flags |= CspProviderFlags.UseMachineKeyStore;
			}
			this.store = new KeyPairPersistence(cspParameters);
		}

		// Token: 0x060017E3 RID: 6115 RVA: 0x0006566C File Offset: 0x0006386C
		private void Common(CspParameters p)
		{
			this.store = new KeyPairPersistence(p);
			bool flag = this.store.Load();
			bool flag2 = (p.Flags & CspProviderFlags.UseExistingKey) > CspProviderFlags.NoFlags;
			this.privateKeyExportable = ((p.Flags & CspProviderFlags.UseNonExportableKey) == CspProviderFlags.NoFlags);
			if (flag2 && !flag)
			{
				throw new CryptographicException("Keyset does not exist");
			}
			if (this.store.KeyValue != null)
			{
				this.persisted = true;
				this.FromXmlString(this.store.KeyValue);
			}
		}

		// Token: 0x060017E4 RID: 6116 RVA: 0x000656E4 File Offset: 0x000638E4
		~RSACryptoServiceProvider()
		{
			this.Dispose(false);
		}

		/// <summary>Gets the size of the current key.</summary>
		/// <returns>The size of the key in bits.</returns>
		// Token: 0x17000281 RID: 641
		// (get) Token: 0x060017E5 RID: 6117 RVA: 0x00065714 File Offset: 0x00063914
		public override int KeySize
		{
			get
			{
				if (this.rsa == null)
				{
					return this.KeySizeValue;
				}
				return this.rsa.KeySize;
			}
		}

		/// <summary>Gets a value that indicates whether the <see cref="T:System.Security.Cryptography.RSACryptoServiceProvider" /> object contains only a public key.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Security.Cryptography.RSACryptoServiceProvider" /> object contains only a public key; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000282 RID: 642
		// (get) Token: 0x060017E6 RID: 6118 RVA: 0x00065730 File Offset: 0x00063930
		[ComVisible(false)]
		public bool PublicOnly
		{
			get
			{
				return this.rsa.PublicOnly;
			}
		}

		/// <summary>This method is not supported in the current version.</summary>
		/// <param name="rgb">The data to be encrypted. </param>
		/// <returns>The encrypted data.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not supported in the current version. </exception>
		// Token: 0x060017E7 RID: 6119 RVA: 0x0006573D File Offset: 0x0006393D
		public override byte[] EncryptValue(byte[] rgb)
		{
			return this.rsa.EncryptValue(rgb);
		}

		/// <summary>Exports the <see cref="T:System.Security.Cryptography.RSAParameters" />.</summary>
		/// <param name="includePrivateParameters">
		///       <see langword="true" /> to include private parameters; otherwise, <see langword="false" />. </param>
		/// <returns>The parameters for <see cref="T:System.Security.Cryptography.RSA" />.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The key cannot be exported. </exception>
		// Token: 0x060017E8 RID: 6120 RVA: 0x0006574C File Offset: 0x0006394C
		public override RSAParameters ExportParameters(bool includePrivateParameters)
		{
			if (includePrivateParameters && !this.privateKeyExportable)
			{
				throw new CryptographicException("cannot export private key");
			}
			RSAParameters rsaparameters = this.rsa.ExportParameters(includePrivateParameters);
			if (includePrivateParameters)
			{
				if (rsaparameters.D == null)
				{
					throw new ArgumentNullException("Missing D parameter for the private key.");
				}
				if (rsaparameters.P == null || rsaparameters.Q == null || rsaparameters.DP == null || rsaparameters.DQ == null || rsaparameters.InverseQ == null)
				{
					throw new CryptographicException("Missing some CRT parameters for the private key.");
				}
			}
			return rsaparameters;
		}

		/// <summary>Imports the specified <see cref="T:System.Security.Cryptography.RSAParameters" />.</summary>
		/// <param name="parameters">The parameters for <see cref="T:System.Security.Cryptography.RSA" />. </param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The cryptographic service provider (CSP) cannot be acquired.-or- The <paramref name="parameters" /> parameter has missing fields. </exception>
		// Token: 0x060017E9 RID: 6121 RVA: 0x000657C6 File Offset: 0x000639C6
		public override void ImportParameters(RSAParameters parameters)
		{
			this.rsa.ImportParameters(parameters);
		}

		// Token: 0x060017EA RID: 6122 RVA: 0x000657D4 File Offset: 0x000639D4
		private string GetHashNameFromOID(string oid)
		{
			if (oid == "1.3.14.3.2.26")
			{
				return "SHA1";
			}
			if (oid == "1.2.840.113549.2.5")
			{
				return "MD5";
			}
			if (oid == "2.16.840.1.101.3.4.2.1")
			{
				return "SHA256";
			}
			if (oid == "2.16.840.1.101.3.4.2.2")
			{
				return "SHA384";
			}
			if (!(oid == "2.16.840.1.101.3.4.2.3"))
			{
				throw new CryptographicException(oid + " is an unsupported hash algorithm for RSA signing");
			}
			return "SHA512";
		}

		/// <summary>Verifies that a digital signature is valid by determining the hash value in the signature using the provided public key and comparing it to the provided hash value.</summary>
		/// <param name="rgbHash">The hash value of the signed data. </param>
		/// <param name="str">The hash algorithm identifier (OID) used to create the hash value of the data. </param>
		/// <param name="rgbSignature">The signature data to be verified. </param>
		/// <returns>
		///     <see langword="true" /> if the signature is valid; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="rgbHash" /> parameter is <see langword="null" />.-or- The <paramref name="rgbSignature" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The cryptographic service provider (CSP) cannot be acquired.-or- The signature cannot be verified. </exception>
		// Token: 0x060017EB RID: 6123 RVA: 0x00065854 File Offset: 0x00063A54
		public bool VerifyHash(byte[] rgbHash, string str, byte[] rgbSignature)
		{
			if (rgbHash == null)
			{
				throw new ArgumentNullException("rgbHash");
			}
			if (rgbSignature == null)
			{
				throw new ArgumentNullException("rgbSignature");
			}
			HashAlgorithm hash = HashAlgorithm.Create((str == null) ? "SHA1" : this.GetHashNameFromOID(str));
			return PKCS1.Verify_v15(this, hash, rgbHash, rgbSignature);
		}

		// Token: 0x060017EC RID: 6124 RVA: 0x0006589D File Offset: 0x00063A9D
		protected override void Dispose(bool disposing)
		{
			if (!this.m_disposed)
			{
				if (this.persisted && !this.persistKey)
				{
					this.store.Remove();
				}
				if (this.rsa != null)
				{
					this.rsa.Clear();
				}
				this.m_disposed = true;
			}
		}

		// Token: 0x060017ED RID: 6125 RVA: 0x000658DC File Offset: 0x00063ADC
		private void OnKeyGenerated(object sender, EventArgs e)
		{
			if (this.persistKey && !this.persisted)
			{
				this.store.KeyValue = this.ToXmlString(!this.rsa.PublicOnly);
				this.store.Save();
				this.persisted = true;
			}
		}

		// Token: 0x040009E2 RID: 2530
		private static volatile CspProviderFlags s_UseMachineKeyStore;

		// Token: 0x040009E3 RID: 2531
		private KeyPairPersistence store;

		// Token: 0x040009E4 RID: 2532
		private bool persistKey;

		// Token: 0x040009E5 RID: 2533
		private bool persisted;

		// Token: 0x040009E6 RID: 2534
		private bool privateKeyExportable;

		// Token: 0x040009E7 RID: 2535
		private bool m_disposed;

		// Token: 0x040009E8 RID: 2536
		private RSAManaged rsa;
	}
}
