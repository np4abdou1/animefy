using System;
using System.Collections;
using System.Security.Cryptography;
using System.Text;
using Mono.Security.Cryptography;

namespace Mono.Security.X509
{
	// Token: 0x0200000C RID: 12
	public class PKCS12 : ICloneable
	{
		// Token: 0x06000044 RID: 68 RVA: 0x00003314 File Offset: 0x00001514
		public PKCS12()
		{
			this._iterations = 2000;
			this._keyBags = new ArrayList();
			this._secretBags = new ArrayList();
			this._certs = new X509CertificateCollection();
			this._keyBagsChanged = false;
			this._secretBagsChanged = false;
			this._certsChanged = false;
			this._safeBags = new ArrayList();
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00003373 File Offset: 0x00001573
		public PKCS12(byte[] data) : this()
		{
			this.Password = null;
			this.Decode(data);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00003389 File Offset: 0x00001589
		public PKCS12(byte[] data, string password) : this()
		{
			this.Password = password;
			this.Decode(data);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000033A0 File Offset: 0x000015A0
		private void Decode(byte[] data)
		{
			ASN1 asn = new ASN1(data);
			if (asn.Tag != 48)
			{
				throw new ArgumentException("invalid data");
			}
			if (asn[0].Tag != 2)
			{
				throw new ArgumentException("invalid PFX version");
			}
			PKCS7.ContentInfo contentInfo = new PKCS7.ContentInfo(asn[1]);
			if (contentInfo.ContentType != "1.2.840.113549.1.7.1")
			{
				throw new ArgumentException("invalid authenticated safe");
			}
			if (asn.Count > 2)
			{
				ASN1 asn2 = asn[2];
				if (asn2.Tag != 48)
				{
					throw new ArgumentException("invalid MAC");
				}
				ASN1 asn3 = asn2[0];
				if (asn3.Tag != 48)
				{
					throw new ArgumentException("invalid MAC");
				}
				if (ASN1Convert.ToOid(asn3[0][0]) != "1.3.14.3.2.26")
				{
					throw new ArgumentException("unsupported HMAC");
				}
				byte[] value = asn3[1].Value;
				ASN1 asn4 = asn2[1];
				if (asn4.Tag != 4)
				{
					throw new ArgumentException("missing MAC salt");
				}
				this._iterations = 1;
				if (asn2.Count > 2)
				{
					ASN1 asn5 = asn2[2];
					if (asn5.Tag != 2)
					{
						throw new ArgumentException("invalid MAC iteration");
					}
					this._iterations = ASN1Convert.ToInt32(asn5);
				}
				byte[] value2 = contentInfo.Content[0].Value;
				byte[] actual = this.MAC(this._password, asn4.Value, this._iterations, value2);
				if (!this.Compare(value, actual))
				{
					byte[] password = new byte[2];
					actual = this.MAC(password, asn4.Value, this._iterations, value2);
					if (!this.Compare(value, actual))
					{
						throw new CryptographicException("Invalid MAC - file may have been tampered with!");
					}
					this._password = password;
				}
			}
			ASN1 asn6 = new ASN1(contentInfo.Content[0].Value);
			for (int i = 0; i < asn6.Count; i++)
			{
				PKCS7.ContentInfo contentInfo2 = new PKCS7.ContentInfo(asn6[i]);
				string contentType = contentInfo2.ContentType;
				if (!(contentType == "1.2.840.113549.1.7.1"))
				{
					if (!(contentType == "1.2.840.113549.1.7.6"))
					{
						if (!(contentType == "1.2.840.113549.1.7.3"))
						{
							throw new ArgumentException("unknown authenticatedSafe");
						}
						throw new NotImplementedException("public key encrypted");
					}
					else
					{
						PKCS7.EncryptedData ed = new PKCS7.EncryptedData(contentInfo2.Content[0]);
						ASN1 asn7 = new ASN1(this.Decrypt(ed));
						for (int j = 0; j < asn7.Count; j++)
						{
							ASN1 safeBag = asn7[j];
							this.ReadSafeBag(safeBag);
						}
					}
				}
				else
				{
					ASN1 asn8 = new ASN1(contentInfo2.Content[0].Value);
					for (int k = 0; k < asn8.Count; k++)
					{
						ASN1 safeBag2 = asn8[k];
						this.ReadSafeBag(safeBag2);
					}
				}
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00003684 File Offset: 0x00001884
		~PKCS12()
		{
			if (this._password != null)
			{
				Array.Clear(this._password, 0, this._password.Length);
			}
			this._password = null;
		}

		// Token: 0x17000018 RID: 24
		// (set) Token: 0x06000049 RID: 73 RVA: 0x000036D0 File Offset: 0x000018D0
		public string Password
		{
			set
			{
				if (this._password != null)
				{
					Array.Clear(this._password, 0, this._password.Length);
				}
				this._password = null;
				if (value != null)
				{
					if (value.Length > 0)
					{
						int num = value.Length;
						int num2 = 0;
						if (num < PKCS12.MaximumPasswordLength)
						{
							if (value[num - 1] != '\0')
							{
								num2 = 1;
							}
						}
						else
						{
							num = PKCS12.MaximumPasswordLength;
						}
						this._password = new byte[num + num2 << 1];
						Encoding.BigEndianUnicode.GetBytes(value, 0, num, this._password, 0);
						return;
					}
					this._password = new byte[2];
				}
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00003764 File Offset: 0x00001964
		// (set) Token: 0x0600004B RID: 75 RVA: 0x0000376C File Offset: 0x0000196C
		public int IterationCount
		{
			get
			{
				return this._iterations;
			}
			set
			{
				this._iterations = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00003778 File Offset: 0x00001978
		public ArrayList Keys
		{
			get
			{
				if (this._keyBagsChanged)
				{
					this._keyBags.Clear();
					foreach (object obj in this._safeBags)
					{
						SafeBag safeBag = (SafeBag)obj;
						if (safeBag.BagOID.Equals("1.2.840.113549.1.12.10.1.1"))
						{
							byte[] privateKey = new PKCS8.PrivateKeyInfo(safeBag.ASN1[1].Value).PrivateKey;
							byte b = privateKey[0];
							if (b != 2)
							{
								if (b == 48)
								{
									this._keyBags.Add(PKCS8.PrivateKeyInfo.DecodeRSA(privateKey));
								}
							}
							else
							{
								DSAParameters dsaParameters = default(DSAParameters);
								this._keyBags.Add(PKCS8.PrivateKeyInfo.DecodeDSA(privateKey, dsaParameters));
							}
							Array.Clear(privateKey, 0, privateKey.Length);
						}
						else if (safeBag.BagOID.Equals("1.2.840.113549.1.12.10.1.2"))
						{
							PKCS8.EncryptedPrivateKeyInfo encryptedPrivateKeyInfo = new PKCS8.EncryptedPrivateKeyInfo(safeBag.ASN1[1].Value);
							byte[] array = this.Decrypt(encryptedPrivateKeyInfo.Algorithm, encryptedPrivateKeyInfo.Salt, encryptedPrivateKeyInfo.IterationCount, encryptedPrivateKeyInfo.EncryptedData);
							byte[] privateKey2 = new PKCS8.PrivateKeyInfo(array).PrivateKey;
							byte b = privateKey2[0];
							if (b != 2)
							{
								if (b == 48)
								{
									this._keyBags.Add(PKCS8.PrivateKeyInfo.DecodeRSA(privateKey2));
								}
							}
							else
							{
								DSAParameters dsaParameters2 = default(DSAParameters);
								this._keyBags.Add(PKCS8.PrivateKeyInfo.DecodeDSA(privateKey2, dsaParameters2));
							}
							Array.Clear(privateKey2, 0, privateKey2.Length);
							Array.Clear(array, 0, array.Length);
						}
					}
					this._keyBagsChanged = false;
				}
				return ArrayList.ReadOnly(this._keyBags);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00003944 File Offset: 0x00001B44
		public X509CertificateCollection Certificates
		{
			get
			{
				if (this._certsChanged)
				{
					this._certs.Clear();
					foreach (object obj in this._safeBags)
					{
						SafeBag safeBag = (SafeBag)obj;
						if (safeBag.BagOID.Equals("1.2.840.113549.1.12.10.1.3"))
						{
							PKCS7.ContentInfo contentInfo = new PKCS7.ContentInfo(safeBag.ASN1[1].Value);
							this._certs.Add(new X509Certificate(contentInfo.Content[0].Value));
						}
					}
					this._certsChanged = false;
				}
				return this._certs;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00003A04 File Offset: 0x00001C04
		internal RandomNumberGenerator RNG
		{
			get
			{
				if (this._rng == null)
				{
					this._rng = RandomNumberGenerator.Create();
				}
				return this._rng;
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00003A20 File Offset: 0x00001C20
		private bool Compare(byte[] expected, byte[] actual)
		{
			bool result = false;
			if (expected.Length == actual.Length)
			{
				for (int i = 0; i < expected.Length; i++)
				{
					if (expected[i] != actual[i])
					{
						return false;
					}
				}
				result = true;
			}
			return result;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00003A54 File Offset: 0x00001C54
		private SymmetricAlgorithm GetSymmetricAlgorithm(string algorithmOid, byte[] salt, int iterationCount)
		{
			string text = null;
			int size = 8;
			int num = 8;
			PKCS12.DeriveBytes deriveBytes = new PKCS12.DeriveBytes();
			deriveBytes.Password = this._password;
			deriveBytes.Salt = salt;
			deriveBytes.IterationCount = iterationCount;
			uint num2 = <PrivateImplementationDetails>.ComputeStringHash(algorithmOid);
			if (num2 <= 2949822700U)
			{
				if (num2 <= 2882712224U)
				{
					if (num2 != 1314512600U)
					{
						if (num2 != 1331290219U)
						{
							if (num2 == 2882712224U)
							{
								if (algorithmOid == "1.2.840.113549.1.12.1.6")
								{
									deriveBytes.HashName = "SHA1";
									text = "RC2";
									size = 5;
									goto IL_2FE;
								}
							}
						}
						else if (algorithmOid == "1.2.840.113549.1.5.11")
						{
							deriveBytes.HashName = "SHA1";
							text = "RC2";
							size = 4;
							goto IL_2FE;
						}
					}
					else if (algorithmOid == "1.2.840.113549.1.5.10")
					{
						deriveBytes.HashName = "SHA1";
						text = "DES";
						goto IL_2FE;
					}
				}
				else if (num2 != 2916267462U)
				{
					if (num2 != 2933045081U)
					{
						if (num2 == 2949822700U)
						{
							if (algorithmOid == "1.2.840.113549.1.12.1.2")
							{
								deriveBytes.HashName = "SHA1";
								text = "RC4";
								size = 5;
								num = 0;
								goto IL_2FE;
							}
						}
					}
					else if (algorithmOid == "1.2.840.113549.1.12.1.5")
					{
						deriveBytes.HashName = "SHA1";
						text = "RC2";
						size = 16;
						goto IL_2FE;
					}
				}
				else if (algorithmOid == "1.2.840.113549.1.12.1.4")
				{
					deriveBytes.HashName = "SHA1";
					text = "TripleDES";
					size = 16;
					goto IL_2FE;
				}
			}
			else if (num2 <= 3543878904U)
			{
				if (num2 != 2966600319U)
				{
					if (num2 != 3000155557U)
					{
						if (num2 == 3543878904U)
						{
							if (algorithmOid == "1.2.840.113549.1.5.1")
							{
								deriveBytes.HashName = "MD2";
								text = "DES";
								goto IL_2FE;
							}
						}
					}
					else if (algorithmOid == "1.2.840.113549.1.12.1.1")
					{
						deriveBytes.HashName = "SHA1";
						text = "RC4";
						size = 16;
						num = 0;
						goto IL_2FE;
					}
				}
				else if (algorithmOid == "1.2.840.113549.1.12.1.3")
				{
					deriveBytes.HashName = "SHA1";
					text = "TripleDES";
					size = 24;
					goto IL_2FE;
				}
			}
			else if (num2 != 3577434142U)
			{
				if (num2 != 3627766999U)
				{
					if (num2 == 3661322237U)
					{
						if (algorithmOid == "1.2.840.113549.1.5.6")
						{
							deriveBytes.HashName = "MD5";
							text = "RC2";
							size = 4;
							goto IL_2FE;
						}
					}
				}
				else if (algorithmOid == "1.2.840.113549.1.5.4")
				{
					deriveBytes.HashName = "MD2";
					text = "RC2";
					size = 4;
					goto IL_2FE;
				}
			}
			else if (algorithmOid == "1.2.840.113549.1.5.3")
			{
				deriveBytes.HashName = "MD5";
				text = "DES";
				goto IL_2FE;
			}
			throw new NotSupportedException("unknown oid " + text);
			IL_2FE:
			SymmetricAlgorithm symmetricAlgorithm = SymmetricAlgorithm.Create(text);
			symmetricAlgorithm.Key = deriveBytes.DeriveKey(size);
			if (num > 0)
			{
				symmetricAlgorithm.IV = deriveBytes.DeriveIV(num);
				symmetricAlgorithm.Mode = CipherMode.CBC;
			}
			return symmetricAlgorithm;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00003D94 File Offset: 0x00001F94
		public byte[] Decrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] encryptedData)
		{
			SymmetricAlgorithm symmetricAlgorithm = null;
			byte[] result = null;
			try
			{
				symmetricAlgorithm = this.GetSymmetricAlgorithm(algorithmOid, salt, iterationCount);
				result = symmetricAlgorithm.CreateDecryptor().TransformFinalBlock(encryptedData, 0, encryptedData.Length);
			}
			finally
			{
				if (symmetricAlgorithm != null)
				{
					symmetricAlgorithm.Clear();
				}
			}
			return result;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00003DE0 File Offset: 0x00001FE0
		public byte[] Decrypt(PKCS7.EncryptedData ed)
		{
			return this.Decrypt(ed.EncryptionAlgorithm.ContentType, ed.EncryptionAlgorithm.Content[0].Value, ASN1Convert.ToInt32(ed.EncryptionAlgorithm.Content[1]), ed.EncryptedContent);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00003E30 File Offset: 0x00002030
		public byte[] Encrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] data)
		{
			byte[] result = null;
			using (SymmetricAlgorithm symmetricAlgorithm = this.GetSymmetricAlgorithm(algorithmOid, salt, iterationCount))
			{
				result = symmetricAlgorithm.CreateEncryptor().TransformFinalBlock(data, 0, data.Length);
			}
			return result;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00003E7C File Offset: 0x0000207C
		private DSAParameters GetExistingParameters(out bool found)
		{
			foreach (X509Certificate x509Certificate in this.Certificates)
			{
				if (x509Certificate.KeyAlgorithmParameters != null)
				{
					DSA dsa = x509Certificate.DSA;
					if (dsa != null)
					{
						found = true;
						return dsa.ExportParameters(false);
					}
				}
			}
			found = false;
			return default(DSAParameters);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00003EFC File Offset: 0x000020FC
		private void AddPrivateKey(PKCS8.PrivateKeyInfo pki)
		{
			byte[] privateKey = pki.PrivateKey;
			try
			{
				string algorithm = pki.Algorithm;
				if (!(algorithm == "1.2.840.113549.1.1.1"))
				{
					if (!(algorithm == "1.2.840.10040.4.1"))
					{
						if (!(algorithm == "1.2.840.10045.2.1"))
						{
						}
						throw new CryptographicException("Unknown private key format");
					}
					bool flag;
					DSAParameters existingParameters = this.GetExistingParameters(out flag);
					if (flag)
					{
						this._keyBags.Add(PKCS8.PrivateKeyInfo.DecodeDSA(privateKey, existingParameters));
					}
				}
				else
				{
					this._keyBags.Add(PKCS8.PrivateKeyInfo.DecodeRSA(privateKey));
				}
			}
			finally
			{
				Array.Clear(privateKey, 0, privateKey.Length);
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00003FA0 File Offset: 0x000021A0
		private void ReadSafeBag(ASN1 safeBag)
		{
			if (safeBag.Tag != 48)
			{
				throw new ArgumentException("invalid safeBag");
			}
			ASN1 asn = safeBag[0];
			if (asn.Tag != 6)
			{
				throw new ArgumentException("invalid safeBag id");
			}
			ASN1 asn2 = safeBag[1];
			string text = ASN1Convert.ToOid(asn);
			if (!(text == "1.2.840.113549.1.12.10.1.1"))
			{
				if (!(text == "1.2.840.113549.1.12.10.1.2"))
				{
					if (!(text == "1.2.840.113549.1.12.10.1.3"))
					{
						if (!(text == "1.2.840.113549.1.12.10.1.4"))
						{
							if (!(text == "1.2.840.113549.1.12.10.1.5"))
							{
								if (!(text == "1.2.840.113549.1.12.10.1.6"))
								{
									throw new ArgumentException("unknown safeBag oid");
								}
							}
							else
							{
								byte[] value = asn2.Value;
								this._secretBags.Add(value);
							}
						}
					}
					else
					{
						PKCS7.ContentInfo contentInfo = new PKCS7.ContentInfo(asn2.Value);
						if (contentInfo.ContentType != "1.2.840.113549.1.9.22.1")
						{
							throw new NotSupportedException("unsupport certificate type");
						}
						X509Certificate value2 = new X509Certificate(contentInfo.Content[0].Value);
						this._certs.Add(value2);
					}
				}
				else
				{
					PKCS8.EncryptedPrivateKeyInfo encryptedPrivateKeyInfo = new PKCS8.EncryptedPrivateKeyInfo(asn2.Value);
					byte[] array = this.Decrypt(encryptedPrivateKeyInfo.Algorithm, encryptedPrivateKeyInfo.Salt, encryptedPrivateKeyInfo.IterationCount, encryptedPrivateKeyInfo.EncryptedData);
					this.AddPrivateKey(new PKCS8.PrivateKeyInfo(array));
					Array.Clear(array, 0, array.Length);
				}
			}
			else
			{
				this.AddPrivateKey(new PKCS8.PrivateKeyInfo(asn2.Value));
			}
			if (safeBag.Count > 2)
			{
				ASN1 asn3 = safeBag[2];
				if (asn3.Tag != 49)
				{
					throw new ArgumentException("invalid safeBag attributes id");
				}
				for (int i = 0; i < asn3.Count; i++)
				{
					ASN1 asn4 = asn3[i];
					if (asn4.Tag != 48)
					{
						throw new ArgumentException("invalid PKCS12 attributes id");
					}
					ASN1 asn5 = asn4[0];
					if (asn5.Tag != 6)
					{
						throw new ArgumentException("invalid attribute id");
					}
					string a = ASN1Convert.ToOid(asn5);
					ASN1 asn6 = asn4[1];
					for (int j = 0; j < asn6.Count; j++)
					{
						ASN1 asn7 = asn6[j];
						if (!(a == "1.2.840.113549.1.9.20"))
						{
							if (a == "1.2.840.113549.1.9.21")
							{
								if (asn7.Tag != 4)
								{
									throw new ArgumentException("invalid attribute value id");
								}
							}
						}
						else if (asn7.Tag != 30)
						{
							throw new ArgumentException("invalid attribute value id");
						}
					}
				}
			}
			this._safeBags.Add(new SafeBag(text, safeBag));
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00004224 File Offset: 0x00002424
		private ASN1 Pkcs8ShroudedKeyBagSafeBag(AsymmetricAlgorithm aa, IDictionary attributes)
		{
			PKCS8.PrivateKeyInfo privateKeyInfo = new PKCS8.PrivateKeyInfo();
			if (aa is RSA)
			{
				privateKeyInfo.Algorithm = "1.2.840.113549.1.1.1";
				privateKeyInfo.PrivateKey = PKCS8.PrivateKeyInfo.Encode((RSA)aa);
			}
			else
			{
				if (!(aa is DSA))
				{
					throw new CryptographicException("Unknown asymmetric algorithm {0}", aa.ToString());
				}
				privateKeyInfo.Algorithm = null;
				privateKeyInfo.PrivateKey = PKCS8.PrivateKeyInfo.Encode((DSA)aa);
			}
			PKCS8.EncryptedPrivateKeyInfo encryptedPrivateKeyInfo = new PKCS8.EncryptedPrivateKeyInfo();
			encryptedPrivateKeyInfo.Algorithm = "1.2.840.113549.1.12.1.3";
			encryptedPrivateKeyInfo.IterationCount = this._iterations;
			encryptedPrivateKeyInfo.EncryptedData = this.Encrypt("1.2.840.113549.1.12.1.3", encryptedPrivateKeyInfo.Salt, this._iterations, privateKeyInfo.GetBytes());
			ASN1 asn = new ASN1(48);
			asn.Add(ASN1Convert.FromOid("1.2.840.113549.1.12.10.1.2"));
			ASN1 asn2 = new ASN1(160);
			asn2.Add(new ASN1(encryptedPrivateKeyInfo.GetBytes()));
			asn.Add(asn2);
			if (attributes != null)
			{
				ASN1 asn3 = new ASN1(49);
				IDictionaryEnumerator enumerator = attributes.GetEnumerator();
				while (enumerator.MoveNext())
				{
					string a = (string)enumerator.Key;
					if (!(a == "1.2.840.113549.1.9.20"))
					{
						if (a == "1.2.840.113549.1.9.21")
						{
							ArrayList arrayList = (ArrayList)enumerator.Value;
							if (arrayList.Count > 0)
							{
								ASN1 asn4 = new ASN1(48);
								asn4.Add(ASN1Convert.FromOid("1.2.840.113549.1.9.21"));
								ASN1 asn5 = new ASN1(49);
								foreach (object obj in arrayList)
								{
									byte[] value = (byte[])obj;
									asn5.Add(new ASN1(4)
									{
										Value = value
									});
								}
								asn4.Add(asn5);
								asn3.Add(asn4);
							}
						}
					}
					else
					{
						ArrayList arrayList2 = (ArrayList)enumerator.Value;
						if (arrayList2.Count > 0)
						{
							ASN1 asn6 = new ASN1(48);
							asn6.Add(ASN1Convert.FromOid("1.2.840.113549.1.9.20"));
							ASN1 asn7 = new ASN1(49);
							foreach (object obj2 in arrayList2)
							{
								byte[] value2 = (byte[])obj2;
								asn7.Add(new ASN1(30)
								{
									Value = value2
								});
							}
							asn6.Add(asn7);
							asn3.Add(asn6);
						}
					}
				}
				if (asn3.Count > 0)
				{
					asn.Add(asn3);
				}
			}
			return asn;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000044EC File Offset: 0x000026EC
		private ASN1 CertificateSafeBag(X509Certificate x509, IDictionary attributes)
		{
			ASN1 asn = new ASN1(4, x509.RawData);
			PKCS7.ContentInfo contentInfo = new PKCS7.ContentInfo();
			contentInfo.ContentType = "1.2.840.113549.1.9.22.1";
			contentInfo.Content.Add(asn);
			ASN1 asn2 = new ASN1(160);
			asn2.Add(contentInfo.ASN1);
			ASN1 asn3 = new ASN1(48);
			asn3.Add(ASN1Convert.FromOid("1.2.840.113549.1.12.10.1.3"));
			asn3.Add(asn2);
			if (attributes != null)
			{
				ASN1 asn4 = new ASN1(49);
				IDictionaryEnumerator enumerator = attributes.GetEnumerator();
				while (enumerator.MoveNext())
				{
					string a = (string)enumerator.Key;
					if (!(a == "1.2.840.113549.1.9.20"))
					{
						if (a == "1.2.840.113549.1.9.21")
						{
							ArrayList arrayList = (ArrayList)enumerator.Value;
							if (arrayList.Count > 0)
							{
								ASN1 asn5 = new ASN1(48);
								asn5.Add(ASN1Convert.FromOid("1.2.840.113549.1.9.21"));
								ASN1 asn6 = new ASN1(49);
								foreach (object obj in arrayList)
								{
									byte[] value = (byte[])obj;
									asn6.Add(new ASN1(4)
									{
										Value = value
									});
								}
								asn5.Add(asn6);
								asn4.Add(asn5);
							}
						}
					}
					else
					{
						ArrayList arrayList2 = (ArrayList)enumerator.Value;
						if (arrayList2.Count > 0)
						{
							ASN1 asn7 = new ASN1(48);
							asn7.Add(ASN1Convert.FromOid("1.2.840.113549.1.9.20"));
							ASN1 asn8 = new ASN1(49);
							foreach (object obj2 in arrayList2)
							{
								byte[] value2 = (byte[])obj2;
								asn8.Add(new ASN1(30)
								{
									Value = value2
								});
							}
							asn7.Add(asn8);
							asn4.Add(asn7);
						}
					}
				}
				if (asn4.Count > 0)
				{
					asn3.Add(asn4);
				}
			}
			return asn3;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000473C File Offset: 0x0000293C
		private byte[] MAC(byte[] password, byte[] salt, int iterations, byte[] data)
		{
			PKCS12.DeriveBytes deriveBytes = new PKCS12.DeriveBytes();
			deriveBytes.HashName = "SHA1";
			deriveBytes.Password = password;
			deriveBytes.Salt = salt;
			deriveBytes.IterationCount = iterations;
			HMACSHA1 hmacsha = (HMACSHA1)HMAC.Create();
			hmacsha.Key = deriveBytes.DeriveMAC(20);
			return hmacsha.ComputeHash(data, 0, data.Length);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00004794 File Offset: 0x00002994
		public byte[] GetBytes()
		{
			ASN1 asn = new ASN1(48);
			ArrayList arrayList = new ArrayList();
			foreach (object obj in this._safeBags)
			{
				SafeBag safeBag = (SafeBag)obj;
				if (safeBag.BagOID.Equals("1.2.840.113549.1.12.10.1.3"))
				{
					PKCS7.ContentInfo contentInfo = new PKCS7.ContentInfo(safeBag.ASN1[1].Value);
					arrayList.Add(new X509Certificate(contentInfo.Content[0].Value));
				}
			}
			ArrayList arrayList2 = new ArrayList();
			ArrayList arrayList3 = new ArrayList();
			foreach (X509Certificate x509Certificate in this.Certificates)
			{
				bool flag = false;
				foreach (object obj2 in arrayList)
				{
					X509Certificate x509Certificate2 = (X509Certificate)obj2;
					if (this.Compare(x509Certificate.RawData, x509Certificate2.RawData))
					{
						flag = true;
					}
				}
				if (!flag)
				{
					arrayList2.Add(x509Certificate);
				}
			}
			foreach (object obj3 in arrayList)
			{
				X509Certificate x509Certificate3 = (X509Certificate)obj3;
				bool flag2 = false;
				foreach (X509Certificate x509Certificate4 in this.Certificates)
				{
					if (this.Compare(x509Certificate3.RawData, x509Certificate4.RawData))
					{
						flag2 = true;
					}
				}
				if (!flag2)
				{
					arrayList3.Add(x509Certificate3);
				}
			}
			foreach (object obj4 in arrayList3)
			{
				X509Certificate cert = (X509Certificate)obj4;
				this.RemoveCertificate(cert);
			}
			foreach (object obj5 in arrayList2)
			{
				X509Certificate cert2 = (X509Certificate)obj5;
				this.AddCertificate(cert2);
			}
			if (this._safeBags.Count > 0)
			{
				ASN1 asn2 = new ASN1(48);
				foreach (object obj6 in this._safeBags)
				{
					SafeBag safeBag2 = (SafeBag)obj6;
					if (safeBag2.BagOID.Equals("1.2.840.113549.1.12.10.1.3"))
					{
						asn2.Add(safeBag2.ASN1);
					}
				}
				if (asn2.Count > 0)
				{
					PKCS7.ContentInfo contentInfo2 = this.EncryptedContentInfo(asn2, "1.2.840.113549.1.12.1.3");
					asn.Add(contentInfo2.ASN1);
				}
			}
			if (this._safeBags.Count > 0)
			{
				ASN1 asn3 = new ASN1(48);
				foreach (object obj7 in this._safeBags)
				{
					SafeBag safeBag3 = (SafeBag)obj7;
					if (safeBag3.BagOID.Equals("1.2.840.113549.1.12.10.1.1") || safeBag3.BagOID.Equals("1.2.840.113549.1.12.10.1.2"))
					{
						asn3.Add(safeBag3.ASN1);
					}
				}
				if (asn3.Count > 0)
				{
					ASN1 asn4 = new ASN1(160);
					asn4.Add(new ASN1(4, asn3.GetBytes()));
					asn.Add(new PKCS7.ContentInfo("1.2.840.113549.1.7.1")
					{
						Content = asn4
					}.ASN1);
				}
			}
			if (this._safeBags.Count > 0)
			{
				ASN1 asn5 = new ASN1(48);
				foreach (object obj8 in this._safeBags)
				{
					SafeBag safeBag4 = (SafeBag)obj8;
					if (safeBag4.BagOID.Equals("1.2.840.113549.1.12.10.1.5"))
					{
						asn5.Add(safeBag4.ASN1);
					}
				}
				if (asn5.Count > 0)
				{
					PKCS7.ContentInfo contentInfo3 = this.EncryptedContentInfo(asn5, "1.2.840.113549.1.12.1.3");
					asn.Add(contentInfo3.ASN1);
				}
			}
			ASN1 asn6 = new ASN1(4, asn.GetBytes());
			ASN1 asn7 = new ASN1(160);
			asn7.Add(asn6);
			PKCS7.ContentInfo contentInfo4 = new PKCS7.ContentInfo("1.2.840.113549.1.7.1");
			contentInfo4.Content = asn7;
			ASN1 asn8 = new ASN1(48);
			if (this._password != null)
			{
				byte[] array = new byte[20];
				this.RNG.GetBytes(array);
				byte[] data = this.MAC(this._password, array, this._iterations, contentInfo4.Content[0].Value);
				ASN1 asn9 = new ASN1(48);
				asn9.Add(ASN1Convert.FromOid("1.3.14.3.2.26"));
				asn9.Add(new ASN1(5));
				ASN1 asn10 = new ASN1(48);
				asn10.Add(asn9);
				asn10.Add(new ASN1(4, data));
				asn8.Add(asn10);
				asn8.Add(new ASN1(4, array));
				asn8.Add(ASN1Convert.FromInt32(this._iterations));
			}
			ASN1 asn11 = new ASN1(2, new byte[]
			{
				3
			});
			ASN1 asn12 = new ASN1(48);
			asn12.Add(asn11);
			asn12.Add(contentInfo4.ASN1);
			if (asn8.Count > 0)
			{
				asn12.Add(asn8);
			}
			return asn12.GetBytes();
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00004DE0 File Offset: 0x00002FE0
		private PKCS7.ContentInfo EncryptedContentInfo(ASN1 safeBags, string algorithmOid)
		{
			byte[] array = new byte[8];
			this.RNG.GetBytes(array);
			ASN1 asn = new ASN1(48);
			asn.Add(new ASN1(4, array));
			asn.Add(ASN1Convert.FromInt32(this._iterations));
			ASN1 asn2 = new ASN1(48);
			asn2.Add(ASN1Convert.FromOid(algorithmOid));
			asn2.Add(asn);
			byte[] data = this.Encrypt(algorithmOid, array, this._iterations, safeBags.GetBytes());
			ASN1 asn3 = new ASN1(128, data);
			ASN1 asn4 = new ASN1(48);
			asn4.Add(ASN1Convert.FromOid("1.2.840.113549.1.7.1"));
			asn4.Add(asn2);
			asn4.Add(asn3);
			ASN1 asn5 = new ASN1(2, new byte[1]);
			ASN1 asn6 = new ASN1(48);
			asn6.Add(asn5);
			asn6.Add(asn4);
			ASN1 asn7 = new ASN1(160);
			asn7.Add(asn6);
			return new PKCS7.ContentInfo("1.2.840.113549.1.7.6")
			{
				Content = asn7
			};
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00004EE8 File Offset: 0x000030E8
		public void AddCertificate(X509Certificate cert)
		{
			this.AddCertificate(cert, null);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00004EF4 File Offset: 0x000030F4
		public void AddCertificate(X509Certificate cert, IDictionary attributes)
		{
			bool flag = false;
			int num = 0;
			while (!flag && num < this._safeBags.Count)
			{
				SafeBag safeBag = (SafeBag)this._safeBags[num];
				if (safeBag.BagOID.Equals("1.2.840.113549.1.12.10.1.3"))
				{
					X509Certificate x509Certificate = new X509Certificate(new PKCS7.ContentInfo(safeBag.ASN1[1].Value).Content[0].Value);
					if (this.Compare(cert.RawData, x509Certificate.RawData))
					{
						flag = true;
					}
				}
				num++;
			}
			if (!flag)
			{
				this._safeBags.Add(new SafeBag("1.2.840.113549.1.12.10.1.3", this.CertificateSafeBag(cert, attributes)));
				this._certsChanged = true;
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00004FAA File Offset: 0x000031AA
		public void RemoveCertificate(X509Certificate cert)
		{
			this.RemoveCertificate(cert, null);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00004FB4 File Offset: 0x000031B4
		public void RemoveCertificate(X509Certificate cert, IDictionary attrs)
		{
			int num = -1;
			int num2 = 0;
			while (num == -1 && num2 < this._safeBags.Count)
			{
				SafeBag safeBag = (SafeBag)this._safeBags[num2];
				if (safeBag.BagOID.Equals("1.2.840.113549.1.12.10.1.3"))
				{
					ASN1 asn = safeBag.ASN1;
					X509Certificate x509Certificate = new X509Certificate(new PKCS7.ContentInfo(asn[1].Value).Content[0].Value);
					if (this.Compare(cert.RawData, x509Certificate.RawData))
					{
						if (attrs != null)
						{
							if (asn.Count == 3)
							{
								ASN1 asn2 = asn[2];
								int num3 = 0;
								for (int i = 0; i < asn2.Count; i++)
								{
									ASN1 asn3 = asn2[i];
									string key = ASN1Convert.ToOid(asn3[0]);
									ArrayList arrayList = (ArrayList)attrs[key];
									if (arrayList != null)
									{
										ASN1 asn4 = asn3[1];
										if (arrayList.Count == asn4.Count)
										{
											int num4 = 0;
											for (int j = 0; j < asn4.Count; j++)
											{
												ASN1 asn5 = asn4[j];
												byte[] expected = (byte[])arrayList[j];
												if (this.Compare(expected, asn5.Value))
												{
													num4++;
												}
											}
											if (num4 == asn4.Count)
											{
												num3++;
											}
										}
									}
								}
								if (num3 == asn2.Count)
								{
									num = num2;
								}
							}
						}
						else
						{
							num = num2;
						}
					}
				}
				num2++;
			}
			if (num != -1)
			{
				this._safeBags.RemoveAt(num);
				this._certsChanged = true;
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00005156 File Offset: 0x00003356
		private bool CompareAsymmetricAlgorithm(AsymmetricAlgorithm a1, AsymmetricAlgorithm a2)
		{
			return a1.KeySize == a2.KeySize && a1.ToXmlString(false) == a2.ToXmlString(false);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000517C File Offset: 0x0000337C
		public void AddPkcs8ShroudedKeyBag(AsymmetricAlgorithm aa, IDictionary attributes)
		{
			bool flag = false;
			int num = 0;
			while (!flag && num < this._safeBags.Count)
			{
				SafeBag safeBag = (SafeBag)this._safeBags[num];
				if (safeBag.BagOID.Equals("1.2.840.113549.1.12.10.1.2"))
				{
					PKCS8.EncryptedPrivateKeyInfo encryptedPrivateKeyInfo = new PKCS8.EncryptedPrivateKeyInfo(safeBag.ASN1[1].Value);
					byte[] array = this.Decrypt(encryptedPrivateKeyInfo.Algorithm, encryptedPrivateKeyInfo.Salt, encryptedPrivateKeyInfo.IterationCount, encryptedPrivateKeyInfo.EncryptedData);
					byte[] privateKey = new PKCS8.PrivateKeyInfo(array).PrivateKey;
					byte b = privateKey[0];
					AsymmetricAlgorithm a;
					if (b != 2)
					{
						if (b != 48)
						{
							Array.Clear(array, 0, array.Length);
							Array.Clear(privateKey, 0, privateKey.Length);
							throw new CryptographicException("Unknown private key format");
						}
						a = PKCS8.PrivateKeyInfo.DecodeRSA(privateKey);
					}
					else
					{
						a = PKCS8.PrivateKeyInfo.DecodeDSA(privateKey, default(DSAParameters));
					}
					Array.Clear(array, 0, array.Length);
					Array.Clear(privateKey, 0, privateKey.Length);
					if (this.CompareAsymmetricAlgorithm(aa, a))
					{
						flag = true;
					}
				}
				num++;
			}
			if (!flag)
			{
				this._safeBags.Add(new SafeBag("1.2.840.113549.1.12.10.1.2", this.Pkcs8ShroudedKeyBagSafeBag(aa, attributes)));
				this._keyBagsChanged = true;
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000052BC File Offset: 0x000034BC
		public object Clone()
		{
			PKCS12 pkcs;
			if (this._password != null)
			{
				pkcs = new PKCS12(this.GetBytes(), Encoding.BigEndianUnicode.GetString(this._password));
			}
			else
			{
				pkcs = new PKCS12(this.GetBytes());
			}
			pkcs.IterationCount = this.IterationCount;
			return pkcs;
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000063 RID: 99 RVA: 0x0000530A File Offset: 0x0000350A
		public static int MaximumPasswordLength
		{
			get
			{
				return PKCS12.password_max_length;
			}
		}

		// Token: 0x0400001B RID: 27
		private byte[] _password;

		// Token: 0x0400001C RID: 28
		private ArrayList _keyBags;

		// Token: 0x0400001D RID: 29
		private ArrayList _secretBags;

		// Token: 0x0400001E RID: 30
		private X509CertificateCollection _certs;

		// Token: 0x0400001F RID: 31
		private bool _keyBagsChanged;

		// Token: 0x04000020 RID: 32
		private bool _secretBagsChanged;

		// Token: 0x04000021 RID: 33
		private bool _certsChanged;

		// Token: 0x04000022 RID: 34
		private int _iterations;

		// Token: 0x04000023 RID: 35
		private ArrayList _safeBags;

		// Token: 0x04000024 RID: 36
		private RandomNumberGenerator _rng;

		// Token: 0x04000025 RID: 37
		private static int password_max_length = int.MaxValue;

		// Token: 0x0200000D RID: 13
		public class DeriveBytes
		{
			// Token: 0x1700001E RID: 30
			// (set) Token: 0x06000066 RID: 102 RVA: 0x00005325 File Offset: 0x00003525
			public string HashName
			{
				set
				{
					this._hashName = value;
				}
			}

			// Token: 0x1700001F RID: 31
			// (set) Token: 0x06000067 RID: 103 RVA: 0x0000532E File Offset: 0x0000352E
			public int IterationCount
			{
				set
				{
					this._iterations = value;
				}
			}

			// Token: 0x17000020 RID: 32
			// (set) Token: 0x06000068 RID: 104 RVA: 0x00005337 File Offset: 0x00003537
			public byte[] Password
			{
				set
				{
					if (value == null)
					{
						this._password = new byte[0];
						return;
					}
					this._password = (byte[])value.Clone();
				}
			}

			// Token: 0x17000021 RID: 33
			// (set) Token: 0x06000069 RID: 105 RVA: 0x0000535A File Offset: 0x0000355A
			public byte[] Salt
			{
				set
				{
					if (value != null)
					{
						this._salt = (byte[])value.Clone();
						return;
					}
					this._salt = null;
				}
			}

			// Token: 0x0600006A RID: 106 RVA: 0x00005378 File Offset: 0x00003578
			private void Adjust(byte[] a, int aOff, byte[] b)
			{
				int num = (int)((b[b.Length - 1] & byte.MaxValue) + (a[aOff + b.Length - 1] & byte.MaxValue) + 1);
				a[aOff + b.Length - 1] = (byte)num;
				num >>= 8;
				for (int i = b.Length - 2; i >= 0; i--)
				{
					num += (int)((b[i] & byte.MaxValue) + (a[aOff + i] & byte.MaxValue));
					a[aOff + i] = (byte)num;
					num >>= 8;
				}
			}

			// Token: 0x0600006B RID: 107 RVA: 0x000053E8 File Offset: 0x000035E8
			private byte[] Derive(byte[] diversifier, int n)
			{
				HashAlgorithm hashAlgorithm = PKCS1.CreateFromName(this._hashName);
				int num = hashAlgorithm.HashSize >> 3;
				int num2 = 64;
				byte[] array = new byte[n];
				byte[] array2;
				if (this._salt != null && this._salt.Length != 0)
				{
					array2 = new byte[num2 * ((this._salt.Length + num2 - 1) / num2)];
					for (int num3 = 0; num3 != array2.Length; num3++)
					{
						array2[num3] = this._salt[num3 % this._salt.Length];
					}
				}
				else
				{
					array2 = new byte[0];
				}
				byte[] array3;
				if (this._password != null && this._password.Length != 0)
				{
					array3 = new byte[num2 * ((this._password.Length + num2 - 1) / num2)];
					for (int num4 = 0; num4 != array3.Length; num4++)
					{
						array3[num4] = this._password[num4 % this._password.Length];
					}
				}
				else
				{
					array3 = new byte[0];
				}
				byte[] array4 = new byte[array2.Length + array3.Length];
				Buffer.BlockCopy(array2, 0, array4, 0, array2.Length);
				Buffer.BlockCopy(array3, 0, array4, array2.Length, array3.Length);
				byte[] array5 = new byte[num2];
				int num5 = (n + num - 1) / num;
				for (int i = 1; i <= num5; i++)
				{
					hashAlgorithm.TransformBlock(diversifier, 0, diversifier.Length, diversifier, 0);
					hashAlgorithm.TransformFinalBlock(array4, 0, array4.Length);
					byte[] array6 = hashAlgorithm.Hash;
					hashAlgorithm.Initialize();
					for (int num6 = 1; num6 != this._iterations; num6++)
					{
						array6 = hashAlgorithm.ComputeHash(array6, 0, array6.Length);
					}
					for (int num7 = 0; num7 != array5.Length; num7++)
					{
						array5[num7] = array6[num7 % array6.Length];
					}
					for (int num8 = 0; num8 != array4.Length / num2; num8++)
					{
						this.Adjust(array4, num8 * num2, array5);
					}
					if (i == num5)
					{
						Buffer.BlockCopy(array6, 0, array, (i - 1) * num, array.Length - (i - 1) * num);
					}
					else
					{
						Buffer.BlockCopy(array6, 0, array, (i - 1) * num, array6.Length);
					}
				}
				return array;
			}

			// Token: 0x0600006C RID: 108 RVA: 0x000055ED File Offset: 0x000037ED
			public byte[] DeriveKey(int size)
			{
				return this.Derive(PKCS12.DeriveBytes.keyDiversifier, size);
			}

			// Token: 0x0600006D RID: 109 RVA: 0x000055FB File Offset: 0x000037FB
			public byte[] DeriveIV(int size)
			{
				return this.Derive(PKCS12.DeriveBytes.ivDiversifier, size);
			}

			// Token: 0x0600006E RID: 110 RVA: 0x00005609 File Offset: 0x00003809
			public byte[] DeriveMAC(int size)
			{
				return this.Derive(PKCS12.DeriveBytes.macDiversifier, size);
			}

			// Token: 0x04000026 RID: 38
			private static byte[] keyDiversifier = new byte[]
			{
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1,
				1
			};

			// Token: 0x04000027 RID: 39
			private static byte[] ivDiversifier = new byte[]
			{
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2
			};

			// Token: 0x04000028 RID: 40
			private static byte[] macDiversifier = new byte[]
			{
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3,
				3
			};

			// Token: 0x04000029 RID: 41
			private string _hashName;

			// Token: 0x0400002A RID: 42
			private int _iterations;

			// Token: 0x0400002B RID: 43
			private byte[] _password;

			// Token: 0x0400002C RID: 44
			private byte[] _salt;
		}
	}
}
