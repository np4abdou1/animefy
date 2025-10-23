using System;
using Android.Runtime;
using Java.Interop;

namespace Android.Gms.Common.Api.Internal
{
	// Token: 0x02000029 RID: 41
	[Register("com/google/android/gms/common/api/internal/OnConnectionFailedListener", "", "Android.Gms.Common.Api.Internal.IOnConnectionFailedListenerInvoker")]
	public interface IOnConnectionFailedListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000174 RID: 372
		[Register("onConnectionFailed", "(Lcom/google/android/gms/common/ConnectionResult;)V", "GetOnConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_Handler:Android.Gms.Common.Api.Internal.IOnConnectionFailedListenerInvoker, Xamarin.GooglePlayServices.Base")]
		void OnConnectionFailed(ConnectionResult p0);
	}
}
