using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using AndroidX.Lifecycle;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Fragment.App
{
	// Token: 0x02000046 RID: 70
	[Register("androidx/fragment/app/FragmentTransaction", DoNotGenerateAcw = true)]
	public abstract class FragmentTransaction : Java.Lang.Object
	{
		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x0000BD68 File Offset: 0x00009F68
		internal static IntPtr class_ref
		{
			get
			{
				return FragmentTransaction._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060003A9 RID: 937 RVA: 0x0000BD8C File Offset: 0x00009F8C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FragmentTransaction._members;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060003AA RID: 938 RVA: 0x0000BD94 File Offset: 0x00009F94
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return FragmentTransaction._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060003AB RID: 939 RVA: 0x0000BDB8 File Offset: 0x00009FB8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FragmentTransaction._members.ManagedPeerType;
			}
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00003624 File Offset: 0x00001824
		protected FragmentTransaction(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0000BDC4 File Offset: 0x00009FC4
		[Register(".ctor", "()V", "")]
		public FragmentTransaction() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(FragmentTransaction._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			FragmentTransaction._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060003AE RID: 942 RVA: 0x0000BE32 File Offset: 0x0000A032
		private static Delegate GetIsAddToBackStackAllowedHandler()
		{
			if (FragmentTransaction.cb_isAddToBackStackAllowed == null)
			{
				FragmentTransaction.cb_isAddToBackStackAllowed = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(FragmentTransaction.n_IsAddToBackStackAllowed));
			}
			return FragmentTransaction.cb_isAddToBackStackAllowed;
		}

		// Token: 0x060003AF RID: 943 RVA: 0x0000BE56 File Offset: 0x0000A056
		private static bool n_IsAddToBackStackAllowed(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<FragmentTransaction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsAddToBackStackAllowed;
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x0000BE65 File Offset: 0x0000A065
		public virtual bool IsAddToBackStackAllowed
		{
			[Register("isAddToBackStackAllowed", "()Z", "GetIsAddToBackStackAllowedHandler")]
			get
			{
				return FragmentTransaction._members.InstanceMethods.InvokeVirtualBooleanMethod("isAddToBackStackAllowed.()Z", this, null);
			}
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x0000BE7E File Offset: 0x0000A07E
		private static Delegate GetIsEmptyHandler()
		{
			if (FragmentTransaction.cb_isEmpty == null)
			{
				FragmentTransaction.cb_isEmpty = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(FragmentTransaction.n_IsEmpty));
			}
			return FragmentTransaction.cb_isEmpty;
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0000BEA2 File Offset: 0x0000A0A2
		private static bool n_IsEmpty(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<FragmentTransaction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsEmpty;
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x0000BEB1 File Offset: 0x0000A0B1
		public virtual bool IsEmpty
		{
			[Register("isEmpty", "()Z", "GetIsEmptyHandler")]
			get
			{
				return FragmentTransaction._members.InstanceMethods.InvokeVirtualBooleanMethod("isEmpty.()Z", this, null);
			}
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0000BECA File Offset: 0x0000A0CA
		private static Delegate GetAdd_Landroidx_fragment_app_Fragment_Ljava_lang_String_Handler()
		{
			if (FragmentTransaction.cb_add_Landroidx_fragment_app_Fragment_Ljava_lang_String_ == null)
			{
				FragmentTransaction.cb_add_Landroidx_fragment_app_Fragment_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(FragmentTransaction.n_Add_Landroidx_fragment_app_Fragment_Ljava_lang_String_));
			}
			return FragmentTransaction.cb_add_Landroidx_fragment_app_Fragment_Ljava_lang_String_;
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0000BEF0 File Offset: 0x0000A0F0
		private static IntPtr n_Add_Landroidx_fragment_app_Fragment_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_fragment, IntPtr native_tag)
		{
			FragmentTransaction @object = Java.Lang.Object.GetObject<FragmentTransaction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Fragment object2 = Java.Lang.Object.GetObject<Fragment>(native_fragment, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_tag, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Add(object2, @string));
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0000BF24 File Offset: 0x0000A124
		[Register("add", "(Landroidx/fragment/app/Fragment;Ljava/lang/String;)Landroidx/fragment/app/FragmentTransaction;", "GetAdd_Landroidx_fragment_app_Fragment_Ljava_lang_String_Handler")]
		public unsafe virtual FragmentTransaction Add(Fragment fragment, string tag)
		{
			IntPtr intPtr = JNIEnv.NewString(tag);
			FragmentTransaction @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((fragment == null) ? IntPtr.Zero : fragment.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<FragmentTransaction>(FragmentTransaction._members.InstanceMethods.InvokeVirtualObjectMethod("add.(Landroidx/fragment/app/Fragment;Ljava/lang/String;)Landroidx/fragment/app/FragmentTransaction;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(fragment);
			}
			return @object;
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0000BFB8 File Offset: 0x0000A1B8
		private static Delegate GetAdd_ILandroidx_fragment_app_Fragment_Handler()
		{
			if (FragmentTransaction.cb_add_ILandroidx_fragment_app_Fragment_ == null)
			{
				FragmentTransaction.cb_add_ILandroidx_fragment_app_Fragment_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_L(FragmentTransaction.n_Add_ILandroidx_fragment_app_Fragment_));
			}
			return FragmentTransaction.cb_add_ILandroidx_fragment_app_Fragment_;
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x0000BFDC File Offset: 0x0000A1DC
		private static IntPtr n_Add_ILandroidx_fragment_app_Fragment_(IntPtr jnienv, IntPtr native__this, int containerViewId, IntPtr native_fragment)
		{
			FragmentTransaction @object = Java.Lang.Object.GetObject<FragmentTransaction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Fragment object2 = Java.Lang.Object.GetObject<Fragment>(native_fragment, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Add(containerViewId, object2));
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0000C008 File Offset: 0x0000A208
		[Register("add", "(ILandroidx/fragment/app/Fragment;)Landroidx/fragment/app/FragmentTransaction;", "GetAdd_ILandroidx_fragment_app_Fragment_Handler")]
		public unsafe virtual FragmentTransaction Add(int containerViewId, Fragment fragment)
		{
			FragmentTransaction @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(containerViewId);
				ptr[1] = new JniArgumentValue((fragment == null) ? IntPtr.Zero : fragment.Handle);
				@object = Java.Lang.Object.GetObject<FragmentTransaction>(FragmentTransaction._members.InstanceMethods.InvokeVirtualObjectMethod("add.(ILandroidx/fragment/app/Fragment;)Landroidx/fragment/app/FragmentTransaction;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(fragment);
			}
			return @object;
		}

		// Token: 0x060003BA RID: 954 RVA: 0x0000C090 File Offset: 0x0000A290
		private static Delegate GetAdd_ILandroidx_fragment_app_Fragment_Ljava_lang_String_Handler()
		{
			if (FragmentTransaction.cb_add_ILandroidx_fragment_app_Fragment_Ljava_lang_String_ == null)
			{
				FragmentTransaction.cb_add_ILandroidx_fragment_app_Fragment_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPILL_L(FragmentTransaction.n_Add_ILandroidx_fragment_app_Fragment_Ljava_lang_String_));
			}
			return FragmentTransaction.cb_add_ILandroidx_fragment_app_Fragment_Ljava_lang_String_;
		}

		// Token: 0x060003BB RID: 955 RVA: 0x0000C0B4 File Offset: 0x0000A2B4
		private static IntPtr n_Add_ILandroidx_fragment_app_Fragment_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, int containerViewId, IntPtr native_fragment, IntPtr native_tag)
		{
			FragmentTransaction @object = Java.Lang.Object.GetObject<FragmentTransaction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Fragment object2 = Java.Lang.Object.GetObject<Fragment>(native_fragment, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_tag, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Add(containerViewId, object2, @string));
		}

		// Token: 0x060003BC RID: 956 RVA: 0x0000C0E8 File Offset: 0x0000A2E8
		[Register("add", "(ILandroidx/fragment/app/Fragment;Ljava/lang/String;)Landroidx/fragment/app/FragmentTransaction;", "GetAdd_ILandroidx_fragment_app_Fragment_Ljava_lang_String_Handler")]
		public unsafe virtual FragmentTransaction Add(int containerViewId, Fragment fragment, string tag)
		{
			IntPtr intPtr = JNIEnv.NewString(tag);
			FragmentTransaction @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(containerViewId);
				ptr[1] = new JniArgumentValue((fragment == null) ? IntPtr.Zero : fragment.Handle);
				ptr[2] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<FragmentTransaction>(FragmentTransaction._members.InstanceMethods.InvokeVirtualObjectMethod("add.(ILandroidx/fragment/app/Fragment;Ljava/lang/String;)Landroidx/fragment/app/FragmentTransaction;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(fragment);
			}
			return @object;
		}

		// Token: 0x060003BD RID: 957 RVA: 0x0000C194 File Offset: 0x0000A394
		[Register("add", "(ILjava/lang/Class;Landroid/os/Bundle;)Landroidx/fragment/app/FragmentTransaction;", "")]
		public unsafe FragmentTransaction Add(int containerViewId, Class fragmentClass, Bundle args)
		{
			FragmentTransaction @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(containerViewId);
				ptr[1] = new JniArgumentValue((fragmentClass == null) ? IntPtr.Zero : fragmentClass.Handle);
				ptr[2] = new JniArgumentValue((args == null) ? IntPtr.Zero : args.Handle);
				@object = Java.Lang.Object.GetObject<FragmentTransaction>(FragmentTransaction._members.InstanceMethods.InvokeNonvirtualObjectMethod("add.(ILjava/lang/Class;Landroid/os/Bundle;)Landroidx/fragment/app/FragmentTransaction;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(fragmentClass);
				GC.KeepAlive(args);
			}
			return @object;
		}

		// Token: 0x060003BE RID: 958 RVA: 0x0000C248 File Offset: 0x0000A448
		[Register("add", "(ILjava/lang/Class;Landroid/os/Bundle;Ljava/lang/String;)Landroidx/fragment/app/FragmentTransaction;", "")]
		public unsafe FragmentTransaction Add(int containerViewId, Class fragmentClass, Bundle args, string tag)
		{
			IntPtr intPtr = JNIEnv.NewString(tag);
			FragmentTransaction @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(containerViewId);
				ptr[1] = new JniArgumentValue((fragmentClass == null) ? IntPtr.Zero : fragmentClass.Handle);
				ptr[2] = new JniArgumentValue((args == null) ? IntPtr.Zero : args.Handle);
				ptr[3] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<FragmentTransaction>(FragmentTransaction._members.InstanceMethods.InvokeNonvirtualObjectMethod("add.(ILjava/lang/Class;Landroid/os/Bundle;Ljava/lang/String;)Landroidx/fragment/app/FragmentTransaction;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(fragmentClass);
				GC.KeepAlive(args);
			}
			return @object;
		}

		// Token: 0x060003BF RID: 959 RVA: 0x0000C320 File Offset: 0x0000A520
		[Register("add", "(Ljava/lang/Class;Landroid/os/Bundle;Ljava/lang/String;)Landroidx/fragment/app/FragmentTransaction;", "")]
		public unsafe FragmentTransaction Add(Class fragmentClass, Bundle args, string tag)
		{
			IntPtr intPtr = JNIEnv.NewString(tag);
			FragmentTransaction @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((fragmentClass == null) ? IntPtr.Zero : fragmentClass.Handle);
				ptr[1] = new JniArgumentValue((args == null) ? IntPtr.Zero : args.Handle);
				ptr[2] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<FragmentTransaction>(FragmentTransaction._members.InstanceMethods.InvokeNonvirtualObjectMethod("add.(Ljava/lang/Class;Landroid/os/Bundle;Ljava/lang/String;)Landroidx/fragment/app/FragmentTransaction;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(fragmentClass);
				GC.KeepAlive(args);
			}
			return @object;
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x0000C3E0 File Offset: 0x0000A5E0
		private static Delegate GetAddSharedElement_Landroid_view_View_Ljava_lang_String_Handler()
		{
			if (FragmentTransaction.cb_addSharedElement_Landroid_view_View_Ljava_lang_String_ == null)
			{
				FragmentTransaction.cb_addSharedElement_Landroid_view_View_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(FragmentTransaction.n_AddSharedElement_Landroid_view_View_Ljava_lang_String_));
			}
			return FragmentTransaction.cb_addSharedElement_Landroid_view_View_Ljava_lang_String_;
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x0000C404 File Offset: 0x0000A604
		private static IntPtr n_AddSharedElement_Landroid_view_View_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_sharedElement, IntPtr native_name)
		{
			FragmentTransaction @object = Java.Lang.Object.GetObject<FragmentTransaction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_sharedElement, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_name, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.AddSharedElement(object2, @string));
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x0000C438 File Offset: 0x0000A638
		[Register("addSharedElement", "(Landroid/view/View;Ljava/lang/String;)Landroidx/fragment/app/FragmentTransaction;", "GetAddSharedElement_Landroid_view_View_Ljava_lang_String_Handler")]
		public unsafe virtual FragmentTransaction AddSharedElement(View sharedElement, string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			FragmentTransaction @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((sharedElement == null) ? IntPtr.Zero : sharedElement.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<FragmentTransaction>(FragmentTransaction._members.InstanceMethods.InvokeVirtualObjectMethod("addSharedElement.(Landroid/view/View;Ljava/lang/String;)Landroidx/fragment/app/FragmentTransaction;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(sharedElement);
			}
			return @object;
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x0000C4CC File Offset: 0x0000A6CC
		private static Delegate GetAddToBackStack_Ljava_lang_String_Handler()
		{
			if (FragmentTransaction.cb_addToBackStack_Ljava_lang_String_ == null)
			{
				FragmentTransaction.cb_addToBackStack_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(FragmentTransaction.n_AddToBackStack_Ljava_lang_String_));
			}
			return FragmentTransaction.cb_addToBackStack_Ljava_lang_String_;
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0000C4F0 File Offset: 0x0000A6F0
		private static IntPtr n_AddToBackStack_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			FragmentTransaction @object = Java.Lang.Object.GetObject<FragmentTransaction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_name, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.AddToBackStack(@string));
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0000C518 File Offset: 0x0000A718
		[Register("addToBackStack", "(Ljava/lang/String;)Landroidx/fragment/app/FragmentTransaction;", "GetAddToBackStack_Ljava_lang_String_Handler")]
		public unsafe virtual FragmentTransaction AddToBackStack(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			FragmentTransaction @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<FragmentTransaction>(FragmentTransaction._members.InstanceMethods.InvokeVirtualObjectMethod("addToBackStack.(Ljava/lang/String;)Landroidx/fragment/app/FragmentTransaction;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x0000C584 File Offset: 0x0000A784
		private static Delegate GetAttach_Landroidx_fragment_app_Fragment_Handler()
		{
			if (FragmentTransaction.cb_attach_Landroidx_fragment_app_Fragment_ == null)
			{
				FragmentTransaction.cb_attach_Landroidx_fragment_app_Fragment_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(FragmentTransaction.n_Attach_Landroidx_fragment_app_Fragment_));
			}
			return FragmentTransaction.cb_attach_Landroidx_fragment_app_Fragment_;
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x0000C5A8 File Offset: 0x0000A7A8
		private static IntPtr n_Attach_Landroidx_fragment_app_Fragment_(IntPtr jnienv, IntPtr native__this, IntPtr native_fragment)
		{
			FragmentTransaction @object = Java.Lang.Object.GetObject<FragmentTransaction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Fragment object2 = Java.Lang.Object.GetObject<Fragment>(native_fragment, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Attach(object2));
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x0000C5D0 File Offset: 0x0000A7D0
		[Register("attach", "(Landroidx/fragment/app/Fragment;)Landroidx/fragment/app/FragmentTransaction;", "GetAttach_Landroidx_fragment_app_Fragment_Handler")]
		public unsafe virtual FragmentTransaction Attach(Fragment fragment)
		{
			FragmentTransaction @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((fragment == null) ? IntPtr.Zero : fragment.Handle);
				@object = Java.Lang.Object.GetObject<FragmentTransaction>(FragmentTransaction._members.InstanceMethods.InvokeVirtualObjectMethod("attach.(Landroidx/fragment/app/Fragment;)Landroidx/fragment/app/FragmentTransaction;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(fragment);
			}
			return @object;
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x0000C644 File Offset: 0x0000A844
		private static Delegate GetCommitHandler()
		{
			if (FragmentTransaction.cb_commit == null)
			{
				FragmentTransaction.cb_commit = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(FragmentTransaction.n_Commit));
			}
			return FragmentTransaction.cb_commit;
		}

		// Token: 0x060003CA RID: 970 RVA: 0x0000C668 File Offset: 0x0000A868
		private static int n_Commit(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<FragmentTransaction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Commit();
		}

		// Token: 0x060003CB RID: 971
		[Register("commit", "()I", "GetCommitHandler")]
		public abstract int Commit();

		// Token: 0x060003CC RID: 972 RVA: 0x0000C677 File Offset: 0x0000A877
		private static Delegate GetCommitAllowingStateLossHandler()
		{
			if (FragmentTransaction.cb_commitAllowingStateLoss == null)
			{
				FragmentTransaction.cb_commitAllowingStateLoss = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(FragmentTransaction.n_CommitAllowingStateLoss));
			}
			return FragmentTransaction.cb_commitAllowingStateLoss;
		}

		// Token: 0x060003CD RID: 973 RVA: 0x0000C69B File Offset: 0x0000A89B
		private static int n_CommitAllowingStateLoss(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<FragmentTransaction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CommitAllowingStateLoss();
		}

		// Token: 0x060003CE RID: 974
		[Register("commitAllowingStateLoss", "()I", "GetCommitAllowingStateLossHandler")]
		public abstract int CommitAllowingStateLoss();

		// Token: 0x060003CF RID: 975 RVA: 0x0000C6AA File Offset: 0x0000A8AA
		private static Delegate GetCommitNowHandler()
		{
			if (FragmentTransaction.cb_commitNow == null)
			{
				FragmentTransaction.cb_commitNow = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(FragmentTransaction.n_CommitNow));
			}
			return FragmentTransaction.cb_commitNow;
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x0000C6CE File Offset: 0x0000A8CE
		private static void n_CommitNow(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<FragmentTransaction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CommitNow();
		}

		// Token: 0x060003D1 RID: 977
		[Register("commitNow", "()V", "GetCommitNowHandler")]
		public abstract void CommitNow();

		// Token: 0x060003D2 RID: 978 RVA: 0x0000C6DD File Offset: 0x0000A8DD
		private static Delegate GetCommitNowAllowingStateLossHandler()
		{
			if (FragmentTransaction.cb_commitNowAllowingStateLoss == null)
			{
				FragmentTransaction.cb_commitNowAllowingStateLoss = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(FragmentTransaction.n_CommitNowAllowingStateLoss));
			}
			return FragmentTransaction.cb_commitNowAllowingStateLoss;
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x0000C701 File Offset: 0x0000A901
		private static void n_CommitNowAllowingStateLoss(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<FragmentTransaction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CommitNowAllowingStateLoss();
		}

		// Token: 0x060003D4 RID: 980
		[Register("commitNowAllowingStateLoss", "()V", "GetCommitNowAllowingStateLossHandler")]
		public abstract void CommitNowAllowingStateLoss();

		// Token: 0x060003D5 RID: 981 RVA: 0x0000C710 File Offset: 0x0000A910
		private static Delegate GetDetach_Landroidx_fragment_app_Fragment_Handler()
		{
			if (FragmentTransaction.cb_detach_Landroidx_fragment_app_Fragment_ == null)
			{
				FragmentTransaction.cb_detach_Landroidx_fragment_app_Fragment_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(FragmentTransaction.n_Detach_Landroidx_fragment_app_Fragment_));
			}
			return FragmentTransaction.cb_detach_Landroidx_fragment_app_Fragment_;
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x0000C734 File Offset: 0x0000A934
		private static IntPtr n_Detach_Landroidx_fragment_app_Fragment_(IntPtr jnienv, IntPtr native__this, IntPtr native_fragment)
		{
			FragmentTransaction @object = Java.Lang.Object.GetObject<FragmentTransaction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Fragment object2 = Java.Lang.Object.GetObject<Fragment>(native_fragment, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Detach(object2));
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0000C75C File Offset: 0x0000A95C
		[Register("detach", "(Landroidx/fragment/app/Fragment;)Landroidx/fragment/app/FragmentTransaction;", "GetDetach_Landroidx_fragment_app_Fragment_Handler")]
		public unsafe virtual FragmentTransaction Detach(Fragment fragment)
		{
			FragmentTransaction @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((fragment == null) ? IntPtr.Zero : fragment.Handle);
				@object = Java.Lang.Object.GetObject<FragmentTransaction>(FragmentTransaction._members.InstanceMethods.InvokeVirtualObjectMethod("detach.(Landroidx/fragment/app/Fragment;)Landroidx/fragment/app/FragmentTransaction;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(fragment);
			}
			return @object;
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x0000C7D0 File Offset: 0x0000A9D0
		private static Delegate GetDisallowAddToBackStackHandler()
		{
			if (FragmentTransaction.cb_disallowAddToBackStack == null)
			{
				FragmentTransaction.cb_disallowAddToBackStack = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(FragmentTransaction.n_DisallowAddToBackStack));
			}
			return FragmentTransaction.cb_disallowAddToBackStack;
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x0000C7F4 File Offset: 0x0000A9F4
		private static IntPtr n_DisallowAddToBackStack(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<FragmentTransaction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DisallowAddToBackStack());
		}

		// Token: 0x060003DA RID: 986 RVA: 0x0000C808 File Offset: 0x0000AA08
		[Register("disallowAddToBackStack", "()Landroidx/fragment/app/FragmentTransaction;", "GetDisallowAddToBackStackHandler")]
		public virtual FragmentTransaction DisallowAddToBackStack()
		{
			return Java.Lang.Object.GetObject<FragmentTransaction>(FragmentTransaction._members.InstanceMethods.InvokeVirtualObjectMethod("disallowAddToBackStack.()Landroidx/fragment/app/FragmentTransaction;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060003DB RID: 987 RVA: 0x0000C83A File Offset: 0x0000AA3A
		private static Delegate GetHide_Landroidx_fragment_app_Fragment_Handler()
		{
			if (FragmentTransaction.cb_hide_Landroidx_fragment_app_Fragment_ == null)
			{
				FragmentTransaction.cb_hide_Landroidx_fragment_app_Fragment_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(FragmentTransaction.n_Hide_Landroidx_fragment_app_Fragment_));
			}
			return FragmentTransaction.cb_hide_Landroidx_fragment_app_Fragment_;
		}

		// Token: 0x060003DC RID: 988 RVA: 0x0000C860 File Offset: 0x0000AA60
		private static IntPtr n_Hide_Landroidx_fragment_app_Fragment_(IntPtr jnienv, IntPtr native__this, IntPtr native_fragment)
		{
			FragmentTransaction @object = Java.Lang.Object.GetObject<FragmentTransaction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Fragment object2 = Java.Lang.Object.GetObject<Fragment>(native_fragment, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Hide(object2));
		}

		// Token: 0x060003DD RID: 989 RVA: 0x0000C888 File Offset: 0x0000AA88
		[Register("hide", "(Landroidx/fragment/app/Fragment;)Landroidx/fragment/app/FragmentTransaction;", "GetHide_Landroidx_fragment_app_Fragment_Handler")]
		public unsafe virtual FragmentTransaction Hide(Fragment fragment)
		{
			FragmentTransaction @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((fragment == null) ? IntPtr.Zero : fragment.Handle);
				@object = Java.Lang.Object.GetObject<FragmentTransaction>(FragmentTransaction._members.InstanceMethods.InvokeVirtualObjectMethod("hide.(Landroidx/fragment/app/Fragment;)Landroidx/fragment/app/FragmentTransaction;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(fragment);
			}
			return @object;
		}

		// Token: 0x060003DE RID: 990 RVA: 0x0000C8FC File Offset: 0x0000AAFC
		private static Delegate GetRemove_Landroidx_fragment_app_Fragment_Handler()
		{
			if (FragmentTransaction.cb_remove_Landroidx_fragment_app_Fragment_ == null)
			{
				FragmentTransaction.cb_remove_Landroidx_fragment_app_Fragment_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(FragmentTransaction.n_Remove_Landroidx_fragment_app_Fragment_));
			}
			return FragmentTransaction.cb_remove_Landroidx_fragment_app_Fragment_;
		}

		// Token: 0x060003DF RID: 991 RVA: 0x0000C920 File Offset: 0x0000AB20
		private static IntPtr n_Remove_Landroidx_fragment_app_Fragment_(IntPtr jnienv, IntPtr native__this, IntPtr native_fragment)
		{
			FragmentTransaction @object = Java.Lang.Object.GetObject<FragmentTransaction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Fragment object2 = Java.Lang.Object.GetObject<Fragment>(native_fragment, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Remove(object2));
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x0000C948 File Offset: 0x0000AB48
		[Register("remove", "(Landroidx/fragment/app/Fragment;)Landroidx/fragment/app/FragmentTransaction;", "GetRemove_Landroidx_fragment_app_Fragment_Handler")]
		public unsafe virtual FragmentTransaction Remove(Fragment fragment)
		{
			FragmentTransaction @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((fragment == null) ? IntPtr.Zero : fragment.Handle);
				@object = Java.Lang.Object.GetObject<FragmentTransaction>(FragmentTransaction._members.InstanceMethods.InvokeVirtualObjectMethod("remove.(Landroidx/fragment/app/Fragment;)Landroidx/fragment/app/FragmentTransaction;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(fragment);
			}
			return @object;
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x0000C9BC File Offset: 0x0000ABBC
		private static Delegate GetReplace_ILandroidx_fragment_app_Fragment_Handler()
		{
			if (FragmentTransaction.cb_replace_ILandroidx_fragment_app_Fragment_ == null)
			{
				FragmentTransaction.cb_replace_ILandroidx_fragment_app_Fragment_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_L(FragmentTransaction.n_Replace_ILandroidx_fragment_app_Fragment_));
			}
			return FragmentTransaction.cb_replace_ILandroidx_fragment_app_Fragment_;
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x0000C9E0 File Offset: 0x0000ABE0
		private static IntPtr n_Replace_ILandroidx_fragment_app_Fragment_(IntPtr jnienv, IntPtr native__this, int containerViewId, IntPtr native_fragment)
		{
			FragmentTransaction @object = Java.Lang.Object.GetObject<FragmentTransaction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Fragment object2 = Java.Lang.Object.GetObject<Fragment>(native_fragment, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Replace(containerViewId, object2));
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x0000CA0C File Offset: 0x0000AC0C
		[Register("replace", "(ILandroidx/fragment/app/Fragment;)Landroidx/fragment/app/FragmentTransaction;", "GetReplace_ILandroidx_fragment_app_Fragment_Handler")]
		public unsafe virtual FragmentTransaction Replace(int containerViewId, Fragment fragment)
		{
			FragmentTransaction @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(containerViewId);
				ptr[1] = new JniArgumentValue((fragment == null) ? IntPtr.Zero : fragment.Handle);
				@object = Java.Lang.Object.GetObject<FragmentTransaction>(FragmentTransaction._members.InstanceMethods.InvokeVirtualObjectMethod("replace.(ILandroidx/fragment/app/Fragment;)Landroidx/fragment/app/FragmentTransaction;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(fragment);
			}
			return @object;
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x0000CA94 File Offset: 0x0000AC94
		private static Delegate GetReplace_ILandroidx_fragment_app_Fragment_Ljava_lang_String_Handler()
		{
			if (FragmentTransaction.cb_replace_ILandroidx_fragment_app_Fragment_Ljava_lang_String_ == null)
			{
				FragmentTransaction.cb_replace_ILandroidx_fragment_app_Fragment_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPILL_L(FragmentTransaction.n_Replace_ILandroidx_fragment_app_Fragment_Ljava_lang_String_));
			}
			return FragmentTransaction.cb_replace_ILandroidx_fragment_app_Fragment_Ljava_lang_String_;
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x0000CAB8 File Offset: 0x0000ACB8
		private static IntPtr n_Replace_ILandroidx_fragment_app_Fragment_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, int containerViewId, IntPtr native_fragment, IntPtr native_tag)
		{
			FragmentTransaction @object = Java.Lang.Object.GetObject<FragmentTransaction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Fragment object2 = Java.Lang.Object.GetObject<Fragment>(native_fragment, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_tag, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Replace(containerViewId, object2, @string));
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x0000CAEC File Offset: 0x0000ACEC
		[Register("replace", "(ILandroidx/fragment/app/Fragment;Ljava/lang/String;)Landroidx/fragment/app/FragmentTransaction;", "GetReplace_ILandroidx_fragment_app_Fragment_Ljava_lang_String_Handler")]
		public unsafe virtual FragmentTransaction Replace(int containerViewId, Fragment fragment, string tag)
		{
			IntPtr intPtr = JNIEnv.NewString(tag);
			FragmentTransaction @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(containerViewId);
				ptr[1] = new JniArgumentValue((fragment == null) ? IntPtr.Zero : fragment.Handle);
				ptr[2] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<FragmentTransaction>(FragmentTransaction._members.InstanceMethods.InvokeVirtualObjectMethod("replace.(ILandroidx/fragment/app/Fragment;Ljava/lang/String;)Landroidx/fragment/app/FragmentTransaction;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(fragment);
			}
			return @object;
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x0000CB98 File Offset: 0x0000AD98
		[Register("replace", "(ILjava/lang/Class;Landroid/os/Bundle;)Landroidx/fragment/app/FragmentTransaction;", "")]
		public unsafe FragmentTransaction Replace(int containerViewId, Class fragmentClass, Bundle args)
		{
			FragmentTransaction @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(containerViewId);
				ptr[1] = new JniArgumentValue((fragmentClass == null) ? IntPtr.Zero : fragmentClass.Handle);
				ptr[2] = new JniArgumentValue((args == null) ? IntPtr.Zero : args.Handle);
				@object = Java.Lang.Object.GetObject<FragmentTransaction>(FragmentTransaction._members.InstanceMethods.InvokeNonvirtualObjectMethod("replace.(ILjava/lang/Class;Landroid/os/Bundle;)Landroidx/fragment/app/FragmentTransaction;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(fragmentClass);
				GC.KeepAlive(args);
			}
			return @object;
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x0000CC4C File Offset: 0x0000AE4C
		[Register("replace", "(ILjava/lang/Class;Landroid/os/Bundle;Ljava/lang/String;)Landroidx/fragment/app/FragmentTransaction;", "")]
		public unsafe FragmentTransaction Replace(int containerViewId, Class fragmentClass, Bundle args, string tag)
		{
			IntPtr intPtr = JNIEnv.NewString(tag);
			FragmentTransaction @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(containerViewId);
				ptr[1] = new JniArgumentValue((fragmentClass == null) ? IntPtr.Zero : fragmentClass.Handle);
				ptr[2] = new JniArgumentValue((args == null) ? IntPtr.Zero : args.Handle);
				ptr[3] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<FragmentTransaction>(FragmentTransaction._members.InstanceMethods.InvokeNonvirtualObjectMethod("replace.(ILjava/lang/Class;Landroid/os/Bundle;Ljava/lang/String;)Landroidx/fragment/app/FragmentTransaction;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(fragmentClass);
				GC.KeepAlive(args);
			}
			return @object;
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x0000CD24 File Offset: 0x0000AF24
		private static Delegate GetRunOnCommit_Ljava_lang_Runnable_Handler()
		{
			if (FragmentTransaction.cb_runOnCommit_Ljava_lang_Runnable_ == null)
			{
				FragmentTransaction.cb_runOnCommit_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(FragmentTransaction.n_RunOnCommit_Ljava_lang_Runnable_));
			}
			return FragmentTransaction.cb_runOnCommit_Ljava_lang_Runnable_;
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x0000CD48 File Offset: 0x0000AF48
		private static IntPtr n_RunOnCommit_Ljava_lang_Runnable_(IntPtr jnienv, IntPtr native__this, IntPtr native_runnable)
		{
			FragmentTransaction @object = Java.Lang.Object.GetObject<FragmentTransaction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IRunnable object2 = Java.Lang.Object.GetObject<IRunnable>(native_runnable, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.RunOnCommit(object2));
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x0000CD70 File Offset: 0x0000AF70
		[Register("runOnCommit", "(Ljava/lang/Runnable;)Landroidx/fragment/app/FragmentTransaction;", "GetRunOnCommit_Ljava_lang_Runnable_Handler")]
		public unsafe virtual FragmentTransaction RunOnCommit(IRunnable runnable)
		{
			FragmentTransaction @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((runnable == null) ? IntPtr.Zero : ((Java.Lang.Object)runnable).Handle);
				@object = Java.Lang.Object.GetObject<FragmentTransaction>(FragmentTransaction._members.InstanceMethods.InvokeVirtualObjectMethod("runOnCommit.(Ljava/lang/Runnable;)Landroidx/fragment/app/FragmentTransaction;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(runnable);
			}
			return @object;
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x0000CDE8 File Offset: 0x0000AFE8
		private static Delegate GetSetAllowOptimization_ZHandler()
		{
			if (FragmentTransaction.cb_setAllowOptimization_Z == null)
			{
				FragmentTransaction.cb_setAllowOptimization_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_L(FragmentTransaction.n_SetAllowOptimization_Z));
			}
			return FragmentTransaction.cb_setAllowOptimization_Z;
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0000CE0C File Offset: 0x0000B00C
		private static IntPtr n_SetAllowOptimization_Z(IntPtr jnienv, IntPtr native__this, bool allowOptimization)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<FragmentTransaction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetAllowOptimization(allowOptimization));
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0000CE24 File Offset: 0x0000B024
		[Register("setAllowOptimization", "(Z)Landroidx/fragment/app/FragmentTransaction;", "GetSetAllowOptimization_ZHandler")]
		public unsafe virtual FragmentTransaction SetAllowOptimization(bool allowOptimization)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(allowOptimization);
			return Java.Lang.Object.GetObject<FragmentTransaction>(FragmentTransaction._members.InstanceMethods.InvokeVirtualObjectMethod("setAllowOptimization.(Z)Landroidx/fragment/app/FragmentTransaction;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x0000CE6D File Offset: 0x0000B06D
		private static Delegate GetSetBreadCrumbShortTitle_IHandler()
		{
			if (FragmentTransaction.cb_setBreadCrumbShortTitle_I == null)
			{
				FragmentTransaction.cb_setBreadCrumbShortTitle_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(FragmentTransaction.n_SetBreadCrumbShortTitle_I));
			}
			return FragmentTransaction.cb_setBreadCrumbShortTitle_I;
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x0000CE91 File Offset: 0x0000B091
		private static IntPtr n_SetBreadCrumbShortTitle_I(IntPtr jnienv, IntPtr native__this, int res)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<FragmentTransaction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetBreadCrumbShortTitle(res));
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x0000CEA8 File Offset: 0x0000B0A8
		[Register("setBreadCrumbShortTitle", "(I)Landroidx/fragment/app/FragmentTransaction;", "GetSetBreadCrumbShortTitle_IHandler")]
		public unsafe virtual FragmentTransaction SetBreadCrumbShortTitle(int res)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(res);
			return Java.Lang.Object.GetObject<FragmentTransaction>(FragmentTransaction._members.InstanceMethods.InvokeVirtualObjectMethod("setBreadCrumbShortTitle.(I)Landroidx/fragment/app/FragmentTransaction;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x0000CEF1 File Offset: 0x0000B0F1
		private static Delegate GetSetBreadCrumbShortTitle_Ljava_lang_CharSequence_Handler()
		{
			if (FragmentTransaction.cb_setBreadCrumbShortTitle_Ljava_lang_CharSequence_ == null)
			{
				FragmentTransaction.cb_setBreadCrumbShortTitle_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(FragmentTransaction.n_SetBreadCrumbShortTitle_Ljava_lang_CharSequence_));
			}
			return FragmentTransaction.cb_setBreadCrumbShortTitle_Ljava_lang_CharSequence_;
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x0000CF18 File Offset: 0x0000B118
		private static IntPtr n_SetBreadCrumbShortTitle_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_text)
		{
			FragmentTransaction @object = Java.Lang.Object.GetObject<FragmentTransaction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_text, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetBreadCrumbShortTitle(object2));
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x0000CF40 File Offset: 0x0000B140
		[Register("setBreadCrumbShortTitle", "(Ljava/lang/CharSequence;)Landroidx/fragment/app/FragmentTransaction;", "GetSetBreadCrumbShortTitle_Ljava_lang_CharSequence_Handler")]
		public unsafe virtual FragmentTransaction SetBreadCrumbShortTitle(ICharSequence text)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(text);
			FragmentTransaction @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<FragmentTransaction>(FragmentTransaction._members.InstanceMethods.InvokeVirtualObjectMethod("setBreadCrumbShortTitle.(Ljava/lang/CharSequence;)Landroidx/fragment/app/FragmentTransaction;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(text);
			}
			return @object;
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x0000CFB4 File Offset: 0x0000B1B4
		public FragmentTransaction SetBreadCrumbShortTitle(string text)
		{
			Java.Lang.String @string = (text == null) ? null : new Java.Lang.String(text);
			FragmentTransaction result = this.SetBreadCrumbShortTitle(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x0000CFDE File Offset: 0x0000B1DE
		private static Delegate GetSetBreadCrumbTitle_IHandler()
		{
			if (FragmentTransaction.cb_setBreadCrumbTitle_I == null)
			{
				FragmentTransaction.cb_setBreadCrumbTitle_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(FragmentTransaction.n_SetBreadCrumbTitle_I));
			}
			return FragmentTransaction.cb_setBreadCrumbTitle_I;
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x0000D002 File Offset: 0x0000B202
		private static IntPtr n_SetBreadCrumbTitle_I(IntPtr jnienv, IntPtr native__this, int res)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<FragmentTransaction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetBreadCrumbTitle(res));
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0000D018 File Offset: 0x0000B218
		[Register("setBreadCrumbTitle", "(I)Landroidx/fragment/app/FragmentTransaction;", "GetSetBreadCrumbTitle_IHandler")]
		public unsafe virtual FragmentTransaction SetBreadCrumbTitle(int res)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(res);
			return Java.Lang.Object.GetObject<FragmentTransaction>(FragmentTransaction._members.InstanceMethods.InvokeVirtualObjectMethod("setBreadCrumbTitle.(I)Landroidx/fragment/app/FragmentTransaction;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0000D061 File Offset: 0x0000B261
		private static Delegate GetSetBreadCrumbTitle_Ljava_lang_CharSequence_Handler()
		{
			if (FragmentTransaction.cb_setBreadCrumbTitle_Ljava_lang_CharSequence_ == null)
			{
				FragmentTransaction.cb_setBreadCrumbTitle_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(FragmentTransaction.n_SetBreadCrumbTitle_Ljava_lang_CharSequence_));
			}
			return FragmentTransaction.cb_setBreadCrumbTitle_Ljava_lang_CharSequence_;
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x0000D088 File Offset: 0x0000B288
		private static IntPtr n_SetBreadCrumbTitle_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_text)
		{
			FragmentTransaction @object = Java.Lang.Object.GetObject<FragmentTransaction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_text, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetBreadCrumbTitle(object2));
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x0000D0B0 File Offset: 0x0000B2B0
		[Register("setBreadCrumbTitle", "(Ljava/lang/CharSequence;)Landroidx/fragment/app/FragmentTransaction;", "GetSetBreadCrumbTitle_Ljava_lang_CharSequence_Handler")]
		public unsafe virtual FragmentTransaction SetBreadCrumbTitle(ICharSequence text)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(text);
			FragmentTransaction @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<FragmentTransaction>(FragmentTransaction._members.InstanceMethods.InvokeVirtualObjectMethod("setBreadCrumbTitle.(Ljava/lang/CharSequence;)Landroidx/fragment/app/FragmentTransaction;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(text);
			}
			return @object;
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0000D124 File Offset: 0x0000B324
		public FragmentTransaction SetBreadCrumbTitle(string text)
		{
			Java.Lang.String @string = (text == null) ? null : new Java.Lang.String(text);
			FragmentTransaction result = this.SetBreadCrumbTitle(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x0000D14E File Offset: 0x0000B34E
		private static Delegate GetSetCustomAnimations_IIHandler()
		{
			if (FragmentTransaction.cb_setCustomAnimations_II == null)
			{
				FragmentTransaction.cb_setCustomAnimations_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_L(FragmentTransaction.n_SetCustomAnimations_II));
			}
			return FragmentTransaction.cb_setCustomAnimations_II;
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x0000D172 File Offset: 0x0000B372
		private static IntPtr n_SetCustomAnimations_II(IntPtr jnienv, IntPtr native__this, int enter, int exit)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<FragmentTransaction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetCustomAnimations(enter, exit));
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x0000D188 File Offset: 0x0000B388
		[Register("setCustomAnimations", "(II)Landroidx/fragment/app/FragmentTransaction;", "GetSetCustomAnimations_IIHandler")]
		public unsafe virtual FragmentTransaction SetCustomAnimations(int enter, int exit)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(enter);
			ptr[1] = new JniArgumentValue(exit);
			return Java.Lang.Object.GetObject<FragmentTransaction>(FragmentTransaction._members.InstanceMethods.InvokeVirtualObjectMethod("setCustomAnimations.(II)Landroidx/fragment/app/FragmentTransaction;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x0000D1E4 File Offset: 0x0000B3E4
		private static Delegate GetSetCustomAnimations_IIIIHandler()
		{
			if (FragmentTransaction.cb_setCustomAnimations_IIII == null)
			{
				FragmentTransaction.cb_setCustomAnimations_IIII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIII_L(FragmentTransaction.n_SetCustomAnimations_IIII));
			}
			return FragmentTransaction.cb_setCustomAnimations_IIII;
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x0000D208 File Offset: 0x0000B408
		private static IntPtr n_SetCustomAnimations_IIII(IntPtr jnienv, IntPtr native__this, int enter, int exit, int popEnter, int popExit)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<FragmentTransaction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetCustomAnimations(enter, exit, popEnter, popExit));
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x0000D224 File Offset: 0x0000B424
		[Register("setCustomAnimations", "(IIII)Landroidx/fragment/app/FragmentTransaction;", "GetSetCustomAnimations_IIIIHandler")]
		public unsafe virtual FragmentTransaction SetCustomAnimations(int enter, int exit, int popEnter, int popExit)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(enter);
			ptr[1] = new JniArgumentValue(exit);
			ptr[2] = new JniArgumentValue(popEnter);
			ptr[3] = new JniArgumentValue(popExit);
			return Java.Lang.Object.GetObject<FragmentTransaction>(FragmentTransaction._members.InstanceMethods.InvokeVirtualObjectMethod("setCustomAnimations.(IIII)Landroidx/fragment/app/FragmentTransaction;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x0000D2AD File Offset: 0x0000B4AD
		private static Delegate GetSetMaxLifecycle_Landroidx_fragment_app_Fragment_Landroidx_lifecycle_Lifecycle_State_Handler()
		{
			if (FragmentTransaction.cb_setMaxLifecycle_Landroidx_fragment_app_Fragment_Landroidx_lifecycle_Lifecycle_State_ == null)
			{
				FragmentTransaction.cb_setMaxLifecycle_Landroidx_fragment_app_Fragment_Landroidx_lifecycle_Lifecycle_State_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(FragmentTransaction.n_SetMaxLifecycle_Landroidx_fragment_app_Fragment_Landroidx_lifecycle_Lifecycle_State_));
			}
			return FragmentTransaction.cb_setMaxLifecycle_Landroidx_fragment_app_Fragment_Landroidx_lifecycle_Lifecycle_State_;
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x0000D2D4 File Offset: 0x0000B4D4
		private static IntPtr n_SetMaxLifecycle_Landroidx_fragment_app_Fragment_Landroidx_lifecycle_Lifecycle_State_(IntPtr jnienv, IntPtr native__this, IntPtr native_fragment, IntPtr native_state)
		{
			FragmentTransaction @object = Java.Lang.Object.GetObject<FragmentTransaction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Fragment object2 = Java.Lang.Object.GetObject<Fragment>(native_fragment, JniHandleOwnership.DoNotTransfer);
			Lifecycle.State object3 = Java.Lang.Object.GetObject<Lifecycle.State>(native_state, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetMaxLifecycle(object2, object3));
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x0000D308 File Offset: 0x0000B508
		[Register("setMaxLifecycle", "(Landroidx/fragment/app/Fragment;Landroidx/lifecycle/Lifecycle$State;)Landroidx/fragment/app/FragmentTransaction;", "GetSetMaxLifecycle_Landroidx_fragment_app_Fragment_Landroidx_lifecycle_Lifecycle_State_Handler")]
		public unsafe virtual FragmentTransaction SetMaxLifecycle(Fragment fragment, Lifecycle.State state)
		{
			FragmentTransaction @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((fragment == null) ? IntPtr.Zero : fragment.Handle);
				ptr[1] = new JniArgumentValue((state == null) ? IntPtr.Zero : state.Handle);
				@object = Java.Lang.Object.GetObject<FragmentTransaction>(FragmentTransaction._members.InstanceMethods.InvokeVirtualObjectMethod("setMaxLifecycle.(Landroidx/fragment/app/Fragment;Landroidx/lifecycle/Lifecycle$State;)Landroidx/fragment/app/FragmentTransaction;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(fragment);
				GC.KeepAlive(state);
			}
			return @object;
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x0000D3A4 File Offset: 0x0000B5A4
		private static Delegate GetSetPrimaryNavigationFragment_Landroidx_fragment_app_Fragment_Handler()
		{
			if (FragmentTransaction.cb_setPrimaryNavigationFragment_Landroidx_fragment_app_Fragment_ == null)
			{
				FragmentTransaction.cb_setPrimaryNavigationFragment_Landroidx_fragment_app_Fragment_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(FragmentTransaction.n_SetPrimaryNavigationFragment_Landroidx_fragment_app_Fragment_));
			}
			return FragmentTransaction.cb_setPrimaryNavigationFragment_Landroidx_fragment_app_Fragment_;
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x0000D3C8 File Offset: 0x0000B5C8
		private static IntPtr n_SetPrimaryNavigationFragment_Landroidx_fragment_app_Fragment_(IntPtr jnienv, IntPtr native__this, IntPtr native_fragment)
		{
			FragmentTransaction @object = Java.Lang.Object.GetObject<FragmentTransaction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Fragment object2 = Java.Lang.Object.GetObject<Fragment>(native_fragment, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetPrimaryNavigationFragment(object2));
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x0000D3F0 File Offset: 0x0000B5F0
		[Register("setPrimaryNavigationFragment", "(Landroidx/fragment/app/Fragment;)Landroidx/fragment/app/FragmentTransaction;", "GetSetPrimaryNavigationFragment_Landroidx_fragment_app_Fragment_Handler")]
		public unsafe virtual FragmentTransaction SetPrimaryNavigationFragment(Fragment fragment)
		{
			FragmentTransaction @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((fragment == null) ? IntPtr.Zero : fragment.Handle);
				@object = Java.Lang.Object.GetObject<FragmentTransaction>(FragmentTransaction._members.InstanceMethods.InvokeVirtualObjectMethod("setPrimaryNavigationFragment.(Landroidx/fragment/app/Fragment;)Landroidx/fragment/app/FragmentTransaction;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(fragment);
			}
			return @object;
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x0000D464 File Offset: 0x0000B664
		private static Delegate GetSetReorderingAllowed_ZHandler()
		{
			if (FragmentTransaction.cb_setReorderingAllowed_Z == null)
			{
				FragmentTransaction.cb_setReorderingAllowed_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_L(FragmentTransaction.n_SetReorderingAllowed_Z));
			}
			return FragmentTransaction.cb_setReorderingAllowed_Z;
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x0000D488 File Offset: 0x0000B688
		private static IntPtr n_SetReorderingAllowed_Z(IntPtr jnienv, IntPtr native__this, bool reorderingAllowed)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<FragmentTransaction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetReorderingAllowed(reorderingAllowed));
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x0000D4A0 File Offset: 0x0000B6A0
		[Register("setReorderingAllowed", "(Z)Landroidx/fragment/app/FragmentTransaction;", "GetSetReorderingAllowed_ZHandler")]
		public unsafe virtual FragmentTransaction SetReorderingAllowed(bool reorderingAllowed)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(reorderingAllowed);
			return Java.Lang.Object.GetObject<FragmentTransaction>(FragmentTransaction._members.InstanceMethods.InvokeVirtualObjectMethod("setReorderingAllowed.(Z)Landroidx/fragment/app/FragmentTransaction;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x0000D4E9 File Offset: 0x0000B6E9
		private static Delegate GetSetTransition_IHandler()
		{
			if (FragmentTransaction.cb_setTransition_I == null)
			{
				FragmentTransaction.cb_setTransition_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(FragmentTransaction.n_SetTransition_I));
			}
			return FragmentTransaction.cb_setTransition_I;
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x0000D50D File Offset: 0x0000B70D
		private static IntPtr n_SetTransition_I(IntPtr jnienv, IntPtr native__this, int transit)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<FragmentTransaction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetTransition(transit));
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x0000D524 File Offset: 0x0000B724
		[Register("setTransition", "(I)Landroidx/fragment/app/FragmentTransaction;", "GetSetTransition_IHandler")]
		public unsafe virtual FragmentTransaction SetTransition(int transit)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(transit);
			return Java.Lang.Object.GetObject<FragmentTransaction>(FragmentTransaction._members.InstanceMethods.InvokeVirtualObjectMethod("setTransition.(I)Landroidx/fragment/app/FragmentTransaction;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x0000D56D File Offset: 0x0000B76D
		private static Delegate GetSetTransitionStyle_IHandler()
		{
			if (FragmentTransaction.cb_setTransitionStyle_I == null)
			{
				FragmentTransaction.cb_setTransitionStyle_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(FragmentTransaction.n_SetTransitionStyle_I));
			}
			return FragmentTransaction.cb_setTransitionStyle_I;
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x0000D591 File Offset: 0x0000B791
		private static IntPtr n_SetTransitionStyle_I(IntPtr jnienv, IntPtr native__this, int styleRes)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<FragmentTransaction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetTransitionStyle(styleRes));
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x0000D5A8 File Offset: 0x0000B7A8
		[Register("setTransitionStyle", "(I)Landroidx/fragment/app/FragmentTransaction;", "GetSetTransitionStyle_IHandler")]
		public unsafe virtual FragmentTransaction SetTransitionStyle(int styleRes)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(styleRes);
			return Java.Lang.Object.GetObject<FragmentTransaction>(FragmentTransaction._members.InstanceMethods.InvokeVirtualObjectMethod("setTransitionStyle.(I)Landroidx/fragment/app/FragmentTransaction;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x0000D5F1 File Offset: 0x0000B7F1
		private static Delegate GetShow_Landroidx_fragment_app_Fragment_Handler()
		{
			if (FragmentTransaction.cb_show_Landroidx_fragment_app_Fragment_ == null)
			{
				FragmentTransaction.cb_show_Landroidx_fragment_app_Fragment_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(FragmentTransaction.n_Show_Landroidx_fragment_app_Fragment_));
			}
			return FragmentTransaction.cb_show_Landroidx_fragment_app_Fragment_;
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x0000D618 File Offset: 0x0000B818
		private static IntPtr n_Show_Landroidx_fragment_app_Fragment_(IntPtr jnienv, IntPtr native__this, IntPtr native_fragment)
		{
			FragmentTransaction @object = Java.Lang.Object.GetObject<FragmentTransaction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Fragment object2 = Java.Lang.Object.GetObject<Fragment>(native_fragment, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Show(object2));
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x0000D640 File Offset: 0x0000B840
		[Register("show", "(Landroidx/fragment/app/Fragment;)Landroidx/fragment/app/FragmentTransaction;", "GetShow_Landroidx_fragment_app_Fragment_Handler")]
		public unsafe virtual FragmentTransaction Show(Fragment fragment)
		{
			FragmentTransaction @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((fragment == null) ? IntPtr.Zero : fragment.Handle);
				@object = Java.Lang.Object.GetObject<FragmentTransaction>(FragmentTransaction._members.InstanceMethods.InvokeVirtualObjectMethod("show.(Landroidx/fragment/app/Fragment;)Landroidx/fragment/app/FragmentTransaction;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(fragment);
			}
			return @object;
		}

		// Token: 0x040000F5 RID: 245
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/fragment/app/FragmentTransaction", typeof(FragmentTransaction));

		// Token: 0x040000F6 RID: 246
		private static Delegate cb_isAddToBackStackAllowed;

		// Token: 0x040000F7 RID: 247
		private static Delegate cb_isEmpty;

		// Token: 0x040000F8 RID: 248
		private static Delegate cb_add_Landroidx_fragment_app_Fragment_Ljava_lang_String_;

		// Token: 0x040000F9 RID: 249
		private static Delegate cb_add_ILandroidx_fragment_app_Fragment_;

		// Token: 0x040000FA RID: 250
		private static Delegate cb_add_ILandroidx_fragment_app_Fragment_Ljava_lang_String_;

		// Token: 0x040000FB RID: 251
		private static Delegate cb_addSharedElement_Landroid_view_View_Ljava_lang_String_;

		// Token: 0x040000FC RID: 252
		private static Delegate cb_addToBackStack_Ljava_lang_String_;

		// Token: 0x040000FD RID: 253
		private static Delegate cb_attach_Landroidx_fragment_app_Fragment_;

		// Token: 0x040000FE RID: 254
		private static Delegate cb_commit;

		// Token: 0x040000FF RID: 255
		private static Delegate cb_commitAllowingStateLoss;

		// Token: 0x04000100 RID: 256
		private static Delegate cb_commitNow;

		// Token: 0x04000101 RID: 257
		private static Delegate cb_commitNowAllowingStateLoss;

		// Token: 0x04000102 RID: 258
		private static Delegate cb_detach_Landroidx_fragment_app_Fragment_;

		// Token: 0x04000103 RID: 259
		private static Delegate cb_disallowAddToBackStack;

		// Token: 0x04000104 RID: 260
		private static Delegate cb_hide_Landroidx_fragment_app_Fragment_;

		// Token: 0x04000105 RID: 261
		private static Delegate cb_remove_Landroidx_fragment_app_Fragment_;

		// Token: 0x04000106 RID: 262
		private static Delegate cb_replace_ILandroidx_fragment_app_Fragment_;

		// Token: 0x04000107 RID: 263
		private static Delegate cb_replace_ILandroidx_fragment_app_Fragment_Ljava_lang_String_;

		// Token: 0x04000108 RID: 264
		private static Delegate cb_runOnCommit_Ljava_lang_Runnable_;

		// Token: 0x04000109 RID: 265
		private static Delegate cb_setAllowOptimization_Z;

		// Token: 0x0400010A RID: 266
		private static Delegate cb_setBreadCrumbShortTitle_I;

		// Token: 0x0400010B RID: 267
		private static Delegate cb_setBreadCrumbShortTitle_Ljava_lang_CharSequence_;

		// Token: 0x0400010C RID: 268
		private static Delegate cb_setBreadCrumbTitle_I;

		// Token: 0x0400010D RID: 269
		private static Delegate cb_setBreadCrumbTitle_Ljava_lang_CharSequence_;

		// Token: 0x0400010E RID: 270
		private static Delegate cb_setCustomAnimations_II;

		// Token: 0x0400010F RID: 271
		private static Delegate cb_setCustomAnimations_IIII;

		// Token: 0x04000110 RID: 272
		private static Delegate cb_setMaxLifecycle_Landroidx_fragment_app_Fragment_Landroidx_lifecycle_Lifecycle_State_;

		// Token: 0x04000111 RID: 273
		private static Delegate cb_setPrimaryNavigationFragment_Landroidx_fragment_app_Fragment_;

		// Token: 0x04000112 RID: 274
		private static Delegate cb_setReorderingAllowed_Z;

		// Token: 0x04000113 RID: 275
		private static Delegate cb_setTransition_I;

		// Token: 0x04000114 RID: 276
		private static Delegate cb_setTransitionStyle_I;

		// Token: 0x04000115 RID: 277
		private static Delegate cb_show_Landroidx_fragment_app_Fragment_;
	}
}
