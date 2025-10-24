using System;
using Android.Runtime;
using Java.Interop;

namespace Bumptech.Glide.Manager
{
	// Token: 0x02000075 RID: 117
	[Register("com/bumptech/glide/manager/ConnectivityMonitor", "", "Bumptech.Glide.Manager.IConnectivityMonitorInvoker")]
	public interface IConnectivityMonitor : ILifecycleListener, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
