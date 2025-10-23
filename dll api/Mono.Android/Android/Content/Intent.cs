using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Net;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Content
{
	// Token: 0x02000299 RID: 665
	[Register("android/content/Intent", DoNotGenerateAcw = true)]
	public class Intent : Java.Lang.Object, IParcelable, IJavaObject, IDisposable, IJavaPeerable, Java.Lang.ICloneable
	{
		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06001943 RID: 6467 RVA: 0x00041395 File Offset: 0x0003F595
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Intent._members;
			}
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06001944 RID: 6468 RVA: 0x0004139C File Offset: 0x0003F59C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Intent._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06001945 RID: 6469 RVA: 0x000413C0 File Offset: 0x0003F5C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Intent._members.ManagedPeerType;
			}
		}

		// Token: 0x06001946 RID: 6470 RVA: 0x000021E0 File Offset: 0x000003E0
		protected Intent(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x000413CC File Offset: 0x0003F5CC
		public Intent() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(Intent._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			Intent._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x0004143C File Offset: 0x0003F63C
		public unsafe Intent(Context packageContext, Class cls) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((packageContext == null) ? IntPtr.Zero : packageContext.Handle);
				ptr[1] = new JniArgumentValue((cls == null) ? IntPtr.Zero : cls.Handle);
				base.SetHandle(Intent._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Ljava/lang/Class;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				Intent._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Ljava/lang/Class;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(packageContext);
				GC.KeepAlive(cls);
			}
		}

		// Token: 0x06001949 RID: 6473 RVA: 0x00041514 File Offset: 0x0003F714
		public unsafe Intent(string action) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(action);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				base.SetHandle(Intent._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				Intent._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x000415B8 File Offset: 0x0003F7B8
		public unsafe Intent(string action, Android.Net.Uri uri) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(action);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((uri == null) ? IntPtr.Zero : uri.Handle);
				base.SetHandle(Intent._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Landroid/net/Uri;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				Intent._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Landroid/net/Uri;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(uri);
			}
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x00041684 File Offset: 0x0003F884
		private static Delegate GetGetDataHandler()
		{
			if (Intent.cb_getData == null)
			{
				Intent.cb_getData = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Intent.n_GetData));
			}
			return Intent.cb_getData;
		}

		// Token: 0x0600194C RID: 6476 RVA: 0x000416A8 File Offset: 0x0003F8A8
		private static IntPtr n_GetData(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Intent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Data);
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x0600194D RID: 6477 RVA: 0x000416BC File Offset: 0x0003F8BC
		public virtual Android.Net.Uri Data
		{
			get
			{
				return Java.Lang.Object.GetObject<Android.Net.Uri>(Intent._members.InstanceMethods.InvokeVirtualObjectMethod("getData.()Landroid/net/Uri;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600194E RID: 6478 RVA: 0x000416EE File Offset: 0x0003F8EE
		private static Delegate GetAddCategory_Ljava_lang_String_Handler()
		{
			if (Intent.cb_addCategory_Ljava_lang_String_ == null)
			{
				Intent.cb_addCategory_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(Intent.n_AddCategory_Ljava_lang_String_));
			}
			return Intent.cb_addCategory_Ljava_lang_String_;
		}

		// Token: 0x0600194F RID: 6479 RVA: 0x00041714 File Offset: 0x0003F914
		private static IntPtr n_AddCategory_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_category)
		{
			Intent @object = Java.Lang.Object.GetObject<Intent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_category, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.AddCategory(@string));
		}

		// Token: 0x06001950 RID: 6480 RVA: 0x0004173C File Offset: 0x0003F93C
		public unsafe virtual Intent AddCategory(string category)
		{
			IntPtr intPtr = JNIEnv.NewString(category);
			Intent @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Intent>(Intent._members.InstanceMethods.InvokeVirtualObjectMethod("addCategory.(Ljava/lang/String;)Landroid/content/Intent;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06001951 RID: 6481 RVA: 0x000417A8 File Offset: 0x0003F9A8
		public unsafe static Intent CreateChooser(Intent target, ICharSequence title)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(title);
			Intent @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((target == null) ? IntPtr.Zero : target.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Intent>(Intent._members.StaticMethods.InvokeObjectMethod("createChooser.(Landroid/content/Intent;Ljava/lang/CharSequence;)Landroid/content/Intent;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(target);
				GC.KeepAlive(title);
			}
			return @object;
		}

		// Token: 0x06001952 RID: 6482 RVA: 0x00041840 File Offset: 0x0003FA40
		public static Intent CreateChooser(Intent target, string title)
		{
			Java.Lang.String @string = (title == null) ? null : new Java.Lang.String(title);
			Intent result = Intent.CreateChooser(target, @string);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06001953 RID: 6483 RVA: 0x0004186A File Offset: 0x0003FA6A
		private static Delegate GetDescribeContentsHandler()
		{
			if (Intent.cb_describeContents == null)
			{
				Intent.cb_describeContents = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(Intent.n_DescribeContents));
			}
			return Intent.cb_describeContents;
		}

		// Token: 0x06001954 RID: 6484 RVA: 0x0004188E File Offset: 0x0003FA8E
		private static int n_DescribeContents(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Intent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DescribeContents();
		}

		// Token: 0x06001955 RID: 6485 RVA: 0x0004189D File Offset: 0x0003FA9D
		public virtual int DescribeContents()
		{
			return Intent._members.InstanceMethods.InvokeVirtualInt32Method("describeContents.()I", this, null);
		}

		// Token: 0x06001956 RID: 6486 RVA: 0x000418B6 File Offset: 0x0003FAB6
		private static Delegate GetGetBooleanExtra_Ljava_lang_String_ZHandler()
		{
			if (Intent.cb_getBooleanExtra_Ljava_lang_String_Z == null)
			{
				Intent.cb_getBooleanExtra_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZ_Z(Intent.n_GetBooleanExtra_Ljava_lang_String_Z));
			}
			return Intent.cb_getBooleanExtra_Ljava_lang_String_Z;
		}

		// Token: 0x06001957 RID: 6487 RVA: 0x000418DC File Offset: 0x0003FADC
		private static bool n_GetBooleanExtra_Ljava_lang_String_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_name, bool defaultValue)
		{
			Intent @object = Java.Lang.Object.GetObject<Intent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_name, JniHandleOwnership.DoNotTransfer);
			return @object.GetBooleanExtra(@string, defaultValue);
		}

		// Token: 0x06001958 RID: 6488 RVA: 0x00041900 File Offset: 0x0003FB00
		public unsafe virtual bool GetBooleanExtra(string name, bool defaultValue)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(defaultValue);
				result = Intent._members.InstanceMethods.InvokeVirtualBooleanMethod("getBooleanExtra.(Ljava/lang/String;Z)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06001959 RID: 6489 RVA: 0x00041970 File Offset: 0x0003FB70
		private static Delegate GetGetFloatExtra_Ljava_lang_String_FHandler()
		{
			if (Intent.cb_getFloatExtra_Ljava_lang_String_F == null)
			{
				Intent.cb_getFloatExtra_Ljava_lang_String_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLF_F(Intent.n_GetFloatExtra_Ljava_lang_String_F));
			}
			return Intent.cb_getFloatExtra_Ljava_lang_String_F;
		}

		// Token: 0x0600195A RID: 6490 RVA: 0x00041994 File Offset: 0x0003FB94
		private static float n_GetFloatExtra_Ljava_lang_String_F(IntPtr jnienv, IntPtr native__this, IntPtr native_name, float defaultValue)
		{
			Intent @object = Java.Lang.Object.GetObject<Intent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_name, JniHandleOwnership.DoNotTransfer);
			return @object.GetFloatExtra(@string, defaultValue);
		}

		// Token: 0x0600195B RID: 6491 RVA: 0x000419B8 File Offset: 0x0003FBB8
		public unsafe virtual float GetFloatExtra(string name, float defaultValue)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			float result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(defaultValue);
				result = Intent._members.InstanceMethods.InvokeVirtualSingleMethod("getFloatExtra.(Ljava/lang/String;F)F", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x0600195C RID: 6492 RVA: 0x00041A28 File Offset: 0x0003FC28
		private static Delegate GetGetIntExtra_Ljava_lang_String_IHandler()
		{
			if (Intent.cb_getIntExtra_Ljava_lang_String_I == null)
			{
				Intent.cb_getIntExtra_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_I(Intent.n_GetIntExtra_Ljava_lang_String_I));
			}
			return Intent.cb_getIntExtra_Ljava_lang_String_I;
		}

		// Token: 0x0600195D RID: 6493 RVA: 0x00041A4C File Offset: 0x0003FC4C
		private static int n_GetIntExtra_Ljava_lang_String_I(IntPtr jnienv, IntPtr native__this, IntPtr native_name, int defaultValue)
		{
			Intent @object = Java.Lang.Object.GetObject<Intent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_name, JniHandleOwnership.DoNotTransfer);
			return @object.GetIntExtra(@string, defaultValue);
		}

		// Token: 0x0600195E RID: 6494 RVA: 0x00041A70 File Offset: 0x0003FC70
		public unsafe virtual int GetIntExtra(string name, int defaultValue)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(defaultValue);
				result = Intent._members.InstanceMethods.InvokeVirtualInt32Method("getIntExtra.(Ljava/lang/String;I)I", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x0600195F RID: 6495 RVA: 0x00041AE0 File Offset: 0x0003FCE0
		private static Delegate GetGetStringExtra_Ljava_lang_String_Handler()
		{
			if (Intent.cb_getStringExtra_Ljava_lang_String_ == null)
			{
				Intent.cb_getStringExtra_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(Intent.n_GetStringExtra_Ljava_lang_String_));
			}
			return Intent.cb_getStringExtra_Ljava_lang_String_;
		}

		// Token: 0x06001960 RID: 6496 RVA: 0x00041B04 File Offset: 0x0003FD04
		private static IntPtr n_GetStringExtra_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			Intent @object = Java.Lang.Object.GetObject<Intent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_name, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString(@object.GetStringExtra(@string));
		}

		// Token: 0x06001961 RID: 6497 RVA: 0x00041B2C File Offset: 0x0003FD2C
		public unsafe virtual string GetStringExtra(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@string = JNIEnv.GetString(Intent._members.InstanceMethods.InvokeVirtualObjectMethod("getStringExtra.(Ljava/lang/String;)Ljava/lang/String;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @string;
		}

		// Token: 0x06001962 RID: 6498 RVA: 0x00041B98 File Offset: 0x0003FD98
		private static Delegate GetPutExtra_Ljava_lang_String_ZHandler()
		{
			if (Intent.cb_putExtra_Ljava_lang_String_Z == null)
			{
				Intent.cb_putExtra_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZ_L(Intent.n_PutExtra_Ljava_lang_String_Z));
			}
			return Intent.cb_putExtra_Ljava_lang_String_Z;
		}

		// Token: 0x06001963 RID: 6499 RVA: 0x00041BBC File Offset: 0x0003FDBC
		private static IntPtr n_PutExtra_Ljava_lang_String_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_name, bool value)
		{
			Intent @object = Java.Lang.Object.GetObject<Intent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_name, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.PutExtra(@string, value));
		}

		// Token: 0x06001964 RID: 6500 RVA: 0x00041BE8 File Offset: 0x0003FDE8
		public unsafe virtual Intent PutExtra(string name, bool value)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			Intent @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(value);
				@object = Java.Lang.Object.GetObject<Intent>(Intent._members.InstanceMethods.InvokeVirtualObjectMethod("putExtra.(Ljava/lang/String;Z)Landroid/content/Intent;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06001965 RID: 6501 RVA: 0x00041C68 File Offset: 0x0003FE68
		private static Delegate GetPutExtra_Ljava_lang_String_FHandler()
		{
			if (Intent.cb_putExtra_Ljava_lang_String_F == null)
			{
				Intent.cb_putExtra_Ljava_lang_String_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLF_L(Intent.n_PutExtra_Ljava_lang_String_F));
			}
			return Intent.cb_putExtra_Ljava_lang_String_F;
		}

		// Token: 0x06001966 RID: 6502 RVA: 0x00041C8C File Offset: 0x0003FE8C
		private static IntPtr n_PutExtra_Ljava_lang_String_F(IntPtr jnienv, IntPtr native__this, IntPtr native_name, float value)
		{
			Intent @object = Java.Lang.Object.GetObject<Intent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_name, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.PutExtra(@string, value));
		}

		// Token: 0x06001967 RID: 6503 RVA: 0x00041CB8 File Offset: 0x0003FEB8
		public unsafe virtual Intent PutExtra(string name, float value)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			Intent @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(value);
				@object = Java.Lang.Object.GetObject<Intent>(Intent._members.InstanceMethods.InvokeVirtualObjectMethod("putExtra.(Ljava/lang/String;F)Landroid/content/Intent;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06001968 RID: 6504 RVA: 0x00041D38 File Offset: 0x0003FF38
		private static Delegate GetPutExtra_Ljava_lang_String_IHandler()
		{
			if (Intent.cb_putExtra_Ljava_lang_String_I == null)
			{
				Intent.cb_putExtra_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_L(Intent.n_PutExtra_Ljava_lang_String_I));
			}
			return Intent.cb_putExtra_Ljava_lang_String_I;
		}

		// Token: 0x06001969 RID: 6505 RVA: 0x00041D5C File Offset: 0x0003FF5C
		private static IntPtr n_PutExtra_Ljava_lang_String_I(IntPtr jnienv, IntPtr native__this, IntPtr native_name, int value)
		{
			Intent @object = Java.Lang.Object.GetObject<Intent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_name, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.PutExtra(@string, value));
		}

		// Token: 0x0600196A RID: 6506 RVA: 0x00041D88 File Offset: 0x0003FF88
		public unsafe virtual Intent PutExtra(string name, int value)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			Intent @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(value);
				@object = Java.Lang.Object.GetObject<Intent>(Intent._members.InstanceMethods.InvokeVirtualObjectMethod("putExtra.(Ljava/lang/String;I)Landroid/content/Intent;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x0600196B RID: 6507 RVA: 0x00041E08 File Offset: 0x00040008
		private static Delegate GetPutExtra_Ljava_lang_String_Ljava_lang_String_Handler()
		{
			if (Intent.cb_putExtra_Ljava_lang_String_Ljava_lang_String_ == null)
			{
				Intent.cb_putExtra_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(Intent.n_PutExtra_Ljava_lang_String_Ljava_lang_String_));
			}
			return Intent.cb_putExtra_Ljava_lang_String_Ljava_lang_String_;
		}

		// Token: 0x0600196C RID: 6508 RVA: 0x00041E2C File Offset: 0x0004002C
		private static IntPtr n_PutExtra_Ljava_lang_String_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_value)
		{
			Intent @object = Java.Lang.Object.GetObject<Intent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_name, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_value, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.PutExtra(@string, string2));
		}

		// Token: 0x0600196D RID: 6509 RVA: 0x00041E60 File Offset: 0x00040060
		public unsafe virtual Intent PutExtra(string name, string value)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			IntPtr intPtr2 = JNIEnv.NewString(value);
			Intent @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<Intent>(Intent._members.InstanceMethods.InvokeVirtualObjectMethod("putExtra.(Ljava/lang/String;Ljava/lang/String;)Landroid/content/Intent;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
			return @object;
		}

		// Token: 0x0600196E RID: 6510 RVA: 0x00041EF0 File Offset: 0x000400F0
		private static Delegate GetPutExtras_Landroid_os_Bundle_Handler()
		{
			if (Intent.cb_putExtras_Landroid_os_Bundle_ == null)
			{
				Intent.cb_putExtras_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(Intent.n_PutExtras_Landroid_os_Bundle_));
			}
			return Intent.cb_putExtras_Landroid_os_Bundle_;
		}

		// Token: 0x0600196F RID: 6511 RVA: 0x00041F14 File Offset: 0x00040114
		private static IntPtr n_PutExtras_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_extras)
		{
			Intent @object = Java.Lang.Object.GetObject<Intent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_extras, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.PutExtras(object2));
		}

		// Token: 0x06001970 RID: 6512 RVA: 0x00041F3C File Offset: 0x0004013C
		public unsafe virtual Intent PutExtras(Bundle extras)
		{
			Intent @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((extras == null) ? IntPtr.Zero : extras.Handle);
				@object = Java.Lang.Object.GetObject<Intent>(Intent._members.InstanceMethods.InvokeVirtualObjectMethod("putExtras.(Landroid/os/Bundle;)Landroid/content/Intent;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(extras);
			}
			return @object;
		}

		// Token: 0x06001971 RID: 6513 RVA: 0x00041FB0 File Offset: 0x000401B0
		private static Delegate GetSetData_Landroid_net_Uri_Handler()
		{
			if (Intent.cb_setData_Landroid_net_Uri_ == null)
			{
				Intent.cb_setData_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(Intent.n_SetData_Landroid_net_Uri_));
			}
			return Intent.cb_setData_Landroid_net_Uri_;
		}

		// Token: 0x06001972 RID: 6514 RVA: 0x00041FD4 File Offset: 0x000401D4
		private static IntPtr n_SetData_Landroid_net_Uri_(IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			Intent @object = Java.Lang.Object.GetObject<Intent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Android.Net.Uri object2 = Java.Lang.Object.GetObject<Android.Net.Uri>(native_data, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetData(object2));
		}

		// Token: 0x06001973 RID: 6515 RVA: 0x00041FFC File Offset: 0x000401FC
		public unsafe virtual Intent SetData(Android.Net.Uri data)
		{
			Intent @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((data == null) ? IntPtr.Zero : data.Handle);
				@object = Java.Lang.Object.GetObject<Intent>(Intent._members.InstanceMethods.InvokeVirtualObjectMethod("setData.(Landroid/net/Uri;)Landroid/content/Intent;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(data);
			}
			return @object;
		}

		// Token: 0x06001974 RID: 6516 RVA: 0x00042070 File Offset: 0x00040270
		private static Delegate GetSetDataAndType_Landroid_net_Uri_Ljava_lang_String_Handler()
		{
			if (Intent.cb_setDataAndType_Landroid_net_Uri_Ljava_lang_String_ == null)
			{
				Intent.cb_setDataAndType_Landroid_net_Uri_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(Intent.n_SetDataAndType_Landroid_net_Uri_Ljava_lang_String_));
			}
			return Intent.cb_setDataAndType_Landroid_net_Uri_Ljava_lang_String_;
		}

		// Token: 0x06001975 RID: 6517 RVA: 0x00042094 File Offset: 0x00040294
		private static IntPtr n_SetDataAndType_Landroid_net_Uri_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_data, IntPtr native_type)
		{
			Intent @object = Java.Lang.Object.GetObject<Intent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Android.Net.Uri object2 = Java.Lang.Object.GetObject<Android.Net.Uri>(native_data, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_type, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetDataAndType(object2, @string));
		}

		// Token: 0x06001976 RID: 6518 RVA: 0x000420C8 File Offset: 0x000402C8
		public unsafe virtual Intent SetDataAndType(Android.Net.Uri data, string type)
		{
			IntPtr intPtr = JNIEnv.NewString(type);
			Intent @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((data == null) ? IntPtr.Zero : data.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Intent>(Intent._members.InstanceMethods.InvokeVirtualObjectMethod("setDataAndType.(Landroid/net/Uri;Ljava/lang/String;)Landroid/content/Intent;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(data);
			}
			return @object;
		}

		// Token: 0x06001977 RID: 6519 RVA: 0x0004215C File Offset: 0x0004035C
		private static Delegate GetSetFlags_IHandler()
		{
			if (Intent.cb_setFlags_I == null)
			{
				Intent.cb_setFlags_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(Intent.n_SetFlags_I));
			}
			return Intent.cb_setFlags_I;
		}

		// Token: 0x06001978 RID: 6520 RVA: 0x00042180 File Offset: 0x00040380
		private static IntPtr n_SetFlags_I(IntPtr jnienv, IntPtr native__this, int native_flags)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Intent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetFlags((ActivityFlags)native_flags));
		}

		// Token: 0x06001979 RID: 6521 RVA: 0x000421A4 File Offset: 0x000403A4
		public unsafe virtual Intent SetFlags([GeneratedEnum] ActivityFlags flags)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((int)flags);
			return Java.Lang.Object.GetObject<Intent>(Intent._members.InstanceMethods.InvokeVirtualObjectMethod("setFlags.(I)Landroid/content/Intent;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600197A RID: 6522 RVA: 0x000421ED File Offset: 0x000403ED
		private static Delegate GetSetPackage_Ljava_lang_String_Handler()
		{
			if (Intent.cb_setPackage_Ljava_lang_String_ == null)
			{
				Intent.cb_setPackage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(Intent.n_SetPackage_Ljava_lang_String_));
			}
			return Intent.cb_setPackage_Ljava_lang_String_;
		}

		// Token: 0x0600197B RID: 6523 RVA: 0x00042214 File Offset: 0x00040414
		private static IntPtr n_SetPackage_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_packageName)
		{
			Intent @object = Java.Lang.Object.GetObject<Intent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_packageName, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetPackage(@string));
		}

		// Token: 0x0600197C RID: 6524 RVA: 0x0004223C File Offset: 0x0004043C
		public unsafe virtual Intent SetPackage(string packageName)
		{
			IntPtr intPtr = JNIEnv.NewString(packageName);
			Intent @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Intent>(Intent._members.InstanceMethods.InvokeVirtualObjectMethod("setPackage.(Ljava/lang/String;)Landroid/content/Intent;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x0600197D RID: 6525 RVA: 0x000422A8 File Offset: 0x000404A8
		private static Delegate GetSetType_Ljava_lang_String_Handler()
		{
			if (Intent.cb_setType_Ljava_lang_String_ == null)
			{
				Intent.cb_setType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(Intent.n_SetType_Ljava_lang_String_));
			}
			return Intent.cb_setType_Ljava_lang_String_;
		}

		// Token: 0x0600197E RID: 6526 RVA: 0x000422CC File Offset: 0x000404CC
		private static IntPtr n_SetType_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_type)
		{
			Intent @object = Java.Lang.Object.GetObject<Intent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_type, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetType(@string));
		}

		// Token: 0x0600197F RID: 6527 RVA: 0x000422F4 File Offset: 0x000404F4
		public unsafe virtual Intent SetType(string type)
		{
			IntPtr intPtr = JNIEnv.NewString(type);
			Intent @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Intent>(Intent._members.InstanceMethods.InvokeVirtualObjectMethod("setType.(Ljava/lang/String;)Landroid/content/Intent;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06001980 RID: 6528 RVA: 0x00042360 File Offset: 0x00040560
		private static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler()
		{
			if (Intent.cb_writeToParcel_Landroid_os_Parcel_I == null)
			{
				Intent.cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(Intent.n_WriteToParcel_Landroid_os_Parcel_I));
			}
			return Intent.cb_writeToParcel_Landroid_os_Parcel_I;
		}

		// Token: 0x06001981 RID: 6529 RVA: 0x00042384 File Offset: 0x00040584
		private static void n_WriteToParcel_Landroid_os_Parcel_I(IntPtr jnienv, IntPtr native__this, IntPtr native__out, int native_flags)
		{
			Intent @object = Java.Lang.Object.GetObject<Intent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Parcel object2 = Java.Lang.Object.GetObject<Parcel>(native__out, JniHandleOwnership.DoNotTransfer);
			@object.WriteToParcel(object2, (ParcelableWriteFlags)native_flags);
		}

		// Token: 0x06001982 RID: 6530 RVA: 0x000423AC File Offset: 0x000405AC
		public unsafe virtual void WriteToParcel(Parcel @out, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((@out == null) ? IntPtr.Zero : @out.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				Intent._members.InstanceMethods.InvokeVirtualVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(@out);
			}
		}

		// Token: 0x06001983 RID: 6531 RVA: 0x00042424 File Offset: 0x00040624
		public Intent(Context packageContext, Type type) : this(packageContext, Class.FromType(type))
		{
		}

		// Token: 0x04000A9C RID: 2716
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/content/Intent", typeof(Intent));

		// Token: 0x04000A9D RID: 2717
		private static Delegate cb_getData;

		// Token: 0x04000A9E RID: 2718
		private static Delegate cb_addCategory_Ljava_lang_String_;

		// Token: 0x04000A9F RID: 2719
		private static Delegate cb_describeContents;

		// Token: 0x04000AA0 RID: 2720
		private static Delegate cb_getBooleanExtra_Ljava_lang_String_Z;

		// Token: 0x04000AA1 RID: 2721
		private static Delegate cb_getFloatExtra_Ljava_lang_String_F;

		// Token: 0x04000AA2 RID: 2722
		private static Delegate cb_getIntExtra_Ljava_lang_String_I;

		// Token: 0x04000AA3 RID: 2723
		private static Delegate cb_getStringExtra_Ljava_lang_String_;

		// Token: 0x04000AA4 RID: 2724
		private static Delegate cb_putExtra_Ljava_lang_String_Z;

		// Token: 0x04000AA5 RID: 2725
		private static Delegate cb_putExtra_Ljava_lang_String_F;

		// Token: 0x04000AA6 RID: 2726
		private static Delegate cb_putExtra_Ljava_lang_String_I;

		// Token: 0x04000AA7 RID: 2727
		private static Delegate cb_putExtra_Ljava_lang_String_Ljava_lang_String_;

		// Token: 0x04000AA8 RID: 2728
		private static Delegate cb_putExtras_Landroid_os_Bundle_;

		// Token: 0x04000AA9 RID: 2729
		private static Delegate cb_setData_Landroid_net_Uri_;

		// Token: 0x04000AAA RID: 2730
		private static Delegate cb_setDataAndType_Landroid_net_Uri_Ljava_lang_String_;

		// Token: 0x04000AAB RID: 2731
		private static Delegate cb_setFlags_I;

		// Token: 0x04000AAC RID: 2732
		private static Delegate cb_setPackage_Ljava_lang_String_;

		// Token: 0x04000AAD RID: 2733
		private static Delegate cb_setType_Ljava_lang_String_;

		// Token: 0x04000AAE RID: 2734
		private static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
	}
}
