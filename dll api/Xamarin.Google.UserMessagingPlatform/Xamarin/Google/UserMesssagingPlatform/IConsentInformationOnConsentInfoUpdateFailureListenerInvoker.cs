using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.UserMesssagingPlatform
{
	// Token: 0x02000026 RID: 38
	[Register("com/google/android/ump/ConsentInformation$OnConsentInfoUpdateFailureListener", DoNotGenerateAcw = true)]
	internal class IConsentInformationOnConsentInfoUpdateFailureListenerInvoker : Java.Lang.Object, IConsentInformationOnConsentInfoUpdateFailureListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00003844 File Offset: 0x00001A44
		private static IntPtr java_class_ref
		{
			get
			{
				return IConsentInformationOnConsentInfoUpdateFailureListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00003868 File Offset: 0x00001A68
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IConsentInformationOnConsentInfoUpdateFailureListenerInvoker._members;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x0000386F File Offset: 0x00001A6F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000DA RID: 218 RVA: 0x00003877 File Offset: 0x00001A77
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IConsentInformationOnConsentInfoUpdateFailureListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00003883 File Offset: 0x00001A83
		public static IConsentInformationOnConsentInfoUpdateFailureListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IConsentInformationOnConsentInfoUpdateFailureListener>(handle, transfer);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000388C File Offset: 0x00001A8C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IConsentInformationOnConsentInfoUpdateFailureListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.ump.ConsentInformation.OnConsentInfoUpdateFailureListener'.");
			}
			return handle;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000038B7 File Offset: 0x00001AB7
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000038E8 File Offset: 0x00001AE8
		public IConsentInformationOnConsentInfoUpdateFailureListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IConsentInformationOnConsentInfoUpdateFailureListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00003920 File Offset: 0x00001B20
		private static Delegate GetOnConsentInfoUpdateFailure_Lcom_google_android_ump_FormError_Handler()
		{
			if (IConsentInformationOnConsentInfoUpdateFailureListenerInvoker.cb_onConsentInfoUpdateFailure_Lcom_google_android_ump_FormError_ == null)
			{
				IConsentInformationOnConsentInfoUpdateFailureListenerInvoker.cb_onConsentInfoUpdateFailure_Lcom_google_android_ump_FormError_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IConsentInformationOnConsentInfoUpdateFailureListenerInvoker.n_OnConsentInfoUpdateFailure_Lcom_google_android_ump_FormError_));
			}
			return IConsentInformationOnConsentInfoUpdateFailureListenerInvoker.cb_onConsentInfoUpdateFailure_Lcom_google_android_ump_FormError_;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00003944 File Offset: 0x00001B44
		private static void n_OnConsentInfoUpdateFailure_Lcom_google_android_ump_FormError_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IConsentInformationOnConsentInfoUpdateFailureListener @object = Java.Lang.Object.GetObject<IConsentInformationOnConsentInfoUpdateFailureListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			FormError object2 = Java.Lang.Object.GetObject<FormError>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnConsentInfoUpdateFailure(object2);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00003968 File Offset: 0x00001B68
		public unsafe void OnConsentInfoUpdateFailure(FormError p0)
		{
			if (this.id_onConsentInfoUpdateFailure_Lcom_google_android_ump_FormError_ == IntPtr.Zero)
			{
				this.id_onConsentInfoUpdateFailure_Lcom_google_android_ump_FormError_ = JNIEnv.GetMethodID(this.class_ref, "onConsentInfoUpdateFailure", "(Lcom/google/android/ump/FormError;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onConsentInfoUpdateFailure_Lcom_google_android_ump_FormError_, ptr);
		}

		// Token: 0x04000044 RID: 68
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/ump/ConsentInformation$OnConsentInfoUpdateFailureListener", typeof(IConsentInformationOnConsentInfoUpdateFailureListenerInvoker));

		// Token: 0x04000045 RID: 69
		private IntPtr class_ref;

		// Token: 0x04000046 RID: 70
		private static Delegate cb_onConsentInfoUpdateFailure_Lcom_google_android_ump_FormError_;

		// Token: 0x04000047 RID: 71
		private IntPtr id_onConsentInfoUpdateFailure_Lcom_google_android_ump_FormError_;
	}
}
