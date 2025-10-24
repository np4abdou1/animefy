using System;

namespace System.Security.Principal
{
	/// <summary>Defines the basic functionality of an identity object.</summary>
	// Token: 0x020002F3 RID: 755
	public interface IIdentity
	{
		/// <summary>Gets the name of the current user.</summary>
		/// <returns>The name of the user on whose behalf the code is running.</returns>
		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06001908 RID: 6408
		string Name { get; }

		/// <summary>Gets the type of authentication used.</summary>
		/// <returns>The type of authentication used to identify the user.</returns>
		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06001909 RID: 6409
		string AuthenticationType { get; }
	}
}
