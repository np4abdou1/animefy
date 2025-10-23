using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Sdk
{
	// Token: 0x0200006C RID: 108
	[Register("mono/com/applovin/sdk/AppLovinAdClickListenerImplementor")]
	internal sealed class IAppLovinAdClickListenerImplementor : Java.Lang.Object, IAppLovinAdClickListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060003B9 RID: 953 RVA: 0x0000A3FA File Offset: 0x000085FA
		public IAppLovinAdClickListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/applovin/sdk/AppLovinAdClickListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x060003BA RID: 954 RVA: 0x0000A434 File Offset: 0x00008634
		public void AdClicked(IAppLovinAd p0)
		{
			EventHandler<AppLovinAdClickEventArgs> handler = this.Handler;
			if (handler != null)
			{
				handler(this.sender, new AppLovinAdClickEventArgs(p0));
			}
		}

		// Token: 0x060003BB RID: 955 RVA: 0x0000A45D File Offset: 0x0000865D
		internal static bool __IsEmpty(IAppLovinAdClickListenerImplementor value)
		{
			return value.Handler == null;
		}

		// Token: 0x040000EE RID: 238
		private object sender;

		// Token: 0x040000EF RID: 239
		public EventHandler<AppLovinAdClickEventArgs> Handler;
	}
}
