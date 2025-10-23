using System;
using Android.Gms.Common.Apis;
using Android.Runtime;
using Java.Interop;

namespace Android.Gms.Common.Api.Internal
{
	// Token: 0x0200002F RID: 47
	[Register("com/google/android/gms/common/api/internal/zau", "", "Android.Gms.Common.Api.Internal.IZauInvoker")]
	public interface IZau : GoogleApiClient.IConnectionCallbacks, IConnectionCallbacks, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600019B RID: 411
		[Register("zaa", "(Lcom/google/android/gms/common/ConnectionResult;Lcom/google/android/gms/common/api/Api;Z)V", "GetZaa_Lcom_google_android_gms_common_ConnectionResult_Lcom_google_android_gms_common_api_Api_ZHandler:Android.Gms.Common.Api.Internal.IZauInvoker, Xamarin.GooglePlayServices.Base")]
		void Zaa(ConnectionResult p0, Api p1, bool p2);
	}
}
