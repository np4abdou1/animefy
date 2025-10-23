using System;
using Android.Runtime;
using Java.Interop;

namespace AndroidX.Lifecycle
{
	// Token: 0x02000009 RID: 9
	[Register("androidx/lifecycle/LifecycleObserver", "", "AndroidX.Lifecycle.ILifecycleObserverInvoker")]
	public interface ILifecycleObserver : IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
