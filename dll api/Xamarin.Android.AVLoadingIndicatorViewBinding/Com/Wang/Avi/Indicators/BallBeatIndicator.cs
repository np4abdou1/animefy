using System;
using System.Collections.Generic;
using Android.Animation;
using Android.Graphics;
using Android.Runtime;
using Java.Lang;

namespace Com.Wang.Avi.Indicators
{
	// Token: 0x02000007 RID: 7
	[Register("com/wang/avi/indicators/BallBeatIndicator", DoNotGenerateAcw = true)]
	public class BallBeatIndicator : Indicator
	{
		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00003FC1 File Offset: 0x000021C1
		internal new static IntPtr class_ref
		{
			get
			{
				return JNIEnv.FindClass("com/wang/avi/indicators/BallBeatIndicator", ref BallBeatIndicator.java_class_handle);
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00003FD2 File Offset: 0x000021D2
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BallBeatIndicator.class_ref;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00003FD9 File Offset: 0x000021D9
		protected override Type ThresholdType
		{
			get
			{
				return typeof(BallBeatIndicator);
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00003EDD File Offset: 0x000020DD
		protected BallBeatIndicator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00003FE8 File Offset: 0x000021E8
		[Register(".ctor", "()V", "")]
		public BallBeatIndicator() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			if (base.GetType() != typeof(BallBeatIndicator))
			{
				base.SetHandle(JNIEnv.StartCreateInstance(base.GetType(), "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				return;
			}
			if (BallBeatIndicator.id_ctor == IntPtr.Zero)
			{
				BallBeatIndicator.id_ctor = JNIEnv.GetMethodID(BallBeatIndicator.class_ref, "<init>", "()V");
			}
			base.SetHandle(JNIEnv.StartCreateInstance(BallBeatIndicator.class_ref, BallBeatIndicator.id_ctor, Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance(base.Handle, BallBeatIndicator.class_ref, BallBeatIndicator.id_ctor, Array.Empty<JValue>());
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000040BC File Offset: 0x000022BC
		private static Delegate GetDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_Handler()
		{
			if (BallBeatIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ == null)
			{
				BallBeatIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr, IntPtr>(BallBeatIndicator.n_Draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_));
			}
			return BallBeatIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000040E0 File Offset: 0x000022E0
		private static void n_Draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			BallBeatIndicator @object = Java.Lang.Object.GetObject<BallBeatIndicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Canvas object2 = Java.Lang.Object.GetObject<Canvas>(native_p0, JniHandleOwnership.DoNotTransfer);
			Paint object3 = Java.Lang.Object.GetObject<Paint>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.Draw(object2, object3);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00004110 File Offset: 0x00002310
		[Register("draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V", "GetDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_Handler")]
		public unsafe override void Draw(Canvas p0, Paint p1)
		{
			if (BallBeatIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ == IntPtr.Zero)
			{
				BallBeatIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ = JNIEnv.GetMethodID(BallBeatIndicator.class_ref, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			ptr[1] = new JValue(p1);
			if (base.GetType() == this.ThresholdType)
			{
				JNIEnv.CallVoidMethod(base.Handle, BallBeatIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_, ptr);
				return;
			}
			JNIEnv.CallNonvirtualVoidMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V"), ptr);
			GC.KeepAlive(p0);
			GC.KeepAlive(p1);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000041CA File Offset: 0x000023CA
		private static Delegate GetOnCreateAnimatorsHandler()
		{
			if (BallBeatIndicator.cb_onCreateAnimators == null)
			{
				BallBeatIndicator.cb_onCreateAnimators = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr>(BallBeatIndicator.n_OnCreateAnimators));
			}
			return BallBeatIndicator.cb_onCreateAnimators;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000041F0 File Offset: 0x000023F0
		private static IntPtr n_OnCreateAnimators(IntPtr jnienv, IntPtr native__this)
		{
			BallBeatIndicator @object = Java.Lang.Object.GetObject<BallBeatIndicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JavaList<ValueAnimator>.ToLocalJniHandle(@object.OnCreateAnimators());
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00004214 File Offset: 0x00002414
		[Register("onCreateAnimators", "()Ljava/util/ArrayList;", "GetOnCreateAnimatorsHandler")]
		public override IList<ValueAnimator> OnCreateAnimators()
		{
			if (BallBeatIndicator.id_onCreateAnimators == IntPtr.Zero)
			{
				BallBeatIndicator.id_onCreateAnimators = JNIEnv.GetMethodID(BallBeatIndicator.class_ref, "onCreateAnimators", "()Ljava/util/ArrayList;");
			}
			if (base.GetType() == this.ThresholdType)
			{
				return JavaList<ValueAnimator>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, BallBeatIndicator.id_onCreateAnimators), JniHandleOwnership.TransferLocalRef);
			}
			return JavaList<ValueAnimator>.FromJniHandle(JNIEnv.CallNonvirtualObjectMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "onCreateAnimators", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400004C RID: 76
		[Register("SCALE")]
		public const float Scale = 1f;

		// Token: 0x0400004D RID: 77
		internal new static IntPtr java_class_handle;

		// Token: 0x0400004E RID: 78
		private static IntPtr id_ctor;

		// Token: 0x0400004F RID: 79
		private static Delegate cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;

		// Token: 0x04000050 RID: 80
		private static IntPtr id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;

		// Token: 0x04000051 RID: 81
		private static Delegate cb_onCreateAnimators;

		// Token: 0x04000052 RID: 82
		private static IntPtr id_onCreateAnimators;
	}
}
