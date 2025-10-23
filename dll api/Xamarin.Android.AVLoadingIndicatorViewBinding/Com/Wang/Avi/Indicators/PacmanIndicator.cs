using System;
using System.Collections.Generic;
using Android.Animation;
using Android.Graphics;
using Android.Runtime;
using Java.Lang;

namespace Com.Wang.Avi.Indicators
{
	// Token: 0x02000020 RID: 32
	[Register("com/wang/avi/indicators/PacmanIndicator", DoNotGenerateAcw = true)]
	public class PacmanIndicator : Indicator
	{
		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000161 RID: 353 RVA: 0x00007BD8 File Offset: 0x00005DD8
		internal new static IntPtr class_ref
		{
			get
			{
				return JNIEnv.FindClass("com/wang/avi/indicators/PacmanIndicator", ref PacmanIndicator.java_class_handle);
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000162 RID: 354 RVA: 0x00007BE9 File Offset: 0x00005DE9
		protected override IntPtr ThresholdClass
		{
			get
			{
				return PacmanIndicator.class_ref;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000163 RID: 355 RVA: 0x00007BF0 File Offset: 0x00005DF0
		protected override Type ThresholdType
		{
			get
			{
				return typeof(PacmanIndicator);
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00003EDD File Offset: 0x000020DD
		protected PacmanIndicator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00007BFC File Offset: 0x00005DFC
		[Register(".ctor", "()V", "")]
		public PacmanIndicator() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			if (base.GetType() != typeof(PacmanIndicator))
			{
				base.SetHandle(JNIEnv.StartCreateInstance(base.GetType(), "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				return;
			}
			if (PacmanIndicator.id_ctor == IntPtr.Zero)
			{
				PacmanIndicator.id_ctor = JNIEnv.GetMethodID(PacmanIndicator.class_ref, "<init>", "()V");
			}
			base.SetHandle(JNIEnv.StartCreateInstance(PacmanIndicator.class_ref, PacmanIndicator.id_ctor, Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance(base.Handle, PacmanIndicator.class_ref, PacmanIndicator.id_ctor, Array.Empty<JValue>());
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00007CD0 File Offset: 0x00005ED0
		private static Delegate GetDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_Handler()
		{
			if (PacmanIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ == null)
			{
				PacmanIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr, IntPtr>(PacmanIndicator.n_Draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_));
			}
			return PacmanIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00007CF4 File Offset: 0x00005EF4
		private static void n_Draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			PacmanIndicator @object = Java.Lang.Object.GetObject<PacmanIndicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Canvas object2 = Java.Lang.Object.GetObject<Canvas>(native_p0, JniHandleOwnership.DoNotTransfer);
			Paint object3 = Java.Lang.Object.GetObject<Paint>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.Draw(object2, object3);
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00007D24 File Offset: 0x00005F24
		[Register("draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V", "GetDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_Handler")]
		public unsafe override void Draw(Canvas p0, Paint p1)
		{
			if (PacmanIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ == IntPtr.Zero)
			{
				PacmanIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ = JNIEnv.GetMethodID(PacmanIndicator.class_ref, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			ptr[1] = new JValue(p1);
			if (base.GetType() == this.ThresholdType)
			{
				JNIEnv.CallVoidMethod(base.Handle, PacmanIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_, ptr);
				return;
			}
			JNIEnv.CallNonvirtualVoidMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V"), ptr);
			GC.KeepAlive(p0);
			GC.KeepAlive(p1);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00007DDE File Offset: 0x00005FDE
		private static Delegate GetOnCreateAnimatorsHandler()
		{
			if (PacmanIndicator.cb_onCreateAnimators == null)
			{
				PacmanIndicator.cb_onCreateAnimators = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr>(PacmanIndicator.n_OnCreateAnimators));
			}
			return PacmanIndicator.cb_onCreateAnimators;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00007E04 File Offset: 0x00006004
		private static IntPtr n_OnCreateAnimators(IntPtr jnienv, IntPtr native__this)
		{
			PacmanIndicator @object = Java.Lang.Object.GetObject<PacmanIndicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JavaList<ValueAnimator>.ToLocalJniHandle(@object.OnCreateAnimators());
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00007E28 File Offset: 0x00006028
		[Register("onCreateAnimators", "()Ljava/util/ArrayList;", "GetOnCreateAnimatorsHandler")]
		public override IList<ValueAnimator> OnCreateAnimators()
		{
			if (PacmanIndicator.id_onCreateAnimators == IntPtr.Zero)
			{
				PacmanIndicator.id_onCreateAnimators = JNIEnv.GetMethodID(PacmanIndicator.class_ref, "onCreateAnimators", "()Ljava/util/ArrayList;");
			}
			if (base.GetType() == this.ThresholdType)
			{
				return JavaList<ValueAnimator>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, PacmanIndicator.id_onCreateAnimators), JniHandleOwnership.TransferLocalRef);
			}
			return JavaList<ValueAnimator>.FromJniHandle(JNIEnv.CallNonvirtualObjectMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "onCreateAnimators", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040000CE RID: 206
		internal new static IntPtr java_class_handle;

		// Token: 0x040000CF RID: 207
		private static IntPtr id_ctor;

		// Token: 0x040000D0 RID: 208
		private static Delegate cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;

		// Token: 0x040000D1 RID: 209
		private static IntPtr id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;

		// Token: 0x040000D2 RID: 210
		private static Delegate cb_onCreateAnimators;

		// Token: 0x040000D3 RID: 211
		private static IntPtr id_onCreateAnimators;
	}
}
