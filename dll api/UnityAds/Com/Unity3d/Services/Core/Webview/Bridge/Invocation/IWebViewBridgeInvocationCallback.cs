using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Services.Core.Webview.Bridge.Invocation
{
	// Token: 0x02000087 RID: 135
	[Register("com/unity3d/services/core/webview/bridge/invocation/IWebViewBridgeInvocationCallback", "", "Com.Unity3d.Services.Core.Webview.Bridge.Invocation.IWebViewBridgeInvocationCallbackInvoker")]
	public interface IWebViewBridgeInvocationCallback : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060004D1 RID: 1233
		[Register("onFailure", "(Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/CallbackStatus;)V", "GetOnFailure_Ljava_lang_String_Lcom_unity3d_services_core_webview_bridge_CallbackStatus_Handler:Com.Unity3d.Services.Core.Webview.Bridge.Invocation.IWebViewBridgeInvocationCallbackInvoker, UnityAds")]
		void OnFailure(string p0, CallbackStatus p1);

		// Token: 0x060004D2 RID: 1234
		[Register("onSuccess", "()V", "GetOnSuccessHandler:Com.Unity3d.Services.Core.Webview.Bridge.Invocation.IWebViewBridgeInvocationCallbackInvoker, UnityAds")]
		void OnSuccess();

		// Token: 0x060004D3 RID: 1235
		[Register("onTimeout", "()V", "GetOnTimeoutHandler:Com.Unity3d.Services.Core.Webview.Bridge.Invocation.IWebViewBridgeInvocationCallbackInvoker, UnityAds")]
		void OnTimeout();
	}
}
