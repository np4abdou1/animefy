using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Common.Apis.Internal
{
	// Token: 0x02000023 RID: 35
	[Register("com/google/android/gms/common/api/internal/LifecycleFragment", DoNotGenerateAcw = true)]
	internal class ILifecycleFragmentInvoker : Java.Lang.Object, ILifecycleFragment, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000FA RID: 250 RVA: 0x000042A8 File Offset: 0x000024A8
		private static IntPtr java_class_ref
		{
			get
			{
				return ILifecycleFragmentInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000FB RID: 251 RVA: 0x000042CC File Offset: 0x000024CC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ILifecycleFragmentInvoker._members;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000FC RID: 252 RVA: 0x000042D3 File Offset: 0x000024D3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000FD RID: 253 RVA: 0x000042DB File Offset: 0x000024DB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ILifecycleFragmentInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x000042E7 File Offset: 0x000024E7
		public static ILifecycleFragment GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ILifecycleFragment>(handle, transfer);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x000042F0 File Offset: 0x000024F0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ILifecycleFragmentInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.gms.common.api.internal.LifecycleFragment'.");
			}
			return handle;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000431B File Offset: 0x0000251B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000434C File Offset: 0x0000254C
		public ILifecycleFragmentInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ILifecycleFragmentInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00004384 File Offset: 0x00002584
		private static Delegate GetIsCreatedHandler()
		{
			if (ILifecycleFragmentInvoker.cb_isCreated == null)
			{
				ILifecycleFragmentInvoker.cb_isCreated = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ILifecycleFragmentInvoker.n_IsCreated));
			}
			return ILifecycleFragmentInvoker.cb_isCreated;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x000043A8 File Offset: 0x000025A8
		private static bool n_IsCreated(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ILifecycleFragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsCreated;
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000104 RID: 260 RVA: 0x000043B7 File Offset: 0x000025B7
		public bool IsCreated
		{
			get
			{
				if (this.id_isCreated == IntPtr.Zero)
				{
					this.id_isCreated = JNIEnv.GetMethodID(this.class_ref, "isCreated", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isCreated);
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000043F7 File Offset: 0x000025F7
		private static Delegate GetIsStartedHandler()
		{
			if (ILifecycleFragmentInvoker.cb_isStarted == null)
			{
				ILifecycleFragmentInvoker.cb_isStarted = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ILifecycleFragmentInvoker.n_IsStarted));
			}
			return ILifecycleFragmentInvoker.cb_isStarted;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0000441B File Offset: 0x0000261B
		private static bool n_IsStarted(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ILifecycleFragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsStarted;
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000107 RID: 263 RVA: 0x0000442A File Offset: 0x0000262A
		public bool IsStarted
		{
			get
			{
				if (this.id_isStarted == IntPtr.Zero)
				{
					this.id_isStarted = JNIEnv.GetMethodID(this.class_ref, "isStarted", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isStarted);
			}
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0000446A File Offset: 0x0000266A
		private static Delegate GetGetLifecycleActivityHandler()
		{
			if (ILifecycleFragmentInvoker.cb_getLifecycleActivity == null)
			{
				ILifecycleFragmentInvoker.cb_getLifecycleActivity = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ILifecycleFragmentInvoker.n_GetLifecycleActivity));
			}
			return ILifecycleFragmentInvoker.cb_getLifecycleActivity;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0000448E File Offset: 0x0000268E
		private static IntPtr n_GetLifecycleActivity(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ILifecycleFragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LifecycleActivity);
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600010A RID: 266 RVA: 0x000044A4 File Offset: 0x000026A4
		public Activity LifecycleActivity
		{
			get
			{
				if (this.id_getLifecycleActivity == IntPtr.Zero)
				{
					this.id_getLifecycleActivity = JNIEnv.GetMethodID(this.class_ref, "getLifecycleActivity", "()Landroid/app/Activity;");
				}
				return Java.Lang.Object.GetObject<Activity>(JNIEnv.CallObjectMethod(base.Handle, this.id_getLifecycleActivity), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000044F5 File Offset: 0x000026F5
		private static Delegate GetAddCallback_Ljava_lang_String_Lcom_google_android_gms_common_api_internal_LifecycleCallback_Handler()
		{
			if (ILifecycleFragmentInvoker.cb_addCallback_Ljava_lang_String_Lcom_google_android_gms_common_api_internal_LifecycleCallback_ == null)
			{
				ILifecycleFragmentInvoker.cb_addCallback_Ljava_lang_String_Lcom_google_android_gms_common_api_internal_LifecycleCallback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(ILifecycleFragmentInvoker.n_AddCallback_Ljava_lang_String_Lcom_google_android_gms_common_api_internal_LifecycleCallback_));
			}
			return ILifecycleFragmentInvoker.cb_addCallback_Ljava_lang_String_Lcom_google_android_gms_common_api_internal_LifecycleCallback_;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0000451C File Offset: 0x0000271C
		private static void n_AddCallback_Ljava_lang_String_Lcom_google_android_gms_common_api_internal_LifecycleCallback_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			ILifecycleFragment @object = Java.Lang.Object.GetObject<ILifecycleFragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			LifecycleCallback object2 = Java.Lang.Object.GetObject<LifecycleCallback>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.AddCallback(@string, object2);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00004548 File Offset: 0x00002748
		public unsafe void AddCallback(string p0, LifecycleCallback p1)
		{
			if (this.id_addCallback_Ljava_lang_String_Lcom_google_android_gms_common_api_internal_LifecycleCallback_ == IntPtr.Zero)
			{
				this.id_addCallback_Ljava_lang_String_Lcom_google_android_gms_common_api_internal_LifecycleCallback_ = JNIEnv.GetMethodID(this.class_ref, "addCallback", "(Ljava/lang/String;Lcom/google/android/gms/common/api/internal/LifecycleCallback;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_addCallback_Ljava_lang_String_Lcom_google_android_gms_common_api_internal_LifecycleCallback_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x000045DB File Offset: 0x000027DB
		private static Delegate GetGetCallbackOrNull_Ljava_lang_String_Ljava_lang_Class_Handler()
		{
			if (ILifecycleFragmentInvoker.cb_getCallbackOrNull_Ljava_lang_String_Ljava_lang_Class_ == null)
			{
				ILifecycleFragmentInvoker.cb_getCallbackOrNull_Ljava_lang_String_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(ILifecycleFragmentInvoker.n_GetCallbackOrNull_Ljava_lang_String_Ljava_lang_Class_));
			}
			return ILifecycleFragmentInvoker.cb_getCallbackOrNull_Ljava_lang_String_Ljava_lang_Class_;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00004600 File Offset: 0x00002800
		private static IntPtr n_GetCallbackOrNull_Ljava_lang_String_Ljava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			ILifecycleFragment @object = Java.Lang.Object.GetObject<ILifecycleFragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetCallbackOrNull(@string, object2));
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00004634 File Offset: 0x00002834
		public unsafe Java.Lang.Object GetCallbackOrNull(string p0, Class p1)
		{
			if (this.id_getCallbackOrNull_Ljava_lang_String_Ljava_lang_Class_ == IntPtr.Zero)
			{
				this.id_getCallbackOrNull_Ljava_lang_String_Ljava_lang_Class_ = JNIEnv.GetMethodID(this.class_ref, "getCallbackOrNull", "(Ljava/lang/String;Ljava/lang/Class;)Lcom/google/android/gms/common/api/internal/LifecycleCallback;");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_getCallbackOrNull_Ljava_lang_String_Ljava_lang_Class_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x000046CD File Offset: 0x000028CD
		private static Delegate GetStartActivityForResult_Landroid_content_Intent_IHandler()
		{
			if (ILifecycleFragmentInvoker.cb_startActivityForResult_Landroid_content_Intent_I == null)
			{
				ILifecycleFragmentInvoker.cb_startActivityForResult_Landroid_content_Intent_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(ILifecycleFragmentInvoker.n_StartActivityForResult_Landroid_content_Intent_I));
			}
			return ILifecycleFragmentInvoker.cb_startActivityForResult_Landroid_content_Intent_I;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000046F4 File Offset: 0x000028F4
		private static void n_StartActivityForResult_Landroid_content_Intent_I(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			ILifecycleFragment @object = Java.Lang.Object.GetObject<ILifecycleFragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Intent object2 = Java.Lang.Object.GetObject<Intent>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.StartActivityForResult(object2, p1);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00004718 File Offset: 0x00002918
		public unsafe void StartActivityForResult(Intent p0, int p1)
		{
			if (this.id_startActivityForResult_Landroid_content_Intent_I == IntPtr.Zero)
			{
				this.id_startActivityForResult_Landroid_content_Intent_I = JNIEnv.GetMethodID(this.class_ref, "startActivityForResult", "(Landroid/content/Intent;I)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue(p1);
			JNIEnv.CallVoidMethod(base.Handle, this.id_startActivityForResult_Landroid_content_Intent_I, ptr);
		}

		// Token: 0x0400002A RID: 42
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/internal/LifecycleFragment", typeof(ILifecycleFragmentInvoker));

		// Token: 0x0400002B RID: 43
		private IntPtr class_ref;

		// Token: 0x0400002C RID: 44
		private static Delegate cb_isCreated;

		// Token: 0x0400002D RID: 45
		private IntPtr id_isCreated;

		// Token: 0x0400002E RID: 46
		private static Delegate cb_isStarted;

		// Token: 0x0400002F RID: 47
		private IntPtr id_isStarted;

		// Token: 0x04000030 RID: 48
		private static Delegate cb_getLifecycleActivity;

		// Token: 0x04000031 RID: 49
		private IntPtr id_getLifecycleActivity;

		// Token: 0x04000032 RID: 50
		private static Delegate cb_addCallback_Ljava_lang_String_Lcom_google_android_gms_common_api_internal_LifecycleCallback_;

		// Token: 0x04000033 RID: 51
		private IntPtr id_addCallback_Ljava_lang_String_Lcom_google_android_gms_common_api_internal_LifecycleCallback_;

		// Token: 0x04000034 RID: 52
		private static Delegate cb_getCallbackOrNull_Ljava_lang_String_Ljava_lang_Class_;

		// Token: 0x04000035 RID: 53
		private IntPtr id_getCallbackOrNull_Ljava_lang_String_Ljava_lang_Class_;

		// Token: 0x04000036 RID: 54
		private static Delegate cb_startActivityForResult_Landroid_content_Intent_I;

		// Token: 0x04000037 RID: 55
		private IntPtr id_startActivityForResult_Landroid_content_Intent_I;
	}
}
