using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.DI
{
	// Token: 0x02000111 RID: 273
	[Register("com/unity3d/services/core/di/IServicesRegistry", "", "Com.Unity3d.Services.Core.DI.IServicesRegistryInvoker")]
	public interface IServicesRegistry : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000AA3 RID: 2723
		[Register("resolveService", "(Lcom/unity3d/services/core/di/ServiceKey;)Ljava/lang/Object;", "GetResolveService_Lcom_unity3d_services_core_di_ServiceKey_Handler:Com.Unity3d.Services.Core.DI.IServicesRegistryInvoker, UnityAds")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		Java.Lang.Object ResolveService(ServiceKey key);

		// Token: 0x06000AA4 RID: 2724
		[Register("resolveServiceOrNull", "(Lcom/unity3d/services/core/di/ServiceKey;)Ljava/lang/Object;", "GetResolveServiceOrNull_Lcom_unity3d_services_core_di_ServiceKey_Handler:Com.Unity3d.Services.Core.DI.IServicesRegistryInvoker, UnityAds")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		Java.Lang.Object ResolveServiceOrNull(ServiceKey key);
	}
}
