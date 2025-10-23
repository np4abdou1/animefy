using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using AndroidX.AppCompat.View;
using AndroidX.AppCompat.Widget;
using AndroidX.Core.OS;
using Java.Interop;
using Java.Lang;

namespace AndroidX.AppCompat.App
{
	// Token: 0x02000055 RID: 85
	[Register("androidx/appcompat/app/AppCompatDelegate", DoNotGenerateAcw = true)]
	public abstract class AppCompatDelegate : Java.Lang.Object
	{
		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x0000BD2C File Offset: 0x00009F2C
		internal static IntPtr class_ref
		{
			get
			{
				return AppCompatDelegate._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x0000BD50 File Offset: 0x00009F50
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AppCompatDelegate._members;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600046F RID: 1135 RVA: 0x0000BD58 File Offset: 0x00009F58
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AppCompatDelegate._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x0000BD7C File Offset: 0x00009F7C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AppCompatDelegate._members.ManagedPeerType;
			}
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x000039D4 File Offset: 0x00001BD4
		protected AppCompatDelegate(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000472 RID: 1138 RVA: 0x0000BD88 File Offset: 0x00009F88
		// (set) Token: 0x06000473 RID: 1139 RVA: 0x0000BDBC File Offset: 0x00009FBC
		public unsafe static LocaleListCompat ApplicationLocales
		{
			[Register("getApplicationLocales", "()Landroidx/core/os/LocaleListCompat;", "")]
			get
			{
				return Java.Lang.Object.GetObject<LocaleListCompat>(AppCompatDelegate._members.StaticMethods.InvokeObjectMethod("getApplicationLocales.()Landroidx/core/os/LocaleListCompat;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setApplicationLocales", "(Landroidx/core/os/LocaleListCompat;)V", "")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					AppCompatDelegate._members.StaticMethods.InvokeVoidMethod("setApplicationLocales.(Landroidx/core/os/LocaleListCompat;)V", ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x0000BE20 File Offset: 0x0000A020
		// (set) Token: 0x06000475 RID: 1141 RVA: 0x0000BE38 File Offset: 0x0000A038
		public unsafe static bool CompatVectorFromResourcesEnabled
		{
			[Register("isCompatVectorFromResourcesEnabled", "()Z", "")]
			get
			{
				return AppCompatDelegate._members.StaticMethods.InvokeBooleanMethod("isCompatVectorFromResourcesEnabled.()Z", null);
			}
			[Register("setCompatVectorFromResourcesEnabled", "(Z)V", "")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				AppCompatDelegate._members.StaticMethods.InvokeVoidMethod("setCompatVectorFromResourcesEnabled.(Z)V", ptr);
			}
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x0000BE72 File Offset: 0x0000A072
		private static Delegate GetGetContextForDelegateHandler()
		{
			if (AppCompatDelegate.cb_getContextForDelegate == null)
			{
				AppCompatDelegate.cb_getContextForDelegate = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppCompatDelegate.n_GetContextForDelegate));
			}
			return AppCompatDelegate.cb_getContextForDelegate;
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x0000BE96 File Offset: 0x0000A096
		private static IntPtr n_GetContextForDelegate(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AppCompatDelegate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ContextForDelegate);
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000478 RID: 1144 RVA: 0x0000BEAC File Offset: 0x0000A0AC
		public virtual Context ContextForDelegate
		{
			[Register("getContextForDelegate", "()Landroid/content/Context;", "GetGetContextForDelegateHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Context>(AppCompatDelegate._members.InstanceMethods.InvokeVirtualObjectMethod("getContextForDelegate.()Landroid/content/Context;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000479 RID: 1145 RVA: 0x0000BEDE File Offset: 0x0000A0DE
		// (set) Token: 0x0600047A RID: 1146 RVA: 0x0000BEF8 File Offset: 0x0000A0F8
		public unsafe static int DefaultNightMode
		{
			[Register("getDefaultNightMode", "()I", "")]
			get
			{
				return AppCompatDelegate._members.StaticMethods.InvokeInt32Method("getDefaultNightMode.()I", null);
			}
			[Register("setDefaultNightMode", "(I)V", "")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				AppCompatDelegate._members.StaticMethods.InvokeVoidMethod("setDefaultNightMode.(I)V", ptr);
			}
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x0000BF32 File Offset: 0x0000A132
		private static Delegate GetGetDrawerToggleDelegateHandler()
		{
			if (AppCompatDelegate.cb_getDrawerToggleDelegate == null)
			{
				AppCompatDelegate.cb_getDrawerToggleDelegate = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppCompatDelegate.n_GetDrawerToggleDelegate));
			}
			return AppCompatDelegate.cb_getDrawerToggleDelegate;
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x0000BF56 File Offset: 0x0000A156
		private static IntPtr n_GetDrawerToggleDelegate(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AppCompatDelegate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DrawerToggleDelegate);
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600047D RID: 1149
		public abstract ActionBarDrawerToggle.IDelegate DrawerToggleDelegate { [Register("getDrawerToggleDelegate", "()Landroidx/appcompat/app/ActionBarDrawerToggle$Delegate;", "GetGetDrawerToggleDelegateHandler")] get; }

		// Token: 0x0600047E RID: 1150 RVA: 0x0000BF6A File Offset: 0x0000A16A
		private static Delegate GetIsHandleNativeActionModesEnabledHandler()
		{
			if (AppCompatDelegate.cb_isHandleNativeActionModesEnabled == null)
			{
				AppCompatDelegate.cb_isHandleNativeActionModesEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AppCompatDelegate.n_IsHandleNativeActionModesEnabled));
			}
			return AppCompatDelegate.cb_isHandleNativeActionModesEnabled;
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x0000BF8E File Offset: 0x0000A18E
		private static bool n_IsHandleNativeActionModesEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AppCompatDelegate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HandleNativeActionModesEnabled;
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x0000BF9D File Offset: 0x0000A19D
		private static Delegate GetSetHandleNativeActionModesEnabled_ZHandler()
		{
			if (AppCompatDelegate.cb_setHandleNativeActionModesEnabled_Z == null)
			{
				AppCompatDelegate.cb_setHandleNativeActionModesEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(AppCompatDelegate.n_SetHandleNativeActionModesEnabled_Z));
			}
			return AppCompatDelegate.cb_setHandleNativeActionModesEnabled_Z;
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x0000BFC1 File Offset: 0x0000A1C1
		private static void n_SetHandleNativeActionModesEnabled_Z(IntPtr jnienv, IntPtr native__this, bool p0)
		{
			Java.Lang.Object.GetObject<AppCompatDelegate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HandleNativeActionModesEnabled = p0;
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000482 RID: 1154
		// (set) Token: 0x06000483 RID: 1155
		public abstract bool HandleNativeActionModesEnabled { [Register("isHandleNativeActionModesEnabled", "()Z", "GetIsHandleNativeActionModesEnabledHandler")] get; [Register("setHandleNativeActionModesEnabled", "(Z)V", "GetSetHandleNativeActionModesEnabled_ZHandler")] set; }

		// Token: 0x06000484 RID: 1156 RVA: 0x0000BFD1 File Offset: 0x0000A1D1
		private static Delegate GetGetLocalNightModeHandler()
		{
			if (AppCompatDelegate.cb_getLocalNightMode == null)
			{
				AppCompatDelegate.cb_getLocalNightMode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AppCompatDelegate.n_GetLocalNightMode));
			}
			return AppCompatDelegate.cb_getLocalNightMode;
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x0000BFF5 File Offset: 0x0000A1F5
		private static int n_GetLocalNightMode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AppCompatDelegate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LocalNightMode;
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000486 RID: 1158 RVA: 0x0000C004 File Offset: 0x0000A204
		public virtual int LocalNightMode
		{
			[Register("getLocalNightMode", "()I", "GetGetLocalNightModeHandler")]
			get
			{
				return AppCompatDelegate._members.InstanceMethods.InvokeVirtualInt32Method("getLocalNightMode.()I", this, null);
			}
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x0000C01D File Offset: 0x0000A21D
		private static Delegate GetGetMenuInflaterHandler()
		{
			if (AppCompatDelegate.cb_getMenuInflater == null)
			{
				AppCompatDelegate.cb_getMenuInflater = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppCompatDelegate.n_GetMenuInflater));
			}
			return AppCompatDelegate.cb_getMenuInflater;
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x0000C041 File Offset: 0x0000A241
		private static IntPtr n_GetMenuInflater(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AppCompatDelegate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MenuInflater);
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000489 RID: 1161
		public abstract MenuInflater MenuInflater { [Register("getMenuInflater", "()Landroid/view/MenuInflater;", "GetGetMenuInflaterHandler")] get; }

		// Token: 0x0600048A RID: 1162 RVA: 0x0000C055 File Offset: 0x0000A255
		private static Delegate GetGetSupportActionBarHandler()
		{
			if (AppCompatDelegate.cb_getSupportActionBar == null)
			{
				AppCompatDelegate.cb_getSupportActionBar = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppCompatDelegate.n_GetSupportActionBar));
			}
			return AppCompatDelegate.cb_getSupportActionBar;
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x0000C079 File Offset: 0x0000A279
		private static IntPtr n_GetSupportActionBar(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AppCompatDelegate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SupportActionBar);
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600048C RID: 1164
		public abstract ActionBar SupportActionBar { [Register("getSupportActionBar", "()Landroidx/appcompat/app/ActionBar;", "GetGetSupportActionBarHandler")] get; }

		// Token: 0x0600048D RID: 1165 RVA: 0x0000C08D File Offset: 0x0000A28D
		private static Delegate GetAddContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_Handler()
		{
			if (AppCompatDelegate.cb_addContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_ == null)
			{
				AppCompatDelegate.cb_addContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(AppCompatDelegate.n_AddContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_));
			}
			return AppCompatDelegate.cb_addContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_;
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x0000C0B4 File Offset: 0x0000A2B4
		private static void n_AddContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_(IntPtr jnienv, IntPtr native__this, IntPtr native_v, IntPtr native_lp)
		{
			AppCompatDelegate @object = Java.Lang.Object.GetObject<AppCompatDelegate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_v, JniHandleOwnership.DoNotTransfer);
			ViewGroup.LayoutParams object3 = Java.Lang.Object.GetObject<ViewGroup.LayoutParams>(native_lp, JniHandleOwnership.DoNotTransfer);
			@object.AddContentView(object2, object3);
		}

		// Token: 0x0600048F RID: 1167
		[Register("addContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", "GetAddContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_Handler")]
		public abstract void AddContentView(View v, ViewGroup.LayoutParams lp);

		// Token: 0x06000490 RID: 1168 RVA: 0x0000C0E0 File Offset: 0x0000A2E0
		private static Delegate GetApplyDayNightHandler()
		{
			if (AppCompatDelegate.cb_applyDayNight == null)
			{
				AppCompatDelegate.cb_applyDayNight = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AppCompatDelegate.n_ApplyDayNight));
			}
			return AppCompatDelegate.cb_applyDayNight;
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x0000C104 File Offset: 0x0000A304
		private static bool n_ApplyDayNight(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AppCompatDelegate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ApplyDayNight();
		}

		// Token: 0x06000492 RID: 1170
		[Register("applyDayNight", "()Z", "GetApplyDayNightHandler")]
		public abstract bool ApplyDayNight();

		// Token: 0x06000493 RID: 1171 RVA: 0x0000C113 File Offset: 0x0000A313
		private static Delegate GetAttachBaseContext_Landroid_content_Context_Handler()
		{
			if (AppCompatDelegate.cb_attachBaseContext_Landroid_content_Context_ == null)
			{
				AppCompatDelegate.cb_attachBaseContext_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AppCompatDelegate.n_AttachBaseContext_Landroid_content_Context_));
			}
			return AppCompatDelegate.cb_attachBaseContext_Landroid_content_Context_;
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x0000C138 File Offset: 0x0000A338
		private static void n_AttachBaseContext_Landroid_content_Context_(IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			AppCompatDelegate @object = Java.Lang.Object.GetObject<AppCompatDelegate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			@object.AttachBaseContext(object2);
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x0000C15C File Offset: 0x0000A35C
		[Register("attachBaseContext", "(Landroid/content/Context;)V", "GetAttachBaseContext_Landroid_content_Context_Handler")]
		public unsafe virtual void AttachBaseContext(Context context)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				AppCompatDelegate._members.InstanceMethods.InvokeVirtualVoidMethod("attachBaseContext.(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x0000C1C0 File Offset: 0x0000A3C0
		private static Delegate GetAttachBaseContext2_Landroid_content_Context_Handler()
		{
			if (AppCompatDelegate.cb_attachBaseContext2_Landroid_content_Context_ == null)
			{
				AppCompatDelegate.cb_attachBaseContext2_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AppCompatDelegate.n_AttachBaseContext2_Landroid_content_Context_));
			}
			return AppCompatDelegate.cb_attachBaseContext2_Landroid_content_Context_;
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x0000C1E4 File Offset: 0x0000A3E4
		private static IntPtr n_AttachBaseContext2_Landroid_content_Context_(IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			AppCompatDelegate @object = Java.Lang.Object.GetObject<AppCompatDelegate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.AttachBaseContext2(object2));
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x0000C20C File Offset: 0x0000A40C
		[Register("attachBaseContext2", "(Landroid/content/Context;)Landroid/content/Context;", "GetAttachBaseContext2_Landroid_content_Context_Handler")]
		public unsafe virtual Context AttachBaseContext2(Context context)
		{
			Context @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				@object = Java.Lang.Object.GetObject<Context>(AppCompatDelegate._members.InstanceMethods.InvokeVirtualObjectMethod("attachBaseContext2.(Landroid/content/Context;)Landroid/content/Context;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x0000C280 File Offset: 0x0000A480
		[Register("create", "(Landroid/app/Activity;Landroidx/appcompat/app/AppCompatCallback;)Landroidx/appcompat/app/AppCompatDelegate;", "")]
		public unsafe static AppCompatDelegate Create(Activity activity, IAppCompatCallback callback)
		{
			AppCompatDelegate @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : ((Java.Lang.Object)callback).Handle);
				@object = Java.Lang.Object.GetObject<AppCompatDelegate>(AppCompatDelegate._members.StaticMethods.InvokeObjectMethod("create.(Landroid/app/Activity;Landroidx/appcompat/app/AppCompatCallback;)Landroidx/appcompat/app/AppCompatDelegate;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(activity);
				GC.KeepAlive(callback);
			}
			return @object;
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x0000C320 File Offset: 0x0000A520
		[Register("create", "(Landroid/app/Dialog;Landroidx/appcompat/app/AppCompatCallback;)Landroidx/appcompat/app/AppCompatDelegate;", "")]
		public unsafe static AppCompatDelegate Create(Dialog dialog, IAppCompatCallback callback)
		{
			AppCompatDelegate @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dialog == null) ? IntPtr.Zero : dialog.Handle);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : ((Java.Lang.Object)callback).Handle);
				@object = Java.Lang.Object.GetObject<AppCompatDelegate>(AppCompatDelegate._members.StaticMethods.InvokeObjectMethod("create.(Landroid/app/Dialog;Landroidx/appcompat/app/AppCompatCallback;)Landroidx/appcompat/app/AppCompatDelegate;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(dialog);
				GC.KeepAlive(callback);
			}
			return @object;
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x0000C3C0 File Offset: 0x0000A5C0
		[Register("create", "(Landroid/content/Context;Landroid/app/Activity;Landroidx/appcompat/app/AppCompatCallback;)Landroidx/appcompat/app/AppCompatDelegate;", "")]
		public unsafe static AppCompatDelegate Create(Context context, Activity activity, IAppCompatCallback callback)
		{
			AppCompatDelegate @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ptr[2] = new JniArgumentValue((callback == null) ? IntPtr.Zero : ((Java.Lang.Object)callback).Handle);
				@object = Java.Lang.Object.GetObject<AppCompatDelegate>(AppCompatDelegate._members.StaticMethods.InvokeObjectMethod("create.(Landroid/content/Context;Landroid/app/Activity;Landroidx/appcompat/app/AppCompatCallback;)Landroidx/appcompat/app/AppCompatDelegate;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(activity);
				GC.KeepAlive(callback);
			}
			return @object;
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x0000C48C File Offset: 0x0000A68C
		[Register("create", "(Landroid/content/Context;Landroid/view/Window;Landroidx/appcompat/app/AppCompatCallback;)Landroidx/appcompat/app/AppCompatDelegate;", "")]
		public unsafe static AppCompatDelegate Create(Context context, Window window, IAppCompatCallback callback)
		{
			AppCompatDelegate @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((window == null) ? IntPtr.Zero : window.Handle);
				ptr[2] = new JniArgumentValue((callback == null) ? IntPtr.Zero : ((Java.Lang.Object)callback).Handle);
				@object = Java.Lang.Object.GetObject<AppCompatDelegate>(AppCompatDelegate._members.StaticMethods.InvokeObjectMethod("create.(Landroid/content/Context;Landroid/view/Window;Landroidx/appcompat/app/AppCompatCallback;)Landroidx/appcompat/app/AppCompatDelegate;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(window);
				GC.KeepAlive(callback);
			}
			return @object;
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x0000C558 File Offset: 0x0000A758
		private static Delegate GetCreateView_Landroid_view_View_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_Handler()
		{
			if (AppCompatDelegate.cb_createView_Landroid_view_View_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_ == null)
			{
				AppCompatDelegate.cb_createView_Landroid_view_View_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLL_L(AppCompatDelegate.n_CreateView_Landroid_view_View_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_));
			}
			return AppCompatDelegate.cb_createView_Landroid_view_View_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_;
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x0000C57C File Offset: 0x0000A77C
		private static IntPtr n_CreateView_Landroid_view_View_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_(IntPtr jnienv, IntPtr native__this, IntPtr native_parent, IntPtr native_name, IntPtr native_context, IntPtr native_attrs)
		{
			AppCompatDelegate @object = Java.Lang.Object.GetObject<AppCompatDelegate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_parent, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_name, JniHandleOwnership.DoNotTransfer);
			Context object3 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			IAttributeSet object4 = Java.Lang.Object.GetObject<IAttributeSet>(native_attrs, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.CreateView(object2, @string, object3, object4));
		}

		// Token: 0x0600049F RID: 1183
		[Register("createView", "(Landroid/view/View;Ljava/lang/String;Landroid/content/Context;Landroid/util/AttributeSet;)Landroid/view/View;", "GetCreateView_Landroid_view_View_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_Handler")]
		public abstract View CreateView(View parent, string name, Context context, IAttributeSet attrs);

		// Token: 0x060004A0 RID: 1184 RVA: 0x0000C5C1 File Offset: 0x0000A7C1
		private static Delegate GetFindViewById_IHandler()
		{
			if (AppCompatDelegate.cb_findViewById_I == null)
			{
				AppCompatDelegate.cb_findViewById_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(AppCompatDelegate.n_FindViewById_I));
			}
			return AppCompatDelegate.cb_findViewById_I;
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x0000C5E5 File Offset: 0x0000A7E5
		private static IntPtr n_FindViewById_I(IntPtr jnienv, IntPtr native__this, int id)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AppCompatDelegate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FindViewById(id));
		}

		// Token: 0x060004A2 RID: 1186
		[Register("findViewById", "(I)Landroid/view/View;", "GetFindViewById_IHandler")]
		[JavaTypeParameters(new string[]
		{
			"T extends android.view.View"
		})]
		public abstract Java.Lang.Object FindViewById(int id);

		// Token: 0x060004A3 RID: 1187 RVA: 0x0000C5FA File Offset: 0x0000A7FA
		private static Delegate GetHasWindowFeature_IHandler()
		{
			if (AppCompatDelegate.cb_hasWindowFeature_I == null)
			{
				AppCompatDelegate.cb_hasWindowFeature_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_Z(AppCompatDelegate.n_HasWindowFeature_I));
			}
			return AppCompatDelegate.cb_hasWindowFeature_I;
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x0000C61E File Offset: 0x0000A81E
		private static bool n_HasWindowFeature_I(IntPtr jnienv, IntPtr native__this, int featureId)
		{
			return Java.Lang.Object.GetObject<AppCompatDelegate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasWindowFeature(featureId);
		}

		// Token: 0x060004A5 RID: 1189
		[Register("hasWindowFeature", "(I)Z", "GetHasWindowFeature_IHandler")]
		public abstract bool HasWindowFeature(int featureId);

		// Token: 0x060004A6 RID: 1190 RVA: 0x0000C62E File Offset: 0x0000A82E
		private static Delegate GetInstallViewFactoryHandler()
		{
			if (AppCompatDelegate.cb_installViewFactory == null)
			{
				AppCompatDelegate.cb_installViewFactory = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AppCompatDelegate.n_InstallViewFactory));
			}
			return AppCompatDelegate.cb_installViewFactory;
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x0000C652 File Offset: 0x0000A852
		private static void n_InstallViewFactory(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AppCompatDelegate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).InstallViewFactory();
		}

		// Token: 0x060004A8 RID: 1192
		[Register("installViewFactory", "()V", "GetInstallViewFactoryHandler")]
		public abstract void InstallViewFactory();

		// Token: 0x060004A9 RID: 1193 RVA: 0x0000C661 File Offset: 0x0000A861
		private static Delegate GetInvalidateOptionsMenuHandler()
		{
			if (AppCompatDelegate.cb_invalidateOptionsMenu == null)
			{
				AppCompatDelegate.cb_invalidateOptionsMenu = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AppCompatDelegate.n_InvalidateOptionsMenu));
			}
			return AppCompatDelegate.cb_invalidateOptionsMenu;
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x0000C685 File Offset: 0x0000A885
		private static void n_InvalidateOptionsMenu(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AppCompatDelegate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).InvalidateOptionsMenu();
		}

		// Token: 0x060004AB RID: 1195
		[Register("invalidateOptionsMenu", "()V", "GetInvalidateOptionsMenuHandler")]
		public abstract void InvalidateOptionsMenu();

		// Token: 0x060004AC RID: 1196 RVA: 0x0000C694 File Offset: 0x0000A894
		private static Delegate GetOnConfigurationChanged_Landroid_content_res_Configuration_Handler()
		{
			if (AppCompatDelegate.cb_onConfigurationChanged_Landroid_content_res_Configuration_ == null)
			{
				AppCompatDelegate.cb_onConfigurationChanged_Landroid_content_res_Configuration_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AppCompatDelegate.n_OnConfigurationChanged_Landroid_content_res_Configuration_));
			}
			return AppCompatDelegate.cb_onConfigurationChanged_Landroid_content_res_Configuration_;
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x0000C6B8 File Offset: 0x0000A8B8
		private static void n_OnConfigurationChanged_Landroid_content_res_Configuration_(IntPtr jnienv, IntPtr native__this, IntPtr native_newConfig)
		{
			AppCompatDelegate @object = Java.Lang.Object.GetObject<AppCompatDelegate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Configuration object2 = Java.Lang.Object.GetObject<Configuration>(native_newConfig, JniHandleOwnership.DoNotTransfer);
			@object.OnConfigurationChanged(object2);
		}

		// Token: 0x060004AE RID: 1198
		[Register("onConfigurationChanged", "(Landroid/content/res/Configuration;)V", "GetOnConfigurationChanged_Landroid_content_res_Configuration_Handler")]
		public abstract void OnConfigurationChanged(Configuration newConfig);

		// Token: 0x060004AF RID: 1199 RVA: 0x0000C6DB File Offset: 0x0000A8DB
		private static Delegate GetOnCreate_Landroid_os_Bundle_Handler()
		{
			if (AppCompatDelegate.cb_onCreate_Landroid_os_Bundle_ == null)
			{
				AppCompatDelegate.cb_onCreate_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AppCompatDelegate.n_OnCreate_Landroid_os_Bundle_));
			}
			return AppCompatDelegate.cb_onCreate_Landroid_os_Bundle_;
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x0000C700 File Offset: 0x0000A900
		private static void n_OnCreate_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_savedInstanceState)
		{
			AppCompatDelegate @object = Java.Lang.Object.GetObject<AppCompatDelegate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_savedInstanceState, JniHandleOwnership.DoNotTransfer);
			@object.OnCreate(object2);
		}

		// Token: 0x060004B1 RID: 1201
		[Register("onCreate", "(Landroid/os/Bundle;)V", "GetOnCreate_Landroid_os_Bundle_Handler")]
		public abstract void OnCreate(Bundle savedInstanceState);

		// Token: 0x060004B2 RID: 1202 RVA: 0x0000C723 File Offset: 0x0000A923
		private static Delegate GetOnDestroyHandler()
		{
			if (AppCompatDelegate.cb_onDestroy == null)
			{
				AppCompatDelegate.cb_onDestroy = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AppCompatDelegate.n_OnDestroy));
			}
			return AppCompatDelegate.cb_onDestroy;
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x0000C747 File Offset: 0x0000A947
		private static void n_OnDestroy(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AppCompatDelegate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnDestroy();
		}

