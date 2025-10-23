using System;
using System.Collections;
using System.Security.Cryptography;

namespace Mono.Security.Cryptography
{
	// Token: 0x0200004C RID: 76
	public sealed class PKCS8
	{
		// Token: 0x0200004D RID: 77
		public class PrivateKeyInfo
		{
			// Token: 0x06000199 RID: 409 RVA: 0x0000ACB3 File Offset: 0x00008EB3
			public PrivateKeyInfo()
			{
				this._version = 0;
				this._list = new ArrayList();
			}

			// Token: 0x0600019A RID: 410 RVA: 0x0000ACCD File Offset: 0x00008ECD
			public PrivateKeyInfo(byte[] data) : this()
			{
				this.Decode(data);
			}

			// Token: 0x17000073 RID: 115
			// (get) Token: 0x0600019B RID: 411 RVA: 0x0000ACDC File Offset: 0x00008EDC
			// (set) Token: 0x0600019C RID: 412 RVA: 0x0000ACE4 File Offset: 0x00008EE4
			public string Algorithm
			{
				get
				{
					return this._algorithm;
				}
				set
				{
					this._algorithm = value;
				}
			}

			// Token: 0x17000074 RID: 116
			// (get) Token: 0x0600019D RID: 413 RVA: 0x0000ACED File Offset: 0x00008EED
			// (set) Token: 0x0600019E RID: 414 RVA: 0x0000AD09 File Offset: 0x00008F09
			public byte[] PrivateKey
			{
				get
				{
					if (this._key == null)
					{
						return null;
					}
					return (byte[])this._key.Clone();
				}
				set
				{
					if (value == null)
					{
						throw new ArgumentNullException("PrivateKey");
					}
					this._key = (byte[])value.Clone();
				}
			}

			// Token: 0x0600019F RID: 415 RVA: 0x0000AD2C File Offset: 0x00008F2C
			private void Decode(byte[] data)
			{
				ASN1 asn = new ASN1(data);
				if (asn.Tag != 48)
				{
					throw new CryptographicException("invalid PrivateKeyInfo");
				}
				ASN1 asn2 = asn[0];
				if (asn2.Tag != 2)
				{
					throw new CryptographicException("invalid version");
				}
				this._version = (int)asn2.Value[0];
				ASN1 asn3 = asn[1];
				if (asn3.Tag != 48)
				{
					throw new CryptographicException("invalid algorithm");
				}
				ASN1 asn4 = asn3[0];
				if (asn4.Tag != 6)
				{
					throw new CryptographicException("missing algorithm OID");
				}
				this._algorithm = ASN1Convert.ToOid(asn4);
				ASN1 asn5 = asn[2];
				this._key = asn5.Value;
				if (asn.Count > 3)
				{
					ASN1 asn6 = asn[3];
					for (int i = 0; i < asn6.Count; i++)
					{
						this._list.Add(asn6[i]);
					}
				}
			}

			// Token: 0x060001A0 RID: 416 RVA: 0x0000AE14 File Offset: 0x00009014
			public byte[] GetBytes()
			{
				ASN1 asn = new ASN1(48);
				asn.Add(ASN1Convert.FromOid(this._algorithm));
				asn.Add(new ASN1(5));
				ASN1 asn2 = new ASN1(48);
				asn2.Add(new ASN1(2, new byte[]
				{
					(byte)this._version
				}));
				asn2.Add(asn);
				asn2.Add(new ASN1(4, this._key));
				if (this._list.Count > 0)
				{
					ASN1 asn3 = new ASN1(160);
					foreach (object obj in this._list)
					{
						ASN1 asn4 = (ASN1)obj;
						asn3.Add(asn4);
					}
					asn2.Add(asn3);
				}
				return asn2.GetBytes();
			}

			// Token: 0x060001A1 RID: 417 RVA: 0x0000AF04 File Offset: 0x00009104
			private static byte[] RemoveLeadingZero(byte[] bigInt)
			{
				int srcOffset = 0;
				int num = bigInt.Length;
				if (bigInt[0] == 0)
				{
					srcOffset = 1;
					num--;
				}
				byte[] array = new byte[num];
				Buffer.BlockCopy(bigInt, srcOffset, array, 0, num);
				return array;
			}

			// Token: 0x060001A2 RID: 418 RVA: 0x0000AF34 File Offset: 0x00009134
			private static byte[] Normalize(byte[] bigInt, int length)
			{
				if (bigInt.Length == length)
				{
					return bigInt;
				}
				if (bigInt.Length > length)
				{
					return PKCS8.PrivateKeyInfo.RemoveLeadingZero(bigInt);
				}
				byte[] array = new byte[length];
				Buffer.BlockCopy(bigInt, 0, array, length - bigInt.Length, bigInt.Length);
				return array;
			}

