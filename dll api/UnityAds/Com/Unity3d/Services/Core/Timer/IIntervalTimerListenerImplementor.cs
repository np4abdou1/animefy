using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Timer
{
	// Token: 0x02000096 RID: 150
	[Register("mono/com/unity3d/services/core/timer/IIntervalTimerListenerImplementor")]
	internal sealed class IIntervalTimerListenerImplementor : Java.Lang.Object, IIntervalTimerListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000582 RID: 1410 RVA: 0x0000FAC6 File Offset: 0x0000DCC6
		public IIntervalTimerListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/unity3d/services/core/timer/IIntervalTimerListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x0000FB00 File Offset: 0x0000DD00
		public void OnNextIntervalTriggered()
		{
			EventHandler handler = this.Handler;
			if (handler != null)
			{
				handler(this.sender, new EventArgs());
			}
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x0000FB28 File Offset: 0x0000DD28
		internal static bool __IsEmpty(IIntervalTimerListenerImplementor value)
		{
			return value.Handler == null;
		}

		// Token: 0x0400013F RID: 319
		private object sender;

		// Token: 0x04000140 RID: 320
		public EventHandler Handler;
	}
}
