using System;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Specifies the name of the X.509 certificate store to open.</summary>
	// Token: 0x020000E3 RID: 227
	public enum StoreName
	{
		/// <summary>The X.509 certificate store for other users.</summary>
		// Token: 0x04000459 RID: 1113
		AddressBook = 1,
		/// <summary>The X.509 certificate store for third-party certificate authorities (CAs).</summary>
		// Token: 0x0400045A RID: 1114
		AuthRoot,
		/// <summary>The X.509 certificate store for intermediate certificate authorities (CAs). </summary>
		// Token: 0x0400045B RID: 1115
		CertificateAuthority,
		/// <summary>The X.509 certificate store for revoked certificates.</summary>
		// Token: 0x0400045C RID: 1116
		Disallowed,
		/// <summary>The X.509 certificate store for personal certificates.</summary>
		// Token: 0x0400045D RID: 1117
		My,
		/// <summary>The X.509 certificate store for trusted root certificate authorities (CAs).</summary>
		// Token: 0x0400045E RID: 1118
		Root,
		/// <summary>The X.509 certificate store for directly trusted people and resources.</summary>
		// Token: 0x0400045F RID: 1119
		TrustedPeople,
		/// <summary>The X.509 certificate store for directly trusted publishers.</summary>
		// Token: 0x04000460 RID: 1120
		TrustedPublisher
	}
}
