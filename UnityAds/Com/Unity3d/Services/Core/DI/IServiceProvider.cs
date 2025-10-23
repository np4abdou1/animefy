using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Services.Core.DI
{
	// Token: 0x0200010E RID: 270
	[Register("com/unity3d/services/core/di/IServiceProvider", "", "Com.Unity3d.Services.Core.DI.IServiceProviderInvoker")]
	public interface IServiceProvider : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000A8C RID: 2700
		IServicesRegistry Registry { [Register("getRegistry", "()Lcom/unity3d/services/core/di/IServicesRegistry;", "GetGetRegistryHandler:Com.Unity3d.Services.Core.DI.IServiceProviderInvoker, UnityAds")] get; }

		// Token: 0x06000A8D RID: 2701
		[Register("initialize", "()Lcom/unity3d/services/core/di/IServicesRegistry;", "GetInitializeHandler:Com.Unity3d.Services.Core.DI.IServiceProviderInvoker, UnityAds")]
		IServicesRegistry Initialize();
	}
}
