using System;

namespace System.Security.Authentication
{
	/// <summary>Defines the possible versions of <see cref="T:System.Security.Authentication.SslProtocols" />.</summary>
	// Token: 0x020000D7 RID: 215
	[Flags]
	public enum SslProtocols
	{
		/// <summary>No SSL protocol is specified.</summary>
		// Token: 0x04000411 RID: 1041
		None = 0,
		/// <summary>Specifies the SSL 2.0 protocol. SSL 2.0 has been superseded by the TLS protocol and is provided for backward compatibility only.</summary>
		// Token: 0x04000412 RID: 1042
		Ssl2 = 12,
		/// <summary>Specifies the SSL 3.0 protocol. SSL 3.0 has been superseded by the TLS protocol and is provided for backward compatibility only.</summary>
		// Token: 0x04000413 RID: 1043
		Ssl3 = 48,
		/// <summary>Specifies the TLS 1.0 security protocol. The TLS protocol is defined in IETF RFC 2246.</summary>
		// Token: 0x04000414 RID: 1044
		Tls = 192,
		/// <summary>Specifies the TLS 1.1 security protocol. The TLS protocol is defined in IETF RFC 4346.</summary>
		// Token: 0x04000415 RID: 1045
		Tls11 = 768,
		/// <summary>Specifies the TLS 1.2 security protocol. The TLS protocol is defined in IETF RFC 5246.</summary>
		// Token: 0x04000416 RID: 1046
		Tls12 = 3072,
		// Token: 0x04000417 RID: 1047
		Tls13 = 12288,
		/// <summary>Specifies that either Secure Sockets Layer (SSL) 3.0 or Transport Layer Security (TLS) 1.0 are acceptable for secure communications</summary>
		// Token: 0x04000418 RID: 1048
		Default = 240
	}
}
