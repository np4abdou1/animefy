using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Services.Core.Configuration
{
	// Token: 0x0200015F RID: 351
	[Register("com/unity3d/services/core/configuration/IConfigurationLoaderListener", "", "Com.Unity3d.Services.Core.Configuration.IConfigurationLoaderListenerInvoker")]
	public interface IConfigurationLoaderListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000F34 RID: 3892
		[Register("onError", "(Ljava/lang/String;)V", "GetOnError_Ljava_lang_String_Handler:Com.Unity3d.Services.Core.Configuration.IConfigurationLoaderListenerInvoker, UnityAds")]
		void OnError(string p0);

		// Token: 0x06000F35 RID: 3893
		[Register("onSuccess", "(Lcom/unity3d/services/core/configuration/Configuration;)V", "GetOnSuccess_Lcom_unity3d_services_core_configuration_Configuration_Handler:Com.Unity3d.Services.Core.Configuration.IConfigurationLoaderListenerInvoker, UnityAds")]
		void OnSuccess(Configuration p0);
	}
}
