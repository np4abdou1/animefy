using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Webview.Bridge
{
	// Token: 0x02000076 RID: 118
	[Register("com/unity3d/services/core/webview/bridge/IWebViewBridgeSharedObjectStore", "", "Com.Unity3d.Services.Core.Webview.Bridge.IWebViewBridgeSharedObjectStoreInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T extends com.unity3d.services.core.webview.bridge.IWebViewSharedObject"
	})]
	public interface IWebViewBridgeSharedObjectStore : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600041A RID: 1050
		[Register("get", "(Ljava/lang/String;)Lcom/unity3d/services/core/webview/bridge/IWebViewSharedObject;", "GetGet_Ljava_lang_String_Handler:Com.Unity3d.Services.Core.Webview.Bridge.IWebViewBridgeSharedObjectStoreInvoker, UnityAds")]
		Java.Lang.Object Get(string p0);

		// Token: 0x0600041B RID: 1051
		[Register("remove", "(Ljava/lang/String;)V", "GetRemove_Ljava_lang_String_Handler:Com.Unity3d.Services.Core.Webview.Bridge.IWebViewBridgeSharedObjectStoreInvoker, UnityAds")]
		void Remove(string p0);

		// Token: 0x0600041C RID: 1052
		[Register("set", "(Lcom/unity3d/services/core/webview/bridge/IWebViewSharedObject;)V", "GetSet_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_Handler:Com.Unity3d.Services.Core.Webview.Bridge.IWebViewBridgeSharedObjectStoreInvoker, UnityAds")]
		void Set(Java.Lang.Object p0);
	}
}
