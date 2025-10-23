using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Content
{
	// Token: 0x0200029F RID: 671
	[Register("android/content/SharedPreferences$OnSharedPreferenceChangeListener", DoNotGenerateAcw = true)]
	internal class ISharedPreferencesOnSharedPreferenceChangeListenerInvoker : Java.Lang.Object, ISharedPreferencesOnSharedPreferenceChangeListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x060019C8 RID: 6600 RVA: 0x00042F10 File Offset: 0x00041110
		private static IntPtr java_class_ref
		{
			get
			{
				return ISharedPreferencesOnSharedPreferenceChangeListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x060019C9 RID: 6601 RVA: 0x00042F34 File Offset: 0x00041134
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISharedPreferencesOnSharedPreferenceChangeListenerInvoker._members;
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x060019CA RID: 6602 RVA: 0x00042F3B File Offset: 0x0004113B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x060019CB RID: 6603 RVA: 0x00042F43 File Offset: 0x00041143
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISharedPreferencesOnSharedPreferenceChangeListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060019CC RID: 6604 RVA: 0x00042F4F File Offset: 0x0004114F
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISharedPreferencesOnSharedPreferenceChangeListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.content.SharedPreferences.OnSharedPreferenceChangeListener'.");
			}
			return handle;
		}

		// Token: 0x060019CD RID: 6605 RVA: 0x00042F7A File Offset: 0x0004117A
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060019CE RID: 6606 RVA: 0x00042FAC File Offset: 0x000411AC
		public ISharedPreferencesOnSharedPreferenceChangeListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ISharedPreferencesOnSharedPreferenceChangeListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060019CF RID: 6607 RVA: 0x00042FE4 File Offset: 0x000411E4
		private static Delegate GetOnSharedPreferenceChanged_Landroid_content_SharedPreferences_Ljava_lang_String_Handler()
		{
			if (ISharedPreferencesOnSharedPreferenceChangeListenerInvoker.cb_onSharedPreferenceChanged_Landroid_content_SharedPreferences_Ljava_lang_String_ == null)
			{
				ISharedPreferencesOnSharedPreferenceChangeListenerInvoker.cb_onSharedPreferenceChanged_Landroid_content_SharedPreferences_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(ISharedPreferencesOnSharedPreferenceChangeListenerInvoker.n_OnSharedPreferenceChanged_Landroid_content_SharedPreferences_Ljava_lang_String_));
			}
			return ISharedPreferencesOnSharedPreferenceChangeListenerInvoker.cb_onSharedPreferenceChanged_Landroid_content_SharedPreferences_Ljava_lang_String_;
		}

		// Token: 0x060019D0 RID: 6608 RVA: 0x00043008 File Offset: 0x00041208
		private static void n_OnSharedPreferenceChanged_Landroid_content_SharedPreferences_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_sharedPreferences, IntPtr native_key)
		{
			ISharedPreferencesOnSharedPreferenceChangeListener @object = Java.Lang.Object.GetObject<ISharedPreferencesOnSharedPreferenceChangeListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ISharedPreferences object2 = Java.Lang.Object.GetObject<ISharedPreferences>(native_sharedPreferences, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
			@object.OnSharedPreferenceChanged(object2, @string);
		}

		// Token: 0x060019D1 RID: 6609 RVA: 0x00043034 File Offset: 0x00041234
		public unsafe void OnSharedPreferenceChanged(ISharedPreferences sharedPreferences, string key)
		{
			if (this.id_onSharedPreferenceChanged_Landroid_content_SharedPreferences_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_onSharedPreferenceChanged_Landroid_content_SharedPreferences_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "onSharedPreferenceChanged", "(Landroid/content/SharedPreferences;Ljava/lang/String;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(key);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((sharedPreferences == null) ? IntPtr.Zero : ((Java.Lang.Object)sharedPreferences).Handle);
			ptr[1] = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onSharedPreferenceChanged_Landroid_content_SharedPreferences_Ljava_lang_String_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x04000AC9 RID: 2761
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/content/SharedPreferences$OnSharedPreferenceChangeListener", typeof(ISharedPreferencesOnSharedPreferenceChangeListenerInvoker));

		// Token: 0x04000ACA RID: 2762
		private IntPtr class_ref;

		// Token: 0x04000ACB RID: 2763
		private static Delegate cb_onSharedPreferenceChanged_Landroid_content_SharedPreferences_Ljava_lang_String_;

		// Token: 0x04000ACC RID: 2764
		private IntPtr id_onSharedPreferenceChanged_Landroid_content_SharedPreferences_Ljava_lang_String_;
	}
}
