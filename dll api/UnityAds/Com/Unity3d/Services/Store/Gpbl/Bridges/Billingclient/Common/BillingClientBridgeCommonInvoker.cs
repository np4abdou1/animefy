using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Store.Gpbl.Proxies;
using Java.Interop;

namespace Com.Unity3d.Services.Store.Gpbl.Bridges.Billingclient.Common
{
	// Token: 0x02000065 RID: 101
	[Register("com/unity3d/services/store/gpbl/bridges/billingclient/common/BillingClientBridgeCommon", DoNotGenerateAcw = true)]
	internal class BillingClientBridgeCommonInvoker : BillingClientBridgeCommon
	{
		// Token: 0x060002FB RID: 763 RVA: 0x000075E4 File Offset: 0x000057E4
		public BillingClientBridgeCommonInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060002FC RID: 764 RVA: 0x000084C7 File Offset: 0x000066C7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BillingClientBridgeCommonInvoker._members;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060002FD RID: 765 RVA: 0x000084CE File Offset: 0x000066CE
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BillingClientBridgeCommonInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060002FE RID: 766 RVA: 0x000084DC File Offset: 0x000066DC
		[Register("queryPurchasesAsync", "(Ljava/lang/String;Lcom/unity3d/services/store/gpbl/proxies/PurchasesResponseListenerProxy;)V", "GetQueryPurchasesAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchasesResponseListenerProxy_Handler")]
		public unsafe override void QueryPurchasesAsync(string p0, PurchasesResponseListenerProxy p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				BillingClientBridgeCommonInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("queryPurchasesAsync.(Ljava/lang/String;Lcom/unity3d/services/store/gpbl/proxies/PurchasesResponseListenerProxy;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x04000092 RID: 146
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/store/gpbl/bridges/billingclient/common/BillingClientBridgeCommon", typeof(BillingClientBridgeCommonInvoker));
	}
}
