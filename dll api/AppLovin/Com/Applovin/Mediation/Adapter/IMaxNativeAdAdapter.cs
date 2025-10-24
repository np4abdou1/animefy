using System;
using Android.App;
using Android.Runtime;
using Com.Applovin.Mediation.Adapter.Listeners;
using Com.Applovin.Mediation.Adapter.Parameters;
using Java.Interop;

namespace Com.Applovin.Mediation.Adapter
{
	// Token: 0x02000104 RID: 260
	[Register("com/applovin/mediation/adapter/MaxNativeAdAdapter", "", "Com.Applovin.Mediation.Adapter.IMaxNativeAdAdapterInvoker")]
	public interface IMaxNativeAdAdapter : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000AFD RID: 2813
		[Register("loadNativeAd", "(Lcom/applovin/mediation/adapter/parameters/MaxAdapterResponseParameters;Landroid/app/Activity;Lcom/applovin/mediation/adapter/listeners/MaxNativeAdAdapterListener;)V", "GetLoadNativeAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxNativeAdAdapterListener_Handler:Com.Applovin.Mediation.Adapter.IMaxNativeAdAdapterInvoker, AppLovin")]
		void LoadNativeAd(IMaxAdapterResponseParameters p0, Activity p1, IMaxNativeAdAdapterListener p2);
	}
}
