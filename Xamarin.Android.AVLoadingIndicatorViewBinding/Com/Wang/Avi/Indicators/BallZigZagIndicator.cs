using System;
using System.Collections.Generic;
using Android.Animation;
using Android.Graphics;
using Android.Runtime;
using Java.Lang;

namespace Com.Wang.Avi.Indicators
{
	// Token: 0x02000019 RID: 25
	[Register("com/wang/avi/indicators/BallZigZagIndicator", DoNotGenerateAcw = true)]
	public class BallZigZagIndicator : Indicator
	{
		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000126 RID: 294 RVA: 0x00006D5C File Offset: 0x00004F5C
		internal new static IntPtr class_ref
		{
			get
			{
				return JNIEnv.FindClass("com/wang/avi/indicators/BallZigZagIndicator", ref BallZigZagIndicator.java_class_handle);
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000127 RID: 295 RVA: 0x00006D6D File Offset: 0x00004F6D
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BallZigZagIndicator.class_ref;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000128 RID: 296 RVA: 0x00006D74 File Offset: 0x00004F74
		protected override Type ThresholdType
		{
			get
			{
				return typeof(BallZigZagIndicator);
			}
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00003EDD File Offset: 0x000020DD
		protected BallZigZagIndicator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00006D80 File Offset: 0x00004F80
		[Register(".ctor", "()V", "")]
		public BallZigZagIndicator() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			if (base.GetType() != typeof(BallZigZagIndicator))
			{
				base.SetHandle(JNIEnv.StartCreateInstance(base.GetType(), "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				return;
			}
			if (BallZigZagIndicator.id_ctor == IntPtr.Zero)
			{
				BallZigZagIndicator.id_ctor = JNIEnv.GetMethodID(BallZigZagIndicator.class_ref, "<init>", "()V");
			}
			base.SetHandle(JNIEnv.StartCreateInstance(BallZigZagIndicator.class_ref, BallZigZagIndicator.id_ctor, Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance(base.Handle, BallZigZagIndicator.class_ref, BallZigZagIndicator.id_ctor, Array.Empty<JValue>());
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00006E54 File Offset: 0x00005054
		private static Delegate GetDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_Handler()
		{
			if (BallZigZagIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ == null)
			{
				BallZigZagIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr, IntPtr>(BallZigZagIndicator.n_Draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_));
			}
			return BallZigZagIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00006E78 File Offset: 0x00005078
		private static void n_Draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			BallZigZagIndicator @object = Java.Lang.Object.GetObject<BallZigZagIndicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Canvas object2 = Java.Lang.Object.GetObject<Canvas>(native_p0, JniHandleOwnership.DoNotTransfer);
			Paint object3 = Java.Lang.Object.GetObject<Paint>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.Draw(object2, object3);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00006EA8 File Offset: 0x000050A8
		[Register("draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V", "GetDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_Handler")]
		public unsafe override void Draw(Canvas p0, Paint p1)
		{
			if (BallZigZagIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ == IntPtr.Zero)
			{
				BallZigZagIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ = JNIEnv.GetMethodID(BallZigZagIndicator.class_ref, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			ptr[1] = new JValue(p1);
			if (base.GetType() == this.ThresholdType)
			{
				JNIEnv.CallVoidMethod(base.Handle, BallZigZagIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_, ptr);
				return;
			}
			JNIEnv.CallNonvirtualVoidMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V"), ptr);
			GC.KeepAlive(p0);
			GC.KeepAlive(p1);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00006F62 File Offset: 0x00005162
		private static Delegate GetOnCreateAnimatorsHandler()
		{
			if (BallZigZagIndicator.cb_onCreateAnimators == null)
			{
				BallZigZagIndicator.cb_onCreateAnimators = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr>(BallZigZagIndicator.n_OnCreateAnimators));
			}
			return BallZigZagIndicator.cb_onCreateAnimators;
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00006F88 File Offset: 0x00005188
		private static IntPtr n_OnCreateAnimators(IntPtr jnienv, IntPtr native__this)
		{
			BallZigZagIndicator @object = Java.Lang.Object.GetObject<BallZigZagIndicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JavaList<ValueAnimator>.ToLocalJniHandle(@object.OnCreateAnimators());
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00006FAC File Offset: 0x000051AC
		[Register("onCreateAnimators", "()Ljava/util/ArrayList;", "GetOnCreateAnimatorsHandler")]
		public override IList<ValueAnimator> OnCreateAnimators()
		{
			if (BallZigZagIndicator.id_onCreateAnimators == IntPtr.Zero)
			{
				BallZigZagIndicator.id_onCreateAnimators = JNIEnv.GetMethodID(BallZigZagIndicator.class_ref, "onCreateAnimators", "()Ljava/util/ArrayList;");
			}
			if (base.GetType() == this.ThresholdType)
			{
				return JavaList<ValueAnimator>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, BallZigZagIndicator.id_onCreateAnimators), JniHandleOwnership.TransferLocalRef);
			}
			return JavaList<ValueAnimator>.FromJniHandle(JNIEnv.CallNonvirtualObjectMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "onCreateAnimators", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040000AE RID: 174
		internal new static IntPtr java_class_handle;

		// Token: 0x040000AF RID: 175
		private static IntPtr id_ctor;

		// Token: 0x040000B0 RID: 176
		private static Delegate cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;

		// Token: 0x040000B1 RID: 177
		private static IntPtr id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;

		// Token: 0x040000B2 RID: 178
		private static Delegate cb_onCreateAnimators;

		// Token: 0x040000B3 RID: 179
		private static IntPtr id_onCreateAnimators;
	}
}
