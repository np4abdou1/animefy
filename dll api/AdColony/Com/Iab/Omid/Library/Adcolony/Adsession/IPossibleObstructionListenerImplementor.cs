using System;
using System.Collections.Generic;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace Com.Iab.Omid.Library.Adcolony.Adsession
{
	// Token: 0x02000032 RID: 50
	[Register("mono/com/iab/omid/library/adcolony/adsession/PossibleObstructionListenerImplementor")]
	internal sealed class IPossibleObstructionListenerImplementor : Java.Lang.Object, IPossibleObstructionListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000197 RID: 407 RVA: 0x000052DE File Offset: 0x000034DE
		public IPossibleObstructionListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/iab/omid/library/adcolony/adsession/PossibleObstructionListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00005318 File Offset: 0x00003518
		public void OnPossibleObstructionsDetected(string p0, IList<View> p1)
		{
			EventHandler<PossibleObstructionEventArgs> handler = this.Handler;
			if (handler != null)
			{
				handler(this.sender, new PossibleObstructionEventArgs(p0, p1));
			}
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00005342 File Offset: 0x00003542
		internal static bool __IsEmpty(IPossibleObstructionListenerImplementor value)
		{
			return value.Handler == null;
		}

		// Token: 0x0400004D RID: 77
		private object sender;

		// Token: 0x0400004E RID: 78
		public EventHandler<PossibleObstructionEventArgs> Handler;
	}
}