			// Token: 0x060001A3 RID: 419 RVA: 0x0000AF70 File Offset: 0x00009170
			public static RSA DecodeRSA(byte[] keypair)
			{
				ASN1 asn = new ASN1(keypair);
				if (asn.Tag != 48)
				{
					throw new CryptographicException("invalid private key format");
				}
				if (asn[0].Tag != 2)
				{
					throw new CryptographicException("missing version");
				}
				if (asn.Count < 9)
				{
					throw new CryptographicException("not enough key parameters");
				}
				RSAParameters rsaparameters = new RSAParameters
				{
					Modulus = PKCS8.PrivateKeyInfo.RemoveLeadingZero(asn[1].Value)
				};
				int num = rsaparameters.Modulus.Length;
				int length = num >> 1;
				rsaparameters.D = PKCS8.PrivateKeyInfo.Normalize(asn[3].Value, num);
				rsaparameters.DP = PKCS8.PrivateKeyInfo.Normalize(asn[6].Value, length);
				rsaparameters.DQ = PKCS8.PrivateKeyInfo.Normalize(asn[7].Value, length);
				rsaparameters.Exponent = PKCS8.PrivateKeyInfo.RemoveLeadingZero(asn[2].Value);
				rsaparameters.InverseQ = PKCS8.PrivateKeyInfo.Normalize(asn[8].Value, length);
				rsaparameters.P = PKCS8.PrivateKeyInfo.Normalize(asn[4].Value, length);
				rsaparameters.Q = PKCS8.PrivateKeyInfo.Normalize(asn[5].Value, length);
				RSA rsa = null;
				try
				{
					rsa = RSA.Create();
					rsa.ImportParameters(rsaparameters);
				}
				catch (CryptographicException)
				{
					rsa = new RSACryptoServiceProvider(new CspParameters
					{
						Flags = CspProviderFlags.UseMachineKeyStore
					});
					rsa.ImportParameters(rsaparameters);
				}
				return rsa;
			}

			// Token: 0x060001A4 RID: 420 RVA: 0x0000B0E8 File Offset: 0x000092E8
			public static byte[] Encode(RSA rsa)
			{
				RSAParameters rsaparameters = rsa.ExportParameters(true);
				ASN1 asn = new ASN1(48);
				asn.Add(new ASN1(2, new byte[1]));
				asn.Add(ASN1Convert.FromUnsignedBigInteger(rsaparameters.Modulus));
				asn.Add(ASN1Convert.FromUnsignedBigInteger(rsaparameters.Exponent));
				asn.Add(ASN1Convert.FromUnsignedBigInteger(rsaparameters.D));
				asn.Add(ASN1Convert.FromUnsignedBigInteger(rsaparameters.P));
				asn.Add(ASN1Convert.FromUnsignedBigInteger(rsaparameters.Q));
				asn.Add(ASN1Convert.FromUnsignedBigInteger(rsaparameters.DP));
				asn.Add(ASN1Convert.FromUnsignedBigInteger(rsaparameters.DQ));
				asn.Add(ASN1Convert.FromUnsignedBigInteger(rsaparameters.InverseQ));
				return asn.GetBytes();
			}

			// Token: 0x060001A5 RID: 421 RVA: 0x0000B1B0 File Offset: 0x000093B0
			public static DSA DecodeDSA(byte[] privateKey, DSAParameters dsaParameters)
			{
				ASN1 asn = new ASN1(privateKey);
				if (asn.Tag != 2)
				{
					throw new CryptographicException("invalid private key format");
				}
				dsaParameters.X = PKCS8.PrivateKeyInfo.Normalize(asn.Value, 20);
				DSA dsa = DSA.Create();
				dsa.ImportParameters(dsaParameters);
				return dsa;
			}

			// Token: 0x060001A6 RID: 422 RVA: 0x0000B1F8 File Offset: 0x000093F8
			public static byte[] Encode(DSA dsa)
			{
				return ASN1Convert.FromUnsignedBigInteger(dsa.ExportParameters(true).X).GetBytes();
			}

			// Token: 0x04000210 RID: 528
			private int _version;

			// Token: 0x04000211 RID: 529
			private string _algorithm;

			// Token: 0x04000212 RID: 530
			private byte[] _key;

			// Token: 0x04000213 RID: 531
			private ArrayList _list;
		}

		// Token: 0x0200004E RID: 78
		public class EncryptedPrivateKeyInfo
		{
			// Token: 0x060001A7 RID: 423 RVA: 0x0000531D File Offset: 0x0000351D
			public EncryptedPrivateKeyInfo()
			{
			}

			// Token: 0x060001A8 RID: 424 RVA: 0x0000B210 File Offset: 0x00009410
			public EncryptedPrivateKeyInfo(byte[] data) : this()
			{
				this.Decode(data);
			}

