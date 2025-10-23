using System;
using Android.Runtime;

namespace Warkiz.Widgets
{
	// Token: 0x0200001D RID: 29
	public enum TickMarkTypes
	{
		// Token: 0x0400008E RID: 142
		[IntDefinition(null, JniField = "com/warkiz/widget/TickMarkType.DIVIDER")]
		Divider = 3,
		// Token: 0x0400008F RID: 143
		[IntDefinition(null, JniField = "com/warkiz/widget/TickMarkType.NONE")]
		None = 0,
		// Token: 0x04000090 RID: 144
		[IntDefinition(null, JniField = "com/warkiz/widget/TickMarkType.OVAL")]
		Oval,
		// Token: 0x04000091 RID: 145
		[IntDefinition(null, JniField = "com/warkiz/widget/TickMarkType.SQUARE")]
		Square
	}
}
