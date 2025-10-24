using System;
using System.Collections.Generic;
using Android.Runtime;
using Com.Unity3d.Services.Core.Request.Metrics;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Configuration
{
	// Token: 0x0200016C RID: 364
	[Register("com/unity3d/services/core/configuration/IInitializeEventsMetricSender", "", "Com.Unity3d.Services.Core.Configuration.IInitializeEventsMetricSenderInvoker")]
	public interface IInitializeEventsMetricSender : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06000FCC RID: 4044
		IDictionary<string, string> RetryTags { [Register("getRetryTags", "()Ljava/util/Map;", "GetGetRetryTagsHandler:Com.Unity3d.Services.Core.Configuration.IInitializeEventsMetricSenderInvoker, UnityAds")] get; }

		// Token: 0x06000FCD RID: 4045
		[Register("configRequestDuration", "()Ljava/lang/Long;", "GetConfigRequestDurationHandler:Com.Unity3d.Services.Core.Configuration.IInitializeEventsMetricSenderInvoker, UnityAds")]
		Long ConfigRequestDuration();

		// Token: 0x06000FCE RID: 4046
		[Register("didConfigRequestEnd", "(Z)V", "GetDidConfigRequestEnd_ZHandler:Com.Unity3d.Services.Core.Configuration.IInitializeEventsMetricSenderInvoker, UnityAds")]
		void DidConfigRequestEnd(bool p0);

		// Token: 0x06000FCF RID: 4047
		[Register("didConfigRequestStart", "()V", "GetDidConfigRequestStartHandler:Com.Unity3d.Services.Core.Configuration.IInitializeEventsMetricSenderInvoker, UnityAds")]
		void DidConfigRequestStart();

		// Token: 0x06000FD0 RID: 4048
		[Register("didInitStart", "()V", "GetDidInitStartHandler:Com.Unity3d.Services.Core.Configuration.IInitializeEventsMetricSenderInvoker, UnityAds")]
		void DidInitStart();

		// Token: 0x06000FD1 RID: 4049
		[Register("didPrivacyConfigRequestEnd", "(Z)V", "GetDidPrivacyConfigRequestEnd_ZHandler:Com.Unity3d.Services.Core.Configuration.IInitializeEventsMetricSenderInvoker, UnityAds")]
		void DidPrivacyConfigRequestEnd(bool p0);

		// Token: 0x06000FD2 RID: 4050
		[Register("didPrivacyConfigRequestStart", "()V", "GetDidPrivacyConfigRequestStartHandler:Com.Unity3d.Services.Core.Configuration.IInitializeEventsMetricSenderInvoker, UnityAds")]
		void DidPrivacyConfigRequestStart();

		// Token: 0x06000FD3 RID: 4051
		[Register("duration", "()Ljava/lang/Long;", "GetDurationHandler:Com.Unity3d.Services.Core.Configuration.IInitializeEventsMetricSenderInvoker, UnityAds")]
		Long Duration();

		// Token: 0x06000FD4 RID: 4052
		[Register("initializationStartTimeStamp", "()Ljava/lang/Long;", "GetInitializationStartTimeStampHandler:Com.Unity3d.Services.Core.Configuration.IInitializeEventsMetricSenderInvoker, UnityAds")]
		Long InitializationStartTimeStamp();

		// Token: 0x06000FD5 RID: 4053
		[Register("onRetryConfig", "()V", "GetOnRetryConfigHandler:Com.Unity3d.Services.Core.Configuration.IInitializeEventsMetricSenderInvoker, UnityAds")]
		void OnRetryConfig();

		// Token: 0x06000FD6 RID: 4054
		[Register("onRetryWebview", "()V", "GetOnRetryWebviewHandler:Com.Unity3d.Services.Core.Configuration.IInitializeEventsMetricSenderInvoker, UnityAds")]
		void OnRetryWebview();

		// Token: 0x06000FD7 RID: 4055
		[Register("privacyConfigDuration", "()Ljava/lang/Long;", "GetPrivacyConfigDurationHandler:Com.Unity3d.Services.Core.Configuration.IInitializeEventsMetricSenderInvoker, UnityAds")]
		Long PrivacyConfigDuration();

		// Token: 0x06000FD8 RID: 4056
		[Register("sdkDidInitialize", "()V", "GetSdkDidInitializeHandler:Com.Unity3d.Services.Core.Configuration.IInitializeEventsMetricSenderInvoker, UnityAds")]
		void SdkDidInitialize();

		// Token: 0x06000FD9 RID: 4057
		[Register("sdkInitializeFailed", "(Ljava/lang/String;Lcom/unity3d/services/core/configuration/ErrorState;)V", "GetSdkInitializeFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_Handler:Com.Unity3d.Services.Core.Configuration.IInitializeEventsMetricSenderInvoker, UnityAds")]
		void SdkInitializeFailed(string p0, ErrorState p1);

		// Token: 0x06000FDA RID: 4058
		[Register("sdkTokenDidBecomeAvailableWithConfig", "(Z)V", "GetSdkTokenDidBecomeAvailableWithConfig_ZHandler:Com.Unity3d.Services.Core.Configuration.IInitializeEventsMetricSenderInvoker, UnityAds")]
		void SdkTokenDidBecomeAvailableWithConfig(bool p0);

		// Token: 0x06000FDB RID: 4059
		[Register("sendMetric", "(Lcom/unity3d/services/core/request/metrics/Metric;)V", "GetSendMetric_Lcom_unity3d_services_core_request_metrics_Metric_Handler:Com.Unity3d.Services.Core.Configuration.IInitializeEventsMetricSenderInvoker, UnityAds")]
		void SendMetric(Metric p0);

		// Token: 0x06000FDC RID: 4060
		[Register("setNewInitFlow", "(Z)V", "GetSetNewInitFlow_ZHandler:Com.Unity3d.Services.Core.Configuration.IInitializeEventsMetricSenderInvoker, UnityAds")]
		void SetNewInitFlow(bool p0);

		// Token: 0x06000FDD RID: 4061
		[Register("tokenDuration", "()Ljava/lang/Long;", "GetTokenDurationHandler:Com.Unity3d.Services.Core.Configuration.IInitializeEventsMetricSenderInvoker, UnityAds")]
		Long TokenDuration();
	}
}
