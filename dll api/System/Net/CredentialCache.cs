using System;

namespace System.Net
{
	/// <summary>Provides storage for multiple credentials.</summary>
	// Token: 0x0200014A RID: 330
	public class CredentialCache
	{
		/// <summary>Gets the system credentials of the application.</summary>
		/// <returns>An <see cref="T:System.Net.ICredentials" /> that represents the system credentials of the application.</returns>
		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000948 RID: 2376 RVA: 0x000333D1 File Offset: 0x000315D1
		public static ICredentials DefaultCredentials
		{
			get
			{
				return SystemNetworkCredential.defaultCredential;
			}
		}

		/// <summary>Gets the network credentials of the current security context.</summary>
		/// <returns>An <see cref="T:System.Net.NetworkCredential" /> that represents the network credentials of the current user or application.</returns>
		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000949 RID: 2377 RVA: 0x000333D1 File Offset: 0x000315D1
		public static NetworkCredential DefaultNetworkCredentials
		{
			get
			{
				return SystemNetworkCredential.defaultCredential;
			}
		}
	}
}
