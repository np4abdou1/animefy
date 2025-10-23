using System;
using Android.OS;
using Android.Runtime;
using Java.Interop;

namespace Com.Applovin.Mediation.Adapter.Listeners
{
	// Token: 0x02000120 RID: 288
	[Register("com/applovin/mediation/adapter/listeners/MaxRewardedAdapterListener", "", "Com.Applovin.Mediation.Adapter.Listeners.IMaxRewardedAdapterListenerInvoker")]
	public interface IMaxRewardedAdapterListener : IMaxAdapterListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000C91 RID: 3217
		[Register("onRewardedAdClicked", "()V", "GetOnRewardedAdClickedHandler:Com.Applovin.Mediation.Adapter.Listeners.IMaxRewardedAdapterListenerInvoker, AppLovin")]
		void OnRewardedAdClicked();

		// Token: 0x06000C92 RID: 3218
		[Register("onRewardedAdClicked", "(Landroid/os/Bundle;)V", "GetOnRewardedAdClicked_Landroid_os_Bundle_Handler:Com.Applovin.Mediation.Adapter.Listeners.IMaxRewardedAdapterListenerInvoker, AppLovin")]
		void OnRewardedAdClicked(Bundle p0);

		// Token: 0x06000C93 RID: 3219
		[Register("onRewardedAdDisplayFailed", "(Lcom/applovin/mediation/adapter/MaxAdapterError;)V", "GetOnRewardedAdDisplayFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_Handler:Com.Applovin.Mediation.Adapter.Listeners.IMaxRewardedAdapterListenerInvoker, AppLovin")]
		void OnRewardedAdDisplayFailed(MaxAdapterError p0);

		// Token: 0x06000C94 RID: 3220
		[Register("onRewardedAdDisplayed", "()V", "GetOnRewardedAdDisplayedHandler:Com.Applovin.Mediation.Adapter.Listeners.IMaxRewardedAdapterListenerInvoker, AppLovin")]
		void OnRewardedAdDisplayed();

		// Token: 0x06000C95 RID: 3221
		[Register("onRewardedAdDisplayed", "(Landroid/os/Bundle;)V", "GetOnRewardedAdDisplayed_Landroid_os_Bundle_Handler:Com.Applovin.Mediation.Adapter.Listeners.IMaxRewardedAdapterListenerInvoker, AppLovin")]
		void OnRewardedAdDisplayed(Bundle p0);

		// Token: 0x06000C96 RID: 3222
		[Register("onRewardedAdHidden", "()V", "GetOnRewardedAdHiddenHandler:Com.Applovin.Mediation.Adapter.Listeners.IMaxRewardedAdapterListenerInvoker, AppLovin")]
		void OnRewardedAdHidden();

		// Token: 0x06000C97 RID: 3223
		[Register("onRewardedAdHidden", "(Landroid/os/Bundle;)V", "GetOnRewardedAdHidden_Landroid_os_Bundle_Handler:Com.Applovin.Mediation.Adapter.Listeners.IMaxRewardedAdapterListenerInvoker, AppLovin")]
		void OnRewardedAdHidden(Bundle p0);

		// Token: 0x06000C98 RID: 3224
		[Register("onRewardedAdLoadFailed", "(Lcom/applovin/mediation/adapter/MaxAdapterError;)V", "GetOnRewardedAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_Handler:Com.Applovin.Mediation.Adapter.Listeners.IMaxRewardedAdapterListenerInvoker, AppLovin")]
		void OnRewardedAdLoadFailed(MaxAdapterError p0);

		// Token: 0x06000C99 RID: 3225
		[Register("onRewardedAdLoaded", "()V", "GetOnRewardedAdLoadedHandler:Com.Applovin.Mediation.Adapter.Listeners.IMaxRewardedAdapterListenerInvoker, AppLovin")]
		void OnRewardedAdLoaded();

		// Token: 0x06000C9A RID: 3226
		[Register("onRewardedAdLoaded", "(Landroid/os/Bundle;)V", "GetOnRewardedAdLoaded_Landroid_os_Bundle_Handler:Com.Applovin.Mediation.Adapter.Listeners.IMaxRewardedAdapterListenerInvoker, AppLovin")]
		void OnRewardedAdLoaded(Bundle p0);

		// Token: 0x06000C9B RID: 3227
		[Register("onRewardedAdVideoCompleted", "()V", "GetOnRewardedAdVideoCompletedHandler:Com.Applovin.Mediation.Adapter.Listeners.IMaxRewardedAdapterListenerInvoker, AppLovin")]
		void OnRewardedAdVideoCompleted();

		// Token: 0x06000C9C RID: 3228
		[Register("onRewardedAdVideoStarted", "()V", "GetOnRewardedAdVideoStartedHandler:Com.Applovin.Mediation.Adapter.Listeners.IMaxRewardedAdapterListenerInvoker, AppLovin")]
		void OnRewardedAdVideoStarted();

		// Token: 0x06000C9D RID: 3229
		[Register("onUserRewarded", "(Lcom/applovin/mediation/MaxReward;)V", "GetOnUserRewarded_Lcom_applovin_mediation_MaxReward_Handler:Com.Applovin.Mediation.Adapter.Listeners.IMaxRewardedAdapterListenerInvoker, AppLovin")]
		void OnUserRewarded(IMaxReward p0);
	}
}
