using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Store.Gpbl.Bridges.Billingclient.Common
{
	// Token: 0x02000067 RID: 103
	[Register("com/unity3d/services/store/gpbl/bridges/billingclient/common/BillingClientBuilderBridgeCommon", DoNotGenerateAcw = true)]
	internal class BillingClientBuilderBridgeCommonInvoker : BillingClientBuilderBridgeCommon
	{
		// Token: 0x06000315 RID: 789 RVA: 0x00007878 File Offset: 0x00005A78
		public BillingClientBuilderBridgeCommonInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000316 RID: 790 RVA: 0x000088EF File Offset: 0x00006AEF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BillingClientBuilderBridgeCommonInvoker._members;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000317 RID: 791 RVA: 0x000088F6 File Offset: 0x00006AF6
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BillingClientBuilderBridgeCommonInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00008904 File Offset: 0x00006B04
		[Register("build", "()Lcom/unity3d/services/store/gpbl/bridges/billingclient/IBillingClient;", "GetBuildHandler")]
		public override IBillingClient Build()
		{
			return Java.Lang.Object.GetObject<IBillingClient>(BillingClientBuilderBridgeCommonInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("build.()Lcom/unity3d/services/store/gpbl/bridges/billingclient/IBillingClient;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000099 RID: 153
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/store/gpbl/bridges/billingclient/common/BillingClientBuilderBridgeCommon", typeof(BillingClientBuilderBridgeCommonInvoker));
	}
}
