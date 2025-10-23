using System;
using System.IO;
using Android.Runtime;
using Bumptech.Glide.Load.Engine.BitmapRecycle;
using Java.Interop;
using Java.Nio;

namespace Bumptech.Glide.Load
{
	// Token: 0x020000D0 RID: 208
	[Register("com/bumptech/glide/load/ImageHeaderParser", "", "Bumptech.Glide.Load.IImageHeaderParserInvoker")]
	public interface IImageHeaderParser : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000AA8 RID: 2728
		[Register("getOrientation", "(Ljava/io/InputStream;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)I", "GetGetOrientation_Ljava_io_InputStream_Lcom_bumptech_glide_load_engine_bitmap_recycle_ArrayPool_Handler:Bumptech.Glide.Load.IImageHeaderParserInvoker, Xamarin.Android.Glide")]
		int GetOrientation(Stream p0, IArrayPool p1);

		// Token: 0x06000AA9 RID: 2729
		[Register("getOrientation", "(Ljava/nio/ByteBuffer;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)I", "GetGetOrientation_Ljava_nio_ByteBuffer_Lcom_bumptech_glide_load_engine_bitmap_recycle_ArrayPool_Handler:Bumptech.Glide.Load.IImageHeaderParserInvoker, Xamarin.Android.Glide")]
		int GetOrientation(ByteBuffer p0, IArrayPool p1);

		// Token: 0x06000AAA RID: 2730
		[Register("getType", "(Ljava/io/InputStream;)Lcom/bumptech/glide/load/ImageHeaderParser$ImageType;", "GetGetType_Ljava_io_InputStream_Handler:Bumptech.Glide.Load.IImageHeaderParserInvoker, Xamarin.Android.Glide")]
		ImageHeaderParserImageType GetType(Stream p0);

		// Token: 0x06000AAB RID: 2731
		[Register("getType", "(Ljava/nio/ByteBuffer;)Lcom/bumptech/glide/load/ImageHeaderParser$ImageType;", "GetGetType_Ljava_nio_ByteBuffer_Handler:Bumptech.Glide.Load.IImageHeaderParserInvoker, Xamarin.Android.Glide")]
		ImageHeaderParserImageType GetType(ByteBuffer p0);
	}
}
