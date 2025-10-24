using System;
using Android.Runtime;
using Java.Interop;

namespace AndroidX.Activity.Result
{
	// Token: 0x02000029 RID: 41
	[Register("androidx/activity/result/ActivityResultRegistryOwner", "", "AndroidX.Activity.Result.IActivityResultRegistryOwnerInvoker")]
	public interface IActivityResultRegistryOwner : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600013B RID: 315
		ActivityResultRegistry ActivityResultRegistry { [Register("getActivityResultRegistry", "()Landroidx/activity/result/ActivityResultRegistry;", "GetGetActivityResultRegistryHandler:AndroidX.Activity.Result.IActivityResultRegistryOwnerInvoker, Xamarin.AndroidX.Activity")] get; }
	}
}
