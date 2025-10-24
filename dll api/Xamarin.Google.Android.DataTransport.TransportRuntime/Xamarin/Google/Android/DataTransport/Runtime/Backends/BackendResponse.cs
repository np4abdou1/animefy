using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Backends
{
	// Token: 0x02000089 RID: 137
	[Register("com/google/android/datatransport/runtime/backends/BackendResponse", DoNotGenerateAcw = true)]
	public abstract class BackendResponse : Java.Lang.Object
	{
		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x060004FC RID: 1276 RVA: 0x0000F354 File Offset: 0x0000D554
		internal static IntPtr class_ref
		{
			get
			{
				return BackendResponse._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x060004FD RID: 1277 RVA: 0x0000F378 File Offset: 0x0000D578
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BackendResponse._members;
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x060004FE RID: 1278 RVA: 0x0000F380 File Offset: 0x0000D580
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BackendResponse._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x060004FF RID: 1279 RVA: 0x0000F3A4 File Offset: 0x0000D5A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BackendResponse._members.ManagedPeerType;
			}
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x000026C4 File Offset: 0x000008C4
		protected BackendResponse(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x0000F3B0 File Offset: 0x0000D5B0
		[Register(".ctor", "()V", "")]
		public BackendResponse() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(BackendResponse._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			BackendResponse._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x0000F41E File Offset: 0x0000D61E
		private static Delegate GetGetNextRequestWaitMillisHandler()
		{
			if (BackendResponse.cb_getNextRequestWaitMillis == null)
			{
				BackendResponse.cb_getNextRequestWaitMillis = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(BackendResponse.n_GetNextRequestWaitMillis));
			}
			return BackendResponse.cb_getNextRequestWaitMillis;
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x0000F442 File Offset: 0x0000D642
		private static long n_GetNextRequestWaitMillis(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BackendResponse>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NextRequestWaitMillis;
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000504 RID: 1284
		public abstract long NextRequestWaitMillis { [Register("getNextRequestWaitMillis", "()J", "GetGetNextRequestWaitMillisHandler")] get; }

		// Token: 0x06000505 RID: 1285 RVA: 0x0000F454 File Offset: 0x0000D654
		[Register("fatalError", "()Lcom/google/android/datatransport/runtime/backends/BackendResponse;", "")]
		public static BackendResponse FatalError()
		{
			return Java.Lang.Object.GetObject<BackendResponse>(BackendResponse._members.StaticMethods.InvokeObjectMethod("fatalError.()Lcom/google/android/datatransport/runtime/backends/BackendResponse;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x0000F485 File Offset: 0x0000D685
		private static Delegate GetGetStatusHandler()
		{
			if (BackendResponse.cb_getStatus == null)
			{
				BackendResponse.cb_getStatus = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(BackendResponse.n_GetStatus));
			}
			return BackendResponse.cb_getStatus;
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x0000F4A9 File Offset: 0x0000D6A9
		private static IntPtr n_GetStatus(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BackendResponse>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetStatus());
		}

		// Token: 0x06000508 RID: 1288
		[Register("getStatus", "()Lcom/google/android/datatransport/runtime/backends/BackendResponse$Status;", "GetGetStatusHandler")]
		public abstract BackendResponse.Status GetStatus();

		// Token: 0x06000509 RID: 1289 RVA: 0x0000F4C0 File Offset: 0x0000D6C0
		[Register("invalidPayload", "()Lcom/google/android/datatransport/runtime/backends/BackendResponse;", "")]
		public static BackendResponse InvalidPayload()
		{
			return Java.Lang.Object.GetObject<BackendResponse>(BackendResponse._members.StaticMethods.InvokeObjectMethod("invalidPayload.()Lcom/google/android/datatransport/runtime/backends/BackendResponse;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x0000F4F4 File Offset: 0x0000D6F4
		[Register("ok", "(J)Lcom/google/android/datatransport/runtime/backends/BackendResponse;", "")]
		public unsafe static BackendResponse Ok(long nextRequestWaitMillis)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(nextRequestWaitMillis);
			return Java.Lang.Object.GetObject<BackendResponse>(BackendResponse._members.StaticMethods.InvokeObjectMethod("ok.(J)Lcom/google/android/datatransport/runtime/backends/BackendResponse;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x0000F53C File Offset: 0x0000D73C
		[Register("transientError", "()Lcom/google/android/datatransport/runtime/backends/BackendResponse;", "")]
		public static BackendResponse TransientError()
		{
			return Java.Lang.Object.GetObject<BackendResponse>(BackendResponse._members.StaticMethods.InvokeObjectMethod("transientError.()Lcom/google/android/datatransport/runtime/backends/BackendResponse;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000112 RID: 274
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/backends/BackendResponse", typeof(BackendResponse));

		// Token: 0x04000113 RID: 275
		private static Delegate cb_getNextRequestWaitMillis;

		// Token: 0x04000114 RID: 276
		private static Delegate cb_getStatus;

		// Token: 0x0200008A RID: 138
		[Register("com/google/android/datatransport/runtime/backends/BackendResponse$Status", DoNotGenerateAcw = true)]
		public sealed class Status : Java.Lang.Enum
		{
			// Token: 0x170001AE RID: 430
			// (get) Token: 0x0600050D RID: 1293 RVA: 0x0000F588 File Offset: 0x0000D788
			[Register("FATAL_ERROR")]
			public static BackendResponse.Status FatalError
			{
				get
				{
					return Java.Lang.Object.GetObject<BackendResponse.Status>(BackendResponse.Status._members.StaticFields.GetObjectValue("FATAL_ERROR.Lcom/google/android/datatransport/runtime/backends/BackendResponse$Status;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170001AF RID: 431
			// (get) Token: 0x0600050E RID: 1294 RVA: 0x0000F5B8 File Offset: 0x0000D7B8
			[Register("INVALID_PAYLOAD")]
			public static BackendResponse.Status InvalidPayload
			{
				get
				{
					return Java.Lang.Object.GetObject<BackendResponse.Status>(BackendResponse.Status._members.StaticFields.GetObjectValue("INVALID_PAYLOAD.Lcom/google/android/datatransport/runtime/backends/BackendResponse$Status;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170001B0 RID: 432
			// (get) Token: 0x0600050F RID: 1295 RVA: 0x0000F5E8 File Offset: 0x0000D7E8
			[Register("OK")]
			public static BackendResponse.Status Ok
			{
				get
				{
					return Java.Lang.Object.GetObject<BackendResponse.Status>(BackendResponse.Status._members.StaticFields.GetObjectValue("OK.Lcom/google/android/datatransport/runtime/backends/BackendResponse$Status;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170001B1 RID: 433
			// (get) Token: 0x06000510 RID: 1296 RVA: 0x0000F618 File Offset: 0x0000D818
			[Register("TRANSIENT_ERROR")]
			public static BackendResponse.Status TransientError
			{
				get
				{
					return Java.Lang.Object.GetObject<BackendResponse.Status>(BackendResponse.Status._members.StaticFields.GetObjectValue("TRANSIENT_ERROR.Lcom/google/android/datatransport/runtime/backends/BackendResponse$Status;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170001B2 RID: 434
			// (get) Token: 0x06000511 RID: 1297 RVA: 0x0000F648 File Offset: 0x0000D848
			internal static IntPtr class_ref
			{
				get
				{
					return BackendResponse.Status._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170001B3 RID: 435
			// (get) Token: 0x06000512 RID: 1298 RVA: 0x0000F66C File Offset: 0x0000D86C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return BackendResponse.Status._members;
				}
			}

			// Token: 0x170001B4 RID: 436
			// (get) Token: 0x06000513 RID: 1299 RVA: 0x0000F674 File Offset: 0x0000D874
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return BackendResponse.Status._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170001B5 RID: 437
			// (get) Token: 0x06000514 RID: 1300 RVA: 0x0000F698 File Offset: 0x0000D898
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return BackendResponse.Status._members.ManagedPeerType;
				}
			}

			// Token: 0x06000515 RID: 1301 RVA: 0x00009400 File Offset: 0x00007600
			internal Status(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06000516 RID: 1302 RVA: 0x0000F6A4 File Offset: 0x0000D8A4
			[Register("valueOf", "(Ljava/lang/String;)Lcom/google/android/datatransport/runtime/backends/BackendResponse$Status;", "")]
			public unsafe static BackendResponse.Status ValueOf(string name)
			{
				IntPtr intPtr = JNIEnv.NewString(name);
				BackendResponse.Status @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<BackendResponse.Status>(BackendResponse.Status._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/google/android/datatransport/runtime/backends/BackendResponse$Status;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x06000517 RID: 1303 RVA: 0x0000F710 File Offset: 0x0000D910
			[Register("values", "()[Lcom/google/android/datatransport/runtime/backends/BackendResponse$Status;", "")]
			public static BackendResponse.Status[] Values()
			{
				return (BackendResponse.Status[])JNIEnv.GetArray(BackendResponse.Status._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/google/android/datatransport/runtime/backends/BackendResponse$Status;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(BackendResponse.Status));
			}

			// Token: 0x04000115 RID: 277
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/backends/BackendResponse$Status", typeof(BackendResponse.Status));
		}
	}
}
