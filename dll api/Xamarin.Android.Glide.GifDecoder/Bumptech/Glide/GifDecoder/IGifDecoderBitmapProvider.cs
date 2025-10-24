using System;
using Android.Graphics;
using Android.Runtime;
using Java.Interop;

namespace Bumptech.Glide.GifDecoder
{
	// Token: 0x02000014 RID: 20
	[Register("com/bumptech/glide/gifdecoder/GifDecoder$BitmapProvider", "", "Bumptech.Glide.GifDecoder.IGifDecoderBitmapProviderInvoker")]
	public interface IGifDecoderBitmapProvider : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000067 RID: 103
		[Register("obtain", "(IILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;", "GetObtain_IILandroid_graphics_Bitmap_Config_Handler:Bumptech.Glide.GifDecoder.IGifDecoderBitmapProviderInvoker, Xamarin.Android.Glide.GifDecoder")]
		Bitmap Obtain(int p0, int p1, Bitmap.Config p2);

		// Token: 0x06000068 RID: 104
		[Register("obtainByteArray", "(I)[B", "GetObtainByteArray_IHandler:Bumptech.Glide.GifDecoder.IGifDecoderBitmapProviderInvoker, Xamarin.Android.Glide.GifDecoder")]
		byte[] ObtainByteArray(int p0);

		// Token: 0x06000069 RID: 105
		[Register("obtainIntArray", "(I)[I", "GetObtainIntArray_IHandler:Bumptech.Glide.GifDecoder.IGifDecoderBitmapProviderInvoker, Xamarin.Android.Glide.GifDecoder")]
		int[] ObtainIntArray(int p0);

		// Token: 0x0600006A RID: 106
		[Register("release", "(Landroid/graphics/Bitmap;)V", "GetRelease_Landroid_graphics_Bitmap_Handler:Bumptech.Glide.GifDecoder.IGifDecoderBitmapProviderInvoker, Xamarin.Android.Glide.GifDecoder")]
		void Release(Bitmap p0);

		// Token: 0x0600006B RID: 107
		[Register("release", "([B)V", "GetRelease_arrayBHandler:Bumptech.Glide.GifDecoder.IGifDecoderBitmapProviderInvoker, Xamarin.Android.Glide.GifDecoder")]
		void Release(byte[] p0);

		// Token: 0x0600006C RID: 108
		[Register("release", "([I)V", "GetRelease_arrayIHandler:Bumptech.Glide.GifDecoder.IGifDecoderBitmapProviderInvoker, Xamarin.Android.Glide.GifDecoder")]
		void Release(int[] p0);
	}
}
