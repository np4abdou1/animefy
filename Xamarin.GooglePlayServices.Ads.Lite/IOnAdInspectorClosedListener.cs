using System;
using Android.Runtime;
using Java.Interop;

namespace Android.Gms.Ads
{
	// Token: 0x02000016 RID: 22
	[Register("com/google/android/gms/ads/OnAdInspectorClosedListener", "", "Android.Gms.Ads.IOnAdInspectorClosedListenerInvoker")]
	public interface IOnAdInspectorClosedListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060000D4 RID: 212
		[Register("onAdInspectorClosed", "(Lcom/google/android/gms/ads/AdInspectorError;)V", "GetOnAdInspectorClosed_Lcom_google_android_gms_ads_AdInspectorError_Handler:Android.Gms.Ads.IOnAdInspectorClosedListenerInvoker, Xamarin.GooglePlayServices.Ads.Lite")]
		void OnAdInspectorClosed(AdInspectorError p0);
	}
}
