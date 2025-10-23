using System;

namespace System.Resources
{
	/// <summary>Specifies whether a <see cref="T:System.Resources.ResourceManager" /> object looks for the resources of the app's default culture in the main assembly or in a satellite assembly. </summary>
	// Token: 0x0200047E RID: 1150
	public enum UltimateResourceFallbackLocation
	{
		/// <summary>Fallback resources are located in the main assembly.</summary>
		// Token: 0x04000F92 RID: 3986
		MainAssembly,
		/// <summary>Fallback resources are located in a satellite assembly. </summary>
		// Token: 0x04000F93 RID: 3987
		Satellite
	}
}
