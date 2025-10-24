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
	// Token: 0x020001CE RID: 462
	[Register("android/text/method/BaseMovementMethod", DoNotGenerateAcw = true)]
	public class BaseMovementMethod : Java.Lang.Object, IMovementMethod, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06001099 RID: 4249 RVA: 0x0002B333 File Offset: 0x00029533
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BaseMovementMethod._members;
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x0600109A RID: 4250 RVA: 0x0002B33C File Offset: 0x0002953C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BaseMovementMethod._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x0600109B RID: 4251 RVA: 0x0002B360 File Offset: 0x00029560
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BaseMovementMethod._members.ManagedPeerType;
			}
		}

		// Token: 0x0600109C RID: 4252 RVA: 0x000021E0 File Offset: 0x000003E0
		protected BaseMovementMethod(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600109D RID: 4253 RVA: 0x0002B36C File Offset: 0x0002956C
		private static Delegate GetCanSelectArbitrarilyHandler()
		{
			if (BaseMovementMethod.cb_canSelectArbitrarily == null)
			{
				BaseMovementMethod.cb_canSelectArbitrarily = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(BaseMovementMethod.n_CanSelectArbitrarily));
			}
			return BaseMovementMethod.cb_canSelectArbitrarily;
		}

		// Token: 0x0600109E RID: 4254 RVA: 0x0002B390 File Offset: 0x00029590
		private static bool n_CanSelectArbitrarily(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BaseMovementMethod>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CanSelectArbitrarily();
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x0002B39F File Offset: 0x0002959F
		public virtual bool CanSelectArbitrarily()
		{
			return BaseMovementMethod._members.InstanceMethods.InvokeVirtualBooleanMethod("canSelectArbitrarily.()Z", this, null);
		}

		// Token: 0x060010A0 RID: 4256 RVA: 0x0002B3B8 File Offset: 0x000295B8
		private static Delegate GetInitialize_Landroid_widget_TextView_Landroid_text_Spannable_Handler()
		{
			if (BaseMovementMethod.cb_initialize_Landroid_widget_TextView_Landroid_text_Spannable_ == null)
			{
				BaseMovementMethod.cb_initialize_Landroid_widget_TextView_Landroid_text_Spannable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(BaseMovementMethod.n_Initialize_Landroid_widget_TextView_Landroid_text_Spannable_));
			}
			return BaseMovementMethod.cb_initialize_Landroid_widget_TextView_Landroid_text_Spannable_;
		}

		// Token: 0x060010A1 RID: 4257 RVA: 0x0002B3DC File Offset: 0x000295DC
		private static void n_Initialize_Landroid_widget_TextView_Landroid_text_Spannable_(IntPtr jnienv, IntPtr native__this, IntPtr native_widget, IntPtr native_text)
		{
			BaseMovementMethod @object = Java.Lang.Object.GetObject<BaseMovementMethod>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TextView object2 = Java.Lang.Object.GetObject<TextView>(native_widget, JniHandleOwnership.DoNotTransfer);
			ISpannable object3 = Java.Lang.Object.GetObject<ISpannable>(native_text, JniHandleOwnership.DoNotTransfer);
			@object.Initialize(object2, object3);
		}

		// Token: 0x060010A2 RID: 4258 RVA: 0x0002B408 File Offset: 0x00029608
		public unsafe virtual void Initialize(TextView widget, ISpannable text)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((widget == null) ? IntPtr.Zero : widget.Handle);
				ptr[1] = new JniArgumentValue((text == null) ? IntPtr.Zero : ((Java.Lang.Object)text).Handle);
				BaseMovementMethod._members.InstanceMethods.InvokeVirtualVoidMethod("initialize.(Landroid/widget/TextView;Landroid/text/Spannable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(widget);
				GC.KeepAlive(text);
			}
		}

		// Token: 0x060010A3 RID: 4259 RVA: 0x0002B498 File Offset: 0x00029698
		private static Delegate GetOnGenericMotionEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_Handler()
		{
			if (BaseMovementMethod.cb_onGenericMotionEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_ == null)
			{
				BaseMovementMethod.cb_onGenericMotionEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_Z(BaseMovementMethod.n_OnGenericMotionEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_));
			}
			return BaseMovementMethod.cb_onGenericMotionEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_;
		}

		// Token: 0x060010A4 RID: 4260 RVA: 0x0002B4BC File Offset: 0x000296BC
		private static bool n_OnGenericMotionEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_widget, IntPtr native_text, IntPtr native_e)
		{
			BaseMovementMethod @object = Java.Lang.Object.GetObject<BaseMovementMethod>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TextView object2 = Java.Lang.Object.GetObject<TextView>(native_widget, JniHandleOwnership.DoNotTransfer);
			ISpannable object3 = Java.Lang.Object.GetObject<ISpannable>(native_text, JniHandleOwnership.DoNotTransfer);
			MotionEvent object4 = Java.Lang.Object.GetObject<MotionEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.OnGenericMotionEvent(object2, object3, object4);
		}

		// Token: 0x060010A5 RID: 4261 RVA: 0x0002B4F4 File Offset: 0x000296F4
		public unsafe virtual bool OnGenericMotionEvent(TextView widget, ISpannable text, MotionEvent e)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((widget == null) ? IntPtr.Zero : widget.Handle);
				ptr[1] = new JniArgumentValue((text == null) ? IntPtr.Zero : ((Java.Lang.Object)text).Handle);
				ptr[2] = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				result = BaseMovementMethod._members.InstanceMethods.InvokeVirtualBooleanMethod("onGenericMotionEvent.(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/MotionEvent;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(widget);
				GC.KeepAlive(text);
				GC.KeepAlive(e);
			}
			return result;
		}

		// Token: 0x060010A6 RID: 4262 RVA: 0x0002B5B4 File Offset: 0x000297B4
		private static Delegate GetOnKeyDown_Landroid_widget_TextView_Landroid_text_Spannable_ILandroid_view_KeyEvent_Handler()
		{
			if (BaseMovementMethod.cb_onKeyDown_Landroid_widget_TextView_Landroid_text_Spannable_ILandroid_view_KeyEvent_ == null)
			{
				BaseMovementMethod.cb_onKeyDown_Landroid_widget_TextView_Landroid_text_Spannable_ILandroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLIL_Z(BaseMovementMethod.n_OnKeyDown_Landroid_widget_TextView_Landroid_text_Spannable_ILandroid_view_KeyEvent_));
			}
			return BaseMovementMethod.cb_onKeyDown_Landroid_widget_TextView_Landroid_text_Spannable_ILandroid_view_KeyEvent_;
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x0002B5D8 File Offset: 0x000297D8
		private static bool n_OnKeyDown_Landroid_widget_TextView_Landroid_text_Spannable_ILandroid_view_KeyEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_widget, IntPtr native_text, int native_keyCode, IntPtr native_e)
		{
			BaseMovementMethod @object = Java.Lang.Object.GetObject<BaseMovementMethod>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TextView object2 = Java.Lang.Object.GetObject<TextView>(native_widget, JniHandleOwnership.DoNotTransfer);
			ISpannable object3 = Java.Lang.Object.GetObject<ISpannable>(native_text, JniHandleOwnership.DoNotTransfer);
			KeyEvent object4 = Java.Lang.Object.GetObject<KeyEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.OnKeyDown(object2, object3, (Keycode)native_keyCode, object4);
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x0002B614 File Offset: 0x00029814
		public unsafe virtual bool OnKeyDown(TextView widget, ISpannable text, [GeneratedEnum] Keycode keyCode, KeyEvent e)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((widget == null) ? IntPtr.Zero : widget.Handle);
				ptr[1] = new JniArgumentValue((text == null) ? IntPtr.Zero : ((Java.Lang.Object)text).Handle);
				ptr[2] = new JniArgumentValue((int)keyCode);
				ptr[3] = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				result = BaseMovementMethod._members.InstanceMethods.InvokeVirtualBooleanMethod("onKeyDown.(Landroid/widget/TextView;Landroid/text/Spannable;ILandroid/view/KeyEvent;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(widget);
				GC.KeepAlive(text);
				GC.KeepAlive(e);
			}
			return result;
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x0002B6EC File Offset: 0x000298EC
		private static Delegate GetOnKeyOther_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_KeyEvent_Handler()
		{
			if (BaseMovementMethod.cb_onKeyOther_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_KeyEvent_ == null)
			{
				BaseMovementMethod.cb_onKeyOther_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_Z(BaseMovementMethod.n_OnKeyOther_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_KeyEvent_));
			}
			return BaseMovementMethod.cb_onKeyOther_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_KeyEvent_;
		}

		// Token: 0x060010AA RID: 4266 RVA: 0x0002B710 File Offset: 0x00029910
		private static bool n_OnKeyOther_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_KeyEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_widget, IntPtr native_text, IntPtr native_e)
		{
			BaseMovementMethod @object = Java.Lang.Object.GetObject<BaseMovementMethod>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TextView object2 = Java.Lang.Object.GetObject<TextView>(native_widget, JniHandleOwnership.DoNotTransfer);
			ISpannable object3 = Java.Lang.Object.GetObject<ISpannable>(native_text, JniHandleOwnership.DoNotTransfer);
			KeyEvent object4 = Java.Lang.Object.GetObject<KeyEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.OnKeyOther(object2, object3, object4);
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x0002B748 File Offset: 0x00029948
		public unsafe virtual bool OnKeyOther(TextView widget, ISpannable text, KeyEvent e)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((widget == null) ? IntPtr.Zero : widget.Handle);
				ptr[1] = new JniArgumentValue((text == null) ? IntPtr.Zero : ((Java.Lang.Object)text).Handle);
				ptr[2] = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				result = BaseMovementMethod._members.InstanceMethods.InvokeVirtualBooleanMethod("onKeyOther.(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/KeyEvent;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(widget);
				GC.KeepAlive(text);
				GC.KeepAlive(e);
			}
			return result;
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x0002B808 File Offset: 0x00029A08
		private static Delegate GetOnKeyUp_Landroid_widget_TextView_Landroid_text_Spannable_ILandroid_view_KeyEvent_Handler()
		{
			if (BaseMovementMethod.cb_onKeyUp_Landroid_widget_TextView_Landroid_text_Spannable_ILandroid_view_KeyEvent_ == null)
			{
				BaseMovementMethod.cb_onKeyUp_Landroid_widget_TextView_Landroid_text_Spannable_ILandroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLIL_Z(BaseMovementMethod.n_OnKeyUp_Landroid_widget_TextView_Landroid_text_Spannable_ILandroid_view_KeyEvent_));
			}
			return BaseMovementMethod.cb_onKeyUp_Landroid_widget_TextView_Landroid_text_Spannable_ILandroid_view_KeyEvent_;
		}

		// Token: 0x060010AD RID: 4269 RVA: 0x0002B82C File Offset: 0x00029A2C
		private static bool n_OnKeyUp_Landroid_widget_TextView_Landroid_text_Spannable_ILandroid_view_KeyEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_widget, IntPtr native_text, int native_keyCode, IntPtr native_e)
		{
			BaseMovementMethod @object = Java.Lang.Object.GetObject<BaseMovementMethod>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TextView object2 = Java.Lang.Object.GetObject<TextView>(native_widget, JniHandleOwnership.DoNotTransfer);
			ISpannable object3 = Java.Lang.Object.GetObject<ISpannable>(native_text, JniHandleOwnership.DoNotTransfer);
			KeyEvent object4 = Java.Lang.Object.GetObject<KeyEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.OnKeyUp(object2, object3, (Keycode)native_keyCode, object4);
		}

		// Token: 0x060010AE RID: 4270 RVA: 0x0002B868 File Offset: 0x00029A68
		public unsafe virtual bool OnKeyUp(TextView widget, ISpannable text, [GeneratedEnum] Keycode keyCode, KeyEvent e)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((widget == null) ? IntPtr.Zero : widget.Handle);
				ptr[1] = new JniArgumentValue((text == null) ? IntPtr.Zero : ((Java.Lang.Object)text).Handle);
				ptr[2] = new JniArgumentValue((int)keyCode);
				ptr[3] = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				result = BaseMovementMethod._members.InstanceMethods.InvokeVirtualBooleanMethod("onKeyUp.(Landroid/widget/TextView;Landroid/text/Spannable;ILandroid/view/KeyEvent;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(widget);
				GC.KeepAlive(text);
				GC.KeepAlive(e);
			}
			return result;
		}

		// Token: 0x060010AF RID: 4271 RVA: 0x0002B940 File Offset: 0x00029B40
		private static Delegate GetOnTakeFocus_Landroid_widget_TextView_Landroid_text_Spannable_IHandler()
		{
			if (BaseMovementMethod.cb_onTakeFocus_Landroid_widget_TextView_Landroid_text_Spannable_I == null)
			{
				BaseMovementMethod.cb_onTakeFocus_Landroid_widget_TextView_Landroid_text_Spannable_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLI_V(BaseMovementMethod.n_OnTakeFocus_Landroid_widget_TextView_Landroid_text_Spannable_I));
			}
			return BaseMovementMethod.cb_onTakeFocus_Landroid_widget_TextView_Landroid_text_Spannable_I;
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x0002B964 File Offset: 0x00029B64
		private static void n_OnTakeFocus_Landroid_widget_TextView_Landroid_text_Spannable_I(IntPtr jnienv, IntPtr native__this, IntPtr native_widget, IntPtr native_text, int native_direction)
		{
			BaseMovementMethod @object = Java.Lang.Object.GetObject<BaseMovementMethod>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TextView object2 = Java.Lang.Object.GetObject<TextView>(native_widget, JniHandleOwnership.DoNotTransfer);
			ISpannable object3 = Java.Lang.Object.GetObject<ISpannable>(native_text, JniHandleOwnership.DoNotTransfer);
			@object.OnTakeFocus(object2, object3, (FocusSearchDirection)native_direction);
		}

		// Token: 0x060010B1 RID: 4273 RVA: 0x0002B994 File Offset: 0x00029B94
		public unsafe virtual void OnTakeFocus(TextView widget, ISpannable text, [GeneratedEnum] FocusSearchDirection direction)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((widget == null) ? IntPtr.Zero : widget.Handle);
				ptr[1] = new JniArgumentValue((text == null) ? IntPtr.Zero : ((Java.Lang.Object)text).Handle);
				ptr[2] = new JniArgumentValue((int)direction);
				BaseMovementMethod._members.InstanceMethods.InvokeVirtualVoidMethod("onTakeFocus.(Landroid/widget/TextView;Landroid/text/Spannable;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(widget);
				GC.KeepAlive(text);
			}
		}

		// Token: 0x060010B2 RID: 4274 RVA: 0x0002BA3C File Offset: 0x00029C3C
		private static Delegate GetOnTouchEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_Handler()
		{
			if (BaseMovementMethod.cb_onTouchEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_ == null)
			{
				BaseMovementMethod.cb_onTouchEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_Z(BaseMovementMethod.n_OnTouchEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_));
			}
			return BaseMovementMethod.cb_onTouchEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_;
		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x0002BA60 File Offset: 0x00029C60
		private static bool n_OnTouchEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_widget, IntPtr native_text, IntPtr native_e)
		{
			BaseMovementMethod @object = Java.Lang.Object.GetObject<BaseMovementMethod>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TextView object2 = Java.Lang.Object.GetObject<TextView>(native_widget, JniHandleOwnership.DoNotTransfer);
			ISpannable object3 = Java.Lang.Object.GetObject<ISpannable>(native_text, JniHandleOwnership.DoNotTransfer);
			MotionEvent object4 = Java.Lang.Object.GetObject<MotionEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.OnTouchEvent(object2, object3, object4);
		}

		// Token: 0x060010B4 RID: 4276 RVA: 0x0002BA98 File Offset: 0x00029C98
		public unsafe virtual bool OnTouchEvent(TextView widget, ISpannable text, MotionEvent e)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((widget == null) ? IntPtr.Zero : widget.Handle);
				ptr[1] = new JniArgumentValue((text == null) ? IntPtr.Zero : ((Java.Lang.Object)text).Handle);
				ptr[2] = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				result = BaseMovementMethod._members.InstanceMethods.InvokeVirtualBooleanMethod("onTouchEvent.(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/MotionEvent;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(widget);
				GC.KeepAlive(text);
				GC.KeepAlive(e);
			}
			return result;
		}

		// Token: 0x060010B5 RID: 4277 RVA: 0x0002BB58 File Offset: 0x00029D58
		private static Delegate GetOnTrackballEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_Handler()
		{
			if (BaseMovementMethod.cb_onTrackballEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_ == null)
			{
				BaseMovementMethod.cb_onTrackballEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_Z(BaseMovementMethod.n_OnTrackballEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_));
			}
			return BaseMovementMethod.cb_onTrackballEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_;
		}

		// Token: 0x060010B6 RID: 4278 RVA: 0x0002BB7C File Offset: 0x00029D7C
		private static bool n_OnTrackballEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_widget, IntPtr native_text, IntPtr native_e)
		{
			BaseMovementMethod @object = Java.Lang.Object.GetObject<BaseMovementMethod>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TextView object2 = Java.Lang.Object.GetObject<TextView>(native_widget, JniHandleOwnership.DoNotTransfer);
			ISpannable object3 = Java.Lang.Object.GetObject<ISpannable>(native_text, JniHandleOwnership.DoNotTransfer);
			MotionEvent object4 = Java.Lang.Object.GetObject<MotionEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.OnTrackballEvent(object2, object3, object4);
		}

		// Token: 0x060010B7 RID: 4279 RVA: 0x0002BBB4 File Offset: 0x00029DB4
		public unsafe virtual bool OnTrackballEvent(TextView widget, ISpannable text, MotionEvent e)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((widget == null) ? IntPtr.Zero : widget.Handle);
				ptr[1] = new JniArgumentValue((text == null) ? IntPtr.Zero : ((Java.Lang.Object)text).Handle);
				ptr[2] = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				result = BaseMovementMethod._members.InstanceMethods.InvokeVirtualBooleanMethod("onTrackballEvent.(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/MotionEvent;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(widget);
				GC.KeepAlive(text);
				GC.KeepAlive(e);
			}
			return result;
		}

		// Token: 0x04000792 RID: 1938
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/text/method/BaseMovementMethod", typeof(BaseMovementMethod));

		// Token: 0x04000793 RID: 1939
		private static Delegate cb_canSelectArbitrarily;

		// Token: 0x04000794 RID: 1940
		private static Delegate cb_initialize_Landroid_widget_TextView_Landroid_text_Spannable_;

		// Token: 0x04000795 RID: 1941
		private static Delegate cb_onGenericMotionEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_;

		// Token: 0x04000796 RID: 1942
		private static Delegate cb_onKeyDown_Landroid_widget_TextView_Landroid_text_Spannable_ILandroid_view_KeyEvent_;

		// Token: 0x04000797 RID: 1943
		private static Delegate cb_onKeyOther_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_KeyEvent_;

		// Token: 0x04000798 RID: 1944
		private static Delegate cb_onKeyUp_Landroid_widget_TextView_Landroid_text_Spannable_ILandroid_view_KeyEvent_;

		// Token: 0x04000799 RID: 1945
		private static Delegate cb_onTakeFocus_Landroid_widget_TextView_Landroid_text_Spannable_I;

		// Token: 0x0400079A RID: 1946
		private static Delegate cb_onTouchEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_;

		// Token: 0x0400079B RID: 1947
		private static Delegate cb_onTrackballEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_;
	}
}
