using System;
using Android.Runtime;
using Java.Interop;

namespace Bumptech.Glide.Load.Engine.Cache
{
	// Token: 0x02000168 RID: 360
	[Register("com/bumptech/glide/load/engine/cache/MemoryCache$ResourceRemovedListener", "", "Bumptech.Glide.Load.Engine.Cache.IMemoryCacheResourceRemovedListenerInvoker")]
	public interface IMemoryCacheResourceRemovedListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060011E9 RID: 4585
		[Register("onResourceRemoved", "(Lcom/bumptech/glide/load/engine/Resource;)V", "GetOnResourceRemoved_Lcom_bumptech_glide_load_engine_Resource_Handler:Bumptech.Glide.Load.Engine.Cache.IMemoryCacheResourceRemovedListenerInvoker, Xamarin.Android.Glide")]
		void OnResourceRemoved(IResource p0);
	}
}
