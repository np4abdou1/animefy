using System;
using Android.Runtime;
using Com.Unity3d.Services.Store.Gpbl.Bridges;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Store.Gpbl
{
	// Token: 0x02000049 RID: 73
	[Register("mono/com/unity3d/services/store/gpbl/IBillingClientStateListenerImplementor")]
	internal sealed class IBillingClientStateListenerImplementor : Java.Lang.Object, IBillingClientStateListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600018D RID: 397 RVA: 0x000043C5 File Offset: 0x000025C5
		public IBillingClientStateListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/unity3d/services/store/gpbl/IBillingClientStateListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00004400 File Offset: 0x00002600
		public void OnBillingServiceDisconnected()
		{
			EventHandler onBillingServiceDisconnectedHandler = this.OnBillingServiceDisconnectedHandler;
			if (onBillingServiceDisconnectedHandler != null)
			{
				onBillingServiceDisconnectedHandler(this.sender, new EventArgs());
			}
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00004428 File Offset: 0x00002628
		public void OnBillingSetupFinished(BillingResultBridge p0)
		{
			EventHandler<BillingSetupFinishedEventArgs> onBillingSetupFinishedHandler = this.OnBillingSetupFinishedHandler;
			if (onBillingSetupFinishedHandler != null)
			{
				onBillingSetupFinishedHandler(this.sender, new BillingSetupFinishedEventArgs(p0));
			}
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00004451 File Offset: 0x00002651
		internal static bool __IsEmpty(IBillingClientStateListenerImplementor value)
		{
			return value.OnBillingServiceDisconnectedHandler == null && value.OnBillingSetupFinishedHandler == null;
		}

		// Token: 0x0400002D RID: 45
		private object sender;

		// Token: 0x0400002E RID: 46
		public EventHandler OnBillingServiceDisconnectedHandler;

		// Token: 0x0400002F RID: 47
		public EventHandler<BillingSetupFinishedEventArgs> OnBillingSetupFinishedHandler;
	}
}
