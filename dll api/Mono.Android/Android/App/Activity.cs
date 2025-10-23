using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Content.PM;
using Android.Content.Res;
using Android.Media;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Views.Accessibility;
using Java.Interop;
using Java.Lang;

namespace Android.App
{
	// Token: 0x0200025A RID: 602
	[Register("android/app/Activity", DoNotGenerateAcw = true)]
	public class Activity : ContextThemeWrapper, IComponentCallbacks, IJavaObject, IDisposable, IJavaPeerable, IComponentCallbacks2, KeyEvent.ICallback, LayoutInflater.IFactory, LayoutInflater.IFactory2, View.IOnCreateContextMenuListener, Window.ICallback
	{
		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x060015C2 RID: 5570 RVA: 0x00037708 File Offset: 0x00035908
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Activity._members;
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x060015C3 RID: 5571 RVA: 0x00037710 File Offset: 0x00035910
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Activity._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x060015C4 RID: 5572 RVA: 0x00037734 File Offset: 0x00035934
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Activity._members.ManagedPeerType;
			}
		}

		// Token: 0x060015C5 RID: 5573 RVA: 0x00037740 File Offset: 0x00035940
		protected Activity(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060015C6 RID: 5574 RVA: 0x0003774C File Offset: 0x0003594C
		public Activity() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(Activity._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			Activity._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060015C7 RID: 5575 RVA: 0x000377BA File Offset: 0x000359BA
		private static Delegate GetGetCurrentFocusHandler()
		{
			if (Activity.cb_getCurrentFocus == null)
			{
				Activity.cb_getCurrentFocus = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Activity.n_GetCurrentFocus));
			}
			return Activity.cb_getCurrentFocus;
		}

		// Token: 0x060015C8 RID: 5576 RVA: 0x000377DE File Offset: 0x000359DE
		private static IntPtr n_GetCurrentFocus(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CurrentFocus);
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x060015C9 RID: 5577 RVA: 0x000377F4 File Offset: 0x000359F4
		public virtual View CurrentFocus
		{
			get
			{
				return Java.Lang.Object.GetObject<View>(Activity._members.InstanceMethods.InvokeVirtualObjectMethod("getCurrentFocus.()Landroid/view/View;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060015CA RID: 5578 RVA: 0x00037826 File Offset: 0x00035A26
		private static Delegate GetGetIntentHandler()
		{
			if (Activity.cb_getIntent == null)
			{
				Activity.cb_getIntent = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Activity.n_GetIntent));
			}
			return Activity.cb_getIntent;
		}

		// Token: 0x060015CB RID: 5579 RVA: 0x0003784A File Offset: 0x00035A4A
		private static IntPtr n_GetIntent(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Intent);
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x060015CC RID: 5580 RVA: 0x00037860 File Offset: 0x00035A60
		public virtual Intent Intent
		{
			get
			{
				return Java.Lang.Object.GetObject<Intent>(Activity._members.InstanceMethods.InvokeVirtualObjectMethod("getIntent.()Landroid/content/Intent;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060015CD RID: 5581 RVA: 0x00037892 File Offset: 0x00035A92
		private static Delegate GetGetMenuInflaterHandler()
		{
			if (Activity.cb_getMenuInflater == null)
			{
				Activity.cb_getMenuInflater = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Activity.n_GetMenuInflater));
			}
			return Activity.cb_getMenuInflater;
		}

		// Token: 0x060015CE RID: 5582 RVA: 0x000378B6 File Offset: 0x00035AB6
		private static IntPtr n_GetMenuInflater(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MenuInflater);
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x060015CF RID: 5583 RVA: 0x000378CC File Offset: 0x00035ACC
		public virtual MenuInflater MenuInflater
		{
			get
			{
				return Java.Lang.Object.GetObject<MenuInflater>(Activity._members.InstanceMethods.InvokeVirtualObjectMethod("getMenuInflater.()Landroid/view/MenuInflater;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x000378FE File Offset: 0x00035AFE
		private static Delegate GetSetRequestedOrientation_IHandler()
		{
			if (Activity.cb_setRequestedOrientation_I == null)
			{
				Activity.cb_setRequestedOrientation_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(Activity.n_SetRequestedOrientation_I));
			}
			return Activity.cb_setRequestedOrientation_I;
		}

		// Token: 0x060015D1 RID: 5585 RVA: 0x00037924 File Offset: 0x00035B24
		private static void n_SetRequestedOrientation_I(IntPtr jnienv, IntPtr native__this, int native_requestedOrientation)
		{
			Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RequestedOrientation = (ScreenOrientation)native_requestedOrientation;
		}

		// Token: 0x170004DA RID: 1242
		// (set) Token: 0x060015D2 RID: 5586 RVA: 0x00037944 File Offset: 0x00035B44
		public unsafe virtual ScreenOrientation RequestedOrientation
		{
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((int)value);
				Activity._members.InstanceMethods.InvokeVirtualVoidMethod("setRequestedOrientation.(I)V", this, ptr);
			}
		}

		// Token: 0x170004DB RID: 1243
		// (set) Token: 0x060015D3 RID: 5587 RVA: 0x00037980 File Offset: 0x00035B80
		public unsafe Stream VolumeControlStream
		{
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((int)value);
				Activity._members.InstanceMethods.InvokeNonvirtualVoidMethod("setVolumeControlStream.(I)V", this, ptr);
			}
		}

		// Token: 0x060015D4 RID: 5588 RVA: 0x000379BB File Offset: 0x00035BBB
		private static Delegate GetGetWindowHandler()
		{
			if (Activity.cb_getWindow == null)
			{
				Activity.cb_getWindow = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Activity.n_GetWindow));
			}
			return Activity.cb_getWindow;
		}

		// Token: 0x060015D5 RID: 5589 RVA: 0x000379DF File Offset: 0x00035BDF
		private static IntPtr n_GetWindow(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Window);
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x060015D6 RID: 5590 RVA: 0x000379F4 File Offset: 0x00035BF4
		public virtual Window Window
		{
			get
			{
				return Java.Lang.Object.GetObject<Window>(Activity._members.InstanceMethods.InvokeVirtualObjectMethod("getWindow.()Landroid/view/Window;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060015D7 RID: 5591 RVA: 0x00037A26 File Offset: 0x00035C26
		private static Delegate GetDispatchGenericMotionEvent_Landroid_view_MotionEvent_Handler()
		{
			if (Activity.cb_dispatchGenericMotionEvent_Landroid_view_MotionEvent_ == null)
			{
				Activity.cb_dispatchGenericMotionEvent_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(Activity.n_DispatchGenericMotionEvent_Landroid_view_MotionEvent_));
			}
			return Activity.cb_dispatchGenericMotionEvent_Landroid_view_MotionEvent_;
		}

		// Token: 0x060015D8 RID: 5592 RVA: 0x00037A4C File Offset: 0x00035C4C
		private static bool n_DispatchGenericMotionEvent_Landroid_view_MotionEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_ev)
		{
			Activity @object = Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MotionEvent object2 = Java.Lang.Object.GetObject<MotionEvent>(native_ev, JniHandleOwnership.DoNotTransfer);
			return @object.DispatchGenericMotionEvent(object2);
		}

		// Token: 0x060015D9 RID: 5593 RVA: 0x00037A70 File Offset: 0x00035C70
		public unsafe virtual bool DispatchGenericMotionEvent(MotionEvent ev)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((ev == null) ? IntPtr.Zero : ev.Handle);
				result = Activity._members.InstanceMethods.InvokeVirtualBooleanMethod("dispatchGenericMotionEvent.(Landroid/view/MotionEvent;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(ev);
			}
			return result;
		}

		// Token: 0x060015DA RID: 5594 RVA: 0x00037AD8 File Offset: 0x00035CD8
		private static Delegate GetDispatchKeyEvent_Landroid_view_KeyEvent_Handler()
		{
			if (Activity.cb_dispatchKeyEvent_Landroid_view_KeyEvent_ == null)
			{
				Activity.cb_dispatchKeyEvent_Landroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(Activity.n_DispatchKeyEvent_Landroid_view_KeyEvent_));
			}
			return Activity.cb_dispatchKeyEvent_Landroid_view_KeyEvent_;
		}

		// Token: 0x060015DB RID: 5595 RVA: 0x00037AFC File Offset: 0x00035CFC
		private static bool n_DispatchKeyEvent_Landroid_view_KeyEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			Activity @object = Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			KeyEvent object2 = Java.Lang.Object.GetObject<KeyEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.DispatchKeyEvent(object2);
		}

		// Token: 0x060015DC RID: 5596 RVA: 0x00037B20 File Offset: 0x00035D20
		public unsafe virtual bool DispatchKeyEvent(KeyEvent e)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				result = Activity._members.InstanceMethods.InvokeVirtualBooleanMethod("dispatchKeyEvent.(Landroid/view/KeyEvent;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(e);
			}
			return result;
		}

		// Token: 0x060015DD RID: 5597 RVA: 0x00037B88 File Offset: 0x00035D88
		private static Delegate GetDispatchKeyShortcutEvent_Landroid_view_KeyEvent_Handler()
		{
			if (Activity.cb_dispatchKeyShortcutEvent_Landroid_view_KeyEvent_ == null)
			{
				Activity.cb_dispatchKeyShortcutEvent_Landroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(Activity.n_DispatchKeyShortcutEvent_Landroid_view_KeyEvent_));
			}
			return Activity.cb_dispatchKeyShortcutEvent_Landroid_view_KeyEvent_;
		}

		// Token: 0x060015DE RID: 5598 RVA: 0x00037BAC File Offset: 0x00035DAC
		private static bool n_DispatchKeyShortcutEvent_Landroid_view_KeyEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			Activity @object = Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			KeyEvent object2 = Java.Lang.Object.GetObject<KeyEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.DispatchKeyShortcutEvent(object2);
		}

		// Token: 0x060015DF RID: 5599 RVA: 0x00037BD0 File Offset: 0x00035DD0
		public unsafe virtual bool DispatchKeyShortcutEvent(KeyEvent e)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				result = Activity._members.InstanceMethods.InvokeVirtualBooleanMethod("dispatchKeyShortcutEvent.(Landroid/view/KeyEvent;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(e);
			}
			return result;
		}

		// Token: 0x060015E0 RID: 5600 RVA: 0x00037C38 File Offset: 0x00035E38
		private static Delegate GetDispatchPopulateAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_Handler()
		{
			if (Activity.cb_dispatchPopulateAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_ == null)
			{
				Activity.cb_dispatchPopulateAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(Activity.n_DispatchPopulateAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_));
			}
			return Activity.cb_dispatchPopulateAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_;
		}

		// Token: 0x060015E1 RID: 5601 RVA: 0x00037C5C File Offset: 0x00035E5C
		private static bool n_DispatchPopulateAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			Activity @object = Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AccessibilityEvent object2 = Java.Lang.Object.GetObject<AccessibilityEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.DispatchPopulateAccessibilityEvent(object2);
		}

		// Token: 0x060015E2 RID: 5602 RVA: 0x00037C80 File Offset: 0x00035E80
		public unsafe virtual bool DispatchPopulateAccessibilityEvent(AccessibilityEvent e)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				result = Activity._members.InstanceMethods.InvokeVirtualBooleanMethod("dispatchPopulateAccessibilityEvent.(Landroid/view/accessibility/AccessibilityEvent;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(e);
			}
			return result;
		}

		// Token: 0x060015E3 RID: 5603 RVA: 0x00037CE8 File Offset: 0x00035EE8
		private static Delegate GetDispatchTouchEvent_Landroid_view_MotionEvent_Handler()
		{
			if (Activity.cb_dispatchTouchEvent_Landroid_view_MotionEvent_ == null)
			{
				Activity.cb_dispatchTouchEvent_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(Activity.n_DispatchTouchEvent_Landroid_view_MotionEvent_));
			}
			return Activity.cb_dispatchTouchEvent_Landroid_view_MotionEvent_;
		}

		// Token: 0x060015E4 RID: 5604 RVA: 0x00037D0C File Offset: 0x00035F0C
		private static bool n_DispatchTouchEvent_Landroid_view_MotionEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_ev)
		{
			Activity @object = Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MotionEvent object2 = Java.Lang.Object.GetObject<MotionEvent>(native_ev, JniHandleOwnership.DoNotTransfer);
			return @object.DispatchTouchEvent(object2);
		}

		// Token: 0x060015E5 RID: 5605 RVA: 0x00037D30 File Offset: 0x00035F30
		public unsafe virtual bool DispatchTouchEvent(MotionEvent ev)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((ev == null) ? IntPtr.Zero : ev.Handle);
				result = Activity._members.InstanceMethods.InvokeVirtualBooleanMethod("dispatchTouchEvent.(Landroid/view/MotionEvent;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(ev);
			}
			return result;
		}

		// Token: 0x060015E6 RID: 5606 RVA: 0x00037D98 File Offset: 0x00035F98
		private static Delegate GetDispatchTrackballEvent_Landroid_view_MotionEvent_Handler()
		{
			if (Activity.cb_dispatchTrackballEvent_Landroid_view_MotionEvent_ == null)
			{
				Activity.cb_dispatchTrackballEvent_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(Activity.n_DispatchTrackballEvent_Landroid_view_MotionEvent_));
			}
			return Activity.cb_dispatchTrackballEvent_Landroid_view_MotionEvent_;
		}

		// Token: 0x060015E7 RID: 5607 RVA: 0x00037DBC File Offset: 0x00035FBC
		private static bool n_DispatchTrackballEvent_Landroid_view_MotionEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_ev)
		{
			Activity @object = Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MotionEvent object2 = Java.Lang.Object.GetObject<MotionEvent>(native_ev, JniHandleOwnership.DoNotTransfer);
			return @object.DispatchTrackballEvent(object2);
		}

		// Token: 0x060015E8 RID: 5608 RVA: 0x00037DE0 File Offset: 0x00035FE0
		public unsafe virtual bool DispatchTrackballEvent(MotionEvent ev)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((ev == null) ? IntPtr.Zero : ev.Handle);
				result = Activity._members.InstanceMethods.InvokeVirtualBooleanMethod("dispatchTrackballEvent.(Landroid/view/MotionEvent;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(ev);
			}
			return result;
		}

		// Token: 0x060015E9 RID: 5609 RVA: 0x00037E48 File Offset: 0x00036048
		private static Delegate GetFindViewById_IHandler()
		{
			if (Activity.cb_findViewById_I == null)
			{
				Activity.cb_findViewById_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(Activity.n_FindViewById_I));
			}
			return Activity.cb_findViewById_I;
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x00037E6C File Offset: 0x0003606C
		private static IntPtr n_FindViewById_I(IntPtr jnienv, IntPtr native__this, int id)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FindViewById(id));
		}

		// Token: 0x060015EB RID: 5611 RVA: 0x00037E84 File Offset: 0x00036084
		public unsafe virtual View FindViewById(int id)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(id);
			return Java.Lang.Object.GetObject<View>(Activity._members.InstanceMethods.InvokeVirtualObjectMethod("findViewById.(I)Landroid/view/View;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060015EC RID: 5612 RVA: 0x00037ECD File Offset: 0x000360CD
		private static Delegate GetFinishHandler()
		{
			if (Activity.cb_finish == null)
			{
				Activity.cb_finish = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Activity.n_Finish));
			}
			return Activity.cb_finish;
		}

		// Token: 0x060015ED RID: 5613 RVA: 0x00037EF1 File Offset: 0x000360F1
		private static void n_Finish(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Finish();
		}

		// Token: 0x060015EE RID: 5614 RVA: 0x00037F00 File Offset: 0x00036100
		public virtual void Finish()
		{
			Activity._members.InstanceMethods.InvokeVirtualVoidMethod("finish.()V", this, null);
		}

		// Token: 0x060015EF RID: 5615 RVA: 0x00037F19 File Offset: 0x00036119
		private static Delegate GetOnActionModeFinished_Landroid_view_ActionMode_Handler()
		{
			if (Activity.cb_onActionModeFinished_Landroid_view_ActionMode_ == null)
			{
				Activity.cb_onActionModeFinished_Landroid_view_ActionMode_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Activity.n_OnActionModeFinished_Landroid_view_ActionMode_));
			}
			return Activity.cb_onActionModeFinished_Landroid_view_ActionMode_;
		}

		// Token: 0x060015F0 RID: 5616 RVA: 0x00037F40 File Offset: 0x00036140
		private static void n_OnActionModeFinished_Landroid_view_ActionMode_(IntPtr jnienv, IntPtr native__this, IntPtr native_mode)
		{
			Activity @object = Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ActionMode object2 = Java.Lang.Object.GetObject<ActionMode>(native_mode, JniHandleOwnership.DoNotTransfer);
			@object.OnActionModeFinished(object2);
		}

		// Token: 0x060015F1 RID: 5617 RVA: 0x00037F64 File Offset: 0x00036164
		public unsafe virtual void OnActionModeFinished(ActionMode mode)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((mode == null) ? IntPtr.Zero : mode.Handle);
				Activity._members.InstanceMethods.InvokeVirtualVoidMethod("onActionModeFinished.(Landroid/view/ActionMode;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(mode);
			}
		}

		// Token: 0x060015F2 RID: 5618 RVA: 0x00037FC8 File Offset: 0x000361C8
		private static Delegate GetOnActionModeStarted_Landroid_view_ActionMode_Handler()
		{
			if (Activity.cb_onActionModeStarted_Landroid_view_ActionMode_ == null)
			{
				Activity.cb_onActionModeStarted_Landroid_view_ActionMode_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Activity.n_OnActionModeStarted_Landroid_view_ActionMode_));
			}
			return Activity.cb_onActionModeStarted_Landroid_view_ActionMode_;
		}

		// Token: 0x060015F3 RID: 5619 RVA: 0x00037FEC File Offset: 0x000361EC
		private static void n_OnActionModeStarted_Landroid_view_ActionMode_(IntPtr jnienv, IntPtr native__this, IntPtr native_mode)
		{
			Activity @object = Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ActionMode object2 = Java.Lang.Object.GetObject<ActionMode>(native_mode, JniHandleOwnership.DoNotTransfer);
			@object.OnActionModeStarted(object2);
		}

		// Token: 0x060015F4 RID: 5620 RVA: 0x00038010 File Offset: 0x00036210
		public unsafe virtual void OnActionModeStarted(ActionMode mode)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((mode == null) ? IntPtr.Zero : mode.Handle);
				Activity._members.InstanceMethods.InvokeVirtualVoidMethod("onActionModeStarted.(Landroid/view/ActionMode;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(mode);
			}
		}

		// Token: 0x060015F5 RID: 5621 RVA: 0x00038074 File Offset: 0x00036274
		private static Delegate GetOnActivityResult_IILandroid_content_Intent_Handler()
		{
			if (Activity.cb_onActivityResult_IILandroid_content_Intent_ == null)
			{
				Activity.cb_onActivityResult_IILandroid_content_Intent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIL_V(Activity.n_OnActivityResult_IILandroid_content_Intent_));
			}
			return Activity.cb_onActivityResult_IILandroid_content_Intent_;
		}

		// Token: 0x060015F6 RID: 5622 RVA: 0x00038098 File Offset: 0x00036298
		private static void n_OnActivityResult_IILandroid_content_Intent_(IntPtr jnienv, IntPtr native__this, int requestCode, int native_resultCode, IntPtr native_data)
		{
			Activity @object = Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Intent object2 = Java.Lang.Object.GetObject<Intent>(native_data, JniHandleOwnership.DoNotTransfer);
			@object.OnActivityResult(requestCode, (Result)native_resultCode, object2);
		}

		// Token: 0x060015F7 RID: 5623 RVA: 0x000380C0 File Offset: 0x000362C0
		protected unsafe virtual void OnActivityResult(int requestCode, [GeneratedEnum] Result resultCode, Intent data)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(requestCode);
				ptr[1] = new JniArgumentValue((int)resultCode);
				ptr[2] = new JniArgumentValue((data == null) ? IntPtr.Zero : data.Handle);
				Activity._members.InstanceMethods.InvokeVirtualVoidMethod("onActivityResult.(IILandroid/content/Intent;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(data);
			}
		}

		// Token: 0x060015F8 RID: 5624 RVA: 0x0003814C File Offset: 0x0003634C
		private static Delegate GetOnAttachedToWindowHandler()
		{
			if (Activity.cb_onAttachedToWindow == null)
			{
				Activity.cb_onAttachedToWindow = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Activity.n_OnAttachedToWindow));
			}
			return Activity.cb_onAttachedToWindow;
		}

		// Token: 0x060015F9 RID: 5625 RVA: 0x00038170 File Offset: 0x00036370
		private static void n_OnAttachedToWindow(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnAttachedToWindow();
		}

		// Token: 0x060015FA RID: 5626 RVA: 0x0003817F File Offset: 0x0003637F
		public virtual void OnAttachedToWindow()
		{
			Activity._members.InstanceMethods.InvokeVirtualVoidMethod("onAttachedToWindow.()V", this, null);
		}

		// Token: 0x060015FB RID: 5627 RVA: 0x00038198 File Offset: 0x00036398
		private static Delegate GetOnBackPressedHandler()
		{
			if (Activity.cb_onBackPressed == null)
			{
				Activity.cb_onBackPressed = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Activity.n_OnBackPressed));
			}
			return Activity.cb_onBackPressed;
		}

		// Token: 0x060015FC RID: 5628 RVA: 0x000381BC File Offset: 0x000363BC
		private static void n_OnBackPressed(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnBackPressed();
		}

		// Token: 0x060015FD RID: 5629 RVA: 0x000381CB File Offset: 0x000363CB
		public virtual void OnBackPressed()
		{
			Activity._members.InstanceMethods.InvokeVirtualVoidMethod("onBackPressed.()V", this, null);
		}

		// Token: 0x060015FE RID: 5630 RVA: 0x000381E4 File Offset: 0x000363E4
		private static Delegate GetOnConfigurationChanged_Landroid_content_res_Configuration_Handler()
		{
			if (Activity.cb_onConfigurationChanged_Landroid_content_res_Configuration_ == null)
			{
				Activity.cb_onConfigurationChanged_Landroid_content_res_Configuration_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Activity.n_OnConfigurationChanged_Landroid_content_res_Configuration_));
			}
			return Activity.cb_onConfigurationChanged_Landroid_content_res_Configuration_;
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x00038208 File Offset: 0x00036408
		private static void n_OnConfigurationChanged_Landroid_content_res_Configuration_(IntPtr jnienv, IntPtr native__this, IntPtr native_newConfig)
		{
			Activity @object = Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Configuration object2 = Java.Lang.Object.GetObject<Configuration>(native_newConfig, JniHandleOwnership.DoNotTransfer);
			@object.OnConfigurationChanged(object2);
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x0003822C File Offset: 0x0003642C
		public unsafe virtual void OnConfigurationChanged(Configuration newConfig)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((newConfig == null) ? IntPtr.Zero : newConfig.Handle);
				Activity._members.InstanceMethods.InvokeVirtualVoidMethod("onConfigurationChanged.(Landroid/content/res/Configuration;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(newConfig);
			}
		}

		// Token: 0x06001601 RID: 5633 RVA: 0x00038290 File Offset: 0x00036490
		private static Delegate GetOnContentChangedHandler()
		{
			if (Activity.cb_onContentChanged == null)
			{
				Activity.cb_onContentChanged = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Activity.n_OnContentChanged));
			}
			return Activity.cb_onContentChanged;
		}

		// Token: 0x06001602 RID: 5634 RVA: 0x000382B4 File Offset: 0x000364B4
		private static void n_OnContentChanged(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnContentChanged();
		}

		// Token: 0x06001603 RID: 5635 RVA: 0x000382C3 File Offset: 0x000364C3
		public virtual void OnContentChanged()
		{
			Activity._members.InstanceMethods.InvokeVirtualVoidMethod("onContentChanged.()V", this, null);
		}

		// Token: 0x06001604 RID: 5636 RVA: 0x000382DC File Offset: 0x000364DC
		private static Delegate GetOnCreate_Landroid_os_Bundle_Handler()
		{
			if (Activity.cb_onCreate_Landroid_os_Bundle_ == null)
			{
				Activity.cb_onCreate_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Activity.n_OnCreate_Landroid_os_Bundle_));
			}
			return Activity.cb_onCreate_Landroid_os_Bundle_;
		}

		// Token: 0x06001605 RID: 5637 RVA: 0x00038300 File Offset: 0x00036500
		private static void n_OnCreate_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_savedInstanceState)
		{
			Activity @object = Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_savedInstanceState, JniHandleOwnership.DoNotTransfer);
			@object.OnCreate(object2);
		}

		// Token: 0x06001606 RID: 5638 RVA: 0x00038324 File Offset: 0x00036524
		protected unsafe virtual void OnCreate(Bundle savedInstanceState)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((savedInstanceState == null) ? IntPtr.Zero : savedInstanceState.Handle);
				Activity._members.InstanceMethods.InvokeVirtualVoidMethod("onCreate.(Landroid/os/Bundle;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(savedInstanceState);
			}
		}

		// Token: 0x06001607 RID: 5639 RVA: 0x00038388 File Offset: 0x00036588
		private static Delegate GetOnCreate_Landroid_os_Bundle_Landroid_os_PersistableBundle_Handler()
		{
			if (Activity.cb_onCreate_Landroid_os_Bundle_Landroid_os_PersistableBundle_ == null)
			{
				Activity.cb_onCreate_Landroid_os_Bundle_Landroid_os_PersistableBundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(Activity.n_OnCreate_Landroid_os_Bundle_Landroid_os_PersistableBundle_));
			}
			return Activity.cb_onCreate_Landroid_os_Bundle_Landroid_os_PersistableBundle_;
		}

		// Token: 0x06001608 RID: 5640 RVA: 0x000383AC File Offset: 0x000365AC
		private static void n_OnCreate_Landroid_os_Bundle_Landroid_os_PersistableBundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_savedInstanceState, IntPtr native_persistentState)
		{
			Activity @object = Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_savedInstanceState, JniHandleOwnership.DoNotTransfer);
			PersistableBundle object3 = Java.Lang.Object.GetObject<PersistableBundle>(native_persistentState, JniHandleOwnership.DoNotTransfer);
			@object.OnCreate(object2, object3);
		}

		// Token: 0x06001609 RID: 5641 RVA: 0x000383D8 File Offset: 0x000365D8
		public unsafe virtual void OnCreate(Bundle savedInstanceState, PersistableBundle persistentState)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((savedInstanceState == null) ? IntPtr.Zero : savedInstanceState.Handle);
				ptr[1] = new JniArgumentValue((persistentState == null) ? IntPtr.Zero : persistentState.Handle);
				Activity._members.InstanceMethods.InvokeVirtualVoidMethod("onCreate.(Landroid/os/Bundle;Landroid/os/PersistableBundle;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(savedInstanceState);
				GC.KeepAlive(persistentState);
			}
		}

		// Token: 0x0600160A RID: 5642 RVA: 0x00038464 File Offset: 0x00036664
		private static Delegate GetOnCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_Handler()
		{
			if (Activity.cb_onCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_ == null)
			{
				Activity.cb_onCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(Activity.n_OnCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_));
			}
			return Activity.cb_onCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_;
		}

		// Token: 0x0600160B RID: 5643 RVA: 0x00038488 File Offset: 0x00036688
		private static void n_OnCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_(IntPtr jnienv, IntPtr native__this, IntPtr native_menu, IntPtr native_v, IntPtr native_menuInfo)
		{
			Activity @object = Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IContextMenu object2 = Java.Lang.Object.GetObject<IContextMenu>(native_menu, JniHandleOwnership.DoNotTransfer);
			View object3 = Java.Lang.Object.GetObject<View>(native_v, JniHandleOwnership.DoNotTransfer);
			IContextMenuContextMenuInfo object4 = Java.Lang.Object.GetObject<IContextMenuContextMenuInfo>(native_menuInfo, JniHandleOwnership.DoNotTransfer);
			@object.OnCreateContextMenu(object2, object3, object4);
		}

		// Token: 0x0600160C RID: 5644 RVA: 0x000384C0 File Offset: 0x000366C0
		public unsafe virtual void OnCreateContextMenu(IContextMenu menu, View v, IContextMenuContextMenuInfo menuInfo)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((menu == null) ? IntPtr.Zero : ((Java.Lang.Object)menu).Handle);
				ptr[1] = new JniArgumentValue((v == null) ? IntPtr.Zero : v.Handle);
				ptr[2] = new JniArgumentValue((menuInfo == null) ? IntPtr.Zero : ((Java.Lang.Object)menuInfo).Handle);
				Activity._members.InstanceMethods.InvokeVirtualVoidMethod("onCreateContextMenu.(Landroid/view/ContextMenu;Landroid/view/View;Landroid/view/ContextMenu$ContextMenuInfo;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(menu);
				GC.KeepAlive(v);
				GC.KeepAlive(menuInfo);
			}
		}

		// Token: 0x0600160D RID: 5645 RVA: 0x00038580 File Offset: 0x00036780
		private static Delegate GetOnCreateOptionsMenu_Landroid_view_Menu_Handler()
		{
			if (Activity.cb_onCreateOptionsMenu_Landroid_view_Menu_ == null)
			{
				Activity.cb_onCreateOptionsMenu_Landroid_view_Menu_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(Activity.n_OnCreateOptionsMenu_Landroid_view_Menu_));
			}
			return Activity.cb_onCreateOptionsMenu_Landroid_view_Menu_;
		}

		// Token: 0x0600160E RID: 5646 RVA: 0x000385A4 File Offset: 0x000367A4
		private static bool n_OnCreateOptionsMenu_Landroid_view_Menu_(IntPtr jnienv, IntPtr native__this, IntPtr native_menu)
		{
			Activity @object = Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMenu object2 = Java.Lang.Object.GetObject<IMenu>(native_menu, JniHandleOwnership.DoNotTransfer);
			return @object.OnCreateOptionsMenu(object2);
		}

		// Token: 0x0600160F RID: 5647 RVA: 0x000385C8 File Offset: 0x000367C8
		public unsafe virtual bool OnCreateOptionsMenu(IMenu menu)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((menu == null) ? IntPtr.Zero : ((Java.Lang.Object)menu).Handle);
				result = Activity._members.InstanceMethods.InvokeVirtualBooleanMethod("onCreateOptionsMenu.(Landroid/view/Menu;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(menu);
			}
			return result;
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x00038634 File Offset: 0x00036834
		private static Delegate GetOnCreatePanelMenu_ILandroid_view_Menu_Handler()
		{
			if (Activity.cb_onCreatePanelMenu_ILandroid_view_Menu_ == null)
			{
				Activity.cb_onCreatePanelMenu_ILandroid_view_Menu_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_Z(Activity.n_OnCreatePanelMenu_ILandroid_view_Menu_));
			}
			return Activity.cb_onCreatePanelMenu_ILandroid_view_Menu_;
		}

		// Token: 0x06001611 RID: 5649 RVA: 0x00038658 File Offset: 0x00036858
		private static bool n_OnCreatePanelMenu_ILandroid_view_Menu_(IntPtr jnienv, IntPtr native__this, int featureId, IntPtr native_menu)
		{
			Activity @object = Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMenu object2 = Java.Lang.Object.GetObject<IMenu>(native_menu, JniHandleOwnership.DoNotTransfer);
			return @object.OnCreatePanelMenu(featureId, object2);
		}

		// Token: 0x06001612 RID: 5650 RVA: 0x0003867C File Offset: 0x0003687C
		public unsafe virtual bool OnCreatePanelMenu(int featureId, IMenu menu)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(featureId);
				ptr[1] = new JniArgumentValue((menu == null) ? IntPtr.Zero : ((Java.Lang.Object)menu).Handle);
				result = Activity._members.InstanceMethods.InvokeVirtualBooleanMethod("onCreatePanelMenu.(ILandroid/view/Menu;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(menu);
			}
			return result;
		}

		// Token: 0x06001613 RID: 5651 RVA: 0x000386FC File Offset: 0x000368FC
		private static Delegate GetOnCreatePanelView_IHandler()
		{
			if (Activity.cb_onCreatePanelView_I == null)
			{
				Activity.cb_onCreatePanelView_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(Activity.n_OnCreatePanelView_I));
			}
			return Activity.cb_onCreatePanelView_I;
		}

		// Token: 0x06001614 RID: 5652 RVA: 0x00038720 File Offset: 0x00036920
		private static IntPtr n_OnCreatePanelView_I(IntPtr jnienv, IntPtr native__this, int featureId)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnCreatePanelView(featureId));
		}

		// Token: 0x06001615 RID: 5653 RVA: 0x00038738 File Offset: 0x00036938
		public unsafe virtual View OnCreatePanelView(int featureId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(featureId);
			return Java.Lang.Object.GetObject<View>(Activity._members.InstanceMethods.InvokeVirtualObjectMethod("onCreatePanelView.(I)Landroid/view/View;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001616 RID: 5654 RVA: 0x00038781 File Offset: 0x00036981
		private static Delegate GetOnCreateView_Landroid_view_View_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_Handler()
		{
			if (Activity.cb_onCreateView_Landroid_view_View_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_ == null)
			{
				Activity.cb_onCreateView_Landroid_view_View_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLL_L(Activity.n_OnCreateView_Landroid_view_View_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_));
			}
			return Activity.cb_onCreateView_Landroid_view_View_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_;
		}

		// Token: 0x06001617 RID: 5655 RVA: 0x000387A8 File Offset: 0x000369A8
		private static IntPtr n_OnCreateView_Landroid_view_View_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_(IntPtr jnienv, IntPtr native__this, IntPtr native_parent, IntPtr native_name, IntPtr native_context, IntPtr native_attrs)
		{
			Activity @object = Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_parent, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_name, JniHandleOwnership.DoNotTransfer);
			Context object3 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			IAttributeSet object4 = Java.Lang.Object.GetObject<IAttributeSet>(native_attrs, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.OnCreateView(object2, @string, object3, object4));
		}

		// Token: 0x06001618 RID: 5656 RVA: 0x000387F0 File Offset: 0x000369F0
		public unsafe virtual View OnCreateView(View parent, string name, Context context, IAttributeSet attrs)
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
				@object = Java.Lang.Object.GetObject<View>(Activity._members.InstanceMethods.InvokeVirtualObjectMethod("onCreateView.(Landroid/view/View;Ljava/lang/String;Landroid/content/Context;Landroid/util/AttributeSet;)Landroid/view/View;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x06001619 RID: 5657 RVA: 0x000388E4 File Offset: 0x00036AE4
		private static Delegate GetOnCreateView_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_Handler()
		{
			if (Activity.cb_onCreateView_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_ == null)
			{
				Activity.cb_onCreateView_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(Activity.n_OnCreateView_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_));
			}
			return Activity.cb_onCreateView_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_;
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x00038908 File Offset: 0x00036B08
		private static IntPtr n_OnCreateView_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_(IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_context, IntPtr native_attrs)
		{
			Activity @object = Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_name, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			IAttributeSet object3 = Java.Lang.Object.GetObject<IAttributeSet>(native_attrs, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.OnCreateView(@string, object2, object3));
		}

		// Token: 0x0600161B RID: 5659 RVA: 0x00038944 File Offset: 0x00036B44
		public unsafe virtual View OnCreateView(string name, Context context, IAttributeSet attrs)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			View @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[2] = new JniArgumentValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
				@object = Java.Lang.Object.GetObject<View>(Activity._members.InstanceMethods.InvokeVirtualObjectMethod("onCreateView.(Ljava/lang/String;Landroid/content/Context;Landroid/util/AttributeSet;)Landroid/view/View;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
			return @object;
		}

		// Token: 0x0600161C RID: 5660 RVA: 0x00038A08 File Offset: 0x00036C08
		private static Delegate GetOnDetachedFromWindowHandler()
		{
			if (Activity.cb_onDetachedFromWindow == null)
			{
				Activity.cb_onDetachedFromWindow = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Activity.n_OnDetachedFromWindow));
			}
			return Activity.cb_onDetachedFromWindow;
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x00038A2C File Offset: 0x00036C2C
		private static void n_OnDetachedFromWindow(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnDetachedFromWindow();
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x00038A3B File Offset: 0x00036C3B
		public virtual void OnDetachedFromWindow()
		{
			Activity._members.InstanceMethods.InvokeVirtualVoidMethod("onDetachedFromWindow.()V", this, null);
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x00038A54 File Offset: 0x00036C54
		private static Delegate GetOnKeyDown_ILandroid_view_KeyEvent_Handler()
		{
			if (Activity.cb_onKeyDown_ILandroid_view_KeyEvent_ == null)
			{
				Activity.cb_onKeyDown_ILandroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_Z(Activity.n_OnKeyDown_ILandroid_view_KeyEvent_));
			}
			return Activity.cb_onKeyDown_ILandroid_view_KeyEvent_;
		}

		// Token: 0x06001620 RID: 5664 RVA: 0x00038A78 File Offset: 0x00036C78
		private static bool n_OnKeyDown_ILandroid_view_KeyEvent_(IntPtr jnienv, IntPtr native__this, int native_keyCode, IntPtr native_e)
		{
			Activity @object = Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			KeyEvent object2 = Java.Lang.Object.GetObject<KeyEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.OnKeyDown((Keycode)native_keyCode, object2);
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x00038AA0 File Offset: 0x00036CA0
		public unsafe virtual bool OnKeyDown([GeneratedEnum] Keycode keyCode, KeyEvent e)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((int)keyCode);
				ptr[1] = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				result = Activity._members.InstanceMethods.InvokeVirtualBooleanMethod("onKeyDown.(ILandroid/view/KeyEvent;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(e);
			}
			return result;
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x00038B18 File Offset: 0x00036D18
		private static Delegate GetOnKeyLongPress_ILandroid_view_KeyEvent_Handler()
		{
			if (Activity.cb_onKeyLongPress_ILandroid_view_KeyEvent_ == null)
			{
				Activity.cb_onKeyLongPress_ILandroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_Z(Activity.n_OnKeyLongPress_ILandroid_view_KeyEvent_));
			}
			return Activity.cb_onKeyLongPress_ILandroid_view_KeyEvent_;
		}

		// Token: 0x06001623 RID: 5667 RVA: 0x00038B3C File Offset: 0x00036D3C
		private static bool n_OnKeyLongPress_ILandroid_view_KeyEvent_(IntPtr jnienv, IntPtr native__this, int native_keyCode, IntPtr native_e)
		{
			Activity @object = Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			KeyEvent object2 = Java.Lang.Object.GetObject<KeyEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.OnKeyLongPress((Keycode)native_keyCode, object2);
		}

		// Token: 0x06001624 RID: 5668 RVA: 0x00038B64 File Offset: 0x00036D64
		public unsafe virtual bool OnKeyLongPress([GeneratedEnum] Keycode keyCode, KeyEvent e)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((int)keyCode);
				ptr[1] = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				result = Activity._members.InstanceMethods.InvokeVirtualBooleanMethod("onKeyLongPress.(ILandroid/view/KeyEvent;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(e);
			}
			return result;
		}

		// Token: 0x06001625 RID: 5669 RVA: 0x00038BDC File Offset: 0x00036DDC
		private static Delegate GetOnKeyMultiple_IILandroid_view_KeyEvent_Handler()
		{
			if (Activity.cb_onKeyMultiple_IILandroid_view_KeyEvent_ == null)
			{
				Activity.cb_onKeyMultiple_IILandroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIL_Z(Activity.n_OnKeyMultiple_IILandroid_view_KeyEvent_));
			}
			return Activity.cb_onKeyMultiple_IILandroid_view_KeyEvent_;
		}

		// Token: 0x06001626 RID: 5670 RVA: 0x00038C00 File Offset: 0x00036E00
		private static bool n_OnKeyMultiple_IILandroid_view_KeyEvent_(IntPtr jnienv, IntPtr native__this, int native_keyCode, int repeatCount, IntPtr native_e)
		{
			Activity @object = Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			KeyEvent object2 = Java.Lang.Object.GetObject<KeyEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.OnKeyMultiple((Keycode)native_keyCode, repeatCount, object2);
		}

		// Token: 0x06001627 RID: 5671 RVA: 0x00038C28 File Offset: 0x00036E28
		public unsafe virtual bool OnKeyMultiple([GeneratedEnum] Keycode keyCode, int repeatCount, KeyEvent e)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((int)keyCode);
				ptr[1] = new JniArgumentValue(repeatCount);
				ptr[2] = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				result = Activity._members.InstanceMethods.InvokeVirtualBooleanMethod("onKeyMultiple.(IILandroid/view/KeyEvent;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(e);
			}
			return result;
		}

		// Token: 0x06001628 RID: 5672 RVA: 0x00038CB8 File Offset: 0x00036EB8
		private static Delegate GetOnKeyUp_ILandroid_view_KeyEvent_Handler()
		{
			if (Activity.cb_onKeyUp_ILandroid_view_KeyEvent_ == null)
			{
				Activity.cb_onKeyUp_ILandroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_Z(Activity.n_OnKeyUp_ILandroid_view_KeyEvent_));
			}
			return Activity.cb_onKeyUp_ILandroid_view_KeyEvent_;
		}

		// Token: 0x06001629 RID: 5673 RVA: 0x00038CDC File Offset: 0x00036EDC
		private static bool n_OnKeyUp_ILandroid_view_KeyEvent_(IntPtr jnienv, IntPtr native__this, int native_keyCode, IntPtr native_e)
		{
			Activity @object = Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			KeyEvent object2 = Java.Lang.Object.GetObject<KeyEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.OnKeyUp((Keycode)native_keyCode, object2);
		}

		// Token: 0x0600162A RID: 5674 RVA: 0x00038D04 File Offset: 0x00036F04
		public unsafe virtual bool OnKeyUp([GeneratedEnum] Keycode keyCode, KeyEvent e)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((int)keyCode);
				ptr[1] = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				result = Activity._members.InstanceMethods.InvokeVirtualBooleanMethod("onKeyUp.(ILandroid/view/KeyEvent;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(e);
			}
			return result;
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x00038D7C File Offset: 0x00036F7C
		private static Delegate GetOnLowMemoryHandler()
		{
			if (Activity.cb_onLowMemory == null)
			{
				Activity.cb_onLowMemory = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Activity.n_OnLowMemory));
			}
			return Activity.cb_onLowMemory;
		}

		// Token: 0x0600162C RID: 5676 RVA: 0x00038DA0 File Offset: 0x00036FA0
		private static void n_OnLowMemory(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnLowMemory();
		}

		// Token: 0x0600162D RID: 5677 RVA: 0x00038DAF File Offset: 0x00036FAF
		public virtual void OnLowMemory()
		{
			Activity._members.InstanceMethods.InvokeVirtualVoidMethod("onLowMemory.()V", this, null);
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x00038DC8 File Offset: 0x00036FC8
		private static Delegate GetOnMenuItemSelected_ILandroid_view_MenuItem_Handler()
		{
			if (Activity.cb_onMenuItemSelected_ILandroid_view_MenuItem_ == null)
			{
				Activity.cb_onMenuItemSelected_ILandroid_view_MenuItem_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_Z(Activity.n_OnMenuItemSelected_ILandroid_view_MenuItem_));
			}
			return Activity.cb_onMenuItemSelected_ILandroid_view_MenuItem_;
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x00038DEC File Offset: 0x00036FEC
		private static bool n_OnMenuItemSelected_ILandroid_view_MenuItem_(IntPtr jnienv, IntPtr native__this, int featureId, IntPtr native_item)
		{
			Activity @object = Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMenuItem object2 = Java.Lang.Object.GetObject<IMenuItem>(native_item, JniHandleOwnership.DoNotTransfer);
			return @object.OnMenuItemSelected(featureId, object2);
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x00038E10 File Offset: 0x00037010
		public unsafe virtual bool OnMenuItemSelected(int featureId, IMenuItem item)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(featureId);
				ptr[1] = new JniArgumentValue((item == null) ? IntPtr.Zero : ((Java.Lang.Object)item).Handle);
				result = Activity._members.InstanceMethods.InvokeVirtualBooleanMethod("onMenuItemSelected.(ILandroid/view/MenuItem;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(item);
			}
			return result;
		}

		// Token: 0x06001631 RID: 5681 RVA: 0x00038E90 File Offset: 0x00037090
		private static Delegate GetOnMenuOpened_ILandroid_view_Menu_Handler()
		{
			if (Activity.cb_onMenuOpened_ILandroid_view_Menu_ == null)
			{
				Activity.cb_onMenuOpened_ILandroid_view_Menu_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_Z(Activity.n_OnMenuOpened_ILandroid_view_Menu_));
			}
			return Activity.cb_onMenuOpened_ILandroid_view_Menu_;
		}

		// Token: 0x06001632 RID: 5682 RVA: 0x00038EB4 File Offset: 0x000370B4
		private static bool n_OnMenuOpened_ILandroid_view_Menu_(IntPtr jnienv, IntPtr native__this, int featureId, IntPtr native_menu)
		{
			Activity @object = Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMenu object2 = Java.Lang.Object.GetObject<IMenu>(native_menu, JniHandleOwnership.DoNotTransfer);
			return @object.OnMenuOpened(featureId, object2);
		}

		// Token: 0x06001633 RID: 5683 RVA: 0x00038ED8 File Offset: 0x000370D8
		public unsafe virtual bool OnMenuOpened(int featureId, IMenu menu)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(featureId);
				ptr[1] = new JniArgumentValue((menu == null) ? IntPtr.Zero : ((Java.Lang.Object)menu).Handle);
				result = Activity._members.InstanceMethods.InvokeVirtualBooleanMethod("onMenuOpened.(ILandroid/view/Menu;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(menu);
			}
			return result;
		}

		// Token: 0x06001634 RID: 5684 RVA: 0x00038F58 File Offset: 0x00037158
		private static Delegate GetOnOptionsItemSelected_Landroid_view_MenuItem_Handler()
		{
			if (Activity.cb_onOptionsItemSelected_Landroid_view_MenuItem_ == null)
			{
				Activity.cb_onOptionsItemSelected_Landroid_view_MenuItem_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(Activity.n_OnOptionsItemSelected_Landroid_view_MenuItem_));
			}
			return Activity.cb_onOptionsItemSelected_Landroid_view_MenuItem_;
		}

		// Token: 0x06001635 RID: 5685 RVA: 0x00038F7C File Offset: 0x0003717C
		private static bool n_OnOptionsItemSelected_Landroid_view_MenuItem_(IntPtr jnienv, IntPtr native__this, IntPtr native_item)
		{
			Activity @object = Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMenuItem object2 = Java.Lang.Object.GetObject<IMenuItem>(native_item, JniHandleOwnership.DoNotTransfer);
			return @object.OnOptionsItemSelected(object2);
		}

		// Token: 0x06001636 RID: 5686 RVA: 0x00038FA0 File Offset: 0x000371A0
		public unsafe virtual bool OnOptionsItemSelected(IMenuItem item)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((item == null) ? IntPtr.Zero : ((Java.Lang.Object)item).Handle);
				result = Activity._members.InstanceMethods.InvokeVirtualBooleanMethod("onOptionsItemSelected.(Landroid/view/MenuItem;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(item);
			}
			return result;
		}

		// Token: 0x06001637 RID: 5687 RVA: 0x0003900C File Offset: 0x0003720C
		private static Delegate GetOnPanelClosed_ILandroid_view_Menu_Handler()
		{
			if (Activity.cb_onPanelClosed_ILandroid_view_Menu_ == null)
			{
				Activity.cb_onPanelClosed_ILandroid_view_Menu_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_V(Activity.n_OnPanelClosed_ILandroid_view_Menu_));
			}
			return Activity.cb_onPanelClosed_ILandroid_view_Menu_;
		}

		// Token: 0x06001638 RID: 5688 RVA: 0x00039030 File Offset: 0x00037230
		private static void n_OnPanelClosed_ILandroid_view_Menu_(IntPtr jnienv, IntPtr native__this, int featureId, IntPtr native_menu)
		{
			Activity @object = Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMenu object2 = Java.Lang.Object.GetObject<IMenu>(native_menu, JniHandleOwnership.DoNotTransfer);
			@object.OnPanelClosed(featureId, object2);
		}

		// Token: 0x06001639 RID: 5689 RVA: 0x00039054 File Offset: 0x00037254
		public unsafe virtual void OnPanelClosed(int featureId, IMenu menu)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(featureId);
				ptr[1] = new JniArgumentValue((menu == null) ? IntPtr.Zero : ((Java.Lang.Object)menu).Handle);
				Activity._members.InstanceMethods.InvokeVirtualVoidMethod("onPanelClosed.(ILandroid/view/Menu;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(menu);
			}
		}

		// Token: 0x0600163A RID: 5690 RVA: 0x000390D0 File Offset: 0x000372D0
		private static Delegate GetOnPauseHandler()
		{
			if (Activity.cb_onPause == null)
			{
				Activity.cb_onPause = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Activity.n_OnPause));
			}
			return Activity.cb_onPause;
		}

		// Token: 0x0600163B RID: 5691 RVA: 0x000390F4 File Offset: 0x000372F4
		private static void n_OnPause(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnPause();
		}

		// Token: 0x0600163C RID: 5692 RVA: 0x00039103 File Offset: 0x00037303
		protected virtual void OnPause()
		{
			Activity._members.InstanceMethods.InvokeVirtualVoidMethod("onPause.()V", this, null);
		}

		// Token: 0x0600163D RID: 5693 RVA: 0x0003911C File Offset: 0x0003731C
		private static Delegate GetOnPreparePanel_ILandroid_view_View_Landroid_view_Menu_Handler()
		{
			if (Activity.cb_onPreparePanel_ILandroid_view_View_Landroid_view_Menu_ == null)
			{
				Activity.cb_onPreparePanel_ILandroid_view_View_Landroid_view_Menu_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPILL_Z(Activity.n_OnPreparePanel_ILandroid_view_View_Landroid_view_Menu_));
			}
			return Activity.cb_onPreparePanel_ILandroid_view_View_Landroid_view_Menu_;
		}

		// Token: 0x0600163E RID: 5694 RVA: 0x00039140 File Offset: 0x00037340
		private static bool n_OnPreparePanel_ILandroid_view_View_Landroid_view_Menu_(IntPtr jnienv, IntPtr native__this, int featureId, IntPtr native_view, IntPtr native_menu)
		{
			Activity @object = Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			IMenu object3 = Java.Lang.Object.GetObject<IMenu>(native_menu, JniHandleOwnership.DoNotTransfer);
			return @object.OnPreparePanel(featureId, object2, object3);
		}

		// Token: 0x0600163F RID: 5695 RVA: 0x00039170 File Offset: 0x00037370
		public unsafe virtual bool OnPreparePanel(int featureId, View view, IMenu menu)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(featureId);
				ptr[1] = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				ptr[2] = new JniArgumentValue((menu == null) ? IntPtr.Zero : ((Java.Lang.Object)menu).Handle);
				result = Activity._members.InstanceMethods.InvokeVirtualBooleanMethod("onPreparePanel.(ILandroid/view/View;Landroid/view/Menu;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(view);
				GC.KeepAlive(menu);
			}
			return result;
		}

		// Token: 0x06001640 RID: 5696 RVA: 0x00039218 File Offset: 0x00037418
		private static Delegate GetOnProvideKeyboardShortcuts_Ljava_util_List_Landroid_view_Menu_IHandler()
		{
			if (Activity.cb_onProvideKeyboardShortcuts_Ljava_util_List_Landroid_view_Menu_I == null)
			{
				Activity.cb_onProvideKeyboardShortcuts_Ljava_util_List_Landroid_view_Menu_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLI_V(Activity.n_OnProvideKeyboardShortcuts_Ljava_util_List_Landroid_view_Menu_I));
			}
			return Activity.cb_onProvideKeyboardShortcuts_Ljava_util_List_Landroid_view_Menu_I;
		}

		// Token: 0x06001641 RID: 5697 RVA: 0x0003923C File Offset: 0x0003743C
		private static void n_OnProvideKeyboardShortcuts_Ljava_util_List_Landroid_view_Menu_I(IntPtr jnienv, IntPtr native__this, IntPtr native_data, IntPtr native_menu, int deviceId)
		{
			Activity @object = Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IList<KeyboardShortcutGroup> data = JavaList<KeyboardShortcutGroup>.FromJniHandle(native_data, JniHandleOwnership.DoNotTransfer);
			IMenu object2 = Java.Lang.Object.GetObject<IMenu>(native_menu, JniHandleOwnership.DoNotTransfer);
			@object.OnProvideKeyboardShortcuts(data, object2, deviceId);
		}

		// Token: 0x06001642 RID: 5698 RVA: 0x0003926C File Offset: 0x0003746C
		public unsafe virtual void OnProvideKeyboardShortcuts(IList<KeyboardShortcutGroup> data, IMenu menu, int deviceId)
		{
			IntPtr intPtr = JavaList<KeyboardShortcutGroup>.ToLocalJniHandle(data);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((menu == null) ? IntPtr.Zero : ((Java.Lang.Object)menu).Handle);
				ptr[2] = new JniArgumentValue(deviceId);
				Activity._members.InstanceMethods.InvokeVirtualVoidMethod("onProvideKeyboardShortcuts.(Ljava/util/List;Landroid/view/Menu;I)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(data);
				GC.KeepAlive(menu);
			}
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x00039310 File Offset: 0x00037510
		private static Delegate GetOnRequestPermissionsResult_IarrayLjava_lang_String_arrayIHandler()
		{
			if (Activity.cb_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI == null)
			{
				Activity.cb_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPILL_V(Activity.n_OnRequestPermissionsResult_IarrayLjava_lang_String_arrayI));
			}
			return Activity.cb_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI;
		}

		// Token: 0x06001644 RID: 5700 RVA: 0x00039334 File Offset: 0x00037534
		private static void n_OnRequestPermissionsResult_IarrayLjava_lang_String_arrayI(IntPtr jnienv, IntPtr native__this, int requestCode, IntPtr native_permissions, IntPtr native_grantResults)
		{
			Activity @object = Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] array = (string[])JNIEnv.GetArray(native_permissions, JniHandleOwnership.DoNotTransfer, typeof(string));
			Permission[] array2 = (Permission[])JNIEnv.GetArray(native_grantResults, JniHandleOwnership.DoNotTransfer, typeof(Permission));
			@object.OnRequestPermissionsResult(requestCode, array, array2);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_permissions);
			}
			if (array2 != null)
			{
				JNIEnv.CopyArray<Permission>(array2, native_grantResults);
			}
		}

		// Token: 0x06001645 RID: 5701 RVA: 0x00039398 File Offset: 0x00037598
		public unsafe virtual void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Permission[] grantResults)
		{
			IntPtr intPtr = JNIEnv.NewArray(permissions);
			IntPtr intPtr2 = JNIEnv.NewArray<Permission>(grantResults);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(requestCode);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(intPtr2);
				Activity._members.InstanceMethods.InvokeVirtualVoidMethod("onRequestPermissionsResult.(I[Ljava/lang/String;[I)V", this, ptr);
			}
			finally
			{
				if (permissions != null)
				{
					JNIEnv.CopyArray(intPtr, permissions);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				if (grantResults != null)
				{
					JNIEnv.CopyArray<Permission>(intPtr2, grantResults);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(permissions);
				GC.KeepAlive(grantResults);
			}
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x0003944C File Offset: 0x0003764C
		private static Delegate GetOnResumeHandler()
		{
			if (Activity.cb_onResume == null)
			{
				Activity.cb_onResume = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Activity.n_OnResume));
			}
			return Activity.cb_onResume;
		}

		// Token: 0x06001647 RID: 5703 RVA: 0x00039470 File Offset: 0x00037670
		private static void n_OnResume(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnResume();
		}

		// Token: 0x06001648 RID: 5704 RVA: 0x0003947F File Offset: 0x0003767F
		protected virtual void OnResume()
		{
			Activity._members.InstanceMethods.InvokeVirtualVoidMethod("onResume.()V", this, null);
		}

		// Token: 0x06001649 RID: 5705 RVA: 0x00039498 File Offset: 0x00037698
		private static Delegate GetOnRetainNonConfigurationInstanceHandler()
		{
			if (Activity.cb_onRetainNonConfigurationInstance == null)
			{
				Activity.cb_onRetainNonConfigurationInstance = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Activity.n_OnRetainNonConfigurationInstance));
			}
			return Activity.cb_onRetainNonConfigurationInstance;
		}

		// Token: 0x0600164A RID: 5706 RVA: 0x000394BC File Offset: 0x000376BC
		private static IntPtr n_OnRetainNonConfigurationInstance(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnRetainNonConfigurationInstance());
		}

		// Token: 0x0600164B RID: 5707 RVA: 0x000394D0 File Offset: 0x000376D0
		public virtual Java.Lang.Object OnRetainNonConfigurationInstance()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(Activity._members.InstanceMethods.InvokeVirtualObjectMethod("onRetainNonConfigurationInstance.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600164C RID: 5708 RVA: 0x00039502 File Offset: 0x00037702
		private static Delegate GetOnSaveInstanceState_Landroid_os_Bundle_Handler()
		{
			if (Activity.cb_onSaveInstanceState_Landroid_os_Bundle_ == null)
			{
				Activity.cb_onSaveInstanceState_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Activity.n_OnSaveInstanceState_Landroid_os_Bundle_));
			}
			return Activity.cb_onSaveInstanceState_Landroid_os_Bundle_;
		}

		// Token: 0x0600164D RID: 5709 RVA: 0x00039528 File Offset: 0x00037728
		private static void n_OnSaveInstanceState_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_outState)
		{
			Activity @object = Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_outState, JniHandleOwnership.DoNotTransfer);
			@object.OnSaveInstanceState(object2);
		}

		// Token: 0x0600164E RID: 5710 RVA: 0x0003954C File Offset: 0x0003774C
		protected unsafe virtual void OnSaveInstanceState(Bundle outState)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((outState == null) ? IntPtr.Zero : outState.Handle);
				Activity._members.InstanceMethods.InvokeVirtualVoidMethod("onSaveInstanceState.(Landroid/os/Bundle;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(outState);
			}
		}

		// Token: 0x0600164F RID: 5711 RVA: 0x000395B0 File Offset: 0x000377B0
		private static Delegate GetOnSearchRequestedHandler()
		{
			if (Activity.cb_onSearchRequested == null)
			{
				Activity.cb_onSearchRequested = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(Activity.n_OnSearchRequested));
			}
			return Activity.cb_onSearchRequested;
		}

		// Token: 0x06001650 RID: 5712 RVA: 0x000395D4 File Offset: 0x000377D4
		private static bool n_OnSearchRequested(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnSearchRequested();
		}

		// Token: 0x06001651 RID: 5713 RVA: 0x000395E3 File Offset: 0x000377E3
		public virtual bool OnSearchRequested()
		{
			return Activity._members.InstanceMethods.InvokeVirtualBooleanMethod("onSearchRequested.()Z", this, null);
		}

		// Token: 0x06001652 RID: 5714 RVA: 0x000395FC File Offset: 0x000377FC
		private static Delegate GetOnSearchRequested_Landroid_view_SearchEvent_Handler()
		{
			if (Activity.cb_onSearchRequested_Landroid_view_SearchEvent_ == null)
			{
				Activity.cb_onSearchRequested_Landroid_view_SearchEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(Activity.n_OnSearchRequested_Landroid_view_SearchEvent_));
			}
			return Activity.cb_onSearchRequested_Landroid_view_SearchEvent_;
		}

		// Token: 0x06001653 RID: 5715 RVA: 0x00039620 File Offset: 0x00037820
		private static bool n_OnSearchRequested_Landroid_view_SearchEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_searchEvent)
		{
			Activity @object = Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			SearchEvent object2 = Java.Lang.Object.GetObject<SearchEvent>(native_searchEvent, JniHandleOwnership.DoNotTransfer);
			return @object.OnSearchRequested(object2);
		}

		// Token: 0x06001654 RID: 5716 RVA: 0x00039644 File Offset: 0x00037844
		public unsafe virtual bool OnSearchRequested(SearchEvent searchEvent)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((searchEvent == null) ? IntPtr.Zero : searchEvent.Handle);
				result = Activity._members.InstanceMethods.InvokeVirtualBooleanMethod("onSearchRequested.(Landroid/view/SearchEvent;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(searchEvent);
			}
			return result;
		}

		// Token: 0x06001655 RID: 5717 RVA: 0x000396AC File Offset: 0x000378AC
		private static Delegate GetOnTrimMemory_IHandler()
		{
			if (Activity.cb_onTrimMemory_I == null)
			{
				Activity.cb_onTrimMemory_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(Activity.n_OnTrimMemory_I));
			}
			return Activity.cb_onTrimMemory_I;
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x000396D0 File Offset: 0x000378D0
		private static void n_OnTrimMemory_I(IntPtr jnienv, IntPtr native__this, int native_level)
		{
			Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnTrimMemory((TrimMemory)native_level);
		}

		// Token: 0x06001657 RID: 5719 RVA: 0x000396F0 File Offset: 0x000378F0
		public unsafe virtual void OnTrimMemory([GeneratedEnum] TrimMemory level)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((int)level);
			Activity._members.InstanceMethods.InvokeVirtualVoidMethod("onTrimMemory.(I)V", this, ptr);
		}

		// Token: 0x06001658 RID: 5720 RVA: 0x0003972B File Offset: 0x0003792B
		private static Delegate GetOnWindowAttributesChanged_Landroid_view_WindowManager_LayoutParams_Handler()
		{
			if (Activity.cb_onWindowAttributesChanged_Landroid_view_WindowManager_LayoutParams_ == null)
			{
				Activity.cb_onWindowAttributesChanged_Landroid_view_WindowManager_LayoutParams_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Activity.n_OnWindowAttributesChanged_Landroid_view_WindowManager_LayoutParams_));
			}
			return Activity.cb_onWindowAttributesChanged_Landroid_view_WindowManager_LayoutParams_;
		}

		// Token: 0x06001659 RID: 5721 RVA: 0x00039750 File Offset: 0x00037950
		private static void n_OnWindowAttributesChanged_Landroid_view_WindowManager_LayoutParams_(IntPtr jnienv, IntPtr native__this, IntPtr native__params)
		{
			Activity @object = Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			WindowManagerLayoutParams object2 = Java.Lang.Object.GetObject<WindowManagerLayoutParams>(native__params, JniHandleOwnership.DoNotTransfer);
			@object.OnWindowAttributesChanged(object2);
		}

		// Token: 0x0600165A RID: 5722 RVA: 0x00039774 File Offset: 0x00037974
		public unsafe virtual void OnWindowAttributesChanged(WindowManagerLayoutParams @params)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((@params == null) ? IntPtr.Zero : @params.Handle);
				Activity._members.InstanceMethods.InvokeVirtualVoidMethod("onWindowAttributesChanged.(Landroid/view/WindowManager$LayoutParams;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(@params);
			}
		}

		// Token: 0x0600165B RID: 5723 RVA: 0x000397D8 File Offset: 0x000379D8
		private static Delegate GetOnWindowFocusChanged_ZHandler()
		{
			if (Activity.cb_onWindowFocusChanged_Z == null)
			{
				Activity.cb_onWindowFocusChanged_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(Activity.n_OnWindowFocusChanged_Z));
			}
			return Activity.cb_onWindowFocusChanged_Z;
		}

		// Token: 0x0600165C RID: 5724 RVA: 0x000397FC File Offset: 0x000379FC
		private static void n_OnWindowFocusChanged_Z(IntPtr jnienv, IntPtr native__this, bool hasFocus)
		{
			Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnWindowFocusChanged(hasFocus);
		}

		// Token: 0x0600165D RID: 5725 RVA: 0x0003980C File Offset: 0x00037A0C
		public unsafe virtual void OnWindowFocusChanged(bool hasFocus)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(hasFocus);
			Activity._members.InstanceMethods.InvokeVirtualVoidMethod("onWindowFocusChanged.(Z)V", this, ptr);
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x00039847 File Offset: 0x00037A47
		private static Delegate GetOnWindowStartingActionMode_Landroid_view_ActionMode_Callback_Handler()
		{
			if (Activity.cb_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_ == null)
			{
				Activity.cb_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(Activity.n_OnWindowStartingActionMode_Landroid_view_ActionMode_Callback_));
			}
			return Activity.cb_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_;
		}

		// Token: 0x0600165F RID: 5727 RVA: 0x0003986C File Offset: 0x00037A6C
		private static IntPtr n_OnWindowStartingActionMode_Landroid_view_ActionMode_Callback_(IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			Activity @object = Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ActionMode.ICallback object2 = Java.Lang.Object.GetObject<ActionMode.ICallback>(native__callback, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.OnWindowStartingActionMode(object2));
		}

		// Token: 0x06001660 RID: 5728 RVA: 0x00039894 File Offset: 0x00037A94
		public unsafe virtual ActionMode OnWindowStartingActionMode(ActionMode.ICallback callback)
		{
			ActionMode @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : ((Java.Lang.Object)callback).Handle);
				@object = Java.Lang.Object.GetObject<ActionMode>(Activity._members.InstanceMethods.InvokeVirtualObjectMethod("onWindowStartingActionMode.(Landroid/view/ActionMode$Callback;)Landroid/view/ActionMode;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
			return @object;
		}

		// Token: 0x06001661 RID: 5729 RVA: 0x0003990C File Offset: 0x00037B0C
		private static Delegate GetOnWindowStartingActionMode_Landroid_view_ActionMode_Callback_IHandler()
		{
			if (Activity.cb_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_I == null)
			{
				Activity.cb_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_L(Activity.n_OnWindowStartingActionMode_Landroid_view_ActionMode_Callback_I));
			}
			return Activity.cb_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_I;
		}

		// Token: 0x06001662 RID: 5730 RVA: 0x00039930 File Offset: 0x00037B30
		private static IntPtr n_OnWindowStartingActionMode_Landroid_view_ActionMode_Callback_I(IntPtr jnienv, IntPtr native__this, IntPtr native__callback, int native_type)
		{
			Activity @object = Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ActionMode.ICallback object2 = Java.Lang.Object.GetObject<ActionMode.ICallback>(native__callback, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.OnWindowStartingActionMode(object2, (ActionModeType)native_type));
		}

		// Token: 0x06001663 RID: 5731 RVA: 0x0003995C File Offset: 0x00037B5C
		public unsafe virtual ActionMode OnWindowStartingActionMode(ActionMode.ICallback callback, [GeneratedEnum] ActionModeType type)
		{
			ActionMode @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : ((Java.Lang.Object)callback).Handle);
				ptr[1] = new JniArgumentValue((int)type);
				@object = Java.Lang.Object.GetObject<ActionMode>(Activity._members.InstanceMethods.InvokeVirtualObjectMethod("onWindowStartingActionMode.(Landroid/view/ActionMode$Callback;I)Landroid/view/ActionMode;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
			return @object;
		}

		// Token: 0x06001664 RID: 5732 RVA: 0x000399E8 File Offset: 0x00037BE8
		private static Delegate GetOverridePendingTransition_IIHandler()
		{
			if (Activity.cb_overridePendingTransition_II == null)
			{
				Activity.cb_overridePendingTransition_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_V(Activity.n_OverridePendingTransition_II));
			}
			return Activity.cb_overridePendingTransition_II;
		}

		// Token: 0x06001665 RID: 5733 RVA: 0x00039A0C File Offset: 0x00037C0C
		private static void n_OverridePendingTransition_II(IntPtr jnienv, IntPtr native__this, int enterAnim, int exitAnim)
		{
			Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OverridePendingTransition(enterAnim, exitAnim);
		}

		// Token: 0x06001666 RID: 5734 RVA: 0x00039A20 File Offset: 0x00037C20
		public unsafe virtual void OverridePendingTransition(int enterAnim, int exitAnim)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(enterAnim);
			ptr[1] = new JniArgumentValue(exitAnim);
			Activity._members.InstanceMethods.InvokeVirtualVoidMethod("overridePendingTransition.(II)V", this, ptr);
		}

		// Token: 0x06001667 RID: 5735 RVA: 0x00039A6E File Offset: 0x00037C6E
		private static Delegate GetRecreateHandler()
		{
			if (Activity.cb_recreate == null)
			{
				Activity.cb_recreate = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Activity.n_Recreate));
			}
			return Activity.cb_recreate;
		}

		// Token: 0x06001668 RID: 5736 RVA: 0x00039A92 File Offset: 0x00037C92
		private static void n_Recreate(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Recreate();
		}

		// Token: 0x06001669 RID: 5737 RVA: 0x00039AA1 File Offset: 0x00037CA1
		public virtual void Recreate()
		{
			Activity._members.InstanceMethods.InvokeVirtualVoidMethod("recreate.()V", this, null);
		}

		// Token: 0x0600166A RID: 5738 RVA: 0x00039ABC File Offset: 0x00037CBC
		public unsafe void RequestPermissions(string[] permissions, int requestCode)
		{
			IntPtr intPtr = JNIEnv.NewArray(permissions);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(requestCode);
				Activity._members.InstanceMethods.InvokeNonvirtualVoidMethod("requestPermissions.([Ljava/lang/String;I)V", this, ptr);
			}
			finally
			{
				if (permissions != null)
				{
					JNIEnv.CopyArray(intPtr, permissions);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(permissions);
			}
		}

		// Token: 0x0600166B RID: 5739 RVA: 0x00039B3C File Offset: 0x00037D3C
		public unsafe void RunOnUiThread(IRunnable action)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				Activity._members.InstanceMethods.InvokeNonvirtualVoidMethod("runOnUiThread.(Ljava/lang/Runnable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(action);
			}
		}

		// Token: 0x0600166C RID: 5740 RVA: 0x00039BA4 File Offset: 0x00037DA4
		private static Delegate GetSetContentView_IHandler()
		{
			if (Activity.cb_setContentView_I == null)
			{
				Activity.cb_setContentView_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(Activity.n_SetContentView_I));
			}
			return Activity.cb_setContentView_I;
		}

		// Token: 0x0600166D RID: 5741 RVA: 0x00039BC8 File Offset: 0x00037DC8
		private static void n_SetContentView_I(IntPtr jnienv, IntPtr native__this, int layoutResID)
		{
			Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetContentView(layoutResID);
		}

		// Token: 0x0600166E RID: 5742 RVA: 0x00039BD8 File Offset: 0x00037DD8
		public unsafe virtual void SetContentView(int layoutResID)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(layoutResID);
			Activity._members.InstanceMethods.InvokeVirtualVoidMethod("setContentView.(I)V", this, ptr);
		}

		// Token: 0x0600166F RID: 5743 RVA: 0x00039C14 File Offset: 0x00037E14
		public unsafe void SetResult([GeneratedEnum] Result resultCode, Intent data)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((int)resultCode);
				ptr[1] = new JniArgumentValue((data == null) ? IntPtr.Zero : data.Handle);
				Activity._members.InstanceMethods.InvokeNonvirtualVoidMethod("setResult.(ILandroid/content/Intent;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(data);
			}
		}

		// Token: 0x06001670 RID: 5744 RVA: 0x00039C8C File Offset: 0x00037E8C
		private static Delegate GetStartActivityForResult_Landroid_content_Intent_IHandler()
		{
			if (Activity.cb_startActivityForResult_Landroid_content_Intent_I == null)
			{
				Activity.cb_startActivityForResult_Landroid_content_Intent_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(Activity.n_StartActivityForResult_Landroid_content_Intent_I));
			}
			return Activity.cb_startActivityForResult_Landroid_content_Intent_I;
		}

		// Token: 0x06001671 RID: 5745 RVA: 0x00039CB0 File Offset: 0x00037EB0
		private static void n_StartActivityForResult_Landroid_content_Intent_I(IntPtr jnienv, IntPtr native__this, IntPtr native_intent, int requestCode)
		{
			Activity @object = Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Intent object2 = Java.Lang.Object.GetObject<Intent>(native_intent, JniHandleOwnership.DoNotTransfer);
			@object.StartActivityForResult(object2, requestCode);
		}

		// Token: 0x06001672 RID: 5746 RVA: 0x00039CD4 File Offset: 0x00037ED4
		public unsafe virtual void StartActivityForResult(Intent intent, int requestCode)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((intent == null) ? IntPtr.Zero : intent.Handle);
				ptr[1] = new JniArgumentValue(requestCode);
				Activity._members.InstanceMethods.InvokeVirtualVoidMethod("startActivityForResult.(Landroid/content/Intent;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(intent);
			}
		}

		// Token: 0x06001673 RID: 5747 RVA: 0x00039D4C File Offset: 0x00037F4C
		private static Delegate GetStartActivityForResult_Landroid_content_Intent_ILandroid_os_Bundle_Handler()
		{
			if (Activity.cb_startActivityForResult_Landroid_content_Intent_ILandroid_os_Bundle_ == null)
			{
				Activity.cb_startActivityForResult_Landroid_content_Intent_ILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIL_V(Activity.n_StartActivityForResult_Landroid_content_Intent_ILandroid_os_Bundle_));
			}
			return Activity.cb_startActivityForResult_Landroid_content_Intent_ILandroid_os_Bundle_;
		}

		// Token: 0x06001674 RID: 5748 RVA: 0x00039D70 File Offset: 0x00037F70
		private static void n_StartActivityForResult_Landroid_content_Intent_ILandroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_intent, int requestCode, IntPtr native_options)
		{
			Activity @object = Java.Lang.Object.GetObject<Activity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Intent object2 = Java.Lang.Object.GetObject<Intent>(native_intent, JniHandleOwnership.DoNotTransfer);
			Bundle object3 = Java.Lang.Object.GetObject<Bundle>(native_options, JniHandleOwnership.DoNotTransfer);
			@object.StartActivityForResult(object2, requestCode, object3);
		}

		// Token: 0x06001675 RID: 5749 RVA: 0x00039DA0 File Offset: 0x00037FA0
		public unsafe virtual void StartActivityForResult(Intent intent, int requestCode, Bundle options)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((intent == null) ? IntPtr.Zero : intent.Handle);
				ptr[1] = new JniArgumentValue(requestCode);
				ptr[2] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				Activity._members.InstanceMethods.InvokeVirtualVoidMethod("startActivityForResult.(Landroid/content/Intent;ILandroid/os/Bundle;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(intent);
				GC.KeepAlive(options);
			}
		}

		// Token: 0x06001676 RID: 5750 RVA: 0x00039E44 File Offset: 0x00038044
		public T FindViewById<T>(int id) where T : View
		{
			return this.FindViewById(id).JavaCast<T>();
		}

		// Token: 0x06001677 RID: 5751 RVA: 0x00039E52 File Offset: 0x00038052
		public void RunOnUiThread(System.Action action)
		{
			this.RunOnUiThread(new Thread.RunnableImplementor(action));
		}

		// Token: 0x04000979 RID: 2425
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/app/Activity", typeof(Activity));

		// Token: 0x0400097A RID: 2426
		private static Delegate cb_getCurrentFocus;

		// Token: 0x0400097B RID: 2427
		private static Delegate cb_getIntent;

		// Token: 0x0400097C RID: 2428
		private static Delegate cb_getMenuInflater;

		// Token: 0x0400097D RID: 2429
		private static Delegate cb_setRequestedOrientation_I;

		// Token: 0x0400097E RID: 2430
		private static Delegate cb_getWindow;

		// Token: 0x0400097F RID: 2431
		private static Delegate cb_dispatchGenericMotionEvent_Landroid_view_MotionEvent_;

		// Token: 0x04000980 RID: 2432
		private static Delegate cb_dispatchKeyEvent_Landroid_view_KeyEvent_;

		// Token: 0x04000981 RID: 2433
		private static Delegate cb_dispatchKeyShortcutEvent_Landroid_view_KeyEvent_;

		// Token: 0x04000982 RID: 2434
		private static Delegate cb_dispatchPopulateAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_;

		// Token: 0x04000983 RID: 2435
		private static Delegate cb_dispatchTouchEvent_Landroid_view_MotionEvent_;

		// Token: 0x04000984 RID: 2436
		private static Delegate cb_dispatchTrackballEvent_Landroid_view_MotionEvent_;

		// Token: 0x04000985 RID: 2437
		private static Delegate cb_findViewById_I;

		// Token: 0x04000986 RID: 2438
		private static Delegate cb_finish;

		// Token: 0x04000987 RID: 2439
		private static Delegate cb_onActionModeFinished_Landroid_view_ActionMode_;

		// Token: 0x04000988 RID: 2440
		private static Delegate cb_onActionModeStarted_Landroid_view_ActionMode_;

		// Token: 0x04000989 RID: 2441
		private static Delegate cb_onActivityResult_IILandroid_content_Intent_;

		// Token: 0x0400098A RID: 2442
		private static Delegate cb_onAttachedToWindow;

		// Token: 0x0400098B RID: 2443
		private static Delegate cb_onBackPressed;

		// Token: 0x0400098C RID: 2444
		private static Delegate cb_onConfigurationChanged_Landroid_content_res_Configuration_;

		// Token: 0x0400098D RID: 2445
		private static Delegate cb_onContentChanged;

		// Token: 0x0400098E RID: 2446
		private static Delegate cb_onCreate_Landroid_os_Bundle_;

		// Token: 0x0400098F RID: 2447
		private static Delegate cb_onCreate_Landroid_os_Bundle_Landroid_os_PersistableBundle_;

		// Token: 0x04000990 RID: 2448
		private static Delegate cb_onCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_;

		// Token: 0x04000991 RID: 2449
		private static Delegate cb_onCreateOptionsMenu_Landroid_view_Menu_;

		// Token: 0x04000992 RID: 2450
		private static Delegate cb_onCreatePanelMenu_ILandroid_view_Menu_;

		// Token: 0x04000993 RID: 2451
		private static Delegate cb_onCreatePanelView_I;

		// Token: 0x04000994 RID: 2452
		private static Delegate cb_onCreateView_Landroid_view_View_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_;

		// Token: 0x04000995 RID: 2453
		private static Delegate cb_onCreateView_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_;

		// Token: 0x04000996 RID: 2454
		private static Delegate cb_onDetachedFromWindow;

		// Token: 0x04000997 RID: 2455
		private static Delegate cb_onKeyDown_ILandroid_view_KeyEvent_;

		// Token: 0x04000998 RID: 2456
		private static Delegate cb_onKeyLongPress_ILandroid_view_KeyEvent_;

		// Token: 0x04000999 RID: 2457
		private static Delegate cb_onKeyMultiple_IILandroid_view_KeyEvent_;

		// Token: 0x0400099A RID: 2458
		private static Delegate cb_onKeyUp_ILandroid_view_KeyEvent_;

		// Token: 0x0400099B RID: 2459
		private static Delegate cb_onLowMemory;

		// Token: 0x0400099C RID: 2460
		private static Delegate cb_onMenuItemSelected_ILandroid_view_MenuItem_;

		// Token: 0x0400099D RID: 2461
		private static Delegate cb_onMenuOpened_ILandroid_view_Menu_;

		// Token: 0x0400099E RID: 2462
		private static Delegate cb_onOptionsItemSelected_Landroid_view_MenuItem_;

		// Token: 0x0400099F RID: 2463
		private static Delegate cb_onPanelClosed_ILandroid_view_Menu_;

		// Token: 0x040009A0 RID: 2464
		private static Delegate cb_onPause;

		// Token: 0x040009A1 RID: 2465
		private static Delegate cb_onPreparePanel_ILandroid_view_View_Landroid_view_Menu_;

		// Token: 0x040009A2 RID: 2466
		private static Delegate cb_onProvideKeyboardShortcuts_Ljava_util_List_Landroid_view_Menu_I;

		// Token: 0x040009A3 RID: 2467
		private static Delegate cb_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI;

		// Token: 0x040009A4 RID: 2468
		private static Delegate cb_onResume;

		// Token: 0x040009A5 RID: 2469
		private static Delegate cb_onRetainNonConfigurationInstance;

		// Token: 0x040009A6 RID: 2470
		private static Delegate cb_onSaveInstanceState_Landroid_os_Bundle_;

		// Token: 0x040009A7 RID: 2471
		private static Delegate cb_onSearchRequested;

		// Token: 0x040009A8 RID: 2472
		private static Delegate cb_onSearchRequested_Landroid_view_SearchEvent_;

		// Token: 0x040009A9 RID: 2473
		private static Delegate cb_onTrimMemory_I;

		// Token: 0x040009AA RID: 2474
		private static Delegate cb_onWindowAttributesChanged_Landroid_view_WindowManager_LayoutParams_;

		// Token: 0x040009AB RID: 2475
		private static Delegate cb_onWindowFocusChanged_Z;

		// Token: 0x040009AC RID: 2476
		private static Delegate cb_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_;

		// Token: 0x040009AD RID: 2477
		private static Delegate cb_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_I;

		// Token: 0x040009AE RID: 2478
		private static Delegate cb_overridePendingTransition_II;

		// Token: 0x040009AF RID: 2479
		private static Delegate cb_recreate;

		// Token: 0x040009B0 RID: 2480
		private static Delegate cb_setContentView_I;

		// Token: 0x040009B1 RID: 2481
		private static Delegate cb_startActivityForResult_Landroid_content_Intent_I;

		// Token: 0x040009B2 RID: 2482
		private static Delegate cb_startActivityForResult_Landroid_content_Intent_ILandroid_os_Bundle_;
	}
}
