using System;
using Android.Runtime;
using Java.Interop;

namespace Android.Gms.Tasks
{
	// Token: 0x02000017 RID: 23
	[Register("com/google/android/gms/tasks/OnTokenCanceledListener", "", "Android.Gms.Tasks.IOnTokenCanceledListenerInvoker")]
	public interface IOnTokenCanceledListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060000D9 RID: 217
		[Register("onCanceled", "()V", "GetOnCanceledHandler:Android.Gms.Tasks.IOnTokenCanceledListenerInvoker, Xamarin.GooglePlayServices.Tasks")]
		void OnCanceled();
	}
}
