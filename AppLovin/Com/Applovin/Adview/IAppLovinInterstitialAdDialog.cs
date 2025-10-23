using System;
using Android.Runtime;
using Com.Applovin.Sdk;
using Java.Interop;

namespace Com.Applovin.Adview
{
	// Token: 0x0200019A RID: 410
	[Register("com/applovin/adview/AppLovinInterstitialAdDialog", "", "Com.Applovin.Adview.IAppLovinInterstitialAdDialogInvoker")]
	public interface IAppLovinInterstitialAdDialog : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06001302 RID: 4866
		[Register("setAdClickListener", "(Lcom/applovin/sdk/AppLovinAdClickListener;)V", "GetSetAdClickListener_Lcom_applovin_sdk_AppLovinAdClickListener_Handler:Com.Applovin.Adview.IAppLovinInterstitialAdDialogInvoker, AppLovin")]
		void SetAdClickListener(IAppLovinAdClickListener p0);

		// Token: 0x06001303 RID: 4867
		[Register("setAdDisplayListener", "(Lcom/applovin/sdk/AppLovinAdDisplayListener;)V", "GetSetAdDisplayListener_Lcom_applovin_sdk_AppLovinAdDisplayListener_Handler:Com.Applovin.Adview.IAppLovinInterstitialAdDialogInvoker, AppLovin")]
		void SetAdDisplayListener(IAppLovinAdDisplayListener p0);

		// Token: 0x06001304 RID: 4868
		[Register("setAdLoadListener", "(Lcom/applovin/sdk/AppLovinAdLoadListener;)V", "GetSetAdLoadListener_Lcom_applovin_sdk_AppLovinAdLoadListener_Handler:Com.Applovin.Adview.IAppLovinInterstitialAdDialogInvoker, AppLovin")]
		void SetAdLoadListener(IAppLovinAdLoadListener p0);

		// Token: 0x06001305 RID: 4869
		[Register("setAdVideoPlaybackListener", "(Lcom/applovin/sdk/AppLovinAdVideoPlaybackListener;)V", "GetSetAdVideoPlaybackListener_Lcom_applovin_sdk_AppLovinAdVideoPlaybackListener_Handler:Com.Applovin.Adview.IAppLovinInterstitialAdDialogInvoker, AppLovin")]
		void SetAdVideoPlaybackListener(IAppLovinAdVideoPlaybackListener p0);

		// Token: 0x06001306 RID: 4870
		[Register("show", "()V", "GetShowHandler:Com.Applovin.Adview.IAppLovinInterstitialAdDialogInvoker, AppLovin")]
		void Show();

		// Token: 0x06001307 RID: 4871
		[Register("showAndRender", "(Lcom/applovin/sdk/AppLovinAd;)V", "GetShowAndRender_Lcom_applovin_sdk_AppLovinAd_Handler:Com.Applovin.Adview.IAppLovinInterstitialAdDialogInvoker, AppLovin")]
		void ShowAndRender(IAppLovinAd p0);
	}
}
