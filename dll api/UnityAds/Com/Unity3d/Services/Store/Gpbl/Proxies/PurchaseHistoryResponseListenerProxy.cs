using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Reflection;
using Com.Unity3d.Services.Store.Listeners;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Store.Gpbl.Proxies
{
	// Token: 0x0200004E RID: 78
	[Register("com/unity3d/services/store/gpbl/proxies/PurchaseHistoryResponseListenerProxy", DoNotGenerateAcw = true)]
	public class PurchaseHistoryResponseListenerProxy : GenericListenerProxy
	{
		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001BF RID: 447 RVA: 0x00004D44 File Offset: 0x00002F44
		internal new static IntPtr class_ref
		{
			get
			{
				return PurchaseHistoryResponseListenerProxy._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x00004D68 File Offset: 0x00002F68
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PurchaseHistoryResponseListenerProxy._members;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x00004D70 File Offset: 0x00002F70
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return PurchaseHistoryResponseListenerProxy._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x00004D94 File Offset: 0x00002F94
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PurchaseHistoryResponseListenerProxy._members.ManagedPeerType;
			}
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00004BCC File Offset: 0x00002DCC
		protected PurchaseHistoryResponseListenerProxy(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00004DA0 File Offset: 0x00002FA0
		[Register(".ctor", "(Lcom/unity3d/services/store/listeners/IPurchaseHistoryResponseListener;I)V", "")]
		public unsafe PurchaseHistoryResponseListenerProxy(IPurchaseHistoryResponseListener purchaseHistoryResponseListener, int maxPurchases) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((purchaseHistoryResponseListener == null) ? IntPtr.Zero : ((Java.Lang.Object)purchaseHistoryResponseListener).Handle);
				ptr[1] = new JniArgumentValue(maxPurchases);
				base.SetHandle(PurchaseHistoryResponseListenerProxy._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/services/store/listeners/IPurchaseHistoryResponseListener;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				PurchaseHistoryResponseListenerProxy._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/services/store/listeners/IPurchaseHistoryResponseListener;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(purchaseHistoryResponseListener);
			}
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00004E68 File Offset: 0x00003068
		private static Delegate GetGetProxyClassHandler()
		{
			if (PurchaseHistoryResponseListenerProxy.cb_getProxyClass == null)
			{
				PurchaseHistoryResponseListenerProxy.cb_getProxyClass = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(PurchaseHistoryResponseListenerProxy.n_GetProxyClass));
			}
			return PurchaseHistoryResponseListenerProxy.cb_getProxyClass;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00004E8C File Offset: 0x0000308C
		private static IntPtr n_GetProxyClass(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<PurchaseHistoryResponseListenerProxy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ProxyClass);
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x00004EA0 File Offset: 0x000030A0
		public override Class ProxyClass
		{
			[Register("getProxyClass", "()Ljava/lang/Class;", "GetGetProxyClassHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Class>(PurchaseHistoryResponseListenerProxy._members.InstanceMethods.InvokeVirtualObjectMethod("getProxyClass.()Ljava/lang/Class;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x00004ED4 File Offset: 0x000030D4
		public static Class ProxyListenerClass
		{
			[Register("getProxyListenerClass", "()Ljava/lang/Class;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Class>(PurchaseHistoryResponseListenerProxy._members.StaticMethods.InvokeObjectMethod("getProxyListenerClass.()Ljava/lang/Class;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00004F05 File Offset: 0x00003105
		private static Delegate GetOnPurchaseHistoryResponse_Ljava_lang_Object_Ljava_util_List_Handler()
		{
			if (PurchaseHistoryResponseListenerProxy.cb_onPurchaseHistoryResponse_Ljava_lang_Object_Ljava_util_List_ == null)
			{
				PurchaseHistoryResponseListenerProxy.cb_onPurchaseHistoryResponse_Ljava_lang_Object_Ljava_util_List_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(PurchaseHistoryResponseListenerProxy.n_OnPurchaseHistoryResponse_Ljava_lang_Object_Ljava_util_List_));
			}
			return PurchaseHistoryResponseListenerProxy.cb_onPurchaseHistoryResponse_Ljava_lang_Object_Ljava_util_List_;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00004F2C File Offset: 0x0000312C
		private static void n_OnPurchaseHistoryResponse_Ljava_lang_Object_Ljava_util_List_(IntPtr jnienv, IntPtr native__this, IntPtr native_billingResult, IntPtr native_purchaseHistoryRecordList)
		{
			PurchaseHistoryResponseListenerProxy @object = Java.Lang.Object.GetObject<PurchaseHistoryResponseListenerProxy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_billingResult, JniHandleOwnership.DoNotTransfer);
			IList<Java.Lang.Object> purchaseHistoryRecordList = JavaList<Java.Lang.Object>.FromJniHandle(native_purchaseHistoryRecordList, JniHandleOwnership.DoNotTransfer);
			@object.OnPurchaseHistoryResponse(object2, purchaseHistoryRecordList);
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00004F58 File Offset: 0x00003158
		[Register("onPurchaseHistoryResponse", "(Ljava/lang/Object;Ljava/util/List;)V", "GetOnPurchaseHistoryResponse_Ljava_lang_Object_Ljava_util_List_Handler")]
		public unsafe virtual void OnPurchaseHistoryResponse(Java.Lang.Object billingResult, IList<Java.Lang.Object> purchaseHistoryRecordList)
		{
			IntPtr intPtr = JavaList<Java.Lang.Object>.ToLocalJniHandle(purchaseHistoryRecordList);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((billingResult == null) ? IntPtr.Zero : billingResult.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				PurchaseHistoryResponseListenerProxy._members.InstanceMethods.InvokeVirtualVoidMethod("onPurchaseHistoryResponse.(Ljava/lang/Object;Ljava/util/List;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(billingResult);
				GC.KeepAlive(purchaseHistoryRecordList);
			}
		}

		// Token: 0x0400003C RID: 60
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/store/gpbl/proxies/PurchaseHistoryResponseListenerProxy", typeof(PurchaseHistoryResponseListenerProxy));

		// Token: 0x0400003D RID: 61
		private static Delegate cb_getProxyClass;

		// Token: 0x0400003E RID: 62
		private static Delegate cb_onPurchaseHistoryResponse_Ljava_lang_Object_Ljava_util_List_;
	}
}
