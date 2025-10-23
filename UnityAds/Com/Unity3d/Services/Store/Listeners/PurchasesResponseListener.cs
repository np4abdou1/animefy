using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Store.Gpbl.Bridges;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Store.Listeners
{
	// Token: 0x02000044 RID: 68
	[Register("com/unity3d/services/store/listeners/PurchasesResponseListener", DoNotGenerateAcw = true)]
	public class PurchasesResponseListener : Java.Lang.Object, IPurchasesResponseListener, IBillingDataResponseListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000158 RID: 344 RVA: 0x00003A94 File Offset: 0x00001C94
		internal static IntPtr class_ref
		{
			get
			{
				return PurchasesResponseListener._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000159 RID: 345 RVA: 0x00003AB8 File Offset: 0x00001CB8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PurchasesResponseListener._members;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600015A RID: 346 RVA: 0x00003AC0 File Offset: 0x00001CC0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return PurchasesResponseListener._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600015B RID: 347 RVA: 0x00003AE4 File Offset: 0x00001CE4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PurchasesResponseListener._members.ManagedPeerType;
			}
		}

		// Token: 0x0600015C RID: 348 RVA: 0x000021E8 File Offset: 0x000003E8
		protected PurchasesResponseListener(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00003AF0 File Offset: 0x00001CF0
		[Register(".ctor", "(Lcom/unity3d/services/store/StoreEvent;Lcom/unity3d/services/store/StoreEvent;)V", "")]
		public unsafe PurchasesResponseListener(StoreEvent successEvent, StoreEvent errorEvent) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((successEvent == null) ? IntPtr.Zero : successEvent.Handle);
				ptr[1] = new JniArgumentValue((errorEvent == null) ? IntPtr.Zero : errorEvent.Handle);
				base.SetHandle(PurchasesResponseListener._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/services/store/StoreEvent;Lcom/unity3d/services/store/StoreEvent;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				PurchasesResponseListener._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/services/store/StoreEvent;Lcom/unity3d/services/store/StoreEvent;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(successEvent);
				GC.KeepAlive(errorEvent);
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00003BC8 File Offset: 0x00001DC8
		[Register(".ctor", "(Ljava/lang/Integer;Lcom/unity3d/services/store/StoreEvent;Lcom/unity3d/services/store/StoreEvent;)V", "")]
		public unsafe PurchasesResponseListener(Integer operationId, StoreEvent successEvent, StoreEvent errorEvent) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((operationId == null) ? IntPtr.Zero : operationId.Handle);
				ptr[1] = new JniArgumentValue((successEvent == null) ? IntPtr.Zero : successEvent.Handle);
				ptr[2] = new JniArgumentValue((errorEvent == null) ? IntPtr.Zero : errorEvent.Handle);
				base.SetHandle(PurchasesResponseListener._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Integer;Lcom/unity3d/services/store/StoreEvent;Lcom/unity3d/services/store/StoreEvent;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				PurchasesResponseListener._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Integer;Lcom/unity3d/services/store/StoreEvent;Lcom/unity3d/services/store/StoreEvent;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(operationId);
				GC.KeepAlive(successEvent);
				GC.KeepAlive(errorEvent);
			}
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00003CC8 File Offset: 0x00001EC8
		private static Delegate GetOnBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_Handler()
		{
			if (PurchasesResponseListener.cb_onBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_ == null)
			{
				PurchasesResponseListener.cb_onBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(PurchasesResponseListener.n_OnBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_));
			}
			return PurchasesResponseListener.cb_onBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00003CEC File Offset: 0x00001EEC
		private static void n_OnBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_(IntPtr jnienv, IntPtr native__this, IntPtr native_billingResult, IntPtr native_purchases)
		{
			PurchasesResponseListener @object = Java.Lang.Object.GetObject<PurchasesResponseListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			BillingResultBridge object2 = Java.Lang.Object.GetObject<BillingResultBridge>(native_billingResult, JniHandleOwnership.DoNotTransfer);
			IList<PurchaseBridge> purchases = JavaList<PurchaseBridge>.FromJniHandle(native_purchases, JniHandleOwnership.DoNotTransfer);
			@object.OnBillingResponse(object2, purchases);
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00003D18 File Offset: 0x00001F18
		[Register("onBillingResponse", "(Lcom/unity3d/services/store/gpbl/bridges/BillingResultBridge;Ljava/util/List;)V", "GetOnBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_Handler")]
		public unsafe virtual void OnBillingResponse(BillingResultBridge billingResult, IList<PurchaseBridge> purchases)
		{
			IntPtr intPtr = JavaList<PurchaseBridge>.ToLocalJniHandle(purchases);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((billingResult == null) ? IntPtr.Zero : billingResult.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				PurchasesResponseListener._members.InstanceMethods.InvokeVirtualVoidMethod("onBillingResponse.(Lcom/unity3d/services/store/gpbl/bridges/BillingResultBridge;Ljava/util/List;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(billingResult);
				GC.KeepAlive(purchases);
			}
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00002226 File Offset: 0x00000426
		public void OnBillingResponse(BillingResultBridge p0, IList p1)
		{
			throw new NotImplementedException();
		}

		// Token: 0x04000023 RID: 35
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/store/listeners/PurchasesResponseListener", typeof(PurchasesResponseListener));

		// Token: 0x04000024 RID: 36
		private static Delegate cb_onBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_;
	}
}
