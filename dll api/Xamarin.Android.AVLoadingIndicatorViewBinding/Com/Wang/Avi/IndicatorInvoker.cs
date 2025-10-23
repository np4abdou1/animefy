using System;
using System.Collections.Generic;
using Android.Animation;
using Android.Graphics;
using Android.Runtime;

namespace Com.Wang.Avi
{
	// Token: 0x02000006 RID: 6
	[Register("com/wang/avi/Indicator", DoNotGenerateAcw = true)]
	internal class IndicatorInvoker : Indicator
	{
		// Token: 0x06000070 RID: 112 RVA: 0x00003EDD File Offset: 0x000020DD
		public IndicatorInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00003EE7 File Offset: 0x000020E7
		protected override Type ThresholdType
		{
			get
			{
				return typeof(IndicatorInvoker);
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00003EF4 File Offset: 0x000020F4
		[Register("draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V", "GetDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_Handler")]
		public unsafe override void Draw(Canvas p0, Paint p1)
		{
			if (IndicatorInvoker.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ == IntPtr.Zero)
			{
				IndicatorInvoker.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ = JNIEnv.GetMethodID(Indicator.class_ref, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			ptr[1] = new JValue(p1);
			JNIEnv.CallVoidMethod(base.Handle, IndicatorInvoker.id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_, ptr);
			GC.KeepAlive(p0);
			GC.KeepAlive(p1);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00003F74 File Offset: 0x00002174
		[Register("onCreateAnimators", "()Ljava/util/ArrayList;", "GetOnCreateAnimatorsHandler")]
		public override IList<ValueAnimator> OnCreateAnimators()
		{
			if (IndicatorInvoker.id_onCreateAnimators == IntPtr.Zero)
			{
				IndicatorInvoker.id_onCreateAnimators = JNIEnv.GetMethodID(Indicator.class_ref, "onCreateAnimators", "()Ljava/util/ArrayList;");
			}
			return JavaList<ValueAnimator>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, IndicatorInvoker.id_onCreateAnimators), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400004A RID: 74
		private static IntPtr id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;

		// Token: 0x0400004B RID: 75
		private static IntPtr id_onCreateAnimators;
	}
}
