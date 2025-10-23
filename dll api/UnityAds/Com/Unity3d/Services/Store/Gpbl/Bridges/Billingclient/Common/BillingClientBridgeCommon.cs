using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Reflection;
using Com.Unity3d.Services.Store.Gpbl.Proxies;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Store.Gpbl.Bridges.Billingclient.Common
{
	// Token: 0x02000064 RID: 100
	[Register("com/unity3d/services/store/gpbl/bridges/billingclient/common/BillingClientBridgeCommon", DoNotGenerateAcw = true)]
	public abstract class BillingClientBridgeCommon : GenericBridge, IBillingClient, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x00007DC8 File Offset: 0x00005FC8
		// (set) Token: 0x060002D9 RID: 729 RVA: 0x00007DF8 File Offset: 0x00005FF8
		[Register("_billingClientInternalInstance")]
		protected Java.Lang.Object BillingClientInternalInstance
		{
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Object>(BillingClientBridgeCommon._members.InstanceFields.GetObjectValue("_billingClientInternalInstance.Ljava/lang/Object;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					BillingClientBridgeCommon._members.InstanceFields.SetValue("_billingClientInternalInstance.Ljava/lang/Object;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060002DA RID: 730 RVA: 0x00007E44 File Offset: 0x00006044
		internal new static IntPtr class_ref
		{
			get
			{
				return BillingClientBridgeCommon._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060002DB RID: 731 RVA: 0x00007E68 File Offset: 0x00006068
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BillingClientBridgeCommon._members;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060002DC RID: 732 RVA: 0x00007E70 File Offset: 0x00006070
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BillingClientBridgeCommon._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060002DD RID: 733 RVA: 0x00007E94 File Offset: 0x00006094
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BillingClientBridgeCommon._members.ManagedPeerType;
			}
		}

		// Token: 0x060002DE RID: 734 RVA: 0x000058C0 File Offset: 0x00003AC0
		protected BillingClientBridgeCommon(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00007EA0 File Offset: 0x000060A0
		[Register(".ctor", "(Ljava/lang/Object;Ljava/util/Map;)V", "")]
		public unsafe BillingClientBridgeCommon(Java.Lang.Object billingClientInternalInstance, IDictionary<string, Class[]> functionAndParameters) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JavaDictionary<string, Class[]>.ToLocalJniHandle(functionAndParameters);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((billingClientInternalInstance == null) ? IntPtr.Zero : billingClientInternalInstance.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				base.SetHandle(BillingClientBridgeCommon._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Object;Ljava/util/Map;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				BillingClientBridgeCommon._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Object;Ljava/util/Map;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(billingClientInternalInstance);
				GC.KeepAlive(functionAndParameters);
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x00007F74 File Offset: 0x00006174
		protected static Class ClassForBridge
		{
			[Register("getClassForBridge", "()Ljava/lang/Class;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Class>(BillingClientBridgeCommon._members.StaticMethods.InvokeObjectMethod("getClassForBridge.()Ljava/lang/Class;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00007FA5 File Offset: 0x000061A5
		private static Delegate GetGetClassNameHandler()
		{
			if (BillingClientBridgeCommon.cb_getClassName == null)
			{
				BillingClientBridgeCommon.cb_getClassName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(BillingClientBridgeCommon.n_GetClassName));
			}
			return BillingClientBridgeCommon.cb_getClassName;
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00007FC9 File Offset: 0x000061C9
		private static IntPtr n_GetClassName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<BillingClientBridgeCommon>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClassName);
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x00007FE0 File Offset: 0x000061E0
		protected override string ClassName
		{
			[Register("getClassName", "()Ljava/lang/String;", "GetGetClassNameHandler")]
			get
			{
				return JNIEnv.GetString(BillingClientBridgeCommon._members.InstanceMethods.InvokeVirtualObjectMethod("getClassName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00008012 File Offset: 0x00006212
		private static Delegate GetIsReadyHandler()
		{
			if (BillingClientBridgeCommon.cb_isReady == null)
			{
				BillingClientBridgeCommon.cb_isReady = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(BillingClientBridgeCommon.n_IsReady));
			}
			return BillingClientBridgeCommon.cb_isReady;
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00008036 File Offset: 0x00006236
		private static bool n_IsReady(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BillingClientBridgeCommon>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsReady;
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x00008045 File Offset: 0x00006245
		public virtual bool IsReady
		{
			[Register("isReady", "()Z", "GetIsReadyHandler")]
			get
			{
				return BillingClientBridgeCommon._members.InstanceMethods.InvokeVirtualBooleanMethod("isReady.()Z", this, null);
			}
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00008060 File Offset: 0x00006260
		[Register("callNonVoidStaticMethod", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public unsafe static Java.Lang.Object CallNonVoidStaticMethod(string methodName, params Java.Lang.Object[] parameters)
		{
			IntPtr intPtr = JNIEnv.NewString(methodName);
			IntPtr intPtr2 = JNIEnv.NewArray<Java.Lang.Object>(parameters);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(BillingClientBridgeCommon._members.StaticMethods.InvokeObjectMethod("callNonVoidStaticMethod.(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (parameters != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr2, parameters);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(parameters);
			}
			return @object;
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x000080FC File Offset: 0x000062FC
		private static Delegate GetEndConnectionHandler()
		{
			if (BillingClientBridgeCommon.cb_endConnection == null)
			{
				BillingClientBridgeCommon.cb_endConnection = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(BillingClientBridgeCommon.n_EndConnection));
			}
			return BillingClientBridgeCommon.cb_endConnection;
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00008120 File Offset: 0x00006320
		private static void n_EndConnection(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<BillingClientBridgeCommon>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).EndConnection();
		}

		// Token: 0x060002EA RID: 746 RVA: 0x0000812F File Offset: 0x0000632F
		[Register("endConnection", "()V", "GetEndConnectionHandler")]
		public virtual void EndConnection()
		{
			BillingClientBridgeCommon._members.InstanceMethods.InvokeVirtualVoidMethod("endConnection.()V", this, null);
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00008148 File Offset: 0x00006348
		private static Delegate GetIsFeatureSupported_Ljava_lang_String_Handler()
		{
			if (BillingClientBridgeCommon.cb_isFeatureSupported_Ljava_lang_String_ == null)
			{
				BillingClientBridgeCommon.cb_isFeatureSupported_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(BillingClientBridgeCommon.n_IsFeatureSupported_Ljava_lang_String_));
			}
			return BillingClientBridgeCommon.cb_isFeatureSupported_Ljava_lang_String_;
		}

		// Token: 0x060002EC RID: 748 RVA: 0x0000816C File Offset: 0x0000636C
		private static IntPtr n_IsFeatureSupported_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_purchaseType)
		{
			BillingClientBridgeCommon @object = Java.Lang.Object.GetObject<BillingClientBridgeCommon>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_purchaseType, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.IsFeatureSupported(@string));
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00008194 File Offset: 0x00006394
		[Register("isFeatureSupported", "(Ljava/lang/String;)Lcom/unity3d/services/store/gpbl/BillingResultResponseCode;", "GetIsFeatureSupported_Ljava_lang_String_Handler")]
		public unsafe virtual BillingResultResponseCode IsFeatureSupported(string purchaseType)
		{
			IntPtr intPtr = JNIEnv.NewString(purchaseType);
			BillingResultResponseCode @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<BillingResultResponseCode>(BillingClientBridgeCommon._members.InstanceMethods.InvokeVirtualObjectMethod("isFeatureSupported.(Ljava/lang/String;)Lcom/unity3d/services/store/gpbl/BillingResultResponseCode;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00008200 File Offset: 0x00006400
		private static Delegate GetQueryPurchaseHistoryAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchaseHistoryResponseListenerProxy_Handler()
		{
			if (BillingClientBridgeCommon.cb_queryPurchaseHistoryAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchaseHistoryResponseListenerProxy_ == null)
			{
				BillingClientBridgeCommon.cb_queryPurchaseHistoryAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchaseHistoryResponseListenerProxy_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(BillingClientBridgeCommon.n_QueryPurchaseHistoryAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchaseHistoryResponseListenerProxy_));
			}
			return BillingClientBridgeCommon.cb_queryPurchaseHistoryAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchaseHistoryResponseListenerProxy_;
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00008224 File Offset: 0x00006424
		private static void n_QueryPurchaseHistoryAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchaseHistoryResponseListenerProxy_(IntPtr jnienv, IntPtr native__this, IntPtr native_skuType, IntPtr native_purchaseHistoryResponseListenerProxy)
		{
			BillingClientBridgeCommon @object = Java.Lang.Object.GetObject<BillingClientBridgeCommon>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_skuType, JniHandleOwnership.DoNotTransfer);
			PurchaseHistoryResponseListenerProxy object2 = Java.Lang.Object.GetObject<PurchaseHistoryResponseListenerProxy>(native_purchaseHistoryResponseListenerProxy, JniHandleOwnership.DoNotTransfer);
			@object.QueryPurchaseHistoryAsync(@string, object2);
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00008250 File Offset: 0x00006450
		[Register("queryPurchaseHistoryAsync", "(Ljava/lang/String;Lcom/unity3d/services/store/gpbl/proxies/PurchaseHistoryResponseListenerProxy;)V", "GetQueryPurchaseHistoryAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchaseHistoryResponseListenerProxy_Handler")]
		public unsafe virtual void QueryPurchaseHistoryAsync(string skuType, PurchaseHistoryResponseListenerProxy purchaseHistoryResponseListenerProxy)
		{
			IntPtr intPtr = JNIEnv.NewString(skuType);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((purchaseHistoryResponseListenerProxy == null) ? IntPtr.Zero : purchaseHistoryResponseListenerProxy.Handle);
				BillingClientBridgeCommon._members.InstanceMethods.InvokeVirtualVoidMethod("queryPurchaseHistoryAsync.(Ljava/lang/String;Lcom/unity3d/services/store/gpbl/proxies/PurchaseHistoryResponseListenerProxy;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(purchaseHistoryResponseListenerProxy);
			}
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x000082D4 File Offset: 0x000064D4
		private static Delegate GetQuerySkuDetailsAsync_Lcom_unity3d_services_store_gpbl_bridges_SkuDetailsParamsBridge_Lcom_unity3d_services_store_gpbl_proxies_SkuDetailsResponseListenerProxy_Handler()
		{
			if (BillingClientBridgeCommon.cb_querySkuDetailsAsync_Lcom_unity3d_services_store_gpbl_bridges_SkuDetailsParamsBridge_Lcom_unity3d_services_store_gpbl_proxies_SkuDetailsResponseListenerProxy_ == null)
			{
				BillingClientBridgeCommon.cb_querySkuDetailsAsync_Lcom_unity3d_services_store_gpbl_bridges_SkuDetailsParamsBridge_Lcom_unity3d_services_store_gpbl_proxies_SkuDetailsResponseListenerProxy_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(BillingClientBridgeCommon.n_QuerySkuDetailsAsync_Lcom_unity3d_services_store_gpbl_bridges_SkuDetailsParamsBridge_Lcom_unity3d_services_store_gpbl_proxies_SkuDetailsResponseListenerProxy_));
			}
			return BillingClientBridgeCommon.cb_querySkuDetailsAsync_Lcom_unity3d_services_store_gpbl_bridges_SkuDetailsParamsBridge_Lcom_unity3d_services_store_gpbl_proxies_SkuDetailsResponseListenerProxy_;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x000082F8 File Offset: 0x000064F8
		private static void n_QuerySkuDetailsAsync_Lcom_unity3d_services_store_gpbl_bridges_SkuDetailsParamsBridge_Lcom_unity3d_services_store_gpbl_proxies_SkuDetailsResponseListenerProxy_(IntPtr jnienv, IntPtr native__this, IntPtr native__params, IntPtr native_skuDetailsResponseListenerProxy)
		{
			BillingClientBridgeCommon @object = Java.Lang.Object.GetObject<BillingClientBridgeCommon>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			SkuDetailsParamsBridge object2 = Java.Lang.Object.GetObject<SkuDetailsParamsBridge>(native__params, JniHandleOwnership.DoNotTransfer);
			SkuDetailsResponseListenerProxy object3 = Java.Lang.Object.GetObject<SkuDetailsResponseListenerProxy>(native_skuDetailsResponseListenerProxy, JniHandleOwnership.DoNotTransfer);
			@object.QuerySkuDetailsAsync(object2, object3);
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00008324 File Offset: 0x00006524
		[Register("querySkuDetailsAsync", "(Lcom/unity3d/services/store/gpbl/bridges/SkuDetailsParamsBridge;Lcom/unity3d/services/store/gpbl/proxies/SkuDetailsResponseListenerProxy;)V", "GetQuerySkuDetailsAsync_Lcom_unity3d_services_store_gpbl_bridges_SkuDetailsParamsBridge_Lcom_unity3d_services_store_gpbl_proxies_SkuDetailsResponseListenerProxy_Handler")]
		public unsafe virtual void QuerySkuDetailsAsync(SkuDetailsParamsBridge @params, SkuDetailsResponseListenerProxy skuDetailsResponseListenerProxy)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((@params == null) ? IntPtr.Zero : @params.Handle);
				ptr[1] = new JniArgumentValue((skuDetailsResponseListenerProxy == null) ? IntPtr.Zero : skuDetailsResponseListenerProxy.Handle);
				BillingClientBridgeCommon._members.InstanceMethods.InvokeVirtualVoidMethod("querySkuDetailsAsync.(Lcom/unity3d/services/store/gpbl/bridges/SkuDetailsParamsBridge;Lcom/unity3d/services/store/gpbl/proxies/SkuDetailsResponseListenerProxy;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(@params);
				GC.KeepAlive(skuDetailsResponseListenerProxy);
			}
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x000083B0 File Offset: 0x000065B0
		private static Delegate GetStartConnection_Lcom_unity3d_services_store_gpbl_proxies_BillingClientStateListenerProxy_Handler()
		{
			if (BillingClientBridgeCommon.cb_startConnection_Lcom_unity3d_services_store_gpbl_proxies_BillingClientStateListenerProxy_ == null)
			{
				BillingClientBridgeCommon.cb_startConnection_Lcom_unity3d_services_store_gpbl_proxies_BillingClientStateListenerProxy_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(BillingClientBridgeCommon.n_StartConnection_Lcom_unity3d_services_store_gpbl_proxies_BillingClientStateListenerProxy_));
			}
			return BillingClientBridgeCommon.cb_startConnection_Lcom_unity3d_services_store_gpbl_proxies_BillingClientStateListenerProxy_;
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x000083D4 File Offset: 0x000065D4
		private static void n_StartConnection_Lcom_unity3d_services_store_gpbl_proxies_BillingClientStateListenerProxy_(IntPtr jnienv, IntPtr native__this, IntPtr native_billingClientStateListenerProxy)
		{
			BillingClientBridgeCommon @object = Java.Lang.Object.GetObject<BillingClientBridgeCommon>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			BillingClientStateListenerProxy object2 = Java.Lang.Object.GetObject<BillingClientStateListenerProxy>(native_billingClientStateListenerProxy, JniHandleOwnership.DoNotTransfer);
			@object.StartConnection(object2);
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x000083F8 File Offset: 0x000065F8
		[Register("startConnection", "(Lcom/unity3d/services/store/gpbl/proxies/BillingClientStateListenerProxy;)V", "GetStartConnection_Lcom_unity3d_services_store_gpbl_proxies_BillingClientStateListenerProxy_Handler")]
		public unsafe virtual void StartConnection(BillingClientStateListenerProxy billingClientStateListenerProxy)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((billingClientStateListenerProxy == null) ? IntPtr.Zero : billingClientStateListenerProxy.Handle);
				BillingClientBridgeCommon._members.InstanceMethods.InvokeVirtualVoidMethod("startConnection.(Lcom/unity3d/services/store/gpbl/proxies/BillingClientStateListenerProxy;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(billingClientStateListenerProxy);
			}
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0000845C File Offset: 0x0000665C
		private static Delegate GetQueryPurchasesAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchasesResponseListenerProxy_Handler()
		{
			if (BillingClientBridgeCommon.cb_queryPurchasesAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchasesResponseListenerProxy_ == null)
			{
				BillingClientBridgeCommon.cb_queryPurchasesAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchasesResponseListenerProxy_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(BillingClientBridgeCommon.n_QueryPurchasesAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchasesResponseListenerProxy_));
			}
			return BillingClientBridgeCommon.cb_queryPurchasesAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchasesResponseListenerProxy_;
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00008480 File Offset: 0x00006680
		private static void n_QueryPurchasesAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchasesResponseListenerProxy_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			BillingClientBridgeCommon @object = Java.Lang.Object.GetObject<BillingClientBridgeCommon>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			PurchasesResponseListenerProxy object2 = Java.Lang.Object.GetObject<PurchasesResponseListenerProxy>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.QueryPurchasesAsync(@string, object2);
		}

		// Token: 0x060002F9 RID: 761
		[Register("queryPurchasesAsync", "(Ljava/lang/String;Lcom/unity3d/services/store/gpbl/proxies/PurchasesResponseListenerProxy;)V", "GetQueryPurchasesAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchasesResponseListenerProxy_Handler")]
		public abstract void QueryPurchasesAsync(string p0, PurchasesResponseListenerProxy p1);

		// Token: 0x04000082 RID: 130
		[Register("endConnectionMethodName")]
		protected const string EndConnectionMethodName = "endConnection";

		// Token: 0x04000083 RID: 131
		[Register("isFeatureSupportedMethodName")]
		protected const string IsFeatureSupportedMethodName = "isFeatureSupported";

		// Token: 0x04000084 RID: 132
		[Register("isReadyMethodName")]
		protected const string IsReadyMethodName = "isReady";

		// Token: 0x04000085 RID: 133
		[Register("newBuilderMethodName")]
		protected const string NewBuilderMethodName = "newBuilder";

		// Token: 0x04000086 RID: 134
		[Register("queryPurchaseHistoryAsyncMethodName")]
		protected const string QueryPurchaseHistoryAsyncMethodName = "queryPurchaseHistoryAsync";

		// Token: 0x04000087 RID: 135
		[Register("querySkuDetailsAsyncMethodName")]
		protected const string QuerySkuDetailsAsyncMethodName = "querySkuDetailsAsync";

		// Token: 0x04000088 RID: 136
		[Register("startConnectionMethodName")]
		protected const string StartConnectionMethodName = "startConnection";

		// Token: 0x04000089 RID: 137
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/store/gpbl/bridges/billingclient/common/BillingClientBridgeCommon", typeof(BillingClientBridgeCommon));

		// Token: 0x0400008A RID: 138
		private static Delegate cb_getClassName;

		// Token: 0x0400008B RID: 139
		private static Delegate cb_isReady;

		// Token: 0x0400008C RID: 140
		private static Delegate cb_endConnection;

		// Token: 0x0400008D RID: 141
		private static Delegate cb_isFeatureSupported_Ljava_lang_String_;

		// Token: 0x0400008E RID: 142
		private static Delegate cb_queryPurchaseHistoryAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchaseHistoryResponseListenerProxy_;

		// Token: 0x0400008F RID: 143
		private static Delegate cb_querySkuDetailsAsync_Lcom_unity3d_services_store_gpbl_bridges_SkuDetailsParamsBridge_Lcom_unity3d_services_store_gpbl_proxies_SkuDetailsResponseListenerProxy_;

		// Token: 0x04000090 RID: 144
		private static Delegate cb_startConnection_Lcom_unity3d_services_store_gpbl_proxies_BillingClientStateListenerProxy_;

		// Token: 0x04000091 RID: 145
		private static Delegate cb_queryPurchasesAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchasesResponseListenerProxy_;
	}
}
