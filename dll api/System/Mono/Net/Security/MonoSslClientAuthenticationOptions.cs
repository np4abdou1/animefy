using System;
using System.Net.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;

namespace Mono.Net.Security
{
	// Token: 0x02000020 RID: 32
	internal sealed class MonoSslClientAuthenticationOptions : MonoSslAuthenticationOptions
	{
		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00004DAC File Offset: 0x00002FAC
		public SslClientAuthenticationOptions Options { get; }

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x000023F6 File Offset: 0x000005F6
		public override bool ServerMode
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00004DB4 File Offset: 0x00002FB4
		public MonoSslClientAuthenticationOptions()
		{
			this.Options = new SslClientAuthenticationOptions();
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x00004DC7 File Offset: 0x00002FC7
		public override bool AllowRenegotiation
		{
			get
			{
				return this.Options.AllowRenegotiation;
			}
		}

		// Token: 0x1700003C RID: 60
		// (set) Token: 0x060000C8 RID: 200 RVA: 0x00004DD4 File Offset: 0x00002FD4
		public override X509RevocationMode CertificateRevocationCheckMode
		{
			set
			{
				this.Options.CertificateRevocationCheckMode = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x00004DE2 File Offset: 0x00002FE2
		public override EncryptionPolicy EncryptionPolicy
		{
			set
			{
				this.Options.EncryptionPolicy = value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00004DF0 File Offset: 0x00002FF0
		// (set) Token: 0x060000CB RID: 203 RVA: 0x00004DFD File Offset: 0x00002FFD
		public override SslProtocols EnabledSslProtocols
		{
			get
			{
				return this.Options.EnabledSslProtocols;
			}
			set
			{
				this.Options.EnabledSslProtocols = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00004E0B File Offset: 0x0000300B
		// (set) Token: 0x060000CD RID: 205 RVA: 0x00004E18 File Offset: 0x00003018
		public override string TargetHost
		{
			get
			{
				return this.Options.TargetHost;
			}
			set
			{
				this.Options.TargetHost = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00003E34 File Offset: 0x00002034
		public override bool ClientCertificateRequired
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00004E26 File Offset: 0x00003026
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x00004E33 File Offset: 0x00003033
		public override X509CertificateCollection ClientCertificates
		{
			get
			{
				return this.Options.ClientCertificates;
			}
			set
			{
				this.Options.ClientCertificates = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00003E34 File Offset: 0x00002034
		public override X509Certificate ServerCertificate
		{
			get
			{
				throw new NotSupportedException();
			}
		}
	}
}
