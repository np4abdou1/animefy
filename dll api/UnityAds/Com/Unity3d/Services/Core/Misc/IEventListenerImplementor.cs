using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Misc
{
	// Token: 0x020000DA RID: 218
	[Register("mono/com/unity3d/services/core/misc/IEventListenerImplementor")]
	internal sealed class IEventListenerImplementor : Java.Lang.Object, IEventListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600088B RID: 2187 RVA: 0x00018B6F File Offset: 0x00016D6F
		public IEventListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/unity3d/services/core/misc/IEventListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x00018BA8 File Offset: 0x00016DA8
		public void OnNextEvent(Java.Lang.Object p0)
		{
			EventHandler<EventEventArgs> handler = this.Handler;
			if (handler != null)
			{
				handler(this.sender, new EventEventArgs(p0));
			}
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x00018BD1 File Offset: 0x00016DD1
		internal static bool __IsEmpty(IEventListenerImplementor value)
		{
			return value.Handler == null;
		}

		// Token: 0x04000201 RID: 513
		private object sender;

		// Token: 0x04000202 RID: 514
		public EventHandler<EventEventArgs> Handler;
	}
}
