using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Services.Core.Connectivity
{
	// Token: 0x0200014B RID: 331
	[Register("com/unity3d/services/core/connectivity/IConnectivityListener", "", "Com.Unity3d.Services.Core.Connectivity.IConnectivityListenerInvoker")]
	public interface IConnectivityListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000D45 RID: 3397
		[Register("onConnected", "()V", "GetOnConnectedHandler:Com.Unity3d.Services.Core.Connectivity.IConnectivityListenerInvoker, UnityAds")]
		void OnConnected();

		// Token: 0x06000D46 RID: 3398
		[Register("onDisconnected", "()V", "GetOnDisconnectedHandler:Com.Unity3d.Services.Core.Connectivity.IConnectivityListenerInvoker, UnityAds")]
		void OnDisconnected();
	}
}
