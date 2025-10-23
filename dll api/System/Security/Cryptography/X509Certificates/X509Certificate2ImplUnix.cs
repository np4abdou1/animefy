using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Internal.Cryptography.Pal;
using Microsoft.Win32.SafeHandles;
using Mono.Security.X509;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x020000F5 RID: 245
	internal abstract class X509Certificate2ImplUnix : X509Certificate2Impl
	{
		// Token: 0x060006D1 RID: 1745 RVA: 0x0002849D File Offset: 0x0002669D
		private void EnsureCertData()
		{
			if (this.readCertData)
			{
				return;
			}
			base.ThrowIfContextInvalid();
			this.certData = new CertificateData(this.GetRawCertData());
			this.readCertData = true;
		}

		// Token: 0x060006D2 RID: 1746
		protected abstract byte[] GetRawCertData();

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060006D3 RID: 1747 RVA: 0x000284C6 File Offset: 0x000266C6
		public sealed override string KeyAlgorithm
		{
			get
			{
				this.EnsureCertData();
				return this.certData.PublicKeyAlgorithm.AlgorithmId;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060006D4 RID: 1748 RVA: 0x000284DE File Offset: 0x000266DE
		public sealed override byte[] KeyAlgorithmParameters
		{
			get
			{
				this.EnsureCertData();
				return this.certData.PublicKeyAlgorithm.Parameters;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060006D5 RID: 1749 RVA: 0x000284F6 File Offset: 0x000266F6
		public sealed override byte[] PublicKeyValue
		{
			get
			{
				this.EnsureCertData();
				return this.certData.PublicKey;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060006D6 RID: 1750 RVA: 0x00028509 File Offset: 0x00026709
		public sealed override byte[] SerialNumber
		{
			get
			{
				this.EnsureCertData();
				return this.certData.SerialNumber;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060006D7 RID: 1751 RVA: 0x0002851C File Offset: 0x0002671C
		public sealed override string SignatureAlgorithm
		{
			get
			{
				this.EnsureCertData();
				return this.certData.SignatureAlgorithm.AlgorithmId;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060006D8 RID: 1752 RVA: 0x00028534 File Offset: 0x00026734
		public sealed override int Version
		{
			get
			{
				this.EnsureCertData();
				return this.certData.Version + 1;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060006D9 RID: 1753 RVA: 0x00028549 File Offset: 0x00026749
		public sealed override X500DistinguishedName SubjectName
		{
			get
			{
				this.EnsureCertData();
				return this.certData.Subject;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060006DA RID: 1754 RVA: 0x0002855C File Offset: 0x0002675C
		public sealed override X500DistinguishedName IssuerName
		{
			get
			{
				this.EnsureCertData();
				return this.certData.Issuer;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060006DB RID: 1755 RVA: 0x0002856F File Offset: 0x0002676F
		public sealed override string Subject
		{
			get
			{
				return this.SubjectName.Name;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060006DC RID: 1756 RVA: 0x0002857C File Offset: 0x0002677C
		public sealed override string Issuer
		{
			get
			{
				return this.IssuerName.Name;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060006DD RID: 1757 RVA: 0x00028589 File Offset: 0x00026789
		public sealed override byte[] RawData
		{
			get
			{
				this.EnsureCertData();
				return this.certData.RawData;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060006DE RID: 1758 RVA: 0x0002859C File Offset: 0x0002679C
		public sealed override byte[] Thumbprint
		{
			get
			{
				this.EnsureCertData();
				byte[] result;
				using (SHA1 sha = SHA1.Create())
				{
					result = sha.ComputeHash(this.certData.RawData);
				}
				return result;
			}
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x000285E4 File Offset: 0x000267E4
		public sealed override string GetNameInfo(X509NameType nameType, bool forIssuer)
		{
			this.EnsureCertData();
			return this.certData.GetNameInfo(nameType, forIssuer);
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060006E0 RID: 1760 RVA: 0x000285F9 File Offset: 0x000267F9
		public sealed override IEnumerable<X509Extension> Extensions
		{
			get
			{
				this.EnsureCertData();
				return this.certData.Extensions;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060006E1 RID: 1761 RVA: 0x0002860C File Offset: 0x0002680C
		public sealed override DateTime NotAfter
		{
			get
			{
				this.EnsureCertData();
				return this.certData.NotAfter.ToLocalTime();
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060006E2 RID: 1762 RVA: 0x00028624 File Offset: 0x00026824
		public sealed override DateTime NotBefore
		{
			get
			{
				this.EnsureCertData();
				return this.certData.NotBefore.ToLocalTime();
			}
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x0002863C File Offset: 0x0002683C
		public sealed override void AppendPrivateKeyInfo(StringBuilder sb)
		{
			if (!this.HasPrivateKey)
			{
				return;
			}
			sb.AppendLine();
			sb.AppendLine();
			sb.AppendLine("[Private Key]");
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x00028664 File Offset: 0x00026864
		public sealed override byte[] Export(X509ContentType contentType, SafePasswordHandle password)
		{
			base.ThrowIfContextInvalid();
			switch (contentType)
			{
			case X509ContentType.Cert:
				return this.RawData;
			case X509ContentType.SerializedCert:
			case X509ContentType.SerializedStore:
				throw new PlatformNotSupportedException("X509ContentType.SerializedCert and X509ContentType.SerializedStore are not supported on Unix.");
			case X509ContentType.Pfx:
				return this.ExportPkcs12(password);
			case X509ContentType.Pkcs7:
				return this.ExportPkcs12(null);
			default:
				throw new CryptographicException("Invalid content type.");
			}
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x000286C4 File Offset: 0x000268C4
		private byte[] ExportPkcs12(SafePasswordHandle password)
		{
			if (password == null || password.IsInvalid)
			{
				return this.ExportPkcs12(null);
			}
			string password2 = password.Mono_DangerousGetString();
			return this.ExportPkcs12(password2);
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x000286F4 File Offset: 0x000268F4
		private byte[] ExportPkcs12(string password)
		{
			PKCS12 pkcs = new PKCS12();
			byte[] bytes;
			try
			{
				Hashtable hashtable = new Hashtable();
				ArrayList arrayList = new ArrayList();
				ArrayList arrayList2 = arrayList;
				byte[] array = new byte[4];
				array[0] = 1;
				arrayList2.Add(array);
				hashtable.Add("1.2.840.113549.1.9.21", arrayList);
				if (password != null)
				{
					pkcs.Password = password;
				}
				pkcs.AddCertificate(new X509Certificate(this.RawData), hashtable);
				if (this.IntermediateCertificates != null)
				{
					for (int i = 0; i < this.IntermediateCertificates.Count; i++)
					{
						pkcs.AddCertificate(new X509Certificate(this.IntermediateCertificates[i].RawData));
					}
				}
				AsymmetricAlgorithm privateKey = this.PrivateKey;
				if (privateKey != null)
				{
					pkcs.AddPkcs8ShroudedKeyBag(privateKey, hashtable);
				}
				bytes = pkcs.GetBytes();
			}
			finally
			{
				pkcs.Password = null;
			}
			return bytes;
		}

		// Token: 0x040004DC RID: 1244
		private bool readCertData;

		// Token: 0x040004DD RID: 1245
		private CertificateData certData;
	}
}
