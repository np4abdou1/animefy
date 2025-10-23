using System;
using System.Collections.Generic;
using Android.Animation;
using Android.Graphics;
using Android.Runtime;
using Java.Lang;

namespace Com.Wang.Avi.Indicators
{
	// Token: 0x02000008 RID: 8
	[Register("com/wang/avi/indicators/BallClipRotateIndicator", DoNotGenerateAcw = true)]
	public class BallClipRotateIndicator : Indicator
	{
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600007F RID: 127 RVA: 0x000042A1 File Offset: 0x000024A1
		internal new static IntPtr class_ref
		{
			get
			{
				return JNIEnv.FindClass("com/wang/avi/indicators/BallClipRotateIndicator", ref BallClipRotateIndicator.java_class_handle);
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000080 RID: 128 RVA: 0x000042B2 File Offset: 0x000024B2
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BallClipRotateIndicator.class_ref;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000081 RID: 129 RVA: 0x000042B9 File Offset: 0x000024B9
		protected override Type ThresholdType
		{
			get
			{
				return typeof(BallClipRotateIndicator);
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00003EDD File Offset: 0x000020DD
		protected BallClipRotateIndicator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000042C8 File Offset: 0x000024C8
		[Register(".ctor", "()V", "")]
		public BallClipRotateIndicator() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			if (base.GetType() != typeof(BallClipRotateIndicator))
			{
				base.SetHandle(JNIEnv.StartCreateInstance(base.GetType(), "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				return;
			}
			if (BallClipRotateIndicator.id_ctor == IntPtr.Zero)
			{
				BallClipRotateIndicator.id_ctor = JNIEnv.GetMethodID(BallClipRotateIndicator.class_ref, "<init>", "()V");
			}
			base.SetHandle(JNIEnv.StartCreateInstance(BallClipRotateIndicator.class_ref, BallClipRotateIndicator.id_ctor, Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance(base.Handle, BallClipRotateIndicator.class_ref, BallClipRotateIndicator.id_ctor, Array.Empty<JValue>());
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000439C File Offset: 0x0000259C
		private static Delegate GetDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_Handler()
		{
			if (BallClipRotateIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ == null)
			{
				BallClipRotateIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr, IntPtr>(BallClipRotateIndicator.n_Draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_));
			}
			return BallClipRotateIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000043C0 File Offset: 0x000025C0
		private static void n_Draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			BallClipRotateIndicator @object = Java.Lang.Object.GetObject<BallClipRotateIndicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Canvas object2 = Java.Lang.Object.GetObject<Canvas>(native_p0, JniHandleOwnership.DoNotTransfer);
			Paint object3 = Java.Lang.Object.GetObject<Paint>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.Draw(object2, object3);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000043F0 File Offset: 0x000025F0
		[Register("draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V", "GetDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_Handler")]
		public unsafe override void Draw(Canvas p0, Paint p1)
		{
			if (BallClipRotateIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ == IntPtr.Zero)
			{
				BallClipRotateIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ = JNIEnv.GetMethodID(BallClipRotateIndicator.class_ref, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			ptr[1] = new JValue(p1);
			if (base.GetType() == this.ThresholdType)
			{
				JNIEnv.CallVoidMethod(base.Handle, BallClipRotateIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_, ptr);
				return;
			}
			JNIEnv.CallNonvirtualVoidMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V"), ptr);
			GC.KeepAlive(p0);
			GC.KeepAlive(p1);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x000044AA File Offset: 0x000026AA
		private static Delegate GetOnCreateAnimatorsHandler()
		{
			if (BallClipRotateIndicator.cb_onCreateAnimators == null)
			{
				BallClipRotateIndicator.cb_onCreateAnimators = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr>(BallClipRotateIndicator.n_OnCreateAnimators));
			}
			return BallClipRotateIndicator.cb_onCreateAnimators;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000044D0 File Offset: 0x000026D0
		private static IntPtr n_OnCreateAnimators(IntPtr jnienv, IntPtr native__this)
		{
			BallClipRotateIndicator @object = Java.Lang.Object.GetObject<BallClipRotateIndicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JavaList<ValueAnimator>.ToLocalJniHandle(@object.OnCreateAnimators());
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000044F4 File Offset: 0x000026F4
		[Register("onCreateAnimators", "()Ljava/util/ArrayList;", "GetOnCreateAnimatorsHandler")]
		public override IList<ValueAnimator> OnCreateAnimators()
		{
			if (BallClipRotateIndicator.id_onCreateAnimators == IntPtr.Zero)
			{
				BallClipRotateIndicator.id_onCreateAnimators = JNIEnv.GetMethodID(BallClipRotateIndicator.class_ref, "onCreateAnimators", "()Ljava/util/ArrayList;");
			}
			if (base.GetType() == this.ThresholdType)
			{
				return JavaList<ValueAnimator>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, BallClipRotateIndicator.id_onCreateAnimators), JniHandleOwnership.TransferLocalRef);
			}
			return JavaList<ValueAnimator>.FromJniHandle(JNIEnv.CallNonvirtualObjectMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "onCreateAnimators", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000053 RID: 83
		internal new static IntPtr java_class_handle;

		// Token: 0x04000054 RID: 84
		private static IntPtr id_ctor;

		// Token: 0x04000055 RID: 85
		private static Delegate cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;

		// Token: 0x04000056 RID: 86
		private static IntPtr id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;

		// Token: 0x04000057 RID: 87
		private static Delegate cb_onCreateAnimators;

		// Token: 0x04000058 RID: 88
		private static IntPtr id_onCreateAnimators;
	}
}
