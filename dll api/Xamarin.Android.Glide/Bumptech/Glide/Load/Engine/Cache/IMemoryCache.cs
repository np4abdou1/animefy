using System;
using Android.Runtime;
using Java.Interop;

namespace Bumptech.Glide.Load.Engine.Cache
{
	// Token: 0x0200016C RID: 364
	[Register("com/bumptech/glide/load/engine/cache/MemoryCache", "", "Bumptech.Glide.Load.Engine.Cache.IMemoryCacheInvoker")]
	public interface IMemoryCache : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x060011FB RID: 4603
		long CurrentSize { [Register("getCurrentSize", "()J", "GetGetCurrentSizeHandler:Bumptech.Glide.Load.Engine.Cache.IMemoryCacheInvoker, Xamarin.Android.Glide")] get; }

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x060011FC RID: 4604
		long MaxSize { [Register("getMaxSize", "()J", "GetGetMaxSizeHandler:Bumptech.Glide.Load.Engine.Cache.IMemoryCacheInvoker, Xamarin.Android.Glide")] get; }

		// Token: 0x060011FD RID: 4605
		[Register("clearMemory", "()V", "GetClearMemoryHandler:Bumptech.Glide.Load.Engine.Cache.IMemoryCacheInvoker, Xamarin.Android.Glide")]
		void ClearMemory();

		// Token: 0x060011FE RID: 4606
		[Register("put", "(Lcom/bumptech/glide/load/Key;Lcom/bumptech/glide/load/engine/Resource;)Lcom/bumptech/glide/load/engine/Resource;", "GetPut_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_Handler:Bumptech.Glide.Load.Engine.Cache.IMemoryCacheInvoker, Xamarin.Android.Glide")]
		IResource Put(IKey p0, IResource p1);

		// Token: 0x060011FF RID: 4607
		[Register("remove", "(Lcom/bumptech/glide/load/Key;)Lcom/bumptech/glide/load/engine/Resource;", "GetRemove_Lcom_bumptech_glide_load_Key_Handler:Bumptech.Glide.Load.Engine.Cache.IMemoryCacheInvoker, Xamarin.Android.Glide")]
		IResource Remove(IKey p0);

		// Token: 0x06001200 RID: 4608
		[Register("setResourceRemovedListener", "(Lcom/bumptech/glide/load/engine/cache/MemoryCache$ResourceRemovedListener;)V", "GetSetResourceRemovedListener_Lcom_bumptech_glide_load_engine_cache_MemoryCache_ResourceRemovedListener_Handler:Bumptech.Glide.Load.Engine.Cache.IMemoryCacheInvoker, Xamarin.Android.Glide")]
		void SetResourceRemovedListener(IMemoryCacheResourceRemovedListener p0);

		// Token: 0x06001201 RID: 4609
		[Register("setSizeMultiplier", "(F)V", "GetSetSizeMultiplier_FHandler:Bumptech.Glide.Load.Engine.Cache.IMemoryCacheInvoker, Xamarin.Android.Glide")]
		void SetSizeMultiplier(float p0);

		// Token: 0x06001202 RID: 4610
		[Register("trimMemory", "(I)V", "GetTrimMemory_IHandler:Bumptech.Glide.Load.Engine.Cache.IMemoryCacheInvoker, Xamarin.Android.Glide")]
		void TrimMemory(int p0);
	}
}
