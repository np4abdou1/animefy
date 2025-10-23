using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Firebase.Transport
{
	// Token: 0x02000078 RID: 120
	[Register("com/google/android/datatransport/runtime/firebase/transport/GlobalMetrics", DoNotGenerateAcw = true)]
	public sealed class GlobalMetrics : Java.Lang.Object
	{
		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x0000DCE8 File Offset: 0x0000BEE8
		internal static IntPtr class_ref
		{
			get
			{
				return GlobalMetrics._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000457 RID: 1111 RVA: 0x0000DD0C File Offset: 0x0000BF0C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return GlobalMetrics._members;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000458 RID: 1112 RVA: 0x0000DD14 File Offset: 0x0000BF14
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return GlobalMetrics._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000459 RID: 1113 RVA: 0x0000DD38 File Offset: 0x0000BF38
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return GlobalMetrics._members.ManagedPeerType;
			}
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x000026C4 File Offset: 0x000008C4
		internal GlobalMetrics(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x0600045B RID: 1115 RVA: 0x0000DD44 File Offset: 0x0000BF44
		public static GlobalMetrics DefaultInstance
		{
			[Register("getDefaultInstance", "()Lcom/google/android/datatransport/runtime/firebase/transport/GlobalMetrics;", "")]
			get
			{
				return Java.Lang.Object.GetObject<GlobalMetrics>(GlobalMetrics._members.StaticMethods.InvokeObjectMethod("getDefaultInstance.()Lcom/google/android/datatransport/runtime/firebase/transport/GlobalMetrics;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x0600045C RID: 1116 RVA: 0x0000DD78 File Offset: 0x0000BF78
		public StorageMetrics StorageMetrics
		{
			[Register("getStorageMetrics", "()Lcom/google/android/datatransport/runtime/firebase/transport/StorageMetrics;", "")]
			get
			{
				return Java.Lang.Object.GetObject<StorageMetrics>(GlobalMetrics._members.InstanceMethods.InvokeAbstractObjectMethod("getStorageMetrics.()Lcom/google/android/datatransport/runtime/firebase/transport/StorageMetrics;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x0600045D RID: 1117 RVA: 0x0000DDAC File Offset: 0x0000BFAC
		public StorageMetrics StorageMetricsInternal
		{
			[Register("getStorageMetricsInternal", "()Lcom/google/android/datatransport/runtime/firebase/transport/StorageMetrics;", "")]
			get
			{
				return Java.Lang.Object.GetObject<StorageMetrics>(GlobalMetrics._members.InstanceMethods.InvokeAbstractObjectMethod("getStorageMetricsInternal.()Lcom/google/android/datatransport/runtime/firebase/transport/StorageMetrics;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x0000DDE0 File Offset: 0x0000BFE0
		[Register("newBuilder", "()Lcom/google/android/datatransport/runtime/firebase/transport/GlobalMetrics$Builder;", "")]
		public static GlobalMetrics.Builder NewBuilder()
		{
			return Java.Lang.Object.GetObject<GlobalMetrics.Builder>(GlobalMetrics._members.StaticMethods.InvokeObjectMethod("newBuilder.()Lcom/google/android/datatransport/runtime/firebase/transport/GlobalMetrics$Builder;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040000FC RID: 252
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/firebase/transport/GlobalMetrics", typeof(GlobalMetrics));

		// Token: 0x02000079 RID: 121
		[Register("com/google/android/datatransport/runtime/firebase/transport/GlobalMetrics$Builder", DoNotGenerateAcw = true)]
		public sealed class Builder : Java.Lang.Object
		{
			// Token: 0x1700015A RID: 346
			// (get) Token: 0x06000460 RID: 1120 RVA: 0x0000DE2C File Offset: 0x0000C02C
			internal static IntPtr class_ref
			{
				get
				{
					return GlobalMetrics.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700015B RID: 347
			// (get) Token: 0x06000461 RID: 1121 RVA: 0x0000DE50 File Offset: 0x0000C050
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return GlobalMetrics.Builder._members;
				}
			}

			// Token: 0x1700015C RID: 348
			// (get) Token: 0x06000462 RID: 1122 RVA: 0x0000DE58 File Offset: 0x0000C058
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return GlobalMetrics.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700015D RID: 349
			// (get) Token: 0x06000463 RID: 1123 RVA: 0x0000DE7C File Offset: 0x0000C07C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return GlobalMetrics.Builder._members.ManagedPeerType;
				}
			}

			// Token: 0x06000464 RID: 1124 RVA: 0x000026C4 File Offset: 0x000008C4
			internal Builder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06000465 RID: 1125 RVA: 0x0000DE88 File Offset: 0x0000C088
			[Register("build", "()Lcom/google/android/datatransport/runtime/firebase/transport/GlobalMetrics;", "")]
			public GlobalMetrics Build()
			{
				return Java.Lang.Object.GetObject<GlobalMetrics>(GlobalMetrics.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("build.()Lcom/google/android/datatransport/runtime/firebase/transport/GlobalMetrics;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000466 RID: 1126 RVA: 0x0000DEBC File Offset: 0x0000C0BC
			[Register("setStorageMetrics", "(Lcom/google/android/datatransport/runtime/firebase/transport/StorageMetrics;)Lcom/google/android/datatransport/runtime/firebase/transport/GlobalMetrics$Builder;", "")]
			public unsafe GlobalMetrics.Builder SetStorageMetrics(StorageMetrics storage_metrics_)
			{
				GlobalMetrics.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((storage_metrics_ == null) ? IntPtr.Zero : storage_metrics_.Handle);
					@object = Java.Lang.Object.GetObject<GlobalMetrics.Builder>(GlobalMetrics.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setStorageMetrics.(Lcom/google/android/datatransport/runtime/firebase/transport/StorageMetrics;)Lcom/google/android/datatransport/runtime/firebase/transport/GlobalMetrics$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(storage_metrics_);
				}
				return @object;
			}

			// Token: 0x040000FD RID: 253
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/firebase/transport/GlobalMetrics$Builder", typeof(GlobalMetrics.Builder));
		}
	}
}
