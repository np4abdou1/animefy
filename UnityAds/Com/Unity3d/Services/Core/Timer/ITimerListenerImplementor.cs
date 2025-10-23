using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Timer
{
	// Token: 0x0200009A RID: 154
	[Register("mono/com/unity3d/services/core/timer/ITimerListenerImplementor")]
	internal sealed class ITimerListenerImplementor : Java.Lang.Object, ITimerListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600059C RID: 1436 RVA: 0x0000FEBA File Offset: 0x0000E0BA
		public ITimerListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/unity3d/services/core/timer/ITimerListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x0000FEF4 File Offset: 0x0000E0F4
		public void OnTimerFinished()
		{
			EventHandler handler = this.Handler;
			if (handler != null)
			{
				handler(this.sender, new EventArgs());
			}
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x0000FF1C File Offset: 0x0000E11C
		internal static bool __IsEmpty(ITimerListenerImplementor value)
		{
			return value.Handler == null;
		}

		// Token: 0x04000147 RID: 327
		private object sender;

		// Token: 0x04000148 RID: 328
		public EventHandler Handler;
	}
}
