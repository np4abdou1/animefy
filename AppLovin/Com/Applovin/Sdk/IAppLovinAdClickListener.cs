using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Applovin.Sdk
{
	// Token: 0x02000069 RID: 105
	[Register("com/applovin/sdk/AppLovinAdClickListener", "", "Com.Applovin.Sdk.IAppLovinAdClickListenerInvoker")]
	public interface IAppLovinAdClickListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060003AA RID: 938
		[Register("adClicked", "(Lcom/applovin/sdk/AppLovinAd;)V", "GetAdClicked_Lcom_applovin_sdk_AppLovinAd_Handler:Com.Applovin.Sdk.IAppLovinAdClickListenerInvoker, AppLovin")]
		void AdClicked(IAppLovinAd p0);
	}
}
