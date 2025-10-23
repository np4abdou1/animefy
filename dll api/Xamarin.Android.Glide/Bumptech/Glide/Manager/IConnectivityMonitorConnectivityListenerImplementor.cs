using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Manager
{
	// Token: 0x02000074 RID: 116
	[Register("mono/com/bumptech/glide/manager/ConnectivityMonitor_ConnectivityListenerImplementor")]
	internal sealed class IConnectivityMonitorConnectivityListenerImplementor : Java.Lang.Object, IConnectivityMonitorConnectivityListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000502 RID: 1282 RVA: 0x00010A82 File Offset: 0x0000EC82
		public IConnectivityMonitorConnectivityListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/bumptech/glide/manager/ConnectivityMonitor_ConnectivityListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00010ABC File Offset: 0x0000ECBC
		public void OnConnectivityChanged(bool p0)
		{
			EventHandler<ConnectivityMonitorConnectivityEventArgs> handler = this.Handler;
			if (handler != null)
			{
				handler(this.sender, new ConnectivityMonitorConnectivityEventArgs(p0));
			}
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00010AE5 File Offset: 0x0000ECE5
		internal static bool __IsEmpty(IConnectivityMonitorConnectivityListenerImplementor value)
		{
			return value.Handler == null;
		}

		// Token: 0x04000111 RID: 273
		private object sender;

		// Token: 0x04000112 RID: 274
		public EventHandler<ConnectivityMonitorConnectivityEventArgs> Handler;
	}
}
