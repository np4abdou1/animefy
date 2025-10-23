using System;

namespace System.Net.Security
{
	/// <summary>Enumerates Secure Socket Layer (SSL) policy errors.</summary>
	// Token: 0x02000221 RID: 545
	[Flags]
	public enum SslPolicyErrors
	{
		/// <summary>No SSL policy errors.</summary>
		// Token: 0x04000BD5 RID: 3029
		None = 0,
		/// <summary>Certificate not available.</summary>
		// Token: 0x04000BD6 RID: 3030
		RemoteCertificateNotAvailable = 1,
		/// <summary>Certificate name mismatch.</summary>
		// Token: 0x04000BD7 RID: 3031
		RemoteCertificateNameMismatch = 2,
		/// <summary>
		///     <see cref="P:System.Security.Cryptography.X509Certificates.X509Chain.ChainStatus" /> has returned a non empty array.</summary>
		// Token: 0x04000BD8 RID: 3032
		RemoteCertificateChainErrors = 4
	}
}
