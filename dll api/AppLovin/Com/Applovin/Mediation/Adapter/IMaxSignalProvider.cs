using System;
using Android.App;
using Android.Runtime;
using Com.Applovin.Mediation.Adapter.Listeners;
using Com.Applovin.Mediation.Adapter.Parameters;
using Java.Interop;

namespace Com.Applovin.Mediation.Adapter
{
	// Token: 0x0200010C RID: 268
	[Register("com/applovin/mediation/adapter/MaxSignalProvider", "", "Com.Applovin.Mediation.Adapter.IMaxSignalProviderInvoker")]
	public interface IMaxSignalProvider : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000B35 RID: 2869
		[Register("collectSignal", "(Lcom/applovin/mediation/adapter/parameters/MaxAdapterSignalCollectionParameters;Landroid/app/Activity;Lcom/applovin/mediation/adapter/listeners/MaxSignalCollectionListener;)V", "GetCollectSignal_Lcom_applovin_mediation_adapter_parameters_MaxAdapterSignalCollectionParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxSignalCollectionListener_Handler:Com.Applovin.Mediation.Adapter.IMaxSignalProviderInvoker, AppLovin")]
		void CollectSignal(IMaxAdapterSignalCollectionParameters p0, Activity p1, IMaxSignalCollectionListener p2);
	}
}
