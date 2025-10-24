using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Mediation
{
	// Token: 0x020000B4 RID: 180
	[Register("com/applovin/mediation/MaxAdViewAdListener", DoNotGenerateAcw = true)]
	internal class IMaxAdViewAdListenerInvoker : Java.Lang.Object, IMaxAdViewAdListener, IMaxAdListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000606 RID: 1542 RVA: 0x0000F7D8 File Offset: 0x0000D9D8
		private static IntPtr java_class_ref
		{
			get
			{
				return IMaxAdViewAdListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000607 RID: 1543 RVA: 0x0000F7FC File Offset: 0x0000D9FC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMaxAdViewAdListenerInvoker._members;
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000608 RID: 1544 RVA: 0x0000F803 File Offset: 0x0000DA03
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000609 RID: 1545 RVA: 0x0000F80B File Offset: 0x0000DA0B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMaxAdViewAdListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x0000F817 File Offset: 0x0000DA17
		public static IMaxAdViewAdListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMaxAdViewAdListener>(handle, transfer);
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x0000F820 File Offset: 0x0000DA20
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMaxAdViewAdListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.mediation.MaxAdViewAdListener'.");
			}
			return handle;
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x0000F84B File Offset: 0x0000DA4B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x0000F87C File Offset: 0x0000DA7C
		public IMaxAdViewAdListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMaxAdViewAdListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x0000F8B4 File Offset: 0x0000DAB4
		private static Delegate GetOnAdCollapsed_Lcom_applovin_mediation_MaxAd_Handler()
		{
			if (IMaxAdViewAdListenerInvoker.cb_onAdCollapsed_Lcom_applovin_mediation_MaxAd_ == null)
			{
				IMaxAdViewAdListenerInvoker.cb_onAdCollapsed_Lcom_applovin_mediation_MaxAd_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMaxAdViewAdListenerInvoker.n_OnAdCollapsed_Lcom_applovin_mediation_MaxAd_));
			}
			return IMaxAdViewAdListenerInvoker.cb_onAdCollapsed_Lcom_applovin_mediation_MaxAd_;
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x0000F8D8 File Offset: 0x0000DAD8
		private static void n_OnAdCollapsed_Lcom_applovin_mediation_MaxAd_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMaxAdViewAdListener @object = Java.Lang.Object.GetObject<IMaxAdViewAdListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAd object2 = Java.Lang.Object.GetObject<IMaxAd>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnAdCollapsed(object2);
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x0000F8FC File Offset: 0x0000DAFC
		public unsafe void OnAdCollapsed(IMaxAd p0)
		{
			if (this.id_onAdCollapsed_Lcom_applovin_mediation_MaxAd_ == IntPtr.Zero)
			{
				this.id_onAdCollapsed_Lcom_applovin_mediation_MaxAd_ = JNIEnv.GetMethodID(this.class_ref, "onAdCollapsed", "(Lcom/applovin/mediation/MaxAd;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAdCollapsed_Lcom_applovin_mediation_MaxAd_, ptr);
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x0000F974 File Offset: 0x0000DB74
		private static Delegate GetOnAdExpanded_Lcom_applovin_mediation_MaxAd_Handler()
		{
			if (IMaxAdViewAdListenerInvoker.cb_onAdExpanded_Lcom_applovin_mediation_MaxAd_ == null)
			{
				IMaxAdViewAdListenerInvoker.cb_onAdExpanded_Lcom_applovin_mediation_MaxAd_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMaxAdViewAdListenerInvoker.n_OnAdExpanded_Lcom_applovin_mediation_MaxAd_));
			}
			return IMaxAdViewAdListenerInvoker.cb_onAdExpanded_Lcom_applovin_mediation_MaxAd_;
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x0000F998 File Offset: 0x0000DB98
		private static void n_OnAdExpanded_Lcom_applovin_mediation_MaxAd_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMaxAdViewAdListener @object = Java.Lang.Object.GetObject<IMaxAdViewAdListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAd object2 = Java.Lang.Object.GetObject<IMaxAd>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnAdExpanded(object2);
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x0000F9BC File Offset: 0x0000DBBC
		public unsafe void OnAdExpanded(IMaxAd p0)
		{
			if (this.id_onAdExpanded_Lcom_applovin_mediation_MaxAd_ == IntPtr.Zero)
			{
				this.id_onAdExpanded_Lcom_applovin_mediation_MaxAd_ = JNIEnv.GetMethodID(this.class_ref, "onAdExpanded", "(Lcom/applovin/mediation/MaxAd;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAdExpanded_Lcom_applovin_mediation_MaxAd_, ptr);
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x0000FA34 File Offset: 0x0000DC34
		private static Delegate GetOnAdClicked_Lcom_applovin_mediation_MaxAd_Handler()
		{
			if (IMaxAdViewAdListenerInvoker.cb_onAdClicked_Lcom_applovin_mediation_MaxAd_ == null)
			{
				IMaxAdViewAdListenerInvoker.cb_onAdClicked_Lcom_applovin_mediation_MaxAd_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMaxAdViewAdListenerInvoker.n_OnAdClicked_Lcom_applovin_mediation_MaxAd_));
			}
			return IMaxAdViewAdListenerInvoker.cb_onAdClicked_Lcom_applovin_mediation_MaxAd_;
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x0000FA58 File Offset: 0x0000DC58
		private static void n_OnAdClicked_Lcom_applovin_mediation_MaxAd_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMaxAdListener @object = Java.Lang.Object.GetObject<IMaxAdViewAdListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAd object2 = Java.Lang.Object.GetObject<IMaxAd>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnAdClicked(object2);
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x0000FA7C File Offset: 0x0000DC7C
		public unsafe void OnAdClicked(IMaxAd p0)
		{
			if (this.id_onAdClicked_Lcom_applovin_mediation_MaxAd_ == IntPtr.Zero)
			{
				this.id_onAdClicked_Lcom_applovin_mediation_MaxAd_ = JNIEnv.GetMethodID(this.class_ref, "onAdClicked", "(Lcom/applovin/mediation/MaxAd;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAdClicked_Lcom_applovin_mediation_MaxAd_, ptr);
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x0000FAF4 File Offset: 0x0000DCF4
		private static Delegate GetOnAdDisplayFailed_Lcom_applovin_mediation_MaxAd_Lcom_applovin_mediation_MaxError_Handler()
		{
			if (IMaxAdViewAdListenerInvoker.cb_onAdDisplayFailed_Lcom_applovin_mediation_MaxAd_Lcom_applovin_mediation_MaxError_ == null)
			{
				IMaxAdViewAdListenerInvoker.cb_onAdDisplayFailed_Lcom_applovin_mediation_MaxAd_Lcom_applovin_mediation_MaxError_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IMaxAdViewAdListenerInvoker.n_OnAdDisplayFailed_Lcom_applovin_mediation_MaxAd_Lcom_applovin_mediation_MaxError_));
			}
			return IMaxAdViewAdListenerInvoker.cb_onAdDisplayFailed_Lcom_applovin_mediation_MaxAd_Lcom_applovin_mediation_MaxError_;
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x0000FB18 File Offset: 0x0000DD18
		private static void n_OnAdDisplayFailed_Lcom_applovin_mediation_MaxAd_Lcom_applovin_mediation_MaxError_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IMaxAdListener @object = Java.Lang.Object.GetObject<IMaxAdViewAdListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAd object2 = Java.Lang.Object.GetObject<IMaxAd>(native_p0, JniHandleOwnership.DoNotTransfer);
			IMaxError object3 = Java.Lang.Object.GetObject<IMaxError>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.OnAdDisplayFailed(object2, object3);
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x0000FB44 File Offset: 0x0000DD44
		public unsafe void OnAdDisplayFailed(IMaxAd p0, IMaxError p1)
		{
			if (this.id_onAdDisplayFailed_Lcom_applovin_mediation_MaxAd_Lcom_applovin_mediation_MaxError_ == IntPtr.Zero)
			{
				this.id_onAdDisplayFailed_Lcom_applovin_mediation_MaxAd_Lcom_applovin_mediation_MaxError_ = JNIEnv.GetMethodID(this.class_ref, "onAdDisplayFailed", "(Lcom/applovin/mediation/MaxAd;Lcom/applovin/mediation/MaxError;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAdDisplayFailed_Lcom_applovin_mediation_MaxAd_Lcom_applovin_mediation_MaxError_, ptr);
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x0000FBE3 File Offset: 0x0000DDE3
		private static Delegate GetOnAdDisplayed_Lcom_applovin_mediation_MaxAd_Handler()
		{
			if (IMaxAdViewAdListenerInvoker.cb_onAdDisplayed_Lcom_applovin_mediation_MaxAd_ == null)
			{
				IMaxAdViewAdListenerInvoker.cb_onAdDisplayed_Lcom_applovin_mediation_MaxAd_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMaxAdViewAdListenerInvoker.n_OnAdDisplayed_Lcom_applovin_mediation_MaxAd_));
			}
			return IMaxAdViewAdListenerInvoker.cb_onAdDisplayed_Lcom_applovin_mediation_MaxAd_;
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x0000FC08 File Offset: 0x0000DE08
		private static void n_OnAdDisplayed_Lcom_applovin_mediation_MaxAd_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMaxAdListener @object = Java.Lang.Object.GetObject<IMaxAdViewAdListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAd object2 = Java.Lang.Object.GetObject<IMaxAd>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnAdDisplayed(object2);
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x0000FC2C File Offset: 0x0000DE2C
		public unsafe void OnAdDisplayed(IMaxAd p0)
		{
			if (this.id_onAdDisplayed_Lcom_applovin_mediation_MaxAd_ == IntPtr.Zero)
			{
				this.id_onAdDisplayed_Lcom_applovin_mediation_MaxAd_ = JNIEnv.GetMethodID(this.class_ref, "onAdDisplayed", "(Lcom/applovin/mediation/MaxAd;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAdDisplayed_Lcom_applovin_mediation_MaxAd_, ptr);
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x0000FCA4 File Offset: 0x0000DEA4
		private static Delegate GetOnAdHidden_Lcom_applovin_mediation_MaxAd_Handler()
		{
			if (IMaxAdViewAdListenerInvoker.cb_onAdHidden_Lcom_applovin_mediation_MaxAd_ == null)
			{
				IMaxAdViewAdListenerInvoker.cb_onAdHidden_Lcom_applovin_mediation_MaxAd_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMaxAdViewAdListenerInvoker.n_OnAdHidden_Lcom_applovin_mediation_MaxAd_));
			}
			return IMaxAdViewAdListenerInvoker.cb_onAdHidden_Lcom_applovin_mediation_MaxAd_;
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x0000FCC8 File Offset: 0x0000DEC8
		private static void n_OnAdHidden_Lcom_applovin_mediation_MaxAd_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMaxAdListener @object = Java.Lang.Object.GetObject<IMaxAdViewAdListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAd object2 = Java.Lang.Object.GetObject<IMaxAd>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnAdHidden(object2);
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x0000FCEC File Offset: 0x0000DEEC
		public unsafe void OnAdHidden(IMaxAd p0)
		{
			if (this.id_onAdHidden_Lcom_applovin_mediation_MaxAd_ == IntPtr.Zero)
			{
				this.id_onAdHidden_Lcom_applovin_mediation_MaxAd_ = JNIEnv.GetMethodID(this.class_ref, "onAdHidden", "(Lcom/applovin/mediation/MaxAd;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAdHidden_Lcom_applovin_mediation_MaxAd_, ptr);
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x0000FD64 File Offset: 0x0000DF64
		private static Delegate GetOnAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_MaxError_Handler()
		{
			if (IMaxAdViewAdListenerInvoker.cb_onAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_MaxError_ == null)
			{
				IMaxAdViewAdListenerInvoker.cb_onAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_MaxError_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IMaxAdViewAdListenerInvoker.n_OnAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_MaxError_));
			}
			return IMaxAdViewAdListenerInvoker.cb_onAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_MaxError_;
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x0000FD88 File Offset: 0x0000DF88
		private static void n_OnAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_MaxError_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IMaxAdListener @object = Java.Lang.Object.GetObject<IMaxAdViewAdListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			IMaxError object2 = Java.Lang.Object.GetObject<IMaxError>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.OnAdLoadFailed(@string, object2);
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x0000FDB4 File Offset: 0x0000DFB4
		public unsafe void OnAdLoadFailed(string p0, IMaxError p1)
		{
			if (this.id_onAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_MaxError_ == IntPtr.Zero)
			{
				this.id_onAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_MaxError_ = JNIEnv.GetMethodID(this.class_ref, "onAdLoadFailed", "(Ljava/lang/String;Lcom/applovin/mediation/MaxError;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_MaxError_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x0000FE4C File Offset: 0x0000E04C
		private static Delegate GetOnAdLoaded_Lcom_applovin_mediation_MaxAd_Handler()
		{
			if (IMaxAdViewAdListenerInvoker.cb_onAdLoaded_Lcom_applovin_mediation_MaxAd_ == null)
			{
				IMaxAdViewAdListenerInvoker.cb_onAdLoaded_Lcom_applovin_mediation_MaxAd_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMaxAdViewAdListenerInvoker.n_OnAdLoaded_Lcom_applovin_mediation_MaxAd_));
			}
			return IMaxAdViewAdListenerInvoker.cb_onAdLoaded_Lcom_applovin_mediation_MaxAd_;
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x0000FE70 File Offset: 0x0000E070
		private static void n_OnAdLoaded_Lcom_applovin_mediation_MaxAd_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMaxAdListener @object = Java.Lang.Object.GetObject<IMaxAdViewAdListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAd object2 = Java.Lang.Object.GetObject<IMaxAd>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnAdLoaded(object2);
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x0000FE94 File Offset: 0x0000E094
		public unsafe void OnAdLoaded(IMaxAd p0)
		{
			if (this.id_onAdLoaded_Lcom_applovin_mediation_MaxAd_ == IntPtr.Zero)
			{
				this.id_onAdLoaded_Lcom_applovin_mediation_MaxAd_ = JNIEnv.GetMethodID(this.class_ref, "onAdLoaded", "(Lcom/applovin/mediation/MaxAd;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAdLoaded_Lcom_applovin_mediation_MaxAd_, ptr);
		}

		// Token: 0x040001F0 RID: 496
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/MaxAdViewAdListener", typeof(IMaxAdViewAdListenerInvoker));

		// Token: 0x040001F1 RID: 497
		private IntPtr class_ref;

		// Token: 0x040001F2 RID: 498
		private static Delegate cb_onAdCollapsed_Lcom_applovin_mediation_MaxAd_;

		// Token: 0x040001F3 RID: 499
		private IntPtr id_onAdCollapsed_Lcom_applovin_mediation_MaxAd_;

		// Token: 0x040001F4 RID: 500
		private static Delegate cb_onAdExpanded_Lcom_applovin_mediation_MaxAd_;

		// Token: 0x040001F5 RID: 501
		private IntPtr id_onAdExpanded_Lcom_applovin_mediation_MaxAd_;

		// Token: 0x040001F6 RID: 502
		private static Delegate cb_onAdClicked_Lcom_applovin_mediation_MaxAd_;

		// Token: 0x040001F7 RID: 503
		private IntPtr id_onAdClicked_Lcom_applovin_mediation_MaxAd_;

		// Token: 0x040001F8 RID: 504
		private static Delegate cb_onAdDisplayFailed_Lcom_applovin_mediation_MaxAd_Lcom_applovin_mediation_MaxError_;

		// Token: 0x040001F9 RID: 505
		private IntPtr id_onAdDisplayFailed_Lcom_applovin_mediation_MaxAd_Lcom_applovin_mediation_MaxError_;

		// Token: 0x040001FA RID: 506
		private static Delegate cb_onAdDisplayed_Lcom_applovin_mediation_MaxAd_;

		// Token: 0x040001FB RID: 507
		private IntPtr id_onAdDisplayed_Lcom_applovin_mediation_MaxAd_;

		// Token: 0x040001FC RID: 508
		private static Delegate cb_onAdHidden_Lcom_applovin_mediation_MaxAd_;

		// Token: 0x040001FD RID: 509
		private IntPtr id_onAdHidden_Lcom_applovin_mediation_MaxAd_;

		// Token: 0x040001FE RID: 510
		private static Delegate cb_onAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_MaxError_;

		// Token: 0x040001FF RID: 511
		private IntPtr id_onAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_MaxError_;

		// Token: 0x04000200 RID: 512
		private static Delegate cb_onAdLoaded_Lcom_applovin_mediation_MaxAd_;

		// Token: 0x04000201 RID: 513
		private IntPtr id_onAdLoaded_Lcom_applovin_mediation_MaxAd_;
	}
}
