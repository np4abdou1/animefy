using System;
using System.Collections.Generic;
using Android.Animation;
using Android.Graphics;
using Android.Runtime;
using Java.Lang;

namespace Com.Wang.Avi.Indicators
{
	// Token: 0x02000015 RID: 21
	[Register("com/wang/avi/indicators/BallSpinFadeLoaderIndicator", DoNotGenerateAcw = true)]
	public class BallSpinFadeLoaderIndicator : Indicator
	{
		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000102 RID: 258 RVA: 0x00006448 File Offset: 0x00004648
		internal new static IntPtr class_ref
		{
			get
			{
				return JNIEnv.FindClass("com/wang/avi/indicators/BallSpinFadeLoaderIndicator", ref BallSpinFadeLoaderIndicator.java_class_handle);
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000103 RID: 259 RVA: 0x00006459 File Offset: 0x00004659
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BallSpinFadeLoaderIndicator.class_ref;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000104 RID: 260 RVA: 0x00006460 File Offset: 0x00004660
		protected override Type ThresholdType
		{
			get
			{
				return typeof(BallSpinFadeLoaderIndicator);
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00003EDD File Offset: 0x000020DD
		protected BallSpinFadeLoaderIndicator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0000646C File Offset: 0x0000466C
		[Register(".ctor", "()V", "")]
		public BallSpinFadeLoaderIndicator() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			if (base.GetType() != typeof(BallSpinFadeLoaderIndicator))
			{
				base.SetHandle(JNIEnv.StartCreateInstance(base.GetType(), "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				return;
			}
			if (BallSpinFadeLoaderIndicator.id_ctor == IntPtr.Zero)
			{
				BallSpinFadeLoaderIndicator.id_ctor = JNIEnv.GetMethodID(BallSpinFadeLoaderIndicator.class_ref, "<init>", "()V");
			}
			base.SetHandle(JNIEnv.StartCreateInstance(BallSpinFadeLoaderIndicator.class_ref, BallSpinFadeLoaderIndicator.id_ctor, Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance(base.Handle, BallSpinFadeLoaderIndicator.class_ref, BallSpinFadeLoaderIndicator.id_ctor, Array.Empty<JValue>());
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00006540 File Offset: 0x00004740
		private static Delegate GetDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_Handler()
		{
			if (BallSpinFadeLoaderIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ == null)
			{
				BallSpinFadeLoaderIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr, IntPtr>(BallSpinFadeLoaderIndicator.n_Draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_));
			}
			return BallSpinFadeLoaderIndicator.cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00006564 File Offset: 0x00004764
		private static void n_Draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			BallSpinFadeLoaderIndicator @object = Java.Lang.Object.GetObject<BallSpinFadeLoaderIndicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Canvas object2 = Java.Lang.Object.GetObject<Canvas>(native_p0, JniHandleOwnership.DoNotTransfer);
			Paint object3 = Java.Lang.Object.GetObject<Paint>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.Draw(object2, object3);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00006594 File Offset: 0x00004794
		[Register("draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V", "GetDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_Handler")]
		public unsafe override void Draw(Canvas p0, Paint p1)
		{
			if (BallSpinFadeLoaderIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ == IntPtr.Zero)
			{
				BallSpinFadeLoaderIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ = JNIEnv.GetMethodID(BallSpinFadeLoaderIndicator.class_ref, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			ptr[1] = new JValue(p1);
			if (base.GetType() == this.ThresholdType)
			{
				JNIEnv.CallVoidMethod(base.Handle, BallSpinFadeLoaderIndicator.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_, ptr);
				return;
			}
			JNIEnv.CallNonvirtualVoidMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V"), ptr);
			GC.KeepAlive(p0);
			GC.KeepAlive(p1);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0000664E File Offset: 0x0000484E
		private static Delegate GetOnCreateAnimatorsHandler()
		{
			if (BallSpinFadeLoaderIndicator.cb_onCreateAnimators == null)
			{
				BallSpinFadeLoaderIndicator.cb_onCreateAnimators = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr>(BallSpinFadeLoaderIndicator.n_OnCreateAnimators));
			}
			return BallSpinFadeLoaderIndicator.cb_onCreateAnimators;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00006674 File Offset: 0x00004874
		private static IntPtr n_OnCreateAnimators(IntPtr jnienv, IntPtr native__this)
		{
			BallSpinFadeLoaderIndicator @object = Java.Lang.Object.GetObject<BallSpinFadeLoaderIndicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JavaList<ValueAnimator>.ToLocalJniHandle(@object.OnCreateAnimators());
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00006698 File Offset: 0x00004898
		[Register("onCreateAnimators", "()Ljava/util/ArrayList;", "GetOnCreateAnimatorsHandler")]
		public override IList<ValueAnimator> OnCreateAnimators()
		{
			if (BallSpinFadeLoaderIndicator.id_onCreateAnimators == IntPtr.Zero)
			{
				BallSpinFadeLoaderIndicator.id_onCreateAnimators = JNIEnv.GetMethodID(BallSpinFadeLoaderIndicator.class_ref, "onCreateAnimators", "()Ljava/util/ArrayList;");
			}
			if (base.GetType() == this.ThresholdType)
			{
				return JavaList<ValueAnimator>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, BallSpinFadeLoaderIndicator.id_onCreateAnimators), JniHandleOwnership.TransferLocalRef);
			}
			return JavaList<ValueAnimator>.FromJniHandle(JNIEnv.CallNonvirtualObjectMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "onCreateAnimators", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400009B RID: 155
		[Register("SCALE")]
		public const float Scale = 1f;

		// Token: 0x0400009C RID: 156
		internal new static IntPtr java_class_handle;

		// Token: 0x0400009D RID: 157
		private static IntPtr id_ctor;

		// Token: 0x0400009E RID: 158
		private static Delegate cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;

		// Token: 0x0400009F RID: 159
		private static IntPtr id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;

		// Token: 0x040000A0 RID: 160
		private static Delegate cb_onCreateAnimators;

		// Token: 0x040000A1 RID: 161
		private static IntPtr id_onCreateAnimators;

		// Token: 0x02000016 RID: 22
		[Register("com/wang/avi/indicators/BallSpinFadeLoaderIndicator$Point", DoNotGenerateAcw = true)]
		public sealed class Point : Java.Lang.Object
		{
			// Token: 0x1700003F RID: 63
			// (get) Token: 0x0600010D RID: 269 RVA: 0x00006725 File Offset: 0x00004925
			// (set) Token: 0x0600010E RID: 270 RVA: 0x00006761 File Offset: 0x00004961
			[Register("x")]
			public float X
			{
				get
				{
					if (BallSpinFadeLoaderIndicator.Point.x_jfieldId == IntPtr.Zero)
					{
						BallSpinFadeLoaderIndicator.Point.x_jfieldId = JNIEnv.GetFieldID(BallSpinFadeLoaderIndicator.Point.class_ref, "x", "F");
					}
					return JNIEnv.GetFloatField(base.Handle, BallSpinFadeLoaderIndicator.Point.x_jfieldId);
				}
				set
				{
					if (BallSpinFadeLoaderIndicator.Point.x_jfieldId == IntPtr.Zero)
					{
						BallSpinFadeLoaderIndicator.Point.x_jfieldId = JNIEnv.GetFieldID(BallSpinFadeLoaderIndicator.Point.class_ref, "x", "F");
					}
					JNIEnv.SetField(base.Handle, BallSpinFadeLoaderIndicator.Point.x_jfieldId, value);
				}
			}

			// Token: 0x17000040 RID: 64
			// (get) Token: 0x0600010F RID: 271 RVA: 0x0000679E File Offset: 0x0000499E
			// (set) Token: 0x06000110 RID: 272 RVA: 0x000067DA File Offset: 0x000049DA
			[Register("y")]
			public float Y
			{
				get
				{
					if (BallSpinFadeLoaderIndicator.Point.y_jfieldId == IntPtr.Zero)
					{
						BallSpinFadeLoaderIndicator.Point.y_jfieldId = JNIEnv.GetFieldID(BallSpinFadeLoaderIndicator.Point.class_ref, "y", "F");
					}
					return JNIEnv.GetFloatField(base.Handle, BallSpinFadeLoaderIndicator.Point.y_jfieldId);
				}
				set
				{
					if (BallSpinFadeLoaderIndicator.Point.y_jfieldId == IntPtr.Zero)
					{
						BallSpinFadeLoaderIndicator.Point.y_jfieldId = JNIEnv.GetFieldID(BallSpinFadeLoaderIndicator.Point.class_ref, "y", "F");
					}
					JNIEnv.SetField(base.Handle, BallSpinFadeLoaderIndicator.Point.y_jfieldId, value);
				}
			}

			// Token: 0x17000041 RID: 65
			// (get) Token: 0x06000111 RID: 273 RVA: 0x00006817 File Offset: 0x00004A17
			internal static IntPtr class_ref
			{
				get
				{
					return JNIEnv.FindClass("com/wang/avi/indicators/BallSpinFadeLoaderIndicator$Point", ref BallSpinFadeLoaderIndicator.Point.java_class_handle);
				}
			}

			// Token: 0x17000042 RID: 66
			// (get) Token: 0x06000112 RID: 274 RVA: 0x00006828 File Offset: 0x00004A28
			protected override IntPtr ThresholdClass
			{
				get
				{
					return BallSpinFadeLoaderIndicator.Point.class_ref;
				}
			}

			// Token: 0x17000043 RID: 67
			// (get) Token: 0x06000113 RID: 275 RVA: 0x0000682F File Offset: 0x00004A2F
			protected override Type ThresholdType
			{
				get
				{
					return typeof(BallSpinFadeLoaderIndicator.Point);
				}
			}

			// Token: 0x06000114 RID: 276 RVA: 0x00002BB9 File Offset: 0x00000DB9
			internal Point(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06000115 RID: 277 RVA: 0x0000683C File Offset: 0x00004A3C
			[Register(".ctor", "(Lcom/wang/avi/indicators/BallSpinFadeLoaderIndicator;FF)V", "")]
			public unsafe Point(BallSpinFadeLoaderIndicator __self, float p1, float p2) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(__self);
				ptr[1] = new JValue(p1);
				ptr[2] = new JValue(p2);
				if (base.GetType() != typeof(BallSpinFadeLoaderIndicator.Point))
				{
					base.SetHandle(JNIEnv.StartCreateInstance(base.GetType(), "(L" + JNIEnv.GetJniName(base.GetType().DeclaringType) + ";FF)V", ptr), JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance(base.Handle, "(L" + JNIEnv.GetJniName(base.GetType().DeclaringType) + ";FF)V", ptr);
					return;
				}
				if (BallSpinFadeLoaderIndicator.Point.id_ctor_Lcom_wang_avi_indicators_BallSpinFadeLoaderIndicator_FF == IntPtr.Zero)
				{
					BallSpinFadeLoaderIndicator.Point.id_ctor_Lcom_wang_avi_indicators_BallSpinFadeLoaderIndicator_FF = JNIEnv.GetMethodID(BallSpinFadeLoaderIndicator.Point.class_ref, "<init>", "(Lcom/wang/avi/indicators/BallSpinFadeLoaderIndicator;FF)V");
				}
				base.SetHandle(JNIEnv.StartCreateInstance(BallSpinFadeLoaderIndicator.Point.class_ref, BallSpinFadeLoaderIndicator.Point.id_ctor_Lcom_wang_avi_indicators_BallSpinFadeLoaderIndicator_FF, ptr), JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance(base.Handle, BallSpinFadeLoaderIndicator.Point.class_ref, BallSpinFadeLoaderIndicator.Point.id_ctor_Lcom_wang_avi_indicators_BallSpinFadeLoaderIndicator_FF, ptr);
				GC.KeepAlive(__self);
			}

			// Token: 0x040000A2 RID: 162
			private static IntPtr x_jfieldId;

			// Token: 0x040000A3 RID: 163
			private static IntPtr y_jfieldId;

			// Token: 0x040000A4 RID: 164
			internal static IntPtr java_class_handle;

			// Token: 0x040000A5 RID: 165
			private static IntPtr id_ctor_Lcom_wang_avi_indicators_BallSpinFadeLoaderIndicator_FF;
		}
	}
}
