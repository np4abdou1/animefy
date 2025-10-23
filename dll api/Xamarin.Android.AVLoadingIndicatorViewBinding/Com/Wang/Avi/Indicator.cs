using System;
using System.Collections.Generic;
using Android.Animation;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Runtime;
using Java.Lang;

namespace Com.Wang.Avi
{
	// Token: 0x02000005 RID: 5
	[Register("com/wang/avi/Indicator", DoNotGenerateAcw = true)]
	public abstract class Indicator : Drawable, IAnimatable, IJavaObject, IDisposable
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00002C98 File Offset: 0x00000E98
		internal static IntPtr class_ref
		{
			get
			{
				return JNIEnv.FindClass("com/wang/avi/Indicator", ref Indicator.java_class_handle);
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00002CA9 File Offset: 0x00000EA9
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Indicator.class_ref;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00002CB0 File Offset: 0x00000EB0
		protected override Type ThresholdType
		{
			get
			{
				return typeof(Indicator);
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002CBC File Offset: 0x00000EBC
		protected Indicator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002CC8 File Offset: 0x00000EC8
		[Register(".ctor", "()V", "")]
		public Indicator() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			if (base.GetType() != typeof(Indicator))
			{
				base.SetHandle(JNIEnv.StartCreateInstance(base.GetType(), "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				return;
			}
			if (Indicator.id_ctor == IntPtr.Zero)
			{
				Indicator.id_ctor = JNIEnv.GetMethodID(Indicator.class_ref, "<init>", "()V");
			}
			base.SetHandle(JNIEnv.StartCreateInstance(Indicator.class_ref, Indicator.id_ctor, Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance(base.Handle, Indicator.class_ref, Indicator.id_ctor, Array.Empty<JValue>());
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002D9C File Offset: 0x00000F9C
		private static Delegate GetGetColorHandler()
		{
			if (Indicator.cb_getColor == null)
			{
				Indicator.cb_getColor = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, int>(Indicator.n_GetColor));
			}
			return Indicator.cb_getColor;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002DC0 File Offset: 0x00000FC0
		private static int n_GetColor(IntPtr jnienv, IntPtr native__this)
		{
			Indicator @object = Java.Lang.Object.GetObject<Indicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return @object.Color;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002DDC File Offset: 0x00000FDC
		private static Delegate GetSetColor_IHandler()
		{
			if (Indicator.cb_setColor_I == null)
			{
				Indicator.cb_setColor_I = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, int>(Indicator.n_SetColor_I));
			}
			return Indicator.cb_setColor_I;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002E00 File Offset: 0x00001000
		private static void n_SetColor_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			Indicator @object = Java.Lang.Object.GetObject<Indicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			@object.Color = p0;
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00002E20 File Offset: 0x00001020
		// (set) Token: 0x06000033 RID: 51 RVA: 0x00002EA4 File Offset: 0x000010A4
		public unsafe virtual int Color
		{
			[Register("getColor", "()I", "GetGetColorHandler")]
			get
			{
				if (Indicator.id_getColor == IntPtr.Zero)
				{
					Indicator.id_getColor = JNIEnv.GetMethodID(Indicator.class_ref, "getColor", "()I");
				}
				if (base.GetType() == this.ThresholdType)
				{
					return JNIEnv.CallIntMethod(base.Handle, Indicator.id_getColor);
				}
				return JNIEnv.CallNonvirtualIntMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "getColor", "()I"));
			}
			[Register("setColor", "(I)V", "GetSetColor_IHandler")]
			set
			{
				if (Indicator.id_setColor_I == IntPtr.Zero)
				{
					Indicator.id_setColor_I = JNIEnv.GetMethodID(Indicator.class_ref, "setColor", "(I)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(value);
				if (base.GetType() == this.ThresholdType)
				{
					JNIEnv.CallVoidMethod(base.Handle, Indicator.id_setColor_I, ptr);
					return;
				}
				JNIEnv.CallNonvirtualVoidMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "setColor", "(I)V"), ptr);
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002F3F File Offset: 0x0000113F
		private static Delegate GetGetDrawBoundsHandler()
		{
			if (Indicator.cb_getDrawBounds == null)
			{
				Indicator.cb_getDrawBounds = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr>(Indicator.n_GetDrawBounds));
			}
			return Indicator.cb_getDrawBounds;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002F64 File Offset: 0x00001164
		private static IntPtr n_GetDrawBounds(IntPtr jnienv, IntPtr native__this)
		{
			Indicator @object = Java.Lang.Object.GetObject<Indicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.DrawBounds);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002F85 File Offset: 0x00001185
		private static Delegate GetSetDrawBounds_Landroid_graphics_Rect_Handler()
		{
			if (Indicator.cb_setDrawBounds_Landroid_graphics_Rect_ == null)
			{
				Indicator.cb_setDrawBounds_Landroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr>(Indicator.n_SetDrawBounds_Landroid_graphics_Rect_));
			}
			return Indicator.cb_setDrawBounds_Landroid_graphics_Rect_;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002FAC File Offset: 0x000011AC
		private static void n_SetDrawBounds_Landroid_graphics_Rect_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			Indicator @object = Java.Lang.Object.GetObject<Indicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Rect object2 = Java.Lang.Object.GetObject<Rect>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.DrawBounds = object2;
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00002FD4 File Offset: 0x000011D4
		// (set) Token: 0x06000039 RID: 57 RVA: 0x00003064 File Offset: 0x00001264
		public unsafe virtual Rect DrawBounds
		{
			[Register("getDrawBounds", "()Landroid/graphics/Rect;", "GetGetDrawBoundsHandler")]
			get
			{
				if (Indicator.id_getDrawBounds == IntPtr.Zero)
				{
					Indicator.id_getDrawBounds = JNIEnv.GetMethodID(Indicator.class_ref, "getDrawBounds", "()Landroid/graphics/Rect;");
				}
				if (base.GetType() == this.ThresholdType)
				{
					return Java.Lang.Object.GetObject<Rect>(JNIEnv.CallObjectMethod(base.Handle, Indicator.id_getDrawBounds), JniHandleOwnership.TransferLocalRef);
				}
				return Java.Lang.Object.GetObject<Rect>(JNIEnv.CallNonvirtualObjectMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "getDrawBounds", "()Landroid/graphics/Rect;")), JniHandleOwnership.TransferLocalRef);
			}
			[Register("setDrawBounds", "(Landroid/graphics/Rect;)V", "GetSetDrawBounds_Landroid_graphics_Rect_Handler")]
			set
			{
				if (Indicator.id_setDrawBounds_Landroid_graphics_Rect_ == IntPtr.Zero)
				{
					Indicator.id_setDrawBounds_Landroid_graphics_Rect_ = JNIEnv.GetMethodID(Indicator.class_ref, "setDrawBounds", "(Landroid/graphics/Rect;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(value);
				if (base.GetType() == this.ThresholdType)
				{
					JNIEnv.CallVoidMethod(base.Handle, Indicator.id_setDrawBounds_Landroid_graphics_Rect_, ptr);
					return;
				}
				JNIEnv.CallNonvirtualVoidMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "setDrawBounds", "(Landroid/graphics/Rect;)V"), ptr);
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000030FF File Offset: 0x000012FF
		private static Delegate GetGetHeightHandler()
		{
			if (Indicator.cb_getHeight == null)
			{
				Indicator.cb_getHeight = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, int>(Indicator.n_GetHeight));
			}
			return Indicator.cb_getHeight;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003124 File Offset: 0x00001324
		private static int n_GetHeight(IntPtr jnienv, IntPtr native__this)
		{
			Indicator @object = Java.Lang.Object.GetObject<Indicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return @object.Height;
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00003140 File Offset: 0x00001340
		public virtual int Height
		{
			[Register("getHeight", "()I", "GetGetHeightHandler")]
			get
			{
				if (Indicator.id_getHeight == IntPtr.Zero)
				{
					Indicator.id_getHeight = JNIEnv.GetMethodID(Indicator.class_ref, "getHeight", "()I");
				}
				if (base.GetType() == this.ThresholdType)
				{
					return JNIEnv.CallIntMethod(base.Handle, Indicator.id_getHeight);
				}
				return JNIEnv.CallNonvirtualIntMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "getHeight", "()I"));
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000031C1 File Offset: 0x000013C1
		private static Delegate GetIsRunningHandler()
		{
			if (Indicator.cb_isRunning == null)
			{
				Indicator.cb_isRunning = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, bool>(Indicator.n_IsRunning));
			}
			return Indicator.cb_isRunning;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000031E8 File Offset: 0x000013E8
		private static bool n_IsRunning(IntPtr jnienv, IntPtr native__this)
		{
			Indicator @object = Java.Lang.Object.GetObject<Indicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return @object.IsRunning;
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00003204 File Offset: 0x00001404
		public virtual bool IsRunning
		{
			[Register("isRunning", "()Z", "GetIsRunningHandler")]
			get
			{
				if (Indicator.id_isRunning == IntPtr.Zero)
				{
					Indicator.id_isRunning = JNIEnv.GetMethodID(Indicator.class_ref, "isRunning", "()Z");
				}
				if (base.GetType() == this.ThresholdType)
				{
					return JNIEnv.CallBooleanMethod(base.Handle, Indicator.id_isRunning);
				}
				return JNIEnv.CallNonvirtualBooleanMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "isRunning", "()Z"));
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00003285 File Offset: 0x00001485
		private static Delegate GetGetOpacityHandler()
		{
			if (Indicator.cb_getOpacity == null)
			{
				Indicator.cb_getOpacity = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, int>(Indicator.n_GetOpacity));
			}
			return Indicator.cb_getOpacity;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000032AC File Offset: 0x000014AC
		private static int n_GetOpacity(IntPtr jnienv, IntPtr native__this)
		{
			Indicator @object = Java.Lang.Object.GetObject<Indicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return @object.Opacity;
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000042 RID: 66 RVA: 0x000032C8 File Offset: 0x000014C8
		public override int Opacity
		{
			[Register("getOpacity", "()I", "GetGetOpacityHandler")]
			get
			{
				if (Indicator.id_getOpacity == IntPtr.Zero)
				{
					Indicator.id_getOpacity = JNIEnv.GetMethodID(Indicator.class_ref, "getOpacity", "()I");
				}
				if (base.GetType() == this.ThresholdType)
				{
					return JNIEnv.CallIntMethod(base.Handle, Indicator.id_getOpacity);
				}
				return JNIEnv.CallNonvirtualIntMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "getOpacity", "()I"));
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00003349 File Offset: 0x00001549
		private static Delegate GetGetWidthHandler()
		{
			if (Indicator.cb_getWidth == null)
			{
				Indicator.cb_getWidth = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, int>(Indicator.n_GetWidth));
			}
			return Indicator.cb_getWidth;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00003370 File Offset: 0x00001570
		private static int n_GetWidth(IntPtr jnienv, IntPtr native__this)
		{
			Indicator @object = Java.Lang.Object.GetObject<Indicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return @object.Width;
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000045 RID: 69 RVA: 0x0000338C File Offset: 0x0000158C
		public virtual int Width
		{
			[Register("getWidth", "()I", "GetGetWidthHandler")]
			get
			{
				if (Indicator.id_getWidth == IntPtr.Zero)
				{
					Indicator.id_getWidth = JNIEnv.GetMethodID(Indicator.class_ref, "getWidth", "()I");
				}
				if (base.GetType() == this.ThresholdType)
				{
					return JNIEnv.CallIntMethod(base.Handle, Indicator.id_getWidth);
				}
				return JNIEnv.CallNonvirtualIntMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "getWidth", "()I"));
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000340D File Offset: 0x0000160D
		private static Delegate GetAddUpdateListener_Landroid_animation_ValueAnimator_Landroid_animation_ValueAnimator_AnimatorUpdateListener_Handler()
		{
			if (Indicator.cb_addUpdateListener_Landroid_animation_ValueAnimator_Landroid_animation_ValueAnimator_AnimatorUpdateListener_ == null)
			{
				Indicator.cb_addUpdateListener_Landroid_animation_ValueAnimator_Landroid_animation_ValueAnimator_AnimatorUpdateListener_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr, IntPtr>(Indicator.n_AddUpdateListener_Landroid_animation_ValueAnimator_Landroid_animation_ValueAnimator_AnimatorUpdateListener_));
			}
			return Indicator.cb_addUpdateListener_Landroid_animation_ValueAnimator_Landroid_animation_ValueAnimator_AnimatorUpdateListener_;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00003434 File Offset: 0x00001634
		private static void n_AddUpdateListener_Landroid_animation_ValueAnimator_Landroid_animation_ValueAnimator_AnimatorUpdateListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			Indicator @object = Java.Lang.Object.GetObject<Indicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ValueAnimator object2 = Java.Lang.Object.GetObject<ValueAnimator>(native_p0, JniHandleOwnership.DoNotTransfer);
			ValueAnimator.IAnimatorUpdateListener object3 = Java.Lang.Object.GetObject<ValueAnimator.IAnimatorUpdateListener>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.AddUpdateListener(object2, object3);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00003464 File Offset: 0x00001664
		[Register("addUpdateListener", "(Landroid/animation/ValueAnimator;Landroid/animation/ValueAnimator$AnimatorUpdateListener;)V", "GetAddUpdateListener_Landroid_animation_ValueAnimator_Landroid_animation_ValueAnimator_AnimatorUpdateListener_Handler")]
		public unsafe virtual void AddUpdateListener(ValueAnimator p0, ValueAnimator.IAnimatorUpdateListener p1)
		{
			if (Indicator.id_addUpdateListener_Landroid_animation_ValueAnimator_Landroid_animation_ValueAnimator_AnimatorUpdateListener_ == IntPtr.Zero)
			{
				Indicator.id_addUpdateListener_Landroid_animation_ValueAnimator_Landroid_animation_ValueAnimator_AnimatorUpdateListener_ = JNIEnv.GetMethodID(Indicator.class_ref, "addUpdateListener", "(Landroid/animation/ValueAnimator;Landroid/animation/ValueAnimator$AnimatorUpdateListener;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			ptr[1] = new JValue(p1);
			if (base.GetType() == this.ThresholdType)
			{
				JNIEnv.CallVoidMethod(base.Handle, Indicator.id_addUpdateListener_Landroid_animation_ValueAnimator_Landroid_animation_ValueAnimator_AnimatorUpdateListener_, ptr);
				return;
			}
			JNIEnv.CallNonvirtualVoidMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "addUpdateListener", "(Landroid/animation/ValueAnimator;Landroid/animation/ValueAnimator$AnimatorUpdateListener;)V"), ptr);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00003512 File Offset: 0x00001712
		private static Delegate GetCenterXHandler()
		{
			if (Indicator.cb_centerX == null)
			{
				Indicator.cb_centerX = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, int>(Indicator.n_CenterX));
			}
			return Indicator.cb_centerX;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00003538 File Offset: 0x00001738
		private static int n_CenterX(IntPtr jnienv, IntPtr native__this)
		{
			Indicator @object = Java.Lang.Object.GetObject<Indicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return @object.CenterX();
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00003554 File Offset: 0x00001754
		[Register("centerX", "()I", "GetCenterXHandler")]
		public virtual int CenterX()
		{
			if (Indicator.id_centerX == IntPtr.Zero)
			{
				Indicator.id_centerX = JNIEnv.GetMethodID(Indicator.class_ref, "centerX", "()I");
			}
			if (base.GetType() == this.ThresholdType)
			{
				return JNIEnv.CallIntMethod(base.Handle, Indicator.id_centerX);
			}
			return JNIEnv.CallNonvirtualIntMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "centerX", "()I"));
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000035D5 File Offset: 0x000017D5
		private static Delegate GetCenterYHandler()
		{
			if (Indicator.cb_centerY == null)
			{
				Indicator.cb_centerY = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, int>(Indicator.n_CenterY));
			}
			return Indicator.cb_centerY;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000035FC File Offset: 0x000017FC
		private static int n_CenterY(IntPtr jnienv, IntPtr native__this)
		{
			Indicator @object = Java.Lang.Object.GetObject<Indicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return @object.CenterY();
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00003618 File Offset: 0x00001818
		[Register("centerY", "()I", "GetCenterYHandler")]
		public virtual int CenterY()
		{
			if (Indicator.id_centerY == IntPtr.Zero)
			{
				Indicator.id_centerY = JNIEnv.GetMethodID(Indicator.class_ref, "centerY", "()I");
			}
			if (base.GetType() == this.ThresholdType)
			{
				return JNIEnv.CallIntMethod(base.Handle, Indicator.id_centerY);
			}
			return JNIEnv.CallNonvirtualIntMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "centerY", "()I"));
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00003699 File Offset: 0x00001899
		private static Delegate GetDraw_Landroid_graphics_Canvas_Handler()
		{
			if (Indicator.cb_draw_Landroid_graphics_Canvas_ == null)
			{
				Indicator.cb_draw_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr>(Indicator.n_Draw_Landroid_graphics_Canvas_));
			}
			return Indicator.cb_draw_Landroid_graphics_Canvas_;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000036C0 File Offset: 0x000018C0
		private static void n_Draw_Landroid_graphics_Canvas_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			Indicator @object = Java.Lang.Object.GetObject<Indicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Canvas object2 = Java.Lang.Object.GetObject<Canvas>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Draw(object2);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000036E8 File Offset: 0x000018E8
		[Register("draw", "(Landroid/graphics/Canvas;)V", "GetDraw_Landroid_graphics_Canvas_Handler")]
		public unsafe override void Draw(Canvas p0)
		{
			if (Indicator.id_draw_Landroid_graphics_Canvas_ == IntPtr.Zero)
			{
				Indicator.id_draw_Landroid_graphics_Canvas_ = JNIEnv.GetMethodID(Indicator.class_ref, "draw", "(Landroid/graphics/Canvas;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			if (base.GetType() == this.ThresholdType)
			{
				JNIEnv.CallVoidMethod(base.Handle, Indicator.id_draw_Landroid_graphics_Canvas_, ptr);
				return;
			}
			JNIEnv.CallNonvirtualVoidMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "draw", "(Landroid/graphics/Canvas;)V"), ptr);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00003783 File Offset: 0x00001983
		private static Delegate GetDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_Handler()
		{
			if (Indicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ == null)
			{
				Indicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr, IntPtr>(Indicator.n_Draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_));
			}
			return Indicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000037A8 File Offset: 0x000019A8
		private static void n_Draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			Indicator @object = Java.Lang.Object.GetObject<Indicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Canvas object2 = Java.Lang.Object.GetObject<Canvas>(native_p0, JniHandleOwnership.DoNotTransfer);
			Paint object3 = Java.Lang.Object.GetObject<Paint>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.Draw(object2, object3);
		}

		// Token: 0x06000054 RID: 84
		[Register("draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V", "GetDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_Handler")]
		public abstract void Draw(Canvas p0, Paint p1);

		// Token: 0x06000055 RID: 85 RVA: 0x000037D6 File Offset: 0x000019D6
		private static Delegate GetExactCenterXHandler()
		{
			if (Indicator.cb_exactCenterX == null)
			{
				Indicator.cb_exactCenterX = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, float>(Indicator.n_ExactCenterX));
			}
			return Indicator.cb_exactCenterX;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000037FC File Offset: 0x000019FC
		private static float n_ExactCenterX(IntPtr jnienv, IntPtr native__this)
		{
			Indicator @object = Java.Lang.Object.GetObject<Indicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return @object.ExactCenterX();
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00003818 File Offset: 0x00001A18
		[Register("exactCenterX", "()F", "GetExactCenterXHandler")]
		public virtual float ExactCenterX()
		{
			if (Indicator.id_exactCenterX == IntPtr.Zero)
			{
				Indicator.id_exactCenterX = JNIEnv.GetMethodID(Indicator.class_ref, "exactCenterX", "()F");
			}
			if (base.GetType() == this.ThresholdType)
			{
				return JNIEnv.CallFloatMethod(base.Handle, Indicator.id_exactCenterX);
			}
			return JNIEnv.CallNonvirtualFloatMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "exactCenterX", "()F"));
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00003899 File Offset: 0x00001A99
		private static Delegate GetExactCenterYHandler()
		{
			if (Indicator.cb_exactCenterY == null)
			{
				Indicator.cb_exactCenterY = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, float>(Indicator.n_ExactCenterY));
			}
			return Indicator.cb_exactCenterY;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000038C0 File Offset: 0x00001AC0
		private static float n_ExactCenterY(IntPtr jnienv, IntPtr native__this)
		{
			Indicator @object = Java.Lang.Object.GetObject<Indicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return @object.ExactCenterY();
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000038DC File Offset: 0x00001ADC
		[Register("exactCenterY", "()F", "GetExactCenterYHandler")]
		public virtual float ExactCenterY()
		{
			if (Indicator.id_exactCenterY == IntPtr.Zero)
			{
				Indicator.id_exactCenterY = JNIEnv.GetMethodID(Indicator.class_ref, "exactCenterY", "()F");
			}
			if (base.GetType() == this.ThresholdType)
			{
				return JNIEnv.CallFloatMethod(base.Handle, Indicator.id_exactCenterY);
			}
			return JNIEnv.CallNonvirtualFloatMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "exactCenterY", "()F"));
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000395D File Offset: 0x00001B5D
		private static Delegate GetOnCreateAnimatorsHandler()
		{
			if (Indicator.cb_onCreateAnimators == null)
			{
				Indicator.cb_onCreateAnimators = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr>(Indicator.n_OnCreateAnimators));
			}
			return Indicator.cb_onCreateAnimators;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00003984 File Offset: 0x00001B84
		private static IntPtr n_OnCreateAnimators(IntPtr jnienv, IntPtr native__this)
		{
			Indicator @object = Java.Lang.Object.GetObject<Indicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JavaList<ValueAnimator>.ToLocalJniHandle(@object.OnCreateAnimators());
		}

		// Token: 0x0600005D RID: 93
		[Register("onCreateAnimators", "()Ljava/util/ArrayList;", "GetOnCreateAnimatorsHandler")]
		public abstract IList<ValueAnimator> OnCreateAnimators();

		// Token: 0x0600005E RID: 94 RVA: 0x000039A5 File Offset: 0x00001BA5
		private static Delegate GetPostInvalidateHandler()
		{
			if (Indicator.cb_postInvalidate == null)
			{
				Indicator.cb_postInvalidate = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr>(Indicator.n_PostInvalidate));
			}
			return Indicator.cb_postInvalidate;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000039CC File Offset: 0x00001BCC
		private static void n_PostInvalidate(IntPtr jnienv, IntPtr native__this)
		{
			Indicator @object = Java.Lang.Object.GetObject<Indicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			@object.PostInvalidate();
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000039E8 File Offset: 0x00001BE8
		[Register("postInvalidate", "()V", "GetPostInvalidateHandler")]
		public virtual void PostInvalidate()
		{
			if (Indicator.id_postInvalidate == IntPtr.Zero)
			{
				Indicator.id_postInvalidate = JNIEnv.GetMethodID(Indicator.class_ref, "postInvalidate", "()V");
			}
			if (base.GetType() == this.ThresholdType)
			{
				JNIEnv.CallVoidMethod(base.Handle, Indicator.id_postInvalidate);
				return;
			}
			JNIEnv.CallNonvirtualVoidMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "postInvalidate", "()V"));
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00003A69 File Offset: 0x00001C69
		private static Delegate GetSetAlpha_IHandler()
		{
			if (Indicator.cb_setAlpha_I == null)
			{
				Indicator.cb_setAlpha_I = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, int>(Indicator.n_SetAlpha_I));
			}
			return Indicator.cb_setAlpha_I;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00003A90 File Offset: 0x00001C90
		private static void n_SetAlpha_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			Indicator @object = Java.Lang.Object.GetObject<Indicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			@object.SetAlpha(p0);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00003AB0 File Offset: 0x00001CB0
		[Register("setAlpha", "(I)V", "GetSetAlpha_IHandler")]
		public unsafe override void SetAlpha(int p0)
		{
			if (Indicator.id_setAlpha_I == IntPtr.Zero)
			{
				Indicator.id_setAlpha_I = JNIEnv.GetMethodID(Indicator.class_ref, "setAlpha", "(I)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			if (base.GetType() == this.ThresholdType)
			{
				JNIEnv.CallVoidMethod(base.Handle, Indicator.id_setAlpha_I, ptr);
				return;
			}
			JNIEnv.CallNonvirtualVoidMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "setAlpha", "(I)V"), ptr);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00003B4B File Offset: 0x00001D4B
		private static Delegate GetSetColorFilter_Landroid_graphics_ColorFilter_Handler()
		{
			if (Indicator.cb_setColorFilter_Landroid_graphics_ColorFilter_ == null)
			{
				Indicator.cb_setColorFilter_Landroid_graphics_ColorFilter_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr>(Indicator.n_SetColorFilter_Landroid_graphics_ColorFilter_));
			}
			return Indicator.cb_setColorFilter_Landroid_graphics_ColorFilter_;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00003B70 File Offset: 0x00001D70
		private static void n_SetColorFilter_Landroid_graphics_ColorFilter_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			Indicator @object = Java.Lang.Object.GetObject<Indicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorFilter object2 = Java.Lang.Object.GetObject<ColorFilter>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetColorFilter(object2);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00003B98 File Offset: 0x00001D98
		[Register("setColorFilter", "(Landroid/graphics/ColorFilter;)V", "GetSetColorFilter_Landroid_graphics_ColorFilter_Handler")]
		public unsafe override void SetColorFilter(ColorFilter p0)
		{
			if (Indicator.id_setColorFilter_Landroid_graphics_ColorFilter_ == IntPtr.Zero)
			{
				Indicator.id_setColorFilter_Landroid_graphics_ColorFilter_ = JNIEnv.GetMethodID(Indicator.class_ref, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			if (base.GetType() == this.ThresholdType)
			{
				JNIEnv.CallVoidMethod(base.Handle, Indicator.id_setColorFilter_Landroid_graphics_ColorFilter_, ptr);
				return;
			}
			JNIEnv.CallNonvirtualVoidMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V"), ptr);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00003C33 File Offset: 0x00001E33
		private static Delegate GetSetDrawBounds_IIIIHandler()
		{
			if (Indicator.cb_setDrawBounds_IIII == null)
			{
				Indicator.cb_setDrawBounds_IIII = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, int, int, int, int>(Indicator.n_SetDrawBounds_IIII));
			}
			return Indicator.cb_setDrawBounds_IIII;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00003C58 File Offset: 0x00001E58
		private static void n_SetDrawBounds_IIII(IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3)
		{
			Indicator @object = Java.Lang.Object.GetObject<Indicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			@object.SetDrawBounds(p0, p1, p2, p3);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00003C7C File Offset: 0x00001E7C
		[Register("setDrawBounds", "(IIII)V", "GetSetDrawBounds_IIIIHandler")]
		public unsafe virtual void SetDrawBounds(int p0, int p1, int p2, int p3)
		{
			if (Indicator.id_setDrawBounds_IIII == IntPtr.Zero)
			{
				Indicator.id_setDrawBounds_IIII = JNIEnv.GetMethodID(Indicator.class_ref, "setDrawBounds", "(IIII)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			ptr[1] = new JValue(p1);
			ptr[2] = new JValue(p2);
			ptr[3] = new JValue(p3);
			if (base.GetType() == this.ThresholdType)
			{
				JNIEnv.CallVoidMethod(base.Handle, Indicator.id_setDrawBounds_IIII, ptr);
				return;
			}
			JNIEnv.CallNonvirtualVoidMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "setDrawBounds", "(IIII)V"), ptr);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00003D57 File Offset: 0x00001F57
		private static Delegate GetStartHandler()
		{
			if (Indicator.cb_start == null)
			{
				Indicator.cb_start = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr>(Indicator.n_Start));
			}
			return Indicator.cb_start;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00003D7C File Offset: 0x00001F7C
		private static void n_Start(IntPtr jnienv, IntPtr native__this)
		{
			Indicator @object = Java.Lang.Object.GetObject<Indicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			@object.Start();
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00003D98 File Offset: 0x00001F98
		[Register("start", "()V", "GetStartHandler")]
		public virtual void Start()
		{
			if (Indicator.id_start == IntPtr.Zero)
			{
				Indicator.id_start = JNIEnv.GetMethodID(Indicator.class_ref, "start", "()V");
			}
			if (base.GetType() == this.ThresholdType)
			{
				JNIEnv.CallVoidMethod(base.Handle, Indicator.id_start);
				return;
			}
			JNIEnv.CallNonvirtualVoidMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "start", "()V"));
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00003E19 File Offset: 0x00002019
		private static Delegate GetStopHandler()
		{
			if (Indicator.cb_stop == null)
			{
				Indicator.cb_stop = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr>(Indicator.n_Stop));
			}
			return Indicator.cb_stop;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00003E40 File Offset: 0x00002040
		private static void n_Stop(IntPtr jnienv, IntPtr native__this)
		{
			Indicator @object = Java.Lang.Object.GetObject<Indicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			@object.Stop();
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00003E5C File Offset: 0x0000205C
		[Register("stop", "()V", "GetStopHandler")]
		public virtual void Stop()
		{
			if (Indicator.id_stop == IntPtr.Zero)
			{
				Indicator.id_stop = JNIEnv.GetMethodID(Indicator.class_ref, "stop", "()V");
			}
			if (base.GetType() == this.ThresholdType)
			{
				JNIEnv.CallVoidMethod(base.Handle, Indicator.id_stop);
				return;
			}
			JNIEnv.CallNonvirtualVoidMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "stop", "()V"));
		}

		// Token: 0x0400001E RID: 30
		internal static IntPtr java_class_handle;

		// Token: 0x0400001F RID: 31
		private static IntPtr id_ctor;

		// Token: 0x04000020 RID: 32
		private static Delegate cb_getColor;

		// Token: 0x04000021 RID: 33
		private static Delegate cb_setColor_I;

		// Token: 0x04000022 RID: 34
		private static IntPtr id_getColor;

		// Token: 0x04000023 RID: 35
		private static IntPtr id_setColor_I;

		// Token: 0x04000024 RID: 36
		private static Delegate cb_getDrawBounds;

		// Token: 0x04000025 RID: 37
		private static Delegate cb_setDrawBounds_Landroid_graphics_Rect_;

		// Token: 0x04000026 RID: 38
		private static IntPtr id_getDrawBounds;

		// Token: 0x04000027 RID: 39
		private static IntPtr id_setDrawBounds_Landroid_graphics_Rect_;

		// Token: 0x04000028 RID: 40
		private static Delegate cb_getHeight;

		// Token: 0x04000029 RID: 41
		private static IntPtr id_getHeight;

		// Token: 0x0400002A RID: 42
		private static Delegate cb_isRunning;

		// Token: 0x0400002B RID: 43
		private static IntPtr id_isRunning;

		// Token: 0x0400002C RID: 44
		private static Delegate cb_getOpacity;

		// Token: 0x0400002D RID: 45
		private static IntPtr id_getOpacity;

		// Token: 0x0400002E RID: 46
		private static Delegate cb_getWidth;

		// Token: 0x0400002F RID: 47
		private static IntPtr id_getWidth;

		// Token: 0x04000030 RID: 48
		private static Delegate cb_addUpdateListener_Landroid_animation_ValueAnimator_Landroid_animation_ValueAnimator_AnimatorUpdateListener_;

		// Token: 0x04000031 RID: 49
		private static IntPtr id_addUpdateListener_Landroid_animation_ValueAnimator_Landroid_animation_ValueAnimator_AnimatorUpdateListener_;

		// Token: 0x04000032 RID: 50
		private static Delegate cb_centerX;

		// Token: 0x04000033 RID: 51
		private static IntPtr id_centerX;

		// Token: 0x04000034 RID: 52
		private static Delegate cb_centerY;

		// Token: 0x04000035 RID: 53
		private static IntPtr id_centerY;

		// Token: 0x04000036 RID: 54
		private static Delegate cb_draw_Landroid_graphics_Canvas_;

		// Token: 0x04000037 RID: 55
		private static IntPtr id_draw_Landroid_graphics_Canvas_;

		// Token: 0x04000038 RID: 56
		private static Delegate cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;

		// Token: 0x04000039 RID: 57
		private static Delegate cb_exactCenterX;

		// Token: 0x0400003A RID: 58
		private static IntPtr id_exactCenterX;

		// Token: 0x0400003B RID: 59
		private static Delegate cb_exactCenterY;

		// Token: 0x0400003C RID: 60
		private static IntPtr id_exactCenterY;

		// Token: 0x0400003D RID: 61
		private static Delegate cb_onCreateAnimators;

		// Token: 0x0400003E RID: 62
		private static Delegate cb_postInvalidate;

		// Token: 0x0400003F RID: 63
		private static IntPtr id_postInvalidate;

		// Token: 0x04000040 RID: 64
		private static Delegate cb_setAlpha_I;

		// Token: 0x04000041 RID: 65
		private static IntPtr id_setAlpha_I;

		// Token: 0x04000042 RID: 66
		private static Delegate cb_setColorFilter_Landroid_graphics_ColorFilter_;

		// Token: 0x04000043 RID: 67
		private static IntPtr id_setColorFilter_Landroid_graphics_ColorFilter_;

		// Token: 0x04000044 RID: 68
		private static Delegate cb_setDrawBounds_IIII;

		// Token: 0x04000045 RID: 69
		private static IntPtr id_setDrawBounds_IIII;

		// Token: 0x04000046 RID: 70
		private static Delegate cb_start;

		// Token: 0x04000047 RID: 71
		private static IntPtr id_start;

		// Token: 0x04000048 RID: 72
		private static Delegate cb_stop;

		// Token: 0x04000049 RID: 73
		private static IntPtr id_stop;
	}
}
