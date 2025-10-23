using System;
using System.IO;
using Android.Graphics;
using Android.Runtime;
using Java.Interop;
using Java.Nio;

namespace Bumptech.Glide.GifDecoder
{
	// Token: 0x0200001A RID: 26
	[Register("com/bumptech/glide/gifdecoder/GifDecoder", "", "Bumptech.Glide.GifDecoder.IGifDecoderInvoker")]
	public interface IGifDecoder : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600009F RID: 159
		int ByteSize { [Register("getByteSize", "()I", "GetGetByteSizeHandler:Bumptech.Glide.GifDecoder.IGifDecoderInvoker, Xamarin.Android.Glide.GifDecoder")] get; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000A0 RID: 160
		int CurrentFrameIndex { [Register("getCurrentFrameIndex", "()I", "GetGetCurrentFrameIndexHandler:Bumptech.Glide.GifDecoder.IGifDecoderInvoker, Xamarin.Android.Glide.GifDecoder")] get; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000A1 RID: 161
		ByteBuffer Data { [Register("getData", "()Ljava/nio/ByteBuffer;", "GetGetDataHandler:Bumptech.Glide.GifDecoder.IGifDecoderInvoker, Xamarin.Android.Glide.GifDecoder")] get; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000A2 RID: 162
		int FrameCount { [Register("getFrameCount", "()I", "GetGetFrameCountHandler:Bumptech.Glide.GifDecoder.IGifDecoderInvoker, Xamarin.Android.Glide.GifDecoder")] get; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000A3 RID: 163
		int Height { [Register("getHeight", "()I", "GetGetHeightHandler:Bumptech.Glide.GifDecoder.IGifDecoderInvoker, Xamarin.Android.Glide.GifDecoder")] get; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000A4 RID: 164
		int LoopCount { [Register("getLoopCount", "()I", "GetGetLoopCountHandler:Bumptech.Glide.GifDecoder.IGifDecoderInvoker, Xamarin.Android.Glide.GifDecoder")] get; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000A5 RID: 165
		int NetscapeLoopCount { [Register("getNetscapeLoopCount", "()I", "GetGetNetscapeLoopCountHandler:Bumptech.Glide.GifDecoder.IGifDecoderInvoker, Xamarin.Android.Glide.GifDecoder")] get; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000A6 RID: 166
		int NextDelay { [Register("getNextDelay", "()I", "GetGetNextDelayHandler:Bumptech.Glide.GifDecoder.IGifDecoderInvoker, Xamarin.Android.Glide.GifDecoder")] get; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000A7 RID: 167
		Bitmap NextFrame { [Register("getNextFrame", "()Landroid/graphics/Bitmap;", "GetGetNextFrameHandler:Bumptech.Glide.GifDecoder.IGifDecoderInvoker, Xamarin.Android.Glide.GifDecoder")] get; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000A8 RID: 168
		int Status { [Register("getStatus", "()I", "GetGetStatusHandler:Bumptech.Glide.GifDecoder.IGifDecoderInvoker, Xamarin.Android.Glide.GifDecoder")] get; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000A9 RID: 169
		int TotalIterationCount { [Register("getTotalIterationCount", "()I", "GetGetTotalIterationCountHandler:Bumptech.Glide.GifDecoder.IGifDecoderInvoker, Xamarin.Android.Glide.GifDecoder")] get; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000AA RID: 170
		int Width { [Register("getWidth", "()I", "GetGetWidthHandler:Bumptech.Glide.GifDecoder.IGifDecoderInvoker, Xamarin.Android.Glide.GifDecoder")] get; }

		// Token: 0x060000AB RID: 171
		[Register("advance", "()V", "GetAdvanceHandler:Bumptech.Glide.GifDecoder.IGifDecoderInvoker, Xamarin.Android.Glide.GifDecoder")]
		void Advance();

		// Token: 0x060000AC RID: 172
		[Register("clear", "()V", "GetClearHandler:Bumptech.Glide.GifDecoder.IGifDecoderInvoker, Xamarin.Android.Glide.GifDecoder")]
		void Clear();

		// Token: 0x060000AD RID: 173
		[Register("getDelay", "(I)I", "GetGetDelay_IHandler:Bumptech.Glide.GifDecoder.IGifDecoderInvoker, Xamarin.Android.Glide.GifDecoder")]
		int GetDelay(int p0);

		// Token: 0x060000AE RID: 174
		[Register("read", "([B)I", "GetRead_arrayBHandler:Bumptech.Glide.GifDecoder.IGifDecoderInvoker, Xamarin.Android.Glide.GifDecoder")]
		int Read(byte[] p0);

		// Token: 0x060000AF RID: 175
		[Register("read", "(Ljava/io/InputStream;I)I", "GetRead_Ljava_io_InputStream_IHandler:Bumptech.Glide.GifDecoder.IGifDecoderInvoker, Xamarin.Android.Glide.GifDecoder")]
		int Read(Stream p0, int p1);

		// Token: 0x060000B0 RID: 176
		[Register("resetFrameIndex", "()V", "GetResetFrameIndexHandler:Bumptech.Glide.GifDecoder.IGifDecoderInvoker, Xamarin.Android.Glide.GifDecoder")]
		void ResetFrameIndex();

		// Token: 0x060000B1 RID: 177
		[Register("setData", "(Lcom/bumptech/glide/gifdecoder/GifHeader;[B)V", "GetSetData_Lcom_bumptech_glide_gifdecoder_GifHeader_arrayBHandler:Bumptech.Glide.GifDecoder.IGifDecoderInvoker, Xamarin.Android.Glide.GifDecoder")]
		void SetData(GifHeader p0, byte[] p1);

		// Token: 0x060000B2 RID: 178
		[Register("setData", "(Lcom/bumptech/glide/gifdecoder/GifHeader;Ljava/nio/ByteBuffer;)V", "GetSetData_Lcom_bumptech_glide_gifdecoder_GifHeader_Ljava_nio_ByteBuffer_Handler:Bumptech.Glide.GifDecoder.IGifDecoderInvoker, Xamarin.Android.Glide.GifDecoder")]
		void SetData(GifHeader p0, ByteBuffer p1);

		// Token: 0x060000B3 RID: 179
		[Register("setData", "(Lcom/bumptech/glide/gifdecoder/GifHeader;Ljava/nio/ByteBuffer;I)V", "GetSetData_Lcom_bumptech_glide_gifdecoder_GifHeader_Ljava_nio_ByteBuffer_IHandler:Bumptech.Glide.GifDecoder.IGifDecoderInvoker, Xamarin.Android.Glide.GifDecoder")]
		void SetData(GifHeader p0, ByteBuffer p1, int p2);

		// Token: 0x060000B4 RID: 180
		[Register("setDefaultBitmapConfig", "(Landroid/graphics/Bitmap$Config;)V", "GetSetDefaultBitmapConfig_Landroid_graphics_Bitmap_Config_Handler:Bumptech.Glide.GifDecoder.IGifDecoderInvoker, Xamarin.Android.Glide.GifDecoder")]
		void SetDefaultBitmapConfig(Bitmap.Config p0);
	}
}
