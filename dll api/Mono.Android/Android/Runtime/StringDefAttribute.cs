using System;
using System.Runtime.CompilerServices;

namespace Android.Runtime
{
	// Token: 0x020002F6 RID: 758
	[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = true)]
	public class StringDefAttribute : Attribute
	{
		// Token: 0x17000616 RID: 1558
		// (set) Token: 0x06001E01 RID: 7681 RVA: 0x00051F36 File Offset: 0x00050136
		public string Type
		{
			[CompilerGenerated]
			set
			{
				this.<Type>k__BackingField = value;
			}
		}

		// Token: 0x17000617 RID: 1559
		// (set) Token: 0x06001E02 RID: 7682 RVA: 0x00051F3F File Offset: 0x0005013F
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
