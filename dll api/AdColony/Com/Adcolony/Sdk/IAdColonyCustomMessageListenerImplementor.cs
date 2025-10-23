using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Adcolony.Sdk
{
	// Token: 0x0200004F RID: 79
	[Register("mono/com/adcolony/sdk/AdColonyCustomMessageListenerImplementor")]
	internal sealed class IAdColonyCustomMessageListenerImplementor : Java.Lang.Object, IAdColonyCustomMessageListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000414 RID: 1044 RVA: 0x0000C899 File Offset: 0x0000AA99
		public IAdColonyCustomMessageListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/adcolony/sdk/AdColonyCustomMessageListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x0000C8D4 File Offset: 0x0000AAD4
		public void OnAdColonyCustomMessage(AdColonyCustomMessage p0)
		{
			EventHandler<AdColonyCustomMessageEventArgs> handler = this.Handler;
			if (handler != null)
			{
				handler(this.sender, new AdColonyCustomMessageEventArgs(p0));
			}
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x0000C8FD File Offset: 0x0000AAFD
		internal static bool __IsEmpty(IAdColonyCustomMessageListenerImplementor value)
		{
			return value.Handler == null;
		}

		// Token: 0x04000127 RID: 295
		private object sender;

		// Token: 0x04000128 RID: 296
		public EventHandler<AdColonyCustomMessageEventArgs> Handler;
	}
}
