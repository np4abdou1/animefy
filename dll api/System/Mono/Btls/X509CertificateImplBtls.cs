using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Win32.SafeHandles;
using Mono.Security.Authenticode;
using Mono.Security.Cryptography;

namespace Mono.Btls
{
	// Token: 0x02000066 RID: 102
	internal class X509CertificateImplBtls : X509Certificate2ImplUnix
	{
		// Token: 0x06000286 RID: 646 RVA: 0x00008CA3 File Offset: 0x00006EA3
		internal X509CertificateImplBtls(MonoBtlsX509 x509)
		{
			this.x509 = x509.Copy();
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00008CB8 File Offset: 0x00006EB8
		private X509CertificateImplBtls(X509CertificateImplBtls other)
		{
			this.x509 = ((other.x509 != null) ? other.x509.Copy() : null);
			this.nativePrivateKey = ((other.nativePrivateKey != null) ? other.nativePrivateKey.Copy() : null);
			if (other.intermediateCerts != null)
			{
				this.intermediateCerts = other.intermediateCerts.Clone();
			}
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00008D1C File Offset: 0x00006F1C
		internal X509CertificateImplBtls(byte[] data, MonoBtlsX509Format format)
		{
			this.x509 = MonoBtlsX509.LoadFromData(data, format);
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00008D34 File Offset: 0x00006F34
		internal X509CertificateImplBtls(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags)
		{
			if (password == null || password.IsInvalid)
			{
				try
				{
					this.Import(data);
					return;
				}
				catch (Exception inner)
				{
					try
					{
						this.ImportPkcs12(data, null);
					}
					catch
					{
						try
						{
							this.ImportAuthenticode(data);
						}
						catch
						{
							throw new CryptographicException(Locale.GetText("Unable to decode certificate."), inner);
						}
					}
					return;
				}
			}
			try
			{
				this.ImportPkcs12(data, password);
			}
			catch (Exception inner2)
			{
				try
				{
					this.Import(data);
				}
				catch
				{
					try
					{
						this.ImportAuthenticode(data);
					}
					catch
					{
						throw new CryptographicException(Locale.GetText("Unable to decode certificate."), inner2);
					}
				}
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600028A RID: 650 RVA: 0x00008E08 File Offset: 0x00007008
		public override bool IsValid
		{
			get
			{
				return this.x509 != null && this.x509.IsValid;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600028B RID: 651 RVA: 0x00008E1F File Offset: 0x0000701F
		internal MonoBtlsX509 X509
		{
			get
			{
				base.ThrowIfContextInvalid();
				return this.x509;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600028C RID: 652 RVA: 0x00008E2D File Offset: 0x0000702D
		internal MonoBtlsKey NativePrivateKey
		{
			get
			{
				base.ThrowIfContextInvalid();
				return this.nativePrivateKey;
			}
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00008E3B File Offset: 0x0000703B
		public override X509CertificateImpl Clone()
		{
			base.ThrowIfContextInvalid();
			return new X509CertificateImplBtls(this);
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00008E49 File Offset: 0x00007049
		protected override byte[] GetRawCertData()
		{
			base.ThrowIfContextInvalid();
			return this.X509.GetRawData(MonoBtlsX509Format.DER);
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600028F RID: 655 RVA: 0x00008E5D File Offset: 0x0000705D
		internal override X509CertificateImplCollection IntermediateCertificates
		{
			get
			{
				return this.intermediateCerts;
			}
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00008E65 File Offset: 0x00007065
		protected override void Dispose(bool disposing)
		{
			if (this.x509 != null)
			{
				this.x509.Dispose();
				this.x509 = null;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000291 RID: 657 RVA: 0x00008E81 File Offset: 0x00007081
		public override bool HasPrivateKey
		{
			get
			{
				return this.nativePrivateKey != null;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000292 RID: 658 RVA: 0x00008E8C File Offset: 0x0000708C
		// (set) Token: 0x06000293 RID: 659 RVA: 0x00008EAC File Offset: 0x000070AC
		public override AsymmetricAlgorithm PrivateKey
		{
			get
			{
				if (this.nativePrivateKey == null)
				{
					return null;
				}
				return PKCS8.PrivateKeyInfo.DecodeRSA(this.nativePrivateKey.GetBytes(true));
			}
			set
			{
				if (this.nativePrivateKey != null)
				{
					this.nativePrivateKey.Dispose();
				}
				try
				{
					if (value != null)
					{
						this.nativePrivateKey = MonoBtlsKey.CreateFromRSAPrivateKey((RSA)value);
					}
				}
				catch
				{
					this.nativePrivateKey = null;
				}
			}
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00008F00 File Offset: 0x00007100
		private void Import(byte[] data)
		{
			if (data != null)
			{
				if (data.Length != 0 && data[0] != 48)
				{
					this.x509 = MonoBtlsX509.LoadFromData(data, MonoBtlsX509Format.PEM);
					return;
				}
				this.x509 = MonoBtlsX509.LoadFromData(data, MonoBtlsX509Format.DER);
			}
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00008F2C File Offset: 0x0000712C
		private void ImportPkcs12(byte[] data, SafePasswordHandle password)
		{
			using (MonoBtlsPkcs12 monoBtlsPkcs = new MonoBtlsPkcs12())
			{
				if (password == null || password.IsInvalid)
				{
					try
					{
						monoBtlsPkcs.Import(data, null);
						goto IL_46;
					}
					catch
					{
						using (SafePasswordHandle safePasswordHandle = new SafePasswordHandle(string.Empty))
						{
							monoBtlsPkcs.Import(data, safePasswordHandle);
						}
						goto IL_46;
					}
				}
				monoBtlsPkcs.Import(data, password);
				IL_46:
				this.x509 = monoBtlsPkcs.GetCertificate(0);
				if (monoBtlsPkcs.HasPrivateKey)
				{
					this.nativePrivateKey = monoBtlsPkcs.GetPrivateKey();
				}
				if (monoBtlsPkcs.Count > 1)
				{
					this.intermediateCerts = new X509CertificateImplCollection();
					for (int i = 0; i < monoBtlsPkcs.Count; i++)
					{
						using (MonoBtlsX509 certificate = monoBtlsPkcs.GetCertificate(i))
						{
							if (MonoBtlsX509.Compare(certificate, this.x509) != 0)
							{
								X509CertificateImplBtls impl = new X509CertificateImplBtls(certificate);
								this.intermediateCerts.Add(impl, true);
							}
						}
					}
				}
			}
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00009040 File Offset: 0x00007240
		private void ImportAuthenticode(byte[] data)
		{
			if (data != null)
			{
				AuthenticodeDeformatter authenticodeDeformatter = new AuthenticodeDeformatter(data);
				this.Import(authenticodeDeformatter.SigningCertificate.RawData);
			}
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00009068 File Offset: 0x00007268
		public override bool Verify(X509Certificate2 thisCertificate)
		{
			bool result;
			using (MonoBtlsX509Chain monoBtlsX509Chain = new MonoBtlsX509Chain())
			{
				monoBtlsX509Chain.AddCertificate(this.x509.Copy());
				if (this.intermediateCerts != null)
				{
					for (int i = 0; i < this.intermediateCerts.Count; i++)
					{
						X509CertificateImplBtls x509CertificateImplBtls = (X509CertificateImplBtls)this.intermediateCerts[i];
						monoBtlsX509Chain.AddCertificate(x509CertificateImplBtls.x509.Copy());
					}
				}
				result = MonoBtlsProvider.ValidateCertificate(monoBtlsX509Chain, null);
			}
			return result;
		}

		// Token: 0x04000150 RID: 336
		private MonoBtlsX509 x509;

		// Token: 0x04000151 RID: 337
		private MonoBtlsKey nativePrivateKey;

		// Token: 0x04000152 RID: 338
		private X509CertificateImplCollection intermediateCerts;
	}
}
