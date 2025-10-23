using System;
using System.Collections.Generic;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace Com.Iab.Omid.Library.Applovin.Adsession
{
	// Token: 0x02000047 RID: 71
	[Register("mono/com/iab/omid/library/applovin/adsession/PossibleObstructionListenerImplementor")]
	internal sealed class IPossibleObstructionListenerImplementor : Java.Lang.Object, IPossibleObstructionListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060001EE RID: 494 RVA: 0x000053A6 File Offset: 0x000035A6
		public IPossibleObstructionListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/iab/omid/library/applovin/adsession/PossibleObstructionListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x000053E0 File Offset: 0x000035E0
		public void OnPossibleObstructionsDetected(string p0, IList<View> p1)
		{
			EventHandler<PossibleObstructionEventArgs> handler = this.Handler;
			if (handler != null)
			{
				handler(this.sender, new PossibleObstructionEventArgs(p0, p1));
			}
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0000540A File Offset: 0x0000360A
		internal static bool __IsEmpty(IPossibleObstructionListenerImplementor value)
		{
			return value.Handler == null;
		}

		// Token: 0x04000050 RID: 80
		private object sender;

		// Token: 0x04000051 RID: 81
		public EventHandler<PossibleObstructionEventArgs> Handler;
	}
}
