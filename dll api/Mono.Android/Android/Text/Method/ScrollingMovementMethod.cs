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
	// Token: 0x020001D5 RID: 469
	[Register("android/text/method/ScrollingMovementMethod", DoNotGenerateAcw = true)]
	public class ScrollingMovementMethod : BaseMovementMethod, IMovementMethod, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06001107 RID: 4359 RVA: 0x0002CD7B File Offset: 0x0002AF7B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ScrollingMovementMethod._members;
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06001108 RID: 4360 RVA: 0x0002CD84 File Offset: 0x0002AF84
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ScrollingMovementMethod._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06001109 RID: 4361 RVA: 0x0002CDA8 File Offset: 0x0002AFA8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ScrollingMovementMethod._members.ManagedPeerType;
			}
		}

		// Token: 0x0600110A RID: 4362 RVA: 0x0002CDB4 File Offset: 0x0002AFB4
		protected ScrollingMovementMethod(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600110B RID: 4363 RVA: 0x0002CDBE File Offset: 0x0002AFBE
		private static Delegate GetCanSelectArbitrarilyHandler()
		{
			if (ScrollingMovementMethod.cb_canSelectArbitrarily == null)
			{
				ScrollingMovementMethod.cb_canSelectArbitrarily = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ScrollingMovementMethod.n_CanSelectArbitrarily));
			}
			return ScrollingMovementMethod.cb_canSelectArbitrarily;
		}

		// Token: 0x0600110C RID: 4364 RVA: 0x0002CDE2 File Offset: 0x0002AFE2
		private static bool n_CanSelectArbitrarily(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ScrollingMovementMethod>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CanSelectArbitrarily();
		}

		// Token: 0x0600110D RID: 4365 RVA: 0x0002CDF1 File Offset: 0x0002AFF1
		public override bool CanSelectArbitrarily()
		{
			return ScrollingMovementMethod._members.InstanceMethods.InvokeVirtualBooleanMethod("canSelectArbitrarily.()Z", this, null);
		}

		// Token: 0x0600110E RID: 4366 RVA: 0x0002CE0A File Offset: 0x0002B00A
		private static Delegate GetInitialize_Landroid_widget_TextView_Landroid_text_Spannable_Handler()
		{
			if (ScrollingMovementMethod.cb_initialize_Landroid_widget_TextView_Landroid_text_Spannable_ == null)
			{
				ScrollingMovementMethod.cb_initialize_Landroid_widget_TextView_Landroid_text_Spannable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(ScrollingMovementMethod.n_Initialize_Landroid_widget_TextView_Landroid_text_Spannable_));
			}
			return ScrollingMovementMethod.cb_initialize_Landroid_widget_TextView_Landroid_text_Spannable_;
		}

		// Token: 0x0600110F RID: 4367 RVA: 0x0002CE30 File Offset: 0x0002B030
		private static void n_Initialize_Landroid_widget_TextView_Landroid_text_Spannable_(IntPtr jnienv, IntPtr native__this, IntPtr native_widget, IntPtr native_text)
		{
			BaseMovementMethod @object = Java.Lang.Object.GetObject<ScrollingMovementMethod>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TextView object2 = Java.Lang.Object.GetObject<TextView>(native_widget, JniHandleOwnership.DoNotTransfer);
			ISpannable object3 = Java.Lang.Object.GetObject<ISpannable>(native_text, JniHandleOwnership.DoNotTransfer);
			@object.Initialize(object2, object3);
		}

		// Token: 0x06001110 RID: 4368 RVA: 0x0002CE5C File Offset: 0x0002B05C
		public unsafe override void Initialize(TextView widget, ISpannable text)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((widget == null) ? IntPtr.Zero : widget.Handle);
				ptr[1] = new JniArgumentValue((text == null) ? IntPtr.Zero : ((Java.Lang.Object)text).Handle);
				ScrollingMovementMethod._members.InstanceMethods.InvokeVirtualVoidMethod("initialize.(Landroid/widget/TextView;Landroid/text/Spannable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(widget);
				GC.KeepAlive(text);
			}
		}

		// Token: 0x06001111 RID: 4369 RVA: 0x0002CEEC File Offset: 0x0002B0EC
		private static Delegate GetOnKeyDown_Landroid_widget_TextView_Landroid_text_Spannable_ILandroid_view_KeyEvent_Handler()
		{
			if (ScrollingMovementMethod.cb_onKeyDown_Landroid_widget_TextView_Landroid_text_Spannable_ILandroid_view_KeyEvent_ == null)
			{
				ScrollingMovementMethod.cb_onKeyDown_Landroid_widget_TextView_Landroid_text_Spannable_ILandroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLIL_Z(ScrollingMovementMethod.n_OnKeyDown_Landroid_widget_TextView_Landroid_text_Spannable_ILandroid_view_KeyEvent_));
			}
			return ScrollingMovementMethod.cb_onKeyDown_Landroid_widget_TextView_Landroid_text_Spannable_ILandroid_view_KeyEvent_;
		}

		// Token: 0x06001112 RID: 4370 RVA: 0x0002CF10 File Offset: 0x0002B110
		private static bool n_OnKeyDown_Landroid_widget_TextView_Landroid_text_Spannable_ILandroid_view_KeyEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_widget, IntPtr native_buffer, int native_keyCode, IntPtr native_e)
		{
			BaseMovementMethod @object = Java.Lang.Object.GetObject<ScrollingMovementMethod>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TextView object2 = Java.Lang.Object.GetObject<TextView>(native_widget, JniHandleOwnership.DoNotTransfer);
			ISpannable object3 = Java.Lang.Object.GetObject<ISpannable>(native_buffer, JniHandleOwnership.DoNotTransfer);
			KeyEvent object4 = Java.Lang.Object.GetObject<KeyEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.OnKeyDown(object2, object3, (Keycode)native_keyCode, object4);
		}

		// Token: 0x06001113 RID: 4371 RVA: 0x0002CF4C File Offset: 0x0002B14C
		public unsafe override bool OnKeyDown(TextView widget, ISpannable buffer, [GeneratedEnum] Keycode keyCode, KeyEvent e)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((widget == null) ? IntPtr.Zero : widget.Handle);
				ptr[1] = new JniArgumentValue((buffer == null) ? IntPtr.Zero : ((Java.Lang.Object)buffer).Handle);
				ptr[2] = new JniArgumentValue((int)keyCode);
				ptr[3] = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				result = ScrollingMovementMethod._members.InstanceMethods.InvokeVirtualBooleanMethod("onKeyDown.(Landroid/widget/TextView;Landroid/text/Spannable;ILandroid/view/KeyEvent;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(widget);
				GC.KeepAlive(buffer);
				GC.KeepAlive(e);
			}
			return result;
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x0002D024 File Offset: 0x0002B224
		private static Delegate GetOnKeyOther_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_KeyEvent_Handler()
		{
			if (ScrollingMovementMethod.cb_onKeyOther_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_KeyEvent_ == null)
			{
				ScrollingMovementMethod.cb_onKeyOther_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_Z(ScrollingMovementMethod.n_OnKeyOther_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_KeyEvent_));
			}
			return ScrollingMovementMethod.cb_onKeyOther_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_KeyEvent_;
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x0002D048 File Offset: 0x0002B248
		private static bool n_OnKeyOther_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_KeyEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_view, IntPtr native_text, IntPtr native_e)
		{
			BaseMovementMethod @object = Java.Lang.Object.GetObject<ScrollingMovementMethod>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TextView object2 = Java.Lang.Object.GetObject<TextView>(native_view, JniHandleOwnership.DoNotTransfer);
			ISpannable object3 = Java.Lang.Object.GetObject<ISpannable>(native_text, JniHandleOwnership.DoNotTransfer);
			KeyEvent object4 = Java.Lang.Object.GetObject<KeyEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.OnKeyOther(object2, object3, object4);
		}

		// Token: 0x06001116 RID: 4374 RVA: 0x0002D080 File Offset: 0x0002B280
		public unsafe override bool OnKeyOther(TextView view, ISpannable text, KeyEvent e)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				ptr[1] = new JniArgumentValue((text == null) ? IntPtr.Zero : ((Java.Lang.Object)text).Handle);
				ptr[2] = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				result = ScrollingMovementMethod._members.InstanceMethods.InvokeVirtualBooleanMethod("onKeyOther.(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/KeyEvent;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(view);
				GC.KeepAlive(text);
				GC.KeepAlive(e);
			}
			return result;
		}

		// Token: 0x06001117 RID: 4375 RVA: 0x0002D140 File Offset: 0x0002B340
		private static Delegate GetOnKeyUp_Landroid_widget_TextView_Landroid_text_Spannable_ILandroid_view_KeyEvent_Handler()
		{
			if (ScrollingMovementMethod.cb_onKeyUp_Landroid_widget_TextView_Landroid_text_Spannable_ILandroid_view_KeyEvent_ == null)
			{
				ScrollingMovementMethod.cb_onKeyUp_Landroid_widget_TextView_Landroid_text_Spannable_ILandroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLIL_Z(ScrollingMovementMethod.n_OnKeyUp_Landroid_widget_TextView_Landroid_text_Spannable_ILandroid_view_KeyEvent_));
			}
			return ScrollingMovementMethod.cb_onKeyUp_Landroid_widget_TextView_Landroid_text_Spannable_ILandroid_view_KeyEvent_;
		}

		// Token: 0x06001118 RID: 4376 RVA: 0x0002D164 File Offset: 0x0002B364
		private static bool n_OnKeyUp_Landroid_widget_TextView_Landroid_text_Spannable_ILandroid_view_KeyEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_widget, IntPtr native_buffer, int native_keyCode, IntPtr native_e)
		{
			BaseMovementMethod @object = Java.Lang.Object.GetObject<ScrollingMovementMethod>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TextView object2 = Java.Lang.Object.GetObject<TextView>(native_widget, JniHandleOwnership.DoNotTransfer);
			ISpannable object3 = Java.Lang.Object.GetObject<ISpannable>(native_buffer, JniHandleOwnership.DoNotTransfer);
			KeyEvent object4 = Java.Lang.Object.GetObject<KeyEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.OnKeyUp(object2, object3, (Keycode)native_keyCode, object4);
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x0002D1A0 File Offset: 0x0002B3A0
		public unsafe override bool OnKeyUp(TextView widget, ISpannable buffer, [GeneratedEnum] Keycode keyCode, KeyEvent e)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((widget == null) ? IntPtr.Zero : widget.Handle);
				ptr[1] = new JniArgumentValue((buffer == null) ? IntPtr.Zero : ((Java.Lang.Object)buffer).Handle);
				ptr[2] = new JniArgumentValue((int)keyCode);
				ptr[3] = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				result = ScrollingMovementMethod._members.InstanceMethods.InvokeVirtualBooleanMethod("onKeyUp.(Landroid/widget/TextView;Landroid/text/Spannable;ILandroid/view/KeyEvent;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(widget);
				GC.KeepAlive(buffer);
				GC.KeepAlive(e);
			}
			return result;
		}

		// Token: 0x0600111A RID: 4378 RVA: 0x0002D278 File Offset: 0x0002B478
		private static Delegate GetOnTakeFocus_Landroid_widget_TextView_Landroid_text_Spannable_IHandler()
		{
			if (ScrollingMovementMethod.cb_onTakeFocus_Landroid_widget_TextView_Landroid_text_Spannable_I == null)
			{
				ScrollingMovementMethod.cb_onTakeFocus_Landroid_widget_TextView_Landroid_text_Spannable_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLI_V(ScrollingMovementMethod.n_OnTakeFocus_Landroid_widget_TextView_Landroid_text_Spannable_I));
			}
			return ScrollingMovementMethod.cb_onTakeFocus_Landroid_widget_TextView_Landroid_text_Spannable_I;
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x0002D29C File Offset: 0x0002B49C
		private static void n_OnTakeFocus_Landroid_widget_TextView_Landroid_text_Spannable_I(IntPtr jnienv, IntPtr native__this, IntPtr native_widget, IntPtr native_text, int native_dir)
		{
			BaseMovementMethod @object = Java.Lang.Object.GetObject<ScrollingMovementMethod>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TextView object2 = Java.Lang.Object.GetObject<TextView>(native_widget, JniHandleOwnership.DoNotTransfer);
			ISpannable object3 = Java.Lang.Object.GetObject<ISpannable>(native_text, JniHandleOwnership.DoNotTransfer);
			@object.OnTakeFocus(object2, object3, (FocusSearchDirection)native_dir);
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x0002D2CC File Offset: 0x0002B4CC
		public unsafe override void OnTakeFocus(TextView widget, ISpannable text, [GeneratedEnum] FocusSearchDirection dir)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((widget == null) ? IntPtr.Zero : widget.Handle);
				ptr[1] = new JniArgumentValue((text == null) ? IntPtr.Zero : ((Java.Lang.Object)text).Handle);
				ptr[2] = new JniArgumentValue((int)dir);
				ScrollingMovementMethod._members.InstanceMethods.InvokeVirtualVoidMethod("onTakeFocus.(Landroid/widget/TextView;Landroid/text/Spannable;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(widget);
				GC.KeepAlive(text);
			}
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x0002D374 File Offset: 0x0002B574
		private static Delegate GetOnTouchEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_Handler()
		{
			if (ScrollingMovementMethod.cb_onTouchEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_ == null)
			{
				ScrollingMovementMethod.cb_onTouchEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_Z(ScrollingMovementMethod.n_OnTouchEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_));
			}
			return ScrollingMovementMethod.cb_onTouchEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_;
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x0002D398 File Offset: 0x0002B598
		private static bool n_OnTouchEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_widget, IntPtr native_buffer, IntPtr native_e)
		{
			BaseMovementMethod @object = Java.Lang.Object.GetObject<ScrollingMovementMethod>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TextView object2 = Java.Lang.Object.GetObject<TextView>(native_widget, JniHandleOwnership.DoNotTransfer);
			ISpannable object3 = Java.Lang.Object.GetObject<ISpannable>(native_buffer, JniHandleOwnership.DoNotTransfer);
			MotionEvent object4 = Java.Lang.Object.GetObject<MotionEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.OnTouchEvent(object2, object3, object4);
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x0002D3D0 File Offset: 0x0002B5D0
		public unsafe override bool OnTouchEvent(TextView widget, ISpannable buffer, MotionEvent e)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((widget == null) ? IntPtr.Zero : widget.Handle);
				ptr[1] = new JniArgumentValue((buffer == null) ? IntPtr.Zero : ((Java.Lang.Object)buffer).Handle);
				ptr[2] = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				result = ScrollingMovementMethod._members.InstanceMethods.InvokeVirtualBooleanMethod("onTouchEvent.(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/MotionEvent;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(widget);
				GC.KeepAlive(buffer);
				GC.KeepAlive(e);
			}
			return result;
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x0002D490 File Offset: 0x0002B690
		private static Delegate GetOnTrackballEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_Handler()
		{
			if (ScrollingMovementMethod.cb_onTrackballEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_ == null)
			{
				ScrollingMovementMethod.cb_onTrackballEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_Z(ScrollingMovementMethod.n_OnTrackballEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_));
			}
			return ScrollingMovementMethod.cb_onTrackballEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_;
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x0002D4B4 File Offset: 0x0002B6B4
		private static bool n_OnTrackballEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_widget, IntPtr native_text, IntPtr native_e)
		{
			BaseMovementMethod @object = Java.Lang.Object.GetObject<ScrollingMovementMethod>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TextView object2 = Java.Lang.Object.GetObject<TextView>(native_widget, JniHandleOwnership.DoNotTransfer);
			ISpannable object3 = Java.Lang.Object.GetObject<ISpannable>(native_text, JniHandleOwnership.DoNotTransfer);
			MotionEvent object4 = Java.Lang.Object.GetObject<MotionEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.OnTrackballEvent(object2, object3, object4);
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x0002D4EC File Offset: 0x0002B6EC
		public unsafe override bool OnTrackballEvent(TextView widget, ISpannable text, MotionEvent e)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((widget == null) ? IntPtr.Zero : widget.Handle);
				ptr[1] = new JniArgumentValue((text == null) ? IntPtr.Zero : ((Java.Lang.Object)text).Handle);
				ptr[2] = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				result = ScrollingMovementMethod._members.InstanceMethods.InvokeVirtualBooleanMethod("onTrackballEvent.(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/MotionEvent;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(widget);
				GC.KeepAlive(text);
				GC.KeepAlive(e);
			}
			return result;
		}

		// Token: 0x040007BA RID: 1978
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/text/method/ScrollingMovementMethod", typeof(ScrollingMovementMethod));

		// Token: 0x040007BB RID: 1979
		private static Delegate cb_canSelectArbitrarily;

		// Token: 0x040007BC RID: 1980
		private static Delegate cb_initialize_Landroid_widget_TextView_Landroid_text_Spannable_;

		// Token: 0x040007BD RID: 1981
		private static Delegate cb_onKeyDown_Landroid_widget_TextView_Landroid_text_Spannable_ILandroid_view_KeyEvent_;

		// Token: 0x040007BE RID: 1982
		private static Delegate cb_onKeyOther_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_KeyEvent_;

		// Token: 0x040007BF RID: 1983
		private static Delegate cb_onKeyUp_Landroid_widget_TextView_Landroid_text_Spannable_ILandroid_view_KeyEvent_;

		// Token: 0x040007C0 RID: 1984
		private static Delegate cb_onTakeFocus_Landroid_widget_TextView_Landroid_text_Spannable_I;

		// Token: 0x040007C1 RID: 1985
		private static Delegate cb_onTouchEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_;

		// Token: 0x040007C2 RID: 1986
		private static Delegate cb_onTrackballEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_;
	}
}
