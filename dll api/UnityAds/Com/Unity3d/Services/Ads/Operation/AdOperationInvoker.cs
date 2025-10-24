using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Services.Ads.Operation
{
	// Token: 0x020001E7 RID: 487
	[Register("com/unity3d/services/ads/operation/AdOperation", DoNotGenerateAcw = true)]
	internal class AdOperationInvoker : AdOperation
	{
		// Token: 0x0600162F RID: 5679 RVA: 0x0003FA1B File Offset: 0x0003DC1B
		public AdOperationInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x06001630 RID: 5680 RVA: 0x0003FA25 File Offset: 0x0003DC25
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdOperationInvoker._members;
			}
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x06001631 RID: 5681 RVA: 0x0003FA2C File Offset: 0x0003DC2C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdOperationInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x06001632 RID: 5682 RVA: 0x0003FA38 File Offset: 0x0003DC38
		public override string Id
		{
			[Register("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get
			{
				return JNIEnv.GetString(AdOperationInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getId.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0400053E RID: 1342
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/operation/AdOperation", typeof(AdOperationInvoker));
	}
}
