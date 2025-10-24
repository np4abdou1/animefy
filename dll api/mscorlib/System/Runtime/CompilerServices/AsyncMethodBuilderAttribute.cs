using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000436 RID: 1078
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate, Inherited = false, AllowMultiple = false)]
	public sealed class AsyncMethodBuilderAttribute : Attribute
	{
		// Token: 0x06001FE8 RID: 8168 RVA: 0x00087C38 File Offset: 0x00085E38
		public AsyncMethodBuilderAttribute(Type builderType)
		{
			this.<BuilderType>k__BackingField = builderType;
		}
	}
}
