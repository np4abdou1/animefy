using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Adcolony.Sdk
{
	// Token: 0x02000053 RID: 83
	[Register("mono/com/adcolony/sdk/AdColonyRewardListenerImplementor")]
	internal sealed class IAdColonyRewardListenerImplementor : Java.Lang.Object, IAdColonyRewardListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000426 RID: 1062 RVA: 0x0000CAD1 File Offset: 0x0000ACD1
		public IAdColonyRewardListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/adcolony/sdk/AdColonyRewardListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x0000CB0C File Offset: 0x0000AD0C
		public void OnReward(AdColonyReward p0)
		{
			EventHandler<AdColonyRewardEventArgs> handler = this.Handler;
			if (handler != null)
			{
				handler(this.sender, new AdColonyRewardEventArgs(p0));
			}
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x0000CB35 File Offset: 0x0000AD35
		internal static bool __IsEmpty(IAdColonyRewardListenerImplementor value)
		{
			return value.Handler == null;
		}

		// Token: 0x0400012E RID: 302
		private object sender;

		// Token: 0x0400012F RID: 303
		public EventHandler<AdColonyRewardEventArgs> Handler;
	}
}
