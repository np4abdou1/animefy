using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Content.Res;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using AndroidX.AppCompat.View;
using AndroidX.AppCompat.Widget;
using Java.Interop;
using Java.Lang;

namespace AndroidX.AppCompat.App
{
	// Token: 0x02000056 RID: 86
	[Register("androidx/appcompat/app/AppCompatDelegate", DoNotGenerateAcw = true)]
	internal class AppCompatDelegateInvoker : AppCompatDelegate
	{
		// Token: 0x060004E1 RID: 1249 RVA: 0x0000CB4B File Offset: 0x0000AD4B
		public AppCompatDelegateInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060004E2 RID: 1250 RVA: 0x0000CB55 File Offset: 0x0000AD55
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AppCompatDelegateInvoker._members;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x0000CB5C File Offset: 0x0000AD5C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AppCompatDelegateInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060004E4 RID: 1252 RVA: 0x0000CB68 File Offset: 0x0000AD68
		public override ActionBarDrawerToggle.IDelegate DrawerToggleDelegate
		{
			[Register("getDrawerToggleDelegate", "()Landroidx/appcompat/app/ActionBarDrawerToggle$Delegate;", "GetGetDrawerToggleDelegateHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ActionBarDrawerToggle.IDelegate>(AppCompatDelegateInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getDrawerToggleDelegate.()Landroidx/appcompat/app/ActionBarDrawerToggle$Delegate;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x0000CB9A File Offset: 0x0000AD9A
		// (set) Token: 0x060004E6 RID: 1254 RVA: 0x0000CBB4 File Offset: 0x0000ADB4
		public unsafe override bool HandleNativeActionModesEnabled
		{
			[Register("isHandleNativeActionModesEnabled", "()Z", "GetIsHandleNativeActionModesEnabledHandler")]
			get
			{
				return AppCompatDelegateInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("isHandleNativeActionModesEnabled.()Z", this, null);
			}
			[Register("setHandleNativeActionModesEnabled", "(Z)V", "GetSetHandleNativeActionModesEnabled_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				AppCompatDelegateInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setHandleNativeActionModesEnabled.(Z)V", this, ptr);
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060004E7 RID: 1255 RVA: 0x0000CBF0 File Offset: 0x0000ADF0
		public override MenuInflater MenuInflater
		{
			[Register("getMenuInflater", "()Landroid/view/MenuInflater;", "GetGetMenuInflaterHandler")]
			get
			{
				return Java.Lang.Object.GetObject<MenuInflater>(AppCompatDelegateInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getMenuInflater.()Landroid/view/MenuInflater;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060004E8 RID: 1256 RVA: 0x0000CC24 File Offset: 0x0000AE24
		public override ActionBar SupportActionBar
		{
			[Register("getSupportActionBar", "()Landroidx/appcompat/app/ActionBar;", "GetGetSupportActionBarHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ActionBar>(AppCompatDelegateInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getSupportActionBar.()Landroidx/appcompat/app/ActionBar;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x0000CC58 File Offset: 0x0000AE58
		[Register("addContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", "GetAddContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_Handler")]
		public unsafe override void AddContentView(View v, ViewGroup.LayoutParams lp)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((v == null) ? IntPtr.Zero : v.Handle);
				ptr[1] = new JniArgumentValue((lp == null) ? IntPtr.Zero : lp.Handle);
				AppCompatDelegateInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("addContentView.(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(v);
				GC.KeepAlive(lp);
			}
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x0000CCE4 File Offset: 0x0000AEE4
		[Register("applyDayNight", "()Z", "GetApplyDayNightHandler")]
		public override bool ApplyDayNight()
		{
			return AppCompatDelegateInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("applyDayNight.()Z", this, null);
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x0000CD00 File Offset: 0x0000AF00
		[Register("createView", "(Landroid/view/View;Ljava/lang/String;Landroid/content/Context;Landroid/util/AttributeSet;)Landroid/view/View;", "GetCreateView_Landroid_view_View_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_Handler")]
		public unsafe override View CreateView(View parent, string name, Context context, IAttributeSet attrs)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			View @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((parent == null) ? IntPtr.Zero : parent.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[3] = new JniArgumentValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
				@object = Java.Lang.Object.GetObject<View>(AppCompatDelegateInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("createView.(Landroid/view/View;Ljava/lang/String;Landroid/content/Context;Landroid/util/AttributeSet;)Landroid/view/View;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(parent);
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
			return @object;
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x0000CDF4 File Offset: 0x0000AFF4
		[Register("findViewById", "(I)Landroid/view/View;", "GetFindViewById_IHandler")]
		[JavaTypeParameters(new string[]
		{
			"T extends android.view.View"
		})]
		public unsafe override Java.Lang.Object FindViewById(int id)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(id);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(AppCompatDelegateInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("findViewById.(I)Landroid/view/View;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x0000CE40 File Offset: 0x0000B040
		[Register("hasWindowFeature", "(I)Z", "GetHasWindowFeature_IHandler")]
		public unsafe override bool HasWindowFeature(int featureId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(featureId);
			return AppCompatDelegateInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("hasWindowFeature.(I)Z", this, ptr);
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x0000CE7B File Offset: 0x0000B07B
		[Register("installViewFactory", "()V", "GetInstallViewFactoryHandler")]
		public override void InstallViewFactory()
		{
			AppCompatDelegateInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("installViewFactory.()V", this, null);
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x0000CE94 File Offset: 0x0000B094
		[Register("invalidateOptionsMenu", "()V", "GetInvalidateOptionsMenuHandler")]
		public override void InvalidateOptionsMenu()
		{
			AppCompatDelegateInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("invalidateOptionsMenu.()V", this, null);
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x0000CEB0 File Offset: 0x0000B0B0
		[Register("onConfigurationChanged", "(Landroid/content/res/Configuration;)V", "GetOnConfigurationChanged_Landroid_content_res_Configuration_Handler")]
		public unsafe override void OnConfigurationChanged(Configuration newConfig)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((newConfig == null) ? IntPtr.Zero : newConfig.Handle);
				AppCompatDelegateInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("onConfigurationChanged.(Landroid/content/res/Configuration;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(newConfig);
			}
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x0000CF14 File Offset: 0x0000B114
		[Register("onCreate", "(Landroid/os/Bundle;)V", "GetOnCreate_Landroid_os_Bundle_Handler")]
		public unsafe override void OnCreate(Bundle savedInstanceState)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((savedInstanceState == null) ? IntPtr.Zero : savedInstanceState.Handle);
				AppCompatDelegateInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("onCreate.(Landroid/os/Bundle;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(savedInstanceState);
			}
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x0000CF78 File Offset: 0x0000B178
		[Register("onDestroy", "()V", "GetOnDestroyHandler")]
		public override void OnDestroy()
		{
			AppCompatDelegateInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("onDestroy.()V", this, null);
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x0000CF94 File Offset: 0x0000B194
		[Register("onPostCreate", "(Landroid/os/Bundle;)V", "GetOnPostCreate_Landroid_os_Bundle_Handler")]
		public unsafe override void OnPostCreate(Bundle savedInstanceState)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((savedInstanceState == null) ? IntPtr.Zero : savedInstanceState.Handle);
				AppCompatDelegateInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("onPostCreate.(Landroid/os/Bundle;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(savedInstanceState);
			}
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x0000CFF8 File Offset: 0x0000B1F8
		[Register("onPostResume", "()V", "GetOnPostResumeHandler")]
		public override void OnPostResume()
		{
			AppCompatDelegateInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("onPostResume.()V", this, null);
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x0000D014 File Offset: 0x0000B214
		[Register("onSaveInstanceState", "(Landroid/os/Bundle;)V", "GetOnSaveInstanceState_Landroid_os_Bundle_Handler")]
		public unsafe override void OnSaveInstanceState(Bundle outState)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((outState == null) ? IntPtr.Zero : outState.Handle);
				AppCompatDelegateInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("onSaveInstanceState.(Landroid/os/Bundle;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(outState);
			}
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x0000D078 File Offset: 0x0000B278
		[Register("onStart", "()V", "GetOnStartHandler")]
		public override void OnStart()
		{
			AppCompatDelegateInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("onStart.()V", this, null);
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x0000D091 File Offset: 0x0000B291
		[Register("onStop", "()V", "GetOnStopHandler")]
		public override void OnStop()
		{
			AppCompatDelegateInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("onStop.()V", this, null);
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x0000D0AC File Offset: 0x0000B2AC
		[Register("requestWindowFeature", "(I)Z", "GetRequestWindowFeature_IHandler")]
		public unsafe override bool RequestWindowFeature(int featureId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(featureId);
			return AppCompatDelegateInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("requestWindowFeature.(I)Z", this, ptr);
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x0000D0E8 File Offset: 0x0000B2E8
		[Register("setContentView", "(Landroid/view/View;)V", "GetSetContentView_Landroid_view_View_Handler")]
		public unsafe override void SetContentView(View v)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((v == null) ? IntPtr.Zero : v.Handle);
				AppCompatDelegateInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setContentView.(Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(v);
			}
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x0000D14C File Offset: 0x0000B34C
		[Register("setContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", "GetSetContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_Handler")]
		public unsafe override void SetContentView(View v, ViewGroup.LayoutParams lp)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((v == null) ? IntPtr.Zero : v.Handle);
				ptr[1] = new JniArgumentValue((lp == null) ? IntPtr.Zero : lp.Handle);
				AppCompatDelegateInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setContentView.(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(v);
				GC.KeepAlive(lp);
			}
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x0000D1D8 File Offset: 0x0000B3D8
		[Register("setContentView", "(I)V", "GetSetContentView_IHandler")]
		public unsafe override void SetContentView(int resId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resId);
			AppCompatDelegateInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setContentView.(I)V", this, ptr);
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x0000D214 File Offset: 0x0000B414
		[Register("setLocalNightMode", "(I)V", "GetSetLocalNightMode_IHandler")]
		public unsafe override void SetLocalNightMode(int mode)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(mode);
			AppCompatDelegateInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setLocalNightMode.(I)V", this, ptr);
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x0000D250 File Offset: 0x0000B450
		[Register("setSupportActionBar", "(Landroidx/appcompat/widget/Toolbar;)V", "GetSetSupportActionBar_Landroidx_appcompat_widget_Toolbar_Handler")]
		public unsafe override void SetSupportActionBar(Toolbar toolbar)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((toolbar == null) ? IntPtr.Zero : toolbar.Handle);
				AppCompatDelegateInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setSupportActionBar.(Landroidx/appcompat/widget/Toolbar;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(toolbar);
			}
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x0000D2B4 File Offset: 0x0000B4B4
		[Register("setTitle", "(Ljava/lang/CharSequence;)V", "GetSetTitle_Ljava_lang_CharSequence_Handler")]
		public unsafe override void SetTitle(ICharSequence title)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(title);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				AppCompatDelegateInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setTitle.(Ljava/lang/CharSequence;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(title);
			}
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x0000D318 File Offset: 0x0000B518
		[Register("startSupportActionMode", "(Landroidx/appcompat/view/ActionMode$Callback;)Landroidx/appcompat/view/ActionMode;", "GetStartSupportActionMode_Landroidx_appcompat_view_ActionMode_Callback_Handler")]
		public unsafe override AndroidX.AppCompat.View.ActionMode StartSupportActionMode(AndroidX.AppCompat.View.ActionMode.ICallback callback_)
		{
			AndroidX.AppCompat.View.ActionMode @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback_ == null) ? IntPtr.Zero : ((Java.Lang.Object)callback_).Handle);
				@object = Java.Lang.Object.GetObject<AndroidX.AppCompat.View.ActionMode>(AppCompatDelegateInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("startSupportActionMode.(Landroidx/appcompat/view/ActionMode$Callback;)Landroidx/appcompat/view/ActionMode;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(callback_);
			}
			return @object;
		}

		// Token: 0x04000128 RID: 296
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/appcompat/app/AppCompatDelegate", typeof(AppCompatDelegateInvoker));
	}
}
