using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content.Res;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Graphics.Drawables
{
	// Token: 0x02000234 RID: 564
	[Register("android/graphics/drawable/BitmapDrawable", DoNotGenerateAcw = true)]
	public class BitmapDrawable : Drawable
	{
		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x060013DD RID: 5085 RVA: 0x0003347A File Offset: 0x0003167A
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BitmapDrawable._members;
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x060013DE RID: 5086 RVA: 0x00033484 File Offset: 0x00031684
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BitmapDrawable._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x060013DF RID: 5087 RVA: 0x000334A8 File Offset: 0x000316A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BitmapDrawable._members.ManagedPeerType;
			}
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x000334B4 File Offset: 0x000316B4
		protected BitmapDrawable(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060013E1 RID: 5089 RVA: 0x000334C0 File Offset: 0x000316C0
		public unsafe BitmapDrawable(Resources res, Bitmap bitmap) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((res == null) ? IntPtr.Zero : res.Handle);
				ptr[1] = new JniArgumentValue((bitmap == null) ? IntPtr.Zero : bitmap.Handle);
				base.SetHandle(BitmapDrawable._members.InstanceMethods.StartCreateInstance("(Landroid/content/res/Resources;Landroid/graphics/Bitmap;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				BitmapDrawable._members.InstanceMethods.FinishCreateInstance("(Landroid/content/res/Resources;Landroid/graphics/Bitmap;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(res);
				GC.KeepAlive(bitmap);
			}
		}

		// Token: 0x060013E2 RID: 5090 RVA: 0x00033598 File Offset: 0x00031798
		private static Delegate GetGetOpacityHandler()
		{
			if (BitmapDrawable.cb_getOpacity == null)
			{
				BitmapDrawable.cb_getOpacity = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(BitmapDrawable.n_GetOpacity));
			}
			return BitmapDrawable.cb_getOpacity;
		}

		// Token: 0x060013E3 RID: 5091 RVA: 0x000335BC File Offset: 0x000317BC
		private static int n_GetOpacity(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BitmapDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Opacity;
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x060013E4 RID: 5092 RVA: 0x000335CB File Offset: 0x000317CB
		public override int Opacity
		{
			get
			{
				return BitmapDrawable._members.InstanceMethods.InvokeVirtualInt32Method("getOpacity.()I", this, null);
			}
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x000335E4 File Offset: 0x000317E4
		private static Delegate GetDraw_Landroid_graphics_Canvas_Handler()
		{
			if (BitmapDrawable.cb_draw_Landroid_graphics_Canvas_ == null)
			{
				BitmapDrawable.cb_draw_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(BitmapDrawable.n_Draw_Landroid_graphics_Canvas_));
			}
			return BitmapDrawable.cb_draw_Landroid_graphics_Canvas_;
		}

		// Token: 0x060013E6 RID: 5094 RVA: 0x00033608 File Offset: 0x00031808
		private static void n_Draw_Landroid_graphics_Canvas_(IntPtr jnienv, IntPtr native__this, IntPtr native_canvas)
		{
			Drawable @object = Java.Lang.Object.GetObject<BitmapDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Canvas object2 = Java.Lang.Object.GetObject<Canvas>(native_canvas, JniHandleOwnership.DoNotTransfer);
			@object.Draw(object2);
		}

		// Token: 0x060013E7 RID: 5095 RVA: 0x0003362C File Offset: 0x0003182C
		public unsafe override void Draw(Canvas canvas)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((canvas == null) ? IntPtr.Zero : canvas.Handle);
				BitmapDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("draw.(Landroid/graphics/Canvas;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(canvas);
			}
		}

		// Token: 0x060013E8 RID: 5096 RVA: 0x00033690 File Offset: 0x00031890
		private static Delegate GetSetAlpha_IHandler()
		{
			if (BitmapDrawable.cb_setAlpha_I == null)
			{
				BitmapDrawable.cb_setAlpha_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(BitmapDrawable.n_SetAlpha_I));
			}
			return BitmapDrawable.cb_setAlpha_I;
		}

		// Token: 0x060013E9 RID: 5097 RVA: 0x000336B4 File Offset: 0x000318B4
		private static void n_SetAlpha_I(IntPtr jnienv, IntPtr native__this, int alpha)
		{
			Java.Lang.Object.GetObject<BitmapDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetAlpha(alpha);
		}

		// Token: 0x060013EA RID: 5098 RVA: 0x000336C4 File Offset: 0x000318C4
		public unsafe override void SetAlpha(int alpha)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(alpha);
			BitmapDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("setAlpha.(I)V", this, ptr);
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x000336FF File Offset: 0x000318FF
		private static Delegate GetSetColorFilter_Landroid_graphics_ColorFilter_Handler()
		{
			if (BitmapDrawable.cb_setColorFilter_Landroid_graphics_ColorFilter_ == null)
			{
				BitmapDrawable.cb_setColorFilter_Landroid_graphics_ColorFilter_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(BitmapDrawable.n_SetColorFilter_Landroid_graphics_ColorFilter_));
			}
			return BitmapDrawable.cb_setColorFilter_Landroid_graphics_ColorFilter_;
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x00033724 File Offset: 0x00031924
		private static void n_SetColorFilter_Landroid_graphics_ColorFilter_(IntPtr jnienv, IntPtr native__this, IntPtr native_colorFilter)
		{
			Drawable @object = Java.Lang.Object.GetObject<BitmapDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorFilter object2 = Java.Lang.Object.GetObject<ColorFilter>(native_colorFilter, JniHandleOwnership.DoNotTransfer);
			@object.SetColorFilter(object2);
		}

		// Token: 0x060013ED RID: 5101 RVA: 0x00033748 File Offset: 0x00031948
		public unsafe override void SetColorFilter(ColorFilter colorFilter)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((colorFilter == null) ? IntPtr.Zero : colorFilter.Handle);
				BitmapDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("setColorFilter.(Landroid/graphics/ColorFilter;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(colorFilter);
			}
		}

		// Token: 0x040008BD RID: 2237
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/graphics/drawable/BitmapDrawable", typeof(BitmapDrawable));

		// Token: 0x040008BE RID: 2238
		private static Delegate cb_getOpacity;

		// Token: 0x040008BF RID: 2239
		private static Delegate cb_draw_Landroid_graphics_Canvas_;

		// Token: 0x040008C0 RID: 2240
		private static Delegate cb_setAlpha_I;

		// Token: 0x040008C1 RID: 2241
		private static Delegate cb_setColorFilter_Landroid_graphics_ColorFilter_;
	}
}
