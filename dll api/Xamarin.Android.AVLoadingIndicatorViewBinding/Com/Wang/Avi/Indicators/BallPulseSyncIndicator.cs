using System;
using System.Collections.Generic;
using Android.Animation;
using Android.Graphics;
using Android.Runtime;
using Java.Lang;

namespace Com.Wang.Avi.Indicators
{
	// Token: 0x0200000F RID: 15
	[Register("com/wang/avi/indicators/BallPulseSyncIndicator", DoNotGenerateAcw = true)]
	public class BallPulseSyncIndicator : Indicator
	{
		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000CC RID: 204 RVA: 0x000056C1 File Offset: 0x000038C1
		internal new static IntPtr class_ref
		{
			get
			{
				return JNIEnv.FindClass("com/wang/avi/indicators/BallPulseSyncIndicator", ref BallPulseSyncIndicator.java_class_handle);
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000CD RID: 205 RVA: 0x000056D2 File Offset: 0x000038D2
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BallPulseSyncIndicator.class_ref;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000CE RID: 206 RVA: 0x000056D9 File Offset: 0x000038D9
		protected override Type ThresholdType
		{
			get
			{
				return typeof(BallPulseSyncIndicator);
			}
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00003EDD File Offset: 0x000020DD
		protected BallPulseSyncIndicator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000056E8 File Offset: 0x000038E8
		[Register(".ctor", "()V", "")]
		public BallPulseSyncIndicator() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			if (base.GetType() != typeof(BallPulseSyncIndicator))
			{
				base.SetHandle(JNIEnv.StartCreateInstance(base.GetType(), "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				return;
			}
			if (BallPulseSyncIndicator.id_ctor == IntPtr.Zero)
			{
				BallPulseSyncIndicator.id_ctor = JNIEnv.GetMethodID(BallPulseSyncIndicator.class_ref, "<init>", "()V");
			}
			base.SetHandle(JNIEnv.StartCreateInstance(BallPulseSyncIndicator.class_ref, BallPulseSyncIndicator.id_ctor, Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance(base.Handle, BallPulseSyncIndicator.class_ref, BallPulseSyncIndicator.id_ctor, Array.Empty<JValue>());
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000057BC File Offset: 0x000039BC
		private static Delegate GetDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_Handler()
		{
			if (BallPulseSyncIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ == null)
			{
				BallPulseSyncIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr, IntPtr>(BallPulseSyncIndicator.n_Draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_));
			}
			return BallPulseSyncIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000057E0 File Offset: 0x000039E0
		private static void n_Draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			BallPulseSyncIndicator @object = Java.Lang.Object.GetObject<BallPulseSyncIndicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Canvas object2 = Java.Lang.Object.GetObject<Canvas>(native_p0, JniHandleOwnership.DoNotTransfer);
			Paint object3 = Java.Lang.Object.GetObject<Paint>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.Draw(object2, object3);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00005810 File Offset: 0x00003A10
		[Register("draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V", "GetDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_Handler")]
		public unsafe override void Draw(Canvas p0, Paint p1)
		{
			if (BallPulseSyncIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ == IntPtr.Zero)
			{
				BallPulseSyncIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ = JNIEnv.GetMethodID(BallPulseSyncIndicator.class_ref, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			ptr[1] = new JValue(p1);
			if (base.GetType() == this.ThresholdType)
			{
				JNIEnv.CallVoidMethod(base.Handle, BallPulseSyncIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_, ptr);
				return;
			}
			JNIEnv.CallNonvirtualVoidMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V"), ptr);
			GC.KeepAlive(p0);
			GC.KeepAlive(p1);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000058CA File Offset: 0x00003ACA
		private static Delegate GetOnCreateAnimatorsHandler()
		{
			if (BallPulseSyncIndicator.cb_onCreateAnimators == null)
			{
				BallPulseSyncIndicator.cb_onCreateAnimators = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr>(BallPulseSyncIndicator.n_OnCreateAnimators));
			}
			return BallPulseSyncIndicator.cb_onCreateAnimators;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x000058F0 File Offset: 0x00003AF0
		private static IntPtr n_OnCreateAnimators(IntPtr jnienv, IntPtr native__this)
		{
			BallPulseSyncIndicator @object = Java.Lang.Object.GetObject<BallPulseSyncIndicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JavaList<ValueAnimator>.ToLocalJniHandle(@object.OnCreateAnimators());
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00005914 File Offset: 0x00003B14
		[Register("onCreateAnimators", "()Ljava/util/ArrayList;", "GetOnCreateAnimatorsHandler")]
		public override IList<ValueAnimator> OnCreateAnimators()
		{
			if (BallPulseSyncIndicator.id_onCreateAnimators == IntPtr.Zero)
			{
				BallPulseSyncIndicator.id_onCreateAnimators = JNIEnv.GetMethodID(BallPulseSyncIndicator.class_ref, "onCreateAnimators", "()Ljava/util/ArrayList;");
			}
			if (base.GetType() == this.ThresholdType)
			{
				return JavaList<ValueAnimator>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, BallPulseSyncIndicator.id_onCreateAnimators), JniHandleOwnership.TransferLocalRef);
			}
			return JavaList<ValueAnimator>.FromJniHandle(JNIEnv.CallNonvirtualObjectMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "onCreateAnimators", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400007F RID: 127
		internal new static IntPtr java_class_handle;

		// Token: 0x04000080 RID: 128
		private static IntPtr id_ctor;

		// Token: 0x04000081 RID: 129
		private static Delegate cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;

		// Token: 0x04000082 RID: 130
		private static IntPtr id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;

		// Token: 0x04000083 RID: 131
		private static Delegate cb_onCreateAnimators;

		// Token: 0x04000084 RID: 132
		private static IntPtr id_onCreateAnimators;
	}
}
