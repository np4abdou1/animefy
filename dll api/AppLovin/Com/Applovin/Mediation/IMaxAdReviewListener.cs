using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Applovin.Mediation
{
	// Token: 0x020000AF RID: 175
	[Register("com/applovin/mediation/MaxAdReviewListener", "", "Com.Applovin.Mediation.IMaxAdReviewListenerInvoker")]
	public interface IMaxAdReviewListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060005F1 RID: 1521
		[Register("onCreativeIdGenerated", "(Ljava/lang/String;Lcom/applovin/mediation/MaxAd;)V", "GetOnCreativeIdGenerated_Ljava_lang_String_Lcom_applovin_mediation_MaxAd_Handler:Com.Applovin.Mediation.IMaxAdReviewListenerInvoker, AppLovin")]
		void OnCreativeIdGenerated(string p0, IMaxAd p1);
	}
}
