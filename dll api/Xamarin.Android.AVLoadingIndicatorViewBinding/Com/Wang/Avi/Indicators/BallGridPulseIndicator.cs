using System;
using System.Collections.Generic;
using Android.Animation;
using Android.Graphics;
using Android.Runtime;
using Java.Lang;

namespace Com.Wang.Avi.Indicators
{
	// Token: 0x0200000C RID: 12
	[Register("com/wang/avi/indicators/BallGridPulseIndicator", DoNotGenerateAcw = true)]
	public class BallGridPulseIndicator : Indicator
	{
		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000AB RID: 171 RVA: 0x00004E21 File Offset: 0x00003021
		internal new static IntPtr class_ref
		{
			get
			{
				return JNIEnv.FindClass("com/wang/avi/indicators/BallGridPulseIndicator", ref BallGridPulseIndicator.java_class_handle);
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00004E32 File Offset: 0x00003032
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BallGridPulseIndicator.class_ref;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00004E39 File Offset: 0x00003039
		protected override Type ThresholdType
		{
			get
			{
				return typeof(BallGridPulseIndicator);
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00003EDD File Offset: 0x000020DD
		protected BallGridPulseIndicator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00004E48 File Offset: 0x00003048
		[Register(".ctor", "()V", "")]
		public BallGridPulseIndicator() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			if (base.GetType() != typeof(BallGridPulseIndicator))
			{
				base.SetHandle(JNIEnv.StartCreateInstance(base.GetType(), "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				return;
			}
			if (BallGridPulseIndicator.id_ctor == IntPtr.Zero)
			{
				BallGridPulseIndicator.id_ctor = JNIEnv.GetMethodID(BallGridPulseIndicator.class_ref, "<init>", "()V");
			}
			base.SetHandle(JNIEnv.StartCreateInstance(BallGridPulseIndicator.class_ref, BallGridPulseIndicator.id_ctor, Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance(base.Handle, BallGridPulseIndicator.class_ref, BallGridPulseIndicator.id_ctor, Array.Empty<JValue>());
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00004F1C File Offset: 0x0000311C
		private static Delegate GetDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_Handler()
		{
			if (BallGridPulseIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ == null)
			{
				BallGridPulseIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr, IntPtr>(BallGridPulseIndicator.n_Draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_));
			}
			return BallGridPulseIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00004F40 File Offset: 0x00003140
		private static void n_Draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			BallGridPulseIndicator @object = Java.Lang.Object.GetObject<BallGridPulseIndicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Canvas object2 = Java.Lang.Object.GetObject<Canvas>(native_p0, JniHandleOwnership.DoNotTransfer);
			Paint object3 = Java.Lang.Object.GetObject<Paint>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.Draw(object2, object3);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00004F70 File Offset: 0x00003170
		[Register("draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V", "GetDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_Handler")]
		public unsafe override void Draw(Canvas p0, Paint p1)
		{
			if (BallGridPulseIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ == IntPtr.Zero)
			{
				BallGridPulseIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ = JNIEnv.GetMethodID(BallGridPulseIndicator.class_ref, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			ptr[1] = new JValue(p1);
			if (base.GetType() == this.ThresholdType)
			{
				JNIEnv.CallVoidMethod(base.Handle, BallGridPulseIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_, ptr);
				return;
			}
			JNIEnv.CallNonvirtualVoidMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V"), ptr);
			GC.KeepAlive(p0);
			GC.KeepAlive(p1);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000502A File Offset: 0x0000322A
		private static Delegate GetOnCreateAnimatorsHandler()
		{
			if (BallGridPulseIndicator.cb_onCreateAnimators == null)
			{
				BallGridPulseIndicator.cb_onCreateAnimators = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr>(BallGridPulseIndicator.n_OnCreateAnimators));
			}
			return BallGridPulseIndicator.cb_onCreateAnimators;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00005050 File Offset: 0x00003250
		private static IntPtr n_OnCreateAnimators(IntPtr jnienv, IntPtr native__this)
		{
			BallGridPulseIndicator @object = Java.Lang.Object.GetObject<BallGridPulseIndicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JavaList<ValueAnimator>.ToLocalJniHandle(@object.OnCreateAnimators());
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00005074 File Offset: 0x00003274
		[Register("onCreateAnimators", "()Ljava/util/ArrayList;", "GetOnCreateAnimatorsHandler")]
		public override IList<ValueAnimator> OnCreateAnimators()
		{
			if (BallGridPulseIndicator.id_onCreateAnimators == IntPtr.Zero)
			{
				BallGridPulseIndicator.id_onCreateAnimators = JNIEnv.GetMethodID(BallGridPulseIndicator.class_ref, "onCreateAnimators", "()Ljava/util/ArrayList;");
			}
			if (base.GetType() == this.ThresholdType)
			{
				return JavaList<ValueAnimator>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, BallGridPulseIndicator.id_onCreateAnimators), JniHandleOwnership.TransferLocalRef);
			}
			return JavaList<ValueAnimator>.FromJniHandle(JNIEnv.CallNonvirtualObjectMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "onCreateAnimators", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400006B RID: 107
		[Register("SCALE")]
		public const float Scale = 1f;

		// Token: 0x0400006C RID: 108
		internal new static IntPtr java_class_handle;

		// Token: 0x0400006D RID: 109
		private static IntPtr id_ctor;

		// Token: 0x0400006E RID: 110
		private static Delegate cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;

		// Token: 0x0400006F RID: 111
		private static IntPtr id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;

		// Token: 0x04000070 RID: 112
		private static Delegate cb_onCreateAnimators;

		// Token: 0x04000071 RID: 113
		private static IntPtr id_onCreateAnimators;
	}
}
