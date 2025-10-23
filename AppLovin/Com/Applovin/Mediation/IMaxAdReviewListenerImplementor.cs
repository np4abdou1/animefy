using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Mediation
{
	// Token: 0x020000B2 RID: 178
	[Register("mono/com/applovin/mediation/MaxAdReviewListenerImplementor")]
	internal sealed class IMaxAdReviewListenerImplementor : Java.Lang.Object, IMaxAdReviewListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000601 RID: 1537 RVA: 0x0000F765 File Offset: 0x0000D965
		public IMaxAdReviewListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/applovin/mediation/MaxAdReviewListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x0000F7A0 File Offset: 0x0000D9A0
		public void OnCreativeIdGenerated(string p0, IMaxAd p1)
		{
			EventHandler<MaxAdReviewEventArgs> handler = this.Handler;
			if (handler != null)
			{
				handler(this.sender, new MaxAdReviewEventArgs(p0, p1));
			}
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x0000F7CA File Offset: 0x0000D9CA
		internal static bool __IsEmpty(IMaxAdReviewListenerImplementor value)
		{
			return value.Handler == null;
		}

		// Token: 0x040001EE RID: 494
		private object sender;

		// Token: 0x040001EF RID: 495
		public EventHandler<MaxAdReviewEventArgs> Handler;
	}
}
