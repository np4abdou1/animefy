using System;
using Android.Runtime;
using Java.Interop;

namespace AndroidX.Lifecycle
{
	// Token: 0x0200000C RID: 12
	[Register("androidx/lifecycle/ViewModelStoreOwner", "", "AndroidX.Lifecycle.IViewModelStoreOwnerInvoker")]
	public interface IViewModelStoreOwner : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000029 RID: 41
		ViewModelStore ViewModelStore { [Register("getViewModelStore", "()Landroidx/lifecycle/ViewModelStore;", "GetGetViewModelStoreHandler:AndroidX.Lifecycle.IViewModelStoreOwnerInvoker, Xamarin.AndroidX.Lifecycle.ViewModel")] get; }
	}
}
