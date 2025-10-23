using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Fragment.App
{
	// Token: 0x0200002D RID: 45
	[Register("androidx/fragment/app/FragmentFactory", DoNotGenerateAcw = true)]
	public class FragmentFactory : Java.Lang.Object
	{
		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000246 RID: 582 RVA: 0x000077A8 File Offset: 0x000059A8
		internal static IntPtr class_ref
		{
			get
			{
				return FragmentFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000247 RID: 583 RVA: 0x000077CC File Offset: 0x000059CC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FragmentFactory._members;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000248 RID: 584 RVA: 0x000077D4 File Offset: 0x000059D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return FragmentFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000249 RID: 585 RVA: 0x000077F8 File Offset: 0x000059F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FragmentFactory._members.ManagedPeerType;
			}
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00003624 File Offset: 0x00001824
		protected FragmentFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00007804 File Offset: 0x00005A04
		[Register(".ctor", "()V", "")]
		public FragmentFactory() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(FragmentFactory._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			FragmentFactory._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00007872 File Offset: 0x00005A72
		private static Delegate GetInstantiate_Ljava_lang_ClassLoader_Ljava_lang_String_Handler()
		{
			if (FragmentFactory.cb_instantiate_Ljava_lang_ClassLoader_Ljava_lang_String_ == null)
			{
				FragmentFactory.cb_instantiate_Ljava_lang_ClassLoader_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(FragmentFactory.n_Instantiate_Ljava_lang_ClassLoader_Ljava_lang_String_));
			}
			return FragmentFactory.cb_instantiate_Ljava_lang_ClassLoader_Ljava_lang_String_;
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00007898 File Offset: 0x00005A98
		private static IntPtr n_Instantiate_Ljava_lang_ClassLoader_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_classLoader, IntPtr native_className)
		{
			FragmentFactory @object = Java.Lang.Object.GetObject<FragmentFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ClassLoader object2 = Java.Lang.Object.GetObject<ClassLoader>(native_classLoader, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_className, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Instantiate(object2, @string));
		}

		// Token: 0x0600024E RID: 590 RVA: 0x000078CC File Offset: 0x00005ACC
		[Register("instantiate", "(Ljava/lang/ClassLoader;Ljava/lang/String;)Landroidx/fragment/app/Fragment;", "GetInstantiate_Ljava_lang_ClassLoader_Ljava_lang_String_Handler")]
		public unsafe virtual Fragment Instantiate(ClassLoader classLoader, string className)
		{
			IntPtr intPtr = JNIEnv.NewString(className);
			Fragment @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((classLoader == null) ? IntPtr.Zero : classLoader.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Fragment>(FragmentFactory._members.InstanceMethods.InvokeVirtualObjectMethod("instantiate.(Ljava/lang/ClassLoader;Ljava/lang/String;)Landroidx/fragment/app/Fragment;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(classLoader);
			}
			return @object;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00007960 File Offset: 0x00005B60
		[Register("loadFragmentClass", "(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Class;", "")]
		public unsafe static Class LoadFragmentClass(ClassLoader classLoader, string className)
		{
			IntPtr intPtr = JNIEnv.NewString(className);
			Class @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((classLoader == null) ? IntPtr.Zero : classLoader.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Class>(FragmentFactory._members.StaticMethods.InvokeObjectMethod("loadFragmentClass.(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Class;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(classLoader);
			}
			return @object;
		}

		// Token: 0x0400007C RID: 124
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/fragment/app/FragmentFactory", typeof(FragmentFactory));

		// Token: 0x0400007D RID: 125
		private static Delegate cb_instantiate_Ljava_lang_ClassLoader_Ljava_lang_String_;
	}
}
