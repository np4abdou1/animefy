using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Configuration
{
	// Token: 0x0200016E RID: 366
	[Register("com/unity3d/services/core/configuration/IModuleConfiguration", "", "Com.Unity3d.Services.Core.Configuration.IModuleConfigurationInvoker")]
	public interface IModuleConfiguration : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600101D RID: 4125
		[Register("getWebAppApiClassList", "()[Ljava/lang/Class;", "GetGetWebAppApiClassListHandler:Com.Unity3d.Services.Core.Configuration.IModuleConfigurationInvoker, UnityAds")]
		Class[] GetWebAppApiClassList();

		// Token: 0x0600101E RID: 4126
		[Register("initCompleteState", "(Lcom/unity3d/services/core/configuration/Configuration;)Z", "GetInitCompleteState_Lcom_unity3d_services_core_configuration_Configuration_Handler:Com.Unity3d.Services.Core.Configuration.IModuleConfigurationInvoker, UnityAds")]
		bool InitCompleteState(Configuration p0);

		// Token: 0x0600101F RID: 4127
		[Register("initErrorState", "(Lcom/unity3d/services/core/configuration/Configuration;Lcom/unity3d/services/core/configuration/ErrorState;Ljava/lang/String;)Z", "GetInitErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_Handler:Com.Unity3d.Services.Core.Configuration.IModuleConfigurationInvoker, UnityAds")]
		bool InitErrorState(Configuration p0, ErrorState p1, string p2);

		// Token: 0x06001020 RID: 4128
		[Register("initModuleState", "(Lcom/unity3d/services/core/configuration/Configuration;)Z", "GetInitModuleState_Lcom_unity3d_services_core_configuration_Configuration_Handler:Com.Unity3d.Services.Core.Configuration.IModuleConfigurationInvoker, UnityAds")]
		bool InitModuleState(Configuration p0);

		// Token: 0x06001021 RID: 4129
		[Register("resetState", "(Lcom/unity3d/services/core/configuration/Configuration;)Z", "GetResetState_Lcom_unity3d_services_core_configuration_Configuration_Handler:Com.Unity3d.Services.Core.Configuration.IModuleConfigurationInvoker, UnityAds")]
		bool ResetState(Configuration p0);
	}
}
