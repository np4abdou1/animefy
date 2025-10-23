using System;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;

namespace System.Net.Security
{
	// Token: 0x0200021B RID: 539
	public class SslClientAuthenticationOptions
	{
		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000EAA RID: 3754 RVA: 0x0004BB61 File Offset: 0x00049D61
		public bool AllowRenegotiation
		{
			get
			{
				return this._allowRenegotiation;
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000EAB RID: 3755 RVA: 0x0004BB69 File Offset: 0x00049D69
		// (set) Token: 0x06000EAC RID: 3756 RVA: 0x0004BB71 File Offset: 0x00049D71
		public string TargetHost { get; set; }

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000EAD RID: 3757 RVA: 0x0004BB7A File Offset: 0x00049D7A
		// (set) Token: 0x06000EAE RID: 3758 RVA: 0x0004BB82 File Offset: 0x00049D82
		public X509CertificateCollection ClientCertificates { get; set; }

		// Token: 0x170002F1 RID: 753
		// (set) Token: 0x06000EAF RID: 3759 RVA: 0x0004BB8B File Offset: 0x00049D8B
		public X509RevocationMode CertificateRevocationCheckMode
		{
			set
			{
				if (value != X509RevocationMode.NoCheck && value != X509RevocationMode.Offline && value != X509RevocationMode.Online)
				{
					throw new ArgumentException(SR.Format("The specified value is not valid in the '{0}' enumeration.", "X509RevocationMode"), "value");
				}
				this._checkCertificateRevocation = value;
			}
		}

		// Token: 0x170002F2 RID: 754
		// (set) Token: 0x06000EB0 RID: 3760 RVA: 0x0004BBB9 File Offset: 0x00049DB9
		public EncryptionPolicy EncryptionPolicy
		{
			set
			{
				if (value != EncryptionPolicy.RequireEncryption && value != EncryptionPolicy.AllowNoEncryption && value != EncryptionPolicy.NoEncryption)
				{
					throw new ArgumentException(SR.Format("The specified value is not valid in the '{0}' enumeration.", "EncryptionPolicy"), "value");
				}
				this._encryptionPolicy = value;
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000EB1 RID: 3761 RVA: 0x0004BBE7 File Offset: 0x00049DE7
		// (set) Token: 0x06000EB2 RID: 3762 RVA: 0x0004BBEF File Offset: 0x00049DEF
		public SslProtocols EnabledSslProtocols
		{
			get
			{
				return this._enabledSslProtocols;
			}
			set
			{
				this._enabledSslProtocols = value;
			}
		}

		// Token: 0x04000BC4 RID: 3012
		private EncryptionPolicy _encryptionPolicy;

		// Token: 0x04000BC5 RID: 3013
		private X509RevocationMode _checkCertificateRevocation;

		// Token: 0x04000BC6 RID: 3014
		private SslProtocols _enabledSslProtocols;

		// Token: 0x04000BC7 RID: 3015
		private bool _allowRenegotiation = true;
	}
}
