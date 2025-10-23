using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Impl.Sdk.NativeAd
{
	// Token: 0x02000150 RID: 336
	[Register("mono/com/applovin/impl/sdk/nativeAd/AppLovinNativeAdLoadListenerImplementor")]
	internal sealed class IAppLovinNativeAdLoadListenerImplementor : Java.Lang.Object, IAppLovinNativeAdLoadListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06001037 RID: 4151 RVA: 0x0002F36D File Offset: 0x0002D56D
		public IAppLovinNativeAdLoadListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/applovin/impl/sdk/nativeAd/AppLovinNativeAdLoadListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x06001038 RID: 4152 RVA: 0x0002F3A8 File Offset: 0x0002D5A8
		public void OnNativeAdLoadFailed(int p0)
		{
			EventHandler<NativeAdLoadFailedEventArgs> onNativeAdLoadFailedHandler = this.OnNativeAdLoadFailedHandler;
			if (onNativeAdLoadFailedHandler != null)
			{
				onNativeAdLoadFailedHandler(this.sender, new NativeAdLoadFailedEventArgs(p0));
			}
		}

		// Token: 0x06001039 RID: 4153 RVA: 0x0002F3D4 File Offset: 0x0002D5D4
		public void OnNativeAdLoaded(IAppLovinNativeAd p0)
		{
			EventHandler<NativeAdLoadedEventArgs> onNativeAdLoadedHandler = this.OnNativeAdLoadedHandler;
			if (onNativeAdLoadedHandler != null)
			{
				onNativeAdLoadedHandler(this.sender, new NativeAdLoadedEventArgs(p0));
			}
		}

		// Token: 0x0600103A RID: 4154 RVA: 0x0002F3FD File Offset: 0x0002D5FD
		internal static bool __IsEmpty(IAppLovinNativeAdLoadListenerImplementor value)
		{
			return value.OnNativeAdLoadFailedHandler == null && value.OnNativeAdLoadedHandler == null;
		}

		// Token: 0x0400055C RID: 1372
		private object sender;

		// Token: 0x0400055D RID: 1373
		public EventHandler<NativeAdLoadFailedEventArgs> OnNativeAdLoadFailedHandler;

		// Token: 0x0400055E RID: 1374
		public EventHandler<NativeAdLoadedEventArgs> OnNativeAdLoadedHandler;
	}
}
