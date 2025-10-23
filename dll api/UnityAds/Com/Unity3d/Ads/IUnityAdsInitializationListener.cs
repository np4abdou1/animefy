using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Ads
{
	// Token: 0x020002C3 RID: 707
	[Register("com/unity3d/ads/IUnityAdsInitializationListener", "", "Com.Unity3d.Ads.IUnityAdsInitializationListenerInvoker")]
	public interface IUnityAdsInitializationListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060027DF RID: 10207
		[Register("onInitializationComplete", "()V", "GetOnInitializationCompleteHandler:Com.Unity3d.Ads.IUnityAdsInitializationListenerInvoker, UnityAds")]
		void OnInitializationComplete();

		// Token: 0x060027E0 RID: 10208
		[Register("onInitializationFailed", "(Lcom/unity3d/ads/UnityAds$UnityAdsInitializationError;Ljava/lang/String;)V", "GetOnInitializationFailed_Lcom_unity3d_ads_UnityAds_UnityAdsInitializationError_Ljava_lang_String_Handler:Com.Unity3d.Ads.IUnityAdsInitializationListenerInvoker, UnityAds")]
		void OnInitializationFailed(UnityAds.UnityAdsInitializationError p0, string p1);
	}
}
