using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using AndroidX.Lifecycle;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Fragment.App
{
	// Token: 0x0200004F RID: 79
	[Register("androidx/fragment/app/FragmentResultOwner", DoNotGenerateAcw = true)]
	internal class IFragmentResultOwnerInvoker : Java.Lang.Object, IFragmentResultOwner, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x0000DBAC File Offset: 0x0000BDAC
		private static IntPtr java_class_ref
		{
			get
			{
				return IFragmentResultOwnerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x0000DBD0 File Offset: 0x0000BDD0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IFragmentResultOwnerInvoker._members;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x0000DBD7 File Offset: 0x0000BDD7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000443 RID: 1091 RVA: 0x0000DBDF File Offset: 0x0000BDDF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IFragmentResultOwnerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x0000DBEB File Offset: 0x0000BDEB
		public static IFragmentResultOwner GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IFragmentResultOwner>(handle, transfer);
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x0000DBF4 File Offset: 0x0000BDF4
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IFragmentResultOwnerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.fragment.app.FragmentResultOwner'.");
			}
			return handle;
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x0000DC1F File Offset: 0x0000BE1F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x0000DC50 File Offset: 0x0000BE50
		public IFragmentResultOwnerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IFragmentResultOwnerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x0000DC88 File Offset: 0x0000BE88
		private static Delegate GetClearFragmentResult_Ljava_lang_String_Handler()
		{
			if (IFragmentResultOwnerInvoker.cb_clearFragmentResult_Ljava_lang_String_ == null)
			{
				IFragmentResultOwnerInvoker.cb_clearFragmentResult_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IFragmentResultOwnerInvoker.n_ClearFragmentResult_Ljava_lang_String_));
			}
			return IFragmentResultOwnerInvoker.cb_clearFragmentResult_Ljava_lang_String_;
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x0000DCAC File Offset: 0x0000BEAC
		private static void n_ClearFragmentResult_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IFragmentResultOwner @object = Java.Lang.Object.GetObject<IFragmentResultOwner>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.ClearFragmentResult(@string);
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x0000DCD0 File Offset: 0x0000BED0
		public unsafe void ClearFragmentResult(string p0)
		{
			if (this.id_clearFragmentResult_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_clearFragmentResult_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "clearFragmentResult", "(Ljava/lang/String;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_clearFragmentResult_Ljava_lang_String_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x0000DD41 File Offset: 0x0000BF41
		private static Delegate GetClearFragmentResultListener_Ljava_lang_String_Handler()
		{
			if (IFragmentResultOwnerInvoker.cb_clearFragmentResultListener_Ljava_lang_String_ == null)
			{
				IFragmentResultOwnerInvoker.cb_clearFragmentResultListener_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IFragmentResultOwnerInvoker.n_ClearFragmentResultListener_Ljava_lang_String_));
			}
			return IFragmentResultOwnerInvoker.cb_clearFragmentResultListener_Ljava_lang_String_;
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x0000DD68 File Offset: 0x0000BF68
		private static void n_ClearFragmentResultListener_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IFragmentResultOwner @object = Java.Lang.Object.GetObject<IFragmentResultOwner>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.ClearFragmentResultListener(@string);
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x0000DD8C File Offset: 0x0000BF8C
		public unsafe void ClearFragmentResultListener(string p0)
		{
			if (this.id_clearFragmentResultListener_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_clearFragmentResultListener_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "clearFragmentResultListener", "(Ljava/lang/String;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_clearFragmentResultListener_Ljava_lang_String_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x0000DDFD File Offset: 0x0000BFFD
		private static Delegate GetSetFragmentResult_Ljava_lang_String_Landroid_os_Bundle_Handler()
		{
			if (IFragmentResultOwnerInvoker.cb_setFragmentResult_Ljava_lang_String_Landroid_os_Bundle_ == null)
			{
				IFragmentResultOwnerInvoker.cb_setFragmentResult_Ljava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IFragmentResultOwnerInvoker.n_SetFragmentResult_Ljava_lang_String_Landroid_os_Bundle_));
			}
			return IFragmentResultOwnerInvoker.cb_setFragmentResult_Ljava_lang_String_Landroid_os_Bundle_;
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x0000DE24 File Offset: 0x0000C024
		private static void n_SetFragmentResult_Ljava_lang_String_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IFragmentResultOwner @object = Java.Lang.Object.GetObject<IFragmentResultOwner>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.SetFragmentResult(@string, object2);
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x0000DE50 File Offset: 0x0000C050
		public unsafe void SetFragmentResult(string p0, Bundle p1)
		{
			if (this.id_setFragmentResult_Ljava_lang_String_Landroid_os_Bundle_ == IntPtr.Zero)
			{
				this.id_setFragmentResult_Ljava_lang_String_Landroid_os_Bundle_ = JNIEnv.GetMethodID(this.class_ref, "setFragmentResult", "(Ljava/lang/String;Landroid/os/Bundle;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_setFragmentResult_Ljava_lang_String_Landroid_os_Bundle_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x0000DEE3 File Offset: 0x0000C0E3
		private static Delegate GetSetFragmentResultListener_Ljava_lang_String_Landroidx_lifecycle_LifecycleOwner_Landroidx_fragment_app_FragmentResultListener_Handler()
		{
			if (IFragmentResultOwnerInvoker.cb_setFragmentResultListener_Ljava_lang_String_Landroidx_lifecycle_LifecycleOwner_Landroidx_fragment_app_FragmentResultListener_ == null)
			{
				IFragmentResultOwnerInvoker.cb_setFragmentResultListener_Ljava_lang_String_Landroidx_lifecycle_LifecycleOwner_Landroidx_fragment_app_FragmentResultListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(IFragmentResultOwnerInvoker.n_SetFragmentResultListener_Ljava_lang_String_Landroidx_lifecycle_LifecycleOwner_Landroidx_fragment_app_FragmentResultListener_));
			}
			return IFragmentResultOwnerInvoker.cb_setFragmentResultListener_Ljava_lang_String_Landroidx_lifecycle_LifecycleOwner_Landroidx_fragment_app_FragmentResultListener_;
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x0000DF08 File Offset: 0x0000C108
		private static void n_SetFragmentResultListener_Ljava_lang_String_Landroidx_lifecycle_LifecycleOwner_Landroidx_fragment_app_FragmentResultListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			IFragmentResultOwner @object = Java.Lang.Object.GetObject<IFragmentResultOwner>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			ILifecycleOwner object2 = Java.Lang.Object.GetObject<ILifecycleOwner>(native_p1, JniHandleOwnership.DoNotTransfer);
			IFragmentResultListener object3 = Java.Lang.Object.GetObject<IFragmentResultListener>(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.SetFragmentResultListener(@string, object2, object3);
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x0000DF40 File Offset: 0x0000C140
		public unsafe void SetFragmentResultListener(string p0, ILifecycleOwner p1, IFragmentResultListener p2)
		{
			if (this.id_setFragmentResultListener_Ljava_lang_String_Landroidx_lifecycle_LifecycleOwner_Landroidx_fragment_app_FragmentResultListener_ == IntPtr.Zero)
			{
				this.id_setFragmentResultListener_Ljava_lang_String_Landroidx_lifecycle_LifecycleOwner_Landroidx_fragment_app_FragmentResultListener_ = JNIEnv.GetMethodID(this.class_ref, "setFragmentResultListener", "(Ljava/lang/String;Landroidx/lifecycle/LifecycleOwner;Landroidx/fragment/app/FragmentResultListener;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
			ptr[2] = new JValue((p2 == null) ? IntPtr.Zero : ((Java.Lang.Object)p2).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_setFragmentResultListener_Ljava_lang_String_Landroidx_lifecycle_LifecycleOwner_Landroidx_fragment_app_FragmentResultListener_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x04000123 RID: 291
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/fragment/app/FragmentResultOwner", typeof(IFragmentResultOwnerInvoker));

		// Token: 0x04000124 RID: 292
		private IntPtr class_ref;

		// Token: 0x04000125 RID: 293
		private static Delegate cb_clearFragmentResult_Ljava_lang_String_;

		// Token: 0x04000126 RID: 294
		private IntPtr id_clearFragmentResult_Ljava_lang_String_;

		// Token: 0x04000127 RID: 295
		private static Delegate cb_clearFragmentResultListener_Ljava_lang_String_;

		// Token: 0x04000128 RID: 296
		private IntPtr id_clearFragmentResultListener_Ljava_lang_String_;

		// Token: 0x04000129 RID: 297
		private static Delegate cb_setFragmentResult_Ljava_lang_String_Landroid_os_Bundle_;

		// Token: 0x0400012A RID: 298
		private IntPtr id_setFragmentResult_Ljava_lang_String_Landroid_os_Bundle_;

		// Token: 0x0400012B RID: 299
		private static Delegate cb_setFragmentResultListener_Ljava_lang_String_Landroidx_lifecycle_LifecycleOwner_Landroidx_fragment_app_FragmentResultListener_;

		// Token: 0x0400012C RID: 300
		private IntPtr id_setFragmentResultListener_Ljava_lang_String_Landroidx_lifecycle_LifecycleOwner_Landroidx_fragment_app_FragmentResultListener_;
	}
}
