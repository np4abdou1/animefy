using System;
using System.Collections;
using Mono.Security.X509;

namespace Mono.Security
{
	// Token: 0x02000006 RID: 6
	public sealed class PKCS7
	{
		// Token: 0x02000007 RID: 7
		public class ContentInfo
		{
			// Token: 0x06000023 RID: 35 RVA: 0x00002B88 File Offset: 0x00000D88
			public ContentInfo()
			{
				this.content = new ASN1(160);
			}

			// Token: 0x06000024 RID: 36 RVA: 0x00002BA0 File Offset: 0x00000DA0
			public ContentInfo(string oid) : this()
			{
				this.contentType = oid;
			}

			// Token: 0x06000025 RID: 37 RVA: 0x00002BAF File Offset: 0x00000DAF
			public ContentInfo(byte[] data) : this(new ASN1(data))
			{
			}

			// Token: 0x06000026 RID: 38 RVA: 0x00002BC0 File Offset: 0x00000DC0
			public ContentInfo(ASN1 asn1)
			{
				if (asn1.Tag != 48 || (asn1.Count < 1 && asn1.Count > 2))
				{
					throw new ArgumentException("Invalid ASN1");
				}
				if (asn1[0].Tag != 6)
				{
					throw new ArgumentException("Invalid contentType");
				}
				this.contentType = ASN1Convert.ToOid(asn1[0]);
				if (asn1.Count > 1)
				{
					if (asn1[1].Tag != 160)
					{
						throw new ArgumentException("Invalid content");
					}
					this.content = asn1[1];
				}
			}

			// Token: 0x17000006 RID: 6
			// (get) Token: 0x06000027 RID: 39 RVA: 0x00002C5A File Offset: 0x00000E5A
			public ASN1 ASN1
			{
				get
				{
					return this.GetASN1();
				}
			}

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x06000028 RID: 40 RVA: 0x00002C62 File Offset: 0x00000E62
			// (set) Token: 0x06000029 RID: 41 RVA: 0x00002C6A File Offset: 0x00000E6A
			public ASN1 Content
			{
				get
				{
					return this.content;
				}
				set
				{
					this.content = value;
				}
			}

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x0600002A RID: 42 RVA: 0x00002C73 File Offset: 0x00000E73
			// (set) Token: 0x0600002B RID: 43 RVA: 0x00002C7B File Offset: 0x00000E7B
			public string ContentType
			{
				get
				{
					return this.contentType;
				}
				set
				{
					this.contentType = value;
				}
			}

			// Token: 0x0600002C RID: 44 RVA: 0x00002C84 File Offset: 0x00000E84
			internal ASN1 GetASN1()
			{
				ASN1 asn = new ASN1(48);
				asn.Add(ASN1Convert.FromOid(this.contentType));
				if (this.content != null && this.content.Count > 0)
				{
					asn.Add(this.content);
				}
				return asn;
			}

			// Token: 0x04000004 RID: 4
			private string contentType;

			// Token: 0x04000005 RID: 5
			private ASN1 content;
		}

		// Token: 0x02000008 RID: 8
		public class EncryptedData
		{
			// Token: 0x0600002D RID: 45 RVA: 0x00002CCF File Offset: 0x00000ECF
			public EncryptedData()
			{
				this._version = 0;
			}

			// Token: 0x0600002E RID: 46 RVA: 0x00002CE0 File Offset: 0x00000EE0
			public EncryptedData(ASN1 asn1) : this()
			{
				if (asn1.Tag != 48 || asn1.Count < 2)
				{
					throw new ArgumentException("Invalid EncryptedData");
				}
				if (asn1[0].Tag != 2)
				{
					throw new ArgumentException("Invalid version");
				}
				this._version = asn1[0].Value[0];
				ASN1 asn2 = asn1[1];
				if (asn2.Tag != 48)
				{
					throw new ArgumentException("missing EncryptedContentInfo");
				}
				ASN1 asn3 = asn2[0];
				if (asn3.Tag != 6)
				{
					throw new ArgumentException("missing EncryptedContentInfo.ContentType");
				}
				this._content = new PKCS7.ContentInfo(ASN1Convert.ToOid(asn3));
				ASN1 asn4 = asn2[1];
				if (asn4.Tag != 48)
				{
					throw new ArgumentException("missing EncryptedContentInfo.ContentEncryptionAlgorithmIdentifier");
				}
				this._encryptionAlgorithm = new PKCS7.ContentInfo(ASN1Convert.ToOid(asn4[0]));
				this._encryptionAlgorithm.Content = asn4[1];
				ASN1 asn5 = asn2[2];
				if (asn5.Tag != 128)
				{
					throw new ArgumentException("missing EncryptedContentInfo.EncryptedContent");
				}
				this._encrypted = asn5.Value;
			}

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x0600002F RID: 47 RVA: 0x00002DF9 File Offset: 0x00000FF9
			public PKCS7.ContentInfo EncryptionAlgorithm
			{
				get
				{
					return this._encryptionAlgorithm;
				}
			}

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x06000030 RID: 48 RVA: 0x00002E01 File Offset: 0x00001001
			public byte[] EncryptedContent
			{
				get
				{
					if (this._encrypted == null)
					{
						return null;
					}
					return (byte[])this._encrypted.Clone();
				}
			}

