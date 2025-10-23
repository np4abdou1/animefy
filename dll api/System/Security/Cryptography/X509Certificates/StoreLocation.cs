using System;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Specifies the location of the X.509 certificate store.</summary>
	// Token: 0x020000E2 RID: 226
	public enum StoreLocation
	{
		/// <summary>The X.509 certificate store used by the current user.</summary>
		// Token: 0x04000456 RID: 1110
		CurrentUser = 1,
		/// <summary>The X.509 certificate store assigned to the local machine.</summary>
		// Token: 0x04000457 RID: 1111
		LocalMachine
	}
}
