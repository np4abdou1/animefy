using System;
using System.Runtime.CompilerServices;

namespace System.Diagnostics.CodeAnalysis
{
	// Token: 0x02000099 RID: 153
	[AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
	internal sealed class UnconditionalSuppressMessageAttribute : Attribute
	{
		// Token: 0x06000265 RID: 613 RVA: 0x00002B29 File Offset: 0x00000D29
		public UnconditionalSuppressMessageAttribute(string category, string checkId)
		{
			this.<Category>k__BackingField = category;
			this.<CheckId>k__BackingField = checkId;
		}

		// Token: 0x17000019 RID: 25
		// (set) Token: 0x06000266 RID: 614 RVA: 0x00002B3F File Offset: 0x00000D3F
		public string Justification
		{
			[CompilerGenerated]
			set
			{
				this.<Justification>k__BackingField = value;
			}
		}
	}
}
