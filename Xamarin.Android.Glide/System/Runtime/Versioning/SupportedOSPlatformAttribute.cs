using System;
using System.Diagnostics;

namespace System.Runtime.Versioning
{
	// Token: 0x02000033 RID: 51
	[Conditional("NEVER")]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface, AllowMultiple = true, Inherited = false)]
	internal sealed class SupportedOSPlatformAttribute : Attribute
	{
		// Token: 0x060000BD RID: 189 RVA: 0x0000208E File Offset: 0x0000028E
		public SupportedOSPlatformAttribute(string platformName)
		{
		}
	}
}
