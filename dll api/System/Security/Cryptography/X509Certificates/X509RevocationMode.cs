using System;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Specifies the mode used to check for X509 certificate revocation.</summary>
	// Token: 0x020000EA RID: 234
	public enum X509RevocationMode
	{
		/// <summary>No revocation check is performed on the certificate.</summary>
		// Token: 0x040004AE RID: 1198
		NoCheck,
		/// <summary>A revocation check is made using an online certificate revocation list (CRL).</summary>
		// Token: 0x040004AF RID: 1199
		Online,
		/// <summary>A revocation check is made using a cached certificate revocation list (CRL).</summary>
		// Token: 0x040004B0 RID: 1200
		Offline
	}
}
