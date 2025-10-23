using System;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Specifies which X509 certificates in the chain should be checked for revocation.</summary>
	// Token: 0x020000E9 RID: 233
	public enum X509RevocationFlag
	{
		/// <summary>Only the end certificate is checked for revocation.</summary>
		// Token: 0x040004AA RID: 1194
		EndCertificateOnly,
		/// <summary>The entire chain of certificates is checked for revocation.</summary>
		// Token: 0x040004AB RID: 1195
		EntireChain,
		/// <summary>The entire chain, except the root certificate, is checked for revocation.</summary>
		// Token: 0x040004AC RID: 1196
		ExcludeRoot
	}
}
