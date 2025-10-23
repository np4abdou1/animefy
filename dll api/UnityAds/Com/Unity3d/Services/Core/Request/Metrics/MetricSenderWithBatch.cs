using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Properties;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Request.Metrics
{
	// Token: 0x020000C3 RID: 195
	[Register("com/unity3d/services/core/request/metrics/MetricSenderWithBatch", DoNotGenerateAcw = true)]
	public class MetricSenderWithBatch : IMetricSenderWithBatch
	{
		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000764 RID: 1892 RVA: 0x00014E08 File Offset: 0x00013008
		internal new static IntPtr class_ref
		{
			get
			{
				return MetricSenderWithBatch._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000765 RID: 1893 RVA: 0x00014E2C File Offset: 0x0001302C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MetricSenderWithBatch._members;
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000766 RID: 1894 RVA: 0x00014E34 File Offset: 0x00013034
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MetricSenderWithBatch._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000767 RID: 1895 RVA: 0x00014E58 File Offset: 0x00013058
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MetricSenderWithBatch._members.ManagedPeerType;
			}
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x00013977 File Offset: 0x00011B77
		protected MetricSenderWithBatch(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x00014E64 File Offset: 0x00013064
		[Register(".ctor", "(Lcom/unity3d/services/core/request/metrics/ISDKMetrics;Lcom/unity3d/services/core/properties/InitializationStatusReader;)V", "")]
		public unsafe MetricSenderWithBatch(ISDKMetrics metrics, InitializationStatusReader initializationStatusReader) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((metrics == null) ? IntPtr.Zero : ((Java.Lang.Object)metrics).Handle);
				ptr[1] = new JniArgumentValue((initializationStatusReader == null) ? IntPtr.Zero : initializationStatusReader.Handle);
				base.SetHandle(MetricSenderWithBatch._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/services/core/request/metrics/ISDKMetrics;Lcom/unity3d/services/core/properties/InitializationStatusReader;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MetricSenderWithBatch._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/services/core/request/metrics/ISDKMetrics;Lcom/unity3d/services/core/properties/InitializationStatusReader;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(metrics);
				GC.KeepAlive(initializationStatusReader);
			}
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x00014F40 File Offset: 0x00013140
		private static Delegate GetGetMetricEndPointHandler()
		{
			if (MetricSenderWithBatch.cb_getMetricEndPoint == null)
			{
				MetricSenderWithBatch.cb_getMetricEndPoint = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MetricSenderWithBatch.n_GetMetricEndPoint));
			}
			return MetricSenderWithBatch.cb_getMetricEndPoint;
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x00014F64 File Offset: 0x00013164
		private static IntPtr n_GetMetricEndPoint(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<MetricSenderWithBatch>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MetricEndPoint);
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x0600076C RID: 1900 RVA: 0x00014F78 File Offset: 0x00013178
		public virtual string MetricEndPoint
		{
			[Register("getMetricEndPoint", "()Ljava/lang/String;", "GetGetMetricEndPointHandler")]
			get
			{
				return JNIEnv.GetString(MetricSenderWithBatch._members.InstanceMethods.InvokeVirtualObjectMethod("getMetricEndPoint.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x00014FAA File Offset: 0x000131AA
		private static Delegate GetAreMetricsEnabledForCurrentSessionHandler()
		{
			if (MetricSenderWithBatch.cb_areMetricsEnabledForCurrentSession == null)
			{
				MetricSenderWithBatch.cb_areMetricsEnabledForCurrentSession = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(MetricSenderWithBatch.n_AreMetricsEnabledForCurrentSession));
			}
			return MetricSenderWithBatch.cb_areMetricsEnabledForCurrentSession;
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x00014FCE File Offset: 0x000131CE
		private static bool n_AreMetricsEnabledForCurrentSession(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<MetricSenderWithBatch>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AreMetricsEnabledForCurrentSession();
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x00014FDD File Offset: 0x000131DD
		[Register("areMetricsEnabledForCurrentSession", "()Z", "GetAreMetricsEnabledForCurrentSessionHandler")]
		public virtual bool AreMetricsEnabledForCurrentSession()
		{
			return MetricSenderWithBatch._members.InstanceMethods.InvokeVirtualBooleanMethod("areMetricsEnabledForCurrentSession.()Z", this, null);
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x00014FF6 File Offset: 0x000131F6
		private static Delegate GetSendEvent_Ljava_lang_String_Handler()
		{
			if (MetricSenderWithBatch.cb_sendEvent_Ljava_lang_String_ == null)
			{
				MetricSenderWithBatch.cb_sendEvent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MetricSenderWithBatch.n_SendEvent_Ljava_lang_String_));
			}
			return MetricSenderWithBatch.cb_sendEvent_Ljava_lang_String_;
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x0001501C File Offset: 0x0001321C
		private static void n_SendEvent_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			MetricSenderWithBatch @object = Java.Lang.Object.GetObject<MetricSenderWithBatch>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_e, JniHandleOwnership.DoNotTransfer);
			@object.SendEvent(@string);
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x00015040 File Offset: 0x00013240
		[Register("sendEvent", "(Ljava/lang/String;)V", "GetSendEvent_Ljava_lang_String_Handler")]
		public unsafe virtual void SendEvent(string e)
		{
			IntPtr intPtr = JNIEnv.NewString(e);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				MetricSenderWithBatch._members.InstanceMethods.InvokeVirtualVoidMethod("sendEvent.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x0001509C File Offset: 0x0001329C
		private static Delegate GetSendEvent_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Handler()
		{
			if (MetricSenderWithBatch.cb_sendEvent_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ == null)
			{
				MetricSenderWithBatch.cb_sendEvent_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(MetricSenderWithBatch.n_SendEvent_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_));
			}
			return MetricSenderWithBatch.cb_sendEvent_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x000150C0 File Offset: 0x000132C0
		private static void n_SendEvent_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_e, IntPtr native_value, IntPtr native_tags)
		{
			MetricSenderWithBatch @object = Java.Lang.Object.GetObject<MetricSenderWithBatch>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_e, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_value, JniHandleOwnership.DoNotTransfer);
			IDictionary<string, string> tags = JavaDictionary<string, string>.FromJniHandle(native_tags, JniHandleOwnership.DoNotTransfer);
			@object.SendEvent(@string, string2, tags);
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x000150F8 File Offset: 0x000132F8
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
				MetricSenderWithBatch._members.InstanceMethods.InvokeVirtualVoidMethod("sendEvent.(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				GC.KeepAlive(tags);
			}
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x0001519C File Offset: 0x0001339C
		private static Delegate GetSendEvent_Ljava_lang_String_Ljava_util_Map_Handler()
		{
			if (MetricSenderWithBatch.cb_sendEvent_Ljava_lang_String_Ljava_util_Map_ == null)
			{
				MetricSenderWithBatch.cb_sendEvent_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(MetricSenderWithBatch.n_SendEvent_Ljava_lang_String_Ljava_util_Map_));
			}
			return MetricSenderWithBatch.cb_sendEvent_Ljava_lang_String_Ljava_util_Map_;
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x000151C0 File Offset: 0x000133C0
		private static void n_SendEvent_Ljava_lang_String_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_e, IntPtr native_tags)
		{
			MetricSenderWithBatch @object = Java.Lang.Object.GetObject<MetricSenderWithBatch>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_e, JniHandleOwnership.DoNotTransfer);
			IDictionary<string, string> tags = JavaDictionary<string, string>.FromJniHandle(native_tags, JniHandleOwnership.DoNotTransfer);
			@object.SendEvent(@string, tags);
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x000151EC File Offset: 0x000133EC
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
				MetricSenderWithBatch._members.InstanceMethods.InvokeVirtualVoidMethod("sendEvent.(Ljava/lang/String;Ljava/util/Map;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(tags);
			}
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x00015270 File Offset: 0x00013470
		private static Delegate GetSendMetric_Lcom_unity3d_services_core_request_metrics_Metric_Handler()
		{
			if (MetricSenderWithBatch.cb_sendMetric_Lcom_unity3d_services_core_request_metrics_Metric_ == null)
			{
				MetricSenderWithBatch.cb_sendMetric_Lcom_unity3d_services_core_request_metrics_Metric_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MetricSenderWithBatch.n_SendMetric_Lcom_unity3d_services_core_request_metrics_Metric_));
			}
			return MetricSenderWithBatch.cb_sendMetric_Lcom_unity3d_services_core_request_metrics_Metric_;
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x00015294 File Offset: 0x00013494
		private static void n_SendMetric_Lcom_unity3d_services_core_request_metrics_Metric_(IntPtr jnienv, IntPtr native__this, IntPtr native_metric)
		{
			MetricSenderWithBatch @object = Java.Lang.Object.GetObject<MetricSenderWithBatch>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Metric object2 = Java.Lang.Object.GetObject<Metric>(native_metric, JniHandleOwnership.DoNotTransfer);
			@object.SendMetric(object2);
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x000152B8 File Offset: 0x000134B8
		[Register("sendMetric", "(Lcom/unity3d/services/core/request/metrics/Metric;)V", "GetSendMetric_Lcom_unity3d_services_core_request_metrics_Metric_Handler")]
		public unsafe virtual void SendMetric(Metric metric)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((metric == null) ? IntPtr.Zero : metric.Handle);
				MetricSenderWithBatch._members.InstanceMethods.InvokeVirtualVoidMethod("sendMetric.(Lcom/unity3d/services/core/request/metrics/Metric;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(metric);
			}
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x0001531C File Offset: 0x0001351C
		private static Delegate GetSendMetrics_Ljava_util_List_Handler()
		{
			if (MetricSenderWithBatch.cb_sendMetrics_Ljava_util_List_ == null)
			{
				MetricSenderWithBatch.cb_sendMetrics_Ljava_util_List_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MetricSenderWithBatch.n_SendMetrics_Ljava_util_List_));
			}
			return MetricSenderWithBatch.cb_sendMetrics_Ljava_util_List_;
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x00015340 File Offset: 0x00013540
		private static void n_SendMetrics_Ljava_util_List_(IntPtr jnienv, IntPtr native__this, IntPtr native_metrics)
		{
			MetricSenderWithBatch @object = Java.Lang.Object.GetObject<MetricSenderWithBatch>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IList<Metric> metrics = JavaList<Metric>.FromJniHandle(native_metrics, JniHandleOwnership.DoNotTransfer);
			@object.SendMetrics(metrics);
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x00015364 File Offset: 0x00013564
		[Register("sendMetrics", "(Ljava/util/List;)V", "GetSendMetrics_Ljava_util_List_Handler")]
		public unsafe virtual void SendMetrics(IList<Metric> metrics)
		{
			IntPtr intPtr = JavaList<Metric>.ToLocalJniHandle(metrics);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				MetricSenderWithBatch._members.InstanceMethods.InvokeVirtualVoidMethod("sendMetrics.(Ljava/util/List;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(metrics);
			}
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x000153C8 File Offset: 0x000135C8
		private static Delegate GetSendQueueIfNeededHandler()
		{
			if (MetricSenderWithBatch.cb_sendQueueIfNeeded == null)
			{
				MetricSenderWithBatch.cb_sendQueueIfNeeded = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(MetricSenderWithBatch.n_SendQueueIfNeeded));
			}
			return MetricSenderWithBatch.cb_sendQueueIfNeeded;
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x000153EC File Offset: 0x000135EC
		private static void n_SendQueueIfNeeded(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<MetricSenderWithBatch>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SendQueueIfNeeded();
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x000153FB File Offset: 0x000135FB
		[Register("sendQueueIfNeeded", "()V", "GetSendQueueIfNeededHandler")]
		public virtual void SendQueueIfNeeded()
		{
			MetricSenderWithBatch._members.InstanceMethods.InvokeVirtualVoidMethod("sendQueueIfNeeded.()V", this, null);
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x00015414 File Offset: 0x00013614
		private static Delegate GetUpdateOriginal_Lcom_unity3d_services_core_request_metrics_ISDKMetrics_Handler()
		{
			if (MetricSenderWithBatch.cb_updateOriginal_Lcom_unity3d_services_core_request_metrics_ISDKMetrics_ == null)
			{
				MetricSenderWithBatch.cb_updateOriginal_Lcom_unity3d_services_core_request_metrics_ISDKMetrics_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MetricSenderWithBatch.n_UpdateOriginal_Lcom_unity3d_services_core_request_metrics_ISDKMetrics_));
			}
			return MetricSenderWithBatch.cb_updateOriginal_Lcom_unity3d_services_core_request_metrics_ISDKMetrics_;
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x00015438 File Offset: 0x00013638
		private static void n_UpdateOriginal_Lcom_unity3d_services_core_request_metrics_ISDKMetrics_(IntPtr jnienv, IntPtr native__this, IntPtr native_metrics)
		{
			MetricSenderWithBatch @object = Java.Lang.Object.GetObject<MetricSenderWithBatch>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ISDKMetrics object2 = Java.Lang.Object.GetObject<ISDKMetrics>(native_metrics, JniHandleOwnership.DoNotTransfer);
			@object.UpdateOriginal(object2);
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x0001545C File Offset: 0x0001365C
		[Register("updateOriginal", "(Lcom/unity3d/services/core/request/metrics/ISDKMetrics;)V", "GetUpdateOriginal_Lcom_unity3d_services_core_request_metrics_ISDKMetrics_Handler")]
		public unsafe virtual void UpdateOriginal(ISDKMetrics metrics)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((metrics == null) ? IntPtr.Zero : ((Java.Lang.Object)metrics).Handle);
				MetricSenderWithBatch._members.InstanceMethods.InvokeVirtualVoidMethod("updateOriginal.(Lcom/unity3d/services/core/request/metrics/ISDKMetrics;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(metrics);
			}
		}

		// Token: 0x040001CD RID: 461
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/request/metrics/MetricSenderWithBatch", typeof(MetricSenderWithBatch));

		// Token: 0x040001CE RID: 462
		private static Delegate cb_getMetricEndPoint;

		// Token: 0x040001CF RID: 463
		private static Delegate cb_areMetricsEnabledForCurrentSession;

		// Token: 0x040001D0 RID: 464
		private static Delegate cb_sendEvent_Ljava_lang_String_;

		// Token: 0x040001D1 RID: 465
		private static Delegate cb_sendEvent_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;

		// Token: 0x040001D2 RID: 466
		private static Delegate cb_sendEvent_Ljava_lang_String_Ljava_util_Map_;

		// Token: 0x040001D3 RID: 467
		private static Delegate cb_sendMetric_Lcom_unity3d_services_core_request_metrics_Metric_;

		// Token: 0x040001D4 RID: 468
		private static Delegate cb_sendMetrics_Ljava_util_List_;

		// Token: 0x040001D5 RID: 469
		private static Delegate cb_sendQueueIfNeeded;

		// Token: 0x040001D6 RID: 470
		private static Delegate cb_updateOriginal_Lcom_unity3d_services_core_request_metrics_ISDKMetrics_;
	}
}
