using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Manager
{
	// Token: 0x0200007D RID: 125
	[Register("mono/com/bumptech/glide/manager/LifecycleListenerImplementor")]
	internal sealed class ILifecycleListenerImplementor : Java.Lang.Object, ILifecycleListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600054A RID: 1354 RVA: 0x000113F8 File Offset: 0x0000F5F8
		public ILifecycleListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/bumptech/glide/manager/LifecycleListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00011434 File Offset: 0x0000F634
		public void OnDestroy()
		{
			EventHandler onDestroyHandler = this.OnDestroyHandler;
			if (onDestroyHandler != null)
			{
				onDestroyHandler(this.sender, new EventArgs());
			}
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x0001145C File Offset: 0x0000F65C
		public void OnStart()
		{
			EventHandler onStartHandler = this.OnStartHandler;
			if (onStartHandler != null)
			{
				onStartHandler(this.sender, new EventArgs());
			}
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00011484 File Offset: 0x0000F684
		public void OnStop()
		{
			EventHandler onStopHandler = this.OnStopHandler;
			if (onStopHandler != null)
			{
				onStopHandler(this.sender, new EventArgs());
			}
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x000114AC File Offset: 0x0000F6AC
		internal static bool __IsEmpty(ILifecycleListenerImplementor value)
		{
			return value.OnDestroyHandler == null && value.OnStartHandler == null && value.OnStopHandler == null;
		}

		// Token: 0x0400012D RID: 301
		private object sender;

		// Token: 0x0400012E RID: 302
		public EventHandler OnDestroyHandler;

		// Token: 0x0400012F RID: 303
		public EventHandler OnStartHandler;

		// Token: 0x04000130 RID: 304
		public EventHandler OnStopHandler;
	}
}
