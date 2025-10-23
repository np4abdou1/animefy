using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Views.Accessibility;
using Java.Interop;
using Java.Lang;

namespace Android.Views
{
	// Token: 0x02000168 RID: 360
	[Register("android/view/Window", DoNotGenerateAcw = true)]
	public abstract class Window : Java.Lang.Object
	{
		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000CE7 RID: 3303 RVA: 0x00021373 File Offset: 0x0001F573
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Window._members;
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000CE8 RID: 3304 RVA: 0x0002137C File Offset: 0x0001F57C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Window._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000CE9 RID: 3305 RVA: 0x000213A0 File Offset: 0x0001F5A0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Window._members.ManagedPeerType;
			}
		}

		// Token: 0x06000CEA RID: 3306 RVA: 0x000021E0 File Offset: 0x000003E0
		protected Window(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000CEB RID: 3307 RVA: 0x000213AC File Offset: 0x0001F5AC
		public WindowManagerLayoutParams Attributes
		{
			get
			{
				return Java.Lang.Object.GetObject<WindowManagerLayoutParams>(Window._members.InstanceMethods.InvokeNonvirtualObjectMethod("getAttributes.()Landroid/view/WindowManager$LayoutParams;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x000213DE File Offset: 0x0001F5DE
		private static Delegate GetGetDecorViewHandler()
		{
			if (Window.cb_getDecorView == null)
			{
				Window.cb_getDecorView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Window.n_GetDecorView));
			}
			return Window.cb_getDecorView;
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x00021402 File Offset: 0x0001F602
		private static IntPtr n_GetDecorView(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Window>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DecorView);
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000CEE RID: 3310
		public abstract View DecorView { get; }

		// Token: 0x06000CEF RID: 3311 RVA: 0x00021416 File Offset: 0x0001F616
		private static Delegate GetSetBackgroundDrawableResource_IHandler()
		{
			if (Window.cb_setBackgroundDrawableResource_I == null)
			{
				Window.cb_setBackgroundDrawableResource_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(Window.n_SetBackgroundDrawableResource_I));
			}
			return Window.cb_setBackgroundDrawableResource_I;
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x0002143A File Offset: 0x0001F63A
		private static void n_SetBackgroundDrawableResource_I(IntPtr jnienv, IntPtr native__this, int resId)
		{
			Java.Lang.Object.GetObject<Window>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetBackgroundDrawableResource(resId);
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x0002144C File Offset: 0x0001F64C
		public unsafe virtual void SetBackgroundDrawableResource(int resId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resId);
			Window._members.InstanceMethods.InvokeVirtualVoidMethod("setBackgroundDrawableResource.(I)V", this, ptr);
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x00021487 File Offset: 0x0001F687
		private static Delegate GetSetSoftInputMode_IHandler()
		{
			if (Window.cb_setSoftInputMode_I == null)
			{
				Window.cb_setSoftInputMode_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(Window.n_SetSoftInputMode_I));
			}
			return Window.cb_setSoftInputMode_I;
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x000214AC File Offset: 0x0001F6AC
		private static void n_SetSoftInputMode_I(IntPtr jnienv, IntPtr native__this, int native_mode)
		{
			Java.Lang.Object.GetObject<Window>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetSoftInputMode((SoftInput)native_mode);
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x000214CC File Offset: 0x0001F6CC
		public unsafe virtual void SetSoftInputMode([GeneratedEnum] SoftInput mode)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((int)mode);
			Window._members.InstanceMethods.InvokeVirtualVoidMethod("setSoftInputMode.(I)V", this, ptr);
		}

		// Token: 0x04000436 RID: 1078
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/Window", typeof(Window));

		// Token: 0x04000437 RID: 1079
		private static Delegate cb_getDecorView;

		// Token: 0x04000438 RID: 1080
		private static Delegate cb_setBackgroundDrawableResource_I;

		// Token: 0x04000439 RID: 1081
		private static Delegate cb_setSoftInputMode_I;

		// Token: 0x02000169 RID: 361
		[Register("android/view/Window$Callback", "", "Android.Views.Window/ICallbackInvoker")]
		public interface ICallback : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000CF6 RID: 3318
			[Register("dispatchGenericMotionEvent", "(Landroid/view/MotionEvent;)Z", "GetDispatchGenericMotionEvent_Landroid_view_MotionEvent_Handler:Android.Views.Window/ICallbackInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			bool DispatchGenericMotionEvent(MotionEvent e);

			// Token: 0x06000CF7 RID: 3319
			[Register("dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", "GetDispatchKeyEvent_Landroid_view_KeyEvent_Handler:Android.Views.Window/ICallbackInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			bool DispatchKeyEvent(KeyEvent e);

			// Token: 0x06000CF8 RID: 3320
			[Register("dispatchKeyShortcutEvent", "(Landroid/view/KeyEvent;)Z", "GetDispatchKeyShortcutEvent_Landroid_view_KeyEvent_Handler:Android.Views.Window/ICallbackInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			bool DispatchKeyShortcutEvent(KeyEvent e);

			// Token: 0x06000CF9 RID: 3321
			[Register("dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z", "GetDispatchPopulateAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_Handler:Android.Views.Window/ICallbackInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			bool DispatchPopulateAccessibilityEvent(AccessibilityEvent e);

			// Token: 0x06000CFA RID: 3322
			[Register("dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z", "GetDispatchTouchEvent_Landroid_view_MotionEvent_Handler:Android.Views.Window/ICallbackInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			bool DispatchTouchEvent(MotionEvent e);

			// Token: 0x06000CFB RID: 3323
			[Register("dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z", "GetDispatchTrackballEvent_Landroid_view_MotionEvent_Handler:Android.Views.Window/ICallbackInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			bool DispatchTrackballEvent(MotionEvent e);

			// Token: 0x06000CFC RID: 3324
			[Register("onActionModeFinished", "(Landroid/view/ActionMode;)V", "GetOnActionModeFinished_Landroid_view_ActionMode_Handler:Android.Views.Window/ICallbackInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			void OnActionModeFinished(ActionMode mode);

			// Token: 0x06000CFD RID: 3325
			[Register("onActionModeStarted", "(Landroid/view/ActionMode;)V", "GetOnActionModeStarted_Landroid_view_ActionMode_Handler:Android.Views.Window/ICallbackInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			void OnActionModeStarted(ActionMode mode);

			// Token: 0x06000CFE RID: 3326
			[Register("onAttachedToWindow", "()V", "GetOnAttachedToWindowHandler:Android.Views.Window/ICallbackInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			void OnAttachedToWindow();

			// Token: 0x06000CFF RID: 3327
			[Register("onContentChanged", "()V", "GetOnContentChangedHandler:Android.Views.Window/ICallbackInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			void OnContentChanged();

			// Token: 0x06000D00 RID: 3328
			[Register("onCreatePanelMenu", "(ILandroid/view/Menu;)Z", "GetOnCreatePanelMenu_ILandroid_view_Menu_Handler:Android.Views.Window/ICallbackInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			bool OnCreatePanelMenu(int featureId, IMenu menu);

			// Token: 0x06000D01 RID: 3329
			[Register("onCreatePanelView", "(I)Landroid/view/View;", "GetOnCreatePanelView_IHandler:Android.Views.Window/ICallbackInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			View OnCreatePanelView(int featureId);

			// Token: 0x06000D02 RID: 3330
			[Register("onDetachedFromWindow", "()V", "GetOnDetachedFromWindowHandler:Android.Views.Window/ICallbackInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			void OnDetachedFromWindow();

			// Token: 0x06000D03 RID: 3331
			[Register("onMenuItemSelected", "(ILandroid/view/MenuItem;)Z", "GetOnMenuItemSelected_ILandroid_view_MenuItem_Handler:Android.Views.Window/ICallbackInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			bool OnMenuItemSelected(int featureId, IMenuItem item);

			// Token: 0x06000D04 RID: 3332
			[Register("onMenuOpened", "(ILandroid/view/Menu;)Z", "GetOnMenuOpened_ILandroid_view_Menu_Handler:Android.Views.Window/ICallbackInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			bool OnMenuOpened(int featureId, IMenu menu);

			// Token: 0x06000D05 RID: 3333
			[Register("onPanelClosed", "(ILandroid/view/Menu;)V", "GetOnPanelClosed_ILandroid_view_Menu_Handler:Android.Views.Window/ICallbackInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			void OnPanelClosed(int featureId, IMenu menu);

			// Token: 0x06000D06 RID: 3334
			[Register("onPreparePanel", "(ILandroid/view/View;Landroid/view/Menu;)Z", "GetOnPreparePanel_ILandroid_view_View_Landroid_view_Menu_Handler:Android.Views.Window/ICallbackInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			bool OnPreparePanel(int featureId, View view, IMenu menu);

			// Token: 0x06000D07 RID: 3335
			[Register("onSearchRequested", "()Z", "GetOnSearchRequestedHandler:Android.Views.Window/ICallbackInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			bool OnSearchRequested();

			// Token: 0x06000D08 RID: 3336
			[Register("onSearchRequested", "(Landroid/view/SearchEvent;)Z", "GetOnSearchRequested_Landroid_view_SearchEvent_Handler:Android.Views.Window/ICallbackInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", ApiSince = 23)]
			bool OnSearchRequested(SearchEvent searchEvent);

			// Token: 0x06000D09 RID: 3337
			[Register("onWindowAttributesChanged", "(Landroid/view/WindowManager$LayoutParams;)V", "GetOnWindowAttributesChanged_Landroid_view_WindowManager_LayoutParams_Handler:Android.Views.Window/ICallbackInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			void OnWindowAttributesChanged(WindowManagerLayoutParams attrs);

			// Token: 0x06000D0A RID: 3338
			[Register("onWindowFocusChanged", "(Z)V", "GetOnWindowFocusChanged_ZHandler:Android.Views.Window/ICallbackInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			void OnWindowFocusChanged(bool hasFocus);

			// Token: 0x06000D0B RID: 3339
			[Register("onWindowStartingActionMode", "(Landroid/view/ActionMode$Callback;)Landroid/view/ActionMode;", "GetOnWindowStartingActionMode_Landroid_view_ActionMode_Callback_Handler:Android.Views.Window/ICallbackInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			ActionMode OnWindowStartingActionMode(ActionMode.ICallback callback);

			// Token: 0x06000D0C RID: 3340
			[Register("onWindowStartingActionMode", "(Landroid/view/ActionMode$Callback;I)Landroid/view/ActionMode;", "GetOnWindowStartingActionMode_Landroid_view_ActionMode_Callback_IHandler:Android.Views.Window/ICallbackInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", ApiSince = 23)]
			ActionMode OnWindowStartingActionMode(ActionMode.ICallback callback, [GeneratedEnum] ActionModeType type);

			// Token: 0x06000D0D RID: 3341 RVA: 0x00021522 File Offset: 0x0001F722
			private static Delegate GetOnPointerCaptureChanged_ZHandler()
			{
				if (Window.ICallback.cb_onPointerCaptureChanged_Z == null)
				{
					Window.ICallback.cb_onPointerCaptureChanged_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(Window.ICallback.n_OnPointerCaptureChanged_Z));
				}
				return Window.ICallback.cb_onPointerCaptureChanged_Z;
			}

			// Token: 0x06000D0E RID: 3342 RVA: 0x00021546 File Offset: 0x0001F746
			private static void n_OnPointerCaptureChanged_Z(IntPtr jnienv, IntPtr native__this, bool hasCapture)
			{
				Java.Lang.Object.GetObject<Window.ICallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnPointerCaptureChanged(hasCapture);
			}

			// Token: 0x06000D0F RID: 3343 RVA: 0x00021558 File Offset: 0x0001F758
			[Register("onPointerCaptureChanged", "(Z)V", "GetOnPointerCaptureChanged_ZHandler:Android.Views.Window/ICallback, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", ApiSince = 26)]
			unsafe void OnPointerCaptureChanged(bool hasCapture)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(hasCapture);
				Window.ICallback._members.InstanceMethods.InvokeVirtualVoidMethod("onPointerCaptureChanged.(Z)V", this, ptr);
			}

			// Token: 0x06000D10 RID: 3344 RVA: 0x00021593 File Offset: 0x0001F793
			private static Delegate GetOnProvideKeyboardShortcuts_Ljava_util_List_Landroid_view_Menu_IHandler()
			{
				if (Window.ICallback.cb_onProvideKeyboardShortcuts_Ljava_util_List_Landroid_view_Menu_I == null)
				{
					Window.ICallback.cb_onProvideKeyboardShortcuts_Ljava_util_List_Landroid_view_Menu_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLI_V(Window.ICallback.n_OnProvideKeyboardShortcuts_Ljava_util_List_Landroid_view_Menu_I));
				}
				return Window.ICallback.cb_onProvideKeyboardShortcuts_Ljava_util_List_Landroid_view_Menu_I;
			}

			// Token: 0x06000D11 RID: 3345 RVA: 0x000215B8 File Offset: 0x0001F7B8
			private static void n_OnProvideKeyboardShortcuts_Ljava_util_List_Landroid_view_Menu_I(IntPtr jnienv, IntPtr native__this, IntPtr native_data, IntPtr native_menu, int deviceId)
			{
				Window.ICallback @object = Java.Lang.Object.GetObject<Window.ICallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				IList<KeyboardShortcutGroup> data = JavaList<KeyboardShortcutGroup>.FromJniHandle(native_data, JniHandleOwnership.DoNotTransfer);
				IMenu object2 = Java.Lang.Object.GetObject<IMenu>(native_menu, JniHandleOwnership.DoNotTransfer);
				@object.OnProvideKeyboardShortcuts(data, object2, deviceId);
			}

			// Token: 0x06000D12 RID: 3346 RVA: 0x000215E8 File Offset: 0x0001F7E8
			[Register("onProvideKeyboardShortcuts", "(Ljava/util/List;Landroid/view/Menu;I)V", "GetOnProvideKeyboardShortcuts_Ljava_util_List_Landroid_view_Menu_IHandler:Android.Views.Window/ICallback, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", ApiSince = 24)]
			unsafe void OnProvideKeyboardShortcuts(IList<KeyboardShortcutGroup> data, IMenu menu, int deviceId)
			{
				IntPtr intPtr = JavaList<KeyboardShortcutGroup>.ToLocalJniHandle(data);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					ptr[1] = new JniArgumentValue((menu == null) ? IntPtr.Zero : ((Java.Lang.Object)menu).Handle);
					ptr[2] = new JniArgumentValue(deviceId);
					Window.ICallback._members.InstanceMethods.InvokeVirtualVoidMethod("onProvideKeyboardShortcuts.(Ljava/util/List;Landroid/view/Menu;I)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(data);
					GC.KeepAlive(menu);
				}
			}

			// Token: 0x0400043A RID: 1082
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/Window$Callback", typeof(Window.ICallback), true);

			// Token: 0x0400043B RID: 1083
			private static Delegate cb_onPointerCaptureChanged_Z;

			// Token: 0x0400043C RID: 1084
			private static Delegate cb_onProvideKeyboardShortcuts_Ljava_util_List_Landroid_view_Menu_I;
		}

		// Token: 0x0200016A RID: 362
		[Register("android/view/Window$Callback", DoNotGenerateAcw = true)]
		internal class ICallbackInvoker : Java.Lang.Object, Window.ICallback, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x1700027A RID: 634
			// (get) Token: 0x06000D14 RID: 3348 RVA: 0x000216A8 File Offset: 0x0001F8A8
			private static IntPtr java_class_ref
			{
				get
				{
					return Window.ICallbackInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700027B RID: 635
			// (get) Token: 0x06000D15 RID: 3349 RVA: 0x000216CC File Offset: 0x0001F8CC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return Window.ICallbackInvoker._members;
				}
			}

			// Token: 0x1700027C RID: 636
			// (get) Token: 0x06000D16 RID: 3350 RVA: 0x000216D3 File Offset: 0x0001F8D3
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x1700027D RID: 637
			// (get) Token: 0x06000D17 RID: 3351 RVA: 0x000216DB File Offset: 0x0001F8DB
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return Window.ICallbackInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000D18 RID: 3352 RVA: 0x000216E7 File Offset: 0x0001F8E7
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, Window.ICallbackInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.view.Window.Callback'.");
				}
				return handle;
			}

			// Token: 0x06000D19 RID: 3353 RVA: 0x00021712 File Offset: 0x0001F912
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000D1A RID: 3354 RVA: 0x00021744 File Offset: 0x0001F944
			public ICallbackInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Window.ICallbackInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000D1B RID: 3355 RVA: 0x0002177C File Offset: 0x0001F97C
			private static Delegate GetDispatchGenericMotionEvent_Landroid_view_MotionEvent_Handler()
			{
				if (Window.ICallbackInvoker.cb_dispatchGenericMotionEvent_Landroid_view_MotionEvent_ == null)
				{
					Window.ICallbackInvoker.cb_dispatchGenericMotionEvent_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(Window.ICallbackInvoker.n_DispatchGenericMotionEvent_Landroid_view_MotionEvent_));
				}
				return Window.ICallbackInvoker.cb_dispatchGenericMotionEvent_Landroid_view_MotionEvent_;
			}

			// Token: 0x06000D1C RID: 3356 RVA: 0x000217A0 File Offset: 0x0001F9A0
			private static bool n_DispatchGenericMotionEvent_Landroid_view_MotionEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_e)
			{
				Window.ICallback @object = Java.Lang.Object.GetObject<Window.ICallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				MotionEvent object2 = Java.Lang.Object.GetObject<MotionEvent>(native_e, JniHandleOwnership.DoNotTransfer);
				return @object.DispatchGenericMotionEvent(object2);
			}

			// Token: 0x06000D1D RID: 3357 RVA: 0x000217C4 File Offset: 0x0001F9C4
			public unsafe bool DispatchGenericMotionEvent(MotionEvent e)
			{
				if (this.id_dispatchGenericMotionEvent_Landroid_view_MotionEvent_ == IntPtr.Zero)
				{
					this.id_dispatchGenericMotionEvent_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID(this.class_ref, "dispatchGenericMotionEvent", "(Landroid/view/MotionEvent;)Z");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((e == null) ? IntPtr.Zero : e.Handle);
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_dispatchGenericMotionEvent_Landroid_view_MotionEvent_, ptr);
			}

			// Token: 0x06000D1E RID: 3358 RVA: 0x00021837 File Offset: 0x0001FA37
			private static Delegate GetDispatchKeyEvent_Landroid_view_KeyEvent_Handler()
			{
				if (Window.ICallbackInvoker.cb_dispatchKeyEvent_Landroid_view_KeyEvent_ == null)
				{
					Window.ICallbackInvoker.cb_dispatchKeyEvent_Landroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(Window.ICallbackInvoker.n_DispatchKeyEvent_Landroid_view_KeyEvent_));
				}
				return Window.ICallbackInvoker.cb_dispatchKeyEvent_Landroid_view_KeyEvent_;
			}

			// Token: 0x06000D1F RID: 3359 RVA: 0x0002185C File Offset: 0x0001FA5C
			private static bool n_DispatchKeyEvent_Landroid_view_KeyEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_e)
			{
				Window.ICallback @object = Java.Lang.Object.GetObject<Window.ICallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				KeyEvent object2 = Java.Lang.Object.GetObject<KeyEvent>(native_e, JniHandleOwnership.DoNotTransfer);
				return @object.DispatchKeyEvent(object2);
			}

			// Token: 0x06000D20 RID: 3360 RVA: 0x00021880 File Offset: 0x0001FA80
			public unsafe bool DispatchKeyEvent(KeyEvent e)
			{
				if (this.id_dispatchKeyEvent_Landroid_view_KeyEvent_ == IntPtr.Zero)
				{
					this.id_dispatchKeyEvent_Landroid_view_KeyEvent_ = JNIEnv.GetMethodID(this.class_ref, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((e == null) ? IntPtr.Zero : e.Handle);
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_dispatchKeyEvent_Landroid_view_KeyEvent_, ptr);
			}

			// Token: 0x06000D21 RID: 3361 RVA: 0x000218F3 File Offset: 0x0001FAF3
			private static Delegate GetDispatchKeyShortcutEvent_Landroid_view_KeyEvent_Handler()
			{
				if (Window.ICallbackInvoker.cb_dispatchKeyShortcutEvent_Landroid_view_KeyEvent_ == null)
				{
					Window.ICallbackInvoker.cb_dispatchKeyShortcutEvent_Landroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(Window.ICallbackInvoker.n_DispatchKeyShortcutEvent_Landroid_view_KeyEvent_));
				}
				return Window.ICallbackInvoker.cb_dispatchKeyShortcutEvent_Landroid_view_KeyEvent_;
			}

			// Token: 0x06000D22 RID: 3362 RVA: 0x00021918 File Offset: 0x0001FB18
			private static bool n_DispatchKeyShortcutEvent_Landroid_view_KeyEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_e)
			{
				Window.ICallback @object = Java.Lang.Object.GetObject<Window.ICallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				KeyEvent object2 = Java.Lang.Object.GetObject<KeyEvent>(native_e, JniHandleOwnership.DoNotTransfer);
				return @object.DispatchKeyShortcutEvent(object2);
			}

			// Token: 0x06000D23 RID: 3363 RVA: 0x0002193C File Offset: 0x0001FB3C
			public unsafe bool DispatchKeyShortcutEvent(KeyEvent e)
			{
				if (this.id_dispatchKeyShortcutEvent_Landroid_view_KeyEvent_ == IntPtr.Zero)
				{
					this.id_dispatchKeyShortcutEvent_Landroid_view_KeyEvent_ = JNIEnv.GetMethodID(this.class_ref, "dispatchKeyShortcutEvent", "(Landroid/view/KeyEvent;)Z");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((e == null) ? IntPtr.Zero : e.Handle);
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_dispatchKeyShortcutEvent_Landroid_view_KeyEvent_, ptr);
			}

			// Token: 0x06000D24 RID: 3364 RVA: 0x000219AF File Offset: 0x0001FBAF
			private static Delegate GetDispatchPopulateAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_Handler()
			{
				if (Window.ICallbackInvoker.cb_dispatchPopulateAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_ == null)
				{
					Window.ICallbackInvoker.cb_dispatchPopulateAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(Window.ICallbackInvoker.n_DispatchPopulateAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_));
				}
				return Window.ICallbackInvoker.cb_dispatchPopulateAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_;
			}

			// Token: 0x06000D25 RID: 3365 RVA: 0x000219D4 File Offset: 0x0001FBD4
			private static bool n_DispatchPopulateAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_e)
			{
				Window.ICallback @object = Java.Lang.Object.GetObject<Window.ICallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				AccessibilityEvent object2 = Java.Lang.Object.GetObject<AccessibilityEvent>(native_e, JniHandleOwnership.DoNotTransfer);
				return @object.DispatchPopulateAccessibilityEvent(object2);
			}

			// Token: 0x06000D26 RID: 3366 RVA: 0x000219F8 File Offset: 0x0001FBF8
			public unsafe bool DispatchPopulateAccessibilityEvent(AccessibilityEvent e)
			{
				if (this.id_dispatchPopulateAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_ == IntPtr.Zero)
				{
					this.id_dispatchPopulateAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_ = JNIEnv.GetMethodID(this.class_ref, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((e == null) ? IntPtr.Zero : e.Handle);
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_dispatchPopulateAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_, ptr);
			}

			// Token: 0x06000D27 RID: 3367 RVA: 0x00021A6B File Offset: 0x0001FC6B
			private static Delegate GetDispatchTouchEvent_Landroid_view_MotionEvent_Handler()
			{
				if (Window.ICallbackInvoker.cb_dispatchTouchEvent_Landroid_view_MotionEvent_ == null)
				{
					Window.ICallbackInvoker.cb_dispatchTouchEvent_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(Window.ICallbackInvoker.n_DispatchTouchEvent_Landroid_view_MotionEvent_));
				}
				return Window.ICallbackInvoker.cb_dispatchTouchEvent_Landroid_view_MotionEvent_;
			}

			// Token: 0x06000D28 RID: 3368 RVA: 0x00021A90 File Offset: 0x0001FC90
			private static bool n_DispatchTouchEvent_Landroid_view_MotionEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_e)
			{
				Window.ICallback @object = Java.Lang.Object.GetObject<Window.ICallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				MotionEvent object2 = Java.Lang.Object.GetObject<MotionEvent>(native_e, JniHandleOwnership.DoNotTransfer);
				return @object.DispatchTouchEvent(object2);
			}

			// Token: 0x06000D29 RID: 3369 RVA: 0x00021AB4 File Offset: 0x0001FCB4
			public unsafe bool DispatchTouchEvent(MotionEvent e)
			{
				if (this.id_dispatchTouchEvent_Landroid_view_MotionEvent_ == IntPtr.Zero)
				{
					this.id_dispatchTouchEvent_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID(this.class_ref, "dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((e == null) ? IntPtr.Zero : e.Handle);
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_dispatchTouchEvent_Landroid_view_MotionEvent_, ptr);
			}

			// Token: 0x06000D2A RID: 3370 RVA: 0x00021B27 File Offset: 0x0001FD27
			private static Delegate GetDispatchTrackballEvent_Landroid_view_MotionEvent_Handler()
			{
				if (Window.ICallbackInvoker.cb_dispatchTrackballEvent_Landroid_view_MotionEvent_ == null)
				{
					Window.ICallbackInvoker.cb_dispatchTrackballEvent_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(Window.ICallbackInvoker.n_DispatchTrackballEvent_Landroid_view_MotionEvent_));
				}
				return Window.ICallbackInvoker.cb_dispatchTrackballEvent_Landroid_view_MotionEvent_;
			}

			// Token: 0x06000D2B RID: 3371 RVA: 0x00021B4C File Offset: 0x0001FD4C
			private static bool n_DispatchTrackballEvent_Landroid_view_MotionEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_e)
			{
				Window.ICallback @object = Java.Lang.Object.GetObject<Window.ICallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				MotionEvent object2 = Java.Lang.Object.GetObject<MotionEvent>(native_e, JniHandleOwnership.DoNotTransfer);
				return @object.DispatchTrackballEvent(object2);
			}

			// Token: 0x06000D2C RID: 3372 RVA: 0x00021B70 File Offset: 0x0001FD70
			public unsafe bool DispatchTrackballEvent(MotionEvent e)
			{
				if (this.id_dispatchTrackballEvent_Landroid_view_MotionEvent_ == IntPtr.Zero)
				{
					this.id_dispatchTrackballEvent_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID(this.class_ref, "dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((e == null) ? IntPtr.Zero : e.Handle);
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_dispatchTrackballEvent_Landroid_view_MotionEvent_, ptr);
			}

			// Token: 0x06000D2D RID: 3373 RVA: 0x00021BE3 File Offset: 0x0001FDE3
			private static Delegate GetOnActionModeFinished_Landroid_view_ActionMode_Handler()
			{
				if (Window.ICallbackInvoker.cb_onActionModeFinished_Landroid_view_ActionMode_ == null)
				{
					Window.ICallbackInvoker.cb_onActionModeFinished_Landroid_view_ActionMode_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Window.ICallbackInvoker.n_OnActionModeFinished_Landroid_view_ActionMode_));
				}
				return Window.ICallbackInvoker.cb_onActionModeFinished_Landroid_view_ActionMode_;
			}

			// Token: 0x06000D2E RID: 3374 RVA: 0x00021C08 File Offset: 0x0001FE08
			private static void n_OnActionModeFinished_Landroid_view_ActionMode_(IntPtr jnienv, IntPtr native__this, IntPtr native_mode)
			{
				Window.ICallback @object = Java.Lang.Object.GetObject<Window.ICallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ActionMode object2 = Java.Lang.Object.GetObject<ActionMode>(native_mode, JniHandleOwnership.DoNotTransfer);
				@object.OnActionModeFinished(object2);
			}

			// Token: 0x06000D2F RID: 3375 RVA: 0x00021C2C File Offset: 0x0001FE2C
			public unsafe void OnActionModeFinished(ActionMode mode)
			{
				if (this.id_onActionModeFinished_Landroid_view_ActionMode_ == IntPtr.Zero)
				{
					this.id_onActionModeFinished_Landroid_view_ActionMode_ = JNIEnv.GetMethodID(this.class_ref, "onActionModeFinished", "(Landroid/view/ActionMode;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((mode == null) ? IntPtr.Zero : mode.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onActionModeFinished_Landroid_view_ActionMode_, ptr);
			}

			// Token: 0x06000D30 RID: 3376 RVA: 0x00021C9F File Offset: 0x0001FE9F
			private static Delegate GetOnActionModeStarted_Landroid_view_ActionMode_Handler()
			{
				if (Window.ICallbackInvoker.cb_onActionModeStarted_Landroid_view_ActionMode_ == null)
				{
					Window.ICallbackInvoker.cb_onActionModeStarted_Landroid_view_ActionMode_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Window.ICallbackInvoker.n_OnActionModeStarted_Landroid_view_ActionMode_));
				}
				return Window.ICallbackInvoker.cb_onActionModeStarted_Landroid_view_ActionMode_;
			}

			// Token: 0x06000D31 RID: 3377 RVA: 0x00021CC4 File Offset: 0x0001FEC4
			private static void n_OnActionModeStarted_Landroid_view_ActionMode_(IntPtr jnienv, IntPtr native__this, IntPtr native_mode)
			{
				Window.ICallback @object = Java.Lang.Object.GetObject<Window.ICallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ActionMode object2 = Java.Lang.Object.GetObject<ActionMode>(native_mode, JniHandleOwnership.DoNotTransfer);
				@object.OnActionModeStarted(object2);
			}

			// Token: 0x06000D32 RID: 3378 RVA: 0x00021CE8 File Offset: 0x0001FEE8
			public unsafe void OnActionModeStarted(ActionMode mode)
			{
				if (this.id_onActionModeStarted_Landroid_view_ActionMode_ == IntPtr.Zero)
				{
					this.id_onActionModeStarted_Landroid_view_ActionMode_ = JNIEnv.GetMethodID(this.class_ref, "onActionModeStarted", "(Landroid/view/ActionMode;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((mode == null) ? IntPtr.Zero : mode.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onActionModeStarted_Landroid_view_ActionMode_, ptr);
			}

			// Token: 0x06000D33 RID: 3379 RVA: 0x00021D5B File Offset: 0x0001FF5B
			private static Delegate GetOnAttachedToWindowHandler()
			{
				if (Window.ICallbackInvoker.cb_onAttachedToWindow == null)
				{
					Window.ICallbackInvoker.cb_onAttachedToWindow = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Window.ICallbackInvoker.n_OnAttachedToWindow));
				}
				return Window.ICallbackInvoker.cb_onAttachedToWindow;
			}

			// Token: 0x06000D34 RID: 3380 RVA: 0x00021D7F File Offset: 0x0001FF7F
			private static void n_OnAttachedToWindow(IntPtr jnienv, IntPtr native__this)
			{
				Java.Lang.Object.GetObject<Window.ICallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnAttachedToWindow();
			}

			// Token: 0x06000D35 RID: 3381 RVA: 0x00021D8E File Offset: 0x0001FF8E
			public void OnAttachedToWindow()
			{
				if (this.id_onAttachedToWindow == IntPtr.Zero)
				{
					this.id_onAttachedToWindow = JNIEnv.GetMethodID(this.class_ref, "onAttachedToWindow", "()V");
				}
				JNIEnv.CallVoidMethod(base.Handle, this.id_onAttachedToWindow);
			}

			// Token: 0x06000D36 RID: 3382 RVA: 0x00021DCE File Offset: 0x0001FFCE
			private static Delegate GetOnContentChangedHandler()
			{
				if (Window.ICallbackInvoker.cb_onContentChanged == null)
				{
					Window.ICallbackInvoker.cb_onContentChanged = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Window.ICallbackInvoker.n_OnContentChanged));
				}
				return Window.ICallbackInvoker.cb_onContentChanged;
			}

			// Token: 0x06000D37 RID: 3383 RVA: 0x00021DF2 File Offset: 0x0001FFF2
			private static void n_OnContentChanged(IntPtr jnienv, IntPtr native__this)
			{
				Java.Lang.Object.GetObject<Window.ICallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnContentChanged();
			}

			// Token: 0x06000D38 RID: 3384 RVA: 0x00021E01 File Offset: 0x00020001
			public void OnContentChanged()
			{
				if (this.id_onContentChanged == IntPtr.Zero)
				{
					this.id_onContentChanged = JNIEnv.GetMethodID(this.class_ref, "onContentChanged", "()V");
				}
				JNIEnv.CallVoidMethod(base.Handle, this.id_onContentChanged);
			}

			// Token: 0x06000D39 RID: 3385 RVA: 0x00021E41 File Offset: 0x00020041
			private static Delegate GetOnCreatePanelMenu_ILandroid_view_Menu_Handler()
			{
				if (Window.ICallbackInvoker.cb_onCreatePanelMenu_ILandroid_view_Menu_ == null)
				{
					Window.ICallbackInvoker.cb_onCreatePanelMenu_ILandroid_view_Menu_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_Z(Window.ICallbackInvoker.n_OnCreatePanelMenu_ILandroid_view_Menu_));
				}
				return Window.ICallbackInvoker.cb_onCreatePanelMenu_ILandroid_view_Menu_;
			}

			// Token: 0x06000D3A RID: 3386 RVA: 0x00021E68 File Offset: 0x00020068
			private static bool n_OnCreatePanelMenu_ILandroid_view_Menu_(IntPtr jnienv, IntPtr native__this, int featureId, IntPtr native_menu)
			{
				Window.ICallback @object = Java.Lang.Object.GetObject<Window.ICallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				IMenu object2 = Java.Lang.Object.GetObject<IMenu>(native_menu, JniHandleOwnership.DoNotTransfer);
				return @object.OnCreatePanelMenu(featureId, object2);
			}

			// Token: 0x06000D3B RID: 3387 RVA: 0x00021E8C File Offset: 0x0002008C
			public unsafe bool OnCreatePanelMenu(int featureId, IMenu menu)
			{
				if (this.id_onCreatePanelMenu_ILandroid_view_Menu_ == IntPtr.Zero)
				{
					this.id_onCreatePanelMenu_ILandroid_view_Menu_ = JNIEnv.GetMethodID(this.class_ref, "onCreatePanelMenu", "(ILandroid/view/Menu;)Z");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(featureId);
				ptr[1] = new JValue((menu == null) ? IntPtr.Zero : ((Java.Lang.Object)menu).Handle);
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_onCreatePanelMenu_ILandroid_view_Menu_, ptr);
			}

			// Token: 0x06000D3C RID: 3388 RVA: 0x00021F17 File Offset: 0x00020117
			private static Delegate GetOnCreatePanelView_IHandler()
			{
				if (Window.ICallbackInvoker.cb_onCreatePanelView_I == null)
				{
					Window.ICallbackInvoker.cb_onCreatePanelView_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(Window.ICallbackInvoker.n_OnCreatePanelView_I));
				}
				return Window.ICallbackInvoker.cb_onCreatePanelView_I;
			}

			// Token: 0x06000D3D RID: 3389 RVA: 0x00021F3B File Offset: 0x0002013B
			private static IntPtr n_OnCreatePanelView_I(IntPtr jnienv, IntPtr native__this, int featureId)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Window.ICallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnCreatePanelView(featureId));
			}

			// Token: 0x06000D3E RID: 3390 RVA: 0x00021F50 File Offset: 0x00020150
			public unsafe View OnCreatePanelView(int featureId)
			{
				if (this.id_onCreatePanelView_I == IntPtr.Zero)
				{
					this.id_onCreatePanelView_I = JNIEnv.GetMethodID(this.class_ref, "onCreatePanelView", "(I)Landroid/view/View;");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(featureId);
				return Java.Lang.Object.GetObject<View>(JNIEnv.CallObjectMethod(base.Handle, this.id_onCreatePanelView_I, ptr), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000D3F RID: 3391 RVA: 0x00021FBA File Offset: 0x000201BA
			private static Delegate GetOnDetachedFromWindowHandler()
			{
				if (Window.ICallbackInvoker.cb_onDetachedFromWindow == null)
				{
					Window.ICallbackInvoker.cb_onDetachedFromWindow = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Window.ICallbackInvoker.n_OnDetachedFromWindow));
				}
				return Window.ICallbackInvoker.cb_onDetachedFromWindow;
			}

			// Token: 0x06000D40 RID: 3392 RVA: 0x00021FDE File Offset: 0x000201DE
			private static void n_OnDetachedFromWindow(IntPtr jnienv, IntPtr native__this)
			{
				Java.Lang.Object.GetObject<Window.ICallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnDetachedFromWindow();
			}

			// Token: 0x06000D41 RID: 3393 RVA: 0x00021FED File Offset: 0x000201ED
			public void OnDetachedFromWindow()
			{
				if (this.id_onDetachedFromWindow == IntPtr.Zero)
				{
					this.id_onDetachedFromWindow = JNIEnv.GetMethodID(this.class_ref, "onDetachedFromWindow", "()V");
				}
				JNIEnv.CallVoidMethod(base.Handle, this.id_onDetachedFromWindow);
			}

			// Token: 0x06000D42 RID: 3394 RVA: 0x0002202D File Offset: 0x0002022D
			private static Delegate GetOnMenuItemSelected_ILandroid_view_MenuItem_Handler()
			{
				if (Window.ICallbackInvoker.cb_onMenuItemSelected_ILandroid_view_MenuItem_ == null)
				{
					Window.ICallbackInvoker.cb_onMenuItemSelected_ILandroid_view_MenuItem_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_Z(Window.ICallbackInvoker.n_OnMenuItemSelected_ILandroid_view_MenuItem_));
				}
				return Window.ICallbackInvoker.cb_onMenuItemSelected_ILandroid_view_MenuItem_;
			}

			// Token: 0x06000D43 RID: 3395 RVA: 0x00022054 File Offset: 0x00020254
			private static bool n_OnMenuItemSelected_ILandroid_view_MenuItem_(IntPtr jnienv, IntPtr native__this, int featureId, IntPtr native_item)
			{
				Window.ICallback @object = Java.Lang.Object.GetObject<Window.ICallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				IMenuItem object2 = Java.Lang.Object.GetObject<IMenuItem>(native_item, JniHandleOwnership.DoNotTransfer);
				return @object.OnMenuItemSelected(featureId, object2);
			}

			// Token: 0x06000D44 RID: 3396 RVA: 0x00022078 File Offset: 0x00020278
			public unsafe bool OnMenuItemSelected(int featureId, IMenuItem item)
			{
				if (this.id_onMenuItemSelected_ILandroid_view_MenuItem_ == IntPtr.Zero)
				{
					this.id_onMenuItemSelected_ILandroid_view_MenuItem_ = JNIEnv.GetMethodID(this.class_ref, "onMenuItemSelected", "(ILandroid/view/MenuItem;)Z");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(featureId);
				ptr[1] = new JValue((item == null) ? IntPtr.Zero : ((Java.Lang.Object)item).Handle);
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_onMenuItemSelected_ILandroid_view_MenuItem_, ptr);
			}

			// Token: 0x06000D45 RID: 3397 RVA: 0x00022103 File Offset: 0x00020303
			private static Delegate GetOnMenuOpened_ILandroid_view_Menu_Handler()
			{
				if (Window.ICallbackInvoker.cb_onMenuOpened_ILandroid_view_Menu_ == null)
				{
					Window.ICallbackInvoker.cb_onMenuOpened_ILandroid_view_Menu_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_Z(Window.ICallbackInvoker.n_OnMenuOpened_ILandroid_view_Menu_));
				}
				return Window.ICallbackInvoker.cb_onMenuOpened_ILandroid_view_Menu_;
			}

			// Token: 0x06000D46 RID: 3398 RVA: 0x00022128 File Offset: 0x00020328
			private static bool n_OnMenuOpened_ILandroid_view_Menu_(IntPtr jnienv, IntPtr native__this, int featureId, IntPtr native_menu)
			{
				Window.ICallback @object = Java.Lang.Object.GetObject<Window.ICallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				IMenu object2 = Java.Lang.Object.GetObject<IMenu>(native_menu, JniHandleOwnership.DoNotTransfer);
				return @object.OnMenuOpened(featureId, object2);
			}

			// Token: 0x06000D47 RID: 3399 RVA: 0x0002214C File Offset: 0x0002034C
			public unsafe bool OnMenuOpened(int featureId, IMenu menu)
			{
				if (this.id_onMenuOpened_ILandroid_view_Menu_ == IntPtr.Zero)
				{
					this.id_onMenuOpened_ILandroid_view_Menu_ = JNIEnv.GetMethodID(this.class_ref, "onMenuOpened", "(ILandroid/view/Menu;)Z");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(featureId);
				ptr[1] = new JValue((menu == null) ? IntPtr.Zero : ((Java.Lang.Object)menu).Handle);
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_onMenuOpened_ILandroid_view_Menu_, ptr);
			}

			// Token: 0x06000D48 RID: 3400 RVA: 0x000221D7 File Offset: 0x000203D7
			private static Delegate GetOnPanelClosed_ILandroid_view_Menu_Handler()
			{
				if (Window.ICallbackInvoker.cb_onPanelClosed_ILandroid_view_Menu_ == null)
				{
					Window.ICallbackInvoker.cb_onPanelClosed_ILandroid_view_Menu_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_V(Window.ICallbackInvoker.n_OnPanelClosed_ILandroid_view_Menu_));
				}
				return Window.ICallbackInvoker.cb_onPanelClosed_ILandroid_view_Menu_;
			}

			// Token: 0x06000D49 RID: 3401 RVA: 0x000221FC File Offset: 0x000203FC
			private static void n_OnPanelClosed_ILandroid_view_Menu_(IntPtr jnienv, IntPtr native__this, int featureId, IntPtr native_menu)
			{
				Window.ICallback @object = Java.Lang.Object.GetObject<Window.ICallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				IMenu object2 = Java.Lang.Object.GetObject<IMenu>(native_menu, JniHandleOwnership.DoNotTransfer);
				@object.OnPanelClosed(featureId, object2);
			}

			// Token: 0x06000D4A RID: 3402 RVA: 0x00022220 File Offset: 0x00020420
			public unsafe void OnPanelClosed(int featureId, IMenu menu)
			{
				if (this.id_onPanelClosed_ILandroid_view_Menu_ == IntPtr.Zero)
				{
					this.id_onPanelClosed_ILandroid_view_Menu_ = JNIEnv.GetMethodID(this.class_ref, "onPanelClosed", "(ILandroid/view/Menu;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(featureId);
				ptr[1] = new JValue((menu == null) ? IntPtr.Zero : ((Java.Lang.Object)menu).Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onPanelClosed_ILandroid_view_Menu_, ptr);
			}

			// Token: 0x06000D4B RID: 3403 RVA: 0x000222AB File Offset: 0x000204AB
			private static Delegate GetOnPreparePanel_ILandroid_view_View_Landroid_view_Menu_Handler()
			{
				if (Window.ICallbackInvoker.cb_onPreparePanel_ILandroid_view_View_Landroid_view_Menu_ == null)
				{
					Window.ICallbackInvoker.cb_onPreparePanel_ILandroid_view_View_Landroid_view_Menu_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPILL_Z(Window.ICallbackInvoker.n_OnPreparePanel_ILandroid_view_View_Landroid_view_Menu_));
				}
				return Window.ICallbackInvoker.cb_onPreparePanel_ILandroid_view_View_Landroid_view_Menu_;
			}

			// Token: 0x06000D4C RID: 3404 RVA: 0x000222D0 File Offset: 0x000204D0
			private static bool n_OnPreparePanel_ILandroid_view_View_Landroid_view_Menu_(IntPtr jnienv, IntPtr native__this, int featureId, IntPtr native_view, IntPtr native_menu)
			{
				Window.ICallback @object = Java.Lang.Object.GetObject<Window.ICallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
				IMenu object3 = Java.Lang.Object.GetObject<IMenu>(native_menu, JniHandleOwnership.DoNotTransfer);
				return @object.OnPreparePanel(featureId, object2, object3);
			}

			// Token: 0x06000D4D RID: 3405 RVA: 0x00022300 File Offset: 0x00020500
			public unsafe bool OnPreparePanel(int featureId, View view, IMenu menu)
			{
				if (this.id_onPreparePanel_ILandroid_view_View_Landroid_view_Menu_ == IntPtr.Zero)
				{
					this.id_onPreparePanel_ILandroid_view_View_Landroid_view_Menu_ = JNIEnv.GetMethodID(this.class_ref, "onPreparePanel", "(ILandroid/view/View;Landroid/view/Menu;)Z");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(featureId);
				ptr[1] = new JValue((view == null) ? IntPtr.Zero : view.Handle);
				ptr[2] = new JValue((menu == null) ? IntPtr.Zero : ((Java.Lang.Object)menu).Handle);
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_onPreparePanel_ILandroid_view_View_Landroid_view_Menu_, ptr);
			}

			// Token: 0x06000D4E RID: 3406 RVA: 0x000223B0 File Offset: 0x000205B0
			private static Delegate GetOnSearchRequestedHandler()
			{
				if (Window.ICallbackInvoker.cb_onSearchRequested == null)
				{
					Window.ICallbackInvoker.cb_onSearchRequested = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(Window.ICallbackInvoker.n_OnSearchRequested));
				}
				return Window.ICallbackInvoker.cb_onSearchRequested;
			}

			// Token: 0x06000D4F RID: 3407 RVA: 0x000223D4 File Offset: 0x000205D4
			private static bool n_OnSearchRequested(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<Window.ICallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnSearchRequested();
			}

			// Token: 0x06000D50 RID: 3408 RVA: 0x000223E3 File Offset: 0x000205E3
			public bool OnSearchRequested()
			{
				if (this.id_onSearchRequested == IntPtr.Zero)
				{
					this.id_onSearchRequested = JNIEnv.GetMethodID(this.class_ref, "onSearchRequested", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_onSearchRequested);
			}

			// Token: 0x06000D51 RID: 3409 RVA: 0x00022423 File Offset: 0x00020623
			private static Delegate GetOnSearchRequested_Landroid_view_SearchEvent_Handler()
			{
				if (Window.ICallbackInvoker.cb_onSearchRequested_Landroid_view_SearchEvent_ == null)
				{
					Window.ICallbackInvoker.cb_onSearchRequested_Landroid_view_SearchEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(Window.ICallbackInvoker.n_OnSearchRequested_Landroid_view_SearchEvent_));
				}
				return Window.ICallbackInvoker.cb_onSearchRequested_Landroid_view_SearchEvent_;
			}

			// Token: 0x06000D52 RID: 3410 RVA: 0x00022448 File Offset: 0x00020648
			private static bool n_OnSearchRequested_Landroid_view_SearchEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_searchEvent)
			{
				Window.ICallback @object = Java.Lang.Object.GetObject<Window.ICallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				SearchEvent object2 = Java.Lang.Object.GetObject<SearchEvent>(native_searchEvent, JniHandleOwnership.DoNotTransfer);
				return @object.OnSearchRequested(object2);
			}

			// Token: 0x06000D53 RID: 3411 RVA: 0x0002246C File Offset: 0x0002066C
			public unsafe bool OnSearchRequested(SearchEvent searchEvent)
			{
				if (this.id_onSearchRequested_Landroid_view_SearchEvent_ == IntPtr.Zero)
				{
					this.id_onSearchRequested_Landroid_view_SearchEvent_ = JNIEnv.GetMethodID(this.class_ref, "onSearchRequested", "(Landroid/view/SearchEvent;)Z");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((searchEvent == null) ? IntPtr.Zero : searchEvent.Handle);
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_onSearchRequested_Landroid_view_SearchEvent_, ptr);
			}

			// Token: 0x06000D54 RID: 3412 RVA: 0x000224DF File Offset: 0x000206DF
			private static Delegate GetOnWindowAttributesChanged_Landroid_view_WindowManager_LayoutParams_Handler()
			{
				if (Window.ICallbackInvoker.cb_onWindowAttributesChanged_Landroid_view_WindowManager_LayoutParams_ == null)
				{
					Window.ICallbackInvoker.cb_onWindowAttributesChanged_Landroid_view_WindowManager_LayoutParams_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Window.ICallbackInvoker.n_OnWindowAttributesChanged_Landroid_view_WindowManager_LayoutParams_));
				}
				return Window.ICallbackInvoker.cb_onWindowAttributesChanged_Landroid_view_WindowManager_LayoutParams_;
			}

			// Token: 0x06000D55 RID: 3413 RVA: 0x00022504 File Offset: 0x00020704
			private static void n_OnWindowAttributesChanged_Landroid_view_WindowManager_LayoutParams_(IntPtr jnienv, IntPtr native__this, IntPtr native_attrs)
			{
				Window.ICallback @object = Java.Lang.Object.GetObject<Window.ICallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				WindowManagerLayoutParams object2 = Java.Lang.Object.GetObject<WindowManagerLayoutParams>(native_attrs, JniHandleOwnership.DoNotTransfer);
				@object.OnWindowAttributesChanged(object2);
			}

			// Token: 0x06000D56 RID: 3414 RVA: 0x00022528 File Offset: 0x00020728
			public unsafe void OnWindowAttributesChanged(WindowManagerLayoutParams attrs)
			{
				if (this.id_onWindowAttributesChanged_Landroid_view_WindowManager_LayoutParams_ == IntPtr.Zero)
				{
					this.id_onWindowAttributesChanged_Landroid_view_WindowManager_LayoutParams_ = JNIEnv.GetMethodID(this.class_ref, "onWindowAttributesChanged", "(Landroid/view/WindowManager$LayoutParams;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((attrs == null) ? IntPtr.Zero : attrs.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onWindowAttributesChanged_Landroid_view_WindowManager_LayoutParams_, ptr);
			}

			// Token: 0x06000D57 RID: 3415 RVA: 0x0002259B File Offset: 0x0002079B
			private static Delegate GetOnWindowFocusChanged_ZHandler()
			{
				if (Window.ICallbackInvoker.cb_onWindowFocusChanged_Z == null)
				{
					Window.ICallbackInvoker.cb_onWindowFocusChanged_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(Window.ICallbackInvoker.n_OnWindowFocusChanged_Z));
				}
				return Window.ICallbackInvoker.cb_onWindowFocusChanged_Z;
			}

			// Token: 0x06000D58 RID: 3416 RVA: 0x000225BF File Offset: 0x000207BF
			private static void n_OnWindowFocusChanged_Z(IntPtr jnienv, IntPtr native__this, bool hasFocus)
			{
				Java.Lang.Object.GetObject<Window.ICallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnWindowFocusChanged(hasFocus);
			}

			// Token: 0x06000D59 RID: 3417 RVA: 0x000225D0 File Offset: 0x000207D0
			public unsafe void OnWindowFocusChanged(bool hasFocus)
			{
				if (this.id_onWindowFocusChanged_Z == IntPtr.Zero)
				{
					this.id_onWindowFocusChanged_Z = JNIEnv.GetMethodID(this.class_ref, "onWindowFocusChanged", "(Z)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(hasFocus);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onWindowFocusChanged_Z, ptr);
			}

			// Token: 0x06000D5A RID: 3418 RVA: 0x00022634 File Offset: 0x00020834
			private static Delegate GetOnWindowStartingActionMode_Landroid_view_ActionMode_Callback_Handler()
			{
				if (Window.ICallbackInvoker.cb_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_ == null)
				{
					Window.ICallbackInvoker.cb_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(Window.ICallbackInvoker.n_OnWindowStartingActionMode_Landroid_view_ActionMode_Callback_));
				}
				return Window.ICallbackInvoker.cb_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_;
			}

			// Token: 0x06000D5B RID: 3419 RVA: 0x00022658 File Offset: 0x00020858
			private static IntPtr n_OnWindowStartingActionMode_Landroid_view_ActionMode_Callback_(IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
			{
				Window.ICallback @object = Java.Lang.Object.GetObject<Window.ICallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ActionMode.ICallback object2 = Java.Lang.Object.GetObject<ActionMode.ICallback>(native__callback, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.OnWindowStartingActionMode(object2));
			}

			// Token: 0x06000D5C RID: 3420 RVA: 0x00022680 File Offset: 0x00020880
			public unsafe ActionMode OnWindowStartingActionMode(ActionMode.ICallback callback)
			{
				if (this.id_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_ == IntPtr.Zero)
				{
					this.id_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_ = JNIEnv.GetMethodID(this.class_ref, "onWindowStartingActionMode", "(Landroid/view/ActionMode$Callback;)Landroid/view/ActionMode;");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((callback == null) ? IntPtr.Zero : ((Java.Lang.Object)callback).Handle);
				return Java.Lang.Object.GetObject<ActionMode>(JNIEnv.CallObjectMethod(base.Handle, this.id_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_, ptr), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000D5D RID: 3421 RVA: 0x000226FE File Offset: 0x000208FE
			private static Delegate GetOnWindowStartingActionMode_Landroid_view_ActionMode_Callback_IHandler()
			{
				if (Window.ICallbackInvoker.cb_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_I == null)
				{
					Window.ICallbackInvoker.cb_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_L(Window.ICallbackInvoker.n_OnWindowStartingActionMode_Landroid_view_ActionMode_Callback_I));
				}
				return Window.ICallbackInvoker.cb_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_I;
			}

			// Token: 0x06000D5E RID: 3422 RVA: 0x00022724 File Offset: 0x00020924
			private static IntPtr n_OnWindowStartingActionMode_Landroid_view_ActionMode_Callback_I(IntPtr jnienv, IntPtr native__this, IntPtr native__callback, int native_type)
			{
				Window.ICallback @object = Java.Lang.Object.GetObject<Window.ICallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ActionMode.ICallback object2 = Java.Lang.Object.GetObject<ActionMode.ICallback>(native__callback, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.OnWindowStartingActionMode(object2, (ActionModeType)native_type));
			}

			// Token: 0x06000D5F RID: 3423 RVA: 0x00022750 File Offset: 0x00020950
			public unsafe ActionMode OnWindowStartingActionMode(ActionMode.ICallback callback, [GeneratedEnum] ActionModeType type)
			{
				if (this.id_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_I == IntPtr.Zero)
				{
					this.id_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_I = JNIEnv.GetMethodID(this.class_ref, "onWindowStartingActionMode", "(Landroid/view/ActionMode$Callback;I)Landroid/view/ActionMode;");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((callback == null) ? IntPtr.Zero : ((Java.Lang.Object)callback).Handle);
				ptr[1] = new JValue((int)type);
				return Java.Lang.Object.GetObject<ActionMode>(JNIEnv.CallObjectMethod(base.Handle, this.id_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_I, ptr), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0400043D RID: 1085
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/Window$Callback", typeof(Window.ICallbackInvoker));

			// Token: 0x0400043E RID: 1086
			private IntPtr class_ref;

			// Token: 0x0400043F RID: 1087
			private static Delegate cb_dispatchGenericMotionEvent_Landroid_view_MotionEvent_;

			// Token: 0x04000440 RID: 1088
			private IntPtr id_dispatchGenericMotionEvent_Landroid_view_MotionEvent_;

			// Token: 0x04000441 RID: 1089
			private static Delegate cb_dispatchKeyEvent_Landroid_view_KeyEvent_;

			// Token: 0x04000442 RID: 1090
			private IntPtr id_dispatchKeyEvent_Landroid_view_KeyEvent_;

			// Token: 0x04000443 RID: 1091
			private static Delegate cb_dispatchKeyShortcutEvent_Landroid_view_KeyEvent_;

			// Token: 0x04000444 RID: 1092
			private IntPtr id_dispatchKeyShortcutEvent_Landroid_view_KeyEvent_;

			// Token: 0x04000445 RID: 1093
			private static Delegate cb_dispatchPopulateAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_;

			// Token: 0x04000446 RID: 1094
			private IntPtr id_dispatchPopulateAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_;

			// Token: 0x04000447 RID: 1095
			private static Delegate cb_dispatchTouchEvent_Landroid_view_MotionEvent_;

			// Token: 0x04000448 RID: 1096
			private IntPtr id_dispatchTouchEvent_Landroid_view_MotionEvent_;

			// Token: 0x04000449 RID: 1097
			private static Delegate cb_dispatchTrackballEvent_Landroid_view_MotionEvent_;

			// Token: 0x0400044A RID: 1098
			private IntPtr id_dispatchTrackballEvent_Landroid_view_MotionEvent_;

			// Token: 0x0400044B RID: 1099
			private static Delegate cb_onActionModeFinished_Landroid_view_ActionMode_;

			// Token: 0x0400044C RID: 1100
			private IntPtr id_onActionModeFinished_Landroid_view_ActionMode_;

			// Token: 0x0400044D RID: 1101
			private static Delegate cb_onActionModeStarted_Landroid_view_ActionMode_;

			// Token: 0x0400044E RID: 1102
			private IntPtr id_onActionModeStarted_Landroid_view_ActionMode_;

			// Token: 0x0400044F RID: 1103
			private static Delegate cb_onAttachedToWindow;

			// Token: 0x04000450 RID: 1104
			private IntPtr id_onAttachedToWindow;

			// Token: 0x04000451 RID: 1105
			private static Delegate cb_onContentChanged;

			// Token: 0x04000452 RID: 1106
			private IntPtr id_onContentChanged;

			// Token: 0x04000453 RID: 1107
			private static Delegate cb_onCreatePanelMenu_ILandroid_view_Menu_;

			// Token: 0x04000454 RID: 1108
			private IntPtr id_onCreatePanelMenu_ILandroid_view_Menu_;

			// Token: 0x04000455 RID: 1109
			private static Delegate cb_onCreatePanelView_I;

			// Token: 0x04000456 RID: 1110
			private IntPtr id_onCreatePanelView_I;

			// Token: 0x04000457 RID: 1111
			private static Delegate cb_onDetachedFromWindow;

			// Token: 0x04000458 RID: 1112
			private IntPtr id_onDetachedFromWindow;

			// Token: 0x04000459 RID: 1113
			private static Delegate cb_onMenuItemSelected_ILandroid_view_MenuItem_;

			// Token: 0x0400045A RID: 1114
			private IntPtr id_onMenuItemSelected_ILandroid_view_MenuItem_;

			// Token: 0x0400045B RID: 1115
			private static Delegate cb_onMenuOpened_ILandroid_view_Menu_;

			// Token: 0x0400045C RID: 1116
			private IntPtr id_onMenuOpened_ILandroid_view_Menu_;

			// Token: 0x0400045D RID: 1117
			private static Delegate cb_onPanelClosed_ILandroid_view_Menu_;

			// Token: 0x0400045E RID: 1118
			private IntPtr id_onPanelClosed_ILandroid_view_Menu_;

			// Token: 0x0400045F RID: 1119
			private static Delegate cb_onPreparePanel_ILandroid_view_View_Landroid_view_Menu_;

			// Token: 0x04000460 RID: 1120
			private IntPtr id_onPreparePanel_ILandroid_view_View_Landroid_view_Menu_;

			// Token: 0x04000461 RID: 1121
			private static Delegate cb_onSearchRequested;

			// Token: 0x04000462 RID: 1122
			private IntPtr id_onSearchRequested;

			// Token: 0x04000463 RID: 1123
			private static Delegate cb_onSearchRequested_Landroid_view_SearchEvent_;

			// Token: 0x04000464 RID: 1124
			private IntPtr id_onSearchRequested_Landroid_view_SearchEvent_;

			// Token: 0x04000465 RID: 1125
			private static Delegate cb_onWindowAttributesChanged_Landroid_view_WindowManager_LayoutParams_;

			// Token: 0x04000466 RID: 1126
			private IntPtr id_onWindowAttributesChanged_Landroid_view_WindowManager_LayoutParams_;

			// Token: 0x04000467 RID: 1127
			private static Delegate cb_onWindowFocusChanged_Z;

			// Token: 0x04000468 RID: 1128
			private IntPtr id_onWindowFocusChanged_Z;

			// Token: 0x04000469 RID: 1129
			private static Delegate cb_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_;

			// Token: 0x0400046A RID: 1130
			private IntPtr id_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_;

			// Token: 0x0400046B RID: 1131
			private static Delegate cb_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_I;

			// Token: 0x0400046C RID: 1132
			private IntPtr id_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_I;
		}
	}
}
