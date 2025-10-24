using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Com.Unity3d.Services.Store.Listeners;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Store.Gpbl
{
	// Token: 0x0200004C RID: 76
	[Register("com/unity3d/services/store/gpbl/StoreBilling", DoNotGenerateAcw = true)]
	public class StoreBilling : Java.Lang.Object
	{
		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600019E RID: 414 RVA: 0x000045E8 File Offset: 0x000027E8
		internal static IntPtr class_ref
		{
			get
			{
				return StoreBilling._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600019F RID: 415 RVA: 0x0000460C File Offset: 0x0000280C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return StoreBilling._members;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x00004614 File Offset: 0x00002814
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return StoreBilling._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x00004638 File Offset: 0x00002838
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return StoreBilling._members.ManagedPeerType;
			}
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x000021E8 File Offset: 0x000003E8
		protected StoreBilling(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00004644 File Offset: 0x00002844
		[Register(".ctor", "(Landroid/content/Context;Lcom/unity3d/services/store/listeners/IPurchaseUpdatedResponseListener;)V", "")]
		public unsafe StoreBilling(Context context, IPurchaseUpdatedResponseListener purchaseUpdatedResponseListener) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((purchaseUpdatedResponseListener == null) ? IntPtr.Zero : ((Java.Lang.Object)purchaseUpdatedResponseListener).Handle);
				base.SetHandle(StoreBilling._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Lcom/unity3d/services/store/listeners/IPurchaseUpdatedResponseListener;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				StoreBilling._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Lcom/unity3d/services/store/listeners/IPurchaseUpdatedResponseListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(purchaseUpdatedResponseListener);
			}
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00004720 File Offset: 0x00002920
		private static Delegate GetGetPurchaseHistory_Ljava_lang_String_ILcom_unity3d_services_store_listeners_IPurchaseHistoryResponseListener_Handler()
		{
			if (StoreBilling.cb_getPurchaseHistory_Ljava_lang_String_ILcom_unity3d_services_store_listeners_IPurchaseHistoryResponseListener_ == null)
			{
				StoreBilling.cb_getPurchaseHistory_Ljava_lang_String_ILcom_unity3d_services_store_listeners_IPurchaseHistoryResponseListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIL_V(StoreBilling.n_GetPurchaseHistory_Ljava_lang_String_ILcom_unity3d_services_store_listeners_IPurchaseHistoryResponseListener_));
			}
			return StoreBilling.cb_getPurchaseHistory_Ljava_lang_String_ILcom_unity3d_services_store_listeners_IPurchaseHistoryResponseListener_;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00004744 File Offset: 0x00002944
		private static void n_GetPurchaseHistory_Ljava_lang_String_ILcom_unity3d_services_store_listeners_IPurchaseHistoryResponseListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_purchaseType, int maxPurchases, IntPtr native_purchaseHistoryResponseListener)
		{
			StoreBilling @object = Java.Lang.Object.GetObject<StoreBilling>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_purchaseType, JniHandleOwnership.DoNotTransfer);
			IPurchaseHistoryResponseListener object2 = Java.Lang.Object.GetObject<IPurchaseHistoryResponseListener>(native_purchaseHistoryResponseListener, JniHandleOwnership.DoNotTransfer);
			@object.GetPurchaseHistory(@string, maxPurchases, object2);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00004774 File Offset: 0x00002974
		[Register("getPurchaseHistory", "(Ljava/lang/String;ILcom/unity3d/services/store/listeners/IPurchaseHistoryResponseListener;)V", "GetGetPurchaseHistory_Ljava_lang_String_ILcom_unity3d_services_store_listeners_IPurchaseHistoryResponseListener_Handler")]
		public unsafe virtual void GetPurchaseHistory(string purchaseType, int maxPurchases, IPurchaseHistoryResponseListener purchaseHistoryResponseListener)
		{
			IntPtr intPtr = JNIEnv.NewString(purchaseType);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(maxPurchases);
				ptr[2] = new JniArgumentValue((purchaseHistoryResponseListener == null) ? IntPtr.Zero : ((Java.Lang.Object)purchaseHistoryResponseListener).Handle);
				StoreBilling._members.InstanceMethods.InvokeVirtualVoidMethod("getPurchaseHistory.(Ljava/lang/String;ILcom/unity3d/services/store/listeners/IPurchaseHistoryResponseListener;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(purchaseHistoryResponseListener);
			}
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00004814 File Offset: 0x00002A14
		private static Delegate GetGetPurchases_Ljava_lang_String_Lcom_unity3d_services_store_listeners_IPurchasesResponseListener_Handler()
		{
			if (StoreBilling.cb_getPurchases_Ljava_lang_String_Lcom_unity3d_services_store_listeners_IPurchasesResponseListener_ == null)
			{
				StoreBilling.cb_getPurchases_Ljava_lang_String_Lcom_unity3d_services_store_listeners_IPurchasesResponseListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(StoreBilling.n_GetPurchases_Ljava_lang_String_Lcom_unity3d_services_store_listeners_IPurchasesResponseListener_));
			}
			return StoreBilling.cb_getPurchases_Ljava_lang_String_Lcom_unity3d_services_store_listeners_IPurchasesResponseListener_;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00004838 File Offset: 0x00002A38
		private static void n_GetPurchases_Ljava_lang_String_Lcom_unity3d_services_store_listeners_IPurchasesResponseListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_purchaseType, IntPtr native_purchasesResponseListener)
		{
			StoreBilling @object = Java.Lang.Object.GetObject<StoreBilling>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_purchaseType, JniHandleOwnership.DoNotTransfer);
			IPurchasesResponseListener object2 = Java.Lang.Object.GetObject<IPurchasesResponseListener>(native_purchasesResponseListener, JniHandleOwnership.DoNotTransfer);
			@object.GetPurchases(@string, object2);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00004864 File Offset: 0x00002A64
		[Register("getPurchases", "(Ljava/lang/String;Lcom/unity3d/services/store/listeners/IPurchasesResponseListener;)V", "GetGetPurchases_Ljava_lang_String_Lcom_unity3d_services_store_listeners_IPurchasesResponseListener_Handler")]
		public unsafe virtual void GetPurchases(string purchaseType, IPurchasesResponseListener purchasesResponseListener)
		{
			IntPtr intPtr = JNIEnv.NewString(purchaseType);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((purchasesResponseListener == null) ? IntPtr.Zero : ((Java.Lang.Object)purchasesResponseListener).Handle);
				StoreBilling._members.InstanceMethods.InvokeVirtualVoidMethod("getPurchases.(Ljava/lang/String;Lcom/unity3d/services/store/listeners/IPurchasesResponseListener;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(purchasesResponseListener);
			}
		}

		// Token: 0x060001AA RID: 426 RVA: 0x000048EC File Offset: 0x00002AEC
		private static Delegate GetGetSkuDetails_Ljava_lang_String_Ljava_util_ArrayList_Lcom_unity3d_services_store_listeners_ISkuDetailsResponseListener_Handler()
		{
			if (StoreBilling.cb_getSkuDetails_Ljava_lang_String_Ljava_util_ArrayList_Lcom_unity3d_services_store_listeners_ISkuDetailsResponseListener_ == null)
			{
				StoreBilling.cb_getSkuDetails_Ljava_lang_String_Ljava_util_ArrayList_Lcom_unity3d_services_store_listeners_ISkuDetailsResponseListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(StoreBilling.n_GetSkuDetails_Ljava_lang_String_Ljava_util_ArrayList_Lcom_unity3d_services_store_listeners_ISkuDetailsResponseListener_));
			}
			return StoreBilling.cb_getSkuDetails_Ljava_lang_String_Ljava_util_ArrayList_Lcom_unity3d_services_store_listeners_ISkuDetailsResponseListener_;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00004910 File Offset: 0x00002B10
		private static void n_GetSkuDetails_Ljava_lang_String_Ljava_util_ArrayList_Lcom_unity3d_services_store_listeners_ISkuDetailsResponseListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_purchaseType, IntPtr native_skuList, IntPtr native_skuDetailsResponseListener)
		{
			StoreBilling @object = Java.Lang.Object.GetObject<StoreBilling>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_purchaseType, JniHandleOwnership.DoNotTransfer);
			IList<string> skuList = JavaList<string>.FromJniHandle(native_skuList, JniHandleOwnership.DoNotTransfer);
			ISkuDetailsResponseListener object2 = Java.Lang.Object.GetObject<ISkuDetailsResponseListener>(native_skuDetailsResponseListener, JniHandleOwnership.DoNotTransfer);
			@object.GetSkuDetails(@string, skuList, object2);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00004948 File Offset: 0x00002B48
		[Register("getSkuDetails", "(Ljava/lang/String;Ljava/util/ArrayList;Lcom/unity3d/services/store/listeners/ISkuDetailsResponseListener;)V", "GetGetSkuDetails_Ljava_lang_String_Ljava_util_ArrayList_Lcom_unity3d_services_store_listeners_ISkuDetailsResponseListener_Handler")]
		public unsafe virtual void GetSkuDetails(string purchaseType, IList<string> skuList, ISkuDetailsResponseListener skuDetailsResponseListener)
		{
			IntPtr intPtr = JNIEnv.NewString(purchaseType);
			IntPtr intPtr2 = JavaList<string>.ToLocalJniHandle(skuList);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((skuDetailsResponseListener == null) ? IntPtr.Zero : ((Java.Lang.Object)skuDetailsResponseListener).Handle);
				StoreBilling._members.InstanceMethods.InvokeVirtualVoidMethod("getSkuDetails.(Ljava/lang/String;Ljava/util/ArrayList;Lcom/unity3d/services/store/listeners/ISkuDetailsResponseListener;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(skuList);
				GC.KeepAlive(skuDetailsResponseListener);
			}
		}

		// Token: 0x060001AD RID: 429 RVA: 0x000049FC File Offset: 0x00002BFC
		private static Delegate GetInitialize_Lcom_unity3d_services_store_gpbl_IBillingClientStateListener_Handler()
		{
			if (StoreBilling.cb_initialize_Lcom_unity3d_services_store_gpbl_IBillingClientStateListener_ == null)
			{
				StoreBilling.cb_initialize_Lcom_unity3d_services_store_gpbl_IBillingClientStateListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(StoreBilling.n_Initialize_Lcom_unity3d_services_store_gpbl_IBillingClientStateListener_));
			}
			return StoreBilling.cb_initialize_Lcom_unity3d_services_store_gpbl_IBillingClientStateListener_;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00004A20 File Offset: 0x00002C20
		private static void n_Initialize_Lcom_unity3d_services_store_gpbl_IBillingClientStateListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_billingClientStateListener)
		{
			StoreBilling @object = Java.Lang.Object.GetObject<StoreBilling>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IBillingClientStateListener object2 = Java.Lang.Object.GetObject<IBillingClientStateListener>(native_billingClientStateListener, JniHandleOwnership.DoNotTransfer);
			@object.Initialize(object2);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00004A44 File Offset: 0x00002C44
		[Register("initialize", "(Lcom/unity3d/services/store/gpbl/IBillingClientStateListener;)V", "GetInitialize_Lcom_unity3d_services_store_gpbl_IBillingClientStateListener_Handler")]
		public unsafe virtual void Initialize(IBillingClientStateListener billingClientStateListener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((billingClientStateListener == null) ? IntPtr.Zero : ((Java.Lang.Object)billingClientStateListener).Handle);
				StoreBilling._members.InstanceMethods.InvokeVirtualVoidMethod("initialize.(Lcom/unity3d/services/store/gpbl/IBillingClientStateListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(billingClientStateListener);
			}
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00004AAC File Offset: 0x00002CAC
		private static Delegate GetIsFeatureSupported_Ljava_lang_String_Handler()
		{
			if (StoreBilling.cb_isFeatureSupported_Ljava_lang_String_ == null)
			{
				StoreBilling.cb_isFeatureSupported_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(StoreBilling.n_IsFeatureSupported_Ljava_lang_String_));
			}
			return StoreBilling.cb_isFeatureSupported_Ljava_lang_String_;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00004AD0 File Offset: 0x00002CD0
		private static int n_IsFeatureSupported_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_purchaseType)
		{
			StoreBilling @object = Java.Lang.Object.GetObject<StoreBilling>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_purchaseType, JniHandleOwnership.DoNotTransfer);
			return @object.IsFeatureSupported(@string);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00004AF4 File Offset: 0x00002CF4
		[Register("isFeatureSupported", "(Ljava/lang/String;)I", "GetIsFeatureSupported_Ljava_lang_String_Handler")]
		public unsafe virtual int IsFeatureSupported(string purchaseType)
		{
			IntPtr intPtr = JNIEnv.NewString(purchaseType);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = StoreBilling._members.InstanceMethods.InvokeVirtualInt32Method("isFeatureSupported.(Ljava/lang/String;)I", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x04000034 RID: 52
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/store/gpbl/StoreBilling", typeof(StoreBilling));

		// Token: 0x04000035 RID: 53
		private static Delegate cb_getPurchaseHistory_Ljava_lang_String_ILcom_unity3d_services_store_listeners_IPurchaseHistoryResponseListener_;

		// Token: 0x04000036 RID: 54
		private static Delegate cb_getPurchases_Ljava_lang_String_Lcom_unity3d_services_store_listeners_IPurchasesResponseListener_;

		// Token: 0x04000037 RID: 55
		private static Delegate cb_getSkuDetails_Ljava_lang_String_Ljava_util_ArrayList_Lcom_unity3d_services_store_listeners_ISkuDetailsResponseListener_;

		// Token: 0x04000038 RID: 56
		private static Delegate cb_initialize_Lcom_unity3d_services_store_gpbl_IBillingClientStateListener_;

		// Token: 0x04000039 RID: 57
		private static Delegate cb_isFeatureSupported_Ljava_lang_String_;
	}
}
