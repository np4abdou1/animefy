using System;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Defines the status of an X509 chain.</summary>
	// Token: 0x020000E5 RID: 229
	[Flags]
	public enum X509ChainStatusFlags
	{
		/// <summary>Specifies that the X509 chain has no errors.</summary>
		// Token: 0x0400046D RID: 1133
		NoError = 0,
		/// <summary>Specifies that the X509 chain is not valid due to an invalid time value, such as a value that indicates an expired certificate.</summary>
		// Token: 0x0400046E RID: 1134
		NotTimeValid = 1,
		/// <summary>Deprecated. Specifies that the CA (certificate authority) certificate and the issued certificate have validity periods that are not nested. For example, the CA cert can be valid from January 1 to December 1 and the issued certificate from January 2 to December 2, which would mean the validity periods are not nested.</summary>
		// Token: 0x0400046F RID: 1135
		NotTimeNested = 2,
		/// <summary>Specifies that the X509 chain is invalid due to a revoked certificate.</summary>
		// Token: 0x04000470 RID: 1136
		Revoked = 4,
		/// <summary>Specifies that the X509 chain is invalid due to an invalid certificate signature.</summary>
		// Token: 0x04000471 RID: 1137
		NotSignatureValid = 8,
		/// <summary>Specifies that the key usage is not valid.</summary>
		// Token: 0x04000472 RID: 1138
		NotValidForUsage = 16,
		/// <summary>Specifies that the X509 chain is invalid due to an untrusted root certificate.</summary>
		// Token: 0x04000473 RID: 1139
		UntrustedRoot = 32,
		/// <summary>Specifies that it is not possible to determine whether the certificate has been revoked. This can be due to the certificate revocation list (CRL) being offline or unavailable.</summary>
		// Token: 0x04000474 RID: 1140
		RevocationStatusUnknown = 64,
		/// <summary>Specifies that the X509 chain could not be built.</summary>
		// Token: 0x04000475 RID: 1141
		Cyclic = 128,
		/// <summary>Specifies that the X509 chain is invalid due to an invalid extension.</summary>
		// Token: 0x04000476 RID: 1142
		InvalidExtension = 256,
		/// <summary>Specifies that the X509 chain is invalid due to invalid policy constraints.</summary>
		// Token: 0x04000477 RID: 1143
		InvalidPolicyConstraints = 512,
		/// <summary>Specifies that the X509 chain is invalid due to invalid basic constraints.</summary>
		// Token: 0x04000478 RID: 1144
		InvalidBasicConstraints = 1024,
		/// <summary>Specifies that the X509 chain is invalid due to invalid name constraints.</summary>
		// Token: 0x04000479 RID: 1145
		InvalidNameConstraints = 2048,
		/// <summary>Specifies that the certificate does not have a supported name constraint or has a name constraint that is unsupported.</summary>
		// Token: 0x0400047A RID: 1146
		HasNotSupportedNameConstraint = 4096,
		/// <summary>Specifies that the certificate has an undefined name constraint.</summary>
		// Token: 0x0400047B RID: 1147
		HasNotDefinedNameConstraint = 8192,
		/// <summary>Specifies that the certificate has an impermissible name constraint.</summary>
		// Token: 0x0400047C RID: 1148
		HasNotPermittedNameConstraint = 16384,
		/// <summary>Specifies that the X509 chain is invalid because a certificate has excluded a name constraint.</summary>
		// Token: 0x0400047D RID: 1149
		HasExcludedNameConstraint = 32768,
		/// <summary>Specifies that the X509 chain could not be built up to the root certificate.</summary>
		// Token: 0x0400047E RID: 1150
		PartialChain = 65536,
		/// <summary>Specifies that the certificate trust list (CTL) is not valid because of an invalid time value, such as one that indicates that the CTL has expired.</summary>
		// Token: 0x0400047F RID: 1151
		CtlNotTimeValid = 131072,
		/// <summary>Specifies that the certificate trust list (CTL) contains an invalid signature.</summary>
		// Token: 0x04000480 RID: 1152
		CtlNotSignatureValid = 262144,
		/// <summary>Specifies that the certificate trust list (CTL) is not valid for this use.</summary>
		// Token: 0x04000481 RID: 1153
		CtlNotValidForUsage = 524288,
		/// <summary>Specifies that the online certificate revocation list (CRL) the X509 chain relies on is currently offline.</summary>
		// Token: 0x04000482 RID: 1154
		OfflineRevocation = 16777216,
		/// <summary>Specifies that there is no certificate policy extension in the certificate. This error would occur if a group policy has specified that all certificates must have a certificate policy.</summary>
		// Token: 0x04000483 RID: 1155
		NoIssuanceChainPolicy = 33554432,
		/// <summary>Specifies that the certificate is explicitly distrusted.</summary>
		// Token: 0x04000484 RID: 1156
		ExplicitDistrust = 67108864,
		/// <summary>Specifies that the certificate does not support a critical extension.</summary>
		// Token: 0x04000485 RID: 1157
		HasNotSupportedCriticalExtension = 134217728,
		/// <summary>Specifies that the certificate has not been strong signed. Typically, this indicates that the MD2 or MD5 hashing algorithms were used to create a hash of the certificate.</summary>
		// Token: 0x04000486 RID: 1158
		HasWeakSignature = 1048576
	}
}
