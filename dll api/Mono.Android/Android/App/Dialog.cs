using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Views.Accessibility;
using Java.Interop;
using Java.Lang;

namespace Android.App
{
	// Token: 0x0200025E RID: 606
	[Register("android/app/Dialog", DoNotGenerateAcw = true)]
	public class Dialog : Java.Lang.Object, IDialogInterface, IJavaObject, IDisposable, IJavaPeerable, KeyEvent.ICallback, View.IOnCreateContextMenuListener, Window.ICallback
	{
		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x060016D8 RID: 5848 RVA: 0x0003B172 File Offset: 0x00039372
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Dialog._members;
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x060016D9 RID: 5849 RVA: 0x0003B17C File Offset: 0x0003937C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Dialog._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x060016DA RID: 5850 RVA: 0x0003B1A0 File Offset: 0x000393A0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Dialog._members.ManagedPeerType;
			}
		}

		// Token: 0x060016DB RID: 5851 RVA: 0x000021E0 File Offset: 0x000003E0
		protected Dialog(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060016DC RID: 5852 RVA: 0x0003B1AC File Offset: 0x000393AC
		private static Delegate GetGetWindowHandler()
		{
			if (Dialog.cb_getWindow == null)
			{
				Dialog.cb_getWindow = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Dialog.n_GetWindow));
			}
			return Dialog.cb_getWindow;
		}

		// Token: 0x060016DD RID: 5853 RVA: 0x0003B1D0 File Offset: 0x000393D0
		private static IntPtr n_GetWindow(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Dialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Window);
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x060016DE RID: 5854 RVA: 0x0003B1E4 File Offset: 0x000393E4
		public virtual Window Window
		{
			get
			{
				return Java.Lang.Object.GetObject<Window>(Dialog._members.InstanceMethods.InvokeVirtualObjectMethod("getWindow.()Landroid/view/Window;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060016DF RID: 5855 RVA: 0x0003B216 File Offset: 0x00039416
		private static Delegate GetCancelHandler()
		{
			if (Dialog.cb_cancel == null)
			{
				Dialog.cb_cancel = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Dialog.n_Cancel));
			}
			return Dialog.cb_cancel;
		}

		// Token: 0x060016E0 RID: 5856 RVA: 0x0003B23A File Offset: 0x0003943A
		private static void n_Cancel(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Dialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Cancel();
		}

		// Token: 0x060016E1 RID: 5857 RVA: 0x0003B249 File Offset: 0x00039449
		public virtual void Cancel()
		{
			Dialog._members.InstanceMethods.InvokeVirtualVoidMethod("cancel.()V", this, null);
		}

		// Token: 0x060016E2 RID: 5858 RVA: 0x0003B262 File Offset: 0x00039462
		private static Delegate GetDismissHandler()
		{
			if (Dialog.cb_dismiss == null)
			{
				Dialog.cb_dismiss = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Dialog.n_Dismiss));
			}
			return Dialog.cb_dismiss;
		}

		// Token: 0x060016E3 RID: 5859 RVA: 0x0003B286 File Offset: 0x00039486
		private static void n_Dismiss(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Dialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Dismiss();
		}

		// Token: 0x060016E4 RID: 5860 RVA: 0x0003B295 File Offset: 0x00039495
		public virtual void Dismiss()
		{
			Dialog._members.InstanceMethods.InvokeVirtualVoidMethod("dismiss.()V", this, null);
		}

		// Token: 0x060016E5 RID: 5861 RVA: 0x0003B2AE File Offset: 0x000394AE
		private static Delegate GetDispatchGenericMotionEvent_Landroid_view_MotionEvent_Handler()
		{
			if (Dialog.cb_dispatchGenericMotionEvent_Landroid_view_MotionEvent_ == null)
			{
				Dialog.cb_dispatchGenericMotionEvent_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(Dialog.n_DispatchGenericMotionEvent_Landroid_view_MotionEvent_));
			}
			return Dialog.cb_dispatchGenericMotionEvent_Landroid_view_MotionEvent_;
		}

		// Token: 0x060016E6 RID: 5862 RVA: 0x0003B2D4 File Offset: 0x000394D4
		private static bool n_DispatchGenericMotionEvent_Landroid_view_MotionEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_ev)
		{
			Dialog @object = Java.Lang.Object.GetObject<Dialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MotionEvent object2 = Java.Lang.Object.GetObject<MotionEvent>(native_ev, JniHandleOwnership.DoNotTransfer);
			return @object.DispatchGenericMotionEvent(object2);
		}

		// Token: 0x060016E7 RID: 5863 RVA: 0x0003B2F8 File Offset: 0x000394F8
		public unsafe virtual bool DispatchGenericMotionEvent(MotionEvent ev)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((ev == null) ? IntPtr.Zero : ev.Handle);
				result = Dialog._members.InstanceMethods.InvokeVirtualBooleanMethod("dispatchGenericMotionEvent.(Landroid/view/MotionEvent;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(ev);
			}
			return result;
		}

		// Token: 0x060016E8 RID: 5864 RVA: 0x0003B360 File Offset: 0x00039560
		private static Delegate GetDispatchKeyEvent_Landroid_view_KeyEvent_Handler()
		{
			if (Dialog.cb_dispatchKeyEvent_Landroid_view_KeyEvent_ == null)
			{
				Dialog.cb_dispatchKeyEvent_Landroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(Dialog.n_DispatchKeyEvent_Landroid_view_KeyEvent_));
			}
			return Dialog.cb_dispatchKeyEvent_Landroid_view_KeyEvent_;
		}

		// Token: 0x060016E9 RID: 5865 RVA: 0x0003B384 File Offset: 0x00039584
		private static bool n_DispatchKeyEvent_Landroid_view_KeyEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			Dialog @object = Java.Lang.Object.GetObject<Dialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			KeyEvent object2 = Java.Lang.Object.GetObject<KeyEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.DispatchKeyEvent(object2);
		}

		// Token: 0x060016EA RID: 5866 RVA: 0x0003B3A8 File Offset: 0x000395A8
		public unsafe virtual bool DispatchKeyEvent(KeyEvent e)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				result = Dialog._members.InstanceMethods.InvokeVirtualBooleanMethod("dispatchKeyEvent.(Landroid/view/KeyEvent;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(e);
			}
			return result;
		}

		// Token: 0x060016EB RID: 5867 RVA: 0x0003B410 File Offset: 0x00039610
		private static Delegate GetDispatchKeyShortcutEvent_Landroid_view_KeyEvent_Handler()
		{
			if (Dialog.cb_dispatchKeyShortcutEvent_Landroid_view_KeyEvent_ == null)
			{
				Dialog.cb_dispatchKeyShortcutEvent_Landroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(Dialog.n_DispatchKeyShortcutEvent_Landroid_view_KeyEvent_));
			}
			return Dialog.cb_dispatchKeyShortcutEvent_Landroid_view_KeyEvent_;
		}

		// Token: 0x060016EC RID: 5868 RVA: 0x0003B434 File Offset: 0x00039634
		private static bool n_DispatchKeyShortcutEvent_Landroid_view_KeyEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			Dialog @object = Java.Lang.Object.GetObject<Dialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			KeyEvent object2 = Java.Lang.Object.GetObject<KeyEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.DispatchKeyShortcutEvent(object2);
		}

		// Token: 0x060016ED RID: 5869 RVA: 0x0003B458 File Offset: 0x00039658
		public unsafe virtual bool DispatchKeyShortcutEvent(KeyEvent e)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				result = Dialog._members.InstanceMethods.InvokeVirtualBooleanMethod("dispatchKeyShortcutEvent.(Landroid/view/KeyEvent;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(e);
			}
			return result;
		}

		// Token: 0x060016EE RID: 5870 RVA: 0x0003B4C0 File Offset: 0x000396C0
		private static Delegate GetDispatchPopulateAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_Handler()
		{
			if (Dialog.cb_dispatchPopulateAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_ == null)
			{
				Dialog.cb_dispatchPopulateAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(Dialog.n_DispatchPopulateAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_));
			}
			return Dialog.cb_dispatchPopulateAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_;
		}

		// Token: 0x060016EF RID: 5871 RVA: 0x0003B4E4 File Offset: 0x000396E4
		private static bool n_DispatchPopulateAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			Dialog @object = Java.Lang.Object.GetObject<Dialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AccessibilityEvent object2 = Java.Lang.Object.GetObject<AccessibilityEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.DispatchPopulateAccessibilityEvent(object2);
		}

		// Token: 0x060016F0 RID: 5872 RVA: 0x0003B508 File Offset: 0x00039708
		public unsafe virtual bool DispatchPopulateAccessibilityEvent(AccessibilityEvent e)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				result = Dialog._members.InstanceMethods.InvokeVirtualBooleanMethod("dispatchPopulateAccessibilityEvent.(Landroid/view/accessibility/AccessibilityEvent;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(e);
			}
			return result;
		}

		// Token: 0x060016F1 RID: 5873 RVA: 0x0003B570 File Offset: 0x00039770
		private static Delegate GetDispatchTouchEvent_Landroid_view_MotionEvent_Handler()
		{
			if (Dialog.cb_dispatchTouchEvent_Landroid_view_MotionEvent_ == null)
			{
				Dialog.cb_dispatchTouchEvent_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(Dialog.n_DispatchTouchEvent_Landroid_view_MotionEvent_));
			}
			return Dialog.cb_dispatchTouchEvent_Landroid_view_MotionEvent_;
		}

		// Token: 0x060016F2 RID: 5874 RVA: 0x0003B594 File Offset: 0x00039794
		private static bool n_DispatchTouchEvent_Landroid_view_MotionEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_ev)
		{
			Dialog @object = Java.Lang.Object.GetObject<Dialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MotionEvent object2 = Java.Lang.Object.GetObject<MotionEvent>(native_ev, JniHandleOwnership.DoNotTransfer);
			return @object.DispatchTouchEvent(object2);
		}

		// Token: 0x060016F3 RID: 5875 RVA: 0x0003B5B8 File Offset: 0x000397B8
		public unsafe virtual bool DispatchTouchEvent(MotionEvent ev)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((ev == null) ? IntPtr.Zero : ev.Handle);
				result = Dialog._members.InstanceMethods.InvokeVirtualBooleanMethod("dispatchTouchEvent.(Landroid/view/MotionEvent;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(ev);
			}
			return result;
		}

		// Token: 0x060016F4 RID: 5876 RVA: 0x0003B620 File Offset: 0x00039820
		private static Delegate GetDispatchTrackballEvent_Landroid_view_MotionEvent_Handler()
		{
			if (Dialog.cb_dispatchTrackballEvent_Landroid_view_MotionEvent_ == null)
			{
				Dialog.cb_dispatchTrackballEvent_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(Dialog.n_DispatchTrackballEvent_Landroid_view_MotionEvent_));
			}
			return Dialog.cb_dispatchTrackballEvent_Landroid_view_MotionEvent_;
		}

		// Token: 0x060016F5 RID: 5877 RVA: 0x0003B644 File Offset: 0x00039844
		private static bool n_DispatchTrackballEvent_Landroid_view_MotionEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_ev)
		{
			Dialog @object = Java.Lang.Object.GetObject<Dialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MotionEvent object2 = Java.Lang.Object.GetObject<MotionEvent>(native_ev, JniHandleOwnership.DoNotTransfer);
			return @object.DispatchTrackballEvent(object2);
		}

		// Token: 0x060016F6 RID: 5878 RVA: 0x0003B668 File Offset: 0x00039868
		public unsafe virtual bool DispatchTrackballEvent(MotionEvent ev)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((ev == null) ? IntPtr.Zero : ev.Handle);
				result = Dialog._members.InstanceMethods.InvokeVirtualBooleanMethod("dispatchTrackballEvent.(Landroid/view/MotionEvent;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(ev);
			}
			return result;
		}

		// Token: 0x060016F7 RID: 5879 RVA: 0x0003B6D0 File Offset: 0x000398D0
		private static Delegate GetOnActionModeFinished_Landroid_view_ActionMode_Handler()
		{
			if (Dialog.cb_onActionModeFinished_Landroid_view_ActionMode_ == null)
			{
				Dialog.cb_onActionModeFinished_Landroid_view_ActionMode_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Dialog.n_OnActionModeFinished_Landroid_view_ActionMode_));
			}
			return Dialog.cb_onActionModeFinished_Landroid_view_ActionMode_;
		}

		// Token: 0x060016F8 RID: 5880 RVA: 0x0003B6F4 File Offset: 0x000398F4
		private static void n_OnActionModeFinished_Landroid_view_ActionMode_(IntPtr jnienv, IntPtr native__this, IntPtr native_mode)
		{
			Dialog @object = Java.Lang.Object.GetObject<Dialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ActionMode object2 = Java.Lang.Object.GetObject<ActionMode>(native_mode, JniHandleOwnership.DoNotTransfer);
			@object.OnActionModeFinished(object2);
		}

		// Token: 0x060016F9 RID: 5881 RVA: 0x0003B718 File Offset: 0x00039918
		public unsafe virtual void OnActionModeFinished(ActionMode mode)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((mode == null) ? IntPtr.Zero : mode.Handle);
				Dialog._members.InstanceMethods.InvokeVirtualVoidMethod("onActionModeFinished.(Landroid/view/ActionMode;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(mode);
			}
		}

		// Token: 0x060016FA RID: 5882 RVA: 0x0003B77C File Offset: 0x0003997C
		private static Delegate GetOnActionModeStarted_Landroid_view_ActionMode_Handler()
		{
			if (Dialog.cb_onActionModeStarted_Landroid_view_ActionMode_ == null)
			{
				Dialog.cb_onActionModeStarted_Landroid_view_ActionMode_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Dialog.n_OnActionModeStarted_Landroid_view_ActionMode_));
			}
			return Dialog.cb_onActionModeStarted_Landroid_view_ActionMode_;
		}

		// Token: 0x060016FB RID: 5883 RVA: 0x0003B7A0 File Offset: 0x000399A0
		private static void n_OnActionModeStarted_Landroid_view_ActionMode_(IntPtr jnienv, IntPtr native__this, IntPtr native_mode)
		{
			Dialog @object = Java.Lang.Object.GetObject<Dialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ActionMode object2 = Java.Lang.Object.GetObject<ActionMode>(native_mode, JniHandleOwnership.DoNotTransfer);
			@object.OnActionModeStarted(object2);
		}

		// Token: 0x060016FC RID: 5884 RVA: 0x0003B7C4 File Offset: 0x000399C4
		public unsafe virtual void OnActionModeStarted(ActionMode mode)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((mode == null) ? IntPtr.Zero : mode.Handle);
				Dialog._members.InstanceMethods.InvokeVirtualVoidMethod("onActionModeStarted.(Landroid/view/ActionMode;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(mode);
			}
		}

		// Token: 0x060016FD RID: 5885 RVA: 0x0003B828 File Offset: 0x00039A28
		private static Delegate GetOnAttachedToWindowHandler()
		{
			if (Dialog.cb_onAttachedToWindow == null)
			{
				Dialog.cb_onAttachedToWindow = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Dialog.n_OnAttachedToWindow));
			}
			return Dialog.cb_onAttachedToWindow;
		}

		// Token: 0x060016FE RID: 5886 RVA: 0x0003B84C File Offset: 0x00039A4C
		private static void n_OnAttachedToWindow(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Dialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnAttachedToWindow();
		}

		// Token: 0x060016FF RID: 5887 RVA: 0x0003B85B File Offset: 0x00039A5B
		public virtual void OnAttachedToWindow()
		{
			Dialog._members.InstanceMethods.InvokeVirtualVoidMethod("onAttachedToWindow.()V", this, null);
		}

		// Token: 0x06001700 RID: 5888 RVA: 0x0003B874 File Offset: 0x00039A74
		private static Delegate GetOnContentChangedHandler()
		{
			if (Dialog.cb_onContentChanged == null)
			{
				Dialog.cb_onContentChanged = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Dialog.n_OnContentChanged));
			}
			return Dialog.cb_onContentChanged;
		}

		// Token: 0x06001701 RID: 5889 RVA: 0x0003B898 File Offset: 0x00039A98
		private static void n_OnContentChanged(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Dialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnContentChanged();
		}

		// Token: 0x06001702 RID: 5890 RVA: 0x0003B8A7 File Offset: 0x00039AA7
		public virtual void OnContentChanged()
		{
			Dialog._members.InstanceMethods.InvokeVirtualVoidMethod("onContentChanged.()V", this, null);
		}

		// Token: 0x06001703 RID: 5891 RVA: 0x0003B8C0 File Offset: 0x00039AC0
		private static Delegate GetOnCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_Handler()
		{
			if (Dialog.cb_onCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_ == null)
			{
				Dialog.cb_onCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(Dialog.n_OnCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_));
			}
			return Dialog.cb_onCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_;
		}

		// Token: 0x06001704 RID: 5892 RVA: 0x0003B8E4 File Offset: 0x00039AE4
		private static void n_OnCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_(IntPtr jnienv, IntPtr native__this, IntPtr native_menu, IntPtr native_v, IntPtr native_menuInfo)
		{
			Dialog @object = Java.Lang.Object.GetObject<Dialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IContextMenu object2 = Java.Lang.Object.GetObject<IContextMenu>(native_menu, JniHandleOwnership.DoNotTransfer);
			View object3 = Java.Lang.Object.GetObject<View>(native_v, JniHandleOwnership.DoNotTransfer);
			IContextMenuContextMenuInfo object4 = Java.Lang.Object.GetObject<IContextMenuContextMenuInfo>(native_menuInfo, JniHandleOwnership.DoNotTransfer);
			@object.OnCreateContextMenu(object2, object3, object4);
		}

		// Token: 0x06001705 RID: 5893 RVA: 0x0003B91C File Offset: 0x00039B1C
		public unsafe virtual void OnCreateContextMenu(IContextMenu menu, View v, IContextMenuContextMenuInfo menuInfo)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((menu == null) ? IntPtr.Zero : ((Java.Lang.Object)menu).Handle);
				ptr[1] = new JniArgumentValue((v == null) ? IntPtr.Zero : v.Handle);
				ptr[2] = new JniArgumentValue((menuInfo == null) ? IntPtr.Zero : ((Java.Lang.Object)menuInfo).Handle);
				Dialog._members.InstanceMethods.InvokeVirtualVoidMethod("onCreateContextMenu.(Landroid/view/ContextMenu;Landroid/view/View;Landroid/view/ContextMenu$ContextMenuInfo;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(menu);
				GC.KeepAlive(v);
				GC.KeepAlive(menuInfo);
			}
		}

		// Token: 0x06001706 RID: 5894 RVA: 0x0003B9DC File Offset: 0x00039BDC
		private static Delegate GetOnCreatePanelMenu_ILandroid_view_Menu_Handler()
		{
			if (Dialog.cb_onCreatePanelMenu_ILandroid_view_Menu_ == null)
			{
				Dialog.cb_onCreatePanelMenu_ILandroid_view_Menu_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_Z(Dialog.n_OnCreatePanelMenu_ILandroid_view_Menu_));
			}
			return Dialog.cb_onCreatePanelMenu_ILandroid_view_Menu_;
		}

		// Token: 0x06001707 RID: 5895 RVA: 0x0003BA00 File Offset: 0x00039C00
		private static bool n_OnCreatePanelMenu_ILandroid_view_Menu_(IntPtr jnienv, IntPtr native__this, int featureId, IntPtr native_menu)
		{
			Dialog @object = Java.Lang.Object.GetObject<Dialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMenu object2 = Java.Lang.Object.GetObject<IMenu>(native_menu, JniHandleOwnership.DoNotTransfer);
			return @object.OnCreatePanelMenu(featureId, object2);
		}

		// Token: 0x06001708 RID: 5896 RVA: 0x0003BA24 File Offset: 0x00039C24
		public unsafe virtual bool OnCreatePanelMenu(int featureId, IMenu menu)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(featureId);
				ptr[1] = new JniArgumentValue((menu == null) ? IntPtr.Zero : ((Java.Lang.Object)menu).Handle);
				result = Dialog._members.InstanceMethods.InvokeVirtualBooleanMethod("onCreatePanelMenu.(ILandroid/view/Menu;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(menu);
			}
			return result;
		}

		// Token: 0x06001709 RID: 5897 RVA: 0x0003BAA4 File Offset: 0x00039CA4
		private static Delegate GetOnCreatePanelView_IHandler()
		{
			if (Dialog.cb_onCreatePanelView_I == null)
			{
				Dialog.cb_onCreatePanelView_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(Dialog.n_OnCreatePanelView_I));
			}
			return Dialog.cb_onCreatePanelView_I;
		}

		// Token: 0x0600170A RID: 5898 RVA: 0x0003BAC8 File Offset: 0x00039CC8
		private static IntPtr n_OnCreatePanelView_I(IntPtr jnienv, IntPtr native__this, int featureId)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Dialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnCreatePanelView(featureId));
		}

		// Token: 0x0600170B RID: 5899 RVA: 0x0003BAE0 File Offset: 0x00039CE0
		public unsafe virtual View OnCreatePanelView(int featureId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(featureId);
			return Java.Lang.Object.GetObject<View>(Dialog._members.InstanceMethods.InvokeVirtualObjectMethod("onCreatePanelView.(I)Landroid/view/View;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600170C RID: 5900 RVA: 0x0003BB29 File Offset: 0x00039D29
		private static Delegate GetOnDetachedFromWindowHandler()
		{
			if (Dialog.cb_onDetachedFromWindow == null)
			{
				Dialog.cb_onDetachedFromWindow = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Dialog.n_OnDetachedFromWindow));
			}
			return Dialog.cb_onDetachedFromWindow;
		}

		// Token: 0x0600170D RID: 5901 RVA: 0x0003BB4D File Offset: 0x00039D4D
		private static void n_OnDetachedFromWindow(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Dialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnDetachedFromWindow();
		}

		// Token: 0x0600170E RID: 5902 RVA: 0x0003BB5C File Offset: 0x00039D5C
		public virtual void OnDetachedFromWindow()
		{
			Dialog._members.InstanceMethods.InvokeVirtualVoidMethod("onDetachedFromWindow.()V", this, null);
		}

		// Token: 0x0600170F RID: 5903 RVA: 0x0003BB75 File Offset: 0x00039D75
		private static Delegate GetOnKeyDown_ILandroid_view_KeyEvent_Handler()
		{
			if (Dialog.cb_onKeyDown_ILandroid_view_KeyEvent_ == null)
			{
				Dialog.cb_onKeyDown_ILandroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_Z(Dialog.n_OnKeyDown_ILandroid_view_KeyEvent_));
			}
			return Dialog.cb_onKeyDown_ILandroid_view_KeyEvent_;
		}

		// Token: 0x06001710 RID: 5904 RVA: 0x0003BB9C File Offset: 0x00039D9C
		private static bool n_OnKeyDown_ILandroid_view_KeyEvent_(IntPtr jnienv, IntPtr native__this, int native_keyCode, IntPtr native_e)
		{
			Dialog @object = Java.Lang.Object.GetObject<Dialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			KeyEvent object2 = Java.Lang.Object.GetObject<KeyEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.OnKeyDown((Keycode)native_keyCode, object2);
		}

		// Token: 0x06001711 RID: 5905 RVA: 0x0003BBC4 File Offset: 0x00039DC4
		public unsafe virtual bool OnKeyDown([GeneratedEnum] Keycode keyCode, KeyEvent e)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((int)keyCode);
				ptr[1] = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				result = Dialog._members.InstanceMethods.InvokeVirtualBooleanMethod("onKeyDown.(ILandroid/view/KeyEvent;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(e);
			}
			return result;
		}

		// Token: 0x06001712 RID: 5906 RVA: 0x0003BC3C File Offset: 0x00039E3C
		private static Delegate GetOnKeyLongPress_ILandroid_view_KeyEvent_Handler()
		{
			if (Dialog.cb_onKeyLongPress_ILandroid_view_KeyEvent_ == null)
			{
				Dialog.cb_onKeyLongPress_ILandroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_Z(Dialog.n_OnKeyLongPress_ILandroid_view_KeyEvent_));
			}
			return Dialog.cb_onKeyLongPress_ILandroid_view_KeyEvent_;
		}

		// Token: 0x06001713 RID: 5907 RVA: 0x0003BC60 File Offset: 0x00039E60
		private static bool n_OnKeyLongPress_ILandroid_view_KeyEvent_(IntPtr jnienv, IntPtr native__this, int native_keyCode, IntPtr native_e)
		{
			Dialog @object = Java.Lang.Object.GetObject<Dialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			KeyEvent object2 = Java.Lang.Object.GetObject<KeyEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.OnKeyLongPress((Keycode)native_keyCode, object2);
		}

		// Token: 0x06001714 RID: 5908 RVA: 0x0003BC88 File Offset: 0x00039E88
		public unsafe virtual bool OnKeyLongPress([GeneratedEnum] Keycode keyCode, KeyEvent e)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((int)keyCode);
				ptr[1] = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				result = Dialog._members.InstanceMethods.InvokeVirtualBooleanMethod("onKeyLongPress.(ILandroid/view/KeyEvent;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(e);
			}
			return result;
		}

		// Token: 0x06001715 RID: 5909 RVA: 0x0003BD00 File Offset: 0x00039F00
		private static Delegate GetOnKeyMultiple_IILandroid_view_KeyEvent_Handler()
		{
			if (Dialog.cb_onKeyMultiple_IILandroid_view_KeyEvent_ == null)
			{
				Dialog.cb_onKeyMultiple_IILandroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIL_Z(Dialog.n_OnKeyMultiple_IILandroid_view_KeyEvent_));
			}
			return Dialog.cb_onKeyMultiple_IILandroid_view_KeyEvent_;
		}

		// Token: 0x06001716 RID: 5910 RVA: 0x0003BD24 File Offset: 0x00039F24
		private static bool n_OnKeyMultiple_IILandroid_view_KeyEvent_(IntPtr jnienv, IntPtr native__this, int native_keyCode, int repeatCount, IntPtr native_e)
		{
			Dialog @object = Java.Lang.Object.GetObject<Dialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			KeyEvent object2 = Java.Lang.Object.GetObject<KeyEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.OnKeyMultiple((Keycode)native_keyCode, repeatCount, object2);
		}

		// Token: 0x06001717 RID: 5911 RVA: 0x0003BD4C File Offset: 0x00039F4C
		public unsafe virtual bool OnKeyMultiple([GeneratedEnum] Keycode keyCode, int repeatCount, KeyEvent e)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((int)keyCode);
				ptr[1] = new JniArgumentValue(repeatCount);
				ptr[2] = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				result = Dialog._members.InstanceMethods.InvokeVirtualBooleanMethod("onKeyMultiple.(IILandroid/view/KeyEvent;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(e);
			}
			return result;
		}

		// Token: 0x06001718 RID: 5912 RVA: 0x0003BDDC File Offset: 0x00039FDC
		private static Delegate GetOnKeyUp_ILandroid_view_KeyEvent_Handler()
		{
			if (Dialog.cb_onKeyUp_ILandroid_view_KeyEvent_ == null)
			{
				Dialog.cb_onKeyUp_ILandroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_Z(Dialog.n_OnKeyUp_ILandroid_view_KeyEvent_));
			}
			return Dialog.cb_onKeyUp_ILandroid_view_KeyEvent_;
		}

		// Token: 0x06001719 RID: 5913 RVA: 0x0003BE00 File Offset: 0x0003A000
		private static bool n_OnKeyUp_ILandroid_view_KeyEvent_(IntPtr jnienv, IntPtr native__this, int native_keyCode, IntPtr native_e)
		{
			Dialog @object = Java.Lang.Object.GetObject<Dialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			KeyEvent object2 = Java.Lang.Object.GetObject<KeyEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.OnKeyUp((Keycode)native_keyCode, object2);
		}

		// Token: 0x0600171A RID: 5914 RVA: 0x0003BE28 File Offset: 0x0003A028
		public unsafe virtual bool OnKeyUp([GeneratedEnum] Keycode keyCode, KeyEvent e)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((int)keyCode);
				ptr[1] = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				result = Dialog._members.InstanceMethods.InvokeVirtualBooleanMethod("onKeyUp.(ILandroid/view/KeyEvent;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(e);
			}
			return result;
		}

		// Token: 0x0600171B RID: 5915 RVA: 0x0003BEA0 File Offset: 0x0003A0A0
		private static Delegate GetOnMenuItemSelected_ILandroid_view_MenuItem_Handler()
		{
			if (Dialog.cb_onMenuItemSelected_ILandroid_view_MenuItem_ == null)
			{
				Dialog.cb_onMenuItemSelected_ILandroid_view_MenuItem_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_Z(Dialog.n_OnMenuItemSelected_ILandroid_view_MenuItem_));
			}
			return Dialog.cb_onMenuItemSelected_ILandroid_view_MenuItem_;
		}

		// Token: 0x0600171C RID: 5916 RVA: 0x0003BEC4 File Offset: 0x0003A0C4
		private static bool n_OnMenuItemSelected_ILandroid_view_MenuItem_(IntPtr jnienv, IntPtr native__this, int featureId, IntPtr native_item)
		{
			Dialog @object = Java.Lang.Object.GetObject<Dialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMenuItem object2 = Java.Lang.Object.GetObject<IMenuItem>(native_item, JniHandleOwnership.DoNotTransfer);
			return @object.OnMenuItemSelected(featureId, object2);
		}

		// Token: 0x0600171D RID: 5917 RVA: 0x0003BEE8 File Offset: 0x0003A0E8
		public unsafe virtual bool OnMenuItemSelected(int featureId, IMenuItem item)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(featureId);
				ptr[1] = new JniArgumentValue((item == null) ? IntPtr.Zero : ((Java.Lang.Object)item).Handle);
				result = Dialog._members.InstanceMethods.InvokeVirtualBooleanMethod("onMenuItemSelected.(ILandroid/view/MenuItem;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(item);
			}
			return result;
		}

		// Token: 0x0600171E RID: 5918 RVA: 0x0003BF68 File Offset: 0x0003A168
		private static Delegate GetOnMenuOpened_ILandroid_view_Menu_Handler()
		{
			if (Dialog.cb_onMenuOpened_ILandroid_view_Menu_ == null)
			{
				Dialog.cb_onMenuOpened_ILandroid_view_Menu_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_Z(Dialog.n_OnMenuOpened_ILandroid_view_Menu_));
			}
			return Dialog.cb_onMenuOpened_ILandroid_view_Menu_;
		}

		// Token: 0x0600171F RID: 5919 RVA: 0x0003BF8C File Offset: 0x0003A18C
		private static bool n_OnMenuOpened_ILandroid_view_Menu_(IntPtr jnienv, IntPtr native__this, int featureId, IntPtr native_menu)
		{
			Dialog @object = Java.Lang.Object.GetObject<Dialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMenu object2 = Java.Lang.Object.GetObject<IMenu>(native_menu, JniHandleOwnership.DoNotTransfer);
			return @object.OnMenuOpened(featureId, object2);
		}

		// Token: 0x06001720 RID: 5920 RVA: 0x0003BFB0 File Offset: 0x0003A1B0
		public unsafe virtual bool OnMenuOpened(int featureId, IMenu menu)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(featureId);
				ptr[1] = new JniArgumentValue((menu == null) ? IntPtr.Zero : ((Java.Lang.Object)menu).Handle);
				result = Dialog._members.InstanceMethods.InvokeVirtualBooleanMethod("onMenuOpened.(ILandroid/view/Menu;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(menu);
			}
			return result;
		}

		// Token: 0x06001721 RID: 5921 RVA: 0x0003C030 File Offset: 0x0003A230
		private static Delegate GetOnPanelClosed_ILandroid_view_Menu_Handler()
		{
			if (Dialog.cb_onPanelClosed_ILandroid_view_Menu_ == null)
			{
				Dialog.cb_onPanelClosed_ILandroid_view_Menu_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_V(Dialog.n_OnPanelClosed_ILandroid_view_Menu_));
			}
			return Dialog.cb_onPanelClosed_ILandroid_view_Menu_;
		}

		// Token: 0x06001722 RID: 5922 RVA: 0x0003C054 File Offset: 0x0003A254
		private static void n_OnPanelClosed_ILandroid_view_Menu_(IntPtr jnienv, IntPtr native__this, int featureId, IntPtr native_menu)
		{
			Dialog @object = Java.Lang.Object.GetObject<Dialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMenu object2 = Java.Lang.Object.GetObject<IMenu>(native_menu, JniHandleOwnership.DoNotTransfer);
			@object.OnPanelClosed(featureId, object2);
		}

		// Token: 0x06001723 RID: 5923 RVA: 0x0003C078 File Offset: 0x0003A278
		public unsafe virtual void OnPanelClosed(int featureId, IMenu menu)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(featureId);
				ptr[1] = new JniArgumentValue((menu == null) ? IntPtr.Zero : ((Java.Lang.Object)menu).Handle);
				Dialog._members.InstanceMethods.InvokeVirtualVoidMethod("onPanelClosed.(ILandroid/view/Menu;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(menu);
			}
		}

		// Token: 0x06001724 RID: 5924 RVA: 0x0003C0F4 File Offset: 0x0003A2F4
		private static Delegate GetOnPreparePanel_ILandroid_view_View_Landroid_view_Menu_Handler()
		{
			if (Dialog.cb_onPreparePanel_ILandroid_view_View_Landroid_view_Menu_ == null)
			{
				Dialog.cb_onPreparePanel_ILandroid_view_View_Landroid_view_Menu_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPILL_Z(Dialog.n_OnPreparePanel_ILandroid_view_View_Landroid_view_Menu_));
			}
			return Dialog.cb_onPreparePanel_ILandroid_view_View_Landroid_view_Menu_;
		}

		// Token: 0x06001725 RID: 5925 RVA: 0x0003C118 File Offset: 0x0003A318
		private static bool n_OnPreparePanel_ILandroid_view_View_Landroid_view_Menu_(IntPtr jnienv, IntPtr native__this, int featureId, IntPtr native_view, IntPtr native_menu)
		{
			Dialog @object = Java.Lang.Object.GetObject<Dialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			IMenu object3 = Java.Lang.Object.GetObject<IMenu>(native_menu, JniHandleOwnership.DoNotTransfer);
			return @object.OnPreparePanel(featureId, object2, object3);
		}

		// Token: 0x06001726 RID: 5926 RVA: 0x0003C148 File Offset: 0x0003A348
		public unsafe virtual bool OnPreparePanel(int featureId, View view, IMenu menu)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(featureId);
				ptr[1] = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				ptr[2] = new JniArgumentValue((menu == null) ? IntPtr.Zero : ((Java.Lang.Object)menu).Handle);
				result = Dialog._members.InstanceMethods.InvokeVirtualBooleanMethod("onPreparePanel.(ILandroid/view/View;Landroid/view/Menu;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(view);
				GC.KeepAlive(menu);
			}
			return result;
		}

		// Token: 0x06001727 RID: 5927 RVA: 0x0003C1F0 File Offset: 0x0003A3F0
		private static Delegate GetOnSearchRequestedHandler()
		{
			if (Dialog.cb_onSearchRequested == null)
			{
				Dialog.cb_onSearchRequested = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(Dialog.n_OnSearchRequested));
			}
			return Dialog.cb_onSearchRequested;
		}

		// Token: 0x06001728 RID: 5928 RVA: 0x0003C214 File Offset: 0x0003A414
		private static bool n_OnSearchRequested(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Dialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnSearchRequested();
		}

		// Token: 0x06001729 RID: 5929 RVA: 0x0003C223 File Offset: 0x0003A423
		public virtual bool OnSearchRequested()
		{
			return Dialog._members.InstanceMethods.InvokeVirtualBooleanMethod("onSearchRequested.()Z", this, null);
		}

		// Token: 0x0600172A RID: 5930 RVA: 0x0003C23C File Offset: 0x0003A43C
		private static Delegate GetOnSearchRequested_Landroid_view_SearchEvent_Handler()
		{
			if (Dialog.cb_onSearchRequested_Landroid_view_SearchEvent_ == null)
			{
				Dialog.cb_onSearchRequested_Landroid_view_SearchEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(Dialog.n_OnSearchRequested_Landroid_view_SearchEvent_));
			}
			return Dialog.cb_onSearchRequested_Landroid_view_SearchEvent_;
		}

		// Token: 0x0600172B RID: 5931 RVA: 0x0003C260 File Offset: 0x0003A460
		private static bool n_OnSearchRequested_Landroid_view_SearchEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_searchEvent)
		{
			Dialog @object = Java.Lang.Object.GetObject<Dialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			SearchEvent object2 = Java.Lang.Object.GetObject<SearchEvent>(native_searchEvent, JniHandleOwnership.DoNotTransfer);
			return @object.OnSearchRequested(object2);
		}

		// Token: 0x0600172C RID: 5932 RVA: 0x0003C284 File Offset: 0x0003A484
		public unsafe virtual bool OnSearchRequested(SearchEvent searchEvent)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((searchEvent == null) ? IntPtr.Zero : searchEvent.Handle);
				result = Dialog._members.InstanceMethods.InvokeVirtualBooleanMethod("onSearchRequested.(Landroid/view/SearchEvent;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(searchEvent);
			}
			return result;
		}

		// Token: 0x0600172D RID: 5933 RVA: 0x0003C2EC File Offset: 0x0003A4EC
		private static Delegate GetOnWindowAttributesChanged_Landroid_view_WindowManager_LayoutParams_Handler()
		{
			if (Dialog.cb_onWindowAttributesChanged_Landroid_view_WindowManager_LayoutParams_ == null)
			{
				Dialog.cb_onWindowAttributesChanged_Landroid_view_WindowManager_LayoutParams_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Dialog.n_OnWindowAttributesChanged_Landroid_view_WindowManager_LayoutParams_));
			}
			return Dialog.cb_onWindowAttributesChanged_Landroid_view_WindowManager_LayoutParams_;
		}

		// Token: 0x0600172E RID: 5934 RVA: 0x0003C310 File Offset: 0x0003A510
		private static void n_OnWindowAttributesChanged_Landroid_view_WindowManager_LayoutParams_(IntPtr jnienv, IntPtr native__this, IntPtr native__params)
		{
			Dialog @object = Java.Lang.Object.GetObject<Dialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			WindowManagerLayoutParams object2 = Java.Lang.Object.GetObject<WindowManagerLayoutParams>(native__params, JniHandleOwnership.DoNotTransfer);
			@object.OnWindowAttributesChanged(object2);
		}

		// Token: 0x0600172F RID: 5935 RVA: 0x0003C334 File Offset: 0x0003A534
		public unsafe virtual void OnWindowAttributesChanged(WindowManagerLayoutParams @params)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((@params == null) ? IntPtr.Zero : @params.Handle);
				Dialog._members.InstanceMethods.InvokeVirtualVoidMethod("onWindowAttributesChanged.(Landroid/view/WindowManager$LayoutParams;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(@params);
			}
		}

		// Token: 0x06001730 RID: 5936 RVA: 0x0003C398 File Offset: 0x0003A598
		private static Delegate GetOnWindowFocusChanged_ZHandler()
		{
			if (Dialog.cb_onWindowFocusChanged_Z == null)
			{
				Dialog.cb_onWindowFocusChanged_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(Dialog.n_OnWindowFocusChanged_Z));
			}
			return Dialog.cb_onWindowFocusChanged_Z;
		}

		// Token: 0x06001731 RID: 5937 RVA: 0x0003C3BC File Offset: 0x0003A5BC
		private static void n_OnWindowFocusChanged_Z(IntPtr jnienv, IntPtr native__this, bool hasFocus)
		{
			Java.Lang.Object.GetObject<Dialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnWindowFocusChanged(hasFocus);
		}

		// Token: 0x06001732 RID: 5938 RVA: 0x0003C3CC File Offset: 0x0003A5CC
		public unsafe virtual void OnWindowFocusChanged(bool hasFocus)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(hasFocus);
			Dialog._members.InstanceMethods.InvokeVirtualVoidMethod("onWindowFocusChanged.(Z)V", this, ptr);
		}

		// Token: 0x06001733 RID: 5939 RVA: 0x0003C407 File Offset: 0x0003A607
		private static Delegate GetOnWindowStartingActionMode_Landroid_view_ActionMode_Callback_Handler()
		{
			if (Dialog.cb_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_ == null)
			{
				Dialog.cb_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(Dialog.n_OnWindowStartingActionMode_Landroid_view_ActionMode_Callback_));
			}
			return Dialog.cb_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_;
		}

		// Token: 0x06001734 RID: 5940 RVA: 0x0003C42C File Offset: 0x0003A62C
		private static IntPtr n_OnWindowStartingActionMode_Landroid_view_ActionMode_Callback_(IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			Dialog @object = Java.Lang.Object.GetObject<Dialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ActionMode.ICallback object2 = Java.Lang.Object.GetObject<ActionMode.ICallback>(native__callback, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.OnWindowStartingActionMode(object2));
		}

		// Token: 0x06001735 RID: 5941 RVA: 0x0003C454 File Offset: 0x0003A654
		public unsafe virtual ActionMode OnWindowStartingActionMode(ActionMode.ICallback callback)
		{
			ActionMode @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : ((Java.Lang.Object)callback).Handle);
				@object = Java.Lang.Object.GetObject<ActionMode>(Dialog._members.InstanceMethods.InvokeVirtualObjectMethod("onWindowStartingActionMode.(Landroid/view/ActionMode$Callback;)Landroid/view/ActionMode;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
			return @object;
		}

		// Token: 0x06001736 RID: 5942 RVA: 0x0003C4CC File Offset: 0x0003A6CC
		private static Delegate GetOnWindowStartingActionMode_Landroid_view_ActionMode_Callback_IHandler()
		{
			if (Dialog.cb_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_I == null)
			{
				Dialog.cb_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_L(Dialog.n_OnWindowStartingActionMode_Landroid_view_ActionMode_Callback_I));
			}
			return Dialog.cb_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_I;
		}

		// Token: 0x06001737 RID: 5943 RVA: 0x0003C4F0 File Offset: 0x0003A6F0
		private static IntPtr n_OnWindowStartingActionMode_Landroid_view_ActionMode_Callback_I(IntPtr jnienv, IntPtr native__this, IntPtr native__callback, int native_type)
		{
			Dialog @object = Java.Lang.Object.GetObject<Dialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ActionMode.ICallback object2 = Java.Lang.Object.GetObject<ActionMode.ICallback>(native__callback, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.OnWindowStartingActionMode(object2, (ActionModeType)native_type));
		}

		// Token: 0x06001738 RID: 5944 RVA: 0x0003C51C File Offset: 0x0003A71C
		public unsafe virtual ActionMode OnWindowStartingActionMode(ActionMode.ICallback callback, [GeneratedEnum] ActionModeType type)
		{
			ActionMode @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : ((Java.Lang.Object)callback).Handle);
				ptr[1] = new JniArgumentValue((int)type);
				@object = Java.Lang.Object.GetObject<ActionMode>(Dialog._members.InstanceMethods.InvokeVirtualObjectMethod("onWindowStartingActionMode.(Landroid/view/ActionMode$Callback;I)Landroid/view/ActionMode;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
			return @object;
		}

		// Token: 0x06001739 RID: 5945 RVA: 0x0003C5A8 File Offset: 0x0003A7A8
		private static Delegate GetShowHandler()
		{
			if (Dialog.cb_show == null)
			{
				Dialog.cb_show = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Dialog.n_Show));
			}
			return Dialog.cb_show;
		}

		// Token: 0x0600173A RID: 5946 RVA: 0x0003C5CC File Offset: 0x0003A7CC
		private static void n_Show(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Dialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Show();
		}

		// Token: 0x0600173B RID: 5947 RVA: 0x0003C5DB File Offset: 0x0003A7DB
		public virtual void Show()
		{
			Dialog._members.InstanceMethods.InvokeVirtualVoidMethod("show.()V", this, null);
		}

		// Token: 0x040009D8 RID: 2520
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/app/Dialog", typeof(Dialog));

		// Token: 0x040009D9 RID: 2521
		private static Delegate cb_getWindow;

		// Token: 0x040009DA RID: 2522
		private static Delegate cb_cancel;

		// Token: 0x040009DB RID: 2523
		private static Delegate cb_dismiss;

		// Token: 0x040009DC RID: 2524
		private static Delegate cb_dispatchGenericMotionEvent_Landroid_view_MotionEvent_;

		// Token: 0x040009DD RID: 2525
		private static Delegate cb_dispatchKeyEvent_Landroid_view_KeyEvent_;

		// Token: 0x040009DE RID: 2526
		private static Delegate cb_dispatchKeyShortcutEvent_Landroid_view_KeyEvent_;

		// Token: 0x040009DF RID: 2527
		private static Delegate cb_dispatchPopulateAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_;

		// Token: 0x040009E0 RID: 2528
		private static Delegate cb_dispatchTouchEvent_Landroid_view_MotionEvent_;

		// Token: 0x040009E1 RID: 2529
		private static Delegate cb_dispatchTrackballEvent_Landroid_view_MotionEvent_;

		// Token: 0x040009E2 RID: 2530
		private static Delegate cb_onActionModeFinished_Landroid_view_ActionMode_;

		// Token: 0x040009E3 RID: 2531
		private static Delegate cb_onActionModeStarted_Landroid_view_ActionMode_;

		// Token: 0x040009E4 RID: 2532
		private static Delegate cb_onAttachedToWindow;

		// Token: 0x040009E5 RID: 2533
		private static Delegate cb_onContentChanged;

		// Token: 0x040009E6 RID: 2534
		private static Delegate cb_onCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_;

		// Token: 0x040009E7 RID: 2535
		private static Delegate cb_onCreatePanelMenu_ILandroid_view_Menu_;

		// Token: 0x040009E8 RID: 2536
		private static Delegate cb_onCreatePanelView_I;

		// Token: 0x040009E9 RID: 2537
		private static Delegate cb_onDetachedFromWindow;

		// Token: 0x040009EA RID: 2538
		private static Delegate cb_onKeyDown_ILandroid_view_KeyEvent_;

		// Token: 0x040009EB RID: 2539
		private static Delegate cb_onKeyLongPress_ILandroid_view_KeyEvent_;

		// Token: 0x040009EC RID: 2540
		private static Delegate cb_onKeyMultiple_IILandroid_view_KeyEvent_;

		// Token: 0x040009ED RID: 2541
		private static Delegate cb_onKeyUp_ILandroid_view_KeyEvent_;

		// Token: 0x040009EE RID: 2542
		private static Delegate cb_onMenuItemSelected_ILandroid_view_MenuItem_;

		// Token: 0x040009EF RID: 2543
		private static Delegate cb_onMenuOpened_ILandroid_view_Menu_;

		// Token: 0x040009F0 RID: 2544
		private static Delegate cb_onPanelClosed_ILandroid_view_Menu_;

		// Token: 0x040009F1 RID: 2545
		private static Delegate cb_onPreparePanel_ILandroid_view_View_Landroid_view_Menu_;

		// Token: 0x040009F2 RID: 2546
		private static Delegate cb_onSearchRequested;

		// Token: 0x040009F3 RID: 2547
		private static Delegate cb_onSearchRequested_Landroid_view_SearchEvent_;

		// Token: 0x040009F4 RID: 2548
		private static Delegate cb_onWindowAttributesChanged_Landroid_view_WindowManager_LayoutParams_;

		// Token: 0x040009F5 RID: 2549
		private static Delegate cb_onWindowFocusChanged_Z;

		// Token: 0x040009F6 RID: 2550
		private static Delegate cb_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_;

		// Token: 0x040009F7 RID: 2551
		private static Delegate cb_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_I;

		// Token: 0x040009F8 RID: 2552
		private static Delegate cb_show;
	}
}
