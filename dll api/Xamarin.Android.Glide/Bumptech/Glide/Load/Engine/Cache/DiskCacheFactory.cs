using System;
using Android.Runtime;
using Java.Lang;

namespace Bumptech.Glide.Load.Engine.Cache
{
	// Token: 0x02000160 RID: 352
	[Register("com/bumptech/glide/load/engine/cache/DiskCache$Factory", DoNotGenerateAcw = true)]
	public abstract class DiskCacheFactory : Java.Lang.Object
	{
		// Token: 0x060011B4 RID: 4532 RVA: 0x0003979B File Offset: 0x0003799B
		internal DiskCacheFactory()
		{
		}

		// Token: 0x04000410 RID: 1040
		[Register("DEFAULT_DISK_CACHE_DIR")]
		public const string DefaultDiskCacheDir = "image_manager_disk_cache";

		// Token: 0x04000411 RID: 1041
		[Register("DEFAULT_DISK_CACHE_SIZE")]
		public const int DefaultDiskCacheSize = 262144000;
	}
}
