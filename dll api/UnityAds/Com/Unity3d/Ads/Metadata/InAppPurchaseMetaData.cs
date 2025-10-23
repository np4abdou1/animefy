using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Ads.Metadata
{
	// Token: 0x020002DF RID: 735
	[Register("com/unity3d/ads/metadata/InAppPurchaseMetaData", DoNotGenerateAcw = true)]
	public class InAppPurchaseMetaData : MetaData
	{
		// Token: 0x17000F6D RID: 3949
		// (get) Token: 0x060028BA RID: 10426 RVA: 0x00069570 File Offset: 0x00067770
		internal new static IntPtr class_ref
		{
			get
			{
				return InAppPurchaseMetaData._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000F6E RID: 3950
		// (get) Token: 0x060028BB RID: 10427 RVA: 0x00069594 File Offset: 0x00067794
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return InAppPurchaseMetaData._members;
			}
		}

		// Token: 0x17000F6F RID: 3951
		// (get) Token: 0x060028BC RID: 10428 RVA: 0x0006959C File Offset: 0x0006779C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return InAppPurchaseMetaData._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000F70 RID: 3952
		// (get) Token: 0x060028BD RID: 10429 RVA: 0x000695C0 File Offset: 0x000677C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return InAppPurchaseMetaData._members.ManagedPeerType;
			}
		}

		// Token: 0x060028BE RID: 10430 RVA: 0x000695CC File Offset: 0x000677CC
		protected InAppPurchaseMetaData(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060028BF RID: 10431 RVA: 0x000695D8 File Offset: 0x000677D8
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe InAppPurchaseMetaData(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(InAppPurchaseMetaData._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				InAppPurchaseMetaData._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x060028C0 RID: 10432 RVA: 0x00069688 File Offset: 0x00067888
		private static Delegate GetSetCurrency_Ljava_lang_String_Handler()
		{
			if (InAppPurchaseMetaData.cb_setCurrency_Ljava_lang_String_ == null)
			{
				InAppPurchaseMetaData.cb_setCurrency_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(InAppPurchaseMetaData.n_SetCurrency_Ljava_lang_String_));
			}
			return InAppPurchaseMetaData.cb_setCurrency_Ljava_lang_String_;
		}

		// Token: 0x060028C1 RID: 10433 RVA: 0x000696AC File Offset: 0x000678AC
		private static void n_SetCurrency_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_currency)
		{
			InAppPurchaseMetaData @object = Java.Lang.Object.GetObject<InAppPurchaseMetaData>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_currency, JniHandleOwnership.DoNotTransfer);
			@object.SetCurrency(@string);
		}

		// Token: 0x060028C2 RID: 10434 RVA: 0x000696D0 File Offset: 0x000678D0
		[Register("setCurrency", "(Ljava/lang/String;)V", "GetSetCurrency_Ljava_lang_String_Handler")]
		public unsafe virtual void SetCurrency(string currency)
		{
			IntPtr intPtr = JNIEnv.NewString(currency);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				InAppPurchaseMetaData._members.InstanceMethods.InvokeVirtualVoidMethod("setCurrency.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060028C3 RID: 10435 RVA: 0x0006972C File Offset: 0x0006792C
		private static Delegate GetSetPrice_Ljava_lang_Double_Handler()
		{
			if (InAppPurchaseMetaData.cb_setPrice_Ljava_lang_Double_ == null)
			{
				InAppPurchaseMetaData.cb_setPrice_Ljava_lang_Double_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(InAppPurchaseMetaData.n_SetPrice_Ljava_lang_Double_));
			}
			return InAppPurchaseMetaData.cb_setPrice_Ljava_lang_Double_;
		}

		// Token: 0x060028C4 RID: 10436 RVA: 0x00069750 File Offset: 0x00067950
		private static void n_SetPrice_Ljava_lang_Double_(IntPtr jnienv, IntPtr native__this, IntPtr native_price)
		{
			InAppPurchaseMetaData @object = Java.Lang.Object.GetObject<InAppPurchaseMetaData>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Double object2 = Java.Lang.Object.GetObject<Java.Lang.Double>(native_price, JniHandleOwnership.DoNotTransfer);
			@object.SetPrice(object2);
		}

		// Token: 0x060028C5 RID: 10437 RVA: 0x00069774 File Offset: 0x00067974
		[Register("setPrice", "(Ljava/lang/Double;)V", "GetSetPrice_Ljava_lang_Double_Handler")]
		public unsafe virtual void SetPrice(Java.Lang.Double price)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((price == null) ? IntPtr.Zero : price.Handle);
				InAppPurchaseMetaData._members.InstanceMethods.InvokeVirtualVoidMethod("setPrice.(Ljava/lang/Double;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(price);
			}
		}

		// Token: 0x060028C6 RID: 10438 RVA: 0x000697D8 File Offset: 0x000679D8
		private static Delegate GetSetProductId_Ljava_lang_String_Handler()
		{
			if (InAppPurchaseMetaData.cb_setProductId_Ljava_lang_String_ == null)
			{
				InAppPurchaseMetaData.cb_setProductId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(InAppPurchaseMetaData.n_SetProductId_Ljava_lang_String_));
			}
			return InAppPurchaseMetaData.cb_setProductId_Ljava_lang_String_;
		}

		// Token: 0x060028C7 RID: 10439 RVA: 0x000697FC File Offset: 0x000679FC
		private static void n_SetProductId_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_productId)
		{
			InAppPurchaseMetaData @object = Java.Lang.Object.GetObject<InAppPurchaseMetaData>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_productId, JniHandleOwnership.DoNotTransfer);
			@object.SetProductId(@string);
		}

		// Token: 0x060028C8 RID: 10440 RVA: 0x00069820 File Offset: 0x00067A20
		[Register("setProductId", "(Ljava/lang/String;)V", "GetSetProductId_Ljava_lang_String_Handler")]
		public unsafe virtual void SetProductId(string productId)
		{
			IntPtr intPtr = JNIEnv.NewString(productId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				InAppPurchaseMetaData._members.InstanceMethods.InvokeVirtualVoidMethod("setProductId.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060028C9 RID: 10441 RVA: 0x0006987C File Offset: 0x00067A7C
		private static Delegate GetSetReceiptPurchaseData_Ljava_lang_String_Handler()
		{
			if (InAppPurchaseMetaData.cb_setReceiptPurchaseData_Ljava_lang_String_ == null)
			{
				InAppPurchaseMetaData.cb_setReceiptPurchaseData_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(InAppPurchaseMetaData.n_SetReceiptPurchaseData_Ljava_lang_String_));
			}
			return InAppPurchaseMetaData.cb_setReceiptPurchaseData_Ljava_lang_String_;
		}

		// Token: 0x060028CA RID: 10442 RVA: 0x000698A0 File Offset: 0x00067AA0
		private static void n_SetReceiptPurchaseData_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_receiptPurchaseData)
		{
			InAppPurchaseMetaData @object = Java.Lang.Object.GetObject<InAppPurchaseMetaData>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_receiptPurchaseData, JniHandleOwnership.DoNotTransfer);
			@object.SetReceiptPurchaseData(@string);
		}

		// Token: 0x060028CB RID: 10443 RVA: 0x000698C4 File Offset: 0x00067AC4
		[Register("setReceiptPurchaseData", "(Ljava/lang/String;)V", "GetSetReceiptPurchaseData_Ljava_lang_String_Handler")]
		public unsafe virtual void SetReceiptPurchaseData(string receiptPurchaseData)
		{
			IntPtr intPtr = JNIEnv.NewString(receiptPurchaseData);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				InAppPurchaseMetaData._members.InstanceMethods.InvokeVirtualVoidMethod("setReceiptPurchaseData.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060028CC RID: 10444 RVA: 0x00069920 File Offset: 0x00067B20
		private static Delegate GetSetSignature_Ljava_lang_String_Handler()
		{
			if (InAppPurchaseMetaData.cb_setSignature_Ljava_lang_String_ == null)
			{
				InAppPurchaseMetaData.cb_setSignature_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(InAppPurchaseMetaData.n_SetSignature_Ljava_lang_String_));
			}
			return InAppPurchaseMetaData.cb_setSignature_Ljava_lang_String_;
		}

		// Token: 0x060028CD RID: 10445 RVA: 0x00069944 File Offset: 0x00067B44
		private static void n_SetSignature_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_signature)
		{
			InAppPurchaseMetaData @object = Java.Lang.Object.GetObject<InAppPurchaseMetaData>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_signature, JniHandleOwnership.DoNotTransfer);
			@object.SetSignature(@string);
		}

		// Token: 0x060028CE RID: 10446 RVA: 0x00069968 File Offset: 0x00067B68
		[Register("setSignature", "(Ljava/lang/String;)V", "GetSetSignature_Ljava_lang_String_Handler")]
		public unsafe virtual void SetSignature(string signature)
		{
			IntPtr intPtr = JNIEnv.NewString(signature);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				InAppPurchaseMetaData._members.InstanceMethods.InvokeVirtualVoidMethod("setSignature.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x04000846 RID: 2118
		[Register("IAP_KEY")]
		public const string IapKey = "iap";

		// Token: 0x04000847 RID: 2119
		[Register("KEY_CURRENCY")]
		public const string KeyCurrency = "currency";

		// Token: 0x04000848 RID: 2120
		[Register("KEY_PRICE")]
		public const string KeyPrice = "price";

		// Token: 0x04000849 RID: 2121
		[Register("KEY_PRODUCT_ID")]
		public const string KeyProductId = "productId";

		// Token: 0x0400084A RID: 2122
		[Register("KEY_RECEIPT_PURCHASE_DATA")]
		public const string KeyReceiptPurchaseData = "receiptPurchaseData";

		// Token: 0x0400084B RID: 2123
		[Register("KEY_SIGNATURE")]
		public const string KeySignature = "signature";

		// Token: 0x0400084C RID: 2124
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/ads/metadata/InAppPurchaseMetaData", typeof(InAppPurchaseMetaData));

		// Token: 0x0400084D RID: 2125
		private static Delegate cb_setCurrency_Ljava_lang_String_;

		// Token: 0x0400084E RID: 2126
		private static Delegate cb_setPrice_Ljava_lang_Double_;

		// Token: 0x0400084F RID: 2127
		private static Delegate cb_setProductId_Ljava_lang_String_;

		// Token: 0x04000850 RID: 2128
		private static Delegate cb_setReceiptPurchaseData_Ljava_lang_String_;

		// Token: 0x04000851 RID: 2129
		private static Delegate cb_setSignature_Ljava_lang_String_;
	}
}
