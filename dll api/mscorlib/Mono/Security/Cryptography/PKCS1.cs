using System;
using System.Security.Cryptography;

namespace Mono.Security.Cryptography
{
	// Token: 0x0200004B RID: 75
	internal sealed class PKCS1
	{
		// Token: 0x0600016B RID: 363 RVA: 0x0000A248 File Offset: 0x00008448
		private static bool Compare(byte[] array1, byte[] array2)
		{
			bool flag = array1.Length == array2.Length;
			if (flag)
			{
				for (int i = 0; i < array1.Length; i++)
				{
					if (array1[i] != array2[i])
					{
						return false;
					}
				}
			}
			return flag;
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0000A27C File Offset: 0x0000847C
		public static byte[] I2OSP(byte[] x, int size)
		{
			byte[] array = new byte[size];
			Buffer.BlockCopy(x, 0, array, array.Length - x.Length, x.Length);
			return array;
		}

		// Token: 0x0600016D RID: 365 RVA: 0x0000A2A4 File Offset: 0x000084A4
		public static byte[] OS2IP(byte[] x)
		{
			int num = 0;
			while (x[num++] == 0 && num < x.Length)
			{
			}
			num--;
			if (num > 0)
			{
				byte[] array = new byte[x.Length - num];
				Buffer.BlockCopy(x, num, array, 0, array.Length);
				return array;
			}
			return x;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0000A2E4 File Offset: 0x000084E4
		public static byte[] RSAVP1(RSA rsa, byte[] s)
		{
			return rsa.EncryptValue(s);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0000A2ED File Offset: 0x000084ED
		public static bool Verify_v15(RSA rsa, HashAlgorithm hash, byte[] hashValue, byte[] signature)
		{
			return PKCS1.Verify_v15(rsa, hash, hashValue, signature, false);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0000A2FC File Offset: 0x000084FC
		internal static bool Verify_v15(RSA rsa, string hashName, byte[] hashValue, byte[] signature)
		{
			bool result;
			using (HashAlgorithm hashAlgorithm = PKCS1.CreateFromName(hashName))
			{
				result = PKCS1.Verify_v15(rsa, hashAlgorithm, hashValue, signature, false);
			}
			return result;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0000A338 File Offset: 0x00008538
		public static bool Verify_v15(RSA rsa, HashAlgorithm hash, byte[] hashValue, byte[] signature, bool tryNonStandardEncoding)
		{
			int num = rsa.KeySize >> 3;
			byte[] s = PKCS1.OS2IP(signature);
			byte[] array = PKCS1.I2OSP(PKCS1.RSAVP1(rsa, s), num);
			bool flag = PKCS1.Compare(PKCS1.Encode_v15(hash, hashValue, num), array);
			if (flag || !tryNonStandardEncoding)
			{
				return flag;
			}
			if (array[0] != 0 || array[1] != 1)
			{
				return false;
			}
			int i;
			for (i = 2; i < array.Length - hashValue.Length - 1; i++)
			{
				if (array[i] != 255)
				{
					return false;
				}
			}
			if (array[i++] != 0)
			{
				return false;
			}
			byte[] array2 = new byte[hashValue.Length];
			Buffer.BlockCopy(array, i, array2, 0, array2.Length);
			return PKCS1.Compare(array2, hashValue);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0000A3DC File Offset: 0x000085DC
		public static byte[] Encode_v15(HashAlgorithm hash, byte[] hashValue, int emLength)
		{
			if (hashValue.Length != hash.HashSize >> 3)
			{
				throw new CryptographicException("bad hash length for " + hash.ToString());
			}
			string text = CryptoConfig.MapNameToOID(hash.ToString());
			byte[] array;
			if (text != null)
			{
				ASN1 asn = new ASN1(48);
				asn.Add(new ASN1(CryptoConfig.EncodeOID(text)));
				asn.Add(new ASN1(5));
				ASN1 asn2 = new ASN1(4, hashValue);
				ASN1 asn3 = new ASN1(48);
				asn3.Add(asn);
				asn3.Add(asn2);
				array = asn3.GetBytes();
			}
			else
			{
				array = hashValue;
			}
			Buffer.BlockCopy(hashValue, 0, array, array.Length - hashValue.Length, hashValue.Length);
			int num = Math.Max(8, emLength - array.Length - 3);
			byte[] array2 = new byte[num + array.Length + 3];
			array2[1] = 1;
			for (int i = 2; i < num + 2; i++)
			{
				array2[i] = byte.MaxValue;
			}
			Buffer.BlockCopy(array, 0, array2, num + 3, array.Length);
			return array2;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00007F1F File Offset: 0x0000611F
		internal static HashAlgorithm CreateFromName(string name)
		{
			return HashAlgorithm.Create(name);
		}
	}
}
