using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime
{
	// Token: 0x0200001F RID: 31
	[Register("com/google/android/datatransport/runtime/EventInternal", DoNotGenerateAcw = true)]
	internal class EventInternalInvoker : EventInternal
	{
		// Token: 0x060000CC RID: 204 RVA: 0x000035EC File Offset: 0x000017EC
		public EventInternalInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000CD RID: 205 RVA: 0x000035F6 File Offset: 0x000017F6
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return EventInternalInvoker._members;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000CE RID: 206 RVA: 0x000035FD File Offset: 0x000017FD
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return EventInternalInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000CF RID: 207 RVA: 0x0000360C File Offset: 0x0000180C
		protected override IDictionary<string, string> AutoMetadata
		{
			[Register("getAutoMetadata", "()Ljava/util/Map;", "GetGetAutoMetadataHandler")]
			get
			{
				return JavaDictionary<string, string>.FromJniHandle(EventInternalInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getAutoMetadata.()Ljava/util/Map;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00003640 File Offset: 0x00001840
		public override Integer Code
		{
			[Register("getCode", "()Ljava/lang/Integer;", "GetGetCodeHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Integer>(EventInternalInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getCode.()Ljava/lang/Integer;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00003674 File Offset: 0x00001874
		public override EncodedPayload EncodedPayload
		{
			[Register("getEncodedPayload", "()Lcom/google/android/datatransport/runtime/EncodedPayload;", "GetGetEncodedPayloadHandler")]
			get
			{
				return Java.Lang.Object.GetObject<EncodedPayload>(EventInternalInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getEncodedPayload.()Lcom/google/android/datatransport/runtime/EncodedPayload;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x000036A6 File Offset: 0x000018A6
		public override long EventMillis
		{
			[Register("getEventMillis", "()J", "GetGetEventMillisHandler")]
			get
			{
				return EventInternalInvoker._members.InstanceMethods.InvokeAbstractInt64Method("getEventMillis.()J", this, null);
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x000036C0 File Offset: 0x000018C0
		public override string TransportName
		{
			[Register("getTransportName", "()Ljava/lang/String;", "GetGetTransportNameHandler")]
			get
			{
				return JNIEnv.GetString(EventInternalInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getTransportName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x000036F2 File Offset: 0x000018F2
		public override long UptimeMillis
		{
			[Register("getUptimeMillis", "()J", "GetGetUptimeMillisHandler")]
			get
			{
				return EventInternalInvoker._members.InstanceMethods.InvokeAbstractInt64Method("getUptimeMillis.()J", this, null);
			}
		}

		// Token: 0x04000026 RID: 38
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/EventInternal", typeof(EventInternalInvoker));
	}
}
