using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Applovin.Mediation
{
	// Token: 0x020000AB RID: 171
	[Register("com/applovin/mediation/MaxAdRevenueListener", "", "Com.Applovin.Mediation.IMaxAdRevenueListenerInvoker")]
	public interface IMaxAdRevenueListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060005DF RID: 1503
		[Register("onAdRevenuePaid", "(Lcom/applovin/mediation/MaxAd;)V", "GetOnAdRevenuePaid_Lcom_applovin_mediation_MaxAd_Handler:Com.Applovin.Mediation.IMaxAdRevenueListenerInvoker, AppLovin")]
		void OnAdRevenuePaid(IMaxAd p0);
	}
}
