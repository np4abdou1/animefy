using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Firebase.Encoders.Proto;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Firebase.Transport
{
	// Token: 0x0200007A RID: 122
	[Register("com/google/android/datatransport/runtime/firebase/transport/LogEventDropped", DoNotGenerateAcw = true)]
	public sealed class LogEventDropped : Java.Lang.Object
	{
		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x0000DF4C File Offset: 0x0000C14C
		internal static IntPtr class_ref
		{
			get
			{
				return LogEventDropped._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000469 RID: 1129 RVA: 0x0000DF70 File Offset: 0x0000C170
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LogEventDropped._members;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x0000DF78 File Offset: 0x0000C178
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LogEventDropped._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x0600046B RID: 1131 RVA: 0x0000DF9C File Offset: 0x0000C19C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LogEventDropped._members.ManagedPeerType;
			}
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x000026C4 File Offset: 0x000008C4
		internal LogEventDropped(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x0000DFA8 File Offset: 0x0000C1A8
		public static LogEventDropped DefaultInstance
		{
			[Register("getDefaultInstance", "()Lcom/google/android/datatransport/runtime/firebase/transport/LogEventDropped;", "")]
			get
			{
				return Java.Lang.Object.GetObject<LogEventDropped>(LogEventDropped._members.StaticMethods.InvokeObjectMethod("getDefaultInstance.()Lcom/google/android/datatransport/runtime/firebase/transport/LogEventDropped;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x0000DFD9 File Offset: 0x0000C1D9
		public long EventsDroppedCount
		{
			[Register("getEventsDroppedCount", "()J", "")]
			get
			{
				return LogEventDropped._members.InstanceMethods.InvokeAbstractInt64Method("getEventsDroppedCount.()J", this, null);
			}
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x0000DFF4 File Offset: 0x0000C1F4
		[Register("getReason", "()Lcom/google/android/datatransport/runtime/firebase/transport/LogEventDropped$Reason;", "")]
		public LogEventDropped.Reason GetReason()
		{
			return Java.Lang.Object.GetObject<LogEventDropped.Reason>(LogEventDropped._members.InstanceMethods.InvokeAbstractObjectMethod("getReason.()Lcom/google/android/datatransport/runtime/firebase/transport/LogEventDropped$Reason;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x0000E028 File Offset: 0x0000C228
		[Register("newBuilder", "()Lcom/google/android/datatransport/runtime/firebase/transport/LogEventDropped$Builder;", "")]
		public static LogEventDropped.Builder NewBuilder()
		{
			return Java.Lang.Object.GetObject<LogEventDropped.Builder>(LogEventDropped._members.StaticMethods.InvokeObjectMethod("newBuilder.()Lcom/google/android/datatransport/runtime/firebase/transport/LogEventDropped$Builder;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040000FE RID: 254
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/firebase/transport/LogEventDropped", typeof(LogEventDropped));

		// Token: 0x0200007B RID: 123
		[Register("com/google/android/datatransport/runtime/firebase/transport/LogEventDropped$Builder", DoNotGenerateAcw = true)]
		public sealed class Builder : Java.Lang.Object
		{
			// Token: 0x17000164 RID: 356
			// (get) Token: 0x06000472 RID: 1138 RVA: 0x0000E074 File Offset: 0x0000C274
			internal static IntPtr class_ref
			{
				get
				{
					return LogEventDropped.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000165 RID: 357
			// (get) Token: 0x06000473 RID: 1139 RVA: 0x0000E098 File Offset: 0x0000C298
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return LogEventDropped.Builder._members;
				}
			}

			// Token: 0x17000166 RID: 358
			// (get) Token: 0x06000474 RID: 1140 RVA: 0x0000E0A0 File Offset: 0x0000C2A0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return LogEventDropped.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000167 RID: 359
			// (get) Token: 0x06000475 RID: 1141 RVA: 0x0000E0C4 File Offset: 0x0000C2C4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return LogEventDropped.Builder._members.ManagedPeerType;
				}
			}

			// Token: 0x06000476 RID: 1142 RVA: 0x000026C4 File Offset: 0x000008C4
			internal Builder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06000477 RID: 1143 RVA: 0x0000E0D0 File Offset: 0x0000C2D0
			[Register("build", "()Lcom/google/android/datatransport/runtime/firebase/transport/LogEventDropped;", "")]
			public LogEventDropped Build()
			{
				return Java.Lang.Object.GetObject<LogEventDropped>(LogEventDropped.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("build.()Lcom/google/android/datatransport/runtime/firebase/transport/LogEventDropped;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000478 RID: 1144 RVA: 0x0000E104 File Offset: 0x0000C304
			[Register("setEventsDroppedCount", "(J)Lcom/google/android/datatransport/runtime/firebase/transport/LogEventDropped$Builder;", "")]
			public unsafe LogEventDropped.Builder SetEventsDroppedCount(long events_dropped_count_)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(events_dropped_count_);
				return Java.Lang.Object.GetObject<LogEventDropped.Builder>(LogEventDropped.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setEventsDroppedCount.(J)Lcom/google/android/datatransport/runtime/firebase/transport/LogEventDropped$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000479 RID: 1145 RVA: 0x0000E150 File Offset: 0x0000C350
			[Register("setReason", "(Lcom/google/android/datatransport/runtime/firebase/transport/LogEventDropped$Reason;)Lcom/google/android/datatransport/runtime/firebase/transport/LogEventDropped$Builder;", "")]
			public unsafe LogEventDropped.Builder SetReason(LogEventDropped.Reason reason_)
			{
				LogEventDropped.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((reason_ == null) ? IntPtr.Zero : reason_.Handle);
					@object = Java.Lang.Object.GetObject<LogEventDropped.Builder>(LogEventDropped.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setReason.(Lcom/google/android/datatransport/runtime/firebase/transport/LogEventDropped$Reason;)Lcom/google/android/datatransport/runtime/firebase/transport/LogEventDropped$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(reason_);
				}
				return @object;
			}

			// Token: 0x040000FF RID: 255
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/firebase/transport/LogEventDropped$Builder", typeof(LogEventDropped.Builder));
		}

		// Token: 0x0200007C RID: 124
		[Register("com/google/android/datatransport/runtime/firebase/transport/LogEventDropped$Reason", DoNotGenerateAcw = true)]
		public sealed class Reason : Java.Lang.Enum, IProtoEnum, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000168 RID: 360
			// (get) Token: 0x0600047B RID: 1147 RVA: 0x0000E1E0 File Offset: 0x0000C3E0
			[Register("CACHE_FULL")]
			public static LogEventDropped.Reason CacheFull
			{
				get
				{
					return Java.Lang.Object.GetObject<LogEventDropped.Reason>(LogEventDropped.Reason._members.StaticFields.GetObjectValue("CACHE_FULL.Lcom/google/android/datatransport/runtime/firebase/transport/LogEventDropped$Reason;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000169 RID: 361
			// (get) Token: 0x0600047C RID: 1148 RVA: 0x0000E210 File Offset: 0x0000C410
			[Register("INVALID_PAYLOD")]
			public static LogEventDropped.Reason InvalidPaylod
			{
				get
				{
					return Java.Lang.Object.GetObject<LogEventDropped.Reason>(LogEventDropped.Reason._members.StaticFields.GetObjectValue("INVALID_PAYLOD.Lcom/google/android/datatransport/runtime/firebase/transport/LogEventDropped$Reason;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x1700016A RID: 362
			// (get) Token: 0x0600047D RID: 1149 RVA: 0x0000E240 File Offset: 0x0000C440
			[Register("MAX_RETRIES_REACHED")]
			public static LogEventDropped.Reason MaxRetriesReached
			{
				get
				{
					return Java.Lang.Object.GetObject<LogEventDropped.Reason>(LogEventDropped.Reason._members.StaticFields.GetObjectValue("MAX_RETRIES_REACHED.Lcom/google/android/datatransport/runtime/firebase/transport/LogEventDropped$Reason;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x1700016B RID: 363
			// (get) Token: 0x0600047E RID: 1150 RVA: 0x0000E270 File Offset: 0x0000C470
			[Register("MESSAGE_TOO_OLD")]
			public static LogEventDropped.Reason MessageTooOld
			{
				get
				{
					return Java.Lang.Object.GetObject<LogEventDropped.Reason>(LogEventDropped.Reason._members.StaticFields.GetObjectValue("MESSAGE_TOO_OLD.Lcom/google/android/datatransport/runtime/firebase/transport/LogEventDropped$Reason;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x1700016C RID: 364
			// (get) Token: 0x0600047F RID: 1151 RVA: 0x0000E2A0 File Offset: 0x0000C4A0
			[Register("PAYLOAD_TOO_BIG")]
			public static LogEventDropped.Reason PayloadTooBig
			{
				get
				{
					return Java.Lang.Object.GetObject<LogEventDropped.Reason>(LogEventDropped.Reason._members.StaticFields.GetObjectValue("PAYLOAD_TOO_BIG.Lcom/google/android/datatransport/runtime/firebase/transport/LogEventDropped$Reason;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x1700016D RID: 365
			// (get) Token: 0x06000480 RID: 1152 RVA: 0x0000E2D0 File Offset: 0x0000C4D0
			[Register("REASON_UNKNOWN")]
			public static LogEventDropped.Reason ReasonUnknown
			{
				get
				{
					return Java.Lang.Object.GetObject<LogEventDropped.Reason>(LogEventDropped.Reason._members.StaticFields.GetObjectValue("REASON_UNKNOWN.Lcom/google/android/datatransport/runtime/firebase/transport/LogEventDropped$Reason;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x1700016E RID: 366
			// (get) Token: 0x06000481 RID: 1153 RVA: 0x0000E300 File Offset: 0x0000C500
			[Register("SERVER_ERROR")]
			public static LogEventDropped.Reason ServerError
			{
				get
				{
					return Java.Lang.Object.GetObject<LogEventDropped.Reason>(LogEventDropped.Reason._members.StaticFields.GetObjectValue("SERVER_ERROR.Lcom/google/android/datatransport/runtime/firebase/transport/LogEventDropped$Reason;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x1700016F RID: 367
			// (get) Token: 0x06000482 RID: 1154 RVA: 0x0000E330 File Offset: 0x0000C530
			internal static IntPtr class_ref
			{
				get
				{
					return LogEventDropped.Reason._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000170 RID: 368
			// (get) Token: 0x06000483 RID: 1155 RVA: 0x0000E354 File Offset: 0x0000C554
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return LogEventDropped.Reason._members;
				}
			}

			// Token: 0x17000171 RID: 369
			// (get) Token: 0x06000484 RID: 1156 RVA: 0x0000E35C File Offset: 0x0000C55C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return LogEventDropped.Reason._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000172 RID: 370
			// (get) Token: 0x06000485 RID: 1157 RVA: 0x0000E380 File Offset: 0x0000C580
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return LogEventDropped.Reason._members.ManagedPeerType;
				}
			}

			// Token: 0x06000486 RID: 1158 RVA: 0x00009400 File Offset: 0x00007600
			internal Reason(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x17000173 RID: 371
			// (get) Token: 0x06000487 RID: 1159 RVA: 0x0000E38C File Offset: 0x0000C58C
			public int Number
			{
				[Register("getNumber", "()I", "")]
				get
				{
					return LogEventDropped.Reason._members.InstanceMethods.InvokeAbstractInt32Method("getNumber.()I", this, null);
				}
			}

			// Token: 0x06000488 RID: 1160 RVA: 0x0000E3A8 File Offset: 0x0000C5A8
			[Register("valueOf", "(Ljava/lang/String;)Lcom/google/android/datatransport/runtime/firebase/transport/LogEventDropped$Reason;", "")]
			public unsafe static LogEventDropped.Reason ValueOf(string name)
			{
				IntPtr intPtr = JNIEnv.NewString(name);
				LogEventDropped.Reason @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<LogEventDropped.Reason>(LogEventDropped.Reason._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/google/android/datatransport/runtime/firebase/transport/LogEventDropped$Reason;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x06000489 RID: 1161 RVA: 0x0000E414 File Offset: 0x0000C614
			[Register("values", "()[Lcom/google/android/datatransport/runtime/firebase/transport/LogEventDropped$Reason;", "")]
			public static LogEventDropped.Reason[] Values()
			{
				return (LogEventDropped.Reason[])JNIEnv.GetArray(LogEventDropped.Reason._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/google/android/datatransport/runtime/firebase/transport/LogEventDropped$Reason;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(LogEventDropped.Reason));
			}

			// Token: 0x04000100 RID: 256
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/firebase/transport/LogEventDropped$Reason", typeof(LogEventDropped.Reason));
		}
	}
}
