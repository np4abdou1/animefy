using System;
using Android.OS;
using Android.Runtime;
using Java.Interop;

namespace Com.Applovin.Mediation.Adapter.Listeners
{
	// Token: 0x0200011C RID: 284
	[Register("com/applovin/mediation/adapter/listeners/MaxInterstitialAdapterListener", "", "Com.Applovin.Mediation.Adapter.Listeners.IMaxInterstitialAdapterListenerInvoker")]
	public interface IMaxInterstitialAdapterListener : IMaxAdapterListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000C47 RID: 3143
		[Register("onInterstitialAdClicked", "()V", "GetOnInterstitialAdClickedHandler:Com.Applovin.Mediation.Adapter.Listeners.IMaxInterstitialAdapterListenerInvoker, AppLovin")]
		void OnInterstitialAdClicked();

		// Token: 0x06000C48 RID: 3144
		[Register("onInterstitialAdClicked", "(Landroid/os/Bundle;)V", "GetOnInterstitialAdClicked_Landroid_os_Bundle_Handler:Com.Applovin.Mediation.Adapter.Listeners.IMaxInterstitialAdapterListenerInvoker, AppLovin")]
		void OnInterstitialAdClicked(Bundle p0);

		// Token: 0x06000C49 RID: 3145
		[Register("onInterstitialAdDisplayFailed", "(Lcom/applovin/mediation/adapter/MaxAdapterError;)V", "GetOnInterstitialAdDisplayFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_Handler:Com.Applovin.Mediation.Adapter.Listeners.IMaxInterstitialAdapterListenerInvoker, AppLovin")]
		void OnInterstitialAdDisplayFailed(MaxAdapterError p0);

		// Token: 0x06000C4A RID: 3146
		[Register("onInterstitialAdDisplayed", "()V", "GetOnInterstitialAdDisplayedHandler:Com.Applovin.Mediation.Adapter.Listeners.IMaxInterstitialAdapterListenerInvoker, AppLovin")]
		void OnInterstitialAdDisplayed();

		// Token: 0x06000C4B RID: 3147
		[Register("onInterstitialAdDisplayed", "(Landroid/os/Bundle;)V", "GetOnInterstitialAdDisplayed_Landroid_os_Bundle_Handler:Com.Applovin.Mediation.Adapter.Listeners.IMaxInterstitialAdapterListenerInvoker, AppLovin")]
		void OnInterstitialAdDisplayed(Bundle p0);

		// Token: 0x06000C4C RID: 3148
		[Register("onInterstitialAdHidden", "()V", "GetOnInterstitialAdHiddenHandler:Com.Applovin.Mediation.Adapter.Listeners.IMaxInterstitialAdapterListenerInvoker, AppLovin")]
		void OnInterstitialAdHidden();

		// Token: 0x06000C4D RID: 3149
		[Register("onInterstitialAdHidden", "(Landroid/os/Bundle;)V", "GetOnInterstitialAdHidden_Landroid_os_Bundle_Handler:Com.Applovin.Mediation.Adapter.Listeners.IMaxInterstitialAdapterListenerInvoker, AppLovin")]
		void OnInterstitialAdHidden(Bundle p0);

		// Token: 0x06000C4E RID: 3150
		[Register("onInterstitialAdLoadFailed", "(Lcom/applovin/mediation/adapter/MaxAdapterError;)V", "GetOnInterstitialAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_Handler:Com.Applovin.Mediation.Adapter.Listeners.IMaxInterstitialAdapterListenerInvoker, AppLovin")]
		void OnInterstitialAdLoadFailed(MaxAdapterError p0);

		// Token: 0x06000C4F RID: 3151
		[Register("onInterstitialAdLoaded", "()V", "GetOnInterstitialAdLoadedHandler:Com.Applovin.Mediation.Adapter.Listeners.IMaxInterstitialAdapterListenerInvoker, AppLovin")]
		void OnInterstitialAdLoaded();

		// Token: 0x06000C50 RID: 3152
		[Register("onInterstitialAdLoaded", "(Landroid/os/Bundle;)V", "GetOnInterstitialAdLoaded_Landroid_os_Bundle_Handler:Com.Applovin.Mediation.Adapter.Listeners.IMaxInterstitialAdapterListenerInvoker, AppLovin")]
		void OnInterstitialAdLoaded(Bundle p0);
	}
}
