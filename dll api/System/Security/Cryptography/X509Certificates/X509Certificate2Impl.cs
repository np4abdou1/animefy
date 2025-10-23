using System;
using System.Collections.Generic;
using System.Text;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x020000F3 RID: 243
	internal abstract class X509Certificate2Impl : X509CertificateImpl
	{
		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060006B5 RID: 1717
		public abstract IEnumerable<X509Extension> Extensions { get; }

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060006B6 RID: 1718
		public abstract X500DistinguishedName IssuerName { get; }

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060006B7 RID: 1719
		// (set) Token: 0x060006B8 RID: 1720
		public abstract AsymmetricAlgorithm PrivateKey { get; set; }

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060006B9 RID: 1721
		public abstract string SignatureAlgorithm { get; }

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060006BA RID: 1722
		public abstract X500DistinguishedName SubjectName { get; }

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060006BB RID: 1723
		public abstract int Version { get; }

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060006BC RID: 1724
		internal abstract X509CertificateImplCollection IntermediateCertificates { get; }

		// Token: 0x060006BD RID: 1725
		public abstract string GetNameInfo(X509NameType nameType, bool forIssuer);

		// Token: 0x060006BE RID: 1726
		public abstract bool Verify(X509Certificate2 thisCertificate);

		// Token: 0x060006BF RID: 1727
		public abstract void AppendPrivateKeyInfo(StringBuilder sb);
	}
}
