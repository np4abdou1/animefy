using System;
using Android.Runtime;
using Java.Interop;

namespace Bumptech.Glide.Manager
{
	// Token: 0x02000079 RID: 121
	[Register("com/bumptech/glide/manager/Lifecycle", "", "Bumptech.Glide.Manager.ILifecycleInvoker")]
	public interface ILifecycle : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000524 RID: 1316
		[Register("addListener", "(Lcom/bumptech/glide/manager/LifecycleListener;)V", "GetAddListener_Lcom_bumptech_glide_manager_LifecycleListener_Handler:Bumptech.Glide.Manager.ILifecycleInvoker, Xamarin.Android.Glide")]
		void AddListener(ILifecycleListener p0);

		// Token: 0x06000525 RID: 1317
		[Register("removeListener", "(Lcom/bumptech/glide/manager/LifecycleListener;)V", "GetRemoveListener_Lcom_bumptech_glide_manager_LifecycleListener_Handler:Bumptech.Glide.Manager.ILifecycleInvoker, Xamarin.Android.Glide")]
		void RemoveListener(ILifecycleListener p0);
	}
}
