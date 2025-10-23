using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Firebase.Transport
{
	// Token: 0x0200007F RID: 127
	[Register("com/google/android/datatransport/runtime/firebase/transport/StorageMetrics", DoNotGenerateAcw = true)]
	public sealed class StorageMetrics : Java.Lang.Object
	{
		// Token: 0x1700017F RID: 383
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x0000E7B4 File Offset: 0x0000C9B4
		internal static IntPtr class_ref
		{
			get
			{
				return StorageMetrics._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060004A0 RID: 1184 RVA: 0x0000E7D8 File Offset: 0x0000C9D8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return StorageMetrics._members;
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x0000E7E0 File Offset: 0x0000C9E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return StorageMetrics._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060004A2 RID: 1186 RVA: 0x0000E804 File Offset: 0x0000CA04
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return StorageMetrics._members.ManagedPeerType;
			}
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x000026C4 File Offset: 0x000008C4
		internal StorageMetrics(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060004A4 RID: 1188 RVA: 0x0000E810 File Offset: 0x0000CA10
		public long CurrentCacheSizeBytes
		{
			[Register("getCurrentCacheSizeBytes", "()J", "")]
			get
			{
				return StorageMetrics._members.InstanceMethods.InvokeAbstractInt64Method("getCurrentCacheSizeBytes.()J", this, null);
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060004A5 RID: 1189 RVA: 0x0000E82C File Offset: 0x0000CA2C
		public static StorageMetrics DefaultInstance
		{
			[Register("getDefaultInstance", "()Lcom/google/android/datatransport/runtime/firebase/transport/StorageMetrics;", "")]
			get
			{
				return Java.Lang.Object.GetObject<StorageMetrics>(StorageMetrics._members.StaticMethods.InvokeObjectMethod("getDefaultInstance.()Lcom/google/android/datatransport/runtime/firebase/transport/StorageMetrics;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060004A6 RID: 1190 RVA: 0x0000E85D File Offset: 0x0000CA5D
		public long MaxCacheSizeBytes
		{
			[Register("getMaxCacheSizeBytes", "()J", "")]
			get
			{
				return StorageMetrics._members.InstanceMethods.InvokeAbstractInt64Method("getMaxCacheSizeBytes.()J", this, null);
			}
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x0000E878 File Offset: 0x0000CA78
		[Register("newBuilder", "()Lcom/google/android/datatransport/runtime/firebase/transport/StorageMetrics$Builder;", "")]
		public static StorageMetrics.Builder NewBuilder()
		{
			return Java.Lang.Object.GetObject<StorageMetrics.Builder>(StorageMetrics._members.StaticMethods.InvokeObjectMethod("newBuilder.()Lcom/google/android/datatransport/runtime/firebase/transport/StorageMetrics$Builder;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000103 RID: 259
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/firebase/transport/StorageMetrics", typeof(StorageMetrics));

		// Token: 0x02000080 RID: 128
		[Register("com/google/android/datatransport/runtime/firebase/transport/StorageMetrics$Builder", DoNotGenerateAcw = true)]
		public sealed class Builder : Java.Lang.Object
		{
			// Token: 0x17000186 RID: 390
			// (get) Token: 0x060004A9 RID: 1193 RVA: 0x0000E8C4 File Offset: 0x0000CAC4
			internal static IntPtr class_ref
			{
				get
				{
					return StorageMetrics.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000187 RID: 391
			// (get) Token: 0x060004AA RID: 1194 RVA: 0x0000E8E8 File Offset: 0x0000CAE8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return StorageMetrics.Builder._members;
				}
			}

			// Token: 0x17000188 RID: 392
			// (get) Token: 0x060004AB RID: 1195 RVA: 0x0000E8F0 File Offset: 0x0000CAF0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return StorageMetrics.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000189 RID: 393
			// (get) Token: 0x060004AC RID: 1196 RVA: 0x0000E914 File Offset: 0x0000CB14
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return StorageMetrics.Builder._members.ManagedPeerType;
				}
			}

			// Token: 0x060004AD RID: 1197 RVA: 0x000026C4 File Offset: 0x000008C4
			internal Builder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060004AE RID: 1198 RVA: 0x0000E920 File Offset: 0x0000CB20
			[Register("build", "()Lcom/google/android/datatransport/runtime/firebase/transport/StorageMetrics;", "")]
			public StorageMetrics Build()
			{
				return Java.Lang.Object.GetObject<StorageMetrics>(StorageMetrics.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("build.()Lcom/google/android/datatransport/runtime/firebase/transport/StorageMetrics;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060004AF RID: 1199 RVA: 0x0000E954 File Offset: 0x0000CB54
			[Register("setCurrentCacheSizeBytes", "(J)Lcom/google/android/datatransport/runtime/firebase/transport/StorageMetrics$Builder;", "")]
			public unsafe StorageMetrics.Builder SetCurrentCacheSizeBytes(long current_cache_size_bytes_)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(current_cache_size_bytes_);
				return Java.Lang.Object.GetObject<StorageMetrics.Builder>(StorageMetrics.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setCurrentCacheSizeBytes.(J)Lcom/google/android/datatransport/runtime/firebase/transport/StorageMetrics$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060004B0 RID: 1200 RVA: 0x0000E9A0 File Offset: 0x0000CBA0
			[Register("setMaxCacheSizeBytes", "(J)Lcom/google/android/datatransport/runtime/firebase/transport/StorageMetrics$Builder;", "")]
			public unsafe StorageMetrics.Builder SetMaxCacheSizeBytes(long max_cache_size_bytes_)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(max_cache_size_bytes_);
				return Java.Lang.Object.GetObject<StorageMetrics.Builder>(StorageMetrics.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setMaxCacheSizeBytes.(J)Lcom/google/android/datatransport/runtime/firebase/transport/StorageMetrics$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x04000104 RID: 260
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/firebase/transport/StorageMetrics$Builder", typeof(StorageMetrics.Builder));
		}
	}
}
