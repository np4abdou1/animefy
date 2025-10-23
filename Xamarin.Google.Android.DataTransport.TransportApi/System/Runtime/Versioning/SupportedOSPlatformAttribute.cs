using System;
using System.Diagnostics;

namespace System.Runtime.Versioning
{
	// Token: 0x02000008 RID: 8
	[Conditional("NEVER")]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface, AllowMultiple = true, Inherited = false)]
	internal sealed class SupportedOSPlatformAttribute : Attribute
	{
		// Token: 0x06000019 RID: 25 RVA: 0x00002050 File Offset: 0x00000250
		public SupportedOSPlatformAttribute(string platformName)
		{
		}
	}
}
