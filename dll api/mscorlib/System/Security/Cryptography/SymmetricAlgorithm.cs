using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Represents the abstract base class from which all implementations of symmetric algorithms must inherit.</summary>
	// Token: 0x020002DE RID: 734
	[ComVisible(true)]
	public abstract class SymmetricAlgorithm : IDisposable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.SymmetricAlgorithm" /> class.</summary>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The implementation of the class derived from the symmetric algorithm is not valid.</exception>
		// Token: 0x06001841 RID: 6209 RVA: 0x00067839 File Offset: 0x00065A39
		protected SymmetricAlgorithm()
		{
			this.ModeValue = CipherMode.CBC;
			this.PaddingValue = PaddingMode.PKCS7;
		}

		/// <summary>Releases all resources used by the current instance of the <see cref="T:System.Security.Cryptography.SymmetricAlgorithm" /> class.</summary>
		// Token: 0x06001842 RID: 6210 RVA: 0x0006784F File Offset: 0x00065A4F
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Releases all resources used by the <see cref="T:System.Security.Cryptography.SymmetricAlgorithm" /> class.</summary>
		// Token: 0x06001843 RID: 6211 RVA: 0x0005F4C8 File Offset: 0x0005D6C8
		public void Clear()
		{
			((IDisposable)this).Dispose();
		}

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Security.Cryptography.SymmetricAlgorithm" /> and optionally releases the managed resources.</summary>
		/// <param name="disposing">
		///       <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources. </param>
		// Token: 0x06001844 RID: 6212 RVA: 0x00067860 File Offset: 0x00065A60
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (this.KeyValue != null)
				{
					Array.Clear(this.KeyValue, 0, this.KeyValue.Length);
					this.KeyValue = null;
				}
				if (this.IVValue != null)
				{
					Array.Clear(this.IVValue, 0, this.IVValue.Length);
					this.IVValue = null;
				}
			}
		}

		/// <summary>Gets or sets the block size, in bits, of the cryptographic operation.</summary>
		/// <returns>The block size, in bits.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The block size is invalid. </exception>
		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06001845 RID: 6213 RVA: 0x000678B6 File Offset: 0x00065AB6
		public virtual int BlockSize
		{
			get
			{
				return this.BlockSizeValue;
			}
		}

		/// <summary>Gets or sets the feedback size, in bits, of the cryptographic operation.</summary>
		/// <returns>The feedback size in bits.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The feedback size is larger than the block size. </exception>
		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06001846 RID: 6214 RVA: 0x000678BE File Offset: 0x00065ABE
		public virtual int FeedbackSize
		{
			get
			{
				return this.FeedbackSizeValue;
			}
		}

		/// <summary>Gets or sets the initialization vector (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.IV" />) for the symmetric algorithm.</summary>
		/// <returns>The initialization vector.</returns>
		/// <exception cref="T:System.ArgumentNullException">An attempt was made to set the initialization vector to <see langword="null" />. </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">An attempt was made to set the initialization vector to an invalid size. </exception>
		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06001847 RID: 6215 RVA: 0x000678C6 File Offset: 0x00065AC6
		// (set) Token: 0x06001848 RID: 6216 RVA: 0x000678E6 File Offset: 0x00065AE6
		public virtual byte[] IV
		{
			get
			{
				if (this.IVValue == null)
				{
					this.GenerateIV();
				}
				return (byte[])this.IVValue.Clone();
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				if (value.Length != this.BlockSizeValue / 8)
				{
					throw new CryptographicException(Environment.GetResourceString("Specified initialization vector (IV) does not match the block size for this algorithm."));
				}
				this.IVValue = (byte[])value.Clone();
			}
		}

		/// <summary>Gets or sets the secret key for the symmetric algorithm.</summary>
		/// <returns>The secret key to use for the symmetric algorithm.</returns>
		/// <exception cref="T:System.ArgumentNullException">An attempt was made to set the key to <see langword="null" />. </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The key size is invalid.</exception>
		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06001849 RID: 6217 RVA: 0x00067924 File Offset: 0x00065B24
		// (set) Token: 0x0600184A RID: 6218 RVA: 0x00067944 File Offset: 0x00065B44
		public virtual byte[] Key
		{
			get
			{
				if (this.KeyValue == null)
				{
					this.GenerateKey();
				}
				return (byte[])this.KeyValue.Clone();
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				if (!this.ValidKeySize(value.Length * 8))
				{
					throw new CryptographicException(Environment.GetResourceString("Specified key is not a valid size for this algorithm."));
				}
				this.KeyValue = (byte[])value.Clone();
				this.KeySizeValue = value.Length * 8;
			}
		}

		/// <summary>Gets the key sizes, in bits, that are supported by the symmetric algorithm.</summary>
		/// <returns>An array that contains the key sizes supported by the algorithm.</returns>
		// Token: 0x1700028B RID: 651
		// (get) Token: 0x0600184B RID: 6219 RVA: 0x00067998 File Offset: 0x00065B98
		public virtual KeySizes[] LegalKeySizes
		{
			get
			{
				return (KeySizes[])this.LegalKeySizesValue.Clone();
			}
		}

		/// <summary>Gets or sets the size, in bits, of the secret key used by the symmetric algorithm.</summary>
		/// <returns>The size, in bits, of the secret key used by the symmetric algorithm.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The key size is not valid. </exception>
		// Token: 0x1700028C RID: 652
		// (get) Token: 0x0600184C RID: 6220 RVA: 0x00060E24 File Offset: 0x0005F024
		public virtual int KeySize
		{
			get
			{
				return this.KeySizeValue;
			}
		}

		/// <summary>Gets or sets the mode for operation of the symmetric algorithm.</summary>
		/// <returns>The mode for operation of the symmetric algorithm. The default is <see cref="F:System.Security.Cryptography.CipherMode.CBC" />.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The cipher mode is not one of the <see cref="T:System.Security.Cryptography.CipherMode" /> values. </exception>
		// Token: 0x1700028D RID: 653
		// (get) Token: 0x0600184D RID: 6221 RVA: 0x000679AA File Offset: 0x00065BAA
		// (set) Token: 0x0600184E RID: 6222 RVA: 0x000679B2 File Offset: 0x00065BB2
		public virtual CipherMode Mode
		{
			get
			{
				return this.ModeValue;
			}
			set
			{
				if (value < CipherMode.CBC || CipherMode.CFB < value)
				{
					throw new CryptographicException(Environment.GetResourceString("Specified cipher mode is not valid for this algorithm."));
				}
				this.ModeValue = value;
			}
		}

		/// <summary>Gets or sets the padding mode used in the symmetric algorithm.</summary>
		/// <returns>The padding mode used in the symmetric algorithm. The default is <see cref="F:System.Security.Cryptography.PaddingMode.PKCS7" />.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The padding mode is not one of the <see cref="T:System.Security.Cryptography.PaddingMode" /> values. </exception>
		// Token: 0x1700028E RID: 654
		// (get) Token: 0x0600184F RID: 6223 RVA: 0x000679D3 File Offset: 0x00065BD3
		// (set) Token: 0x06001850 RID: 6224 RVA: 0x000679DB File Offset: 0x00065BDB
		public virtual PaddingMode Padding
		{
			get
			{
				return this.PaddingValue;
			}
			set
			{
				if (value < PaddingMode.None || PaddingMode.ISO10126 < value)
				{
					throw new CryptographicException(Environment.GetResourceString("Specified padding mode is not valid for this algorithm."));
				}
				this.PaddingValue = value;
			}
		}

		/// <summary>Determines whether the specified key size is valid for the current algorithm.</summary>
		/// <param name="bitLength">The length, in bits, to check for a valid key size. </param>
		/// <returns>
		///     <see langword="true" /> if the specified key size is valid for the current algorithm; otherwise, <see langword="false" />.</returns>
		// Token: 0x06001851 RID: 6225 RVA: 0x000679FC File Offset: 0x00065BFC
		public bool ValidKeySize(int bitLength)
		{
			KeySizes[] legalKeySizes = this.LegalKeySizes;
			if (legalKeySizes == null)
			{
				return false;
			}
			for (int i = 0; i < legalKeySizes.Length; i++)
			{
				if (legalKeySizes[i].SkipSize == 0)
				{
					if (legalKeySizes[i].MinSize == bitLength)
					{
						return true;
					}
				}
				else
				{
					for (int j = legalKeySizes[i].MinSize; j <= legalKeySizes[i].MaxSize; j += legalKeySizes[i].SkipSize)
					{
						if (j == bitLength)
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		/// <summary>Creates the specified cryptographic object used to perform the symmetric algorithm.</summary>
		/// <param name="algName">The name of the specific implementation of the <see cref="T:System.Security.Cryptography.SymmetricAlgorithm" /> class to use. </param>
		/// <returns>A cryptographic object used to perform the symmetric algorithm.</returns>
		// Token: 0x06001852 RID: 6226 RVA: 0x00067A62 File Offset: 0x00065C62
		public static SymmetricAlgorithm Create(string algName)
		{
			return (SymmetricAlgorithm)CryptoConfig.CreateFromName(algName);
		}

		/// <summary>Creates a symmetric encryptor object with the current <see cref="P:System.Security.Cryptography.SymmetricAlgorithm.Key" /> property and initialization vector (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.IV" />).</summary>
		/// <returns>A symmetric encryptor object.</returns>
		// Token: 0x06001853 RID: 6227 RVA: 0x00067A6F File Offset: 0x00065C6F
		public virtual ICryptoTransform CreateEncryptor()
		{
			return this.CreateEncryptor(this.Key, this.IV);
		}

		/// <summary>When overridden in a derived class, creates a symmetric encryptor object with the specified <see cref="P:System.Security.Cryptography.SymmetricAlgorithm.Key" /> property and initialization vector (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.IV" />).</summary>
		/// <param name="rgbKey">The secret key to use for the symmetric algorithm. </param>
		/// <param name="rgbIV">The initialization vector to use for the symmetric algorithm. </param>
		/// <returns>A symmetric encryptor object.</returns>
		// Token: 0x06001854 RID: 6228
		public abstract ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV);

		/// <summary>Creates a symmetric decryptor object with the current <see cref="P:System.Security.Cryptography.SymmetricAlgorithm.Key" /> property and initialization vector (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.IV" />).</summary>
		/// <returns>A symmetric decryptor object.</returns>
		// Token: 0x06001855 RID: 6229 RVA: 0x00067A83 File Offset: 0x00065C83
		public virtual ICryptoTransform CreateDecryptor()
		{
			return this.CreateDecryptor(this.Key, this.IV);
		}

		/// <summary>When overridden in a derived class, creates a symmetric decryptor object with the specified <see cref="P:System.Security.Cryptography.SymmetricAlgorithm.Key" /> property and initialization vector (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.IV" />).</summary>
		/// <param name="rgbKey">The secret key to use for the symmetric algorithm. </param>
		/// <param name="rgbIV">The initialization vector to use for the symmetric algorithm. </param>
		/// <returns>A symmetric decryptor object.</returns>
		// Token: 0x06001856 RID: 6230
		public abstract ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV);

		/// <summary>When overridden in a derived class, generates a random key (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.Key" />) to use for the algorithm. </summary>
		// Token: 0x06001857 RID: 6231
		public abstract void GenerateKey();

		/// <summary>When overridden in a derived class, generates a random initialization vector (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.IV" />) to use for the algorithm.</summary>
		// Token: 0x06001858 RID: 6232
		public abstract void GenerateIV();

		/// <summary>Represents the block size, in bits, of the cryptographic operation.</summary>
		// Token: 0x04000A01 RID: 2561
		protected int BlockSizeValue;

		/// <summary>Represents the feedback size, in bits, of the cryptographic operation.</summary>
		// Token: 0x04000A02 RID: 2562
		protected int FeedbackSizeValue;

		/// <summary>Represents the initialization vector (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.IV" />) for the symmetric algorithm.</summary>
		// Token: 0x04000A03 RID: 2563
		protected byte[] IVValue;

		/// <summary>Represents the secret key for the symmetric algorithm.</summary>
		// Token: 0x04000A04 RID: 2564
		protected byte[] KeyValue;

		/// <summary>Specifies the block sizes, in bits, that are supported by the symmetric algorithm.</summary>
		// Token: 0x04000A05 RID: 2565
		protected KeySizes[] LegalBlockSizesValue;

		/// <summary>Specifies the key sizes, in bits, that are supported by the symmetric algorithm.</summary>
		// Token: 0x04000A06 RID: 2566
		protected KeySizes[] LegalKeySizesValue;

		/// <summary>Represents the size, in bits, of the secret key used by the symmetric algorithm.</summary>
		// Token: 0x04000A07 RID: 2567
		protected int KeySizeValue;

		/// <summary>Represents the cipher mode used in the symmetric algorithm.</summary>
		// Token: 0x04000A08 RID: 2568
		protected CipherMode ModeValue;

		/// <summary>Represents the padding mode used in the symmetric algorithm.</summary>
		// Token: 0x04000A09 RID: 2569
		protected PaddingMode PaddingValue;
	}
}
