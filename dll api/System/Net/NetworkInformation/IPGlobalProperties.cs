using System;

namespace System.Net.NetworkInformation
{
	/// <summary>Provides information about the network connectivity of the local computer.</summary>
	// Token: 0x020001EA RID: 490
	public abstract class IPGlobalProperties
	{
		/// <summary>Gets an object that provides information about the local computer's network connectivity and traffic statistics.</summary>
		/// <returns>A <see cref="T:System.Net.NetworkInformation.IPGlobalProperties" /> object that contains information about the local computer.</returns>
		// Token: 0x06000D53 RID: 3411 RVA: 0x00046786 File Offset: 0x00044986
		public static IPGlobalProperties GetIPGlobalProperties()
		{
			return IPGlobalPropertiesFactoryPal.Create();
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x0004678D File Offset: 0x0004498D
		internal static IPGlobalProperties InternalGetIPGlobalProperties()
		{
			return IPGlobalProperties.GetIPGlobalProperties();
		}

		/// <summary>Gets the domain in which the local computer is registered.</summary>
		/// <returns>A <see cref="T:System.String" /> instance that contains the computer's domain name. If the computer does not belong to a domain, returns <see cref="F:System.String.Empty" />.</returns>
		/// <exception cref="T:System.Net.NetworkInformation.NetworkInformationException">A Win32 function call failed. </exception>
		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000D55 RID: 3413
		public abstract string DomainName { get; }
	}
}
