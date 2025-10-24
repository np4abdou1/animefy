using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Content
{
	// Token: 0x0200029D RID: 669
	[Register("android/content/SharedPreferences$Editor", DoNotGenerateAcw = true)]
	internal class ISharedPreferencesEditorInvoker : Java.Lang.Object, ISharedPreferencesEditor, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x060019A1 RID: 6561 RVA: 0x0004269C File Offset: 0x0004089C
		private static IntPtr java_class_ref
		{
			get
			{
				return ISharedPreferencesEditorInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x060019A2 RID: 6562 RVA: 0x000426C0 File Offset: 0x000408C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISharedPreferencesEditorInvoker._members;
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x060019A3 RID: 6563 RVA: 0x000426C7 File Offset: 0x000408C7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x060019A4 RID: 6564 RVA: 0x000426CF File Offset: 0x000408CF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISharedPreferencesEditorInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060019A5 RID: 6565 RVA: 0x000426DB File Offset: 0x000408DB
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISharedPreferencesEditorInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.content.SharedPreferences.Editor'.");
			}
			return handle;
		}

		// Token: 0x060019A6 RID: 6566 RVA: 0x00042706 File Offset: 0x00040906
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060019A7 RID: 6567 RVA: 0x00042738 File Offset: 0x00040938
		public ISharedPreferencesEditorInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ISharedPreferencesEditorInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060019A8 RID: 6568 RVA: 0x00042770 File Offset: 0x00040970
		private static Delegate GetApplyHandler()
		{
			if (ISharedPreferencesEditorInvoker.cb_apply == null)
			{
				ISharedPreferencesEditorInvoker.cb_apply = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ISharedPreferencesEditorInvoker.n_Apply));
			}
			return ISharedPreferencesEditorInvoker.cb_apply;
		}

		// Token: 0x060019A9 RID: 6569 RVA: 0x00042794 File Offset: 0x00040994
		private static void n_Apply(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ISharedPreferencesEditor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Apply();
		}

		// Token: 0x060019AA RID: 6570 RVA: 0x000427A3 File Offset: 0x000409A3
		public void Apply()
		{
			if (this.id_apply == IntPtr.Zero)
			{
				this.id_apply = JNIEnv.GetMethodID(this.class_ref, "apply", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_apply);
		}

		// Token: 0x060019AB RID: 6571 RVA: 0x000427E3 File Offset: 0x000409E3
		private static Delegate GetClearHandler()
		{
			if (ISharedPreferencesEditorInvoker.cb_clear == null)
			{
				ISharedPreferencesEditorInvoker.cb_clear = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISharedPreferencesEditorInvoker.n_Clear));
			}
			return ISharedPreferencesEditorInvoker.cb_clear;
		}

		// Token: 0x060019AC RID: 6572 RVA: 0x00042807 File Offset: 0x00040A07
		private static IntPtr n_Clear(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISharedPreferencesEditor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Clear());
		}

		// Token: 0x060019AD RID: 6573 RVA: 0x0004281C File Offset: 0x00040A1C
		public ISharedPreferencesEditor Clear()
		{
			if (this.id_clear == IntPtr.Zero)
			{
				this.id_clear = JNIEnv.GetMethodID(this.class_ref, "clear", "()Landroid/content/SharedPreferences$Editor;");
			}
			return Java.Lang.Object.GetObject<ISharedPreferencesEditor>(JNIEnv.CallObjectMethod(base.Handle, this.id_clear), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060019AE RID: 6574 RVA: 0x0004286D File Offset: 0x00040A6D
		private static Delegate GetCommitHandler()
		{
			if (ISharedPreferencesEditorInvoker.cb_commit == null)
			{
				ISharedPreferencesEditorInvoker.cb_commit = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ISharedPreferencesEditorInvoker.n_Commit));
			}
			return ISharedPreferencesEditorInvoker.cb_commit;
		}

		// Token: 0x060019AF RID: 6575 RVA: 0x00042891 File Offset: 0x00040A91
		private static bool n_Commit(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ISharedPreferencesEditor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Commit();
		}

		// Token: 0x060019B0 RID: 6576 RVA: 0x000428A0 File Offset: 0x00040AA0
		public bool Commit()
		{
			if (this.id_commit == IntPtr.Zero)
			{
				this.id_commit = JNIEnv.GetMethodID(this.class_ref, "commit", "()Z");
			}
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_commit);
		}

		// Token: 0x060019B1 RID: 6577 RVA: 0x000428E0 File Offset: 0x00040AE0
		private static Delegate GetPutBoolean_Ljava_lang_String_ZHandler()
		{
			if (ISharedPreferencesEditorInvoker.cb_putBoolean_Ljava_lang_String_Z == null)
			{
				ISharedPreferencesEditorInvoker.cb_putBoolean_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZ_L(ISharedPreferencesEditorInvoker.n_PutBoolean_Ljava_lang_String_Z));
			}
			return ISharedPreferencesEditorInvoker.cb_putBoolean_Ljava_lang_String_Z;
		}

		// Token: 0x060019B2 RID: 6578 RVA: 0x00042904 File Offset: 0x00040B04
		private static IntPtr n_PutBoolean_Ljava_lang_String_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_key, bool value)
		{
			ISharedPreferencesEditor @object = Java.Lang.Object.GetObject<ISharedPreferencesEditor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.PutBoolean(@string, value));
		}

		// Token: 0x060019B3 RID: 6579 RVA: 0x00042930 File Offset: 0x00040B30
		public unsafe ISharedPreferencesEditor PutBoolean(string key, bool value)
		{
			if (this.id_putBoolean_Ljava_lang_String_Z == IntPtr.Zero)
			{
				this.id_putBoolean_Ljava_lang_String_Z = JNIEnv.GetMethodID(this.class_ref, "putBoolean", "(Ljava/lang/String;Z)Landroid/content/SharedPreferences$Editor;");
			}
			IntPtr intPtr = JNIEnv.NewString(key);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(value);
			ISharedPreferencesEditor @object = Java.Lang.Object.GetObject<ISharedPreferencesEditor>(JNIEnv.CallObjectMethod(base.Handle, this.id_putBoolean_Ljava_lang_String_Z, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x060019B4 RID: 6580 RVA: 0x000429BA File Offset: 0x00040BBA
		private static Delegate GetPutFloat_Ljava_lang_String_FHandler()
		{
			if (ISharedPreferencesEditorInvoker.cb_putFloat_Ljava_lang_String_F == null)
			{
				ISharedPreferencesEditorInvoker.cb_putFloat_Ljava_lang_String_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLF_L(ISharedPreferencesEditorInvoker.n_PutFloat_Ljava_lang_String_F));
			}
			return ISharedPreferencesEditorInvoker.cb_putFloat_Ljava_lang_String_F;
		}

		// Token: 0x060019B5 RID: 6581 RVA: 0x000429E0 File Offset: 0x00040BE0
		private static IntPtr n_PutFloat_Ljava_lang_String_F(IntPtr jnienv, IntPtr native__this, IntPtr native_key, float value)
		{
			ISharedPreferencesEditor @object = Java.Lang.Object.GetObject<ISharedPreferencesEditor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.PutFloat(@string, value));
		}

		// Token: 0x060019B6 RID: 6582 RVA: 0x00042A0C File Offset: 0x00040C0C
		public unsafe ISharedPreferencesEditor PutFloat(string key, float value)
		{
			if (this.id_putFloat_Ljava_lang_String_F == IntPtr.Zero)
			{
				this.id_putFloat_Ljava_lang_String_F = JNIEnv.GetMethodID(this.class_ref, "putFloat", "(Ljava/lang/String;F)Landroid/content/SharedPreferences$Editor;");
			}
			IntPtr intPtr = JNIEnv.NewString(key);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(value);
			ISharedPreferencesEditor @object = Java.Lang.Object.GetObject<ISharedPreferencesEditor>(JNIEnv.CallObjectMethod(base.Handle, this.id_putFloat_Ljava_lang_String_F, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x060019B7 RID: 6583 RVA: 0x00042A96 File Offset: 0x00040C96
		private static Delegate GetPutInt_Ljava_lang_String_IHandler()
		{
			if (ISharedPreferencesEditorInvoker.cb_putInt_Ljava_lang_String_I == null)
			{
				ISharedPreferencesEditorInvoker.cb_putInt_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_L(ISharedPreferencesEditorInvoker.n_PutInt_Ljava_lang_String_I));
			}
			return ISharedPreferencesEditorInvoker.cb_putInt_Ljava_lang_String_I;
		}

		// Token: 0x060019B8 RID: 6584 RVA: 0x00042ABC File Offset: 0x00040CBC
		private static IntPtr n_PutInt_Ljava_lang_String_I(IntPtr jnienv, IntPtr native__this, IntPtr native_key, int value)
		{
			ISharedPreferencesEditor @object = Java.Lang.Object.GetObject<ISharedPreferencesEditor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.PutInt(@string, value));
		}

		// Token: 0x060019B9 RID: 6585 RVA: 0x00042AE8 File Offset: 0x00040CE8
		public unsafe ISharedPreferencesEditor PutInt(string key, int value)
		{
			if (this.id_putInt_Ljava_lang_String_I == IntPtr.Zero)
			{
				this.id_putInt_Ljava_lang_String_I = JNIEnv.GetMethodID(this.class_ref, "putInt", "(Ljava/lang/String;I)Landroid/content/SharedPreferences$Editor;");
			}
			IntPtr intPtr = JNIEnv.NewString(key);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(value);
			ISharedPreferencesEditor @object = Java.Lang.Object.GetObject<ISharedPreferencesEditor>(JNIEnv.CallObjectMethod(base.Handle, this.id_putInt_Ljava_lang_String_I, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x060019BA RID: 6586 RVA: 0x00042B72 File Offset: 0x00040D72
		private static Delegate GetPutLong_Ljava_lang_String_JHandler()
		{
			if (ISharedPreferencesEditorInvoker.cb_putLong_Ljava_lang_String_J == null)
			{
				ISharedPreferencesEditorInvoker.cb_putLong_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLJ_L(ISharedPreferencesEditorInvoker.n_PutLong_Ljava_lang_String_J));
			}
			return ISharedPreferencesEditorInvoker.cb_putLong_Ljava_lang_String_J;
		}

		// Token: 0x060019BB RID: 6587 RVA: 0x00042B98 File Offset: 0x00040D98
		private static IntPtr n_PutLong_Ljava_lang_String_J(IntPtr jnienv, IntPtr native__this, IntPtr native_key, long value)
		{
			ISharedPreferencesEditor @object = Java.Lang.Object.GetObject<ISharedPreferencesEditor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.PutLong(@string, value));
		}

		// Token: 0x060019BC RID: 6588 RVA: 0x00042BC4 File Offset: 0x00040DC4
		public unsafe ISharedPreferencesEditor PutLong(string key, long value)
		{
			if (this.id_putLong_Ljava_lang_String_J == IntPtr.Zero)
			{
				this.id_putLong_Ljava_lang_String_J = JNIEnv.GetMethodID(this.class_ref, "putLong", "(Ljava/lang/String;J)Landroid/content/SharedPreferences$Editor;");
			}
			IntPtr intPtr = JNIEnv.NewString(key);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(value);
			ISharedPreferencesEditor @object = Java.Lang.Object.GetObject<ISharedPreferencesEditor>(JNIEnv.CallObjectMethod(base.Handle, this.id_putLong_Ljava_lang_String_J, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x060019BD RID: 6589 RVA: 0x00042C4E File Offset: 0x00040E4E
		private static Delegate GetPutString_Ljava_lang_String_Ljava_lang_String_Handler()
		{
			if (ISharedPreferencesEditorInvoker.cb_putString_Ljava_lang_String_Ljava_lang_String_ == null)
			{
				ISharedPreferencesEditorInvoker.cb_putString_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(ISharedPreferencesEditorInvoker.n_PutString_Ljava_lang_String_Ljava_lang_String_));
			}
			return ISharedPreferencesEditorInvoker.cb_putString_Ljava_lang_String_Ljava_lang_String_;
		}

		// Token: 0x060019BE RID: 6590 RVA: 0x00042C74 File Offset: 0x00040E74
		private static IntPtr n_PutString_Ljava_lang_String_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			ISharedPreferencesEditor @object = Java.Lang.Object.GetObject<ISharedPreferencesEditor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_value, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.PutString(@string, string2));
		}

		// Token: 0x060019BF RID: 6591 RVA: 0x00042CA8 File Offset: 0x00040EA8
		public unsafe ISharedPreferencesEditor PutString(string key, string value)
		{
			if (this.id_putString_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_putString_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "putString", "(Ljava/lang/String;Ljava/lang/String;)Landroid/content/SharedPreferences$Editor;");
			}
			IntPtr intPtr = JNIEnv.NewString(key);
			IntPtr intPtr2 = JNIEnv.NewString(value);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(intPtr2);
			ISharedPreferencesEditor @object = Java.Lang.Object.GetObject<ISharedPreferencesEditor>(JNIEnv.CallObjectMethod(base.Handle, this.id_putString_Ljava_lang_String_Ljava_lang_String_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
			return @object;
		}

		// Token: 0x060019C0 RID: 6592 RVA: 0x00042D3F File Offset: 0x00040F3F
		private static Delegate GetPutStringSet_Ljava_lang_String_Ljava_util_Set_Handler()
		{
			if (ISharedPreferencesEditorInvoker.cb_putStringSet_Ljava_lang_String_Ljava_util_Set_ == null)
			{
				ISharedPreferencesEditorInvoker.cb_putStringSet_Ljava_lang_String_Ljava_util_Set_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(ISharedPreferencesEditorInvoker.n_PutStringSet_Ljava_lang_String_Ljava_util_Set_));
			}
			return ISharedPreferencesEditorInvoker.cb_putStringSet_Ljava_lang_String_Ljava_util_Set_;
		}

		// Token: 0x060019C1 RID: 6593 RVA: 0x00042D64 File Offset: 0x00040F64
		private static IntPtr n_PutStringSet_Ljava_lang_String_Ljava_util_Set_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_values)
		{
			ISharedPreferencesEditor @object = Java.Lang.Object.GetObject<ISharedPreferencesEditor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
			ICollection<string> values = JavaSet<string>.FromJniHandle(native_values, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.PutStringSet(@string, values));
		}

		// Token: 0x060019C2 RID: 6594 RVA: 0x00042D98 File Offset: 0x00040F98
		public unsafe ISharedPreferencesEditor PutStringSet(string key, ICollection<string> values)
		{
			if (this.id_putStringSet_Ljava_lang_String_Ljava_util_Set_ == IntPtr.Zero)
			{
				this.id_putStringSet_Ljava_lang_String_Ljava_util_Set_ = JNIEnv.GetMethodID(this.class_ref, "putStringSet", "(Ljava/lang/String;Ljava/util/Set;)Landroid/content/SharedPreferences$Editor;");
			}
			IntPtr intPtr = JNIEnv.NewString(key);
			IntPtr intPtr2 = JavaSet<string>.ToLocalJniHandle(values);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(intPtr2);
			ISharedPreferencesEditor @object = Java.Lang.Object.GetObject<ISharedPreferencesEditor>(JNIEnv.CallObjectMethod(base.Handle, this.id_putStringSet_Ljava_lang_String_Ljava_util_Set_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
			return @object;
		}

		// Token: 0x060019C3 RID: 6595 RVA: 0x00042E2F File Offset: 0x0004102F
		private static Delegate GetRemove_Ljava_lang_String_Handler()
		{
			if (ISharedPreferencesEditorInvoker.cb_remove_Ljava_lang_String_ == null)
			{
				ISharedPreferencesEditorInvoker.cb_remove_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ISharedPreferencesEditorInvoker.n_Remove_Ljava_lang_String_));
			}
			return ISharedPreferencesEditorInvoker.cb_remove_Ljava_lang_String_;
		}

		// Token: 0x060019C4 RID: 6596 RVA: 0x00042E54 File Offset: 0x00041054
		private static IntPtr n_Remove_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			ISharedPreferencesEditor @object = Java.Lang.Object.GetObject<ISharedPreferencesEditor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Remove(@string));
		}

		// Token: 0x060019C5 RID: 6597 RVA: 0x00042E7C File Offset: 0x0004107C
		public unsafe ISharedPreferencesEditor Remove(string key)
		{
			if (this.id_remove_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_remove_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "remove", "(Ljava/lang/String;)Landroid/content/SharedPreferences$Editor;");
			}
			IntPtr intPtr = JNIEnv.NewString(key);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ISharedPreferencesEditor @object = Java.Lang.Object.GetObject<ISharedPreferencesEditor>(JNIEnv.CallObjectMethod(base.Handle, this.id_remove_Ljava_lang_String_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x04000AB3 RID: 2739
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/content/SharedPreferences$Editor", typeof(ISharedPreferencesEditorInvoker));

		// Token: 0x04000AB4 RID: 2740
		private IntPtr class_ref;

		// Token: 0x04000AB5 RID: 2741
		private static Delegate cb_apply;

		// Token: 0x04000AB6 RID: 2742
		private IntPtr id_apply;

		// Token: 0x04000AB7 RID: 2743
		private static Delegate cb_clear;

		// Token: 0x04000AB8 RID: 2744
		private IntPtr id_clear;

		// Token: 0x04000AB9 RID: 2745
		private static Delegate cb_commit;

		// Token: 0x04000ABA RID: 2746
		private IntPtr id_commit;

		// Token: 0x04000ABB RID: 2747
		private static Delegate cb_putBoolean_Ljava_lang_String_Z;

		// Token: 0x04000ABC RID: 2748
		private IntPtr id_putBoolean_Ljava_lang_String_Z;

		// Token: 0x04000ABD RID: 2749
		private static Delegate cb_putFloat_Ljava_lang_String_F;

		// Token: 0x04000ABE RID: 2750
		private IntPtr id_putFloat_Ljava_lang_String_F;

		// Token: 0x04000ABF RID: 2751
		private static Delegate cb_putInt_Ljava_lang_String_I;

		// Token: 0x04000AC0 RID: 2752
		private IntPtr id_putInt_Ljava_lang_String_I;

		// Token: 0x04000AC1 RID: 2753
		private static Delegate cb_putLong_Ljava_lang_String_J;

		// Token: 0x04000AC2 RID: 2754
		private IntPtr id_putLong_Ljava_lang_String_J;

		// Token: 0x04000AC3 RID: 2755
		private static Delegate cb_putString_Ljava_lang_String_Ljava_lang_String_;

		// Token: 0x04000AC4 RID: 2756
		private IntPtr id_putString_Ljava_lang_String_Ljava_lang_String_;

		// Token: 0x04000AC5 RID: 2757
		private static Delegate cb_putStringSet_Ljava_lang_String_Ljava_util_Set_;

		// Token: 0x04000AC6 RID: 2758
		private IntPtr id_putStringSet_Ljava_lang_String_Ljava_util_Set_;

		// Token: 0x04000AC7 RID: 2759
		private static Delegate cb_remove_Ljava_lang_String_;

		// Token: 0x04000AC8 RID: 2760
		private IntPtr id_remove_Ljava_lang_String_;
	}
}
