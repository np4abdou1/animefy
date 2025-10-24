using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Applovin.Mediation.Adapter
{
	// Token: 0x020000F8 RID: 248
	[Register("com/applovin/mediation/adapter/MaxAdapter$OnCompletionListener", "", "Com.Applovin.Mediation.Adapter.IMaxAdapterOnCompletionListenerInvoker")]
	public interface IMaxAdapterOnCompletionListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000AA6 RID: 2726
		[Register("onCompletion", "(Lcom/applovin/mediation/adapter/MaxAdapter$InitializationStatus;Ljava/lang/String;)V", "GetOnCompletion_Lcom_applovin_mediation_adapter_MaxAdapter_InitializationStatus_Ljava_lang_String_Handler:Com.Applovin.Mediation.Adapter.IMaxAdapterOnCompletionListenerInvoker, AppLovin")]
		void OnCompletion(MaxAdapterInitializationStatus p0, string p1);
	}
}
