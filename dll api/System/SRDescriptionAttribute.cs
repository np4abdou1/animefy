using System;
using System.ComponentModel;

namespace System
{
	// Token: 0x02000096 RID: 150
	[AttributeUsage(AttributeTargets.All)]
	internal class SRDescriptionAttribute : DescriptionAttribute
	{
		// Token: 0x060003C5 RID: 965 RVA: 0x00015CC5 File Offset: 0x00013EC5
		public SRDescriptionAttribute(string description) : base(description)
		{
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x00015CCE File Offset: 0x00013ECE
		public override string Description
		{
			get
			{
				if (!this.isReplaced)
				{
					this.isReplaced = true;
					base.DescriptionValue = Locale.GetText(base.DescriptionValue);
				}
				return base.DescriptionValue;
			}
		}

		// Token: 0x0400028F RID: 655
		private bool isReplaced;
	}
}
