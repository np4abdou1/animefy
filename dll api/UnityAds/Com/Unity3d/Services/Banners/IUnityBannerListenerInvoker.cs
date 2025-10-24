using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Banners
{
	// Token: 0x020001A4 RID: 420
	[Register("com/unity3d/services/banners/IUnityBannerListener", DoNotGenerateAcw = true)]
	internal class IUnityBannerListenerInvoker : Java.Lang.Object, IUnityBannerListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x0600132B RID: 4907 RVA: 0x0003669C File Offset: 0x0003489C
		private static IntPtr java_class_ref
		{
			get
			{
				return IUnityBannerListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x0600132C RID: 4908 RVA: 0x000366C0 File Offset: 0x000348C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IUnityBannerListenerInvoker._members;
			}
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x0600132D RID: 4909 RVA: 0x000366C7 File Offset: 0x000348C7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x0600132E RID: 4910 RVA: 0x000366CF File Offset: 0x000348CF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IUnityBannerListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600132F RID: 4911 RVA: 0x000366DB File Offset: 0x000348DB
		public static IUnityBannerListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IUnityBannerListener>(handle, transfer);
		}

		// Token: 0x06001330 RID: 4912 RVA: 0x000366E4 File Offset: 0x000348E4
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IUnityBannerListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.banners.IUnityBannerListener'.");
			}
			return handle;
		}

		// Token: 0x06001331 RID: 4913 RVA: 0x0003670F File Offset: 0x0003490F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001332 RID: 4914 RVA: 0x00036740 File Offset: 0x00034940
		public IUnityBannerListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IUnityBannerListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001333 RID: 4915 RVA: 0x00036778 File Offset: 0x00034978
		private static Delegate GetOnUnityBannerClick_Ljava_lang_String_Handler()
		{
			if (IUnityBannerListenerInvoker.cb_onUnityBannerClick_Ljava_lang_String_ == null)
			{
				IUnityBannerListenerInvoker.cb_onUnityBannerClick_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IUnityBannerListenerInvoker.n_OnUnityBannerClick_Ljava_lang_String_));
			}
			return IUnityBannerListenerInvoker.cb_onUnityBannerClick_Ljava_lang_String_;
		}

		// Token: 0x06001334 RID: 4916 RVA: 0x0003679C File Offset: 0x0003499C
		private static void n_OnUnityBannerClick_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IUnityBannerListener @object = Java.Lang.Object.GetObject<IUnityBannerListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnUnityBannerClick(@string);
		}

		// Token: 0x06001335 RID: 4917 RVA: 0x000367C0 File Offset: 0x000349C0
		public unsafe void OnUnityBannerClick(string p0)
		{
			if (this.id_onUnityBannerClick_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_onUnityBannerClick_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "onUnityBannerClick", "(Ljava/lang/String;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onUnityBannerClick_Ljava_lang_String_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x06001336 RID: 4918 RVA: 0x00036831 File Offset: 0x00034A31
		private static Delegate GetOnUnityBannerError_Ljava_lang_String_Handler()
		{
			if (IUnityBannerListenerInvoker.cb_onUnityBannerError_Ljava_lang_String_ == null)
			{
				IUnityBannerListenerInvoker.cb_onUnityBannerError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IUnityBannerListenerInvoker.n_OnUnityBannerError_Ljava_lang_String_));
			}
			return IUnityBannerListenerInvoker.cb_onUnityBannerError_Ljava_lang_String_;
		}

		// Token: 0x06001337 RID: 4919 RVA: 0x00036858 File Offset: 0x00034A58
		private static void n_OnUnityBannerError_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IUnityBannerListener @object = Java.Lang.Object.GetObject<IUnityBannerListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnUnityBannerError(@string);
		}

		// Token: 0x06001338 RID: 4920 RVA: 0x0003687C File Offset: 0x00034A7C
		public unsafe void OnUnityBannerError(string p0)
		{
			if (this.id_onUnityBannerError_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_onUnityBannerError_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "onUnityBannerError", "(Ljava/lang/String;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onUnityBannerError_Ljava_lang_String_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x06001339 RID: 4921 RVA: 0x000368ED File Offset: 0x00034AED
		private static Delegate GetOnUnityBannerHide_Ljava_lang_String_Handler()
		{
			if (IUnityBannerListenerInvoker.cb_onUnityBannerHide_Ljava_lang_String_ == null)
			{
				IUnityBannerListenerInvoker.cb_onUnityBannerHide_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IUnityBannerListenerInvoker.n_OnUnityBannerHide_Ljava_lang_String_));
			}
			return IUnityBannerListenerInvoker.cb_onUnityBannerHide_Ljava_lang_String_;
		}

		// Token: 0x0600133A RID: 4922 RVA: 0x00036914 File Offset: 0x00034B14
		private static void n_OnUnityBannerHide_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IUnityBannerListener @object = Java.Lang.Object.GetObject<IUnityBannerListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnUnityBannerHide(@string);
		}

		// Token: 0x0600133B RID: 4923 RVA: 0x00036938 File Offset: 0x00034B38
		public unsafe void OnUnityBannerHide(string p0)
		{
			if (this.id_onUnityBannerHide_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_onUnityBannerHide_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "onUnityBannerHide", "(Ljava/lang/String;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onUnityBannerHide_Ljava_lang_String_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x0600133C RID: 4924 RVA: 0x000369A9 File Offset: 0x00034BA9
		private static Delegate GetOnUnityBannerLoaded_Ljava_lang_String_Landroid_view_View_Handler()
		{
			if (IUnityBannerListenerInvoker.cb_onUnityBannerLoaded_Ljava_lang_String_Landroid_view_View_ == null)
			{
				IUnityBannerListenerInvoker.cb_onUnityBannerLoaded_Ljava_lang_String_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IUnityBannerListenerInvoker.n_OnUnityBannerLoaded_Ljava_lang_String_Landroid_view_View_));
			}
			return IUnityBannerListenerInvoker.cb_onUnityBannerLoaded_Ljava_lang_String_Landroid_view_View_;
		}

		// Token: 0x0600133D RID: 4925 RVA: 0x000369D0 File Offset: 0x00034BD0
		private static void n_OnUnityBannerLoaded_Ljava_lang_String_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IUnityBannerListener @object = Java.Lang.Object.GetObject<IUnityBannerListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.OnUnityBannerLoaded(@string, object2);
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x000369FC File Offset: 0x00034BFC
		public unsafe void OnUnityBannerLoaded(string p0, View p1)
		{
			if (this.id_onUnityBannerLoaded_Ljava_lang_String_Landroid_view_View_ == IntPtr.Zero)
			{
				this.id_onUnityBannerLoaded_Ljava_lang_String_Landroid_view_View_ = JNIEnv.GetMethodID(this.class_ref, "onUnityBannerLoaded", "(Ljava/lang/String;Landroid/view/View;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onUnityBannerLoaded_Ljava_lang_String_Landroid_view_View_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x00036A8F File Offset: 0x00034C8F
		private static Delegate GetOnUnityBannerShow_Ljava_lang_String_Handler()
		{
			if (IUnityBannerListenerInvoker.cb_onUnityBannerShow_Ljava_lang_String_ == null)
			{
				IUnityBannerListenerInvoker.cb_onUnityBannerShow_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IUnityBannerListenerInvoker.n_OnUnityBannerShow_Ljava_lang_String_));
			}
			return IUnityBannerListenerInvoker.cb_onUnityBannerShow_Ljava_lang_String_;
		}

		// Token: 0x06001340 RID: 4928 RVA: 0x00036AB4 File Offset: 0x00034CB4
		private static void n_OnUnityBannerShow_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IUnityBannerListener @object = Java.Lang.Object.GetObject<IUnityBannerListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnUnityBannerShow(@string);
		}

		// Token: 0x06001341 RID: 4929 RVA: 0x00036AD8 File Offset: 0x00034CD8
		public unsafe void OnUnityBannerShow(string p0)
		{
			if (this.id_onUnityBannerShow_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_onUnityBannerShow_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "onUnityBannerShow", "(Ljava/lang/String;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onUnityBannerShow_Ljava_lang_String_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x06001342 RID: 4930 RVA: 0x00036B49 File Offset: 0x00034D49
		private static Delegate GetOnUnityBannerUnloaded_Ljava_lang_String_Handler()
		{
			if (IUnityBannerListenerInvoker.cb_onUnityBannerUnloaded_Ljava_lang_String_ == null)
			{
				IUnityBannerListenerInvoker.cb_onUnityBannerUnloaded_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IUnityBannerListenerInvoker.n_OnUnityBannerUnloaded_Ljava_lang_String_));
			}
			return IUnityBannerListenerInvoker.cb_onUnityBannerUnloaded_Ljava_lang_String_;
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x00036B70 File Offset: 0x00034D70
		private static void n_OnUnityBannerUnloaded_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IUnityBannerListener @object = Java.Lang.Object.GetObject<IUnityBannerListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnUnityBannerUnloaded(@string);
		}

		// Token: 0x06001344 RID: 4932 RVA: 0x00036B94 File Offset: 0x00034D94
		public unsafe void OnUnityBannerUnloaded(string p0)
		{
			if (this.id_onUnityBannerUnloaded_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_onUnityBannerUnloaded_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "onUnityBannerUnloaded", "(Ljava/lang/String;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onUnityBannerUnloaded_Ljava_lang_String_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x04000485 RID: 1157
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/banners/IUnityBannerListener", typeof(IUnityBannerListenerInvoker));

		// Token: 0x04000486 RID: 1158
		private IntPtr class_ref;

		// Token: 0x04000487 RID: 1159
		private static Delegate cb_onUnityBannerClick_Ljava_lang_String_;

		// Token: 0x04000488 RID: 1160
		private IntPtr id_onUnityBannerClick_Ljava_lang_String_;

		// Token: 0x04000489 RID: 1161
		private static Delegate cb_onUnityBannerError_Ljava_lang_String_;

		// Token: 0x0400048A RID: 1162
		private IntPtr id_onUnityBannerError_Ljava_lang_String_;

		// Token: 0x0400048B RID: 1163
		private static Delegate cb_onUnityBannerHide_Ljava_lang_String_;

		// Token: 0x0400048C RID: 1164
		private IntPtr id_onUnityBannerHide_Ljava_lang_String_;

		// Token: 0x0400048D RID: 1165
		private static Delegate cb_onUnityBannerLoaded_Ljava_lang_String_Landroid_view_View_;

		// Token: 0x0400048E RID: 1166
		private IntPtr id_onUnityBannerLoaded_Ljava_lang_String_Landroid_view_View_;

		// Token: 0x0400048F RID: 1167
		private static Delegate cb_onUnityBannerShow_Ljava_lang_String_;

		// Token: 0x04000490 RID: 1168
		private IntPtr id_onUnityBannerShow_Ljava_lang_String_;

		// Token: 0x04000491 RID: 1169
		private static Delegate cb_onUnityBannerUnloaded_Ljava_lang_String_;

		// Token: 0x04000492 RID: 1170
		private IntPtr id_onUnityBannerUnloaded_Ljava_lang_String_;
	}
}
