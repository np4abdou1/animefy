using System;
using System.Security;
using System.Security.Cryptography;
using Mono.Security.Cryptography;
using Mono.Security.X509;

namespace Mono.Security.Authenticode
{
	// Token: 0x02000052 RID: 82
	public class AuthenticodeDeformatter : AuthenticodeBase
	{
		// Token: 0x060001CB RID: 459 RVA: 0x0000C4BA File Offset: 0x0000A6BA
		public AuthenticodeDeformatter()
		{
			this.reason = -1;
			this.signerChain = new X509Chain();
			this.timestampChain = new X509Chain();
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0000C4DF File Offset: 0x0000A6DF
		public AuthenticodeDeformatter(byte[] rawData) : this()
		{
			this.RawData = rawData;
		}

		// Token: 0x1700007C RID: 124
		// (set) Token: 0x060001CD RID: 461 RVA: 0x0000C4F0 File Offset: 0x0000A6F0
		public byte[] RawData
		{
			set
			{
				this.Reset();
				this.rawdata = value;
				try
				{
					this.CheckSignature();
				}
				catch (SecurityException)
				{
					throw;
				}
				catch
				{
					this.reason = 1;
				}
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001CE RID: 462 RVA: 0x0000C53C File Offset: 0x0000A73C
		public X509Certificate SigningCertificate
		{
			get
			{
				return this.signingCertificate;
			}
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0000C544 File Offset: 0x0000A744
		private bool CheckSignature()
		{
			if (this.filename != null)
			{
				base.Open(this.filename);
			}
			else
			{
				base.Open(this.rawdata);
			}
			this.entry = base.GetSecurityEntry();
			if (this.entry == null)
			{
				this.reason = 1;
				base.Close();
				return false;
			}
			PKCS7.ContentInfo contentInfo = new PKCS7.ContentInfo(this.entry);
			if (contentInfo.ContentType != "1.2.840.113549.1.7.2")
			{
				base.Close();
				return false;
			}
			PKCS7.SignedData signedData = new PKCS7.SignedData(contentInfo.Content);
			if (signedData.ContentInfo.ContentType != "1.3.6.1.4.1.311.2.1.4")
			{
				base.Close();
				return false;
			}
			this.coll = signedData.Certificates;
			ASN1 content = signedData.ContentInfo.Content;
			this.signedHash = content[0][1][1];
			int length = this.signedHash.Length;
			HashAlgorithm hashAlgorithm;
			if (length <= 20)
			{
				if (length == 16)
				{
					hashAlgorithm = MD5.Create();
					this.hash = base.GetHash(hashAlgorithm);
					goto IL_176;
				}
				if (length == 20)
				{
					hashAlgorithm = SHA1.Create();
					this.hash = base.GetHash(hashAlgorithm);
					goto IL_176;
				}
			}
			else
			{
				if (length == 32)
				{
					hashAlgorithm = SHA256.Create();
					this.hash = base.GetHash(hashAlgorithm);
					goto IL_176;
				}
				if (length == 48)
				{
					hashAlgorithm = SHA384.Create();
					this.hash = base.GetHash(hashAlgorithm);
					goto IL_176;
				}
				if (length == 64)
				{
					hashAlgorithm = SHA512.Create();
					this.hash = base.GetHash(hashAlgorithm);
					goto IL_176;
				}
			}
			this.reason = 5;
			base.Close();
			return false;
			IL_176:
			base.Close();
			if (!this.signedHash.CompareValue(this.hash))
			{
				this.reason = 2;
			}
			byte[] value = content[0].Value;
			hashAlgorithm.Initialize();
			byte[] calculatedMessageDigest = hashAlgorithm.ComputeHash(value);
			return this.VerifySignature(signedData, calculatedMessageDigest, hashAlgorithm) && this.reason == 0;
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0000C71C File Offset: 0x0000A91C
		private bool CompareIssuerSerial(string issuer, byte[] serial, X509Certificate x509)
		{
			if (issuer != x509.IssuerName)
			{
				return false;
			}
			if (serial.Length != x509.SerialNumber.Length)
			{
				return false;
			}
			int num = serial.Length;
			for (int i = 0; i < serial.Length; i++)
			{
				if (serial[i] != x509.SerialNumber[--num])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0000C770 File Offset: 0x0000A970
		private bool VerifySignature(PKCS7.SignedData sd, byte[] calculatedMessageDigest, HashAlgorithm ha)
		{
			string a = null;
			ASN1 asn = null;
			for (int i = 0; i < sd.SignerInfo.AuthenticatedAttributes.Count; i++)
			{
				ASN1 asn2 = (ASN1)sd.SignerInfo.AuthenticatedAttributes[i];
				string a2 = ASN1Convert.ToOid(asn2[0]);
				if (!(a2 == "1.2.840.113549.1.9.3"))
				{
					if (!(a2 == "1.2.840.113549.1.9.4"))
					{
						if (!(a2 == "1.3.6.1.4.1.311.2.1.11") && !(a2 == "1.3.6.1.4.1.311.2.1.12"))
						{
						}
					}
					else
					{
						asn = asn2[1][0];
					}
				}
				else
				{
					a = ASN1Convert.ToOid(asn2[1][0]);
				}
			}
			if (a != "1.3.6.1.4.1.311.2.1.4")
			{
				return false;
			}
			if (asn == null)
			{
				return false;
			}
			if (!asn.CompareValue(calculatedMessageDigest))
			{
				return false;
			}
			string str = CryptoConfig.MapNameToOID(ha.ToString());
			ASN1 asn3 = new ASN1(49);
			foreach (object obj in sd.SignerInfo.AuthenticatedAttributes)
			{
				ASN1 asn4 = (ASN1)obj;
				asn3.Add(asn4);
			}
			ha.Initialize();
			byte[] rgbHash = ha.ComputeHash(asn3.GetBytes());
			byte[] signature = sd.SignerInfo.Signature;
			string issuerName = sd.SignerInfo.IssuerName;
			byte[] serialNumber = sd.SignerInfo.SerialNumber;
			foreach (X509Certificate x509Certificate in this.coll)
			{
				if (this.CompareIssuerSerial(issuerName, serialNumber, x509Certificate) && x509Certificate.PublicKey.Length > signature.Length >> 3)
				{
					this.signingCertificate = x509Certificate;
					if (((RSACryptoServiceProvider)x509Certificate.RSA).VerifyHash(rgbHash, str, signature))
					{
						this.signerChain.LoadCertificates(this.coll);
						this.trustedRoot = this.signerChain.Build(x509Certificate);
						break;
					}
				}
			}
			bool flag = false;
			X509Extension x509Extension = (this.coll.Count > 0) ? this.coll[0].Extensions["2.5.29.37"] : null;
			if (x509Extension == null)
			{
				return false;
			}
			ASN1 asn5 = new ASN1(x509Extension.Value.Value);
			if (asn5.Tag != 48)
			{
				return false;
			}
			for (int j = 0; j < asn5.Count; j++)
			{
				if (ASN1Convert.ToOid(asn5[j]) == "1.3.6.1.5.5.7.3.3")
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return false;
			}
			if (sd.SignerInfo.UnauthenticatedAttributes.Count == 0)
			{
				this.trustedTimestampRoot = true;
			}
			else
			{
				for (int k = 0; k < sd.SignerInfo.UnauthenticatedAttributes.Count; k++)
				{
					ASN1 asn6 = (ASN1)sd.SignerInfo.UnauthenticatedAttributes[k];
					if (ASN1Convert.ToOid(asn6[0]) == "1.2.840.113549.1.9.6")
					{
						PKCS7.SignerInfo cs = new PKCS7.SignerInfo(asn6[1]);
						this.trustedTimestampRoot = this.VerifyCounterSignature(cs, signature);
					}
				}
			}
			return this.trustedRoot && this.trustedTimestampRoot;
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x0000CACC File Offset: 0x0000ACCC
		private bool VerifyCounterSignature(PKCS7.SignerInfo cs, byte[] signature)
		{
			if (cs.Version > 1)
			{
				return false;
			}
			string a = null;
			ASN1 asn = null;
			for (int i = 0; i < cs.AuthenticatedAttributes.Count; i++)
			{
				ASN1 asn2 = (ASN1)cs.AuthenticatedAttributes[i];
				string a2 = ASN1Convert.ToOid(asn2[0]);
				if (!(a2 == "1.2.840.113549.1.9.3"))
				{
					if (!(a2 == "1.2.840.113549.1.9.4"))
					{
						if (a2 == "1.2.840.113549.1.9.5")
						{
							this.timestamp = ASN1Convert.ToDateTime(asn2[1][0]);
						}
					}
					else
					{
						asn = asn2[1][0];
					}
				}
				else
				{
					a = ASN1Convert.ToOid(asn2[1][0]);
				}
			}
			if (a != "1.2.840.113549.1.7.1")
			{
				return false;
			}
			if (asn == null)
			{
				return false;
			}
			string hashName = null;
			int length = asn.Length;
			if (length <= 20)
			{
				if (length != 16)
				{
					if (length == 20)
					{
						hashName = "SHA1";
					}
				}
				else
				{
					hashName = "MD5";
				}
			}
			else if (length != 32)
			{
				if (length != 48)
				{
					if (length == 64)
					{
						hashName = "SHA512";
					}
				}
				else
				{
					hashName = "SHA384";
				}
			}
			else
			{
				hashName = "SHA256";
			}
			HashAlgorithm hashAlgorithm = HashAlgorithm.Create(hashName);
			if (!asn.CompareValue(hashAlgorithm.ComputeHash(signature)))
			{
				return false;
			}
			byte[] signature2 = cs.Signature;
			ASN1 asn3 = new ASN1(49);
			foreach (object obj in cs.AuthenticatedAttributes)
			{
				ASN1 asn4 = (ASN1)obj;
				asn3.Add(asn4);
			}
			byte[] hashValue = hashAlgorithm.ComputeHash(asn3.GetBytes());
			string issuerName = cs.IssuerName;
			byte[] serialNumber = cs.SerialNumber;
			foreach (X509Certificate x509Certificate in this.coll)
			{
				if (this.CompareIssuerSerial(issuerName, serialNumber, x509Certificate) && x509Certificate.PublicKey.Length > signature2.Length)
				{
					RSACryptoServiceProvider rsacryptoServiceProvider = (RSACryptoServiceProvider)x509Certificate.RSA;
					RSAManaged rsamanaged = new RSAManaged();
					rsamanaged.ImportParameters(rsacryptoServiceProvider.ExportParameters(false));
					if (PKCS1.Verify_v15(rsamanaged, hashAlgorithm, hashValue, signature2, true))
					{
						this.timestampChain.LoadCertificates(this.coll);
						return this.timestampChain.Build(x509Certificate);
					}
				}
			}
			return false;
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0000CD58 File Offset: 0x0000AF58
		private void Reset()
		{
			this.filename = null;
			this.rawdata = null;
			this.entry = null;
			this.hash = null;
			this.signedHash = null;
			this.signingCertificate = null;
			this.reason = -1;
			this.trustedRoot = false;
			this.trustedTimestampRoot = false;
			this.signerChain.Reset();
			this.timestampChain.Reset();
			this.timestamp = DateTime.MinValue;
		}

		// Token: 0x0400022E RID: 558
		private string filename;

		// Token: 0x0400022F RID: 559
		private byte[] rawdata;

		// Token: 0x04000230 RID: 560
		private byte[] hash;

		// Token: 0x04000231 RID: 561
		private X509CertificateCollection coll;

		// Token: 0x04000232 RID: 562
		private ASN1 signedHash;

		// Token: 0x04000233 RID: 563
		private DateTime timestamp;

		// Token: 0x04000234 RID: 564
		private X509Certificate signingCertificate;

		// Token: 0x04000235 RID: 565
		private int reason;

		// Token: 0x04000236 RID: 566
		private bool trustedRoot;

		// Token: 0x04000237 RID: 567
		private bool trustedTimestampRoot;

		// Token: 0x04000238 RID: 568
		private byte[] entry;

		// Token: 0x04000239 RID: 569
		private X509Chain signerChain;

		// Token: 0x0400023A RID: 570
		private X509Chain timestampChain;
	}
}
