using System;
using Android.Runtime;
using Com.Unity3d.Ads;
using Com.Unity3d.Services.Core.Webview.Bridge;
using Java.Interop;

namespace Com.Unity3d.Services.Ads.Operation.Show
{
	// Token: 0x020001ED RID: 493
	[Register("com/unity3d/services/ads/operation/show/IShowModule", "", "Com.Unity3d.Services.Ads.Operation.Show.IShowModuleInvoker")]
	public interface IShowModule : IAdModule, IWebViewBridgeSharedObjectStore, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06001676 RID: 5750
		[Register("onUnityAdsShowClick", "(Ljava/lang/String;)V", "GetOnUnityAdsShowClick_Ljava_lang_String_Handler:Com.Unity3d.Services.Ads.Operation.Show.IShowModuleInvoker, UnityAds")]
		void OnUnityAdsShowClick(string p0);

		// Token: 0x06001677 RID: 5751
		[Register("onUnityAdsShowComplete", "(Ljava/lang/String;Lcom/unity3d/ads/UnityAds$UnityAdsShowCompletionState;)V", "GetOnUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_Handler:Com.Unity3d.Services.Ads.Operation.Show.IShowModuleInvoker, UnityAds")]
		void OnUnityAdsShowComplete(string p0, UnityAds.UnityAdsShowCompletionState p1);

		// Token: 0x06001678 RID: 5752
		[Register("onUnityAdsShowConsent", "(Ljava/lang/String;)V", "GetOnUnityAdsShowConsent_Ljava_lang_String_Handler:Com.Unity3d.Services.Ads.Operation.Show.IShowModuleInvoker, UnityAds")]
		void OnUnityAdsShowConsent(string p0);

		// Token: 0x06001679 RID: 5753
		[Register("onUnityAdsShowFailure", "(Ljava/lang/String;Lcom/unity3d/ads/UnityAds$UnityAdsShowError;Ljava/lang/String;)V", "GetOnUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_Handler:Com.Unity3d.Services.Ads.Operation.Show.IShowModuleInvoker, UnityAds")]
		void OnUnityAdsShowFailure(string p0, UnityAds.UnityAdsShowError p1, string p2);

		// Token: 0x0600167A RID: 5754
		[Register("onUnityAdsShowStart", "(Ljava/lang/String;)V", "GetOnUnityAdsShowStart_Ljava_lang_String_Handler:Com.Unity3d.Services.Ads.Operation.Show.IShowModuleInvoker, UnityAds")]
		void OnUnityAdsShowStart(string p0);
	}
}
