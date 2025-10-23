using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Cct.Internal
{
	// Token: 0x0200001A RID: 26
	[Register("com/google/android/datatransport/cct/internal/LogRequest", DoNotGenerateAcw = true)]
	public abstract class LogRequest : Java.Lang.Object
	{
		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000144 RID: 324 RVA: 0x0000492C File Offset: 0x00002B2C
		internal static IntPtr class_ref
		{
			get
			{
				return LogRequest._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000145 RID: 325 RVA: 0x00004950 File Offset: 0x00002B50
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LogRequest._members;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000146 RID: 326 RVA: 0x00004958 File Offset: 0x00002B58
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LogRequest._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000147 RID: 327 RVA: 0x0000497C File Offset: 0x00002B7C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LogRequest._members.ManagedPeerType;
			}
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000020B4 File Offset: 0x000002B4
		protected LogRequest(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00004988 File Offset: 0x00002B88
		[Register(".ctor", "()V", "")]
		public LogRequest() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(LogRequest._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			LogRequest._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x000049F6 File Offset: 0x00002BF6
		private static Delegate GetGetClientInfoHandler()
		{
			if (LogRequest.cb_getClientInfo == null)
			{
				LogRequest.cb_getClientInfo = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(LogRequest.n_GetClientInfo));
			}
			return LogRequest.cb_getClientInfo;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00004A1A File Offset: 0x00002C1A
		private static IntPtr n_GetClientInfo(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<LogRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClientInfo);
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600014C RID: 332
		public abstract ClientInfo ClientInfo { [Register("getClientInfo", "()Lcom/google/android/datatransport/cct/internal/ClientInfo;", "GetGetClientInfoHandler")] get; }

		// Token: 0x0600014D RID: 333 RVA: 0x00004A2E File Offset: 0x00002C2E
		private static Delegate GetGetLogEventsHandler()
		{
			if (LogRequest.cb_getLogEvents == null)
			{
				LogRequest.cb_getLogEvents = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(LogRequest.n_GetLogEvents));
			}
			return LogRequest.cb_getLogEvents;
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00004A52 File Offset: 0x00002C52
		private static IntPtr n_GetLogEvents(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<LogEvent>.ToLocalJniHandle(Java.Lang.Object.GetObject<LogRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LogEvents);
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600014F RID: 335
		public abstract IList<LogEvent> LogEvents { [Register("getLogEvents", "()Ljava/util/List;", "GetGetLogEventsHandler")] get; }

		// Token: 0x06000150 RID: 336 RVA: 0x00004A66 File Offset: 0x00002C66
		private static Delegate GetGetLogSourceHandler()
		{
			if (LogRequest.cb_getLogSource == null)
			{
				LogRequest.cb_getLogSource = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(LogRequest.n_GetLogSource));
			}
			return LogRequest.cb_getLogSource;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00004A8A File Offset: 0x00002C8A
		private static IntPtr n_GetLogSource(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<LogRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LogSource);
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000152 RID: 338
		public abstract Integer LogSource { [Register("getLogSource", "()Ljava/lang/Integer;", "GetGetLogSourceHandler")] get; }

		// Token: 0x06000153 RID: 339 RVA: 0x00004A9E File Offset: 0x00002C9E
		private static Delegate GetGetLogSourceNameHandler()
		{
			if (LogRequest.cb_getLogSourceName == null)
			{
				LogRequest.cb_getLogSourceName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(LogRequest.n_GetLogSourceName));
			}
			return LogRequest.cb_getLogSourceName;
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00004AC2 File Offset: 0x00002CC2
		private static IntPtr n_GetLogSourceName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<LogRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LogSourceName);
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000155 RID: 341
		public abstract string LogSourceName { [Register("getLogSourceName", "()Ljava/lang/String;", "GetGetLogSourceNameHandler")] get; }

		// Token: 0x06000156 RID: 342 RVA: 0x00004AD6 File Offset: 0x00002CD6
		private static Delegate GetGetQosTierHandler()
		{
			if (LogRequest.cb_getQosTier == null)
			{
				LogRequest.cb_getQosTier = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(LogRequest.n_GetQosTier));
			}
			return LogRequest.cb_getQosTier;
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00004AFA File Offset: 0x00002CFA
		private static IntPtr n_GetQosTier(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<LogRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).QosTier);
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000158 RID: 344
		public abstract QosTier QosTier { [Register("getQosTier", "()Lcom/google/android/datatransport/cct/internal/QosTier;", "GetGetQosTierHandler")] get; }

		// Token: 0x06000159 RID: 345 RVA: 0x00004B0E File Offset: 0x00002D0E
		private static Delegate GetGetRequestTimeMsHandler()
		{
			if (LogRequest.cb_getRequestTimeMs == null)
			{
				LogRequest.cb_getRequestTimeMs = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(LogRequest.n_GetRequestTimeMs));
			}
			return LogRequest.cb_getRequestTimeMs;
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00004B32 File Offset: 0x00002D32
		private static long n_GetRequestTimeMs(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<LogRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RequestTimeMs;
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600015B RID: 347
		public abstract long RequestTimeMs { [Register("getRequestTimeMs", "()J", "GetGetRequestTimeMsHandler")] get; }

		// Token: 0x0600015C RID: 348 RVA: 0x00004B41 File Offset: 0x00002D41
		private static Delegate GetGetRequestUptimeMsHandler()
		{
			if (LogRequest.cb_getRequestUptimeMs == null)
			{
				LogRequest.cb_getRequestUptimeMs = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(LogRequest.n_GetRequestUptimeMs));
			}
			return LogRequest.cb_getRequestUptimeMs;
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00004B65 File Offset: 0x00002D65
		private static long n_GetRequestUptimeMs(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<LogRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RequestUptimeMs;
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600015E RID: 350
		public abstract long RequestUptimeMs { [Register("getRequestUptimeMs", "()J", "GetGetRequestUptimeMsHandler")] get; }

		// Token: 0x0600015F RID: 351 RVA: 0x00004B74 File Offset: 0x00002D74
		[Register("builder", "()Lcom/google/android/datatransport/cct/internal/LogRequest$Builder;", "")]
		public static LogRequest.Builder InvokeBuilder()
		{
			return Java.Lang.Object.GetObject<LogRequest.Builder>(LogRequest._members.StaticMethods.InvokeObjectMethod("builder.()Lcom/google/android/datatransport/cct/internal/LogRequest$Builder;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000040 RID: 64
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/cct/internal/LogRequest", typeof(LogRequest));

		// Token: 0x04000041 RID: 65
		private static Delegate cb_getClientInfo;

		// Token: 0x04000042 RID: 66
		private static Delegate cb_getLogEvents;

		// Token: 0x04000043 RID: 67
		private static Delegate cb_getLogSource;

		// Token: 0x04000044 RID: 68
		private static Delegate cb_getLogSourceName;

		// Token: 0x04000045 RID: 69
		private static Delegate cb_getQosTier;

		// Token: 0x04000046 RID: 70
		private static Delegate cb_getRequestTimeMs;

		// Token: 0x04000047 RID: 71
		private static Delegate cb_getRequestUptimeMs;

		// Token: 0x0200001B RID: 27
		[Register("com/google/android/datatransport/cct/internal/LogRequest$Builder", DoNotGenerateAcw = true)]
		public abstract class Builder : Java.Lang.Object
		{
			// Token: 0x17000076 RID: 118
			// (get) Token: 0x06000161 RID: 353 RVA: 0x00004BC0 File Offset: 0x00002DC0
			internal static IntPtr class_ref
			{
				get
				{
					return LogRequest.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000077 RID: 119
			// (get) Token: 0x06000162 RID: 354 RVA: 0x00004BE4 File Offset: 0x00002DE4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return LogRequest.Builder._members;
				}
			}

			// Token: 0x17000078 RID: 120
			// (get) Token: 0x06000163 RID: 355 RVA: 0x00004BEC File Offset: 0x00002DEC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return LogRequest.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000079 RID: 121
			// (get) Token: 0x06000164 RID: 356 RVA: 0x00004C10 File Offset: 0x00002E10
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return LogRequest.Builder._members.ManagedPeerType;
				}
			}

			// Token: 0x06000165 RID: 357 RVA: 0x000020B4 File Offset: 0x000002B4
			protected Builder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06000166 RID: 358 RVA: 0x00004C1C File Offset: 0x00002E1C
			[Register(".ctor", "()V", "")]
			public Builder() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(LogRequest.Builder._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				LogRequest.Builder._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x06000167 RID: 359 RVA: 0x00004C8A File Offset: 0x00002E8A
			private static Delegate GetBuildHandler()
			{
				if (LogRequest.Builder.cb_build == null)
				{
					LogRequest.Builder.cb_build = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(LogRequest.Builder.n_Build));
				}
				return LogRequest.Builder.cb_build;
			}

			// Token: 0x06000168 RID: 360 RVA: 0x00004CAE File Offset: 0x00002EAE
			private static IntPtr n_Build(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<LogRequest.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Build());
			}

			// Token: 0x06000169 RID: 361
			[Register("build", "()Lcom/google/android/datatransport/cct/internal/LogRequest;", "GetBuildHandler")]
			public abstract LogRequest Build();

			// Token: 0x0600016A RID: 362 RVA: 0x00004CC2 File Offset: 0x00002EC2
			private static Delegate GetSetClientInfo_Lcom_google_android_datatransport_cct_internal_ClientInfo_Handler()
			{
				if (LogRequest.Builder.cb_setClientInfo_Lcom_google_android_datatransport_cct_internal_ClientInfo_ == null)
				{
					LogRequest.Builder.cb_setClientInfo_Lcom_google_android_datatransport_cct_internal_ClientInfo_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(LogRequest.Builder.n_SetClientInfo_Lcom_google_android_datatransport_cct_internal_ClientInfo_));
				}
				return LogRequest.Builder.cb_setClientInfo_Lcom_google_android_datatransport_cct_internal_ClientInfo_;
			}

			// Token: 0x0600016B RID: 363 RVA: 0x00004CE8 File Offset: 0x00002EE8
			private static IntPtr n_SetClientInfo_Lcom_google_android_datatransport_cct_internal_ClientInfo_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				LogRequest.Builder @object = Java.Lang.Object.GetObject<LogRequest.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ClientInfo object2 = Java.Lang.Object.GetObject<ClientInfo>(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetClientInfo(object2));
			}

			// Token: 0x0600016C RID: 364
			[Register("setClientInfo", "(Lcom/google/android/datatransport/cct/internal/ClientInfo;)Lcom/google/android/datatransport/cct/internal/LogRequest$Builder;", "GetSetClientInfo_Lcom_google_android_datatransport_cct_internal_ClientInfo_Handler")]
			public abstract LogRequest.Builder SetClientInfo(ClientInfo p0);

			// Token: 0x0600016D RID: 365 RVA: 0x00004D10 File Offset: 0x00002F10
			private static Delegate GetSetLogEvents_Ljava_util_List_Handler()
			{
				if (LogRequest.Builder.cb_setLogEvents_Ljava_util_List_ == null)
				{
					LogRequest.Builder.cb_setLogEvents_Ljava_util_List_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(LogRequest.Builder.n_SetLogEvents_Ljava_util_List_));
				}
				return LogRequest.Builder.cb_setLogEvents_Ljava_util_List_;
			}

			// Token: 0x0600016E RID: 366 RVA: 0x00004D34 File Offset: 0x00002F34
			private static IntPtr n_SetLogEvents_Ljava_util_List_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				LogRequest.Builder @object = Java.Lang.Object.GetObject<LogRequest.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				IList<LogEvent> logEvents = JavaList<LogEvent>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetLogEvents(logEvents));
			}

			// Token: 0x0600016F RID: 367
			[Register("setLogEvents", "(Ljava/util/List;)Lcom/google/android/datatransport/cct/internal/LogRequest$Builder;", "GetSetLogEvents_Ljava_util_List_Handler")]
			public abstract LogRequest.Builder SetLogEvents(IList<LogEvent> p0);

			// Token: 0x06000170 RID: 368 RVA: 0x00004D5C File Offset: 0x00002F5C
			private static Delegate GetSetQosTier_Lcom_google_android_datatransport_cct_internal_QosTier_Handler()
			{
				if (LogRequest.Builder.cb_setQosTier_Lcom_google_android_datatransport_cct_internal_QosTier_ == null)
				{
					LogRequest.Builder.cb_setQosTier_Lcom_google_android_datatransport_cct_internal_QosTier_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(LogRequest.Builder.n_SetQosTier_Lcom_google_android_datatransport_cct_internal_QosTier_));
				}
				return LogRequest.Builder.cb_setQosTier_Lcom_google_android_datatransport_cct_internal_QosTier_;
			}

			// Token: 0x06000171 RID: 369 RVA: 0x00004D80 File Offset: 0x00002F80
			private static IntPtr n_SetQosTier_Lcom_google_android_datatransport_cct_internal_QosTier_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				LogRequest.Builder @object = Java.Lang.Object.GetObject<LogRequest.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				QosTier object2 = Java.Lang.Object.GetObject<QosTier>(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetQosTier(object2));
			}

			// Token: 0x06000172 RID: 370
			[Register("setQosTier", "(Lcom/google/android/datatransport/cct/internal/QosTier;)Lcom/google/android/datatransport/cct/internal/LogRequest$Builder;", "GetSetQosTier_Lcom_google_android_datatransport_cct_internal_QosTier_Handler")]
			public abstract LogRequest.Builder SetQosTier(QosTier p0);

			// Token: 0x06000173 RID: 371 RVA: 0x00004DA8 File Offset: 0x00002FA8
			private static Delegate GetSetRequestTimeMs_JHandler()
			{
				if (LogRequest.Builder.cb_setRequestTimeMs_J == null)
				{
					LogRequest.Builder.cb_setRequestTimeMs_J = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJ_L(LogRequest.Builder.n_SetRequestTimeMs_J));
				}
				return LogRequest.Builder.cb_setRequestTimeMs_J;
			}

			// Token: 0x06000174 RID: 372 RVA: 0x00004DCC File Offset: 0x00002FCC
			private static IntPtr n_SetRequestTimeMs_J(IntPtr jnienv, IntPtr native__this, long p0)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<LogRequest.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetRequestTimeMs(p0));
			}

			// Token: 0x06000175 RID: 373
			[Register("setRequestTimeMs", "(J)Lcom/google/android/datatransport/cct/internal/LogRequest$Builder;", "GetSetRequestTimeMs_JHandler")]
			public abstract LogRequest.Builder SetRequestTimeMs(long p0);

			// Token: 0x06000176 RID: 374 RVA: 0x00004DE1 File Offset: 0x00002FE1
			private static Delegate GetSetRequestUptimeMs_JHandler()
			{
				if (LogRequest.Builder.cb_setRequestUptimeMs_J == null)
				{
					LogRequest.Builder.cb_setRequestUptimeMs_J = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJ_L(LogRequest.Builder.n_SetRequestUptimeMs_J));
				}
				return LogRequest.Builder.cb_setRequestUptimeMs_J;
			}

			// Token: 0x06000177 RID: 375 RVA: 0x00004E05 File Offset: 0x00003005
			private static IntPtr n_SetRequestUptimeMs_J(IntPtr jnienv, IntPtr native__this, long p0)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<LogRequest.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetRequestUptimeMs(p0));
			}

			// Token: 0x06000178 RID: 376
			[Register("setRequestUptimeMs", "(J)Lcom/google/android/datatransport/cct/internal/LogRequest$Builder;", "GetSetRequestUptimeMs_JHandler")]
			public abstract LogRequest.Builder SetRequestUptimeMs(long p0);

			// Token: 0x06000179 RID: 377 RVA: 0x00004E1A File Offset: 0x0000301A
			private static Delegate GetSetSource_IHandler()
			{
				if (LogRequest.Builder.cb_setSource_I == null)
				{
					LogRequest.Builder.cb_setSource_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(LogRequest.Builder.n_SetSource_I));
				}
				return LogRequest.Builder.cb_setSource_I;
			}

			// Token: 0x0600017A RID: 378 RVA: 0x00004E3E File Offset: 0x0000303E
			private static IntPtr n_SetSource_I(IntPtr jnienv, IntPtr native__this, int value)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<LogRequest.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetSource(value));
			}

			// Token: 0x0600017B RID: 379 RVA: 0x00004E54 File Offset: 0x00003054
			[Register("setSource", "(I)Lcom/google/android/datatransport/cct/internal/LogRequest$Builder;", "GetSetSource_IHandler")]
			public unsafe virtual LogRequest.Builder SetSource(int value)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				return Java.Lang.Object.GetObject<LogRequest.Builder>(LogRequest.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setSource.(I)Lcom/google/android/datatransport/cct/internal/LogRequest$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0600017C RID: 380 RVA: 0x00004E9D File Offset: 0x0000309D
			private static Delegate GetSetSource_Ljava_lang_String_Handler()
			{
				if (LogRequest.Builder.cb_setSource_Ljava_lang_String_ == null)
				{
					LogRequest.Builder.cb_setSource_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(LogRequest.Builder.n_SetSource_Ljava_lang_String_));
				}
				return LogRequest.Builder.cb_setSource_Ljava_lang_String_;
			}

			// Token: 0x0600017D RID: 381 RVA: 0x00004EC4 File Offset: 0x000030C4
			private static IntPtr n_SetSource_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_value)
			{
				LogRequest.Builder @object = Java.Lang.Object.GetObject<LogRequest.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_value, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetSource(@string));
			}

			// Token: 0x0600017E RID: 382 RVA: 0x00004EEC File Offset: 0x000030EC
			[Register("setSource", "(Ljava/lang/String;)Lcom/google/android/datatransport/cct/internal/LogRequest$Builder;", "GetSetSource_Ljava_lang_String_Handler")]
			public unsafe virtual LogRequest.Builder SetSource(string value)
			{
				IntPtr intPtr = JNIEnv.NewString(value);
				LogRequest.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<LogRequest.Builder>(LogRequest.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setSource.(Ljava/lang/String;)Lcom/google/android/datatransport/cct/internal/LogRequest$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x04000048 RID: 72
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/cct/internal/LogRequest$Builder", typeof(LogRequest.Builder));

			// Token: 0x04000049 RID: 73
			private static Delegate cb_build;

			// Token: 0x0400004A RID: 74
			private static Delegate cb_setClientInfo_Lcom_google_android_datatransport_cct_internal_ClientInfo_;

			// Token: 0x0400004B RID: 75
			private static Delegate cb_setLogEvents_Ljava_util_List_;

			// Token: 0x0400004C RID: 76
			private static Delegate cb_setQosTier_Lcom_google_android_datatransport_cct_internal_QosTier_;

			// Token: 0x0400004D RID: 77
			private static Delegate cb_setRequestTimeMs_J;

			// Token: 0x0400004E RID: 78
			private static Delegate cb_setRequestUptimeMs_J;

			// Token: 0x0400004F RID: 79
			private static Delegate cb_setSource_I;

			// Token: 0x04000050 RID: 80
			private static Delegate cb_setSource_Ljava_lang_String_;
		}

		// Token: 0x0200001C RID: 28
		[Register("com/google/android/datatransport/cct/internal/LogRequest$Builder", DoNotGenerateAcw = true)]
		internal class BuilderInvoker : LogRequest.Builder
		{
			// Token: 0x06000180 RID: 384 RVA: 0x00004F73 File Offset: 0x00003173
			public BuilderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
			{
			}

			// Token: 0x1700007A RID: 122
			// (get) Token: 0x06000181 RID: 385 RVA: 0x00004F7D File Offset: 0x0000317D
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return LogRequest.BuilderInvoker._members;
				}
			}

			// Token: 0x1700007B RID: 123
			// (get) Token: 0x06000182 RID: 386 RVA: 0x00004F84 File Offset: 0x00003184
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return LogRequest.BuilderInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000183 RID: 387 RVA: 0x00004F90 File Offset: 0x00003190
			[Register("build", "()Lcom/google/android/datatransport/cct/internal/LogRequest;", "GetBuildHandler")]
			public override LogRequest Build()
			{
				return Java.Lang.Object.GetObject<LogRequest>(LogRequest.BuilderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("build.()Lcom/google/android/datatransport/cct/internal/LogRequest;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000184 RID: 388 RVA: 0x00004FC4 File Offset: 0x000031C4
			[Register("setClientInfo", "(Lcom/google/android/datatransport/cct/internal/ClientInfo;)Lcom/google/android/datatransport/cct/internal/LogRequest$Builder;", "GetSetClientInfo_Lcom_google_android_datatransport_cct_internal_ClientInfo_Handler")]
			public unsafe override LogRequest.Builder SetClientInfo(ClientInfo p0)
			{
				LogRequest.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
					@object = Java.Lang.Object.GetObject<LogRequest.Builder>(LogRequest.BuilderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("setClientInfo.(Lcom/google/android/datatransport/cct/internal/ClientInfo;)Lcom/google/android/datatransport/cct/internal/LogRequest$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(p0);
				}
				return @object;
			}

			// Token: 0x06000185 RID: 389 RVA: 0x00005038 File Offset: 0x00003238
			[Register("setLogEvents", "(Ljava/util/List;)Lcom/google/android/datatransport/cct/internal/LogRequest$Builder;", "GetSetLogEvents_Ljava_util_List_Handler")]
			public unsafe override LogRequest.Builder SetLogEvents(IList<LogEvent> p0)
			{
				IntPtr intPtr = JavaList<LogEvent>.ToLocalJniHandle(p0);
				LogRequest.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<LogRequest.Builder>(LogRequest.BuilderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("setLogEvents.(Ljava/util/List;)Lcom/google/android/datatransport/cct/internal/LogRequest$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(p0);
				}
				return @object;
			}

			// Token: 0x06000186 RID: 390 RVA: 0x000050AC File Offset: 0x000032AC
			[Register("setQosTier", "(Lcom/google/android/datatransport/cct/internal/QosTier;)Lcom/google/android/datatransport/cct/internal/LogRequest$Builder;", "GetSetQosTier_Lcom_google_android_datatransport_cct_internal_QosTier_Handler")]
			public unsafe override LogRequest.Builder SetQosTier(QosTier p0)
			{
				LogRequest.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
					@object = Java.Lang.Object.GetObject<LogRequest.Builder>(LogRequest.BuilderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("setQosTier.(Lcom/google/android/datatransport/cct/internal/QosTier;)Lcom/google/android/datatransport/cct/internal/LogRequest$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(p0);
				}
				return @object;
			}

			// Token: 0x06000187 RID: 391 RVA: 0x00005120 File Offset: 0x00003320
			[Register("setRequestTimeMs", "(J)Lcom/google/android/datatransport/cct/internal/LogRequest$Builder;", "GetSetRequestTimeMs_JHandler")]
			public unsafe override LogRequest.Builder SetRequestTimeMs(long p0)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(p0);
				return Java.Lang.Object.GetObject<LogRequest.Builder>(LogRequest.BuilderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("setRequestTimeMs.(J)Lcom/google/android/datatransport/cct/internal/LogRequest$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000188 RID: 392 RVA: 0x0000516C File Offset: 0x0000336C
			[Register("setRequestUptimeMs", "(J)Lcom/google/android/datatransport/cct/internal/LogRequest$Builder;", "GetSetRequestUptimeMs_JHandler")]
			public unsafe override LogRequest.Builder SetRequestUptimeMs(long p0)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(p0);
				return Java.Lang.Object.GetObject<LogRequest.Builder>(LogRequest.BuilderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("setRequestUptimeMs.(J)Lcom/google/android/datatransport/cct/internal/LogRequest$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x04000051 RID: 81
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/cct/internal/LogRequest$Builder", typeof(LogRequest.BuilderInvoker));
		}
	}
}
