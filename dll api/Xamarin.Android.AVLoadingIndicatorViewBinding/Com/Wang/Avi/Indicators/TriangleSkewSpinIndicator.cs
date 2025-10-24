using System;
using System.Collections.Generic;
using Android.Animation;
using Android.Graphics;
using Android.Runtime;
using Java.Lang;

namespace Com.Wang.Avi.Indicators
{
	// Token: 0x02000023 RID: 35
	[Register("com/wang/avi/indicators/TriangleSkewSpinIndicator", DoNotGenerateAcw = true)]
	public class TriangleSkewSpinIndicator : Indicator
	{
		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000182 RID: 386 RVA: 0x00008475 File Offset: 0x00006675
		internal new static IntPtr class_ref
		{
			get
			{
				return JNIEnv.FindClass("com/wang/avi/indicators/TriangleSkewSpinIndicator", ref TriangleSkewSpinIndicator.java_class_handle);
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000183 RID: 387 RVA: 0x00008486 File Offset: 0x00006686
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TriangleSkewSpinIndicator.class_ref;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000184 RID: 388 RVA: 0x0000848D File Offset: 0x0000668D
		protected override Type ThresholdType
		{
			get
			{
				return typeof(TriangleSkewSpinIndicator);
			}
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00003EDD File Offset: 0x000020DD
		protected TriangleSkewSpinIndicator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0000849C File Offset: 0x0000669C
		[Register(".ctor", "()V", "")]
		public TriangleSkewSpinIndicator() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			if (base.GetType() != typeof(TriangleSkewSpinIndicator))
			{
				base.SetHandle(JNIEnv.StartCreateInstance(base.GetType(), "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				return;
			}
			if (TriangleSkewSpinIndicator.id_ctor == IntPtr.Zero)
			{
				TriangleSkewSpinIndicator.id_ctor = JNIEnv.GetMethodID(TriangleSkewSpinIndicator.class_ref, "<init>", "()V");
			}
			base.SetHandle(JNIEnv.StartCreateInstance(TriangleSkewSpinIndicator.class_ref, TriangleSkewSpinIndicator.id_ctor, Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance(base.Handle, TriangleSkewSpinIndicator.class_ref, TriangleSkewSpinIndicator.id_ctor, Array.Empty<JValue>());
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00008570 File Offset: 0x00006770
		private static Delegate GetDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_Handler()
		{
			if (TriangleSkewSpinIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ == null)
			{
				TriangleSkewSpinIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr, IntPtr>(TriangleSkewSpinIndicator.n_Draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_));
			}
			return TriangleSkewSpinIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00008594 File Offset: 0x00006794
		private static void n_Draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			TriangleSkewSpinIndicator @object = Java.Lang.Object.GetObject<TriangleSkewSpinIndicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Canvas object2 = Java.Lang.Object.GetObject<Canvas>(native_p0, JniHandleOwnership.DoNotTransfer);
			Paint object3 = Java.Lang.Object.GetObject<Paint>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.Draw(object2, object3);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x000085C4 File Offset: 0x000067C4
		[Register("draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V", "GetDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_Handler")]
		public unsafe override void Draw(Canvas p0, Paint p1)
		{
			if (TriangleSkewSpinIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ == IntPtr.Zero)
			{
				TriangleSkewSpinIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ = JNIEnv.GetMethodID(TriangleSkewSpinIndicator.class_ref, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			ptr[1] = new JValue(p1);
			if (base.GetType() == this.ThresholdType)
			{
				JNIEnv.CallVoidMethod(base.Handle, TriangleSkewSpinIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_, ptr);
				return;
			}
			JNIEnv.CallNonvirtualVoidMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V"), ptr);
			GC.KeepAlive(p0);
			GC.KeepAlive(p1);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0000867E File Offset: 0x0000687E
		private static Delegate GetOnCreateAnimatorsHandler()
		{
			if (TriangleSkewSpinIndicator.cb_onCreateAnimators == null)
			{
				TriangleSkewSpinIndicator.cb_onCreateAnimators = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr>(TriangleSkewSpinIndicator.n_OnCreateAnimators));
			}
			return TriangleSkewSpinIndicator.cb_onCreateAnimators;
		}

		// Token: 0x0600018B RID: 395 RVA: 0x000086A4 File Offset: 0x000068A4
		private static IntPtr n_OnCreateAnimators(IntPtr jnienv, IntPtr native__this)
		{
			TriangleSkewSpinIndicator @object = Java.Lang.Object.GetObject<TriangleSkewSpinIndicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JavaList<ValueAnimator>.ToLocalJniHandle(@object.OnCreateAnimators());
		}

		// Token: 0x0600018C RID: 396 RVA: 0x000086C8 File Offset: 0x000068C8
		[Register("onCreateAnimators", "()Ljava/util/ArrayList;", "GetOnCreateAnimatorsHandler")]
		public override IList<ValueAnimator> OnCreateAnimators()
		{
			if (TriangleSkewSpinIndicator.id_onCreateAnimators == IntPtr.Zero)
			{
				TriangleSkewSpinIndicator.id_onCreateAnimators = JNIEnv.GetMethodID(TriangleSkewSpinIndicator.class_ref, "onCreateAnimators", "()Ljava/util/ArrayList;");
			}
			if (base.GetType() == this.ThresholdType)
			{
				return JavaList<ValueAnimator>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, TriangleSkewSpinIndicator.id_onCreateAnimators), JniHandleOwnership.TransferLocalRef);
			}
			return JavaList<ValueAnimator>.FromJniHandle(JNIEnv.CallNonvirtualObjectMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "onCreateAnimators", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040000E0 RID: 224
		internal new static IntPtr java_class_handle;

		// Token: 0x040000E1 RID: 225
		private static IntPtr id_ctor;

		// Token: 0x040000E2 RID: 226
		private static Delegate cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;

		// Token: 0x040000E3 RID: 227
		private static IntPtr id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;

		// Token: 0x040000E4 RID: 228
		private static Delegate cb_onCreateAnimators;

		// Token: 0x040000E5 RID: 229
		private static IntPtr id_onCreateAnimators;
	}
}
