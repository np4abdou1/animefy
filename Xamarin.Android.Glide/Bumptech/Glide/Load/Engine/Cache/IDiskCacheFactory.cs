using System;
using Android.Runtime;
using Java.Interop;

namespace Bumptech.Glide.Load.Engine.Cache
{
	// Token: 0x02000162 RID: 354
	[Register("com/bumptech/glide/load/engine/cache/DiskCache$Factory", "", "Bumptech.Glide.Load.Engine.Cache.IDiskCacheFactoryInvoker")]
	public interface IDiskCacheFactory : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060011B6 RID: 4534
		[Register("build", "()Lcom/bumptech/glide/load/engine/cache/DiskCache;", "GetBuildHandler:Bumptech.Glide.Load.Engine.Cache.IDiskCacheFactoryInvoker, Xamarin.Android.Glide")]
		IDiskCache Build();
	}
}