			// Token: 0x17000075 RID: 117
			// (get) Token: 0x060001A9 RID: 425 RVA: 0x0000B21F File Offset: 0x0000941F
			// (set) Token: 0x060001AA RID: 426 RVA: 0x0000B227 File Offset: 0x00009427
			public string Algorithm
			{
				get
				{
					return this._algorithm;
				}
				set
				{
					this._algorithm = value;
				}
			}

			// Token: 0x17000076 RID: 118
			// (get) Token: 0x060001AB RID: 427 RVA: 0x0000B230 File Offset: 0x00009430
			// (set) Token: 0x060001AC RID: 428 RVA: 0x0000B24C File Offset: 0x0000944C
			public byte[] EncryptedData
			{
				get
				{
					if (this._data != null)
					{
						return (byte[])this._data.Clone();
					}
					return null;
				}
				set
				{
					this._data = ((value == null) ? null : ((byte[])value.Clone()));
				}
			}

			// Token: 0x17000077 RID: 119
			// (get) Token: 0x060001AD RID: 429 RVA: 0x0000B265 File Offset: 0x00009465
			public byte[] Salt
			{
				get
				{
					if (this._salt == null)
					{
						RandomNumberGenerator randomNumberGenerator = RandomNumberGenerator.Create();
						this._salt = new byte[8];
						randomNumberGenerator.GetBytes(this._salt);
					}
					return (byte[])this._salt.Clone();
				}
			}

			// Token: 0x17000078 RID: 120
			// (get) Token: 0x060001AE RID: 430 RVA: 0x0000B29B File Offset: 0x0000949B
			// (set) Token: 0x060001AF RID: 431 RVA: 0x0000B2A3 File Offset: 0x000094A3
			public int IterationCount
			{
				get
				{
					return this._iterations;
				}
				set
				{
					if (value < 0)
					{
						throw new ArgumentOutOfRangeException("IterationCount", "Negative");
					}
					this._iterations = value;
				}
			}

			// Token: 0x060001B0 RID: 432 RVA: 0x0000B2C0 File Offset: 0x000094C0
			private void Decode(byte[] data)
			{
				ASN1 asn = new ASN1(data);
				if (asn.Tag != 48)
				{
					throw new CryptographicException("invalid EncryptedPrivateKeyInfo");
				}
				ASN1 asn2 = asn[0];
				if (asn2.Tag != 48)
				{
					throw new CryptographicException("invalid encryptionAlgorithm");
				}
				ASN1 asn3 = asn2[0];
				if (asn3.Tag != 6)
				{
					throw new CryptographicException("invalid algorithm");
				}
				this._algorithm = ASN1Convert.ToOid(asn3);
				if (asn2.Count > 1)
				{
					ASN1 asn4 = asn2[1];
					if (asn4.Tag != 48)
					{
						throw new CryptographicException("invalid parameters");
					}
					ASN1 asn5 = asn4[0];
					if (asn5.Tag != 4)
					{
						throw new CryptographicException("invalid salt");
					}
					this._salt = asn5.Value;
					ASN1 asn6 = asn4[1];
					if (asn6.Tag != 2)
					{
						throw new CryptographicException("invalid iterationCount");
					}
					this._iterations = ASN1Convert.ToInt32(asn6);
				}
				ASN1 asn7 = asn[1];
				if (asn7.Tag != 4)
				{
					throw new CryptographicException("invalid EncryptedData");
				}
				this._data = asn7.Value;
			}

			// Token: 0x060001B1 RID: 433 RVA: 0x0000B3CC File Offset: 0x000095CC
			public byte[] GetBytes()
			{
				if (this._algorithm == null)
				{
					throw new CryptographicException("No algorithm OID specified");
				}
				ASN1 asn = new ASN1(48);
				asn.Add(ASN1Convert.FromOid(this._algorithm));
				if (this._iterations > 0 || this._salt != null)
				{
					ASN1 asn2 = new ASN1(4, this._salt);
					ASN1 asn3 = ASN1Convert.FromInt32(this._iterations);
					ASN1 asn4 = new ASN1(48);
					asn4.Add(asn2);
					asn4.Add(asn3);
					asn.Add(asn4);
				}
				ASN1 asn5 = new ASN1(4, this._data);
				ASN1 asn6 = new ASN1(48);
				asn6.Add(asn);
				asn6.Add(asn5);
				return asn6.GetBytes();
			}

			// Token: 0x04000214 RID: 532
			private string _algorithm;

			// Token: 0x04000215 RID: 533
			private byte[] _salt;

			// Token: 0x04000216 RID: 534
			private int _iterations;

			// Token: 0x04000217 RID: 535
			private byte[] _data;
		}
	}
}
