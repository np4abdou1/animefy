using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Reflect;

namespace Com.Unity3d.Services.Core.Webview.Bridge
{
	// Token: 0x02000074 RID: 116
	[Register("com/unity3d/services/core/webview/bridge/IWebViewBridgeInvoker", "", "Com.Unity3d.Services.Core.Webview.Bridge.IWebViewBridgeInvokerInvoker")]
	public interface IWebViewBridgeInvoker : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600040D RID: 1037
		[Register("invokeMethod", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Z", "GetInvokeMethod_Ljava_lang_String_Ljava_lang_String_Ljava_lang_reflect_Method_arrayLjava_lang_Object_Handler:Com.Unity3d.Services.Core.Webview.Bridge.IWebViewBridgeInvokerInvoker, UnityAds")]
		bool InvokeMethod(string p0, string p1, Method p2, params Java.Lang.Object[] p3);
	}
}
