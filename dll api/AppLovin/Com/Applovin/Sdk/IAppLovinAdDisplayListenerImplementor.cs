using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Sdk
{
	// Token: 0x02000071 RID: 113
	[Register("mono/com/applovin/sdk/AppLovinAdDisplayListenerImplementor")]
	internal sealed class IAppLovinAdDisplayListenerImplementor : Java.Lang.Object, IAppLovinAdDisplayListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060003D1 RID: 977 RVA: 0x0000A70D File Offset: 0x0000890D
		public IAppLovinAdDisplayListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/applovin/sdk/AppLovinAdDisplayListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x0000A748 File Offset: 0x00008948
		public void AdDisplayed(IAppLovinAd p0)
		{
			EventHandler<AdDisplayedEventArgs> adDisplayedHandler = this.AdDisplayedHandler;
			if (adDisplayedHandler != null)
			{
				adDisplayedHandler(this.sender, new AdDisplayedEventArgs(p0));
			}
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x0000A774 File Offset: 0x00008974
		public void AdHidden(IAppLovinAd p0)
		{
			EventHandler<AdHiddenEventArgs> adHiddenHandler = this.AdHiddenHandler;
			if (adHiddenHandler != null)
			{
				adHiddenHandler(this.sender, new AdHiddenEventArgs(p0));
			}
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x0000A79D File Offset: 0x0000899D
		internal static bool __IsEmpty(IAppLovinAdDisplayListenerImplementor value)
		{
			return value.AdDisplayedHandler == null && value.AdHiddenHandler == null;
		}

		// Token: 0x040000F8 RID: 248
		private object sender;

		// Token: 0x040000F9 RID: 249
		public EventHandler<AdDisplayedEventArgs> AdDisplayedHandler;

		// Token: 0x040000FA RID: 250
		public EventHandler<AdHiddenEventArgs> AdHiddenHandler;
	}
}
