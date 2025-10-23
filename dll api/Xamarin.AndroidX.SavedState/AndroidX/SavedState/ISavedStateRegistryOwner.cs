using System;
using Android.Runtime;
using AndroidX.Lifecycle;
using Java.Interop;

namespace AndroidX.SavedState
{
	// Token: 0x02000006 RID: 6
	[Register("androidx/savedstate/SavedStateRegistryOwner", "", "AndroidX.SavedState.ISavedStateRegistryOwnerInvoker")]
	public interface ISavedStateRegistryOwner : ILifecycleOwner, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000008 RID: 8
		SavedStateRegistry SavedStateRegistry { [Register("getSavedStateRegistry", "()Landroidx/savedstate/SavedStateRegistry;", "GetGetSavedStateRegistryHandler:AndroidX.SavedState.ISavedStateRegistryOwnerInvoker, Xamarin.AndroidX.SavedState")] get; }
	}
}
