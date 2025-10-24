using System;
using Android.Runtime;
using Java.Lang;

namespace Warkiz.Widgets
{
	// Token: 0x02000007 RID: 7
	[Register("com/warkiz/widget/IndicatorType", DoNotGenerateAcw = true)]
	public abstract class IndicatorType : Java.Lang.Object
	{
		// Token: 0x060000AD RID: 173 RVA: 0x00003F92 File Offset: 0x00002192
		internal IndicatorType()
		{
		}

		// Token: 0x04000036 RID: 54
		[Register("CIRCULAR_BUBBLE")]
		public const int CircularBubble = 1;

		// Token: 0x04000037 RID: 55
		[Register("CUSTOM")]
		public const int Custom = 4;

		// Token: 0x04000038 RID: 56
		[Register("NONE")]
		public const int None = 0;

		// Token: 0x04000039 RID: 57
		[Register("RECTANGLE")]
		public const int Rectangle = 3;

		// Token: 0x0400003A RID: 58
		[Register("ROUNDED_RECTANGLE")]
		public const int RoundedRectangle = 2;
	}
}
