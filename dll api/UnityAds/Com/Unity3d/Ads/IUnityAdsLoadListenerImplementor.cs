using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Ads
{
	// Token: 0x020002CB RID: 715
	[Register("mono/com/unity3d/ads/IUnityAdsLoadListenerImplementor")]
	internal sealed class IUnityAdsLoadListenerImplementor : Java.Lang.Object, IUnityAdsLoadListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600280E RID: 10254 RVA: 0x00067631 File Offset: 0x00065831
		public IUnityAdsLoadListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/unity3d/ads/IUnityAdsLoadListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x0600280F RID: 10255 RVA: 0x0006766C File Offset: 0x0006586C
		public void OnUnityAdsAdLoaded(string p0)
		{
			EventHandler<UnityAdsAdLoadedEventArgs> onUnityAdsAdLoadedHandler = this.OnUnityAdsAdLoadedHandler;
			if (onUnityAdsAdLoadedHandler != null)
			{
				onUnityAdsAdLoadedHandler(this.sender, new UnityAdsAdLoadedEventArgs(p0));
			}
		}

		// Token: 0x06002810 RID: 10256 RVA: 0x00067698 File Offset: 0x00065898
		public void OnUnityAdsFailedToLoad(string p0, UnityAds.UnityAdsLoadError p1, string p2)
		{
			EventHandler<UnityAdsFailedToLoadEventArgs> onUnityAdsFailedToLoadHandler = this.OnUnityAdsFailedToLoadHandler;
			if (onUnityAdsFailedToLoadHandler != null)
			{
				onUnityAdsFailedToLoadHandler(this.sender, new UnityAdsFailedToLoadEventArgs(p0, p1, p2));
			}
		}

		// Token: 0x06002811 RID: 10257 RVA: 0x000676C3 File Offset: 0x000658C3
		internal static bool __IsEmpty(IUnityAdsLoadListenerImplementor value)
		{
			return value.OnUnityAdsAdLoadedHandler == null && value.OnUnityAdsFailedToLoadHandler == null;
		}

		// Token: 0x0400081A RID: 2074
		private object sender;

		// Token: 0x0400081B RID: 2075
		public EventHandler<UnityAdsAdLoadedEventArgs> OnUnityAdsAdLoadedHandler;

		// Token: 0x0400081C RID: 2076
		public EventHandler<UnityAdsFailedToLoadEventArgs> OnUnityAdsFailedToLoadHandler;
	}
}
