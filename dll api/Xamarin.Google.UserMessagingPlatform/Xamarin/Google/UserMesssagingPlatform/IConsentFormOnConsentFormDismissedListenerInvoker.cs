using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.UserMesssagingPlatform
{
	// Token: 0x0200001C RID: 28
	[Register("com/google/android/ump/ConsentForm$OnConsentFormDismissedListener", DoNotGenerateAcw = true)]
	internal class IConsentFormOnConsentFormDismissedListenerInvoker : Java.Lang.Object, IConsentFormOnConsentFormDismissedListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x000030E4 File Offset: 0x000012E4
		private static IntPtr java_class_ref
		{
			get
			{
				return IConsentFormOnConsentFormDismissedListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00003108 File Offset: 0x00001308
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IConsentFormOnConsentFormDismissedListenerInvoker._members;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x0000310F File Offset: 0x0000130F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00003117 File Offset: 0x00001317
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IConsentFormOnConsentFormDismissedListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00003123 File Offset: 0x00001323
		public static IConsentFormOnConsentFormDismissedListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IConsentFormOnConsentFormDismissedListener>(handle, transfer);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0000312C File Offset: 0x0000132C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IConsentFormOnConsentFormDismissedListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.ump.ConsentForm.OnConsentFormDismissedListener'.");
			}
			return handle;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00003157 File Offset: 0x00001357
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00003188 File Offset: 0x00001388
		public IConsentFormOnConsentFormDismissedListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IConsentFormOnConsentFormDismissedListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000031C0 File Offset: 0x000013C0
		private static Delegate GetOnConsentFormDismissed_Lcom_google_android_ump_FormError_Handler()
		{
			if (IConsentFormOnConsentFormDismissedListenerInvoker.cb_onConsentFormDismissed_Lcom_google_android_ump_FormError_ == null)
			{
				IConsentFormOnConsentFormDismissedListenerInvoker.cb_onConsentFormDismissed_Lcom_google_android_ump_FormError_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IConsentFormOnConsentFormDismissedListenerInvoker.n_OnConsentFormDismissed_Lcom_google_android_ump_FormError_));
			}
			return IConsentFormOnConsentFormDismissedListenerInvoker.cb_onConsentFormDismissed_Lcom_google_android_ump_FormError_;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000031E4 File Offset: 0x000013E4
		private static void n_OnConsentFormDismissed_Lcom_google_android_ump_FormError_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IConsentFormOnConsentFormDismissedListener @object = Java.Lang.Object.GetObject<IConsentFormOnConsentFormDismissedListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			FormError object2 = Java.Lang.Object.GetObject<FormError>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnConsentFormDismissed(object2);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00003208 File Offset: 0x00001408
		public unsafe void OnConsentFormDismissed(FormError p0)
		{
			if (this.id_onConsentFormDismissed_Lcom_google_android_ump_FormError_ == IntPtr.Zero)
			{
				this.id_onConsentFormDismissed_Lcom_google_android_ump_FormError_ = JNIEnv.GetMethodID(this.class_ref, "onConsentFormDismissed", "(Lcom/google/android/ump/FormError;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onConsentFormDismissed_Lcom_google_android_ump_FormError_, ptr);
		}

		// Token: 0x0400002B RID: 43
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/ump/ConsentForm$OnConsentFormDismissedListener", typeof(IConsentFormOnConsentFormDismissedListenerInvoker));

		// Token: 0x0400002C RID: 44
		private IntPtr class_ref;

		// Token: 0x0400002D RID: 45
		private static Delegate cb_onConsentFormDismissed_Lcom_google_android_ump_FormError_;

		// Token: 0x0400002E RID: 46
		private IntPtr id_onConsentFormDismissed_Lcom_google_android_ump_FormError_;
	}
}
