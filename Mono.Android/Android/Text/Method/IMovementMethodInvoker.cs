using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Interop;
using Java.Lang;

namespace Android.Text.Method
{
	// Token: 0x020001D0 RID: 464
	[Register("android/text/method/MovementMethod", DoNotGenerateAcw = true)]
	internal class IMovementMethodInvoker : Java.Lang.Object, IMovementMethod, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700034B RID: 843
		// (get) Token: 0x060010C2 RID: 4290 RVA: 0x0002BC90 File Offset: 0x00029E90
		private static IntPtr java_class_ref
		{
			get
			{
				return IMovementMethodInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x060010C3 RID: 4291 RVA: 0x0002BCB4 File Offset: 0x00029EB4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMovementMethodInvoker._members;
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x060010C4 RID: 4292 RVA: 0x0002BCBB File Offset: 0x00029EBB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x060010C5 RID: 4293 RVA: 0x0002BCC3 File Offset: 0x00029EC3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMovementMethodInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060010C6 RID: 4294 RVA: 0x0002BCCF File Offset: 0x00029ECF
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMovementMethodInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.text.method.MovementMethod'.");
			}
			return handle;
		}

		// Token: 0x060010C7 RID: 4295 RVA: 0x0002BCFA File Offset: 0x00029EFA
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060010C8 RID: 4296 RVA: 0x0002BD2C File Offset: 0x00029F2C
		public IMovementMethodInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMovementMethodInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060010C9 RID: 4297 RVA: 0x0002BD64 File Offset: 0x00029F64
		private static Delegate GetCanSelectArbitrarilyHandler()
		{
			if (IMovementMethodInvoker.cb_canSelectArbitrarily == null)
			{
				IMovementMethodInvoker.cb_canSelectArbitrarily = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IMovementMethodInvoker.n_CanSelectArbitrarily));
			}
			return IMovementMethodInvoker.cb_canSelectArbitrarily;
		}

		// Token: 0x060010CA RID: 4298 RVA: 0x0002BD88 File Offset: 0x00029F88
		private static bool n_CanSelectArbitrarily(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMovementMethod>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CanSelectArbitrarily();
		}

		// Token: 0x060010CB RID: 4299 RVA: 0x0002BD97 File Offset: 0x00029F97
		public bool CanSelectArbitrarily()
		{
			if (this.id_canSelectArbitrarily == IntPtr.Zero)
			{
				this.id_canSelectArbitrarily = JNIEnv.GetMethodID(this.class_ref, "canSelectArbitrarily", "()Z");
			}
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_canSelectArbitrarily);
		}

		// Token: 0x060010CC RID: 4300 RVA: 0x0002BDD7 File Offset: 0x00029FD7
		private static Delegate GetInitialize_Landroid_widget_TextView_Landroid_text_Spannable_Handler()
		{
			if (IMovementMethodInvoker.cb_initialize_Landroid_widget_TextView_Landroid_text_Spannable_ == null)
			{
				IMovementMethodInvoker.cb_initialize_Landroid_widget_TextView_Landroid_text_Spannable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IMovementMethodInvoker.n_Initialize_Landroid_widget_TextView_Landroid_text_Spannable_));
			}
			return IMovementMethodInvoker.cb_initialize_Landroid_widget_TextView_Landroid_text_Spannable_;
		}

		// Token: 0x060010CD RID: 4301 RVA: 0x0002BDFC File Offset: 0x00029FFC
		private static void n_Initialize_Landroid_widget_TextView_Landroid_text_Spannable_(IntPtr jnienv, IntPtr native__this, IntPtr native_widget, IntPtr native_text)
		{
			IMovementMethod @object = Java.Lang.Object.GetObject<IMovementMethod>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TextView object2 = Java.Lang.Object.GetObject<TextView>(native_widget, JniHandleOwnership.DoNotTransfer);
			ISpannable object3 = Java.Lang.Object.GetObject<ISpannable>(native_text, JniHandleOwnership.DoNotTransfer);
			@object.Initialize(object2, object3);
		}

		// Token: 0x060010CE RID: 4302 RVA: 0x0002BE28 File Offset: 0x0002A028
		public unsafe void Initialize(TextView widget, ISpannable text)
		{
			if (this.id_initialize_Landroid_widget_TextView_Landroid_text_Spannable_ == IntPtr.Zero)
			{
				this.id_initialize_Landroid_widget_TextView_Landroid_text_Spannable_ = JNIEnv.GetMethodID(this.class_ref, "initialize", "(Landroid/widget/TextView;Landroid/text/Spannable;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((widget == null) ? IntPtr.Zero : widget.Handle);
			ptr[1] = new JValue((text == null) ? IntPtr.Zero : ((Java.Lang.Object)text).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_initialize_Landroid_widget_TextView_Landroid_text_Spannable_, ptr);
		}

		// Token: 0x060010CF RID: 4303 RVA: 0x0002BEC2 File Offset: 0x0002A0C2
		private static Delegate GetOnGenericMotionEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_Handler()
		{
			if (IMovementMethodInvoker.cb_onGenericMotionEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_ == null)
			{
				IMovementMethodInvoker.cb_onGenericMotionEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_Z(IMovementMethodInvoker.n_OnGenericMotionEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_));
			}
			return IMovementMethodInvoker.cb_onGenericMotionEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_;
		}

		// Token: 0x060010D0 RID: 4304 RVA: 0x0002BEE8 File Offset: 0x0002A0E8
		private static bool n_OnGenericMotionEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_widget, IntPtr native_text, IntPtr native_e)
		{
			IMovementMethod @object = Java.Lang.Object.GetObject<IMovementMethod>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TextView object2 = Java.Lang.Object.GetObject<TextView>(native_widget, JniHandleOwnership.DoNotTransfer);
			ISpannable object3 = Java.Lang.Object.GetObject<ISpannable>(native_text, JniHandleOwnership.DoNotTransfer);
			MotionEvent object4 = Java.Lang.Object.GetObject<MotionEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.OnGenericMotionEvent(object2, object3, object4);
		}

		// Token: 0x060010D1 RID: 4305 RVA: 0x0002BF20 File Offset: 0x0002A120
		public unsafe bool OnGenericMotionEvent(TextView widget, ISpannable text, MotionEvent e)
		{
			if (this.id_onGenericMotionEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_ == IntPtr.Zero)
			{
				this.id_onGenericMotionEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID(this.class_ref, "onGenericMotionEvent", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/MotionEvent;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((widget == null) ? IntPtr.Zero : widget.Handle);
			ptr[1] = new JValue((text == null) ? IntPtr.Zero : ((Java.Lang.Object)text).Handle);
			ptr[2] = new JValue((e == null) ? IntPtr.Zero : e.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_onGenericMotionEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_, ptr);
		}

		// Token: 0x060010D2 RID: 4306 RVA: 0x0002BFDF File Offset: 0x0002A1DF
		private static Delegate GetOnKeyDown_Landroid_widget_TextView_Landroid_text_Spannable_ILandroid_view_KeyEvent_Handler()
		{
			if (IMovementMethodInvoker.cb_onKeyDown_Landroid_widget_TextView_Landroid_text_Spannable_ILandroid_view_KeyEvent_ == null)
			{
				IMovementMethodInvoker.cb_onKeyDown_Landroid_widget_TextView_Landroid_text_Spannable_ILandroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLIL_Z(IMovementMethodInvoker.n_OnKeyDown_Landroid_widget_TextView_Landroid_text_Spannable_ILandroid_view_KeyEvent_));
			}
			return IMovementMethodInvoker.cb_onKeyDown_Landroid_widget_TextView_Landroid_text_Spannable_ILandroid_view_KeyEvent_;
		}

		// Token: 0x060010D3 RID: 4307 RVA: 0x0002C004 File Offset: 0x0002A204
		private static bool n_OnKeyDown_Landroid_widget_TextView_Landroid_text_Spannable_ILandroid_view_KeyEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_widget, IntPtr native_text, int native_keyCode, IntPtr native_e)
		{
			IMovementMethod @object = Java.Lang.Object.GetObject<IMovementMethod>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TextView object2 = Java.Lang.Object.GetObject<TextView>(native_widget, JniHandleOwnership.DoNotTransfer);
			ISpannable object3 = Java.Lang.Object.GetObject<ISpannable>(native_text, JniHandleOwnership.DoNotTransfer);
			KeyEvent object4 = Java.Lang.Object.GetObject<KeyEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.OnKeyDown(object2, object3, (Keycode)native_keyCode, object4);
		}

		// Token: 0x060010D4 RID: 4308 RVA: 0x0002C040 File Offset: 0x0002A240
		public unsafe bool OnKeyDown(TextView widget, ISpannable text, [GeneratedEnum] Keycode keyCode, KeyEvent e)
		{
			if (this.id_onKeyDown_Landroid_widget_TextView_Landroid_text_Spannable_ILandroid_view_KeyEvent_ == IntPtr.Zero)
			{
				this.id_onKeyDown_Landroid_widget_TextView_Landroid_text_Spannable_ILandroid_view_KeyEvent_ = JNIEnv.GetMethodID(this.class_ref, "onKeyDown", "(Landroid/widget/TextView;Landroid/text/Spannable;ILandroid/view/KeyEvent;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((widget == null) ? IntPtr.Zero : widget.Handle);
			ptr[1] = new JValue((text == null) ? IntPtr.Zero : ((Java.Lang.Object)text).Handle);
			ptr[2] = new JValue((int)keyCode);
			ptr[3] = new JValue((e == null) ? IntPtr.Zero : e.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_onKeyDown_Landroid_widget_TextView_Landroid_text_Spannable_ILandroid_view_KeyEvent_, ptr);
		}

		// Token: 0x060010D5 RID: 4309 RVA: 0x0002C117 File Offset: 0x0002A317
		private static Delegate GetOnKeyOther_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_KeyEvent_Handler()
		{
			if (IMovementMethodInvoker.cb_onKeyOther_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_KeyEvent_ == null)
			{
				IMovementMethodInvoker.cb_onKeyOther_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_Z(IMovementMethodInvoker.n_OnKeyOther_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_KeyEvent_));
			}
			return IMovementMethodInvoker.cb_onKeyOther_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_KeyEvent_;
		}

		// Token: 0x060010D6 RID: 4310 RVA: 0x0002C13C File Offset: 0x0002A33C
		private static bool n_OnKeyOther_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_KeyEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_view, IntPtr native_text, IntPtr native_e)
		{
			IMovementMethod @object = Java.Lang.Object.GetObject<IMovementMethod>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TextView object2 = Java.Lang.Object.GetObject<TextView>(native_view, JniHandleOwnership.DoNotTransfer);
			ISpannable object3 = Java.Lang.Object.GetObject<ISpannable>(native_text, JniHandleOwnership.DoNotTransfer);
			KeyEvent object4 = Java.Lang.Object.GetObject<KeyEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.OnKeyOther(object2, object3, object4);
		}

		// Token: 0x060010D7 RID: 4311 RVA: 0x0002C174 File Offset: 0x0002A374
		public unsafe bool OnKeyOther(TextView view, ISpannable text, KeyEvent e)
		{
			if (this.id_onKeyOther_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_KeyEvent_ == IntPtr.Zero)
			{
				this.id_onKeyOther_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_KeyEvent_ = JNIEnv.GetMethodID(this.class_ref, "onKeyOther", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/KeyEvent;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((view == null) ? IntPtr.Zero : view.Handle);
			ptr[1] = new JValue((text == null) ? IntPtr.Zero : ((Java.Lang.Object)text).Handle);
			ptr[2] = new JValue((e == null) ? IntPtr.Zero : e.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_onKeyOther_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_KeyEvent_, ptr);
		}

		// Token: 0x060010D8 RID: 4312 RVA: 0x0002C233 File Offset: 0x0002A433
		private static Delegate GetOnKeyUp_Landroid_widget_TextView_Landroid_text_Spannable_ILandroid_view_KeyEvent_Handler()
		{
			if (IMovementMethodInvoker.cb_onKeyUp_Landroid_widget_TextView_Landroid_text_Spannable_ILandroid_view_KeyEvent_ == null)
			{
				IMovementMethodInvoker.cb_onKeyUp_Landroid_widget_TextView_Landroid_text_Spannable_ILandroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLIL_Z(IMovementMethodInvoker.n_OnKeyUp_Landroid_widget_TextView_Landroid_text_Spannable_ILandroid_view_KeyEvent_));
			}
			return IMovementMethodInvoker.cb_onKeyUp_Landroid_widget_TextView_Landroid_text_Spannable_ILandroid_view_KeyEvent_;
		}

		// Token: 0x060010D9 RID: 4313 RVA: 0x0002C258 File Offset: 0x0002A458
		private static bool n_OnKeyUp_Landroid_widget_TextView_Landroid_text_Spannable_ILandroid_view_KeyEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_widget, IntPtr native_text, int native_keyCode, IntPtr native_e)
		{
			IMovementMethod @object = Java.Lang.Object.GetObject<IMovementMethod>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TextView object2 = Java.Lang.Object.GetObject<TextView>(native_widget, JniHandleOwnership.DoNotTransfer);
			ISpannable object3 = Java.Lang.Object.GetObject<ISpannable>(native_text, JniHandleOwnership.DoNotTransfer);
			KeyEvent object4 = Java.Lang.Object.GetObject<KeyEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.OnKeyUp(object2, object3, (Keycode)native_keyCode, object4);
		}

		// Token: 0x060010DA RID: 4314 RVA: 0x0002C294 File Offset: 0x0002A494
		public unsafe bool OnKeyUp(TextView widget, ISpannable text, [GeneratedEnum] Keycode keyCode, KeyEvent e)
		{
			if (this.id_onKeyUp_Landroid_widget_TextView_Landroid_text_Spannable_ILandroid_view_KeyEvent_ == IntPtr.Zero)
			{
				this.id_onKeyUp_Landroid_widget_TextView_Landroid_text_Spannable_ILandroid_view_KeyEvent_ = JNIEnv.GetMethodID(this.class_ref, "onKeyUp", "(Landroid/widget/TextView;Landroid/text/Spannable;ILandroid/view/KeyEvent;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((widget == null) ? IntPtr.Zero : widget.Handle);
			ptr[1] = new JValue((text == null) ? IntPtr.Zero : ((Java.Lang.Object)text).Handle);
			ptr[2] = new JValue((int)keyCode);
			ptr[3] = new JValue((e == null) ? IntPtr.Zero : e.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_onKeyUp_Landroid_widget_TextView_Landroid_text_Spannable_ILandroid_view_KeyEvent_, ptr);
		}

		// Token: 0x060010DB RID: 4315 RVA: 0x0002C36B File Offset: 0x0002A56B
		private static Delegate GetOnTakeFocus_Landroid_widget_TextView_Landroid_text_Spannable_IHandler()
		{
			if (IMovementMethodInvoker.cb_onTakeFocus_Landroid_widget_TextView_Landroid_text_Spannable_I == null)
			{
				IMovementMethodInvoker.cb_onTakeFocus_Landroid_widget_TextView_Landroid_text_Spannable_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLI_V(IMovementMethodInvoker.n_OnTakeFocus_Landroid_widget_TextView_Landroid_text_Spannable_I));
			}
			return IMovementMethodInvoker.cb_onTakeFocus_Landroid_widget_TextView_Landroid_text_Spannable_I;
		}

		// Token: 0x060010DC RID: 4316 RVA: 0x0002C390 File Offset: 0x0002A590
		private static void n_OnTakeFocus_Landroid_widget_TextView_Landroid_text_Spannable_I(IntPtr jnienv, IntPtr native__this, IntPtr native_widget, IntPtr native_text, int native_direction)
		{
			IMovementMethod @object = Java.Lang.Object.GetObject<IMovementMethod>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TextView object2 = Java.Lang.Object.GetObject<TextView>(native_widget, JniHandleOwnership.DoNotTransfer);
			ISpannable object3 = Java.Lang.Object.GetObject<ISpannable>(native_text, JniHandleOwnership.DoNotTransfer);
			@object.OnTakeFocus(object2, object3, (FocusSearchDirection)native_direction);
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x0002C3C0 File Offset: 0x0002A5C0
		public unsafe void OnTakeFocus(TextView widget, ISpannable text, [GeneratedEnum] FocusSearchDirection direction)
		{
			if (this.id_onTakeFocus_Landroid_widget_TextView_Landroid_text_Spannable_I == IntPtr.Zero)
			{
				this.id_onTakeFocus_Landroid_widget_TextView_Landroid_text_Spannable_I = JNIEnv.GetMethodID(this.class_ref, "onTakeFocus", "(Landroid/widget/TextView;Landroid/text/Spannable;I)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((widget == null) ? IntPtr.Zero : widget.Handle);
			ptr[1] = new JValue((text == null) ? IntPtr.Zero : ((Java.Lang.Object)text).Handle);
			ptr[2] = new JValue((int)direction);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onTakeFocus_Landroid_widget_TextView_Landroid_text_Spannable_I, ptr);
		}

		// Token: 0x060010DE RID: 4318 RVA: 0x0002C470 File Offset: 0x0002A670
		private static Delegate GetOnTouchEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_Handler()
		{
			if (IMovementMethodInvoker.cb_onTouchEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_ == null)
			{
				IMovementMethodInvoker.cb_onTouchEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_Z(IMovementMethodInvoker.n_OnTouchEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_));
			}
			return IMovementMethodInvoker.cb_onTouchEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_;
		}

		// Token: 0x060010DF RID: 4319 RVA: 0x0002C494 File Offset: 0x0002A694
		private static bool n_OnTouchEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_widget, IntPtr native_text, IntPtr native_e)
		{
			IMovementMethod @object = Java.Lang.Object.GetObject<IMovementMethod>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TextView object2 = Java.Lang.Object.GetObject<TextView>(native_widget, JniHandleOwnership.DoNotTransfer);
			ISpannable object3 = Java.Lang.Object.GetObject<ISpannable>(native_text, JniHandleOwnership.DoNotTransfer);
			MotionEvent object4 = Java.Lang.Object.GetObject<MotionEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.OnTouchEvent(object2, object3, object4);
		}

		// Token: 0x060010E0 RID: 4320 RVA: 0x0002C4CC File Offset: 0x0002A6CC
		public unsafe bool OnTouchEvent(TextView widget, ISpannable text, MotionEvent e)
		{
			if (this.id_onTouchEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_ == IntPtr.Zero)
			{
				this.id_onTouchEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID(this.class_ref, "onTouchEvent", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/MotionEvent;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((widget == null) ? IntPtr.Zero : widget.Handle);
			ptr[1] = new JValue((text == null) ? IntPtr.Zero : ((Java.Lang.Object)text).Handle);
			ptr[2] = new JValue((e == null) ? IntPtr.Zero : e.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_onTouchEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_, ptr);
		}

		// Token: 0x060010E1 RID: 4321 RVA: 0x0002C58B File Offset: 0x0002A78B
		private static Delegate GetOnTrackballEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_Handler()
		{
			if (IMovementMethodInvoker.cb_onTrackballEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_ == null)
			{
				IMovementMethodInvoker.cb_onTrackballEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_Z(IMovementMethodInvoker.n_OnTrackballEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_));
			}
			return IMovementMethodInvoker.cb_onTrackballEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_;
		}

		// Token: 0x060010E2 RID: 4322 RVA: 0x0002C5B0 File Offset: 0x0002A7B0
		private static bool n_OnTrackballEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_widget, IntPtr native_text, IntPtr native_e)
		{
			IMovementMethod @object = Java.Lang.Object.GetObject<IMovementMethod>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TextView object2 = Java.Lang.Object.GetObject<TextView>(native_widget, JniHandleOwnership.DoNotTransfer);
			ISpannable object3 = Java.Lang.Object.GetObject<ISpannable>(native_text, JniHandleOwnership.DoNotTransfer);
			MotionEvent object4 = Java.Lang.Object.GetObject<MotionEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.OnTrackballEvent(object2, object3, object4);
		}

		// Token: 0x060010E3 RID: 4323 RVA: 0x0002C5E8 File Offset: 0x0002A7E8
		public unsafe bool OnTrackballEvent(TextView widget, ISpannable text, MotionEvent e)
		{
			if (this.id_onTrackballEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_ == IntPtr.Zero)
			{
				this.id_onTrackballEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID(this.class_ref, "onTrackballEvent", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/MotionEvent;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((widget == null) ? IntPtr.Zero : widget.Handle);
			ptr[1] = new JValue((text == null) ? IntPtr.Zero : ((Java.Lang.Object)text).Handle);
			ptr[2] = new JValue((e == null) ? IntPtr.Zero : e.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_onTrackballEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_, ptr);
		}

		// Token: 0x0400079C RID: 1948
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/text/method/MovementMethod", typeof(IMovementMethodInvoker));

		// Token: 0x0400079D RID: 1949
		private IntPtr class_ref;

		// Token: 0x0400079E RID: 1950
		private static Delegate cb_canSelectArbitrarily;

		// Token: 0x0400079F RID: 1951
		private IntPtr id_canSelectArbitrarily;

		// Token: 0x040007A0 RID: 1952
		private static Delegate cb_initialize_Landroid_widget_TextView_Landroid_text_Spannable_;

		// Token: 0x040007A1 RID: 1953
		private IntPtr id_initialize_Landroid_widget_TextView_Landroid_text_Spannable_;

		// Token: 0x040007A2 RID: 1954
		private static Delegate cb_onGenericMotionEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_;

		// Token: 0x040007A3 RID: 1955
		private IntPtr id_onGenericMotionEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_;

		// Token: 0x040007A4 RID: 1956
		private static Delegate cb_onKeyDown_Landroid_widget_TextView_Landroid_text_Spannable_ILandroid_view_KeyEvent_;

		// Token: 0x040007A5 RID: 1957
		private IntPtr id_onKeyDown_Landroid_widget_TextView_Landroid_text_Spannable_ILandroid_view_KeyEvent_;

		// Token: 0x040007A6 RID: 1958
		private static Delegate cb_onKeyOther_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_KeyEvent_;

		// Token: 0x040007A7 RID: 1959
		private IntPtr id_onKeyOther_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_KeyEvent_;

		// Token: 0x040007A8 RID: 1960
		private static Delegate cb_onKeyUp_Landroid_widget_TextView_Landroid_text_Spannable_ILandroid_view_KeyEvent_;

		// Token: 0x040007A9 RID: 1961
		private IntPtr id_onKeyUp_Landroid_widget_TextView_Landroid_text_Spannable_ILandroid_view_KeyEvent_;

		// Token: 0x040007AA RID: 1962
		private static Delegate cb_onTakeFocus_Landroid_widget_TextView_Landroid_text_Spannable_I;

		// Token: 0x040007AB RID: 1963
		private IntPtr id_onTakeFocus_Landroid_widget_TextView_Landroid_text_Spannable_I;

		// Token: 0x040007AC RID: 1964
		private static Delegate cb_onTouchEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_;

		// Token: 0x040007AD RID: 1965
		private IntPtr id_onTouchEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_;

		// Token: 0x040007AE RID: 1966
		private static Delegate cb_onTrackballEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_;

		// Token: 0x040007AF RID: 1967
		private IntPtr id_onTrackballEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_;
	}
}
