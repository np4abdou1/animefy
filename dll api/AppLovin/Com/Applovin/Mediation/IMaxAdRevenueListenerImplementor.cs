using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Mediation
{
	// Token: 0x020000AE RID: 174
	[Register("mono/com/applovin/mediation/MaxAdRevenueListenerImplementor")]
	internal sealed class IMaxAdRevenueListenerImplementor : Java.Lang.Object, IMaxAdRevenueListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060005EE RID: 1518 RVA: 0x0000F4F2 File Offset: 0x0000D6F2
		public IMaxAdRevenueListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/applovin/mediation/MaxAdRevenueListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x0000F52C File Offset: 0x0000D72C
		public void OnAdRevenuePaid(IMaxAd p0)
		{
			EventHandler<MaxAdRevenueEventArgs> handler = this.Handler;
			if (handler != null)
			{
				handler(this.sender, new MaxAdRevenueEventArgs(p0));
			}
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x0000F555 File Offset: 0x0000D755
		internal static bool __IsEmpty(IMaxAdRevenueListenerImplementor value)
		{
			return value.Handler == null;
		}

		// Token: 0x040001E6 RID: 486
		private object sender;

		// Token: 0x040001E7 RID: 487
		public EventHandler<MaxAdRevenueEventArgs> Handler;
	}
}
