﻿using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Represents the base class for the Data Encryption Standard (DES) algorithm from which all <see cref="T:System.Security.Cryptography.DES" /> implementations must derive.</summary>
	// Token: 0x020002AE RID: 686
	[ComVisible(true)]
	public abstract class DES : SymmetricAlgorithm
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.DES" /> class.</summary>
		// Token: 0x0600172E RID: 5934 RVA: 0x0005F918 File Offset: 0x0005DB18
		protected DES()
		{
			this.KeySizeValue = 64;
			this.BlockSizeValue = 64;
			this.FeedbackSizeValue = this.BlockSizeValue;
			this.LegalBlockSizesValue = DES.s_legalBlockSizes;
			this.LegalKeySizesValue = DES.s_legalKeySizes;
		}

		/// <summary>Gets or sets the secret key for the Data Encryption Standard (<see cref="T:System.Security.Cryptography.DES" />) algorithm.</summary>
		/// <returns>The secret key for the <see cref="T:System.Security.Cryptography.DES" /> algorithm.</returns>
		/// <exception cref="T:System.ArgumentNullException">An attempt was made to set the key to <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">An attempt was made to set a key whose length is not equal to <see cref="F:System.Security.Cryptography.SymmetricAlgorithm.BlockSizeValue" />. </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">An attempt was made to set a weak key (see <see cref="M:System.Security.Cryptography.DES.IsWeakKey(System.Byte[])" />) or a semi-weak key (see <see cref="M:System.Security.Cryptography.DES.IsSemiWeakKey(System.Byte[])" />). </exception>
		// Token: 0x1700026B RID: 619
		// (get) Token: 0x0600172F RID: 5935 RVA: 0x0005F952 File Offset: 0x0005DB52
		// (set) Token: 0x06001730 RID: 5936 RVA: 0x0005F98C File Offset: 0x0005DB8C
		public override byte[] Key
		{
			get
			{
				if (this.KeyValue == null)
				{
					do
					{
						this.GenerateKey();
					}
					while (DES.IsWeakKey(this.KeyValue) || DES.IsSemiWeakKey(this.KeyValue));
				}
				return (byte[])this.KeyValue.Clone();
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				if (!base.ValidKeySize(value.Length * 8))
				{
					throw new ArgumentException(Environment.GetResourceString("Specified key is not a valid size for this algorithm."));
				}
				if (DES.IsWeakKey(value))
				{
					throw new CryptographicException(Environment.GetResourceString("Specified key is a known weak key for '{0}' and cannot be used."), "DES");
				}
				if (DES.IsSemiWeakKey(value))
				{
					throw new CryptographicException(Environment.GetResourceString("Specified key is a known semi-weak key for '{0}' and cannot be used."), "DES");
				}
				this.KeyValue = (byte[])value.Clone();
				this.KeySizeValue = value.Length * 8;
			}
		}

		/// <summary>Creates an instance of a cryptographic object to perform the Data Encryption Standard (<see cref="T:System.Security.Cryptography.DES" />) algorithm.</summary>
		/// <returns>A cryptographic object.</returns>
		// Token: 0x06001731 RID: 5937 RVA: 0x0005FA1A File Offset: 0x0005DC1A
		public static DES Create()
		{
			return DES.Create("System.Security.Cryptography.DES");
		}

		/// <summary>Creates an instance of a cryptographic object to perform the specified implementation of the Data Encryption Standard (<see cref="T:System.Security.Cryptography.DES" />) algorithm.</summary>
		/// <param name="algName">The name of the specific implementation of <see cref="T:System.Security.Cryptography.DES" /> to use. </param>
		/// <returns>A cryptographic object.</returns>
		// Token: 0x06001732 RID: 5938 RVA: 0x0005FA26 File Offset: 0x0005DC26
		public new static DES Create(string algName)
		{
			return (DES)CryptoConfig.CreateFromName(algName);
		}

		/// <summary>Determines whether the specified key is weak.</summary>
		/// <param name="rgbKey">The secret key to test for weakness. </param>
		/// <returns>
		///     <see langword="true" /> if the key is weak; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The size of the <paramref name="rgbKey" /> parameter is not valid. </exception>
		// Token: 0x06001733 RID: 5939 RVA: 0x0005FA34 File Offset: 0x0005DC34
		public static bool IsWeakKey(byte[] rgbKey)
		{
			if (!DES.IsLegalKeySize(rgbKey))
			{
				throw new CryptographicException(Environment.GetResourceString("Specified key is not a valid size for this algorithm."));
			}
			ulong num = DES.QuadWordFromBigEndian(Utils.FixupKeyParity(rgbKey));
			return num == 72340172838076673UL || num == 18374403900871474942UL || num == 2242545357694045710UL || num == 16204198716015505905UL;
		}

		/// <summary>Determines whether the specified key is semi-weak.</summary>
		/// <param name="rgbKey">The secret key to test for semi-weakness. </param>
		/// <returns>
		///     <see langword="true" /> if the key is semi-weak; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The size of the <paramref name="rgbKey" /> parameter is not valid. </exception>
		// Token: 0x06001734 RID: 5940 RVA: 0x0005FA98 File Offset: 0x0005DC98
		public static bool IsSemiWeakKey(byte[] rgbKey)
		{
			if (!DES.IsLegalKeySize(rgbKey))
			{
				throw new CryptographicException(Environment.GetResourceString("Specified key is not a valid size for this algorithm."));
			}
			ulong num = DES.QuadWordFromBigEndian(Utils.FixupKeyParity(rgbKey));
			return num == 143554428589179390UL || num == 18303189645120372225UL || num == 2296870857142767345UL || num == 16149873216566784270UL || num == 135110050437988849UL || num == 16141428838415593729UL || num == 2305315235293957886UL || num == 18311634023271562766UL || num == 80784550989267214UL || num == 2234100979542855169UL || num == 16212643094166696446UL || num == 18365959522720284401UL;
		}

		// Token: 0x06001735 RID: 5941 RVA: 0x0005FB5F File Offset: 0x0005DD5F
		private static bool IsLegalKeySize(byte[] rgbKey)
		{
			return rgbKey != null && rgbKey.Length == 8;
		}

		// Token: 0x06001736 RID: 5942 RVA: 0x0005FB6D File Offset: 0x0005DD6D
		private static ulong QuadWordFromBigEndian(byte[] block)
		{
			return (ulong)block[0] << 56 | (ulong)block[1] << 48 | (ulong)block[2] << 40 | (ulong)block[3] << 32 | (ulong)block[4] << 24 | (ulong)block[5] << 16 | (ulong)block[6] << 8 | (ulong)block[7];
		}

		// Token: 0x04000985 RID: 2437
		private static KeySizes[] s_legalBlockSizes = new KeySizes[]
		{
			new KeySizes(64, 64, 0)
		};

		// Token: 0x04000986 RID: 2438
		private static KeySizes[] s_legalKeySizes = new KeySizes[]
		{
			new KeySizes(64, 64, 0)
		};
	}
}
