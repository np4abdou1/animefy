using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Applovin.Sdk
{
	// Token: 0x0200007E RID: 126
	[Register("com/applovin/sdk/AppLovinAdService", "", "Com.Applovin.Sdk.IAppLovinAdServiceInvoker")]
	public interface IAppLovinAdService : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000419 RID: 1049
		string BidToken { [Register("getBidToken", "()Ljava/lang/String;", "GetGetBidTokenHandler:Com.Applovin.Sdk.IAppLovinAdServiceInvoker, AppLovin")] get; }

		// Token: 0x0600041A RID: 1050
		[Register("loadNextAd", "(Lcom/applovin/sdk/AppLovinAdSize;Lcom/applovin/sdk/AppLovinAdLoadListener;)V", "GetLoadNextAd_Lcom_applovin_sdk_AppLovinAdSize_Lcom_applovin_sdk_AppLovinAdLoadListener_Handler:Com.Applovin.Sdk.IAppLovinAdServiceInvoker, AppLovin")]
		void LoadNextAd(AppLovinAdSize p0, IAppLovinAdLoadListener p1);

		// Token: 0x0600041B RID: 1051
		[Register("loadNextAdForAdToken", "(Ljava/lang/String;Lcom/applovin/sdk/AppLovinAdLoadListener;)V", "GetLoadNextAdForAdToken_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdLoadListener_Handler:Com.Applovin.Sdk.IAppLovinAdServiceInvoker, AppLovin")]
		void LoadNextAdForAdToken(string p0, IAppLovinAdLoadListener p1);

		// Token: 0x0600041C RID: 1052
		[Register("loadNextAdForZoneId", "(Ljava/lang/String;Lcom/applovin/sdk/AppLovinAdLoadListener;)V", "GetLoadNextAdForZoneId_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdLoadListener_Handler:Com.Applovin.Sdk.IAppLovinAdServiceInvoker, AppLovin")]
		void LoadNextAdForZoneId(string p0, IAppLovinAdLoadListener p1);

		// Token: 0x0600041D RID: 1053
		[Register("loadNextAdForZoneIds", "(Ljava/util/List;Lcom/applovin/sdk/AppLovinAdLoadListener;)V", "GetLoadNextAdForZoneIds_Ljava_util_List_Lcom_applovin_sdk_AppLovinAdLoadListener_Handler:Com.Applovin.Sdk.IAppLovinAdServiceInvoker, AppLovin")]
		void LoadNextAdForZoneIds(IList<string> p0, IAppLovinAdLoadListener p1);
	}
}
