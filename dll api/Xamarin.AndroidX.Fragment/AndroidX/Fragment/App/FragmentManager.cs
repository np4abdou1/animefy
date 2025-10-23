using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using AndroidX.Fragment.App.StrictMode;
using AndroidX.Lifecycle;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace AndroidX.Fragment.App
{
	// Token: 0x02000030 RID: 48
	[Register("androidx/fragment/app/FragmentManager", DoNotGenerateAcw = true)]
	public abstract class FragmentManager : Java.Lang.Object, IFragmentResultOwner, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600028A RID: 650 RVA: 0x00008660 File Offset: 0x00006860
		internal static IntPtr class_ref
		{
			get
			{
				return FragmentManager._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600028B RID: 651 RVA: 0x00008684 File Offset: 0x00006884
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FragmentManager._members;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600028C RID: 652 RVA: 0x0000868C File Offset: 0x0000688C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return FragmentManager._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600028D RID: 653 RVA: 0x000086B0 File Offset: 0x000068B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FragmentManager._members.ManagedPeerType;
			}
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00003624 File Offset: 0x00001824
		protected FragmentManager(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600028F RID: 655 RVA: 0x000086BC File Offset: 0x000068BC
		[Register(".ctor", "()V", "")]
		public FragmentManager() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(FragmentManager._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			FragmentManager._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0000872A File Offset: 0x0000692A
		private static Delegate GetGetBackStackEntryCountHandler()
		{
			if (FragmentManager.cb_getBackStackEntryCount == null)
			{
				FragmentManager.cb_getBackStackEntryCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(FragmentManager.n_GetBackStackEntryCount));
			}
			return FragmentManager.cb_getBackStackEntryCount;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0000874E File Offset: 0x0000694E
		private static int n_GetBackStackEntryCount(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<FragmentManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BackStackEntryCount;
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000292 RID: 658 RVA: 0x0000875D File Offset: 0x0000695D
		public virtual int BackStackEntryCount
		{
			[Register("getBackStackEntryCount", "()I", "GetGetBackStackEntryCountHandler")]
			get
			{
				return FragmentManager._members.InstanceMethods.InvokeVirtualInt32Method("getBackStackEntryCount.()I", this, null);
			}
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00008776 File Offset: 0x00006976
		private static Delegate GetGetFragmentFactoryHandler()
		{
			if (FragmentManager.cb_getFragmentFactory == null)
			{
				FragmentManager.cb_getFragmentFactory = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(FragmentManager.n_GetFragmentFactory));
			}
			return FragmentManager.cb_getFragmentFactory;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0000879A File Offset: 0x0000699A
		private static IntPtr n_GetFragmentFactory(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<FragmentManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FragmentFactory);
		}

		// Token: 0x06000295 RID: 661 RVA: 0x000087AE File Offset: 0x000069AE
		private static Delegate GetSetFragmentFactory_Landroidx_fragment_app_FragmentFactory_Handler()
		{
			if (FragmentManager.cb_setFragmentFactory_Landroidx_fragment_app_FragmentFactory_ == null)
			{
				FragmentManager.cb_setFragmentFactory_Landroidx_fragment_app_FragmentFactory_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(FragmentManager.n_SetFragmentFactory_Landroidx_fragment_app_FragmentFactory_));
			}
			return FragmentManager.cb_setFragmentFactory_Landroidx_fragment_app_FragmentFactory_;
		}

		// Token: 0x06000296 RID: 662 RVA: 0x000087D4 File Offset: 0x000069D4
		private static void n_SetFragmentFactory_Landroidx_fragment_app_FragmentFactory_(IntPtr jnienv, IntPtr native__this, IntPtr native_fragmentFactory)
		{
			FragmentManager @object = Java.Lang.Object.GetObject<FragmentManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			FragmentFactory object2 = Java.Lang.Object.GetObject<FragmentFactory>(native_fragmentFactory, JniHandleOwnership.DoNotTransfer);
			@object.FragmentFactory = object2;
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000297 RID: 663 RVA: 0x000087F8 File Offset: 0x000069F8
		// (set) Token: 0x06000298 RID: 664 RVA: 0x0000882C File Offset: 0x00006A2C
		public unsafe virtual FragmentFactory FragmentFactory
		{
			[Register("getFragmentFactory", "()Landroidx/fragment/app/FragmentFactory;", "GetGetFragmentFactoryHandler")]
			get
			{
				return Java.Lang.Object.GetObject<FragmentFactory>(FragmentManager._members.InstanceMethods.InvokeVirtualObjectMethod("getFragmentFactory.()Landroidx/fragment/app/FragmentFactory;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setFragmentFactory", "(Landroidx/fragment/app/FragmentFactory;)V", "GetSetFragmentFactory_Landroidx_fragment_app_FragmentFactory_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					FragmentManager._members.InstanceMethods.InvokeVirtualVoidMethod("setFragmentFactory.(Landroidx/fragment/app/FragmentFactory;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00008890 File Offset: 0x00006A90
		private static Delegate GetGetFragmentsHandler()
		{
			if (FragmentManager.cb_getFragments == null)
			{
				FragmentManager.cb_getFragments = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(FragmentManager.n_GetFragments));
			}
			return FragmentManager.cb_getFragments;
		}

		// Token: 0x0600029A RID: 666 RVA: 0x000088B4 File Offset: 0x00006AB4
		private static IntPtr n_GetFragments(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<Fragment>.ToLocalJniHandle(Java.Lang.Object.GetObject<FragmentManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Fragments);
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600029B RID: 667 RVA: 0x000088C8 File Offset: 0x00006AC8
		public virtual IList<Fragment> Fragments
		{
			[Register("getFragments", "()Ljava/util/List;", "GetGetFragmentsHandler")]
			get
			{
				return JavaList<Fragment>.FromJniHandle(FragmentManager._members.InstanceMethods.InvokeVirtualObjectMethod("getFragments.()Ljava/util/List;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600029C RID: 668 RVA: 0x000088FA File Offset: 0x00006AFA
		private static Delegate GetGetHostHandler()
		{
			if (FragmentManager.cb_getHost == null)
			{
				FragmentManager.cb_getHost = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(FragmentManager.n_GetHost));
			}
			return FragmentManager.cb_getHost;
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0000891E File Offset: 0x00006B1E
		private static IntPtr n_GetHost(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<FragmentManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Host);
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600029E RID: 670 RVA: 0x00008934 File Offset: 0x00006B34
		public virtual FragmentHostCallback Host
		{
			[Register("getHost", "()Landroidx/fragment/app/FragmentHostCallback;", "GetGetHostHandler")]
			get
			{
				return Java.Lang.Object.GetObject<FragmentHostCallback>(FragmentManager._members.InstanceMethods.InvokeVirtualObjectMethod("getHost.()Landroidx/fragment/app/FragmentHostCallback;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00008966 File Offset: 0x00006B66
		private static Delegate GetIsDestroyedHandler()
		{
			if (FragmentManager.cb_isDestroyed == null)
			{
				FragmentManager.cb_isDestroyed = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(FragmentManager.n_IsDestroyed));
			}
			return FragmentManager.cb_isDestroyed;
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0000898A File Offset: 0x00006B8A
		private static bool n_IsDestroyed(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<FragmentManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsDestroyed;
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x00008999 File Offset: 0x00006B99
		public virtual bool IsDestroyed
		{
			[Register("isDestroyed", "()Z", "GetIsDestroyedHandler")]
			get
			{
				return FragmentManager._members.InstanceMethods.InvokeVirtualBooleanMethod("isDestroyed.()Z", this, null);
			}
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x000089B2 File Offset: 0x00006BB2
		private static Delegate GetIsStateSavedHandler()
		{
			if (FragmentManager.cb_isStateSaved == null)
			{
				FragmentManager.cb_isStateSaved = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(FragmentManager.n_IsStateSaved));
			}
			return FragmentManager.cb_isStateSaved;
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x000089D6 File Offset: 0x00006BD6
		private static bool n_IsStateSaved(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<FragmentManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsStateSaved;
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x000089E5 File Offset: 0x00006BE5
		public virtual bool IsStateSaved
		{
			[Register("isStateSaved", "()Z", "GetIsStateSavedHandler")]
			get
			{
				return FragmentManager._members.InstanceMethods.InvokeVirtualBooleanMethod("isStateSaved.()Z", this, null);
			}
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x000089FE File Offset: 0x00006BFE
		private static Delegate GetGetPrimaryNavigationFragmentHandler()
		{
			if (FragmentManager.cb_getPrimaryNavigationFragment == null)
			{
				FragmentManager.cb_getPrimaryNavigationFragment = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(FragmentManager.n_GetPrimaryNavigationFragment));
			}
			return FragmentManager.cb_getPrimaryNavigationFragment;
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00008A22 File Offset: 0x00006C22
		private static IntPtr n_GetPrimaryNavigationFragment(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<FragmentManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PrimaryNavigationFragment);
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x00008A38 File Offset: 0x00006C38
		public virtual Fragment PrimaryNavigationFragment
		{
			[Register("getPrimaryNavigationFragment", "()Landroidx/fragment/app/Fragment;", "GetGetPrimaryNavigationFragmentHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Fragment>(FragmentManager._members.InstanceMethods.InvokeVirtualObjectMethod("getPrimaryNavigationFragment.()Landroidx/fragment/app/Fragment;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00008A6A File Offset: 0x00006C6A
		private static Delegate GetGetStrictModePolicyHandler()
		{
			if (FragmentManager.cb_getStrictModePolicy == null)
			{
				FragmentManager.cb_getStrictModePolicy = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(FragmentManager.n_GetStrictModePolicy));
			}
			return FragmentManager.cb_getStrictModePolicy;
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00008A8E File Offset: 0x00006C8E
		private static IntPtr n_GetStrictModePolicy(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<FragmentManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StrictModePolicy);
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00008AA2 File Offset: 0x00006CA2
		private static Delegate GetSetStrictModePolicy_Landroidx_fragment_app_strictmode_FragmentStrictMode_Policy_Handler()
		{
			if (FragmentManager.cb_setStrictModePolicy_Landroidx_fragment_app_strictmode_FragmentStrictMode_Policy_ == null)
			{
				FragmentManager.cb_setStrictModePolicy_Landroidx_fragment_app_strictmode_FragmentStrictMode_Policy_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(FragmentManager.n_SetStrictModePolicy_Landroidx_fragment_app_strictmode_FragmentStrictMode_Policy_));
			}
			return FragmentManager.cb_setStrictModePolicy_Landroidx_fragment_app_strictmode_FragmentStrictMode_Policy_;
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00008AC8 File Offset: 0x00006CC8
		private static void n_SetStrictModePolicy_Landroidx_fragment_app_strictmode_FragmentStrictMode_Policy_(IntPtr jnienv, IntPtr native__this, IntPtr native_policy)
		{
			FragmentManager @object = Java.Lang.Object.GetObject<FragmentManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			FragmentStrictMode.Policy object2 = Java.Lang.Object.GetObject<FragmentStrictMode.Policy>(native_policy, JniHandleOwnership.DoNotTransfer);
			@object.StrictModePolicy = object2;
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060002AC RID: 684 RVA: 0x00008AEC File Offset: 0x00006CEC
		// (set) Token: 0x060002AD RID: 685 RVA: 0x00008B20 File Offset: 0x00006D20
		public unsafe virtual FragmentStrictMode.Policy StrictModePolicy
		{
			[Register("getStrictModePolicy", "()Landroidx/fragment/app/strictmode/FragmentStrictMode$Policy;", "GetGetStrictModePolicyHandler")]
			get
			{
				return Java.Lang.Object.GetObject<FragmentStrictMode.Policy>(FragmentManager._members.InstanceMethods.InvokeVirtualObjectMethod("getStrictModePolicy.()Landroidx/fragment/app/strictmode/FragmentStrictMode$Policy;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setStrictModePolicy", "(Landroidx/fragment/app/strictmode/FragmentStrictMode$Policy;)V", "GetSetStrictModePolicy_Landroidx_fragment_app_strictmode_FragmentStrictMode_Policy_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					FragmentManager._members.InstanceMethods.InvokeVirtualVoidMethod("setStrictModePolicy.(Landroidx/fragment/app/strictmode/FragmentStrictMode$Policy;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00008B84 File Offset: 0x00006D84
		private static Delegate GetAddFragmentOnAttachListener_Landroidx_fragment_app_FragmentOnAttachListener_Handler()
		{
			if (FragmentManager.cb_addFragmentOnAttachListener_Landroidx_fragment_app_FragmentOnAttachListener_ == null)
			{
				FragmentManager.cb_addFragmentOnAttachListener_Landroidx_fragment_app_FragmentOnAttachListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(FragmentManager.n_AddFragmentOnAttachListener_Landroidx_fragment_app_FragmentOnAttachListener_));
			}
			return FragmentManager.cb_addFragmentOnAttachListener_Landroidx_fragment_app_FragmentOnAttachListener_;
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00008BA8 File Offset: 0x00006DA8
		private static void n_AddFragmentOnAttachListener_Landroidx_fragment_app_FragmentOnAttachListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			FragmentManager @object = Java.Lang.Object.GetObject<FragmentManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IFragmentOnAttachListener object2 = Java.Lang.Object.GetObject<IFragmentOnAttachListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.AddFragmentOnAttachListener(object2);
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00008BCC File Offset: 0x00006DCC
		[Register("addFragmentOnAttachListener", "(Landroidx/fragment/app/FragmentOnAttachListener;)V", "GetAddFragmentOnAttachListener_Landroidx_fragment_app_FragmentOnAttachListener_Handler")]
		public unsafe virtual void AddFragmentOnAttachListener(IFragmentOnAttachListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				FragmentManager._members.InstanceMethods.InvokeVirtualVoidMethod("addFragmentOnAttachListener.(Landroidx/fragment/app/FragmentOnAttachListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00008C34 File Offset: 0x00006E34
		private static Delegate GetAddOnBackStackChangedListener_Landroidx_fragment_app_FragmentManager_OnBackStackChangedListener_Handler()
		{
			if (FragmentManager.cb_addOnBackStackChangedListener_Landroidx_fragment_app_FragmentManager_OnBackStackChangedListener_ == null)
			{
				FragmentManager.cb_addOnBackStackChangedListener_Landroidx_fragment_app_FragmentManager_OnBackStackChangedListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(FragmentManager.n_AddOnBackStackChangedListener_Landroidx_fragment_app_FragmentManager_OnBackStackChangedListener_));
			}
			return FragmentManager.cb_addOnBackStackChangedListener_Landroidx_fragment_app_FragmentManager_OnBackStackChangedListener_;
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00008C58 File Offset: 0x00006E58
		private static void n_AddOnBackStackChangedListener_Landroidx_fragment_app_FragmentManager_OnBackStackChangedListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			FragmentManager @object = Java.Lang.Object.GetObject<FragmentManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			FragmentManager.IOnBackStackChangedListener object2 = Java.Lang.Object.GetObject<FragmentManager.IOnBackStackChangedListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.AddOnBackStackChangedListener(object2);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00008C7C File Offset: 0x00006E7C
		[Register("addOnBackStackChangedListener", "(Landroidx/fragment/app/FragmentManager$OnBackStackChangedListener;)V", "GetAddOnBackStackChangedListener_Landroidx_fragment_app_FragmentManager_OnBackStackChangedListener_Handler")]
		public unsafe virtual void AddOnBackStackChangedListener(FragmentManager.IOnBackStackChangedListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				FragmentManager._members.InstanceMethods.InvokeVirtualVoidMethod("addOnBackStackChangedListener.(Landroidx/fragment/app/FragmentManager$OnBackStackChangedListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00008CE4 File Offset: 0x00006EE4
		private static Delegate GetBeginTransactionHandler()
		{
			if (FragmentManager.cb_beginTransaction == null)
			{
				FragmentManager.cb_beginTransaction = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(FragmentManager.n_BeginTransaction));
			}
			return FragmentManager.cb_beginTransaction;
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00008D08 File Offset: 0x00006F08
		private static IntPtr n_BeginTransaction(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<FragmentManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BeginTransaction());
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00008D1C File Offset: 0x00006F1C
		[Register("beginTransaction", "()Landroidx/fragment/app/FragmentTransaction;", "GetBeginTransactionHandler")]
		public virtual FragmentTransaction BeginTransaction()
		{
			return Java.Lang.Object.GetObject<FragmentTransaction>(FragmentManager._members.InstanceMethods.InvokeVirtualObjectMethod("beginTransaction.()Landroidx/fragment/app/FragmentTransaction;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00008D4E File Offset: 0x00006F4E
		private static Delegate GetClearBackStack_Ljava_lang_String_Handler()
		{
			if (FragmentManager.cb_clearBackStack_Ljava_lang_String_ == null)
			{
				FragmentManager.cb_clearBackStack_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(FragmentManager.n_ClearBackStack_Ljava_lang_String_));
			}
			return FragmentManager.cb_clearBackStack_Ljava_lang_String_;
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00008D74 File Offset: 0x00006F74
		private static void n_ClearBackStack_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			FragmentManager @object = Java.Lang.Object.GetObject<FragmentManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_name, JniHandleOwnership.DoNotTransfer);
			@object.ClearBackStack(@string);
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00008D98 File Offset: 0x00006F98
		[Register("clearBackStack", "(Ljava/lang/String;)V", "GetClearBackStack_Ljava_lang_String_Handler")]
		public unsafe virtual void ClearBackStack(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				FragmentManager._members.InstanceMethods.InvokeVirtualVoidMethod("clearBackStack.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00008DF4 File Offset: 0x00006FF4
		[Register("clearFragmentResult", "(Ljava/lang/String;)V", "")]
		public unsafe void ClearFragmentResult(string requestKey)
		{
			IntPtr intPtr = JNIEnv.NewString(requestKey);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				FragmentManager._members.InstanceMethods.InvokeNonvirtualVoidMethod("clearFragmentResult.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00008E50 File Offset: 0x00007050
		[Register("clearFragmentResultListener", "(Ljava/lang/String;)V", "")]
		public unsafe void ClearFragmentResultListener(string requestKey)
		{
			IntPtr intPtr = JNIEnv.NewString(requestKey);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				FragmentManager._members.InstanceMethods.InvokeNonvirtualVoidMethod("clearFragmentResultListener.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00008EAC File Offset: 0x000070AC
		private static Delegate GetDump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_Handler()
		{
			if (FragmentManager.cb_dump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_ == null)
			{
				FragmentManager.cb_dump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLL_V(FragmentManager.n_Dump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_));
			}
			return FragmentManager.cb_dump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_;
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00008ED0 File Offset: 0x000070D0
		private static void n_Dump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_prefix, IntPtr native_fd, IntPtr native_writer, IntPtr native_args)
		{
			FragmentManager @object = Java.Lang.Object.GetObject<FragmentManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_prefix, JniHandleOwnership.DoNotTransfer);
			FileDescriptor object2 = Java.Lang.Object.GetObject<FileDescriptor>(native_fd, JniHandleOwnership.DoNotTransfer);
			PrintWriter object3 = Java.Lang.Object.GetObject<PrintWriter>(native_writer, JniHandleOwnership.DoNotTransfer);
			string[] array = (string[])JNIEnv.GetArray(native_args, JniHandleOwnership.DoNotTransfer, typeof(string));
			@object.Dump(@string, object2, object3, array);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_args);
			}
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00008F2C File Offset: 0x0000712C
		[Register("dump", "(Ljava/lang/String;Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V", "GetDump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_Handler")]
		public unsafe virtual void Dump(string prefix, FileDescriptor fd, PrintWriter writer, string[] args)
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
				FragmentManager._members.InstanceMethods.InvokeVirtualVoidMethod("dump.(Ljava/lang/String;Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V", this, ptr);
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

		// Token: 0x060002BF RID: 703 RVA: 0x00009014 File Offset: 0x00007214
		[Register("enableDebugLogging", "(Z)V", "")]
		public unsafe static void EnableDebugLogging(bool enabled)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(enabled);
			FragmentManager._members.StaticMethods.InvokeVoidMethod("enableDebugLogging.(Z)V", ptr);
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x0000904E File Offset: 0x0000724E
		private static Delegate GetExecutePendingTransactionsHandler()
		{
			if (FragmentManager.cb_executePendingTransactions == null)
			{
				FragmentManager.cb_executePendingTransactions = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(FragmentManager.n_ExecutePendingTransactions));
			}
			return FragmentManager.cb_executePendingTransactions;
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00009072 File Offset: 0x00007272
		private static bool n_ExecutePendingTransactions(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<FragmentManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ExecutePendingTransactions();
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00009081 File Offset: 0x00007281
		[Register("executePendingTransactions", "()Z", "GetExecutePendingTransactionsHandler")]
		public virtual bool ExecutePendingTransactions()
		{
			return FragmentManager._members.InstanceMethods.InvokeVirtualBooleanMethod("executePendingTransactions.()Z", this, null);
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0000909C File Offset: 0x0000729C
		[Register("findFragment", "(Landroid/view/View;)Landroidx/fragment/app/Fragment;", "")]
		[JavaTypeParameters(new string[]
		{
			"F extends androidx.fragment.app.Fragment"
		})]
		public unsafe static Java.Lang.Object FindFragment(View view)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(FragmentManager._members.StaticMethods.InvokeObjectMethod("findFragment.(Landroid/view/View;)Landroidx/fragment/app/Fragment;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(view);
			}
			return @object;
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00009110 File Offset: 0x00007310
		private static Delegate GetFindFragmentById_IHandler()
		{
			if (FragmentManager.cb_findFragmentById_I == null)
			{
				FragmentManager.cb_findFragmentById_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(FragmentManager.n_FindFragmentById_I));
			}
			return FragmentManager.cb_findFragmentById_I;
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00009134 File Offset: 0x00007334
		private static IntPtr n_FindFragmentById_I(IntPtr jnienv, IntPtr native__this, int id)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<FragmentManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FindFragmentById(id));
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0000914C File Offset: 0x0000734C
		[Register("findFragmentById", "(I)Landroidx/fragment/app/Fragment;", "GetFindFragmentById_IHandler")]
		public unsafe virtual Fragment FindFragmentById(int id)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(id);
			return Java.Lang.Object.GetObject<Fragment>(FragmentManager._members.InstanceMethods.InvokeVirtualObjectMethod("findFragmentById.(I)Landroidx/fragment/app/Fragment;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00009195 File Offset: 0x00007395
		private static Delegate GetFindFragmentByTag_Ljava_lang_String_Handler()
		{
			if (FragmentManager.cb_findFragmentByTag_Ljava_lang_String_ == null)
			{
				FragmentManager.cb_findFragmentByTag_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(FragmentManager.n_FindFragmentByTag_Ljava_lang_String_));
			}
			return FragmentManager.cb_findFragmentByTag_Ljava_lang_String_;
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x000091BC File Offset: 0x000073BC
		private static IntPtr n_FindFragmentByTag_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_tag)
		{
			FragmentManager @object = Java.Lang.Object.GetObject<FragmentManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_tag, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.FindFragmentByTag(@string));
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x000091E4 File Offset: 0x000073E4
		[Register("findFragmentByTag", "(Ljava/lang/String;)Landroidx/fragment/app/Fragment;", "GetFindFragmentByTag_Ljava_lang_String_Handler")]
		public unsafe virtual Fragment FindFragmentByTag(string tag)
		{
			IntPtr intPtr = JNIEnv.NewString(tag);
			Fragment @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Fragment>(FragmentManager._members.InstanceMethods.InvokeVirtualObjectMethod("findFragmentByTag.(Ljava/lang/String;)Landroidx/fragment/app/Fragment;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00009250 File Offset: 0x00007450
		private static Delegate GetGetBackStackEntryAt_IHandler()
		{
			if (FragmentManager.cb_getBackStackEntryAt_I == null)
			{
				FragmentManager.cb_getBackStackEntryAt_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(FragmentManager.n_GetBackStackEntryAt_I));
			}
			return FragmentManager.cb_getBackStackEntryAt_I;
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00009274 File Offset: 0x00007474
		private static IntPtr n_GetBackStackEntryAt_I(IntPtr jnienv, IntPtr native__this, int index)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<FragmentManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetBackStackEntryAt(index));
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0000928C File Offset: 0x0000748C
		[Register("getBackStackEntryAt", "(I)Landroidx/fragment/app/FragmentManager$BackStackEntry;", "GetGetBackStackEntryAt_IHandler")]
		public unsafe virtual FragmentManager.IBackStackEntry GetBackStackEntryAt(int index)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(index);
			return Java.Lang.Object.GetObject<FragmentManager.IBackStackEntry>(FragmentManager._members.InstanceMethods.InvokeVirtualObjectMethod("getBackStackEntryAt.(I)Landroidx/fragment/app/FragmentManager$BackStackEntry;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002CD RID: 717 RVA: 0x000092D5 File Offset: 0x000074D5
		private static Delegate GetGetFragment_Landroid_os_Bundle_Ljava_lang_String_Handler()
		{
			if (FragmentManager.cb_getFragment_Landroid_os_Bundle_Ljava_lang_String_ == null)
			{
				FragmentManager.cb_getFragment_Landroid_os_Bundle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(FragmentManager.n_GetFragment_Landroid_os_Bundle_Ljava_lang_String_));
			}
			return FragmentManager.cb_getFragment_Landroid_os_Bundle_Ljava_lang_String_;
		}

		// Token: 0x060002CE RID: 718 RVA: 0x000092FC File Offset: 0x000074FC
		private static IntPtr n_GetFragment_Landroid_os_Bundle_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_bundle, IntPtr native_key)
		{
			FragmentManager @object = Java.Lang.Object.GetObject<FragmentManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_bundle, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetFragment(object2, @string));
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00009330 File Offset: 0x00007530
		[Register("getFragment", "(Landroid/os/Bundle;Ljava/lang/String;)Landroidx/fragment/app/Fragment;", "GetGetFragment_Landroid_os_Bundle_Ljava_lang_String_Handler")]
		public unsafe virtual Fragment GetFragment(Bundle bundle, string key)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			Fragment @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((bundle == null) ? IntPtr.Zero : bundle.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Fragment>(FragmentManager._members.InstanceMethods.InvokeVirtualObjectMethod("getFragment.(Landroid/os/Bundle;Ljava/lang/String;)Landroidx/fragment/app/Fragment;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(bundle);
			}
			return @object;
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x000093C4 File Offset: 0x000075C4
		[Register("isLoggingEnabled", "(I)Z", "")]
		public unsafe static bool IsLoggingEnabled(int level)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(level);
			return FragmentManager._members.StaticMethods.InvokeBooleanMethod("isLoggingEnabled.(I)Z", ptr);
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x000093FE File Offset: 0x000075FE
		private static Delegate GetOpenTransactionHandler()
		{
			if (FragmentManager.cb_openTransaction == null)
			{
				FragmentManager.cb_openTransaction = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(FragmentManager.n_OpenTransaction));
			}
			return FragmentManager.cb_openTransaction;
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00009422 File Offset: 0x00007622
		private static IntPtr n_OpenTransaction(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<FragmentManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OpenTransaction());
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00009438 File Offset: 0x00007638
		[Register("openTransaction", "()Landroidx/fragment/app/FragmentTransaction;", "GetOpenTransactionHandler")]
		public virtual FragmentTransaction OpenTransaction()
		{
			return Java.Lang.Object.GetObject<FragmentTransaction>(FragmentManager._members.InstanceMethods.InvokeVirtualObjectMethod("openTransaction.()Landroidx/fragment/app/FragmentTransaction;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0000946A File Offset: 0x0000766A
		private static Delegate GetPopBackStackHandler()
		{
			if (FragmentManager.cb_popBackStack == null)
			{
				FragmentManager.cb_popBackStack = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(FragmentManager.n_PopBackStack));
			}
			return FragmentManager.cb_popBackStack;
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0000948E File Offset: 0x0000768E
		private static void n_PopBackStack(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<FragmentManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PopBackStack();
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0000949D File Offset: 0x0000769D
		[Register("popBackStack", "()V", "GetPopBackStackHandler")]
		public virtual void PopBackStack()
		{
			FragmentManager._members.InstanceMethods.InvokeVirtualVoidMethod("popBackStack.()V", this, null);
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x000094B6 File Offset: 0x000076B6
		private static Delegate GetPopBackStack_IIHandler()
		{
			if (FragmentManager.cb_popBackStack_II == null)
			{
				FragmentManager.cb_popBackStack_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_V(FragmentManager.n_PopBackStack_II));
			}
			return FragmentManager.cb_popBackStack_II;
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x000094DA File Offset: 0x000076DA
		private static void n_PopBackStack_II(IntPtr jnienv, IntPtr native__this, int id, int flags)
		{
			Java.Lang.Object.GetObject<FragmentManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PopBackStack(id, flags);
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x000094EC File Offset: 0x000076EC
		[Register("popBackStack", "(II)V", "GetPopBackStack_IIHandler")]
		public unsafe virtual void PopBackStack(int id, int flags)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(id);
			ptr[1] = new JniArgumentValue(flags);
			FragmentManager._members.InstanceMethods.InvokeVirtualVoidMethod("popBackStack.(II)V", this, ptr);
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0000953A File Offset: 0x0000773A
		private static Delegate GetPopBackStack_Ljava_lang_String_IHandler()
		{
			if (FragmentManager.cb_popBackStack_Ljava_lang_String_I == null)
			{
				FragmentManager.cb_popBackStack_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(FragmentManager.n_PopBackStack_Ljava_lang_String_I));
			}
			return FragmentManager.cb_popBackStack_Ljava_lang_String_I;
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00009560 File Offset: 0x00007760
		private static void n_PopBackStack_Ljava_lang_String_I(IntPtr jnienv, IntPtr native__this, IntPtr native_name, int flags)
		{
			FragmentManager @object = Java.Lang.Object.GetObject<FragmentManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_name, JniHandleOwnership.DoNotTransfer);
			@object.PopBackStack(@string, flags);
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00009584 File Offset: 0x00007784
		[Register("popBackStack", "(Ljava/lang/String;I)V", "GetPopBackStack_Ljava_lang_String_IHandler")]
		public unsafe virtual void PopBackStack(string name, int flags)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(flags);
				FragmentManager._members.InstanceMethods.InvokeVirtualVoidMethod("popBackStack.(Ljava/lang/String;I)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060002DD RID: 733 RVA: 0x000095F4 File Offset: 0x000077F4
		private static Delegate GetPopBackStackImmediateHandler()
		{
			if (FragmentManager.cb_popBackStackImmediate == null)
			{
				FragmentManager.cb_popBackStackImmediate = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(FragmentManager.n_PopBackStackImmediate));
			}
			return FragmentManager.cb_popBackStackImmediate;
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00009618 File Offset: 0x00007818
		private static bool n_PopBackStackImmediate(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<FragmentManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PopBackStackImmediate();
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00009627 File Offset: 0x00007827
		[Register("popBackStackImmediate", "()Z", "GetPopBackStackImmediateHandler")]
		public virtual bool PopBackStackImmediate()
		{
			return FragmentManager._members.InstanceMethods.InvokeVirtualBooleanMethod("popBackStackImmediate.()Z", this, null);
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00009640 File Offset: 0x00007840
		private static Delegate GetPopBackStackImmediate_IIHandler()
		{
			if (FragmentManager.cb_popBackStackImmediate_II == null)
			{
				FragmentManager.cb_popBackStackImmediate_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_Z(FragmentManager.n_PopBackStackImmediate_II));
			}
			return FragmentManager.cb_popBackStackImmediate_II;
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00009664 File Offset: 0x00007864
		private static bool n_PopBackStackImmediate_II(IntPtr jnienv, IntPtr native__this, int id, int flags)
		{
			return Java.Lang.Object.GetObject<FragmentManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PopBackStackImmediate(id, flags);
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00009678 File Offset: 0x00007878
		[Register("popBackStackImmediate", "(II)Z", "GetPopBackStackImmediate_IIHandler")]
		public unsafe virtual bool PopBackStackImmediate(int id, int flags)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(id);
			ptr[1] = new JniArgumentValue(flags);
			return FragmentManager._members.InstanceMethods.InvokeVirtualBooleanMethod("popBackStackImmediate.(II)Z", this, ptr);
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x000096C6 File Offset: 0x000078C6
		private static Delegate GetPopBackStackImmediate_Ljava_lang_String_IHandler()
		{
			if (FragmentManager.cb_popBackStackImmediate_Ljava_lang_String_I == null)
			{
				FragmentManager.cb_popBackStackImmediate_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_Z(FragmentManager.n_PopBackStackImmediate_Ljava_lang_String_I));
			}
			return FragmentManager.cb_popBackStackImmediate_Ljava_lang_String_I;
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x000096EC File Offset: 0x000078EC
		private static bool n_PopBackStackImmediate_Ljava_lang_String_I(IntPtr jnienv, IntPtr native__this, IntPtr native_name, int flags)
		{
			FragmentManager @object = Java.Lang.Object.GetObject<FragmentManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_name, JniHandleOwnership.DoNotTransfer);
			return @object.PopBackStackImmediate(@string, flags);
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00009710 File Offset: 0x00007910
		[Register("popBackStackImmediate", "(Ljava/lang/String;I)Z", "GetPopBackStackImmediate_Ljava_lang_String_IHandler")]
		public unsafe virtual bool PopBackStackImmediate(string name, int flags)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(flags);
				result = FragmentManager._members.InstanceMethods.InvokeVirtualBooleanMethod("popBackStackImmediate.(Ljava/lang/String;I)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00009780 File Offset: 0x00007980
		private static Delegate GetPutFragment_Landroid_os_Bundle_Ljava_lang_String_Landroidx_fragment_app_Fragment_Handler()
		{
			if (FragmentManager.cb_putFragment_Landroid_os_Bundle_Ljava_lang_String_Landroidx_fragment_app_Fragment_ == null)
			{
				FragmentManager.cb_putFragment_Landroid_os_Bundle_Ljava_lang_String_Landroidx_fragment_app_Fragment_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(FragmentManager.n_PutFragment_Landroid_os_Bundle_Ljava_lang_String_Landroidx_fragment_app_Fragment_));
			}
			return FragmentManager.cb_putFragment_Landroid_os_Bundle_Ljava_lang_String_Landroidx_fragment_app_Fragment_;
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x000097A4 File Offset: 0x000079A4
		private static void n_PutFragment_Landroid_os_Bundle_Ljava_lang_String_Landroidx_fragment_app_Fragment_(IntPtr jnienv, IntPtr native__this, IntPtr native_bundle, IntPtr native_key, IntPtr native_fragment)
		{
			FragmentManager @object = Java.Lang.Object.GetObject<FragmentManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_bundle, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
			Fragment object3 = Java.Lang.Object.GetObject<Fragment>(native_fragment, JniHandleOwnership.DoNotTransfer);
			@object.PutFragment(object2, @string, object3);
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x000097DC File Offset: 0x000079DC
		[Register("putFragment", "(Landroid/os/Bundle;Ljava/lang/String;Landroidx/fragment/app/Fragment;)V", "GetPutFragment_Landroid_os_Bundle_Ljava_lang_String_Landroidx_fragment_app_Fragment_Handler")]
		public unsafe virtual void PutFragment(Bundle bundle, string key, Fragment fragment)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((bundle == null) ? IntPtr.Zero : bundle.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((fragment == null) ? IntPtr.Zero : fragment.Handle);
				FragmentManager._members.InstanceMethods.InvokeVirtualVoidMethod("putFragment.(Landroid/os/Bundle;Ljava/lang/String;Landroidx/fragment/app/Fragment;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(bundle);
				GC.KeepAlive(fragment);
			}
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x0000988C File Offset: 0x00007A8C
		private static Delegate GetRegisterFragmentLifecycleCallbacks_Landroidx_fragment_app_FragmentManager_FragmentLifecycleCallbacks_ZHandler()
		{
			if (FragmentManager.cb_registerFragmentLifecycleCallbacks_Landroidx_fragment_app_FragmentManager_FragmentLifecycleCallbacks_Z == null)
			{
				FragmentManager.cb_registerFragmentLifecycleCallbacks_Landroidx_fragment_app_FragmentManager_FragmentLifecycleCallbacks_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZ_V(FragmentManager.n_RegisterFragmentLifecycleCallbacks_Landroidx_fragment_app_FragmentManager_FragmentLifecycleCallbacks_Z));
			}
			return FragmentManager.cb_registerFragmentLifecycleCallbacks_Landroidx_fragment_app_FragmentManager_FragmentLifecycleCallbacks_Z;
		}

		// Token: 0x060002EA RID: 746 RVA: 0x000098B0 File Offset: 0x00007AB0
		private static void n_RegisterFragmentLifecycleCallbacks_Landroidx_fragment_app_FragmentManager_FragmentLifecycleCallbacks_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_cb, bool recursive)
		{
			FragmentManager @object = Java.Lang.Object.GetObject<FragmentManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			FragmentManager.FragmentLifecycleCallbacks object2 = Java.Lang.Object.GetObject<FragmentManager.FragmentLifecycleCallbacks>(native_cb, JniHandleOwnership.DoNotTransfer);
			@object.RegisterFragmentLifecycleCallbacks(object2, recursive);
		}

		// Token: 0x060002EB RID: 747 RVA: 0x000098D4 File Offset: 0x00007AD4
		[Register("registerFragmentLifecycleCallbacks", "(Landroidx/fragment/app/FragmentManager$FragmentLifecycleCallbacks;Z)V", "GetRegisterFragmentLifecycleCallbacks_Landroidx_fragment_app_FragmentManager_FragmentLifecycleCallbacks_ZHandler")]
		public unsafe virtual void RegisterFragmentLifecycleCallbacks(FragmentManager.FragmentLifecycleCallbacks cb, bool recursive)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((cb == null) ? IntPtr.Zero : cb.Handle);
				ptr[1] = new JniArgumentValue(recursive);
				FragmentManager._members.InstanceMethods.InvokeVirtualVoidMethod("registerFragmentLifecycleCallbacks.(Landroidx/fragment/app/FragmentManager$FragmentLifecycleCallbacks;Z)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(cb);
			}
		}

		// Token: 0x060002EC RID: 748 RVA: 0x0000994C File Offset: 0x00007B4C
		private static Delegate GetRemoveFragmentOnAttachListener_Landroidx_fragment_app_FragmentOnAttachListener_Handler()
		{
			if (FragmentManager.cb_removeFragmentOnAttachListener_Landroidx_fragment_app_FragmentOnAttachListener_ == null)
			{
				FragmentManager.cb_removeFragmentOnAttachListener_Landroidx_fragment_app_FragmentOnAttachListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(FragmentManager.n_RemoveFragmentOnAttachListener_Landroidx_fragment_app_FragmentOnAttachListener_));
			}
			return FragmentManager.cb_removeFragmentOnAttachListener_Landroidx_fragment_app_FragmentOnAttachListener_;
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00009970 File Offset: 0x00007B70
		private static void n_RemoveFragmentOnAttachListener_Landroidx_fragment_app_FragmentOnAttachListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			FragmentManager @object = Java.Lang.Object.GetObject<FragmentManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IFragmentOnAttachListener object2 = Java.Lang.Object.GetObject<IFragmentOnAttachListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.RemoveFragmentOnAttachListener(object2);
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00009994 File Offset: 0x00007B94
		[Register("removeFragmentOnAttachListener", "(Landroidx/fragment/app/FragmentOnAttachListener;)V", "GetRemoveFragmentOnAttachListener_Landroidx_fragment_app_FragmentOnAttachListener_Handler")]
		public unsafe virtual void RemoveFragmentOnAttachListener(IFragmentOnAttachListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				FragmentManager._members.InstanceMethods.InvokeVirtualVoidMethod("removeFragmentOnAttachListener.(Landroidx/fragment/app/FragmentOnAttachListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x060002EF RID: 751 RVA: 0x000099FC File Offset: 0x00007BFC
		private static Delegate GetRemoveOnBackStackChangedListener_Landroidx_fragment_app_FragmentManager_OnBackStackChangedListener_Handler()
		{
			if (FragmentManager.cb_removeOnBackStackChangedListener_Landroidx_fragment_app_FragmentManager_OnBackStackChangedListener_ == null)
			{
				FragmentManager.cb_removeOnBackStackChangedListener_Landroidx_fragment_app_FragmentManager_OnBackStackChangedListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(FragmentManager.n_RemoveOnBackStackChangedListener_Landroidx_fragment_app_FragmentManager_OnBackStackChangedListener_));
			}
			return FragmentManager.cb_removeOnBackStackChangedListener_Landroidx_fragment_app_FragmentManager_OnBackStackChangedListener_;
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00009A20 File Offset: 0x00007C20
		private static void n_RemoveOnBackStackChangedListener_Landroidx_fragment_app_FragmentManager_OnBackStackChangedListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			FragmentManager @object = Java.Lang.Object.GetObject<FragmentManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			FragmentManager.IOnBackStackChangedListener object2 = Java.Lang.Object.GetObject<FragmentManager.IOnBackStackChangedListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.RemoveOnBackStackChangedListener(object2);
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00009A44 File Offset: 0x00007C44
		[Register("removeOnBackStackChangedListener", "(Landroidx/fragment/app/FragmentManager$OnBackStackChangedListener;)V", "GetRemoveOnBackStackChangedListener_Landroidx_fragment_app_FragmentManager_OnBackStackChangedListener_Handler")]
		public unsafe virtual void RemoveOnBackStackChangedListener(FragmentManager.IOnBackStackChangedListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				FragmentManager._members.InstanceMethods.InvokeVirtualVoidMethod("removeOnBackStackChangedListener.(Landroidx/fragment/app/FragmentManager$OnBackStackChangedListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00009AAC File Offset: 0x00007CAC
		private static Delegate GetRestoreBackStack_Ljava_lang_String_Handler()
		{
			if (FragmentManager.cb_restoreBackStack_Ljava_lang_String_ == null)
			{
				FragmentManager.cb_restoreBackStack_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(FragmentManager.n_RestoreBackStack_Ljava_lang_String_));
			}
			return FragmentManager.cb_restoreBackStack_Ljava_lang_String_;
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00009AD0 File Offset: 0x00007CD0
		private static void n_RestoreBackStack_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			FragmentManager @object = Java.Lang.Object.GetObject<FragmentManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_name, JniHandleOwnership.DoNotTransfer);
			@object.RestoreBackStack(@string);
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00009AF4 File Offset: 0x00007CF4
		[Register("restoreBackStack", "(Ljava/lang/String;)V", "GetRestoreBackStack_Ljava_lang_String_Handler")]
		public unsafe virtual void RestoreBackStack(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				FragmentManager._members.InstanceMethods.InvokeVirtualVoidMethod("restoreBackStack.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00009B50 File Offset: 0x00007D50
		private static Delegate GetSaveBackStack_Ljava_lang_String_Handler()
		{
			if (FragmentManager.cb_saveBackStack_Ljava_lang_String_ == null)
			{
				FragmentManager.cb_saveBackStack_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(FragmentManager.n_SaveBackStack_Ljava_lang_String_));
			}
			return FragmentManager.cb_saveBackStack_Ljava_lang_String_;
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00009B74 File Offset: 0x00007D74
		private static void n_SaveBackStack_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			FragmentManager @object = Java.Lang.Object.GetObject<FragmentManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_name, JniHandleOwnership.DoNotTransfer);
			@object.SaveBackStack(@string);
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00009B98 File Offset: 0x00007D98
		[Register("saveBackStack", "(Ljava/lang/String;)V", "GetSaveBackStack_Ljava_lang_String_Handler")]
		public unsafe virtual void SaveBackStack(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				FragmentManager._members.InstanceMethods.InvokeVirtualVoidMethod("saveBackStack.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00009BF4 File Offset: 0x00007DF4
		private static Delegate GetSaveFragmentInstanceState_Landroidx_fragment_app_Fragment_Handler()
		{
			if (FragmentManager.cb_saveFragmentInstanceState_Landroidx_fragment_app_Fragment_ == null)
			{
				FragmentManager.cb_saveFragmentInstanceState_Landroidx_fragment_app_Fragment_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(FragmentManager.n_SaveFragmentInstanceState_Landroidx_fragment_app_Fragment_));
			}
			return FragmentManager.cb_saveFragmentInstanceState_Landroidx_fragment_app_Fragment_;
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00009C18 File Offset: 0x00007E18
		private static IntPtr n_SaveFragmentInstanceState_Landroidx_fragment_app_Fragment_(IntPtr jnienv, IntPtr native__this, IntPtr native_f)
		{
			FragmentManager @object = Java.Lang.Object.GetObject<FragmentManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Fragment object2 = Java.Lang.Object.GetObject<Fragment>(native_f, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SaveFragmentInstanceState(object2));
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00009C40 File Offset: 0x00007E40
		[Register("saveFragmentInstanceState", "(Landroidx/fragment/app/Fragment;)Landroidx/fragment/app/Fragment$SavedState;", "GetSaveFragmentInstanceState_Landroidx_fragment_app_Fragment_Handler")]
		public unsafe virtual Fragment.SavedState SaveFragmentInstanceState(Fragment f)
		{
			Fragment.SavedState @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((f == null) ? IntPtr.Zero : f.Handle);
				@object = Java.Lang.Object.GetObject<Fragment.SavedState>(FragmentManager._members.InstanceMethods.InvokeVirtualObjectMethod("saveFragmentInstanceState.(Landroidx/fragment/app/Fragment;)Landroidx/fragment/app/Fragment$SavedState;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(f);
			}
			return @object;
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00009CB4 File Offset: 0x00007EB4
		[Register("setFragmentResult", "(Ljava/lang/String;Landroid/os/Bundle;)V", "")]
		public unsafe void SetFragmentResult(string requestKey, Bundle result)
		{
			IntPtr intPtr = JNIEnv.NewString(requestKey);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((result == null) ? IntPtr.Zero : result.Handle);
				FragmentManager._members.InstanceMethods.InvokeNonvirtualVoidMethod("setFragmentResult.(Ljava/lang/String;Landroid/os/Bundle;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(result);
			}
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00009D38 File Offset: 0x00007F38
		[Register("setFragmentResultListener", "(Ljava/lang/String;Landroidx/lifecycle/LifecycleOwner;Landroidx/fragment/app/FragmentResultListener;)V", "")]
		public unsafe void SetFragmentResultListener(string requestKey, ILifecycleOwner lifecycleOwner, IFragmentResultListener listener)
		{
			IntPtr intPtr = JNIEnv.NewString(requestKey);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((lifecycleOwner == null) ? IntPtr.Zero : ((Java.Lang.Object)lifecycleOwner).Handle);
				ptr[2] = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				FragmentManager._members.InstanceMethods.InvokeNonvirtualVoidMethod("setFragmentResultListener.(Ljava/lang/String;Landroidx/lifecycle/LifecycleOwner;Landroidx/fragment/app/FragmentResultListener;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(lifecycleOwner);
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00009DF0 File Offset: 0x00007FF0
		private static Delegate GetUnregisterFragmentLifecycleCallbacks_Landroidx_fragment_app_FragmentManager_FragmentLifecycleCallbacks_Handler()
		{
			if (FragmentManager.cb_unregisterFragmentLifecycleCallbacks_Landroidx_fragment_app_FragmentManager_FragmentLifecycleCallbacks_ == null)
			{
				FragmentManager.cb_unregisterFragmentLifecycleCallbacks_Landroidx_fragment_app_FragmentManager_FragmentLifecycleCallbacks_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(FragmentManager.n_UnregisterFragmentLifecycleCallbacks_Landroidx_fragment_app_FragmentManager_FragmentLifecycleCallbacks_));
			}
			return FragmentManager.cb_unregisterFragmentLifecycleCallbacks_Landroidx_fragment_app_FragmentManager_FragmentLifecycleCallbacks_;
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00009E14 File Offset: 0x00008014
		private static void n_UnregisterFragmentLifecycleCallbacks_Landroidx_fragment_app_FragmentManager_FragmentLifecycleCallbacks_(IntPtr jnienv, IntPtr native__this, IntPtr native_cb)
		{
			FragmentManager @object = Java.Lang.Object.GetObject<FragmentManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			FragmentManager.FragmentLifecycleCallbacks object2 = Java.Lang.Object.GetObject<FragmentManager.FragmentLifecycleCallbacks>(native_cb, JniHandleOwnership.DoNotTransfer);
			@object.UnregisterFragmentLifecycleCallbacks(object2);
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00009E38 File Offset: 0x00008038
		[Register("unregisterFragmentLifecycleCallbacks", "(Landroidx/fragment/app/FragmentManager$FragmentLifecycleCallbacks;)V", "GetUnregisterFragmentLifecycleCallbacks_Landroidx_fragment_app_FragmentManager_FragmentLifecycleCallbacks_Handler")]
		public unsafe virtual void UnregisterFragmentLifecycleCallbacks(FragmentManager.FragmentLifecycleCallbacks cb)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((cb == null) ? IntPtr.Zero : cb.Handle);
				FragmentManager._members.InstanceMethods.InvokeVirtualVoidMethod("unregisterFragmentLifecycleCallbacks.(Landroidx/fragment/app/FragmentManager$FragmentLifecycleCallbacks;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(cb);
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000300 RID: 768 RVA: 0x00009E9C File Offset: 0x0000809C
		// (remove) Token: 0x06000301 RID: 769 RVA: 0x00009EE8 File Offset: 0x000080E8
		public event EventHandler<FragmentOnAttachEventArgs> FragmentOnAttach
		{
			add
			{
				EventHelper.AddEventHandler<IFragmentOnAttachListener, IFragmentOnAttachListenerImplementor>(ref this.weak_implementor_AddFragmentOnAttachListener, new Func<IFragmentOnAttachListenerImplementor>(this.__CreateIFragmentOnAttachListenerImplementor), new Action<IFragmentOnAttachListener>(this.AddFragmentOnAttachListener), delegate(IFragmentOnAttachListenerImplementor __h)
				{
					__h.Handler = (EventHandler<FragmentOnAttachEventArgs>)Delegate.Combine(__h.Handler, value);
				});
			}
			remove
			{
				Func<IFragmentOnAttachListenerImplementor, bool> empty;
				if ((empty = FragmentManager.<>O.<0>____IsEmpty) == null)
				{
					empty = (FragmentManager.<>O.<0>____IsEmpty = new Func<IFragmentOnAttachListenerImplementor, bool>(IFragmentOnAttachListenerImplementor.__IsEmpty));
				}
				EventHelper.RemoveEventHandler<IFragmentOnAttachListener, IFragmentOnAttachListenerImplementor>(ref this.weak_implementor_AddFragmentOnAttachListener, empty, delegate(IFragmentOnAttachListener __v)
				{
					this.RemoveFragmentOnAttachListener(__v);
				}, delegate(IFragmentOnAttachListenerImplementor __h)
				{
					__h.Handler = (EventHandler<FragmentOnAttachEventArgs>)Delegate.Remove(__h.Handler, value);
				});
			}
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00009F47 File Offset: 0x00008147
		private IFragmentOnAttachListenerImplementor __CreateIFragmentOnAttachListenerImplementor()
		{
			return new IFragmentOnAttachListenerImplementor(this);
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000303 RID: 771 RVA: 0x00009F50 File Offset: 0x00008150
		// (remove) Token: 0x06000304 RID: 772 RVA: 0x00009F9C File Offset: 0x0000819C
		public event EventHandler<FragmentManager.BackStackChangeCommittedEventArgs> BackStackChangeCommitted
		{
			add
			{
				EventHelper.AddEventHandler<FragmentManager.IOnBackStackChangedListener, FragmentManager.IOnBackStackChangedListenerImplementor>(ref this.weak_implementor_AddOnBackStackChangedListener, new Func<FragmentManager.IOnBackStackChangedListenerImplementor>(this.__CreateIOnBackStackChangedListenerImplementor), new Action<FragmentManager.IOnBackStackChangedListener>(this.AddOnBackStackChangedListener), delegate(FragmentManager.IOnBackStackChangedListenerImplementor __h)
				{
					__h.OnBackStackChangeCommittedHandler = (EventHandler<FragmentManager.BackStackChangeCommittedEventArgs>)Delegate.Combine(__h.OnBackStackChangeCommittedHandler, value);
				});
			}
			remove
			{
				Func<FragmentManager.IOnBackStackChangedListenerImplementor, bool> empty;
				if ((empty = FragmentManager.<>O.<1>____IsEmpty) == null)
				{
					empty = (FragmentManager.<>O.<1>____IsEmpty = new Func<FragmentManager.IOnBackStackChangedListenerImplementor, bool>(FragmentManager.IOnBackStackChangedListenerImplementor.__IsEmpty));
				}
				EventHelper.RemoveEventHandler<FragmentManager.IOnBackStackChangedListener, FragmentManager.IOnBackStackChangedListenerImplementor>(ref this.weak_implementor_AddOnBackStackChangedListener, empty, delegate(FragmentManager.IOnBackStackChangedListener __v)
				{
					this.RemoveOnBackStackChangedListener(__v);
				}, delegate(FragmentManager.IOnBackStackChangedListenerImplementor __h)
				{
					__h.OnBackStackChangeCommittedHandler = (EventHandler<FragmentManager.BackStackChangeCommittedEventArgs>)Delegate.Remove(__h.OnBackStackChangeCommittedHandler, value);
				});
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000305 RID: 773 RVA: 0x00009FFC File Offset: 0x000081FC
		// (remove) Token: 0x06000306 RID: 774 RVA: 0x0000A048 File Offset: 0x00008248
		public event EventHandler<FragmentManager.BackStackChangeStartedEventArgs> BackStackChangeStarted
		{
			add
			{
				EventHelper.AddEventHandler<FragmentManager.IOnBackStackChangedListener, FragmentManager.IOnBackStackChangedListenerImplementor>(ref this.weak_implementor_AddOnBackStackChangedListener, new Func<FragmentManager.IOnBackStackChangedListenerImplementor>(this.__CreateIOnBackStackChangedListenerImplementor), new Action<FragmentManager.IOnBackStackChangedListener>(this.AddOnBackStackChangedListener), delegate(FragmentManager.IOnBackStackChangedListenerImplementor __h)
				{
					__h.OnBackStackChangeStartedHandler = (EventHandler<FragmentManager.BackStackChangeStartedEventArgs>)Delegate.Combine(__h.OnBackStackChangeStartedHandler, value);
				});
			}
			remove
			{
				Func<FragmentManager.IOnBackStackChangedListenerImplementor, bool> empty;
				if ((empty = FragmentManager.<>O.<1>____IsEmpty) == null)
				{
					empty = (FragmentManager.<>O.<1>____IsEmpty = new Func<FragmentManager.IOnBackStackChangedListenerImplementor, bool>(FragmentManager.IOnBackStackChangedListenerImplementor.__IsEmpty));
				}
				EventHelper.RemoveEventHandler<FragmentManager.IOnBackStackChangedListener, FragmentManager.IOnBackStackChangedListenerImplementor>(ref this.weak_implementor_AddOnBackStackChangedListener, empty, delegate(FragmentManager.IOnBackStackChangedListener __v)
				{
					this.RemoveOnBackStackChangedListener(__v);
				}, delegate(FragmentManager.IOnBackStackChangedListenerImplementor __h)
				{
					__h.OnBackStackChangeStartedHandler = (EventHandler<FragmentManager.BackStackChangeStartedEventArgs>)Delegate.Remove(__h.OnBackStackChangeStartedHandler, value);
				});
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000307 RID: 775 RVA: 0x0000A0A8 File Offset: 0x000082A8
		// (remove) Token: 0x06000308 RID: 776 RVA: 0x0000A0F4 File Offset: 0x000082F4
		public event EventHandler BackStackChanged
		{
			add
			{
				EventHelper.AddEventHandler<FragmentManager.IOnBackStackChangedListener, FragmentManager.IOnBackStackChangedListenerImplementor>(ref this.weak_implementor_AddOnBackStackChangedListener, new Func<FragmentManager.IOnBackStackChangedListenerImplementor>(this.__CreateIOnBackStackChangedListenerImplementor), new Action<FragmentManager.IOnBackStackChangedListener>(this.AddOnBackStackChangedListener), delegate(FragmentManager.IOnBackStackChangedListenerImplementor __h)
				{
					__h.OnBackStackChangedHandler = (EventHandler)Delegate.Combine(__h.OnBackStackChangedHandler, value);
				});
			}
			remove
			{
				Func<FragmentManager.IOnBackStackChangedListenerImplementor, bool> empty;
				if ((empty = FragmentManager.<>O.<1>____IsEmpty) == null)
				{
					empty = (FragmentManager.<>O.<1>____IsEmpty = new Func<FragmentManager.IOnBackStackChangedListenerImplementor, bool>(FragmentManager.IOnBackStackChangedListenerImplementor.__IsEmpty));
				}
				EventHelper.RemoveEventHandler<FragmentManager.IOnBackStackChangedListener, FragmentManager.IOnBackStackChangedListenerImplementor>(ref this.weak_implementor_AddOnBackStackChangedListener, empty, delegate(FragmentManager.IOnBackStackChangedListener __v)
				{
					this.RemoveOnBackStackChangedListener(__v);
				}, delegate(FragmentManager.IOnBackStackChangedListenerImplementor __h)
				{
					__h.OnBackStackChangedHandler = (EventHandler)Delegate.Remove(__h.OnBackStackChangedHandler, value);
				});
			}
		}

		// Token: 0x06000309 RID: 777 RVA: 0x0000A153 File Offset: 0x00008353
		private FragmentManager.IOnBackStackChangedListenerImplementor __CreateIOnBackStackChangedListenerImplementor()
		{
			return new FragmentManager.IOnBackStackChangedListenerImplementor(this);
		}

		// Token: 0x0400008F RID: 143
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/fragment/app/FragmentManager", typeof(FragmentManager));

		// Token: 0x04000090 RID: 144
		private static Delegate cb_getBackStackEntryCount;

		// Token: 0x04000091 RID: 145
		private static Delegate cb_getFragmentFactory;

		// Token: 0x04000092 RID: 146
		private static Delegate cb_setFragmentFactory_Landroidx_fragment_app_FragmentFactory_;

		// Token: 0x04000093 RID: 147
		private static Delegate cb_getFragments;

		// Token: 0x04000094 RID: 148
		private static Delegate cb_getHost;

		// Token: 0x04000095 RID: 149
		private static Delegate cb_isDestroyed;

		// Token: 0x04000096 RID: 150
		private static Delegate cb_isStateSaved;

		// Token: 0x04000097 RID: 151
		private static Delegate cb_getPrimaryNavigationFragment;

		// Token: 0x04000098 RID: 152
		private static Delegate cb_getStrictModePolicy;

		// Token: 0x04000099 RID: 153
		private static Delegate cb_setStrictModePolicy_Landroidx_fragment_app_strictmode_FragmentStrictMode_Policy_;

		// Token: 0x0400009A RID: 154
		private static Delegate cb_addFragmentOnAttachListener_Landroidx_fragment_app_FragmentOnAttachListener_;

		// Token: 0x0400009B RID: 155
		private static Delegate cb_addOnBackStackChangedListener_Landroidx_fragment_app_FragmentManager_OnBackStackChangedListener_;

		// Token: 0x0400009C RID: 156
		private static Delegate cb_beginTransaction;

		// Token: 0x0400009D RID: 157
		private static Delegate cb_clearBackStack_Ljava_lang_String_;

		// Token: 0x0400009E RID: 158
		private static Delegate cb_dump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_;

		// Token: 0x0400009F RID: 159
		private static Delegate cb_executePendingTransactions;

		// Token: 0x040000A0 RID: 160
		private static Delegate cb_findFragmentById_I;

		// Token: 0x040000A1 RID: 161
		private static Delegate cb_findFragmentByTag_Ljava_lang_String_;

		// Token: 0x040000A2 RID: 162
		private static Delegate cb_getBackStackEntryAt_I;

		// Token: 0x040000A3 RID: 163
		private static Delegate cb_getFragment_Landroid_os_Bundle_Ljava_lang_String_;

		// Token: 0x040000A4 RID: 164
		private static Delegate cb_openTransaction;

		// Token: 0x040000A5 RID: 165
		private static Delegate cb_popBackStack;

		// Token: 0x040000A6 RID: 166
		private static Delegate cb_popBackStack_II;

		// Token: 0x040000A7 RID: 167
		private static Delegate cb_popBackStack_Ljava_lang_String_I;

		// Token: 0x040000A8 RID: 168
		private static Delegate cb_popBackStackImmediate;

		// Token: 0x040000A9 RID: 169
		private static Delegate cb_popBackStackImmediate_II;

		// Token: 0x040000AA RID: 170
		private static Delegate cb_popBackStackImmediate_Ljava_lang_String_I;

		// Token: 0x040000AB RID: 171
		private static Delegate cb_putFragment_Landroid_os_Bundle_Ljava_lang_String_Landroidx_fragment_app_Fragment_;

		// Token: 0x040000AC RID: 172
		private static Delegate cb_registerFragmentLifecycleCallbacks_Landroidx_fragment_app_FragmentManager_FragmentLifecycleCallbacks_Z;

		// Token: 0x040000AD RID: 173
		private static Delegate cb_removeFragmentOnAttachListener_Landroidx_fragment_app_FragmentOnAttachListener_;

		// Token: 0x040000AE RID: 174
		private static Delegate cb_removeOnBackStackChangedListener_Landroidx_fragment_app_FragmentManager_OnBackStackChangedListener_;

		// Token: 0x040000AF RID: 175
		private static Delegate cb_restoreBackStack_Ljava_lang_String_;

		// Token: 0x040000B0 RID: 176
		private static Delegate cb_saveBackStack_Ljava_lang_String_;

		// Token: 0x040000B1 RID: 177
		private static Delegate cb_saveFragmentInstanceState_Landroidx_fragment_app_Fragment_;

		// Token: 0x040000B2 RID: 178
		private static Delegate cb_unregisterFragmentLifecycleCallbacks_Landroidx_fragment_app_FragmentManager_FragmentLifecycleCallbacks_;

		// Token: 0x040000B3 RID: 179
		private WeakReference weak_implementor_AddFragmentOnAttachListener;

		// Token: 0x040000B4 RID: 180
		private WeakReference weak_implementor_AddOnBackStackChangedListener;

		// Token: 0x02000031 RID: 49
		[Register("androidx/fragment/app/FragmentManager$BackStackEntry", "", "AndroidX.Fragment.App.FragmentManager/IBackStackEntryInvoker")]
		public interface IBackStackEntry : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000062 RID: 98
			// (get) Token: 0x0600030B RID: 779
			ICharSequence BreadCrumbShortTitleFormatted { [Register("getBreadCrumbShortTitle", "()Ljava/lang/CharSequence;", "GetGetBreadCrumbShortTitleHandler:AndroidX.Fragment.App.FragmentManager/IBackStackEntryInvoker, Xamarin.AndroidX.Fragment")] get; }

			// Token: 0x17000063 RID: 99
			// (get) Token: 0x0600030C RID: 780
			int BreadCrumbShortTitleRes { [Register("getBreadCrumbShortTitleRes", "()I", "GetGetBreadCrumbShortTitleResHandler:AndroidX.Fragment.App.FragmentManager/IBackStackEntryInvoker, Xamarin.AndroidX.Fragment")] get; }

			// Token: 0x17000064 RID: 100
			// (get) Token: 0x0600030D RID: 781
			ICharSequence BreadCrumbTitleFormatted { [Register("getBreadCrumbTitle", "()Ljava/lang/CharSequence;", "GetGetBreadCrumbTitleHandler:AndroidX.Fragment.App.FragmentManager/IBackStackEntryInvoker, Xamarin.AndroidX.Fragment")] get; }

			// Token: 0x17000065 RID: 101
			// (get) Token: 0x0600030E RID: 782
			int BreadCrumbTitleRes { [Register("getBreadCrumbTitleRes", "()I", "GetGetBreadCrumbTitleResHandler:AndroidX.Fragment.App.FragmentManager/IBackStackEntryInvoker, Xamarin.AndroidX.Fragment")] get; }

			// Token: 0x17000066 RID: 102
			// (get) Token: 0x0600030F RID: 783
			int Id { [Register("getId", "()I", "GetGetIdHandler:AndroidX.Fragment.App.FragmentManager/IBackStackEntryInvoker, Xamarin.AndroidX.Fragment")] get; }

			// Token: 0x17000067 RID: 103
			// (get) Token: 0x06000310 RID: 784
			string Name { [Register("getName", "()Ljava/lang/String;", "GetGetNameHandler:AndroidX.Fragment.App.FragmentManager/IBackStackEntryInvoker, Xamarin.AndroidX.Fragment")] get; }
		}

		// Token: 0x02000032 RID: 50
		[Register("androidx/fragment/app/FragmentManager$BackStackEntry", DoNotGenerateAcw = true)]
		internal class IBackStackEntryInvoker : Java.Lang.Object, FragmentManager.IBackStackEntry, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000068 RID: 104
			// (get) Token: 0x06000311 RID: 785 RVA: 0x0000A178 File Offset: 0x00008378
			private static IntPtr java_class_ref
			{
				get
				{
					return FragmentManager.IBackStackEntryInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000069 RID: 105
			// (get) Token: 0x06000312 RID: 786 RVA: 0x0000A19C File Offset: 0x0000839C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return FragmentManager.IBackStackEntryInvoker._members;
				}
			}

			// Token: 0x1700006A RID: 106
			// (get) Token: 0x06000313 RID: 787 RVA: 0x0000A1A3 File Offset: 0x000083A3
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x1700006B RID: 107
			// (get) Token: 0x06000314 RID: 788 RVA: 0x0000A1AB File Offset: 0x000083AB
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return FragmentManager.IBackStackEntryInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000315 RID: 789 RVA: 0x0000A1B7 File Offset: 0x000083B7
			public static FragmentManager.IBackStackEntry GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<FragmentManager.IBackStackEntry>(handle, transfer);
			}

			// Token: 0x06000316 RID: 790 RVA: 0x0000A1C0 File Offset: 0x000083C0
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, FragmentManager.IBackStackEntryInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.fragment.app.FragmentManager.BackStackEntry'.");
				}
				return handle;
			}

			// Token: 0x06000317 RID: 791 RVA: 0x0000A1EB File Offset: 0x000083EB
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000318 RID: 792 RVA: 0x0000A21C File Offset: 0x0000841C
			public IBackStackEntryInvoker(IntPtr handle, JniHandleOwnership transfer) : base(FragmentManager.IBackStackEntryInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000319 RID: 793 RVA: 0x0000A254 File Offset: 0x00008454
			private static Delegate GetGetBreadCrumbShortTitleHandler()
			{
				if (FragmentManager.IBackStackEntryInvoker.cb_getBreadCrumbShortTitle == null)
				{
					FragmentManager.IBackStackEntryInvoker.cb_getBreadCrumbShortTitle = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(FragmentManager.IBackStackEntryInvoker.n_GetBreadCrumbShortTitle));
				}
				return FragmentManager.IBackStackEntryInvoker.cb_getBreadCrumbShortTitle;
			}

			// Token: 0x0600031A RID: 794 RVA: 0x0000A278 File Offset: 0x00008478
			private static IntPtr n_GetBreadCrumbShortTitle(IntPtr jnienv, IntPtr native__this)
			{
				return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<FragmentManager.IBackStackEntry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BreadCrumbShortTitleFormatted);
			}

			// Token: 0x1700006C RID: 108
			// (get) Token: 0x0600031B RID: 795 RVA: 0x0000A28C File Offset: 0x0000848C
			public ICharSequence BreadCrumbShortTitleFormatted
			{
				get
				{
					if (this.id_getBreadCrumbShortTitle == IntPtr.Zero)
					{
						this.id_getBreadCrumbShortTitle = JNIEnv.GetMethodID(this.class_ref, "getBreadCrumbShortTitle", "()Ljava/lang/CharSequence;");
					}
					return Java.Lang.Object.GetObject<ICharSequence>(JNIEnv.CallObjectMethod(base.Handle, this.id_getBreadCrumbShortTitle), JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x0600031C RID: 796 RVA: 0x0000A2DD File Offset: 0x000084DD
			private static Delegate GetGetBreadCrumbShortTitleResHandler()
			{
				if (FragmentManager.IBackStackEntryInvoker.cb_getBreadCrumbShortTitleRes == null)
				{
					FragmentManager.IBackStackEntryInvoker.cb_getBreadCrumbShortTitleRes = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(FragmentManager.IBackStackEntryInvoker.n_GetBreadCrumbShortTitleRes));
				}
				return FragmentManager.IBackStackEntryInvoker.cb_getBreadCrumbShortTitleRes;
			}

			// Token: 0x0600031D RID: 797 RVA: 0x0000A301 File Offset: 0x00008501
			private static int n_GetBreadCrumbShortTitleRes(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<FragmentManager.IBackStackEntry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BreadCrumbShortTitleRes;
			}

			// Token: 0x1700006D RID: 109
			// (get) Token: 0x0600031E RID: 798 RVA: 0x0000A310 File Offset: 0x00008510
			public int BreadCrumbShortTitleRes
			{
				get
				{
					if (this.id_getBreadCrumbShortTitleRes == IntPtr.Zero)
					{
						this.id_getBreadCrumbShortTitleRes = JNIEnv.GetMethodID(this.class_ref, "getBreadCrumbShortTitleRes", "()I");
					}
					return JNIEnv.CallIntMethod(base.Handle, this.id_getBreadCrumbShortTitleRes);
				}
			}

			// Token: 0x0600031F RID: 799 RVA: 0x0000A350 File Offset: 0x00008550
			private static Delegate GetGetBreadCrumbTitleHandler()
			{
				if (FragmentManager.IBackStackEntryInvoker.cb_getBreadCrumbTitle == null)
				{
					FragmentManager.IBackStackEntryInvoker.cb_getBreadCrumbTitle = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(FragmentManager.IBackStackEntryInvoker.n_GetBreadCrumbTitle));
				}
				return FragmentManager.IBackStackEntryInvoker.cb_getBreadCrumbTitle;
			}

			// Token: 0x06000320 RID: 800 RVA: 0x0000A374 File Offset: 0x00008574
			private static IntPtr n_GetBreadCrumbTitle(IntPtr jnienv, IntPtr native__this)
			{
				return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<FragmentManager.IBackStackEntry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BreadCrumbTitleFormatted);
			}

			// Token: 0x1700006E RID: 110
			// (get) Token: 0x06000321 RID: 801 RVA: 0x0000A388 File Offset: 0x00008588
			public ICharSequence BreadCrumbTitleFormatted
			{
				get
				{
					if (this.id_getBreadCrumbTitle == IntPtr.Zero)
					{
						this.id_getBreadCrumbTitle = JNIEnv.GetMethodID(this.class_ref, "getBreadCrumbTitle", "()Ljava/lang/CharSequence;");
					}
					return Java.Lang.Object.GetObject<ICharSequence>(JNIEnv.CallObjectMethod(base.Handle, this.id_getBreadCrumbTitle), JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x06000322 RID: 802 RVA: 0x0000A3D9 File Offset: 0x000085D9
			private static Delegate GetGetBreadCrumbTitleResHandler()
			{
				if (FragmentManager.IBackStackEntryInvoker.cb_getBreadCrumbTitleRes == null)
				{
					FragmentManager.IBackStackEntryInvoker.cb_getBreadCrumbTitleRes = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(FragmentManager.IBackStackEntryInvoker.n_GetBreadCrumbTitleRes));
				}
				return FragmentManager.IBackStackEntryInvoker.cb_getBreadCrumbTitleRes;
			}

			// Token: 0x06000323 RID: 803 RVA: 0x0000A3FD File Offset: 0x000085FD
			private static int n_GetBreadCrumbTitleRes(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<FragmentManager.IBackStackEntry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BreadCrumbTitleRes;
			}

			// Token: 0x1700006F RID: 111
			// (get) Token: 0x06000324 RID: 804 RVA: 0x0000A40C File Offset: 0x0000860C
			public int BreadCrumbTitleRes
			{
				get
				{
					if (this.id_getBreadCrumbTitleRes == IntPtr.Zero)
					{
						this.id_getBreadCrumbTitleRes = JNIEnv.GetMethodID(this.class_ref, "getBreadCrumbTitleRes", "()I");
					}
					return JNIEnv.CallIntMethod(base.Handle, this.id_getBreadCrumbTitleRes);
				}
			}

			// Token: 0x06000325 RID: 805 RVA: 0x0000A44C File Offset: 0x0000864C
			private static Delegate GetGetIdHandler()
			{
				if (FragmentManager.IBackStackEntryInvoker.cb_getId == null)
				{
					FragmentManager.IBackStackEntryInvoker.cb_getId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(FragmentManager.IBackStackEntryInvoker.n_GetId));
				}
				return FragmentManager.IBackStackEntryInvoker.cb_getId;
			}

			// Token: 0x06000326 RID: 806 RVA: 0x0000A470 File Offset: 0x00008670
			private static int n_GetId(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<FragmentManager.IBackStackEntry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Id;
			}

			// Token: 0x17000070 RID: 112
			// (get) Token: 0x06000327 RID: 807 RVA: 0x0000A47F File Offset: 0x0000867F
			public int Id
			{
				get
				{
					if (this.id_getId == IntPtr.Zero)
					{
						this.id_getId = JNIEnv.GetMethodID(this.class_ref, "getId", "()I");
					}
					return JNIEnv.CallIntMethod(base.Handle, this.id_getId);
				}
			}

			// Token: 0x06000328 RID: 808 RVA: 0x0000A4BF File Offset: 0x000086BF
			private static Delegate GetGetNameHandler()
			{
				if (FragmentManager.IBackStackEntryInvoker.cb_getName == null)
				{
					FragmentManager.IBackStackEntryInvoker.cb_getName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(FragmentManager.IBackStackEntryInvoker.n_GetName));
				}
				return FragmentManager.IBackStackEntryInvoker.cb_getName;
			}

			// Token: 0x06000329 RID: 809 RVA: 0x0000A4E3 File Offset: 0x000086E3
			private static IntPtr n_GetName(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<FragmentManager.IBackStackEntry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Name);
			}

			// Token: 0x17000071 RID: 113
			// (get) Token: 0x0600032A RID: 810 RVA: 0x0000A4F8 File Offset: 0x000086F8
			public string Name
			{
				get
				{
					if (this.id_getName == IntPtr.Zero)
					{
						this.id_getName = JNIEnv.GetMethodID(this.class_ref, "getName", "()Ljava/lang/String;");
					}
					return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getName), JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x040000B5 RID: 181
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/fragment/app/FragmentManager$BackStackEntry", typeof(FragmentManager.IBackStackEntryInvoker));

			// Token: 0x040000B6 RID: 182
			private IntPtr class_ref;

			// Token: 0x040000B7 RID: 183
			private static Delegate cb_getBreadCrumbShortTitle;

			// Token: 0x040000B8 RID: 184
			private IntPtr id_getBreadCrumbShortTitle;

			// Token: 0x040000B9 RID: 185
			private static Delegate cb_getBreadCrumbShortTitleRes;

			// Token: 0x040000BA RID: 186
			private IntPtr id_getBreadCrumbShortTitleRes;

			// Token: 0x040000BB RID: 187
			private static Delegate cb_getBreadCrumbTitle;

			// Token: 0x040000BC RID: 188
			private IntPtr id_getBreadCrumbTitle;

			// Token: 0x040000BD RID: 189
			private static Delegate cb_getBreadCrumbTitleRes;

			// Token: 0x040000BE RID: 190
			private IntPtr id_getBreadCrumbTitleRes;

			// Token: 0x040000BF RID: 191
			private static Delegate cb_getId;

			// Token: 0x040000C0 RID: 192
			private IntPtr id_getId;

			// Token: 0x040000C1 RID: 193
			private static Delegate cb_getName;

			// Token: 0x040000C2 RID: 194
			private IntPtr id_getName;
		}

		// Token: 0x02000033 RID: 51
		[Register("androidx/fragment/app/FragmentManager$FragmentLifecycleCallbacks", DoNotGenerateAcw = true)]
		public abstract class FragmentLifecycleCallbacks : Java.Lang.Object
		{
			// Token: 0x17000072 RID: 114
			// (get) Token: 0x0600032C RID: 812 RVA: 0x0000A564 File Offset: 0x00008764
			internal static IntPtr class_ref
			{
				get
				{
					return FragmentManager.FragmentLifecycleCallbacks._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000073 RID: 115
			// (get) Token: 0x0600032D RID: 813 RVA: 0x0000A588 File Offset: 0x00008788
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return FragmentManager.FragmentLifecycleCallbacks._members;
				}
			}

			// Token: 0x17000074 RID: 116
			// (get) Token: 0x0600032E RID: 814 RVA: 0x0000A590 File Offset: 0x00008790
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return FragmentManager.FragmentLifecycleCallbacks._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000075 RID: 117
			// (get) Token: 0x0600032F RID: 815 RVA: 0x0000A5B4 File Offset: 0x000087B4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return FragmentManager.FragmentLifecycleCallbacks._members.ManagedPeerType;
				}
			}

			// Token: 0x06000330 RID: 816 RVA: 0x00003624 File Offset: 0x00001824
			protected FragmentLifecycleCallbacks(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06000331 RID: 817 RVA: 0x0000A5C0 File Offset: 0x000087C0
			[Register(".ctor", "()V", "")]
			public FragmentLifecycleCallbacks() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(FragmentManager.FragmentLifecycleCallbacks._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				FragmentManager.FragmentLifecycleCallbacks._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x06000332 RID: 818 RVA: 0x0000A62E File Offset: 0x0000882E
			private static Delegate GetOnFragmentActivityCreated_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_os_Bundle_Handler()
			{
				if (FragmentManager.FragmentLifecycleCallbacks.cb_onFragmentActivityCreated_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_os_Bundle_ == null)
				{
					FragmentManager.FragmentLifecycleCallbacks.cb_onFragmentActivityCreated_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(FragmentManager.FragmentLifecycleCallbacks.n_OnFragmentActivityCreated_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_os_Bundle_));
				}
				return FragmentManager.FragmentLifecycleCallbacks.cb_onFragmentActivityCreated_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_os_Bundle_;
			}

			// Token: 0x06000333 RID: 819 RVA: 0x0000A654 File Offset: 0x00008854
			private static void n_OnFragmentActivityCreated_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_fm, IntPtr native_f, IntPtr native_savedInstanceState)
			{
				FragmentManager.FragmentLifecycleCallbacks @object = Java.Lang.Object.GetObject<FragmentManager.FragmentLifecycleCallbacks>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				FragmentManager object2 = Java.Lang.Object.GetObject<FragmentManager>(native_fm, JniHandleOwnership.DoNotTransfer);
				Fragment object3 = Java.Lang.Object.GetObject<Fragment>(native_f, JniHandleOwnership.DoNotTransfer);
				Bundle object4 = Java.Lang.Object.GetObject<Bundle>(native_savedInstanceState, JniHandleOwnership.DoNotTransfer);
				@object.OnFragmentActivityCreated(object2, object3, object4);
			}

			// Token: 0x06000334 RID: 820 RVA: 0x0000A68C File Offset: 0x0000888C
			[Register("onFragmentActivityCreated", "(Landroidx/fragment/app/FragmentManager;Landroidx/fragment/app/Fragment;Landroid/os/Bundle;)V", "GetOnFragmentActivityCreated_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_os_Bundle_Handler")]
			public unsafe virtual void OnFragmentActivityCreated(FragmentManager fm, Fragment f, Bundle savedInstanceState)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((fm == null) ? IntPtr.Zero : fm.Handle);
					ptr[1] = new JniArgumentValue((f == null) ? IntPtr.Zero : f.Handle);
					ptr[2] = new JniArgumentValue((savedInstanceState == null) ? IntPtr.Zero : savedInstanceState.Handle);
					FragmentManager.FragmentLifecycleCallbacks._members.InstanceMethods.InvokeVirtualVoidMethod("onFragmentActivityCreated.(Landroidx/fragment/app/FragmentManager;Landroidx/fragment/app/Fragment;Landroid/os/Bundle;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(fm);
					GC.KeepAlive(f);
					GC.KeepAlive(savedInstanceState);
				}
			}

			// Token: 0x06000335 RID: 821 RVA: 0x0000A744 File Offset: 0x00008944
			private static Delegate GetOnFragmentAttached_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_content_Context_Handler()
			{
				if (FragmentManager.FragmentLifecycleCallbacks.cb_onFragmentAttached_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_content_Context_ == null)
				{
					FragmentManager.FragmentLifecycleCallbacks.cb_onFragmentAttached_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(FragmentManager.FragmentLifecycleCallbacks.n_OnFragmentAttached_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_content_Context_));
				}
				return FragmentManager.FragmentLifecycleCallbacks.cb_onFragmentAttached_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_content_Context_;
			}

			// Token: 0x06000336 RID: 822 RVA: 0x0000A768 File Offset: 0x00008968
			private static void n_OnFragmentAttached_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_content_Context_(IntPtr jnienv, IntPtr native__this, IntPtr native_fm, IntPtr native_f, IntPtr native_context)
			{
				FragmentManager.FragmentLifecycleCallbacks @object = Java.Lang.Object.GetObject<FragmentManager.FragmentLifecycleCallbacks>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				FragmentManager object2 = Java.Lang.Object.GetObject<FragmentManager>(native_fm, JniHandleOwnership.DoNotTransfer);
				Fragment object3 = Java.Lang.Object.GetObject<Fragment>(native_f, JniHandleOwnership.DoNotTransfer);
				Context object4 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
				@object.OnFragmentAttached(object2, object3, object4);
			}

			// Token: 0x06000337 RID: 823 RVA: 0x0000A7A0 File Offset: 0x000089A0
			[Register("onFragmentAttached", "(Landroidx/fragment/app/FragmentManager;Landroidx/fragment/app/Fragment;Landroid/content/Context;)V", "GetOnFragmentAttached_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_content_Context_Handler")]
			public unsafe virtual void OnFragmentAttached(FragmentManager fm, Fragment f, Context context)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((fm == null) ? IntPtr.Zero : fm.Handle);
					ptr[1] = new JniArgumentValue((f == null) ? IntPtr.Zero : f.Handle);
					ptr[2] = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
					FragmentManager.FragmentLifecycleCallbacks._members.InstanceMethods.InvokeVirtualVoidMethod("onFragmentAttached.(Landroidx/fragment/app/FragmentManager;Landroidx/fragment/app/Fragment;Landroid/content/Context;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(fm);
					GC.KeepAlive(f);
					GC.KeepAlive(context);
				}
			}

			// Token: 0x06000338 RID: 824 RVA: 0x0000A858 File Offset: 0x00008A58
			private static Delegate GetOnFragmentCreated_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_os_Bundle_Handler()
			{
				if (FragmentManager.FragmentLifecycleCallbacks.cb_onFragmentCreated_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_os_Bundle_ == null)
				{
					FragmentManager.FragmentLifecycleCallbacks.cb_onFragmentCreated_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(FragmentManager.FragmentLifecycleCallbacks.n_OnFragmentCreated_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_os_Bundle_));
				}
				return FragmentManager.FragmentLifecycleCallbacks.cb_onFragmentCreated_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_os_Bundle_;
			}

			// Token: 0x06000339 RID: 825 RVA: 0x0000A87C File Offset: 0x00008A7C
			private static void n_OnFragmentCreated_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_fm, IntPtr native_f, IntPtr native_savedInstanceState)
			{
				FragmentManager.FragmentLifecycleCallbacks @object = Java.Lang.Object.GetObject<FragmentManager.FragmentLifecycleCallbacks>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				FragmentManager object2 = Java.Lang.Object.GetObject<FragmentManager>(native_fm, JniHandleOwnership.DoNotTransfer);
				Fragment object3 = Java.Lang.Object.GetObject<Fragment>(native_f, JniHandleOwnership.DoNotTransfer);
				Bundle object4 = Java.Lang.Object.GetObject<Bundle>(native_savedInstanceState, JniHandleOwnership.DoNotTransfer);
				@object.OnFragmentCreated(object2, object3, object4);
			}

			// Token: 0x0600033A RID: 826 RVA: 0x0000A8B4 File Offset: 0x00008AB4
			[Register("onFragmentCreated", "(Landroidx/fragment/app/FragmentManager;Landroidx/fragment/app/Fragment;Landroid/os/Bundle;)V", "GetOnFragmentCreated_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_os_Bundle_Handler")]
			public unsafe virtual void OnFragmentCreated(FragmentManager fm, Fragment f, Bundle savedInstanceState)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((fm == null) ? IntPtr.Zero : fm.Handle);
					ptr[1] = new JniArgumentValue((f == null) ? IntPtr.Zero : f.Handle);
					ptr[2] = new JniArgumentValue((savedInstanceState == null) ? IntPtr.Zero : savedInstanceState.Handle);
					FragmentManager.FragmentLifecycleCallbacks._members.InstanceMethods.InvokeVirtualVoidMethod("onFragmentCreated.(Landroidx/fragment/app/FragmentManager;Landroidx/fragment/app/Fragment;Landroid/os/Bundle;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(fm);
					GC.KeepAlive(f);
					GC.KeepAlive(savedInstanceState);
				}
			}

			// Token: 0x0600033B RID: 827 RVA: 0x0000A96C File Offset: 0x00008B6C
			private static Delegate GetOnFragmentDestroyed_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Handler()
			{
				if (FragmentManager.FragmentLifecycleCallbacks.cb_onFragmentDestroyed_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_ == null)
				{
					FragmentManager.FragmentLifecycleCallbacks.cb_onFragmentDestroyed_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(FragmentManager.FragmentLifecycleCallbacks.n_OnFragmentDestroyed_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_));
				}
				return FragmentManager.FragmentLifecycleCallbacks.cb_onFragmentDestroyed_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_;
			}

			// Token: 0x0600033C RID: 828 RVA: 0x0000A990 File Offset: 0x00008B90
			private static void n_OnFragmentDestroyed_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_(IntPtr jnienv, IntPtr native__this, IntPtr native_fm, IntPtr native_f)
			{
				FragmentManager.FragmentLifecycleCallbacks @object = Java.Lang.Object.GetObject<FragmentManager.FragmentLifecycleCallbacks>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				FragmentManager object2 = Java.Lang.Object.GetObject<FragmentManager>(native_fm, JniHandleOwnership.DoNotTransfer);
				Fragment object3 = Java.Lang.Object.GetObject<Fragment>(native_f, JniHandleOwnership.DoNotTransfer);
				@object.OnFragmentDestroyed(object2, object3);
			}

			// Token: 0x0600033D RID: 829 RVA: 0x0000A9BC File Offset: 0x00008BBC
			[Register("onFragmentDestroyed", "(Landroidx/fragment/app/FragmentManager;Landroidx/fragment/app/Fragment;)V", "GetOnFragmentDestroyed_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Handler")]
			public unsafe virtual void OnFragmentDestroyed(FragmentManager fm, Fragment f)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((fm == null) ? IntPtr.Zero : fm.Handle);
					ptr[1] = new JniArgumentValue((f == null) ? IntPtr.Zero : f.Handle);
					FragmentManager.FragmentLifecycleCallbacks._members.InstanceMethods.InvokeVirtualVoidMethod("onFragmentDestroyed.(Landroidx/fragment/app/FragmentManager;Landroidx/fragment/app/Fragment;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(fm);
					GC.KeepAlive(f);
				}
			}

			// Token: 0x0600033E RID: 830 RVA: 0x0000AA48 File Offset: 0x00008C48
			private static Delegate GetOnFragmentDetached_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Handler()
			{
				if (FragmentManager.FragmentLifecycleCallbacks.cb_onFragmentDetached_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_ == null)
				{
					FragmentManager.FragmentLifecycleCallbacks.cb_onFragmentDetached_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(FragmentManager.FragmentLifecycleCallbacks.n_OnFragmentDetached_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_));
				}
				return FragmentManager.FragmentLifecycleCallbacks.cb_onFragmentDetached_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_;
			}

			// Token: 0x0600033F RID: 831 RVA: 0x0000AA6C File Offset: 0x00008C6C
			private static void n_OnFragmentDetached_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_(IntPtr jnienv, IntPtr native__this, IntPtr native_fm, IntPtr native_f)
			{
				FragmentManager.FragmentLifecycleCallbacks @object = Java.Lang.Object.GetObject<FragmentManager.FragmentLifecycleCallbacks>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				FragmentManager object2 = Java.Lang.Object.GetObject<FragmentManager>(native_fm, JniHandleOwnership.DoNotTransfer);
				Fragment object3 = Java.Lang.Object.GetObject<Fragment>(native_f, JniHandleOwnership.DoNotTransfer);
				@object.OnFragmentDetached(object2, object3);
			}

			// Token: 0x06000340 RID: 832 RVA: 0x0000AA98 File Offset: 0x00008C98
			[Register("onFragmentDetached", "(Landroidx/fragment/app/FragmentManager;Landroidx/fragment/app/Fragment;)V", "GetOnFragmentDetached_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Handler")]
			public unsafe virtual void OnFragmentDetached(FragmentManager fm, Fragment f)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((fm == null) ? IntPtr.Zero : fm.Handle);
					ptr[1] = new JniArgumentValue((f == null) ? IntPtr.Zero : f.Handle);
					FragmentManager.FragmentLifecycleCallbacks._members.InstanceMethods.InvokeVirtualVoidMethod("onFragmentDetached.(Landroidx/fragment/app/FragmentManager;Landroidx/fragment/app/Fragment;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(fm);
					GC.KeepAlive(f);
				}
			}

			// Token: 0x06000341 RID: 833 RVA: 0x0000AB24 File Offset: 0x00008D24
			private static Delegate GetOnFragmentPaused_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Handler()
			{
				if (FragmentManager.FragmentLifecycleCallbacks.cb_onFragmentPaused_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_ == null)
				{
					FragmentManager.FragmentLifecycleCallbacks.cb_onFragmentPaused_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(FragmentManager.FragmentLifecycleCallbacks.n_OnFragmentPaused_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_));
				}
				return FragmentManager.FragmentLifecycleCallbacks.cb_onFragmentPaused_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_;
			}

			// Token: 0x06000342 RID: 834 RVA: 0x0000AB48 File Offset: 0x00008D48
			private static void n_OnFragmentPaused_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_(IntPtr jnienv, IntPtr native__this, IntPtr native_fm, IntPtr native_f)
			{
				FragmentManager.FragmentLifecycleCallbacks @object = Java.Lang.Object.GetObject<FragmentManager.FragmentLifecycleCallbacks>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				FragmentManager object2 = Java.Lang.Object.GetObject<FragmentManager>(native_fm, JniHandleOwnership.DoNotTransfer);
				Fragment object3 = Java.Lang.Object.GetObject<Fragment>(native_f, JniHandleOwnership.DoNotTransfer);
				@object.OnFragmentPaused(object2, object3);
			}

			// Token: 0x06000343 RID: 835 RVA: 0x0000AB74 File Offset: 0x00008D74
			[Register("onFragmentPaused", "(Landroidx/fragment/app/FragmentManager;Landroidx/fragment/app/Fragment;)V", "GetOnFragmentPaused_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Handler")]
			public unsafe virtual void OnFragmentPaused(FragmentManager fm, Fragment f)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((fm == null) ? IntPtr.Zero : fm.Handle);
					ptr[1] = new JniArgumentValue((f == null) ? IntPtr.Zero : f.Handle);
					FragmentManager.FragmentLifecycleCallbacks._members.InstanceMethods.InvokeVirtualVoidMethod("onFragmentPaused.(Landroidx/fragment/app/FragmentManager;Landroidx/fragment/app/Fragment;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(fm);
					GC.KeepAlive(f);
				}
			}

			// Token: 0x06000344 RID: 836 RVA: 0x0000AC00 File Offset: 0x00008E00
			private static Delegate GetOnFragmentPreAttached_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_content_Context_Handler()
			{
				if (FragmentManager.FragmentLifecycleCallbacks.cb_onFragmentPreAttached_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_content_Context_ == null)
				{
					FragmentManager.FragmentLifecycleCallbacks.cb_onFragmentPreAttached_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(FragmentManager.FragmentLifecycleCallbacks.n_OnFragmentPreAttached_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_content_Context_));
				}
				return FragmentManager.FragmentLifecycleCallbacks.cb_onFragmentPreAttached_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_content_Context_;
			}

			// Token: 0x06000345 RID: 837 RVA: 0x0000AC24 File Offset: 0x00008E24
			private static void n_OnFragmentPreAttached_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_content_Context_(IntPtr jnienv, IntPtr native__this, IntPtr native_fm, IntPtr native_f, IntPtr native_context)
			{
				FragmentManager.FragmentLifecycleCallbacks @object = Java.Lang.Object.GetObject<FragmentManager.FragmentLifecycleCallbacks>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				FragmentManager object2 = Java.Lang.Object.GetObject<FragmentManager>(native_fm, JniHandleOwnership.DoNotTransfer);
				Fragment object3 = Java.Lang.Object.GetObject<Fragment>(native_f, JniHandleOwnership.DoNotTransfer);
				Context object4 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
				@object.OnFragmentPreAttached(object2, object3, object4);
			}

			// Token: 0x06000346 RID: 838 RVA: 0x0000AC5C File Offset: 0x00008E5C
			[Register("onFragmentPreAttached", "(Landroidx/fragment/app/FragmentManager;Landroidx/fragment/app/Fragment;Landroid/content/Context;)V", "GetOnFragmentPreAttached_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_content_Context_Handler")]
			public unsafe virtual void OnFragmentPreAttached(FragmentManager fm, Fragment f, Context context)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((fm == null) ? IntPtr.Zero : fm.Handle);
					ptr[1] = new JniArgumentValue((f == null) ? IntPtr.Zero : f.Handle);
					ptr[2] = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
					FragmentManager.FragmentLifecycleCallbacks._members.InstanceMethods.InvokeVirtualVoidMethod("onFragmentPreAttached.(Landroidx/fragment/app/FragmentManager;Landroidx/fragment/app/Fragment;Landroid/content/Context;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(fm);
					GC.KeepAlive(f);
					GC.KeepAlive(context);
				}
			}

			// Token: 0x06000347 RID: 839 RVA: 0x0000AD14 File Offset: 0x00008F14
			private static Delegate GetOnFragmentPreCreated_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_os_Bundle_Handler()
			{
				if (FragmentManager.FragmentLifecycleCallbacks.cb_onFragmentPreCreated_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_os_Bundle_ == null)
				{
					FragmentManager.FragmentLifecycleCallbacks.cb_onFragmentPreCreated_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(FragmentManager.FragmentLifecycleCallbacks.n_OnFragmentPreCreated_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_os_Bundle_));
				}
				return FragmentManager.FragmentLifecycleCallbacks.cb_onFragmentPreCreated_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_os_Bundle_;
			}

			// Token: 0x06000348 RID: 840 RVA: 0x0000AD38 File Offset: 0x00008F38
			private static void n_OnFragmentPreCreated_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_fm, IntPtr native_f, IntPtr native_savedInstanceState)
			{
				FragmentManager.FragmentLifecycleCallbacks @object = Java.Lang.Object.GetObject<FragmentManager.FragmentLifecycleCallbacks>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				FragmentManager object2 = Java.Lang.Object.GetObject<FragmentManager>(native_fm, JniHandleOwnership.DoNotTransfer);
				Fragment object3 = Java.Lang.Object.GetObject<Fragment>(native_f, JniHandleOwnership.DoNotTransfer);
				Bundle object4 = Java.Lang.Object.GetObject<Bundle>(native_savedInstanceState, JniHandleOwnership.DoNotTransfer);
				@object.OnFragmentPreCreated(object2, object3, object4);
			}

			// Token: 0x06000349 RID: 841 RVA: 0x0000AD70 File Offset: 0x00008F70
			[Register("onFragmentPreCreated", "(Landroidx/fragment/app/FragmentManager;Landroidx/fragment/app/Fragment;Landroid/os/Bundle;)V", "GetOnFragmentPreCreated_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_os_Bundle_Handler")]
			public unsafe virtual void OnFragmentPreCreated(FragmentManager fm, Fragment f, Bundle savedInstanceState)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((fm == null) ? IntPtr.Zero : fm.Handle);
					ptr[1] = new JniArgumentValue((f == null) ? IntPtr.Zero : f.Handle);
					ptr[2] = new JniArgumentValue((savedInstanceState == null) ? IntPtr.Zero : savedInstanceState.Handle);
					FragmentManager.FragmentLifecycleCallbacks._members.InstanceMethods.InvokeVirtualVoidMethod("onFragmentPreCreated.(Landroidx/fragment/app/FragmentManager;Landroidx/fragment/app/Fragment;Landroid/os/Bundle;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(fm);
					GC.KeepAlive(f);
					GC.KeepAlive(savedInstanceState);
				}
			}

			// Token: 0x0600034A RID: 842 RVA: 0x0000AE28 File Offset: 0x00009028
			private static Delegate GetOnFragmentResumed_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Handler()
			{
				if (FragmentManager.FragmentLifecycleCallbacks.cb_onFragmentResumed_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_ == null)
				{
					FragmentManager.FragmentLifecycleCallbacks.cb_onFragmentResumed_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(FragmentManager.FragmentLifecycleCallbacks.n_OnFragmentResumed_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_));
				}
				return FragmentManager.FragmentLifecycleCallbacks.cb_onFragmentResumed_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_;
			}

			// Token: 0x0600034B RID: 843 RVA: 0x0000AE4C File Offset: 0x0000904C
			private static void n_OnFragmentResumed_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_(IntPtr jnienv, IntPtr native__this, IntPtr native_fm, IntPtr native_f)
			{
				FragmentManager.FragmentLifecycleCallbacks @object = Java.Lang.Object.GetObject<FragmentManager.FragmentLifecycleCallbacks>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				FragmentManager object2 = Java.Lang.Object.GetObject<FragmentManager>(native_fm, JniHandleOwnership.DoNotTransfer);
				Fragment object3 = Java.Lang.Object.GetObject<Fragment>(native_f, JniHandleOwnership.DoNotTransfer);
				@object.OnFragmentResumed(object2, object3);
			}

			// Token: 0x0600034C RID: 844 RVA: 0x0000AE78 File Offset: 0x00009078
			[Register("onFragmentResumed", "(Landroidx/fragment/app/FragmentManager;Landroidx/fragment/app/Fragment;)V", "GetOnFragmentResumed_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Handler")]
			public unsafe virtual void OnFragmentResumed(FragmentManager fm, Fragment f)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((fm == null) ? IntPtr.Zero : fm.Handle);
					ptr[1] = new JniArgumentValue((f == null) ? IntPtr.Zero : f.Handle);
					FragmentManager.FragmentLifecycleCallbacks._members.InstanceMethods.InvokeVirtualVoidMethod("onFragmentResumed.(Landroidx/fragment/app/FragmentManager;Landroidx/fragment/app/Fragment;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(fm);
					GC.KeepAlive(f);
				}
			}

			// Token: 0x0600034D RID: 845 RVA: 0x0000AF04 File Offset: 0x00009104
			private static Delegate GetOnFragmentSaveInstanceState_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_os_Bundle_Handler()
			{
				if (FragmentManager.FragmentLifecycleCallbacks.cb_onFragmentSaveInstanceState_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_os_Bundle_ == null)
				{
					FragmentManager.FragmentLifecycleCallbacks.cb_onFragmentSaveInstanceState_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(FragmentManager.FragmentLifecycleCallbacks.n_OnFragmentSaveInstanceState_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_os_Bundle_));
				}
				return FragmentManager.FragmentLifecycleCallbacks.cb_onFragmentSaveInstanceState_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_os_Bundle_;
			}

			// Token: 0x0600034E RID: 846 RVA: 0x0000AF28 File Offset: 0x00009128
			private static void n_OnFragmentSaveInstanceState_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_fm, IntPtr native_f, IntPtr native_outState)
			{
				FragmentManager.FragmentLifecycleCallbacks @object = Java.Lang.Object.GetObject<FragmentManager.FragmentLifecycleCallbacks>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				FragmentManager object2 = Java.Lang.Object.GetObject<FragmentManager>(native_fm, JniHandleOwnership.DoNotTransfer);
				Fragment object3 = Java.Lang.Object.GetObject<Fragment>(native_f, JniHandleOwnership.DoNotTransfer);
				Bundle object4 = Java.Lang.Object.GetObject<Bundle>(native_outState, JniHandleOwnership.DoNotTransfer);
				@object.OnFragmentSaveInstanceState(object2, object3, object4);
			}

			// Token: 0x0600034F RID: 847 RVA: 0x0000AF60 File Offset: 0x00009160
			[Register("onFragmentSaveInstanceState", "(Landroidx/fragment/app/FragmentManager;Landroidx/fragment/app/Fragment;Landroid/os/Bundle;)V", "GetOnFragmentSaveInstanceState_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_os_Bundle_Handler")]
			public unsafe virtual void OnFragmentSaveInstanceState(FragmentManager fm, Fragment f, Bundle outState)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((fm == null) ? IntPtr.Zero : fm.Handle);
					ptr[1] = new JniArgumentValue((f == null) ? IntPtr.Zero : f.Handle);
					ptr[2] = new JniArgumentValue((outState == null) ? IntPtr.Zero : outState.Handle);
					FragmentManager.FragmentLifecycleCallbacks._members.InstanceMethods.InvokeVirtualVoidMethod("onFragmentSaveInstanceState.(Landroidx/fragment/app/FragmentManager;Landroidx/fragment/app/Fragment;Landroid/os/Bundle;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(fm);
					GC.KeepAlive(f);
					GC.KeepAlive(outState);
				}
			}

			// Token: 0x06000350 RID: 848 RVA: 0x0000B018 File Offset: 0x00009218
			private static Delegate GetOnFragmentStarted_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Handler()
			{
				if (FragmentManager.FragmentLifecycleCallbacks.cb_onFragmentStarted_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_ == null)
				{
					FragmentManager.FragmentLifecycleCallbacks.cb_onFragmentStarted_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(FragmentManager.FragmentLifecycleCallbacks.n_OnFragmentStarted_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_));
				}
				return FragmentManager.FragmentLifecycleCallbacks.cb_onFragmentStarted_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_;
			}

			// Token: 0x06000351 RID: 849 RVA: 0x0000B03C File Offset: 0x0000923C
			private static void n_OnFragmentStarted_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_(IntPtr jnienv, IntPtr native__this, IntPtr native_fm, IntPtr native_f)
			{
				FragmentManager.FragmentLifecycleCallbacks @object = Java.Lang.Object.GetObject<FragmentManager.FragmentLifecycleCallbacks>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				FragmentManager object2 = Java.Lang.Object.GetObject<FragmentManager>(native_fm, JniHandleOwnership.DoNotTransfer);
				Fragment object3 = Java.Lang.Object.GetObject<Fragment>(native_f, JniHandleOwnership.DoNotTransfer);
				@object.OnFragmentStarted(object2, object3);
			}

			// Token: 0x06000352 RID: 850 RVA: 0x0000B068 File Offset: 0x00009268
			[Register("onFragmentStarted", "(Landroidx/fragment/app/FragmentManager;Landroidx/fragment/app/Fragment;)V", "GetOnFragmentStarted_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Handler")]
			public unsafe virtual void OnFragmentStarted(FragmentManager fm, Fragment f)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((fm == null) ? IntPtr.Zero : fm.Handle);
					ptr[1] = new JniArgumentValue((f == null) ? IntPtr.Zero : f.Handle);
					FragmentManager.FragmentLifecycleCallbacks._members.InstanceMethods.InvokeVirtualVoidMethod("onFragmentStarted.(Landroidx/fragment/app/FragmentManager;Landroidx/fragment/app/Fragment;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(fm);
					GC.KeepAlive(f);
				}
			}

			// Token: 0x06000353 RID: 851 RVA: 0x0000B0F4 File Offset: 0x000092F4
			private static Delegate GetOnFragmentStopped_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Handler()
			{
				if (FragmentManager.FragmentLifecycleCallbacks.cb_onFragmentStopped_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_ == null)
				{
					FragmentManager.FragmentLifecycleCallbacks.cb_onFragmentStopped_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(FragmentManager.FragmentLifecycleCallbacks.n_OnFragmentStopped_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_));
				}
				return FragmentManager.FragmentLifecycleCallbacks.cb_onFragmentStopped_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_;
			}

			// Token: 0x06000354 RID: 852 RVA: 0x0000B118 File Offset: 0x00009318
			private static void n_OnFragmentStopped_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_(IntPtr jnienv, IntPtr native__this, IntPtr native_fm, IntPtr native_f)
			{
				FragmentManager.FragmentLifecycleCallbacks @object = Java.Lang.Object.GetObject<FragmentManager.FragmentLifecycleCallbacks>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				FragmentManager object2 = Java.Lang.Object.GetObject<FragmentManager>(native_fm, JniHandleOwnership.DoNotTransfer);
				Fragment object3 = Java.Lang.Object.GetObject<Fragment>(native_f, JniHandleOwnership.DoNotTransfer);
				@object.OnFragmentStopped(object2, object3);
			}

			// Token: 0x06000355 RID: 853 RVA: 0x0000B144 File Offset: 0x00009344
			[Register("onFragmentStopped", "(Landroidx/fragment/app/FragmentManager;Landroidx/fragment/app/Fragment;)V", "GetOnFragmentStopped_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Handler")]
			public unsafe virtual void OnFragmentStopped(FragmentManager fm, Fragment f)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((fm == null) ? IntPtr.Zero : fm.Handle);
					ptr[1] = new JniArgumentValue((f == null) ? IntPtr.Zero : f.Handle);
					FragmentManager.FragmentLifecycleCallbacks._members.InstanceMethods.InvokeVirtualVoidMethod("onFragmentStopped.(Landroidx/fragment/app/FragmentManager;Landroidx/fragment/app/Fragment;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(fm);
					GC.KeepAlive(f);
				}
			}

			// Token: 0x06000356 RID: 854 RVA: 0x0000B1D0 File Offset: 0x000093D0
			private static Delegate GetOnFragmentViewCreated_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_view_View_Landroid_os_Bundle_Handler()
			{
				if (FragmentManager.FragmentLifecycleCallbacks.cb_onFragmentViewCreated_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_view_View_Landroid_os_Bundle_ == null)
				{
					FragmentManager.FragmentLifecycleCallbacks.cb_onFragmentViewCreated_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_view_View_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLL_V(FragmentManager.FragmentLifecycleCallbacks.n_OnFragmentViewCreated_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_view_View_Landroid_os_Bundle_));
				}
				return FragmentManager.FragmentLifecycleCallbacks.cb_onFragmentViewCreated_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_view_View_Landroid_os_Bundle_;
			}

			// Token: 0x06000357 RID: 855 RVA: 0x0000B1F4 File Offset: 0x000093F4
			private static void n_OnFragmentViewCreated_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_view_View_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_fm, IntPtr native_f, IntPtr native_v, IntPtr native_savedInstanceState)
			{
				FragmentManager.FragmentLifecycleCallbacks @object = Java.Lang.Object.GetObject<FragmentManager.FragmentLifecycleCallbacks>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				FragmentManager object2 = Java.Lang.Object.GetObject<FragmentManager>(native_fm, JniHandleOwnership.DoNotTransfer);
				Fragment object3 = Java.Lang.Object.GetObject<Fragment>(native_f, JniHandleOwnership.DoNotTransfer);
				View object4 = Java.Lang.Object.GetObject<View>(native_v, JniHandleOwnership.DoNotTransfer);
				Bundle object5 = Java.Lang.Object.GetObject<Bundle>(native_savedInstanceState, JniHandleOwnership.DoNotTransfer);
				@object.OnFragmentViewCreated(object2, object3, object4, object5);
			}

			// Token: 0x06000358 RID: 856 RVA: 0x0000B234 File Offset: 0x00009434
			[Register("onFragmentViewCreated", "(Landroidx/fragment/app/FragmentManager;Landroidx/fragment/app/Fragment;Landroid/view/View;Landroid/os/Bundle;)V", "GetOnFragmentViewCreated_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_view_View_Landroid_os_Bundle_Handler")]
			public unsafe virtual void OnFragmentViewCreated(FragmentManager fm, Fragment f, View v, Bundle savedInstanceState)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((fm == null) ? IntPtr.Zero : fm.Handle);
					ptr[1] = new JniArgumentValue((f == null) ? IntPtr.Zero : f.Handle);
					ptr[2] = new JniArgumentValue((v == null) ? IntPtr.Zero : v.Handle);
					ptr[3] = new JniArgumentValue((savedInstanceState == null) ? IntPtr.Zero : savedInstanceState.Handle);
					FragmentManager.FragmentLifecycleCallbacks._members.InstanceMethods.InvokeVirtualVoidMethod("onFragmentViewCreated.(Landroidx/fragment/app/FragmentManager;Landroidx/fragment/app/Fragment;Landroid/view/View;Landroid/os/Bundle;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(fm);
					GC.KeepAlive(f);
					GC.KeepAlive(v);
					GC.KeepAlive(savedInstanceState);
				}
			}

			// Token: 0x06000359 RID: 857 RVA: 0x0000B318 File Offset: 0x00009518
			private static Delegate GetOnFragmentViewDestroyed_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Handler()
			{
				if (FragmentManager.FragmentLifecycleCallbacks.cb_onFragmentViewDestroyed_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_ == null)
				{
					FragmentManager.FragmentLifecycleCallbacks.cb_onFragmentViewDestroyed_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(FragmentManager.FragmentLifecycleCallbacks.n_OnFragmentViewDestroyed_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_));
				}
				return FragmentManager.FragmentLifecycleCallbacks.cb_onFragmentViewDestroyed_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_;
			}

			// Token: 0x0600035A RID: 858 RVA: 0x0000B33C File Offset: 0x0000953C
			private static void n_OnFragmentViewDestroyed_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_(IntPtr jnienv, IntPtr native__this, IntPtr native_fm, IntPtr native_f)
			{
				FragmentManager.FragmentLifecycleCallbacks @object = Java.Lang.Object.GetObject<FragmentManager.FragmentLifecycleCallbacks>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				FragmentManager object2 = Java.Lang.Object.GetObject<FragmentManager>(native_fm, JniHandleOwnership.DoNotTransfer);
				Fragment object3 = Java.Lang.Object.GetObject<Fragment>(native_f, JniHandleOwnership.DoNotTransfer);
				@object.OnFragmentViewDestroyed(object2, object3);
			}

			// Token: 0x0600035B RID: 859 RVA: 0x0000B368 File Offset: 0x00009568
			[Register("onFragmentViewDestroyed", "(Landroidx/fragment/app/FragmentManager;Landroidx/fragment/app/Fragment;)V", "GetOnFragmentViewDestroyed_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Handler")]
			public unsafe virtual void OnFragmentViewDestroyed(FragmentManager fm, Fragment f)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((fm == null) ? IntPtr.Zero : fm.Handle);
					ptr[1] = new JniArgumentValue((f == null) ? IntPtr.Zero : f.Handle);
					FragmentManager.FragmentLifecycleCallbacks._members.InstanceMethods.InvokeVirtualVoidMethod("onFragmentViewDestroyed.(Landroidx/fragment/app/FragmentManager;Landroidx/fragment/app/Fragment;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(fm);
					GC.KeepAlive(f);
				}
			}

			// Token: 0x040000C3 RID: 195
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/fragment/app/FragmentManager$FragmentLifecycleCallbacks", typeof(FragmentManager.FragmentLifecycleCallbacks));

			// Token: 0x040000C4 RID: 196
			private static Delegate cb_onFragmentActivityCreated_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_os_Bundle_;

			// Token: 0x040000C5 RID: 197
			private static Delegate cb_onFragmentAttached_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_content_Context_;

			// Token: 0x040000C6 RID: 198
			private static Delegate cb_onFragmentCreated_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_os_Bundle_;

			// Token: 0x040000C7 RID: 199
			private static Delegate cb_onFragmentDestroyed_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_;

			// Token: 0x040000C8 RID: 200
			private static Delegate cb_onFragmentDetached_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_;

			// Token: 0x040000C9 RID: 201
			private static Delegate cb_onFragmentPaused_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_;

			// Token: 0x040000CA RID: 202
			private static Delegate cb_onFragmentPreAttached_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_content_Context_;

			// Token: 0x040000CB RID: 203
			private static Delegate cb_onFragmentPreCreated_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_os_Bundle_;

			// Token: 0x040000CC RID: 204
			private static Delegate cb_onFragmentResumed_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_;

			// Token: 0x040000CD RID: 205
			private static Delegate cb_onFragmentSaveInstanceState_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_os_Bundle_;

			// Token: 0x040000CE RID: 206
			private static Delegate cb_onFragmentStarted_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_;

			// Token: 0x040000CF RID: 207
			private static Delegate cb_onFragmentStopped_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_;

			// Token: 0x040000D0 RID: 208
			private static Delegate cb_onFragmentViewCreated_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Landroid_view_View_Landroid_os_Bundle_;

			// Token: 0x040000D1 RID: 209
			private static Delegate cb_onFragmentViewDestroyed_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_;
		}

		// Token: 0x02000034 RID: 52
		[Register("androidx/fragment/app/FragmentManager$FragmentLifecycleCallbacks", DoNotGenerateAcw = true)]
		internal class FragmentLifecycleCallbacksInvoker : FragmentManager.FragmentLifecycleCallbacks
		{
			// Token: 0x0600035D RID: 861 RVA: 0x0000B40F File Offset: 0x0000960F
			public FragmentLifecycleCallbacksInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
			{
			}

			// Token: 0x17000076 RID: 118
			// (get) Token: 0x0600035E RID: 862 RVA: 0x0000B419 File Offset: 0x00009619
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return FragmentManager.FragmentLifecycleCallbacksInvoker._members;
				}
			}

			// Token: 0x17000077 RID: 119
			// (get) Token: 0x0600035F RID: 863 RVA: 0x0000B420 File Offset: 0x00009620
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return FragmentManager.FragmentLifecycleCallbacksInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x040000D2 RID: 210
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/fragment/app/FragmentManager$FragmentLifecycleCallbacks", typeof(FragmentManager.FragmentLifecycleCallbacksInvoker));
		}

		// Token: 0x02000035 RID: 53
		[Register("androidx/fragment/app/FragmentManager$OnBackStackChangedListener", "", "AndroidX.Fragment.App.FragmentManager/IOnBackStackChangedListenerInvoker")]
		public interface IOnBackStackChangedListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000361 RID: 865
			[Register("onBackStackChanged", "()V", "GetOnBackStackChangedHandler:AndroidX.Fragment.App.FragmentManager/IOnBackStackChangedListenerInvoker, Xamarin.AndroidX.Fragment")]
			void OnBackStackChanged();

			// Token: 0x06000362 RID: 866 RVA: 0x0000B447 File Offset: 0x00009647
			private static Delegate GetOnBackStackChangeCommitted_Landroidx_fragment_app_Fragment_ZHandler()
			{
				if (FragmentManager.IOnBackStackChangedListener.cb_onBackStackChangeCommitted_Landroidx_fragment_app_Fragment_Z == null)
				{
					FragmentManager.IOnBackStackChangedListener.cb_onBackStackChangeCommitted_Landroidx_fragment_app_Fragment_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZ_V(FragmentManager.IOnBackStackChangedListener.n_OnBackStackChangeCommitted_Landroidx_fragment_app_Fragment_Z));
				}
				return FragmentManager.IOnBackStackChangedListener.cb_onBackStackChangeCommitted_Landroidx_fragment_app_Fragment_Z;
			}

			// Token: 0x06000363 RID: 867 RVA: 0x0000B46C File Offset: 0x0000966C
			private static void n_OnBackStackChangeCommitted_Landroidx_fragment_app_Fragment_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_fragment, bool pop)
			{
				FragmentManager.IOnBackStackChangedListener @object = Java.Lang.Object.GetObject<FragmentManager.IOnBackStackChangedListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Fragment object2 = Java.Lang.Object.GetObject<Fragment>(native_fragment, JniHandleOwnership.DoNotTransfer);
				@object.OnBackStackChangeCommitted(object2, pop);
			}

			// Token: 0x06000364 RID: 868 RVA: 0x0000B490 File Offset: 0x00009690
			[Register("onBackStackChangeCommitted", "(Landroidx/fragment/app/Fragment;Z)V", "GetOnBackStackChangeCommitted_Landroidx_fragment_app_Fragment_ZHandler:AndroidX.Fragment.App.FragmentManager/IOnBackStackChangedListener, Xamarin.AndroidX.Fragment")]
			unsafe void OnBackStackChangeCommitted(Fragment fragment, bool pop)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((fragment == null) ? IntPtr.Zero : fragment.Handle);
					ptr[1] = new JniArgumentValue(pop);
					FragmentManager.IOnBackStackChangedListener._members.InstanceMethods.InvokeVirtualVoidMethod("onBackStackChangeCommitted.(Landroidx/fragment/app/Fragment;Z)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(fragment);
				}
			}

			// Token: 0x06000365 RID: 869 RVA: 0x0000B508 File Offset: 0x00009708
			private static Delegate GetOnBackStackChangeStarted_Landroidx_fragment_app_Fragment_ZHandler()
			{
				if (FragmentManager.IOnBackStackChangedListener.cb_onBackStackChangeStarted_Landroidx_fragment_app_Fragment_Z == null)
				{
					FragmentManager.IOnBackStackChangedListener.cb_onBackStackChangeStarted_Landroidx_fragment_app_Fragment_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZ_V(FragmentManager.IOnBackStackChangedListener.n_OnBackStackChangeStarted_Landroidx_fragment_app_Fragment_Z));
				}
				return FragmentManager.IOnBackStackChangedListener.cb_onBackStackChangeStarted_Landroidx_fragment_app_Fragment_Z;
			}

			// Token: 0x06000366 RID: 870 RVA: 0x0000B52C File Offset: 0x0000972C
			private static void n_OnBackStackChangeStarted_Landroidx_fragment_app_Fragment_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_fragment, bool pop)
			{
				FragmentManager.IOnBackStackChangedListener @object = Java.Lang.Object.GetObject<FragmentManager.IOnBackStackChangedListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Fragment object2 = Java.Lang.Object.GetObject<Fragment>(native_fragment, JniHandleOwnership.DoNotTransfer);
				@object.OnBackStackChangeStarted(object2, pop);
			}

			// Token: 0x06000367 RID: 871 RVA: 0x0000B550 File Offset: 0x00009750
			[Register("onBackStackChangeStarted", "(Landroidx/fragment/app/Fragment;Z)V", "GetOnBackStackChangeStarted_Landroidx_fragment_app_Fragment_ZHandler:AndroidX.Fragment.App.FragmentManager/IOnBackStackChangedListener, Xamarin.AndroidX.Fragment")]
			unsafe void OnBackStackChangeStarted(Fragment fragment, bool pop)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((fragment == null) ? IntPtr.Zero : fragment.Handle);
					ptr[1] = new JniArgumentValue(pop);
					FragmentManager.IOnBackStackChangedListener._members.InstanceMethods.InvokeVirtualVoidMethod("onBackStackChangeStarted.(Landroidx/fragment/app/Fragment;Z)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(fragment);
				}
			}

			// Token: 0x040000D3 RID: 211
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/fragment/app/FragmentManager$OnBackStackChangedListener", typeof(FragmentManager.IOnBackStackChangedListener), true);

			// Token: 0x040000D4 RID: 212
			private static Delegate cb_onBackStackChangeCommitted_Landroidx_fragment_app_Fragment_Z;

			// Token: 0x040000D5 RID: 213
			private static Delegate cb_onBackStackChangeStarted_Landroidx_fragment_app_Fragment_Z;
		}

		// Token: 0x02000036 RID: 54
		[Register("androidx/fragment/app/FragmentManager$OnBackStackChangedListener", DoNotGenerateAcw = true)]
		internal class IOnBackStackChangedListenerInvoker : Java.Lang.Object, FragmentManager.IOnBackStackChangedListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000078 RID: 120
			// (get) Token: 0x06000369 RID: 873 RVA: 0x0000B5E4 File Offset: 0x000097E4
			private static IntPtr java_class_ref
			{
				get
				{
					return FragmentManager.IOnBackStackChangedListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000079 RID: 121
			// (get) Token: 0x0600036A RID: 874 RVA: 0x0000B608 File Offset: 0x00009808
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return FragmentManager.IOnBackStackChangedListenerInvoker._members;
				}
			}

			// Token: 0x1700007A RID: 122
			// (get) Token: 0x0600036B RID: 875 RVA: 0x0000B60F File Offset: 0x0000980F
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x1700007B RID: 123
			// (get) Token: 0x0600036C RID: 876 RVA: 0x0000B617 File Offset: 0x00009817
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return FragmentManager.IOnBackStackChangedListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x0600036D RID: 877 RVA: 0x0000B623 File Offset: 0x00009823
			public static FragmentManager.IOnBackStackChangedListener GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<FragmentManager.IOnBackStackChangedListener>(handle, transfer);
			}

			// Token: 0x0600036E RID: 878 RVA: 0x0000B62C File Offset: 0x0000982C
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, FragmentManager.IOnBackStackChangedListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.fragment.app.FragmentManager.OnBackStackChangedListener'.");
				}
				return handle;
			}

			// Token: 0x0600036F RID: 879 RVA: 0x0000B657 File Offset: 0x00009857
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000370 RID: 880 RVA: 0x0000B688 File Offset: 0x00009888
			public IOnBackStackChangedListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(FragmentManager.IOnBackStackChangedListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000371 RID: 881 RVA: 0x0000B6C0 File Offset: 0x000098C0
			private static Delegate GetOnBackStackChangedHandler()
			{
				if (FragmentManager.IOnBackStackChangedListenerInvoker.cb_onBackStackChanged == null)
				{
					FragmentManager.IOnBackStackChangedListenerInvoker.cb_onBackStackChanged = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(FragmentManager.IOnBackStackChangedListenerInvoker.n_OnBackStackChanged));
				}
				return FragmentManager.IOnBackStackChangedListenerInvoker.cb_onBackStackChanged;
			}

			// Token: 0x06000372 RID: 882 RVA: 0x0000B6E4 File Offset: 0x000098E4
			private static void n_OnBackStackChanged(IntPtr jnienv, IntPtr native__this)
			{
				Java.Lang.Object.GetObject<FragmentManager.IOnBackStackChangedListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnBackStackChanged();
			}

			// Token: 0x06000373 RID: 883 RVA: 0x0000B6F3 File Offset: 0x000098F3
			public void OnBackStackChanged()
			{
				if (this.id_onBackStackChanged == IntPtr.Zero)
				{
					this.id_onBackStackChanged = JNIEnv.GetMethodID(this.class_ref, "onBackStackChanged", "()V");
				}
				JNIEnv.CallVoidMethod(base.Handle, this.id_onBackStackChanged);
			}

			// Token: 0x040000D6 RID: 214
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/fragment/app/FragmentManager$OnBackStackChangedListener", typeof(FragmentManager.IOnBackStackChangedListenerInvoker));

			// Token: 0x040000D7 RID: 215
			private IntPtr class_ref;

			// Token: 0x040000D8 RID: 216
			private static Delegate cb_onBackStackChanged;

			// Token: 0x040000D9 RID: 217
			private IntPtr id_onBackStackChanged;
		}

		// Token: 0x02000037 RID: 55
		public class BackStackChangeCommittedEventArgs : EventArgs
		{
			// Token: 0x06000375 RID: 885 RVA: 0x0000B74E File Offset: 0x0000994E
			public BackStackChangeCommittedEventArgs(Fragment fragment, bool pop)
			{
				this.fragment = fragment;
				this.pop = pop;
			}

			// Token: 0x040000DA RID: 218
			private Fragment fragment;

			// Token: 0x040000DB RID: 219
			private bool pop;
		}

		// Token: 0x02000038 RID: 56
		public class BackStackChangeStartedEventArgs : EventArgs
		{
			// Token: 0x06000376 RID: 886 RVA: 0x0000B764 File Offset: 0x00009964
			public BackStackChangeStartedEventArgs(Fragment fragment, bool pop)
			{
				this.fragment = fragment;
				this.pop = pop;
			}

			// Token: 0x040000DC RID: 220
			private Fragment fragment;

			// Token: 0x040000DD RID: 221
			private bool pop;
		}

		// Token: 0x02000039 RID: 57
		[Register("mono/androidx/fragment/app/FragmentManager_OnBackStackChangedListenerImplementor")]
		internal sealed class IOnBackStackChangedListenerImplementor : Java.Lang.Object, FragmentManager.IOnBackStackChangedListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000377 RID: 887 RVA: 0x0000B77A File Offset: 0x0000997A
			public IOnBackStackChangedListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/androidx/fragment/app/FragmentManager_OnBackStackChangedListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
			{
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				this.sender = sender;
			}

			// Token: 0x06000378 RID: 888 RVA: 0x0000B7B4 File Offset: 0x000099B4
			public void OnBackStackChangeCommitted(Fragment fragment, bool pop)
			{
				EventHandler<FragmentManager.BackStackChangeCommittedEventArgs> onBackStackChangeCommittedHandler = this.OnBackStackChangeCommittedHandler;
				if (onBackStackChangeCommittedHandler != null)
				{
					onBackStackChangeCommittedHandler(this.sender, new FragmentManager.BackStackChangeCommittedEventArgs(fragment, pop));
				}
			}

			// Token: 0x06000379 RID: 889 RVA: 0x0000B7E0 File Offset: 0x000099E0
			public void OnBackStackChangeStarted(Fragment fragment, bool pop)
			{
				EventHandler<FragmentManager.BackStackChangeStartedEventArgs> onBackStackChangeStartedHandler = this.OnBackStackChangeStartedHandler;
				if (onBackStackChangeStartedHandler != null)
				{
					onBackStackChangeStartedHandler(this.sender, new FragmentManager.BackStackChangeStartedEventArgs(fragment, pop));
				}
			}

			// Token: 0x0600037A RID: 890 RVA: 0x0000B80C File Offset: 0x00009A0C
			public void OnBackStackChanged()
			{
				EventHandler onBackStackChangedHandler = this.OnBackStackChangedHandler;
				if (onBackStackChangedHandler != null)
				{
					onBackStackChangedHandler(this.sender, new EventArgs());
				}
			}

			// Token: 0x0600037B RID: 891 RVA: 0x0000B834 File Offset: 0x00009A34
			internal static bool __IsEmpty(FragmentManager.IOnBackStackChangedListenerImplementor value)
			{
				return value.OnBackStackChangeCommittedHandler == null && value.OnBackStackChangeStartedHandler == null && value.OnBackStackChangedHandler == null;
			}

			// Token: 0x040000DE RID: 222
			private object sender;

			// Token: 0x040000DF RID: 223
			public EventHandler<FragmentManager.BackStackChangeCommittedEventArgs> OnBackStackChangeCommittedHandler;

			// Token: 0x040000E0 RID: 224
			public EventHandler<FragmentManager.BackStackChangeStartedEventArgs> OnBackStackChangeStartedHandler;

			// Token: 0x040000E1 RID: 225
			public EventHandler OnBackStackChangedHandler;
		}

		// Token: 0x0200003A RID: 58
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040000E2 RID: 226
			public static Func<IFragmentOnAttachListenerImplementor, bool> <0>____IsEmpty;

			// Token: 0x040000E3 RID: 227
			public static Func<FragmentManager.IOnBackStackChangedListenerImplementor, bool> <1>____IsEmpty;
		}
	}
}
