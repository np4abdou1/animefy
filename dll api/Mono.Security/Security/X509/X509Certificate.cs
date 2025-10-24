using System;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using Mono.Security.Cryptography;

namespace Mono.Security.X509
{
	// Token: 0x02000011 RID: 17
	public class X509Certificate : ISerializable
	{
		// Token: 0x0600008D RID: 141 RVA: 0x00006864 File Offset: 0x00004A64
		private void Parse(byte[] data)
		{
			try
			{
				this.decoder = new ASN1(data);
				if (this.decoder.Tag != 48)
				{
					throw new CryptographicException(X509Certificate.encoding_error);
				}
				if (this.decoder[0].Tag != 48)
				{
					throw new CryptographicException(X509Certificate.encoding_error);
				}
				ASN1 asn = this.decoder[0];
				int num = 0;
				ASN1 asn2 = this.decoder[0][num];
				this.version = 1;
				if (asn2.Tag == 160 && asn2.Count > 0)
				{
					this.version += (int)asn2[0].Value[0];
					num++;
				}
				ASN1 asn3 = this.decoder[0][num++];
				if (asn3.Tag != 2)
				{
					throw new CryptographicException(X509Certificate.encoding_error);
				}
				this.serialnumber = asn3.Value;
				Array.Reverse<byte>(this.serialnumber, 0, this.serialnumber.Length);
				num++;
				this.issuer = asn.Element(num++, 48);
				this.m_issuername = X501.ToString(this.issuer);
				ASN1 asn4 = asn.Element(num++, 48);
				ASN1 time = asn4[0];
				this.m_from = ASN1Convert.ToDateTime(time);
				ASN1 time2 = asn4[1];
				this.m_until = ASN1Convert.ToDateTime(time2);
				this.subject = asn.Element(num++, 48);
				this.m_subject = X501.ToString(this.subject);
				ASN1 asn5 = asn.Element(num++, 48);
				ASN1 asn6 = asn5.Element(0, 48);
				ASN1 asn7 = asn6.Element(0, 6);
				this.m_keyalgo = ASN1Convert.ToOid(asn7);
				ASN1 asn8 = asn6[1];
				this.m_keyalgoparams = ((asn6.Count > 1) ? asn8.GetBytes() : null);
				ASN1 asn9 = asn5.Element(1, 3);
				int num2 = asn9.Length - 1;
				this.m_publickey = new byte[num2];
				Buffer.BlockCopy(asn9.Value, 1, this.m_publickey, 0, num2);
				byte[] value = this.decoder[2].Value;
				this.signature = new byte[value.Length - 1];
				Buffer.BlockCopy(value, 1, this.signature, 0, this.signature.Length);
				asn6 = this.decoder[1];
				asn7 = asn6.Element(0, 6);
				this.m_signaturealgo = ASN1Convert.ToOid(asn7);
				asn8 = asn6[1];
				if (asn8 != null)
				{
					this.m_signaturealgoparams = asn8.GetBytes();
				}
				else
				{
					this.m_signaturealgoparams = null;
				}
				ASN1 asn10 = asn.Element(num, 129);
				if (asn10 != null)
				{
					num++;
					this.issuerUniqueID = asn10.Value;
				}
				ASN1 asn11 = asn.Element(num, 130);
				if (asn11 != null)
				{
					num++;
					this.subjectUniqueID = asn11.Value;
				}
				ASN1 asn12 = asn.Element(num, 163);
				if (asn12 != null && asn12.Count == 1)
				{
					this.extensions = new X509ExtensionCollection(asn12[0]);
				}
				else
				{
					this.extensions = new X509ExtensionCollection(null);
				}
				this.m_encodedcert = (byte[])data.Clone();
			}
			catch (Exception inner)
			{
				throw new CryptographicException(X509Certificate.encoding_error, inner);
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00006BB0 File Offset: 0x00004DB0
		public X509Certificate(byte[] data)
		{
			if (data != null)
			{
				if (data.Length != 0 && data[0] != 48)
				{
					try
					{
						data = X509Certificate.PEM("CERTIFICATE", data);
					}
					catch (Exception inner)
					{
						throw new CryptographicException(X509Certificate.encoding_error, inner);
					}
				}
				this.Parse(data);
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00006C04 File Offset: 0x00004E04
		private byte[] GetUnsignedBigInteger(byte[] integer)
		{
			if (integer[0] == 0)
			{
				int num = integer.Length - 1;
				byte[] array = new byte[num];
				Buffer.BlockCopy(integer, 1, array, 0, num);
				return array;
			}
			return integer;
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00006C30 File Offset: 0x00004E30
		// (set) Token: 0x06000091 RID: 145 RVA: 0x00006D6A File Offset: 0x00004F6A
		public DSA DSA
		{
			get
			{
				if (this.m_keyalgoparams == null)
				{
					throw new CryptographicException("Missing key algorithm parameters.");
				}
				if (this._dsa == null && this.m_keyalgo == "1.2.840.10040.4.1")
				{
					DSAParameters dsaparameters = default(DSAParameters);
					ASN1 asn = new ASN1(this.m_publickey);
					if (asn == null || asn.Tag != 2)
					{
						return null;
					}
					dsaparameters.Y = this.GetUnsignedBigInteger(asn.Value);
					ASN1 asn2 = new ASN1(this.m_keyalgoparams);
					if (asn2 == null || asn2.Tag != 48 || asn2.Count < 3)
					{
						return null;
					}
					if (asn2[0].Tag != 2 || asn2[1].Tag != 2 || asn2[2].Tag != 2)
					{
						return null;
					}
					dsaparameters.P = this.GetUnsignedBigInteger(asn2[0].Value);
					dsaparameters.Q = this.GetUnsignedBigInteger(asn2[1].Value);
					dsaparameters.G = this.GetUnsignedBigInteger(asn2[2].Value);
					this._dsa = new DSACryptoServiceProvider(dsaparameters.Y.Length << 3);
					this._dsa.ImportParameters(dsaparameters);
				}
				return this._dsa;
			}
			set
			{
				this._dsa = value;
				if (value != null)
				{
					this._rsa = null;
				}
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00006D7D File Offset: 0x00004F7D
		public X509ExtensionCollection Extensions
		{
			get
			{
				return this.extensions;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00006D88 File Offset: 0x00004F88
		public byte[] Hash
		{
			get
			{
				if (this.certhash == null)
				{
					if (this.decoder == null || this.decoder.Count < 1)
					{
						return null;
					}
					string text = PKCS1.HashNameFromOid(this.m_signaturealgo, false);
					if (text == null)
					{
						return null;
					}
					byte[] bytes = this.decoder[0].GetBytes();
					using (HashAlgorithm hashAlgorithm = PKCS1.CreateFromName(text))
					{
						this.certhash = hashAlgorithm.ComputeHash(bytes, 0, bytes.Length);
					}
				}
				return (byte[])this.certhash.Clone();
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00006E20 File Offset: 0x00005020
		public virtual string IssuerName
		{
			get
			{
				return this.m_issuername;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00006E28 File Offset: 0x00005028
		public virtual string KeyAlgorithm
		{
			get
			{
				return this.m_keyalgo;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00006E30 File Offset: 0x00005030
		// (set) Token: 0x06000097 RID: 151 RVA: 0x00006E4C File Offset: 0x0000504C
		public virtual byte[] KeyAlgorithmParameters
		{
			get
			{
				if (this.m_keyalgoparams == null)
				{
					return null;
				}
				return (byte[])this.m_keyalgoparams.Clone();
			}
			set
			{
				this.m_keyalgoparams = value;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00006E55 File Offset: 0x00005055
		public virtual byte[] PublicKey
		{
			get
			{
				if (this.m_publickey == null)
				{
					return null;
				}
				return (byte[])this.m_publickey.Clone();
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00006E74 File Offset: 0x00005074
		// (set) Token: 0x0600009A RID: 154 RVA: 0x00006F29 File Offset: 0x00005129
		public virtual RSA RSA
		{
			get
			{
				if (this._rsa == null && this.m_keyalgo == "1.2.840.113549.1.1.1")
				{
					RSAParameters rsaparameters = default(RSAParameters);
					ASN1 asn = new ASN1(this.m_publickey);
					ASN1 asn2 = asn[0];
					if (asn2 == null || asn2.Tag != 2)
					{
						return null;
					}
					ASN1 asn3 = asn[1];
					if (asn3.Tag != 2)
					{
						return null;
					}
					rsaparameters.Modulus = this.GetUnsignedBigInteger(asn2.Value);
					rsaparameters.Exponent = asn3.Value;
					int dwKeySize = rsaparameters.Modulus.Length << 3;
					this._rsa = new RSACryptoServiceProvider(dwKeySize);
					this._rsa.ImportParameters(rsaparameters);
				}
				return this._rsa;
			}
			set
			{
				if (value != null)
				{
					this._dsa = null;
				}
				this._rsa = value;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00006F3C File Offset: 0x0000513C
		public virtual byte[] RawData
		{
			get
			{
				if (this.m_encodedcert == null)
				{
					return null;
				}
				return (byte[])this.m_encodedcert.Clone();
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00006F58 File Offset: 0x00005158
		public virtual byte[] SerialNumber
		{
			get
			{
				if (this.serialnumber == null)
				{
					return null;
				}
				return (byte[])this.serialnumber.Clone();
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00006F74 File Offset: 0x00005174
		public virtual byte[] Signature
		{
			get
			{
				if (this.signature == null)
				{
					return null;
				}
				string signaturealgo = this.m_signaturealgo;
				uint num = <PrivateImplementationDetails>.ComputeStringHash(signaturealgo);
				if (num <= 719034781U)
				{
					if (num <= 601591448U)
					{
						if (num != 510574318U)
						{
							if (num != 601591448U)
							{
								goto IL_22D;
							}
							if (!(signaturealgo == "1.2.840.113549.1.1.5"))
							{
								goto IL_22D;
							}
						}
						else
						{
							if (!(signaturealgo == "1.2.840.10040.4.3"))
							{
								goto IL_22D;
							}
							ASN1 asn = new ASN1(this.signature);
							if (asn == null || asn.Count != 2)
							{
								return null;
							}
							byte[] value = asn[0].Value;
							byte[] value2 = asn[1].Value;
							byte[] array = new byte[40];
							int num2 = Math.Max(0, value.Length - 20);
							int dstOffset = Math.Max(0, 20 - value.Length);
							Buffer.BlockCopy(value, num2, array, dstOffset, value.Length - num2);
							int num3 = Math.Max(0, value2.Length - 20);
							int dstOffset2 = Math.Max(20, 40 - value2.Length);
							Buffer.BlockCopy(value2, num3, array, dstOffset2, value2.Length - num3);
							return array;
						}
					}
					else if (num != 618369067U)
					{
						if (num != 702257162U)
						{
							if (num != 719034781U)
							{
								goto IL_22D;
							}
							if (!(signaturealgo == "1.2.840.113549.1.1.2"))
							{
								goto IL_22D;
							}
						}
						else if (!(signaturealgo == "1.2.840.113549.1.1.3"))
						{
							goto IL_22D;
						}
					}
					else if (!(signaturealgo == "1.2.840.113549.1.1.4"))
					{
						goto IL_22D;
					}
				}
				else if (num <= 2477476687U)
				{
					if (num != 875536856U)
					{
						if (num != 2477476687U)
						{
							goto IL_22D;
						}
						if (!(signaturealgo == "1.2.840.113549.1.1.11"))
						{
							goto IL_22D;
						}
					}
					else if (!(signaturealgo == "1.3.14.3.2.29"))
					{
						goto IL_22D;
					}
				}
				else if (num != 2494254306U)
				{
					if (num != 2511031925U)
					{
						if (num != 3493391575U)
						{
							goto IL_22D;
						}
						if (!(signaturealgo == "1.3.36.3.3.1.2"))
						{
							goto IL_22D;
						}
					}
					else if (!(signaturealgo == "1.2.840.113549.1.1.13"))
					{
						goto IL_22D;
					}
				}
				else if (!(signaturealgo == "1.2.840.113549.1.1.12"))
				{
					goto IL_22D;
				}
				return (byte[])this.signature.Clone();
				IL_22D:
				throw new CryptographicException("Unsupported hash algorithm: " + this.m_signaturealgo);
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600009E RID: 158 RVA: 0x000071C3 File Offset: 0x000053C3
		public virtual string SubjectName
		{
			get
			{
				return this.m_subject;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600009F RID: 159 RVA: 0x000071CB File Offset: 0x000053CB
		public virtual DateTime ValidFrom
		{
			get
			{
				return this.m_from;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x000071D3 File Offset: 0x000053D3
		public virtual DateTime ValidUntil
		{
			get
			{
				return this.m_until;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x000071DB File Offset: 0x000053DB
		public int Version
		{
			get
			{
				return this.version;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x000071E3 File Offset: 0x000053E3
		public bool IsCurrent
		{
			get
			{
				return this.WasCurrent(DateTime.UtcNow);
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000071F0 File Offset: 0x000053F0
		public bool WasCurrent(DateTime instant)
		{
			return instant > this.ValidFrom && instant <= this.ValidUntil;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000720E File Offset: 0x0000540E
		internal bool VerifySignature(DSA dsa)
		{
			DSASignatureDeformatter dsasignatureDeformatter = new DSASignatureDeformatter(dsa);
			dsasignatureDeformatter.SetHashAlgorithm("SHA1");
			return dsasignatureDeformatter.VerifySignature(this.Hash, this.Signature);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00007232 File Offset: 0x00005432
		internal bool VerifySignature(RSA rsa)
		{
			if (this.m_signaturealgo == "1.2.840.10040.4.3")
			{
				return false;
			}
			RSAPKCS1SignatureDeformatter rsapkcs1SignatureDeformatter = new RSAPKCS1SignatureDeformatter(rsa);
			rsapkcs1SignatureDeformatter.SetHashAlgorithm(PKCS1.HashNameFromOid(this.m_signaturealgo, true));
			return rsapkcs1SignatureDeformatter.VerifySignature(this.Hash, this.Signature);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00007274 File Offset: 0x00005474
		public bool VerifySignature(AsymmetricAlgorithm aa)
		{
			if (aa == null)
			{
				throw new ArgumentNullException("aa");
			}
			if (aa is RSA)
			{
				return this.VerifySignature(aa as RSA);
			}
			if (aa is DSA)
			{
				return this.VerifySignature(aa as DSA);
			}
			throw new NotSupportedException("Unknown Asymmetric Algorithm " + aa.ToString());
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x000072D0 File Offset: 0x000054D0
		public bool IsSelfSigned
		{
			get
			{
				if (this.m_issuername != this.m_subject)
				{
					return false;
				}
				bool result;
				try
				{
					if (this.RSA != null)
					{
						result = this.VerifySignature(this.RSA);
					}
					else if (this.DSA != null)
					{
						result = this.VerifySignature(this.DSA);
					}
					else
					{
						result = false;
					}
				}
				catch (CryptographicException)
				{
					result = false;
				}
				return result;
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000733C File Offset: 0x0000553C
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("raw", this.m_encodedcert);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00007350 File Offset: 0x00005550
		private static byte[] PEM(string type, byte[] data)
		{
			string @string = Encoding.ASCII.GetString(data);
			string text = string.Format("-----BEGIN {0}-----", type);
			string value = string.Format("-----END {0}-----", type);
			int num = @string.IndexOf(text) + text.Length;
			int num2 = @string.IndexOf(value, num);
			return Convert.FromBase64String(@string.Substring(num, num2 - num));
		}

		// Token: 0x0400004A RID: 74
		private ASN1 decoder;

		// Token: 0x0400004B RID: 75
		private byte[] m_encodedcert;

		// Token: 0x0400004C RID: 76
		private DateTime m_from;

		// Token: 0x0400004D RID: 77
		private DateTime m_until;

		// Token: 0x0400004E RID: 78
		private ASN1 issuer;

		// Token: 0x0400004F RID: 79
		private string m_issuername;

		// Token: 0x04000050 RID: 80
		private string m_keyalgo;

		// Token: 0x04000051 RID: 81
		private byte[] m_keyalgoparams;

		// Token: 0x04000052 RID: 82
		private ASN1 subject;

		// Token: 0x04000053 RID: 83
		private string m_subject;

		// Token: 0x04000054 RID: 84
		private byte[] m_publickey;

		// Token: 0x04000055 RID: 85
		private byte[] signature;

		// Token: 0x04000056 RID: 86
		private string m_signaturealgo;

		// Token: 0x04000057 RID: 87
		private byte[] m_signaturealgoparams;

		// Token: 0x04000058 RID: 88
		private byte[] certhash;

		// Token: 0x04000059 RID: 89
		private RSA _rsa;

		// Token: 0x0400005A RID: 90
		private DSA _dsa;

		// Token: 0x0400005B RID: 91
		private int version;

		// Token: 0x0400005C RID: 92
		private byte[] serialnumber;

		// Token: 0x0400005D RID: 93
		private byte[] issuerUniqueID;

		// Token: 0x0400005E RID: 94
		private byte[] subjectUniqueID;

		// Token: 0x0400005F RID: 95
		private X509ExtensionCollection extensions;

		// Token: 0x04000060 RID: 96
		private static string encoding_error = Locale.GetText("Input data cannot be coded as a valid certificate.");
	}
}
