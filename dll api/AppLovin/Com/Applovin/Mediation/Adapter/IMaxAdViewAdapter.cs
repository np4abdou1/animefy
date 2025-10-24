using System;
using Android.App;
using Android.Runtime;
using Com.Applovin.Mediation.Adapter.Listeners;
using Com.Applovin.Mediation.Adapter.Parameters;
using Java.Interop;

namespace Com.Applovin.Mediation.Adapter
{
	// Token: 0x020000FE RID: 254
	[Register("com/applovin/mediation/adapter/MaxAdViewAdapter", "", "Com.Applovin.Mediation.Adapter.IMaxAdViewAdapterInvoker")]
	public interface IMaxAdViewAdapter : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000AD6 RID: 2774
		[Register("loadAdViewAd", "(Lcom/applovin/mediation/adapter/parameters/MaxAdapterResponseParameters;Lcom/applovin/mediation/MaxAdFormat;Landroid/app/Activity;Lcom/applovin/mediation/adapter/listeners/MaxAdViewAdapterListener;)V", "GetLoadAdViewAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Lcom_applovin_mediation_MaxAdFormat_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxAdViewAdapterListener_Handler:Com.Applovin.Mediation.Adapter.IMaxAdViewAdapterInvoker, AppLovin")]
		void LoadAdViewAd(IMaxAdapterResponseParameters p0, MaxAdFormat p1, Activity p2, IMaxAdViewAdapterListener p3);
	}
}
