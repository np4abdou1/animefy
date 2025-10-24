using System;
using Android.OS;
using Android.Runtime;
using Java.Interop;

namespace Com.Applovin.Mediation.Adapter.Listeners
{
	// Token: 0x02000122 RID: 290
	[Register("com/applovin/mediation/adapter/listeners/MaxRewardedInterstitialAdapterListener", "", "Com.Applovin.Mediation.Adapter.Listeners.IMaxRewardedInterstitialAdapterListenerInvoker")]
	public interface IMaxRewardedInterstitialAdapterListener : IMaxAdapterListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000CCE RID: 3278
		[Register("onRewardedInterstitialAdClicked", "()V", "GetOnRewardedInterstitialAdClickedHandler:Com.Applovin.Mediation.Adapter.Listeners.IMaxRewardedInterstitialAdapterListenerInvoker, AppLovin")]
		void OnRewardedInterstitialAdClicked();

		// Token: 0x06000CCF RID: 3279
		[Register("onRewardedInterstitialAdClicked", "(Landroid/os/Bundle;)V", "GetOnRewardedInterstitialAdClicked_Landroid_os_Bundle_Handler:Com.Applovin.Mediation.Adapter.Listeners.IMaxRewardedInterstitialAdapterListenerInvoker, AppLovin")]
		void OnRewardedInterstitialAdClicked(Bundle p0);

		// Token: 0x06000CD0 RID: 3280
		[Register("onRewardedInterstitialAdDisplayFailed", "(Lcom/applovin/mediation/adapter/MaxAdapterError;)V", "GetOnRewardedInterstitialAdDisplayFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_Handler:Com.Applovin.Mediation.Adapter.Listeners.IMaxRewardedInterstitialAdapterListenerInvoker, AppLovin")]
		void OnRewardedInterstitialAdDisplayFailed(MaxAdapterError p0);

		// Token: 0x06000CD1 RID: 3281
		[Register("onRewardedInterstitialAdDisplayed", "()V", "GetOnRewardedInterstitialAdDisplayedHandler:Com.Applovin.Mediation.Adapter.Listeners.IMaxRewardedInterstitialAdapterListenerInvoker, AppLovin")]
		void OnRewardedInterstitialAdDisplayed();

		// Token: 0x06000CD2 RID: 3282
		[Register("onRewardedInterstitialAdDisplayed", "(Landroid/os/Bundle;)V", "GetOnRewardedInterstitialAdDisplayed_Landroid_os_Bundle_Handler:Com.Applovin.Mediation.Adapter.Listeners.IMaxRewardedInterstitialAdapterListenerInvoker, AppLovin")]
		void OnRewardedInterstitialAdDisplayed(Bundle p0);

		// Token: 0x06000CD3 RID: 3283
		[Register("onRewardedInterstitialAdHidden", "()V", "GetOnRewardedInterstitialAdHiddenHandler:Com.Applovin.Mediation.Adapter.Listeners.IMaxRewardedInterstitialAdapterListenerInvoker, AppLovin")]
		void OnRewardedInterstitialAdHidden();

		// Token: 0x06000CD4 RID: 3284
		[Register("onRewardedInterstitialAdHidden", "(Landroid/os/Bundle;)V", "GetOnRewardedInterstitialAdHidden_Landroid_os_Bundle_Handler:Com.Applovin.Mediation.Adapter.Listeners.IMaxRewardedInterstitialAdapterListenerInvoker, AppLovin")]
		void OnRewardedInterstitialAdHidden(Bundle p0);

		// Token: 0x06000CD5 RID: 3285
		[Register("onRewardedInterstitialAdLoadFailed", "(Lcom/applovin/mediation/adapter/MaxAdapterError;)V", "GetOnRewardedInterstitialAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_Handler:Com.Applovin.Mediation.Adapter.Listeners.IMaxRewardedInterstitialAdapterListenerInvoker, AppLovin")]
		void OnRewardedInterstitialAdLoadFailed(MaxAdapterError p0);

		// Token: 0x06000CD6 RID: 3286
		[Register("onRewardedInterstitialAdLoaded", "()V", "GetOnRewardedInterstitialAdLoadedHandler:Com.Applovin.Mediation.Adapter.Listeners.IMaxRewardedInterstitialAdapterListenerInvoker, AppLovin")]
		void OnRewardedInterstitialAdLoaded();

		// Token: 0x06000CD7 RID: 3287
		[Register("onRewardedInterstitialAdLoaded", "(Landroid/os/Bundle;)V", "GetOnRewardedInterstitialAdLoaded_Landroid_os_Bundle_Handler:Com.Applovin.Mediation.Adapter.Listeners.IMaxRewardedInterstitialAdapterListenerInvoker, AppLovin")]
		void OnRewardedInterstitialAdLoaded(Bundle p0);

		// Token: 0x06000CD8 RID: 3288
		[Register("onRewardedInterstitialAdVideoCompleted", "()V", "GetOnRewardedInterstitialAdVideoCompletedHandler:Com.Applovin.Mediation.Adapter.Listeners.IMaxRewardedInterstitialAdapterListenerInvoker, AppLovin")]
		void OnRewardedInterstitialAdVideoCompleted();

		// Token: 0x06000CD9 RID: 3289
		[Register("onRewardedInterstitialAdVideoStarted", "()V", "GetOnRewardedInterstitialAdVideoStartedHandler:Com.Applovin.Mediation.Adapter.Listeners.IMaxRewardedInterstitialAdapterListenerInvoker, AppLovin")]
		void OnRewardedInterstitialAdVideoStarted();

		// Token: 0x06000CDA RID: 3290
		[Register("onUserRewarded", "(Lcom/applovin/mediation/MaxReward;)V", "GetOnUserRewarded_Lcom_applovin_mediation_MaxReward_Handler:Com.Applovin.Mediation.Adapter.Listeners.IMaxRewardedInterstitialAdapterListenerInvoker, AppLovin")]
		void OnUserRewarded(IMaxReward p0);
	}
}
