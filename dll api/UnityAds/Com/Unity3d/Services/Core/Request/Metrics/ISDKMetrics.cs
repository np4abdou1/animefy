using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Services.Core.Request.Metrics
{
	// Token: 0x020000BD RID: 189
	[Register("com/unity3d/services/core/request/metrics/ISDKMetrics", "", "Com.Unity3d.Services.Core.Request.Metrics.ISDKMetricsInvoker")]
	public interface ISDKMetrics : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700023A RID: 570
		// (get) Token: 0x060006F2 RID: 1778
		string MetricEndPoint { [Register("getMetricEndPoint", "()Ljava/lang/String;", "GetGetMetricEndPointHandler:Com.Unity3d.Services.Core.Request.Metrics.ISDKMetricsInvoker, UnityAds")] get; }

		// Token: 0x060006F3 RID: 1779
		[Register("areMetricsEnabledForCurrentSession", "()Z", "GetAreMetricsEnabledForCurrentSessionHandler:Com.Unity3d.Services.Core.Request.Metrics.ISDKMetricsInvoker, UnityAds")]
		bool AreMetricsEnabledForCurrentSession();

		// Token: 0x060006F4 RID: 1780
		[Register("sendEvent", "(Ljava/lang/String;)V", "GetSendEvent_Ljava_lang_String_Handler:Com.Unity3d.Services.Core.Request.Metrics.ISDKMetricsInvoker, UnityAds")]
		void SendEvent(string p0);

		// Token: 0x060006F5 RID: 1781
		[Register("sendEvent", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V", "GetSendEvent_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Handler:Com.Unity3d.Services.Core.Request.Metrics.ISDKMetricsInvoker, UnityAds")]
		void SendEvent(string p0, string p1, IDictionary<string, string> p2);

		// Token: 0x060006F6 RID: 1782
		[Register("sendEvent", "(Ljava/lang/String;Ljava/util/Map;)V", "GetSendEvent_Ljava_lang_String_Ljava_util_Map_Handler:Com.Unity3d.Services.Core.Request.Metrics.ISDKMetricsInvoker, UnityAds")]
		void SendEvent(string p0, IDictionary<string, string> p1);

		// Token: 0x060006F7 RID: 1783
		[Register("sendMetric", "(Lcom/unity3d/services/core/request/metrics/Metric;)V", "GetSendMetric_Lcom_unity3d_services_core_request_metrics_Metric_Handler:Com.Unity3d.Services.Core.Request.Metrics.ISDKMetricsInvoker, UnityAds")]
		void SendMetric(Metric p0);

		// Token: 0x060006F8 RID: 1784
		[Register("sendMetricWithInitState", "(Lcom/unity3d/services/core/request/metrics/Metric;)V", "GetSendMetricWithInitState_Lcom_unity3d_services_core_request_metrics_Metric_Handler:Com.Unity3d.Services.Core.Request.Metrics.ISDKMetricsInvoker, UnityAds")]
		void SendMetricWithInitState(Metric p0);

		// Token: 0x060006F9 RID: 1785
		[Register("sendMetrics", "(Ljava/util/List;)V", "GetSendMetrics_Ljava_util_List_Handler:Com.Unity3d.Services.Core.Request.Metrics.ISDKMetricsInvoker, UnityAds")]
		void SendMetrics(IList<Metric> p0);
	}
}
