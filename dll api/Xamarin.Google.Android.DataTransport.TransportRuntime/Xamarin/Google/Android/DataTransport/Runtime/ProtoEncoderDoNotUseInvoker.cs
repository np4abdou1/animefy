using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Xamarin.Google.Android.DataTransport.Runtime.Firebase.Transport;

namespace Xamarin.Google.Android.DataTransport.Runtime
{
	// Token: 0x02000027 RID: 39
	[Register("com/google/android/datatransport/runtime/ProtoEncoderDoNotUse", DoNotGenerateAcw = true)]
	internal class ProtoEncoderDoNotUseInvoker : ProtoEncoderDoNotUse
	{
		// Token: 0x06000116 RID: 278 RVA: 0x00004033 File Offset: 0x00002233
		public ProtoEncoderDoNotUseInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000117 RID: 279 RVA: 0x0000403D File Offset: 0x0000223D
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ProtoEncoderDoNotUseInvoker._members;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000118 RID: 280 RVA: 0x00004044 File Offset: 0x00002244
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ProtoEncoderDoNotUseInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000119 RID: 281 RVA: 0x00004050 File Offset: 0x00002250
		public override ClientMetrics ClientMetrics
		{
			[Register("getClientMetrics", "()Lcom/google/android/datatransport/runtime/firebase/transport/ClientMetrics;", "GetGetClientMetricsHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ClientMetrics>(ProtoEncoderDoNotUseInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getClientMetrics.()Lcom/google/android/datatransport/runtime/firebase/transport/ClientMetrics;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x04000039 RID: 57
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/ProtoEncoderDoNotUse", typeof(ProtoEncoderDoNotUseInvoker));
	}
}
