using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Services.Core.Configuration
{
	// Token: 0x02000166 RID: 358
	[Register("com/unity3d/services/core/configuration/IInitializationListener", "", "Com.Unity3d.Services.Core.Configuration.IInitializationListenerInvoker")]
	public interface IInitializationListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000F9A RID: 3994
		[Register("onSdkInitializationFailed", "(Ljava/lang/String;Lcom/unity3d/services/core/configuration/ErrorState;I)V", "GetOnSdkInitializationFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_IHandler:Com.Unity3d.Services.Core.Configuration.IInitializationListenerInvoker, UnityAds")]
		void OnSdkInitializationFailed(string p0, ErrorState p1, int p2);

		// Token: 0x06000F9B RID: 3995
		[Register("onSdkInitialized", "()V", "GetOnSdkInitializedHandler:Com.Unity3d.Services.Core.Configuration.IInitializationListenerInvoker, UnityAds")]
		void OnSdkInitialized();
	}
}
