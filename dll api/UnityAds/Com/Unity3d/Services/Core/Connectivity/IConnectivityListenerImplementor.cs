using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Connectivity
{
	// Token: 0x0200014D RID: 333
	[Register("mono/com/unity3d/services/core/connectivity/IConnectivityListenerImplementor")]
	internal sealed class IConnectivityListenerImplementor : Java.Lang.Object, IConnectivityListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000D56 RID: 3414 RVA: 0x00025571 File Offset: 0x00023771
		public IConnectivityListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/unity3d/services/core/connectivity/IConnectivityListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x000255AC File Offset: 0x000237AC
		public void OnConnected()
		{
			EventHandler onConnectedHandler = this.OnConnectedHandler;
			if (onConnectedHandler != null)
			{
				onConnectedHandler(this.sender, new EventArgs());
			}
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x000255D4 File Offset: 0x000237D4
		public void OnDisconnected()
		{
			EventHandler onDisconnectedHandler = this.OnDisconnectedHandler;
			if (onDisconnectedHandler != null)
			{
				onDisconnectedHandler(this.sender, new EventArgs());
			}
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x000255FC File Offset: 0x000237FC
		internal static bool __IsEmpty(IConnectivityListenerImplementor value)
		{
			return value.OnConnectedHandler == null && value.OnDisconnectedHandler == null;
		}

		// Token: 0x04000310 RID: 784
		private object sender;

		// Token: 0x04000311 RID: 785
		public EventHandler OnConnectedHandler;

		// Token: 0x04000312 RID: 786
		public EventHandler OnDisconnectedHandler;
	}
}
