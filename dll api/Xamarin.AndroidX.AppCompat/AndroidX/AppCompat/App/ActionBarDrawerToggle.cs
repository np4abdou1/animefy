using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Graphics.Drawables;
using Android.Runtime;
using Android.Views;
using AndroidX.AppCompat.Graphics.Drawable;
using AndroidX.AppCompat.Widget;
using AndroidX.DrawerLayout.Widget;
using Java.Interop;
using Java.Lang;

namespace AndroidX.AppCompat.App
{
	// Token: 0x0200004F RID: 79
	[Register("androidx/appcompat/app/ActionBarDrawerToggle", DoNotGenerateAcw = true)]
	public class ActionBarDrawerToggle : Java.Lang.Object, DrawerLayout.IDrawerListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060003BD RID: 957 RVA: 0x00009E50 File Offset: 0x00008050
		internal static IntPtr class_ref
		{
			get
			{
				return ActionBarDrawerToggle._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060003BE RID: 958 RVA: 0x00009E74 File Offset: 0x00008074
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ActionBarDrawerToggle._members;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060003BF RID: 959 RVA: 0x00009E7C File Offset: 0x0000807C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ActionBarDrawerToggle._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x00009EA0 File Offset: 0x000080A0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ActionBarDrawerToggle._members.ManagedPeerType;
			}
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x000039D4 File Offset: 0x00001BD4
		protected ActionBarDrawerToggle(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00009EAC File Offset: 0x000080AC
		[Register(".ctor", "(Landroid/app/Activity;Landroidx/drawerlayout/widget/DrawerLayout;Landroidx/appcompat/widget/Toolbar;II)V", "")]
		public unsafe ActionBarDrawerToggle(Activity activity, DrawerLayout drawerLayout, Toolbar toolbar, int openDrawerContentDescRes, int closeDrawerContentDescRes) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ptr[1] = new JniArgumentValue((drawerLayout == null) ? IntPtr.Zero : drawerLayout.Handle);
				ptr[2] = new JniArgumentValue((toolbar == null) ? IntPtr.Zero : toolbar.Handle);
				ptr[3] = new JniArgumentValue(openDrawerContentDescRes);
				ptr[4] = new JniArgumentValue(closeDrawerContentDescRes);
				base.SetHandle(ActionBarDrawerToggle._members.InstanceMethods.StartCreateInstance("(Landroid/app/Activity;Landroidx/drawerlayout/widget/DrawerLayout;Landroidx/appcompat/widget/Toolbar;II)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ActionBarDrawerToggle._members.InstanceMethods.FinishCreateInstance("(Landroid/app/Activity;Landroidx/drawerlayout/widget/DrawerLayout;Landroidx/appcompat/widget/Toolbar;II)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
				GC.KeepAlive(drawerLayout);
				GC.KeepAlive(toolbar);
			}
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00009FDC File Offset: 0x000081DC
		[Register(".ctor", "(Landroid/app/Activity;Landroidx/drawerlayout/widget/DrawerLayout;II)V", "")]
		public unsafe ActionBarDrawerToggle(Activity activity, DrawerLayout drawerLayout, int openDrawerContentDescRes, int closeDrawerContentDescRes) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ptr[1] = new JniArgumentValue((drawerLayout == null) ? IntPtr.Zero : drawerLayout.Handle);
				ptr[2] = new JniArgumentValue(openDrawerContentDescRes);
				ptr[3] = new JniArgumentValue(closeDrawerContentDescRes);
				base.SetHandle(ActionBarDrawerToggle._members.InstanceMethods.StartCreateInstance("(Landroid/app/Activity;Landroidx/drawerlayout/widget/DrawerLayout;II)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ActionBarDrawerToggle._members.InstanceMethods.FinishCreateInstance("(Landroid/app/Activity;Landroidx/drawerlayout/widget/DrawerLayout;II)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
				GC.KeepAlive(drawerLayout);
			}
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0000A0E0 File Offset: 0x000082E0
		private static Delegate GetGetDrawerArrowDrawableHandler()
		{
			if (ActionBarDrawerToggle.cb_getDrawerArrowDrawable == null)
			{
				ActionBarDrawerToggle.cb_getDrawerArrowDrawable = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ActionBarDrawerToggle.n_GetDrawerArrowDrawable));
			}
			return ActionBarDrawerToggle.cb_getDrawerArrowDrawable;
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0000A104 File Offset: 0x00008304
		private static IntPtr n_GetDrawerArrowDrawable(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ActionBarDrawerToggle>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DrawerArrowDrawable);
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x0000A118 File Offset: 0x00008318
		private static Delegate GetSetDrawerArrowDrawable_Landroidx_appcompat_graphics_drawable_DrawerArrowDrawable_Handler()
		{
			if (ActionBarDrawerToggle.cb_setDrawerArrowDrawable_Landroidx_appcompat_graphics_drawable_DrawerArrowDrawable_ == null)
			{
				ActionBarDrawerToggle.cb_setDrawerArrowDrawable_Landroidx_appcompat_graphics_drawable_DrawerArrowDrawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ActionBarDrawerToggle.n_SetDrawerArrowDrawable_Landroidx_appcompat_graphics_drawable_DrawerArrowDrawable_));
			}
			return ActionBarDrawerToggle.cb_setDrawerArrowDrawable_Landroidx_appcompat_graphics_drawable_DrawerArrowDrawable_;
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x0000A13C File Offset: 0x0000833C
		private static void n_SetDrawerArrowDrawable_Landroidx_appcompat_graphics_drawable_DrawerArrowDrawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_drawable)
		{
			ActionBarDrawerToggle @object = Java.Lang.Object.GetObject<ActionBarDrawerToggle>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			DrawerArrowDrawable object2 = Java.Lang.Object.GetObject<DrawerArrowDrawable>(native_drawable, JniHandleOwnership.DoNotTransfer);
			@object.DrawerArrowDrawable = object2;
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x0000A160 File Offset: 0x00008360
		// (set) Token: 0x060003C9 RID: 969 RVA: 0x0000A194 File Offset: 0x00008394
		public unsafe virtual DrawerArrowDrawable DrawerArrowDrawable
		{
			[Register("getDrawerArrowDrawable", "()Landroidx/appcompat/graphics/drawable/DrawerArrowDrawable;", "GetGetDrawerArrowDrawableHandler")]
			get
			{
				return Java.Lang.Object.GetObject<DrawerArrowDrawable>(ActionBarDrawerToggle._members.InstanceMethods.InvokeVirtualObjectMethod("getDrawerArrowDrawable.()Landroidx/appcompat/graphics/drawable/DrawerArrowDrawable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setDrawerArrowDrawable", "(Landroidx/appcompat/graphics/drawable/DrawerArrowDrawable;)V", "GetSetDrawerArrowDrawable_Landroidx_appcompat_graphics_drawable_DrawerArrowDrawable_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					ActionBarDrawerToggle._members.InstanceMethods.InvokeVirtualVoidMethod("setDrawerArrowDrawable.(Landroidx/appcompat/graphics/drawable/DrawerArrowDrawable;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x060003CA RID: 970 RVA: 0x0000A1F8 File Offset: 0x000083F8
		private static Delegate GetIsDrawerIndicatorEnabledHandler()
		{
			if (ActionBarDrawerToggle.cb_isDrawerIndicatorEnabled == null)
			{
				ActionBarDrawerToggle.cb_isDrawerIndicatorEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ActionBarDrawerToggle.n_IsDrawerIndicatorEnabled));
			}
			return ActionBarDrawerToggle.cb_isDrawerIndicatorEnabled;
		}

		// Token: 0x060003CB RID: 971 RVA: 0x0000A21C File Offset: 0x0000841C
		private static bool n_IsDrawerIndicatorEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ActionBarDrawerToggle>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DrawerIndicatorEnabled;
		}

		// Token: 0x060003CC RID: 972 RVA: 0x0000A22B File Offset: 0x0000842B
		private static Delegate GetSetDrawerIndicatorEnabled_ZHandler()
		{
			if (ActionBarDrawerToggle.cb_setDrawerIndicatorEnabled_Z == null)
			{
				ActionBarDrawerToggle.cb_setDrawerIndicatorEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(ActionBarDrawerToggle.n_SetDrawerIndicatorEnabled_Z));
			}
			return ActionBarDrawerToggle.cb_setDrawerIndicatorEnabled_Z;
		}

		// Token: 0x060003CD RID: 973 RVA: 0x0000A24F File Offset: 0x0000844F
		private static void n_SetDrawerIndicatorEnabled_Z(IntPtr jnienv, IntPtr native__this, bool enable)
		{
			Java.Lang.Object.GetObject<ActionBarDrawerToggle>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DrawerIndicatorEnabled = enable;
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060003CE RID: 974 RVA: 0x0000A25F File Offset: 0x0000845F
		// (set) Token: 0x060003CF RID: 975 RVA: 0x0000A278 File Offset: 0x00008478
		public unsafe virtual bool DrawerIndicatorEnabled
		{
			[Register("isDrawerIndicatorEnabled", "()Z", "GetIsDrawerIndicatorEnabledHandler")]
			get
			{
				return ActionBarDrawerToggle._members.InstanceMethods.InvokeVirtualBooleanMethod("isDrawerIndicatorEnabled.()Z", this, null);
			}
			[Register("setDrawerIndicatorEnabled", "(Z)V", "GetSetDrawerIndicatorEnabled_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				ActionBarDrawerToggle._members.InstanceMethods.InvokeVirtualVoidMethod("setDrawerIndicatorEnabled.(Z)V", this, ptr);
			}
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x0000A2B3 File Offset: 0x000084B3
		private static Delegate GetIsDrawerSlideAnimationEnabledHandler()
		{
			if (ActionBarDrawerToggle.cb_isDrawerSlideAnimationEnabled == null)
			{
				ActionBarDrawerToggle.cb_isDrawerSlideAnimationEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ActionBarDrawerToggle.n_IsDrawerSlideAnimationEnabled));
			}
			return ActionBarDrawerToggle.cb_isDrawerSlideAnimationEnabled;
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x0000A2D7 File Offset: 0x000084D7
		private static bool n_IsDrawerSlideAnimationEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ActionBarDrawerToggle>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DrawerSlideAnimationEnabled;
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x0000A2E6 File Offset: 0x000084E6
		private static Delegate GetSetDrawerSlideAnimationEnabled_ZHandler()
		{
			if (ActionBarDrawerToggle.cb_setDrawerSlideAnimationEnabled_Z == null)
			{
				ActionBarDrawerToggle.cb_setDrawerSlideAnimationEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(ActionBarDrawerToggle.n_SetDrawerSlideAnimationEnabled_Z));
			}
			return ActionBarDrawerToggle.cb_setDrawerSlideAnimationEnabled_Z;
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x0000A30A File Offset: 0x0000850A
		private static void n_SetDrawerSlideAnimationEnabled_Z(IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			Java.Lang.Object.GetObject<ActionBarDrawerToggle>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DrawerSlideAnimationEnabled = enabled;
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x0000A31A File Offset: 0x0000851A
		// (set) Token: 0x060003D5 RID: 981 RVA: 0x0000A334 File Offset: 0x00008534
		public unsafe virtual bool DrawerSlideAnimationEnabled
		{
			[Register("isDrawerSlideAnimationEnabled", "()Z", "GetIsDrawerSlideAnimationEnabledHandler")]
			get
			{
				return ActionBarDrawerToggle._members.InstanceMethods.InvokeVirtualBooleanMethod("isDrawerSlideAnimationEnabled.()Z", this, null);
			}
			[Register("setDrawerSlideAnimationEnabled", "(Z)V", "GetSetDrawerSlideAnimationEnabled_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				ActionBarDrawerToggle._members.InstanceMethods.InvokeVirtualVoidMethod("setDrawerSlideAnimationEnabled.(Z)V", this, ptr);
			}
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x0000A36F File Offset: 0x0000856F
		private static Delegate GetGetToolbarNavigationClickListenerHandler()
		{
			if (ActionBarDrawerToggle.cb_getToolbarNavigationClickListener == null)
			{
				ActionBarDrawerToggle.cb_getToolbarNavigationClickListener = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ActionBarDrawerToggle.n_GetToolbarNavigationClickListener));
			}
			return ActionBarDrawerToggle.cb_getToolbarNavigationClickListener;
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0000A393 File Offset: 0x00008593
		private static IntPtr n_GetToolbarNavigationClickListener(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ActionBarDrawerToggle>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToolbarNavigationClickListener);
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x0000A3A7 File Offset: 0x000085A7
		private static Delegate GetSetToolbarNavigationClickListener_Landroid_view_View_OnClickListener_Handler()
		{
			if (ActionBarDrawerToggle.cb_setToolbarNavigationClickListener_Landroid_view_View_OnClickListener_ == null)
			{
				ActionBarDrawerToggle.cb_setToolbarNavigationClickListener_Landroid_view_View_OnClickListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ActionBarDrawerToggle.n_SetToolbarNavigationClickListener_Landroid_view_View_OnClickListener_));
			}
			return ActionBarDrawerToggle.cb_setToolbarNavigationClickListener_Landroid_view_View_OnClickListener_;
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x0000A3CC File Offset: 0x000085CC
		private static void n_SetToolbarNavigationClickListener_Landroid_view_View_OnClickListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_onToolbarNavigationClickListener)
		{
			ActionBarDrawerToggle @object = Java.Lang.Object.GetObject<ActionBarDrawerToggle>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View.IOnClickListener object2 = Java.Lang.Object.GetObject<View.IOnClickListener>(native_onToolbarNavigationClickListener, JniHandleOwnership.DoNotTransfer);
			@object.ToolbarNavigationClickListener = object2;
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060003DA RID: 986 RVA: 0x0000A3F0 File Offset: 0x000085F0
		// (set) Token: 0x060003DB RID: 987 RVA: 0x0000A424 File Offset: 0x00008624
		public unsafe virtual View.IOnClickListener ToolbarNavigationClickListener
		{
			[Register("getToolbarNavigationClickListener", "()Landroid/view/View$OnClickListener;", "GetGetToolbarNavigationClickListenerHandler")]
			get
			{
				return Java.Lang.Object.GetObject<View.IOnClickListener>(ActionBarDrawerToggle._members.InstanceMethods.InvokeVirtualObjectMethod("getToolbarNavigationClickListener.()Landroid/view/View$OnClickListener;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setToolbarNavigationClickListener", "(Landroid/view/View$OnClickListener;)V", "GetSetToolbarNavigationClickListener_Landroid_view_View_OnClickListener_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : ((Java.Lang.Object)value).Handle);
					ActionBarDrawerToggle._members.InstanceMethods.InvokeVirtualVoidMethod("setToolbarNavigationClickListener.(Landroid/view/View$OnClickListener;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x060003DC RID: 988 RVA: 0x0000A48C File Offset: 0x0000868C
		private static Delegate GetOnConfigurationChanged_Landroid_content_res_Configuration_Handler()
		{
			if (ActionBarDrawerToggle.cb_onConfigurationChanged_Landroid_content_res_Configuration_ == null)
			{
				ActionBarDrawerToggle.cb_onConfigurationChanged_Landroid_content_res_Configuration_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ActionBarDrawerToggle.n_OnConfigurationChanged_Landroid_content_res_Configuration_));
			}
			return ActionBarDrawerToggle.cb_onConfigurationChanged_Landroid_content_res_Configuration_;
		}

		// Token: 0x060003DD RID: 989 RVA: 0x0000A4B0 File Offset: 0x000086B0
		private static void n_OnConfigurationChanged_Landroid_content_res_Configuration_(IntPtr jnienv, IntPtr native__this, IntPtr native_newConfig)
		{
			ActionBarDrawerToggle @object = Java.Lang.Object.GetObject<ActionBarDrawerToggle>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Configuration object2 = Java.Lang.Object.GetObject<Configuration>(native_newConfig, JniHandleOwnership.DoNotTransfer);
			@object.OnConfigurationChanged(object2);
		}

		// Token: 0x060003DE RID: 990 RVA: 0x0000A4D4 File Offset: 0x000086D4
		[Register("onConfigurationChanged", "(Landroid/content/res/Configuration;)V", "GetOnConfigurationChanged_Landroid_content_res_Configuration_Handler")]
		public unsafe virtual void OnConfigurationChanged(Configuration newConfig)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((newConfig == null) ? IntPtr.Zero : newConfig.Handle);
				ActionBarDrawerToggle._members.InstanceMethods.InvokeVirtualVoidMethod("onConfigurationChanged.(Landroid/content/res/Configuration;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(newConfig);
			}
		}

		// Token: 0x060003DF RID: 991 RVA: 0x0000A538 File Offset: 0x00008738
		private static Delegate GetOnDrawerClosed_Landroid_view_View_Handler()
		{
			if (ActionBarDrawerToggle.cb_onDrawerClosed_Landroid_view_View_ == null)
			{
				ActionBarDrawerToggle.cb_onDrawerClosed_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ActionBarDrawerToggle.n_OnDrawerClosed_Landroid_view_View_));
			}
			return ActionBarDrawerToggle.cb_onDrawerClosed_Landroid_view_View_;
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x0000A55C File Offset: 0x0000875C
		private static void n_OnDrawerClosed_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_drawerView)
		{
			ActionBarDrawerToggle @object = Java.Lang.Object.GetObject<ActionBarDrawerToggle>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_drawerView, JniHandleOwnership.DoNotTransfer);
			@object.OnDrawerClosed(object2);
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x0000A580 File Offset: 0x00008780
		[Register("onDrawerClosed", "(Landroid/view/View;)V", "GetOnDrawerClosed_Landroid_view_View_Handler")]
		public unsafe virtual void OnDrawerClosed(View drawerView)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((drawerView == null) ? IntPtr.Zero : drawerView.Handle);
				ActionBarDrawerToggle._members.InstanceMethods.InvokeVirtualVoidMethod("onDrawerClosed.(Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(drawerView);
			}
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x0000A5E4 File Offset: 0x000087E4
		private static Delegate GetOnDrawerOpened_Landroid_view_View_Handler()
		{
			if (ActionBarDrawerToggle.cb_onDrawerOpened_Landroid_view_View_ == null)
			{
				ActionBarDrawerToggle.cb_onDrawerOpened_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ActionBarDrawerToggle.n_OnDrawerOpened_Landroid_view_View_));
			}
			return ActionBarDrawerToggle.cb_onDrawerOpened_Landroid_view_View_;
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x0000A608 File Offset: 0x00008808
		private static void n_OnDrawerOpened_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_drawerView)
		{
			ActionBarDrawerToggle @object = Java.Lang.Object.GetObject<ActionBarDrawerToggle>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_drawerView, JniHandleOwnership.DoNotTransfer);
			@object.OnDrawerOpened(object2);
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x0000A62C File Offset: 0x0000882C
		[Register("onDrawerOpened", "(Landroid/view/View;)V", "GetOnDrawerOpened_Landroid_view_View_Handler")]
		public unsafe virtual void OnDrawerOpened(View drawerView)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((drawerView == null) ? IntPtr.Zero : drawerView.Handle);
				ActionBarDrawerToggle._members.InstanceMethods.InvokeVirtualVoidMethod("onDrawerOpened.(Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(drawerView);
			}
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x0000A690 File Offset: 0x00008890
		private static Delegate GetOnDrawerSlide_Landroid_view_View_FHandler()
		{
			if (ActionBarDrawerToggle.cb_onDrawerSlide_Landroid_view_View_F == null)
			{
				ActionBarDrawerToggle.cb_onDrawerSlide_Landroid_view_View_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLF_V(ActionBarDrawerToggle.n_OnDrawerSlide_Landroid_view_View_F));
			}
			return ActionBarDrawerToggle.cb_onDrawerSlide_Landroid_view_View_F;
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x0000A6B4 File Offset: 0x000088B4
		private static void n_OnDrawerSlide_Landroid_view_View_F(IntPtr jnienv, IntPtr native__this, IntPtr native_drawerView, float slideOffset)
		{
			ActionBarDrawerToggle @object = Java.Lang.Object.GetObject<ActionBarDrawerToggle>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_drawerView, JniHandleOwnership.DoNotTransfer);
			@object.OnDrawerSlide(object2, slideOffset);
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x0000A6D8 File Offset: 0x000088D8
		[Register("onDrawerSlide", "(Landroid/view/View;F)V", "GetOnDrawerSlide_Landroid_view_View_FHandler")]
		public unsafe virtual void OnDrawerSlide(View drawerView, float slideOffset)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((drawerView == null) ? IntPtr.Zero : drawerView.Handle);
				ptr[1] = new JniArgumentValue(slideOffset);
				ActionBarDrawerToggle._members.InstanceMethods.InvokeVirtualVoidMethod("onDrawerSlide.(Landroid/view/View;F)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(drawerView);
			}
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x0000A750 File Offset: 0x00008950
		private static Delegate GetOnDrawerStateChanged_IHandler()
		{
			if (ActionBarDrawerToggle.cb_onDrawerStateChanged_I == null)
			{
				ActionBarDrawerToggle.cb_onDrawerStateChanged_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(ActionBarDrawerToggle.n_OnDrawerStateChanged_I));
			}
			return ActionBarDrawerToggle.cb_onDrawerStateChanged_I;
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x0000A774 File Offset: 0x00008974
		private static void n_OnDrawerStateChanged_I(IntPtr jnienv, IntPtr native__this, int newState)
		{
			Java.Lang.Object.GetObject<ActionBarDrawerToggle>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnDrawerStateChanged(newState);
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x0000A784 File Offset: 0x00008984
		[Register("onDrawerStateChanged", "(I)V", "GetOnDrawerStateChanged_IHandler")]
		public unsafe virtual void OnDrawerStateChanged(int newState)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(newState);
			ActionBarDrawerToggle._members.InstanceMethods.InvokeVirtualVoidMethod("onDrawerStateChanged.(I)V", this, ptr);
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x0000A7BF File Offset: 0x000089BF
		private static Delegate GetOnOptionsItemSelected_Landroid_view_MenuItem_Handler()
		{
			if (ActionBarDrawerToggle.cb_onOptionsItemSelected_Landroid_view_MenuItem_ == null)
			{
				ActionBarDrawerToggle.cb_onOptionsItemSelected_Landroid_view_MenuItem_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ActionBarDrawerToggle.n_OnOptionsItemSelected_Landroid_view_MenuItem_));
			}
			return ActionBarDrawerToggle.cb_onOptionsItemSelected_Landroid_view_MenuItem_;
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x0000A7E4 File Offset: 0x000089E4
		private static bool n_OnOptionsItemSelected_Landroid_view_MenuItem_(IntPtr jnienv, IntPtr native__this, IntPtr native_item)
		{
			ActionBarDrawerToggle @object = Java.Lang.Object.GetObject<ActionBarDrawerToggle>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMenuItem object2 = Java.Lang.Object.GetObject<IMenuItem>(native_item, JniHandleOwnership.DoNotTransfer);
			return @object.OnOptionsItemSelected(object2);
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0000A808 File Offset: 0x00008A08
		[Register("onOptionsItemSelected", "(Landroid/view/MenuItem;)Z", "GetOnOptionsItemSelected_Landroid_view_MenuItem_Handler")]
		public unsafe virtual bool OnOptionsItemSelected(IMenuItem item)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((item == null) ? IntPtr.Zero : ((Java.Lang.Object)item).Handle);
				result = ActionBarDrawerToggle._members.InstanceMethods.InvokeVirtualBooleanMethod("onOptionsItemSelected.(Landroid/view/MenuItem;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(item);
			}
			return result;
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0000A874 File Offset: 0x00008A74
		private static Delegate GetSetHomeAsUpIndicator_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (ActionBarDrawerToggle.cb_setHomeAsUpIndicator_Landroid_graphics_drawable_Drawable_ == null)
			{
				ActionBarDrawerToggle.cb_setHomeAsUpIndicator_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ActionBarDrawerToggle.n_SetHomeAsUpIndicator_Landroid_graphics_drawable_Drawable_));
			}
			return ActionBarDrawerToggle.cb_setHomeAsUpIndicator_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x0000A898 File Offset: 0x00008A98
		private static void n_SetHomeAsUpIndicator_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_indicator)
		{
			ActionBarDrawerToggle @object = Java.Lang.Object.GetObject<ActionBarDrawerToggle>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_indicator, JniHandleOwnership.DoNotTransfer);
			@object.SetHomeAsUpIndicator(object2);
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x0000A8BC File Offset: 0x00008ABC
		[Register("setHomeAsUpIndicator", "(Landroid/graphics/drawable/Drawable;)V", "GetSetHomeAsUpIndicator_Landroid_graphics_drawable_Drawable_Handler")]
		public unsafe virtual void SetHomeAsUpIndicator(Drawable indicator)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((indicator == null) ? IntPtr.Zero : indicator.Handle);
				ActionBarDrawerToggle._members.InstanceMethods.InvokeVirtualVoidMethod("setHomeAsUpIndicator.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(indicator);
			}
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x0000A920 File Offset: 0x00008B20
		private static Delegate GetSetHomeAsUpIndicator_IHandler()
		{
			if (ActionBarDrawerToggle.cb_setHomeAsUpIndicator_I == null)
			{
				ActionBarDrawerToggle.cb_setHomeAsUpIndicator_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(ActionBarDrawerToggle.n_SetHomeAsUpIndicator_I));
			}
			return ActionBarDrawerToggle.cb_setHomeAsUpIndicator_I;
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x0000A944 File Offset: 0x00008B44
		private static void n_SetHomeAsUpIndicator_I(IntPtr jnienv, IntPtr native__this, int resId)
		{
			Java.Lang.Object.GetObject<ActionBarDrawerToggle>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetHomeAsUpIndicator(resId);
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x0000A954 File Offset: 0x00008B54
		[Register("setHomeAsUpIndicator", "(I)V", "GetSetHomeAsUpIndicator_IHandler")]
		public unsafe virtual void SetHomeAsUpIndicator(int resId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resId);
			ActionBarDrawerToggle._members.InstanceMethods.InvokeVirtualVoidMethod("setHomeAsUpIndicator.(I)V", this, ptr);
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x0000A98F File Offset: 0x00008B8F
		private static Delegate GetSyncStateHandler()
		{
			if (ActionBarDrawerToggle.cb_syncState == null)
			{
				ActionBarDrawerToggle.cb_syncState = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ActionBarDrawerToggle.n_SyncState));
			}
			return ActionBarDrawerToggle.cb_syncState;
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x0000A9B3 File Offset: 0x00008BB3
		private static void n_SyncState(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ActionBarDrawerToggle>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SyncState();
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x0000A9C2 File Offset: 0x00008BC2
		[Register("syncState", "()V", "GetSyncStateHandler")]
		public virtual void SyncState()
		{
			ActionBarDrawerToggle._members.InstanceMethods.InvokeVirtualVoidMethod("syncState.()V", this, null);
		}

		// Token: 0x040000CD RID: 205
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/appcompat/app/ActionBarDrawerToggle", typeof(ActionBarDrawerToggle));

		// Token: 0x040000CE RID: 206
		private static Delegate cb_getDrawerArrowDrawable;

		// Token: 0x040000CF RID: 207
		private static Delegate cb_setDrawerArrowDrawable_Landroidx_appcompat_graphics_drawable_DrawerArrowDrawable_;

		// Token: 0x040000D0 RID: 208
		private static Delegate cb_isDrawerIndicatorEnabled;

		// Token: 0x040000D1 RID: 209
		private static Delegate cb_setDrawerIndicatorEnabled_Z;

		// Token: 0x040000D2 RID: 210
		private static Delegate cb_isDrawerSlideAnimationEnabled;

		// Token: 0x040000D3 RID: 211
		private static Delegate cb_setDrawerSlideAnimationEnabled_Z;

		// Token: 0x040000D4 RID: 212
		private static Delegate cb_getToolbarNavigationClickListener;

		// Token: 0x040000D5 RID: 213
		private static Delegate cb_setToolbarNavigationClickListener_Landroid_view_View_OnClickListener_;

		// Token: 0x040000D6 RID: 214
		private static Delegate cb_onConfigurationChanged_Landroid_content_res_Configuration_;

		// Token: 0x040000D7 RID: 215
		private static Delegate cb_onDrawerClosed_Landroid_view_View_;

		// Token: 0x040000D8 RID: 216
		private static Delegate cb_onDrawerOpened_Landroid_view_View_;

		// Token: 0x040000D9 RID: 217
		private static Delegate cb_onDrawerSlide_Landroid_view_View_F;

		// Token: 0x040000DA RID: 218
		private static Delegate cb_onDrawerStateChanged_I;

		// Token: 0x040000DB RID: 219
		private static Delegate cb_onOptionsItemSelected_Landroid_view_MenuItem_;

		// Token: 0x040000DC RID: 220
		private static Delegate cb_setHomeAsUpIndicator_Landroid_graphics_drawable_Drawable_;

		// Token: 0x040000DD RID: 221
		private static Delegate cb_setHomeAsUpIndicator_I;

		// Token: 0x040000DE RID: 222
		private static Delegate cb_syncState;

		// Token: 0x02000050 RID: 80
		[Register("androidx/appcompat/app/ActionBarDrawerToggle$Delegate", "", "AndroidX.AppCompat.App.ActionBarDrawerToggle/IDelegateInvoker")]
		public interface IDelegate : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x1700006D RID: 109
			// (get) Token: 0x060003F8 RID: 1016
			Context ActionBarThemedContext { [Register("getActionBarThemedContext", "()Landroid/content/Context;", "GetGetActionBarThemedContextHandler:AndroidX.AppCompat.App.ActionBarDrawerToggle/IDelegateInvoker, Xamarin.AndroidX.AppCompat")] get; }

			// Token: 0x1700006E RID: 110
			// (get) Token: 0x060003F9 RID: 1017
			bool IsNavigationVisible { [Register("isNavigationVisible", "()Z", "GetIsNavigationVisibleHandler:AndroidX.AppCompat.App.ActionBarDrawerToggle/IDelegateInvoker, Xamarin.AndroidX.AppCompat")] get; }

			// Token: 0x1700006F RID: 111
			// (get) Token: 0x060003FA RID: 1018
			Drawable ThemeUpIndicator { [Register("getThemeUpIndicator", "()Landroid/graphics/drawable/Drawable;", "GetGetThemeUpIndicatorHandler:AndroidX.AppCompat.App.ActionBarDrawerToggle/IDelegateInvoker, Xamarin.AndroidX.AppCompat")] get; }

			// Token: 0x060003FB RID: 1019
			[Register("setActionBarDescription", "(I)V", "GetSetActionBarDescription_IHandler:AndroidX.AppCompat.App.ActionBarDrawerToggle/IDelegateInvoker, Xamarin.AndroidX.AppCompat")]
			void SetActionBarDescription(int contentDescRes);

			// Token: 0x060003FC RID: 1020
			[Register("setActionBarUpIndicator", "(Landroid/graphics/drawable/Drawable;I)V", "GetSetActionBarUpIndicator_Landroid_graphics_drawable_Drawable_IHandler:AndroidX.AppCompat.App.ActionBarDrawerToggle/IDelegateInvoker, Xamarin.AndroidX.AppCompat")]
			void SetActionBarUpIndicator(Drawable upDrawable, int contentDescRes);
		}

		// Token: 0x02000051 RID: 81
		[Register("androidx/appcompat/app/ActionBarDrawerToggle$Delegate", DoNotGenerateAcw = true)]
		internal class IDelegateInvoker : Java.Lang.Object, ActionBarDrawerToggle.IDelegate, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000070 RID: 112
			// (get) Token: 0x060003FD RID: 1021 RVA: 0x0000A9F8 File Offset: 0x00008BF8
			private static IntPtr java_class_ref
			{
				get
				{
					return ActionBarDrawerToggle.IDelegateInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000071 RID: 113
			// (get) Token: 0x060003FE RID: 1022 RVA: 0x0000AA1C File Offset: 0x00008C1C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ActionBarDrawerToggle.IDelegateInvoker._members;
				}
			}

			// Token: 0x17000072 RID: 114
			// (get) Token: 0x060003FF RID: 1023 RVA: 0x0000AA23 File Offset: 0x00008C23
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000073 RID: 115
			// (get) Token: 0x06000400 RID: 1024 RVA: 0x0000AA2B File Offset: 0x00008C2B
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ActionBarDrawerToggle.IDelegateInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000401 RID: 1025 RVA: 0x0000AA37 File Offset: 0x00008C37
			public static ActionBarDrawerToggle.IDelegate GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<ActionBarDrawerToggle.IDelegate>(handle, transfer);
			}

			// Token: 0x06000402 RID: 1026 RVA: 0x0000AA40 File Offset: 0x00008C40
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, ActionBarDrawerToggle.IDelegateInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.appcompat.app.ActionBarDrawerToggle.Delegate'.");
				}
				return handle;
			}

			// Token: 0x06000403 RID: 1027 RVA: 0x0000AA6B File Offset: 0x00008C6B
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000404 RID: 1028 RVA: 0x0000AA9C File Offset: 0x00008C9C
			public IDelegateInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ActionBarDrawerToggle.IDelegateInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000405 RID: 1029 RVA: 0x0000AAD4 File Offset: 0x00008CD4
			private static Delegate GetGetActionBarThemedContextHandler()
			{
				if (ActionBarDrawerToggle.IDelegateInvoker.cb_getActionBarThemedContext == null)
				{
					ActionBarDrawerToggle.IDelegateInvoker.cb_getActionBarThemedContext = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ActionBarDrawerToggle.IDelegateInvoker.n_GetActionBarThemedContext));
				}
				return ActionBarDrawerToggle.IDelegateInvoker.cb_getActionBarThemedContext;
			}

			// Token: 0x06000406 RID: 1030 RVA: 0x0000AAF8 File Offset: 0x00008CF8
			private static IntPtr n_GetActionBarThemedContext(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ActionBarDrawerToggle.IDelegate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ActionBarThemedContext);
			}

			// Token: 0x17000074 RID: 116
			// (get) Token: 0x06000407 RID: 1031 RVA: 0x0000AB0C File Offset: 0x00008D0C
			public Context ActionBarThemedContext
			{
				get
				{
					if (this.id_getActionBarThemedContext == IntPtr.Zero)
					{
						this.id_getActionBarThemedContext = JNIEnv.GetMethodID(this.class_ref, "getActionBarThemedContext", "()Landroid/content/Context;");
					}
					return Java.Lang.Object.GetObject<Context>(JNIEnv.CallObjectMethod(base.Handle, this.id_getActionBarThemedContext), JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x06000408 RID: 1032 RVA: 0x0000AB5D File Offset: 0x00008D5D
			private static Delegate GetIsNavigationVisibleHandler()
			{
				if (ActionBarDrawerToggle.IDelegateInvoker.cb_isNavigationVisible == null)
				{
					ActionBarDrawerToggle.IDelegateInvoker.cb_isNavigationVisible = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ActionBarDrawerToggle.IDelegateInvoker.n_IsNavigationVisible));
				}
				return ActionBarDrawerToggle.IDelegateInvoker.cb_isNavigationVisible;
			}

			// Token: 0x06000409 RID: 1033 RVA: 0x0000AB81 File Offset: 0x00008D81
			private static bool n_IsNavigationVisible(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<ActionBarDrawerToggle.IDelegate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsNavigationVisible;
			}

			// Token: 0x17000075 RID: 117
			// (get) Token: 0x0600040A RID: 1034 RVA: 0x0000AB90 File Offset: 0x00008D90
			public bool IsNavigationVisible
			{
				get
				{
					if (this.id_isNavigationVisible == IntPtr.Zero)
					{
						this.id_isNavigationVisible = JNIEnv.GetMethodID(this.class_ref, "isNavigationVisible", "()Z");
					}
					return JNIEnv.CallBooleanMethod(base.Handle, this.id_isNavigationVisible);
				}
			}

			// Token: 0x0600040B RID: 1035 RVA: 0x0000ABD0 File Offset: 0x00008DD0
			private static Delegate GetGetThemeUpIndicatorHandler()
			{
				if (ActionBarDrawerToggle.IDelegateInvoker.cb_getThemeUpIndicator == null)
				{
					ActionBarDrawerToggle.IDelegateInvoker.cb_getThemeUpIndicator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ActionBarDrawerToggle.IDelegateInvoker.n_GetThemeUpIndicator));
				}
				return ActionBarDrawerToggle.IDelegateInvoker.cb_getThemeUpIndicator;
			}

			// Token: 0x0600040C RID: 1036 RVA: 0x0000ABF4 File Offset: 0x00008DF4
			private static IntPtr n_GetThemeUpIndicator(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ActionBarDrawerToggle.IDelegate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ThemeUpIndicator);
			}

			// Token: 0x17000076 RID: 118
			// (get) Token: 0x0600040D RID: 1037 RVA: 0x0000AC08 File Offset: 0x00008E08
			public Drawable ThemeUpIndicator
			{
				get
				{
					if (this.id_getThemeUpIndicator == IntPtr.Zero)
					{
						this.id_getThemeUpIndicator = JNIEnv.GetMethodID(this.class_ref, "getThemeUpIndicator", "()Landroid/graphics/drawable/Drawable;");
					}
					return Java.Lang.Object.GetObject<Drawable>(JNIEnv.CallObjectMethod(base.Handle, this.id_getThemeUpIndicator), JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x0600040E RID: 1038 RVA: 0x0000AC59 File Offset: 0x00008E59
			private static Delegate GetSetActionBarDescription_IHandler()
			{
				if (ActionBarDrawerToggle.IDelegateInvoker.cb_setActionBarDescription_I == null)
				{
					ActionBarDrawerToggle.IDelegateInvoker.cb_setActionBarDescription_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(ActionBarDrawerToggle.IDelegateInvoker.n_SetActionBarDescription_I));
				}
				return ActionBarDrawerToggle.IDelegateInvoker.cb_setActionBarDescription_I;
			}

			// Token: 0x0600040F RID: 1039 RVA: 0x0000AC7D File Offset: 0x00008E7D
			private static void n_SetActionBarDescription_I(IntPtr jnienv, IntPtr native__this, int contentDescRes)
			{
				Java.Lang.Object.GetObject<ActionBarDrawerToggle.IDelegate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetActionBarDescription(contentDescRes);
			}

			// Token: 0x06000410 RID: 1040 RVA: 0x0000AC90 File Offset: 0x00008E90
			public unsafe void SetActionBarDescription(int contentDescRes)
			{
				if (this.id_setActionBarDescription_I == IntPtr.Zero)
				{
					this.id_setActionBarDescription_I = JNIEnv.GetMethodID(this.class_ref, "setActionBarDescription", "(I)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(contentDescRes);
				JNIEnv.CallVoidMethod(base.Handle, this.id_setActionBarDescription_I, ptr);
			}

			// Token: 0x06000411 RID: 1041 RVA: 0x0000ACF4 File Offset: 0x00008EF4
			private static Delegate GetSetActionBarUpIndicator_Landroid_graphics_drawable_Drawable_IHandler()
			{
				if (ActionBarDrawerToggle.IDelegateInvoker.cb_setActionBarUpIndicator_Landroid_graphics_drawable_Drawable_I == null)
				{
					ActionBarDrawerToggle.IDelegateInvoker.cb_setActionBarUpIndicator_Landroid_graphics_drawable_Drawable_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(ActionBarDrawerToggle.IDelegateInvoker.n_SetActionBarUpIndicator_Landroid_graphics_drawable_Drawable_I));
				}
				return ActionBarDrawerToggle.IDelegateInvoker.cb_setActionBarUpIndicator_Landroid_graphics_drawable_Drawable_I;
			}

			// Token: 0x06000412 RID: 1042 RVA: 0x0000AD18 File Offset: 0x00008F18
			private static void n_SetActionBarUpIndicator_Landroid_graphics_drawable_Drawable_I(IntPtr jnienv, IntPtr native__this, IntPtr native_upDrawable, int contentDescRes)
			{
				ActionBarDrawerToggle.IDelegate @object = Java.Lang.Object.GetObject<ActionBarDrawerToggle.IDelegate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_upDrawable, JniHandleOwnership.DoNotTransfer);
				@object.SetActionBarUpIndicator(object2, contentDescRes);
			}

			// Token: 0x06000413 RID: 1043 RVA: 0x0000AD3C File Offset: 0x00008F3C
			public unsafe void SetActionBarUpIndicator(Drawable upDrawable, int contentDescRes)
			{
				if (this.id_setActionBarUpIndicator_Landroid_graphics_drawable_Drawable_I == IntPtr.Zero)
				{
					this.id_setActionBarUpIndicator_Landroid_graphics_drawable_Drawable_I = JNIEnv.GetMethodID(this.class_ref, "setActionBarUpIndicator", "(Landroid/graphics/drawable/Drawable;I)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((upDrawable == null) ? IntPtr.Zero : upDrawable.Handle);
				ptr[1] = new JValue(contentDescRes);
				JNIEnv.CallVoidMethod(base.Handle, this.id_setActionBarUpIndicator_Landroid_graphics_drawable_Drawable_I, ptr);
			}

			// Token: 0x040000DF RID: 223
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/appcompat/app/ActionBarDrawerToggle$Delegate", typeof(ActionBarDrawerToggle.IDelegateInvoker));

			// Token: 0x040000E0 RID: 224
			private IntPtr class_ref;

			// Token: 0x040000E1 RID: 225
			private static Delegate cb_getActionBarThemedContext;

			// Token: 0x040000E2 RID: 226
			private IntPtr id_getActionBarThemedContext;

			// Token: 0x040000E3 RID: 227
			private static Delegate cb_isNavigationVisible;

			// Token: 0x040000E4 RID: 228
			private IntPtr id_isNavigationVisible;

			// Token: 0x040000E5 RID: 229
			private static Delegate cb_getThemeUpIndicator;

			// Token: 0x040000E6 RID: 230
			private IntPtr id_getThemeUpIndicator;

			// Token: 0x040000E7 RID: 231
			private static Delegate cb_setActionBarDescription_I;

			// Token: 0x040000E8 RID: 232
			private IntPtr id_setActionBarDescription_I;

			// Token: 0x040000E9 RID: 233
			private static Delegate cb_setActionBarUpIndicator_Landroid_graphics_drawable_Drawable_I;

			// Token: 0x040000EA RID: 234
			private IntPtr id_setActionBarUpIndicator_Landroid_graphics_drawable_Drawable_I;
		}

		// Token: 0x02000052 RID: 82
		[Register("androidx/appcompat/app/ActionBarDrawerToggle$DelegateProvider", "", "AndroidX.AppCompat.App.ActionBarDrawerToggle/IDelegateProviderInvoker")]
		public interface IDelegateProvider : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000077 RID: 119
			// (get) Token: 0x06000415 RID: 1045
			ActionBarDrawerToggle.IDelegate DrawerToggleDelegate { [Register("getDrawerToggleDelegate", "()Landroidx/appcompat/app/ActionBarDrawerToggle$Delegate;", "GetGetDrawerToggleDelegateHandler:AndroidX.AppCompat.App.ActionBarDrawerToggle/IDelegateProviderInvoker, Xamarin.AndroidX.AppCompat")] get; }
		}

		// Token: 0x02000053 RID: 83
		[Register("androidx/appcompat/app/ActionBarDrawerToggle$DelegateProvider", DoNotGenerateAcw = true)]
		internal class IDelegateProviderInvoker : Java.Lang.Object, ActionBarDrawerToggle.IDelegateProvider, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000078 RID: 120
			// (get) Token: 0x06000416 RID: 1046 RVA: 0x0000ADE0 File Offset: 0x00008FE0
			private static IntPtr java_class_ref
			{
				get
				{
					return ActionBarDrawerToggle.IDelegateProviderInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000079 RID: 121
			// (get) Token: 0x06000417 RID: 1047 RVA: 0x0000AE04 File Offset: 0x00009004
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ActionBarDrawerToggle.IDelegateProviderInvoker._members;
				}
			}

			// Token: 0x1700007A RID: 122
			// (get) Token: 0x06000418 RID: 1048 RVA: 0x0000AE0B File Offset: 0x0000900B
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
			// (get) Token: 0x06000419 RID: 1049 RVA: 0x0000AE13 File Offset: 0x00009013
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ActionBarDrawerToggle.IDelegateProviderInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x0600041A RID: 1050 RVA: 0x0000AE1F File Offset: 0x0000901F
			public static ActionBarDrawerToggle.IDelegateProvider GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<ActionBarDrawerToggle.IDelegateProvider>(handle, transfer);
			}

			// Token: 0x0600041B RID: 1051 RVA: 0x0000AE28 File Offset: 0x00009028
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, ActionBarDrawerToggle.IDelegateProviderInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.appcompat.app.ActionBarDrawerToggle.DelegateProvider'.");
				}
				return handle;
			}

			// Token: 0x0600041C RID: 1052 RVA: 0x0000AE53 File Offset: 0x00009053
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x0600041D RID: 1053 RVA: 0x0000AE84 File Offset: 0x00009084
			public IDelegateProviderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ActionBarDrawerToggle.IDelegateProviderInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x0600041E RID: 1054 RVA: 0x0000AEBC File Offset: 0x000090BC
			private static Delegate GetGetDrawerToggleDelegateHandler()
			{
				if (ActionBarDrawerToggle.IDelegateProviderInvoker.cb_getDrawerToggleDelegate == null)
				{
					ActionBarDrawerToggle.IDelegateProviderInvoker.cb_getDrawerToggleDelegate = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ActionBarDrawerToggle.IDelegateProviderInvoker.n_GetDrawerToggleDelegate));
				}
				return ActionBarDrawerToggle.IDelegateProviderInvoker.cb_getDrawerToggleDelegate;
			}

			// Token: 0x0600041F RID: 1055 RVA: 0x0000AEE0 File Offset: 0x000090E0
			private static IntPtr n_GetDrawerToggleDelegate(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ActionBarDrawerToggle.IDelegateProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DrawerToggleDelegate);
			}

			// Token: 0x1700007C RID: 124
			// (get) Token: 0x06000420 RID: 1056 RVA: 0x0000AEF4 File Offset: 0x000090F4
			public ActionBarDrawerToggle.IDelegate DrawerToggleDelegate
			{
				get
				{
					if (this.id_getDrawerToggleDelegate == IntPtr.Zero)
					{
						this.id_getDrawerToggleDelegate = JNIEnv.GetMethodID(this.class_ref, "getDrawerToggleDelegate", "()Landroidx/appcompat/app/ActionBarDrawerToggle$Delegate;");
					}
					return Java.Lang.Object.GetObject<ActionBarDrawerToggle.IDelegate>(JNIEnv.CallObjectMethod(base.Handle, this.id_getDrawerToggleDelegate), JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x040000EB RID: 235
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/appcompat/app/ActionBarDrawerToggle$DelegateProvider", typeof(ActionBarDrawerToggle.IDelegateProviderInvoker));

			// Token: 0x040000EC RID: 236
			private IntPtr class_ref;

			// Token: 0x040000ED RID: 237
			private static Delegate cb_getDrawerToggleDelegate;

			// Token: 0x040000EE RID: 238
			private IntPtr id_getDrawerToggleDelegate;
		}
	}
}
