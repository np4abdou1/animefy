using System;
using Android.Runtime;
using Java.Lang;

namespace Warkiz.Widgets
{
	// Token: 0x02000018 RID: 24
	[Register("com/warkiz/widget/TickMarkType", DoNotGenerateAcw = true)]
	public abstract class TickMarkType : Java.Lang.Object
	{
		// Token: 0x06000177 RID: 375 RVA: 0x00003F92 File Offset: 0x00002192
		internal TickMarkType()
		{
		}

		// Token: 0x04000081 RID: 129
		[Register("DIVIDER")]
		public const int Divider = 3;

		// Token: 0x04000082 RID: 130
		[Register("NONE")]
		public const int None = 0;

		// Token: 0x04000083 RID: 131
		[Register("OVAL")]
		public const int Oval = 1;

		// Token: 0x04000084 RID: 132
		[Register("SQUARE")]
		public const int Square = 2;
	}
}
