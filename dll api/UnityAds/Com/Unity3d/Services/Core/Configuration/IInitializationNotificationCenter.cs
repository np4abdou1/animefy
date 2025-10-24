using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Services.Core.Configuration
{
	// Token: 0x0200016A RID: 362
	[Register("com/unity3d/services/core/configuration/IInitializationNotificationCenter", "", "Com.Unity3d.Services.Core.Configuration.IInitializationNotificationCenterInvoker")]
	public interface IInitializationNotificationCenter : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000FB3 RID: 4019
		[Register("addListener", "(Lcom/unity3d/services/core/configuration/IInitializationListener;)V", "GetAddListener_Lcom_unity3d_services_core_configuration_IInitializationListener_Handler:Com.Unity3d.Services.Core.Configuration.IInitializationNotificationCenterInvoker, UnityAds")]
		void AddListener(IInitializationListener p0);

		// Token: 0x06000FB4 RID: 4020
		[Register("removeListener", "(Lcom/unity3d/services/core/configuration/IInitializationListener;)V", "GetRemoveListener_Lcom_unity3d_services_core_configuration_IInitializationListener_Handler:Com.Unity3d.Services.Core.Configuration.IInitializationNotificationCenterInvoker, UnityAds")]
		void RemoveListener(IInitializationListener p0);

		// Token: 0x06000FB5 RID: 4021
		[Register("triggerOnSdkInitializationFailed", "(Ljava/lang/String;Lcom/unity3d/services/core/configuration/ErrorState;I)V", "GetTriggerOnSdkInitializationFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_IHandler:Com.Unity3d.Services.Core.Configuration.IInitializationNotificationCenterInvoker, UnityAds")]
		void TriggerOnSdkInitializationFailed(string p0, ErrorState p1, int p2);

		// Token: 0x06000FB6 RID: 4022
		[Register("triggerOnSdkInitialized", "()V", "GetTriggerOnSdkInitializedHandler:Com.Unity3d.Services.Core.Configuration.IInitializationNotificationCenterInvoker, UnityAds")]
		void TriggerOnSdkInitialized();
	}
}
