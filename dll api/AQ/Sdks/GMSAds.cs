using System;
using Android.Gms.Ads.Interstitial;
using Android.Gms.Ads.Rewarded;
using Android.Runtime;
using Java.Lang;

namespace AQ.Sdks
{
	// Token: 0x02000047 RID: 71
	public class GMSAds
	{
		// Token: 0x02000113 RID: 275
		public abstract class InterstitialAdLoadCallback : Android.Gms.Ads.Interstitial.InterstitialAdLoadCallback
		{
			// Token: 0x06000B59 RID: 2905 RVA: 0x0003C5F0 File Offset: 0x0003A7F0
			private static Delegate GetOnAdLoadedHandler()
			{
				if (GMSAds.InterstitialAdLoadCallback.cb_onAdLoaded == null)
				{
					GMSAds.InterstitialAdLoadCallback.cb_onAdLoaded = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr>(GMSAds.InterstitialAdLoadCallback.n_onAdLoaded));
				}
				return GMSAds.InterstitialAdLoadCallback.cb_onAdLoaded;
			}

			// Token: 0x06000B5A RID: 2906 RVA: 0x0003C614 File Offset: 0x0003A814
			private static void n_onAdLoaded(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				GMSAds.InterstitialAdLoadCallback @object = Java.Lang.Object.GetObject<GMSAds.InterstitialAdLoadCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				InterstitialAd object2 = Java.Lang.Object.GetObject<InterstitialAd>(native_p0, JniHandleOwnership.DoNotTransfer);
				@object.OnAdLoaded(object2);
			}

			// Token: 0x06000B5B RID: 2907 RVA: 0x00004097 File Offset: 0x00002297
			[Register("onAdLoaded", "(Lcom/google/android/gms/ads/interstitial/InterstitialAd;)V", "GetOnAdLoadedHandler")]
			public virtual void OnAdLoaded(InterstitialAd interstitialAd)
			{
			}

			// Token: 0x04003031 RID: 12337
			private static Delegate cb_onAdLoaded;
		}

		// Token: 0x02000114 RID: 276
		public abstract class RewardedAdLoadCallback : Android.Gms.Ads.Rewarded.RewardedAdLoadCallback
		{
			// Token: 0x06000B5D RID: 2909 RVA: 0x0003C641 File Offset: 0x0003A841
			private static Delegate GetOnAdLoadedHandler()
			{
				if (GMSAds.RewardedAdLoadCallback.cb_onAdLoaded == null)
				{
					GMSAds.RewardedAdLoadCallback.cb_onAdLoaded = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr>(GMSAds.RewardedAdLoadCallback.n_onAdLoaded));
				}
				return GMSAds.RewardedAdLoadCallback.cb_onAdLoaded;
			}

			// Token: 0x06000B5E RID: 2910 RVA: 0x0003C668 File Offset: 0x0003A868
			private static void n_onAdLoaded(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				GMSAds.RewardedAdLoadCallback @object = Java.Lang.Object.GetObject<GMSAds.RewardedAdLoadCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RewardedAd object2 = Java.Lang.Object.GetObject<RewardedAd>(native_p0, JniHandleOwnership.DoNotTransfer);
				@object.OnAdLoaded(object2);
			}

			// Token: 0x06000B5F RID: 2911 RVA: 0x00004097 File Offset: 0x00002297
			[Register("onAdLoaded", "(Lcom/google/android/gms/ads/rewarded/RewardedAd;)V", "GetOnAdLoadedHandler")]
			public virtual void OnAdLoaded(RewardedAd rewardedAd)
			{
			}

			// Token: 0x04003032 RID: 12338
			private static Delegate cb_onAdLoaded;
		}
	}
}
