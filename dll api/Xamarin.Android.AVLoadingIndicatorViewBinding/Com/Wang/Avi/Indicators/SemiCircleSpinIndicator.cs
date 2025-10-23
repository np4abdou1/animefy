using System;
using System.Collections.Generic;
using Android.Animation;
using Android.Graphics;
using Android.Runtime;
using Java.Lang;

namespace Com.Wang.Avi.Indicators
{
	// Token: 0x02000021 RID: 33
	[Register("com/wang/avi/indicators/SemiCircleSpinIndicator", DoNotGenerateAcw = true)]
	public class SemiCircleSpinIndicator : Indicator
	{
		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600016C RID: 364 RVA: 0x00007EB5 File Offset: 0x000060B5
		internal new static IntPtr class_ref
		{
			get
			{
				return JNIEnv.FindClass("com/wang/avi/indicators/SemiCircleSpinIndicator", ref SemiCircleSpinIndicator.java_class_handle);
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600016D RID: 365 RVA: 0x00007EC6 File Offset: 0x000060C6
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SemiCircleSpinIndicator.class_ref;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600016E RID: 366 RVA: 0x00007ECD File Offset: 0x000060CD
		protected override Type ThresholdType
		{
			get
			{
				return typeof(SemiCircleSpinIndicator);
			}
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00003EDD File Offset: 0x000020DD
		protected SemiCircleSpinIndicator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00007EDC File Offset: 0x000060DC
		[Register(".ctor", "()V", "")]
		public SemiCircleSpinIndicator() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			if (base.GetType() != typeof(SemiCircleSpinIndicator))
			{
				base.SetHandle(JNIEnv.StartCreateInstance(base.GetType(), "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				return;
			}
			if (SemiCircleSpinIndicator.id_ctor == IntPtr.Zero)
			{
				SemiCircleSpinIndicator.id_ctor = JNIEnv.GetMethodID(SemiCircleSpinIndicator.class_ref, "<init>", "()V");
			}
			base.SetHandle(JNIEnv.StartCreateInstance(SemiCircleSpinIndicator.class_ref, SemiCircleSpinIndicator.id_ctor, Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance(base.Handle, SemiCircleSpinIndicator.class_ref, SemiCircleSpinIndicator.id_ctor, Array.Empty<JValue>());
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00007FB0 File Offset: 0x000061B0
		private static Delegate GetDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_Handler()
		{
			if (SemiCircleSpinIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ == null)
			{
				SemiCircleSpinIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr, IntPtr>(SemiCircleSpinIndicator.n_Draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_));
			}
			return SemiCircleSpinIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00007FD4 File Offset: 0x000061D4
		private static void n_Draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			SemiCircleSpinIndicator @object = Java.Lang.Object.GetObject<SemiCircleSpinIndicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Canvas object2 = Java.Lang.Object.GetObject<Canvas>(native_p0, JniHandleOwnership.DoNotTransfer);
			Paint object3 = Java.Lang.Object.GetObject<Paint>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.Draw(object2, object3);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00008004 File Offset: 0x00006204
		[Register("draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V", "GetDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_Handler")]
		public unsafe override void Draw(Canvas p0, Paint p1)
		{
			if (SemiCircleSpinIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ == IntPtr.Zero)
			{
				SemiCircleSpinIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ = JNIEnv.GetMethodID(SemiCircleSpinIndicator.class_ref, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			ptr[1] = new JValue(p1);
			if (base.GetType() == this.ThresholdType)
			{
				JNIEnv.CallVoidMethod(base.Handle, SemiCircleSpinIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_, ptr);
				return;
			}
			JNIEnv.CallNonvirtualVoidMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V"), ptr);
			GC.KeepAlive(p0);
			GC.KeepAlive(p1);
		}

		// Token: 0x06000174 RID: 372 RVA: 0x000080BE File Offset: 0x000062BE
		private static Delegate GetOnCreateAnimatorsHandler()
		{
			if (SemiCircleSpinIndicator.cb_onCreateAnimators == null)
			{
				SemiCircleSpinIndicator.cb_onCreateAnimators = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr>(SemiCircleSpinIndicator.n_OnCreateAnimators));
			}
			return SemiCircleSpinIndicator.cb_onCreateAnimators;
		}

		// Token: 0x06000175 RID: 373 RVA: 0x000080E4 File Offset: 0x000062E4
		private static IntPtr n_OnCreateAnimators(IntPtr jnienv, IntPtr native__this)
		{
			SemiCircleSpinIndicator @object = Java.Lang.Object.GetObject<SemiCircleSpinIndicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JavaList<ValueAnimator>.ToLocalJniHandle(@object.OnCreateAnimators());
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00008108 File Offset: 0x00006308
		[Register("onCreateAnimators", "()Ljava/util/ArrayList;", "GetOnCreateAnimatorsHandler")]
		public override IList<ValueAnimator> OnCreateAnimators()
		{
			if (SemiCircleSpinIndicator.id_onCreateAnimators == IntPtr.Zero)
			{
				SemiCircleSpinIndicator.id_onCreateAnimators = JNIEnv.GetMethodID(SemiCircleSpinIndicator.class_ref, "onCreateAnimators", "()Ljava/util/ArrayList;");
			}
			if (base.GetType() == this.ThresholdType)
			{
				return JavaList<ValueAnimator>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, SemiCircleSpinIndicator.id_onCreateAnimators), JniHandleOwnership.TransferLocalRef);
			}
			return JavaList<ValueAnimator>.FromJniHandle(JNIEnv.CallNonvirtualObjectMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "onCreateAnimators", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040000D4 RID: 212
		internal new static IntPtr java_class_handle;

		// Token: 0x040000D5 RID: 213
		private static IntPtr id_ctor;

		// Token: 0x040000D6 RID: 214
		private static Delegate cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;

		// Token: 0x040000D7 RID: 215
		private static IntPtr id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;

		// Token: 0x040000D8 RID: 216
		private static Delegate cb_onCreateAnimators;

		// Token: 0x040000D9 RID: 217
		private static IntPtr id_onCreateAnimators;
	}
}
