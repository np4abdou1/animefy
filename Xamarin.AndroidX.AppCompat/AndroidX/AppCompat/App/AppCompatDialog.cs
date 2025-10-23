using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using AndroidX.Activity;
using AndroidX.AppCompat.View;
using Java.Interop;
using Java.Lang;

namespace AndroidX.AppCompat.App
{
	// Token: 0x02000057 RID: 87
	[Register("androidx/appcompat/app/AppCompatDialog", DoNotGenerateAcw = true)]
	public class AppCompatDialog : ComponentDialog, IAppCompatCallback, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000501 RID: 1281 RVA: 0x0000D3AC File Offset: 0x0000B5AC
		internal static IntPtr class_ref
		{
			get
			{
				return AppCompatDialog._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000502 RID: 1282 RVA: 0x0000D3D0 File Offset: 0x0000B5D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AppCompatDialog._members;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000503 RID: 1283 RVA: 0x0000D3D8 File Offset: 0x0000B5D8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AppCompatDialog._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000504 RID: 1284 RVA: 0x0000D3FC File Offset: 0x0000B5FC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AppCompatDialog._members.ManagedPeerType;
			}
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x0000D408 File Offset: 0x0000B608
		protected AppCompatDialog(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x0000D414 File Offset: 0x0000B614
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe AppCompatDialog(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(AppCompatDialog._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AppCompatDialog._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x0000D4C4 File Offset: 0x0000B6C4
		[Register(".ctor", "(Landroid/content/Context;ZLandroid/content/DialogInterface$OnCancelListener;)V", "")]
		protected unsafe AppCompatDialog(Context context, bool cancelable, IDialogInterfaceOnCancelListener cancelListener) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(cancelable);
				ptr[2] = new JniArgumentValue((cancelListener == null) ? IntPtr.Zero : ((Java.Lang.Object)cancelListener).Handle);
				base.SetHandle(AppCompatDialog._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;ZLandroid/content/DialogInterface$OnCancelListener;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AppCompatDialog._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;ZLandroid/content/DialogInterface$OnCancelListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(cancelListener);
			}
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x0000D5B4 File Offset: 0x0000B7B4
		[Register(".ctor", "(Landroid/content/Context;I)V", "")]
		public unsafe AppCompatDialog(Context context, int theme) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(theme);
				base.SetHandle(AppCompatDialog._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AppCompatDialog._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x0000D674 File Offset: 0x0000B874
		private static Delegate GetGetDelegateHandler()
		{
			if (AppCompatDialog.cb_getDelegate == null)
			{
				AppCompatDialog.cb_getDelegate = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppCompatDialog.n_GetDelegate));
			}
			return AppCompatDialog.cb_getDelegate;
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x0000D698 File Offset: 0x0000B898
		private static IntPtr n_GetDelegate(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AppCompatDialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Delegate);
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600050B RID: 1291 RVA: 0x0000D6AC File Offset: 0x0000B8AC
		public virtual AppCompatDelegate Delegate
		{
			[Register("getDelegate", "()Landroidx/appcompat/app/AppCompatDelegate;", "GetGetDelegateHandler")]
			get
			{
				return Java.Lang.Object.GetObject<AppCompatDelegate>(AppCompatDialog._members.InstanceMethods.InvokeVirtualObjectMethod("getDelegate.()Landroidx/appcompat/app/AppCompatDelegate;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x0000D6DE File Offset: 0x0000B8DE
		private static Delegate GetGetSupportActionBarHandler()
		{
			if (AppCompatDialog.cb_getSupportActionBar == null)
			{
				AppCompatDialog.cb_getSupportActionBar = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppCompatDialog.n_GetSupportActionBar));
			}
			return AppCompatDialog.cb_getSupportActionBar;
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x0000D702 File Offset: 0x0000B902
		private static IntPtr n_GetSupportActionBar(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AppCompatDialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SupportActionBar);
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x0000D718 File Offset: 0x0000B918
		public virtual ActionBar SupportActionBar
		{
			[Register("getSupportActionBar", "()Landroidx/appcompat/app/ActionBar;", "GetGetSupportActionBarHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ActionBar>(AppCompatDialog._members.InstanceMethods.InvokeVirtualObjectMethod("getSupportActionBar.()Landroidx/appcompat/app/ActionBar;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x0000D74A File Offset: 0x0000B94A
		private static Delegate GetOnSupportActionModeFinished_Landroidx_appcompat_view_ActionMode_Handler()
		{
			if (AppCompatDialog.cb_onSupportActionModeFinished_Landroidx_appcompat_view_ActionMode_ == null)
			{
				AppCompatDialog.cb_onSupportActionModeFinished_Landroidx_appcompat_view_ActionMode_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AppCompatDialog.n_OnSupportActionModeFinished_Landroidx_appcompat_view_ActionMode_));
			}
			return AppCompatDialog.cb_onSupportActionModeFinished_Landroidx_appcompat_view_ActionMode_;
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x0000D770 File Offset: 0x0000B970
		private static void n_OnSupportActionModeFinished_Landroidx_appcompat_view_ActionMode_(IntPtr jnienv, IntPtr native__this, IntPtr native_mode)
		{
			AppCompatDialog @object = Java.Lang.Object.GetObject<AppCompatDialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ActionMode object2 = Java.Lang.Object.GetObject<ActionMode>(native_mode, JniHandleOwnership.DoNotTransfer);
			@object.OnSupportActionModeFinished(object2);
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x0000D794 File Offset: 0x0000B994
		[Register("onSupportActionModeFinished", "(Landroidx/appcompat/view/ActionMode;)V", "GetOnSupportActionModeFinished_Landroidx_appcompat_view_ActionMode_Handler")]
		public unsafe virtual void OnSupportActionModeFinished(ActionMode mode)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((mode == null) ? IntPtr.Zero : mode.Handle);
				AppCompatDialog._members.InstanceMethods.InvokeVirtualVoidMethod("onSupportActionModeFinished.(Landroidx/appcompat/view/ActionMode;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(mode);
			}
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x0000D7F8 File Offset: 0x0000B9F8
		private static Delegate GetOnSupportActionModeStarted_Landroidx_appcompat_view_ActionMode_Handler()
		{
			if (AppCompatDialog.cb_onSupportActionModeStarted_Landroidx_appcompat_view_ActionMode_ == null)
			{
				AppCompatDialog.cb_onSupportActionModeStarted_Landroidx_appcompat_view_ActionMode_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AppCompatDialog.n_OnSupportActionModeStarted_Landroidx_appcompat_view_ActionMode_));
			}
			return AppCompatDialog.cb_onSupportActionModeStarted_Landroidx_appcompat_view_ActionMode_;
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x0000D81C File Offset: 0x0000BA1C
		private static void n_OnSupportActionModeStarted_Landroidx_appcompat_view_ActionMode_(IntPtr jnienv, IntPtr native__this, IntPtr native_mode)
		{
			AppCompatDialog @object = Java.Lang.Object.GetObject<AppCompatDialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ActionMode object2 = Java.Lang.Object.GetObject<ActionMode>(native_mode, JniHandleOwnership.DoNotTransfer);
			@object.OnSupportActionModeStarted(object2);
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x0000D840 File Offset: 0x0000BA40
		[Register("onSupportActionModeStarted", "(Landroidx/appcompat/view/ActionMode;)V", "GetOnSupportActionModeStarted_Landroidx_appcompat_view_ActionMode_Handler")]
		public unsafe virtual void OnSupportActionModeStarted(ActionMode mode)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((mode == null) ? IntPtr.Zero : mode.Handle);
				AppCompatDialog._members.InstanceMethods.InvokeVirtualVoidMethod("onSupportActionModeStarted.(Landroidx/appcompat/view/ActionMode;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(mode);
			}
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x0000D8A4 File Offset: 0x0000BAA4
		private static Delegate GetOnWindowStartingSupportActionMode_Landroidx_appcompat_view_ActionMode_Callback_Handler()
		{
			if (AppCompatDialog.cb_onWindowStartingSupportActionMode_Landroidx_appcompat_view_ActionMode_Callback_ == null)
			{
				AppCompatDialog.cb_onWindowStartingSupportActionMode_Landroidx_appcompat_view_ActionMode_Callback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AppCompatDialog.n_OnWindowStartingSupportActionMode_Landroidx_appcompat_view_ActionMode_Callback_));
			}
			return AppCompatDialog.cb_onWindowStartingSupportActionMode_Landroidx_appcompat_view_ActionMode_Callback_;
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x0000D8C8 File Offset: 0x0000BAC8
		private static IntPtr n_OnWindowStartingSupportActionMode_Landroidx_appcompat_view_ActionMode_Callback_(IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			AppCompatDialog @object = Java.Lang.Object.GetObject<AppCompatDialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ActionMode.ICallback object2 = Java.Lang.Object.GetObject<ActionMode.ICallback>(native__callback, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.OnWindowStartingSupportActionMode(object2));
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x0000D8F0 File Offset: 0x0000BAF0
		[Register("onWindowStartingSupportActionMode", "(Landroidx/appcompat/view/ActionMode$Callback;)Landroidx/appcompat/view/ActionMode;", "GetOnWindowStartingSupportActionMode_Landroidx_appcompat_view_ActionMode_Callback_Handler")]
		public unsafe virtual ActionMode OnWindowStartingSupportActionMode(ActionMode.ICallback callback)
		{
			ActionMode @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : ((Java.Lang.Object)callback).Handle);
				@object = Java.Lang.Object.GetObject<ActionMode>(AppCompatDialog._members.InstanceMethods.InvokeVirtualObjectMethod("onWindowStartingSupportActionMode.(Landroidx/appcompat/view/ActionMode$Callback;)Landroidx/appcompat/view/ActionMode;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
			return @object;
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x0000D968 File Offset: 0x0000BB68
		private static Delegate GetSupportRequestWindowFeature_IHandler()
		{
			if (AppCompatDialog.cb_supportRequestWindowFeature_I == null)
			{
				AppCompatDialog.cb_supportRequestWindowFeature_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_Z(AppCompatDialog.n_SupportRequestWindowFeature_I));
			}
			return AppCompatDialog.cb_supportRequestWindowFeature_I;
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x0000D98C File Offset: 0x0000BB8C
		private static bool n_SupportRequestWindowFeature_I(IntPtr jnienv, IntPtr native__this, int featureId)
		{
			return Java.Lang.Object.GetObject<AppCompatDialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SupportRequestWindowFeature(featureId);
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x0000D99C File Offset: 0x0000BB9C
		[Register("supportRequestWindowFeature", "(I)Z", "GetSupportRequestWindowFeature_IHandler")]
		public unsafe virtual bool SupportRequestWindowFeature(int featureId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(featureId);
			return AppCompatDialog._members.InstanceMethods.InvokeVirtualBooleanMethod("supportRequestWindowFeature.(I)Z", this, ptr);
		}

		// Token: 0x04000129 RID: 297
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/appcompat/app/AppCompatDialog", typeof(AppCompatDialog));

		// Token: 0x0400012A RID: 298
		private static Delegate cb_getDelegate;

		// Token: 0x0400012B RID: 299
		private static Delegate cb_getSupportActionBar;

		// Token: 0x0400012C RID: 300
		private static Delegate cb_onSupportActionModeFinished_Landroidx_appcompat_view_ActionMode_;

		// Token: 0x0400012D RID: 301
		private static Delegate cb_onSupportActionModeStarted_Landroidx_appcompat_view_ActionMode_;

		// Token: 0x0400012E RID: 302
		private static Delegate cb_onWindowStartingSupportActionMode_Landroidx_appcompat_view_ActionMode_Callback_;

		// Token: 0x0400012F RID: 303
		private static Delegate cb_supportRequestWindowFeature_I;
	}
}
