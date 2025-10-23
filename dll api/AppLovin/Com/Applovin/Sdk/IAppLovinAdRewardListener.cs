using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Applovin.Sdk
{
	// Token: 0x02000077 RID: 119
	[Register("com/applovin/sdk/AppLovinAdRewardListener", "", "Com.Applovin.Sdk.IAppLovinAdRewardListenerInvoker")]
	public interface IAppLovinAdRewardListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060003EE RID: 1006
		[Register("userOverQuota", "(Lcom/applovin/sdk/AppLovinAd;Ljava/util/Map;)V", "GetUserOverQuota_Lcom_applovin_sdk_AppLovinAd_Ljava_util_Map_Handler:Com.Applovin.Sdk.IAppLovinAdRewardListenerInvoker, AppLovin")]
		void UserOverQuota(IAppLovinAd p0, IDictionary<string, string> p1);

		// Token: 0x060003EF RID: 1007
		[Register("userRewardRejected", "(Lcom/applovin/sdk/AppLovinAd;Ljava/util/Map;)V", "GetUserRewardRejected_Lcom_applovin_sdk_AppLovinAd_Ljava_util_Map_Handler:Com.Applovin.Sdk.IAppLovinAdRewardListenerInvoker, AppLovin")]
		void UserRewardRejected(IAppLovinAd p0, IDictionary<string, string> p1);

		// Token: 0x060003F0 RID: 1008
		[Register("userRewardVerified", "(Lcom/applovin/sdk/AppLovinAd;Ljava/util/Map;)V", "GetUserRewardVerified_Lcom_applovin_sdk_AppLovinAd_Ljava_util_Map_Handler:Com.Applovin.Sdk.IAppLovinAdRewardListenerInvoker, AppLovin")]
		void UserRewardVerified(IAppLovinAd p0, IDictionary<string, string> p1);

		// Token: 0x060003F1 RID: 1009
		[Register("validationRequestFailed", "(Lcom/applovin/sdk/AppLovinAd;I)V", "GetValidationRequestFailed_Lcom_applovin_sdk_AppLovinAd_IHandler:Com.Applovin.Sdk.IAppLovinAdRewardListenerInvoker, AppLovin")]
		void ValidationRequestFailed(IAppLovinAd p0, int p1);
	}
}