			// Token: 0x04000006 RID: 6
			private byte _version;

			// Token: 0x04000007 RID: 7
			private PKCS7.ContentInfo _content;

			// Token: 0x04000008 RID: 8
			private PKCS7.ContentInfo _encryptionAlgorithm;

			// Token: 0x04000009 RID: 9
			private byte[] _encrypted;
		}

		// Token: 0x02000009 RID: 9
		public class SignedData
		{
			// Token: 0x06000031 RID: 49 RVA: 0x00002E20 File Offset: 0x00001020
			public SignedData(ASN1 asn1)
			{
				if (asn1[0].Tag != 48 || asn1[0].Count < 4)
				{
					throw new ArgumentException("Invalid SignedData");
				}
				if (asn1[0][0].Tag != 2)
				{
					throw new ArgumentException("Invalid version");
				}
				this.version = asn1[0][0].Value[0];
				this.contentInfo = new PKCS7.ContentInfo(asn1[0][2]);
				int num = 3;
				this.certs = new X509CertificateCollection();
				if (asn1[0][num].Tag == 160)
				{
					for (int i = 0; i < asn1[0][num].Count; i++)
					{
						this.certs.Add(new X509Certificate(asn1[0][num][i].GetBytes()));
					}
					num++;
				}
				this.crls = new ArrayList();
				if (asn1[0][num].Tag == 161)
				{
					for (int j = 0; j < asn1[0][num].Count; j++)
					{
						this.crls.Add(asn1[0][num][j].GetBytes());
					}
					num++;
				}
				if (asn1[0][num].Count > 0)
				{
					this.signerInfo = new PKCS7.SignerInfo(asn1[0][num]);
				}
				else
				{
					this.signerInfo = new PKCS7.SignerInfo();
				}
				if (this.signerInfo.HashName != null)
				{
					this.HashName = this.OidToName(this.signerInfo.HashName);
				}
				this.mda = (this.signerInfo.AuthenticatedAttributes.Count > 0);
			}

			// Token: 0x1700000B RID: 11
			// (get) Token: 0x06000032 RID: 50 RVA: 0x00002FFF File Offset: 0x000011FF
			public X509CertificateCollection Certificates
			{
				get
				{
					return this.certs;
				}
			}

			// Token: 0x1700000C RID: 12
			// (get) Token: 0x06000033 RID: 51 RVA: 0x00003007 File Offset: 0x00001207
			public PKCS7.ContentInfo ContentInfo
			{
				get
				{
					return this.contentInfo;
				}
			}

			// Token: 0x1700000D RID: 13
			// (set) Token: 0x06000034 RID: 52 RVA: 0x0000300F File Offset: 0x0000120F
			public string HashName
			{
				set
				{
					this.hashAlgorithm = value;
					this.signerInfo.HashName = value;
				}
			}

			// Token: 0x1700000E RID: 14
			// (get) Token: 0x06000035 RID: 53 RVA: 0x00003024 File Offset: 0x00001224
			public PKCS7.SignerInfo SignerInfo
			{
				get
				{
					return this.signerInfo;
				}
			}

			// Token: 0x06000036 RID: 54 RVA: 0x0000302C File Offset: 0x0000122C
			internal string OidToName(string oid)
			{
				if (oid == "1.3.14.3.2.26")
				{
					return "SHA1";
				}
				if (oid == "1.2.840.113549.2.2")
				{
					return "MD2";
				}
				if (oid == "1.2.840.113549.2.5")
				{
					return "MD5";
				}
				if (oid == "2.16.840.1.101.3.4.1")
				{
					return "SHA256";
				}
				if (oid == "2.16.840.1.101.3.4.2")
				{
					return "SHA384";
				}
				if (!(oid == "2.16.840.1.101.3.4.3"))
				{
					return oid;
				}
				return "SHA512";
			}

			// Token: 0x0400000A RID: 10
			private byte version;

			// Token: 0x0400000B RID: 11
			private string hashAlgorithm;

