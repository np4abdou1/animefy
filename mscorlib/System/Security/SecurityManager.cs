using System;
using System.Runtime.InteropServices;

namespace System.Security
{
	/// <summary>Provides the main access point for classes interacting with the security system. This class cannot be inherited.</summary>
	// Token: 0x02000288 RID: 648
	[ComVisible(true)]
	public static class SecurityManager
	{
		/// <summary>Gets or sets a value indicating whether security is enabled.</summary>
		/// <returns>
		///     <see langword="true" /> if security is enabled; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">The code that calls this method does not have <see cref="F:System.Security.Permissions.SecurityPermissionFlag.ControlPolicy" />. </exception>
		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06001693 RID: 5779 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public static bool SecurityEnabled
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06001694 RID: 5780 RVA: 0x00002A7D File Offset: 0x00000C7D
		internal static void EnsureElevatedPermissions()
		{
		}
	}
}
