using System;
using System.Collections.Generic;
using Android.Animation;
using Android.Graphics;
using Android.Runtime;
using Java.Lang;

namespace Com.Wang.Avi.Indicators
{
	// Token: 0x0200000E RID: 14
	[Register("com/wang/avi/indicators/BallPulseRiseIndicator", DoNotGenerateAcw = true)]
	public class BallPulseRiseIndicator : Indicator
	{
		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x000053E1 File Offset: 0x000035E1
		internal new static IntPtr class_ref
		{
			get
			{
				return JNIEnv.FindClass("com/wang/avi/indicators/BallPulseRiseIndicator", ref BallPulseRiseIndicator.java_class_handle);
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x000053F2 File Offset: 0x000035F2
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BallPulseRiseIndicator.class_ref;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x000053F9 File Offset: 0x000035F9
		protected override Type ThresholdType
		{
			get
			{
				return typeof(BallPulseRiseIndicator);
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00003EDD File Offset: 0x000020DD
		protected BallPulseRiseIndicator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00005408 File Offset: 0x00003608
		[Register(".ctor", "()V", "")]
		public BallPulseRiseIndicator() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			if (base.GetType() != typeof(BallPulseRiseIndicator))
			{
				base.SetHandle(JNIEnv.StartCreateInstance(base.GetType(), "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				return;
			}
			if (BallPulseRiseIndicator.id_ctor == IntPtr.Zero)
			{
				BallPulseRiseIndicator.id_ctor = JNIEnv.GetMethodID(BallPulseRiseIndicator.class_ref, "<init>", "()V");
			}
			base.SetHandle(JNIEnv.StartCreateInstance(BallPulseRiseIndicator.class_ref, BallPulseRiseIndicator.id_ctor, Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance(base.Handle, BallPulseRiseIndicator.class_ref, BallPulseRiseIndicator.id_ctor, Array.Empty<JValue>());
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000054DC File Offset: 0x000036DC
		private static Delegate GetDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_Handler()
		{
			if (BallPulseRiseIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ == null)
			{
				BallPulseRiseIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr, IntPtr>(BallPulseRiseIndicator.n_Draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_));
			}
			return BallPulseRiseIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00005500 File Offset: 0x00003700
		private static void n_Draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			BallPulseRiseIndicator @object = Java.Lang.Object.GetObject<BallPulseRiseIndicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Canvas object2 = Java.Lang.Object.GetObject<Canvas>(native_p0, JniHandleOwnership.DoNotTransfer);
			Paint object3 = Java.Lang.Object.GetObject<Paint>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.Draw(object2, object3);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00005530 File Offset: 0x00003730
		[Register("draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V", "GetDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_Handler")]
		public unsafe override void Draw(Canvas p0, Paint p1)
		{
			if (BallPulseRiseIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ == IntPtr.Zero)
			{
				BallPulseRiseIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ = JNIEnv.GetMethodID(BallPulseRiseIndicator.class_ref, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			ptr[1] = new JValue(p1);
			if (base.GetType() == this.ThresholdType)
			{
				JNIEnv.CallVoidMethod(base.Handle, BallPulseRiseIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_, ptr);
				return;
			}
			JNIEnv.CallNonvirtualVoidMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V"), ptr);
			GC.KeepAlive(p0);
			GC.KeepAlive(p1);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000055EA File Offset: 0x000037EA
		private static Delegate GetOnCreateAnimatorsHandler()
		{
			if (BallPulseRiseIndicator.cb_onCreateAnimators == null)
			{
				BallPulseRiseIndicator.cb_onCreateAnimators = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr>(BallPulseRiseIndicator.n_OnCreateAnimators));
			}
			return BallPulseRiseIndicator.cb_onCreateAnimators;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00005610 File Offset: 0x00003810
		private static IntPtr n_OnCreateAnimators(IntPtr jnienv, IntPtr native__this)
		{
			BallPulseRiseIndicator @object = Java.Lang.Object.GetObject<BallPulseRiseIndicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JavaList<ValueAnimator>.ToLocalJniHandle(@object.OnCreateAnimators());
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00005634 File Offset: 0x00003834
		[Register("onCreateAnimators", "()Ljava/util/ArrayList;", "GetOnCreateAnimatorsHandler")]
		public override IList<ValueAnimator> OnCreateAnimators()
		{
			if (BallPulseRiseIndicator.id_onCreateAnimators == IntPtr.Zero)
			{
				BallPulseRiseIndicator.id_onCreateAnimators = JNIEnv.GetMethodID(BallPulseRiseIndicator.class_ref, "onCreateAnimators", "()Ljava/util/ArrayList;");
			}
			if (base.GetType() == this.ThresholdType)
			{
				return JavaList<ValueAnimator>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, BallPulseRiseIndicator.id_onCreateAnimators), JniHandleOwnership.TransferLocalRef);
			}
			return JavaList<ValueAnimator>.FromJniHandle(JNIEnv.CallNonvirtualObjectMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "onCreateAnimators", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000079 RID: 121
		internal new static IntPtr java_class_handle;

		// Token: 0x0400007A RID: 122
		private static IntPtr id_ctor;

		// Token: 0x0400007B RID: 123
		private static Delegate cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;

		// Token: 0x0400007C RID: 124
		private static IntPtr id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;

		// Token: 0x0400007D RID: 125
		private static Delegate cb_onCreateAnimators;

		// Token: 0x0400007E RID: 126
		private static IntPtr id_onCreateAnimators;
	}
}
