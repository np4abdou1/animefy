using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Xamarin.Google.Android.DataTransport.Cct.Internal
{
	// Token: 0x02000010 RID: 16
	[Register("com/google/android/datatransport/cct/internal/BatchedLogRequest", DoNotGenerateAcw = true)]
	internal class BatchedLogRequestInvoker : BatchedLogRequest
	{
		// Token: 0x060000BE RID: 190 RVA: 0x000038B4 File Offset: 0x00001AB4
		public BatchedLogRequestInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000BF RID: 191 RVA: 0x000038BE File Offset: 0x00001ABE
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BatchedLogRequestInvoker._members;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x000038C5 File Offset: 0x00001AC5
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BatchedLogRequestInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x000038D4 File Offset: 0x00001AD4
		public override IList<LogRequest> LogRequests
		{
			[Register("getLogRequests", "()Ljava/util/List;", "GetGetLogRequestsHandler")]
			get
			{
				return JavaList<LogRequest>.FromJniHandle(BatchedLogRequestInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getLogRequests.()Ljava/util/List;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x04000024 RID: 36
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/cct/internal/BatchedLogRequest", typeof(BatchedLogRequestInvoker));
	}
}
