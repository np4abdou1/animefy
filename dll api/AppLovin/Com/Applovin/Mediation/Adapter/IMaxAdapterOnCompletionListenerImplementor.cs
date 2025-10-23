using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Mediation.Adapter
{
	// Token: 0x020000FB RID: 251
	[Register("mono/com/applovin/mediation/adapter/MaxAdapter_OnCompletionListenerImplementor")]
	internal sealed class IMaxAdapterOnCompletionListenerImplementor : Java.Lang.Object, IMaxAdapterOnCompletionListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000AB6 RID: 2742 RVA: 0x0001D2E4 File Offset: 0x0001B4E4
		public IMaxAdapterOnCompletionListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/applovin/mediation/adapter/MaxAdapter_OnCompletionListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x0001D320 File Offset: 0x0001B520
		public void OnCompletion(MaxAdapterInitializationStatus p0, string p1)
		{
			EventHandler<MaxAdapterOnCompletionEventArgs> handler = this.Handler;
			if (handler != null)
			{
				handler(this.sender, new MaxAdapterOnCompletionEventArgs(p0, p1));
			}
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x0001D34A File Offset: 0x0001B54A
		internal static bool __IsEmpty(IMaxAdapterOnCompletionListenerImplementor value)
		{
			return value.Handler == null;
		}

		// Token: 0x04000382 RID: 898
		private object sender;

		// Token: 0x04000383 RID: 899
		public EventHandler<MaxAdapterOnCompletionEventArgs> Handler;
	}
}
