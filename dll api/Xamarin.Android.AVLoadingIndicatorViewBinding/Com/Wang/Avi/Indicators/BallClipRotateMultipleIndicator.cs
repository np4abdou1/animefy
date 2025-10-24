using System;
using System.Collections.Generic;
using Android.Animation;
using Android.Graphics;
using Android.Runtime;
using Java.Lang;

namespace Com.Wang.Avi.Indicators
{
	// Token: 0x02000009 RID: 9
	[Register("com/wang/avi/indicators/BallClipRotateMultipleIndicator", DoNotGenerateAcw = true)]
	public class BallClipRotateMultipleIndicator : Indicator
	{
		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00004581 File Offset: 0x00002781
		internal new static IntPtr class_ref
		{
			get
			{
				return JNIEnv.FindClass("com/wang/avi/indicators/BallClipRotateMultipleIndicator", ref BallClipRotateMultipleIndicator.java_class_handle);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00004592 File Offset: 0x00002792
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BallClipRotateMultipleIndicator.class_ref;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00004599 File Offset: 0x00002799
		protected override Type ThresholdType
		{
			get
			{
				return typeof(BallClipRotateMultipleIndicator);
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00003EDD File Offset: 0x000020DD
		protected BallClipRotateMultipleIndicator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000045A8 File Offset: 0x000027A8
		[Register(".ctor", "()V", "")]
		public BallClipRotateMultipleIndicator() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			if (base.GetType() != typeof(BallClipRotateMultipleIndicator))
			{
				base.SetHandle(JNIEnv.StartCreateInstance(base.GetType(), "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				return;
			}
			if (BallClipRotateMultipleIndicator.id_ctor == IntPtr.Zero)
			{
				BallClipRotateMultipleIndicator.id_ctor = JNIEnv.GetMethodID(BallClipRotateMultipleIndicator.class_ref, "<init>", "()V");
			}
			base.SetHandle(JNIEnv.StartCreateInstance(BallClipRotateMultipleIndicator.class_ref, BallClipRotateMultipleIndicator.id_ctor, Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance(base.Handle, BallClipRotateMultipleIndicator.class_ref, BallClipRotateMultipleIndicator.id_ctor, Array.Empty<JValue>());
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000467C File Offset: 0x0000287C
		private static Delegate GetDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_Handler()
		{
			if (BallClipRotateMultipleIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ == null)
			{
				BallClipRotateMultipleIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr, IntPtr>(BallClipRotateMultipleIndicator.n_Draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_));
			}
			return BallClipRotateMultipleIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x000046A0 File Offset: 0x000028A0
		private static void n_Draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			BallClipRotateMultipleIndicator @object = Java.Lang.Object.GetObject<BallClipRotateMultipleIndicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Canvas object2 = Java.Lang.Object.GetObject<Canvas>(native_p0, JniHandleOwnership.DoNotTransfer);
			Paint object3 = Java.Lang.Object.GetObject<Paint>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.Draw(object2, object3);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000046D0 File Offset: 0x000028D0
		[Register("draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V", "GetDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_Handler")]
		public unsafe override void Draw(Canvas p0, Paint p1)
		{
			if (BallClipRotateMultipleIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ == IntPtr.Zero)
			{
				BallClipRotateMultipleIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ = JNIEnv.GetMethodID(BallClipRotateMultipleIndicator.class_ref, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			ptr[1] = new JValue(p1);
			if (base.GetType() == this.ThresholdType)
			{
				JNIEnv.CallVoidMethod(base.Handle, BallClipRotateMultipleIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_, ptr);
				return;
			}
			JNIEnv.CallNonvirtualVoidMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V"), ptr);
			GC.KeepAlive(p0);
			GC.KeepAlive(p1);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000478A File Offset: 0x0000298A
		private static Delegate GetOnCreateAnimatorsHandler()
		{
			if (BallClipRotateMultipleIndicator.cb_onCreateAnimators == null)
			{
				BallClipRotateMultipleIndicator.cb_onCreateAnimators = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr>(BallClipRotateMultipleIndicator.n_OnCreateAnimators));
			}
			return BallClipRotateMultipleIndicator.cb_onCreateAnimators;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000047B0 File Offset: 0x000029B0
		private static IntPtr n_OnCreateAnimators(IntPtr jnienv, IntPtr native__this)
		{
			BallClipRotateMultipleIndicator @object = Java.Lang.Object.GetObject<BallClipRotateMultipleIndicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JavaList<ValueAnimator>.ToLocalJniHandle(@object.OnCreateAnimators());
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000047D4 File Offset: 0x000029D4
		[Register("onCreateAnimators", "()Ljava/util/ArrayList;", "GetOnCreateAnimatorsHandler")]
		public override IList<ValueAnimator> OnCreateAnimators()
		{
			if (BallClipRotateMultipleIndicator.id_onCreateAnimators == IntPtr.Zero)
			{
				BallClipRotateMultipleIndicator.id_onCreateAnimators = JNIEnv.GetMethodID(BallClipRotateMultipleIndicator.class_ref, "onCreateAnimators", "()Ljava/util/ArrayList;");
			}
			if (base.GetType() == this.ThresholdType)
			{
				return JavaList<ValueAnimator>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, BallClipRotateMultipleIndicator.id_onCreateAnimators), JniHandleOwnership.TransferLocalRef);
			}
			return JavaList<ValueAnimator>.FromJniHandle(JNIEnv.CallNonvirtualObjectMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "onCreateAnimators", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000059 RID: 89
		internal new static IntPtr java_class_handle;

		// Token: 0x0400005A RID: 90
		private static IntPtr id_ctor;

		// Token: 0x0400005B RID: 91
		private static Delegate cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;

		// Token: 0x0400005C RID: 92
		private static IntPtr id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;

		// Token: 0x0400005D RID: 93
		private static Delegate cb_onCreateAnimators;

		// Token: 0x0400005E RID: 94
		private static IntPtr id_onCreateAnimators;
	}
}
