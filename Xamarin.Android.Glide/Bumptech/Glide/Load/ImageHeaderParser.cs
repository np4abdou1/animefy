using System;
using Android.Runtime;
using Java.Lang;

namespace Bumptech.Glide.Load
{
	// Token: 0x020000CE RID: 206
	[Register("com/bumptech/glide/load/ImageHeaderParser", DoNotGenerateAcw = true)]
	public abstract class ImageHeaderParser : Java.Lang.Object
	{
		// Token: 0x06000AA6 RID: 2726 RVA: 0x00021117 File Offset: 0x0001F317
		internal ImageHeaderParser()
		{
		}

		// Token: 0x04000298 RID: 664
		[Register("UNKNOWN_ORIENTATION")]
		public const int UnknownOrientation = -1;
	}
}
