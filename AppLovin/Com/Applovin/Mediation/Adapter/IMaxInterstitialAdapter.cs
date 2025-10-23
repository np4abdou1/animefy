using System;
using Android.App;
using Android.Runtime;
using Com.Applovin.Mediation.Adapter.Listeners;
using Com.Applovin.Mediation.Adapter.Parameters;
using Java.Interop;

namespace Com.Applovin.Mediation.Adapter
{
	// Token: 0x02000100 RID: 256
	[Register("com/applovin/mediation/adapter/MaxInterstitialAdapter", "", "Com.Applovin.Mediation.Adapter.IMaxInterstitialAdapterInvoker")]
	public interface IMaxInterstitialAdapter : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000AE3 RID: 2787
		[Register("loadInterstitialAd", "(Lcom/applovin/mediation/adapter/parameters/MaxAdapterResponseParameters;Landroid/app/Activity;Lcom/applovin/mediation/adapter/listeners/MaxInterstitialAdapterListener;)V", "GetLoadInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxInterstitialAdapterListener_Handler:Com.Applovin.Mediation.Adapter.IMaxInterstitialAdapterInvoker, AppLovin")]
		void LoadInterstitialAd(IMaxAdapterResponseParameters p0, Activity p1, IMaxInterstitialAdapterListener p2);

		// Token: 0x06000AE4 RID: 2788
		[Register("showInterstitialAd", "(Lcom/applovin/mediation/adapter/parameters/MaxAdapterResponseParameters;Landroid/app/Activity;Lcom/applovin/mediation/adapter/listeners/MaxInterstitialAdapterListener;)V", "GetShowInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxInterstitialAdapterListener_Handler:Com.Applovin.Mediation.Adapter.IMaxInterstitialAdapterInvoker, AppLovin")]
		void ShowInterstitialAd(IMaxAdapterResponseParameters p0, Activity p1, IMaxInterstitialAdapterListener p2);
	}
}
