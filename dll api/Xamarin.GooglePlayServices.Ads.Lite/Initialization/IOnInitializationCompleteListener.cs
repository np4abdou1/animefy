using System;
using Android.Runtime;
using Java.Interop;

namespace Android.Gms.Ads.Initialization
{
	// Token: 0x0200003D RID: 61
	[Register("com/google/android/gms/ads/initialization/OnInitializationCompleteListener", "", "Android.Gms.Ads.Initialization.IOnInitializationCompleteListenerInvoker")]
	public interface IOnInitializationCompleteListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000263 RID: 611
		[Register("onInitializationComplete", "(Lcom/google/android/gms/ads/initialization/InitializationStatus;)V", "GetOnInitializationComplete_Lcom_google_android_gms_ads_initialization_InitializationStatus_Handler:Android.Gms.Ads.Initialization.IOnInitializationCompleteListenerInvoker, Xamarin.GooglePlayServices.Ads.Lite")]
		void OnInitializationComplete(IInitializationStatus p0);
	}
}
