using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Request.Target
{
	// Token: 0x020000B6 RID: 182
	[Register("com/bumptech/glide/request/target/FixedSizeDrawable", DoNotGenerateAcw = true)]
	public class FixedSizeDrawable : Drawable
	{
		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000997 RID: 2455 RVA: 0x0001DFC8 File Offset: 0x0001C1C8
		internal static IntPtr class_ref
		{
			get
			{
				return FixedSizeDrawable._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000998 RID: 2456 RVA: 0x0001DFEC File Offset: 0x0001C1EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FixedSizeDrawable._members;
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000999 RID: 2457 RVA: 0x0001DFF4 File Offset: 0x0001C1F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return FixedSizeDrawable._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x0600099A RID: 2458 RVA: 0x0001E018 File Offset: 0x0001C218
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FixedSizeDrawable._members.ManagedPeerType;
			}
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x0001E024 File Offset: 0x0001C224
		protected FixedSizeDrawable(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x0001E030 File Offset: 0x0001C230
		[Register(".ctor", "(Landroid/graphics/drawable/Drawable;II)V", "")]
		public unsafe FixedSizeDrawable(Drawable wrapped, int width, int height) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((wrapped == null) ? IntPtr.Zero : wrapped.Handle);
				ptr[1] = new JniArgumentValue(width);
				ptr[2] = new JniArgumentValue(height);
				base.SetHandle(FixedSizeDrawable._members.InstanceMethods.StartCreateInstance("(Landroid/graphics/drawable/Drawable;II)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				FixedSizeDrawable._members.InstanceMethods.FinishCreateInstance("(Landroid/graphics/drawable/Drawable;II)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(wrapped);
			}
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x0001E108 File Offset: 0x0001C308
		private static Delegate GetGetOpacityHandler()
		{
			if (FixedSizeDrawable.cb_getOpacity == null)
			{
				FixedSizeDrawable.cb_getOpacity = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(FixedSizeDrawable.n_GetOpacity));
			}
			return FixedSizeDrawable.cb_getOpacity;
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x0001E12C File Offset: 0x0001C32C
		private static int n_GetOpacity(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<FixedSizeDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Opacity;
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x0600099F RID: 2463 RVA: 0x0001E13B File Offset: 0x0001C33B
		public override int Opacity
		{
			[Register("getOpacity", "()I", "GetGetOpacityHandler")]
			get
			{
				return FixedSizeDrawable._members.InstanceMethods.InvokeVirtualInt32Method("getOpacity.()I", this, null);
			}
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x0001E154 File Offset: 0x0001C354
		private static Delegate GetDraw_Landroid_graphics_Canvas_Handler()
		{
			if (FixedSizeDrawable.cb_draw_Landroid_graphics_Canvas_ == null)
			{
				FixedSizeDrawable.cb_draw_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(FixedSizeDrawable.n_Draw_Landroid_graphics_Canvas_));
			}
			return FixedSizeDrawable.cb_draw_Landroid_graphics_Canvas_;
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x0001E178 File Offset: 0x0001C378
		private static void n_Draw_Landroid_graphics_Canvas_(IntPtr jnienv, IntPtr native__this, IntPtr native_canvas)
		{
			Drawable @object = Java.Lang.Object.GetObject<FixedSizeDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Canvas object2 = Java.Lang.Object.GetObject<Canvas>(native_canvas, JniHandleOwnership.DoNotTransfer);
			@object.Draw(object2);
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x0001E19C File Offset: 0x0001C39C
		[Register("draw", "(Landroid/graphics/Canvas;)V", "GetDraw_Landroid_graphics_Canvas_Handler")]
		public unsafe override void Draw(Canvas canvas)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((canvas == null) ? IntPtr.Zero : canvas.Handle);
				FixedSizeDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("draw.(Landroid/graphics/Canvas;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(canvas);
			}
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x0001E200 File Offset: 0x0001C400
		private static Delegate GetSetAlpha_IHandler()
		{
			if (FixedSizeDrawable.cb_setAlpha_I == null)
			{
				FixedSizeDrawable.cb_setAlpha_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(FixedSizeDrawable.n_SetAlpha_I));
			}
			return FixedSizeDrawable.cb_setAlpha_I;
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x0001E224 File Offset: 0x0001C424
		private static void n_SetAlpha_I(IntPtr jnienv, IntPtr native__this, int i)
		{
			Java.Lang.Object.GetObject<FixedSizeDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetAlpha(i);
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x0001E234 File Offset: 0x0001C434
		[Register("setAlpha", "(I)V", "GetSetAlpha_IHandler")]
		public unsafe override void SetAlpha(int i)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(i);
			FixedSizeDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("setAlpha.(I)V", this, ptr);
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x0001E26F File Offset: 0x0001C46F
		private static Delegate GetSetColorFilter_Landroid_graphics_ColorFilter_Handler()
		{
			if (FixedSizeDrawable.cb_setColorFilter_Landroid_graphics_ColorFilter_ == null)
			{
				FixedSizeDrawable.cb_setColorFilter_Landroid_graphics_ColorFilter_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(FixedSizeDrawable.n_SetColorFilter_Landroid_graphics_ColorFilter_));
			}
			return FixedSizeDrawable.cb_setColorFilter_Landroid_graphics_ColorFilter_;
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x0001E294 File Offset: 0x0001C494
		private static void n_SetColorFilter_Landroid_graphics_ColorFilter_(IntPtr jnienv, IntPtr native__this, IntPtr native_colorFilter)
		{
			Drawable @object = Java.Lang.Object.GetObject<FixedSizeDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorFilter object2 = Java.Lang.Object.GetObject<ColorFilter>(native_colorFilter, JniHandleOwnership.DoNotTransfer);
			@object.SetColorFilter(object2);
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x0001E2B8 File Offset: 0x0001C4B8
		[Register("setColorFilter", "(Landroid/graphics/ColorFilter;)V", "GetSetColorFilter_Landroid_graphics_ColorFilter_Handler")]
		public unsafe override void SetColorFilter(ColorFilter colorFilter)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((colorFilter == null) ? IntPtr.Zero : colorFilter.Handle);
				FixedSizeDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("setColorFilter.(Landroid/graphics/ColorFilter;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(colorFilter);
			}
		}

		// Token: 0x04000257 RID: 599
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/target/FixedSizeDrawable", typeof(FixedSizeDrawable));

		// Token: 0x04000258 RID: 600
		private static Delegate cb_getOpacity;

		// Token: 0x04000259 RID: 601
		private static Delegate cb_draw_Landroid_graphics_Canvas_;

		// Token: 0x0400025A RID: 602
		private static Delegate cb_setAlpha_I;

		// Token: 0x0400025B RID: 603
		private static Delegate cb_setColorFilter_Landroid_graphics_ColorFilter_;
	}
}
