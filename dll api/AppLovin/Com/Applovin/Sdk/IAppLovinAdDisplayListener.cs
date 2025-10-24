using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Applovin.Sdk
{
	// Token: 0x0200006D RID: 109
	[Register("com/applovin/sdk/AppLovinAdDisplayListener", "", "Com.Applovin.Sdk.IAppLovinAdDisplayListenerInvoker")]
	public interface IAppLovinAdDisplayListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060003BC RID: 956
		[Register("adDisplayed", "(Lcom/applovin/sdk/AppLovinAd;)V", "GetAdDisplayed_Lcom_applovin_sdk_AppLovinAd_Handler:Com.Applovin.Sdk.IAppLovinAdDisplayListenerInvoker, AppLovin")]
		void AdDisplayed(IAppLovinAd p0);

		// Token: 0x060003BD RID: 957
		[Register("adHidden", "(Lcom/applovin/sdk/AppLovinAd;)V", "GetAdHidden_Lcom_applovin_sdk_AppLovinAd_Handler:Com.Applovin.Sdk.IAppLovinAdDisplayListenerInvoker, AppLovin")]
		void AdHidden(IAppLovinAd p0);
	}
}
