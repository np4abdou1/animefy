using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Scar.Adapter.Common
{
	// Token: 0x020002A1 RID: 673
	[Register("com/unity3d/scar/adapter/common/IScarRewardedAdListenerWrapper", "", "Com.Unity3d.Scar.Adapter.Common.IScarRewardedAdListenerWrapperInvoker")]
	public interface IScarRewardedAdListenerWrapper : IScarAdListenerWrapper, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06002684 RID: 9860
		[Register("onAdFailedToShow", "(ILjava/lang/String;)V", "GetOnAdFailedToShow_ILjava_lang_String_Handler:Com.Unity3d.Scar.Adapter.Common.IScarRewardedAdListenerWrapperInvoker, UnityAds")]
		void OnAdFailedToShow(int p0, string p1);

		// Token: 0x06002685 RID: 9861
		[Register("onAdImpression", "()V", "GetOnAdImpressionHandler:Com.Unity3d.Scar.Adapter.Common.IScarRewardedAdListenerWrapperInvoker, UnityAds")]
		void OnAdImpression();

		// Token: 0x06002686 RID: 9862
		[Register("onUserEarnedReward", "()V", "GetOnUserEarnedRewardHandler:Com.Unity3d.Scar.Adapter.Common.IScarRewardedAdListenerWrapperInvoker, UnityAds")]
		void OnUserEarnedReward();
	}
}
