using System;
using Android.Runtime;

namespace Com.Wang.Avi.Indicators
{
	// Token: 0x02000013 RID: 19
	[Register("com/wang/avi/indicators/BallScaleRippleIndicator", DoNotGenerateAcw = true)]
	public class BallScaleRippleIndicator : BallScaleIndicator
	{
		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x00006241 File Offset: 0x00004441
		internal new static IntPtr class_ref
		{
			get
			{
				return JNIEnv.FindClass("com/wang/avi/indicators/BallScaleRippleIndicator", ref BallScaleRippleIndicator.java_class_handle);
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x00006252 File Offset: 0x00004452
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BallScaleRippleIndicator.class_ref;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000FA RID: 250 RVA: 0x00006259 File Offset: 0x00004459
		protected override Type ThresholdType
		{
			get
			{
				return typeof(BallScaleRippleIndicator);
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00006265 File Offset: 0x00004465
		protected BallScaleRippleIndicator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00006270 File Offset: 0x00004470
		[Register(".ctor", "()V", "")]
		public BallScaleRippleIndicator() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			if (base.GetType() != typeof(BallScaleRippleIndicator))
			{
				base.SetHandle(JNIEnv.StartCreateInstance(base.GetType(), "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				return;
			}
			if (BallScaleRippleIndicator.id_ctor == IntPtr.Zero)
			{
				BallScaleRippleIndicator.id_ctor = JNIEnv.GetMethodID(BallScaleRippleIndicator.class_ref, "<init>", "()V");
			}
			base.SetHandle(JNIEnv.StartCreateInstance(BallScaleRippleIndicator.class_ref, BallScaleRippleIndicator.id_ctor, Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance(base.Handle, BallScaleRippleIndicator.class_ref, BallScaleRippleIndicator.id_ctor, Array.Empty<JValue>());
		}

		// Token: 0x04000097 RID: 151
		internal new static IntPtr java_class_handle;

		// Token: 0x04000098 RID: 152
		private static IntPtr id_ctor;
	}
}
