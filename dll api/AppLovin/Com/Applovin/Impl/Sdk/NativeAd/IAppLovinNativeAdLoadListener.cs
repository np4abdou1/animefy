using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Applovin.Impl.Sdk.NativeAd
{
	// Token: 0x0200014C RID: 332
	[Register("com/applovin/impl/sdk/nativeAd/AppLovinNativeAdLoadListener", "", "Com.Applovin.Impl.Sdk.NativeAd.IAppLovinNativeAdLoadListenerInvoker")]
	public interface IAppLovinNativeAdLoadListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06001022 RID: 4130
		[Register("onNativeAdLoadFailed", "(I)V", "GetOnNativeAdLoadFailed_IHandler:Com.Applovin.Impl.Sdk.NativeAd.IAppLovinNativeAdLoadListenerInvoker, AppLovin")]
		void OnNativeAdLoadFailed(int p0);

		// Token: 0x06001023 RID: 4131
		[Register("onNativeAdLoaded", "(Lcom/applovin/impl/sdk/nativeAd/AppLovinNativeAd;)V", "GetOnNativeAdLoaded_Lcom_applovin_impl_sdk_nativeAd_AppLovinNativeAd_Handler:Com.Applovin.Impl.Sdk.NativeAd.IAppLovinNativeAdLoadListenerInvoker, AppLovin")]
		void OnNativeAdLoaded(IAppLovinNativeAd p0);
	}
}
