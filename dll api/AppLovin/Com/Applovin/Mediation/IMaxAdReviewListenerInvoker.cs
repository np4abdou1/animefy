using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Mediation
{
	// Token: 0x020000B0 RID: 176
	[Register("com/applovin/mediation/MaxAdReviewListener", DoNotGenerateAcw = true)]
	internal class IMaxAdReviewListenerInvoker : Java.Lang.Object, IMaxAdReviewListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060005F2 RID: 1522 RVA: 0x0000F560 File Offset: 0x0000D760
		private static IntPtr java_class_ref
		{
			get
			{
				return IMaxAdReviewListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x060005F3 RID: 1523 RVA: 0x0000F584 File Offset: 0x0000D784
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMaxAdReviewListenerInvoker._members;
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060005F4 RID: 1524 RVA: 0x0000F58B File Offset: 0x0000D78B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060005F5 RID: 1525 RVA: 0x0000F593 File Offset: 0x0000D793
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMaxAdReviewListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x0000F59F File Offset: 0x0000D79F
		public static IMaxAdReviewListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMaxAdReviewListener>(handle, transfer);
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x0000F5A8 File Offset: 0x0000D7A8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMaxAdReviewListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.mediation.MaxAdReviewListener'.");
			}
			return handle;
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x0000F5D3 File Offset: 0x0000D7D3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x0000F604 File Offset: 0x0000D804
		public IMaxAdReviewListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMaxAdReviewListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x0000F63C File Offset: 0x0000D83C
		private static Delegate GetOnCreativeIdGenerated_Ljava_lang_String_Lcom_applovin_mediation_MaxAd_Handler()
		{
			if (IMaxAdReviewListenerInvoker.cb_onCreativeIdGenerated_Ljava_lang_String_Lcom_applovin_mediation_MaxAd_ == null)
			{
				IMaxAdReviewListenerInvoker.cb_onCreativeIdGenerated_Ljava_lang_String_Lcom_applovin_mediation_MaxAd_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IMaxAdReviewListenerInvoker.n_OnCreativeIdGenerated_Ljava_lang_String_Lcom_applovin_mediation_MaxAd_));
			}
			return IMaxAdReviewListenerInvoker.cb_onCreativeIdGenerated_Ljava_lang_String_Lcom_applovin_mediation_MaxAd_;
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x0000F660 File Offset: 0x0000D860
		private static void n_OnCreativeIdGenerated_Ljava_lang_String_Lcom_applovin_mediation_MaxAd_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IMaxAdReviewListener @object = Java.Lang.Object.GetObject<IMaxAdReviewListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			IMaxAd object2 = Java.Lang.Object.GetObject<IMaxAd>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.OnCreativeIdGenerated(@string, object2);
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x0000F68C File Offset: 0x0000D88C
		public unsafe void OnCreativeIdGenerated(string p0, IMaxAd p1)
		{
			if (this.id_onCreativeIdGenerated_Ljava_lang_String_Lcom_applovin_mediation_MaxAd_ == IntPtr.Zero)
			{
				this.id_onCreativeIdGenerated_Ljava_lang_String_Lcom_applovin_mediation_MaxAd_ = JNIEnv.GetMethodID(this.class_ref, "onCreativeIdGenerated", "(Ljava/lang/String;Lcom/applovin/mediation/MaxAd;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onCreativeIdGenerated_Ljava_lang_String_Lcom_applovin_mediation_MaxAd_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x040001E8 RID: 488
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/MaxAdReviewListener", typeof(IMaxAdReviewListenerInvoker));

		// Token: 0x040001E9 RID: 489
		private IntPtr class_ref;

		// Token: 0x040001EA RID: 490
		private static Delegate cb_onCreativeIdGenerated_Ljava_lang_String_Lcom_applovin_mediation_MaxAd_;

		// Token: 0x040001EB RID: 491
		private IntPtr id_onCreativeIdGenerated_Ljava_lang_String_Lcom_applovin_mediation_MaxAd_;
	}
}
