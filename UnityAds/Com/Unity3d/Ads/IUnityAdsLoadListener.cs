using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Ads
{
	// Token: 0x020002C7 RID: 711
	[Register("com/unity3d/ads/IUnityAdsLoadListener", "", "Com.Unity3d.Ads.IUnityAdsLoadListenerInvoker")]
	public interface IUnityAdsLoadListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060027F7 RID: 10231
		[Register("onUnityAdsAdLoaded", "(Ljava/lang/String;)V", "GetOnUnityAdsAdLoaded_Ljava_lang_String_Handler:Com.Unity3d.Ads.IUnityAdsLoadListenerInvoker, UnityAds")]
		void OnUnityAdsAdLoaded(string p0);

		// Token: 0x060027F8 RID: 10232
		[Register("onUnityAdsFailedToLoad", "(Ljava/lang/String;Lcom/unity3d/ads/UnityAds$UnityAdsLoadError;Ljava/lang/String;)V", "GetOnUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_Handler:Com.Unity3d.Ads.IUnityAdsLoadListenerInvoker, UnityAds")]
		void OnUnityAdsFailedToLoad(string p0, UnityAds.UnityAdsLoadError p1, string p2);
	}
}
