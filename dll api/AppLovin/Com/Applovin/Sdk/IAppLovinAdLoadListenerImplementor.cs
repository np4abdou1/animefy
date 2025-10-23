using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Sdk
{
	// Token: 0x02000076 RID: 118
	[Register("mono/com/applovin/sdk/AppLovinAdLoadListenerImplementor")]
	internal sealed class IAppLovinAdLoadListenerImplementor : Java.Lang.Object, IAppLovinAdLoadListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060003EA RID: 1002 RVA: 0x0000AA31 File Offset: 0x00008C31
		public IAppLovinAdLoadListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/applovin/sdk/AppLovinAdLoadListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x0000AA6C File Offset: 0x00008C6C
		public void AdReceived(IAppLovinAd p0)
		{
			EventHandler<AdReceivedEventArgs> adReceivedHandler = this.AdReceivedHandler;
			if (adReceivedHandler != null)
			{
				adReceivedHandler(this.sender, new AdReceivedEventArgs(p0));
			}
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x0000AA98 File Offset: 0x00008C98
		public void FailedToReceiveAd(int p0)
		{
			EventHandler<FailedToReceiveAdEventArgs> failedToReceiveAdHandler = this.FailedToReceiveAdHandler;
			if (failedToReceiveAdHandler != null)
			{
				failedToReceiveAdHandler(this.sender, new FailedToReceiveAdEventArgs(p0));
			}
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0000AAC1 File Offset: 0x00008CC1
		internal static bool __IsEmpty(IAppLovinAdLoadListenerImplementor value)
		{
			return value.AdReceivedHandler == null && value.FailedToReceiveAdHandler == null;
		}

		// Token: 0x04000103 RID: 259
		private object sender;

		// Token: 0x04000104 RID: 260
		public EventHandler<AdReceivedEventArgs> AdReceivedHandler;

		// Token: 0x04000105 RID: 261
		public EventHandler<FailedToReceiveAdEventArgs> FailedToReceiveAdHandler;
	}
}
