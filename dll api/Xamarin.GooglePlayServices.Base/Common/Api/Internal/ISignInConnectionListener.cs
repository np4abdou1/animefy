using System;
using Android.Runtime;
using Java.Interop;

namespace Android.Gms.Common.Api.Internal
{
	// Token: 0x0200002D RID: 45
	[Register("com/google/android/gms/common/api/internal/SignInConnectionListener", "", "Android.Gms.Common.Api.Internal.ISignInConnectionListenerInvoker")]
	public interface ISignInConnectionListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600018E RID: 398
		[Register("onComplete", "()V", "GetOnCompleteHandler:Android.Gms.Common.Api.Internal.ISignInConnectionListenerInvoker, Xamarin.GooglePlayServices.Base")]
		void OnComplete();
	}
}
