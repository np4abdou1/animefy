using System;
using System.Collections;
using Android.Runtime;
using Com.Unity3d.Services.Store.Gpbl.Bridges;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Store.Listeners
{
	// Token: 0x0200003B RID: 59
	[Register("mono/com/unity3d/services/store/listeners/IBillingDataResponseListenerImplementor")]
	internal sealed class IBillingDataResponseListenerImplementor : Java.Lang.Object, IBillingDataResponseListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600011D RID: 285 RVA: 0x000032B0 File Offset: 0x000014B0
		public IBillingDataResponseListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/unity3d/services/store/listeners/IBillingDataResponseListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x000032EC File Offset: 0x000014EC
		public void OnBillingResponse(BillingResultBridge p0, IList p1)
		{
			EventHandler<BillingDataResponseEventArgs> handler = this.Handler;
			if (handler != null)
			{
				handler(this.sender, new BillingDataResponseEventArgs(p0, p1));
			}
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00003316 File Offset: 0x00001516
		internal static bool __IsEmpty(IBillingDataResponseListenerImplementor value)
		{
			return value.Handler == null;
		}

		// Token: 0x04000011 RID: 17
		private object sender;

		// Token: 0x04000012 RID: 18
		public EventHandler<BillingDataResponseEventArgs> Handler;
	}
}
