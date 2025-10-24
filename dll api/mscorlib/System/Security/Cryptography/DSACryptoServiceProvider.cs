using System;
using System.Runtime.InteropServices;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	/// <summary>Defines a wrapper object to access the cryptographic service provider (CSP) implementation of the <see cref="T:System.Security.Cryptography.DSA" /> algorithm. This class cannot be inherited. </summary>
	// Token: 0x020002E4 RID: 740
	[ComVisible(true)]
	public sealed class DSACryptoServiceProvider : DSA
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.DSACryptoServiceProvider" /> class.</summary>
		// Token: 0x06001886 RID: 6278 RVA: 0x0006A016 File Offset: 0x00068216
		public DSACryptoServiceProvider() : this(1024)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.DSACryptoServiceProvider" /> class with the specified parameters for the cryptographic service provider (CSP).</summary>
		/// <param name="parameters">The parameters for the CSP. </param>
		// Token: 0x06001887 RID: 6279 RVA: 0x0006A023 File Offset: 0x00068223
		public DSACryptoServiceProvider(CspParameters parameters) : this(1024, parameters)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.DSACryptoServiceProvider" /> class with the specified key size.</summary>
		/// <param name="dwKeySize">The size of the key for the asymmetric algorithm in bits. </param>
		// Token: 0x06001888 RID: 6280 RVA: 0x0006A031 File Offset: 0x00068231
		public DSACryptoServiceProvider(int dwKeySize)
		{
			this.privateKeyExportable = true;
			base..ctor();
			this.Common(dwKeySize, false);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.DSACryptoServiceProvider" /> class with the specified key size and parameters for the cryptographic service provider (CSP).</summary>
		/// <param name="dwKeySize">The size of the key for the cryptographic algorithm in bits. </param>
		/// <param name="parameters">The parameters for the CSP. </param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The CSP cannot be acquired.-or- The key cannot be created. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="dwKeySize" /> is out of range.</exception>
		// Token: 0x06001889 RID: 6281 RVA: 0x0006A048 File Offset: 0x00068248
		public DSACryptoServiceProvider(int dwKeySize, CspParameters parameters)
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

		// Token: 0x0600188A RID: 6282 RVA: 0x0006A07C File Offset: 0x0006827C
		private void Common(int dwKeySize, bool parameters)
		{
			this.LegalKeySizesValue = new KeySizes[1];
			this.LegalKeySizesValue[0] = new KeySizes(512, 1024, 64);
			this.KeySize = dwKeySize;
			this.dsa = new DSAManaged(dwKeySize);
			this.dsa.KeyGenerated += this.OnKeyGenerated;
			this.persistKey = parameters;
			if (parameters)
			{
				return;
			}
			CspParameters cspParameters = new CspParameters(13);
			if (DSACryptoServiceProvider.useMachineKeyStore)
			{
				cspParameters.Flags |= CspProviderFlags.UseMachineKeyStore;
			}
			this.store = new KeyPairPersistence(cspParameters);
		}

		// Token: 0x0600188B RID: 6283 RVA: 0x0006A10C File Offset: 0x0006830C
		private void Common(CspParameters parameters)
		{
			this.store = new KeyPairPersistence(parameters);
			this.store.Load();
			if (this.store.KeyValue != null)
			{
				this.persisted = true;
				this.FromXmlString(this.store.KeyValue);
			}
			this.privateKeyExportable = ((parameters.Flags & CspProviderFlags.UseNonExportableKey) == CspProviderFlags.NoFlags);
		}

		// Token: 0x0600188C RID: 6284 RVA: 0x0006A168 File Offset: 0x00068368
		~DSACryptoServiceProvider()
		{
			this.Dispose(false);
		}

		/// <summary>Gets the size of the key used by the asymmetric algorithm in bits.</summary>
		/// <returns>The size of the key used by the asymmetric algorithm.</returns>
		// Token: 0x17000292 RID: 658
		// (get) Token: 0x0600188D RID: 6285 RVA: 0x0006A198 File Offset: 0x00068398
		public override int KeySize
		{
			get
			{
				return this.dsa.KeySize;
			}
		}

		/// <summary>Gets a value that indicates whether the <see cref="T:System.Security.Cryptography.DSACryptoServiceProvider" /> object contains only a public key.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Security.Cryptography.DSACryptoServiceProvider" /> object contains only a public key; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000293 RID: 659
		// (get) Token: 0x0600188E RID: 6286 RVA: 0x0006A1A5 File Offset: 0x000683A5
		[ComVisible(false)]
		public bool PublicOnly
		{
			get
			{
				return this.dsa.PublicOnly;
			}
		}

		/// <summary>Exports the <see cref="T:System.Security.Cryptography.DSAParameters" />.</summary>
		/// <param name="includePrivateParameters">
		///       <see langword="true" /> to include private parameters; otherwise, <see langword="false" />. </param>
		/// <returns>The parameters for <see cref="T:System.Security.Cryptography.DSA" />.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The key cannot be exported. </exception>
		// Token: 0x0600188F RID: 6287 RVA: 0x0006A1B2 File Offset: 0x000683B2
		public override DSAParameters ExportParameters(bool includePrivateParameters)
		{
			if (includePrivateParameters && !this.privateKeyExportable)
			{
				throw new CryptographicException(Locale.GetText("Cannot export private key"));
			}
			return this.dsa.ExportParameters(includePrivateParameters);
		}

		/// <summary>Imports the specified <see cref="T:System.Security.Cryptography.DSAParameters" />.</summary>
		/// <param name="parameters">The parameters for <see cref="T:System.Security.Cryptography.DSA" />. </param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The cryptographic service provider (CSP) cannot be acquired.-or- The <paramref name="parameters" /> parameter has missing fields. </exception>
		// Token: 0x06001890 RID: 6288 RVA: 0x0006A1DB File Offset: 0x000683DB
		public override void ImportParameters(DSAParameters parameters)
		{
			this.dsa.ImportParameters(parameters);
		}

		/// <summary>Verifies the <see cref="T:System.Security.Cryptography.DSA" /> signature for the specified data.</summary>
		/// <param name="rgbHash">The data signed with <paramref name="rgbSignature" />. </param>
		/// <param name="rgbSignature">The signature to be verified for <paramref name="rgbData" />. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="rgbSignature" /> matches the signature computed using the specified hash algorithm and key on <paramref name="rgbHash" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x06001891 RID: 6289 RVA: 0x0006A1E9 File Offset: 0x000683E9
		public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature)
		{
			return this.dsa.VerifySignature(rgbHash, rgbSignature);
		}

		// Token: 0x06001892 RID: 6290 RVA: 0x0006A1F8 File Offset: 0x000683F8
		protected override void Dispose(bool disposing)
		{
			if (!this.m_disposed)
			{
				if (this.persisted && !this.persistKey)
				{
					this.store.Remove();
				}
				if (this.dsa != null)
				{
					this.dsa.Clear();
				}
				this.m_disposed = true;
			}
		}

		// Token: 0x06001893 RID: 6291 RVA: 0x0006A238 File Offset: 0x00068438
		private void OnKeyGenerated(object sender, EventArgs e)
		{
			if (this.persistKey && !this.persisted)
			{
				this.store.KeyValue = this.ToXmlString(!this.dsa.PublicOnly);
				this.store.Save();
				this.persisted = true;
			}
		}

		// Token: 0x04000A1C RID: 2588
		private KeyPairPersistence store;

		// Token: 0x04000A1D RID: 2589
		private bool persistKey;

		// Token: 0x04000A1E RID: 2590
		private bool persisted;

		// Token: 0x04000A1F RID: 2591
		private bool privateKeyExportable;

		// Token: 0x04000A20 RID: 2592
		private bool m_disposed;

		// Token: 0x04000A21 RID: 2593
		private DSAManaged dsa;

		// Token: 0x04000A22 RID: 2594
		private static bool useMachineKeyStore;
	}
}
