using System;
using System.Collections.Generic;
using Android.Animation;
using Android.Graphics;
using Android.Runtime;
using Java.Lang;

namespace Com.Wang.Avi.Indicators
{
	// Token: 0x0200001A RID: 26
	[Register("com/wang/avi/indicators/CubeTransitionIndicator", DoNotGenerateAcw = true)]
	public class CubeTransitionIndicator : Indicator
	{
		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00007039 File Offset: 0x00005239
		internal new static IntPtr class_ref
		{
			get
			{
				return JNIEnv.FindClass("com/wang/avi/indicators/CubeTransitionIndicator", ref CubeTransitionIndicator.java_class_handle);
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000132 RID: 306 RVA: 0x0000704A File Offset: 0x0000524A
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CubeTransitionIndicator.class_ref;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000133 RID: 307 RVA: 0x00007051 File Offset: 0x00005251
		protected override Type ThresholdType
		{
			get
			{
				return typeof(CubeTransitionIndicator);
			}
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00003EDD File Offset: 0x000020DD
		protected CubeTransitionIndicator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00007060 File Offset: 0x00005260
		[Register(".ctor", "()V", "")]
		public CubeTransitionIndicator() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			if (base.GetType() != typeof(CubeTransitionIndicator))
			{
				base.SetHandle(JNIEnv.StartCreateInstance(base.GetType(), "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				return;
			}
			if (CubeTransitionIndicator.id_ctor == IntPtr.Zero)
			{
				CubeTransitionIndicator.id_ctor = JNIEnv.GetMethodID(CubeTransitionIndicator.class_ref, "<init>", "()V");
			}
			base.SetHandle(JNIEnv.StartCreateInstance(CubeTransitionIndicator.class_ref, CubeTransitionIndicator.id_ctor, Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance(base.Handle, CubeTransitionIndicator.class_ref, CubeTransitionIndicator.id_ctor, Array.Empty<JValue>());
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00007134 File Offset: 0x00005334
		private static Delegate GetDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_Handler()
		{
			if (CubeTransitionIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ == null)
			{
				CubeTransitionIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr, IntPtr>(CubeTransitionIndicator.n_Draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_));
			}
			return CubeTransitionIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00007158 File Offset: 0x00005358
		private static void n_Draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			CubeTransitionIndicator @object = Java.Lang.Object.GetObject<CubeTransitionIndicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Canvas object2 = Java.Lang.Object.GetObject<Canvas>(native_p0, JniHandleOwnership.DoNotTransfer);
			Paint object3 = Java.Lang.Object.GetObject<Paint>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.Draw(object2, object3);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00007188 File Offset: 0x00005388
		[Register("draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V", "GetDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_Handler")]
		public unsafe override void Draw(Canvas p0, Paint p1)
		{
			if (CubeTransitionIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ == IntPtr.Zero)
			{
				CubeTransitionIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ = JNIEnv.GetMethodID(CubeTransitionIndicator.class_ref, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			ptr[1] = new JValue(p1);
			if (base.GetType() == this.ThresholdType)
			{
				JNIEnv.CallVoidMethod(base.Handle, CubeTransitionIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_, ptr);
				return;
			}
			JNIEnv.CallNonvirtualVoidMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V"), ptr);
			GC.KeepAlive(p0);
			GC.KeepAlive(p1);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00007242 File Offset: 0x00005442
		private static Delegate GetOnCreateAnimatorsHandler()
		{
			if (CubeTransitionIndicator.cb_onCreateAnimators == null)
			{
				CubeTransitionIndicator.cb_onCreateAnimators = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr>(CubeTransitionIndicator.n_OnCreateAnimators));
			}
			return CubeTransitionIndicator.cb_onCreateAnimators;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00007268 File Offset: 0x00005468
		private static IntPtr n_OnCreateAnimators(IntPtr jnienv, IntPtr native__this)
		{
			CubeTransitionIndicator @object = Java.Lang.Object.GetObject<CubeTransitionIndicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JavaList<ValueAnimator>.ToLocalJniHandle(@object.OnCreateAnimators());
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0000728C File Offset: 0x0000548C
		[Register("onCreateAnimators", "()Ljava/util/ArrayList;", "GetOnCreateAnimatorsHandler")]
		public override IList<ValueAnimator> OnCreateAnimators()
		{
			if (CubeTransitionIndicator.id_onCreateAnimators == IntPtr.Zero)
			{
				CubeTransitionIndicator.id_onCreateAnimators = JNIEnv.GetMethodID(CubeTransitionIndicator.class_ref, "onCreateAnimators", "()Ljava/util/ArrayList;");
			}
			if (base.GetType() == this.ThresholdType)
			{
				return JavaList<ValueAnimator>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, CubeTransitionIndicator.id_onCreateAnimators), JniHandleOwnership.TransferLocalRef);
			}
			return JavaList<ValueAnimator>.FromJniHandle(JNIEnv.CallNonvirtualObjectMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "onCreateAnimators", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040000B4 RID: 180
		internal new static IntPtr java_class_handle;

		// Token: 0x040000B5 RID: 181
		private static IntPtr id_ctor;

		// Token: 0x040000B6 RID: 182
		private static Delegate cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;

		// Token: 0x040000B7 RID: 183
		private static IntPtr id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;

		// Token: 0x040000B8 RID: 184
		private static Delegate cb_onCreateAnimators;

		// Token: 0x040000B9 RID: 185
		private static IntPtr id_onCreateAnimators;
	}
}
