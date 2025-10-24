using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Applovin.Mediation
{
	// Token: 0x020000C6 RID: 198
	[Register("com/applovin/mediation/MaxRewardedAdListener", "", "Com.Applovin.Mediation.IMaxRewardedAdListenerInvoker")]
	public interface IMaxRewardedAdListener : IMaxAdListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060006BC RID: 1724
		[Register("onRewardedVideoCompleted", "(Lcom/applovin/mediation/MaxAd;)V", "GetOnRewardedVideoCompleted_Lcom_applovin_mediation_MaxAd_Handler:Com.Applovin.Mediation.IMaxRewardedAdListenerInvoker, AppLovin")]
		void OnRewardedVideoCompleted(IMaxAd p0);

		// Token: 0x060006BD RID: 1725
		[Register("onRewardedVideoStarted", "(Lcom/applovin/mediation/MaxAd;)V", "GetOnRewardedVideoStarted_Lcom_applovin_mediation_MaxAd_Handler:Com.Applovin.Mediation.IMaxRewardedAdListenerInvoker, AppLovin")]
		void OnRewardedVideoStarted(IMaxAd p0);

		// Token: 0x060006BE RID: 1726
		[Register("onUserRewarded", "(Lcom/applovin/mediation/MaxAd;Lcom/applovin/mediation/MaxReward;)V", "GetOnUserRewarded_Lcom_applovin_mediation_MaxAd_Lcom_applovin_mediation_MaxReward_Handler:Com.Applovin.Mediation.IMaxRewardedAdListenerInvoker, AppLovin")]
		void OnUserRewarded(IMaxAd p0, IMaxReward p1);
	}
}
