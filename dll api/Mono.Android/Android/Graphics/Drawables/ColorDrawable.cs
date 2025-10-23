using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Graphics.Drawables
{
	// Token: 0x02000235 RID: 565
	[Register("android/graphics/drawable/ColorDrawable", DoNotGenerateAcw = true)]
	public class ColorDrawable : Drawable
	{
		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x060013EF RID: 5103 RVA: 0x000337C7 File Offset: 0x000319C7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ColorDrawable._members;
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x060013F0 RID: 5104 RVA: 0x000337D0 File Offset: 0x000319D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ColorDrawable._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x060013F1 RID: 5105 RVA: 0x000337F4 File Offset: 0x000319F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ColorDrawable._members.ManagedPeerType;
			}
		}

		// Token: 0x060013F2 RID: 5106 RVA: 0x000334B4 File Offset: 0x000316B4
		protected ColorDrawable(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060013F3 RID: 5107 RVA: 0x00033800 File Offset: 0x00031A00
		public unsafe ColorDrawable(Color color) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(color.ToArgb());
			base.SetHandle(ColorDrawable._members.InstanceMethods.StartCreateInstance("(I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			ColorDrawable._members.InstanceMethods.FinishCreateInstance("(I)V", this, ptr);
		}

		// Token: 0x060013F4 RID: 5108 RVA: 0x0003388A File Offset: 0x00031A8A
		private static Delegate GetGetOpacityHandler()
		{
			if (ColorDrawable.cb_getOpacity == null)
			{
				ColorDrawable.cb_getOpacity = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ColorDrawable.n_GetOpacity));
			}
			return ColorDrawable.cb_getOpacity;
		}

		// Token: 0x060013F5 RID: 5109 RVA: 0x000338AE File Offset: 0x00031AAE
		private static int n_GetOpacity(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ColorDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Opacity;
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x060013F6 RID: 5110 RVA: 0x000338BD File Offset: 0x00031ABD
		public override int Opacity
		{
			get
			{
				return ColorDrawable._members.InstanceMethods.InvokeVirtualInt32Method("getOpacity.()I", this, null);
			}
		}

		// Token: 0x060013F7 RID: 5111 RVA: 0x000338D6 File Offset: 0x00031AD6
		private static Delegate GetDraw_Landroid_graphics_Canvas_Handler()
		{
			if (ColorDrawable.cb_draw_Landroid_graphics_Canvas_ == null)
			{
				ColorDrawable.cb_draw_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ColorDrawable.n_Draw_Landroid_graphics_Canvas_));
			}
			return ColorDrawable.cb_draw_Landroid_graphics_Canvas_;
		}

		// Token: 0x060013F8 RID: 5112 RVA: 0x000338FC File Offset: 0x00031AFC
		private static void n_Draw_Landroid_graphics_Canvas_(IntPtr jnienv, IntPtr native__this, IntPtr native_canvas)
		{
			Drawable @object = Java.Lang.Object.GetObject<ColorDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Canvas object2 = Java.Lang.Object.GetObject<Canvas>(native_canvas, JniHandleOwnership.DoNotTransfer);
			@object.Draw(object2);
		}

		// Token: 0x060013F9 RID: 5113 RVA: 0x00033920 File Offset: 0x00031B20
		public unsafe override void Draw(Canvas canvas)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((canvas == null) ? IntPtr.Zero : canvas.Handle);
				ColorDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("draw.(Landroid/graphics/Canvas;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(canvas);
			}
		}

		// Token: 0x060013FA RID: 5114 RVA: 0x00033984 File Offset: 0x00031B84
		private static Delegate GetSetAlpha_IHandler()
		{
			if (ColorDrawable.cb_setAlpha_I == null)
			{
				ColorDrawable.cb_setAlpha_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(ColorDrawable.n_SetAlpha_I));
			}
			return ColorDrawable.cb_setAlpha_I;
		}

		// Token: 0x060013FB RID: 5115 RVA: 0x000339A8 File Offset: 0x00031BA8
		private static void n_SetAlpha_I(IntPtr jnienv, IntPtr native__this, int alpha)
		{
			Java.Lang.Object.GetObject<ColorDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetAlpha(alpha);
		}

		// Token: 0x060013FC RID: 5116 RVA: 0x000339B8 File Offset: 0x00031BB8
		public unsafe override void SetAlpha(int alpha)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(alpha);
			ColorDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("setAlpha.(I)V", this, ptr);
		}

		// Token: 0x060013FD RID: 5117 RVA: 0x000339F3 File Offset: 0x00031BF3
		private static Delegate GetSetColorFilter_Landroid_graphics_ColorFilter_Handler()
		{
			if (ColorDrawable.cb_setColorFilter_Landroid_graphics_ColorFilter_ == null)
			{
				ColorDrawable.cb_setColorFilter_Landroid_graphics_ColorFilter_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ColorDrawable.n_SetColorFilter_Landroid_graphics_ColorFilter_));
			}
			return ColorDrawable.cb_setColorFilter_Landroid_graphics_ColorFilter_;
		}

		// Token: 0x060013FE RID: 5118 RVA: 0x00033A18 File Offset: 0x00031C18
		private static void n_SetColorFilter_Landroid_graphics_ColorFilter_(IntPtr jnienv, IntPtr native__this, IntPtr native_colorFilter)
		{
			Drawable @object = Java.Lang.Object.GetObject<ColorDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorFilter object2 = Java.Lang.Object.GetObject<ColorFilter>(native_colorFilter, JniHandleOwnership.DoNotTransfer);
			@object.SetColorFilter(object2);
		}

		// Token: 0x060013FF RID: 5119 RVA: 0x00033A3C File Offset: 0x00031C3C
		public unsafe override void SetColorFilter(ColorFilter colorFilter)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((colorFilter == null) ? IntPtr.Zero : colorFilter.Handle);
				ColorDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("setColorFilter.(Landroid/graphics/ColorFilter;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(colorFilter);
			}
		}

		// Token: 0x040008C2 RID: 2242
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/graphics/drawable/ColorDrawable", typeof(ColorDrawable));

		// Token: 0x040008C3 RID: 2243
		private static Delegate cb_getOpacity;

		// Token: 0x040008C4 RID: 2244
		private static Delegate cb_draw_Landroid_graphics_Canvas_;

		// Token: 0x040008C5 RID: 2245
		private static Delegate cb_setAlpha_I;

		// Token: 0x040008C6 RID: 2246
		private static Delegate cb_setColorFilter_Landroid_graphics_ColorFilter_;
	}
}
