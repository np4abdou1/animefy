using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Ads
{
	// Token: 0x020002D6 RID: 726
	[Register("mono/com/unity3d/ads/IUnityAdsTokenListenerImplementor")]
	internal sealed class IUnityAdsTokenListenerImplementor : Java.Lang.Object, IUnityAdsTokenListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600284B RID: 10315 RVA: 0x00067E9B File Offset: 0x0006609B
		public IUnityAdsTokenListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/unity3d/ads/IUnityAdsTokenListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x0600284C RID: 10316 RVA: 0x00067ED4 File Offset: 0x000660D4
		public void OnUnityAdsTokenReady(string p0)
		{
			EventHandler<UnityAdsTokenEventArgs> handler = this.Handler;
			if (handler != null)
			{
				handler(this.sender, new UnityAdsTokenEventArgs(p0));
			}
		}

		// Token: 0x0600284D RID: 10317 RVA: 0x00067EFD File Offset: 0x000660FD
		internal static bool __IsEmpty(IUnityAdsTokenListenerImplementor value)
		{
			return value.Handler == null;
		}

		// Token: 0x04000838 RID: 2104
		private object sender;

		// Token: 0x04000839 RID: 2105
		public EventHandler<UnityAdsTokenEventArgs> Handler;
	}
}
