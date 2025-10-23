using System;
using Android.App;
using Android.Runtime;
using Com.Applovin.Mediation.Adapter.Parameters;
using Java.Interop;

namespace Com.Applovin.Mediation.Adapter
{
	// Token: 0x020000FC RID: 252
	[Register("com/applovin/mediation/adapter/MaxAdapter", "", "Com.Applovin.Mediation.Adapter.IMaxAdapterInvoker")]
	public interface IMaxAdapter : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000AB9 RID: 2745
		string AdapterVersion { [Register("getAdapterVersion", "()Ljava/lang/String;", "GetGetAdapterVersionHandler:Com.Applovin.Mediation.Adapter.IMaxAdapterInvoker, AppLovin")] get; }

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000ABA RID: 2746
		bool IsBeta { [Register("isBeta", "()Z", "GetIsBetaHandler:Com.Applovin.Mediation.Adapter.IMaxAdapterInvoker, AppLovin")] get; }

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000ABB RID: 2747
		string SdkVersion { [Register("getSdkVersion", "()Ljava/lang/String;", "GetGetSdkVersionHandler:Com.Applovin.Mediation.Adapter.IMaxAdapterInvoker, AppLovin")] get; }

		// Token: 0x06000ABC RID: 2748
		[Register("initialize", "(Lcom/applovin/mediation/adapter/parameters/MaxAdapterInitializationParameters;Landroid/app/Activity;Lcom/applovin/mediation/adapter/MaxAdapter$OnCompletionListener;)V", "GetInitialize_Lcom_applovin_mediation_adapter_parameters_MaxAdapterInitializationParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_MaxAdapter_OnCompletionListener_Handler:Com.Applovin.Mediation.Adapter.IMaxAdapterInvoker, AppLovin")]
		void Initialize(IMaxAdapterInitializationParameters p0, Activity p1, IMaxAdapterOnCompletionListener p2);

		// Token: 0x06000ABD RID: 2749
		[Register("onDestroy", "()V", "GetOnDestroyHandler:Com.Applovin.Mediation.Adapter.IMaxAdapterInvoker, AppLovin")]
		void OnDestroy();
	}
}
