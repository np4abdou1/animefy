using System;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Specifies the format of an X.509 certificate. </summary>
	// Token: 0x020002EE RID: 750
	public enum X509ContentType
	{
		/// <summary>An unknown X.509 certificate.  </summary>
		// Token: 0x04000A41 RID: 2625
		Unknown,
		/// <summary>A single X.509 certificate.</summary>
		// Token: 0x04000A42 RID: 2626
		Cert,
		/// <summary>A single serialized X.509 certificate. </summary>
		// Token: 0x04000A43 RID: 2627
		SerializedCert,
		/// <summary>A PFX-formatted certificate. The <see langword="Pfx" /> value is identical to the <see langword="Pkcs12" /> value.</summary>
		// Token: 0x04000A44 RID: 2628
		Pfx,
		/// <summary>A PKCS #12–formatted certificate. The <see langword="Pkcs12" /> value is identical to the <see langword="Pfx" /> value.</summary>
		// Token: 0x04000A45 RID: 2629
		Pkcs12 = 3,
		/// <summary>A serialized store.</summary>
		// Token: 0x04000A46 RID: 2630
		SerializedStore,
		/// <summary>A PKCS #7–formatted certificate.</summary>
		// Token: 0x04000A47 RID: 2631
		Pkcs7,
		/// <summary>An Authenticode X.509 certificate. </summary>
		// Token: 0x04000A48 RID: 2632
		Authenticode
	}
}
