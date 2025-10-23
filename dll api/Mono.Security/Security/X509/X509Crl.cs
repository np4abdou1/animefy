using System;
using System.Collections;
using System.Reflection;
using System.Security.Cryptography;
using Mono.Security.Cryptography;

namespace Mono.Security.X509
{
	// Token: 0x0200000F RID: 15
	[DefaultMember("Item")]
	public class X509Crl
	{
		// Token: 0x0600007D RID: 125 RVA: 0x000062CC File Offset: 0x000044CC
		public X509Crl(byte[] crl)
		{
			if (crl == null)
			{
				throw new ArgumentNullException("crl");
			}
			this.encoded = (byte[])crl.Clone();
			this.Parse(this.encoded);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00006300 File Offset: 0x00004500
		private void Parse(byte[] crl)
		{
			string text = "Input data cannot be coded as a valid CRL.";
			try
			{
				ASN1 asn = new ASN1(this.encoded);
				if (asn.Tag != 48 || asn.Count != 3)
				{
					throw new CryptographicException(text);
				}
				ASN1 asn2 = asn[0];
				if (asn2.Tag != 48 || asn2.Count < 3)
				{
					throw new CryptographicException(text);
				}
				int num = 0;
				if (asn2[num].Tag == 2)
				{
					this.version = asn2[num++].Value[0] + 1;
				}
				else
				{
					this.version = 1;
				}
				this.signatureOID = ASN1Convert.ToOid(asn2[num++][0]);
				this.issuer = X501.ToString(asn2[num++]);
				this.thisUpdate = ASN1Convert.ToDateTime(asn2[num++]);
				ASN1 asn3 = asn2[num++];
				if (asn3.Tag == 23 || asn3.Tag == 24)
				{
					this.nextUpdate = ASN1Convert.ToDateTime(asn3);
					asn3 = asn2[num++];
				}
				this.entries = new ArrayList();
				if (asn3 != null && asn3.Tag == 48)
				{
					ASN1 asn4 = asn3;
					for (int i = 0; i < asn4.Count; i++)
					{
						this.entries.Add(new X509Crl.X509CrlEntry(asn4[i]));
					}
				}
				else
				{
					num--;
				}
				ASN1 asn5 = asn2[num];
				if (asn5 != null && asn5.Tag == 160 && asn5.Count == 1)
				{
					this.extensions = new X509ExtensionCollection(asn5[0]);
				}
				else
				{
					this.extensions = new X509ExtensionCollection(null);
				}
				string b = ASN1Convert.ToOid(asn[1][0]);
				if (this.signatureOID != b)
				{
					throw new CryptographicException(text + " [Non-matching signature algorithms in CRL]");
				}
				byte[] value = asn[2].Value;
				this.signature = new byte[value.Length - 1];
				Buffer.BlockCopy(value, 1, this.signature, 0, this.signature.Length);
			}
			catch
			{
				throw new CryptographicException(text);
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00006540 File Offset: 0x00004740
		public X509ExtensionCollection Extensions
		{
			get
			{
				return this.extensions;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00006548 File Offset: 0x00004748
		public byte[] Hash
		{
			get
			{
				if (this.hash_value == null)
				{
					byte[] bytes = new ASN1(this.encoded)[0].GetBytes();
					using (HashAlgorithm hashAlgorithm = PKCS1.CreateFromOid(this.signatureOID))
					{
						this.hash_value = hashAlgorithm.ComputeHash(bytes);
					}
				}
				return this.hash_value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000081 RID: 129 RVA: 0x000065B0 File Offset: 0x000047B0
		public string IssuerName
		{
			get
			{
				return this.issuer;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000082 RID: 130 RVA: 0x000065B8 File Offset: 0x000047B8
		public DateTime NextUpdate
		{
			get
			{
				return this.nextUpdate;
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000065C0 File Offset: 0x000047C0
		private bool Compare(byte[] array1, byte[] array2)
		{
			if (array1 == null && array2 == null)
			{
				return true;
			}
			if (array1 == null || array2 == null)
			{
				return false;
			}
			if (array1.Length != array2.Length)
			{
				return false;
			}
			for (int i = 0; i < array1.Length; i++)
			{
				if (array1[i] != array2[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00006600 File Offset: 0x00004800
		public X509Crl.X509CrlEntry GetCrlEntry(X509Certificate x509)
		{
			if (x509 == null)
			{
				throw new ArgumentNullException("x509");
			}
			return this.GetCrlEntry(x509.SerialNumber);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000661C File Offset: 0x0000481C
		public X509Crl.X509CrlEntry GetCrlEntry(byte[] serialNumber)
		{
			if (serialNumber == null)
			{
				throw new ArgumentNullException("serialNumber");
			}
			for (int i = 0; i < this.entries.Count; i++)
			{
				X509Crl.X509CrlEntry x509CrlEntry = (X509Crl.X509CrlEntry)this.entries[i];
				if (this.Compare(serialNumber, x509CrlEntry.SerialNumber))
				{
					return x509CrlEntry;
				}
			}
			return null;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00006674 File Offset: 0x00004874
		internal bool VerifySignature(DSA dsa)
		{
			if (this.signatureOID != "1.2.840.10040.4.3")
			{
				throw new CryptographicException("Unsupported hash algorithm: " + this.signatureOID);
			}
			DSASignatureDeformatter dsasignatureDeformatter = new DSASignatureDeformatter(dsa);
			dsasignatureDeformatter.SetHashAlgorithm("SHA1");
			ASN1 asn = new ASN1(this.signature);
			if (asn == null || asn.Count != 2)
			{
				return false;
			}
			byte[] value = asn[0].Value;
			byte[] value2 = asn[1].Value;
			byte[] array = new byte[40];
			int num = Math.Max(0, value.Length - 20);
			int dstOffset = Math.Max(0, 20 - value.Length);
			Buffer.BlockCopy(value, num, array, dstOffset, value.Length - num);
			int num2 = Math.Max(0, value2.Length - 20);
			int dstOffset2 = Math.Max(20, 40 - value2.Length);
			Buffer.BlockCopy(value2, num2, array, dstOffset2, value2.Length - num2);
			return dsasignatureDeformatter.VerifySignature(this.Hash, array);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00006763 File Offset: 0x00004963
		internal bool VerifySignature(RSA rsa)
		{
			RSAPKCS1SignatureDeformatter rsapkcs1SignatureDeformatter = new RSAPKCS1SignatureDeformatter(rsa);
			rsapkcs1SignatureDeformatter.SetHashAlgorithm(PKCS1.HashNameFromOid(this.signatureOID, true));
			return rsapkcs1SignatureDeformatter.VerifySignature(this.Hash, this.signature);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00006790 File Offset: 0x00004990
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

		// Token: 0x0400003D RID: 61
		private string issuer;

		// Token: 0x0400003E RID: 62
		private byte version;

		// Token: 0x0400003F RID: 63
		private DateTime thisUpdate;

		// Token: 0x04000040 RID: 64
		private DateTime nextUpdate;

		// Token: 0x04000041 RID: 65
		private ArrayList entries;

		// Token: 0x04000042 RID: 66
		private string signatureOID;

		// Token: 0x04000043 RID: 67
		private byte[] signature;

		// Token: 0x04000044 RID: 68
		private X509ExtensionCollection extensions;

		// Token: 0x04000045 RID: 69
		private byte[] encoded;

		// Token: 0x04000046 RID: 70
		private byte[] hash_value;

		// Token: 0x02000010 RID: 16
		public class X509CrlEntry
		{
			// Token: 0x06000089 RID: 137 RVA: 0x000067EC File Offset: 0x000049EC
			internal X509CrlEntry(ASN1 entry)
			{
				this.sn = entry[0].Value;
				Array.Reverse<byte>(this.sn);
				this.revocationDate = ASN1Convert.ToDateTime(entry[1]);
				this.extensions = new X509ExtensionCollection(entry[2]);
			}

			// Token: 0x17000026 RID: 38
			// (get) Token: 0x0600008A RID: 138 RVA: 0x00006840 File Offset: 0x00004A40
			public byte[] SerialNumber
			{
				get
				{
					return (byte[])this.sn.Clone();
				}
			}

			// Token: 0x17000027 RID: 39
			// (get) Token: 0x0600008B RID: 139 RVA: 0x00006852 File Offset: 0x00004A52
			public DateTime RevocationDate
			{
				get
				{
					return this.revocationDate;
				}
			}

			// Token: 0x17000028 RID: 40
			// (get) Token: 0x0600008C RID: 140 RVA: 0x0000685A File Offset: 0x00004A5A
			public X509ExtensionCollection Extensions
			{
				get
				{
					return this.extensions;
				}
			}

			// Token: 0x04000047 RID: 71
			private byte[] sn;

			// Token: 0x04000048 RID: 72
			private DateTime revocationDate;

			// Token: 0x04000049 RID: 73
			private X509ExtensionCollection extensions;
		}
	}
}
