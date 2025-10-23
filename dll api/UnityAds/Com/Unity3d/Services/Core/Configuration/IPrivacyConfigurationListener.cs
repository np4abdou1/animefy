using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Services.Core.Configuration
{
	// Token: 0x02000174 RID: 372
	[Register("com/unity3d/services/core/configuration/IPrivacyConfigurationListener", "", "Com.Unity3d.Services.Core.Configuration.IPrivacyConfigurationListenerInvoker")]
	public interface IPrivacyConfigurationListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060010AC RID: 4268
		[Register("onError", "(Ljava/lang/String;)V", "GetOnError_Ljava_lang_String_Handler:Com.Unity3d.Services.Core.Configuration.IPrivacyConfigurationListenerInvoker, UnityAds")]
		void OnError(string p0);

		// Token: 0x060010AD RID: 4269
		[Register("onSuccess", "(Lcom/unity3d/services/core/configuration/PrivacyConfig;)V", "GetOnSuccess_Lcom_unity3d_services_core_configuration_PrivacyConfig_Handler:Com.Unity3d.Services.Core.Configuration.IPrivacyConfigurationListenerInvoker, UnityAds")]
		void OnSuccess(PrivacyConfig p0);
	}
}
