using System;
using Android.Runtime;

namespace Com.Wang.Avi.Indicators
{
	// Token: 0x02000014 RID: 20
	[Register("com/wang/avi/indicators/BallScaleRippleMultipleIndicator", DoNotGenerateAcw = true)]
	public class BallScaleRippleMultipleIndicator : BallScaleMultipleIndicator
	{
		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00006344 File Offset: 0x00004544
		internal new static IntPtr class_ref
		{
			get
			{
				return JNIEnv.FindClass("com/wang/avi/indicators/BallScaleRippleMultipleIndicator", ref BallScaleRippleMultipleIndicator.java_class_handle);
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000FE RID: 254 RVA: 0x00006355 File Offset: 0x00004555
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BallScaleRippleMultipleIndicator.class_ref;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000FF RID: 255 RVA: 0x0000635C File Offset: 0x0000455C
		protected override Type ThresholdType
		{
			get
			{
				return typeof(BallScaleRippleMultipleIndicator);
			}
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00006368 File Offset: 0x00004568
		protected BallScaleRippleMultipleIndicator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00006374 File Offset: 0x00004574
		[Register(".ctor", "()V", "")]
		public BallScaleRippleMultipleIndicator() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			if (base.GetType() != typeof(BallScaleRippleMultipleIndicator))
			{
				base.SetHandle(JNIEnv.StartCreateInstance(base.GetType(), "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				return;
			}
			if (BallScaleRippleMultipleIndicator.id_ctor == IntPtr.Zero)
			{
				BallScaleRippleMultipleIndicator.id_ctor = JNIEnv.GetMethodID(BallScaleRippleMultipleIndicator.class_ref, "<init>", "()V");
			}
			base.SetHandle(JNIEnv.StartCreateInstance(BallScaleRippleMultipleIndicator.class_ref, BallScaleRippleMultipleIndicator.id_ctor, Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance(base.Handle, BallScaleRippleMultipleIndicator.class_ref, BallScaleRippleMultipleIndicator.id_ctor, Array.Empty<JValue>());
		}

		// Token: 0x04000099 RID: 153
		internal new static IntPtr java_class_handle;

		// Token: 0x0400009A RID: 154
		private static IntPtr id_ctor;
	}
}
