using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Store.Gpbl.Bridges;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Store.Listeners
{
	// Token: 0x02000039 RID: 57
	[Register("com/unity3d/services/store/listeners/IBillingDataResponseListener", DoNotGenerateAcw = true)]
	internal class IBillingDataResponseListenerInvoker : Java.Lang.Object, IBillingDataResponseListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600010E RID: 270 RVA: 0x000030B0 File Offset: 0x000012B0
		private static IntPtr java_class_ref
		{
			get
			{
				return IBillingDataResponseListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600010F RID: 271 RVA: 0x000030D4 File Offset: 0x000012D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IBillingDataResponseListenerInvoker._members;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000110 RID: 272 RVA: 0x000030DB File Offset: 0x000012DB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000111 RID: 273 RVA: 0x000030E3 File Offset: 0x000012E3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IBillingDataResponseListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000030EF File Offset: 0x000012EF
		public static IBillingDataResponseListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IBillingDataResponseListener>(handle, transfer);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x000030F8 File Offset: 0x000012F8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IBillingDataResponseListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.store.listeners.IBillingDataResponseListener'.");
			}
			return handle;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00003123 File Offset: 0x00001323
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00003154 File Offset: 0x00001354
		public IBillingDataResponseListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IBillingDataResponseListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0000318C File Offset: 0x0000138C
		private static Delegate GetOnBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_Handler()
		{
			if (IBillingDataResponseListenerInvoker.cb_onBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_ == null)
			{
				IBillingDataResponseListenerInvoker.cb_onBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IBillingDataResponseListenerInvoker.n_OnBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_));
			}
			return IBillingDataResponseListenerInvoker.cb_onBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x000031B0 File Offset: 0x000013B0
		private static void n_OnBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IBillingDataResponseListener @object = Java.Lang.Object.GetObject<IBillingDataResponseListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			BillingResultBridge object2 = Java.Lang.Object.GetObject<BillingResultBridge>(native_p0, JniHandleOwnership.DoNotTransfer);
			IList p = JavaList.FromJniHandle(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.OnBillingResponse(object2, p);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x000031DC File Offset: 0x000013DC
		public unsafe void OnBillingResponse(BillingResultBridge p0, IList p1)
		{
			if (this.id_onBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_ == IntPtr.Zero)
			{
				this.id_onBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_ = JNIEnv.GetMethodID(this.class_ref, "onBillingResponse", "(Lcom/unity3d/services/store/gpbl/bridges/BillingResultBridge;Ljava/util/List;)V");
			}
			IntPtr intPtr = JavaList.ToLocalJniHandle(p1);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x0400000B RID: 11
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/store/listeners/IBillingDataResponseListener", typeof(IBillingDataResponseListenerInvoker));

		// Token: 0x0400000C RID: 12
		private IntPtr class_ref;

		// Token: 0x0400000D RID: 13
		private static Delegate cb_onBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_;

		// Token: 0x0400000E RID: 14
		private IntPtr id_onBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_;
	}
}
