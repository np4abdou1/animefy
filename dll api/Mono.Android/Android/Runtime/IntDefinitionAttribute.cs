using System;
using System.Runtime.CompilerServices;

namespace Android.Runtime
{
	// Token: 0x020002CC RID: 716
	[AttributeUsage(AttributeTargets.Field)]
	public class IntDefinitionAttribute : Attribute
	{
		// Token: 0x06001B12 RID: 6930 RVA: 0x0004698F File Offset: 0x00044B8F
		public IntDefinitionAttribute(string constantMember)
		{
			this.ConstantMember = constantMember;
		}

		// Token: 0x170005CE RID: 1486
		// (set) Token: 0x06001B13 RID: 6931 RVA: 0x0004699E File Offset: 0x00044B9E
		public string ConstantMember
		{
			[CompilerGenerated]
			set
			{
				this.<ConstantMember>k__BackingField = value;
			}
		}

		// Token: 0x170005CF RID: 1487
		// (set) Token: 0x06001B14 RID: 6932 RVA: 0x000469A7 File Offset: 0x00044BA7
		public string JniField
		{
			[CompilerGenerated]
			set
			{
				this.<JniField>k__BackingField = value;
			}
		}
	}
}
