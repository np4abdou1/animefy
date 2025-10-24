using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using AndroidX.Activity;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Fragment.App
{
	// Token: 0x02000028 RID: 40
	[Register("androidx/fragment/app/DialogFragment", DoNotGenerateAcw = true)]
	public class DialogFragment : Fragment, IDialogInterfaceOnCancelListener, IJavaObject, IDisposable, IJavaPeerable, IDialogInterfaceOnDismissListener
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x060000BD RID: 189 RVA: 0x00002A74 File Offset: 0x00000C74
		internal new static IntPtr class_ref
		{
			get
			{
				return DialogFragment._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x060000BE RID: 190 RVA: 0x00002A98 File Offset: 0x00000C98
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DialogFragment._members;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x060000BF RID: 191 RVA: 0x00002AA0 File Offset: 0x00000CA0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DialogFragment._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00002AC4 File Offset: 0x00000CC4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DialogFragment._members.ManagedPeerType;
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002AD0 File Offset: 0x00000CD0
		protected DialogFragment(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002ADC File Offset: 0x00000CDC
		[Register(".ctor", "()V", "")]
		public DialogFragment() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(DialogFragment._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			DialogFragment._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002B4C File Offset: 0x00000D4C
		[Register(".ctor", "(I)V", "")]
		public unsafe DialogFragment(int contentLayoutId) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(contentLayoutId);
			base.SetHandle(DialogFragment._members.InstanceMethods.StartCreateInstance("(I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			DialogFragment._members.InstanceMethods.FinishCreateInstance("(I)V", this, ptr);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002BD0 File Offset: 0x00000DD0
		private static Delegate GetIsCancelableHandler()
		{
			if (DialogFragment.cb_isCancelable == null)
			{
				DialogFragment.cb_isCancelable = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(DialogFragment.n_IsCancelable));
			}
			return DialogFragment.cb_isCancelable;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002BF4 File Offset: 0x00000DF4
		private static bool n_IsCancelable(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<DialogFragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Cancelable;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002C03 File Offset: 0x00000E03
		private static Delegate GetSetCancelable_ZHandler()
		{
			if (DialogFragment.cb_setCancelable_Z == null)
			{
				DialogFragment.cb_setCancelable_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(DialogFragment.n_SetCancelable_Z));
			}
			return DialogFragment.cb_setCancelable_Z;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002C27 File Offset: 0x00000E27
		private static void n_SetCancelable_Z(IntPtr jnienv, IntPtr native__this, bool cancelable)
		{
			Java.Lang.Object.GetObject<DialogFragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Cancelable = cancelable;
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00002C37 File Offset: 0x00000E37
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x00002C50 File Offset: 0x00000E50
		public unsafe virtual bool Cancelable
		{
			[Register("isCancelable", "()Z", "GetIsCancelableHandler")]
			get
			{
				return DialogFragment._members.InstanceMethods.InvokeVirtualBooleanMethod("isCancelable.()Z", this, null);
			}
			[Register("setCancelable", "(Z)V", "GetSetCancelable_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				DialogFragment._members.InstanceMethods.InvokeVirtualVoidMethod("setCancelable.(Z)V", this, ptr);
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002C8B File Offset: 0x00000E8B
		private static Delegate GetGetDialogHandler()
		{
			if (DialogFragment.cb_getDialog == null)
			{
				DialogFragment.cb_getDialog = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(DialogFragment.n_GetDialog));
			}
			return DialogFragment.cb_getDialog;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002CAF File Offset: 0x00000EAF
		private static IntPtr n_GetDialog(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<DialogFragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Dialog);
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00002CC4 File Offset: 0x00000EC4
		public virtual Dialog Dialog
		{
			[Register("getDialog", "()Landroid/app/Dialog;", "GetGetDialogHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Dialog>(DialogFragment._members.InstanceMethods.InvokeVirtualObjectMethod("getDialog.()Landroid/app/Dialog;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002CF6 File Offset: 0x00000EF6
		private static Delegate GetGetShowsDialogHandler()
		{
			if (DialogFragment.cb_getShowsDialog == null)
			{
				DialogFragment.cb_getShowsDialog = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(DialogFragment.n_GetShowsDialog));
			}
			return DialogFragment.cb_getShowsDialog;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002D1A File Offset: 0x00000F1A
		private static bool n_GetShowsDialog(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<DialogFragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShowsDialog;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002D29 File Offset: 0x00000F29
		private static Delegate GetSetShowsDialog_ZHandler()
		{
			if (DialogFragment.cb_setShowsDialog_Z == null)
			{
				DialogFragment.cb_setShowsDialog_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(DialogFragment.n_SetShowsDialog_Z));
			}
			return DialogFragment.cb_setShowsDialog_Z;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002D4D File Offset: 0x00000F4D
		private static void n_SetShowsDialog_Z(IntPtr jnienv, IntPtr native__this, bool showsDialog)
		{
			Java.Lang.Object.GetObject<DialogFragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShowsDialog = showsDialog;
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00002D5D File Offset: 0x00000F5D
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x00002D78 File Offset: 0x00000F78
		public unsafe virtual bool ShowsDialog
		{
			[Register("getShowsDialog", "()Z", "GetGetShowsDialogHandler")]
			get
			{
				return DialogFragment._members.InstanceMethods.InvokeVirtualBooleanMethod("getShowsDialog.()Z", this, null);
			}
			[Register("setShowsDialog", "(Z)V", "GetSetShowsDialog_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				DialogFragment._members.InstanceMethods.InvokeVirtualVoidMethod("setShowsDialog.(Z)V", this, ptr);
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002DB3 File Offset: 0x00000FB3
		private static Delegate GetGetThemeHandler()
		{
			if (DialogFragment.cb_getTheme == null)
			{
				DialogFragment.cb_getTheme = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(DialogFragment.n_GetTheme));
			}
			return DialogFragment.cb_getTheme;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002DD7 File Offset: 0x00000FD7
		private static int n_GetTheme(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<DialogFragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Theme;
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00002DE6 File Offset: 0x00000FE6
		public virtual int Theme
		{
			[Register("getTheme", "()I", "GetGetThemeHandler")]
			get
			{
				return DialogFragment._members.InstanceMethods.InvokeVirtualInt32Method("getTheme.()I", this, null);
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00002DFF File Offset: 0x00000FFF
		private static Delegate GetDismissHandler()
		{
			if (DialogFragment.cb_dismiss == null)
			{
				DialogFragment.cb_dismiss = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(DialogFragment.n_Dismiss));
			}
			return DialogFragment.cb_dismiss;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00002E23 File Offset: 0x00001023
		private static void n_Dismiss(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<DialogFragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Dismiss();
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002E32 File Offset: 0x00001032
		[Register("dismiss", "()V", "GetDismissHandler")]
		public virtual void Dismiss()
		{
			DialogFragment._members.InstanceMethods.InvokeVirtualVoidMethod("dismiss.()V", this, null);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002E4B File Offset: 0x0000104B
		private static Delegate GetDismissAllowingStateLossHandler()
		{
			if (DialogFragment.cb_dismissAllowingStateLoss == null)
			{
				DialogFragment.cb_dismissAllowingStateLoss = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(DialogFragment.n_DismissAllowingStateLoss));
			}
			return DialogFragment.cb_dismissAllowingStateLoss;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002E6F File Offset: 0x0000106F
		private static void n_DismissAllowingStateLoss(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<DialogFragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DismissAllowingStateLoss();
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002E7E File Offset: 0x0000107E
		[Register("dismissAllowingStateLoss", "()V", "GetDismissAllowingStateLossHandler")]
		public virtual void DismissAllowingStateLoss()
		{
			DialogFragment._members.InstanceMethods.InvokeVirtualVoidMethod("dismissAllowingStateLoss.()V", this, null);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00002E97 File Offset: 0x00001097
		private static Delegate GetDismissNowHandler()
		{
			if (DialogFragment.cb_dismissNow == null)
			{
				DialogFragment.cb_dismissNow = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(DialogFragment.n_DismissNow));
			}
			return DialogFragment.cb_dismissNow;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002EBB File Offset: 0x000010BB
		private static void n_DismissNow(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<DialogFragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DismissNow();
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002ECA File Offset: 0x000010CA
		[Register("dismissNow", "()V", "GetDismissNowHandler")]
		public virtual void DismissNow()
		{
			DialogFragment._members.InstanceMethods.InvokeVirtualVoidMethod("dismissNow.()V", this, null);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002EE3 File Offset: 0x000010E3
		private static Delegate GetOnCancel_Landroid_content_DialogInterface_Handler()
		{
			if (DialogFragment.cb_onCancel_Landroid_content_DialogInterface_ == null)
			{
				DialogFragment.cb_onCancel_Landroid_content_DialogInterface_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(DialogFragment.n_OnCancel_Landroid_content_DialogInterface_));
			}
			return DialogFragment.cb_onCancel_Landroid_content_DialogInterface_;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00002F08 File Offset: 0x00001108
		private static void n_OnCancel_Landroid_content_DialogInterface_(IntPtr jnienv, IntPtr native__this, IntPtr native_dialog)
		{
			DialogFragment @object = Java.Lang.Object.GetObject<DialogFragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IDialogInterface object2 = Java.Lang.Object.GetObject<IDialogInterface>(native_dialog, JniHandleOwnership.DoNotTransfer);
			@object.OnCancel(object2);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002F2C File Offset: 0x0000112C
		[Register("onCancel", "(Landroid/content/DialogInterface;)V", "GetOnCancel_Landroid_content_DialogInterface_Handler")]
		public unsafe virtual void OnCancel(IDialogInterface dialog)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dialog == null) ? IntPtr.Zero : ((Java.Lang.Object)dialog).Handle);
				DialogFragment._members.InstanceMethods.InvokeVirtualVoidMethod("onCancel.(Landroid/content/DialogInterface;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(dialog);
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002F94 File Offset: 0x00001194
		private static Delegate GetOnCreateDialog_Landroid_os_Bundle_Handler()
		{
			if (DialogFragment.cb_onCreateDialog_Landroid_os_Bundle_ == null)
			{
				DialogFragment.cb_onCreateDialog_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(DialogFragment.n_OnCreateDialog_Landroid_os_Bundle_));
			}
			return DialogFragment.cb_onCreateDialog_Landroid_os_Bundle_;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002FB8 File Offset: 0x000011B8
		private static IntPtr n_OnCreateDialog_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_savedInstanceState)
		{
			DialogFragment @object = Java.Lang.Object.GetObject<DialogFragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_savedInstanceState, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.OnCreateDialog(object2));
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002FE0 File Offset: 0x000011E0
		[Register("onCreateDialog", "(Landroid/os/Bundle;)Landroid/app/Dialog;", "GetOnCreateDialog_Landroid_os_Bundle_Handler")]
		public unsafe virtual Dialog OnCreateDialog(Bundle savedInstanceState)
		{
			Dialog @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((savedInstanceState == null) ? IntPtr.Zero : savedInstanceState.Handle);
				@object = Java.Lang.Object.GetObject<Dialog>(DialogFragment._members.InstanceMethods.InvokeVirtualObjectMethod("onCreateDialog.(Landroid/os/Bundle;)Landroid/app/Dialog;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(savedInstanceState);
			}
			return @object;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00003054 File Offset: 0x00001254
		private static Delegate GetOnDismiss_Landroid_content_DialogInterface_Handler()
		{
			if (DialogFragment.cb_onDismiss_Landroid_content_DialogInterface_ == null)
			{
				DialogFragment.cb_onDismiss_Landroid_content_DialogInterface_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(DialogFragment.n_OnDismiss_Landroid_content_DialogInterface_));
			}
			return DialogFragment.cb_onDismiss_Landroid_content_DialogInterface_;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00003078 File Offset: 0x00001278
		private static void n_OnDismiss_Landroid_content_DialogInterface_(IntPtr jnienv, IntPtr native__this, IntPtr native_dialog)
		{
			DialogFragment @object = Java.Lang.Object.GetObject<DialogFragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IDialogInterface object2 = Java.Lang.Object.GetObject<IDialogInterface>(native_dialog, JniHandleOwnership.DoNotTransfer);
			@object.OnDismiss(object2);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0000309C File Offset: 0x0000129C
		[Register("onDismiss", "(Landroid/content/DialogInterface;)V", "GetOnDismiss_Landroid_content_DialogInterface_Handler")]
		public unsafe virtual void OnDismiss(IDialogInterface dialog)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dialog == null) ? IntPtr.Zero : ((Java.Lang.Object)dialog).Handle);
				DialogFragment._members.InstanceMethods.InvokeVirtualVoidMethod("onDismiss.(Landroid/content/DialogInterface;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(dialog);
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00003104 File Offset: 0x00001304
		[Register("requireComponentDialog", "()Landroidx/activity/ComponentDialog;", "")]
		public ComponentDialog RequireComponentDialog()
		{
			return Java.Lang.Object.GetObject<ComponentDialog>(DialogFragment._members.InstanceMethods.InvokeNonvirtualObjectMethod("requireComponentDialog.()Landroidx/activity/ComponentDialog;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00003138 File Offset: 0x00001338
		[Register("requireDialog", "()Landroid/app/Dialog;", "")]
		public Dialog RequireDialog()
		{
			return Java.Lang.Object.GetObject<Dialog>(DialogFragment._members.InstanceMethods.InvokeNonvirtualObjectMethod("requireDialog.()Landroid/app/Dialog;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000316A File Offset: 0x0000136A
		private static Delegate GetSetStyle_IIHandler()
		{
			if (DialogFragment.cb_setStyle_II == null)
			{
				DialogFragment.cb_setStyle_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_V(DialogFragment.n_SetStyle_II));
			}
			return DialogFragment.cb_setStyle_II;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000318E File Offset: 0x0000138E
		private static void n_SetStyle_II(IntPtr jnienv, IntPtr native__this, int style, int theme)
		{
			Java.Lang.Object.GetObject<DialogFragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetStyle(style, theme);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000031A0 File Offset: 0x000013A0
		[Register("setStyle", "(II)V", "GetSetStyle_IIHandler")]
		public unsafe virtual void SetStyle(int style, int theme)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(style);
			ptr[1] = new JniArgumentValue(theme);
			DialogFragment._members.InstanceMethods.InvokeVirtualVoidMethod("setStyle.(II)V", this, ptr);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000031EE File Offset: 0x000013EE
		private static Delegate GetSetupDialog_Landroid_app_Dialog_IHandler()
		{
			if (DialogFragment.cb_setupDialog_Landroid_app_Dialog_I == null)
			{
				DialogFragment.cb_setupDialog_Landroid_app_Dialog_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(DialogFragment.n_SetupDialog_Landroid_app_Dialog_I));
			}
			return DialogFragment.cb_setupDialog_Landroid_app_Dialog_I;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00003214 File Offset: 0x00001414
		private static void n_SetupDialog_Landroid_app_Dialog_I(IntPtr jnienv, IntPtr native__this, IntPtr native_dialog, int style)
		{
			DialogFragment @object = Java.Lang.Object.GetObject<DialogFragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Dialog object2 = Java.Lang.Object.GetObject<Dialog>(native_dialog, JniHandleOwnership.DoNotTransfer);
			@object.SetupDialog(object2, style);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00003238 File Offset: 0x00001438
		[Register("setupDialog", "(Landroid/app/Dialog;I)V", "GetSetupDialog_Landroid_app_Dialog_IHandler")]
		public unsafe virtual void SetupDialog(Dialog dialog, int style)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dialog == null) ? IntPtr.Zero : dialog.Handle);
				ptr[1] = new JniArgumentValue(style);
				DialogFragment._members.InstanceMethods.InvokeVirtualVoidMethod("setupDialog.(Landroid/app/Dialog;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(dialog);
			}
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000032B0 File Offset: 0x000014B0
		private static Delegate GetShow_Landroidx_fragment_app_FragmentManager_Ljava_lang_String_Handler()
		{
			if (DialogFragment.cb_show_Landroidx_fragment_app_FragmentManager_Ljava_lang_String_ == null)
			{
				DialogFragment.cb_show_Landroidx_fragment_app_FragmentManager_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(DialogFragment.n_Show_Landroidx_fragment_app_FragmentManager_Ljava_lang_String_));
			}
			return DialogFragment.cb_show_Landroidx_fragment_app_FragmentManager_Ljava_lang_String_;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x000032D4 File Offset: 0x000014D4
		private static void n_Show_Landroidx_fragment_app_FragmentManager_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_manager, IntPtr native_tag)
		{
			DialogFragment @object = Java.Lang.Object.GetObject<DialogFragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			FragmentManager object2 = Java.Lang.Object.GetObject<FragmentManager>(native_manager, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_tag, JniHandleOwnership.DoNotTransfer);
			@object.Show(object2, @string);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00003300 File Offset: 0x00001500
		[Register("show", "(Landroidx/fragment/app/FragmentManager;Ljava/lang/String;)V", "GetShow_Landroidx_fragment_app_FragmentManager_Ljava_lang_String_Handler")]
		public unsafe virtual void Show(FragmentManager manager, string tag)
		{
			IntPtr intPtr = JNIEnv.NewString(tag);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((manager == null) ? IntPtr.Zero : manager.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				DialogFragment._members.InstanceMethods.InvokeVirtualVoidMethod("show.(Landroidx/fragment/app/FragmentManager;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(manager);
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00003384 File Offset: 0x00001584
		private static Delegate GetShow_Landroidx_fragment_app_FragmentTransaction_Ljava_lang_String_Handler()
		{
			if (DialogFragment.cb_show_Landroidx_fragment_app_FragmentTransaction_Ljava_lang_String_ == null)
			{
				DialogFragment.cb_show_Landroidx_fragment_app_FragmentTransaction_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_I(DialogFragment.n_Show_Landroidx_fragment_app_FragmentTransaction_Ljava_lang_String_));
			}
			return DialogFragment.cb_show_Landroidx_fragment_app_FragmentTransaction_Ljava_lang_String_;
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x000033A8 File Offset: 0x000015A8
		private static int n_Show_Landroidx_fragment_app_FragmentTransaction_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_transaction, IntPtr native_tag)
		{
			DialogFragment @object = Java.Lang.Object.GetObject<DialogFragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			FragmentTransaction object2 = Java.Lang.Object.GetObject<FragmentTransaction>(native_transaction, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_tag, JniHandleOwnership.DoNotTransfer);
			return @object.Show(object2, @string);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000033D4 File Offset: 0x000015D4
		[Register("show", "(Landroidx/fragment/app/FragmentTransaction;Ljava/lang/String;)I", "GetShow_Landroidx_fragment_app_FragmentTransaction_Ljava_lang_String_Handler")]
		public unsafe virtual int Show(FragmentTransaction transaction, string tag)
		{
			IntPtr intPtr = JNIEnv.NewString(tag);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((transaction == null) ? IntPtr.Zero : transaction.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				result = DialogFragment._members.InstanceMethods.InvokeVirtualInt32Method("show.(Landroidx/fragment/app/FragmentTransaction;Ljava/lang/String;)I", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(transaction);
			}
			return result;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0000345C File Offset: 0x0000165C
		private static Delegate GetShowNow_Landroidx_fragment_app_FragmentManager_Ljava_lang_String_Handler()
		{
			if (DialogFragment.cb_showNow_Landroidx_fragment_app_FragmentManager_Ljava_lang_String_ == null)
			{
				DialogFragment.cb_showNow_Landroidx_fragment_app_FragmentManager_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(DialogFragment.n_ShowNow_Landroidx_fragment_app_FragmentManager_Ljava_lang_String_));
			}
			return DialogFragment.cb_showNow_Landroidx_fragment_app_FragmentManager_Ljava_lang_String_;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00003480 File Offset: 0x00001680
		private static void n_ShowNow_Landroidx_fragment_app_FragmentManager_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_manager, IntPtr native_tag)
		{
			DialogFragment @object = Java.Lang.Object.GetObject<DialogFragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			FragmentManager object2 = Java.Lang.Object.GetObject<FragmentManager>(native_manager, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_tag, JniHandleOwnership.DoNotTransfer);
			@object.ShowNow(object2, @string);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x000034AC File Offset: 0x000016AC
		[Register("showNow", "(Landroidx/fragment/app/FragmentManager;Ljava/lang/String;)V", "GetShowNow_Landroidx_fragment_app_FragmentManager_Ljava_lang_String_Handler")]
		public unsafe virtual void ShowNow(FragmentManager manager, string tag)
		{
			IntPtr intPtr = JNIEnv.NewString(tag);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((manager == null) ? IntPtr.Zero : manager.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				DialogFragment._members.InstanceMethods.InvokeVirtualVoidMethod("showNow.(Landroidx/fragment/app/FragmentManager;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(manager);
			}
		}

		// Token: 0x04000011 RID: 17
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/fragment/app/DialogFragment", typeof(DialogFragment));

		// Token: 0x04000012 RID: 18
		private static Delegate cb_isCancelable;

		// Token: 0x04000013 RID: 19
		private static Delegate cb_setCancelable_Z;

		// Token: 0x04000014 RID: 20
		private static Delegate cb_getDialog;

		// Token: 0x04000015 RID: 21
		private static Delegate cb_getShowsDialog;

		// Token: 0x04000016 RID: 22
		private static Delegate cb_setShowsDialog_Z;

		// Token: 0x04000017 RID: 23
		private static Delegate cb_getTheme;

		// Token: 0x04000018 RID: 24
		private static Delegate cb_dismiss;

		// Token: 0x04000019 RID: 25
		private static Delegate cb_dismissAllowingStateLoss;

		// Token: 0x0400001A RID: 26
		private static Delegate cb_dismissNow;

		// Token: 0x0400001B RID: 27
		private static Delegate cb_onCancel_Landroid_content_DialogInterface_;

		// Token: 0x0400001C RID: 28
		private static Delegate cb_onCreateDialog_Landroid_os_Bundle_;

		// Token: 0x0400001D RID: 29
		private static Delegate cb_onDismiss_Landroid_content_DialogInterface_;

		// Token: 0x0400001E RID: 30
		private static Delegate cb_setStyle_II;

		// Token: 0x0400001F RID: 31
		private static Delegate cb_setupDialog_Landroid_app_Dialog_I;

		// Token: 0x04000020 RID: 32
		private static Delegate cb_show_Landroidx_fragment_app_FragmentManager_Ljava_lang_String_;

		// Token: 0x04000021 RID: 33
		private static Delegate cb_show_Landroidx_fragment_app_FragmentTransaction_Ljava_lang_String_;

		// Token: 0x04000022 RID: 34
		private static Delegate cb_showNow_Landroidx_fragment_app_FragmentManager_Ljava_lang_String_;
	}
}
