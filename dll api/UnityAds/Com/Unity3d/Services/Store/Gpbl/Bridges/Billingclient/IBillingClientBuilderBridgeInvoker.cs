using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Store.Gpbl.Proxies;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Store.Gpbl.Bridges.Billingclient
{
	// Token: 0x0200005F RID: 95
	[Register("com/unity3d/services/store/gpbl/bridges/billingclient/IBillingClientBuilderBridge", DoNotGenerateAcw = true)]
	internal class IBillingClientBuilderBridgeInvoker : Java.Lang.Object, IBillingClientBuilderBridge, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600029A RID: 666 RVA: 0x000072B4 File Offset: 0x000054B4
		private static IntPtr java_class_ref
		{
			get
			{
				return IBillingClientBuilderBridgeInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600029B RID: 667 RVA: 0x000072D8 File Offset: 0x000054D8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IBillingClientBuilderBridgeInvoker._members;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x0600029C RID: 668 RVA: 0x000072DF File Offset: 0x000054DF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600029D RID: 669 RVA: 0x000072E7 File Offset: 0x000054E7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IBillingClientBuilderBridgeInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600029E RID: 670 RVA: 0x000072F3 File Offset: 0x000054F3
		public static IBillingClientBuilderBridge GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IBillingClientBuilderBridge>(handle, transfer);
		}

		// Token: 0x0600029F RID: 671 RVA: 0x000072FC File Offset: 0x000054FC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IBillingClientBuilderBridgeInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.store.gpbl.bridges.billingclient.IBillingClientBuilderBridge'.");
			}
			return handle;
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00007327 File Offset: 0x00005527
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00007358 File Offset: 0x00005558
		public IBillingClientBuilderBridgeInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IBillingClientBuilderBridgeInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00007390 File Offset: 0x00005590
		private static Delegate GetBuildHandler()
		{
			if (IBillingClientBuilderBridgeInvoker.cb_build == null)
			{
				IBillingClientBuilderBridgeInvoker.cb_build = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IBillingClientBuilderBridgeInvoker.n_Build));
			}
			return IBillingClientBuilderBridgeInvoker.cb_build;
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x000073B4 File Offset: 0x000055B4
		private static IntPtr n_Build(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IBillingClientBuilderBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Build());
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x000073C8 File Offset: 0x000055C8
		public IBillingClient Build()
		{
			if (this.id_build == IntPtr.Zero)
			{
				this.id_build = JNIEnv.GetMethodID(this.class_ref, "build", "()Lcom/unity3d/services/store/gpbl/bridges/billingclient/IBillingClient;");
			}
			return Java.Lang.Object.GetObject<IBillingClient>(JNIEnv.CallObjectMethod(base.Handle, this.id_build), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00007419 File Offset: 0x00005619
		private static Delegate GetEnablePendingPurchasesHandler()
		{
			if (IBillingClientBuilderBridgeInvoker.cb_enablePendingPurchases == null)
			{
				IBillingClientBuilderBridgeInvoker.cb_enablePendingPurchases = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IBillingClientBuilderBridgeInvoker.n_EnablePendingPurchases));
			}
			return IBillingClientBuilderBridgeInvoker.cb_enablePendingPurchases;
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0000743D File Offset: 0x0000563D
		private static IntPtr n_EnablePendingPurchases(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IBillingClientBuilderBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).EnablePendingPurchases());
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00007454 File Offset: 0x00005654
		public IBillingClientBuilderBridge EnablePendingPurchases()
		{
			if (this.id_enablePendingPurchases == IntPtr.Zero)
			{
				this.id_enablePendingPurchases = JNIEnv.GetMethodID(this.class_ref, "enablePendingPurchases", "()Lcom/unity3d/services/store/gpbl/bridges/billingclient/IBillingClientBuilderBridge;");
			}
			return Java.Lang.Object.GetObject<IBillingClientBuilderBridge>(JNIEnv.CallObjectMethod(base.Handle, this.id_enablePendingPurchases), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x000074A5 File Offset: 0x000056A5
		private static Delegate GetSetListener_Lcom_unity3d_services_store_gpbl_proxies_PurchaseUpdatedListenerProxy_Handler()
		{
			if (IBillingClientBuilderBridgeInvoker.cb_setListener_Lcom_unity3d_services_store_gpbl_proxies_PurchaseUpdatedListenerProxy_ == null)
			{
				IBillingClientBuilderBridgeInvoker.cb_setListener_Lcom_unity3d_services_store_gpbl_proxies_PurchaseUpdatedListenerProxy_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IBillingClientBuilderBridgeInvoker.n_SetListener_Lcom_unity3d_services_store_gpbl_proxies_PurchaseUpdatedListenerProxy_));
			}
			return IBillingClientBuilderBridgeInvoker.cb_setListener_Lcom_unity3d_services_store_gpbl_proxies_PurchaseUpdatedListenerProxy_;
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x000074CC File Offset: 0x000056CC
		private static IntPtr n_SetListener_Lcom_unity3d_services_store_gpbl_proxies_PurchaseUpdatedListenerProxy_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IBillingClientBuilderBridge @object = Java.Lang.Object.GetObject<IBillingClientBuilderBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			PurchaseUpdatedListenerProxy object2 = Java.Lang.Object.GetObject<PurchaseUpdatedListenerProxy>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetListener(object2));
		}

		// Token: 0x060002AA RID: 682 RVA: 0x000074F4 File Offset: 0x000056F4
		public unsafe IBillingClientBuilderBridge SetListener(PurchaseUpdatedListenerProxy p0)
		{
			if (this.id_setListener_Lcom_unity3d_services_store_gpbl_proxies_PurchaseUpdatedListenerProxy_ == IntPtr.Zero)
			{
				this.id_setListener_Lcom_unity3d_services_store_gpbl_proxies_PurchaseUpdatedListenerProxy_ = JNIEnv.GetMethodID(this.class_ref, "setListener", "(Lcom/unity3d/services/store/gpbl/proxies/PurchaseUpdatedListenerProxy;)Lcom/unity3d/services/store/gpbl/bridges/billingclient/IBillingClientBuilderBridge;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			return Java.Lang.Object.GetObject<IBillingClientBuilderBridge>(JNIEnv.CallObjectMethod(base.Handle, this.id_setListener_Lcom_unity3d_services_store_gpbl_proxies_PurchaseUpdatedListenerProxy_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000072 RID: 114
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/store/gpbl/bridges/billingclient/IBillingClientBuilderBridge", typeof(IBillingClientBuilderBridgeInvoker));

		// Token: 0x04000073 RID: 115
		private IntPtr class_ref;

		// Token: 0x04000074 RID: 116
		private static Delegate cb_build;

		// Token: 0x04000075 RID: 117
		private IntPtr id_build;

		// Token: 0x04000076 RID: 118
		private static Delegate cb_enablePendingPurchases;

		// Token: 0x04000077 RID: 119
		private IntPtr id_enablePendingPurchases;

		// Token: 0x04000078 RID: 120
		private static Delegate cb_setListener_Lcom_unity3d_services_store_gpbl_proxies_PurchaseUpdatedListenerProxy_;

		// Token: 0x04000079 RID: 121
		private IntPtr id_setListener_Lcom_unity3d_services_store_gpbl_proxies_PurchaseUpdatedListenerProxy_;
	}
}
