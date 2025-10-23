using System;
using Android.Runtime;
using Java.Interop;

namespace Bumptech.Glide.Manager
{
	// Token: 0x02000071 RID: 113
	[Register("com/bumptech/glide/manager/ConnectivityMonitor$ConnectivityListener", "", "Bumptech.Glide.Manager.IConnectivityMonitorConnectivityListenerInvoker")]
	public interface IConnectivityMonitorConnectivityListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060004F3 RID: 1267
		[Register("onConnectivityChanged", "(Z)V", "GetOnConnectivityChanged_ZHandler:Bumptech.Glide.Manager.IConnectivityMonitorConnectivityListenerInvoker, Xamarin.Android.Glide")]
		void OnConnectivityChanged(bool p0);
	}
}
