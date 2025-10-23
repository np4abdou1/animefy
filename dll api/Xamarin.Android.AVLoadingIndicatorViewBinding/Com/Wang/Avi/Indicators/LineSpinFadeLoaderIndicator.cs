using System;
using Android.Runtime;

namespace Com.Wang.Avi.Indicators
{
	// Token: 0x0200001F RID: 31
	[Register("com/wang/avi/indicators/LineSpinFadeLoaderIndicator", DoNotGenerateAcw = true)]
	public class LineSpinFadeLoaderIndicator : BallSpinFadeLoaderIndicator
	{
		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600015C RID: 348 RVA: 0x00007AD4 File Offset: 0x00005CD4
		internal new static IntPtr class_ref
		{
			get
			{
				return JNIEnv.FindClass("com/wang/avi/indicators/LineSpinFadeLoaderIndicator", ref LineSpinFadeLoaderIndicator.java_class_handle);
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00007AE5 File Offset: 0x00005CE5
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LineSpinFadeLoaderIndicator.class_ref;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600015E RID: 350 RVA: 0x00007AEC File Offset: 0x00005CEC
		protected override Type ThresholdType
		{
			get
			{
				return typeof(LineSpinFadeLoaderIndicator);
			}
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00007AF8 File Offset: 0x00005CF8
		protected LineSpinFadeLoaderIndicator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00007B04 File Offset: 0x00005D04
		[Register(".ctor", "()V", "")]
		public LineSpinFadeLoaderIndicator() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			if (base.GetType() != typeof(LineSpinFadeLoaderIndicator))
			{
				base.SetHandle(JNIEnv.StartCreateInstance(base.GetType(), "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				return;
			}
			if (LineSpinFadeLoaderIndicator.id_ctor == IntPtr.Zero)
			{
				LineSpinFadeLoaderIndicator.id_ctor = JNIEnv.GetMethodID(LineSpinFadeLoaderIndicator.class_ref, "<init>", "()V");
			}
			base.SetHandle(JNIEnv.StartCreateInstance(LineSpinFadeLoaderIndicator.class_ref, LineSpinFadeLoaderIndicator.id_ctor, Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance(base.Handle, LineSpinFadeLoaderIndicator.class_ref, LineSpinFadeLoaderIndicator.id_ctor, Array.Empty<JValue>());
		}

		// Token: 0x040000CC RID: 204
		internal new static IntPtr java_class_handle;

		// Token: 0x040000CD RID: 205
		private static IntPtr id_ctor;
	}
}
