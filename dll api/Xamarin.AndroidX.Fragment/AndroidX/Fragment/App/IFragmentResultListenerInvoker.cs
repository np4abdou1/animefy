using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Fragment.App
{
	// Token: 0x0200004D RID: 77
	[Register("androidx/fragment/app/FragmentResultListener", DoNotGenerateAcw = true)]
	internal class IFragmentResultListenerInvoker : Java.Lang.Object, IFragmentResultListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000430 RID: 1072 RVA: 0x0000D9D0 File Offset: 0x0000BBD0
		private static IntPtr java_class_ref
		{
			get
			{
				return IFragmentResultListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x0000D9F4 File Offset: 0x0000BBF4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IFragmentResultListenerInvoker._members;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x0000D9FB File Offset: 0x0000BBFB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x0000DA03 File Offset: 0x0000BC03
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IFragmentResultListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x0000DA0F File Offset: 0x0000BC0F
		public static IFragmentResultListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IFragmentResultListener>(handle, transfer);
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x0000DA18 File Offset: 0x0000BC18
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IFragmentResultListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.fragment.app.FragmentResultListener'.");
			}
			return handle;
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x0000DA43 File Offset: 0x0000BC43
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x0000DA74 File Offset: 0x0000BC74
		public IFragmentResultListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IFragmentResultListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x0000DAAC File Offset: 0x0000BCAC
		private static Delegate GetOnFragmentResult_Ljava_lang_String_Landroid_os_Bundle_Handler()
		{
			if (IFragmentResultListenerInvoker.cb_onFragmentResult_Ljava_lang_String_Landroid_os_Bundle_ == null)
			{
				IFragmentResultListenerInvoker.cb_onFragmentResult_Ljava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IFragmentResultListenerInvoker.n_OnFragmentResult_Ljava_lang_String_Landroid_os_Bundle_));
			}
			return IFragmentResultListenerInvoker.cb_onFragmentResult_Ljava_lang_String_Landroid_os_Bundle_;
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x0000DAD0 File Offset: 0x0000BCD0
		private static void n_OnFragmentResult_Ljava_lang_String_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IFragmentResultListener @object = Java.Lang.Object.GetObject<IFragmentResultListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.OnFragmentResult(@string, object2);
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x0000DAFC File Offset: 0x0000BCFC
		public unsafe void OnFragmentResult(string p0, Bundle p1)
		{
			if (this.id_onFragmentResult_Ljava_lang_String_Landroid_os_Bundle_ == IntPtr.Zero)
			{
				this.id_onFragmentResult_Ljava_lang_String_Landroid_os_Bundle_ = JNIEnv.GetMethodID(this.class_ref, "onFragmentResult", "(Ljava/lang/String;Landroid/os/Bundle;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onFragmentResult_Ljava_lang_String_Landroid_os_Bundle_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x0400011F RID: 287
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/fragment/app/FragmentResultListener", typeof(IFragmentResultListenerInvoker));

		// Token: 0x04000120 RID: 288
		private IntPtr class_ref;

		// Token: 0x04000121 RID: 289
		private static Delegate cb_onFragmentResult_Ljava_lang_String_Landroid_os_Bundle_;

		// Token: 0x04000122 RID: 290
		private IntPtr id_onFragmentResult_Ljava_lang_String_Landroid_os_Bundle_;
	}
}
