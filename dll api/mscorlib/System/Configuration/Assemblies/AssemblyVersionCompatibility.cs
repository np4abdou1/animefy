using System;

namespace System.Configuration.Assemblies
{
	/// <summary>Defines the different types of assembly version compatibility. This feature is not available in version 1.0 of the .NET Framework.</summary>
	// Token: 0x020005CE RID: 1486
	public enum AssemblyVersionCompatibility
	{
		/// <summary>The assembly cannot execute with other versions if they are executing on the same machine.</summary>
		// Token: 0x0400185E RID: 6238
		SameMachine = 1,
		/// <summary>The assembly cannot execute with other versions if they are executing in the same process.</summary>
		// Token: 0x0400185F RID: 6239
		SameProcess,
		/// <summary>The assembly cannot execute with other versions if they are executing in the same application domain.</summary>
		// Token: 0x04001860 RID: 6240
		SameDomain
	}
}
