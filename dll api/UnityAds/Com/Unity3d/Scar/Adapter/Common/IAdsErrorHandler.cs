using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.Common
{
	// Token: 0x02000299 RID: 665
	[Register("com/unity3d/scar/adapter/common/IAdsErrorHandler", "", "Com.Unity3d.Scar.Adapter.Common.IAdsErrorHandlerInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T extends com.unity3d.scar.adapter.common.IUnityAdsError"
	})]
	public interface IAdsErrorHandler : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06002616 RID: 9750
		[Register("handleError", "(Lcom/unity3d/scar/adapter/common/IUnityAdsError;)V", "GetHandleError_Lcom_unity3d_scar_adapter_common_IUnityAdsError_Handler:Com.Unity3d.Scar.Adapter.Common.IAdsErrorHandlerInvoker, UnityAds")]
		void HandleError(Java.Lang.Object p0);
	}
}
