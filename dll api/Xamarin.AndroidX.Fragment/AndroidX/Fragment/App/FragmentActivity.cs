using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.OS;
using Android.Runtime;
using AndroidX.Activity;
using AndroidX.Core.App;
using AndroidX.Lifecycle;
using AndroidX.Loader.App;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Fragment.App
{
	// Token: 0x02000027 RID: 39
	[Register("androidx/fragment/app/FragmentActivity", DoNotGenerateAcw = true)]
	public class FragmentActivity : AndroidX.Activity.ComponentActivity, ActivityCompat.IOnRequestPermissionsResultCallback, IJavaObject, IDisposable, IJavaPeerable, ActivityCompat.IRequestPermissionsRequestCodeValidator
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600008C RID: 140 RVA: 0x0000207F File Offset: 0x0000027F
		public override Lifecycle Lifecycle
		{
			get
			{
				return base.Lifecycle;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00002088 File Offset: 0x00000288
		internal static IntPtr class_ref
		{
			get
			{
				return FragmentActivity._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600008E RID: 142 RVA: 0x000020AC File Offset: 0x000002AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FragmentActivity._members;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600008F RID: 143 RVA: 0x000020B4 File Offset: 0x000002B4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return FragmentActivity._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000090 RID: 144 RVA: 0x000020D8 File Offset: 0x000002D8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FragmentActivity._members.ManagedPeerType;
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000020E4 File Offset: 0x000002E4
		protected FragmentActivity(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000020F0 File Offset: 0x000002F0
		[Register(".ctor", "()V", "")]
		public FragmentActivity() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(FragmentActivity._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			FragmentActivity._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002160 File Offset: 0x00000360
		[Register(".ctor", "(I)V", "")]
		public unsafe FragmentActivity(int contentLayoutId) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(contentLayoutId);
			base.SetHandle(FragmentActivity._members.InstanceMethods.StartCreateInstance("(I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			FragmentActivity._members.InstanceMethods.FinishCreateInstance("(I)V", this, ptr);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000021E4 File Offset: 0x000003E4
		private static Delegate GetGetSupportFragmentManagerHandler()
		{
			if (FragmentActivity.cb_getSupportFragmentManager == null)
			{
				FragmentActivity.cb_getSupportFragmentManager = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(FragmentActivity.n_GetSupportFragmentManager));
			}
			return FragmentActivity.cb_getSupportFragmentManager;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00002208 File Offset: 0x00000408
		private static IntPtr n_GetSupportFragmentManager(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<FragmentActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SupportFragmentManager);
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000096 RID: 150 RVA: 0x0000221C File Offset: 0x0000041C
		public virtual FragmentManager SupportFragmentManager
		{
			[Register("getSupportFragmentManager", "()Landroidx/fragment/app/FragmentManager;", "GetGetSupportFragmentManagerHandler")]
			get
			{
				return Java.Lang.Object.GetObject<FragmentManager>(FragmentActivity._members.InstanceMethods.InvokeVirtualObjectMethod("getSupportFragmentManager.()Landroidx/fragment/app/FragmentManager;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000224E File Offset: 0x0000044E
		private static Delegate GetGetSupportLoaderManagerHandler()
		{
			if (FragmentActivity.cb_getSupportLoaderManager == null)
			{
				FragmentActivity.cb_getSupportLoaderManager = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(FragmentActivity.n_GetSupportLoaderManager));
			}
			return FragmentActivity.cb_getSupportLoaderManager;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00002272 File Offset: 0x00000472
		private static IntPtr n_GetSupportLoaderManager(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<FragmentActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SupportLoaderManager);
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00002288 File Offset: 0x00000488
		public virtual LoaderManager SupportLoaderManager
		{
			[Register("getSupportLoaderManager", "()Landroidx/loader/app/LoaderManager;", "GetGetSupportLoaderManagerHandler")]
			get
			{
				return Java.Lang.Object.GetObject<LoaderManager>(FragmentActivity._members.InstanceMethods.InvokeVirtualObjectMethod("getSupportLoaderManager.()Landroidx/loader/app/LoaderManager;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000022BA File Offset: 0x000004BA
		private static Delegate GetOnAttachFragment_Landroidx_fragment_app_Fragment_Handler()
		{
			if (FragmentActivity.cb_onAttachFragment_Landroidx_fragment_app_Fragment_ == null)
			{
				FragmentActivity.cb_onAttachFragment_Landroidx_fragment_app_Fragment_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(FragmentActivity.n_OnAttachFragment_Landroidx_fragment_app_Fragment_));
			}
			return FragmentActivity.cb_onAttachFragment_Landroidx_fragment_app_Fragment_;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000022E0 File Offset: 0x000004E0
		private static void n_OnAttachFragment_Landroidx_fragment_app_Fragment_(IntPtr jnienv, IntPtr native__this, IntPtr native_fragment)
		{
			FragmentActivity @object = Java.Lang.Object.GetObject<FragmentActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Fragment object2 = Java.Lang.Object.GetObject<Fragment>(native_fragment, JniHandleOwnership.DoNotTransfer);
			@object.OnAttachFragment(object2);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002304 File Offset: 0x00000504
		[Register("onAttachFragment", "(Landroidx/fragment/app/Fragment;)V", "GetOnAttachFragment_Landroidx_fragment_app_Fragment_Handler")]
		public unsafe virtual void OnAttachFragment(Fragment fragment)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((fragment == null) ? IntPtr.Zero : fragment.Handle);
				FragmentActivity._members.InstanceMethods.InvokeVirtualVoidMethod("onAttachFragment.(Landroidx/fragment/app/Fragment;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(fragment);
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002368 File Offset: 0x00000568
		private static Delegate GetOnResumeFragmentsHandler()
		{
			if (FragmentActivity.cb_onResumeFragments == null)
			{
				FragmentActivity.cb_onResumeFragments = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(FragmentActivity.n_OnResumeFragments));
			}
			return FragmentActivity.cb_onResumeFragments;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0000238C File Offset: 0x0000058C
		private static void n_OnResumeFragments(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<FragmentActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnResumeFragments();
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000239B File Offset: 0x0000059B
		[Register("onResumeFragments", "()V", "GetOnResumeFragmentsHandler")]
		protected virtual void OnResumeFragments()
		{
			FragmentActivity._members.InstanceMethods.InvokeVirtualVoidMethod("onResumeFragments.()V", this, null);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000023B4 File Offset: 0x000005B4
		private static Delegate GetSetEnterSharedElementCallback_Landroidx_core_app_SharedElementCallback_Handler()
		{
			if (FragmentActivity.cb_setEnterSharedElementCallback_Landroidx_core_app_SharedElementCallback_ == null)
			{
				FragmentActivity.cb_setEnterSharedElementCallback_Landroidx_core_app_SharedElementCallback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(FragmentActivity.n_SetEnterSharedElementCallback_Landroidx_core_app_SharedElementCallback_));
			}
			return FragmentActivity.cb_setEnterSharedElementCallback_Landroidx_core_app_SharedElementCallback_;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000023D8 File Offset: 0x000005D8
		private static void n_SetEnterSharedElementCallback_Landroidx_core_app_SharedElementCallback_(IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			FragmentActivity @object = Java.Lang.Object.GetObject<FragmentActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			SharedElementCallback object2 = Java.Lang.Object.GetObject<SharedElementCallback>(native__callback, JniHandleOwnership.DoNotTransfer);
			@object.SetEnterSharedElementCallback(object2);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x000023FC File Offset: 0x000005FC
		[Register("setEnterSharedElementCallback", "(Landroidx/core/app/SharedElementCallback;)V", "GetSetEnterSharedElementCallback_Landroidx_core_app_SharedElementCallback_Handler")]
		public unsafe virtual void SetEnterSharedElementCallback(SharedElementCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				FragmentActivity._members.InstanceMethods.InvokeVirtualVoidMethod("setEnterSharedElementCallback.(Landroidx/core/app/SharedElementCallback;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002460 File Offset: 0x00000660
		private static Delegate GetSetExitSharedElementCallback_Landroidx_core_app_SharedElementCallback_Handler()
		{
			if (FragmentActivity.cb_setExitSharedElementCallback_Landroidx_core_app_SharedElementCallback_ == null)
			{
				FragmentActivity.cb_setExitSharedElementCallback_Landroidx_core_app_SharedElementCallback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(FragmentActivity.n_SetExitSharedElementCallback_Landroidx_core_app_SharedElementCallback_));
			}
			return FragmentActivity.cb_setExitSharedElementCallback_Landroidx_core_app_SharedElementCallback_;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00002484 File Offset: 0x00000684
		private static void n_SetExitSharedElementCallback_Landroidx_core_app_SharedElementCallback_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			FragmentActivity @object = Java.Lang.Object.GetObject<FragmentActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			SharedElementCallback object2 = Java.Lang.Object.GetObject<SharedElementCallback>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.SetExitSharedElementCallback(object2);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000024A8 File Offset: 0x000006A8
		[Register("setExitSharedElementCallback", "(Landroidx/core/app/SharedElementCallback;)V", "GetSetExitSharedElementCallback_Landroidx_core_app_SharedElementCallback_Handler")]
		public unsafe virtual void SetExitSharedElementCallback(SharedElementCallback listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : listener.Handle);
				FragmentActivity._members.InstanceMethods.InvokeVirtualVoidMethod("setExitSharedElementCallback.(Landroidx/core/app/SharedElementCallback;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0000250C File Offset: 0x0000070C
		private static Delegate GetStartActivityFromFragment_Landroidx_fragment_app_Fragment_Landroid_content_Intent_IHandler()
		{
			if (FragmentActivity.cb_startActivityFromFragment_Landroidx_fragment_app_Fragment_Landroid_content_Intent_I == null)
			{
				FragmentActivity.cb_startActivityFromFragment_Landroidx_fragment_app_Fragment_Landroid_content_Intent_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLI_V(FragmentActivity.n_StartActivityFromFragment_Landroidx_fragment_app_Fragment_Landroid_content_Intent_I));
			}
			return FragmentActivity.cb_startActivityFromFragment_Landroidx_fragment_app_Fragment_Landroid_content_Intent_I;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002530 File Offset: 0x00000730
		private static void n_StartActivityFromFragment_Landroidx_fragment_app_Fragment_Landroid_content_Intent_I(IntPtr jnienv, IntPtr native__this, IntPtr native_fragment, IntPtr native_intent, int requestCode)
		{
			FragmentActivity @object = Java.Lang.Object.GetObject<FragmentActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Fragment object2 = Java.Lang.Object.GetObject<Fragment>(native_fragment, JniHandleOwnership.DoNotTransfer);
			Intent object3 = Java.Lang.Object.GetObject<Intent>(native_intent, JniHandleOwnership.DoNotTransfer);
			@object.StartActivityFromFragment(object2, object3, requestCode);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002560 File Offset: 0x00000760
		[Register("startActivityFromFragment", "(Landroidx/fragment/app/Fragment;Landroid/content/Intent;I)V", "GetStartActivityFromFragment_Landroidx_fragment_app_Fragment_Landroid_content_Intent_IHandler")]
		public unsafe virtual void StartActivityFromFragment(Fragment fragment, Intent intent, int requestCode)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((fragment == null) ? IntPtr.Zero : fragment.Handle);
				ptr[1] = new JniArgumentValue((intent == null) ? IntPtr.Zero : intent.Handle);
				ptr[2] = new JniArgumentValue(requestCode);
				FragmentActivity._members.InstanceMethods.InvokeVirtualVoidMethod("startActivityFromFragment.(Landroidx/fragment/app/Fragment;Landroid/content/Intent;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(fragment);
				GC.KeepAlive(intent);
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002604 File Offset: 0x00000804
		private static Delegate GetStartActivityFromFragment_Landroidx_fragment_app_Fragment_Landroid_content_Intent_ILandroid_os_Bundle_Handler()
		{
			if (FragmentActivity.cb_startActivityFromFragment_Landroidx_fragment_app_Fragment_Landroid_content_Intent_ILandroid_os_Bundle_ == null)
			{
				FragmentActivity.cb_startActivityFromFragment_Landroidx_fragment_app_Fragment_Landroid_content_Intent_ILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLIL_V(FragmentActivity.n_StartActivityFromFragment_Landroidx_fragment_app_Fragment_Landroid_content_Intent_ILandroid_os_Bundle_));
			}
			return FragmentActivity.cb_startActivityFromFragment_Landroidx_fragment_app_Fragment_Landroid_content_Intent_ILandroid_os_Bundle_;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002628 File Offset: 0x00000828
		private static void n_StartActivityFromFragment_Landroidx_fragment_app_Fragment_Landroid_content_Intent_ILandroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_fragment, IntPtr native_intent, int requestCode, IntPtr native_options)
		{
			FragmentActivity @object = Java.Lang.Object.GetObject<FragmentActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Fragment object2 = Java.Lang.Object.GetObject<Fragment>(native_fragment, JniHandleOwnership.DoNotTransfer);
			Intent object3 = Java.Lang.Object.GetObject<Intent>(native_intent, JniHandleOwnership.DoNotTransfer);
			Bundle object4 = Java.Lang.Object.GetObject<Bundle>(native_options, JniHandleOwnership.DoNotTransfer);
			@object.StartActivityFromFragment(object2, object3, requestCode, object4);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002660 File Offset: 0x00000860
		[Register("startActivityFromFragment", "(Landroidx/fragment/app/Fragment;Landroid/content/Intent;ILandroid/os/Bundle;)V", "GetStartActivityFromFragment_Landroidx_fragment_app_Fragment_Landroid_content_Intent_ILandroid_os_Bundle_Handler")]
		public unsafe virtual void StartActivityFromFragment(Fragment fragment, Intent intent, int requestCode, Bundle options)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((fragment == null) ? IntPtr.Zero : fragment.Handle);
				ptr[1] = new JniArgumentValue((intent == null) ? IntPtr.Zero : intent.Handle);
				ptr[2] = new JniArgumentValue(requestCode);
				ptr[3] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				FragmentActivity._members.InstanceMethods.InvokeVirtualVoidMethod("startActivityFromFragment.(Landroidx/fragment/app/Fragment;Landroid/content/Intent;ILandroid/os/Bundle;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(fragment);
				GC.KeepAlive(intent);
				GC.KeepAlive(options);
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002730 File Offset: 0x00000930
		private static Delegate GetStartIntentSenderFromFragment_Landroidx_fragment_app_Fragment_Landroid_content_IntentSender_ILandroid_content_Intent_IIILandroid_os_Bundle_Handler()
		{
			if (FragmentActivity.cb_startIntentSenderFromFragment_Landroidx_fragment_app_Fragment_Landroid_content_IntentSender_ILandroid_content_Intent_IIILandroid_os_Bundle_ == null)
			{
				FragmentActivity.cb_startIntentSenderFromFragment_Landroidx_fragment_app_Fragment_Landroid_content_IntentSender_ILandroid_content_Intent_IIILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLILIIIL_V(FragmentActivity.n_StartIntentSenderFromFragment_Landroidx_fragment_app_Fragment_Landroid_content_IntentSender_ILandroid_content_Intent_IIILandroid_os_Bundle_));
			}
			return FragmentActivity.cb_startIntentSenderFromFragment_Landroidx_fragment_app_Fragment_Landroid_content_IntentSender_ILandroid_content_Intent_IIILandroid_os_Bundle_;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002754 File Offset: 0x00000954
		private static void n_StartIntentSenderFromFragment_Landroidx_fragment_app_Fragment_Landroid_content_IntentSender_ILandroid_content_Intent_IIILandroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_fragment, IntPtr native_intent, int requestCode, IntPtr native_fillInIntent, int flagsMask, int flagsValues, int extraFlags, IntPtr native_options)
		{
			FragmentActivity @object = Java.Lang.Object.GetObject<FragmentActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Fragment object2 = Java.Lang.Object.GetObject<Fragment>(native_fragment, JniHandleOwnership.DoNotTransfer);
			IntentSender object3 = Java.Lang.Object.GetObject<IntentSender>(native_intent, JniHandleOwnership.DoNotTransfer);
			Intent object4 = Java.Lang.Object.GetObject<Intent>(native_fillInIntent, JniHandleOwnership.DoNotTransfer);
			Bundle object5 = Java.Lang.Object.GetObject<Bundle>(native_options, JniHandleOwnership.DoNotTransfer);
			@object.StartIntentSenderFromFragment(object2, object3, requestCode, object4, flagsMask, flagsValues, extraFlags, object5);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000279C File Offset: 0x0000099C
		[Register("startIntentSenderFromFragment", "(Landroidx/fragment/app/Fragment;Landroid/content/IntentSender;ILandroid/content/Intent;IIILandroid/os/Bundle;)V", "GetStartIntentSenderFromFragment_Landroidx_fragment_app_Fragment_Landroid_content_IntentSender_ILandroid_content_Intent_IIILandroid_os_Bundle_Handler")]
		public unsafe virtual void StartIntentSenderFromFragment(Fragment fragment, IntentSender intent, int requestCode, Intent fillInIntent, int flagsMask, int flagsValues, int extraFlags, Bundle options)
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
				FragmentActivity._members.InstanceMethods.InvokeVirtualVoidMethod("startIntentSenderFromFragment.(Landroidx/fragment/app/Fragment;Landroid/content/IntentSender;ILandroid/content/Intent;IIILandroid/os/Bundle;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(fragment);
				GC.KeepAlive(intent);
				GC.KeepAlive(fillInIntent);
				GC.KeepAlive(options);
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000028EC File Offset: 0x00000AEC
		private static Delegate GetSupportFinishAfterTransitionHandler()
		{
			if (FragmentActivity.cb_supportFinishAfterTransition == null)
			{
				FragmentActivity.cb_supportFinishAfterTransition = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(FragmentActivity.n_SupportFinishAfterTransition));
			}
			return FragmentActivity.cb_supportFinishAfterTransition;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002910 File Offset: 0x00000B10
		private static void n_SupportFinishAfterTransition(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<FragmentActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SupportFinishAfterTransition();
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000291F File Offset: 0x00000B1F
		[Register("supportFinishAfterTransition", "()V", "GetSupportFinishAfterTransitionHandler")]
		public virtual void SupportFinishAfterTransition()
		{
			FragmentActivity._members.InstanceMethods.InvokeVirtualVoidMethod("supportFinishAfterTransition.()V", this, null);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00002938 File Offset: 0x00000B38
		private static Delegate GetSupportInvalidateOptionsMenuHandler()
		{
			if (FragmentActivity.cb_supportInvalidateOptionsMenu == null)
			{
				FragmentActivity.cb_supportInvalidateOptionsMenu = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(FragmentActivity.n_SupportInvalidateOptionsMenu));
			}
			return FragmentActivity.cb_supportInvalidateOptionsMenu;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000295C File Offset: 0x00000B5C
		private static void n_SupportInvalidateOptionsMenu(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<FragmentActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SupportInvalidateOptionsMenu();
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000296B File Offset: 0x00000B6B
		[Register("supportInvalidateOptionsMenu", "()V", "GetSupportInvalidateOptionsMenuHandler")]
		public virtual void SupportInvalidateOptionsMenu()
		{
			FragmentActivity._members.InstanceMethods.InvokeVirtualVoidMethod("supportInvalidateOptionsMenu.()V", this, null);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002984 File Offset: 0x00000B84
		private static Delegate GetSupportPostponeEnterTransitionHandler()
		{
			if (FragmentActivity.cb_supportPostponeEnterTransition == null)
			{
				FragmentActivity.cb_supportPostponeEnterTransition = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(FragmentActivity.n_SupportPostponeEnterTransition));
			}
			return FragmentActivity.cb_supportPostponeEnterTransition;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000029A8 File Offset: 0x00000BA8
		private static void n_SupportPostponeEnterTransition(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<FragmentActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SupportPostponeEnterTransition();
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000029B7 File Offset: 0x00000BB7
		[Register("supportPostponeEnterTransition", "()V", "GetSupportPostponeEnterTransitionHandler")]
		public virtual void SupportPostponeEnterTransition()
		{
			FragmentActivity._members.InstanceMethods.InvokeVirtualVoidMethod("supportPostponeEnterTransition.()V", this, null);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000029D0 File Offset: 0x00000BD0
		private static Delegate GetSupportStartPostponedEnterTransitionHandler()
		{
			if (FragmentActivity.cb_supportStartPostponedEnterTransition == null)
			{
				FragmentActivity.cb_supportStartPostponedEnterTransition = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(FragmentActivity.n_SupportStartPostponedEnterTransition));
			}
			return FragmentActivity.cb_supportStartPostponedEnterTransition;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000029F4 File Offset: 0x00000BF4
		private static void n_SupportStartPostponedEnterTransition(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<FragmentActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SupportStartPostponedEnterTransition();
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002A03 File Offset: 0x00000C03
		[Register("supportStartPostponedEnterTransition", "()V", "GetSupportStartPostponedEnterTransitionHandler")]
		public virtual void SupportStartPostponedEnterTransition()
		{
			FragmentActivity._members.InstanceMethods.InvokeVirtualVoidMethod("supportStartPostponedEnterTransition.()V", this, null);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002A1C File Offset: 0x00000C1C
		[Register("validateRequestPermissionsRequestCode", "(I)V", "")]
		public unsafe void ValidateRequestPermissionsRequestCode(int requestCode)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(requestCode);
			FragmentActivity._members.InstanceMethods.InvokeNonvirtualVoidMethod("validateRequestPermissionsRequestCode.(I)V", this, ptr);
		}

		// Token: 0x04000003 RID: 3
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/fragment/app/FragmentActivity", typeof(FragmentActivity));

		// Token: 0x04000004 RID: 4
		private static Delegate cb_getSupportFragmentManager;

		// Token: 0x04000005 RID: 5
		private static Delegate cb_getSupportLoaderManager;

		// Token: 0x04000006 RID: 6
		private static Delegate cb_onAttachFragment_Landroidx_fragment_app_Fragment_;

		// Token: 0x04000007 RID: 7
		private static Delegate cb_onResumeFragments;

		// Token: 0x04000008 RID: 8
		private static Delegate cb_setEnterSharedElementCallback_Landroidx_core_app_SharedElementCallback_;

		// Token: 0x04000009 RID: 9
		private static Delegate cb_setExitSharedElementCallback_Landroidx_core_app_SharedElementCallback_;

		// Token: 0x0400000A RID: 10
		private static Delegate cb_startActivityFromFragment_Landroidx_fragment_app_Fragment_Landroid_content_Intent_I;

		// Token: 0x0400000B RID: 11
		private static Delegate cb_startActivityFromFragment_Landroidx_fragment_app_Fragment_Landroid_content_Intent_ILandroid_os_Bundle_;

		// Token: 0x0400000C RID: 12
		private static Delegate cb_startIntentSenderFromFragment_Landroidx_fragment_app_Fragment_Landroid_content_IntentSender_ILandroid_content_Intent_IIILandroid_os_Bundle_;

		// Token: 0x0400000D RID: 13
		private static Delegate cb_supportFinishAfterTransition;

		// Token: 0x0400000E RID: 14
		private static Delegate cb_supportInvalidateOptionsMenu;

		// Token: 0x0400000F RID: 15
		private static Delegate cb_supportPostponeEnterTransition;

		// Token: 0x04000010 RID: 16
		private static Delegate cb_supportStartPostponedEnterTransition;
	}
}
