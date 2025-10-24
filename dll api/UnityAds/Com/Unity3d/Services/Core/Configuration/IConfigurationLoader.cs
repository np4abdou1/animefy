using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Services.Core.Configuration
{
	// Token: 0x0200015D RID: 349
	[Register("com/unity3d/services/core/configuration/IConfigurationLoader", "", "Com.Unity3d.Services.Core.Configuration.IConfigurationLoaderInvoker")]
	public interface IConfigurationLoader : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06000F23 RID: 3875
		Configuration LocalConfiguration { [Register("getLocalConfiguration", "()Lcom/unity3d/services/core/configuration/Configuration;", "GetGetLocalConfigurationHandler:Com.Unity3d.Services.Core.Configuration.IConfigurationLoaderInvoker, UnityAds")] get; }

		// Token: 0x06000F24 RID: 3876
		[Register("loadConfiguration", "(Lcom/unity3d/services/core/configuration/IConfigurationLoaderListener;)V", "GetLoadConfiguration_Lcom_unity3d_services_core_configuration_IConfigurationLoaderListener_Handler:Com.Unity3d.Services.Core.Configuration.IConfigurationLoaderInvoker, UnityAds")]
		void LoadConfiguration(IConfigurationLoaderListener p0);
	}
}
