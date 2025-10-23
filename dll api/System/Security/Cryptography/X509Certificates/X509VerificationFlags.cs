using System;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Specifies conditions under which verification of certificates in the X509 chain should be conducted.</summary>
	// Token: 0x020000EC RID: 236
	[Flags]
	public enum X509VerificationFlags
	{
		/// <summary>No flags pertaining to verification are included.</summary>
		// Token: 0x040004B6 RID: 1206
		NoFlag = 0,
		/// <summary>Ignore certificates in the chain that are not valid either because they have expired or they are not yet in effect when determining certificate validity.</summary>
		// Token: 0x040004B7 RID: 1207
		IgnoreNotTimeValid = 1,
		/// <summary>Ignore that the certificate trust list (CTL) is not valid, for reasons such as the CTL has expired, when determining certificate verification.</summary>
		// Token: 0x040004B8 RID: 1208
		IgnoreCtlNotTimeValid = 2,
		/// <summary>Ignore that the CA (certificate authority) certificate and the issued certificate have validity periods that are not nested when verifying the certificate. For example, the CA cert can be valid from January 1 to December 1 and the issued certificate from January 2 to December 2, which would mean the validity periods are not nested.</summary>
		// Token: 0x040004B9 RID: 1209
		IgnoreNotTimeNested = 4,
		/// <summary>Ignore that the basic constraints are not valid when determining certificate verification.</summary>
		// Token: 0x040004BA RID: 1210
		IgnoreInvalidBasicConstraints = 8,
		/// <summary>Ignore that the chain cannot be verified due to an unknown certificate authority (CA).</summary>
		// Token: 0x040004BB RID: 1211
		AllowUnknownCertificateAuthority = 16,
		/// <summary>Ignore that the certificate was not issued for the current use when determining certificate verification.</summary>
		// Token: 0x040004BC RID: 1212
		IgnoreWrongUsage = 32,
		/// <summary>Ignore that the certificate has an invalid name when determining certificate verification.</summary>
		// Token: 0x040004BD RID: 1213
		IgnoreInvalidName = 64,
		/// <summary>Ignore that the certificate has invalid policy when determining certificate verification.</summary>
		// Token: 0x040004BE RID: 1214
		IgnoreInvalidPolicy = 128,
		/// <summary>Ignore that the end certificate (the user certificate) revocation is unknown when determining certificate verification.</summary>
		// Token: 0x040004BF RID: 1215
		IgnoreEndRevocationUnknown = 256,
		/// <summary>Ignore that the certificate trust list (CTL) signer revocation is unknown when determining certificate verification.</summary>
		// Token: 0x040004C0 RID: 1216
		IgnoreCtlSignerRevocationUnknown = 512,
		/// <summary>Ignore that the certificate authority revocation is unknown when determining certificate verification.</summary>
		// Token: 0x040004C1 RID: 1217
		IgnoreCertificateAuthorityRevocationUnknown = 1024,
		/// <summary>Ignore that the root revocation is unknown when determining certificate verification.</summary>
		// Token: 0x040004C2 RID: 1218
		IgnoreRootRevocationUnknown = 2048,
		/// <summary>All flags pertaining to verification are included.</summary>
		// Token: 0x040004C3 RID: 1219
		AllFlags = 4095
	}
}
