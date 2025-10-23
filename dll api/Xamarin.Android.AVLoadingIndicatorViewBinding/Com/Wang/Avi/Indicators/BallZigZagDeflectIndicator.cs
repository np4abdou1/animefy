using System;
using Android.Runtime;

namespace Com.Wang.Avi.Indicators
{
	// Token: 0x02000018 RID: 24
	[Register("com/wang/avi/indicators/BallZigZagDeflectIndicator", DoNotGenerateAcw = true)]
	public class BallZigZagDeflectIndicator : BallZigZagIndicator
	{
		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000121 RID: 289 RVA: 0x00006C59 File Offset: 0x00004E59
		internal new static IntPtr class_ref
		{
			get
			{
				return JNIEnv.FindClass("com/wang/avi/indicators/BallZigZagDeflectIndicator", ref BallZigZagDeflectIndicator.java_class_handle);
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000122 RID: 290 RVA: 0x00006C6A File Offset: 0x00004E6A
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BallZigZagDeflectIndicator.class_ref;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000123 RID: 291 RVA: 0x00006C71 File Offset: 0x00004E71
		protected override Type ThresholdType
		{
			get
			{
				return typeof(BallZigZagDeflectIndicator);
			}
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00006C7D File Offset: 0x00004E7D
		protected BallZigZagDeflectIndicator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00006C88 File Offset: 0x00004E88
		[Register(".ctor", "()V", "")]
		public BallZigZagDeflectIndicator() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			if (base.GetType() != typeof(BallZigZagDeflectIndicator))
			{
				base.SetHandle(JNIEnv.StartCreateInstance(base.GetType(), "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				return;
			}
			if (BallZigZagDeflectIndicator.id_ctor == IntPtr.Zero)
			{
				BallZigZagDeflectIndicator.id_ctor = JNIEnv.GetMethodID(BallZigZagDeflectIndicator.class_ref, "<init>", "()V");
			}
			base.SetHandle(JNIEnv.StartCreateInstance(BallZigZagDeflectIndicator.class_ref, BallZigZagDeflectIndicator.id_ctor, Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance(base.Handle, BallZigZagDeflectIndicator.class_ref, BallZigZagDeflectIndicator.id_ctor, Array.Empty<JValue>());
		}

		// Token: 0x040000AC RID: 172
		internal new static IntPtr java_class_handle;

		// Token: 0x040000AD RID: 173
		private static IntPtr id_ctor;
	}
}
