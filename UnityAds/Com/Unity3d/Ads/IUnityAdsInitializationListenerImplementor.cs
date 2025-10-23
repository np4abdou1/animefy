using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Ads
{
	// Token: 0x020002C6 RID: 710
	[Register("mono/com/unity3d/ads/IUnityAdsInitializationListenerImplementor")]
	internal sealed class IUnityAdsInitializationListenerImplementor : Java.Lang.Object, IUnityAdsInitializationListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060027F3 RID: 10227 RVA: 0x0006727C File Offset: 0x0006547C
		public IUnityAdsInitializationListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/unity3d/ads/IUnityAdsInitializationListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x060027F4 RID: 10228 RVA: 0x000672B8 File Offset: 0x000654B8
		public void OnInitializationComplete()
		{
			EventHandler onInitializationCompleteHandler = this.OnInitializationCompleteHandler;
			if (onInitializationCompleteHandler != null)
			{
				onInitializationCompleteHandler(this.sender, new EventArgs());
			}
		}

		// Token: 0x060027F5 RID: 10229 RVA: 0x000672E0 File Offset: 0x000654E0
		public void OnInitializationFailed(UnityAds.UnityAdsInitializationError p0, string p1)
		{
			EventHandler<InitializationFailedEventArgs> onInitializationFailedHandler = this.OnInitializationFailedHandler;
			if (onInitializationFailedHandler != null)
			{
				onInitializationFailedHandler(this.sender, new InitializationFailedEventArgs(p0, p1));
			}
		}

		// Token: 0x060027F6 RID: 10230 RVA: 0x0006730A File Offset: 0x0006550A
		internal static bool __IsEmpty(IUnityAdsInitializationListenerImplementor value)
		{
			return value.OnInitializationCompleteHandler == null && value.OnInitializationFailedHandler == null;
		}

		// Token: 0x0400080D RID: 2061
		private object sender;

		// Token: 0x0400080E RID: 2062
		public EventHandler OnInitializationCompleteHandler;

		// Token: 0x0400080F RID: 2063
		public EventHandler<InitializationFailedEventArgs> OnInitializationFailedHandler;
	}
}
