using System;
using Android.Graphics;
using Android.Runtime;
using Java.Interop;

namespace Bumptech.Glide.Load.Engine.BitmapRecycle
{
	// Token: 0x0200017B RID: 379
	[Register("com/bumptech/glide/load/engine/bitmap_recycle/BitmapPool", "", "Bumptech.Glide.Load.Engine.BitmapRecycle.IBitmapPoolInvoker")]
	public interface IBitmapPool : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x060012D5 RID: 4821
		long MaxSize { [Register("getMaxSize", "()J", "GetGetMaxSizeHandler:Bumptech.Glide.Load.Engine.BitmapRecycle.IBitmapPoolInvoker, Xamarin.Android.Glide")] get; }

		// Token: 0x060012D6 RID: 4822
		[Register("clearMemory", "()V", "GetClearMemoryHandler:Bumptech.Glide.Load.Engine.BitmapRecycle.IBitmapPoolInvoker, Xamarin.Android.Glide")]
		void ClearMemory();

		// Token: 0x060012D7 RID: 4823
		[Register("get", "(IILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;", "GetGet_IILandroid_graphics_Bitmap_Config_Handler:Bumptech.Glide.Load.Engine.BitmapRecycle.IBitmapPoolInvoker, Xamarin.Android.Glide")]
		Bitmap Get(int p0, int p1, Bitmap.Config p2);

		// Token: 0x060012D8 RID: 4824
		[Register("getDirty", "(IILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;", "GetGetDirty_IILandroid_graphics_Bitmap_Config_Handler:Bumptech.Glide.Load.Engine.BitmapRecycle.IBitmapPoolInvoker, Xamarin.Android.Glide")]
		Bitmap GetDirty(int p0, int p1, Bitmap.Config p2);

		// Token: 0x060012D9 RID: 4825
		[Register("put", "(Landroid/graphics/Bitmap;)V", "GetPut_Landroid_graphics_Bitmap_Handler:Bumptech.Glide.Load.Engine.BitmapRecycle.IBitmapPoolInvoker, Xamarin.Android.Glide")]
		void Put(Bitmap p0);

		// Token: 0x060012DA RID: 4826
		[Register("setSizeMultiplier", "(F)V", "GetSetSizeMultiplier_FHandler:Bumptech.Glide.Load.Engine.BitmapRecycle.IBitmapPoolInvoker, Xamarin.Android.Glide")]
		void SetSizeMultiplier(float p0);

		// Token: 0x060012DB RID: 4827
		[Register("trimMemory", "(I)V", "GetTrimMemory_IHandler:Bumptech.Glide.Load.Engine.BitmapRecycle.IBitmapPoolInvoker, Xamarin.Android.Glide")]
		void TrimMemory(int p0);
	}
}
