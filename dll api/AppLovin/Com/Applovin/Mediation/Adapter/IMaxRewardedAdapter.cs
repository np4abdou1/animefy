using System;
using Android.App;
using Android.Runtime;
using Com.Applovin.Mediation.Adapter.Listeners;
using Com.Applovin.Mediation.Adapter.Parameters;
using Java.Interop;

namespace Com.Applovin.Mediation.Adapter
{
	// Token: 0x02000106 RID: 262
	[Register("com/applovin/mediation/adapter/MaxRewardedAdapter", "", "Com.Applovin.Mediation.Adapter.IMaxRewardedAdapterInvoker")]
	public interface IMaxRewardedAdapter : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000B0A RID: 2826
		[Register("loadRewardedAd", "(Lcom/applovin/mediation/adapter/parameters/MaxAdapterResponseParameters;Landroid/app/Activity;Lcom/applovin/mediation/adapter/listeners/MaxRewardedAdapterListener;)V", "GetLoadRewardedAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedAdapterListener_Handler:Com.Applovin.Mediation.Adapter.IMaxRewardedAdapterInvoker, AppLovin")]
		void LoadRewardedAd(IMaxAdapterResponseParameters p0, Activity p1, IMaxRewardedAdapterListener p2);

		// Token: 0x06000B0B RID: 2827
		[Register("showRewardedAd", "(Lcom/applovin/mediation/adapter/parameters/MaxAdapterResponseParameters;Landroid/app/Activity;Lcom/applovin/mediation/adapter/listeners/MaxRewardedAdapterListener;)V", "GetShowRewardedAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedAdapterListener_Handler:Com.Applovin.Mediation.Adapter.IMaxRewardedAdapterInvoker, AppLovin")]
		void ShowRewardedAd(IMaxAdapterResponseParameters p0, Activity p1, IMaxRewardedAdapterListener p2);
	}
}
