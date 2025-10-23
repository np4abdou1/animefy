using System;
using Android.App;
using Android.Runtime;
using Com.Applovin.Mediation.Adapter.Listeners;
using Com.Applovin.Mediation.Adapter.Parameters;
using Java.Interop;

namespace Com.Applovin.Mediation.Adapter
{
	// Token: 0x0200010A RID: 266
	[Register("com/applovin/mediation/adapter/MaxRewardedInterstitialAdapter", "", "Com.Applovin.Mediation.Adapter.IMaxRewardedInterstitialAdapterInvoker")]
	public interface IMaxRewardedInterstitialAdapter : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000B24 RID: 2852
		[Register("loadRewardedInterstitialAd", "(Lcom/applovin/mediation/adapter/parameters/MaxAdapterResponseParameters;Landroid/app/Activity;Lcom/applovin/mediation/adapter/listeners/MaxRewardedInterstitialAdapterListener;)V", "GetLoadRewardedInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedInterstitialAdapterListener_Handler:Com.Applovin.Mediation.Adapter.IMaxRewardedInterstitialAdapterInvoker, AppLovin")]
		void LoadRewardedInterstitialAd(IMaxAdapterResponseParameters p0, Activity p1, IMaxRewardedInterstitialAdapterListener p2);

		// Token: 0x06000B25 RID: 2853
		[Register("showRewardedInterstitialAd", "(Lcom/applovin/mediation/adapter/parameters/MaxAdapterResponseParameters;Landroid/app/Activity;Lcom/applovin/mediation/adapter/listeners/MaxRewardedInterstitialAdapterListener;)V", "GetShowRewardedInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedInterstitialAdapterListener_Handler:Com.Applovin.Mediation.Adapter.IMaxRewardedInterstitialAdapterInvoker, AppLovin")]
		void ShowRewardedInterstitialAd(IMaxAdapterResponseParameters p0, Activity p1, IMaxRewardedInterstitialAdapterListener p2);
	}
}
