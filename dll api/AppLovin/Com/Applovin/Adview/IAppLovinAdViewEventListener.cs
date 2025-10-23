using System;
using Android.Runtime;
using Com.Applovin.Sdk;
using Java.Interop;

namespace Com.Applovin.Adview
{
	// Token: 0x02000193 RID: 403
	[Register("com/applovin/adview/AppLovinAdViewEventListener", "", "Com.Applovin.Adview.IAppLovinAdViewEventListenerInvoker")]
	public interface IAppLovinAdViewEventListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060012D6 RID: 4822
		[Register("adClosedFullscreen", "(Lcom/applovin/sdk/AppLovinAd;Lcom/applovin/adview/AppLovinAdView;)V", "GetAdClosedFullscreen_Lcom_applovin_sdk_AppLovinAd_Lcom_applovin_adview_AppLovinAdView_Handler:Com.Applovin.Adview.IAppLovinAdViewEventListenerInvoker, AppLovin")]
		void AdClosedFullscreen(IAppLovinAd p0, AppLovinAdView p1);

		// Token: 0x060012D7 RID: 4823
		[Register("adFailedToDisplay", "(Lcom/applovin/sdk/AppLovinAd;Lcom/applovin/adview/AppLovinAdView;Lcom/applovin/adview/AppLovinAdViewDisplayErrorCode;)V", "GetAdFailedToDisplay_Lcom_applovin_sdk_AppLovinAd_Lcom_applovin_adview_AppLovinAdView_Lcom_applovin_adview_AppLovinAdViewDisplayErrorCode_Handler:Com.Applovin.Adview.IAppLovinAdViewEventListenerInvoker, AppLovin")]
		void AdFailedToDisplay(IAppLovinAd p0, AppLovinAdView p1, AppLovinAdViewDisplayErrorCode p2);

		// Token: 0x060012D8 RID: 4824
		[Register("adLeftApplication", "(Lcom/applovin/sdk/AppLovinAd;Lcom/applovin/adview/AppLovinAdView;)V", "GetAdLeftApplication_Lcom_applovin_sdk_AppLovinAd_Lcom_applovin_adview_AppLovinAdView_Handler:Com.Applovin.Adview.IAppLovinAdViewEventListenerInvoker, AppLovin")]
		void AdLeftApplication(IAppLovinAd p0, AppLovinAdView p1);

		// Token: 0x060012D9 RID: 4825
		[Register("adOpenedFullscreen", "(Lcom/applovin/sdk/AppLovinAd;Lcom/applovin/adview/AppLovinAdView;)V", "GetAdOpenedFullscreen_Lcom_applovin_sdk_AppLovinAd_Lcom_applovin_adview_AppLovinAdView_Handler:Com.Applovin.Adview.IAppLovinAdViewEventListenerInvoker, AppLovin")]
		void AdOpenedFullscreen(IAppLovinAd p0, AppLovinAdView p1);
	}
}
