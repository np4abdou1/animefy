using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Backends
{
	// Token: 0x0200008B RID: 139
	[Register("com/google/android/datatransport/runtime/backends/BackendResponse", DoNotGenerateAcw = true)]
	internal class BackendResponseInvoker : BackendResponse
	{
		// Token: 0x06000519 RID: 1305 RVA: 0x0000F76B File Offset: 0x0000D96B
		public BackendResponseInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x0600051A RID: 1306 RVA: 0x0000F775 File Offset: 0x0000D975
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BackendResponseInvoker._members;
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x0600051B RID: 1307 RVA: 0x0000F77C File Offset: 0x0000D97C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BackendResponseInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x0600051C RID: 1308 RVA: 0x0000F788 File Offset: 0x0000D988
		public override long NextRequestWaitMillis
		{
			[Register("getNextRequestWaitMillis", "()J", "GetGetNextRequestWaitMillisHandler")]
			get
			{
				return BackendResponseInvoker._members.InstanceMethods.InvokeAbstractInt64Method("getNextRequestWaitMillis.()J", this, null);
			}
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x0000F7A4 File Offset: 0x0000D9A4
		[Register("getStatus", "()Lcom/google/android/datatransport/runtime/backends/BackendResponse$Status;", "GetGetStatusHandler")]
		public override BackendResponse.Status GetStatus()
		{
			return Java.Lang.Object.GetObject<BackendResponse.Status>(BackendResponseInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getStatus.()Lcom/google/android/datatransport/runtime/backends/BackendResponse$Status;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000116 RID: 278
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/backends/BackendResponse", typeof(BackendResponseInvoker));
	}
}
