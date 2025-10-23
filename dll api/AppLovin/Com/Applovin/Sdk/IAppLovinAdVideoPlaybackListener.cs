using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Applovin.Sdk
{
	// Token: 0x02000080 RID: 128
	[Register("com/applovin/sdk/AppLovinAdVideoPlaybackListener", "", "Com.Applovin.Sdk.IAppLovinAdVideoPlaybackListenerInvoker")]
	public interface IAppLovinAdVideoPlaybackListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000436 RID: 1078
		[Register("videoPlaybackBegan", "(Lcom/applovin/sdk/AppLovinAd;)V", "GetVideoPlaybackBegan_Lcom_applovin_sdk_AppLovinAd_Handler:Com.Applovin.Sdk.IAppLovinAdVideoPlaybackListenerInvoker, AppLovin")]
		void VideoPlaybackBegan(IAppLovinAd p0);

		// Token: 0x06000437 RID: 1079
		[Register("videoPlaybackEnded", "(Lcom/applovin/sdk/AppLovinAd;DZ)V", "GetVideoPlaybackEnded_Lcom_applovin_sdk_AppLovinAd_DZHandler:Com.Applovin.Sdk.IAppLovinAdVideoPlaybackListenerInvoker, AppLovin")]
		void VideoPlaybackEnded(IAppLovinAd p0, double p1, bool p2);
	}
}
