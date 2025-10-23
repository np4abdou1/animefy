using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Android.Views;
using AndroidX.AppCompat.View;
using AndroidX.AppCompat.Widget;
using AndroidX.Core.App;
using AndroidX.Core.OS;
using AndroidX.Fragment.App;
using Java.Interop;
using Java.Lang;

namespace AndroidX.AppCompat.App
{
	// Token: 0x02000054 RID: 84
	[Register("androidx/appcompat/app/AppCompatActivity", DoNotGenerateAcw = true)]
	public class AppCompatActivity : FragmentActivity, ActionBarDrawerToggle.IDelegateProvider, IJavaObject, IDisposable, IJavaPeerable, IAppCompatCallback, TaskStackBuilder.ISupportParentable
	{
		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000422 RID: 1058 RVA: 0x0000AF60 File Offset: 0x00009160
		internal static IntPtr class_ref
		{
			get
			{
				return AppCompatActivity._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000423 RID: 1059 RVA: 0x0000AF84 File Offset: 0x00009184
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AppCompatActivity._members;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x0000AF8C File Offset: 0x0000918C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AppCompatActivity._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000425 RID: 1061 RVA: 0x0000AFB0 File Offset: 0x000091B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AppCompatActivity._members.ManagedPeerType;
			}
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x0000AFBC File Offset: 0x000091BC
		protected AppCompatActivity(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x0000AFC8 File Offset: 0x000091C8
		[Register(".ctor", "()V", "")]
		public AppCompatActivity() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AppCompatActivity._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AppCompatActivity._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x0000B038 File Offset: 0x00009238
		[Register(".ctor", "(I)V", "")]
		public unsafe AppCompatActivity(int contentLayoutId) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(contentLayoutId);
			base.SetHandle(AppCompatActivity._members.InstanceMethods.StartCreateInstance("(I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			AppCompatActivity._members.InstanceMethods.FinishCreateInstance("(I)V", this, ptr);
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x0000B0BC File Offset: 0x000092BC
		private static Delegate GetGetDelegateHandler()
		{
			if (AppCompatActivity.cb_getDelegate == null)
			{
				AppCompatActivity.cb_getDelegate = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppCompatActivity.n_GetDelegate));
			}
			return AppCompatActivity.cb_getDelegate;
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x0000B0E0 File Offset: 0x000092E0
		private static IntPtr n_GetDelegate(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AppCompatActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Delegate);
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600042B RID: 1067 RVA: 0x0000B0F4 File Offset: 0x000092F4
		public virtual AppCompatDelegate Delegate
		{
			[Register("getDelegate", "()Landroidx/appcompat/app/AppCompatDelegate;", "GetGetDelegateHandler")]
			get
			{
				return Java.Lang.Object.GetObject<AppCompatDelegate>(AppCompatActivity._members.InstanceMethods.InvokeVirtualObjectMethod("getDelegate.()Landroidx/appcompat/app/AppCompatDelegate;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x0000B126 File Offset: 0x00009326
		private static Delegate GetGetDrawerToggleDelegateHandler()
		{
			if (AppCompatActivity.cb_getDrawerToggleDelegate == null)
			{
				AppCompatActivity.cb_getDrawerToggleDelegate = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppCompatActivity.n_GetDrawerToggleDelegate));
			}
			return AppCompatActivity.cb_getDrawerToggleDelegate;
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x0000B14A File Offset: 0x0000934A
		private static IntPtr n_GetDrawerToggleDelegate(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AppCompatActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DrawerToggleDelegate);
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x0000B160 File Offset: 0x00009360
		public virtual ActionBarDrawerToggle.IDelegate DrawerToggleDelegate
		{
			[Register("getDrawerToggleDelegate", "()Landroidx/appcompat/app/ActionBarDrawerToggle$Delegate;", "GetGetDrawerToggleDelegateHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ActionBarDrawerToggle.IDelegate>(AppCompatActivity._members.InstanceMethods.InvokeVirtualObjectMethod("getDrawerToggleDelegate.()Landroidx/appcompat/app/ActionBarDrawerToggle$Delegate;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x0000B192 File Offset: 0x00009392
		private static Delegate GetGetSupportActionBarHandler()
		{
			if (AppCompatActivity.cb_getSupportActionBar == null)
			{
				AppCompatActivity.cb_getSupportActionBar = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppCompatActivity.n_GetSupportActionBar));
			}
			return AppCompatActivity.cb_getSupportActionBar;
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x0000B1B6 File Offset: 0x000093B6
		private static IntPtr n_GetSupportActionBar(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AppCompatActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SupportActionBar);
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x0000B1CC File Offset: 0x000093CC
		public virtual ActionBar SupportActionBar
		{
			[Register("getSupportActionBar", "()Landroidx/appcompat/app/ActionBar;", "GetGetSupportActionBarHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ActionBar>(AppCompatActivity._members.InstanceMethods.InvokeVirtualObjectMethod("getSupportActionBar.()Landroidx/appcompat/app/ActionBar;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x0000B1FE File Offset: 0x000093FE
		private static Delegate GetGetSupportParentActivityIntentHandler()
		{
			if (AppCompatActivity.cb_getSupportParentActivityIntent == null)
			{
				AppCompatActivity.cb_getSupportParentActivityIntent = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppCompatActivity.n_GetSupportParentActivityIntent));
			}
			return AppCompatActivity.cb_getSupportParentActivityIntent;
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x0000B222 File Offset: 0x00009422
		private static IntPtr n_GetSupportParentActivityIntent(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AppCompatActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SupportParentActivityIntent);
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000434 RID: 1076 RVA: 0x0000B238 File Offset: 0x00009438
		public virtual Intent SupportParentActivityIntent
		{
			[Register("getSupportParentActivityIntent", "()Landroid/content/Intent;", "GetGetSupportParentActivityIntentHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Intent>(AppCompatActivity._members.InstanceMethods.InvokeVirtualObjectMethod("getSupportParentActivityIntent.()Landroid/content/Intent;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x0000B26A File Offset: 0x0000946A
		private static Delegate GetOnCreateSupportNavigateUpTaskStack_Landroidx_core_app_TaskStackBuilder_Handler()
		{
			if (AppCompatActivity.cb_onCreateSupportNavigateUpTaskStack_Landroidx_core_app_TaskStackBuilder_ == null)
			{
				AppCompatActivity.cb_onCreateSupportNavigateUpTaskStack_Landroidx_core_app_TaskStackBuilder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AppCompatActivity.n_OnCreateSupportNavigateUpTaskStack_Landroidx_core_app_TaskStackBuilder_));
			}
			return AppCompatActivity.cb_onCreateSupportNavigateUpTaskStack_Landroidx_core_app_TaskStackBuilder_;
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x0000B290 File Offset: 0x00009490
		private static void n_OnCreateSupportNavigateUpTaskStack_Landroidx_core_app_TaskStackBuilder_(IntPtr jnienv, IntPtr native__this, IntPtr native_builder)
		{
			AppCompatActivity @object = Java.Lang.Object.GetObject<AppCompatActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TaskStackBuilder object2 = Java.Lang.Object.GetObject<TaskStackBuilder>(native_builder, JniHandleOwnership.DoNotTransfer);
			@object.OnCreateSupportNavigateUpTaskStack(object2);
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x0000B2B4 File Offset: 0x000094B4
		[Register("onCreateSupportNavigateUpTaskStack", "(Landroidx/core/app/TaskStackBuilder;)V", "GetOnCreateSupportNavigateUpTaskStack_Landroidx_core_app_TaskStackBuilder_Handler")]
		public unsafe virtual void OnCreateSupportNavigateUpTaskStack(TaskStackBuilder builder)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((builder == null) ? IntPtr.Zero : builder.Handle);
				AppCompatActivity._members.InstanceMethods.InvokeVirtualVoidMethod("onCreateSupportNavigateUpTaskStack.(Landroidx/core/app/TaskStackBuilder;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(builder);
			}
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x0000B318 File Offset: 0x00009518
		private static Delegate GetOnLocalesChanged_Landroidx_core_os_LocaleListCompat_Handler()
		{
			if (AppCompatActivity.cb_onLocalesChanged_Landroidx_core_os_LocaleListCompat_ == null)
			{
				AppCompatActivity.cb_onLocalesChanged_Landroidx_core_os_LocaleListCompat_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AppCompatActivity.n_OnLocalesChanged_Landroidx_core_os_LocaleListCompat_));
			}
			return AppCompatActivity.cb_onLocalesChanged_Landroidx_core_os_LocaleListCompat_;
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x0000B33C File Offset: 0x0000953C
		private static void n_OnLocalesChanged_Landroidx_core_os_LocaleListCompat_(IntPtr jnienv, IntPtr native__this, IntPtr native_locales)
		{
			AppCompatActivity @object = Java.Lang.Object.GetObject<AppCompatActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			LocaleListCompat object2 = Java.Lang.Object.GetObject<LocaleListCompat>(native_locales, JniHandleOwnership.DoNotTransfer);
			@object.OnLocalesChanged(object2);
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x0000B360 File Offset: 0x00009560
		[Register("onLocalesChanged", "(Landroidx/core/os/LocaleListCompat;)V", "GetOnLocalesChanged_Landroidx_core_os_LocaleListCompat_Handler")]
		protected unsafe virtual void OnLocalesChanged(LocaleListCompat locales)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((locales == null) ? IntPtr.Zero : locales.Handle);
				AppCompatActivity._members.InstanceMethods.InvokeVirtualVoidMethod("onLocalesChanged.(Landroidx/core/os/LocaleListCompat;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(locales);
			}
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x0000B3C4 File Offset: 0x000095C4
		[Register("onMenuItemSelected", "(ILandroid/view/MenuItem;)Z", "")]
		public unsafe sealed override bool OnMenuItemSelected(int featureId, IMenuItem item)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(featureId);
				ptr[1] = new JniArgumentValue((item == null) ? IntPtr.Zero : ((Java.Lang.Object)item).Handle);
				result = AppCompatActivity._members.InstanceMethods.InvokeNonvirtualBooleanMethod("onMenuItemSelected.(ILandroid/view/MenuItem;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(item);
			}
			return result;
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x0000B444 File Offset: 0x00009644
		private static Delegate GetOnNightModeChanged_IHandler()
		{
			if (AppCompatActivity.cb_onNightModeChanged_I == null)
			{
				AppCompatActivity.cb_onNightModeChanged_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(AppCompatActivity.n_OnNightModeChanged_I));
			}
			return AppCompatActivity.cb_onNightModeChanged_I;
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x0000B468 File Offset: 0x00009668
		private static void n_OnNightModeChanged_I(IntPtr jnienv, IntPtr native__this, int mode)
		{
			Java.Lang.Object.GetObject<AppCompatActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnNightModeChanged(mode);
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x0000B478 File Offset: 0x00009678
		[Register("onNightModeChanged", "(I)V", "GetOnNightModeChanged_IHandler")]
		protected unsafe virtual void OnNightModeChanged(int mode)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(mode);
			AppCompatActivity._members.InstanceMethods.InvokeVirtualVoidMethod("onNightModeChanged.(I)V", this, ptr);
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x0000B4B3 File Offset: 0x000096B3
		private static Delegate GetOnPrepareSupportNavigateUpTaskStack_Landroidx_core_app_TaskStackBuilder_Handler()
		{
			if (AppCompatActivity.cb_onPrepareSupportNavigateUpTaskStack_Landroidx_core_app_TaskStackBuilder_ == null)
			{
				AppCompatActivity.cb_onPrepareSupportNavigateUpTaskStack_Landroidx_core_app_TaskStackBuilder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AppCompatActivity.n_OnPrepareSupportNavigateUpTaskStack_Landroidx_core_app_TaskStackBuilder_));
			}
			return AppCompatActivity.cb_onPrepareSupportNavigateUpTaskStack_Landroidx_core_app_TaskStackBuilder_;
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x0000B4D8 File Offset: 0x000096D8
		private static void n_OnPrepareSupportNavigateUpTaskStack_Landroidx_core_app_TaskStackBuilder_(IntPtr jnienv, IntPtr native__this, IntPtr native_builder)
		{
			AppCompatActivity @object = Java.Lang.Object.GetObject<AppCompatActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TaskStackBuilder object2 = Java.Lang.Object.GetObject<TaskStackBuilder>(native_builder, JniHandleOwnership.DoNotTransfer);
			@object.OnPrepareSupportNavigateUpTaskStack(object2);
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x0000B4FC File Offset: 0x000096FC
		[Register("onPrepareSupportNavigateUpTaskStack", "(Landroidx/core/app/TaskStackBuilder;)V", "GetOnPrepareSupportNavigateUpTaskStack_Landroidx_core_app_TaskStackBuilder_Handler")]
		public unsafe virtual void OnPrepareSupportNavigateUpTaskStack(TaskStackBuilder builder)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((builder == null) ? IntPtr.Zero : builder.Handle);
				AppCompatActivity._members.InstanceMethods.InvokeVirtualVoidMethod("onPrepareSupportNavigateUpTaskStack.(Landroidx/core/app/TaskStackBuilder;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(builder);
			}
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x0000B560 File Offset: 0x00009760
		private static Delegate GetOnSupportActionModeFinished_Landroidx_appcompat_view_ActionMode_Handler()
		{
			if (AppCompatActivity.cb_onSupportActionModeFinished_Landroidx_appcompat_view_ActionMode_ == null)
			{
				AppCompatActivity.cb_onSupportActionModeFinished_Landroidx_appcompat_view_ActionMode_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AppCompatActivity.n_OnSupportActionModeFinished_Landroidx_appcompat_view_ActionMode_));
			}
			return AppCompatActivity.cb_onSupportActionModeFinished_Landroidx_appcompat_view_ActionMode_;
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x0000B584 File Offset: 0x00009784
		private static void n_OnSupportActionModeFinished_Landroidx_appcompat_view_ActionMode_(IntPtr jnienv, IntPtr native__this, IntPtr native_mode)
		{
			AppCompatActivity @object = Java.Lang.Object.GetObject<AppCompatActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AndroidX.AppCompat.View.ActionMode object2 = Java.Lang.Object.GetObject<AndroidX.AppCompat.View.ActionMode>(native_mode, JniHandleOwnership.DoNotTransfer);
			@object.OnSupportActionModeFinished(object2);
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x0000B5A8 File Offset: 0x000097A8
		[Register("onSupportActionModeFinished", "(Landroidx/appcompat/view/ActionMode;)V", "GetOnSupportActionModeFinished_Landroidx_appcompat_view_ActionMode_Handler")]
		public unsafe virtual void OnSupportActionModeFinished(AndroidX.AppCompat.View.ActionMode mode)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((mode == null) ? IntPtr.Zero : mode.Handle);
				AppCompatActivity._members.InstanceMethods.InvokeVirtualVoidMethod("onSupportActionModeFinished.(Landroidx/appcompat/view/ActionMode;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(mode);
			}
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x0000B60C File Offset: 0x0000980C
		private static Delegate GetOnSupportActionModeStarted_Landroidx_appcompat_view_ActionMode_Handler()
		{
			if (AppCompatActivity.cb_onSupportActionModeStarted_Landroidx_appcompat_view_ActionMode_ == null)
			{
				AppCompatActivity.cb_onSupportActionModeStarted_Landroidx_appcompat_view_ActionMode_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AppCompatActivity.n_OnSupportActionModeStarted_Landroidx_appcompat_view_ActionMode_));
			}
			return AppCompatActivity.cb_onSupportActionModeStarted_Landroidx_appcompat_view_ActionMode_;
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x0000B630 File Offset: 0x00009830
		private static void n_OnSupportActionModeStarted_Landroidx_appcompat_view_ActionMode_(IntPtr jnienv, IntPtr native__this, IntPtr native_mode)
		{
			AppCompatActivity @object = Java.Lang.Object.GetObject<AppCompatActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AndroidX.AppCompat.View.ActionMode object2 = Java.Lang.Object.GetObject<AndroidX.AppCompat.View.ActionMode>(native_mode, JniHandleOwnership.DoNotTransfer);
			@object.OnSupportActionModeStarted(object2);
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x0000B654 File Offset: 0x00009854
		[Register("onSupportActionModeStarted", "(Landroidx/appcompat/view/ActionMode;)V", "GetOnSupportActionModeStarted_Landroidx_appcompat_view_ActionMode_Handler")]
		public unsafe virtual void OnSupportActionModeStarted(AndroidX.AppCompat.View.ActionMode mode)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((mode == null) ? IntPtr.Zero : mode.Handle);
				AppCompatActivity._members.InstanceMethods.InvokeVirtualVoidMethod("onSupportActionModeStarted.(Landroidx/appcompat/view/ActionMode;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(mode);
			}
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x0000B6B8 File Offset: 0x000098B8
		private static Delegate GetOnSupportContentChangedHandler()
		{
			if (AppCompatActivity.cb_onSupportContentChanged == null)
			{
				AppCompatActivity.cb_onSupportContentChanged = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AppCompatActivity.n_OnSupportContentChanged));
			}
			return AppCompatActivity.cb_onSupportContentChanged;
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x0000B6DC File Offset: 0x000098DC
		private static void n_OnSupportContentChanged(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AppCompatActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnSupportContentChanged();
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x0000B6EB File Offset: 0x000098EB
		[Register("onSupportContentChanged", "()V", "GetOnSupportContentChangedHandler")]
		public virtual void OnSupportContentChanged()
		{
			AppCompatActivity._members.InstanceMethods.InvokeVirtualVoidMethod("onSupportContentChanged.()V", this, null);
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x0000B704 File Offset: 0x00009904
		private static Delegate GetOnSupportNavigateUpHandler()
		{
			if (AppCompatActivity.cb_onSupportNavigateUp == null)
			{
				AppCompatActivity.cb_onSupportNavigateUp = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AppCompatActivity.n_OnSupportNavigateUp));
			}
			return AppCompatActivity.cb_onSupportNavigateUp;
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x0000B728 File Offset: 0x00009928
		private static bool n_OnSupportNavigateUp(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AppCompatActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnSupportNavigateUp();
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x0000B737 File Offset: 0x00009937
		[Register("onSupportNavigateUp", "()Z", "GetOnSupportNavigateUpHandler")]
		public virtual bool OnSupportNavigateUp()
		{
			return AppCompatActivity._members.InstanceMethods.InvokeVirtualBooleanMethod("onSupportNavigateUp.()Z", this, null);
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x0000B750 File Offset: 0x00009950
		private static Delegate GetOnWindowStartingSupportActionMode_Landroidx_appcompat_view_ActionMode_Callback_Handler()
		{
			if (AppCompatActivity.cb_onWindowStartingSupportActionMode_Landroidx_appcompat_view_ActionMode_Callback_ == null)
			{
				AppCompatActivity.cb_onWindowStartingSupportActionMode_Landroidx_appcompat_view_ActionMode_Callback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AppCompatActivity.n_OnWindowStartingSupportActionMode_Landroidx_appcompat_view_ActionMode_Callback_));
			}
			return AppCompatActivity.cb_onWindowStartingSupportActionMode_Landroidx_appcompat_view_ActionMode_Callback_;
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x0000B774 File Offset: 0x00009974
		private static IntPtr n_OnWindowStartingSupportActionMode_Landroidx_appcompat_view_ActionMode_Callback_(IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			AppCompatActivity @object = Java.Lang.Object.GetObject<AppCompatActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AndroidX.AppCompat.View.ActionMode.ICallback object2 = Java.Lang.Object.GetObject<AndroidX.AppCompat.View.ActionMode.ICallback>(native__callback, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.OnWindowStartingSupportActionMode(object2));
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x0000B79C File Offset: 0x0000999C
		[Register("onWindowStartingSupportActionMode", "(Landroidx/appcompat/view/ActionMode$Callback;)Landroidx/appcompat/view/ActionMode;", "GetOnWindowStartingSupportActionMode_Landroidx_appcompat_view_ActionMode_Callback_Handler")]
		public unsafe virtual AndroidX.AppCompat.View.ActionMode OnWindowStartingSupportActionMode(AndroidX.AppCompat.View.ActionMode.ICallback callback)
		{
			AndroidX.AppCompat.View.ActionMode @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : ((Java.Lang.Object)callback).Handle);
				@object = Java.Lang.Object.GetObject<AndroidX.AppCompat.View.ActionMode>(AppCompatActivity._members.InstanceMethods.InvokeVirtualObjectMethod("onWindowStartingSupportActionMode.(Landroidx/appcompat/view/ActionMode$Callback;)Landroidx/appcompat/view/ActionMode;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
			return @object;
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x0000B814 File Offset: 0x00009A14
		private static Delegate GetSetSupportActionBar_Landroidx_appcompat_widget_Toolbar_Handler()
		{
			if (AppCompatActivity.cb_setSupportActionBar_Landroidx_appcompat_widget_Toolbar_ == null)
			{
				AppCompatActivity.cb_setSupportActionBar_Landroidx_appcompat_widget_Toolbar_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AppCompatActivity.n_SetSupportActionBar_Landroidx_appcompat_widget_Toolbar_));
			}
			return AppCompatActivity.cb_setSupportActionBar_Landroidx_appcompat_widget_Toolbar_;
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x0000B838 File Offset: 0x00009A38
		private static void n_SetSupportActionBar_Landroidx_appcompat_widget_Toolbar_(IntPtr jnienv, IntPtr native__this, IntPtr native_toolbar)
		{
			AppCompatActivity @object = Java.Lang.Object.GetObject<AppCompatActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Toolbar object2 = Java.Lang.Object.GetObject<Toolbar>(native_toolbar, JniHandleOwnership.DoNotTransfer);
			@object.SetSupportActionBar(object2);
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x0000B85C File Offset: 0x00009A5C
		[Register("setSupportActionBar", "(Landroidx/appcompat/widget/Toolbar;)V", "GetSetSupportActionBar_Landroidx_appcompat_widget_Toolbar_Handler")]
		public unsafe virtual void SetSupportActionBar(Toolbar toolbar)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((toolbar == null) ? IntPtr.Zero : toolbar.Handle);
				AppCompatActivity._members.InstanceMethods.InvokeVirtualVoidMethod("setSupportActionBar.(Landroidx/appcompat/widget/Toolbar;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(toolbar);
			}
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x0000B8C0 File Offset: 0x00009AC0
		private static Delegate GetSetSupportProgress_IHandler()
		{
			if (AppCompatActivity.cb_setSupportProgress_I == null)
			{
				AppCompatActivity.cb_setSupportProgress_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(AppCompatActivity.n_SetSupportProgress_I));
			}
			return AppCompatActivity.cb_setSupportProgress_I;
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x0000B8E4 File Offset: 0x00009AE4
		private static void n_SetSupportProgress_I(IntPtr jnienv, IntPtr native__this, int progress)
		{
			Java.Lang.Object.GetObject<AppCompatActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetSupportProgress(progress);
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x0000B8F4 File Offset: 0x00009AF4
		[Register("setSupportProgress", "(I)V", "GetSetSupportProgress_IHandler")]
		public unsafe virtual void SetSupportProgress(int progress)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(progress);
			AppCompatActivity._members.InstanceMethods.InvokeVirtualVoidMethod("setSupportProgress.(I)V", this, ptr);
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x0000B92F File Offset: 0x00009B2F
		private static Delegate GetSetSupportProgressBarIndeterminate_ZHandler()
		{
			if (AppCompatActivity.cb_setSupportProgressBarIndeterminate_Z == null)
			{
				AppCompatActivity.cb_setSupportProgressBarIndeterminate_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(AppCompatActivity.n_SetSupportProgressBarIndeterminate_Z));
			}
			return AppCompatActivity.cb_setSupportProgressBarIndeterminate_Z;
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x0000B953 File Offset: 0x00009B53
		private static void n_SetSupportProgressBarIndeterminate_Z(IntPtr jnienv, IntPtr native__this, bool indeterminate)
		{
			Java.Lang.Object.GetObject<AppCompatActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetSupportProgressBarIndeterminate(indeterminate);
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x0000B964 File Offset: 0x00009B64
		[Register("setSupportProgressBarIndeterminate", "(Z)V", "GetSetSupportProgressBarIndeterminate_ZHandler")]
		public unsafe virtual void SetSupportProgressBarIndeterminate(bool indeterminate)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(indeterminate);
			AppCompatActivity._members.InstanceMethods.InvokeVirtualVoidMethod("setSupportProgressBarIndeterminate.(Z)V", this, ptr);
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x0000B99F File Offset: 0x00009B9F
		private static Delegate GetSetSupportProgressBarIndeterminateVisibility_ZHandler()
		{
			if (AppCompatActivity.cb_setSupportProgressBarIndeterminateVisibility_Z == null)
			{
				AppCompatActivity.cb_setSupportProgressBarIndeterminateVisibility_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(AppCompatActivity.n_SetSupportProgressBarIndeterminateVisibility_Z));
			}
			return AppCompatActivity.cb_setSupportProgressBarIndeterminateVisibility_Z;
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x0000B9C3 File Offset: 0x00009BC3
		private static void n_SetSupportProgressBarIndeterminateVisibility_Z(IntPtr jnienv, IntPtr native__this, bool visible)
		{
			Java.Lang.Object.GetObject<AppCompatActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetSupportProgressBarIndeterminateVisibility(visible);
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x0000B9D4 File Offset: 0x00009BD4
		[Register("setSupportProgressBarIndeterminateVisibility", "(Z)V", "GetSetSupportProgressBarIndeterminateVisibility_ZHandler")]
		public unsafe virtual void SetSupportProgressBarIndeterminateVisibility(bool visible)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(visible);
			AppCompatActivity._members.InstanceMethods.InvokeVirtualVoidMethod("setSupportProgressBarIndeterminateVisibility.(Z)V", this, ptr);
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x0000BA0F File Offset: 0x00009C0F
		private static Delegate GetSetSupportProgressBarVisibility_ZHandler()
		{
			if (AppCompatActivity.cb_setSupportProgressBarVisibility_Z == null)
			{
				AppCompatActivity.cb_setSupportProgressBarVisibility_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(AppCompatActivity.n_SetSupportProgressBarVisibility_Z));
			}
			return AppCompatActivity.cb_setSupportProgressBarVisibility_Z;
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x0000BA33 File Offset: 0x00009C33
		private static void n_SetSupportProgressBarVisibility_Z(IntPtr jnienv, IntPtr native__this, bool visible)
		{
			Java.Lang.Object.GetObject<AppCompatActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetSupportProgressBarVisibility(visible);
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x0000BA44 File Offset: 0x00009C44
		[Register("setSupportProgressBarVisibility", "(Z)V", "GetSetSupportProgressBarVisibility_ZHandler")]
		public unsafe virtual void SetSupportProgressBarVisibility(bool visible)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(visible);
			AppCompatActivity._members.InstanceMethods.InvokeVirtualVoidMethod("setSupportProgressBarVisibility.(Z)V", this, ptr);
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x0000BA7F File Offset: 0x00009C7F
		private static Delegate GetStartSupportActionMode_Landroidx_appcompat_view_ActionMode_Callback_Handler()
		{
			if (AppCompatActivity.cb_startSupportActionMode_Landroidx_appcompat_view_ActionMode_Callback_ == null)
			{
				AppCompatActivity.cb_startSupportActionMode_Landroidx_appcompat_view_ActionMode_Callback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AppCompatActivity.n_StartSupportActionMode_Landroidx_appcompat_view_ActionMode_Callback_));
			}
			return AppCompatActivity.cb_startSupportActionMode_Landroidx_appcompat_view_ActionMode_Callback_;
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x0000BAA4 File Offset: 0x00009CA4
		private static IntPtr n_StartSupportActionMode_Landroidx_appcompat_view_ActionMode_Callback_(IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			AppCompatActivity @object = Java.Lang.Object.GetObject<AppCompatActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AndroidX.AppCompat.View.ActionMode.ICallback object2 = Java.Lang.Object.GetObject<AndroidX.AppCompat.View.ActionMode.ICallback>(native__callback, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.StartSupportActionMode(object2));
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x0000BACC File Offset: 0x00009CCC
		[Register("startSupportActionMode", "(Landroidx/appcompat/view/ActionMode$Callback;)Landroidx/appcompat/view/ActionMode;", "GetStartSupportActionMode_Landroidx_appcompat_view_ActionMode_Callback_Handler")]
		public unsafe virtual AndroidX.AppCompat.View.ActionMode StartSupportActionMode(AndroidX.AppCompat.View.ActionMode.ICallback callback)
		{
			AndroidX.AppCompat.View.ActionMode @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : ((Java.Lang.Object)callback).Handle);
				@object = Java.Lang.Object.GetObject<AndroidX.AppCompat.View.ActionMode>(AppCompatActivity._members.InstanceMethods.InvokeVirtualObjectMethod("startSupportActionMode.(Landroidx/appcompat/view/ActionMode$Callback;)Landroidx/appcompat/view/ActionMode;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
			return @object;
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x0000BB44 File Offset: 0x00009D44
		private static Delegate GetSupportNavigateUpTo_Landroid_content_Intent_Handler()
		{
			if (AppCompatActivity.cb_supportNavigateUpTo_Landroid_content_Intent_ == null)
			{
				AppCompatActivity.cb_supportNavigateUpTo_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AppCompatActivity.n_SupportNavigateUpTo_Landroid_content_Intent_));
			}
			return AppCompatActivity.cb_supportNavigateUpTo_Landroid_content_Intent_;
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x0000BB68 File Offset: 0x00009D68
		private static void n_SupportNavigateUpTo_Landroid_content_Intent_(IntPtr jnienv, IntPtr native__this, IntPtr native_upIntent)
		{
			AppCompatActivity @object = Java.Lang.Object.GetObject<AppCompatActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Intent object2 = Java.Lang.Object.GetObject<Intent>(native_upIntent, JniHandleOwnership.DoNotTransfer);
			@object.SupportNavigateUpTo(object2);
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x0000BB8C File Offset: 0x00009D8C
		[Register("supportNavigateUpTo", "(Landroid/content/Intent;)V", "GetSupportNavigateUpTo_Landroid_content_Intent_Handler")]
		public unsafe virtual void SupportNavigateUpTo(Intent upIntent)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((upIntent == null) ? IntPtr.Zero : upIntent.Handle);
				AppCompatActivity._members.InstanceMethods.InvokeVirtualVoidMethod("supportNavigateUpTo.(Landroid/content/Intent;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(upIntent);
			}
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x0000BBF0 File Offset: 0x00009DF0
		private static Delegate GetSupportRequestWindowFeature_IHandler()
		{
			if (AppCompatActivity.cb_supportRequestWindowFeature_I == null)
			{
				AppCompatActivity.cb_supportRequestWindowFeature_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_Z(AppCompatActivity.n_SupportRequestWindowFeature_I));
			}
			return AppCompatActivity.cb_supportRequestWindowFeature_I;
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x0000BC14 File Offset: 0x00009E14
		private static bool n_SupportRequestWindowFeature_I(IntPtr jnienv, IntPtr native__this, int featureId)
		{
			return Java.Lang.Object.GetObject<AppCompatActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SupportRequestWindowFeature(featureId);
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x0000BC24 File Offset: 0x00009E24
		[Register("supportRequestWindowFeature", "(I)Z", "GetSupportRequestWindowFeature_IHandler")]
		public unsafe virtual bool SupportRequestWindowFeature(int featureId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(featureId);
			return AppCompatActivity._members.InstanceMethods.InvokeVirtualBooleanMethod("supportRequestWindowFeature.(I)Z", this, ptr);
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x0000BC5F File Offset: 0x00009E5F
		private static Delegate GetSupportShouldUpRecreateTask_Landroid_content_Intent_Handler()
		{
			if (AppCompatActivity.cb_supportShouldUpRecreateTask_Landroid_content_Intent_ == null)
			{
				AppCompatActivity.cb_supportShouldUpRecreateTask_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(AppCompatActivity.n_SupportShouldUpRecreateTask_Landroid_content_Intent_));
			}
			return AppCompatActivity.cb_supportShouldUpRecreateTask_Landroid_content_Intent_;
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x0000BC84 File Offset: 0x00009E84
		private static bool n_SupportShouldUpRecreateTask_Landroid_content_Intent_(IntPtr jnienv, IntPtr native__this, IntPtr native_targetIntent)
		{
			AppCompatActivity @object = Java.Lang.Object.GetObject<AppCompatActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Intent object2 = Java.Lang.Object.GetObject<Intent>(native_targetIntent, JniHandleOwnership.DoNotTransfer);
			return @object.SupportShouldUpRecreateTask(object2);
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x0000BCA8 File Offset: 0x00009EA8
		[Register("supportShouldUpRecreateTask", "(Landroid/content/Intent;)Z", "GetSupportShouldUpRecreateTask_Landroid_content_Intent_Handler")]
		public unsafe virtual bool SupportShouldUpRecreateTask(Intent targetIntent)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((targetIntent == null) ? IntPtr.Zero : targetIntent.Handle);
				result = AppCompatActivity._members.InstanceMethods.InvokeVirtualBooleanMethod("supportShouldUpRecreateTask.(Landroid/content/Intent;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(targetIntent);
			}
			return result;
		}

		// Token: 0x040000EF RID: 239
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/appcompat/app/AppCompatActivity", typeof(AppCompatActivity));

		// Token: 0x040000F0 RID: 240
		private static Delegate cb_getDelegate;

		// Token: 0x040000F1 RID: 241
		private static Delegate cb_getDrawerToggleDelegate;

		// Token: 0x040000F2 RID: 242
		private static Delegate cb_getSupportActionBar;

		// Token: 0x040000F3 RID: 243
		private static Delegate cb_getSupportParentActivityIntent;

		// Token: 0x040000F4 RID: 244
		private static Delegate cb_onCreateSupportNavigateUpTaskStack_Landroidx_core_app_TaskStackBuilder_;

		// Token: 0x040000F5 RID: 245
		private static Delegate cb_onLocalesChanged_Landroidx_core_os_LocaleListCompat_;

		// Token: 0x040000F6 RID: 246
		private static Delegate cb_onNightModeChanged_I;

		// Token: 0x040000F7 RID: 247
		private static Delegate cb_onPrepareSupportNavigateUpTaskStack_Landroidx_core_app_TaskStackBuilder_;

		// Token: 0x040000F8 RID: 248
		private static Delegate cb_onSupportActionModeFinished_Landroidx_appcompat_view_ActionMode_;

		// Token: 0x040000F9 RID: 249
		private static Delegate cb_onSupportActionModeStarted_Landroidx_appcompat_view_ActionMode_;

		// Token: 0x040000FA RID: 250
		private static Delegate cb_onSupportContentChanged;

		// Token: 0x040000FB RID: 251
		private static Delegate cb_onSupportNavigateUp;

		// Token: 0x040000FC RID: 252
		private static Delegate cb_onWindowStartingSupportActionMode_Landroidx_appcompat_view_ActionMode_Callback_;

		// Token: 0x040000FD RID: 253
		private static Delegate cb_setSupportActionBar_Landroidx_appcompat_widget_Toolbar_;

		// Token: 0x040000FE RID: 254
		private static Delegate cb_setSupportProgress_I;

		// Token: 0x040000FF RID: 255
		private static Delegate cb_setSupportProgressBarIndeterminate_Z;

		// Token: 0x04000100 RID: 256
		private static Delegate cb_setSupportProgressBarIndeterminateVisibility_Z;

		// Token: 0x04000101 RID: 257
		private static Delegate cb_setSupportProgressBarVisibility_Z;

		// Token: 0x04000102 RID: 258
		private static Delegate cb_startSupportActionMode_Landroidx_appcompat_view_ActionMode_Callback_;

		// Token: 0x04000103 RID: 259
		private static Delegate cb_supportNavigateUpTo_Landroid_content_Intent_;

		// Token: 0x04000104 RID: 260
		private static Delegate cb_supportRequestWindowFeature_I;

		// Token: 0x04000105 RID: 261
		private static Delegate cb_supportShouldUpRecreateTask_Landroid_content_Intent_;
	}
}
