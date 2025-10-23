using System;
using System.Collections.Generic;
using Android.Animation;
using Android.Graphics;
using Android.Runtime;
using Java.Lang;

namespace Com.Wang.Avi.Indicators
{
	// Token: 0x02000012 RID: 18
	[Register("com/wang/avi/indicators/BallScaleMultipleIndicator", DoNotGenerateAcw = true)]
	public class BallScaleMultipleIndicator : Indicator
	{
		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000ED RID: 237 RVA: 0x00005F61 File Offset: 0x00004161
		internal new static IntPtr class_ref
		{
			get
			{
				return JNIEnv.FindClass("com/wang/avi/indicators/BallScaleMultipleIndicator", ref BallScaleMultipleIndicator.java_class_handle);
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000EE RID: 238 RVA: 0x00005F72 File Offset: 0x00004172
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BallScaleMultipleIndicator.class_ref;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000EF RID: 239 RVA: 0x00005F79 File Offset: 0x00004179
		protected override Type ThresholdType
		{
			get
			{
				return typeof(BallScaleMultipleIndicator);
			}
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00003EDD File Offset: 0x000020DD
		protected BallScaleMultipleIndicator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00005F88 File Offset: 0x00004188
		[Register(".ctor", "()V", "")]
		public BallScaleMultipleIndicator() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			if (base.GetType() != typeof(BallScaleMultipleIndicator))
			{
				base.SetHandle(JNIEnv.StartCreateInstance(base.GetType(), "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				return;
			}
			if (BallScaleMultipleIndicator.id_ctor == IntPtr.Zero)
			{
				BallScaleMultipleIndicator.id_ctor = JNIEnv.GetMethodID(BallScaleMultipleIndicator.class_ref, "<init>", "()V");
			}
			base.SetHandle(JNIEnv.StartCreateInstance(BallScaleMultipleIndicator.class_ref, BallScaleMultipleIndicator.id_ctor, Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance(base.Handle, BallScaleMultipleIndicator.class_ref, BallScaleMultipleIndicator.id_ctor, Array.Empty<JValue>());
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0000605C File Offset: 0x0000425C
		private static Delegate GetDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_Handler()
		{
			if (BallScaleMultipleIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ == null)
			{
				BallScaleMultipleIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr, IntPtr>(BallScaleMultipleIndicator.n_Draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_));
			}
			return BallScaleMultipleIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00006080 File Offset: 0x00004280
		private static void n_Draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			BallScaleMultipleIndicator @object = Java.Lang.Object.GetObject<BallScaleMultipleIndicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Canvas object2 = Java.Lang.Object.GetObject<Canvas>(native_p0, JniHandleOwnership.DoNotTransfer);
			Paint object3 = Java.Lang.Object.GetObject<Paint>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.Draw(object2, object3);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x000060B0 File Offset: 0x000042B0
		[Register("draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V", "GetDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_Handler")]
		public unsafe override void Draw(Canvas p0, Paint p1)
		{
			if (BallScaleMultipleIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ == IntPtr.Zero)
			{
				BallScaleMultipleIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ = JNIEnv.GetMethodID(BallScaleMultipleIndicator.class_ref, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			ptr[1] = new JValue(p1);
			if (base.GetType() == this.ThresholdType)
			{
				JNIEnv.CallVoidMethod(base.Handle, BallScaleMultipleIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_, ptr);
				return;
			}
			JNIEnv.CallNonvirtualVoidMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V"), ptr);
			GC.KeepAlive(p0);
			GC.KeepAlive(p1);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0000616A File Offset: 0x0000436A
		private static Delegate GetOnCreateAnimatorsHandler()
		{
			if (BallScaleMultipleIndicator.cb_onCreateAnimators == null)
			{
				BallScaleMultipleIndicator.cb_onCreateAnimators = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr>(BallScaleMultipleIndicator.n_OnCreateAnimators));
			}
			return BallScaleMultipleIndicator.cb_onCreateAnimators;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00006190 File Offset: 0x00004390
		private static IntPtr n_OnCreateAnimators(IntPtr jnienv, IntPtr native__this)
		{
			BallScaleMultipleIndicator @object = Java.Lang.Object.GetObject<BallScaleMultipleIndicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JavaList<ValueAnimator>.ToLocalJniHandle(@object.OnCreateAnimators());
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x000061B4 File Offset: 0x000043B4
		[Register("onCreateAnimators", "()Ljava/util/ArrayList;", "GetOnCreateAnimatorsHandler")]
		public override IList<ValueAnimator> OnCreateAnimators()
		{
			if (BallScaleMultipleIndicator.id_onCreateAnimators == IntPtr.Zero)
			{
				BallScaleMultipleIndicator.id_onCreateAnimators = JNIEnv.GetMethodID(BallScaleMultipleIndicator.class_ref, "onCreateAnimators", "()Ljava/util/ArrayList;");
			}
			if (base.GetType() == this.ThresholdType)
			{
				return JavaList<ValueAnimator>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, BallScaleMultipleIndicator.id_onCreateAnimators), JniHandleOwnership.TransferLocalRef);
			}
			return JavaList<ValueAnimator>.FromJniHandle(JNIEnv.CallNonvirtualObjectMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "onCreateAnimators", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000091 RID: 145
		internal new static IntPtr java_class_handle;

		// Token: 0x04000092 RID: 146
		private static IntPtr id_ctor;

		// Token: 0x04000093 RID: 147
		private static Delegate cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;

		// Token: 0x04000094 RID: 148
		private static IntPtr id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;

		// Token: 0x04000095 RID: 149
		private static Delegate cb_onCreateAnimators;

		// Token: 0x04000096 RID: 150
		private static IntPtr id_onCreateAnimators;
	}
}
