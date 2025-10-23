using System;
using Microsoft.Win32.SafeHandles;
using Mono.Security.Authenticode;
using Mono.Security.Cryptography;
using Mono.Security.X509;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x020000F4 RID: 244
	internal class X509Certificate2ImplMono : X509Certificate2ImplUnix
	{
		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060006C1 RID: 1729 RVA: 0x00027FDA File Offset: 0x000261DA
		public override bool IsValid
		{
			get
			{
				return this._cert != null;
			}
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x00027FE5 File Offset: 0x000261E5
		public X509Certificate2ImplMono(X509Certificate cert)
		{
			this._cert = cert;
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x00027FF4 File Offset: 0x000261F4
		private X509Certificate2ImplMono(X509Certificate2ImplMono other)
		{
			this._cert = other._cert;
			if (other.intermediateCerts != null)
			{
				this.intermediateCerts = other.intermediateCerts.Clone();
			}
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x00028024 File Offset: 0x00026224
		public X509Certificate2ImplMono(byte[] rawData, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags)
		{
			switch (X509Certificate2.GetCertContentType(rawData))
			{
			case X509ContentType.Cert:
			case X509ContentType.Pkcs7:
				this._cert = new X509Certificate(rawData);
				return;
			case X509ContentType.Pfx:
				this._cert = this.ImportPkcs12(rawData, password);
				return;
			case X509ContentType.Authenticode:
			{
				AuthenticodeDeformatter authenticodeDeformatter = new AuthenticodeDeformatter(rawData);
				this._cert = authenticodeDeformatter.SigningCertificate;
				if (this._cert != null)
				{
					return;
				}
				break;
			}
			}
			throw new CryptographicException(Locale.GetText("Unable to decode certificate."));
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x000280A7 File Offset: 0x000262A7
		public override X509CertificateImpl Clone()
		{
			base.ThrowIfContextInvalid();
			return new X509Certificate2ImplMono(this);
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060006C6 RID: 1734 RVA: 0x000280B5 File Offset: 0x000262B5
		private X509Certificate Cert
		{
			get
			{
				base.ThrowIfContextInvalid();
				return this._cert;
			}
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x000280C3 File Offset: 0x000262C3
		protected override byte[] GetRawCertData()
		{
			base.ThrowIfContextInvalid();
			return this.Cert.RawData;
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060006C8 RID: 1736 RVA: 0x000280D6 File Offset: 0x000262D6
		public override bool HasPrivateKey
		{
			get
			{
				return this.PrivateKey != null;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060006C9 RID: 1737 RVA: 0x000280E4 File Offset: 0x000262E4
		// (set) Token: 0x060006CA RID: 1738 RVA: 0x000281E0 File Offset: 0x000263E0
		public override AsymmetricAlgorithm PrivateKey
		{
			get
			{
				if (this._cert == null)
				{
					throw new CryptographicException(X509Certificate2ImplMono.empty_error);
				}
				try
				{
					RSACryptoServiceProvider rsacryptoServiceProvider = this._cert.RSA as RSACryptoServiceProvider;
					if (rsacryptoServiceProvider != null)
					{
						if (rsacryptoServiceProvider.PublicOnly)
						{
							return null;
						}
						RSACryptoServiceProvider rsacryptoServiceProvider2 = new RSACryptoServiceProvider();
						rsacryptoServiceProvider2.ImportParameters(this._cert.RSA.ExportParameters(true));
						return rsacryptoServiceProvider2;
					}
					else
					{
						RSAManaged rsamanaged = this._cert.RSA as RSAManaged;
						if (rsamanaged != null)
						{
							if (rsamanaged.PublicOnly)
							{
								return null;
							}
							RSAManaged rsamanaged2 = new RSAManaged();
							rsamanaged2.ImportParameters(this._cert.RSA.ExportParameters(true));
							return rsamanaged2;
						}
						else
						{
							DSACryptoServiceProvider dsacryptoServiceProvider = this._cert.DSA as DSACryptoServiceProvider;
							if (dsacryptoServiceProvider != null)
							{
								if (dsacryptoServiceProvider.PublicOnly)
								{
									return null;
								}
								DSACryptoServiceProvider dsacryptoServiceProvider2 = new DSACryptoServiceProvider();
								dsacryptoServiceProvider2.ImportParameters(this._cert.DSA.ExportParameters(true));
								return dsacryptoServiceProvider2;
							}
						}
					}
				}
				catch
				{
				}
				return null;
			}
			set
			{
				if (this._cert == null)
				{
					throw new CryptographicException(X509Certificate2ImplMono.empty_error);
				}
				if (value == null)
				{
					this._cert.RSA = null;
					this._cert.DSA = null;
					return;
				}
				if (value is RSA)
				{
					this._cert.RSA = (RSA)value;
					return;
				}
				if (value is DSA)
				{
					this._cert.DSA = (DSA)value;
					return;
				}
				throw new NotSupportedException();
			}
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x00028258 File Offset: 0x00026458
		private X509Certificate ImportPkcs12(byte[] rawData, SafePasswordHandle password)
		{
			if (password == null || password.IsInvalid)
			{
				return this.ImportPkcs12(rawData, null);
			}
			string password2 = password.Mono_DangerousGetString();
			return this.ImportPkcs12(rawData, password2);
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x00028288 File Offset: 0x00026488
		private X509Certificate ImportPkcs12(byte[] rawData, string password)
		{
			PKCS12 pkcs = null;
			if (string.IsNullOrEmpty(password))
			{
				try
				{
					pkcs = new PKCS12(rawData, null);
					goto IL_2B;
				}
				catch
				{
					pkcs = new PKCS12(rawData, string.Empty);
					goto IL_2B;
				}
			}
			pkcs = new PKCS12(rawData, password);
			IL_2B:
			if (pkcs.Certificates.Count == 0)
			{
				return null;
			}
			if (pkcs.Keys.Count == 0)
			{
				return pkcs.Certificates[0];
			}
			X509Certificate x509Certificate = null;
			AsymmetricAlgorithm asymmetricAlgorithm = pkcs.Keys[0] as AsymmetricAlgorithm;
			string a = asymmetricAlgorithm.ToXmlString(false);
			foreach (X509Certificate x509Certificate2 in pkcs.Certificates)
			{
				if ((x509Certificate2.RSA != null && a == x509Certificate2.RSA.ToXmlString(false)) || (x509Certificate2.DSA != null && a == x509Certificate2.DSA.ToXmlString(false)))
				{
					x509Certificate = x509Certificate2;
					break;
				}
			}
			if (x509Certificate == null)
			{
				x509Certificate = pkcs.Certificates[0];
			}
			else
			{
				x509Certificate.RSA = (asymmetricAlgorithm as RSA);
				x509Certificate.DSA = (asymmetricAlgorithm as DSA);
			}
			if (pkcs.Certificates.Count > 1)
			{
				this.intermediateCerts = new X509CertificateImplCollection();
				foreach (X509Certificate x509Certificate3 in pkcs.Certificates)
				{
					if (x509Certificate3 != x509Certificate)
					{
						X509Certificate2ImplMono impl = new X509Certificate2ImplMono(x509Certificate3);
						this.intermediateCerts.Add(impl, true);
					}
				}
			}
			return x509Certificate;
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x00028440 File Offset: 0x00026640
		public override bool Verify(X509Certificate2 thisCertificate)
		{
			if (this._cert == null)
			{
				throw new CryptographicException(X509Certificate2ImplMono.empty_error);
			}
			return X509Chain.Create().Build(thisCertificate);
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060006CE RID: 1742 RVA: 0x00028465 File Offset: 0x00026665
		internal override X509CertificateImplCollection IntermediateCertificates
		{
			get
			{
				return this.intermediateCerts;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060006CF RID: 1743 RVA: 0x0002846D File Offset: 0x0002666D
		internal X509Certificate MonoCertificate
		{
			get
			{
				return this._cert;
			}
		}

		// Token: 0x040004D8 RID: 1240
		private X509CertificateImplCollection intermediateCerts;

		// Token: 0x040004D9 RID: 1241
		private X509Certificate _cert;

		// Token: 0x040004DA RID: 1242
		private static string empty_error = Locale.GetText("Certificate instance is empty.");

		// Token: 0x040004DB RID: 1243
		private static byte[] signedData = new byte[]
		{
			42,
			134,
			72,
			134,
			247,
			13,
			1,
			7,
			2
		};
	}
}
