using System;
using Android.Gms.Ads.Rewarded;
using Android.Runtime;
using Java.Interop;

namespace Android.Gms.Ads
{
	// Token: 0x0200001C RID: 28
	[Register("com/google/android/gms/ads/OnUserEarnedRewardListener", "", "Android.Gms.Ads.IOnUserEarnedRewardListenerInvoker")]
	public interface IOnUserEarnedRewardListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060000F2 RID: 242
		[Register("onUserEarnedReward", "(Lcom/google/android/gms/ads/rewarded/RewardItem;)V", "GetOnUserEarnedReward_Lcom_google_android_gms_ads_rewarded_RewardItem_Handler:Android.Gms.Ads.IOnUserEarnedRewardListenerInvoker, Xamarin.GooglePlayServices.Ads.Lite")]
		void OnUserEarnedReward(IRewardItem p0);
	}
}
