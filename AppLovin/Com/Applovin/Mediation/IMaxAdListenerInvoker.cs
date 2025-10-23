using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Mediation
{
	// Token: 0x020000A3 RID: 163
	[Register("com/applovin/mediation/MaxAdListener", DoNotGenerateAcw = true)]
	internal class IMaxAdListenerInvoker : Java.Lang.Object, IMaxAdListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060005AE RID: 1454 RVA: 0x0000EB38 File Offset: 0x0000CD38
		private static IntPtr java_class_ref
		{
			get
			{
				return IMaxAdListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x0000EB5C File Offset: 0x0000CD5C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMaxAdListenerInvoker._members;
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060005B0 RID: 1456 RVA: 0x0000EB63 File Offset: 0x0000CD63
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060005B1 RID: 1457 RVA: 0x0000EB6B File Offset: 0x0000CD6B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMaxAdListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x0000EB77 File Offset: 0x0000CD77
		public static IMaxAdListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMaxAdListener>(handle, transfer);
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x0000EB80 File Offset: 0x0000CD80
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMaxAdListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.mediation.MaxAdListener'.");
			}
			return handle;
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x0000EBAB File Offset: 0x0000CDAB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x0000EBDC File Offset: 0x0000CDDC
		public IMaxAdListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMaxAdListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x0000EC14 File Offset: 0x0000CE14
		private static Delegate GetOnAdClicked_Lcom_applovin_mediation_MaxAd_Handler()
		{
			if (IMaxAdListenerInvoker.cb_onAdClicked_Lcom_applovin_mediation_MaxAd_ == null)
			{
				IMaxAdListenerInvoker.cb_onAdClicked_Lcom_applovin_mediation_MaxAd_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMaxAdListenerInvoker.n_OnAdClicked_Lcom_applovin_mediation_MaxAd_));
			}
			return IMaxAdListenerInvoker.cb_onAdClicked_Lcom_applovin_mediation_MaxAd_;
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x0000EC38 File Offset: 0x0000CE38
		private static void n_OnAdClicked_Lcom_applovin_mediation_MaxAd_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMaxAdListener @object = Java.Lang.Object.GetObject<IMaxAdListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAd object2 = Java.Lang.Object.GetObject<IMaxAd>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnAdClicked(object2);
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x0000EC5C File Offset: 0x0000CE5C
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

		// Token: 0x060005B9 RID: 1465 RVA: 0x0000ECD4 File Offset: 0x0000CED4
		private static Delegate GetOnAdDisplayFailed_Lcom_applovin_mediation_MaxAd_Lcom_applovin_mediation_MaxError_Handler()
		{
			if (IMaxAdListenerInvoker.cb_onAdDisplayFailed_Lcom_applovin_mediation_MaxAd_Lcom_applovin_mediation_MaxError_ == null)
			{
				IMaxAdListenerInvoker.cb_onAdDisplayFailed_Lcom_applovin_mediation_MaxAd_Lcom_applovin_mediation_MaxError_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IMaxAdListenerInvoker.n_OnAdDisplayFailed_Lcom_applovin_mediation_MaxAd_Lcom_applovin_mediation_MaxError_));
			}
			return IMaxAdListenerInvoker.cb_onAdDisplayFailed_Lcom_applovin_mediation_MaxAd_Lcom_applovin_mediation_MaxError_;
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x0000ECF8 File Offset: 0x0000CEF8
		private static void n_OnAdDisplayFailed_Lcom_applovin_mediation_MaxAd_Lcom_applovin_mediation_MaxError_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IMaxAdListener @object = Java.Lang.Object.GetObject<IMaxAdListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAd object2 = Java.Lang.Object.GetObject<IMaxAd>(native_p0, JniHandleOwnership.DoNotTransfer);
			IMaxError object3 = Java.Lang.Object.GetObject<IMaxError>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.OnAdDisplayFailed(object2, object3);
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x0000ED24 File Offset: 0x0000CF24
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

		// Token: 0x060005BC RID: 1468 RVA: 0x0000EDC3 File Offset: 0x0000CFC3
		private static Delegate GetOnAdDisplayed_Lcom_applovin_mediation_MaxAd_Handler()
		{
			if (IMaxAdListenerInvoker.cb_onAdDisplayed_Lcom_applovin_mediation_MaxAd_ == null)
			{
				IMaxAdListenerInvoker.cb_onAdDisplayed_Lcom_applovin_mediation_MaxAd_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMaxAdListenerInvoker.n_OnAdDisplayed_Lcom_applovin_mediation_MaxAd_));
			}
			return IMaxAdListenerInvoker.cb_onAdDisplayed_Lcom_applovin_mediation_MaxAd_;
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x0000EDE8 File Offset: 0x0000CFE8
		private static void n_OnAdDisplayed_Lcom_applovin_mediation_MaxAd_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMaxAdListener @object = Java.Lang.Object.GetObject<IMaxAdListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAd object2 = Java.Lang.Object.GetObject<IMaxAd>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnAdDisplayed(object2);
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x0000EE0C File Offset: 0x0000D00C
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

		// Token: 0x060005BF RID: 1471 RVA: 0x0000EE84 File Offset: 0x0000D084
		private static Delegate GetOnAdHidden_Lcom_applovin_mediation_MaxAd_Handler()
		{
			if (IMaxAdListenerInvoker.cb_onAdHidden_Lcom_applovin_mediation_MaxAd_ == null)
			{
				IMaxAdListenerInvoker.cb_onAdHidden_Lcom_applovin_mediation_MaxAd_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMaxAdListenerInvoker.n_OnAdHidden_Lcom_applovin_mediation_MaxAd_));
			}
			return IMaxAdListenerInvoker.cb_onAdHidden_Lcom_applovin_mediation_MaxAd_;
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x0000EEA8 File Offset: 0x0000D0A8
		private static void n_OnAdHidden_Lcom_applovin_mediation_MaxAd_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMaxAdListener @object = Java.Lang.Object.GetObject<IMaxAdListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAd object2 = Java.Lang.Object.GetObject<IMaxAd>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnAdHidden(object2);
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x0000EECC File Offset: 0x0000D0CC
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

		// Token: 0x060005C2 RID: 1474 RVA: 0x0000EF44 File Offset: 0x0000D144
		private static Delegate GetOnAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_MaxError_Handler()
		{
			if (IMaxAdListenerInvoker.cb_onAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_MaxError_ == null)
			{
				IMaxAdListenerInvoker.cb_onAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_MaxError_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IMaxAdListenerInvoker.n_OnAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_MaxError_));
			}
			return IMaxAdListenerInvoker.cb_onAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_MaxError_;
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x0000EF68 File Offset: 0x0000D168
		private static void n_OnAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_MaxError_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IMaxAdListener @object = Java.Lang.Object.GetObject<IMaxAdListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			IMaxError object2 = Java.Lang.Object.GetObject<IMaxError>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.OnAdLoadFailed(@string, object2);
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x0000EF94 File Offset: 0x0000D194
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

		// Token: 0x060005C5 RID: 1477 RVA: 0x0000F02C File Offset: 0x0000D22C
		private static Delegate GetOnAdLoaded_Lcom_applovin_mediation_MaxAd_Handler()
		{
			if (IMaxAdListenerInvoker.cb_onAdLoaded_Lcom_applovin_mediation_MaxAd_ == null)
			{
				IMaxAdListenerInvoker.cb_onAdLoaded_Lcom_applovin_mediation_MaxAd_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMaxAdListenerInvoker.n_OnAdLoaded_Lcom_applovin_mediation_MaxAd_));
			}
			return IMaxAdListenerInvoker.cb_onAdLoaded_Lcom_applovin_mediation_MaxAd_;
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x0000F050 File Offset: 0x0000D250
		private static void n_OnAdLoaded_Lcom_applovin_mediation_MaxAd_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMaxAdListener @object = Java.Lang.Object.GetObject<IMaxAdListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAd object2 = Java.Lang.Object.GetObject<IMaxAd>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnAdLoaded(object2);
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x0000F074 File Offset: 0x0000D274
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

		// Token: 0x040001C4 RID: 452
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/MaxAdListener", typeof(IMaxAdListenerInvoker));

		// Token: 0x040001C5 RID: 453
		private IntPtr class_ref;

		// Token: 0x040001C6 RID: 454
		private static Delegate cb_onAdClicked_Lcom_applovin_mediation_MaxAd_;

		// Token: 0x040001C7 RID: 455
		private IntPtr id_onAdClicked_Lcom_applovin_mediation_MaxAd_;

		// Token: 0x040001C8 RID: 456
		private static Delegate cb_onAdDisplayFailed_Lcom_applovin_mediation_MaxAd_Lcom_applovin_mediation_MaxError_;

		// Token: 0x040001C9 RID: 457
		private IntPtr id_onAdDisplayFailed_Lcom_applovin_mediation_MaxAd_Lcom_applovin_mediation_MaxError_;

		// Token: 0x040001CA RID: 458
		private static Delegate cb_onAdDisplayed_Lcom_applovin_mediation_MaxAd_;

		// Token: 0x040001CB RID: 459
		private IntPtr id_onAdDisplayed_Lcom_applovin_mediation_MaxAd_;

		// Token: 0x040001CC RID: 460
		private static Delegate cb_onAdHidden_Lcom_applovin_mediation_MaxAd_;

		// Token: 0x040001CD RID: 461
		private IntPtr id_onAdHidden_Lcom_applovin_mediation_MaxAd_;

		// Token: 0x040001CE RID: 462
		private static Delegate cb_onAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_MaxError_;

		// Token: 0x040001CF RID: 463
		private IntPtr id_onAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_MaxError_;

		// Token: 0x040001D0 RID: 464
		private static Delegate cb_onAdLoaded_Lcom_applovin_mediation_MaxAd_;

		// Token: 0x040001D1 RID: 465
		private IntPtr id_onAdLoaded_Lcom_applovin_mediation_MaxAd_;
	}
}