			// Token: 0x0400000C RID: 12
			private PKCS7.ContentInfo contentInfo;

			// Token: 0x0400000D RID: 13
			private X509CertificateCollection certs;

			// Token: 0x0400000E RID: 14
			private ArrayList crls;

			// Token: 0x0400000F RID: 15
			private PKCS7.SignerInfo signerInfo;

			// Token: 0x04000010 RID: 16
			private bool mda;
		}

		// Token: 0x0200000A RID: 10
		public class SignerInfo
		{
			// Token: 0x06000037 RID: 55 RVA: 0x000030AE File Offset: 0x000012AE
			public SignerInfo()
			{
				this.version = 1;
				this.authenticatedAttributes = new ArrayList();
				this.unauthenticatedAttributes = new ArrayList();
			}

			// Token: 0x06000038 RID: 56 RVA: 0x000030D4 File Offset: 0x000012D4
			public SignerInfo(ASN1 asn1) : this()
			{
				if (asn1[0].Tag != 48 || asn1[0].Count < 5)
				{
					throw new ArgumentException("Invalid SignedData");
				}
				if (asn1[0][0].Tag != 2)
				{
					throw new ArgumentException("Invalid version");
				}
				this.version = asn1[0][0].Value[0];
				ASN1 asn2 = asn1[0][1];
				if (asn2.Tag == 128 && this.version == 3)
				{
					this.ski = asn2.Value;
				}
				else
				{
					this.issuer = X501.ToString(asn2[0]);
					this.serial = asn2[1].Value;
				}
				ASN1 asn3 = asn1[0][2];
				this.hashAlgorithm = ASN1Convert.ToOid(asn3[0]);
				int num = 3;
				ASN1 asn4 = asn1[0][num];
				if (asn4.Tag == 160)
				{
					num++;
					for (int i = 0; i < asn4.Count; i++)
					{
						this.authenticatedAttributes.Add(asn4[i]);
					}
				}
				num++;
				ASN1 asn5 = asn1[0][num++];
				if (asn5.Tag == 4)
				{
					this.signature = asn5.Value;
				}
				ASN1 asn6 = asn1[0][num];
				if (asn6 != null && asn6.Tag == 161)
				{
					for (int j = 0; j < asn6.Count; j++)
					{
						this.unauthenticatedAttributes.Add(asn6[j]);
					}
				}
			}

			// Token: 0x1700000F RID: 15
			// (get) Token: 0x06000039 RID: 57 RVA: 0x00003285 File Offset: 0x00001485
			public string IssuerName
			{
				get
				{
					return this.issuer;
				}
			}

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x0600003A RID: 58 RVA: 0x0000328D File Offset: 0x0000148D
			public byte[] SerialNumber
			{
				get
				{
					if (this.serial == null)
					{
						return null;
					}
					return (byte[])this.serial.Clone();
				}
			}

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x0600003B RID: 59 RVA: 0x000032A9 File Offset: 0x000014A9
			public ArrayList AuthenticatedAttributes
			{
				get
				{
					return this.authenticatedAttributes;
				}
			}

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x0600003C RID: 60 RVA: 0x000032B1 File Offset: 0x000014B1
			// (set) Token: 0x0600003D RID: 61 RVA: 0x000032B9 File Offset: 0x000014B9
			public string HashName
			{
				get
				{
					return this.hashAlgorithm;
				}
				set
				{
					this.hashAlgorithm = value;
				}
			}

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x0600003E RID: 62 RVA: 0x000032C2 File Offset: 0x000014C2
			public byte[] Signature
			{
				get
				{
					if (this.signature == null)
					{
						return null;
					}
					return (byte[])this.signature.Clone();
				}
			}

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x0600003F RID: 63 RVA: 0x000032DE File Offset: 0x000014DE
			public ArrayList UnauthenticatedAttributes
			{
				get
				{
					return this.unauthenticatedAttributes;
				}
			}

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x06000040 RID: 64 RVA: 0x000032E6 File Offset: 0x000014E6
			public byte Version
			{
				get
				{
					return this.version;
				}
			}

			// Token: 0x04000011 RID: 17
			private byte version;

			// Token: 0x04000012 RID: 18
			private string hashAlgorithm;

			// Token: 0x04000013 RID: 19
			private ArrayList authenticatedAttributes;

			// Token: 0x04000014 RID: 20
			private ArrayList unauthenticatedAttributes;

			// Token: 0x04000015 RID: 21
			private byte[] signature;

			// Token: 0x04000016 RID: 22
			private string issuer;

			// Token: 0x04000017 RID: 23
			private byte[] serial;

			// Token: 0x04000018 RID: 24
			private byte[] ski;
		}
	}
}
