using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Applovin.Mediation
{
	// Token: 0x020000B3 RID: 179
	[Register("com/applovin/mediation/MaxAdViewAdListener", "", "Com.Applovin.Mediation.IMaxAdViewAdListenerInvoker")]
	public interface IMaxAdViewAdListener : IMaxAdListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000604 RID: 1540
		[Register("onAdCollapsed", "(Lcom/applovin/mediation/MaxAd;)V", "GetOnAdCollapsed_Lcom_applovin_mediation_MaxAd_Handler:Com.Applovin.Mediation.IMaxAdViewAdListenerInvoker, AppLovin")]
		void OnAdCollapsed(IMaxAd p0);

		// Token: 0x06000605 RID: 1541
		[Register("onAdExpanded", "(Lcom/applovin/mediation/MaxAd;)V", "GetOnAdExpanded_Lcom_applovin_mediation_MaxAd_Handler:Com.Applovin.Mediation.IMaxAdViewAdListenerInvoker, AppLovin")]
		void OnAdExpanded(IMaxAd p0);
	}
}
