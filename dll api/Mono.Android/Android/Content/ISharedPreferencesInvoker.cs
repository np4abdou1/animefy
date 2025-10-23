using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Content
{
	// Token: 0x020002A1 RID: 673
	[Register("android/content/SharedPreferences", DoNotGenerateAcw = true)]
	internal class ISharedPreferencesInvoker : Java.Lang.Object, ISharedPreferences, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x060019DE RID: 6622 RVA: 0x000430E8 File Offset: 0x000412E8
		private static IntPtr java_class_ref
		{
			get
			{
				return ISharedPreferencesInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x060019DF RID: 6623 RVA: 0x0004310C File Offset: 0x0004130C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISharedPreferencesInvoker._members;
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x060019E0 RID: 6624 RVA: 0x00043113 File Offset: 0x00041313
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x060019E1 RID: 6625 RVA: 0x0004311B File Offset: 0x0004131B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISharedPreferencesInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060019E2 RID: 6626 RVA: 0x00043127 File Offset: 0x00041327
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISharedPreferencesInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.content.SharedPreferences'.");
			}
			return handle;
		}

		// Token: 0x060019E3 RID: 6627 RVA: 0x00043152 File Offset: 0x00041352
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060019E4 RID: 6628 RVA: 0x00043184 File Offset: 0x00041384
		public ISharedPreferencesInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ISharedPreferencesInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060019E5 RID: 6629 RVA: 0x000431BC File Offset: 0x000413BC
		private static Delegate GetGetAllHandler()
		{
			if (ISharedPreferencesInvoker.cb_getAll == null)
			{
				ISharedPreferencesInvoker.cb_getAll = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISharedPreferencesInvoker.n_GetAll));
			}
			return ISharedPreferencesInvoker.cb_getAll;
		}

		// Token: 0x060019E6 RID: 6630 RVA: 0x000431E0 File Offset: 0x000413E0
		private static IntPtr n_GetAll(IntPtr jnienv, IntPtr native__this)
		{
			return JavaDictionary<string, object>.ToLocalJniHandle(Java.Lang.Object.GetObject<ISharedPreferences>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).All);
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x060019E7 RID: 6631 RVA: 0x000431F4 File Offset: 0x000413F4
		public IDictionary<string, object> All
		{
			get
			{
				if (this.id_getAll == IntPtr.Zero)
				{
					this.id_getAll = JNIEnv.GetMethodID(this.class_ref, "getAll", "()Ljava/util/Map;");
				}
				return JavaDictionary<string, object>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, this.id_getAll), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060019E8 RID: 6632 RVA: 0x00043245 File Offset: 0x00041445
		private static Delegate GetContains_Ljava_lang_String_Handler()
		{
			if (ISharedPreferencesInvoker.cb_contains_Ljava_lang_String_ == null)
			{
				ISharedPreferencesInvoker.cb_contains_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ISharedPreferencesInvoker.n_Contains_Ljava_lang_String_));
			}
			return ISharedPreferencesInvoker.cb_contains_Ljava_lang_String_;
		}

		// Token: 0x060019E9 RID: 6633 RVA: 0x0004326C File Offset: 0x0004146C
		private static bool n_Contains_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			ISharedPreferences @object = Java.Lang.Object.GetObject<ISharedPreferences>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
			return @object.Contains(@string);
		}

		// Token: 0x060019EA RID: 6634 RVA: 0x00043290 File Offset: 0x00041490
		public unsafe bool Contains(string key)
		{
			if (this.id_contains_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_contains_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "contains", "(Ljava/lang/String;)Z");
			}
			IntPtr intPtr = JNIEnv.NewString(key);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			bool result = JNIEnv.CallBooleanMethod(base.Handle, this.id_contains_Ljava_lang_String_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x060019EB RID: 6635 RVA: 0x00043301 File Offset: 0x00041501
		private static Delegate GetEditHandler()
		{
			if (ISharedPreferencesInvoker.cb_edit == null)
			{
				ISharedPreferencesInvoker.cb_edit = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISharedPreferencesInvoker.n_Edit));
			}
			return ISharedPreferencesInvoker.cb_edit;
		}

		// Token: 0x060019EC RID: 6636 RVA: 0x00043325 File Offset: 0x00041525
		private static IntPtr n_Edit(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISharedPreferences>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Edit());
		}

		// Token: 0x060019ED RID: 6637 RVA: 0x0004333C File Offset: 0x0004153C
		public ISharedPreferencesEditor Edit()
		{
			if (this.id_edit == IntPtr.Zero)
			{
				this.id_edit = JNIEnv.GetMethodID(this.class_ref, "edit", "()Landroid/content/SharedPreferences$Editor;");
			}
			return Java.Lang.Object.GetObject<ISharedPreferencesEditor>(JNIEnv.CallObjectMethod(base.Handle, this.id_edit), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060019EE RID: 6638 RVA: 0x0004338D File Offset: 0x0004158D
		private static Delegate GetGetBoolean_Ljava_lang_String_ZHandler()
		{
			if (ISharedPreferencesInvoker.cb_getBoolean_Ljava_lang_String_Z == null)
			{
				ISharedPreferencesInvoker.cb_getBoolean_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZ_Z(ISharedPreferencesInvoker.n_GetBoolean_Ljava_lang_String_Z));
			}
			return ISharedPreferencesInvoker.cb_getBoolean_Ljava_lang_String_Z;
		}

		// Token: 0x060019EF RID: 6639 RVA: 0x000433B4 File Offset: 0x000415B4
		private static bool n_GetBoolean_Ljava_lang_String_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_key, bool defValue)
		{
			ISharedPreferences @object = Java.Lang.Object.GetObject<ISharedPreferences>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
			return @object.GetBoolean(@string, defValue);
		}

		// Token: 0x060019F0 RID: 6640 RVA: 0x000433D8 File Offset: 0x000415D8
		public unsafe bool GetBoolean(string key, bool defValue)
		{
			if (this.id_getBoolean_Ljava_lang_String_Z == IntPtr.Zero)
			{
				this.id_getBoolean_Ljava_lang_String_Z = JNIEnv.GetMethodID(this.class_ref, "getBoolean", "(Ljava/lang/String;Z)Z");
			}
			IntPtr intPtr = JNIEnv.NewString(key);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(defValue);
			bool result = JNIEnv.CallBooleanMethod(base.Handle, this.id_getBoolean_Ljava_lang_String_Z, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x060019F1 RID: 6641 RVA: 0x0004345C File Offset: 0x0004165C
		private static Delegate GetGetFloat_Ljava_lang_String_FHandler()
		{
			if (ISharedPreferencesInvoker.cb_getFloat_Ljava_lang_String_F == null)
			{
				ISharedPreferencesInvoker.cb_getFloat_Ljava_lang_String_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLF_F(ISharedPreferencesInvoker.n_GetFloat_Ljava_lang_String_F));
			}
			return ISharedPreferencesInvoker.cb_getFloat_Ljava_lang_String_F;
		}

		// Token: 0x060019F2 RID: 6642 RVA: 0x00043480 File Offset: 0x00041680
		private static float n_GetFloat_Ljava_lang_String_F(IntPtr jnienv, IntPtr native__this, IntPtr native_key, float defValue)
		{
			ISharedPreferences @object = Java.Lang.Object.GetObject<ISharedPreferences>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
			return @object.GetFloat(@string, defValue);
		}

		// Token: 0x060019F3 RID: 6643 RVA: 0x000434A4 File Offset: 0x000416A4
		public unsafe float GetFloat(string key, float defValue)
		{
			if (this.id_getFloat_Ljava_lang_String_F == IntPtr.Zero)
			{
				this.id_getFloat_Ljava_lang_String_F = JNIEnv.GetMethodID(this.class_ref, "getFloat", "(Ljava/lang/String;F)F");
			}
			IntPtr intPtr = JNIEnv.NewString(key);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(defValue);
			float result = JNIEnv.CallFloatMethod(base.Handle, this.id_getFloat_Ljava_lang_String_F, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x060019F4 RID: 6644 RVA: 0x00043528 File Offset: 0x00041728
		private static Delegate GetGetInt_Ljava_lang_String_IHandler()
		{
			if (ISharedPreferencesInvoker.cb_getInt_Ljava_lang_String_I == null)
			{
				ISharedPreferencesInvoker.cb_getInt_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_I(ISharedPreferencesInvoker.n_GetInt_Ljava_lang_String_I));
			}
			return ISharedPreferencesInvoker.cb_getInt_Ljava_lang_String_I;
		}

		// Token: 0x060019F5 RID: 6645 RVA: 0x0004354C File Offset: 0x0004174C
		private static int n_GetInt_Ljava_lang_String_I(IntPtr jnienv, IntPtr native__this, IntPtr native_key, int defValue)
		{
			ISharedPreferences @object = Java.Lang.Object.GetObject<ISharedPreferences>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
			return @object.GetInt(@string, defValue);
		}

		// Token: 0x060019F6 RID: 6646 RVA: 0x00043570 File Offset: 0x00041770
		public unsafe int GetInt(string key, int defValue)
		{
			if (this.id_getInt_Ljava_lang_String_I == IntPtr.Zero)
			{
				this.id_getInt_Ljava_lang_String_I = JNIEnv.GetMethodID(this.class_ref, "getInt", "(Ljava/lang/String;I)I");
			}
			IntPtr intPtr = JNIEnv.NewString(key);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(defValue);
			int result = JNIEnv.CallIntMethod(base.Handle, this.id_getInt_Ljava_lang_String_I, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x060019F7 RID: 6647 RVA: 0x000435F4 File Offset: 0x000417F4
		private static Delegate GetGetLong_Ljava_lang_String_JHandler()
		{
			if (ISharedPreferencesInvoker.cb_getLong_Ljava_lang_String_J == null)
			{
				ISharedPreferencesInvoker.cb_getLong_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLJ_J(ISharedPreferencesInvoker.n_GetLong_Ljava_lang_String_J));
			}
			return ISharedPreferencesInvoker.cb_getLong_Ljava_lang_String_J;
		}

		// Token: 0x060019F8 RID: 6648 RVA: 0x00043618 File Offset: 0x00041818
		private static long n_GetLong_Ljava_lang_String_J(IntPtr jnienv, IntPtr native__this, IntPtr native_key, long defValue)
		{
			ISharedPreferences @object = Java.Lang.Object.GetObject<ISharedPreferences>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
			return @object.GetLong(@string, defValue);
		}

		// Token: 0x060019F9 RID: 6649 RVA: 0x0004363C File Offset: 0x0004183C
		public unsafe long GetLong(string key, long defValue)
		{
			if (this.id_getLong_Ljava_lang_String_J == IntPtr.Zero)
			{
				this.id_getLong_Ljava_lang_String_J = JNIEnv.GetMethodID(this.class_ref, "getLong", "(Ljava/lang/String;J)J");
			}
			IntPtr intPtr = JNIEnv.NewString(key);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(defValue);
			long result = JNIEnv.CallLongMethod(base.Handle, this.id_getLong_Ljava_lang_String_J, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x060019FA RID: 6650 RVA: 0x000436C0 File Offset: 0x000418C0
		private static Delegate GetGetString_Ljava_lang_String_Ljava_lang_String_Handler()
		{
			if (ISharedPreferencesInvoker.cb_getString_Ljava_lang_String_Ljava_lang_String_ == null)
			{
				ISharedPreferencesInvoker.cb_getString_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(ISharedPreferencesInvoker.n_GetString_Ljava_lang_String_Ljava_lang_String_));
			}
			return ISharedPreferencesInvoker.cb_getString_Ljava_lang_String_Ljava_lang_String_;
		}

		// Token: 0x060019FB RID: 6651 RVA: 0x000436E4 File Offset: 0x000418E4
		private static IntPtr n_GetString_Ljava_lang_String_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_defValue)
		{
			ISharedPreferences @object = Java.Lang.Object.GetObject<ISharedPreferences>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_defValue, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString(@object.GetString(@string, string2));
		}

		// Token: 0x060019FC RID: 6652 RVA: 0x00043718 File Offset: 0x00041918
		public unsafe string GetString(string key, string defValue)
		{
			if (this.id_getString_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_getString_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "getString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			}
			IntPtr intPtr = JNIEnv.NewString(key);
			IntPtr intPtr2 = JNIEnv.NewString(defValue);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(intPtr2);
			string @string = JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getString_Ljava_lang_String_Ljava_lang_String_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
			return @string;
		}

		// Token: 0x060019FD RID: 6653 RVA: 0x000437AF File Offset: 0x000419AF
		private static Delegate GetGetStringSet_Ljava_lang_String_Ljava_util_Set_Handler()
		{
			if (ISharedPreferencesInvoker.cb_getStringSet_Ljava_lang_String_Ljava_util_Set_ == null)
			{
				ISharedPreferencesInvoker.cb_getStringSet_Ljava_lang_String_Ljava_util_Set_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(ISharedPreferencesInvoker.n_GetStringSet_Ljava_lang_String_Ljava_util_Set_));
			}
			return ISharedPreferencesInvoker.cb_getStringSet_Ljava_lang_String_Ljava_util_Set_;
		}

		// Token: 0x060019FE RID: 6654 RVA: 0x000437D4 File Offset: 0x000419D4
		private static IntPtr n_GetStringSet_Ljava_lang_String_Ljava_util_Set_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_defValues)
		{
			ISharedPreferences @object = Java.Lang.Object.GetObject<ISharedPreferences>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
			ICollection<string> defValues = JavaSet<string>.FromJniHandle(native_defValues, JniHandleOwnership.DoNotTransfer);
			return JavaSet<string>.ToLocalJniHandle(@object.GetStringSet(@string, defValues));
		}

		// Token: 0x060019FF RID: 6655 RVA: 0x00043808 File Offset: 0x00041A08
		public unsafe ICollection<string> GetStringSet(string key, ICollection<string> defValues)
		{
			if (this.id_getStringSet_Ljava_lang_String_Ljava_util_Set_ == IntPtr.Zero)
			{
				this.id_getStringSet_Ljava_lang_String_Ljava_util_Set_ = JNIEnv.GetMethodID(this.class_ref, "getStringSet", "(Ljava/lang/String;Ljava/util/Set;)Ljava/util/Set;");
			}
			IntPtr intPtr = JNIEnv.NewString(key);
			IntPtr intPtr2 = JavaSet<string>.ToLocalJniHandle(defValues);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(intPtr2);
			ICollection<string> result = JavaSet<string>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, this.id_getStringSet_Ljava_lang_String_Ljava_util_Set_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
			return result;
		}

		// Token: 0x06001A00 RID: 6656 RVA: 0x0004389F File Offset: 0x00041A9F
		private static Delegate GetRegisterOnSharedPreferenceChangeListener_Landroid_content_SharedPreferences_OnSharedPreferenceChangeListener_Handler()
		{
			if (ISharedPreferencesInvoker.cb_registerOnSharedPreferenceChangeListener_Landroid_content_SharedPreferences_OnSharedPreferenceChangeListener_ == null)
			{
				ISharedPreferencesInvoker.cb_registerOnSharedPreferenceChangeListener_Landroid_content_SharedPreferences_OnSharedPreferenceChangeListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ISharedPreferencesInvoker.n_RegisterOnSharedPreferenceChangeListener_Landroid_content_SharedPreferences_OnSharedPreferenceChangeListener_));
			}
			return ISharedPreferencesInvoker.cb_registerOnSharedPreferenceChangeListener_Landroid_content_SharedPreferences_OnSharedPreferenceChangeListener_;
		}

		// Token: 0x06001A01 RID: 6657 RVA: 0x000438C4 File Offset: 0x00041AC4
		private static void n_RegisterOnSharedPreferenceChangeListener_Landroid_content_SharedPreferences_OnSharedPreferenceChangeListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			ISharedPreferences @object = Java.Lang.Object.GetObject<ISharedPreferences>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ISharedPreferencesOnSharedPreferenceChangeListener object2 = Java.Lang.Object.GetObject<ISharedPreferencesOnSharedPreferenceChangeListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.RegisterOnSharedPreferenceChangeListener(object2);
		}

		// Token: 0x06001A02 RID: 6658 RVA: 0x000438E8 File Offset: 0x00041AE8
		public unsafe void RegisterOnSharedPreferenceChangeListener(ISharedPreferencesOnSharedPreferenceChangeListener listener)
		{
			if (this.id_registerOnSharedPreferenceChangeListener_Landroid_content_SharedPreferences_OnSharedPreferenceChangeListener_ == IntPtr.Zero)
			{
				this.id_registerOnSharedPreferenceChangeListener_Landroid_content_SharedPreferences_OnSharedPreferenceChangeListener_ = JNIEnv.GetMethodID(this.class_ref, "registerOnSharedPreferenceChangeListener", "(Landroid/content/SharedPreferences$OnSharedPreferenceChangeListener;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_registerOnSharedPreferenceChangeListener_Landroid_content_SharedPreferences_OnSharedPreferenceChangeListener_, ptr);
		}

		// Token: 0x06001A03 RID: 6659 RVA: 0x00043960 File Offset: 0x00041B60
		private static Delegate GetUnregisterOnSharedPreferenceChangeListener_Landroid_content_SharedPreferences_OnSharedPreferenceChangeListener_Handler()
		{
			if (ISharedPreferencesInvoker.cb_unregisterOnSharedPreferenceChangeListener_Landroid_content_SharedPreferences_OnSharedPreferenceChangeListener_ == null)
			{
				ISharedPreferencesInvoker.cb_unregisterOnSharedPreferenceChangeListener_Landroid_content_SharedPreferences_OnSharedPreferenceChangeListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ISharedPreferencesInvoker.n_UnregisterOnSharedPreferenceChangeListener_Landroid_content_SharedPreferences_OnSharedPreferenceChangeListener_));
			}
			return ISharedPreferencesInvoker.cb_unregisterOnSharedPreferenceChangeListener_Landroid_content_SharedPreferences_OnSharedPreferenceChangeListener_;
		}

		// Token: 0x06001A04 RID: 6660 RVA: 0x00043984 File Offset: 0x00041B84
		private static void n_UnregisterOnSharedPreferenceChangeListener_Landroid_content_SharedPreferences_OnSharedPreferenceChangeListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			ISharedPreferences @object = Java.Lang.Object.GetObject<ISharedPreferences>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ISharedPreferencesOnSharedPreferenceChangeListener object2 = Java.Lang.Object.GetObject<ISharedPreferencesOnSharedPreferenceChangeListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.UnregisterOnSharedPreferenceChangeListener(object2);
		}

		// Token: 0x06001A05 RID: 6661 RVA: 0x000439A8 File Offset: 0x00041BA8
		public unsafe void UnregisterOnSharedPreferenceChangeListener(ISharedPreferencesOnSharedPreferenceChangeListener listener)
		{
			if (this.id_unregisterOnSharedPreferenceChangeListener_Landroid_content_SharedPreferences_OnSharedPreferenceChangeListener_ == IntPtr.Zero)
			{
				this.id_unregisterOnSharedPreferenceChangeListener_Landroid_content_SharedPreferences_OnSharedPreferenceChangeListener_ = JNIEnv.GetMethodID(this.class_ref, "unregisterOnSharedPreferenceChangeListener", "(Landroid/content/SharedPreferences$OnSharedPreferenceChangeListener;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_unregisterOnSharedPreferenceChangeListener_Landroid_content_SharedPreferences_OnSharedPreferenceChangeListener_, ptr);
		}

		// Token: 0x04000ACD RID: 2765
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/content/SharedPreferences", typeof(ISharedPreferencesInvoker));

		// Token: 0x04000ACE RID: 2766
		private IntPtr class_ref;

		// Token: 0x04000ACF RID: 2767
		private static Delegate cb_getAll;

		// Token: 0x04000AD0 RID: 2768
		private IntPtr id_getAll;

		// Token: 0x04000AD1 RID: 2769
		private static Delegate cb_contains_Ljava_lang_String_;

		// Token: 0x04000AD2 RID: 2770
		private IntPtr id_contains_Ljava_lang_String_;

		// Token: 0x04000AD3 RID: 2771
		private static Delegate cb_edit;

		// Token: 0x04000AD4 RID: 2772
		private IntPtr id_edit;

		// Token: 0x04000AD5 RID: 2773
		private static Delegate cb_getBoolean_Ljava_lang_String_Z;

		// Token: 0x04000AD6 RID: 2774
		private IntPtr id_getBoolean_Ljava_lang_String_Z;

		// Token: 0x04000AD7 RID: 2775
		private static Delegate cb_getFloat_Ljava_lang_String_F;

		// Token: 0x04000AD8 RID: 2776
		private IntPtr id_getFloat_Ljava_lang_String_F;

		// Token: 0x04000AD9 RID: 2777
		private static Delegate cb_getInt_Ljava_lang_String_I;

		// Token: 0x04000ADA RID: 2778
		private IntPtr id_getInt_Ljava_lang_String_I;

		// Token: 0x04000ADB RID: 2779
		private static Delegate cb_getLong_Ljava_lang_String_J;

		// Token: 0x04000ADC RID: 2780
		private IntPtr id_getLong_Ljava_lang_String_J;

		// Token: 0x04000ADD RID: 2781
		private static Delegate cb_getString_Ljava_lang_String_Ljava_lang_String_;

		// Token: 0x04000ADE RID: 2782
		private IntPtr id_getString_Ljava_lang_String_Ljava_lang_String_;

		// Token: 0x04000ADF RID: 2783
		private static Delegate cb_getStringSet_Ljava_lang_String_Ljava_util_Set_;

		// Token: 0x04000AE0 RID: 2784
		private IntPtr id_getStringSet_Ljava_lang_String_Ljava_util_Set_;

		// Token: 0x04000AE1 RID: 2785
		private static Delegate cb_registerOnSharedPreferenceChangeListener_Landroid_content_SharedPreferences_OnSharedPreferenceChangeListener_;

		// Token: 0x04000AE2 RID: 2786
		private IntPtr id_registerOnSharedPreferenceChangeListener_Landroid_content_SharedPreferences_OnSharedPreferenceChangeListener_;

		// Token: 0x04000AE3 RID: 2787
		private static Delegate cb_unregisterOnSharedPreferenceChangeListener_Landroid_content_SharedPreferences_OnSharedPreferenceChangeListener_;

		// Token: 0x04000AE4 RID: 2788
		private IntPtr id_unregisterOnSharedPreferenceChangeListener_Landroid_content_SharedPreferences_OnSharedPreferenceChangeListener_;
	}
}
