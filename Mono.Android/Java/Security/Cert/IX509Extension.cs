using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Java.Security.Cert
{
	// Token: 0x0200036D RID: 877
	[Register("java/security/cert/X509Extension", "", "Java.Security.Cert.IX509ExtensionInvoker")]
	public interface IX509Extension : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x060026BC RID: 9916
		ICollection<string> CriticalExtensionOIDs { get; }

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x060026BD RID: 9917
		bool HasUnsupportedCriticalExtension { get; }

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x060026BE RID: 9918
		ICollection<string> NonCriticalExtensionOIDs { get; }

		// Token: 0x060026BF RID: 9919
		byte[] GetExtensionValue(string oid);
	}
}
