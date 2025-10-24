using System;
using Android.Runtime;
using Java.Interop;

namespace Android.Gms.Ads
{
	// Token: 0x02000018 RID: 24
	[Register("com/google/android/gms/ads/OnPaidEventListener", "", "Android.Gms.Ads.IOnPaidEventListenerInvoker")]
	public interface IOnPaidEventListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060000E1 RID: 225
		[Register("onPaidEvent", "(Lcom/google/android/gms/ads/AdValue;)V", "GetOnPaidEvent_Lcom_google_android_gms_ads_AdValue_Handler:Android.Gms.Ads.IOnPaidEventListenerInvoker, Xamarin.GooglePlayServices.Ads.Lite")]
		void OnPaidEvent(AdValue p0);
	}
}
