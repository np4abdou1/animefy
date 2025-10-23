using System;
using Android.Runtime;
using Java.Interop;

namespace Android.Gms.Tasks
{
	// Token: 0x0200000F RID: 15
	[Register("com/google/android/gms/tasks/OnCanceledListener", "", "Android.Gms.Tasks.IOnCanceledListenerInvoker")]
	public interface IOnCanceledListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060000A5 RID: 165
		[Register("onCanceled", "()V", "GetOnCanceledHandler:Android.Gms.Tasks.IOnCanceledListenerInvoker, Xamarin.GooglePlayServices.Tasks")]
		void OnCanceled();
	}
}
