using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Services.Core.DI
{
	// Token: 0x0200010B RID: 267
	[Register("com/unity3d/services/core/di/ServiceComponent", "", "Com.Unity3d.Services.Core.DI.IServiceComponentInvoker")]
	public interface IServiceComponent : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000A79 RID: 2681
		ServiceProvider ServiceProvider { [Register("getServiceProvider", "()Lcom/unity3d/services/core/di/ServiceProvider;", "GetGetServiceProviderHandler:Com.Unity3d.Services.Core.DI.IServiceComponentInvoker, UnityAds")] get; }
	}
}
