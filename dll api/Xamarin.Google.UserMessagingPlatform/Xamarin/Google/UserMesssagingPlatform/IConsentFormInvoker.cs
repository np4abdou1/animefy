using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.UserMesssagingPlatform
{
	// Token: 0x02000020 RID: 32
	[Register("com/google/android/ump/ConsentForm", DoNotGenerateAcw = true)]
	internal class IConsentFormInvoker : Java.Lang.Object, IConsentForm, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x0000331C File Offset: 0x0000151C
		private static IntPtr java_class_ref
		{
			get
			{
				return IConsentFormInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00003340 File Offset: 0x00001540
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IConsentFormInvoker._members;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00003347 File Offset: 0x00001547
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x0000334F File Offset: 0x0000154F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IConsentFormInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000335B File Offset: 0x0000155B
		public static IConsentForm GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IConsentForm>(handle, transfer);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00003364 File Offset: 0x00001564
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IConsentFormInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.ump.ConsentForm'.");
			}
			return handle;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000338F File Offset: 0x0000158F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000033C0 File Offset: 0x000015C0
		public IConsentFormInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IConsentFormInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000033F8 File Offset: 0x000015F8
		private static Delegate GetShow_Landroid_app_Activity_Lcom_google_android_ump_ConsentForm_OnConsentFormDismissedListener_Handler()
		{
			if (IConsentFormInvoker.cb_show_Landroid_app_Activity_Lcom_google_android_ump_ConsentForm_OnConsentFormDismissedListener_ == null)
			{
				IConsentFormInvoker.cb_show_Landroid_app_Activity_Lcom_google_android_ump_ConsentForm_OnConsentFormDismissedListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IConsentFormInvoker.n_Show_Landroid_app_Activity_Lcom_google_android_ump_ConsentForm_OnConsentFormDismissedListener_));
			}
			return IConsentFormInvoker.cb_show_Landroid_app_Activity_Lcom_google_android_ump_ConsentForm_OnConsentFormDismissedListener_;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000341C File Offset: 0x0000161C
		private static void n_Show_Landroid_app_Activity_Lcom_google_android_ump_ConsentForm_OnConsentFormDismissedListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IConsentForm @object = Java.Lang.Object.GetObject<IConsentForm>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Activity object2 = Java.Lang.Object.GetObject<Activity>(native_p0, JniHandleOwnership.DoNotTransfer);
			IConsentFormOnConsentFormDismissedListener object3 = Java.Lang.Object.GetObject<IConsentFormOnConsentFormDismissedListener>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.Show(object2, object3);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00003448 File Offset: 0x00001648
		public unsafe void Show(Activity p0, IConsentFormOnConsentFormDismissedListener p1)
		{
			if (this.id_show_Landroid_app_Activity_Lcom_google_android_ump_ConsentForm_OnConsentFormDismissedListener_ == IntPtr.Zero)
			{
				this.id_show_Landroid_app_Activity_Lcom_google_android_ump_ConsentForm_OnConsentFormDismissedListener_ = JNIEnv.GetMethodID(this.class_ref, "show", "(Landroid/app/Activity;Lcom/google/android/ump/ConsentForm$OnConsentFormDismissedListener;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_show_Landroid_app_Activity_Lcom_google_android_ump_ConsentForm_OnConsentFormDismissedListener_, ptr);
		}

		// Token: 0x04000032 RID: 50
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/ump/ConsentForm", typeof(IConsentFormInvoker));

		// Token: 0x04000033 RID: 51
		private IntPtr class_ref;

		// Token: 0x04000034 RID: 52
		private static Delegate cb_show_Landroid_app_Activity_Lcom_google_android_ump_ConsentForm_OnConsentFormDismissedListener_;

		// Token: 0x04000035 RID: 53
		private IntPtr id_show_Landroid_app_Activity_Lcom_google_android_ump_ConsentForm_OnConsentFormDismissedListener_;
	}
}
