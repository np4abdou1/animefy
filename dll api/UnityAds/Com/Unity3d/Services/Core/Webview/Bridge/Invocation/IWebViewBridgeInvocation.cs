using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Webview.Bridge.Invocation
{
	// Token: 0x02000085 RID: 133
	[Register("com/unity3d/services/core/webview/bridge/invocation/IWebViewBridgeInvocation", "", "Com.Unity3d.Services.Core.Webview.Bridge.Invocation.IWebViewBridgeInvocationInvoker")]
	public interface IWebViewBridgeInvocation : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060004C4 RID: 1220
		[Register("invoke", "(Ljava/lang/String;Ljava/lang/String;I[Ljava/lang/Object;)V", "GetInvoke_Ljava_lang_String_Ljava_lang_String_IarrayLjava_lang_Object_Handler:Com.Unity3d.Services.Core.Webview.Bridge.Invocation.IWebViewBridgeInvocationInvoker, UnityAds")]
		void Invoke(string p0, string p1, int p2, params Java.Lang.Object[] p3);
	}
}
