using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Runtime.Versioning
{
	// Token: 0x0200003E RID: 62
	[Conditional("NEVER")]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface, AllowMultiple = true, Inherited = false)]
	internal sealed class SupportedOSPlatformAttribute : Attribute
	{
		// Token: 0x060000E6 RID: 230 RVA: 0x0000209D File Offset: 0x0000029D
		[NullableContext(1)]
		public SupportedOSPlatformAttribute(string platformName)
		{
		}
	}
}
