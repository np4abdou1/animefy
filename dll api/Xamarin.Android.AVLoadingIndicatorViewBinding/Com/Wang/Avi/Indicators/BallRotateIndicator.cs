using System;
using System.Collections.Generic;
using Android.Animation;
using Android.Graphics;
using Android.Runtime;
using Java.Lang;

namespace Com.Wang.Avi.Indicators
{
	// Token: 0x02000010 RID: 16
	[Register("com/wang/avi/indicators/BallRotateIndicator", DoNotGenerateAcw = true)]
	public class BallRotateIndicator : Indicator
	{
		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x000059A1 File Offset: 0x00003BA1
		internal new static IntPtr class_ref
		{
			get
			{
				return JNIEnv.FindClass("com/wang/avi/indicators/BallRotateIndicator", ref BallRotateIndicator.java_class_handle);
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x000059B2 File Offset: 0x00003BB2
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BallRotateIndicator.class_ref;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x000059B9 File Offset: 0x00003BB9
		protected override Type ThresholdType
		{
			get
			{
				return typeof(BallRotateIndicator);
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00003EDD File Offset: 0x000020DD
		protected BallRotateIndicator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000059C8 File Offset: 0x00003BC8
		[Register(".ctor", "()V", "")]
		public BallRotateIndicator() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			if (base.GetType() != typeof(BallRotateIndicator))
			{
				base.SetHandle(JNIEnv.StartCreateInstance(base.GetType(), "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				return;
			}
			if (BallRotateIndicator.id_ctor == IntPtr.Zero)
			{
				BallRotateIndicator.id_ctor = JNIEnv.GetMethodID(BallRotateIndicator.class_ref, "<init>", "()V");
			}
			base.SetHandle(JNIEnv.StartCreateInstance(BallRotateIndicator.class_ref, BallRotateIndicator.id_ctor, Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance(base.Handle, BallRotateIndicator.class_ref, BallRotateIndicator.id_ctor, Array.Empty<JValue>());
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00005A9C File Offset: 0x00003C9C
		private static Delegate GetDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_Handler()
		{
			if (BallRotateIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ == null)
			{
				BallRotateIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr, IntPtr>(BallRotateIndicator.n_Draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_));
			}
			return BallRotateIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00005AC0 File Offset: 0x00003CC0
		private static void n_Draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			BallRotateIndicator @object = Java.Lang.Object.GetObject<BallRotateIndicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Canvas object2 = Java.Lang.Object.GetObject<Canvas>(native_p0, JniHandleOwnership.DoNotTransfer);
			Paint object3 = Java.Lang.Object.GetObject<Paint>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.Draw(object2, object3);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00005AF0 File Offset: 0x00003CF0
		[Register("draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V", "GetDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_Handler")]
		public unsafe override void Draw(Canvas p0, Paint p1)
		{
			if (BallRotateIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ == IntPtr.Zero)
			{
				BallRotateIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ = JNIEnv.GetMethodID(BallRotateIndicator.class_ref, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			ptr[1] = new JValue(p1);
			if (base.GetType() == this.ThresholdType)
			{
				JNIEnv.CallVoidMethod(base.Handle, BallRotateIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_, ptr);
				return;
			}
			JNIEnv.CallNonvirtualVoidMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V"), ptr);
			GC.KeepAlive(p0);
			GC.KeepAlive(p1);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00005BAA File Offset: 0x00003DAA
		private static Delegate GetOnCreateAnimatorsHandler()
		{
			if (BallRotateIndicator.cb_onCreateAnimators == null)
			{
				BallRotateIndicator.cb_onCreateAnimators = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr>(BallRotateIndicator.n_OnCreateAnimators));
			}
			return BallRotateIndicator.cb_onCreateAnimators;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00005BD0 File Offset: 0x00003DD0
		private static IntPtr n_OnCreateAnimators(IntPtr jnienv, IntPtr native__this)
		{
			BallRotateIndicator @object = Java.Lang.Object.GetObject<BallRotateIndicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JavaList<ValueAnimator>.ToLocalJniHandle(@object.OnCreateAnimators());
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00005BF4 File Offset: 0x00003DF4
		[Register("onCreateAnimators", "()Ljava/util/ArrayList;", "GetOnCreateAnimatorsHandler")]
		public override IList<ValueAnimator> OnCreateAnimators()
		{
			if (BallRotateIndicator.id_onCreateAnimators == IntPtr.Zero)
			{
				BallRotateIndicator.id_onCreateAnimators = JNIEnv.GetMethodID(BallRotateIndicator.class_ref, "onCreateAnimators", "()Ljava/util/ArrayList;");
			}
			if (base.GetType() == this.ThresholdType)
			{
				return JavaList<ValueAnimator>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, BallRotateIndicator.id_onCreateAnimators), JniHandleOwnership.TransferLocalRef);
			}
			return JavaList<ValueAnimator>.FromJniHandle(JNIEnv.CallNonvirtualObjectMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "onCreateAnimators", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000085 RID: 133
		internal new static IntPtr java_class_handle;

		// Token: 0x04000086 RID: 134
		private static IntPtr id_ctor;

		// Token: 0x04000087 RID: 135
		private static Delegate cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;

		// Token: 0x04000088 RID: 136
		private static IntPtr id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;

		// Token: 0x04000089 RID: 137
		private static Delegate cb_onCreateAnimators;

		// Token: 0x0400008A RID: 138
		private static IntPtr id_onCreateAnimators;
	}
}
