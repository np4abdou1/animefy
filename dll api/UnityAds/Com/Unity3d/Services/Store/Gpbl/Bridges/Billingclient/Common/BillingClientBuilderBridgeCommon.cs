using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Reflection;
using Com.Unity3d.Services.Store.Gpbl.Proxies;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Store.Gpbl.Bridges.Billingclient.Common
{
	// Token: 0x02000066 RID: 102
	[Register("com/unity3d/services/store/gpbl/bridges/billingclient/common/BillingClientBuilderBridgeCommon", DoNotGenerateAcw = true)]
	public abstract class BillingClientBuilderBridgeCommon : GenericBridge, IBillingClientBuilderBridge, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000300 RID: 768 RVA: 0x0000857C File Offset: 0x0000677C
		// (set) Token: 0x06000301 RID: 769 RVA: 0x000085AC File Offset: 0x000067AC
		[Register("_billingClientBuilderInternalInstance")]
		protected Java.Lang.Object BillingClientBuilderInternalInstance
		{
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Object>(BillingClientBuilderBridgeCommon._members.InstanceFields.GetObjectValue("_billingClientBuilderInternalInstance.Ljava/lang/Object;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					BillingClientBuilderBridgeCommon._members.InstanceFields.SetValue("_billingClientBuilderInternalInstance.Ljava/lang/Object;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000302 RID: 770 RVA: 0x000085F8 File Offset: 0x000067F8
		internal new static IntPtr class_ref
		{
			get
			{
				return BillingClientBuilderBridgeCommon._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000303 RID: 771 RVA: 0x0000861C File Offset: 0x0000681C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BillingClientBuilderBridgeCommon._members;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000304 RID: 772 RVA: 0x00008624 File Offset: 0x00006824
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BillingClientBuilderBridgeCommon._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000305 RID: 773 RVA: 0x00008648 File Offset: 0x00006848
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BillingClientBuilderBridgeCommon._members.ManagedPeerType;
			}
		}

		// Token: 0x06000306 RID: 774 RVA: 0x000058C0 File Offset: 0x00003AC0
		protected BillingClientBuilderBridgeCommon(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00008654 File Offset: 0x00006854
		[Register(".ctor", "(Ljava/lang/Object;)V", "")]
		public unsafe BillingClientBuilderBridgeCommon(Java.Lang.Object billingClientBuilderInternalInstance) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((billingClientBuilderInternalInstance == null) ? IntPtr.Zero : billingClientBuilderInternalInstance.Handle);
				base.SetHandle(BillingClientBuilderBridgeCommon._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Object;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				BillingClientBuilderBridgeCommon._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(billingClientBuilderInternalInstance);
			}
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00008704 File Offset: 0x00006904
		private static Delegate GetGetClassNameHandler()
		{
			if (BillingClientBuilderBridgeCommon.cb_getClassName == null)
			{
				BillingClientBuilderBridgeCommon.cb_getClassName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(BillingClientBuilderBridgeCommon.n_GetClassName));
			}
			return BillingClientBuilderBridgeCommon.cb_getClassName;
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00008728 File Offset: 0x00006928
		private static IntPtr n_GetClassName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<BillingClientBuilderBridgeCommon>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClassName);
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x0600030A RID: 778 RVA: 0x0000873C File Offset: 0x0000693C
		protected override string ClassName
		{
			[Register("getClassName", "()Ljava/lang/String;", "GetGetClassNameHandler")]
			get
			{
				return JNIEnv.GetString(BillingClientBuilderBridgeCommon._members.InstanceMethods.InvokeVirtualObjectMethod("getClassName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600030B RID: 779 RVA: 0x0000876E File Offset: 0x0000696E
		private static Delegate GetEnablePendingPurchasesHandler()
		{
			if (BillingClientBuilderBridgeCommon.cb_enablePendingPurchases == null)
			{
				BillingClientBuilderBridgeCommon.cb_enablePendingPurchases = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(BillingClientBuilderBridgeCommon.n_EnablePendingPurchases));
			}
			return BillingClientBuilderBridgeCommon.cb_enablePendingPurchases;
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00008792 File Offset: 0x00006992
		private static IntPtr n_EnablePendingPurchases(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BillingClientBuilderBridgeCommon>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).EnablePendingPurchases());
		}

		// Token: 0x0600030D RID: 781 RVA: 0x000087A8 File Offset: 0x000069A8
		[Register("enablePendingPurchases", "()Lcom/unity3d/services/store/gpbl/bridges/billingclient/IBillingClientBuilderBridge;", "GetEnablePendingPurchasesHandler")]
		public virtual IBillingClientBuilderBridge EnablePendingPurchases()
		{
			return Java.Lang.Object.GetObject<IBillingClientBuilderBridge>(BillingClientBuilderBridgeCommon._members.InstanceMethods.InvokeVirtualObjectMethod("enablePendingPurchases.()Lcom/unity3d/services/store/gpbl/bridges/billingclient/IBillingClientBuilderBridge;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600030E RID: 782 RVA: 0x000087DA File Offset: 0x000069DA
		private static Delegate GetSetListener_Lcom_unity3d_services_store_gpbl_proxies_PurchaseUpdatedListenerProxy_Handler()
		{
			if (BillingClientBuilderBridgeCommon.cb_setListener_Lcom_unity3d_services_store_gpbl_proxies_PurchaseUpdatedListenerProxy_ == null)
			{
				BillingClientBuilderBridgeCommon.cb_setListener_Lcom_unity3d_services_store_gpbl_proxies_PurchaseUpdatedListenerProxy_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(BillingClientBuilderBridgeCommon.n_SetListener_Lcom_unity3d_services_store_gpbl_proxies_PurchaseUpdatedListenerProxy_));
			}
			return BillingClientBuilderBridgeCommon.cb_setListener_Lcom_unity3d_services_store_gpbl_proxies_PurchaseUpdatedListenerProxy_;
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00008800 File Offset: 0x00006A00
		private static IntPtr n_SetListener_Lcom_unity3d_services_store_gpbl_proxies_PurchaseUpdatedListenerProxy_(IntPtr jnienv, IntPtr native__this, IntPtr native_purchaseUpdatedListenerProxy)
		{
			BillingClientBuilderBridgeCommon @object = Java.Lang.Object.GetObject<BillingClientBuilderBridgeCommon>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			PurchaseUpdatedListenerProxy object2 = Java.Lang.Object.GetObject<PurchaseUpdatedListenerProxy>(native_purchaseUpdatedListenerProxy, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetListener(object2));
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00008828 File Offset: 0x00006A28
		[Register("setListener", "(Lcom/unity3d/services/store/gpbl/proxies/PurchaseUpdatedListenerProxy;)Lcom/unity3d/services/store/gpbl/bridges/billingclient/IBillingClientBuilderBridge;", "GetSetListener_Lcom_unity3d_services_store_gpbl_proxies_PurchaseUpdatedListenerProxy_Handler")]
		public unsafe virtual IBillingClientBuilderBridge SetListener(PurchaseUpdatedListenerProxy purchaseUpdatedListenerProxy)
		{
			IBillingClientBuilderBridge @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((purchaseUpdatedListenerProxy == null) ? IntPtr.Zero : purchaseUpdatedListenerProxy.Handle);
				@object = Java.Lang.Object.GetObject<IBillingClientBuilderBridge>(BillingClientBuilderBridgeCommon._members.InstanceMethods.InvokeVirtualObjectMethod("setListener.(Lcom/unity3d/services/store/gpbl/proxies/PurchaseUpdatedListenerProxy;)Lcom/unity3d/services/store/gpbl/bridges/billingclient/IBillingClientBuilderBridge;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(purchaseUpdatedListenerProxy);
			}
			return @object;
		}

		// Token: 0x06000311 RID: 785 RVA: 0x0000889C File Offset: 0x00006A9C
		private static Delegate GetBuildHandler()
		{
			if (BillingClientBuilderBridgeCommon.cb_build == null)
			{
				BillingClientBuilderBridgeCommon.cb_build = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(BillingClientBuilderBridgeCommon.n_Build));
			}
			return BillingClientBuilderBridgeCommon.cb_build;
		}

		// Token: 0x06000312 RID: 786 RVA: 0x000088C0 File Offset: 0x00006AC0
		private static IntPtr n_Build(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BillingClientBuilderBridgeCommon>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Build());
		}

		// Token: 0x06000313 RID: 787
		[Register("build", "()Lcom/unity3d/services/store/gpbl/bridges/billingclient/IBillingClient;", "GetBuildHandler")]
		public abstract IBillingClient Build();

		// Token: 0x04000093 RID: 147
		[Register("buildMethodName")]
		protected const string BuildMethodName = "build";

		// Token: 0x04000094 RID: 148
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/store/gpbl/bridges/billingclient/common/BillingClientBuilderBridgeCommon", typeof(BillingClientBuilderBridgeCommon));

		// Token: 0x04000095 RID: 149
		private static Delegate cb_getClassName;

		// Token: 0x04000096 RID: 150
		private static Delegate cb_enablePendingPurchases;

		// Token: 0x04000097 RID: 151
		private static Delegate cb_setListener_Lcom_unity3d_services_store_gpbl_proxies_PurchaseUpdatedListenerProxy_;

		// Token: 0x04000098 RID: 152
		private static Delegate cb_build;
	}
}
