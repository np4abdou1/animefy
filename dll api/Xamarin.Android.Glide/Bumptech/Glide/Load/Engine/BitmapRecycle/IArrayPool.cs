using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Engine.BitmapRecycle
{
	// Token: 0x02000179 RID: 377
	[Register("com/bumptech/glide/load/engine/bitmap_recycle/ArrayPool", "", "Bumptech.Glide.Load.Engine.BitmapRecycle.IArrayPoolInvoker")]
	public interface IArrayPool : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060012B4 RID: 4788
		[Register("clearMemory", "()V", "GetClearMemoryHandler:Bumptech.Glide.Load.Engine.BitmapRecycle.IArrayPoolInvoker, Xamarin.Android.Glide")]
		void ClearMemory();

		// Token: 0x060012B5 RID: 4789
		[Register("get", "(ILjava/lang/Class;)Ljava/lang/Object;", "GetGet_ILjava_lang_Class_Handler:Bumptech.Glide.Load.Engine.BitmapRecycle.IArrayPoolInvoker, Xamarin.Android.Glide")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		Java.Lang.Object Get(int p0, Class p1);

		// Token: 0x060012B6 RID: 4790
		[Register("getExact", "(ILjava/lang/Class;)Ljava/lang/Object;", "GetGetExact_ILjava_lang_Class_Handler:Bumptech.Glide.Load.Engine.BitmapRecycle.IArrayPoolInvoker, Xamarin.Android.Glide")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		Java.Lang.Object GetExact(int p0, Class p1);

		// Token: 0x060012B7 RID: 4791
		[Register("put", "(Ljava/lang/Object;)V", "GetPut_Ljava_lang_Object_Handler:Bumptech.Glide.Load.Engine.BitmapRecycle.IArrayPoolInvoker, Xamarin.Android.Glide")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		void Put(Java.Lang.Object p0);

		// Token: 0x060012B8 RID: 4792
		[Obsolete("deprecated")]
		[Register("put", "(Ljava/lang/Object;Ljava/lang/Class;)V", "GetPut_Ljava_lang_Object_Ljava_lang_Class_Handler:Bumptech.Glide.Load.Engine.BitmapRecycle.IArrayPoolInvoker, Xamarin.Android.Glide")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		void Put(Java.Lang.Object p0, Class p1);

		// Token: 0x060012B9 RID: 4793
		[Register("trimMemory", "(I)V", "GetTrimMemory_IHandler:Bumptech.Glide.Load.Engine.BitmapRecycle.IArrayPoolInvoker, Xamarin.Android.Glide")]
		void TrimMemory(int p0);
	}
}
