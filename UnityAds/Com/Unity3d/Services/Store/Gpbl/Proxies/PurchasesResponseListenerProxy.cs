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
	// Token: 0x0200004F RID: 79
	[Register("com/unity3d/services/store/gpbl/proxies/PurchasesResponseListenerProxy", DoNotGenerateAcw = true)]
	public class PurchasesResponseListenerProxy : GenericListenerProxy
	{
		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001CD RID: 461 RVA: 0x00005000 File Offset: 0x00003200
		internal new static IntPtr class_ref
		{
			get
			{
				return PurchasesResponseListenerProxy._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001CE RID: 462 RVA: 0x00005024 File Offset: 0x00003224
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PurchasesResponseListenerProxy._members;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001CF RID: 463 RVA: 0x0000502C File Offset: 0x0000322C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return PurchasesResponseListenerProxy._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x00005050 File Offset: 0x00003250
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PurchasesResponseListenerProxy._members.ManagedPeerType;
			}
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00004BCC File Offset: 0x00002DCC
		protected PurchasesResponseListenerProxy(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x0000505C File Offset: 0x0000325C
		[Register(".ctor", "(Lcom/unity3d/services/store/listeners/IPurchasesResponseListener;)V", "")]
		public unsafe PurchasesResponseListenerProxy(IPurchasesResponseListener purchasesResponseListener) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((purchasesResponseListener == null) ? IntPtr.Zero : ((Java.Lang.Object)purchasesResponseListener).Handle);
				base.SetHandle(PurchasesResponseListenerProxy._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/services/store/listeners/IPurchasesResponseListener;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				PurchasesResponseListenerProxy._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/services/store/listeners/IPurchasesResponseListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(purchasesResponseListener);
			}
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00005110 File Offset: 0x00003310
		private static Delegate GetGetProxyClassHandler()
		{
			if (PurchasesResponseListenerProxy.cb_getProxyClass == null)
			{
				PurchasesResponseListenerProxy.cb_getProxyClass = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(PurchasesResponseListenerProxy.n_GetProxyClass));
			}
			return PurchasesResponseListenerProxy.cb_getProxyClass;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00005134 File Offset: 0x00003334
		private static IntPtr n_GetProxyClass(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<PurchasesResponseListenerProxy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ProxyClass);
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x00005148 File Offset: 0x00003348
		public override Class ProxyClass
		{
			[Register("getProxyClass", "()Ljava/lang/Class;", "GetGetProxyClassHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Class>(PurchasesResponseListenerProxy._members.InstanceMethods.InvokeVirtualObjectMethod("getProxyClass.()Ljava/lang/Class;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x0000517C File Offset: 0x0000337C
		public static Class ProxyListenerClass
		{
			[Register("getProxyListenerClass", "()Ljava/lang/Class;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Class>(PurchasesResponseListenerProxy._members.StaticMethods.InvokeObjectMethod("getProxyListenerClass.()Ljava/lang/Class;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x000051AD File Offset: 0x000033AD
		private static Delegate GetGetPurchasesResponseListenerHandler()
		{
			if (PurchasesResponseListenerProxy.cb_getPurchasesResponseListener == null)
			{
				PurchasesResponseListenerProxy.cb_getPurchasesResponseListener = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(PurchasesResponseListenerProxy.n_GetPurchasesResponseListener));
			}
			return PurchasesResponseListenerProxy.cb_getPurchasesResponseListener;
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x000051D1 File Offset: 0x000033D1
		private static IntPtr n_GetPurchasesResponseListener(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<PurchasesResponseListenerProxy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PurchasesResponseListener);
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x000051E8 File Offset: 0x000033E8
		public virtual IPurchasesResponseListener PurchasesResponseListener
		{
			[Register("getPurchasesResponseListener", "()Lcom/unity3d/services/store/listeners/IPurchasesResponseListener;", "GetGetPurchasesResponseListenerHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IPurchasesResponseListener>(PurchasesResponseListenerProxy._members.InstanceMethods.InvokeVirtualObjectMethod("getPurchasesResponseListener.()Lcom/unity3d/services/store/listeners/IPurchasesResponseListener;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060001DA RID: 474 RVA: 0x0000521A File Offset: 0x0000341A
		private static Delegate GetOnQueryPurchasesResponse_Ljava_lang_Object_Ljava_util_List_Handler()
		{
			if (PurchasesResponseListenerProxy.cb_onQueryPurchasesResponse_Ljava_lang_Object_Ljava_util_List_ == null)
			{
				PurchasesResponseListenerProxy.cb_onQueryPurchasesResponse_Ljava_lang_Object_Ljava_util_List_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(PurchasesResponseListenerProxy.n_OnQueryPurchasesResponse_Ljava_lang_Object_Ljava_util_List_));
			}
			return PurchasesResponseListenerProxy.cb_onQueryPurchasesResponse_Ljava_lang_Object_Ljava_util_List_;
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00005240 File Offset: 0x00003440
		private static void n_OnQueryPurchasesResponse_Ljava_lang_Object_Ljava_util_List_(IntPtr jnienv, IntPtr native__this, IntPtr native_billingResult, IntPtr native_purchases)
		{
			PurchasesResponseListenerProxy @object = Java.Lang.Object.GetObject<PurchasesResponseListenerProxy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_billingResult, JniHandleOwnership.DoNotTransfer);
			IList<Java.Lang.Object> purchases = JavaList<Java.Lang.Object>.FromJniHandle(native_purchases, JniHandleOwnership.DoNotTransfer);
			@object.OnQueryPurchasesResponse(object2, purchases);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0000526C File Offset: 0x0000346C
		[Register("onQueryPurchasesResponse", "(Ljava/lang/Object;Ljava/util/List;)V", "GetOnQueryPurchasesResponse_Ljava_lang_Object_Ljava_util_List_Handler")]
		public unsafe virtual void OnQueryPurchasesResponse(Java.Lang.Object billingResult, IList<Java.Lang.Object> purchases)
		{
			IntPtr intPtr = JavaList<Java.Lang.Object>.ToLocalJniHandle(purchases);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((billingResult == null) ? IntPtr.Zero : billingResult.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				PurchasesResponseListenerProxy._members.InstanceMethods.InvokeVirtualVoidMethod("onQueryPurchasesResponse.(Ljava/lang/Object;Ljava/util/List;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(billingResult);
				GC.KeepAlive(purchases);
			}
		}

		// Token: 0x0400003F RID: 63
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/store/gpbl/proxies/PurchasesResponseListenerProxy", typeof(PurchasesResponseListenerProxy));

		// Token: 0x04000040 RID: 64
		private static Delegate cb_getProxyClass;

		// Token: 0x04000041 RID: 65
		private static Delegate cb_getPurchasesResponseListener;

		// Token: 0x04000042 RID: 66
		private static Delegate cb_onQueryPurchasesResponse_Ljava_lang_Object_Ljava_util_List_;
	}
}
