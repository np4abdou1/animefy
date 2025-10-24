using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Configuration;
using Com.Unity3d.Services.Core.Properties;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Request.Metrics
{
	// Token: 0x020000C2 RID: 194
	[Register("com/unity3d/services/core/request/metrics/MetricSender", DoNotGenerateAcw = true)]
	public class MetricSender : Java.Lang.Object
	{
		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000745 RID: 1861 RVA: 0x00014784 File Offset: 0x00012984
		internal static IntPtr class_ref
		{
			get
			{
				return MetricSender._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x000147A8 File Offset: 0x000129A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MetricSender._members;
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000747 RID: 1863 RVA: 0x000147B0 File Offset: 0x000129B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MetricSender._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x000147D4 File Offset: 0x000129D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MetricSender._members.ManagedPeerType;
			}
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x000021E8 File Offset: 0x000003E8
		protected MetricSender(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x000147E0 File Offset: 0x000129E0
		[Register(".ctor", "(Lcom/unity3d/services/core/configuration/Configuration;Lcom/unity3d/services/core/properties/InitializationStatusReader;)V", "")]
		public unsafe MetricSender(Configuration configuration, InitializationStatusReader initializationStatusReader) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((configuration == null) ? IntPtr.Zero : configuration.Handle);
				ptr[1] = new JniArgumentValue((initializationStatusReader == null) ? IntPtr.Zero : initializationStatusReader.Handle);
				base.SetHandle(MetricSender._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/services/core/configuration/Configuration;Lcom/unity3d/services/core/properties/InitializationStatusReader;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MetricSender._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/services/core/configuration/Configuration;Lcom/unity3d/services/core/properties/InitializationStatusReader;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(configuration);
				GC.KeepAlive(initializationStatusReader);
			}
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x000148B8 File Offset: 0x00012AB8
		private static Delegate GetGetMetricEndPointHandler()
		{
			if (MetricSender.cb_getMetricEndPoint == null)
			{
				MetricSender.cb_getMetricEndPoint = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MetricSender.n_GetMetricEndPoint));
			}
			return MetricSender.cb_getMetricEndPoint;
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x000148DC File Offset: 0x00012ADC
		private static IntPtr n_GetMetricEndPoint(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<MetricSender>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MetricEndPoint);
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x0600074D RID: 1869 RVA: 0x000148F0 File Offset: 0x00012AF0
		public virtual string MetricEndPoint
		{
			[Register("getMetricEndPoint", "()Ljava/lang/String;", "GetGetMetricEndPointHandler")]
			get
			{
				return JNIEnv.GetString(MetricSender._members.InstanceMethods.InvokeVirtualObjectMethod("getMetricEndPoint.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x00014922 File Offset: 0x00012B22
		private static Delegate GetAreMetricsEnabledForCurrentSessionHandler()
		{
			if (MetricSender.cb_areMetricsEnabledForCurrentSession == null)
			{
				MetricSender.cb_areMetricsEnabledForCurrentSession = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(MetricSender.n_AreMetricsEnabledForCurrentSession));
			}
			return MetricSender.cb_areMetricsEnabledForCurrentSession;
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x00014946 File Offset: 0x00012B46
		private static bool n_AreMetricsEnabledForCurrentSession(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<MetricSender>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AreMetricsEnabledForCurrentSession();
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00014955 File Offset: 0x00012B55
		[Register("areMetricsEnabledForCurrentSession", "()Z", "GetAreMetricsEnabledForCurrentSessionHandler")]
		public virtual bool AreMetricsEnabledForCurrentSession()
		{
			return MetricSender._members.InstanceMethods.InvokeVirtualBooleanMethod("areMetricsEnabledForCurrentSession.()Z", this, null);
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x0001496E File Offset: 0x00012B6E
		private static Delegate GetSendEvent_Ljava_lang_String_Handler()
		{
			if (MetricSender.cb_sendEvent_Ljava_lang_String_ == null)
			{
				MetricSender.cb_sendEvent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MetricSender.n_SendEvent_Ljava_lang_String_));
			}
			return MetricSender.cb_sendEvent_Ljava_lang_String_;
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x00014994 File Offset: 0x00012B94
		private static void n_SendEvent_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			MetricSender @object = Java.Lang.Object.GetObject<MetricSender>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_e, JniHandleOwnership.DoNotTransfer);
			@object.SendEvent(@string);
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x000149B8 File Offset: 0x00012BB8
		[Register("sendEvent", "(Ljava/lang/String;)V", "GetSendEvent_Ljava_lang_String_Handler")]
		public unsafe virtual void SendEvent(string e)
		{
			IntPtr intPtr = JNIEnv.NewString(e);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				MetricSender._members.InstanceMethods.InvokeVirtualVoidMethod("sendEvent.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x00014A14 File Offset: 0x00012C14
		private static Delegate GetSendEvent_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Handler()
		{
			if (MetricSender.cb_sendEvent_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ == null)
			{
				MetricSender.cb_sendEvent_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(MetricSender.n_SendEvent_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_));
			}
			return MetricSender.cb_sendEvent_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x00014A38 File Offset: 0x00012C38
		private static void n_SendEvent_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_e, IntPtr native_value, IntPtr native_tags)
		{
			MetricSender @object = Java.Lang.Object.GetObject<MetricSender>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_e, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_value, JniHandleOwnership.DoNotTransfer);
			IDictionary<string, string> tags = JavaDictionary<string, string>.FromJniHandle(native_tags, JniHandleOwnership.DoNotTransfer);
			@object.SendEvent(@string, string2, tags);
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x00014A70 File Offset: 0x00012C70
		[Register("sendEvent", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V", "GetSendEvent_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Handler")]
		public unsafe virtual void SendEvent(string e, string value, IDictionary<string, string> tags)
		{
			IntPtr intPtr = JNIEnv.NewString(e);
			IntPtr intPtr2 = JNIEnv.NewString(value);
			IntPtr intPtr3 = JavaDictionary<string, string>.ToLocalJniHandle(tags);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				MetricSender._members.InstanceMethods.InvokeVirtualVoidMethod("sendEvent.(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				GC.KeepAlive(tags);
			}
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x00014B14 File Offset: 0x00012D14
		private static Delegate GetSendEvent_Ljava_lang_String_Ljava_util_Map_Handler()
		{
			if (MetricSender.cb_sendEvent_Ljava_lang_String_Ljava_util_Map_ == null)
			{
				MetricSender.cb_sendEvent_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(MetricSender.n_SendEvent_Ljava_lang_String_Ljava_util_Map_));
			}
			return MetricSender.cb_sendEvent_Ljava_lang_String_Ljava_util_Map_;
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x00014B38 File Offset: 0x00012D38
		private static void n_SendEvent_Ljava_lang_String_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_e, IntPtr native_tags)
		{
			MetricSender @object = Java.Lang.Object.GetObject<MetricSender>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_e, JniHandleOwnership.DoNotTransfer);
			IDictionary<string, string> tags = JavaDictionary<string, string>.FromJniHandle(native_tags, JniHandleOwnership.DoNotTransfer);
			@object.SendEvent(@string, tags);
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x00014B64 File Offset: 0x00012D64
		[Register("sendEvent", "(Ljava/lang/String;Ljava/util/Map;)V", "GetSendEvent_Ljava_lang_String_Ljava_util_Map_Handler")]
		public unsafe virtual void SendEvent(string e, IDictionary<string, string> tags)
		{
			IntPtr intPtr = JNIEnv.NewString(e);
			IntPtr intPtr2 = JavaDictionary<string, string>.ToLocalJniHandle(tags);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				MetricSender._members.InstanceMethods.InvokeVirtualVoidMethod("sendEvent.(Ljava/lang/String;Ljava/util/Map;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(tags);
			}
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x00014BE8 File Offset: 0x00012DE8
		private static Delegate GetSendMetric_Lcom_unity3d_services_core_request_metrics_Metric_Handler()
		{
			if (MetricSender.cb_sendMetric_Lcom_unity3d_services_core_request_metrics_Metric_ == null)
			{
				MetricSender.cb_sendMetric_Lcom_unity3d_services_core_request_metrics_Metric_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MetricSender.n_SendMetric_Lcom_unity3d_services_core_request_metrics_Metric_));
			}
			return MetricSender.cb_sendMetric_Lcom_unity3d_services_core_request_metrics_Metric_;
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x00014C0C File Offset: 0x00012E0C
		private static void n_SendMetric_Lcom_unity3d_services_core_request_metrics_Metric_(IntPtr jnienv, IntPtr native__this, IntPtr native_metric)
		{
			MetricSender @object = Java.Lang.Object.GetObject<MetricSender>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Metric object2 = Java.Lang.Object.GetObject<Metric>(native_metric, JniHandleOwnership.DoNotTransfer);
			@object.SendMetric(object2);
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x00014C30 File Offset: 0x00012E30
		[Register("sendMetric", "(Lcom/unity3d/services/core/request/metrics/Metric;)V", "GetSendMetric_Lcom_unity3d_services_core_request_metrics_Metric_Handler")]
		public unsafe virtual void SendMetric(Metric metric)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((metric == null) ? IntPtr.Zero : metric.Handle);
				MetricSender._members.InstanceMethods.InvokeVirtualVoidMethod("sendMetric.(Lcom/unity3d/services/core/request/metrics/Metric;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(metric);
			}
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x00014C94 File Offset: 0x00012E94
		private static Delegate GetSendMetricWithInitState_Lcom_unity3d_services_core_request_metrics_Metric_Handler()
		{
			if (MetricSender.cb_sendMetricWithInitState_Lcom_unity3d_services_core_request_metrics_Metric_ == null)
			{
				MetricSender.cb_sendMetricWithInitState_Lcom_unity3d_services_core_request_metrics_Metric_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MetricSender.n_SendMetricWithInitState_Lcom_unity3d_services_core_request_metrics_Metric_));
			}
			return MetricSender.cb_sendMetricWithInitState_Lcom_unity3d_services_core_request_metrics_Metric_;
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x00014CB8 File Offset: 0x00012EB8
		private static void n_SendMetricWithInitState_Lcom_unity3d_services_core_request_metrics_Metric_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MetricSender @object = Java.Lang.Object.GetObject<MetricSender>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Metric object2 = Java.Lang.Object.GetObject<Metric>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SendMetricWithInitState(object2);
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00014CDC File Offset: 0x00012EDC
		[Register("sendMetricWithInitState", "(Lcom/unity3d/services/core/request/metrics/Metric;)V", "GetSendMetricWithInitState_Lcom_unity3d_services_core_request_metrics_Metric_Handler")]
		public unsafe virtual void SendMetricWithInitState(Metric p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				MetricSender._members.InstanceMethods.InvokeVirtualVoidMethod("sendMetricWithInitState.(Lcom/unity3d/services/core/request/metrics/Metric;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x00014D40 File Offset: 0x00012F40
		private static Delegate GetSendMetrics_Ljava_util_List_Handler()
		{
			if (MetricSender.cb_sendMetrics_Ljava_util_List_ == null)
			{
				MetricSender.cb_sendMetrics_Ljava_util_List_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MetricSender.n_SendMetrics_Ljava_util_List_));
			}
			return MetricSender.cb_sendMetrics_Ljava_util_List_;
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x00014D64 File Offset: 0x00012F64
		private static void n_SendMetrics_Ljava_util_List_(IntPtr jnienv, IntPtr native__this, IntPtr native_metrics)
		{
			MetricSender @object = Java.Lang.Object.GetObject<MetricSender>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IList<Metric> metrics = JavaList<Metric>.FromJniHandle(native_metrics, JniHandleOwnership.DoNotTransfer);
			@object.SendMetrics(metrics);
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x00014D88 File Offset: 0x00012F88
		[Register("sendMetrics", "(Ljava/util/List;)V", "GetSendMetrics_Ljava_util_List_Handler")]
		public unsafe virtual void SendMetrics(IList<Metric> metrics)
		{
			IntPtr intPtr = JavaList<Metric>.ToLocalJniHandle(metrics);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				MetricSender._members.InstanceMethods.InvokeVirtualVoidMethod("sendMetrics.(Ljava/util/List;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(metrics);
			}
		}

		// Token: 0x040001C4 RID: 452
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/request/metrics/MetricSender", typeof(MetricSender));

		// Token: 0x040001C5 RID: 453
		private static Delegate cb_getMetricEndPoint;

		// Token: 0x040001C6 RID: 454
		private static Delegate cb_areMetricsEnabledForCurrentSession;

		// Token: 0x040001C7 RID: 455
		private static Delegate cb_sendEvent_Ljava_lang_String_;

		// Token: 0x040001C8 RID: 456
		private static Delegate cb_sendEvent_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;

		// Token: 0x040001C9 RID: 457
		private static Delegate cb_sendEvent_Ljava_lang_String_Ljava_util_Map_;

		// Token: 0x040001CA RID: 458
		private static Delegate cb_sendMetric_Lcom_unity3d_services_core_request_metrics_Metric_;

		// Token: 0x040001CB RID: 459
		private static Delegate cb_sendMetricWithInitState_Lcom_unity3d_services_core_request_metrics_Metric_;

		// Token: 0x040001CC RID: 460
		private static Delegate cb_sendMetrics_Ljava_util_List_;
	}
}
