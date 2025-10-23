using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace AndroidX.Fragment.App
{
	// Token: 0x0200002E RID: 46
	[Register("androidx/fragment/app/FragmentHostCallback", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"E"
	})]
	public abstract class FragmentHostCallback : FragmentContainer
	{
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000251 RID: 593 RVA: 0x00007A10 File Offset: 0x00005C10
		internal new static IntPtr class_ref
		{
			get
			{
				return FragmentHostCallback._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000252 RID: 594 RVA: 0x00007A34 File Offset: 0x00005C34
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FragmentHostCallback._members;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000253 RID: 595 RVA: 0x00007A3C File Offset: 0x00005C3C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return FragmentHostCallback._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000254 RID: 596 RVA: 0x00007A60 File Offset: 0x00005C60
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FragmentHostCallback._members.ManagedPeerType;
			}
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0000770B File Offset: 0x0000590B
		protected FragmentHostCallback(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00007A6C File Offset: 0x00005C6C
		[Register(".ctor", "(Landroid/content/Context;Landroid/os/Handler;I)V", "")]
		public unsafe FragmentHostCallback(Context context, Handler handler, int windowAnimations) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((handler == null) ? IntPtr.Zero : handler.Handle);
				ptr[2] = new JniArgumentValue(windowAnimations);
				base.SetHandle(FragmentHostCallback._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/os/Handler;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				FragmentHostCallback._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/os/Handler;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(handler);
			}
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00007B58 File Offset: 0x00005D58
		private static Delegate GetGetHandlerHandler()
		{
			if (FragmentHostCallback.cb_getHandler == null)
			{
				FragmentHostCallback.cb_getHandler = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(FragmentHostCallback.n_GetHandler));
			}
			return FragmentHostCallback.cb_getHandler;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00007B7C File Offset: 0x00005D7C
		private static IntPtr n_GetHandler(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<FragmentHostCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Handler);
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000259 RID: 601 RVA: 0x00007B90 File Offset: 0x00005D90
		public virtual Handler Handler
		{
			[Register("getHandler", "()Landroid/os/Handler;", "GetGetHandlerHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Handler>(FragmentHostCallback._members.InstanceMethods.InvokeVirtualObjectMethod("getHandler.()Landroid/os/Handler;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00007BC2 File Offset: 0x00005DC2
		private static Delegate GetOnDump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_Handler()
		{
			if (FragmentHostCallback.cb_onDump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_ == null)
			{
				FragmentHostCallback.cb_onDump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLL_V(FragmentHostCallback.n_OnDump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_));
			}
			return FragmentHostCallback.cb_onDump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_;
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00007BE8 File Offset: 0x00005DE8
		private static void n_OnDump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_prefix, IntPtr native_fd, IntPtr native_writer, IntPtr native_args)
		{
			FragmentHostCallback @object = Java.Lang.Object.GetObject<FragmentHostCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_prefix, JniHandleOwnership.DoNotTransfer);
			FileDescriptor object2 = Java.Lang.Object.GetObject<FileDescriptor>(native_fd, JniHandleOwnership.DoNotTransfer);
			PrintWriter object3 = Java.Lang.Object.GetObject<PrintWriter>(native_writer, JniHandleOwnership.DoNotTransfer);
			string[] array = (string[])JNIEnv.GetArray(native_args, JniHandleOwnership.DoNotTransfer, typeof(string));
			@object.OnDump(@string, object2, object3, array);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_args);
			}
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00007C44 File Offset: 0x00005E44
		[Register("onDump", "(Ljava/lang/String;Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V", "GetOnDump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_Handler")]
		public unsafe virtual void OnDump(string prefix, FileDescriptor fd, PrintWriter writer, string[] args)
		{
			IntPtr intPtr = JNIEnv.NewString(prefix);
			IntPtr intPtr2 = JNIEnv.NewArray(args);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((fd == null) ? IntPtr.Zero : fd.Handle);
				ptr[2] = new JniArgumentValue((writer == null) ? IntPtr.Zero : writer.Handle);
				ptr[3] = new JniArgumentValue(intPtr2);
				FragmentHostCallback._members.InstanceMethods.InvokeVirtualVoidMethod("onDump.(Ljava/lang/String;Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (args != null)
				{
					JNIEnv.CopyArray(intPtr2, args);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(fd);
				GC.KeepAlive(writer);
				GC.KeepAlive(args);
			}
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00007D2C File Offset: 0x00005F2C
		private static Delegate GetOnFindViewById_IHandler()
		{
			if (FragmentHostCallback.cb_onFindViewById_I == null)
			{
				FragmentHostCallback.cb_onFindViewById_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(FragmentHostCallback.n_OnFindViewById_I));
			}
			return FragmentHostCallback.cb_onFindViewById_I;
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00007D50 File Offset: 0x00005F50
		private static IntPtr n_OnFindViewById_I(IntPtr jnienv, IntPtr native__this, int id)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<FragmentHostCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnFindViewById(id));
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00007D68 File Offset: 0x00005F68
		[Register("onFindViewById", "(I)Landroid/view/View;", "GetOnFindViewById_IHandler")]
		public unsafe override View OnFindViewById(int id)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(id);
			return Java.Lang.Object.GetObject<View>(FragmentHostCallback._members.InstanceMethods.InvokeVirtualObjectMethod("onFindViewById.(I)Landroid/view/View;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00007DB1 File Offset: 0x00005FB1
		private static Delegate GetOnGetHostHandler()
		{
			if (FragmentHostCallback.cb_onGetHost == null)
			{
				FragmentHostCallback.cb_onGetHost = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(FragmentHostCallback.n_OnGetHost));
			}
			return FragmentHostCallback.cb_onGetHost;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00007DD5 File Offset: 0x00005FD5
		private static IntPtr n_OnGetHost(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<FragmentHostCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnGetHost());
		}

		// Token: 0x06000262 RID: 610
		[Register("onGetHost", "()Ljava/lang/Object;", "GetOnGetHostHandler")]
		public abstract Java.Lang.Object OnGetHost();

		// Token: 0x06000263 RID: 611 RVA: 0x00007DE9 File Offset: 0x00005FE9
		private static Delegate GetOnGetLayoutInflaterHandler()
		{
			if (FragmentHostCallback.cb_onGetLayoutInflater == null)
			{
				FragmentHostCallback.cb_onGetLayoutInflater = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(FragmentHostCallback.n_OnGetLayoutInflater));
			}
			return FragmentHostCallback.cb_onGetLayoutInflater;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00007E0D File Offset: 0x0000600D
		private static IntPtr n_OnGetLayoutInflater(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<FragmentHostCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnGetLayoutInflater());
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00007E24 File Offset: 0x00006024
		[Register("onGetLayoutInflater", "()Landroid/view/LayoutInflater;", "GetOnGetLayoutInflaterHandler")]
		public virtual LayoutInflater OnGetLayoutInflater()
		{
			return Java.Lang.Object.GetObject<LayoutInflater>(FragmentHostCallback._members.InstanceMethods.InvokeVirtualObjectMethod("onGetLayoutInflater.()Landroid/view/LayoutInflater;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00007E56 File Offset: 0x00006056
		private static Delegate GetOnGetWindowAnimationsHandler()
		{
			if (FragmentHostCallback.cb_onGetWindowAnimations == null)
			{
				FragmentHostCallback.cb_onGetWindowAnimations = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(FragmentHostCallback.n_OnGetWindowAnimations));
			}
			return FragmentHostCallback.cb_onGetWindowAnimations;
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00007E7A File Offset: 0x0000607A
		private static int n_OnGetWindowAnimations(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<FragmentHostCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnGetWindowAnimations();
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00007E89 File Offset: 0x00006089
		[Register("onGetWindowAnimations", "()I", "GetOnGetWindowAnimationsHandler")]
		public virtual int OnGetWindowAnimations()
		{
			return FragmentHostCallback._members.InstanceMethods.InvokeVirtualInt32Method("onGetWindowAnimations.()I", this, null);
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00007EA2 File Offset: 0x000060A2
		private static Delegate GetOnHasViewHandler()
		{
			if (FragmentHostCallback.cb_onHasView == null)
			{
				FragmentHostCallback.cb_onHasView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(FragmentHostCallback.n_OnHasView));
			}
			return FragmentHostCallback.cb_onHasView;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00007EC6 File Offset: 0x000060C6
		private static bool n_OnHasView(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<FragmentHostCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnHasView();
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00007ED5 File Offset: 0x000060D5
		[Register("onHasView", "()Z", "GetOnHasViewHandler")]
		public override bool OnHasView()
		{
			return FragmentHostCallback._members.InstanceMethods.InvokeVirtualBooleanMethod("onHasView.()Z", this, null);
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00007EEE File Offset: 0x000060EE
		private static Delegate GetOnHasWindowAnimationsHandler()
		{
			if (FragmentHostCallback.cb_onHasWindowAnimations == null)
			{
				FragmentHostCallback.cb_onHasWindowAnimations = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(FragmentHostCallback.n_OnHasWindowAnimations));
			}
			return FragmentHostCallback.cb_onHasWindowAnimations;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00007F12 File Offset: 0x00006112
		private static bool n_OnHasWindowAnimations(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<FragmentHostCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnHasWindowAnimations();
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00007F21 File Offset: 0x00006121
		[Register("onHasWindowAnimations", "()Z", "GetOnHasWindowAnimationsHandler")]
		public virtual bool OnHasWindowAnimations()
		{
			return FragmentHostCallback._members.InstanceMethods.InvokeVirtualBooleanMethod("onHasWindowAnimations.()Z", this, null);
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00007F3A File Offset: 0x0000613A
		private static Delegate GetOnRequestPermissionsFromFragment_Landroidx_fragment_app_Fragment_arrayLjava_lang_String_IHandler()
		{
			if (FragmentHostCallback.cb_onRequestPermissionsFromFragment_Landroidx_fragment_app_Fragment_arrayLjava_lang_String_I == null)
			{
				FragmentHostCallback.cb_onRequestPermissionsFromFragment_Landroidx_fragment_app_Fragment_arrayLjava_lang_String_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLI_V(FragmentHostCallback.n_OnRequestPermissionsFromFragment_Landroidx_fragment_app_Fragment_arrayLjava_lang_String_I));
			}
			return FragmentHostCallback.cb_onRequestPermissionsFromFragment_Landroidx_fragment_app_Fragment_arrayLjava_lang_String_I;
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00007F60 File Offset: 0x00006160
		private static void n_OnRequestPermissionsFromFragment_Landroidx_fragment_app_Fragment_arrayLjava_lang_String_I(IntPtr jnienv, IntPtr native__this, IntPtr native_fragment, IntPtr native_permissions, int requestCode)
		{
			FragmentHostCallback @object = Java.Lang.Object.GetObject<FragmentHostCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Fragment object2 = Java.Lang.Object.GetObject<Fragment>(native_fragment, JniHandleOwnership.DoNotTransfer);
			string[] array = (string[])JNIEnv.GetArray(native_permissions, JniHandleOwnership.DoNotTransfer, typeof(string));
			@object.OnRequestPermissionsFromFragment(object2, array, requestCode);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_permissions);
			}
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00007FA8 File Offset: 0x000061A8
		[Register("onRequestPermissionsFromFragment", "(Landroidx/fragment/app/Fragment;[Ljava/lang/String;I)V", "GetOnRequestPermissionsFromFragment_Landroidx_fragment_app_Fragment_arrayLjava_lang_String_IHandler")]
		public unsafe virtual void OnRequestPermissionsFromFragment(Fragment fragment, string[] permissions, int requestCode)
		{
			IntPtr intPtr = JNIEnv.NewArray(permissions);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((fragment == null) ? IntPtr.Zero : fragment.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(requestCode);
				FragmentHostCallback._members.InstanceMethods.InvokeVirtualVoidMethod("onRequestPermissionsFromFragment.(Landroidx/fragment/app/Fragment;[Ljava/lang/String;I)V", this, ptr);
			}
			finally
			{
				if (permissions != null)
				{
					JNIEnv.CopyArray(intPtr, permissions);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(fragment);
				GC.KeepAlive(permissions);
			}
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00008054 File Offset: 0x00006254
		private static Delegate GetOnShouldSaveFragmentState_Landroidx_fragment_app_Fragment_Handler()
		{
			if (FragmentHostCallback.cb_onShouldSaveFragmentState_Landroidx_fragment_app_Fragment_ == null)
			{
				FragmentHostCallback.cb_onShouldSaveFragmentState_Landroidx_fragment_app_Fragment_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(FragmentHostCallback.n_OnShouldSaveFragmentState_Landroidx_fragment_app_Fragment_));
			}
			return FragmentHostCallback.cb_onShouldSaveFragmentState_Landroidx_fragment_app_Fragment_;
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00008078 File Offset: 0x00006278
		private static bool n_OnShouldSaveFragmentState_Landroidx_fragment_app_Fragment_(IntPtr jnienv, IntPtr native__this, IntPtr native_fragment)
		{
			FragmentHostCallback @object = Java.Lang.Object.GetObject<FragmentHostCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Fragment object2 = Java.Lang.Object.GetObject<Fragment>(native_fragment, JniHandleOwnership.DoNotTransfer);
			return @object.OnShouldSaveFragmentState(object2);
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0000809C File Offset: 0x0000629C
		[Register("onShouldSaveFragmentState", "(Landroidx/fragment/app/Fragment;)Z", "GetOnShouldSaveFragmentState_Landroidx_fragment_app_Fragment_Handler")]
		public unsafe virtual bool OnShouldSaveFragmentState(Fragment fragment)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((fragment == null) ? IntPtr.Zero : fragment.Handle);
				result = FragmentHostCallback._members.InstanceMethods.InvokeVirtualBooleanMethod("onShouldSaveFragmentState.(Landroidx/fragment/app/Fragment;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(fragment);
			}
			return result;
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00008104 File Offset: 0x00006304
		private static Delegate GetOnShouldShowRequestPermissionRationale_Ljava_lang_String_Handler()
		{
			if (FragmentHostCallback.cb_onShouldShowRequestPermissionRationale_Ljava_lang_String_ == null)
			{
				FragmentHostCallback.cb_onShouldShowRequestPermissionRationale_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(FragmentHostCallback.n_OnShouldShowRequestPermissionRationale_Ljava_lang_String_));
			}
			return FragmentHostCallback.cb_onShouldShowRequestPermissionRationale_Ljava_lang_String_;
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00008128 File Offset: 0x00006328
		private static bool n_OnShouldShowRequestPermissionRationale_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_permission)
		{
			FragmentHostCallback @object = Java.Lang.Object.GetObject<FragmentHostCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_permission, JniHandleOwnership.DoNotTransfer);
			return @object.OnShouldShowRequestPermissionRationale(@string);
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0000814C File Offset: 0x0000634C
		[Register("onShouldShowRequestPermissionRationale", "(Ljava/lang/String;)Z", "GetOnShouldShowRequestPermissionRationale_Ljava_lang_String_Handler")]
		public unsafe virtual bool OnShouldShowRequestPermissionRationale(string permission)
		{
			IntPtr intPtr = JNIEnv.NewString(permission);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = FragmentHostCallback._members.InstanceMethods.InvokeVirtualBooleanMethod("onShouldShowRequestPermissionRationale.(Ljava/lang/String;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06000278 RID: 632 RVA: 0x000081AC File Offset: 0x000063AC
		private static Delegate GetOnStartActivityFromFragment_Landroidx_fragment_app_Fragment_Landroid_content_Intent_IHandler()
		{
			if (FragmentHostCallback.cb_onStartActivityFromFragment_Landroidx_fragment_app_Fragment_Landroid_content_Intent_I == null)
			{
				FragmentHostCallback.cb_onStartActivityFromFragment_Landroidx_fragment_app_Fragment_Landroid_content_Intent_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLI_V(FragmentHostCallback.n_OnStartActivityFromFragment_Landroidx_fragment_app_Fragment_Landroid_content_Intent_I));
			}
			return FragmentHostCallback.cb_onStartActivityFromFragment_Landroidx_fragment_app_Fragment_Landroid_content_Intent_I;
		}

		// Token: 0x06000279 RID: 633 RVA: 0x000081D0 File Offset: 0x000063D0
		private static void n_OnStartActivityFromFragment_Landroidx_fragment_app_Fragment_Landroid_content_Intent_I(IntPtr jnienv, IntPtr native__this, IntPtr native_fragment, IntPtr native_intent, int requestCode)
		{
			FragmentHostCallback @object = Java.Lang.Object.GetObject<FragmentHostCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Fragment object2 = Java.Lang.Object.GetObject<Fragment>(native_fragment, JniHandleOwnership.DoNotTransfer);
			Intent object3 = Java.Lang.Object.GetObject<Intent>(native_intent, JniHandleOwnership.DoNotTransfer);
			@object.OnStartActivityFromFragment(object2, object3, requestCode);
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00008200 File Offset: 0x00006400
		[Register("onStartActivityFromFragment", "(Landroidx/fragment/app/Fragment;Landroid/content/Intent;I)V", "GetOnStartActivityFromFragment_Landroidx_fragment_app_Fragment_Landroid_content_Intent_IHandler")]
		public unsafe virtual void OnStartActivityFromFragment(Fragment fragment, Intent intent, int requestCode)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((fragment == null) ? IntPtr.Zero : fragment.Handle);
				ptr[1] = new JniArgumentValue((intent == null) ? IntPtr.Zero : intent.Handle);
				ptr[2] = new JniArgumentValue(requestCode);
				FragmentHostCallback._members.InstanceMethods.InvokeVirtualVoidMethod("onStartActivityFromFragment.(Landroidx/fragment/app/Fragment;Landroid/content/Intent;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(fragment);
				GC.KeepAlive(intent);
			}
		}

		// Token: 0x0600027B RID: 635 RVA: 0x000082A4 File Offset: 0x000064A4
		private static Delegate GetOnStartActivityFromFragment_Landroidx_fragment_app_Fragment_Landroid_content_Intent_ILandroid_os_Bundle_Handler()
		{
			if (FragmentHostCallback.cb_onStartActivityFromFragment_Landroidx_fragment_app_Fragment_Landroid_content_Intent_ILandroid_os_Bundle_ == null)
			{
				FragmentHostCallback.cb_onStartActivityFromFragment_Landroidx_fragment_app_Fragment_Landroid_content_Intent_ILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLIL_V(FragmentHostCallback.n_OnStartActivityFromFragment_Landroidx_fragment_app_Fragment_Landroid_content_Intent_ILandroid_os_Bundle_));
			}
			return FragmentHostCallback.cb_onStartActivityFromFragment_Landroidx_fragment_app_Fragment_Landroid_content_Intent_ILandroid_os_Bundle_;
		}

		// Token: 0x0600027C RID: 636 RVA: 0x000082C8 File Offset: 0x000064C8
		private static void n_OnStartActivityFromFragment_Landroidx_fragment_app_Fragment_Landroid_content_Intent_ILandroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_fragment, IntPtr native_intent, int requestCode, IntPtr native_options)
		{
			FragmentHostCallback @object = Java.Lang.Object.GetObject<FragmentHostCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Fragment object2 = Java.Lang.Object.GetObject<Fragment>(native_fragment, JniHandleOwnership.DoNotTransfer);
			Intent object3 = Java.Lang.Object.GetObject<Intent>(native_intent, JniHandleOwnership.DoNotTransfer);
			Bundle object4 = Java.Lang.Object.GetObject<Bundle>(native_options, JniHandleOwnership.DoNotTransfer);
			@object.OnStartActivityFromFragment(object2, object3, requestCode, object4);
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00008300 File Offset: 0x00006500
		[Register("onStartActivityFromFragment", "(Landroidx/fragment/app/Fragment;Landroid/content/Intent;ILandroid/os/Bundle;)V", "GetOnStartActivityFromFragment_Landroidx_fragment_app_Fragment_Landroid_content_Intent_ILandroid_os_Bundle_Handler")]
		public unsafe virtual void OnStartActivityFromFragment(Fragment fragment, Intent intent, int requestCode, Bundle options)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((fragment == null) ? IntPtr.Zero : fragment.Handle);
				ptr[1] = new JniArgumentValue((intent == null) ? IntPtr.Zero : intent.Handle);
				ptr[2] = new JniArgumentValue(requestCode);
				ptr[3] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				FragmentHostCallback._members.InstanceMethods.InvokeVirtualVoidMethod("onStartActivityFromFragment.(Landroidx/fragment/app/Fragment;Landroid/content/Intent;ILandroid/os/Bundle;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(fragment);
				GC.KeepAlive(intent);
				GC.KeepAlive(options);
			}
		}

		// Token: 0x0600027E RID: 638 RVA: 0x000083D0 File Offset: 0x000065D0
		private static Delegate GetOnStartIntentSenderFromFragment_Landroidx_fragment_app_Fragment_Landroid_content_IntentSender_ILandroid_content_Intent_IIILandroid_os_Bundle_Handler()
		{
			if (FragmentHostCallback.cb_onStartIntentSenderFromFragment_Landroidx_fragment_app_Fragment_Landroid_content_IntentSender_ILandroid_content_Intent_IIILandroid_os_Bundle_ == null)
			{
				FragmentHostCallback.cb_onStartIntentSenderFromFragment_Landroidx_fragment_app_Fragment_Landroid_content_IntentSender_ILandroid_content_Intent_IIILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLILIIIL_V(FragmentHostCallback.n_OnStartIntentSenderFromFragment_Landroidx_fragment_app_Fragment_Landroid_content_IntentSender_ILandroid_content_Intent_IIILandroid_os_Bundle_));
			}
			return FragmentHostCallback.cb_onStartIntentSenderFromFragment_Landroidx_fragment_app_Fragment_Landroid_content_IntentSender_ILandroid_content_Intent_IIILandroid_os_Bundle_;
		}

		// Token: 0x0600027F RID: 639 RVA: 0x000083F4 File Offset: 0x000065F4
		private static void n_OnStartIntentSenderFromFragment_Landroidx_fragment_app_Fragment_Landroid_content_IntentSender_ILandroid_content_Intent_IIILandroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_fragment, IntPtr native_intent, int requestCode, IntPtr native_fillInIntent, int flagsMask, int flagsValues, int extraFlags, IntPtr native_options)
		{
			FragmentHostCallback @object = Java.Lang.Object.GetObject<FragmentHostCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Fragment object2 = Java.Lang.Object.GetObject<Fragment>(native_fragment, JniHandleOwnership.DoNotTransfer);
			IntentSender object3 = Java.Lang.Object.GetObject<IntentSender>(native_intent, JniHandleOwnership.DoNotTransfer);
			Intent object4 = Java.Lang.Object.GetObject<Intent>(native_fillInIntent, JniHandleOwnership.DoNotTransfer);
			Bundle object5 = Java.Lang.Object.GetObject<Bundle>(native_options, JniHandleOwnership.DoNotTransfer);
			@object.OnStartIntentSenderFromFragment(object2, object3, requestCode, object4, flagsMask, flagsValues, extraFlags, object5);
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0000843C File Offset: 0x0000663C
		[Register("onStartIntentSenderFromFragment", "(Landroidx/fragment/app/Fragment;Landroid/content/IntentSender;ILandroid/content/Intent;IIILandroid/os/Bundle;)V", "GetOnStartIntentSenderFromFragment_Landroidx_fragment_app_Fragment_Landroid_content_IntentSender_ILandroid_content_Intent_IIILandroid_os_Bundle_Handler")]
		public unsafe virtual void OnStartIntentSenderFromFragment(Fragment fragment, IntentSender intent, int requestCode, Intent fillInIntent, int flagsMask, int flagsValues, int extraFlags, Bundle options)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((fragment == null) ? IntPtr.Zero : fragment.Handle);
				ptr[1] = new JniArgumentValue((intent == null) ? IntPtr.Zero : intent.Handle);
				ptr[2] = new JniArgumentValue(requestCode);
				ptr[3] = new JniArgumentValue((fillInIntent == null) ? IntPtr.Zero : fillInIntent.Handle);
				ptr[4] = new JniArgumentValue(flagsMask);
				ptr[5] = new JniArgumentValue(flagsValues);
				ptr[6] = new JniArgumentValue(extraFlags);
				ptr[7] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				FragmentHostCallback._members.InstanceMethods.InvokeVirtualVoidMethod("onStartIntentSenderFromFragment.(Landroidx/fragment/app/Fragment;Landroid/content/IntentSender;ILandroid/content/Intent;IIILandroid/os/Bundle;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(fragment);
				GC.KeepAlive(intent);
				GC.KeepAlive(fillInIntent);
				GC.KeepAlive(options);
			}
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0000858C File Offset: 0x0000678C
		private static Delegate GetOnSupportInvalidateOptionsMenuHandler()
		{
			if (FragmentHostCallback.cb_onSupportInvalidateOptionsMenu == null)
			{
				FragmentHostCallback.cb_onSupportInvalidateOptionsMenu = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(FragmentHostCallback.n_OnSupportInvalidateOptionsMenu));
			}
			return FragmentHostCallback.cb_onSupportInvalidateOptionsMenu;
		}

		// Token: 0x06000282 RID: 642 RVA: 0x000085B0 File Offset: 0x000067B0
		private static void n_OnSupportInvalidateOptionsMenu(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<FragmentHostCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnSupportInvalidateOptionsMenu();
		}

		// Token: 0x06000283 RID: 643 RVA: 0x000085BF File Offset: 0x000067BF
		[Register("onSupportInvalidateOptionsMenu", "()V", "GetOnSupportInvalidateOptionsMenuHandler")]
		public virtual void OnSupportInvalidateOptionsMenu()
		{
			FragmentHostCallback._members.InstanceMethods.InvokeVirtualVoidMethod("onSupportInvalidateOptionsMenu.()V", this, null);
		}

		// Token: 0x0400007E RID: 126
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/fragment/app/FragmentHostCallback", typeof(FragmentHostCallback));

		// Token: 0x0400007F RID: 127
		private static Delegate cb_getHandler;

		// Token: 0x04000080 RID: 128
		private static Delegate cb_onDump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_;

		// Token: 0x04000081 RID: 129
		private static Delegate cb_onFindViewById_I;

		// Token: 0x04000082 RID: 130
		private static Delegate cb_onGetHost;

		// Token: 0x04000083 RID: 131
		private static Delegate cb_onGetLayoutInflater;

		// Token: 0x04000084 RID: 132
		private static Delegate cb_onGetWindowAnimations;

		// Token: 0x04000085 RID: 133
		private static Delegate cb_onHasView;

		// Token: 0x04000086 RID: 134
		private static Delegate cb_onHasWindowAnimations;

		// Token: 0x04000087 RID: 135
		private static Delegate cb_onRequestPermissionsFromFragment_Landroidx_fragment_app_Fragment_arrayLjava_lang_String_I;

		// Token: 0x04000088 RID: 136
		private static Delegate cb_onShouldSaveFragmentState_Landroidx_fragment_app_Fragment_;

		// Token: 0x04000089 RID: 137
		private static Delegate cb_onShouldShowRequestPermissionRationale_Ljava_lang_String_;

		// Token: 0x0400008A RID: 138
		private static Delegate cb_onStartActivityFromFragment_Landroidx_fragment_app_Fragment_Landroid_content_Intent_I;

		// Token: 0x0400008B RID: 139
		private static Delegate cb_onStartActivityFromFragment_Landroidx_fragment_app_Fragment_Landroid_content_Intent_ILandroid_os_Bundle_;

		// Token: 0x0400008C RID: 140
		private static Delegate cb_onStartIntentSenderFromFragment_Landroidx_fragment_app_Fragment_Landroid_content_IntentSender_ILandroid_content_Intent_IIILandroid_os_Bundle_;

		// Token: 0x0400008D RID: 141
		private static Delegate cb_onSupportInvalidateOptionsMenu;
	}
}
