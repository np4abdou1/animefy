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
	// Token: 0x02000043 RID: 67
	[Register("com/unity3d/services/store/listeners/ISkuDetailsResponseListener", DoNotGenerateAcw = true)]
	internal class ISkuDetailsResponseListenerInvoker : Java.Lang.Object, ISkuDetailsResponseListener, IBillingDataResponseListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600014B RID: 331 RVA: 0x000038B8 File Offset: 0x00001AB8
		private static IntPtr java_class_ref
		{
			get
			{
				return ISkuDetailsResponseListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600014C RID: 332 RVA: 0x000038DC File Offset: 0x00001ADC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISkuDetailsResponseListenerInvoker._members;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600014D RID: 333 RVA: 0x000038E3 File Offset: 0x00001AE3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600014E RID: 334 RVA: 0x000038EB File Offset: 0x00001AEB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISkuDetailsResponseListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600014F RID: 335 RVA: 0x000038F7 File Offset: 0x00001AF7
		public static ISkuDetailsResponseListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ISkuDetailsResponseListener>(handle, transfer);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00003900 File Offset: 0x00001B00
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISkuDetailsResponseListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.store.listeners.ISkuDetailsResponseListener'.");
			}
			return handle;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0000392B File Offset: 0x00001B2B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0000395C File Offset: 0x00001B5C
		public ISkuDetailsResponseListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ISkuDetailsResponseListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00003994 File Offset: 0x00001B94
		private static Delegate GetOnBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_Handler()
		{
			if (ISkuDetailsResponseListenerInvoker.cb_onBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_ == null)
			{
				ISkuDetailsResponseListenerInvoker.cb_onBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(ISkuDetailsResponseListenerInvoker.n_OnBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_));
			}
			return ISkuDetailsResponseListenerInvoker.cb_onBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_;
		}

		// Token: 0x06000154 RID: 340 RVA: 0x000039B8 File Offset: 0x00001BB8
		private static void n_OnBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			ISkuDetailsResponseListener @object = Java.Lang.Object.GetObject<ISkuDetailsResponseListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			BillingResultBridge object2 = Java.Lang.Object.GetObject<BillingResultBridge>(native_p0, JniHandleOwnership.DoNotTransfer);
			IList<SkuDetailsBridge> p = JavaList<SkuDetailsBridge>.FromJniHandle(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.OnBillingResponse(object2, p);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x000039E4 File Offset: 0x00001BE4
		public unsafe void OnBillingResponse(BillingResultBridge p0, IList<SkuDetailsBridge> p1)
		{
			if (this.id_onBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_ == IntPtr.Zero)
			{
				this.id_onBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_ = JNIEnv.GetMethodID(this.class_ref, "onBillingResponse", "(Lcom/unity3d/services/store/gpbl/bridges/BillingResultBridge;Ljava/util/List;)V");
			}
			IntPtr intPtr = JavaList<SkuDetailsBridge>.ToLocalJniHandle(p1);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00002226 File Offset: 0x00000426
		public void OnBillingResponse(BillingResultBridge p0, IList p1)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0400001F RID: 31
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/store/listeners/ISkuDetailsResponseListener", typeof(ISkuDetailsResponseListenerInvoker));

		// Token: 0x04000020 RID: 32
		private IntPtr class_ref;

		// Token: 0x04000021 RID: 33
		private static Delegate cb_onBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_;

		// Token: 0x04000022 RID: 34
		private IntPtr id_onBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_;
	}
}
