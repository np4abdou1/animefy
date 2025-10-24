using System;
using System.Security.Cryptography;

namespace Mono.Security.Cryptography
{
	// Token: 0x0200004B RID: 75
	public sealed class PKCS1
	{
		// Token: 0x06000190 RID: 400 RVA: 0x0000A8C8 File Offset: 0x00008AC8
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

		// Token: 0x06000191 RID: 401 RVA: 0x0000A8FC File Offset: 0x00008AFC
		public static byte[] I2OSP(byte[] x, int size)
		{
			byte[] array = new byte[size];
			Buffer.BlockCopy(x, 0, array, array.Length - x.Length, x.Length);
			return array;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0000A924 File Offset: 0x00008B24
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

		// Token: 0x06000193 RID: 403 RVA: 0x0000A964 File Offset: 0x00008B64
		public static byte[] RSAVP1(RSA rsa, byte[] s)
		{
			return rsa.EncryptValue(s);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0000A970 File Offset: 0x00008B70
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

		// Token: 0x06000195 RID: 405 RVA: 0x0000AA14 File Offset: 0x00008C14
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

		// Token: 0x06000196 RID: 406 RVA: 0x0000AB08 File Offset: 0x00008D08
		internal static string HashNameFromOid(string oid, bool throwOnError = true)
		{
			uint num = <PrivateImplementationDetails>.ComputeStringHash(oid);
			if (num <= 719034781U)
			{
				if (num <= 601591448U)
				{
					if (num != 510574318U)
					{
						if (num != 601591448U)
						{
							goto IL_173;
						}
						if (!(oid == "1.2.840.113549.1.1.5"))
						{
							goto IL_173;
						}
					}
					else if (!(oid == "1.2.840.10040.4.3"))
					{
						goto IL_173;
					}
				}
				else if (num != 618369067U)
				{
					if (num != 702257162U)
					{
						if (num != 719034781U)
						{
							goto IL_173;
						}
						if (!(oid == "1.2.840.113549.1.1.2"))
						{
							goto IL_173;
						}
						return "MD2";
					}
					else
					{
						if (!(oid == "1.2.840.113549.1.1.3"))
						{
							goto IL_173;
						}
						return "MD4";
					}
				}
				else
				{
					if (!(oid == "1.2.840.113549.1.1.4"))
					{
						goto IL_173;
					}
					return "MD5";
				}
			}
			else if (num <= 2477476687U)
			{
				if (num != 875536856U)
				{
					if (num != 2477476687U)
					{
						goto IL_173;
					}
					if (!(oid == "1.2.840.113549.1.1.11"))
					{
						goto IL_173;
					}
					return "SHA256";
				}
				else if (!(oid == "1.3.14.3.2.29"))
				{
					goto IL_173;
				}
			}
			else if (num != 2494254306U)
			{
				if (num != 2511031925U)
				{
					if (num != 3493391575U)
					{
						goto IL_173;
					}
					if (!(oid == "1.3.36.3.3.1.2"))
					{
						goto IL_173;
					}
					return "RIPEMD160";
				}
				else
				{
					if (!(oid == "1.2.840.113549.1.1.13"))
					{
						goto IL_173;
					}
					return "SHA512";
				}
			}
			else
			{
				if (!(oid == "1.2.840.113549.1.1.12"))
				{
					goto IL_173;
				}
				return "SHA384";
			}
			return "SHA1";
			IL_173:
			if (throwOnError)
			{
				throw new CryptographicException("Unsupported hash algorithm: " + oid);
			}
			return null;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0000AC9D File Offset: 0x00008E9D
		internal static HashAlgorithm CreateFromOid(string oid)
		{
			return PKCS1.CreateFromName(PKCS1.HashNameFromOid(oid, true));
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0000ACAB File Offset: 0x00008EAB
		internal static HashAlgorithm CreateFromName(string name)
		{
			return HashAlgorithm.Create(name);
		}
	}
}
