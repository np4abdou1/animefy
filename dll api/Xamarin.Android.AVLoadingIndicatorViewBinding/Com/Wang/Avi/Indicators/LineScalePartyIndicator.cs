using System;
using System.Collections.Generic;
using Android.Animation;
using Android.Graphics;
using Android.Runtime;
using Java.Lang;

namespace Com.Wang.Avi.Indicators
{
	// Token: 0x0200001C RID: 28
	[Register("com/wang/avi/indicators/LineScalePartyIndicator", DoNotGenerateAcw = true)]
	public class LineScalePartyIndicator : Indicator
	{
		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000147 RID: 327 RVA: 0x000075F9 File Offset: 0x000057F9
		internal new static IntPtr class_ref
		{
			get
			{
				return JNIEnv.FindClass("com/wang/avi/indicators/LineScalePartyIndicator", ref LineScalePartyIndicator.java_class_handle);
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000148 RID: 328 RVA: 0x0000760A File Offset: 0x0000580A
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LineScalePartyIndicator.class_ref;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000149 RID: 329 RVA: 0x00007611 File Offset: 0x00005811
		protected override Type ThresholdType
		{
			get
			{
				return typeof(LineScalePartyIndicator);
			}
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00003EDD File Offset: 0x000020DD
		protected LineScalePartyIndicator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00007620 File Offset: 0x00005820
		[Register(".ctor", "()V", "")]
		public LineScalePartyIndicator() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			if (base.GetType() != typeof(LineScalePartyIndicator))
			{
				base.SetHandle(JNIEnv.StartCreateInstance(base.GetType(), "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				return;
			}
			if (LineScalePartyIndicator.id_ctor == IntPtr.Zero)
			{
				LineScalePartyIndicator.id_ctor = JNIEnv.GetMethodID(LineScalePartyIndicator.class_ref, "<init>", "()V");
			}
			base.SetHandle(JNIEnv.StartCreateInstance(LineScalePartyIndicator.class_ref, LineScalePartyIndicator.id_ctor, Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance(base.Handle, LineScalePartyIndicator.class_ref, LineScalePartyIndicator.id_ctor, Array.Empty<JValue>());
		}

		// Token: 0x0600014C RID: 332 RVA: 0x000076F4 File Offset: 0x000058F4
		private static Delegate GetDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_Handler()
		{
			if (LineScalePartyIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ == null)
			{
				LineScalePartyIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr, IntPtr>(LineScalePartyIndicator.n_Draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_));
			}
			return LineScalePartyIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00007718 File Offset: 0x00005918
		private static void n_Draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			LineScalePartyIndicator @object = Java.Lang.Object.GetObject<LineScalePartyIndicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Canvas object2 = Java.Lang.Object.GetObject<Canvas>(native_p0, JniHandleOwnership.DoNotTransfer);
			Paint object3 = Java.Lang.Object.GetObject<Paint>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.Draw(object2, object3);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00007748 File Offset: 0x00005948
		[Register("draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V", "GetDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_Handler")]
		public unsafe override void Draw(Canvas p0, Paint p1)
		{
			if (LineScalePartyIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ == IntPtr.Zero)
			{
				LineScalePartyIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ = JNIEnv.GetMethodID(LineScalePartyIndicator.class_ref, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			ptr[1] = new JValue(p1);
			if (base.GetType() == this.ThresholdType)
			{
				JNIEnv.CallVoidMethod(base.Handle, LineScalePartyIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_, ptr);
				return;
			}
			JNIEnv.CallNonvirtualVoidMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V"), ptr);
			GC.KeepAlive(p0);
			GC.KeepAlive(p1);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00007802 File Offset: 0x00005A02
		private static Delegate GetOnCreateAnimatorsHandler()
		{
			if (LineScalePartyIndicator.cb_onCreateAnimators == null)
			{
				LineScalePartyIndicator.cb_onCreateAnimators = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr>(LineScalePartyIndicator.n_OnCreateAnimators));
			}
			return LineScalePartyIndicator.cb_onCreateAnimators;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00007828 File Offset: 0x00005A28
		private static IntPtr n_OnCreateAnimators(IntPtr jnienv, IntPtr native__this)
		{
			LineScalePartyIndicator @object = Java.Lang.Object.GetObject<LineScalePartyIndicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JavaList<ValueAnimator>.ToLocalJniHandle(@object.OnCreateAnimators());
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0000784C File Offset: 0x00005A4C
		[Register("onCreateAnimators", "()Ljava/util/ArrayList;", "GetOnCreateAnimatorsHandler")]
		public override IList<ValueAnimator> OnCreateAnimators()
		{
			if (LineScalePartyIndicator.id_onCreateAnimators == IntPtr.Zero)
			{
				LineScalePartyIndicator.id_onCreateAnimators = JNIEnv.GetMethodID(LineScalePartyIndicator.class_ref, "onCreateAnimators", "()Ljava/util/ArrayList;");
			}
			if (base.GetType() == this.ThresholdType)
			{
				return JavaList<ValueAnimator>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, LineScalePartyIndicator.id_onCreateAnimators), JniHandleOwnership.TransferLocalRef);
			}
			return JavaList<ValueAnimator>.FromJniHandle(JNIEnv.CallNonvirtualObjectMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "onCreateAnimators", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040000C1 RID: 193
		[Register("SCALE")]
		public const float Scale = 1f;

		// Token: 0x040000C2 RID: 194
		internal new static IntPtr java_class_handle;

		// Token: 0x040000C3 RID: 195
		private static IntPtr id_ctor;

		// Token: 0x040000C4 RID: 196
		private static Delegate cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;

		// Token: 0x040000C5 RID: 197
		private static IntPtr id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;

		// Token: 0x040000C6 RID: 198
		private static Delegate cb_onCreateAnimators;

		// Token: 0x040000C7 RID: 199
		private static IntPtr id_onCreateAnimators;
	}
}
