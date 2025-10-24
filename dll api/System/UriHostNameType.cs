using System;

namespace System
{
	/// <summary>Defines host name types for the <see cref="M:System.Uri.CheckHostName(System.String)" /> method.</summary>
	// Token: 0x02000086 RID: 134
	public enum UriHostNameType
	{
		/// <summary>The type of the host name is not supplied.</summary>
		// Token: 0x0400023E RID: 574
		Unknown,
		/// <summary>The host is set, but the type cannot be determined.</summary>
		// Token: 0x0400023F RID: 575
		Basic,
		/// <summary>The host name is a domain name system (DNS) style host name.</summary>
		// Token: 0x04000240 RID: 576
		Dns,
		/// <summary>The host name is an Internet Protocol (IP) version 4 host address.</summary>
		// Token: 0x04000241 RID: 577
		IPv4,
		/// <summary>The host name is an Internet Protocol (IP) version 6 host address.</summary>
		// Token: 0x04000242 RID: 578
		IPv6
	}
}
