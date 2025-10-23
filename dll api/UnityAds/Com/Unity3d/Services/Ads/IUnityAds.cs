using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Com.Unity3d.Ads;
using Java.Interop;

namespace Com.Unity3d.Services.Ads
{
	// Token: 0x020001CB RID: 459
	[Register("com/unity3d/services/ads/IUnityAds", "", "Com.Unity3d.Services.Ads.IUnityAdsInvoker")]
	public interface IUnityAds : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x06001480 RID: 5248
		// (set) Token: 0x06001481 RID: 5249
		bool DebugMode { [Register("getDebugMode", "()Z", "GetGetDebugModeHandler:Com.Unity3d.Services.Ads.IUnityAdsInvoker, UnityAds")] get; [Register("setDebugMode", "(Z)V", "GetSetDebugMode_ZHandler:Com.Unity3d.Services.Ads.IUnityAdsInvoker, UnityAds")] set; }

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x06001482 RID: 5250
		bool IsInitialized { [Register("isInitialized", "()Z", "GetIsInitializedHandler:Com.Unity3d.Services.Ads.IUnityAdsInvoker, UnityAds")] get; }

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x06001483 RID: 5251
		bool IsSupported { [Register("isSupported", "()Z", "GetIsSupportedHandler:Com.Unity3d.Services.Ads.IUnityAdsInvoker, UnityAds")] get; }

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x06001484 RID: 5252
		string Token { [Register("getToken", "()Ljava/lang/String;", "GetGetTokenHandler:Com.Unity3d.Services.Ads.IUnityAdsInvoker, UnityAds")] get; }

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x06001485 RID: 5253
		string Version { [Register("getVersion", "()Ljava/lang/String;", "GetGetVersionHandler:Com.Unity3d.Services.Ads.IUnityAdsInvoker, UnityAds")] get; }

		// Token: 0x06001486 RID: 5254
		[Register("getToken", "(Lcom/unity3d/ads/IUnityAdsTokenListener;)V", "GetGetToken_Lcom_unity3d_ads_IUnityAdsTokenListener_Handler:Com.Unity3d.Services.Ads.IUnityAdsInvoker, UnityAds")]
		void GetToken(IUnityAdsTokenListener p0);

		// Token: 0x06001487 RID: 5255
		[Register("initialize", "(Landroid/content/Context;Ljava/lang/String;ZLcom/unity3d/ads/IUnityAdsInitializationListener;)V", "GetInitialize_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_ads_IUnityAdsInitializationListener_Handler:Com.Unity3d.Services.Ads.IUnityAdsInvoker, UnityAds")]
		void Initialize(Context p0, string p1, bool p2, IUnityAdsInitializationListener p3);

		// Token: 0x06001488 RID: 5256
		[Register("load", "(Ljava/lang/String;Lcom/unity3d/ads/UnityAdsLoadOptions;Lcom/unity3d/ads/IUnityAdsLoadListener;)V", "GetLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAdsLoadOptions_Lcom_unity3d_ads_IUnityAdsLoadListener_Handler:Com.Unity3d.Services.Ads.IUnityAdsInvoker, UnityAds")]
		void Load(string p0, UnityAdsLoadOptions p1, IUnityAdsLoadListener p2);

		// Token: 0x06001489 RID: 5257
		[Register("show", "(Landroid/app/Activity;Ljava/lang/String;Lcom/unity3d/ads/UnityAdsShowOptions;Lcom/unity3d/ads/IUnityAdsShowListener;)V", "GetShow_Landroid_app_Activity_Ljava_lang_String_Lcom_unity3d_ads_UnityAdsShowOptions_Lcom_unity3d_ads_IUnityAdsShowListener_Handler:Com.Unity3d.Services.Ads.IUnityAdsInvoker, UnityAds")]
		void Show(Activity p0, string p1, UnityAdsShowOptions p2, IUnityAdsShowListener p3);
	}
}
