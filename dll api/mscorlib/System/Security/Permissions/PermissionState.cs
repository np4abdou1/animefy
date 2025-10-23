using System;

namespace System.Security.Permissions
{
	/// <summary>Specifies whether a permission should have all or no access to resources at creation.</summary>
	// Token: 0x02000294 RID: 660
	public enum PermissionState
	{
		/// <summary>No access to the resource protected by the permission.</summary>
		// Token: 0x040008FE RID: 2302
		None,
		/// <summary>Full access to the resource protected by the permission.</summary>
		// Token: 0x040008FF RID: 2303
		Unrestricted
	}
}
