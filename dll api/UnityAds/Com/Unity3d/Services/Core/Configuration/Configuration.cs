using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Org.Json;

namespace Com.Unity3d.Services.Core.Configuration
{
	// Token: 0x0200014E RID: 334
	[Register("com/unity3d/services/core/configuration/Configuration", DoNotGenerateAcw = true)]
	public class Configuration : Java.Lang.Object
	{
		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06000D5A RID: 3418 RVA: 0x00025614 File Offset: 0x00023814
		internal static IntPtr class_ref
		{
			get
			{
				return Configuration._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06000D5B RID: 3419 RVA: 0x00025638 File Offset: 0x00023838
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Configuration._members;
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06000D5C RID: 3420 RVA: 0x00025640 File Offset: 0x00023840
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Configuration._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06000D5D RID: 3421 RVA: 0x00025664 File Offset: 0x00023864
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Configuration._members.ManagedPeerType;
			}
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x000021E8 File Offset: 0x000003E8
		protected Configuration(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x00025670 File Offset: 0x00023870
		[Register(".ctor", "()V", "")]
		public Configuration() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(Configuration._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			Configuration._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x000256E0 File Offset: 0x000238E0
		[Register(".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe Configuration(string configUrl) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(configUrl);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				base.SetHandle(Configuration._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				Configuration._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x00025784 File Offset: 0x00023984
		[Register(".ctor", "(Ljava/lang/String;Lcom/unity3d/services/core/configuration/ExperimentsReader;)V", "")]
		public unsafe Configuration(string configUrl, ExperimentsReader experimentsReader) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(configUrl);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((experimentsReader == null) ? IntPtr.Zero : experimentsReader.Handle);
				base.SetHandle(Configuration._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Lcom/unity3d/services/core/configuration/ExperimentsReader;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				Configuration._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Lcom/unity3d/services/core/configuration/ExperimentsReader;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(experimentsReader);
			}
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x00025850 File Offset: 0x00023A50
		[Register(".ctor", "(Ljava/lang/String;Lcom/unity3d/services/core/configuration/IExperiments;)V", "")]
		public unsafe Configuration(string configUrl, IExperiments experiments) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(configUrl);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((experiments == null) ? IntPtr.Zero : ((Java.Lang.Object)experiments).Handle);
				base.SetHandle(Configuration._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Lcom/unity3d/services/core/configuration/IExperiments;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				Configuration._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Lcom/unity3d/services/core/configuration/IExperiments;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(experiments);
			}
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x00025924 File Offset: 0x00023B24
		[Register(".ctor", "(Lorg/json/JSONObject;)V", "")]
		public unsafe Configuration(JSONObject configData) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((configData == null) ? IntPtr.Zero : configData.Handle);
				base.SetHandle(Configuration._members.InstanceMethods.StartCreateInstance("(Lorg/json/JSONObject;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				Configuration._members.InstanceMethods.FinishCreateInstance("(Lorg/json/JSONObject;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(configData);
			}
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x000259D4 File Offset: 0x00023BD4
		private static Delegate GetGetConfigUrlHandler()
		{
			if (Configuration.cb_getConfigUrl == null)
			{
				Configuration.cb_getConfigUrl = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Configuration.n_GetConfigUrl));
			}
			return Configuration.cb_getConfigUrl;
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x000259F8 File Offset: 0x00023BF8
		private static IntPtr n_GetConfigUrl(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<Configuration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ConfigUrl);
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06000D66 RID: 3430 RVA: 0x00025A0C File Offset: 0x00023C0C
		public virtual string ConfigUrl
		{
			[Register("getConfigUrl", "()Ljava/lang/String;", "GetGetConfigUrlHandler")]
			get
			{
				return JNIEnv.GetString(Configuration._members.InstanceMethods.InvokeVirtualObjectMethod("getConfigUrl.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x00025A3E File Offset: 0x00023C3E
		private static Delegate GetGetConnectedEventThresholdHandler()
		{
			if (Configuration.cb_getConnectedEventThreshold == null)
			{
				Configuration.cb_getConnectedEventThreshold = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(Configuration.n_GetConnectedEventThreshold));
			}
			return Configuration.cb_getConnectedEventThreshold;
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x00025A62 File Offset: 0x00023C62
		private static int n_GetConnectedEventThreshold(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Configuration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ConnectedEventThreshold;
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06000D69 RID: 3433 RVA: 0x00025A71 File Offset: 0x00023C71
		public virtual int ConnectedEventThreshold
		{
			[Register("getConnectedEventThreshold", "()I", "GetGetConnectedEventThresholdHandler")]
			get
			{
				return Configuration._members.InstanceMethods.InvokeVirtualInt32Method("getConnectedEventThreshold.()I", this, null);
			}
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x00025A8A File Offset: 0x00023C8A
		private static Delegate GetGetDelayWebViewUpdateHandler()
		{
			if (Configuration.cb_getDelayWebViewUpdate == null)
			{
				Configuration.cb_getDelayWebViewUpdate = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(Configuration.n_GetDelayWebViewUpdate));
			}
			return Configuration.cb_getDelayWebViewUpdate;
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x00025AAE File Offset: 0x00023CAE
		private static bool n_GetDelayWebViewUpdate(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Configuration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DelayWebViewUpdate;
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06000D6C RID: 3436 RVA: 0x00025ABD File Offset: 0x00023CBD
		public virtual bool DelayWebViewUpdate
		{
			[Register("getDelayWebViewUpdate", "()Z", "GetGetDelayWebViewUpdateHandler")]
			get
			{
				return Configuration._members.InstanceMethods.InvokeVirtualBooleanMethod("getDelayWebViewUpdate.()Z", this, null);
			}
		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x00025AD6 File Offset: 0x00023CD6
		private static Delegate GetGetExperimentsHandler()
		{
			if (Configuration.cb_getExperiments == null)
			{
				Configuration.cb_getExperiments = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Configuration.n_GetExperiments));
			}
			return Configuration.cb_getExperiments;
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x00025AFA File Offset: 0x00023CFA
		private static IntPtr n_GetExperiments(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Configuration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Experiments);
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06000D6F RID: 3439 RVA: 0x00025B10 File Offset: 0x00023D10
		public virtual IExperiments Experiments
		{
			[Register("getExperiments", "()Lcom/unity3d/services/core/configuration/IExperiments;", "GetGetExperimentsHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IExperiments>(Configuration._members.InstanceMethods.InvokeVirtualObjectMethod("getExperiments.()Lcom/unity3d/services/core/configuration/IExperiments;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x00025B42 File Offset: 0x00023D42
		private static Delegate GetGetExperimentsReaderHandler()
		{
			if (Configuration.cb_getExperimentsReader == null)
			{
				Configuration.cb_getExperimentsReader = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Configuration.n_GetExperimentsReader));
			}
			return Configuration.cb_getExperimentsReader;
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x00025B66 File Offset: 0x00023D66
		private static IntPtr n_GetExperimentsReader(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Configuration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ExperimentsReader);
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06000D72 RID: 3442 RVA: 0x00025B7C File Offset: 0x00023D7C
		public virtual ExperimentsReader ExperimentsReader
		{
			[Register("getExperimentsReader", "()Lcom/unity3d/services/core/configuration/ExperimentsReader;", "GetGetExperimentsReaderHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ExperimentsReader>(Configuration._members.InstanceMethods.InvokeVirtualObjectMethod("getExperimentsReader.()Lcom/unity3d/services/core/configuration/ExperimentsReader;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x00025BAE File Offset: 0x00023DAE
		private static Delegate GetGetFilteredJsonStringHandler()
		{
			if (Configuration.cb_getFilteredJsonString == null)
			{
				Configuration.cb_getFilteredJsonString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Configuration.n_GetFilteredJsonString));
			}
			return Configuration.cb_getFilteredJsonString;
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x00025BD2 File Offset: 0x00023DD2
		private static IntPtr n_GetFilteredJsonString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<Configuration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FilteredJsonString);
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06000D75 RID: 3445 RVA: 0x00025BE8 File Offset: 0x00023DE8
		public virtual string FilteredJsonString
		{
			[Register("getFilteredJsonString", "()Ljava/lang/String;", "GetGetFilteredJsonStringHandler")]
			get
			{
				return JNIEnv.GetString(Configuration._members.InstanceMethods.InvokeVirtualObjectMethod("getFilteredJsonString.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x00025C1A File Offset: 0x00023E1A
		private static Delegate GetGetLoadTimeoutHandler()
		{
			if (Configuration.cb_getLoadTimeout == null)
			{
				Configuration.cb_getLoadTimeout = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(Configuration.n_GetLoadTimeout));
			}
			return Configuration.cb_getLoadTimeout;
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x00025C3E File Offset: 0x00023E3E
		private static int n_GetLoadTimeout(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Configuration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LoadTimeout;
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06000D78 RID: 3448 RVA: 0x00025C4D File Offset: 0x00023E4D
		public virtual int LoadTimeout
		{
			[Register("getLoadTimeout", "()I", "GetGetLoadTimeoutHandler")]
			get
			{
				return Configuration._members.InstanceMethods.InvokeVirtualInt32Method("getLoadTimeout.()I", this, null);
			}
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x00025C66 File Offset: 0x00023E66
		private static Delegate GetGetMaxRetriesHandler()
		{
			if (Configuration.cb_getMaxRetries == null)
			{
				Configuration.cb_getMaxRetries = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(Configuration.n_GetMaxRetries));
			}
			return Configuration.cb_getMaxRetries;
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x00025C8A File Offset: 0x00023E8A
		private static int n_GetMaxRetries(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Configuration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MaxRetries;
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06000D7B RID: 3451 RVA: 0x00025C99 File Offset: 0x00023E99
		public virtual int MaxRetries
		{
			[Register("getMaxRetries", "()I", "GetGetMaxRetriesHandler")]
			get
			{
				return Configuration._members.InstanceMethods.InvokeVirtualInt32Method("getMaxRetries.()I", this, null);
			}
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x00025CB2 File Offset: 0x00023EB2
		private static Delegate GetGetMaximumConnectedEventsHandler()
		{
			if (Configuration.cb_getMaximumConnectedEvents == null)
			{
				Configuration.cb_getMaximumConnectedEvents = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(Configuration.n_GetMaximumConnectedEvents));
			}
			return Configuration.cb_getMaximumConnectedEvents;
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x00025CD6 File Offset: 0x00023ED6
		private static int n_GetMaximumConnectedEvents(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Configuration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MaximumConnectedEvents;
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06000D7E RID: 3454 RVA: 0x00025CE5 File Offset: 0x00023EE5
		public virtual int MaximumConnectedEvents
		{
			[Register("getMaximumConnectedEvents", "()I", "GetGetMaximumConnectedEventsHandler")]
			get
			{
				return Configuration._members.InstanceMethods.InvokeVirtualInt32Method("getMaximumConnectedEvents.()I", this, null);
			}
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x00025CFE File Offset: 0x00023EFE
		private static Delegate GetGetMetricSampleRateHandler()
		{
			if (Configuration.cb_getMetricSampleRate == null)
			{
				Configuration.cb_getMetricSampleRate = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_D(Configuration.n_GetMetricSampleRate));
			}
			return Configuration.cb_getMetricSampleRate;
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x00025D22 File Offset: 0x00023F22
		private static double n_GetMetricSampleRate(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Configuration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MetricSampleRate;
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06000D81 RID: 3457 RVA: 0x00025D31 File Offset: 0x00023F31
		public virtual double MetricSampleRate
		{
			[Register("getMetricSampleRate", "()D", "GetGetMetricSampleRateHandler")]
			get
			{
				return Configuration._members.InstanceMethods.InvokeVirtualDoubleMethod("getMetricSampleRate.()D", this, null);
			}
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x00025D4A File Offset: 0x00023F4A
		private static Delegate GetGetMetricsUrlHandler()
		{
			if (Configuration.cb_getMetricsUrl == null)
			{
				Configuration.cb_getMetricsUrl = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Configuration.n_GetMetricsUrl));
			}
			return Configuration.cb_getMetricsUrl;
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x00025D6E File Offset: 0x00023F6E
		private static IntPtr n_GetMetricsUrl(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<Configuration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MetricsUrl);
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06000D84 RID: 3460 RVA: 0x00025D84 File Offset: 0x00023F84
		public virtual string MetricsUrl
		{
			[Register("getMetricsUrl", "()Ljava/lang/String;", "GetGetMetricsUrlHandler")]
			get
			{
				return JNIEnv.GetString(Configuration._members.InstanceMethods.InvokeVirtualObjectMethod("getMetricsUrl.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x00025DB6 File Offset: 0x00023FB6
		private static Delegate GetGetNetworkErrorTimeoutHandler()
		{
			if (Configuration.cb_getNetworkErrorTimeout == null)
			{
				Configuration.cb_getNetworkErrorTimeout = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(Configuration.n_GetNetworkErrorTimeout));
			}
			return Configuration.cb_getNetworkErrorTimeout;
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x00025DDA File Offset: 0x00023FDA
		private static long n_GetNetworkErrorTimeout(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Configuration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NetworkErrorTimeout;
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06000D87 RID: 3463 RVA: 0x00025DE9 File Offset: 0x00023FE9
		public virtual long NetworkErrorTimeout
		{
			[Register("getNetworkErrorTimeout", "()J", "GetGetNetworkErrorTimeoutHandler")]
			get
			{
				return Configuration._members.InstanceMethods.InvokeVirtualInt64Method("getNetworkErrorTimeout.()J", this, null);
			}
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x00025E02 File Offset: 0x00024002
		private static Delegate GetGetPrivacyRequestWaitTimeoutHandler()
		{
			if (Configuration.cb_getPrivacyRequestWaitTimeout == null)
			{
				Configuration.cb_getPrivacyRequestWaitTimeout = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(Configuration.n_GetPrivacyRequestWaitTimeout));
			}
			return Configuration.cb_getPrivacyRequestWaitTimeout;
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x00025E26 File Offset: 0x00024026
		private static int n_GetPrivacyRequestWaitTimeout(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Configuration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PrivacyRequestWaitTimeout;
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06000D8A RID: 3466 RVA: 0x00025E35 File Offset: 0x00024035
		public virtual int PrivacyRequestWaitTimeout
		{
			[Register("getPrivacyRequestWaitTimeout", "()I", "GetGetPrivacyRequestWaitTimeoutHandler")]
			get
			{
				return Configuration._members.InstanceMethods.InvokeVirtualInt32Method("getPrivacyRequestWaitTimeout.()I", this, null);
			}
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x00025E4E File Offset: 0x0002404E
		private static Delegate GetGetRawConfigDataHandler()
		{
			if (Configuration.cb_getRawConfigData == null)
			{
				Configuration.cb_getRawConfigData = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Configuration.n_GetRawConfigData));
			}
			return Configuration.cb_getRawConfigData;
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x00025E72 File Offset: 0x00024072
		private static IntPtr n_GetRawConfigData(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Configuration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RawConfigData);
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06000D8D RID: 3469 RVA: 0x00025E88 File Offset: 0x00024088
		public virtual JSONObject RawConfigData
		{
			[Register("getRawConfigData", "()Lorg/json/JSONObject;", "GetGetRawConfigDataHandler")]
			get
			{
				return Java.Lang.Object.GetObject<JSONObject>(Configuration._members.InstanceMethods.InvokeVirtualObjectMethod("getRawConfigData.()Lorg/json/JSONObject;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x00025EBA File Offset: 0x000240BA
		private static Delegate GetGetResetWebappTimeoutHandler()
		{
			if (Configuration.cb_getResetWebappTimeout == null)
			{
				Configuration.cb_getResetWebappTimeout = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(Configuration.n_GetResetWebappTimeout));
			}
			return Configuration.cb_getResetWebappTimeout;
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x00025EDE File Offset: 0x000240DE
		private static int n_GetResetWebappTimeout(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Configuration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ResetWebappTimeout;
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06000D90 RID: 3472 RVA: 0x00025EED File Offset: 0x000240ED
		public virtual int ResetWebappTimeout
		{
			[Register("getResetWebappTimeout", "()I", "GetGetResetWebappTimeoutHandler")]
			get
			{
				return Configuration._members.InstanceMethods.InvokeVirtualInt32Method("getResetWebappTimeout.()I", this, null);
			}
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x00025F06 File Offset: 0x00024106
		private static Delegate GetGetRetryDelayHandler()
		{
			if (Configuration.cb_getRetryDelay == null)
			{
				Configuration.cb_getRetryDelay = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(Configuration.n_GetRetryDelay));
			}
			return Configuration.cb_getRetryDelay;
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x00025F2A File Offset: 0x0002412A
		private static long n_GetRetryDelay(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Configuration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RetryDelay;
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06000D93 RID: 3475 RVA: 0x00025F39 File Offset: 0x00024139
		public virtual long RetryDelay
		{
			[Register("getRetryDelay", "()J", "GetGetRetryDelayHandler")]
			get
			{
				return Configuration._members.InstanceMethods.InvokeVirtualInt64Method("getRetryDelay.()J", this, null);
			}
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x00025F52 File Offset: 0x00024152
		private static Delegate GetGetRetryScalingFactorHandler()
		{
			if (Configuration.cb_getRetryScalingFactor == null)
			{
				Configuration.cb_getRetryScalingFactor = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_D(Configuration.n_GetRetryScalingFactor));
			}
			return Configuration.cb_getRetryScalingFactor;
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x00025F76 File Offset: 0x00024176
		private static double n_GetRetryScalingFactor(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Configuration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RetryScalingFactor;
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06000D96 RID: 3478 RVA: 0x00025F85 File Offset: 0x00024185
		public virtual double RetryScalingFactor
		{
			[Register("getRetryScalingFactor", "()D", "GetGetRetryScalingFactorHandler")]
			get
			{
				return Configuration._members.InstanceMethods.InvokeVirtualDoubleMethod("getRetryScalingFactor.()D", this, null);
			}
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x00025F9E File Offset: 0x0002419E
		private static Delegate GetGetSdkVersionHandler()
		{
			if (Configuration.cb_getSdkVersion == null)
			{
				Configuration.cb_getSdkVersion = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Configuration.n_GetSdkVersion));
			}
			return Configuration.cb_getSdkVersion;
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x00025FC2 File Offset: 0x000241C2
		private static IntPtr n_GetSdkVersion(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<Configuration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SdkVersion);
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06000D99 RID: 3481 RVA: 0x00025FD8 File Offset: 0x000241D8
		public virtual string SdkVersion
		{
			[Register("getSdkVersion", "()Ljava/lang/String;", "GetGetSdkVersionHandler")]
			get
			{
				return JNIEnv.GetString(Configuration._members.InstanceMethods.InvokeVirtualObjectMethod("getSdkVersion.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x0002600A File Offset: 0x0002420A
		private static Delegate GetGetSessionTokenHandler()
		{
			if (Configuration.cb_getSessionToken == null)
			{
				Configuration.cb_getSessionToken = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Configuration.n_GetSessionToken));
			}
			return Configuration.cb_getSessionToken;
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x0002602E File Offset: 0x0002422E
		private static IntPtr n_GetSessionToken(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<Configuration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SessionToken);
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06000D9C RID: 3484 RVA: 0x00026044 File Offset: 0x00024244
		public virtual string SessionToken
		{
			[Register("getSessionToken", "()Ljava/lang/String;", "GetGetSessionTokenHandler")]
			get
			{
				return JNIEnv.GetString(Configuration._members.InstanceMethods.InvokeVirtualObjectMethod("getSessionToken.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000D9D RID: 3485 RVA: 0x00026076 File Offset: 0x00024276
		private static Delegate GetGetShowTimeoutHandler()
		{
			if (Configuration.cb_getShowTimeout == null)
			{
				Configuration.cb_getShowTimeout = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(Configuration.n_GetShowTimeout));
			}
			return Configuration.cb_getShowTimeout;
		}

		// Token: 0x06000D9E RID: 3486 RVA: 0x0002609A File Offset: 0x0002429A
		private static int n_GetShowTimeout(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Configuration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShowTimeout;
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06000D9F RID: 3487 RVA: 0x000260A9 File Offset: 0x000242A9
		public virtual int ShowTimeout
		{
			[Register("getShowTimeout", "()I", "GetGetShowTimeoutHandler")]
			get
			{
				return Configuration._members.InstanceMethods.InvokeVirtualInt32Method("getShowTimeout.()I", this, null);
			}
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x000260C2 File Offset: 0x000242C2
		private static Delegate GetGetSrcHandler()
		{
			if (Configuration.cb_getSrc == null)
			{
				Configuration.cb_getSrc = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Configuration.n_GetSrc));
			}
			return Configuration.cb_getSrc;
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x000260E6 File Offset: 0x000242E6
		private static IntPtr n_GetSrc(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<Configuration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Src);
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06000DA2 RID: 3490 RVA: 0x000260FC File Offset: 0x000242FC
		public virtual string Src
		{
			[Register("getSrc", "()Ljava/lang/String;", "GetGetSrcHandler")]
			get
			{
				return JNIEnv.GetString(Configuration._members.InstanceMethods.InvokeVirtualObjectMethod("getSrc.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x0002612E File Offset: 0x0002432E
		private static Delegate GetGetStateIdHandler()
		{
			if (Configuration.cb_getStateId == null)
			{
				Configuration.cb_getStateId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Configuration.n_GetStateId));
			}
			return Configuration.cb_getStateId;
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x00026152 File Offset: 0x00024352
		private static IntPtr n_GetStateId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<Configuration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StateId);
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06000DA5 RID: 3493 RVA: 0x00026168 File Offset: 0x00024368
		public virtual string StateId
		{
			[Register("getStateId", "()Ljava/lang/String;", "GetGetStateIdHandler")]
			get
			{
				return JNIEnv.GetString(Configuration._members.InstanceMethods.InvokeVirtualObjectMethod("getStateId.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x0002619A File Offset: 0x0002439A
		private static Delegate GetGetTokenTimeoutHandler()
		{
			if (Configuration.cb_getTokenTimeout == null)
			{
				Configuration.cb_getTokenTimeout = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(Configuration.n_GetTokenTimeout));
			}
			return Configuration.cb_getTokenTimeout;
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x000261BE File Offset: 0x000243BE
		private static int n_GetTokenTimeout(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Configuration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TokenTimeout;
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06000DA8 RID: 3496 RVA: 0x000261CD File Offset: 0x000243CD
		public virtual int TokenTimeout
		{
			[Register("getTokenTimeout", "()I", "GetGetTokenTimeoutHandler")]
			get
			{
				return Configuration._members.InstanceMethods.InvokeVirtualInt32Method("getTokenTimeout.()I", this, null);
			}
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x000261E6 File Offset: 0x000243E6
		private static Delegate GetGetUnifiedAuctionTokenHandler()
		{
			if (Configuration.cb_getUnifiedAuctionToken == null)
			{
				Configuration.cb_getUnifiedAuctionToken = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Configuration.n_GetUnifiedAuctionToken));
			}
			return Configuration.cb_getUnifiedAuctionToken;
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x0002620A File Offset: 0x0002440A
		private static IntPtr n_GetUnifiedAuctionToken(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<Configuration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).UnifiedAuctionToken);
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06000DAB RID: 3499 RVA: 0x00026220 File Offset: 0x00024420
		public virtual string UnifiedAuctionToken
		{
			[Register("getUnifiedAuctionToken", "()Ljava/lang/String;", "GetGetUnifiedAuctionTokenHandler")]
			get
			{
				return JNIEnv.GetString(Configuration._members.InstanceMethods.InvokeVirtualObjectMethod("getUnifiedAuctionToken.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x00026252 File Offset: 0x00024452
		private static Delegate GetGetWebViewAppCreateTimeoutHandler()
		{
			if (Configuration.cb_getWebViewAppCreateTimeout == null)
			{
				Configuration.cb_getWebViewAppCreateTimeout = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(Configuration.n_GetWebViewAppCreateTimeout));
			}
			return Configuration.cb_getWebViewAppCreateTimeout;
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x00026276 File Offset: 0x00024476
		private static long n_GetWebViewAppCreateTimeout(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Configuration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).WebViewAppCreateTimeout;
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06000DAE RID: 3502 RVA: 0x00026285 File Offset: 0x00024485
		public virtual long WebViewAppCreateTimeout
		{
			[Register("getWebViewAppCreateTimeout", "()J", "GetGetWebViewAppCreateTimeoutHandler")]
			get
			{
				return Configuration._members.InstanceMethods.InvokeVirtualInt64Method("getWebViewAppCreateTimeout.()J", this, null);
			}
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x0002629E File Offset: 0x0002449E
		private static Delegate GetGetWebViewBridgeTimeoutHandler()
		{
			if (Configuration.cb_getWebViewBridgeTimeout == null)
			{
				Configuration.cb_getWebViewBridgeTimeout = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(Configuration.n_GetWebViewBridgeTimeout));
			}
			return Configuration.cb_getWebViewBridgeTimeout;
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x000262C2 File Offset: 0x000244C2
		private static int n_GetWebViewBridgeTimeout(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Configuration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).WebViewBridgeTimeout;
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06000DB1 RID: 3505 RVA: 0x000262D1 File Offset: 0x000244D1
		public virtual int WebViewBridgeTimeout
		{
			[Register("getWebViewBridgeTimeout", "()I", "GetGetWebViewBridgeTimeoutHandler")]
			get
			{
				return Configuration._members.InstanceMethods.InvokeVirtualInt32Method("getWebViewBridgeTimeout.()I", this, null);
			}
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x000262EA File Offset: 0x000244EA
		private static Delegate GetGetWebViewDataHandler()
		{
			if (Configuration.cb_getWebViewData == null)
			{
				Configuration.cb_getWebViewData = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Configuration.n_GetWebViewData));
			}
			return Configuration.cb_getWebViewData;
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x0002630E File Offset: 0x0002450E
		private static IntPtr n_GetWebViewData(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<Configuration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).WebViewData);
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x00026322 File Offset: 0x00024522
		private static Delegate GetSetWebViewData_Ljava_lang_String_Handler()
		{
			if (Configuration.cb_setWebViewData_Ljava_lang_String_ == null)
			{
				Configuration.cb_setWebViewData_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Configuration.n_SetWebViewData_Ljava_lang_String_));
			}
			return Configuration.cb_setWebViewData_Ljava_lang_String_;
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x00026348 File Offset: 0x00024548
		private static void n_SetWebViewData_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			Configuration @object = Java.Lang.Object.GetObject<Configuration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_data, JniHandleOwnership.DoNotTransfer);
			@object.WebViewData = @string;
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06000DB6 RID: 3510 RVA: 0x0002636C File Offset: 0x0002456C
		// (set) Token: 0x06000DB7 RID: 3511 RVA: 0x000263A0 File Offset: 0x000245A0
		public unsafe virtual string WebViewData
		{
			[Register("getWebViewData", "()Ljava/lang/String;", "GetGetWebViewDataHandler")]
			get
			{
				return JNIEnv.GetString(Configuration._members.InstanceMethods.InvokeVirtualObjectMethod("getWebViewData.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setWebViewData", "(Ljava/lang/String;)V", "GetSetWebViewData_Ljava_lang_String_Handler")]
			set
			{
				IntPtr intPtr = JNIEnv.NewString(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					Configuration._members.InstanceMethods.InvokeVirtualVoidMethod("setWebViewData.(Ljava/lang/String;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x000263FC File Offset: 0x000245FC
		private static Delegate GetGetWebViewHashHandler()
		{
			if (Configuration.cb_getWebViewHash == null)
			{
				Configuration.cb_getWebViewHash = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Configuration.n_GetWebViewHash));
			}
			return Configuration.cb_getWebViewHash;
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x00026420 File Offset: 0x00024620
		private static IntPtr n_GetWebViewHash(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<Configuration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).WebViewHash);
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x00026434 File Offset: 0x00024634
		private static Delegate GetSetWebViewHash_Ljava_lang_String_Handler()
		{
			if (Configuration.cb_setWebViewHash_Ljava_lang_String_ == null)
			{
				Configuration.cb_setWebViewHash_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Configuration.n_SetWebViewHash_Ljava_lang_String_));
			}
			return Configuration.cb_setWebViewHash_Ljava_lang_String_;
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x00026458 File Offset: 0x00024658
		private static void n_SetWebViewHash_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_hash)
		{
			Configuration @object = Java.Lang.Object.GetObject<Configuration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_hash, JniHandleOwnership.DoNotTransfer);
			@object.WebViewHash = @string;
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06000DBC RID: 3516 RVA: 0x0002647C File Offset: 0x0002467C
		// (set) Token: 0x06000DBD RID: 3517 RVA: 0x000264B0 File Offset: 0x000246B0
		public unsafe virtual string WebViewHash
		{
			[Register("getWebViewHash", "()Ljava/lang/String;", "GetGetWebViewHashHandler")]
			get
			{
				return JNIEnv.GetString(Configuration._members.InstanceMethods.InvokeVirtualObjectMethod("getWebViewHash.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setWebViewHash", "(Ljava/lang/String;)V", "GetSetWebViewHash_Ljava_lang_String_Handler")]
			set
			{
				IntPtr intPtr = JNIEnv.NewString(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					Configuration._members.InstanceMethods.InvokeVirtualVoidMethod("setWebViewHash.(Ljava/lang/String;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x0002650C File Offset: 0x0002470C
		private static Delegate GetGetWebViewUrlHandler()
		{
			if (Configuration.cb_getWebViewUrl == null)
			{
				Configuration.cb_getWebViewUrl = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Configuration.n_GetWebViewUrl));
			}
			return Configuration.cb_getWebViewUrl;
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x00026530 File Offset: 0x00024730
		private static IntPtr n_GetWebViewUrl(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<Configuration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).WebViewUrl);
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x00026544 File Offset: 0x00024744
		private static Delegate GetSetWebViewUrl_Ljava_lang_String_Handler()
		{
			if (Configuration.cb_setWebViewUrl_Ljava_lang_String_ == null)
			{
				Configuration.cb_setWebViewUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Configuration.n_SetWebViewUrl_Ljava_lang_String_));
			}
			return Configuration.cb_setWebViewUrl_Ljava_lang_String_;
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x00026568 File Offset: 0x00024768
		private static void n_SetWebViewUrl_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_url)
		{
			Configuration @object = Java.Lang.Object.GetObject<Configuration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_url, JniHandleOwnership.DoNotTransfer);
			@object.WebViewUrl = @string;
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06000DC2 RID: 3522 RVA: 0x0002658C File Offset: 0x0002478C
		// (set) Token: 0x06000DC3 RID: 3523 RVA: 0x000265C0 File Offset: 0x000247C0
		public unsafe virtual string WebViewUrl
		{
			[Register("getWebViewUrl", "()Ljava/lang/String;", "GetGetWebViewUrlHandler")]
			get
			{
				return JNIEnv.GetString(Configuration._members.InstanceMethods.InvokeVirtualObjectMethod("getWebViewUrl.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setWebViewUrl", "(Ljava/lang/String;)V", "GetSetWebViewUrl_Ljava_lang_String_Handler")]
			set
			{
				IntPtr intPtr = JNIEnv.NewString(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					Configuration._members.InstanceMethods.InvokeVirtualVoidMethod("setWebViewUrl.(Ljava/lang/String;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x0002661C File Offset: 0x0002481C
		private static Delegate GetGetWebViewVersionHandler()
		{
			if (Configuration.cb_getWebViewVersion == null)
			{
				Configuration.cb_getWebViewVersion = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Configuration.n_GetWebViewVersion));
			}
			return Configuration.cb_getWebViewVersion;
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x00026640 File Offset: 0x00024840
		private static IntPtr n_GetWebViewVersion(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<Configuration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).WebViewVersion);
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06000DC6 RID: 3526 RVA: 0x00026654 File Offset: 0x00024854
		public virtual string WebViewVersion
		{
			[Register("getWebViewVersion", "()Ljava/lang/String;", "GetGetWebViewVersionHandler")]
			get
			{
				return JNIEnv.GetString(Configuration._members.InstanceMethods.InvokeVirtualObjectMethod("getWebViewVersion.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x00026686 File Offset: 0x00024886
		private static Delegate GetGetModuleConfiguration_Ljava_lang_String_Handler()
		{
			if (Configuration.cb_getModuleConfiguration_Ljava_lang_String_ == null)
			{
				Configuration.cb_getModuleConfiguration_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(Configuration.n_GetModuleConfiguration_Ljava_lang_String_));
			}
			return Configuration.cb_getModuleConfiguration_Ljava_lang_String_;
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x000266AC File Offset: 0x000248AC
		private static IntPtr n_GetModuleConfiguration_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_moduleName)
		{
			Configuration @object = Java.Lang.Object.GetObject<Configuration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_moduleName, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetModuleConfiguration(@string));
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x000266D4 File Offset: 0x000248D4
		[Register("getModuleConfiguration", "(Ljava/lang/String;)Lcom/unity3d/services/core/configuration/IModuleConfiguration;", "GetGetModuleConfiguration_Ljava_lang_String_Handler")]
		public unsafe virtual IModuleConfiguration GetModuleConfiguration(string moduleName)
		{
			IntPtr intPtr = JNIEnv.NewString(moduleName);
			IModuleConfiguration @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IModuleConfiguration>(Configuration._members.InstanceMethods.InvokeVirtualObjectMethod("getModuleConfiguration.(Ljava/lang/String;)Lcom/unity3d/services/core/configuration/IModuleConfiguration;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x00026740 File Offset: 0x00024940
		private static Delegate GetGetModuleConfigurationListHandler()
		{
			if (Configuration.cb_getModuleConfigurationList == null)
			{
				Configuration.cb_getModuleConfigurationList = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Configuration.n_GetModuleConfigurationList));
			}
			return Configuration.cb_getModuleConfigurationList;
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x00026764 File Offset: 0x00024964
		private static IntPtr n_GetModuleConfigurationList(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray(Java.Lang.Object.GetObject<Configuration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetModuleConfigurationList());
		}

		// Token: 0x06000DCC RID: 3532 RVA: 0x00026778 File Offset: 0x00024978
		[Register("getModuleConfigurationList", "()[Ljava/lang/String;", "GetGetModuleConfigurationListHandler")]
		public virtual string[] GetModuleConfigurationList()
		{
			return (string[])JNIEnv.GetArray(Configuration._members.InstanceMethods.InvokeVirtualObjectMethod("getModuleConfigurationList.()[Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(string));
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x000267B9 File Offset: 0x000249B9
		private static Delegate GetGetWebAppApiClassListHandler()
		{
			if (Configuration.cb_getWebAppApiClassList == null)
			{
				Configuration.cb_getWebAppApiClassList = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Configuration.n_GetWebAppApiClassList));
			}
			return Configuration.cb_getWebAppApiClassList;
		}

		// Token: 0x06000DCE RID: 3534 RVA: 0x000267DD File Offset: 0x000249DD
		private static IntPtr n_GetWebAppApiClassList(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray<Class>(Java.Lang.Object.GetObject<Configuration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetWebAppApiClassList());
		}

		// Token: 0x06000DCF RID: 3535 RVA: 0x000267F4 File Offset: 0x000249F4
		[Register("getWebAppApiClassList", "()[Ljava/lang/Class;", "GetGetWebAppApiClassListHandler")]
		public virtual Class[] GetWebAppApiClassList()
		{
			return (Class[])JNIEnv.GetArray(Configuration._members.InstanceMethods.InvokeVirtualObjectMethod("getWebAppApiClassList.()[Ljava/lang/Class;", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(Class));
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x00026835 File Offset: 0x00024A35
		private static Delegate GetHandleConfigurationData_Lorg_json_JSONObject_ZHandler()
		{
			if (Configuration.cb_handleConfigurationData_Lorg_json_JSONObject_Z == null)
			{
				Configuration.cb_handleConfigurationData_Lorg_json_JSONObject_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZ_V(Configuration.n_HandleConfigurationData_Lorg_json_JSONObject_Z));
			}
			return Configuration.cb_handleConfigurationData_Lorg_json_JSONObject_Z;
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x0002685C File Offset: 0x00024A5C
		private static void n_HandleConfigurationData_Lorg_json_JSONObject_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_configData, bool isRemoteConfig)
		{
			Configuration @object = Java.Lang.Object.GetObject<Configuration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			JSONObject object2 = Java.Lang.Object.GetObject<JSONObject>(native_configData, JniHandleOwnership.DoNotTransfer);
			@object.HandleConfigurationData(object2, isRemoteConfig);
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x00026880 File Offset: 0x00024A80
		[Register("handleConfigurationData", "(Lorg/json/JSONObject;Z)V", "GetHandleConfigurationData_Lorg_json_JSONObject_ZHandler")]
		protected unsafe virtual void HandleConfigurationData(JSONObject configData, bool isRemoteConfig)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((configData == null) ? IntPtr.Zero : configData.Handle);
				ptr[1] = new JniArgumentValue(isRemoteConfig);
				Configuration._members.InstanceMethods.InvokeVirtualVoidMethod("handleConfigurationData.(Lorg/json/JSONObject;Z)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(configData);
			}
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x000268F8 File Offset: 0x00024AF8
		private static Delegate GetMakeRequestHandler()
		{
			if (Configuration.cb_makeRequest == null)
			{
				Configuration.cb_makeRequest = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Configuration.n_MakeRequest));
			}
			return Configuration.cb_makeRequest;
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x0002691C File Offset: 0x00024B1C
		private static void n_MakeRequest(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Configuration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MakeRequest();
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x0002692B File Offset: 0x00024B2B
		[Register("makeRequest", "()V", "GetMakeRequestHandler")]
		public virtual void MakeRequest()
		{
			Configuration._members.InstanceMethods.InvokeVirtualVoidMethod("makeRequest.()V", this, null);
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x00026944 File Offset: 0x00024B44
		private static Delegate GetSaveToDiskHandler()
		{
			if (Configuration.cb_saveToDisk == null)
			{
				Configuration.cb_saveToDisk = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Configuration.n_SaveToDisk));
			}
			return Configuration.cb_saveToDisk;
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x00026968 File Offset: 0x00024B68
		private static void n_SaveToDisk(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Configuration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SaveToDisk();
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x00026977 File Offset: 0x00024B77
		[Register("saveToDisk", "()V", "GetSaveToDiskHandler")]
		public virtual void SaveToDisk()
		{
			Configuration._members.InstanceMethods.InvokeVirtualVoidMethod("saveToDisk.()V", this, null);
		}

		// Token: 0x04000313 RID: 787
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/configuration/Configuration", typeof(Configuration));

		// Token: 0x04000314 RID: 788
		private static Delegate cb_getConfigUrl;

		// Token: 0x04000315 RID: 789
		private static Delegate cb_getConnectedEventThreshold;

		// Token: 0x04000316 RID: 790
		private static Delegate cb_getDelayWebViewUpdate;

		// Token: 0x04000317 RID: 791
		private static Delegate cb_getExperiments;

		// Token: 0x04000318 RID: 792
		private static Delegate cb_getExperimentsReader;

		// Token: 0x04000319 RID: 793
		private static Delegate cb_getFilteredJsonString;

		// Token: 0x0400031A RID: 794
		private static Delegate cb_getLoadTimeout;

		// Token: 0x0400031B RID: 795
		private static Delegate cb_getMaxRetries;

		// Token: 0x0400031C RID: 796
		private static Delegate cb_getMaximumConnectedEvents;

		// Token: 0x0400031D RID: 797
		private static Delegate cb_getMetricSampleRate;

		// Token: 0x0400031E RID: 798
		private static Delegate cb_getMetricsUrl;

		// Token: 0x0400031F RID: 799
		private static Delegate cb_getNetworkErrorTimeout;

		// Token: 0x04000320 RID: 800
		private static Delegate cb_getPrivacyRequestWaitTimeout;

		// Token: 0x04000321 RID: 801
		private static Delegate cb_getRawConfigData;

		// Token: 0x04000322 RID: 802
		private static Delegate cb_getResetWebappTimeout;

		// Token: 0x04000323 RID: 803
		private static Delegate cb_getRetryDelay;

		// Token: 0x04000324 RID: 804
		private static Delegate cb_getRetryScalingFactor;

		// Token: 0x04000325 RID: 805
		private static Delegate cb_getSdkVersion;

		// Token: 0x04000326 RID: 806
		private static Delegate cb_getSessionToken;

		// Token: 0x04000327 RID: 807
		private static Delegate cb_getShowTimeout;

		// Token: 0x04000328 RID: 808
		private static Delegate cb_getSrc;

		// Token: 0x04000329 RID: 809
		private static Delegate cb_getStateId;

		// Token: 0x0400032A RID: 810
		private static Delegate cb_getTokenTimeout;

		// Token: 0x0400032B RID: 811
		private static Delegate cb_getUnifiedAuctionToken;

		// Token: 0x0400032C RID: 812
		private static Delegate cb_getWebViewAppCreateTimeout;

		// Token: 0x0400032D RID: 813
		private static Delegate cb_getWebViewBridgeTimeout;

		// Token: 0x0400032E RID: 814
		private static Delegate cb_getWebViewData;

		// Token: 0x0400032F RID: 815
		private static Delegate cb_setWebViewData_Ljava_lang_String_;

		// Token: 0x04000330 RID: 816
		private static Delegate cb_getWebViewHash;

		// Token: 0x04000331 RID: 817
		private static Delegate cb_setWebViewHash_Ljava_lang_String_;

		// Token: 0x04000332 RID: 818
		private static Delegate cb_getWebViewUrl;

		// Token: 0x04000333 RID: 819
		private static Delegate cb_setWebViewUrl_Ljava_lang_String_;

		// Token: 0x04000334 RID: 820
		private static Delegate cb_getWebViewVersion;

		// Token: 0x04000335 RID: 821
		private static Delegate cb_getModuleConfiguration_Ljava_lang_String_;

		// Token: 0x04000336 RID: 822
		private static Delegate cb_getModuleConfigurationList;

		// Token: 0x04000337 RID: 823
		private static Delegate cb_getWebAppApiClassList;

		// Token: 0x04000338 RID: 824
		private static Delegate cb_handleConfigurationData_Lorg_json_JSONObject_Z;

		// Token: 0x04000339 RID: 825
		private static Delegate cb_makeRequest;

		// Token: 0x0400033A RID: 826
		private static Delegate cb_saveToDisk;
	}
}
