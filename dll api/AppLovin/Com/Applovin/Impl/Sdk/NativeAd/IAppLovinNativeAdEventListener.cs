using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Applovin.Impl.Sdk.NativeAd
{
	// Token: 0x02000148 RID: 328
	[Register("com/applovin/impl/sdk/nativeAd/AppLovinNativeAdEventListener", "", "Com.Applovin.Impl.Sdk.NativeAd.IAppLovinNativeAdEventListenerInvoker")]
	public interface IAppLovinNativeAdEventListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06001010 RID: 4112
		[Register("onNativeAdClicked", "(Lcom/applovin/impl/sdk/nativeAd/AppLovinNativeAd;)V", "GetOnNativeAdClicked_Lcom_applovin_impl_sdk_nativeAd_AppLovinNativeAd_Handler:Com.Applovin.Impl.Sdk.NativeAd.IAppLovinNativeAdEventListenerInvoker, AppLovin")]
		void OnNativeAdClicked(IAppLovinNativeAd p0);
	}
}
