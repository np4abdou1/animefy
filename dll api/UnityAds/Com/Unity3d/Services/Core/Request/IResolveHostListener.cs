using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Services.Core.Request
{
	// Token: 0x0200009E RID: 158
	[Register("com/unity3d/services/core/request/IResolveHostListener", "", "Com.Unity3d.Services.Core.Request.IResolveHostListenerInvoker")]
	public interface IResolveHostListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060005C3 RID: 1475
		[Register("onFailed", "(Ljava/lang/String;Lcom/unity3d/services/core/request/ResolveHostError;Ljava/lang/String;)V", "GetOnFailed_Ljava_lang_String_Lcom_unity3d_services_core_request_ResolveHostError_Ljava_lang_String_Handler:Com.Unity3d.Services.Core.Request.IResolveHostListenerInvoker, UnityAds")]
		void OnFailed(string p0, ResolveHostError p1, string p2);

		// Token: 0x060005C4 RID: 1476
		[Register("onResolve", "(Ljava/lang/String;Ljava/lang/String;)V", "GetOnResolve_Ljava_lang_String_Ljava_lang_String_Handler:Com.Unity3d.Services.Core.Request.IResolveHostListenerInvoker, UnityAds")]
		void OnResolve(string p0, string p1);
	}
}
