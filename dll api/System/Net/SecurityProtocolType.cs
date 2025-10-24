using System;

namespace System.Net
{
	/// <summary>Specifies the security protocols that are supported by the Schannel security package.</summary>
	// Token: 0x0200012E RID: 302
	[Flags]
	public enum SecurityProtocolType
	{
		/// <summary>Specifies the system default security protocol as defined by Schannel.</summary>
		// Token: 0x04000622 RID: 1570
		SystemDefault = 0,
		/// <summary>Specifies the Secure Socket Layer (SSL) 3.0 security protocol.</summary>
		// Token: 0x04000623 RID: 1571
		Ssl3 = 48,
		/// <summary>Specifies the Transport Layer Security (TLS) 1.0 security protocol.</summary>
		// Token: 0x04000624 RID: 1572
		Tls = 192,
		/// <summary>Specifies the Transport Layer Security (TLS) 1.1 security protocol.</summary>
		// Token: 0x04000625 RID: 1573
		Tls11 = 768,
		/// <summary>Specifies the Transport Layer Security (TLS) 1.2 security protocol.</summary>
		// Token: 0x04000626 RID: 1574
		Tls12 = 3072,
		// Token: 0x04000627 RID: 1575
		Tls13 = 12288
	}
}
