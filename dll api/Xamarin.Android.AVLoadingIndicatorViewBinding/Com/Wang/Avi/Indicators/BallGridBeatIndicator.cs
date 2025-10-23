using System;
using System.Collections.Generic;
using Android.Animation;
using Android.Graphics;
using Android.Runtime;
using Java.Lang;

namespace Com.Wang.Avi.Indicators
{
	// Token: 0x0200000B RID: 11
	[Register("com/wang/avi/indicators/BallGridBeatIndicator", DoNotGenerateAcw = true)]
	public class BallGridBeatIndicator : Indicator
	{
		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00004B41 File Offset: 0x00002D41
		internal new static IntPtr class_ref
		{
			get
			{
				return JNIEnv.FindClass("com/wang/avi/indicators/BallGridBeatIndicator", ref BallGridBeatIndicator.java_class_handle);
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00004B52 File Offset: 0x00002D52
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BallGridBeatIndicator.class_ref;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00004B59 File Offset: 0x00002D59
		protected override Type ThresholdType
		{
			get
			{
				return typeof(BallGridBeatIndicator);
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00003EDD File Offset: 0x000020DD
		protected BallGridBeatIndicator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00004B68 File Offset: 0x00002D68
		[Register(".ctor", "()V", "")]
		public BallGridBeatIndicator() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			if (base.GetType() != typeof(BallGridBeatIndicator))
			{
				base.SetHandle(JNIEnv.StartCreateInstance(base.GetType(), "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				return;
			}
			if (BallGridBeatIndicator.id_ctor == IntPtr.Zero)
			{
				BallGridBeatIndicator.id_ctor = JNIEnv.GetMethodID(BallGridBeatIndicator.class_ref, "<init>", "()V");
			}
			base.SetHandle(JNIEnv.StartCreateInstance(BallGridBeatIndicator.class_ref, BallGridBeatIndicator.id_ctor, Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance(base.Handle, BallGridBeatIndicator.class_ref, BallGridBeatIndicator.id_ctor, Array.Empty<JValue>());
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00004C3C File Offset: 0x00002E3C
		private static Delegate GetDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_Handler()
		{
			if (BallGridBeatIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ == null)
			{
				BallGridBeatIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr, IntPtr>(BallGridBeatIndicator.n_Draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_));
			}
			return BallGridBeatIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00004C60 File Offset: 0x00002E60
		private static void n_Draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			BallGridBeatIndicator @object = Java.Lang.Object.GetObject<BallGridBeatIndicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Canvas object2 = Java.Lang.Object.GetObject<Canvas>(native_p0, JniHandleOwnership.DoNotTransfer);
			Paint object3 = Java.Lang.Object.GetObject<Paint>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.Draw(object2, object3);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00004C90 File Offset: 0x00002E90
		[Register("draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V", "GetDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_Handler")]
		public unsafe override void Draw(Canvas p0, Paint p1)
		{
			if (BallGridBeatIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ == IntPtr.Zero)
			{
				BallGridBeatIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ = JNIEnv.GetMethodID(BallGridBeatIndicator.class_ref, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			ptr[1] = new JValue(p1);
			if (base.GetType() == this.ThresholdType)
			{
				JNIEnv.CallVoidMethod(base.Handle, BallGridBeatIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_, ptr);
				return;
			}
			JNIEnv.CallNonvirtualVoidMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V"), ptr);
			GC.KeepAlive(p0);
			GC.KeepAlive(p1);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00004D4A File Offset: 0x00002F4A
		private static Delegate GetOnCreateAnimatorsHandler()
		{
			if (BallGridBeatIndicator.cb_onCreateAnimators == null)
			{
				BallGridBeatIndicator.cb_onCreateAnimators = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr>(BallGridBeatIndicator.n_OnCreateAnimators));
			}
			return BallGridBeatIndicator.cb_onCreateAnimators;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00004D70 File Offset: 0x00002F70
		private static IntPtr n_OnCreateAnimators(IntPtr jnienv, IntPtr native__this)
		{
			BallGridBeatIndicator @object = Java.Lang.Object.GetObject<BallGridBeatIndicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JavaList<ValueAnimator>.ToLocalJniHandle(@object.OnCreateAnimators());
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00004D94 File Offset: 0x00002F94
		[Register("onCreateAnimators", "()Ljava/util/ArrayList;", "GetOnCreateAnimatorsHandler")]
		public override IList<ValueAnimator> OnCreateAnimators()
		{
			if (BallGridBeatIndicator.id_onCreateAnimators == IntPtr.Zero)
			{
				BallGridBeatIndicator.id_onCreateAnimators = JNIEnv.GetMethodID(BallGridBeatIndicator.class_ref, "onCreateAnimators", "()Ljava/util/ArrayList;");
			}
			if (base.GetType() == this.ThresholdType)
			{
				return JavaList<ValueAnimator>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, BallGridBeatIndicator.id_onCreateAnimators), JniHandleOwnership.TransferLocalRef);
			}
			return JavaList<ValueAnimator>.FromJniHandle(JNIEnv.CallNonvirtualObjectMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "onCreateAnimators", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000065 RID: 101
		internal new static IntPtr java_class_handle;

		// Token: 0x04000066 RID: 102
		private static IntPtr id_ctor;

		// Token: 0x04000067 RID: 103
		private static Delegate cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;

		// Token: 0x04000068 RID: 104
		private static IntPtr id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;

		// Token: 0x04000069 RID: 105
		private static Delegate cb_onCreateAnimators;

		// Token: 0x0400006A RID: 106
		private static IntPtr id_onCreateAnimators;
	}
}
