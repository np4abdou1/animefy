using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Accesses the managed version of the <see cref="T:System.Security.Cryptography.Rijndael" /> algorithm. This class cannot be inherited.</summary>
	// Token: 0x020002C7 RID: 711
	[ComVisible(true)]
	public sealed class RijndaelManaged : Rijndael
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.RijndaelManaged" /> class.</summary>
		/// <exception cref="T:System.InvalidOperationException">This class is not compliant with the FIPS algorithm.</exception>
		// Token: 0x060017AD RID: 6061 RVA: 0x00060FBB File Offset: 0x0005F1BB
		public RijndaelManaged()
		{
			if (CryptoConfig.AllowOnlyFipsAlgorithms)
			{
				throw new InvalidOperationException(Environment.GetResourceString("This implementation is not part of the Windows Platform FIPS validated cryptographic algorithms."));
			}
		}

		/// <summary>Creates a symmetric <see cref="T:System.Security.Cryptography.Rijndael" /> encryptor object with the specified <see cref="P:System.Security.Cryptography.SymmetricAlgorithm.Key" /> and initialization vector (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.IV" />).</summary>
		/// <param name="rgbKey">The secret key to be used for the symmetric algorithm. The key size must be 128, 192, or 256 bits.</param>
		/// <param name="rgbIV">The IV to be used for the symmetric algorithm. </param>
		/// <returns>A symmetric <see cref="T:System.Security.Cryptography.Rijndael" /> encryptor object.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="rgbKey" /> parameter is <see langword="null" />.-or-The <paramref name="rgbIV" /> parameter is <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The value of the <see cref="P:System.Security.Cryptography.SymmetricAlgorithm.Mode" /> property is not <see cref="F:System.Security.Cryptography.CipherMode.ECB" />, <see cref="F:System.Security.Cryptography.CipherMode.CBC" />, or <see cref="F:System.Security.Cryptography.CipherMode.CFB" />.</exception>
		// Token: 0x060017AE RID: 6062 RVA: 0x00060FDA File Offset: 0x0005F1DA
		public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
		{
			return this.NewEncryptor(rgbKey, this.ModeValue, rgbIV, this.FeedbackSizeValue, RijndaelManagedTransformMode.Encrypt);
		}

		/// <summary>Creates a symmetric <see cref="T:System.Security.Cryptography.Rijndael" /> decryptor object with the specified <see cref="P:System.Security.Cryptography.SymmetricAlgorithm.Key" /> and initialization vector (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.IV" />).</summary>
		/// <param name="rgbKey">The secret key to be used for the symmetric algorithm. The key size must be 128, 192, or 256 bits.</param>
		/// <param name="rgbIV">The IV to be used for the symmetric algorithm. </param>
		/// <returns>A symmetric <see cref="T:System.Security.Cryptography.Rijndael" /> decryptor object.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="rgbKey" /> parameter is <see langword="null" />.-or-The <paramref name="rgbIV" /> parameter is <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The value of the <see cref="P:System.Security.Cryptography.SymmetricAlgorithm.Mode" /> property is not <see cref="F:System.Security.Cryptography.CipherMode.ECB" />, <see cref="F:System.Security.Cryptography.CipherMode.CBC" />, or <see cref="F:System.Security.Cryptography.CipherMode.CFB" />.</exception>
		// Token: 0x060017AF RID: 6063 RVA: 0x00060FF1 File Offset: 0x0005F1F1
		public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
		{
			return this.NewEncryptor(rgbKey, this.ModeValue, rgbIV, this.FeedbackSizeValue, RijndaelManagedTransformMode.Decrypt);
		}

		/// <summary>Generates a random <see cref="P:System.Security.Cryptography.SymmetricAlgorithm.Key" /> to be used for the algorithm.</summary>
		// Token: 0x060017B0 RID: 6064 RVA: 0x00061008 File Offset: 0x0005F208
		public override void GenerateKey()
		{
			this.KeyValue = Utils.GenerateRandom(this.KeySizeValue / 8);
		}

		/// <summary>Generates a random initialization vector (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.IV" />) to be used for the algorithm.</summary>
		// Token: 0x060017B1 RID: 6065 RVA: 0x0006101D File Offset: 0x0005F21D
		public override void GenerateIV()
		{
			this.IVValue = Utils.GenerateRandom(this.BlockSizeValue / 8);
		}

		// Token: 0x060017B2 RID: 6066 RVA: 0x00061032 File Offset: 0x0005F232
		private ICryptoTransform NewEncryptor(byte[] rgbKey, CipherMode mode, byte[] rgbIV, int feedbackSize, RijndaelManagedTransformMode encryptMode)
		{
			if (rgbKey == null)
			{
				rgbKey = Utils.GenerateRandom(this.KeySizeValue / 8);
			}
			if (rgbIV == null)
			{
				rgbIV = Utils.GenerateRandom(this.BlockSizeValue / 8);
			}
			return new RijndaelManagedTransform(rgbKey, mode, rgbIV, this.BlockSizeValue, feedbackSize, this.PaddingValue, encryptMode);
		}
	}
}
