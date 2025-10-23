using System;
using System.Collections.Generic;
using Android.Animation;
using Android.Graphics;
using Android.Runtime;
using Java.Lang;

namespace Com.Wang.Avi.Indicators
{
	// Token: 0x02000011 RID: 17
	[Register("com/wang/avi/indicators/BallScaleIndicator", DoNotGenerateAcw = true)]
	public class BallScaleIndicator : Indicator
	{
		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x00005C81 File Offset: 0x00003E81
		internal new static IntPtr class_ref
		{
			get
			{
				return JNIEnv.FindClass("com/wang/avi/indicators/BallScaleIndicator", ref BallScaleIndicator.java_class_handle);
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x00005C92 File Offset: 0x00003E92
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BallScaleIndicator.class_ref;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x00005C99 File Offset: 0x00003E99
		protected override Type ThresholdType
		{
			get
			{
				return typeof(BallScaleIndicator);
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00003EDD File Offset: 0x000020DD
		protected BallScaleIndicator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00005CA8 File Offset: 0x00003EA8
		[Register(".ctor", "()V", "")]
		public BallScaleIndicator() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			if (base.GetType() != typeof(BallScaleIndicator))
			{
				base.SetHandle(JNIEnv.StartCreateInstance(base.GetType(), "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				return;
			}
			if (BallScaleIndicator.id_ctor == IntPtr.Zero)
			{
				BallScaleIndicator.id_ctor = JNIEnv.GetMethodID(BallScaleIndicator.class_ref, "<init>", "()V");
			}
			base.SetHandle(JNIEnv.StartCreateInstance(BallScaleIndicator.class_ref, BallScaleIndicator.id_ctor, Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance(base.Handle, BallScaleIndicator.class_ref, BallScaleIndicator.id_ctor, Array.Empty<JValue>());
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00005D7C File Offset: 0x00003F7C
		private static Delegate GetDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_Handler()
		{
			if (BallScaleIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ == null)
			{
				BallScaleIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr, IntPtr>(BallScaleIndicator.n_Draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_));
			}
			return BallScaleIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00005DA0 File Offset: 0x00003FA0
		private static void n_Draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			BallScaleIndicator @object = Java.Lang.Object.GetObject<BallScaleIndicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Canvas object2 = Java.Lang.Object.GetObject<Canvas>(native_p0, JniHandleOwnership.DoNotTransfer);
			Paint object3 = Java.Lang.Object.GetObject<Paint>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.Draw(object2, object3);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00005DD0 File Offset: 0x00003FD0
		[Register("draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V", "GetDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_Handler")]
		public unsafe override void Draw(Canvas p0, Paint p1)
		{
			if (BallScaleIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ == IntPtr.Zero)
			{
				BallScaleIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ = JNIEnv.GetMethodID(BallScaleIndicator.class_ref, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			ptr[1] = new JValue(p1);
			if (base.GetType() == this.ThresholdType)
			{
				JNIEnv.CallVoidMethod(base.Handle, BallScaleIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_, ptr);
				return;
			}
			JNIEnv.CallNonvirtualVoidMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V"), ptr);
			GC.KeepAlive(p0);
			GC.KeepAlive(p1);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00005E8A File Offset: 0x0000408A
		private static Delegate GetOnCreateAnimatorsHandler()
		{
			if (BallScaleIndicator.cb_onCreateAnimators == null)
			{
				BallScaleIndicator.cb_onCreateAnimators = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr>(BallScaleIndicator.n_OnCreateAnimators));
			}
			return BallScaleIndicator.cb_onCreateAnimators;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00005EB0 File Offset: 0x000040B0
		private static IntPtr n_OnCreateAnimators(IntPtr jnienv, IntPtr native__this)
		{
			BallScaleIndicator @object = Java.Lang.Object.GetObject<BallScaleIndicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JavaList<ValueAnimator>.ToLocalJniHandle(@object.OnCreateAnimators());
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00005ED4 File Offset: 0x000040D4
		[Register("onCreateAnimators", "()Ljava/util/ArrayList;", "GetOnCreateAnimatorsHandler")]
		public override IList<ValueAnimator> OnCreateAnimators()
		{
			if (BallScaleIndicator.id_onCreateAnimators == IntPtr.Zero)
			{
				BallScaleIndicator.id_onCreateAnimators = JNIEnv.GetMethodID(BallScaleIndicator.class_ref, "onCreateAnimators", "()Ljava/util/ArrayList;");
			}
			if (base.GetType() == this.ThresholdType)
			{
				return JavaList<ValueAnimator>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, BallScaleIndicator.id_onCreateAnimators), JniHandleOwnership.TransferLocalRef);
			}
			return JavaList<ValueAnimator>.FromJniHandle(JNIEnv.CallNonvirtualObjectMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "onCreateAnimators", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400008B RID: 139
		internal new static IntPtr java_class_handle;

		// Token: 0x0400008C RID: 140
		private static IntPtr id_ctor;

		// Token: 0x0400008D RID: 141
		private static Delegate cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;

		// Token: 0x0400008E RID: 142
		private static IntPtr id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;

		// Token: 0x0400008F RID: 143
		private static Delegate cb_onCreateAnimators;

		// Token: 0x04000090 RID: 144
		private static IntPtr id_onCreateAnimators;
	}
}
