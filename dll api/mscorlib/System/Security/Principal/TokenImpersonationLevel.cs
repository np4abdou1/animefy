﻿using System;

namespace System.Security.Principal
{
	/// <summary>Defines security impersonation levels. Security impersonation levels govern the degree to which a server process can act on behalf of a client process.</summary>
	// Token: 0x020002F5 RID: 757
	public enum TokenImpersonationLevel
	{
		/// <summary>An impersonation level is not assigned.</summary>
		// Token: 0x04000A5C RID: 2652
		None,
		/// <summary>The server process cannot obtain identification information about the client, and it cannot impersonate the client.</summary>
		// Token: 0x04000A5D RID: 2653
		Anonymous,
		/// <summary>The server process can obtain information about the client, such as security identifiers and privileges, but it cannot impersonate the client. This is useful for servers that export their own objects, for example, database products that export tables and views. Using the retrieved client-security information, the server can make access-validation decisions without being able to use other services that are using the client's security context.</summary>
		// Token: 0x04000A5E RID: 2654
		Identification,
		/// <summary>The server process can impersonate the client's security context on its local system. The server cannot impersonate the client on remote systems.</summary>
		// Token: 0x04000A5F RID: 2655
		Impersonation,
		/// <summary>The server process can impersonate the client's security context on remote systems.</summary>
		// Token: 0x04000A60 RID: 2656
		Delegation
	}
}
