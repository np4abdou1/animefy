using System;
using System.Net.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;

namespace Mono.Net.Security
{
	// Token: 0x0200001F RID: 31
	internal abstract class MonoSslAuthenticationOptions
	{
		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000B6 RID: 182
		public abstract bool ServerMode { get; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000B7 RID: 183
		public abstract bool AllowRenegotiation { get; }

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000B8 RID: 184
		// (set) Token: 0x060000B9 RID: 185
		public abstract SslProtocols EnabledSslProtocols { get; set; }

		// Token: 0x17000032 RID: 50
		// (set) Token: 0x060000BA RID: 186
		public abstract EncryptionPolicy EncryptionPolicy { set; }

		// Token: 0x17000033 RID: 51
		// (set) Token: 0x060000BB RID: 187
		public abstract X509RevocationMode CertificateRevocationCheckMode { set; }

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000BC RID: 188
		// (set) Token: 0x060000BD RID: 189
		public abstract string TargetHost { get; set; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000BE RID: 190
		public abstract X509Certificate ServerCertificate { get; }

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000BF RID: 191
		// (set) Token: 0x060000C0 RID: 192
		public abstract X509CertificateCollection ClientCertificates { get; set; }

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000C1 RID: 193
		public abstract bool ClientCertificateRequired { get; }

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00004DA4 File Offset: 0x00002FA4
		internal ServerCertSelectionCallback ServerCertSelectionDelegate { get; }
	}
}
