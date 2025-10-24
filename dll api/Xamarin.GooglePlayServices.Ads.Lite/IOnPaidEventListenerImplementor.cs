using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Ads
{
	// Token: 0x0200001B RID: 27
	[Register("mono/com/google/android/gms/ads/OnPaidEventListenerImplementor")]
	internal sealed class IOnPaidEventListenerImplementor : Java.Lang.Object, IOnPaidEventListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060000EF RID: 239 RVA: 0x000041A1 File Offset: 0x000023A1
		public IOnPaidEventListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/google/android/gms/ads/OnPaidEventListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000041DC File Offset: 0x000023DC
		public void OnPaidEvent(AdValue p0)
		{
			EventHandler<PaidEventEventArgs> handler = this.Handler;
			if (handler != null)
			{
				handler(this.sender, new PaidEventEventArgs(p0));
			}
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00004205 File Offset: 0x00002405
		internal static bool __IsEmpty(IOnPaidEventListenerImplementor value)
		{
			return value.Handler == null;
		}

		// Token: 0x04000032 RID: 50
		private object sender;

		// Token: 0x04000033 RID: 51
		public EventHandler<PaidEventEventArgs> Handler;
	}
}
