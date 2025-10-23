using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Ads
{
	// Token: 0x020002D2 RID: 722
	[Register("mono/com/unity3d/ads/IUnityAdsShowListenerImplementor")]
	internal sealed class IUnityAdsShowListenerImplementor : Java.Lang.Object, IUnityAdsShowListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06002836 RID: 10294 RVA: 0x00067BC5 File Offset: 0x00065DC5
		public IUnityAdsShowListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/unity3d/ads/IUnityAdsShowListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x06002837 RID: 10295 RVA: 0x00067C00 File Offset: 0x00065E00
		public void OnUnityAdsShowClick(string p0)
		{
			EventHandler<UnityAdsShowClickEventArgs> onUnityAdsShowClickHandler = this.OnUnityAdsShowClickHandler;
			if (onUnityAdsShowClickHandler != null)
			{
				onUnityAdsShowClickHandler(this.sender, new UnityAdsShowClickEventArgs(p0));
			}
		}

		// Token: 0x06002838 RID: 10296 RVA: 0x00067C2C File Offset: 0x00065E2C
		public void OnUnityAdsShowComplete(string p0, UnityAds.UnityAdsShowCompletionState p1)
		{
			EventHandler<UnityAdsShowCompleteEventArgs> onUnityAdsShowCompleteHandler = this.OnUnityAdsShowCompleteHandler;
			if (onUnityAdsShowCompleteHandler != null)
			{
				onUnityAdsShowCompleteHandler(this.sender, new UnityAdsShowCompleteEventArgs(p0, p1));
			}
		}

		// Token: 0x06002839 RID: 10297 RVA: 0x00067C58 File Offset: 0x00065E58
		public void OnUnityAdsShowFailure(string p0, UnityAds.UnityAdsShowError p1, string p2)
		{
			EventHandler<UnityAdsShowFailureEventArgs> onUnityAdsShowFailureHandler = this.OnUnityAdsShowFailureHandler;
			if (onUnityAdsShowFailureHandler != null)
			{
				onUnityAdsShowFailureHandler(this.sender, new UnityAdsShowFailureEventArgs(p0, p1, p2));
			}
		}

		// Token: 0x0600283A RID: 10298 RVA: 0x00067C84 File Offset: 0x00065E84
		public void OnUnityAdsShowStart(string p0)
		{
			EventHandler<UnityAdsShowStartEventArgs> onUnityAdsShowStartHandler = this.OnUnityAdsShowStartHandler;
			if (onUnityAdsShowStartHandler != null)
			{
				onUnityAdsShowStartHandler(this.sender, new UnityAdsShowStartEventArgs(p0));
			}
		}

		// Token: 0x0600283B RID: 10299 RVA: 0x00067CAD File Offset: 0x00065EAD
		internal static bool __IsEmpty(IUnityAdsShowListenerImplementor value)
		{
			return value.OnUnityAdsShowClickHandler == null && value.OnUnityAdsShowCompleteHandler == null && value.OnUnityAdsShowFailureHandler == null && value.OnUnityAdsShowStartHandler == null;
		}

		// Token: 0x0400082E RID: 2094
		private object sender;

		// Token: 0x0400082F RID: 2095
		public EventHandler<UnityAdsShowClickEventArgs> OnUnityAdsShowClickHandler;

		// Token: 0x04000830 RID: 2096
		public EventHandler<UnityAdsShowCompleteEventArgs> OnUnityAdsShowCompleteHandler;

		// Token: 0x04000831 RID: 2097
		public EventHandler<UnityAdsShowFailureEventArgs> OnUnityAdsShowFailureHandler;

		// Token: 0x04000832 RID: 2098
		public EventHandler<UnityAdsShowStartEventArgs> OnUnityAdsShowStartHandler;
	}
}
