using System;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	/// <summary>Performs symmetric encryption and decryption using the Cryptographic Application Programming Interfaces (CAPI) implementation of the Advanced Encryption Standard (AES) algorithm. </summary>
	// Token: 0x02000013 RID: 19
	public sealed class AesCryptoServiceProvider : Aes
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.AesCryptoServiceProvider" /> class. </summary>
		/// <exception cref="T:System.PlatformNotSupportedException">There is no supported key size for the current platform.</exception>
		// Token: 0x06000046 RID: 70 RVA: 0x00002093 File Offset: 0x00000293
		public AesCryptoServiceProvider()
		{
			this.FeedbackSizeValue = 8;
		}

		/// <summary>Generates a random initialization vector (IV) to use for the algorithm.</summary>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The initialization vector (IV) could not be generated. </exception>
		// Token: 0x06000047 RID: 71 RVA: 0x000020A2 File Offset: 0x000002A2
		public override void GenerateIV()
		{
			this.IVValue = KeyBuilder.IV(this.BlockSizeValue >> 3);
		}

		/// <summary>Generates a random key to use for the algorithm. </summary>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The key could not be generated.</exception>
		// Token: 0x06000048 RID: 72 RVA: 0x000020B7 File Offset: 0x000002B7
		public override void GenerateKey()
		{
			this.KeyValue = KeyBuilder.Key(this.KeySizeValue >> 3);
		}

		/// <summary>Creates a symmetric AES decryptor object using the specified key and initialization vector (IV).</summary>
		/// <param name="key">The secret key to use for the symmetric algorithm.</param>
		/// <param name="iv">The initialization vector to use for the symmetric algorithm.</param>
		/// <returns>A symmetric AES decryptor object.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> or <paramref name="iv" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="key" /> is invalid.</exception>
		// Token: 0x06000049 RID: 73 RVA: 0x000020CC File Offset: 0x000002CC
		public override ICryptoTransform CreateDecryptor(byte[] key, byte[] iv)
		{
			if (this.Mode == CipherMode.CFB && this.FeedbackSize > 64)
			{
				throw new CryptographicException("CFB with Feedbaack > 64 bits");
			}
			return new AesTransform(this, false, key, iv);
		}

		/// <summary>Creates a symmetric encryptor object using the specified key and initialization vector (IV).</summary>
		/// <param name="key">The secret key to use for the symmetric algorithm.</param>
		/// <param name="iv">The initialization vector to use for the symmetric algorithm.</param>
		/// <returns>A symmetric AES encryptor object.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="key" /> or <paramref name="iv" /> parameter is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="key" /> is invalid.</exception>
		// Token: 0x0600004A RID: 74 RVA: 0x000020F5 File Offset: 0x000002F5
		public override ICryptoTransform CreateEncryptor(byte[] key, byte[] iv)
		{
			if (this.Mode == CipherMode.CFB && this.FeedbackSize > 64)
			{
				throw new CryptographicException("CFB with Feedbaack > 64 bits");
			}
			return new AesTransform(this, true, key, iv);
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600004B RID: 75 RVA: 0x0000211E File Offset: 0x0000031E
		// (set) Token: 0x0600004C RID: 76 RVA: 0x00002126 File Offset: 0x00000326
		public override byte[] IV
		{
			get
			{
				return base.IV;
			}
			set
			{
				base.IV = value;
			}
		}

		/// <summary>Gets or sets the symmetric key that is used for encryption and decryption.</summary>
		/// <returns>The symmetric key that is used for encryption and decryption.</returns>
		/// <exception cref="T:System.ArgumentNullException">The value for the key is <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The size of the key is invalid.</exception>
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600004D RID: 77 RVA: 0x0000212F File Offset: 0x0000032F
		// (set) Token: 0x0600004E RID: 78 RVA: 0x00002137 File Offset: 0x00000337
		public override byte[] Key
		{
			get
			{
				return base.Key;
			}
			set
			{
				base.Key = value;
			}
		}

		/// <summary>Gets or sets the size, in bits, of the secret key. </summary>
		/// <returns>The size, in bits, of the key.</returns>
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00002140 File Offset: 0x00000340
		public override int KeySize
		{
			get
			{
				return base.KeySize;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00002148 File Offset: 0x00000348
		public override int FeedbackSize
		{
			get
			{
				return base.FeedbackSize;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00002150 File Offset: 0x00000350
		// (set) Token: 0x06000052 RID: 82 RVA: 0x00002158 File Offset: 0x00000358
		public override CipherMode Mode
		{
			get
			{
				return base.Mode;
			}
			set
			{
				if (value == CipherMode.CTS)
				{
					throw new CryptographicException("CTS is not supported");
				}
				base.Mode = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00002170 File Offset: 0x00000370
		// (set) Token: 0x06000054 RID: 84 RVA: 0x00002178 File Offset: 0x00000378
		public override PaddingMode Padding
		{
			get
			{
				return base.Padding;
			}
			set
			{
				base.Padding = value;
			}
		}

		/// <summary>Creates a symmetric AES decryptor object using the current key and initialization vector (IV).</summary>
		/// <returns>A symmetric AES decryptor object.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The current key is invalid or missing.</exception>
		// Token: 0x06000055 RID: 85 RVA: 0x00002181 File Offset: 0x00000381
		public override ICryptoTransform CreateDecryptor()
		{
			return this.CreateDecryptor(this.Key, this.IV);
		}

		/// <summary>Creates a symmetric AES encryptor object using the current key and initialization vector (IV).</summary>
		/// <returns>A symmetric AES encryptor object.</returns>
		// Token: 0x06000056 RID: 86 RVA: 0x00002195 File Offset: 0x00000395
		public override ICryptoTransform CreateEncryptor()
		{
			return this.CreateEncryptor(this.Key, this.IV);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000021A9 File Offset: 0x000003A9
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}
	}
}
