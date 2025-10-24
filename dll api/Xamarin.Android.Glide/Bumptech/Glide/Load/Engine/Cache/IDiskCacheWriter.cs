using System;
using Android.Runtime;
using Java.Interop;
using Java.IO;

namespace Bumptech.Glide.Load.Engine.Cache
{
	// Token: 0x02000164 RID: 356
	[Register("com/bumptech/glide/load/engine/cache/DiskCache$Writer", "", "Bumptech.Glide.Load.Engine.Cache.IDiskCacheWriterInvoker")]
	public interface IDiskCacheWriter : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060011C3 RID: 4547
		[Register("write", "(Ljava/io/File;)Z", "GetWrite_Ljava_io_File_Handler:Bumptech.Glide.Load.Engine.Cache.IDiskCacheWriterInvoker, Xamarin.Android.Glide")]
		bool Write(File p0);
	}
}
