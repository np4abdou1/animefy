using System;
using Android.Runtime;
using Com.Applovin.Sdk;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Adview
{
	// Token: 0x02000199 RID: 409
	[Register("mono/com/applovin/adview/AppLovinAdViewEventListenerImplementor")]
	internal sealed class IAppLovinAdViewEventListenerImplementor : Java.Lang.Object, IAppLovinAdViewEventListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060012FC RID: 4860 RVA: 0x00036CFC File Offset: 0x00034EFC
		public IAppLovinAdViewEventListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/applovin/adview/AppLovinAdViewEventListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x060012FD RID: 4861 RVA: 0x00036D38 File Offset: 0x00034F38
		public void AdClosedFullscreen(IAppLovinAd p0, AppLovinAdView p1)
		{
			EventHandler<AdClosedFullscreenEventArgs> adClosedFullscreenHandler = this.AdClosedFullscreenHandler;
			if (adClosedFullscreenHandler != null)
			{
				adClosedFullscreenHandler(this.sender, new AdClosedFullscreenEventArgs(p0, p1));
			}
		}

		// Token: 0x060012FE RID: 4862 RVA: 0x00036D64 File Offset: 0x00034F64
		public void AdFailedToDisplay(IAppLovinAd p0, AppLovinAdView p1, AppLovinAdViewDisplayErrorCode p2)
		{
			EventHandler<AdFailedToDisplayEventArgs> adFailedToDisplayHandler = this.AdFailedToDisplayHandler;
			if (adFailedToDisplayHandler != null)
			{
				adFailedToDisplayHandler(this.sender, new AdFailedToDisplayEventArgs(p0, p1, p2));
			}
		}

		// Token: 0x060012FF RID: 4863 RVA: 0x00036D90 File Offset: 0x00034F90
		public void AdLeftApplication(IAppLovinAd p0, AppLovinAdView p1)
		{
			EventHandler<AdLeftApplicationEventArgs> adLeftApplicationHandler = this.AdLeftApplicationHandler;
			if (adLeftApplicationHandler != null)
			{
				adLeftApplicationHandler(this.sender, new AdLeftApplicationEventArgs(p0, p1));
			}
		}

		// Token: 0x06001300 RID: 4864 RVA: 0x00036DBC File Offset: 0x00034FBC
		public void AdOpenedFullscreen(IAppLovinAd p0, AppLovinAdView p1)
		{
			EventHandler<AdOpenedFullscreenEventArgs> adOpenedFullscreenHandler = this.AdOpenedFullscreenHandler;
			if (adOpenedFullscreenHandler != null)
			{
				adOpenedFullscreenHandler(this.sender, new AdOpenedFullscreenEventArgs(p0, p1));
			}
		}

		// Token: 0x06001301 RID: 4865 RVA: 0x00036DE6 File Offset: 0x00034FE6
		internal static bool __IsEmpty(IAppLovinAdViewEventListenerImplementor value)
		{
			return value.AdClosedFullscreenHandler == null && value.AdFailedToDisplayHandler == null && value.AdLeftApplicationHandler == null && value.AdOpenedFullscreenHandler == null;
		}

		// Token: 0x04000639 RID: 1593
		private object sender;

		// Token: 0x0400063A RID: 1594
		public EventHandler<AdClosedFullscreenEventArgs> AdClosedFullscreenHandler;

		// Token: 0x0400063B RID: 1595
		public EventHandler<AdFailedToDisplayEventArgs> AdFailedToDisplayHandler;

		// Token: 0x0400063C RID: 1596
		public EventHandler<AdLeftApplicationEventArgs> AdLeftApplicationHandler;

		// Token: 0x0400063D RID: 1597
		public EventHandler<AdOpenedFullscreenEventArgs> AdOpenedFullscreenHandler;
	}
}
