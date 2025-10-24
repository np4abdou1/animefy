using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Applovin.Mediation
{
	// Token: 0x020000A2 RID: 162
	[Register("com/applovin/mediation/MaxAdListener", "", "Com.Applovin.Mediation.IMaxAdListenerInvoker")]
	public interface IMaxAdListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060005A8 RID: 1448
		[Register("onAdClicked", "(Lcom/applovin/mediation/MaxAd;)V", "GetOnAdClicked_Lcom_applovin_mediation_MaxAd_Handler:Com.Applovin.Mediation.IMaxAdListenerInvoker, AppLovin")]
		void OnAdClicked(IMaxAd p0);

		// Token: 0x060005A9 RID: 1449
		[Register("onAdDisplayFailed", "(Lcom/applovin/mediation/MaxAd;Lcom/applovin/mediation/MaxError;)V", "GetOnAdDisplayFailed_Lcom_applovin_mediation_MaxAd_Lcom_applovin_mediation_MaxError_Handler:Com.Applovin.Mediation.IMaxAdListenerInvoker, AppLovin")]
		void OnAdDisplayFailed(IMaxAd p0, IMaxError p1);

		// Token: 0x060005AA RID: 1450
		[Register("onAdDisplayed", "(Lcom/applovin/mediation/MaxAd;)V", "GetOnAdDisplayed_Lcom_applovin_mediation_MaxAd_Handler:Com.Applovin.Mediation.IMaxAdListenerInvoker, AppLovin")]
		void OnAdDisplayed(IMaxAd p0);

		// Token: 0x060005AB RID: 1451
		[Register("onAdHidden", "(Lcom/applovin/mediation/MaxAd;)V", "GetOnAdHidden_Lcom_applovin_mediation_MaxAd_Handler:Com.Applovin.Mediation.IMaxAdListenerInvoker, AppLovin")]
		void OnAdHidden(IMaxAd p0);

		// Token: 0x060005AC RID: 1452
		[Register("onAdLoadFailed", "(Ljava/lang/String;Lcom/applovin/mediation/MaxError;)V", "GetOnAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_MaxError_Handler:Com.Applovin.Mediation.IMaxAdListenerInvoker, AppLovin")]
		void OnAdLoadFailed(string p0, IMaxError p1);

		// Token: 0x060005AD RID: 1453
		[Register("onAdLoaded", "(Lcom/applovin/mediation/MaxAd;)V", "GetOnAdLoaded_Lcom_applovin_mediation_MaxAd_Handler:Com.Applovin.Mediation.IMaxAdListenerInvoker, AppLovin")]
		void OnAdLoaded(IMaxAd p0);
	}
}
