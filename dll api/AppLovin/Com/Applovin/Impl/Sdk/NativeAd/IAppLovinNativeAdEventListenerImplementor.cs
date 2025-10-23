using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Impl.Sdk.NativeAd
{
	// Token: 0x0200014B RID: 331
	[Register("mono/com/applovin/impl/sdk/nativeAd/AppLovinNativeAdEventListenerImplementor")]
	internal sealed class IAppLovinNativeAdEventListenerImplementor : Java.Lang.Object, IAppLovinNativeAdEventListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600101F RID: 4127 RVA: 0x0002F082 File Offset: 0x0002D282
		public IAppLovinNativeAdEventListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/applovin/impl/sdk/nativeAd/AppLovinNativeAdEventListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x0002F0BC File Offset: 0x0002D2BC
		public void OnNativeAdClicked(IAppLovinNativeAd p0)
		{
			EventHandler<AppLovinNativeAdEventEventArgs> handler = this.Handler;
			if (handler != null)
			{
				handler(this.sender, new AppLovinNativeAdEventEventArgs(p0));
			}
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x0002F0E5 File Offset: 0x0002D2E5
		internal static bool __IsEmpty(IAppLovinNativeAdEventListenerImplementor value)
		{
			return value.Handler == null;
		}

		// Token: 0x04000552 RID: 1362
		private object sender;

		// Token: 0x04000553 RID: 1363
		public EventHandler<AppLovinNativeAdEventEventArgs> Handler;
	}
}
