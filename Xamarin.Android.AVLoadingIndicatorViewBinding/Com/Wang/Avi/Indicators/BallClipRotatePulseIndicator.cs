using System;
using System.Collections.Generic;
using Android.Animation;
using Android.Graphics;
using Android.Runtime;
using Java.Lang;

namespace Com.Wang.Avi.Indicators
{
	// Token: 0x0200000A RID: 10
	[Register("com/wang/avi/indicators/BallClipRotatePulseIndicator", DoNotGenerateAcw = true)]
	public class BallClipRotatePulseIndicator : Indicator
	{
		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00004861 File Offset: 0x00002A61
		internal new static IntPtr class_ref
		{
			get
			{
				return JNIEnv.FindClass("com/wang/avi/indicators/BallClipRotatePulseIndicator", ref BallClipRotatePulseIndicator.java_class_handle);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00004872 File Offset: 0x00002A72
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BallClipRotatePulseIndicator.class_ref;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00004879 File Offset: 0x00002A79
		protected override Type ThresholdType
		{
			get
			{
				return typeof(BallClipRotatePulseIndicator);
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00003EDD File Offset: 0x000020DD
		protected BallClipRotatePulseIndicator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00004888 File Offset: 0x00002A88
		[Register(".ctor", "()V", "")]
		public BallClipRotatePulseIndicator() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			if (base.GetType() != typeof(BallClipRotatePulseIndicator))
			{
				base.SetHandle(JNIEnv.StartCreateInstance(base.GetType(), "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				return;
			}
			if (BallClipRotatePulseIndicator.id_ctor == IntPtr.Zero)
			{
				BallClipRotatePulseIndicator.id_ctor = JNIEnv.GetMethodID(BallClipRotatePulseIndicator.class_ref, "<init>", "()V");
			}
			base.SetHandle(JNIEnv.StartCreateInstance(BallClipRotatePulseIndicator.class_ref, BallClipRotatePulseIndicator.id_ctor, Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance(base.Handle, BallClipRotatePulseIndicator.class_ref, BallClipRotatePulseIndicator.id_ctor, Array.Empty<JValue>());
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000495C File Offset: 0x00002B5C
		private static Delegate GetDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_Handler()
		{
			if (BallClipRotatePulseIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ == null)
			{
				BallClipRotatePulseIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr, IntPtr>(BallClipRotatePulseIndicator.n_Draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_));
			}
			return BallClipRotatePulseIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00004980 File Offset: 0x00002B80
		private static void n_Draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			BallClipRotatePulseIndicator @object = Java.Lang.Object.GetObject<BallClipRotatePulseIndicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Canvas object2 = Java.Lang.Object.GetObject<Canvas>(native_p0, JniHandleOwnership.DoNotTransfer);
			Paint object3 = Java.Lang.Object.GetObject<Paint>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.Draw(object2, object3);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000049B0 File Offset: 0x00002BB0
		[Register("draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V", "GetDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_Handler")]
		public unsafe override void Draw(Canvas p0, Paint p1)
		{
			if (BallClipRotatePulseIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ == IntPtr.Zero)
			{
				BallClipRotatePulseIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ = JNIEnv.GetMethodID(BallClipRotatePulseIndicator.class_ref, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			ptr[1] = new JValue(p1);
			if (base.GetType() == this.ThresholdType)
			{
				JNIEnv.CallVoidMethod(base.Handle, BallClipRotatePulseIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_, ptr);
				return;
			}
			JNIEnv.CallNonvirtualVoidMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V"), ptr);
			GC.KeepAlive(p0);
			GC.KeepAlive(p1);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00004A6A File Offset: 0x00002C6A
		private static Delegate GetOnCreateAnimatorsHandler()
		{
			if (BallClipRotatePulseIndicator.cb_onCreateAnimators == null)
			{
				BallClipRotatePulseIndicator.cb_onCreateAnimators = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr>(BallClipRotatePulseIndicator.n_OnCreateAnimators));
			}
			return BallClipRotatePulseIndicator.cb_onCreateAnimators;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00004A90 File Offset: 0x00002C90
		private static IntPtr n_OnCreateAnimators(IntPtr jnienv, IntPtr native__this)
		{
			BallClipRotatePulseIndicator @object = Java.Lang.Object.GetObject<BallClipRotatePulseIndicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JavaList<ValueAnimator>.ToLocalJniHandle(@object.OnCreateAnimators());
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00004AB4 File Offset: 0x00002CB4
		[Register("onCreateAnimators", "()Ljava/util/ArrayList;", "GetOnCreateAnimatorsHandler")]
		public override IList<ValueAnimator> OnCreateAnimators()
		{
			if (BallClipRotatePulseIndicator.id_onCreateAnimators == IntPtr.Zero)
			{
				BallClipRotatePulseIndicator.id_onCreateAnimators = JNIEnv.GetMethodID(BallClipRotatePulseIndicator.class_ref, "onCreateAnimators", "()Ljava/util/ArrayList;");
			}
			if (base.GetType() == this.ThresholdType)
			{
				return JavaList<ValueAnimator>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, BallClipRotatePulseIndicator.id_onCreateAnimators), JniHandleOwnership.TransferLocalRef);
			}
			return JavaList<ValueAnimator>.FromJniHandle(JNIEnv.CallNonvirtualObjectMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "onCreateAnimators", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400005F RID: 95
		internal new static IntPtr java_class_handle;

		// Token: 0x04000060 RID: 96
		private static IntPtr id_ctor;

		// Token: 0x04000061 RID: 97
		private static Delegate cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;

		// Token: 0x04000062 RID: 98
		private static IntPtr id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;

		// Token: 0x04000063 RID: 99
		private static Delegate cb_onCreateAnimators;

		// Token: 0x04000064 RID: 100
		private static IntPtr id_onCreateAnimators;
	}
}
