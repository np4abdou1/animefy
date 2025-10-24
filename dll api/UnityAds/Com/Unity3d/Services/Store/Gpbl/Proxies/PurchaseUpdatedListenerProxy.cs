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
	// Token: 0x02000050 RID: 80
	[Register("com/unity3d/services/store/gpbl/proxies/PurchaseUpdatedListenerProxy", DoNotGenerateAcw = true)]
	public class PurchaseUpdatedListenerProxy : GenericListenerProxy
	{
		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001DE RID: 478 RVA: 0x00005314 File Offset: 0x00003514
		internal new static IntPtr class_ref
		{
			get
			{
				return PurchaseUpdatedListenerProxy._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001DF RID: 479 RVA: 0x00005338 File Offset: 0x00003538
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PurchaseUpdatedListenerProxy._members;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x00005340 File Offset: 0x00003540
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return PurchaseUpdatedListenerProxy._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x00005364 File Offset: 0x00003564
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PurchaseUpdatedListenerProxy._members.ManagedPeerType;
			}
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00004BCC File Offset: 0x00002DCC
		protected PurchaseUpdatedListenerProxy(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00005370 File Offset: 0x00003570
		[Register(".ctor", "(Lcom/unity3d/services/store/listeners/IPurchaseUpdatedResponseListener;)V", "")]
		public unsafe PurchaseUpdatedListenerProxy(IPurchaseUpdatedResponseListener purchaseUpdatedResponseListener) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((purchaseUpdatedResponseListener == null) ? IntPtr.Zero : ((Java.Lang.Object)purchaseUpdatedResponseListener).Handle);
				base.SetHandle(PurchaseUpdatedListenerProxy._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/services/store/listeners/IPurchaseUpdatedResponseListener;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				PurchaseUpdatedListenerProxy._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/services/store/listeners/IPurchaseUpdatedResponseListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(purchaseUpdatedResponseListener);
			}
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00005424 File Offset: 0x00003624
		private static Delegate GetGetProxyClassHandler()
		{
			if (PurchaseUpdatedListenerProxy.cb_getProxyClass == null)
			{
				PurchaseUpdatedListenerProxy.cb_getProxyClass = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(PurchaseUpdatedListenerProxy.n_GetProxyClass));
			}
			return PurchaseUpdatedListenerProxy.cb_getProxyClass;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00005448 File Offset: 0x00003648
		private static IntPtr n_GetProxyClass(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<PurchaseUpdatedListenerProxy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ProxyClass);
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x0000545C File Offset: 0x0000365C
		public override Class ProxyClass
		{
			[Register("getProxyClass", "()Ljava/lang/Class;", "GetGetProxyClassHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Class>(PurchaseUpdatedListenerProxy._members.InstanceMethods.InvokeVirtualObjectMethod("getProxyClass.()Ljava/lang/Class;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x00005490 File Offset: 0x00003690
		public static Class ProxyListenerClass
		{
			[Register("getProxyListenerClass", "()Ljava/lang/Class;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Class>(PurchaseUpdatedListenerProxy._members.StaticMethods.InvokeObjectMethod("getProxyListenerClass.()Ljava/lang/Class;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x000054C1 File Offset: 0x000036C1
		private static Delegate GetOnPurchasesUpdated_Ljava_lang_Object_Ljava_util_List_Handler()
		{
			if (PurchaseUpdatedListenerProxy.cb_onPurchasesUpdated_Ljava_lang_Object_Ljava_util_List_ == null)
			{
				PurchaseUpdatedListenerProxy.cb_onPurchasesUpdated_Ljava_lang_Object_Ljava_util_List_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(PurchaseUpdatedListenerProxy.n_OnPurchasesUpdated_Ljava_lang_Object_Ljava_util_List_));
			}
			return PurchaseUpdatedListenerProxy.cb_onPurchasesUpdated_Ljava_lang_Object_Ljava_util_List_;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x000054E8 File Offset: 0x000036E8
		private static void n_OnPurchasesUpdated_Ljava_lang_Object_Ljava_util_List_(IntPtr jnienv, IntPtr native__this, IntPtr native_billingResult, IntPtr native_purchases)
		{
			PurchaseUpdatedListenerProxy @object = Java.Lang.Object.GetObject<PurchaseUpdatedListenerProxy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_billingResult, JniHandleOwnership.DoNotTransfer);
			IList<Java.Lang.Object> purchases = JavaList<Java.Lang.Object>.FromJniHandle(native_purchases, JniHandleOwnership.DoNotTransfer);
			@object.OnPurchasesUpdated(object2, purchases);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00005514 File Offset: 0x00003714
		[Register("onPurchasesUpdated", "(Ljava/lang/Object;Ljava/util/List;)V", "GetOnPurchasesUpdated_Ljava_lang_Object_Ljava_util_List_Handler")]
		public unsafe virtual void OnPurchasesUpdated(Java.Lang.Object billingResult, IList<Java.Lang.Object> purchases)
		{
			IntPtr intPtr = JavaList<Java.Lang.Object>.ToLocalJniHandle(purchases);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((billingResult == null) ? IntPtr.Zero : billingResult.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				PurchaseUpdatedListenerProxy._members.InstanceMethods.InvokeVirtualVoidMethod("onPurchasesUpdated.(Ljava/lang/Object;Ljava/util/List;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(billingResult);
				GC.KeepAlive(purchases);
			}
		}

		// Token: 0x04000043 RID: 67
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/store/gpbl/proxies/PurchaseUpdatedListenerProxy", typeof(PurchaseUpdatedListenerProxy));

		// Token: 0x04000044 RID: 68
		private static Delegate cb_getProxyClass;

		// Token: 0x04000045 RID: 69
		private static Delegate cb_onPurchasesUpdated_Ljava_lang_Object_Ljava_util_List_;
	}
}
