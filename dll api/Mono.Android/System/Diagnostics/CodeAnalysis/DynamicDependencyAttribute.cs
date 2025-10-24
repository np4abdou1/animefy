using System;

namespace System.Diagnostics.CodeAnalysis
{
	// Token: 0x02000098 RID: 152
	[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Field, AllowMultiple = true, Inherited = false)]
	internal sealed class DynamicDependencyAttribute : Attribute
	{
		// Token: 0x06000264 RID: 612 RVA: 0x00002B0C File Offset: 0x00000D0C
		public DynamicDependencyAttribute(DynamicallyAccessedMemberTypes memberTypes, string typeName, string assemblyName)
		{
			this.<MemberTypes>k__BackingField = memberTypes;
			this.<TypeName>k__BackingField = typeName;
			this.<AssemblyName>k__BackingField = assemblyName;
		}
	}
}
