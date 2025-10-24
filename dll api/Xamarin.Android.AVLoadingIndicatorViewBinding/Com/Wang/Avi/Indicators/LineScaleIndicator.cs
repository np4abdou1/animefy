using System;
using System.Collections.Generic;
using Android.Animation;
using Android.Graphics;
using Android.Runtime;
using Java.Lang;

namespace Com.Wang.Avi.Indicators
{
	// Token: 0x0200001B RID: 27
	[Register("com/wang/avi/indicators/LineScaleIndicator", DoNotGenerateAcw = true)]
	public class LineScaleIndicator : Indicator
	{
		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600013C RID: 316 RVA: 0x00007319 File Offset: 0x00005519
		internal new static IntPtr class_ref
		{
			get
			{
				return JNIEnv.FindClass("com/wang/avi/indicators/LineScaleIndicator", ref LineScaleIndicator.java_class_handle);
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600013D RID: 317 RVA: 0x0000732A File Offset: 0x0000552A
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LineScaleIndicator.class_ref;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600013E RID: 318 RVA: 0x00007331 File Offset: 0x00005531
		protected override Type ThresholdType
		{
			get
			{
				return typeof(LineScaleIndicator);
			}
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00003EDD File Offset: 0x000020DD
		protected LineScaleIndicator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00007340 File Offset: 0x00005540
		[Register(".ctor", "()V", "")]
		public LineScaleIndicator() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			if (base.GetType() != typeof(LineScaleIndicator))
			{
				base.SetHandle(JNIEnv.StartCreateInstance(base.GetType(), "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				return;
			}
			if (LineScaleIndicator.id_ctor == IntPtr.Zero)
			{
				LineScaleIndicator.id_ctor = JNIEnv.GetMethodID(LineScaleIndicator.class_ref, "<init>", "()V");
			}
			base.SetHandle(JNIEnv.StartCreateInstance(LineScaleIndicator.class_ref, LineScaleIndicator.id_ctor, Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance(base.Handle, LineScaleIndicator.class_ref, LineScaleIndicator.id_ctor, Array.Empty<JValue>());
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00007414 File Offset: 0x00005614
		private static Delegate GetDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_Handler()
		{
			if (LineScaleIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ == null)
			{
				LineScaleIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr, IntPtr>(LineScaleIndicator.n_Draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_));
			}
			return LineScaleIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00007438 File Offset: 0x00005638
		private static void n_Draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			LineScaleIndicator @object = Java.Lang.Object.GetObject<LineScaleIndicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Canvas object2 = Java.Lang.Object.GetObject<Canvas>(native_p0, JniHandleOwnership.DoNotTransfer);
			Paint object3 = Java.Lang.Object.GetObject<Paint>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.Draw(object2, object3);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00007468 File Offset: 0x00005668
		[Register("draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V", "GetDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_Handler")]
		public unsafe override void Draw(Canvas p0, Paint p1)
		{
			if (LineScaleIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ == IntPtr.Zero)
			{
				LineScaleIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ = JNIEnv.GetMethodID(LineScaleIndicator.class_ref, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			ptr[1] = new JValue(p1);
			if (base.GetType() == this.ThresholdType)
			{
				JNIEnv.CallVoidMethod(base.Handle, LineScaleIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_, ptr);
				return;
			}
			JNIEnv.CallNonvirtualVoidMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V"), ptr);
			GC.KeepAlive(p0);
			GC.KeepAlive(p1);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00007522 File Offset: 0x00005722
		private static Delegate GetOnCreateAnimatorsHandler()
		{
			if (LineScaleIndicator.cb_onCreateAnimators == null)
			{
				LineScaleIndicator.cb_onCreateAnimators = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr>(LineScaleIndicator.n_OnCreateAnimators));
			}
			return LineScaleIndicator.cb_onCreateAnimators;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00007548 File Offset: 0x00005748
		private static IntPtr n_OnCreateAnimators(IntPtr jnienv, IntPtr native__this)
		{
			LineScaleIndicator @object = Java.Lang.Object.GetObject<LineScaleIndicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JavaList<ValueAnimator>.ToLocalJniHandle(@object.OnCreateAnimators());
		}

		// Token: 0x06000146 RID: 326 RVA: 0x0000756C File Offset: 0x0000576C
		[Register("onCreateAnimators", "()Ljava/util/ArrayList;", "GetOnCreateAnimatorsHandler")]
		public override IList<ValueAnimator> OnCreateAnimators()
		{
			if (LineScaleIndicator.id_onCreateAnimators == IntPtr.Zero)
			{
				LineScaleIndicator.id_onCreateAnimators = JNIEnv.GetMethodID(LineScaleIndicator.class_ref, "onCreateAnimators", "()Ljava/util/ArrayList;");
			}
			if (base.GetType() == this.ThresholdType)
			{
				return JavaList<ValueAnimator>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, LineScaleIndicator.id_onCreateAnimators), JniHandleOwnership.TransferLocalRef);
			}
			return JavaList<ValueAnimator>.FromJniHandle(JNIEnv.CallNonvirtualObjectMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "onCreateAnimators", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040000BA RID: 186
		[Register("SCALE")]
		public const float Scale = 1f;

		// Token: 0x040000BB RID: 187
		internal new static IntPtr java_class_handle;

		// Token: 0x040000BC RID: 188
		private static IntPtr id_ctor;

		// Token: 0x040000BD RID: 189
		private static Delegate cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;

		// Token: 0x040000BE RID: 190
		private static IntPtr id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;

		// Token: 0x040000BF RID: 191
		private static Delegate cb_onCreateAnimators;

		// Token: 0x040000C0 RID: 192
		private static IntPtr id_onCreateAnimators;
	}
}
