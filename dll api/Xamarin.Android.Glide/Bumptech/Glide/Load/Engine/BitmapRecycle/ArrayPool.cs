using System;
using Android.Runtime;
using Java.Lang;

namespace Bumptech.Glide.Load.Engine.BitmapRecycle
{
	// Token: 0x02000177 RID: 375
	[Register("com/bumptech/glide/load/engine/bitmap_recycle/ArrayPool", DoNotGenerateAcw = true)]
	public abstract class ArrayPool : Java.Lang.Object
	{
		// Token: 0x060012B2 RID: 4786 RVA: 0x0003C0CB File Offset: 0x0003A2CB
		internal ArrayPool()
		{
		}

		// Token: 0x0400045F RID: 1119
		[Register("STANDARD_BUFFER_SIZE_BYTES")]
		public const int StandardBufferSizeBytes = 65536;
	}
}
