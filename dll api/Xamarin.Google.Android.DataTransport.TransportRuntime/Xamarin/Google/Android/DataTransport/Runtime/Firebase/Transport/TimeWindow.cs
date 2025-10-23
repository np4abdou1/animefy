using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Firebase.Transport
{
	// Token: 0x02000081 RID: 129
	[Register("com/google/android/datatransport/runtime/firebase/transport/TimeWindow", DoNotGenerateAcw = true)]
	public sealed class TimeWindow : Java.Lang.Object
	{
		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060004B2 RID: 1202 RVA: 0x0000EA04 File Offset: 0x0000CC04
		internal static IntPtr class_ref
		{
			get
			{
				return TimeWindow._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060004B3 RID: 1203 RVA: 0x0000EA28 File Offset: 0x0000CC28
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TimeWindow._members;
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060004B4 RID: 1204 RVA: 0x0000EA30 File Offset: 0x0000CC30
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TimeWindow._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060004B5 RID: 1205 RVA: 0x0000EA54 File Offset: 0x0000CC54
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TimeWindow._members.ManagedPeerType;
			}
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x000026C4 File Offset: 0x000008C4
		internal TimeWindow(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060004B7 RID: 1207 RVA: 0x0000EA60 File Offset: 0x0000CC60
		public static TimeWindow DefaultInstance
		{
			[Register("getDefaultInstance", "()Lcom/google/android/datatransport/runtime/firebase/transport/TimeWindow;", "")]
			get
			{
				return Java.Lang.Object.GetObject<TimeWindow>(TimeWindow._members.StaticMethods.InvokeObjectMethod("getDefaultInstance.()Lcom/google/android/datatransport/runtime/firebase/transport/TimeWindow;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060004B8 RID: 1208 RVA: 0x0000EA91 File Offset: 0x0000CC91
		public long EndMs
		{
			[Register("getEndMs", "()J", "")]
			get
			{
				return TimeWindow._members.InstanceMethods.InvokeAbstractInt64Method("getEndMs.()J", this, null);
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x0000EAAA File Offset: 0x0000CCAA
		public long StartMs
		{
			[Register("getStartMs", "()J", "")]
			get
			{
				return TimeWindow._members.InstanceMethods.InvokeAbstractInt64Method("getStartMs.()J", this, null);
			}
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x0000EAC4 File Offset: 0x0000CCC4
		[Register("newBuilder", "()Lcom/google/android/datatransport/runtime/firebase/transport/TimeWindow$Builder;", "")]
		public static TimeWindow.Builder NewBuilder()
		{
			return Java.Lang.Object.GetObject<TimeWindow.Builder>(TimeWindow._members.StaticMethods.InvokeObjectMethod("newBuilder.()Lcom/google/android/datatransport/runtime/firebase/transport/TimeWindow$Builder;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000105 RID: 261
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/firebase/transport/TimeWindow", typeof(TimeWindow));

		// Token: 0x02000082 RID: 130
		[Register("com/google/android/datatransport/runtime/firebase/transport/TimeWindow$Builder", DoNotGenerateAcw = true)]
		public sealed class Builder : Java.Lang.Object
		{
			// Token: 0x17000191 RID: 401
			// (get) Token: 0x060004BC RID: 1212 RVA: 0x0000EB10 File Offset: 0x0000CD10
			internal static IntPtr class_ref
			{
				get
				{
					return TimeWindow.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000192 RID: 402
			// (get) Token: 0x060004BD RID: 1213 RVA: 0x0000EB34 File Offset: 0x0000CD34
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return TimeWindow.Builder._members;
				}
			}

			// Token: 0x17000193 RID: 403
			// (get) Token: 0x060004BE RID: 1214 RVA: 0x0000EB3C File Offset: 0x0000CD3C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return TimeWindow.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000194 RID: 404
			// (get) Token: 0x060004BF RID: 1215 RVA: 0x0000EB60 File Offset: 0x0000CD60
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return TimeWindow.Builder._members.ManagedPeerType;
				}
			}

			// Token: 0x060004C0 RID: 1216 RVA: 0x000026C4 File Offset: 0x000008C4
			internal Builder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060004C1 RID: 1217 RVA: 0x0000EB6C File Offset: 0x0000CD6C
			[Register("build", "()Lcom/google/android/datatransport/runtime/firebase/transport/TimeWindow;", "")]
			public TimeWindow Build()
			{
				return Java.Lang.Object.GetObject<TimeWindow>(TimeWindow.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("build.()Lcom/google/android/datatransport/runtime/firebase/transport/TimeWindow;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060004C2 RID: 1218 RVA: 0x0000EBA0 File Offset: 0x0000CDA0
			[Register("setEndMs", "(J)Lcom/google/android/datatransport/runtime/firebase/transport/TimeWindow$Builder;", "")]
			public unsafe TimeWindow.Builder SetEndMs(long end_ms_)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(end_ms_);
				return Java.Lang.Object.GetObject<TimeWindow.Builder>(TimeWindow.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setEndMs.(J)Lcom/google/android/datatransport/runtime/firebase/transport/TimeWindow$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060004C3 RID: 1219 RVA: 0x0000EBEC File Offset: 0x0000CDEC
			[Register("setStartMs", "(J)Lcom/google/android/datatransport/runtime/firebase/transport/TimeWindow$Builder;", "")]
			public unsafe TimeWindow.Builder SetStartMs(long start_ms_)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(start_ms_);
				return Java.Lang.Object.GetObject<TimeWindow.Builder>(TimeWindow.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setStartMs.(J)Lcom/google/android/datatransport/runtime/firebase/transport/TimeWindow$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x04000106 RID: 262
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/firebase/transport/TimeWindow$Builder", typeof(TimeWindow.Builder));
		}
	}
}
