using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Represents the abstract base class from which all implementations of asymmetric algorithms must inherit.</summary>
	// Token: 0x020002A4 RID: 676
	[ComVisible(true)]
	public abstract class AsymmetricAlgorithm : IDisposable
	{
		/// <summary>Releases all resources used by the current instance of the <see cref="T:System.Security.Cryptography.AsymmetricAlgorithm" /> class.</summary>
		// Token: 0x0600170D RID: 5901 RVA: 0x0005F658 File Offset: 0x0005D858
		public void Dispose()
		{
			this.Clear();
		}

		/// <summary>Releases all resources used by the <see cref="T:System.Security.Cryptography.AsymmetricAlgorithm" /> class.</summary>
		// Token: 0x0600170E RID: 5902 RVA: 0x0005F660 File Offset: 0x0005D860
		public void Clear()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Security.Cryptography.AsymmetricAlgorithm" /> class and optionally releases the managed resources.</summary>
		/// <param name="disposing">
		///       <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources. </param>
		// Token: 0x0600170F RID: 5903 RVA: 0x00002A7D File Offset: 0x00000C7D
		protected virtual void Dispose(bool disposing)
		{
		}

		/// <summary>Gets or sets the size, in bits, of the key modulus used by the asymmetric algorithm.</summary>
		/// <returns>The size, in bits, of the key modulus used by the asymmetric algorithm.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The key modulus size is invalid. </exception>
		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06001710 RID: 5904 RVA: 0x0005F66F File Offset: 0x0005D86F
		// (set) Token: 0x06001711 RID: 5905 RVA: 0x0005F678 File Offset: 0x0005D878
		public virtual int KeySize
		{
			get
			{
				return this.KeySizeValue;
			}
			set
			{
				for (int i = 0; i < this.LegalKeySizesValue.Length; i++)
				{
					if (this.LegalKeySizesValue[i].SkipSize == 0)
					{
						if (this.LegalKeySizesValue[i].MinSize == value)
						{
							this.KeySizeValue = value;
							return;
						}
					}
					else
					{
						for (int j = this.LegalKeySizesValue[i].MinSize; j <= this.LegalKeySizesValue[i].MaxSize; j += this.LegalKeySizesValue[i].SkipSize)
						{
							if (j == value)
							{
								this.KeySizeValue = value;
								return;
							}
						}
					}
				}
				throw new CryptographicException(Environment.GetResourceString("Specified key is not a valid size for this algorithm."));
			}
		}

		/// <summary>When overridden in a derived class, reconstructs an <see cref="T:System.Security.Cryptography.AsymmetricAlgorithm" /> object from an XML string. Otherwise, throws a <see cref="T:System.NotImplementedException" />.</summary>
		/// <param name="xmlString">The XML string to use to reconstruct the <see cref="T:System.Security.Cryptography.AsymmetricAlgorithm" /> object. </param>
		// Token: 0x06001712 RID: 5906 RVA: 0x0002B1E0 File Offset: 0x000293E0
		public virtual void FromXmlString(string xmlString)
		{
			throw new NotImplementedException();
		}

		/// <summary>When overridden in a derived class, creates and returns an XML string representation of the current <see cref="T:System.Security.Cryptography.AsymmetricAlgorithm" /> object. Otherwise, throws a <see cref="T:System.NotImplementedException" />.</summary>
		/// <param name="includePrivateParameters">
		///       <see langword="true" /> to include private parameters; otherwise, <see langword="false" />. </param>
		/// <returns>An XML string encoding of the current <see cref="T:System.Security.Cryptography.AsymmetricAlgorithm" /> object.</returns>
		// Token: 0x06001713 RID: 5907 RVA: 0x0002B1E0 File Offset: 0x000293E0
		public virtual string ToXmlString(bool includePrivateParameters)
		{
			throw new NotImplementedException();
		}

		/// <summary>Represents the size, in bits, of the key modulus used by the asymmetric algorithm.</summary>
		// Token: 0x04000965 RID: 2405
		protected int KeySizeValue;

		/// <summary>Specifies the key sizes that are supported by the asymmetric algorithm.</summary>
		// Token: 0x04000966 RID: 2406
		protected KeySizes[] LegalKeySizesValue;
	}
}
