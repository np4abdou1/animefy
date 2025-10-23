using System;
using Android.Graphics;
using Android.Runtime;
using Java.Interop;

namespace Bumptech.Glide.Load.Engine.BitmapRecycle
{
	// Token: 0x0200017D RID: 381
	[Register("com/bumptech/glide/load/engine/bitmap_recycle/LruPoolStrategy", "", "Bumptech.Glide.Load.Engine.BitmapRecycle.ILruPoolStrategyInvoker")]
	public interface ILruPoolStrategy : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060012FA RID: 4858
		[Register("get", "(IILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;", "GetGet_IILandroid_graphics_Bitmap_Config_Handler:Bumptech.Glide.Load.Engine.BitmapRecycle.ILruPoolStrategyInvoker, Xamarin.Android.Glide")]
		Bitmap Get(int p0, int p1, Bitmap.Config p2);

		// Token: 0x060012FB RID: 4859
		[Register("getSize", "(Landroid/graphics/Bitmap;)I", "GetGetSize_Landroid_graphics_Bitmap_Handler:Bumptech.Glide.Load.Engine.BitmapRecycle.ILruPoolStrategyInvoker, Xamarin.Android.Glide")]
		int GetSize(Bitmap p0);

		// Token: 0x060012FC RID: 4860
		[Register("logBitmap", "(Landroid/graphics/Bitmap;)Ljava/lang/String;", "GetLogBitmap_Landroid_graphics_Bitmap_Handler:Bumptech.Glide.Load.Engine.BitmapRecycle.ILruPoolStrategyInvoker, Xamarin.Android.Glide")]
		string LogBitmap(Bitmap p0);

		// Token: 0x060012FD RID: 4861
		[Register("logBitmap", "(IILandroid/graphics/Bitmap$Config;)Ljava/lang/String;", "GetLogBitmap_IILandroid_graphics_Bitmap_Config_Handler:Bumptech.Glide.Load.Engine.BitmapRecycle.ILruPoolStrategyInvoker, Xamarin.Android.Glide")]
		string LogBitmap(int p0, int p1, Bitmap.Config p2);

		// Token: 0x060012FE RID: 4862
		[Register("put", "(Landroid/graphics/Bitmap;)V", "GetPut_Landroid_graphics_Bitmap_Handler:Bumptech.Glide.Load.Engine.BitmapRecycle.ILruPoolStrategyInvoker, Xamarin.Android.Glide")]
		void Put(Bitmap p0);

		// Token: 0x060012FF RID: 4863
		[Register("removeLast", "()Landroid/graphics/Bitmap;", "GetRemoveLastHandler:Bumptech.Glide.Load.Engine.BitmapRecycle.ILruPoolStrategyInvoker, Xamarin.Android.Glide")]
		Bitmap RemoveLast();
	}
}
