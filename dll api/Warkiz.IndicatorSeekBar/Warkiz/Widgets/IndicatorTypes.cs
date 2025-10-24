using System;
using Android.Runtime;

namespace Warkiz.Widgets
{
	// Token: 0x0200001C RID: 28
	public enum IndicatorTypes
	{
		// Token: 0x04000088 RID: 136
		[IntDefinition(null, JniField = "com/warkiz/widget/TickMarkType.CIRCULAR_BUBBLE")]
		CircularBubble = 1,
		// Token: 0x04000089 RID: 137
		[IntDefinition(null, JniField = "com/warkiz/widget/TickMarkType.CUSTOM")]
		Custom = 4,
		// Token: 0x0400008A RID: 138
		[IntDefinition(null, JniField = "com/warkiz/widget/TickMarkType.NONE")]
		None = 0,
		// Token: 0x0400008B RID: 139
		[IntDefinition(null, JniField = "com/warkiz/widget/TickMarkType.RECTANGLE")]
		Rectangle = 3,
		// Token: 0x0400008C RID: 140
		[IntDefinition(null, JniField = "com/warkiz/widget/TickMarkType.ROUNDED_RECTANGLE")]
		RoundedRectangle = 2
	}
}
