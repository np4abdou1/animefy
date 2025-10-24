using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.OS
{
	// Token: 0x020001DC RID: 476
	[Register("android/os/BaseBundle", DoNotGenerateAcw = true)]
	public class BaseBundle : Java.Lang.Object
	{
		// Token: 0x1700036F RID: 879
		// (get) Token: 0x0600114C RID: 4428 RVA: 0x0002D9C7 File Offset: 0x0002BBC7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BaseBundle._members;
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x0600114D RID: 4429 RVA: 0x0002D9D0 File Offset: 0x0002BBD0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BaseBundle._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x0600114E RID: 4430 RVA: 0x0002D9F4 File Offset: 0x0002BBF4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BaseBundle._members.ManagedPeerType;
			}
		}

		// Token: 0x0600114F RID: 4431 RVA: 0x000021E0 File Offset: 0x000003E0
		protected BaseBundle(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001150 RID: 4432 RVA: 0x0002DA00 File Offset: 0x0002BC00
		private static Delegate GetGetBoolean_Ljava_lang_String_ZHandler()
		{
			if (BaseBundle.cb_getBoolean_Ljava_lang_String_Z == null)
			{
				BaseBundle.cb_getBoolean_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZ_Z(BaseBundle.n_GetBoolean_Ljava_lang_String_Z));
			}
			return BaseBundle.cb_getBoolean_Ljava_lang_String_Z;
		}

		// Token: 0x06001151 RID: 4433 RVA: 0x0002DA24 File Offset: 0x0002BC24
		private static bool n_GetBoolean_Ljava_lang_String_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_key, bool defaultValue)
		{
			BaseBundle @object = Java.Lang.Object.GetObject<BaseBundle>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
			return @object.GetBoolean(@string, defaultValue);
		}

		// Token: 0x06001152 RID: 4434 RVA: 0x0002DA48 File Offset: 0x0002BC48
		public unsafe virtual bool GetBoolean(string key, bool defaultValue)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(defaultValue);
				result = BaseBundle._members.InstanceMethods.InvokeVirtualBooleanMethod("getBoolean.(Ljava/lang/String;Z)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06001153 RID: 4435 RVA: 0x0002DAB8 File Offset: 0x0002BCB8
		private static Delegate GetGetInt_Ljava_lang_String_Handler()
		{
			if (BaseBundle.cb_getInt_Ljava_lang_String_ == null)
			{
				BaseBundle.cb_getInt_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(BaseBundle.n_GetInt_Ljava_lang_String_));
			}
			return BaseBundle.cb_getInt_Ljava_lang_String_;
		}

		// Token: 0x06001154 RID: 4436 RVA: 0x0002DADC File Offset: 0x0002BCDC
		private static int n_GetInt_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			BaseBundle @object = Java.Lang.Object.GetObject<BaseBundle>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
			return @object.GetInt(@string);
		}

		// Token: 0x06001155 RID: 4437 RVA: 0x0002DB00 File Offset: 0x0002BD00
		public unsafe virtual int GetInt(string key)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = BaseBundle._members.InstanceMethods.InvokeVirtualInt32Method("getInt.(Ljava/lang/String;)I", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06001156 RID: 4438 RVA: 0x0002DB60 File Offset: 0x0002BD60
		private static Delegate GetGetInt_Ljava_lang_String_IHandler()
		{
			if (BaseBundle.cb_getInt_Ljava_lang_String_I == null)
			{
				BaseBundle.cb_getInt_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_I(BaseBundle.n_GetInt_Ljava_lang_String_I));
			}
			return BaseBundle.cb_getInt_Ljava_lang_String_I;
		}

		// Token: 0x06001157 RID: 4439 RVA: 0x0002DB84 File Offset: 0x0002BD84
		private static int n_GetInt_Ljava_lang_String_I(IntPtr jnienv, IntPtr native__this, IntPtr native_key, int defaultValue)
		{
			BaseBundle @object = Java.Lang.Object.GetObject<BaseBundle>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
			return @object.GetInt(@string, defaultValue);
		}

		// Token: 0x06001158 RID: 4440 RVA: 0x0002DBA8 File Offset: 0x0002BDA8
		public unsafe virtual int GetInt(string key, int defaultValue)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(defaultValue);
				result = BaseBundle._members.InstanceMethods.InvokeVirtualInt32Method("getInt.(Ljava/lang/String;I)I", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06001159 RID: 4441 RVA: 0x0002DC18 File Offset: 0x0002BE18
		private static Delegate GetGetString_Ljava_lang_String_Handler()
		{
			if (BaseBundle.cb_getString_Ljava_lang_String_ == null)
			{
				BaseBundle.cb_getString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(BaseBundle.n_GetString_Ljava_lang_String_));
			}
			return BaseBundle.cb_getString_Ljava_lang_String_;
		}

		// Token: 0x0600115A RID: 4442 RVA: 0x0002DC3C File Offset: 0x0002BE3C
		private static IntPtr n_GetString_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			BaseBundle @object = Java.Lang.Object.GetObject<BaseBundle>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString(@object.GetString(@string));
		}

		// Token: 0x0600115B RID: 4443 RVA: 0x0002DC64 File Offset: 0x0002BE64
		public unsafe virtual string GetString(string key)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@string = JNIEnv.GetString(BaseBundle._members.InstanceMethods.InvokeVirtualObjectMethod("getString.(Ljava/lang/String;)Ljava/lang/String;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @string;
		}

		// Token: 0x0600115C RID: 4444 RVA: 0x0002DCD0 File Offset: 0x0002BED0
		private static Delegate GetGetString_Ljava_lang_String_Ljava_lang_String_Handler()
		{
			if (BaseBundle.cb_getString_Ljava_lang_String_Ljava_lang_String_ == null)
			{
				BaseBundle.cb_getString_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(BaseBundle.n_GetString_Ljava_lang_String_Ljava_lang_String_));
			}
			return BaseBundle.cb_getString_Ljava_lang_String_Ljava_lang_String_;
		}

		// Token: 0x0600115D RID: 4445 RVA: 0x0002DCF4 File Offset: 0x0002BEF4
		private static IntPtr n_GetString_Ljava_lang_String_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_defaultValue)
		{
			BaseBundle @object = Java.Lang.Object.GetObject<BaseBundle>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_defaultValue, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString(@object.GetString(@string, string2));
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x0002DD28 File Offset: 0x0002BF28
		public unsafe virtual string GetString(string key, string defaultValue)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			IntPtr intPtr2 = JNIEnv.NewString(defaultValue);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@string = JNIEnv.GetString(BaseBundle._members.InstanceMethods.InvokeVirtualObjectMethod("getString.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
			return @string;
		}

		// Token: 0x0600115F RID: 4447 RVA: 0x0002DDB8 File Offset: 0x0002BFB8
		private static Delegate GetPutBoolean_Ljava_lang_String_ZHandler()
		{
			if (BaseBundle.cb_putBoolean_Ljava_lang_String_Z == null)
			{
				BaseBundle.cb_putBoolean_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZ_V(BaseBundle.n_PutBoolean_Ljava_lang_String_Z));
			}
			return BaseBundle.cb_putBoolean_Ljava_lang_String_Z;
		}

		// Token: 0x06001160 RID: 4448 RVA: 0x0002DDDC File Offset: 0x0002BFDC
		private static void n_PutBoolean_Ljava_lang_String_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_key, bool value)
		{
			BaseBundle @object = Java.Lang.Object.GetObject<BaseBundle>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
			@object.PutBoolean(@string, value);
		}

		// Token: 0x06001161 RID: 4449 RVA: 0x0002DE00 File Offset: 0x0002C000
		public unsafe virtual void PutBoolean(string key, bool value)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(value);
				BaseBundle._members.InstanceMethods.InvokeVirtualVoidMethod("putBoolean.(Ljava/lang/String;Z)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06001162 RID: 4450 RVA: 0x0002DE70 File Offset: 0x0002C070
		private static Delegate GetPutInt_Ljava_lang_String_IHandler()
		{
			if (BaseBundle.cb_putInt_Ljava_lang_String_I == null)
			{
				BaseBundle.cb_putInt_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(BaseBundle.n_PutInt_Ljava_lang_String_I));
			}
			return BaseBundle.cb_putInt_Ljava_lang_String_I;
		}

		// Token: 0x06001163 RID: 4451 RVA: 0x0002DE94 File Offset: 0x0002C094
		private static void n_PutInt_Ljava_lang_String_I(IntPtr jnienv, IntPtr native__this, IntPtr native_key, int value)
		{
			BaseBundle @object = Java.Lang.Object.GetObject<BaseBundle>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
			@object.PutInt(@string, value);
		}

		// Token: 0x06001164 RID: 4452 RVA: 0x0002DEB8 File Offset: 0x0002C0B8
		public unsafe virtual void PutInt(string key, int value)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(value);
				BaseBundle._members.InstanceMethods.InvokeVirtualVoidMethod("putInt.(Ljava/lang/String;I)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06001165 RID: 4453 RVA: 0x0002DF28 File Offset: 0x0002C128
		private static Delegate GetPutString_Ljava_lang_String_Ljava_lang_String_Handler()
		{
			if (BaseBundle.cb_putString_Ljava_lang_String_Ljava_lang_String_ == null)
			{
				BaseBundle.cb_putString_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(BaseBundle.n_PutString_Ljava_lang_String_Ljava_lang_String_));
			}
			return BaseBundle.cb_putString_Ljava_lang_String_Ljava_lang_String_;
		}

		// Token: 0x06001166 RID: 4454 RVA: 0x0002DF4C File Offset: 0x0002C14C
		private static void n_PutString_Ljava_lang_String_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			BaseBundle @object = Java.Lang.Object.GetObject<BaseBundle>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_value, JniHandleOwnership.DoNotTransfer);
			@object.PutString(@string, string2);
		}

		// Token: 0x06001167 RID: 4455 RVA: 0x0002DF78 File Offset: 0x0002C178
		public unsafe virtual void PutString(string key, string value)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			IntPtr intPtr2 = JNIEnv.NewString(value);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				BaseBundle._members.InstanceMethods.InvokeVirtualVoidMethod("putString.(Ljava/lang/String;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
		}

		// Token: 0x040007CC RID: 1996
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/os/BaseBundle", typeof(BaseBundle));

		// Token: 0x040007CD RID: 1997
		private static Delegate cb_getBoolean_Ljava_lang_String_Z;

		// Token: 0x040007CE RID: 1998
		private static Delegate cb_getInt_Ljava_lang_String_;

		// Token: 0x040007CF RID: 1999
		private static Delegate cb_getInt_Ljava_lang_String_I;

		// Token: 0x040007D0 RID: 2000
		private static Delegate cb_getString_Ljava_lang_String_;

		// Token: 0x040007D1 RID: 2001
		private static Delegate cb_getString_Ljava_lang_String_Ljava_lang_String_;

		// Token: 0x040007D2 RID: 2002
		private static Delegate cb_putBoolean_Ljava_lang_String_Z;

		// Token: 0x040007D3 RID: 2003
		private static Delegate cb_putInt_Ljava_lang_String_I;

		// Token: 0x040007D4 RID: 2004
		private static Delegate cb_putString_Ljava_lang_String_Ljava_lang_String_;
	}
}
