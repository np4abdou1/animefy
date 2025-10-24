using System;
using System.Diagnostics;

namespace System.Runtime.Versioning
{
	// Token: 0x0200002D RID: 45
	[Conditional("NEVER")]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Event, AllowMultiple = true, Inherited = false)]
	internal sealed class SupportedOSPlatformAttribute : Attribute
	{
		// Token: 0x060000A5 RID: 165 RVA: 0x00002050 File Offset: 0x00000250
		public SupportedOSPlatformAttribute(string platformName)
		{
		}
	}
}
