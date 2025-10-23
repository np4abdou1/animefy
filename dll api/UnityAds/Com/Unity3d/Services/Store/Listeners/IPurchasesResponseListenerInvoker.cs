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
	// Token: 0x0200003F RID: 63
	[Register("com/unity3d/services/store/listeners/IPurchasesResponseListener", DoNotGenerateAcw = true)]
	internal class IPurchasesResponseListenerInvoker : Java.Lang.Object, IPurchasesResponseListener, IBillingDataResponseListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600012F RID: 303 RVA: 0x00003500 File Offset: 0x00001700
		private static IntPtr java_class_ref
		{
			get
			{
				return IPurchasesResponseListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000130 RID: 304 RVA: 0x00003524 File Offset: 0x00001724
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IPurchasesResponseListenerInvoker._members;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000131 RID: 305 RVA: 0x0000352B File Offset: 0x0000172B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000132 RID: 306 RVA: 0x00003533 File Offset: 0x00001733
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IPurchasesResponseListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x0000353F File Offset: 0x0000173F
		public static IPurchasesResponseListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IPurchasesResponseListener>(handle, transfer);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00003548 File Offset: 0x00001748
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IPurchasesResponseListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.store.listeners.IPurchasesResponseListener'.");
			}
			return handle;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00003573 File Offset: 0x00001773
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x000035A4 File Offset: 0x000017A4
		public IPurchasesResponseListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IPurchasesResponseListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x000035DC File Offset: 0x000017DC
		private static Delegate GetOnBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_Handler()
		{
			if (IPurchasesResponseListenerInvoker.cb_onBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_ == null)
			{
				IPurchasesResponseListenerInvoker.cb_onBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IPurchasesResponseListenerInvoker.n_OnBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_));
			}
			return IPurchasesResponseListenerInvoker.cb_onBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00003600 File Offset: 0x00001800
		private static void n_OnBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IPurchasesResponseListener @object = Java.Lang.Object.GetObject<IPurchasesResponseListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			BillingResultBridge object2 = Java.Lang.Object.GetObject<BillingResultBridge>(native_p0, JniHandleOwnership.DoNotTransfer);
			IList<PurchaseBridge> p = JavaList<PurchaseBridge>.FromJniHandle(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.OnBillingResponse(object2, p);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x0000362C File Offset: 0x0000182C
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

		// Token: 0x0600013A RID: 314 RVA: 0x00002226 File Offset: 0x00000426
		public void OnBillingResponse(BillingResultBridge p0, IList p1)
		{
			throw new NotImplementedException();
		}

		// Token: 0x04000017 RID: 23
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/store/listeners/IPurchasesResponseListener", typeof(IPurchasesResponseListenerInvoker));

		// Token: 0x04000018 RID: 24
		private IntPtr class_ref;

		// Token: 0x04000019 RID: 25
		private static Delegate cb_onBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_;

		// Token: 0x0400001A RID: 26
		private IntPtr id_onBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_;
	}
}
