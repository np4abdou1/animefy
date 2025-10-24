using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Data
{
	// Token: 0x02000197 RID: 407
	[Register("com/bumptech/glide/load/data/DataRewinder", "", "Bumptech.Glide.Load.Data.IDataRewinderInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public interface IDataRewinder : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06001490 RID: 5264
		[Register("cleanup", "()V", "GetCleanupHandler:Bumptech.Glide.Load.Data.IDataRewinderInvoker, Xamarin.Android.Glide")]
		void Cleanup();

		// Token: 0x06001491 RID: 5265
		[Register("rewindAndGet", "()Ljava/lang/Object;", "GetRewindAndGetHandler:Bumptech.Glide.Load.Data.IDataRewinderInvoker, Xamarin.Android.Glide")]
		Java.Lang.Object RewindAndGet();
	}
}
