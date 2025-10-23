using System;
using Android.Runtime;
using AndroidX.Lifecycle;
using Java.Interop;

namespace AndroidX.Activity
{
	// Token: 0x02000016 RID: 22
	[Register("androidx/activity/OnBackPressedDispatcherOwner", "", "AndroidX.Activity.IOnBackPressedDispatcherOwnerInvoker")]
	public interface IOnBackPressedDispatcherOwner : ILifecycleOwner, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600009A RID: 154
		OnBackPressedDispatcher OnBackPressedDispatcher { [Register("getOnBackPressedDispatcher", "()Landroidx/activity/OnBackPressedDispatcher;", "GetGetOnBackPressedDispatcherHandler:AndroidX.Activity.IOnBackPressedDispatcherOwnerInvoker, Xamarin.AndroidX.Activity")] get; }
	}
}
