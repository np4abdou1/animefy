using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Request.Metrics
{
	// Token: 0x020000BE RID: 190
	[Register("com/unity3d/services/core/request/metrics/ISDKMetrics", DoNotGenerateAcw = true)]
	internal class ISDKMetricsInvoker : Java.Lang.Object, ISDKMetrics, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700023B RID: 571
		// (get) Token: 0x060006FA RID: 1786 RVA: 0x000139B0 File Offset: 0x00011BB0
		private static IntPtr java_class_ref
		{
			get
			{
				return ISDKMetricsInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x060006FB RID: 1787 RVA: 0x000139D4 File Offset: 0x00011BD4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISDKMetricsInvoker._members;
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x060006FC RID: 1788 RVA: 0x000139DB File Offset: 0x00011BDB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x060006FD RID: 1789 RVA: 0x000139E3 File Offset: 0x00011BE3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISDKMetricsInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x000139EF File Offset: 0x00011BEF
		public static ISDKMetrics GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ISDKMetrics>(handle, transfer);
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x000139F8 File Offset: 0x00011BF8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISDKMetricsInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.core.request.metrics.ISDKMetrics'.");
			}
			return handle;
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x00013A23 File Offset: 0x00011C23
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x00013A54 File Offset: 0x00011C54
		public ISDKMetricsInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ISDKMetricsInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x00013A8C File Offset: 0x00011C8C
		private static Delegate GetGetMetricEndPointHandler()
		{
			if (ISDKMetricsInvoker.cb_getMetricEndPoint == null)
			{
				ISDKMetricsInvoker.cb_getMetricEndPoint = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISDKMetricsInvoker.n_GetMetricEndPoint));
			}
			return ISDKMetricsInvoker.cb_getMetricEndPoint;
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x00013AB0 File Offset: 0x00011CB0
		private static IntPtr n_GetMetricEndPoint(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<ISDKMetrics>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MetricEndPoint);
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000704 RID: 1796 RVA: 0x00013AC4 File Offset: 0x00011CC4
		public string MetricEndPoint
		{
			get
			{
				if (this.id_getMetricEndPoint == IntPtr.Zero)
				{
					this.id_getMetricEndPoint = JNIEnv.GetMethodID(this.class_ref, "getMetricEndPoint", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getMetricEndPoint), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x00013B15 File Offset: 0x00011D15
		private static Delegate GetAreMetricsEnabledForCurrentSessionHandler()
		{
			if (ISDKMetricsInvoker.cb_areMetricsEnabledForCurrentSession == null)
			{
				ISDKMetricsInvoker.cb_areMetricsEnabledForCurrentSession = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ISDKMetricsInvoker.n_AreMetricsEnabledForCurrentSession));
			}
			return ISDKMetricsInvoker.cb_areMetricsEnabledForCurrentSession;
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x00013B39 File Offset: 0x00011D39
		private static bool n_AreMetricsEnabledForCurrentSession(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ISDKMetrics>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AreMetricsEnabledForCurrentSession();
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x00013B48 File Offset: 0x00011D48
		public bool AreMetricsEnabledForCurrentSession()
		{
			if (this.id_areMetricsEnabledForCurrentSession == IntPtr.Zero)
			{
				this.id_areMetricsEnabledForCurrentSession = JNIEnv.GetMethodID(this.class_ref, "areMetricsEnabledForCurrentSession", "()Z");
			}
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_areMetricsEnabledForCurrentSession);
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x00013B88 File Offset: 0x00011D88
		private static Delegate GetSendEvent_Ljava_lang_String_Handler()
		{
			if (ISDKMetricsInvoker.cb_sendEvent_Ljava_lang_String_ == null)
			{
				ISDKMetricsInvoker.cb_sendEvent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ISDKMetricsInvoker.n_SendEvent_Ljava_lang_String_));
			}
			return ISDKMetricsInvoker.cb_sendEvent_Ljava_lang_String_;
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x00013BAC File Offset: 0x00011DAC
		private static void n_SendEvent_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ISDKMetrics @object = Java.Lang.Object.GetObject<ISDKMetrics>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SendEvent(@string);
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x00013BD0 File Offset: 0x00011DD0
		public unsafe void SendEvent(string p0)
		{
			if (this.id_sendEvent_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_sendEvent_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "sendEvent", "(Ljava/lang/String;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_sendEvent_Ljava_lang_String_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x00013C41 File Offset: 0x00011E41
		private static Delegate GetSendEvent_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Handler()
		{
			if (ISDKMetricsInvoker.cb_sendEvent_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ == null)
			{
				ISDKMetricsInvoker.cb_sendEvent_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(ISDKMetricsInvoker.n_SendEvent_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_));
			}
			return ISDKMetricsInvoker.cb_sendEvent_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x00013C68 File Offset: 0x00011E68
		private static void n_SendEvent_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			ISDKMetrics @object = Java.Lang.Object.GetObject<ISDKMetrics>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
			IDictionary<string, string> p = JavaDictionary<string, string>.FromJniHandle(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.SendEvent(@string, string2, p);
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x00013CA0 File Offset: 0x00011EA0
		public unsafe void SendEvent(string p0, string p1, IDictionary<string, string> p2)
		{
			if (this.id_sendEvent_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
			{
				this.id_sendEvent_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID(this.class_ref, "sendEvent", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JNIEnv.NewString(p1);
			IntPtr intPtr3 = JavaDictionary<string, string>.ToLocalJniHandle(p2);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(intPtr2);
			ptr[2] = new JValue(intPtr3);
			JNIEnv.CallVoidMethod(base.Handle, this.id_sendEvent_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
			JNIEnv.DeleteLocalRef(intPtr3);
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x00013D54 File Offset: 0x00011F54
		private static Delegate GetSendEvent_Ljava_lang_String_Ljava_util_Map_Handler()
		{
			if (ISDKMetricsInvoker.cb_sendEvent_Ljava_lang_String_Ljava_util_Map_ == null)
			{
				ISDKMetricsInvoker.cb_sendEvent_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(ISDKMetricsInvoker.n_SendEvent_Ljava_lang_String_Ljava_util_Map_));
			}
			return ISDKMetricsInvoker.cb_sendEvent_Ljava_lang_String_Ljava_util_Map_;
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x00013D78 File Offset: 0x00011F78
		private static void n_SendEvent_Ljava_lang_String_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			ISDKMetrics @object = Java.Lang.Object.GetObject<ISDKMetrics>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			IDictionary<string, string> p = JavaDictionary<string, string>.FromJniHandle(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.SendEvent(@string, p);
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x00013DA4 File Offset: 0x00011FA4
		public unsafe void SendEvent(string p0, IDictionary<string, string> p1)
		{
			if (this.id_sendEvent_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
			{
				this.id_sendEvent_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID(this.class_ref, "sendEvent", "(Ljava/lang/String;Ljava/util/Map;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JavaDictionary<string, string>.ToLocalJniHandle(p1);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(intPtr2);
			JNIEnv.CallVoidMethod(base.Handle, this.id_sendEvent_Ljava_lang_String_Ljava_util_Map_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00013E35 File Offset: 0x00012035
		private static Delegate GetSendMetric_Lcom_unity3d_services_core_request_metrics_Metric_Handler()
		{
			if (ISDKMetricsInvoker.cb_sendMetric_Lcom_unity3d_services_core_request_metrics_Metric_ == null)
			{
				ISDKMetricsInvoker.cb_sendMetric_Lcom_unity3d_services_core_request_metrics_Metric_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ISDKMetricsInvoker.n_SendMetric_Lcom_unity3d_services_core_request_metrics_Metric_));
			}
			return ISDKMetricsInvoker.cb_sendMetric_Lcom_unity3d_services_core_request_metrics_Metric_;
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x00013E5C File Offset: 0x0001205C
		private static void n_SendMetric_Lcom_unity3d_services_core_request_metrics_Metric_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ISDKMetrics @object = Java.Lang.Object.GetObject<ISDKMetrics>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Metric object2 = Java.Lang.Object.GetObject<Metric>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SendMetric(object2);
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x00013E80 File Offset: 0x00012080
		public unsafe void SendMetric(Metric p0)
		{
			if (this.id_sendMetric_Lcom_unity3d_services_core_request_metrics_Metric_ == IntPtr.Zero)
			{
				this.id_sendMetric_Lcom_unity3d_services_core_request_metrics_Metric_ = JNIEnv.GetMethodID(this.class_ref, "sendMetric", "(Lcom/unity3d/services/core/request/metrics/Metric;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_sendMetric_Lcom_unity3d_services_core_request_metrics_Metric_, ptr);
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x00013EF3 File Offset: 0x000120F3
		private static Delegate GetSendMetricWithInitState_Lcom_unity3d_services_core_request_metrics_Metric_Handler()
		{
			if (ISDKMetricsInvoker.cb_sendMetricWithInitState_Lcom_unity3d_services_core_request_metrics_Metric_ == null)
			{
				ISDKMetricsInvoker.cb_sendMetricWithInitState_Lcom_unity3d_services_core_request_metrics_Metric_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ISDKMetricsInvoker.n_SendMetricWithInitState_Lcom_unity3d_services_core_request_metrics_Metric_));
			}
			return ISDKMetricsInvoker.cb_sendMetricWithInitState_Lcom_unity3d_services_core_request_metrics_Metric_;
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x00013F18 File Offset: 0x00012118
		private static void n_SendMetricWithInitState_Lcom_unity3d_services_core_request_metrics_Metric_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ISDKMetrics @object = Java.Lang.Object.GetObject<ISDKMetrics>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Metric object2 = Java.Lang.Object.GetObject<Metric>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SendMetricWithInitState(object2);
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x00013F3C File Offset: 0x0001213C
		public unsafe void SendMetricWithInitState(Metric p0)
		{
			if (this.id_sendMetricWithInitState_Lcom_unity3d_services_core_request_metrics_Metric_ == IntPtr.Zero)
			{
				this.id_sendMetricWithInitState_Lcom_unity3d_services_core_request_metrics_Metric_ = JNIEnv.GetMethodID(this.class_ref, "sendMetricWithInitState", "(Lcom/unity3d/services/core/request/metrics/Metric;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_sendMetricWithInitState_Lcom_unity3d_services_core_request_metrics_Metric_, ptr);
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x00013FAF File Offset: 0x000121AF
		private static Delegate GetSendMetrics_Ljava_util_List_Handler()
		{
			if (ISDKMetricsInvoker.cb_sendMetrics_Ljava_util_List_ == null)
			{
				ISDKMetricsInvoker.cb_sendMetrics_Ljava_util_List_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ISDKMetricsInvoker.n_SendMetrics_Ljava_util_List_));
			}
			return ISDKMetricsInvoker.cb_sendMetrics_Ljava_util_List_;
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x00013FD4 File Offset: 0x000121D4
		private static void n_SendMetrics_Ljava_util_List_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ISDKMetrics @object = Java.Lang.Object.GetObject<ISDKMetrics>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IList<Metric> p = JavaList<Metric>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SendMetrics(p);
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x00013FF8 File Offset: 0x000121F8
		public unsafe void SendMetrics(IList<Metric> p0)
		{
			if (this.id_sendMetrics_Ljava_util_List_ == IntPtr.Zero)
			{
				this.id_sendMetrics_Ljava_util_List_ = JNIEnv.GetMethodID(this.class_ref, "sendMetrics", "(Ljava/util/List;)V");
			}
			IntPtr intPtr = JavaList<Metric>.ToLocalJniHandle(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_sendMetrics_Ljava_util_List_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x040001A7 RID: 423
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/request/metrics/ISDKMetrics", typeof(ISDKMetricsInvoker));

		// Token: 0x040001A8 RID: 424
		private IntPtr class_ref;

		// Token: 0x040001A9 RID: 425
		private static Delegate cb_getMetricEndPoint;

		// Token: 0x040001AA RID: 426
		private IntPtr id_getMetricEndPoint;

		// Token: 0x040001AB RID: 427
		private static Delegate cb_areMetricsEnabledForCurrentSession;

		// Token: 0x040001AC RID: 428
		private IntPtr id_areMetricsEnabledForCurrentSession;

		// Token: 0x040001AD RID: 429
		private static Delegate cb_sendEvent_Ljava_lang_String_;

		// Token: 0x040001AE RID: 430
		private IntPtr id_sendEvent_Ljava_lang_String_;

		// Token: 0x040001AF RID: 431
		private static Delegate cb_sendEvent_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;

		// Token: 0x040001B0 RID: 432
		private IntPtr id_sendEvent_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;

		// Token: 0x040001B1 RID: 433
		private static Delegate cb_sendEvent_Ljava_lang_String_Ljava_util_Map_;

		// Token: 0x040001B2 RID: 434
		private IntPtr id_sendEvent_Ljava_lang_String_Ljava_util_Map_;

		// Token: 0x040001B3 RID: 435
		private static Delegate cb_sendMetric_Lcom_unity3d_services_core_request_metrics_Metric_;

		// Token: 0x040001B4 RID: 436
		private IntPtr id_sendMetric_Lcom_unity3d_services_core_request_metrics_Metric_;

		// Token: 0x040001B5 RID: 437
		private static Delegate cb_sendMetricWithInitState_Lcom_unity3d_services_core_request_metrics_Metric_;

		// Token: 0x040001B6 RID: 438
		private IntPtr id_sendMetricWithInitState_Lcom_unity3d_services_core_request_metrics_Metric_;

		// Token: 0x040001B7 RID: 439
		private static Delegate cb_sendMetrics_Ljava_util_List_;

		// Token: 0x040001B8 RID: 440
		private IntPtr id_sendMetrics_Ljava_util_List_;
	}
}
