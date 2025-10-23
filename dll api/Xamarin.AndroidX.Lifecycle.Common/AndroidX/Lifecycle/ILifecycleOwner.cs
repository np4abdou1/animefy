using System;
using Android.Runtime;
using Java.Interop;

namespace AndroidX.Lifecycle
{
	// Token: 0x0200000B RID: 11
	[Register("androidx/lifecycle/LifecycleOwner", "", "AndroidX.Lifecycle.ILifecycleOwnerInvoker")]
	public interface ILifecycleOwner : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000035 RID: 53
		Lifecycle Lifecycle { [Register("getLifecycle", "()Landroidx/lifecycle/Lifecycle;", "GetGetLifecycleHandler:AndroidX.Lifecycle.ILifecycleOwnerInvoker, Xamarin.AndroidX.Lifecycle.Common")] get; }
	}
}
