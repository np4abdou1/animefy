using System;
using Android.Runtime;
using Java.Interop;

namespace Bumptech.Glide.Manager
{
	// Token: 0x0200007B RID: 123
	[Register("com/bumptech/glide/manager/LifecycleListener", "", "Bumptech.Glide.Manager.ILifecycleListenerInvoker")]
	public interface ILifecycleListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000535 RID: 1333
		[Register("onDestroy", "()V", "GetOnDestroyHandler:Bumptech.Glide.Manager.ILifecycleListenerInvoker, Xamarin.Android.Glide")]
		void OnDestroy();

		// Token: 0x06000536 RID: 1334
		[Register("onStart", "()V", "GetOnStartHandler:Bumptech.Glide.Manager.ILifecycleListenerInvoker, Xamarin.Android.Glide")]
		void OnStart();

		// Token: 0x06000537 RID: 1335
		[Register("onStop", "()V", "GetOnStopHandler:Bumptech.Glide.Manager.ILifecycleListenerInvoker, Xamarin.Android.Glide")]
		void OnStop();
	}
}
