using System;
using System.Runtime.CompilerServices;

namespace Android.Runtime
{
	// Token: 0x020002CB RID: 715
	[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = true)]
	public class IntDefAttribute : Attribute
	{
		// Token: 0x170005CC RID: 1484
		// (set) Token: 0x06001B0F RID: 6927 RVA: 0x0004697D File Offset: 0x00044B7D
		public string Type
		{
			[CompilerGenerated]
			set
			{
				this.<Type>k__BackingField = value;
			}
		}

		// Token: 0x170005CD RID: 1485
		// (set) Token: 0x06001B10 RID: 6928 RVA: 0x00046986 File Offset: 0x00044B86
		public string[] Fields
		{
			[CompilerGenerated]
			set
			{
				this.<Fields>k__BackingField = value;
			}
		}
	}
}
