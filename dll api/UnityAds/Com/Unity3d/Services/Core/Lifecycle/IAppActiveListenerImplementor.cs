using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Lifecycle
{
	// Token: 0x020000EE RID: 238
	[Register("mono/com/unity3d/services/core/lifecycle/IAppActiveListenerImplementor")]
	internal sealed class IAppActiveListenerImplementor : Java.Lang.Object, IAppActiveListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000972 RID: 2418 RVA: 0x0001B936 File Offset: 0x00019B36
		public IAppActiveListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/unity3d/services/core/lifecycle/IAppActiveListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x0001B970 File Offset: 0x00019B70
		public void OnAppStateChanged(bool p0)
		{
			EventHandler<AppActiveEventArgs> handler = this.Handler;
			if (handler != null)
			{
				handler(this.sender, new AppActiveEventArgs(p0));
			}
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x0001B999 File Offset: 0x00019B99
		internal static bool __IsEmpty(IAppActiveListenerImplementor value)
		{
			return value.Handler == null;
		}

		// Token: 0x04000236 RID: 566
		private object sender;

		// Token: 0x04000237 RID: 567
		public EventHandler<AppActiveEventArgs> Handler;
	}
}
