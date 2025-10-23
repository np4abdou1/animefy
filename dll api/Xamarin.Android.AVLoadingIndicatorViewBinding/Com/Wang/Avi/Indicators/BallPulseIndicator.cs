using System;
using System.Collections.Generic;
using Android.Animation;
using Android.Graphics;
using Android.Runtime;
using Java.Lang;

namespace Com.Wang.Avi.Indicators
{
	// Token: 0x0200000D RID: 13
	[Register("com/wang/avi/indicators/BallPulseIndicator", DoNotGenerateAcw = true)]
	public class BallPulseIndicator : Indicator
	{
		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x00005101 File Offset: 0x00003301
		internal new static IntPtr class_ref
		{
			get
			{
				return JNIEnv.FindClass("com/wang/avi/indicators/BallPulseIndicator", ref BallPulseIndicator.java_class_handle);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x00005112 File Offset: 0x00003312
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BallPulseIndicator.class_ref;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00005119 File Offset: 0x00003319
		protected override Type ThresholdType
		{
			get
			{
				return typeof(BallPulseIndicator);
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00003EDD File Offset: 0x000020DD
		protected BallPulseIndicator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00005128 File Offset: 0x00003328
		[Register(".ctor", "()V", "")]
		public BallPulseIndicator() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			if (base.GetType() != typeof(BallPulseIndicator))
			{
				base.SetHandle(JNIEnv.StartCreateInstance(base.GetType(), "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				return;
			}
			if (BallPulseIndicator.id_ctor == IntPtr.Zero)
			{
				BallPulseIndicator.id_ctor = JNIEnv.GetMethodID(BallPulseIndicator.class_ref, "<init>", "()V");
			}
			base.SetHandle(JNIEnv.StartCreateInstance(BallPulseIndicator.class_ref, BallPulseIndicator.id_ctor, Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance(base.Handle, BallPulseIndicator.class_ref, BallPulseIndicator.id_ctor, Array.Empty<JValue>());
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000051FC File Offset: 0x000033FC
		private static Delegate GetDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_Handler()
		{
			if (BallPulseIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ == null)
			{
				BallPulseIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr, IntPtr>(BallPulseIndicator.n_Draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_));
			}
			return BallPulseIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00005220 File Offset: 0x00003420
		private static void n_Draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			BallPulseIndicator @object = Java.Lang.Object.GetObject<BallPulseIndicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Canvas object2 = Java.Lang.Object.GetObject<Canvas>(native_p0, JniHandleOwnership.DoNotTransfer);
			Paint object3 = Java.Lang.Object.GetObject<Paint>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.Draw(object2, object3);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00005250 File Offset: 0x00003450
		[Register("draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V", "GetDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_Handler")]
		public unsafe override void Draw(Canvas p0, Paint p1)
		{
			if (BallPulseIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ == IntPtr.Zero)
			{
				BallPulseIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ = JNIEnv.GetMethodID(BallPulseIndicator.class_ref, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			ptr[1] = new JValue(p1);
			if (base.GetType() == this.ThresholdType)
			{
				JNIEnv.CallVoidMethod(base.Handle, BallPulseIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_, ptr);
				return;
			}
			JNIEnv.CallNonvirtualVoidMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V"), ptr);
			GC.KeepAlive(p0);
			GC.KeepAlive(p1);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000530A File Offset: 0x0000350A
		private static Delegate GetOnCreateAnimatorsHandler()
		{
			if (BallPulseIndicator.cb_onCreateAnimators == null)
			{
				BallPulseIndicator.cb_onCreateAnimators = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr>(BallPulseIndicator.n_OnCreateAnimators));
			}
			return BallPulseIndicator.cb_onCreateAnimators;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00005330 File Offset: 0x00003530
		private static IntPtr n_OnCreateAnimators(IntPtr jnienv, IntPtr native__this)
		{
			BallPulseIndicator @object = Java.Lang.Object.GetObject<BallPulseIndicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JavaList<ValueAnimator>.ToLocalJniHandle(@object.OnCreateAnimators());
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00005354 File Offset: 0x00003554
		[Register("onCreateAnimators", "()Ljava/util/ArrayList;", "GetOnCreateAnimatorsHandler")]
		public override IList<ValueAnimator> OnCreateAnimators()
		{
			if (BallPulseIndicator.id_onCreateAnimators == IntPtr.Zero)
			{
				BallPulseIndicator.id_onCreateAnimators = JNIEnv.GetMethodID(BallPulseIndicator.class_ref, "onCreateAnimators", "()Ljava/util/ArrayList;");
			}
			if (base.GetType() == this.ThresholdType)
			{
				return JavaList<ValueAnimator>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, BallPulseIndicator.id_onCreateAnimators), JniHandleOwnership.TransferLocalRef);
			}
			return JavaList<ValueAnimator>.FromJniHandle(JNIEnv.CallNonvirtualObjectMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "onCreateAnimators", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000072 RID: 114
		[Register("SCALE")]
		public const float Scale = 1f;

		// Token: 0x04000073 RID: 115
		internal new static IntPtr java_class_handle;

		// Token: 0x04000074 RID: 116
		private static IntPtr id_ctor;

		// Token: 0x04000075 RID: 117
		private static Delegate cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;

		// Token: 0x04000076 RID: 118
		private static IntPtr id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;

		// Token: 0x04000077 RID: 119
		private static Delegate cb_onCreateAnimators;

		// Token: 0x04000078 RID: 120
		private static IntPtr id_onCreateAnimators;
	}
}
