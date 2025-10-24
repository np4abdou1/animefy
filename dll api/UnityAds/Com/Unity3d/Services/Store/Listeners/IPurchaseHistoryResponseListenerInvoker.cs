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
	// Token: 0x0200003D RID: 61
	[Register("com/unity3d/services/store/listeners/IPurchaseHistoryResponseListener", DoNotGenerateAcw = true)]
	internal class IPurchaseHistoryResponseListenerInvoker : Java.Lang.Object, IPurchaseHistoryResponseListener, IBillingDataResponseListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000121 RID: 289 RVA: 0x00003324 File Offset: 0x00001524
		private static IntPtr java_class_ref
		{
			get
			{
				return IPurchaseHistoryResponseListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000122 RID: 290 RVA: 0x00003348 File Offset: 0x00001548
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IPurchaseHistoryResponseListenerInvoker._members;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000123 RID: 291 RVA: 0x0000334F File Offset: 0x0000154F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000124 RID: 292 RVA: 0x00003357 File Offset: 0x00001557
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IPurchaseHistoryResponseListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00003363 File Offset: 0x00001563
		public static IPurchaseHistoryResponseListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IPurchaseHistoryResponseListener>(handle, transfer);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0000336C File Offset: 0x0000156C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IPurchaseHistoryResponseListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.store.listeners.IPurchaseHistoryResponseListener'.");
			}
			return handle;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00003397 File Offset: 0x00001597
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x000033C8 File Offset: 0x000015C8
		public IPurchaseHistoryResponseListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IPurchaseHistoryResponseListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00003400 File Offset: 0x00001600
		private static Delegate GetOnBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_Handler()
		{
			if (IPurchaseHistoryResponseListenerInvoker.cb_onBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_ == null)
			{
				IPurchaseHistoryResponseListenerInvoker.cb_onBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IPurchaseHistoryResponseListenerInvoker.n_OnBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_));
			}
			return IPurchaseHistoryResponseListenerInvoker.cb_onBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00003424 File Offset: 0x00001624
		private static void n_OnBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IPurchaseHistoryResponseListener @object = Java.Lang.Object.GetObject<IPurchaseHistoryResponseListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			BillingResultBridge object2 = Java.Lang.Object.GetObject<BillingResultBridge>(native_p0, JniHandleOwnership.DoNotTransfer);
			IList<PurchaseHistoryRecordBridge> p = JavaList<PurchaseHistoryRecordBridge>.FromJniHandle(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.OnBillingResponse(object2, p);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00003450 File Offset: 0x00001650
		public unsafe void OnBillingResponse(BillingResultBridge p0, IList<PurchaseHistoryRecordBridge> p1)
		{
			if (this.id_onBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_ == IntPtr.Zero)
			{
				this.id_onBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_ = JNIEnv.GetMethodID(this.class_ref, "onBillingResponse", "(Lcom/unity3d/services/store/gpbl/bridges/BillingResultBridge;Ljava/util/List;)V");
			}
			IntPtr intPtr = JavaList<PurchaseHistoryRecordBridge>.ToLocalJniHandle(p1);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00002226 File Offset: 0x00000426
		public void OnBillingResponse(BillingResultBridge p0, IList p1)
		{
			throw new NotImplementedException();
		}

		// Token: 0x04000013 RID: 19
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/store/listeners/IPurchaseHistoryResponseListener", typeof(IPurchaseHistoryResponseListenerInvoker));

		// Token: 0x04000014 RID: 20
		private IntPtr class_ref;

		// Token: 0x04000015 RID: 21
		private static Delegate cb_onBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_;

		// Token: 0x04000016 RID: 22
		private IntPtr id_onBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_;
	}
}
