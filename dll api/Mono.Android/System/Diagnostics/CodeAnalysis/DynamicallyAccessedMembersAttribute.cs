using System;

namespace System.Diagnostics.CodeAnalysis
{
	// Token: 0x02000096 RID: 150
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, Inherited = false)]
	internal sealed class DynamicallyAccessedMembersAttribute : Attribute
	{
		// Token: 0x06000263 RID: 611 RVA: 0x00002AFD File Offset: 0x00000CFD
		public DynamicallyAccessedMembersAttribute(DynamicallyAccessedMemberTypes memberTypes)
		{
			this.<MemberTypes>k__BackingField = memberTypes;
		}
	}
}
