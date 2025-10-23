using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Firebase.Transport
{
	// Token: 0x0200007D RID: 125
	[Register("com/google/android/datatransport/runtime/firebase/transport/LogSourceMetrics", DoNotGenerateAcw = true)]
	public sealed class LogSourceMetrics : Java.Lang.Object
	{
		// Token: 0x17000174 RID: 372
		// (get) Token: 0x0600048B RID: 1163 RVA: 0x0000E470 File Offset: 0x0000C670
		internal static IntPtr class_ref
		{
			get
			{
				return LogSourceMetrics._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x0600048C RID: 1164 RVA: 0x0000E494 File Offset: 0x0000C694
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LogSourceMetrics._members;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x0600048D RID: 1165 RVA: 0x0000E49C File Offset: 0x0000C69C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LogSourceMetrics._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x0600048E RID: 1166 RVA: 0x0000E4C0 File Offset: 0x0000C6C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LogSourceMetrics._members.ManagedPeerType;
			}
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x000026C4 File Offset: 0x000008C4
		internal LogSourceMetrics(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000490 RID: 1168 RVA: 0x0000E4CC File Offset: 0x0000C6CC
		public static LogSourceMetrics DefaultInstance
		{
			[Register("getDefaultInstance", "()Lcom/google/android/datatransport/runtime/firebase/transport/LogSourceMetrics;", "")]
			get
			{
				return Java.Lang.Object.GetObject<LogSourceMetrics>(LogSourceMetrics._members.StaticMethods.InvokeObjectMethod("getDefaultInstance.()Lcom/google/android/datatransport/runtime/firebase/transport/LogSourceMetrics;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x0000E500 File Offset: 0x0000C700
		public IList<LogEventDropped> LogEventDroppedList
		{
			[Register("getLogEventDroppedList", "()Ljava/util/List;", "")]
			get
			{
				return JavaList<LogEventDropped>.FromJniHandle(LogSourceMetrics._members.InstanceMethods.InvokeAbstractObjectMethod("getLogEventDroppedList.()Ljava/util/List;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000492 RID: 1170 RVA: 0x0000E534 File Offset: 0x0000C734
		public string LogSource
		{
			[Register("getLogSource", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(LogSourceMetrics._members.InstanceMethods.InvokeAbstractObjectMethod("getLogSource.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x0000E568 File Offset: 0x0000C768
		[Register("newBuilder", "()Lcom/google/android/datatransport/runtime/firebase/transport/LogSourceMetrics$Builder;", "")]
		public static LogSourceMetrics.Builder NewBuilder()
		{
			return Java.Lang.Object.GetObject<LogSourceMetrics.Builder>(LogSourceMetrics._members.StaticMethods.InvokeObjectMethod("newBuilder.()Lcom/google/android/datatransport/runtime/firebase/transport/LogSourceMetrics$Builder;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000101 RID: 257
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/firebase/transport/LogSourceMetrics", typeof(LogSourceMetrics));

		// Token: 0x0200007E RID: 126
		[Register("com/google/android/datatransport/runtime/firebase/transport/LogSourceMetrics$Builder", DoNotGenerateAcw = true)]
		public sealed class Builder : Java.Lang.Object
		{
			// Token: 0x1700017B RID: 379
			// (get) Token: 0x06000495 RID: 1173 RVA: 0x0000E5B4 File Offset: 0x0000C7B4
			internal static IntPtr class_ref
			{
				get
				{
					return LogSourceMetrics.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700017C RID: 380
			// (get) Token: 0x06000496 RID: 1174 RVA: 0x0000E5D8 File Offset: 0x0000C7D8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return LogSourceMetrics.Builder._members;
				}
			}

			// Token: 0x1700017D RID: 381
			// (get) Token: 0x06000497 RID: 1175 RVA: 0x0000E5E0 File Offset: 0x0000C7E0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return LogSourceMetrics.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700017E RID: 382
			// (get) Token: 0x06000498 RID: 1176 RVA: 0x0000E604 File Offset: 0x0000C804
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return LogSourceMetrics.Builder._members.ManagedPeerType;
				}
			}

			// Token: 0x06000499 RID: 1177 RVA: 0x000026C4 File Offset: 0x000008C4
			internal Builder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0600049A RID: 1178 RVA: 0x0000E610 File Offset: 0x0000C810
			[Register("addLogEventDropped", "(Lcom/google/android/datatransport/runtime/firebase/transport/LogEventDropped;)Lcom/google/android/datatransport/runtime/firebase/transport/LogSourceMetrics$Builder;", "")]
			public unsafe LogSourceMetrics.Builder AddLogEventDropped(LogEventDropped log_event_dropped_)
			{
				LogSourceMetrics.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((log_event_dropped_ == null) ? IntPtr.Zero : log_event_dropped_.Handle);
					@object = Java.Lang.Object.GetObject<LogSourceMetrics.Builder>(LogSourceMetrics.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("addLogEventDropped.(Lcom/google/android/datatransport/runtime/firebase/transport/LogEventDropped;)Lcom/google/android/datatransport/runtime/firebase/transport/LogSourceMetrics$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(log_event_dropped_);
				}
				return @object;
			}

			// Token: 0x0600049B RID: 1179 RVA: 0x0000E684 File Offset: 0x0000C884
			[Register("build", "()Lcom/google/android/datatransport/runtime/firebase/transport/LogSourceMetrics;", "")]
			public LogSourceMetrics Build()
			{
				return Java.Lang.Object.GetObject<LogSourceMetrics>(LogSourceMetrics.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("build.()Lcom/google/android/datatransport/runtime/firebase/transport/LogSourceMetrics;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0600049C RID: 1180 RVA: 0x0000E6B8 File Offset: 0x0000C8B8
			[Register("setLogEventDroppedList", "(Ljava/util/List;)Lcom/google/android/datatransport/runtime/firebase/transport/LogSourceMetrics$Builder;", "")]
			public unsafe LogSourceMetrics.Builder SetLogEventDroppedList(IList<LogEventDropped> log_event_dropped_)
			{
				IntPtr intPtr = JavaList<LogEventDropped>.ToLocalJniHandle(log_event_dropped_);
				LogSourceMetrics.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<LogSourceMetrics.Builder>(LogSourceMetrics.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setLogEventDroppedList.(Ljava/util/List;)Lcom/google/android/datatransport/runtime/firebase/transport/LogSourceMetrics$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(log_event_dropped_);
				}
				return @object;
			}

			// Token: 0x0600049D RID: 1181 RVA: 0x0000E72C File Offset: 0x0000C92C
			[Register("setLogSource", "(Ljava/lang/String;)Lcom/google/android/datatransport/runtime/firebase/transport/LogSourceMetrics$Builder;", "")]
			public unsafe LogSourceMetrics.Builder SetLogSource(string log_source_)
			{
				IntPtr intPtr = JNIEnv.NewString(log_source_);
				LogSourceMetrics.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<LogSourceMetrics.Builder>(LogSourceMetrics.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setLogSource.(Ljava/lang/String;)Lcom/google/android/datatransport/runtime/firebase/transport/LogSourceMetrics$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x04000102 RID: 258
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/firebase/transport/LogSourceMetrics$Builder", typeof(LogSourceMetrics.Builder));
		}
	}
}
