﻿using System;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Specifies the type of name the X509 certificate contains.</summary>
	// Token: 0x020000E8 RID: 232
	public enum X509NameType
	{
		/// <summary>The simple name of a subject or issuer of an X509 certificate.</summary>
		// Token: 0x040004A3 RID: 1187
		SimpleName,
		/// <summary>The email address of the subject or issuer associated of an X509 certificate.</summary>
		// Token: 0x040004A4 RID: 1188
		EmailName,
		/// <summary>The UPN name of the subject or issuer of an X509 certificate.</summary>
		// Token: 0x040004A5 RID: 1189
		UpnName,
		/// <summary>The DNS name associated with the alternative name of either the subject or issuer of an X509 certificate.</summary>
		// Token: 0x040004A6 RID: 1190
		DnsName,
		/// <summary>The DNS name associated with the alternative name of either the subject or the issuer of an X.509 certificate.  This value is equivalent to the <see cref="F:System.Security.Cryptography.X509Certificates.X509NameType.DnsName" /> value.</summary>
		// Token: 0x040004A7 RID: 1191
		DnsFromAlternativeName,
		/// <summary>The URL address associated with the alternative name of either the subject or issuer of an X509 certificate.</summary>
		// Token: 0x040004A8 RID: 1192
		UrlName
	}
}