		// Token: 0x060004B4 RID: 1204
		[Register("onDestroy", "()V", "GetOnDestroyHandler")]
		public abstract void OnDestroy();

		// Token: 0x060004B5 RID: 1205 RVA: 0x0000C756 File Offset: 0x0000A956
		private static Delegate GetOnPostCreate_Landroid_os_Bundle_Handler()
		{
			if (AppCompatDelegate.cb_onPostCreate_Landroid_os_Bundle_ == null)
			{
				AppCompatDelegate.cb_onPostCreate_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AppCompatDelegate.n_OnPostCreate_Landroid_os_Bundle_));
			}
			return AppCompatDelegate.cb_onPostCreate_Landroid_os_Bundle_;
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x0000C77C File Offset: 0x0000A97C
		private static void n_OnPostCreate_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_savedInstanceState)
		{
			AppCompatDelegate @object = Java.Lang.Object.GetObject<AppCompatDelegate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_savedInstanceState, JniHandleOwnership.DoNotTransfer);
			@object.OnPostCreate(object2);
		}

		// Token: 0x060004B7 RID: 1207
		[Register("onPostCreate", "(Landroid/os/Bundle;)V", "GetOnPostCreate_Landroid_os_Bundle_Handler")]
		public abstract void OnPostCreate(Bundle savedInstanceState);

		// Token: 0x060004B8 RID: 1208 RVA: 0x0000C79F File Offset: 0x0000A99F
		private static Delegate GetOnPostResumeHandler()
		{
			if (AppCompatDelegate.cb_onPostResume == null)
			{
				AppCompatDelegate.cb_onPostResume = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AppCompatDelegate.n_OnPostResume));
			}
			return AppCompatDelegate.cb_onPostResume;
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x0000C7C3 File Offset: 0x0000A9C3
		private static void n_OnPostResume(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AppCompatDelegate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnPostResume();
		}

		// Token: 0x060004BA RID: 1210
		[Register("onPostResume", "()V", "GetOnPostResumeHandler")]
		public abstract void OnPostResume();

		// Token: 0x060004BB RID: 1211 RVA: 0x0000C7D2 File Offset: 0x0000A9D2
		private static Delegate GetOnSaveInstanceState_Landroid_os_Bundle_Handler()
		{
			if (AppCompatDelegate.cb_onSaveInstanceState_Landroid_os_Bundle_ == null)
			{
				AppCompatDelegate.cb_onSaveInstanceState_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AppCompatDelegate.n_OnSaveInstanceState_Landroid_os_Bundle_));
			}
			return AppCompatDelegate.cb_onSaveInstanceState_Landroid_os_Bundle_;
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x0000C7F8 File Offset: 0x0000A9F8
		private static void n_OnSaveInstanceState_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_outState)
		{
			AppCompatDelegate @object = Java.Lang.Object.GetObject<AppCompatDelegate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_outState, JniHandleOwnership.DoNotTransfer);
			@object.OnSaveInstanceState(object2);
		}

		// Token: 0x060004BD RID: 1213
		[Register("onSaveInstanceState", "(Landroid/os/Bundle;)V", "GetOnSaveInstanceState_Landroid_os_Bundle_Handler")]
		public abstract void OnSaveInstanceState(Bundle outState);

		// Token: 0x060004BE RID: 1214 RVA: 0x0000C81B File Offset: 0x0000AA1B
		private static Delegate GetOnStartHandler()
		{
			if (AppCompatDelegate.cb_onStart == null)
			{
				AppCompatDelegate.cb_onStart = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AppCompatDelegate.n_OnStart));
			}
			return AppCompatDelegate.cb_onStart;
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x0000C83F File Offset: 0x0000AA3F
		private static void n_OnStart(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AppCompatDelegate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnStart();
		}

		// Token: 0x060004C0 RID: 1216
		[Register("onStart", "()V", "GetOnStartHandler")]
		public abstract void OnStart();

		// Token: 0x060004C1 RID: 1217 RVA: 0x0000C84E File Offset: 0x0000AA4E
		private static Delegate GetOnStopHandler()
		{
			if (AppCompatDelegate.cb_onStop == null)
			{
				AppCompatDelegate.cb_onStop = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AppCompatDelegate.n_OnStop));
			}
			return AppCompatDelegate.cb_onStop;
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x0000C872 File Offset: 0x0000AA72
		private static void n_OnStop(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AppCompatDelegate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnStop();
		}

		// Token: 0x060004C3 RID: 1219
		[Register("onStop", "()V", "GetOnStopHandler")]
		public abstract void OnStop();

		// Token: 0x060004C4 RID: 1220 RVA: 0x0000C881 File Offset: 0x0000AA81
		private static Delegate GetRequestWindowFeature_IHandler()
		{
			if (AppCompatDelegate.cb_requestWindowFeature_I == null)
			{
				AppCompatDelegate.cb_requestWindowFeature_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_Z(AppCompatDelegate.n_RequestWindowFeature_I));
			}
			return AppCompatDelegate.cb_requestWindowFeature_I;
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x0000C8A5 File Offset: 0x0000AAA5
		private static bool n_RequestWindowFeature_I(IntPtr jnienv, IntPtr native__this, int featureId)
		{
			return Java.Lang.Object.GetObject<AppCompatDelegate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RequestWindowFeature(featureId);
		}

		// Token: 0x060004C6 RID: 1222
		[Register("requestWindowFeature", "(I)Z", "GetRequestWindowFeature_IHandler")]
		public abstract bool RequestWindowFeature(int featureId);

		// Token: 0x060004C7 RID: 1223 RVA: 0x0000C8B5 File Offset: 0x0000AAB5
		private static Delegate GetSetContentView_Landroid_view_View_Handler()
		{
			if (AppCompatDelegate.cb_setContentView_Landroid_view_View_ == null)
			{
				AppCompatDelegate.cb_setContentView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AppCompatDelegate.n_SetContentView_Landroid_view_View_));
			}
			return AppCompatDelegate.cb_setContentView_Landroid_view_View_;
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x0000C8DC File Offset: 0x0000AADC
		private static void n_SetContentView_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_v)
		{
			AppCompatDelegate @object = Java.Lang.Object.GetObject<AppCompatDelegate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_v, JniHandleOwnership.DoNotTransfer);
			@object.SetContentView(object2);
		}

		// Token: 0x060004C9 RID: 1225
		[Register("setContentView", "(Landroid/view/View;)V", "GetSetContentView_Landroid_view_View_Handler")]
		public abstract void SetContentView(View v);

		// Token: 0x060004CA RID: 1226 RVA: 0x0000C8FF File Offset: 0x0000AAFF
		private static Delegate GetSetContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_Handler()
		{
			if (AppCompatDelegate.cb_setContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_ == null)
			{
				AppCompatDelegate.cb_setContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(AppCompatDelegate.n_SetContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_));
			}
			return AppCompatDelegate.cb_setContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_;
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x0000C924 File Offset: 0x0000AB24
		private static void n_SetContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_(IntPtr jnienv, IntPtr native__this, IntPtr native_v, IntPtr native_lp)
		{
			AppCompatDelegate @object = Java.Lang.Object.GetObject<AppCompatDelegate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_v, JniHandleOwnership.DoNotTransfer);
			ViewGroup.LayoutParams object3 = Java.Lang.Object.GetObject<ViewGroup.LayoutParams>(native_lp, JniHandleOwnership.DoNotTransfer);
			@object.SetContentView(object2, object3);
		}

		// Token: 0x060004CC RID: 1228
		[Register("setContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", "GetSetContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_Handler")]
		public abstract void SetContentView(View v, ViewGroup.LayoutParams lp);

		// Token: 0x060004CD RID: 1229 RVA: 0x0000C950 File Offset: 0x0000AB50
		private static Delegate GetSetContentView_IHandler()
		{
			if (AppCompatDelegate.cb_setContentView_I == null)
			{
				AppCompatDelegate.cb_setContentView_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(AppCompatDelegate.n_SetContentView_I));
			}
			return AppCompatDelegate.cb_setContentView_I;
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x0000C974 File Offset: 0x0000AB74
		private static void n_SetContentView_I(IntPtr jnienv, IntPtr native__this, int resId)
		{
			Java.Lang.Object.GetObject<AppCompatDelegate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetContentView(resId);
		}

		// Token: 0x060004CF RID: 1231
		[Register("setContentView", "(I)V", "GetSetContentView_IHandler")]
		public abstract void SetContentView(int resId);

		// Token: 0x060004D0 RID: 1232 RVA: 0x0000C984 File Offset: 0x0000AB84
		private static Delegate GetSetLocalNightMode_IHandler()
		{
			if (AppCompatDelegate.cb_setLocalNightMode_I == null)
			{
				AppCompatDelegate.cb_setLocalNightMode_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(AppCompatDelegate.n_SetLocalNightMode_I));
			}
			return AppCompatDelegate.cb_setLocalNightMode_I;
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x0000C9A8 File Offset: 0x0000ABA8
		private static void n_SetLocalNightMode_I(IntPtr jnienv, IntPtr native__this, int mode)
		{
			Java.Lang.Object.GetObject<AppCompatDelegate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetLocalNightMode(mode);
		}

		// Token: 0x060004D2 RID: 1234
		[Register("setLocalNightMode", "(I)V", "GetSetLocalNightMode_IHandler")]
		public abstract void SetLocalNightMode(int mode);

		// Token: 0x060004D3 RID: 1235 RVA: 0x0000C9B8 File Offset: 0x0000ABB8
		private static Delegate GetSetSupportActionBar_Landroidx_appcompat_widget_Toolbar_Handler()
		{
			if (AppCompatDelegate.cb_setSupportActionBar_Landroidx_appcompat_widget_Toolbar_ == null)
			{
				AppCompatDelegate.cb_setSupportActionBar_Landroidx_appcompat_widget_Toolbar_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AppCompatDelegate.n_SetSupportActionBar_Landroidx_appcompat_widget_Toolbar_));
			}
			return AppCompatDelegate.cb_setSupportActionBar_Landroidx_appcompat_widget_Toolbar_;
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x0000C9DC File Offset: 0x0000ABDC
		private static void n_SetSupportActionBar_Landroidx_appcompat_widget_Toolbar_(IntPtr jnienv, IntPtr native__this, IntPtr native_toolbar)
		{
			AppCompatDelegate @object = Java.Lang.Object.GetObject<AppCompatDelegate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Toolbar object2 = Java.Lang.Object.GetObject<Toolbar>(native_toolbar, JniHandleOwnership.DoNotTransfer);
			@object.SetSupportActionBar(object2);
		}

		// Token: 0x060004D5 RID: 1237
		[Register("setSupportActionBar", "(Landroidx/appcompat/widget/Toolbar;)V", "GetSetSupportActionBar_Landroidx_appcompat_widget_Toolbar_Handler")]
		public abstract void SetSupportActionBar(Toolbar toolbar);

		// Token: 0x060004D6 RID: 1238 RVA: 0x0000C9FF File Offset: 0x0000ABFF
		private static Delegate GetSetTheme_IHandler()
		{
			if (AppCompatDelegate.cb_setTheme_I == null)
			{
				AppCompatDelegate.cb_setTheme_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(AppCompatDelegate.n_SetTheme_I));
			}
			return AppCompatDelegate.cb_setTheme_I;
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x0000CA23 File Offset: 0x0000AC23
		private static void n_SetTheme_I(IntPtr jnienv, IntPtr native__this, int themeResId)
		{
			Java.Lang.Object.GetObject<AppCompatDelegate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetTheme(themeResId);
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x0000CA34 File Offset: 0x0000AC34
		[Register("setTheme", "(I)V", "GetSetTheme_IHandler")]
		public unsafe virtual void SetTheme(int themeResId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(themeResId);
			AppCompatDelegate._members.InstanceMethods.InvokeVirtualVoidMethod("setTheme.(I)V", this, ptr);
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x0000CA6F File Offset: 0x0000AC6F
		private static Delegate GetSetTitle_Ljava_lang_CharSequence_Handler()
		{
			if (AppCompatDelegate.cb_setTitle_Ljava_lang_CharSequence_ == null)
			{
				AppCompatDelegate.cb_setTitle_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AppCompatDelegate.n_SetTitle_Ljava_lang_CharSequence_));
			}
			return AppCompatDelegate.cb_setTitle_Ljava_lang_CharSequence_;
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x0000CA94 File Offset: 0x0000AC94
		private static void n_SetTitle_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_title)
		{
			AppCompatDelegate @object = Java.Lang.Object.GetObject<AppCompatDelegate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_title, JniHandleOwnership.DoNotTransfer);
			@object.SetTitle(object2);
		}

		// Token: 0x060004DB RID: 1243
		[Register("setTitle", "(Ljava/lang/CharSequence;)V", "GetSetTitle_Ljava_lang_CharSequence_Handler")]
		public abstract void SetTitle(ICharSequence title);

		// Token: 0x060004DC RID: 1244 RVA: 0x0000CAB8 File Offset: 0x0000ACB8
		public void SetTitle(string title)
		{
			Java.Lang.String @string = (title == null) ? null : new Java.Lang.String(title);
			this.SetTitle(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x0000CAE2 File Offset: 0x0000ACE2
		private static Delegate GetStartSupportActionMode_Landroidx_appcompat_view_ActionMode_Callback_Handler()
		{
			if (AppCompatDelegate.cb_startSupportActionMode_Landroidx_appcompat_view_ActionMode_Callback_ == null)
			{
				AppCompatDelegate.cb_startSupportActionMode_Landroidx_appcompat_view_ActionMode_Callback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AppCompatDelegate.n_StartSupportActionMode_Landroidx_appcompat_view_ActionMode_Callback_));
			}
			return AppCompatDelegate.cb_startSupportActionMode_Landroidx_appcompat_view_ActionMode_Callback_;
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x0000CB08 File Offset: 0x0000AD08
		private static IntPtr n_StartSupportActionMode_Landroidx_appcompat_view_ActionMode_Callback_(IntPtr jnienv, IntPtr native__this, IntPtr native_callback)
		{
			AppCompatDelegate @object = Java.Lang.Object.GetObject<AppCompatDelegate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AndroidX.AppCompat.View.ActionMode.ICallback object2 = Java.Lang.Object.GetObject<AndroidX.AppCompat.View.ActionMode.ICallback>(native_callback, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.StartSupportActionMode(object2));
		}

		// Token: 0x060004DF RID: 1247
		[Register("startSupportActionMode", "(Landroidx/appcompat/view/ActionMode$Callback;)Landroidx/appcompat/view/ActionMode;", "GetStartSupportActionMode_Landroidx_appcompat_view_ActionMode_Callback_Handler")]
		public abstract AndroidX.AppCompat.View.ActionMode StartSupportActionMode(AndroidX.AppCompat.View.ActionMode.ICallback callback_);

		// Token: 0x04000106 RID: 262
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/appcompat/app/AppCompatDelegate", typeof(AppCompatDelegate));

		// Token: 0x04000107 RID: 263
		private static Delegate cb_getContextForDelegate;

		// Token: 0x04000108 RID: 264
		private static Delegate cb_getDrawerToggleDelegate;

		// Token: 0x04000109 RID: 265
		private static Delegate cb_isHandleNativeActionModesEnabled;

		// Token: 0x0400010A RID: 266
		private static Delegate cb_setHandleNativeActionModesEnabled_Z;

		// Token: 0x0400010B RID: 267
		private static Delegate cb_getLocalNightMode;

		// Token: 0x0400010C RID: 268
		private static Delegate cb_getMenuInflater;

		// Token: 0x0400010D RID: 269
		private static Delegate cb_getSupportActionBar;

		// Token: 0x0400010E RID: 270
		private static Delegate cb_addContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_;

		// Token: 0x0400010F RID: 271
		private static Delegate cb_applyDayNight;

		// Token: 0x04000110 RID: 272
		private static Delegate cb_attachBaseContext_Landroid_content_Context_;

		// Token: 0x04000111 RID: 273
		private static Delegate cb_attachBaseContext2_Landroid_content_Context_;

		// Token: 0x04000112 RID: 274
		private static Delegate cb_createView_Landroid_view_View_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_;

		// Token: 0x04000113 RID: 275
		private static Delegate cb_findViewById_I;

		// Token: 0x04000114 RID: 276
		private static Delegate cb_hasWindowFeature_I;

		// Token: 0x04000115 RID: 277
		private static Delegate cb_installViewFactory;

		// Token: 0x04000116 RID: 278
		private static Delegate cb_invalidateOptionsMenu;

		// Token: 0x04000117 RID: 279
		private static Delegate cb_onConfigurationChanged_Landroid_content_res_Configuration_;

		// Token: 0x04000118 RID: 280
		private static Delegate cb_onCreate_Landroid_os_Bundle_;

		// Token: 0x04000119 RID: 281
		private static Delegate cb_onDestroy;

		// Token: 0x0400011A RID: 282
		private static Delegate cb_onPostCreate_Landroid_os_Bundle_;

		// Token: 0x0400011B RID: 283
		private static Delegate cb_onPostResume;

		// Token: 0x0400011C RID: 284
		private static Delegate cb_onSaveInstanceState_Landroid_os_Bundle_;

		// Token: 0x0400011D RID: 285
		private static Delegate cb_onStart;

		// Token: 0x0400011E RID: 286
		private static Delegate cb_onStop;

		// Token: 0x0400011F RID: 287
		private static Delegate cb_requestWindowFeature_I;

		// Token: 0x04000120 RID: 288
		private static Delegate cb_setContentView_Landroid_view_View_;

		// Token: 0x04000121 RID: 289
		private static Delegate cb_setContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_;

		// Token: 0x04000122 RID: 290
		private static Delegate cb_setContentView_I;

		// Token: 0x04000123 RID: 291
		private static Delegate cb_setLocalNightMode_I;

		// Token: 0x04000124 RID: 292
		private static Delegate cb_setSupportActionBar_Landroidx_appcompat_widget_Toolbar_;

		// Token: 0x04000125 RID: 293
		private static Delegate cb_setTheme_I;

		// Token: 0x04000126 RID: 294
		private static Delegate cb_setTitle_Ljava_lang_CharSequence_;

		// Token: 0x04000127 RID: 295
		private static Delegate cb_startSupportActionMode_Landroidx_appcompat_view_ActionMode_Callback_;
	}
}
