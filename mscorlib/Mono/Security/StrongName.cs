using System;
using System.Security.Cryptography;
using Mono.Security.Cryptography;

namespace Mono.Security
{
	// Token: 0x02000044 RID: 68
	internal sealed class StrongName
	{
		// Token: 0x06000117 RID: 279 RVA: 0x00007CEC File Offset: 0x00005EEC
		public StrongName(byte[] data)
		{
			if (data == null)
			{
				throw new ArgumentNullException("data");
			}
			if (data.Length == 16)
			{
				int i = 0;
				int num = 0;
				while (i < data.Length)
				{
					num += (int)data[i++];
				}
				if (num == 4)
				{
					this.publicKey = (byte[])data.Clone();
					return;
				}
			}
			else
			{
				this.RSA = CryptoConvert.FromCapiKeyBlob(data);
				if (this.rsa == null)
				{
					throw new ArgumentException("data isn't a correctly encoded RSA public key");
				}
			}
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00007D5F File Offset: 0x00005F5F
		public StrongName(RSA rsa)
		{
			if (rsa == null)
			{
				throw new ArgumentNullException("rsa");
			}
			this.RSA = rsa;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00007D7C File Offset: 0x00005F7C
		private void InvalidateCache()
		{
			this.publicKey = null;
			this.keyToken = null;
		}

		// Token: 0x1700001A RID: 26
		// (set) Token: 0x0600011A RID: 282 RVA: 0x00007D8C File Offset: 0x00005F8C
		public RSA RSA
		{
			set
			{
				this.rsa = value;
				this.InvalidateCache();
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600011B RID: 283 RVA: 0x00007D9C File Offset: 0x00005F9C
		public byte[] PublicKey
		{
			get
			{
				if (this.publicKey == null)
				{
					byte[] array = CryptoConvert.ToCapiKeyBlob(this.rsa, false);
					this.publicKey = new byte[32 + (this.rsa.KeySize >> 3)];
					this.publicKey[0] = array[4];
					this.publicKey[1] = array[5];
					this.publicKey[2] = array[6];
					this.publicKey[3] = array[7];
					this.publicKey[4] = 4;
					this.publicKey[5] = 128;
					this.publicKey[6] = 0;
					this.publicKey[7] = 0;
					byte[] bytes = BitConverterLE.GetBytes(this.publicKey.Length - 12);
					this.publicKey[8] = bytes[0];
					this.publicKey[9] = bytes[1];
					this.publicKey[10] = bytes[2];
					this.publicKey[11] = bytes[3];
					this.publicKey[12] = 6;
					Buffer.BlockCopy(array, 1, this.publicKey, 13, this.publicKey.Length - 13);
					this.publicKey[23] = 49;
				}
				return (byte[])this.publicKey.Clone();
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00007EB0 File Offset: 0x000060B0
		public byte[] PublicKeyToken
		{
			get
			{
				if (this.keyToken == null)
				{
					byte[] array = this.PublicKey;
					if (array == null)
					{
						return null;
					}
					byte[] array2 = StrongName.GetHashAlgorithm(this.TokenAlgorithm).ComputeHash(array);
					this.keyToken = new byte[8];
					Buffer.BlockCopy(array2, array2.Length - 8, this.keyToken, 0, 8);
					Array.Reverse<byte>(this.keyToken, 0, 8);
				}
				return (byte[])this.keyToken.Clone();
			}
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00007F1F File Offset: 0x0000611F
		private static HashAlgorithm GetHashAlgorithm(string algorithm)
		{
			return HashAlgorithm.Create(algorithm);
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600011E RID: 286 RVA: 0x00007F27 File Offset: 0x00006127
		public string TokenAlgorithm
		{
			get
			{
				if (this.tokenAlgorithm == null)
				{
					this.tokenAlgorithm = "SHA1";
				}
				return this.tokenAlgorithm;
			}
		}

		// Token: 0x0400013F RID: 319
		private RSA rsa;

		// Token: 0x04000140 RID: 320
		private byte[] publicKey;

		// Token: 0x04000141 RID: 321
		private byte[] keyToken;

		// Token: 0x04000142 RID: 322
		private string tokenAlgorithm;

		// Token: 0x04000143 RID: 323
		private static object lockObject = new object();
	}
}
