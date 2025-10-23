using System;
using Android.Runtime;
using Java.Lang;

namespace Bumptech.Glide.GifDecoder
{
	// Token: 0x02000018 RID: 24
	[Register("com/bumptech/glide/gifdecoder/GifDecoder", DoNotGenerateAcw = true)]
	public abstract class GifDecoder : Java.Lang.Object
	{
		// Token: 0x0600009D RID: 157 RVA: 0x00002FA8 File Offset: 0x000011A8
		internal GifDecoder()
		{
		}

		// Token: 0x04000027 RID: 39
		[Register("STATUS_FORMAT_ERROR")]
		public const int StatusFormatError = 1;

		// Token: 0x04000028 RID: 40
		[Register("STATUS_OK")]
		public const int StatusOk = 0;

		// Token: 0x04000029 RID: 41
		[Register("STATUS_OPEN_ERROR")]
		public const int StatusOpenError = 2;

		// Token: 0x0400002A RID: 42
		[Register("STATUS_PARTIAL_DECODE")]
		public const int StatusPartialDecode = 3;

		// Token: 0x0400002B RID: 43
		[Register("TOTAL_ITERATION_COUNT_FOREVER")]
		public const int TotalIterationCountForever = 0;
	}
}
