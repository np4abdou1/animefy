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
	// Token: 0x02000041 RID: 65
	[Register("com/unity3d/services/store/listeners/IPurchaseUpdatedResponseListener", DoNotGenerateAcw = true)]
	internal class IPurchaseUpdatedResponseListenerInvoker : Java.Lang.Object, IPurchaseUpdatedResponseListener, IBillingDataResponseListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600013D RID: 317 RVA: 0x000036DC File Offset: 0x000018DC
		private static IntPtr java_class_ref
		{
			get
			{
				return IPurchaseUpdatedResponseListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600013E RID: 318 RVA: 0x00003700 File Offset: 0x00001900
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IPurchaseUpdatedResponseListenerInvoker._members;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00003707 File Offset: 0x00001907
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000140 RID: 320 RVA: 0x0000370F File Offset: 0x0000190F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IPurchaseUpdatedResponseListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000141 RID: 321 RVA: 0x0000371B File Offset: 0x0000191B
		public static IPurchaseUpdatedResponseListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IPurchaseUpdatedResponseListener>(handle, transfer);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00003724 File Offset: 0x00001924
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IPurchaseUpdatedResponseListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.store.listeners.IPurchaseUpdatedResponseListener'.");
			}
			return handle;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x0000374F File Offset: 0x0000194F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00003780 File Offset: 0x00001980
		public IPurchaseUpdatedResponseListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IPurchaseUpdatedResponseListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x000037B8 File Offset: 0x000019B8
		private static Delegate GetOnBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_Handler()
		{
			if (IPurchaseUpdatedResponseListenerInvoker.cb_onBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_ == null)
			{
				IPurchaseUpdatedResponseListenerInvoker.cb_onBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IPurchaseUpdatedResponseListenerInvoker.n_OnBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_));
			}
			return IPurchaseUpdatedResponseListenerInvoker.cb_onBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_;
		}

		// Token: 0x06000146 RID: 326 RVA: 0x000037DC File Offset: 0x000019DC
		private static void n_OnBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IPurchaseUpdatedResponseListener @object = Java.Lang.Object.GetObject<IPurchaseUpdatedResponseListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			BillingResultBridge object2 = Java.Lang.Object.GetObject<BillingResultBridge>(native_p0, JniHandleOwnership.DoNotTransfer);
			IList<PurchaseBridge> p = JavaList<PurchaseBridge>.FromJniHandle(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.OnBillingResponse(object2, p);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00003808 File Offset: 0x00001A08
		public unsafe void OnBillingResponse(BillingResultBridge p0, IList<PurchaseBridge> p1)
		{
			if (this.id_onBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_ == IntPtr.Zero)
			{
				this.id_onBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_ = JNIEnv.GetMethodID(this.class_ref, "onBillingResponse", "(Lcom/unity3d/services/store/gpbl/bridges/BillingResultBridge;Ljava/util/List;)V");
			}
			IntPtr intPtr = JavaList<PurchaseBridge>.ToLocalJniHandle(p1);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00002226 File Offset: 0x00000426
		public void OnBillingResponse(BillingResultBridge p0, IList p1)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0400001B RID: 27
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/store/listeners/IPurchaseUpdatedResponseListener", typeof(IPurchaseUpdatedResponseListenerInvoker));

		// Token: 0x0400001C RID: 28
		private IntPtr class_ref;

		// Token: 0x0400001D RID: 29
		private static Delegate cb_onBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_;

		// Token: 0x0400001E RID: 30
		private IntPtr id_onBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_;
	}
}
