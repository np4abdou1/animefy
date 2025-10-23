using System;
using System.Collections.Generic;
using Android.Animation;
using Android.Graphics;
using Android.Runtime;
using Java.Lang;

namespace Com.Wang.Avi.Indicators
{
	// Token: 0x02000022 RID: 34
	[Register("com/wang/avi/indicators/SquareSpinIndicator", DoNotGenerateAcw = true)]
	public class SquareSpinIndicator : Indicator
	{
		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000177 RID: 375 RVA: 0x00008195 File Offset: 0x00006395
		internal new static IntPtr class_ref
		{
			get
			{
				return JNIEnv.FindClass("com/wang/avi/indicators/SquareSpinIndicator", ref SquareSpinIndicator.java_class_handle);
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000178 RID: 376 RVA: 0x000081A6 File Offset: 0x000063A6
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SquareSpinIndicator.class_ref;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000179 RID: 377 RVA: 0x000081AD File Offset: 0x000063AD
		protected override Type ThresholdType
		{
			get
			{
				return typeof(SquareSpinIndicator);
			}
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00003EDD File Offset: 0x000020DD
		protected SquareSpinIndicator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600017B RID: 379 RVA: 0x000081BC File Offset: 0x000063BC
		[Register(".ctor", "()V", "")]
		public SquareSpinIndicator() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			if (base.GetType() != typeof(SquareSpinIndicator))
			{
				base.SetHandle(JNIEnv.StartCreateInstance(base.GetType(), "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				return;
			}
			if (SquareSpinIndicator.id_ctor == IntPtr.Zero)
			{
				SquareSpinIndicator.id_ctor = JNIEnv.GetMethodID(SquareSpinIndicator.class_ref, "<init>", "()V");
			}
			base.SetHandle(JNIEnv.StartCreateInstance(SquareSpinIndicator.class_ref, SquareSpinIndicator.id_ctor, Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance(base.Handle, SquareSpinIndicator.class_ref, SquareSpinIndicator.id_ctor, Array.Empty<JValue>());
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00008290 File Offset: 0x00006490
		private static Delegate GetDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_Handler()
		{
			if (SquareSpinIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ == null)
			{
				SquareSpinIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr, IntPtr>(SquareSpinIndicator.n_Draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_));
			}
			return SquareSpinIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;
		}

		// Token: 0x0600017D RID: 381 RVA: 0x000082B4 File Offset: 0x000064B4
		private static void n_Draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			SquareSpinIndicator @object = Java.Lang.Object.GetObject<SquareSpinIndicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Canvas object2 = Java.Lang.Object.GetObject<Canvas>(native_p0, JniHandleOwnership.DoNotTransfer);
			Paint object3 = Java.Lang.Object.GetObject<Paint>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.Draw(object2, object3);
		}

		// Token: 0x0600017E RID: 382 RVA: 0x000082E4 File Offset: 0x000064E4
		[Register("draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V", "GetDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_Handler")]
		public unsafe override void Draw(Canvas p0, Paint p1)
		{
			if (SquareSpinIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ == IntPtr.Zero)
			{
				SquareSpinIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ = JNIEnv.GetMethodID(SquareSpinIndicator.class_ref, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			ptr[1] = new JValue(p1);
			if (base.GetType() == this.ThresholdType)
			{
				JNIEnv.CallVoidMethod(base.Handle, SquareSpinIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_, ptr);
				return;
			}
			JNIEnv.CallNonvirtualVoidMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V"), ptr);
			GC.KeepAlive(p0);
			GC.KeepAlive(p1);
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0000839E File Offset: 0x0000659E
		private static Delegate GetOnCreateAnimatorsHandler()
		{
			if (SquareSpinIndicator.cb_onCreateAnimators == null)
			{
				SquareSpinIndicator.cb_onCreateAnimators = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr>(SquareSpinIndicator.n_OnCreateAnimators));
			}
			return SquareSpinIndicator.cb_onCreateAnimators;
		}

		// Token: 0x06000180 RID: 384 RVA: 0x000083C4 File Offset: 0x000065C4
		private static IntPtr n_OnCreateAnimators(IntPtr jnienv, IntPtr native__this)
		{
			SquareSpinIndicator @object = Java.Lang.Object.GetObject<SquareSpinIndicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JavaList<ValueAnimator>.ToLocalJniHandle(@object.OnCreateAnimators());
		}

		// Token: 0x06000181 RID: 385 RVA: 0x000083E8 File Offset: 0x000065E8
		[Register("onCreateAnimators", "()Ljava/util/ArrayList;", "GetOnCreateAnimatorsHandler")]
		public override IList<ValueAnimator> OnCreateAnimators()
		{
			if (SquareSpinIndicator.id_onCreateAnimators == IntPtr.Zero)
			{
				SquareSpinIndicator.id_onCreateAnimators = JNIEnv.GetMethodID(SquareSpinIndicator.class_ref, "onCreateAnimators", "()Ljava/util/ArrayList;");
			}
			if (base.GetType() == this.ThresholdType)
			{
				return JavaList<ValueAnimator>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, SquareSpinIndicator.id_onCreateAnimators), JniHandleOwnership.TransferLocalRef);
			}
			return JavaList<ValueAnimator>.FromJniHandle(JNIEnv.CallNonvirtualObjectMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "onCreateAnimators", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040000DA RID: 218
		internal new static IntPtr java_class_handle;

		// Token: 0x040000DB RID: 219
		private static IntPtr id_ctor;

		// Token: 0x040000DC RID: 220
		private static Delegate cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;

		// Token: 0x040000DD RID: 221
		private static IntPtr id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;

		// Token: 0x040000DE RID: 222
		private static Delegate cb_onCreateAnimators;

		// Token: 0x040000DF RID: 223
		private static IntPtr id_onCreateAnimators;
	}
}
