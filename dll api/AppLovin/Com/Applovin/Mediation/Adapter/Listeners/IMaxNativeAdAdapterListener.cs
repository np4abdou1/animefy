using System;
using Android.OS;
using Android.Runtime;
using Com.Applovin.Mediation.NativeAds;
using Java.Interop;

namespace Com.Applovin.Mediation.Adapter.Listeners
{
	// Token: 0x0200011E RID: 286
	[Register("com/applovin/mediation/adapter/listeners/MaxNativeAdAdapterListener", "", "Com.Applovin.Mediation.Adapter.Listeners.IMaxNativeAdAdapterListenerInvoker")]
	public interface IMaxNativeAdAdapterListener : IMaxAdapterListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000C78 RID: 3192
		[Register("onNativeAdClicked", "()V", "GetOnNativeAdClickedHandler:Com.Applovin.Mediation.Adapter.Listeners.IMaxNativeAdAdapterListenerInvoker, AppLovin")]
		void OnNativeAdClicked();

		// Token: 0x06000C79 RID: 3193
		[Register("onNativeAdDisplayed", "(Landroid/os/Bundle;)V", "GetOnNativeAdDisplayed_Landroid_os_Bundle_Handler:Com.Applovin.Mediation.Adapter.Listeners.IMaxNativeAdAdapterListenerInvoker, AppLovin")]
		void OnNativeAdDisplayed(Bundle p0);

		// Token: 0x06000C7A RID: 3194
		[Register("onNativeAdLoadFailed", "(Lcom/applovin/mediation/adapter/MaxAdapterError;)V", "GetOnNativeAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_Handler:Com.Applovin.Mediation.Adapter.Listeners.IMaxNativeAdAdapterListenerInvoker, AppLovin")]
		void OnNativeAdLoadFailed(MaxAdapterError p0);

		// Token: 0x06000C7B RID: 3195
		[Register("onNativeAdLoaded", "(Lcom/applovin/mediation/nativeAds/MaxNativeAd;Landroid/os/Bundle;)V", "GetOnNativeAdLoaded_Lcom_applovin_mediation_nativeAds_MaxNativeAd_Landroid_os_Bundle_Handler:Com.Applovin.Mediation.Adapter.Listeners.IMaxNativeAdAdapterListenerInvoker, AppLovin")]
		void OnNativeAdLoaded(MaxNativeAd p0, Bundle p1);
	}
}
