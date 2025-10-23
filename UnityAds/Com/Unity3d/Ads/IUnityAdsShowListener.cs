using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Ads
{
	// Token: 0x020002CC RID: 716
	[Register("com/unity3d/ads/IUnityAdsShowListener", "", "Com.Unity3d.Ads.IUnityAdsShowListenerInvoker")]
	public interface IUnityAdsShowListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06002812 RID: 10258
		[Register("onUnityAdsShowClick", "(Ljava/lang/String;)V", "GetOnUnityAdsShowClick_Ljava_lang_String_Handler:Com.Unity3d.Ads.IUnityAdsShowListenerInvoker, UnityAds")]
		void OnUnityAdsShowClick(string p0);

		// Token: 0x06002813 RID: 10259
		[Register("onUnityAdsShowComplete", "(Ljava/lang/String;Lcom/unity3d/ads/UnityAds$UnityAdsShowCompletionState;)V", "GetOnUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_Handler:Com.Unity3d.Ads.IUnityAdsShowListenerInvoker, UnityAds")]
		void OnUnityAdsShowComplete(string p0, UnityAds.UnityAdsShowCompletionState p1);

		// Token: 0x06002814 RID: 10260
		[Register("onUnityAdsShowFailure", "(Ljava/lang/String;Lcom/unity3d/ads/UnityAds$UnityAdsShowError;Ljava/lang/String;)V", "GetOnUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_Handler:Com.Unity3d.Ads.IUnityAdsShowListenerInvoker, UnityAds")]
		void OnUnityAdsShowFailure(string p0, UnityAds.UnityAdsShowError p1, string p2);

		// Token: 0x06002815 RID: 10261
		[Register("onUnityAdsShowStart", "(Ljava/lang/String;)V", "GetOnUnityAdsShowStart_Ljava_lang_String_Handler:Com.Unity3d.Ads.IUnityAdsShowListenerInvoker, UnityAds")]
		void OnUnityAdsShowStart(string p0);
	}
}
