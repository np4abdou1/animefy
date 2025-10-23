using System;
using System.Collections.Generic;
using Android.Animation;
using Android.Graphics;
using Android.Runtime;
using Java.Lang;

namespace Com.Wang.Avi.Indicators
{
	// Token: 0x02000017 RID: 23
	[Register("com/wang/avi/indicators/BallTrianglePathIndicator", DoNotGenerateAcw = true)]
	public class BallTrianglePathIndicator : Indicator
	{
		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000116 RID: 278 RVA: 0x0000697B File Offset: 0x00004B7B
		internal new static IntPtr class_ref
		{
			get
			{
				return JNIEnv.FindClass("com/wang/avi/indicators/BallTrianglePathIndicator", ref BallTrianglePathIndicator.java_class_handle);
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000117 RID: 279 RVA: 0x0000698C File Offset: 0x00004B8C
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BallTrianglePathIndicator.class_ref;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000118 RID: 280 RVA: 0x00006993 File Offset: 0x00004B93
		protected override Type ThresholdType
		{
			get
			{
				return typeof(BallTrianglePathIndicator);
			}
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00003EDD File Offset: 0x000020DD
		protected BallTrianglePathIndicator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600011A RID: 282 RVA: 0x000069A0 File Offset: 0x00004BA0
		[Register(".ctor", "()V", "")]
		public BallTrianglePathIndicator() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			if (base.GetType() != typeof(BallTrianglePathIndicator))
			{
				base.SetHandle(JNIEnv.StartCreateInstance(base.GetType(), "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				return;
			}
			if (BallTrianglePathIndicator.id_ctor == IntPtr.Zero)
			{
				BallTrianglePathIndicator.id_ctor = JNIEnv.GetMethodID(BallTrianglePathIndicator.class_ref, "<init>", "()V");
			}
			base.SetHandle(JNIEnv.StartCreateInstance(BallTrianglePathIndicator.class_ref, BallTrianglePathIndicator.id_ctor, Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance(base.Handle, BallTrianglePathIndicator.class_ref, BallTrianglePathIndicator.id_ctor, Array.Empty<JValue>());
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00006A74 File Offset: 0x00004C74
		private static Delegate GetDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_Handler()
		{
			if (BallTrianglePathIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ == null)
			{
				BallTrianglePathIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr, IntPtr>(BallTrianglePathIndicator.n_Draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_));
			}
			return BallTrianglePathIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00006A98 File Offset: 0x00004C98
		private static void n_Draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			BallTrianglePathIndicator @object = Java.Lang.Object.GetObject<BallTrianglePathIndicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Canvas object2 = Java.Lang.Object.GetObject<Canvas>(native_p0, JniHandleOwnership.DoNotTransfer);
			Paint object3 = Java.Lang.Object.GetObject<Paint>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.Draw(object2, object3);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00006AC8 File Offset: 0x00004CC8
		[Register("draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V", "GetDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_Handler")]
		public unsafe override void Draw(Canvas p0, Paint p1)
		{
			if (BallTrianglePathIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ == IntPtr.Zero)
			{
				BallTrianglePathIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ = JNIEnv.GetMethodID(BallTrianglePathIndicator.class_ref, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			ptr[1] = new JValue(p1);
			if (base.GetType() == this.ThresholdType)
			{
				JNIEnv.CallVoidMethod(base.Handle, BallTrianglePathIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_, ptr);
				return;
			}
			JNIEnv.CallNonvirtualVoidMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V"), ptr);
			GC.KeepAlive(p0);
			GC.KeepAlive(p1);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00006B82 File Offset: 0x00004D82
		private static Delegate GetOnCreateAnimatorsHandler()
		{
			if (BallTrianglePathIndicator.cb_onCreateAnimators == null)
			{
				BallTrianglePathIndicator.cb_onCreateAnimators = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr>(BallTrianglePathIndicator.n_OnCreateAnimators));
			}
			return BallTrianglePathIndicator.cb_onCreateAnimators;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00006BA8 File Offset: 0x00004DA8
		private static IntPtr n_OnCreateAnimators(IntPtr jnienv, IntPtr native__this)
		{
			BallTrianglePathIndicator @object = Java.Lang.Object.GetObject<BallTrianglePathIndicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JavaList<ValueAnimator>.ToLocalJniHandle(@object.OnCreateAnimators());
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00006BCC File Offset: 0x00004DCC
		[Register("onCreateAnimators", "()Ljava/util/ArrayList;", "GetOnCreateAnimatorsHandler")]
		public override IList<ValueAnimator> OnCreateAnimators()
		{
			if (BallTrianglePathIndicator.id_onCreateAnimators == IntPtr.Zero)
			{
				BallTrianglePathIndicator.id_onCreateAnimators = JNIEnv.GetMethodID(BallTrianglePathIndicator.class_ref, "onCreateAnimators", "()Ljava/util/ArrayList;");
			}
			if (base.GetType() == this.ThresholdType)
			{
				return JavaList<ValueAnimator>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, BallTrianglePathIndicator.id_onCreateAnimators), JniHandleOwnership.TransferLocalRef);
			}
			return JavaList<ValueAnimator>.FromJniHandle(JNIEnv.CallNonvirtualObjectMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "onCreateAnimators", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040000A6 RID: 166
		internal new static IntPtr java_class_handle;

		// Token: 0x040000A7 RID: 167
		private static IntPtr id_ctor;

		// Token: 0x040000A8 RID: 168
		private static Delegate cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;

		// Token: 0x040000A9 RID: 169
		private static IntPtr id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;

		// Token: 0x040000AA RID: 170
		private static Delegate cb_onCreateAnimators;

		// Token: 0x040000AB RID: 171
		private static IntPtr id_onCreateAnimators;
	}
}
