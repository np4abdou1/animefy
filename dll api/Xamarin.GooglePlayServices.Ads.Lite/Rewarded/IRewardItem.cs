using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Ads.Rewarded
{
	// Token: 0x02000027 RID: 39
	[Register("com/google/android/gms/ads/rewarded/RewardItem", "", "Android.Gms.Ads.Rewarded.IRewardItemInvoker")]
	public interface IRewardItem : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600017A RID: 378 RVA: 0x000057B8 File Offset: 0x000039B8
		[Register("DEFAULT_REWARD")]
		IRewardItem DefaultReward
		{
			get
			{
				return Java.Lang.Object.GetObject<IRewardItem>(IRewardItem._members.StaticFields.GetObjectValue("DEFAULT_REWARD.Lcom/google/android/gms/ads/rewarded/RewardItem;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600017B RID: 379
		int Amount { [Register("getAmount", "()I", "GetGetAmountHandler:Android.Gms.Ads.Rewarded.IRewardItemInvoker, Xamarin.GooglePlayServices.Ads.Lite")] get; }

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600017C RID: 380
		string Type { [Register("getType", "()Ljava/lang/String;", "GetGetTypeHandler:Android.Gms.Ads.Rewarded.IRewardItemInvoker, Xamarin.GooglePlayServices.Ads.Lite")] get; }

		// Token: 0x04000051 RID: 81
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/ads/rewarded/RewardItem", typeof(IRewardItem), true);
	}
}
