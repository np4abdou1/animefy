using System;
using Android.Runtime;
using Com.Unity3d.Ads;
using Com.Unity3d.Services.Core.Webview.Bridge;
using Java.Interop;

namespace Com.Unity3d.Services.Ads.Operation.Load
{
	// Token: 0x020001F6 RID: 502
	[Register("com/unity3d/services/ads/operation/load/ILoadModule", "", "Com.Unity3d.Services.Ads.Operation.Load.ILoadModuleInvoker")]
	public interface ILoadModule : IAdModule, IWebViewBridgeSharedObjectStore, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600173E RID: 5950
		[Register("onUnityAdsAdLoaded", "(Ljava/lang/String;)V", "GetOnUnityAdsAdLoaded_Ljava_lang_String_Handler:Com.Unity3d.Services.Ads.Operation.Load.ILoadModuleInvoker, UnityAds")]
		void OnUnityAdsAdLoaded(string p0);

		// Token: 0x0600173F RID: 5951
		[Register("onUnityAdsFailedToLoad", "(Ljava/lang/String;Lcom/unity3d/ads/UnityAds$UnityAdsLoadError;Ljava/lang/String;)V", "GetOnUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_Handler:Com.Unity3d.Services.Ads.Operation.Load.ILoadModuleInvoker, UnityAds")]
		void OnUnityAdsFailedToLoad(string p0, UnityAds.UnityAdsLoadError p1, string p2);
	}
}
