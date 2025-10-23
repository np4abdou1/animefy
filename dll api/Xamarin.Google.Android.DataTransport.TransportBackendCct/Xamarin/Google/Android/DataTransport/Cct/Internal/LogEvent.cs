using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Cct.Internal
{
	// Token: 0x02000016 RID: 22
	[Register("com/google/android/datatransport/cct/internal/LogEvent", DoNotGenerateAcw = true)]
	public abstract class LogEvent : Java.Lang.Object
	{
		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x00003FE8 File Offset: 0x000021E8
		internal static IntPtr class_ref
		{
			get
			{
				return LogEvent._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x0000400C File Offset: 0x0000220C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LogEvent._members;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000FA RID: 250 RVA: 0x00004014 File Offset: 0x00002214
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LogEvent._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000FB RID: 251 RVA: 0x00004038 File Offset: 0x00002238
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LogEvent._members.ManagedPeerType;
			}
		}

		// Token: 0x060000FC RID: 252 RVA: 0x000020B4 File Offset: 0x000002B4
		protected LogEvent(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00004044 File Offset: 0x00002244
		[Register(".ctor", "()V", "")]
		public LogEvent() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(LogEvent._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			LogEvent._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x000040B2 File Offset: 0x000022B2
		private static Delegate GetGetEventCodeHandler()
		{
			if (LogEvent.cb_getEventCode == null)
			{
				LogEvent.cb_getEventCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(LogEvent.n_GetEventCode));
			}
			return LogEvent.cb_getEventCode;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x000040D6 File Offset: 0x000022D6
		private static IntPtr n_GetEventCode(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<LogEvent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).EventCode);
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000100 RID: 256
		public abstract Integer EventCode { [Register("getEventCode", "()Ljava/lang/Integer;", "GetGetEventCodeHandler")] get; }

		// Token: 0x06000101 RID: 257 RVA: 0x000040EA File Offset: 0x000022EA
		private static Delegate GetGetEventTimeMsHandler()
		{
			if (LogEvent.cb_getEventTimeMs == null)
			{
				LogEvent.cb_getEventTimeMs = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(LogEvent.n_GetEventTimeMs));
			}
			return LogEvent.cb_getEventTimeMs;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0000410E File Offset: 0x0000230E
		private static long n_GetEventTimeMs(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<LogEvent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).EventTimeMs;
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000103 RID: 259
		public abstract long EventTimeMs { [Register("getEventTimeMs", "()J", "GetGetEventTimeMsHandler")] get; }

		// Token: 0x06000104 RID: 260 RVA: 0x0000411D File Offset: 0x0000231D
		private static Delegate GetGetEventUptimeMsHandler()
		{
			if (LogEvent.cb_getEventUptimeMs == null)
			{
				LogEvent.cb_getEventUptimeMs = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(LogEvent.n_GetEventUptimeMs));
			}
			return LogEvent.cb_getEventUptimeMs;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00004141 File Offset: 0x00002341
		private static long n_GetEventUptimeMs(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<LogEvent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).EventUptimeMs;
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000106 RID: 262
		public abstract long EventUptimeMs { [Register("getEventUptimeMs", "()J", "GetGetEventUptimeMsHandler")] get; }

		// Token: 0x06000107 RID: 263 RVA: 0x00004150 File Offset: 0x00002350
		private static Delegate GetGetNetworkConnectionInfoHandler()
		{
			if (LogEvent.cb_getNetworkConnectionInfo == null)
			{
				LogEvent.cb_getNetworkConnectionInfo = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(LogEvent.n_GetNetworkConnectionInfo));
			}
			return LogEvent.cb_getNetworkConnectionInfo;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00004174 File Offset: 0x00002374
		private static IntPtr n_GetNetworkConnectionInfo(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<LogEvent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NetworkConnectionInfo);
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000109 RID: 265
		public abstract NetworkConnectionInfo NetworkConnectionInfo { [Register("getNetworkConnectionInfo", "()Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo;", "GetGetNetworkConnectionInfoHandler")] get; }

		// Token: 0x0600010A RID: 266 RVA: 0x00004188 File Offset: 0x00002388
		private static Delegate GetGetSourceExtensionJsonProto3Handler()
		{
			if (LogEvent.cb_getSourceExtensionJsonProto3 == null)
			{
				LogEvent.cb_getSourceExtensionJsonProto3 = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(LogEvent.n_GetSourceExtensionJsonProto3));
			}
			return LogEvent.cb_getSourceExtensionJsonProto3;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000041AC File Offset: 0x000023AC
		private static IntPtr n_GetSourceExtensionJsonProto3(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<LogEvent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SourceExtensionJsonProto3);
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600010C RID: 268
		public abstract string SourceExtensionJsonProto3 { [Register("getSourceExtensionJsonProto3", "()Ljava/lang/String;", "GetGetSourceExtensionJsonProto3Handler")] get; }

		// Token: 0x0600010D RID: 269 RVA: 0x000041C0 File Offset: 0x000023C0
		private static Delegate GetGetTimezoneOffsetSecondsHandler()
		{
			if (LogEvent.cb_getTimezoneOffsetSeconds == null)
			{
				LogEvent.cb_getTimezoneOffsetSeconds = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(LogEvent.n_GetTimezoneOffsetSeconds));
			}
			return LogEvent.cb_getTimezoneOffsetSeconds;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x000041E4 File Offset: 0x000023E4
		private static long n_GetTimezoneOffsetSeconds(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<LogEvent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TimezoneOffsetSeconds;
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600010F RID: 271
		public abstract long TimezoneOffsetSeconds { [Register("getTimezoneOffsetSeconds", "()J", "GetGetTimezoneOffsetSecondsHandler")] get; }

		// Token: 0x06000110 RID: 272 RVA: 0x000041F3 File Offset: 0x000023F3
		private static Delegate GetGetSourceExtensionHandler()
		{
			if (LogEvent.cb_getSourceExtension == null)
			{
				LogEvent.cb_getSourceExtension = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(LogEvent.n_GetSourceExtension));
			}
			return LogEvent.cb_getSourceExtension;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00004217 File Offset: 0x00002417
		private static IntPtr n_GetSourceExtension(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray(Java.Lang.Object.GetObject<LogEvent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetSourceExtension());
		}

		// Token: 0x06000112 RID: 274
		[Register("getSourceExtension", "()[B", "GetGetSourceExtensionHandler")]
		public abstract byte[] GetSourceExtension();

		// Token: 0x06000113 RID: 275 RVA: 0x0000422C File Offset: 0x0000242C
		[Register("jsonBuilder", "(Ljava/lang/String;)Lcom/google/android/datatransport/cct/internal/LogEvent$Builder;", "")]
		public unsafe static LogEvent.Builder JsonBuilder(string sourceJsonExtension)
		{
			IntPtr intPtr = JNIEnv.NewString(sourceJsonExtension);
			LogEvent.Builder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<LogEvent.Builder>(LogEvent._members.StaticMethods.InvokeObjectMethod("jsonBuilder.(Ljava/lang/String;)Lcom/google/android/datatransport/cct/internal/LogEvent$Builder;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00004298 File Offset: 0x00002498
		[Register("protoBuilder", "([B)Lcom/google/android/datatransport/cct/internal/LogEvent$Builder;", "")]
		public unsafe static LogEvent.Builder ProtoBuilder(byte[] sourceExtension)
		{
			IntPtr intPtr = JNIEnv.NewArray(sourceExtension);
			LogEvent.Builder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<LogEvent.Builder>(LogEvent._members.StaticMethods.InvokeObjectMethod("protoBuilder.([B)Lcom/google/android/datatransport/cct/internal/LogEvent$Builder;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (sourceExtension != null)
				{
					JNIEnv.CopyArray(intPtr, sourceExtension);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(sourceExtension);
			}
			return @object;
		}

		// Token: 0x0400002F RID: 47
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/cct/internal/LogEvent", typeof(LogEvent));

		// Token: 0x04000030 RID: 48
		private static Delegate cb_getEventCode;

		// Token: 0x04000031 RID: 49
		private static Delegate cb_getEventTimeMs;

		// Token: 0x04000032 RID: 50
		private static Delegate cb_getEventUptimeMs;

		// Token: 0x04000033 RID: 51
		private static Delegate cb_getNetworkConnectionInfo;

		// Token: 0x04000034 RID: 52
		private static Delegate cb_getSourceExtensionJsonProto3;

		// Token: 0x04000035 RID: 53
		private static Delegate cb_getTimezoneOffsetSeconds;

		// Token: 0x04000036 RID: 54
		private static Delegate cb_getSourceExtension;

		// Token: 0x02000017 RID: 23
		[Register("com/google/android/datatransport/cct/internal/LogEvent$Builder", DoNotGenerateAcw = true)]
		public abstract class Builder : Java.Lang.Object
		{
			// Token: 0x1700005D RID: 93
			// (get) Token: 0x06000116 RID: 278 RVA: 0x00004330 File Offset: 0x00002530
			internal static IntPtr class_ref
			{
				get
				{
					return LogEvent.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700005E RID: 94
			// (get) Token: 0x06000117 RID: 279 RVA: 0x00004354 File Offset: 0x00002554
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return LogEvent.Builder._members;
				}
			}

			// Token: 0x1700005F RID: 95
			// (get) Token: 0x06000118 RID: 280 RVA: 0x0000435C File Offset: 0x0000255C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return LogEvent.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000060 RID: 96
			// (get) Token: 0x06000119 RID: 281 RVA: 0x00004380 File Offset: 0x00002580
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return LogEvent.Builder._members.ManagedPeerType;
				}
			}

			// Token: 0x0600011A RID: 282 RVA: 0x000020B4 File Offset: 0x000002B4
			protected Builder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0600011B RID: 283 RVA: 0x0000438C File Offset: 0x0000258C
			[Register(".ctor", "()V", "")]
			public Builder() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(LogEvent.Builder._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				LogEvent.Builder._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x0600011C RID: 284 RVA: 0x000043FA File Offset: 0x000025FA
			private static Delegate GetBuildHandler()
			{
				if (LogEvent.Builder.cb_build == null)
				{
					LogEvent.Builder.cb_build = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(LogEvent.Builder.n_Build));
				}
				return LogEvent.Builder.cb_build;
			}

			// Token: 0x0600011D RID: 285 RVA: 0x0000441E File Offset: 0x0000261E
			private static IntPtr n_Build(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<LogEvent.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Build());
			}

			// Token: 0x0600011E RID: 286
			[Register("build", "()Lcom/google/android/datatransport/cct/internal/LogEvent;", "GetBuildHandler")]
			public abstract LogEvent Build();

			// Token: 0x0600011F RID: 287 RVA: 0x00004432 File Offset: 0x00002632
			private static Delegate GetSetEventCode_Ljava_lang_Integer_Handler()
			{
				if (LogEvent.Builder.cb_setEventCode_Ljava_lang_Integer_ == null)
				{
					LogEvent.Builder.cb_setEventCode_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(LogEvent.Builder.n_SetEventCode_Ljava_lang_Integer_));
				}
				return LogEvent.Builder.cb_setEventCode_Ljava_lang_Integer_;
			}

			// Token: 0x06000120 RID: 288 RVA: 0x00004458 File Offset: 0x00002658
			private static IntPtr n_SetEventCode_Ljava_lang_Integer_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				LogEvent.Builder @object = Java.Lang.Object.GetObject<LogEvent.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Integer object2 = Java.Lang.Object.GetObject<Integer>(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetEventCode(object2));
			}

			// Token: 0x06000121 RID: 289
			[Register("setEventCode", "(Ljava/lang/Integer;)Lcom/google/android/datatransport/cct/internal/LogEvent$Builder;", "GetSetEventCode_Ljava_lang_Integer_Handler")]
			public abstract LogEvent.Builder SetEventCode(Integer p0);

			// Token: 0x06000122 RID: 290 RVA: 0x00004480 File Offset: 0x00002680
			private static Delegate GetSetEventTimeMs_JHandler()
			{
				if (LogEvent.Builder.cb_setEventTimeMs_J == null)
				{
					LogEvent.Builder.cb_setEventTimeMs_J = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJ_L(LogEvent.Builder.n_SetEventTimeMs_J));
				}
				return LogEvent.Builder.cb_setEventTimeMs_J;
			}

			// Token: 0x06000123 RID: 291 RVA: 0x000044A4 File Offset: 0x000026A4
			private static IntPtr n_SetEventTimeMs_J(IntPtr jnienv, IntPtr native__this, long p0)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<LogEvent.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetEventTimeMs(p0));
			}

			// Token: 0x06000124 RID: 292
			[Register("setEventTimeMs", "(J)Lcom/google/android/datatransport/cct/internal/LogEvent$Builder;", "GetSetEventTimeMs_JHandler")]
			public abstract LogEvent.Builder SetEventTimeMs(long p0);

			// Token: 0x06000125 RID: 293 RVA: 0x000044B9 File Offset: 0x000026B9
			private static Delegate GetSetEventUptimeMs_JHandler()
			{
				if (LogEvent.Builder.cb_setEventUptimeMs_J == null)
				{
					LogEvent.Builder.cb_setEventUptimeMs_J = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJ_L(LogEvent.Builder.n_SetEventUptimeMs_J));
				}
				return LogEvent.Builder.cb_setEventUptimeMs_J;
			}

			// Token: 0x06000126 RID: 294 RVA: 0x000044DD File Offset: 0x000026DD
			private static IntPtr n_SetEventUptimeMs_J(IntPtr jnienv, IntPtr native__this, long p0)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<LogEvent.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetEventUptimeMs(p0));
			}

			// Token: 0x06000127 RID: 295
			[Register("setEventUptimeMs", "(J)Lcom/google/android/datatransport/cct/internal/LogEvent$Builder;", "GetSetEventUptimeMs_JHandler")]
			public abstract LogEvent.Builder SetEventUptimeMs(long p0);

			// Token: 0x06000128 RID: 296 RVA: 0x000044F2 File Offset: 0x000026F2
			private static Delegate GetSetNetworkConnectionInfo_Lcom_google_android_datatransport_cct_internal_NetworkConnectionInfo_Handler()
			{
				if (LogEvent.Builder.cb_setNetworkConnectionInfo_Lcom_google_android_datatransport_cct_internal_NetworkConnectionInfo_ == null)
				{
					LogEvent.Builder.cb_setNetworkConnectionInfo_Lcom_google_android_datatransport_cct_internal_NetworkConnectionInfo_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(LogEvent.Builder.n_SetNetworkConnectionInfo_Lcom_google_android_datatransport_cct_internal_NetworkConnectionInfo_));
				}
				return LogEvent.Builder.cb_setNetworkConnectionInfo_Lcom_google_android_datatransport_cct_internal_NetworkConnectionInfo_;
			}

			// Token: 0x06000129 RID: 297 RVA: 0x00004518 File Offset: 0x00002718
			private static IntPtr n_SetNetworkConnectionInfo_Lcom_google_android_datatransport_cct_internal_NetworkConnectionInfo_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				LogEvent.Builder @object = Java.Lang.Object.GetObject<LogEvent.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				NetworkConnectionInfo object2 = Java.Lang.Object.GetObject<NetworkConnectionInfo>(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetNetworkConnectionInfo(object2));
			}

			// Token: 0x0600012A RID: 298
			[Register("setNetworkConnectionInfo", "(Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo;)Lcom/google/android/datatransport/cct/internal/LogEvent$Builder;", "GetSetNetworkConnectionInfo_Lcom_google_android_datatransport_cct_internal_NetworkConnectionInfo_Handler")]
			public abstract LogEvent.Builder SetNetworkConnectionInfo(NetworkConnectionInfo p0);

			// Token: 0x0600012B RID: 299 RVA: 0x00004540 File Offset: 0x00002740
			private static Delegate GetSetTimezoneOffsetSeconds_JHandler()
			{
				if (LogEvent.Builder.cb_setTimezoneOffsetSeconds_J == null)
				{
					LogEvent.Builder.cb_setTimezoneOffsetSeconds_J = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJ_L(LogEvent.Builder.n_SetTimezoneOffsetSeconds_J));
				}
				return LogEvent.Builder.cb_setTimezoneOffsetSeconds_J;
			}

			// Token: 0x0600012C RID: 300 RVA: 0x00004564 File Offset: 0x00002764
			private static IntPtr n_SetTimezoneOffsetSeconds_J(IntPtr jnienv, IntPtr native__this, long p0)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<LogEvent.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetTimezoneOffsetSeconds(p0));
			}

			// Token: 0x0600012D RID: 301
			[Register("setTimezoneOffsetSeconds", "(J)Lcom/google/android/datatransport/cct/internal/LogEvent$Builder;", "GetSetTimezoneOffsetSeconds_JHandler")]
			public abstract LogEvent.Builder SetTimezoneOffsetSeconds(long p0);

			// Token: 0x04000037 RID: 55
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/cct/internal/LogEvent$Builder", typeof(LogEvent.Builder));

			// Token: 0x04000038 RID: 56
			private static Delegate cb_build;

			// Token: 0x04000039 RID: 57
			private static Delegate cb_setEventCode_Ljava_lang_Integer_;

			// Token: 0x0400003A RID: 58
			private static Delegate cb_setEventTimeMs_J;

			// Token: 0x0400003B RID: 59
			private static Delegate cb_setEventUptimeMs_J;

			// Token: 0x0400003C RID: 60
			private static Delegate cb_setNetworkConnectionInfo_Lcom_google_android_datatransport_cct_internal_NetworkConnectionInfo_;

			// Token: 0x0400003D RID: 61
			private static Delegate cb_setTimezoneOffsetSeconds_J;
		}

		// Token: 0x02000018 RID: 24
		[Register("com/google/android/datatransport/cct/internal/LogEvent$Builder", DoNotGenerateAcw = true)]
		internal class BuilderInvoker : LogEvent.Builder
		{
			// Token: 0x0600012F RID: 303 RVA: 0x00004594 File Offset: 0x00002794
			public BuilderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
			{
			}

			// Token: 0x17000061 RID: 97
			// (get) Token: 0x06000130 RID: 304 RVA: 0x0000459E File Offset: 0x0000279E
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return LogEvent.BuilderInvoker._members;
				}
			}

			// Token: 0x17000062 RID: 98
			// (get) Token: 0x06000131 RID: 305 RVA: 0x000045A5 File Offset: 0x000027A5
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return LogEvent.BuilderInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000132 RID: 306 RVA: 0x000045B4 File Offset: 0x000027B4
			[Register("build", "()Lcom/google/android/datatransport/cct/internal/LogEvent;", "GetBuildHandler")]
			public override LogEvent Build()
			{
				return Java.Lang.Object.GetObject<LogEvent>(LogEvent.BuilderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("build.()Lcom/google/android/datatransport/cct/internal/LogEvent;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000133 RID: 307 RVA: 0x000045E8 File Offset: 0x000027E8
			[Register("setEventCode", "(Ljava/lang/Integer;)Lcom/google/android/datatransport/cct/internal/LogEvent$Builder;", "GetSetEventCode_Ljava_lang_Integer_Handler")]
			public unsafe override LogEvent.Builder SetEventCode(Integer p0)
			{
				LogEvent.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
					@object = Java.Lang.Object.GetObject<LogEvent.Builder>(LogEvent.BuilderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("setEventCode.(Ljava/lang/Integer;)Lcom/google/android/datatransport/cct/internal/LogEvent$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(p0);
				}
				return @object;
			}

			// Token: 0x06000134 RID: 308 RVA: 0x0000465C File Offset: 0x0000285C
			[Register("setEventTimeMs", "(J)Lcom/google/android/datatransport/cct/internal/LogEvent$Builder;", "GetSetEventTimeMs_JHandler")]
			public unsafe override LogEvent.Builder SetEventTimeMs(long p0)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(p0);
				return Java.Lang.Object.GetObject<LogEvent.Builder>(LogEvent.BuilderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("setEventTimeMs.(J)Lcom/google/android/datatransport/cct/internal/LogEvent$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000135 RID: 309 RVA: 0x000046A8 File Offset: 0x000028A8
			[Register("setEventUptimeMs", "(J)Lcom/google/android/datatransport/cct/internal/LogEvent$Builder;", "GetSetEventUptimeMs_JHandler")]
			public unsafe override LogEvent.Builder SetEventUptimeMs(long p0)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(p0);
				return Java.Lang.Object.GetObject<LogEvent.Builder>(LogEvent.BuilderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("setEventUptimeMs.(J)Lcom/google/android/datatransport/cct/internal/LogEvent$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000136 RID: 310 RVA: 0x000046F4 File Offset: 0x000028F4
			[Register("setNetworkConnectionInfo", "(Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo;)Lcom/google/android/datatransport/cct/internal/LogEvent$Builder;", "GetSetNetworkConnectionInfo_Lcom_google_android_datatransport_cct_internal_NetworkConnectionInfo_Handler")]
			public unsafe override LogEvent.Builder SetNetworkConnectionInfo(NetworkConnectionInfo p0)
			{
				LogEvent.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
					@object = Java.Lang.Object.GetObject<LogEvent.Builder>(LogEvent.BuilderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("setNetworkConnectionInfo.(Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo;)Lcom/google/android/datatransport/cct/internal/LogEvent$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(p0);
				}
				return @object;
			}

			// Token: 0x06000137 RID: 311 RVA: 0x00004768 File Offset: 0x00002968
			[Register("setTimezoneOffsetSeconds", "(J)Lcom/google/android/datatransport/cct/internal/LogEvent$Builder;", "GetSetTimezoneOffsetSeconds_JHandler")]
			public unsafe override LogEvent.Builder SetTimezoneOffsetSeconds(long p0)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(p0);
				return Java.Lang.Object.GetObject<LogEvent.Builder>(LogEvent.BuilderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("setTimezoneOffsetSeconds.(J)Lcom/google/android/datatransport/cct/internal/LogEvent$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0400003E RID: 62
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/cct/internal/LogEvent$Builder", typeof(LogEvent.BuilderInvoker));
		}
	}
}
