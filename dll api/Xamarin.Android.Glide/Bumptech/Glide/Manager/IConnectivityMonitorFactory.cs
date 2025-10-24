using System;
using Android.Content;
using Android.Runtime;
using Java.Interop;

namespace Bumptech.Glide.Manager
{
	// Token: 0x02000077 RID: 119
	[Register("com/bumptech/glide/manager/ConnectivityMonitorFactory", "", "Bumptech.Glide.Manager.IConnectivityMonitorFactoryInvoker")]
	public interface IConnectivityMonitorFactory : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000517 RID: 1303
		[Register("build", "(Landroid/content/Context;Lcom/bumptech/glide/manager/ConnectivityMonitor$ConnectivityListener;)Lcom/bumptech/glide/manager/ConnectivityMonitor;", "GetBuild_Landroid_content_Context_Lcom_bumptech_glide_manager_ConnectivityMonitor_ConnectivityListener_Handler:Bumptech.Glide.Manager.IConnectivityMonitorFactoryInvoker, Xamarin.Android.Glide")]
		IConnectivityMonitor Build(Context p0, IConnectivityMonitorConnectivityListener p1);
	}
}
