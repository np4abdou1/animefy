using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Store.Gpbl.Bridges;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Store.Gpbl
{
	// Token: 0x02000047 RID: 71
	[Register("com/unity3d/services/store/gpbl/IBillingClientStateListener", DoNotGenerateAcw = true)]
	internal class IBillingClientStateListenerInvoker : Java.Lang.Object, IBillingClientStateListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600017C RID: 380 RVA: 0x00004188 File Offset: 0x00002388
		private static IntPtr java_class_ref
		{
			get
			{
				return IBillingClientStateListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600017D RID: 381 RVA: 0x000041AC File Offset: 0x000023AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IBillingClientStateListenerInvoker._members;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600017E RID: 382 RVA: 0x000041B3 File Offset: 0x000023B3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600017F RID: 383 RVA: 0x000041BB File Offset: 0x000023BB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IBillingClientStateListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000180 RID: 384 RVA: 0x000041C7 File Offset: 0x000023C7
		public static IBillingClientStateListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IBillingClientStateListener>(handle, transfer);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x000041D0 File Offset: 0x000023D0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IBillingClientStateListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.store.gpbl.IBillingClientStateListener'.");
			}
			return handle;
		}

		// Token: 0x06000182 RID: 386 RVA: 0x000041FB File Offset: 0x000023FB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0000422C File Offset: 0x0000242C
		public IBillingClientStateListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IBillingClientStateListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00004264 File Offset: 0x00002464
		private static Delegate GetOnBillingServiceDisconnectedHandler()
		{
			if (IBillingClientStateListenerInvoker.cb_onBillingServiceDisconnected == null)
			{
				IBillingClientStateListenerInvoker.cb_onBillingServiceDisconnected = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IBillingClientStateListenerInvoker.n_OnBillingServiceDisconnected));
			}
			return IBillingClientStateListenerInvoker.cb_onBillingServiceDisconnected;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00004288 File Offset: 0x00002488
		private static void n_OnBillingServiceDisconnected(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IBillingClientStateListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnBillingServiceDisconnected();
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00004297 File Offset: 0x00002497
		public void OnBillingServiceDisconnected()
		{
			if (this.id_onBillingServiceDisconnected == IntPtr.Zero)
			{
				this.id_onBillingServiceDisconnected = JNIEnv.GetMethodID(this.class_ref, "onBillingServiceDisconnected", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onBillingServiceDisconnected);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x000042D7 File Offset: 0x000024D7
		private static Delegate GetOnBillingSetupFinished_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Handler()
		{
			if (IBillingClientStateListenerInvoker.cb_onBillingSetupFinished_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_ == null)
			{
				IBillingClientStateListenerInvoker.cb_onBillingSetupFinished_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IBillingClientStateListenerInvoker.n_OnBillingSetupFinished_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_));
			}
			return IBillingClientStateListenerInvoker.cb_onBillingSetupFinished_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x000042FC File Offset: 0x000024FC
		private static void n_OnBillingSetupFinished_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IBillingClientStateListener @object = Java.Lang.Object.GetObject<IBillingClientStateListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			BillingResultBridge object2 = Java.Lang.Object.GetObject<BillingResultBridge>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnBillingSetupFinished(object2);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00004320 File Offset: 0x00002520
		public unsafe void OnBillingSetupFinished(BillingResultBridge p0)
		{
			if (this.id_onBillingSetupFinished_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_ == IntPtr.Zero)
			{
				this.id_onBillingSetupFinished_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_ = JNIEnv.GetMethodID(this.class_ref, "onBillingSetupFinished", "(Lcom/unity3d/services/store/gpbl/bridges/BillingResultBridge;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onBillingSetupFinished_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_, ptr);
		}

		// Token: 0x04000026 RID: 38
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/store/gpbl/IBillingClientStateListener", typeof(IBillingClientStateListenerInvoker));

		// Token: 0x04000027 RID: 39
		private IntPtr class_ref;

		// Token: 0x04000028 RID: 40
		private static Delegate cb_onBillingServiceDisconnected;

		// Token: 0x04000029 RID: 41
		private IntPtr id_onBillingServiceDisconnected;

		// Token: 0x0400002A RID: 42
		private static Delegate cb_onBillingSetupFinished_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_;

		// Token: 0x0400002B RID: 43
		private IntPtr id_onBillingSetupFinished_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_;
	}
}
