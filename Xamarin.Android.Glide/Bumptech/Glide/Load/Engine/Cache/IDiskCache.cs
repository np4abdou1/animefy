using System;
using Android.Runtime;
using Java.Interop;
using Java.IO;

namespace Bumptech.Glide.Load.Engine.Cache
{
	// Token: 0x02000166 RID: 358
	[Register("com/bumptech/glide/load/engine/cache/DiskCache", "", "Bumptech.Glide.Load.Engine.Cache.IDiskCacheInvoker")]
	public interface IDiskCache : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060011D0 RID: 4560
		[Register("clear", "()V", "GetClearHandler:Bumptech.Glide.Load.Engine.Cache.IDiskCacheInvoker, Xamarin.Android.Glide")]
		void Clear();

		// Token: 0x060011D1 RID: 4561
		[Register("delete", "(Lcom/bumptech/glide/load/Key;)V", "GetDelete_Lcom_bumptech_glide_load_Key_Handler:Bumptech.Glide.Load.Engine.Cache.IDiskCacheInvoker, Xamarin.Android.Glide")]
		void Delete(IKey p0);

		// Token: 0x060011D2 RID: 4562
		[Register("get", "(Lcom/bumptech/glide/load/Key;)Ljava/io/File;", "GetGet_Lcom_bumptech_glide_load_Key_Handler:Bumptech.Glide.Load.Engine.Cache.IDiskCacheInvoker, Xamarin.Android.Glide")]
		File Get(IKey p0);

		// Token: 0x060011D3 RID: 4563
		[Register("put", "(Lcom/bumptech/glide/load/Key;Lcom/bumptech/glide/load/engine/cache/DiskCache$Writer;)V", "GetPut_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_cache_DiskCache_Writer_Handler:Bumptech.Glide.Load.Engine.Cache.IDiskCacheInvoker, Xamarin.Android.Glide")]
		void Put(IKey p0, IDiskCacheWriter p1);
	}
}
