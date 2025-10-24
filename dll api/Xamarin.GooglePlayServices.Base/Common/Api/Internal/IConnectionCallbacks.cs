using System;
using Android.OS;
using Android.Runtime;
using Java.Interop;

namespace Android.Gms.Common.Api.Internal
{
	// Token: 0x02000027 RID: 39
	[Register("com/google/android/gms/common/api/internal/ConnectionCallbacks", "", "Android.Gms.Common.Api.Internal.IConnectionCallbacksInvoker")]
	public interface IConnectionCallbacks : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000163 RID: 355
		[Register("onConnected", "(Landroid/os/Bundle;)V", "GetOnConnected_Landroid_os_Bundle_Handler:Android.Gms.Common.Api.Internal.IConnectionCallbacksInvoker, Xamarin.GooglePlayServices.Base")]
		void OnConnected(Bundle p0);

		// Token: 0x06000164 RID: 356
		[Register("onConnectionSuspended", "(I)V", "GetOnConnectionSuspended_IHandler:Android.Gms.Common.Api.Internal.IConnectionCallbacksInvoker, Xamarin.GooglePlayServices.Base")]
		void OnConnectionSuspended(int p0);
	}
}
