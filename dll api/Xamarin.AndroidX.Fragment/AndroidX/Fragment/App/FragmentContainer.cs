using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Fragment.App
{
	// Token: 0x0200002B RID: 43
	[Register("androidx/fragment/app/FragmentContainer", DoNotGenerateAcw = true)]
	public abstract class FragmentContainer : Java.Lang.Object
	{
		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000230 RID: 560 RVA: 0x00007498 File Offset: 0x00005698
		internal static IntPtr class_ref
		{
			get
			{
				return FragmentContainer._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000231 RID: 561 RVA: 0x000074BC File Offset: 0x000056BC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FragmentContainer._members;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000232 RID: 562 RVA: 0x000074C4 File Offset: 0x000056C4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return FragmentContainer._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000233 RID: 563 RVA: 0x000074E8 File Offset: 0x000056E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FragmentContainer._members.ManagedPeerType;
			}
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00003624 File Offset: 0x00001824
		protected FragmentContainer(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000235 RID: 565 RVA: 0x000074F4 File Offset: 0x000056F4
		[Register(".ctor", "()V", "")]
		public FragmentContainer() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(FragmentContainer._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			FragmentContainer._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00007562 File Offset: 0x00005762
		private static Delegate GetInstantiate_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_Handler()
		{
			if (FragmentContainer.cb_instantiate_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ == null)
			{
				FragmentContainer.cb_instantiate_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(FragmentContainer.n_Instantiate_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_));
			}
			return FragmentContainer.cb_instantiate_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_;
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00007588 File Offset: 0x00005788
		private static IntPtr n_Instantiate_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_className, IntPtr native_arguments)
		{
			FragmentContainer @object = Java.Lang.Object.GetObject<FragmentContainer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_className, JniHandleOwnership.DoNotTransfer);
			Bundle object3 = Java.Lang.Object.GetObject<Bundle>(native_arguments, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Instantiate(object2, @string, object3));
		}

		// Token: 0x06000238 RID: 568 RVA: 0x000075C4 File Offset: 0x000057C4
		[Register("instantiate", "(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;)Landroidx/fragment/app/Fragment;", "GetInstantiate_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_Handler")]
		public unsafe virtual Fragment Instantiate(Context context, string className, Bundle arguments)
		{
			IntPtr intPtr = JNIEnv.NewString(className);
			Fragment @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((arguments == null) ? IntPtr.Zero : arguments.Handle);
				@object = Java.Lang.Object.GetObject<Fragment>(FragmentContainer._members.InstanceMethods.InvokeVirtualObjectMethod("instantiate.(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;)Landroidx/fragment/app/Fragment;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(context);
				GC.KeepAlive(arguments);
			}
			return @object;
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00007684 File Offset: 0x00005884
		private static Delegate GetOnFindViewById_IHandler()
		{
			if (FragmentContainer.cb_onFindViewById_I == null)
			{
				FragmentContainer.cb_onFindViewById_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(FragmentContainer.n_OnFindViewById_I));
			}
			return FragmentContainer.cb_onFindViewById_I;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x000076A8 File Offset: 0x000058A8
		private static IntPtr n_OnFindViewById_I(IntPtr jnienv, IntPtr native__this, int id)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<FragmentContainer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnFindViewById(id));
		}

		// Token: 0x0600023B RID: 571
		[Register("onFindViewById", "(I)Landroid/view/View;", "GetOnFindViewById_IHandler")]
		public abstract View OnFindViewById(int id);

		// Token: 0x0600023C RID: 572 RVA: 0x000076BD File Offset: 0x000058BD
		private static Delegate GetOnHasViewHandler()
		{
			if (FragmentContainer.cb_onHasView == null)
			{
				FragmentContainer.cb_onHasView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(FragmentContainer.n_OnHasView));
			}
			return FragmentContainer.cb_onHasView;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x000076E1 File Offset: 0x000058E1
		private static bool n_OnHasView(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<FragmentContainer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnHasView();
		}

		// Token: 0x0600023E RID: 574
		[Register("onHasView", "()Z", "GetOnHasViewHandler")]
		public abstract bool OnHasView();

		// Token: 0x04000077 RID: 119
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/fragment/app/FragmentContainer", typeof(FragmentContainer));

		// Token: 0x04000078 RID: 120
		private static Delegate cb_instantiate_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_;

		// Token: 0x04000079 RID: 121
		private static Delegate cb_onFindViewById_I;

		// Token: 0x0400007A RID: 122
		private static Delegate cb_onHasView;
	}
}
