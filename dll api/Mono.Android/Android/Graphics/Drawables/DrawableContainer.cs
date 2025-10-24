using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Graphics.Drawables
{
	// Token: 0x0200023A RID: 570
	[Register("android/graphics/drawable/DrawableContainer", DoNotGenerateAcw = true)]
	public class DrawableContainer : Drawable, Drawable.ICallback, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06001434 RID: 5172 RVA: 0x0003423B File Offset: 0x0003243B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DrawableContainer._members;
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06001435 RID: 5173 RVA: 0x00034244 File Offset: 0x00032444
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DrawableContainer._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06001436 RID: 5174 RVA: 0x00034268 File Offset: 0x00032468
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DrawableContainer._members.ManagedPeerType;
			}
		}

		// Token: 0x06001437 RID: 5175 RVA: 0x000334B4 File Offset: 0x000316B4
		protected DrawableContainer(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001438 RID: 5176 RVA: 0x00034274 File Offset: 0x00032474
		private static Delegate GetGetOpacityHandler()
		{
			if (DrawableContainer.cb_getOpacity == null)
			{
				DrawableContainer.cb_getOpacity = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(DrawableContainer.n_GetOpacity));
			}
			return DrawableContainer.cb_getOpacity;
		}

		// Token: 0x06001439 RID: 5177 RVA: 0x00034298 File Offset: 0x00032498
		private static int n_GetOpacity(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<DrawableContainer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Opacity;
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x0600143A RID: 5178 RVA: 0x000342A7 File Offset: 0x000324A7
		public override int Opacity
		{
			get
			{
				return DrawableContainer._members.InstanceMethods.InvokeVirtualInt32Method("getOpacity.()I", this, null);
			}
		}

		// Token: 0x0600143B RID: 5179 RVA: 0x000342C0 File Offset: 0x000324C0
		private static Delegate GetDraw_Landroid_graphics_Canvas_Handler()
		{
			if (DrawableContainer.cb_draw_Landroid_graphics_Canvas_ == null)
			{
				DrawableContainer.cb_draw_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(DrawableContainer.n_Draw_Landroid_graphics_Canvas_));
			}
			return DrawableContainer.cb_draw_Landroid_graphics_Canvas_;
		}

		// Token: 0x0600143C RID: 5180 RVA: 0x000342E4 File Offset: 0x000324E4
		private static void n_Draw_Landroid_graphics_Canvas_(IntPtr jnienv, IntPtr native__this, IntPtr native_canvas)
		{
			Drawable @object = Java.Lang.Object.GetObject<DrawableContainer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Canvas object2 = Java.Lang.Object.GetObject<Canvas>(native_canvas, JniHandleOwnership.DoNotTransfer);
			@object.Draw(object2);
		}

		// Token: 0x0600143D RID: 5181 RVA: 0x00034308 File Offset: 0x00032508
		public unsafe override void Draw(Canvas canvas)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((canvas == null) ? IntPtr.Zero : canvas.Handle);
				DrawableContainer._members.InstanceMethods.InvokeVirtualVoidMethod("draw.(Landroid/graphics/Canvas;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(canvas);
			}
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x0003436C File Offset: 0x0003256C
		private static Delegate GetInvalidateDrawable_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (DrawableContainer.cb_invalidateDrawable_Landroid_graphics_drawable_Drawable_ == null)
			{
				DrawableContainer.cb_invalidateDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(DrawableContainer.n_InvalidateDrawable_Landroid_graphics_drawable_Drawable_));
			}
			return DrawableContainer.cb_invalidateDrawable_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x00034390 File Offset: 0x00032590
		private static void n_InvalidateDrawable_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_who)
		{
			DrawableContainer @object = Java.Lang.Object.GetObject<DrawableContainer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_who, JniHandleOwnership.DoNotTransfer);
			@object.InvalidateDrawable(object2);
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x000343B4 File Offset: 0x000325B4
		public unsafe virtual void InvalidateDrawable(Drawable who)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((who == null) ? IntPtr.Zero : who.Handle);
				DrawableContainer._members.InstanceMethods.InvokeVirtualVoidMethod("invalidateDrawable.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(who);
			}
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x00034418 File Offset: 0x00032618
		private static Delegate GetScheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_JHandler()
		{
			if (DrawableContainer.cb_scheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_J == null)
			{
				DrawableContainer.cb_scheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_J = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLJ_V(DrawableContainer.n_ScheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_J));
			}
			return DrawableContainer.cb_scheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_J;
		}

		// Token: 0x06001442 RID: 5186 RVA: 0x0003443C File Offset: 0x0003263C
		private static void n_ScheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_J(IntPtr jnienv, IntPtr native__this, IntPtr native_who, IntPtr native_what, long when)
		{
			DrawableContainer @object = Java.Lang.Object.GetObject<DrawableContainer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_who, JniHandleOwnership.DoNotTransfer);
			IRunnable object3 = Java.Lang.Object.GetObject<IRunnable>(native_what, JniHandleOwnership.DoNotTransfer);
			@object.ScheduleDrawable(object2, object3, when);
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x0003446C File Offset: 0x0003266C
		public unsafe virtual void ScheduleDrawable(Drawable who, IRunnable what, long when)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((who == null) ? IntPtr.Zero : who.Handle);
				ptr[1] = new JniArgumentValue((what == null) ? IntPtr.Zero : ((Java.Lang.Object)what).Handle);
				ptr[2] = new JniArgumentValue(when);
				DrawableContainer._members.InstanceMethods.InvokeVirtualVoidMethod("scheduleDrawable.(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(who);
				GC.KeepAlive(what);
			}
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x00034514 File Offset: 0x00032714
		private static Delegate GetSetAlpha_IHandler()
		{
			if (DrawableContainer.cb_setAlpha_I == null)
			{
				DrawableContainer.cb_setAlpha_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(DrawableContainer.n_SetAlpha_I));
			}
			return DrawableContainer.cb_setAlpha_I;
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x00034538 File Offset: 0x00032738
		private static void n_SetAlpha_I(IntPtr jnienv, IntPtr native__this, int alpha)
		{
			Java.Lang.Object.GetObject<DrawableContainer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetAlpha(alpha);
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x00034548 File Offset: 0x00032748
		public unsafe override void SetAlpha(int alpha)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(alpha);
			DrawableContainer._members.InstanceMethods.InvokeVirtualVoidMethod("setAlpha.(I)V", this, ptr);
		}

		// Token: 0x06001447 RID: 5191 RVA: 0x00034583 File Offset: 0x00032783
		private static Delegate GetSetColorFilter_Landroid_graphics_ColorFilter_Handler()
		{
			if (DrawableContainer.cb_setColorFilter_Landroid_graphics_ColorFilter_ == null)
			{
				DrawableContainer.cb_setColorFilter_Landroid_graphics_ColorFilter_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(DrawableContainer.n_SetColorFilter_Landroid_graphics_ColorFilter_));
			}
			return DrawableContainer.cb_setColorFilter_Landroid_graphics_ColorFilter_;
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x000345A8 File Offset: 0x000327A8
		private static void n_SetColorFilter_Landroid_graphics_ColorFilter_(IntPtr jnienv, IntPtr native__this, IntPtr native_colorFilter)
		{
			Drawable @object = Java.Lang.Object.GetObject<DrawableContainer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorFilter object2 = Java.Lang.Object.GetObject<ColorFilter>(native_colorFilter, JniHandleOwnership.DoNotTransfer);
			@object.SetColorFilter(object2);
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x000345CC File Offset: 0x000327CC
		public unsafe override void SetColorFilter(ColorFilter colorFilter)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((colorFilter == null) ? IntPtr.Zero : colorFilter.Handle);
				DrawableContainer._members.InstanceMethods.InvokeVirtualVoidMethod("setColorFilter.(Landroid/graphics/ColorFilter;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(colorFilter);
			}
		}

		// Token: 0x0600144A RID: 5194 RVA: 0x00034630 File Offset: 0x00032830
		private static Delegate GetUnscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_Handler()
		{
			if (DrawableContainer.cb_unscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_ == null)
			{
				DrawableContainer.cb_unscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(DrawableContainer.n_UnscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_));
			}
			return DrawableContainer.cb_unscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_;
		}

		// Token: 0x0600144B RID: 5195 RVA: 0x00034654 File Offset: 0x00032854
		private static void n_UnscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_(IntPtr jnienv, IntPtr native__this, IntPtr native_who, IntPtr native_what)
		{
			DrawableContainer @object = Java.Lang.Object.GetObject<DrawableContainer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_who, JniHandleOwnership.DoNotTransfer);
			IRunnable object3 = Java.Lang.Object.GetObject<IRunnable>(native_what, JniHandleOwnership.DoNotTransfer);
			@object.UnscheduleDrawable(object2, object3);
		}

		// Token: 0x0600144C RID: 5196 RVA: 0x00034680 File Offset: 0x00032880
		public unsafe virtual void UnscheduleDrawable(Drawable who, IRunnable what)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((who == null) ? IntPtr.Zero : who.Handle);
				ptr[1] = new JniArgumentValue((what == null) ? IntPtr.Zero : ((Java.Lang.Object)what).Handle);
				DrawableContainer._members.InstanceMethods.InvokeVirtualVoidMethod("unscheduleDrawable.(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(who);
				GC.KeepAlive(what);
			}
		}

		// Token: 0x040008D7 RID: 2263
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/graphics/drawable/DrawableContainer", typeof(DrawableContainer));

		// Token: 0x040008D8 RID: 2264
		private static Delegate cb_getOpacity;

		// Token: 0x040008D9 RID: 2265
		private static Delegate cb_draw_Landroid_graphics_Canvas_;

		// Token: 0x040008DA RID: 2266
		private static Delegate cb_invalidateDrawable_Landroid_graphics_drawable_Drawable_;

		// Token: 0x040008DB RID: 2267
		private static Delegate cb_scheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_J;

		// Token: 0x040008DC RID: 2268
		private static Delegate cb_setAlpha_I;

		// Token: 0x040008DD RID: 2269
		private static Delegate cb_setColorFilter_Landroid_graphics_ColorFilter_;

		// Token: 0x040008DE RID: 2270
		private static Delegate cb_unscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_;
	}
}
