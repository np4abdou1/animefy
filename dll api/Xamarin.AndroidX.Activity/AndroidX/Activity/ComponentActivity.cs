using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Content;
using Android.Runtime;
using AndroidX.Activity.ContextAware;
using AndroidX.Activity.Result;
using AndroidX.Activity.Result.Contract;
using AndroidX.Core.App;
using AndroidX.Core.Content;
using AndroidX.Core.Util;
using AndroidX.Core.View;
using AndroidX.Lifecycle;
using AndroidX.Lifecycle.ViewModels;
using AndroidX.SavedState;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Activity
{
	// Token: 0x0200000E RID: 14
	[Register("androidx/activity/ComponentActivity", DoNotGenerateAcw = true)]
	public class ComponentActivity : ComponentActivity, IFullyDrawnReporterOwner, IJavaObject, IDisposable, IJavaPeerable, IOnBackPressedDispatcherOwner, ILifecycleOwner, IContextAware, IActivityResultCaller, IActivityResultRegistryOwner, IOnMultiWindowModeChangedProvider, IOnNewIntentProvider, IOnPictureInPictureModeChangedProvider, IOnConfigurationChangedProvider, IOnTrimMemoryProvider, IMenuHost, IHasDefaultViewModelProviderFactory, IViewModelStoreOwner, ISavedStateRegistryOwner
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00002080 File Offset: 0x00000280
		internal static IntPtr class_ref
		{
			get
			{
				return ComponentActivity._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000029 RID: 41 RVA: 0x000020A4 File Offset: 0x000002A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ComponentActivity._members;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600002A RID: 42 RVA: 0x000020AC File Offset: 0x000002AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ComponentActivity._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600002B RID: 43 RVA: 0x000020D0 File Offset: 0x000002D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ComponentActivity._members.ManagedPeerType;
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000020DC File Offset: 0x000002DC
		protected ComponentActivity(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000020E8 File Offset: 0x000002E8
		[Register(".ctor", "()V", "")]
		public ComponentActivity() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(ComponentActivity._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			ComponentActivity._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002158 File Offset: 0x00000358
		[Register(".ctor", "(I)V", "")]
		public unsafe ComponentActivity(int contentLayoutId) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(contentLayoutId);
			base.SetHandle(ComponentActivity._members.InstanceMethods.StartCreateInstance("(I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			ComponentActivity._members.InstanceMethods.FinishCreateInstance("(I)V", this, ptr);
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600002F RID: 47 RVA: 0x000021DC File Offset: 0x000003DC
		public ActivityResultRegistry ActivityResultRegistry
		{
			[Register("getActivityResultRegistry", "()Landroidx/activity/result/ActivityResultRegistry;", "")]
			get
			{
				return Java.Lang.Object.GetObject<ActivityResultRegistry>(ComponentActivity._members.InstanceMethods.InvokeNonvirtualObjectMethod("getActivityResultRegistry.()Landroidx/activity/result/ActivityResultRegistry;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000220E File Offset: 0x0000040E
		private static Delegate GetGetDefaultViewModelCreationExtrasHandler()
		{
			if (ComponentActivity.cb_getDefaultViewModelCreationExtras == null)
			{
				ComponentActivity.cb_getDefaultViewModelCreationExtras = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ComponentActivity.n_GetDefaultViewModelCreationExtras));
			}
			return ComponentActivity.cb_getDefaultViewModelCreationExtras;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002232 File Offset: 0x00000432
		private static IntPtr n_GetDefaultViewModelCreationExtras(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ComponentActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DefaultViewModelCreationExtras);
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00002248 File Offset: 0x00000448
		public virtual CreationExtras DefaultViewModelCreationExtras
		{
			[Register("getDefaultViewModelCreationExtras", "()Landroidx/lifecycle/viewmodel/CreationExtras;", "GetGetDefaultViewModelCreationExtrasHandler")]
			get
			{
				return Java.Lang.Object.GetObject<CreationExtras>(ComponentActivity._members.InstanceMethods.InvokeVirtualObjectMethod("getDefaultViewModelCreationExtras.()Landroidx/lifecycle/viewmodel/CreationExtras;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000227A File Offset: 0x0000047A
		private static Delegate GetGetDefaultViewModelProviderFactoryHandler()
		{
			if (ComponentActivity.cb_getDefaultViewModelProviderFactory == null)
			{
				ComponentActivity.cb_getDefaultViewModelProviderFactory = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ComponentActivity.n_GetDefaultViewModelProviderFactory));
			}
			return ComponentActivity.cb_getDefaultViewModelProviderFactory;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000229E File Offset: 0x0000049E
		private static IntPtr n_GetDefaultViewModelProviderFactory(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ComponentActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DefaultViewModelProviderFactory);
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000035 RID: 53 RVA: 0x000022B4 File Offset: 0x000004B4
		public virtual ViewModelProvider.IFactory DefaultViewModelProviderFactory
		{
			[Register("getDefaultViewModelProviderFactory", "()Landroidx/lifecycle/ViewModelProvider$Factory;", "GetGetDefaultViewModelProviderFactoryHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ViewModelProvider.IFactory>(ComponentActivity._members.InstanceMethods.InvokeVirtualObjectMethod("getDefaultViewModelProviderFactory.()Landroidx/lifecycle/ViewModelProvider$Factory;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000022E6 File Offset: 0x000004E6
		private static Delegate GetGetFullyDrawnReporterHandler()
		{
			if (ComponentActivity.cb_getFullyDrawnReporter == null)
			{
				ComponentActivity.cb_getFullyDrawnReporter = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ComponentActivity.n_GetFullyDrawnReporter));
			}
			return ComponentActivity.cb_getFullyDrawnReporter;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0000230A File Offset: 0x0000050A
		private static IntPtr n_GetFullyDrawnReporter(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ComponentActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FullyDrawnReporter);
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00002320 File Offset: 0x00000520
		public virtual FullyDrawnReporter FullyDrawnReporter
		{
			[Register("getFullyDrawnReporter", "()Landroidx/activity/FullyDrawnReporter;", "GetGetFullyDrawnReporterHandler")]
			get
			{
				return Java.Lang.Object.GetObject<FullyDrawnReporter>(ComponentActivity._members.InstanceMethods.InvokeVirtualObjectMethod("getFullyDrawnReporter.()Landroidx/activity/FullyDrawnReporter;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002352 File Offset: 0x00000552
		private static Delegate GetGetLastCustomNonConfigurationInstanceHandler()
		{
			if (ComponentActivity.cb_getLastCustomNonConfigurationInstance == null)
			{
				ComponentActivity.cb_getLastCustomNonConfigurationInstance = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ComponentActivity.n_GetLastCustomNonConfigurationInstance));
			}
			return ComponentActivity.cb_getLastCustomNonConfigurationInstance;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002376 File Offset: 0x00000576
		private static IntPtr n_GetLastCustomNonConfigurationInstance(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ComponentActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LastCustomNonConfigurationInstance);
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600003B RID: 59 RVA: 0x0000238C File Offset: 0x0000058C
		public virtual Java.Lang.Object LastCustomNonConfigurationInstance
		{
			[Register("getLastCustomNonConfigurationInstance", "()Ljava/lang/Object;", "GetGetLastCustomNonConfigurationInstanceHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Object>(ComponentActivity._members.InstanceMethods.InvokeVirtualObjectMethod("getLastCustomNonConfigurationInstance.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600003C RID: 60 RVA: 0x000023C0 File Offset: 0x000005C0
		public OnBackPressedDispatcher OnBackPressedDispatcher
		{
			[Register("getOnBackPressedDispatcher", "()Landroidx/activity/OnBackPressedDispatcher;", "")]
			get
			{
				return Java.Lang.Object.GetObject<OnBackPressedDispatcher>(ComponentActivity._members.InstanceMethods.InvokeNonvirtualObjectMethod("getOnBackPressedDispatcher.()Landroidx/activity/OnBackPressedDispatcher;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600003D RID: 61 RVA: 0x000023F4 File Offset: 0x000005F4
		public SavedStateRegistry SavedStateRegistry
		{
			[Register("getSavedStateRegistry", "()Landroidx/savedstate/SavedStateRegistry;", "")]
			get
			{
				return Java.Lang.Object.GetObject<SavedStateRegistry>(ComponentActivity._members.InstanceMethods.InvokeNonvirtualObjectMethod("getSavedStateRegistry.()Landroidx/savedstate/SavedStateRegistry;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002426 File Offset: 0x00000626
		private static Delegate GetGetViewModelStoreHandler()
		{
			if (ComponentActivity.cb_getViewModelStore == null)
			{
				ComponentActivity.cb_getViewModelStore = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ComponentActivity.n_GetViewModelStore));
			}
			return ComponentActivity.cb_getViewModelStore;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000244A File Offset: 0x0000064A
		private static IntPtr n_GetViewModelStore(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ComponentActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ViewModelStore);
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00002460 File Offset: 0x00000660
		public virtual ViewModelStore ViewModelStore
		{
			[Register("getViewModelStore", "()Landroidx/lifecycle/ViewModelStore;", "GetGetViewModelStoreHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ViewModelStore>(ComponentActivity._members.InstanceMethods.InvokeVirtualObjectMethod("getViewModelStore.()Landroidx/lifecycle/ViewModelStore;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002492 File Offset: 0x00000692
		private static Delegate GetAddMenuProvider_Landroidx_core_view_MenuProvider_Handler()
		{
			if (ComponentActivity.cb_addMenuProvider_Landroidx_core_view_MenuProvider_ == null)
			{
				ComponentActivity.cb_addMenuProvider_Landroidx_core_view_MenuProvider_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ComponentActivity.n_AddMenuProvider_Landroidx_core_view_MenuProvider_));
			}
			return ComponentActivity.cb_addMenuProvider_Landroidx_core_view_MenuProvider_;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000024B8 File Offset: 0x000006B8
		private static void n_AddMenuProvider_Landroidx_core_view_MenuProvider_(IntPtr jnienv, IntPtr native__this, IntPtr native_provider)
		{
			ComponentActivity @object = Java.Lang.Object.GetObject<ComponentActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMenuProvider object2 = Java.Lang.Object.GetObject<IMenuProvider>(native_provider, JniHandleOwnership.DoNotTransfer);
			@object.AddMenuProvider(object2);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000024DC File Offset: 0x000006DC
		[Register("addMenuProvider", "(Landroidx/core/view/MenuProvider;)V", "GetAddMenuProvider_Landroidx_core_view_MenuProvider_Handler")]
		public unsafe virtual void AddMenuProvider(IMenuProvider provider)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((provider == null) ? IntPtr.Zero : ((Java.Lang.Object)provider).Handle);
				ComponentActivity._members.InstanceMethods.InvokeVirtualVoidMethod("addMenuProvider.(Landroidx/core/view/MenuProvider;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(provider);
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002544 File Offset: 0x00000744
		private static Delegate GetAddMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_Handler()
		{
			if (ComponentActivity.cb_addMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_ == null)
			{
				ComponentActivity.cb_addMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(ComponentActivity.n_AddMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_));
			}
			return ComponentActivity.cb_addMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002568 File Offset: 0x00000768
		private static void n_AddMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_(IntPtr jnienv, IntPtr native__this, IntPtr native_provider, IntPtr native_owner)
		{
			ComponentActivity @object = Java.Lang.Object.GetObject<ComponentActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMenuProvider object2 = Java.Lang.Object.GetObject<IMenuProvider>(native_provider, JniHandleOwnership.DoNotTransfer);
			ILifecycleOwner object3 = Java.Lang.Object.GetObject<ILifecycleOwner>(native_owner, JniHandleOwnership.DoNotTransfer);
			@object.AddMenuProvider(object2, object3);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002594 File Offset: 0x00000794
		[Register("addMenuProvider", "(Landroidx/core/view/MenuProvider;Landroidx/lifecycle/LifecycleOwner;)V", "GetAddMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_Handler")]
		public unsafe virtual void AddMenuProvider(IMenuProvider provider, ILifecycleOwner owner)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((provider == null) ? IntPtr.Zero : ((Java.Lang.Object)provider).Handle);
				ptr[1] = new JniArgumentValue((owner == null) ? IntPtr.Zero : ((Java.Lang.Object)owner).Handle);
				ComponentActivity._members.InstanceMethods.InvokeVirtualVoidMethod("addMenuProvider.(Landroidx/core/view/MenuProvider;Landroidx/lifecycle/LifecycleOwner;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(provider);
				GC.KeepAlive(owner);
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000262C File Offset: 0x0000082C
		private static Delegate GetAddMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_Landroidx_lifecycle_Lifecycle_State_Handler()
		{
			if (ComponentActivity.cb_addMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_Landroidx_lifecycle_Lifecycle_State_ == null)
			{
				ComponentActivity.cb_addMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_Landroidx_lifecycle_Lifecycle_State_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(ComponentActivity.n_AddMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_Landroidx_lifecycle_Lifecycle_State_));
			}
			return ComponentActivity.cb_addMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_Landroidx_lifecycle_Lifecycle_State_;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002650 File Offset: 0x00000850
		private static void n_AddMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_Landroidx_lifecycle_Lifecycle_State_(IntPtr jnienv, IntPtr native__this, IntPtr native_provider, IntPtr native_owner, IntPtr native_state)
		{
			ComponentActivity @object = Java.Lang.Object.GetObject<ComponentActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMenuProvider object2 = Java.Lang.Object.GetObject<IMenuProvider>(native_provider, JniHandleOwnership.DoNotTransfer);
			ILifecycleOwner object3 = Java.Lang.Object.GetObject<ILifecycleOwner>(native_owner, JniHandleOwnership.DoNotTransfer);
			Lifecycle.State object4 = Java.Lang.Object.GetObject<Lifecycle.State>(native_state, JniHandleOwnership.DoNotTransfer);
			@object.AddMenuProvider(object2, object3, object4);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002688 File Offset: 0x00000888
		[Register("addMenuProvider", "(Landroidx/core/view/MenuProvider;Landroidx/lifecycle/LifecycleOwner;Landroidx/lifecycle/Lifecycle$State;)V", "GetAddMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_Landroidx_lifecycle_Lifecycle_State_Handler")]
		public unsafe virtual void AddMenuProvider(IMenuProvider provider, ILifecycleOwner owner, Lifecycle.State state)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((provider == null) ? IntPtr.Zero : ((Java.Lang.Object)provider).Handle);
				ptr[1] = new JniArgumentValue((owner == null) ? IntPtr.Zero : ((Java.Lang.Object)owner).Handle);
				ptr[2] = new JniArgumentValue((state == null) ? IntPtr.Zero : state.Handle);
				ComponentActivity._members.InstanceMethods.InvokeVirtualVoidMethod("addMenuProvider.(Landroidx/core/view/MenuProvider;Landroidx/lifecycle/LifecycleOwner;Landroidx/lifecycle/Lifecycle$State;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(provider);
				GC.KeepAlive(owner);
				GC.KeepAlive(state);
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002748 File Offset: 0x00000948
		[Register("addOnConfigurationChangedListener", "(Landroidx/core/util/Consumer;)V", "")]
		public unsafe void AddOnConfigurationChangedListener(IConsumer listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				ComponentActivity._members.InstanceMethods.InvokeNonvirtualVoidMethod("addOnConfigurationChangedListener.(Landroidx/core/util/Consumer;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000027B0 File Offset: 0x000009B0
		[Register("addOnContextAvailableListener", "(Landroidx/activity/contextaware/OnContextAvailableListener;)V", "")]
		public unsafe void AddOnContextAvailableListener(IOnContextAvailableListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				ComponentActivity._members.InstanceMethods.InvokeNonvirtualVoidMethod("addOnContextAvailableListener.(Landroidx/activity/contextaware/OnContextAvailableListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002818 File Offset: 0x00000A18
		[Register("addOnMultiWindowModeChangedListener", "(Landroidx/core/util/Consumer;)V", "")]
		public unsafe void AddOnMultiWindowModeChangedListener(IConsumer listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				ComponentActivity._members.InstanceMethods.InvokeNonvirtualVoidMethod("addOnMultiWindowModeChangedListener.(Landroidx/core/util/Consumer;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002880 File Offset: 0x00000A80
		[Register("addOnNewIntentListener", "(Landroidx/core/util/Consumer;)V", "")]
		public unsafe void AddOnNewIntentListener(IConsumer listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				ComponentActivity._members.InstanceMethods.InvokeNonvirtualVoidMethod("addOnNewIntentListener.(Landroidx/core/util/Consumer;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000028E8 File Offset: 0x00000AE8
		[Register("addOnPictureInPictureModeChangedListener", "(Landroidx/core/util/Consumer;)V", "")]
		public unsafe void AddOnPictureInPictureModeChangedListener(IConsumer listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				ComponentActivity._members.InstanceMethods.InvokeNonvirtualVoidMethod("addOnPictureInPictureModeChangedListener.(Landroidx/core/util/Consumer;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002950 File Offset: 0x00000B50
		[Register("addOnTrimMemoryListener", "(Landroidx/core/util/Consumer;)V", "")]
		public unsafe void AddOnTrimMemoryListener(IConsumer listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				ComponentActivity._members.InstanceMethods.InvokeNonvirtualVoidMethod("addOnTrimMemoryListener.(Landroidx/core/util/Consumer;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000029B8 File Offset: 0x00000BB8
		private static Delegate GetInvalidateMenuHandler()
		{
			if (ComponentActivity.cb_invalidateMenu == null)
			{
				ComponentActivity.cb_invalidateMenu = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ComponentActivity.n_InvalidateMenu));
			}
			return ComponentActivity.cb_invalidateMenu;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000029DC File Offset: 0x00000BDC
		private static void n_InvalidateMenu(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ComponentActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).InvalidateMenu();
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000029EB File Offset: 0x00000BEB
		[Register("invalidateMenu", "()V", "GetInvalidateMenuHandler")]
		public virtual void InvalidateMenu()
		{
			ComponentActivity._members.InstanceMethods.InvokeVirtualVoidMethod("invalidateMenu.()V", this, null);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002A04 File Offset: 0x00000C04
		private static Delegate GetOnRetainCustomNonConfigurationInstanceHandler()
		{
			if (ComponentActivity.cb_onRetainCustomNonConfigurationInstance == null)
			{
				ComponentActivity.cb_onRetainCustomNonConfigurationInstance = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ComponentActivity.n_OnRetainCustomNonConfigurationInstance));
			}
			return ComponentActivity.cb_onRetainCustomNonConfigurationInstance;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002A28 File Offset: 0x00000C28
		private static IntPtr n_OnRetainCustomNonConfigurationInstance(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ComponentActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnRetainCustomNonConfigurationInstance());
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002A3C File Offset: 0x00000C3C
		[Register("onRetainCustomNonConfigurationInstance", "()Ljava/lang/Object;", "GetOnRetainCustomNonConfigurationInstanceHandler")]
		public virtual Java.Lang.Object OnRetainCustomNonConfigurationInstance()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(ComponentActivity._members.InstanceMethods.InvokeVirtualObjectMethod("onRetainCustomNonConfigurationInstance.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002A70 File Offset: 0x00000C70
		[Register("onRetainNonConfigurationInstance", "()Ljava/lang/Object;", "")]
		public sealed override Java.Lang.Object OnRetainNonConfigurationInstance()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(ComponentActivity._members.InstanceMethods.InvokeNonvirtualObjectMethod("onRetainNonConfigurationInstance.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002AA2 File Offset: 0x00000CA2
		private static Delegate GetPeekAvailableContextHandler()
		{
			if (ComponentActivity.cb_peekAvailableContext == null)
			{
				ComponentActivity.cb_peekAvailableContext = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ComponentActivity.n_PeekAvailableContext));
			}
			return ComponentActivity.cb_peekAvailableContext;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002AC6 File Offset: 0x00000CC6
		private static IntPtr n_PeekAvailableContext(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ComponentActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PeekAvailableContext());
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002ADC File Offset: 0x00000CDC
		[Register("peekAvailableContext", "()Landroid/content/Context;", "GetPeekAvailableContextHandler")]
		public virtual Context PeekAvailableContext()
		{
			return Java.Lang.Object.GetObject<Context>(ComponentActivity._members.InstanceMethods.InvokeVirtualObjectMethod("peekAvailableContext.()Landroid/content/Context;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002B10 File Offset: 0x00000D10
		[Register("registerForActivityResult", "(Landroidx/activity/result/contract/ActivityResultContract;Landroidx/activity/result/ActivityResultCallback;)Landroidx/activity/result/ActivityResultLauncher;", "")]
		[JavaTypeParameters(new string[]
		{
			"I",
			"O"
		})]
		public unsafe ActivityResultLauncher RegisterForActivityResult(ActivityResultContract contract, IActivityResultCallback callback)
		{
			ActivityResultLauncher @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((contract == null) ? IntPtr.Zero : contract.Handle);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : ((Java.Lang.Object)callback).Handle);
				@object = Java.Lang.Object.GetObject<ActivityResultLauncher>(ComponentActivity._members.InstanceMethods.InvokeNonvirtualObjectMethod("registerForActivityResult.(Landroidx/activity/result/contract/ActivityResultContract;Landroidx/activity/result/ActivityResultCallback;)Landroidx/activity/result/ActivityResultLauncher;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(contract);
				GC.KeepAlive(callback);
			}
			return @object;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002BB0 File Offset: 0x00000DB0
		[Register("registerForActivityResult", "(Landroidx/activity/result/contract/ActivityResultContract;Landroidx/activity/result/ActivityResultRegistry;Landroidx/activity/result/ActivityResultCallback;)Landroidx/activity/result/ActivityResultLauncher;", "")]
		[JavaTypeParameters(new string[]
		{
			"I",
			"O"
		})]
		public unsafe ActivityResultLauncher RegisterForActivityResult(ActivityResultContract contract, ActivityResultRegistry registry, IActivityResultCallback callback)
		{
			ActivityResultLauncher @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((contract == null) ? IntPtr.Zero : contract.Handle);
				ptr[1] = new JniArgumentValue((registry == null) ? IntPtr.Zero : registry.Handle);
				ptr[2] = new JniArgumentValue((callback == null) ? IntPtr.Zero : ((Java.Lang.Object)callback).Handle);
				@object = Java.Lang.Object.GetObject<ActivityResultLauncher>(ComponentActivity._members.InstanceMethods.InvokeNonvirtualObjectMethod("registerForActivityResult.(Landroidx/activity/result/contract/ActivityResultContract;Landroidx/activity/result/ActivityResultRegistry;Landroidx/activity/result/ActivityResultCallback;)Landroidx/activity/result/ActivityResultLauncher;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(contract);
				GC.KeepAlive(registry);
				GC.KeepAlive(callback);
			}
			return @object;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002C7C File Offset: 0x00000E7C
		private static Delegate GetRemoveMenuProvider_Landroidx_core_view_MenuProvider_Handler()
		{
			if (ComponentActivity.cb_removeMenuProvider_Landroidx_core_view_MenuProvider_ == null)
			{
				ComponentActivity.cb_removeMenuProvider_Landroidx_core_view_MenuProvider_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ComponentActivity.n_RemoveMenuProvider_Landroidx_core_view_MenuProvider_));
			}
			return ComponentActivity.cb_removeMenuProvider_Landroidx_core_view_MenuProvider_;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002CA0 File Offset: 0x00000EA0
		private static void n_RemoveMenuProvider_Landroidx_core_view_MenuProvider_(IntPtr jnienv, IntPtr native__this, IntPtr native_provider)
		{
			ComponentActivity @object = Java.Lang.Object.GetObject<ComponentActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMenuProvider object2 = Java.Lang.Object.GetObject<IMenuProvider>(native_provider, JniHandleOwnership.DoNotTransfer);
			@object.RemoveMenuProvider(object2);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002CC4 File Offset: 0x00000EC4
		[Register("removeMenuProvider", "(Landroidx/core/view/MenuProvider;)V", "GetRemoveMenuProvider_Landroidx_core_view_MenuProvider_Handler")]
		public unsafe virtual void RemoveMenuProvider(IMenuProvider provider)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((provider == null) ? IntPtr.Zero : ((Java.Lang.Object)provider).Handle);
				ComponentActivity._members.InstanceMethods.InvokeVirtualVoidMethod("removeMenuProvider.(Landroidx/core/view/MenuProvider;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(provider);
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002D2C File Offset: 0x00000F2C
		[Register("removeOnConfigurationChangedListener", "(Landroidx/core/util/Consumer;)V", "")]
		public unsafe void RemoveOnConfigurationChangedListener(IConsumer listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				ComponentActivity._members.InstanceMethods.InvokeNonvirtualVoidMethod("removeOnConfigurationChangedListener.(Landroidx/core/util/Consumer;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002D94 File Offset: 0x00000F94
		[Register("removeOnContextAvailableListener", "(Landroidx/activity/contextaware/OnContextAvailableListener;)V", "")]
		public unsafe void RemoveOnContextAvailableListener(IOnContextAvailableListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				ComponentActivity._members.InstanceMethods.InvokeNonvirtualVoidMethod("removeOnContextAvailableListener.(Landroidx/activity/contextaware/OnContextAvailableListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002DFC File Offset: 0x00000FFC
		[Register("removeOnMultiWindowModeChangedListener", "(Landroidx/core/util/Consumer;)V", "")]
		public unsafe void RemoveOnMultiWindowModeChangedListener(IConsumer listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				ComponentActivity._members.InstanceMethods.InvokeNonvirtualVoidMethod("removeOnMultiWindowModeChangedListener.(Landroidx/core/util/Consumer;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002E64 File Offset: 0x00001064
		[Register("removeOnNewIntentListener", "(Landroidx/core/util/Consumer;)V", "")]
		public unsafe void RemoveOnNewIntentListener(IConsumer listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				ComponentActivity._members.InstanceMethods.InvokeNonvirtualVoidMethod("removeOnNewIntentListener.(Landroidx/core/util/Consumer;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002ECC File Offset: 0x000010CC
		[Register("removeOnPictureInPictureModeChangedListener", "(Landroidx/core/util/Consumer;)V", "")]
		public unsafe void RemoveOnPictureInPictureModeChangedListener(IConsumer listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				ComponentActivity._members.InstanceMethods.InvokeNonvirtualVoidMethod("removeOnPictureInPictureModeChangedListener.(Landroidx/core/util/Consumer;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002F34 File Offset: 0x00001134
		[Register("removeOnTrimMemoryListener", "(Landroidx/core/util/Consumer;)V", "")]
		public unsafe void RemoveOnTrimMemoryListener(IConsumer listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				ComponentActivity._members.InstanceMethods.InvokeNonvirtualVoidMethod("removeOnTrimMemoryListener.(Landroidx/core/util/Consumer;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000065 RID: 101 RVA: 0x00002F9C File Offset: 0x0000119C
		// (remove) Token: 0x06000066 RID: 102 RVA: 0x00002FE8 File Offset: 0x000011E8
		public event EventHandler<ContextAvailableEventArgs> ContextAvailable
		{
			add
			{
				EventHelper.AddEventHandler<IOnContextAvailableListener, IOnContextAvailableListenerImplementor>(ref this.weak_implementor_AddOnContextAvailableListener, new Func<IOnContextAvailableListenerImplementor>(this.__CreateIOnContextAvailableListenerImplementor), new Action<IOnContextAvailableListener>(this.AddOnContextAvailableListener), delegate(IOnContextAvailableListenerImplementor __h)
				{
					__h.Handler = (EventHandler<ContextAvailableEventArgs>)Delegate.Combine(__h.Handler, value);
				});
			}
			remove
			{
				Func<IOnContextAvailableListenerImplementor, bool> empty;
				if ((empty = ComponentActivity.<>O.<0>____IsEmpty) == null)
				{
					empty = (ComponentActivity.<>O.<0>____IsEmpty = new Func<IOnContextAvailableListenerImplementor, bool>(IOnContextAvailableListenerImplementor.__IsEmpty));
				}
				EventHelper.RemoveEventHandler<IOnContextAvailableListener, IOnContextAvailableListenerImplementor>(ref this.weak_implementor_AddOnContextAvailableListener, empty, delegate(IOnContextAvailableListener __v)
				{
					this.RemoveOnContextAvailableListener(__v);
				}, delegate(IOnContextAvailableListenerImplementor __h)
				{
					__h.Handler = (EventHandler<ContextAvailableEventArgs>)Delegate.Remove(__h.Handler, value);
				});
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00003047 File Offset: 0x00001247
		private IOnContextAvailableListenerImplementor __CreateIOnContextAvailableListenerImplementor()
		{
			return new IOnContextAvailableListenerImplementor(this);
		}

		// Token: 0x04000003 RID: 3
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/activity/ComponentActivity", typeof(ComponentActivity));

		// Token: 0x04000004 RID: 4
		private static Delegate cb_getDefaultViewModelCreationExtras;

		// Token: 0x04000005 RID: 5
		private static Delegate cb_getDefaultViewModelProviderFactory;

		// Token: 0x04000006 RID: 6
		private static Delegate cb_getFullyDrawnReporter;

		// Token: 0x04000007 RID: 7
		private static Delegate cb_getLastCustomNonConfigurationInstance;

		// Token: 0x04000008 RID: 8
		private static Delegate cb_getViewModelStore;

		// Token: 0x04000009 RID: 9
		private static Delegate cb_addMenuProvider_Landroidx_core_view_MenuProvider_;

		// Token: 0x0400000A RID: 10
		private static Delegate cb_addMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_;

		// Token: 0x0400000B RID: 11
		private static Delegate cb_addMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_Landroidx_lifecycle_Lifecycle_State_;

		// Token: 0x0400000C RID: 12
		private static Delegate cb_invalidateMenu;

		// Token: 0x0400000D RID: 13
		private static Delegate cb_onRetainCustomNonConfigurationInstance;

		// Token: 0x0400000E RID: 14
		private static Delegate cb_peekAvailableContext;

		// Token: 0x0400000F RID: 15
		private static Delegate cb_removeMenuProvider_Landroidx_core_view_MenuProvider_;

		// Token: 0x04000010 RID: 16
		private WeakReference weak_implementor_AddOnContextAvailableListener;

		// Token: 0x0200000F RID: 15
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04000011 RID: 17
			public static Func<IOnContextAvailableListenerImplementor, bool> <0>____IsEmpty;
		}
	}
}
