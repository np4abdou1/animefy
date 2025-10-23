using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Applovin.Sdk
{
	// Token: 0x02000072 RID: 114
	[Register("com/applovin/sdk/AppLovinAdLoadListener", "", "Com.Applovin.Sdk.IAppLovinAdLoadListenerInvoker")]
	public interface IAppLovinAdLoadListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060003D5 RID: 981
		[Register("adReceived", "(Lcom/applovin/sdk/AppLovinAd;)V", "GetAdReceived_Lcom_applovin_sdk_AppLovinAd_Handler:Com.Applovin.Sdk.IAppLovinAdLoadListenerInvoker, AppLovin")]
		void AdReceived(IAppLovinAd p0);

		// Token: 0x060003D6 RID: 982
		[Register("failedToReceiveAd", "(I)V", "GetFailedToReceiveAd_IHandler:Com.Applovin.Sdk.IAppLovinAdLoadListenerInvoker, AppLovin")]
		void FailedToReceiveAd(int p0);
	}
}
