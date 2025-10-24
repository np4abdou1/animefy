using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Store.Gpbl.Proxies;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Store.Gpbl.Bridges.Billingclient
{
	// Token: 0x0200005D RID: 93
	[Register("com/unity3d/services/store/gpbl/bridges/billingclient/IBillingClient", DoNotGenerateAcw = true)]
	internal class IBillingClientInvoker : Java.Lang.Object, IBillingClient, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x0600027C RID: 636 RVA: 0x00006D18 File Offset: 0x00004F18
		private static IntPtr java_class_ref
		{
			get
			{
				return IBillingClientInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x0600027D RID: 637 RVA: 0x00006D3C File Offset: 0x00004F3C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IBillingClientInvoker._members;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600027E RID: 638 RVA: 0x00006D43 File Offset: 0x00004F43
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600027F RID: 639 RVA: 0x00006D4B File Offset: 0x00004F4B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IBillingClientInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00006D57 File Offset: 0x00004F57
		public static IBillingClient GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IBillingClient>(handle, transfer);
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00006D60 File Offset: 0x00004F60
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IBillingClientInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.store.gpbl.bridges.billingclient.IBillingClient'.");
			}
			return handle;
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00006D8B File Offset: 0x00004F8B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00006DBC File Offset: 0x00004FBC
		public IBillingClientInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IBillingClientInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00006DF4 File Offset: 0x00004FF4
		private static Delegate GetIsReadyHandler()
		{
			if (IBillingClientInvoker.cb_isReady == null)
			{
				IBillingClientInvoker.cb_isReady = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IBillingClientInvoker.n_IsReady));
			}
			return IBillingClientInvoker.cb_isReady;
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00006E18 File Offset: 0x00005018
		private static bool n_IsReady(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IBillingClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsReady;
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000286 RID: 646 RVA: 0x00006E27 File Offset: 0x00005027
		public bool IsReady
		{
			get
			{
				if (this.id_isReady == IntPtr.Zero)
				{
					this.id_isReady = JNIEnv.GetMethodID(this.class_ref, "isReady", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isReady);
			}
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00006E67 File Offset: 0x00005067
		private static Delegate GetIsFeatureSupported_Ljava_lang_String_Handler()
		{
			if (IBillingClientInvoker.cb_isFeatureSupported_Ljava_lang_String_ == null)
			{
				IBillingClientInvoker.cb_isFeatureSupported_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IBillingClientInvoker.n_IsFeatureSupported_Ljava_lang_String_));
			}
			return IBillingClientInvoker.cb_isFeatureSupported_Ljava_lang_String_;
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00006E8C File Offset: 0x0000508C
		private static IntPtr n_IsFeatureSupported_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IBillingClient @object = Java.Lang.Object.GetObject<IBillingClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.IsFeatureSupported(@string));
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00006EB4 File Offset: 0x000050B4
		public unsafe BillingResultResponseCode IsFeatureSupported(string p0)
		{
			if (this.id_isFeatureSupported_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_isFeatureSupported_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "isFeatureSupported", "(Ljava/lang/String;)Lcom/unity3d/services/store/gpbl/BillingResultResponseCode;");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			BillingResultResponseCode @object = Java.Lang.Object.GetObject<BillingResultResponseCode>(JNIEnv.CallObjectMethod(base.Handle, this.id_isFeatureSupported_Ljava_lang_String_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00006F2B File Offset: 0x0000512B
		private static Delegate GetQueryPurchaseHistoryAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchaseHistoryResponseListenerProxy_Handler()
		{
			if (IBillingClientInvoker.cb_queryPurchaseHistoryAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchaseHistoryResponseListenerProxy_ == null)
			{
				IBillingClientInvoker.cb_queryPurchaseHistoryAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchaseHistoryResponseListenerProxy_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IBillingClientInvoker.n_QueryPurchaseHistoryAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchaseHistoryResponseListenerProxy_));
			}
			return IBillingClientInvoker.cb_queryPurchaseHistoryAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchaseHistoryResponseListenerProxy_;
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00006F50 File Offset: 0x00005150
		private static void n_QueryPurchaseHistoryAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchaseHistoryResponseListenerProxy_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IBillingClient @object = Java.Lang.Object.GetObject<IBillingClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			PurchaseHistoryResponseListenerProxy object2 = Java.Lang.Object.GetObject<PurchaseHistoryResponseListenerProxy>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.QueryPurchaseHistoryAsync(@string, object2);
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00006F7C File Offset: 0x0000517C
		public unsafe void QueryPurchaseHistoryAsync(string p0, PurchaseHistoryResponseListenerProxy p1)
		{
			if (this.id_queryPurchaseHistoryAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchaseHistoryResponseListenerProxy_ == IntPtr.Zero)
			{
				this.id_queryPurchaseHistoryAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchaseHistoryResponseListenerProxy_ = JNIEnv.GetMethodID(this.class_ref, "queryPurchaseHistoryAsync", "(Ljava/lang/String;Lcom/unity3d/services/store/gpbl/proxies/PurchaseHistoryResponseListenerProxy;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_queryPurchaseHistoryAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchaseHistoryResponseListenerProxy_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000700F File Offset: 0x0000520F
		private static Delegate GetQueryPurchasesAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchasesResponseListenerProxy_Handler()
		{
			if (IBillingClientInvoker.cb_queryPurchasesAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchasesResponseListenerProxy_ == null)
			{
				IBillingClientInvoker.cb_queryPurchasesAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchasesResponseListenerProxy_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IBillingClientInvoker.n_QueryPurchasesAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchasesResponseListenerProxy_));
			}
			return IBillingClientInvoker.cb_queryPurchasesAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchasesResponseListenerProxy_;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00007034 File Offset: 0x00005234
		private static void n_QueryPurchasesAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchasesResponseListenerProxy_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IBillingClient @object = Java.Lang.Object.GetObject<IBillingClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			PurchasesResponseListenerProxy object2 = Java.Lang.Object.GetObject<PurchasesResponseListenerProxy>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.QueryPurchasesAsync(@string, object2);
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00007060 File Offset: 0x00005260
		public unsafe void QueryPurchasesAsync(string p0, PurchasesResponseListenerProxy p1)
		{
			if (this.id_queryPurchasesAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchasesResponseListenerProxy_ == IntPtr.Zero)
			{
				this.id_queryPurchasesAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchasesResponseListenerProxy_ = JNIEnv.GetMethodID(this.class_ref, "queryPurchasesAsync", "(Ljava/lang/String;Lcom/unity3d/services/store/gpbl/proxies/PurchasesResponseListenerProxy;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_queryPurchasesAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchasesResponseListenerProxy_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x06000290 RID: 656 RVA: 0x000070F3 File Offset: 0x000052F3
		private static Delegate GetQuerySkuDetailsAsync_Lcom_unity3d_services_store_gpbl_bridges_SkuDetailsParamsBridge_Lcom_unity3d_services_store_gpbl_proxies_SkuDetailsResponseListenerProxy_Handler()
		{
			if (IBillingClientInvoker.cb_querySkuDetailsAsync_Lcom_unity3d_services_store_gpbl_bridges_SkuDetailsParamsBridge_Lcom_unity3d_services_store_gpbl_proxies_SkuDetailsResponseListenerProxy_ == null)
			{
				IBillingClientInvoker.cb_querySkuDetailsAsync_Lcom_unity3d_services_store_gpbl_bridges_SkuDetailsParamsBridge_Lcom_unity3d_services_store_gpbl_proxies_SkuDetailsResponseListenerProxy_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IBillingClientInvoker.n_QuerySkuDetailsAsync_Lcom_unity3d_services_store_gpbl_bridges_SkuDetailsParamsBridge_Lcom_unity3d_services_store_gpbl_proxies_SkuDetailsResponseListenerProxy_));
			}
			return IBillingClientInvoker.cb_querySkuDetailsAsync_Lcom_unity3d_services_store_gpbl_bridges_SkuDetailsParamsBridge_Lcom_unity3d_services_store_gpbl_proxies_SkuDetailsResponseListenerProxy_;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00007118 File Offset: 0x00005318
		private static void n_QuerySkuDetailsAsync_Lcom_unity3d_services_store_gpbl_bridges_SkuDetailsParamsBridge_Lcom_unity3d_services_store_gpbl_proxies_SkuDetailsResponseListenerProxy_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IBillingClient @object = Java.Lang.Object.GetObject<IBillingClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			SkuDetailsParamsBridge object2 = Java.Lang.Object.GetObject<SkuDetailsParamsBridge>(native_p0, JniHandleOwnership.DoNotTransfer);
			SkuDetailsResponseListenerProxy object3 = Java.Lang.Object.GetObject<SkuDetailsResponseListenerProxy>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.QuerySkuDetailsAsync(object2, object3);
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00007144 File Offset: 0x00005344
		public unsafe void QuerySkuDetailsAsync(SkuDetailsParamsBridge p0, SkuDetailsResponseListenerProxy p1)
		{
			if (this.id_querySkuDetailsAsync_Lcom_unity3d_services_store_gpbl_bridges_SkuDetailsParamsBridge_Lcom_unity3d_services_store_gpbl_proxies_SkuDetailsResponseListenerProxy_ == IntPtr.Zero)
			{
				this.id_querySkuDetailsAsync_Lcom_unity3d_services_store_gpbl_bridges_SkuDetailsParamsBridge_Lcom_unity3d_services_store_gpbl_proxies_SkuDetailsResponseListenerProxy_ = JNIEnv.GetMethodID(this.class_ref, "querySkuDetailsAsync", "(Lcom/unity3d/services/store/gpbl/bridges/SkuDetailsParamsBridge;Lcom/unity3d/services/store/gpbl/proxies/SkuDetailsResponseListenerProxy;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_querySkuDetailsAsync_Lcom_unity3d_services_store_gpbl_bridges_SkuDetailsParamsBridge_Lcom_unity3d_services_store_gpbl_proxies_SkuDetailsResponseListenerProxy_, ptr);
		}

		// Token: 0x06000293 RID: 659 RVA: 0x000071D9 File Offset: 0x000053D9
		private static Delegate GetStartConnection_Lcom_unity3d_services_store_gpbl_proxies_BillingClientStateListenerProxy_Handler()
		{
			if (IBillingClientInvoker.cb_startConnection_Lcom_unity3d_services_store_gpbl_proxies_BillingClientStateListenerProxy_ == null)
			{
				IBillingClientInvoker.cb_startConnection_Lcom_unity3d_services_store_gpbl_proxies_BillingClientStateListenerProxy_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IBillingClientInvoker.n_StartConnection_Lcom_unity3d_services_store_gpbl_proxies_BillingClientStateListenerProxy_));
			}
			return IBillingClientInvoker.cb_startConnection_Lcom_unity3d_services_store_gpbl_proxies_BillingClientStateListenerProxy_;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00007200 File Offset: 0x00005400
		private static void n_StartConnection_Lcom_unity3d_services_store_gpbl_proxies_BillingClientStateListenerProxy_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IBillingClient @object = Java.Lang.Object.GetObject<IBillingClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			BillingClientStateListenerProxy object2 = Java.Lang.Object.GetObject<BillingClientStateListenerProxy>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.StartConnection(object2);
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00007224 File Offset: 0x00005424
		public unsafe void StartConnection(BillingClientStateListenerProxy p0)
		{
			if (this.id_startConnection_Lcom_unity3d_services_store_gpbl_proxies_BillingClientStateListenerProxy_ == IntPtr.Zero)
			{
				this.id_startConnection_Lcom_unity3d_services_store_gpbl_proxies_BillingClientStateListenerProxy_ = JNIEnv.GetMethodID(this.class_ref, "startConnection", "(Lcom/unity3d/services/store/gpbl/proxies/BillingClientStateListenerProxy;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_startConnection_Lcom_unity3d_services_store_gpbl_proxies_BillingClientStateListenerProxy_, ptr);
		}

		// Token: 0x04000064 RID: 100
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/store/gpbl/bridges/billingclient/IBillingClient", typeof(IBillingClientInvoker));

		// Token: 0x04000065 RID: 101
		private IntPtr class_ref;

		// Token: 0x04000066 RID: 102
		private static Delegate cb_isReady;

		// Token: 0x04000067 RID: 103
		private IntPtr id_isReady;

		// Token: 0x04000068 RID: 104
		private static Delegate cb_isFeatureSupported_Ljava_lang_String_;

		// Token: 0x04000069 RID: 105
		private IntPtr id_isFeatureSupported_Ljava_lang_String_;

		// Token: 0x0400006A RID: 106
		private static Delegate cb_queryPurchaseHistoryAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchaseHistoryResponseListenerProxy_;

		// Token: 0x0400006B RID: 107
		private IntPtr id_queryPurchaseHistoryAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchaseHistoryResponseListenerProxy_;

		// Token: 0x0400006C RID: 108
		private static Delegate cb_queryPurchasesAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchasesResponseListenerProxy_;

		// Token: 0x0400006D RID: 109
		private IntPtr id_queryPurchasesAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchasesResponseListenerProxy_;

		// Token: 0x0400006E RID: 110
		private static Delegate cb_querySkuDetailsAsync_Lcom_unity3d_services_store_gpbl_bridges_SkuDetailsParamsBridge_Lcom_unity3d_services_store_gpbl_proxies_SkuDetailsResponseListenerProxy_;

		// Token: 0x0400006F RID: 111
		private IntPtr id_querySkuDetailsAsync_Lcom_unity3d_services_store_gpbl_bridges_SkuDetailsParamsBridge_Lcom_unity3d_services_store_gpbl_proxies_SkuDetailsResponseListenerProxy_;

		// Token: 0x04000070 RID: 112
		private static Delegate cb_startConnection_Lcom_unity3d_services_store_gpbl_proxies_BillingClientStateListenerProxy_;

		// Token: 0x04000071 RID: 113
		private IntPtr id_startConnection_Lcom_unity3d_services_store_gpbl_proxies_BillingClientStateListenerProxy_;
	}
}
