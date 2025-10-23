using System;
using Android.Runtime;
using Com.Unity3d.Services.Core.Request.Metrics;
using Com.Unity3d.Services.Core.Webview.Bridge;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Operation
{
	// Token: 0x020001E8 RID: 488
	[Register("com/unity3d/services/ads/operation/IAdModule", "", "Com.Unity3d.Services.Ads.Operation.IAdModuleInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T extends com.unity3d.services.core.webview.bridge.IWebViewSharedObject",
		"T2"
	})]
	public interface IAdModule : IWebViewBridgeSharedObjectStore, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x06001634 RID: 5684
		ISDKMetrics MetricSender { [Register("getMetricSender", "()Lcom/unity3d/services/core/request/metrics/ISDKMetrics;", "GetGetMetricSenderHandler:Com.Unity3d.Services.Ads.Operation.IAdModuleInvoker, UnityAds")] get; }

		// Token: 0x06001635 RID: 5685
		[Register("executeAdOperation", "(Lcom/unity3d/services/core/webview/bridge/IWebViewBridgeInvoker;Ljava/lang/Object;)V", "GetExecuteAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Ljava_lang_Object_Handler:Com.Unity3d.Services.Ads.Operation.IAdModuleInvoker, UnityAds")]
		void ExecuteAdOperation(IWebViewBridgeInvoker p0, Java.Lang.Object p1);
	}
}
